using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FEyeTrackerStereoGazeData
{
    [FieldOffset(0x0000)] public FVector LeftEyeOrigin;
    [FieldOffset(0x000C)] public FVector LeftEyeDirection;
    [FieldOffset(0x0018)] public FVector RightEyeOrigin;
    [FieldOffset(0x0024)] public FVector RightEyeDirection;
    [FieldOffset(0x0030)] public FVector FixationPoint;
    [FieldOffset(0x003C)] public float ConfidenceValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FEyeTrackerGazeData
{
    [FieldOffset(0x0000)] public FVector GazeOrigin;
    [FieldOffset(0x000C)] public FVector GazeDirection;
    [FieldOffset(0x0018)] public FVector FixationPoint;
    [FieldOffset(0x0024)] public float ConfidenceValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEyeTrackerFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

