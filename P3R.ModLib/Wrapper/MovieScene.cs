using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneSignedObject : ObjectBase<UMovieSceneSignedObject>
{
    public MovieSceneSignedObject(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneTrack : ObjectBase<UMovieSceneTrack>
{
    public MovieSceneTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneNameableTrack : ObjectBase<UMovieSceneNameableTrack>
{
    public MovieSceneNameableTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSection : ObjectBase<UMovieSceneSection>
{
    public MovieSceneSection(IntPtr pointer) : base(pointer) {}
    public void SetRowIndex(int NewRowIndex)
    {
        Span<(string name, object value)> @params = [
            ("NewRowIndex", NewRowIndex)
        ];
        ProcessEvent(GetFunction("SetRowIndex"), @params);
    }
    public void SetPreRollFrames(int InPreRollFrames)
    {
        Span<(string name, object value)> @params = [
            ("InPreRollFrames", InPreRollFrames)
        ];
        ProcessEvent(GetFunction("SetPreRollFrames"), @params);
    }
    public void SetPostRollFrames(int InPostRollFrames)
    {
        Span<(string name, object value)> @params = [
            ("InPostRollFrames", InPostRollFrames)
        ];
        ProcessEvent(GetFunction("SetPostRollFrames"), @params);
    }
    public void SetOverlapPriority(int NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetOverlapPriority"), @params);
    }
    public void SetIsLocked(bool bInIsLocked)
    {
        Span<(string name, object value)> @params = [
            ("bInIsLocked", bInIsLocked)
        ];
        ProcessEvent(GetFunction("SetIsLocked"), @params);
    }
    public void SetIsActive(bool bInIsActive)
    {
        Span<(string name, object value)> @params = [
            ("bInIsActive", bInIsActive)
        ];
        ProcessEvent(GetFunction("SetIsActive"), @params);
    }
    public void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode)
    {
        Span<(string name, object value)> @params = [
            ("InCompletionMode", InCompletionMode)
        ];
        ProcessEvent(GetFunction("SetCompletionMode"), @params);
    }
    public void SetBlendType(EMovieSceneBlendType InBlendType)
    {
        Span<(string name, object value)> @params = [
            ("InBlendType", InBlendType)
        ];
        ProcessEvent(GetFunction("SetBlendType"), @params);
    }
    public bool IsLocked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLocked"), @params);
    }
    public bool IsActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsActive"), @params);
    }
    public int GetRowIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetRowIndex"), @params);
    }
    public int GetPreRollFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPreRollFrames"), @params);
    }
    public int GetPostRollFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPostRollFrames"), @params);
    }
    public int GetOverlapPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetOverlapPriority"), @params);
    }
    public EMovieSceneCompletionMode GetCompletionMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMovieSceneCompletionMode>(GetFunction("GetCompletionMode"), @params);
    }
    public FOptionalMovieSceneBlendType GetBlendType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FOptionalMovieSceneBlendType>(GetFunction("GetBlendType"), @params);
    }
}

public unsafe class MovieSceneSequence : ObjectBase<UMovieSceneSequence>
{
    public MovieSceneSequence(IntPtr pointer) : base(pointer) {}
    public TArray<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
    {
        Span<(string name, object value)> @params = [
            ("InBindingName", InBindingName)
        ];
        return ProcessEvent<TArray<FMovieSceneObjectBindingID>>(GetFunction("FindBindingsByTag"), @params);
    }
    public FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
    {
        Span<(string name, object value)> @params = [
            ("InBindingName", InBindingName)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("FindBindingByTag"), @params);
    }
}

