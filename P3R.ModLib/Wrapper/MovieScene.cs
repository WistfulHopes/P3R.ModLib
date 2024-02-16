using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneSignedObject : ObjectBase<UMovieSceneSignedObject>
{

}

public unsafe class MovieSceneTrack : ObjectBase<UMovieSceneTrack>
{

}

public unsafe class MovieSceneNameableTrack : ObjectBase<UMovieSceneNameableTrack>
{
}

public unsafe class OptionalMovieSceneBlendType : ObjectBase<FOptionalMovieSceneBlendType>
{

}

public unsafe class MovieSceneSection : ObjectBase<UMovieSceneSection>
{

    public void SetRowIndex(int NewRowIndex)
    {
        Span<(string name, object value)> @params = [
            ("NewRowIndex", NewRowIndex)
        ];
        ProcessEvent(GetFunction("SetRowIndex"),  @params);
    }
    public void SetPreRollFrames(int InPreRollFrames)
    {
        Span<(string name, object value)> @params = [
            ("InPreRollFrames", InPreRollFrames)
        ];
        ProcessEvent(GetFunction("SetPreRollFrames"),  @params);
    }
    public void SetPostRollFrames(int InPostRollFrames)
    {
        Span<(string name, object value)> @params = [
            ("InPostRollFrames", InPostRollFrames)
        ];
        ProcessEvent(GetFunction("SetPostRollFrames"),  @params);
    }
    public void SetOverlapPriority(int NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetOverlapPriority"),  @params);
    }
    public void SetIsLocked(bool bInIsLocked)
    {
        Span<(string name, object value)> @params = [
            ("bInIsLocked", bInIsLocked)
        ];
        ProcessEvent(GetFunction("SetIsLocked"),  @params);
    }
    public void SetIsActive(bool bInIsActive)
    {
        Span<(string name, object value)> @params = [
            ("bInIsActive", bInIsActive)
        ];
        ProcessEvent(GetFunction("SetIsActive"),  @params);
    }
    public void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode)
    {
        Span<(string name, object value)> @params = [
            ("InCompletionMode", InCompletionMode)
        ];
        ProcessEvent(GetFunction("SetCompletionMode"),  @params);
    }
    public void SetBlendType(EMovieSceneBlendType InBlendType)
    {
        Span<(string name, object value)> @params = [
            ("InBlendType", InBlendType)
        ];
        ProcessEvent(GetFunction("SetBlendType"),  @params);
    }
    public bool IsLocked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLocked"),  @params);
    }
    public bool IsActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsActive"),  @params);
    }
    public int GetRowIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetRowIndex"),  @params);
    }
    public int GetPreRollFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPreRollFrames"),  @params);
    }
    public int GetPostRollFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPostRollFrames"),  @params);
    }
    public int GetOverlapPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetOverlapPriority"),  @params);
    }
    public EMovieSceneCompletionMode GetCompletionMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMovieSceneCompletionMode>(GetFunction("GetCompletionMode"),  @params);
    }
    public FOptionalMovieSceneBlendType GetBlendType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FOptionalMovieSceneBlendType>(GetFunction("GetBlendType"),  @params);
    }
}

public unsafe class MovieSceneObjectBindingID : ObjectBase<FMovieSceneObjectBindingID>
{

}

public unsafe class MovieSceneMarkedFrame : ObjectBase<FMovieSceneMarkedFrame>
{

}

public unsafe class MovieSceneSequence : ObjectBase<UMovieSceneSequence>
{

    public TArray<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
    {
        Span<(string name, object value)> @params = [
            ("InBindingName", InBindingName)
        ];
        return ProcessEvent<TArray<FMovieSceneObjectBindingID>>(GetFunction("FindBindingsByTag"),  @params);
    }
    public FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
    {
        Span<(string name, object value)> @params = [
            ("InBindingName", InBindingName)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("FindBindingByTag"),  @params);
    }
}

public unsafe class MovieSceneSequencePlaybackParams : ObjectBase<FMovieSceneSequencePlaybackParams>
{

}

public unsafe class MovieSceneSequencePlayer : ObjectBase<UMovieSceneSequencePlayer>
{

