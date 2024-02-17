using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class Atom3dRegion : ObjectBase<UAtom3dRegion>
{
    public Atom3dRegion(IntPtr pointer) : base(pointer) {}
    public void SetHandle(UAtom3dRegionHandle* InHandle)
    {
        Span<(string name, object value)> @params = [
            ("InHandle", (IntPtr)InHandle)
        ];
        ProcessEvent(GetFunction("SetHandle"), @params);
    }
    public UAtom3dRegionHandle* GetHandle()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAtom3dRegionHandle*)ProcessEvent<IntPtr>(GetFunction("GetHandle"), @params);
    }
}

public unsafe class Atom3dSourceBaseComponent : ObjectBase<UAtom3dSourceBaseComponent>
{
    public Atom3dSourceBaseComponent(IntPtr pointer) : base(pointer) {}
    public void SetRegion(UAtom3dRegion* InRegion)
    {
        Span<(string name, object value)> @params = [
            ("InRegion", (IntPtr)InRegion)
        ];
        ProcessEvent(GetFunction("SetRegion"), @params);
    }
}

public unsafe class Atom3dTransceiverComponent : ObjectBase<UAtom3dTransceiverComponent>
{
    public Atom3dTransceiverComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomAreaSoundVolume : ObjectBase<AAtomAreaSoundVolume>
{
    public AtomAreaSoundVolume(IntPtr pointer) : base(pointer) {}
    public void SetPriority(float NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetPriority"), @params);
    }
    public void SetEnabled(bool bNewEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bNewEnabled", bNewEnabled)
        ];
        ProcessEvent(GetFunction("SetEnabled"), @params);
    }
    public void OnRep_bEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_bEnabled"), @params);
    }
    public float GetPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPriority"), @params);
    }
    public bool GetEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetEnabled"), @params);
    }
    public void DestroySounds()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroySounds"), @params);
    }
    public TArray<IntPtr> CreateSounds(FVector listener_location)
    {
        Span<(string name, object value)> @params = [
            ("listener_location", listener_location)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("CreateSounds"), @params);
    }
}

public unsafe class AtomAsrRack : ObjectBase<UAtomAsrRack>
{
    public AtomAsrRack(IntPtr pointer) : base(pointer) {}
    public void SetEffectBypass(FString BusName, FString EffectName, bool Bypasses)
    {
        Span<(string name, object value)> @params = [
            ("BusName", BusName), 
            ("EffectName", EffectName), 
            ("Bypasses", Bypasses)
        ];
        ProcessEvent(GetFunction("SetEffectBypass"), @params);
    }
    public void SetBusVolumeByName(FString BusName, float Volume)
    {
        Span<(string name, object value)> @params = [
            ("BusName", BusName), 
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetBusVolumeByName"), @params);
    }
    public void SetBusSendLevelByName(FString SourceBusName, FString DestBusName, float Level)
    {
        Span<(string name, object value)> @params = [
            ("SourceBusName", SourceBusName), 
            ("DestBusName", DestBusName), 
            ("Level", Level)
        ];
        ProcessEvent(GetFunction("SetBusSendLevelByName"), @params);
    }
    public UAtomAsrRack* GetDefaultAsrRack()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAtomAsrRack*)ProcessEvent<IntPtr>(GetFunction("GetDefaultAsrRack"), @params);
    }
    public FString GetCurrentAppliedSnapshot(int ASRRackID)
    {
        Span<(string name, object value)> @params = [
            ("ASRRackID", ASRRackID)
        ];
        return ProcessEvent<FString>(GetFunction("GetCurrentAppliedSnapshot"), @params);
    }
    public bool GetBusAnalyzerInfo(FString DspBusName, ref int num_channels, ref TArray<float> rms_levels, ref TArray<float> peak_levels, ref TArray<float> peak_hold_levels)
    {
        Span<(string name, object value)> @params = [
            ("DspBusName", DspBusName), 
            ("num_channels", num_channels), 
            ("rms_levels", rms_levels), 
            ("peak_levels", peak_levels), 
            ("peak_hold_levels", peak_hold_levels)
        ];
        return ProcessEvent<bool>(GetFunction("GetBusAnalyzerInfo"), @params);
    }
    public UAtomAsrRack* GetAsrRack(int ASRRackID)
    {
        Span<(string name, object value)> @params = [
            ("ASRRackID", ASRRackID)
        ];
        return (UAtomAsrRack*)ProcessEvent<IntPtr>(GetFunction("GetAsrRack"), @params);
    }
    public void DetachDspBusSetting()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DetachDspBusSetting"), @params);
    }
    public void ConnectToPadVibrator(int UserIndex)
    {
        Span<(string name, object value)> @params = [
            ("UserIndex", UserIndex)
        ];
        ProcessEvent(GetFunction("ConnectToPadVibrator"), @params);
    }
    public void ConnectToPadSpeaker(int UserIndex)
    {
        Span<(string name, object value)> @params = [
            ("UserIndex", UserIndex)
        ];
        ProcessEvent(GetFunction("ConnectToPadSpeaker"), @params);
    }
    public void AttachDspBusSetting(FString SettingName)
    {
        Span<(string name, object value)> @params = [
            ("SettingName", SettingName)
        ];
        ProcessEvent(GetFunction("AttachDspBusSetting"), @params);
    }
    public void ApplyDspBusSnapshot(FString SnapshotName, int Milliseconds)
    {
        Span<(string name, object value)> @params = [
            ("SnapshotName", SnapshotName), 
            ("Milliseconds", Milliseconds)
        ];
        ProcessEvent(GetFunction("ApplyDspBusSnapshot"), @params);
    }
}

public unsafe class AtomEntranceVolume : ObjectBase<AAtomEntranceVolume>
{
    public AtomEntranceVolume(IntPtr pointer) : base(pointer) {}
    public void SetPriority(float NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetPriority"), @params);
    }
    public void SetEnabled(bool bNewEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bNewEnabled", bNewEnabled)
        ];
        ProcessEvent(GetFunction("SetEnabled"), @params);
    }
    public void OnRep_bEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_bEnabled"), @params);
    }
    public float GetPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPriority"), @params);
    }
    public bool GetEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetEnabled"), @params);
    }
}

public unsafe class AtomAudioVolume : ObjectBase<AAtomAudioVolume>
{
    public AtomAudioVolume(IntPtr pointer) : base(pointer) {}
    public void SetReverbSettings(ref FSnapshotSwitchSettings NewReverbSettings)
    {
        Span<(string name, object value)> @params = [
            ("NewReverbSettings", NewReverbSettings)
        ];
        ProcessEvent(GetFunction("SetReverbSettings"), @params);
    }
    public void SetPriority(float NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetPriority"), @params);
    }
    public void SetEnabled(bool bNewEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bNewEnabled", bNewEnabled)
        ];
        ProcessEvent(GetFunction("SetEnabled"), @params);
    }
    public void OnRep_bEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_bEnabled"), @params);
    }
    public float GetPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPriority"), @params);
    }
    public bool GetEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetEnabled"), @params);
    }
    public void EnableAllAudioVolume(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("EnableAllAudioVolume"), @params);
    }
}

public unsafe class AtomAudioVolumeSettings : ObjectBase<UAtomAudioVolumeSettings>
{
    public AtomAudioVolumeSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomBusSampler : ObjectBase<UAtomBusSampler>
{
    public AtomBusSampler(IntPtr pointer) : base(pointer) {}
    public void StopRecordedSound()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopRecordedSound"), @params);
    }
    public void StartRecording(float InExpectedDuration, int InAsrRack, FString InBusName, bool BusOutput)
    {
        Span<(string name, object value)> @params = [
            ("InExpectedDuration", InExpectedDuration), 
            ("InAsrRack", InAsrRack), 
            ("InBusName", InBusName), 
            ("BusOutput", BusOutput)
        ];
        ProcessEvent(GetFunction("StartRecording"), @params);
    }
    public void PlayRecordedSound()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayRecordedSound"), @params);
    }
    public void PauseRecordedSound(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("PauseRecordedSound"), @params);
    }
    public void OnRecordingStarted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRecordingStarted__DelegateSignature"), @params);
    }
    public void OnRecordingFinished__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRecordingFinished__DelegateSignature"), @params);
    }
    public bool IsRecording()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsRecording"), @params);
    }
    public bool IsPlayingRecordedSound()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingRecordedSound"), @params);
    }
    public bool IsPausedRecordedSound()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPausedRecordedSound"), @params);
    }
    public void FinishRecording()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinishRecording"), @params);
    }
    public bool CanRecord()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CanRecord"), @params);
    }
    public bool CanPlayRecordedSound()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CanPlayRecordedSound"), @params);
    }
}

