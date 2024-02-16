using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SequencerBindingProxy : ObjectBase<FSequencerBindingProxy>
{

}

public unsafe class MovieSceneBindingExtensions : ObjectBase<UMovieSceneBindingExtensions>
{

    public void SetParent(ref FSequencerBindingProxy InBinding, ref FSequencerBindingProxy InParentBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("InParentBinding", InParentBinding)
        ];
        ProcessEvent(GetFunction("SetParent"),  @params);
    }
    public void SetName(ref FSequencerBindingProxy InBinding, FString InName)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("InName", InName)
        ];
        ProcessEvent(GetFunction("SetName"),  @params);
    }
    public void SetDisplayName(ref FSequencerBindingProxy InBinding, ref FText InDisplayName)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("InDisplayName", InDisplayName)
        ];
        ProcessEvent(GetFunction("SetDisplayName"),  @params);
    }
    public void RemoveTrack(ref FSequencerBindingProxy InBinding, UMovieSceneTrack* TrackToRemove)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("TrackToRemove", (IntPtr)TrackToRemove)
        ];
        ProcessEvent(GetFunction("RemoveTrack"),  @params);
    }
    public void Remove(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        ProcessEvent(GetFunction("Remove"),  @params);
    }
    public void MoveBindingContents(ref FSequencerBindingProxy SourceBindingId, ref FSequencerBindingProxy DestinationBindingId)
    {
        Span<(string name, object value)> @params = [
            ("SourceBindingId", SourceBindingId), 
            ("DestinationBindingId", DestinationBindingId)
        ];
        ProcessEvent(GetFunction("MoveBindingContents"),  @params);
    }
    public bool IsValid(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<bool>(GetFunction("IsValid"),  @params);
    }
    public TArray<IntPtr> GetTracks(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetTracks"),  @params);
    }
    public UClass* GetPossessedObjectClass(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return (UClass*)ProcessEvent<IntPtr>(GetFunction("GetPossessedObjectClass"),  @params);
    }
    public FSequencerBindingProxy GetParent(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("GetParent"),  @params);
    }
    public UObject* GetObjectTemplate(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetObjectTemplate"),  @params);
    }
    public FString GetName(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FString>(GetFunction("GetName"),  @params);
    }
    public FGuid GetId(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FGuid>(GetFunction("GetId"),  @params);
    }
    public FText GetDisplayName(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FText>(GetFunction("GetDisplayName"),  @params);
    }
    public TArray<FSequencerBindingProxy> GetChildPossessables(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<TArray<FSequencerBindingProxy>>(GetFunction("GetChildPossessables"),  @params);
    }
    public TArray<IntPtr> FindTracksByType(ref FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("TrackType", TrackType)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindTracksByType"),  @params);
    }
    public TArray<IntPtr> FindTracksByExactType(ref FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("TrackType", TrackType)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindTracksByExactType"),  @params);
    }
    public UMovieSceneTrack* AddTrack(ref FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding), 
            ("TrackType", TrackType)
        ];
        return (UMovieSceneTrack*)ProcessEvent<IntPtr>(GetFunction("AddTrack"),  @params);
    }
}

public unsafe class MovieSceneEventTrackExtensions : ObjectBase<UMovieSceneEventTrackExtensions>
{

    public UMovieSceneEventTriggerSection* AddEventTriggerSection(UMovieSceneEventTrack* InTrack)
    {
        Span<(string name, object value)> @params = [
            ("InTrack", (IntPtr)InTrack)
        ];
        return (UMovieSceneEventTriggerSection*)ProcessEvent<IntPtr>(GetFunction("AddEventTriggerSection"),  @params);
    }
    public UMovieSceneEventRepeaterSection* AddEventRepeaterSection(UMovieSceneEventTrack* InTrack)
    {
        Span<(string name, object value)> @params = [
            ("InTrack", (IntPtr)InTrack)
        ];
        return (UMovieSceneEventRepeaterSection*)ProcessEvent<IntPtr>(GetFunction("AddEventRepeaterSection"),  @params);
    }
}

public unsafe class MovieSceneFolderExtensions : ObjectBase<UMovieSceneFolderExtensions>
{

