using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimNotify_PlayNiagaraEffectEx : ObjectBase<UAnimNotify_PlayNiagaraEffectEx>
{

    public UNiagaraComponent* GetSpawnedEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("GetSpawnedEffect"),  @params);
    }
}

public unsafe class AnimNotifyState_NiagaraTrail : ObjectBase<UAnimNotifyState_NiagaraTrail>
{

}

public unsafe class AnimNotifyState_TimedNiagaraEffectEx : ObjectBase<UAnimNotifyState_TimedNiagaraEffectEx>
{

}

public unsafe class NiagaraActorExtends : ObjectBase<ANiagaraActorExtends>
{

    public void SpawnNiagaraSystem(UNiagaraSystem* InAsset, float InSpeed)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InSpeed", InSpeed)
        ];
        ProcessEvent(GetFunction("SpawnNiagaraSystem"),  @params);
    }
    public void SetVisibleDebugArrow_DebugOnly(bool InVisible)
    {
        Span<(string name, object value)> @params = [
            ("InVisible", InVisible)
        ];
        ProcessEvent(GetFunction("SetVisibleDebugArrow_DebugOnly"),  @params);
    }
    public void SetDesiredAge(float InDeltTime)
    {
        Span<(string name, object value)> @params = [
            ("InDeltTime", InDeltTime)
        ];
        ProcessEvent(GetFunction("SetDesiredAge"),  @params);
    }
    public void RestertEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestertEffect"),  @params);
    }
    public void OnComplete(UNiagaraComponent* PSystem)
    {
        Span<(string name, object value)> @params = [
            ("PSystem", (IntPtr)PSystem)
        ];
        ProcessEvent(GetFunction("OnComplete"),  @params);
    }
    public UNiagaraParameterCollectionInstance* GetParameterCollectionInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraParameterCollectionInstance*)ProcessEvent<IntPtr>(GetFunction("GetParameterCollectionInstance"),  @params);
    }
    public ANiagaraActorExtends* CreateNiagaraActorExtends(APlayerController* InPC, UNiagaraSystem* InAsset, float InSpeed)
    {
        Span<(string name, object value)> @params = [
            ("InPC", (IntPtr)InPC), 
            ("InAsset", (IntPtr)InAsset), 
            ("InSpeed", InSpeed)
        ];
        return (ANiagaraActorExtends*)ProcessEvent<IntPtr>(GetFunction("CreateNiagaraActorExtends"),  @params);
    }
}

public unsafe class NiagaraCameraShake : ObjectBase<UNiagaraCameraShake>
{
}

public unsafe class NiagaraDataInterfaceBillboardEffect : ObjectBase<UNiagaraDataInterfaceBillboardEffect>
{

}

public unsafe class NiagaraDataInterfaceBillboardEffect2 : ObjectBase<UNiagaraDataInterfaceBillboardEffect2>
{

}

public unsafe class NiagaraDataInterfaceCameraShake : ObjectBase<UNiagaraDataInterfaceCameraShake>
{

}

public unsafe class NiagaraDataInterfacePostProcess : ObjectBase<UNiagaraDataInterfacePostProcess>
{

}

public unsafe class NiagaraDataInterfaceSetCustomStencil : ObjectBase<UNiagaraDataInterfaceSetCustomStencil>
{

}

public unsafe class NiagaraDataInterfaceSyncActorPause : ObjectBase<UNiagaraDataInterfaceSyncActorPause>
{
}

public unsafe class NiagaraExtendsFunctionLibrary : ObjectBase<UNiagaraExtendsFunctionLibrary>
{

    public UNiagaraComponent* SpawnSystemAttachedOnCamera(FString WorldAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldAssetPath", WorldAssetPath)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAttachedOnCamera"),  @params);
    }
    public UNiagaraComponent* SpawnSystemAttached(UNiagaraSystem* SystemTemplate, USceneComponent* AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bAutoDestroy, bool bAbsoluteLocation, bool bAbsoluteRotation, bool bAbsoluteScale, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
    {
        Span<(string name, object value)> @params = [
            ("SystemTemplate", (IntPtr)SystemTemplate), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("LocationType", LocationType), 
            ("bAutoDestroy", bAutoDestroy), 
            ("bAbsoluteLocation", bAbsoluteLocation), 
            ("bAbsoluteRotation", bAbsoluteRotation), 
            ("bAbsoluteScale", bAbsoluteScale), 
            ("bAutoActivate", bAutoActivate), 
            ("PoolingMethod", PoolingMethod), 
            ("bPreCullCheck", bPreCullCheck)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAttached"),  @params);
    }
    public AActor* SpawnActorFromBP(APlayerController* InPC, FString InBaseAssetPath, FTransform InBaseTransform)
    {
        Span<(string name, object value)> @params = [
            ("InPC", (IntPtr)InPC), 
            ("InBaseAssetPath", InBaseAssetPath), 
            ("InBaseTransform", InBaseTransform)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("SpawnActorFromBP"),  @params);
    }
    public void SetAllNiagaraPaused(UObject* InWorldContextObject, bool InPaused)
    {
        Span<(string name, object value)> @params = [
            ("InWorldContextObject", (IntPtr)InWorldContextObject), 
            ("InPaused", InPaused)
        ];
        ProcessEvent(GetFunction("SetAllNiagaraPaused"),  @params);
    }
    public void OpenAssetEditorWindowFromPath(FString FilePath)
    {
        Span<(string name, object value)> @params = [
            ("FilePath", FilePath)
        ];
        ProcessEvent(GetFunction("OpenAssetEditorWindowFromPath"),  @params);
    }
    public void OpenAssetEditorWindowFromAsset(UObject* Asset)
    {
        Span<(string name, object value)> @params = [
            ("Asset", (IntPtr)Asset)
        ];
        ProcessEvent(GetFunction("OpenAssetEditorWindowFromAsset"),  @params);
    }
    public TArray<FString> GetWarldLevelNames(FString WorldAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldAssetPath", WorldAssetPath)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("GetWarldLevelNames"),  @params);
    }
    public FVector GetNiagaraEmitterVectorValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<FVector>(GetFunction("GetNiagaraEmitterVectorValue"),  @params);
    }
    public FQuat GetNiagaraEmitterQuatValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<FQuat>(GetFunction("GetNiagaraEmitterQuatValue"),  @params);
    }
    public FMatrix GetNiagaraEmitterMatrixValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<FMatrix>(GetFunction("GetNiagaraEmitterMatrixValue"),  @params);
    }
    public int GetNiagaraEmitterIntValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<int>(GetFunction("GetNiagaraEmitterIntValue"),  @params);
    }
    public float GetNiagaraEmitterFloatValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<float>(GetFunction("GetNiagaraEmitterFloatValue"),  @params);
    }
    public bool GetNiagaraEmitterBoolValue(UNiagaraComponent* NiagaraComponent, FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent), 
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<bool>(GetFunction("GetNiagaraEmitterBoolValue"),  @params);
    }
    public FPostProcessSettings GetFinalPostProcessSettings(UWorld* World)
    {
        Span<(string name, object value)> @params = [
            ("World", (IntPtr)World)
        ];
        return ProcessEvent<FPostProcessSettings>(GetFunction("GetFinalPostProcessSettings"),  @params);
    }
    public TArray<FString> GetEmitterNames(UNiagaraComponent* NiagaraComponent)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraComponent", (IntPtr)NiagaraComponent)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("GetEmitterNames"),  @params);
    }
}

