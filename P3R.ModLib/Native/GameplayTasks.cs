using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FGameplayResourceSet
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UGameplayTask
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FName InstanceName;
    [FieldOffset(0x003A)] public ETaskResourceOverlapPolicy ResourceOverlapPolicy;
    [FieldOffset(0x0060)] public UGameplayTask* ChildTask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UGameplayTask_ClaimResource
{
    [FieldOffset(0x0000)] public UGameplayTask baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UGameplayTask_SpawnActor
{
    [FieldOffset(0x0000)] public UGameplayTask baseObj;
    [FieldOffset(0x00A0)] public TSubclassOf<AActor> ClassToSpawn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UGameplayTask_TimeLimitedExecution
{
    [FieldOffset(0x0000)] public UGameplayTask baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UGameplayTask_WaitDelay
{
    [FieldOffset(0x0000)] public UGameplayTask baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGameplayTaskOwnerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UGameplayTaskResource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int ManualResourceID;
    [FieldOffset(0x002C)] public sbyte AutoResourceID;
    [FieldOffset(0x0030)] public byte bManuallySetID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UGameplayTasksComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00BC)] public byte bIsNetDirty;
    [FieldOffset(0x00C0)] public TArray<IntPtr> SimulatedTasks;
    [FieldOffset(0x00D0)] public TArray<IntPtr> TaskPriorityQueue;
    [FieldOffset(0x00F0)] public TArray<IntPtr> TickingTasks;
    [FieldOffset(0x0100)] public TArray<IntPtr> KnownTasks;
}

