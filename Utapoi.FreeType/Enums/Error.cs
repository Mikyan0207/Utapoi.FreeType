﻿// Copyright (c) Utapoi Ltd <contact@utapoi.com>

namespace Utapoi.FreeType.Enums;

/// <summary>
/// FreeType error codes.
/// </summary>
public enum Error
{
    /// <summary>No error.</summary>
    Ok = 0x00,

    /// <summary>Cannot open resource.</summary>
    CannotOpenResource = 0x01,

    /// <summary>Unknown file format.</summary>
    UnknownFileFormat = 0x02,

    /// <summary>Broken file.</summary>
    InvalidFileFormat = 0x03,

    /// <summary>Invalid FreeType version.</summary>
    InvalidVersion = 0x04,

    /// <summary>Module version is too low.</summary>
    LowerModuleVersion = 0x05,

    /// <summary>Invalid argument.</summary>
    InvalidArgument = 0x06,

    /// <summary>Unimplemented feature.</summary>
    UnimplementedFeature = 0x07,

    /// <summary>Broken table.</summary>
    InvalidTable = 0x08,

    /// <summary>Broken offset within table.</summary>
    InvalidOffset = 0x09,

    /// <summary>Array allocation size too large.</summary>
    ArrayTooLarge = 0x0A,

    /// <summary>Invalid glyph index.</summary>
    InvalidGlyphIndex = 0x10,

    /// <summary>Invalid character code.</summary>
    InvalidCharacterCode = 0x11,

    /// <summary>Unsupported glyph image format.</summary>
    InvalidGlyphFormat = 0x12,

    /// <summary>Cannot render this glyph format.</summary>
    CannotRenderGlyph = 0x13,

    /// <summary>Invalid outline.</summary>
    InvalidOutline = 0x14,

    /// <summary>Invalid composite glyph.</summary>
    InvalidComposite = 0x15,

    /// <summary>Too many hints.</summary>
    TooManyHints = 0x16,

    /// <summary>Invalid pixel size.</summary>
    InvalidPixelSize = 0x17,

    /// <summary>Invalid object handle.</summary>
    InvalidHandle = 0x20,

    /// <summary>Invalid library handle.</summary>
    InvalidLibraryHandle = 0x21,

    /// <summary>Invalid module handle.</summary>
    InvalidDriverHandle = 0x22,

    /// <summary>Invalid face handle.</summary>
    InvalidFaceHandle = 0x23,

    /// <summary>Invalid size handle.</summary>
    InvalidSizeHandle = 0x24,

    /// <summary>Invalid glyph slot handle.</summary>
    InvalidSlotHandle = 0x25,

    /// <summary>Invalid charmap handle.</summary>
    InvalidCharMapHandle = 0x26,

    /// <summary>Invalid cache manager handle.</summary>
    InvalidCacheHandle = 0x27,

    /// <summary>Invalid stream handle.</summary>
    InvalidStreamHandle = 0x28,

    /// <summary>Too many modules.</summary>
    TooManyDrivers = 0x30,

    /// <summary>Too many extensions.</summary>
    TooManyExtensions = 0x31,

    /// <summary>Out of memory.</summary>
    OutOfMemory = 0x40,

    /// <summary>Unlisted object.</summary>
    UnlistedObject = 0x41,

    /// <summary>Cannot open stream.</summary>
    CannotOpenStream = 0x51,

    /// <summary>Invalid stream seek.</summary>
    InvalidStreamSeek = 0x52,

    /// <summary>Invalid stream skip.</summary>
    InvalidStreamSkip = 0x53,

    /// <summary>Invalid stream read.</summary>
    InvalidStreamRead = 0x54,

    /// <summary>Invalid stream operation.</summary>
    InvalidStreamOperation = 0x55,

    /// <summary>Invalid frame operation.</summary>
    InvalidFrameOperation = 0x56,

    /// <summary>Nested frame access.</summary>
    NestedFrameAccess = 0x57,

    /// <summary>Invalid frame read.</summary>
    InvalidFrameRead = 0x58,

    /// <summary>Raster uninitialized.</summary>
    RasterUninitialized = 0x60,

    /// <summary>Raster corrupted.</summary>
    RasterCorrupted = 0x61,

    /// <summary>Raster overflow.</summary>
    RasterOverflow = 0x62,