public unsafe class AtomCallback : ObjectBase<IAtomCallback>
{
    public AtomCallback(IntPtr pointer) : base(pointer) {}}

public unsafe class AtomCallbackManager : ObjectBase<UAtomCallbackManager>
{
    public AtomCallbackManager(IntPtr pointer) : base(pointer) {}
    public void NativeBreakAtomSequenceInfo(ref FAtomSequenceInfo SequenceInfo, ref float Time, ref FString TagName, ref EAtomSequenceEventType EventType, ref int CallbackID)
    {
        Span<(string name, object value)> @params = [
            ("SequenceInfo", SequenceInfo), 
            ("Time", Time), 
            ("TagName", TagName), 
            ("EventType", EventType), 
            ("CallbackID", CallbackID)
        ];
        ProcessEvent(GetFunction("NativeBreakAtomSequenceInfo"), @params);
    }
    public void NativeBreakAtomBeatSyncInfo(ref FAtomBeatSyncInfo BeatSyncInfo, ref int BarCnt, ref int BeatCnt, ref float BeatProgress, ref float Bpm, ref int Offset, ref int NumBeats)
    {
        Span<(string name, object value)> @params = [
            ("BeatSyncInfo", BeatSyncInfo), 
            ("BarCnt", BarCnt), 
            ("BeatCnt", BeatCnt), 
            ("BeatProgress", BeatProgress), 
            ("Bpm", Bpm), 
            ("Offset", Offset), 
            ("NumBeats", NumBeats)
        ];
        ProcessEvent(GetFunction("NativeBreakAtomBeatSyncInfo"), @params);
    }
}

public unsafe class AtomCategory : ObjectBase<UAtomCategory>
{
    public AtomCategory(IntPtr pointer) : base(pointer) {}
    public void StopByName(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        ProcessEvent(GetFunction("StopByName"), @params);
    }
    public void SetVolumeByName(FString CategoryName, float Volume)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName), 
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetVolumeByName"), @params);
    }
    public void SetAisacControlByName(FString CategoryName, FString AisacName, float Value)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName), 
            ("AisacName", AisacName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetAisacControlByName"), @params);
    }
    public bool ResetAllAisacControlByName(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        return ProcessEvent<bool>(GetFunction("ResetAllAisacControlByName"), @params);
    }
    public bool ResetAllAisacControlById(int CategoryID)
    {
        Span<(string name, object value)> @params = [
            ("CategoryID", CategoryID)
        ];
        return ProcessEvent<bool>(GetFunction("ResetAllAisacControlById"), @params);
    }
    public void PauseByName(FString CategoryName, bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName), 
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("PauseByName"), @params);
    }
    public bool IsPausedByName(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        return ProcessEvent<bool>(GetFunction("IsPausedByName"), @params);
    }
    public float GetVolumeByName(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        return ProcessEvent<float>(GetFunction("GetVolumeByName"), @params);
    }
    public int GetNumAttachedAisacsByName(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        return ProcessEvent<int>(GetFunction("GetNumAttachedAisacsByName"), @params);
    }
    public int GetNumAttachedAisacsById(int CategoryID)
    {
        Span<(string name, object value)> @params = [
            ("CategoryID", CategoryID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumAttachedAisacsById"), @params);
    }
    public float GetCurrentAisacControlValueByName(FString CategoryName, FString AisacControlName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName), 
            ("AisacControlName", AisacControlName)
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentAisacControlValueByName"), @params);
    }
    public float GetCurrentAisacControlValueById(int CategoryID, int AisacControlID)
    {
        Span<(string name, object value)> @params = [
            ("CategoryID", CategoryID), 
            ("AisacControlID", AisacControlID)
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentAisacControlValueById"), @params);
    }
    public void GetAttachedAisacInfoByName(FString CategoryName, int AisacAttachedIndex, ref bool IsSuccess, ref FAtomAisacInfo AisacInfo)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName), 
            ("AisacAttachedIndex", AisacAttachedIndex), 
            ("IsSuccess", IsSuccess), 
            ("AisacInfo", AisacInfo)
        ];
        ProcessEvent(GetFunction("GetAttachedAisacInfoByName"), @params);
    }
    public void GetAttachedAisacInfoById(int CategoryID, int AisacAttachedIndex, ref bool IsSuccess, ref FAtomAisacInfo AisacInfo)
    {
        Span<(string name, object value)> @params = [
            ("CategoryID", CategoryID), 
            ("AisacAttachedIndex", AisacAttachedIndex), 
            ("IsSuccess", IsSuccess), 
            ("AisacInfo", AisacInfo)
        ];
        ProcessEvent(GetFunction("GetAttachedAisacInfoById"), @params);
    }
}

