using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FPlgPrimitiveData
{
    [FieldOffset(0x0000)] public TArray<FVector> Vertices;
    [FieldOffset(0x0010)] public TArray<ushort> Indices;
    [FieldOffset(0x0020)] public TArray<uint> Colors;
    [FieldOffset(0x0030)] public FName Name;
    [FieldOffset(0x0038)] public float MinX;
    [FieldOffset(0x003C)] public float MinY;
    [FieldOffset(0x0040)] public float MaxX;
    [FieldOffset(0x0044)] public float MaxY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPlgData
{
    [FieldOffset(0x0000)] public TArray<FPlgPrimitiveData> PlgDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPlgAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FPlgData PlgData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UPlgPrimitiveComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public UPlgAsset* PlgAsset;
    [FieldOffset(0x0480)] public int PlgPrimitiveNo;
}

