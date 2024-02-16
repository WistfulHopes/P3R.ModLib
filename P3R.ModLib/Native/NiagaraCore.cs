using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraMergeable
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraDataInterfaceBase
{
    [FieldOffset(0x0000)] public UNiagaraMergeable baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNiagaraCompileHash
{
    [FieldOffset(0x0000)] public TArray<byte> DataHash;
}