public unsafe class AtomComponent : ObjectBase<UAtomComponent>
{
    public AtomComponent(IntPtr pointer) : base(pointer) {}
    public void StopWithoutReleaseTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopWithoutReleaseTime"), @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void SetVolume(float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetVolume"), @params);
    }
    public void SetSoundObject(UAtomSoundObject* InSoundObject)
    {
        Span<(string name, object value)> @params = [
            ("InSoundObject", (IntPtr)InSoundObject)
        ];
        ProcessEvent(GetFunction("SetSoundObject"), @params);
    }
    public void SetSound(USoundAtomCue* NewSound)
    {
        Span<(string name, object value)> @params = [
            ("NewSound", (IntPtr)NewSound)
        ];
        ProcessEvent(GetFunction("SetSound"), @params);
    }
    public void SetSelectorLabel(FString Selector, FString Label)
    {
        Span<(string name, object value)> @params = [
            ("Selector", Selector), 
            ("Label", Label)
        ];
        ProcessEvent(GetFunction("SetSelectorLabel"), @params);
    }
    public void SetRegion(UAtom3dRegion* InRegion)
    {
        Span<(string name, object value)> @params = [
            ("InRegion", (IntPtr)InRegion)
        ];
        ProcessEvent(GetFunction("SetRegion"), @params);
    }
    public void SetPitchMultiplier(float NewPitchMultiplier)
    {
        Span<(string name, object value)> @params = [
            ("NewPitchMultiplier", NewPitchMultiplier)
        ];
        ProcessEvent(GetFunction("SetPitchMultiplier"), @params);
    }
    public void SetPitch(float Pitch)
    {
        Span<(string name, object value)> @params = [
            ("Pitch", Pitch)
        ];
        ProcessEvent(GetFunction("SetPitch"), @params);
    }
    public void SetNextBlockIndex(int BlockIndex)
    {
        Span<(string name, object value)> @params = [
            ("BlockIndex", BlockIndex)
        ];
        ProcessEvent(GetFunction("SetNextBlockIndex"), @params);
    }
    public void SetDefaultAttenuationEnable(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetDefaultAttenuationEnable"), @params);
    }
    public void SetBusSendLevelOffsetByName(FString BusName, float LevelOffset)
    {
        Span<(string name, object value)> @params = [
            ("BusName", BusName), 
            ("LevelOffset", LevelOffset)
        ];
        ProcessEvent(GetFunction("SetBusSendLevelOffsetByName"), @params);
    }
    public void SetBusSendLevelOffset(int BusId, float LevelOffset)
    {
        Span<(string name, object value)> @params = [
            ("BusId", BusId), 
            ("LevelOffset", LevelOffset)
        ];
        ProcessEvent(GetFunction("SetBusSendLevelOffset"), @params);
    }
    public void SetBusSendLevelByName(FString BusName, float Level)
    {
        Span<(string name, object value)> @params = [
            ("BusName", BusName), 
            ("Level", Level)
        ];
        ProcessEvent(GetFunction("SetBusSendLevelByName"), @params);
    }
    public void SetBusSendLevel(int BusId, float Level)
    {
        Span<(string name, object value)> @params = [
            ("BusId", BusId), 
            ("Level", Level)
        ];
        ProcessEvent(GetFunction("SetBusSendLevel"), @params);
    }
    public void SetAsrRackIdArray(TArray<int> AsrRackIDs)
    {
        Span<(string name, object value)> @params = [
            ("AsrRackIDs", AsrRackIDs)
        ];
        ProcessEvent(GetFunction("SetAsrRackIdArray"), @params);
    }
    public void SetAsrRackID(int asr_rack_id)
    {
        Span<(string name, object value)> @params = [
            ("asr_rack_id", asr_rack_id)
        ];
        ProcessEvent(GetFunction("SetAsrRackID"), @params);
    }
    public void SetAisacByName(FString ControlName, float ControlValue)
    {
        Span<(string name, object value)> @params = [
            ("ControlName", ControlName), 
            ("ControlValue", ControlValue)
        ];
        ProcessEvent(GetFunction("SetAisacByName"), @params);
    }
    public void Play(float StartTime)
    {
        Span<(string name, object value)> @params = [
            ("StartTime", StartTime)
        ];
        ProcessEvent(GetFunction("Play"), @params);
    }
    public void Pause(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("Pause"), @params);
    }
    public void OnStatusChanged__DelegateSignature(EAtomComponentStatus Status, UAtomComponent* AtomComponent)
    {
        Span<(string name, object value)> @params = [
            ("Status", Status), 
            ("AtomComponent", (IntPtr)AtomComponent)
        ];
        ProcessEvent(GetFunction("OnStatusChanged__DelegateSignature"), @params);
    }
    public void OnAudioVolumeChanged__DelegateSignature(EAtomAudioVolumeType Type, AAtomAudioVolume* AtomAudioVolume, bool bIsCalledFromTick)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("AtomAudioVolume", (IntPtr)AtomAudioVolume), 
            ("bIsCalledFromTick", bIsCalledFromTick)
        ];
        ProcessEvent(GetFunction("OnAudioVolumeChanged__DelegateSignature"), @params);
    }
    public void OnAudioFinished__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnAudioFinished__DelegateSignature"), @params);
    }
    public bool IsReducingTickFrequency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReducingTickFrequency"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public bool IsLoop()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoop"), @params);
    }
    public bool HasBeenEconomicTick()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasBeenEconomicTick"), @params);
    }
    public float GetVolume()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetVolume"), @params);
    }
    public FVector GetVelocity()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetVelocity"), @params);
    }
    public float GetTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetTime"), @params);
    }
    public EAtomComponentStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAtomComponentStatus>(GetFunction("GetStatus"), @params);
    }
    public float GetSequencePosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSequencePosition"), @params);
    }
    public int GetNumQueuedSounds()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumQueuedSounds"), @params);
    }
    public float GetMaxAttenuationDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxAttenuationDistance"), @params);
    }
    public float GetEconomicTickFrequency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickFrequency"), @params);
    }
    public float GetEconomicTickDistanceMargin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickDistanceMargin"), @params);
    }
    public float GetEconomicTickDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickDistance"), @params);
    }
    public bool GetDefaultAttenuationEnable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetDefaultAttenuationEnable"), @params);
    }
    public float GetCurrentMaxAttenuationDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentMaxAttenuationDistance"), @params);
    }
    public float GetCurrentEconomicTickMarginDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentEconomicTickMarginDistance"), @params);
    }
    public float GetCurrentEconomicTickFrequency()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentEconomicTickFrequency"), @params);
    }
    public float GetCurrentEconomicTickBoundaryDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentEconomicTickBoundaryDistance"), @params);
    }
    public float GetCurrentCullingMarginDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentCullingMarginDistance"), @params);
    }
    public float GetCurrentCullingBoundaryDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentCullingBoundaryDistance"), @params);
    }
    public AAtomAudioVolume* GetCurrentBelongingAudioVolume(EAtomAudioVolumeType Type, bool IsNeighbor)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("IsNeighbor", IsNeighbor)
        ];
        return (AAtomAudioVolume*)ProcessEvent<IntPtr>(GetFunction("GetCurrentBelongingAudioVolume"), @params);
    }
    public float GetCullDistanceMargin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullDistanceMargin"), @params);
    }
    public float GetCullDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullDistance"), @params);
    }
    public FString GetCueName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetCueName"), @params);
    }
    public TMap<FString, float> GetAudioVolumeValueMap(EAtomAudioVolumeType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<TMap<FString, float>>(GetFunction("GetAudioVolumeValueMap"), @params);
    }
    public int GetAtomComponentID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetAtomComponentID"), @params);
    }
    public UAtomComponent* GetAtomComponentFromID(int TargetID)
    {
        Span<(string name, object value)> @params = [
            ("TargetID", TargetID)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("GetAtomComponentFromID"), @params);
    }
    public void FadeOut(float FadeOutDuration, float FadeVolumeLevel)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutDuration", FadeOutDuration), 
            ("FadeVolumeLevel", FadeVolumeLevel)
        ];
        ProcessEvent(GetFunction("FadeOut"), @params);
    }
    public void FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime)
    {
        Span<(string name, object value)> @params = [
            ("FadeInDuration", FadeInDuration), 
            ("FadeVolumeLevel", FadeVolumeLevel), 
            ("StartTime", StartTime)
        ];
        ProcessEvent(GetFunction("FadeIn"), @params);
    }
    public void EnqueueSound(USoundAtomCue* NewSound)
    {
        Span<(string name, object value)> @params = [
            ("NewSound", (IntPtr)NewSound)
        ];
        ProcessEvent(GetFunction("EnqueueSound"), @params);
    }
    public void DestroyComponentByID(int TargetID)
    {
        Span<(string name, object value)> @params = [
            ("TargetID", TargetID)
        ];
        ProcessEvent(GetFunction("DestroyComponentByID"), @params);
    }
    public void ClearSelectorLabels()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearSelectorLabels"), @params);
    }
    public bool BP_GetAttenuationSettingsToApply(ref FSoundAttenuationSettings OutAttenuationSettings)
    {
        Span<(string name, object value)> @params = [
            ("OutAttenuationSettings", OutAttenuationSettings)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetAttenuationSettingsToApply"), @params);
    }
    public void AttachAreaSoundVolume(AAtomAreaSoundVolume* sound_shape_volume)
    {
        Span<(string name, object value)> @params = [
            ("sound_shape_volume", (IntPtr)sound_shape_volume)
        ];
        ProcessEvent(GetFunction("AttachAreaSoundVolume"), @params);
    }
    public void AtomSequenceCallbackDelegate__DelegateSignature(UAtomComponent* AtomComponent, ref FAtomSequenceInfo SequenceInfo)
    {
        Span<(string name, object value)> @params = [
            ("AtomComponent", (IntPtr)AtomComponent), 
            ("SequenceInfo", SequenceInfo)
        ];
        ProcessEvent(GetFunction("AtomSequenceCallbackDelegate__DelegateSignature"), @params);
    }
    public void AtomBeatSyncCallbackDelegate__DelegateSignature(UAtomComponent* AtomComponent, ref FAtomBeatSyncInfo BeatSyncInfo)
    {
        Span<(string name, object value)> @params = [
            ("AtomComponent", (IntPtr)AtomComponent), 
            ("BeatSyncInfo", BeatSyncInfo)
        ];
        ProcessEvent(GetFunction("AtomBeatSyncCallbackDelegate__DelegateSignature"), @params);
    }
    public void AdjustAttenuation(ref FSoundAttenuationSettings InAttenuationSettings)
    {
        Span<(string name, object value)> @params = [
            ("InAttenuationSettings", InAttenuationSettings)
        ];
        ProcessEvent(GetFunction("AdjustAttenuation"), @params);
    }
}

public unsafe class AtomComponentPool : ObjectBase<UAtomComponentPool>
{
    public AtomComponentPool(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomCueSheetLoaderComponent : ObjectBase<UAtomCueSheetLoaderComponent>
{
    public AtomCueSheetLoaderComponent(IntPtr pointer) : base(pointer) {}
    public void OnLoadError__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadError__DelegateSignature"), @params);
    }
    public void OnLoadCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted__DelegateSignature"), @params);
    }
    public void OnAtomCueSheetLoaded__DelegateSignature(USoundAtomCueSheet* Loaded)
    {
        Span<(string name, object value)> @params = [
            ("Loaded", (IntPtr)Loaded)
        ];
        ProcessEvent(GetFunction("OnAtomCueSheetLoaded__DelegateSignature"), @params);
    }
    public void Load()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Load"), @params);
    }
    public EAtomCueSheetLoaderComponentStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAtomCueSheetLoaderComponentStatus>(GetFunction("GetStatus"), @params);
    }
    public USoundAtomCueSheet* GetAtomCueSheet()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USoundAtomCueSheet*)ProcessEvent<IntPtr>(GetFunction("GetAtomCueSheet"), @params);
    }
}

public unsafe class AtomDeviceWatcher : ObjectBase<UAtomDeviceWatcher>
{
    public AtomDeviceWatcher(IntPtr pointer) : base(pointer) {}
    public void OnDeviceUpdated__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnDeviceUpdated__DelegateSignature"), @params);
    }
    public EAtomDeviceType GetDeviceType(int ASRRackID)
    {
        Span<(string name, object value)> @params = [
            ("ASRRackID", ASRRackID)
        ];
        return ProcessEvent<EAtomDeviceType>(GetFunction("GetDeviceType"), @params);
    }
    public FString GetDeviceName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDeviceName"), @params);
    }
    public int GetDeviceChannelCount(int ASRRackID)
    {
        Span<(string name, object value)> @params = [
            ("ASRRackID", ASRRackID)
        ];
        return ProcessEvent<int>(GetFunction("GetDeviceChannelCount"), @params);
    }
}