    public void StopAtCurrentTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAtCurrentTime"),  @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"),  @params);
    }
    public void SetTimeRange(float StartTime, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("StartTime", StartTime), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("SetTimeRange"),  @params);
    }
    public void SetPlayRate(float PlayRate)
    {
        Span<(string name, object value)> @params = [
            ("PlayRate", PlayRate)
        ];
        ProcessEvent(GetFunction("SetPlayRate"),  @params);
    }
    public void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
    {
        Span<(string name, object value)> @params = [
            ("PlaybackParams", PlaybackParams)
        ];
        ProcessEvent(GetFunction("SetPlaybackPosition"),  @params);
    }
    public void SetFrameRate(FFrameRate FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("FrameRate", FrameRate)
        ];
        ProcessEvent(GetFunction("SetFrameRate"),  @params);
    }
    public void SetFrameRange(int StartFrame, int Duration, float SubFrames)
    {
        Span<(string name, object value)> @params = [
            ("StartFrame", StartFrame), 
            ("Duration", Duration), 
            ("SubFrames", SubFrames)
        ];
        ProcessEvent(GetFunction("SetFrameRange"),  @params);
    }
    public void SetDisableCameraCuts(bool bInDisableCameraCuts)
    {
        Span<(string name, object value)> @params = [
            ("bInDisableCameraCuts", bInDisableCameraCuts)
        ];
        ProcessEvent(GetFunction("SetDisableCameraCuts"),  @params);
    }
    public void ScrubToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("ScrubToSeconds"),  @params);
    }
    public bool ScrubToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("ScrubToMarkedFrame"),  @params);
    }
    public void ScrubToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("ScrubToFrame"),  @params);
    }
    public void Scrub()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Scrub"),  @params);
    }
    public void RPC_OnStopEvent(FFrameTime StoppedTime)
    {
        Span<(string name, object value)> @params = [
            ("StoppedTime", StoppedTime)
        ];
        ProcessEvent(GetFunction("RPC_OnStopEvent"),  @params);
    }
    public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FFrameTime RelevantTime)
    {
        Span<(string name, object value)> @params = [
            ("Method", Method), 
            ("RelevantTime", RelevantTime)
        ];
        ProcessEvent(GetFunction("RPC_ExplicitServerUpdateEvent"),  @params);
    }
    public void RestoreState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestoreState"),  @params);
    }
    public void PlayToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("PlayToSeconds"),  @params);
    }
    public bool PlayToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("PlayToMarkedFrame"),  @params);
    }
    public void PlayToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("PlayToFrame"),  @params);
    }
    public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
    {
        Span<(string name, object value)> @params = [
            ("PlaybackParams", PlaybackParams)
        ];
        ProcessEvent(GetFunction("PlayTo"),  @params);
    }
    public void PlayReverse()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayReverse"),  @params);
    }
    public void PlayLooping(int NumLoops)
    {
        Span<(string name, object value)> @params = [
            ("NumLoops", NumLoops)
        ];
        ProcessEvent(GetFunction("PlayLooping"),  @params);
    }
    public void Play()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Play"),  @params);
    }
    public void Pause()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Pause"),  @params);
    }
    public void JumpToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("JumpToSeconds"),  @params);
    }
    public bool JumpToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("JumpToMarkedFrame"),  @params);
    }
    public void JumpToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("JumpToFrame"),  @params);
    }
    public bool IsReversed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReversed"),  @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"),  @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"),  @params);
    }
    public void GoToEndAndStop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GoToEndAndStop"),  @params);
    }
    public FQualifiedFrameTime GetStartTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetStartTime"),  @params);
    }
    public UMovieSceneSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
    public float GetPlayRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayRate"),  @params);
    }
    public TArray<FMovieSceneObjectBindingID> GetObjectBindings(UObject* InObject)
    {
        Span<(string name, object value)> @params = [
            ("InObject", (IntPtr)InObject)
        ];
        return ProcessEvent<TArray<FMovieSceneObjectBindingID>>(GetFunction("GetObjectBindings"),  @params);
    }
    public FFrameRate GetFrameRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameRate>(GetFunction("GetFrameRate"),  @params);
    }
    public int GetFrameDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFrameDuration"),  @params);
    }
    public FQualifiedFrameTime GetEndTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetEndTime"),  @params);
    }
    public FQualifiedFrameTime GetDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetDuration"),  @params);
    }
    public bool GetDisableCameraCuts()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetDisableCameraCuts"),  @params);
    }
    public FQualifiedFrameTime GetCurrentTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetCurrentTime"),  @params);
    }
    public TArray<IntPtr> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetBoundObjects"),  @params);
    }
    public void ChangePlaybackDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangePlaybackDirection"),  @params);
    }
}

