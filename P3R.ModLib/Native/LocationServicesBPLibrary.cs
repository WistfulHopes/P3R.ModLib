using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FLocationServicesData
{
    [FieldOffset(0x0000)] public float Timestamp;
    [FieldOffset(0x0004)] public float Longitude;
    [FieldOffset(0x0008)] public float Latitude;
    [FieldOffset(0x000C)] public float HorizontalAccuracy;
    [FieldOffset(0x0010)] public float VerticalAccuracy;
    [FieldOffset(0x0014)] public float Altitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULocationServices
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULocationServicesImpl
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

