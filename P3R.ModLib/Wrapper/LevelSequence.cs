using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class LevelSequenceActor : ObjectBase<ALevelSequenceActor>
{

    public void ShowBurnin()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowBurnin"),  @params);
    }
    public void SetSequence(ULevelSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        ProcessEvent(GetFunction("SetSequence"),  @params);
    }
    public void SetReplicatePlayback(bool ReplicatePlayback)
    {
        Span<(string name, object value)> @params = [
            ("ReplicatePlayback", ReplicatePlayback)
        ];
        ProcessEvent(GetFunction("SetReplicatePlayback"),  @params);
    }
    public void SetBindingByTag(FName BindingTag, ref TArray<IntPtr> Actors, bool bAllowBindingsFromAsset)
    {
        Span<(string name, object value)> @params = [
            ("BindingTag", BindingTag), 
            ("Actors", Actors), 
            ("bAllowBindingsFromAsset", bAllowBindingsFromAsset)
        ];
        ProcessEvent(GetFunction("SetBindingByTag"),  @params);
    }
    public void SetBinding(FMovieSceneObjectBindingID Binding, ref TArray<IntPtr> Actors, bool bAllowBindingsFromAsset)
    {
        Span<(string name, object value)> @params = [
            ("Binding", Binding), 
            ("Actors", Actors), 
            ("bAllowBindingsFromAsset", bAllowBindingsFromAsset)
        ];
        ProcessEvent(GetFunction("SetBinding"),  @params);
    }
    public void ResetBindings()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetBindings"),  @params);
    }
    public void ResetBinding(FMovieSceneObjectBindingID Binding)
    {
        Span<(string name, object value)> @params = [
            ("Binding", Binding)
        ];
        ProcessEvent(GetFunction("ResetBinding"),  @params);
    }
    public void RemoveBindingByTag(FName Tag, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("RemoveBindingByTag"),  @params);
    }
    public void RemoveBinding(FMovieSceneObjectBindingID Binding, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Binding", Binding), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("RemoveBinding"),  @params);
    }
    public void OnLevelSequenceLoaded__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLevelSequenceLoaded__DelegateSignature"),  @params);
    }
    public ULevelSequence* LoadSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULevelSequence*)ProcessEvent<IntPtr>(GetFunction("LoadSequence"),  @params);
    }
    public void HideBurnin()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("HideBurnin"),  @params);
    }
    public ULevelSequencePlayer* GetSequencePlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULevelSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("GetSequencePlayer"),  @params);
    }
    public ULevelSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULevelSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
    public TArray<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        return ProcessEvent<TArray<FMovieSceneObjectBindingID>>(GetFunction("FindNamedBindings"),  @params);
    }
    public FMovieSceneObjectBindingID FindNamedBinding(FName Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("FindNamedBinding"),  @params);
    }
    public void AddBindingByTag(FName BindingTag, AActor* Actor, bool bAllowBindingsFromAsset)
    {
        Span<(string name, object value)> @params = [
            ("BindingTag", BindingTag), 
            ("Actor", (IntPtr)Actor), 
            ("bAllowBindingsFromAsset", bAllowBindingsFromAsset)
        ];
        ProcessEvent(GetFunction("AddBindingByTag"),  @params);
    }
    public void AddBinding(FMovieSceneObjectBindingID Binding, AActor* Actor, bool bAllowBindingsFromAsset)
    {
        Span<(string name, object value)> @params = [
            ("Binding", Binding), 
            ("Actor", (IntPtr)Actor), 
            ("bAllowBindingsFromAsset", bAllowBindingsFromAsset)
        ];
        ProcessEvent(GetFunction("AddBinding"),  @params);
    }
}

public unsafe class AnimSequenceLevelSequenceLink : ObjectBase<UAnimSequenceLevelSequenceLink>
{

}

public unsafe class DefaultLevelSequenceInstanceData : ObjectBase<UDefaultLevelSequenceInstanceData>
{

}

public unsafe class LevelSequenceMetaData : ObjectBase<ILevelSequenceMetaData>
{
}

public unsafe class LevelSequence : ObjectBase<ULevelSequence>
{

    public void RemoveMetaDataByClass(UClass* InClass)
    {
        Span<(string name, object value)> @params = [
            ("InClass", (IntPtr)InClass)
        ];
        ProcessEvent(GetFunction("RemoveMetaDataByClass"),  @params);
    }
    public UObject* FindOrAddMetaDataByClass(UClass* InClass)
    {
        Span<(string name, object value)> @params = [
            ("InClass", (IntPtr)InClass)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("FindOrAddMetaDataByClass"),  @params);
    }
    public UObject* FindMetaDataByClass(UClass* InClass)
    {
        Span<(string name, object value)> @params = [
            ("InClass", (IntPtr)InClass)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("FindMetaDataByClass"),  @params);
    }
    public UObject* CopyMetaData(UObject* InMetaData)
    {
        Span<(string name, object value)> @params = [
            ("InMetaData", (IntPtr)InMetaData)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("CopyMetaData"),  @params);
    }
}

