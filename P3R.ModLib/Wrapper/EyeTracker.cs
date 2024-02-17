using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class EyeTrackerFunctionLibrary : ObjectBase<UEyeTrackerFunctionLibrary>
{
    public EyeTrackerFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public void SetEyeTrackedPlayer(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        ProcessEvent(GetFunction("SetEyeTrackedPlayer"), @params);
    }
    public bool IsStereoGazeDataAvailable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsStereoGazeDataAvailable"), @params);
    }
    public bool IsEyeTrackerConnected()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEyeTrackerConnected"), @params);
    }
    public bool GetStereoGazeData(ref FEyeTrackerStereoGazeData OutGazeData)
    {
        Span<(string name, object value)> @params = [
            ("OutGazeData", OutGazeData)
        ];
        return ProcessEvent<bool>(GetFunction("GetStereoGazeData"), @params);
    }
    public bool GetGazeData(ref FEyeTrackerGazeData OutGazeData)
    {
        Span<(string name, object value)> @params = [
            ("OutGazeData", OutGazeData)
        ];
        return ProcessEvent<bool>(GetFunction("GetGazeData"), @params);
    }
}

