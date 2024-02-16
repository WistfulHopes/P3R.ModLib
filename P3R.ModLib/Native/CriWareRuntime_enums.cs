public enum EAtomAudioVolumeType {
    UseSnapshot = 0,
    UseBus = 1,
    UseAisacControl = 2,
    UseEntranceVolume = 3,
    Num = 4,
    EAtomAudioVolumeType_MAX = 5,
};

public enum EAtomComponentStatus {
    Stop = 0,
    Prep = 1,
    Playing = 2,
    PlayEnd = 3,
    Error = 4,
    EAtomComponentStatus_MAX = 5,
};

public enum EAtomLoopSetting {
    Inherited = 0,
    Loop = 1,
    OneShot = 2,
    EAtomLoopSetting_MAX = 3,
};

public enum ECriFsBinderStatus {
    Stop = 0,
    Binding = 1,
    Complete = 2,
    Error = 3,
    ECriFsBinderStatus_MAX = 4,
};

public enum EAtomCueSheetLoaderComponentStatus {
    Stop = 0,
    Loading = 1,
    LoadEnd = 2,
    Serializing = 3,
    SerializeEnd = 4,
    Binding = 5,
    BindEnd = 6,
    LoadCueSheet = 7,
    Complete = 8,
    Error = 9,
    EAtomCueSheetLoaderComponentStatus_MAX = 10,
};

public enum EAtomDeviceType {
    DEVICE_TYPE_HDMI = 1,
    DEVICE_TYPE_HEADPHONE = 2,
    DEVICE_TYPE_BUILT_IN_SPEAKER = 3,
    DEVICE_TYPE_PAD_SPEAKER = 4,
    DEVICE_TYPE_VIBRATION = 5,
    DEVICE_TYPE_UNKNOWN = 0,
    DEVICE_TYPE_UNAVAILABLE = 254,
    DEVICE_TYPE_MAX = 255,
};

public enum ECriFsLoaderStatus {
    Stop = 0,
    Loading = 1,
    Complete = 2,
    Error = 3,
    ECriFsLoaderStatus_MAX = 4,
};

public enum ECriWareErrorType {
    Warning = 0,
    Error = 1,
    ECriWareErrorType_MAX = 2,
};

public enum EManaSubtitlesEncoding {
    Default = 0,
    ANSI = 1,
    Utf8 = 2,
    Utf16 = 3,
    EManaSubtitlesEncoding_MAX = 4,
};

public enum EManaComponentStatus {
    Stop = 0,
    DecHdr = 1,
    WaitPrep = 2,
    Prep = 3,
    Ready = 4,
    Playing = 5,
    PlayEnd = 6,
    Error = 7,
    StopProcessing = 8,
    EManaComponentStatus_MAX = 9,
};

public enum EManaFrameAction {
    Default = 0,
    Hold = 1,
    Clear = 2,
    EManaFrameAction_MAX = 3,
};

public enum EManaMaxFrameDrop {
    Disabled = 0,
    One = 1,
    Two = 2,
    Three = 3,
    For = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Infinite = 11,
    EManaMaxFrameDrop_MAX = 12,
};

public enum EManaPlaybackTimer {
    Default = 0,
    RealTime = 1,
    FrameTime = 2,
    Manual = 3,
    EManaPlaybackTimer_MAX = 4,
};

public enum EAtomSpeakerID {
    FrontLeft = 0,
    FrontRight = 1,
    FrontCenter = 2,
    LowFrequency = 3,
    SurroundLeft = 4,
    SurroundRight = 5,
    SurroundBackLeft = 6,
    SurroundBackRight = 7,
    EAtomSpeakerID_MAX = 8,
};

public enum EManaPlayerTrack {
    Audio = 0,
    SubAudio = 1,
    ExtraAudio = 2,
    Subtitle = 3,
    Video = 4,
    Alpha = 5,
    EManaPlayerTrack_MAX = 6,
};

public enum EManaPlayerOptionBooleanOverride {
    UseManaPlayerSetting = 0,
    Enabled = 1,
    Disabled = 2,
    EManaPlayerOptionBooleanOverride_MAX = 3,
};

public enum EAtomSequenceEventType {
    SEQUENCE_TYPE_CALLBACK = 0,
    SEQUENCE_TYPESIZE_4BYTE = 1,
    SEQUENCE_MAX = 2,
};

public enum EAtomSortOrderType {
    Ascending = 0,
    Descending = 1,
    EAtomSortOrderType_MAX = 2,
};

public enum EAtomProfileSortType {
    AtomComponentID = 0,
    Distance = 1,
    Name = 2,
    Time = 3,
    EAtomProfileSortType_MAX = 4,
};

public enum EAtomWavePlayState {
    Playing = 0,
    Stopped = 1,
    Paused = 2,
    FadingIn = 3,
    FadingOut = 4,
    Count = 5,
    EAtomWavePlayState_MAX = 6,
};

public enum ECriWareSpeakerSystem {
    Surround5Point1 = 0,
    Surround7Point1 = 1,
    ECriWareSpeakerSystem_MAX = 2,
};

public enum EAtomLoopSettingID_DEPRECEATED {
    DefaultLoop_DEPRECATED = 0,
    ForceLoop_DEPRECATED = 1,
    IgnoreLoop_DEPRECATED = 2,
    EAtomLoopSettingID_MAX = 3,
};

public enum EAtomSoundRendererType {
    Any = 0,
    Native = 1,
    Asr = 2,
    Hardware1 = 1,
    Hardware2 = 5,
    Hardware3 = 9,
    Hardware4 = 13,
    VibrationHardware = 29,
    Pad = 255,
    EAtomSoundRendererType_MAX = 256,
};

public enum EEngineIniFileType {
    EngBaseEngineIni = 0,
    EngWindowsEngineIni = 1,
    ProjDefaultEngineIni = 4,
    ProjWindowsEngineIni = 5,
    EEngineIniFileType_MAX = 6,
};

public enum EManaComponentTextureType {
    Texture_Y = 0,
    Texture_U = 1,
    Texture_V = 2,
    Texture_A = 3,
    Texture_UV = 4,
    Texture_RGB = 5,
    Texture_External = 6,
    Texture_MAX = 7,
};

public enum EManaSoundType {
    Adx = 0,
    HCA = 1,
    Num = 2,
    Unknown = 255,
    EManaSoundType_MAX = 256,
};

public enum EManaColorSpace {
    Rec601 = 0,
    Rec601Full = 1,
    Rec709 = 2,
    Rec709Full = 3,
    Num = 4,
    EManaColorSpace_MAX = 5,
};

public enum EManaMovieType {
    SofdecPrime = 0,
    H264 = 1,
    VP9 = 2,
    Num = 3,
    Unknown = 255,
    EManaMovieType_MAX = 256,
};

public enum EAtomFormat {
    None = 0,
    ADX = 1,
    HCA = 2,
    HCAMX = 3,
    AIFF = 4,
    Wave = 5,
    RawPCM = 6,
    Vibration = 7,
    AudioBuffer = 8,
    Instrument = 9,
    Hardware1 = 10,
    Hardware2 = 11,
    Num = 12,
    EAtomFormat_MAX = 13,
};

