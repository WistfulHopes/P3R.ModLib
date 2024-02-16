using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEventPtrs
{
    [FieldOffset(0x0000)] public UFunction* Function;
    [FieldOffset(0x0008)] public TFieldPath<FProperty> BoundObjectProperty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEvent
{
    [FieldOffset(0x0000)] public FMovieSceneEventPtrs Ptrs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneCameraShakeEvaluator
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieScenePropertyTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public UMovieSceneSection* SectionToKey;
    [FieldOffset(0x0098)] public FMovieScenePropertyBinding PropertyBinding;
    [FieldOffset(0x00B0)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneActorReferenceKey
{
    [FieldOffset(0x0000)] public FMovieSceneObjectBindingID Object;
    [FieldOffset(0x0018)] public FName ComponentName;
    [FieldOffset(0x0020)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FMovieSceneActorReferenceData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> KeyTimes;
    [FieldOffset(0x0018)] public FMovieSceneActorReferenceKey DefaultValue;
    [FieldOffset(0x0040)] public TArray<FMovieSceneActorReferenceKey> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FScalarParameterNameAndCurve
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneFloatChannel ParameterCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UByteChannelEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFloatChannelEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneTransformOrigin
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UIntegerChannelEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UMovieScene3DConstraintSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FGuid ConstraintId;
    [FieldOffset(0x00F8)] public FMovieSceneObjectBindingID ConstraintBindingID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UMovieScene3DAttachSection
{
    [FieldOffset(0x0000)] public UMovieScene3DConstraintSection baseObj;
    [FieldOffset(0x0118)] public FName AttachSocketName;
    [FieldOffset(0x0120)] public FName AttachComponentName;
    [FieldOffset(0x0128)] public EAttachmentRule AttachmentLocationRule;
    [FieldOffset(0x0129)] public EAttachmentRule AttachmentRotationRule;
    [FieldOffset(0x012A)] public EAttachmentRule AttachmentScaleRule;
    [FieldOffset(0x012B)] public EDetachmentRule DetachmentLocationRule;
    [FieldOffset(0x012C)] public EDetachmentRule DetachmentRotationRule;
    [FieldOffset(0x012D)] public EDetachmentRule DetachmentScaleRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieScene3DConstraintTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> ConstraintSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieScene3DAttachTrack
{
    [FieldOffset(0x0000)] public UMovieScene3DConstraintTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UMovieScene3DPathSection
{
    [FieldOffset(0x0000)] public UMovieScene3DConstraintSection baseObj;
    [FieldOffset(0x0110)] public FMovieSceneFloatChannel TimingCurve;
    [FieldOffset(0x01B0)] public MovieScene3DPathSection_Axis FrontAxisEnum;
    [FieldOffset(0x01B1)] public MovieScene3DPathSection_Axis UpAxisEnum;
    [FieldOffset(0x01B4)] public byte bFollow;
    [FieldOffset(0x01B4)] public byte bReverse;
    [FieldOffset(0x01B4)] public byte bForceUpright;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieScene3DPathTrack
{
    [FieldOffset(0x0000)] public UMovieScene3DConstraintTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieScenePropertySystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
    [FieldOffset(0x0048)] public UMovieScenePropertyInstantiatorSystem* InstantiatorSystem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieScene3DTransformPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieSceneTransformMask
{
    [FieldOffset(0x0000)] public uint Mask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x740)] 
public unsafe struct UMovieScene3DTransformSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneTransformMask TransformMask;
    [FieldOffset(0x00F8)] public FMovieSceneFloatChannel Translation;
    [FieldOffset(0x02D8)] public FMovieSceneFloatChannel Rotation;
    [FieldOffset(0x04B8)] public FMovieSceneFloatChannel Scale;
    [FieldOffset(0x0698)] public FMovieSceneFloatChannel ManualWeight;
    [FieldOffset(0x0738)] public bool bUseQuaternionInterpolation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieScene3DTransformTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct UMovieSceneActorReferenceSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneActorReferenceData ActorReferenceData;
    [FieldOffset(0x0198)] public FIntegralCurve ActorGuidIndexCurve;
    [FieldOffset(0x0218)] public TArray<FString> ActorGuidStrings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneActorReferenceTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x338)] 
public unsafe struct UMovieSceneAudioSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public USoundBase* Sound;
    [FieldOffset(0x00F0)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x00F4)] public float StartOffset;
    [FieldOffset(0x00F8)] public float AudioStartTime;
    [FieldOffset(0x00FC)] public float AudioDilationFactor;
    [FieldOffset(0x0100)] public float AudioVolume;
    [FieldOffset(0x0108)] public FMovieSceneFloatChannel SoundVolume;
    [FieldOffset(0x01A8)] public FMovieSceneFloatChannel PitchMultiplier;
    [FieldOffset(0x0248)] public FMovieSceneActorReferenceData AttachActorData;
    [FieldOffset(0x02F8)] public bool bLooping;
    [FieldOffset(0x02F9)] public bool bSuppressSubtitles;
    [FieldOffset(0x02FA)] public bool bOverrideAttenuation;
    [FieldOffset(0x0300)] public USoundAttenuation* AttenuationSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneAudioTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> AudioSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneBaseValueEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneBoolPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneBoolTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneBytePropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UMovieSceneByteSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneByteChannel ByteCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneByteTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C0)] public UEnum* Enum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneCameraAnimSectionData
{
    [FieldOffset(0x0000)] public UCameraAnim* CameraAnim;
    [FieldOffset(0x0008)] public float PlayRate;
    [FieldOffset(0x000C)] public float PlayScale;
    [FieldOffset(0x0010)] public float BlendInTime;
    [FieldOffset(0x0014)] public float BlendOutTime;
    [FieldOffset(0x0018)] public bool bLooping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UMovieSceneCameraAnimSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneCameraAnimSectionData AnimData;
    [FieldOffset(0x0108)] public UCameraAnim* CameraAnim;
    [FieldOffset(0x0110)] public float PlayRate;
    [FieldOffset(0x0114)] public float PlayScale;
    [FieldOffset(0x0118)] public float BlendInTime;
    [FieldOffset(0x011C)] public float BlendOutTime;
    [FieldOffset(0x0120)] public bool bLooping;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneCameraAnimTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> CameraAnimSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UMovieSceneCameraCutSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public bool bLockPreviousCamera;
    [FieldOffset(0x00F4)] public FGuid CameraGuid;
    [FieldOffset(0x0104)] public FMovieSceneObjectBindingID CameraBindingID;
    [FieldOffset(0x0120)] public FTransform InitialCameraCutTransform;
    [FieldOffset(0x0150)] public bool bHasInitialCameraCutTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneCameraCutTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public bool bCanBlend;
    [FieldOffset(0x0098)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UMovieSceneCameraCutTrackInstance
{
    [FieldOffset(0x0000)] public UMovieSceneTrackInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneCameraShakeSectionData
{
    [FieldOffset(0x0000)] public TSubclassOf<UCameraShakeBase> ShakeClass;
    [FieldOffset(0x0008)] public float PlayScale;
    [FieldOffset(0x000C)] public ECameraShakePlaySpace PlaySpace;
    [FieldOffset(0x0010)] public FRotator UserDefinedPlaySpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UMovieSceneCameraShakeSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneCameraShakeSectionData ShakeData;
    [FieldOffset(0x0108)] public TSubclassOf<UCameraShakeBase> ShakeClass;
    [FieldOffset(0x0110)] public float PlayScale;
    [FieldOffset(0x0114)] public ECameraShakePlaySpace PlaySpace;
    [FieldOffset(0x0118)] public FRotator UserDefinedPlaySpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UMovieSceneCameraShakeSourceShakeSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneCameraShakeSectionData ShakeData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneCameraShakeSourceShakeTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> CameraShakeSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovieSceneCameraShakeSourceTrigger
{
    [FieldOffset(0x0000)] public TSubclassOf<UCameraShakeBase> ShakeClass;
    [FieldOffset(0x0008)] public float PlayScale;
    [FieldOffset(0x000C)] public ECameraShakePlaySpace PlaySpace;
    [FieldOffset(0x0010)] public FRotator UserDefinedPlaySpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneCameraShakeSourceTriggerChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> KeyTimes;
    [FieldOffset(0x0018)] public TArray<FMovieSceneCameraShakeSourceTrigger> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneCameraShakeSourceTriggerSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneCameraShakeSourceTriggerChannel Channel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneCameraShakeSourceTriggerTrack
{
    [FieldOffset(0x0000)] public UMovieSceneTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneCameraShakeTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> CameraShakeSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UMovieSceneCinematicShotSection
{
    [FieldOffset(0x0000)] public UMovieSceneSubSection baseObj;
    [FieldOffset(0x0168)] public FString ShotDisplayName;
    [FieldOffset(0x0178)] public FText DisplayName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieSceneCinematicShotTrack
{
    [FieldOffset(0x0000)] public UMovieSceneSubTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneColorPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UMovieSceneColorSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneFloatChannel RedCurve;
    [FieldOffset(0x0190)] public FMovieSceneFloatChannel GreenCurve;
    [FieldOffset(0x0230)] public FMovieSceneFloatChannel BlueCurve;
    [FieldOffset(0x02D0)] public FMovieSceneFloatChannel AlphaCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneColorTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C0)] public bool bIsSlateColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneComponentAttachmentInvalidatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UMovieSceneComponentAttachmentSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UMovieSceneComponentMobilitySystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneComponentTransformSystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneDeferredComponentMovementSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneEnumPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UMovieSceneEnumSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneByteChannel EnumCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneEnumTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C0)] public UEnum* Enum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneEulerTransformPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneEulerTransformTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEventSectionBase
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UMovieSceneEventRepeaterSection
{
    [FieldOffset(0x0000)] public UMovieSceneEventSectionBase baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneEvent Event;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEventParameters
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEventPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public FMovieSceneEventParameters Parameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEventSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEventPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneEventSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FNameCurve Events;
    [FieldOffset(0x0160)] public FMovieSceneEventSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneEventSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePreSpawnEventSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEventSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePostSpawnEventSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEventSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePostEvalEventSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEventSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UMovieSceneEventTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x00A0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00A4)] public EFireEventsAtPosition EventPosition;
    [FieldOffset(0x00A8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEventChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> KeyTimes;
    [FieldOffset(0x0018)] public TArray<FMovieSceneEvent> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x178)] 
public unsafe struct UMovieSceneEventTriggerSection
{
    [FieldOffset(0x0000)] public UMovieSceneEventSectionBase baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneEventChannel EventChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UMovieSceneFadeSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneFloatChannel FloatCurve;
    [FieldOffset(0x0188)] public FLinearColor FadeColor;
    [FieldOffset(0x0198)] public byte bFadeAudio;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneFloatTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneFadeTrack
{
    [FieldOffset(0x0000)] public UMovieSceneFloatTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneFloatPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UMovieSceneFloatSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneFloatChannel FloatCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneHierarchicalBiasSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneInitialValueSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneIntegerPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UMovieSceneIntegerSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneIntegerChannel IntegerCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneIntegerTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneInterrogatedPropertyInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UMovieSceneLevelVisibilitySection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public ELevelVisibility Visibility;
    [FieldOffset(0x00F8)] public TArray<FName> LevelNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A8)] 
public unsafe struct UMovieSceneLevelVisibilitySystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieSceneLevelVisibilityTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMovieSceneMaterialTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMovieSceneMaterialParameterCollectionTrack
{
    [FieldOffset(0x0000)] public UMovieSceneMaterialTrack baseObj;
    [FieldOffset(0x00A8)] public UMaterialParameterCollection* MPC;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMovieSceneComponentMaterialTrack
{
    [FieldOffset(0x0000)] public UMovieSceneMaterialTrack baseObj;
    [FieldOffset(0x00A8)] public int MaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UMovieSceneMotionVectorSimulationSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A8)] 
public unsafe struct UMovieSceneObjectPropertySection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneObjectPathChannel ObjectChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMovieSceneObjectPropertyTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C8)] public UClass* PropertyClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FBoolParameterNameAndCurve
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneBoolChannel ParameterCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct FVector2DParameterNameAndCurves
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneFloatChannel XCurve;
    [FieldOffset(0x00A8)] public FMovieSceneFloatChannel YCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct FVectorParameterNameAndCurves
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneFloatChannel XCurve;
    [FieldOffset(0x00A8)] public FMovieSceneFloatChannel YCurve;
    [FieldOffset(0x0148)] public FMovieSceneFloatChannel ZCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct FColorParameterNameAndCurves
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneFloatChannel RedCurve;
    [FieldOffset(0x00A8)] public FMovieSceneFloatChannel GreenCurve;
    [FieldOffset(0x0148)] public FMovieSceneFloatChannel BlueCurve;
    [FieldOffset(0x01E8)] public FMovieSceneFloatChannel AlphaCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5A8)] 
public unsafe struct FTransformParameterNameAndCurves
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FMovieSceneFloatChannel Translation;
    [FieldOffset(0x01E8)] public FMovieSceneFloatChannel Rotation;
    [FieldOffset(0x03C8)] public FMovieSceneFloatChannel Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UMovieSceneParameterSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves;
    [FieldOffset(0x00F8)] public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves;
    [FieldOffset(0x0108)] public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves;
    [FieldOffset(0x0118)] public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves;
    [FieldOffset(0x0128)] public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves;
    [FieldOffset(0x0138)] public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneParticleParameterTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FMovieSceneParticleChannel
{
    [FieldOffset(0x0000)] public FMovieSceneByteChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UMovieSceneParticleSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneParticleChannel ParticleKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneParticleTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> ParticleSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePiecewiseBoolBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneBlenderSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePiecewiseByteBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneBlenderSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieScenePiecewiseEnumBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneBlenderSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UMovieScenePiecewiseFloatBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneBlenderSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMovieScenePiecewiseIntegerBlenderSystem
{
    [FieldOffset(0x0000)] public UMovieSceneBlenderSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A8)] 
public unsafe struct UMovieScenePrimitiveMaterialSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneObjectPathChannel MaterialChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMovieScenePrimitiveMaterialTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C8)] public int MaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct UMovieScenePropertyInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneQuaternionInterpolationRotationSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneSkeletalAnimationParams
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* Animation;
    [FieldOffset(0x0008)] public FFrameNumber FirstLoopStartFrameOffset;
    [FieldOffset(0x000C)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x0010)] public FFrameNumber EndFrameOffset;
    [FieldOffset(0x0014)] public float PlayRate;
    [FieldOffset(0x0018)] public byte bReverse;
    [FieldOffset(0x001C)] public FName SlotName;
    [FieldOffset(0x0028)] public FMovieSceneFloatChannel Weight;
    [FieldOffset(0x00C8)] public bool bSkipAnimNotifiers;
    [FieldOffset(0x00C9)] public bool bForceCustomMode;
    [FieldOffset(0x00CC)] public float StartOffset;
    [FieldOffset(0x00D0)] public float EndOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UMovieSceneSkeletalAnimationSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneSkeletalAnimationParams Params;
    [FieldOffset(0x01C0)] public UAnimSequence* AnimSequence;
    [FieldOffset(0x01C8)] public UAnimSequenceBase* Animation;
    [FieldOffset(0x01D0)] public float StartOffset;
    [FieldOffset(0x01D4)] public float EndOffset;
    [FieldOffset(0x01D8)] public float PlayRate;
    [FieldOffset(0x01DC)] public byte bReverse;
    [FieldOffset(0x01E0)] public FName SlotName;
    [FieldOffset(0x01E8)] public FVector StartLocationOffset;
    [FieldOffset(0x01F4)] public FRotator StartRotationOffset;
    [FieldOffset(0x0200)] public bool bMatchWithPrevious;
    [FieldOffset(0x0204)] public FName MatchedBoneName;
    [FieldOffset(0x020C)] public FVector MatchedLocationOffset;
    [FieldOffset(0x0218)] public FRotator MatchedRotationOffset;
    [FieldOffset(0x0224)] public bool bMatchTranslation;
    [FieldOffset(0x0225)] public bool bMatchIncludeZHeight;
    [FieldOffset(0x0226)] public bool bMatchRotationYaw;
    [FieldOffset(0x0227)] public bool bMatchRotationPitch;
    [FieldOffset(0x0228)] public bool bMatchRotationRoll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneSkeletalAnimRootMotionTrackParams
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneSkeletalAnimationTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> AnimationSections;
    [FieldOffset(0x00A8)] public bool bUseLegacySectionIndexBlend;
    [FieldOffset(0x00B0)] public FMovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams;
    [FieldOffset(0x00E0)] public bool bBlendFirstChildOfRoot;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UMovieSceneSlomoSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneFloatChannel FloatCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneSlomoTrack
{
    [FieldOffset(0x0000)] public UMovieSceneFloatTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FMovieSceneStringChannel
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FString> Values;
    [FieldOffset(0x0028)] public FString DefaultValue;
    [FieldOffset(0x0038)] public bool bHasDefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UMovieSceneStringSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneStringChannel StringCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneStringTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMovieSceneTransformOriginSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneTransformTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneVectorPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x378)] 
