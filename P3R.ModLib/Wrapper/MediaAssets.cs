using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MediaSource : ObjectBase<UMediaSource>
{

    public bool Validate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Validate"),  @params);
    }
    public void SetMediaOptionString(ref FName Key, FString Value)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetMediaOptionString"),  @params);
    }
    public void SetMediaOptionInt64(ref FName Key, long Value)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetMediaOptionInt64"),  @params);
    }
    public void SetMediaOptionFloat(ref FName Key, float Value)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetMediaOptionFloat"),  @params);
    }
    public void SetMediaOptionBool(ref FName Key, bool Value)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetMediaOptionBool"),  @params);
    }
    public FString GetUrl()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetUrl"),  @params);
    }
}

public unsafe class BaseMediaSource : ObjectBase<UBaseMediaSource>
{

}

public unsafe class FileMediaSource : ObjectBase<UFileMediaSource>
{

    public void SetFilePath(FString Path)
    {
        Span<(string name, object value)> @params = [
            ("Path", Path)
        ];
        ProcessEvent(GetFunction("SetFilePath"),  @params);
    }
}

public unsafe class MediaCaptureDevice : ObjectBase<FMediaCaptureDevice>
{

}

public unsafe class MediaBlueprintFunctionLibrary : ObjectBase<UMediaBlueprintFunctionLibrary>
{

    public void EnumerateWebcamCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter)
    {
        Span<(string name, object value)> @params = [
            ("OutDevices", OutDevices), 
            ("Filter", Filter)
        ];
        ProcessEvent(GetFunction("EnumerateWebcamCaptureDevices"),  @params);
    }
    public void EnumerateVideoCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter)
    {
        Span<(string name, object value)> @params = [
            ("OutDevices", OutDevices), 
            ("Filter", Filter)
        ];
        ProcessEvent(GetFunction("EnumerateVideoCaptureDevices"),  @params);
    }
    public void EnumerateAudioCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter)
    {
        Span<(string name, object value)> @params = [
            ("OutDevices", OutDevices), 
            ("Filter", Filter)
        ];
        ProcessEvent(GetFunction("EnumerateAudioCaptureDevices"),  @params);
    }
}

public unsafe class MediaComponent : ObjectBase<UMediaComponent>
{

    public UMediaTexture* GetMediaTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaTexture*)ProcessEvent<IntPtr>(GetFunction("GetMediaTexture"),  @params);
    }
    public UMediaPlayer* GetMediaPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaPlayer*)ProcessEvent<IntPtr>(GetFunction("GetMediaPlayer"),  @params);
    }
}

public unsafe class MediaTimeStampInfo : ObjectBase<UMediaTimeStampInfo>
{

}

public unsafe class MediaPlayer : ObjectBase<UMediaPlayer>
{

