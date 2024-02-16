using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FActorLayer
{
    [FieldOffset(0x0000)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULayersBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

