using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ARActor : ObjectBase<AARActor>
{

    public UARComponent* AddARComponent(TSubclassOf<UARComponent> InComponentClass, ref FGuid NativeID)
    {
        Span<(string name, object value)> @params = [
            ("InComponentClass", InComponentClass), 
            ("NativeID", NativeID)
        ];
        return (UARComponent*)ProcessEvent<IntPtr>(GetFunction("AddARComponent"),  @params);
    }
}

public unsafe class ARTraceResult : ObjectBase<FARTraceResult>
{

}

public unsafe class ARVideoFormat : ObjectBase<FARVideoFormat>
{

}

public unsafe class ARCameraIntrinsics : ObjectBase<FARCameraIntrinsics>
{

}

public unsafe class ARSessionStatus : ObjectBase<FARSessionStatus>
{

}

public unsafe class ARPose2D : ObjectBase<FARPose2D>
{

}

public unsafe class ARBlueprintLibrary : ObjectBase<UARBlueprintLibrary>
{

    public void UnpinComponent(USceneComponent* ComponentToUnpin)
    {
        Span<(string name, object value)> @params = [
            ("ComponentToUnpin", (IntPtr)ComponentToUnpin)
        ];
        ProcessEvent(GetFunction("UnpinComponent"),  @params);
    }
    public bool ToggleARCapture(bool bOnOff, EARCaptureType CaptureType)
    {
        Span<(string name, object value)> @params = [
            ("bOnOff", bOnOff), 
            ("CaptureType", CaptureType)
        ];
        return ProcessEvent<bool>(GetFunction("ToggleARCapture"),  @params);
    }
    public void StopARSession()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopARSession"),  @params);
    }
    public void StartARSession(UARSessionConfig* SessionConfig)
    {
        Span<(string name, object value)> @params = [
            ("SessionConfig", (IntPtr)SessionConfig)
        ];
        ProcessEvent(GetFunction("StartARSession"),  @params);
    }
    public void SetEnabledXRCamera(bool bOnOff)
    {
        Span<(string name, object value)> @params = [
            ("bOnOff", bOnOff)
        ];
        ProcessEvent(GetFunction("SetEnabledXRCamera"),  @params);
    }
    public void SetARWorldScale(float InWorldScale)
    {
        Span<(string name, object value)> @params = [
            ("InWorldScale", InWorldScale)
        ];
        ProcessEvent(GetFunction("SetARWorldScale"),  @params);
    }
    public void SetARWorldOriginLocationAndRotation(FVector OriginLocation, FRotator OriginRotation, bool bIsTransformInWorldSpace, bool bMaintainUpDirection)
    {
        Span<(string name, object value)> @params = [
            ("OriginLocation", OriginLocation), 
            ("OriginRotation", OriginRotation), 
            ("bIsTransformInWorldSpace", bIsTransformInWorldSpace), 
            ("bMaintainUpDirection", bMaintainUpDirection)
        ];
        ProcessEvent(GetFunction("SetARWorldOriginLocationAndRotation"),  @params);
    }
    public void SetAlignmentTransform(ref FTransform InAlignmentTransform)
    {
        Span<(string name, object value)> @params = [
            ("InAlignmentTransform", InAlignmentTransform)
        ];
        ProcessEvent(GetFunction("SetAlignmentTransform"),  @params);
    }
    public bool SaveARPinToLocalStore(FName InSaveName, UARPin* InPin)
    {
        Span<(string name, object value)> @params = [
            ("InSaveName", InSaveName), 
            ("InPin", (IntPtr)InPin)
        ];
        return ProcessEvent<bool>(GetFunction("SaveARPinToLocalStore"),  @params);
    }
    public FIntPoint ResizeXRCamera(ref FIntPoint InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        return ProcessEvent<FIntPoint>(GetFunction("ResizeXRCamera"),  @params);
    }
    public void RemovePin(UARPin* PinToRemove)
    {
        Span<(string name, object value)> @params = [
            ("PinToRemove", (IntPtr)PinToRemove)
        ];
        ProcessEvent(GetFunction("RemovePin"),  @params);
    }
    public void RemoveARPinFromLocalStore(FName InSaveName)
    {
        Span<(string name, object value)> @params = [
            ("InSaveName", InSaveName)
        ];
        ProcessEvent(GetFunction("RemoveARPinFromLocalStore"),  @params);
    }
    public void RemoveAllARPinsFromLocalStore()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveAllARPinsFromLocalStore"),  @params);
    }
    public UARPin* PinComponentToTraceResult(USceneComponent* ComponentToPin, ref FARTraceResult TraceResult, FName DebugName)
    {
        Span<(string name, object value)> @params = [
            ("ComponentToPin", (IntPtr)ComponentToPin), 
            ("TraceResult", TraceResult), 
            ("DebugName", DebugName)
        ];
        return (UARPin*)ProcessEvent<IntPtr>(GetFunction("PinComponentToTraceResult"),  @params);
    }
    public bool PinComponentToARPin(USceneComponent* ComponentToPin, UARPin* Pin)
    {
        Span<(string name, object value)> @params = [
            ("ComponentToPin", (IntPtr)ComponentToPin), 
            ("Pin", (IntPtr)Pin)
        ];
        return ProcessEvent<bool>(GetFunction("PinComponentToARPin"),  @params);
    }
    public UARPin* PinComponent(USceneComponent* ComponentToPin, ref FTransform PinToWorldTransform, UARTrackedGeometry* TrackedGeometry, FName DebugName)
    {
        Span<(string name, object value)> @params = [
            ("ComponentToPin", (IntPtr)ComponentToPin), 
            ("PinToWorldTransform", PinToWorldTransform), 
            ("TrackedGeometry", (IntPtr)TrackedGeometry), 
            ("DebugName", DebugName)
        ];
        return (UARPin*)ProcessEvent<IntPtr>(GetFunction("PinComponent"),  @params);
    }
    public void PauseARSession()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PauseARSession"),  @params);
    }
    public TMap<FName, IntPtr> LoadARPinsFromLocalStore()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TMap<FName, IntPtr>>(GetFunction("LoadARPinsFromLocalStore"),  @params);
    }
    public TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start, FVector End, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon)
    {
        Span<(string name, object value)> @params = [
            ("Start", Start), 
            ("End", End), 
            ("bTestFeaturePoints", bTestFeaturePoints), 
            ("bTestGroundPlane", bTestGroundPlane), 
            ("bTestPlaneExtents", bTestPlaneExtents), 
            ("bTestPlaneBoundaryPolygon", bTestPlaneBoundaryPolygon)
        ];
        return ProcessEvent<TArray<FARTraceResult>>(GetFunction("LineTraceTrackedObjects3D"),  @params);
    }
    public TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon)
    {
        Span<(string name, object value)> @params = [
            ("ScreenCoord", ScreenCoord), 
            ("bTestFeaturePoints", bTestFeaturePoints), 
            ("bTestGroundPlane", bTestGroundPlane), 
            ("bTestPlaneExtents", bTestPlaneExtents), 
            ("bTestPlaneBoundaryPolygon", bTestPlaneBoundaryPolygon)
        ];
        return ProcessEvent<TArray<FARTraceResult>>(GetFunction("LineTraceTrackedObjects"),  @params);
    }
    public bool IsSessionTypeSupported(EARSessionType SessionType)
    {
        Span<(string name, object value)> @params = [
            ("SessionType", SessionType)
        ];
        return ProcessEvent<bool>(GetFunction("IsSessionTypeSupported"),  @params);
    }
    public bool IsSessionTrackingFeatureSupported(EARSessionType SessionType, EARSessionTrackingFeature SessionTrackingFeature)
    {
        Span<(string name, object value)> @params = [
            ("SessionType", SessionType), 
            ("SessionTrackingFeature", SessionTrackingFeature)
        ];
        return ProcessEvent<bool>(GetFunction("IsSessionTrackingFeatureSupported"),  @params);
    }
    public bool IsSceneReconstructionSupported(EARSessionType SessionType, EARSceneReconstruction SceneReconstructionMethod)
    {
        Span<(string name, object value)> @params = [
            ("SessionType", SessionType), 
            ("SceneReconstructionMethod", SceneReconstructionMethod)
        ];
        return ProcessEvent<bool>(GetFunction("IsSceneReconstructionSupported"),  @params);
    }
    public bool IsARSupported()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsARSupported"),  @params);
    }
    public bool IsARPinLocalStoreSupported()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsARPinLocalStoreSupported"),  @params);
    }
    public bool IsARPinLocalStoreReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsARPinLocalStoreReady"),  @params);
    }
    public EARWorldMappingState GetWorldMappingStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARWorldMappingState>(GetFunction("GetWorldMappingStatus"),  @params);
    }
    public EARTrackingQualityReason GetTrackingQualityReason()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARTrackingQualityReason>(GetFunction("GetTrackingQualityReason"),  @params);
    }
    public EARTrackingQuality GetTrackingQuality()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARTrackingQuality>(GetFunction("GetTrackingQuality"),  @params);
    }
    public TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType)
    {
        Span<(string name, object value)> @params = [
            ("SessionType", SessionType)
        ];
        return ProcessEvent<TArray<FARVideoFormat>>(GetFunction("GetSupportedVideoFormats"),  @params);
    }
    public UARSessionConfig* GetSessionConfig()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARSessionConfig*)ProcessEvent<IntPtr>(GetFunction("GetSessionConfig"),  @params);
    }
    public TArray<FVector> GetPointCloud()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetPointCloud"),  @params);
    }
    public UARTexture* GetPersonSegmentationImage()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARTexture*)ProcessEvent<IntPtr>(GetFunction("GetPersonSegmentationImage"),  @params);
    }
    public UARTexture* GetPersonSegmentationDepthImage()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARTexture*)ProcessEvent<IntPtr>(GetFunction("GetPersonSegmentationDepthImage"),  @params);
    }
    public bool GetObjectClassificationAtLocation(ref FVector InWorldLocation, ref EARObjectClassification OutClassification, ref FVector OutClassificationLocation, float MaxLocationDiff)
    {
        Span<(string name, object value)> @params = [
            ("InWorldLocation", InWorldLocation), 
            ("OutClassification", OutClassification), 
            ("OutClassificationLocation", OutClassificationLocation), 
            ("MaxLocationDiff", MaxLocationDiff)
        ];
        return ProcessEvent<bool>(GetFunction("GetObjectClassificationAtLocation"),  @params);
    }
    public int GetNumberOfTrackedFacesSupported()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumberOfTrackedFacesSupported"),  @params);
    }
    public UARLightEstimate* GetCurrentLightEstimate()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARLightEstimate*)ProcessEvent<IntPtr>(GetFunction("GetCurrentLightEstimate"),  @params);
    }
    public bool GetCameraIntrinsics(ref FARCameraIntrinsics OutCameraIntrinsics)
    {
        Span<(string name, object value)> @params = [
            ("OutCameraIntrinsics", OutCameraIntrinsics)
        ];
        return ProcessEvent<bool>(GetFunction("GetCameraIntrinsics"),  @params);
    }
    public UARTextureCameraImage* GetCameraImage()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARTextureCameraImage*)ProcessEvent<IntPtr>(GetFunction("GetCameraImage"),  @params);
    }
    public UARTextureCameraDepth* GetCameraDepth()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARTextureCameraDepth*)ProcessEvent<IntPtr>(GetFunction("GetCameraDepth"),  @params);
    }
    public float GetARWorldScale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetARWorldScale"),  @params);
    }
    public UARTexture* GetARTexture(EARTextureType TextureType)
    {
        Span<(string name, object value)> @params = [
            ("TextureType", TextureType)
        ];
        return (UARTexture*)ProcessEvent<IntPtr>(GetFunction("GetARTexture"),  @params);
    }
    public FARSessionStatus GetARSessionStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FARSessionStatus>(GetFunction("GetARSessionStatus"),  @params);
    }
    public TArray<IntPtr> GetAllTrackedPoses()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllTrackedPoses"),  @params);
    }
    public TArray<IntPtr> GetAllTrackedPoints()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllTrackedPoints"),  @params);
    }
    public TArray<IntPtr> GetAllTrackedPlanes()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllTrackedPlanes"),  @params);
    }
    public TArray<IntPtr> GetAllTrackedImages()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllTrackedImages"),  @params);
    }
    public TArray<IntPtr> GetAllTrackedEnvironmentCaptureProbes()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllTrackedEnvironmentCaptureProbes"),  @params);
    }
    public TArray<FARPose2D> GetAllTracked2DPoses()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FARPose2D>>(GetFunction("GetAllTracked2DPoses"),  @params);
    }
    public TArray<IntPtr> GetAllPins()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllPins"),  @params);
    }
    public TArray<IntPtr> GetAllGeometriesByClass(TSubclassOf<UARTrackedGeometry> GeometryClass)
    {
        Span<(string name, object value)> @params = [
            ("GeometryClass", GeometryClass)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllGeometriesByClass"),  @params);
    }
    public TArray<IntPtr> GetAllGeometries()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllGeometries"),  @params);
    }
    public FTransform GetAlignmentTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetAlignmentTransform"),  @params);
    }
    public TArray<IntPtr> FindTrackedPointsByName(FString PointName)
    {
        Span<(string name, object value)> @params = [
            ("PointName", PointName)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("FindTrackedPointsByName"),  @params);
    }
    public void DebugDrawTrackedGeometry(UARTrackedGeometry* TrackedGeometry, UObject* WorldContextObject, FLinearColor Color, float OutlineThickness, float PersistForSeconds)
    {
        Span<(string name, object value)> @params = [
            ("TrackedGeometry", (IntPtr)TrackedGeometry), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Color", Color), 
            ("OutlineThickness", OutlineThickness), 
            ("PersistForSeconds", PersistForSeconds)
        ];
        ProcessEvent(GetFunction("DebugDrawTrackedGeometry"),  @params);
    }
    public void DebugDrawPin(UARPin* ARPin, UObject* WorldContextObject, FLinearColor Color, float Scale, float PersistForSeconds)
    {
        Span<(string name, object value)> @params = [
            ("ARPin", (IntPtr)ARPin), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Color", Color), 
            ("Scale", Scale), 
            ("PersistForSeconds", PersistForSeconds)
        ];
        ProcessEvent(GetFunction("DebugDrawPin"),  @params);
    }
    public void CalculateClosestIntersection(ref TArray<FVector> StartPoints, ref TArray<FVector> EndPoints, ref FVector ClosestIntersection)
    {
        Span<(string name, object value)> @params = [
            ("StartPoints", StartPoints), 
            ("EndPoints", EndPoints), 
            ("ClosestIntersection", ClosestIntersection)
        ];
        ProcessEvent(GetFunction("CalculateClosestIntersection"),  @params);
    }
    public void CalculateAlignmentTransform(ref FTransform TransformInFirstCoordinateSystem, ref FTransform TransformInSecondCoordinateSystem, ref FTransform AlignmentTransform)
    {
        Span<(string name, object value)> @params = [
            ("TransformInFirstCoordinateSystem", TransformInFirstCoordinateSystem), 
            ("TransformInSecondCoordinateSystem", TransformInSecondCoordinateSystem), 
            ("AlignmentTransform", AlignmentTransform)
        ];
        ProcessEvent(GetFunction("CalculateAlignmentTransform"),  @params);
    }
    public bool AddTrackedPointWithName(ref FTransform WorldTransform, FString PointName, bool bDeletePointsWithSameName)
    {
        Span<(string name, object value)> @params = [
            ("WorldTransform", WorldTransform), 
            ("PointName", PointName), 
            ("bDeletePointsWithSameName", bDeletePointsWithSameName)
        ];
        return ProcessEvent<bool>(GetFunction("AddTrackedPointWithName"),  @params);
    }
    public UARCandidateImage* AddRuntimeCandidateImage(UARSessionConfig* SessionConfig, UTexture2D* CandidateTexture, FString FriendlyName, float PhysicalWidth)
    {
        Span<(string name, object value)> @params = [
            ("SessionConfig", (IntPtr)SessionConfig), 
            ("CandidateTexture", (IntPtr)CandidateTexture), 
            ("FriendlyName", FriendlyName), 
            ("PhysicalWidth", PhysicalWidth)
        ];
        return (UARCandidateImage*)ProcessEvent<IntPtr>(GetFunction("AddRuntimeCandidateImage"),  @params);
    }
    public bool AddManualEnvironmentCaptureProbe(FVector Location, FVector Extent)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location), 
            ("Extent", Extent)
        ];
        return ProcessEvent<bool>(GetFunction("AddManualEnvironmentCaptureProbe"),  @params);
    }
}

