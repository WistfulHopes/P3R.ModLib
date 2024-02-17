using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimNotify_PlayMontageNotifyWindow : ObjectBase<UAnimNotify_PlayMontageNotifyWindow>
{
    public AnimNotify_PlayMontageNotifyWindow(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimSequencerInstance : ObjectBase<UAnimSequencerInstance>
{
    public AnimSequencerInstance(IntPtr pointer) : base(pointer) {}}

public unsafe class KismetAnimationLibrary : ObjectBase<UKismetAnimationLibrary>
{
    public KismetAnimationLibrary(IntPtr pointer) : base(pointer) {}
    public void K2_TwoBoneIK(ref FVector RootPos, ref FVector JointPos, ref FVector EndPos, ref FVector JointTarget, ref FVector Effector, ref FVector OutJointPos, ref FVector OutEndPos, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale)
    {
        Span<(string name, object value)> @params = [
            ("RootPos", RootPos), 
            ("JointPos", JointPos), 
            ("EndPos", EndPos), 
            ("JointTarget", JointTarget), 
            ("Effector", Effector), 
            ("OutJointPos", OutJointPos), 
            ("OutEndPos", OutEndPos), 
            ("bAllowStretching", bAllowStretching), 
            ("StartStretchRatio", StartStretchRatio), 
            ("MaxStretchScale", MaxStretchScale)
        ];
        ProcessEvent(GetFunction("K2_TwoBoneIK"), @params);
    }
    public void K2_StartProfilingTimer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("K2_StartProfilingTimer"), @params);
    }
    public FVector K2_MakePerlinNoiseVectorAndRemap(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("RangeOutMinX", RangeOutMinX), 
            ("RangeOutMaxX", RangeOutMaxX), 
            ("RangeOutMinY", RangeOutMinY), 
            ("RangeOutMaxY", RangeOutMaxY), 
            ("RangeOutMinZ", RangeOutMinZ), 
            ("RangeOutMaxZ", RangeOutMaxZ)
        ];
        return ProcessEvent<FVector>(GetFunction("K2_MakePerlinNoiseVectorAndRemap"), @params);
    }
    public float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value), 
            ("RangeOutMin", RangeOutMin), 
            ("RangeOutMax", RangeOutMax)
        ];
        return ProcessEvent<float>(GetFunction("K2_MakePerlinNoiseAndRemap"), @params);
    }
    public FTransform K2_LookAt(ref FTransform CurrentTransform, ref FVector TargetPosition, FVector LookAtVector, bool bUseUpVector, FVector UpVector, float ClampConeInDegree)
    {
        Span<(string name, object value)> @params = [
            ("CurrentTransform", CurrentTransform), 
            ("TargetPosition", TargetPosition), 
            ("LookAtVector", LookAtVector), 
            ("bUseUpVector", bUseUpVector), 
            ("UpVector", UpVector), 
            ("ClampConeInDegree", ClampConeInDegree)
        ];
        return ProcessEvent<FTransform>(GetFunction("K2_LookAt"), @params);
    }
    public float K2_EndProfilingTimer(bool bLog, FString LogPrefix)
    {
        Span<(string name, object value)> @params = [
            ("bLog", bLog), 
            ("LogPrefix", LogPrefix)
        ];
        return ProcessEvent<float>(GetFunction("K2_EndProfilingTimer"), @params);
    }
    public float K2_DistanceBetweenTwoSocketsAndMapRange(USkeletalMeshComponent* Component, FName SocketOrBoneNameA, ERelativeTransformSpace SocketSpaceA, FName SocketOrBoneNameB, ERelativeTransformSpace SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SocketOrBoneNameA", SocketOrBoneNameA), 
            ("SocketSpaceA", SocketSpaceA), 
            ("SocketOrBoneNameB", SocketOrBoneNameB), 
            ("SocketSpaceB", SocketSpaceB), 
            ("bRemapRange", bRemapRange), 
            ("InRangeMin", InRangeMin), 
            ("InRangeMax", InRangeMax), 
            ("OutRangeMin", OutRangeMin), 
            ("OutRangeMax", OutRangeMax)
        ];
        return ProcessEvent<float>(GetFunction("K2_DistanceBetweenTwoSocketsAndMapRange"), @params);
    }
    public FVector K2_DirectionBetweenSockets(USkeletalMeshComponent* Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SocketOrBoneNameFrom", SocketOrBoneNameFrom), 
            ("SocketOrBoneNameTo", SocketOrBoneNameTo)
        ];
        return ProcessEvent<FVector>(GetFunction("K2_DirectionBetweenSockets"), @params);
    }
    public float K2_CalculateVelocityFromSockets(float DeltaSeconds, USkeletalMeshComponent* Component, FName SocketOrBoneName, FName ReferenceSocketOrBone, ERelativeTransformSpace SocketSpace, FVector OffsetInBoneSpace, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, ref FRuntimeFloatCurve CustomCurve)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds), 
            ("Component", (IntPtr)Component), 
            ("SocketOrBoneName", SocketOrBoneName), 
            ("ReferenceSocketOrBone", ReferenceSocketOrBone), 
            ("SocketSpace", SocketSpace), 
            ("OffsetInBoneSpace", OffsetInBoneSpace), 
            ("History", History), 
            ("NumberOfSamples", NumberOfSamples), 
            ("VelocityMin", VelocityMin), 
            ("VelocityMax", VelocityMax), 
            ("EasingType", EasingType), 
            ("CustomCurve", CustomCurve)
        ];
        return ProcessEvent<float>(GetFunction("K2_CalculateVelocityFromSockets"), @params);
    }
    public float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds, FVector Position, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds), 
            ("Position", Position), 
            ("History", History), 
            ("NumberOfSamples", NumberOfSamples), 
            ("VelocityMin", VelocityMin), 
            ("VelocityMax", VelocityMax)
        ];
        return ProcessEvent<float>(GetFunction("K2_CalculateVelocityFromPositionHistory"), @params);
    }
}

