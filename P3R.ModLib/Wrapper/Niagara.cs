using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneNiagaraTrack : ObjectBase<UMovieSceneNiagaraTrack>
{

}

public unsafe class MovieSceneNiagaraParameterTrack : ObjectBase<UMovieSceneNiagaraParameterTrack>
{

}

public unsafe class MovieSceneNiagaraBoolParameterTrack : ObjectBase<UMovieSceneNiagaraBoolParameterTrack>
{
}

public unsafe class MovieSceneNiagaraColorParameterTrack : ObjectBase<UMovieSceneNiagaraColorParameterTrack>
{
}

public unsafe class MovieSceneNiagaraFloatParameterTrack : ObjectBase<UMovieSceneNiagaraFloatParameterTrack>
{
}

public unsafe class MovieSceneNiagaraIntegerParameterTrack : ObjectBase<UMovieSceneNiagaraIntegerParameterTrack>
{
}

public unsafe class MovieSceneNiagaraSystemSpawnSection : ObjectBase<UMovieSceneNiagaraSystemSpawnSection>
{

}

public unsafe class MovieSceneNiagaraSystemTrack : ObjectBase<UMovieSceneNiagaraSystemTrack>
{
}

public unsafe class MovieSceneNiagaraVectorParameterTrack : ObjectBase<UMovieSceneNiagaraVectorParameterTrack>
{

}

public unsafe class NiagaraActor : ObjectBase<ANiagaraActor>
{

    public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish)
    {
        Span<(string name, object value)> @params = [
            ("bShouldDestroyOnSystemFinish", bShouldDestroyOnSystemFinish)
        ];
        ProcessEvent(GetFunction("SetDestroyOnSystemFinish"),  @params);
    }
    public void OnNiagaraSystemFinished(UNiagaraComponent* FinishedComponent)
    {
        Span<(string name, object value)> @params = [
            ("FinishedComponent", (IntPtr)FinishedComponent)
        ];
        ProcessEvent(GetFunction("OnNiagaraSystemFinished"),  @params);
    }
}

public unsafe class NiagaraBakerSettings : ObjectBase<UNiagaraBakerSettings>
{

}

public unsafe class NiagaraComponent : ObjectBase<UNiagaraComponent>
{

