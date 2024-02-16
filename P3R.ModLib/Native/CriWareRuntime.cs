using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAtom3dRegionHandle
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAtom3dRegion
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UAtom3dRegionHandle* Handle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UAtom3dSourceBaseComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float DefaultOutputVolumeScale;
    [FieldOffset(0x0200)] public UAtom3dRegion* DefaultRegion;
    [FieldOffset(0x0208)] public byte bIsAttenuationDistanceDebugSpheresVisible;
    [FieldOffset(0x020C)] public float DefaultMinAttenuationDistance;
    [FieldOffset(0x0210)] public float DefaultMaxAttenuationDistance;
    [FieldOffset(0x0214)] public byte bIsOutputInteriorPanFieldDebugSpheresVisible;
    [FieldOffset(0x0218)] public float DefaultSourceRadius;
    [FieldOffset(0x021C)] public float DefaultInteriorDistance;
    [FieldOffset(0x0220)] public TArray<FString> DefaultDistanceAisacControls;
    [FieldOffset(0x0230)] public TArray<FString> DefaultOutputBasedAzimuthAngleAisacControls;
    [FieldOffset(0x0240)] public TArray<FString> DefaultOutputBasedElevationAngleAisacControls;
    [FieldOffset(0x0250)] public TArray<FString> DefaultListenerBasedAzimuthAngleAisacControls;
    [FieldOffset(0x0260)] public TArray<FString> DefaultListenerBasedElevationAngleAisacControls;
    [FieldOffset(0x0270)] public byte bIsDebugStringsForDetailsVisible;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UAtom3dTransceiverComponent
{
    [FieldOffset(0x0000)] public UAtom3dSourceBaseComponent baseObj;
    [FieldOffset(0x0290)] public AActor* InputPoint;
    [FieldOffset(0x0298)] public TArray<FString> DefaultGlobalAisacs;
    [FieldOffset(0x02A8)] public byte bIsInputCrossfadeFieldDebugSpheresVisible;
    [FieldOffset(0x02AC)] public float DefaultDirectAudioRadius;
    [FieldOffset(0x02B0)] public float DefaultCrossfadeDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AAtomAreaSoundVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public float Priority;
    [FieldOffset(0x025C)] public byte bEnabled;
    [FieldOffset(0x0260)] public FName CollisionProfile;
    [FieldOffset(0x0268)] public float SoundStopDistance;
    [FieldOffset(0x026C)] public bool bIsEnableAtomCompoentPack;
    [FieldOffset(0x026F)] public bool bIsAutoPlaySound;
    [FieldOffset(0x0270)] public bool bIsDeterminationFromVolumeBoundaryPlane;
    [FieldOffset(0x0278)] public TArray<IntPtr> AtomComponents;
    [FieldOffset(0x0288)] public TArray<IntPtr> Sounds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAtomAsrRack
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int RackId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AAtomEntranceVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public float Priority;
    [FieldOffset(0x025C)] public byte bEnabled;
    [FieldOffset(0x0268)] public TArray<TWeakObjectPtr<AAtomAudioVolume>> NeighbourhoodAudioVolumeArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSnapshotSwitchSettings
{
    [FieldOffset(0x0000)] public int ASRRackID;
    [FieldOffset(0x0004)] public int DspBusSettingsID;
    [FieldOffset(0x0008)] public FString DspBusSettingsName;
    [FieldOffset(0x0018)] public int SnapshotID;
    [FieldOffset(0x0020)] public FString SnapshotName;
    [FieldOffset(0x0030)] public float FadeTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FBusSendInterpolationSettings
{
    [FieldOffset(0x0000)] public int DspBusSettingsID;
    [FieldOffset(0x0008)] public FString DspBusSettingsName;
    [FieldOffset(0x0018)] public int BusId;
    [FieldOffset(0x0020)] public FString BusName;
    [FieldOffset(0x0030)] public float BusSendLevelForInside;
    [FieldOffset(0x0034)] public float BusSendLevelForOutside;
    [FieldOffset(0x0038)] public float Width;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAisacControlInterpolationSettings
{
    [FieldOffset(0x0000)] public int AisacControlID;
    [FieldOffset(0x0008)] public FString AisacControlName;
    [FieldOffset(0x0018)] public float AisacControlValueForInside;
    [FieldOffset(0x001C)] public float AisacControlValueForOutside;
    [FieldOffset(0x0020)] public float Width;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAtomAudioVolumeParameters
{
    [FieldOffset(0x0000)] public bool bUseSnapshotSettings;
    [FieldOffset(0x0001)] public bool bUseBusSendSettings;
    [FieldOffset(0x0002)] public bool bUseAisacControlSettings;
    [FieldOffset(0x0004)] public float MaxDistanceForEntranceVolume;
    [FieldOffset(0x0008)] public bool bSwitchIntepolationInsideForBus;
    [FieldOffset(0x0009)] public bool bSwitchIntepolationInsideForAisac;
    [FieldOffset(0x0010)] public TArray<FSnapshotSwitchSettings> SnapshotSwitchSettings;
    [FieldOffset(0x0020)] public TArray<FBusSendInterpolationSettings> BusSendInterpolateSettings;
    [FieldOffset(0x0030)] public TArray<FAisacControlInterpolationSettings> AisacControlInterpolateSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct AAtomAudioVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public float Priority;
    [FieldOffset(0x025C)] public byte bEnabled;
    [FieldOffset(0x0260)] public FName CollisionProfile;
    [FieldOffset(0x0268)] public bool bAutoSettingEntranceVolume;
    [FieldOffset(0x0269)] public bool bAutoSettingNeighbourAudioVolumeToEntranceVolume;
    [FieldOffset(0x0270)] public TArray<FName> AudioVolumeTags;
    [FieldOffset(0x0280)] public bool bOverrideAtomAudioVolume;
    [FieldOffset(0x0288)] public UAtomAudioVolumeSettings* AtomAudioVolumeSettings;
    [FieldOffset(0x0290)] public FAtomAudioVolumeParameters AtomAudioVolumeSettingsOverrides;
    [FieldOffset(0x02D0)] public TArray<IntPtr> EntranceVolumes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAtomAudioVolumeSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FAtomAudioVolumeParameters AtomAudioVolumeParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAtomBusSampler
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAtomCallback
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAtomSequenceInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAtomBeatSyncInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAtomCallbackManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtomAisacInfo
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public bool DefaultControlFlag;
    [FieldOffset(0x0014)] public float DefaultControlValue;
    [FieldOffset(0x0018)] public int ControlId;
    [FieldOffset(0x0020)] public FString ControlName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtomCategory
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomAisacControlParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtomSelectorParam
{
    [FieldOffset(0x0000)] public FString Selector;
    [FieldOffset(0x0010)] public FString Label;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10A0)] 
public unsafe struct UAtomComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x0200)] public USoundAtomCue* Sound;
    [FieldOffset(0x0208)] public UAtom3dRegion* Region;
    [FieldOffset(0x0210)] public byte bAutoDestroy;
    [FieldOffset(0x0210)] public byte bPersistAcrossLevelTransition;
    [FieldOffset(0x0210)] public byte bStopWhenOwnerDestroyed;
    [FieldOffset(0x0210)] public byte bIsUISound;
    [FieldOffset(0x0214)] public float DefaultVolume;
    [FieldOffset(0x0218)] public byte bEnableMultipleSoundPlayback;
    [FieldOffset(0x0218)] public byte bUsePlaylist;
    [FieldOffset(0x0219)] public bool bIsMovable;
    [FieldOffset(0x021A)] public bool bCanStraddleAudioVolume;
    [FieldOffset(0x021B)] public bool bUseAudioVolume;
    [FieldOffset(0x021C)] public bool bUseAreaSoundVolume;
    [FieldOffset(0x0220)] public UAtomSoundObject* SoundObject;
    [FieldOffset(0x0228)] public int DefaultBlockIndex;
    [FieldOffset(0x0230)] public TArray<FAtomAisacControlParam> DefaultAisacControl;
    [FieldOffset(0x0240)] public TArray<FAtomSelectorParam> DefaultSelectorLabel;
    [FieldOffset(0x0250)] public EAtomLoopSetting LoopSetting;
    [FieldOffset(0x0251)] public byte bOnly2DSound;
    [FieldOffset(0x0288)] public UWorld* PlayWorld;
    [FieldOffset(0x0290)] public UGameViewportClient* GameViewport;
    [FieldOffset(0x02B0)] public UAtomSoundObject* DefaultSoundObject;
    [FieldOffset(0x02B8)] public byte bOverrideAttenuation;
    [FieldOffset(0x02C0)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x02C8)] public FSoundAttenuationSettings AttenuationOverrides;
    [FieldOffset(0x1038)] public USoundAtomCueSheet* CueSheet;
    [FieldOffset(0x1050)] public UAtomSoundObject* AppliedSoundObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAtomComponentPool
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Pool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UAtomCueSheetLoaderComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FSoftObjectPath CueSheetReference;
    [FieldOffset(0x0210)] public UCriFsBinderComponent* BinderComponent;
    [FieldOffset(0x0268)] public USoundAtomCueSheet* CueSheet;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAtomDeviceWatcher
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AAtomDisposer
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct UAtomListenerFocusPoint
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float DistanceFocusLevel;
    [FieldOffset(0x01FC)] public float DirectionFocusLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UAtomParameterComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UAtomSoundObject* SoundObject;
    [FieldOffset(0x00B8)] public UAtom3dRegion* Region;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FAtomProfileItem
{
    [FieldOffset(0x0000)] public int AtomComponentID;
    [FieldOffset(0x0008)] public FString AtomCueName;
    [FieldOffset(0x0018)] public FVector AtomComponentLocation;
    [FieldOffset(0x0024)] public float DistanceFromListener;
    [FieldOffset(0x0028)] public float PlayingTime;
    [FieldOffset(0x0030)] public FString PlayerState;
    [FieldOffset(0x0040)] public int NumSounds;
    [FieldOffset(0x0048)] public FString ConcurrencyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtomProfileData
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AAtomSound
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UAtomComponent* AtomComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AAtomSoundData
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USoundAtomCueSheet* CueSheet;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAtomSoundObject
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public bool EnableVoiceLimitScope;
    [FieldOffset(0x0031)] public bool EnableCategoryCueLimitScope;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtomSpectrumAnalyzer
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FAtomComponentParams
{
    [FieldOffset(0x0000)] public float DefaultVolume;
    [FieldOffset(0x0004)] public float DefaultPitchMultiplier;
    [FieldOffset(0x0008)] public float StartTime;
    [FieldOffset(0x000C)] public byte bEnableMultipleSoundPlayback;
    [FieldOffset(0x000C)] public byte bUsePlaylist;
    [FieldOffset(0x000D)] public bool bIsMovable;
    [FieldOffset(0x000E)] public bool bCanStraddleAudioVolume;
    [FieldOffset(0x000F)] public bool bUseAudioVolume;
    [FieldOffset(0x0010)] public bool bUseAreaSoundVolume;
    [FieldOffset(0x0018)] public UAtomSoundObject* SoundObject;
    [FieldOffset(0x0020)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0028)] public int DefaultBlockIndex;
    [FieldOffset(0x0030)] public TArray<FAtomAisacControlParam> DefaultAisacControl;
    [FieldOffset(0x0040)] public TArray<FAtomSelectorParam> DefaultSelectorLabel;
    [FieldOffset(0x0050)] public EAtomLoopSetting LoopSetting;
    [FieldOffset(0x0054)] public FRotator Rotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomListenerFocusPointInfo
{
    [FieldOffset(0x0000)] public AActor* TargetActor;
    [FieldOffset(0x0008)] public USceneComponent* TargetComponent;
    [FieldOffset(0x0010)] public float DistanceLevel;
    [FieldOffset(0x0014)] public float DirectionLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtomStatics
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtomTriggerRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float Time;
    [FieldOffset(0x000C)] public FName Bone;
    [FieldOffset(0x0018)] public USoundAtomCue* Cue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtomTriggerTableFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8410)] 
public unsafe struct UAtomUnrealSoundRenderer
{
    [FieldOffset(0x0000)] public USoundWaveProcedural baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FAtomWaveInfo
{
    [FieldOffset(0x0000)] public EAtomFormat Format;
    [FieldOffset(0x0004)] public int SamplingRate;
    [FieldOffset(0x0008)] public int NumChannels;
    [FieldOffset(0x000C)] public int NumSamples;
    [FieldOffset(0x0010)] public byte bIsStreamed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UAtomWavePlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public byte bIsUISound;
    [FieldOffset(0x0090)] public USoundAtomCue* SoundAtomCue;
    [FieldOffset(0x0098)] public FAtomWaveInfo WaveInfo;
    [FieldOffset(0x00AC)] public byte bLoop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UCriFsBinderComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FString FilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ACriFsLoader
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UCriFsLoaderComponent* LoaderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UCriFsLoaderComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FString FilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCriWareErrorInfo
{
    [FieldOffset(0x0000)] public FString ErrorID;
    [FieldOffset(0x0010)] public ECriWareErrorType ErrorType;
    [FieldOffset(0x0018)] public FString Message;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UCriWareError
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCriWareFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCriWareInitializer
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtomAsrRackConfigUI
{
    [FieldOffset(0x0000)] public EAtomSoundRendererType SoundRendererTypeUI;
    [FieldOffset(0x0004)] public int ElementID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtomAsrRackConfig
{
    [FieldOffset(0x0000)] public int SoundRendererType;
    [FieldOffset(0x0004)] public int ElementID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct UCriWarePluginSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bNoExistCriWareIni;
    [FieldOffset(0x0029)] public bool bEditableCriWareAdxLipSyncSetting;
    [FieldOffset(0x0030)] public FDirectoryPath NonAssetContentDir;
    [FieldOffset(0x0040)] public FString ContentDir;
    [FieldOffset(0x0060)] public int NumBinders;
    [FieldOffset(0x0068)] public int MaxBinds;
    [FieldOffset(0x0070)] public int NumLoaders;
    [FieldOffset(0x0078)] public int MaxPath;
    [FieldOffset(0x0080)] public bool OutputsLogFileSystem;
    [FieldOffset(0x0084)] public int PS4_FileAccessThreadAffinityMask;
    [FieldOffset(0x008C)] public int PS4_DataDecompressionThreadAffinityMask;
    [FieldOffset(0x0094)] public int PS4_MemoryFileSystemThreadAffinityMask;
    [FieldOffset(0x009C)] public int PS4_FileAccessThreadPriority;
    [FieldOffset(0x00A4)] public int PS4_DataDecompressionThreadPriority;
    [FieldOffset(0x00AC)] public int PS4_MemoryFileSystemThreadPriority;
    [FieldOffset(0x00B4)] public bool AutomaticallyCreateCueAsset;
    [FieldOffset(0x00B5)] public bool UsesInGamePreview;
    [FieldOffset(0x00B7)] public bool OutputsLogAtom;
    [FieldOffset(0x00C0)] public FDirectoryPath AwbRootDirectory;
    [FieldOffset(0x00D0)] public FString AwbRoot;
    [FieldOffset(0x00F0)] public int MonitorCommunicationBufferSize;
    [FieldOffset(0x00F8)] public int MaxPitch;
    [FieldOffset(0x0100)] public int AsrOutputChannels;
    [FieldOffset(0x0108)] public int MaxVirtualVoices;
    [FieldOffset(0x0110)] public int NumStandardMemoryVoices;
    [FieldOffset(0x0118)] public int StandardMemoryVoiceNumChannels;
    [FieldOffset(0x0120)] public int StandardMemoryVoiceSamplingRate;
    [FieldOffset(0x0128)] public int NumStandardStreamingVoices;
    [FieldOffset(0x0130)] public int StandardStreamingVoiceNumChannels;
    [FieldOffset(0x0138)] public int StandardStreamingVoiceSamplingRate;
    [FieldOffset(0x0140)] public bool PoolAtomComponent;
    [FieldOffset(0x0148)] public FSoftObjectPath AtomConfig;
    [FieldOffset(0x0178)] public FString AcfFileName;
    [FieldOffset(0x0188)] public FSoftObjectPath AtomConfigDataTable;
    [FieldOffset(0x01B8)] public float DistanceFactor;
    [FieldOffset(0x01C0)] public EAtomSoundRendererType SoundRendererTypeUI;
    [FieldOffset(0x01C4)] public int SoundRendererType;
    [FieldOffset(0x01D0)] public TArray<FAtomAsrRackConfigUI> AsrRackConfigUI;
    [FieldOffset(0x01E0)] public TArray<FAtomAsrRackConfig> AsrRackConfig;
    [FieldOffset(0x0200)] public FString Hardware1;
    [FieldOffset(0x0210)] public FString Hardware2;
    [FieldOffset(0x0220)] public FString Hardware3;
    [FieldOffset(0x0230)] public FString Hardware4;
    [FieldOffset(0x0240)] public float EconomicTickMarginDistance;
    [FieldOffset(0x0248)] public int EconomicTickFrequency;
    [FieldOffset(0x0250)] public float CullingMarginDistance;
    [FieldOffset(0x0258)] public int HcaMxVoiceSamplingRate;
    [FieldOffset(0x0260)] public int NumHcaMxMemoryVoices;
    [FieldOffset(0x0268)] public int HcaMxMemoryVoiceNumChannels;
    [FieldOffset(0x0270)] public int NumHcaMxStreamingVoices;
    [FieldOffset(0x0278)] public int HcaMxStreamingVoiceNumChannels;
    [FieldOffset(0x0280)] public bool WASAPI_IsExclusive;
    [FieldOffset(0x0284)] public int WASAPI_BitsPerSample;
    [FieldOffset(0x028C)] public int WASAPI_SamplingRate;
    [FieldOffset(0x0294)] public int WASAPI_NumChannels;
    [FieldOffset(0x029C)] public bool UseUnrealSoundRenderer;
    [FieldOffset(0x029E)] public bool SmartPhone_UseSonicSYNC;
    [FieldOffset(0x02A0)] public int PS4_ServerThreadAffinityMask;
    [FieldOffset(0x02A8)] public int PS4_OutputThreadAffinityMask;
    [FieldOffset(0x02B0)] public int PS4_ServerThreadPriority;
    [FieldOffset(0x02B8)] public int PS4_OutputThreadPriority;
    [FieldOffset(0x02C0)] public bool PS4_UseAudio3d;
    [FieldOffset(0x02C4)] public int PS4_NumberOfAudio3dMemoryVoices;
    [FieldOffset(0x02CC)] public int PS4_SamplingRateOfAudio3dMemoryVoices;
    [FieldOffset(0x02D4)] public int PS4_NumberOfAudio3dStreamingVoices;
    [FieldOffset(0x02DC)] public int PS4_SamplingRateOfAudio3dStreamingVoices;
    [FieldOffset(0x02E4)] public int Switch_NumOpusMemoryVoices;
    [FieldOffset(0x02EC)] public int Switch_OpusMemoryVoiceNumChannels;
    [FieldOffset(0x02F4)] public int Switch_OpusMemoryVoiceSamplingRate;
    [FieldOffset(0x02FC)] public int Switch_NumOpusStreamingVoices;
    [FieldOffset(0x0304)] public int Switch_OpusStreamingVoiceNumChannels;
    [FieldOffset(0x030C)] public int Switch_OpusStreamingVoiceSamplingRate;
    [FieldOffset(0x0314)] public bool InitializeMana;
    [FieldOffset(0x0316)] public bool EnableDecodeSkip;
    [FieldOffset(0x0318)] public int MaxDecoderHandles;
    [FieldOffset(0x0320)] public int MaxManaBPS;
    [FieldOffset(0x0328)] public int MaxManaStreams;
    [FieldOffset(0x0330)] public bool UseH264Decoder;
    [FieldOffset(0x0332)] public bool InitializeAdxLipSync;
    [FieldOffset(0x0334)] public int MaxNumAnalyzerHandles;
    [FieldOffset(0x033C)] public bool bUseManaStartupMovies;
    [FieldOffset(0x033D)] public bool bWaitForMoviesToComplete;
    [FieldOffset(0x033E)] public bool bMoviesAreSkippable;
    [FieldOffset(0x0340)] public TArray<FString> StartupMovies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FManaEventPointInfo
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public float Time;
    [FieldOffset(0x0014)] public int Type;
    [FieldOffset(0x0018)] public FString Parameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UManaComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UManaTexture* Movie;
    [FieldOffset(0x0188)] public UManaPlaylist* Playlist;
    [FieldOffset(0x0190)] public int PlaylistIndex;
    [FieldOffset(0x0198)] public bool bLoop;
    [FieldOffset(0x019C)] public int AlphaTrack;
    [FieldOffset(0x01A0)] public int AudioTrack;
    [FieldOffset(0x01A4)] public int SubAudioTrack;
    [FieldOffset(0x01A8)] public int ExtraAudioTrack;
    [FieldOffset(0x01B0)] public FString AudioCategoryName;
    [FieldOffset(0x01C0)] public FString SubAudioCategoryName;
    [FieldOffset(0x01D0)] public FString ExtraAudioCategoryName;
    [FieldOffset(0x01E0)] public bool bSubtitlesEnabled;
    [FieldOffset(0x01E4)] public int SubtitlesChannel;
    [FieldOffset(0x01E8)] public EManaSubtitlesEncoding SubtitlesEncoding;
    [FieldOffset(0x01E9)] public EManaFrameAction EndFrameAction;
    [FieldOffset(0x01EA)] public EManaPlaybackTimer PlaybackTimer;
    [FieldOffset(0x01EB)] public EManaMaxFrameDrop MaxFrameDrop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UManaComponentTexture
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0178)] public int SizeX;
    [FieldOffset(0x017C)] public int SizeY;
    [FieldOffset(0x0180)] public EPixelFormat Format;
    [FieldOffset(0x0181)] public EManaComponentTextureType ComponentType;
    [FieldOffset(0x0182)] public TextureAddress AddressX;
    [FieldOffset(0x0183)] public TextureAddress AddressY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UManaSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FManaVideoTrackInfo
{
    [FieldOffset(0x0000)] public FIntPoint TextureDimensions;
    [FieldOffset(0x0008)] public FIntPoint DisplayDimensions;
    [FieldOffset(0x0010)] public float FrameRate;
    [FieldOffset(0x0014)] public int TotalFrames;
    [FieldOffset(0x0018)] public bool bIsAlpha;
    [FieldOffset(0x0019)] public EManaMovieType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FManaAudioTrackInfo
{
    [FieldOffset(0x0000)] public int NumChannels;
    [FieldOffset(0x0004)] public int SamplingRate;
    [FieldOffset(0x0008)] public int TotalSamples;
    [FieldOffset(0x000C)] public bool bIsAmbisonics;
    [FieldOffset(0x000D)] public EManaSoundType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UManaMovie
{
    [FieldOffset(0x0000)] public UManaSource baseObj;
    [FieldOffset(0x0030)] public TArray<FManaVideoTrackInfo> VideoTracks;
    [FieldOffset(0x0040)] public TArray<FManaVideoTrackInfo> AlphaTracks;
    [FieldOffset(0x0050)] public TArray<FManaAudioTrackInfo> AudioTracks;
    [FieldOffset(0x0060)] public TArray<FManaEventPointInfo> EventPoints;
    [FieldOffset(0x0070)] public int NumSubtitleChannels;
    [FieldOffset(0x0074)] public int MaxSubtitleSize;
    [FieldOffset(0x0078)] public byte bIsAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UFileManaMovie
{
    [FieldOffset(0x0000)] public UManaMovie baseObj;
    [FieldOffset(0x0088)] public bool bPrecacheFile;
    [FieldOffset(0x0090)] public FString FilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDataManaMovie
{
    [FieldOffset(0x0000)] public UManaMovie baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UStreamManaMovie
{
    [FieldOffset(0x0000)] public UManaMovie baseObj;
    [FieldOffset(0x0088)] public FString StreamUrl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FManaPlayerTrackOptions
{
    [FieldOffset(0x0000)] public int Audio;
    [FieldOffset(0x0004)] public int SubAudio;
    [FieldOffset(0x0008)] public int ExtraAudio;
    [FieldOffset(0x000C)] public int Subtitle;
    [FieldOffset(0x0010)] public int Video;
    [FieldOffset(0x0014)] public int Alpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FManaPlayerOptions
{
    [FieldOffset(0x0000)] public FManaPlayerTrackOptions Tracks;
    [FieldOffset(0x0018)] public FTimespan SeekTime;
    [FieldOffset(0x0020)] public EManaPlayerOptionBooleanOverride PlayOnOpen;
    [FieldOffset(0x0021)] public EManaPlayerOptionBooleanOverride Loop;
    [FieldOffset(0x0022)] public EManaPlaybackTimer PlaybackTimer;
    [FieldOffset(0x0023)] public EManaMaxFrameDrop MaxFrameDrop;
    [FieldOffset(0x0024)] public EManaFrameAction EndFrameAction;
    [FieldOffset(0x0028)] public UAtomComponent* TimeSyncedSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UManaPlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public bool PlayOnOpen;
    [FieldOffset(0x0034)] public byte Loop;
    [FieldOffset(0x0040)] public EManaMaxFrameDrop MaxFrameDrop;
    [FieldOffset(0x00C8)] public UManaTexture* ManaTexture;
    [FieldOffset(0x00D0)] public UManaMovie* ManaMovie;
    [FieldOffset(0x00D8)] public UManaPlaylist* Playlist;
    [FieldOffset(0x00E0)] public int PlaylistIndex;
    [FieldOffset(0x00E8)] public UManaComponent* ManaComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UManaPlaylist
{
    [FieldOffset(0x0000)] public UManaSource baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Movies;
    [FieldOffset(0x0038)] public bool bIsAlpha;
    [FieldOffset(0x0039)] public bool bIsMixedTypes;
    [FieldOffset(0x003A)] public bool bIsSeamless;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UManaTexture
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0180)] public UManaSource* MovieSource;
    [FieldOffset(0x0188)] public FString MovieFilePath;
    [FieldOffset(0x0198)] public byte bRenderToTexture;
    [FieldOffset(0x019C)] public float TargetGamma;
    [FieldOffset(0x01A0)] public byte bHDR;
    [FieldOffset(0x01A4)] public TextureAddress AddressX;
    [FieldOffset(0x01A5)] public TextureAddress AddressY;
    [FieldOffset(0x01A8)] public FLinearColor ClearColor;
    [FieldOffset(0x01B8)] public byte bOverrideDimensions;
    [FieldOffset(0x01BC)] public FIntPoint TargetDimensions;
    [FieldOffset(0x01C4)] public EPixelFormat OverrideFormat;
    [FieldOffset(0x01D8)] public TArray<IntPtr> ComponentTextures;
    [FieldOffset(0x01E8)] public TArray<IntPtr> AlphaComponentTextures;
    [FieldOffset(0x01F8)] public UManaComponent* ManaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMaterialExpressionManaColorSpaceConverter
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Luma;
    [FieldOffset(0x0054)] public FExpressionInput ChromaB;
    [FieldOffset(0x0068)] public FExpressionInput ChromaR;
    [FieldOffset(0x007C)] public FExpressionInput Alpha;
    [FieldOffset(0x0090)] public FExpressionInput Gamma;
    [FieldOffset(0x00A4)] public bool bH264;
    [FieldOffset(0x00A5)] public EManaMovieType MovieType;
    [FieldOffset(0x00A6)] public EManaColorSpace ColorSpace;
    [FieldOffset(0x00A7)] public bool bUseGammaExponent;
    [FieldOffset(0x00A8)] public float ConstGamma;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UDEPRECATED_MaterialExpressionManaMovieFormatSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Inputs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UPlatformManaMovie
{
    [FieldOffset(0x0000)] public UManaMovie baseObj;
    [FieldOffset(0x0088)] public UManaMovie* ManaMovie;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtomCategoryInfoParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public int category_id;
    [FieldOffset(0x0014)] public int group_no;
    [FieldOffset(0x0018)] public float Volume;
    [FieldOffset(0x001C)] public bool IsPaused;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USoundAtomConfig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString AcfFilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtomAttenuationDistanceParam
{
    [FieldOffset(0x0000)] public float MinDistance;
    [FieldOffset(0x0004)] public float MaxDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FAtomCueInfo
{
    [FieldOffset(0x0000)] public int ID;
    [FieldOffset(0x0004)] public bool HeaderVisibility;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FTimespan Duration;
    [FieldOffset(0x0020)] public FString UserData;
    [FieldOffset(0x0030)] public TArray<FString> CategoryNames;
    [FieldOffset(0x0040)] public TArray<FString> AisacControlNames;
    [FieldOffset(0x0050)] public FAtomAttenuationDistanceParam AttenuationDistance;
    [FieldOffset(0x0058)] public byte bLooping;
    [FieldOffset(0x0058)] public byte bIsParameterPalletAssigned;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct USoundAtomCue
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public USoundAtomCueSheet* CueSheet;
    [FieldOffset(0x0038)] public FString CueName;
    [FieldOffset(0x0048)] public EAtomLoopSetting LoopSetting;
    [FieldOffset(0x0049)] public bool bApplyAtomParameter;
    [FieldOffset(0x004C)] public float Duration;
    [FieldOffset(0x0050)] public float FirstWaveDuration;
    [FieldOffset(0x0058)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0060)] public bool bEnableAudioVolume;
    [FieldOffset(0x0061)] public bool bIsMovable;
    [FieldOffset(0x0062)] public bool bCanStraddleAudioVolume;
    [FieldOffset(0x0063)] public bool bUseDistanceToEnableAudioVolume;
    [FieldOffset(0x0064)] public float MinDistanceToEnableAudioVolume;
    [FieldOffset(0x0068)] public bool bUseAreaSoundVolume;
    [FieldOffset(0x006C)] public int UpdateRateForFrame;
    [FieldOffset(0x0070)] public UAtom3dRegion* Region;
    [FieldOffset(0x0078)] public bool bEconomicTick;
    [FieldOffset(0x0079)] public bool bOverrideEconomicTickSettings;
    [FieldOffset(0x007C)] public float EconomicTickDistanceMargin;
    [FieldOffset(0x0080)] public int EconomicTickFrequency;
    [FieldOffset(0x0084)] public bool bEnableDistanceCulling;
    [FieldOffset(0x0085)] public bool bOverrideCullSettings;
    [FieldOffset(0x0088)] public float CullDistanceMargin;
    [FieldOffset(0x008C)] public float EconomicTickMarginDistance;
    [FieldOffset(0x0090)] public bool bLoopSettingByAtomCraft;
    [FieldOffset(0x0091)] public bool bCullingSoundPlayingProcessByDistance;
    [FieldOffset(0x0092)] public bool bUseLegacyCullingSettings;
    [FieldOffset(0x0094)] public float MaxProcessDistance;
    [FieldOffset(0x0098)] public bool bOverrideCullingSettings;
    [FieldOffset(0x009C)] public float CullingMarginDistance;
    [FieldOffset(0x00A0)] public bool bLoop;
    [FieldOffset(0x00A8)] public USoundAttenuation* DefaultAttenuation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct USoundAtomCueSheet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool Contains;
    [FieldOffset(0x0030)] public FString AcbFilePath;
    [FieldOffset(0x0040)] public FString CueSheetName;
    [FieldOffset(0x0050)] public int NumSlots;
    [FieldOffset(0x0054)] public bool bOverrideAwbDirectory;
    [FieldOffset(0x0058)] public FDirectoryPath AwbDirectory;
    [FieldOffset(0x0068)] public UDataTable* AdditionalData;
    [FieldOffset(0x0070)] public TArray<FAtomCueInfo> CueInfos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtomStringWithComment
{
    [FieldOffset(0x0000)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtomSelectorSettingsParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FString DefaultSelectorLabel;
    [FieldOffset(0x0020)] public TArray<FAtomStringWithComment> Labels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomAisacControlSettingsParam
{
    [FieldOffset(0x0000)] public int ID;
    [FieldOffset(0x0008)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomGameVariableParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtomGlobalAisacSettingsParam
{
    [FieldOffset(0x0000)] public FString AisacControl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtomCategoryParam
{
    [FieldOffset(0x0000)] public int ID;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FString Group;
    [FieldOffset(0x0028)] public float Volume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtomDspBusSettingsParam
{
    [FieldOffset(0x0000)] public FString BusSettingsName;
    [FieldOffset(0x0010)] public TArray<FAtomStringWithComment> Snapshot;
    [FieldOffset(0x0020)] public TArray<FAtomStringWithComment> Bus;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FAtomConfigDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString BuildDate;
    [FieldOffset(0x0018)] public int NumCategoriesPerPlayback;
    [FieldOffset(0x001C)] public int NumCategories;
    [FieldOffset(0x0020)] public int NumAisacControls;
    [FieldOffset(0x0024)] public int NumGlobalAisacs;
    [FieldOffset(0x0028)] public int NumVoiceLimitGroups;
    [FieldOffset(0x002C)] public int NumDspBusSettings;
    [FieldOffset(0x0030)] public int NumDspBusSettingSnapshots;
    [FieldOffset(0x0034)] public int NumDspBus;
    [FieldOffset(0x0038)] public int NumGameVariables;
    [FieldOffset(0x003C)] public int NumSelectors;
    [FieldOffset(0x0040)] public int NumReacts;
    [FieldOffset(0x0048)] public TArray<FAtomSelectorSettingsParam> Selector;
    [FieldOffset(0x0058)] public TArray<FAtomAisacControlSettingsParam> AisacControl;
    [FieldOffset(0x0068)] public TArray<FAtomGameVariableParam> GameVariable;
    [FieldOffset(0x0078)] public TArray<FAtomGlobalAisacSettingsParam> GlobalAisac;
    [FieldOffset(0x0088)] public TArray<FAtomCategoryParam> Category;
    [FieldOffset(0x0098)] public TArray<FAtomDspBusSettingsParam> DspBusSettings;
    [FieldOffset(0x00A8)] public TArray<FAtomStringWithComment> React;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FAcfDataTable
{
    [FieldOffset(0x0000)] public FAtomConfigDataTable baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtomCueInfoSelectorParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FString Label;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtomCueInfoCategoryParam
{
    [FieldOffset(0x0000)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtomCueInfoTrackParam
{
    [FieldOffset(0x0000)] public float Volume;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FAtomCueInfoSelectorParam Selector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomCueInfoBusSendParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public bool Enable;
    [FieldOffset(0x0014)] public float Level;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomCueInfoBlocksParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public int StartPosition;
    [FieldOffset(0x0014)] public int Length;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtomCueInfoAttachedSelectorParam
{
    [FieldOffset(0x0000)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtomCueInfoAttachedAisacControlParam
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public int ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct FAtomCueInfoDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public int CueId;
    [FieldOffset(0x001C)] public int CueTypeIndex;
    [FieldOffset(0x0020)] public FString CueType;
    [FieldOffset(0x0030)] public FAtomCueInfoSelectorParam DefaultSelectorLabel;
    [FieldOffset(0x0050)] public float Volume;
    [FieldOffset(0x0054)] public bool Public;
    [FieldOffset(0x0058)] public int CategoryCuePriority;
    [FieldOffset(0x0060)] public FString CategoryCuePriorityType;
    [FieldOffset(0x0070)] public int CategoryCuePriorityTypeIndex;
    [FieldOffset(0x0078)] public FString CuePriorityType;
    [FieldOffset(0x0088)] public int CuePriorityTypeIndex;
    [FieldOffset(0x008C)] public bool EnableCueLimit;
    [FieldOffset(0x0090)] public int NumCueLimits;
    [FieldOffset(0x0094)] public int Probability;
    [FieldOffset(0x0098)] public int Length;
    [FieldOffset(0x00A0)] public TArray<FAtomCueInfoCategoryParam> Category;
    [FieldOffset(0x00B0)] public TArray<FAtomCueInfoTrackParam> Track;
    [FieldOffset(0x00C0)] public TArray<FAtomCueInfoBusSendParam> BusSend;
    [FieldOffset(0x00D0)] public TArray<FAtomCueInfoBlocksParam> Blocks;
    [FieldOffset(0x00E0)] public TArray<FAtomCueInfoAttachedSelectorParam> AttachedSelector;
    [FieldOffset(0x00F0)] public TArray<FAtomCueInfoAttachedAisacControlParam> AttachedAisacControl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FAtomCueSheetDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FString BuildDate;
    [FieldOffset(0x0028)] public FString WorkUnit;
    [FieldOffset(0x0038)] public float Volume;
    [FieldOffset(0x003C)] public bool EnableCueLimit;
    [FieldOffset(0x0040)] public int NumCueLimits;
    [FieldOffset(0x0048)] public FString PriorityType;
    [FieldOffset(0x0058)] public int PriorityTypeIndex;
    [FieldOffset(0x0060)] public TArray<FAtomCueInfoDataTable> Cue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FAtomSoundManager
{
}

