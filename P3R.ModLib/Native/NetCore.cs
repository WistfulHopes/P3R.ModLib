using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNetAnalyticsDataConfig
{
    [FieldOffset(0x0000)] public FName DataName;
    [FieldOffset(0x0008)] public bool bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNetAnalyticsAggregatorConfig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FNetAnalyticsDataConfig> NetAnalyticsData;
}

