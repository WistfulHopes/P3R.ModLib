using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFOscillator
{
    [FieldOffset(0x0000)] public float Amplitude;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public EInitialOscillatorOffset InitialOffset;
    [FieldOffset(0x0009)] public EOscillatorWaveform Waveform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FROscillator
{
    [FieldOffset(0x0000)] public FFOscillator Pitch;
    [FieldOffset(0x000C)] public FFOscillator Yaw;
    [FieldOffset(0x0018)] public FFOscillator Roll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FVOscillator
{
    [FieldOffset(0x0000)] public FFOscillator X;
    [FieldOffset(0x000C)] public FFOscillator Y;
    [FieldOffset(0x0018)] public FFOscillator Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UMatineeCameraShake
{
    [FieldOffset(0x0000)] public UCameraShakeBase baseObj;
    [FieldOffset(0x00A8)] public float OscillationDuration;
    [FieldOffset(0x00AC)] public float OscillationBlendInTime;
    [FieldOffset(0x00B0)] public float OscillationBlendOutTime;
    [FieldOffset(0x00B4)] public FROscillator RotOscillation;
    [FieldOffset(0x00D8)] public FVOscillator LocOscillation;
    [FieldOffset(0x00FC)] public FFOscillator FOVOscillation;
    [FieldOffset(0x0108)] public float AnimPlayRate;
    [FieldOffset(0x010C)] public float AnimScale;
    [FieldOffset(0x0110)] public float AnimBlendInTime;
    [FieldOffset(0x0114)] public float AnimBlendOutTime;
    [FieldOffset(0x0118)] public float RandomAnimSegmentDuration;
    [FieldOffset(0x0120)] public UCameraAnim* Anim;
    [FieldOffset(0x0128)] public UCameraAnimationSequence* AnimSequence;
    [FieldOffset(0x0130)] public byte bRandomAnimSegment;
    [FieldOffset(0x0134)] public float OscillatorTimeRemaining;
    [FieldOffset(0x0138)] public UCameraAnimInst* AnimInst;
    [FieldOffset(0x0180)] public USequenceCameraShakePattern* SequenceShakePattern;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UTestCameraShake
{
    [FieldOffset(0x0000)] public UCameraShakeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct USimpleCameraShakePattern
{
    [FieldOffset(0x0000)] public UCameraShakePattern baseObj;
    [FieldOffset(0x0028)] public float Duration;
    [FieldOffset(0x002C)] public float BlendInTime;
    [FieldOffset(0x0030)] public float BlendOutTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UConstantCameraShakePattern
{
    [FieldOffset(0x0000)] public USimpleCameraShakePattern baseObj;
    [FieldOffset(0x0038)] public FVector LocationOffset;
    [FieldOffset(0x0044)] public FRotator RotationOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UCompositeCameraShakePattern
{
    [FieldOffset(0x0000)] public UCameraShakePattern baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> ChildPatterns;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UDefaultCameraShakeBase
{
    [FieldOffset(0x0000)] public UCameraShakeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMatineeCameraShakePattern
{
    [FieldOffset(0x0000)] public UCameraShakePattern baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneMatineeCameraShakeEvaluator
{
    [FieldOffset(0x0000)] public UMovieSceneCameraShakeEvaluator baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMatineeCameraShakeFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPerlinNoiseShaker
{
    [FieldOffset(0x0000)] public float Amplitude;
    [FieldOffset(0x0004)] public float Frequency;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UPerlinNoiseCameraShakePattern
{
    [FieldOffset(0x0000)] public USimpleCameraShakePattern baseObj;
    [FieldOffset(0x0038)] public float LocationAmplitudeMultiplier;
    [FieldOffset(0x003C)] public float LocationFrequencyMultiplier;
    [FieldOffset(0x0040)] public FPerlinNoiseShaker X;
    [FieldOffset(0x0048)] public FPerlinNoiseShaker Y;
    [FieldOffset(0x0050)] public FPerlinNoiseShaker Z;
    [FieldOffset(0x0058)] public float RotationAmplitudeMultiplier;
    [FieldOffset(0x005C)] public float RotationFrequencyMultiplier;
    [FieldOffset(0x0060)] public FPerlinNoiseShaker Pitch;
    [FieldOffset(0x0068)] public FPerlinNoiseShaker Yaw;
    [FieldOffset(0x0070)] public FPerlinNoiseShaker Roll;
    [FieldOffset(0x0078)] public FPerlinNoiseShaker FOV;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FWaveOscillator
{
    [FieldOffset(0x0000)] public float Amplitude;
    [FieldOffset(0x0004)] public float Frequency;
    [FieldOffset(0x0008)] public EInitialWaveOscillatorOffsetType InitialOffsetType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UWaveOscillatorCameraShakePattern
{
    [FieldOffset(0x0000)] public USimpleCameraShakePattern baseObj;
    [FieldOffset(0x0038)] public float LocationAmplitudeMultiplier;
    [FieldOffset(0x003C)] public float LocationFrequencyMultiplier;
    [FieldOffset(0x0040)] public FWaveOscillator X;
    [FieldOffset(0x004C)] public FWaveOscillator Y;
    [FieldOffset(0x0058)] public FWaveOscillator Z;
    [FieldOffset(0x0064)] public float RotationAmplitudeMultiplier;
    [FieldOffset(0x0068)] public float RotationFrequencyMultiplier;
    [FieldOffset(0x006C)] public FWaveOscillator Pitch;
    [FieldOffset(0x0078)] public FWaveOscillator Yaw;
    [FieldOffset(0x0084)] public FWaveOscillator Roll;
    [FieldOffset(0x0090)] public FWaveOscillator FOV;
}

