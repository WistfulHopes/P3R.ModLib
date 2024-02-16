using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAudioSynesthesiaNRTSettings
{
    [FieldOffset(0x0000)] public UAudioAnalyzerNRTSettings baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAudioSynesthesiaNRT
{
    [FieldOffset(0x0000)] public UAudioAnalyzerNRT baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UConstantQNRTSettings
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRTSettings baseObj;
    [FieldOffset(0x0028)] public float StartingFrequency;
    [FieldOffset(0x002C)] public int NumBands;
    [FieldOffset(0x0030)] public float NumBandsPerOctave;
    [FieldOffset(0x0034)] public float AnalysisPeriod;
    [FieldOffset(0x0038)] public bool bDownmixToMono;
    [FieldOffset(0x0039)] public EConstantQFFTSizeEnum FFTSize;
    [FieldOffset(0x003A)] public EFFTWindowType WindowType;
    [FieldOffset(0x003B)] public EAudioSpectrumType SpectrumType;
    [FieldOffset(0x003C)] public float BandWidthStretch;
    [FieldOffset(0x0040)] public EConstantQNormalizationEnum CQTNormalization;
    [FieldOffset(0x0044)] public float NoiseFloorDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UConstantQNRT
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRT baseObj;
    [FieldOffset(0x0078)] public UConstantQNRTSettings* Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct ULoudnessNRTSettings
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRTSettings baseObj;
    [FieldOffset(0x0028)] public float AnalysisPeriod;
    [FieldOffset(0x002C)] public float MinimumFrequency;
    [FieldOffset(0x0030)] public float MaximumFrequency;
    [FieldOffset(0x0034)] public ELoudnessNRTCurveTypeEnum CurveType;
    [FieldOffset(0x0038)] public float NoiseFloorDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct ULoudnessNRT
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRT baseObj;
    [FieldOffset(0x0078)] public ULoudnessNRTSettings* Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UOnsetNRTSettings
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRTSettings baseObj;
    [FieldOffset(0x0028)] public bool bDownmixToMono;
    [FieldOffset(0x002C)] public float GranularityInSeconds;
    [FieldOffset(0x0030)] public float Sensitivity;
    [FieldOffset(0x0034)] public float MinimumFrequency;
    [FieldOffset(0x0038)] public float MaximumFrequency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UOnsetNRT
{
    [FieldOffset(0x0000)] public UAudioSynesthesiaNRT baseObj;
    [FieldOffset(0x0078)] public UOnsetNRTSettings* Settings;
}