public unsafe class MovieSceneSequencePlayer : ObjectBase<UMovieSceneSequencePlayer>
{
    public MovieSceneSequencePlayer(IntPtr pointer) : base(pointer) {}
    public void StopAtCurrentTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAtCurrentTime"), @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void SetTimeRange(float StartTime, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("StartTime", StartTime), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("SetTimeRange"), @params);
    }
    public void SetPlayRate(float PlayRate)
    {
        Span<(string name, object value)> @params = [
            ("PlayRate", PlayRate)
        ];
        ProcessEvent(GetFunction("SetPlayRate"), @params);
    }
    public void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
    {
        Span<(string name, object value)> @params = [
            ("PlaybackParams", PlaybackParams)
        ];
        ProcessEvent(GetFunction("SetPlaybackPosition"), @params);
    }
    public void SetFrameRate(FFrameRate FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("FrameRate", FrameRate)
        ];
        ProcessEvent(GetFunction("SetFrameRate"), @params);
    }
    public void SetFrameRange(int StartFrame, int Duration, float SubFrames)
    {
        Span<(string name, object value)> @params = [
            ("StartFrame", StartFrame), 
            ("Duration", Duration), 
            ("SubFrames", SubFrames)
        ];
        ProcessEvent(GetFunction("SetFrameRange"), @params);
    }
    public void SetDisableCameraCuts(bool bInDisableCameraCuts)
    {
        Span<(string name, object value)> @params = [
            ("bInDisableCameraCuts", bInDisableCameraCuts)
        ];
        ProcessEvent(GetFunction("SetDisableCameraCuts"), @params);
    }
    public void ScrubToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("ScrubToSeconds"), @params);
    }
    public bool ScrubToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("ScrubToMarkedFrame"), @params);
    }
    public void ScrubToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("ScrubToFrame"), @params);
    }
    public void Scrub()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Scrub"), @params);
    }
    public void RPC_OnStopEvent(FFrameTime StoppedTime)
    {
        Span<(string name, object value)> @params = [
            ("StoppedTime", StoppedTime)
        ];
        ProcessEvent(GetFunction("RPC_OnStopEvent"), @params);
    }
    public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FFrameTime RelevantTime)
    {
        Span<(string name, object value)> @params = [
            ("Method", Method), 
            ("RelevantTime", RelevantTime)
        ];
        ProcessEvent(GetFunction("RPC_ExplicitServerUpdateEvent"), @params);
    }
    public void RestoreState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestoreState"), @params);
    }
    public void PlayToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("PlayToSeconds"), @params);
    }
    public bool PlayToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("PlayToMarkedFrame"), @params);
    }
    public void PlayToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("PlayToFrame"), @params);
    }
    public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
    {
        Span<(string name, object value)> @params = [
            ("PlaybackParams", PlaybackParams)
        ];
        ProcessEvent(GetFunction("PlayTo"), @params);
    }
    public void PlayReverse()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayReverse"), @params);
    }
    public void PlayLooping(int NumLoops)
    {
        Span<(string name, object value)> @params = [
            ("NumLoops", NumLoops)
        ];
        ProcessEvent(GetFunction("PlayLooping"), @params);
    }
    public void Play()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Play"), @params);
    }
    public void Pause()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Pause"), @params);
    }
    public void JumpToSeconds(float TimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds)
        ];
        ProcessEvent(GetFunction("JumpToSeconds"), @params);
    }
    public bool JumpToMarkedFrame(FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("InLabel", InLabel)
        ];
        return ProcessEvent<bool>(GetFunction("JumpToMarkedFrame"), @params);
    }
    public void JumpToFrame(FFrameTime NewPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition)
        ];
        ProcessEvent(GetFunction("JumpToFrame"), @params);
    }
    public bool IsReversed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReversed"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public void GoToEndAndStop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GoToEndAndStop"), @params);
    }
    public FQualifiedFrameTime GetStartTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetStartTime"), @params);
    }
    public UMovieSceneSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"), @params);
    }
    public float GetPlayRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayRate"), @params);
    }
    public TArray<FMovieSceneObjectBindingID> GetObjectBindings(UObject* InObject)
    {
        Span<(string name, object value)> @params = [
            ("InObject", (IntPtr)InObject)
        ];
        return ProcessEvent<TArray<FMovieSceneObjectBindingID>>(GetFunction("GetObjectBindings"), @params);
    }
    public FFrameRate GetFrameRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameRate>(GetFunction("GetFrameRate"), @params);
    }
    public int GetFrameDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFrameDuration"), @params);
    }
    public FQualifiedFrameTime GetEndTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetEndTime"), @params);
    }
    public FQualifiedFrameTime GetDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetDuration"), @params);
    }
    public bool GetDisableCameraCuts()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetDisableCameraCuts"), @params);
    }
    public FQualifiedFrameTime GetCurrentTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FQualifiedFrameTime>(GetFunction("GetCurrentTime"), @params);
    }
    public TArray<IntPtr> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetBoundObjects"), @params);
    }
    public void ChangePlaybackDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangePlaybackDirection"), @params);
    }
}