public unsafe class ARTraceResultLibrary : ObjectBase<UARTraceResultLibrary>
{

    public UARTrackedGeometry* GetTrackedGeometry(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return (UARTrackedGeometry*)ProcessEvent<IntPtr>(GetFunction("GetTrackedGeometry"),  @params);
    }
    public EARLineTraceChannels GetTraceChannel(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return ProcessEvent<EARLineTraceChannels>(GetFunction("GetTraceChannel"),  @params);
    }
    public FTransform GetLocalTransform(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalTransform"),  @params);
    }
    public FTransform GetLocalToWorldTransform(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToWorldTransform"),  @params);
    }
    public FTransform GetLocalToTrackingTransform(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToTrackingTransform"),  @params);
    }
    public float GetDistanceFromCamera(ref FARTraceResult TraceResult)
    {
        Span<(string name, object value)> @params = [
            ("TraceResult", TraceResult)
        ];
        return ProcessEvent<float>(GetFunction("GetDistanceFromCamera"),  @params);
    }
}

public unsafe class ARBaseAsyncTaskBlueprintProxy : ObjectBase<UARBaseAsyncTaskBlueprintProxy>
{
}

public unsafe class ARSaveWorldAsyncTaskBlueprintProxy : ObjectBase<UARSaveWorldAsyncTaskBlueprintProxy>
{

