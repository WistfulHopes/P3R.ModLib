using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UML_MontageUtility
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AML_SplineActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UML_SplineComponent* _SplineComponent;
    [FieldOffset(0x0228)] public UML_TargetMarkerComponent* _TargetMarkerComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x550)] 
public unsafe struct UML_SplineComponent
{
    [FieldOffset(0x0000)] public USplineComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UML_TargetMarkerComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

