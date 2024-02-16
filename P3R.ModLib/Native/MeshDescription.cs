using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FElementID
{
    [FieldOffset(0x0000)] public int IDValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FVertexID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FEdgeID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPolygonID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FVertexInstanceID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPolygonGroupID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FTriangleID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDEPRECATED_MeshDescription
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x390)] 
public unsafe struct UMeshDescriptionBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

