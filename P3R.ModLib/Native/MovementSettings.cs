using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMovementSettings
{
    [FieldOffset(0x0000)] public float WalkSpeed_40_9AD737B14B8BC378F924E890E018B5B0;
    [FieldOffset(0x0004)] public float RunSpeed_39_7397773A4A46B563F765429BD6A2DDE8;
    [FieldOffset(0x0008)] public float SprintSpeed_38_6123675A40931BD70D4CF18D9A2A1C4C;
    [FieldOffset(0x0010)] public UCurveVector* MovementCurve_51_FDDCE64149CA0F8A553745BEA0FEE53E;
    [FieldOffset(0x0018)] public UCurveFloat* RotationRateCurve_52_73FA146B4B31FF205DE8E1BBFA8800F6;
}

