using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FCameraFilmbackSettings
{
    [FieldOffset(0x0000)] public float SensorWidth;
    [FieldOffset(0x0004)] public float SensorHeight;
    [FieldOffset(0x0008)] public float SensorAspectRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCameraLensSettings
{
    [FieldOffset(0x0000)] public float MinFocalLength;
    [FieldOffset(0x0004)] public float MaxFocalLength;
    [FieldOffset(0x0008)] public float MinFStop;
    [FieldOffset(0x000C)] public float MaxFStop;
    [FieldOffset(0x0010)] public float MinimumFocusDistance;
    [FieldOffset(0x0014)] public int DiaphragmBladeCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCameraTrackingFocusSettings
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<AActor> ActorToTrack;
    [FieldOffset(0x0028)] public FVector RelativeOffset;
    [FieldOffset(0x0034)] public byte bDrawDebugTrackingFocusPoint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FCameraFocusSettings
{
    [FieldOffset(0x0000)] public ECameraFocusMethod FocusMethod;
    [FieldOffset(0x0004)] public float ManualFocusDistance;
    [FieldOffset(0x0008)] public FCameraTrackingFocusSettings TrackingFocusSettings;
    [FieldOffset(0x0040)] public byte bDrawDebugFocusPlane;
    [FieldOffset(0x0044)] public FColor DebugFocusPlaneColor;
    [FieldOffset(0x0048)] public byte bSmoothFocusChanges;
    [FieldOffset(0x004C)] public float FocusSmoothingInterpSpeed;
    [FieldOffset(0x0050)] public float FocusOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct ACameraRig_Crane
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public float CranePitch;
    [FieldOffset(0x0224)] public float CraneYaw;
    [FieldOffset(0x0228)] public float CraneArmLength;
    [FieldOffset(0x022C)] public bool bLockMountPitch;
    [FieldOffset(0x022D)] public bool bLockMountYaw;
    [FieldOffset(0x0230)] public USceneComponent* TransformComponent;
    [FieldOffset(0x0238)] public USceneComponent* CraneYawControl;
    [FieldOffset(0x0240)] public USceneComponent* CranePitchControl;
    [FieldOffset(0x0248)] public USceneComponent* CraneCameraMount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct ACameraRig_Rail
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public float CurrentPositionOnRail;
    [FieldOffset(0x0224)] public bool bLockOrientationToRail;
    [FieldOffset(0x0228)] public USceneComponent* TransformComponent;
    [FieldOffset(0x0230)] public USplineComponent* RailSplineComponent;
    [FieldOffset(0x0238)] public USceneComponent* RailCameraMount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FCameraLookatTrackingSettings
{
    [FieldOffset(0x0000)] public byte bEnableLookAtTracking;
    [FieldOffset(0x0000)] public byte bDrawDebugLookAtTrackingPosition;
    [FieldOffset(0x0004)] public float LookAtTrackingInterpSpeed;
    [FieldOffset(0x0018)] public TSoftObjectPtr<AActor> ActorToTrack;
    [FieldOffset(0x0040)] public FVector RelativeOffset;
    [FieldOffset(0x004C)] public byte bAllowRoll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x810)] 
public unsafe struct ACineCameraActor
{
    [FieldOffset(0x0000)] public ACameraActor baseObj;
    [FieldOffset(0x07B0)] public FCameraLookatTrackingSettings LookatTrackingSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNamedFilmbackPreset
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FCameraFilmbackSettings FilmbackSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNamedLensPreset
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FCameraLensSettings LensSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8D0)] 
public unsafe struct UCineCameraComponent
{
    [FieldOffset(0x0000)] public UCameraComponent baseObj;
    [FieldOffset(0x07D0)] public FCameraFilmbackSettings FilmbackSettings;
    [FieldOffset(0x07DC)] public FCameraFilmbackSettings Filmback;
    [FieldOffset(0x07E8)] public FCameraLensSettings LensSettings;
    [FieldOffset(0x0800)] public FCameraFocusSettings FocusSettings;
    [FieldOffset(0x0858)] public float CurrentFocalLength;
    [FieldOffset(0x085C)] public float CurrentAperture;
    [FieldOffset(0x0860)] public float CurrentFocusDistance;
    [FieldOffset(0x0870)] public TArray<FNamedFilmbackPreset> FilmbackPresets;
    [FieldOffset(0x0880)] public TArray<FNamedLensPreset> LensPresets;
    [FieldOffset(0x0890)] public FString DefaultFilmbackPresetName;
    [FieldOffset(0x08A0)] public FString DefaultFilmbackPreset;
    [FieldOffset(0x08B0)] public FString DefaultLensPresetName;
    [FieldOffset(0x08C0)] public float DefaultLensFocalLength;
    [FieldOffset(0x08C4)] public float DefaultLensFStop;
}