    public void SetVariableVec4(FName InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec4"),  @params);
    }
    public void SetVariableVec3(FName InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec3"),  @params);
    }
    public void SetVariableVec2(FName InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec2"),  @params);
    }
    public void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget* TextureRenderTarget)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("TextureRenderTarget", (IntPtr)TextureRenderTarget)
        ];
        ProcessEvent(GetFunction("SetVariableTextureRenderTarget"),  @params);
    }
    public void SetVariableQuat(FName InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableQuat"),  @params);
    }
    public void SetVariableObject(FName InVariableName, UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetVariableObject"),  @params);
    }
    public void SetVariableMaterial(FName InVariableName, UMaterialInterface* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetVariableMaterial"),  @params);
    }
    public void SetVariableLinearColor(FName InVariableName, ref FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableLinearColor"),  @params);
    }
    public void SetVariableInt(FName InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableInt"),  @params);
    }
    public void SetVariableFloat(FName InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableFloat"),  @params);
    }
    public void SetVariableBool(FName InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableBool"),  @params);
    }
    public void SetVariableActor(FName InVariableName, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetVariableActor"),  @params);
    }
    public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior)
    {
        Span<(string name, object value)> @params = [
            ("NewTickBehavior", NewTickBehavior)
        ];
        ProcessEvent(GetFunction("SetTickBehavior"),  @params);
    }
    public void SetSeekDelta(float InSeekDelta)
    {
        Span<(string name, object value)> @params = [
            ("InSeekDelta", InSeekDelta)
        ];
        ProcessEvent(GetFunction("SetSeekDelta"),  @params);
    }
    public void SetRenderingEnabled(bool bInRenderingEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bInRenderingEnabled", bInRenderingEnabled)
        ];
        ProcessEvent(GetFunction("SetRenderingEnabled"),  @params);
    }
    public void SetRandomSeedOffset(int NewRandomSeedOffset)
    {
        Span<(string name, object value)> @params = [
            ("NewRandomSeedOffset", NewRandomSeedOffset)
        ];
        ProcessEvent(GetFunction("SetRandomSeedOffset"),  @params);
    }
    public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance)
    {
        Span<(string name, object value)> @params = [
            ("bEnablePreviewLODDistance", bEnablePreviewLODDistance), 
            ("PreviewLODDistance", PreviewLODDistance)
        ];
        ProcessEvent(GetFunction("SetPreviewLODDistance"),  @params);
    }
    public void SetPaused(bool bInPaused)
    {
        Span<(string name, object value)> @params = [
            ("bInPaused", bInPaused)
        ];
        ProcessEvent(GetFunction("SetPaused"),  @params);
    }
    public void SetNiagaraVariableVec4(FString InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec4"),  @params);
    }
    public void SetNiagaraVariableVec3(FString InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec3"),  @params);
    }
    public void SetNiagaraVariableVec2(FString InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec2"),  @params);
    }
    public void SetNiagaraVariableQuat(FString InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableQuat"),  @params);
    }
    public void SetNiagaraVariableObject(FString InVariableName, UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableObject"),  @params);
    }
    public void SetNiagaraVariableLinearColor(FString InVariableName, ref FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableLinearColor"),  @params);
    }
    public void SetNiagaraVariableInt(FString InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableInt"),  @params);
    }
    public void SetNiagaraVariableFloat(FString InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableFloat"),  @params);
    }
    public void SetNiagaraVariableBool(FString InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableBool"),  @params);
    }
    public void SetNiagaraVariableActor(FString InVariableName, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableActor"),  @params);
    }
    public void SetMaxSimTime(float InMaxTime)
    {
        Span<(string name, object value)> @params = [
            ("InMaxTime", InMaxTime)
        ];
        ProcessEvent(GetFunction("SetMaxSimTime"),  @params);
    }
    public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
    {
        Span<(string name, object value)> @params = [
            ("bLock", bLock)
        ];
        ProcessEvent(GetFunction("SetLockDesiredAgeDeltaTimeToSeekDelta"),  @params);
    }
    public void SetGpuComputeDebug(bool bEnableDebug)
    {
        Span<(string name, object value)> @params = [
            ("bEnableDebug", bEnableDebug)
        ];
        ProcessEvent(GetFunction("SetGpuComputeDebug"),  @params);
    }
    public void SetForceSolo(bool bInForceSolo)
    {
        Span<(string name, object value)> @params = [
            ("bInForceSolo", bInForceSolo)
        ];
        ProcessEvent(GetFunction("SetForceSolo"),  @params);
    }
    public void SetDesiredAge(float InDesiredAge)
    {
        Span<(string name, object value)> @params = [
            ("InDesiredAge", InDesiredAge)
        ];
        ProcessEvent(GetFunction("SetDesiredAge"),  @params);
    }
    public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
    {
        Span<(string name, object value)> @params = [
            ("bInCanRenderWhileSeeking", bInCanRenderWhileSeeking)
        ];
        ProcessEvent(GetFunction("SetCanRenderWhileSeeking"),  @params);
    }
    public void SetAutoDestroy(bool bInAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("bInAutoDestroy", bInAutoDestroy)
        ];
        ProcessEvent(GetFunction("SetAutoDestroy"),  @params);
    }
    public void SetAsset(UNiagaraSystem* InAsset, bool bResetExistingOverrideParameters)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("bResetExistingOverrideParameters", bResetExistingOverrideParameters)
        ];
        ProcessEvent(GetFunction("SetAsset"),  @params);
    }
    public void SetAllowScalability(bool bAllow)
    {
        Span<(string name, object value)> @params = [
            ("bAllow", bAllow)
        ];
        ProcessEvent(GetFunction("SetAllowScalability"),  @params);
    }
    public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode)
    {
        Span<(string name, object value)> @params = [
            ("InAgeUpdateMode", InAgeUpdateMode)
        ];
        ProcessEvent(GetFunction("SetAgeUpdateMode"),  @params);
    }
    public void SeekToDesiredAge(float InDesiredAge)
    {
        Span<(string name, object value)> @params = [
            ("InDesiredAge", InDesiredAge)
        ];
        ProcessEvent(GetFunction("SeekToDesiredAge"),  @params);
    }
    public void ResetSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetSystem"),  @params);
    }
    public void ReinitializeSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReinitializeSystem"),  @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"),  @params);
    }
    public void InitForPerformanceBaseline()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitForPerformanceBaseline"),  @params);
    }
    public ENiagaraTickBehavior GetTickBehavior()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ENiagaraTickBehavior>(GetFunction("GetTickBehavior"),  @params);
    }
    public float GetSeekDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSeekDelta"),  @params);
    }
    public int GetRandomSeedOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetRandomSeedOffset"),  @params);
    }
    public bool GetPreviewLODDistanceEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetPreviewLODDistanceEnabled"),  @params);
    }
    public float GetPreviewLODDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPreviewLODDistance"),  @params);
    }
    public TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraParticleValueVec3_DebugOnly"),  @params);
    }
    public TArray<float> GetNiagaraParticleValues_DebugOnly(FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("GetNiagaraParticleValues_DebugOnly"),  @params);
    }
    public TArray<FVector> GetNiagaraParticlePositions_DebugOnly(FString InEmitterName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraParticlePositions_DebugOnly"),  @params);
    }
    public float GetMaxSimTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxSimTime"),  @params);
    }
    public bool GetLockDesiredAgeDeltaTimeToSeekDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetLockDesiredAgeDeltaTimeToSeekDelta"),  @params);
    }
    public bool GetForceSolo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetForceSolo"),  @params);
    }
    public float GetDesiredAge()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDesiredAge"),  @params);
    }
    public UNiagaraDataInterface* GetDataInterface(FString Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return (UNiagaraDataInterface*)ProcessEvent<IntPtr>(GetFunction("GetDataInterface"),  @params);
    }
    public UNiagaraSystem* GetAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraSystem*)ProcessEvent<IntPtr>(GetFunction("GetAsset"),  @params);
    }
    public ENiagaraAgeUpdateMode GetAgeUpdateMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ENiagaraAgeUpdateMode>(GetFunction("GetAgeUpdateMode"),  @params);
    }
    public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("SimulateTime", SimulateTime), 
            ("TickDeltaSeconds", TickDeltaSeconds)
        ];
        ProcessEvent(GetFunction("AdvanceSimulationByTime"),  @params);
    }
    public void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TickCount", TickCount), 
            ("TickDeltaSeconds", TickDeltaSeconds)
        ];
        ProcessEvent(GetFunction("AdvanceSimulation"),  @params);
    }
}

public unsafe class NiagaraComponentPool : ObjectBase<UNiagaraComponentPool>
{

}

public unsafe class NiagaraRendererProperties : ObjectBase<UNiagaraRendererProperties>
{

}

public unsafe class NiagaraComponentRendererProperties : ObjectBase<UNiagaraComponentRendererProperties>
{

}

public unsafe class NiagaraComponentSettings : ObjectBase<UNiagaraComponentSettings>
{

}

public unsafe class NiagaraConvertInPlaceUtilityBase : ObjectBase<UNiagaraConvertInPlaceUtilityBase>
{
}

public unsafe class NiagaraDataInterface : ObjectBase<UNiagaraDataInterface>
{
}

public unsafe class NiagaraDataInterface2DArrayTexture : ObjectBase<UNiagaraDataInterface2DArrayTexture>
{

}

public unsafe class NiagaraDataInterfaceArray : ObjectBase<UNiagaraDataInterfaceArray>
{

}

public unsafe class NiagaraDataInterfaceArrayFloat : ObjectBase<UNiagaraDataInterfaceArrayFloat>
{

}

public unsafe class NiagaraDataInterfaceArrayFloat2 : ObjectBase<UNiagaraDataInterfaceArrayFloat2>
{

}

public unsafe class NiagaraDataInterfaceArrayFloat3 : ObjectBase<UNiagaraDataInterfaceArrayFloat3>
{

}

public unsafe class NiagaraDataInterfaceArrayFloat4 : ObjectBase<UNiagaraDataInterfaceArrayFloat4>
{

}

public unsafe class NiagaraDataInterfaceArrayColor : ObjectBase<UNiagaraDataInterfaceArrayColor>
{

}

public unsafe class NiagaraDataInterfaceArrayQuat : ObjectBase<UNiagaraDataInterfaceArrayQuat>
{

}

public unsafe class NiagaraDataInterfaceArrayFunctionLibrary : ObjectBase<UNiagaraDataInterfaceArrayFunctionLibrary>
{

    public void SetNiagaraArrayVectorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FVector Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVectorValue"),  @params);
    }
    public void SetNiagaraArrayVector4Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FVector4 Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector4Value"),  @params);
    }
    public void SetNiagaraArrayVector4(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector4> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector4"),  @params);
    }
    public void SetNiagaraArrayVector2DValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FVector2D Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector2DValue"),  @params);
    }
    public void SetNiagaraArrayVector2D(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector2D> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector2D"),  @params);
    }
    public void SetNiagaraArrayVector(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector"),  @params);
    }
    public void SetNiagaraArrayQuatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FQuat Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayQuatValue"),  @params);
    }
    public void SetNiagaraArrayQuat(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FQuat> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayQuat"),  @params);
    }
    public void SetNiagaraArrayInt32Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, int Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayInt32Value"),  @params);
    }
    public void SetNiagaraArrayInt32(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<int> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayInt32"),  @params);
    }
    public void SetNiagaraArrayFloatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, float Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayFloatValue"),  @params);
    }
    public void SetNiagaraArrayFloat(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<float> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayFloat"),  @params);
    }
    public void SetNiagaraArrayColorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FLinearColor Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayColorValue"),  @params);
    }
    public void SetNiagaraArrayColor(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FLinearColor> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayColor"),  @params);
    }
    public void SetNiagaraArrayBoolValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref bool Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayBoolValue"),  @params);
    }
    public void SetNiagaraArrayBool(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<bool> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayBool"),  @params);
    }
    public FVector GetNiagaraArrayVectorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector>(GetFunction("GetNiagaraArrayVectorValue"),  @params);
    }
    public FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector4>(GetFunction("GetNiagaraArrayVector4Value"),  @params);
    }
    public TArray<FVector4> GetNiagaraArrayVector4(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector4>>(GetFunction("GetNiagaraArrayVector4"),  @params);
    }
    public FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetNiagaraArrayVector2DValue"),  @params);
    }
    public TArray<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector2D>>(GetFunction("GetNiagaraArrayVector2D"),  @params);
    }
    public TArray<FVector> GetNiagaraArrayVector(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraArrayVector"),  @params);
    }
    public FQuat GetNiagaraArrayQuatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FQuat>(GetFunction("GetNiagaraArrayQuatValue"),  @params);
    }
    public TArray<FQuat> GetNiagaraArrayQuat(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FQuat>>(GetFunction("GetNiagaraArrayQuat"),  @params);
    }
    public int GetNiagaraArrayInt32Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetNiagaraArrayInt32Value"),  @params);
    }
    public TArray<int> GetNiagaraArrayInt32(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetNiagaraArrayInt32"),  @params);
    }
    public float GetNiagaraArrayFloatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<float>(GetFunction("GetNiagaraArrayFloatValue"),  @params);
    }
    public TArray<float> GetNiagaraArrayFloat(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("GetNiagaraArrayFloat"),  @params);
    }
    public FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetNiagaraArrayColorValue"),  @params);
    }
    public TArray<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FLinearColor>>(GetFunction("GetNiagaraArrayColor"),  @params);
    }
    public bool GetNiagaraArrayBoolValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("GetNiagaraArrayBoolValue"),  @params);
    }
    public TArray<bool> GetNiagaraArrayBool(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<bool>>(GetFunction("GetNiagaraArrayBool"),  @params);
    }
}

public unsafe class NiagaraDataInterfaceArrayInt32 : ObjectBase<UNiagaraDataInterfaceArrayInt32>
{

}

public unsafe class NiagaraDataInterfaceArrayBool : ObjectBase<UNiagaraDataInterfaceArrayBool>
{

}

public unsafe class NiagaraDataInterfaceAudioSubmix : ObjectBase<UNiagaraDataInterfaceAudioSubmix>
{

}

public unsafe class NiagaraDataInterfaceAudioOscilloscope : ObjectBase<UNiagaraDataInterfaceAudioOscilloscope>
{

}

public unsafe class NiagaraDataInterfaceAudioPlayer : ObjectBase<UNiagaraDataInterfaceAudioPlayer>
{

}

public unsafe class NiagaraDataInterfaceAudioSpectrum : ObjectBase<UNiagaraDataInterfaceAudioSpectrum>
{

}

public unsafe class NiagaraDataInterfaceCamera : ObjectBase<UNiagaraDataInterfaceCamera>
{

}

public unsafe class NiagaraDataInterfaceCollisionQuery : ObjectBase<UNiagaraDataInterfaceCollisionQuery>
{
}

public unsafe class NiagaraDataInterfaceCurveBase : ObjectBase<UNiagaraDataInterfaceCurveBase>
{

}

public unsafe class NiagaraDataInterfaceColorCurve : ObjectBase<UNiagaraDataInterfaceColorCurve>
{

}

public unsafe class NiagaraDataInterfaceCubeTexture : ObjectBase<UNiagaraDataInterfaceCubeTexture>
{

}

public unsafe class NiagaraDataInterfaceCurlNoise : ObjectBase<UNiagaraDataInterfaceCurlNoise>
{

}

public unsafe class NiagaraDataInterfaceCurve : ObjectBase<UNiagaraDataInterfaceCurve>
{

}

public unsafe class NiagaraDataInterfaceDebugDraw : ObjectBase<UNiagaraDataInterfaceDebugDraw>
{
}

public unsafe class BasicParticleData : ObjectBase<FBasicParticleData>
{

}

public unsafe class NiagaraParticleCallbackHandler : ObjectBase<INiagaraParticleCallbackHandler>
{

    public void ReceiveParticleData(ref TArray<FBasicParticleData> Data, UNiagaraSystem* NiagaraSystem)
    {
        Span<(string name, object value)> @params = [
            ("Data", Data), 
            ("NiagaraSystem", (IntPtr)NiagaraSystem)
        ];
        ProcessEvent(GetFunction("ReceiveParticleData"),  @params);
    }
}

public unsafe class NiagaraDataInterfaceExport : ObjectBase<UNiagaraDataInterfaceExport>
{

}

public unsafe class NiagaraDataInterfaceGBuffer : ObjectBase<UNiagaraDataInterfaceGBuffer>
{
}

public unsafe class NiagaraDataInterfaceRWBase : ObjectBase<UNiagaraDataInterfaceRWBase>
{

}

public unsafe class NiagaraDataInterfaceGrid2D : ObjectBase<UNiagaraDataInterfaceGrid2D>
{

}

