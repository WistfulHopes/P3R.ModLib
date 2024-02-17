using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ChaosDebugDrawComponent : ObjectBase<UChaosDebugDrawComponent>
{
    public ChaosDebugDrawComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class ChaosEventListenerComponent : ObjectBase<UChaosEventListenerComponent>
{
    public ChaosEventListenerComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class ChaosGameplayEventDispatcher : ObjectBase<UChaosGameplayEventDispatcher>
{
    public ChaosGameplayEventDispatcher(IntPtr pointer) : base(pointer) {}
}

public unsafe class ChaosNotifyHandlerInterface : ObjectBase<IChaosNotifyHandlerInterface>
{
    public ChaosNotifyHandlerInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class ChaosSolverEngineBlueprintLibrary : ObjectBase<UChaosSolverEngineBlueprintLibrary>
{
    public ChaosSolverEngineBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public FHitResult ConvertPhysicsCollisionToHitResult(ref FChaosPhysicsCollisionInfo PhysicsCollision)
    {
        Span<(string name, object value)> @params = [
            ("PhysicsCollision", PhysicsCollision)
        ];
        return ProcessEvent<FHitResult>(GetFunction("ConvertPhysicsCollisionToHitResult"), @params);
    }
}

public unsafe class ChaosSolver : ObjectBase<UChaosSolver>
{
    public ChaosSolver(IntPtr pointer) : base(pointer) {}}

public unsafe class ChaosSolverActor : ObjectBase<AChaosSolverActor>
{
    public ChaosSolverActor(IntPtr pointer) : base(pointer) {}
    public void SetSolverActive(bool bActive)
    {
        Span<(string name, object value)> @params = [
            ("bActive", bActive)
        ];
        ProcessEvent(GetFunction("SetSolverActive"), @params);
    }
    public void SetAsCurrentWorldSolver()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetAsCurrentWorldSolver"), @params);
    }
}

public unsafe class ChaosSolverSettings : ObjectBase<UChaosSolverSettings>
{
    public ChaosSolverSettings(IntPtr pointer) : base(pointer) {}
}

