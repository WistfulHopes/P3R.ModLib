using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class NavAreaMeta_SwitchByAgent : ObjectBase<UNavAreaMeta_SwitchByAgent>
{
    public NavAreaMeta_SwitchByAgent(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavCollision : ObjectBase<UNavCollision>
{
    public NavCollision(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavigationGraph : ObjectBase<ANavigationGraph>
{
    public NavigationGraph(IntPtr pointer) : base(pointer) {}}

public unsafe class NavigationGraphNode : ObjectBase<ANavigationGraphNode>
{
    public NavigationGraphNode(IntPtr pointer) : base(pointer) {}}

public unsafe class NavigationGraphNodeComponent : ObjectBase<UNavigationGraphNodeComponent>
{
    public NavigationGraphNodeComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavigationInvokerComponent : ObjectBase<UNavigationInvokerComponent>
{
    public NavigationInvokerComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavigationPath : ObjectBase<UNavigationPath>
{
    public NavigationPath(IntPtr pointer) : base(pointer) {}
    public bool IsValid()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsValid"), @params);
    }
    public bool IsStringPulled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsStringPulled"), @params);
    }
    public bool IsPartial()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPartial"), @params);
    }
    public float GetPathLength()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPathLength"), @params);
    }
    public float GetPathCost()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPathCost"), @params);
    }
    public FString GetDebugString()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugString"), @params);
    }
    public void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation)
    {
        Span<(string name, object value)> @params = [
            ("DoRecalculation", DoRecalculation)
        ];
        ProcessEvent(GetFunction("EnableRecalculationOnInvalidation"), @params);
    }
    public void EnableDebugDrawing(bool bShouldDrawDebugData, FLinearColor PathColor)
    {
        Span<(string name, object value)> @params = [
            ("bShouldDrawDebugData", bShouldDrawDebugData), 
            ("PathColor", PathColor)
        ];
        ProcessEvent(GetFunction("EnableDebugDrawing"), @params);
    }
}

public unsafe class NavigationPathGenerator : ObjectBase<INavigationPathGenerator>
{
    public NavigationPathGenerator(IntPtr pointer) : base(pointer) {}}

