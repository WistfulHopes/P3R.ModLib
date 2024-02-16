using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class XRDeviceId : ObjectBase<FXRDeviceId>
{

}

public unsafe class XRMotionControllerData : ObjectBase<FXRMotionControllerData>
{

}

public unsafe class XRHMDData : ObjectBase<FXRHMDData>
{

}

public unsafe class XRGestureConfig : ObjectBase<FXRGestureConfig>
{

}

public unsafe class HeadMountedDisplayFunctionLibrary : ObjectBase<UHeadMountedDisplayFunctionLibrary>
{

    public void UpdateExternalTrackingHMDPosition(ref FTransform ExternalTrackingTransform)
    {
        Span<(string name, object value)> @params = [
            ("ExternalTrackingTransform", ExternalTrackingTransform)
        ];
        ProcessEvent(GetFunction("UpdateExternalTrackingHMDPosition"),  @params);
    }
    public void SetWorldToMetersScale(UObject* WorldContext, float NewScale)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext), 
            ("NewScale", NewScale)
        ];
        ProcessEvent(GetFunction("SetWorldToMetersScale"),  @params);
    }
    public void SetTrackingOrigin(EHMDTrackingOrigin Origin)
    {
        Span<(string name, object value)> @params = [
            ("Origin", Origin)
        ];
        ProcessEvent(GetFunction("SetTrackingOrigin"),  @params);
    }
    public void SetSpectatorScreenTexture(UTexture* inTexture)
    {
        Span<(string name, object value)> @params = [
            ("inTexture", (IntPtr)inTexture)
        ];
        ProcessEvent(GetFunction("SetSpectatorScreenTexture"),  @params);
    }
    public void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin, FVector2D EyeRectMax, FVector2D TextureRectMin, FVector2D TextureRectMax, bool bDrawEyeFirst, bool bClearBlack, bool bUseAlpha)
    {
        Span<(string name, object value)> @params = [
            ("EyeRectMin", EyeRectMin), 
            ("EyeRectMax", EyeRectMax), 
            ("TextureRectMin", TextureRectMin), 
            ("TextureRectMax", TextureRectMax), 
            ("bDrawEyeFirst", bDrawEyeFirst), 
            ("bClearBlack", bClearBlack), 
            ("bUseAlpha", bUseAlpha)
        ];
        ProcessEvent(GetFunction("SetSpectatorScreenModeTexturePlusEyeLayout"),  @params);
    }
    public void SetSpectatorScreenMode(ESpectatorScreenMode Mode)
    {
        Span<(string name, object value)> @params = [
            ("Mode", Mode)
        ];
        ProcessEvent(GetFunction("SetSpectatorScreenMode"),  @params);
    }
    public void SetClippingPlanes(float Near, float Far)
    {
        Span<(string name, object value)> @params = [
            ("Near", Near), 
            ("Far", Far)
        ];
        ProcessEvent(GetFunction("SetClippingPlanes"),  @params);
    }
    public void ResetOrientationAndPosition(float Yaw, EOrientPositionSelector Options)
    {
        Span<(string name, object value)> @params = [
            ("Yaw", Yaw), 
            ("Options", Options)
        ];
        ProcessEvent(GetFunction("ResetOrientationAndPosition"),  @params);
    }
    public bool IsSpectatorScreenModeControllable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSpectatorScreenModeControllable"),  @params);
    }
    public bool IsInLowPersistenceMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInLowPersistenceMode"),  @params);
    }
    public bool IsHeadMountedDisplayEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsHeadMountedDisplayEnabled"),  @params);
    }
    public bool IsHeadMountedDisplayConnected()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsHeadMountedDisplayConnected"),  @params);
    }
    public bool IsDeviceTracking(ref FXRDeviceId XRDeviceId)
    {
        Span<(string name, object value)> @params = [
            ("XRDeviceId", XRDeviceId)
        ];
        return ProcessEvent<bool>(GetFunction("IsDeviceTracking"),  @params);
    }
    public bool HasValidTrackingPosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasValidTrackingPosition"),  @params);
    }
    public int GetXRSystemFlags()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetXRSystemFlags"),  @params);
    }
    public float GetWorldToMetersScale(UObject* WorldContext)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext)
        ];
        return ProcessEvent<float>(GetFunction("GetWorldToMetersScale"),  @params);
    }
    public void GetVRFocusState(ref bool bUseFocus, ref bool bHasFocus)
    {
        Span<(string name, object value)> @params = [
            ("bUseFocus", bUseFocus), 
            ("bHasFocus", bHasFocus)
        ];
        ProcessEvent(GetFunction("GetVRFocusState"),  @params);
    }
    public FString GetVersionString()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetVersionString"),  @params);
    }
    public FTransform GetTrackingToWorldTransform(UObject* WorldContext)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetTrackingToWorldTransform"),  @params);
    }
    public void GetTrackingSensorParameters(ref FVector Origin, ref FRotator Rotation, ref float LeftFOV, ref float RightFOV, ref float TopFOV, ref float BottomFOV, ref float Distance, ref float NearPlane, ref float FarPlane, ref bool IsActive, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Origin", Origin), 
            ("Rotation", Rotation), 
            ("LeftFOV", LeftFOV), 
            ("RightFOV", RightFOV), 
            ("TopFOV", TopFOV), 
            ("BottomFOV", BottomFOV), 
            ("Distance", Distance), 
            ("NearPlane", NearPlane), 
            ("FarPlane", FarPlane), 
            ("IsActive", IsActive), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("GetTrackingSensorParameters"),  @params);
    }
    public EHMDTrackingOrigin GetTrackingOrigin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EHMDTrackingOrigin>(GetFunction("GetTrackingOrigin"),  @params);
    }
    public float GetScreenPercentage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetScreenPercentage"),  @params);
    }
    public void GetPositionalTrackingCameraParameters(ref FVector CameraOrigin, ref FRotator CameraRotation, ref float HFOV, ref float VFOV, ref float CameraDistance, ref float NearPlane, ref float FarPlane)
    {
        Span<(string name, object value)> @params = [
            ("CameraOrigin", CameraOrigin), 
            ("CameraRotation", CameraRotation), 
            ("HFOV", HFOV), 
            ("VFOV", VFOV), 
            ("CameraDistance", CameraDistance), 
            ("NearPlane", NearPlane), 
            ("FarPlane", FarPlane)
        ];
        ProcessEvent(GetFunction("GetPositionalTrackingCameraParameters"),  @params);
    }
    public FVector2D GetPlayAreaBounds(EHMDTrackingOrigin Origin)
    {
        Span<(string name, object value)> @params = [
            ("Origin", Origin)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetPlayAreaBounds"),  @params);
    }
    public float GetPixelDensity()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPixelDensity"),  @params);
    }
    public void GetOrientationAndPosition(ref FRotator DeviceRotation, ref FVector DevicePosition)
    {
        Span<(string name, object value)> @params = [
            ("DeviceRotation", DeviceRotation), 
            ("DevicePosition", DevicePosition)
        ];
        ProcessEvent(GetFunction("GetOrientationAndPosition"),  @params);
    }
    public int GetNumOfTrackingSensors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumOfTrackingSensors"),  @params);
    }
    public void GetMotionControllerData(UObject* WorldContext, EControllerHand Hand, ref FXRMotionControllerData MotionControllerData)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext), 
            ("Hand", Hand), 
            ("MotionControllerData", MotionControllerData)
        ];
        ProcessEvent(GetFunction("GetMotionControllerData"),  @params);
    }
    public EHMDWornState GetHMDWornState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EHMDWornState>(GetFunction("GetHMDWornState"),  @params);
    }
    public FName GetHMDDeviceName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetHMDDeviceName"),  @params);
    }
    public void GetHMDData(UObject* WorldContext, ref FXRHMDData HMDData)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext), 
            ("HMDData", HMDData)
        ];
        ProcessEvent(GetFunction("GetHMDData"),  @params);
    }
    public void GetDeviceWorldPose(UObject* WorldContext, ref FXRDeviceId XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext), 
            ("XRDeviceId", XRDeviceId), 
            ("bIsTracked", bIsTracked), 
            ("Orientation", Orientation), 
            ("bHasPositionalTracking", bHasPositionalTracking), 
            ("Position", Position)
        ];
        ProcessEvent(GetFunction("GetDeviceWorldPose"),  @params);
    }
    public void GetDevicePose(ref FXRDeviceId XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("XRDeviceId", XRDeviceId), 
            ("bIsTracked", bIsTracked), 
            ("Orientation", Orientation), 
            ("bHasPositionalTracking", bHasPositionalTracking), 
            ("Position", Position)
        ];
        ProcessEvent(GetFunction("GetDevicePose"),  @params);
    }
    public bool GetControllerTransformForTime(UObject* WorldContext, int ControllerIndex, FName MotionSource, FTimespan Time, ref bool bTimeWasUsed, ref FRotator Orientation, ref FVector Position, ref bool bProvidedLinearVelocity, ref FVector LinearVelocity, ref bool bProvidedAngularVelocity, ref FVector AngularVelocityRadPerSec, ref bool bProvidedLinearAcceleration, ref FVector LinearAcceleration)
    {
        Span<(string name, object value)> @params = [
            ("WorldContext", (IntPtr)WorldContext), 
            ("ControllerIndex", ControllerIndex), 
            ("MotionSource", MotionSource), 
            ("Time", Time), 
            ("bTimeWasUsed", bTimeWasUsed), 
            ("Orientation", Orientation), 
            ("Position", Position), 
            ("bProvidedLinearVelocity", bProvidedLinearVelocity), 
            ("LinearVelocity", LinearVelocity), 
            ("bProvidedAngularVelocity", bProvidedAngularVelocity), 
            ("AngularVelocityRadPerSec", AngularVelocityRadPerSec), 
            ("bProvidedLinearAcceleration", bProvidedLinearAcceleration), 
            ("LinearAcceleration", LinearAcceleration)
        ];
        return ProcessEvent<bool>(GetFunction("GetControllerTransformForTime"),  @params);
    }
    public TArray<FXRDeviceId> EnumerateTrackedDevices(FName SystemId, EXRTrackedDeviceType DeviceType)
    {
        Span<(string name, object value)> @params = [
            ("SystemId", SystemId), 
            ("DeviceType", DeviceType)
        ];
        return ProcessEvent<TArray<FXRDeviceId>>(GetFunction("EnumerateTrackedDevices"),  @params);
    }
    public void EnableLowPersistenceMode(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("EnableLowPersistenceMode"),  @params);
    }
    public bool EnableHMD(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        return ProcessEvent<bool>(GetFunction("EnableHMD"),  @params);
    }
    public void DisconnectRemoteXRDevice()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisconnectRemoteXRDevice"),  @params);
    }
    public EXRDeviceConnectionResult ConnectRemoteXRDevice(FString IpAddress, int BitRate)
    {
        Span<(string name, object value)> @params = [
            ("IpAddress", IpAddress), 
            ("BitRate", BitRate)
        ];
        return ProcessEvent<EXRDeviceConnectionResult>(GetFunction("ConnectRemoteXRDevice"),  @params);
    }
    public bool ConfigureGestures(ref FXRGestureConfig GestureConfig)
    {
        Span<(string name, object value)> @params = [
            ("GestureConfig", GestureConfig)
        ];
        return ProcessEvent<bool>(GetFunction("ConfigureGestures"),  @params);
    }
    public void ClearXRTimedInputActionDelegate(ref FName ActionPath)
    {
        Span<(string name, object value)> @params = [
            ("ActionPath", ActionPath)
        ];
        ProcessEvent(GetFunction("ClearXRTimedInputActionDelegate"),  @params);
    }
    public void CalibrateExternalTrackingToHMD(ref FTransform ExternalTrackingTransform)
    {
        Span<(string name, object value)> @params = [
            ("ExternalTrackingTransform", ExternalTrackingTransform)
        ];
        ProcessEvent(GetFunction("CalibrateExternalTrackingToHMD"),  @params);
    }
    public void BreakKey(FKey InKey, ref FString InteractionProfile, ref EControllerHand Hand, ref FName MotionSource, ref FString Indentifier, ref FString Component)
    {
        Span<(string name, object value)> @params = [
            ("InKey", InKey), 
            ("InteractionProfile", InteractionProfile), 
            ("Hand", Hand), 
            ("MotionSource", MotionSource), 
            ("Indentifier", Indentifier), 
            ("Component", Component)
        ];
        ProcessEvent(GetFunction("BreakKey"),  @params);
    }
}

