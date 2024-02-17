using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AudioSynesthesiaNRTSettings : ObjectBase<UAudioSynesthesiaNRTSettings>
{
    public AudioSynesthesiaNRTSettings(IntPtr pointer) : base(pointer) {}}

public unsafe class AudioSynesthesiaNRT : ObjectBase<UAudioSynesthesiaNRT>
{
    public AudioSynesthesiaNRT(IntPtr pointer) : base(pointer) {}}

public unsafe class ConstantQNRTSettings : ObjectBase<UConstantQNRTSettings>
{
    public ConstantQNRTSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class ConstantQNRT : ObjectBase<UConstantQNRT>
{
    public ConstantQNRT(IntPtr pointer) : base(pointer) {}
    public void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("InChannel", InChannel), 
            ("OutConstantQ", OutConstantQ)
        ];
        ProcessEvent(GetFunction("GetNormalizedChannelConstantQAtTime"), @params);
    }
    public void GetChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("InChannel", InChannel), 
            ("OutConstantQ", OutConstantQ)
        ];
        ProcessEvent(GetFunction("GetChannelConstantQAtTime"), @params);
    }
}

public unsafe class LoudnessNRTSettings : ObjectBase<ULoudnessNRTSettings>
{
    public LoudnessNRTSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class LoudnessNRT : ObjectBase<ULoudnessNRT>
{
    public LoudnessNRT(IntPtr pointer) : base(pointer) {}
    public void GetNormalizedLoudnessAtTime(float InSeconds, ref float OutLoudness)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("OutLoudness", OutLoudness)
        ];
        ProcessEvent(GetFunction("GetNormalizedLoudnessAtTime"), @params);
    }
    public void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("InChannel", InChannel), 
            ("OutLoudness", OutLoudness)
        ];
        ProcessEvent(GetFunction("GetNormalizedChannelLoudnessAtTime"), @params);
    }
    public void GetLoudnessAtTime(float InSeconds, ref float OutLoudness)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("OutLoudness", OutLoudness)
        ];
        ProcessEvent(GetFunction("GetLoudnessAtTime"), @params);
    }
    public void GetChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
    {
        Span<(string name, object value)> @params = [
            ("InSeconds", InSeconds), 
            ("InChannel", InChannel), 
            ("OutLoudness", OutLoudness)
        ];
        ProcessEvent(GetFunction("GetChannelLoudnessAtTime"), @params);
    }
}

public unsafe class OnsetNRTSettings : ObjectBase<UOnsetNRTSettings>
{
    public OnsetNRTSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class OnsetNRT : ObjectBase<UOnsetNRT>
{
    public OnsetNRT(IntPtr pointer) : base(pointer) {}
    public void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
    {
        Span<(string name, object value)> @params = [
            ("InStartSeconds", InStartSeconds), 
            ("InEndSeconds", InEndSeconds), 
            ("InChannel", InChannel), 
            ("OutOnsetTimestamps", OutOnsetTimestamps), 
            ("OutOnsetStrengths", OutOnsetStrengths)
        ];
        ProcessEvent(GetFunction("GetNormalizedChannelOnsetsBetweenTimes"), @params);
    }
    public void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
    {
        Span<(string name, object value)> @params = [
            ("InStartSeconds", InStartSeconds), 
            ("InEndSeconds", InEndSeconds), 
            ("InChannel", InChannel), 
            ("OutOnsetTimestamps", OutOnsetTimestamps), 
            ("OutOnsetStrengths", OutOnsetStrengths)
        ];
        ProcessEvent(GetFunction("GetChannelOnsetsBetweenTimes"), @params);
    }
}

