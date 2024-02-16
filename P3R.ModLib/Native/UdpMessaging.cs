using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UUdpMessagingSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool EnabledByDefault;
    [FieldOffset(0x0029)] public bool EnableTransport;
    [FieldOffset(0x002A)] public bool bAutoRepair;
    [FieldOffset(0x002C)] public float MaxSendRate;
    [FieldOffset(0x0030)] public uint AutoRepairAttemptLimit;
    [FieldOffset(0x0034)] public bool bStopServiceWhenAppDeactivates;
    [FieldOffset(0x0038)] public FString UnicastEndpoint;
    [FieldOffset(0x0048)] public FString MulticastEndpoint;
    [FieldOffset(0x0058)] public EUdpMessageFormat MessageFormat;
    [FieldOffset(0x0059)] public byte MulticastTimeToLive;
    [FieldOffset(0x0060)] public TArray<FString> StaticEndpoints;
    [FieldOffset(0x0070)] public bool EnableTunnel;
    [FieldOffset(0x0078)] public FString TunnelUnicastEndpoint;
    [FieldOffset(0x0088)] public FString TunnelMulticastEndpoint;
    [FieldOffset(0x0098)] public TArray<FString> RemoteTunnelEndpoints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FUdpMockMessage
{
    [FieldOffset(0x0000)] public TArray<byte> Data;
}

