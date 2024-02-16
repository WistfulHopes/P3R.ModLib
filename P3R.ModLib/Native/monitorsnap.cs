using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMonitorHandle
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMonitorResolution
{
    [FieldOffset(0x0000)] public int Width;
    [FieldOffset(0x0004)] public int Height;
    [FieldOffset(0x0008)] public int RefreshRateNumerator;
    [FieldOffset(0x000C)] public int RefreshRateDenominator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMonitorBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

