using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FStructSerializerNumericTestStruct
{
    [FieldOffset(0x0000)] public sbyte Int8;
    [FieldOffset(0x0002)] public short Int16;
    [FieldOffset(0x0004)] public int Int32;
    [FieldOffset(0x0008)] public long Int64;
    [FieldOffset(0x0010)] public byte UInt8;
    [FieldOffset(0x0012)] public ushort UInt16;
    [FieldOffset(0x0014)] public uint UInt32;
    [FieldOffset(0x0018)] public ulong UInt64;
    [FieldOffset(0x0020)] public float Float;
    [FieldOffset(0x0028)] public double Double;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FStructSerializerBooleanTestStruct
{
    [FieldOffset(0x0000)] public bool BoolFalse;
    [FieldOffset(0x0001)] public bool BoolTrue;
    [FieldOffset(0x0002)] public byte Bitfield0;
    [FieldOffset(0x0002)] public byte Bitfield1;
    [FieldOffset(0x0002)] public byte Bitfield2Set;
    [FieldOffset(0x0002)] public byte Bitfield3;
    [FieldOffset(0x0002)] public byte Bitfield4Set;
    [FieldOffset(0x0002)] public byte Bitfield5Set;
    [FieldOffset(0x0002)] public byte Bitfield6;
    [FieldOffset(0x0002)] public byte Bitfield7Set;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FStructSerializerObjectTestStruct
{
    [FieldOffset(0x0000)] public UClass* Class;
    [FieldOffset(0x0008)] public TSubclassOf<UMetaData> SubClass;
    [FieldOffset(0x0010)] public TSoftClassPtr<UMetaData> SoftClass;
    [FieldOffset(0x0038)] public UObject* Object;
    [FieldOffset(0x0040)] public TWeakObjectPtr<UMetaData> WeakObject;
    [FieldOffset(0x0048)] public TSoftObjectPtr<UMetaData> SoftObject;
    [FieldOffset(0x0070)] public FSoftClassPath ClassPath;
    [FieldOffset(0x0088)] public FSoftObjectPath ObjectPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FStructSerializerBuiltinTestStruct
{
    [FieldOffset(0x0000)] public FGuid Guid;
    [FieldOffset(0x0010)] public FName Name;
    [FieldOffset(0x0018)] public FString String;
    [FieldOffset(0x0028)] public FText Text;
    [FieldOffset(0x0040)] public FVector Vector;
    [FieldOffset(0x0050)] public FVector4 Vector4;
    [FieldOffset(0x0060)] public FRotator Rotator;
    [FieldOffset(0x0070)] public FQuat Quat;
    [FieldOffset(0x0080)] public FColor Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FStructSerializerArrayTestStruct
{
    [FieldOffset(0x0000)] public TArray<int> Int32Array;
    [FieldOffset(0x0010)] public TArray<byte> ByteArray;
    [FieldOffset(0x0020)] public int StaticSingleElement;
    [FieldOffset(0x0024)] public int StaticInt32Array;
    [FieldOffset(0x0030)] public float StaticFloatArray;
    [FieldOffset(0x0040)] public TArray<FVector> VectorArray;
    [FieldOffset(0x0050)] public TArray<FStructSerializerBuiltinTestStruct> StructArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct FStructSerializerMapTestStruct
{
    [FieldOffset(0x0000)] public TMap<int, FString> IntToStr;
    [FieldOffset(0x0050)] public TMap<FString, FString> StrToStr;
    [FieldOffset(0x00A0)] public TMap<FString, FVector> StrToVec;
    [FieldOffset(0x00F0)] public TMap<FString, FStructSerializerBuiltinTestStruct> StrToStruct;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct FStructSerializerSetTestStruct
{
    [FieldOffset(0x0000)] public TSet<FString> StrSet;
    [FieldOffset(0x0050)] public TSet<int> IntSet;
    [FieldOffset(0x00A0)] public TSet<FName> NameSet;
    [FieldOffset(0x00F0)] public TSet<FStructSerializerBuiltinTestStruct> StructSet;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct FStructSerializerTestStruct
{
    [FieldOffset(0x0000)] public FStructSerializerNumericTestStruct Numerics;
    [FieldOffset(0x0030)] public FStructSerializerBooleanTestStruct Booleans;
    [FieldOffset(0x0038)] public FStructSerializerObjectTestStruct objects;
    [FieldOffset(0x00E0)] public FStructSerializerBuiltinTestStruct Builtins;
    [FieldOffset(0x0170)] public FStructSerializerArrayTestStruct Arrays;
    [FieldOffset(0x01D0)] public FStructSerializerMapTestStruct Maps;
    [FieldOffset(0x0310)] public FStructSerializerSetTestStruct Sets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FStructSerializerByteArray
{
    [FieldOffset(0x0000)] public int Dummy1;
    [FieldOffset(0x0008)] public TArray<byte> ByteArray;
    [FieldOffset(0x0018)] public int Dummy2;
    [FieldOffset(0x0020)] public TArray<sbyte> Int8Array;
    [FieldOffset(0x0030)] public int Dummy3;
}