public unsafe class MovieSceneSequencePlaybackSettings : ObjectBase<FMovieSceneSequencePlaybackSettings>
{

}

public unsafe class MovieSceneSubSection : ObjectBase<UMovieSceneSubSection>
{

    public void SetSequence(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        ProcessEvent(GetFunction("SetSequence"),  @params);
    }
    public UMovieSceneSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
}

public unsafe class MovieSceneEntitySystem : ObjectBase<UMovieSceneEntitySystem>
{

}

public unsafe class MovieSceneSubTrack : ObjectBase<UMovieSceneSubTrack>
{

}

public unsafe class MovieSceneCustomClockSource : ObjectBase<IMovieSceneCustomClockSource>
{

    public void OnTick(float DeltaSeconds, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds), 
            ("InPlayRate", InPlayRate)
        ];
        ProcessEvent(GetFunction("OnTick"),  @params);
    }
    public void OnStopPlaying(ref FQualifiedFrameTime InStopTime)
    {
        Span<(string name, object value)> @params = [
            ("InStopTime", InStopTime)
        ];
        ProcessEvent(GetFunction("OnStopPlaying"),  @params);
    }
    public void OnStartPlaying(ref FQualifiedFrameTime InStartTime)
    {
        Span<(string name, object value)> @params = [
            ("InStartTime", InStartTime)
        ];
        ProcessEvent(GetFunction("OnStartPlaying"),  @params);
    }
    public FFrameTime OnRequestCurrentTime(ref FQualifiedFrameTime InCurrentTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("InCurrentTime", InCurrentTime), 
            ("InPlayRate", InPlayRate)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("OnRequestCurrentTime"),  @params);
    }
}

public unsafe class MovieSceneDeterminismSource : ObjectBase<IMovieSceneDeterminismSource>
{
}

public unsafe class MovieSceneEntityProvider : ObjectBase<IMovieSceneEntityProvider>
{
}

public unsafe class MovieSceneEvaluationHook : ObjectBase<IMovieSceneEvaluationHook>
{
}

public unsafe class MovieScenePlaybackClient : ObjectBase<IMovieScenePlaybackClient>
{
}

public unsafe class MovieSceneTrackTemplateProducer : ObjectBase<IMovieSceneTrackTemplateProducer>
{
}

public unsafe class NodeAndChannelMappings : ObjectBase<INodeAndChannelMappings>
{
}

public unsafe class MovieSceneNodeGroup : ObjectBase<UMovieSceneNodeGroup>
{
}

public unsafe class MovieSceneNodeGroupCollection : ObjectBase<UMovieSceneNodeGroupCollection>
{
}

public unsafe class MovieScene : ObjectBase<UMovieScene>
{

}

public unsafe class MovieSceneBindingOverrides : ObjectBase<UMovieSceneBindingOverrides>
{

}

public unsafe class MovieSceneBindingOwnerInterface : ObjectBase<IMovieSceneBindingOwnerInterface>
{
}

public unsafe class MovieSceneBlenderSystem : ObjectBase<UMovieSceneBlenderSystem>
{
}

public unsafe class MovieSceneBoolSection : ObjectBase<UMovieSceneBoolSection>
{

}

public unsafe class MovieSceneEntityInstantiatorSystem : ObjectBase<UMovieSceneEntityInstantiatorSystem>
{
}

public unsafe class MovieSceneGenericBoundObjectInstantiator : ObjectBase<UMovieSceneGenericBoundObjectInstantiator>
{
}

public unsafe class MovieSceneBoundSceneComponentInstantiator : ObjectBase<UMovieSceneBoundSceneComponentInstantiator>
{
}