public unsafe class AtomDisposer : ObjectBase<AAtomDisposer>
{
    public AtomDisposer(IntPtr pointer) : base(pointer) {}}

public unsafe class AtomListenerFocusPoint : ObjectBase<UAtomListenerFocusPoint>
{
    public AtomListenerFocusPoint(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomParameterComponent : ObjectBase<UAtomParameterComponent>
{
    public AtomParameterComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class Atom3dRegionHandle : ObjectBase<UAtom3dRegionHandle>
{
    public Atom3dRegionHandle(IntPtr pointer) : base(pointer) {}}

public unsafe class AtomProfileData : ObjectBase<UAtomProfileData>
{
    public AtomProfileData(IntPtr pointer) : base(pointer) {}
    public TArray<FAtomProfileItem> CriWareAdx2ProfileDataUpdate(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<TArray<FAtomProfileItem>>(GetFunction("CriWareAdx2ProfileDataUpdate"), @params);
    }
    public void CriWareAdx2ProfileDataSort(TArray<FAtomProfileItem> original_item, EAtomProfileSortType sort_type, EAtomSortOrderType order_type, ref TArray<FAtomProfileItem> sorted_item)
    {
        Span<(string name, object value)> @params = [
            ("original_item", original_item), 
            ("sort_type", sort_type), 
            ("order_type", order_type), 
            ("sorted_item", sorted_item)
        ];
        ProcessEvent(GetFunction("CriWareAdx2ProfileDataSort"), @params);
    }
}

public unsafe class AtomSound : ObjectBase<AAtomSound>
{
    public AtomSound(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomSoundData : ObjectBase<AAtomSoundData>
{
    public AtomSoundData(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomSoundObject : ObjectBase<UAtomSoundObject>
{
    public AtomSoundObject(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtomSpectrumAnalyzer : ObjectBase<UAtomSpectrumAnalyzer>
{
    public AtomSpectrumAnalyzer(IntPtr pointer) : base(pointer) {}
    public void GetLevelsDB(float display_range, ref TArray<float> spectra)
    {
        Span<(string name, object value)> @params = [
            ("display_range", display_range), 
            ("spectra", spectra)
        ];
        ProcessEvent(GetFunction("GetLevelsDB"), @params);
    }
    public void GetLevels(ref TArray<float> spectra)
    {
        Span<(string name, object value)> @params = [
            ("spectra", spectra)
        ];
        ProcessEvent(GetFunction("GetLevels"), @params);
    }
    public void CreateDspSpectra(UAtomAsrRack* asr_rack, FString bus_name, int num_bands)
    {
        Span<(string name, object value)> @params = [
            ("asr_rack", (IntPtr)asr_rack), 
            ("bus_name", bus_name), 
            ("num_bands", num_bands)
        ];
        ProcessEvent(GetFunction("CreateDspSpectra"), @params);
    }
}

public unsafe class AtomStatics : ObjectBase<UAtomStatics>
{
    public AtomStatics(IntPtr pointer) : base(pointer) {}
    public void UpdateDistanceFactorForAllSounds(float ArgDistanceFactor)
    {
        Span<(string name, object value)> @params = [
            ("ArgDistanceFactor", ArgDistanceFactor)
        ];
        ProcessEvent(GetFunction("UpdateDistanceFactorForAllSounds"), @params);
    }
    public void StopAllSoundsForKeyFromAtomComponentIds(UObject* AtomPlayGateRef, UObject* SkeltalMeshComponentRef)
    {
        Span<(string name, object value)> @params = [
            ("AtomPlayGateRef", (IntPtr)AtomPlayGateRef), 
            ("SkeltalMeshComponentRef", (IntPtr)SkeltalMeshComponentRef)
        ];
        ProcessEvent(GetFunction("StopAllSoundsForKeyFromAtomComponentIds"), @params);
    }
    public void StopAllSounds()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAllSounds"), @params);
    }
    public UAtomComponent* SpawnSoundAttached(USoundAtomCue* Sound, USceneComponent* AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation* AttenuationSettings, USoundConcurrency* ConcurrencySettings, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("Sound", (IntPtr)Sound), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("LocationType", LocationType), 
            ("bStopWhenAttachedToDestroyed", bStopWhenAttachedToDestroyed), 
            ("VolumeMultiplier", VolumeMultiplier), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("AttenuationSettings", (IntPtr)AttenuationSettings), 
            ("ConcurrencySettings", (IntPtr)ConcurrencySettings), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSoundAttached"), @params);
    }
    public UAtomComponent* SpawnSoundAtLocation(UObject* WorldContextObject, USoundAtomCue* Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation* AttenuationSettings, USoundConcurrency* ConcurrencySettings, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("VolumeMultiplier", VolumeMultiplier), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("AttenuationSettings", (IntPtr)AttenuationSettings), 
            ("ConcurrencySettings", (IntPtr)ConcurrencySettings), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSoundAtLocation"), @params);
    }
    public UAtomComponent* SpawnSound2D(UObject* WorldContextObject, USoundAtomCue* Sound, float PitchMultiplier, float StartTime, bool bPersistAcrossLevelTransition, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("bPersistAcrossLevelTransition", bPersistAcrossLevelTransition), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSound2D"), @params);
    }
    public UAtomComponent* SpawnAtomSoundAttachedByName(USoundAtomCueSheet* CueSheet, FString CueName, USceneComponent* AttachToComponent, ref FAtomComponentParams Params, FName AttachPointName, FVector Location, EAttachLocation LocationType, bool bStopWhenAttachedToDestroyed, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("CueSheet", (IntPtr)CueSheet), 
            ("CueName", CueName), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("Params", Params), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("LocationType", LocationType), 
            ("bStopWhenAttachedToDestroyed", bStopWhenAttachedToDestroyed), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSoundAttachedByName"), @params);
    }
    public UAtomComponent* SpawnAtomSoundAttached(USoundAtomCue* Sound, USceneComponent* AttachToComponent, ref FAtomComponentParams Params, FName AttachPointName, FVector Location, EAttachLocation LocationType, bool bStopWhenAttachedToDestroyed, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("Sound", (IntPtr)Sound), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("Params", Params), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("LocationType", LocationType), 
            ("bStopWhenAttachedToDestroyed", bStopWhenAttachedToDestroyed), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSoundAttached"), @params);
    }
    public UAtomComponent* SpawnAtomSoundAtLocationByName(UObject* WorldContextObject, USoundAtomCueSheet* CueSheet, FString CueName, FVector Location, ref FAtomComponentParams Params, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CueSheet", (IntPtr)CueSheet), 
            ("CueName", CueName), 
            ("Location", Location), 
            ("Params", Params), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSoundAtLocationByName"), @params);
    }
    public UAtomComponent* SpawnAtomSoundAtLocation(UObject* WorldContextObject, USoundAtomCue* Sound, FVector Location, ref FAtomComponentParams Params, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("Location", Location), 
            ("Params", Params), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSoundAtLocation"), @params);
    }
    public UAtomComponent* SpawnAtomSound2DByName(UObject* WorldContextObject, USoundAtomCueSheet* CueSheet, FString CueName, ref FAtomComponentParams Params, bool bPersistAcrossLevelTransition, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CueSheet", (IntPtr)CueSheet), 
            ("CueName", CueName), 
            ("Params", Params), 
            ("bPersistAcrossLevelTransition", bPersistAcrossLevelTransition), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSound2DByName"), @params);
    }
    public UAtomComponent* SpawnAtomSound2D(UObject* WorldContextObject, USoundAtomCue* Sound, ref FAtomComponentParams Params, bool bPersistAcrossLevelTransition, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("Params", Params), 
            ("bPersistAcrossLevelTransition", bPersistAcrossLevelTransition), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnAtomSound2D"), @params);
    }
    public void SetListenerRegion(UAtom3dRegion* Region, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("Region", (IntPtr)Region), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerRegion"), @params);
    }
    public void SetListenerFocusPointTargetComponent(USceneComponent* TargetComponent, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("TargetComponent", (IntPtr)TargetComponent), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerFocusPointTargetComponent"), @params);
    }
    public void SetListenerFocusPointTargetActor(AActor* TargetActor, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("TargetActor", (IntPtr)TargetActor), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerFocusPointTargetActor"), @params);
    }
    public void SetListenerFocusPointInfo(FAtomListenerFocusPointInfo FocusPointInfo, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("FocusPointInfo", FocusPointInfo), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerFocusPointInfo"), @params);
    }
    public void SetListenerFocusPointDistanceLevel(float DistanceLevel, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("DistanceLevel", DistanceLevel), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerFocusPointDistanceLevel"), @params);
    }
    public void SetListenerFocusPointDirectionLevel(float DirectionLevel, int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("DirectionLevel", DirectionLevel), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("SetListenerFocusPointDirectionLevel"), @params);
    }
    public void SetAtomGameVariable(FString GameVariableName, float Value)
    {
        Span<(string name, object value)> @params = [
            ("GameVariableName", GameVariableName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetAtomGameVariable"), @params);
    }
    public UAtomComponent* PlaySoundForAnimNotify(USoundAtomCue* Sound, USceneComponent* AttachToComponent, FName AttachPointName, FVector Location, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation* AttenuationSettings, bool bFollow)
    {
        Span<(string name, object value)> @params = [
            ("Sound", (IntPtr)Sound), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("bStopWhenAttachedToDestroyed", bStopWhenAttachedToDestroyed), 
            ("VolumeMultiplier", VolumeMultiplier), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("AttenuationSettings", (IntPtr)AttenuationSettings), 
            ("bFollow", bFollow)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("PlaySoundForAnimNotify"), @params);
    }
    public UAtomComponent* PlaySoundAttached(USoundAtomCue* Sound, USceneComponent* AttachToComponent, FName AttachPointName, FVector Location, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation* AttenuationSettings)
    {
        Span<(string name, object value)> @params = [
            ("Sound", (IntPtr)Sound), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("bStopWhenAttachedToDestroyed", bStopWhenAttachedToDestroyed), 
            ("VolumeMultiplier", VolumeMultiplier), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("AttenuationSettings", (IntPtr)AttenuationSettings)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("PlaySoundAttached"), @params);
    }
    public void PlaySoundAtLocation(UObject* WorldContextObject, USoundAtomCue* Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation* AttenuationSettings, USoundConcurrency* ConcurrencySettings)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("VolumeMultiplier", VolumeMultiplier), 
            ("PitchMultiplier", PitchMultiplier), 
            ("StartTime", StartTime), 
            ("AttenuationSettings", (IntPtr)AttenuationSettings), 
            ("ConcurrencySettings", (IntPtr)ConcurrencySettings)
        ];
        ProcessEvent(GetFunction("PlaySoundAtLocation"), @params);
    }
    public void PlayAtomSoundAtLocationByName(UObject* WorldContextObject, USoundAtomCueSheet* CueSheet, FString CueName, FVector Location, ref FAtomComponentParams Params)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CueSheet", (IntPtr)CueSheet), 
            ("CueName", CueName), 
            ("Location", Location), 
            ("Params", Params)
        ];
        ProcessEvent(GetFunction("PlayAtomSoundAtLocationByName"), @params);
    }
    public void PlayAtomSoundAtLocation(UObject* WorldContextObject, USoundAtomCue* Sound, FVector Location, ref FAtomComponentParams Params)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sound", (IntPtr)Sound), 
            ("Location", Location), 
            ("Params", Params)
        ];
        ProcessEvent(GetFunction("PlayAtomSoundAtLocation"), @params);
    }
    public void PauseAudioOutput(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("PauseAudioOutput"), @params);
    }
    public bool LoadAtomConfig(USoundAtomConfig* AcfObject)
    {
        Span<(string name, object value)> @params = [
            ("AcfObject", (IntPtr)AcfObject)
        ];
        return ProcessEvent<bool>(GetFunction("LoadAtomConfig"), @params);
    }
    public FVector GetListeningPoint(int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex)
        ];
        return ProcessEvent<FVector>(GetFunction("GetListeningPoint"), @params);
    }
    public UAtom3dRegion* GetListenerRegion(int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex)
        ];
        return (UAtom3dRegion*)ProcessEvent<IntPtr>(GetFunction("GetListenerRegion"), @params);
    }
    public FAtomListenerFocusPointInfo GetListenerFocusPointInfo(int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex)
        ];
        return ProcessEvent<FAtomListenerFocusPointInfo>(GetFunction("GetListenerFocusPointInfo"), @params);
    }
    public AAtomAudioVolume* GetAudioVolumeAffectingListener(int PlayerIndex, EAtomAudioVolumeType TypeNum)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("TypeNum", TypeNum)
        ];
        return (AAtomAudioVolume*)ProcessEvent<IntPtr>(GetFunction("GetAudioVolumeAffectingListener"), @params);
    }
    public float GetAtomGameVariable(FString GameVariableName)
    {
        Span<(string name, object value)> @params = [
            ("GameVariableName", GameVariableName)
        ];
        return ProcessEvent<float>(GetFunction("GetAtomGameVariable"), @params);
    }
    public UAtomComponent* CreateRootedAtomComponent(UObject* WorldContextObject, bool bAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("bAutoDestroy", bAutoDestroy)
        ];
        return (UAtomComponent*)ProcessEvent<IntPtr>(GetFunction("CreateRootedAtomComponent"), @params);
    }
    public void AddToAtomComponentIds(UObject* AtomPlayGateRef, UObject* SkeltalMeshComponentRef, int AtomComponentID)
    {
        Span<(string name, object value)> @params = [
            ("AtomPlayGateRef", (IntPtr)AtomPlayGateRef), 
            ("SkeltalMeshComponentRef", (IntPtr)SkeltalMeshComponentRef), 
            ("AtomComponentID", AtomComponentID)
        ];
        ProcessEvent(GetFunction("AddToAtomComponentIds"), @params);
    }
}

