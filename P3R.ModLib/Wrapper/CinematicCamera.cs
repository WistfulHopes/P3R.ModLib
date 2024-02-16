using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class CameraRig_Crane : ObjectBase<ACameraRig_Crane>
{

}

public unsafe class CameraRig_Rail : ObjectBase<ACameraRig_Rail>
{

    public USplineComponent* GetRailSplineComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USplineComponent*)ProcessEvent<IntPtr>(GetFunction("GetRailSplineComponent"),  @params);
    }
}

public unsafe class CineCameraActor : ObjectBase<ACineCameraActor>
{

    public UCineCameraComponent* GetCineCameraComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCineCameraComponent*)ProcessEvent<IntPtr>(GetFunction("GetCineCameraComponent"),  @params);
    }
}

public unsafe class NamedLensPreset : ObjectBase<FNamedLensPreset>
{

}

public unsafe class NamedFilmbackPreset : ObjectBase<FNamedFilmbackPreset>
{

}

public unsafe class CineCameraComponent : ObjectBase<UCineCameraComponent>
{

    public void SetLensPresetByName(FString InPresetName)
    {
        Span<(string name, object value)> @params = [
            ("InPresetName", InPresetName)
        ];
        ProcessEvent(GetFunction("SetLensPresetByName"),  @params);
    }
    public void SetFilmbackPresetByName(FString InPresetName)
    {
        Span<(string name, object value)> @params = [
            ("InPresetName", InPresetName)
        ];
        ProcessEvent(GetFunction("SetFilmbackPresetByName"),  @params);
    }
    public void SetCurrentFocalLength(float InFocalLength)
    {
        Span<(string name, object value)> @params = [
            ("InFocalLength", InFocalLength)
        ];
        ProcessEvent(GetFunction("SetCurrentFocalLength"),  @params);
    }
    public float GetVerticalFieldOfView()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetVerticalFieldOfView"),  @params);
    }
    public TArray<FNamedLensPreset> GetLensPresetsCopy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FNamedLensPreset>>(GetFunction("GetLensPresetsCopy"),  @params);
    }
    public FString GetLensPresetName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetLensPresetName"),  @params);
    }
    public float GetHorizontalFieldOfView()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetHorizontalFieldOfView"),  @params);
    }
    public TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FNamedFilmbackPreset>>(GetFunction("GetFilmbackPresetsCopy"),  @params);
    }
    public FString GetFilmbackPresetName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetFilmbackPresetName"),  @params);
    }
    public FString GetDefaultFilmbackPresetName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDefaultFilmbackPresetName"),  @params);
    }
}

public unsafe class CameraLookatTrackingSettings : ObjectBase<FCameraLookatTrackingSettings>
{

}

public unsafe class CameraFocusSettings : ObjectBase<FCameraFocusSettings>
{

}

public unsafe class CameraTrackingFocusSettings : ObjectBase<FCameraTrackingFocusSettings>
{

}

public unsafe class CameraLensSettings : ObjectBase<FCameraLensSettings>
{

}

public unsafe class CameraFilmbackSettings : ObjectBase<FCameraFilmbackSettings>
{

}

