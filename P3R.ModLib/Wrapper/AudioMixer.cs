using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SynthComponent : ObjectBase<USynthComponent>
{
    public SynthComponent(IntPtr pointer) : base(pointer) {}
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void Start()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Start"), @params);
    }
    public void SetVolumeMultiplier(float VolumeMultiplier)
    {
        Span<(string name, object value)> @params = [
            ("VolumeMultiplier", VolumeMultiplier)
        ];
        ProcessEvent(GetFunction("SetVolumeMultiplier"), @params);
    }
    public void SetSubmixSend(USoundSubmixBase* Submix, float SendLevel)
    {
        Span<(string name, object value)> @params = [
            ("Submix", (IntPtr)Submix), 
            ("SendLevel", SendLevel)
        ];
        ProcessEvent(GetFunction("SetSubmixSend"), @params);
    }
    public void SetOutputToBusOnly(bool bInOutputToBusOnly)
    {
        Span<(string name, object value)> @params = [
            ("bInOutputToBusOnly", bInOutputToBusOnly)
        ];
        ProcessEvent(GetFunction("SetOutputToBusOnly"), @params);
    }
    public void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
    {
        Span<(string name, object value)> @params = [
            ("InLowPassFilterFrequency", InLowPassFilterFrequency)
        ];
        ProcessEvent(GetFunction("SetLowPassFilterFrequency"), @params);
    }
    public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
    {
        Span<(string name, object value)> @params = [
            ("InLowPassFilterEnabled", InLowPassFilterEnabled)
        ];
        ProcessEvent(GetFunction("SetLowPassFilterEnabled"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
}

public unsafe class AudioGenerator : ObjectBase<UAudioGenerator>
{
    public AudioGenerator(IntPtr pointer) : base(pointer) {}}

public unsafe class AudioMixerBlueprintLibrary : ObjectBase<UAudioMixerBlueprintLibrary>
{
    public AudioMixerBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public float TrimAudioCache(float InMegabytesToFree)
    {
        Span<(string name, object value)> @params = [
            ("InMegabytesToFree", InMegabytesToFree)
        ];
        return ProcessEvent<float>(GetFunction("TrimAudioCache"), @params);
    }
    public USoundWave* StopRecordingOutput(UObject* WorldContextObject, EAudioRecordingExportType ExportType, FString Name, FString Path, USoundSubmix* SubmixToRecord, USoundWave* ExistingSoundWaveToOverwrite)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ExportType", ExportType), 
            ("Name", Name), 
            ("Path", Path), 
            ("SubmixToRecord", (IntPtr)SubmixToRecord), 
            ("ExistingSoundWaveToOverwrite", (IntPtr)ExistingSoundWaveToOverwrite)
        ];
        return (USoundWave*)ProcessEvent<IntPtr>(GetFunction("StopRecordingOutput"), @params);
    }
    public void StopAudioBus(UObject* WorldContextObject, UAudioBus* AudioBus)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("AudioBus", (IntPtr)AudioBus)
        ];
        ProcessEvent(GetFunction("StopAudioBus"), @params);
    }
    public void StopAnalyzingOutput(UObject* WorldContextObject, USoundSubmix* SubmixToStopAnalyzing)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixToStopAnalyzing", (IntPtr)SubmixToStopAnalyzing)
        ];
        ProcessEvent(GetFunction("StopAnalyzingOutput"), @params);
    }
    public void StartRecordingOutput(UObject* WorldContextObject, float ExpectedDuration, USoundSubmix* SubmixToRecord)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ExpectedDuration", ExpectedDuration), 
            ("SubmixToRecord", (IntPtr)SubmixToRecord)
        ];
        ProcessEvent(GetFunction("StartRecordingOutput"), @params);
    }
    public void StartAudioBus(UObject* WorldContextObject, UAudioBus* AudioBus)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("AudioBus", (IntPtr)AudioBus)
        ];
        ProcessEvent(GetFunction("StartAudioBus"), @params);
    }
    public void StartAnalyzingOutput(UObject* WorldContextObject, USoundSubmix* SubmixToAnalyze, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixToAnalyze", (IntPtr)SubmixToAnalyze), 
            ("FFTSize", FFTSize), 
            ("InterpolationMethod", InterpolationMethod), 
            ("WindowType", WindowType), 
            ("HopSize", HopSize), 
            ("SpectrumType", SpectrumType)
        ];
        ProcessEvent(GetFunction("StartAnalyzingOutput"), @params);
    }
    public void SetSubmixEffectChainOverride(UObject* WorldContextObject, USoundSubmix* SoundSubmix, TArray<IntPtr> SubmixEffectPresetChain, float FadeTimeSec)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixEffectPresetChain", SubmixEffectPresetChain), 
            ("FadeTimeSec", FadeTimeSec)
        ];
        ProcessEvent(GetFunction("SetSubmixEffectChainOverride"), @params);
    }
    public void SetBypassSourceEffectChainEntry(UObject* WorldContextObject, USoundEffectSourcePresetChain* PresetChain, int EntryIndex, bool bBypassed)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PresetChain", (IntPtr)PresetChain), 
            ("EntryIndex", EntryIndex), 
            ("bBypassed", bBypassed)
        ];
        ProcessEvent(GetFunction("SetBypassSourceEffectChainEntry"), @params);
    }
    public void ResumeRecordingOutput(UObject* WorldContextObject, USoundSubmix* SubmixToPause)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixToPause", (IntPtr)SubmixToPause)
        ];
        ProcessEvent(GetFunction("ResumeRecordingOutput"), @params);
    }
    public void ReplaceSubmixEffect(UObject* WorldContextObject, USoundSubmix* InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InSoundSubmix", (IntPtr)InSoundSubmix), 
            ("SubmixChainIndex", SubmixChainIndex), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("ReplaceSubmixEffect"), @params);
    }
    public void ReplaceSoundEffectSubmix(UObject* WorldContextObject, USoundSubmix* InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InSoundSubmix", (IntPtr)InSoundSubmix), 
            ("SubmixChainIndex", SubmixChainIndex), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("ReplaceSoundEffectSubmix"), @params);
    }
    public void RemoveSubmixEffectPresetAtIndex(UObject* WorldContextObject, USoundSubmix* SoundSubmix, int SubmixChainIndex)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixChainIndex", SubmixChainIndex)
        ];
        ProcessEvent(GetFunction("RemoveSubmixEffectPresetAtIndex"), @params);
    }
    public void RemoveSubmixEffectPreset(UObject* WorldContextObject, USoundSubmix* SoundSubmix, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("RemoveSubmixEffectPreset"), @params);
    }
    public void RemoveSubmixEffectAtIndex(UObject* WorldContextObject, USoundSubmix* SoundSubmix, int SubmixChainIndex)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixChainIndex", SubmixChainIndex)
        ];
        ProcessEvent(GetFunction("RemoveSubmixEffectAtIndex"), @params);
    }
    public void RemoveSubmixEffect(UObject* WorldContextObject, USoundSubmix* SoundSubmix, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("RemoveSubmixEffect"), @params);
    }
    public void RemoveSourceEffectFromPresetChain(UObject* WorldContextObject, USoundEffectSourcePresetChain* PresetChain, int EntryIndex)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PresetChain", (IntPtr)PresetChain), 
            ("EntryIndex", EntryIndex)
        ];
        ProcessEvent(GetFunction("RemoveSourceEffectFromPresetChain"), @params);
    }
    public void RemoveMasterSubmixEffect(UObject* WorldContextObject, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("RemoveMasterSubmixEffect"), @params);
    }
    public void PrimeSoundCueForPlayback(USoundCue* SoundCue)
    {
        Span<(string name, object value)> @params = [
            ("SoundCue", (IntPtr)SoundCue)
        ];
        ProcessEvent(GetFunction("PrimeSoundCueForPlayback"), @params);
    }
    public void PauseRecordingOutput(UObject* WorldContextObject, USoundSubmix* SubmixToPause)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixToPause", (IntPtr)SubmixToPause)
        ];
        ProcessEvent(GetFunction("PauseRecordingOutput"), @params);
    }
    public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands, int InAttackTimeMsec, int InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InBandPresetType", InBandPresetType), 
            ("InNumBands", InNumBands), 
            ("InAttackTimeMsec", InAttackTimeMsec), 
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        return ProcessEvent<TArray<FSoundSubmixSpectralAnalysisBandSettings>>(GetFunction("MakePresetSpectralAnalysisBandSettings"), @params);
    }
    public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones, EMusicalNoteName InStartingMusicalNote, int InStartingOctave, int InAttackTimeMsec, int InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InNumSemitones", InNumSemitones), 
            ("InStartingMusicalNote", InStartingMusicalNote), 
            ("InStartingOctave", InStartingOctave), 
            ("InAttackTimeMsec", InAttackTimeMsec), 
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        return ProcessEvent<TArray<FSoundSubmixSpectralAnalysisBandSettings>>(GetFunction("MakeMusicalSpectralAnalysisBandSettings"), @params);
    }
    public TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands, float InMinimumFrequency, float InMaximumFrequency, int InAttackTimeMsec, int InReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("InNumBands", InNumBands), 
            ("InMinimumFrequency", InMinimumFrequency), 
            ("InMaximumFrequency", InMaximumFrequency), 
            ("InAttackTimeMsec", InAttackTimeMsec), 
            ("InReleaseTimeMsec", InReleaseTimeMsec)
        ];
        return ProcessEvent<TArray<FSoundSubmixSpectralAnalysisBandSettings>>(GetFunction("MakeFullSpectrumSpectralAnalysisBandSettings"), @params);
    }
    public bool IsAudioBusActive(UObject* WorldContextObject, UAudioBus* AudioBus)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("AudioBus", (IntPtr)AudioBus)
        ];
        return ProcessEvent<bool>(GetFunction("IsAudioBusActive"), @params);
    }
    public void GetPhaseForFrequencies(UObject* WorldContextObject, ref TArray<float> Frequencies, ref TArray<float> Phases, USoundSubmix* SubmixToAnalyze)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Frequencies", Frequencies), 
            ("Phases", Phases), 
            ("SubmixToAnalyze", (IntPtr)SubmixToAnalyze)
        ];
        ProcessEvent(GetFunction("GetPhaseForFrequencies"), @params);
    }
    public int GetNumberOfEntriesInSourceEffectChain(UObject* WorldContextObject, USoundEffectSourcePresetChain* PresetChain)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PresetChain", (IntPtr)PresetChain)
        ];
        return ProcessEvent<int>(GetFunction("GetNumberOfEntriesInSourceEffectChain"), @params);
    }
    public void GetMagnitudeForFrequencies(UObject* WorldContextObject, ref TArray<float> Frequencies, ref TArray<float> Magnitudes, USoundSubmix* SubmixToAnalyze)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Frequencies", Frequencies), 
            ("Magnitudes", Magnitudes), 
            ("SubmixToAnalyze", (IntPtr)SubmixToAnalyze)
        ];
        ProcessEvent(GetFunction("GetMagnitudeForFrequencies"), @params);
    }
    public void ClearSubmixEffects(UObject* WorldContextObject, USoundSubmix* SoundSubmix)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix)
        ];
        ProcessEvent(GetFunction("ClearSubmixEffects"), @params);
    }
    public void ClearSubmixEffectChainOverride(UObject* WorldContextObject, USoundSubmix* SoundSubmix, float FadeTimeSec)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("FadeTimeSec", FadeTimeSec)
        ];
        ProcessEvent(GetFunction("ClearSubmixEffectChainOverride"), @params);
    }
    public void ClearMasterSubmixEffects(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        ProcessEvent(GetFunction("ClearMasterSubmixEffects"), @params);
    }
    public int AddSubmixEffect(UObject* WorldContextObject, USoundSubmix* SoundSubmix, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SoundSubmix", (IntPtr)SoundSubmix), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        return ProcessEvent<int>(GetFunction("AddSubmixEffect"), @params);
    }
    public void AddSourceEffectToPresetChain(UObject* WorldContextObject, USoundEffectSourcePresetChain* PresetChain, FSourceEffectChainEntry Entry)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PresetChain", (IntPtr)PresetChain), 
            ("Entry", Entry)
        ];
        ProcessEvent(GetFunction("AddSourceEffectToPresetChain"), @params);
    }
    public void AddMasterSubmixEffect(UObject* WorldContextObject, USoundEffectSubmixPreset* SubmixEffectPreset)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SubmixEffectPreset", (IntPtr)SubmixEffectPreset)
        ];
        ProcessEvent(GetFunction("AddMasterSubmixEffect"), @params);
    }
}

