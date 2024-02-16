using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAnimNotify_PlayMontageNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public FName NotifyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify_PlayMontageNotifyWindow
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public FName NotifyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UAnimSequencerInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FPositionHistory
{
    [FieldOffset(0x0000)] public TArray<FVector> Positions;
    [FieldOffset(0x0010)] public float Range;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetAnimationLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UPlayMontageCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ISequencerAnimationSupport
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FAnimNode_SkeletalControlBase
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FComponentSpacePoseLink ComponentPose;
    [FieldOffset(0x0020)] public int LODThreshold;
    [FieldOffset(0x0024)] public float ActualAlpha;
    [FieldOffset(0x0028)] public EAnimAlphaInputType AlphaInputType;
    [FieldOffset(0x0029)] public bool bAlphaBoolEnabled;
    [FieldOffset(0x002C)] public float Alpha;
    [FieldOffset(0x0030)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0038)] public FInputAlphaBoolBlend AlphaBoolBlend;
    [FieldOffset(0x0080)] public FName AlphaCurveName;
    [FieldOffset(0x0088)] public FInputScaleBiasClamp AlphaScaleBiasClamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FAnimNode_BlendSpacePlayer
{
    [FieldOffset(0x0000)] public FAnimNode_AssetPlayerBase baseObj;
    [FieldOffset(0x0038)] public float X;
    [FieldOffset(0x003C)] public float Y;
    [FieldOffset(0x0040)] public float Z;
    [FieldOffset(0x0044)] public float PlayRate;
    [FieldOffset(0x0048)] public bool bLoop;
    [FieldOffset(0x0049)] public bool bResetPlayTimeWhenBlendSpaceChanges;
    [FieldOffset(0x004C)] public float StartPosition;
    [FieldOffset(0x0050)] public UBlendSpaceBase* BlendSpace;
    [FieldOffset(0x00E0)] public UBlendSpaceBase* PreviousBlendSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct FAnimNode_AimOffsetLookAt
{
    [FieldOffset(0x0000)] public FAnimNode_BlendSpacePlayer baseObj;
    [FieldOffset(0x0150)] public FPoseLink BasePose;
    [FieldOffset(0x0160)] public int LODThreshold;
    [FieldOffset(0x0164)] public FName SourceSocketName;
    [FieldOffset(0x016C)] public FName PivotSocketName;
    [FieldOffset(0x0174)] public FVector LookAtLocation;
    [FieldOffset(0x0180)] public FVector SocketAxis;
    [FieldOffset(0x018C)] public float Alpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FAnimPhysConstraintSetup
{
    [FieldOffset(0x0000)] public AnimPhysLinearConstraintType LinearXLimitType;
    [FieldOffset(0x0001)] public AnimPhysLinearConstraintType LinearYLimitType;
    [FieldOffset(0x0002)] public AnimPhysLinearConstraintType LinearZLimitType;
    [FieldOffset(0x0004)] public FVector LinearAxesMin;
    [FieldOffset(0x0010)] public FVector LinearAxesMax;
    [FieldOffset(0x001C)] public AnimPhysAngularConstraintType AngularConstraintType;
    [FieldOffset(0x001D)] public AnimPhysTwistAxis TwistAxis;
    [FieldOffset(0x001E)] public AnimPhysTwistAxis AngularTargetAxis;
    [FieldOffset(0x0020)] public float ConeAngle;
    [FieldOffset(0x0024)] public FVector AngularLimitsMin;
    [FieldOffset(0x0030)] public FVector AngularLimitsMax;
    [FieldOffset(0x003C)] public FVector AngularTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FAnimPhysSphericalLimit
{
    [FieldOffset(0x0000)] public FBoneReference DrivingBone;
    [FieldOffset(0x0010)] public FVector SphereLocalOffset;
    [FieldOffset(0x001C)] public float LimitRadius;
    [FieldOffset(0x0020)] public ESphericalLimitType LimitType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAnimPhysPlanarLimit
{
    [FieldOffset(0x0000)] public FBoneReference DrivingBone;
    [FieldOffset(0x0010)] public FTransform PlaneTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FRotationRetargetingInfo
{
    [FieldOffset(0x0000)] public bool bEnabled;
    [FieldOffset(0x0010)] public FTransform Source;
    [FieldOffset(0x0040)] public FTransform Target;
    [FieldOffset(0x0070)] public ERotationComponent RotationComponent;
    [FieldOffset(0x0074)] public FVector TwistAxis;
    [FieldOffset(0x0080)] public bool bUseAbsoluteAngle;
    [FieldOffset(0x0084)] public float SourceMinimum;
    [FieldOffset(0x0088)] public float SourceMaximum;
    [FieldOffset(0x008C)] public float TargetMinimum;
    [FieldOffset(0x0090)] public float TargetMaximum;
    [FieldOffset(0x0094)] public EEasingFuncType EasingType;
    [FieldOffset(0x0098)] public FRuntimeFloatCurve CustomCurve;
    [FieldOffset(0x0120)] public bool bFlipEasing;
    [FieldOffset(0x0124)] public float EasingWeight;
    [FieldOffset(0x0128)] public bool bClamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x440)] 
public unsafe struct FAnimNode_AnimDynamics
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public float LinearDampingOverride;
    [FieldOffset(0x00CC)] public float AngularDampingOverride;
    [FieldOffset(0x0130)] public FBoneReference RelativeSpaceBone;
    [FieldOffset(0x0140)] public FBoneReference BoundBone;
    [FieldOffset(0x0150)] public FBoneReference ChainEnd;
    [FieldOffset(0x0160)] public FVector BoxExtents;
    [FieldOffset(0x016C)] public FVector LocalJointOffset;
    [FieldOffset(0x0178)] public float GravityScale;
    [FieldOffset(0x017C)] public FVector GravityOverride;
    [FieldOffset(0x0188)] public float LinearSpringConstant;
    [FieldOffset(0x018C)] public float AngularSpringConstant;
    [FieldOffset(0x0190)] public float WindScale;
    [FieldOffset(0x0194)] public FVector ComponentLinearAccScale;
    [FieldOffset(0x01A0)] public FVector ComponentLinearVelScale;
    [FieldOffset(0x01AC)] public FVector ComponentAppliedLinearAccClamp;
    [FieldOffset(0x01B8)] public float AngularBiasOverride;
    [FieldOffset(0x01BC)] public int NumSolverIterationsPreUpdate;
    [FieldOffset(0x01C0)] public int NumSolverIterationsPostUpdate;
    [FieldOffset(0x01C4)] public FAnimPhysConstraintSetup ConstraintSetup;
    [FieldOffset(0x0210)] public TArray<FAnimPhysSphericalLimit> SphericalLimits;
    [FieldOffset(0x0220)] public float SphereCollisionRadius;
    [FieldOffset(0x0224)] public FVector ExternalForce;
    [FieldOffset(0x0230)] public TArray<FAnimPhysPlanarLimit> PlanarLimits;
    [FieldOffset(0x0240)] public AnimPhysCollisionType CollisionType;
    [FieldOffset(0x0241)] public AnimPhysSimSpaceType SimulationSpace;
    [FieldOffset(0x0244)] public byte bUseSphericalLimits;
    [FieldOffset(0x0244)] public byte bUsePlanarLimit;
    [FieldOffset(0x0244)] public byte bDoUpdate;
    [FieldOffset(0x0244)] public byte bDoEval;
    [FieldOffset(0x0244)] public byte bOverrideLinearDamping;
    [FieldOffset(0x0244)] public byte bOverrideAngularBias;
    [FieldOffset(0x0244)] public byte bOverrideAngularDamping;
    [FieldOffset(0x0244)] public byte bEnableWind;
    [FieldOffset(0x0245)] public byte bUseGravityOverride;
    [FieldOffset(0x0245)] public byte bLinearSpring;
    [FieldOffset(0x0245)] public byte bAngularSpring;
    [FieldOffset(0x0245)] public byte bChain;
    [FieldOffset(0x0250)] public FRotationRetargetingInfo RetargetingSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FAnimNode_ApplyAdditive
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Base;
    [FieldOffset(0x0020)] public FPoseLink Additive;
    [FieldOffset(0x0030)] public float Alpha;
    [FieldOffset(0x0034)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x003C)] public int LODThreshold;
    [FieldOffset(0x0040)] public FInputAlphaBoolBlend AlphaBoolBlend;
    [FieldOffset(0x0088)] public FName AlphaCurveName;
    [FieldOffset(0x0090)] public FInputScaleBiasClamp AlphaScaleBiasClamp;
    [FieldOffset(0x00C4)] public EAnimAlphaInputType AlphaInputType;
    [FieldOffset(0x00C5)] public bool bAlphaBoolEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAngularRangeLimit
{
    [FieldOffset(0x0000)] public FVector LimitMin;
    [FieldOffset(0x000C)] public FVector LimitMax;
    [FieldOffset(0x0018)] public FBoneReference Bone;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FAnimNode_ApplyLimits
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public TArray<FAngularRangeLimit> AngularRangeLimits;
    [FieldOffset(0x00D8)] public TArray<FVector> AngularOffsets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FBlendBoneByChannelEntry
{
    [FieldOffset(0x0000)] public FBoneReference SourceBone;
    [FieldOffset(0x0010)] public FBoneReference TargetBone;
    [FieldOffset(0x0020)] public bool bBlendTranslation;
    [FieldOffset(0x0021)] public bool bBlendRotation;
    [FieldOffset(0x0022)] public bool bBlendScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FAnimNode_BlendBoneByChannel
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink A;
    [FieldOffset(0x0020)] public FPoseLink B;
    [FieldOffset(0x0030)] public TArray<FBlendBoneByChannelEntry> BoneDefinitions;
    [FieldOffset(0x0050)] public float Alpha;
    [FieldOffset(0x0058)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0060)] public EBoneControlSpace TransformsSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FAnimNode_BlendListBase
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public TArray<FPoseLink> BlendPose;
    [FieldOffset(0x0020)] public TArray<float> BlendTime;
    [FieldOffset(0x0030)] public EBlendListTransitionType TransitionType;
    [FieldOffset(0x0031)] public EAlphaBlendOption BlendType;
    [FieldOffset(0x0032)] public bool bResetChildOnActivation;
    [FieldOffset(0x0038)] public UCurveFloat* CustomBlendCurve;
    [FieldOffset(0x0040)] public UBlendProfile* BlendProfile;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimNode_BlendListByBool
{
    [FieldOffset(0x0000)] public FAnimNode_BlendListBase baseObj;
    [FieldOffset(0x0098)] public bool bActiveValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FAnimNode_BlendListByEnum
{
    [FieldOffset(0x0000)] public FAnimNode_BlendListBase baseObj;
    [FieldOffset(0x0098)] public TArray<int> EnumToPoseIndex;
    [FieldOffset(0x00A8)] public byte ActiveEnumValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimNode_BlendListByInt
{
    [FieldOffset(0x0000)] public FAnimNode_BlendListBase baseObj;
    [FieldOffset(0x0098)] public int ActiveChildIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FAnimNode_BlendSpaceEvaluator
{
    [FieldOffset(0x0000)] public FAnimNode_BlendSpacePlayer baseObj;
    [FieldOffset(0x00E8)] public float NormalizedTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FAnimNode_BoneDrivenController
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference SourceBone;
    [FieldOffset(0x00D8)] public UCurveFloat* DrivingCurve;
    [FieldOffset(0x00E0)] public float Multiplier;
    [FieldOffset(0x00E4)] public float RangeMin;
    [FieldOffset(0x00E8)] public float RangeMax;
    [FieldOffset(0x00EC)] public float RemappedMin;
    [FieldOffset(0x00F0)] public float RemappedMax;
    [FieldOffset(0x00F4)] public FName ParameterName;
    [FieldOffset(0x00FC)] public FBoneReference TargetBone;
    [FieldOffset(0x010C)] public EDrivenDestinationMode DestinationMode;
    [FieldOffset(0x010D)] public EDrivenBoneModificationMode ModificationMode;
    [FieldOffset(0x010E)] public EComponentType SourceComponent;
    [FieldOffset(0x010F)] public byte bUseRange;
    [FieldOffset(0x010F)] public byte bAffectTargetTranslationX;
    [FieldOffset(0x010F)] public byte bAffectTargetTranslationY;
    [FieldOffset(0x010F)] public byte bAffectTargetTranslationZ;
    [FieldOffset(0x010F)] public byte bAffectTargetRotationX;
    [FieldOffset(0x010F)] public byte bAffectTargetRotationY;
    [FieldOffset(0x010F)] public byte bAffectTargetRotationZ;
    [FieldOffset(0x010F)] public byte bAffectTargetScaleX;
    [FieldOffset(0x0110)] public byte bAffectTargetScaleY;
    [FieldOffset(0x0110)] public byte bAffectTargetScaleZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSocketReference
{
    [FieldOffset(0x0030)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FBoneSocketTarget
{
    [FieldOffset(0x0000)] public bool bUseSocket;
    [FieldOffset(0x0004)] public FBoneReference BoneReference;
    [FieldOffset(0x0020)] public FSocketReference SocketReference;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct FAnimNode_CCDIK
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FVector EffectorLocation;
    [FieldOffset(0x00D4)] public EBoneControlSpace EffectorLocationSpace;
    [FieldOffset(0x00E0)] public FBoneSocketTarget EffectorTarget;
    [FieldOffset(0x0140)] public FBoneReference TipBone;
    [FieldOffset(0x0150)] public FBoneReference RootBone;
    [FieldOffset(0x0160)] public float Precision;
    [FieldOffset(0x0164)] public int MaxIterations;
    [FieldOffset(0x0168)] public bool bStartFromTail;
    [FieldOffset(0x0169)] public bool bEnableRotationLimit;
    [FieldOffset(0x0170)] public TArray<float> RotationLimitPerJoints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FConstraint
{
    [FieldOffset(0x0000)] public FBoneReference TargetBone;
    [FieldOffset(0x0010)] public EConstraintOffsetOption OffsetOption;
    [FieldOffset(0x0011)] public ETransformConstraintType TransformType;
    [FieldOffset(0x0012)] public FFilterOptionPerAxis PerAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FAnimNode_Constraint
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference BoneToModify;
    [FieldOffset(0x00D8)] public TArray<FConstraint> ConstraintSetup;
    [FieldOffset(0x00E8)] public TArray<float> ConstraintWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FAnimNode_CopyBone
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference SourceBone;
    [FieldOffset(0x00D8)] public FBoneReference TargetBone;
    [FieldOffset(0x00E8)] public bool bCopyTranslation;
    [FieldOffset(0x00E9)] public bool bCopyRotation;
    [FieldOffset(0x00EA)] public bool bCopyScale;
    [FieldOffset(0x00EB)] public EBoneControlSpace ControlSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FAnimNode_CopyBoneDelta
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference SourceBone;
    [FieldOffset(0x00D8)] public FBoneReference TargetBone;
    [FieldOffset(0x00E8)] public bool bCopyTranslation;
    [FieldOffset(0x00E9)] public bool bCopyRotation;
    [FieldOffset(0x00EA)] public bool bCopyScale;
    [FieldOffset(0x00EB)] public CopyBoneDeltaMode CopyMode;
    [FieldOffset(0x00EC)] public float TranslationMultiplier;
    [FieldOffset(0x00F0)] public float RotationMultiplier;
    [FieldOffset(0x00F4)] public float ScaleMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct FAnimNode_CopyPoseFromMesh
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent;
    [FieldOffset(0x0018)] public byte bUseAttachedParent;
    [FieldOffset(0x0018)] public byte bCopyCurves;
    [FieldOffset(0x0019)] public bool bCopyCustomAttributes;
    [FieldOffset(0x001A)] public byte bUseMeshPose;
    [FieldOffset(0x001C)] public FName RootBoneToCopy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAnimNode_CurveSource
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink SourcePose;
    [FieldOffset(0x0020)] public FName SourceBinding;
    [FieldOffset(0x0028)] public float Alpha;
    [FieldOffset(0x0030)] public TScriptInterface<ICurveSourceInterface> CurveSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct FAnimNode_Fabrik
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00D0)] public FTransform EffectorTransform;
    [FieldOffset(0x0100)] public FBoneSocketTarget EffectorTarget;
    [FieldOffset(0x0160)] public FBoneReference TipBone;
    [FieldOffset(0x0170)] public FBoneReference RootBone;
    [FieldOffset(0x0180)] public float Precision;
    [FieldOffset(0x0184)] public int MaxIterations;
    [FieldOffset(0x0188)] public EBoneControlSpace EffectorTransformSpace;
    [FieldOffset(0x0189)] public EBoneRotationSource EffectorRotationSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct FAnimNode_HandIKRetargeting
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference RightHandFK;
    [FieldOffset(0x00D8)] public FBoneReference LeftHandFK;
    [FieldOffset(0x00E8)] public FBoneReference RightHandIK;
    [FieldOffset(0x00F8)] public FBoneReference LeftHandIK;
    [FieldOffset(0x0108)] public TArray<FBoneReference> IKBonesToMove;
    [FieldOffset(0x0118)] public float HandFKWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FAnimNode_LayeredBoneBlend
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink BasePose;
    [FieldOffset(0x0020)] public TArray<FPoseLink> BlendPoses;
    [FieldOffset(0x0030)] public TArray<FInputBlendPose> LayerSetup;
    [FieldOffset(0x0040)] public TArray<float> BlendWeights;
    [FieldOffset(0x0050)] public bool bMeshSpaceRotationBlend;
    [FieldOffset(0x0051)] public bool bMeshSpaceScaleBlend;
    [FieldOffset(0x0052)] public ECurveBlendOption CurveBlendOption;
    [FieldOffset(0x0053)] public bool bBlendRootMotionBasedOnRootBone;
    [FieldOffset(0x0058)] public int LODThreshold;
    [FieldOffset(0x0060)] public TArray<FPerBoneBlendWeight> PerBoneBlendWeights;
    [FieldOffset(0x0070)] public FGuid SkeletonGuid;
    [FieldOffset(0x0080)] public FGuid VirtualBoneGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FAnimLegIKDefinition
{
    [FieldOffset(0x0000)] public FBoneReference IKFootBone;
    [FieldOffset(0x0010)] public FBoneReference FKFootBone;
    [FieldOffset(0x0020)] public int NumBonesInLimb;
    [FieldOffset(0x0024)] public float MinRotationAngle;
    [FieldOffset(0x0028)] public EAxis FootBoneForwardAxis;
    [FieldOffset(0x0029)] public EAxis HingeRotationAxis;
    [FieldOffset(0x002A)] public bool bEnableRotationLimit;
    [FieldOffset(0x002B)] public bool bEnableKneeTwistCorrection;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FAnimNode_LegIK
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public float ReachPrecision;
    [FieldOffset(0x00CC)] public int MaxIterations;
    [FieldOffset(0x00D0)] public TArray<FAnimLegIKDefinition> LegsDefinition;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimLegIKData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FIKChain
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FIKChainLink
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct FAnimNode_LookAt
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference BoneToModify;
    [FieldOffset(0x00E0)] public FBoneSocketTarget LookAtTarget;
    [FieldOffset(0x0140)] public FVector LookAtLocation;
    [FieldOffset(0x014C)] public FAxis LookAt_Axis;
    [FieldOffset(0x015C)] public bool bUseLookUpAxis;
    [FieldOffset(0x015D)] public EInterpolationBlend InterpolationType;
    [FieldOffset(0x0160)] public FAxis LookUp_Axis;
    [FieldOffset(0x0170)] public float LookAtClamp;
    [FieldOffset(0x0174)] public float InterpolationTime;
    [FieldOffset(0x0178)] public float InterpolationTriggerThreashold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAnimNode_MakeDynamicAdditive
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Base;
    [FieldOffset(0x0020)] public FPoseLink Additive;
    [FieldOffset(0x0030)] public bool bMeshSpaceAdditive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FAnimNode_ModifyBone
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference BoneToModify;
    [FieldOffset(0x00D8)] public FVector Translation;
    [FieldOffset(0x00E4)] public FRotator Rotation;
    [FieldOffset(0x00F0)] public FVector Scale;
    [FieldOffset(0x00FC)] public EBoneModificationMode TranslationMode;
    [FieldOffset(0x00FD)] public EBoneModificationMode RotationMode;
    [FieldOffset(0x00FE)] public EBoneModificationMode ScaleMode;
    [FieldOffset(0x00FF)] public EBoneControlSpace TranslationSpace;
    [FieldOffset(0x0100)] public EBoneControlSpace RotationSpace;
    [FieldOffset(0x0101)] public EBoneControlSpace ScaleSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FAnimNode_ModifyCurve
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink SourcePose;
    [FieldOffset(0x0020)] public TArray<float> CurveValues;
    [FieldOffset(0x0030)] public TArray<FName> CurveNames;
    [FieldOffset(0x0050)] public float Alpha;
    [FieldOffset(0x0054)] public EModifyCurveApplyMode ApplyMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAnimNode_MultiWayBlend
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public TArray<FPoseLink> Poses;
    [FieldOffset(0x0020)] public TArray<float> DesiredAlphas;
    [FieldOffset(0x0040)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0048)] public bool bAdditiveNode;
    [FieldOffset(0x0049)] public bool bNormalizeAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct FAnimNode_ObserveBone
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference BoneToObserve;
    [FieldOffset(0x00D8)] public EBoneControlSpace DisplaySpace;
    [FieldOffset(0x00D9)] public bool bRelativeToRefPose;
    [FieldOffset(0x00DC)] public FVector Translation;
    [FieldOffset(0x00E8)] public FRotator Rotation;
    [FieldOffset(0x00F4)] public FVector Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FAnimNode_PoseHandler
{
    [FieldOffset(0x0000)] public FAnimNode_AssetPlayerBase baseObj;
    [FieldOffset(0x0038)] public UPoseAsset* PoseAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimNode_PoseBlendNode
{
    [FieldOffset(0x0000)] public FAnimNode_PoseHandler baseObj;
    [FieldOffset(0x0080)] public FPoseLink SourcePose;
    [FieldOffset(0x0090)] public EAlphaBlendOption BlendOption;
    [FieldOffset(0x0098)] public UCurveFloat* CustomCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FAnimNode_PoseByName
{
    [FieldOffset(0x0000)] public FAnimNode_PoseHandler baseObj;
    [FieldOffset(0x0080)] public FName PoseName;
    [FieldOffset(0x0088)] public float PoseWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPoseDriverTransform
{
    [FieldOffset(0x0000)] public FVector TargetTranslation;
    [FieldOffset(0x000C)] public FRotator TargetRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FPoseDriverTarget
{
    [FieldOffset(0x0000)] public TArray<FPoseDriverTransform> BoneTransforms;
    [FieldOffset(0x0010)] public FRotator TargetRotation;
    [FieldOffset(0x001C)] public float TargetScale;
    [FieldOffset(0x0020)] public ERBFDistanceMethod DistanceMethod;
    [FieldOffset(0x0021)] public ERBFFunctionType FunctionType;
    [FieldOffset(0x0022)] public bool bApplyCustomCurve;
    [FieldOffset(0x0028)] public FRichCurve CustomCurve;
    [FieldOffset(0x00A8)] public FName DrivenName;
    [FieldOffset(0x00B8)] public bool bIsHidden;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FRBFParams
{
    [FieldOffset(0x0000)] public int TargetDimensions;
    [FieldOffset(0x0004)] public ERBFSolverType SolverType;
    [FieldOffset(0x0008)] public float Radius;
    [FieldOffset(0x000C)] public bool bAutomaticRadius;
    [FieldOffset(0x000D)] public ERBFFunctionType Function;
    [FieldOffset(0x000E)] public ERBFDistanceMethod DistanceMethod;
    [FieldOffset(0x000F)] public EBoneAxis TwistAxis;
    [FieldOffset(0x0010)] public float WeightThreshold;
    [FieldOffset(0x0014)] public ERBFNormalizeMethod NormalizeMethod;
    [FieldOffset(0x0018)] public FVector MedianReference;
    [FieldOffset(0x0024)] public float MedianMin;
    [FieldOffset(0x0028)] public float MedianMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct FAnimNode_PoseDriver
{
    [FieldOffset(0x0000)] public FAnimNode_PoseHandler baseObj;
    [FieldOffset(0x0080)] public FPoseLink SourcePose;
    [FieldOffset(0x0090)] public TArray<FBoneReference> SourceBones;
    [FieldOffset(0x00A0)] public TArray<FBoneReference> OnlyDriveBones;
    [FieldOffset(0x00B0)] public TArray<FPoseDriverTarget> PoseTargets;
    [FieldOffset(0x00F0)] public FBoneReference EvalSpaceBone;
    [FieldOffset(0x0100)] public FRBFParams RBFParams;
    [FieldOffset(0x012C)] public EPoseDriverSource DriveSource;
    [FieldOffset(0x012D)] public EPoseDriverOutput DriveOutput;
    [FieldOffset(0x012E)] public byte bOnlyDriveSelectedBones;
    [FieldOffset(0x0130)] public int LODThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FAnimNode_PoseSnapshot
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FName SnapshotName;
    [FieldOffset(0x0018)] public FPoseSnapshot Snapshot;
    [FieldOffset(0x0050)] public ESnapshotSourceMode Mode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FRandomPlayerSequenceEntry
{
    [FieldOffset(0x0000)] public UAnimSequence* Sequence;
    [FieldOffset(0x0008)] public float ChanceToPlay;
    [FieldOffset(0x000C)] public int MinLoopCount;
    [FieldOffset(0x0010)] public int MaxLoopCount;
    [FieldOffset(0x0014)] public float MinPlayRate;
    [FieldOffset(0x0018)] public float MaxPlayRate;
    [FieldOffset(0x0020)] public FAlphaBlend BlendIn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FAnimNode_RandomPlayer
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public TArray<FRandomPlayerSequenceEntry> Entries;
    [FieldOffset(0x0070)] public bool bShuffleMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimNode_MeshSpaceRefPose
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimNode_RefPose
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public ERefPoseType RefPoseType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FAnimNode_ResetRoot
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSimSpaceSettings
{
    [FieldOffset(0x0000)] public float MasterAlpha;
    [FieldOffset(0x0004)] public float VelocityScaleZ;
    [FieldOffset(0x0008)] public float MaxLinearVelocity;
    [FieldOffset(0x000C)] public float MaxAngularVelocity;
    [FieldOffset(0x0010)] public float MaxLinearAcceleration;
    [FieldOffset(0x0014)] public float MaxAngularAcceleration;
    [FieldOffset(0x0018)] public float ExternalLinearDrag;
    [FieldOffset(0x001C)] public FVector ExternalLinearDragV;
    [FieldOffset(0x0028)] public FVector ExternalLinearVelocity;
    [FieldOffset(0x0034)] public FVector ExternalAngularVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x830)] 
public unsafe struct FAnimNode_RigidBody
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public UPhysicsAsset* OverridePhysicsAsset;
    [FieldOffset(0x0168)] public FVector OverrideWorldGravity;
    [FieldOffset(0x0174)] public FVector ExternalForce;
    [FieldOffset(0x0180)] public FVector ComponentLinearAccScale;
    [FieldOffset(0x018C)] public FVector ComponentLinearVelScale;
    [FieldOffset(0x0198)] public FVector ComponentAppliedLinearAccClamp;
    [FieldOffset(0x01A4)] public FSimSpaceSettings SimSpaceSettings;
    [FieldOffset(0x01E4)] public float CachedBoundsScale;
    [FieldOffset(0x01E8)] public FBoneReference BaseBoneRef;
    [FieldOffset(0x01F8)] public ECollisionChannel OverlapChannel;
    [FieldOffset(0x01F9)] public ESimulationSpace SimulationSpace;
    [FieldOffset(0x01FA)] public bool bForceDisableCollisionBetweenConstraintBodies;
    [FieldOffset(0x01FC)] public byte bEnableWorldGeometry;
    [FieldOffset(0x01FC)] public byte bOverrideWorldGravity;
    [FieldOffset(0x01FC)] public byte bTransferBoneVelocities;
    [FieldOffset(0x01FC)] public byte bFreezeIncomingPoseOnStart;
    [FieldOffset(0x01FC)] public byte bClampLinearTranslationLimitToRefPose;
    [FieldOffset(0x0200)] public float WorldSpaceMinimumScale;
    [FieldOffset(0x0204)] public float EvaluationResetTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimNode_RotateRootBone
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink BasePose;
    [FieldOffset(0x0020)] public float Pitch;
    [FieldOffset(0x0024)] public float Yaw;
    [FieldOffset(0x0028)] public FInputScaleBiasClamp PitchScaleBiasClamp;
    [FieldOffset(0x0058)] public FInputScaleBiasClamp YawScaleBiasClamp;
    [FieldOffset(0x0088)] public FRotator MeshToComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FAnimNode_RotationMultiplier
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference TargetBone;
    [FieldOffset(0x00D8)] public FBoneReference SourceBone;
    [FieldOffset(0x00E8)] public float Multiplier;
    [FieldOffset(0x00EC)] public EBoneAxis RotationAxisToRefer;
    [FieldOffset(0x00ED)] public bool bIsAdditive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct FAnimNode_RotationOffsetBlendSpace
{
    [FieldOffset(0x0000)] public FAnimNode_BlendSpacePlayer baseObj;
    [FieldOffset(0x00E8)] public FPoseLink BasePose;
    [FieldOffset(0x00F8)] public int LODThreshold;
    [FieldOffset(0x00FC)] public float Alpha;
    [FieldOffset(0x0100)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0108)] public FInputAlphaBoolBlend AlphaBoolBlend;
    [FieldOffset(0x0150)] public FName AlphaCurveName;
    [FieldOffset(0x0158)] public FInputScaleBiasClamp AlphaScaleBiasClamp;
    [FieldOffset(0x018C)] public EAnimAlphaInputType AlphaInputType;
    [FieldOffset(0x018D)] public bool bAlphaBoolEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FAnimNode_ScaleChainLength
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink InputPose;
    [FieldOffset(0x0020)] public float DefaultChainLength;
    [FieldOffset(0x0024)] public FBoneReference ChainStartBone;
    [FieldOffset(0x0034)] public FBoneReference ChainEndBone;
    [FieldOffset(0x0044)] public FVector TargetLocation;
    [FieldOffset(0x0050)] public float Alpha;
    [FieldOffset(0x0058)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0060)] public EScaleChainInitialLength ChainInitialLength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAnimNode_SequenceEvaluator
{
    [FieldOffset(0x0000)] public FAnimNode_AssetPlayerBase baseObj;
    [FieldOffset(0x0038)] public UAnimSequenceBase* Sequence;
    [FieldOffset(0x0040)] public float ExplicitTime;
    [FieldOffset(0x0044)] public bool bShouldLoop;
    [FieldOffset(0x0045)] public bool bTeleportToExplicitTime;
    [FieldOffset(0x0046)] public ESequenceEvalReinit ReinitializationBehavior;
    [FieldOffset(0x0048)] public float StartPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FAnimNode_Slot
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Source;
    [FieldOffset(0x0020)] public FName SlotName;
    [FieldOffset(0x0028)] public bool bAlwaysUpdateSourcePose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct FAnimNode_SplineIK
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference StartBone;
    [FieldOffset(0x00D8)] public FBoneReference EndBone;
    [FieldOffset(0x00E8)] public ESplineBoneAxis BoneAxis;
    [FieldOffset(0x00E9)] public bool bAutoCalculateSpline;
    [FieldOffset(0x00EC)] public int PointCount;
    [FieldOffset(0x00F0)] public TArray<FTransform> ControlPoints;
    [FieldOffset(0x0100)] public float Roll;
    [FieldOffset(0x0104)] public float TwistStart;
    [FieldOffset(0x0108)] public float TwistEnd;
    [FieldOffset(0x0110)] public FAlphaBlend TwistBlend;
    [FieldOffset(0x0140)] public float Stretch;
    [FieldOffset(0x0144)] public float Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FSplineIKCachedBoneData
{
    [FieldOffset(0x0000)] public FBoneReference Bone;
    [FieldOffset(0x0010)] public int RefSkeletonIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct FAnimNode_SpringBone
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference SpringBone;
    [FieldOffset(0x00D8)] public float MaxDisplacement;
    [FieldOffset(0x00DC)] public float SpringStiffness;
    [FieldOffset(0x00E0)] public float SpringDamping;
    [FieldOffset(0x00E4)] public float ErrorResetThresh;
    [FieldOffset(0x0124)] public byte bLimitDisplacement;
    [FieldOffset(0x0124)] public byte bTranslateX;
    [FieldOffset(0x0124)] public byte bTranslateY;
    [FieldOffset(0x0124)] public byte bTranslateZ;
    [FieldOffset(0x0124)] public byte bRotateX;
    [FieldOffset(0x0124)] public byte bRotateY;
    [FieldOffset(0x0124)] public byte bRotateZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimNode_StateResult
{
    [FieldOffset(0x0000)] public FAnimNode_Root baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FRotationLimit
{
    [FieldOffset(0x0000)] public FVector LimitMin;
    [FieldOffset(0x000C)] public FVector LimitMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct FAnimNode_Trail
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x0100)] public FBoneReference TrailBone;
    [FieldOffset(0x0110)] public int ChainLength;
    [FieldOffset(0x0114)] public EAxis ChainBoneAxis;
    [FieldOffset(0x0115)] public byte bInvertChainBoneAxis;
    [FieldOffset(0x0115)] public byte bLimitStretch;
    [FieldOffset(0x0115)] public byte bLimitRotation;
    [FieldOffset(0x0115)] public byte bUsePlanarLimit;
    [FieldOffset(0x0115)] public byte bActorSpaceFakeVel;
    [FieldOffset(0x0115)] public byte bReorientParentToChild;
    [FieldOffset(0x0118)] public float MaxDeltaTime;
    [FieldOffset(0x011C)] public float RelaxationSpeedScale;
    [FieldOffset(0x0120)] public FRuntimeFloatCurve TrailRelaxationSpeed;
    [FieldOffset(0x01A8)] public FInputScaleBiasClamp RelaxationSpeedScaleInputProcessor;
    [FieldOffset(0x01D8)] public TArray<FRotationLimit> RotationLimits;
    [FieldOffset(0x01E8)] public TArray<FVector> RotationOffsets;
    [FieldOffset(0x01F8)] public TArray<FAnimPhysPlanarLimit> PlanarLimits;
    [FieldOffset(0x0208)] public float StretchLimit;
    [FieldOffset(0x020C)] public FVector FakeVelocity;
    [FieldOffset(0x0218)] public FBoneReference BaseJoint;
    [FieldOffset(0x0228)] public float LastBoneRotationAnimAlphaBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FReferenceBoneFrame
{
    [FieldOffset(0x0000)] public FBoneReference Bone;
    [FieldOffset(0x0010)] public FAxis Axis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct FAnimNode_TwistCorrectiveNode
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FReferenceBoneFrame BaseFrame;
    [FieldOffset(0x00E8)] public FReferenceBoneFrame TwistFrame;
    [FieldOffset(0x0108)] public FAxis TwistPlaneNormalAxis;
    [FieldOffset(0x0118)] public float RangeMax;
    [FieldOffset(0x011C)] public float RemappedMin;
    [FieldOffset(0x0120)] public float RemappedMax;
    [FieldOffset(0x0124)] public FAnimCurveParam Curve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E0)] 
public unsafe struct FAnimNode_TwoBoneIK
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference IKBone;
    [FieldOffset(0x00D8)] public float StartStretchRatio;
    [FieldOffset(0x00DC)] public float MaxStretchScale;
    [FieldOffset(0x00E0)] public FVector EffectorLocation;
    [FieldOffset(0x00F0)] public FBoneSocketTarget EffectorTarget;
    [FieldOffset(0x0150)] public FVector JointTargetLocation;
    [FieldOffset(0x0160)] public FBoneSocketTarget JointTarget;
    [FieldOffset(0x01C0)] public FAxis TwistAxis;
    [FieldOffset(0x01D0)] public EBoneControlSpace EffectorLocationSpace;
    [FieldOffset(0x01D1)] public EBoneControlSpace JointTargetLocationSpace;
    [FieldOffset(0x01D2)] public byte bAllowStretching;
    [FieldOffset(0x01D2)] public byte bTakeRotationFromEffectorSpace;
    [FieldOffset(0x01D2)] public byte bMaintainEffectorRelRot;
    [FieldOffset(0x01D2)] public byte bAllowTwist;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FAnimNode_TwoWayBlend
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink A;
    [FieldOffset(0x0020)] public FPoseLink B;
    [FieldOffset(0x0030)] public EAnimAlphaInputType AlphaInputType;
    [FieldOffset(0x0031)] public byte bAlphaBoolEnabled;
    [FieldOffset(0x0031)] public byte bResetChildOnActivation;
    [FieldOffset(0x0034)] public float Alpha;
    [FieldOffset(0x0038)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0040)] public FInputAlphaBoolBlend AlphaBoolBlend;
    [FieldOffset(0x0088)] public FName AlphaCurveName;
    [FieldOffset(0x0090)] public FInputScaleBiasClamp AlphaScaleBiasClamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA10)] 
public unsafe struct FAnimSequencerInstanceProxy
{
    [FieldOffset(0x0000)] public FAnimInstanceProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRBFEntry
{
    [FieldOffset(0x0000)] public TArray<float> Values;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FRBFTarget
{
    [FieldOffset(0x0000)] public FRBFEntry baseObj;
    [FieldOffset(0x0010)] public float ScaleFactor;
    [FieldOffset(0x0014)] public bool bApplyCustomCurve;
    [FieldOffset(0x0018)] public FRichCurve CustomCurve;
    [FieldOffset(0x0098)] public ERBFDistanceMethod DistanceMethod;
    [FieldOffset(0x0099)] public ERBFFunctionType FunctionType;
}

