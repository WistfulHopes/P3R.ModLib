using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UDebugMenuBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ADebugMenuBPI_Actor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UDebugMenuBase* _DebugMenuBase;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDebugMenuItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDebugMenuBPI
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UWorld* _World;
    [FieldOffset(0x0030)] public UDebugMenuBase* _DebugMenuBase;
    [FieldOffset(0x0038)] public ADebugMenuBPI_Actor* _Actor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDebugMenuEventData
{
}

