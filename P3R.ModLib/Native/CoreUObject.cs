using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

public enum EObjectFlags : uint
{
    Public = 1 << 0x0,
    Standalone = 1 << 0x1,
    MarkAsNative = 1 << 0x2,
    Transactional = 1 << 0x3,
    ClassDefaultObject = 1 << 0x4,
    ArchetypeObject = 1 << 0x5,
    Transient = 1 << 0x6,
    MarkAsRootSet = 1 << 0x7,
    TagGarbageTemp = 1 << 0x8,
    NeedInitialization = 1 << 0x9,
    NeedLoad = 1 << 0xa,
    KeepForCooker = 1 << 0xb,
    NeedPostLoad = 1 << 0xc,
    NeedPostLoadSubobjects = 1 << 0xd,
    NewerVersionExists = 1 << 0xe,
    BeginDestroyed = 1 << 0xf,
    FinishDestroyed = 1 << 0x10,
    BeingRegenerated = 1 << 0x11,
    DefaultSubObject = 1 << 0x12,
    WasLoaded = 1 << 0x13,
    TextExportTransient = 1 << 0x14,
    LoadCompleted = 1 << 0x15,
    InheritableComponentTemplate = 1 << 0x16,
    DuplicateTransient = 1 << 0x17,
    StrongRefOnFrame = 1 << 0x18,
    NonPIEDuplicateTransient = 1 << 0x19,
    Dynamic = 1 << 0x1a,
    WillBeLoaded = 1 << 0x1b,
    HasExternalPackage = 1 << 0x1c,
    PendingKill = 1 << 0x1d,
    Garbage = 1 << 0x1e,
    AllocatedInSharedPage = (uint)1 << 0x1f
}

