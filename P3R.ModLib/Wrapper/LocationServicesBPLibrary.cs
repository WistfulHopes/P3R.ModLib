using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class LocationServicesData : ObjectBase<FLocationServicesData>
{

}

public unsafe class LocationServices : ObjectBase<ULocationServices>
{

    public bool StopLocationServices()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StopLocationServices"),  @params);
    }
    public bool StartLocationServices()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StartLocationServices"),  @params);
    }
    public bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy)
    {
        Span<(string name, object value)> @params = [
            ("Accuracy", Accuracy)
        ];
        return ProcessEvent<bool>(GetFunction("IsLocationAccuracyAvailable"),  @params);
    }
    public bool InitLocationServices(ELocationAccuracy Accuracy, float UpdateFrequency, float MinDistanceFilter)
    {
        Span<(string name, object value)> @params = [
            ("Accuracy", Accuracy), 
            ("UpdateFrequency", UpdateFrequency), 
            ("MinDistanceFilter", MinDistanceFilter)
        ];
        return ProcessEvent<bool>(GetFunction("InitLocationServices"),  @params);
    }
    public ULocationServicesImpl* GetLocationServicesImpl()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULocationServicesImpl*)ProcessEvent<IntPtr>(GetFunction("GetLocationServicesImpl"),  @params);
    }
    public FLocationServicesData GetLastKnownLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLocationServicesData>(GetFunction("GetLastKnownLocation"),  @params);
    }
    public bool AreLocationServicesEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("AreLocationServicesEnabled"),  @params);
    }
}

public unsafe class LocationServicesImpl : ObjectBase<ULocationServicesImpl>
{

}

