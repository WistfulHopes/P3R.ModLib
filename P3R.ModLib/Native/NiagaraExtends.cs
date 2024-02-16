using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAnimNotify_PlayNiagaraEffectEx
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public UNiagaraSystem* Template;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public FVector Scale;
    [FieldOffset(0x0064)] public bool bAbsoluteLocation;
    [FieldOffset(0x0065)] public bool bAbsoluteRotation;
    [FieldOffset(0x0066)] public bool bAbsoluteScale;
    [FieldOffset(0x0067)] public bool bIsLoopEffect;
    [FieldOffset(0x0080)] public byte Attached;
    [FieldOffset(0x0084)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAnimNotifyState_NiagaraTrail
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public UNiagaraSystem* Template;
    [FieldOffset(0x0038)] public FName FirstSocketName;
    [FieldOffset(0x0040)] public FName SecondSocketName;
    [FieldOffset(0x0048)] public FVector LocationOffset;
    [FieldOffset(0x0054)] public FRotator RotationOffset;
    [FieldOffset(0x0060)] public bool bDestroyAtEnd;
    [FieldOffset(0x0061)] public bool bAbsoluteLocation;
    [FieldOffset(0x0062)] public bool bAbsoluteRotation;
    [FieldOffset(0x0063)] public bool bAbsoluteScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAnimNotifyState_TimedNiagaraEffectEx
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public UNiagaraSystem* Template;
    [FieldOffset(0x0038)] public FName SocketName;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public bool bAbsoluteLocation;
    [FieldOffset(0x0059)] public bool bAbsoluteRotation;
    [FieldOffset(0x005A)] public bool bAbsoluteScale;
    [FieldOffset(0x005B)] public bool bUseOffsetRootLocation;
    [FieldOffset(0x005C)] public bool bUseOffsetRootRotation;
    [FieldOffset(0x005D)] public bool bUseOffsetRootScale;
    [FieldOffset(0x005E)] public bool bDestroyAtEnd;
    [FieldOffset(0x0060)] public UFXSystemComponent* Component;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ANiagaraActorExtends
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public UNiagaraParameterCollection* ParameterCollection;
    [FieldOffset(0x0238)] public bool bIsPause;
    [FieldOffset(0x0239)] public bool bISBillboard;
    [FieldOffset(0x023C)] public float PlaybackSpeed;
    [FieldOffset(0x0248)] public UNiagaraComponent* NiagaraComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UNiagaraCameraShake
{
    [FieldOffset(0x0000)] public UMatineeCameraShake baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNiagaraDataInterfaceBillboardEffect
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public int PlayerControllerIndex;
    [FieldOffset(0x003C)] public FVector LockAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNiagaraDataInterfaceBillboardEffect2
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public int PlayerControllerIndex;
    [FieldOffset(0x003C)] public FVector LockAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNiagaraDataInterfaceCameraShake
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public TSubclassOf<UNiagaraCameraShake> NiagaraCameraShake;
    [FieldOffset(0x0048)] public TArray<uint> ShakingEffects;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB30)] 
public unsafe struct UNiagaraDataInterfacePostProcess
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public bool CreatePostProcessComponent;
    [FieldOffset(0x0040)] public FWeightedBlendables PostProcessMaterials;
    [FieldOffset(0x0B20)] public UMaterialParameterCollectionInstance* niagaraPostProcessParameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraDataInterfaceSetCustomStencil
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public int CustomStencilValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNiagaraDataInterfaceSyncActorPause
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraExtendsFunctionLibrary
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

