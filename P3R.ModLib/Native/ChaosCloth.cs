using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FChaosClothWeightedValue
{
    [FieldOffset(0x0000)] public float Low;
    [FieldOffset(0x0004)] public float High;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UChaosClothConfig
{
    [FieldOffset(0x0000)] public UClothConfigCommon baseObj;
    [FieldOffset(0x0028)] public EClothMassMode MassMode;
    [FieldOffset(0x002C)] public float UniformMass;
    [FieldOffset(0x0030)] public float TotalMass;
    [FieldOffset(0x0034)] public float Density;
    [FieldOffset(0x0038)] public float MinPerParticleMass;
    [FieldOffset(0x003C)] public float EdgeStiffness;
    [FieldOffset(0x0040)] public float BendingStiffness;
    [FieldOffset(0x0044)] public bool bUseBendingElements;
    [FieldOffset(0x0048)] public float AreaStiffness;
    [FieldOffset(0x004C)] public float VolumeStiffness;
    [FieldOffset(0x0050)] public FChaosClothWeightedValue TetherStiffness;
    [FieldOffset(0x0058)] public float LimitScale;
    [FieldOffset(0x005C)] public bool bUseGeodesicDistance;
    [FieldOffset(0x0060)] public float ShapeTargetStiffness;
    [FieldOffset(0x0064)] public float CollisionThickness;
    [FieldOffset(0x0068)] public float FrictionCoefficient;
    [FieldOffset(0x006C)] public bool bUseCCD;
    [FieldOffset(0x006D)] public bool bUseSelfCollisions;
    [FieldOffset(0x0070)] public float SelfCollisionThickness;
    [FieldOffset(0x0074)] public bool bUseLegacyBackstop;
    [FieldOffset(0x0078)] public float DampingCoefficient;
    [FieldOffset(0x007C)] public bool bUsePointBasedWindModel;
    [FieldOffset(0x0080)] public float DragCoefficient;
    [FieldOffset(0x0084)] public float LiftCoefficient;
    [FieldOffset(0x0088)] public bool bUseGravityOverride;
    [FieldOffset(0x008C)] public float GravityScale;
    [FieldOffset(0x0090)] public FVector Gravity;
    [FieldOffset(0x009C)] public FChaosClothWeightedValue AnimDriveStiffness;
    [FieldOffset(0x00A4)] public FChaosClothWeightedValue AnimDriveDamping;
    [FieldOffset(0x00AC)] public FVector LinearVelocityScale;
    [FieldOffset(0x00B8)] public float AngularVelocityScale;
    [FieldOffset(0x00BC)] public float FictitiousAngularScale;
    [FieldOffset(0x00C0)] public bool bUseTetrahedralConstraints;
    [FieldOffset(0x00C1)] public bool bUseThinShellVolumeConstraints;
    [FieldOffset(0x00C2)] public bool bUseContinuousCollisionDetection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UChaosClothSharedSimConfig
{
    [FieldOffset(0x0000)] public UClothSharedConfigCommon baseObj;
    [FieldOffset(0x0028)] public int IterationCount;
    [FieldOffset(0x002C)] public int SubdivisionCount;
    [FieldOffset(0x0030)] public bool bUseLocalSpaceSimulation;
    [FieldOffset(0x0031)] public bool bUseXPBDConstraints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UChaosClothingSimulationFactory
{
    [FieldOffset(0x0000)] public UClothingSimulationFactory baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UChaosClothingInteractor
{
    [FieldOffset(0x0000)] public UClothingInteractor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UChaosClothingSimulationInteractor
{
    [FieldOffset(0x0000)] public UClothingSimulationInteractor baseObj;
}