public unsafe class MovieSceneSceneComponentImpersonator : ObjectBase<IMovieSceneSceneComponentImpersonator>
{
}

public unsafe class MovieSceneCompiledData : ObjectBase<UMovieSceneCompiledData>
{

}

public unsafe class MovieSceneCompiledDataManager : ObjectBase<UMovieSceneCompiledDataManager>
{

}

public unsafe class MovieSceneFloatDecomposer : ObjectBase<IMovieSceneFloatDecomposer>
{
}

public unsafe class MovieSceneBuiltInEasingFunction : ObjectBase<UMovieSceneBuiltInEasingFunction>
{

}

public unsafe class MovieSceneEasingExternalCurve : ObjectBase<UMovieSceneEasingExternalCurve>
{

}

public unsafe class MovieSceneEasingFunction : ObjectBase<IMovieSceneEasingFunction>
{

    public float OnEvaluate(float Interp)
    {
        Span<(string name, object value)> @params = [
            ("Interp", Interp)
        ];
        return ProcessEvent<float>(GetFunction("OnEvaluate"),  @params);
    }
}

public unsafe class MovieSceneEntitySystemLinker : ObjectBase<UMovieSceneEntitySystemLinker>
{

}

public unsafe class MovieSceneEvalTimeSystem : ObjectBase<UMovieSceneEvalTimeSystem>
{
}

public unsafe class MovieSceneEvaluationHookSystem : ObjectBase<UMovieSceneEvaluationHookSystem>
{

}

public unsafe class MovieSceneFolder : ObjectBase<UMovieSceneFolder>
{

}

public unsafe class MovieSceneHookSection : ObjectBase<UMovieSceneHookSection>
{

}

public unsafe class MovieSceneKeyProxy : ObjectBase<IMovieSceneKeyProxy>
{
}

public unsafe class MovieSceneMasterInstantiatorSystem : ObjectBase<UMovieSceneMasterInstantiatorSystem>
{
}

public unsafe class MovieScenePreAnimatedStateSystemInterface : ObjectBase<IMovieScenePreAnimatedStateSystemInterface>
{
}

public unsafe class MovieSceneCachePreAnimatedStateSystem : ObjectBase<UMovieSceneCachePreAnimatedStateSystem>
{
}

public unsafe class MovieSceneRestorePreAnimatedStateSystem : ObjectBase<UMovieSceneRestorePreAnimatedStateSystem>
{
}

public unsafe class MovieSceneSequenceActor : ObjectBase<IMovieSceneSequenceActor>
{
}

public unsafe class MovieSceneSequenceTickManager : ObjectBase<UMovieSceneSequenceTickManager>
{

}

public unsafe class MovieSceneSpawnablesSystem : ObjectBase<UMovieSceneSpawnablesSystem>
{
}

public unsafe class MovieSceneSpawnSection : ObjectBase<UMovieSceneSpawnSection>
{
}

public unsafe class MovieSceneSpawnTrack : ObjectBase<UMovieSceneSpawnTrack>
{

}

public unsafe class TestMovieSceneTrack : ObjectBase<UTestMovieSceneTrack>
{

}

public unsafe class TestMovieSceneSection : ObjectBase<UTestMovieSceneSection>
{
}

public unsafe class TestMovieSceneSequence : ObjectBase<UTestMovieSceneSequence>
{

}

public unsafe class TestMovieSceneSubTrack : ObjectBase<UTestMovieSceneSubTrack>
{

}

public unsafe class TestMovieSceneSubSection : ObjectBase<UTestMovieSceneSubSection>
{
}

public unsafe class TestMovieSceneEvalHookTrack : ObjectBase<UTestMovieSceneEvalHookTrack>
{

}

public unsafe class TestMovieSceneEvalHookSection : ObjectBase<UTestMovieSceneEvalHookSection>
{
}

public unsafe class MovieSceneTrackInstance : ObjectBase<UMovieSceneTrackInstance>
{

}

public unsafe class MovieSceneTrackInstanceInstantiator : ObjectBase<UMovieSceneTrackInstanceInstantiator>
{
}

public unsafe class MovieSceneTrackInstanceSystem : ObjectBase<UMovieSceneTrackInstanceSystem>
{

}