public unsafe class HandKeypointConversion : ObjectBase<UHandKeypointConversion>
{

    public int Conv_HandKeypointToInt32(EHandKeypoint Input)
    {
        Span<(string name, object value)> @params = [
            ("Input", Input)
        ];
        return ProcessEvent<int>(GetFunction("Conv_HandKeypointToInt32"),  @params);
    }
}

public unsafe class MotionControllerComponent : ObjectBase<UMotionControllerComponent>
{

    public void SetTrackingSource(EControllerHand NewSource)
    {
        Span<(string name, object value)> @params = [
            ("NewSource", NewSource)
        ];
        ProcessEvent(GetFunction("SetTrackingSource"),  @params);
    }
    public void SetTrackingMotionSource(FName NewSource)
    {
        Span<(string name, object value)> @params = [
            ("NewSource", NewSource)
        ];
        ProcessEvent(GetFunction("SetTrackingMotionSource"),  @params);
    }
    public void SetShowDeviceModel(bool bShowControllerModel)
    {
        Span<(string name, object value)> @params = [
            ("bShowControllerModel", bShowControllerModel)
        ];
        ProcessEvent(GetFunction("SetShowDeviceModel"),  @params);
    }
    public void SetDisplayModelSource(FName NewDisplayModelSource)
    {
        Span<(string name, object value)> @params = [
            ("NewDisplayModelSource", NewDisplayModelSource)
        ];
        ProcessEvent(GetFunction("SetDisplayModelSource"),  @params);
    }
    public void SetCustomDisplayMesh(UStaticMesh* NewDisplayMesh)
    {
        Span<(string name, object value)> @params = [
            ("NewDisplayMesh", (IntPtr)NewDisplayMesh)
        ];
        ProcessEvent(GetFunction("SetCustomDisplayMesh"),  @params);
    }
    public void SetAssociatedPlayerIndex(int NewPlayer)
    {
        Span<(string name, object value)> @params = [
            ("NewPlayer", NewPlayer)
        ];
        ProcessEvent(GetFunction("SetAssociatedPlayerIndex"),  @params);
    }
    public void OnMotionControllerUpdated()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnMotionControllerUpdated"),  @params);
    }
    public bool IsTracked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTracked"),  @params);
    }
    public EControllerHand GetTrackingSource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EControllerHand>(GetFunction("GetTrackingSource"),  @params);
    }
    public float GetParameterValue(FName InName, ref bool bValueFound)
    {
        Span<(string name, object value)> @params = [
            ("InName", InName), 
            ("bValueFound", bValueFound)
        ];
        return ProcessEvent<float>(GetFunction("GetParameterValue"),  @params);
    }
    public FVector GetHandJointPosition(int jointIndex, ref bool bValueFound)
    {
        Span<(string name, object value)> @params = [
            ("jointIndex", jointIndex), 
            ("bValueFound", bValueFound)
        ];
        return ProcessEvent<FVector>(GetFunction("GetHandJointPosition"),  @params);
    }
}

