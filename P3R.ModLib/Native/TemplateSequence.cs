using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UTemplateSequence
{
    [FieldOffset(0x0000)] public UMovieSceneSequence baseObj;
    [FieldOffset(0x0060)] public UMovieScene* MovieScene;
    [FieldOffset(0x0068)] public TSoftClassPtr<AActor> BoundActorClass;
    [FieldOffset(0x0090)] public TSoftObjectPtr<AActor> BoundPreviewActor;
    [FieldOffset(0x00B8)] public TMap<FGuid, FName> BoundActorComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UCameraAnimationSequence
{
    [FieldOffset(0x0000)] public UTemplateSequence baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x670)] 
public unsafe struct USequenceCameraShakeCameraStandIn
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public float FieldOfView;
    [FieldOffset(0x0034)] public byte bConstrainAspectRatio;
    [FieldOffset(0x0038)] public float AspectRatio;
    [FieldOffset(0x0040)] public FPostProcessSettings PostProcessSettings;
    [FieldOffset(0x05A0)] public float PostProcessBlendWeight;
    [FieldOffset(0x05A4)] public FCameraFilmbackSettings Filmback;
    [FieldOffset(0x05B0)] public FCameraLensSettings LensSettings;
    [FieldOffset(0x05C8)] public FCameraFocusSettings FocusSettings;
    [FieldOffset(0x0620)] public float CurrentFocalLength;
    [FieldOffset(0x0624)] public float CurrentAperture;
    [FieldOffset(0x0628)] public float CurrentFocusDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USequenceCameraShakePattern
{
    [FieldOffset(0x0000)] public UCameraShakePattern baseObj;
    [FieldOffset(0x0028)] public UCameraAnimationSequence* Sequence;
    [FieldOffset(0x0030)] public float PlayRate;
    [FieldOffset(0x0034)] public float Scale;
    [FieldOffset(0x0038)] public float BlendInTime;
    [FieldOffset(0x003C)] public float BlendOutTime;
    [FieldOffset(0x0040)] public float RandomSegmentDuration;
    [FieldOffset(0x0044)] public bool bRandomSegment;
    [FieldOffset(0x0048)] public USequenceCameraShakeSequencePlayer* Player;
    [FieldOffset(0x0050)] public USequenceCameraShakeCameraStandIn* CameraStandIn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct USequenceCameraShakeSequencePlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x02D0)] public UObject* BoundObjectOverride;
    [FieldOffset(0x02D8)] public UMovieSceneSequence* Sequence;
    [FieldOffset(0x02E0)] public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FTemplateSequenceBindingOverrideData
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UObject> Object;
    [FieldOffset(0x0008)] public bool bOverridesDefault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ATemplateSequenceActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public FMovieSceneSequencePlaybackSettings PlaybackSettings;
    [FieldOffset(0x0248)] public UTemplateSequencePlayer* SequencePlayer;
    [FieldOffset(0x0250)] public FSoftObjectPath TemplateSequence;
    [FieldOffset(0x0268)] public FTemplateSequenceBindingOverrideData BindingOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4F0)] 
public unsafe struct UTemplateSequencePlayer
{
    [FieldOffset(0x0000)] public UMovieSceneSequencePlayer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FTemplateSectionPropertyScale
{
    [FieldOffset(0x0000)] public FGuid ObjectBinding;
    [FieldOffset(0x0010)] public FMovieScenePropertyBinding PropertyBinding;
    [FieldOffset(0x0024)] public ETemplateSectionPropertyScaleType PropertyScaleType;
    [FieldOffset(0x0028)] public FMovieSceneFloatChannel FloatChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UTemplateSequenceSection
{
    [FieldOffset(0x0000)] public UMovieSceneSubSection baseObj;
    [FieldOffset(0x0170)] public TArray<FTemplateSectionPropertyScale> PropertyScales;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UTemplateSequenceSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UTemplateSequencePropertyScalingInstantiatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UTemplateSequencePropertyScalingEvaluatorSystem
{
    [FieldOffset(0x0000)] public UMovieSceneEntitySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UTemplateSequenceTrack
{
    [FieldOffset(0x0000)] public UMovieSceneSubTrack baseObj;
}

