using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class DatasmithObjectTemplate : ObjectBase<UDatasmithObjectTemplate>
{
}

public unsafe class DatasmithActorTemplate : ObjectBase<UDatasmithActorTemplate>
{

}

public unsafe class DatasmithAdditionalData : ObjectBase<UDatasmithAdditionalData>
{
}

public unsafe class DatasmithAreaLightActor : ObjectBase<ADatasmithAreaLightActor>
{

}

public unsafe class DatasmithAreaLightActorTemplate : ObjectBase<UDatasmithAreaLightActorTemplate>
{

}

public unsafe class DatasmithAssetImportData : ObjectBase<UDatasmithAssetImportData>
{
}

public unsafe class DatasmithStaticMeshImportData : ObjectBase<UDatasmithStaticMeshImportData>
{
}

public unsafe class DatasmithStaticMeshCADImportData : ObjectBase<UDatasmithStaticMeshCADImportData>
{
}

public unsafe class DatasmithSceneImportData : ObjectBase<UDatasmithSceneImportData>
{
}

public unsafe class DatasmithTranslatedSceneImportData : ObjectBase<UDatasmithTranslatedSceneImportData>
{
}

public unsafe class DatasmithCADImportSceneData : ObjectBase<UDatasmithCADImportSceneData>
{
}

public unsafe class DatasmithMDLSceneImportData : ObjectBase<UDatasmithMDLSceneImportData>
{
}

public unsafe class DatasmithGLTFSceneImportData : ObjectBase<UDatasmithGLTFSceneImportData>
{

}

public unsafe class DatasmithStaticMeshGLTFImportData : ObjectBase<UDatasmithStaticMeshGLTFImportData>
{

}

public unsafe class DatasmithFBXSceneImportData : ObjectBase<UDatasmithFBXSceneImportData>
{

}

public unsafe class DatasmithDeltaGenAssetImportData : ObjectBase<UDatasmithDeltaGenAssetImportData>
{
}

public unsafe class DatasmithDeltaGenSceneImportData : ObjectBase<UDatasmithDeltaGenSceneImportData>
{

}

public unsafe class DatasmithVREDAssetImportData : ObjectBase<UDatasmithVREDAssetImportData>
{
}

public unsafe class DatasmithVREDSceneImportData : ObjectBase<UDatasmithVREDSceneImportData>
{

}

public unsafe class DatasmithIFCSceneImportData : ObjectBase<UDatasmithIFCSceneImportData>
{
}

public unsafe class DatasmithStaticMeshIFCImportData : ObjectBase<UDatasmithStaticMeshIFCImportData>
{

}

public unsafe class DatasmithAssetUserData : ObjectBase<UDatasmithAssetUserData>
{

}

public unsafe class DatasmithCineCameraActorTemplate : ObjectBase<UDatasmithCineCameraActorTemplate>
{

}

public unsafe class DatasmithCineCameraComponentTemplate : ObjectBase<UDatasmithCineCameraComponentTemplate>
{

}

public unsafe class DatasmithContentBlueprintLibrary : ObjectBase<UDatasmithContentBlueprintLibrary>
{

    public FString GetDatasmithUserDataValueForKey(UObject* Object, FName Key)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("Key", Key)
        ];
        return ProcessEvent<FString>(GetFunction("GetDatasmithUserDataValueForKey"),  @params);
    }
    public void GetDatasmithUserDataKeysAndValuesForValue(UObject* Object, FString StringToMatch, ref TArray<FName> OutKeys, ref TArray<FString> OutValues)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("StringToMatch", StringToMatch), 
            ("OutKeys", OutKeys), 
            ("OutValues", OutValues)
        ];
        ProcessEvent(GetFunction("GetDatasmithUserDataKeysAndValuesForValue"),  @params);
    }
    public UDatasmithAssetUserData* GetDatasmithUserData(UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object)
        ];
        return (UDatasmithAssetUserData*)ProcessEvent<IntPtr>(GetFunction("GetDatasmithUserData"),  @params);
    }
}

public unsafe class DatasmithCustomActionBase : ObjectBase<UDatasmithCustomActionBase>
{
}

public unsafe class DatasmithDecalComponentTemplate : ObjectBase<UDatasmithDecalComponentTemplate>
{

}

public unsafe class DatasmithImportedSequencesActor : ObjectBase<ADatasmithImportedSequencesActor>
{

