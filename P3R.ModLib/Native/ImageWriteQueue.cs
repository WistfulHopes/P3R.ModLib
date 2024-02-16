using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FImageWriteOptions
{
    [FieldOffset(0x0000)] public EDesiredImageFormat Format;
    [FieldOffset(0x0014)] public int CompressionQuality;
    [FieldOffset(0x0018)] public bool bOverwriteFile;
    [FieldOffset(0x0019)] public bool bAsync;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UImageWriteBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