    public bool SetFolderName(UMovieSceneFolder* Folder, FName InFolderName)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InFolderName", InFolderName)
        ];
        return ProcessEvent<bool>(GetFunction("SetFolderName"),  @params);
    }
    public bool SetFolderColor(UMovieSceneFolder* Folder, FColor InFolderColor)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InFolderColor", InFolderColor)
        ];
        return ProcessEvent<bool>(GetFunction("SetFolderColor"),  @params);
    }
    public bool RemoveChildObjectBinding(UMovieSceneFolder* Folder, FSequencerBindingProxy InObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InObjectBinding", InObjectBinding)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveChildObjectBinding"),  @params);
    }
    public bool RemoveChildMasterTrack(UMovieSceneFolder* Folder, UMovieSceneTrack* InMasterTrack)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InMasterTrack", (IntPtr)InMasterTrack)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveChildMasterTrack"),  @params);
    }
    public bool RemoveChildFolder(UMovieSceneFolder* TargetFolder, UMovieSceneFolder* FolderToRemove)
    {
        Span<(string name, object value)> @params = [
            ("TargetFolder", (IntPtr)TargetFolder), 
            ("FolderToRemove", (IntPtr)FolderToRemove)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveChildFolder"),  @params);
    }
    public FName GetFolderName(UMovieSceneFolder* Folder)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder)
        ];
        return ProcessEvent<FName>(GetFunction("GetFolderName"),  @params);
    }
    public FColor GetFolderColor(UMovieSceneFolder* Folder)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder)
        ];
        return ProcessEvent<FColor>(GetFunction("GetFolderColor"),  @params);
    }
    public TArray<FSequencerBindingProxy> GetChildObjectBindings(UMovieSceneFolder* Folder)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder)
        ];
        return ProcessEvent<TArray<FSequencerBindingProxy>>(GetFunction("GetChildObjectBindings"),  @params);
    }
    public TArray<IntPtr> GetChildMasterTracks(UMovieSceneFolder* Folder)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetChildMasterTracks"),  @params);
    }
    public TArray<IntPtr> GetChildFolders(UMovieSceneFolder* Folder)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetChildFolders"),  @params);
    }
    public bool AddChildObjectBinding(UMovieSceneFolder* Folder, FSequencerBindingProxy InObjectBinding)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InObjectBinding", InObjectBinding)
        ];
        return ProcessEvent<bool>(GetFunction("AddChildObjectBinding"),  @params);
    }
    public bool AddChildMasterTrack(UMovieSceneFolder* Folder, UMovieSceneTrack* InMasterTrack)
    {
        Span<(string name, object value)> @params = [
            ("Folder", (IntPtr)Folder), 
            ("InMasterTrack", (IntPtr)InMasterTrack)
        ];
        return ProcessEvent<bool>(GetFunction("AddChildMasterTrack"),  @params);
    }
    public bool AddChildFolder(UMovieSceneFolder* TargetFolder, UMovieSceneFolder* FolderToAdd)
    {
        Span<(string name, object value)> @params = [
            ("TargetFolder", (IntPtr)TargetFolder), 
            ("FolderToAdd", (IntPtr)FolderToAdd)
        ];
        return ProcessEvent<bool>(GetFunction("AddChildFolder"),  @params);
    }
}

public unsafe class MovieScenePropertyTrackExtensions : ObjectBase<UMovieScenePropertyTrackExtensions>
{

    public void SetPropertyNameAndPath(UMovieScenePropertyTrack* Track, ref FName InPropertyName, FString InPropertyPath)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("InPropertyName", InPropertyName), 
            ("InPropertyPath", InPropertyPath)
        ];
        ProcessEvent(GetFunction("SetPropertyNameAndPath"),  @params);
    }
    public void SetObjectPropertyClass(UMovieSceneObjectPropertyTrack* Track, UClass* PropertyClass)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("PropertyClass", (IntPtr)PropertyClass)
        ];
        ProcessEvent(GetFunction("SetObjectPropertyClass"),  @params);
    }
    public FName GetUniqueTrackName(UMovieScenePropertyTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<FName>(GetFunction("GetUniqueTrackName"),  @params);
    }
    public FString GetPropertyPath(UMovieScenePropertyTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<FString>(GetFunction("GetPropertyPath"),  @params);
    }
    public FName GetPropertyName(UMovieScenePropertyTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<FName>(GetFunction("GetPropertyName"),  @params);
    }
    public UClass* GetObjectPropertyClass(UMovieSceneObjectPropertyTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return (UClass*)ProcessEvent<IntPtr>(GetFunction("GetObjectPropertyClass"),  @params);
    }
}

public unsafe class MovieSceneScriptingKey : ObjectBase<UMovieSceneScriptingKey>
{
}

public unsafe class MovieSceneScriptingActorReferenceKey : ObjectBase<UMovieSceneScriptingActorReferenceKey>
{

