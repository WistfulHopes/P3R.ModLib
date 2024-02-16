using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneGeometryCollectionParams
{
    [FieldOffset(0x0008)] public FSoftObjectPath GeometryCollectionCache;
    [FieldOffset(0x0020)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x0024)] public FFrameNumber EndFrameOffset;
    [FieldOffset(0x0028)] public float PlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UMovieSceneGeometryCollectionSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneGeometryCollectionParams Params;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneGeometryCollectionTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> AnimationSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneGeometryCollectionSectionTemplateParameters
{
    [FieldOffset(0x0000)] public FMovieSceneGeometryCollectionParams baseObj;
    [FieldOffset(0x0030)] public FFrameNumber SectionStartTime;
    [FieldOffset(0x0034)] public FFrameNumber SectionEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FMovieSceneGeometryCollectionSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneGeometryCollectionSectionTemplateParameters Params;
}

