using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class LipsAnalyzerBase : ObjectBase<ULipsAnalyzerBase>
{
    public LipsAnalyzerBase(IntPtr pointer) : base(pointer) {}
    public void SetSilenceThreshold(float VolumeDb)
    {
        Span<(string name, object value)> @params = [
            ("VolumeDb", VolumeDb)
        ];
        ProcessEvent(GetFunction("SetSilenceThreshold"), @params);
    }
    public void SetSamplingRate(int SamplingRateHz)
    {
        Span<(string name, object value)> @params = [
            ("SamplingRateHz", SamplingRateHz)
        ];
        ProcessEvent(GetFunction("SetSamplingRate"), @params);
    }
    public bool IsAtSilence()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAtSilence"), @params);
    }
    public void Init(int MaxInputSamplingRate)
    {
        Span<(string name, object value)> @params = [
            ("MaxInputSamplingRate", MaxInputSamplingRate)
        ];
        ProcessEvent(GetFunction("Init"), @params);
    }
    public float GetVolume()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetVolume"), @params);
    }
    public float GetSilenceThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSilenceThreshold"), @params);
    }
    public FCriLipsMorphTargetBlendAmountAsJapanese GetMorphTargetBlendAmountAsJapanese()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FCriLipsMorphTargetBlendAmountAsJapanese>(GetFunction("GetMorphTargetBlendAmountAsJapanese"), @params);
    }
    public FCriLipsMouthInfo GetInfoAtSilence()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FCriLipsMouthInfo>(GetFunction("GetInfoAtSilence"), @params);
    }
    public FCriLipsMouthInfo GetInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FCriLipsMouthInfo>(GetFunction("GetInfo"), @params);
    }
}

public unsafe class LipsAtomAnalyzer : ObjectBase<ULipsAtomAnalyzer>
{
    public LipsAtomAnalyzer(IntPtr pointer) : base(pointer) {}
    public void Detach()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Detach"), @params);
    }
    public void Attach(UAtomComponent* InAtomComponent)
    {
        Span<(string name, object value)> @params = [
            ("InAtomComponent", (IntPtr)InAtomComponent)
        ];
        ProcessEvent(GetFunction("Attach"), @params);
    }
}

