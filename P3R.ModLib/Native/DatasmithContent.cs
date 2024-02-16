using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDatasmithObjectTemplate
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UDatasmithActorTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public TSet<FName> Layers;
    [FieldOffset(0x0080)] public TSet<FName> Tags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithAdditionalData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ADatasmithAreaLightActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public EComponentMobility Mobility;
    [FieldOffset(0x0221)] public EDatasmithAreaLightActorType LightType;
    [FieldOffset(0x0222)] public EDatasmithAreaLightActorShape LightShape;
    [FieldOffset(0x0224)] public FVector2D Dimensions;
    [FieldOffset(0x022C)] public float Intensity;
    [FieldOffset(0x0230)] public ELightUnits IntensityUnits;
    [FieldOffset(0x0234)] public FLinearColor Color;
    [FieldOffset(0x0244)] public float Temperature;
    [FieldOffset(0x0248)] public UTextureLightProfile* IESTexture;
    [FieldOffset(0x0250)] public bool bUseIESBrightness;
    [FieldOffset(0x0254)] public float IESBrightnessScale;
    [FieldOffset(0x0258)] public FRotator Rotation;
    [FieldOffset(0x0264)] public float SourceRadius;
    [FieldOffset(0x0268)] public float SourceLength;
    [FieldOffset(0x026C)] public float AttenuationRadius;
    [FieldOffset(0x0270)] public float SpotlightInnerAngle;
    [FieldOffset(0x0274)] public float SpotlightOuterAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UDatasmithAreaLightActorTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public EDatasmithAreaLightActorType LightType;
    [FieldOffset(0x0031)] public EDatasmithAreaLightActorShape LightShape;
    [FieldOffset(0x0034)] public FVector2D Dimensions;
    [FieldOffset(0x003C)] public FLinearColor Color;
    [FieldOffset(0x004C)] public float Intensity;
    [FieldOffset(0x0050)] public ELightUnits IntensityUnits;
    [FieldOffset(0x0054)] public float Temperature;
    [FieldOffset(0x0058)] public TSoftObjectPtr<UTextureLightProfile> IESTexture;
    [FieldOffset(0x0080)] public bool bUseIESBrightness;
    [FieldOffset(0x0084)] public float IESBrightnessScale;
    [FieldOffset(0x0088)] public FRotator Rotation;
    [FieldOffset(0x0094)] public float SourceRadius;
    [FieldOffset(0x0098)] public float SourceLength;
    [FieldOffset(0x009C)] public float AttenuationRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithAssetImportData
{
    [FieldOffset(0x0000)] public UAssetImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithStaticMeshImportData
{
    [FieldOffset(0x0000)] public UDatasmithAssetImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithStaticMeshCADImportData
{
    [FieldOffset(0x0000)] public UDatasmithStaticMeshImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithSceneImportData
{
    [FieldOffset(0x0000)] public UAssetImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithTranslatedSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithCADImportSceneData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithMDLSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDatasmithGLTFSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
    [FieldOffset(0x0028)] public FString Generator;
    [FieldOffset(0x0038)] public float Version;
    [FieldOffset(0x0040)] public FString Author;
    [FieldOffset(0x0050)] public FString License;
    [FieldOffset(0x0060)] public FString Source;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatasmithStaticMeshGLTFImportData
{
    [FieldOffset(0x0000)] public UDatasmithStaticMeshImportData baseObj;
    [FieldOffset(0x0028)] public FString SourceMeshName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDatasmithFBXSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
    [FieldOffset(0x0028)] public bool bGenerateLightmapUVs;
    [FieldOffset(0x0030)] public FString TexturesDir;
    [FieldOffset(0x0040)] public byte IntermediateSerialization;
    [FieldOffset(0x0041)] public bool bColorizeMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithDeltaGenAssetImportData
{
    [FieldOffset(0x0000)] public UDatasmithAssetImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDatasmithDeltaGenSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithFBXSceneImportData baseObj;
    [FieldOffset(0x0048)] public bool bMergeNodes;
    [FieldOffset(0x0049)] public bool bOptimizeDuplicatedNodes;
    [FieldOffset(0x004A)] public bool bRemoveInvisibleNodes;
    [FieldOffset(0x004B)] public bool bSimplifyNodeHierarchy;
    [FieldOffset(0x004C)] public bool bImportVar;
    [FieldOffset(0x0050)] public FString VarPath;
    [FieldOffset(0x0060)] public bool bImportPos;
    [FieldOffset(0x0068)] public FString PosPath;
    [FieldOffset(0x0078)] public bool bImportTml;
    [FieldOffset(0x0080)] public FString TmlPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithVREDAssetImportData
{
    [FieldOffset(0x0000)] public UDatasmithAssetImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UDatasmithVREDSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithFBXSceneImportData baseObj;
    [FieldOffset(0x0048)] public bool bMergeNodes;
    [FieldOffset(0x0049)] public bool bOptimizeDuplicatedNodes;
    [FieldOffset(0x004A)] public bool bImportMats;
    [FieldOffset(0x0050)] public FString MatsPath;
    [FieldOffset(0x0060)] public bool bImportVar;
    [FieldOffset(0x0061)] public bool bCleanVar;
    [FieldOffset(0x0068)] public FString VarPath;
    [FieldOffset(0x0078)] public bool bImportLightInfo;
    [FieldOffset(0x0080)] public FString LightInfoPath;
    [FieldOffset(0x0090)] public bool bImportClipInfo;
    [FieldOffset(0x0098)] public FString ClipInfoPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithIFCSceneImportData
{
    [FieldOffset(0x0000)] public UDatasmithSceneImportData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatasmithStaticMeshIFCImportData
{
    [FieldOffset(0x0000)] public UDatasmithStaticMeshImportData baseObj;
    [FieldOffset(0x0028)] public FString SourceGlobalId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UDatasmithAssetUserData
{
    [FieldOffset(0x0000)] public UAssetUserData baseObj;
    [FieldOffset(0x0028)] public TMap<FName, FString> MetaData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDatasmithCameraLookatTrackingSettingsTemplate
{
    [FieldOffset(0x0000)] public byte bEnableLookAtTracking;
    [FieldOffset(0x0000)] public byte bAllowRoll;
    [FieldOffset(0x0008)] public TSoftObjectPtr<AActor> ActorToTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDatasmithCineCameraActorTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public FDatasmithCameraLookatTrackingSettingsTemplate LookatTrackingSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatasmithCameraFilmbackSettingsTemplate
{
    [FieldOffset(0x0000)] public float SensorWidth;
    [FieldOffset(0x0004)] public float SensorHeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatasmithCameraLensSettingsTemplate
{
    [FieldOffset(0x0000)] public float MaxFStop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatasmithCameraFocusSettingsTemplate
{
    [FieldOffset(0x0000)] public ECameraFocusMethod FocusMethod;
    [FieldOffset(0x0004)] public float ManualFocusDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FDatasmithPostProcessSettingsTemplate
{
    [FieldOffset(0x0000)] public byte bOverride_WhiteTemp;
    [FieldOffset(0x0000)] public byte bOverride_ColorSaturation;
    [FieldOffset(0x0000)] public byte bOverride_VignetteIntensity;
    [FieldOffset(0x0000)] public byte bOverride_FilmWhitePoint;
    [FieldOffset(0x0000)] public byte bOverride_AutoExposureMethod;
    [FieldOffset(0x0000)] public byte bOverride_CameraISO;
    [FieldOffset(0x0000)] public byte bOverride_CameraShutterSpeed;
    [FieldOffset(0x0004)] public byte bOverride_DepthOfFieldFstop;
    [FieldOffset(0x0008)] public float WhiteTemp;
    [FieldOffset(0x000C)] public float VignetteIntensity;
    [FieldOffset(0x0010)] public FLinearColor FilmWhitePoint;
    [FieldOffset(0x0020)] public FVector4 ColorSaturation;
    [FieldOffset(0x0030)] public EAutoExposureMethod AutoExposureMethod;
    [FieldOffset(0x0034)] public float CameraISO;
    [FieldOffset(0x0038)] public float CameraShutterSpeed;
    [FieldOffset(0x003C)] public float DepthOfFieldFstop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDatasmithCineCameraComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public FDatasmithCameraFilmbackSettingsTemplate FilmbackSettings;
    [FieldOffset(0x0038)] public FDatasmithCameraLensSettingsTemplate LensSettings;
    [FieldOffset(0x003C)] public FDatasmithCameraFocusSettingsTemplate FocusSettings;
    [FieldOffset(0x0044)] public float CurrentFocalLength;
    [FieldOffset(0x0048)] public float CurrentAperture;
    [FieldOffset(0x0050)] public FDatasmithPostProcessSettingsTemplate PostProcessSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithContentBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDatasmithCustomActionBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDatasmithDecalComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public int SortOrder;
    [FieldOffset(0x0034)] public FVector DecalSize;
    [FieldOffset(0x0040)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ADatasmithImportedSequencesActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public TArray<IntPtr> ImportedSequences;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatasmithOptionsBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatasmithTessellationOptions
{
    [FieldOffset(0x0000)] public float ChordTolerance;
    [FieldOffset(0x0004)] public float MaxEdgeLength;
    [FieldOffset(0x0008)] public float NormalTolerance;
    [FieldOffset(0x000C)] public EDatasmithCADStitchingTechnique StitchingTechnique;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatasmithCommonTessellationOptions
{
    [FieldOffset(0x0000)] public UDatasmithOptionsBase baseObj;
    [FieldOffset(0x0028)] public FDatasmithTessellationOptions Options;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatasmithAssetImportOptions
{
    [FieldOffset(0x0000)] public FName PackagePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatasmithStaticMeshImportOptions
{
    [FieldOffset(0x0000)] public EDatasmithImportLightmapMin MinLightmapResolution;
    [FieldOffset(0x0001)] public EDatasmithImportLightmapMax MaxLightmapResolution;
    [FieldOffset(0x0002)] public bool bGenerateLightmapUVs;
    [FieldOffset(0x0003)] public bool bRemoveDegenerates;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatasmithImportBaseOptions
{
    [FieldOffset(0x0000)] public EDatasmithImportScene SceneHandling;
    [FieldOffset(0x0001)] public bool bIncludeGeometry;
    [FieldOffset(0x0002)] public bool bIncludeMaterial;
    [FieldOffset(0x0003)] public bool bIncludeLight;
    [FieldOffset(0x0004)] public bool bIncludeCamera;
    [FieldOffset(0x0005)] public bool bIncludeAnimation;
    [FieldOffset(0x0008)] public FDatasmithAssetImportOptions AssetOptions;
    [FieldOffset(0x0010)] public FDatasmithStaticMeshImportOptions StaticMeshOptions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FDatasmithReimportOptions
{
    [FieldOffset(0x0000)] public bool bUpdateActors;
    [FieldOffset(0x0001)] public bool bRespawnDeletedActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDatasmithImportOptions
{
    [FieldOffset(0x0000)] public UDatasmithOptionsBase baseObj;
    [FieldOffset(0x0028)] public EDatasmithImportSearchPackagePolicy SearchPackagePolicy;
    [FieldOffset(0x0029)] public EDatasmithImportAssetConflictPolicy MaterialConflictPolicy;
    [FieldOffset(0x002A)] public EDatasmithImportAssetConflictPolicy TextureConflictPolicy;
    [FieldOffset(0x002B)] public EDatasmithImportActorPolicy StaticMeshActorImportPolicy;
    [FieldOffset(0x002C)] public EDatasmithImportActorPolicy LightImportPolicy;
    [FieldOffset(0x002D)] public EDatasmithImportActorPolicy CameraImportPolicy;
    [FieldOffset(0x002E)] public EDatasmithImportActorPolicy OtherActorImportPolicy;
    [FieldOffset(0x002F)] public EDatasmithImportMaterialQuality MaterialQuality;
    [FieldOffset(0x0030)] public FDatasmithImportBaseOptions BaseOptions;
    [FieldOffset(0x0044)] public FDatasmithReimportOptions ReimportOptions;
    [FieldOffset(0x0048)] public FString Filename;
    [FieldOffset(0x0058)] public FString FilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatasmithLandscapeTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public UMaterialInterface* LandscapeMaterial;
    [FieldOffset(0x0038)] public int StaticLightingLOD;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UDatasmithLightComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public byte bVisible;
    [FieldOffset(0x0034)] public byte CastShadows;
    [FieldOffset(0x0034)] public byte bUseTemperature;
    [FieldOffset(0x0034)] public byte bUseIESBrightness;
    [FieldOffset(0x0038)] public float Intensity;
    [FieldOffset(0x003C)] public float Temperature;
    [FieldOffset(0x0040)] public float IESBrightnessScale;
    [FieldOffset(0x0044)] public FLinearColor LightColor;
    [FieldOffset(0x0058)] public UMaterialInterface* LightFunctionMaterial;
    [FieldOffset(0x0060)] public UTextureLightProfile* IESTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDatasmithStaticParameterSetTemplate
{
    [FieldOffset(0x0000)] public TMap<FName, bool> StaticSwitchParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x198)] 
public unsafe struct UDatasmithMaterialInstanceTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public TSoftObjectPtr<UMaterialInterface> ParentMaterial;
    [FieldOffset(0x0058)] public TMap<FName, float> ScalarParameterValues;
    [FieldOffset(0x00A8)] public TMap<FName, FLinearColor> VectorParameterValues;
    [FieldOffset(0x00F8)] public TMap<FName, TSoftObjectPtr<UTexture>> TextureParameterValues;
    [FieldOffset(0x0148)] public FDatasmithStaticParameterSetTemplate StaticParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatasmithPointLightComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public ELightUnits IntensityUnits;
    [FieldOffset(0x0034)] public float SourceRadius;
    [FieldOffset(0x0038)] public float SourceLength;
    [FieldOffset(0x003C)] public float AttenuationRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UDatasmithPostProcessVolumeTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public FDatasmithPostProcessSettingsTemplate Settings;
    [FieldOffset(0x0070)] public byte bEnabled;
    [FieldOffset(0x0070)] public byte bUnbound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDatasmithScene
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ADatasmithSceneActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UDatasmithScene* Scene;
    [FieldOffset(0x0228)] public TMap<FName, TSoftObjectPtr<AActor>> RelatedActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UDatasmithSceneComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public FTransform RelativeTransform;
    [FieldOffset(0x0060)] public EComponentMobility Mobility;
    [FieldOffset(0x0068)] public TSoftObjectPtr<USceneComponent> AttachParent;
    [FieldOffset(0x0090)] public bool bVisible;
    [FieldOffset(0x0098)] public TSet<FName> Tags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatasmithSkyLightComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public ESkyLightSourceType SourceType;
    [FieldOffset(0x0034)] public int CubemapResolution;
    [FieldOffset(0x0038)] public UTextureCube* Cubemap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatasmithSpotLightComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public float InnerConeAngle;
    [FieldOffset(0x0034)] public float OuterConeAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDatasmithStaticMeshComponentTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0038)] public TArray<IntPtr> OverrideMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatasmithMeshSectionInfoTemplate
{
    [FieldOffset(0x0000)] public int MaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDatasmithMeshSectionInfoMapTemplate
{
    [FieldOffset(0x0000)] public TMap<uint, FDatasmithMeshSectionInfoTemplate> Map;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatasmithMeshBuildSettingsTemplate
{
    [FieldOffset(0x0000)] public byte bUseMikkTSpace;
    [FieldOffset(0x0000)] public byte bRecomputeNormals;
    [FieldOffset(0x0000)] public byte bRecomputeTangents;
    [FieldOffset(0x0000)] public byte bRemoveDegenerates;
    [FieldOffset(0x0000)] public byte bBuildAdjacencyBuffer;
    [FieldOffset(0x0000)] public byte bUseHighPrecisionTangentBasis;
    [FieldOffset(0x0000)] public byte bUseFullPrecisionUVs;
    [FieldOffset(0x0000)] public byte bGenerateLightmapUVs;
    [FieldOffset(0x0004)] public int MinLightmapResolution;
    [FieldOffset(0x0008)] public int SrcLightmapIndex;
    [FieldOffset(0x000C)] public int DstLightmapIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatasmithStaticMaterialTemplate
{
    [FieldOffset(0x0000)] public FName MaterialSlotName;
    [FieldOffset(0x0008)] public UMaterialInterface* MaterialInterface;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UDatasmithStaticMeshTemplate
{
    [FieldOffset(0x0000)] public UDatasmithObjectTemplate baseObj;
    [FieldOffset(0x0030)] public FDatasmithMeshSectionInfoMapTemplate SectionInfoMap;
    [FieldOffset(0x0080)] public int LightMapCoordinateIndex;
    [FieldOffset(0x0084)] public int LightMapResolution;
    [FieldOffset(0x0088)] public TArray<FDatasmithMeshBuildSettingsTemplate> BuildSettings;
    [FieldOffset(0x0098)] public TArray<FDatasmithStaticMaterialTemplate> StaticMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatasmithRetessellationOptions
{
    [FieldOffset(0x0000)] public FDatasmithTessellationOptions baseObj;
    [FieldOffset(0x0010)] public EDatasmithCADRetessellationRule RetessellationRule;
}

