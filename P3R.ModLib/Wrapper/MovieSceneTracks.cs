using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneEvent : ObjectBase<FMovieSceneEvent>
{

}

public unsafe class MovieSceneCameraShakeEvaluator : ObjectBase<UMovieSceneCameraShakeEvaluator>
{
}

public unsafe class MovieScenePropertyTrack : ObjectBase<UMovieScenePropertyTrack>
{

}

public unsafe class ByteChannelEvaluatorSystem : ObjectBase<UByteChannelEvaluatorSystem>
{
}

public unsafe class FloatChannelEvaluatorSystem : ObjectBase<UFloatChannelEvaluatorSystem>
{
}

public unsafe class MovieSceneTransformOrigin : ObjectBase<IMovieSceneTransformOrigin>
{

    public FTransform BP_GetTransformOrigin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("BP_GetTransformOrigin"),  @params);
    }
}

public unsafe class IntegerChannelEvaluatorSystem : ObjectBase<UIntegerChannelEvaluatorSystem>
{
}

public unsafe class MovieScene3DConstraintSection : ObjectBase<UMovieScene3DConstraintSection>
{

    public void SetConstraintBindingID(ref FMovieSceneObjectBindingID InConstraintBindingID)
    {
        Span<(string name, object value)> @params = [
            ("InConstraintBindingID", InConstraintBindingID)
        ];
        ProcessEvent(GetFunction("SetConstraintBindingID"),  @params);
    }
    public FMovieSceneObjectBindingID GetConstraintBindingID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetConstraintBindingID"),  @params);
    }
}

public unsafe class MovieScene3DAttachSection : ObjectBase<UMovieScene3DAttachSection>
{

}

public unsafe class MovieScene3DConstraintTrack : ObjectBase<UMovieScene3DConstraintTrack>
{

}

public unsafe class MovieScene3DAttachTrack : ObjectBase<UMovieScene3DAttachTrack>
{
}

public unsafe class MovieScene3DPathSection : ObjectBase<UMovieScene3DPathSection>
{

}

public unsafe class MovieScene3DPathTrack : ObjectBase<UMovieScene3DPathTrack>
{
}

public unsafe class MovieScenePropertySystem : ObjectBase<UMovieScenePropertySystem>
{

}

public unsafe class MovieScene3DTransformPropertySystem : ObjectBase<UMovieScene3DTransformPropertySystem>
{
}

public unsafe class MovieScene3DTransformSection : ObjectBase<UMovieScene3DTransformSection>
{

}

public unsafe class MovieScene3DTransformTrack : ObjectBase<UMovieScene3DTransformTrack>
{
}

public unsafe class MovieSceneActorReferenceSection : ObjectBase<UMovieSceneActorReferenceSection>
{

}

public unsafe class MovieSceneActorReferenceTrack : ObjectBase<UMovieSceneActorReferenceTrack>
{
}

public unsafe class MovieSceneAudioSection : ObjectBase<UMovieSceneAudioSection>
{

    public void SetStartOffset(FFrameNumber InStartOffset)
    {
        Span<(string name, object value)> @params = [
            ("InStartOffset", InStartOffset)
        ];
        ProcessEvent(GetFunction("SetStartOffset"),  @params);
    }
    public void SetSound(USoundBase* InSound)
    {
        Span<(string name, object value)> @params = [
            ("InSound", (IntPtr)InSound)
        ];
        ProcessEvent(GetFunction("SetSound"),  @params);
    }
    public FFrameNumber GetStartOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("GetStartOffset"),  @params);
    }
    public USoundBase* GetSound()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USoundBase*)ProcessEvent<IntPtr>(GetFunction("GetSound"),  @params);
    }
}

public unsafe class MovieSceneAudioTrack : ObjectBase<UMovieSceneAudioTrack>
{

}

public unsafe class MovieSceneBaseValueEvaluatorSystem : ObjectBase<UMovieSceneBaseValueEvaluatorSystem>
{
}

public unsafe class MovieSceneBoolPropertySystem : ObjectBase<UMovieSceneBoolPropertySystem>
{
}

public unsafe class MovieSceneBoolTrack : ObjectBase<UMovieSceneBoolTrack>
{
}

public unsafe class MovieSceneBytePropertySystem : ObjectBase<UMovieSceneBytePropertySystem>
{
}

