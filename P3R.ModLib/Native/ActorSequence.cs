using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FActorSequenceObjectReference
{
    [FieldOffset(0x0000)] public EActorSequenceObjectReferenceType Type;
    [FieldOffset(0x0004)] public FGuid ActorId;
    [FieldOffset(0x0018)] public FString PathToComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FActorSequenceObjectReferences
{
    [FieldOffset(0x0000)] public TArray<FActorSequenceObjectReference> Array;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FActorSequenceObjectReferenceMap
{
    [FieldOffset(0x0000)] public TArray<FGuid> BindingIds;
    [FieldOffset(0x0010)] public TArray<FActorSequenceObjectReferences> References;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UActorSequence
{
    [FieldOffset(0x0000)] public UMovieSceneSequence baseObj;
    [FieldOffset(0x0060)] public UMovieScene* MovieScene;
    [FieldOffset(0x0068)] public FActorSequenceObjectReferenceMap ObjectReferences;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UActorSequenceComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public FMovieSceneSequencePlaybackSettings PlaybackSettings;
    [FieldOffset(0x00C8)] public UActorSequence* Sequence;
    [FieldOffset(0x00D0)] public UActorSequencePlayer* SequencePlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E8)] 
public unsafe struct UActorSequencePlayer
{
    [FieldOffset(0x0000)] public UMovieSceneSequencePlayer baseObj;
}

