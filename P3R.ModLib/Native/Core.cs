using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public unsafe struct TArray<T> where T : unmanaged
{
    public T* AllocatorInstance;
    public int Num;
    public int Max;
}

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public unsafe struct TBitArray
{
    public bool* AllocatorInstance;
    public int NumBits;
    public int MaxBits;
}

public struct TSparseArrayElementOrFreeListLink<T> where T : unmanaged
{
    public T ElementData;
    public int FreeIndex; // union, either PreFreeIndex or NextFreeIndex
}

public unsafe struct TSparseArray<T> where T : unmanaged
{
    public TArray<TSparseArrayElementOrFreeListLink<T>> Data;
    public TBitArray AllocationFlags;
    public int FirstFreeIndex;
    public int NumFreeIndices;
}

[StructLayout(LayoutKind.Sequential)]
public struct TSetEleemnt<T> where T : unmanaged
{
    public T Value;
    public int Index;
    public int HashIndex;
}

[StructLayout(LayoutKind.Sequential)]
public struct TSet<T> where T : unmanaged
{
    public TSparseArray<TSetEleemnt<T>> Elements;
    public int HashType;
    public int HashSize;
}

[StructLayout(LayoutKind.Sequential)]
public struct TMapElement<TMapInnerKeyType, TMapInnerValueType> 
    where TMapInnerKeyType : unmanaged
    where TMapInnerValueType : unmanaged
{
    public TMapInnerKeyType Key;
    public TMapInnerValueType Value;
    public long Padding; // Figure out what this is later
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct TMap<TMapInnerKeyType, TMapInnerValueType> 
    where TMapInnerKeyType : unmanaged
    where TMapInnerValueType : unmanaged
{
    public TMapElement<TMapInnerKeyType, TMapInnerValueType>* Elements;
    public int MapNum;
    public int MapMax;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct TSubclassOf<TClass>
    where TClass : unmanaged
{
    public TClass* Class;
}

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public unsafe struct FString
{
    public TArray<ushort> Data;
    
    public string? GetString()
    {
        return Marshal.PtrToStringAuto((IntPtr)Data.AllocatorInstance);
    }
}

[StructLayout(LayoutKind.Sequential, Size = 0x8)]
public struct FName
{
    public uint ComparisonIndex;
    public uint Number;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FText
{
    public void* Data;
    public void* SharedRefCollector;
    public uint Flags;
    public uint Unk;
}

[StructLayout(LayoutKind.Sequential)]
public struct FWeakObjectPtr
{
    public int ObjectIndex;
    public int ObjectSerialNumber;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct TWeakObjectPtr<T> where T : unmanaged
{
    private FWeakObjectPtr baseObj;

    T* Get()
    {
        throw new NotImplementedException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FScriptInterface
{
    public UObject* ObjectPointer;
    public void* InterfacePointer;
}

[StructLayout(LayoutKind.Sequential)]
public struct TScriptInterface<T> where T : unmanaged
{
    public FScriptInterface baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct TPersistentObjectPtr<T> where T : unmanaged
{
    public FWeakObjectPtr WeakPtr;
    public int TagAtLastTest;
    public T ObjectId;
}

[StructLayout(LayoutKind.Sequential)]
public struct FUniqueObjectGuid
{
    public FGuid Guid;
}

[StructLayout(LayoutKind.Sequential)]
public struct FLazyObjectPtr
{
    public TPersistentObjectPtr<FUniqueObjectGuid> baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct TLazyObjectPtr<T> where T : unmanaged
{
    public FLazyObjectPtr baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FSoftObjectPtr
{
    public TPersistentObjectPtr<FSoftObjectPath> baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct TSoftObjectPtr<T> where T : unmanaged
{
    public FSoftObjectPtr baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct TSoftClassPtr<T> where T : unmanaged
{
    public FSoftObjectPtr baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FField
{
    
}

[StructLayout(LayoutKind.Sequential)]
public struct FProperty
{
    public FField baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FArrayProperty
{
    public FProperty baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FNumericProperty
{
    public FProperty baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FFloatProperty
{
    public FNumericProperty baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public struct FStructProperty
{
    public FProperty baseObj;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FFieldPath
{
    public FField* ResolvedField;
    public TWeakObjectPtr<UStruct> ResolvedOwner;
    public TArray<FName> Path;
}

[StructLayout(LayoutKind.Sequential)]
public struct TFieldPath<T> where T : unmanaged
{
    public FFieldPath baseObj;
}