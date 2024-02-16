using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVelocityBlend
{
    [FieldOffset(0x0000)] public float F_3_2154ABAD4BD15DAC904154B63D704219;
    [FieldOffset(0x0004)] public float B_5_0A0855774CB13BB3E4B0A6847E7154F6;
    [FieldOffset(0x0008)] public float L_8_DFEBB8584D28F158D2562CA60EB07B6D;
    [FieldOffset(0x000C)] public float R_9_79E6E09B4A52B442B9FE6DB7192CFBEE;
}

