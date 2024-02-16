using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSynth1PatchCable
{
    [FieldOffset(0x0000)] public float Depth;
    [FieldOffset(0x0004)] public ESynth1PatchDestination Destination;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEpicSynth1Patch
{
    [FieldOffset(0x0000)] public ESynth1PatchSource PatchSource;
    [FieldOffset(0x0008)] public TArray<FSynth1PatchCable> PatchCables;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FModularSynthPreset
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte bEnablePolyphony;
    [FieldOffset(0x000C)] public ESynth1OscType Osc1Type;
    [FieldOffset(0x0010)] public float Osc1Gain;
    [FieldOffset(0x0014)] public float Osc1Octave;
    [FieldOffset(0x0018)] public float Osc1Semitones;
    [FieldOffset(0x001C)] public float Osc1Cents;
    [FieldOffset(0x0020)] public float Osc1PulseWidth;
    [FieldOffset(0x0024)] public ESynth1OscType Osc2Type;
    [FieldOffset(0x0028)] public float Osc2Gain;
    [FieldOffset(0x002C)] public float Osc2Octave;
    [FieldOffset(0x0030)] public float Osc2Semitones;
    [FieldOffset(0x0034)] public float Osc2Cents;
    [FieldOffset(0x0038)] public float Osc2PulseWidth;
    [FieldOffset(0x003C)] public float Portamento;
    [FieldOffset(0x0040)] public byte bEnableUnison;
    [FieldOffset(0x0040)] public byte bEnableOscillatorSync;
    [FieldOffset(0x0044)] public float Spread;
    [FieldOffset(0x0048)] public float Pan;
    [FieldOffset(0x004C)] public float LFO1Frequency;
    [FieldOffset(0x0050)] public float LFO1Gain;
    [FieldOffset(0x0054)] public ESynthLFOType LFO1Type;
    [FieldOffset(0x0055)] public ESynthLFOMode LFO1Mode;
    [FieldOffset(0x0056)] public ESynthLFOPatchType LFO1PatchType;
    [FieldOffset(0x0058)] public float LFO2Frequency;
    [FieldOffset(0x005C)] public float LFO2Gain;
    [FieldOffset(0x0060)] public ESynthLFOType LFO2Type;
    [FieldOffset(0x0061)] public ESynthLFOMode LFO2Mode;
    [FieldOffset(0x0062)] public ESynthLFOPatchType LFO2PatchType;
    [FieldOffset(0x0064)] public float GainDb;
    [FieldOffset(0x0068)] public float AttackTime;
    [FieldOffset(0x006C)] public float DecayTime;
    [FieldOffset(0x0070)] public float SustainGain;
    [FieldOffset(0x0074)] public float ReleaseTime;
    [FieldOffset(0x0078)] public ESynthModEnvPatch ModEnvPatchType;
    [FieldOffset(0x0079)] public ESynthModEnvBiasPatch ModEnvBiasPatchType;
    [FieldOffset(0x007C)] public byte bInvertModulationEnvelope;
    [FieldOffset(0x007C)] public byte bInvertModulationEnvelopeBias;
    [FieldOffset(0x0080)] public float ModulationEnvelopeDepth;
    [FieldOffset(0x0084)] public float ModulationEnvelopeAttackTime;
    [FieldOffset(0x0088)] public float ModulationEnvelopeDecayTime;
    [FieldOffset(0x008C)] public float ModulationEnvelopeSustainGain;
    [FieldOffset(0x0090)] public float ModulationEnvelopeReleaseTime;
    [FieldOffset(0x0094)] public byte bLegato;
    [FieldOffset(0x0094)] public byte bRetrigger;
    [FieldOffset(0x0098)] public float FilterFrequency;
    [FieldOffset(0x009C)] public float FilterQ;
    [FieldOffset(0x00A0)] public ESynthFilterType FilterType;
    [FieldOffset(0x00A1)] public ESynthFilterAlgorithm FilterAlgorithm;
    [FieldOffset(0x00A4)] public byte bStereoDelayEnabled;
    [FieldOffset(0x00A8)] public ESynthStereoDelayMode StereoDelayMode;
    [FieldOffset(0x00AC)] public float StereoDelayTime;
    [FieldOffset(0x00B0)] public float StereoDelayFeedback;
    [FieldOffset(0x00B4)] public float StereoDelayWetlevel;
    [FieldOffset(0x00B8)] public float StereoDelayRatio;
    [FieldOffset(0x00BC)] public byte bChorusEnabled;
    [FieldOffset(0x00C0)] public float ChorusDepth;
    [FieldOffset(0x00C4)] public float ChorusFeedback;
    [FieldOffset(0x00C8)] public float ChorusFrequency;
    [FieldOffset(0x00D0)] public TArray<FEpicSynth1Patch> Patches;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FModularSynthPresetBankEntry
{
    [FieldOffset(0x0000)] public FString PresetName;
    [FieldOffset(0x0010)] public FModularSynthPreset Preset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UModularSynthPresetBank
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FModularSynthPresetBankEntry> Presets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UModularSynthLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPatchId
{
    [FieldOffset(0x0000)] public int ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD80)] 
public unsafe struct UModularSynthComponent
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public int VoiceCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSourceEffectBitCrusherSettings
{
    [FieldOffset(0x0000)] public float CrushedSampleRate;
    [FieldOffset(0x0008)] public FSoundModulationDestinationSettings SampleRateModulation;
    [FieldOffset(0x0018)] public float CrushedBits;
    [FieldOffset(0x0020)] public FSoundModulationDestinationSettings BitModulation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSourceEffectBitCrusherBaseSettings
{
    [FieldOffset(0x0000)] public float SampleRate;
    [FieldOffset(0x0004)] public float BitDepth;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct USourceEffectBitCrusherPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00C0)] public FSourceEffectBitCrusherSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FSourceEffectChorusSettings
{
    [FieldOffset(0x0000)] public float Depth;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public float Feedback;
    [FieldOffset(0x000C)] public float WetLevel;
    [FieldOffset(0x0010)] public float DryLevel;
    [FieldOffset(0x0014)] public float Spread;
    [FieldOffset(0x0018)] public FSoundModulationDestinationSettings DepthModulation;
    [FieldOffset(0x0028)] public FSoundModulationDestinationSettings FrequencyModulation;
    [FieldOffset(0x0038)] public FSoundModulationDestinationSettings FeedbackModulation;
    [FieldOffset(0x0048)] public FSoundModulationDestinationSettings WetModulation;
    [FieldOffset(0x0058)] public FSoundModulationDestinationSettings DryModulation;
    [FieldOffset(0x0068)] public FSoundModulationDestinationSettings SpreadModulation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSourceEffectChorusBaseSettings
{
    [FieldOffset(0x0000)] public float Depth;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public float Feedback;
    [FieldOffset(0x000C)] public float WetLevel;
    [FieldOffset(0x0010)] public float DryLevel;
    [FieldOffset(0x0014)] public float Spread;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct USourceEffectChorusPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x0108)] public FSourceEffectChorusSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSourceEffectDynamicsProcessorSettings
{
    [FieldOffset(0x0000)] public ESourceEffectDynamicsProcessorType DynamicsProcessorType;
    [FieldOffset(0x0001)] public ESourceEffectDynamicsPeakMode PeakMode;
    [FieldOffset(0x0004)] public float LookAheadMsec;
    [FieldOffset(0x0008)] public float AttackTimeMsec;
    [FieldOffset(0x000C)] public float ReleaseTimeMsec;
    [FieldOffset(0x0010)] public float ThresholdDb;
    [FieldOffset(0x0014)] public float Ratio;
    [FieldOffset(0x0018)] public float KneeBandwidthDb;
    [FieldOffset(0x001C)] public float InputGainDb;
    [FieldOffset(0x0020)] public float OutputGainDb;
    [FieldOffset(0x0024)] public byte bStereoLinked;
    [FieldOffset(0x0024)] public byte bAnalogMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct USourceEffectDynamicsProcessorPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00B8)] public FSourceEffectDynamicsProcessorSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UEnvelopeFollowerListener
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSourceEffectEnvelopeFollowerSettings
{
    [FieldOffset(0x0000)] public float AttackTime;
    [FieldOffset(0x0004)] public float ReleaseTime;
    [FieldOffset(0x0008)] public EEnvelopeFollowerPeakMode PeakMode;
    [FieldOffset(0x0009)] public bool bIsAnalogMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct USourceEffectEnvelopeFollowerPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x009C)] public FSourceEffectEnvelopeFollowerSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSourceEffectEQBand
{
    [FieldOffset(0x0000)] public float Frequency;
    [FieldOffset(0x0004)] public float Bandwidth;
    [FieldOffset(0x0008)] public float GainDb;
    [FieldOffset(0x000C)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSourceEffectEQSettings
{
    [FieldOffset(0x0000)] public TArray<FSourceEffectEQBand> EQBands;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USourceEffectEQPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00A0)] public FSourceEffectEQSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSourceEffectFilterAudioBusModulationSettings
{
    [FieldOffset(0x0000)] public UAudioBus* AudioBus;
    [FieldOffset(0x0008)] public int EnvelopeFollowerAttackTimeMsec;
    [FieldOffset(0x000C)] public int EnvelopeFollowerReleaseTimeMsec;
    [FieldOffset(0x0010)] public float EnvelopeGainMultiplier;
    [FieldOffset(0x0014)] public ESourceEffectFilterParam FilterParam;
    [FieldOffset(0x0018)] public float MinFrequencyModulation;
    [FieldOffset(0x001C)] public float MaxFrequencyModulation;
    [FieldOffset(0x0020)] public float MinResonanceModulation;
    [FieldOffset(0x0024)] public float MaxResonanceModulation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSourceEffectFilterSettings
{
    [FieldOffset(0x0000)] public ESourceEffectFilterCircuit FilterCircuit;
    [FieldOffset(0x0001)] public ESourceEffectFilterType FilterType;
    [FieldOffset(0x0004)] public float CutoffFrequency;
    [FieldOffset(0x0008)] public float FilterQ;
    [FieldOffset(0x0010)] public TArray<FSourceEffectFilterAudioBusModulationSettings> AudioBusModulation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct USourceEffectFilterPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00B0)] public FSourceEffectFilterSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSourceEffectFoldbackDistortionSettings
{
    [FieldOffset(0x0000)] public float InputGainDb;
    [FieldOffset(0x0004)] public float ThresholdDb;
    [FieldOffset(0x0008)] public float OutputGainDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct USourceEffectFoldbackDistortionPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x009C)] public FSourceEffectFoldbackDistortionSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSourceEffectMidSideSpreaderSettings
{
    [FieldOffset(0x0000)] public float SpreadAmount;
    [FieldOffset(0x0004)] public EStereoChannelMode InputMode;
    [FieldOffset(0x0005)] public EStereoChannelMode OutputMode;
    [FieldOffset(0x0006)] public bool bEqualPower;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct USourceEffectMidSideSpreaderPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x0098)] public FSourceEffectMidSideSpreaderSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSourceEffectPannerSettings
{
    [FieldOffset(0x0000)] public float Spread;
    [FieldOffset(0x0004)] public float Pan;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct USourceEffectPannerPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x0098)] public FSourceEffectPannerSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSourceEffectPhaserSettings
{
    [FieldOffset(0x0000)] public float WetLevel;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public float Feedback;
    [FieldOffset(0x000C)] public EPhaserLFOType LFOType;
    [FieldOffset(0x000D)] public bool UseQuadraturePhase;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USourceEffectPhaserPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00A0)] public FSourceEffectPhaserSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSourceEffectRingModulationSettings
{
    [FieldOffset(0x0000)] public ERingModulatorTypeSourceEffect ModulatorType;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public float Depth;
    [FieldOffset(0x000C)] public float DryLevel;
    [FieldOffset(0x0010)] public float WetLevel;
    [FieldOffset(0x0018)] public UAudioBus* AudioBusModulator;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct USourceEffectRingModulationPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00B0)] public FSourceEffectRingModulationSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSourceEffectSimpleDelaySettings
{
    [FieldOffset(0x0000)] public float SpeedOfSound;
    [FieldOffset(0x0004)] public float DelayAmount;
    [FieldOffset(0x0008)] public float DryAmount;
    [FieldOffset(0x000C)] public float WetAmount;
    [FieldOffset(0x0010)] public float Feedback;
    [FieldOffset(0x0014)] public byte bDelayBasedOnDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct USourceEffectSimpleDelayPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00A8)] public FSourceEffectSimpleDelaySettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FSourceEffectStereoDelaySettings
{
    [FieldOffset(0x0000)] public EStereoDelaySourceEffect DelayMode;
    [FieldOffset(0x0004)] public float DelayTimeMsec;
    [FieldOffset(0x0008)] public float Feedback;
    [FieldOffset(0x000C)] public float DelayRatio;
    [FieldOffset(0x0010)] public float WetLevel;
    [FieldOffset(0x0014)] public float DryLevel;
    [FieldOffset(0x0018)] public bool bFilterEnabled;
    [FieldOffset(0x0019)] public EStereoDelayFiltertype FilterType;
    [FieldOffset(0x001C)] public float FilterFrequency;
    [FieldOffset(0x0020)] public float FilterQ;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct USourceEffectStereoDelayPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x00B4)] public FSourceEffectStereoDelaySettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSourceEffectWaveShaperSettings
{
    [FieldOffset(0x0000)] public float Amount;
    [FieldOffset(0x0004)] public float OutputGainDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct USourceEffectWaveShaperPreset
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset baseObj;
    [FieldOffset(0x0098)] public FSourceEffectWaveShaperSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAudioImpulseResponse
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<float> ImpulseResponse;
    [FieldOffset(0x0038)] public int NumChannels;
    [FieldOffset(0x003C)] public int SampleRate;
    [FieldOffset(0x0040)] public float NormalizationVolumeDb;
    [FieldOffset(0x0044)] public bool bTrueStereo;
    [FieldOffset(0x0048)] public TArray<float> IRData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSubmixEffectConvolutionReverbSettings
{
    [FieldOffset(0x0000)] public float NormalizationVolumeDb;
    [FieldOffset(0x0004)] public bool bBypass;
    [FieldOffset(0x0005)] public bool bMixInputChannelFormatToImpulseResponseFormat;
    [FieldOffset(0x0006)] public bool bMixReverbOutputToOutputChannelFormat;
    [FieldOffset(0x0008)] public float SurroundRearChannelBleedDb;
    [FieldOffset(0x000C)] public bool bInvertRearChannelBleedPhase;
    [FieldOffset(0x000D)] public bool bSurroundRearChannelFlip;
    [FieldOffset(0x0010)] public float SurroundRearChannelBleedAmount;
    [FieldOffset(0x0018)] public UAudioImpulseResponse* ImpulseResponse;
    [FieldOffset(0x0020)] public bool AllowHArdwareAcceleration;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct USubmixEffectConvolutionReverbPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x0068)] public UAudioImpulseResponse* ImpulseResponse;
    [FieldOffset(0x0070)] public FSubmixEffectConvolutionReverbSettings Settings;
    [FieldOffset(0x0098)] public ESubmixEffectConvolutionReverbBlockSize BlockSize;
    [FieldOffset(0x0099)] public bool bEnableHardwareAcceleration;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSubmixEffectDelaySettings
{
    [FieldOffset(0x0000)] public float MaximumDelayLength;
    [FieldOffset(0x0004)] public float InterpolationTime;
    [FieldOffset(0x0008)] public float DelayLength;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct USubmixEffectDelayPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x009C)] public FSubmixEffectDelaySettings Settings;
    [FieldOffset(0x00A8)] public FSubmixEffectDelaySettings DynamicSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSubmixEffectFilterSettings
{
    [FieldOffset(0x0000)] public ESubmixFilterType FilterType;
    [FieldOffset(0x0001)] public ESubmixFilterAlgorithm FilterAlgorithm;
    [FieldOffset(0x0004)] public float FilterFrequency;
    [FieldOffset(0x0008)] public float FilterQ;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct USubmixEffectFilterPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x009C)] public FSubmixEffectFilterSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSubmixEffectFlexiverbSettings
{
    [FieldOffset(0x0000)] public float PreDelay;
    [FieldOffset(0x0004)] public float DecayTime;
    [FieldOffset(0x0008)] public float RoomDampening;
    [FieldOffset(0x000C)] public int Complexity;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USubmixEffectFlexiverbPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00A0)] public FSubmixEffectFlexiverbSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDynamicsBandSettings
{
    [FieldOffset(0x0000)] public float CrossoverTopFrequency;
    [FieldOffset(0x0004)] public float AttackTimeMsec;
    [FieldOffset(0x0008)] public float ReleaseTimeMsec;
    [FieldOffset(0x000C)] public float ThresholdDb;
    [FieldOffset(0x0010)] public float Ratio;
    [FieldOffset(0x0014)] public float KneeBandwidthDb;
    [FieldOffset(0x0018)] public float InputGainDb;
    [FieldOffset(0x001C)] public float OutputGainDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSubmixEffectMultibandCompressorSettings
{
    [FieldOffset(0x0000)] public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
    [FieldOffset(0x0001)] public ESubmixEffectDynamicsPeakMode PeakMode;
    [FieldOffset(0x0004)] public float LookAheadMsec;
    [FieldOffset(0x0008)] public bool bLinkChannels;
    [FieldOffset(0x0009)] public bool bAnalogMode;
    [FieldOffset(0x000A)] public bool bFourPole;
    [FieldOffset(0x0010)] public TArray<FDynamicsBandSettings> Bands;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct USubmixEffectMultibandCompressorPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00B0)] public FSubmixEffectMultibandCompressorSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FSubmixEffectStereoDelaySettings
{
    [FieldOffset(0x0000)] public EStereoDelaySourceEffect DelayMode;
    [FieldOffset(0x0004)] public float DelayTimeMsec;
    [FieldOffset(0x0008)] public float Feedback;
    [FieldOffset(0x000C)] public float DelayRatio;
    [FieldOffset(0x0010)] public float WetLevel;
    [FieldOffset(0x0014)] public float DryLevel;
    [FieldOffset(0x0018)] public bool bFilterEnabled;
    [FieldOffset(0x0019)] public EStereoDelayFiltertype FilterType;
    [FieldOffset(0x001C)] public float FilterFrequency;
    [FieldOffset(0x0020)] public float FilterQ;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct USubmixEffectStereoDelayPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00B4)] public FSubmixEffectStereoDelaySettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTapDelayInfo
{
    [FieldOffset(0x0000)] public ETapLineMode TapLineMode;
    [FieldOffset(0x0004)] public float DelayLength;
    [FieldOffset(0x0008)] public float Gain;
    [FieldOffset(0x000C)] public int OutputChannel;
    [FieldOffset(0x0010)] public float PanInDegrees;
    [FieldOffset(0x0014)] public int TapId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSubmixEffectTapDelaySettings
{
    [FieldOffset(0x0000)] public float MaximumDelayLength;
    [FieldOffset(0x0004)] public float InterpolationTime;
    [FieldOffset(0x0008)] public TArray<FTapDelayInfo> Taps;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct USubmixEffectTapDelayPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00A8)] public FSubmixEffectTapDelaySettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct FSynth2DSliderStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush NormalThumbImage;
    [FieldOffset(0x0090)] public FSlateBrush DisabledThumbImage;
    [FieldOffset(0x0118)] public FSlateBrush NormalBarImage;
    [FieldOffset(0x01A0)] public FSlateBrush DisabledBarImage;
    [FieldOffset(0x0228)] public FSlateBrush BackgroundImage;
    [FieldOffset(0x02B0)] public float BarThickness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x478)] 
