using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USteamAuthComponentModuleInterface
{
    [FieldOffset(0x0000)] public UHandlerComponentFactory baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C50)] 
public unsafe struct USteamNetConnection
{
    [FieldOffset(0x0000)] public UIpConnection baseObj;
    [FieldOffset(0x1C48)] public bool bIsPassthrough;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7D8)] 
public unsafe struct USteamNetDriver
{
    [FieldOffset(0x0000)] public UIpNetDriver baseObj;
}

