using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMediaSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UBaseMediaSource
{
    [FieldOffset(0x0000)] public UMediaSource baseObj;
    [FieldOffset(0x0080)] public FName PlayerName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFileMediaSource
{
    [FieldOffset(0x0000)] public UBaseMediaSource baseObj;
    [FieldOffset(0x0088)] public FString FilePath;
    [FieldOffset(0x0098)] public bool PrecacheFile;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMediaCaptureDevice
{
    [FieldOffset(0x0000)] public FText DisplayName;
    [FieldOffset(0x0018)] public FString URL;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMediaBlueprintFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMediaComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UMediaTexture* MediaTexture;
    [FieldOffset(0x00B8)] public UMediaPlayer* MediaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UMediaTimeStampInfo
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FTimespan Time;
    [FieldOffset(0x0030)] public long SequenceIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UMediaPlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x00A8)] public FTimespan CacheAhead;
    [FieldOffset(0x00B0)] public FTimespan CacheBehind;
    [FieldOffset(0x00B8)] public FTimespan CacheBehindGame;
    [FieldOffset(0x00C0)] public bool NativeAudioOut;
    [FieldOffset(0x00C1)] public bool PlayOnOpen;
    [FieldOffset(0x00C4)] public byte Shuffle;
    [FieldOffset(0x00C4)] public byte Loop;
    [FieldOffset(0x00C8)] public UMediaPlaylist* Playlist;
    [FieldOffset(0x00D0)] public int PlaylistIndex;
    [FieldOffset(0x00D8)] public FTimespan TimeDelay;
    [FieldOffset(0x00E0)] public float HorizontalFieldOfView;
    [FieldOffset(0x00E4)] public float VerticalFieldOfView;
    [FieldOffset(0x00E8)] public FRotator ViewRotation;
    [FieldOffset(0x0120)] public FGuid PlayerGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UMediaPlaylist
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Items;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMediaSoundComponentSpectralData
{
    [FieldOffset(0x0000)] public float FrequencyHz;
    [FieldOffset(0x0004)] public float Magnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0x820)] 
public unsafe struct UMediaSoundComponent
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public EMediaSoundChannels Channels;
    [FieldOffset(0x06C4)] public bool DynamicRateAdjustment;
    [FieldOffset(0x06C8)] public float RateAdjustmentFactor;
    [FieldOffset(0x06CC)] public FFloatRange RateAdjustmentRange;
    [FieldOffset(0x06E0)] public UMediaPlayer* MediaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UMediaTexture
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0178)] public TextureAddress AddressX;
    [FieldOffset(0x0179)] public TextureAddress AddressY;
    [FieldOffset(0x017A)] public bool AutoClear;
    [FieldOffset(0x017C)] public FLinearColor ClearColor;
    [FieldOffset(0x018C)] public bool EnableGenMips;
    [FieldOffset(0x018D)] public byte NumMips;
    [FieldOffset(0x018E)] public bool NewStyleOutput;
    [FieldOffset(0x018F)] public MediaTextureOutputFormat OutputFormat;
    [FieldOffset(0x0190)] public float CurrentAspectRatio;
    [FieldOffset(0x0194)] public MediaTextureOrientation CurrentOrientation;
    [FieldOffset(0x0198)] public UMediaPlayer* MediaPlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UPlatformMediaSource
{
    [FieldOffset(0x0000)] public UMediaSource baseObj;
    [FieldOffset(0x0080)] public UMediaSource* MediaSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UStreamMediaSource
{
    [FieldOffset(0x0000)] public UBaseMediaSource baseObj;
    [FieldOffset(0x0088)] public FString StreamUrl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UTimeSynchronizableMediaSource
{
    [FieldOffset(0x0000)] public UBaseMediaSource baseObj;
    [FieldOffset(0x0088)] public bool bUseTimeSynchronization;
    [FieldOffset(0x008C)] public int FrameDelay;
    [FieldOffset(0x0090)] public double TimeDelay;
}