public unsafe class MotionTrackedDeviceFunctionLibrary : ObjectBase<UMotionTrackedDeviceFunctionLibrary>
{

    public void SetIsControllerMotionTrackingEnabledByDefault(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetIsControllerMotionTrackingEnabledByDefault"),  @params);
    }
    public bool IsMotionTrackingEnabledForSource(int PlayerIndex, FName SourceName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("SourceName", SourceName)
        ];
        return ProcessEvent<bool>(GetFunction("IsMotionTrackingEnabledForSource"),  @params);
    }
    public bool IsMotionTrackingEnabledForDevice(int PlayerIndex, EControllerHand Hand)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("Hand", Hand)
        ];
        return ProcessEvent<bool>(GetFunction("IsMotionTrackingEnabledForDevice"),  @params);
    }
    public bool IsMotionTrackingEnabledForComponent(UMotionControllerComponent* MotionControllerComponent)
    {
        Span<(string name, object value)> @params = [
            ("MotionControllerComponent", (IntPtr)MotionControllerComponent)
        ];
        return ProcessEvent<bool>(GetFunction("IsMotionTrackingEnabledForComponent"),  @params);
    }
    public bool IsMotionTrackedDeviceCountManagementNecessary()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsMotionTrackedDeviceCountManagementNecessary"),  @params);
    }
    public bool IsMotionSourceTracking(int PlayerIndex, FName SourceName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("SourceName", SourceName)
        ];
        return ProcessEvent<bool>(GetFunction("IsMotionSourceTracking"),  @params);
    }
    public int GetMotionTrackingEnabledControllerCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMotionTrackingEnabledControllerCount"),  @params);
    }
    public int GetMaximumMotionTrackedControllerCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMaximumMotionTrackedControllerCount"),  @params);
    }
    public FName GetActiveTrackingSystemName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetActiveTrackingSystemName"),  @params);
    }
    public TArray<FName> EnumerateMotionSources()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FName>>(GetFunction("EnumerateMotionSources"),  @params);
    }
    public bool EnableMotionTrackingOfSource(int PlayerIndex, FName SourceName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("SourceName", SourceName)
        ];
        return ProcessEvent<bool>(GetFunction("EnableMotionTrackingOfSource"),  @params);
    }
    public bool EnableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("Hand", Hand)
        ];
        return ProcessEvent<bool>(GetFunction("EnableMotionTrackingOfDevice"),  @params);
    }
    public bool EnableMotionTrackingForComponent(UMotionControllerComponent* MotionControllerComponent)
    {
        Span<(string name, object value)> @params = [
            ("MotionControllerComponent", (IntPtr)MotionControllerComponent)
        ];
        return ProcessEvent<bool>(GetFunction("EnableMotionTrackingForComponent"),  @params);
    }
    public void DisableMotionTrackingOfSource(int PlayerIndex, FName SourceName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("SourceName", SourceName)
        ];
        ProcessEvent(GetFunction("DisableMotionTrackingOfSource"),  @params);
    }
    public void DisableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex), 
            ("Hand", Hand)
        ];
        ProcessEvent(GetFunction("DisableMotionTrackingOfDevice"),  @params);
    }
    public void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("DisableMotionTrackingOfControllersForPlayer"),  @params);
    }
    public void DisableMotionTrackingOfAllControllers()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisableMotionTrackingOfAllControllers"),  @params);
    }
    public void DisableMotionTrackingForComponent(UMotionControllerComponent* MotionControllerComponent)
    {
        Span<(string name, object value)> @params = [
            ("MotionControllerComponent", (IntPtr)MotionControllerComponent)
        ];
        ProcessEvent(GetFunction("DisableMotionTrackingForComponent"),  @params);
    }
}