public unsafe class MovieSceneByteSection : ObjectBase<UMovieSceneByteSection>
{

}

public unsafe class MovieSceneByteTrack : ObjectBase<UMovieSceneByteTrack>
{

}

public unsafe class MovieSceneCameraAnimSection : ObjectBase<UMovieSceneCameraAnimSection>
{

}

public unsafe class MovieSceneCameraAnimTrack : ObjectBase<UMovieSceneCameraAnimTrack>
{

}

public unsafe class MovieSceneCameraCutSection : ObjectBase<UMovieSceneCameraCutSection>
{

    public void SetCameraBindingID(ref FMovieSceneObjectBindingID InCameraBindingID)
    {
        Span<(string name, object value)> @params = [
            ("InCameraBindingID", InCameraBindingID)
        ];
        ProcessEvent(GetFunction("SetCameraBindingID"),  @params);
    }
    public FMovieSceneObjectBindingID GetCameraBindingID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetCameraBindingID"),  @params);
    }
}

public unsafe class MovieSceneCameraCutTrack : ObjectBase<UMovieSceneCameraCutTrack>
{

}

public unsafe class MovieSceneCameraCutTrackInstance : ObjectBase<UMovieSceneCameraCutTrackInstance>
{
}

public unsafe class MovieSceneCameraShakeSection : ObjectBase<UMovieSceneCameraShakeSection>
{

}

public unsafe class MovieSceneCameraShakeSourceShakeSection : ObjectBase<UMovieSceneCameraShakeSourceShakeSection>
{

}

public unsafe class MovieSceneCameraShakeSourceShakeTrack : ObjectBase<UMovieSceneCameraShakeSourceShakeTrack>
{

}

public unsafe class MovieSceneCameraShakeSourceTriggerSection : ObjectBase<UMovieSceneCameraShakeSourceTriggerSection>
{

}

public unsafe class MovieSceneCameraShakeSourceTriggerTrack : ObjectBase<UMovieSceneCameraShakeSourceTriggerTrack>
{

}

public unsafe class MovieSceneCameraShakeTrack : ObjectBase<UMovieSceneCameraShakeTrack>
{

}

public unsafe class MovieSceneCinematicShotSection : ObjectBase<UMovieSceneCinematicShotSection>
{

    public void SetShotDisplayName(FString InShotDisplayName)
    {
        Span<(string name, object value)> @params = [
            ("InShotDisplayName", InShotDisplayName)
        ];
        ProcessEvent(GetFunction("SetShotDisplayName"),  @params);
    }
    public FString GetShotDisplayName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetShotDisplayName"),  @params);
    }
}

public unsafe class MovieSceneCinematicShotTrack : ObjectBase<UMovieSceneCinematicShotTrack>
{
}

public unsafe class MovieSceneColorPropertySystem : ObjectBase<UMovieSceneColorPropertySystem>
{
}

public unsafe class MovieSceneColorSection : ObjectBase<UMovieSceneColorSection>
{

}

public unsafe class MovieSceneColorTrack : ObjectBase<UMovieSceneColorTrack>
{

}

public unsafe class MovieSceneComponentAttachmentInvalidatorSystem : ObjectBase<UMovieSceneComponentAttachmentInvalidatorSystem>
{
}

public unsafe class MovieSceneComponentAttachmentSystem : ObjectBase<UMovieSceneComponentAttachmentSystem>
{
}

public unsafe class MovieSceneComponentMobilitySystem : ObjectBase<UMovieSceneComponentMobilitySystem>
{
}

public unsafe class MovieSceneComponentTransformSystem : ObjectBase<UMovieSceneComponentTransformSystem>
{
}

public unsafe class MovieSceneDeferredComponentMovementSystem : ObjectBase<UMovieSceneDeferredComponentMovementSystem>
{
}

public unsafe class MovieSceneEnumPropertySystem : ObjectBase<UMovieSceneEnumPropertySystem>
{
}

public unsafe class MovieSceneEnumSection : ObjectBase<UMovieSceneEnumSection>
{

}

public unsafe class MovieSceneEnumTrack : ObjectBase<UMovieSceneEnumTrack>
{

}

public unsafe class MovieSceneEulerTransformPropertySystem : ObjectBase<UMovieSceneEulerTransformPropertySystem>
{
}

