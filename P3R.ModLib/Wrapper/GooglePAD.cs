using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class GooglePADFunctionLibrary : ObjectBase<UGooglePADFunctionLibrary>
{

    public EGooglePADErrorCode ShowCellularDataConfirmation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("ShowCellularDataConfirmation"),  @params);
    }
    public EGooglePADErrorCode RequestRemoval(FString Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("RequestRemoval"),  @params);
    }
    public EGooglePADErrorCode RequestInfo(TArray<FString> AssetPacks)
    {
        Span<(string name, object value)> @params = [
            ("AssetPacks", AssetPacks)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("RequestInfo"),  @params);
    }
    public EGooglePADErrorCode RequestDownload(TArray<FString> AssetPacks)
    {
        Span<(string name, object value)> @params = [
            ("AssetPacks", AssetPacks)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("RequestDownload"),  @params);
    }
    public void ReleaseDownloadState(int State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        ProcessEvent(GetFunction("ReleaseDownloadState"),  @params);
    }
    public void ReleaseAssetPackLocation(int Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("ReleaseAssetPackLocation"),  @params);
    }
    public int GetTotalBytesToDownload(int State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        return ProcessEvent<int>(GetFunction("GetTotalBytesToDownload"),  @params);
    }
    public EGooglePADStorageMethod GetStorageMethod(int Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        return ProcessEvent<EGooglePADStorageMethod>(GetFunction("GetStorageMethod"),  @params);
    }
    public EGooglePADErrorCode GetShowCellularDataConfirmationStatus(ref EGooglePADCellularDataConfirmStatus Status)
    {
        Span<(string name, object value)> @params = [
            ("Status", Status)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("GetShowCellularDataConfirmationStatus"),  @params);
    }
    public EGooglePADDownloadStatus GetDownloadStatus(int State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        return ProcessEvent<EGooglePADDownloadStatus>(GetFunction("GetDownloadStatus"),  @params);
    }
    public EGooglePADErrorCode GetDownloadState(FString Name, ref int State)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name), 
            ("State", State)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("GetDownloadState"),  @params);
    }
    public int GetBytesDownloaded(int State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        return ProcessEvent<int>(GetFunction("GetBytesDownloaded"),  @params);
    }
    public FString GetAssetsPath(int Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        return ProcessEvent<FString>(GetFunction("GetAssetsPath"),  @params);
    }
    public EGooglePADErrorCode GetAssetPackLocation(FString Name, ref int Location)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name), 
            ("Location", Location)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("GetAssetPackLocation"),  @params);
    }
    public EGooglePADErrorCode CancelDownload(TArray<FString> AssetPacks)
    {
        Span<(string name, object value)> @params = [
            ("AssetPacks", AssetPacks)
        ];
        return ProcessEvent<EGooglePADErrorCode>(GetFunction("CancelDownload"),  @params);
    }
}

