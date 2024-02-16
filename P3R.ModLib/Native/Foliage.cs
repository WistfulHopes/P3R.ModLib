using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x6B0)] 
public unsafe struct UFoliageInstancedStaticMeshComponent
{
    [FieldOffset(0x0000)] public UHierarchicalInstancedStaticMeshComponent baseObj;
    [FieldOffset(0x0698)] public FGuid GenerationGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFoliageStatistics
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFoliageVertexColorChannelMask
{
    [FieldOffset(0x0000)] public byte UseMask;
    [FieldOffset(0x0004)] public float MaskThreshold;
    [FieldOffset(0x0008)] public byte InvertMask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B0)] 
public unsafe struct UFoliageType
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FGuid UpdateGuid;
    [FieldOffset(0x0038)] public float Density;
    [FieldOffset(0x003C)] public float DensityAdjustmentFactor;
    [FieldOffset(0x0040)] public float Radius;
    [FieldOffset(0x0044)] public bool bSingleInstanceModeOverrideRadius;
    [FieldOffset(0x0048)] public float SingleInstanceModeRadius;
    [FieldOffset(0x004C)] public EFoliageScaling Scaling;
    [FieldOffset(0x0050)] public FFloatInterval ScaleX;
    [FieldOffset(0x0058)] public FFloatInterval ScaleY;
    [FieldOffset(0x0060)] public FFloatInterval ScaleZ;
    [FieldOffset(0x0068)] public FFoliageVertexColorChannelMask VertexColorMaskByChannel;
    [FieldOffset(0x0098)] public FoliageVertexColorMask VertexColorMask;
    [FieldOffset(0x009C)] public float VertexColorMaskThreshold;
    [FieldOffset(0x00A0)] public byte VertexColorMaskInvert;
    [FieldOffset(0x00A4)] public FFloatInterval ZOffset;
    [FieldOffset(0x00AC)] public byte AlignToNormal;
    [FieldOffset(0x00B0)] public float AlignMaxAngle;
    [FieldOffset(0x00B4)] public byte RandomYaw;
    [FieldOffset(0x00B8)] public float RandomPitchAngle;
    [FieldOffset(0x00BC)] public FFloatInterval GroundSlopeAngle;
    [FieldOffset(0x00C4)] public FFloatInterval Height;
    [FieldOffset(0x00D0)] public TArray<FName> LandscapeLayers;
    [FieldOffset(0x00E0)] public float MinimumLayerWeight;
    [FieldOffset(0x00E8)] public TArray<FName> ExclusionLandscapeLayers;
    [FieldOffset(0x00F8)] public float MinimumExclusionLayerWeight;
    [FieldOffset(0x00FC)] public FName LandscapeLayer;
    [FieldOffset(0x0104)] public byte CollisionWithWorld;
    [FieldOffset(0x0108)] public FVector CollisionScale;
    [FieldOffset(0x0114)] public FBoxSphereBounds MeshBounds;
    [FieldOffset(0x0130)] public FVector LowBoundOriginRadius;
    [FieldOffset(0x013C)] public EComponentMobility Mobility;
    [FieldOffset(0x0140)] public FInt32Interval CullDistance;
    [FieldOffset(0x0148)] public byte bEnableStaticLighting;
    [FieldOffset(0x0148)] public byte CastShadow;
    [FieldOffset(0x0148)] public byte bAffectDynamicIndirectLighting;
    [FieldOffset(0x0148)] public byte bAffectDistanceFieldLighting;
    [FieldOffset(0x0148)] public byte bCastDynamicShadow;
    [FieldOffset(0x0148)] public byte bCastStaticShadow;
    [FieldOffset(0x0148)] public byte bCastShadowAsTwoSided;
    [FieldOffset(0x0148)] public byte bReceivesDecals;
    [FieldOffset(0x0149)] public byte bOverrideLightMapRes;
    [FieldOffset(0x014C)] public int OverriddenLightMapRes;
    [FieldOffset(0x0150)] public ELightmapType LightmapType;
    [FieldOffset(0x0154)] public byte bUseAsOccluder;
    [FieldOffset(0x0158)] public byte bVisibleInRayTracing;
    [FieldOffset(0x0158)] public byte bEvaluateWorldPositionOffset;
    [FieldOffset(0x0160)] public FBodyInstance BodyInstance;
    [FieldOffset(0x02B8)] public EHasCustomNavigableGeometry CustomNavigableGeometry;
    [FieldOffset(0x02B9)] public FLightingChannels LightingChannels;
    [FieldOffset(0x02BC)] public byte bRenderCustomDepth;
    [FieldOffset(0x02C0)] public ERendererStencilMask CustomDepthStencilWriteMask;
    [FieldOffset(0x02C4)] public int CustomDepthStencilValue;
    [FieldOffset(0x02C8)] public int TranslucencySortPriority;
    [FieldOffset(0x02CC)] public float CollisionRadius;
    [FieldOffset(0x02D0)] public float ShadeRadius;
    [FieldOffset(0x02D4)] public int NumSteps;
    [FieldOffset(0x02D8)] public float InitialSeedDensity;
    [FieldOffset(0x02DC)] public float AverageSpreadDistance;
    [FieldOffset(0x02E0)] public float SpreadVariance;
    [FieldOffset(0x02E4)] public int SeedsPerStep;
    [FieldOffset(0x02E8)] public int DistributionSeed;
    [FieldOffset(0x02EC)] public float MaxInitialSeedOffset;
    [FieldOffset(0x02F0)] public bool bCanGrowInShade;
    [FieldOffset(0x02F1)] public bool bSpawnsInShade;
    [FieldOffset(0x02F4)] public float MaxInitialAge;
    [FieldOffset(0x02F8)] public float MaxAge;
    [FieldOffset(0x02FC)] public float OverlapPriority;
    [FieldOffset(0x0300)] public FFloatInterval ProceduralScale;
    [FieldOffset(0x0308)] public FRuntimeFloatCurve ScaleCurve;
    [FieldOffset(0x0390)] public int ChangeCount;
    [FieldOffset(0x0394)] public byte ReapplyDensity;
    [FieldOffset(0x0394)] public byte ReapplyRadius;
    [FieldOffset(0x0394)] public byte ReapplyAlignToNormal;
    [FieldOffset(0x0394)] public byte ReapplyRandomYaw;
    [FieldOffset(0x0394)] public byte ReapplyScaling;
    [FieldOffset(0x0394)] public byte ReapplyScaleX;
    [FieldOffset(0x0394)] public byte ReapplyScaleY;
    [FieldOffset(0x0394)] public byte ReapplyScaleZ;
    [FieldOffset(0x0395)] public byte ReapplyRandomPitchAngle;
    [FieldOffset(0x0395)] public byte ReapplyGroundSlope;
    [FieldOffset(0x0395)] public byte ReapplyHeight;
    [FieldOffset(0x0395)] public byte ReapplyLandscapeLayers;
    [FieldOffset(0x0395)] public byte ReapplyZOffset;
    [FieldOffset(0x0395)] public byte ReapplyCollisionWithWorld;
    [FieldOffset(0x0395)] public byte ReapplyVertexColorMask;
    [FieldOffset(0x0395)] public byte bEnableDensityScaling;
    [FieldOffset(0x0396)] public byte bEnableDiscardOnLoad;
    [FieldOffset(0x0398)] public TArray<IntPtr> RuntimeVirtualTextures;
    [FieldOffset(0x03A8)] public int VirtualTextureCullMips;
    [FieldOffset(0x03AC)] public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C0)] 