public unsafe class PlayMontageCallbackProxy : ObjectBase<UPlayMontageCallbackProxy>
{
    public PlayMontageCallbackProxy(IntPtr pointer) : base(pointer) {}
    public void OnNotifyEndReceived(FName NotifyName, ref FBranchingPointNotifyPayload BranchingPointNotifyPayload)
    {
        Span<(string name, object value)> @params = [
            ("NotifyName", NotifyName), 
            ("BranchingPointNotifyPayload", BranchingPointNotifyPayload)
        ];
        ProcessEvent(GetFunction("OnNotifyEndReceived"), @params);
    }
    public void OnNotifyBeginReceived(FName NotifyName, ref FBranchingPointNotifyPayload BranchingPointNotifyPayload)
    {
        Span<(string name, object value)> @params = [
            ("NotifyName", NotifyName), 
            ("BranchingPointNotifyPayload", BranchingPointNotifyPayload)
        ];
        ProcessEvent(GetFunction("OnNotifyBeginReceived"), @params);
    }
    public void OnMontageEnded(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageEnded"), @params);
    }
    public void OnMontageBlendingOut(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageBlendingOut"), @params);
    }
    public UPlayMontageCallbackProxy* CreateProxyObjectForPlayMontage(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimMontage* MontageToPlay, float PlayRate, float startingPosition, FName StartingSection)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("MontageToPlay", (IntPtr)MontageToPlay), 
            ("PlayRate", PlayRate), 
            ("startingPosition", startingPosition), 
            ("StartingSection", StartingSection)
        ];
        return (UPlayMontageCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForPlayMontage"), @params);
    }
}

public unsafe class SequencerAnimationSupport : ObjectBase<ISequencerAnimationSupport>
{
    public SequencerAnimationSupport(IntPtr pointer) : base(pointer) {}}

public unsafe class AnimNotify_PlayMontageNotify : ObjectBase<UAnimNotify_PlayMontageNotify>
{
    public AnimNotify_PlayMontageNotify(IntPtr pointer) : base(pointer) {}
}