public unsafe class NavigationQueryFilter : ObjectBase<UNavigationQueryFilter>
{
    public NavigationQueryFilter(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavigationSystemV1 : ObjectBase<UNavigationSystemV1>
{
    public NavigationSystemV1(IntPtr pointer) : base(pointer) {}
    public void UnregisterNavigationInvoker(AActor* Invoker)
    {
        Span<(string name, object value)> @params = [
            ("Invoker", (IntPtr)Invoker)
        ];
        ProcessEvent(GetFunction("UnregisterNavigationInvoker"), @params);
    }
    public void SimpleMoveToLocation(AController* Controller, ref FVector Goal)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("Goal", Goal)
        ];
        ProcessEvent(GetFunction("SimpleMoveToLocation"), @params);
    }
    public void SimpleMoveToActor(AController* Controller, AActor* Goal)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("Goal", (IntPtr)Goal)
        ];
        ProcessEvent(GetFunction("SimpleMoveToActor"), @params);
    }
    public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
    {
        Span<(string name, object value)> @params = [
            ("MaxNumberOfJobs", MaxNumberOfJobs)
        ];
        ProcessEvent(GetFunction("SetMaxSimultaneousTileGenerationJobsCount"), @params);
    }
    public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)
    {
        Span<(string name, object value)> @params = [
            ("NewMode", NewMode)
        ];
        ProcessEvent(GetFunction("SetGeometryGatheringMode"), @params);
    }
    public void ResetMaxSimultaneousTileGenerationJobsCount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetMaxSimultaneousTileGenerationJobsCount"), @params);
    }
    public void RegisterNavigationInvoker(AActor* Invoker, float TileGenerationRadius, float TileRemovalRadius)
    {
        Span<(string name, object value)> @params = [
            ("Invoker", (IntPtr)Invoker), 
            ("TileGenerationRadius", TileGenerationRadius), 
            ("TileRemovalRadius", TileRemovalRadius)
        ];
        ProcessEvent(GetFunction("RegisterNavigationInvoker"), @params);
    }
    public FVector ProjectPointToNavigation(UObject* WorldContextObject, ref FVector Point, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Point", Point), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass), 
            ("QueryExtent", QueryExtent)
        ];
        return ProcessEvent<FVector>(GetFunction("ProjectPointToNavigation"), @params);
    }
    public void OnNavigationBoundsUpdated(ANavMeshBoundsVolume* NavVolume)
    {
        Span<(string name, object value)> @params = [
            ("NavVolume", (IntPtr)NavVolume)
        ];
        ProcessEvent(GetFunction("OnNavigationBoundsUpdated"), @params);
    }
    public bool NavigationRaycast(UObject* WorldContextObject, ref FVector RayStart, ref FVector RayEnd, ref FVector HitLocation, TSubclassOf<UNavigationQueryFilter> FilterClass, AController* Querier)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("RayStart", RayStart), 
            ("RayEnd", RayEnd), 
            ("HitLocation", HitLocation), 
            ("FilterClass", FilterClass), 
            ("Querier", (IntPtr)Querier)
        ];
        return ProcessEvent<bool>(GetFunction("NavigationRaycast"), @params);
    }
    public bool K2_ReplaceAreaInOctreeData(UObject* Object, TSubclassOf<UNavArea> OldArea, TSubclassOf<UNavArea> NewArea)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("OldArea", OldArea), 
            ("NewArea", NewArea)
        ];
        return ProcessEvent<bool>(GetFunction("K2_ReplaceAreaInOctreeData"), @params);
    }
    public bool K2_ProjectPointToNavigation(UObject* WorldContextObject, ref FVector Point, ref FVector ProjectedLocation, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Point", Point), 
            ("ProjectedLocation", ProjectedLocation), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass), 
            ("QueryExtent", QueryExtent)
        ];
        return ProcessEvent<bool>(GetFunction("K2_ProjectPointToNavigation"), @params);
    }
    public bool K2_GetRandomReachablePointInRadius(UObject* WorldContextObject, ref FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Origin", Origin), 
            ("RandomLocation", RandomLocation), 
            ("Radius", Radius), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<bool>(GetFunction("K2_GetRandomReachablePointInRadius"), @params);
    }
    public bool K2_GetRandomPointInNavigableRadius(UObject* WorldContextObject, ref FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Origin", Origin), 
            ("RandomLocation", RandomLocation), 
            ("Radius", Radius), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<bool>(GetFunction("K2_GetRandomPointInNavigableRadius"), @params);
    }
    public bool K2_GetRandomLocationInNavigableRadius(UObject* WorldContextObject, ref FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Origin", Origin), 
            ("RandomLocation", RandomLocation), 
            ("Radius", Radius), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<bool>(GetFunction("K2_GetRandomLocationInNavigableRadius"), @params);
    }
    public bool IsNavigationBeingBuiltOrLocked(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<bool>(GetFunction("IsNavigationBeingBuiltOrLocked"), @params);
    }
    public bool IsNavigationBeingBuilt(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<bool>(GetFunction("IsNavigationBeingBuilt"), @params);
    }
    public FVector GetRandomReachablePointInRadius(UObject* WorldContextObject, ref FVector Origin, float Radius, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Origin", Origin), 
            ("Radius", Radius), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<FVector>(GetFunction("GetRandomReachablePointInRadius"), @params);
    }
    public FVector GetRandomPointInNavigableRadius(UObject* WorldContextObject, ref FVector Origin, float Radius, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Origin", Origin), 
            ("Radius", Radius), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<FVector>(GetFunction("GetRandomPointInNavigableRadius"), @params);
    }
    public ENavigationQueryResult GetPathLength(UObject* WorldContextObject, ref FVector PathStart, ref FVector PathEnd, ref float PathLength, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PathStart", PathStart), 
            ("PathEnd", PathEnd), 
            ("PathLength", PathLength), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<ENavigationQueryResult>(GetFunction("GetPathLength"), @params);
    }
    public ENavigationQueryResult GetPathCost(UObject* WorldContextObject, ref FVector PathStart, ref FVector PathEnd, ref float PathCost, ANavigationData* NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PathStart", PathStart), 
            ("PathEnd", PathEnd), 
            ("PathCost", PathCost), 
            ("NavData", (IntPtr)NavData), 
            ("FilterClass", FilterClass)
        ];
        return ProcessEvent<ENavigationQueryResult>(GetFunction("GetPathCost"), @params);
    }
    public UNavigationSystemV1* GetNavigationSystem(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (UNavigationSystemV1*)ProcessEvent<IntPtr>(GetFunction("GetNavigationSystem"), @params);
    }
    public UNavigationPath* FindPathToLocationSynchronously(UObject* WorldContextObject, ref FVector PathStart, ref FVector PathEnd, AActor* PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PathStart", PathStart), 
            ("PathEnd", PathEnd), 
            ("PathfindingContext", (IntPtr)PathfindingContext), 
            ("FilterClass", FilterClass)
        ];
        return (UNavigationPath*)ProcessEvent<IntPtr>(GetFunction("FindPathToLocationSynchronously"), @params);
    }
    public UNavigationPath* FindPathToActorSynchronously(UObject* WorldContextObject, ref FVector PathStart, AActor* GoalActor, float TetherDistance, AActor* PathfindingContext, TSubclassOf<UNavigationQueryFilter> FilterClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PathStart", PathStart), 
            ("GoalActor", (IntPtr)GoalActor), 
            ("TetherDistance", TetherDistance), 
            ("PathfindingContext", (IntPtr)PathfindingContext), 
            ("FilterClass", FilterClass)
        ];
        return (UNavigationPath*)ProcessEvent<IntPtr>(GetFunction("FindPathToActorSynchronously"), @params);
    }
}

