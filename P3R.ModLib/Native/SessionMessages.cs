using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FSessionServiceLogUnsubscribe
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FSessionServiceLogSubscribe
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSessionServiceLog
{
    [FieldOffset(0x0000)] public FName Category;
    [FieldOffset(0x0008)] public FString Data;
    [FieldOffset(0x0018)] public FGuid InstanceId;
    [FieldOffset(0x0028)] public double TimeSeconds;
    [FieldOffset(0x0030)] public byte Verbosity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FSessionServicePong
{
    [FieldOffset(0x0000)] public bool Authorized;
    [FieldOffset(0x0008)] public FString BuildDate;
    [FieldOffset(0x0018)] public FString DeviceName;
    [FieldOffset(0x0028)] public FGuid InstanceId;
    [FieldOffset(0x0038)] public FString InstanceName;
    [FieldOffset(0x0048)] public FString PlatformName;
    [FieldOffset(0x0058)] public FGuid SessionId;
    [FieldOffset(0x0068)] public FString SessionName;
    [FieldOffset(0x0078)] public FString SessionOwner;
    [FieldOffset(0x0088)] public bool Standalone;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSessionServicePing
{
    [FieldOffset(0x0000)] public FString UserName;
}

