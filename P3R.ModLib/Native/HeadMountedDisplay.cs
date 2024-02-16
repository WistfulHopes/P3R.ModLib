using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FXRDeviceId
{
    [FieldOffset(0x0000)] public FName SystemName;
    [FieldOffset(0x0008)] public int DeviceID;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FXRMotionControllerData
{
    [FieldOffset(0x0000)] public bool bValid;
    [FieldOffset(0x0004)] public FName DeviceName;
    [FieldOffset(0x000C)] public FGuid ApplicationInstanceID;
    [FieldOffset(0x001C)] public EXRVisualType DeviceVisualType;
    [FieldOffset(0x001D)] public EControllerHand HandIndex;
    [FieldOffset(0x001E)] public ETrackingStatus TrackingStatus;
    [FieldOffset(0x0020)] public FVector GripPosition;
    [FieldOffset(0x0030)] public FQuat GripRotation;
    [FieldOffset(0x0040)] public FVector AimPosition;
    [FieldOffset(0x0050)] public FQuat AimRotation;
    [FieldOffset(0x0060)] public TArray<FVector> HandKeyPositions;
    [FieldOffset(0x0070)] public TArray<FQuat> HandKeyRotations;
    [FieldOffset(0x0080)] public TArray<float> HandKeyRadii;
    [FieldOffset(0x0090)] public bool bIsGrasped;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FXRHMDData
{
    [FieldOffset(0x0000)] public bool bValid;
    [FieldOffset(0x0004)] public FName DeviceName;
    [FieldOffset(0x000C)] public FGuid ApplicationInstanceID;
    [FieldOffset(0x001C)] public ETrackingStatus TrackingStatus;
    [FieldOffset(0x0020)] public FVector Position;
    [FieldOffset(0x0030)] public FQuat Rotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6)] 
public unsafe struct FXRGestureConfig
{
    [FieldOffset(0x0000)] public bool bTap;
    [FieldOffset(0x0001)] public bool bHold;
    [FieldOffset(0x0002)] public ESpatialInputGestureAxis AxisGesture;
    [FieldOffset(0x0003)] public bool bNavigationAxisX;
    [FieldOffset(0x0004)] public bool bNavigationAxisY;
    [FieldOffset(0x0005)] public bool bNavigationAxisZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHeadMountedDisplayFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHandKeypointConversion
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct UMotionControllerComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public int PlayerIndex;
    [FieldOffset(0x0454)] public EControllerHand Hand;
    [FieldOffset(0x0458)] public FName MotionSource;
    [FieldOffset(0x0460)] public byte bDisableLowLatencyUpdate;
    [FieldOffset(0x0464)] public ETrackingStatus CurrentTrackingStatus;
    [FieldOffset(0x0465)] public bool bDisplayDeviceModel;
    [FieldOffset(0x0468)] public FName DisplayModelSource;
    [FieldOffset(0x0470)] public UStaticMesh* CustomDisplayMesh;
    [FieldOffset(0x0478)] public TArray<IntPtr> DisplayMeshMaterialOverrides;
    [FieldOffset(0x04F0)] public UPrimitiveComponent* DisplayComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMotionTrackedDeviceFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UVRNotificationsComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UXRAssetFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAsyncTask_LoadXRDeviceVisComponent
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
    [FieldOffset(0x0058)] public UPrimitiveComponent* SpawnedComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UXRLoadingScreenFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

