using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FMediaPlayerTrackOptions
{
    [FieldOffset(0x0000)] public int Audio;
    [FieldOffset(0x0004)] public int Caption;
    [FieldOffset(0x0008)] public int MetaData;
    [FieldOffset(0x000C)] public int Script;
    [FieldOffset(0x0010)] public int Subtitle;
    [FieldOffset(0x0014)] public int Text;
    [FieldOffset(0x0018)] public int Video;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMediaPlayerOptions
{
    [FieldOffset(0x0000)] public FMediaPlayerTrackOptions Tracks;
    [FieldOffset(0x0020)] public FTimespan SeekTime;
    [FieldOffset(0x0028)] public EMediaPlayerOptionBooleanOverride PlayOnOpen;
    [FieldOffset(0x0029)] public EMediaPlayerOptionBooleanOverride Loop;
}