public unsafe class VRNotificationsComponent : ObjectBase<UVRNotificationsComponent>
{

}

public unsafe class XRAssetFunctionLibrary : ObjectBase<UXRAssetFunctionLibrary>
{

    public UPrimitiveComponent* AddNamedDeviceVisualizationComponentBlocking(AActor* Target, FName SystemName, FName DeviceName, bool bManualAttachment, ref FTransform RelativeTransform, ref FXRDeviceId XRDeviceId)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SystemName", SystemName), 
            ("DeviceName", DeviceName), 
            ("bManualAttachment", bManualAttachment), 
            ("RelativeTransform", RelativeTransform), 
            ("XRDeviceId", XRDeviceId)
        ];
        return (UPrimitiveComponent*)ProcessEvent<IntPtr>(GetFunction("AddNamedDeviceVisualizationComponentBlocking"),  @params);
    }
    public UPrimitiveComponent* AddDeviceVisualizationComponentBlocking(AActor* Target, ref FXRDeviceId XRDeviceId, bool bManualAttachment, ref FTransform RelativeTransform)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("XRDeviceId", XRDeviceId), 
            ("bManualAttachment", bManualAttachment), 
            ("RelativeTransform", RelativeTransform)
        ];
        return (UPrimitiveComponent*)ProcessEvent<IntPtr>(GetFunction("AddDeviceVisualizationComponentBlocking"),  @params);
    }
}

