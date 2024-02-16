using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class FieldSystemActor : ObjectBase<AFieldSystemActor>
{

}

public unsafe class FieldSystem : ObjectBase<UFieldSystem>
{
}

public unsafe class FieldSystemComponent : ObjectBase<UFieldSystemComponent>
{

    public void ResetFieldSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetFieldSystem"),  @params);
    }
    public void RemovePersistentFields()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemovePersistentFields"),  @params);
    }
    public void ApplyUniformVectorFalloffForce(bool Enabled, FVector Position, FVector Direction, float Radius, float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Position", Position), 
            ("Direction", Direction), 
            ("Radius", Radius), 
            ("Magnitude", Magnitude)
        ];
        ProcessEvent(GetFunction("ApplyUniformVectorFalloffForce"),  @params);
    }
    public void ApplyStrainField(bool Enabled, FVector Position, float Radius, float Magnitude, int Iterations)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Position", Position), 
            ("Radius", Radius), 
            ("Magnitude", Magnitude), 
            ("Iterations", Iterations)
        ];
        ProcessEvent(GetFunction("ApplyStrainField"),  @params);
    }
    public void ApplyStayDynamicField(bool Enabled, FVector Position, float Radius)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Position", Position), 
            ("Radius", Radius)
        ];
        ProcessEvent(GetFunction("ApplyStayDynamicField"),  @params);
    }
    public void ApplyRadialVectorFalloffForce(bool Enabled, FVector Position, float Radius, float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Position", Position), 
            ("Radius", Radius), 
            ("Magnitude", Magnitude)
        ];
        ProcessEvent(GetFunction("ApplyRadialVectorFalloffForce"),  @params);
    }
    public void ApplyRadialForce(bool Enabled, FVector Position, float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Position", Position), 
            ("Magnitude", Magnitude)
        ];
        ProcessEvent(GetFunction("ApplyRadialForce"),  @params);
    }
    public void ApplyPhysicsField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData* MetaData, UFieldNodeBase* Field)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Target", Target), 
            ("MetaData", (IntPtr)MetaData), 
            ("Field", (IntPtr)Field)
        ];
        ProcessEvent(GetFunction("ApplyPhysicsField"),  @params);
    }
    public void ApplyLinearForce(bool Enabled, FVector Direction, float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Direction", Direction), 
            ("Magnitude", Magnitude)
        ];
        ProcessEvent(GetFunction("ApplyLinearForce"),  @params);
    }
    public void AddPersistentField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData* MetaData, UFieldNodeBase* Field)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Target", Target), 
            ("MetaData", (IntPtr)MetaData), 
            ("Field", (IntPtr)Field)
        ];
        ProcessEvent(GetFunction("AddPersistentField"),  @params);
    }
    public void AddFieldCommand(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData* MetaData, UFieldNodeBase* Field)
    {
        Span<(string name, object value)> @params = [
            ("Enabled", Enabled), 
            ("Target", Target), 
            ("MetaData", (IntPtr)MetaData), 
            ("Field", (IntPtr)Field)
        ];
        ProcessEvent(GetFunction("AddFieldCommand"),  @params);
    }
}

public unsafe class FieldSystemMetaData : ObjectBase<UFieldSystemMetaData>
{
}

public unsafe class FieldSystemMetaDataIteration : ObjectBase<UFieldSystemMetaDataIteration>
{

    public UFieldSystemMetaDataIteration* SetMetaDataIteration(int Iterations)
    {
        Span<(string name, object value)> @params = [
            ("Iterations", Iterations)
        ];
        return (UFieldSystemMetaDataIteration*)ProcessEvent<IntPtr>(GetFunction("SetMetaDataIteration"),  @params);
    }
}

public unsafe class FieldSystemMetaDataProcessingResolution : ObjectBase<UFieldSystemMetaDataProcessingResolution>
{

    public UFieldSystemMetaDataProcessingResolution* SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType)
    {
        Span<(string name, object value)> @params = [
            ("ResolutionType", ResolutionType)
        ];
        return (UFieldSystemMetaDataProcessingResolution*)ProcessEvent<IntPtr>(GetFunction("SetMetaDataaProcessingResolutionType"),  @params);
    }
}

