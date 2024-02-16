using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FProcMeshTangent
{
    [FieldOffset(0x0000)] public FVector TangentX;
    [FieldOffset(0x000C)] public bool bFlipTangentY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetProceduralMeshLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FProcMeshVertex
{
    [FieldOffset(0x0000)] public FVector Position;
    [FieldOffset(0x000C)] public FVector Normal;
    [FieldOffset(0x0018)] public FProcMeshTangent Tangent;
    [FieldOffset(0x0028)] public FColor Color;
    [FieldOffset(0x002C)] public FVector2D UV0;
    [FieldOffset(0x0034)] public FVector2D UV1;
    [FieldOffset(0x003C)] public FVector2D UV2;
    [FieldOffset(0x0044)] public FVector2D UV3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FProcMeshSection
{
    [FieldOffset(0x0000)] public TArray<FProcMeshVertex> ProcVertexBuffer;
    [FieldOffset(0x0010)] public TArray<uint> ProcIndexBuffer;
    [FieldOffset(0x0020)] public FBox SectionLocalBox;
    [FieldOffset(0x003C)] public bool bEnableCollision;
    [FieldOffset(0x003D)] public bool bSectionVisible;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E0)] 
public unsafe struct UProceduralMeshComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0480)] public bool bUseComplexAsSimpleCollision;
    [FieldOffset(0x0481)] public bool bUseAsyncCooking;
    [FieldOffset(0x0488)] public UBodySetup* ProcMeshBodySetup;
    [FieldOffset(0x0490)] public TArray<FProcMeshSection> ProcMeshSections;
    [FieldOffset(0x04A0)] public TArray<FKConvexElem> CollisionConvexElems;
    [FieldOffset(0x04B0)] public FBoxSphereBounds LocalBounds;
    [FieldOffset(0x04D0)] public TArray<IntPtr> AsyncBodySetupQueue;
}

