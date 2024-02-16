using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothConfigCommon
{
    [FieldOffset(0x0000)] public UClothConfigBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothSharedConfigCommon
{
    [FieldOffset(0x0000)] public UClothConfigCommon baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothingAssetCustomData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPointWeightMap
{
    [FieldOffset(0x0000)] public TArray<float> Values;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FClothPhysicalMeshData
{
    [FieldOffset(0x0000)] public TArray<FVector> Vertices;
    [FieldOffset(0x0010)] public TArray<FVector> Normals;
    [FieldOffset(0x0020)] public TArray<uint> Indices;
    [FieldOffset(0x0030)] public TMap<uint, FPointWeightMap> WeightMaps;
    [FieldOffset(0x0080)] public TArray<float> InverseMasses;
    [FieldOffset(0x0090)] public TArray<FClothVertBoneData> BoneData;
    [FieldOffset(0x00A0)] public int MaxBoneWeights;
    [FieldOffset(0x00A4)] public int NumFixedVerts;
    [FieldOffset(0x00A8)] public TArray<uint> SelfCollisionIndices;
    [FieldOffset(0x00B8)] public TArray<float> MaxDistances;
    [FieldOffset(0x00C8)] public TArray<float> BackstopDistances;
    [FieldOffset(0x00D8)] public TArray<float> BackstopRadiuses;
    [FieldOffset(0x00E8)] public TArray<float> AnimDriveMultipliers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct FClothLODDataCommon
{
    [FieldOffset(0x0000)] public FClothPhysicalMeshData PhysicalMeshData;
    [FieldOffset(0x00F8)] public FClothCollisionData CollisionData;
    [FieldOffset(0x0138)] public bool bUseMultipleInfluences;
    [FieldOffset(0x013C)] public float SkinningKernelRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UClothingAssetCommon
{
    [FieldOffset(0x0000)] public UClothingAssetBase baseObj;
    [FieldOffset(0x0048)] public UPhysicsAsset* PhysicsAsset;
    [FieldOffset(0x0050)] public TMap<FName, IntPtr> ClothConfigs;
    [FieldOffset(0x00A0)] public TArray<FClothLODDataCommon> LODData;
    [FieldOffset(0x00B0)] public TArray<int> LodMap;
    [FieldOffset(0x00C0)] public TArray<FName> UsedBoneNames;
    [FieldOffset(0x00D0)] public TArray<int> UsedBoneIndices;
    [FieldOffset(0x00E0)] public int ReferenceBoneIndex;
    [FieldOffset(0x00E8)] public UClothingAssetCustomData* CustomData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UClothLODDataCommon_Legacy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClothPhysicalMeshDataBase_Legacy* PhysicalMeshData;
    [FieldOffset(0x0030)] public FClothPhysicalMeshData ClothPhysicalMeshData;
    [FieldOffset(0x0128)] public FClothCollisionData CollisionData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FClothConstraintSetup_Legacy
{
    [FieldOffset(0x0000)] public float Stiffness;
    [FieldOffset(0x0004)] public float StiffnessMultiplier;
    [FieldOffset(0x0008)] public float StretchLimit;
    [FieldOffset(0x000C)] public float CompressionLimit;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD4)] 
public unsafe struct FClothConfig_Legacy
{
    [FieldOffset(0x0000)] public EClothingWindMethod_Legacy WindMethod;
    [FieldOffset(0x0004)] public FClothConstraintSetup_Legacy VerticalConstraintConfig;
    [FieldOffset(0x0014)] public FClothConstraintSetup_Legacy HorizontalConstraintConfig;
    [FieldOffset(0x0024)] public FClothConstraintSetup_Legacy BendConstraintConfig;
    [FieldOffset(0x0034)] public FClothConstraintSetup_Legacy ShearConstraintConfig;
    [FieldOffset(0x0044)] public float SelfCollisionRadius;
    [FieldOffset(0x0048)] public float SelfCollisionStiffness;
    [FieldOffset(0x004C)] public float SelfCollisionCullScale;
    [FieldOffset(0x0050)] public FVector Damping;
    [FieldOffset(0x005C)] public float Friction;
    [FieldOffset(0x0060)] public float WindDragCoefficient;
    [FieldOffset(0x0064)] public float WindLiftCoefficient;
    [FieldOffset(0x0068)] public FVector LinearDrag;
    [FieldOffset(0x0074)] public FVector AngularDrag;
    [FieldOffset(0x0080)] public FVector LinearInertiaScale;
    [FieldOffset(0x008C)] public FVector AngularInertiaScale;
    [FieldOffset(0x0098)] public FVector CentrifugalInertiaScale;
    [FieldOffset(0x00A4)] public float SolverFrequency;
    [FieldOffset(0x00A8)] public float StiffnessFrequency;
    [FieldOffset(0x00AC)] public float GravityScale;
    [FieldOffset(0x00B0)] public FVector GravityOverride;
    [FieldOffset(0x00BC)] public bool bUseGravityOverride;
    [FieldOffset(0x00C0)] public float TetherStiffness;
    [FieldOffset(0x00C4)] public float TetherLimit;
    [FieldOffset(0x00C8)] public float CollisionThickness;
    [FieldOffset(0x00CC)] public float AnimDriveSpringStiffness;
    [FieldOffset(0x00D0)] public float AnimDriveDamperStiffness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FClothParameterMask_Legacy
{
    [FieldOffset(0x0000)] public FName MaskName;
    [FieldOffset(0x0008)] public EWeightMapTargetCommon CurrentTarget;
    [FieldOffset(0x000C)] public float MaxValue;
    [FieldOffset(0x0010)] public float MinValue;
    [FieldOffset(0x0018)] public TArray<float> Values;
    [FieldOffset(0x0028)] public bool bEnabled;
}