    public bool SupportsSeeking()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SupportsSeeking"),  @params);
    }
    public bool SupportsScrubbing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SupportsScrubbing"),  @params);
    }
    public bool SupportsRate(float Rate, bool Unthinned)
    {
        Span<(string name, object value)> @params = [
            ("Rate", Rate), 
            ("Unthinned", Unthinned)
        ];
        return ProcessEvent<bool>(GetFunction("SupportsRate"),  @params);
    }
    public bool SetViewRotation(ref FRotator Rotation, bool Absolute)
    {
        Span<(string name, object value)> @params = [
            ("Rotation", Rotation), 
            ("Absolute", Absolute)
        ];
        return ProcessEvent<bool>(GetFunction("SetViewRotation"),  @params);
    }
    public bool SetViewField(float Horizontal, float Vertical, bool Absolute)
    {
        Span<(string name, object value)> @params = [
            ("Horizontal", Horizontal), 
            ("Vertical", Vertical), 
            ("Absolute", Absolute)
        ];
        return ProcessEvent<bool>(GetFunction("SetViewField"),  @params);
    }
    public bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex), 
            ("FrameRate", FrameRate)
        ];
        return ProcessEvent<bool>(GetFunction("SetVideoTrackFrameRate"),  @params);
    }
    public bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<bool>(GetFunction("SetTrackFormat"),  @params);
    }
    public void SetTimeDelay(FTimespan TimeDelay)
    {
        Span<(string name, object value)> @params = [
            ("TimeDelay", TimeDelay)
        ];
        ProcessEvent(GetFunction("SetTimeDelay"),  @params);
    }
    public bool SetRate(float Rate)
    {
        Span<(string name, object value)> @params = [
            ("Rate", Rate)
        ];
        return ProcessEvent<bool>(GetFunction("SetRate"),  @params);
    }
    public bool SetNativeVolume(float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Volume", Volume)
        ];
        return ProcessEvent<bool>(GetFunction("SetNativeVolume"),  @params);
    }
    public void SetMediaOptions(UMediaSource* Options)
    {
        Span<(string name, object value)> @params = [
            ("Options", (IntPtr)Options)
        ];
        ProcessEvent(GetFunction("SetMediaOptions"),  @params);
    }
    public bool SetLooping(bool Looping)
    {
        Span<(string name, object value)> @params = [
            ("Looping", Looping)
        ];
        return ProcessEvent<bool>(GetFunction("SetLooping"),  @params);
    }
    public void SetDesiredPlayerName(FName PlayerName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerName", PlayerName)
        ];
        ProcessEvent(GetFunction("SetDesiredPlayerName"),  @params);
    }
    public void SetBlockOnTime(ref FTimespan Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("SetBlockOnTime"),  @params);
    }
    public bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<bool>(GetFunction("SelectTrack"),  @params);
    }
    public bool Seek(ref FTimespan Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        return ProcessEvent<bool>(GetFunction("Seek"),  @params);
    }
    public bool Rewind()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Rewind"),  @params);
    }
    public bool Reopen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Reopen"),  @params);
    }
    public bool Previous()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Previous"),  @params);
    }
    public void PlayAndSeek()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayAndSeek"),  @params);
    }
    public bool Play()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Play"),  @params);
    }
    public bool Pause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Pause"),  @params);
    }
    public bool OpenUrl(FString URL)
    {
        Span<(string name, object value)> @params = [
            ("URL", URL)
        ];
        return ProcessEvent<bool>(GetFunction("OpenUrl"),  @params);
    }
    public bool OpenSourceWithOptions(UMediaSource* MediaSource, ref FMediaPlayerOptions Options)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource), 
            ("Options", Options)
        ];
        return ProcessEvent<bool>(GetFunction("OpenSourceWithOptions"),  @params);
    }
    public void OpenSourceLatent(UObject* WorldContextObject, FLatentActionInfo LatentInfo, UMediaSource* MediaSource, ref FMediaPlayerOptions Options, ref bool bSuccess)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo), 
            ("MediaSource", (IntPtr)MediaSource), 
            ("Options", Options), 
            ("bSuccess", bSuccess)
        ];
        ProcessEvent(GetFunction("OpenSourceLatent"),  @params);
    }
    public bool OpenSource(UMediaSource* MediaSource)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource)
        ];
        return ProcessEvent<bool>(GetFunction("OpenSource"),  @params);
    }
    public bool OpenPlaylistIndex(UMediaPlaylist* InPlaylist, int Index)
    {
        Span<(string name, object value)> @params = [
            ("InPlaylist", (IntPtr)InPlaylist), 
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("OpenPlaylistIndex"),  @params);
    }
    public bool OpenPlaylist(UMediaPlaylist* InPlaylist)
    {
        Span<(string name, object value)> @params = [
            ("InPlaylist", (IntPtr)InPlaylist)
        ];
        return ProcessEvent<bool>(GetFunction("OpenPlaylist"),  @params);
    }
    public bool OpenFile(FString FilePath)
    {
        Span<(string name, object value)> @params = [
            ("FilePath", FilePath)
        ];
        return ProcessEvent<bool>(GetFunction("OpenFile"),  @params);
    }
    public bool Next()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Next"),  @params);
    }
    public bool IsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReady"),  @params);
    }
    public bool IsPreparing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPreparing"),  @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"),  @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"),  @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"),  @params);
    }
    public bool IsConnecting()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsConnecting"),  @params);
    }
    public bool IsClosed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsClosed"),  @params);
    }
    public bool IsBuffering()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBuffering"),  @params);
    }
    public bool HasError()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasError"),  @params);
    }
    public FRotator GetViewRotation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FRotator>(GetFunction("GetViewRotation"),  @params);
    }
    public FString GetVideoTrackType(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<FString>(GetFunction("GetVideoTrackType"),  @params);
    }
    public FFloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<FFloatRange>(GetFunction("GetVideoTrackFrameRates"),  @params);
    }
    public float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<float>(GetFunction("GetVideoTrackFrameRate"),  @params);
    }
    public FIntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<FIntPoint>(GetFunction("GetVideoTrackDimensions"),  @params);
    }
    public float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<float>(GetFunction("GetVideoTrackAspectRatio"),  @params);
    }
    public float GetVerticalFieldOfView()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetVerticalFieldOfView"),  @params);
    }
    public FString GetUrl()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetUrl"),  @params);
    }
    public FString GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<FString>(GetFunction("GetTrackLanguage"),  @params);
    }
    public int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<int>(GetFunction("GetTrackFormat"),  @params);
    }
    public FText GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<FText>(GetFunction("GetTrackDisplayName"),  @params);
    }
    public UMediaTimeStampInfo* GetTimeStamp()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaTimeStampInfo*)ProcessEvent<IntPtr>(GetFunction("GetTimeStamp"),  @params);
    }
    public FTimespan GetTimeDelay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetTimeDelay"),  @params);
    }
    public FTimespan GetTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetTime"),  @params);
    }
    public void GetSupportedRates(ref TArray<FFloatRange> OutRates, bool Unthinned)
    {
        Span<(string name, object value)> @params = [
            ("OutRates", OutRates), 
            ("Unthinned", Unthinned)
        ];
        ProcessEvent(GetFunction("GetSupportedRates"),  @params);
    }
    public int GetSelectedTrack(EMediaPlayerTrack TrackType)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType)
        ];
        return ProcessEvent<int>(GetFunction("GetSelectedTrack"),  @params);
    }
    public float GetRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRate"),  @params);
    }
    public int GetPlaylistIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPlaylistIndex"),  @params);
    }
    public UMediaPlaylist* GetPlaylist()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaPlaylist*)ProcessEvent<IntPtr>(GetFunction("GetPlaylist"),  @params);
    }
    public FName GetPlayerName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetPlayerName"),  @params);
    }
    public int GetNumTracks(EMediaPlayerTrack TrackType)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType)
        ];
        return ProcessEvent<int>(GetFunction("GetNumTracks"),  @params);
    }
    public int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackType", TrackType), 
            ("TrackIndex", TrackIndex)
        ];
        return ProcessEvent<int>(GetFunction("GetNumTrackFormats"),  @params);
    }
    public FText GetMediaName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetMediaName"),  @params);
    }
    public float GetHorizontalFieldOfView()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetHorizontalFieldOfView"),  @params);
    }
    public FTimespan GetDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimespan>(GetFunction("GetDuration"),  @params);
    }
    public FName GetDesiredPlayerName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetDesiredPlayerName"),  @params);
    }
    public FString GetAudioTrackType(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<FString>(GetFunction("GetAudioTrackType"),  @params);
    }
    public int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<int>(GetFunction("GetAudioTrackSampleRate"),  @params);
    }
    public int GetAudioTrackChannels(int TrackIndex, int FormatIndex)
    {
        Span<(string name, object value)> @params = [
            ("TrackIndex", TrackIndex), 
            ("FormatIndex", FormatIndex)
        ];
        return ProcessEvent<int>(GetFunction("GetAudioTrackChannels"),  @params);
    }
    public void Close()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Close"),  @params);
    }
    public bool CanPlayUrl(FString URL)
    {
        Span<(string name, object value)> @params = [
            ("URL", URL)
        ];
        return ProcessEvent<bool>(GetFunction("CanPlayUrl"),  @params);
    }
    public bool CanPlaySource(UMediaSource* MediaSource)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource)
        ];
        return ProcessEvent<bool>(GetFunction("CanPlaySource"),  @params);
    }
    public bool CanPause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CanPause"),  @params);
    }
}