[StructLayout(LayoutKind.Sequential, Size = 0x28)] 
public unsafe struct UObject
{
    public IntPtr _vtable; // @ 0x0
    public EObjectFlags ObjectFlags; // @ 0x8
    public uint InternalIndex; // @ 0xc
    public UClass* ClassPrivate; // @ 0x10 Type of this object. Used for reflection
    public FName NamePrivate; // @ 0x18
    public UObject* OuterPrivate; // @ 0x20 Object that is containing this object
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGuid
{
    [FieldOffset(0x0000)] public int A;
    [FieldOffset(0x0004)] public int B;
    [FieldOffset(0x0008)] public int C;
    [FieldOffset(0x000C)] public int D;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FFrameNumber
{
    [FieldOffset(0x0000)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFrameNumberRangeBound
{
    [FieldOffset(0x0000)] public ERangeBoundTypes Type;
    [FieldOffset(0x0004)] public FFrameNumber Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFrameNumberRange
{
    [FieldOffset(0x0000)] public FFrameNumberRangeBound LowerBound;
    [FieldOffset(0x0008)] public FFrameNumberRangeBound UpperBound;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVector
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FRotator
{
    [FieldOffset(0x0000)] public float Pitch;
    [FieldOffset(0x0004)] public float Yaw;
    [FieldOffset(0x0008)] public float Roll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FQuat
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
    [FieldOffset(0x000C)] public float W;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FTransform
{
    [FieldOffset(0x0000)] public FQuat Rotation;
    [FieldOffset(0x0010)] public FVector Translation;
    [FieldOffset(0x0020)] public FVector Scale3D;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FIntPoint
{
    [FieldOffset(0x0000)] public int X;
    [FieldOffset(0x0004)] public int Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVector4
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
    [FieldOffset(0x0008)] public float Z;
    [FieldOffset(0x000C)] public float W;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVector2D
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FBox
{
    [FieldOffset(0x0000)] public FVector Min;
    [FieldOffset(0x000C)] public FVector Max;
    [FieldOffset(0x0018)] public byte IsValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLinearColor
{
    [FieldOffset(0x0000)] public float R;
    [FieldOffset(0x0004)] public float G;
    [FieldOffset(0x0008)] public float B;
    [FieldOffset(0x000C)] public float A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit)] 
public unsafe struct UInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FIntVector
{
    [FieldOffset(0x0000)] public int X;
    [FieldOffset(0x0004)] public int Y;
    [FieldOffset(0x0008)] public int Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSoftObjectPath
{
    [FieldOffset(0x0000)] public FName AssetPathName;
    [FieldOffset(0x0008)] public FString SubPathString;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FColor
{
    [FieldOffset(0x0000)] public byte B;
    [FieldOffset(0x0001)] public byte G;
    [FieldOffset(0x0002)] public byte R;
    [FieldOffset(0x0003)] public byte A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFrameTime
{
    [FieldOffset(0x0000)] public FFrameNumber FrameNumber;
    [FieldOffset(0x0004)] public float SubFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFrameRate
{
    [FieldOffset(0x0000)] public int Numerator;
    [FieldOffset(0x0004)] public int Denominator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FTimecode
{
    [FieldOffset(0x0000)] public int Hours;
    [FieldOffset(0x0004)] public int Minutes;
    [FieldOffset(0x0008)] public int Seconds;
    [FieldOffset(0x000C)] public int Frames;
    [FieldOffset(0x0010)] public bool bDropFrameFormat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FQualifiedFrameTime
{
    [FieldOffset(0x0000)] public FFrameTime Time;
    [FieldOffset(0x0008)] public FFrameRate Rate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FUniqueNetIdWrapper
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FBoxSphereBounds
{
    [FieldOffset(0x0000)] public FVector Origin;
    [FieldOffset(0x000C)] public FVector BoxExtent;
    [FieldOffset(0x0018)] public float SphereRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPlane
{
    [FieldOffset(0x0000)] public FVector baseObj;
    [FieldOffset(0x000C)] public float W;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMatrix
{
    [FieldOffset(0x0000)] public FPlane XPlane;
    [FieldOffset(0x0010)] public FPlane YPlane;
    [FieldOffset(0x0020)] public FPlane ZPlane;
    [FieldOffset(0x0030)] public FPlane WPlane;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FInterpCurvePointVector
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0004)] public FVector OutVal;
    [FieldOffset(0x0010)] public FVector ArriveTangent;
    [FieldOffset(0x001C)] public FVector LeaveTangent;
    [FieldOffset(0x0028)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveVector
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointVector> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FInterpCurvePointQuat
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0010)] public FQuat OutVal;
    [FieldOffset(0x0020)] public FQuat ArriveTangent;
    [FieldOffset(0x0030)] public FQuat LeaveTangent;
    [FieldOffset(0x0040)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveQuat
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointQuat> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FInterpCurvePointFloat
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0004)] public float OutVal;
    [FieldOffset(0x0008)] public float ArriveTangent;
    [FieldOffset(0x000C)] public float LeaveTangent;
    [FieldOffset(0x0010)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveFloat
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointFloat> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FTimespan
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FBox2D
{
    [FieldOffset(0x0000)] public FVector2D Min;
    [FieldOffset(0x0008)] public FVector2D Max;
    [FieldOffset(0x0010)] public byte bIsValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSoftClassPath
{
    [FieldOffset(0x0000)] public FSoftObjectPath baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FAssetData
{
    [FieldOffset(0x0000)] public FName ObjectPath;
    [FieldOffset(0x0008)] public FName PackageName;
    [FieldOffset(0x0010)] public FName PackagePath;
    [FieldOffset(0x0018)] public FName AssetName;
    [FieldOffset(0x0020)] public FName AssetClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPrimaryAssetType
{
    [FieldOffset(0x0000)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPrimaryAssetId
{
    [FieldOffset(0x0000)] public FPrimaryAssetType PrimaryAssetType;
    [FieldOffset(0x0008)] public FName PrimaryAssetName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UGCObjectReferencer
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UTextBuffer
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UField
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UStruct
{
    [FieldOffset(0x0000)] public UField baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UScriptStruct
{
    [FieldOffset(0x0000)] public UStruct baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UPackage
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UClass
{
    [FieldOffset(0x0000)] public UStruct baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UFunction
{
    [FieldOffset(0x0000)] public UStruct baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UDelegateFunction
{
    [FieldOffset(0x0000)] public UFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct USparseDelegateFunction
{
    [FieldOffset(0x0000)] public UDelegateFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct UDynamicClass
{
    [FieldOffset(0x0000)] public UClass baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UPackageMap
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UEnum
{
    [FieldOffset(0x0000)] public UField baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E8)] 
public unsafe struct ULinkerPlaceholderClass
{
    [FieldOffset(0x0000)] public UClass baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct ULinkerPlaceholderExportObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ULinkerPlaceholderFunction
{
    [FieldOffset(0x0000)] public UFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMetaData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UObjectRedirector
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UProperty
{
    [FieldOffset(0x0000)] public UField baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UEnumProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UArrayProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UObjectPropertyBase
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBoolProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNumericProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UByteProperty
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UObjectProperty
{
    [FieldOffset(0x0000)] public UObjectPropertyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UClassProperty
{
    [FieldOffset(0x0000)] public UObjectProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UDelegateProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDoubleProperty
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UFloatProperty
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UIntProperty
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UInt8Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UInt16Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UInt64Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UInterfaceProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct ULazyObjectProperty
{
    [FieldOffset(0x0000)] public UObjectPropertyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UMapProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMulticastDelegateProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMulticastInlineDelegateProperty
{
    [FieldOffset(0x0000)] public UMulticastDelegateProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMulticastSparseDelegateProperty
{
    [FieldOffset(0x0000)] public UMulticastDelegateProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNameProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct USetProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct USoftObjectProperty
{
    [FieldOffset(0x0000)] public UObjectPropertyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct USoftClassProperty
{
    [FieldOffset(0x0000)] public USoftObjectProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UStrProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UStructProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UUInt16Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UUInt32Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UUInt64Property
{
    [FieldOffset(0x0000)] public UNumericProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UWeakObjectProperty
{
    [FieldOffset(0x0000)] public UObjectPropertyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UTextProperty
{
    [FieldOffset(0x0000)] public UProperty baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UPropertyWrapper
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UMulticastDelegatePropertyWrapper
{
    [FieldOffset(0x0000)] public UPropertyWrapper baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UMulticastInlineDelegatePropertyWrapper
{
    [FieldOffset(0x0000)] public UMulticastDelegatePropertyWrapper baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFloatInterval
{
    [FieldOffset(0x0000)] public float Min;
    [FieldOffset(0x0004)] public float Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInt32Interval
{
    [FieldOffset(0x0000)] public int Min;
    [FieldOffset(0x0004)] public int Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FARFilter
{
    [FieldOffset(0x0000)] public TArray<FName> PackageNames;
    [FieldOffset(0x0010)] public TArray<FName> PackagePaths;
    [FieldOffset(0x0020)] public TArray<FName> ObjectPaths;
    [FieldOffset(0x0030)] public TArray<FName> ClassNames;
    [FieldOffset(0x0090)] public TSet<FName> RecursiveClassesExclusionSet;
    [FieldOffset(0x00E0)] public bool bRecursivePaths;
    [FieldOffset(0x00E1)] public bool bRecursiveClasses;
    [FieldOffset(0x00E2)] public bool bIncludeOnlyOnDiskAssets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFloatRangeBound
{
    [FieldOffset(0x0000)] public ERangeBoundTypes Type;
    [FieldOffset(0x0004)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFloatRange
{
    [FieldOffset(0x0000)] public FFloatRangeBound LowerBound;
    [FieldOffset(0x0008)] public FFloatRangeBound UpperBound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDateTime
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FInterpCurvePointVector2D
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0004)] public FVector2D OutVal;
    [FieldOffset(0x000C)] public FVector2D ArriveTangent;
    [FieldOffset(0x0014)] public FVector2D LeaveTangent;
    [FieldOffset(0x001C)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveVector2D
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointVector2D> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTwoVectors
{
    [FieldOffset(0x0000)] public FVector v1;
    [FieldOffset(0x000C)] public FVector v2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FInterpCurvePointTwoVectors
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0004)] public FTwoVectors OutVal;
    [FieldOffset(0x001C)] public FTwoVectors ArriveTangent;
    [FieldOffset(0x0034)] public FTwoVectors LeaveTangent;
    [FieldOffset(0x004C)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveTwoVectors
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointTwoVectors> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInt32RangeBound
{
    [FieldOffset(0x0000)] public ERangeBoundTypes Type;
    [FieldOffset(0x0004)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FInt32Range
{
    [FieldOffset(0x0000)] public FInt32RangeBound LowerBound;
    [FieldOffset(0x0008)] public FInt32RangeBound UpperBound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FInterpCurvePointLinearColor
{
    [FieldOffset(0x0000)] public float InVal;
    [FieldOffset(0x0004)] public FLinearColor OutVal;
    [FieldOffset(0x0014)] public FLinearColor ArriveTangent;
    [FieldOffset(0x0024)] public FLinearColor LeaveTangent;
    [FieldOffset(0x0034)] public EInterpCurveMode InterpMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpCurveLinearColor
{
    [FieldOffset(0x0000)] public TArray<FInterpCurvePointLinearColor> Points;
    [FieldOffset(0x0010)] public bool bIsLooped;
    [FieldOffset(0x0014)] public float LoopKeyOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FRandomStream
{
    [FieldOffset(0x0000)] public int InitialSeed;
    [FieldOffset(0x0004)] public int Seed;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FPolyglotTextData
{
    [FieldOffset(0x0000)] public ELocalizedTextSourceCategory Category;
    [FieldOffset(0x0008)] public FString NativeCulture;
    [FieldOffset(0x0018)] public FString Namespace;
    [FieldOffset(0x0028)] public FString Key;
    [FieldOffset(0x0038)] public FString NativeString;
    [FieldOffset(0x0048)] public TMap<FString, FString> LocalizedStrings;
    [FieldOffset(0x0098)] public bool bIsMinimalPatch;
    [FieldOffset(0x00A0)] public FText CachedText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct FDefault__ScriptStruct
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FJoinabilitySettings
{
    [FieldOffset(0x0000)] public FName SessionName;
    [FieldOffset(0x0008)] public bool bPublicSearchable;
    [FieldOffset(0x0009)] public bool bAllowInvites;
    [FieldOffset(0x000A)] public bool bJoinViaPresence;
    [FieldOffset(0x000B)] public bool bJoinViaPresenceFriendsOnly;
    [FieldOffset(0x000C)] public int MaxPlayers;
    [FieldOffset(0x0010)] public int MaxPartySize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPackedNormal
{
    [FieldOffset(0x0000)] public byte X;
    [FieldOffset(0x0001)] public byte Y;
    [FieldOffset(0x0002)] public byte Z;
    [FieldOffset(0x0003)] public byte W;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPackedRGB10A2N
{
    [FieldOffset(0x0000)] public int Packed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPackedRGBA16N
{
    [FieldOffset(0x0000)] public int XY;
    [FieldOffset(0x0004)] public int ZW;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FOrientedBox
{
    [FieldOffset(0x0000)] public FVector Center;
    [FieldOffset(0x000C)] public FVector AxisX;
    [FieldOffset(0x0018)] public FVector AxisY;
    [FieldOffset(0x0024)] public FVector AxisZ;
    [FieldOffset(0x0030)] public float ExtentX;
    [FieldOffset(0x0034)] public float ExtentY;
    [FieldOffset(0x0038)] public float ExtentZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FFallbackStruct
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAutomationEvent
{
    [FieldOffset(0x0000)] public EAutomationEventType Type;
    [FieldOffset(0x0008)] public FString Message;
    [FieldOffset(0x0018)] public FString Context;
    [FieldOffset(0x0028)] public FGuid Artifact;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FAutomationExecutionEntry
{
    [FieldOffset(0x0000)] public FAutomationEvent Event;
    [FieldOffset(0x0038)] public FString Filename;
    [FieldOffset(0x0048)] public int LineNumber;
    [FieldOffset(0x0050)] public FDateTime Timestamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAssetBundleEntry
{
    [FieldOffset(0x0000)] public FName BundleName;
    [FieldOffset(0x0008)] public TArray<FSoftObjectPath> BundleAssets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAssetBundleData
{
    [FieldOffset(0x0000)] public TArray<FAssetBundleEntry> Bundles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTestUninitializedScriptStructMembersTest
{
    [FieldOffset(0x0000)] public UObject* UninitializedObjectReference;
    [FieldOffset(0x0008)] public UObject* InitializedObjectReference;
    [FieldOffset(0x0010)] public float UnusedValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__Class
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__DynamicClass
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__LinkerPlaceholderClass
{
}

