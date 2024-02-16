using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IPropertyAccess
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IPropertyEventBroadcaster
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IPropertyEventSubscriber
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPropertyAccessSegment
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public UStruct* Struct;
    [FieldOffset(0x0010)] public TFieldPath<FProperty> Property;
    [FieldOffset(0x0030)] public UFunction* Function;
    [FieldOffset(0x0038)] public int ArrayIndex;
    [FieldOffset(0x003C)] public ushort flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FPropertyAccessPath
{
    [FieldOffset(0x0000)] public int PathSegmentStartIndex;
    [FieldOffset(0x0004)] public int PathSegmentCount;
    [FieldOffset(0x0008)] public byte bHasEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPropertyAccessCopy
{
    [FieldOffset(0x0000)] public int AccessIndex;
    [FieldOffset(0x0004)] public int DestAccessStartIndex;
    [FieldOffset(0x0008)] public int DestAccessEndIndex;
    [FieldOffset(0x000C)] public EPropertyAccessCopyType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPropertyAccessCopyBatch
{
    [FieldOffset(0x0000)] public TArray<FPropertyAccessCopy> Copies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FPropertyAccessIndirectionChain
{
    [FieldOffset(0x0000)] public TFieldPath<FProperty> Property;
    [FieldOffset(0x0020)] public int IndirectionStartIndex;
    [FieldOffset(0x0024)] public int IndirectionEndIndex;
    [FieldOffset(0x0028)] public int eventId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPropertyAccessIndirection
{
    [FieldOffset(0x0000)] public TFieldPath<FArrayProperty> ArrayProperty;
    [FieldOffset(0x0020)] public UFunction* Function;
    [FieldOffset(0x0028)] public int ReturnBufferSize;
    [FieldOffset(0x002C)] public int ReturnBufferAlignment;
    [FieldOffset(0x0030)] public int ArrayIndex;
    [FieldOffset(0x0034)] public uint Offset;
    [FieldOffset(0x0038)] public EPropertyAccessObjectType ObjectType;
    [FieldOffset(0x0039)] public EPropertyAccessIndirectionType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FPropertyAccessLibrary
{
    [FieldOffset(0x0000)] public TArray<FPropertyAccessSegment> PathSegments;
    [FieldOffset(0x0010)] public TArray<FPropertyAccessPath> SrcPaths;
    [FieldOffset(0x0020)] public TArray<FPropertyAccessPath> DestPaths;
    [FieldOffset(0x0030)] public FPropertyAccessCopyBatch CopyBatches;
    [FieldOffset(0x0070)] public TArray<FPropertyAccessIndirectionChain> SrcAccesses;
    [FieldOffset(0x0080)] public TArray<FPropertyAccessIndirectionChain> DestAccesses;
    [FieldOffset(0x0090)] public TArray<FPropertyAccessIndirection> Indirections;
    [FieldOffset(0x00A0)] public TArray<int> EventAccessIndices;
}

