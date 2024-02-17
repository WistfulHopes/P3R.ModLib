using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class PreviewWorldUpdater : ObjectBase<APreviewWorldUpdater>
{
    public PreviewWorldUpdater(IntPtr pointer) : base(pointer) {}
    public AActor* SpawnAttachedActor(TSubclassOf<AActor> ActorClass)
    {
        Span<(string name, object value)> @params = [
            ("ActorClass", ActorClass)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("SpawnAttachedActor"), @params);
    }
    public AActor* SetTargetActor(TSubclassOf<AActor> ActorClass, bool IsResetCamera)
    {
        Span<(string name, object value)> @params = [
            ("ActorClass", ActorClass), 
            ("IsResetCamera", IsResetCamera)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("SetTargetActor"), @params);
    }
    public void SetGazeOffsetBoneName(FString NewGazeOffsetBoneName)
    {
        Span<(string name, object value)> @params = [
            ("NewGazeOffsetBoneName", NewGazeOffsetBoneName)
        ];
        ProcessEvent(GetFunction("SetGazeOffsetBoneName"), @params);
    }
    public void SetGazeOffset(FVector NewGazeOffset)
    {
        Span<(string name, object value)> @params = [
            ("NewGazeOffset", NewGazeOffset)
        ];
        ProcessEvent(GetFunction("SetGazeOffset"), @params);
    }
    public void SetGazeMode(bool NewGazeMode)
    {
        Span<(string name, object value)> @params = [
            ("NewGazeMode", NewGazeMode)
        ];
        ProcessEvent(GetFunction("SetGazeMode"), @params);
    }
    public void SetFoV(float NewFOV)
    {
        Span<(string name, object value)> @params = [
            ("NewFOV", NewFOV)
        ];
        ProcessEvent(GetFunction("SetFoV"), @params);
    }
    public void SetCameraTransform(FTransform NewCameraTransform)
    {
        Span<(string name, object value)> @params = [
            ("NewCameraTransform", NewCameraTransform)
        ];
        ProcessEvent(GetFunction("SetCameraTransform"), @params);
    }
    public void SetCameraPosition(FVector NewCameraPosition)
    {
        Span<(string name, object value)> @params = [
            ("NewCameraPosition", NewCameraPosition)
        ];
        ProcessEvent(GetFunction("SetCameraPosition"), @params);
    }
    public void SetCameraPosBoneName(FString NewCameraPosBoneName)
    {
        Span<(string name, object value)> @params = [
            ("NewCameraPosBoneName", NewCameraPosBoneName)
        ];
        ProcessEvent(GetFunction("SetCameraPosBoneName"), @params);
    }
    public void SetCameraAngle(FRotator NewCameraAngle)
    {
        Span<(string name, object value)> @params = [
            ("NewCameraAngle", NewCameraAngle)
        ];
        ProcessEvent(GetFunction("SetCameraAngle"), @params);
    }
    public void OnSetTargetActor__DelegateSignature(AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("OnSetTargetActor__DelegateSignature"), @params);
    }
    public AActor* GetTargetActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetTargetActor"), @params);
    }
    public ASceneCapture2D* GetSceneCaptureActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ASceneCapture2D*)ProcessEvent<IntPtr>(GetFunction("GetSceneCaptureActor"), @params);
    }
    public UWorld* GetPreviewWorld()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWorld*)ProcessEvent<IntPtr>(GetFunction("GetPreviewWorld"), @params);
    }
    public void Cleanup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Cleanup"), @params);
    }
}

