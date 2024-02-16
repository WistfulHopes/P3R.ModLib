using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class Object : ObjectBase<UObject>
{

    public void ExecuteUbergraph(int EntryPoint)
    {
        Span<(string name, object value)> @params = [
            ("EntryPoint", EntryPoint)
        ];
        ProcessEvent(GetFunction("ExecuteUbergraph"),  @params);
    }
}

public unsafe class Vector : ObjectBase<FVector>
{

}

public unsafe class Rotator : ObjectBase<FRotator>
{

}

public unsafe class Transform : ObjectBase<FTransform>
{

}

public unsafe class Quat : ObjectBase<FQuat>
{

}

public unsafe class Vector4 : ObjectBase<FVector4>
{

}

public unsafe class Vector2D : ObjectBase<FVector2D>
{

}

public unsafe class Box : ObjectBase<FBox>
{

}

public unsafe class LinearColor : ObjectBase<FLinearColor>
{

}

public unsafe class Interface : ObjectBase<IInterface>
{
}

public unsafe class Guid : ObjectBase<FGuid>
{

}

public unsafe class Color : ObjectBase<FColor>
{

}

public unsafe class FrameNumber : ObjectBase<FFrameNumber>
{

}

public unsafe class FrameTime : ObjectBase<FFrameTime>
{

}

public unsafe class FrameRate : ObjectBase<FFrameRate>
{

}

public unsafe class Timecode : ObjectBase<FTimecode>
{

}

public unsafe class QualifiedFrameTime : ObjectBase<FQualifiedFrameTime>
{

}

public unsafe class UniqueNetIdWrapper : ObjectBase<FUniqueNetIdWrapper>
{
}

public unsafe class IntPoint : ObjectBase<FIntPoint>
{

}

public unsafe class Matrix : ObjectBase<FMatrix>
{

}

public unsafe class Timespan : ObjectBase<FTimespan>
{
}

public unsafe class SoftObjectPath : ObjectBase<FSoftObjectPath>
{

}

public unsafe class Plane : ObjectBase<FPlane>
{

}

public unsafe class BoxSphereBounds : ObjectBase<FBoxSphereBounds>
{

}

public unsafe class AssetData : ObjectBase<FAssetData>
{

}

public unsafe class GCObjectReferencer : ObjectBase<UGCObjectReferencer>
{
}

public unsafe class TextBuffer : ObjectBase<UTextBuffer>
{
}

public unsafe class Field : ObjectBase<UField>
{
}

public unsafe class Struct : ObjectBase<UStruct>
{
}

public unsafe class ScriptStruct : ObjectBase<UScriptStruct>
{
}

public unsafe class Package : ObjectBase<UPackage>
{
}

public unsafe class Class : ObjectBase<UClass>
{
}

public unsafe class Function : ObjectBase<UFunction>
{
}

public unsafe class DelegateFunction : ObjectBase<UDelegateFunction>
{
}

public unsafe class SparseDelegateFunction : ObjectBase<USparseDelegateFunction>
{
}

public unsafe class DynamicClass : ObjectBase<UDynamicClass>
{
}

public unsafe class PackageMap : ObjectBase<UPackageMap>
{
}

public unsafe class Enum : ObjectBase<UEnum>
{
}

public unsafe class LinkerPlaceholderClass : ObjectBase<ULinkerPlaceholderClass>
{
}

public unsafe class LinkerPlaceholderExportObject : ObjectBase<ULinkerPlaceholderExportObject>
{
}

public unsafe class LinkerPlaceholderFunction : ObjectBase<ULinkerPlaceholderFunction>
{
}

public unsafe class MetaData : ObjectBase<UMetaData>
{
}

public unsafe class ObjectRedirector : ObjectBase<UObjectRedirector>
{
}

public unsafe class Property : ObjectBase<UProperty>
{
}

public unsafe class EnumProperty : ObjectBase<UEnumProperty>
{
}

public unsafe class ArrayProperty : ObjectBase<UArrayProperty>
{
}

public unsafe class ObjectPropertyBase : ObjectBase<UObjectPropertyBase>
{
}

public unsafe class BoolProperty : ObjectBase<UBoolProperty>
{
}

public unsafe class NumericProperty : ObjectBase<UNumericProperty>
{
}

public unsafe class ByteProperty : ObjectBase<UByteProperty>
{
}

public unsafe class ObjectProperty : ObjectBase<UObjectProperty>
{
}

public unsafe class ClassProperty : ObjectBase<UClassProperty>
{
}

public unsafe class DelegateProperty : ObjectBase<UDelegateProperty>
{
}

public unsafe class DoubleProperty : ObjectBase<UDoubleProperty>
{
}

public unsafe class FloatProperty : ObjectBase<UFloatProperty>
{
}

public unsafe class IntProperty : ObjectBase<UIntProperty>
{
}

public unsafe class Int8Property : ObjectBase<UInt8Property>
{
}

public unsafe class Int16Property : ObjectBase<P3R.ModLib.Native.UInt16Property>
{
}

public unsafe class Int64Property : ObjectBase<P3R.ModLib.Native.UInt64Property>
{
}

public unsafe class InterfaceProperty : ObjectBase<UInterfaceProperty>
{
}

public unsafe class LazyObjectProperty : ObjectBase<ULazyObjectProperty>
{
}

public unsafe class MapProperty : ObjectBase<UMapProperty>
{
}

public unsafe class MulticastDelegateProperty : ObjectBase<UMulticastDelegateProperty>
{
}

public unsafe class MulticastInlineDelegateProperty : ObjectBase<UMulticastInlineDelegateProperty>
{
}

