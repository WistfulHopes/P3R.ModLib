using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ModularSynthPresetBank : ObjectBase<UModularSynthPresetBank>
{
    public ModularSynthPresetBank(IntPtr pointer) : base(pointer) {}
}

public unsafe class SourceEffectWaveShaperPreset : ObjectBase<USourceEffectWaveShaperPreset>
{
    public SourceEffectWaveShaperPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectWaveShaperSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class AudioImpulseResponse : ObjectBase<UAudioImpulseResponse>
{
    public AudioImpulseResponse(IntPtr pointer) : base(pointer) {}
}

public unsafe class ModularSynthLibrary : ObjectBase<UModularSynthLibrary>
{
    public ModularSynthLibrary(IntPtr pointer) : base(pointer) {}
    public void AddModularSynthPresetToBankAsset(UModularSynthPresetBank* InBank, ref FModularSynthPreset Preset, FString PresetName)
    {
        Span<(string name, object value)> @params = [
            ("InBank", (IntPtr)InBank), 
            ("Preset", Preset), 
            ("PresetName", PresetName)
        ];
        ProcessEvent(GetFunction("AddModularSynthPresetToBankAsset"), @params);
    }
}

public unsafe class SubmixEffectConvolutionReverbPreset : ObjectBase<USubmixEffectConvolutionReverbPreset>
{
    public SubmixEffectConvolutionReverbPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectConvolutionReverbSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetImpulseResponse(UAudioImpulseResponse* InImpulseResponse)
    {
        Span<(string name, object value)> @params = [
            ("InImpulseResponse", (IntPtr)InImpulseResponse)
        ];
        ProcessEvent(GetFunction("SetImpulseResponse"), @params);
    }
}

public unsafe class ModularSynthComponent : ObjectBase<UModularSynthComponent>
{
    public ModularSynthComponent(IntPtr pointer) : base(pointer) {}
    public void SetSynthPreset(ref FModularSynthPreset SynthPreset)
    {
        Span<(string name, object value)> @params = [
            ("SynthPreset", SynthPreset)
        ];
        ProcessEvent(GetFunction("SetSynthPreset"), @params);
    }
    public void SetSustainGain(float SustainGain)
    {
        Span<(string name, object value)> @params = [
            ("SustainGain", SustainGain)
        ];
        ProcessEvent(GetFunction("SetSustainGain"), @params);
    }
    public void SetStereoDelayWetlevel(float DelayWetlevel)
    {
        Span<(string name, object value)> @params = [
            ("DelayWetlevel", DelayWetlevel)
        ];
        ProcessEvent(GetFunction("SetStereoDelayWetlevel"), @params);
    }
    public void SetStereoDelayTime(float DelayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("DelayTimeMsec", DelayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetStereoDelayTime"), @params);
    }
    public void SetStereoDelayRatio(float DelayRatio)
    {
        Span<(string name, object value)> @params = [
            ("DelayRatio", DelayRatio)
        ];
        ProcessEvent(GetFunction("SetStereoDelayRatio"), @params);
    }
    public void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode)
    {
        Span<(string name, object value)> @params = [
            ("StereoDelayMode", StereoDelayMode)
        ];
        ProcessEvent(GetFunction("SetStereoDelayMode"), @params);
    }
    public void SetStereoDelayIsEnabled(bool StereoDelayEnabled)
    {
        Span<(string name, object value)> @params = [
            ("StereoDelayEnabled", StereoDelayEnabled)
        ];
        ProcessEvent(GetFunction("SetStereoDelayIsEnabled"), @params);
    }
    public void SetStereoDelayFeedback(float DelayFeedback)
    {
        Span<(string name, object value)> @params = [
            ("DelayFeedback", DelayFeedback)
        ];
        ProcessEvent(GetFunction("SetStereoDelayFeedback"), @params);
    }
    public void SetSpread(float Spread)
    {
        Span<(string name, object value)> @params = [
            ("Spread", Spread)
        ];
        ProcessEvent(GetFunction("SetSpread"), @params);
    }
    public void SetReleaseTime(float ReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("ReleaseTimeMsec", ReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetReleaseTime"), @params);
    }
    public void SetPortamento(float Portamento)
    {
        Span<(string name, object value)> @params = [
            ("Portamento", Portamento)
        ];
        ProcessEvent(GetFunction("SetPortamento"), @params);
    }
    public void SetPitchBend(float PitchBend)
    {
        Span<(string name, object value)> @params = [
            ("PitchBend", PitchBend)
        ];
        ProcessEvent(GetFunction("SetPitchBend"), @params);
    }
    public void SetPan(float Pan)
    {
        Span<(string name, object value)> @params = [
            ("Pan", Pan)
        ];
        ProcessEvent(GetFunction("SetPan"), @params);
    }
    public void SetOscType(int OscIndex, ESynth1OscType OscType)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("OscType", OscType)
        ];
        ProcessEvent(GetFunction("SetOscType"), @params);
    }
    public void SetOscSync(bool bIsSynced)
    {
        Span<(string name, object value)> @params = [
            ("bIsSynced", bIsSynced)
        ];
        ProcessEvent(GetFunction("SetOscSync"), @params);
    }
    public void SetOscSemitones(int OscIndex, float Semitones)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("Semitones", Semitones)
        ];
        ProcessEvent(GetFunction("SetOscSemitones"), @params);
    }
    public void SetOscPulsewidth(int OscIndex, float Pulsewidth)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("Pulsewidth", Pulsewidth)
        ];
        ProcessEvent(GetFunction("SetOscPulsewidth"), @params);
    }
    public void SetOscOctave(int OscIndex, float Octave)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("Octave", Octave)
        ];
        ProcessEvent(GetFunction("SetOscOctave"), @params);
    }
    public void SetOscGainMod(int OscIndex, float OscGainMod)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("OscGainMod", OscGainMod)
        ];
        ProcessEvent(GetFunction("SetOscGainMod"), @params);
    }
    public void SetOscGain(int OscIndex, float OscGain)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("OscGain", OscGain)
        ];
        ProcessEvent(GetFunction("SetOscGain"), @params);
    }
    public void SetOscFrequencyMod(int OscIndex, float OscFreqMod)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("OscFreqMod", OscFreqMod)
        ];
        ProcessEvent(GetFunction("SetOscFrequencyMod"), @params);
    }
    public void SetOscCents(int OscIndex, float Cents)
    {
        Span<(string name, object value)> @params = [
            ("OscIndex", OscIndex), 
            ("Cents", Cents)
        ];
        ProcessEvent(GetFunction("SetOscCents"), @params);
    }
    public void SetModEnvSustainGain(float SustainGain)
    {
        Span<(string name, object value)> @params = [
            ("SustainGain", SustainGain)
        ];
        ProcessEvent(GetFunction("SetModEnvSustainGain"), @params);
    }
    public void SetModEnvReleaseTime(float Release)
    {
        Span<(string name, object value)> @params = [
            ("Release", Release)
        ];
        ProcessEvent(GetFunction("SetModEnvReleaseTime"), @params);
    }
    public void SetModEnvPatch(ESynthModEnvPatch InPatchType)
    {
        Span<(string name, object value)> @params = [
            ("InPatchType", InPatchType)
        ];
        ProcessEvent(GetFunction("SetModEnvPatch"), @params);
    }
    public void SetModEnvInvert(bool bInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInvert", bInvert)
        ];
        ProcessEvent(GetFunction("SetModEnvInvert"), @params);
    }
    public void SetModEnvDepth(float Depth)
    {
        Span<(string name, object value)> @params = [
            ("Depth", Depth)
        ];
        ProcessEvent(GetFunction("SetModEnvDepth"), @params);
    }
    public void SetModEnvDecayTime(float DecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("DecayTimeMsec", DecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetModEnvDecayTime"), @params);
    }
    public void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType)
    {
        Span<(string name, object value)> @params = [
            ("InPatchType", InPatchType)
        ];
        ProcessEvent(GetFunction("SetModEnvBiasPatch"), @params);
    }
    public void SetModEnvBiasInvert(bool bInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInvert", bInvert)
        ];
        ProcessEvent(GetFunction("SetModEnvBiasInvert"), @params);
    }
    public void SetModEnvAttackTime(float AttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("AttackTimeMsec", AttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetModEnvAttackTime"), @params);
    }
    public void SetLFOType(int LFOIndex, ESynthLFOType LFOType)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("LFOType", LFOType)
        ];
        ProcessEvent(GetFunction("SetLFOType"), @params);
    }
    public void SetLFOPatch(int LFOIndex, ESynthLFOPatchType LFOPatchType)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("LFOPatchType", LFOPatchType)
        ];
        ProcessEvent(GetFunction("SetLFOPatch"), @params);
    }
    public void SetLFOMode(int LFOIndex, ESynthLFOMode LFOMode)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("LFOMode", LFOMode)
        ];
        ProcessEvent(GetFunction("SetLFOMode"), @params);
    }
    public void SetLFOGainMod(int LFOIndex, float GainMod)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("GainMod", GainMod)
        ];
        ProcessEvent(GetFunction("SetLFOGainMod"), @params);
    }
    public void SetLFOGain(int LFOIndex, float Gain)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("Gain", Gain)
        ];
        ProcessEvent(GetFunction("SetLFOGain"), @params);
    }
    public void SetLFOFrequencyMod(int LFOIndex, float FrequencyModHz)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("FrequencyModHz", FrequencyModHz)
        ];
        ProcessEvent(GetFunction("SetLFOFrequencyMod"), @params);
    }
    public void SetLFOFrequency(int LFOIndex, float FrequencyHz)
    {
        Span<(string name, object value)> @params = [
            ("LFOIndex", LFOIndex), 
            ("FrequencyHz", FrequencyHz)
        ];
        ProcessEvent(GetFunction("SetLFOFrequency"), @params);
    }
    public void SetGainDb(float GainDb)
    {
        Span<(string name, object value)> @params = [
            ("GainDb", GainDb)
        ];
        ProcessEvent(GetFunction("SetGainDb"), @params);
    }
    public void SetFilterType(ESynthFilterType FilterType)
    {
        Span<(string name, object value)> @params = [
            ("FilterType", FilterType)
        ];
        ProcessEvent(GetFunction("SetFilterType"), @params);
    }
    public void SetFilterQMod(float FilterQ)
    {
        Span<(string name, object value)> @params = [
            ("FilterQ", FilterQ)
        ];
        ProcessEvent(GetFunction("SetFilterQMod"), @params);
    }
    public void SetFilterQ(float FilterQ)
    {
        Span<(string name, object value)> @params = [
            ("FilterQ", FilterQ)
        ];
        ProcessEvent(GetFunction("SetFilterQ"), @params);
    }
    public void SetFilterFrequencyMod(float FilterFrequencyHz)
    {
        Span<(string name, object value)> @params = [
            ("FilterFrequencyHz", FilterFrequencyHz)
        ];
        ProcessEvent(GetFunction("SetFilterFrequencyMod"), @params);
    }
    public void SetFilterFrequency(float FilterFrequencyHz)
    {
        Span<(string name, object value)> @params = [
            ("FilterFrequencyHz", FilterFrequencyHz)
        ];
        ProcessEvent(GetFunction("SetFilterFrequency"), @params);
    }
    public void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm)
    {
        Span<(string name, object value)> @params = [
            ("FilterAlgorithm", FilterAlgorithm)
        ];
        ProcessEvent(GetFunction("SetFilterAlgorithm"), @params);
    }
    public void SetEnableUnison(bool EnableUnison)
    {
        Span<(string name, object value)> @params = [
            ("EnableUnison", EnableUnison)
        ];
        ProcessEvent(GetFunction("SetEnableUnison"), @params);
    }
    public void SetEnableRetrigger(bool RetriggerEnabled)
    {
        Span<(string name, object value)> @params = [
            ("RetriggerEnabled", RetriggerEnabled)
        ];
        ProcessEvent(GetFunction("SetEnableRetrigger"), @params);
    }
    public void SetEnablePolyphony(bool bEnablePolyphony)
    {
        Span<(string name, object value)> @params = [
            ("bEnablePolyphony", bEnablePolyphony)
        ];
        ProcessEvent(GetFunction("SetEnablePolyphony"), @params);
    }
    public bool SetEnablePatch(FPatchId PatchId, bool bIsEnabled)
    {
        Span<(string name, object value)> @params = [
            ("PatchId", PatchId), 
            ("bIsEnabled", bIsEnabled)
        ];
        return ProcessEvent<bool>(GetFunction("SetEnablePatch"), @params);
    }
    public void SetEnableLegato(bool LegatoEnabled)
    {
        Span<(string name, object value)> @params = [
            ("LegatoEnabled", LegatoEnabled)
        ];
        ProcessEvent(GetFunction("SetEnableLegato"), @params);
    }
    public void SetDecayTime(float DecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("DecayTimeMsec", DecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetDecayTime"), @params);
    }
    public void SetChorusFrequency(float Frequency)
    {
        Span<(string name, object value)> @params = [
            ("Frequency", Frequency)
        ];
        ProcessEvent(GetFunction("SetChorusFrequency"), @params);
    }
    public void SetChorusFeedback(float Feedback)
    {
        Span<(string name, object value)> @params = [
            ("Feedback", Feedback)
        ];
        ProcessEvent(GetFunction("SetChorusFeedback"), @params);
    }
    public void SetChorusEnabled(bool EnableChorus)
    {
        Span<(string name, object value)> @params = [
            ("EnableChorus", EnableChorus)
        ];
        ProcessEvent(GetFunction("SetChorusEnabled"), @params);
    }
    public void SetChorusDepth(float Depth)
    {
        Span<(string name, object value)> @params = [
            ("Depth", Depth)
        ];
        ProcessEvent(GetFunction("SetChorusDepth"), @params);
    }
    public void SetAttackTime(float AttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("AttackTimeMsec", AttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetAttackTime"), @params);
    }
    public void NoteOn(float Note, int Velocity, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("Note", Note), 
            ("Velocity", Velocity), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("NoteOn"), @params);
    }
    public void NoteOff(float Note, bool bAllNotesOff, bool bKillAllNotes)
    {
        Span<(string name, object value)> @params = [
            ("Note", Note), 
            ("bAllNotesOff", bAllNotesOff), 
            ("bKillAllNotes", bKillAllNotes)
        ];
        ProcessEvent(GetFunction("NoteOff"), @params);
    }
    public FPatchId CreatePatch(ESynth1PatchSource PatchSource, ref TArray<FSynth1PatchCable> PatchCables, bool bEnableByDefault)
    {
        Span<(string name, object value)> @params = [
            ("PatchSource", PatchSource), 
            ("PatchCables", PatchCables), 
            ("bEnableByDefault", bEnableByDefault)
        ];
        return ProcessEvent<FPatchId>(GetFunction("CreatePatch"), @params);
    }
}

