using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x390)] 
public unsafe struct UStaticMeshDescription
{
    [FieldOffset(0x0000)] public UMeshDescriptionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FUVMapSettings
{
    [FieldOffset(0x0000)] public FVector Size;
    [FieldOffset(0x000C)] public FVector2D UVTile;
    [FieldOffset(0x0014)] public FVector Position;
    [FieldOffset(0x0020)] public FRotator Rotation;
    [FieldOffset(0x002C)] public FVector Scale;
}