    /// <summary>Negative height while rastering.</summary>
    RasterNegativeHeight = 0x63,

    /// <summary>Too many registered caches.</summary>
    TooManyCaches = 0x70,

    /// <summary>Invalid opcode.</summary>
    InvalidOpCode = 0x80,

    /// <summary>Too few arguments.</summary>
    TooFewArguments = 0x81,

    /// <summary>Stack overflow.</summary>
    StackOverflow = 0x82,

    /// <summary>Code overflow.</summary>
    CodeOverflow = 0x83,

    /// <summary>Bad argument.</summary>
    BadArgument = 0x84,

    /// <summary>Division by zero.</summary>
    DivideByZero = 0x85,

    /// <summary>Invalid reference.</summary>
    InvalidReference = 0x86,

    /// <summary>Found debug opcode.</summary>
    DebugOpCode = 0x87,

    /// <summary>Found ENDF opcode in execution stream.</summary>
    EndfInExecStream = 0x88,

    /// <summary>Nested DEFS.</summary>
    NestedDefs = 0x89,

    /// <summary>Invalid code range.</summary>
    InvalidCodeRange = 0x8A,

    /// <summary>Execution context too long.</summary>
    ExecutionTooLong = 0x8B,

    /// <summary>Too many function definitions.</summary>
    TooManyFunctionDefs = 0x8C,

    /// <summary>Too many instruction definitions.</summary>
    TooManyInstructionDefs = 0x8D,

    /// <summary>SFNT font table missing.</summary>
    TableMissing = 0x8E,

    /// <summary>Horizontal header (hhea) table missing.</summary>
    HorizHeaderMissing = 0x8F,

    /// <summary>Locations (loca) table missing.</summary>
    LocationsMissing = 0x90,

    /// <summary>Name table missing.</summary>
    NameTableMissing = 0x91,

    /// <summary>Character map table missing.</summary>
    CharacterMapTableMissing = 0x92,

    /// <summary>Horizontal metrics table missing.</summary>
    HorizontalMetricsTableMissing = 0x93,

    /// <summary>PostScript (post) table missing.</summary>
    PostTableMissing = 0x94,

    /// <summary>Invalid horizontal metrics.</summary>
    InvalidHorizontalMetrics = 0x95,

    /// <summary>Invalid character map format.</summary>
    InvalidCharacterMapFormat = 0x96,

    /// <summary>Invalid ppem value.</summary>
    InvalidPPem = 0x97,

    /// <summary>Invalid vertical metrics.</summary>
    InvalidVerticalMetrics = 0x98,

    /// <summary>Could not find context.</summary>
    CouldNotFindContext = 0x99,

    /// <summary>Invalid PostScript (post) table format.</summary>
    InvalidPostTableFormat = 0x9A,

    /// <summary>Invalid PostScript (post) table.</summary>
    InvalidPostTable = 0x9B,

    /// <summary>Opcode syntax error.</summary>
    SyntaxError = 0xA0,

    /// <summary>Argument stack underflow.</summary>
    StackUnderflow = 0xA1,

    /// <summary>Ignore this error.</summary>
    Ignore = 0xA2,

    /// <summary>No Unicode glyph name found.</summary>
    NoUnicodeGlyphName = 0xA3,

    /// <summary>`STARTFONT' field missing.</summary>
    MissingStartFontField = 0xB0,

    /// <summary>`FONT' field missing.</summary>
    MissingFontField = 0xB1,

    /// <summary>`SIZE' field missing.</summary>
    MissingSizeField = 0xB2,

    /// <summary>`FONTBOUNDINGBOX' field missing.</summary>
    MissingFontBoundingBoxField = 0xB3,

    /// <summary>`CHARS' field missing.</summary>
    MissingCharsField = 0xB4,

    /// <summary>`STARTCHAR' field missing.</summary>
    MissingStartCharField = 0xB5,

    /// <summary>`ENCODING' field missing.</summary>
    MissingEncodingField = 0xB6,

    /// <summary>`BBX' field missing.</summary>
    MissingBbxField = 0xB7,

    /// <summary>`BBX' too big.</summary>
    BbxTooBig = 0xB8,

    /// <summary>Font header corrupted or missing fields.</summary>
    CorruptedFontHeader = 0xB9,

    /// <summary>Font glyphs corrupted or missing fields.</summary>
    CorruptedFontGlyphs = 0xBA
}