public unsafe class NiagaraDataInterfaceGrid2DCollection : ObjectBase<UNiagaraDataInterfaceGrid2DCollection>
{

    public void GetTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY)
        ];
        ProcessEvent(GetFunction("GetTextureSize"),  @params);
    }
    public void GetRawTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY)
        ];
        ProcessEvent(GetFunction("GetRawTextureSize"),  @params);
    }
    public bool FillTexture2D(UNiagaraComponent* Component, UTextureRenderTarget2D* Dest, int AttributeIndex)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("AttributeIndex", AttributeIndex)
        ];
        return ProcessEvent<bool>(GetFunction("FillTexture2D"),  @params);
    }
    public bool FillRawTexture2D(UNiagaraComponent* Component, UTextureRenderTarget2D* Dest, ref int TilesX, ref int TilesY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("TilesX", TilesX), 
            ("TilesY", TilesY)
        ];
        return ProcessEvent<bool>(GetFunction("FillRawTexture2D"),  @params);
    }
}

public unsafe class NiagaraDataInterfaceGrid2DCollectionReader : ObjectBase<UNiagaraDataInterfaceGrid2DCollectionReader>
{

}

public unsafe class NiagaraDataInterfaceGrid3D : ObjectBase<UNiagaraDataInterfaceGrid3D>
{

}

public unsafe class NiagaraDataInterfaceGrid3DCollection : ObjectBase<UNiagaraDataInterfaceGrid3DCollection>
{

    public void GetTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY, ref int SizeZ)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("SizeZ", SizeZ)
        ];
        ProcessEvent(GetFunction("GetTextureSize"),  @params);
    }
    public void GetRawTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY, ref int SizeZ)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("SizeZ", SizeZ)
        ];
        ProcessEvent(GetFunction("GetRawTextureSize"),  @params);
    }
    public bool FillVolumeTexture(UNiagaraComponent* Component, UVolumeTexture* Dest, int AttributeIndex)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("AttributeIndex", AttributeIndex)
        ];
        return ProcessEvent<bool>(GetFunction("FillVolumeTexture"),  @params);
    }
    public bool FillRawVolumeTexture(UNiagaraComponent* Component, UVolumeTexture* Dest, ref int TilesX, ref int TilesY, ref int TileZ)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("TilesX", TilesX), 
            ("TilesY", TilesY), 
            ("TileZ", TileZ)
        ];
        return ProcessEvent<bool>(GetFunction("FillRawVolumeTexture"),  @params);
    }
}

public unsafe class NiagaraDataInterfaceIntRenderTarget2D : ObjectBase<UNiagaraDataInterfaceIntRenderTarget2D>
{

}

public unsafe class NiagaraDataInterfaceLandscape : ObjectBase<UNiagaraDataInterfaceLandscape>
{

}

public unsafe class NiagaraDataInterfaceMeshRendererInfo : ObjectBase<UNiagaraDataInterfaceMeshRendererInfo>
{

}

public unsafe class NiagaraDataInterfaceNeighborGrid3D : ObjectBase<UNiagaraDataInterfaceNeighborGrid3D>
{

}

public unsafe class NiagaraDataInterfaceOcclusion : ObjectBase<UNiagaraDataInterfaceOcclusion>
{
}

public unsafe class NiagaraDataInterfaceParticleRead : ObjectBase<UNiagaraDataInterfaceParticleRead>
{

}

public unsafe class NiagaraDataInterfacePlatformSet : ObjectBase<UNiagaraDataInterfacePlatformSet>
{

}

public unsafe class NiagaraDataInterfaceRenderTarget2D : ObjectBase<UNiagaraDataInterfaceRenderTarget2D>
{

}

public unsafe class NiagaraDataInterfaceRenderTarget2DArray : ObjectBase<UNiagaraDataInterfaceRenderTarget2DArray>
{

}

public unsafe class NiagaraDataInterfaceRenderTargetCube : ObjectBase<UNiagaraDataInterfaceRenderTargetCube>
{

}

public unsafe class NiagaraDataInterfaceRenderTargetVolume : ObjectBase<UNiagaraDataInterfaceRenderTargetVolume>
{

}

public unsafe class NiagaraDataInterfaceSimpleCounter : ObjectBase<UNiagaraDataInterfaceSimpleCounter>
{
}

public unsafe class NiagaraDataInterfaceSkeletalMesh : ObjectBase<UNiagaraDataInterfaceSkeletalMesh>
{

}

public unsafe class NiagaraDataInterfaceSpline : ObjectBase<UNiagaraDataInterfaceSpline>
{

}

public unsafe class NiagaraDataInterfaceStaticMesh : ObjectBase<UNiagaraDataInterfaceStaticMesh>
{

}

public unsafe class NiagaraDataInterfaceTexture : ObjectBase<UNiagaraDataInterfaceTexture>
{

}

public unsafe class NiagaraDataInterfaceVector2DCurve : ObjectBase<UNiagaraDataInterfaceVector2DCurve>
{

}

public unsafe class NiagaraDataInterfaceVector4Curve : ObjectBase<UNiagaraDataInterfaceVector4Curve>
{

}

public unsafe class NiagaraDataInterfaceVectorCurve : ObjectBase<UNiagaraDataInterfaceVectorCurve>
{

}

public unsafe class NiagaraDataInterfaceVectorField : ObjectBase<UNiagaraDataInterfaceVectorField>
{

}

public unsafe class NiagaraDataInterfaceVolumeTexture : ObjectBase<UNiagaraDataInterfaceVolumeTexture>
{

}

public unsafe class NiagaraDebugHUDSettings : ObjectBase<UNiagaraDebugHUDSettings>
{

}

public unsafe class NiagaraEditorDataBase : ObjectBase<UNiagaraEditorDataBase>
{
}

public unsafe class NiagaraEditorParametersAdapterBase : ObjectBase<UNiagaraEditorParametersAdapterBase>
{
}

public unsafe class NiagaraSignificanceHandler : ObjectBase<UNiagaraSignificanceHandler>
{
}

public unsafe class NiagaraSignificanceHandlerDistance : ObjectBase<UNiagaraSignificanceHandlerDistance>
{
}

public unsafe class NiagaraSignificanceHandlerAge : ObjectBase<UNiagaraSignificanceHandlerAge>
{
}

public unsafe class NiagaraEffectType : ObjectBase<UNiagaraEffectType>
{

}

public unsafe class NiagaraEmitter : ObjectBase<UNiagaraEmitter>
{

}

