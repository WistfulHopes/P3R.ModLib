using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UAnimSharingStateInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public UAnimSequence* AnimationToPlay;
    [FieldOffset(0x02C0)] public float PermutationTimeOffset;
    [FieldOffset(0x02C4)] public float PlayRate;
    [FieldOffset(0x02C8)] public bool bStateBool;
    [FieldOffset(0x02D0)] public UAnimSharingInstance* Instance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct UAnimSharingTransitionInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public TWeakObjectPtr<USkeletalMeshComponent> FromComponent;
    [FieldOffset(0x02C0)] public TWeakObjectPtr<USkeletalMeshComponent> ToComponent;
    [FieldOffset(0x02C8)] public float BlendTime;
    [FieldOffset(0x02CC)] public bool bBlendBool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct UAnimSharingAdditiveInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public TWeakObjectPtr<USkeletalMeshComponent> BaseComponent;
    [FieldOffset(0x02C0)] public TWeakObjectPtr<UAnimSequence> AdditiveAnimation;
    [FieldOffset(0x02C8)] public float Alpha;
    [FieldOffset(0x02CC)] public bool bStateBool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UAnimSharingInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> RegisteredActors;
    [FieldOffset(0x0088)] public UAnimationSharingStateProcessor* StateProcessor;
    [FieldOffset(0x00C8)] public TArray<IntPtr> UsedAnimationSequences;
    [FieldOffset(0x00E8)] public UEnum* StateEnum;
    [FieldOffset(0x00F0)] public AActor* SharingActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAnimationSharingManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Skeletons;
    [FieldOffset(0x0038)] public TArray<IntPtr> PerSkeletonData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimationSetup
{
    [FieldOffset(0x0000)] public UAnimSequence* AnimSequence;
    [FieldOffset(0x0008)] public TSubclassOf<UAnimSharingStateInstance> AnimBlueprint;
    [FieldOffset(0x0010)] public FPerPlatformInt NumRandomizedInstances;
    [FieldOffset(0x0014)] public FPerPlatformBool Enabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimationStateEntry
{
    [FieldOffset(0x0000)] public byte State;
    [FieldOffset(0x0008)] public TArray<FAnimationSetup> AnimationSetups;
    [FieldOffset(0x0018)] public bool bOnDemand;
    [FieldOffset(0x0019)] public bool bAdditive;
    [FieldOffset(0x001C)] public float BlendTime;
    [FieldOffset(0x0020)] public bool bReturnToPreviousState;
    [FieldOffset(0x0021)] public bool bSetNextState;
    [FieldOffset(0x0022)] public byte NextState;
    [FieldOffset(0x0024)] public FPerPlatformInt MaximumNumberOfConcurrentInstances;
    [FieldOffset(0x0028)] public float WiggleTimePercentage;
    [FieldOffset(0x002C)] public bool bRequiresCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPerSkeletonAnimationSharingSetup
{
    [FieldOffset(0x0000)] public USkeleton* Skeleton;
    [FieldOffset(0x0008)] public USkeletalMesh* SkeletalMesh;
    [FieldOffset(0x0010)] public TSubclassOf<UAnimSharingTransitionInstance> BlendAnimBlueprint;
    [FieldOffset(0x0018)] public TSubclassOf<UAnimSharingAdditiveInstance> AdditiveAnimBlueprint;
    [FieldOffset(0x0020)] public TSubclassOf<UAnimationSharingStateProcessor> StateProcessorClass;
    [FieldOffset(0x0028)] public TArray<FAnimationStateEntry> AnimationStates;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimationSharingScalability
{
    [FieldOffset(0x0000)] public FPerPlatformBool UseBlendTransitions;
    [FieldOffset(0x0004)] public FPerPlatformFloat BlendSignificanceValue;
    [FieldOffset(0x0008)] public FPerPlatformInt MaximumNumberConcurrentBlends;
    [FieldOffset(0x000C)] public FPerPlatformFloat TickSignificanceValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAnimationSharingSetup
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FPerSkeletonAnimationSharingSetup> SkeletonSetups;
    [FieldOffset(0x0038)] public FAnimationSharingScalability ScalabilitySettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAnimationSharingStateProcessor
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSoftObjectPtr<UEnum> AnimationStateEnum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FTickAnimationSharingFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

