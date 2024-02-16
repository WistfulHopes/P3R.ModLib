using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UPakFile
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPakFileManagerControl
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPakFiledManagerGameInstanceSubSystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public UPakFileManagerControl* FileManagerControl;
}

