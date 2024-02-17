using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ImgMediaSource : ObjectBase<UImgMediaSource>
{
    public ImgMediaSource(IntPtr pointer) : base(pointer) {}
    public void SetSequencePath(FString Path)
    {
        Span<(string name, object value)> @params = [
            ("Path", Path)
        ];
        ProcessEvent(GetFunction("SetSequencePath"), @params);
    }
    public void SetMipLevelDistance(float Distance)
    {
        Span<(string name, object value)> @params = [
            ("Distance", Distance)
        ];
        ProcessEvent(GetFunction("SetMipLevelDistance"), @params);
    }
    public void RemoveTargetObject(AActor* InActor)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor)
        ];
        ProcessEvent(GetFunction("RemoveTargetObject"), @params);
    }
    public void RemoveGlobalCamera(AActor* InActor)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor)
        ];
        ProcessEvent(GetFunction("RemoveGlobalCamera"), @params);
    }
    public FString GetSequencePath()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetSequencePath"), @params);
    }
    public void GetProxies(ref TArray<FString> OutProxies)
    {
        Span<(string name, object value)> @params = [
            ("OutProxies", OutProxies)
        ];
        ProcessEvent(GetFunction("GetProxies"), @params);
    }
    public void AddTargetObject(AActor* InActor, float Width)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor), 
            ("Width", Width)
        ];
        ProcessEvent(GetFunction("AddTargetObject"), @params);
    }
    public void AddGlobalCamera(AActor* InActor)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor)
        ];
        ProcessEvent(GetFunction("AddGlobalCamera"), @params);
    }
}

