using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UOverlays
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FOverlayItem
{
    [FieldOffset(0x0000)] public FTimespan StartTime;
    [FieldOffset(0x0008)] public FTimespan EndTime;
    [FieldOffset(0x0010)] public FString Text;
    [FieldOffset(0x0020)] public FVector2D Position;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBasicOverlays
{
    [FieldOffset(0x0000)] public UOverlays baseObj;
    [FieldOffset(0x0028)] public TArray<FOverlayItem> Overlays;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct ULocalizedOverlays
{
    [FieldOffset(0x0000)] public UOverlays baseObj;
    [FieldOffset(0x0028)] public UBasicOverlays* DefaultOverlays;
    [FieldOffset(0x0030)] public TMap<FString, IntPtr> LocaleToOverlaysMap;
}