public unsafe class SubmixEffectDelayPreset : ObjectBase<USubmixEffectDelayPreset>
{
    public SubmixEffectDelayPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectDelaySettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetInterpolationTime(float Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("SetInterpolationTime"), @params);
    }
    public void SetDelay(float Length)
    {
        Span<(string name, object value)> @params = [
            ("Length", Length)
        ];
        ProcessEvent(GetFunction("SetDelay"), @params);
    }
    public float GetMaxDelayInMilliseconds()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxDelayInMilliseconds"), @params);
    }
}

public unsafe class SourceEffectStereoDelayPreset : ObjectBase<USourceEffectStereoDelayPreset>
{
    public SourceEffectStereoDelayPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectStereoDelaySettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SubmixEffectFilterPreset : ObjectBase<USubmixEffectFilterPreset>
{
    public SubmixEffectFilterPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectFilterSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetFilterType(ESubmixFilterType InType)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType)
        ];
        ProcessEvent(GetFunction("SetFilterType"), @params);
    }
    public void SetFilterQMod(float InQ)
    {
        Span<(string name, object value)> @params = [
            ("InQ", InQ)
        ];
        ProcessEvent(GetFunction("SetFilterQMod"), @params);
    }
    public void SetFilterQ(float InQ)
    {
        Span<(string name, object value)> @params = [
            ("InQ", InQ)
        ];
        ProcessEvent(GetFunction("SetFilterQ"), @params);
    }
    public void SetFilterCutoffFrequencyMod(float InFrequency)
    {
        Span<(string name, object value)> @params = [
            ("InFrequency", InFrequency)
        ];
        ProcessEvent(GetFunction("SetFilterCutoffFrequencyMod"), @params);
    }
    public void SetFilterCutoffFrequency(float InFrequency)
    {
        Span<(string name, object value)> @params = [
            ("InFrequency", InFrequency)
        ];
        ProcessEvent(GetFunction("SetFilterCutoffFrequency"), @params);
    }
    public void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm)
    {
        Span<(string name, object value)> @params = [
            ("InAlgorithm", InAlgorithm)
        ];
        ProcessEvent(GetFunction("SetFilterAlgorithm"), @params);
    }
}