public unsafe class MediaPlaylist : ObjectBase<UMediaPlaylist>
{

    public bool Replace(int Index, UMediaSource* Replacement)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Replacement", (IntPtr)Replacement)
        ];
        return ProcessEvent<bool>(GetFunction("Replace"),  @params);
    }
    public bool RemoveAt(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveAt"),  @params);
    }
    public bool Remove(UMediaSource* MediaSource)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource)
        ];
        return ProcessEvent<bool>(GetFunction("Remove"),  @params);
    }
    public int Num()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("Num"),  @params);
    }
    public void Insert(UMediaSource* MediaSource, int Index)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("Insert"),  @params);
    }
    public UMediaSource* GetRandom(ref int OutIndex)
    {
        Span<(string name, object value)> @params = [
            ("OutIndex", OutIndex)
        ];
        return (UMediaSource*)ProcessEvent<IntPtr>(GetFunction("GetRandom"),  @params);
    }
    public UMediaSource* GetPrevious(ref int InOutIndex)
    {
        Span<(string name, object value)> @params = [
            ("InOutIndex", InOutIndex)
        ];
        return (UMediaSource*)ProcessEvent<IntPtr>(GetFunction("GetPrevious"),  @params);
    }
    public UMediaSource* GetNext(ref int InOutIndex)
    {
        Span<(string name, object value)> @params = [
            ("InOutIndex", InOutIndex)
        ];
        return (UMediaSource*)ProcessEvent<IntPtr>(GetFunction("GetNext"),  @params);
    }
    public UMediaSource* Get(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UMediaSource*)ProcessEvent<IntPtr>(GetFunction("Get"),  @params);
    }
    public bool AddUrl(FString URL)
    {
        Span<(string name, object value)> @params = [
            ("URL", URL)
        ];
        return ProcessEvent<bool>(GetFunction("AddUrl"),  @params);
    }
    public bool AddFile(FString FilePath)
    {
        Span<(string name, object value)> @params = [
            ("FilePath", FilePath)
        ];
        return ProcessEvent<bool>(GetFunction("AddFile"),  @params);
    }
    public bool Add(UMediaSource* MediaSource)
    {
        Span<(string name, object value)> @params = [
            ("MediaSource", (IntPtr)MediaSource)
        ];
        return ProcessEvent<bool>(GetFunction("Add"),  @params);
    }
}