public unsafe class NavigationSystemModuleConfig : ObjectBase<UNavigationSystemModuleConfig>
{
    public NavigationSystemModuleConfig(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavigationTestingActor : ObjectBase<ANavigationTestingActor>
{
    public NavigationTestingActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavLinkComponent : ObjectBase<UNavLinkComponent>
{
    public NavLinkComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavRelevantComponent : ObjectBase<UNavRelevantComponent>
{
    public NavRelevantComponent(IntPtr pointer) : base(pointer) {}
    public void SetNavigationRelevancy(bool bRelevant)
    {
        Span<(string name, object value)> @params = [
            ("bRelevant", bRelevant)
        ];
        ProcessEvent(GetFunction("SetNavigationRelevancy"), @params);
    }
}

public unsafe class NavArea_LowHeight : ObjectBase<UNavArea_LowHeight>
{
    public NavArea_LowHeight(IntPtr pointer) : base(pointer) {}}

public unsafe class NavLinkCustomInterface : ObjectBase<INavLinkCustomInterface>
{
    public NavLinkCustomInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class NavLinkHostInterface : ObjectBase<INavLinkHostInterface>
{
    public NavLinkHostInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class NavLinkRenderingComponent : ObjectBase<UNavLinkRenderingComponent>
{
    public NavLinkRenderingComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class NavLinkTrivial : ObjectBase<UNavLinkTrivial>
{
    public NavLinkTrivial(IntPtr pointer) : base(pointer) {}}

public unsafe class NavMeshBoundsVolume : ObjectBase<ANavMeshBoundsVolume>
{
    public NavMeshBoundsVolume(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavMeshRenderingComponent : ObjectBase<UNavMeshRenderingComponent>
{
    public NavMeshRenderingComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class NavModifierComponent : ObjectBase<UNavModifierComponent>
{
    public NavModifierComponent(IntPtr pointer) : base(pointer) {}
    public void SetAreaClass(TSubclassOf<UNavArea> NewAreaClass)
    {
        Span<(string name, object value)> @params = [
            ("NewAreaClass", NewAreaClass)
        ];
        ProcessEvent(GetFunction("SetAreaClass"), @params);
    }
}

public unsafe class NavModifierVolume : ObjectBase<ANavModifierVolume>
{
    public NavModifierVolume(IntPtr pointer) : base(pointer) {}
    public void SetAreaClass(TSubclassOf<UNavArea> NewAreaClass)
    {
        Span<(string name, object value)> @params = [
            ("NewAreaClass", NewAreaClass)
        ];
        ProcessEvent(GetFunction("SetAreaClass"), @params);
    }
}

public unsafe class NavNodeInterface : ObjectBase<INavNodeInterface>
{
    public NavNodeInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class NavSystemConfigOverride : ObjectBase<ANavSystemConfigOverride>
{
    public NavSystemConfigOverride(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavTestRenderingComponent : ObjectBase<UNavTestRenderingComponent>
{
    public NavTestRenderingComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class RecastFilter_UseDefaultArea : ObjectBase<URecastFilter_UseDefaultArea>
{
    public RecastFilter_UseDefaultArea(IntPtr pointer) : base(pointer) {}}

public unsafe class NavigationData : ObjectBase<ANavigationData>
{
    public NavigationData(IntPtr pointer) : base(pointer) {}
}

public unsafe class RecastNavMeshDataChunk : ObjectBase<URecastNavMeshDataChunk>
{
    public RecastNavMeshDataChunk(IntPtr pointer) : base(pointer) {}}

public unsafe class AbstractNavData : ObjectBase<AAbstractNavData>
{
    public AbstractNavData(IntPtr pointer) : base(pointer) {}}

public unsafe class CrowdManagerBase : ObjectBase<UCrowdManagerBase>
{
    public CrowdManagerBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NavArea : ObjectBase<UNavArea>
{
    public NavArea(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavLinkCustomComponent : ObjectBase<UNavLinkCustomComponent>
{
    public NavLinkCustomComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class NavArea_Default : ObjectBase<UNavArea_Default>
{
    public NavArea_Default(IntPtr pointer) : base(pointer) {}}

public unsafe class NavArea_Null : ObjectBase<UNavArea_Null>
{
    public NavArea_Null(IntPtr pointer) : base(pointer) {}}

public unsafe class NavArea_Obstacle : ObjectBase<UNavArea_Obstacle>
{
    public NavArea_Obstacle(IntPtr pointer) : base(pointer) {}}

public unsafe class NavAreaMeta : ObjectBase<UNavAreaMeta>
{
    public NavAreaMeta(IntPtr pointer) : base(pointer) {}}

public unsafe class RecastNavMesh : ObjectBase<ARecastNavMesh>
{
    public RecastNavMesh(IntPtr pointer) : base(pointer) {}
    public bool K2_ReplaceAreaInTileBounds(FBox Bounds, TSubclassOf<UNavArea> OldArea, TSubclassOf<UNavArea> NewArea, bool ReplaceLinks)
    {
        Span<(string name, object value)> @params = [
            ("Bounds", Bounds), 
            ("OldArea", OldArea), 
            ("NewArea", NewArea), 
            ("ReplaceLinks", ReplaceLinks)
        ];
        return ProcessEvent<bool>(GetFunction("K2_ReplaceAreaInTileBounds"), @params);
    }
}