public unsafe class MovieSceneEulerTransformTrack : ObjectBase<UMovieSceneEulerTransformTrack>
{
}

public unsafe class MovieSceneEventSectionBase : ObjectBase<UMovieSceneEventSectionBase>
{
}

public unsafe class MovieSceneEventRepeaterSection : ObjectBase<UMovieSceneEventRepeaterSection>
{

}

public unsafe class MovieSceneEventSection : ObjectBase<UMovieSceneEventSection>
{

}

public unsafe class MovieSceneEventSystem : ObjectBase<UMovieSceneEventSystem>
{
}

public unsafe class MovieScenePreSpawnEventSystem : ObjectBase<UMovieScenePreSpawnEventSystem>
{
}

public unsafe class MovieScenePostSpawnEventSystem : ObjectBase<UMovieScenePostSpawnEventSystem>
{
}

public unsafe class MovieScenePostEvalEventSystem : ObjectBase<UMovieScenePostEvalEventSystem>
{
}

public unsafe class MovieSceneEventTrack : ObjectBase<UMovieSceneEventTrack>
{

}

public unsafe class MovieSceneEventTriggerSection : ObjectBase<UMovieSceneEventTriggerSection>
{

}

public unsafe class MovieSceneFadeSection : ObjectBase<UMovieSceneFadeSection>
{

}

public unsafe class MovieSceneFloatTrack : ObjectBase<UMovieSceneFloatTrack>
{
}

public unsafe class MovieSceneFadeTrack : ObjectBase<UMovieSceneFadeTrack>
{
}

public unsafe class MovieSceneFloatPropertySystem : ObjectBase<UMovieSceneFloatPropertySystem>
{
}

public unsafe class MovieSceneFloatSection : ObjectBase<UMovieSceneFloatSection>
{

}

public unsafe class MovieSceneHierarchicalBiasSystem : ObjectBase<UMovieSceneHierarchicalBiasSystem>
{
}

public unsafe class MovieSceneInitialValueSystem : ObjectBase<UMovieSceneInitialValueSystem>
{
}

public unsafe class MovieSceneIntegerPropertySystem : ObjectBase<UMovieSceneIntegerPropertySystem>
{
}

public unsafe class MovieSceneIntegerSection : ObjectBase<UMovieSceneIntegerSection>
{

}

public unsafe class MovieSceneIntegerTrack : ObjectBase<UMovieSceneIntegerTrack>
{
}

public unsafe class MovieSceneInterrogatedPropertyInstantiatorSystem : ObjectBase<UMovieSceneInterrogatedPropertyInstantiatorSystem>
{
}

public unsafe class MovieSceneLevelVisibilitySection : ObjectBase<UMovieSceneLevelVisibilitySection>
{

    public void SetVisibility(ELevelVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetVisibility"),  @params);
    }
    public void SetLevelNames(ref TArray<FName> InLevelNames)
    {
        Span<(string name, object value)> @params = [
            ("InLevelNames", InLevelNames)
        ];
        ProcessEvent(GetFunction("SetLevelNames"),  @params);
    }
    public ELevelVisibility GetVisibility()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ELevelVisibility>(GetFunction("GetVisibility"),  @params);
    }
    public TArray<FName> GetLevelNames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetLevelNames"),  @params);
    }
}

public unsafe class MovieSceneLevelVisibilitySystem : ObjectBase<UMovieSceneLevelVisibilitySystem>
{
}

public unsafe class MovieSceneLevelVisibilityTrack : ObjectBase<UMovieSceneLevelVisibilityTrack>
{

}

public unsafe class MovieSceneMaterialTrack : ObjectBase<UMovieSceneMaterialTrack>
{

}

public unsafe class MovieSceneMaterialParameterCollectionTrack : ObjectBase<UMovieSceneMaterialParameterCollectionTrack>
{

}

public unsafe class MovieSceneComponentMaterialTrack : ObjectBase<UMovieSceneComponentMaterialTrack>
{

}

public unsafe class MovieSceneMotionVectorSimulationSystem : ObjectBase<UMovieSceneMotionVectorSimulationSystem>
{
}

public unsafe class MovieSceneObjectPropertySection : ObjectBase<UMovieSceneObjectPropertySection>
{

}

