using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FCollisionLimitBase
{
    [FieldOffset(0x0000)] public FBoneReference DrivingBone;
    [FieldOffset(0x0010)] public FVector OffsetLocation;
    [FieldOffset(0x001C)] public FRotator OffsetRotation;
    [FieldOffset(0x0028)] public FVector Location;
    [FieldOffset(0x0040)] public FQuat Rotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FSphericalLimit
{
    [FieldOffset(0x0000)] public FCollisionLimitBase baseObj;
    [FieldOffset(0x0050)] public float Radius;
    [FieldOffset(0x0054)] public ESphericalLimitType LimitType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FCapsuleLimit
{
    [FieldOffset(0x0000)] public FCollisionLimitBase baseObj;
    [FieldOffset(0x0050)] public float Radius;
    [FieldOffset(0x0054)] public float Length;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FPlanarLimit
{
    [FieldOffset(0x0000)] public FCollisionLimitBase baseObj;
    [FieldOffset(0x0050)] public FPlane Plane;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UKawaiiPhysicsLimitsDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSphericalLimit> SphericalLimits;
    [FieldOffset(0x0040)] public TArray<FCapsuleLimit> CapsuleLimits;
    [FieldOffset(0x0050)] public TArray<FPlanarLimit> PlanarLimits;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FKawaiiPhysicsSettings
{
    [FieldOffset(0x0000)] public float Damping;
    [FieldOffset(0x0004)] public float WorldDampingLocation;
    [FieldOffset(0x0008)] public float WorldDampingRotation;
    [FieldOffset(0x000C)] public float Stiffness;
    [FieldOffset(0x0010)] public float Radius;
    [FieldOffset(0x0014)] public float LimitAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FKawaiiPhysicsModifyBone
{
    [FieldOffset(0x0000)] public FBoneReference BoneRef;
    [FieldOffset(0x0010)] public int ParentIndex;
    [FieldOffset(0x0018)] public TArray<int> ChildIndexs;
    [FieldOffset(0x0028)] public FKawaiiPhysicsSettings PhysicsSettings;
    [FieldOffset(0x0040)] public FVector Location;
    [FieldOffset(0x004C)] public FVector PrevLocation;
    [FieldOffset(0x0060)] public FQuat PrevRotation;
    [FieldOffset(0x0070)] public FVector PoseLocation;
    [FieldOffset(0x0080)] public FQuat PoseRotation;
    [FieldOffset(0x0090)] public FVector PoseScale;
    [FieldOffset(0x009C)] public float LengthFromRoot;
    [FieldOffset(0x00A0)] public bool bDummy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct FAnimNode_KawaiiPhysics
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
    [FieldOffset(0x00C8)] public FBoneReference RootBone;
    [FieldOffset(0x00D8)] public TArray<FBoneReference> ExcludeBones;
    [FieldOffset(0x00E8)] public int TargetFramerate;
    [FieldOffset(0x00EC)] public bool OverrideTargetFramerate;
    [FieldOffset(0x00F0)] public FKawaiiPhysicsSettings PhysicsSettings;
    [FieldOffset(0x0108)] public UCurveFloat* DampingCurve;
    [FieldOffset(0x0110)] public UCurveFloat* WorldDampingLocationCurve;
    [FieldOffset(0x0118)] public UCurveFloat* WorldDampingRotationCurve;
    [FieldOffset(0x0120)] public UCurveFloat* StiffnessCurve;
    [FieldOffset(0x0128)] public UCurveFloat* RadiusCurve;
    [FieldOffset(0x0130)] public UCurveFloat* LimitAngleCurve;
    [FieldOffset(0x0138)] public bool bUpdatePhysicsSettingsInGame;
    [FieldOffset(0x013C)] public float DummyBoneLength;
    [FieldOffset(0x0140)] public EBoneForwardAxis BoneForwardAxis;
    [FieldOffset(0x0141)] public EPlanarConstraint PlanarConstraint;
    [FieldOffset(0x0148)] public TArray<FSphericalLimit> SphericalLimits;
    [FieldOffset(0x0158)] public TArray<FCapsuleLimit> CapsuleLimits;
    [FieldOffset(0x0168)] public TArray<FPlanarLimit> PlanarLimits;
    [FieldOffset(0x0178)] public UKawaiiPhysicsLimitsDataAsset* LimitsDataAsset;
    [FieldOffset(0x0180)] public TArray<FSphericalLimit> SphericalLimitsData;
    [FieldOffset(0x0190)] public TArray<FCapsuleLimit> CapsuleLimitsData;
    [FieldOffset(0x01A0)] public TArray<FPlanarLimit> PlanarLimitsData;
    [FieldOffset(0x01B0)] public float TeleportDistanceThreshold;
    [FieldOffset(0x01B4)] public float TeleportRotationThreshold;
    [FieldOffset(0x01B8)] public FVector Gravity;
    [FieldOffset(0x01C4)] public bool bEnableWind;
    [FieldOffset(0x01C8)] public float WindScale;
    [FieldOffset(0x01D0)] public TArray<FKawaiiPhysicsModifyBone> ModifyBones;
    [FieldOffset(0x01E0)] public float TotalBoneLength;
    [FieldOffset(0x01F0)] public FTransform PreSkelCompTransform;
    [FieldOffset(0x0220)] public bool bInitPhysicsSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FCollisionLimitDataBase
{
    [FieldOffset(0x0000)] public FName DrivingBoneName;
    [FieldOffset(0x0008)] public FVector OffsetLocation;
    [FieldOffset(0x0014)] public FRotator OffsetRotation;
    [FieldOffset(0x0020)] public FVector Location;
    [FieldOffset(0x0030)] public FQuat Rotation;
    [FieldOffset(0x0040)] public FGuid Guid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FPlanarLimitData
{
    [FieldOffset(0x0000)] public FCollisionLimitDataBase baseObj;
    [FieldOffset(0x0050)] public FPlane Plane;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FCapsuleLimitData
{
    [FieldOffset(0x0000)] public FCollisionLimitDataBase baseObj;
    [FieldOffset(0x0050)] public float Radius;
    [FieldOffset(0x0054)] public float Length;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FSphericalLimitData
{
    [FieldOffset(0x0000)] public FCollisionLimitDataBase baseObj;
    [FieldOffset(0x0050)] public float Radius;
    [FieldOffset(0x0054)] public ESphericalLimitType LimitType;
}

