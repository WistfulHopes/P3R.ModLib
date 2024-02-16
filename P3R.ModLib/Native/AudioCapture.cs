using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAudioCaptureDeviceInfo
{
    [FieldOffset(0x0000)] public FName DeviceName;
    [FieldOffset(0x0008)] public int NumInputChannels;
    [FieldOffset(0x000C)] public int SampleRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UAudioCapture
{
    [FieldOffset(0x0000)] public UAudioGenerator baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAudioCaptureFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x780)] 
public unsafe struct UAudioCaptureComponent
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
    [FieldOffset(0x06C0)] public int JitterLatencyFrames;
}

