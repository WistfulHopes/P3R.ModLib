using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FPropertyPathSegment
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int ArrayIndex;
    [FieldOffset(0x0010)] public UStruct* Struct;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCachedPropertyPath
{
    [FieldOffset(0x0000)] public TArray<FPropertyPathSegment> Segments;
    [FieldOffset(0x0018)] public UFunction* CachedFunction;
}