public unsafe class NiagaraEventReceiverEmitterAction : ObjectBase<UNiagaraEventReceiverEmitterAction>
{
}

public unsafe class NiagaraEventReceiverEmitterAction_SpawnParticles : ObjectBase<UNiagaraEventReceiverEmitterAction_SpawnParticles>
{

}

public unsafe class NiagaraFunctionLibrary : ObjectBase<UNiagaraFunctionLibrary>
{

    public UNiagaraComponent* SpawnSystemAttached(UNiagaraSystem* SystemTemplate, USceneComponent* AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
    {
        Span<(string name, object value)> @params = [
            ("SystemTemplate", (IntPtr)SystemTemplate), 
            ("AttachToComponent", (IntPtr)AttachToComponent), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("LocationType", LocationType), 
            ("bAutoDestroy", bAutoDestroy), 
            ("bAutoActivate", bAutoActivate), 
            ("PoolingMethod", PoolingMethod), 
            ("bPreCullCheck", bPreCullCheck)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAttached"),  @params);
    }
    public UNiagaraComponent* SpawnSystemAtLocation(UObject* WorldContextObject, UNiagaraSystem* SystemTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SystemTemplate", (IntPtr)SystemTemplate), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("Scale", Scale), 
            ("bAutoDestroy", bAutoDestroy), 
            ("bAutoActivate", bAutoActivate), 
            ("PoolingMethod", PoolingMethod), 
            ("bPreCullCheck", bPreCullCheck)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAtLocation"),  @params);
    }
    public void SetVolumeTextureObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UVolumeTexture* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetVolumeTextureObject"),  @params);
    }
    public void SetTextureObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UTexture* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetTextureObject"),  @params);
    }
    public void SetTexture2DArrayObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UTexture2DArray* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetTexture2DArrayObject"),  @params);
    }
    public void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent* NiagaraSystem, FString OverrideName, ref TArray<FName> SamplingRegions)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("SamplingRegions", SamplingRegions)
        ];
        ProcessEvent(GetFunction("SetSkeletalMeshDataInterfaceSamplingRegions"),  @params);
    }
    public void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent* NiagaraSystem, FString OverrideName, UStaticMeshComponent* StaticMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("StaticMeshComponent", (IntPtr)StaticMeshComponent)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableStaticMeshComponent"),  @params);
    }
    public void OverrideSystemUserVariableStaticMesh(UNiagaraComponent* NiagaraSystem, FString OverrideName, UStaticMesh* StaticMesh)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("StaticMesh", (IntPtr)StaticMesh)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableStaticMesh"),  @params);
    }
    public void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent* NiagaraSystem, FString OverrideName, USkeletalMeshComponent* SkeletalMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("SkeletalMeshComponent", (IntPtr)SkeletalMeshComponent)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableSkeletalMeshComponent"),  @params);
    }
    public UNiagaraParameterCollectionInstance* GetNiagaraParameterCollection(UObject* WorldContextObject, UNiagaraParameterCollection* Collection)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Collection", (IntPtr)Collection)
        ];
        return (UNiagaraParameterCollectionInstance*)ProcessEvent<IntPtr>(GetFunction("GetNiagaraParameterCollection"),  @params);
    }
}

public unsafe class NiagaraLightRendererProperties : ObjectBase<UNiagaraLightRendererProperties>
{

}

public unsafe class NiagaraMeshRendererProperties : ObjectBase<UNiagaraMeshRendererProperties>
{

}

public unsafe class NiagaraMessageDataBase : ObjectBase<UNiagaraMessageDataBase>
{
}

public unsafe class NiagaraParameterCollectionInstance : ObjectBase<UNiagaraParameterCollectionInstance>
{

    public void SetVectorParameter(FString InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVectorParameter"),  @params);
    }
    public void SetVector4Parameter(FString InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVector4Parameter"),  @params);
    }
    public void SetVector2DParameter(FString InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVector2DParameter"),  @params);
    }
    public void SetQuatParameter(FString InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetQuatParameter"),  @params);
    }
    public void SetIntParameter(FString InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetIntParameter"),  @params);
    }
    public void SetFloatParameter(FString InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetFloatParameter"),  @params);
    }
    public void SetColorParameter(FString InVariableName, FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetColorParameter"),  @params);
    }
    public void SetBoolParameter(FString InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetBoolParameter"),  @params);
    }
    public FVector GetVectorParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector>(GetFunction("GetVectorParameter"),  @params);
    }
    public FVector4 GetVector4Parameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector4>(GetFunction("GetVector4Parameter"),  @params);
    }
    public FVector2D GetVector2DParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetVector2DParameter"),  @params);
    }
    public FQuat GetQuatParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FQuat>(GetFunction("GetQuatParameter"),  @params);
    }
    public int GetIntParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<int>(GetFunction("GetIntParameter"),  @params);
    }
    public float GetFloatParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<float>(GetFunction("GetFloatParameter"),  @params);
    }
    public FLinearColor GetColorParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetColorParameter"),  @params);
    }
    public bool GetBoolParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<bool>(GetFunction("GetBoolParameter"),  @params);
    }
}

public unsafe class NiagaraParameterCollection : ObjectBase<UNiagaraParameterCollection>
{

}

public unsafe class NiagaraParameterDefinitionsBase : ObjectBase<UNiagaraParameterDefinitionsBase>
{
}

public unsafe class NiagaraPerfBaselineStats : ObjectBase<FNiagaraPerfBaselineStats>
{

}

public unsafe class NiagaraBaselineController : ObjectBase<UNiagaraBaselineController>
{

    public bool OnTickTest()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnTickTest"),  @params);
    }
    public void OnOwnerTick(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("OnOwnerTick"),  @params);
    }
    public void OnEndTest(FNiagaraPerfBaselineStats Stats)
    {
        Span<(string name, object value)> @params = [
            ("Stats", Stats)
        ];
        ProcessEvent(GetFunction("OnEndTest"),  @params);
    }
    public void OnBeginTest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBeginTest"),  @params);
    }
    public UNiagaraSystem* GetSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraSystem*)ProcessEvent<IntPtr>(GetFunction("GetSystem"),  @params);
    }
}

public unsafe class NiagaraBaselineController_Basic : ObjectBase<UNiagaraBaselineController_Basic>
{

}

public unsafe class NiagaraPerfBaselineActor : ObjectBase<ANiagaraPerfBaselineActor>
{

}

public unsafe class NiagaraPrecompileContainer : ObjectBase<UNiagaraPrecompileContainer>
{

}

