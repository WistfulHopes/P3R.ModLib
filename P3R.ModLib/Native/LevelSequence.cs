using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FLevelSequenceCameraSettings
{
    [FieldOffset(0x0000)] public bool bOverrideAspectRatioAxisConstraint;
    [FieldOffset(0x0001)] public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ALevelSequenceActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0238)] public FMovieSceneSequencePlaybackSettings PlaybackSettings;
    [FieldOffset(0x0250)] public ULevelSequencePlayer* SequencePlayer;
    [FieldOffset(0x0258)] public FSoftObjectPath LevelSequence;
    [FieldOffset(0x0270)] public FLevelSequenceCameraSettings CameraSettings;
    [FieldOffset(0x0278)] public ULevelSequenceBurnInOptions* BurnInOptions;
    [FieldOffset(0x0280)] public UMovieSceneBindingOverrides* BindingOverrides;
    [FieldOffset(0x0288)] public byte bAutoPlay;
    [FieldOffset(0x0288)] public byte bOverrideInstanceData;
    [FieldOffset(0x0288)] public byte bReplicatePlayback;
    [FieldOffset(0x0290)] public UObject* DefaultInstanceData;
    [FieldOffset(0x0298)] public ULevelSequenceBurnIn* BurnInInstance;
    [FieldOffset(0x02A0)] public bool bShowBurnin;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAnimSequenceLevelSequenceLink
{
    [FieldOffset(0x0000)] public UAssetUserData baseObj;
    [FieldOffset(0x0028)] public FGuid SkelTrackGuid;
    [FieldOffset(0x0038)] public FSoftObjectPath PathToLevelSequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDefaultLevelSequenceInstanceData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public AActor* TransformOriginActor;
    [FieldOffset(0x0040)] public FTransform TransformOrigin;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ILevelSequenceMetaData
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FLevelSequenceObjectReferenceMap
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FLevelSequenceBindingReference
{
    [FieldOffset(0x0000)] public FString PackageName;
    [FieldOffset(0x0010)] public FSoftObjectPath ExternalObjectPath;
    [FieldOffset(0x0028)] public FString ObjectPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLevelSequenceBindingReferenceArray
{
    [FieldOffset(0x0000)] public TArray<FLevelSequenceBindingReference> References;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FLevelSequenceBindingReferences
{
    [FieldOffset(0x0000)] public TMap<FGuid, FLevelSequenceBindingReferenceArray> BindingIdToReferences;
    [FieldOffset(0x0050)] public TSet<FGuid> AnimSequenceInstances;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FLevelSequenceObject
{
    [FieldOffset(0x0000)] public TLazyObjectPtr<UObject> ObjectOrOwner;
    [FieldOffset(0x0020)] public FString ComponentName;
    [FieldOffset(0x0030)] public TWeakObjectPtr<UObject> CachedComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C8)] 
public unsafe struct ULevelSequence
{
    [FieldOffset(0x0000)] public UMovieSceneSequence baseObj;
    [FieldOffset(0x0068)] public UMovieScene* MovieScene;
    [FieldOffset(0x0070)] public FLevelSequenceObjectReferenceMap ObjectReferences;
    [FieldOffset(0x00C0)] public FLevelSequenceBindingReferences BindingReferences;
    [FieldOffset(0x0160)] public TMap<FString, FLevelSequenceObject> PossessedObjects;
    [FieldOffset(0x01B0)] public UClass* DirectorClass;
    [FieldOffset(0x01B8)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULevelSequenceBurnInInitSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct ULevelSequenceBurnInOptions
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bUseBurnIn;
    [FieldOffset(0x0030)] public FSoftClassPath BurnInClass;
    [FieldOffset(0x0048)] public ULevelSequenceBurnInInitSettings* Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FLevelSequenceAnimSequenceLinkItem
{
    [FieldOffset(0x0000)] public FGuid SkelTrackGuid;
    [FieldOffset(0x0010)] public FSoftObjectPath PathToAnimSequence;
    [FieldOffset(0x0028)] public bool bExportTransforms;
    [FieldOffset(0x0029)] public bool bExportCurves;
    [FieldOffset(0x002A)] public bool bRecordInWorldSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULevelSequenceAnimSequenceLink
{
    [FieldOffset(0x0000)] public UAssetUserData baseObj;
    [FieldOffset(0x0028)] public TArray<FLevelSequenceAnimSequenceLinkItem> AnimSequenceLinks;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FLevelSequenceSnapshotSettings
{
    [FieldOffset(0x0000)] public byte ZeroPadAmount;
    [FieldOffset(0x0004)] public FFrameRate FrameRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FLevelSequencePlayerSnapshot
{
    [FieldOffset(0x0000)] public FString MasterName;
    [FieldOffset(0x0010)] public FQualifiedFrameTime MasterTime;
    [FieldOffset(0x0020)] public FQualifiedFrameTime SourceTime;
    [FieldOffset(0x0030)] public FString CurrentShotName;
    [FieldOffset(0x0040)] public FQualifiedFrameTime CurrentShotLocalTime;
    [FieldOffset(0x0050)] public FQualifiedFrameTime CurrentShotSourceTime;
    [FieldOffset(0x0060)] public FString SourceTimecode;
    [FieldOffset(0x0070)] public TSoftObjectPtr<UCameraComponent> CameraComponent;
    [FieldOffset(0x0098)] public FLevelSequenceSnapshotSettings Settings;
    [FieldOffset(0x00A8)] public ULevelSequence* ActiveShot;
    [FieldOffset(0x00B0)] public FMovieSceneSequenceID ShotID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x320)] 
public unsafe struct ULevelSequenceBurnIn
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
    [FieldOffset(0x0260)] public FLevelSequencePlayerSnapshot FrameInformation;
    [FieldOffset(0x0318)] public ALevelSequenceActor* LevelSequenceActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULevelSequenceDirector
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ULevelSequencePlayer* Player;
    [FieldOffset(0x0030)] public int SubSequenceID;
    [FieldOffset(0x0034)] public int MovieScenePlayerIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct ULegacyLevelSequenceDirectorBlueprint
{
    [FieldOffset(0x0000)] public UBlueprint baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x600)] 
public unsafe struct ULevelSequencePlayer
{
    [FieldOffset(0x0000)] public UMovieSceneSequencePlayer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct ULevelSequenceProjectSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public bool bDefaultLockEngineToDisplayRate;
    [FieldOffset(0x0040)] public FString DefaultDisplayRate;
    [FieldOffset(0x0050)] public FString DefaultTickResolution;
    [FieldOffset(0x0060)] public EUpdateClockSource DefaultClockSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct ALevelSequenceMediaController
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public ALevelSequenceActor* Sequence;
    [FieldOffset(0x0230)] public UMediaComponent* MediaComponent;
    [FieldOffset(0x0238)] public float ServerStartTimeSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBoundActorProxy
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLevelSequenceLegacyObjectReference
{
}

