using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAssetTagsSubsystem
{
    [FieldOffset(0x0000)] public UEngineSubsystem baseObj;
}

