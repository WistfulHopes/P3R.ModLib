using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AssetRegistryImpl : ObjectBase<UAssetRegistryImpl>
{
    public AssetRegistryImpl(IntPtr pointer) : base(pointer) {}}

public unsafe class AssetRegistryHelpers : ObjectBase<UAssetRegistryHelpers>
{
    public AssetRegistryHelpers(IntPtr pointer) : base(pointer) {}
    public FSoftObjectPath ToSoftObjectPath(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<FSoftObjectPath>(GetFunction("ToSoftObjectPath"), @params);
    }
    public FARFilter SetFilterTagsAndValues(ref FARFilter inFilter, ref TArray<FTagAndValue> InTagsAndValues)
    {
        Span<(string name, object value)> @params = [
            ("inFilter", inFilter), 
            ("InTagsAndValues", InTagsAndValues)
        ];
        return ProcessEvent<FARFilter>(GetFunction("SetFilterTagsAndValues"), @params);
    }
    public bool IsValid(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<bool>(GetFunction("IsValid"), @params);
    }
    public bool IsUAsset(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<bool>(GetFunction("IsUAsset"), @params);
    }
    public bool IsRedirector(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<bool>(GetFunction("IsRedirector"), @params);
    }
    public bool IsAssetLoaded(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<bool>(GetFunction("IsAssetLoaded"), @params);
    }
    public bool GetTagValue(ref FAssetData InAssetData, ref FName InTagName, ref FString OutTagValue)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData), 
            ("InTagName", InTagName), 
            ("OutTagValue", OutTagValue)
        ];
        return ProcessEvent<bool>(GetFunction("GetTagValue"), @params);
    }
    public FString GetFullName(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<FString>(GetFunction("GetFullName"), @params);
    }
    public FString GetExportTextName(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return ProcessEvent<FString>(GetFunction("GetExportTextName"), @params);
    }
    public UClass* GetClass(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return (UClass*)ProcessEvent<IntPtr>(GetFunction("GetClass"), @params);
    }
    public TScriptInterface<IAssetRegistry> GetAssetRegistry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TScriptInterface<IAssetRegistry>>(GetFunction("GetAssetRegistry"), @params);
    }
    public UObject* GetAsset(ref FAssetData InAssetData)
    {
        Span<(string name, object value)> @params = [
            ("InAssetData", InAssetData)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetAsset"), @params);
    }
    public FAssetData CreateAssetData(UObject* InAsset, bool bAllowBlueprintClass)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("bAllowBlueprintClass", bAllowBlueprintClass)
        ];
        return ProcessEvent<FAssetData>(GetFunction("CreateAssetData"), @params);
    }
}

