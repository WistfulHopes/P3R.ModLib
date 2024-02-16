using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AudioCaptureDeviceInfo : ObjectBase<FAudioCaptureDeviceInfo>
{

}

public unsafe class AudioCapture : ObjectBase<UAudioCapture>
{

    public void StopCapturingAudio()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopCapturingAudio"),  @params);
    }
    public void StartCapturingAudio()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartCapturingAudio"),  @params);
    }
    public bool IsCapturingAudio()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCapturingAudio"),  @params);
    }
    public bool GetAudioCaptureDeviceInfo(ref FAudioCaptureDeviceInfo OutInfo)
    {
        Span<(string name, object value)> @params = [
            ("OutInfo", OutInfo)
        ];
        return ProcessEvent<bool>(GetFunction("GetAudioCaptureDeviceInfo"),  @params);
    }
}

public unsafe class AudioCaptureFunctionLibrary : ObjectBase<UAudioCaptureFunctionLibrary>
{

    public UAudioCapture* CreateAudioCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAudioCapture*)ProcessEvent<IntPtr>(GetFunction("CreateAudioCapture"),  @params);
    }
}

public unsafe class AudioCaptureComponent : ObjectBase<UAudioCaptureComponent>
{

}