public unsafe class FieldSystemMetaDataFilter : ObjectBase<UFieldSystemMetaDataFilter>
{

    public UFieldSystemMetaDataFilter* SetMetaDataFilterType(EFieldFilterType FilterType)
    {
        Span<(string name, object value)> @params = [
            ("FilterType", FilterType)
        ];
        return (UFieldSystemMetaDataFilter*)ProcessEvent<IntPtr>(GetFunction("SetMetaDataFilterType"),  @params);
    }
}

public unsafe class FieldNodeBase : ObjectBase<UFieldNodeBase>
{
}

public unsafe class FieldNodeInt : ObjectBase<UFieldNodeInt>
{
}

public unsafe class FieldNodeFloat : ObjectBase<UFieldNodeFloat>
{
}

public unsafe class FieldNodeVector : ObjectBase<UFieldNodeVector>
{
}

public unsafe class UniformInteger : ObjectBase<UUniformInteger>
{

    public UUniformInteger* SetUniformInteger(int Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude)
        ];
        return (UUniformInteger*)ProcessEvent<IntPtr>(GetFunction("SetUniformInteger"),  @params);
    }
}

public unsafe class RadialIntMask : ObjectBase<URadialIntMask>
{

    public URadialIntMask* SetRadialIntMask(float Radius, FVector Position, int InteriorValue, int ExteriorValue, ESetMaskConditionType SetMaskConditionIn)
    {
        Span<(string name, object value)> @params = [
            ("Radius", Radius), 
            ("Position", Position), 
            ("InteriorValue", InteriorValue), 
            ("ExteriorValue", ExteriorValue), 
            ("SetMaskConditionIn", SetMaskConditionIn)
        ];
        return (URadialIntMask*)ProcessEvent<IntPtr>(GetFunction("SetRadialIntMask"),  @params);
    }
}

public unsafe class UniformScalar : ObjectBase<UUniformScalar>
{

    public UUniformScalar* SetUniformScalar(float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude)
        ];
        return (UUniformScalar*)ProcessEvent<IntPtr>(GetFunction("SetUniformScalar"),  @params);
    }
}

public unsafe class WaveScalar : ObjectBase<UWaveScalar>
{

    public UWaveScalar* SetWaveScalar(float Magnitude, FVector Position, float Wavelength, float Period, float Time, EWaveFunctionType Function, EFieldFalloffType Falloff)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("Position", Position), 
            ("Wavelength", Wavelength), 
            ("Period", Period), 
            ("Time", Time), 
            ("Function", Function), 
            ("Falloff", Falloff)
        ];
        return (UWaveScalar*)ProcessEvent<IntPtr>(GetFunction("SetWaveScalar"),  @params);
    }
}

public unsafe class RadialFalloff : ObjectBase<URadialFalloff>
{

    public URadialFalloff* SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, FVector Position, EFieldFalloffType Falloff)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("MinRange", MinRange), 
            ("MaxRange", MaxRange), 
            ("Default", Default), 
            ("Radius", Radius), 
            ("Position", Position), 
            ("Falloff", Falloff)
        ];
        return (URadialFalloff*)ProcessEvent<IntPtr>(GetFunction("SetRadialFalloff"),  @params);
    }
}

public unsafe class PlaneFalloff : ObjectBase<UPlaneFalloff>
{

    public UPlaneFalloff* SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, FVector Position, FVector Normal, EFieldFalloffType Falloff)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("MinRange", MinRange), 
            ("MaxRange", MaxRange), 
            ("Default", Default), 
            ("Distance", Distance), 
            ("Position", Position), 
            ("Normal", Normal), 
            ("Falloff", Falloff)
        ];
        return (UPlaneFalloff*)ProcessEvent<IntPtr>(GetFunction("SetPlaneFalloff"),  @params);
    }
}

public unsafe class BoxFalloff : ObjectBase<UBoxFalloff>
{

