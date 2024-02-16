using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDeveloperSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