public unsafe class AssetRegistry : ObjectBase<IAssetRegistry>
{
    public AssetRegistry(IntPtr pointer) : base(pointer) {}
    public void WaitForCompletion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("WaitForCompletion"), @params);
    }
    public void UseFilterToExcludeAssets(ref TArray<FAssetData> AssetDataList, ref FARFilter Filter)
    {
        Span<(string name, object value)> @params = [
            ("AssetDataList", AssetDataList), 
            ("Filter", Filter)
        ];
        ProcessEvent(GetFunction("UseFilterToExcludeAssets"), @params);
    }
    public void SearchAllAssets(bool bSynchronousSearch)
    {
        Span<(string name, object value)> @params = [
            ("bSynchronousSearch", bSynchronousSearch)
        ];
        ProcessEvent(GetFunction("SearchAllAssets"), @params);
    }
    public void ScanPathsSynchronous(ref TArray<FString> InPaths, bool bForceRescan)
    {
        Span<(string name, object value)> @params = [
            ("InPaths", InPaths), 
            ("bForceRescan", bForceRescan)
        ];
        ProcessEvent(GetFunction("ScanPathsSynchronous"), @params);
    }
    public void ScanModifiedAssetFiles(ref TArray<FString> InFilePaths)
    {
        Span<(string name, object value)> @params = [
            ("InFilePaths", InFilePaths)
        ];
        ProcessEvent(GetFunction("ScanModifiedAssetFiles"), @params);
    }
    public void ScanFilesSynchronous(ref TArray<FString> InFilePaths, bool bForceRescan)
    {
        Span<(string name, object value)> @params = [
            ("InFilePaths", InFilePaths), 
            ("bForceRescan", bForceRescan)
        ];
        ProcessEvent(GetFunction("ScanFilesSynchronous"), @params);
    }
    public void RunAssetsThroughFilter(ref TArray<FAssetData> AssetDataList, ref FARFilter Filter)
    {
        Span<(string name, object value)> @params = [
            ("AssetDataList", AssetDataList), 
            ("Filter", Filter)
        ];
        ProcessEvent(GetFunction("RunAssetsThroughFilter"), @params);
    }
    public void PrioritizeSearchPath(FString PathToPrioritize)
    {
        Span<(string name, object value)> @params = [
            ("PathToPrioritize", PathToPrioritize)
        ];
        ProcessEvent(GetFunction("PrioritizeSearchPath"), @params);
    }
    public bool K2_GetReferencers(FName PackageName, ref FAssetRegistryDependencyOptions ReferenceOptions, ref TArray<FName> OutReferencers)
    {
        Span<(string name, object value)> @params = [
            ("PackageName", PackageName), 
            ("ReferenceOptions", ReferenceOptions), 
            ("OutReferencers", OutReferencers)
        ];
        return ProcessEvent<bool>(GetFunction("K2_GetReferencers"), @params);
    }
    public bool K2_GetDependencies(FName PackageName, ref FAssetRegistryDependencyOptions DependencyOptions, ref TArray<FName> OutDependencies)
    {
        Span<(string name, object value)> @params = [
            ("PackageName", PackageName), 
            ("DependencyOptions", DependencyOptions), 
            ("OutDependencies", OutDependencies)
        ];
        return ProcessEvent<bool>(GetFunction("K2_GetDependencies"), @params);
    }
    public bool IsLoadingAssets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoadingAssets"), @params);
    }
    public bool HasAssets(FName PackagePath, bool bRecursive)
    {
        Span<(string name, object value)> @params = [
            ("PackagePath", PackagePath), 
            ("bRecursive", bRecursive)
        ];
        return ProcessEvent<bool>(GetFunction("HasAssets"), @params);
    }
    public void GetSubPaths(FString InBasePath, ref TArray<FString> OutPathList, bool bInRecurse)
    {
        Span<(string name, object value)> @params = [
            ("InBasePath", InBasePath), 
            ("OutPathList", OutPathList), 
            ("bInRecurse", bInRecurse)
        ];
        ProcessEvent(GetFunction("GetSubPaths"), @params);
    }
    public bool GetAssetsByPath(FName PackagePath, ref TArray<FAssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets)
    {
        Span<(string name, object value)> @params = [
            ("PackagePath", PackagePath), 
            ("OutAssetData", OutAssetData), 
            ("bRecursive", bRecursive), 
            ("bIncludeOnlyOnDiskAssets", bIncludeOnlyOnDiskAssets)
        ];
        return ProcessEvent<bool>(GetFunction("GetAssetsByPath"), @params);
    }
    public bool GetAssetsByPackageName(FName PackageName, ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets)
    {
        Span<(string name, object value)> @params = [
            ("PackageName", PackageName), 
            ("OutAssetData", OutAssetData), 
            ("bIncludeOnlyOnDiskAssets", bIncludeOnlyOnDiskAssets)
        ];
        return ProcessEvent<bool>(GetFunction("GetAssetsByPackageName"), @params);
    }
    public bool GetAssetsByClass(FName ClassName, ref TArray<FAssetData> OutAssetData, bool bSearchSubClasses)
    {
        Span<(string name, object value)> @params = [
            ("ClassName", ClassName), 
            ("OutAssetData", OutAssetData), 
            ("bSearchSubClasses", bSearchSubClasses)
        ];
        return ProcessEvent<bool>(GetFunction("GetAssetsByClass"), @params);
    }
    public bool GetAssets(ref FARFilter Filter, ref TArray<FAssetData> OutAssetData)
    {
        Span<(string name, object value)> @params = [
            ("Filter", Filter), 
            ("OutAssetData", OutAssetData)
        ];
        return ProcessEvent<bool>(GetFunction("GetAssets"), @params);
    }
    public FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets)
    {
        Span<(string name, object value)> @params = [
            ("ObjectPath", ObjectPath), 
            ("bIncludeOnlyOnDiskAssets", bIncludeOnlyOnDiskAssets)
        ];
        return ProcessEvent<FAssetData>(GetFunction("GetAssetByObjectPath"), @params);
    }
    public void GetAllCachedPaths(ref TArray<FString> OutPathList)
    {
        Span<(string name, object value)> @params = [
            ("OutPathList", OutPathList)
        ];
        ProcessEvent(GetFunction("GetAllCachedPaths"), @params);
    }
    public bool GetAllAssets(ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets)
    {
        Span<(string name, object value)> @params = [
            ("OutAssetData", OutAssetData), 
            ("bIncludeOnlyOnDiskAssets", bIncludeOnlyOnDiskAssets)
        ];
        return ProcessEvent<bool>(GetFunction("GetAllAssets"), @params);
    }
}

