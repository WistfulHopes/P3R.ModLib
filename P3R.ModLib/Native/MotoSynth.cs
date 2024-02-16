using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FMotoSynthRuntimeSettings
{
    [FieldOffset(0x0000)] public bool bSynthToneEnabled;
    [FieldOffset(0x0004)] public float SynthToneVolume;
    [FieldOffset(0x0008)] public float SynthToneFilterFrequency;
    [FieldOffset(0x000C)] public int SynthOctaveShift;
    [FieldOffset(0x0010)] public bool bGranularEngineEnabled;
    [FieldOffset(0x0014)] public float GranularEngineVolume;
    [FieldOffset(0x0018)] public float GranularEnginePitchScale;
    [FieldOffset(0x001C)] public int NumSamplesToCrossfadeBetweenGrains;
    [FieldOffset(0x0020)] public int NumGrainTableEntriesPerGrain;
    [FieldOffset(0x0024)] public int GrainTableRandomOffsetForConstantRPMs;
    [FieldOffset(0x0028)] public int GrainCrossfadeSamplesForConstantRPMs;
    [FieldOffset(0x0030)] public UMotoSynthSource* AccelerationSource;
    [FieldOffset(0x0038)] public UMotoSynthSource* DecelerationSource;
    [FieldOffset(0x0040)] public bool bStereoWidenerEnabled;
    [FieldOffset(0x0044)] public float StereoDelayMsec;
    [FieldOffset(0x0048)] public float StereoFeedback;
    [FieldOffset(0x004C)] public float StereoWidenerWetlevel;
    [FieldOffset(0x0050)] public float StereoWidenerDryLevel;
    [FieldOffset(0x0054)] public float StereoWidenerDelayRatio;
    [FieldOffset(0x0058)] public bool bStereoWidenerFilterEnabled;
    [FieldOffset(0x005C)] public float StereoWidenerFilterFrequency;
    [FieldOffset(0x0060)] public float StereoWidenerFilterQ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMotoSynthPreset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FMotoSynthRuntimeSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGrainTableEntry
{
    [FieldOffset(0x0000)] public int SampleIndex;
    [FieldOffset(0x0004)] public float RPM;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UMotoSynthSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bConvertTo8Bit;
    [FieldOffset(0x002C)] public float DownSampleFactor;
    [FieldOffset(0x0030)] public FRuntimeFloatCurve RPMCurve;
    [FieldOffset(0x00B8)] public TArray<float> SourceData;
    [FieldOffset(0x00C8)] public TArray<short> SourceDataPCM;
    [FieldOffset(0x00D8)] public int SourceSampleRate;
    [FieldOffset(0x00E0)] public TArray<FGrainTableEntry> GrainTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x780)] 
public unsafe struct USynthComponentMoto
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public UMotoSynthPreset* MotoSynthPreset;
    [FieldOffset(0x06C8)] public float RPM;
}