public unsafe class MovieSceneSequenceLoopCount : ObjectBase<FMovieSceneSequenceLoopCount>
{

}

public unsafe class MovieSceneEvalTemplateBase : ObjectBase<FMovieSceneEvalTemplateBase>
{
}

public unsafe class MovieSceneEvalTemplate : ObjectBase<FMovieSceneEvalTemplate>
{

}

public unsafe class MovieSceneChannel : ObjectBase<FMovieSceneChannel>
{
}

public unsafe class MovieSceneBoolChannel : ObjectBase<FMovieSceneBoolChannel>
{

}

public unsafe class MovieSceneFloatChannel : ObjectBase<FMovieSceneFloatChannel>
{

}

public unsafe class MovieSceneKeyHandleMap : ObjectBase<FMovieSceneKeyHandleMap>
{
}

public unsafe class MovieSceneFloatValue : ObjectBase<FMovieSceneFloatValue>
{

}

public unsafe class MovieSceneTangentData : ObjectBase<FMovieSceneTangentData>
{

}

public unsafe class MovieSceneIntegerChannel : ObjectBase<FMovieSceneIntegerChannel>
{

}

public unsafe class MovieSceneTrackImplementation : ObjectBase<FMovieSceneTrackImplementation>
{
}

public unsafe class MovieScenePropertyBinding : ObjectBase<FMovieScenePropertyBinding>
{

}

public unsafe class MovieScenePropertySectionTemplate : ObjectBase<FMovieScenePropertySectionTemplate>
{

}

public unsafe class MovieScenePropertySectionData : ObjectBase<FMovieScenePropertySectionData>
{

}

public unsafe class TrackInstanceInputComponent : ObjectBase<FTrackInstanceInputComponent>
{

}

public unsafe class MovieSceneEvaluationHookComponent : ObjectBase<FMovieSceneEvaluationHookComponent>
{

}

public unsafe class MovieSceneTrackInstanceComponent : ObjectBase<FMovieSceneTrackInstanceComponent>
{

}

public unsafe class EasingComponentData : ObjectBase<FEasingComponentData>
{

}

public unsafe class MovieSceneDeterminismData : ObjectBase<FMovieSceneDeterminismData>
{

}

public unsafe class MovieSceneSectionGroup : ObjectBase<FMovieSceneSectionGroup>
{

}

public unsafe class MovieSceneObjectBindingIDs : ObjectBase<FMovieSceneObjectBindingIDs>
{

}

public unsafe class MovieSceneTrackLabels : ObjectBase<FMovieSceneTrackLabels>
{

}

public unsafe class MovieSceneEditorData : ObjectBase<FMovieSceneEditorData>
{

}

public unsafe class MovieSceneExpansionState : ObjectBase<FMovieSceneExpansionState>
{

}

public unsafe class MovieSceneTimecodeSource : ObjectBase<FMovieSceneTimecodeSource>
{

}

public unsafe class MovieSceneBinding : ObjectBase<FMovieSceneBinding>
{

}

public unsafe class MovieSceneBindingOverrideData : ObjectBase<FMovieSceneBindingOverrideData>
{

}

public unsafe class MovieSceneByteChannel : ObjectBase<FMovieSceneByteChannel>
{

}

public unsafe class MovieSceneCompiledSequenceFlagStruct : ObjectBase<FMovieSceneCompiledSequenceFlagStruct>
{

}

public unsafe class MovieSceneSequenceCompilerMaskStruct : ObjectBase<FMovieSceneSequenceCompilerMaskStruct>
{

}

public unsafe class MovieSceneEntitySystemGraph : ObjectBase<FMovieSceneEntitySystemGraph>
{

}

public unsafe class MovieSceneEntitySystemGraphNodes : ObjectBase<FMovieSceneEntitySystemGraphNodes>
{
}

public unsafe class MovieSceneEntitySystemGraphNode : ObjectBase<FMovieSceneEntitySystemGraphNode>
{

}

public unsafe class MovieSceneEvalTemplatePtr : ObjectBase<FMovieSceneEvalTemplatePtr>
{
}

public unsafe class MovieSceneEmptyStruct : ObjectBase<FMovieSceneEmptyStruct>
{
}

