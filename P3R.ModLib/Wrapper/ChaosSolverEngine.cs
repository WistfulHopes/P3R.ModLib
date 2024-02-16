using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ChaosDebugDrawComponent : ObjectBase<UChaosDebugDrawComponent>
{
}

public unsafe class ChaosEventListenerComponent : ObjectBase<UChaosEventListenerComponent>
{
}

public unsafe class ChaosGameplayEventDispatcher : ObjectBase<UChaosGameplayEventDispatcher>
{

}

public unsafe class ChaosNotifyHandlerInterface : ObjectBase<IChaosNotifyHandlerInterface>
{
}

public unsafe class ChaosPhysicsCollisionInfo : ObjectBase<FChaosPhysicsCollisionInfo>
{

}

public unsafe class ChaosSolverEngineBlueprintLibrary : ObjectBase<UChaosSolverEngineBlueprintLibrary>
{

    public FHitResult ConvertPhysicsCollisionToHitResult(ref FChaosPhysicsCollisionInfo PhysicsCollision)
    {
        Span<(string name, object value)> @params = [
            ("PhysicsCollision", PhysicsCollision)
        ];
        return ProcessEvent<FHitResult>(GetFunction("ConvertPhysicsCollisionToHitResult"),  @params);
    }
}

public unsafe class ChaosSolver : ObjectBase<UChaosSolver>
{
}

public unsafe class ChaosSolverActor : ObjectBase<AChaosSolverActor>
{

    public void SetSolverActive(bool bActive)
    {
        Span<(string name, object value)> @params = [
            ("bActive", bActive)
        ];
        ProcessEvent(GetFunction("SetSolverActive"),  @params);
    }
    public void SetAsCurrentWorldSolver()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetAsCurrentWorldSolver"),  @params);
    }
}

public unsafe class ChaosSolverSettings : ObjectBase<UChaosSolverSettings>
{

}

public unsafe class ChaosBreakEvent : ObjectBase<FChaosBreakEvent>
{

}

public unsafe class ChaosHandlerSet : ObjectBase<FChaosHandlerSet>
{

}

public unsafe class BreakEventCallbackWrapper : ObjectBase<FBreakEventCallbackWrapper>
{
}

public unsafe class ChaosDebugSubstepControl : ObjectBase<FChaosDebugSubstepControl>
{

}