    public void SetValue(ref FMovieSceneObjectBindingID InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public FMovieSceneObjectBindingID GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingChannel : ObjectBase<UMovieSceneScriptingChannel>
{

}

public unsafe class MovieSceneScriptingActorReferenceChannel : ObjectBase<UMovieSceneScriptingActorReferenceChannel>
{

    public void SetDefault(FMovieSceneObjectBindingID InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public FMovieSceneObjectBindingID GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetDefault"),  @params);
    }
    public UMovieSceneScriptingActorReferenceKey* AddKey(FFrameNumber InTime, FMovieSceneObjectBindingID NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingActorReferenceKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingBoolKey : ObjectBase<UMovieSceneScriptingBoolKey>
{

    public void SetValue(bool InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public bool GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class SequencerScriptingRange : ObjectBase<FSequencerScriptingRange>
{

}

public unsafe class MovieSceneScriptingBoolChannel : ObjectBase<UMovieSceneScriptingBoolChannel>
{

    public void SetDefault(bool InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public int GetNumKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumKeys"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public bool GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetDefault"),  @params);
    }
    public TArray<bool> EvaluateKeys(FSequencerScriptingRange Range, FFrameRate FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("FrameRate", FrameRate)
        ];
        return ProcessEvent<TArray<bool>>(GetFunction("EvaluateKeys"),  @params);
    }
    public FSequencerScriptingRange ComputeEffectiveRange()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSequencerScriptingRange>(GetFunction("ComputeEffectiveRange"),  @params);
    }
    public UMovieSceneScriptingBoolKey* AddKey(ref FFrameNumber InTime, bool NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingBoolKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingByteKey : ObjectBase<UMovieSceneScriptingByteKey>
{

    public void SetValue(byte InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public byte GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<byte>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingByteChannel : ObjectBase<UMovieSceneScriptingByteChannel>
{

    public void SetDefault(byte InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public byte GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<byte>(GetFunction("GetDefault"),  @params);
    }
    public UMovieSceneScriptingByteKey* AddKey(ref FFrameNumber InTime, byte NewValue, float SubFrame, ESequenceTimeUnit TimeUnit, EMovieSceneKeyInterpolation InInterpolation)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit), 
            ("InInterpolation", InInterpolation)
        ];
        return (UMovieSceneScriptingByteKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingEventKey : ObjectBase<UMovieSceneScriptingEventKey>
{

    public void SetValue(ref FMovieSceneEvent InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public FMovieSceneEvent GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMovieSceneEvent>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingEventChannel : ObjectBase<UMovieSceneScriptingEventChannel>
{

    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public UMovieSceneScriptingEventKey* AddKey(ref FFrameNumber InTime, FMovieSceneEvent NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingEventKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingFloatKey : ObjectBase<UMovieSceneScriptingFloatKey>
{

    public void SetValue(float InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetTangentWeightMode"),  @params);
    }
    public void SetTangentMode(ERichCurveTangentMode InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetTangentMode"),  @params);
    }
    public void SetLeaveTangentWeight(float InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetLeaveTangentWeight"),  @params);
    }
    public void SetLeaveTangent(float InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetLeaveTangent"),  @params);
    }
    public void SetInterpolationMode(ERichCurveInterpMode InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetInterpolationMode"),  @params);
    }
    public void SetArriveTangentWeight(float InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetArriveTangentWeight"),  @params);
    }
    public void SetArriveTangent(float InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetArriveTangent"),  @params);
    }
    public float GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
    public ERichCurveTangentWeightMode GetTangentWeightMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ERichCurveTangentWeightMode>(GetFunction("GetTangentWeightMode"),  @params);
    }
    public ERichCurveTangentMode GetTangentMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ERichCurveTangentMode>(GetFunction("GetTangentMode"),  @params);
    }
    public float GetLeaveTangentWeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLeaveTangentWeight"),  @params);
    }
    public float GetLeaveTangent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLeaveTangent"),  @params);
    }
    public ERichCurveInterpMode GetInterpolationMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ERichCurveInterpMode>(GetFunction("GetInterpolationMode"),  @params);
    }
    public float GetArriveTangentWeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetArriveTangentWeight"),  @params);
    }
    public float GetArriveTangent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetArriveTangent"),  @params);
    }
}

public unsafe class MovieSceneScriptingFloatChannel : ObjectBase<UMovieSceneScriptingFloatChannel>
{

    public void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
    {
        Span<(string name, object value)> @params = [
            ("InExtrapolation", InExtrapolation)
        ];
        ProcessEvent(GetFunction("SetPreInfinityExtrapolation"),  @params);
    }
    public void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
    {
        Span<(string name, object value)> @params = [
            ("InExtrapolation", InExtrapolation)
        ];
        ProcessEvent(GetFunction("SetPostInfinityExtrapolation"),  @params);
    }
    public void SetDefault(float InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public ERichCurveExtrapolation GetPreInfinityExtrapolation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ERichCurveExtrapolation>(GetFunction("GetPreInfinityExtrapolation"),  @params);
    }
    public ERichCurveExtrapolation GetPostInfinityExtrapolation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ERichCurveExtrapolation>(GetFunction("GetPostInfinityExtrapolation"),  @params);
    }
    public int GetNumKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumKeys"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public float GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDefault"),  @params);
    }
    public TArray<float> EvaluateKeys(FSequencerScriptingRange Range, FFrameRate FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("FrameRate", FrameRate)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("EvaluateKeys"),  @params);
    }
    public FSequencerScriptingRange ComputeEffectiveRange()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSequencerScriptingRange>(GetFunction("ComputeEffectiveRange"),  @params);
    }
    public UMovieSceneScriptingFloatKey* AddKey(ref FFrameNumber InTime, float NewValue, float SubFrame, ESequenceTimeUnit TimeUnit, EMovieSceneKeyInterpolation InInterpolation)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit), 
            ("InInterpolation", InInterpolation)
        ];
        return (UMovieSceneScriptingFloatKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingIntegerKey : ObjectBase<UMovieSceneScriptingIntegerKey>
{

    public void SetValue(int InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public int GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingIntegerChannel : ObjectBase<UMovieSceneScriptingIntegerChannel>
{

    public void SetDefault(int InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public int GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDefault"),  @params);
    }
    public UMovieSceneScriptingIntegerKey* AddKey(ref FFrameNumber InTime, int NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingIntegerKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingObjectPathKey : ObjectBase<UMovieSceneScriptingObjectPathKey>
{

    public void SetValue(UObject* InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", (IntPtr)InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public UObject* GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingObjectPathChannel : ObjectBase<UMovieSceneScriptingObjectPathChannel>
{

    public void SetDefault(UObject* InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", (IntPtr)InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public UObject* GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetDefault"),  @params);
    }
    public UMovieSceneScriptingObjectPathKey* AddKey(FFrameNumber InTime, UObject* NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", (IntPtr)NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingObjectPathKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneScriptingStringKey : ObjectBase<UMovieSceneScriptingStringKey>
{

    public void SetValue(FString InNewValue)
    {
        Span<(string name, object value)> @params = [
            ("InNewValue", InNewValue)
        ];
        ProcessEvent(GetFunction("SetValue"),  @params);
    }
    public void SetTime(ref FFrameNumber NewFrameNumber, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("NewFrameNumber", NewFrameNumber), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        ProcessEvent(GetFunction("SetTime"),  @params);
    }
    public FString GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetValue"),  @params);
    }
    public FFrameTime GetTime(ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("TimeUnit", TimeUnit)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("GetTime"),  @params);
    }
}

public unsafe class MovieSceneScriptingStringChannel : ObjectBase<UMovieSceneScriptingStringChannel>
{

    public void SetDefault(FString InDefaultValue)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultValue", InDefaultValue)
        ];
        ProcessEvent(GetFunction("SetDefault"),  @params);
    }
    public void RemoveKey(UMovieSceneScriptingKey* Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", (IntPtr)Key)
        ];
        ProcessEvent(GetFunction("RemoveKey"),  @params);
    }
    public void RemoveDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveDefault"),  @params);
    }
    public bool HasDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasDefault"),  @params);
    }
    public TArray<IntPtr> GetKeys()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetKeys"),  @params);
    }
    public FString GetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDefault"),  @params);
    }
    public UMovieSceneScriptingStringKey* AddKey(ref FFrameNumber InTime, FString NewValue, float SubFrame, ESequenceTimeUnit TimeUnit)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime), 
            ("NewValue", NewValue), 
            ("SubFrame", SubFrame), 
            ("TimeUnit", TimeUnit)
        ];
        return (UMovieSceneScriptingStringKey*)ProcessEvent<IntPtr>(GetFunction("AddKey"),  @params);
    }
}

