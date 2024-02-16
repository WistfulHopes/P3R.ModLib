using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class WheeledVehicleMovementComponent : ObjectBase<UWheeledVehicleMovementComponent>
{

    public void SetUseAutoGears(bool bUseAuto)
    {
        Span<(string name, object value)> @params = [
            ("bUseAuto", bUseAuto)
        ];
        ProcessEvent(GetFunction("SetUseAutoGears"),  @params);
    }
    public void SetThrottleInput(float Throttle)
    {
        Span<(string name, object value)> @params = [
            ("Throttle", Throttle)
        ];
        ProcessEvent(GetFunction("SetThrottleInput"),  @params);
    }
    public void SetTargetGear(int GearNum, bool bImmediate)
    {
        Span<(string name, object value)> @params = [
            ("GearNum", GearNum), 
            ("bImmediate", bImmediate)
        ];
        ProcessEvent(GetFunction("SetTargetGear"),  @params);
    }
    public void SetSteeringInput(float Steering)
    {
        Span<(string name, object value)> @params = [
            ("Steering", Steering)
        ];
        ProcessEvent(GetFunction("SetSteeringInput"),  @params);
    }
    public void SetHandbrakeInput(bool bNewHandbrake)
    {
        Span<(string name, object value)> @params = [
            ("bNewHandbrake", bNewHandbrake)
        ];
        ProcessEvent(GetFunction("SetHandbrakeInput"),  @params);
    }
    public void SetGroupsToIgnoreMask(ref FNavAvoidanceMask GroupMask)
    {
        Span<(string name, object value)> @params = [
            ("GroupMask", GroupMask)
        ];
        ProcessEvent(GetFunction("SetGroupsToIgnoreMask"),  @params);
    }
    public void SetGroupsToIgnore(int GroupFlags)
    {
        Span<(string name, object value)> @params = [
            ("GroupFlags", GroupFlags)
        ];
        ProcessEvent(GetFunction("SetGroupsToIgnore"),  @params);
    }
    public void SetGroupsToAvoidMask(ref FNavAvoidanceMask GroupMask)
    {
        Span<(string name, object value)> @params = [
            ("GroupMask", GroupMask)
        ];
        ProcessEvent(GetFunction("SetGroupsToAvoidMask"),  @params);
    }
    public void SetGroupsToAvoid(int GroupFlags)
    {
        Span<(string name, object value)> @params = [
            ("GroupFlags", GroupFlags)
        ];
        ProcessEvent(GetFunction("SetGroupsToAvoid"),  @params);
    }
    public void SetGearUp(bool bNewGearUp)
    {
        Span<(string name, object value)> @params = [
            ("bNewGearUp", bNewGearUp)
        ];
        ProcessEvent(GetFunction("SetGearUp"),  @params);
    }
    public void SetGearDown(bool bNewGearDown)
    {
        Span<(string name, object value)> @params = [
            ("bNewGearDown", bNewGearDown)
        ];
        ProcessEvent(GetFunction("SetGearDown"),  @params);
    }
    public void SetBrakeInput(float Brake)
    {
        Span<(string name, object value)> @params = [
            ("Brake", Brake)
        ];
        ProcessEvent(GetFunction("SetBrakeInput"),  @params);
    }
    public void SetAvoidanceGroupMask(ref FNavAvoidanceMask GroupMask)
    {
        Span<(string name, object value)> @params = [
            ("GroupMask", GroupMask)
        ];
        ProcessEvent(GetFunction("SetAvoidanceGroupMask"),  @params);
    }
    public void SetAvoidanceGroup(int GroupFlags)
    {
        Span<(string name, object value)> @params = [
            ("GroupFlags", GroupFlags)
        ];
        ProcessEvent(GetFunction("SetAvoidanceGroup"),  @params);
    }
    public void SetAvoidanceEnabled(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetAvoidanceEnabled"),  @params);
    }
    public void ServerUpdateState(float InSteeringInput, float InThrottleInput, float InBrakeInput, float InHandbrakeInput, int CurrentGear)
    {
        Span<(string name, object value)> @params = [
            ("InSteeringInput", InSteeringInput), 
            ("InThrottleInput", InThrottleInput), 
            ("InBrakeInput", InBrakeInput), 
            ("InHandbrakeInput", InHandbrakeInput), 
            ("CurrentGear", CurrentGear)
        ];
        ProcessEvent(GetFunction("ServerUpdateState"),  @params);
    }
    public bool GetUseAutoGears()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetUseAutoGears"),  @params);
    }
    public int GetTargetGear()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetTargetGear"),  @params);
    }
    public float GetForwardSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetForwardSpeed"),  @params);
    }
    public float GetEngineRotationSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEngineRotationSpeed"),  @params);
    }
    public float GetEngineMaxRotationSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEngineMaxRotationSpeed"),  @params);
    }
    public int GetCurrentGear()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCurrentGear"),  @params);
    }
}

