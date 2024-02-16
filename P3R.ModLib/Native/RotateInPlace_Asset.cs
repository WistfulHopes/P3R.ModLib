using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRotateInPlace_Asset
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* Animation_2_7BA2980D4E85CC9E320EB98B57C73B3A;
    [FieldOffset(0x0008)] public FName SlotName_5_73864C9E40AE26D9F294038C7099722B;
    [FieldOffset(0x0010)] public float SlowTurnRate_9_47A596764C9AFE145D75C49448F776A8;
    [FieldOffset(0x0014)] public float FastTurnRate_17_566E906643D9AD8B150F87B98BBF88BB;
    [FieldOffset(0x0018)] public float SlowPlayRate_16_1F78888146721190E66721BAA545F229;
    [FieldOffset(0x001C)] public float FastPlayRate_18_730EF8A04D92C6D5D014CFBF34A93F2A;
}