public unsafe class MovieSceneSectionExtensions : ObjectBase<UMovieSceneSectionExtensions>
{

    public void SetStartFrameSeconds(UMovieSceneSection* Section, float StartTime)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("StartTime", StartTime)
        ];
        ProcessEvent(GetFunction("SetStartFrameSeconds"),  @params);
    }
    public void SetStartFrameBounded(UMovieSceneSection* Section, bool bIsBounded)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("bIsBounded", bIsBounded)
        ];
        ProcessEvent(GetFunction("SetStartFrameBounded"),  @params);
    }
    public void SetStartFrame(UMovieSceneSection* Section, int StartFrame)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("StartFrame", StartFrame)
        ];
        ProcessEvent(GetFunction("SetStartFrame"),  @params);
    }
    public void SetRangeSeconds(UMovieSceneSection* Section, float StartTime, float EndTime)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("StartTime", StartTime), 
            ("EndTime", EndTime)
        ];
        ProcessEvent(GetFunction("SetRangeSeconds"),  @params);
    }
    public void SetRange(UMovieSceneSection* Section, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        ProcessEvent(GetFunction("SetRange"),  @params);
    }
    public void SetEndFrameSeconds(UMovieSceneSection* Section, float EndTime)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("EndTime", EndTime)
        ];
        ProcessEvent(GetFunction("SetEndFrameSeconds"),  @params);
    }
    public void SetEndFrameBounded(UMovieSceneSection* Section, bool bIsBounded)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("bIsBounded", bIsBounded)
        ];
        ProcessEvent(GetFunction("SetEndFrameBounded"),  @params);
    }
    public void SetEndFrame(UMovieSceneSection* Section, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("EndFrame", EndFrame)
        ];
        ProcessEvent(GetFunction("SetEndFrame"),  @params);
    }
    public bool HasStartFrame(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<bool>(GetFunction("HasStartFrame"),  @params);
    }
    public bool HasEndFrame(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<bool>(GetFunction("HasEndFrame"),  @params);
    }
    public float GetStartFrameSeconds(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<float>(GetFunction("GetStartFrameSeconds"),  @params);
    }
    public int GetStartFrame(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<int>(GetFunction("GetStartFrame"),  @params);
    }
    public int GetParentSequenceFrame(UMovieSceneSubSection* Section, int InFrame, UMovieSceneSequence* ParentSequence)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("InFrame", InFrame), 
            ("ParentSequence", (IntPtr)ParentSequence)
        ];
        return ProcessEvent<int>(GetFunction("GetParentSequenceFrame"),  @params);
    }
    public float GetEndFrameSeconds(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<float>(GetFunction("GetEndFrameSeconds"),  @params);
    }
    public int GetEndFrame(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<int>(GetFunction("GetEndFrame"),  @params);
    }
    public TArray<IntPtr> GetChannels(UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetChannels"),  @params);
    }
    public TArray<IntPtr> FindChannelsByType(UMovieSceneSection* Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
    {
        Span<(string name, object value)> @params = [
            ("Section", (IntPtr)Section), 
            ("ChannelType", ChannelType)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindChannelsByType"),  @params);
    }
}

public unsafe class MovieSceneSequenceExtensions : ObjectBase<UMovieSceneSequenceExtensions>
{

    public void SortMarkedFrames(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        ProcessEvent(GetFunction("SortMarkedFrames"),  @params);
    }
    public void SetWorkRangeStart(UMovieSceneSequence* InSequence, float StartTimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("StartTimeInSeconds", StartTimeInSeconds)
        ];
        ProcessEvent(GetFunction("SetWorkRangeStart"),  @params);
    }
    public void SetWorkRangeEnd(UMovieSceneSequence* InSequence, float EndTimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("EndTimeInSeconds", EndTimeInSeconds)
        ];
        ProcessEvent(GetFunction("SetWorkRangeEnd"),  @params);
    }
    public void SetViewRangeStart(UMovieSceneSequence* InSequence, float StartTimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("StartTimeInSeconds", StartTimeInSeconds)
        ];
        ProcessEvent(GetFunction("SetViewRangeStart"),  @params);
    }
    public void SetViewRangeEnd(UMovieSceneSequence* InSequence, float EndTimeInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("EndTimeInSeconds", EndTimeInSeconds)
        ];
        ProcessEvent(GetFunction("SetViewRangeEnd"),  @params);
    }
    public void SetTickResolutionDirectly(UMovieSceneSequence* Sequence, FFrameRate TickResolution)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("TickResolution", TickResolution)
        ];
        ProcessEvent(GetFunction("SetTickResolutionDirectly"),  @params);
    }
    public void SetTickResolution(UMovieSceneSequence* Sequence, FFrameRate TickResolution)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("TickResolution", TickResolution)
        ];
        ProcessEvent(GetFunction("SetTickResolution"),  @params);
    }
    public void SetReadOnly(UMovieSceneSequence* Sequence, bool bInReadOnly)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("bInReadOnly", bInReadOnly)
        ];
        ProcessEvent(GetFunction("SetReadOnly"),  @params);
    }
    public void SetPlaybackStartSeconds(UMovieSceneSequence* Sequence, float StartTime)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("StartTime", StartTime)
        ];
        ProcessEvent(GetFunction("SetPlaybackStartSeconds"),  @params);
    }
    public void SetPlaybackStart(UMovieSceneSequence* Sequence, int StartFrame)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("StartFrame", StartFrame)
        ];
        ProcessEvent(GetFunction("SetPlaybackStart"),  @params);
    }
    public void SetPlaybackEndSeconds(UMovieSceneSequence* Sequence, float EndTime)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("EndTime", EndTime)
        ];
        ProcessEvent(GetFunction("SetPlaybackEndSeconds"),  @params);
    }
    public void SetPlaybackEnd(UMovieSceneSequence* Sequence, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("EndFrame", EndFrame)
        ];
        ProcessEvent(GetFunction("SetPlaybackEnd"),  @params);
    }
    public void SetMarkedFrame(UMovieSceneSequence* Sequence, int InMarkIndex, FFrameNumber InFrameNumber)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InMarkIndex", InMarkIndex), 
            ("InFrameNumber", InFrameNumber)
        ];
        ProcessEvent(GetFunction("SetMarkedFrame"),  @params);
    }
    public void SetEvaluationType(UMovieSceneSequence* InSequence, EMovieSceneEvaluationType InEvaluationType)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("InEvaluationType", InEvaluationType)
        ];
        ProcessEvent(GetFunction("SetEvaluationType"),  @params);
    }
    public void SetDisplayRate(UMovieSceneSequence* Sequence, FFrameRate DisplayRate)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("DisplayRate", DisplayRate)
        ];
        ProcessEvent(GetFunction("SetDisplayRate"),  @params);
    }
    public void SetClockSource(UMovieSceneSequence* InSequence, EUpdateClockSource InClockSource)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence), 
            ("InClockSource", InClockSource)
        ];
        ProcessEvent(GetFunction("SetClockSource"),  @params);
    }
    public FSequencerBindingProxy ResolveBindingID(UMovieSceneSequence* MasterSequence, FMovieSceneObjectBindingID InObjectBindingID)
    {
        Span<(string name, object value)> @params = [
            ("MasterSequence", (IntPtr)MasterSequence), 
            ("InObjectBindingID", InObjectBindingID)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("ResolveBindingID"),  @params);
    }
    public bool RemoveMasterTrack(UMovieSceneSequence* Sequence, UMovieSceneTrack* MasterTrack)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("MasterTrack", (IntPtr)MasterTrack)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveMasterTrack"),  @params);
    }
    public FSequencerScriptingRange MakeRangeSeconds(UMovieSceneSequence* Sequence, float StartTime, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("StartTime", StartTime), 
            ("Duration", Duration)
        ];
        return ProcessEvent<FSequencerScriptingRange>(GetFunction("MakeRangeSeconds"),  @params);
    }
    public FSequencerScriptingRange MakeRange(UMovieSceneSequence* Sequence, int StartFrame, int Duration)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("StartFrame", StartFrame), 
            ("Duration", Duration)
        ];
        return ProcessEvent<FSequencerScriptingRange>(GetFunction("MakeRange"),  @params);
    }
    public FMovieSceneObjectBindingID MakeBindingID(UMovieSceneSequence* MasterSequence, ref FSequencerBindingProxy InBinding, EMovieSceneObjectBindingSpace Space)
    {
        Span<(string name, object value)> @params = [
            ("MasterSequence", (IntPtr)MasterSequence), 
            ("InBinding", InBinding), 
            ("Space", Space)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("MakeBindingID"),  @params);
    }
    public TArray<IntPtr> LocateBoundObjects(UMovieSceneSequence* Sequence, ref FSequencerBindingProxy InBinding, UObject* Context)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InBinding", InBinding), 
            ("Context", (IntPtr)Context)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("LocateBoundObjects"),  @params);
    }
    public bool IsReadOnly(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<bool>(GetFunction("IsReadOnly"),  @params);
    }
    public float GetWorkRangeStart(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<float>(GetFunction("GetWorkRangeStart"),  @params);
    }
    public float GetWorkRangeEnd(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<float>(GetFunction("GetWorkRangeEnd"),  @params);
    }
    public float GetViewRangeStart(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<float>(GetFunction("GetViewRangeStart"),  @params);
    }
    public float GetViewRangeEnd(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<float>(GetFunction("GetViewRangeEnd"),  @params);
    }
    public FTimecode GetTimecodeSource(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<FTimecode>(GetFunction("GetTimecodeSource"),  @params);
    }
    public FFrameRate GetTickResolution(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<FFrameRate>(GetFunction("GetTickResolution"),  @params);
    }
    public TArray<FSequencerBindingProxy> GetSpawnables(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<FSequencerBindingProxy>>(GetFunction("GetSpawnables"),  @params);
    }
    public TArray<IntPtr> GetRootFoldersInSequence(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetRootFoldersInSequence"),  @params);
    }
    public TArray<FSequencerBindingProxy> GetPossessables(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<FSequencerBindingProxy>>(GetFunction("GetPossessables"),  @params);
    }
    public FMovieSceneObjectBindingID GetPortableBindingID(UMovieSceneSequence* MasterSequence, UMovieSceneSequence* DestinationSequence, ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("MasterSequence", (IntPtr)MasterSequence), 
            ("DestinationSequence", (IntPtr)DestinationSequence), 
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetPortableBindingID"),  @params);
    }
    public float GetPlaybackStartSeconds(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<float>(GetFunction("GetPlaybackStartSeconds"),  @params);
    }
    public int GetPlaybackStart(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<int>(GetFunction("GetPlaybackStart"),  @params);
    }
    public FSequencerScriptingRange GetPlaybackRange(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<FSequencerScriptingRange>(GetFunction("GetPlaybackRange"),  @params);
    }
    public float GetPlaybackEndSeconds(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<float>(GetFunction("GetPlaybackEndSeconds"),  @params);
    }
    public int GetPlaybackEnd(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<int>(GetFunction("GetPlaybackEnd"),  @params);
    }
    public UMovieScene* GetMovieScene(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return (UMovieScene*)ProcessEvent<IntPtr>(GetFunction("GetMovieScene"),  @params);
    }
    public TArray<IntPtr> GetMasterTracks(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetMasterTracks"),  @params);
    }
    public TArray<FMovieSceneMarkedFrame> GetMarkedFrames(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<FMovieSceneMarkedFrame>>(GetFunction("GetMarkedFrames"),  @params);
    }
    public EMovieSceneEvaluationType GetEvaluationType(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<EMovieSceneEvaluationType>(GetFunction("GetEvaluationType"),  @params);
    }
    public FFrameRate GetDisplayRate(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<FFrameRate>(GetFunction("GetDisplayRate"),  @params);
    }
    public EUpdateClockSource GetClockSource(UMovieSceneSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        return ProcessEvent<EUpdateClockSource>(GetFunction("GetClockSource"),  @params);
    }
    public TArray<FSequencerBindingProxy> GetBindings(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        return ProcessEvent<TArray<FSequencerBindingProxy>>(GetFunction("GetBindings"),  @params);
    }
    public FMovieSceneObjectBindingID GetBindingID(ref FSequencerBindingProxy InBinding)
    {
        Span<(string name, object value)> @params = [
            ("InBinding", InBinding)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetBindingID"),  @params);
    }
    public int FindNextMarkedFrame(UMovieSceneSequence* Sequence, FFrameNumber InFrameNumber, bool bForward)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InFrameNumber", InFrameNumber), 
            ("bForward", bForward)
        ];
        return ProcessEvent<int>(GetFunction("FindNextMarkedFrame"),  @params);
    }
    public TArray<IntPtr> FindMasterTracksByType(UMovieSceneSequence* Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("TrackType", TrackType)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindMasterTracksByType"),  @params);
    }
    public TArray<IntPtr> FindMasterTracksByExactType(UMovieSceneSequence* Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("TrackType", TrackType)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindMasterTracksByExactType"),  @params);
    }
    public int FindMarkedFrameByLabel(UMovieSceneSequence* Sequence, FString InLabel)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InLabel", InLabel)
        ];
        return ProcessEvent<int>(GetFunction("FindMarkedFrameByLabel"),  @params);
    }
    public int FindMarkedFrameByFrameNumber(UMovieSceneSequence* Sequence, FFrameNumber InFrameNumber)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InFrameNumber", InFrameNumber)
        ];
        return ProcessEvent<int>(GetFunction("FindMarkedFrameByFrameNumber"),  @params);
    }
    public FSequencerBindingProxy FindBindingByName(UMovieSceneSequence* Sequence, FString Name)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("Name", Name)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("FindBindingByName"),  @params);
    }
    public FSequencerBindingProxy FindBindingById(UMovieSceneSequence* Sequence, FGuid BindingID)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("BindingID", BindingID)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("FindBindingById"),  @params);
    }
    public void DeleteMarkedFrames(UMovieSceneSequence* Sequence)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence)
        ];
        ProcessEvent(GetFunction("DeleteMarkedFrames"),  @params);
    }
    public void DeleteMarkedFrame(UMovieSceneSequence* Sequence, int DeleteIndex)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("DeleteIndex", DeleteIndex)
        ];
        ProcessEvent(GetFunction("DeleteMarkedFrame"),  @params);
    }
    public FSequencerBindingProxy AddSpawnableFromInstance(UMovieSceneSequence* Sequence, UObject* ObjectToSpawn)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("ObjectToSpawn", (IntPtr)ObjectToSpawn)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("AddSpawnableFromInstance"),  @params);
    }
    public FSequencerBindingProxy AddSpawnableFromClass(UMovieSceneSequence* Sequence, UClass* ClassToSpawn)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("ClassToSpawn", (IntPtr)ClassToSpawn)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("AddSpawnableFromClass"),  @params);
    }
    public UMovieSceneFolder* AddRootFolderToSequence(UMovieSceneSequence* Sequence, FString NewFolderName)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("NewFolderName", NewFolderName)
        ];
        return (UMovieSceneFolder*)ProcessEvent<IntPtr>(GetFunction("AddRootFolderToSequence"),  @params);
    }
    public FSequencerBindingProxy AddPossessable(UMovieSceneSequence* Sequence, UObject* ObjectToPossess)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("ObjectToPossess", (IntPtr)ObjectToPossess)
        ];
        return ProcessEvent<FSequencerBindingProxy>(GetFunction("AddPossessable"),  @params);
    }
    public UMovieSceneTrack* AddMasterTrack(UMovieSceneSequence* Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("TrackType", TrackType)
        ];
        return (UMovieSceneTrack*)ProcessEvent<IntPtr>(GetFunction("AddMasterTrack"),  @params);
    }
    public int AddMarkedFrame(UMovieSceneSequence* Sequence, ref FMovieSceneMarkedFrame InMarkedFrame)
    {
        Span<(string name, object value)> @params = [
            ("Sequence", (IntPtr)Sequence), 
            ("InMarkedFrame", InMarkedFrame)
        ];
        return ProcessEvent<int>(GetFunction("AddMarkedFrame"),  @params);
    }
}