    public UARSaveWorldAsyncTaskBlueprintProxy* ARSaveWorld(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (UARSaveWorldAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("ARSaveWorld"),  @params);
    }
}

public unsafe class ARGetCandidateObjectAsyncTaskBlueprintProxy : ObjectBase<UARGetCandidateObjectAsyncTaskBlueprintProxy>
{

    public UARGetCandidateObjectAsyncTaskBlueprintProxy* ARGetCandidateObject(UObject* WorldContextObject, FVector Location, FVector Extent)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Location", Location), 
            ("Extent", Extent)
        ];
        return (UARGetCandidateObjectAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("ARGetCandidateObject"),  @params);
    }
}

public unsafe class ARComponent : ObjectBase<UARComponent>
{

    public void UpdateVisualization()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UpdateVisualization"),  @params);
    }
    public void SetNativeID(FGuid NativeID)
    {
        Span<(string name, object value)> @params = [
            ("NativeID", NativeID)
        ];
        ProcessEvent(GetFunction("SetNativeID"),  @params);
    }
    public void ReceiveRemove()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReceiveRemove"),  @params);
    }
    public void OnRep_Payload()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnRep_Payload"),  @params);
    }
    public UMRMeshComponent* GetMRMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMRMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetMRMesh"),  @params);
    }
}

