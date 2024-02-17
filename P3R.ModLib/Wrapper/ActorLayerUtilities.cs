using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class LayersBlueprintLibrary : ObjectBase<ULayersBlueprintLibrary>
{
    public LayersBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public void RemoveActorFromLayer(AActor* InActor, ref FActorLayer Layer)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor), 
            ("Layer", Layer)
        ];
        ProcessEvent(GetFunction("RemoveActorFromLayer"), @params);
    }
    public TArray<IntPtr> GetActors(UObject* WorldContextObject, ref FActorLayer ActorLayer)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ActorLayer", ActorLayer)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetActors"), @params);
    }
    public void AddActorToLayer(AActor* InActor, ref FActorLayer Layer)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor), 
            ("Layer", Layer)
        ];
        ProcessEvent(GetFunction("AddActorToLayer"), @params);
    }
}

