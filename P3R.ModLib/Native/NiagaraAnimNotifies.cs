using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAnimNotify_PlayNiagaraEffect
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public UNiagaraSystem* Template;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public FVector Scale;
    [FieldOffset(0x0064)] public bool bAbsoluteScale;
    [FieldOffset(0x0080)] public byte Attached;
    [FieldOffset(0x0084)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAnimNotifyState_TimedNiagaraEffect
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public UNiagaraSystem* Template;
    [FieldOffset(0x0038)] public FName SocketName;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public bool bDestroyAtEnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UAnimNotifyState_TimedNiagaraEffectAdvanced
{
    [FieldOffset(0x0000)] public UAnimNotifyState_TimedNiagaraEffect baseObj;
}