public unsafe class AtomTriggerTableFunctionLibrary : ObjectBase<UAtomTriggerTableFunctionLibrary>
{
    public AtomTriggerTableFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public bool GetDataTableRowFromName(UDataTable* Table, FName RowName, ref FAtomTriggerRow OutRow)
    {
        Span<(string name, object value)> @params = [
            ("Table", (IntPtr)Table), 
            ("RowName", RowName), 
            ("OutRow", OutRow)
        ];
        return ProcessEvent<bool>(GetFunction("GetDataTableRowFromName"), @params);
    }
}

public unsafe class AtomUnrealSoundRenderer : ObjectBase<UAtomUnrealSoundRenderer>
{
    public AtomUnrealSoundRenderer(IntPtr pointer) : base(pointer) {}}

public unsafe class AtomWavePlayer : ObjectBase<UAtomWavePlayer>
{
    public AtomWavePlayer(IntPtr pointer) : base(pointer) {}
    public void StopDelayed(float DelayTime)
    {
        Span<(string name, object value)> @params = [
            ("DelayTime", DelayTime)
        ];
        ProcessEvent(GetFunction("StopDelayed"), @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void SetWave(USoundAtomCue* InCue)
    {
        Span<(string name, object value)> @params = [
            ("InCue", (IntPtr)InCue)
        ];
        ProcessEvent(GetFunction("SetWave"), @params);
    }
    public void SetPaused(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("SetPaused"), @params);
    }
    public bool SetLooping(bool Looping)
    {
        Span<(string name, object value)> @params = [
            ("Looping", Looping)
        ];
        return ProcessEvent<bool>(GetFunction("SetLooping"), @params);
    }
    public void Play(float StartTime)
    {
        Span<(string name, object value)> @params = [
            ("StartTime", StartTime)
        ];
        ProcessEvent(GetFunction("Play"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public bool HasError()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasError"), @params);
    }
    public FAtomWaveInfo GetWaveInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FAtomWaveInfo>(GetFunction("GetWaveInfo"), @params);
    }
    public FTimespan GetTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetTime"), @params);
    }
    public EAtomWavePlayState GetPlayState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAtomWavePlayState>(GetFunction("GetPlayState"), @params);
    }
    public USoundAtomCue* GetCue()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USoundAtomCue*)ProcessEvent<IntPtr>(GetFunction("GetCue"), @params);
    }
    public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)
    {
        Span<(string name, object value)> @params = [
            ("AdjustVolumeDuration", AdjustVolumeDuration), 
            ("AdjustVolumeLevel", AdjustVolumeLevel)
        ];
        ProcessEvent(GetFunction("AdjustVolume"), @params);
    }
}

public unsafe class CriFsBinderComponent : ObjectBase<UCriFsBinderComponent>
{
    public CriFsBinderComponent(IntPtr pointer) : base(pointer) {}
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void OnBindError__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBindError__DelegateSignature"), @params);
    }
    public void OnBindCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBindCompleted__DelegateSignature"), @params);
    }
    public ECriFsBinderStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECriFsBinderStatus>(GetFunction("GetStatus"), @params);
    }
    public void Bind()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Bind"), @params);
    }
}

