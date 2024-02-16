using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AssetTagsSubsystem : ObjectBase<UAssetTagsSubsystem>
{

    public TArray<FName> GetCollectionsContainingAssetPtr(UObject* AssetPtr)
    {
        Span<(string name, object value)> @params = [
            ("AssetPtr", (IntPtr)AssetPtr)
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetCollectionsContainingAssetPtr"),  @params);
    }
    public TArray<FName> GetCollectionsContainingAssetData(ref FAssetData AssetData)
    {
        Span<(string name, object value)> @params = [
            ("AssetData", AssetData)
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetCollectionsContainingAssetData"),  @params);
    }
    public TArray<FName> GetCollectionsContainingAsset(FName AssetPathName)
    {
        Span<(string name, object value)> @params = [
            ("AssetPathName", AssetPathName)
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetCollectionsContainingAsset"),  @params);
    }
    public TArray<FName> GetCollections()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("GetCollections"),  @params);
    }
    public TArray<FAssetData> GetAssetsInCollection(FName Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return ProcessEvent<TArray<FAssetData>>(GetFunction("GetAssetsInCollection"),  @params);
    }
    public bool CollectionExists(FName Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return ProcessEvent<bool>(GetFunction("CollectionExists"),  @params);
    }
}

