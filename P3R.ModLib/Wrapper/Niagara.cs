using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneNiagaraTrack : ObjectBase<UMovieSceneNiagaraTrack>
{
    public MovieSceneNiagaraTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneNiagaraParameterTrack : ObjectBase<UMovieSceneNiagaraParameterTrack>
{
    public MovieSceneNiagaraParameterTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneNiagaraBoolParameterTrack : ObjectBase<UMovieSceneNiagaraBoolParameterTrack>
{
    public MovieSceneNiagaraBoolParameterTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNiagaraColorParameterTrack : ObjectBase<UMovieSceneNiagaraColorParameterTrack>
{
    public MovieSceneNiagaraColorParameterTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNiagaraFloatParameterTrack : ObjectBase<UMovieSceneNiagaraFloatParameterTrack>
{
    public MovieSceneNiagaraFloatParameterTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNiagaraIntegerParameterTrack : ObjectBase<UMovieSceneNiagaraIntegerParameterTrack>
{
    public MovieSceneNiagaraIntegerParameterTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNiagaraSystemSpawnSection : ObjectBase<UMovieSceneNiagaraSystemSpawnSection>
{
    public MovieSceneNiagaraSystemSpawnSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneNiagaraSystemTrack : ObjectBase<UMovieSceneNiagaraSystemTrack>
{
    public MovieSceneNiagaraSystemTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneNiagaraVectorParameterTrack : ObjectBase<UMovieSceneNiagaraVectorParameterTrack>
{
    public MovieSceneNiagaraVectorParameterTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraActor : ObjectBase<ANiagaraActor>
{
    public NiagaraActor(IntPtr pointer) : base(pointer) {}
    public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish)
    {
        Span<(string name, object value)> @params = [
            ("bShouldDestroyOnSystemFinish", bShouldDestroyOnSystemFinish)
        ];
        ProcessEvent(GetFunction("SetDestroyOnSystemFinish"), @params);
    }
    public void OnNiagaraSystemFinished(UNiagaraComponent* FinishedComponent)
    {
        Span<(string name, object value)> @params = [
            ("FinishedComponent", (IntPtr)FinishedComponent)
        ];
        ProcessEvent(GetFunction("OnNiagaraSystemFinished"), @params);
    }
}

public unsafe class NiagaraBakerSettings : ObjectBase<UNiagaraBakerSettings>
{
    public NiagaraBakerSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraComponent : ObjectBase<UNiagaraComponent>
{
    public NiagaraComponent(IntPtr pointer) : base(pointer) {}
    public void SetVariableVec4(FName InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec4"), @params);
    }
    public void SetVariableVec3(FName InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec3"), @params);
    }
    public void SetVariableVec2(FName InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableVec2"), @params);
    }
    public void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget* TextureRenderTarget)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("TextureRenderTarget", (IntPtr)TextureRenderTarget)
        ];
        ProcessEvent(GetFunction("SetVariableTextureRenderTarget"), @params);
    }
    public void SetVariableQuat(FName InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableQuat"), @params);
    }
    public void SetVariableObject(FName InVariableName, UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetVariableObject"), @params);
    }
    public void SetVariableMaterial(FName InVariableName, UMaterialInterface* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetVariableMaterial"), @params);
    }
    public void SetVariableLinearColor(FName InVariableName, ref FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableLinearColor"), @params);
    }
    public void SetVariableInt(FName InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableInt"), @params);
    }
    public void SetVariableFloat(FName InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableFloat"), @params);
    }
    public void SetVariableBool(FName InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVariableBool"), @params);
    }
    public void SetVariableActor(FName InVariableName, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetVariableActor"), @params);
    }
    public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior)
    {
        Span<(string name, object value)> @params = [
            ("NewTickBehavior", NewTickBehavior)
        ];
        ProcessEvent(GetFunction("SetTickBehavior"), @params);
    }
    public void SetSeekDelta(float InSeekDelta)
    {
        Span<(string name, object value)> @params = [
            ("InSeekDelta", InSeekDelta)
        ];
        ProcessEvent(GetFunction("SetSeekDelta"), @params);
    }
    public void SetRenderingEnabled(bool bInRenderingEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bInRenderingEnabled", bInRenderingEnabled)
        ];
        ProcessEvent(GetFunction("SetRenderingEnabled"), @params);
    }
    public void SetRandomSeedOffset(int NewRandomSeedOffset)
    {
        Span<(string name, object value)> @params = [
            ("NewRandomSeedOffset", NewRandomSeedOffset)
        ];
        ProcessEvent(GetFunction("SetRandomSeedOffset"), @params);
    }
    public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance)
    {
        Span<(string name, object value)> @params = [
            ("bEnablePreviewLODDistance", bEnablePreviewLODDistance), 
            ("PreviewLODDistance", PreviewLODDistance)
        ];
        ProcessEvent(GetFunction("SetPreviewLODDistance"), @params);
    }
    public void SetPaused(bool bInPaused)
    {
        Span<(string name, object value)> @params = [
            ("bInPaused", bInPaused)
        ];
        ProcessEvent(GetFunction("SetPaused"), @params);
    }
    public void SetNiagaraVariableVec4(FString InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec4"), @params);
    }
    public void SetNiagaraVariableVec3(FString InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec3"), @params);
    }
    public void SetNiagaraVariableVec2(FString InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableVec2"), @params);
    }
    public void SetNiagaraVariableQuat(FString InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableQuat"), @params);
    }
    public void SetNiagaraVariableObject(FString InVariableName, UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableObject"), @params);
    }
    public void SetNiagaraVariableLinearColor(FString InVariableName, ref FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableLinearColor"), @params);
    }
    public void SetNiagaraVariableInt(FString InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableInt"), @params);
    }
    public void SetNiagaraVariableFloat(FString InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableFloat"), @params);
    }
    public void SetNiagaraVariableBool(FString InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableBool"), @params);
    }
    public void SetNiagaraVariableActor(FString InVariableName, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetNiagaraVariableActor"), @params);
    }
    public void SetMaxSimTime(float InMaxTime)
    {
        Span<(string name, object value)> @params = [
            ("InMaxTime", InMaxTime)
        ];
        ProcessEvent(GetFunction("SetMaxSimTime"), @params);
    }
    public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
    {
        Span<(string name, object value)> @params = [
            ("bLock", bLock)
        ];
        ProcessEvent(GetFunction("SetLockDesiredAgeDeltaTimeToSeekDelta"), @params);
    }
    public void SetGpuComputeDebug(bool bEnableDebug)
    {
        Span<(string name, object value)> @params = [
            ("bEnableDebug", bEnableDebug)
        ];
        ProcessEvent(GetFunction("SetGpuComputeDebug"), @params);
    }
    public void SetForceSolo(bool bInForceSolo)
    {
        Span<(string name, object value)> @params = [
            ("bInForceSolo", bInForceSolo)
        ];
        ProcessEvent(GetFunction("SetForceSolo"), @params);
    }
    public void SetDesiredAge(float InDesiredAge)
    {
        Span<(string name, object value)> @params = [
            ("InDesiredAge", InDesiredAge)
        ];
        ProcessEvent(GetFunction("SetDesiredAge"), @params);
    }
    public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
    {
        Span<(string name, object value)> @params = [
            ("bInCanRenderWhileSeeking", bInCanRenderWhileSeeking)
        ];
        ProcessEvent(GetFunction("SetCanRenderWhileSeeking"), @params);
    }
    public void SetAutoDestroy(bool bInAutoDestroy)
    {
        Span<(string name, object value)> @params = [
            ("bInAutoDestroy", bInAutoDestroy)
        ];
        ProcessEvent(GetFunction("SetAutoDestroy"), @params);
    }
    public void SetAsset(UNiagaraSystem* InAsset, bool bResetExistingOverrideParameters)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("bResetExistingOverrideParameters", bResetExistingOverrideParameters)
        ];
        ProcessEvent(GetFunction("SetAsset"), @params);
    }
    public void SetAllowScalability(bool bAllow)
    {
        Span<(string name, object value)> @params = [
            ("bAllow", bAllow)
        ];
        ProcessEvent(GetFunction("SetAllowScalability"), @params);
    }
    public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode)
    {
        Span<(string name, object value)> @params = [
            ("InAgeUpdateMode", InAgeUpdateMode)
        ];
        ProcessEvent(GetFunction("SetAgeUpdateMode"), @params);
    }
    public void SeekToDesiredAge(float InDesiredAge)
    {
        Span<(string name, object value)> @params = [
            ("InDesiredAge", InDesiredAge)
        ];
        ProcessEvent(GetFunction("SeekToDesiredAge"), @params);
    }
    public void ResetSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetSystem"), @params);
    }
    public void ReinitializeSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReinitializeSystem"), @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"), @params);
    }
    public void InitForPerformanceBaseline()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitForPerformanceBaseline"), @params);
    }
    public ENiagaraTickBehavior GetTickBehavior()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ENiagaraTickBehavior>(GetFunction("GetTickBehavior"), @params);
    }
    public float GetSeekDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSeekDelta"), @params);
    }
    public int GetRandomSeedOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetRandomSeedOffset"), @params);
    }
    public bool GetPreviewLODDistanceEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetPreviewLODDistanceEnabled"), @params);
    }
    public float GetPreviewLODDistance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPreviewLODDistance"), @params);
    }
    public TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraParticleValueVec3_DebugOnly"), @params);
    }
    public TArray<float> GetNiagaraParticleValues_DebugOnly(FString InEmitterName, FString InValueName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName), 
            ("InValueName", InValueName)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("GetNiagaraParticleValues_DebugOnly"), @params);
    }
    public TArray<FVector> GetNiagaraParticlePositions_DebugOnly(FString InEmitterName)
    {
        Span<(string name, object value)> @params = [
            ("InEmitterName", InEmitterName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraParticlePositions_DebugOnly"), @params);
    }
    public float GetMaxSimTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxSimTime"), @params);
    }
    public bool GetLockDesiredAgeDeltaTimeToSeekDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetLockDesiredAgeDeltaTimeToSeekDelta"), @params);
    }
    public bool GetForceSolo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetForceSolo"), @params);
    }
    public float GetDesiredAge()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDesiredAge"), @params);
    }
    public UNiagaraDataInterface* GetDataInterface(FString Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return (UNiagaraDataInterface*)ProcessEvent<IntPtr>(GetFunction("GetDataInterface"), @params);
    }
    public UNiagaraSystem* GetAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraSystem*)ProcessEvent<IntPtr>(GetFunction("GetAsset"), @params);
    }
    public ENiagaraAgeUpdateMode GetAgeUpdateMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ENiagaraAgeUpdateMode>(GetFunction("GetAgeUpdateMode"), @params);
    }
    public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("SimulateTime", SimulateTime), 
            ("TickDeltaSeconds", TickDeltaSeconds)
        ];
        ProcessEvent(GetFunction("AdvanceSimulationByTime"), @params);
    }
    public void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TickCount", TickCount), 
            ("TickDeltaSeconds", TickDeltaSeconds)
        ];
        ProcessEvent(GetFunction("AdvanceSimulation"), @params);
    }
}

