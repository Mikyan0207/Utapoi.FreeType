﻿// Copyright (c) Utapoi Ltd <contact@utapoi.com>

using System.Runtime.InteropServices;
using Utapoi.FreeType.Enums;
using Utapoi.FreeType.Exceptions;
using Utapoi.FreeType.Internal;

namespace Utapoi.FreeType.Fonts;

public sealed class Face : IDisposable
{
    private IntPtr Library { get; }

    private IntPtr Handle { get; set; }

    private bool IsDisposed { get; set; }

    private FTFace InternalFontFace { get; }

    private IList<Glyph> Glyphs { get; } = new List<Glyph>();

    public Face(IntPtr library, string path, int faceIndex)
    {
        var result = FreeTypeInvoke.FT_New_Face(library, path, faceIndex, out var handle);

        if (result != Error.Ok)
            throw new FreeTypeException($"Failed to load font {path}. Error: {result}");

        Library = library;
        Handle = handle;
        InternalFontFace = Marshal.PtrToStructure<FTFace>(Handle);
    }

    public Face(IntPtr library, string path) : this(library, path, 0)
    {
    }

    ~Face()
    {
        ReleaseUnmanagedResources();
    }

    #region Properties

    public long FaceCount
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(FaceCount), "Cannot access a disposed object.");

            return InternalFontFace.Count;
        }
    }

    public long FaceIndex
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(FaceIndex), "Cannot access a disposed object.");

            return InternalFontFace.Index;
        }
    }

    public string FamilyName
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(FamilyName), "Cannot access a disposed object.");

            return Marshal.PtrToStringAnsi(InternalFontFace.FamilyName) ?? string.Empty;
        }
    }


    public string StyleName
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(StyleName), "Cannot access a disposed object.");

            return Marshal.PtrToStringAnsi(InternalFontFace.StyleName) ?? string.Empty;
        }
    }

    public long GlyphCount
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(GlyphCount), "Cannot access a disposed object.");

            return InternalFontFace.GlyphCount;
        }
    }

    public GlyphSlot Glyph
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(Glyph), "Cannot access a disposed object.");

            return new GlyphSlot(InternalFontFace.Glyph, this);
        }
    }

    public Size Size
    {
        get
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(Size), "Cannot access a disposed object.");

            return new Size(InternalFontFace.Size, this);
        }
    }

    public long FontSize
    {
        get
        {
             if (IsDisposed)
                throw new ObjectDisposedException(nameof(FontSize), "Cannot access a disposed object.");

             return (Size.Ascender - Size.Descender);
        }
    }

    #endregion

    public uint GetCharIndex(char code)
    {
        return FreeTypeInvoke.FT_Get_Char_Index(Handle, code);
    }

    public void LoadGlyph(char code)
    {
        var result = FreeTypeInvoke.FT_Load_Glyph(Handle, GetCharIndex(code), (int)LoadFlags.Default);

        if (result != Error.Ok)
            throw new FreeTypeException($"Failed to load glyph {code}. Error: {result}");

        Glyphs.Add(new Glyph(InternalFontFace.Glyph, this));
    }

    #region Size Management

    public Face SetSize(float size)
    {
        return SetSize(size, 0, 0);
    }

    public Face SetSize(float size, uint horizontalResolution, uint verticalResolution)
    {
        if (IsDisposed)
            throw new ObjectDisposedException(nameof(Face), "Cannot access a disposed object.");

        var fractionalSize = (long)(size * 64);
        var result = FreeTypeInvoke.FT_Set_Char_Size(Handle, 0, fractionalSize, horizontalResolution, verticalResolution);

        if (result != Error.Ok)
            throw new FreeTypeException($"Failed to change the size of the font to {fractionalSize}. Error: {result}");

        return this;
    }

    #endregion

    public void Dispose()
    {
        if (IsDisposed)
            return;

        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
        IsDisposed = true;
    }

    private void ReleaseUnmanagedResources()
    {
        if (Handle == IntPtr.Zero)
            return;

        var result = FreeTypeInvoke.FT_Done_Face(Handle);

        if (result != Error.Ok)
            throw new FreeTypeException($"Failed to free Font. Error: {result}");

        Handle = IntPtr.Zero;
    }
}