public unsafe class SourceEffectBitCrusherPreset : ObjectBase<USourceEffectBitCrusherPreset>
{
    public SourceEffectBitCrusherPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectBitCrusherBaseSettings Settings)
    {
        Span<(string name, object value)> @params = [
            ("Settings", Settings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetSampleRateModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetSampleRateModulator"), @params);
    }
    public void SetSampleRate(float SampleRate)
    {
        Span<(string name, object value)> @params = [
            ("SampleRate", SampleRate)
        ];
        ProcessEvent(GetFunction("SetSampleRate"), @params);
    }
    public void SetModulationSettings(ref FSourceEffectBitCrusherSettings ModulationSettings)
    {
        Span<(string name, object value)> @params = [
            ("ModulationSettings", ModulationSettings)
        ];
        ProcessEvent(GetFunction("SetModulationSettings"), @params);
    }
    public void SetBits(float Bits)
    {
        Span<(string name, object value)> @params = [
            ("Bits", Bits)
        ];
        ProcessEvent(GetFunction("SetBits"), @params);
    }
    public void SetBitModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetBitModulator"), @params);
    }
}

public unsafe class SubmixEffectFlexiverbPreset : ObjectBase<USubmixEffectFlexiverbPreset>
{
    public SubmixEffectFlexiverbPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectFlexiverbSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectChorusPreset : ObjectBase<USourceEffectChorusPreset>
{
    public SourceEffectChorusPreset(IntPtr pointer) : base(pointer) {}
    public void SetWetModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetWetModulator"), @params);
    }
    public void SetWet(float WetAmount)
    {
        Span<(string name, object value)> @params = [
            ("WetAmount", WetAmount)
        ];
        ProcessEvent(GetFunction("SetWet"), @params);
    }
    public void SetSpreadModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetSpreadModulator"), @params);
    }
    public void SetSpread(float Spread)
    {
        Span<(string name, object value)> @params = [
            ("Spread", Spread)
        ];
        ProcessEvent(GetFunction("SetSpread"), @params);
    }
    public void SetSettings(ref FSourceEffectChorusBaseSettings Settings)
    {
        Span<(string name, object value)> @params = [
            ("Settings", Settings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetModulationSettings(ref FSourceEffectChorusSettings ModulationSettings)
    {
        Span<(string name, object value)> @params = [
            ("ModulationSettings", ModulationSettings)
        ];
        ProcessEvent(GetFunction("SetModulationSettings"), @params);
    }
    public void SetFrequencyModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetFrequencyModulator"), @params);
    }
    public void SetFrequency(float Frequency)
    {
        Span<(string name, object value)> @params = [
            ("Frequency", Frequency)
        ];
        ProcessEvent(GetFunction("SetFrequency"), @params);
    }
    public void SetFeedbackModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetFeedbackModulator"), @params);
    }
    public void SetFeedback(float Feedback)
    {
        Span<(string name, object value)> @params = [
            ("Feedback", Feedback)
        ];
        ProcessEvent(GetFunction("SetFeedback"), @params);
    }
    public void SetDryModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetDryModulator"), @params);
    }
    public void SetDry(float DryAmount)
    {
        Span<(string name, object value)> @params = [
            ("DryAmount", DryAmount)
        ];
        ProcessEvent(GetFunction("SetDry"), @params);
    }
    public void SetDepthModulator(USoundModulatorBase* Modulator)
    {
        Span<(string name, object value)> @params = [
            ("Modulator", (IntPtr)Modulator)
        ];
        ProcessEvent(GetFunction("SetDepthModulator"), @params);
    }
    public void SetDepth(float Depth)
    {
        Span<(string name, object value)> @params = [
            ("Depth", Depth)
        ];
        ProcessEvent(GetFunction("SetDepth"), @params);
    }
}