public unsafe class ARPlaneUpdatePayload : ObjectBase<FARPlaneUpdatePayload>
{

}

public unsafe class ARPlaneComponent : ObjectBase<UARPlaneComponent>
{

    public void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetPlaneComponentDebugMode"),  @params);
    }
    public void SetObjectClassificationDebugColors(ref TMap<EARObjectClassification, FLinearColor> InColors)
    {
        Span<(string name, object value)> @params = [
            ("InColors", InColors)
        ];
        ProcessEvent(GetFunction("SetObjectClassificationDebugColors"),  @params);
    }
    public void ServerUpdatePayload(ref FARPlaneUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARPlaneUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARPlaneUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
    public TMap<EARObjectClassification, FLinearColor> GetObjectClassificationDebugColors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TMap<EARObjectClassification, FLinearColor>>(GetFunction("GetObjectClassificationDebugColors"),  @params);
    }
}

public unsafe class ARPointUpdatePayload : ObjectBase<FARPointUpdatePayload>
{
}

public unsafe class ARPointComponent : ObjectBase<UARPointComponent>
{

    public void ServerUpdatePayload(ref FARPointUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARPointUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARPointUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARFaceUpdatePayload : ObjectBase<FARFaceUpdatePayload>
{

}

public unsafe class ARFaceComponent : ObjectBase<UARFaceComponent>
{

    public void SetFaceComponentDebugMode(EFaceComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetFaceComponentDebugMode"),  @params);
    }
    public void ServerUpdatePayload(ref FARFaceUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARFaceUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARFaceUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARImageUpdatePayload : ObjectBase<FARImageUpdatePayload>
{

}

public unsafe class ARImageComponent : ObjectBase<UARImageComponent>
{

    public void SetImageComponentDebugMode(EImageComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetImageComponentDebugMode"),  @params);
    }
    public void ServerUpdatePayload(ref FARImageUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARImageUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARImageUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARQRCodeUpdatePayload : ObjectBase<FARQRCodeUpdatePayload>
{

}

public unsafe class ARQRCodeComponent : ObjectBase<UARQRCodeComponent>
{

    public void SetQRCodeComponentDebugMode(EQRCodeComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetQRCodeComponentDebugMode"),  @params);
    }
    public void ServerUpdatePayload(ref FARQRCodeUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARQRCodeUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARQRCodeUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARPoseUpdatePayload : ObjectBase<FARPoseUpdatePayload>
{

}

public unsafe class ARPoseComponent : ObjectBase<UARPoseComponent>
{

    public void SetPoseComponentDebugMode(EPoseComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetPoseComponentDebugMode"),  @params);
    }
    public void ServerUpdatePayload(ref FARPoseUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARPoseUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARPoseUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class AREnvironmentProbeUpdatePayload : ObjectBase<FAREnvironmentProbeUpdatePayload>
{

}

public unsafe class AREnvironmentProbeComponent : ObjectBase<UAREnvironmentProbeComponent>
{

    public void ServerUpdatePayload(ref FAREnvironmentProbeUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FAREnvironmentProbeUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FAREnvironmentProbeUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARObjectUpdatePayload : ObjectBase<FARObjectUpdatePayload>
{

}

public unsafe class ARObjectComponent : ObjectBase<UARObjectComponent>
{

    public void ServerUpdatePayload(ref FARObjectUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARObjectUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARObjectUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARMeshUpdatePayload : ObjectBase<FARMeshUpdatePayload>
{

}

public unsafe class ARMeshComponent : ObjectBase<UARMeshComponent>
{

    public void ServerUpdatePayload(ref FARMeshUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARMeshUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARMeshUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARGeoAnchorUpdatePayload : ObjectBase<FARGeoAnchorUpdatePayload>
{

}

public unsafe class ARGeoAnchorComponent : ObjectBase<UARGeoAnchorComponent>
{

    public void SetGeoAnchorComponentDebugMode(EGeoAnchorComponentDebugMode NewDebugMode)
    {
        Span<(string name, object value)> @params = [
            ("NewDebugMode", NewDebugMode)
        ];
        ProcessEvent(GetFunction("SetGeoAnchorComponentDebugMode"),  @params);
    }
    public void ServerUpdatePayload(ref FARGeoAnchorUpdatePayload NewPayload)
    {
        Span<(string name, object value)> @params = [
            ("NewPayload", NewPayload)
        ];
        ProcessEvent(GetFunction("ServerUpdatePayload"),  @params);
    }
    public void ReceiveUpdate(ref FARGeoAnchorUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveUpdate"),  @params);
    }
    public void ReceiveAdd(ref FARGeoAnchorUpdatePayload Payload)
    {
        Span<(string name, object value)> @params = [
            ("Payload", Payload)
        ];
        ProcessEvent(GetFunction("ReceiveAdd"),  @params);
    }
}

public unsafe class ARDependencyHandler : ObjectBase<UARDependencyHandler>
{

    public void StartARSessionLatent(UObject* WorldContextObject, UARSessionConfig* SessionConfig, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SessionConfig", (IntPtr)SessionConfig), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("StartARSessionLatent"),  @params);
    }
    public void RequestARSessionPermission(UObject* WorldContextObject, UARSessionConfig* SessionConfig, FLatentActionInfo LatentInfo, ref EARServicePermissionRequestResult OutPermissionResult)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SessionConfig", (IntPtr)SessionConfig), 
            ("LatentInfo", LatentInfo), 
            ("OutPermissionResult", OutPermissionResult)
        ];
        ProcessEvent(GetFunction("RequestARSessionPermission"),  @params);
    }
    public void InstallARService(UObject* WorldContextObject, FLatentActionInfo LatentInfo, ref EARServiceInstallRequestResult OutInstallResult)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo), 
            ("OutInstallResult", OutInstallResult)
        ];
        ProcessEvent(GetFunction("InstallARService"),  @params);
    }
    public UARDependencyHandler* GetARDependencyHandler()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARDependencyHandler*)ProcessEvent<IntPtr>(GetFunction("GetARDependencyHandler"),  @params);
    }
    public void CheckARServiceAvailability(UObject* WorldContextObject, FLatentActionInfo LatentInfo, ref EARServiceAvailability OutAvailability)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo), 
            ("OutAvailability", OutAvailability)
        ];
        ProcessEvent(GetFunction("CheckARServiceAvailability"),  @params);
    }
}

public unsafe class ARGeoTrackingSupport : ObjectBase<UARGeoTrackingSupport>
{

    public UARGeoTrackingSupport* GetGeoTrackingSupport()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARGeoTrackingSupport*)ProcessEvent<IntPtr>(GetFunction("GetGeoTrackingSupport"),  @params);
    }
    public EARGeoTrackingStateReason GetGeoTrackingStateReason()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARGeoTrackingStateReason>(GetFunction("GetGeoTrackingStateReason"),  @params);
    }
    public EARGeoTrackingState GetGeoTrackingState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARGeoTrackingState>(GetFunction("GetGeoTrackingState"),  @params);
    }
    public EARGeoTrackingAccuracy GetGeoTrackingAccuracy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARGeoTrackingAccuracy>(GetFunction("GetGeoTrackingAccuracy"),  @params);
    }
    public bool AddGeoAnchorAtLocationWithAltitude(float Longitude, float Latitude, float AltitudeMeters, FString OptionalAnchorName)
    {
        Span<(string name, object value)> @params = [
            ("Longitude", Longitude), 
            ("Latitude", Latitude), 
            ("AltitudeMeters", AltitudeMeters), 
            ("OptionalAnchorName", OptionalAnchorName)
        ];
        return ProcessEvent<bool>(GetFunction("AddGeoAnchorAtLocationWithAltitude"),  @params);
    }
    public bool AddGeoAnchorAtLocation(float Longitude, float Latitude, FString OptionalAnchorName)
    {
        Span<(string name, object value)> @params = [
            ("Longitude", Longitude), 
            ("Latitude", Latitude), 
            ("OptionalAnchorName", OptionalAnchorName)
        ];
        return ProcessEvent<bool>(GetFunction("AddGeoAnchorAtLocation"),  @params);
    }
}

public unsafe class CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : ObjectBase<UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy>
{