public unsafe struct UMovieSceneVectorSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneFloatChannel Curves;
    [FieldOffset(0x0370)] public int ChannelsUsed;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneVectorTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
    [FieldOffset(0x00C0)] public int NumChannelsUsed;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneVisibilityTrack
{
    [FieldOffset(0x0000)] public UMovieSceneBoolTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMovieSceneHierarchicalEasingInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntityInstantiatorSystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UWeightAndEasingEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FMovieScene3DPathSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneObjectBindingID PathBindingID;
    [FieldOffset(0x0038)] public FMovieSceneFloatChannel TimingCurve;
    [FieldOffset(0x00D8)] public MovieScene3DPathSection_Axis FrontAxisEnum;
    [FieldOffset(0x00D9)] public MovieScene3DPathSection_Axis UpAxisEnum;
    [FieldOffset(0x00DC)] public byte bFollow;
    [FieldOffset(0x00DC)] public byte bReverse;
    [FieldOffset(0x00DC)] public byte bForceUpright;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieScene3DTransformKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FVector Location;
    [FieldOffset(0x0014)] public FRotator Rotation;
    [FieldOffset(0x0020)] public FVector Scale;
    [FieldOffset(0x002C)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieScene3DScaleKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FVector Scale;
    [FieldOffset(0x0014)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieScene3DRotationKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FRotator Rotation;
    [FieldOffset(0x0014)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieScene3DLocationKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FVector Location;
    [FieldOffset(0x0014)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneActorReferenceSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieScenePropertySectionData PropertyData;
    [FieldOffset(0x0038)] public FMovieSceneActorReferenceData ActorReferenceData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneAudioSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public UMovieSceneAudioSection* AudioSection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneCameraAnimSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneCameraAnimSectionData SourceData;
    [FieldOffset(0x0040)] public FFrameNumber SectionStartTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneCameraShakeSourceShakeSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneCameraShakeSectionData SourceData;
    [FieldOffset(0x0040)] public FFrameNumber SectionStartTime;
    [FieldOffset(0x0044)] public FFrameNumber SectionEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMovieSceneCameraShakeSourceTriggerSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public TArray<FFrameNumber> TriggerTimes;
    [FieldOffset(0x0030)] public TArray<FMovieSceneCameraShakeSourceTrigger> TriggerValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneCameraShakeSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneCameraShakeSectionData SourceData;
    [FieldOffset(0x0040)] public FFrameNumber SectionStartTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneColorKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FLinearColor Color;
    [FieldOffset(0x0018)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct FMovieSceneColorSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieScenePropertySectionTemplate baseObj;
    [FieldOffset(0x0038)] public FMovieSceneFloatChannel Curves;
    [FieldOffset(0x02B8)] public EMovieSceneBlendType BlendType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMovieSceneEventPayloadVariable
{
    [FieldOffset(0x0000)] public FString Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneEventTriggerData
{
    [FieldOffset(0x0000)] public FMovieSceneEventPtrs Ptrs;
    [FieldOffset(0x0028)] public FGuid ObjectBindingId;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FMovieSceneEventSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEventSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneFadeSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneFloatChannel FadeCurve;
    [FieldOffset(0x00C0)] public FLinearColor FadeColor;
    [FieldOffset(0x00D0)] public byte bFadeAudio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FMovieSceneParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public TArray<FScalarParameterNameAndCurve> Scalars;
    [FieldOffset(0x0030)] public TArray<FBoolParameterNameAndCurve> Bools;
    [FieldOffset(0x0040)] public TArray<FVector2DParameterNameAndCurves> Vector2Ds;
    [FieldOffset(0x0050)] public TArray<FVectorParameterNameAndCurves> Vectors;
    [FieldOffset(0x0060)] public TArray<FColorParameterNameAndCurves> Colors;
    [FieldOffset(0x0070)] public TArray<FTransformParameterNameAndCurves> Transforms;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneMaterialParameterCollectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneParameterSectionTemplate baseObj;
    [FieldOffset(0x0080)] public UMaterialParameterCollection* MPC;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FMovieSceneObjectPropertyTemplate
{
    [FieldOffset(0x0000)] public FMovieScenePropertySectionTemplate baseObj;
    [FieldOffset(0x0038)] public FMovieSceneObjectPathChannel ObjectChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneComponentMaterialSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneParameterSectionTemplate baseObj;
    [FieldOffset(0x0080)] public int MaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FMovieSceneParticleParameterSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneParameterSectionTemplate baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FMovieSceneParticleSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneParticleChannel ParticleKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieScenePrimitiveMaterialTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public int MaterialIndex;
    [FieldOffset(0x0028)] public FMovieSceneObjectPathChannel MaterialChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneStringPropertySectionTemplate
{
    [FieldOffset(0x0000)] public FMovieScenePropertySectionTemplate baseObj;
    [FieldOffset(0x0038)] public FMovieSceneStringChannel StringCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FMovieSceneBoolPropertySectionTemplate
{
    [FieldOffset(0x0000)] public FMovieScenePropertySectionTemplate baseObj;
    [FieldOffset(0x0038)] public FMovieSceneBoolChannel BoolCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FMovieSceneSkeletalAnimationSectionTemplateParameters
{
    [FieldOffset(0x0000)] public FMovieSceneSkeletalAnimationParams baseObj;
    [FieldOffset(0x00D8)] public FFrameNumber SectionStartTime;
    [FieldOffset(0x00DC)] public FFrameNumber SectionEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct FMovieSceneSkeletalAnimationSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneSkeletalAnimationSectionTemplateParameters Params;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FMovieSceneSlomoSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneFloatChannel SlomoCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FLevelVisibilityComponentData
{
    [FieldOffset(0x0000)] public UMovieSceneLevelVisibilitySection* Section;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneVectorKeyStructBase
{
    [FieldOffset(0x0000)] public FMovieSceneKeyStruct baseObj;
    [FieldOffset(0x0008)] public FFrameNumber Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMovieSceneVector4KeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneVectorKeyStructBase baseObj;
    [FieldOffset(0x0030)] public FVector4 Vector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMovieSceneVectorKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneVectorKeyStructBase baseObj;
    [FieldOffset(0x0028)] public FVector Vector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneVector2DKeyStruct
{
    [FieldOffset(0x0000)] public FMovieSceneVectorKeyStructBase baseObj;
    [FieldOffset(0x0028)] public FVector2D Vector;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FMovieSceneVisibilitySectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneBoolPropertySectionTemplate baseObj;
}

