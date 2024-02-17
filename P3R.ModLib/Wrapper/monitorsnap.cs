using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MonitorBlueprintLibrary : ObjectBase<UMonitorBlueprintLibrary>
{
    public MonitorBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public bool NotEqual_MonitorHandleMonitorHandle(ref FMonitorHandle A, ref FMonitorHandle B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("NotEqual_MonitorHandleMonitorHandle"), @params);
    }
    public bool IsValid(ref FMonitorHandle MonitorHandle)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle)
        ];
        return ProcessEvent<bool>(GetFunction("IsValid"), @params);
    }
    public bool IsSupportedFullscreen(ref FMonitorHandle MonitorHandle)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle)
        ];
        return ProcessEvent<bool>(GetFunction("IsSupportedFullscreen"), @params);
    }
    public bool GetSupportedFullscreenResolutionsUniqueOnly(ref FMonitorHandle MonitorHandle, ref TArray<FMonitorResolution> OutResolutions)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle), 
            ("OutResolutions", OutResolutions)
        ];
        return ProcessEvent<bool>(GetFunction("GetSupportedFullscreenResolutionsUniqueOnly"), @params);
    }
    public bool GetSupportedFullscreenResolutions(ref FMonitorHandle MonitorHandle, ref TArray<FMonitorResolution> OutResolutions)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle), 
            ("OutResolutions", OutResolutions)
        ];
        return ProcessEvent<bool>(GetFunction("GetSupportedFullscreenResolutions"), @params);
    }
    public float GetRefreshRate(ref FMonitorResolution Resolution)
    {
        Span<(string name, object value)> @params = [
            ("Resolution", Resolution)
        ];
        return ProcessEvent<float>(GetFunction("GetRefreshRate"), @params);
    }
    public FMonitorHandle GetPrimaryMonitor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMonitorHandle>(GetFunction("GetPrimaryMonitor"), @params);
    }
    public void GetMonitorSize(ref FMonitorHandle MonitorHandle, ref int Width, ref int Height)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle), 
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetMonitorSize"), @params);
    }
    public FIntPoint GetMonitorPosition(ref FMonitorHandle MonitorHandle)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle)
        ];
        return ProcessEvent<FIntPoint>(GetFunction("GetMonitorPosition"), @params);
    }
    public FString GetMonitorName(ref FMonitorHandle MonitorHandle)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle)
        ];
        return ProcessEvent<FString>(GetFunction("GetMonitorName"), @params);
    }
    public FMonitorHandle GetCurrentMonitor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMonitorHandle>(GetFunction("GetCurrentMonitor"), @params);
    }
    public FMonitorResolution GetClosestEnclosingResolution(ref FMonitorHandle MonitorHandle, FIntPoint DesiredSize)
    {
        Span<(string name, object value)> @params = [
            ("MonitorHandle", MonitorHandle), 
            ("DesiredSize", DesiredSize)
        ];
        return ProcessEvent<FMonitorResolution>(GetFunction("GetClosestEnclosingResolution"), @params);
    }
    public TArray<FMonitorHandle> GetAvailableMonitors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FMonitorHandle>>(GetFunction("GetAvailableMonitors"), @params);
    }
    public bool EqualEqual_MonitorResolutionMonitorResolution(ref FMonitorResolution Left, ref FMonitorResolution Right)
    {
        Span<(string name, object value)> @params = [
            ("Left", Left), 
            ("Right", Right)
        ];
        return ProcessEvent<bool>(GetFunction("EqualEqual_MonitorResolutionMonitorResolution"), @params);
    }
    public bool EqualEqual_MonitorHandleMonitorHandle(ref FMonitorHandle A, ref FMonitorHandle B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("EqualEqual_MonitorHandleMonitorHandle"), @params);
    }
    public void ApplyMonitorSettings(ref FMonitorResolution Resolution, EWindowMode ScreenMode, ref FMonitorHandle Monitor, bool bCheckForCommandLineOverrides, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("Resolution", Resolution), 
            ("ScreenMode", ScreenMode), 
            ("Monitor", Monitor), 
            ("bCheckForCommandLineOverrides", bCheckForCommandLineOverrides), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("ApplyMonitorSettings"), @params);
    }
}