public unsafe class QuartzClockHandle : ObjectBase<UQuartzClockHandle>
{
    public QuartzClockHandle(IntPtr pointer) : base(pointer) {}
    public void UnsubscribeFromTimeDivision(UObject* WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InQuantizationBoundary", InQuantizationBoundary), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("UnsubscribeFromTimeDivision"), @params);
    }
    public void UnsubscribeFromAllTimeDivisions(UObject* WorldContextObject, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("UnsubscribeFromAllTimeDivisions"), @params);
    }
    public void StopClock(UObject* WorldContextObject, bool CancelPendingEvents, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CancelPendingEvents", CancelPendingEvents), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("StopClock"), @params);
    }
    public void StartClock(UObject* WorldContextObject, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("StartClock"), @params);
    }
    public void ResumeClock(UObject* WorldContextObject, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("ResumeClock"), @params);
    }
    public void PauseClock(UObject* WorldContextObject, ref UQuartzClockHandle* ClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockHandle", (IntPtr)ClockHandle)
        ];
        ProcessEvent(GetFunction("PauseClock"), @params);
    }
    public bool IsClockRunning(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<bool>(GetFunction("IsClockRunning"), @params);
    }
    public float GetTicksPerSecond(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetTicksPerSecond"), @params);
    }
    public float GetThirtySecondNotesPerMinute(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetThirtySecondNotesPerMinute"), @params);
    }
    public float GetSecondsPerTick(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetSecondsPerTick"), @params);
    }
    public float GetMillisecondsPerTick(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetMillisecondsPerTick"), @params);
    }
    public float GetEstimatedRunTime(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetEstimatedRunTime"), @params);
    }
    public float GetDurationOfQuantizationTypeInSeconds(UObject* WorldContextObject, ref EQuartzCommandQuantization QuantizationType, float Multiplier)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("QuantizationType", QuantizationType), 
            ("Multiplier", Multiplier)
        ];
        return ProcessEvent<float>(GetFunction("GetDurationOfQuantizationTypeInSeconds"), @params);
    }
    public FQuartzTransportTimeStamp GetCurrentTimestamp(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<FQuartzTransportTimeStamp>(GetFunction("GetCurrentTimestamp"), @params);
    }
    public float GetBeatsPerMinute(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetBeatsPerMinute"), @params);
    }
}