    public void GeoTrackingAvailabilityDelegate__DelegateSignature(bool bIsAvailable, FString Error)
    {
        Span<(string name, object value)> @params = [
            ("bIsAvailable", bIsAvailable), 
            ("Error", Error)
        ];
        ProcessEvent(GetFunction("GeoTrackingAvailabilityDelegate__DelegateSignature"),  @params);
    }
    public UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy* CheckGeoTrackingAvailabilityAtLocation(UObject* WorldContextObject, float Longitude, float Latitude)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Longitude", Longitude), 
            ("Latitude", Latitude)
        ];
        return (UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CheckGeoTrackingAvailabilityAtLocation"),  @params);
    }
    public UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy* CheckGeoTrackingAvailability(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CheckGeoTrackingAvailability"),  @params);
    }
}

public unsafe class GetGeoLocationAsyncTaskBlueprintProxy : ObjectBase<UGetGeoLocationAsyncTaskBlueprintProxy>
{

    public void GetGeoLocationDelegate__DelegateSignature(float Longitude, float Latitude, float Altitude, FString Error)
    {
        Span<(string name, object value)> @params = [
            ("Longitude", Longitude), 
            ("Latitude", Latitude), 
            ("Altitude", Altitude), 
            ("Error", Error)
        ];
        ProcessEvent(GetFunction("GetGeoLocationDelegate__DelegateSignature"),  @params);
    }
    public UGetGeoLocationAsyncTaskBlueprintProxy* GetGeoLocationAtWorldPosition(UObject* WorldContextObject, ref FVector WorldPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("WorldPosition", WorldPosition)
        ];
        return (UGetGeoLocationAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("GetGeoLocationAtWorldPosition"),  @params);
    }
}

public unsafe class ARLifeCycleComponent : ObjectBase<UARLifeCycleComponent>
{

    public void ServerSpawnARActor(UClass* ComponentClass, FGuid NativeID)
    {
        Span<(string name, object value)> @params = [
            ("ComponentClass", (IntPtr)ComponentClass), 
            ("NativeID", NativeID)
        ];
        ProcessEvent(GetFunction("ServerSpawnARActor"),  @params);
    }
    public void ServerDestroyARActor(AARActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("ServerDestroyARActor"),  @params);
    }
    public void InstanceARActorToBeDestroyedDelegate__DelegateSignature(AARActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("InstanceARActorToBeDestroyedDelegate__DelegateSignature"),  @params);
    }
    public void InstanceARActorSpawnedDelegate__DelegateSignature(UClass* ComponentClass, FGuid NativeID, AARActor* SpawnedActor)
    {
        Span<(string name, object value)> @params = [
            ("ComponentClass", (IntPtr)ComponentClass), 
            ("NativeID", NativeID), 
            ("SpawnedActor", (IntPtr)SpawnedActor)
        ];
        ProcessEvent(GetFunction("InstanceARActorSpawnedDelegate__DelegateSignature"),  @params);
    }
}

public unsafe class ARLightEstimate : ObjectBase<UARLightEstimate>
{
}

public unsafe class ARBasicLightEstimate : ObjectBase<UARBasicLightEstimate>
{

