using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMovieSceneSignedObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FGuid Signature;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneTrackEvalOptions
{
    [FieldOffset(0x0000)] public byte bCanEvaluateNearestSection;
    [FieldOffset(0x0000)] public byte bEvalNearestSection;
    [FieldOffset(0x0000)] public byte bEvaluateInPreroll;
    [FieldOffset(0x0000)] public byte bEvaluateInPostroll;
    [FieldOffset(0x0000)] public byte bEvaluateNearestSection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneTrackEvaluationFieldEntry
{
    [FieldOffset(0x0000)] public UMovieSceneSection* Section;
    [FieldOffset(0x0008)] public FFrameNumberRange Range;
    [FieldOffset(0x0018)] public FFrameNumber ForcedTime;
    [FieldOffset(0x001C)] public ESectionEvaluationFlags flags;
    [FieldOffset(0x001E)] public short LegacySortOrder;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackEvaluationField
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneTrackEvaluationFieldEntry> Entries;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneTrack
{
    [FieldOffset(0x0000)] public UMovieSceneSignedObject baseObj;
    [FieldOffset(0x0050)] public FMovieSceneTrackEvalOptions EvalOptions;
    [FieldOffset(0x0055)] public bool bIsEvalDisabled;
    [FieldOffset(0x0058)] public TArray<int> RowsDisabled;
    [FieldOffset(0x006C)] public FGuid EvaluationFieldGuid;
    [FieldOffset(0x0080)] public FMovieSceneTrackEvaluationField EvaluationField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneNameableTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FMovieSceneSectionEvalOptions
{
    [FieldOffset(0x0000)] public bool bCanEditCompletionMode;
    [FieldOffset(0x0001)] public EMovieSceneCompletionMode CompletionMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneEasingSettings
{
    [FieldOffset(0x0000)] public int AutoEaseInDuration;
    [FieldOffset(0x0004)] public int AutoEaseOutDuration;
    [FieldOffset(0x0008)] public TScriptInterface<IMovieSceneEasingFunction> EaseIn;
    [FieldOffset(0x0018)] public bool bManualEaseIn;
    [FieldOffset(0x001C)] public int ManualEaseInDuration;
    [FieldOffset(0x0020)] public TScriptInterface<IMovieSceneEasingFunction> EaseOut;
    [FieldOffset(0x0030)] public bool bManualEaseOut;
    [FieldOffset(0x0034)] public int ManualEaseOutDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneFrameRange
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FOptionalMovieSceneBlendType
{
    [FieldOffset(0x0000)] public EMovieSceneBlendType BlendType;
    [FieldOffset(0x0001)] public bool bIsValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneSection
{
    [FieldOffset(0x0000)] public UMovieSceneSignedObject baseObj;
    [FieldOffset(0x0050)] public FMovieSceneSectionEvalOptions EvalOptions;
    [FieldOffset(0x0058)] public FMovieSceneEasingSettings Easing;
    [FieldOffset(0x0090)] public FMovieSceneFrameRange SectionRange;
    [FieldOffset(0x00A0)] public FFrameNumber PreRollFrames;
    [FieldOffset(0x00A4)] public FFrameNumber PostRollFrames;
    [FieldOffset(0x00A8)] public int RowIndex;
    [FieldOffset(0x00AC)] public int OverlapPriority;
    [FieldOffset(0x00B0)] public byte bIsActive;
    [FieldOffset(0x00B0)] public byte bIsLocked;
    [FieldOffset(0x00B4)] public float StartTime;
    [FieldOffset(0x00B8)] public float EndTime;
    [FieldOffset(0x00BC)] public float PrerollTime;
    [FieldOffset(0x00C0)] public float PostrollTime;
    [FieldOffset(0x00C4)] public byte bIsInfinite;
    [FieldOffset(0x00C8)] public bool bSupportsInfiniteRange;
    [FieldOffset(0x00C9)] public FOptionalMovieSceneBlendType BlendType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneObjectBindingID
{
    [FieldOffset(0x0000)] public FGuid Guid;
    [FieldOffset(0x0010)] public int SequenceID;
    [FieldOffset(0x0014)] public int ResolveParentIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneMarkedFrame
{
    [FieldOffset(0x0000)] public FFrameNumber FrameNumber;
    [FieldOffset(0x0008)] public FString Label;
    [FieldOffset(0x0018)] public bool bIsDeterminismFence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneSequence
{
    [FieldOffset(0x0000)] public UMovieSceneSignedObject baseObj;
    [FieldOffset(0x0050)] public UMovieSceneCompiledData* CompiledData;
    [FieldOffset(0x0058)] public EMovieSceneCompletionMode DefaultCompletionMode;
    [FieldOffset(0x0059)] public bool bParentContextsAreSignificant;
    [FieldOffset(0x005A)] public bool bPlayableDirectly;
    [FieldOffset(0x005B)] public EMovieSceneSequenceFlags SequenceFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneSequenceID
{
    [FieldOffset(0x0000)] public uint Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneRootEvaluationTemplateInstance
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence;
    [FieldOffset(0x0008)] public UMovieSceneCompiledDataManager* CompiledDataManager;
    [FieldOffset(0x0018)] public UMovieSceneEntitySystemLinker* EntitySystemLinker;
    [FieldOffset(0x0090)] public TMap<FMovieSceneSequenceID, IntPtr> DirectorInstances;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneSequenceLoopCount
{
    [FieldOffset(0x0000)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMovieSceneSequencePlaybackSettings
{
    [FieldOffset(0x0000)] public byte bAutoPlay;
    [FieldOffset(0x0004)] public FMovieSceneSequenceLoopCount LoopCount;
    [FieldOffset(0x0008)] public float PlayRate;
    [FieldOffset(0x000C)] public float StartTime;
    [FieldOffset(0x0010)] public byte bRandomStartTime;
    [FieldOffset(0x0010)] public byte bRestoreState;
    [FieldOffset(0x0010)] public byte bDisableMovementInput;
    [FieldOffset(0x0010)] public byte bDisableLookAtInput;
    [FieldOffset(0x0010)] public byte bHidePlayer;
    [FieldOffset(0x0010)] public byte bHideHud;
    [FieldOffset(0x0010)] public byte bDisableCameraCuts;
    [FieldOffset(0x0010)] public byte bPauseAtEnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneSequenceReplProperties
{
    [FieldOffset(0x0000)] public FFrameTime LastKnownPosition;
    [FieldOffset(0x0008)] public EMovieScenePlayerStatus LastKnownStatus;
    [FieldOffset(0x000C)] public int LastKnownNumLoops;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneSequencePlaybackParams
{
    [FieldOffset(0x0000)] public FFrameTime Frame;
    [FieldOffset(0x0008)] public float Time;
    [FieldOffset(0x0010)] public FString MarkedFrame;
    [FieldOffset(0x0020)] public EMovieScenePositionType PositionType;
    [FieldOffset(0x0021)] public EUpdatePositionMethod UpdateMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E8)] 
public unsafe struct UMovieSceneSequencePlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x02B0)] public EMovieScenePlayerStatus Status;
    [FieldOffset(0x02B4)] public byte bReversePlayback;
    [FieldOffset(0x02B8)] public UMovieSceneSequence* Sequence;
    [FieldOffset(0x02C0)] public FFrameNumber StartTime;
    [FieldOffset(0x02C4)] public int DurationFrames;
    [FieldOffset(0x02C8)] public float DurationSubFrames;
    [FieldOffset(0x02CC)] public int CurrentNumLoops;
    [FieldOffset(0x02D0)] public FMovieSceneSequencePlaybackSettings PlaybackSettings;
    [FieldOffset(0x02E8)] public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
    [FieldOffset(0x0438)] public FMovieSceneSequenceReplProperties NetSyncProps;
    [FieldOffset(0x0448)] public TScriptInterface<IMovieScenePlaybackClient> PlaybackClient;
    [FieldOffset(0x0458)] public UMovieSceneSequenceTickManager* TickManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FMovieSceneSectionParameters
{
    [FieldOffset(0x0000)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x0004)] public bool bCanLoop;
    [FieldOffset(0x0008)] public FFrameNumber EndFrameOffset;
    [FieldOffset(0x000C)] public FFrameNumber FirstLoopStartFrameOffset;
    [FieldOffset(0x0010)] public float TimeScale;
    [FieldOffset(0x0014)] public int HierarchicalBias;
    [FieldOffset(0x0018)] public float StartOffset;
    [FieldOffset(0x001C)] public float PrerollTime;
    [FieldOffset(0x0020)] public float PostrollTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UMovieSceneSubSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneSectionParameters Parameters;
    [FieldOffset(0x010C)] public float StartOffset;
    [FieldOffset(0x0110)] public float TimeScale;
    [FieldOffset(0x0114)] public float PrerollTime;
    [FieldOffset(0x0118)] public byte NetworkMask;
    [FieldOffset(0x0120)] public UMovieSceneSequence* SubSequence;
    [FieldOffset(0x0128)] public TLazyObjectPtr<AActor> ActorToRecord;
    [FieldOffset(0x0148)] public FString TargetSequenceName;
    [FieldOffset(0x0158)] public FDirectoryPath TargetPathToRecordTo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMovieScenePropertyBinding
{
    [FieldOffset(0x0000)] public FName PropertyName;
    [FieldOffset(0x0008)] public FName PropertyPath;
    [FieldOffset(0x0010)] public bool bCanUseClassLookup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneChannel
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMovieSceneTangentData
{
    [FieldOffset(0x0000)] public float ArriveTangent;
    [FieldOffset(0x0004)] public float LeaveTangent;
    [FieldOffset(0x0008)] public float ArriveTangentWeight;
    [FieldOffset(0x000C)] public float LeaveTangentWeight;
    [FieldOffset(0x0010)] public ERichCurveTangentWeightMode TangentWeightMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FMovieSceneFloatValue
{
    [FieldOffset(0x0000)] public float Value;
    [FieldOffset(0x0004)] public FMovieSceneTangentData Tangent;
    [FieldOffset(0x0018)] public ERichCurveInterpMode InterpMode;
    [FieldOffset(0x0019)] public ERichCurveTangentMode TangentMode;
    [FieldOffset(0x001A)] public byte PaddingByte;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FMovieSceneKeyHandleMap
{
    [FieldOffset(0x0000)] public FKeyHandleLookupTable baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FMovieSceneFloatChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public ERichCurveExtrapolation PreInfinityExtrap;
    [FieldOffset(0x0009)] public ERichCurveExtrapolation PostInfinityExtrap;
    [FieldOffset(0x0010)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0020)] public TArray<FMovieSceneFloatValue> Values;
    [FieldOffset(0x0030)] public float DefaultValue;
    [FieldOffset(0x0034)] public bool bHasDefaultValue;
    [FieldOffset(0x0038)] public FMovieSceneKeyHandleMap KeyHandles;
    [FieldOffset(0x0098)] public FFrameRate TickResolution;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneEntitySystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UMovieSceneEntitySystemLinker* Linker;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieSceneSubTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneCustomClockSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneDeterminismSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneEntityProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneEvaluationHook
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieScenePlaybackClient
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneTrackTemplateProducer
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INodeAndChannelMappings
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneNodeGroup
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneNodeGroupCollection
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FMovieSceneSpawnable
{
    [FieldOffset(0x0000)] public FTransform SpawnTransform;
    [FieldOffset(0x0030)] public TArray<FName> Tags;
    [FieldOffset(0x0040)] public bool bContinuouslyRespawn;
    [FieldOffset(0x0041)] public bool bNetAddressableName;
    [FieldOffset(0x0042)] public bool bEvaluateTracksWhenNotSpawned;
    [FieldOffset(0x0044)] public FGuid Guid;
    [FieldOffset(0x0058)] public FString Name;
    [FieldOffset(0x0068)] public UObject* ObjectTemplate;
    [FieldOffset(0x0070)] public TArray<FGuid> ChildPossessables;
    [FieldOffset(0x0080)] public ESpawnOwnership Ownership;
    [FieldOffset(0x0084)] public FName LevelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieScenePossessable
{
    [FieldOffset(0x0000)] public TArray<FName> Tags;
    [FieldOffset(0x0010)] public FGuid Guid;
    [FieldOffset(0x0020)] public FString Name;
    [FieldOffset(0x0030)] public UClass* PossessedObjectClass;
    [FieldOffset(0x0038)] public FGuid ParentGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneBinding
{
    [FieldOffset(0x0000)] public FGuid ObjectGuid;
    [FieldOffset(0x0010)] public FString BindingName;
    [FieldOffset(0x0020)] public TArray<IntPtr> Tracks;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneObjectBindingIDs
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneObjectBindingID> IDs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UMovieScene
{
    [FieldOffset(0x0000)] public UMovieSceneSignedObject baseObj;
    [FieldOffset(0x0050)] public TArray<FMovieSceneSpawnable> Spawnables;
    [FieldOffset(0x0060)] public TArray<FMovieScenePossessable> Possessables;
    [FieldOffset(0x0070)] public TArray<FMovieSceneBinding> ObjectBindings;
    [FieldOffset(0x0080)] public TMap<FName, FMovieSceneObjectBindingIDs> BindingGroups;
    [FieldOffset(0x00D0)] public TArray<IntPtr> MasterTracks;
    [FieldOffset(0x00E0)] public UMovieSceneTrack* CameraCutTrack;
    [FieldOffset(0x00E8)] public FMovieSceneFrameRange SelectionRange;
    [FieldOffset(0x00F8)] public FMovieSceneFrameRange PlaybackRange;
    [FieldOffset(0x0108)] public FFrameRate TickResolution;
    [FieldOffset(0x0110)] public FFrameRate DisplayRate;
    [FieldOffset(0x0118)] public EMovieSceneEvaluationType EvaluationType;
    [FieldOffset(0x0119)] public EUpdateClockSource ClockSource;
    [FieldOffset(0x0120)] public FSoftObjectPath CustomClockSourcePath;
    [FieldOffset(0x0138)] public TArray<FMovieSceneMarkedFrame> MarkedFrames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FMovieSceneBindingOverrideData
{
    [FieldOffset(0x0000)] public FMovieSceneObjectBindingID ObjectBindingId;
    [FieldOffset(0x0018)] public TWeakObjectPtr<UObject> Object;
    [FieldOffset(0x0020)] public bool bOverridesDefault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneBindingOverrides
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FMovieSceneBindingOverrideData> BindingData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneBindingOwnerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMovieSceneBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FMovieSceneBoolChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public bool DefaultValue;
    [FieldOffset(0x0019)] public bool bHasDefaultValue;
    [FieldOffset(0x0020)] public TArray<bool> Values;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UMovieSceneBoolSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public bool DefaultValue;
    [FieldOffset(0x00F0)] public FMovieSceneBoolChannel BoolCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneEntityInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneGenericBoundObjectInstantiator
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneBoundSceneComponentInstantiator
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneSceneComponentImpersonator
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneTrackIdentifier
{
    [FieldOffset(0x0000)] public uint Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvalTemplatePtr
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneTrackImplementationPtr
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FMovieSceneEvaluationTrack
{
    [FieldOffset(0x0000)] public FGuid ObjectBindingId;
    [FieldOffset(0x0010)] public ushort EvaluationPriority;
    [FieldOffset(0x0012)] public EEvaluationMethod EvaluationMethod;
    [FieldOffset(0x0014)] public TWeakObjectPtr<UMovieSceneTrack> SourceTrack;
    [FieldOffset(0x0020)] public TArray<FMovieSceneEvalTemplatePtr> ChildTemplates;
    [FieldOffset(0x0030)] public FMovieSceneTrackImplementationPtr TrackTemplate;
    [FieldOffset(0x0068)] public FName EvaluationGroup;
    [FieldOffset(0x0070)] public byte bEvaluateInPreroll;
    [FieldOffset(0x0070)] public byte bEvaluateInPostroll;
    [FieldOffset(0x0070)] public byte bTearDownPriority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneEvaluationTemplateSerialNumber
{
    [FieldOffset(0x0000)] public uint Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FMovieSceneTemplateGenerationLedger
{
    [FieldOffset(0x0000)] public FMovieSceneTrackIdentifier LastTrackIdentifier;
    [FieldOffset(0x0008)] public TMap<FGuid, FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier;
    [FieldOffset(0x0058)] public TMap<FGuid, FMovieSceneFrameRange> SubSectionRanges;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct FMovieSceneEvaluationTemplate
{
    [FieldOffset(0x0000)] public TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> Tracks;
    [FieldOffset(0x00A0)] public FGuid SequenceSignature;
    [FieldOffset(0x00B0)] public FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber;
    [FieldOffset(0x00B8)] public FMovieSceneTemplateGenerationLedger TemplateLedger;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneSequenceHierarchyNode
{
    [FieldOffset(0x0000)] public FMovieSceneSequenceID ParentID;
    [FieldOffset(0x0008)] public TArray<FMovieSceneSequenceID> Children;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FMovieSceneSubSequenceTree
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FMovieSceneTimeTransform
{
    [FieldOffset(0x0000)] public float TimeScale;
    [FieldOffset(0x0004)] public FFrameTime Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneTimeWarping
{
    [FieldOffset(0x0000)] public FFrameNumber Start;
    [FieldOffset(0x0004)] public FFrameNumber End;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMovieSceneNestedSequenceTransform
{
    [FieldOffset(0x0000)] public FMovieSceneTimeTransform LinearTransform;
    [FieldOffset(0x000C)] public FMovieSceneTimeWarping Warping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneSequenceTransform
{
    [FieldOffset(0x0000)] public FMovieSceneTimeTransform LinearTransform;
    [FieldOffset(0x0010)] public TArray<FMovieSceneNestedSequenceTransform> NestedTransforms;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneSequenceInstanceDataPtr
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FMovieSceneSubSequenceData
{
    [FieldOffset(0x0000)] public FSoftObjectPath Sequence;
    [FieldOffset(0x0018)] public FMovieSceneSequenceTransform OuterToInnerTransform;
    [FieldOffset(0x0038)] public FMovieSceneSequenceTransform RootToSequenceTransform;
    [FieldOffset(0x0058)] public FFrameRate TickResolution;
    [FieldOffset(0x0060)] public FMovieSceneSequenceID DeterministicSequenceID;
    [FieldOffset(0x0064)] public FMovieSceneFrameRange ParentPlayRange;
    [FieldOffset(0x0074)] public FFrameNumber ParentStartFrameOffset;
    [FieldOffset(0x0078)] public FFrameNumber ParentEndFrameOffset;
    [FieldOffset(0x007C)] public FFrameNumber ParentFirstLoopStartFrameOffset;
    [FieldOffset(0x0080)] public bool bCanLoop;
    [FieldOffset(0x0084)] public FMovieSceneFrameRange PlayRange;
    [FieldOffset(0x0094)] public FMovieSceneFrameRange FullPlayRange;
    [FieldOffset(0x00A4)] public FMovieSceneFrameRange UnwarpedPlayRange;
    [FieldOffset(0x00B4)] public FMovieSceneFrameRange PreRollRange;
    [FieldOffset(0x00C4)] public FMovieSceneFrameRange PostRollRange;
    [FieldOffset(0x00D4)] public short HierarchicalBias;
    [FieldOffset(0x00D6)] public bool bHasHierarchicalEasing;
    [FieldOffset(0x00D8)] public FMovieSceneSequenceInstanceDataPtr InstanceData;
    [FieldOffset(0x00F8)] public FGuid SubSectionSignature;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FMovieSceneSequenceHierarchy
{
    [FieldOffset(0x0000)] public FMovieSceneSequenceHierarchyNode RootNode;
    [FieldOffset(0x0018)] public FMovieSceneSubSequenceTree Tree;
    [FieldOffset(0x0078)] public TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> SubSequences;
    [FieldOffset(0x00C8)] public TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> Hierarchy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FMovieSceneEvaluationFieldEntityTree
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FMovieSceneEvaluationFieldEntityKey
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UObject> EntityOwner;
    [FieldOffset(0x0008)] public uint EntityID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneEvaluationFieldEntity
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationFieldEntityKey Key;
    [FieldOffset(0x000C)] public int SharedMetaDataIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneEvaluationFieldEntityMetaData
{
    [FieldOffset(0x0000)] public FString OverrideBoundPropertyPath;
    [FieldOffset(0x0010)] public FFrameNumber ForcedTime;
    [FieldOffset(0x0018)] public ESectionEvaluationFlags flags;
    [FieldOffset(0x0019)] public byte bEvaluateInSequencePreRoll;
    [FieldOffset(0x0019)] public byte bEvaluateInSequencePostRoll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneEvaluationFieldSharedEntityMetaData
{
    [FieldOffset(0x0000)] public FGuid ObjectBindingId;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FMovieSceneEntityComponentField
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationFieldEntityTree PersistentEntityTree;
    [FieldOffset(0x0060)] public FMovieSceneEvaluationFieldEntityTree OneShotEntityTree;
    [FieldOffset(0x00C0)] public TArray<FMovieSceneEvaluationFieldEntity> Entities;
    [FieldOffset(0x00D0)] public TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData;
    [FieldOffset(0x00E0)] public TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneEvaluationGroupLUTIndex
{
    [FieldOffset(0x0000)] public int NumInitPtrs;
    [FieldOffset(0x0004)] public int NumEvalPtrs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneEvaluationFieldTrackPtr
{
    [FieldOffset(0x0000)] public FMovieSceneSequenceID SequenceID;
    [FieldOffset(0x0004)] public FMovieSceneTrackIdentifier TrackIdentifier;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FMovieSceneFieldEntry_EvaluationTrack
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationFieldTrackPtr TrackPtr;
    [FieldOffset(0x0008)] public ushort NumChildren;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneFieldEntry_ChildTemplate
{
    [FieldOffset(0x0000)] public ushort ChildIndex;
    [FieldOffset(0x0002)] public ESectionEvaluationFlags flags;
    [FieldOffset(0x0004)] public FFrameNumber ForcedTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneEvaluationGroup
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices;
    [FieldOffset(0x0010)] public TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT;
    [FieldOffset(0x0020)] public TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FMovieSceneEvaluationKey
{
    [FieldOffset(0x0000)] public FMovieSceneSequenceID SequenceID;
    [FieldOffset(0x0004)] public FMovieSceneTrackIdentifier TrackIdentifier;
    [FieldOffset(0x0008)] public uint SectionIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneOrderedEvaluationKey
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationKey Key;
    [FieldOffset(0x000C)] public ushort SetupIndex;
    [FieldOffset(0x000E)] public ushort TearDownIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneEvaluationMetaData
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneSequenceID> ActiveSequences;
    [FieldOffset(0x0010)] public TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneEvaluationField
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneFrameRange> Ranges;
    [FieldOffset(0x0010)] public TArray<FMovieSceneEvaluationGroup> Groups;
    [FieldOffset(0x0020)] public TArray<FMovieSceneEvaluationMetaData> MetaData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMovieSceneSequenceCompilerMaskStruct
{
    [FieldOffset(0x0000)] public byte bHierarchy;
    [FieldOffset(0x0000)] public byte bEvaluationTemplate;
    [FieldOffset(0x0000)] public byte bEvaluationTemplateField;
    [FieldOffset(0x0000)] public byte bEntityComponentField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F8)] 
public unsafe struct UMovieSceneCompiledData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FMovieSceneEvaluationTemplate EvaluationTemplate;
    [FieldOffset(0x0188)] public FMovieSceneSequenceHierarchy Hierarchy;
    [FieldOffset(0x02A0)] public FMovieSceneEntityComponentField EntityComponentField;
    [FieldOffset(0x0390)] public FMovieSceneEvaluationField TrackTemplateField;
    [FieldOffset(0x03C0)] public TArray<FFrameTime> DeterminismFences;
    [FieldOffset(0x03D0)] public FGuid CompiledSignature;
    [FieldOffset(0x03E0)] public FGuid CompilerVersion;
    [FieldOffset(0x03F0)] public FMovieSceneSequenceCompilerMaskStruct AccumulatedMask;
    [FieldOffset(0x03F1)] public FMovieSceneSequenceCompilerMaskStruct AllocatedMask;
    [FieldOffset(0x03F2)] public EMovieSceneSequenceFlags AccumulatedFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UMovieSceneCompiledDataManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x00D8)] public TMap<int, FMovieSceneSequenceHierarchy> Hierarchies;
    [FieldOffset(0x0128)] public TMap<int, FMovieSceneEvaluationTemplate> TrackTemplates;
    [FieldOffset(0x0178)] public TMap<int, FMovieSceneEvaluationField> TrackTemplateFields;
    [FieldOffset(0x01C8)] public TMap<int, FMovieSceneEntityComponentField> EntityComponentFields;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneFloatDecomposer
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UMovieSceneBuiltInEasingFunction
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public EMovieSceneBuiltInEasing Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UMovieSceneEasingExternalCurve
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UCurveFloat* Curve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneEasingFunction
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneEntitySystemGraphNodes
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct FMovieSceneEntitySystemGraph
{
    [FieldOffset(0x0080)] public FMovieSceneEntitySystemGraphNodes Nodes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4F0)] 
public unsafe struct UMovieSceneEntitySystemLinker
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0298)] public FMovieSceneEntitySystemGraph SystemGraph;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMovieSceneEvalTimeSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneEvaluationInstanceKey
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneEvaluationHookComponent
{
    [FieldOffset(0x0000)] public TScriptInterface<IMovieSceneEvaluationHook> Interface;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneEvaluationHookEvent
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationHookComponent Hook;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneEvaluationHookEventContainer
{
    [FieldOffset(0x0000)] public TArray<FMovieSceneEvaluationHookEvent> Events;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneEvaluationHookSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
    [FieldOffset(0x0040)] public TMap<FMovieSceneEvaluationInstanceKey, FMovieSceneEvaluationHookEventContainer> PendingEventsByRootInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMovieSceneFolder
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName FolderName;
    [FieldOffset(0x0030)] public TArray<IntPtr> ChildFolders;
    [FieldOffset(0x0040)] public TArray<IntPtr> ChildMasterTracks;
    [FieldOffset(0x0050)] public TArray<FString> ChildObjectBindingStrings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UMovieSceneHookSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F8)] public byte bRequiresRangedHook;
    [FieldOffset(0x00F8)] public byte bRequiresTriggerHooks;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneKeyProxy
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneMasterInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieScenePreAnimatedStateSystemInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneCachePreAnimatedStateSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMovieSceneRestorePreAnimatedStateSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneSequenceActor
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneSequenceActorPointers
{
    [FieldOffset(0x0000)] public AActor* SequenceActor;
    [FieldOffset(0x0008)] public TScriptInterface<IMovieSceneSequenceActor> SequenceActorInterface;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMovieSceneSequenceTickManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FMovieSceneSequenceActorPointers> SequenceActors;
    [FieldOffset(0x0038)] public UMovieSceneEntitySystemLinker* Linker;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneSpawnablesSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UMovieSceneSpawnSection
{
    [FieldOffset(0x0000)] public UMovieSceneBoolSection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMovieSceneSpawnTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> Sections;
    [FieldOffset(0x00A0)] public FGuid ObjectGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UTestMovieSceneTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
    [FieldOffset(0x0098)] public bool bHighPassFilter;
    [FieldOffset(0x00A0)] public TArray<IntPtr> SectionArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UTestMovieSceneSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UTestMovieSceneSequence
{
    [FieldOffset(0x0000)] public UMovieSceneSequence baseObj;
    [FieldOffset(0x0060)] public UMovieScene* MovieScene;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UTestMovieSceneSubTrack
{
    [FieldOffset(0x0000)] public UMovieSceneSubTrack baseObj;
    [FieldOffset(0x00A0)] public TArray<IntPtr> SectionArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UTestMovieSceneSubSection
{
    [FieldOffset(0x0000)] public UMovieSceneSubSection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UTestMovieSceneEvalHookTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> SectionArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UTestMovieSceneEvalHookSection
{
    [FieldOffset(0x0000)] public UMovieSceneHookSection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackInstanceInput
{
    [FieldOffset(0x0000)] public UMovieSceneSection* Section;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMovieSceneTrackInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UObject* AnimatedObject;
    [FieldOffset(0x0030)] public bool bIsMasterTrackInstance;
    [FieldOffset(0x0038)] public UMovieSceneEntitySystemLinker* Linker;
    [FieldOffset(0x0040)] public TArray<FMovieSceneTrackInstanceInput> Inputs;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UMovieSceneTrackInstanceInstantiator
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMovieSceneTrackInstanceSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
    [FieldOffset(0x0040)] public UMovieSceneTrackInstanceInstantiator* Instantiator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FMovieSceneByteChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public byte DefaultValue;
    [FieldOffset(0x0019)] public bool bHasDefaultValue;
    [FieldOffset(0x0020)] public TArray<byte> Values;
    [FieldOffset(0x0030)] public UEnum* Enum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FMovieSceneIntegerChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public int DefaultValue;
    [FieldOffset(0x001C)] public bool bHasDefaultValue;
    [FieldOffset(0x0020)] public TArray<int> Values;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneObjectPathChannelKeyValue
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<UObject> SoftPtr;
    [FieldOffset(0x0028)] public UObject* HardPtr;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FMovieSceneObjectPathChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public UClass* PropertyClass;
    [FieldOffset(0x0010)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0020)] public TArray<FMovieSceneObjectPathChannelKeyValue> Values;
    [FieldOffset(0x0030)] public FMovieSceneObjectPathChannelKeyValue DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneEvalTemplateBase
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneEvalTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplateBase baseObj;
    [FieldOffset(0x0010)] public EMovieSceneCompletionMode CompletionMode;
    [FieldOffset(0x0014)] public TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackImplementation
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieScenePropertySectionData
{
    [FieldOffset(0x0000)] public FName PropertyName;
    [FieldOffset(0x0008)] public FString PropertyPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieScenePropertySectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieScenePropertySectionData PropertyData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTrackInstanceInputComponent
{
    [FieldOffset(0x0000)] public UMovieSceneSection* Section;
    [FieldOffset(0x0008)] public int OutputIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackInstanceComponent
{
    [FieldOffset(0x0000)] public UMovieSceneSection* Owner;
    [FieldOffset(0x0008)] public TSubclassOf<UMovieSceneTrackInstance> TrackInstanceClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FEasingComponentData
{
    [FieldOffset(0x0000)] public UMovieSceneSection* Section;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneDeterminismData
{
    [FieldOffset(0x0000)] public TArray<FFrameTime> Fences;
    [FieldOffset(0x0010)] public bool bParentSequenceRequiresLowerFence;
    [FieldOffset(0x0011)] public bool bParentSequenceRequiresUpperFence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneSectionGroup
{
    [FieldOffset(0x0000)] public TArray<TWeakObjectPtr<UMovieSceneSection>> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackLabels
{
    [FieldOffset(0x0000)] public TArray<FString> Strings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMovieSceneExpansionState
{
    [FieldOffset(0x0000)] public bool bExpanded;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FMovieSceneEditorData
{
    [FieldOffset(0x0000)] public TMap<FString, FMovieSceneExpansionState> ExpansionStates;
    [FieldOffset(0x0050)] public TArray<FString> PinnedNodes;
    [FieldOffset(0x0060)] public double ViewStart;
    [FieldOffset(0x0068)] public double ViewEnd;
    [FieldOffset(0x0070)] public double WorkStart;
    [FieldOffset(0x0078)] public double WorkEnd;
    [FieldOffset(0x0080)] public TSet<FFrameNumber> MarkedFrames;
    [FieldOffset(0x00D0)] public FFloatRange WorkingRange;
    [FieldOffset(0x00E0)] public FFloatRange ViewRange;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneTimecodeSource
{
    [FieldOffset(0x0000)] public FTimecode Timecode;
    [FieldOffset(0x0014)] public FFrameNumber DeltaFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMovieSceneCompiledSequenceFlagStruct
{
    [FieldOffset(0x0000)] public byte bParentSequenceRequiresLowerFence;
    [FieldOffset(0x0000)] public byte bParentSequenceRequiresUpperFence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEntitySystemGraphNode
{
    [FieldOffset(0x0020)] public UMovieSceneEntitySystem* System;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMovieSceneEmptyStruct
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneSegmentIdentifier
{
    [FieldOffset(0x0000)] public int IdentifierIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FMovieSceneEvaluationFieldSegmentPtr
{
    [FieldOffset(0x0000)] public FMovieSceneEvaluationFieldTrackPtr baseObj;
    [FieldOffset(0x0008)] public FMovieSceneSegmentIdentifier SegmentID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMovieSceneEvaluationOperand
{
    [FieldOffset(0x0000)] public FGuid ObjectBindingId;
    [FieldOffset(0x0010)] public FMovieSceneSequenceID SequenceID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FMovieSceneSubSectionData
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UMovieSceneSubSection> Section;
    [FieldOffset(0x0008)] public FGuid ObjectBindingId;
    [FieldOffset(0x0018)] public ESectionEvaluationFlags flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneKeyStruct
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneKeyTimeStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FGeneratedMovieSceneKeyStruct
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FMovieSceneSegment
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSectionEvaluationData
{
    [FieldOffset(0x0000)] public int ImplIndex;
    [FieldOffset(0x0004)] public FFrameNumber ForcedTime;
    [FieldOffset(0x0008)] public ESectionEvaluationFlags flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneSubSequenceTreeEntry
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneSequenceInstanceData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneWarpCounter
{
    [FieldOffset(0x0000)] public TArray<uint> WarpCounts;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FTestMovieSceneEvalTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneTrackDisplayOptions
{
    [FieldOffset(0x0000)] public byte bShowVerticalFrames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneTrackInstanceEntry
{
    [FieldOffset(0x0000)] public UObject* BoundObject;
    [FieldOffset(0x0008)] public UMovieSceneTrackInstance* TrackInstance;
}

