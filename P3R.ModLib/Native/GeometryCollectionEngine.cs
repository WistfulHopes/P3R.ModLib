using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChaosCollisionEventRequestSettings
{
    [FieldOffset(0x0000)] public int MaxNumberResults;
    [FieldOffset(0x0004)] public float MinMass;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinImpulse;
    [FieldOffset(0x0010)] public float MaxDistance;
    [FieldOffset(0x0014)] public EChaosCollisionSortMethod SortMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChaosBreakingEventRequestSettings
{
    [FieldOffset(0x0000)] public int MaxNumberOfResults;
    [FieldOffset(0x0004)] public float MinRadius;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinMass;
    [FieldOffset(0x0010)] public float MaxDistance;
    [FieldOffset(0x0014)] public EChaosBreakingSortMethod SortMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChaosTrailingEventRequestSettings
{
    [FieldOffset(0x0000)] public int MaxNumberOfResults;
    [FieldOffset(0x0004)] public float MinMass;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinAngularSpeed;
    [FieldOffset(0x0010)] public float MaxDistance;
    [FieldOffset(0x0014)] public EChaosTrailingSortMethod SortMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FChaosTrailingEventData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Velocity;
    [FieldOffset(0x0018)] public FVector AngularVelocity;
    [FieldOffset(0x0024)] public float Mass;
    [FieldOffset(0x0028)] public int ParticleIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FChaosCollisionEventData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Normal;
    [FieldOffset(0x0018)] public FVector Velocity1;
    [FieldOffset(0x0024)] public FVector Velocity2;
    [FieldOffset(0x0030)] public float Mass1;
    [FieldOffset(0x0034)] public float Mass2;
    [FieldOffset(0x0038)] public FVector Impulse;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FChaosBreakingEventData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Velocity;
    [FieldOffset(0x0018)] public float Mass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x420)] 
public unsafe struct UChaosDestructionListener
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public byte bIsCollisionEventListeningEnabled;
    [FieldOffset(0x01F8)] public byte bIsBreakingEventListeningEnabled;
    [FieldOffset(0x01F8)] public byte bIsTrailingEventListeningEnabled;
    [FieldOffset(0x01FC)] public FChaosCollisionEventRequestSettings CollisionEventRequestSettings;
    [FieldOffset(0x0214)] public FChaosBreakingEventRequestSettings BreakingEventRequestSettings;
    [FieldOffset(0x022C)] public FChaosTrailingEventRequestSettings TrailingEventRequestSettings;
    [FieldOffset(0x0248)] public TSet<IntPtr> ChaosSolverActors;
    [FieldOffset(0x0298)] public TSet<IntPtr> GeometryCollectionActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AGeometryCollectionActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UGeometryCollectionComponent* GeometryCollectionComponent;
    [FieldOffset(0x0228)] public UGeometryCollectionDebugDrawComponent* GeometryCollectionDebugDrawComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UGeometryCollectionCache
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FRecordedTransformTrack RecordedData;
    [FieldOffset(0x0038)] public UGeometryCollection* SupportedCollection;
    [FieldOffset(0x0040)] public FGuid CompatibleCollectionState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FGeomComponentCacheParameters
{
    [FieldOffset(0x0000)] public EGeometryCollectionCacheType CacheMode;
    [FieldOffset(0x0008)] public UGeometryCollectionCache* TargetCache;
    [FieldOffset(0x0010)] public float ReverseCacheBeginTime;
    [FieldOffset(0x0014)] public bool SaveCollisionData;
    [FieldOffset(0x0015)] public bool DoGenerateCollisionData;
    [FieldOffset(0x0018)] public int CollisionDataSizeMax;
    [FieldOffset(0x001C)] public bool DoCollisionDataSpatialHash;
    [FieldOffset(0x0020)] public float CollisionDataSpatialHashRadius;
    [FieldOffset(0x0024)] public int MaxCollisionPerCell;
    [FieldOffset(0x0028)] public bool SaveBreakingData;
    [FieldOffset(0x0029)] public bool DoGenerateBreakingData;
    [FieldOffset(0x002C)] public int BreakingDataSizeMax;
    [FieldOffset(0x0030)] public bool DoBreakingDataSpatialHash;
    [FieldOffset(0x0034)] public float BreakingDataSpatialHashRadius;
    [FieldOffset(0x0038)] public int MaxBreakingPerCell;
    [FieldOffset(0x003C)] public bool SaveTrailingData;
    [FieldOffset(0x003D)] public bool DoGenerateTrailingData;
    [FieldOffset(0x0040)] public int TrailingDataSizeMax;
    [FieldOffset(0x0044)] public float TrailingMinSpeedThreshold;
    [FieldOffset(0x0048)] public float TrailingMinVolumeThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FGeometryCollectionRepData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x900)] 