    public float GetAmbientIntensityLumens()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAmbientIntensityLumens"),  @params);
    }
    public float GetAmbientColorTemperatureKelvin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAmbientColorTemperatureKelvin"),  @params);
    }
    public FLinearColor GetAmbientColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetAmbientColor"),  @params);
    }
}

public unsafe class AROriginActor : ObjectBase<AAROriginActor>
{
}

public unsafe class ARPin : ObjectBase<UARPin>
{

    public EARTrackingState GetTrackingState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARTrackingState>(GetFunction("GetTrackingState"),  @params);
    }
    public UARTrackedGeometry* GetTrackedGeometry()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARTrackedGeometry*)ProcessEvent<IntPtr>(GetFunction("GetTrackedGeometry"),  @params);
    }
    public USceneComponent* GetPinnedComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USceneComponent*)ProcessEvent<IntPtr>(GetFunction("GetPinnedComponent"),  @params);
    }
    public FTransform GetLocalToWorldTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToWorldTransform"),  @params);
    }
    public FTransform GetLocalToTrackingTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToTrackingTransform"),  @params);
    }
    public FName GetDebugName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetDebugName"),  @params);
    }
    public void DebugDraw(UWorld* World, ref FLinearColor Color, float Scale, float PersistForSeconds)
    {
        Span<(string name, object value)> @params = [
            ("World", (IntPtr)World), 
            ("Color", Color), 
            ("Scale", Scale), 
            ("PersistForSeconds", PersistForSeconds)
        ];
        ProcessEvent(GetFunction("DebugDraw"),  @params);
    }
}

public unsafe class ARSessionConfig : ObjectBase<UARSessionConfig>
{

    public bool ShouldResetTrackedObjects()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldResetTrackedObjects"),  @params);
    }
    public bool ShouldResetCameraTracking()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldResetCameraTracking"),  @params);
    }
    public bool ShouldRenderCameraOverlay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldRenderCameraOverlay"),  @params);
    }
    public bool ShouldEnableCameraTracking()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldEnableCameraTracking"),  @params);
    }
    public bool ShouldEnableAutoFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldEnableAutoFocus"),  @params);
    }
    public void SetWorldMapData(TArray<byte> WorldMapData)
    {
        Span<(string name, object value)> @params = [
            ("WorldMapData", WorldMapData)
        ];
        ProcessEvent(GetFunction("SetWorldMapData"),  @params);
    }
    public void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature)
    {
        Span<(string name, object value)> @params = [
            ("InSessionTrackingFeature", InSessionTrackingFeature)
        ];
        ProcessEvent(GetFunction("SetSessionTrackingFeatureToEnable"),  @params);
    }
    public void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod)
    {
        Span<(string name, object value)> @params = [
            ("InSceneReconstructionMethod", InSceneReconstructionMethod)
        ];
        ProcessEvent(GetFunction("SetSceneReconstructionMethod"),  @params);
    }
    public void SetResetTrackedObjects(bool bNewValue)
    {
        Span<(string name, object value)> @params = [
            ("bNewValue", bNewValue)
        ];
        ProcessEvent(GetFunction("SetResetTrackedObjects"),  @params);
    }
    public void SetResetCameraTracking(bool bNewValue)
    {
        Span<(string name, object value)> @params = [
            ("bNewValue", bNewValue)
        ];
        ProcessEvent(GetFunction("SetResetCameraTracking"),  @params);
    }
    public void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate)
    {
        Span<(string name, object value)> @params = [
            ("InUpdate", InUpdate)
        ];
        ProcessEvent(GetFunction("SetFaceTrackingUpdate"),  @params);
    }
    public void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection)
    {
        Span<(string name, object value)> @params = [
            ("InDirection", InDirection)
        ];
        ProcessEvent(GetFunction("SetFaceTrackingDirection"),  @params);
    }
    public void SetEnableAutoFocus(bool bNewValue)
    {
        Span<(string name, object value)> @params = [
            ("bNewValue", bNewValue)
        ];
        ProcessEvent(GetFunction("SetEnableAutoFocus"),  @params);
    }
    public void SetDesiredVideoFormat(FARVideoFormat NewFormat)
    {
        Span<(string name, object value)> @params = [
            ("NewFormat", NewFormat)
        ];
        ProcessEvent(GetFunction("SetDesiredVideoFormat"),  @params);
    }
    public void SetCandidateObjectList(ref TArray<IntPtr> InCandidateObjects)
    {
        Span<(string name, object value)> @params = [
            ("InCandidateObjects", InCandidateObjects)
        ];
        ProcessEvent(GetFunction("SetCandidateObjectList"),  @params);
    }
    public TArray<byte> GetWorldMapData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<byte>>(GetFunction("GetWorldMapData"),  @params);
    }
    public EARWorldAlignment GetWorldAlignment()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARWorldAlignment>(GetFunction("GetWorldAlignment"),  @params);
    }
    public EARSessionType GetSessionType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARSessionType>(GetFunction("GetSessionType"),  @params);
    }
    public EARSceneReconstruction GetSceneReconstructionMethod()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARSceneReconstruction>(GetFunction("GetSceneReconstructionMethod"),  @params);
    }
    public EARPlaneDetectionMode GetPlaneDetectionMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARPlaneDetectionMode>(GetFunction("GetPlaneDetectionMode"),  @params);
    }
    public int GetMaxNumSimultaneousImagesTracked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMaxNumSimultaneousImagesTracked"),  @params);
    }
    public EARLightEstimationMode GetLightEstimationMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARLightEstimationMode>(GetFunction("GetLightEstimationMode"),  @params);
    }
    public EARFrameSyncMode GetFrameSyncMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARFrameSyncMode>(GetFunction("GetFrameSyncMode"),  @params);
    }
    public EARFaceTrackingUpdate GetFaceTrackingUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARFaceTrackingUpdate>(GetFunction("GetFaceTrackingUpdate"),  @params);
    }
    public EARFaceTrackingDirection GetFaceTrackingDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARFaceTrackingDirection>(GetFunction("GetFaceTrackingDirection"),  @params);
    }
    public EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAREnvironmentCaptureProbeType>(GetFunction("GetEnvironmentCaptureProbeType"),  @params);
    }
    public EARSessionTrackingFeature GetEnabledSessionTrackingFeature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARSessionTrackingFeature>(GetFunction("GetEnabledSessionTrackingFeature"),  @params);
    }
    public FARVideoFormat GetDesiredVideoFormat()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FARVideoFormat>(GetFunction("GetDesiredVideoFormat"),  @params);
    }
    public TArray<IntPtr> GetCandidateObjectList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetCandidateObjectList"),  @params);
    }
    public TArray<IntPtr> GetCandidateImageList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetCandidateImageList"),  @params);
    }
    public void AddCandidateObject(UARCandidateObject* CandidateObject)
    {
        Span<(string name, object value)> @params = [
            ("CandidateObject", (IntPtr)CandidateObject)
        ];
        ProcessEvent(GetFunction("AddCandidateObject"),  @params);
    }
    public void AddCandidateImage(UARCandidateImage* NewCandidateImage)
    {
        Span<(string name, object value)> @params = [
            ("NewCandidateImage", (IntPtr)NewCandidateImage)
        ];
        ProcessEvent(GetFunction("AddCandidateImage"),  @params);
    }
}

