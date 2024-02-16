using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTmxAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UTexture* mpTex;
    [FieldOffset(0x0030)] public TArray<sbyte> mBuf;
}