public unsafe class SubmixEffectDynamicsProcessorPreset : ObjectBase<USubmixEffectDynamicsProcessorPreset>
{
    public SubmixEffectDynamicsProcessorPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectDynamicsProcessorSettings Settings)
    {
        Span<(string name, object value)> @params = [
            ("Settings", Settings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetExternalSubmix(USoundSubmix* Submix)
    {
        Span<(string name, object value)> @params = [
            ("Submix", (IntPtr)Submix)
        ];
        ProcessEvent(GetFunction("SetExternalSubmix"), @params);
    }
    public void SetAudioBus(UAudioBus* AudioBus)
    {
        Span<(string name, object value)> @params = [
            ("AudioBus", (IntPtr)AudioBus)
        ];
        ProcessEvent(GetFunction("SetAudioBus"), @params);
    }
    public void ResetKey()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetKey"), @params);
    }
}

public unsafe class SubmixEffectSubmixEQPreset : ObjectBase<USubmixEffectSubmixEQPreset>
{
    public SubmixEffectSubmixEQPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FSubmixEffectSubmixEQSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class SubmixEffectReverbPreset : ObjectBase<USubmixEffectReverbPreset>
{
    public SubmixEffectReverbPreset(IntPtr pointer) : base(pointer) {}
    public void SetSettingsWithReverbEffect(UReverbEffect* InReverbEffect, float WetLevel, float DryLevel)
    {
        Span<(string name, object value)> @params = [
            ("InReverbEffect", (IntPtr)InReverbEffect), 
            ("WetLevel", WetLevel), 
            ("DryLevel", DryLevel)
        ];
        ProcessEvent(GetFunction("SetSettingsWithReverbEffect"), @params);
    }
    public void SetSettings(ref FSubmixEffectReverbSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
}

public unsafe class QuartzSubsystem : ObjectBase<UQuartzSubsystem>
{
    public QuartzSubsystem(IntPtr pointer) : base(pointer) {}
    public bool IsQuartzEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsQuartzEnabled"), @params);
    }
    public bool IsClockRunning(UObject* WorldContextObject, FName ClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName)
        ];
        return ProcessEvent<bool>(GetFunction("IsClockRunning"), @params);
    }
    public float GetRoundTripMinLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetRoundTripMinLatency"), @params);
    }
    public float GetRoundTripMaxLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetRoundTripMaxLatency"), @params);
    }
    public float GetRoundTripAverageLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetRoundTripAverageLatency"), @params);
    }
    public UQuartzClockHandle* GetHandleForClock(UObject* WorldContextObject, FName ClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName)
        ];
        return (UQuartzClockHandle*)ProcessEvent<IntPtr>(GetFunction("GetHandleForClock"), @params);
    }
    public float GetGameThreadToAudioRenderThreadMinLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetGameThreadToAudioRenderThreadMinLatency"), @params);
    }
    public float GetGameThreadToAudioRenderThreadMaxLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetGameThreadToAudioRenderThreadMaxLatency"), @params);
    }
    public float GetGameThreadToAudioRenderThreadAverageLatency(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetGameThreadToAudioRenderThreadAverageLatency"), @params);
    }
    public float GetEstimatedClockRunTime(UObject* WorldContextObject, ref FName InClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InClockName", InClockName)
        ];
        return ProcessEvent<float>(GetFunction("GetEstimatedClockRunTime"), @params);
    }
    public float GetDurationOfQuantizationTypeInSeconds(UObject* WorldContextObject, FName ClockName, ref EQuartzCommandQuantization QuantizationType, float Multiplier)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName), 
            ("QuantizationType", QuantizationType), 
            ("Multiplier", Multiplier)
        ];
        return ProcessEvent<float>(GetFunction("GetDurationOfQuantizationTypeInSeconds"), @params);
    }
    public FQuartzTransportTimeStamp GetCurrentClockTimestamp(UObject* WorldContextObject, ref FName InClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InClockName", InClockName)
        ];
        return ProcessEvent<FQuartzTransportTimeStamp>(GetFunction("GetCurrentClockTimestamp"), @params);
    }
    public float GetAudioRenderThreadToGameThreadMinLatency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAudioRenderThreadToGameThreadMinLatency"), @params);
    }
    public float GetAudioRenderThreadToGameThreadMaxLatency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAudioRenderThreadToGameThreadMaxLatency"), @params);
    }
    public float GetAudioRenderThreadToGameThreadAverageLatency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAudioRenderThreadToGameThreadAverageLatency"), @params);
    }
    public bool DoesClockExist(UObject* WorldContextObject, FName ClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName)
        ];
        return ProcessEvent<bool>(GetFunction("DoesClockExist"), @params);
    }
    public void DeleteClockByName(UObject* WorldContextObject, FName ClockName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName)
        ];
        ProcessEvent(GetFunction("DeleteClockByName"), @params);
    }
    public void DeleteClockByHandle(UObject* WorldContextObject, ref UQuartzClockHandle* InClockHandle)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InClockHandle", (IntPtr)InClockHandle)
        ];
        ProcessEvent(GetFunction("DeleteClockByHandle"), @params);
    }
    public UQuartzClockHandle* CreateNewClock(UObject* WorldContextObject, FName ClockName, FQuartzClockSettings InSettings, bool bOverrideSettingsIfClockExists, bool bUseAudioEngineClockManager)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ClockName", ClockName), 
            ("InSettings", InSettings), 
            ("bOverrideSettingsIfClockExists", bOverrideSettingsIfClockExists), 
            ("bUseAudioEngineClockManager", bUseAudioEngineClockManager)
        ];
        return (UQuartzClockHandle*)ProcessEvent<IntPtr>(GetFunction("CreateNewClock"), @params);
    }
}

public unsafe class SynthSound : ObjectBase<USynthSound>
{
    public SynthSound(IntPtr pointer) : base(pointer) {}
}

