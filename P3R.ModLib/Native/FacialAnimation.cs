using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8A0)] 
public unsafe struct UAudioCurveSourceComponent
{
    [FieldOffset(0x0000)] public UAudioComponent baseObj;
    [FieldOffset(0x0868)] public FName CurveSourceBindingName;
    [FieldOffset(0x0870)] public float CurveSyncOffset;
}

