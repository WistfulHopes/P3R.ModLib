using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UTcpMessagingSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool EnableTransport;
    [FieldOffset(0x0030)] public FString ListenEndpoint;
    [FieldOffset(0x0040)] public TArray<FString> ConnectToEndpoints;
    [FieldOffset(0x0050)] public int ConnectionRetryDelay;
    [FieldOffset(0x0054)] public bool bStopServiceWhenAppDeactivates;
}