public unsafe class MediaSoundComponentSpectralData : ObjectBase<FMediaSoundComponentSpectralData>
{

}

public unsafe class MediaSoundComponent : ObjectBase<UMediaSoundComponent>
{

    public void SetSpectralAnalysisSettings(TArray<float> InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize)
    {
        Span<(string name, object value)> @params = [
            ("InFrequenciesToAnalyze", InFrequenciesToAnalyze), 
            ("InFFTSize", InFFTSize)
        ];
        ProcessEvent(GetFunction("SetSpectralAnalysisSettings"),  @params);
    }
    public void SetMediaPlayer(UMediaPlayer* NewMediaPlayer)
    {
        Span<(string name, object value)> @params = [
            ("NewMediaPlayer", (IntPtr)NewMediaPlayer)
        ];
        ProcessEvent(GetFunction("SetMediaPlayer"),  @params);
    }
    public void SetEnvelopeFollowingsettings(int AttackTimeMsec, int ReleaseTimeMsec)
    {
        Span<(string name, object value)> @params = [
            ("AttackTimeMsec", AttackTimeMsec), 
            ("ReleaseTimeMsec", ReleaseTimeMsec)
        ];
        ProcessEvent(GetFunction("SetEnvelopeFollowingsettings"),  @params);
    }
    public void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bInSpectralAnalysisEnabled", bInSpectralAnalysisEnabled)
        ];
        ProcessEvent(GetFunction("SetEnableSpectralAnalysis"),  @params);
    }
    public void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing)
    {
        Span<(string name, object value)> @params = [
            ("bInEnvelopeFollowing", bInEnvelopeFollowing)
        ];
        ProcessEvent(GetFunction("SetEnableEnvelopeFollowing"),  @params);
    }
    public TArray<FMediaSoundComponentSpectralData> GetSpectralData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FMediaSoundComponentSpectralData>>(GetFunction("GetSpectralData"),  @params);
    }
    public TArray<FMediaSoundComponentSpectralData> GetNormalizedSpectralData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FMediaSoundComponentSpectralData>>(GetFunction("GetNormalizedSpectralData"),  @params);
    }
    public UMediaPlayer* GetMediaPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaPlayer*)ProcessEvent<IntPtr>(GetFunction("GetMediaPlayer"),  @params);
    }
    public float GetEnvelopeValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEnvelopeValue"),  @params);
    }
    public bool BP_GetAttenuationSettingsToApply(ref FSoundAttenuationSettings OutAttenuationSettings)
    {
        Span<(string name, object value)> @params = [
            ("OutAttenuationSettings", OutAttenuationSettings)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetAttenuationSettingsToApply"),  @params);
    }
}

public unsafe class MediaTexture : ObjectBase<UMediaTexture>
{

    public void SetMediaPlayer(UMediaPlayer* NewMediaPlayer)
    {
        Span<(string name, object value)> @params = [
            ("NewMediaPlayer", (IntPtr)NewMediaPlayer)
        ];
        ProcessEvent(GetFunction("SetMediaPlayer"),  @params);
    }
    public int GetWidth()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetWidth"),  @params);
    }
    public int GetTextureNumMips()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetTextureNumMips"),  @params);
    }
    public UMediaPlayer* GetMediaPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaPlayer*)ProcessEvent<IntPtr>(GetFunction("GetMediaPlayer"),  @params);
    }
    public int GetHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetHeight"),  @params);
    }
    public float GetAspectRatio()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAspectRatio"),  @params);
    }
}

public unsafe class PlatformMediaSource : ObjectBase<UPlatformMediaSource>
{

}

public unsafe class StreamMediaSource : ObjectBase<UStreamMediaSource>
{

}

public unsafe class TimeSynchronizableMediaSource : ObjectBase<UTimeSynchronizableMediaSource>
{

}

