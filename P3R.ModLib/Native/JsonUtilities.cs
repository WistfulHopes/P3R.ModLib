using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UJsonUtilitiesDummyObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FJsonObjectWrapper
{
    [FieldOffset(0x0000)] public FString JsonString;
}

