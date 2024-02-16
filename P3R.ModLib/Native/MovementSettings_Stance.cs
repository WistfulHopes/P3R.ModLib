using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMovementSettings_Stance
{
    [FieldOffset(0x0000)] public FMovementSettings Standing_12_291919F34C61D6D2C253D3B80934D9D2;
    [FieldOffset(0x0020)] public FMovementSettings Crouching_14_DEF8FDDA4324E7EF87C9DE8D07831456;
}

