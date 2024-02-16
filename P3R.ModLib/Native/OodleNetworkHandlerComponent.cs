using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UOodleNetworkTrainerCommandlet
{
    [FieldOffset(0x0000)] public UCommandlet baseObj;
    [FieldOffset(0x0080)] public bool bCompressionTest;
    [FieldOffset(0x0084)] public int HashTableSize;
    [FieldOffset(0x0088)] public int DictionarySize;
    [FieldOffset(0x008C)] public int DictionaryTrials;
    [FieldOffset(0x0090)] public int TrialRandomness;
    [FieldOffset(0x0094)] public int TrialGenerations;
    [FieldOffset(0x0098)] public bool bNoTrials;
}

