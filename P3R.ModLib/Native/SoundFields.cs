using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAmbisonicsEncodingSettings
{
    [FieldOffset(0x0000)] public USoundfieldEncodingSettingsBase baseObj;
    [FieldOffset(0x0028)] public int AmbisonicsOrder;
}

