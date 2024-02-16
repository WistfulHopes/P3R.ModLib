using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFixedFrameRateCustomTimeStep
{
    [FieldOffset(0x0000)] public UEngineCustomTimeStep baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UGenlockedCustomTimeStep
{
    [FieldOffset(0x0000)] public UFixedFrameRateCustomTimeStep baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGenlockedFixedRateCustomTimeStep
{
    [FieldOffset(0x0000)] public UGenlockedCustomTimeStep baseObj;
    [FieldOffset(0x0028)] public FFrameRate FrameRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGenlockedTimecodeProvider
{
    [FieldOffset(0x0000)] public UTimecodeProvider baseObj;
    [FieldOffset(0x0030)] public bool bUseGenlockToCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTimeManagementBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UTimeSynchronizationSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bUseForSynchronization;
    [FieldOffset(0x002C)] public int FrameOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FTimedDataInputEvaluationData
{
    [FieldOffset(0x0000)] public float DistanceToNewestSampleSeconds;
    [FieldOffset(0x0004)] public float DistanceToOldestSampleSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTimedDataChannelSampleTime
{
}

