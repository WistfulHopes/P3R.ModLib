using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct UMovieSceneAtomSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public USoundAtomCue* Sound;
    [FieldOffset(0x00F0)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x00F8)] public FMovieSceneFloatChannel SoundVolume;
    [FieldOffset(0x0198)] public FMovieSceneFloatChannel PitchMultiplier;
    [FieldOffset(0x0238)] public FMovieSceneActorReferenceData AttachActorData;
    [FieldOffset(0x02E8)] public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves;
    [FieldOffset(0x02F8)] public bool bSuppressSubtitles;
    [FieldOffset(0x02F9)] public bool bOverrideAttenuation;
    [FieldOffset(0x0300)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0308)] public bool bContinueSoundWhenSequenceIsEnd;
    [FieldOffset(0x0310)] public TArray<int> AsrRackIDs;
    [FieldOffset(0x0320)] public TArray<FAtomSelectorParam> SelectorLabels;
    [FieldOffset(0x0330)] public bool bLooping;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneAtomTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> AtomSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UMovieSceneManaSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public UManaSource* ManaSource;
    [FieldOffset(0x00F0)] public bool bLooping;
    [FieldOffset(0x00F4)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x00F8)] public UManaTexture* ManaTexture;
    [FieldOffset(0x0100)] public UAtomComponent* AtomComponent;
    [FieldOffset(0x0108)] public bool bUseExternalManaPlayer;
    [FieldOffset(0x0110)] public UManaPlayer* ExternalManaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMovieSceneManaTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> ManaSections;
    [FieldOffset(0x00A8)] public TSoftObjectPtr<UMovieSceneAtomTrack> SyncedAtomTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneAtomSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public UMovieSceneAtomSection* AtomSection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneManaSectionParams
{
    [FieldOffset(0x0000)] public UAtomComponent* AtomComponent;
    [FieldOffset(0x0008)] public UManaSource* ManaSource;
    [FieldOffset(0x0010)] public UManaTexture* ManaTexture;
    [FieldOffset(0x0018)] public UManaPlayer* ManaPlayer;
    [FieldOffset(0x0020)] public FFrameNumber SectionStartFrame;
    [FieldOffset(0x0024)] public FFrameNumber SectionEndFrame;
    [FieldOffset(0x0028)] public bool bLooping;
    [FieldOffset(0x002C)] public FFrameNumber StartFrameOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FMovieSceneManaSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneManaSectionParams Params;
}

