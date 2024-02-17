using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MotoSynthPreset : ObjectBase<UMotoSynthPreset>
{
    public MotoSynthPreset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MotoSynthSource : ObjectBase<UMotoSynthSource>
{
    public MotoSynthSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class SynthComponentMoto : ObjectBase<USynthComponentMoto>
{
    public SynthComponentMoto(IntPtr pointer) : base(pointer) {}
    public void SetSettings(ref FMotoSynthRuntimeSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetSettings"), @params);
    }
    public void SetRPM(float InRPM, float InTimeSec)
    {
        Span<(string name, object value)> @params = [
            ("InRPM", InRPM), 
            ("InTimeSec", InTimeSec)
        ];
        ProcessEvent(GetFunction("SetRPM"), @params);
    }
    public bool IsEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnabled"), @params);
    }
    public void GetRPMRange(ref float OutMinRPM, ref float OutMaxRPM)
    {
        Span<(string name, object value)> @params = [
            ("OutMinRPM", OutMinRPM), 
            ("OutMaxRPM", OutMaxRPM)
        ];
        ProcessEvent(GetFunction("GetRPMRange"), @params);
    }
}

