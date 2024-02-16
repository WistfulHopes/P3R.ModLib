using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FUim2DVertex
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FUim2DVertCol
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public uint Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FUim2DVertColUV
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public uint Color;
    [FieldOffset(0x000C)] public float U0;
    [FieldOffset(0x0010)] public float V0;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FUim2DVertUV
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float U0;
    [FieldOffset(0x000C)] public float V0;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FUim3DVertex
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FUim3DVertCol
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
    [FieldOffset(0x000C)] public uint Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FUim3DVertColUV
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
    [FieldOffset(0x000C)] public uint Color;
    [FieldOffset(0x0010)] public float U0;
    [FieldOffset(0x0014)] public float V0;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FUim3DVertUV
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
    [FieldOffset(0x000C)] public float U0;
    [FieldOffset(0x0010)] public float V0;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FUimData
{
    [FieldOffset(0x0000)] public uint frameSkip;
    [FieldOffset(0x0004)] public int frameNum;
    [FieldOffset(0x0008)] public int vertexNum;
    [FieldOffset(0x000C)] public int polygonNum;
    [FieldOffset(0x0010)] public int indexNum;
    [FieldOffset(0x0014)] public int coordinate;
    [FieldOffset(0x0018)] public int geomFormat;
    [FieldOffset(0x001C)] public int animFormat;
    [FieldOffset(0x0020)] public TArray<FUim2DVertex> p2DGeomVertex;
    [FieldOffset(0x0030)] public TArray<FUim2DVertCol> p2DGeomVertCol;
    [FieldOffset(0x0040)] public TArray<FUim2DVertColUV> p2DGeomVertColUV;
    [FieldOffset(0x0050)] public TArray<FUim2DVertUV> p2DGeomVertUV;
    [FieldOffset(0x0060)] public TArray<FUim2DVertex> p2DAnimVertex;
    [FieldOffset(0x0070)] public TArray<FUim2DVertCol> p2DAnimVertCol;
    [FieldOffset(0x0080)] public TArray<FUim2DVertColUV> p2DAnimVertColUV;
    [FieldOffset(0x0090)] public TArray<FUim2DVertUV> p2DAnimVertUV;
    [FieldOffset(0x00A0)] public TArray<FUim3DVertex> p3DGeomVertex;
    [FieldOffset(0x00B0)] public TArray<FUim3DVertCol> p3DGeomVertCol;
    [FieldOffset(0x00C0)] public TArray<FUim3DVertColUV> p3DGeomVertColUV;
    [FieldOffset(0x00D0)] public TArray<FUim3DVertUV> p3DGeomVertUV;
    [FieldOffset(0x00E0)] public TArray<FUim3DVertex> p3DAnimVertex;
    [FieldOffset(0x00F0)] public TArray<FUim3DVertCol> p3DAnimVertCol;
    [FieldOffset(0x0100)] public TArray<FUim3DVertColUV> p3DAnimVertColUV;
    [FieldOffset(0x0110)] public TArray<FUim3DVertUV> p3DAnimVertUV;
    [FieldOffset(0x0120)] public TArray<ushort> Indices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UUimAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FUimData UimData;
}

