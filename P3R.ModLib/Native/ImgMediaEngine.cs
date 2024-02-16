using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UImgMediaPlaybackComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float Width;
    [FieldOffset(0x00B4)] public float LODBias;
}

