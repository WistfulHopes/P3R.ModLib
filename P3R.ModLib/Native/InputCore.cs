using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FKey
{
    [FieldOffset(0x0000)] public FName KeyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInputCoreTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

