using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPlatformRuntimeAudioCompressionOverrides
{
    [FieldOffset(0x0000)] public bool bOverrideCompressionTimes;
    [FieldOffset(0x0004)] public float DurationThreshold;
    [FieldOffset(0x0008)] public int MaxNumRandomBranches;
    [FieldOffset(0x000C)] public int SoundCueQualityIndex;
}

