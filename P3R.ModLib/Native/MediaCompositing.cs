using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UMovieSceneMediaPlayerPropertySection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public UMediaSource* MediaSource;
    [FieldOffset(0x00F0)] public bool bLoop;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMovieSceneMediaPlayerPropertyTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UMovieSceneMediaSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public UMediaSource* MediaSource;
    [FieldOffset(0x00F0)] public bool bLooping;
    [FieldOffset(0x00F4)] public FFrameNumber StartFrameOffset;
    [FieldOffset(0x00F8)] public UMediaTexture* MediaTexture;
    [FieldOffset(0x0100)] public UMediaSoundComponent* MediaSoundComponent;
    [FieldOffset(0x0108)] public bool bUseExternalMediaPlayer;
    [FieldOffset(0x0110)] public UMediaPlayer* ExternalMediaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMovieSceneMediaTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public TArray<IntPtr> MediaSections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMovieSceneMediaPlayerPropertySectionTemplate
{
    [FieldOffset(0x0000)] public FMovieScenePropertySectionTemplate baseObj;
    [FieldOffset(0x0038)] public UMediaSource* MediaSource;
    [FieldOffset(0x0040)] public FFrameNumber SectionStartFrame;
    [FieldOffset(0x0044)] public bool bLoop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMovieSceneMediaSectionParams
{
    [FieldOffset(0x0000)] public UMediaSoundComponent* MediaSoundComponent;
    [FieldOffset(0x0008)] public UMediaSource* MediaSource;
    [FieldOffset(0x0010)] public UMediaTexture* MediaTexture;
    [FieldOffset(0x0018)] public UMediaPlayer* MediaPlayer;
    [FieldOffset(0x0020)] public FFrameNumber SectionStartFrame;
    [FieldOffset(0x0024)] public FFrameNumber SectionEndFrame;
    [FieldOffset(0x0028)] public bool bLooping;
    [FieldOffset(0x002C)] public FFrameNumber StartFrameOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FMovieSceneMediaSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneMediaSectionParams Params;
}

