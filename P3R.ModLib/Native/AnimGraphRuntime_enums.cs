public enum ESphericalLimitType {
    Inner = 0,
    Outer = 1,
    ESphericalLimitType_MAX = 2,
};

public enum AnimPhysSimSpaceType {
    Component = 0,
    Actor = 1,
    World = 2,
    RootRelative = 3,
    BoneRelative = 4,
    AnimPhysSimSpaceType_MAX = 5,
};

public enum AnimPhysLinearConstraintType {
    Free = 0,
    Limited = 1,
    AnimPhysLinearConstraintType_MAX = 2,
};

public enum AnimPhysAngularConstraintType {
    Angular = 0,
    Cone = 1,
    AnimPhysAngularConstraintType_MAX = 2,
};

public enum EBlendListTransitionType {
    StandardBlend = 0,
    Inertialization = 1,
    EBlendListTransitionType_MAX = 2,
};

public enum EDrivenDestinationMode {
    Bone = 0,
    MorphTarget = 1,
    MaterialParameter = 2,
    EDrivenDestinationMode_MAX = 3,
};

public enum EDrivenBoneModificationMode {
    AddToInput = 0,
    ReplaceComponent = 1,
    AddToRefPose = 2,
    EDrivenBoneModificationMode_MAX = 3,
};

public enum EConstraintOffsetOption {
    None = 0,
    Offset_RefPose = 1,
    EConstraintOffsetOption_MAX = 2,
};

public enum CopyBoneDeltaMode {
    Accumulate = 0,
    Copy = 1,
    CopyBoneDeltaMode_MAX = 2,
};

public enum EInterpolationBlend {
    Linear = 0,
    Cubic = 1,
    Sinusoidal = 2,
    EaseInOutExponent2 = 3,
    EaseInOutExponent3 = 4,
    EaseInOutExponent4 = 5,
    EaseInOutExponent5 = 6,
    MAX = 7,
};

public enum EBoneModificationMode {
    BMM_Ignore = 0,
    BMM_Replace = 1,
    BMM_Additive = 2,
    BMM_MAX = 3,
};

public enum EModifyCurveApplyMode {
    Add = 0,
    Scale = 1,
    Blend = 2,
    WeightedMovingAverage = 3,
    RemapCurve = 4,
    EModifyCurveApplyMode_MAX = 5,
};

public enum EPoseDriverOutput {
    DrivePoses = 0,
    DriveCurves = 1,
    EPoseDriverOutput_MAX = 2,
};

public enum EPoseDriverSource {
    Rotation = 0,
    Translation = 1,
    EPoseDriverSource_MAX = 2,
};

public enum EPoseDriverType {
    SwingAndTwist = 0,
    SwingOnly = 1,
    Translation = 2,
    EPoseDriverType_MAX = 3,
};

public enum ESnapshotSourceMode {
    NamedSnapshot = 0,
    SnapshotPin = 1,
    ESnapshotSourceMode_MAX = 2,
};

public enum ERefPoseType {
    EIT_LocalSpace = 0,
    EIT_Additive = 1,
    EIT_MAX = 2,
};

public enum ESimulationSpace {
    ComponentSpace = 0,
    WorldSpace = 1,
    BaseBoneSpace = 2,
    ESimulationSpace_MAX = 3,
};

public enum EScaleChainInitialLength {
    FixedDefaultLengthValue = 0,
    Distance = 1,
    ChainLength = 2,
    EScaleChainInitialLength_MAX = 3,
};

public enum ESequenceEvalReinit {
    NoReset = 0,
    StartPosition = 1,
    ExplicitTime = 2,
    ESequenceEvalReinit_MAX = 3,
};

public enum ESplineBoneAxis {
    None = 0,
    X = 1,
    Y = 2,
    Z = 3,
    ESplineBoneAxis_MAX = 4,
};

public enum ERotationComponent {
    EulerX = 0,
    EulerY = 1,
    EulerZ = 2,
    QuaternionAngle = 3,
    SwingAngle = 4,
    TwistAngle = 5,
    ERotationComponent_MAX = 6,
};

public enum EEasingFuncType {
    Linear = 0,
    Sinusoidal = 1,
    Cubic = 2,
    QuadraticInOut = 3,
    CubicInOut = 4,
    HermiteCubic = 5,
    QuarticInOut = 6,
    QuinticInOut = 7,
    CircularIn = 8,
    CircularOut = 9,
    CircularInOut = 10,
    ExpIn = 11,
    ExpOut = 12,
    ExpInOut = 13,
    CustomCurve = 14,
    EEasingFuncType_MAX = 15,
};

public enum ERBFNormalizeMethod {
    OnlyNormalizeAboveOne = 0,
    AlwaysNormalize = 1,
    NormalizeWithinMedian = 2,
    NoNormalization = 3,
    ERBFNormalizeMethod_MAX = 4,
};

public enum ERBFDistanceMethod {
    Euclidean = 0,
    Quaternion = 1,
    SwingAngle = 2,
    TwistAngle = 3,
    DefaultMethod = 4,
    ERBFDistanceMethod_MAX = 5,
};

public enum ERBFFunctionType {
    Gaussian = 0,
    Exponential = 1,
    Linear = 2,
    Cubic = 3,
    Quintic = 4,
    DefaultFunction = 5,
    ERBFFunctionType_MAX = 6,
};

public enum ERBFSolverType {
    Additive = 0,
    Interpolative = 1,
    ERBFSolverType_MAX = 2,
};