public unsafe struct UFoliageType_Actor
{
    [FieldOffset(0x0000)] public UFoliageType baseObj;
    [FieldOffset(0x03B0)] public TSubclassOf<AActor> ActorClass;
    [FieldOffset(0x03B8)] public bool bShouldAttachToBaseComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3D0)] 
public unsafe struct UFoliageType_InstancedStaticMesh
{
    [FieldOffset(0x0000)] public UFoliageType baseObj;
    [FieldOffset(0x03B0)] public UStaticMesh* Mesh;
    [FieldOffset(0x03B8)] public TArray<IntPtr> OverrideMaterials;
    [FieldOffset(0x03C8)] public TSubclassOf<UFoliageInstancedStaticMeshComponent> ComponentClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct AInstancedFoliageActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AInteractiveFoliageActor
{
    [FieldOffset(0x0000)] public AStaticMeshActor baseObj;
    [FieldOffset(0x0230)] public UCapsuleComponent* CapsuleComponent;
    [FieldOffset(0x0238)] public FVector TouchingActorEntryPosition;
    [FieldOffset(0x0244)] public FVector FoliageVelocity;
    [FieldOffset(0x0250)] public FVector FoliageForce;
    [FieldOffset(0x025C)] public FVector FoliagePosition;
    [FieldOffset(0x0268)] public float FoliageDamageImpulseScale;
    [FieldOffset(0x026C)] public float FoliageTouchImpulseScale;
    [FieldOffset(0x0270)] public float FoliageStiffness;
    [FieldOffset(0x0274)] public float FoliageStiffnessQuadratic;
    [FieldOffset(0x0278)] public float FoliageDamping;
    [FieldOffset(0x027C)] public float MaxDamageImpulse;
    [FieldOffset(0x0280)] public float MaxTouchImpulse;
    [FieldOffset(0x0284)] public float MaxForce;
    [FieldOffset(0x0288)] public float Mass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4F0)] 
public unsafe struct UInteractiveFoliageComponent
{
    [FieldOffset(0x0000)] public UStaticMeshComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct AProceduralFoliageBlockingVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public AProceduralFoliageVolume* ProceduralFoliageVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UProceduralFoliageComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UProceduralFoliageSpawner* FoliageSpawner;
    [FieldOffset(0x00B8)] public float TileOverlap;
    [FieldOffset(0x00C0)] public AVolume* SpawningVolume;
    [FieldOffset(0x00C8)] public FGuid ProceduralGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFoliageTypeObject
{
    [FieldOffset(0x0000)] public UObject* FoliageTypeObject;
    [FieldOffset(0x0008)] public UFoliageType* TypeInstance;
    [FieldOffset(0x0010)] public bool bIsAsset;
    [FieldOffset(0x0018)] public TSubclassOf<UFoliageType_InstancedStaticMesh> Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UProceduralFoliageSpawner
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int RandomSeed;
    [FieldOffset(0x002C)] public float TileSize;
    [FieldOffset(0x0030)] public int NumUniqueTiles;
    [FieldOffset(0x0034)] public float MinimumQuadTreeSize;
    [FieldOffset(0x0040)] public TArray<FFoliageTypeObject> FoliageTypes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FProceduralFoliageInstance
{
    [FieldOffset(0x0000)] public FQuat Rotation;
    [FieldOffset(0x0010)] public FVector Location;
    [FieldOffset(0x001C)] public float Age;
    [FieldOffset(0x0020)] public FVector Normal;
    [FieldOffset(0x002C)] public float Scale;
    [FieldOffset(0x0030)] public UFoliageType* Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UProceduralFoliageTile
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UProceduralFoliageSpawner* FoliageSpawner;
    [FieldOffset(0x00D0)] public TArray<FProceduralFoliageInstance> InstancesArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct AProceduralFoliageVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public UProceduralFoliageComponent* ProceduralComponent;
}

