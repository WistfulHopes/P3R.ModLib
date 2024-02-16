using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimNotify_PlayMontageNotify : ObjectBase<UAnimNotify_PlayMontageNotify>
{

}

public unsafe class AnimNotify_PlayMontageNotifyWindow : ObjectBase<UAnimNotify_PlayMontageNotifyWindow>
{

}

public unsafe class AnimSequencerInstance : ObjectBase<UAnimSequencerInstance>
{
}

public unsafe class PositionHistory : ObjectBase<FPositionHistory>
{

}

public unsafe class KismetAnimationLibrary : ObjectBase<UKismetAnimationLibrary>
{

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
        ProcessEvent(GetFunction("K2_TwoBoneIK"),  @params);
    }
    public void K2_StartProfilingTimer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("K2_StartProfilingTimer"),  @params);
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
        return ProcessEvent<FVector>(GetFunction("K2_MakePerlinNoiseVectorAndRemap"),  @params);
    }
    public float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value), 
            ("RangeOutMin", RangeOutMin), 
            ("RangeOutMax", RangeOutMax)
        ];
        return ProcessEvent<float>(GetFunction("K2_MakePerlinNoiseAndRemap"),  @params);
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
        return ProcessEvent<FTransform>(GetFunction("K2_LookAt"),  @params);
    }
    public float K2_EndProfilingTimer(bool bLog, FString LogPrefix)
    {
        Span<(string name, object value)> @params = [
            ("bLog", bLog), 
            ("LogPrefix", LogPrefix)
        ];
        return ProcessEvent<float>(GetFunction("K2_EndProfilingTimer"),  @params);
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
        return ProcessEvent<float>(GetFunction("K2_DistanceBetweenTwoSocketsAndMapRange"),  @params);
    }
    public FVector K2_DirectionBetweenSockets(USkeletalMeshComponent* Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SocketOrBoneNameFrom", SocketOrBoneNameFrom), 
            ("SocketOrBoneNameTo", SocketOrBoneNameTo)
        ];
        return ProcessEvent<FVector>(GetFunction("K2_DirectionBetweenSockets"),  @params);
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
        return ProcessEvent<float>(GetFunction("K2_CalculateVelocityFromSockets"),  @params);
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
        return ProcessEvent<float>(GetFunction("K2_CalculateVelocityFromPositionHistory"),  @params);
    }
}

public unsafe class PlayMontageCallbackProxy : ObjectBase<UPlayMontageCallbackProxy>
{