public unsafe struct USynth2DSlider
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public float ValueX;
    [FieldOffset(0x010C)] public float ValueY;
    [FieldOffset(0x0130)] public FSynth2DSliderStyle WidgetStyle;
    [FieldOffset(0x03E8)] public FLinearColor SliderHandleColor;
    [FieldOffset(0x03F8)] public bool IndentHandle;
    [FieldOffset(0x03F9)] public bool Locked;
    [FieldOffset(0x03FC)] public float StepSize;
    [FieldOffset(0x0400)] public bool IsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA80)] 
public unsafe struct UGranularSynth
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public USoundWave* GranulatedSoundWave;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMonoWaveTableSynthPreset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString PresetName;
    [FieldOffset(0x0038)] public byte bLockKeyframesToGridBool;
    [FieldOffset(0x003C)] public int LockKeyframesToGrid;
    [FieldOffset(0x0040)] public int WaveTableResolution;
    [FieldOffset(0x0048)] public TArray<FRuntimeFloatCurve> WaveTable;
    [FieldOffset(0x0058)] public byte bNormalizeWaveTables;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE00)] 
public unsafe struct USynthComponentMonoWaveTable
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06E0)] public UMonoWaveTableSynthPreset* CurrentPreset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6E0)] 
public unsafe struct USynthComponentToneGenerator
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public float Frequency;
    [FieldOffset(0x06C4)] public float Volume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7F0)] 
