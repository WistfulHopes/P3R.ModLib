using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FClothConstraintSetupNv
{
    [FieldOffset(0x0000)] public float Stiffness;
    [FieldOffset(0x0004)] public float StiffnessMultiplier;
    [FieldOffset(0x0008)] public float StretchLimit;
    [FieldOffset(0x000C)] public float CompressionLimit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UClothConfigNv
{
    [FieldOffset(0x0000)] public UClothConfigCommon baseObj;
    [FieldOffset(0x0028)] public EClothingWindMethodNv ClothingWindMethod;
    [FieldOffset(0x002C)] public FClothConstraintSetupNv VerticalConstraint;
    [FieldOffset(0x003C)] public FClothConstraintSetupNv HorizontalConstraint;
    [FieldOffset(0x004C)] public FClothConstraintSetupNv BendConstraint;
    [FieldOffset(0x005C)] public FClothConstraintSetupNv ShearConstraint;
    [FieldOffset(0x006C)] public float SelfCollisionRadius;
    [FieldOffset(0x0070)] public float SelfCollisionStiffness;
    [FieldOffset(0x0074)] public float SelfCollisionCullScale;
    [FieldOffset(0x0078)] public FVector Damping;
    [FieldOffset(0x0084)] public float Friction;
    [FieldOffset(0x0088)] public float WindDragCoefficient;
    [FieldOffset(0x008C)] public float WindLiftCoefficient;
    [FieldOffset(0x0090)] public FVector LinearDrag;
    [FieldOffset(0x009C)] public FVector AngularDrag;
    [FieldOffset(0x00A8)] public FVector LinearInertiaScale;
    [FieldOffset(0x00B4)] public FVector AngularInertiaScale;
    [FieldOffset(0x00C0)] public FVector CentrifugalInertiaScale;
    [FieldOffset(0x00CC)] public float SolverFrequency;
    [FieldOffset(0x00D0)] public float StiffnessFrequency;
    [FieldOffset(0x00D4)] public float GravityScale;
    [FieldOffset(0x00D8)] public FVector GravityOverride;
    [FieldOffset(0x00E4)] public bool bUseGravityOverride;
    [FieldOffset(0x00E8)] public float TetherStiffness;
    [FieldOffset(0x00EC)] public float TetherLimit;
    [FieldOffset(0x00F0)] public float CollisionThickness;
    [FieldOffset(0x00F4)] public float AnimDriveSpringStiffness;
    [FieldOffset(0x00F8)] public float AnimDriveDamperStiffness;
    [FieldOffset(0x00FC)] public EClothingWindMethod_Legacy WindMethod;
    [FieldOffset(0x0100)] public FClothConstraintSetup_Legacy VerticalConstraintConfig;
    [FieldOffset(0x0110)] public FClothConstraintSetup_Legacy HorizontalConstraintConfig;
    [FieldOffset(0x0120)] public FClothConstraintSetup_Legacy BendConstraintConfig;
    [FieldOffset(0x0130)] public FClothConstraintSetup_Legacy ShearConstraintConfig;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothingSimulationFactoryNv
{
    [FieldOffset(0x0000)] public UClothingSimulationFactory baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UClothingSimulationInteractorNv
{
    [FieldOffset(0x0000)] public UClothingSimulationInteractor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UClothPhysicalMeshDataNv_Legacy
{
    [FieldOffset(0x0000)] public UClothPhysicalMeshDataBase_Legacy baseObj;
    [FieldOffset(0x00E0)] public TArray<float> MaxDistances;
    [FieldOffset(0x00F0)] public TArray<float> BackstopDistances;
    [FieldOffset(0x0100)] public TArray<float> BackstopRadiuses;
    [FieldOffset(0x0110)] public TArray<float> AnimDriveMultipliers;
}

