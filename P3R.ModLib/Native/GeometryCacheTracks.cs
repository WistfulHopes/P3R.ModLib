using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMovieSceneGeometryCacheParams
{
    [FieldOffset(0x0000)] public UGeometryCache* GeometryCacheAsset;
    [FieldOffset(0x0008)] public FFrameNumber FirstLoopStartFrameOffset;
    [FieldOffset(0x000C)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x0010)] public FFrameNumber EndFrameOffset;
    [FieldOffset(0x0014)] public float PlayRate;
    [FieldOffset(0x0018)] public byte bReverse;
    [FieldOffset(0x001C)] public float StartOffset;
    [FieldOffset(0x0020)] public float EndOffset;
    [FieldOffset(0x0028)] public FSoftObjectPath GeometryCache;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UMovieSceneGeometryCacheSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneGeometryCacheParams Params;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneGeometryCacheTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> AnimationSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneGeometryCacheSectionTemplateParameters
{
    [FieldOffset(0x0000)] public FMovieSceneGeometryCacheParams baseObj;
    [FieldOffset(0x0040)] public FFrameNumber SectionStartTime;
    [FieldOffset(0x0044)] public FFrameNumber SectionEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FMovieSceneGeometryCacheSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneGeometryCacheSectionTemplateParameters Params;
}

