using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AARActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FARTraceResult
{
    [FieldOffset(0x0000)] public float DistanceFromCamera;
    [FieldOffset(0x0004)] public EARLineTraceChannels TraceChannel;
    [FieldOffset(0x0010)] public FTransform LocalTransform;
    [FieldOffset(0x0040)] public UARTrackedGeometry* TrackedGeometry;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FARVideoFormat
{
    [FieldOffset(0x0000)] public int FPS;
    [FieldOffset(0x0004)] public int Width;
    [FieldOffset(0x0008)] public int Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FARCameraIntrinsics
{
    [FieldOffset(0x0000)] public FIntPoint ImageResolution;
    [FieldOffset(0x0008)] public FVector2D FocalLength;
    [FieldOffset(0x0010)] public FVector2D PrincipalPoint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FARSessionStatus
{
    [FieldOffset(0x0000)] public FString AdditionalInfo;
    [FieldOffset(0x0010)] public EARSessionStatus Status;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FARSkeletonDefinition
{
    [FieldOffset(0x0000)] public int NumJoints;
    [FieldOffset(0x0008)] public TArray<FName> JointNames;
    [FieldOffset(0x0018)] public TArray<int> ParentIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FARPose2D
{
    [FieldOffset(0x0000)] public FARSkeletonDefinition SkeletonDefinition;
    [FieldOffset(0x0028)] public TArray<FVector2D> JointLocations;
    [FieldOffset(0x0038)] public TArray<bool> IsJointTracked;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARTraceResultLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UARBaseAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UARSaveWorldAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UARBaseAsyncTaskBlueprintProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UARGetCandidateObjectAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UARBaseAsyncTaskBlueprintProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UARComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FGuid NativeID;
    [FieldOffset(0x0238)] public bool bUseDefaultReplication;
    [FieldOffset(0x0240)] public UMaterialInterface* DefaultMeshMaterial;
    [FieldOffset(0x0248)] public UMaterialInterface* DefaultWireframeMeshMaterial;
    [FieldOffset(0x0250)] public UMRMeshComponent* MRMeshComponent;
    [FieldOffset(0x0258)] public UARTrackedGeometry* MyTrackedGeometry;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FARSessionPayload
{
    [FieldOffset(0x0000)] public int ConfigFlags;
    [FieldOffset(0x0008)] public UMaterialInterface* DefaultMeshMaterial;
    [FieldOffset(0x0010)] public UMaterialInterface* DefaultWireframeMeshMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FARPlaneUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0020)] public FTransform WorldTransform;
    [FieldOffset(0x0050)] public FVector Center;
    [FieldOffset(0x005C)] public FVector Extents;
    [FieldOffset(0x0068)] public TArray<FVector> BoundaryVertices;
    [FieldOffset(0x0078)] public EARObjectClassification ObjectClassification;
}

[StructLayout(LayoutKind.Explicit, Size = 0x300)] 
public unsafe struct UARPlaneComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARPlaneUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FARPointUpdatePayload
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UARPointComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0278)] public FARPointUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FARFaceUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0018)] public FVector LeftEyePosition;
    [FieldOffset(0x0024)] public FVector RightEyePosition;
    [FieldOffset(0x0030)] public FVector LookAtTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UARFaceComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0278)] public EARFaceTransformMixing TransformSetting;
    [FieldOffset(0x0279)] public bool bUpdateVertexNormal;
    [FieldOffset(0x027A)] public bool bFaceOutOfScreen;
    [FieldOffset(0x0280)] public FARFaceUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FARImageUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0020)] public FTransform WorldTransform;
    [FieldOffset(0x0050)] public UARCandidateImage* DetectedImage;
    [FieldOffset(0x0058)] public FVector2D EstimatedSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UARImageComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARImageUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FARQRCodeUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0020)] public FTransform WorldTransform;
    [FieldOffset(0x0050)] public FVector Extents;
    [FieldOffset(0x0060)] public FString QRCode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct UARQRCodeComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARQRCodeUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FARPoseUpdatePayload
{
    [FieldOffset(0x0000)] public FTransform WorldTransform;
    [FieldOffset(0x0030)] public TArray<FTransform> JointTransforms;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UARPoseComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARPoseUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAREnvironmentProbeUpdatePayload
{
    [FieldOffset(0x0000)] public FTransform WorldTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct UAREnvironmentProbeComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FAREnvironmentProbeUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FARObjectUpdatePayload
{
    [FieldOffset(0x0000)] public FTransform WorldTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct UARObjectComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARObjectUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FARMeshUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0020)] public FTransform WorldTransform;
    [FieldOffset(0x0050)] public EARObjectClassification ObjectClassification;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UARMeshComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARMeshUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FARGeoAnchorUpdatePayload
{
    [FieldOffset(0x0000)] public FARSessionPayload SessionPayload;
    [FieldOffset(0x0020)] public FTransform WorldTransform;
    [FieldOffset(0x0050)] public float Longitude;
    [FieldOffset(0x0054)] public float Latitude;
    [FieldOffset(0x0058)] public float AltitudeMeters;
    [FieldOffset(0x005C)] public EARAltitudeSource AltitudeSource;
    [FieldOffset(0x0060)] public FString AnchorName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct UARGeoAnchorComponent
{
    [FieldOffset(0x0000)] public UARComponent baseObj;
    [FieldOffset(0x0280)] public FARGeoAnchorUpdatePayload ReplicatedPayload;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARDependencyHandler
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARGeoTrackingSupport
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UARBaseAsyncTaskBlueprintProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UGetGeoLocationAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UARBaseAsyncTaskBlueprintProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UARLifeCycleComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARLightEstimate
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UARBasicLightEstimate
{
    [FieldOffset(0x0000)] public UARLightEstimate baseObj;
    [FieldOffset(0x0028)] public float AmbientIntensityLumens;
    [FieldOffset(0x002C)] public float AmbientColorTemperatureKelvin;
    [FieldOffset(0x0030)] public FLinearColor AmbientColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AAROriginActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UARPin
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UARTrackedGeometry* TrackedGeometry;
    [FieldOffset(0x0030)] public USceneComponent* PinnedComponent;
    [FieldOffset(0x0040)] public FTransform LocalToTrackingTransform;
    [FieldOffset(0x0070)] public FTransform LocalToAlignedTrackingTransform;
    [FieldOffset(0x00A0)] public EARTrackingState TrackingState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UARSessionConfig
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public bool bGenerateMeshDataFromTrackedGeometry;
    [FieldOffset(0x0031)] public bool bGenerateCollisionForMeshData;
    [FieldOffset(0x0032)] public bool bGenerateNavMeshForMeshData;
    [FieldOffset(0x0033)] public bool bUseMeshDataForOcclusion;
    [FieldOffset(0x0034)] public bool bRenderMeshDataInWireframe;
    [FieldOffset(0x0035)] public bool bTrackSceneObjects;
    [FieldOffset(0x0036)] public bool bUsePersonSegmentationForOcclusion;
    [FieldOffset(0x0037)] public bool bUseSceneDepthForOcclusion;
    [FieldOffset(0x0038)] public bool bUseAutomaticImageScaleEstimation;
    [FieldOffset(0x0039)] public bool bUseStandardOnboardingUX;
    [FieldOffset(0x003A)] public EARWorldAlignment WorldAlignment;
    [FieldOffset(0x003B)] public EARSessionType SessionType;
    [FieldOffset(0x003C)] public EARPlaneDetectionMode PlaneDetectionMode;
    [FieldOffset(0x003D)] public bool bHorizontalPlaneDetection;
    [FieldOffset(0x003E)] public bool bVerticalPlaneDetection;
    [FieldOffset(0x003F)] public bool bEnableAutoFocus;
    [FieldOffset(0x0040)] public EARLightEstimationMode LightEstimationMode;
    [FieldOffset(0x0041)] public EARFrameSyncMode FrameSyncMode;
    [FieldOffset(0x0042)] public bool bEnableAutomaticCameraOverlay;
    [FieldOffset(0x0043)] public bool bEnableAutomaticCameraTracking;
    [FieldOffset(0x0044)] public bool bResetCameraTracking;
    [FieldOffset(0x0045)] public bool bResetTrackedObjects;
    [FieldOffset(0x0048)] public TArray<IntPtr> CandidateImages;
    [FieldOffset(0x0058)] public int MaxNumSimultaneousImagesTracked;
    [FieldOffset(0x005C)] public EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType;
    [FieldOffset(0x0060)] public TArray<byte> WorldMapData;
    [FieldOffset(0x0070)] public TArray<IntPtr> CandidateObjects;
    [FieldOffset(0x0080)] public FARVideoFormat DesiredVideoFormat;
    [FieldOffset(0x008C)] public bool bUseOptimalVideoFormat;
    [FieldOffset(0x008D)] public EARFaceTrackingDirection FaceTrackingDirection;
    [FieldOffset(0x008E)] public EARFaceTrackingUpdate FaceTrackingUpdate;
    [FieldOffset(0x0090)] public int MaxNumberOfTrackedFaces;
    [FieldOffset(0x0098)] public TArray<byte> SerializedARCandidateImageDatabase;
    [FieldOffset(0x00A8)] public EARSessionTrackingFeature EnabledSessionTrackingFeature;
    [FieldOffset(0x00A9)] public EARSceneReconstruction SceneReconstructionMethod;
    [FieldOffset(0x00B0)] public TSubclassOf<UARPlaneComponent> PlaneComponentClass;
    [FieldOffset(0x00B8)] public TSubclassOf<UARPointComponent> PointComponentClass;
    [FieldOffset(0x00C0)] public TSubclassOf<UARFaceComponent> FaceComponentClass;
    [FieldOffset(0x00C8)] public TSubclassOf<UARImageComponent> ImageComponentClass;
    [FieldOffset(0x00D0)] public TSubclassOf<UARQRCodeComponent> QRCodeComponentClass;
    [FieldOffset(0x00D8)] public TSubclassOf<UARPoseComponent> PoseComponentClass;
    [FieldOffset(0x00E0)] public TSubclassOf<UAREnvironmentProbeComponent> EnvironmentProbeComponentClass;
    [FieldOffset(0x00E8)] public TSubclassOf<UARObjectComponent> ObjectComponentClass;
    [FieldOffset(0x00F0)] public TSubclassOf<UARMeshComponent> MeshComponentClass;
    [FieldOffset(0x00F8)] public TSubclassOf<UARGeoAnchorComponent> GeoAnchorComponentClass;
    [FieldOffset(0x0100)] public UMaterialInterface* DefaultMeshMaterial;
    [FieldOffset(0x0108)] public UMaterialInterface* DefaultWireframeMeshMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct AARSharedWorldGameMode
{
    [FieldOffset(0x0000)] public AGameMode baseObj;
    [FieldOffset(0x0308)] public int BufferSizePerChunk;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct AARSharedWorldGameState
{
    [FieldOffset(0x0000)] public AGameState baseObj;
    [FieldOffset(0x0290)] public TArray<byte> PreviewImageData;
    [FieldOffset(0x02A0)] public TArray<byte> ARWorldData;
    [FieldOffset(0x02B0)] public int PreviewImageBytesTotal;
    [FieldOffset(0x02B4)] public int ARWorldBytesTotal;
    [FieldOffset(0x02B8)] public int PreviewImageBytesDelivered;
    [FieldOffset(0x02BC)] public int ARWorldBytesDelivered;
}

[StructLayout(LayoutKind.Explicit, Size = 0x588)] 
public unsafe struct AARSharedWorldPlayerController
{
    [FieldOffset(0x0000)] public APlayerController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct AARSkyLight
{
    [FieldOffset(0x0000)] public ASkyLight baseObj;
    [FieldOffset(0x0230)] public UAREnvironmentCaptureProbe* CaptureProbe;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UARTexture
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0178)] public EARTextureType TextureType;
    [FieldOffset(0x017C)] public float Timestamp;
    [FieldOffset(0x0180)] public FGuid ExternalTextureGuid;
    [FieldOffset(0x0190)] public FVector2D Size;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UARTextureCameraImage
{
    [FieldOffset(0x0000)] public UARTexture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UARTextureCameraDepth
{
    [FieldOffset(0x0000)] public UARTexture baseObj;
    [FieldOffset(0x0198)] public EARDepthQuality DepthQuality;
    [FieldOffset(0x0199)] public EARDepthAccuracy DepthAccuracy;
    [FieldOffset(0x019A)] public bool bIsTemporallySmoothed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct UAREnvironmentCaptureProbeTexture
{
    [FieldOffset(0x0000)] public UTextureCube baseObj;
    [FieldOffset(0x01D0)] public EARTextureType TextureType;
    [FieldOffset(0x01D4)] public float Timestamp;
    [FieldOffset(0x01D8)] public FGuid ExternalTextureGuid;
    [FieldOffset(0x01E8)] public FVector2D Size;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARTraceResultDummy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UARTrackedGeometry
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FGuid UniqueId;
    [FieldOffset(0x0040)] public FTransform LocalToTrackingTransform;
    [FieldOffset(0x0070)] public FTransform LocalToAlignedTrackingTransform;
    [FieldOffset(0x00A0)] public EARTrackingState TrackingState;
    [FieldOffset(0x00B0)] public UMRMeshComponent* UnderlyingMesh;
    [FieldOffset(0x00B8)] public EARObjectClassification ObjectClassification;
    [FieldOffset(0x00B9)] public EARSpatialMeshUsageFlags SpatialMeshUsageFlags;
    [FieldOffset(0x00D0)] public int LastUpdateFrameNumber;
    [FieldOffset(0x00E0)] public FName DebugName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UARPlaneGeometry
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public EARPlaneOrientation Orientation;
    [FieldOffset(0x00FC)] public FVector Center;
    [FieldOffset(0x0108)] public FVector Extent;
    [FieldOffset(0x0118)] public TArray<FVector> BoundaryPolygon;
    [FieldOffset(0x0128)] public UARPlaneGeometry* SubsumedBy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UARTrackedPoint
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UARTrackedImage
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public UARCandidateImage* DetectedImage;
    [FieldOffset(0x0100)] public FVector2D EstimatedSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UARTrackedQRCode
{
    [FieldOffset(0x0000)] public UARTrackedImage baseObj;
    [FieldOffset(0x0108)] public FString QRCode;
    [FieldOffset(0x0118)] public int Version;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct UARFaceGeometry
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public FVector LookAtTarget;
    [FieldOffset(0x0104)] public bool bIsTracked;
    [FieldOffset(0x0108)] public TMap<EARFaceBlendShape, float> BlendShapes;
    [FieldOffset(0x0190)] public FTransform LeftEyeTransform;
    [FieldOffset(0x01C0)] public FTransform RightEyeTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UAREnvironmentCaptureProbe
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public FVector Extent;
    [FieldOffset(0x0108)] public UAREnvironmentCaptureProbeTexture* EnvironmentCaptureTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UARTrackedObject
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public UARCandidateObject* DetectedObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FARPose3D
{
    [FieldOffset(0x0000)] public FARSkeletonDefinition SkeletonDefinition;
    [FieldOffset(0x0028)] public TArray<FTransform> JointTransforms;
    [FieldOffset(0x0038)] public TArray<bool> IsJointTracked;
    [FieldOffset(0x0048)] public EARJointTransformSpace JointTransformSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UARTrackedPose
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
    [FieldOffset(0x00F8)] public FARPose3D TrackedPose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UARMeshGeometry
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UARGeoAnchor
{
    [FieldOffset(0x0000)] public UARTrackedGeometry baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UARTrackableNotifyComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UARTypesDummyClass
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UARCandidateImage
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public UTexture2D* CandidateTexture;
    [FieldOffset(0x0038)] public FString FriendlyName;
    [FieldOffset(0x0048)] public float Width;
    [FieldOffset(0x004C)] public float Height;
    [FieldOffset(0x0050)] public EARCandidateImageOrientation Orientation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UARCandidateObject
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<byte> CandidateObjectData;
    [FieldOffset(0x0040)] public FString FriendlyName;
    [FieldOffset(0x0050)] public FBox BoundingBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTrackedGeometryGroup
{
    [FieldOffset(0x0000)] public AARActor* ARActor;
    [FieldOffset(0x0008)] public UARComponent* ARComponent;
    [FieldOffset(0x0010)] public UARTrackedGeometry* TrackedGeometry;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FARSharedWorldReplicationState
{
    [FieldOffset(0x0000)] public int PreviewImageOffset;
    [FieldOffset(0x0004)] public int ARWorldOffset;
}

