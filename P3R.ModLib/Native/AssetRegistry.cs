using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x850)] 
public unsafe struct UAssetRegistryImpl
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTagAndValue
{
    [FieldOffset(0x0000)] public FName Tag;
    [FieldOffset(0x0008)] public FString Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAssetRegistryHelpers
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5)] 
public unsafe struct FAssetRegistryDependencyOptions
{
    [FieldOffset(0x0000)] public bool bIncludeSoftPackageReferences;
    [FieldOffset(0x0001)] public bool bIncludeHardPackageReferences;
    [FieldOffset(0x0002)] public bool bIncludeSearchableNames;
    [FieldOffset(0x0003)] public bool bIncludeSoftManagementReferences;
    [FieldOffset(0x0004)] public bool bIncludeHardManagementReferences;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAssetRegistry
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

