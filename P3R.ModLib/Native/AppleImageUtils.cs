using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAppleImageUtilsImageConversionResult
{
    [FieldOffset(0x0000)] public FString Error;
    [FieldOffset(0x0010)] public TArray<byte> ImageData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAppleImageUtilsBaseAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0060)] public FAppleImageUtilsImageConversionResult ConversionResult;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAppleImageInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