public unsafe class NiagaraPreviewBase : ObjectBase<ANiagaraPreviewBase>
{

    public void SetSystem(UNiagaraSystem* InSystem)
    {
        Span<(string name, object value)> @params = [
            ("InSystem", (IntPtr)InSystem)
        ];
        ProcessEvent(GetFunction("SetSystem"),  @params);
    }
    public void SetLabelText(ref FText InXAxisText, ref FText InYAxisText)
    {
        Span<(string name, object value)> @params = [
            ("InXAxisText", InXAxisText), 
            ("InYAxisText", InYAxisText)
        ];
        ProcessEvent(GetFunction("SetLabelText"),  @params);
    }
}

public unsafe class NiagaraPreviewAxis : ObjectBase<UNiagaraPreviewAxis>
{

    public int Num()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("Num"),  @params);
    }
    public void ApplyToPreview(UNiagaraComponent* PreviewComponent, int PreviewIndex, bool bIsXAxis, ref FString OutLabelText)
    {
        Span<(string name, object value)> @params = [
            ("PreviewComponent", (IntPtr)PreviewComponent), 
            ("PreviewIndex", PreviewIndex), 
            ("bIsXAxis", bIsXAxis), 
            ("OutLabelText", OutLabelText)
        ];
        ProcessEvent(GetFunction("ApplyToPreview"),  @params);
    }
}

public unsafe class NiagaraPreviewAxis_InterpParamBase : ObjectBase<UNiagaraPreviewAxis_InterpParamBase>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamInt32 : ObjectBase<UNiagaraPreviewAxis_InterpParamInt32>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamFloat : ObjectBase<UNiagaraPreviewAxis_InterpParamFloat>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamVector2D : ObjectBase<UNiagaraPreviewAxis_InterpParamVector2D>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamVector : ObjectBase<UNiagaraPreviewAxis_InterpParamVector>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamVector4 : ObjectBase<UNiagaraPreviewAxis_InterpParamVector4>
{

}

public unsafe class NiagaraPreviewAxis_InterpParamLinearColor : ObjectBase<UNiagaraPreviewAxis_InterpParamLinearColor>
{

}

public unsafe class NiagaraPreviewGrid : ObjectBase<ANiagaraPreviewGrid>
{

    public void SetPaused(bool bPaused)
    {
        Span<(string name, object value)> @params = [
            ("bPaused", bPaused)
        ];
        ProcessEvent(GetFunction("SetPaused"),  @params);
    }
    public void GetPreviews(ref TArray<IntPtr> OutPreviews)
    {
        Span<(string name, object value)> @params = [
            ("OutPreviews", OutPreviews)
        ];
        ProcessEvent(GetFunction("GetPreviews"),  @params);
    }
    public void DeactivatePreviews()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeactivatePreviews"),  @params);
    }
    public void ActivatePreviews(bool bReset)
    {
        Span<(string name, object value)> @params = [
            ("bReset", bReset)
        ];
        ProcessEvent(GetFunction("ActivatePreviews"),  @params);
    }
}

public unsafe class NiagaraRibbonRendererProperties : ObjectBase<UNiagaraRibbonRendererProperties>
{

}

public unsafe class NiagaraScript : ObjectBase<UNiagaraScript>
{

    public void RaiseOnGPUCompilationComplete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RaiseOnGPUCompilationComplete"),  @params);
    }
}

public unsafe class NiagaraScriptSourceBase : ObjectBase<UNiagaraScriptSourceBase>
{
}

public unsafe class NiagaraSettings : ObjectBase<UNiagaraSettings>
{

}

public unsafe class NiagaraSimulationStageBase : ObjectBase<UNiagaraSimulationStageBase>
{

}

public unsafe class NiagaraSimulationStageGeneric : ObjectBase<UNiagaraSimulationStageGeneric>
{

}

public unsafe class NiagaraSpriteRendererProperties : ObjectBase<UNiagaraSpriteRendererProperties>
{

}

public unsafe class NiagaraSystem : ObjectBase<UNiagaraSystem>
{

}

public unsafe class MovieSceneNiagaraParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraParameterSectionTemplate>
{

}

public unsafe class NiagaraVariableBase : ObjectBase<FNiagaraVariableBase>
{

}

public unsafe class NiagaraTypeDefinitionHandle : ObjectBase<FNiagaraTypeDefinitionHandle>
{

}

public unsafe class NiagaraVariable : ObjectBase<FNiagaraVariable>
{

}

public unsafe class MovieSceneNiagaraBoolParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraBoolParameterSectionTemplate>
{

}

public unsafe class MovieSceneNiagaraColorParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraColorParameterSectionTemplate>
{

}

public unsafe class MovieSceneNiagaraFloatParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraFloatParameterSectionTemplate>
{

}

public unsafe class MovieSceneNiagaraIntegerParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraIntegerParameterSectionTemplate>
{

}

public unsafe class MovieSceneNiagaraSystemTrackImplementation : ObjectBase<FMovieSceneNiagaraSystemTrackImplementation>
{

}

public unsafe class MovieSceneNiagaraSystemTrackTemplate : ObjectBase<FMovieSceneNiagaraSystemTrackTemplate>
{
}

public unsafe class MovieSceneNiagaraVectorParameterSectionTemplate : ObjectBase<FMovieSceneNiagaraVectorParameterSectionTemplate>
{

}

public unsafe class NiagaraBakerTextureSettings : ObjectBase<FNiagaraBakerTextureSettings>
{

}

public unsafe class NiagaraBakerTextureSource : ObjectBase<FNiagaraBakerTextureSource>
{

}

public unsafe class NiagaraScalabilityState : ObjectBase<FNiagaraScalabilityState>
{

}

public unsafe class NiagaraCompileDependency : ObjectBase<FNiagaraCompileDependency>
{

}

public unsafe class NiagaraRandInfo : ObjectBase<FNiagaraRandInfo>
{

}

public unsafe class NiagaraUserParameterBinding : ObjectBase<FNiagaraUserParameterBinding>
{

}

public unsafe class NiagaraScriptVariableBinding : ObjectBase<FNiagaraScriptVariableBinding>
{

}

public unsafe class NiagaraVariableDataInterfaceBinding : ObjectBase<FNiagaraVariableDataInterfaceBinding>
{

}

public unsafe class NiagaraMaterialAttributeBinding : ObjectBase<FNiagaraMaterialAttributeBinding>
{

}

