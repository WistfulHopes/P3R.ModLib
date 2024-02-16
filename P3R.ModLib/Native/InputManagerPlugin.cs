using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x2840)] 
public unsafe struct AInputManager
{
    [FieldOffset(0x0000)] public APlayerController baseObj;
    [FieldOffset(0x0580)] public UInputComponent* mpDefaultInputComponent;
    [FieldOffset(0x0588)] public UInputComponent* mpCurrentInputComponent;
}