public unsafe class MovieSceneObjectPropertyTrack : ObjectBase<UMovieSceneObjectPropertyTrack>
{

}

public unsafe class MovieSceneParameterSection : ObjectBase<UMovieSceneParameterSection>
{

    public bool RemoveVectorParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveVectorParameter"),  @params);
    }
    public bool RemoveVector2DParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveVector2DParameter"),  @params);
    }
    public bool RemoveTransformParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveTransformParameter"),  @params);
    }
    public bool RemoveScalarParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveScalarParameter"),  @params);
    }
    public bool RemoveColorParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveColorParameter"),  @params);
    }
    public bool RemoveBoolParameter(FName InParameterName)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveBoolParameter"),  @params);
    }
    public void GetParameterNames(ref TSet<FName> ParameterNames)
    {
        Span<(string name, object value)> @params = [
            ("ParameterNames", ParameterNames)
        ];
        ProcessEvent(GetFunction("GetParameterNames"),  @params);
    }
    public void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddVectorParameterKey"),  @params);
    }
    public void AddVector2DParameterKey(FName InParameterName, FFrameNumber InTime, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddVector2DParameterKey"),  @params);
    }
    public void AddTransformParameterKey(FName InParameterName, FFrameNumber InTime, ref FTransform inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddTransformParameterKey"),  @params);
    }
    public void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddScalarParameterKey"),  @params);
    }
    public void AddColorParameterKey(FName InParameterName, FFrameNumber InTime, FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddColorParameterKey"),  @params);
    }
    public void AddBoolParameterKey(FName InParameterName, FFrameNumber InTime, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InParameterName", InParameterName), 
            ("InTime", InTime), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("AddBoolParameterKey"),  @params);
    }
}

public unsafe class MovieSceneParticleParameterTrack : ObjectBase<UMovieSceneParticleParameterTrack>
{

}

public unsafe class MovieSceneParticleSection : ObjectBase<UMovieSceneParticleSection>
{

}

public unsafe class MovieSceneParticleTrack : ObjectBase<UMovieSceneParticleTrack>
{

}

public unsafe class MovieScenePiecewiseBoolBlenderSystem : ObjectBase<UMovieScenePiecewiseBoolBlenderSystem>
{
}

public unsafe class MovieScenePiecewiseByteBlenderSystem : ObjectBase<UMovieScenePiecewiseByteBlenderSystem>
{
}

public unsafe class MovieScenePiecewiseEnumBlenderSystem : ObjectBase<UMovieScenePiecewiseEnumBlenderSystem>
{
}

public unsafe class MovieScenePiecewiseFloatBlenderSystem : ObjectBase<UMovieScenePiecewiseFloatBlenderSystem>
{
}

public unsafe class MovieScenePiecewiseIntegerBlenderSystem : ObjectBase<UMovieScenePiecewiseIntegerBlenderSystem>
{
}

public unsafe class MovieScenePrimitiveMaterialSection : ObjectBase<UMovieScenePrimitiveMaterialSection>
{

}

public unsafe class MovieScenePrimitiveMaterialTrack : ObjectBase<UMovieScenePrimitiveMaterialTrack>
{

}

public unsafe class MovieScenePropertyInstantiatorSystem : ObjectBase<UMovieScenePropertyInstantiatorSystem>
{
}

public unsafe class MovieSceneQuaternionInterpolationRotationSystem : ObjectBase<UMovieSceneQuaternionInterpolationRotationSystem>
{
}

public unsafe class MovieSceneSkeletalAnimationSection : ObjectBase<UMovieSceneSkeletalAnimationSection>
{

}

public unsafe class MovieSceneSkeletalAnimationTrack : ObjectBase<UMovieSceneSkeletalAnimationTrack>
{

}

public unsafe class MovieSceneSlomoSection : ObjectBase<UMovieSceneSlomoSection>
{

}

public unsafe class MovieSceneSlomoTrack : ObjectBase<UMovieSceneSlomoTrack>
{
}

public unsafe class MovieSceneStringSection : ObjectBase<UMovieSceneStringSection>
{

}

public unsafe class MovieSceneStringTrack : ObjectBase<UMovieSceneStringTrack>
{
}

public unsafe class MovieSceneTransformOriginSystem : ObjectBase<UMovieSceneTransformOriginSystem>
{
}

