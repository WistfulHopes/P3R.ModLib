using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ACableActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UCableComponent* CableComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct UCableComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public bool bAttachStart;
    [FieldOffset(0x0479)] public bool bAttachEnd;
    [FieldOffset(0x0480)] public FComponentReference AttachEndTo;
    [FieldOffset(0x04A8)] public FName AttachEndToSocketName;
    [FieldOffset(0x04B0)] public FVector EndLocation;
    [FieldOffset(0x04BC)] public float CableLength;
    [FieldOffset(0x04C0)] public int NumSegments;
    [FieldOffset(0x04C4)] public float SubstepTime;
    [FieldOffset(0x04C8)] public int SolverIterations;
    [FieldOffset(0x04CC)] public bool bEnableStiffness;
    [FieldOffset(0x04CD)] public bool bUseSubstepping;
    [FieldOffset(0x04CE)] public bool bSkipCableUpdateWhenNotVisible;
    [FieldOffset(0x04CF)] public bool bSkipCableUpdateWhenNotOwnerRecentlyRendered;
    [FieldOffset(0x04D0)] public bool bEnableCollision;
    [FieldOffset(0x04D4)] public float CollisionFriction;
    [FieldOffset(0x04D8)] public FVector CableForce;
    [FieldOffset(0x04E4)] public float CableGravityScale;
    [FieldOffset(0x04E8)] public float CableWidth;
    [FieldOffset(0x04EC)] public int NumSides;
    [FieldOffset(0x04F0)] public float TileMaterial;
}