public unsafe class ARSharedWorldGameMode : ObjectBase<AARSharedWorldGameMode>
{

    public void SetPreviewImageData(TArray<byte> ImageData)
    {
        Span<(string name, object value)> @params = [
            ("ImageData", ImageData)
        ];
        ProcessEvent(GetFunction("SetPreviewImageData"),  @params);
    }
    public void SetARWorldSharingIsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetARWorldSharingIsReady"),  @params);
    }
    public void SetARSharedWorldData(TArray<byte> ARWorldData)
    {
        Span<(string name, object value)> @params = [
            ("ARWorldData", ARWorldData)
        ];
        ProcessEvent(GetFunction("SetARSharedWorldData"),  @params);
    }
    public AARSharedWorldGameState* GetARSharedWorldGameState()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AARSharedWorldGameState*)ProcessEvent<IntPtr>(GetFunction("GetARSharedWorldGameState"),  @params);
    }
}

public unsafe class ARSharedWorldGameState : ObjectBase<AARSharedWorldGameState>
{

    public void K2_OnARWorldMapIsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("K2_OnARWorldMapIsReady"),  @params);
    }
}

public unsafe class ARSharedWorldPlayerController : ObjectBase<AARSharedWorldPlayerController>
{

    public void ServerMarkReadyForReceiving()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ServerMarkReadyForReceiving"),  @params);
    }
    public void ClientUpdatePreviewImageData(int Offset, ref TArray<byte> Buffer)
    {
        Span<(string name, object value)> @params = [
            ("Offset", Offset), 
            ("Buffer", Buffer)
        ];
        ProcessEvent(GetFunction("ClientUpdatePreviewImageData"),  @params);
    }
    public void ClientUpdateARWorldData(int Offset, ref TArray<byte> Buffer)
    {
        Span<(string name, object value)> @params = [
            ("Offset", Offset), 
            ("Buffer", Buffer)
        ];
        ProcessEvent(GetFunction("ClientUpdateARWorldData"),  @params);
    }
    public void ClientInitSharedWorld(int PreviewImageSize, int ARWorldDataSize)
    {
        Span<(string name, object value)> @params = [
            ("PreviewImageSize", PreviewImageSize), 
            ("ARWorldDataSize", ARWorldDataSize)
        ];
        ProcessEvent(GetFunction("ClientInitSharedWorld"),  @params);
    }
}

public unsafe class ARSkyLight : ObjectBase<AARSkyLight>
{

    public void SetEnvironmentCaptureProbe(UAREnvironmentCaptureProbe* InCaptureProbe)
    {
        Span<(string name, object value)> @params = [
            ("InCaptureProbe", (IntPtr)InCaptureProbe)
        ];
        ProcessEvent(GetFunction("SetEnvironmentCaptureProbe"),  @params);
    }
}

public unsafe class ARTexture : ObjectBase<UARTexture>
{

}

public unsafe class ARTextureCameraImage : ObjectBase<UARTextureCameraImage>
{
}

public unsafe class ARTextureCameraDepth : ObjectBase<UARTextureCameraDepth>
{

}

public unsafe class AREnvironmentCaptureProbeTexture : ObjectBase<UAREnvironmentCaptureProbeTexture>
{

}

public unsafe class ARTraceResultDummy : ObjectBase<UARTraceResultDummy>
{
}

public unsafe class ARTrackedGeometry : ObjectBase<UARTrackedGeometry>
{

    public bool IsTracked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTracked"),  @params);
    }
    public bool HasSpatialMeshUsageFlag(EARSpatialMeshUsageFlags inFlag)
    {
        Span<(string name, object value)> @params = [
            ("inFlag", inFlag)
        ];
        return ProcessEvent<bool>(GetFunction("HasSpatialMeshUsageFlag"),  @params);
    }
    public UMRMeshComponent* GetUnderlyingMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMRMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetUnderlyingMesh"),  @params);
    }
    public EARTrackingState GetTrackingState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARTrackingState>(GetFunction("GetTrackingState"),  @params);
    }
    public EARObjectClassification GetObjectClassification()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARObjectClassification>(GetFunction("GetObjectClassification"),  @params);
    }
    public FString GetName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetName"),  @params);
    }
    public FTransform GetLocalToWorldTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToWorldTransform"),  @params);
    }
    public FTransform GetLocalToTrackingTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalToTrackingTransform"),  @params);
    }
    public float GetLastUpdateTimestamp()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLastUpdateTimestamp"),  @params);
    }
    public int GetLastUpdateFrameNumber()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetLastUpdateFrameNumber"),  @params);
    }
    public FName GetDebugName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetDebugName"),  @params);
    }
}

public unsafe class ARPlaneGeometry : ObjectBase<UARPlaneGeometry>
{

    public UARPlaneGeometry* GetSubsumedBy()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARPlaneGeometry*)ProcessEvent<IntPtr>(GetFunction("GetSubsumedBy"),  @params);
    }
    public EARPlaneOrientation GetOrientation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARPlaneOrientation>(GetFunction("GetOrientation"),  @params);
    }
    public FVector GetExtent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetExtent"),  @params);
    }
    public FVector GetCenter()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetCenter"),  @params);
    }
    public TArray<FVector> GetBoundaryPolygonInLocalSpace()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetBoundaryPolygonInLocalSpace"),  @params);
    }
}