public unsafe class LevelSequenceBurnInInitSettings : ObjectBase<ULevelSequenceBurnInInitSettings>
{
}

public unsafe class LevelSequenceBurnInOptions : ObjectBase<ULevelSequenceBurnInOptions>
{

    public void SetBurnIn(FSoftClassPath InBurnInClass)
    {
        Span<(string name, object value)> @params = [
            ("InBurnInClass", InBurnInClass)
        ];
        ProcessEvent(GetFunction("SetBurnIn"),  @params);
    }
}

public unsafe class LevelSequenceAnimSequenceLink : ObjectBase<ULevelSequenceAnimSequenceLink>
{

}

public unsafe class LevelSequenceBurnIn : ObjectBase<ULevelSequenceBurnIn>
{

    public void SetSettings(UObject* InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", (IntPtr)InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"),  @params);
    }
    public TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TSubclassOf<ULevelSequenceBurnInInitSettings>>(GetFunction("GetSettingsClass"),  @params);
    }
}

public unsafe class LevelSequenceDirector : ObjectBase<ULevelSequenceDirector>
{

    public void OnCreated()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnCreated"),  @params);
    }
    public UMovieSceneSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
    public TArray<IntPtr> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetBoundObjects"),  @params);
    }
    public UObject* GetBoundObject(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetBoundObject"),  @params);
    }
    public TArray<IntPtr> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetBoundActors"),  @params);
    }
    public AActor* GetBoundActor(FMovieSceneObjectBindingID ObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("ObjectBinding", ObjectBinding)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetBoundActor"),  @params);
    }
}

public unsafe class LegacyLevelSequenceDirectorBlueprint : ObjectBase<ULegacyLevelSequenceDirectorBlueprint>
{
}

public unsafe class LevelSequencePlayer : ObjectBase<ULevelSequencePlayer>
{

    public UCameraComponent* GetActiveCameraComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCameraComponent*)ProcessEvent<IntPtr>(GetFunction("GetActiveCameraComponent"),  @params);
    }
    public ULevelSequencePlayer* CreateLevelSequencePlayer(UObject* WorldContextObject, ULevelSequence* LevelSequence, FMovieSceneSequencePlaybackSettings Settings, ref ALevelSequenceActor* OutActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelSequence", (IntPtr)LevelSequence), 
            ("Settings", Settings), 
            ("OutActor", (IntPtr)OutActor)
        ];
        return (ULevelSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("CreateLevelSequencePlayer"),  @params);
    }
}

public unsafe class LevelSequenceProjectSettings : ObjectBase<ULevelSequenceProjectSettings>
{

}

public unsafe class LevelSequenceMediaController : ObjectBase<ALevelSequenceMediaController>
{

    public void SynchronizeToServer(float DesyncThresholdSeconds)
    {
        Span<(string name, object value)> @params = [
            ("DesyncThresholdSeconds", DesyncThresholdSeconds)
        ];
        ProcessEvent(GetFunction("SynchronizeToServer"),  @params);
    }
    public void Play()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Play"),  @params);
    }
    public void OnRep_ServerStartTimeSeconds()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_ServerStartTimeSeconds"),  @params);
    }
    public ALevelSequenceActor* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ALevelSequenceActor*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
    public UMediaComponent* GetMediaComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMediaComponent*)ProcessEvent<IntPtr>(GetFunction("GetMediaComponent"),  @params);
    }
}

public unsafe class LevelSequenceCameraSettings : ObjectBase<FLevelSequenceCameraSettings>
{

}

public unsafe class BoundActorProxy : ObjectBase<FBoundActorProxy>
{
}

public unsafe class LevelSequenceAnimSequenceLinkItem : ObjectBase<FLevelSequenceAnimSequenceLinkItem>
{

}

public unsafe class LevelSequenceBindingReferences : ObjectBase<FLevelSequenceBindingReferences>
{

}

public unsafe class LevelSequenceBindingReferenceArray : ObjectBase<FLevelSequenceBindingReferenceArray>
{

}

public unsafe class LevelSequenceBindingReference : ObjectBase<FLevelSequenceBindingReference>
{

}

public unsafe class LevelSequenceObjectReferenceMap : ObjectBase<FLevelSequenceObjectReferenceMap>
{
}

public unsafe class LevelSequenceLegacyObjectReference : ObjectBase<FLevelSequenceLegacyObjectReference>
{
}

public unsafe class LevelSequenceObject : ObjectBase<FLevelSequenceObject>
{

}

public unsafe class LevelSequencePlayerSnapshot : ObjectBase<FLevelSequencePlayerSnapshot>
{

}

public unsafe class LevelSequenceSnapshotSettings : ObjectBase<FLevelSequenceSnapshotSettings>
{

}

