using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class GeometryCache : ObjectBase<UGeometryCache>
{
    public GeometryCache(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeometryCacheActor : ObjectBase<AGeometryCacheActor>
{
    public GeometryCacheActor(IntPtr pointer) : base(pointer) {}
    public UGeometryCacheComponent* GetGeometryCacheComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UGeometryCacheComponent*)ProcessEvent<IntPtr>(GetFunction("GetGeometryCacheComponent"), @params);
    }
}

public unsafe class GeometryCacheCodecBase : ObjectBase<UGeometryCacheCodecBase>
{
    public GeometryCacheCodecBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeometryCacheCodecRaw : ObjectBase<UGeometryCacheCodecRaw>
{
    public GeometryCacheCodecRaw(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeometryCacheCodecV1 : ObjectBase<UGeometryCacheCodecV1>
{
    public GeometryCacheCodecV1(IntPtr pointer) : base(pointer) {}}

public unsafe class GeometryCacheComponent : ObjectBase<UGeometryCacheComponent>
{
    public GeometryCacheComponent(IntPtr pointer) : base(pointer) {}
    public void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time), 
            ("bInIsRunning", bInIsRunning), 
            ("bInBackwards", bInBackwards), 
            ("bInIsLooping", bInIsLooping)
        ];
        ProcessEvent(GetFunction("TickAtThisTime"), @params);
    }
    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"), @params);
    }
    public void SetStartTimeOffset(float NewStartTimeOffset)
    {
        Span<(string name, object value)> @params = [
            ("NewStartTimeOffset", NewStartTimeOffset)
        ];
        ProcessEvent(GetFunction("SetStartTimeOffset"), @params);
    }
    public void SetPlaybackSpeed(float NewPlaybackSpeed)
    {
        Span<(string name, object value)> @params = [
            ("NewPlaybackSpeed", NewPlaybackSpeed)
        ];
        ProcessEvent(GetFunction("SetPlaybackSpeed"), @params);
    }
    public void SetMotionVectorScale(float NewMotionVectorScale)
    {
        Span<(string name, object value)> @params = [
            ("NewMotionVectorScale", NewMotionVectorScale)
        ];
        ProcessEvent(GetFunction("SetMotionVectorScale"), @params);
    }
    public void SetLooping(bool bNewLooping)
    {
        Span<(string name, object value)> @params = [
            ("bNewLooping", bNewLooping)
        ];
        ProcessEvent(GetFunction("SetLooping"), @params);
    }
    public bool SetGeometryCache(UGeometryCache* NewGeomCache)
    {
        Span<(string name, object value)> @params = [
            ("NewGeomCache", (IntPtr)NewGeomCache)
        ];
        return ProcessEvent<bool>(GetFunction("SetGeometryCache"), @params);
    }
    public void SetExtrapolateFrames(bool bNewExtrapolating)
    {
        Span<(string name, object value)> @params = [
            ("bNewExtrapolating", bNewExtrapolating)
        ];
        ProcessEvent(GetFunction("SetExtrapolateFrames"), @params);
    }
    public void PlayReversedFromEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayReversedFromEnd"), @params);
    }
    public void PlayReversed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayReversed"), @params);
    }
    public void PlayFromStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayFromStart"), @params);
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
    public bool IsPlayingReversed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingReversed"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public bool IsExtrapolatingFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsExtrapolatingFrames"), @params);
    }
    public float GetStartTimeOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetStartTimeOffset"), @params);
    }
    public float GetPlaybackSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlaybackSpeed"), @params);
    }
    public float GetPlaybackDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlaybackDirection"), @params);
    }
    public int GetNumberOfFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumberOfFrames"), @params);
    }
    public float GetMotionVectorScale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMotionVectorScale"), @params);
    }
    public float GetDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDuration"), @params);
    }
    public float GetAnimationTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAnimationTime"), @params);
    }
}

public unsafe class GeometryCacheTrack : ObjectBase<UGeometryCacheTrack>
{
    public GeometryCacheTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeometryCacheTrack_FlipbookAnimation : ObjectBase<UDEPRECATED_GeometryCacheTrack_FlipbookAnimation>
{
    public GeometryCacheTrack_FlipbookAnimation(IntPtr pointer) : base(pointer) {}
    public void AddMeshSample(ref FGeometryCacheMeshData MeshData, float SampleTime)
    {
        Span<(string name, object value)> @params = [
            ("MeshData", MeshData), 
            ("SampleTime", SampleTime)
        ];
        ProcessEvent(GetFunction("AddMeshSample"), @params);
    }
}

public unsafe class GeometryCacheTrackStreamable : ObjectBase<UGeometryCacheTrackStreamable>
{
    public GeometryCacheTrackStreamable(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeometryCacheTrack_TransformAnimation : ObjectBase<UDEPRECATED_GeometryCacheTrack_TransformAnimation>
{
    public GeometryCacheTrack_TransformAnimation(IntPtr pointer) : base(pointer) {}
    public void SetMesh(ref FGeometryCacheMeshData NewMeshData)
    {
        Span<(string name, object value)> @params = [
            ("NewMeshData", NewMeshData)
        ];
        ProcessEvent(GetFunction("SetMesh"), @params);
    }
}

public unsafe class GeometryCacheTrack_TransformGroupAnimation : ObjectBase<UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation>
{
    public GeometryCacheTrack_TransformGroupAnimation(IntPtr pointer) : base(pointer) {}
    public void SetMesh(ref FGeometryCacheMeshData NewMeshData)
    {
        Span<(string name, object value)> @params = [
            ("NewMeshData", NewMeshData)
        ];
        ProcessEvent(GetFunction("SetMesh"), @params);
    }
}

