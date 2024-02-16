using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FFontStyleData
{
    [FieldOffset(0x0000)] public float Scale;
    [FieldOffset(0x0004)] public float WidthScale;
    [FieldOffset(0x0008)] public int ColumnOffset;
    [FieldOffset(0x000C)] public int RowOffset;
    [FieldOffset(0x0010)] public float BaselineOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UFontStyleAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FFontStyleData MediumStyle;
    [FieldOffset(0x003C)] public FFontStyleData SmallStyle;
    [FieldOffset(0x0050)] public FFontStyleData SSmallStyle;
    [FieldOffset(0x0064)] public float ItalicOffset;
    [FieldOffset(0x0068)] public float PersonaStatusItalicOffset;
    [FieldOffset(0x006C)] public float TheurgiaItalicOffset;
}

