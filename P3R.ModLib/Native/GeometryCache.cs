using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UGeometryCache
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> Materials;
    [FieldOffset(0x0040)] public TArray<IntPtr> Tracks;
    [FieldOffset(0x0060)] public int StartFrame;
    [FieldOffset(0x0064)] public int EndFrame;
    [FieldOffset(0x0068)] public ulong hash;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AGeometryCacheActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UGeometryCacheComponent* GeometryCacheComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UGeometryCacheCodecBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<int> TopologyRanges;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGeometryCacheCodecRaw
{
    [FieldOffset(0x0000)] public UGeometryCacheCodecBase baseObj;
    [FieldOffset(0x0038)] public int DummyProperty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGeometryCacheCodecV1
{
    [FieldOffset(0x0000)] public UGeometryCacheCodecBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E0)] 
public unsafe struct UGeometryCacheComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public UGeometryCache* GeometryCache;
    [FieldOffset(0x0480)] public bool bRunning;
    [FieldOffset(0x0481)] public bool bLooping;
    [FieldOffset(0x0482)] public bool bExtrapolateFrames;
    [FieldOffset(0x0484)] public float StartTimeOffset;
    [FieldOffset(0x0488)] public float PlaybackSpeed;
    [FieldOffset(0x048C)] public float MotionVectorScale;
    [FieldOffset(0x0490)] public int NumTracks;
    [FieldOffset(0x0494)] public float ElapsedTime;
    [FieldOffset(0x04CC)] public float Duration;
    [FieldOffset(0x04D0)] public bool bManualTick;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGeometryCacheTrack
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float Duration;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FGeometryCacheMeshData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UDEPRECATED_GeometryCacheTrack_FlipbookAnimation
{
    [FieldOffset(0x0000)] public UGeometryCacheTrack baseObj;
    [FieldOffset(0x0058)] public uint NumMeshSamples;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UGeometryCacheTrackStreamable
{
    [FieldOffset(0x0000)] public UGeometryCacheTrack baseObj;
    [FieldOffset(0x0058)] public UGeometryCacheCodecBase* Codec;
    [FieldOffset(0x00C8)] public float StartSampleTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UDEPRECATED_GeometryCacheTrack_TransformAnimation
{
    [FieldOffset(0x0000)] public UGeometryCacheTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation
{
    [FieldOffset(0x0000)] public UGeometryCacheTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FTrackRenderData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGeometryCacheVertexInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FGeometryCacheMeshBatchInfo
{
}

