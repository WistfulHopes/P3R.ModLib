using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneCaptureProtocolBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0050)] public EMovieSceneCaptureProtocolState State;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneAudioCaptureProtocolBase
{
    [FieldOffset(0x0000)] public UMovieSceneCaptureProtocolBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNullAudioCaptureProtocol
{
    [FieldOffset(0x0000)] public UMovieSceneAudioCaptureProtocolBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMasterAudioSubmixCaptureProtocol
{
    [FieldOffset(0x0000)] public UMovieSceneAudioCaptureProtocolBase baseObj;
    [FieldOffset(0x0058)] public FString Filename;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneImageCaptureProtocolBase
{
    [FieldOffset(0x0000)] public UMovieSceneCaptureProtocolBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCompositionGraphCapturePasses
{
    [FieldOffset(0x0000)] public TArray<FString> Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UCompositionGraphCaptureProtocol
{
    [FieldOffset(0x0000)] public UMovieSceneImageCaptureProtocolBase baseObj;
    [FieldOffset(0x0058)] public FCompositionGraphCapturePasses IncludeRenderPasses;
    [FieldOffset(0x0068)] public bool bCaptureFramesInHDR;
    [FieldOffset(0x006C)] public int HDRCompressionQuality;
    [FieldOffset(0x0070)] public EHDRCaptureGamut CaptureGamut;
    [FieldOffset(0x0078)] public FSoftObjectPath PostProcessingMaterial;
    [FieldOffset(0x0090)] public bool bDisableScreenPercentage;
    [FieldOffset(0x0098)] public UMaterialInterface* PostProcessingMaterialPtr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UFrameGrabberProtocol
{
    [FieldOffset(0x0000)] public UMovieSceneImageCaptureProtocolBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UImageSequenceProtocol
{
    [FieldOffset(0x0000)] public UFrameGrabberProtocol baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UCompressedImageSequenceProtocol
{
    [FieldOffset(0x0000)] public UImageSequenceProtocol baseObj;
    [FieldOffset(0x00D8)] public int CompressionQuality;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UImageSequenceProtocol_BMP
{
    [FieldOffset(0x0000)] public UImageSequenceProtocol baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UImageSequenceProtocol_PNG
{
    [FieldOffset(0x0000)] public UCompressedImageSequenceProtocol baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UImageSequenceProtocol_JPG
{
    [FieldOffset(0x0000)] public UCompressedImageSequenceProtocol baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UImageSequenceProtocol_EXR
{
    [FieldOffset(0x0000)] public UImageSequenceProtocol baseObj;
    [FieldOffset(0x00D8)] public bool bCompressed;
    [FieldOffset(0x00D9)] public EHDRCaptureGamut CaptureGamut;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMovieSceneCaptureInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCaptureResolution
{
    [FieldOffset(0x0000)] public int ResX;
    [FieldOffset(0x0004)] public int ResY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FMovieSceneCaptureSettings
{
    [FieldOffset(0x0000)] public FDirectoryPath OutputDirectory;
    [FieldOffset(0x0010)] public TSubclassOf<AGameModeBase> GameModeOverride;
    [FieldOffset(0x0018)] public FString OutputFormat;
    [FieldOffset(0x0028)] public bool bOverwriteExisting;
    [FieldOffset(0x0029)] public bool bUseRelativeFrameNumbers;
    [FieldOffset(0x002C)] public int HandleFrames;
    [FieldOffset(0x0030)] public FString MovieExtension;
    [FieldOffset(0x0040)] public byte ZeroPadFrameNumbers;
    [FieldOffset(0x0044)] public FFrameRate FrameRate;
    [FieldOffset(0x004C)] public bool bUseCustomFrameRate;
    [FieldOffset(0x0050)] public FFrameRate CustomFrameRate;
    [FieldOffset(0x0058)] public FCaptureResolution Resolution;
    [FieldOffset(0x0060)] public bool bEnableTextureStreaming;
    [FieldOffset(0x0061)] public bool bCinematicEngineScalability;
    [FieldOffset(0x0062)] public bool bCinematicMode;
    [FieldOffset(0x0063)] public bool bAllowMovement;
    [FieldOffset(0x0064)] public bool bAllowTurning;
    [FieldOffset(0x0065)] public bool bShowPlayer;
    [FieldOffset(0x0066)] public bool bShowHUD;
    [FieldOffset(0x0067)] public bool bUsePathTracer;
    [FieldOffset(0x0068)] public int PathTracerSamplePerPixel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UMovieSceneCapture
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public FSoftClassPath ImageCaptureProtocolType;
    [FieldOffset(0x0050)] public FSoftClassPath AudioCaptureProtocolType;
    [FieldOffset(0x0068)] public UMovieSceneImageCaptureProtocolBase* ImageCaptureProtocol;
    [FieldOffset(0x0070)] public UMovieSceneAudioCaptureProtocolBase* AudioCaptureProtocol;
    [FieldOffset(0x0078)] public FMovieSceneCaptureSettings Settings;
    [FieldOffset(0x00E8)] public bool bUseSeparateProcess;
    [FieldOffset(0x00E9)] public bool bCloseEditorWhenCaptureStarts;
    [FieldOffset(0x00F0)] public FString AdditionalCommandLineArguments;
    [FieldOffset(0x0100)] public FString InheritedCommandLineArguments;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct ULevelCapture
{
    [FieldOffset(0x0000)] public UMovieSceneCapture baseObj;
    [FieldOffset(0x0220)] public bool bAutoStartCapture;
    [FieldOffset(0x022C)] public FGuid PrerequisiteActorId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneCaptureEnvironment
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FCapturedPixelsID
{
    [FieldOffset(0x0000)] public TMap<FName, FName> Identifiers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCapturedPixels
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFrameMetrics
{
    [FieldOffset(0x0000)] public float TotalElapsedTime;
    [FieldOffset(0x0004)] public float FrameDelta;
    [FieldOffset(0x0008)] public int FrameNumber;
    [FieldOffset(0x000C)] public int NumDroppedFrames;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UUserDefinedCaptureProtocol
{
    [FieldOffset(0x0000)] public UMovieSceneImageCaptureProtocolBase baseObj;
    [FieldOffset(0x0058)] public UWorld* World;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UUserDefinedImageCaptureProtocol
{
    [FieldOffset(0x0000)] public UUserDefinedCaptureProtocol baseObj;
    [FieldOffset(0x00D8)] public EDesiredImageFormat Format;
    [FieldOffset(0x00D9)] public bool bEnableCompression;
    [FieldOffset(0x00DC)] public int CompressionQuality;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UVideoCaptureProtocol
{
    [FieldOffset(0x0000)] public UFrameGrabberProtocol baseObj;
    [FieldOffset(0x0068)] public bool bUseCompression;
    [FieldOffset(0x006C)] public float CompressionQuality;
}

