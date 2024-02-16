using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AControlPointMeshActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UControlPointMeshComponent* ControlPointMeshComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4F0)] 
public unsafe struct UControlPointMeshComponent
{
    [FieldOffset(0x0000)] public UStaticMeshComponent baseObj;
    [FieldOffset(0x04E0)] public float VirtualTextureMainPassMaxDrawDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLandscapeProxyMaterialOverride
{
    [FieldOffset(0x0000)] public FPerPlatformInt LODIndex;
    [FieldOffset(0x0008)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x598)] 
public unsafe struct ALandscapeProxy
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ULandscapeSplinesComponent* SplineComponent;
    [FieldOffset(0x0228)] public FGuid LandscapeGuid;
    [FieldOffset(0x0238)] public FIntPoint LandscapeSectionOffset;
    [FieldOffset(0x0240)] public int MaxLODLevel;
    [FieldOffset(0x0244)] public float LODDistanceFactor;
    [FieldOffset(0x0248)] public ELandscapeLODFalloff LODFalloff;
    [FieldOffset(0x024C)] public float ComponentScreenSizeToUseSubSections;
    [FieldOffset(0x0250)] public float LOD0ScreenSize;
    [FieldOffset(0x0254)] public float LOD0DistributionSetting;
    [FieldOffset(0x0258)] public float LODDistributionSetting;
    [FieldOffset(0x025C)] public float TessellationComponentScreenSize;
    [FieldOffset(0x0260)] public bool UseTessellationComponentScreenSizeFalloff;
    [FieldOffset(0x0264)] public float TessellationComponentScreenSizeFalloff;
    [FieldOffset(0x0268)] public int OccluderGeometryLOD;
    [FieldOffset(0x026C)] public int StaticLightingLOD;
    [FieldOffset(0x0270)] public UPhysicalMaterial* DefaultPhysMaterial;
    [FieldOffset(0x0278)] public float StreamingDistanceMultiplier;
    [FieldOffset(0x0280)] public UMaterialInterface* LandscapeMaterial;
    [FieldOffset(0x02A8)] public UMaterialInterface* LandscapeHoleMaterial;
    [FieldOffset(0x02B0)] public TArray<FLandscapeProxyMaterialOverride> LandscapeMaterialsOverride;
    [FieldOffset(0x02C0)] public bool bMeshHoles;
    [FieldOffset(0x02C1)] public byte MeshHolesMaxLod;
    [FieldOffset(0x02C8)] public TArray<IntPtr> RuntimeVirtualTextures;
    [FieldOffset(0x02D8)] public int VirtualTextureNumLods;
    [FieldOffset(0x02DC)] public int VirtualTextureLodBias;
    [FieldOffset(0x02E0)] public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
    [FieldOffset(0x02E4)] public float NegativeZBoundsExtension;
    [FieldOffset(0x02E8)] public float PositiveZBoundsExtension;
    [FieldOffset(0x02F0)] public TArray<IntPtr> LandscapeComponents;
    [FieldOffset(0x0300)] public TArray<IntPtr> CollisionComponents;
    [FieldOffset(0x0310)] public TArray<IntPtr> FoliageComponents;
    [FieldOffset(0x0384)] public bool bHasLandscapeGrass;
    [FieldOffset(0x0388)] public float StaticLightingResolution;
    [FieldOffset(0x038C)] public byte CastShadow;
    [FieldOffset(0x038C)] public byte bCastDynamicShadow;
    [FieldOffset(0x038C)] public byte bCastStaticShadow;
    [FieldOffset(0x0390)] public byte bCastFarShadow;
    [FieldOffset(0x0394)] public byte bCastHiddenShadow;
    [FieldOffset(0x0398)] public byte bCastShadowAsTwoSided;
    [FieldOffset(0x039C)] public byte bAffectDistanceFieldLighting;
    [FieldOffset(0x039D)] public FLightingChannels LightingChannels;
    [FieldOffset(0x03A0)] public byte bUseMaterialPositionOffsetInStaticLighting;
    [FieldOffset(0x03A0)] public byte bRenderCustomDepth;
    [FieldOffset(0x03A4)] public ERendererStencilMask CustomDepthStencilWriteMask;
    [FieldOffset(0x03A8)] public int CustomDepthStencilValue;
    [FieldOffset(0x03AC)] public float LDMaxDrawDistance;
    [FieldOffset(0x03B0)] public FLightmassPrimitiveSettings LightmassSettings;
    [FieldOffset(0x03C8)] public int CollisionMipLevel;
    [FieldOffset(0x03CC)] public int SimpleCollisionMipLevel;
    [FieldOffset(0x03D0)] public float CollisionThickness;
    [FieldOffset(0x03D8)] public FBodyInstance BodyInstance;
    [FieldOffset(0x0530)] public byte bGenerateOverlapEvents;
    [FieldOffset(0x0530)] public byte bBakeMaterialPositionOffsetIntoCollision;
    [FieldOffset(0x0534)] public int ComponentSizeQuads;
    [FieldOffset(0x0538)] public int SubsectionSizeQuads;
    [FieldOffset(0x053C)] public int NumSubsections;
    [FieldOffset(0x0540)] public byte bUsedForNavigation;
    [FieldOffset(0x0540)] public byte bFillCollisionUnderLandscapeForNavmesh;
    [FieldOffset(0x0544)] public bool bUseDynamicMaterialInstance;
    [FieldOffset(0x0545)] public ENavDataGatheringMode NavigationGeometryGatheringMode;
    [FieldOffset(0x0546)] public bool bUseLandscapeForCullingInvisibleHLODVertices;
    [FieldOffset(0x0547)] public bool bHasLayersContent;
    [FieldOffset(0x0548)] public TMap<IntPtr, IntPtr> WeightmapUsageMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x598)] 
