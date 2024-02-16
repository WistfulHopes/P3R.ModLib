using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMyPluginStruct
{
    [FieldOffset(0x0000)] public FString TestString;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UMyPluginObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FMyPluginStruct MyStruct;
}