public unsafe class MovieSceneTrackExtensions : ObjectBase<UMovieSceneTrackExtensions>
{

    public void SetSortingOrder(UMovieSceneTrack* Track, int SortingOrder)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("SortingOrder", SortingOrder)
        ];
        ProcessEvent(GetFunction("SetSortingOrder"),  @params);
    }
    public void SetSectionToKey(UMovieSceneTrack* Track, UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("Section", (IntPtr)Section)
        ];
        ProcessEvent(GetFunction("SetSectionToKey"),  @params);
    }
    public void SetDisplayName(UMovieSceneTrack* Track, ref FText InName)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("InName", InName)
        ];
        ProcessEvent(GetFunction("SetDisplayName"),  @params);
    }
    public void SetColorTint(UMovieSceneTrack* Track, ref FColor ColorTint)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("ColorTint", ColorTint)
        ];
        ProcessEvent(GetFunction("SetColorTint"),  @params);
    }
    public void RemoveSection(UMovieSceneTrack* Track, UMovieSceneSection* Section)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("Section", (IntPtr)Section)
        ];
        ProcessEvent(GetFunction("RemoveSection"),  @params);
    }
    public int GetSortingOrder(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<int>(GetFunction("GetSortingOrder"),  @params);
    }
    public UMovieSceneSection* GetSectionToKey(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return (UMovieSceneSection*)ProcessEvent<IntPtr>(GetFunction("GetSectionToKey"),  @params);
    }
    public TArray<IntPtr> GetSections(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetSections"),  @params);
    }
    public FText GetDisplayName(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<FText>(GetFunction("GetDisplayName"),  @params);
    }
    public FColor GetColorTint(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<FColor>(GetFunction("GetColorTint"),  @params);
    }
    public UMovieSceneSection* AddSection(UMovieSceneTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return (UMovieSceneSection*)ProcessEvent<IntPtr>(GetFunction("AddSection"),  @params);
    }
}

