using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FLeanAmount
{
    [FieldOffset(0x0000)] public float LR_17_ADF99333493B27F5B49BA89100DC4C05;
    [FieldOffset(0x0004)] public float FB_15_297866804FB14F4B81FB4A976A7F57D1;
}

