public enum EMovieSceneKeyInterpolation {
    Auto = 0,
    User = 1,
    Break = 2,
    Linear = 3,
    Constant = 4,
    EMovieSceneKeyInterpolation_MAX = 5,
};

public enum EMovieSceneBlendType {
    Invalid = 0,
    Absolute = 1,
    Additive = 2,
    Relative = 4,
    AdditiveFromBase = 8,
    EMovieSceneBlendType_MAX = 9,
};

public enum EMovieSceneCompletionMode {
    KeepState = 0,
    RestoreState = 1,
    ProjectDefault = 2,
    EMovieSceneCompletionMode_MAX = 3,
};

public enum EMovieSceneBuiltInEasing {
    Linear = 0,
    SinIn = 1,
    SinOut = 2,
    SinInOut = 3,
    QuadIn = 4,
    QuadOut = 5,
    QuadInOut = 6,
    CubicIn = 7,
    CubicOut = 8,
    CubicInOut = 9,
    QuartIn = 10,
    QuartOut = 11,
    QuartInOut = 12,
    QuintIn = 13,
    QuintOut = 14,
    QuintInOut = 15,
    ExpoIn = 16,
    ExpoOut = 17,
    ExpoInOut = 18,
    CircIn = 19,
    CircOut = 20,
    CircInOut = 21,
    EMovieSceneBuiltInEasing_MAX = 22,
};

public enum EEvaluationMethod {
    Static = 0,
    Swept = 1,
    EEvaluationMethod_MAX = 2,
};

public enum EMovieSceneServerClientMask {
    None = 0,
    Server = 1,
    Client = 2,
    All = 3,
    EMovieSceneServerClientMask_MAX = 4,
};

public enum EMovieSceneSequenceFlags {
    None = 0,
    Volatile = 1,
    BlockingEvaluation = 2,
    InheritedFlags = 1,
    EMovieSceneSequenceFlags_MAX = 3,
};

public enum EUpdateClockSource {
    Tick = 0,
    Platform = 1,
    Audio = 2,
    RelativeTimecode = 3,
    Timecode = 4,
    Custom = 5,
    EUpdateClockSource_MAX = 6,
};

public enum EMovieSceneEvaluationType {
    FrameLocked = 0,
    WithSubFrames = 1,
    EMovieSceneEvaluationType_MAX = 2,
};

public enum EMovieScenePlayerStatus {
    Stopped = 0,
    Playing = 1,
    Scrubbing = 2,
    Jumping = 3,
    Stepping = 4,
    Paused = 5,
    MAX = 6,
};

public enum EMovieSceneObjectBindingSpace {
    Local = 0,
    Root = 1,
    Unused = 2,
    EMovieSceneObjectBindingSpace_MAX = 3,
};

public enum ESectionEvaluationFlags {
    None = 0,
    PreRoll = 1,
    PostRoll = 2,
    ESectionEvaluationFlags_MAX = 3,
};

public enum EMovieScenePositionType {
    Frame = 0,
    Time = 1,
    MarkedFrame = 2,
    EMovieScenePositionType_MAX = 3,
};

public enum EUpdatePositionMethod {
    Play = 0,
    Jump = 1,
    Scrub = 2,
    EUpdatePositionMethod_MAX = 3,
};

public enum ESpawnOwnership {
    InnerSequence = 0,
    MasterSequence = 1,
    External = 2,
    ESpawnOwnership_MAX = 3,
};