public unsafe class MovieSceneVectorTrackExtensions : ObjectBase<UMovieSceneVectorTrackExtensions>
{

    public void SetNumChannelsUsed(UMovieSceneVectorTrack* Track, int InNumChannelsUsed)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track), 
            ("InNumChannelsUsed", InNumChannelsUsed)
        ];
        ProcessEvent(GetFunction("SetNumChannelsUsed"),  @params);
    }
    public int GetNumChannelsUsed(UMovieSceneVectorTrack* Track)
    {
        Span<(string name, object value)> @params = [
            ("Track", (IntPtr)Track)
        ];
        return ProcessEvent<int>(GetFunction("GetNumChannelsUsed"),  @params);
    }
}

public unsafe class SequencerScriptingRangeExtensions : ObjectBase<USequencerScriptingRangeExtensions>
{

    public void SetStartSeconds(ref FSequencerScriptingRange Range, float Start)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("Start", Start)
        ];
        ProcessEvent(GetFunction("SetStartSeconds"),  @params);
    }
    public void SetStartFrame(ref FSequencerScriptingRange Range, int Start)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("Start", Start)
        ];
        ProcessEvent(GetFunction("SetStartFrame"),  @params);
    }
    public void SetEndSeconds(ref FSequencerScriptingRange Range, float End)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("End", End)
        ];
        ProcessEvent(GetFunction("SetEndSeconds"),  @params);
    }
    public void SetEndFrame(ref FSequencerScriptingRange Range, int End)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range), 
            ("End", End)
        ];
        ProcessEvent(GetFunction("SetEndFrame"),  @params);
    }
    public void RemoveStart(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        ProcessEvent(GetFunction("RemoveStart"),  @params);
    }
    public void RemoveEnd(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        ProcessEvent(GetFunction("RemoveEnd"),  @params);
    }
    public bool HasStart(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<bool>(GetFunction("HasStart"),  @params);
    }
    public bool HasEnd(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<bool>(GetFunction("HasEnd"),  @params);
    }
    public float GetStartSeconds(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<float>(GetFunction("GetStartSeconds"),  @params);
    }
    public int GetStartFrame(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<int>(GetFunction("GetStartFrame"),  @params);
    }
    public float GetEndSeconds(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<float>(GetFunction("GetEndSeconds"),  @params);
    }
    public int GetEndFrame(ref FSequencerScriptingRange Range)
    {
        Span<(string name, object value)> @params = [
            ("Range", Range)
        ];
        return ProcessEvent<int>(GetFunction("GetEndFrame"),  @params);
    }
}

