using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct ULightPropagationVolumeBlendable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FLightPropagationVolumeSettings Settings;
    [FieldOffset(0x0070)] public float BlendWeight;
}

