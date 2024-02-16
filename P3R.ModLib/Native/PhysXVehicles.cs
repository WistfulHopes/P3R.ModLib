using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FWheelSetup
{
    [FieldOffset(0x0000)] public TSubclassOf<UVehicleWheel> WheelClass;
    [FieldOffset(0x0008)] public FName BoneName;
    [FieldOffset(0x0010)] public FVector AdditionalOffset;
    [FieldOffset(0x001C)] public bool bDisableSteering;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FReplicatedVehicleState
{
    [FieldOffset(0x0000)] public float SteeringInput;
    [FieldOffset(0x0004)] public float ThrottleInput;
    [FieldOffset(0x0008)] public float BrakeInput;
    [FieldOffset(0x000C)] public float HandbrakeInput;
    [FieldOffset(0x0010)] public int CurrentGear;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVehicleInputRate
{
    [FieldOffset(0x0000)] public float RiseRate;
    [FieldOffset(0x0004)] public float FallRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UWheeledVehicleMovementComponent
{
    [FieldOffset(0x0000)] public UPawnMovementComponent baseObj;
    [FieldOffset(0x0140)] public byte bDeprecatedSpringOffsetMode;
    [FieldOffset(0x0140)] public byte bReverseAsBrake;
    [FieldOffset(0x0140)] public byte bUseRVOAvoidance;
    [FieldOffset(0x0140)] public byte bRawHandbrakeInput;
    [FieldOffset(0x0140)] public byte bRawGearUpInput;
    [FieldOffset(0x0140)] public byte bRawGearDownInput;
    [FieldOffset(0x0144)] public byte bWasAvoidanceUpdated;
    [FieldOffset(0x0148)] public float Mass;
    [FieldOffset(0x0150)] public TArray<FWheelSetup> WheelSetups;
    [FieldOffset(0x0160)] public float DragCoefficient;
    [FieldOffset(0x0164)] public float ChassisWidth;
    [FieldOffset(0x0168)] public float ChassisHeight;
    [FieldOffset(0x016C)] public float DragArea;
    [FieldOffset(0x0170)] public float EstimatedMaxEngineSpeed;
    [FieldOffset(0x0174)] public float MaxEngineRPM;
    [FieldOffset(0x0178)] public float DebugDragMagnitude;
    [FieldOffset(0x017C)] public FVector InertiaTensorScale;
    [FieldOffset(0x0188)] public float MinNormalizedTireLoad;
    [FieldOffset(0x018C)] public float MinNormalizedTireLoadFiltered;
    [FieldOffset(0x0190)] public float MaxNormalizedTireLoad;
    [FieldOffset(0x0194)] public float MaxNormalizedTireLoadFiltered;
    [FieldOffset(0x0198)] public float ThresholdLongitudinalSpeed;
    [FieldOffset(0x019C)] public int LowForwardSpeedSubStepCount;
    [FieldOffset(0x01A0)] public int HighForwardSpeedSubStepCount;
    [FieldOffset(0x01A8)] public TArray<IntPtr> Wheels;
    [FieldOffset(0x01D0)] public float RVOAvoidanceRadius;
    [FieldOffset(0x01D4)] public float RVOAvoidanceHeight;
    [FieldOffset(0x01D8)] public float AvoidanceConsiderationRadius;
    [FieldOffset(0x01DC)] public float RVOSteeringStep;
    [FieldOffset(0x01E0)] public float RVOThrottleStep;
    [FieldOffset(0x01E4)] public int AvoidanceUID;
    [FieldOffset(0x01E8)] public FNavAvoidanceMask AvoidanceGroup;
    [FieldOffset(0x01EC)] public FNavAvoidanceMask GroupsToAvoid;
    [FieldOffset(0x01F0)] public FNavAvoidanceMask GroupsToIgnore;
    [FieldOffset(0x01F4)] public float AvoidanceWeight;
    [FieldOffset(0x01F8)] public FVector PendingLaunchVelocity;
    [FieldOffset(0x0204)] public FReplicatedVehicleState ReplicatedState;
    [FieldOffset(0x021C)] public float RawSteeringInput;
    [FieldOffset(0x0220)] public float RawThrottleInput;
    [FieldOffset(0x0224)] public float RawBrakeInput;
    [FieldOffset(0x0228)] public float SteeringInput;
    [FieldOffset(0x022C)] public float ThrottleInput;
    [FieldOffset(0x0230)] public float BrakeInput;
    [FieldOffset(0x0234)] public float HandbrakeInput;
    [FieldOffset(0x0238)] public float IdleBrakeInput;
    [FieldOffset(0x023C)] public float StopThreshold;
    [FieldOffset(0x0240)] public float WrongDirectionThreshold;
    [FieldOffset(0x0244)] public FVehicleInputRate ThrottleInputRate;
    [FieldOffset(0x024C)] public FVehicleInputRate BrakeInputRate;
    [FieldOffset(0x0254)] public FVehicleInputRate HandbrakeInputRate;
    [FieldOffset(0x025C)] public FVehicleInputRate SteeringInputRate;
    [FieldOffset(0x0288)] public AController* OverrideController;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct USimpleWheeledVehicleMovementComponent
{
    [FieldOffset(0x0000)] public UWheeledVehicleMovementComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTireConfigMaterialFriction
{
    [FieldOffset(0x0000)] public UPhysicalMaterial* PhysicalMaterial;
    [FieldOffset(0x0008)] public float FrictionScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UTireConfig
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public float FrictionScale;
    [FieldOffset(0x0038)] public TArray<FTireConfigMaterialFriction> TireFrictionScales;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA60)] 
public unsafe struct UVehicleAnimInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x0A50)] public UWheeledVehicleMovementComponent* WheeledVehicleMovementComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UVehicleWheel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UStaticMesh* CollisionMesh;
    [FieldOffset(0x0030)] public bool bDontCreateShape;
    [FieldOffset(0x0031)] public bool bAutoAdjustCollisionSize;
    [FieldOffset(0x0034)] public FVector Offset;
    [FieldOffset(0x0040)] public float ShapeRadius;
    [FieldOffset(0x0044)] public float ShapeWidth;
    [FieldOffset(0x0048)] public float Mass;
    [FieldOffset(0x004C)] public float DampingRate;
    [FieldOffset(0x0050)] public float SteerAngle;
    [FieldOffset(0x0054)] public bool bAffectedByHandbrake;
    [FieldOffset(0x0058)] public UTireType* TireType;
    [FieldOffset(0x0060)] public UTireConfig* TireConfig;
    [FieldOffset(0x0068)] public float LatStiffMaxLoad;
    [FieldOffset(0x006C)] public float LatStiffValue;
    [FieldOffset(0x0070)] public float LongStiffValue;
    [FieldOffset(0x0074)] public float SuspensionForceOffset;
    [FieldOffset(0x0078)] public float SuspensionMaxRaise;
    [FieldOffset(0x007C)] public float SuspensionMaxDrop;
    [FieldOffset(0x0080)] public float SuspensionNaturalFrequency;
    [FieldOffset(0x0084)] public float SuspensionDampingRatio;
    [FieldOffset(0x0088)] public EWheelSweepType SweepType;
    [FieldOffset(0x008C)] public float MaxBrakeTorque;
    [FieldOffset(0x0090)] public float MaxHandBrakeTorque;
    [FieldOffset(0x0098)] public UWheeledVehicleMovementComponent* VehicleSim;
    [FieldOffset(0x00A0)] public int WheelIndex;
    [FieldOffset(0x00A4)] public float DebugLongSlip;
    [FieldOffset(0x00A8)] public float DebugLatSlip;
    [FieldOffset(0x00AC)] public float DebugNormalizedTireLoad;
    [FieldOffset(0x00B4)] public float DebugWheelTorque;
    [FieldOffset(0x00B8)] public float DebugLongForce;
    [FieldOffset(0x00BC)] public float DebugLatForce;
    [FieldOffset(0x00C0)] public FVector Location;
    [FieldOffset(0x00CC)] public FVector OldLocation;
    [FieldOffset(0x00D8)] public FVector Velocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AWheeledVehicle
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public USkeletalMeshComponent* Mesh;
    [FieldOffset(0x0288)] public UWheeledVehicleMovementComponent* VehicleMovement;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FVehicleEngineData
{
    [FieldOffset(0x0000)] public FRuntimeFloatCurve TorqueCurve;
    [FieldOffset(0x0088)] public float MaxRPM;
    [FieldOffset(0x008C)] public float MOI;
    [FieldOffset(0x0090)] public float DampingRateFullThrottle;
    [FieldOffset(0x0094)] public float DampingRateZeroThrottleClutchEngaged;
    [FieldOffset(0x0098)] public float DampingRateZeroThrottleClutchDisengaged;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FVehicleDifferential4WData
{
    [FieldOffset(0x0000)] public EVehicleDifferential4W DifferentialType;
    [FieldOffset(0x0004)] public float FrontRearSplit;
    [FieldOffset(0x0008)] public float FrontLeftRightSplit;
    [FieldOffset(0x000C)] public float RearLeftRightSplit;
    [FieldOffset(0x0010)] public float CentreBias;
    [FieldOffset(0x0014)] public float FrontBias;
    [FieldOffset(0x0018)] public float RearBias;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVehicleGearData
{
    [FieldOffset(0x0000)] public float Ratio;
    [FieldOffset(0x0004)] public float DownRatio;
    [FieldOffset(0x0008)] public float UpRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FVehicleTransmissionData
{
    [FieldOffset(0x0000)] public bool bUseGearAutoBox;
    [FieldOffset(0x0004)] public float GearSwitchTime;
    [FieldOffset(0x0008)] public float GearAutoBoxLatency;
    [FieldOffset(0x000C)] public float FinalRatio;
    [FieldOffset(0x0010)] public TArray<FVehicleGearData> ForwardGears;
    [FieldOffset(0x0020)] public float ReverseGearRatio;
    [FieldOffset(0x0024)] public float NeutralGearUpRatio;
    [FieldOffset(0x0028)] public float ClutchStrength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x408)] 
public unsafe struct UWheeledVehicleMovementComponent4W
{
    [FieldOffset(0x0000)] public UWheeledVehicleMovementComponent baseObj;
    [FieldOffset(0x0290)] public FVehicleEngineData EngineSetup;
    [FieldOffset(0x0330)] public FVehicleDifferential4WData DifferentialSetup;
    [FieldOffset(0x034C)] public float AckermannAccuracy;
    [FieldOffset(0x0350)] public FVehicleTransmissionData TransmissionSetup;
    [FieldOffset(0x0380)] public FRuntimeFloatCurve SteeringCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FAnimNode_WheelHandler
{
    [FieldOffset(0x0000)] public FAnimNode_SkeletalControlBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x780)] 
public unsafe struct FVehicleAnimInstanceProxy
{
    [FieldOffset(0x0000)] public FAnimInstanceProxy baseObj;
}