public unsafe class ARTrackedPoint : ObjectBase<UARTrackedPoint>
{
}

public unsafe class ARTrackedImage : ObjectBase<UARTrackedImage>
{

    public FVector2D GetEstimateSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetEstimateSize"),  @params);
    }
    public UARCandidateImage* GetDetectedImage()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARCandidateImage*)ProcessEvent<IntPtr>(GetFunction("GetDetectedImage"),  @params);
    }
}

public unsafe class ARTrackedQRCode : ObjectBase<UARTrackedQRCode>
{

}

public unsafe class ARFaceGeometry : ObjectBase<UARFaceGeometry>
{

    public FTransform GetWorldSpaceEyeTransform(EAREye Eye)
    {
        Span<(string name, object value)> @params = [
            ("Eye", Eye)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetWorldSpaceEyeTransform"),  @params);
    }
    public FTransform GetLocalSpaceEyeTransform(EAREye Eye)
    {
        Span<(string name, object value)> @params = [
            ("Eye", Eye)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetLocalSpaceEyeTransform"),  @params);
    }
    public float GetBlendShapeValue(EARFaceBlendShape BlendShape)
    {
        Span<(string name, object value)> @params = [
            ("BlendShape", BlendShape)
        ];
        return ProcessEvent<float>(GetFunction("GetBlendShapeValue"),  @params);
    }
    public TMap<EARFaceBlendShape, float> GetBlendShapes()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TMap<EARFaceBlendShape, float>>(GetFunction("GetBlendShapes"),  @params);
    }
}

public unsafe class AREnvironmentCaptureProbe : ObjectBase<UAREnvironmentCaptureProbe>
{

    public FVector GetExtent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetExtent"),  @params);
    }
    public UAREnvironmentCaptureProbeTexture* GetEnvironmentCaptureTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAREnvironmentCaptureProbeTexture*)ProcessEvent<IntPtr>(GetFunction("GetEnvironmentCaptureTexture"),  @params);
    }
}

public unsafe class ARTrackedObject : ObjectBase<UARTrackedObject>
{

    public UARCandidateObject* GetDetectedObject()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UARCandidateObject*)ProcessEvent<IntPtr>(GetFunction("GetDetectedObject"),  @params);
    }
}

public unsafe class ARPose3D : ObjectBase<FARPose3D>
{

}

public unsafe class ARTrackedPose : ObjectBase<UARTrackedPose>
{

    public FARPose3D GetTrackedPoseData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FARPose3D>(GetFunction("GetTrackedPoseData"),  @params);
    }
}

public unsafe class ARMeshGeometry : ObjectBase<UARMeshGeometry>
{

    public bool GetObjectClassificationAtLocation(ref FVector InWorldLocation, ref EARObjectClassification OutClassification, ref FVector OutClassificationLocation, float MaxLocationDiff)
    {
        Span<(string name, object value)> @params = [
            ("InWorldLocation", InWorldLocation), 
            ("OutClassification", OutClassification), 
            ("OutClassificationLocation", OutClassificationLocation), 
            ("MaxLocationDiff", MaxLocationDiff)
        ];
        return ProcessEvent<bool>(GetFunction("GetObjectClassificationAtLocation"),  @params);
    }
}

public unsafe class ARGeoAnchor : ObjectBase<UARGeoAnchor>
{

    public float GetLongitude()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLongitude"),  @params);
    }
    public float GetLatitude()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLatitude"),  @params);
    }
    public EARAltitudeSource GetAltitudeSource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARAltitudeSource>(GetFunction("GetAltitudeSource"),  @params);
    }
    public float GetAltitudeMeters()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAltitudeMeters"),  @params);
    }
}

public unsafe class ARTrackableNotifyComponent : ObjectBase<UARTrackableNotifyComponent>
{

}

public unsafe class ARTypesDummyClass : ObjectBase<UARTypesDummyClass>
{
}

public unsafe class ARCandidateImage : ObjectBase<UARCandidateImage>
{

    public float GetPhysicalWidth()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPhysicalWidth"),  @params);
    }
    public float GetPhysicalHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPhysicalHeight"),  @params);
    }
    public EARCandidateImageOrientation GetOrientation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EARCandidateImageOrientation>(GetFunction("GetOrientation"),  @params);
    }
    public FString GetFriendlyName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetFriendlyName"),  @params);
    }
    public UTexture2D* GetCandidateTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture2D*)ProcessEvent<IntPtr>(GetFunction("GetCandidateTexture"),  @params);
    }
}

public unsafe class ARCandidateObject : ObjectBase<UARCandidateObject>
{

    public void SetFriendlyName(FString NewName)
    {
        Span<(string name, object value)> @params = [
            ("NewName", NewName)
        ];
        ProcessEvent(GetFunction("SetFriendlyName"),  @params);
    }
    public void SetCandidateObjectData(ref TArray<byte> InCandidateObject)
    {
        Span<(string name, object value)> @params = [
            ("InCandidateObject", InCandidateObject)
        ];
        ProcessEvent(GetFunction("SetCandidateObjectData"),  @params);
    }
    public void SetBoundingBox(ref FBox InBoundingBox)
    {
        Span<(string name, object value)> @params = [
            ("InBoundingBox", InBoundingBox)
        ];
        ProcessEvent(GetFunction("SetBoundingBox"),  @params);
    }
    public FString GetFriendlyName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetFriendlyName"),  @params);
    }
    public TArray<byte> GetCandidateObjectData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<byte>>(GetFunction("GetCandidateObjectData"),  @params);
    }
    public FBox GetBoundingBox()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBox>(GetFunction("GetBoundingBox"),  @params);
    }
}

public unsafe class TrackedGeometryGroup : ObjectBase<FTrackedGeometryGroup>
{

}

public unsafe class ARSessionPayload : ObjectBase<FARSessionPayload>
{

}

public unsafe class ARSharedWorldReplicationState : ObjectBase<FARSharedWorldReplicationState>
{

}

public unsafe class ARSkeletonDefinition : ObjectBase<FARSkeletonDefinition>
{

}