public unsafe class CriFsLoader : ObjectBase<ACriFsLoader>
{
    public CriFsLoader(IntPtr pointer) : base(pointer) {}
}

public unsafe class CriFsLoaderComponent : ObjectBase<UCriFsLoaderComponent>
{
    public CriFsLoaderComponent(IntPtr pointer) : base(pointer) {}
    public void OnLoadError__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadError__DelegateSignature"), @params);
    }
    public void OnLoadCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted__DelegateSignature"), @params);
    }
    public void Load()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Load"), @params);
    }
    public ECriFsLoaderStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECriFsLoaderStatus>(GetFunction("GetStatus"), @params);
    }
    public TArray<byte> GetDataArray()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<byte>>(GetFunction("GetDataArray"), @params);
    }
}

public unsafe class CriWareError : ObjectBase<UCriWareError>
{
    public CriWareError(IntPtr pointer) : base(pointer) {}
    public void OnCriWareError__DelegateSignature(ref FCriWareErrorInfo ErrorInfo)
    {
        Span<(string name, object value)> @params = [
            ("ErrorInfo", ErrorInfo)
        ];
        ProcessEvent(GetFunction("OnCriWareError__DelegateSignature"), @params);
    }
    public UCriWareError* GetCriWareError()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCriWareError*)ProcessEvent<IntPtr>(GetFunction("GetCriWareError"), @params);
    }
}

public unsafe class CriWareFunctionLibrary : ObjectBase<UCriWareFunctionLibrary>
{
    public CriWareFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public void SetSpeakerAngleArray(ECriWareSpeakerSystem SpeakerSystem, ref TArray<float> Angles)
    {
        Span<(string name, object value)> @params = [
            ("SpeakerSystem", SpeakerSystem), 
            ("Angles", Angles)
        ];
        ProcessEvent(GetFunction("SetSpeakerAngleArray"), @params);
    }
    public void SetGlobalLabelToSelectorByName(FString SelectorName, FString LabelName)
    {
        Span<(string name, object value)> @params = [
            ("SelectorName", SelectorName), 
            ("LabelName", LabelName)
        ];
        ProcessEvent(GetFunction("SetGlobalLabelToSelectorByName"), @params);
    }
    public void SetGameVariableByName(FString GameVariableName, float Value)
    {
        Span<(string name, object value)> @params = [
            ("GameVariableName", GameVariableName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetGameVariableByName"), @params);
    }
}

public unsafe class CriWareInitializer : ObjectBase<UCriWareInitializer>
{
    public CriWareInitializer(IntPtr pointer) : base(pointer) {}}

public unsafe class CriWarePluginSettings : ObjectBase<UCriWarePluginSettings>
{
    public CriWarePluginSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class ManaComponent : ObjectBase<UManaComponent>
{
    public ManaComponent(IntPtr pointer) : base(pointer) {}
    public bool ToIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("ToIndex"), @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void SetVolume(float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetVolume"), @params);
    }
    public void SetTexture(UManaTexture* Texture)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetTexture"), @params);
    }
    public void SetSubVolume(float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetSubVolume"), @params);
    }
    public void SetSubAudioTrack(int Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", Track)
        ];
        ProcessEvent(GetFunction("SetSubAudioTrack"), @params);
    }
    public void SetSubAudioSendLevel(int Channel, EAtomSpeakerID SpeakerId, float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Channel", Channel), 
            ("SpeakerId", SpeakerId), 
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetSubAudioSendLevel"), @params);
    }
    public void SetSubAudioCategory(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        ProcessEvent(GetFunction("SetSubAudioCategory"), @params);
    }
    public void SetPlaybackTimer(EManaPlaybackTimer InPlaybackTimer)
    {
        Span<(string name, object value)> @params = [
            ("InPlaybackTimer", InPlaybackTimer)
        ];
        ProcessEvent(GetFunction("SetPlaybackTimer"), @params);
    }
    public void SetMovie(UManaMovie* InMovie)
    {
        Span<(string name, object value)> @params = [
            ("InMovie", (IntPtr)InMovie)
        ];
        ProcessEvent(GetFunction("SetMovie"), @params);
    }
    public void SetMaxDropFrames(EManaMaxFrameDrop InMaxDropFrames)
    {
        Span<(string name, object value)> @params = [
            ("InMaxDropFrames", InMaxDropFrames)
        ];
        ProcessEvent(GetFunction("SetMaxDropFrames"), @params);
    }
    public void SetFile(FString MovieFilePath)
    {
        Span<(string name, object value)> @params = [
            ("MovieFilePath", MovieFilePath)
        ];
        ProcessEvent(GetFunction("SetFile"), @params);
    }
    public void SetExtraVolume(float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("SetExtraVolume"), @params);
    }
    public void SetExtraAudioTrack(int Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", Track)
        ];
        ProcessEvent(GetFunction("SetExtraAudioTrack"), @params);
    }
    public void SetExtraAudioCategory(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        ProcessEvent(GetFunction("SetExtraAudioCategory"), @params);
    }
    public void SetEndFrameAction(EManaFrameAction InFrameAction)
    {
        Span<(string name, object value)> @params = [
            ("InFrameAction", InFrameAction)
        ];
        ProcessEvent(GetFunction("SetEndFrameAction"), @params);
    }
    public void SetAudioTrack(int Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", Track)
        ];
        ProcessEvent(GetFunction("SetAudioTrack"), @params);
    }
    public void SetAudioCategory(FString CategoryName)
    {
        Span<(string name, object value)> @params = [
            ("CategoryName", CategoryName)
        ];
        ProcessEvent(GetFunction("SetAudioCategory"), @params);
    }
    public void SetAlphaTrack(int Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", Track)
        ];
        ProcessEvent(GetFunction("SetAlphaTrack"), @params);
    }
    public void SeekToPosition(int FrameNumber)
    {
        Span<(string name, object value)> @params = [
            ("FrameNumber", FrameNumber)
        ];
        ProcessEvent(GetFunction("SeekToPosition"), @params);
    }
    public void Seek(FTimespan Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("Seek"), @params);
    }
    public void RemoveSubAudioCategory()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveSubAudioCategory"), @params);
    }
    public void RemoveExtraAudioCategory()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveExtraAudioCategory"), @params);
    }
    public void RemoveAudioCategory()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveAudioCategory"), @params);
    }
    public bool Previous()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Previous"), @params);
    }
    public void PreparePlaylistIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("PreparePlaylistIndex"), @params);
    }
    public void Prepare()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Prepare"), @params);
    }
    public void Play()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Play"), @params);
    }
    public void Pause(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("Pause"), @params);
    }
    public void OnTrackChanged__DelegateSignature(int TrackNumber, UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("TrackNumber", TrackNumber), 
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnTrackChanged__DelegateSignature"), @params);
    }
    public void OnSubtitleChanged__DelegateSignature(FText Subtitle)
    {
        Span<(string name, object value)> @params = [
            ("Subtitle", Subtitle)
        ];
        ProcessEvent(GetFunction("OnSubtitleChanged__DelegateSignature"), @params);
    }
    public void OnStatusChanged__DelegateSignature(EManaComponentStatus Status, UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("Status", Status), 
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnStatusChanged__DelegateSignature"), @params);
    }
    public void OnSeekCompleted__DelegateSignature(int FrameNumber, UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("FrameNumber", FrameNumber), 
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnSeekCompleted__DelegateSignature"), @params);
    }
    public void OnRequestData__DelegateSignature(UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnRequestData__DelegateSignature"), @params);
    }
    public void OnPlayerDestroyed__DelegateSignature(UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnPlayerDestroyed__DelegateSignature"), @params);
    }
    public void OnMovieChanged__DelegateSignature(UManaMovie* Movie, UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("Movie", (IntPtr)Movie), 
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnMovieChanged__DelegateSignature"), @params);
    }
    public void OnFrameOnTime__DelegateSignature(int FrameNumber, UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("FrameNumber", FrameNumber), 
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("OnFrameOnTime__DelegateSignature"), @params);
    }
    public void OnEventPoint__DelegateSignature(FManaEventPointInfo EventPointInfo)
    {
        Span<(string name, object value)> @params = [
            ("EventPointInfo", EventPointInfo)
        ];
        ProcessEvent(GetFunction("OnEventPoint__DelegateSignature"), @params);
    }
    public bool Next()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Next"), @params);
    }
    public void Loop(bool bInLoop)
    {
        Span<(string name, object value)> @params = [
            ("bInLoop", bInLoop)
        ];
        ProcessEvent(GetFunction("Loop"), @params);
    }
    public bool IsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReady"), @params);
    }
    public bool IsPreparing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPreparing"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public float GetVolume()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetVolume"), @params);
    }
    public FTimespan GetTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetTime"), @params);
    }
    public UManaTexture* GetTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UManaTexture*)ProcessEvent<IntPtr>(GetFunction("GetTexture"), @params);
    }
    public float GetSubVolume()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSubVolume"), @params);
    }
    public EManaComponentStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EManaComponentStatus>(GetFunction("GetStatus"), @params);
    }
    public UManaMovie* GetSource()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("GetSource"), @params);
    }
    public int GetPosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPosition"), @params);
    }
    public FTimespan GetMovieTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetMovieTime"), @params);
    }
    public int GetFrameNumber()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFrameNumber"), @params);
    }
    public float GetExtraVolume()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetExtraVolume"), @params);
    }
    public void EnableSubtitles(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("EnableSubtitles"), @params);
    }
    public void EnableSeamless(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("EnableSeamless"), @params);
    }
    public void ChangeSubtitlesEncoding(EManaSubtitlesEncoding Encoding)
    {
        Span<(string name, object value)> @params = [
            ("Encoding", Encoding)
        ];
        ProcessEvent(GetFunction("ChangeSubtitlesEncoding"), @params);
    }
    public void ChangeSubtitlesChannel(int Channel)
    {
        Span<(string name, object value)> @params = [
            ("Channel", Channel)
        ];
        ProcessEvent(GetFunction("ChangeSubtitlesChannel"), @params);
    }
    public void AdvanceTime(FTimespan DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("AdvanceTime"), @params);
    }
}