public unsafe class NiagaraVariableAttributeBinding : ObjectBase<FNiagaraVariableAttributeBinding>
{

}

public unsafe class NiagaraVariableInfo : ObjectBase<FNiagaraVariableInfo>
{

}

public unsafe class NiagaraSystemUpdateContext : ObjectBase<FNiagaraSystemUpdateContext>
{

}

public unsafe class VMExternalFunctionBindingInfo : ObjectBase<FVMExternalFunctionBindingInfo>
{

}

public unsafe class VMFunctionSpecifier : ObjectBase<FVMFunctionSpecifier>
{

}

public unsafe class NiagaraStatScope : ObjectBase<FNiagaraStatScope>
{

}

public unsafe class NiagaraScriptDataInterfaceCompileInfo : ObjectBase<FNiagaraScriptDataInterfaceCompileInfo>
{

}

public unsafe class NiagaraTypeDefinition : ObjectBase<FNiagaraTypeDefinition>
{

}

public unsafe class NiagaraScriptDataInterfaceInfo : ObjectBase<FNiagaraScriptDataInterfaceInfo>
{

}

public unsafe class NiagaraFunctionSignature : ObjectBase<FNiagaraFunctionSignature>
{

}

public unsafe class NiagaraScriptDataUsageInfo : ObjectBase<FNiagaraScriptDataUsageInfo>
{

}

public unsafe class NiagaraDataSetProperties : ObjectBase<FNiagaraDataSetProperties>
{

}

public unsafe class NiagaraDataSetID : ObjectBase<FNiagaraDataSetID>
{

}

public unsafe class NiagaraMaterialOverride : ObjectBase<FNiagaraMaterialOverride>
{

}

public unsafe class NCPool : ObjectBase<FNCPool>
{

}

public unsafe class NCPoolElement : ObjectBase<FNCPoolElement>
{

}

public unsafe class NiagaraComponentPropertyBinding : ObjectBase<FNiagaraComponentPropertyBinding>
{

}

public unsafe class NiagaraEmitterNameSettingsRef : ObjectBase<FNiagaraEmitterNameSettingsRef>
{

}

public unsafe class MeshTriCoordinate : ObjectBase<FMeshTriCoordinate>
{

}

public unsafe class NDIStaticMeshSectionFilter : ObjectBase<FNDIStaticMeshSectionFilter>
{

}

public unsafe class NiagaraDataSetCompiledData : ObjectBase<FNiagaraDataSetCompiledData>
{

}

public unsafe class NiagaraVariableLayoutInfo : ObjectBase<FNiagaraVariableLayoutInfo>
{

}

public unsafe class NiagaraTypeLayoutInfo : ObjectBase<FNiagaraTypeLayoutInfo>
{

}

public unsafe class NiagaraSimpleClientInfo : ObjectBase<FNiagaraSimpleClientInfo>
{

}

public unsafe class NiagaraOutlinerCaptureSettings : ObjectBase<FNiagaraOutlinerCaptureSettings>
{

}

public unsafe class NiagaraRequestSimpleClientInfoMessage : ObjectBase<FNiagaraRequestSimpleClientInfoMessage>
{
}

public unsafe class NiagaraDebugHUDSettingsData : ObjectBase<FNiagaraDebugHUDSettingsData>
{

}

public unsafe class NiagaraDebugHudTextOptions : ObjectBase<FNiagaraDebugHudTextOptions>
{

}

public unsafe class NiagaraDebugHUDVariable : ObjectBase<FNiagaraDebugHUDVariable>
{

}

public unsafe class NiagaraDebuggerOutlinerUpdate : ObjectBase<FNiagaraDebuggerOutlinerUpdate>
{

}

public unsafe class NiagaraOutlinerData : ObjectBase<FNiagaraOutlinerData>
{

}

public unsafe class NiagaraOutlinerWorldData : ObjectBase<FNiagaraOutlinerWorldData>
{

}

public unsafe class NiagaraOutlinerTimingData : ObjectBase<FNiagaraOutlinerTimingData>
{

}

public unsafe class NiagaraOutlinerSystemData : ObjectBase<FNiagaraOutlinerSystemData>
{

}

public unsafe class NiagaraOutlinerSystemInstanceData : ObjectBase<FNiagaraOutlinerSystemInstanceData>
{

}

public unsafe class NiagaraOutlinerEmitterInstanceData : ObjectBase<FNiagaraOutlinerEmitterInstanceData>
{

}

public unsafe class NiagaraDebuggerExecuteConsoleCommand : ObjectBase<FNiagaraDebuggerExecuteConsoleCommand>
{

}

public unsafe class NiagaraDebuggerConnectionClosed : ObjectBase<FNiagaraDebuggerConnectionClosed>
{

}

public unsafe class NiagaraDebuggerAcceptConnection : ObjectBase<FNiagaraDebuggerAcceptConnection>
{

}

public unsafe class NiagaraDebuggerRequestConnection : ObjectBase<FNiagaraDebuggerRequestConnection>
{

}

public unsafe class NiagaraGraphViewSettings : ObjectBase<FNiagaraGraphViewSettings>
{

}

public unsafe class NiagaraEmitterScalabilityOverrides : ObjectBase<FNiagaraEmitterScalabilityOverrides>
{

}

public unsafe class NiagaraEmitterScalabilitySettings : ObjectBase<FNiagaraEmitterScalabilitySettings>
{

}

public unsafe class NiagaraPlatformSet : ObjectBase<FNiagaraPlatformSet>
{

}

public unsafe class NiagaraPlatformSetCVarCondition : ObjectBase<FNiagaraPlatformSetCVarCondition>
{

}

public unsafe class NiagaraDeviceProfileStateEntry : ObjectBase<FNiagaraDeviceProfileStateEntry>
{

}

public unsafe class NiagaraEmitterScalabilityOverride : ObjectBase<FNiagaraEmitterScalabilityOverride>
{

}

public unsafe class NiagaraEmitterScalabilitySettingsArray : ObjectBase<FNiagaraEmitterScalabilitySettingsArray>
{

}

public unsafe class NiagaraSystemScalabilityOverrides : ObjectBase<FNiagaraSystemScalabilityOverrides>
{

}

public unsafe class NiagaraSystemScalabilitySettings : ObjectBase<FNiagaraSystemScalabilitySettings>
{

}

public unsafe class NiagaraSystemScalabilityOverride : ObjectBase<FNiagaraSystemScalabilityOverride>
{

}