public unsafe class MovieSceneTransformTrack : ObjectBase<UMovieSceneTransformTrack>
{
}

public unsafe class MovieSceneVectorPropertySystem : ObjectBase<UMovieSceneVectorPropertySystem>
{
}

public unsafe class MovieSceneVectorSection : ObjectBase<UMovieSceneVectorSection>
{

}

public unsafe class MovieSceneVectorTrack : ObjectBase<UMovieSceneVectorTrack>
{

}

public unsafe class MovieSceneVisibilityTrack : ObjectBase<UMovieSceneVisibilityTrack>
{
}

public unsafe class MovieSceneHierarchicalEasingInstantiatorSystem : ObjectBase<UMovieSceneHierarchicalEasingInstantiatorSystem>
{
}

public unsafe class WeightAndEasingEvaluatorSystem : ObjectBase<UWeightAndEasingEvaluatorSystem>
{
}

public unsafe class MovieScene3DPathSectionTemplate : ObjectBase<FMovieScene3DPathSectionTemplate>
{

}

public unsafe class MovieSceneTransformMask : ObjectBase<FMovieSceneTransformMask>
{

}

public unsafe class MovieScene3DTransformKeyStruct : ObjectBase<FMovieScene3DTransformKeyStruct>
{

}

public unsafe class MovieScene3DScaleKeyStruct : ObjectBase<FMovieScene3DScaleKeyStruct>
{

}

public unsafe class MovieScene3DRotationKeyStruct : ObjectBase<FMovieScene3DRotationKeyStruct>
{

}

public unsafe class MovieScene3DLocationKeyStruct : ObjectBase<FMovieScene3DLocationKeyStruct>
{

}

public unsafe class MovieSceneActorReferenceData : ObjectBase<FMovieSceneActorReferenceData>
{

}

public unsafe class MovieSceneActorReferenceKey : ObjectBase<FMovieSceneActorReferenceKey>
{

}

public unsafe class MovieSceneActorReferenceSectionTemplate : ObjectBase<FMovieSceneActorReferenceSectionTemplate>
{

}

public unsafe class MovieSceneAudioSectionTemplate : ObjectBase<FMovieSceneAudioSectionTemplate>
{

}

public unsafe class MovieSceneCameraAnimSectionData : ObjectBase<FMovieSceneCameraAnimSectionData>
{

}

public unsafe class MovieSceneCameraAnimSectionTemplate : ObjectBase<FMovieSceneCameraAnimSectionTemplate>
{

}

public unsafe class MovieSceneCameraShakeSectionData : ObjectBase<FMovieSceneCameraShakeSectionData>
{

}

public unsafe class MovieSceneCameraShakeSourceShakeSectionTemplate : ObjectBase<FMovieSceneCameraShakeSourceShakeSectionTemplate>
{

}

public unsafe class MovieSceneCameraShakeSourceTriggerChannel : ObjectBase<FMovieSceneCameraShakeSourceTriggerChannel>
{

}

public unsafe class MovieSceneCameraShakeSourceTrigger : ObjectBase<FMovieSceneCameraShakeSourceTrigger>
{

}

public unsafe class MovieSceneCameraShakeSourceTriggerSectionTemplate : ObjectBase<FMovieSceneCameraShakeSourceTriggerSectionTemplate>
{

}

public unsafe class MovieSceneCameraShakeSectionTemplate : ObjectBase<FMovieSceneCameraShakeSectionTemplate>
{

}

public unsafe class MovieSceneColorKeyStruct : ObjectBase<FMovieSceneColorKeyStruct>
{

}

public unsafe class MovieSceneColorSectionTemplate : ObjectBase<FMovieSceneColorSectionTemplate>
{

}

public unsafe class MovieSceneEventPtrs : ObjectBase<FMovieSceneEventPtrs>
{

}

public unsafe class MovieSceneEventPayloadVariable : ObjectBase<FMovieSceneEventPayloadVariable>
{

}

public unsafe class MovieSceneEventChannel : ObjectBase<FMovieSceneEventChannel>
{

}

public unsafe class MovieSceneEventSectionData : ObjectBase<FMovieSceneEventSectionData>
{

}

public unsafe class EventPayload : ObjectBase<FEventPayload>
{

}

