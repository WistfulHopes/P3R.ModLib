using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBodyInstanceCore
{
    [FieldOffset(0x0010)] public byte bSimulatePhysics;
    [FieldOffset(0x0010)] public byte bOverrideMass;
    [FieldOffset(0x0010)] public byte bEnableGravity;
    [FieldOffset(0x0010)] public byte bAutoWeld;
    [FieldOffset(0x0010)] public byte bStartAwake;
    [FieldOffset(0x0010)] public byte bGenerateWakeEvents;
    [FieldOffset(0x0010)] public byte bUpdateMassWhenScaleChanges;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBodySetupCore
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName BoneName;
    [FieldOffset(0x0030)] public EPhysicsType PhysicsType;
    [FieldOffset(0x0031)] public ECollisionTraceFlag CollisionTraceFlag;
    [FieldOffset(0x0032)] public EBodyCollisionResponse CollisionReponse;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UChaosPhysicalMaterial
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float Friction;
    [FieldOffset(0x002C)] public float StaticFriction;
    [FieldOffset(0x0030)] public float Restitution;
    [FieldOffset(0x0034)] public float LinearEtherDrag;
    [FieldOffset(0x0038)] public float AngularEtherDrag;
    [FieldOffset(0x003C)] public float SleepingLinearVelocityThreshold;
    [FieldOffset(0x0040)] public float SleepingAngularVelocityThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UPhysicalMaterial
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float Friction;
    [FieldOffset(0x002C)] public float StaticFriction;
    [FieldOffset(0x0030)] public EFrictionCombineMode FrictionCombineMode;
    [FieldOffset(0x0031)] public bool bOverrideFrictionCombineMode;
    [FieldOffset(0x0034)] public float Restitution;
    [FieldOffset(0x0038)] public EFrictionCombineMode RestitutionCombineMode;
    [FieldOffset(0x0039)] public bool bOverrideRestitutionCombineMode;
    [FieldOffset(0x003C)] public float Density;
    [FieldOffset(0x0040)] public float SleepLinearVelocityThreshold;
    [FieldOffset(0x0044)] public float SleepAngularVelocityThreshold;
    [FieldOffset(0x0048)] public int SleepCounterThreshold;
    [FieldOffset(0x004C)] public float RaiseMassToPower;
    [FieldOffset(0x0050)] public float DestructibleDamageThresholdScale;
    [FieldOffset(0x0058)] public UDEPRECATED_PhysicalMaterialPropertyBase* PhysicalMaterialProperty;
    [FieldOffset(0x0060)] public EPhysicalSurface SurfaceType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDEPRECATED_PhysicalMaterialPropertyBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UPhysicsSettingsCore
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public float DefaultGravityZ;
    [FieldOffset(0x003C)] public float DefaultTerminalVelocity;
    [FieldOffset(0x0040)] public float DefaultFluidFriction;
    [FieldOffset(0x0044)] public int SimulateScratchMemorySize;
    [FieldOffset(0x0048)] public int RagdollAggregateThreshold;
    [FieldOffset(0x004C)] public float TriangleMeshTriangleMinAreaThreshold;
    [FieldOffset(0x0050)] public bool bEnableShapeSharing;
    [FieldOffset(0x0051)] public bool bEnablePCM;
    [FieldOffset(0x0052)] public bool bEnableStabilization;
    [FieldOffset(0x0053)] public bool bWarnMissingLocks;
    [FieldOffset(0x0054)] public bool bEnable2DPhysics;
    [FieldOffset(0x0055)] public bool bDefaultHasComplexCollision;
    [FieldOffset(0x0058)] public float BounceThresholdVelocity;
    [FieldOffset(0x005C)] public EFrictionCombineMode FrictionCombineMode;
    [FieldOffset(0x005D)] public EFrictionCombineMode RestitutionCombineMode;
    [FieldOffset(0x0060)] public float MaxAngularVelocity;
    [FieldOffset(0x0064)] public float MaxDepenetrationVelocity;
    [FieldOffset(0x0068)] public float ContactOffsetMultiplier;
    [FieldOffset(0x006C)] public float MinContactOffset;
    [FieldOffset(0x0070)] public float MaxContactOffset;
    [FieldOffset(0x0074)] public bool bSimulateSkeletalMeshOnDedicatedServer;
    [FieldOffset(0x0075)] public ECollisionTraceFlag DefaultShapeComplexity;
    [FieldOffset(0x0078)] public FChaosSolverConfiguration SolverOptions;
}

