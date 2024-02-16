using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSprData
{
    [FieldOffset(0x0000)] public float Width;
    [FieldOffset(0x0004)] public float Height;
    [FieldOffset(0x0008)] public float U0;
    [FieldOffset(0x000C)] public float V0;
    [FieldOffset(0x0010)] public float U1;
    [FieldOffset(0x0014)] public float v1;
    [FieldOffset(0x0018)] public UTexture* Texture;
    [FieldOffset(0x0020)] public uint RGBA;
    [FieldOffset(0x0030)] public short StretchLen;
    [FieldOffset(0x0038)] public uint ScalingSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSprDataArray
{
    [FieldOffset(0x0000)] public TArray<FSprData> SprDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct USprAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> mTexArray;
    [FieldOffset(0x0038)] public TMap<uint, FSprDataArray> SprDatas;
}