public unsafe class MovieSceneEvaluationField : ObjectBase<FMovieSceneEvaluationField>
{

}

public unsafe class MovieSceneEvaluationMetaData : ObjectBase<FMovieSceneEvaluationMetaData>
{

}

public unsafe class MovieSceneOrderedEvaluationKey : ObjectBase<FMovieSceneOrderedEvaluationKey>
{

}

public unsafe class MovieSceneEvaluationKey : ObjectBase<FMovieSceneEvaluationKey>
{

}

public unsafe class MovieSceneTrackIdentifier : ObjectBase<FMovieSceneTrackIdentifier>
{

}

public unsafe class MovieSceneSequenceID : ObjectBase<FMovieSceneSequenceID>
{

}

public unsafe class MovieSceneEvaluationGroup : ObjectBase<FMovieSceneEvaluationGroup>
{

}

public unsafe class MovieSceneFieldEntry_ChildTemplate : ObjectBase<FMovieSceneFieldEntry_ChildTemplate>
{

}

public unsafe class MovieSceneFieldEntry_EvaluationTrack : ObjectBase<FMovieSceneFieldEntry_EvaluationTrack>
{

}

public unsafe class MovieSceneEvaluationFieldTrackPtr : ObjectBase<FMovieSceneEvaluationFieldTrackPtr>
{

}

public unsafe class MovieSceneEvaluationGroupLUTIndex : ObjectBase<FMovieSceneEvaluationGroupLUTIndex>
{

}

public unsafe class MovieSceneFrameRange : ObjectBase<FMovieSceneFrameRange>
{
}

public unsafe class MovieSceneEvaluationFieldSegmentPtr : ObjectBase<FMovieSceneEvaluationFieldSegmentPtr>
{

}

public unsafe class MovieSceneSegmentIdentifier : ObjectBase<FMovieSceneSegmentIdentifier>
{

}

public unsafe class MovieSceneEntityComponentField : ObjectBase<FMovieSceneEntityComponentField>
{

}

public unsafe class MovieSceneEvaluationFieldSharedEntityMetaData : ObjectBase<FMovieSceneEvaluationFieldSharedEntityMetaData>
{

}

public unsafe class MovieSceneEvaluationFieldEntityMetaData : ObjectBase<FMovieSceneEvaluationFieldEntityMetaData>
{

}

public unsafe class MovieSceneEvaluationFieldEntity : ObjectBase<FMovieSceneEvaluationFieldEntity>
{

}

public unsafe class MovieSceneEvaluationFieldEntityKey : ObjectBase<FMovieSceneEvaluationFieldEntityKey>
{

}

public unsafe class MovieSceneEvaluationFieldEntityTree : ObjectBase<FMovieSceneEvaluationFieldEntityTree>
{
}

public unsafe class MovieSceneEvaluationInstanceKey : ObjectBase<FMovieSceneEvaluationInstanceKey>
{
}

public unsafe class MovieSceneEvaluationHookEventContainer : ObjectBase<FMovieSceneEvaluationHookEventContainer>
{

}

public unsafe class MovieSceneEvaluationHookEvent : ObjectBase<FMovieSceneEvaluationHookEvent>
{

}

public unsafe class MovieSceneEvaluationOperand : ObjectBase<FMovieSceneEvaluationOperand>
{

}

public unsafe class MovieSceneEvaluationTemplate : ObjectBase<FMovieSceneEvaluationTemplate>
{

}

public unsafe class MovieSceneTemplateGenerationLedger : ObjectBase<FMovieSceneTemplateGenerationLedger>
{

}

public unsafe class MovieSceneEvaluationTemplateSerialNumber : ObjectBase<FMovieSceneEvaluationTemplateSerialNumber>
{

}

public unsafe class MovieSceneEvaluationTrack : ObjectBase<FMovieSceneEvaluationTrack>
{

}

public unsafe class MovieSceneTrackImplementationPtr : ObjectBase<FMovieSceneTrackImplementationPtr>
{
}

public unsafe class MovieSceneSubSectionData : ObjectBase<FMovieSceneSubSectionData>
{

}

public unsafe class MovieSceneRootEvaluationTemplateInstance : ObjectBase<FMovieSceneRootEvaluationTemplateInstance>
{

}