public unsafe struct USynthSamplePlayer
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public USoundWave* SoundWave;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USynthesisUtilitiesBlueprintFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct FSynthKnobStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush LargeKnob;
    [FieldOffset(0x0090)] public FSlateBrush LargeKnobOverlay;
    [FieldOffset(0x0118)] public FSlateBrush MediumKnob;
    [FieldOffset(0x01A0)] public FSlateBrush MediumKnobOverlay;
    [FieldOffset(0x0228)] public float MinValueAngle;
    [FieldOffset(0x022C)] public float MaxValueAngle;
    [FieldOffset(0x0230)] public ESynthKnobSize KnobSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x400)] 
public unsafe struct USynthKnob
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public float Value;
    [FieldOffset(0x010C)] public float StepSize;
    [FieldOffset(0x0110)] public float MouseSpeed;
    [FieldOffset(0x0114)] public float MouseFineTuneSpeed;
    [FieldOffset(0x0118)] public byte ShowTooltipInfo;
    [FieldOffset(0x0120)] public FText ParameterName;
    [FieldOffset(0x0138)] public FText ParameterUnits;
    [FieldOffset(0x0160)] public FSynthKnobStyle WidgetStyle;
    [FieldOffset(0x0398)] public bool Locked;
    [FieldOffset(0x0399)] public bool IsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSynthSlateStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public ESynthSlateSizeType SizeType;
    [FieldOffset(0x0009)] public ESynthSlateColorStyle ColorStyle;
}