public unsafe class NiagaraComponentPool : ObjectBase<UNiagaraComponentPool>
{
    public NiagaraComponentPool(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraRendererProperties : ObjectBase<UNiagaraRendererProperties>
{
    public NiagaraRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraComponentRendererProperties : ObjectBase<UNiagaraComponentRendererProperties>
{
    public NiagaraComponentRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraComponentSettings : ObjectBase<UNiagaraComponentSettings>
{
    public NiagaraComponentSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraConvertInPlaceUtilityBase : ObjectBase<UNiagaraConvertInPlaceUtilityBase>
{
    public NiagaraConvertInPlaceUtilityBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterface : ObjectBase<UNiagaraDataInterface>
{
    public NiagaraDataInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterface2DArrayTexture : ObjectBase<UNiagaraDataInterface2DArrayTexture>
{
    public NiagaraDataInterface2DArrayTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArray : ObjectBase<UNiagaraDataInterfaceArray>
{
    public NiagaraDataInterfaceArray(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayFloat : ObjectBase<UNiagaraDataInterfaceArrayFloat>
{
    public NiagaraDataInterfaceArrayFloat(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayFloat2 : ObjectBase<UNiagaraDataInterfaceArrayFloat2>
{
    public NiagaraDataInterfaceArrayFloat2(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayFloat3 : ObjectBase<UNiagaraDataInterfaceArrayFloat3>
{
    public NiagaraDataInterfaceArrayFloat3(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayFloat4 : ObjectBase<UNiagaraDataInterfaceArrayFloat4>
{
    public NiagaraDataInterfaceArrayFloat4(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayColor : ObjectBase<UNiagaraDataInterfaceArrayColor>
{
    public NiagaraDataInterfaceArrayColor(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayQuat : ObjectBase<UNiagaraDataInterfaceArrayQuat>
{
    public NiagaraDataInterfaceArrayQuat(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayFunctionLibrary : ObjectBase<UNiagaraDataInterfaceArrayFunctionLibrary>
{
    public NiagaraDataInterfaceArrayFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public void SetNiagaraArrayVectorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index, ref FVector Value, bool bSizeToFit)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index), 
            ("Value", Value), 
            ("bSizeToFit", bSizeToFit)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVectorValue"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayVector4Value"), @params);
    }
    public void SetNiagaraArrayVector4(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector4> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector4"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayVector2DValue"), @params);
    }
    public void SetNiagaraArrayVector2D(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector2D> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector2D"), @params);
    }
    public void SetNiagaraArrayVector(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FVector> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayVector"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayQuatValue"), @params);
    }
    public void SetNiagaraArrayQuat(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FQuat> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayQuat"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayInt32Value"), @params);
    }
    public void SetNiagaraArrayInt32(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<int> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayInt32"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayFloatValue"), @params);
    }
    public void SetNiagaraArrayFloat(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<float> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayFloat"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayColorValue"), @params);
    }
    public void SetNiagaraArrayColor(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<FLinearColor> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayColor"), @params);
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
        ProcessEvent(GetFunction("SetNiagaraArrayBoolValue"), @params);
    }
    public void SetNiagaraArrayBool(UNiagaraComponent* NiagaraSystem, FName OverrideName, ref TArray<bool> ArrayData)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("ArrayData", ArrayData)
        ];
        ProcessEvent(GetFunction("SetNiagaraArrayBool"), @params);
    }
    public FVector GetNiagaraArrayVectorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector>(GetFunction("GetNiagaraArrayVectorValue"), @params);
    }
    public FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector4>(GetFunction("GetNiagaraArrayVector4Value"), @params);
    }
    public TArray<FVector4> GetNiagaraArrayVector4(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector4>>(GetFunction("GetNiagaraArrayVector4"), @params);
    }
    public FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetNiagaraArrayVector2DValue"), @params);
    }
    public TArray<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector2D>>(GetFunction("GetNiagaraArrayVector2D"), @params);
    }
    public TArray<FVector> GetNiagaraArrayVector(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetNiagaraArrayVector"), @params);
    }
    public FQuat GetNiagaraArrayQuatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FQuat>(GetFunction("GetNiagaraArrayQuatValue"), @params);
    }
    public TArray<FQuat> GetNiagaraArrayQuat(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FQuat>>(GetFunction("GetNiagaraArrayQuat"), @params);
    }
    public int GetNiagaraArrayInt32Value(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetNiagaraArrayInt32Value"), @params);
    }
    public TArray<int> GetNiagaraArrayInt32(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetNiagaraArrayInt32"), @params);
    }
    public float GetNiagaraArrayFloatValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<float>(GetFunction("GetNiagaraArrayFloatValue"), @params);
    }
    public TArray<float> GetNiagaraArrayFloat(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<float>>(GetFunction("GetNiagaraArrayFloat"), @params);
    }
    public FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetNiagaraArrayColorValue"), @params);
    }
    public TArray<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<FLinearColor>>(GetFunction("GetNiagaraArrayColor"), @params);
    }
    public bool GetNiagaraArrayBoolValue(UNiagaraComponent* NiagaraSystem, FName OverrideName, int Index)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("GetNiagaraArrayBoolValue"), @params);
    }
    public TArray<bool> GetNiagaraArrayBool(UNiagaraComponent* NiagaraSystem, FName OverrideName)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName)
        ];
        return ProcessEvent<TArray<bool>>(GetFunction("GetNiagaraArrayBool"), @params);
    }
}