public unsafe struct UGeometryCollectionComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0480)] public AChaosSolverActor* ChaosSolverActor;
    [FieldOffset(0x0568)] public UGeometryCollection* RestCollection;
    [FieldOffset(0x0570)] public TArray<IntPtr> InitializationFields;
    [FieldOffset(0x0580)] public bool Simulating;
    [FieldOffset(0x0588)] public EObjectStateTypeEnum ObjectType;
    [FieldOffset(0x0589)] public bool EnableClustering;
    [FieldOffset(0x058C)] public int ClusterGroupIndex;
    [FieldOffset(0x0590)] public int MaxClusterLevel;
    [FieldOffset(0x0598)] public TArray<float> DamageThreshold;
    [FieldOffset(0x05A8)] public EClusterConnectionTypeEnum ClusterConnectionType;
    [FieldOffset(0x05AC)] public int CollisionGroup;
    [FieldOffset(0x05B0)] public float CollisionSampleFraction;
    [FieldOffset(0x05B4)] public float LinearEtherDrag;
    [FieldOffset(0x05B8)] public float AngularEtherDrag;
    [FieldOffset(0x05C0)] public UChaosPhysicalMaterial* PhysicalMaterial;
    [FieldOffset(0x05C8)] public EInitialVelocityTypeEnum InitialVelocityType;
    [FieldOffset(0x05CC)] public FVector InitialLinearVelocity;
    [FieldOffset(0x05D8)] public FVector InitialAngularVelocity;
    [FieldOffset(0x05E8)] public UPhysicalMaterial* PhysicalMaterialOverride;
    [FieldOffset(0x05F0)] public FGeomComponentCacheParameters CacheParameters;
    [FieldOffset(0x0688)] public float DesiredCacheTime;
    [FieldOffset(0x068C)] public bool CachePlayback;
    [FieldOffset(0x06A0)] public bool bNotifyBreaks;
    [FieldOffset(0x06A1)] public bool bNotifyCollisions;
    [FieldOffset(0x06A2)] public bool bEnableReplication;
    [FieldOffset(0x06A3)] public bool bEnableAbandonAfterLevel;
    [FieldOffset(0x06A4)] public int ReplicationAbandonClusterLevel;
    [FieldOffset(0x06A8)] public FGeometryCollectionRepData RepData;
    [FieldOffset(0x08D8)] public UBodySetup* DummyBodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FGeometryCollectionDebugDrawWarningMessage
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FGeometryCollectionDebugDrawActorSelectedRigidBody
{
    [FieldOffset(0x0000)] public int ID;
    [FieldOffset(0x0008)] public AChaosSolverActor* Solver;
    [FieldOffset(0x0010)] public AGeometryCollectionActor* GeometryCollection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AGeometryCollectionDebugDrawActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public FGeometryCollectionDebugDrawWarningMessage WarningMessage;
    [FieldOffset(0x0228)] public FGeometryCollectionDebugDrawActorSelectedRigidBody SelectedRigidBody;
    [FieldOffset(0x0240)] public bool bDebugDrawWholeCollection;
    [FieldOffset(0x0241)] public bool bDebugDrawHierarchy;
    [FieldOffset(0x0242)] public bool bDebugDrawClustering;
    [FieldOffset(0x0243)] public EGeometryCollectionDebugDrawActorHideGeometry HideGeometry;
    [FieldOffset(0x0244)] public bool bShowRigidBodyId;
    [FieldOffset(0x0245)] public bool bShowRigidBodyCollision;
    [FieldOffset(0x0246)] public bool bCollisionAtOrigin;
    [FieldOffset(0x0247)] public bool bShowRigidBodyTransform;
    [FieldOffset(0x0248)] public bool bShowRigidBodyInertia;
    [FieldOffset(0x0249)] public bool bShowRigidBodyVelocity;
    [FieldOffset(0x024A)] public bool bShowRigidBodyForce;
    [FieldOffset(0x024B)] public bool bShowRigidBodyInfos;
    [FieldOffset(0x024C)] public bool bShowTransformIndex;
    [FieldOffset(0x024D)] public bool bShowTransform;
    [FieldOffset(0x024E)] public bool bShowParent;
    [FieldOffset(0x024F)] public bool bShowLevel;
    [FieldOffset(0x0250)] public bool bShowConnectivityEdges;
    [FieldOffset(0x0251)] public bool bShowGeometryIndex;
    [FieldOffset(0x0252)] public bool bShowGeometryTransform;
    [FieldOffset(0x0253)] public bool bShowBoundingBox;
    [FieldOffset(0x0254)] public bool bShowFaces;
    [FieldOffset(0x0255)] public bool bShowFaceIndices;
    [FieldOffset(0x0256)] public bool bShowFaceNormals;
    [FieldOffset(0x0257)] public bool bShowSingleFace;
    [FieldOffset(0x0258)] public int SingleFaceIndex;
    [FieldOffset(0x025C)] public bool bShowVertices;
    [FieldOffset(0x025D)] public bool bShowVertexIndices;
    [FieldOffset(0x025E)] public bool bShowVertexNormals;
    [FieldOffset(0x025F)] public bool bUseActiveVisualization;
    [FieldOffset(0x0260)] public float PointThickness;
    [FieldOffset(0x0264)] public float LineThickness;
    [FieldOffset(0x0268)] public bool bTextShadow;
    [FieldOffset(0x026C)] public float TextScale;
    [FieldOffset(0x0270)] public float NormalScale;
    [FieldOffset(0x0274)] public float AxisScale;
    [FieldOffset(0x0278)] public float ArrowScale;
    [FieldOffset(0x027C)] public FColor RigidBodyIdColor;
    [FieldOffset(0x0280)] public float RigidBodyTransformScale;
    [FieldOffset(0x0284)] public FColor RigidBodyCollisionColor;
    [FieldOffset(0x0288)] public FColor RigidBodyInertiaColor;
    [FieldOffset(0x028C)] public FColor RigidBodyVelocityColor;
    [FieldOffset(0x0290)] public FColor RigidBodyForceColor;
    [FieldOffset(0x0294)] public FColor RigidBodyInfoColor;
    [FieldOffset(0x0298)] public FColor TransformIndexColor;
    [FieldOffset(0x029C)] public float TransformScale;
    [FieldOffset(0x02A0)] public FColor LevelColor;
    [FieldOffset(0x02A4)] public FColor ParentColor;
    [FieldOffset(0x02A8)] public float ConnectivityEdgeThickness;
    [FieldOffset(0x02AC)] public FColor GeometryIndexColor;
    [FieldOffset(0x02B0)] public float GeometryTransformScale;
    [FieldOffset(0x02B4)] public FColor BoundingBoxColor;
    [FieldOffset(0x02B8)] public FColor FaceColor;
    [FieldOffset(0x02BC)] public FColor FaceIndexColor;
    [FieldOffset(0x02C0)] public FColor FaceNormalColor;
    [FieldOffset(0x02C4)] public FColor SingleFaceColor;
    [FieldOffset(0x02C8)] public FColor VertexColor;
    [FieldOffset(0x02CC)] public FColor VertexIndexColor;
    [FieldOffset(0x02D0)] public FColor VertexNormalColor;
    [FieldOffset(0x02D8)] public UBillboardComponent* SpriteComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UGeometryCollectionDebugDrawComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public AGeometryCollectionDebugDrawActor* GeometryCollectionDebugDrawActor;
    [FieldOffset(0x00B8)] public AGeometryCollectionRenderLevelSetActor* GeometryCollectionRenderLevelSetActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FGeometryCollectionSource
{
    [FieldOffset(0x0000)] public FSoftObjectPath SourceGeometryObject;
    [FieldOffset(0x0020)] public FTransform LocalTransform;
    [FieldOffset(0x0050)] public TArray<IntPtr> SourceMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FGeometryCollectionSizeSpecificData
{
    [FieldOffset(0x0000)] public float MaxSize;
    [FieldOffset(0x0004)] public ECollisionTypeEnum CollisionType;
    [FieldOffset(0x0005)] public EImplicitTypeEnum ImplicitType;
    [FieldOffset(0x0008)] public int MinLevelSetResolution;
    [FieldOffset(0x000C)] public int MaxLevelSetResolution;
    [FieldOffset(0x0010)] public int MinClusterLevelSetResolution;
    [FieldOffset(0x0014)] public int MaxClusterLevelSetResolution;
    [FieldOffset(0x0018)] public int CollisionObjectReductionPercentage;
    [FieldOffset(0x001C)] public float CollisionParticlesFraction;
    [FieldOffset(0x0020)] public int MaximumCollisionParticles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UGeometryCollection
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public bool EnableClustering;
    [FieldOffset(0x0034)] public int ClusterGroupIndex;
    [FieldOffset(0x0038)] public int MaxClusterLevel;
    [FieldOffset(0x0040)] public TArray<float> DamageThreshold;
    [FieldOffset(0x0050)] public EClusterConnectionTypeEnum ClusterConnectionType;
    [FieldOffset(0x0058)] public TArray<FGeometryCollectionSource> GeometrySource;
    [FieldOffset(0x0068)] public TArray<IntPtr> Materials;
    [FieldOffset(0x0078)] public ECollisionTypeEnum CollisionType;
    [FieldOffset(0x0079)] public EImplicitTypeEnum ImplicitType;
    [FieldOffset(0x007C)] public int MinLevelSetResolution;
    [FieldOffset(0x0080)] public int MaxLevelSetResolution;
    [FieldOffset(0x0084)] public int MinClusterLevelSetResolution;
    [FieldOffset(0x0088)] public int MaxClusterLevelSetResolution;
    [FieldOffset(0x008C)] public float CollisionObjectReductionPercentage;
    [FieldOffset(0x0090)] public bool bMassAsDensity;
    [FieldOffset(0x0094)] public float Mass;
    [FieldOffset(0x0098)] public float MinimumMassClamp;
    [FieldOffset(0x009C)] public float CollisionParticlesFraction;
    [FieldOffset(0x00A0)] public int MaximumCollisionParticles;
    [FieldOffset(0x00A8)] public TArray<FGeometryCollectionSizeSpecificData> SizeSpecificData;
    [FieldOffset(0x00B8)] public bool EnableRemovePiecesOnFracture;
    [FieldOffset(0x00C0)] public TArray<IntPtr> RemoveOnFractureMaterials;
    [FieldOffset(0x00D0)] public FGuid PersistentGuid;
    [FieldOffset(0x00E0)] public FGuid StateGuid;
    [FieldOffset(0x00F0)] public int BoneSelectedMaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AGeometryCollectionRenderLevelSetActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UVolumeTexture* TargetVolumeTexture;
    [FieldOffset(0x0228)] public UMaterial* RayMarchMaterial;
    [FieldOffset(0x0230)] public float SurfaceTolerance;
    [FieldOffset(0x0234)] public float Isovalue;
    [FieldOffset(0x0238)] public bool Enabled;
    [FieldOffset(0x0239)] public bool RenderVolumeBoundingBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct USkeletalMeshSimulationComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B8)] public UChaosPhysicalMaterial* PhysicalMaterial;
    [FieldOffset(0x00C0)] public AChaosSolverActor* ChaosSolverActor;
    [FieldOffset(0x00C8)] public UPhysicsAsset* OverridePhysicsAsset;
    [FieldOffset(0x00D0)] public bool bSimulating;
    [FieldOffset(0x00D1)] public bool bNotifyCollisions;
    [FieldOffset(0x00D2)] public EObjectStateTypeEnum ObjectType;
    [FieldOffset(0x00D4)] public float Density;
    [FieldOffset(0x00D8)] public float MinMass;
    [FieldOffset(0x00DC)] public float MaxMass;
    [FieldOffset(0x00E0)] public ECollisionTypeEnum CollisionType;
    [FieldOffset(0x00E4)] public float ImplicitShapeParticlesPerUnitArea;
    [FieldOffset(0x00E8)] public int ImplicitShapeMinNumParticles;
    [FieldOffset(0x00EC)] public int ImplicitShapeMaxNumParticles;
    [FieldOffset(0x00F0)] public int MinLevelSetResolution;
    [FieldOffset(0x00F4)] public int MaxLevelSetResolution;
    [FieldOffset(0x00F8)] public int CollisionGroup;
    [FieldOffset(0x00FC)] public EInitialVelocityTypeEnum InitialVelocityType;
    [FieldOffset(0x0100)] public FVector InitialLinearVelocity;
    [FieldOffset(0x010C)] public FVector InitialAngularVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UStaticMeshSimulationComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B8)] public bool Simulating;
    [FieldOffset(0x00B9)] public bool bNotifyCollisions;
    [FieldOffset(0x00BA)] public EObjectStateTypeEnum ObjectType;
    [FieldOffset(0x00BC)] public float Mass;
    [FieldOffset(0x00C0)] public ECollisionTypeEnum CollisionType;
    [FieldOffset(0x00C1)] public EImplicitTypeEnum ImplicitType;
    [FieldOffset(0x00C4)] public int MinLevelSetResolution;
    [FieldOffset(0x00C8)] public int MaxLevelSetResolution;
    [FieldOffset(0x00CC)] public EInitialVelocityTypeEnum InitialVelocityType;
    [FieldOffset(0x00D0)] public FVector InitialLinearVelocity;
    [FieldOffset(0x00DC)] public FVector InitialAngularVelocity;
    [FieldOffset(0x00E8)] public float DamageThreshold;
    [FieldOffset(0x00F0)] public UChaosPhysicalMaterial* PhysicalMaterial;
    [FieldOffset(0x00F8)] public AChaosSolverActor* ChaosSolverActor;
    [FieldOffset(0x0120)] public TArray<IntPtr> SimulatedComponents;
}