    public void PlayLevelSequence(ULevelSequence* SequenceToPlay)
    {
        Span<(string name, object value)> @params = [
            ("SequenceToPlay", (IntPtr)SequenceToPlay)
        ];
        ProcessEvent(GetFunction("PlayLevelSequence"),  @params);
    }
}

public unsafe class DatasmithOptionsBase : ObjectBase<UDatasmithOptionsBase>
{
}

public unsafe class DatasmithCommonTessellationOptions : ObjectBase<UDatasmithCommonTessellationOptions>
{

}

public unsafe class DatasmithImportOptions : ObjectBase<UDatasmithImportOptions>
{

}

public unsafe class DatasmithLandscapeTemplate : ObjectBase<UDatasmithLandscapeTemplate>
{

}

public unsafe class DatasmithLightComponentTemplate : ObjectBase<UDatasmithLightComponentTemplate>
{

}

public unsafe class DatasmithMaterialInstanceTemplate : ObjectBase<UDatasmithMaterialInstanceTemplate>
{

}

public unsafe class DatasmithPointLightComponentTemplate : ObjectBase<UDatasmithPointLightComponentTemplate>
{

}

public unsafe class DatasmithPostProcessVolumeTemplate : ObjectBase<UDatasmithPostProcessVolumeTemplate>
{

}

public unsafe class DatasmithScene : ObjectBase<UDatasmithScene>
{
}

public unsafe class DatasmithSceneActor : ObjectBase<ADatasmithSceneActor>
{

}

public unsafe class DatasmithSceneComponentTemplate : ObjectBase<UDatasmithSceneComponentTemplate>
{

}

public unsafe class DatasmithSkyLightComponentTemplate : ObjectBase<UDatasmithSkyLightComponentTemplate>
{

}

public unsafe class DatasmithSpotLightComponentTemplate : ObjectBase<UDatasmithSpotLightComponentTemplate>
{

}

public unsafe class DatasmithStaticMeshComponentTemplate : ObjectBase<UDatasmithStaticMeshComponentTemplate>
{

}

public unsafe class DatasmithStaticMeshTemplate : ObjectBase<UDatasmithStaticMeshTemplate>
{

}

public unsafe class DatasmithCameraLookatTrackingSettingsTemplate : ObjectBase<FDatasmithCameraLookatTrackingSettingsTemplate>
{

}

public unsafe class DatasmithPostProcessSettingsTemplate : ObjectBase<FDatasmithPostProcessSettingsTemplate>
{

}

public unsafe class DatasmithCameraFocusSettingsTemplate : ObjectBase<FDatasmithCameraFocusSettingsTemplate>
{

}

public unsafe class DatasmithCameraLensSettingsTemplate : ObjectBase<FDatasmithCameraLensSettingsTemplate>
{

}

public unsafe class DatasmithCameraFilmbackSettingsTemplate : ObjectBase<FDatasmithCameraFilmbackSettingsTemplate>
{

}

public unsafe class DatasmithTessellationOptions : ObjectBase<FDatasmithTessellationOptions>
{

}

public unsafe class DatasmithRetessellationOptions : ObjectBase<FDatasmithRetessellationOptions>
{

}

public unsafe class DatasmithImportBaseOptions : ObjectBase<FDatasmithImportBaseOptions>
{

}

public unsafe class DatasmithStaticMeshImportOptions : ObjectBase<FDatasmithStaticMeshImportOptions>
{

}

public unsafe class DatasmithAssetImportOptions : ObjectBase<FDatasmithAssetImportOptions>
{

}

public unsafe class DatasmithReimportOptions : ObjectBase<FDatasmithReimportOptions>
{

}

public unsafe class DatasmithStaticParameterSetTemplate : ObjectBase<FDatasmithStaticParameterSetTemplate>
{

}

public unsafe class DatasmithMeshSectionInfoMapTemplate : ObjectBase<FDatasmithMeshSectionInfoMapTemplate>
{

}

public unsafe class DatasmithMeshSectionInfoTemplate : ObjectBase<FDatasmithMeshSectionInfoTemplate>
{

}

public unsafe class DatasmithStaticMaterialTemplate : ObjectBase<FDatasmithStaticMaterialTemplate>
{

}

public unsafe class DatasmithMeshBuildSettingsTemplate : ObjectBase<FDatasmithMeshBuildSettingsTemplate>
{

}