public unsafe class NiagaraDataInterfaceArrayInt32 : ObjectBase<UNiagaraDataInterfaceArrayInt32>
{
    public NiagaraDataInterfaceArrayInt32(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceArrayBool : ObjectBase<UNiagaraDataInterfaceArrayBool>
{
    public NiagaraDataInterfaceArrayBool(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceAudioOscilloscope : ObjectBase<UNiagaraDataInterfaceAudioOscilloscope>
{
    public NiagaraDataInterfaceAudioOscilloscope(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceAudioPlayer : ObjectBase<UNiagaraDataInterfaceAudioPlayer>
{
    public NiagaraDataInterfaceAudioPlayer(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceAudioSpectrum : ObjectBase<UNiagaraDataInterfaceAudioSpectrum>
{
    public NiagaraDataInterfaceAudioSpectrum(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceCamera : ObjectBase<UNiagaraDataInterfaceCamera>
{
    public NiagaraDataInterfaceCamera(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceCollisionQuery : ObjectBase<UNiagaraDataInterfaceCollisionQuery>
{
    public NiagaraDataInterfaceCollisionQuery(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterfaceCurveBase : ObjectBase<UNiagaraDataInterfaceCurveBase>
{
    public NiagaraDataInterfaceCurveBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceColorCurve : ObjectBase<UNiagaraDataInterfaceColorCurve>
{
    public NiagaraDataInterfaceColorCurve(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceCubeTexture : ObjectBase<UNiagaraDataInterfaceCubeTexture>
{
    public NiagaraDataInterfaceCubeTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceCurlNoise : ObjectBase<UNiagaraDataInterfaceCurlNoise>
{
    public NiagaraDataInterfaceCurlNoise(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceCurve : ObjectBase<UNiagaraDataInterfaceCurve>
{
    public NiagaraDataInterfaceCurve(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceDebugDraw : ObjectBase<UNiagaraDataInterfaceDebugDraw>
{
    public NiagaraDataInterfaceDebugDraw(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraParticleCallbackHandler : ObjectBase<INiagaraParticleCallbackHandler>
{
    public NiagaraParticleCallbackHandler(IntPtr pointer) : base(pointer) {}
    public void ReceiveParticleData(ref TArray<FBasicParticleData> Data, UNiagaraSystem* NiagaraSystem)
    {
        Span<(string name, object value)> @params = [
            ("Data", Data), 
            ("NiagaraSystem", (IntPtr)NiagaraSystem)
        ];
        ProcessEvent(GetFunction("ReceiveParticleData"), @params);
    }
}

public unsafe class NiagaraDataInterfaceExport : ObjectBase<UNiagaraDataInterfaceExport>
{
    public NiagaraDataInterfaceExport(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceGBuffer : ObjectBase<UNiagaraDataInterfaceGBuffer>
{
    public NiagaraDataInterfaceGBuffer(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterfaceRWBase : ObjectBase<UNiagaraDataInterfaceRWBase>
{
    public NiagaraDataInterfaceRWBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceGrid2D : ObjectBase<UNiagaraDataInterfaceGrid2D>
{
    public NiagaraDataInterfaceGrid2D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceGrid2DCollection : ObjectBase<UNiagaraDataInterfaceGrid2DCollection>
{
    public NiagaraDataInterfaceGrid2DCollection(IntPtr pointer) : base(pointer) {}
    public void GetTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY)
        ];
        ProcessEvent(GetFunction("GetTextureSize"), @params);
    }
    public void GetRawTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY)
        ];
        ProcessEvent(GetFunction("GetRawTextureSize"), @params);
    }
    public bool FillTexture2D(UNiagaraComponent* Component, UTextureRenderTarget2D* Dest, int AttributeIndex)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("AttributeIndex", AttributeIndex)
        ];
        return ProcessEvent<bool>(GetFunction("FillTexture2D"), @params);
    }
    public bool FillRawTexture2D(UNiagaraComponent* Component, UTextureRenderTarget2D* Dest, ref int TilesX, ref int TilesY)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("TilesX", TilesX), 
            ("TilesY", TilesY)
        ];
        return ProcessEvent<bool>(GetFunction("FillRawTexture2D"), @params);
    }
}

public unsafe class NiagaraDataInterfaceGrid2DCollectionReader : ObjectBase<UNiagaraDataInterfaceGrid2DCollectionReader>
{
    public NiagaraDataInterfaceGrid2DCollectionReader(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceGrid3D : ObjectBase<UNiagaraDataInterfaceGrid3D>
{
    public NiagaraDataInterfaceGrid3D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceGrid3DCollection : ObjectBase<UNiagaraDataInterfaceGrid3DCollection>
{
    public NiagaraDataInterfaceGrid3DCollection(IntPtr pointer) : base(pointer) {}
    public void GetTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY, ref int SizeZ)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("SizeZ", SizeZ)
        ];
        ProcessEvent(GetFunction("GetTextureSize"), @params);
    }
    public void GetRawTextureSize(UNiagaraComponent* Component, ref int SizeX, ref int SizeY, ref int SizeZ)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("SizeZ", SizeZ)
        ];
        ProcessEvent(GetFunction("GetRawTextureSize"), @params);
    }
    public bool FillVolumeTexture(UNiagaraComponent* Component, UVolumeTexture* Dest, int AttributeIndex)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("Dest", (IntPtr)Dest), 
            ("AttributeIndex", AttributeIndex)
        ];
        return ProcessEvent<bool>(GetFunction("FillVolumeTexture"), @params);
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
        return ProcessEvent<bool>(GetFunction("FillRawVolumeTexture"), @params);
    }
}

public unsafe class NiagaraDataInterfaceIntRenderTarget2D : ObjectBase<UNiagaraDataInterfaceIntRenderTarget2D>
{
    public NiagaraDataInterfaceIntRenderTarget2D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceLandscape : ObjectBase<UNiagaraDataInterfaceLandscape>
{
    public NiagaraDataInterfaceLandscape(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceMeshRendererInfo : ObjectBase<UNiagaraDataInterfaceMeshRendererInfo>
{
    public NiagaraDataInterfaceMeshRendererInfo(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceNeighborGrid3D : ObjectBase<UNiagaraDataInterfaceNeighborGrid3D>
{
    public NiagaraDataInterfaceNeighborGrid3D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceOcclusion : ObjectBase<UNiagaraDataInterfaceOcclusion>
{
    public NiagaraDataInterfaceOcclusion(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterfaceParticleRead : ObjectBase<UNiagaraDataInterfaceParticleRead>
{
    public NiagaraDataInterfaceParticleRead(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfacePlatformSet : ObjectBase<UNiagaraDataInterfacePlatformSet>
{
    public NiagaraDataInterfacePlatformSet(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceRenderTarget2D : ObjectBase<UNiagaraDataInterfaceRenderTarget2D>
{
    public NiagaraDataInterfaceRenderTarget2D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceRenderTarget2DArray : ObjectBase<UNiagaraDataInterfaceRenderTarget2DArray>
{
    public NiagaraDataInterfaceRenderTarget2DArray(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceRenderTargetCube : ObjectBase<UNiagaraDataInterfaceRenderTargetCube>
{
    public NiagaraDataInterfaceRenderTargetCube(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceRenderTargetVolume : ObjectBase<UNiagaraDataInterfaceRenderTargetVolume>
{
    public NiagaraDataInterfaceRenderTargetVolume(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceSimpleCounter : ObjectBase<UNiagaraDataInterfaceSimpleCounter>
{
    public NiagaraDataInterfaceSimpleCounter(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraDataInterfaceSkeletalMesh : ObjectBase<UNiagaraDataInterfaceSkeletalMesh>
{
    public NiagaraDataInterfaceSkeletalMesh(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceSpline : ObjectBase<UNiagaraDataInterfaceSpline>
{
    public NiagaraDataInterfaceSpline(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceStaticMesh : ObjectBase<UNiagaraDataInterfaceStaticMesh>
{
    public NiagaraDataInterfaceStaticMesh(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceTexture : ObjectBase<UNiagaraDataInterfaceTexture>
{
    public NiagaraDataInterfaceTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceVector2DCurve : ObjectBase<UNiagaraDataInterfaceVector2DCurve>
{
    public NiagaraDataInterfaceVector2DCurve(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceVector4Curve : ObjectBase<UNiagaraDataInterfaceVector4Curve>
{
    public NiagaraDataInterfaceVector4Curve(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceVectorCurve : ObjectBase<UNiagaraDataInterfaceVectorCurve>
{
    public NiagaraDataInterfaceVectorCurve(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceVectorField : ObjectBase<UNiagaraDataInterfaceVectorField>
{
    public NiagaraDataInterfaceVectorField(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceVolumeTexture : ObjectBase<UNiagaraDataInterfaceVolumeTexture>
{
    public NiagaraDataInterfaceVolumeTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDebugHUDSettings : ObjectBase<UNiagaraDebugHUDSettings>
{
    public NiagaraDebugHUDSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraEditorDataBase : ObjectBase<UNiagaraEditorDataBase>
{
    public NiagaraEditorDataBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraEditorParametersAdapterBase : ObjectBase<UNiagaraEditorParametersAdapterBase>
{
    public NiagaraEditorParametersAdapterBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraSignificanceHandler : ObjectBase<UNiagaraSignificanceHandler>
{
    public NiagaraSignificanceHandler(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraSignificanceHandlerDistance : ObjectBase<UNiagaraSignificanceHandlerDistance>
{
    public NiagaraSignificanceHandlerDistance(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraSignificanceHandlerAge : ObjectBase<UNiagaraSignificanceHandlerAge>
{
    public NiagaraSignificanceHandlerAge(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraEffectType : ObjectBase<UNiagaraEffectType>
{
    public NiagaraEffectType(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraEmitter : ObjectBase<UNiagaraEmitter>
{
    public NiagaraEmitter(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraEventReceiverEmitterAction : ObjectBase<UNiagaraEventReceiverEmitterAction>
{
    public NiagaraEventReceiverEmitterAction(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraEventReceiverEmitterAction_SpawnParticles : ObjectBase<UNiagaraEventReceiverEmitterAction_SpawnParticles>
{
    public NiagaraEventReceiverEmitterAction_SpawnParticles(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraFunctionLibrary : ObjectBase<UNiagaraFunctionLibrary>
{
    public NiagaraFunctionLibrary(IntPtr pointer) : base(pointer) {}
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
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAttached"), @params);
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
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnSystemAtLocation"), @params);
    }
    public void SetVolumeTextureObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UVolumeTexture* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetVolumeTextureObject"), @params);
    }
    public void SetTextureObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UTexture* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetTextureObject"), @params);
    }
    public void SetTexture2DArrayObject(UNiagaraComponent* NiagaraSystem, FString OverrideName, UTexture2DArray* Texture)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetTexture2DArrayObject"), @params);
    }
    public void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent* NiagaraSystem, FString OverrideName, ref TArray<FName> SamplingRegions)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("SamplingRegions", SamplingRegions)
        ];
        ProcessEvent(GetFunction("SetSkeletalMeshDataInterfaceSamplingRegions"), @params);
    }
    public void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent* NiagaraSystem, FString OverrideName, UStaticMeshComponent* StaticMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("StaticMeshComponent", (IntPtr)StaticMeshComponent)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableStaticMeshComponent"), @params);
    }
    public void OverrideSystemUserVariableStaticMesh(UNiagaraComponent* NiagaraSystem, FString OverrideName, UStaticMesh* StaticMesh)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("StaticMesh", (IntPtr)StaticMesh)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableStaticMesh"), @params);
    }
    public void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent* NiagaraSystem, FString OverrideName, USkeletalMeshComponent* SkeletalMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("NiagaraSystem", (IntPtr)NiagaraSystem), 
            ("OverrideName", OverrideName), 
            ("SkeletalMeshComponent", (IntPtr)SkeletalMeshComponent)
        ];
        ProcessEvent(GetFunction("OverrideSystemUserVariableSkeletalMeshComponent"), @params);
    }
    public UNiagaraParameterCollectionInstance* GetNiagaraParameterCollection(UObject* WorldContextObject, UNiagaraParameterCollection* Collection)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Collection", (IntPtr)Collection)
        ];
        return (UNiagaraParameterCollectionInstance*)ProcessEvent<IntPtr>(GetFunction("GetNiagaraParameterCollection"), @params);
    }
}

public unsafe class NiagaraLightRendererProperties : ObjectBase<UNiagaraLightRendererProperties>
{
    public NiagaraLightRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraMeshRendererProperties : ObjectBase<UNiagaraMeshRendererProperties>
{
    public NiagaraMeshRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraMessageDataBase : ObjectBase<UNiagaraMessageDataBase>
{
    public NiagaraMessageDataBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraParameterCollectionInstance : ObjectBase<UNiagaraParameterCollectionInstance>
{
    public NiagaraParameterCollectionInstance(IntPtr pointer) : base(pointer) {}
    public void SetVectorParameter(FString InVariableName, FVector inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVectorParameter"), @params);
    }
    public void SetVector4Parameter(FString InVariableName, ref FVector4 inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVector4Parameter"), @params);
    }
    public void SetVector2DParameter(FString InVariableName, FVector2D inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetVector2DParameter"), @params);
    }
    public void SetQuatParameter(FString InVariableName, ref FQuat inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetQuatParameter"), @params);
    }
    public void SetIntParameter(FString InVariableName, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetIntParameter"), @params);
    }
    public void SetFloatParameter(FString InVariableName, float inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetFloatParameter"), @params);
    }
    public void SetColorParameter(FString InVariableName, FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetColorParameter"), @params);
    }
    public void SetBoolParameter(FString InVariableName, bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetBoolParameter"), @params);
    }
    public FVector GetVectorParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector>(GetFunction("GetVectorParameter"), @params);
    }
    public FVector4 GetVector4Parameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector4>(GetFunction("GetVector4Parameter"), @params);
    }
    public FVector2D GetVector2DParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetVector2DParameter"), @params);
    }
    public FQuat GetQuatParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FQuat>(GetFunction("GetQuatParameter"), @params);
    }
    public int GetIntParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<int>(GetFunction("GetIntParameter"), @params);
    }
    public float GetFloatParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<float>(GetFunction("GetFloatParameter"), @params);
    }
    public FLinearColor GetColorParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetColorParameter"), @params);
    }
    public bool GetBoolParameter(FString InVariableName)
    {
        Span<(string name, object value)> @params = [
            ("InVariableName", InVariableName)
        ];
        return ProcessEvent<bool>(GetFunction("GetBoolParameter"), @params);
    }
}

public unsafe class NiagaraParameterCollection : ObjectBase<UNiagaraParameterCollection>
{
    public NiagaraParameterCollection(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraParameterDefinitionsBase : ObjectBase<UNiagaraParameterDefinitionsBase>
{
    public NiagaraParameterDefinitionsBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraBaselineController_Basic : ObjectBase<UNiagaraBaselineController_Basic>
{
    public NiagaraBaselineController_Basic(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPerfBaselineActor : ObjectBase<ANiagaraPerfBaselineActor>
{
    public NiagaraPerfBaselineActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPrecompileContainer : ObjectBase<UNiagaraPrecompileContainer>
{
    public NiagaraPrecompileContainer(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewBase : ObjectBase<ANiagaraPreviewBase>
{
    public NiagaraPreviewBase(IntPtr pointer) : base(pointer) {}
    public void SetSystem(UNiagaraSystem* InSystem)
    {
        Span<(string name, object value)> @params = [
            ("InSystem", (IntPtr)InSystem)
        ];
        ProcessEvent(GetFunction("SetSystem"), @params);
    }
    public void SetLabelText(ref FText InXAxisText, ref FText InYAxisText)
    {
        Span<(string name, object value)> @params = [
            ("InXAxisText", InXAxisText), 
            ("InYAxisText", InYAxisText)
        ];
        ProcessEvent(GetFunction("SetLabelText"), @params);
    }
}

public unsafe class NiagaraPreviewAxis : ObjectBase<UNiagaraPreviewAxis>
{
    public NiagaraPreviewAxis(IntPtr pointer) : base(pointer) {}
    public int Num()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("Num"), @params);
    }
    public void ApplyToPreview(UNiagaraComponent* PreviewComponent, int PreviewIndex, bool bIsXAxis, ref FString OutLabelText)
    {
        Span<(string name, object value)> @params = [
            ("PreviewComponent", (IntPtr)PreviewComponent), 
            ("PreviewIndex", PreviewIndex), 
            ("bIsXAxis", bIsXAxis), 
            ("OutLabelText", OutLabelText)
        ];
        ProcessEvent(GetFunction("ApplyToPreview"), @params);
    }
}

public unsafe class NiagaraPreviewAxis_InterpParamBase : ObjectBase<UNiagaraPreviewAxis_InterpParamBase>
{
    public NiagaraPreviewAxis_InterpParamBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamInt32 : ObjectBase<UNiagaraPreviewAxis_InterpParamInt32>
{
    public NiagaraPreviewAxis_InterpParamInt32(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamFloat : ObjectBase<UNiagaraPreviewAxis_InterpParamFloat>
{
    public NiagaraPreviewAxis_InterpParamFloat(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamVector2D : ObjectBase<UNiagaraPreviewAxis_InterpParamVector2D>
{
    public NiagaraPreviewAxis_InterpParamVector2D(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamVector : ObjectBase<UNiagaraPreviewAxis_InterpParamVector>
{
    public NiagaraPreviewAxis_InterpParamVector(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamVector4 : ObjectBase<UNiagaraPreviewAxis_InterpParamVector4>
{
    public NiagaraPreviewAxis_InterpParamVector4(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewAxis_InterpParamLinearColor : ObjectBase<UNiagaraPreviewAxis_InterpParamLinearColor>
{
    public NiagaraPreviewAxis_InterpParamLinearColor(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraPreviewGrid : ObjectBase<ANiagaraPreviewGrid>
{
    public NiagaraPreviewGrid(IntPtr pointer) : base(pointer) {}
    public void SetPaused(bool bPaused)
    {
        Span<(string name, object value)> @params = [
            ("bPaused", bPaused)
        ];
        ProcessEvent(GetFunction("SetPaused"), @params);
    }
    public void GetPreviews(ref TArray<IntPtr> OutPreviews)
    {
        Span<(string name, object value)> @params = [
            ("OutPreviews", OutPreviews)
        ];
        ProcessEvent(GetFunction("GetPreviews"), @params);
    }
    public void DeactivatePreviews()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeactivatePreviews"), @params);
    }
    public void ActivatePreviews(bool bReset)
    {
        Span<(string name, object value)> @params = [
            ("bReset", bReset)
        ];
        ProcessEvent(GetFunction("ActivatePreviews"), @params);
    }
}

public unsafe class NiagaraRibbonRendererProperties : ObjectBase<UNiagaraRibbonRendererProperties>
{
    public NiagaraRibbonRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraScript : ObjectBase<UNiagaraScript>
{
    public NiagaraScript(IntPtr pointer) : base(pointer) {}
    public void RaiseOnGPUCompilationComplete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RaiseOnGPUCompilationComplete"), @params);
    }
}

public unsafe class NiagaraScriptSourceBase : ObjectBase<UNiagaraScriptSourceBase>
{
    public NiagaraScriptSourceBase(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraSettings : ObjectBase<UNiagaraSettings>
{
    public NiagaraSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraSimulationStageBase : ObjectBase<UNiagaraSimulationStageBase>
{
    public NiagaraSimulationStageBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraSimulationStageGeneric : ObjectBase<UNiagaraSimulationStageGeneric>
{
    public NiagaraSimulationStageGeneric(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraSpriteRendererProperties : ObjectBase<UNiagaraSpriteRendererProperties>
{
    public NiagaraSpriteRendererProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraSystem : ObjectBase<UNiagaraSystem>
{
    public NiagaraSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraDataInterfaceAudioSubmix : ObjectBase<UNiagaraDataInterfaceAudioSubmix>
{
    public NiagaraDataInterfaceAudioSubmix(IntPtr pointer) : base(pointer) {}
}

public unsafe class NiagaraBaselineController : ObjectBase<UNiagaraBaselineController>
{
    public NiagaraBaselineController(IntPtr pointer) : base(pointer) {}
    public bool OnTickTest()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnTickTest"), @params);
    }
    public void OnOwnerTick(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("OnOwnerTick"), @params);
    }
    public void OnEndTest(FNiagaraPerfBaselineStats Stats)
    {
        Span<(string name, object value)> @params = [
            ("Stats", Stats)
        ];
        ProcessEvent(GetFunction("OnEndTest"), @params);
    }
    public void OnBeginTest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBeginTest"), @params);
    }
    public UNiagaraSystem* GetSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraSystem*)ProcessEvent<IntPtr>(GetFunction("GetSystem"), @params);
    }
}

