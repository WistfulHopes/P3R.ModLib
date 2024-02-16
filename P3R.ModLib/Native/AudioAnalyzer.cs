using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAudioAnalyzerAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAudioAnalyzerNRTSettings
{
    [FieldOffset(0x0000)] public UAudioAnalyzerAsset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAudioAnalyzerNRT
{
    [FieldOffset(0x0000)] public UAudioAnalyzerAsset baseObj;
    [FieldOffset(0x0028)] public USoundWave* Sound;
    [FieldOffset(0x0030)] public float DurationInSeconds;
}

