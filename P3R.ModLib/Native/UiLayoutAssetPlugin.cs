using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FUIColor
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float R;
    [FieldOffset(0x000C)] public float G;
    [FieldOffset(0x0010)] public float B;
    [FieldOffset(0x0014)] public float A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FUILayout
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float X;
    [FieldOffset(0x000C)] public float Y;
    [FieldOffset(0x0010)] public float Angle;
    [FieldOffset(0x0014)] public float Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FUITriangularCursor
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float X0;
    [FieldOffset(0x000C)] public float Y0;
    [FieldOffset(0x0010)] public float X1;
    [FieldOffset(0x0014)] public float Y1;
    [FieldOffset(0x0018)] public float X2;
    [FieldOffset(0x001C)] public float Y2;
}

