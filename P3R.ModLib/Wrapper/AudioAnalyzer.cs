using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AudioAnalyzerAsset : ObjectBase<UAudioAnalyzerAsset>
{
    public AudioAnalyzerAsset(IntPtr pointer) : base(pointer) {}}

public unsafe class AudioAnalyzerNRTSettings : ObjectBase<UAudioAnalyzerNRTSettings>
{
    public AudioAnalyzerNRTSettings(IntPtr pointer) : base(pointer) {}}

public unsafe class AudioAnalyzerNRT : ObjectBase<UAudioAnalyzerNRT>
{
    public AudioAnalyzerNRT(IntPtr pointer) : base(pointer) {}
}

