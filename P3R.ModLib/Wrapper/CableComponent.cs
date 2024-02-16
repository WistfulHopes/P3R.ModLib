using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class CableActor : ObjectBase<ACableActor>
{

}

public unsafe class CableComponent : ObjectBase<UCableComponent>
{

    public void SetAttachEndToComponent(USceneComponent* Component, FName SocketName)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SocketName", SocketName)
        ];
        ProcessEvent(GetFunction("SetAttachEndToComponent"),  @params);
    }
    public void SetAttachEndTo(AActor* Actor, FName ComponentProperty, FName SocketName)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("ComponentProperty", ComponentProperty), 
            ("SocketName", SocketName)
        ];
        ProcessEvent(GetFunction("SetAttachEndTo"),  @params);
    }
    public void GetCableParticleLocations(ref TArray<FVector> Locations)
    {
        Span<(string name, object value)> @params = [
            ("Locations", Locations)
        ];
        ProcessEvent(GetFunction("GetCableParticleLocations"),  @params);
    }
    public USceneComponent* GetAttachedComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USceneComponent*)ProcessEvent<IntPtr>(GetFunction("GetAttachedComponent"),  @params);
    }
    public AActor* GetAttachedActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetAttachedActor"),  @params);
    }
}