public unsafe class AsyncTask_LoadXRDeviceVisComponent : ObjectBase<UAsyncTask_LoadXRDeviceVisComponent>
{

    public UAsyncTask_LoadXRDeviceVisComponent* AddNamedDeviceVisualizationComponentAsync(AActor* Target, FName SystemName, FName DeviceName, bool bManualAttachment, ref FTransform RelativeTransform, ref FXRDeviceId XRDeviceId, ref UPrimitiveComponent* NewComponent)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SystemName", SystemName), 
            ("DeviceName", DeviceName), 
            ("bManualAttachment", bManualAttachment), 
            ("RelativeTransform", RelativeTransform), 
            ("XRDeviceId", XRDeviceId), 
            ("NewComponent", (IntPtr)NewComponent)
        ];
        return (UAsyncTask_LoadXRDeviceVisComponent*)ProcessEvent<IntPtr>(GetFunction("AddNamedDeviceVisualizationComponentAsync"),  @params);
    }
    public UAsyncTask_LoadXRDeviceVisComponent* AddDeviceVisualizationComponentAsync(AActor* Target, ref FXRDeviceId XRDeviceId, bool bManualAttachment, ref FTransform RelativeTransform, ref UPrimitiveComponent* NewComponent)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("XRDeviceId", XRDeviceId), 
            ("bManualAttachment", bManualAttachment), 
            ("RelativeTransform", RelativeTransform), 
            ("NewComponent", (IntPtr)NewComponent)
        ];
        return (UAsyncTask_LoadXRDeviceVisComponent*)ProcessEvent<IntPtr>(GetFunction("AddDeviceVisualizationComponentAsync"),  @params);
    }
}

