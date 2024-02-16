using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ChaosTrailingEventData : ObjectBase<FChaosTrailingEventData>
{

}

public unsafe class ChaosCollisionEventData : ObjectBase<FChaosCollisionEventData>
{

}

public unsafe class ChaosBreakingEventData : ObjectBase<FChaosBreakingEventData>
{

}

public unsafe class ChaosTrailingEventRequestSettings : ObjectBase<FChaosTrailingEventRequestSettings>
{

}

public unsafe class ChaosCollisionEventRequestSettings : ObjectBase<FChaosCollisionEventRequestSettings>
{

}

public unsafe class ChaosBreakingEventRequestSettings : ObjectBase<FChaosBreakingEventRequestSettings>
{

}

public unsafe class ChaosDestructionListener : ObjectBase<UChaosDestructionListener>
{

    public void SortTrailingEvents(ref TArray<FChaosTrailingEventData> TrailingEvents, EChaosTrailingSortMethod SortMethod)
    {
        Span<(string name, object value)> @params = [
            ("TrailingEvents", TrailingEvents), 
            ("SortMethod", SortMethod)
        ];
        ProcessEvent(GetFunction("SortTrailingEvents"),  @params);
    }
    public void SortCollisionEvents(ref TArray<FChaosCollisionEventData> CollisionEvents, EChaosCollisionSortMethod SortMethod)
    {
        Span<(string name, object value)> @params = [
            ("CollisionEvents", CollisionEvents), 
            ("SortMethod", SortMethod)
        ];
        ProcessEvent(GetFunction("SortCollisionEvents"),  @params);
    }
    public void SortBreakingEvents(ref TArray<FChaosBreakingEventData> BreakingEvents, EChaosBreakingSortMethod SortMethod)
    {
        Span<(string name, object value)> @params = [
            ("BreakingEvents", BreakingEvents), 
            ("SortMethod", SortMethod)
        ];
        ProcessEvent(GetFunction("SortBreakingEvents"),  @params);
    }
    public void SetTrailingEventRequestSettings(ref FChaosTrailingEventRequestSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetTrailingEventRequestSettings"),  @params);
    }
    public void SetTrailingEventEnabled(bool bIsEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bIsEnabled", bIsEnabled)
        ];
        ProcessEvent(GetFunction("SetTrailingEventEnabled"),  @params);
    }
    public void SetCollisionEventRequestSettings(ref FChaosCollisionEventRequestSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetCollisionEventRequestSettings"),  @params);
    }
    public void SetCollisionEventEnabled(bool bIsEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bIsEnabled", bIsEnabled)
        ];
        ProcessEvent(GetFunction("SetCollisionEventEnabled"),  @params);
    }
    public void SetBreakingEventRequestSettings(ref FChaosBreakingEventRequestSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetBreakingEventRequestSettings"),  @params);
    }
    public void SetBreakingEventEnabled(bool bIsEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bIsEnabled", bIsEnabled)
        ];
        ProcessEvent(GetFunction("SetBreakingEventEnabled"),  @params);
    }
    public void RemoveGeometryCollectionActor(AGeometryCollectionActor* GeometryCollectionActor)
    {
        Span<(string name, object value)> @params = [
            ("GeometryCollectionActor", (IntPtr)GeometryCollectionActor)
        ];
        ProcessEvent(GetFunction("RemoveGeometryCollectionActor"),  @params);
    }
    public void RemoveChaosSolverActor(AChaosSolverActor* ChaosSolverActor)
    {
        Span<(string name, object value)> @params = [
            ("ChaosSolverActor", (IntPtr)ChaosSolverActor)
        ];
        ProcessEvent(GetFunction("RemoveChaosSolverActor"),  @params);
    }
    public bool IsEventListening()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEventListening"),  @params);
    }
    public void AddGeometryCollectionActor(AGeometryCollectionActor* GeometryCollectionActor)
    {
        Span<(string name, object value)> @params = [
            ("GeometryCollectionActor", (IntPtr)GeometryCollectionActor)
        ];
        ProcessEvent(GetFunction("AddGeometryCollectionActor"),  @params);
    }
    public void AddChaosSolverActor(AChaosSolverActor* ChaosSolverActor)
    {
        Span<(string name, object value)> @params = [
            ("ChaosSolverActor", (IntPtr)ChaosSolverActor)
        ];
        ProcessEvent(GetFunction("AddChaosSolverActor"),  @params);
    }
}

public unsafe class GeometryCollectionActor : ObjectBase<AGeometryCollectionActor>
{

    public bool RaycastSingle(FVector Start, FVector End, ref FHitResult OutHit)
    {
        Span<(string name, object value)> @params = [
            ("Start", Start), 
            ("End", End), 
            ("OutHit", OutHit)
        ];
        return ProcessEvent<bool>(GetFunction("RaycastSingle"),  @params);
    }
}

