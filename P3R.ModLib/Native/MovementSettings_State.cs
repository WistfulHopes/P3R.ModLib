using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FMovementSettings_State
{
    [FieldOffset(0x0000)] public FMovementSettings_Stance VelocityDirection_17_291919F34C61D6D2C253D3B80934D9D2;
    [FieldOffset(0x0040)] public FMovementSettings_Stance LookingDirection_18_DEF8FDDA4324E7EF87C9DE8D07831456;
    [FieldOffset(0x0080)] public FMovementSettings_Stance Aiming_21_D7B17FD043E721735EF6CCA049CD9E66;
}

