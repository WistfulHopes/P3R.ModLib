using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAvfMediaSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool NativeAudioOut;
}

