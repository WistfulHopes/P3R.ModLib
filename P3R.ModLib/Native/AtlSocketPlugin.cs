using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UAtlSocketBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAtlSocketStringUtils
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UAtlTcpListener
{
    [FieldOffset(0x0000)] public UAtlSocketBase baseObj;
    [FieldOffset(0x00D0)] public TArray<IntPtr> Clients_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UAtlTcpSocket
{
    [FieldOffset(0x0000)] public UAtlSocketBase baseObj;
}

