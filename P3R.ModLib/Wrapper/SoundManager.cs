using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AsyncCueSheetManager : ObjectBase<UAsyncCueSheetManager>
{
    public AsyncCueSheetManager(IntPtr pointer) : base(pointer) {}
    public void OnLoadFailed__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFailed__DelegateSignature"), @params);
    }
    public void OnLoadCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted__DelegateSignature"), @params);
    }
    public void LoadAsync(FSoftObjectPath PathForCueSheet)
    {
        Span<(string name, object value)> @params = [
            ("PathForCueSheet", PathForCueSheet)
        ];
        ProcessEvent(GetFunction("LoadAsync"), @params);
    }
    public USoundAtomCueSheet* GetAtomCueSheet()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USoundAtomCueSheet*)ProcessEvent<IntPtr>(GetFunction("GetAtomCueSheet"), @params);
    }
}

public unsafe class LiveLipSync : ObjectBase<ULiveLipSync>
{
    public LiveLipSync(IntPtr pointer) : base(pointer) {}
    public FCriLipsMorphTargetBlendAmountAsJapanese getLipsyncLiveJapanese()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FCriLipsMorphTargetBlendAmountAsJapanese>(GetFunction("getLipsyncLiveJapanese"), @params);
    }
    public FCriLipsMouthInfo getLipsyncLiveInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FCriLipsMouthInfo>(GetFunction("getLipsyncLiveInfo"), @params);
    }
    public bool detachSoundManager(int majNum, int minNum)
    {
        Span<(string name, object value)> @params = [
            ("majNum", majNum), 
            ("minNum", minNum)
        ];
        return ProcessEvent<bool>(GetFunction("detachSoundManager"), @params);
    }
    public bool attachSoundManager(int majNum, int minNum)
    {
        Span<(string name, object value)> @params = [
            ("majNum", majNum), 
            ("minNum", minNum)
        ];
        return ProcessEvent<bool>(GetFunction("attachSoundManager"), @params);
    }
}

public unsafe class PlayerControlBlock : ObjectBase<UPlayerControlBlock>
{
    public PlayerControlBlock(IntPtr pointer) : base(pointer) {}
}

public unsafe class AcbFileControlBlock : ObjectBase<UAcbFileControlBlock>
{
    public AcbFileControlBlock(IntPtr pointer) : base(pointer) {}
}

