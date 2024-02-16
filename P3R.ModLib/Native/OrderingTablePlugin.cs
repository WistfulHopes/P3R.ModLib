using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UCacheData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> _ObjectCache;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UOrderingTableResourceCache
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> _CacheArray;
}

