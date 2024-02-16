using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct ULevelVariantSets
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClass* DirectorClass;
    [FieldOffset(0x0030)] public TArray<IntPtr> VariantSets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct ALevelVariantSetsActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public FSoftObjectPath LevelVariantSets;
    [FieldOffset(0x0238)] public TMap<IntPtr, IntPtr> DirectorInstances;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct ULevelVariantSetsFunctionDirector
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCapturedPropSegment
{
    [FieldOffset(0x0000)] public FString PropertyName;
    [FieldOffset(0x0010)] public int PropertyIndex;
    [FieldOffset(0x0018)] public FString ComponentName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValue
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0088)] public TArray<TFieldPath<FProperty>> Properties;
    [FieldOffset(0x0098)] public TArray<int> PropertyIndices;
    [FieldOffset(0x00A8)] public TArray<FCapturedPropSegment> CapturedPropSegments;
    [FieldOffset(0x00B8)] public FString FullDisplayString;
    [FieldOffset(0x00C8)] public FName PropertySetterName;
    [FieldOffset(0x00D0)] public TMap<FString, FString> PropertySetterParameterDefaults;
    [FieldOffset(0x0120)] public bool bHasRecordedData;
    [FieldOffset(0x0128)] public UClass* LeafPropertyClass;
    [FieldOffset(0x0138)] public TArray<byte> ValueBytes;
    [FieldOffset(0x0148)] public EPropertyValueCategory PropCategory;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueTransform
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueVisibility
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueColor
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueMaterial
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueOption
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UPropertyValueSoftObject
{
    [FieldOffset(0x0000)] public UPropertyValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct ASwitchActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0238)] public USceneComponent* SceneComponent;
    [FieldOffset(0x0240)] public int LastSelectedOption;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FVariantDependency
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<UVariantSet> VariantSet;
    [FieldOffset(0x0028)] public TSoftObjectPtr<UVariant> Variant;
    [FieldOffset(0x0050)] public bool bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UVariant
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FVariantDependency> Dependencies;
    [FieldOffset(0x0038)] public FText DisplayText;
    [FieldOffset(0x0068)] public TArray<IntPtr> ObjectBindings;
    [FieldOffset(0x0078)] public UTexture2D* Thumbnail;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFunctionCaller
{
    [FieldOffset(0x0000)] public FName FunctionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UVariantObjectBinding
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString CachedActorLabel;
    [FieldOffset(0x0038)] public FSoftObjectPath ObjectPtr;
    [FieldOffset(0x0050)] public TLazyObjectPtr<UObject> LazyObjectPtr;
    [FieldOffset(0x0070)] public TArray<IntPtr> CapturedProperties;
    [FieldOffset(0x0080)] public TArray<FFunctionCaller> FunctionCallers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UVariantSet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FText DisplayText;
    [FieldOffset(0x0058)] public bool bExpanded;
    [FieldOffset(0x0060)] public TArray<IntPtr> Variants;
    [FieldOffset(0x0070)] public UTexture2D* Thumbnail;
}

