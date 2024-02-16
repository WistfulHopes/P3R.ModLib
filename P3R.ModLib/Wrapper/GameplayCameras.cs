using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MatineeCameraShake : ObjectBase<UMatineeCameraShake>
{

    public UMatineeCameraShake* StartMatineeCameraShakeFromSource(APlayerCameraManager* PlayerCameraManager, TSubclassOf<UMatineeCameraShake> ShakeClass, UCameraShakeSourceComponent* SourceComponent, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot)
    {
        Span<(string name, object value)> @params = [
            ("PlayerCameraManager", (IntPtr)PlayerCameraManager), 
            ("ShakeClass", ShakeClass), 
            ("SourceComponent", (IntPtr)SourceComponent), 
            ("Scale", Scale), 
            ("PlaySpace", PlaySpace), 
            ("UserPlaySpaceRot", UserPlaySpaceRot)
        ];
        return (UMatineeCameraShake*)ProcessEvent<IntPtr>(GetFunction("StartMatineeCameraShakeFromSource"),  @params);
    }
    public UMatineeCameraShake* StartMatineeCameraShake(APlayerCameraManager* PlayerCameraManager, TSubclassOf<UMatineeCameraShake> ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot)
    {
        Span<(string name, object value)> @params = [
            ("PlayerCameraManager", (IntPtr)PlayerCameraManager), 
            ("ShakeClass", ShakeClass), 
            ("Scale", Scale), 
            ("PlaySpace", PlaySpace), 
            ("UserPlaySpaceRot", UserPlaySpaceRot)
        ];
        return (UMatineeCameraShake*)ProcessEvent<IntPtr>(GetFunction("StartMatineeCameraShake"),  @params);
    }
    public void ReceiveStopShake(bool bImmediately)
    {
        Span<(string name, object value)> @params = [
            ("bImmediately", bImmediately)
        ];
        ProcessEvent(GetFunction("ReceiveStopShake"),  @params);
    }
    public void ReceivePlayShake(float Scale)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("ReceivePlayShake"),  @params);
    }
    public bool ReceiveIsFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ReceiveIsFinished"),  @params);
    }
    public void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, ref FMinimalViewInfo POV, ref FMinimalViewInfo ModifiedPOV)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("Alpha", Alpha), 
            ("POV", POV), 
            ("ModifiedPOV", ModifiedPOV)
        ];
        ProcessEvent(GetFunction("BlueprintUpdateCameraShake"),  @params);
    }
}

public unsafe class TestCameraShake : ObjectBase<UTestCameraShake>
{
}

public unsafe class SimpleCameraShakePattern : ObjectBase<USimpleCameraShakePattern>
{

}

public unsafe class ConstantCameraShakePattern : ObjectBase<UConstantCameraShakePattern>
{

}

public unsafe class CompositeCameraShakePattern : ObjectBase<UCompositeCameraShakePattern>
{

}

public unsafe class DefaultCameraShakeBase : ObjectBase<UDefaultCameraShakeBase>
{
}

public unsafe class MatineeCameraShakePattern : ObjectBase<UMatineeCameraShakePattern>
{
}

public unsafe class MovieSceneMatineeCameraShakeEvaluator : ObjectBase<UMovieSceneMatineeCameraShakeEvaluator>
{
}

public unsafe class MatineeCameraShakeFunctionLibrary : ObjectBase<UMatineeCameraShakeFunctionLibrary>
{

    public UMatineeCameraShake* Conv_MatineeCameraShake(UCameraShakeBase* CameraShake)
    {
        Span<(string name, object value)> @params = [
            ("CameraShake", (IntPtr)CameraShake)
        ];
        return (UMatineeCameraShake*)ProcessEvent<IntPtr>(GetFunction("Conv_MatineeCameraShake"),  @params);
    }
}

public unsafe class PerlinNoiseCameraShakePattern : ObjectBase<UPerlinNoiseCameraShakePattern>
{

}

public unsafe class WaveOscillatorCameraShakePattern : ObjectBase<UWaveOscillatorCameraShakePattern>
{

}

public unsafe class VOscillator : ObjectBase<FVOscillator>
{

}

public unsafe class FOscillator : ObjectBase<FFOscillator>
{

}

public unsafe class ROscillator : ObjectBase<FROscillator>
{

}

public unsafe class PerlinNoiseShaker : ObjectBase<FPerlinNoiseShaker>
{

}

public unsafe class WaveOscillator : ObjectBase<FWaveOscillator>
{

}

