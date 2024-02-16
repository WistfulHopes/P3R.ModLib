using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieSceneNiagaraTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNiagaraTypeDefinitionHandle
{
    [FieldOffset(0x0000)] public int RegisteredTypeIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNiagaraVariableBase
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FNiagaraTypeDefinitionHandle TypeDefHandle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraVariable
{
    [FieldOffset(0x0000)] public FNiagaraVariableBase baseObj;
    [FieldOffset(0x0010)] public TArray<byte> VarData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneNiagaraParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraTrack baseObj;
    [FieldOffset(0x00A0)] public FNiagaraVariable Parameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneNiagaraBoolParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraParameterTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneNiagaraColorParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraParameterTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneNiagaraFloatParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraParameterTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneNiagaraIntegerParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraParameterTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UMovieSceneNiagaraSystemSpawnSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior;
    [FieldOffset(0x00EC)] public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior;
    [FieldOffset(0x00F0)] public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior;
    [FieldOffset(0x00F4)] public ENiagaraAgeUpdateMode AgeUpdateMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneNiagaraSystemTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMovieSceneNiagaraVectorParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNiagaraParameterTrack baseObj;
    [FieldOffset(0x00C8)] public int ChannelsUsed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ANiagaraActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UNiagaraComponent* NiagaraComponent;
    [FieldOffset(0x0228)] public byte bDestroyOnSystemFinish;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraBakerTextureSource
{
    [FieldOffset(0x0000)] public FName SourceName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraBakerTextureSettings
{
    [FieldOffset(0x0000)] public FName OutputName;
    [FieldOffset(0x0008)] public FNiagaraBakerTextureSource SourceBinding;
    [FieldOffset(0x0010)] public byte bUseFrameSize;
    [FieldOffset(0x0014)] public FIntPoint FrameSize;
    [FieldOffset(0x001C)] public FIntPoint TextureSize;
    [FieldOffset(0x0028)] public UTexture2D* GeneratedTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UNiagaraBakerSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float StartSeconds;
    [FieldOffset(0x002C)] public float DurationSeconds;
    [FieldOffset(0x0030)] public int FramesPerSecond;
    [FieldOffset(0x0034)] public byte bPreviewLooping;
    [FieldOffset(0x0038)] public FIntPoint FramesPerDimension;
    [FieldOffset(0x0040)] public TArray<FNiagaraBakerTextureSettings> OutputTextures;
    [FieldOffset(0x0050)] public ENiagaraBakerViewMode CameraViewportMode;
    [FieldOffset(0x0054)] public FVector CameraViewportLocation;
    [FieldOffset(0x00A8)] public FRotator CameraViewportRotation;
    [FieldOffset(0x00FC)] public float CameraOrbitDistance;
    [FieldOffset(0x0100)] public float CameraFOV;
    [FieldOffset(0x0104)] public float CameraOrthoWidth;
    [FieldOffset(0x0108)] public byte bUseCameraAspectRatio;
    [FieldOffset(0x010C)] public float CameraAspectRatio;
    [FieldOffset(0x0110)] public byte bRenderComponentOnly;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraVariableWithOffset
{
    [FieldOffset(0x0000)] public FNiagaraVariableBase baseObj;
    [FieldOffset(0x000C)] public int Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FNiagaraParameterStore
{
    [FieldOffset(0x0008)] public UObject* Owner;
    [FieldOffset(0x0010)] public TArray<FNiagaraVariableWithOffset> SortedParameterOffsets;
    [FieldOffset(0x0020)] public TArray<byte> ParameterData;
    [FieldOffset(0x0030)] public TArray<IntPtr> DataInterfaces;
    [FieldOffset(0x0040)] public TArray<IntPtr> UObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FNiagaraUserRedirectionParameterStore
{
    [FieldOffset(0x0000)] public FNiagaraParameterStore baseObj;
    [FieldOffset(0x0078)] public TMap<FNiagaraVariable, FNiagaraVariable> UserParameterRedirects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraMaterialOverride
{
    [FieldOffset(0x0000)] public UMaterialInterface* Material;
    [FieldOffset(0x0008)] public uint MaterialSubIndex;
    [FieldOffset(0x0010)] public UNiagaraRendererProperties* EmitterRendererProperty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x600)] 
public unsafe struct UNiagaraComponent
{
    [FieldOffset(0x0000)] public UFXSystemComponent baseObj;
    [FieldOffset(0x0450)] public UNiagaraSystem* Asset;
    [FieldOffset(0x0458)] public ENiagaraTickBehavior TickBehavior;
    [FieldOffset(0x045C)] public int RandomSeedOffset;
    [FieldOffset(0x0460)] public FNiagaraUserRedirectionParameterStore OverrideParameters;
    [FieldOffset(0x0528)] public byte bForceSolo;
    [FieldOffset(0x0528)] public byte bEnableGpuComputeDebug;
    [FieldOffset(0x0558)] public byte bAutoDestroy;
    [FieldOffset(0x0558)] public byte bRenderingEnabled;
    [FieldOffset(0x0558)] public byte bAutoManageAttachment;
    [FieldOffset(0x0558)] public byte bAutoAttachWeldSimulatedBodies;
    [FieldOffset(0x055C)] public float MaxTimeBeforeForceUpdateTransform;
    [FieldOffset(0x0560)] public TArray<FNiagaraMaterialOverride> EmitterMaterials;
    [FieldOffset(0x0588)] public TWeakObjectPtr<USceneComponent> AutoAttachParent;
    [FieldOffset(0x0590)] public FName AutoAttachSocketName;
    [FieldOffset(0x0598)] public EAttachmentRule AutoAttachLocationRule;
    [FieldOffset(0x0599)] public EAttachmentRule AutoAttachRotationRule;
    [FieldOffset(0x059A)] public EAttachmentRule AutoAttachScaleRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNCPoolElement
{
    [FieldOffset(0x0000)] public UNiagaraComponent* Component;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNCPool
{
    [FieldOffset(0x0000)] public TArray<FNCPoolElement> FreeElements;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UNiagaraComponentPool
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TMap<IntPtr, FNCPool> WorldParticleSystemPools;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraDeviceProfileStateEntry
{
    [FieldOffset(0x0000)] public FName ProfileName;
    [FieldOffset(0x0008)] public uint QualityLevelMask;
    [FieldOffset(0x000C)] public uint SetQualityLevelMask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraPlatformSetCVarCondition
{
    [FieldOffset(0x0000)] public FName CVarName;
    [FieldOffset(0x0008)] public bool Value;
    [FieldOffset(0x000C)] public int MinInt;
    [FieldOffset(0x0010)] public int MaxInt;
    [FieldOffset(0x0014)] public float MinFloat;
    [FieldOffset(0x0018)] public float MaxFloat;
    [FieldOffset(0x001C)] public byte bUseMinInt;
    [FieldOffset(0x001C)] public byte bUseMaxInt;
    [FieldOffset(0x001C)] public byte bUseMinFloat;
    [FieldOffset(0x001C)] public byte bUseMaxFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraPlatformSet
{
    [FieldOffset(0x0000)] public int QualityLevelMask;
    [FieldOffset(0x0008)] public TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates;
    [FieldOffset(0x0018)] public TArray<FNiagaraPlatformSetCVarCondition> CVarConditions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UNiagaraRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraMergeable baseObj;
    [FieldOffset(0x0028)] public FNiagaraPlatformSet Platforms;
    [FieldOffset(0x0058)] public int SortOrderHint;
    [FieldOffset(0x005C)] public ENiagaraRendererMotionVectorSetting MotionVectorSetting;
    [FieldOffset(0x0060)] public bool bIsEnabled;
    [FieldOffset(0x0061)] public bool bMotionBlurEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FNiagaraVariableAttributeBinding
{
    [FieldOffset(0x0000)] public FNiagaraVariableBase ParamMapVariable;
    [FieldOffset(0x0010)] public FNiagaraVariable DataSetVariable;
    [FieldOffset(0x0030)] public FNiagaraVariable RootVariable;
    [FieldOffset(0x0050)] public ENiagaraBindingSource BindingSourceMode;
    [FieldOffset(0x0054)] public byte bBindingExistsOnSource;
    [FieldOffset(0x0054)] public byte bIsCachedParticleValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraTypeDefinition
{
    [FieldOffset(0x0000)] public UObject* ClassStructOrEnum;
    [FieldOffset(0x0008)] public ushort UnderlyingType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FNiagaraComponentPropertyBinding
{
    [FieldOffset(0x0000)] public FNiagaraVariableAttributeBinding AttributeBinding;
    [FieldOffset(0x0058)] public FName PropertyName;
    [FieldOffset(0x0060)] public FNiagaraTypeDefinition PropertyType;
    [FieldOffset(0x0070)] public FName MetadataSetterName;
    [FieldOffset(0x0078)] public TMap<FString, FString> PropertySetterParameterDefaults;
    [FieldOffset(0x00C8)] public FNiagaraVariable WritableValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UNiagaraComponentRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraRendererProperties baseObj;
    [FieldOffset(0x0078)] public TSubclassOf<USceneComponent> ComponentType;
    [FieldOffset(0x0080)] public uint ComponentCountLimit;
    [FieldOffset(0x0088)] public FNiagaraVariableAttributeBinding EnabledBinding;
    [FieldOffset(0x00E0)] public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
    [FieldOffset(0x0138)] public bool bAssignComponentsOnParticleID;
    [FieldOffset(0x0139)] public bool bOnlyCreateComponentsOnParticleSpawn;
    [FieldOffset(0x013C)] public int RendererVisibility;
    [FieldOffset(0x0140)] public USceneComponent* TemplateComponent;
    [FieldOffset(0x0148)] public TArray<FNiagaraComponentPropertyBinding> PropertyBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UNiagaraComponentSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSet<FName> SuppressActivationList;
    [FieldOffset(0x0078)] public TSet<FName> ForceAutoPooolingList;
    [FieldOffset(0x00C8)] public TSet<FNiagaraEmitterNameSettingsRef> SuppressEmitterList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraConvertInPlaceUtilityBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterface
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraDataInterface2DArrayTexture
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UTexture2DArray* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraDataInterfaceArray
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0040)] public int MaxElements;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayFloat
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<float> FloatData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayFloat2
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<FVector2D> FloatData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayFloat3
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<FVector> FloatData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayFloat4
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<FVector4> FloatData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayColor
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<FLinearColor> ColorData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayQuat
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<FQuat> QuatData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraDataInterfaceArrayFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayInt32
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<int> IntData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceArrayBool
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceArray baseObj;
    [FieldOffset(0x0050)] public TArray<bool> BoolData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraDataInterfaceAudioSubmix
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public USoundSubmix* Submix;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceAudioOscilloscope
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public USoundSubmix* Submix;
    [FieldOffset(0x0040)] public int Resolution;
    [FieldOffset(0x0044)] public float ScopeInMilliseconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNiagaraDataInterfaceAudioPlayer
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public USoundBase* SoundToPlay;
    [FieldOffset(0x0040)] public USoundAttenuation* Attenuation;
    [FieldOffset(0x0048)] public USoundConcurrency* Concurrency;
    [FieldOffset(0x0050)] public TArray<FName> ParameterNames;
    [FieldOffset(0x0060)] public bool bLimitPlaysPerTick;
    [FieldOffset(0x0064)] public int MaxPlaysPerTick;
    [FieldOffset(0x0068)] public bool bStopWhenComponentIsDestroyed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraDataInterfaceAudioSpectrum
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceAudioSubmix baseObj;
    [FieldOffset(0x0040)] public int Resolution;
    [FieldOffset(0x0044)] public float MinimumFrequency;
    [FieldOffset(0x0048)] public float MaximumFrequency;
    [FieldOffset(0x004C)] public float NoiseFloorDb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraDataInterfaceCamera
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public int PlayerControllerIndex;
    [FieldOffset(0x003C)] public bool bRequireCurrentFrameData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceCollisionQuery
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNiagaraDataInterfaceCurveBase
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public TArray<float> ShaderLUT;
    [FieldOffset(0x0048)] public float LUTMinTime;
    [FieldOffset(0x004C)] public float LUTMaxTime;
    [FieldOffset(0x0050)] public float LUTInvTimeRange;
    [FieldOffset(0x0054)] public float LUTNumSamplesMinusOne;
    [FieldOffset(0x0058)] public byte bUseLUT;
    [FieldOffset(0x0058)] public byte bExposeCurve;
    [FieldOffset(0x005C)] public FName ExposedName;
    [FieldOffset(0x0068)] public UTexture2D* ExposedTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UNiagaraDataInterfaceColorCurve
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceCurveBase baseObj;
    [FieldOffset(0x0070)] public FRichCurve RedCurve;
    [FieldOffset(0x00F0)] public FRichCurve GreenCurve;
    [FieldOffset(0x0170)] public FRichCurve BlueCurve;
    [FieldOffset(0x01F0)] public FRichCurve AlphaCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceCubeTexture
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UTextureCube* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceCurlNoise
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public uint Seed;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UNiagaraDataInterfaceCurve
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceCurveBase baseObj;
    [FieldOffset(0x0070)] public FRichCurve Curve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterfaceDebugDraw
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FBasicParticleData
{
    [FieldOffset(0x0000)] public FVector Position;
    [FieldOffset(0x000C)] public float Size;
    [FieldOffset(0x0010)] public FVector Velocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INiagaraParticleCallbackHandler
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraUserParameterBinding
{
    [FieldOffset(0x0000)] public FNiagaraVariable Parameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UNiagaraDataInterfaceExport
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public FNiagaraUserParameterBinding CallbackHandlerParameter;
    [FieldOffset(0x0058)] public ENDIExport_GPUAllocationMode GPUAllocationMode;
    [FieldOffset(0x005C)] public int GPUAllocationFixedSize;
    [FieldOffset(0x0060)] public float GPUAllocationPerParticleSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterfaceGBuffer
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UNiagaraDataInterfaceRWBase
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public TSet<int> OutputShaderStages;
    [FieldOffset(0x0088)] public TSet<int> IterationShaderStages;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UNiagaraDataInterfaceGrid2D
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public int NumCellsX;
    [FieldOffset(0x00DC)] public int NumCellsY;
    [FieldOffset(0x00E0)] public int NumCellsMaxAxis;
    [FieldOffset(0x00E4)] public int NumAttributes;
    [FieldOffset(0x00E8)] public bool SetGridFromMaxAxis;
    [FieldOffset(0x00EC)] public FVector2D WorldBBoxSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UNiagaraDataInterfaceGrid2DCollection
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceGrid2D baseObj;
    [FieldOffset(0x00F8)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0118)] public ENiagaraGpuBufferFormat OverrideBufferFormat;
    [FieldOffset(0x0119)] public byte bOverrideFormat;
    [FieldOffset(0x0170)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UNiagaraDataInterfaceGrid2DCollectionReader
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceGrid2D baseObj;
    [FieldOffset(0x00F8)] public FString EmitterName;
    [FieldOffset(0x0108)] public FString DIName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UNiagaraDataInterfaceGrid3D
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FIntVector NumCells;
    [FieldOffset(0x00E4)] public float CellSize;
    [FieldOffset(0x00E8)] public int NumCellsMaxAxis;
    [FieldOffset(0x00EC)] public ESetResolutionMethod SetResolutionMethod;
    [FieldOffset(0x00F0)] public FVector WorldBBoxSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UNiagaraDataInterfaceGrid3DCollection
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceGrid3D baseObj;
    [FieldOffset(0x0100)] public int NumAttributes;
    [FieldOffset(0x0108)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0128)] public ENiagaraGpuBufferFormat OverrideBufferFormat;
    [FieldOffset(0x0129)] public byte bOverrideFormat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UNiagaraDataInterfaceIntRenderTarget2D
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FIntPoint Size;
    [FieldOffset(0x00E0)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0100)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNiagaraDataInterfaceLandscape
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public AActor* SourceLandscape;
    [FieldOffset(0x0040)] public ENDILandscape_SourceMode SourceMode;
    [FieldOffset(0x0048)] public TArray<IntPtr> PhysicalMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraDataInterfaceMeshRendererInfo
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UNiagaraMeshRendererProperties* MeshRenderer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UNiagaraDataInterfaceNeighborGrid3D
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceGrid3D baseObj;
    [FieldOffset(0x0100)] public uint MaxNeighborsPerCell;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterfaceOcclusion
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UNiagaraDataInterfaceParticleRead
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FString EmitterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UNiagaraDataInterfacePlatformSet
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public FNiagaraPlatformSet Platforms;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A8)] 
public unsafe struct UNiagaraDataInterfaceRenderTarget2D
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FIntPoint Size;
    [FieldOffset(0x00E0)] public ENiagaraMipMapGeneration MipMapGeneration;
    [FieldOffset(0x00E1)] public ETextureRenderTargetFormat OverrideRenderTargetFormat;
    [FieldOffset(0x00E2)] public byte bInheritUserParameterSettings;
    [FieldOffset(0x00E2)] public byte bOverrideFormat;
    [FieldOffset(0x00E8)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0158)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UNiagaraDataInterfaceRenderTarget2DArray
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FIntVector Size;
    [FieldOffset(0x00E4)] public ETextureRenderTargetFormat OverrideRenderTargetFormat;
    [FieldOffset(0x00E5)] public byte bInheritUserParameterSettings;
    [FieldOffset(0x00E5)] public byte bOverrideFormat;
    [FieldOffset(0x00E8)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0108)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UNiagaraDataInterfaceRenderTargetCube
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public int Size;
    [FieldOffset(0x00DC)] public ETextureRenderTargetFormat OverrideRenderTargetFormat;
    [FieldOffset(0x00DD)] public byte bInheritUserParameterSettings;
    [FieldOffset(0x00DD)] public byte bOverrideFormat;
    [FieldOffset(0x00E0)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0100)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UNiagaraDataInterfaceRenderTargetVolume
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceRWBase baseObj;
    [FieldOffset(0x00D8)] public FIntVector Size;
    [FieldOffset(0x00E4)] public ETextureRenderTargetFormat OverrideRenderTargetFormat;
    [FieldOffset(0x00E5)] public byte bInheritUserParameterSettings;
    [FieldOffset(0x00E5)] public byte bOverrideFormat;
    [FieldOffset(0x00E8)] public FNiagaraUserParameterBinding RenderTargetUserParameter;
    [FieldOffset(0x0108)] public TMap<ulong, IntPtr> ManagedRenderTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterfaceSimpleCounter
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UNiagaraDataInterfaceSkeletalMesh
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public ENDISkeletalMesh_SourceMode SourceMode;
    [FieldOffset(0x0040)] public AActor* Source;
    [FieldOffset(0x0048)] public FNiagaraUserParameterBinding MeshUserParameter;
    [FieldOffset(0x0068)] public USkeletalMeshComponent* SourceComponent;
    [FieldOffset(0x0070)] public ENDISkeletalMesh_SkinningMode SkinningMode;
    [FieldOffset(0x0078)] public TArray<FName> SamplingRegions;
    [FieldOffset(0x0088)] public int WholeMeshLOD;
    [FieldOffset(0x0090)] public TArray<FName> FilteredBones;
    [FieldOffset(0x00A0)] public TArray<FName> FilteredSockets;
    [FieldOffset(0x00B0)] public FName ExcludeBoneName;
    [FieldOffset(0x00B8)] public byte bExcludeBone;
    [FieldOffset(0x00BC)] public int UvSetIndex;
    [FieldOffset(0x00C0)] public bool bRequireCurrentFrameData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceSpline
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public AActor* Source;
    [FieldOffset(0x0040)] public FNiagaraUserParameterBinding SplineUserParameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNDIStaticMeshSectionFilter
{
    [FieldOffset(0x0000)] public TArray<int> AllowedMaterialSlots;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UNiagaraDataInterfaceStaticMesh
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public ENDIStaticMesh_SourceMode SourceMode;
    [FieldOffset(0x0040)] public UStaticMesh* DefaultMesh;
    [FieldOffset(0x0048)] public AActor* Source;
    [FieldOffset(0x0050)] public UStaticMeshComponent* SourceComponent;
    [FieldOffset(0x0058)] public FNDIStaticMeshSectionFilter SectionFilter;
    [FieldOffset(0x0068)] public bool bUsePhysicsBodyVelocity;
    [FieldOffset(0x0070)] public TArray<FName> FilteredSockets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceTexture
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UTexture* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UNiagaraDataInterfaceVector2DCurve
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceCurveBase baseObj;
    [FieldOffset(0x0070)] public FRichCurve XCurve;
    [FieldOffset(0x00F0)] public FRichCurve YCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UNiagaraDataInterfaceVector4Curve
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceCurveBase baseObj;
    [FieldOffset(0x0070)] public FRichCurve XCurve;
    [FieldOffset(0x00F0)] public FRichCurve YCurve;
    [FieldOffset(0x0170)] public FRichCurve ZCurve;
    [FieldOffset(0x01F0)] public FRichCurve WCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct UNiagaraDataInterfaceVectorCurve
{
    [FieldOffset(0x0000)] public UNiagaraDataInterfaceCurveBase baseObj;
    [FieldOffset(0x0070)] public FRichCurve XCurve;
    [FieldOffset(0x00F0)] public FRichCurve YCurve;
    [FieldOffset(0x0170)] public FRichCurve ZCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceVectorField
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UVectorField* Field;
    [FieldOffset(0x0040)] public bool bTileX;
    [FieldOffset(0x0041)] public bool bTileY;
    [FieldOffset(0x0042)] public bool bTileZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraDataInterfaceVolumeTexture
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public UVolumeTexture* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraDebugHUDVariable
{
    [FieldOffset(0x0000)] public bool bEnabled;
    [FieldOffset(0x0008)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraDebugHudTextOptions
{
    [FieldOffset(0x0000)] public ENiagaraDebugHudFont Font;
    [FieldOffset(0x0004)] public ENiagaraDebugHudHAlign HorizontalAlignment;
    [FieldOffset(0x0005)] public ENiagaraDebugHudVAlign VerticalAlignment;
    [FieldOffset(0x0008)] public FVector2D ScreenOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FNiagaraDebugHUDSettingsData
{
    [FieldOffset(0x0000)] public bool bEnabled;
    [FieldOffset(0x0001)] public bool bValidateSystemSimulationDataBuffers;
    [FieldOffset(0x0002)] public bool bValidateParticleDataBuffers;
    [FieldOffset(0x0003)] public bool bOverviewEnabled;
    [FieldOffset(0x0004)] public ENiagaraDebugHudFont OverviewFont;
    [FieldOffset(0x0008)] public FVector2D OverviewLocation;
    [FieldOffset(0x0010)] public FString ActorFilter;
    [FieldOffset(0x0020)] public bool bComponentFilterEnabled;
    [FieldOffset(0x0028)] public FString ComponentFilter;
    [FieldOffset(0x0038)] public bool bSystemFilterEnabled;
    [FieldOffset(0x0040)] public FString SystemFilter;
    [FieldOffset(0x0050)] public bool bEmitterFilterEnabled;
    [FieldOffset(0x0058)] public FString EmitterFilter;
    [FieldOffset(0x0068)] public bool bActorFilterEnabled;
    [FieldOffset(0x006C)] public ENiagaraDebugHudVerbosity SystemDebugVerbosity;
    [FieldOffset(0x0070)] public ENiagaraDebugHudVerbosity SystemEmitterVerbosity;
    [FieldOffset(0x0074)] public bool bSystemShowBounds;
    [FieldOffset(0x0075)] public bool bSystemShowActiveOnlyInWorld;
    [FieldOffset(0x0076)] public bool bShowSystemVariables;
    [FieldOffset(0x0078)] public TArray<FNiagaraDebugHUDVariable> SystemVariables;
    [FieldOffset(0x0088)] public FNiagaraDebugHudTextOptions SystemTextOptions;
    [FieldOffset(0x0098)] public bool bShowParticleVariables;
    [FieldOffset(0x0099)] public bool bEnableGpuParticleReadback;
    [FieldOffset(0x00A0)] public TArray<FNiagaraDebugHUDVariable> ParticlesVariables;
    [FieldOffset(0x00B0)] public FNiagaraDebugHudTextOptions ParticleTextOptions;
    [FieldOffset(0x00C0)] public bool bShowParticlesVariablesWithSystem;
    [FieldOffset(0x00C1)] public bool bUseMaxParticlesToDisplay;
    [FieldOffset(0x00C4)] public int MaxParticlesToDisplay;
    [FieldOffset(0x00C8)] public ENiagaraDebugPlaybackMode PlaybackMode;
    [FieldOffset(0x00C9)] public bool bPlaybackRateEnabled;
    [FieldOffset(0x00CC)] public float PlaybackRate;
    [FieldOffset(0x00D0)] public bool bLoopTimeEnabled;
    [FieldOffset(0x00D4)] public float LoopTime;
    [FieldOffset(0x00D8)] public bool bShowGlobalBudgetInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UNiagaraDebugHUDSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public FNiagaraDebugHUDSettingsData Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraEditorDataBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraEditorParametersAdapterBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraSignificanceHandler
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraSignificanceHandlerDistance
{
    [FieldOffset(0x0000)] public UNiagaraSignificanceHandler baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraSignificanceHandlerAge
{
    [FieldOffset(0x0000)] public UNiagaraSignificanceHandler baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FNiagaraSystemScalabilitySettings
{
    [FieldOffset(0x0000)] public FNiagaraPlatformSet Platforms;
    [FieldOffset(0x0030)] public byte bCullByDistance;
    [FieldOffset(0x0030)] public byte bCullMaxInstanceCount;
    [FieldOffset(0x0030)] public byte bCullPerSystemMaxInstanceCount;
    [FieldOffset(0x0030)] public byte bCullByMaxTimeWithoutRender;
    [FieldOffset(0x0030)] public byte bCullByGlobalBudget;
    [FieldOffset(0x0034)] public float MaxDistance;
    [FieldOffset(0x0038)] public int MaxInstances;
    [FieldOffset(0x003C)] public int MaxSystemInstances;
    [FieldOffset(0x0040)] public float MaxTimeWithoutRender;
    [FieldOffset(0x0044)] public float MaxGlobalBudgetUsage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraSystemScalabilitySettingsArray
{
    [FieldOffset(0x0000)] public TArray<FNiagaraSystemScalabilitySettings> Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FNiagaraEmitterScalabilitySettings
{
    [FieldOffset(0x0000)] public FNiagaraPlatformSet Platforms;
    [FieldOffset(0x0030)] public byte bScaleSpawnCount;
    [FieldOffset(0x0034)] public float SpawnCountScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraEmitterScalabilitySettingsArray
{
    [FieldOffset(0x0000)] public TArray<FNiagaraEmitterScalabilitySettings> Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraPerfBaselineStats
{
    [FieldOffset(0x0000)] public float PerInstanceAvg_GT;
    [FieldOffset(0x0004)] public float PerInstanceAvg_RT;
    [FieldOffset(0x0008)] public float PerInstanceMax_GT;
    [FieldOffset(0x000C)] public float PerInstanceMax_RT;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UNiagaraEffectType
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ENiagaraScalabilityUpdateFrequency UpdateFrequency;
    [FieldOffset(0x002C)] public ENiagaraCullReaction CullReaction;
    [FieldOffset(0x0030)] public UNiagaraSignificanceHandler* SignificanceHandler;
    [FieldOffset(0x0038)] public TArray<FNiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings;
    [FieldOffset(0x0048)] public FNiagaraSystemScalabilitySettingsArray SystemScalabilitySettings;
    [FieldOffset(0x0058)] public FNiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings;
    [FieldOffset(0x0070)] public UNiagaraBaselineController* PerformanceBaselineController;
    [FieldOffset(0x0078)] public FNiagaraPerfBaselineStats PerfBaselineStats;
    [FieldOffset(0x0088)] public FGuid PerfBaselineVersion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraEventReceiverProperties
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FName SourceEventGenerator;
    [FieldOffset(0x0010)] public FName SourceEmitter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FNiagaraTypeLayoutInfo
{
    [FieldOffset(0x0000)] public TArray<uint> FloatComponentByteOffsets;
    [FieldOffset(0x0010)] public TArray<uint> FloatComponentRegisterOffsets;
    [FieldOffset(0x0020)] public TArray<uint> Int32ComponentByteOffsets;
    [FieldOffset(0x0030)] public TArray<uint> Int32ComponentRegisterOffsets;
    [FieldOffset(0x0040)] public TArray<uint> HalfComponentByteOffsets;
    [FieldOffset(0x0050)] public TArray<uint> HalfComponentRegisterOffsets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FNiagaraVariableLayoutInfo
{
    [FieldOffset(0x0000)] public uint FloatComponentStart;
    [FieldOffset(0x0004)] public uint Int32ComponentStart;
    [FieldOffset(0x0008)] public uint HalfComponentStart;
    [FieldOffset(0x0010)] public FNiagaraTypeLayoutInfo LayoutInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNiagaraDataSetID
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public ENiagaraDataSetType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNiagaraDataSetCompiledData
{
    [FieldOffset(0x0000)] public TArray<FNiagaraVariable> Variables;
    [FieldOffset(0x0010)] public TArray<FNiagaraVariableLayoutInfo> VariableLayouts;
    [FieldOffset(0x0020)] public FNiagaraDataSetID ID;
    [FieldOffset(0x002C)] public uint TotalFloatComponents;
    [FieldOffset(0x0030)] public uint TotalInt32Components;
    [FieldOffset(0x0034)] public uint TotalHalfComponents;
    [FieldOffset(0x0038)] public byte bRequiresPersistentIDs;
    [FieldOffset(0x003C)] public ENiagaraSimTarget SimTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FNiagaraEventGeneratorProperties
{
    [FieldOffset(0x0000)] public int MaxEventsPerFrame;
    [FieldOffset(0x0004)] public FName ID;
    [FieldOffset(0x0010)] public FNiagaraDataSetCompiledData DataSetCompiledData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraEmitterScriptProperties
{
    [FieldOffset(0x0000)] public UNiagaraScript* Script;
    [FieldOffset(0x0008)] public TArray<FNiagaraEventReceiverProperties> EventReceivers;
    [FieldOffset(0x0018)] public TArray<FNiagaraEventGeneratorProperties> EventGenerators;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FNiagaraDetailsLevelScaleOverrides
{
    [FieldOffset(0x0000)] public float Low;
    [FieldOffset(0x0004)] public float Medium;
    [FieldOffset(0x0008)] public float High;
    [FieldOffset(0x000C)] public float Epic;
    [FieldOffset(0x0010)] public float Cine;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNiagaraEmitterScalabilityOverride
{
    [FieldOffset(0x0000)] public FNiagaraEmitterScalabilitySettings baseObj;
    [FieldOffset(0x0038)] public byte bOverrideSpawnCountScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraEmitterScalabilityOverrides
{
    [FieldOffset(0x0000)] public TArray<FNiagaraEmitterScalabilityOverride> Overrides;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FNiagaraEventScriptProperties
{
    [FieldOffset(0x0000)] public FNiagaraEmitterScriptProperties baseObj;
    [FieldOffset(0x0028)] public EScriptExecutionMode ExecutionMode;
    [FieldOffset(0x002C)] public uint SpawnNumber;
    [FieldOffset(0x0030)] public uint MaxEventsPerFrame;
    [FieldOffset(0x0034)] public FGuid SourceEmitterID;
    [FieldOffset(0x0044)] public FName SourceEventName;
    [FieldOffset(0x004C)] public bool bRandomSpawnNumber;
    [FieldOffset(0x0050)] public uint MinSpawnNumber;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct UNiagaraEmitter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bLocalSpace;
    [FieldOffset(0x0029)] public bool bDeterminism;
    [FieldOffset(0x002C)] public int RandomSeed;
    [FieldOffset(0x0030)] public EParticleAllocationMode AllocationMode;
    [FieldOffset(0x0034)] public int PreAllocationCount;
    [FieldOffset(0x0038)] public FNiagaraEmitterScriptProperties UpdateScriptProps;
    [FieldOffset(0x0060)] public FNiagaraEmitterScriptProperties SpawnScriptProps;
    [FieldOffset(0x0088)] public ENiagaraSimTarget SimTarget;
    [FieldOffset(0x008C)] public FBox FixedBounds;
    [FieldOffset(0x00A8)] public int MinDetailLevel;
    [FieldOffset(0x00AC)] public int MaxDetailLevel;
    [FieldOffset(0x00B0)] public FNiagaraDetailsLevelScaleOverrides GlobalSpawnCountScaleOverrides;
    [FieldOffset(0x00C8)] public FNiagaraPlatformSet Platforms;
    [FieldOffset(0x00F8)] public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides;
    [FieldOffset(0x0108)] public byte bInterpolatedSpawning;
    [FieldOffset(0x0108)] public byte bFixedBounds;
    [FieldOffset(0x0108)] public byte bUseMinDetailLevel;
    [FieldOffset(0x0108)] public byte bUseMaxDetailLevel;
    [FieldOffset(0x0108)] public byte bOverrideGlobalSpawnCountScale;
    [FieldOffset(0x0108)] public byte bRequiresPersistentIDs;
    [FieldOffset(0x0108)] public byte bCombineEventSpawn;
    [FieldOffset(0x010C)] public float MaxDeltaTimePerTick;
    [FieldOffset(0x0110)] public uint DefaultShaderStageIndex;
    [FieldOffset(0x0114)] public uint MaxUpdateIterations;
    [FieldOffset(0x0118)] public TSet<uint> SpawnStages;
    [FieldOffset(0x0168)] public byte bSimulationStagesEnabled;
    [FieldOffset(0x0168)] public byte bDeprecatedShaderStagesEnabled;
    [FieldOffset(0x0168)] public byte bLimitDeltaTime;
    [FieldOffset(0x0170)] public FString UniqueEmitterName;
    [FieldOffset(0x0180)] public TArray<IntPtr> RendererProperties;
    [FieldOffset(0x0190)] public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps;
    [FieldOffset(0x01A0)] public TArray<IntPtr> SimulationStages;
    [FieldOffset(0x01B0)] public UNiagaraScript* GPUComputeScript;
    [FieldOffset(0x01B8)] public TArray<FName> SharedEventGeneratorIds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraEventReceiverEmitterAction
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UNiagaraEventReceiverEmitterAction_SpawnParticles
{
    [FieldOffset(0x0000)] public UNiagaraEventReceiverEmitterAction baseObj;
    [FieldOffset(0x0028)] public uint NumParticles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct UNiagaraLightRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraRendererProperties baseObj;
    [FieldOffset(0x0078)] public byte bUseInverseSquaredFalloff;
    [FieldOffset(0x0078)] public byte bAffectsTranslucency;
    [FieldOffset(0x0078)] public byte bAlphaScalesBrightness;
    [FieldOffset(0x007C)] public float RadiusScale;
    [FieldOffset(0x0080)] public float DefaultExponent;
    [FieldOffset(0x0084)] public FVector ColorAdd;
    [FieldOffset(0x0090)] public int RendererVisibility;
    [FieldOffset(0x0098)] public FNiagaraVariableAttributeBinding LightRenderingEnabledBinding;
    [FieldOffset(0x00F0)] public FNiagaraVariableAttributeBinding LightExponentBinding;
    [FieldOffset(0x0148)] public FNiagaraVariableAttributeBinding PositionBinding;
    [FieldOffset(0x01A0)] public FNiagaraVariableAttributeBinding ColorBinding;
    [FieldOffset(0x01F8)] public FNiagaraVariableAttributeBinding RadiusBinding;
    [FieldOffset(0x0250)] public FNiagaraVariableAttributeBinding VolumetricScatteringBinding;
    [FieldOffset(0x02A8)] public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraMeshRendererMeshProperties
{
    [FieldOffset(0x0000)] public UStaticMesh* Mesh;
    [FieldOffset(0x0008)] public FVector Scale;
    [FieldOffset(0x0014)] public FVector PivotOffset;
    [FieldOffset(0x0020)] public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraMeshMaterialOverride
{
    [FieldOffset(0x0000)] public UMaterialInterface* ExplicitMat;
    [FieldOffset(0x0008)] public FNiagaraUserParameterBinding UserParamBinding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FNiagaraMaterialAttributeBinding
{
    [FieldOffset(0x0000)] public FName MaterialParameterName;
    [FieldOffset(0x0008)] public FNiagaraVariableBase NiagaraVariable;
    [FieldOffset(0x0014)] public FNiagaraVariableBase ResolvedNiagaraVariable;
    [FieldOffset(0x0020)] public FNiagaraVariableBase NiagaraChildVariable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x898)] 
public unsafe struct UNiagaraMeshRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraRendererProperties baseObj;
    [FieldOffset(0x0078)] public TArray<FNiagaraMeshRendererMeshProperties> Meshes;
    [FieldOffset(0x0088)] public ENiagaraRendererSourceDataMode SourceMode;
    [FieldOffset(0x0089)] public ENiagaraSortMode SortMode;
    [FieldOffset(0x008C)] public byte bOverrideMaterials;
    [FieldOffset(0x008C)] public byte bSortOnlyWhenTranslucent;
    [FieldOffset(0x008C)] public byte bGpuLowLatencyTranslucency;
    [FieldOffset(0x008C)] public byte bSubImageBlend;
    [FieldOffset(0x008C)] public byte bEnableFrustumCulling;
    [FieldOffset(0x008C)] public byte bEnableCameraDistanceCulling;
    [FieldOffset(0x008C)] public byte bEnableMeshFlipbook;
    [FieldOffset(0x0090)] public TArray<FNiagaraMeshMaterialOverride> OverrideMaterials;
    [FieldOffset(0x00A0)] public FVector2D SubImageSize;
    [FieldOffset(0x00A8)] public ENiagaraMeshFacingMode FacingMode;
    [FieldOffset(0x00AC)] public byte bLockedAxisEnable;
    [FieldOffset(0x00B0)] public FVector LockedAxis;
    [FieldOffset(0x00BC)] public ENiagaraMeshLockedAxisSpace LockedAxisSpace;
    [FieldOffset(0x00C0)] public float MinCameraDistance;
    [FieldOffset(0x00C4)] public float MaxCameraDistance;
    [FieldOffset(0x00C8)] public uint RendererVisibility;
    [FieldOffset(0x00D0)] public FNiagaraVariableAttributeBinding PositionBinding;
    [FieldOffset(0x0128)] public FNiagaraVariableAttributeBinding ColorBinding;
    [FieldOffset(0x0180)] public FNiagaraVariableAttributeBinding VelocityBinding;
    [FieldOffset(0x01D8)] public FNiagaraVariableAttributeBinding MeshOrientationBinding;
    [FieldOffset(0x0230)] public FNiagaraVariableAttributeBinding ScaleBinding;
    [FieldOffset(0x0288)] public FNiagaraVariableAttributeBinding SubImageIndexBinding;
    [FieldOffset(0x02E0)] public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
    [FieldOffset(0x0338)] public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
    [FieldOffset(0x0390)] public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
    [FieldOffset(0x03E8)] public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
    [FieldOffset(0x0440)] public FNiagaraVariableAttributeBinding MaterialRandomBinding;
    [FieldOffset(0x0498)] public FNiagaraVariableAttributeBinding CustomSortingBinding;
    [FieldOffset(0x04F0)] public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
    [FieldOffset(0x0548)] public FNiagaraVariableAttributeBinding CameraOffsetBinding;
    [FieldOffset(0x05A0)] public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
    [FieldOffset(0x05F8)] public FNiagaraVariableAttributeBinding MeshIndexBinding;
    [FieldOffset(0x0650)] public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings;
    [FieldOffset(0x0660)] public FNiagaraVariableAttributeBinding PrevPositionBinding;
    [FieldOffset(0x06B8)] public FNiagaraVariableAttributeBinding PrevScaleBinding;
    [FieldOffset(0x0710)] public FNiagaraVariableAttributeBinding PrevMeshOrientationBinding;
    [FieldOffset(0x0768)] public FNiagaraVariableAttributeBinding PrevCameraOffsetBinding;
    [FieldOffset(0x07C0)] public FNiagaraVariableAttributeBinding PrevVelocityBinding;
    [FieldOffset(0x0880)] public UStaticMesh* ParticleMesh;
    [FieldOffset(0x0888)] public FVector PivotOffset;
    [FieldOffset(0x0894)] public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraMessageDataBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UNiagaraParameterCollectionInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UNiagaraParameterCollection* Collection;
    [FieldOffset(0x0030)] public TArray<FNiagaraVariable> OverridenParameters;
    [FieldOffset(0x0040)] public FNiagaraParameterStore ParameterStorage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraParameterCollection
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName Namespace;
    [FieldOffset(0x0030)] public TArray<FNiagaraVariable> Parameters;
    [FieldOffset(0x0040)] public UMaterialParameterCollection* SourceMaterialCollection;
    [FieldOffset(0x0048)] public UNiagaraParameterCollectionInstance* DefaultInstance;
    [FieldOffset(0x0050)] public FGuid CompileId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraParameterDefinitionsBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UNiagaraBaselineController
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float TestDuration;
    [FieldOffset(0x0030)] public UNiagaraEffectType* EffectType;
    [FieldOffset(0x0038)] public ANiagaraPerfBaselineActor* Owner;
    [FieldOffset(0x0040)] public TSoftObjectPtr<UNiagaraSystem> System;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UNiagaraBaselineController_Basic
{
    [FieldOffset(0x0000)] public UNiagaraBaselineController baseObj;
    [FieldOffset(0x0068)] public int NumInstances;
    [FieldOffset(0x0070)] public TArray<IntPtr> SpawnedComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ANiagaraPerfBaselineActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UNiagaraBaselineController* Controller;
    [FieldOffset(0x0228)] public UTextRenderComponent* Label;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraPrecompileContainer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Scripts;
    [FieldOffset(0x0038)] public UNiagaraSystem* System;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ANiagaraPreviewBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraPreviewAxis
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamBase
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis baseObj;
    [FieldOffset(0x0028)] public FName Param;
    [FieldOffset(0x0030)] public int Count;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamInt32
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0038)] public int Min;
    [FieldOffset(0x003C)] public int Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamFloat
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0038)] public float Min;
    [FieldOffset(0x003C)] public float Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamVector2D
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0038)] public FVector2D Min;
    [FieldOffset(0x0040)] public FVector2D Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamVector
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0038)] public FVector Min;
    [FieldOffset(0x0044)] public FVector Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamVector4
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0040)] public FVector4 Min;
    [FieldOffset(0x0050)] public FVector4 Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNiagaraPreviewAxis_InterpParamLinearColor
{
    [FieldOffset(0x0000)] public UNiagaraPreviewAxis_InterpParamBase baseObj;
    [FieldOffset(0x0038)] public FLinearColor Min;
    [FieldOffset(0x0048)] public FLinearColor Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ANiagaraPreviewGrid
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UNiagaraSystem* System;
    [FieldOffset(0x0228)] public ENiagaraPreviewGridResetMode ResetMode;
    [FieldOffset(0x0230)] public UNiagaraPreviewAxis* PreviewAxisX;
    [FieldOffset(0x0238)] public UNiagaraPreviewAxis* PreviewAxisY;
    [FieldOffset(0x0240)] public TSubclassOf<ANiagaraPreviewBase> PreviewClass;
    [FieldOffset(0x0248)] public float SpacingX;
    [FieldOffset(0x024C)] public float SpacingY;
    [FieldOffset(0x0250)] public int NumX;
    [FieldOffset(0x0254)] public int NumY;
    [FieldOffset(0x0258)] public TArray<IntPtr> PreviewComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FNiagaraRibbonUVSettings
{
    [FieldOffset(0x0000)] public ENiagaraRibbonUVDistributionMode DistributionMode;
    [FieldOffset(0x0004)] public ENiagaraRibbonUVEdgeMode LeadingEdgeMode;
    [FieldOffset(0x0008)] public ENiagaraRibbonUVEdgeMode TrailingEdgeMode;
    [FieldOffset(0x000C)] public float TilingLength;
    [FieldOffset(0x0010)] public FVector2D Offset;
    [FieldOffset(0x0018)] public FVector2D Scale;
    [FieldOffset(0x0020)] public bool bEnablePerParticleUOverride;
    [FieldOffset(0x0021)] public bool bEnablePerParticleVRangeOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FNiagaraRibbonShapeCustomVertex
{
    [FieldOffset(0x0000)] public FVector2D Position;
    [FieldOffset(0x0008)] public FVector2D Normal;
    [FieldOffset(0x0010)] public float TextureV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x860)] 
public unsafe struct UNiagaraRibbonRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraRendererProperties baseObj;
    [FieldOffset(0x0078)] public UMaterialInterface* Material;
    [FieldOffset(0x0080)] public FNiagaraUserParameterBinding MaterialUserParamBinding;
    [FieldOffset(0x00A0)] public ENiagaraRibbonFacingMode FacingMode;
    [FieldOffset(0x00A4)] public FNiagaraRibbonUVSettings UV0Settings;
    [FieldOffset(0x00C8)] public FNiagaraRibbonUVSettings UV1Settings;
    [FieldOffset(0x00EC)] public ENiagaraRibbonDrawDirection DrawDirection;
    [FieldOffset(0x00ED)] public ENiagaraRibbonShapeMode Shape;
    [FieldOffset(0x00EE)] public bool bEnableAccurateGeometry;
    [FieldOffset(0x00F0)] public int WidthSegmentationCount;
    [FieldOffset(0x00F4)] public int MultiPlaneCount;
    [FieldOffset(0x00F8)] public int TubeSubdivisions;
    [FieldOffset(0x0100)] public TArray<FNiagaraRibbonShapeCustomVertex> CustomVertices;
    [FieldOffset(0x0110)] public float CurveTension;
    [FieldOffset(0x0114)] public ENiagaraRibbonTessellationMode TessellationMode;
    [FieldOffset(0x0118)] public int TessellationFactor;
    [FieldOffset(0x011C)] public bool bUseConstantFactor;
    [FieldOffset(0x0120)] public float TessellationAngle;
    [FieldOffset(0x0124)] public bool bScreenSpaceTessellation;
    [FieldOffset(0x0128)] public FNiagaraVariableAttributeBinding PositionBinding;
    [FieldOffset(0x0180)] public FNiagaraVariableAttributeBinding ColorBinding;
    [FieldOffset(0x01D8)] public FNiagaraVariableAttributeBinding VelocityBinding;
    [FieldOffset(0x0230)] public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
    [FieldOffset(0x0288)] public FNiagaraVariableAttributeBinding RibbonTwistBinding;
    [FieldOffset(0x02E0)] public FNiagaraVariableAttributeBinding RibbonWidthBinding;
    [FieldOffset(0x0338)] public FNiagaraVariableAttributeBinding RibbonFacingBinding;
    [FieldOffset(0x0390)] public FNiagaraVariableAttributeBinding RibbonIdBinding;
    [FieldOffset(0x03E8)] public FNiagaraVariableAttributeBinding RibbonLinkOrderBinding;
    [FieldOffset(0x0440)] public FNiagaraVariableAttributeBinding MaterialRandomBinding;
    [FieldOffset(0x0498)] public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
    [FieldOffset(0x04F0)] public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
    [FieldOffset(0x0548)] public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
    [FieldOffset(0x05A0)] public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
    [FieldOffset(0x05F8)] public FNiagaraVariableAttributeBinding RibbonUVDistance;
    [FieldOffset(0x0650)] public FNiagaraVariableAttributeBinding U0OverrideBinding;
    [FieldOffset(0x06A8)] public FNiagaraVariableAttributeBinding V0RangeOverrideBinding;
    [FieldOffset(0x0700)] public FNiagaraVariableAttributeBinding U1OverrideBinding;
    [FieldOffset(0x0758)] public FNiagaraVariableAttributeBinding V1RangeOverrideBinding;
    [FieldOffset(0x07B0)] public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraScriptExecutionPaddingInfo
{
    [FieldOffset(0x0000)] public ushort SrcOffset;
    [FieldOffset(0x0002)] public ushort DestOffset;
    [FieldOffset(0x0004)] public ushort SrcSize;
    [FieldOffset(0x0006)] public ushort DestSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FNiagaraScriptExecutionParameterStore
{
    [FieldOffset(0x0000)] public FNiagaraParameterStore baseObj;
    [FieldOffset(0x0078)] public int ParameterSize;
    [FieldOffset(0x007C)] public uint PaddedParameterSize;
    [FieldOffset(0x0080)] public TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo;
    [FieldOffset(0x0090)] public byte bInitialized;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraBoundParameter
{
    [FieldOffset(0x0000)] public FNiagaraVariable Parameter;
    [FieldOffset(0x0020)] public int SrcOffset;
    [FieldOffset(0x0024)] public int DestOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FNiagaraVMExecutableDataId
{
    [FieldOffset(0x0000)] public FGuid CompilerVersionID;
    [FieldOffset(0x0010)] public ENiagaraScriptUsage ScriptUsageType;
    [FieldOffset(0x0014)] public FGuid ScriptUsageTypeID;
    [FieldOffset(0x0024)] public byte bUsesRapidIterationParams;
    [FieldOffset(0x0024)] public byte bInterpolatedSpawn;
    [FieldOffset(0x0024)] public byte bRequiresPersistentIDs;
    [FieldOffset(0x0028)] public FGuid BaseScriptID;
    [FieldOffset(0x0038)] public FNiagaraCompileHash BaseScriptCompileHash;
    [FieldOffset(0x0048)] public FGuid ScriptVersionID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraCompilerTag
{
    [FieldOffset(0x0000)] public FNiagaraVariable Variable;
    [FieldOffset(0x0020)] public FString StringValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FNiagaraScriptDataUsageInfo
{
    [FieldOffset(0x0000)] public bool bReadsAttributeData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FNiagaraScriptDataInterfaceCompileInfo
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int UserPtrIdx;
    [FieldOffset(0x0010)] public FNiagaraTypeDefinition Type;
    [FieldOffset(0x0020)] public FName RegisteredParameterMapRead;
    [FieldOffset(0x0028)] public FName RegisteredParameterMapWrite;
    [FieldOffset(0x0030)] public bool bIsPlaceholder;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVMFunctionSpecifier
{
    [FieldOffset(0x0000)] public FName Key;
    [FieldOffset(0x0008)] public FName Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FVMExternalFunctionBindingInfo
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FName OwnerName;
    [FieldOffset(0x0010)] public TArray<bool> InputParamLocations;
    [FieldOffset(0x0020)] public int NumOutputs;
    [FieldOffset(0x0028)] public TArray<FVMFunctionSpecifier> FunctionSpecifiers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraDataSetProperties
{
    [FieldOffset(0x0000)] public FNiagaraDataSetID ID;
    [FieldOffset(0x0010)] public TArray<FNiagaraVariable> Variables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraStatScope
{
    [FieldOffset(0x0000)] public FName FullName;
    [FieldOffset(0x0008)] public FName FriendlyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FNiagaraVMExecutableData
{
    [FieldOffset(0x0000)] public TArray<byte> ByteCode;
    [FieldOffset(0x0010)] public TArray<byte> OptimizedByteCode;
    [FieldOffset(0x0020)] public int NumTempRegisters;
    [FieldOffset(0x0024)] public int NumUserPtrs;
    [FieldOffset(0x0028)] public TArray<FNiagaraCompilerTag> CompileTags;
    [FieldOffset(0x0038)] public TArray<byte> ScriptLiterals;
    [FieldOffset(0x0048)] public TArray<FNiagaraVariable> Attributes;
    [FieldOffset(0x0058)] public FNiagaraScriptDataUsageInfo DataUsage;
    [FieldOffset(0x0060)] public TArray<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo;
    [FieldOffset(0x0070)] public TArray<FVMExternalFunctionBindingInfo> CalledVMExternalFunctions;
    [FieldOffset(0x0090)] public TArray<FNiagaraDataSetID> ReadDataSets;
    [FieldOffset(0x00A0)] public TArray<FNiagaraDataSetProperties> WriteDataSets;
    [FieldOffset(0x00B0)] public TArray<FNiagaraStatScope> StatScopes;
    [FieldOffset(0x00C0)] public TArray<FNiagaraDataInterfaceGPUParamInfo> DIParamInfo;
    [FieldOffset(0x00D0)] public ENiagaraScriptCompileStatus LastCompileStatus;
    [FieldOffset(0x00D8)] public TArray<FSimulationStageMetaData> SimulationStageMetaData;
    [FieldOffset(0x00E8)] public byte bReadsSignificanceIndex;
    [FieldOffset(0x00E8)] public byte bNeedsGPUContextInit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FNiagaraScriptDataInterfaceInfo
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface* DataInterface;
    [FieldOffset(0x0008)] public FName Name;
    [FieldOffset(0x0010)] public int UserPtrIdx;
    [FieldOffset(0x0018)] public FNiagaraTypeDefinition Type;
    [FieldOffset(0x0028)] public FName RegisteredParameterMapRead;
    [FieldOffset(0x0030)] public FName RegisteredParameterMapWrite;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UNiagaraScript
{
    [FieldOffset(0x0000)] public UNiagaraScriptBase baseObj;
    [FieldOffset(0x0028)] public ENiagaraScriptUsage Usage;
    [FieldOffset(0x002C)] public FGuid UsageId;
    [FieldOffset(0x0040)] public FNiagaraParameterStore RapidIterationParameters;
    [FieldOffset(0x00B8)] public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStore;
    [FieldOffset(0x0150)] public TArray<FNiagaraBoundParameter> ScriptExecutionBoundParameters;
    [FieldOffset(0x0160)] public FNiagaraVMExecutableDataId CachedScriptVMId;
    [FieldOffset(0x01C8)] public FNiagaraVMExecutableData CachedScriptVM;
    [FieldOffset(0x02B8)] public TArray<IntPtr> CachedParameterCollectionReferences;
    [FieldOffset(0x02C8)] public TArray<FNiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraScriptSourceBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UNiagaraSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FSoftObjectPath DefaultEffectType;
    [FieldOffset(0x0050)] public TArray<FText> QualityLevels;
    [FieldOffset(0x0060)] public TMap<FString, FText> ComponentRendererWarningsPerClass;
    [FieldOffset(0x00B0)] public ETextureRenderTargetFormat DefaultRenderTargetFormat;
    [FieldOffset(0x00B1)] public ENiagaraGpuBufferFormat DefaultGridFormat;
    [FieldOffset(0x00B4)] public ENiagaraDefaultRendererMotionVectorSetting DefaultRendererMotionVectorSetting;
    [FieldOffset(0x00B8)] public ENDISkelMesh_GpuMaxInfluences NDISkelMesh_GpuMaxInfluences;
    [FieldOffset(0x00B9)] public ENDISkelMesh_GpuUniformSamplingFormat NDISkelMesh_GpuUniformSamplingFormat;
    [FieldOffset(0x00BA)] public ENDISkelMesh_AdjacencyTriangleIndexFormat NDISkelMesh_AdjacencyTriangleIndexFormat;
    [FieldOffset(0x00C0)] public UNiagaraEffectType* DefaultEffectTypePtr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraSimulationStageBase
{
    [FieldOffset(0x0000)] public UNiagaraMergeable baseObj;
    [FieldOffset(0x0028)] public UNiagaraScript* Script;
    [FieldOffset(0x0030)] public FName SimulationStageName;
    [FieldOffset(0x0038)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraVariableDataInterfaceBinding
{
    [FieldOffset(0x0000)] public FNiagaraVariable BoundVariable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNiagaraSimulationStageGeneric
{
    [FieldOffset(0x0000)] public UNiagaraSimulationStageBase baseObj;
    [FieldOffset(0x0040)] public ENiagaraIterationSource IterationSource;
    [FieldOffset(0x0044)] public int Iterations;
    [FieldOffset(0x0048)] public byte bSpawnOnly;
    [FieldOffset(0x0048)] public byte bDisablePartialParticleUpdate;
    [FieldOffset(0x0050)] public FNiagaraVariableDataInterfaceBinding DataInterface;
}

[StructLayout(LayoutKind.Explicit, Size = 0xAB0)] 
public unsafe struct UNiagaraSpriteRendererProperties
{
    [FieldOffset(0x0000)] public UNiagaraRendererProperties baseObj;
    [FieldOffset(0x0078)] public UMaterialInterface* Material;
    [FieldOffset(0x0080)] public ENiagaraRendererSourceDataMode SourceMode;
    [FieldOffset(0x0088)] public FNiagaraUserParameterBinding MaterialUserParamBinding;
    [FieldOffset(0x00A8)] public ENiagaraSpriteAlignment Alignment;
    [FieldOffset(0x00A9)] public ENiagaraSpriteFacingMode FacingMode;
    [FieldOffset(0x00AC)] public FVector2D PivotInUVSpace;
    [FieldOffset(0x00B4)] public ENiagaraSortMode SortMode;
    [FieldOffset(0x00B8)] public FVector2D SubImageSize;
    [FieldOffset(0x00C0)] public byte bSubImageBlend;
    [FieldOffset(0x00C0)] public byte bRemoveHMDRollInVR;
    [FieldOffset(0x00C0)] public byte bSortOnlyWhenTranslucent;
    [FieldOffset(0x00C0)] public byte bGpuLowLatencyTranslucency;
    [FieldOffset(0x00C4)] public float MinFacingCameraBlendDistance;
    [FieldOffset(0x00C8)] public float MaxFacingCameraBlendDistance;
    [FieldOffset(0x00CC)] public byte bEnableCameraDistanceCulling;
    [FieldOffset(0x00D0)] public float MinCameraDistance;
    [FieldOffset(0x00D4)] public float MaxCameraDistance;
    [FieldOffset(0x00D8)] public uint RendererVisibility;
    [FieldOffset(0x00E0)] public FNiagaraVariableAttributeBinding PositionBinding;
    [FieldOffset(0x0138)] public FNiagaraVariableAttributeBinding ColorBinding;
    [FieldOffset(0x0190)] public FNiagaraVariableAttributeBinding VelocityBinding;
    [FieldOffset(0x01E8)] public FNiagaraVariableAttributeBinding SpriteRotationBinding;
    [FieldOffset(0x0240)] public FNiagaraVariableAttributeBinding SpriteSizeBinding;
    [FieldOffset(0x0298)] public FNiagaraVariableAttributeBinding SpriteFacingBinding;
    [FieldOffset(0x02F0)] public FNiagaraVariableAttributeBinding SpriteAlignmentBinding;
    [FieldOffset(0x0348)] public FNiagaraVariableAttributeBinding SubImageIndexBinding;
    [FieldOffset(0x03A0)] public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
    [FieldOffset(0x03F8)] public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
    [FieldOffset(0x0450)] public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
    [FieldOffset(0x04A8)] public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
    [FieldOffset(0x0500)] public FNiagaraVariableAttributeBinding CameraOffsetBinding;
    [FieldOffset(0x0558)] public FNiagaraVariableAttributeBinding UVScaleBinding;
    [FieldOffset(0x05B0)] public FNiagaraVariableAttributeBinding PivotOffsetBinding;
    [FieldOffset(0x0608)] public FNiagaraVariableAttributeBinding MaterialRandomBinding;
    [FieldOffset(0x0660)] public FNiagaraVariableAttributeBinding CustomSortingBinding;
    [FieldOffset(0x06B8)] public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
    [FieldOffset(0x0710)] public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
    [FieldOffset(0x0768)] public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings;
    [FieldOffset(0x0778)] public FNiagaraVariableAttributeBinding PrevPositionBinding;
    [FieldOffset(0x07D0)] public FNiagaraVariableAttributeBinding PrevVelocityBinding;
    [FieldOffset(0x0828)] public FNiagaraVariableAttributeBinding PrevSpriteRotationBinding;
    [FieldOffset(0x0880)] public FNiagaraVariableAttributeBinding PrevSpriteSizeBinding;
    [FieldOffset(0x08D8)] public FNiagaraVariableAttributeBinding PrevSpriteFacingBinding;
    [FieldOffset(0x0930)] public FNiagaraVariableAttributeBinding PrevSpriteAlignmentBinding;
    [FieldOffset(0x0988)] public FNiagaraVariableAttributeBinding PrevCameraOffsetBinding;
    [FieldOffset(0x09E0)] public FNiagaraVariableAttributeBinding PrevPivotOffsetBinding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FNiagaraSystemScalabilityOverride
{
    [FieldOffset(0x0000)] public FNiagaraSystemScalabilitySettings baseObj;
    [FieldOffset(0x0048)] public byte bOverrideDistanceSettings;
    [FieldOffset(0x0048)] public byte bOverrideInstanceCountSettings;
    [FieldOffset(0x0048)] public byte bOverridePerSystemInstanceCountSettings;
    [FieldOffset(0x0048)] public byte bOverrideTimeSinceRendererSettings;
    [FieldOffset(0x0048)] public byte bOverrideGlobalBudgetCullingSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraSystemScalabilityOverrides
{
    [FieldOffset(0x0000)] public TArray<FNiagaraSystemScalabilityOverride> Overrides;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraEmitterHandle
{
    [FieldOffset(0x0000)] public FGuid ID;
    [FieldOffset(0x0010)] public FName IdName;
    [FieldOffset(0x0018)] public bool bIsEnabled;
    [FieldOffset(0x001C)] public FName Name;
    [FieldOffset(0x0028)] public UNiagaraEmitter* Instance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraParameterDataSetBinding
{
    [FieldOffset(0x0000)] public int ParameterOffset;
    [FieldOffset(0x0004)] public int DataSetComponentOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraParameterDataSetBindingCollection
{
    [FieldOffset(0x0000)] public TArray<FNiagaraParameterDataSetBinding> FloatOffsets;
    [FieldOffset(0x0010)] public TArray<FNiagaraParameterDataSetBinding> Int32Offsets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x218)] 
public unsafe struct FNiagaraSystemCompiledData
{
    [FieldOffset(0x0000)] public FNiagaraParameterStore InstanceParamStore;
    [FieldOffset(0x0078)] public FNiagaraDataSetCompiledData DataSetCompiledData;
    [FieldOffset(0x00B8)] public FNiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData;
    [FieldOffset(0x00F8)] public FNiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData;
    [FieldOffset(0x0138)] public FNiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding;
    [FieldOffset(0x0158)] public FNiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding;
    [FieldOffset(0x0178)] public FNiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding;
    [FieldOffset(0x0198)] public TArray<FNiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings;
    [FieldOffset(0x01A8)] public FNiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding;
    [FieldOffset(0x01C8)] public FNiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding;
    [FieldOffset(0x01E8)] public FNiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding;
    [FieldOffset(0x0208)] public TArray<FNiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UNiagaraSystem
{
    [FieldOffset(0x0000)] public UFXSystemAsset baseObj;
    [FieldOffset(0x0030)] public bool bDumpDebugSystemInfo;
    [FieldOffset(0x0031)] public bool bDumpDebugEmitterInfo;
    [FieldOffset(0x0033)] public bool bUseSelfSoloMode;
    [FieldOffset(0x0034)] public bool bRequireCurrentFrameData;
    [FieldOffset(0x0038)] public byte bFixedBounds;
    [FieldOffset(0x0040)] public UNiagaraEffectType* EffectType;
    [FieldOffset(0x0048)] public bool bOverrideScalabilitySettings;
    [FieldOffset(0x0050)] public TArray<FNiagaraSystemScalabilityOverride> ScalabilityOverrides;
    [FieldOffset(0x0060)] public FNiagaraSystemScalabilityOverrides SystemScalabilityOverrides;
    [FieldOffset(0x0070)] public TArray<FNiagaraEmitterHandle> EmitterHandles;
    [FieldOffset(0x0080)] public TArray<IntPtr> ParameterCollectionOverrides;
    [FieldOffset(0x0090)] public UNiagaraScript* SystemSpawnScript;
    [FieldOffset(0x0098)] public UNiagaraScript* SystemUpdateScript;
    [FieldOffset(0x00B0)] public FNiagaraSystemCompiledData SystemCompiledData;
    [FieldOffset(0x02C8)] public FNiagaraUserRedirectionParameterStore ExposedParameters;
    [FieldOffset(0x0390)] public FBox FixedBounds;
    [FieldOffset(0x03AC)] public bool bAutoDeactivate;
    [FieldOffset(0x03B0)] public float WarmupTime;
    [FieldOffset(0x03B4)] public int WarmupTickCount;
    [FieldOffset(0x03B8)] public float WarmupTickDelta;
    [FieldOffset(0x03BC)] public bool bHasSystemScriptDIsWithPerInstanceData;
    [FieldOffset(0x03BD)] public bool bNeedsGPUContextInitForDataInterfaces;
    [FieldOffset(0x03C0)] public TArray<FName> UserDINamesReadInSystemScripts;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMovieSceneNiagaraParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FNiagaraVariable Parameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FMovieSceneNiagaraBoolParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneNiagaraParameterSectionTemplate baseObj;
    [FieldOffset(0x0040)] public FMovieSceneBoolChannel BoolChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct FMovieSceneNiagaraColorParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneNiagaraParameterSectionTemplate baseObj;
    [FieldOffset(0x0040)] public FMovieSceneFloatChannel RedChannel;
    [FieldOffset(0x00E0)] public FMovieSceneFloatChannel GreenChannel;
    [FieldOffset(0x0180)] public FMovieSceneFloatChannel BlueChannel;
    [FieldOffset(0x0220)] public FMovieSceneFloatChannel AlphaChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FMovieSceneNiagaraFloatParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneNiagaraParameterSectionTemplate baseObj;
    [FieldOffset(0x0040)] public FMovieSceneFloatChannel FloatChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FMovieSceneNiagaraIntegerParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneNiagaraParameterSectionTemplate baseObj;
    [FieldOffset(0x0040)] public FMovieSceneIntegerChannel IntegerChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneNiagaraSystemTrackImplementation
{
    [FieldOffset(0x0000)] public FMovieSceneTrackImplementation baseObj;
    [FieldOffset(0x0010)] public FFrameNumber SpawnSectionStartFrame;
    [FieldOffset(0x0014)] public FFrameNumber SpawnSectionEndFrame;
    [FieldOffset(0x0018)] public ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior;
    [FieldOffset(0x001C)] public ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior;
    [FieldOffset(0x0020)] public ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior;
    [FieldOffset(0x0024)] public ENiagaraAgeUpdateMode AgeUpdateMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneNiagaraSystemTrackTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct FMovieSceneNiagaraVectorParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneNiagaraParameterSectionTemplate baseObj;
    [FieldOffset(0x0040)] public FMovieSceneFloatChannel VectorChannels;
    [FieldOffset(0x02C0)] public int ChannelsUsed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraScalabilityState
{
    [FieldOffset(0x0000)] public float Significance;
    [FieldOffset(0x0004)] public byte bCulled;
    [FieldOffset(0x0004)] public byte bPreviousCulled;
    [FieldOffset(0x0004)] public byte bCulledByDistance;
    [FieldOffset(0x0004)] public byte bCulledByInstanceCount;
    [FieldOffset(0x0004)] public byte bCulledByVisibility;
    [FieldOffset(0x0004)] public byte bCulledByGlobalBudget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FNiagaraCompileDependency
{
    [FieldOffset(0x0000)] public FString LinkerErrorMessage;
    [FieldOffset(0x0010)] public FGuid NodeGuid;
    [FieldOffset(0x0020)] public FGuid PinGuid;
    [FieldOffset(0x0030)] public TArray<FGuid> StackGuids;
    [FieldOffset(0x0040)] public FNiagaraVariableBase DependentVariable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNiagaraRandInfo
{
    [FieldOffset(0x0000)] public int Seed1;
    [FieldOffset(0x0004)] public int Seed2;
    [FieldOffset(0x0008)] public int Seed3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraScriptVariableBinding
{
    [FieldOffset(0x0000)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNiagaraVariableInfo
{
    [FieldOffset(0x0000)] public FNiagaraVariable Variable;
    [FieldOffset(0x0020)] public FText Definition;
    [FieldOffset(0x0038)] public UNiagaraDataInterface* DataInterface;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FNiagaraSystemUpdateContext
{
    [FieldOffset(0x0000)] public TArray<IntPtr> ComponentsToReset;
    [FieldOffset(0x0010)] public TArray<IntPtr> ComponentsToReInit;
    [FieldOffset(0x0020)] public TArray<IntPtr> ComponentsToNotifySimDestroy;
    [FieldOffset(0x0030)] public TArray<IntPtr> SystemSimsToDestroy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FNiagaraFunctionSignature
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public TArray<FNiagaraVariable> Inputs;
    [FieldOffset(0x0018)] public TArray<FNiagaraVariable> Outputs;
    [FieldOffset(0x0028)] public FName OwnerName;
    [FieldOffset(0x0030)] public byte bRequiresContext;
    [FieldOffset(0x0030)] public byte bRequiresExecPin;
    [FieldOffset(0x0030)] public byte bMemberFunction;
    [FieldOffset(0x0030)] public byte bExperimental;
    [FieldOffset(0x0030)] public byte bSupportsCPU;
    [FieldOffset(0x0030)] public byte bSupportsGPU;
    [FieldOffset(0x0030)] public byte bWriteFunction;
    [FieldOffset(0x0030)] public byte bSoftDeprecatedFunction;
    [FieldOffset(0x0031)] public byte bIsCompileTagGenerator;
    [FieldOffset(0x0031)] public byte bHidden;
    [FieldOffset(0x0034)] public int ModuleUsageBitmask;
    [FieldOffset(0x0038)] public int ContextStageMinIndex;
    [FieldOffset(0x003C)] public int ContextStageMaxIndex;
    [FieldOffset(0x0040)] public TMap<FName, FName> FunctionSpecifiers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraEmitterNameSettingsRef
{
    [FieldOffset(0x0000)] public FName SystemName;
    [FieldOffset(0x0008)] public FString EmitterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMeshTriCoordinate
{
    [FieldOffset(0x0000)] public int Tri;
    [FieldOffset(0x0004)] public FVector BaryCoord;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNiagaraSimpleClientInfo
{
    [FieldOffset(0x0000)] public TArray<FString> Systems;
    [FieldOffset(0x0010)] public TArray<FString> Actors;
    [FieldOffset(0x0020)] public TArray<FString> Components;
    [FieldOffset(0x0030)] public TArray<FString> Emitters;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNiagaraOutlinerCaptureSettings
{
    [FieldOffset(0x0000)] public bool bTriggerCapture;
    [FieldOffset(0x0004)] public uint CaptureDelayFrames;
    [FieldOffset(0x0008)] public bool bGatherPerfData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FNiagaraRequestSimpleClientInfoMessage
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraOutlinerEmitterInstanceData
{
    [FieldOffset(0x0000)] public FString EmitterName;
    [FieldOffset(0x0010)] public ENiagaraSimTarget SimTarget;
    [FieldOffset(0x0014)] public ENiagaraExecutionState ExecState;
    [FieldOffset(0x0018)] public int NumParticles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraOutlinerTimingData
{
    [FieldOffset(0x0000)] public float GameThread;
    [FieldOffset(0x0004)] public float RenderThread;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FNiagaraOutlinerSystemInstanceData
{
    [FieldOffset(0x0000)] public FString ComponentName;
    [FieldOffset(0x0010)] public TArray<FNiagaraOutlinerEmitterInstanceData> Emitters;
    [FieldOffset(0x0020)] public ENiagaraExecutionState ActualExecutionState;
    [FieldOffset(0x0024)] public ENiagaraExecutionState RequestedExecutionState;
    [FieldOffset(0x0028)] public FNiagaraScalabilityState ScalabilityState;
    [FieldOffset(0x0030)] public byte bPendingKill;
    [FieldOffset(0x0034)] public ENCPoolMethod PoolMethod;
    [FieldOffset(0x0038)] public FNiagaraOutlinerTimingData AverageTime;
    [FieldOffset(0x0040)] public FNiagaraOutlinerTimingData MaxTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraOutlinerSystemData
{
    [FieldOffset(0x0000)] public TArray<FNiagaraOutlinerSystemInstanceData> SystemInstances;
    [FieldOffset(0x0010)] public FNiagaraOutlinerTimingData AveragePerFrameTime;
    [FieldOffset(0x0018)] public FNiagaraOutlinerTimingData MaxPerFrameTime;
    [FieldOffset(0x0020)] public FNiagaraOutlinerTimingData AveragePerInstanceTime;
    [FieldOffset(0x0028)] public FNiagaraOutlinerTimingData MaxPerInstanceTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FNiagaraOutlinerWorldData
{
    [FieldOffset(0x0000)] public TMap<FString, FNiagaraOutlinerSystemData> Systems;
    [FieldOffset(0x0050)] public bool bHasBegunPlay;
    [FieldOffset(0x0051)] public byte WorldType;
    [FieldOffset(0x0052)] public byte NetMode;
    [FieldOffset(0x0054)] public FNiagaraOutlinerTimingData AveragePerFrameTime;
    [FieldOffset(0x005C)] public FNiagaraOutlinerTimingData MaxPerFrameTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FNiagaraOutlinerData
{
    [FieldOffset(0x0000)] public TMap<FString, FNiagaraOutlinerWorldData> WorldData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FNiagaraDebuggerOutlinerUpdate
{
    [FieldOffset(0x0000)] public FNiagaraOutlinerData OutlinerData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraDebuggerExecuteConsoleCommand
{
    [FieldOffset(0x0000)] public FString Command;
    [FieldOffset(0x0010)] public bool bRequiresWorld;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraDebuggerConnectionClosed
{
    [FieldOffset(0x0000)] public FGuid SessionId;
    [FieldOffset(0x0010)] public FGuid InstanceId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraDebuggerAcceptConnection
{
    [FieldOffset(0x0000)] public FGuid SessionId;
    [FieldOffset(0x0010)] public FGuid InstanceId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNiagaraDebuggerRequestConnection
{
    [FieldOffset(0x0000)] public FGuid SessionId;
    [FieldOffset(0x0010)] public FGuid InstanceId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraGraphViewSettings
{
    [FieldOffset(0x0000)] public FVector2D Location;
    [FieldOffset(0x0008)] public float Zoom;
    [FieldOffset(0x000C)] public bool bIsValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FNiagaraCollisionEventPayload
{
    [FieldOffset(0x0000)] public FVector CollisionPos;
    [FieldOffset(0x000C)] public FVector CollisionNormal;
    [FieldOffset(0x0018)] public FVector CollisionVelocity;
    [FieldOffset(0x0024)] public int ParticleIndex;
    [FieldOffset(0x0028)] public int PhysicalMaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FParameterDefinitionsSubscription
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraParameters
{
    [FieldOffset(0x0000)] public TArray<FNiagaraVariable> Parameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNiagaraPlatformSetConflictEntry
{
    [FieldOffset(0x0000)] public FName ProfileName;
    [FieldOffset(0x0008)] public int QualityLevelMask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraPlatformSetConflictInfo
{
    [FieldOffset(0x0000)] public int SetAIndex;
    [FieldOffset(0x0004)] public int SetBIndex;
    [FieldOffset(0x0008)] public TArray<FNiagaraPlatformSetConflictEntry> Conflicts;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FNiagaraScalabilityManager
{
    [FieldOffset(0x0000)] public UNiagaraEffectType* EffectType;
    [FieldOffset(0x0008)] public TArray<IntPtr> ManagedComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FVersionedNiagaraScriptData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraModuleDependency
{
    [FieldOffset(0x0000)] public FName ID;
    [FieldOffset(0x0008)] public ENiagaraModuleDependencyType Type;
    [FieldOffset(0x0009)] public ENiagaraModuleDependencyScriptConstraint ScriptConstraint;
    [FieldOffset(0x0010)] public FText Description;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FNiagaraScriptInstanceParameterStore
{
    [FieldOffset(0x0000)] public FNiagaraParameterStore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraScriptHighlight
{
    [FieldOffset(0x0000)] public FLinearColor Color;
    [FieldOffset(0x0010)] public FText DisplayName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FNiagaraSystemCompileRequest
{
    [FieldOffset(0x0008)] public TArray<IntPtr> RootObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FEmitterCompiledScriptPair
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FNiagaraEmitterCompiledData
{
    [FieldOffset(0x0000)] public TArray<FName> SpawnAttributes;
    [FieldOffset(0x0010)] public FNiagaraVariable EmitterSpawnIntervalVar;
    [FieldOffset(0x0030)] public FNiagaraVariable EmitterInterpSpawnStartDTVar;
    [FieldOffset(0x0050)] public FNiagaraVariable EmitterSpawnGroupVar;
    [FieldOffset(0x0070)] public FNiagaraVariable EmitterAgeVar;
    [FieldOffset(0x0090)] public FNiagaraVariable EmitterRandomSeedVar;
    [FieldOffset(0x00B0)] public FNiagaraVariable EmitterInstanceSeedVar;
    [FieldOffset(0x00D0)] public FNiagaraVariable EmitterTotalSpawnedParticlesVar;
    [FieldOffset(0x00F0)] public FNiagaraDataSetCompiledData DataSetCompiledData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNiagaraInputConditionMetadata
{
    [FieldOffset(0x0000)] public FName InputName;
    [FieldOffset(0x0008)] public TArray<FString> TargetValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FNiagaraVariableMetaData
{
    [FieldOffset(0x0000)] public FText Description;
    [FieldOffset(0x0018)] public FText CategoryName;
    [FieldOffset(0x0030)] public bool bAdvancedDisplay;
    [FieldOffset(0x0034)] public int EditorSortPriority;
    [FieldOffset(0x0038)] public bool bInlineEditConditionToggle;
    [FieldOffset(0x0040)] public FNiagaraInputConditionMetadata EditCondition;
    [FieldOffset(0x0058)] public FNiagaraInputConditionMetadata VisibleCondition;
    [FieldOffset(0x0070)] public TMap<FName, FString> PropertyMetaData;
    [FieldOffset(0x00C0)] public FName ParentAttribute;
    [FieldOffset(0x00C8)] public FGuid VariableGuid;
    [FieldOffset(0x00D8)] public bool bIsStaticSwitch;
    [FieldOffset(0x00DC)] public int StaticSwitchDefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraCompileHashVisitorDebugInfo
{
    [FieldOffset(0x0000)] public FString Object;
    [FieldOffset(0x0010)] public TArray<FString> PropertyKeys;
    [FieldOffset(0x0020)] public TArray<FString> PropertyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraID
{
    [FieldOffset(0x0000)] public int Index;
    [FieldOffset(0x0004)] public int AcquireTag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraSpawnInfo
{
    [FieldOffset(0x0000)] public int Count;
    [FieldOffset(0x0004)] public float InterpStartDt;
    [FieldOffset(0x0008)] public float IntervalDt;
    [FieldOffset(0x000C)] public int SpawnGroup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FNiagaraAssetVersion
{
    [FieldOffset(0x0000)] public int MajorVersion;
    [FieldOffset(0x0004)] public int MinorVersion;
    [FieldOffset(0x0008)] public FGuid VersionGuid;
    [FieldOffset(0x0018)] public bool bIsVisibleInVersionSelector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNiagaraMatrix
{
    [FieldOffset(0x0000)] public FVector4 Row0;
    [FieldOffset(0x0010)] public FVector4 Row1;
    [FieldOffset(0x0020)] public FVector4 Row2;
    [FieldOffset(0x0030)] public FVector4 Row3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FNiagaraParameterMap
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FNiagaraNumeric
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FNiagaraHalfVector4
{
    [FieldOffset(0x0000)] public ushort X;
    [FieldOffset(0x0002)] public ushort Y;
    [FieldOffset(0x0004)] public ushort Z;
    [FieldOffset(0x0006)] public ushort W;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6)] 
public unsafe struct FNiagaraHalfVector3
{
    [FieldOffset(0x0000)] public ushort X;
    [FieldOffset(0x0002)] public ushort Y;
    [FieldOffset(0x0004)] public ushort Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNiagaraHalfVector2
{
    [FieldOffset(0x0000)] public ushort X;
    [FieldOffset(0x0002)] public ushort Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FNiagaraHalf
{
    [FieldOffset(0x0000)] public ushort Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNiagaraBool
{
    [FieldOffset(0x0000)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNiagaraInt32
{
    [FieldOffset(0x0000)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNiagaraFloat
{
    [FieldOffset(0x0000)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FNiagaraWildcard
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraVariant
{
    [FieldOffset(0x0000)] public UObject* Object;
    [FieldOffset(0x0008)] public UNiagaraDataInterface* DataInterface;
    [FieldOffset(0x0010)] public TArray<byte> Bytes;
    [FieldOffset(0x0020)] public ENiagaraVariantMode CurrentMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraWorldManagerTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

