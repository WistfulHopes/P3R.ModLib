using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMeshReconstructorBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UMockDataMeshTrackerComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x0208)] public bool ScanWorld;
    [FieldOffset(0x0209)] public bool RequestNormals;
    [FieldOffset(0x020A)] public bool RequestVertexConfidence;
    [FieldOffset(0x020B)] public EMeshTrackerVertexColorMode VertexColorMode;
    [FieldOffset(0x0210)] public TArray<FColor> BlockVertexColors;
    [FieldOffset(0x0220)] public FLinearColor VertexColorFromConfidenceZero;
    [FieldOffset(0x0230)] public FLinearColor VertexColorFromConfidenceOne;
    [FieldOffset(0x0240)] public float UpdateInterval;
    [FieldOffset(0x0248)] public UMRMeshComponent* MRMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct UMRMeshComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0460)] public UMaterialInterface* Material;
    [FieldOffset(0x0468)] public UMaterialInterface* WireframeMaterial;
    [FieldOffset(0x0470)] public bool bCreateMeshProxySections;
    [FieldOffset(0x0471)] public bool bUpdateNavMeshOnMeshUpdate;
    [FieldOffset(0x0472)] public bool bNeverCreateCollisionMesh;
    [FieldOffset(0x0478)] public UBodySetup* CachedBodySetup;
    [FieldOffset(0x0480)] public TArray<IntPtr> BodySetups;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMRMeshConfiguration
{
}