    public UBoxFalloff* SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, FTransform Transform, EFieldFalloffType Falloff)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("MinRange", MinRange), 
            ("MaxRange", MaxRange), 
            ("Default", Default), 
            ("Transform", Transform), 
            ("Falloff", Falloff)
        ];
        return (UBoxFalloff*)ProcessEvent<IntPtr>(GetFunction("SetBoxFalloff"),  @params);
    }
}

public unsafe class NoiseField : ObjectBase<UNoiseField>
{

    public UNoiseField* SetNoiseField(float MinRange, float MaxRange, FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("MinRange", MinRange), 
            ("MaxRange", MaxRange), 
            ("Transform", Transform)
        ];
        return (UNoiseField*)ProcessEvent<IntPtr>(GetFunction("SetNoiseField"),  @params);
    }
}

public unsafe class UniformVector : ObjectBase<UUniformVector>
{

    public UUniformVector* SetUniformVector(float Magnitude, FVector Direction)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("Direction", Direction)
        ];
        return (UUniformVector*)ProcessEvent<IntPtr>(GetFunction("SetUniformVector"),  @params);
    }
}

public unsafe class RadialVector : ObjectBase<URadialVector>
{

    public URadialVector* SetRadialVector(float Magnitude, FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("Position", Position)
        ];
        return (URadialVector*)ProcessEvent<IntPtr>(GetFunction("SetRadialVector"),  @params);
    }
}

public unsafe class RandomVector : ObjectBase<URandomVector>
{

    public URandomVector* SetRandomVector(float Magnitude)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude)
        ];
        return (URandomVector*)ProcessEvent<IntPtr>(GetFunction("SetRandomVector"),  @params);
    }
}

public unsafe class OperatorField : ObjectBase<UOperatorField>
{

    public UOperatorField* SetOperatorField(float Magnitude, UFieldNodeBase* LeftField, UFieldNodeBase* RightField, EFieldOperationType Operation)
    {
        Span<(string name, object value)> @params = [
            ("Magnitude", Magnitude), 
            ("LeftField", (IntPtr)LeftField), 
            ("RightField", (IntPtr)RightField), 
            ("Operation", Operation)
        ];
        return (UOperatorField*)ProcessEvent<IntPtr>(GetFunction("SetOperatorField"),  @params);
    }
}

public unsafe class ToIntegerField : ObjectBase<UToIntegerField>
{

    public UToIntegerField* SetToIntegerField(UFieldNodeFloat* FloatField)
    {
        Span<(string name, object value)> @params = [
            ("FloatField", (IntPtr)FloatField)
        ];
        return (UToIntegerField*)ProcessEvent<IntPtr>(GetFunction("SetToIntegerField"),  @params);
    }
}

public unsafe class ToFloatField : ObjectBase<UToFloatField>
{

    public UToFloatField* SetToFloatField(UFieldNodeInt* IntegerField)
    {
        Span<(string name, object value)> @params = [
            ("IntegerField", (IntPtr)IntegerField)
        ];
        return (UToFloatField*)ProcessEvent<IntPtr>(GetFunction("SetToFloatField"),  @params);
    }
}

public unsafe class CullingField : ObjectBase<UCullingField>
{

    public UCullingField* SetCullingField(UFieldNodeBase* Culling, UFieldNodeBase* Field, EFieldCullingOperationType Operation)
    {
        Span<(string name, object value)> @params = [
            ("Culling", (IntPtr)Culling), 
            ("Field", (IntPtr)Field), 
            ("Operation", Operation)
        ];
        return (UCullingField*)ProcessEvent<IntPtr>(GetFunction("SetCullingField"),  @params);
    }
}

public unsafe class ReturnResultsTerminal : ObjectBase<UReturnResultsTerminal>
{

    public UReturnResultsTerminal* SetReturnResultsTerminal()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UReturnResultsTerminal*)ProcessEvent<IntPtr>(GetFunction("SetReturnResultsTerminal"),  @params);
    }
}

public unsafe class FieldObjectCommands : ObjectBase<FFieldObjectCommands>
{

}