public unsafe class MovieSceneEventParameters : ObjectBase<FMovieSceneEventParameters>
{
}

public unsafe class MovieSceneEventTriggerData : ObjectBase<FMovieSceneEventTriggerData>
{

}

public unsafe class MovieSceneEventSectionTemplate : ObjectBase<FMovieSceneEventSectionTemplate>
{

}

public unsafe class MovieSceneFadeSectionTemplate : ObjectBase<FMovieSceneFadeSectionTemplate>
{

}

public unsafe class MovieSceneParameterSectionTemplate : ObjectBase<FMovieSceneParameterSectionTemplate>
{

}

public unsafe class TransformParameterNameAndCurves : ObjectBase<FTransformParameterNameAndCurves>
{

}

public unsafe class ColorParameterNameAndCurves : ObjectBase<FColorParameterNameAndCurves>
{

}

public unsafe class VectorParameterNameAndCurves : ObjectBase<FVectorParameterNameAndCurves>
{

}

public unsafe class Vector2DParameterNameAndCurves : ObjectBase<FVector2DParameterNameAndCurves>
{

}

public unsafe class BoolParameterNameAndCurve : ObjectBase<FBoolParameterNameAndCurve>
{

}

public unsafe class ScalarParameterNameAndCurve : ObjectBase<FScalarParameterNameAndCurve>
{

}

public unsafe class MovieSceneMaterialParameterCollectionTemplate : ObjectBase<FMovieSceneMaterialParameterCollectionTemplate>
{

}

public unsafe class MovieSceneObjectPropertyTemplate : ObjectBase<FMovieSceneObjectPropertyTemplate>
{

}

public unsafe class MovieSceneComponentMaterialSectionTemplate : ObjectBase<FMovieSceneComponentMaterialSectionTemplate>
{

}

public unsafe class MovieSceneParticleParameterSectionTemplate : ObjectBase<FMovieSceneParticleParameterSectionTemplate>
{
}

public unsafe class MovieSceneParticleChannel : ObjectBase<FMovieSceneParticleChannel>
{
}

public unsafe class MovieSceneParticleSectionTemplate : ObjectBase<FMovieSceneParticleSectionTemplate>
{

}

public unsafe class MovieScenePrimitiveMaterialTemplate : ObjectBase<FMovieScenePrimitiveMaterialTemplate>
{

}

public unsafe class MovieSceneStringPropertySectionTemplate : ObjectBase<FMovieSceneStringPropertySectionTemplate>
{

}

public unsafe class MovieSceneStringChannel : ObjectBase<FMovieSceneStringChannel>
{

}

public unsafe class MovieSceneBoolPropertySectionTemplate : ObjectBase<FMovieSceneBoolPropertySectionTemplate>
{

}

public unsafe class MovieSceneSkeletalAnimationParams : ObjectBase<FMovieSceneSkeletalAnimationParams>
{

}

public unsafe class MovieSceneSkeletalAnimationSectionTemplate : ObjectBase<FMovieSceneSkeletalAnimationSectionTemplate>
{

}

public unsafe class MovieSceneSkeletalAnimationSectionTemplateParameters : ObjectBase<FMovieSceneSkeletalAnimationSectionTemplateParameters>
{

}

public unsafe class MovieSceneSkeletalAnimRootMotionTrackParams : ObjectBase<FMovieSceneSkeletalAnimRootMotionTrackParams>
{
}

public unsafe class MovieSceneSlomoSectionTemplate : ObjectBase<FMovieSceneSlomoSectionTemplate>
{

}

public unsafe class LevelVisibilityComponentData : ObjectBase<FLevelVisibilityComponentData>
{

}

public unsafe class MovieSceneVectorKeyStructBase : ObjectBase<FMovieSceneVectorKeyStructBase>
{

}

public unsafe class MovieSceneVector4KeyStruct : ObjectBase<FMovieSceneVector4KeyStruct>
{

}

public unsafe class MovieSceneVectorKeyStruct : ObjectBase<FMovieSceneVectorKeyStruct>
{

}

public unsafe class MovieSceneVector2DKeyStruct : ObjectBase<FMovieSceneVector2DKeyStruct>
{

}

public unsafe class MovieSceneVisibilitySectionTemplate : ObjectBase<FMovieSceneVisibilitySectionTemplate>
{
}

