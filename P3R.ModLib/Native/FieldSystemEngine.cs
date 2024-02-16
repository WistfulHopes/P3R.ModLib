using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AFieldSystemActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UFieldSystemComponent* FieldSystemComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UFieldSystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFieldObjectCommands
{
    [FieldOffset(0x0000)] public TArray<FName> TargetNames;
    [FieldOffset(0x0010)] public TArray<IntPtr> RootNodes;
    [FieldOffset(0x0020)] public TArray<IntPtr> MetaDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x520)] 
public unsafe struct UFieldSystemComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UFieldSystem* FieldSystem;
    [FieldOffset(0x0458)] public bool bIsWorldField;
    [FieldOffset(0x0459)] public bool bIsChaosField;
    [FieldOffset(0x0460)] public TArray<TSoftObjectPtr<AChaosSolverActor>> SupportedSolvers;
    [FieldOffset(0x0470)] public FFieldObjectCommands ConstructionCommands;
    [FieldOffset(0x04A0)] public FFieldObjectCommands BufferCommands;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFieldSystemMetaData
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UFieldSystemMetaDataIteration
{
    [FieldOffset(0x0000)] public UFieldSystemMetaData baseObj;
    [FieldOffset(0x00B0)] public int Iterations;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UFieldSystemMetaDataProcessingResolution
{
    [FieldOffset(0x0000)] public UFieldSystemMetaData baseObj;
    [FieldOffset(0x00B0)] public EFieldResolutionType ResolutionType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UFieldSystemMetaDataFilter
{
    [FieldOffset(0x0000)] public UFieldSystemMetaData baseObj;
    [FieldOffset(0x00B0)] public EFieldFilterType FilterType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFieldNodeBase
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFieldNodeInt
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFieldNodeFloat
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFieldNodeVector
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UUniformInteger
{
    [FieldOffset(0x0000)] public UFieldNodeInt baseObj;
    [FieldOffset(0x00B0)] public int Magnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct URadialIntMask
{
    [FieldOffset(0x0000)] public UFieldNodeInt baseObj;
    [FieldOffset(0x00B0)] public float Radius;
    [FieldOffset(0x00B4)] public FVector Position;
    [FieldOffset(0x00C0)] public int InteriorValue;
    [FieldOffset(0x00C4)] public int ExteriorValue;
    [FieldOffset(0x00C8)] public ESetMaskConditionType SetMaskCondition;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UUniformScalar
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UWaveScalar
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public FVector Position;
    [FieldOffset(0x00C0)] public float Wavelength;
    [FieldOffset(0x00C4)] public float Period;
    [FieldOffset(0x00C8)] public EWaveFunctionType Function;
    [FieldOffset(0x00C9)] public EFieldFalloffType Falloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct URadialFalloff
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public float MinRange;
    [FieldOffset(0x00B8)] public float MaxRange;
    [FieldOffset(0x00BC)] public float Default;
    [FieldOffset(0x00C0)] public float Radius;
    [FieldOffset(0x00C4)] public FVector Position;
    [FieldOffset(0x00D0)] public EFieldFalloffType Falloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UPlaneFalloff
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public float MinRange;
    [FieldOffset(0x00B8)] public float MaxRange;
    [FieldOffset(0x00BC)] public float Default;
    [FieldOffset(0x00C0)] public float Distance;
    [FieldOffset(0x00C4)] public FVector Position;
    [FieldOffset(0x00D0)] public FVector Normal;
    [FieldOffset(0x00DC)] public EFieldFalloffType Falloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UBoxFalloff
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public float MinRange;
    [FieldOffset(0x00B8)] public float MaxRange;
    [FieldOffset(0x00BC)] public float Default;
    [FieldOffset(0x00C0)] public FTransform Transform;
    [FieldOffset(0x00F0)] public EFieldFalloffType Falloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UNoiseField
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public float MinRange;
    [FieldOffset(0x00B4)] public float MaxRange;
    [FieldOffset(0x00C0)] public FTransform Transform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UUniformVector
{
    [FieldOffset(0x0000)] public UFieldNodeVector baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public FVector Direction;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct URadialVector
{
    [FieldOffset(0x0000)] public UFieldNodeVector baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B4)] public FVector Position;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct URandomVector
{
    [FieldOffset(0x0000)] public UFieldNodeVector baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UOperatorField
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
    [FieldOffset(0x00B0)] public float Magnitude;
    [FieldOffset(0x00B8)] public UFieldNodeBase* RightField;
    [FieldOffset(0x00C0)] public UFieldNodeBase* LeftField;
    [FieldOffset(0x00C8)] public EFieldOperationType Operation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UToIntegerField
{
    [FieldOffset(0x0000)] public UFieldNodeInt baseObj;
    [FieldOffset(0x00B0)] public UFieldNodeFloat* FloatField;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UToFloatField
{
    [FieldOffset(0x0000)] public UFieldNodeFloat baseObj;
    [FieldOffset(0x00B0)] public UFieldNodeInt* IntField;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UCullingField
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
    [FieldOffset(0x00B0)] public UFieldNodeBase* Culling;
    [FieldOffset(0x00B8)] public UFieldNodeBase* Field;
    [FieldOffset(0x00C0)] public EFieldCullingOperationType Operation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UReturnResultsTerminal
{
    [FieldOffset(0x0000)] public UFieldNodeBase baseObj;
}

