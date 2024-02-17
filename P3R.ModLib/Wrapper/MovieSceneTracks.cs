using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieScenePostSpawnEventSystem : ObjectBase<UMovieScenePostSpawnEventSystem>
{
    public MovieScenePostSpawnEventSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePostEvalEventSystem : ObjectBase<UMovieScenePostEvalEventSystem>
{
    public MovieScenePostEvalEventSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEventTrack : ObjectBase<UMovieSceneEventTrack>
{
    public MovieSceneEventTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEventTriggerSection : ObjectBase<UMovieSceneEventTriggerSection>
{
    public MovieSceneEventTriggerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneFadeSection : ObjectBase<UMovieSceneFadeSection>
{
    public MovieSceneFadeSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneFloatTrack : ObjectBase<UMovieSceneFloatTrack>
{
    public MovieSceneFloatTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneFadeTrack : ObjectBase<UMovieSceneFadeTrack>
{
    public MovieSceneFadeTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneFloatPropertySystem : ObjectBase<UMovieSceneFloatPropertySystem>
{
    public MovieSceneFloatPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneFloatSection : ObjectBase<UMovieSceneFloatSection>
{
    public MovieSceneFloatSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneHierarchicalBiasSystem : ObjectBase<UMovieSceneHierarchicalBiasSystem>
{
    public MovieSceneHierarchicalBiasSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneInitialValueSystem : ObjectBase<UMovieSceneInitialValueSystem>
{
    public MovieSceneInitialValueSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneIntegerPropertySystem : ObjectBase<UMovieSceneIntegerPropertySystem>
{
    public MovieSceneIntegerPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneIntegerSection : ObjectBase<UMovieSceneIntegerSection>
{
    public MovieSceneIntegerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneIntegerTrack : ObjectBase<UMovieSceneIntegerTrack>
{
    public MovieSceneIntegerTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneInterrogatedPropertyInstantiatorSystem : ObjectBase<UMovieSceneInterrogatedPropertyInstantiatorSystem>
{
    public MovieSceneInterrogatedPropertyInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneLevelVisibilitySection : ObjectBase<UMovieSceneLevelVisibilitySection>
{
    public MovieSceneLevelVisibilitySection(IntPtr pointer) : base(pointer) {}
    public void SetVisibility(ELevelVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetVisibility"), @params);
    }
    public void SetLevelNames(ref TArray<FName> InLevelNames)
    {
        Span<(string name, object value)> @params = [
            ("InLevelNames", InLevelNames)
        ];
        ProcessEvent(GetFunction("SetLevelNames"), @params);
    }
    public ELevelVisibility GetVisibility()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ELevelVisibility>(GetFunction("GetVisibility"), @params);
    }
    public TArray<FName> GetLevelNames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetLevelNames"), @params);
    }
}

public unsafe class MovieSceneLevelVisibilitySystem : ObjectBase<UMovieSceneLevelVisibilitySystem>
{
    public MovieSceneLevelVisibilitySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneLevelVisibilityTrack : ObjectBase<UMovieSceneLevelVisibilityTrack>
{
    public MovieSceneLevelVisibilityTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMaterialTrack : ObjectBase<UMovieSceneMaterialTrack>
{
    public MovieSceneMaterialTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMaterialParameterCollectionTrack : ObjectBase<UMovieSceneMaterialParameterCollectionTrack>
{
    public MovieSceneMaterialParameterCollectionTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneComponentMaterialTrack : ObjectBase<UMovieSceneComponentMaterialTrack>
{
    public MovieSceneComponentMaterialTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMotionVectorSimulationSystem : ObjectBase<UMovieSceneMotionVectorSimulationSystem>
{
    public MovieSceneMotionVectorSimulationSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneObjectPropertySection : ObjectBase<UMovieSceneObjectPropertySection>
{
    public MovieSceneObjectPropertySection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneObjectPropertyTrack : ObjectBase<UMovieSceneObjectPropertyTrack>
{
    public MovieSceneObjectPropertyTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneParameterSection : ObjectBase<UMovieSceneParameterSection>
{
    public MovieSceneParameterSection(IntPtr pointer) : base(pointer) {}
    public bool RemoveVectorParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveVectorParameter"), @params);
    }
    public bool RemoveVector2DParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveVector2DParameter"), @params);
    }
    public bool RemoveTransformParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveTransformParameter"), @params);
    }
    public bool RemoveScalarParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveScalarParameter"), @params);
    }
    public bool RemoveColorParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveColorParameter"), @params);
    }
    public bool RemoveBoolParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveBoolParameter"), @params);
    }
    public void GetParameterNames(ref TSet<FName> ParameterNames)
    {
        Span<(string name, object value)> @params = [
            ("ParameterNames", ParameterNames)
        ];
        ProcessEvent(GetFunction("GetParameterNames"), @params);
    }
    public void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddVectorParameterKey"), @params);
    }
    public void AddVector2DParameterKey(FName InParameterName, FFrameNumber InTime, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddVector2DParameterKey"), @params);
    }
    public void AddTransformParameterKey(FName InParameterName, FFrameNumber InTime, ref FTransform inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddTransformParameterKey"), @params);
    }
    public void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddScalarParameterKey"), @params);
    }
    public void AddColorParameterKey(FName InParameterName, FFrameNumber InTime, FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddColorParameterKey"), @params);
    }
    public void AddBoolParameterKey(FName InParameterName, FFrameNumber InTime, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddBoolParameterKey"), @params);
    }
}

public unsafe class MovieSceneAudioTrack : ObjectBase<UMovieSceneAudioTrack>
{
    public MovieSceneAudioTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneParticleSection : ObjectBase<UMovieSceneParticleSection>
{
    public MovieSceneParticleSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneParticleTrack : ObjectBase<UMovieSceneParticleTrack>
{
    public MovieSceneParticleTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScenePiecewiseBoolBlenderSystem : ObjectBase<UMovieScenePiecewiseBoolBlenderSystem>
{
    public MovieScenePiecewiseBoolBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePiecewiseByteBlenderSystem : ObjectBase<UMovieScenePiecewiseByteBlenderSystem>
{
    public MovieScenePiecewiseByteBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePiecewiseEnumBlenderSystem : ObjectBase<UMovieScenePiecewiseEnumBlenderSystem>
{
    public MovieScenePiecewiseEnumBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePiecewiseFloatBlenderSystem : ObjectBase<UMovieScenePiecewiseFloatBlenderSystem>
{
    public MovieScenePiecewiseFloatBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePiecewiseIntegerBlenderSystem : ObjectBase<UMovieScenePiecewiseIntegerBlenderSystem>
{
    public MovieScenePiecewiseIntegerBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePrimitiveMaterialSection : ObjectBase<UMovieScenePrimitiveMaterialSection>
{
    public MovieScenePrimitiveMaterialSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScenePrimitiveMaterialTrack : ObjectBase<UMovieScenePrimitiveMaterialTrack>
{
    public MovieScenePrimitiveMaterialTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScenePropertyInstantiatorSystem : ObjectBase<UMovieScenePropertyInstantiatorSystem>
{
    public MovieScenePropertyInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneQuaternionInterpolationRotationSystem : ObjectBase<UMovieSceneQuaternionInterpolationRotationSystem>
{
    public MovieSceneQuaternionInterpolationRotationSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSkeletalAnimationSection : ObjectBase<UMovieSceneSkeletalAnimationSection>
{
    public MovieSceneSkeletalAnimationSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneSkeletalAnimationTrack : ObjectBase<UMovieSceneSkeletalAnimationTrack>
{
    public MovieSceneSkeletalAnimationTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneSlomoSection : ObjectBase<UMovieSceneSlomoSection>
{
    public MovieSceneSlomoSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneSlomoTrack : ObjectBase<UMovieSceneSlomoTrack>
{
    public MovieSceneSlomoTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneStringSection : ObjectBase<UMovieSceneStringSection>
{
    public MovieSceneStringSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneStringTrack : ObjectBase<UMovieSceneStringTrack>
{
    public MovieSceneStringTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneTransformOriginSystem : ObjectBase<UMovieSceneTransformOriginSystem>
{
    public MovieSceneTransformOriginSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneTransformTrack : ObjectBase<UMovieSceneTransformTrack>
{
    public MovieSceneTransformTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneVectorPropertySystem : ObjectBase<UMovieSceneVectorPropertySystem>
{
    public MovieSceneVectorPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneVectorSection : ObjectBase<UMovieSceneVectorSection>
{
    public MovieSceneVectorSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneVectorTrack : ObjectBase<UMovieSceneVectorTrack>
{
    public MovieSceneVectorTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneVisibilityTrack : ObjectBase<UMovieSceneVisibilityTrack>
{
    public MovieSceneVisibilityTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneHierarchicalEasingInstantiatorSystem : ObjectBase<UMovieSceneHierarchicalEasingInstantiatorSystem>
{
    public MovieSceneHierarchicalEasingInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class WeightAndEasingEvaluatorSystem : ObjectBase<UWeightAndEasingEvaluatorSystem>
{
    public WeightAndEasingEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneCameraShakeEvaluator : ObjectBase<UMovieSceneCameraShakeEvaluator>
{
    public MovieSceneCameraShakeEvaluator(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePropertyTrack : ObjectBase<UMovieScenePropertyTrack>
{
    public MovieScenePropertyTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class ByteChannelEvaluatorSystem : ObjectBase<UByteChannelEvaluatorSystem>
{
    public ByteChannelEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class FloatChannelEvaluatorSystem : ObjectBase<UFloatChannelEvaluatorSystem>
{
    public FloatChannelEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneTransformOrigin : ObjectBase<IMovieSceneTransformOrigin>
{
    public MovieSceneTransformOrigin(IntPtr pointer) : base(pointer) {}
    public FTransform BP_GetTransformOrigin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("BP_GetTransformOrigin"), @params);
    }
}

public unsafe class IntegerChannelEvaluatorSystem : ObjectBase<UIntegerChannelEvaluatorSystem>
{
    public IntegerChannelEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScene3DConstraintSection : ObjectBase<UMovieScene3DConstraintSection>
{
    public MovieScene3DConstraintSection(IntPtr pointer) : base(pointer) {}
    public void SetConstraintBindingID(ref FMovieSceneObjectBindingID InConstraintBindingID)
    {
        Span<(string name, object value)> @params = [
            ("InConstraintBindingID", InConstraintBindingID)
        ];
        ProcessEvent(GetFunction("SetConstraintBindingID"), @params);
    }
    public FMovieSceneObjectBindingID GetConstraintBindingID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetConstraintBindingID"), @params);
    }
}

public unsafe class MovieScene3DAttachSection : ObjectBase<UMovieScene3DAttachSection>
{
    public MovieScene3DAttachSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene3DConstraintTrack : ObjectBase<UMovieScene3DConstraintTrack>
{
    public MovieScene3DConstraintTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene3DAttachTrack : ObjectBase<UMovieScene3DAttachTrack>
{
    public MovieScene3DAttachTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScene3DPathSection : ObjectBase<UMovieScene3DPathSection>
{
    public MovieScene3DPathSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene3DPathTrack : ObjectBase<UMovieScene3DPathTrack>
{
    public MovieScene3DPathTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePropertySystem : ObjectBase<UMovieScenePropertySystem>
{
    public MovieScenePropertySystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene3DTransformPropertySystem : ObjectBase<UMovieScene3DTransformPropertySystem>
{
    public MovieScene3DTransformPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScene3DTransformSection : ObjectBase<UMovieScene3DTransformSection>
{
    public MovieScene3DTransformSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene3DTransformTrack : ObjectBase<UMovieScene3DTransformTrack>
{
    public MovieScene3DTransformTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneActorReferenceSection : ObjectBase<UMovieSceneActorReferenceSection>
{
    public MovieSceneActorReferenceSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneActorReferenceTrack : ObjectBase<UMovieSceneActorReferenceTrack>
{
    public MovieSceneActorReferenceTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneAudioSection : ObjectBase<UMovieSceneAudioSection>
{
    public MovieSceneAudioSection(IntPtr pointer) : base(pointer) {}
    public void SetStartOffset(FFrameNumber InStartOffset)
    {
        Span<(string name, object value)> @params = [
            ("InStartOffset", InStartOffset)
        ];
        ProcessEvent(GetFunction("SetStartOffset"), @params);
    }
    public void SetSound(USoundBase* InSound)
    {
        Span<(string name, object value)> @params = [
            ("InSound", (IntPtr)InSound)
        ];
        ProcessEvent(GetFunction("SetSound"), @params);
    }
    public FFrameNumber GetStartOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("GetStartOffset"), @params);
    }
    public USoundBase* GetSound()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USoundBase*)ProcessEvent<IntPtr>(GetFunction("GetSound"), @params);
    }
}

public unsafe class MovieSceneBaseValueEvaluatorSystem : ObjectBase<UMovieSceneBaseValueEvaluatorSystem>
{
    public MovieSceneBaseValueEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBoolPropertySystem : ObjectBase<UMovieSceneBoolPropertySystem>
{
    public MovieSceneBoolPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBoolTrack : ObjectBase<UMovieSceneBoolTrack>
{
    public MovieSceneBoolTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBytePropertySystem : ObjectBase<UMovieSceneBytePropertySystem>
{
    public MovieSceneBytePropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneByteSection : ObjectBase<UMovieSceneByteSection>
{
    public MovieSceneByteSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneByteTrack : ObjectBase<UMovieSceneByteTrack>
{
    public MovieSceneByteTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraAnimSection : ObjectBase<UMovieSceneCameraAnimSection>
{
    public MovieSceneCameraAnimSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraAnimTrack : ObjectBase<UMovieSceneCameraAnimTrack>
{
    public MovieSceneCameraAnimTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraCutSection : ObjectBase<UMovieSceneCameraCutSection>
{
    public MovieSceneCameraCutSection(IntPtr pointer) : base(pointer) {}
    public void SetCameraBindingID(ref FMovieSceneObjectBindingID InCameraBindingID)
    {
        Span<(string name, object value)> @params = [
            ("InCameraBindingID", InCameraBindingID)
        ];
        ProcessEvent(GetFunction("SetCameraBindingID"), @params);
    }
    public FMovieSceneObjectBindingID GetCameraBindingID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetCameraBindingID"), @params);
    }
}

public unsafe class MovieSceneCameraCutTrack : ObjectBase<UMovieSceneCameraCutTrack>
{
    public MovieSceneCameraCutTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraCutTrackInstance : ObjectBase<UMovieSceneCameraCutTrackInstance>
{
    public MovieSceneCameraCutTrackInstance(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneCameraShakeSection : ObjectBase<UMovieSceneCameraShakeSection>
{
    public MovieSceneCameraShakeSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraShakeSourceShakeSection : ObjectBase<UMovieSceneCameraShakeSourceShakeSection>
{
    public MovieSceneCameraShakeSourceShakeSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraShakeSourceShakeTrack : ObjectBase<UMovieSceneCameraShakeSourceShakeTrack>
{
    public MovieSceneCameraShakeSourceShakeTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraShakeSourceTriggerSection : ObjectBase<UMovieSceneCameraShakeSourceTriggerSection>
{
    public MovieSceneCameraShakeSourceTriggerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraShakeSourceTriggerTrack : ObjectBase<UMovieSceneCameraShakeSourceTriggerTrack>
{
    public MovieSceneCameraShakeSourceTriggerTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCameraShakeTrack : ObjectBase<UMovieSceneCameraShakeTrack>
{
    public MovieSceneCameraShakeTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneParticleParameterTrack : ObjectBase<UMovieSceneParticleParameterTrack>
{
    public MovieSceneParticleParameterTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCinematicShotSection : ObjectBase<UMovieSceneCinematicShotSection>
{
    public MovieSceneCinematicShotSection(IntPtr pointer) : base(pointer) {}
    public void SetShotDisplayName(FString InShotDisplayName)
    {
        Span<(string name, object value)> @params = [
            ("InShotDisplayName", InShotDisplayName)
        ];
        ProcessEvent(GetFunction("SetShotDisplayName"), @params);
    }
    public FString GetShotDisplayName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetShotDisplayName"), @params);
    }
}

public unsafe class MovieSceneCinematicShotTrack : ObjectBase<UMovieSceneCinematicShotTrack>
{
    public MovieSceneCinematicShotTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneColorPropertySystem : ObjectBase<UMovieSceneColorPropertySystem>
{
    public MovieSceneColorPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneColorSection : ObjectBase<UMovieSceneColorSection>
{
    public MovieSceneColorSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneColorTrack : ObjectBase<UMovieSceneColorTrack>
{
    public MovieSceneColorTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneComponentAttachmentInvalidatorSystem : ObjectBase<UMovieSceneComponentAttachmentInvalidatorSystem>
{
    public MovieSceneComponentAttachmentInvalidatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneComponentAttachmentSystem : ObjectBase<UMovieSceneComponentAttachmentSystem>
{
    public MovieSceneComponentAttachmentSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneComponentMobilitySystem : ObjectBase<UMovieSceneComponentMobilitySystem>
{
    public MovieSceneComponentMobilitySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneComponentTransformSystem : ObjectBase<UMovieSceneComponentTransformSystem>
{
    public MovieSceneComponentTransformSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneDeferredComponentMovementSystem : ObjectBase<UMovieSceneDeferredComponentMovementSystem>
{
    public MovieSceneDeferredComponentMovementSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEnumPropertySystem : ObjectBase<UMovieSceneEnumPropertySystem>
{
    public MovieSceneEnumPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEnumSection : ObjectBase<UMovieSceneEnumSection>
{
    public MovieSceneEnumSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEnumTrack : ObjectBase<UMovieSceneEnumTrack>
{
    public MovieSceneEnumTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEulerTransformPropertySystem : ObjectBase<UMovieSceneEulerTransformPropertySystem>
{
    public MovieSceneEulerTransformPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEulerTransformTrack : ObjectBase<UMovieSceneEulerTransformTrack>
{
    public MovieSceneEulerTransformTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEventSectionBase : ObjectBase<UMovieSceneEventSectionBase>
{
    public MovieSceneEventSectionBase(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEventRepeaterSection : ObjectBase<UMovieSceneEventRepeaterSection>
{
    public MovieSceneEventRepeaterSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEventSection : ObjectBase<UMovieSceneEventSection>
{
    public MovieSceneEventSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEventSystem : ObjectBase<UMovieSceneEventSystem>
{
    public MovieSceneEventSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePreSpawnEventSystem : ObjectBase<UMovieScenePreSpawnEventSystem>
{
    public MovieScenePreSpawnEventSystem(IntPtr pointer) : base(pointer) {}}

