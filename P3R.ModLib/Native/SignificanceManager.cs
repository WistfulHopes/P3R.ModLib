using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct USignificanceManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0108)] public FSoftClassPath SignificanceManagerClassName;
}

