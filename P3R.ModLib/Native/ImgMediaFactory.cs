using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UImgMediaSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FFrameRate DefaultFrameRate;
    [FieldOffset(0x0030)] public float CacheBehindPercentage;
    [FieldOffset(0x0034)] public float CacheSizeGB;
    [FieldOffset(0x0038)] public int CacheThreads;
    [FieldOffset(0x003C)] public int CacheThreadStackSizeKB;
    [FieldOffset(0x0040)] public float GlobalCacheSizeGB;
    [FieldOffset(0x0044)] public bool UseGlobalCache;
    [FieldOffset(0x0048)] public uint ExrDecoderThreads;
    [FieldOffset(0x0050)] public FString DefaultProxy;
    [FieldOffset(0x0060)] public bool UseDefaultProxy;
}

