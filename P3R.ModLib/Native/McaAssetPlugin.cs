using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMcaCamData
{
    [FieldOffset(0x0000)] public float tx;
    [FieldOffset(0x0004)] public float ty;
    [FieldOffset(0x0008)] public float tz;
    [FieldOffset(0x000C)] public float rx;
    [FieldOffset(0x0010)] public float ry;
    [FieldOffset(0x0014)] public float rz;
    [FieldOffset(0x0018)] public float fovX;
    [FieldOffset(0x001C)] public float fovY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMcaData
{
    [FieldOffset(0x0000)] public uint frameSkip;
    [FieldOffset(0x0004)] public int frameNum;
    [FieldOffset(0x0008)] public int dataFormat;
    [FieldOffset(0x0010)] public TArray<FMcaCamData> pCamData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMcaAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FMcaData McaData;
}