public unsafe class NiagaraSystemScalabilitySettingsArray : ObjectBase<FNiagaraSystemScalabilitySettingsArray>
{

}

public unsafe class NiagaraDetailsLevelScaleOverrides : ObjectBase<FNiagaraDetailsLevelScaleOverrides>
{

}

public unsafe class NiagaraEmitterScriptProperties : ObjectBase<FNiagaraEmitterScriptProperties>
{

}

public unsafe class NiagaraEventGeneratorProperties : ObjectBase<FNiagaraEventGeneratorProperties>
{

}

public unsafe class NiagaraEventReceiverProperties : ObjectBase<FNiagaraEventReceiverProperties>
{

}

public unsafe class NiagaraEventScriptProperties : ObjectBase<FNiagaraEventScriptProperties>
{

}

public unsafe class NiagaraEmitterHandle : ObjectBase<FNiagaraEmitterHandle>
{

}

public unsafe class NiagaraCollisionEventPayload : ObjectBase<FNiagaraCollisionEventPayload>
{

}

public unsafe class NiagaraMeshRendererMeshProperties : ObjectBase<FNiagaraMeshRendererMeshProperties>
{

}

public unsafe class NiagaraMeshMaterialOverride : ObjectBase<FNiagaraMeshMaterialOverride>
{

}

public unsafe class ParameterDefinitionsSubscription : ObjectBase<FParameterDefinitionsSubscription>
{
}

public unsafe class NiagaraParameters : ObjectBase<FNiagaraParameters>
{

}

public unsafe class NiagaraParameterStore : ObjectBase<FNiagaraParameterStore>
{

}

public unsafe class NiagaraVariableWithOffset : ObjectBase<FNiagaraVariableWithOffset>
{

}

public unsafe class NiagaraBoundParameter : ObjectBase<FNiagaraBoundParameter>
{

}

public unsafe class NiagaraPlatformSetConflictInfo : ObjectBase<FNiagaraPlatformSetConflictInfo>
{

}

public unsafe class NiagaraPlatformSetConflictEntry : ObjectBase<FNiagaraPlatformSetConflictEntry>
{

}

public unsafe class NiagaraRibbonUVSettings : ObjectBase<FNiagaraRibbonUVSettings>
{

}

public unsafe class NiagaraRibbonShapeCustomVertex : ObjectBase<FNiagaraRibbonShapeCustomVertex>
{

}

public unsafe class NiagaraScalabilityManager : ObjectBase<FNiagaraScalabilityManager>
{

}

public unsafe class VersionedNiagaraScriptData : ObjectBase<FVersionedNiagaraScriptData>
{
}

public unsafe class NiagaraVMExecutableData : ObjectBase<FNiagaraVMExecutableData>
{

}

public unsafe class NiagaraCompilerTag : ObjectBase<FNiagaraCompilerTag>
{

}

public unsafe class NiagaraVMExecutableDataId : ObjectBase<FNiagaraVMExecutableDataId>
{

}

public unsafe class NiagaraModuleDependency : ObjectBase<FNiagaraModuleDependency>
{

}

public unsafe class NiagaraScriptInstanceParameterStore : ObjectBase<FNiagaraScriptInstanceParameterStore>
{
}

public unsafe class NiagaraScriptExecutionParameterStore : ObjectBase<FNiagaraScriptExecutionParameterStore>
{

}

public unsafe class NiagaraScriptExecutionPaddingInfo : ObjectBase<FNiagaraScriptExecutionPaddingInfo>
{

}

public unsafe class NiagaraScriptHighlight : ObjectBase<FNiagaraScriptHighlight>
{

}

public unsafe class NiagaraSystemCompileRequest : ObjectBase<FNiagaraSystemCompileRequest>
{

}

public unsafe class EmitterCompiledScriptPair : ObjectBase<FEmitterCompiledScriptPair>
{
}

public unsafe class NiagaraSystemCompiledData : ObjectBase<FNiagaraSystemCompiledData>
{

}

public unsafe class NiagaraParameterDataSetBindingCollection : ObjectBase<FNiagaraParameterDataSetBindingCollection>
{

}

public unsafe class NiagaraParameterDataSetBinding : ObjectBase<FNiagaraParameterDataSetBinding>
{

}

public unsafe class NiagaraEmitterCompiledData : ObjectBase<FNiagaraEmitterCompiledData>
{

}

public unsafe class NiagaraVariableMetaData : ObjectBase<FNiagaraVariableMetaData>
{

}

public unsafe class NiagaraInputConditionMetadata : ObjectBase<FNiagaraInputConditionMetadata>
{

}

public unsafe class NiagaraCompileHashVisitorDebugInfo : ObjectBase<FNiagaraCompileHashVisitorDebugInfo>
{

}

public unsafe class NiagaraID : ObjectBase<FNiagaraID>
{

}

public unsafe class NiagaraSpawnInfo : ObjectBase<FNiagaraSpawnInfo>
{

}

public unsafe class NiagaraAssetVersion : ObjectBase<FNiagaraAssetVersion>
{

}

public unsafe class NiagaraMatrix : ObjectBase<FNiagaraMatrix>
{

}

public unsafe class NiagaraParameterMap : ObjectBase<FNiagaraParameterMap>
{
}

public unsafe class NiagaraNumeric : ObjectBase<FNiagaraNumeric>
{
}

public unsafe class NiagaraHalfVector4 : ObjectBase<FNiagaraHalfVector4>
{

}

public unsafe class NiagaraHalfVector3 : ObjectBase<FNiagaraHalfVector3>
{

}

public unsafe class NiagaraHalfVector2 : ObjectBase<FNiagaraHalfVector2>
{

}

public unsafe class NiagaraHalf : ObjectBase<FNiagaraHalf>
{

}

public unsafe class NiagaraBool : ObjectBase<FNiagaraBool>
{

}

public unsafe class NiagaraInt32 : ObjectBase<FNiagaraInt32>
{

}

public unsafe class NiagaraFloat : ObjectBase<FNiagaraFloat>
{

}

public unsafe class NiagaraWildcard : ObjectBase<FNiagaraWildcard>
{
}

public unsafe class NiagaraUserRedirectionParameterStore : ObjectBase<FNiagaraUserRedirectionParameterStore>
{

}

public unsafe class NiagaraVariant : ObjectBase<FNiagaraVariant>
{

}

public unsafe class NiagaraWorldManagerTickFunction : ObjectBase<FNiagaraWorldManagerTickFunction>
{
}

