using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSequencerBindingProxy
{
    [FieldOffset(0x0000)] public FGuid BindingID;
    [FieldOffset(0x0010)] public UMovieSceneSequence* Sequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneBindingExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneEventTrackExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneFolderExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieScenePropertyTrackExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMovieSceneScriptingKey
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingActorReferenceKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UMovieSceneScriptingChannel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName ChannelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingActorReferenceChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingBoolKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FSequencerScriptingRange
{
    [FieldOffset(0x0000)] public byte bHasStart;
    [FieldOffset(0x0000)] public byte bHasEnd;
    [FieldOffset(0x0004)] public int InclusiveStart;
    [FieldOffset(0x0008)] public int ExclusiveEnd;
    [FieldOffset(0x000C)] public FFrameRate InternalRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingBoolChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingByteKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingByteChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingEventKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingEventChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingFloatKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingFloatChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingIntegerKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingIntegerChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingObjectPathKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingObjectPathChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingStringKey
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingKey baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMovieSceneScriptingStringChannel
{
    [FieldOffset(0x0000)] public UMovieSceneScriptingChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneSectionExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneSequenceExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneTrackExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieSceneVectorTrackExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USequencerScriptingRangeExtensions
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

