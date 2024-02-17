using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MobileInstalledContent : ObjectBase<UMobileInstalledContent>
{
    public MobileInstalledContent(IntPtr pointer) : base(pointer) {}
    public bool Mount(int PakOrder, FString MountPoint)
    {
        Span<(string name, object value)> @params = [
            ("PakOrder", PakOrder), 
            ("MountPoint", MountPoint)
        ];
        return ProcessEvent<bool>(GetFunction("Mount"), @params);
    }
    public float GetInstalledContentSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetInstalledContentSize"), @params);
    }
    public float GetDiskFreeSpace()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDiskFreeSpace"), @params);
    }
}

public unsafe class MobilePendingContent : ObjectBase<UMobilePendingContent>
{
    public MobilePendingContent(IntPtr pointer) : base(pointer) {}
    public float GetTotalDownloadedSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetTotalDownloadedSize"), @params);
    }
    public float GetRequiredDiskSpace()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRequiredDiskSpace"), @params);
    }
    public float GetInstallProgress()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetInstallProgress"), @params);
    }
    public FText GetDownloadStatusText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetDownloadStatusText"), @params);
    }
    public float GetDownloadSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDownloadSpeed"), @params);
    }
    public float GetDownloadSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDownloadSize"), @params);
    }
}

public unsafe class MobilePatchingLibrary : ObjectBase<UMobilePatchingLibrary>
{
    public MobilePatchingLibrary(IntPtr pointer) : base(pointer) {}
    public bool HasActiveWiFiConnection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasActiveWiFiConnection"), @params);
    }
    public TArray<FString> GetSupportedPlatformNames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("GetSupportedPlatformNames"), @params);
    }
    public UMobileInstalledContent* GetInstalledContent(FString InstallDirectory)
    {
        Span<(string name, object value)> @params = [
            ("InstallDirectory", InstallDirectory)
        ];
        return (UMobileInstalledContent*)ProcessEvent<IntPtr>(GetFunction("GetInstalledContent"), @params);
    }
    public FString GetActiveDeviceProfileName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetActiveDeviceProfileName"), @params);
    }
}