public unsafe class MulticastSparseDelegateProperty : ObjectBase<UMulticastSparseDelegateProperty>
{
}

public unsafe class NameProperty : ObjectBase<UNameProperty>
{
}

public unsafe class SetProperty : ObjectBase<USetProperty>
{
}

public unsafe class SoftObjectProperty : ObjectBase<USoftObjectProperty>
{
}

public unsafe class SoftClassProperty : ObjectBase<USoftClassProperty>
{
}

public unsafe class StrProperty : ObjectBase<UStrProperty>
{
}

public unsafe class StructProperty : ObjectBase<UStructProperty>
{
}

public unsafe class UInt16Property : ObjectBase<UUInt16Property>
{
}

public unsafe class UInt32Property : ObjectBase<UUInt32Property>
{
}

public unsafe class UInt64Property : ObjectBase<UUInt64Property>
{
}

public unsafe class WeakObjectProperty : ObjectBase<UWeakObjectProperty>
{
}

public unsafe class TextProperty : ObjectBase<UTextProperty>
{
}

public unsafe class PropertyWrapper : ObjectBase<UPropertyWrapper>
{
}

public unsafe class MulticastDelegatePropertyWrapper : ObjectBase<UMulticastDelegatePropertyWrapper>
{
}

public unsafe class MulticastInlineDelegatePropertyWrapper : ObjectBase<UMulticastInlineDelegatePropertyWrapper>
{
}

public unsafe class ARFilter : ObjectBase<FARFilter>
{

}

public unsafe class FloatRange : ObjectBase<FFloatRange>
{

}

public unsafe class SoftClassPath : ObjectBase<FSoftClassPath>
{
}

public unsafe class PrimaryAssetId : ObjectBase<FPrimaryAssetId>
{

}

public unsafe class DateTime : ObjectBase<FDateTime>
{
}

public unsafe class IntVector : ObjectBase<FIntVector>
{

}

public unsafe class RandomStream : ObjectBase<FRandomStream>
{

}

public unsafe class Box2D : ObjectBase<FBox2D>
{

}

public unsafe class PrimaryAssetType : ObjectBase<FPrimaryAssetType>
{

}

public unsafe class PolyglotTextData : ObjectBase<FPolyglotTextData>
{

}

public unsafe class Default__ScriptStruct : ObjectBase<FDefault__ScriptStruct>
{
}

public unsafe class JoinabilitySettings : ObjectBase<FJoinabilitySettings>
{

}

public unsafe class TwoVectors : ObjectBase<FTwoVectors>
{

}

public unsafe class PackedNormal : ObjectBase<FPackedNormal>
{

}

public unsafe class PackedRGB10A2N : ObjectBase<FPackedRGB10A2N>
{

}

public unsafe class PackedRGBA16N : ObjectBase<FPackedRGBA16N>
{

}

public unsafe class OrientedBox : ObjectBase<FOrientedBox>
{

}

public unsafe class InterpCurvePointFloat : ObjectBase<FInterpCurvePointFloat>
{

}

public unsafe class InterpCurveFloat : ObjectBase<FInterpCurveFloat>
{

}

public unsafe class InterpCurvePointVector2D : ObjectBase<FInterpCurvePointVector2D>
{

}

public unsafe class InterpCurveVector2D : ObjectBase<FInterpCurveVector2D>
{

}

public unsafe class InterpCurvePointVector : ObjectBase<FInterpCurvePointVector>
{

}

public unsafe class InterpCurveVector : ObjectBase<FInterpCurveVector>
{

}

public unsafe class InterpCurvePointQuat : ObjectBase<FInterpCurvePointQuat>
{

}

public unsafe class InterpCurveQuat : ObjectBase<FInterpCurveQuat>
{

}

public unsafe class InterpCurvePointTwoVectors : ObjectBase<FInterpCurvePointTwoVectors>
{

}

public unsafe class InterpCurveTwoVectors : ObjectBase<FInterpCurveTwoVectors>
{

}

public unsafe class InterpCurvePointLinearColor : ObjectBase<FInterpCurvePointLinearColor>
{

}

public unsafe class InterpCurveLinearColor : ObjectBase<FInterpCurveLinearColor>
{

}

public unsafe class FallbackStruct : ObjectBase<FFallbackStruct>
{
}

public unsafe class FloatRangeBound : ObjectBase<FFloatRangeBound>
{

}

public unsafe class Int32RangeBound : ObjectBase<FInt32RangeBound>
{

}

public unsafe class Int32Range : ObjectBase<FInt32Range>
{

}

public unsafe class FrameNumberRangeBound : ObjectBase<FFrameNumberRangeBound>
{

}

public unsafe class FrameNumberRange : ObjectBase<FFrameNumberRange>
{

}

public unsafe class FloatInterval : ObjectBase<FFloatInterval>
{

}

public unsafe class Int32Interval : ObjectBase<FInt32Interval>
{

}

public unsafe class AutomationEvent : ObjectBase<FAutomationEvent>
{

}

public unsafe class AutomationExecutionEntry : ObjectBase<FAutomationExecutionEntry>
{

}

public unsafe class AssetBundleEntry : ObjectBase<FAssetBundleEntry>
{

}

public unsafe class AssetBundleData : ObjectBase<FAssetBundleData>
{

}

public unsafe class TestUninitializedScriptStructMembersTest : ObjectBase<FTestUninitializedScriptStructMembersTest>
{

}

public unsafe class Default__Class : ObjectBase<UDefault__Class>
{
}

public unsafe class Default__DynamicClass : ObjectBase<UDefault__DynamicClass>
{
}

public unsafe class Default__LinkerPlaceholderClass : ObjectBase<UDefault__LinkerPlaceholderClass>
{
}

