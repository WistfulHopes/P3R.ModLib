using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x54)] 
public unsafe struct UPlayAtomCue_C
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public USoundAtomCue* Sound;
    [FieldOffset(0x0040)] public FName Bone;
    [FieldOffset(0x0048)] public bool follow;
    [FieldOffset(0x004C)] public float VolumeMultiplier;
    [FieldOffset(0x0050)] public float PitchMultiplier;
}