public unsafe class SimpleWheeledVehicleMovementComponent : ObjectBase<USimpleWheeledVehicleMovementComponent>
{

    public void SetSteerAngle(float SteerAngle, int WheelIndex)
    {
        Span<(string name, object value)> @params = [
            ("SteerAngle", SteerAngle), 
            ("WheelIndex", WheelIndex)
        ];
        ProcessEvent(GetFunction("SetSteerAngle"),  @params);
    }
    public void SetDriveTorque(float DriveTorque, int WheelIndex)
    {
        Span<(string name, object value)> @params = [
            ("DriveTorque", DriveTorque), 
            ("WheelIndex", WheelIndex)
        ];
        ProcessEvent(GetFunction("SetDriveTorque"),  @params);
    }
    public void SetBrakeTorque(float BrakeTorque, int WheelIndex)
    {
        Span<(string name, object value)> @params = [
            ("BrakeTorque", BrakeTorque), 
            ("WheelIndex", WheelIndex)
        ];
        ProcessEvent(GetFunction("SetBrakeTorque"),  @params);
    }
}

public unsafe class TireConfig : ObjectBase<UTireConfig>
{

}

public unsafe class VehicleAnimInstance : ObjectBase<UVehicleAnimInstance>
{

    public AWheeledVehicle* GetVehicle()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AWheeledVehicle*)ProcessEvent<IntPtr>(GetFunction("GetVehicle"),  @params);
    }
}

public unsafe class VehicleWheel : ObjectBase<UVehicleWheel>
{

    public bool IsInAir()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInAir"),  @params);
    }
    public float GetSuspensionOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSuspensionOffset"),  @params);
    }
    public float GetSteerAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSteerAngle"),  @params);
    }
    public float GetRotationAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRotationAngle"),  @params);
    }
}

public unsafe class WheeledVehicle : ObjectBase<AWheeledVehicle>
{

}

public unsafe class WheeledVehicleMovementComponent4W : ObjectBase<UWheeledVehicleMovementComponent4W>
{

}

public unsafe class AnimNode_WheelHandler : ObjectBase<FAnimNode_WheelHandler>
{
}

public unsafe class TireConfigMaterialFriction : ObjectBase<FTireConfigMaterialFriction>
{

}

public unsafe class VehicleAnimInstanceProxy : ObjectBase<FVehicleAnimInstanceProxy>
{
}

public unsafe class VehicleInputRate : ObjectBase<FVehicleInputRate>
{

}

public unsafe class ReplicatedVehicleState : ObjectBase<FReplicatedVehicleState>
{

}

public unsafe class WheelSetup : ObjectBase<FWheelSetup>
{

}

public unsafe class VehicleTransmissionData : ObjectBase<FVehicleTransmissionData>
{

}

public unsafe class VehicleGearData : ObjectBase<FVehicleGearData>
{

}

public unsafe class VehicleEngineData : ObjectBase<FVehicleEngineData>
{

}

public unsafe class VehicleDifferential4WData : ObjectBase<FVehicleDifferential4WData>
{

}