public unsafe class XRLoadingScreenFunctionLibrary : ObjectBase<UXRLoadingScreenFunctionLibrary>
{

    public void ShowLoadingScreen()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowLoadingScreen"),  @params);
    }
    public void SetLoadingScreen(UTexture* Texture, FVector2D Scale, FVector Offset, bool bShowLoadingMovie, bool bShowOnSet)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("Scale", Scale), 
            ("Offset", Offset), 
            ("bShowLoadingMovie", bShowLoadingMovie), 
            ("bShowOnSet", bShowOnSet)
        ];
        ProcessEvent(GetFunction("SetLoadingScreen"),  @params);
    }
    public void HideLoadingScreen()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("HideLoadingScreen"),  @params);
    }
    public void ClearLoadingScreenSplashes()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearLoadingScreenSplashes"),  @params);
    }
    public void AddLoadingScreenSplash(UTexture* Texture, FVector Translation, FRotator Rotation, FVector2D Size, FRotator DeltaRotation, bool bClearBeforeAdd)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("Translation", Translation), 
            ("Rotation", Rotation), 
            ("Size", Size), 
            ("DeltaRotation", DeltaRotation), 
            ("bClearBeforeAdd", bClearBeforeAdd)
        ];
        ProcessEvent(GetFunction("AddLoadingScreenSplash"),  @params);
    }
}

