using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAsyncCueSheetManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public USoundAtomCueSheet* CueSheet;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct ULiveLipSync
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ULipsAtomAnalyzer* LipsAnalyzer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UPlayerControlBlock
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAtomComponent* Player;
    [FieldOffset(0x0090)] public ULipsAtomAnalyzer* LipsAnalyzer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAcbFileControlBlock
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public USoundAtomCueSheet* CueSheet;
    [FieldOffset(0x0048)] public UACBLoadObject* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA98)] 
public unsafe struct UPlayAdxControl
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UPlayerControlBlock* mPlayerControlBlock;
    [FieldOffset(0x0840)] public UAcbFileControlBlock* mAcbFileControlBlock;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UACBLoadObject
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B8)] public UAsyncCueSheetManager* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundManagerReadyAsyncFunction
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USoundManagerGameInstanceSubSystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public UPlayAdxControl* PlayAdxControl;
}