public unsafe class SubmixEffectMultibandCompressorPreset : ObjectBase<USubmixEffectMultibandCompressorPreset>
{
    public SubmixEffectMultibandCompressorPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectMultibandCompressorSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectDynamicsProcessorPreset : ObjectBase<USourceEffectDynamicsProcessorPreset>
{
    public SourceEffectDynamicsProcessorPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectDynamicsProcessorSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SubmixEffectStereoDelayPreset : ObjectBase<USubmixEffectStereoDelayPreset>
{
    public SubmixEffectStereoDelayPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectStereoDelaySettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class EnvelopeFollowerListener : ObjectBase<UEnvelopeFollowerListener>
{
    public EnvelopeFollowerListener(IntPtr pointer) : base(pointer) {}
}

public unsafe class SourceEffectEnvelopeFollowerPreset : ObjectBase<USourceEffectEnvelopeFollowerPreset>
{
    public SourceEffectEnvelopeFollowerPreset(IntPtr pointer) : base(pointer) {}
    public void UnregisterEnvelopeFollowerListener(UEnvelopeFollowerListener* EnvelopeFollowerListener)
    {
        Span<(string name, object value)> @params = [
            ("EnvelopeFollowerListener", (IntPtr)EnvelopeFollowerListener)
        ];
        ProcessEvent(GetFunction("UnregisterEnvelopeFollowerListener"), @params);
    }
    public void SetSettings(ref FSourceEffectEnvelopeFollowerSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void RegisterEnvelopeFollowerListener(UEnvelopeFollowerListener* EnvelopeFollowerListener)
    {
        Span<(string name, object value)> @params = [
            ("EnvelopeFollowerListener", (IntPtr)EnvelopeFollowerListener)
        ];
        ProcessEvent(GetFunction("RegisterEnvelopeFollowerListener"), @params);
    }
}

public unsafe class SourceEffectEQPreset : ObjectBase<USourceEffectEQPreset>
{
    public SourceEffectEQPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectEQSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class Synth2DSlider : ObjectBase<USynth2DSlider>
{
    public Synth2DSlider(IntPtr pointer) : base(pointer) {}
    public void SetValue(FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetValue"), @params);
    }
    public void SetStepSize(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetStepSize"), @params);
    }
    public void SetSliderHandleColor(FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetSliderHandleColor"), @params);
    }
    public void SetLocked(bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetLocked"), @params);
    }
    public void SetIndentHandle(bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetIndentHandle"), @params);
    }
    public FVector2D GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetValue"), @params);
    }
}

public unsafe class GranularSynth : ObjectBase<UGranularSynth>
{
    public GranularSynth(IntPtr pointer) : base(pointer) {}
    public void SetSustainGain(float SustainGain)
    {
        Span<(string name, object value)> @params = [
            ("SustainGain", SustainGain)
        ];
        ProcessEvent(GetFunction("SetSustainGain"), @params);
    }
    public void SetSoundWave(USoundWave* InSoundWave)
    {
        Span<(string name, object value)> @params = [
            ("InSoundWave", (IntPtr)InSoundWave)
        ];
        ProcessEvent(GetFunction("SetSoundWave"), @params);
    }
    public void SetScrubMode(bool bScrubMode)
    {
        Span<(string name, object value)> @params = [
            ("bScrubMode", bScrubMode)
        ];
        ProcessEvent(GetFunction("SetScrubMode"), @params);
    }
    public void SetReleaseTimeMsec(float ReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("ReleaseTimeMsec", ReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetReleaseTimeMsec"), @params);
    }
    public void SetPlayheadTime(float InPositionSec, float LerpTimeSec, EGranularSynthSeekType SeekType)
    {
        Span<(string name, object value)> @params = [
            ("InPositionSec", InPositionSec), 
            ("LerpTimeSec", LerpTimeSec), 
            ("SeekType", SeekType)
        ];
        ProcessEvent(GetFunction("SetPlayheadTime"), @params);
    }
    public void SetPlaybackSpeed(float InPlayheadRate)
    {
        Span<(string name, object value)> @params = [
            ("InPlayheadRate", InPlayheadRate)
        ];
        ProcessEvent(GetFunction("SetPlaybackSpeed"), @params);
    }
    public void SetGrainVolume(float BaseVolume, FVector2D VolumeRange)
    {
        Span<(string name, object value)> @params = [
            ("BaseVolume", BaseVolume), 
            ("VolumeRange", VolumeRange)
        ];
        ProcessEvent(GetFunction("SetGrainVolume"), @params);
    }
    public void SetGrainsPerSecond(float InGrainsPerSecond)
    {
        Span<(string name, object value)> @params = [
            ("InGrainsPerSecond", InGrainsPerSecond)
        ];
        ProcessEvent(GetFunction("SetGrainsPerSecond"), @params);
    }
    public void SetGrainProbability(float InGrainProbability)
    {
        Span<(string name, object value)> @params = [
            ("InGrainProbability", InGrainProbability)
        ];
        ProcessEvent(GetFunction("SetGrainProbability"), @params);
    }
    public void SetGrainPitch(float BasePitch, FVector2D PitchRange)
    {
        Span<(string name, object value)> @params = [
            ("BasePitch", BasePitch), 
            ("PitchRange", PitchRange)
        ];
        ProcessEvent(GetFunction("SetGrainPitch"), @params);
    }
    public void SetGrainPan(float BasePan, FVector2D PanRange)
    {
        Span<(string name, object value)> @params = [
            ("BasePan", BasePan), 
            ("PanRange", PanRange)
        ];
        ProcessEvent(GetFunction("SetGrainPan"), @params);
    }
    public void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType)
    {
        Span<(string name, object value)> @params = [
            ("EnvelopeType", EnvelopeType)
        ];
        ProcessEvent(GetFunction("SetGrainEnvelopeType"), @params);
    }
    public void SetGrainDuration(float BaseDurationMsec, FVector2D DurationRange)
    {
        Span<(string name, object value)> @params = [
            ("BaseDurationMsec", BaseDurationMsec), 
            ("DurationRange", DurationRange)
        ];
        ProcessEvent(GetFunction("SetGrainDuration"), @params);
    }
    public void SetDecayTime(float DecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("DecayTimeMsec", DecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetDecayTime"), @params);
    }
    public void SetAttackTime(float AttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("AttackTimeMsec", AttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetAttackTime"), @params);
    }
    public void NoteOn(float Note, int Velocity, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("Note", Note), 
            ("Velocity", Velocity), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("NoteOn"), @params);
    }
    public void NoteOff(float Note, bool bKill)
    {
        Span<(string name, object value)> @params = [
            ("Note", Note), 
            ("bKill", bKill)
        ];
        ProcessEvent(GetFunction("NoteOff"), @params);
    }
    public bool IsLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoaded"), @params);
    }
    public float GetSampleDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSampleDuration"), @params);
    }
    public float GetCurrentPlayheadTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentPlayheadTime"), @params);
    }
}

public unsafe class MonoWaveTableSynthPreset : ObjectBase<UMonoWaveTableSynthPreset>
{
    public MonoWaveTableSynthPreset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SynthComponentMonoWaveTable : ObjectBase<USynthComponentMonoWaveTable>
{
    public SynthComponentMonoWaveTable(IntPtr pointer) : base(pointer) {}
    public void SetWaveTablePosition(float InPosition)
    {
        Span<(string name, object value)> @params = [
            ("InPosition", InPosition)
        ];
        ProcessEvent(GetFunction("SetWaveTablePosition"), @params);
    }
    public void SetSustainPedalState(bool InSustainPedalState)
    {
        Span<(string name, object value)> @params = [
            ("InSustainPedalState", InSustainPedalState)
        ];
        ProcessEvent(GetFunction("SetSustainPedalState"), @params);
    }
    public void SetPosLfoType(ESynthLFOType InLfoType)
    {
        Span<(string name, object value)> @params = [
            ("InLfoType", InLfoType)
        ];
        ProcessEvent(GetFunction("SetPosLfoType"), @params);
    }
    public void SetPosLfoFrequency(float InLfoFrequency)
    {
        Span<(string name, object value)> @params = [
            ("InLfoFrequency", InLfoFrequency)
        ];
        ProcessEvent(GetFunction("SetPosLfoFrequency"), @params);
    }
    public void SetPosLfoDepth(float InLfoDepth)
    {
        Span<(string name, object value)> @params = [
            ("InLfoDepth", InLfoDepth)
        ];
        ProcessEvent(GetFunction("SetPosLfoDepth"), @params);
    }
    public void SetPositionEnvelopeSustainGain(float InSustainGain)
    {
        Span<(string name, object value)> @params = [
            ("InSustainGain", InSustainGain)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeSustainGain"), @params);
    }
    public void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeReleaseTime"), @params);
    }
    public void SetPositionEnvelopeInvert(bool bInInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInInvert", bInInvert)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeInvert"), @params);
    }
    public void SetPositionEnvelopeDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeDepth"), @params);
    }
    public void SetPositionEnvelopeDecayTime(float InDecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InDecayTimeMsec", InDecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeDecayTime"), @params);
    }
    public void SetPositionEnvelopeBiasInvert(bool bInBiasInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInBiasInvert", bInBiasInvert)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeBiasInvert"), @params);
    }
    public void SetPositionEnvelopeBiasDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeBiasDepth"), @params);
    }
    public void SetPositionEnvelopeAttackTime(float InAttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InAttackTimeMsec", InAttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetPositionEnvelopeAttackTime"), @params);
    }
    public void SetLowPassFilterResonance(float InNewQ)
    {
        Span<(string name, object value)> @params = [
            ("InNewQ", InNewQ)
        ];
        ProcessEvent(GetFunction("SetLowPassFilterResonance"), @params);
    }
    public void SetFrequencyWithMidiNote(float InMidiNote)
    {
        Span<(string name, object value)> @params = [
            ("InMidiNote", InMidiNote)
        ];
        ProcessEvent(GetFunction("SetFrequencyWithMidiNote"), @params);
    }
    public void SetFrequencyPitchBend(float FrequencyOffsetCents)
    {
        Span<(string name, object value)> @params = [
            ("FrequencyOffsetCents", FrequencyOffsetCents)
        ];
        ProcessEvent(GetFunction("SetFrequencyPitchBend"), @params);
    }
    public void SetFrequency(float FrequencyHz)
    {
        Span<(string name, object value)> @params = [
            ("FrequencyHz", FrequencyHz)
        ];
        ProcessEvent(GetFunction("SetFrequency"), @params);
    }
    public void SetFilterEnvelopeSustainGain(float InSustainGain)
    {
        Span<(string name, object value)> @params = [
            ("InSustainGain", InSustainGain)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeSustainGain"), @params);
    }
    public void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeReleaseTime"), @params);
    }
    public void SetFilterEnvelopenDecayTime(float InDecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InDecayTimeMsec", InDecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopenDecayTime"), @params);
    }
    public void SetFilterEnvelopeInvert(bool bInInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInInvert", bInInvert)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeInvert"), @params);
    }
    public void SetFilterEnvelopeDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeDepth"), @params);
    }
    public void SetFilterEnvelopeBiasInvert(bool bInBiasInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInBiasInvert", bInBiasInvert)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeBiasInvert"), @params);
    }
    public void SetFilterEnvelopeBiasDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeBiasDepth"), @params);
    }
    public void SetFilterEnvelopeAttackTime(float InAttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InAttackTimeMsec", InAttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetFilterEnvelopeAttackTime"), @params);
    }
    public bool SetCurveValue(int TableIndex, int KeyframeIndex, float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("TableIndex", TableIndex), 
            ("KeyframeIndex", KeyframeIndex), 
            ("NewValue", NewValue)
        ];
        return ProcessEvent<bool>(GetFunction("SetCurveValue"), @params);
    }
    public bool SetCurveTangent(int TableIndex, float InNewTangent)
    {
        Span<(string name, object value)> @params = [
            ("TableIndex", TableIndex), 
            ("InNewTangent", InNewTangent)
        ];
        return ProcessEvent<bool>(GetFunction("SetCurveTangent"), @params);
    }
    public bool SetCurveInterpolationType(CurveInterpolationType InterpolationType, int TableIndex)
    {
        Span<(string name, object value)> @params = [
            ("InterpolationType", InterpolationType), 
            ("TableIndex", TableIndex)
        ];
        return ProcessEvent<bool>(GetFunction("SetCurveInterpolationType"), @params);
    }
    public void SetAmpEnvelopeSustainGain(float InSustainGain)
    {
        Span<(string name, object value)> @params = [
            ("InSustainGain", InSustainGain)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeSustainGain"), @params);
    }
    public void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeReleaseTime"), @params);
    }
    public void SetAmpEnvelopeInvert(bool bInInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInInvert", bInInvert)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeInvert"), @params);
    }
    public void SetAmpEnvelopeDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeDepth"), @params);
    }
    public void SetAmpEnvelopeDecayTime(float InDecayTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InDecayTimeMsec", InDecayTimeMsec)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeDecayTime"), @params);
    }
    public void SetAmpEnvelopeBiasInvert(bool bInBiasInvert)
    {
        Span<(string name, object value)> @params = [
            ("bInBiasInvert", bInBiasInvert)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeBiasInvert"), @params);
    }
    public void SetAmpEnvelopeBiasDepth(float InDepth)
    {
        Span<(string name, object value)> @params = [
            ("InDepth", InDepth)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeBiasDepth"), @params);
    }
    public void SetAmpEnvelopeAttackTime(float InAttackTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InAttackTimeMsec", InAttackTimeMsec)
        ];
        ProcessEvent(GetFunction("SetAmpEnvelopeAttackTime"), @params);
    }
    public void RefreshWaveTable(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("RefreshWaveTable"), @params);
    }
    public void RefreshAllWaveTables()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RefreshAllWaveTables"), @params);
    }
    public void NoteOn(float InMidiNote, float InVelocity)
    {
        Span<(string name, object value)> @params = [
            ("InMidiNote", InMidiNote), 
            ("InVelocity", InVelocity)
        ];
        ProcessEvent(GetFunction("NoteOn"), @params);
    }
    public void NoteOff(float InMidiNote)
    {
        Span<(string name, object value)> @params = [
            ("InMidiNote", InMidiNote)
        ];
        ProcessEvent(GetFunction("NoteOff"), @params);
    }
    public int GetNumTableEntries()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumTableEntries"), @params);
    }
    public int GetMaxTableIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMaxTableIndex"), @params);
    }
    public TArray<float> GetKeyFrameValuesForTable(float TableIndex)
    {
        Span<(string name, object value)> @params = [
            ("TableIndex", TableIndex)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("GetKeyFrameValuesForTable"), @params);
    }
    public float GetCurveTangent(int TableIndex)
    {
        Span<(string name, object value)> @params = [
            ("TableIndex", TableIndex)
        ];
        return ProcessEvent<float>(GetFunction("GetCurveTangent"), @params);
    }
}

