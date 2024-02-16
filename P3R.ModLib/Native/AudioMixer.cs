using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x6C0)] 
public unsafe struct USynthComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public byte bAutoDestroy;
    [FieldOffset(0x01F8)] public byte bStopWhenOwnerDestroyed;
    [FieldOffset(0x01F8)] public byte bAllowSpatialization;
    [FieldOffset(0x01F8)] public byte bOverrideAttenuation;
    [FieldOffset(0x01FC)] public byte bEnableBusSends;
    [FieldOffset(0x01FC)] public byte bEnableBaseSubmix;
    [FieldOffset(0x01FC)] public byte bEnableSubmixSends;
    [FieldOffset(0x0200)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0208)] public FSoundAttenuationSettings AttenuationOverrides;
    [FieldOffset(0x05A8)] public USoundConcurrency* ConcurrencySettings;
    [FieldOffset(0x05B0)] public TSet<IntPtr> ConcurrencySet;
    [FieldOffset(0x0600)] public USoundClass* SoundClass;
    [FieldOffset(0x0608)] public USoundEffectSourcePresetChain* SourceEffectChain;
    [FieldOffset(0x0610)] public USoundSubmixBase* SoundSubmix;
    [FieldOffset(0x0618)] public TArray<FSoundSubmixSendInfo> SoundSubmixSends;
    [FieldOffset(0x0628)] public TArray<FSoundSourceBusSendInfo> BusSends;
    [FieldOffset(0x0638)] public TArray<FSoundSourceBusSendInfo> PreEffectBusSends;
    [FieldOffset(0x0648)] public byte bIsUISound;
    [FieldOffset(0x0648)] public byte bIsPreviewSound;
    [FieldOffset(0x064C)] public int EnvelopeFollowerAttackTime;
    [FieldOffset(0x0650)] public int EnvelopeFollowerReleaseTime;
    [FieldOffset(0x0688)] public USynthSound* Synth;
    [FieldOffset(0x0690)] public UAudioComponent* AudioComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UAudioGenerator
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAudioMixerBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UQuartzClockHandle
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0168)] public UQuartzSubsystem* QuartzSubsystem;
    [FieldOffset(0x0188)] public UWorld* WorldPtr;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSubmixEffectDynamicProcessorFilterSettings
{
    [FieldOffset(0x0000)] public byte bEnabled;
    [FieldOffset(0x0004)] public float Cutoff;
    [FieldOffset(0x0008)] public float GainDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FSubmixEffectDynamicsProcessorSettings
{
    [FieldOffset(0x0000)] public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
    [FieldOffset(0x0001)] public ESubmixEffectDynamicsPeakMode PeakMode;
    [FieldOffset(0x0002)] public ESubmixEffectDynamicsChannelLinkMode LinkMode;
    [FieldOffset(0x0004)] public float InputGainDb;
    [FieldOffset(0x0008)] public float ThresholdDb;
    [FieldOffset(0x000C)] public float Ratio;
    [FieldOffset(0x0010)] public float KneeBandwidthDb;
    [FieldOffset(0x0014)] public float LookAheadMsec;
    [FieldOffset(0x0018)] public float AttackTimeMsec;
    [FieldOffset(0x001C)] public float ReleaseTimeMsec;
    [FieldOffset(0x0020)] public ESubmixEffectDynamicsKeySource KeySource;
    [FieldOffset(0x0028)] public UAudioBus* ExternalAudioBus;
    [FieldOffset(0x0030)] public USoundSubmix* ExternalSubmix;
    [FieldOffset(0x0038)] public byte bChannelLinked;
    [FieldOffset(0x0038)] public byte bAnalogMode;
    [FieldOffset(0x0038)] public byte bBypass;
    [FieldOffset(0x0038)] public byte bKeyAudition;
    [FieldOffset(0x003C)] public float KeyGainDb;
    [FieldOffset(0x0040)] public float OutputGainDb;
    [FieldOffset(0x0044)] public FSubmixEffectDynamicProcessorFilterSettings KeyHighshelf;
    [FieldOffset(0x0050)] public FSubmixEffectDynamicProcessorFilterSettings KeyLowshelf;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct USubmixEffectDynamicsProcessorPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00F0)] public FSubmixEffectDynamicsProcessorSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSubmixEffectEQBand
{
    [FieldOffset(0x0000)] public float Frequency;
    [FieldOffset(0x0004)] public float Bandwidth;
    [FieldOffset(0x0008)] public float GainDb;
    [FieldOffset(0x000C)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSubmixEffectSubmixEQSettings
{
    [FieldOffset(0x0000)] public TArray<FSubmixEffectEQBand> EQBands;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USubmixEffectSubmixEQPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00A0)] public FSubmixEffectSubmixEQSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSubmixEffectReverbSettings
{
    [FieldOffset(0x0000)] public bool bBypassEarlyReflections;
    [FieldOffset(0x0004)] public float ReflectionsDelay;
    [FieldOffset(0x0008)] public float GainHF;
    [FieldOffset(0x000C)] public float ReflectionsGain;
    [FieldOffset(0x0010)] public bool bBypassLateReflections;
    [FieldOffset(0x0014)] public float LateDelay;
    [FieldOffset(0x0018)] public float DecayTime;
    [FieldOffset(0x001C)] public float Density;
    [FieldOffset(0x0020)] public float Diffusion;
    [FieldOffset(0x0024)] public float AirAbsorptionGainHF;
    [FieldOffset(0x0028)] public float DecayHFRatio;
    [FieldOffset(0x002C)] public float LateGain;
    [FieldOffset(0x0030)] public float Gain;
    [FieldOffset(0x0034)] public float WetLevel;
    [FieldOffset(0x0038)] public float DryLevel;
    [FieldOffset(0x003C)] public bool bBypass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct USubmixEffectReverbPreset
{
    [FieldOffset(0x0000)] public USoundEffectSubmixPreset baseObj;
    [FieldOffset(0x00D0)] public FSubmixEffectReverbSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UQuartzSubsystem
{
    [FieldOffset(0x0000)] public UTickableWorldSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E0)] 
public unsafe struct USynthSound
{
    [FieldOffset(0x0000)] public USoundWaveProcedural baseObj;
    [FieldOffset(0x03C0)] public USynthComponent* OwningSynthComponent;
}