public unsafe class StreamManaMovie : ObjectBase<UStreamManaMovie>
{
    public StreamManaMovie(IntPtr pointer) : base(pointer) {}
}

public unsafe class ManaSource : ObjectBase<UManaSource>
{
    public ManaSource(IntPtr pointer) : base(pointer) {}}

public unsafe class ManaComponentTexture : ObjectBase<UManaComponentTexture>
{
    public ManaComponentTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class ManaPlayer : ObjectBase<UManaPlayer>
{
    public ManaPlayer(IntPtr pointer) : base(pointer) {}
    public bool SetVolume(float Volume, EManaPlayerTrack TrackType)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume), 
            ("TrackType", TrackType)
        ];
        return ProcessEvent<bool>(GetFunction("SetVolume"), @params);
    }
    public void SetTimeSyncedSource(UAtomComponent* SyncedSource)
    {
        Span<(string name, object value)> @params = [
            ("SyncedSource", (IntPtr)SyncedSource)
        ];
        ProcessEvent(GetFunction("SetTimeSyncedSource"), @params);
    }
    public void SetTexture(UManaTexture* InManaTexture)
    {
        Span<(string name, object value)> @params = [
            ("InManaTexture", (IntPtr)InManaTexture)
        ];
        ProcessEvent(GetFunction("SetTexture"), @params);
    }
    public bool SetRate(float Rate)
    {
        Span<(string name, object value)> @params = [
            ("Rate", Rate)
        ];
        return ProcessEvent<bool>(GetFunction("SetRate"), @params);
    }
    public bool SetLooping(bool Looping)
    {
        Span<(string name, object value)> @params = [
            ("Looping", Looping)
        ];
        return ProcessEvent<bool>(GetFunction("SetLooping"), @params);
    }
    public bool SelectTrack(EManaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<bool>(GetFunction("SelectTrack"), @params);
    }
    public bool Seek(FTimespan Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        return ProcessEvent<bool>(GetFunction("Seek"), @params);
    }
    public bool Rewind()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Rewind"), @params);
    }
    public bool Reopen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Reopen"), @params);
    }
    public bool Previous()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Previous"), @params);
    }
    public void PlayAndSeek()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayAndSeek"), @params);
    }
    public bool Play()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Play"), @params);
    }
    public bool Pause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Pause"), @params);
    }
    public bool OpenSourceWithOptions(UManaSource* ManaSource, ref FManaPlayerOptions PlayerOptions)
    {
        Span<(string name, object value)> @params = [
            ("ManaSource", (IntPtr)ManaSource), 
            ("PlayerOptions", PlayerOptions)
        ];
        return ProcessEvent<bool>(GetFunction("OpenSourceWithOptions"), @params);
    }
    public bool OpenPlaylistIndex(UManaPlaylist* InPlaylist, int Index)
    {
        Span<(string name, object value)> @params = [
            ("InPlaylist", (IntPtr)InPlaylist), 
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("OpenPlaylistIndex"), @params);
    }
    public bool OpenPlaylist(UManaPlaylist* InPlaylist)
    {
        Span<(string name, object value)> @params = [
            ("InPlaylist", (IntPtr)InPlaylist)
        ];
        return ProcessEvent<bool>(GetFunction("OpenPlaylist"), @params);
    }
    public void OpenMovieSource(UManaMovie* InManaMovie)
    {
        Span<(string name, object value)> @params = [
            ("InManaMovie", (IntPtr)InManaMovie)
        ];
        ProcessEvent(GetFunction("OpenMovieSource"), @params);
    }
    public void OnFrameUpdatedDelegate__DelegateSignature(int FrameNumber)
    {
        Span<(string name, object value)> @params = [
            ("FrameNumber", FrameNumber)
        ];
        ProcessEvent(GetFunction("OnFrameUpdatedDelegate__DelegateSignature"), @params);
    }
    public bool Next()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Next"), @params);
    }
    public bool IsSeeking()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSeeking"), @params);
    }
    public bool IsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReady"), @params);
    }
    public bool IsPreparing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPreparing"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public bool IsClosed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsClosed"), @params);
    }
    public bool HasError()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasError"), @params);
    }
    public void HandleManaComponentStatusChanged(EManaComponentStatus Status, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("Status", Status), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("HandleManaComponentStatusChanged"), @params);
    }
    public void HandleManaComponentSeekCompleted(int InFrameNumber, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InFrameNumber", InFrameNumber), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("HandleManaComponentSeekCompleted"), @params);
    }
    public void HandleManaComponentPlayerDestroyed(UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("HandleManaComponentPlayerDestroyed"), @params);
    }
    public void HandleManaComponentMovieChanged(UManaMovie* InManaMovie, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InManaMovie", (IntPtr)InManaMovie), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("HandleManaComponentMovieChanged"), @params);
    }
    public void HandleManaComponentFrameOnTime(int InFrameNumber, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InFrameNumber", InFrameNumber), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("HandleManaComponentFrameOnTime"), @params);
    }
    public float GetVolume(EManaPlayerTrack TrackType)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType)
        ];
        return ProcessEvent<float>(GetFunction("GetVolume"), @params);
    }
    public FTimespan GetTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetTime"), @params);
    }
    public UManaTexture* GetTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UManaTexture*)ProcessEvent<IntPtr>(GetFunction("GetTexture"), @params);
    }
    public EManaComponentStatus GetStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EManaComponentStatus>(GetFunction("GetStatus"), @params);
    }
    public float GetRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRate"), @params);
    }
    public int GetPlaylistIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPlaylistIndex"), @params);
    }
    public FTimespan GetMovieTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetMovieTime"), @params);
    }
    public UManaMovie* GetMovieSource()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("GetMovieSource"), @params);
    }
    public int GetMovieFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMovieFrames"), @params);
    }
    public int GetFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFrames"), @params);
    }
    public FTimespan GetDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetDuration"), @params);
    }
    public bool DisableTrack(EManaPlayerTrack TrackType)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType)
        ];
        return ProcessEvent<bool>(GetFunction("DisableTrack"), @params);
    }
    public void Close()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Close"), @params);
    }
}

public unsafe class ManaPlaylist : ObjectBase<UManaPlaylist>
{
    public ManaPlaylist(IntPtr pointer) : base(pointer) {}
    public void RemoveAt(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("RemoveAt"), @params);
    }
    public void Remove(UManaMovie* ManaMovie)
    {
        Span<(string name, object value)> @params = [
            ("ManaMovie", (IntPtr)ManaMovie)
        ];
        ProcessEvent(GetFunction("Remove"), @params);
    }
    public int Num()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("Num"), @params);
    }
    public bool IsSeamless()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSeamless"), @params);
    }
    public bool IsMixedTypes()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsMixedTypes"), @params);
    }
    public bool IsAlpha()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAlpha"), @params);
    }
    public void Insert(UManaMovie* ManaMovie, int Index)
    {
        Span<(string name, object value)> @params = [
            ("ManaMovie", (IntPtr)ManaMovie), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("Insert"), @params);
    }
    public UManaMovie* GetRandom(ref int InOutIndex)
    {
        Span<(string name, object value)> @params = [
            ("InOutIndex", InOutIndex)
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("GetRandom"), @params);
    }
    public UManaMovie* GetPrevious(ref int InOutIndex)
    {
        Span<(string name, object value)> @params = [
            ("InOutIndex", InOutIndex)
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("GetPrevious"), @params);
    }
    public UManaMovie* GetNext(ref int InOutIndex)
    {
        Span<(string name, object value)> @params = [
            ("InOutIndex", InOutIndex)
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("GetNext"), @params);
    }
    public UManaMovie* Get(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UManaMovie*)ProcessEvent<IntPtr>(GetFunction("Get"), @params);
    }
    public void Add(UManaMovie* ManaMovie)
    {
        Span<(string name, object value)> @params = [
            ("ManaMovie", (IntPtr)ManaMovie)
        ];
        ProcessEvent(GetFunction("Add"), @params);
    }
}