public unsafe class GeometryCollectionCache : ObjectBase<UGeometryCollectionCache>
{

}

public unsafe class GeometryCollectionRepData : ObjectBase<FGeometryCollectionRepData>
{
}

public unsafe class GeometryCollectionComponent : ObjectBase<UGeometryCollectionComponent>
{

    public void SetNotifyBreaks(bool bNewNotifyBreaks)
    {
        Span<(string name, object value)> @params = [
            ("bNewNotifyBreaks", bNewNotifyBreaks)
        ];
        ProcessEvent(GetFunction("SetNotifyBreaks"),  @params);
    }
    public void ReceivePhysicsCollision(ref FChaosPhysicsCollisionInfo CollisionInfo)
    {
        Span<(string name, object value)> @params = [
            ("CollisionInfo", CollisionInfo)
        ];
        ProcessEvent(GetFunction("ReceivePhysicsCollision"),  @params);
    }
    public void OnRep_RepData(ref FGeometryCollectionRepData OldData)
    {
        Span<(string name, object value)> @params = [
            ("OldData", OldData)
        ];
        ProcessEvent(GetFunction("OnRep_RepData"),  @params);
    }
    public void NotifyGeometryCollectionPhysicsStateChange__DelegateSignature(UGeometryCollectionComponent* FracturedComponent)
    {
        Span<(string name, object value)> @params = [
            ("FracturedComponent", (IntPtr)FracturedComponent)
        ];
        ProcessEvent(GetFunction("NotifyGeometryCollectionPhysicsStateChange__DelegateSignature"),  @params);
    }
    public void NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature(UGeometryCollectionComponent* FracturedComponent)
    {
        Span<(string name, object value)> @params = [
            ("FracturedComponent", (IntPtr)FracturedComponent)
        ];
        ProcessEvent(GetFunction("NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature"),  @params);
    }
    public void NetAbandonCluster(int TransformIndex)
    {
        Span<(string name, object value)> @params = [
            ("TransformIndex", TransformIndex)
        ];
        ProcessEvent(GetFunction("NetAbandonCluster"),  @params);
    }
    public void ApplyPhysicsField(bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, UFieldSystemMetaData* MetaData, UFieldNodeBase* Field)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Target", Target), 
            ("MetaData", (IntPtr)MetaData), 
            ("Field", (IntPtr)Field)
        ];
        ProcessEvent(GetFunction("ApplyPhysicsField"),  @params);
    }
    public void ApplyKinematicField(float Radius, FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("Radius", Radius), 
            ("Position", Position)
        ];
        ProcessEvent(GetFunction("ApplyKinematicField"),  @params);
    }
}

public unsafe class GeometryCollectionDebugDrawActor : ObjectBase<AGeometryCollectionDebugDrawActor>
{

}

public unsafe class GeometryCollectionDebugDrawComponent : ObjectBase<UGeometryCollectionDebugDrawComponent>
{

}

public unsafe class GeometryCollection : ObjectBase<UGeometryCollection>
{

}

public unsafe class GeometryCollectionRenderLevelSetActor : ObjectBase<AGeometryCollectionRenderLevelSetActor>
{

}

public unsafe class SkeletalMeshSimulationComponent : ObjectBase<USkeletalMeshSimulationComponent>
{

    public void ReceivePhysicsCollision(ref FChaosPhysicsCollisionInfo CollisionInfo)
    {
        Span<(string name, object value)> @params = [
            ("CollisionInfo", CollisionInfo)
        ];
        ProcessEvent(GetFunction("ReceivePhysicsCollision"),  @params);
    }
}

public unsafe class StaticMeshSimulationComponent : ObjectBase<UStaticMeshSimulationComponent>
{

    public void ReceivePhysicsCollision(ref FChaosPhysicsCollisionInfo CollisionInfo)
    {
        Span<(string name, object value)> @params = [
            ("CollisionInfo", CollisionInfo)
        ];
        ProcessEvent(GetFunction("ReceivePhysicsCollision"),  @params);
    }
    public void ForceRecreatePhysicsState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceRecreatePhysicsState"),  @params);
    }
}

public unsafe class GeomComponentCacheParameters : ObjectBase<FGeomComponentCacheParameters>
{

}

public unsafe class GeometryCollectionDebugDrawActorSelectedRigidBody : ObjectBase<FGeometryCollectionDebugDrawActorSelectedRigidBody>
{

}

public unsafe class GeometryCollectionDebugDrawWarningMessage : ObjectBase<FGeometryCollectionDebugDrawWarningMessage>
{
}

public unsafe class GeometryCollectionSizeSpecificData : ObjectBase<FGeometryCollectionSizeSpecificData>
{

}

public unsafe class GeometryCollectionSource : ObjectBase<FGeometryCollectionSource>
{

}