public unsafe class PlayAdxControl : ObjectBase<UPlayAdxControl>
{
    public PlayAdxControl(IntPtr pointer) : base(pointer) {}
    public void stopSound_IMD(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        ProcessEvent(GetFunction("stopSound_IMD"), @params);
    }
    public void stopSound(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        ProcessEvent(GetFunction("stopSound"), @params);
    }
    public void setPlayerAcbBank(int PlayerMajorID, int PlayerMinorID, EPlayerType Type, int bankID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("Type", Type), 
            ("bankID", bankID)
        ];
        ProcessEvent(GetFunction("setPlayerAcbBank"), @params);
    }
    public void resetLoudness()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("resetLoudness"), @params);
    }
    public void requestSound(int PlayerMajorID, int PlayerMinorID, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("requestSound"), @params);
    }
    public int requestLoadAcb(FString Filename)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename)
        ];
        return ProcessEvent<int>(GetFunction("requestLoadAcb"), @params);
    }
    public void requestFreeAcb(int bankID)
    {
        Span<(string name, object value)> @params = [
            ("bankID", bankID)
        ];
        ProcessEvent(GetFunction("requestFreeAcb"), @params);
    }
    public void releasePlayerBank(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        ProcessEvent(GetFunction("releasePlayerBank"), @params);
    }
    public void pauseSound(int PlayerMajorID, int PlayerMinorID, bool flag)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("pauseSound"), @params);
    }
    public bool IsLoop(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        return ProcessEvent<bool>(GetFunction("IsLoop"), @params);
    }
    public float GetTime(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        return ProcessEvent<float>(GetFunction("GetTime"), @params);
    }
    public float getShortLoudness()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("getShortLoudness"), @params);
    }
    public int getNumCuePlayingCountByName(FString Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return ProcessEvent<int>(GetFunction("getNumCuePlayingCountByName"), @params);
    }
    public float getMomentaryLoudness()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("getMomentaryLoudness"), @params);
    }
    public FCriLipsMorphTargetBlendAmountAsJapanese getLipsyncLiveJapanese(int majorNum, int minorNum)
    {
        Span<(string name, object value)> @params = [
            ("majorNum", majorNum), 
            ("minorNum", minorNum)
        ];
        return ProcessEvent<FCriLipsMorphTargetBlendAmountAsJapanese>(GetFunction("getLipsyncLiveJapanese"), @params);
    }
    public FCriLipsMouthInfo getLipsyncLiveInfo(int majorNum, int minorNum)
    {
        Span<(string name, object value)> @params = [
            ("majorNum", majorNum), 
            ("minorNum", minorNum)
        ];
        return ProcessEvent<FCriLipsMouthInfo>(GetFunction("getLipsyncLiveInfo"), @params);
    }
    public long getLengthSoundBank(int bankID, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("bankID", bankID), 
            ("CueId", CueId)
        ];
        return ProcessEvent<long>(GetFunction("getLengthSoundBank"), @params);
    }
    public long getLengthPlayerBank(int majorNum, int minorNum, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("majorNum", majorNum), 
            ("minorNum", minorNum), 
            ("CueId", CueId)
        ];
        return ProcessEvent<long>(GetFunction("getLengthPlayerBank"), @params);
    }
    public float getIntegratedLoudness()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("getIntegratedLoudness"), @params);
    }
    public void fadeOutSndMng(int PlayerMajorID, int PlayerMinorID, int fadeOutTime)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("fadeOutTime", fadeOutTime)
        ];
        ProcessEvent(GetFunction("fadeOutSndMng"), @params);
    }
    public bool fadeOutBGMCategorySoundManager(int fadeOutTime, float fadeOutVolume)
    {
        Span<(string name, object value)> @params = [
            ("fadeOutTime", fadeOutTime), 
            ("fadeOutVolume", fadeOutVolume)
        ];
        return ProcessEvent<bool>(GetFunction("fadeOutBGMCategorySoundManager"), @params);
    }
    public void fadeInSndMng(int PlayerMajorID, int PlayerMinorID, int fadeInTime)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("fadeInTime", fadeInTime)
        ];
        ProcessEvent(GetFunction("fadeInSndMng"), @params);
    }
    public bool fadeInBGMCategorySoundmanager(int fadeInTime, float fadeInVolume)
    {
        Span<(string name, object value)> @params = [
            ("fadeInTime", fadeInTime), 
            ("fadeInVolume", fadeInVolume)
        ];
        return ProcessEvent<bool>(GetFunction("fadeInBGMCategorySoundmanager"), @params);
    }
    public bool detachLipsyncLive(int majorNum, int minorNum)
    {
        Span<(string name, object value)> @params = [
            ("majorNum", majorNum), 
            ("minorNum", minorNum)
        ];
        return ProcessEvent<bool>(GetFunction("detachLipsyncLive"), @params);
    }
    public int createPlayerBank(int PlayerMajorID, int PlayerMinorID, bool isMulti)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("isMulti", isMulti)
        ];
        return ProcessEvent<int>(GetFunction("createPlayerBank"), @params);
    }
    public bool checkReadEnd(int bankID)
    {
        Span<(string name, object value)> @params = [
            ("bankID", bankID)
        ];
        return ProcessEvent<bool>(GetFunction("checkReadEnd"), @params);
    }
    public int checkReadAcb(FString Filename)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename)
        ];
        return ProcessEvent<int>(GetFunction("checkReadAcb"), @params);
    }
    public bool checkPlaying(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        return ProcessEvent<bool>(GetFunction("checkPlaying"), @params);
    }
    public bool checkPauseSound(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        return ProcessEvent<bool>(GetFunction("checkPauseSound"), @params);
    }
    public bool attachLipsyncLive(int majorNum, int minorNum)
    {
        Span<(string name, object value)> @params = [
            ("majorNum", majorNum), 
            ("minorNum", minorNum)
        ];
        return ProcessEvent<bool>(GetFunction("attachLipsyncLive"), @params);
    }
}

public unsafe class ACBLoadObject : ObjectBase<UACBLoadObject>
{
    public ACBLoadObject(IntPtr pointer) : base(pointer) {}
    public void OnLoadFailed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFailed"), @params);
    }
    public void OnLoadCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted"), @params);
    }
}

public unsafe class SoundManagerReadyAsyncFunction : ObjectBase<USoundManagerReadyAsyncFunction>
{
    public SoundManagerReadyAsyncFunction(IntPtr pointer) : base(pointer) {}
    public USoundManagerReadyAsyncFunction* SoundManagerReadyAsync(UObject* WorldContextObject, UPlayAdxControl* Control, int bankID)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Control", (IntPtr)Control), 
            ("bankID", bankID)
        ];
        return (USoundManagerReadyAsyncFunction*)ProcessEvent<IntPtr>(GetFunction("SoundManagerReadyAsyncFunction"), @params);
    }
}

public unsafe class SoundManagerGameInstanceSubSystem : ObjectBase<USoundManagerGameInstanceSubSystem>
{
    public SoundManagerGameInstanceSubSystem(IntPtr pointer) : base(pointer) {}
    public UPlayAdxControl* GetPlayAdxControl()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPlayAdxControl*)ProcessEvent<IntPtr>(GetFunction("GetPlayAdxControl"), @params);
    }
}