    public void OnNotifyEndReceived(FName NotifyName, ref FBranchingPointNotifyPayload BranchingPointNotifyPayload)
    {
        Span<(string name, object value)> @params = [
            ("NotifyName", NotifyName), 
            ("BranchingPointNotifyPayload", BranchingPointNotifyPayload)
        ];
        ProcessEvent(GetFunction("OnNotifyEndReceived"),  @params);
    }
    public void OnNotifyBeginReceived(FName NotifyName, ref FBranchingPointNotifyPayload BranchingPointNotifyPayload)
    {
        Span<(string name, object value)> @params = [
            ("NotifyName", NotifyName), 
            ("BranchingPointNotifyPayload", BranchingPointNotifyPayload)
        ];
        ProcessEvent(GetFunction("OnNotifyBeginReceived"),  @params);
    }
    public void OnMontageEnded(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageEnded"),  @params);
    }
    public void OnMontageBlendingOut(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageBlendingOut"),  @params);
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
        return (UPlayMontageCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForPlayMontage"),  @params);
    }
}

public unsafe class SequencerAnimationSupport : ObjectBase<ISequencerAnimationSupport>
{
}

public unsafe class AnimNode_SkeletalControlBase : ObjectBase<FAnimNode_SkeletalControlBase>
{

}

public unsafe class AnimNode_BlendSpacePlayer : ObjectBase<FAnimNode_BlendSpacePlayer>
{

}

public unsafe class AnimNode_AimOffsetLookAt : ObjectBase<FAnimNode_AimOffsetLookAt>
{

}

public unsafe class AnimNode_AnimDynamics : ObjectBase<FAnimNode_AnimDynamics>
{

}

public unsafe class RotationRetargetingInfo : ObjectBase<FRotationRetargetingInfo>
{

}

public unsafe class AnimPhysPlanarLimit : ObjectBase<FAnimPhysPlanarLimit>
{

}

public unsafe class AnimPhysSphericalLimit : ObjectBase<FAnimPhysSphericalLimit>
{

}

public unsafe class AnimPhysConstraintSetup : ObjectBase<FAnimPhysConstraintSetup>
{

}

public unsafe class AnimNode_ApplyAdditive : ObjectBase<FAnimNode_ApplyAdditive>
{

}

public unsafe class AnimNode_ApplyLimits : ObjectBase<FAnimNode_ApplyLimits>
{

}

public unsafe class AngularRangeLimit : ObjectBase<FAngularRangeLimit>
{

}

public unsafe class AnimNode_BlendBoneByChannel : ObjectBase<FAnimNode_BlendBoneByChannel>
{

}

public unsafe class BlendBoneByChannelEntry : ObjectBase<FBlendBoneByChannelEntry>
{

}

public unsafe class AnimNode_BlendListBase : ObjectBase<FAnimNode_BlendListBase>
{

}

public unsafe class AnimNode_BlendListByBool : ObjectBase<FAnimNode_BlendListByBool>
{

}

public unsafe class AnimNode_BlendListByEnum : ObjectBase<FAnimNode_BlendListByEnum>
{

}

public unsafe class AnimNode_BlendListByInt : ObjectBase<FAnimNode_BlendListByInt>
{

}

public unsafe class AnimNode_BlendSpaceEvaluator : ObjectBase<FAnimNode_BlendSpaceEvaluator>
{

}

public unsafe class AnimNode_BoneDrivenController : ObjectBase<FAnimNode_BoneDrivenController>
{

}

public unsafe class AnimNode_CCDIK : ObjectBase<FAnimNode_CCDIK>
{

}

public unsafe class BoneSocketTarget : ObjectBase<FBoneSocketTarget>
{

}

public unsafe class SocketReference : ObjectBase<FSocketReference>
{

}

public unsafe class AnimNode_Constraint : ObjectBase<FAnimNode_Constraint>
{

}

public unsafe class Constraint : ObjectBase<FConstraint>
{

}

public unsafe class AnimNode_CopyBone : ObjectBase<FAnimNode_CopyBone>
{

}

public unsafe class AnimNode_CopyBoneDelta : ObjectBase<FAnimNode_CopyBoneDelta>
{

}

public unsafe class AnimNode_CopyPoseFromMesh : ObjectBase<FAnimNode_CopyPoseFromMesh>
{

}

public unsafe class AnimNode_CurveSource : ObjectBase<FAnimNode_CurveSource>
{

}

public unsafe class AnimNode_Fabrik : ObjectBase<FAnimNode_Fabrik>
{

}

public unsafe class AnimNode_HandIKRetargeting : ObjectBase<FAnimNode_HandIKRetargeting>
{

}

public unsafe class AnimNode_LayeredBoneBlend : ObjectBase<FAnimNode_LayeredBoneBlend>
{

}

public unsafe class AnimNode_LegIK : ObjectBase<FAnimNode_LegIK>
{

}

public unsafe class AnimLegIKDefinition : ObjectBase<FAnimLegIKDefinition>
{

}

public unsafe class AnimLegIKData : ObjectBase<FAnimLegIKData>
{
}

public unsafe class IKChain : ObjectBase<FIKChain>
{
}

public unsafe class IKChainLink : ObjectBase<FIKChainLink>
{
}

public unsafe class AnimNode_LookAt : ObjectBase<FAnimNode_LookAt>
{

}

public unsafe class AnimNode_MakeDynamicAdditive : ObjectBase<FAnimNode_MakeDynamicAdditive>
{

}

public unsafe class AnimNode_ModifyBone : ObjectBase<FAnimNode_ModifyBone>
{

}

public unsafe class AnimNode_ModifyCurve : ObjectBase<FAnimNode_ModifyCurve>
{

}

public unsafe class AnimNode_MultiWayBlend : ObjectBase<FAnimNode_MultiWayBlend>
{

}

public unsafe class AnimNode_ObserveBone : ObjectBase<FAnimNode_ObserveBone>
{

}

public unsafe class AnimNode_PoseHandler : ObjectBase<FAnimNode_PoseHandler>
{

}

public unsafe class AnimNode_PoseBlendNode : ObjectBase<FAnimNode_PoseBlendNode>
{

}

public unsafe class AnimNode_PoseByName : ObjectBase<FAnimNode_PoseByName>
{

}

public unsafe class AnimNode_PoseDriver : ObjectBase<FAnimNode_PoseDriver>
{

}

public unsafe class RBFParams : ObjectBase<FRBFParams>
{

}

public unsafe class PoseDriverTarget : ObjectBase<FPoseDriverTarget>
{

}

public unsafe class PoseDriverTransform : ObjectBase<FPoseDriverTransform>
{

}

public unsafe class AnimNode_PoseSnapshot : ObjectBase<FAnimNode_PoseSnapshot>
{

}

public unsafe class AnimNode_RandomPlayer : ObjectBase<FAnimNode_RandomPlayer>
{

}

public unsafe class RandomPlayerSequenceEntry : ObjectBase<FRandomPlayerSequenceEntry>
{

}

public unsafe class AnimNode_MeshSpaceRefPose : ObjectBase<FAnimNode_MeshSpaceRefPose>
{
}

public unsafe class AnimNode_RefPose : ObjectBase<FAnimNode_RefPose>
{

}

public unsafe class AnimNode_ResetRoot : ObjectBase<FAnimNode_ResetRoot>
{
}

public unsafe class AnimNode_RigidBody : ObjectBase<FAnimNode_RigidBody>
{

}

public unsafe class SimSpaceSettings : ObjectBase<FSimSpaceSettings>
{

}

public unsafe class AnimNode_RotateRootBone : ObjectBase<FAnimNode_RotateRootBone>
{

}

public unsafe class AnimNode_RotationMultiplier : ObjectBase<FAnimNode_RotationMultiplier>
{

}

public unsafe class AnimNode_RotationOffsetBlendSpace : ObjectBase<FAnimNode_RotationOffsetBlendSpace>
{

}

public unsafe class AnimNode_ScaleChainLength : ObjectBase<FAnimNode_ScaleChainLength>
{

}

public unsafe class AnimNode_SequenceEvaluator : ObjectBase<FAnimNode_SequenceEvaluator>
{

}

public unsafe class AnimNode_Slot : ObjectBase<FAnimNode_Slot>
{

}

public unsafe class AnimNode_SplineIK : ObjectBase<FAnimNode_SplineIK>
{

}

public unsafe class SplineIKCachedBoneData : ObjectBase<FSplineIKCachedBoneData>
{

}

public unsafe class AnimNode_SpringBone : ObjectBase<FAnimNode_SpringBone>
{

}

public unsafe class AnimNode_StateResult : ObjectBase<FAnimNode_StateResult>
{
}

public unsafe class AnimNode_Trail : ObjectBase<FAnimNode_Trail>
{

}

public unsafe class RotationLimit : ObjectBase<FRotationLimit>
{

}

public unsafe class AnimNode_TwistCorrectiveNode : ObjectBase<FAnimNode_TwistCorrectiveNode>
{

}

public unsafe class ReferenceBoneFrame : ObjectBase<FReferenceBoneFrame>
{

}

public unsafe class AnimNode_TwoBoneIK : ObjectBase<FAnimNode_TwoBoneIK>
{

}

public unsafe class AnimNode_TwoWayBlend : ObjectBase<FAnimNode_TwoWayBlend>
{

}

public unsafe class AnimSequencerInstanceProxy : ObjectBase<FAnimSequencerInstanceProxy>
{
}

public unsafe class RBFEntry : ObjectBase<FRBFEntry>
{

}

public unsafe class RBFTarget : ObjectBase<FRBFTarget>
{

}