public unsafe class SynthComponentToneGenerator : ObjectBase<USynthComponentToneGenerator>
{
    public SynthComponentToneGenerator(IntPtr pointer) : base(pointer) {}
    public void SetVolume(float InVolume)
    {
        Span<(string name, object value)> @params = [
            ("InVolume", InVolume)
        ];
        ProcessEvent(GetFunction("SetVolume"), @params);
    }
    public void SetFrequency(float InFrequency)
    {
        Span<(string name, object value)> @params = [
            ("InFrequency", InFrequency)
        ];
        ProcessEvent(GetFunction("SetFrequency"), @params);
    }
}

public unsafe class SynthSamplePlayer : ObjectBase<USynthSamplePlayer>
{
    public SynthSamplePlayer(IntPtr pointer) : base(pointer) {}
    public void SetSoundWave(USoundWave* InSoundWave)
    {
        Span<(string name, object value)> @params = [
            ("InSoundWave", (IntPtr)InSoundWave)
        ];
        ProcessEvent(GetFunction("SetSoundWave"), @params);
    }
    public void SetScrubTimeWidth(float InScrubTimeWidthSec)
    {
        Span<(string name, object value)> @params = [
            ("InScrubTimeWidthSec", InScrubTimeWidthSec)
        ];
        ProcessEvent(GetFunction("SetScrubTimeWidth"), @params);
    }
    public void SetScrubMode(bool bScrubMode)
    {
        Span<(string name, object value)> @params = [
            ("bScrubMode", bScrubMode)
        ];
        ProcessEvent(GetFunction("SetScrubMode"), @params);
    }
    public void SetPitch(float InPitch, float TimeSec)
    {
        Span<(string name, object value)> @params = [
            ("InPitch", InPitch), 
            ("TimeSec", TimeSec)
        ];
        ProcessEvent(GetFunction("SetPitch"), @params);
    }
    public void SeekToTime(float TimeSec, ESamplePlayerSeekType SeekType, bool bWrap)
    {
        Span<(string name, object value)> @params = [
            ("TimeSec", TimeSec), 
            ("SeekType", SeekType), 
            ("bWrap", bWrap)
        ];
        ProcessEvent(GetFunction("SeekToTime"), @params);
    }
    public bool IsLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoaded"), @params);
    }
    public float GetSampleDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSampleDuration"), @params);
    }
    public float GetCurrentPlaybackProgressTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentPlaybackProgressTime"), @params);
    }
    public float GetCurrentPlaybackProgressPercent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentPlaybackProgressPercent"), @params);
    }
}

