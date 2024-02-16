using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UWmfMediaSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool AllowNonStandardCodecs;
    [FieldOffset(0x0029)] public bool LowLatency;
    [FieldOffset(0x002A)] public bool NativeAudioOut;
    [FieldOffset(0x002B)] public bool HardwareAcceleratedVideoDecoding;
}