public unsafe class MovieSceneSubSection : ObjectBase<UMovieSceneSubSection>
{
    public MovieSceneSubSection(IntPtr pointer) : base(pointer) {}
    public void SetSequence(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        ProcessEvent(GetFunction("SetSequence"), @params);
    }
    public UMovieSceneSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"), @params);
    }
}

public unsafe class MovieSceneEntitySystem : ObjectBase<UMovieSceneEntitySystem>
{
    public MovieSceneEntitySystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneSubTrack : ObjectBase<UMovieSceneSubTrack>
{
    public MovieSceneSubTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCustomClockSource : ObjectBase<IMovieSceneCustomClockSource>
{
    public MovieSceneCustomClockSource(IntPtr pointer) : base(pointer) {}
    public void OnTick(float DeltaSeconds, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds), 
            ("InPlayRate", InPlayRate)
        ];
        ProcessEvent(GetFunction("OnTick"), @params);
    }
    public void OnStopPlaying(ref FQualifiedFrameTime InStopTime)
    {
        Span<(string name, object value)> @params = [
            ("InStopTime", InStopTime)
        ];
        ProcessEvent(GetFunction("OnStopPlaying"), @params);
    }
    public void OnStartPlaying(ref FQualifiedFrameTime InStartTime)
    {
        Span<(string name, object value)> @params = [
            ("InStartTime", InStartTime)
        ];
        ProcessEvent(GetFunction("OnStartPlaying"), @params);
    }
    public FFrameTime OnRequestCurrentTime(ref FQualifiedFrameTime InCurrentTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("InCurrentTime", InCurrentTime), 
            ("InPlayRate", InPlayRate)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("OnRequestCurrentTime"), @params);
    }
}

