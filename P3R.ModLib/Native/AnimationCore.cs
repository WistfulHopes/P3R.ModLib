using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAnimationDataSourceRegistry
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TMap<FName, TWeakObjectPtr<UObject>> DataSources;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FCCDIKChainLink
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAxis
{
    [FieldOffset(0x0000)] public FVector Axis;
    [FieldOffset(0x000C)] public bool bInLocalSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FConstraintDescriptor
{
    [FieldOffset(0x0000)] public EConstraintType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FConstraintData
{
    [FieldOffset(0x0000)] public FConstraintDescriptor Constraint;
    [FieldOffset(0x0010)] public float Weight;
    [FieldOffset(0x0014)] public bool bMaintainOffset;
    [FieldOffset(0x0020)] public FTransform Offset;
    [FieldOffset(0x0050)] public FTransform CurrentTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FFilterOptionPerAxis
{
    [FieldOffset(0x0000)] public bool bX;
    [FieldOffset(0x0001)] public bool bY;
    [FieldOffset(0x0002)] public bool bZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FConstraintDescriptionEx
{
    [FieldOffset(0x0008)] public FFilterOptionPerAxis AxesFilterOption;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAimConstraintDescription
{
    [FieldOffset(0x0000)] public FConstraintDescriptionEx baseObj;
    [FieldOffset(0x0010)] public FAxis LookAt_Axis;
    [FieldOffset(0x0020)] public FAxis LookUp_Axis;
    [FieldOffset(0x0030)] public bool bUseLookUp;
    [FieldOffset(0x0034)] public FVector LookUpTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTransformConstraintDescription
{
    [FieldOffset(0x0000)] public FConstraintDescriptionEx baseObj;
    [FieldOffset(0x0010)] public ETransformConstraintType TransformType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD)] 
public unsafe struct FConstraintDescription
{
    [FieldOffset(0x0000)] public bool bTranslation;
    [FieldOffset(0x0001)] public bool bRotation;
    [FieldOffset(0x0002)] public bool bScale;
    [FieldOffset(0x0003)] public bool bParent;
    [FieldOffset(0x0004)] public FFilterOptionPerAxis TranslationAxes;
    [FieldOffset(0x0007)] public FFilterOptionPerAxis RotationAxes;
    [FieldOffset(0x000A)] public FFilterOptionPerAxis ScaleAxes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTransformConstraint
{
    [FieldOffset(0x0000)] public FConstraintDescription Operator;
    [FieldOffset(0x0010)] public FName SourceNode;
    [FieldOffset(0x0018)] public FName TargetNode;
    [FieldOffset(0x0020)] public float Weight;
    [FieldOffset(0x0024)] public bool bMaintainOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FConstraintOffset
{
    [FieldOffset(0x0000)] public FVector Translation;
    [FieldOffset(0x0010)] public FQuat Rotation;
    [FieldOffset(0x0020)] public FVector Scale;
    [FieldOffset(0x0030)] public FTransform Parent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9)] 
public unsafe struct FTransformFilter
{
    [FieldOffset(0x0000)] public FFilterOptionPerAxis TranslationFilter;
    [FieldOffset(0x0003)] public FFilterOptionPerAxis RotationFilter;
    [FieldOffset(0x0006)] public FFilterOptionPerAxis ScaleFilter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FEulerTransform
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FRotator Rotation;
    [FieldOffset(0x0018)] public FVector Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFABRIKChainLink
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNodeChain
{
    [FieldOffset(0x0000)] public TArray<FName> Nodes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNodeObject
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FName ParentName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FNodeHierarchyData
{
    [FieldOffset(0x0000)] public TArray<FNodeObject> Nodes;
    [FieldOffset(0x0010)] public TArray<FTransform> Transforms;
    [FieldOffset(0x0020)] public TMap<FName, int> NodeNameToIndexMapping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FNodeHierarchyWithUserData
{
    [FieldOffset(0x0008)] public FNodeHierarchyData Hierarchy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FTransformNoScale
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x0010)] public FQuat Rotation;
}

