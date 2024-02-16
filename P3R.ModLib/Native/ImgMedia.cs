using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UImgMediaSource
{
    [FieldOffset(0x0000)] public UBaseMediaSource baseObj;
    [FieldOffset(0x0088)] public bool IsPathRelativeToProjectRoot;
    [FieldOffset(0x008C)] public FFrameRate FrameRateOverride;
    [FieldOffset(0x0098)] public FString ProxyOverride;
    [FieldOffset(0x00A8)] public FDirectoryPath SequencePath;
}

