using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x520)] 
public unsafe struct AArchVisCharacter
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public FString LookUpAxisName;
    [FieldOffset(0x04C8)] public FString LookUpAtRateAxisName;
    [FieldOffset(0x04D8)] public FString TurnAxisName;
    [FieldOffset(0x04E8)] public FString TurnAtRateAxisName;
    [FieldOffset(0x04F8)] public FString MoveForwardAxisName;
    [FieldOffset(0x0508)] public FString MoveRightAxisName;
    [FieldOffset(0x0518)] public float MouseSensitivityScale_Pitch;
    [FieldOffset(0x051C)] public float MouseSensitivityScale_Yaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB40)] 
public unsafe struct UArchVisCharMovementComponent
{
    [FieldOffset(0x0000)] public UCharacterMovementComponent baseObj;
    [FieldOffset(0x0AF0)] public FRotator RotationalAcceleration;
    [FieldOffset(0x0AFC)] public FRotator RotationalDeceleration;
    [FieldOffset(0x0B08)] public FRotator MaxRotationalVelocity;
    [FieldOffset(0x0B14)] public float MinPitch;
    [FieldOffset(0x0B18)] public float MaxPitch;
    [FieldOffset(0x0B1C)] public float WalkingFriction;
    [FieldOffset(0x0B20)] public float WalkingSpeed;
    [FieldOffset(0x0B24)] public float WalkingAcceleration;
}