public unsafe class ManaTexture : ObjectBase<UManaTexture>
{
    public ManaTexture(IntPtr pointer) : base(pointer) {}
    public void SetMovieSource(UManaSource* InSource)
    {
        Span<(string name, object value)> @params = [
            ("InSource", (IntPtr)InSource)
        ];
        ProcessEvent(GetFunction("SetMovieSource"), @params);
    }
    public void OnTextureUpdated__DelegateSignature(UManaTexture* ManaTexture)
    {
        Span<(string name, object value)> @params = [
            ("ManaTexture", (IntPtr)ManaTexture)
        ];
        ProcessEvent(GetFunction("OnTextureUpdated__DelegateSignature"), @params);
    }
}

public unsafe class MaterialExpressionManaColorSpaceConverter : ObjectBase<UMaterialExpressionManaColorSpaceConverter>
{
    public MaterialExpressionManaColorSpaceConverter(IntPtr pointer) : base(pointer) {}
}

public unsafe class MaterialExpressionManaMovieFormatSwitch : ObjectBase<UDEPRECATED_MaterialExpressionManaMovieFormatSwitch>
{
    public MaterialExpressionManaMovieFormatSwitch(IntPtr pointer) : base(pointer) {}
}

public unsafe class PlatformManaMovie : ObjectBase<UPlatformManaMovie>
{
    public PlatformManaMovie(IntPtr pointer) : base(pointer) {}
}

public unsafe class ManaMovie : ObjectBase<UManaMovie>
{
    public ManaMovie(IntPtr pointer) : base(pointer) {}
    public bool Validate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Validate"), @params);
    }
    public FString GetUrl()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetUrl"), @params);
    }
}

public unsafe class SoundAtomConfig : ObjectBase<USoundAtomConfig>
{
    public SoundAtomConfig(IntPtr pointer) : base(pointer) {}
    public TArray<FAtomCategoryInfoParam> GetCategoryInfoArray()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FAtomCategoryInfoParam>>(GetFunction("GetCategoryInfoArray"), @params);
    }
}

public unsafe class FileManaMovie : ObjectBase<UFileManaMovie>
{
    public FileManaMovie(IntPtr pointer) : base(pointer) {}
    public void SetFilePath(FString Path)
    {
        Span<(string name, object value)> @params = [
            ("Path", Path)
        ];
        ProcessEvent(GetFunction("SetFilePath"), @params);
    }
}

public unsafe class SoundAtomCue : ObjectBase<USoundAtomCue>
{
    public SoundAtomCue(IntPtr pointer) : base(pointer) {}
    public bool Validate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Validate"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public bool IsEconomicTickEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEconomicTickEnabled"), @params);
    }
    public float GetMaxAttenuationDistanceToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxAttenuationDistanceToUse"), @params);
    }
    public float GetMaxAttenuationDistanceToApply()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxAttenuationDistanceToApply"), @params);
    }
    public float GetEconomicTickMarginDistanceToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickMarginDistanceToUse"), @params);
    }
    public float GetEconomicTickFrequencyToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickFrequencyToUse"), @params);
    }
    public float GetEconomicTickFrequencyToApply()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickFrequencyToApply"), @params);
    }
    public float GetEconomicTickDistanceMarginToApply()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickDistanceMarginToApply"), @params);
    }
    public float GetEconomicTickDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickDistance"), @params);
    }
    public float GetEconomicTickBoundaryDistanceToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEconomicTickBoundaryDistanceToUse"), @params);
    }
    public float GetCullingMarginDistanceToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullingMarginDistanceToUse"), @params);
    }
    public float GetCullingBoundaryDistanceToUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullingBoundaryDistanceToUse"), @params);
    }
    public float GetCullDistanceMarginToApply()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullDistanceMarginToApply"), @params);
    }
    public float GetCullDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCullDistance"), @params);
    }
    public bool BP_GetCueInfo(ref FAtomCueInfo CueInfo)
    {
        Span<(string name, object value)> @params = [
            ("CueInfo", CueInfo)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetCueInfo"), @params);
    }
}

public unsafe class SoundAtomCueSheet : ObjectBase<USoundAtomCueSheet>
{
    public SoundAtomCueSheet(IntPtr pointer) : base(pointer) {}
    public void ReleaseAcb(FName AcbName)
    {
        Span<(string name, object value)> @params = [
            ("AcbName", AcbName)
        ];
        ProcessEvent(GetFunction("ReleaseAcb"), @params);
    }
    public USoundAtomCueSheet* LoadAtomCueSheet(USoundAtomCueSheet* CueSheet, bool bAddToLevel)
    {
        Span<(string name, object value)> @params = [
            ("CueSheet", (IntPtr)CueSheet), 
            ("bAddToLevel", bAddToLevel)
        ];
        return (USoundAtomCueSheet*)ProcessEvent<IntPtr>(GetFunction("LoadAtomCueSheet"), @params);
    }
    public USoundAtomCueSheet* LoadAcb(FName AcbName, bool bAddToLevel)
    {
        Span<(string name, object value)> @params = [
            ("AcbName", AcbName), 
            ("bAddToLevel", bAddToLevel)
        ];
        return (USoundAtomCueSheet*)ProcessEvent<IntPtr>(GetFunction("LoadAcb"), @params);
    }
    public bool IsLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoaded"), @params);
    }
    public int GetNumCues()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumCues"), @params);
    }
    public USoundAtomCue* GetAtomCueByName(FString CueName)
    {
        Span<(string name, object value)> @params = [
            ("CueName", CueName)
        ];
        return (USoundAtomCue*)ProcessEvent<IntPtr>(GetFunction("GetAtomCueByName"), @params);
    }
    public USoundAtomCue* GetAtomCueByIndex(int CueIndex)
    {
        Span<(string name, object value)> @params = [
            ("CueIndex", CueIndex)
        ];
        return (USoundAtomCue*)ProcessEvent<IntPtr>(GetFunction("GetAtomCueByIndex"), @params);
    }
    public USoundAtomCue* GetAtomCueById(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        return (USoundAtomCue*)ProcessEvent<IntPtr>(GetFunction("GetAtomCueById"), @params);
    }
    public void DetachDspBusSetting()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DetachDspBusSetting"), @params);
    }
    public bool BP_GetCueInfoFromName(FString Name, ref FAtomCueInfo CueInfo)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name), 
            ("CueInfo", CueInfo)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetCueInfoFromName"), @params);
    }
    public bool BP_GetCueInfoFromIndex(int Index, ref FAtomCueInfo CueInfo)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("CueInfo", CueInfo)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetCueInfoFromIndex"), @params);
    }
    public bool BP_GetCueInfoFromId(int ID, ref FAtomCueInfo CueInfo)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID), 
            ("CueInfo", CueInfo)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetCueInfoFromId"), @params);
    }
    public void AttachDspBusSetting(FString SettingName)
    {
        Span<(string name, object value)> @params = [
            ("SettingName", SettingName)
        ];
        ProcessEvent(GetFunction("AttachDspBusSetting"), @params);
    }
    public void ApplyDspBusSnapshot(FString SnapshotName, int Milliseconds)
    {
        Span<(string name, object value)> @params = [
            ("SnapshotName", SnapshotName), 
            ("Milliseconds", Milliseconds)
        ];
        ProcessEvent(GetFunction("ApplyDspBusSnapshot"), @params);
    }
}

public unsafe class DataManaMovie : ObjectBase<UDataManaMovie>
{
    public DataManaMovie(IntPtr pointer) : base(pointer) {}
    public void SetDataArray(ref TArray<byte> InDataArray)
    {
        Span<(string name, object value)> @params = [
            ("InDataArray", InDataArray)
        ];
        ProcessEvent(GetFunction("SetDataArray"), @params);
    }
    public TArray<byte> GetDataArray()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<byte>>(GetFunction("GetDataArray"), @params);
    }
}

