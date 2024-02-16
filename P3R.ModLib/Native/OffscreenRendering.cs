using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct APreviewWorldUpdater
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UWorld* PreviewWorld;
    [FieldOffset(0x0238)] public FVector CameraPosition;
    [FieldOffset(0x0244)] public FVector CameraOffset;
    [FieldOffset(0x0250)] public FRotator CameraAngle;
    [FieldOffset(0x0260)] public FString CameraPosBoneName;
    [FieldOffset(0x0270)] public float FOV;
    [FieldOffset(0x0274)] public bool IsGazeMode;
    [FieldOffset(0x0278)] public FVector PointOfGazeOffset;
    [FieldOffset(0x0288)] public FString GazeOffsetBoneName;
    [FieldOffset(0x02B0)] public FTransform CameraTransform;
    [FieldOffset(0x02E0)] public TWeakObjectPtr<AActor> TargetActor;
    [FieldOffset(0x02E8)] public TWeakObjectPtr<ASceneCapture2D> SceneCaptureActor;
    [FieldOffset(0x02F0)] public TArray<IntPtr> Niagaras;
    [FieldOffset(0x0300)] public UNiagaraComponent* OneShotEffect;
    [FieldOffset(0x0308)] public TSubclassOf<AActor> SpawnPendingActorClass;
    [FieldOffset(0x0328)] public bool bIsAntialias;
    [FieldOffset(0x0329)] public bool bIsTAA;
    [FieldOffset(0x032A)] public bool bIsToneCurves;
    [FieldOffset(0x032B)] public bool bIsBloom;
    [FieldOffset(0x032C)] public bool bIsMotionBlur;
    [FieldOffset(0x032D)] public bool bIsExposure;
}

