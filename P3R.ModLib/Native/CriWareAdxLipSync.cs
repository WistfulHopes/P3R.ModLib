using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FCriLipsMorphTargetBlendAmountAsJapanese
{
    [FieldOffset(0x0000)] public float A;
    [FieldOffset(0x0004)] public float I;
    [FieldOffset(0x0008)] public float U;
    [FieldOffset(0x000C)] public float E;
    [FieldOffset(0x0010)] public float O;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCriLipsMouthInfo
{
    [FieldOffset(0x0000)] public float LipWidth;
    [FieldOffset(0x0004)] public float LipHeight;
    [FieldOffset(0x0008)] public float TonguePosition;
    [FieldOffset(0x000C)] public bool IsLipWidthReleased;
    [FieldOffset(0x000D)] public bool IsLipHeightReleased;
    [FieldOffset(0x000E)] public bool IsTonguePositionReleased;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULipsAnalyzerBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULipsAtomAnalyzer
{
    [FieldOffset(0x0000)] public ULipsAnalyzerBase baseObj;
    [FieldOffset(0x0030)] public UAtomComponent* AtomComponent;
}

