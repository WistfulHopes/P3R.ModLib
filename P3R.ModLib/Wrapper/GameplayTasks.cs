using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class GameplayTask : ObjectBase<UGameplayTask>
{
    public GameplayTask(IntPtr pointer) : base(pointer) {}
    public void ReadyForActivation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReadyForActivation"), @params);
    }
    public void GenericGameplayTaskDelegate__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GenericGameplayTaskDelegate__DelegateSignature"), @params);
    }
    public void EndTask()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndTask"), @params);
    }
}

public unsafe class GameplayTask_ClaimResource : ObjectBase<UGameplayTask_ClaimResource>
{
    public GameplayTask_ClaimResource(IntPtr pointer) : base(pointer) {}
    public UGameplayTask_ClaimResource* ClaimResources(TScriptInterface<IGameplayTaskOwnerInterface> InTaskOwner, TArray<TSubclassOf<UGameplayTaskResource>> ResourceClasses, byte Priority, FName TaskInstanceName)
    {
        Span<(string name, object value)> @params = [
            ("InTaskOwner", InTaskOwner), 
            ("ResourceClasses", ResourceClasses), 
            ("Priority", Priority), 
            ("TaskInstanceName", TaskInstanceName)
        ];
        return (UGameplayTask_ClaimResource*)ProcessEvent<IntPtr>(GetFunction("ClaimResources"), @params);
    }
    public UGameplayTask_ClaimResource* ClaimResource(TScriptInterface<IGameplayTaskOwnerInterface> InTaskOwner, TSubclassOf<UGameplayTaskResource> ResourceClass, byte Priority, FName TaskInstanceName)
    {
        Span<(string name, object value)> @params = [
            ("InTaskOwner", InTaskOwner), 
            ("ResourceClass", ResourceClass), 
            ("Priority", Priority), 
            ("TaskInstanceName", TaskInstanceName)
        ];
        return (UGameplayTask_ClaimResource*)ProcessEvent<IntPtr>(GetFunction("ClaimResource"), @params);
    }
}

public unsafe class GameplayTask_SpawnActor : ObjectBase<UGameplayTask_SpawnActor>
{
    public GameplayTask_SpawnActor(IntPtr pointer) : base(pointer) {}
    public UGameplayTask_SpawnActor* SpawnActor(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, FVector SpawnLocation, FRotator SpawnRotation, TSubclassOf<AActor> Class, bool bSpawnOnlyOnAuthority)
    {
        Span<(string name, object value)> @params = [
            ("TaskOwner", TaskOwner), 
            ("SpawnLocation", SpawnLocation), 
            ("SpawnRotation", SpawnRotation), 
            ("Class", Class), 
            ("bSpawnOnlyOnAuthority", bSpawnOnlyOnAuthority)
        ];
        return (UGameplayTask_SpawnActor*)ProcessEvent<IntPtr>(GetFunction("SpawnActor"), @params);
    }
    public void FinishSpawningActor(UObject* WorldContextObject, AActor* SpawnedActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SpawnedActor", (IntPtr)SpawnedActor)
        ];
        ProcessEvent(GetFunction("FinishSpawningActor"), @params);
    }
    public bool BeginSpawningActor(UObject* WorldContextObject, ref AActor* SpawnedActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SpawnedActor", (IntPtr)SpawnedActor)
        ];
        return ProcessEvent<bool>(GetFunction("BeginSpawningActor"), @params);
    }
}

public unsafe class GameplayTask_TimeLimitedExecution : ObjectBase<UGameplayTask_TimeLimitedExecution>
{
    public GameplayTask_TimeLimitedExecution(IntPtr pointer) : base(pointer) {}
}

public unsafe class GameplayTask_WaitDelay : ObjectBase<UGameplayTask_WaitDelay>
{
    public GameplayTask_WaitDelay(IntPtr pointer) : base(pointer) {}
    public UGameplayTask_WaitDelay* TaskWaitDelay(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, float Time, byte Priority)
    {
        Span<(string name, object value)> @params = [
            ("TaskOwner", TaskOwner), 
            ("Time", Time), 
            ("Priority", Priority)
        ];
        return (UGameplayTask_WaitDelay*)ProcessEvent<IntPtr>(GetFunction("TaskWaitDelay"), @params);
    }
    public void TaskDelayDelegate__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("TaskDelayDelegate__DelegateSignature"), @params);
    }
}

public unsafe class GameplayTaskOwnerInterface : ObjectBase<IGameplayTaskOwnerInterface>
{
    public GameplayTaskOwnerInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class GameplayTaskResource : ObjectBase<UGameplayTaskResource>
{
    public GameplayTaskResource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GameplayTasksComponent : ObjectBase<UGameplayTasksComponent>
{
    public GameplayTasksComponent(IntPtr pointer) : base(pointer) {}
    public void OnRep_SimulatedTasks()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_SimulatedTasks"), @params);
    }
    public EGameplayTaskRunResult K2_RunGameplayTask(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, UGameplayTask* Task, byte Priority, TArray<TSubclassOf<UGameplayTaskResource>> AdditionalRequiredResources, TArray<TSubclassOf<UGameplayTaskResource>> AdditionalClaimedResources)
    {
        Span<(string name, object value)> @params = [
            ("TaskOwner", TaskOwner), 
            ("Task", (IntPtr)Task), 
            ("Priority", Priority), 
            ("AdditionalRequiredResources", AdditionalRequiredResources), 
            ("AdditionalClaimedResources", AdditionalClaimedResources)
        ];
        return ProcessEvent<EGameplayTaskRunResult>(GetFunction("K2_RunGameplayTask"), @params);
    }
}

