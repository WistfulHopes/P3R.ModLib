using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UChaosDebugDrawComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UChaosEventListenerComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FChaosHandlerSet
{
    [FieldOffset(0x0008)] public TSet<IntPtr> ChaosHandlers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBreakEventCallbackWrapper
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UChaosGameplayEventDispatcher
{
    [FieldOffset(0x0000)] public UChaosEventListenerComponent baseObj;
    [FieldOffset(0x01C8)] public TMap<IntPtr, FChaosHandlerSet> CollisionEventRegistrations;
    [FieldOffset(0x0218)] public TMap<IntPtr, FBreakEventCallbackWrapper> BreakEventRegistrations;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IChaosNotifyHandlerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FChaosPhysicsCollisionInfo
{
    [FieldOffset(0x0000)] public UPrimitiveComponent* Component;
    [FieldOffset(0x0008)] public UPrimitiveComponent* OtherComponent;
    [FieldOffset(0x0010)] public FVector Location;
    [FieldOffset(0x001C)] public FVector Normal;
    [FieldOffset(0x0028)] public FVector AccumulatedImpulse;
    [FieldOffset(0x0034)] public FVector Velocity;
    [FieldOffset(0x0040)] public FVector OtherVelocity;
    [FieldOffset(0x004C)] public FVector AngularVelocity;
    [FieldOffset(0x0058)] public FVector OtherAngularVelocity;
    [FieldOffset(0x0064)] public float Mass;
    [FieldOffset(0x0068)] public float OtherMass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UChaosSolverEngineBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UChaosSolver
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FChaosDebugSubstepControl
{
    [FieldOffset(0x0000)] public bool bPause;
    [FieldOffset(0x0001)] public bool bSubstep;
    [FieldOffset(0x0002)] public bool bStep;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct AChaosSolverActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public FChaosSolverConfiguration Properties;
    [FieldOffset(0x0288)] public float TimeStepMultiplier;
    [FieldOffset(0x028C)] public int CollisionIterations;
    [FieldOffset(0x0290)] public int PushOutIterations;
    [FieldOffset(0x0294)] public int PushOutPairIterations;
    [FieldOffset(0x0298)] public float ClusterConnectionFactor;
    [FieldOffset(0x029C)] public EClusterConnectionTypeEnum ClusterUnionConnectionType;
    [FieldOffset(0x029D)] public bool DoGenerateCollisionData;
    [FieldOffset(0x02A0)] public FSolverCollisionFilterSettings CollisionFilterSettings;
    [FieldOffset(0x02B0)] public bool DoGenerateBreakingData;
    [FieldOffset(0x02B4)] public FSolverBreakingFilterSettings BreakingFilterSettings;
    [FieldOffset(0x02C4)] public bool DoGenerateTrailingData;
    [FieldOffset(0x02C8)] public FSolverTrailingFilterSettings TrailingFilterSettings;
    [FieldOffset(0x02D8)] public float MassScale;
    [FieldOffset(0x02DC)] public bool bGenerateContactGraph;
    [FieldOffset(0x02DD)] public bool bHasFloor;
    [FieldOffset(0x02E0)] public float FloorHeight;
    [FieldOffset(0x02E4)] public FChaosDebugSubstepControl ChaosDebugSubstepControl;
    [FieldOffset(0x02E8)] public UBillboardComponent* SpriteComponent;
    [FieldOffset(0x0308)] public UChaosGameplayEventDispatcher* GameplayEventDispatcherComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UChaosSolverSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0040)] public FSoftClassPath DefaultChaosSolverActorClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FChaosBreakEvent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent* Component;
    [FieldOffset(0x0008)] public FVector Location;
    [FieldOffset(0x0014)] public FVector Velocity;
    [FieldOffset(0x0020)] public FVector AngularVelocity;
    [FieldOffset(0x002C)] public float Mass;
}

