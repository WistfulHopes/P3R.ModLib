using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSupportedAreaData
{
    [FieldOffset(0x0000)] public FString AreaClassName;
    [FieldOffset(0x0010)] public int AreaId;
    [FieldOffset(0x0018)] public UClass* AreaClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct ANavigationData
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public UPrimitiveComponent* RenderingComp;
    [FieldOffset(0x0230)] public FNavDataConfig NavDataConfig;
    [FieldOffset(0x02A8)] public byte bEnableDrawing;
    [FieldOffset(0x02A8)] public byte bForceRebuildOnLoad;
    [FieldOffset(0x02A8)] public byte bAutoDestroyWhenNoNavigation;
    [FieldOffset(0x02A8)] public byte bCanBeMainNavData;
    [FieldOffset(0x02A8)] public byte bCanSpawnOnRebuild;
    [FieldOffset(0x02A8)] public byte bRebuildAtRuntime;
    [FieldOffset(0x02AC)] public ERuntimeGenerationType RuntimeGeneration;
    [FieldOffset(0x02B0)] public float ObservedPathsTickInterval;
    [FieldOffset(0x02B4)] public uint DataVersion;
    [FieldOffset(0x03C0)] public TArray<FSupportedAreaData> SupportedAreas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct AAbstractNavData
{
    [FieldOffset(0x0000)] public ANavigationData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCrowdManagerBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavArea
{
    [FieldOffset(0x0000)] public UNavAreaBase baseObj;
    [FieldOffset(0x0030)] public float DefaultCost;
    [FieldOffset(0x0034)] public float FixedAreaEnteringCost;
    [FieldOffset(0x0038)] public FColor DrawColor;
    [FieldOffset(0x003C)] public FNavAgentSelector SupportedAgents;
    [FieldOffset(0x0040)] public byte bSupportsAgent0;
    [FieldOffset(0x0040)] public byte bSupportsAgent1;
    [FieldOffset(0x0040)] public byte bSupportsAgent2;
    [FieldOffset(0x0040)] public byte bSupportsAgent3;
    [FieldOffset(0x0040)] public byte bSupportsAgent4;
    [FieldOffset(0x0040)] public byte bSupportsAgent5;
    [FieldOffset(0x0040)] public byte bSupportsAgent6;
    [FieldOffset(0x0040)] public byte bSupportsAgent7;
    [FieldOffset(0x0041)] public byte bSupportsAgent8;
    [FieldOffset(0x0041)] public byte bSupportsAgent9;
    [FieldOffset(0x0041)] public byte bSupportsAgent10;
    [FieldOffset(0x0041)] public byte bSupportsAgent11;
    [FieldOffset(0x0041)] public byte bSupportsAgent12;
    [FieldOffset(0x0041)] public byte bSupportsAgent13;
    [FieldOffset(0x0041)] public byte bSupportsAgent14;
    [FieldOffset(0x0041)] public byte bSupportsAgent15;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavArea_Default
{
    [FieldOffset(0x0000)] public UNavArea baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavArea_LowHeight
{
    [FieldOffset(0x0000)] public UNavArea baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavArea_Null
{
    [FieldOffset(0x0000)] public UNavArea baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavArea_Obstacle
{
    [FieldOffset(0x0000)] public UNavArea baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavAreaMeta
{
    [FieldOffset(0x0000)] public UNavArea baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UNavAreaMeta_SwitchByAgent
{
    [FieldOffset(0x0000)] public UNavAreaMeta baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<UNavArea> Agent0Area;
    [FieldOffset(0x0050)] public TSubclassOf<UNavArea> Agent1Area;
    [FieldOffset(0x0058)] public TSubclassOf<UNavArea> Agent2Area;
    [FieldOffset(0x0060)] public TSubclassOf<UNavArea> Agent3Area;
    [FieldOffset(0x0068)] public TSubclassOf<UNavArea> Agent4Area;
    [FieldOffset(0x0070)] public TSubclassOf<UNavArea> Agent5Area;
    [FieldOffset(0x0078)] public TSubclassOf<UNavArea> Agent6Area;
    [FieldOffset(0x0080)] public TSubclassOf<UNavArea> Agent7Area;
    [FieldOffset(0x0088)] public TSubclassOf<UNavArea> Agent8Area;
    [FieldOffset(0x0090)] public TSubclassOf<UNavArea> Agent9Area;
    [FieldOffset(0x0098)] public TSubclassOf<UNavArea> Agent10Area;
    [FieldOffset(0x00A0)] public TSubclassOf<UNavArea> Agent11Area;
    [FieldOffset(0x00A8)] public TSubclassOf<UNavArea> Agent12Area;
    [FieldOffset(0x00B0)] public TSubclassOf<UNavArea> Agent13Area;
    [FieldOffset(0x00B8)] public TSubclassOf<UNavArea> Agent14Area;
    [FieldOffset(0x00C0)] public TSubclassOf<UNavArea> Agent15Area;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FNavCollisionCylinder
{
    [FieldOffset(0x0000)] public FVector Offset;
    [FieldOffset(0x000C)] public float Radius;
    [FieldOffset(0x0010)] public float Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNavCollisionBox
{
    [FieldOffset(0x0000)] public FVector Offset;
    [FieldOffset(0x000C)] public FVector Extent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UNavCollision
{
    [FieldOffset(0x0000)] public UNavCollisionBase baseObj;
    [FieldOffset(0x0080)] public TArray<FNavCollisionCylinder> CylinderCollision;
    [FieldOffset(0x0090)] public TArray<FNavCollisionBox> BoxCollision;
    [FieldOffset(0x00A0)] public TSubclassOf<UNavArea> AreaClass;
    [FieldOffset(0x00A8)] public byte bGatherConvexGeometry;
    [FieldOffset(0x00A8)] public byte bCreateOnClient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct ANavigationGraph
{
    [FieldOffset(0x0000)] public ANavigationData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ANavigationGraphNode
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNavGraphNode
{
    [FieldOffset(0x0000)] public UObject* Owner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UNavigationGraphNodeComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FNavGraphNode Node;
    [FieldOffset(0x0210)] public UNavigationGraphNodeComponent* NextNodeComponent;
    [FieldOffset(0x0218)] public UNavigationGraphNodeComponent* PrevNodeComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UNavigationInvokerComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float TileGenerationRadius;
    [FieldOffset(0x00B4)] public float TileRemovalRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UNavigationPath
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<FVector> PathPoints;
    [FieldOffset(0x0048)] public ENavigationOptionFlag RecalculateOnInvalidation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavigationPathGenerator
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNavigationFilterArea
{
    [FieldOffset(0x0000)] public TSubclassOf<UNavArea> AreaClass;
    [FieldOffset(0x0008)] public float TravelCostOverride;
    [FieldOffset(0x000C)] public float EnteringCostOverride;
    [FieldOffset(0x0010)] public byte bIsExcluded;
    [FieldOffset(0x0010)] public byte bOverrideTravelCost;
    [FieldOffset(0x0010)] public byte bOverrideEnteringCost;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNavigationFilterFlags
{
    [FieldOffset(0x0000)] public byte bNavFlag0;
    [FieldOffset(0x0000)] public byte bNavFlag1;
    [FieldOffset(0x0000)] public byte bNavFlag2;
    [FieldOffset(0x0000)] public byte bNavFlag3;
    [FieldOffset(0x0000)] public byte bNavFlag4;
    [FieldOffset(0x0000)] public byte bNavFlag5;
    [FieldOffset(0x0000)] public byte bNavFlag6;
    [FieldOffset(0x0000)] public byte bNavFlag7;
    [FieldOffset(0x0001)] public byte bNavFlag8;
    [FieldOffset(0x0001)] public byte bNavFlag9;
    [FieldOffset(0x0001)] public byte bNavFlag10;
    [FieldOffset(0x0001)] public byte bNavFlag11;
    [FieldOffset(0x0001)] public byte bNavFlag12;
    [FieldOffset(0x0001)] public byte bNavFlag13;
    [FieldOffset(0x0001)] public byte bNavFlag14;
    [FieldOffset(0x0001)] public byte bNavFlag15;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavigationQueryFilter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FNavigationFilterArea> Areas;
    [FieldOffset(0x0038)] public FNavigationFilterFlags IncludeFlags;
    [FieldOffset(0x003C)] public FNavigationFilterFlags ExcludeFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x15E0)] 
public unsafe struct UNavigationSystemV1
{
    [FieldOffset(0x0000)] public UNavigationSystemBase baseObj;
    [FieldOffset(0x0028)] public ANavigationData* MainNavData;
    [FieldOffset(0x0030)] public ANavigationData* AbstractNavData;
    [FieldOffset(0x0038)] public FName DefaultAgentName;
    [FieldOffset(0x0040)] public TSoftClassPtr<UCrowdManagerBase> CrowdManagerClass;
    [FieldOffset(0x0068)] public byte bAutoCreateNavigationData;
    [FieldOffset(0x0068)] public byte bSpawnNavDataInNavBoundsLevel;
    [FieldOffset(0x0068)] public byte bAllowClientSideNavigation;
    [FieldOffset(0x0068)] public byte bShouldDiscardSubLevelNavData;
    [FieldOffset(0x0068)] public byte bTickWhilePaused;
    [FieldOffset(0x0068)] public byte bSupportRebuilding;
    [FieldOffset(0x0068)] public byte bInitialBuildingLocked;
    [FieldOffset(0x0069)] public byte bSkipAgentHeightCheckWhenPickingNavData;
    [FieldOffset(0x0069)] public byte bGenerateNavigationOnlyAroundNavigationInvokers;
    [FieldOffset(0x006C)] public float ActiveTilesUpdateInterval;
    [FieldOffset(0x0070)] public ENavDataGatheringModeConfig DataGatheringMode;
    [FieldOffset(0x0074)] public float DirtyAreaWarningSizeThreshold;
    [FieldOffset(0x0078)] public TArray<FNavDataConfig> SupportedAgents;
    [FieldOffset(0x0088)] public FNavAgentSelector SupportedAgentsMask;
    [FieldOffset(0x0090)] public TArray<IntPtr> NavDataSet;
    [FieldOffset(0x00A0)] public TArray<IntPtr> NavDataRegistrationQueue;
    [FieldOffset(0x01BC)] public FNavigationSystemRunMode OperationMode;
    [FieldOffset(0x15BC)] public float DirtyAreasUpdateFreq;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNavigationSystemModuleConfig
{
    [FieldOffset(0x0000)] public UNavigationSystemConfig baseObj;
    [FieldOffset(0x0050)] public byte bStrictlyStatic;
    [FieldOffset(0x0050)] public byte bCreateOnClient;
    [FieldOffset(0x0050)] public byte bAutoSpawnMissingNavData;
    [FieldOffset(0x0050)] public byte bSpawnNavDataInNavBoundsLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct ANavigationTestingActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public UCapsuleComponent* CapsuleComponent;
    [FieldOffset(0x0238)] public UNavigationInvokerComponent* InvokerComponent;
    [FieldOffset(0x0240)] public byte bActAsNavigationInvoker;
    [FieldOffset(0x0248)] public FNavAgentProperties NavAgentProps;
    [FieldOffset(0x0278)] public FVector QueryingExtent;
    [FieldOffset(0x0288)] public ANavigationData* MyNavData;
    [FieldOffset(0x0290)] public FVector ProjectedLocation;
    [FieldOffset(0x029C)] public byte bProjectedLocationValid;
    [FieldOffset(0x029C)] public byte bSearchStart;
    [FieldOffset(0x02A0)] public float CostLimitFactor;
    [FieldOffset(0x02A4)] public float MinimumCostLimit;
    [FieldOffset(0x02A8)] public byte bBacktracking;
    [FieldOffset(0x02A8)] public byte bUseHierarchicalPathfinding;
    [FieldOffset(0x02A8)] public byte bGatherDetailedInfo;
    [FieldOffset(0x02A8)] public byte bDrawDistanceToWall;
    [FieldOffset(0x02A8)] public byte bShowNodePool;
    [FieldOffset(0x02A8)] public byte bShowBestPath;
    [FieldOffset(0x02A8)] public byte bShowDiffWithPreviousStep;
    [FieldOffset(0x02A8)] public byte bShouldBeVisibleInGame;
    [FieldOffset(0x02AC)] public ENavCostDisplay CostDisplayMode;
    [FieldOffset(0x02B0)] public FVector2D TextCanvasOffset;
    [FieldOffset(0x02B8)] public byte bPathExist;
    [FieldOffset(0x02B8)] public byte bPathIsPartial;
    [FieldOffset(0x02B8)] public byte bPathSearchOutOfNodes;
    [FieldOffset(0x02BC)] public float PathfindingTime;
    [FieldOffset(0x02C0)] public float PathCost;
    [FieldOffset(0x02C4)] public int PathfindingSteps;
    [FieldOffset(0x02C8)] public ANavigationTestingActor* OtherActor;
    [FieldOffset(0x02D0)] public TSubclassOf<UNavigationQueryFilter> FilterClass;
    [FieldOffset(0x02D8)] public int ShowStepIndex;
    [FieldOffset(0x02DC)] public float OffsetFromCornersDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UNavLinkComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0458)] public TArray<FNavigationLink> Links;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UNavRelevantComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00D4)] public byte bAttachToOwnersRoot;
    [FieldOffset(0x00D8)] public UObject* CachedNavParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UNavLinkCustomComponent
{
    [FieldOffset(0x0000)] public UNavRelevantComponent baseObj;
    [FieldOffset(0x00E8)] public uint NavLinkUserId;
    [FieldOffset(0x00F0)] public TSubclassOf<UNavArea> EnabledAreaClass;
    [FieldOffset(0x00F8)] public TSubclassOf<UNavArea> DisabledAreaClass;
    [FieldOffset(0x0100)] public FNavAgentSelector SupportedAgents;
    [FieldOffset(0x0104)] public FVector LinkRelativeStart;
    [FieldOffset(0x0110)] public FVector LinkRelativeEnd;
    [FieldOffset(0x011C)] public ENavLinkDirection LinkDirection;
    [FieldOffset(0x0120)] public byte bLinkEnabled;
    [FieldOffset(0x0120)] public byte bNotifyWhenEnabled;
    [FieldOffset(0x0120)] public byte bNotifyWhenDisabled;
    [FieldOffset(0x0120)] public byte bCreateBoxObstacle;
    [FieldOffset(0x0124)] public FVector ObstacleOffset;
    [FieldOffset(0x0130)] public FVector ObstacleExtent;
    [FieldOffset(0x0140)] public TSubclassOf<UNavArea> ObstacleAreaClass;
    [FieldOffset(0x0148)] public float BroadcastRadius;
    [FieldOffset(0x014C)] public float BroadcastInterval;
    [FieldOffset(0x0150)] public ECollisionChannel BroadcastChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavLinkCustomInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavLinkHostInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct UNavLinkRenderingComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNavLinkTrivial
{
    [FieldOffset(0x0000)] public UNavLinkDefinition baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct ANavMeshBoundsVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public FNavAgentSelector SupportedAgents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x460)] 
public unsafe struct UNavMeshRenderingComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UNavModifierComponent
{
    [FieldOffset(0x0000)] public UNavRelevantComponent baseObj;
    [FieldOffset(0x00E0)] public TSubclassOf<UNavArea> AreaClass;
    [FieldOffset(0x00E8)] public FVector FailsafeExtent;
    [FieldOffset(0x00F4)] public byte bIncludeAgentHeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ANavModifierVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0260)] public TSubclassOf<UNavArea> AreaClass;
    [FieldOffset(0x0268)] public bool bMaskFillCollisionUnderneathForNavmesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavNodeInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ANavSystemConfigOverride
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UNavigationSystemConfig* NavigationSystemConfig;
    [FieldOffset(0x0228)] public ENavSystemOverridePolicy OverridePolicy;
    [FieldOffset(0x0229)] public byte bLoadOnClient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct UNavTestRenderingComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct URecastFilter_UseDefaultArea
{
    [FieldOffset(0x0000)] public UNavigationQueryFilter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D8)] 
public unsafe struct ARecastNavMesh
{
    [FieldOffset(0x0000)] public ANavigationData baseObj;
    [FieldOffset(0x0428)] public byte bDrawTriangleEdges;
    [FieldOffset(0x0428)] public byte bDrawPolyEdges;
    [FieldOffset(0x0428)] public byte bDrawFilledPolys;
    [FieldOffset(0x0428)] public byte bDrawNavMeshEdges;
    [FieldOffset(0x0428)] public byte bDrawTileBounds;
    [FieldOffset(0x0428)] public byte bDrawPathCollidingGeometry;
    [FieldOffset(0x0428)] public byte bDrawTileLabels;
    [FieldOffset(0x0428)] public byte bDrawPolygonLabels;
    [FieldOffset(0x0429)] public byte bDrawDefaultPolygonCost;
    [FieldOffset(0x0429)] public byte bDrawPolygonFlags;
    [FieldOffset(0x0429)] public byte bDrawLabelsOnPathNodes;
    [FieldOffset(0x0429)] public byte bDrawNavLinks;
    [FieldOffset(0x0429)] public byte bDrawFailedNavLinks;
    [FieldOffset(0x0429)] public byte bDrawClusters;
    [FieldOffset(0x0429)] public byte bDrawOctree;
    [FieldOffset(0x0429)] public byte bDrawOctreeDetails;
    [FieldOffset(0x042A)] public byte bDrawMarkedForbiddenPolys;
    [FieldOffset(0x042A)] public byte bDistinctlyDrawTilesBeingBuilt;
    [FieldOffset(0x042C)] public float DrawOffset;
    [FieldOffset(0x0430)] public byte bFixedTilePoolSize;
    [FieldOffset(0x0434)] public int TilePoolSize;
    [FieldOffset(0x0438)] public float TileSizeUU;
    [FieldOffset(0x043C)] public float CellSize;
    [FieldOffset(0x0440)] public float CellHeight;
    [FieldOffset(0x0444)] public float AgentRadius;
    [FieldOffset(0x0448)] public float AgentHeight;
    [FieldOffset(0x044C)] public float AgentMaxSlope;
    [FieldOffset(0x0450)] public float AgentMaxStepHeight;
    [FieldOffset(0x0454)] public float MinRegionArea;
    [FieldOffset(0x0458)] public float MergeRegionSize;
    [FieldOffset(0x045C)] public float MaxSimplificationError;
    [FieldOffset(0x0460)] public int MaxSimultaneousTileGenerationJobsCount;
    [FieldOffset(0x0464)] public int TileNumberHardLimit;
    [FieldOffset(0x0468)] public int PolyRefTileBits;
    [FieldOffset(0x046C)] public int PolyRefNavPolyBits;
    [FieldOffset(0x0470)] public int PolyRefSaltBits;
    [FieldOffset(0x0474)] public FVector NavMeshOriginOffset;
    [FieldOffset(0x0480)] public float DefaultDrawDistance;
    [FieldOffset(0x0484)] public float DefaultMaxSearchNodes;
    [FieldOffset(0x0488)] public float DefaultMaxHierarchicalSearchNodes;
    [FieldOffset(0x048C)] public ERecastPartitioning RegionPartitioning;
    [FieldOffset(0x048D)] public ERecastPartitioning LayerPartitioning;
    [FieldOffset(0x0490)] public int RegionChunkSplits;
    [FieldOffset(0x0494)] public int LayerChunkSplits;
    [FieldOffset(0x0498)] public byte bSortNavigationAreasByCost;
    [FieldOffset(0x0498)] public byte bPerformVoxelFiltering;
    [FieldOffset(0x0498)] public byte bMarkLowHeightAreas;
    [FieldOffset(0x0498)] public byte bUseExtraTopCellWhenMarkingAreas;
    [FieldOffset(0x0498)] public byte bFilterLowSpanSequences;
    [FieldOffset(0x0498)] public byte bFilterLowSpanFromTileCache;
    [FieldOffset(0x0498)] public byte bDoFullyAsyncNavDataGathering;
    [FieldOffset(0x0498)] public byte bUseBetterOffsetsFromCorners;
    [FieldOffset(0x0499)] public byte bStoreEmptyTileLayers;
    [FieldOffset(0x0499)] public byte bUseVirtualFilters;
    [FieldOffset(0x0499)] public byte bAllowNavLinkAsPathEnd;
    [FieldOffset(0x0499)] public byte bUseVoxelCache;
    [FieldOffset(0x049C)] public float TileSetUpdateInterval;
    [FieldOffset(0x04A0)] public float HeuristicScale;
    [FieldOffset(0x04A4)] public float VerticalDeviationFromGroundCompensation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct URecastNavMeshDataChunk
{
    [FieldOffset(0x0000)] public UNavigationDataChunk baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNavGraphEdge
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FNavLinkCustomInstanceData
{
    [FieldOffset(0x0000)] public FActorComponentInstanceData baseObj;
    [FieldOffset(0x0068)] public uint NavLinkUserId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRecastNavMeshGenerationProperties
{
    [FieldOffset(0x0000)] public int TilePoolSize;
    [FieldOffset(0x0004)] public float TileSizeUU;
    [FieldOffset(0x0008)] public float CellSize;
    [FieldOffset(0x000C)] public float CellHeight;
    [FieldOffset(0x0010)] public float AgentRadius;
    [FieldOffset(0x0014)] public float AgentHeight;
    [FieldOffset(0x0018)] public float AgentMaxSlope;
    [FieldOffset(0x001C)] public float AgentMaxStepHeight;
    [FieldOffset(0x0020)] public float MinRegionArea;
    [FieldOffset(0x0024)] public float MergeRegionSize;
    [FieldOffset(0x0028)] public float MaxSimplificationError;
    [FieldOffset(0x002C)] public int TileNumberHardLimit;
    [FieldOffset(0x0030)] public ERecastPartitioning RegionPartitioning;
    [FieldOffset(0x0031)] public ERecastPartitioning LayerPartitioning;
    [FieldOffset(0x0034)] public int RegionChunkSplits;
    [FieldOffset(0x0038)] public int LayerChunkSplits;
    [FieldOffset(0x003C)] public byte bSortNavigationAreasByCost;
    [FieldOffset(0x003C)] public byte bPerformVoxelFiltering;
    [FieldOffset(0x003C)] public byte bMarkLowHeightAreas;
    [FieldOffset(0x003C)] public byte bUseExtraTopCellWhenMarkingAreas;
    [FieldOffset(0x003C)] public byte bFilterLowSpanSequences;
    [FieldOffset(0x003C)] public byte bFilterLowSpanFromTileCache;
    [FieldOffset(0x003C)] public byte bFixedTilePoolSize;
}