public unsafe class SynthesisUtilitiesBlueprintFunctionLibrary : ObjectBase<USynthesisUtilitiesBlueprintFunctionLibrary>
{
    public SynthesisUtilitiesBlueprintFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public float GetLogFrequency(float InLinearValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
    {
        Span<(string name, object value)> @params = [
            ("InLinearValue", InLinearValue), 
            ("InDomainMin", InDomainMin), 
            ("InDomainMax", InDomainMax), 
            ("InRangeMin", InRangeMin), 
            ("InRangeMax", InRangeMax)
        ];
        return ProcessEvent<float>(GetFunction("GetLogFrequency"), @params);
    }
    public float GetLinearFrequency(float InLogFrequencyValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
    {
        Span<(string name, object value)> @params = [
            ("InLogFrequencyValue", InLogFrequencyValue), 
            ("InDomainMin", InDomainMin), 
            ("InDomainMax", InDomainMax), 
            ("InRangeMin", InRangeMin), 
            ("InRangeMax", InRangeMax)
        ];
        return ProcessEvent<float>(GetFunction("GetLinearFrequency"), @params);
    }
}

public unsafe class SubmixEffectTapDelayPreset : ObjectBase<USubmixEffectTapDelayPreset>
{
    public SubmixEffectTapDelayPreset(IntPtr pointer) : base(pointer) {}
    public void SetTap(int TapId, ref FTapDelayInfo TapInfo)
    {
        Span<(string name, object value)> @params = [
            ("TapId", TapId), 
            ("TapInfo", TapInfo)
        ];
        ProcessEvent(GetFunction("SetTap"), @params);
    }
    public void SetSettings(ref FSubmixEffectTapDelaySettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetInterpolationTime(float Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("SetInterpolationTime"), @params);
    }
    public void RemoveTap(int TapId)
    {
        Span<(string name, object value)> @params = [
            ("TapId", TapId)
        ];
        ProcessEvent(GetFunction("RemoveTap"), @params);
    }
    public void GetTapIds(ref TArray<int> TapIds)
    {
        Span<(string name, object value)> @params = [
            ("TapIds", TapIds)
        ];
        ProcessEvent(GetFunction("GetTapIds"), @params);
    }
    public void GetTap(int TapId, ref FTapDelayInfo TapInfo)
    {
        Span<(string name, object value)> @params = [
            ("TapId", TapId), 
            ("TapInfo", TapInfo)
        ];
        ProcessEvent(GetFunction("GetTap"), @params);
    }
    public float GetMaxDelayInMilliseconds()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxDelayInMilliseconds"), @params);
    }
    public void AddTap(ref int TapId)
    {
        Span<(string name, object value)> @params = [
            ("TapId", TapId)
        ];
        ProcessEvent(GetFunction("AddTap"), @params);
    }
}

public unsafe class SourceEffectFilterPreset : ObjectBase<USourceEffectFilterPreset>
{
    public SourceEffectFilterPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectFilterSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectFoldbackDistortionPreset : ObjectBase<USourceEffectFoldbackDistortionPreset>
{
    public SourceEffectFoldbackDistortionPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectFoldbackDistortionSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectMidSideSpreaderPreset : ObjectBase<USourceEffectMidSideSpreaderPreset>
{
    public SourceEffectMidSideSpreaderPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectMidSideSpreaderSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectPhaserPreset : ObjectBase<USourceEffectPhaserPreset>
{
    public SourceEffectPhaserPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectPhaserSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectRingModulationPreset : ObjectBase<USourceEffectRingModulationPreset>
{
    public SourceEffectRingModulationPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectRingModulationSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectSimpleDelayPreset : ObjectBase<USourceEffectSimpleDelayPreset>
{
    public SourceEffectSimpleDelayPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectSimpleDelaySettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SourceEffectPannerPreset : ObjectBase<USourceEffectPannerPreset>
{
    public SourceEffectPannerPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSourceEffectPannerSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SynthKnob : ObjectBase<USynthKnob>
{
    public SynthKnob(IntPtr pointer) : base(pointer) {}
    public void SetValue(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetValue"), @params);
    }
    public void SetStepSize(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetStepSize"), @params);
    }
    public void SetLocked(bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetLocked"), @params);
    }
    public float GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetValue"), @params);
    }
}

