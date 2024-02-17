using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class DatasmithDeltaGenSceneImportData : ObjectBase<UDatasmithDeltaGenSceneImportData>
{
    public DatasmithDeltaGenSceneImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithVREDAssetImportData : ObjectBase<UDatasmithVREDAssetImportData>
{
    public DatasmithVREDAssetImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithVREDSceneImportData : ObjectBase<UDatasmithVREDSceneImportData>
{
    public DatasmithVREDSceneImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithIFCSceneImportData : ObjectBase<UDatasmithIFCSceneImportData>
{
    public DatasmithIFCSceneImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithStaticMeshIFCImportData : ObjectBase<UDatasmithStaticMeshIFCImportData>
{
    public DatasmithStaticMeshIFCImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithAssetUserData : ObjectBase<UDatasmithAssetUserData>
{
    public DatasmithAssetUserData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithCineCameraActorTemplate : ObjectBase<UDatasmithCineCameraActorTemplate>
{
    public DatasmithCineCameraActorTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithCineCameraComponentTemplate : ObjectBase<UDatasmithCineCameraComponentTemplate>
{
    public DatasmithCineCameraComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithContentBlueprintLibrary : ObjectBase<UDatasmithContentBlueprintLibrary>
{
    public DatasmithContentBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public FString GetDatasmithUserDataValueForKey(UObject* Object, FName Key)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("Key", Key)
        ];
        return ProcessEvent<FString>(GetFunction("GetDatasmithUserDataValueForKey"), @params);
    }
    public void GetDatasmithUserDataKeysAndValuesForValue(UObject* Object, FString StringToMatch, ref TArray<FName> OutKeys, ref TArray<FString> OutValues)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("StringToMatch", StringToMatch), 
            ("OutKeys", OutKeys), 
            ("OutValues", OutValues)
        ];
        ProcessEvent(GetFunction("GetDatasmithUserDataKeysAndValuesForValue"), @params);
    }
    public UDatasmithAssetUserData* GetDatasmithUserData(UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object)
        ];
        return (UDatasmithAssetUserData*)ProcessEvent<IntPtr>(GetFunction("GetDatasmithUserData"), @params);
    }
}

public unsafe class DatasmithCustomActionBase : ObjectBase<UDatasmithCustomActionBase>
{
    public DatasmithCustomActionBase(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithDecalComponentTemplate : ObjectBase<UDatasmithDecalComponentTemplate>
{
    public DatasmithDecalComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithImportedSequencesActor : ObjectBase<ADatasmithImportedSequencesActor>
{
    public DatasmithImportedSequencesActor(IntPtr pointer) : base(pointer) {}
    public void PlayLevelSequence(ULevelSequence* SequenceToPlay)
    {
        Span<(string name, object value)> @params = [
            ("SequenceToPlay", (IntPtr)SequenceToPlay)
        ];
        ProcessEvent(GetFunction("PlayLevelSequence"), @params);
    }
}

public unsafe class DatasmithOptionsBase : ObjectBase<UDatasmithOptionsBase>
{
    public DatasmithOptionsBase(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithStaticMeshCADImportData : ObjectBase<UDatasmithStaticMeshCADImportData>
{
    public DatasmithStaticMeshCADImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithImportOptions : ObjectBase<UDatasmithImportOptions>
{
    public DatasmithImportOptions(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithLandscapeTemplate : ObjectBase<UDatasmithLandscapeTemplate>
{
    public DatasmithLandscapeTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithLightComponentTemplate : ObjectBase<UDatasmithLightComponentTemplate>
{
    public DatasmithLightComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithMaterialInstanceTemplate : ObjectBase<UDatasmithMaterialInstanceTemplate>
{
    public DatasmithMaterialInstanceTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithPointLightComponentTemplate : ObjectBase<UDatasmithPointLightComponentTemplate>
{
    public DatasmithPointLightComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithPostProcessVolumeTemplate : ObjectBase<UDatasmithPostProcessVolumeTemplate>
{
    public DatasmithPostProcessVolumeTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithScene : ObjectBase<UDatasmithScene>
{
    public DatasmithScene(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithSceneActor : ObjectBase<ADatasmithSceneActor>
{
    public DatasmithSceneActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithSceneComponentTemplate : ObjectBase<UDatasmithSceneComponentTemplate>
{
    public DatasmithSceneComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithSkyLightComponentTemplate : ObjectBase<UDatasmithSkyLightComponentTemplate>
{
    public DatasmithSkyLightComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithSpotLightComponentTemplate : ObjectBase<UDatasmithSpotLightComponentTemplate>
{
    public DatasmithSpotLightComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithStaticMeshComponentTemplate : ObjectBase<UDatasmithStaticMeshComponentTemplate>
{
    public DatasmithStaticMeshComponentTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithStaticMeshTemplate : ObjectBase<UDatasmithStaticMeshTemplate>
{
    public DatasmithStaticMeshTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithObjectTemplate : ObjectBase<UDatasmithObjectTemplate>
{
    public DatasmithObjectTemplate(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithActorTemplate : ObjectBase<UDatasmithActorTemplate>
{
    public DatasmithActorTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithAdditionalData : ObjectBase<UDatasmithAdditionalData>
{
    public DatasmithAdditionalData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithAreaLightActor : ObjectBase<ADatasmithAreaLightActor>
{
    public DatasmithAreaLightActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithAreaLightActorTemplate : ObjectBase<UDatasmithAreaLightActorTemplate>
{
    public DatasmithAreaLightActorTemplate(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithAssetImportData : ObjectBase<UDatasmithAssetImportData>
{
    public DatasmithAssetImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithStaticMeshImportData : ObjectBase<UDatasmithStaticMeshImportData>
{
    public DatasmithStaticMeshImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithSceneImportData : ObjectBase<UDatasmithSceneImportData>
{
    public DatasmithSceneImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithCommonTessellationOptions : ObjectBase<UDatasmithCommonTessellationOptions>
{
    public DatasmithCommonTessellationOptions(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithTranslatedSceneImportData : ObjectBase<UDatasmithTranslatedSceneImportData>
{
    public DatasmithTranslatedSceneImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithCADImportSceneData : ObjectBase<UDatasmithCADImportSceneData>
{
    public DatasmithCADImportSceneData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithMDLSceneImportData : ObjectBase<UDatasmithMDLSceneImportData>
{
    public DatasmithMDLSceneImportData(IntPtr pointer) : base(pointer) {}}

public unsafe class DatasmithGLTFSceneImportData : ObjectBase<UDatasmithGLTFSceneImportData>
{
    public DatasmithGLTFSceneImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithStaticMeshGLTFImportData : ObjectBase<UDatasmithStaticMeshGLTFImportData>
{
    public DatasmithStaticMeshGLTFImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithFBXSceneImportData : ObjectBase<UDatasmithFBXSceneImportData>
{
    public DatasmithFBXSceneImportData(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatasmithDeltaGenAssetImportData : ObjectBase<UDatasmithDeltaGenAssetImportData>
{
    public DatasmithDeltaGenAssetImportData(IntPtr pointer) : base(pointer) {}}

