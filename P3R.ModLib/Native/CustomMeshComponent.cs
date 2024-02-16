using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FCustomMeshTriangle
{
    [FieldOffset(0x0000)] public FVector Vertex0;
    [FieldOffset(0x000C)] public FVector Vertex1;
    [FieldOffset(0x0018)] public FVector Vertex2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UCustomMeshComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
}