public unsafe class MovieSceneDeterminismSource : ObjectBase<IMovieSceneDeterminismSource>
{
    public MovieSceneDeterminismSource(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEntityProvider : ObjectBase<IMovieSceneEntityProvider>
{
    public MovieSceneEntityProvider(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEvaluationHook : ObjectBase<IMovieSceneEvaluationHook>
{
    public MovieSceneEvaluationHook(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePlaybackClient : ObjectBase<IMovieScenePlaybackClient>
{
    public MovieScenePlaybackClient(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneTrackTemplateProducer : ObjectBase<IMovieSceneTrackTemplateProducer>
{
    public MovieSceneTrackTemplateProducer(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNodeGroup : ObjectBase<UMovieSceneNodeGroup>
{
    public MovieSceneNodeGroup(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNodeGroupCollection : ObjectBase<UMovieSceneNodeGroupCollection>
{
    public MovieSceneNodeGroupCollection(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScene : ObjectBase<UMovieScene>
{
    public MovieScene(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneBindingOverrides : ObjectBase<UMovieSceneBindingOverrides>
{
    public MovieSceneBindingOverrides(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneBindingOwnerInterface : ObjectBase<IMovieSceneBindingOwnerInterface>
{
    public MovieSceneBindingOwnerInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBlenderSystem : ObjectBase<UMovieSceneBlenderSystem>
{
    public MovieSceneBlenderSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBoolSection : ObjectBase<UMovieSceneBoolSection>
{
    public MovieSceneBoolSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEntityInstantiatorSystem : ObjectBase<UMovieSceneEntityInstantiatorSystem>
{
    public MovieSceneEntityInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneGenericBoundObjectInstantiator : ObjectBase<UMovieSceneGenericBoundObjectInstantiator>
{
    public MovieSceneGenericBoundObjectInstantiator(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBoundSceneComponentInstantiator : ObjectBase<UMovieSceneBoundSceneComponentInstantiator>
{
    public MovieSceneBoundSceneComponentInstantiator(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSceneComponentImpersonator : ObjectBase<IMovieSceneSceneComponentImpersonator>
{
    public MovieSceneSceneComponentImpersonator(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneCompiledData : ObjectBase<UMovieSceneCompiledData>
{
    public MovieSceneCompiledData(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneCompiledDataManager : ObjectBase<UMovieSceneCompiledDataManager>
{
    public MovieSceneCompiledDataManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneFloatDecomposer : ObjectBase<IMovieSceneFloatDecomposer>
{
    public MovieSceneFloatDecomposer(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneBuiltInEasingFunction : ObjectBase<UMovieSceneBuiltInEasingFunction>
{
    public MovieSceneBuiltInEasingFunction(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEasingExternalCurve : ObjectBase<UMovieSceneEasingExternalCurve>
{
    public MovieSceneEasingExternalCurve(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEasingFunction : ObjectBase<IMovieSceneEasingFunction>
{
    public MovieSceneEasingFunction(IntPtr pointer) : base(pointer) {}
    public float OnEvaluate(float Interp)
    {
        Span<(string name, object value)> @params = [
            ("Interp", Interp)
        ];
        return ProcessEvent<float>(GetFunction("OnEvaluate"), @params);
    }
}

public unsafe class MovieSceneEntitySystemLinker : ObjectBase<UMovieSceneEntitySystemLinker>
{
    public MovieSceneEntitySystemLinker(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvalTimeSystem : ObjectBase<UMovieSceneEvalTimeSystem>
{
    public MovieSceneEvalTimeSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneEvaluationHookSystem : ObjectBase<UMovieSceneEvaluationHookSystem>
{
    public MovieSceneEvaluationHookSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneFolder : ObjectBase<UMovieSceneFolder>
{
    public MovieSceneFolder(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneHookSection : ObjectBase<UMovieSceneHookSection>
{
    public MovieSceneHookSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneKeyProxy : ObjectBase<IMovieSceneKeyProxy>
{
    public MovieSceneKeyProxy(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneMasterInstantiatorSystem : ObjectBase<UMovieSceneMasterInstantiatorSystem>
{
    public MovieSceneMasterInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScenePreAnimatedStateSystemInterface : ObjectBase<IMovieScenePreAnimatedStateSystemInterface>
{
    public MovieScenePreAnimatedStateSystemInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneCachePreAnimatedStateSystem : ObjectBase<UMovieSceneCachePreAnimatedStateSystem>
{
    public MovieSceneCachePreAnimatedStateSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneRestorePreAnimatedStateSystem : ObjectBase<UMovieSceneRestorePreAnimatedStateSystem>
{
    public MovieSceneRestorePreAnimatedStateSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSequenceActor : ObjectBase<IMovieSceneSequenceActor>
{
    public MovieSceneSequenceActor(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSequenceTickManager : ObjectBase<UMovieSceneSequenceTickManager>
{
    public MovieSceneSequenceTickManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneSpawnablesSystem : ObjectBase<UMovieSceneSpawnablesSystem>
{
    public MovieSceneSpawnablesSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSpawnSection : ObjectBase<UMovieSceneSpawnSection>
{
    public MovieSceneSpawnSection(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneSpawnTrack : ObjectBase<UMovieSceneSpawnTrack>
{
    public MovieSceneSpawnTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestMovieSceneTrack : ObjectBase<UTestMovieSceneTrack>
{
    public TestMovieSceneTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestMovieSceneSection : ObjectBase<UTestMovieSceneSection>
{
    public TestMovieSceneSection(IntPtr pointer) : base(pointer) {}}

public unsafe class TestMovieSceneSequence : ObjectBase<UTestMovieSceneSequence>
{
    public TestMovieSceneSequence(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestMovieSceneSubTrack : ObjectBase<UTestMovieSceneSubTrack>
{
    public TestMovieSceneSubTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestMovieSceneSubSection : ObjectBase<UTestMovieSceneSubSection>
{
    public TestMovieSceneSubSection(IntPtr pointer) : base(pointer) {}}

public unsafe class TestMovieSceneEvalHookTrack : ObjectBase<UTestMovieSceneEvalHookTrack>
{
    public TestMovieSceneEvalHookTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestMovieSceneEvalHookSection : ObjectBase<UTestMovieSceneEvalHookSection>
{
    public TestMovieSceneEvalHookSection(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneTrackInstance : ObjectBase<UMovieSceneTrackInstance>
{
    public MovieSceneTrackInstance(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneTrackInstanceSystem : ObjectBase<UMovieSceneTrackInstanceSystem>
{
    public MovieSceneTrackInstanceSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneTrackInstanceInstantiator : ObjectBase<UMovieSceneTrackInstanceInstantiator>
{
    public MovieSceneTrackInstanceInstantiator(IntPtr pointer) : base(pointer) {}}

public unsafe class NodeAndChannelMappings : ObjectBase<INodeAndChannelMappings>
{
    public NodeAndChannelMappings(IntPtr pointer) : base(pointer) {}}