public unsafe class MovieSceneKeyStruct : ObjectBase<FMovieSceneKeyStruct>
{
}

public unsafe class MovieSceneKeyTimeStruct : ObjectBase<FMovieSceneKeyTimeStruct>
{

}

public unsafe class GeneratedMovieSceneKeyStruct : ObjectBase<FGeneratedMovieSceneKeyStruct>
{
}

public unsafe class MovieSceneObjectPathChannel : ObjectBase<FMovieSceneObjectPathChannel>
{

}

public unsafe class MovieSceneObjectPathChannelKeyValue : ObjectBase<FMovieSceneObjectPathChannelKeyValue>
{

}

public unsafe class MovieScenePossessable : ObjectBase<FMovieScenePossessable>
{

}

public unsafe class MovieSceneEasingSettings : ObjectBase<FMovieSceneEasingSettings>
{

}

public unsafe class MovieSceneSectionEvalOptions : ObjectBase<FMovieSceneSectionEvalOptions>
{

}

public unsafe class MovieSceneSectionParameters : ObjectBase<FMovieSceneSectionParameters>
{

}

public unsafe class MovieSceneSegment : ObjectBase<FMovieSceneSegment>
{
}

public unsafe class SectionEvaluationData : ObjectBase<FSectionEvaluationData>
{

}

public unsafe class MovieSceneSequenceHierarchy : ObjectBase<FMovieSceneSequenceHierarchy>
{

}

public unsafe class MovieSceneSequenceHierarchyNode : ObjectBase<FMovieSceneSequenceHierarchyNode>
{

}

public unsafe class MovieSceneSubSequenceData : ObjectBase<FMovieSceneSubSequenceData>
{

}

public unsafe class MovieSceneSequenceInstanceDataPtr : ObjectBase<FMovieSceneSequenceInstanceDataPtr>
{
}

public unsafe class MovieSceneSequenceTransform : ObjectBase<FMovieSceneSequenceTransform>
{

}

public unsafe class MovieSceneNestedSequenceTransform : ObjectBase<FMovieSceneNestedSequenceTransform>
{

}

public unsafe class MovieSceneTimeWarping : ObjectBase<FMovieSceneTimeWarping>
{

}

public unsafe class MovieSceneTimeTransform : ObjectBase<FMovieSceneTimeTransform>
{

}

public unsafe class MovieSceneSubSequenceTree : ObjectBase<FMovieSceneSubSequenceTree>
{
}

public unsafe class MovieSceneSubSequenceTreeEntry : ObjectBase<FMovieSceneSubSequenceTreeEntry>
{
}

public unsafe class MovieSceneSequenceInstanceData : ObjectBase<FMovieSceneSequenceInstanceData>
{
}

public unsafe class MovieSceneSequenceReplProperties : ObjectBase<FMovieSceneSequenceReplProperties>
{

}

public unsafe class MovieSceneSequenceActorPointers : ObjectBase<FMovieSceneSequenceActorPointers>
{

}

public unsafe class MovieSceneWarpCounter : ObjectBase<FMovieSceneWarpCounter>
{

}

public unsafe class MovieSceneSpawnable : ObjectBase<FMovieSceneSpawnable>
{

}

public unsafe class TestMovieSceneEvalTemplate : ObjectBase<FTestMovieSceneEvalTemplate>
{
}

public unsafe class MovieSceneTrackDisplayOptions : ObjectBase<FMovieSceneTrackDisplayOptions>
{

}

public unsafe class MovieSceneTrackEvalOptions : ObjectBase<FMovieSceneTrackEvalOptions>
{

}

public unsafe class MovieSceneTrackEvaluationField : ObjectBase<FMovieSceneTrackEvaluationField>
{

}

public unsafe class MovieSceneTrackEvaluationFieldEntry : ObjectBase<FMovieSceneTrackEvaluationFieldEntry>
{

}

public unsafe class MovieSceneTrackInstanceInput : ObjectBase<FMovieSceneTrackInstanceInput>
{

}

public unsafe class MovieSceneTrackInstanceEntry : ObjectBase<FMovieSceneTrackInstanceEntry>
{

}