public unsafe struct ALandscape
{
    [FieldOffset(0x0000)] public ALandscapeProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ALandscapeBlueprintBrushBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct ULandscapeLODStreamingProxy
{
    [FieldOffset(0x0000)] public UStreamableRenderAsset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLandscapeComponentMaterialOverride
{
    [FieldOffset(0x0000)] public FPerPlatformInt LODIndex;
    [FieldOffset(0x0008)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FWeightmapLayerAllocationInfo
{
    [FieldOffset(0x0000)] public ULandscapeLayerInfoObject* LayerInfo;
    [FieldOffset(0x0008)] public byte WeightmapTextureIndex;
    [FieldOffset(0x0009)] public byte WeightmapTextureChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x670)] 
public unsafe struct ULandscapeComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public int SectionBaseX;
    [FieldOffset(0x0454)] public int SectionBaseY;
    [FieldOffset(0x0458)] public int ComponentSizeQuads;
    [FieldOffset(0x045C)] public int SubsectionSizeQuads;
    [FieldOffset(0x0460)] public int NumSubsections;
    [FieldOffset(0x0468)] public UMaterialInterface* OverrideMaterial;
    [FieldOffset(0x0470)] public UMaterialInterface* OverrideHoleMaterial;
    [FieldOffset(0x0478)] public TArray<FLandscapeComponentMaterialOverride> OverrideMaterials;
    [FieldOffset(0x0488)] public TArray<IntPtr> MaterialInstances;
    [FieldOffset(0x0498)] public TArray<IntPtr> MaterialInstancesDynamic;
    [FieldOffset(0x04A8)] public TArray<sbyte> LODIndexToMaterialIndex;
    [FieldOffset(0x04B8)] public TArray<sbyte> MaterialIndexToDisabledTessellationMaterial;
    [FieldOffset(0x04C8)] public UTexture2D* XYOffsetmapTexture;
    [FieldOffset(0x04D0)] public FVector4 WeightmapScaleBias;
    [FieldOffset(0x04E0)] public float WeightmapSubsectionOffset;
    [FieldOffset(0x04F0)] public FVector4 HeightmapScaleBias;
    [FieldOffset(0x0500)] public FBox CachedLocalBox;
    [FieldOffset(0x051C)] public TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent;
    [FieldOffset(0x0538)] public UTexture2D* HeightmapTexture;
    [FieldOffset(0x0540)] public TArray<FWeightmapLayerAllocationInfo> WeightmapLayerAllocations;
    [FieldOffset(0x0550)] public TArray<IntPtr> WeightmapTextures;
    [FieldOffset(0x0560)] public ULandscapeLODStreamingProxy* LODStreamingProxy;
    [FieldOffset(0x0568)] public FGuid MapBuildDataId;
    [FieldOffset(0x0578)] public TArray<FGuid> IrrelevantLights;
    [FieldOffset(0x0588)] public int CollisionMipLevel;
    [FieldOffset(0x058C)] public int SimpleCollisionMipLevel;
    [FieldOffset(0x0590)] public float NegativeZBoundsExtension;
    [FieldOffset(0x0594)] public float PositiveZBoundsExtension;
    [FieldOffset(0x0598)] public float StaticLightingResolution;
    [FieldOffset(0x059C)] public int ForcedLOD;
    [FieldOffset(0x05A0)] public int LODBias;
    [FieldOffset(0x05A4)] public FGuid StateId;
    [FieldOffset(0x05B4)] public FGuid BakedTextureMaterialGuid;
    [FieldOffset(0x05C8)] public UTexture2D* GIBakedBaseColorTexture;
    [FieldOffset(0x05D0)] public byte MobileBlendableLayerMask;
    [FieldOffset(0x05D8)] public UMaterialInterface* MobileMaterialInterface;
    [FieldOffset(0x05E0)] public TArray<IntPtr> MobileMaterialInterfaces;
    [FieldOffset(0x05F0)] public TArray<IntPtr> MobileWeightmapTextures;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ALandscapeGizmoActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ALandscapeGizmoActiveActor
{
    [FieldOffset(0x0000)] public ALandscapeGizmoActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct ULandscapeGizmoRenderComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FGrassVariety
{
    [FieldOffset(0x0000)] public UStaticMesh* GrassMesh;
    [FieldOffset(0x0008)] public TArray<IntPtr> OverrideMaterials;
    [FieldOffset(0x0018)] public FPerPlatformFloat GrassDensity;
    [FieldOffset(0x001C)] public bool bUseGrid;
    [FieldOffset(0x0020)] public float PlacementJitter;
    [FieldOffset(0x0024)] public FPerPlatformInt StartCullDistance;
    [FieldOffset(0x0028)] public FPerPlatformInt EndCullDistance;
    [FieldOffset(0x002C)] public int MinLOD;
    [FieldOffset(0x0030)] public EGrassScaling Scaling;
    [FieldOffset(0x0034)] public FFloatInterval ScaleX;
    [FieldOffset(0x003C)] public FFloatInterval ScaleY;
    [FieldOffset(0x0044)] public FFloatInterval ScaleZ;
    [FieldOffset(0x004C)] public bool RandomRotation;
    [FieldOffset(0x004D)] public bool AlignToSurface;
    [FieldOffset(0x004E)] public bool bUseLandscapeLightmap;
    [FieldOffset(0x004F)] public FLightingChannels LightingChannels;
    [FieldOffset(0x0050)] public bool bReceivesDecals;
    [FieldOffset(0x0051)] public bool bCastDynamicShadow;
    [FieldOffset(0x0052)] public bool bKeepInstanceBufferCPUCopy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct ULandscapeGrassType
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FGrassVariety> GrassVarieties;
    [FieldOffset(0x0038)] public byte bEnableDensityScaling;
    [FieldOffset(0x0040)] public UStaticMesh* GrassMesh;
    [FieldOffset(0x0048)] public float GrassDensity;
    [FieldOffset(0x004C)] public float PlacementJitter;
    [FieldOffset(0x0050)] public int StartCullDistance;
    [FieldOffset(0x0054)] public int EndCullDistance;
    [FieldOffset(0x0058)] public bool RandomRotation;
    [FieldOffset(0x0059)] public bool AlignToSurface;
}

[StructLayout(LayoutKind.Explicit, Size = 0x530)] 
public unsafe struct ULandscapeHeightfieldCollisionComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public TArray<IntPtr> ComponentLayerInfos;
    [FieldOffset(0x0460)] public int SectionBaseX;
    [FieldOffset(0x0464)] public int SectionBaseY;
    [FieldOffset(0x0468)] public int CollisionSizeQuads;
    [FieldOffset(0x046C)] public float CollisionScale;
    [FieldOffset(0x0470)] public int SimpleCollisionSizeQuads;
    [FieldOffset(0x0478)] public TArray<byte> CollisionQuadFlags;
    [FieldOffset(0x0488)] public FGuid HeightfieldGuid;
    [FieldOffset(0x0498)] public FBox CachedLocalBox;
    [FieldOffset(0x04B4)] public TLazyObjectPtr<ULandscapeComponent> RenderComponent;
    [FieldOffset(0x04E0)] public TArray<IntPtr> CookedPhysicalMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct ULandscapeInfo
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TLazyObjectPtr<ALandscape> LandscapeActor;
    [FieldOffset(0x0044)] public FGuid LandscapeGuid;
    [FieldOffset(0x0054)] public int ComponentSizeQuads;
    [FieldOffset(0x0058)] public int SubsectionSizeQuads;
    [FieldOffset(0x005C)] public int ComponentNumSubsections;
    [FieldOffset(0x0060)] public FVector DrawScale;
    [FieldOffset(0x0110)] public TArray<IntPtr> Proxies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct ULandscapeInfoMap
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct ULandscapeLayerInfoObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName LayerName;
    [FieldOffset(0x0030)] public UPhysicalMaterial* PhysMaterial;
    [FieldOffset(0x0038)] public float Hardness;
    [FieldOffset(0x003C)] public FLinearColor LayerUsageDebugColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FLandscapeMaterialTextureStreamingInfo
{
    [FieldOffset(0x0000)] public FName TextureName;
    [FieldOffset(0x0008)] public float TexelFactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct ULandscapeMaterialInstanceConstant
{
    [FieldOffset(0x0000)] public UMaterialInstanceConstant baseObj;
    [FieldOffset(0x0318)] public TArray<FLandscapeMaterialTextureStreamingInfo> TextureStreamingInfo;
    [FieldOffset(0x0328)] public byte bIsLayerThumbnail;
    [FieldOffset(0x0328)] public byte bDisableTessellation;
    [FieldOffset(0x0328)] public byte bMobile;
    [FieldOffset(0x0328)] public byte bEditorToolUsage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x550)] 
public unsafe struct ULandscapeMeshCollisionComponent
{
    [FieldOffset(0x0000)] public ULandscapeHeightfieldCollisionComponent baseObj;
    [FieldOffset(0x0530)] public FGuid MeshGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ALandscapeMeshProxyActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ULandscapeMeshProxyComponent* LandscapeMeshProxyComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct ULandscapeMeshProxyComponent
{
    [FieldOffset(0x0000)] public UStaticMeshComponent baseObj;
    [FieldOffset(0x04E0)] public FGuid LandscapeGuid;
    [FieldOffset(0x04F0)] public TArray<FIntPoint> ProxyComponentBases;
    [FieldOffset(0x0500)] public sbyte ProxyLOD;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct ULandscapeSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public int MaxNumberOfLayers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x480)] 
public unsafe struct ULandscapeSplinesComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public TArray<IntPtr> ControlPoints;
    [FieldOffset(0x0460)] public TArray<IntPtr> Segments;
    [FieldOffset(0x0470)] public TArray<IntPtr> CookedForeignMeshComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLandscapeSplineConnection
{
    [FieldOffset(0x0000)] public ULandscapeSplineSegment* Segment;
    [FieldOffset(0x0008)] public byte End;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FLandscapeSplineInterpPoint
{
    [FieldOffset(0x0000)] public FVector Center;
    [FieldOffset(0x000C)] public FVector Left;
    [FieldOffset(0x0018)] public FVector Right;
    [FieldOffset(0x0024)] public FVector FalloffLeft;
    [FieldOffset(0x0030)] public FVector FalloffRight;
    [FieldOffset(0x003C)] public FVector LayerLeft;
    [FieldOffset(0x0048)] public FVector LayerRight;
    [FieldOffset(0x0054)] public FVector LayerFalloffLeft;
    [FieldOffset(0x0060)] public FVector LayerFalloffRight;
    [FieldOffset(0x006C)] public float StartEndFalloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct ULandscapeSplineControlPoint
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FVector Location;
    [FieldOffset(0x0034)] public FRotator Rotation;
    [FieldOffset(0x0040)] public float Width;
    [FieldOffset(0x0044)] public float LayerWidthRatio;
    [FieldOffset(0x0048)] public float SideFalloff;
    [FieldOffset(0x004C)] public float LeftSideFalloffFactor;
    [FieldOffset(0x0050)] public float RightSideFalloffFactor;
    [FieldOffset(0x0054)] public float LeftSideLayerFalloffFactor;
    [FieldOffset(0x0058)] public float RightSideLayerFalloffFactor;
    [FieldOffset(0x005C)] public float EndFalloff;
    [FieldOffset(0x0060)] public TArray<FLandscapeSplineConnection> ConnectedSegments;
    [FieldOffset(0x0070)] public TArray<FLandscapeSplineInterpPoint> Points;
    [FieldOffset(0x0080)] public FBox Bounds;
    [FieldOffset(0x00A0)] public UControlPointMeshComponent* LocalMeshComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FLandscapeSplineSegmentConnection
{
    [FieldOffset(0x0000)] public ULandscapeSplineControlPoint* ControlPoint;
    [FieldOffset(0x0008)] public float TangentLen;
    [FieldOffset(0x000C)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct ULandscapeSplineSegment
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FLandscapeSplineSegmentConnection Connections;
    [FieldOffset(0x0058)] public FInterpCurveVector SplineInfo;
    [FieldOffset(0x0070)] public TArray<FLandscapeSplineInterpPoint> Points;
    [FieldOffset(0x0080)] public FBox Bounds;
    [FieldOffset(0x00A0)] public TArray<IntPtr> LocalMeshComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5B8)] 
public unsafe struct ALandscapeStreamingProxy
{
    [FieldOffset(0x0000)] public ALandscapeProxy baseObj;
    [FieldOffset(0x0598)] public TLazyObjectPtr<ALandscape> LandscapeActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct ULandscapeSubsystem
{
    [FieldOffset(0x0000)] public UTickableWorldSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct ULandscapeWeightmapUsage
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ULandscapeComponent* ChannelUsage;
    [FieldOffset(0x0048)] public FGuid LayerGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGrassInput
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public ULandscapeGrassType* GrassType;
    [FieldOffset(0x0010)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionLandscapeGrassOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public TArray<FGrassInput> GrassTypes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FLayerBlendInput
{
    [FieldOffset(0x0000)] public FName LayerName;
    [FieldOffset(0x0008)] public ELandscapeLayerBlendType BlendType;
    [FieldOffset(0x000C)] public FExpressionInput LayerInput;
    [FieldOffset(0x0020)] public FExpressionInput HeightInput;
    [FieldOffset(0x0034)] public float PreviewWeight;
    [FieldOffset(0x0038)] public FVector ConstLayerInput;
    [FieldOffset(0x0044)] public float ConstHeightInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionLandscapeLayerBlend
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public TArray<FLayerBlendInput> Layers;
    [FieldOffset(0x0050)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionLandscapeLayerCoords
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public ETerrainCoordMappingType MappingType;
    [FieldOffset(0x0041)] public ELandscapeCustomizedCoordType CustomUVType;
    [FieldOffset(0x0044)] public float MappingScale;
    [FieldOffset(0x0048)] public float MappingRotation;
    [FieldOffset(0x004C)] public float MappingPanU;
    [FieldOffset(0x0050)] public float MappingPanV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionLandscapeLayerSample
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FName ParameterName;
    [FieldOffset(0x0048)] public float PreviewWeight;
    [FieldOffset(0x004C)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionLandscapeLayerSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput LayerUsed;
    [FieldOffset(0x0054)] public FExpressionInput LayerNotUsed;
    [FieldOffset(0x0068)] public FName ParameterName;
    [FieldOffset(0x0070)] public byte PreviewUsed;
    [FieldOffset(0x0074)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionLandscapeLayerWeight
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Base;
    [FieldOffset(0x0054)] public FExpressionInput Layer;
    [FieldOffset(0x0068)] public FName ParameterName;
    [FieldOffset(0x0070)] public float PreviewWeight;
    [FieldOffset(0x0074)] public FVector ConstBase;
    [FieldOffset(0x0080)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FPhysicalMaterialInput
{
    [FieldOffset(0x0000)] public UPhysicalMaterial* PhysicalMaterial;
    [FieldOffset(0x0008)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionLandscapePhysicalMaterialOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public TArray<FPhysicalMaterialInput> Inputs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionLandscapeVisibilityMask
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FLandscapeLayerBrush
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FLandscapeLayer
{
    [FieldOffset(0x0000)] public FGuid Guid;
    [FieldOffset(0x0010)] public FName Name;
    [FieldOffset(0x0018)] public bool bVisible;
    [FieldOffset(0x0019)] public bool bLocked;
    [FieldOffset(0x001C)] public float HeightmapAlpha;
    [FieldOffset(0x0020)] public float WeightmapAlpha;
    [FieldOffset(0x0024)] public ELandscapeBlendMode BlendMode;
    [FieldOffset(0x0028)] public TArray<FLandscapeLayerBrush> Brushes;
    [FieldOffset(0x0038)] public TMap<IntPtr, bool> WeightmapLayerAllocationBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FHeightmapData
{
    [FieldOffset(0x0000)] public UTexture2D* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FWeightmapData
{
    [FieldOffset(0x0000)] public TArray<IntPtr> Textures;
    [FieldOffset(0x0010)] public TArray<FWeightmapLayerAllocationInfo> LayerAllocations;
    [FieldOffset(0x0020)] public TArray<IntPtr> TextureUsages;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FLandscapeLayerComponentData
{
    [FieldOffset(0x0000)] public FHeightmapData HeightmapData;
    [FieldOffset(0x0008)] public FWeightmapData WeightmapData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FLandscapeEditToolRenderData
{
    [FieldOffset(0x0000)] public UMaterialInterface* ToolMaterial;
    [FieldOffset(0x0008)] public UMaterialInterface* GizmoMaterial;
    [FieldOffset(0x0010)] public int SelectedType;
    [FieldOffset(0x0014)] public int DebugChannelR;
    [FieldOffset(0x0018)] public int DebugChannelG;
    [FieldOffset(0x001C)] public int DebugChannelB;
    [FieldOffset(0x0020)] public UTexture2D* DataTexture;
    [FieldOffset(0x0028)] public UTexture2D* LayerContributionTexture;
    [FieldOffset(0x0030)] public UTexture2D* DirtyTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FGizmoSelectData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLandscapeInfoLayerSettings
{
    [FieldOffset(0x0000)] public ULandscapeLayerInfoObject* LayerInfoObj;
    [FieldOffset(0x0008)] public FName LayerName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FLandscapeImportLayerInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FLandscapeLayerStruct
{
    [FieldOffset(0x0000)] public ULandscapeLayerInfoObject* LayerInfoObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FLandscapeEditorLayerSettings
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FForeignWorldSplineData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FForeignSplineSegmentData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FForeignControlPointData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FLandscapeSplineMeshEntry
{
    [FieldOffset(0x0000)] public UStaticMesh* Mesh;
    [FieldOffset(0x0008)] public TArray<IntPtr> MaterialOverrides;
    [FieldOffset(0x0018)] public byte bCenterH;
    [FieldOffset(0x001C)] public FVector2D CenterAdjust;
    [FieldOffset(0x0024)] public byte bScaleToWidth;
    [FieldOffset(0x0028)] public FVector Scale;
    [FieldOffset(0x0034)] public LandscapeSplineMeshOrientation Orientation;
    [FieldOffset(0x0035)] public ESplineMeshAxis ForwardAxis;
    [FieldOffset(0x0036)] public ESplineMeshAxis UpAxis;
}

