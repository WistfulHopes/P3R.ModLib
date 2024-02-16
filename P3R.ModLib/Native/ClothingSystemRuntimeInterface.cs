using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothConfigBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClothingSimulationFactory
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UClothingInteractor
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UClothingSimulationInteractor
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TMap<FName, IntPtr> ClothingInteractors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDEPRECATED_ClothSharedSimConfigBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UClothingAssetBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString ImportedFilePath;
    [FieldOffset(0x0038)] public FGuid AssetGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FClothVertBoneData
{
    [FieldOffset(0x0000)] public int NumInfluences;
    [FieldOffset(0x0004)] public ushort BoneIndices;
    [FieldOffset(0x001C)] public float BoneWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UClothPhysicalMeshDataBase_Legacy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FVector> Vertices;
    [FieldOffset(0x0038)] public TArray<FVector> Normals;
    [FieldOffset(0x0048)] public TArray<uint> Indices;
    [FieldOffset(0x0058)] public TArray<float> InverseMasses;
    [FieldOffset(0x0068)] public TArray<FClothVertBoneData> BoneData;
    [FieldOffset(0x0078)] public int NumFixedVerts;
    [FieldOffset(0x007C)] public int MaxBoneWeights;
    [FieldOffset(0x0080)] public TArray<uint> SelfCollisionIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FClothCollisionPrim_Sphere
{
    [FieldOffset(0x0000)] public int BoneIndex;
    [FieldOffset(0x0004)] public float Radius;
    [FieldOffset(0x0008)] public FVector LocalPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FClothCollisionPrim_SphereConnection
{
    [FieldOffset(0x0000)] public int SphereIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FClothCollisionPrim_ConvexFace
{
    [FieldOffset(0x0000)] public FPlane Plane;
    [FieldOffset(0x0010)] public TArray<int> Indices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FClothCollisionPrim_Convex
{
    [FieldOffset(0x0000)] public TArray<FClothCollisionPrim_ConvexFace> Faces;
    [FieldOffset(0x0010)] public TArray<FVector> SurfacePoints;
    [FieldOffset(0x0020)] public int BoneIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FClothCollisionPrim_Box
{
    [FieldOffset(0x0000)] public FVector LocalPosition;
    [FieldOffset(0x0010)] public FQuat LocalRotation;
    [FieldOffset(0x0020)] public FVector HalfExtents;
    [FieldOffset(0x002C)] public int BoneIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FClothCollisionData
{
    [FieldOffset(0x0000)] public TArray<FClothCollisionPrim_Sphere> Spheres;
    [FieldOffset(0x0010)] public TArray<FClothCollisionPrim_SphereConnection> SphereConnections;
    [FieldOffset(0x0020)] public TArray<FClothCollisionPrim_Convex> Convexes;
    [FieldOffset(0x0030)] public TArray<FClothCollisionPrim_Box> Boxes;
}

