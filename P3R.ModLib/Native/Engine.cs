using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTickFunction
{
    [FieldOffset(0x0008)] public ETickingGroup TickGroup;
    [FieldOffset(0x0009)] public ETickingGroup EndTickGroup;
    [FieldOffset(0x000A)] public byte bTickEvenWhenPaused;
    [FieldOffset(0x000A)] public byte bCanEverTick;
    [FieldOffset(0x000A)] public byte bStartWithTickEnabled;
    [FieldOffset(0x000A)] public byte bAllowTickOnDedicatedServer;
    [FieldOffset(0x000C)] public float TickInterval;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FActorTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FRepMovement
{
    [FieldOffset(0x0000)] public FVector LinearVelocity;
    [FieldOffset(0x000C)] public FVector AngularVelocity;
    [FieldOffset(0x0018)] public FVector Location;
    [FieldOffset(0x0024)] public FRotator Rotation;
    [FieldOffset(0x0030)] public byte bSimulatedPhysicSleep;
    [FieldOffset(0x0030)] public byte bRepPhysics;
    [FieldOffset(0x0031)] public EVectorQuantization LocationQuantizationLevel;
    [FieldOffset(0x0032)] public EVectorQuantization VelocityQuantizationLevel;
    [FieldOffset(0x0033)] public ERotatorQuantization RotationQuantizationLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVector_NetQuantize100
{
    [FieldOffset(0x0000)] public FVector baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRepAttachment
{
    [FieldOffset(0x0000)] public AActor* AttachParent;
    [FieldOffset(0x0008)] public FVector_NetQuantize100 LocationOffset;
    [FieldOffset(0x0014)] public FVector_NetQuantize100 RelativeScale3D;
    [FieldOffset(0x0020)] public FRotator RotationOffset;
    [FieldOffset(0x002C)] public FName AttachSocket;
    [FieldOffset(0x0038)] public USceneComponent* AttachComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVector_NetQuantize
{
    [FieldOffset(0x0000)] public FVector baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVector_NetQuantizeNormal
{
    [FieldOffset(0x0000)] public FVector baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FHitResult
{
    [FieldOffset(0x0000)] public int FaceIndex;
    [FieldOffset(0x0004)] public float Time;
    [FieldOffset(0x0008)] public float Distance;
    [FieldOffset(0x000C)] public FVector_NetQuantize Location;
    [FieldOffset(0x0018)] public FVector_NetQuantize ImpactPoint;
    [FieldOffset(0x0024)] public FVector_NetQuantizeNormal Normal;
    [FieldOffset(0x0030)] public FVector_NetQuantizeNormal ImpactNormal;
    [FieldOffset(0x003C)] public FVector_NetQuantize TraceStart;
    [FieldOffset(0x0048)] public FVector_NetQuantize TraceEnd;
    [FieldOffset(0x0054)] public float PenetrationDepth;
    [FieldOffset(0x0058)] public int Item;
    [FieldOffset(0x005C)] public byte ElementIndex;
    [FieldOffset(0x005D)] public byte bBlockingHit;
    [FieldOffset(0x005D)] public byte bStartPenetrating;
    [FieldOffset(0x0060)] public TWeakObjectPtr<UPhysicalMaterial> PhysMaterial;
    [FieldOffset(0x0068)] public TWeakObjectPtr<AActor> Actor;
    [FieldOffset(0x0070)] public TWeakObjectPtr<UPrimitiveComponent> Component;
    [FieldOffset(0x0078)] public FName BoneName;
    [FieldOffset(0x0080)] public FName MyBoneName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AActor
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FActorTickFunction PrimaryActorTick;
    [FieldOffset(0x0058)] public byte bNetTemporary;
    [FieldOffset(0x0058)] public byte bNetStartup;
    [FieldOffset(0x0058)] public byte bOnlyRelevantToOwner;
    [FieldOffset(0x0058)] public byte bAlwaysRelevant;
    [FieldOffset(0x0058)] public byte bReplicateMovement;
    [FieldOffset(0x0058)] public byte bHidden;
    [FieldOffset(0x0058)] public byte bTearOff;
    [FieldOffset(0x0058)] public byte bForceNetAddressable;
    [FieldOffset(0x0059)] public byte bExchangedRoles;
    [FieldOffset(0x0059)] public byte bNetLoadOnClient;
    [FieldOffset(0x0059)] public byte bNetUseOwnerRelevancy;
    [FieldOffset(0x0059)] public byte bRelevantForNetworkReplays;
    [FieldOffset(0x0059)] public byte bRelevantForLevelBounds;
    [FieldOffset(0x0059)] public byte bReplayRewindable;
    [FieldOffset(0x0059)] public byte bAllowTickBeforeBeginPlay;
    [FieldOffset(0x0059)] public byte bAutoDestroyWhenFinished;
    [FieldOffset(0x005A)] public byte bCanBeDamaged;
    [FieldOffset(0x005A)] public byte bBlockInput;
    [FieldOffset(0x005A)] public byte bCollideWhenPlacing;
    [FieldOffset(0x005A)] public byte bFindCameraComponentWhenViewTarget;
    [FieldOffset(0x005A)] public byte bGenerateOverlapEventsDuringLevelStreaming;
    [FieldOffset(0x005A)] public byte bIgnoresOriginShifting;
    [FieldOffset(0x005A)] public byte bEnableAutoLODGeneration;
    [FieldOffset(0x005A)] public byte bIsEditorOnlyActor;
    [FieldOffset(0x005B)] public byte bActorSeamlessTraveled;
    [FieldOffset(0x005B)] public byte bReplicates;
    [FieldOffset(0x005B)] public byte bCanBeInCluster;
    [FieldOffset(0x005B)] public byte bAllowReceiveTickEventOnDedicatedServer;
    [FieldOffset(0x005C)] public byte bActorEnableCollision;
    [FieldOffset(0x005C)] public byte bActorIsBeingDestroyed;
    [FieldOffset(0x005D)] public EActorUpdateOverlapsMethod UpdateOverlapsMethodDuringLevelStreaming;
    [FieldOffset(0x005E)] public EActorUpdateOverlapsMethod DefaultUpdateOverlapsMethodDuringLevelStreaming;
    [FieldOffset(0x005F)] public ENetRole RemoteRole;
    [FieldOffset(0x0060)] public FRepMovement ReplicatedMovement;
    [FieldOffset(0x0094)] public float InitialLifeSpan;
    [FieldOffset(0x0098)] public float CustomTimeDilation;
    [FieldOffset(0x00A0)] public FRepAttachment AttachmentReplication;
    [FieldOffset(0x00E0)] public AActor* Owner;
    [FieldOffset(0x00E8)] public FName NetDriverName;
    [FieldOffset(0x00F0)] public ENetRole Role;
    [FieldOffset(0x00F1)] public ENetDormancy NetDormancy;
    [FieldOffset(0x00F2)] public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod;
    [FieldOffset(0x00F3)] public EAutoReceiveInput AutoReceiveInput;
    [FieldOffset(0x00F4)] public int InputPriority;
    [FieldOffset(0x00F8)] public UInputComponent* InputComponent;
    [FieldOffset(0x0100)] public float NetCullDistanceSquared;
    [FieldOffset(0x0104)] public int NetTag;
    [FieldOffset(0x0108)] public float NetUpdateFrequency;
    [FieldOffset(0x010C)] public float MinNetUpdateFrequency;
    [FieldOffset(0x0110)] public float NetPriority;
    [FieldOffset(0x0118)] public APawn* Instigator;
    [FieldOffset(0x0120)] public TArray<IntPtr> Children;
    [FieldOffset(0x0130)] public USceneComponent* RootComponent;
    [FieldOffset(0x0138)] public TArray<IntPtr> ControllingMatineeActors;
    [FieldOffset(0x0150)] public TArray<FName> Layers;
    [FieldOffset(0x0160)] public TWeakObjectPtr<UChildActorComponent> ParentComponent;
    [FieldOffset(0x0170)] public TArray<FName> Tags;
    [FieldOffset(0x01F0)] public TArray<IntPtr> InstanceComponents;
    [FieldOffset(0x0200)] public TArray<IntPtr> BlueprintCreatedComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FActorComponentTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSimpleMemberReference
{
    [FieldOffset(0x0000)] public UObject* MemberParent;
    [FieldOffset(0x0008)] public FName MemberName;
    [FieldOffset(0x0010)] public FGuid MemberGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UActorComponent
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FActorComponentTickFunction PrimaryComponentTick;
    [FieldOffset(0x0060)] public TArray<FName> ComponentTags;
    [FieldOffset(0x0070)] public TArray<IntPtr> AssetUserData;
    [FieldOffset(0x0084)] public int UCSSerializationIndex;
    [FieldOffset(0x0088)] public byte bNetAddressable;
    [FieldOffset(0x0088)] public byte bReplicates;
    [FieldOffset(0x0089)] public byte bAutoActivate;
    [FieldOffset(0x008A)] public byte bIsActive;
    [FieldOffset(0x008A)] public byte bEditableWhenInherited;
    [FieldOffset(0x008A)] public byte bCanEverAffectNavigation;
    [FieldOffset(0x008A)] public byte bIsEditorOnly;
    [FieldOffset(0x008C)] public EComponentCreationMethod CreationMethod;
    [FieldOffset(0x0090)] public TArray<FSimpleMemberReference> UCSModifiedProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct USceneComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B8)] public TWeakObjectPtr<APhysicsVolume> PhysicsVolume;
    [FieldOffset(0x00C0)] public USceneComponent* AttachParent;
    [FieldOffset(0x00C8)] public FName AttachSocketName;
    [FieldOffset(0x00D0)] public TArray<IntPtr> AttachChildren;
    [FieldOffset(0x00E0)] public TArray<IntPtr> ClientAttachedChildren;
    [FieldOffset(0x011C)] public FVector RelativeLocation;
    [FieldOffset(0x0128)] public FRotator RelativeRotation;
    [FieldOffset(0x0134)] public FVector RelativeScale3D;
    [FieldOffset(0x0140)] public FVector ComponentVelocity;
    [FieldOffset(0x014C)] public byte bComponentToWorldUpdated;
    [FieldOffset(0x014C)] public byte bAbsoluteLocation;
    [FieldOffset(0x014C)] public byte bAbsoluteRotation;
    [FieldOffset(0x014C)] public byte bAbsoluteScale;
    [FieldOffset(0x014C)] public byte bVisible;
    [FieldOffset(0x014C)] public byte bShouldBeAttached;
    [FieldOffset(0x014C)] public byte bShouldSnapLocationWhenAttached;
    [FieldOffset(0x014D)] public byte bShouldSnapRotationWhenAttached;
    [FieldOffset(0x014D)] public byte bShouldUpdatePhysicsVolume;
    [FieldOffset(0x014D)] public byte bHiddenInGame;
    [FieldOffset(0x014D)] public byte bBoundsChangeTriggersStreamingDataRebuild;
    [FieldOffset(0x014D)] public byte bUseAttachParentBound;
    [FieldOffset(0x014F)] public EComponentMobility Mobility;
    [FieldOffset(0x0150)] public EDetailMode DetailMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FLightingChannels
{
    [FieldOffset(0x0000)] public byte bChannel0;
    [FieldOffset(0x0000)] public byte bChannel1;
    [FieldOffset(0x0000)] public byte bChannel2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCustomPrimitiveData
{
    [FieldOffset(0x0000)] public TArray<float> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCollisionResponseContainer
{
    [FieldOffset(0x0000)] public ECollisionResponse WorldStatic;
    [FieldOffset(0x0001)] public ECollisionResponse WorldDynamic;
    [FieldOffset(0x0002)] public ECollisionResponse Pawn;
    [FieldOffset(0x0003)] public ECollisionResponse Visibility;
    [FieldOffset(0x0004)] public ECollisionResponse Camera;
    [FieldOffset(0x0005)] public ECollisionResponse PhysicsBody;
    [FieldOffset(0x0006)] public ECollisionResponse Vehicle;
    [FieldOffset(0x0007)] public ECollisionResponse Destructible;
    [FieldOffset(0x0008)] public ECollisionResponse EngineTraceChannel1;
    [FieldOffset(0x0009)] public ECollisionResponse EngineTraceChannel2;
    [FieldOffset(0x000A)] public ECollisionResponse EngineTraceChannel3;
    [FieldOffset(0x000B)] public ECollisionResponse EngineTraceChannel4;
    [FieldOffset(0x000C)] public ECollisionResponse EngineTraceChannel5;
    [FieldOffset(0x000D)] public ECollisionResponse EngineTraceChannel6;
    [FieldOffset(0x000E)] public ECollisionResponse GameTraceChannel1;
    [FieldOffset(0x000F)] public ECollisionResponse GameTraceChannel2;
    [FieldOffset(0x0010)] public ECollisionResponse GameTraceChannel3;
    [FieldOffset(0x0011)] public ECollisionResponse GameTraceChannel4;
    [FieldOffset(0x0012)] public ECollisionResponse GameTraceChannel5;
    [FieldOffset(0x0013)] public ECollisionResponse GameTraceChannel6;
    [FieldOffset(0x0014)] public ECollisionResponse GameTraceChannel7;
    [FieldOffset(0x0015)] public ECollisionResponse GameTraceChannel8;
    [FieldOffset(0x0016)] public ECollisionResponse GameTraceChannel9;
    [FieldOffset(0x0017)] public ECollisionResponse GameTraceChannel10;
    [FieldOffset(0x0018)] public ECollisionResponse GameTraceChannel11;
    [FieldOffset(0x0019)] public ECollisionResponse GameTraceChannel12;
    [FieldOffset(0x001A)] public ECollisionResponse GameTraceChannel13;
    [FieldOffset(0x001B)] public ECollisionResponse GameTraceChannel14;
    [FieldOffset(0x001C)] public ECollisionResponse GameTraceChannel15;
    [FieldOffset(0x001D)] public ECollisionResponse GameTraceChannel16;
    [FieldOffset(0x001E)] public ECollisionResponse GameTraceChannel17;
    [FieldOffset(0x001F)] public ECollisionResponse GameTraceChannel18;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FResponseChannel
{
    [FieldOffset(0x0000)] public FName Channel;
    [FieldOffset(0x0008)] public ECollisionResponse Response;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCollisionResponse
{
    [FieldOffset(0x0000)] public FCollisionResponseContainer ResponseToChannels;
    [FieldOffset(0x0020)] public TArray<FResponseChannel> ResponseArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FWalkableSlopeOverride
{
    [FieldOffset(0x0000)] public EWalkableSlopeBehavior WalkableSlopeBehavior;
    [FieldOffset(0x0004)] public float WalkableSlopeAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct FBodyInstance
{
    [FieldOffset(0x0000)] public FBodyInstanceCore baseObj;
    [FieldOffset(0x001E)] public ECollisionChannel ObjectType;
    [FieldOffset(0x0020)] public ECollisionEnabled CollisionEnabled;
    [FieldOffset(0x0059)] public ESleepFamily SleepFamily;
    [FieldOffset(0x005A)] public EDOFMode DOFMode;
    [FieldOffset(0x005B)] public byte bUseCCD;
    [FieldOffset(0x005B)] public byte bIgnoreAnalyticCollisions;
    [FieldOffset(0x005B)] public byte bNotifyRigidBodyCollision;
    [FieldOffset(0x005B)] public byte bLockTranslation;
    [FieldOffset(0x005B)] public byte bLockRotation;
    [FieldOffset(0x005B)] public byte bLockXTranslation;
    [FieldOffset(0x005B)] public byte bLockYTranslation;
    [FieldOffset(0x005C)] public byte bLockZTranslation;
    [FieldOffset(0x005C)] public byte bLockXRotation;
    [FieldOffset(0x005C)] public byte bLockYRotation;
    [FieldOffset(0x005C)] public byte bLockZRotation;
    [FieldOffset(0x005C)] public byte bOverrideMaxAngularVelocity;
    [FieldOffset(0x005C)] public byte bOverrideMaxDepenetrationVelocity;
    [FieldOffset(0x005D)] public byte bOverrideWalkableSlopeOnInstance;
    [FieldOffset(0x005D)] public byte bInterpolateWhenSubStepping;
    [FieldOffset(0x006C)] public FName CollisionProfileName;
    [FieldOffset(0x0074)] public byte PositionSolverIterationCount;
    [FieldOffset(0x0075)] public byte VelocitySolverIterationCount;
    [FieldOffset(0x0078)] public FCollisionResponse CollisionResponses;
    [FieldOffset(0x00A8)] public float MaxDepenetrationVelocity;
    [FieldOffset(0x00AC)] public float MassInKgOverride;
    [FieldOffset(0x00B8)] public float LinearDamping;
    [FieldOffset(0x00BC)] public float AngularDamping;
    [FieldOffset(0x00C0)] public FVector CustomDOFPlaneNormal;
    [FieldOffset(0x00CC)] public FVector COMNudge;
    [FieldOffset(0x00D8)] public float MassScale;
    [FieldOffset(0x00DC)] public FVector InertiaTensorScale;
    [FieldOffset(0x00F8)] public FWalkableSlopeOverride WalkableSlopeOverride;
    [FieldOffset(0x0108)] public UPhysicalMaterial* PhysMaterialOverride;
    [FieldOffset(0x0110)] public float MaxAngularVelocity;
    [FieldOffset(0x0114)] public float CustomSleepThresholdMultiplier;
    [FieldOffset(0x0118)] public float StabilizationThresholdMultiplier;
    [FieldOffset(0x011C)] public float PhysicsBlendWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct UPrimitiveComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x0200)] public float MinDrawDistance;
    [FieldOffset(0x0204)] public float LDMaxDrawDistance;
    [FieldOffset(0x0208)] public float CachedMaxDrawDistance;
    [FieldOffset(0x020C)] public ESceneDepthPriorityGroup DepthPriorityGroup;
    [FieldOffset(0x020D)] public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup;
    [FieldOffset(0x020E)] public EIndirectLightingCacheQuality IndirectLightingCacheQuality;
    [FieldOffset(0x020F)] public ELightmapType LightmapType;
    [FieldOffset(0x0210)] public byte bUseMaxLODAsImposter;
    [FieldOffset(0x0210)] public byte bBatchImpostersAsInstances;
    [FieldOffset(0x0210)] public byte bNeverDistanceCull;
    [FieldOffset(0x0210)] public byte bAlwaysCreatePhysicsState;
    [FieldOffset(0x0211)] public byte bGenerateOverlapEvents;
    [FieldOffset(0x0211)] public byte bMultiBodyOverlap;
    [FieldOffset(0x0211)] public byte bTraceComplexOnMove;
    [FieldOffset(0x0211)] public byte bReturnMaterialOnMove;
    [FieldOffset(0x0211)] public byte bUseViewOwnerDepthPriorityGroup;
    [FieldOffset(0x0211)] public byte bAllowCullDistanceVolume;
    [FieldOffset(0x0211)] public byte bHasMotionBlurVelocityMeshes;
    [FieldOffset(0x0211)] public byte bVisibleInReflectionCaptures;
    [FieldOffset(0x0212)] public byte bVisibleInRealTimeSkyCaptures;
    [FieldOffset(0x0212)] public byte bVisibleInRayTracing;
    [FieldOffset(0x0212)] public byte bRenderInMainPass;
    [FieldOffset(0x0212)] public byte bRenderInDepthPass;
    [FieldOffset(0x0212)] public byte bReceivesDecals;
    [FieldOffset(0x0212)] public byte bOwnerNoSee;
    [FieldOffset(0x0212)] public byte bOnlyOwnerSee;
    [FieldOffset(0x0212)] public byte bTreatAsBackgroundForOcclusion;
    [FieldOffset(0x0213)] public byte bUseAsOccluder;
    [FieldOffset(0x0213)] public byte bSelectable;
    [FieldOffset(0x0213)] public byte bForceMipStreaming;
    [FieldOffset(0x0213)] public byte bHasPerInstanceHitProxies;
    [FieldOffset(0x0213)] public byte CastShadow;
    [FieldOffset(0x0213)] public byte bAffectDynamicIndirectLighting;
    [FieldOffset(0x0213)] public byte bAffectDistanceFieldLighting;
    [FieldOffset(0x0213)] public byte bCastDynamicShadow;
    [FieldOffset(0x0214)] public byte bCastStaticShadow;
    [FieldOffset(0x0214)] public byte bCastVolumetricTranslucentShadow;
    [FieldOffset(0x0214)] public byte bCastContactShadow;
    [FieldOffset(0x0214)] public byte bSelfShadowOnly;
    [FieldOffset(0x0214)] public byte bCastFarShadow;
    [FieldOffset(0x0214)] public byte bCastInsetShadow;
    [FieldOffset(0x0214)] public byte bCastCinematicShadow;
    [FieldOffset(0x0214)] public byte bCastHiddenShadow;
    [FieldOffset(0x0215)] public byte bCastShadowAsTwoSided;
    [FieldOffset(0x0215)] public byte bLightAsIfStatic;
    [FieldOffset(0x0215)] public byte bLightAttachmentsAsGroup;
    [FieldOffset(0x0215)] public byte bExcludeFromLightAttachmentGroup;
    [FieldOffset(0x0215)] public byte bReceiveMobileCSMShadows;
    [FieldOffset(0x0215)] public byte bSingleSampleShadowFromStationaryLights;
    [FieldOffset(0x0215)] public byte bIgnoreRadialImpulse;
    [FieldOffset(0x0215)] public byte bIgnoreRadialForce;
    [FieldOffset(0x0216)] public byte bApplyImpulseOnDamage;
    [FieldOffset(0x0216)] public byte bReplicatePhysicsToAutonomousProxy;
    [FieldOffset(0x0216)] public byte bFillCollisionUnderneathForNavmesh;
    [FieldOffset(0x0216)] public byte AlwaysLoadOnClient;
    [FieldOffset(0x0216)] public byte AlwaysLoadOnServer;
    [FieldOffset(0x0216)] public byte bUseEditorCompositing;
    [FieldOffset(0x0216)] public byte bRenderCustomDepth;
    [FieldOffset(0x0216)] public byte bVisibleInSceneCaptureOnly;
    [FieldOffset(0x0217)] public byte bHiddenInSceneCapture;
    [FieldOffset(0x0218)] public EHasCustomNavigableGeometry bHasCustomNavigableGeometry;
    [FieldOffset(0x021A)] public ECanBeCharacterBase CanCharacterStepUpOn;
    [FieldOffset(0x021B)] public FLightingChannels LightingChannels;
    [FieldOffset(0x021C)] public EShadowChannel CustomShadowChannel;
    [FieldOffset(0x021D)] public ERendererStencilMask CustomDepthStencilWriteMask;
    [FieldOffset(0x0220)] public int CustomDepthStencilValue;
    [FieldOffset(0x0228)] public FCustomPrimitiveData CustomPrimitiveData;
    [FieldOffset(0x0238)] public FCustomPrimitiveData CustomPrimitiveDataInternal;
    [FieldOffset(0x0250)] public int TranslucencySortPriority;
    [FieldOffset(0x0254)] public float TranslucencySortDistanceOffset;
    [FieldOffset(0x0258)] public int VisibilityId;
    [FieldOffset(0x0260)] public TArray<IntPtr> RuntimeVirtualTextures;
    [FieldOffset(0x0270)] public sbyte VirtualTextureLodBias;
    [FieldOffset(0x0271)] public sbyte VirtualTextureCullMips;
    [FieldOffset(0x0272)] public sbyte VirtualTextureMinCoverage;
    [FieldOffset(0x0273)] public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
    [FieldOffset(0x0278)] public float LpvBiasMultiplier;
    [FieldOffset(0x0284)] public float BoundsScale;
    [FieldOffset(0x0298)] public TArray<IntPtr> MoveIgnoreActors;
    [FieldOffset(0x02A8)] public TArray<IntPtr> MoveIgnoreComponents;
    [FieldOffset(0x02C8)] public FBodyInstance BodyInstance;
    [FieldOffset(0x0448)] public UPrimitiveComponent* LODParentPrimitive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x450)] 
public unsafe struct UFXSystemComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintFunctionLibrary
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FKeyHandleMap
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FIndexedCurve
{
    [FieldOffset(0x0008)] public FKeyHandleMap KeyHandlesToIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FRealCurve
{
    [FieldOffset(0x0000)] public FIndexedCurve baseObj;
    [FieldOffset(0x0068)] public float DefaultValue;
    [FieldOffset(0x006C)] public ERichCurveExtrapolation PreInfinityExtrap;
    [FieldOffset(0x006D)] public ERichCurveExtrapolation PostInfinityExtrap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FRichCurveKey
{
    [FieldOffset(0x0000)] public ERichCurveInterpMode InterpMode;
    [FieldOffset(0x0001)] public ERichCurveTangentMode TangentMode;
    [FieldOffset(0x0002)] public ERichCurveTangentWeightMode TangentWeightMode;
    [FieldOffset(0x0004)] public float Time;
    [FieldOffset(0x0008)] public float Value;
    [FieldOffset(0x000C)] public float ArriveTangent;
    [FieldOffset(0x0010)] public float ArriveTangentWeight;
    [FieldOffset(0x0014)] public float LeaveTangent;
    [FieldOffset(0x0018)] public float LeaveTangentWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FRichCurve
{
    [FieldOffset(0x0000)] public FRealCurve baseObj;
    [FieldOffset(0x0070)] public TArray<FRichCurveKey> Keys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UFXSystemAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public uint MaxPoolSize;
    [FieldOffset(0x002C)] public uint PoolPrimeSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAnimNotifyState
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FWeightedBlendable
{
    [FieldOffset(0x0000)] public float Weight;
    [FieldOffset(0x0008)] public UObject* Object;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FWeightedBlendables
{
    [FieldOffset(0x0000)] public TArray<FWeightedBlendable> Array;
}

[StructLayout(LayoutKind.Explicit, Size = 0x560)] 
public unsafe struct FPostProcessSettings
{
    [FieldOffset(0x0000)] public byte bOverride_TemperatureType;
    [FieldOffset(0x0000)] public byte bOverride_WhiteTemp;
    [FieldOffset(0x0000)] public byte bOverride_WhiteTint;
    [FieldOffset(0x0000)] public byte bOverride_ColorSaturation;
    [FieldOffset(0x0000)] public byte bOverride_ColorContrast;
    [FieldOffset(0x0000)] public byte bOverride_ColorGamma;
    [FieldOffset(0x0000)] public byte bOverride_ColorGain;
    [FieldOffset(0x0000)] public byte bOverride_ColorOffset;
    [FieldOffset(0x0001)] public byte bOverride_ColorSaturationShadows;
    [FieldOffset(0x0001)] public byte bOverride_ColorContrastShadows;
    [FieldOffset(0x0001)] public byte bOverride_ColorGammaShadows;
    [FieldOffset(0x0001)] public byte bOverride_ColorGainShadows;
    [FieldOffset(0x0001)] public byte bOverride_ColorOffsetShadows;
    [FieldOffset(0x0001)] public byte bOverride_ColorSaturationMidtones;
    [FieldOffset(0x0001)] public byte bOverride_ColorContrastMidtones;
    [FieldOffset(0x0001)] public byte bOverride_ColorGammaMidtones;
    [FieldOffset(0x0002)] public byte bOverride_ColorGainMidtones;
    [FieldOffset(0x0002)] public byte bOverride_ColorOffsetMidtones;
    [FieldOffset(0x0002)] public byte bOverride_ColorSaturationHighlights;
    [FieldOffset(0x0002)] public byte bOverride_ColorContrastHighlights;
    [FieldOffset(0x0002)] public byte bOverride_ColorGammaHighlights;
    [FieldOffset(0x0002)] public byte bOverride_ColorGainHighlights;
    [FieldOffset(0x0002)] public byte bOverride_ColorOffsetHighlights;
    [FieldOffset(0x0002)] public byte bOverride_ColorCorrectionShadowsMax;
    [FieldOffset(0x0003)] public byte bOverride_ColorCorrectionHighlightsMin;
    [FieldOffset(0x0003)] public byte bOverride_BlueCorrection;
    [FieldOffset(0x0003)] public byte bOverride_ExpandGamut;
    [FieldOffset(0x0003)] public byte bOverride_ToneCurveAmount;
    [FieldOffset(0x0003)] public byte bOverride_FilmWhitePoint;
    [FieldOffset(0x0003)] public byte bOverride_FilmSaturation;
    [FieldOffset(0x0003)] public byte bOverride_FilmChannelMixerRed;
    [FieldOffset(0x0003)] public byte bOverride_FilmChannelMixerGreen;
    [FieldOffset(0x0004)] public byte bOverride_FilmChannelMixerBlue;
    [FieldOffset(0x0004)] public byte bOverride_FilmContrast;
    [FieldOffset(0x0004)] public byte bOverride_FilmDynamicRange;
    [FieldOffset(0x0004)] public byte bOverride_FilmHealAmount;
    [FieldOffset(0x0004)] public byte bOverride_FilmToeAmount;
    [FieldOffset(0x0004)] public byte bOverride_FilmShadowTint;
    [FieldOffset(0x0004)] public byte bOverride_FilmShadowTintBlend;
    [FieldOffset(0x0004)] public byte bOverride_FilmShadowTintAmount;
    [FieldOffset(0x0005)] public byte bOverride_FilmSlope;
    [FieldOffset(0x0005)] public byte bOverride_FilmToe;
    [FieldOffset(0x0005)] public byte bOverride_FilmShoulder;
    [FieldOffset(0x0005)] public byte bOverride_FilmBlackClip;
    [FieldOffset(0x0005)] public byte bOverride_FilmWhiteClip;
    [FieldOffset(0x0005)] public byte bOverride_SceneColorTint;
    [FieldOffset(0x0005)] public byte bOverride_SceneFringeIntensity;
    [FieldOffset(0x0005)] public byte bOverride_ChromaticAberrationStartOffset;
    [FieldOffset(0x0006)] public byte bOverride_AmbientCubemapTint;
    [FieldOffset(0x0006)] public byte bOverride_AmbientCubemapIntensity;
    [FieldOffset(0x0006)] public byte bOverride_BloomMethod;
    [FieldOffset(0x0006)] public byte bOverride_BloomIntensity;
    [FieldOffset(0x0006)] public byte bOverride_BloomThreshold;
    [FieldOffset(0x0006)] public byte bOverride_Bloom1Tint;
    [FieldOffset(0x0006)] public byte bOverride_Bloom1Size;
    [FieldOffset(0x0006)] public byte bOverride_Bloom2Size;
    [FieldOffset(0x0007)] public byte bOverride_Bloom2Tint;
    [FieldOffset(0x0007)] public byte bOverride_Bloom3Tint;
    [FieldOffset(0x0007)] public byte bOverride_Bloom3Size;
    [FieldOffset(0x0007)] public byte bOverride_Bloom4Tint;
    [FieldOffset(0x0007)] public byte bOverride_Bloom4Size;
    [FieldOffset(0x0007)] public byte bOverride_Bloom5Tint;
    [FieldOffset(0x0007)] public byte bOverride_Bloom5Size;
    [FieldOffset(0x0007)] public byte bOverride_Bloom6Tint;
    [FieldOffset(0x0008)] public byte bOverride_Bloom6Size;
    [FieldOffset(0x0008)] public byte bOverride_BloomSizeScale;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionTexture;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionSize;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionCenterUV;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionPreFilter;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionPreFilterMin;
    [FieldOffset(0x0008)] public byte bOverride_BloomConvolutionPreFilterMax;
    [FieldOffset(0x0009)] public byte bOverride_BloomConvolutionPreFilterMult;
    [FieldOffset(0x0009)] public byte bOverride_BloomConvolutionBufferScale;
    [FieldOffset(0x0009)] public byte bOverride_BloomDirtMaskIntensity;
    [FieldOffset(0x0009)] public byte bOverride_BloomDirtMaskTint;
    [FieldOffset(0x0009)] public byte bOverride_BloomDirtMask;
    [FieldOffset(0x0009)] public byte bOverride_CameraShutterSpeed;
    [FieldOffset(0x0009)] public byte bOverride_CameraISO;
    [FieldOffset(0x0009)] public byte bOverride_AutoExposureMethod;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureLowPercent;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureHighPercent;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureMinBrightness;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureMaxBrightness;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureCalibrationConstant;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureSpeedUp;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureSpeedDown;
    [FieldOffset(0x000A)] public byte bOverride_AutoExposureBias;
    [FieldOffset(0x000B)] public byte bOverride_AutoExposureBiasCurve;
    [FieldOffset(0x000B)] public byte bOverride_AutoExposureMeterMask;
    [FieldOffset(0x000B)] public byte bOverride_AutoExposureApplyPhysicalCameraExposure;
    [FieldOffset(0x000B)] public byte bOverride_HistogramLogMin;
    [FieldOffset(0x000B)] public byte bOverride_HistogramLogMax;
    [FieldOffset(0x000B)] public byte bOverride_LensFlareIntensity;
    [FieldOffset(0x000B)] public byte bOverride_LensFlareTint;
    [FieldOffset(0x000B)] public byte bOverride_LensFlareTints;
    [FieldOffset(0x000C)] public byte bOverride_LensFlareBokehSize;
    [FieldOffset(0x000C)] public byte bOverride_LensFlareBokehShape;
    [FieldOffset(0x000C)] public byte bOverride_LensFlareThreshold;
    [FieldOffset(0x000C)] public byte bOverride_VignetteIntensity;
    [FieldOffset(0x000C)] public byte bOverride_GrainIntensity;
    [FieldOffset(0x000C)] public byte bOverride_GrainJitter;
    [FieldOffset(0x000C)] public byte bOverride_AmbientOcclusionIntensity;
    [FieldOffset(0x000C)] public byte bOverride_AmbientOcclusionStaticFraction;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionRadius;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionFadeDistance;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionFadeRadius;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionDistance;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionRadiusInWS;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionPower;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionBias;
    [FieldOffset(0x000D)] public byte bOverride_AmbientOcclusionQuality;
    [FieldOffset(0x000E)] public byte bOverride_AmbientOcclusionMipBlend;
    [FieldOffset(0x000E)] public byte bOverride_AmbientOcclusionMipScale;
    [FieldOffset(0x000E)] public byte bOverride_AmbientOcclusionMipThreshold;
    [FieldOffset(0x000E)] public byte bOverride_AmbientOcclusionTemporalBlendWeight;
    [FieldOffset(0x0010)] public byte bOverride_RayTracingAO;
    [FieldOffset(0x0010)] public byte bOverride_RayTracingAOSamplesPerPixel;
    [FieldOffset(0x0010)] public byte bOverride_RayTracingAOIntensity;
    [FieldOffset(0x0010)] public byte bOverride_RayTracingAORadius;
    [FieldOffset(0x0014)] public byte bOverride_LPVIntensity;
    [FieldOffset(0x0014)] public byte bOverride_LPVDirectionalOcclusionIntensity;
    [FieldOffset(0x0014)] public byte bOverride_LPVDirectionalOcclusionRadius;
    [FieldOffset(0x0014)] public byte bOverride_LPVDiffuseOcclusionExponent;
    [FieldOffset(0x0014)] public byte bOverride_LPVSpecularOcclusionExponent;
    [FieldOffset(0x0014)] public byte bOverride_LPVDiffuseOcclusionIntensity;
    [FieldOffset(0x0014)] public byte bOverride_LPVSpecularOcclusionIntensity;
    [FieldOffset(0x0014)] public byte bOverride_LPVSize;
    [FieldOffset(0x0015)] public byte bOverride_LPVSecondaryOcclusionIntensity;
    [FieldOffset(0x0015)] public byte bOverride_LPVSecondaryBounceIntensity;
    [FieldOffset(0x0015)] public byte bOverride_LPVGeometryVolumeBias;
    [FieldOffset(0x0015)] public byte bOverride_LPVVplInjectionBias;
    [FieldOffset(0x0015)] public byte bOverride_LPVEmissiveInjectionIntensity;
    [FieldOffset(0x0015)] public byte bOverride_LPVFadeRange;
    [FieldOffset(0x0015)] public byte bOverride_LPVDirectionalOcclusionFadeRange;
    [FieldOffset(0x0015)] public byte bOverride_IndirectLightingColor;
    [FieldOffset(0x0016)] public byte bOverride_IndirectLightingIntensity;
    [FieldOffset(0x0016)] public byte bOverride_ColorGradingIntensity;
    [FieldOffset(0x0016)] public byte bOverride_ColorGradingLUT;
    [FieldOffset(0x0016)] public byte bOverride_DepthOfFieldFocalDistance;
    [FieldOffset(0x0016)] public byte bOverride_DepthOfFieldFstop;
    [FieldOffset(0x0016)] public byte bOverride_DepthOfFieldMinFstop;
    [FieldOffset(0x0016)] public byte bOverride_DepthOfFieldBladeCount;
    [FieldOffset(0x0016)] public byte bOverride_DepthOfFieldSensorWidth;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldDepthBlurRadius;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldDepthBlurAmount;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldFocalRegion;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldNearTransitionRegion;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldFarTransitionRegion;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldScale;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldNearBlurSize;
    [FieldOffset(0x0017)] public byte bOverride_DepthOfFieldFarBlurSize;
    [FieldOffset(0x0018)] public byte bOverride_MobileHQGaussian;
    [FieldOffset(0x0018)] public byte bOverride_DepthOfFieldOcclusion;
    [FieldOffset(0x0018)] public byte bOverride_DepthOfFieldSkyFocusDistance;
    [FieldOffset(0x0018)] public byte bOverride_DepthOfFieldVignetteSize;
    [FieldOffset(0x0018)] public byte bOverride_MotionBlurAmount;
    [FieldOffset(0x0018)] public byte bOverride_MotionBlurMax;
    [FieldOffset(0x0018)] public byte bOverride_MotionBlurTargetFPS;
    [FieldOffset(0x0018)] public byte bOverride_MotionBlurPerObjectSize;
    [FieldOffset(0x0019)] public byte bOverride_ScreenPercentage;
    [FieldOffset(0x0019)] public byte bOverride_ScreenSpaceReflectionIntensity;
    [FieldOffset(0x0019)] public byte bOverride_ScreenSpaceReflectionQuality;
    [FieldOffset(0x0019)] public byte bOverride_ScreenSpaceReflectionMaxRoughness;
    [FieldOffset(0x0019)] public byte bOverride_ScreenSpaceReflectionRoughnessScale;
    [FieldOffset(0x001C)] public byte bOverride_ReflectionsType;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingReflectionsMaxRoughness;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingReflectionsMaxBounces;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingReflectionsSamplesPerPixel;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingReflectionsShadows;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingReflectionsTranslucency;
    [FieldOffset(0x001C)] public byte bOverride_TranslucencyType;
    [FieldOffset(0x001C)] public byte bOverride_RayTracingTranslucencyMaxRoughness;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingTranslucencyRefractionRays;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingTranslucencySamplesPerPixel;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingTranslucencyShadows;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingTranslucencyRefraction;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingGI;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingGIMaxBounces;
    [FieldOffset(0x001D)] public byte bOverride_RayTracingGISamplesPerPixel;
    [FieldOffset(0x001D)] public byte bOverride_PathTracingMaxBounces;
    [FieldOffset(0x001E)] public byte bOverride_PathTracingSamplesPerPixel;
    [FieldOffset(0x001E)] public byte bOverride_PathTracingFilterWidth;
    [FieldOffset(0x001E)] public byte bOverride_PathTracingEnableEmissive;
    [FieldOffset(0x001E)] public byte bOverride_PathTracingMaxPathExposure;
    [FieldOffset(0x001E)] public byte bOverride_PathTracingEnableDenoiser;
    [FieldOffset(0x0020)] public byte bMobileHQGaussian;
    [FieldOffset(0x0021)] public EBloomMethod BloomMethod;
    [FieldOffset(0x0022)] public EAutoExposureMethod AutoExposureMethod;
    [FieldOffset(0x0023)] public ETemperatureMethod TemperatureType;
    [FieldOffset(0x0024)] public float WhiteTemp;
    [FieldOffset(0x0028)] public float WhiteTint;
    [FieldOffset(0x0030)] public FVector4 ColorSaturation;
    [FieldOffset(0x0040)] public FVector4 ColorContrast;
    [FieldOffset(0x0050)] public FVector4 ColorGamma;
    [FieldOffset(0x0060)] public FVector4 ColorGain;
    [FieldOffset(0x0070)] public FVector4 ColorOffset;
    [FieldOffset(0x0080)] public FVector4 ColorSaturationShadows;
    [FieldOffset(0x0090)] public FVector4 ColorContrastShadows;
    [FieldOffset(0x00A0)] public FVector4 ColorGammaShadows;
    [FieldOffset(0x00B0)] public FVector4 ColorGainShadows;
    [FieldOffset(0x00C0)] public FVector4 ColorOffsetShadows;
    [FieldOffset(0x00D0)] public FVector4 ColorSaturationMidtones;
    [FieldOffset(0x00E0)] public FVector4 ColorContrastMidtones;
    [FieldOffset(0x00F0)] public FVector4 ColorGammaMidtones;
    [FieldOffset(0x0100)] public FVector4 ColorGainMidtones;
    [FieldOffset(0x0110)] public FVector4 ColorOffsetMidtones;
    [FieldOffset(0x0120)] public FVector4 ColorSaturationHighlights;
    [FieldOffset(0x0130)] public FVector4 ColorContrastHighlights;
    [FieldOffset(0x0140)] public FVector4 ColorGammaHighlights;
    [FieldOffset(0x0150)] public FVector4 ColorGainHighlights;
    [FieldOffset(0x0160)] public FVector4 ColorOffsetHighlights;
    [FieldOffset(0x0170)] public float ColorCorrectionHighlightsMin;
    [FieldOffset(0x0174)] public float ColorCorrectionShadowsMax;
    [FieldOffset(0x0178)] public float BlueCorrection;
    [FieldOffset(0x017C)] public float ExpandGamut;
    [FieldOffset(0x0180)] public float ToneCurveAmount;
    [FieldOffset(0x0184)] public float FilmSlope;
    [FieldOffset(0x0188)] public float FilmToe;
    [FieldOffset(0x018C)] public float FilmShoulder;
    [FieldOffset(0x0190)] public float FilmBlackClip;
    [FieldOffset(0x0194)] public float FilmWhiteClip;
    [FieldOffset(0x0198)] public FLinearColor FilmWhitePoint;
    [FieldOffset(0x01A8)] public FLinearColor FilmShadowTint;
    [FieldOffset(0x01B8)] public float FilmShadowTintBlend;
    [FieldOffset(0x01BC)] public float FilmShadowTintAmount;
    [FieldOffset(0x01C0)] public float FilmSaturation;
    [FieldOffset(0x01C4)] public FLinearColor FilmChannelMixerRed;
    [FieldOffset(0x01D4)] public FLinearColor FilmChannelMixerGreen;
    [FieldOffset(0x01E4)] public FLinearColor FilmChannelMixerBlue;
    [FieldOffset(0x01F4)] public float FilmContrast;
    [FieldOffset(0x01F8)] public float FilmToeAmount;
    [FieldOffset(0x01FC)] public float FilmHealAmount;
    [FieldOffset(0x0200)] public float FilmDynamicRange;
    [FieldOffset(0x0204)] public FLinearColor SceneColorTint;
    [FieldOffset(0x0214)] public float SceneFringeIntensity;
    [FieldOffset(0x0218)] public float ChromaticAberrationStartOffset;
    [FieldOffset(0x021C)] public float BloomIntensity;
    [FieldOffset(0x0220)] public float BloomThreshold;
    [FieldOffset(0x0224)] public float BloomSizeScale;
    [FieldOffset(0x0228)] public float Bloom1Size;
    [FieldOffset(0x022C)] public float Bloom2Size;
    [FieldOffset(0x0230)] public float Bloom3Size;
    [FieldOffset(0x0234)] public float Bloom4Size;
    [FieldOffset(0x0238)] public float Bloom5Size;
    [FieldOffset(0x023C)] public float Bloom6Size;
    [FieldOffset(0x0240)] public FLinearColor Bloom1Tint;
    [FieldOffset(0x0250)] public FLinearColor Bloom2Tint;
    [FieldOffset(0x0260)] public FLinearColor Bloom3Tint;
    [FieldOffset(0x0270)] public FLinearColor Bloom4Tint;
    [FieldOffset(0x0280)] public FLinearColor Bloom5Tint;
    [FieldOffset(0x0290)] public FLinearColor Bloom6Tint;
    [FieldOffset(0x02A0)] public float BloomConvolutionSize;
    [FieldOffset(0x02A8)] public UTexture2D* BloomConvolutionTexture;
    [FieldOffset(0x02B0)] public FVector2D BloomConvolutionCenterUV;
    [FieldOffset(0x02B8)] public float BloomConvolutionPreFilterMin;
    [FieldOffset(0x02BC)] public float BloomConvolutionPreFilterMax;
    [FieldOffset(0x02C0)] public float BloomConvolutionPreFilterMult;
    [FieldOffset(0x02C4)] public float BloomConvolutionBufferScale;
    [FieldOffset(0x02C8)] public UTexture* BloomDirtMask;
    [FieldOffset(0x02D0)] public float BloomDirtMaskIntensity;
    [FieldOffset(0x02D4)] public FLinearColor BloomDirtMaskTint;
    [FieldOffset(0x02E4)] public FLinearColor AmbientCubemapTint;
    [FieldOffset(0x02F4)] public float AmbientCubemapIntensity;
    [FieldOffset(0x02F8)] public UTextureCube* AmbientCubemap;
    [FieldOffset(0x0300)] public float CameraShutterSpeed;
    [FieldOffset(0x0304)] public float CameraISO;
    [FieldOffset(0x0308)] public float DepthOfFieldFstop;
    [FieldOffset(0x030C)] public float DepthOfFieldMinFstop;
    [FieldOffset(0x0310)] public int DepthOfFieldBladeCount;
    [FieldOffset(0x0314)] public float AutoExposureBias;
    [FieldOffset(0x0318)] public float AutoExposureBiasBackup;
    [FieldOffset(0x031C)] public byte bOverride_AutoExposureBiasBackup;
    [FieldOffset(0x0320)] public byte AutoExposureApplyPhysicalCameraExposure;
    [FieldOffset(0x0328)] public UCurveFloat* AutoExposureBiasCurve;
    [FieldOffset(0x0330)] public UTexture* AutoExposureMeterMask;
    [FieldOffset(0x0338)] public float AutoExposureLowPercent;
    [FieldOffset(0x033C)] public float AutoExposureHighPercent;
    [FieldOffset(0x0340)] public float AutoExposureMinBrightness;
    [FieldOffset(0x0344)] public float AutoExposureMaxBrightness;
    [FieldOffset(0x0348)] public float AutoExposureSpeedUp;
    [FieldOffset(0x034C)] public float AutoExposureSpeedDown;
    [FieldOffset(0x0350)] public float HistogramLogMin;
    [FieldOffset(0x0354)] public float HistogramLogMax;
    [FieldOffset(0x0358)] public float AutoExposureCalibrationConstant;
    [FieldOffset(0x035C)] public float LensFlareIntensity;
    [FieldOffset(0x0360)] public FLinearColor LensFlareTint;
    [FieldOffset(0x0370)] public float LensFlareBokehSize;
    [FieldOffset(0x0374)] public float LensFlareThreshold;
    [FieldOffset(0x0378)] public UTexture* LensFlareBokehShape;
    [FieldOffset(0x0380)] public FLinearColor LensFlareTints;
    [FieldOffset(0x0400)] public float VignetteIntensity;
    [FieldOffset(0x0404)] public float GrainJitter;
    [FieldOffset(0x0408)] public float GrainIntensity;
    [FieldOffset(0x040C)] public float AmbientOcclusionIntensity;
    [FieldOffset(0x0410)] public float AmbientOcclusionStaticFraction;
    [FieldOffset(0x0414)] public float AmbientOcclusionRadius;
    [FieldOffset(0x0418)] public byte AmbientOcclusionRadiusInWS;
    [FieldOffset(0x041C)] public float AmbientOcclusionFadeDistance;
    [FieldOffset(0x0420)] public float AmbientOcclusionFadeRadius;
    [FieldOffset(0x0424)] public float AmbientOcclusionDistance;
    [FieldOffset(0x0428)] public float AmbientOcclusionPower;
    [FieldOffset(0x042C)] public float AmbientOcclusionBias;
    [FieldOffset(0x0430)] public float AmbientOcclusionQuality;
    [FieldOffset(0x0434)] public float AmbientOcclusionMipBlend;
    [FieldOffset(0x0438)] public float AmbientOcclusionMipScale;
    [FieldOffset(0x043C)] public float AmbientOcclusionMipThreshold;
    [FieldOffset(0x0440)] public float AmbientOcclusionTemporalBlendWeight;
    [FieldOffset(0x0444)] public byte RayTracingAO;
    [FieldOffset(0x0448)] public int RayTracingAOSamplesPerPixel;
    [FieldOffset(0x044C)] public float RayTracingAOIntensity;
    [FieldOffset(0x0450)] public float RayTracingAORadius;
    [FieldOffset(0x0454)] public FLinearColor IndirectLightingColor;
    [FieldOffset(0x0464)] public float IndirectLightingIntensity;
    [FieldOffset(0x0468)] public ERayTracingGlobalIlluminationType RayTracingGIType;
    [FieldOffset(0x046C)] public int RayTracingGIMaxBounces;
    [FieldOffset(0x0470)] public int RayTracingGISamplesPerPixel;
    [FieldOffset(0x0474)] public float ColorGradingIntensity;
    [FieldOffset(0x0478)] public UTexture* ColorGradingLUT;
    [FieldOffset(0x0480)] public float DepthOfFieldSensorWidth;
    [FieldOffset(0x0484)] public float DepthOfFieldFocalDistance;
    [FieldOffset(0x0488)] public float DepthOfFieldDepthBlurAmount;
    [FieldOffset(0x048C)] public float DepthOfFieldDepthBlurRadius;
    [FieldOffset(0x0490)] public float DepthOfFieldFocalRegion;
    [FieldOffset(0x0494)] public float DepthOfFieldNearTransitionRegion;
    [FieldOffset(0x0498)] public float DepthOfFieldFarTransitionRegion;
    [FieldOffset(0x049C)] public float DepthOfFieldScale;
    [FieldOffset(0x04A0)] public float DepthOfFieldNearBlurSize;
    [FieldOffset(0x04A4)] public float DepthOfFieldFarBlurSize;
    [FieldOffset(0x04A8)] public float DepthOfFieldOcclusion;
    [FieldOffset(0x04AC)] public float DepthOfFieldSkyFocusDistance;
    [FieldOffset(0x04B0)] public float DepthOfFieldVignetteSize;
    [FieldOffset(0x04B4)] public float MotionBlurAmount;
    [FieldOffset(0x04B8)] public float MotionBlurMax;
    [FieldOffset(0x04BC)] public int MotionBlurTargetFPS;
    [FieldOffset(0x04C0)] public float MotionBlurPerObjectSize;
    [FieldOffset(0x04C4)] public float LPVIntensity;
    [FieldOffset(0x04C8)] public float LPVVplInjectionBias;
    [FieldOffset(0x04CC)] public float LPVSize;
    [FieldOffset(0x04D0)] public float LPVSecondaryOcclusionIntensity;
    [FieldOffset(0x04D4)] public float LPVSecondaryBounceIntensity;
    [FieldOffset(0x04D8)] public float LPVGeometryVolumeBias;
    [FieldOffset(0x04DC)] public float LPVEmissiveInjectionIntensity;
    [FieldOffset(0x04E0)] public float LPVDirectionalOcclusionIntensity;
    [FieldOffset(0x04E4)] public float LPVDirectionalOcclusionRadius;
    [FieldOffset(0x04E8)] public float LPVDiffuseOcclusionExponent;
    [FieldOffset(0x04EC)] public float LPVSpecularOcclusionExponent;
    [FieldOffset(0x04F0)] public float LPVDiffuseOcclusionIntensity;
    [FieldOffset(0x04F4)] public float LPVSpecularOcclusionIntensity;
    [FieldOffset(0x04F8)] public EReflectionsType ReflectionsType;
    [FieldOffset(0x04FC)] public float ScreenSpaceReflectionIntensity;
    [FieldOffset(0x0500)] public float ScreenSpaceReflectionQuality;
    [FieldOffset(0x0504)] public float ScreenSpaceReflectionMaxRoughness;
    [FieldOffset(0x0508)] public float RayTracingReflectionsMaxRoughness;
    [FieldOffset(0x050C)] public int RayTracingReflectionsMaxBounces;
    [FieldOffset(0x0510)] public int RayTracingReflectionsSamplesPerPixel;
    [FieldOffset(0x0514)] public EReflectedAndRefractedRayTracedShadows RayTracingReflectionsShadows;
    [FieldOffset(0x0515)] public byte RayTracingReflectionsTranslucency;
    [FieldOffset(0x0516)] public ETranslucencyType TranslucencyType;
    [FieldOffset(0x0518)] public float RayTracingTranslucencyMaxRoughness;
    [FieldOffset(0x051C)] public int RayTracingTranslucencyRefractionRays;
    [FieldOffset(0x0520)] public int RayTracingTranslucencySamplesPerPixel;
    [FieldOffset(0x0524)] public EReflectedAndRefractedRayTracedShadows RayTracingTranslucencyShadows;
    [FieldOffset(0x0525)] public byte RayTracingTranslucencyRefraction;
    [FieldOffset(0x0528)] public int PathTracingMaxBounces;
    [FieldOffset(0x052C)] public int PathTracingSamplesPerPixel;
    [FieldOffset(0x0530)] public float PathTracingFilterWidth;
    [FieldOffset(0x0534)] public byte PathTracingEnableEmissive;
    [FieldOffset(0x0538)] public float PathTracingMaxPathExposure;
    [FieldOffset(0x053C)] public byte PathTracingEnableDenoiser;
    [FieldOffset(0x0540)] public float LPVFadeRange;
    [FieldOffset(0x0544)] public float LPVDirectionalOcclusionFadeRange;
    [FieldOffset(0x0548)] public float ScreenPercentage;
    [FieldOffset(0x0550)] public FWeightedBlendables WeightedBlendables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCameraShakePattern
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDirectoryPath
{
    [FieldOffset(0x0000)] public FString Path;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FKeyHandleLookupTable
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UPlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public APlayerController* PlayerController;
    [FieldOffset(0x0038)] public int CurrentNetSpeed;
    [FieldOffset(0x003C)] public int ConfiguredInternetSpeed;
    [FieldOffset(0x0040)] public int ConfiguredLanSpeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FUniqueNetIdRepl
{
    [FieldOffset(0x0000)] public FUniqueNetIdWrapper baseObj;
    [FieldOffset(0x0018)] public TArray<byte> ReplicationBytes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1BA8)] 
public unsafe struct UNetConnection
{
    [FieldOffset(0x0000)] public UPlayer baseObj;
    [FieldOffset(0x0048)] public TArray<IntPtr> Children;
    [FieldOffset(0x0058)] public UNetDriver* Driver;
    [FieldOffset(0x0060)] public TSubclassOf<UPackageMap> PackageMapClass;
    [FieldOffset(0x0068)] public UPackageMap* PackageMap;
    [FieldOffset(0x0070)] public TArray<IntPtr> OpenChannels;
    [FieldOffset(0x0080)] public TArray<IntPtr> SentTemporaries;
    [FieldOffset(0x0090)] public AActor* ViewTarget;
    [FieldOffset(0x0098)] public AActor* OwningActor;
    [FieldOffset(0x00A0)] public int MaxPacket;
    [FieldOffset(0x00A4)] public byte InternalAck;
    [FieldOffset(0x0160)] public FUniqueNetIdRepl PlayerId;
    [FieldOffset(0x01D0)] public double LastReceiveTime;
    [FieldOffset(0x1510)] public TArray<IntPtr> ChannelsToTick;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FChannelDefinition
{
    [FieldOffset(0x0000)] public FName ChannelName;
    [FieldOffset(0x0008)] public FName ClassName;
    [FieldOffset(0x0010)] public UClass* ChannelClass;
    [FieldOffset(0x0018)] public int StaticChannelIndex;
    [FieldOffset(0x001C)] public bool bTickOnCreate;
    [FieldOffset(0x001D)] public bool bServerOpen;
    [FieldOffset(0x001E)] public bool bClientOpen;
    [FieldOffset(0x001F)] public bool bInitialServer;
    [FieldOffset(0x0020)] public bool bInitialClient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x760)] 
public unsafe struct UNetDriver
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FString NetConnectionClassName;
    [FieldOffset(0x0040)] public FString ReplicationDriverClassName;
    [FieldOffset(0x0050)] public int MaxDownloadSize;
    [FieldOffset(0x0054)] public byte bClampListenServerTickRate;
    [FieldOffset(0x0058)] public int NetServerMaxTickRate;
    [FieldOffset(0x005C)] public int MaxNetTickRate;
    [FieldOffset(0x0060)] public int MaxInternetClientRate;
    [FieldOffset(0x0064)] public int MaxClientRate;
    [FieldOffset(0x0068)] public float ServerTravelPause;
    [FieldOffset(0x006C)] public float SpawnPrioritySeconds;
    [FieldOffset(0x0070)] public float RelevantTimeout;
    [FieldOffset(0x0074)] public float KeepAliveTime;
    [FieldOffset(0x0078)] public float InitialConnectTimeout;
    [FieldOffset(0x007C)] public float ConnectionTimeout;
    [FieldOffset(0x0080)] public float TimeoutMultiplierForUnoptimizedBuilds;
    [FieldOffset(0x0084)] public bool bNoTimeouts;
    [FieldOffset(0x0085)] public bool bNeverApplyNetworkEmulationSettings;
    [FieldOffset(0x0088)] public UNetConnection* ServerConnection;
    [FieldOffset(0x0090)] public TArray<IntPtr> ClientConnections;
    [FieldOffset(0x0100)] public int RecentlyDisconnectedTrackingTime;
    [FieldOffset(0x0140)] public UWorld* World;
    [FieldOffset(0x0148)] public UPackage* WorldPackage;
    [FieldOffset(0x0170)] public UClass* NetConnectionClass;
    [FieldOffset(0x0178)] public UClass* ReplicationDriverClass;
    [FieldOffset(0x0190)] public FName NetDriverName;
    [FieldOffset(0x0198)] public TArray<FChannelDefinition> ChannelDefinitions;
    [FieldOffset(0x01A8)] public TMap<FName, FChannelDefinition> ChannelDefinitionMap;
    [FieldOffset(0x01F8)] public TArray<IntPtr> ActorChannelPool;
    [FieldOffset(0x0210)] public float Time;
    [FieldOffset(0x0700)] public UReplicationDriver* ReplicationDriver;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlueprintAsyncActionBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UOnlineBlueprintCallProxyBase
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UOnlineEngineInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UOnlineSession
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FRuntimeFloatCurve
{
    [FieldOffset(0x0000)] public FRichCurve EditorCurveData;
    [FieldOffset(0x0080)] public UCurveFloat* ExternalCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FBaseAttenuationSettings
{
    [FieldOffset(0x0008)] public EAttenuationDistanceModel DistanceAlgorithm;
    [FieldOffset(0x0009)] public EAttenuationShape AttenuationShape;
    [FieldOffset(0x000C)] public float dBAttenuationAtMax;
    [FieldOffset(0x0010)] public ENaturalSoundFalloffMode FalloffMode;
    [FieldOffset(0x0014)] public FVector AttenuationShapeExtents;
    [FieldOffset(0x0020)] public float ConeOffset;
    [FieldOffset(0x0024)] public float FalloffDistance;
    [FieldOffset(0x0028)] public FRuntimeFloatCurve CustomAttenuationCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FAttenuationSubmixSendSettings
{
    [FieldOffset(0x0000)] public USoundSubmixBase* Submix;
    [FieldOffset(0x0008)] public ESubmixSendMethod SubmixSendMethod;
    [FieldOffset(0x000C)] public float SubmixSendLevelMin;
    [FieldOffset(0x0010)] public float SubmixSendLevelMax;
    [FieldOffset(0x0014)] public float SubmixSendDistanceMin;
    [FieldOffset(0x0018)] public float SubmixSendDistanceMax;
    [FieldOffset(0x001C)] public float ManualSubmixSendLevel;
    [FieldOffset(0x0020)] public FRuntimeFloatCurve CustomSubmixSendCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSoundAttenuationPluginSettings
{
    [FieldOffset(0x0000)] public TArray<IntPtr> SpatializationPluginSettingsArray;
    [FieldOffset(0x0010)] public TArray<IntPtr> OcclusionPluginSettingsArray;
    [FieldOffset(0x0020)] public TArray<IntPtr> ReverbPluginSettingsArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct FSoundAttenuationSettings
{
    [FieldOffset(0x0000)] public FBaseAttenuationSettings baseObj;
    [FieldOffset(0x00B0)] public byte bAttenuate;
    [FieldOffset(0x00B0)] public byte bSpatialize;
    [FieldOffset(0x00B0)] public byte bAttenuateWithLPF;
    [FieldOffset(0x00B0)] public byte bEnableListenerFocus;
    [FieldOffset(0x00B0)] public byte bEnableFocusInterpolation;
    [FieldOffset(0x00B0)] public byte bEnableOcclusion;
    [FieldOffset(0x00B0)] public byte bUseComplexCollisionForOcclusion;
    [FieldOffset(0x00B0)] public byte bEnableReverbSend;
    [FieldOffset(0x00B1)] public byte bEnablePriorityAttenuation;
    [FieldOffset(0x00B1)] public byte bApplyNormalizationToStereoSounds;
    [FieldOffset(0x00B1)] public byte bEnableLogFrequencyScaling;
    [FieldOffset(0x00B1)] public byte bEnableSubmixSends;
    [FieldOffset(0x00B2)] public ESoundSpatializationAlgorithm SpatializationAlgorithm;
    [FieldOffset(0x00B4)] public float BinauralRadius;
    [FieldOffset(0x00B8)] public EAirAbsorptionMethod AbsorptionMethod;
    [FieldOffset(0x00B9)] public ECollisionChannel OcclusionTraceChannel;
    [FieldOffset(0x00BA)] public EReverbSendMethod ReverbSendMethod;
    [FieldOffset(0x00BB)] public EPriorityAttenuationMethod PriorityAttenuationMethod;
    [FieldOffset(0x00BC)] public float OmniRadius;
    [FieldOffset(0x00C0)] public float StereoSpread;
    [FieldOffset(0x00C4)] public float LPFRadiusMin;
    [FieldOffset(0x00C8)] public float LPFRadiusMax;
    [FieldOffset(0x00D0)] public FRuntimeFloatCurve CustomLowpassAirAbsorptionCurve;
    [FieldOffset(0x0158)] public FRuntimeFloatCurve CustomHighpassAirAbsorptionCurve;
    [FieldOffset(0x01E0)] public float LPFFrequencyAtMin;
    [FieldOffset(0x01E4)] public float LPFFrequencyAtMax;
    [FieldOffset(0x01E8)] public float HPFFrequencyAtMin;
    [FieldOffset(0x01EC)] public float HPFFrequencyAtMax;
    [FieldOffset(0x01F0)] public float FocusAzimuth;
    [FieldOffset(0x01F4)] public float NonFocusAzimuth;
    [FieldOffset(0x01F8)] public float FocusDistanceScale;
    [FieldOffset(0x01FC)] public float NonFocusDistanceScale;
    [FieldOffset(0x0200)] public float FocusPriorityScale;
    [FieldOffset(0x0204)] public float NonFocusPriorityScale;
    [FieldOffset(0x0208)] public float FocusVolumeAttenuation;
    [FieldOffset(0x020C)] public float NonFocusVolumeAttenuation;
    [FieldOffset(0x0210)] public float FocusAttackInterpSpeed;
    [FieldOffset(0x0214)] public float FocusReleaseInterpSpeed;
    [FieldOffset(0x0218)] public float OcclusionLowPassFilterFrequency;
    [FieldOffset(0x021C)] public float OcclusionVolumeAttenuation;
    [FieldOffset(0x0220)] public float OcclusionInterpolationTime;
    [FieldOffset(0x0224)] public float ReverbWetLevelMin;
    [FieldOffset(0x0228)] public float ReverbWetLevelMax;
    [FieldOffset(0x022C)] public float ReverbDistanceMin;
    [FieldOffset(0x0230)] public float ReverbDistanceMax;
    [FieldOffset(0x0234)] public float ManualReverbSendLevel;
    [FieldOffset(0x0238)] public FRuntimeFloatCurve CustomReverbSendCurve;
    [FieldOffset(0x02C0)] public TArray<FAttenuationSubmixSendSettings> SubmixSendSettings;
    [FieldOffset(0x02D0)] public float PriorityAttenuationMin;
    [FieldOffset(0x02D4)] public float PriorityAttenuationMax;
    [FieldOffset(0x02D8)] public float PriorityAttenuationDistanceMin;
    [FieldOffset(0x02DC)] public float PriorityAttenuationDistanceMax;
    [FieldOffset(0x02E0)] public float ManualPriorityAttenuation;
    [FieldOffset(0x02E8)] public FRuntimeFloatCurve CustomPriorityAttenuationCurve;
    [FieldOffset(0x0370)] public FSoundAttenuationPluginSettings PluginSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FSoundSubmixSendInfo
{
    [FieldOffset(0x0000)] public ESendLevelControlMethod SendLevelControlMethod;
    [FieldOffset(0x0001)] public ESubmixSendStage SendStage;
    [FieldOffset(0x0008)] public USoundSubmixBase* SoundSubmix;
    [FieldOffset(0x0010)] public float SendLevel;
    [FieldOffset(0x0014)] public float MinSendLevel;
    [FieldOffset(0x0018)] public float MaxSendLevel;
    [FieldOffset(0x001C)] public float MinSendDistance;
    [FieldOffset(0x0020)] public float MaxSendDistance;
    [FieldOffset(0x0028)] public FRuntimeFloatCurve CustomSendLevelCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FSoundSourceBusSendInfo
{
    [FieldOffset(0x0000)] public ESourceBusSendLevelControlMethod SourceBusSendLevelControlMethod;
    [FieldOffset(0x0008)] public USoundSourceBus* SoundSourceBus;
    [FieldOffset(0x0010)] public UAudioBus* AudioBus;
    [FieldOffset(0x0018)] public float SendLevel;
    [FieldOffset(0x001C)] public float MinSendLevel;
    [FieldOffset(0x0020)] public float MaxSendLevel;
    [FieldOffset(0x0024)] public float MinSendDistance;
    [FieldOffset(0x0028)] public float MaxSendDistance;
    [FieldOffset(0x0030)] public FRuntimeFloatCurve CustomSendLevelCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A8)] 
public unsafe struct UGameInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> LocalPlayers;
    [FieldOffset(0x0048)] public UOnlineSession* OnlineSession;
    [FieldOffset(0x0050)] public TArray<IntPtr> ReferencedObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct USubsystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UGameInstanceSubsystem
{
    [FieldOffset(0x0000)] public USubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x480)] 
public unsafe struct UMeshComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public TArray<IntPtr> OverrideMaterials;
    [FieldOffset(0x0470)] public byte bEnableMaterialParameterCaching;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FVertexOffsetUsage
{
    [FieldOffset(0x0000)] public int Usage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FSkelMeshComponentLODInfo
{
    [FieldOffset(0x0000)] public TArray<bool> HiddenMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FSkelMeshSkinWeightInfo
{
    [FieldOffset(0x0000)] public int Bones;
    [FieldOffset(0x0030)] public byte Weights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6A0)] 
public unsafe struct USkinnedMeshComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0480)] public USkeletalMesh* SkeletalMesh;
    [FieldOffset(0x0488)] public TWeakObjectPtr<USkinnedMeshComponent> MasterPoseComponent;
    [FieldOffset(0x0490)] public TArray<ESkinCacheUsage> SkinCacheUsage;
    [FieldOffset(0x04A0)] public TArray<FVertexOffsetUsage> VertexOffsetUsage;
    [FieldOffset(0x05A8)] public UPhysicsAsset* PhysicsAssetOverride;
    [FieldOffset(0x05B0)] public int ForcedLodModel;
    [FieldOffset(0x05B4)] public int MinLodModel;
    [FieldOffset(0x05C0)] public float StreamingDistanceMultiplier;
    [FieldOffset(0x05D0)] public TArray<FSkelMeshComponentLODInfo> LODInfo;
    [FieldOffset(0x0604)] public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption;
    [FieldOffset(0x0606)] public byte bOverrideMinLOD;
    [FieldOffset(0x0606)] public byte bUseBoundsFromMasterPoseComponent;
    [FieldOffset(0x0606)] public byte bForceWireframe;
    [FieldOffset(0x0606)] public byte bDisplayBones;
    [FieldOffset(0x0606)] public byte bDisableMorphTarget;
    [FieldOffset(0x0607)] public byte bHideSkin;
    [FieldOffset(0x0607)] public byte bPerBoneMotionBlur;
    [FieldOffset(0x0607)] public byte bComponentUseFixedSkelBounds;
    [FieldOffset(0x0607)] public byte bConsiderAllBodiesForBounds;
    [FieldOffset(0x0607)] public byte bSyncAttachParentLOD;
    [FieldOffset(0x0607)] public byte bCanHighlightSelectedSections;
    [FieldOffset(0x0607)] public byte bRecentlyRendered;
    [FieldOffset(0x0607)] public byte bCastCapsuleDirectShadow;
    [FieldOffset(0x0608)] public byte bCastCapsuleIndirectShadow;
    [FieldOffset(0x0608)] public byte bCPUSkinning;
    [FieldOffset(0x0608)] public byte bEnableUpdateRateOptimizations;
    [FieldOffset(0x0608)] public byte bDisplayDebugUpdateRateOptimizations;
    [FieldOffset(0x0608)] public byte bRenderStatic;
    [FieldOffset(0x0608)] public byte bIgnoreMasterPoseComponentLOD;
    [FieldOffset(0x0609)] public byte bCachedLocalBoundsUpToDate;
    [FieldOffset(0x0609)] public byte bForceMeshObjectUpdate;
    [FieldOffset(0x060C)] public float CapsuleIndirectShadowMinVisibility;
    [FieldOffset(0x0620)] public FBoxSphereBounds CachedWorldSpaceBounds;
    [FieldOffset(0x0640)] public FMatrix CachedWorldToLocalTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSingleAnimationPlayData
{
    [FieldOffset(0x0000)] public UAnimationAsset* AnimToPlay;
    [FieldOffset(0x0008)] public byte bSavedLooping;
    [FieldOffset(0x0008)] public byte bSavedPlaying;
    [FieldOffset(0x000C)] public float SavedPosition;
    [FieldOffset(0x0010)] public float SavedPlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPoseSnapshot
{
    [FieldOffset(0x0000)] public TArray<FTransform> LocalTransforms;
    [FieldOffset(0x0010)] public TArray<FName> BoneNames;
    [FieldOffset(0x0020)] public FName SkeletalMeshName;
    [FieldOffset(0x0028)] public FName SnapshotName;
    [FieldOffset(0x0030)] public bool bIsValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xED0)] 
public unsafe struct USkeletalMeshComponent
{
    [FieldOffset(0x0000)] public USkinnedMeshComponent baseObj;
    [FieldOffset(0x06A0)] public UClass* AnimBlueprintGeneratedClass;
    [FieldOffset(0x06A8)] public TSubclassOf<UAnimInstance> AnimClass;
    [FieldOffset(0x06B0)] public UAnimInstance* AnimScriptInstance;
    [FieldOffset(0x06B8)] public UAnimInstance* PostProcessAnimInstance;
    [FieldOffset(0x06C0)] public FSingleAnimationPlayData AnimationData;
    [FieldOffset(0x06E8)] public FVector RootBoneTranslation;
    [FieldOffset(0x06F4)] public FVector LineCheckBoundsScale;
    [FieldOffset(0x0730)] public TArray<IntPtr> LinkedInstances;
    [FieldOffset(0x0740)] public TArray<FTransform> CachedBoneSpaceTransforms;
    [FieldOffset(0x0750)] public TArray<FTransform> CachedComponentSpaceTransforms;
    [FieldOffset(0x08B0)] public float GlobalAnimRateScale;
    [FieldOffset(0x08B4)] public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType;
    [FieldOffset(0x08B5)] public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode;
    [FieldOffset(0x08B7)] public EAnimationMode AnimationMode;
    [FieldOffset(0x08B9)] public byte bDisablePostProcessBlueprint;
    [FieldOffset(0x08B9)] public byte bUpdateOverlapsOnAnimationFinalize;
    [FieldOffset(0x08B9)] public byte bHasValidBodies;
    [FieldOffset(0x08B9)] public byte bBlendPhysics;
    [FieldOffset(0x08B9)] public byte bEnablePhysicsOnDedicatedServer;
    [FieldOffset(0x08B9)] public byte bUpdateJointsFromAnimation;
    [FieldOffset(0x08BA)] public byte bDisableClothSimulation;
    [FieldOffset(0x08C0)] public byte bDisableRigidBodyAnimNode;
    [FieldOffset(0x08C0)] public byte bAllowAnimCurveEvaluation;
    [FieldOffset(0x08C0)] public byte bDisableAnimCurves;
    [FieldOffset(0x08C0)] public byte bCollideWithEnvironment;
    [FieldOffset(0x08C1)] public byte bCollideWithAttachedChildren;
    [FieldOffset(0x08C1)] public byte bLocalSpaceSimulation;
    [FieldOffset(0x08C1)] public byte bResetAfterTeleport;
    [FieldOffset(0x08C1)] public byte bDeferKinematicBoneUpdate;
    [FieldOffset(0x08C1)] public byte bNoSkeletonUpdate;
    [FieldOffset(0x08C1)] public byte bPauseAnims;
    [FieldOffset(0x08C1)] public byte bUseRefPoseOnInitAnim;
    [FieldOffset(0x08C2)] public byte bEnablePerPolyCollision;
    [FieldOffset(0x08C2)] public byte bForceRefpose;
    [FieldOffset(0x08C2)] public byte bOnlyAllowAutonomousTickPose;
    [FieldOffset(0x08C2)] public byte bIsAutonomousTickPose;
    [FieldOffset(0x08C2)] public byte bOldForceRefPose;
    [FieldOffset(0x08C2)] public byte bShowPrePhysBones;
    [FieldOffset(0x08C2)] public byte bRequiredBonesUpToDate;
    [FieldOffset(0x08C2)] public byte bAnimTreeInitialised;
    [FieldOffset(0x08C3)] public byte bIncludeComponentLocationIntoBounds;
    [FieldOffset(0x08C3)] public byte bEnableLineCheckWithBounds;
    [FieldOffset(0x08C3)] public byte bPropagateCurvesToSlaves;
    [FieldOffset(0x08C3)] public byte bSkipKinematicUpdateWhenInterpolating;
    [FieldOffset(0x08C3)] public byte bSkipBoundsUpdateWhenInterpolating;
    [FieldOffset(0x08C3)] public byte bNeedsQueuedAnimEventsDispatched;
    [FieldOffset(0x08C6)] public ushort CachedAnimCurveUidVersion;
    [FieldOffset(0x08C8)] public float ClothBlendWeight;
    [FieldOffset(0x08CC)] public bool bWaitForParallelClothTask;
    [FieldOffset(0x08D0)] public TArray<FName> DisallowedAnimCurves;
    [FieldOffset(0x08E0)] public UBodySetup* BodySetup;
    [FieldOffset(0x0900)] public TSubclassOf<UClothingSimulationFactory> ClothingSimulationFactory;
    [FieldOffset(0x09D8)] public float TeleportDistanceThreshold;
    [FieldOffset(0x09DC)] public float TeleportRotationThreshold;
    [FieldOffset(0x09E8)] public uint LastPoseTickFrame;
    [FieldOffset(0x0A40)] public UClothingSimulationInteractor* ClothingInteractor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimNotifyEventReference
{
    [FieldOffset(0x0008)] public UObject* NotifySource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimNotifyArray
{
    [FieldOffset(0x0000)] public TArray<FAnimNotifyEventReference> Notifies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FAnimNotifyQueue
{
    [FieldOffset(0x0010)] public TArray<FAnimNotifyEventReference> AnimNotifies;
    [FieldOffset(0x0020)] public TMap<FName, FAnimNotifyArray> UnfilteredMontageAnimNotifies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimLinkableElement
{
    [FieldOffset(0x0008)] public UAnimMontage* LinkedMontage;
    [FieldOffset(0x0010)] public int SlotIndex;
    [FieldOffset(0x0014)] public int SegmentIndex;
    [FieldOffset(0x0018)] public EAnimLinkMethod LinkMethod;
    [FieldOffset(0x0019)] public EAnimLinkMethod CachedLinkMethod;
    [FieldOffset(0x001C)] public float SegmentBeginTime;
    [FieldOffset(0x0020)] public float SegmentLength;
    [FieldOffset(0x0024)] public float LinkValue;
    [FieldOffset(0x0028)] public UAnimSequenceBase* LinkedSequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FAnimNotifyEvent
{
    [FieldOffset(0x0000)] public FAnimLinkableElement baseObj;
    [FieldOffset(0x0030)] public float DisplayTime;
    [FieldOffset(0x0034)] public float TriggerTimeOffset;
    [FieldOffset(0x0038)] public float EndTriggerTimeOffset;
    [FieldOffset(0x003C)] public float TriggerWeightThreshold;
    [FieldOffset(0x0040)] public FName NotifyName;
    [FieldOffset(0x0048)] public UAnimNotify* Notify;
    [FieldOffset(0x0050)] public UAnimNotifyState* NotifyStateClass;
    [FieldOffset(0x0058)] public float Duration;
    [FieldOffset(0x0060)] public FAnimLinkableElement EndLink;
    [FieldOffset(0x0090)] public bool bConvertedFromBranchingPoint;
    [FieldOffset(0x0091)] public EMontageNotifyTickType MontageTickType;
    [FieldOffset(0x0094)] public float NotifyTriggerChance;
    [FieldOffset(0x0098)] public ENotifyFilterType NotifyFilterType;
    [FieldOffset(0x009C)] public int NotifyFilterLOD;
    [FieldOffset(0x00A0)] public bool bTriggerOnDedicatedServer;
    [FieldOffset(0x00A1)] public bool bTriggerOnFollower;
    [FieldOffset(0x00A4)] public int TrackIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMarkerSyncAnimPosition
{
    [FieldOffset(0x0000)] public FName PreviousMarkerName;
    [FieldOffset(0x0008)] public FName NextMarkerName;
    [FieldOffset(0x0010)] public float PositionBetweenMarkers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UAnimInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public USkeleton* CurrentSkeleton;
    [FieldOffset(0x0030)] public ERootMotionMode RootMotionMode;
    [FieldOffset(0x0031)] public byte bUseMultiThreadedAnimationUpdate;
    [FieldOffset(0x0031)] public byte bUsingCopyPoseFromMesh;
    [FieldOffset(0x0031)] public byte bReceiveNotifiesFromLinkedInstances;
    [FieldOffset(0x0031)] public byte bPropagateNotifiesToLinkedInstances;
    [FieldOffset(0x0031)] public byte bQueueMontageEvents;
    [FieldOffset(0x0100)] public FAnimNotifyQueue NotifyQueue;
    [FieldOffset(0x0170)] public TArray<FAnimNotifyEvent> ActiveAnimNotifyState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDataAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSubclassOf<UDataAsset> NativeClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct APawn
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public byte bUseControllerRotationPitch;
    [FieldOffset(0x0228)] public byte bUseControllerRotationYaw;
    [FieldOffset(0x0228)] public byte bUseControllerRotationRoll;
    [FieldOffset(0x0228)] public byte bCanAffectNavigationGeneration;
    [FieldOffset(0x022C)] public float BaseEyeHeight;
    [FieldOffset(0x0230)] public EAutoReceiveInput AutoPossessPlayer;
    [FieldOffset(0x0231)] public EAutoPossessAI AutoPossessAI;
    [FieldOffset(0x0232)] public byte RemoteViewPitch;
    [FieldOffset(0x0238)] public TSubclassOf<AController> AIControllerClass;
    [FieldOffset(0x0240)] public APlayerState* PlayerState;
    [FieldOffset(0x0250)] public AController* LastHitBy;
    [FieldOffset(0x0258)] public AController* Controller;
    [FieldOffset(0x0264)] public FVector ControlInputVector;
    [FieldOffset(0x0270)] public FVector LastControlInputVector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBasedMovementInfo
{
    [FieldOffset(0x0000)] public UPrimitiveComponent* MovementBase;
    [FieldOffset(0x0008)] public FName BoneName;
    [FieldOffset(0x0010)] public FVector_NetQuantize100 Location;
    [FieldOffset(0x001C)] public FRotator Rotation;
    [FieldOffset(0x0028)] public bool bServerHasBaseComponent;
    [FieldOffset(0x0029)] public bool bRelativeRotation;
    [FieldOffset(0x002A)] public bool bServerHasVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FRootMotionSourceSettings
{
    [FieldOffset(0x0000)] public byte flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVector_NetQuantize10
{
    [FieldOffset(0x0000)] public FVector baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FRootMotionSourceGroup
{
    [FieldOffset(0x0028)] public byte bHasAdditiveSources;
    [FieldOffset(0x0028)] public byte bHasOverrideSources;
    [FieldOffset(0x0028)] public byte bHasOverrideSourcesWithIgnoreZAccumulate;
    [FieldOffset(0x0028)] public byte bIsAdditiveVelocityApplied;
    [FieldOffset(0x0029)] public FRootMotionSourceSettings LastAccumulatedSettings;
    [FieldOffset(0x002C)] public FVector_NetQuantize10 LastPreAdditiveVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRootMotionMovementParams
{
    [FieldOffset(0x0000)] public bool bHasRootMotion;
    [FieldOffset(0x0004)] public float BlendWeight;
    [FieldOffset(0x0010)] public FTransform RootMotionTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FRepRootMotionMontage
{
    [FieldOffset(0x0000)] public bool bIsActive;
    [FieldOffset(0x0008)] public UAnimMontage* AnimMontage;
    [FieldOffset(0x0010)] public float Position;
    [FieldOffset(0x0014)] public FVector_NetQuantize100 Location;
    [FieldOffset(0x0020)] public FRotator Rotation;
    [FieldOffset(0x0030)] public UPrimitiveComponent* MovementBase;
    [FieldOffset(0x0038)] public FName MovementBaseBoneName;
    [FieldOffset(0x0040)] public bool bRelativePosition;
    [FieldOffset(0x0041)] public bool bRelativeRotation;
    [FieldOffset(0x0048)] public FRootMotionSourceGroup AuthoritativeRootMotion;
    [FieldOffset(0x0080)] public FVector_NetQuantize10 Acceleration;
    [FieldOffset(0x008C)] public FVector_NetQuantize10 LinearVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FSimulatedRootMotionReplicatedMove
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0008)] public FRepRootMotionMontage RootMotion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FCharacterNetworkSerializationPackedBits
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FCharacterServerMovePackedBits
{
    [FieldOffset(0x0000)] public FCharacterNetworkSerializationPackedBits baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FCharacterMoveResponsePackedBits
{
    [FieldOffset(0x0000)] public FCharacterNetworkSerializationPackedBits baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C0)] 
public unsafe struct ACharacter
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public USkeletalMeshComponent* Mesh;
    [FieldOffset(0x0288)] public UCharacterMovementComponent* CharacterMovement;
    [FieldOffset(0x0290)] public UCapsuleComponent* CapsuleComponent;
    [FieldOffset(0x0298)] public FBasedMovementInfo BasedMovement;
    [FieldOffset(0x02C8)] public FBasedMovementInfo ReplicatedBasedMovement;
    [FieldOffset(0x02F8)] public float AnimRootMotionTranslationScale;
    [FieldOffset(0x02FC)] public FVector BaseTranslationOffset;
    [FieldOffset(0x0310)] public FQuat BaseRotationOffset;
    [FieldOffset(0x0320)] public float ReplicatedServerLastTransformUpdateTimeStamp;
    [FieldOffset(0x0324)] public float ReplayLastTransformUpdateTimeStamp;
    [FieldOffset(0x0328)] public byte ReplicatedMovementMode;
    [FieldOffset(0x0329)] public bool bInBaseReplication;
    [FieldOffset(0x032C)] public float CrouchedEyeHeight;
    [FieldOffset(0x0330)] public byte bIsCrouched;
    [FieldOffset(0x0330)] public byte bProxyIsJumpForceApplied;
    [FieldOffset(0x0330)] public byte bPressedJump;
    [FieldOffset(0x0330)] public byte bClientUpdating;
    [FieldOffset(0x0330)] public byte bClientWasFalling;
    [FieldOffset(0x0330)] public byte bClientResimulateRootMotion;
    [FieldOffset(0x0330)] public byte bClientResimulateRootMotionSources;
    [FieldOffset(0x0330)] public byte bSimGravityDisabled;
    [FieldOffset(0x0331)] public byte bClientCheckEncroachmentOnNetUpdate;
    [FieldOffset(0x0331)] public byte bServerMoveIgnoreRootMotion;
    [FieldOffset(0x0331)] public byte bWasJumping;
    [FieldOffset(0x0334)] public float JumpKeyHoldTime;
    [FieldOffset(0x0338)] public float JumpForceTimeRemaining;
    [FieldOffset(0x033C)] public float ProxyJumpForceStartedTime;
    [FieldOffset(0x0340)] public float JumpMaxHoldTime;
    [FieldOffset(0x0344)] public int JumpMaxCount;
    [FieldOffset(0x0348)] public int JumpCurrentCount;
    [FieldOffset(0x034C)] public int JumpCurrentCountPreJump;
    [FieldOffset(0x0398)] public FRootMotionSourceGroup SavedRootMotion;
    [FieldOffset(0x03D0)] public FRootMotionMovementParams ClientRootMotionParams;
    [FieldOffset(0x0410)] public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves;
    [FieldOffset(0x0420)] public FRepRootMotionMontage RepRootMotion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AController
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public APlayerState* PlayerState;
    [FieldOffset(0x0248)] public FName StateName;
    [FieldOffset(0x0250)] public APawn* Pawn;
    [FieldOffset(0x0260)] public ACharacter* Character;
    [FieldOffset(0x0268)] public USceneComponent* TransformComponent;
    [FieldOffset(0x0288)] public FRotator ControlRotation;
    [FieldOffset(0x0294)] public byte bAttachToPawn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ATargetPoint
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FActiveForceFeedbackEffect
{
    [FieldOffset(0x0000)] public UForceFeedbackEffect* ForceFeedbackEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FViewTargetTransitionParams
{
    [FieldOffset(0x0000)] public float BlendTime;
    [FieldOffset(0x0004)] public EViewTargetBlendFunction BlendFunction;
    [FieldOffset(0x0008)] public float BlendExp;
    [FieldOffset(0x000C)] public byte bLockOutgoing;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FUpdateLevelVisibilityLevelInfo
{
    [FieldOffset(0x0000)] public FName PackageName;
    [FieldOffset(0x0008)] public FName Filename;
    [FieldOffset(0x0010)] public byte bIsVisible;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FLatentActionInfo
{
    [FieldOffset(0x0000)] public int Linkage;
    [FieldOffset(0x0004)] public int UUID;
    [FieldOffset(0x0008)] public FName ExecutionFunction;
    [FieldOffset(0x0010)] public UObject* CallbackTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FUpdateLevelStreamingLevelStatus
{
    [FieldOffset(0x0000)] public FName PackageName;
    [FieldOffset(0x0008)] public int LODIndex;
    [FieldOffset(0x000C)] public bool bNewShouldBeLoaded;
    [FieldOffset(0x000D)] public bool bNewShouldBeVisible;
    [FieldOffset(0x000E)] public bool bNewShouldBlockOnLoad;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FForceFeedbackParameters
{
    [FieldOffset(0x0000)] public FName Tag;
    [FieldOffset(0x0008)] public bool bLooping;
    [FieldOffset(0x0009)] public bool bIgnoreTimeDilation;
    [FieldOffset(0x000A)] public bool bPlayWhilePaused;
}

[StructLayout(LayoutKind.Explicit, Size = 0x580)] 
public unsafe struct APlayerController
{
    [FieldOffset(0x0000)] public AController baseObj;
    [FieldOffset(0x0298)] public UPlayer* Player;
    [FieldOffset(0x02A0)] public APawn* AcknowledgedPawn;
    [FieldOffset(0x02A8)] public UInterpTrackInstDirector* ControllingDirTrackInst;
    [FieldOffset(0x02B0)] public AHUD* MyHUD;
    [FieldOffset(0x02B8)] public APlayerCameraManager* PlayerCameraManager;
    [FieldOffset(0x02C0)] public TSubclassOf<APlayerCameraManager> PlayerCameraManagerClass;
    [FieldOffset(0x02C8)] public bool bAutoManageActiveCameraTarget;
    [FieldOffset(0x02CC)] public FRotator TargetViewRotation;
    [FieldOffset(0x02E4)] public float SmoothTargetViewRotationSpeed;
    [FieldOffset(0x02F0)] public TArray<IntPtr> HiddenActors;
    [FieldOffset(0x0300)] public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents;
    [FieldOffset(0x0314)] public float LastSpectatorStateSynchTime;
    [FieldOffset(0x0318)] public FVector LastSpectatorSyncLocation;
    [FieldOffset(0x0324)] public FRotator LastSpectatorSyncRotation;
    [FieldOffset(0x0330)] public int ClientCap;
    [FieldOffset(0x0338)] public UCheatManager* CheatManager;
    [FieldOffset(0x0340)] public TSubclassOf<UCheatManager> CheatClass;
    [FieldOffset(0x0348)] public UPlayerInput* PlayerInput;
    [FieldOffset(0x0350)] public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects;
    [FieldOffset(0x03E0)] public byte bPlayerIsWaiting;
    [FieldOffset(0x03E4)] public byte NetPlayerIndex;
    [FieldOffset(0x0420)] public UNetConnection* PendingSwapConnection;
    [FieldOffset(0x0428)] public UNetConnection* NetConnection;
    [FieldOffset(0x043C)] public float InputYawScale;
    [FieldOffset(0x0440)] public float InputPitchScale;
    [FieldOffset(0x0444)] public float InputRollScale;
    [FieldOffset(0x0448)] public byte bShowMouseCursor;
    [FieldOffset(0x0448)] public byte bEnableClickEvents;
    [FieldOffset(0x0448)] public byte bEnableTouchEvents;
    [FieldOffset(0x0448)] public byte bEnableMouseOverEvents;
    [FieldOffset(0x0448)] public byte bEnableTouchOverEvents;
    [FieldOffset(0x0448)] public byte bForceFeedbackEnabled;
    [FieldOffset(0x044C)] public float ForceFeedbackScale;
    [FieldOffset(0x0450)] public TArray<FKey> ClickEventKeys;
    [FieldOffset(0x0460)] public EMouseCursor DefaultMouseCursor;
    [FieldOffset(0x0461)] public EMouseCursor CurrentMouseCursor;
    [FieldOffset(0x0462)] public ECollisionChannel DefaultClickTraceChannel;
    [FieldOffset(0x0463)] public ECollisionChannel CurrentClickTraceChannel;
    [FieldOffset(0x0464)] public float HitResultTraceDistance;
    [FieldOffset(0x0468)] public ushort SeamlessTravelCount;
    [FieldOffset(0x046A)] public ushort LastCompletedSeamlessTravelCount;
    [FieldOffset(0x04E0)] public UInputComponent* InactiveStateInputComponent;
    [FieldOffset(0x04E8)] public byte bShouldPerformFullTickWhenPaused;
    [FieldOffset(0x0500)] public UTouchInterface* CurrentTouchInterface;
    [FieldOffset(0x0558)] public ASpectatorPawn* SpectatorPawn;
    [FieldOffset(0x0564)] public bool bIsLocalPlayerController;
    [FieldOffset(0x0568)] public FVector SpawnLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBoneReference
{
    [FieldOffset(0x0000)] public FName BoneName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FSplineCurves
{
    [FieldOffset(0x0000)] public FInterpCurveVector Position;
    [FieldOffset(0x0018)] public FInterpCurveQuat Rotation;
    [FieldOffset(0x0030)] public FInterpCurveVector Scale;
    [FieldOffset(0x0048)] public FInterpCurveFloat ReparamTable;
    [FieldOffset(0x0060)] public USplineMetadata* MetaData;
    [FieldOffset(0x0068)] public uint Version;
}

[StructLayout(LayoutKind.Explicit, Size = 0x44)] 
public unsafe struct FSplinePoint
{
    [FieldOffset(0x0000)] public float InputKey;
    [FieldOffset(0x0004)] public FVector Position;
    [FieldOffset(0x0010)] public FVector ArriveTangent;
    [FieldOffset(0x001C)] public FVector LeaveTangent;
    [FieldOffset(0x0028)] public FRotator Rotation;
    [FieldOffset(0x0034)] public FVector Scale;
    [FieldOffset(0x0040)] public ESplinePointType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x550)] 
public unsafe struct USplineComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public FSplineCurves SplineCurves;
    [FieldOffset(0x04C0)] public FInterpCurveVector SplineInfo;
    [FieldOffset(0x04D8)] public FInterpCurveQuat SplineRotInfo;
    [FieldOffset(0x04F0)] public FInterpCurveVector SplineScaleInfo;
    [FieldOffset(0x0508)] public FInterpCurveFloat SplineReparamTable;
    [FieldOffset(0x0520)] public bool bAllowSplineEditingPerInstance;
    [FieldOffset(0x0524)] public int ReparamStepsPerSegment;
    [FieldOffset(0x0528)] public float Duration;
    [FieldOffset(0x052C)] public bool bStationaryEndpoints;
    [FieldOffset(0x052D)] public bool bSplineHasBeenEdited;
    [FieldOffset(0x052E)] public bool bModifiedByConstructionScript;
    [FieldOffset(0x052F)] public bool bInputSplinePointsToConstructionScript;
    [FieldOffset(0x0530)] public bool bDrawDebug;
    [FieldOffset(0x0531)] public bool bClosedLoop;
    [FieldOffset(0x0532)] public bool bLoopPositionOverride;
    [FieldOffset(0x0534)] public float LoopPosition;
    [FieldOffset(0x0538)] public FVector DefaultUpVector;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UCameraShakeBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bSingleInstance;
    [FieldOffset(0x002C)] public float ShakeScale;
    [FieldOffset(0x0030)] public UCameraShakePattern* RootShakePattern;
    [FieldOffset(0x0038)] public APlayerCameraManager* CameraManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5F0)] 
public unsafe struct FMinimalViewInfo
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FRotator Rotation;
    [FieldOffset(0x0018)] public float FOV;
    [FieldOffset(0x001C)] public float DesiredFOV;
    [FieldOffset(0x0020)] public float OrthoWidth;
    [FieldOffset(0x0024)] public float OrthoNearClipPlane;
    [FieldOffset(0x0028)] public float OrthoFarClipPlane;
    [FieldOffset(0x002C)] public float AspectRatio;
    [FieldOffset(0x0030)] public byte bConstrainAspectRatio;
    [FieldOffset(0x0030)] public byte bUseFieldOfViewForLOD;
    [FieldOffset(0x0034)] public ECameraProjectionMode ProjectionMode;
    [FieldOffset(0x0038)] public float PostProcessBlendWeight;
    [FieldOffset(0x0040)] public FPostProcessSettings PostProcessSettings;
    [FieldOffset(0x05A0)] public FVector2D OffCenterProjectionOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FGeomSelection
{
    [FieldOffset(0x0000)] public int Type;
    [FieldOffset(0x0004)] public int Index;
    [FieldOffset(0x0008)] public int SelectionIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ABrush
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public EBrushType BrushType;
    [FieldOffset(0x0224)] public FColor BrushColor;
    [FieldOffset(0x0228)] public int PolyFlags;
    [FieldOffset(0x022C)] public byte bColored;
    [FieldOffset(0x022C)] public byte bSolidWhenSelected;
    [FieldOffset(0x022C)] public byte bPlaceableFromClassBrowser;
    [FieldOffset(0x022C)] public byte bNotForClientOrServer;
    [FieldOffset(0x0230)] public UModel* Brush;
    [FieldOffset(0x0238)] public UBrushComponent* BrushComponent;
    [FieldOffset(0x0240)] public byte bInManipulation;
    [FieldOffset(0x0248)] public TArray<FGeomSelection> SavedSelections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AVolume
{
    [FieldOffset(0x0000)] public ABrush baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FTableRowBase
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSoundConcurrencySettings
{
    [FieldOffset(0x0000)] public int MaxCount;
    [FieldOffset(0x0004)] public byte bLimitToOwner;
    [FieldOffset(0x0008)] public EMaxConcurrentResolutionRule ResolutionRule;
    [FieldOffset(0x000C)] public float RetriggerTime;
    [FieldOffset(0x0010)] public float VolumeScale;
    [FieldOffset(0x0014)] public EConcurrencyVolumeScaleMode VolumeScaleMode;
    [FieldOffset(0x0018)] public float VolumeScaleAttackTime;
    [FieldOffset(0x001C)] public byte bVolumeScaleCanRelease;
    [FieldOffset(0x0020)] public float VolumeScaleReleaseTime;
    [FieldOffset(0x0024)] public float VoiceStealReleaseTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct USoundBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public USoundClass* SoundClassObject;
    [FieldOffset(0x0038)] public byte bDebug;
    [FieldOffset(0x0038)] public byte bOverrideConcurrency;
    [FieldOffset(0x0038)] public byte bEnableBusSends;
    [FieldOffset(0x0038)] public byte bEnableBaseSubmix;
    [FieldOffset(0x0038)] public byte bEnableSubmixSends;
    [FieldOffset(0x0038)] public byte bHasDelayNode;
    [FieldOffset(0x0038)] public byte bHasConcatenatorNode;
    [FieldOffset(0x0038)] public byte bBypassVolumeScaleForPriority;
    [FieldOffset(0x0039)] public EVirtualizationMode VirtualizationMode;
    [FieldOffset(0x0090)] public TSet<IntPtr> ConcurrencySet;
    [FieldOffset(0x00E0)] public FSoundConcurrencySettings ConcurrencyOverrides;
    [FieldOffset(0x0108)] public float Duration;
    [FieldOffset(0x010C)] public float MaxDistance;
    [FieldOffset(0x0110)] public float TotalSamples;
    [FieldOffset(0x0114)] public float Priority;
    [FieldOffset(0x0118)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0120)] public USoundSubmixBase* SoundSubmixObject;
    [FieldOffset(0x0128)] public TArray<FSoundSubmixSendInfo> SoundSubmixSends;
    [FieldOffset(0x0138)] public USoundEffectSourcePresetChain* SourceEffectChain;
    [FieldOffset(0x0140)] public TArray<FSoundSourceBusSendInfo> BusSends;
    [FieldOffset(0x0150)] public TArray<FSoundSourceBusSendInfo> PreEffectBusSends;
    [FieldOffset(0x0160)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSoundModulationDestinationSettings
{
    [FieldOffset(0x0000)] public float Value;
    [FieldOffset(0x0008)] public USoundModulatorBase* Modulator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSoundModulationDefaultSettings
{
    [FieldOffset(0x0000)] public FSoundModulationDestinationSettings VolumeModulationDestination;
    [FieldOffset(0x0010)] public FSoundModulationDestinationSettings PitchModulationDestination;
    [FieldOffset(0x0020)] public FSoundModulationDestinationSettings HighpassModulationDestination;
    [FieldOffset(0x0030)] public FSoundModulationDestinationSettings LowpassModulationDestination;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FSoundModulationDefaultRoutingSettings
{
    [FieldOffset(0x0000)] public FSoundModulationDefaultSettings baseObj;
    [FieldOffset(0x0040)] public EModulationRouting VolumeRouting;
    [FieldOffset(0x0041)] public EModulationRouting PitchRouting;
    [FieldOffset(0x0042)] public EModulationRouting HighpassRouting;
    [FieldOffset(0x0043)] public EModulationRouting LowpassRouting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSoundWaveSpectralDataEntry
{
    [FieldOffset(0x0000)] public float Magnitude;
    [FieldOffset(0x0004)] public float NormalizedMagnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSoundWaveSpectralTimeData
{
    [FieldOffset(0x0000)] public TArray<FSoundWaveSpectralDataEntry> Data;
    [FieldOffset(0x0010)] public float TimeSec;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSoundWaveEnvelopeTimeData
{
    [FieldOffset(0x0000)] public float Amplitude;
    [FieldOffset(0x0004)] public float TimeSec;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSubtitleCue
{
    [FieldOffset(0x0000)] public FText Text;
    [FieldOffset(0x0018)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct USoundWave
{
    [FieldOffset(0x0000)] public USoundBase baseObj;
    [FieldOffset(0x0170)] public int CompressionQuality;
    [FieldOffset(0x0174)] public int StreamingPriority;
    [FieldOffset(0x0178)] public ESoundwaveSampleRateSettings SampleRateQuality;
    [FieldOffset(0x017A)] public ESoundGroup SoundGroup;
    [FieldOffset(0x017B)] public byte bLooping;
    [FieldOffset(0x017B)] public byte bStreaming;
    [FieldOffset(0x017B)] public byte bSeekableStreaming;
    [FieldOffset(0x017C)] public ESoundWaveLoadingBehavior LoadingBehavior;
    [FieldOffset(0x017D)] public byte bMature;
    [FieldOffset(0x017D)] public byte bManualWordWrap;
    [FieldOffset(0x017E)] public byte bSingleLine;
    [FieldOffset(0x017E)] public byte bIsAmbisonics;
    [FieldOffset(0x0180)] public FSoundModulationDefaultRoutingSettings ModulationSettings;
    [FieldOffset(0x01C8)] public TArray<float> FrequenciesToAnalyze;
    [FieldOffset(0x01D8)] public TArray<FSoundWaveSpectralTimeData> CookedSpectralTimeData;
    [FieldOffset(0x01E8)] public TArray<FSoundWaveEnvelopeTimeData> CookedEnvelopeTimeData;
    [FieldOffset(0x01F8)] public int InitialChunkSize;
    [FieldOffset(0x0240)] public FString SpokenText;
    [FieldOffset(0x0250)] public float SubtitlePriority;
    [FieldOffset(0x0254)] public float Volume;
    [FieldOffset(0x0258)] public float Pitch;
    [FieldOffset(0x025C)] public int NumChannels;
    [FieldOffset(0x0260)] public int SampleRate;
    [FieldOffset(0x0270)] public TArray<FSubtitleCue> Subtitles;
    [FieldOffset(0x0280)] public UCurveTable* Curves;
    [FieldOffset(0x0288)] public UCurveTable* InternalCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C0)] 
public unsafe struct USoundWaveProcedural
{
    [FieldOffset(0x0000)] public USoundWave baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UStreamableRenderAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public double ForceMipLevelsToBeResidentTimestamp;
    [FieldOffset(0x0048)] public int NumCinematicMipLevels;
    [FieldOffset(0x004C)] public int StreamingIndex;
    [FieldOffset(0x0050)] public int CachedCombinedLODBias;
    [FieldOffset(0x0054)] public byte NeverStream;
    [FieldOffset(0x0054)] public byte bGlobalForceMipLevelsToBeResident;
    [FieldOffset(0x0054)] public byte bHasStreamingUpdatePending;
    [FieldOffset(0x0054)] public byte bForceMiplevelsToBeResident;
    [FieldOffset(0x0054)] public byte bIgnoreStreamingMipBias;
    [FieldOffset(0x0054)] public byte bUseCinematicMipLevels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPerPlatformFloat
{
    [FieldOffset(0x0000)] public float Default;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UTexture
{
    [FieldOffset(0x0000)] public UStreamableRenderAsset baseObj;
    [FieldOffset(0x0068)] public FGuid LightingGuid;
    [FieldOffset(0x0078)] public int LODBias;
    [FieldOffset(0x007C)] public TextureCompressionSettings CompressionSettings;
    [FieldOffset(0x007D)] public TextureFilter Filter;
    [FieldOffset(0x007E)] public ETextureMipLoadOptions MipLoadOptions;
    [FieldOffset(0x007F)] public TextureGroup LODGroup;
    [FieldOffset(0x0080)] public FPerPlatformFloat Downscale;
    [FieldOffset(0x0084)] public ETextureDownscaleOptions DownscaleOptions;
    [FieldOffset(0x0085)] public byte sRGB;
    [FieldOffset(0x0085)] public byte bNoTiling;
    [FieldOffset(0x0085)] public byte VirtualTextureStreaming;
    [FieldOffset(0x0085)] public byte CompressionYCoCg;
    [FieldOffset(0x0085)] public byte bNotOfflineProcessed;
    [FieldOffset(0x0085)] public byte bAsyncResourceReleaseHasBeenStarted;
    [FieldOffset(0x0088)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpression
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UMaterial* Material;
    [FieldOffset(0x0030)] public UMaterialFunction* Function;
    [FieldOffset(0x0038)] public byte bIsParameterExpression;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FExpressionInput
{
    [FieldOffset(0x0000)] public int OutputIndex;
    [FieldOffset(0x0004)] public FName InputName;
    [FieldOffset(0x000C)] public FName ExpressionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionTextureBase
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public UTexture* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionTextureSample
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureBase baseObj;
    [FieldOffset(0x0048)] public FExpressionInput Coordinates;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureSampleParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSample baseObj;
    [FieldOffset(0x0060)] public FName ParameterName;
    [FieldOffset(0x0068)] public FGuid ExpressionGUID;
    [FieldOffset(0x0078)] public FName Group;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureSampleParameter2D
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UCommandlet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString HelpDescription;
    [FieldOffset(0x0038)] public FString HelpUsage;
    [FieldOffset(0x0048)] public FString HelpWebLink;
    [FieldOffset(0x0058)] public TArray<FString> HelpParamNames;
    [FieldOffset(0x0068)] public TArray<FString> HelpParamDescriptions;
    [FieldOffset(0x0078)] public byte IsServer;
    [FieldOffset(0x0078)] public byte IsClient;
    [FieldOffset(0x0078)] public byte IsEditor;
    [FieldOffset(0x0078)] public byte LogToConsole;
    [FieldOffset(0x0078)] public byte ShowErrorCount;
    [FieldOffset(0x0078)] public byte ShowProgress;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FPerPlatformInt
{
    [FieldOffset(0x0000)] public int Default;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FPerPlatformBool
{
    [FieldOffset(0x0000)] public bool Default;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAudioComponentParam
{
    [FieldOffset(0x0000)] public FName ParamName;
    [FieldOffset(0x0008)] public float FloatParam;
    [FieldOffset(0x000C)] public bool BoolParam;
    [FieldOffset(0x0010)] public int IntParam;
    [FieldOffset(0x0018)] public USoundWave* SoundWaveParam;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FQuartzQuantizationBoundary
{
    [FieldOffset(0x0000)] public EQuartzCommandQuantization Quantization;
    [FieldOffset(0x0004)] public float Multiplier;
    [FieldOffset(0x0008)] public EQuarztQuantizationReference CountingReferencePoint;
    [FieldOffset(0x0009)] public bool bFireOnClockStart;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSoundWaveSpectralData
{
    [FieldOffset(0x0000)] public float FrequencyHz;
    [FieldOffset(0x0004)] public float Magnitude;
    [FieldOffset(0x0008)] public float NormalizedMagnitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSoundWaveSpectralDataPerSound
{
    [FieldOffset(0x0000)] public TArray<FSoundWaveSpectralData> SpectralData;
    [FieldOffset(0x0010)] public float PlaybackTime;
    [FieldOffset(0x0018)] public USoundWave* SoundWave;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSoundWaveEnvelopeDataPerSound
{
    [FieldOffset(0x0000)] public float Envelope;
    [FieldOffset(0x0004)] public float PlaybackTime;
    [FieldOffset(0x0008)] public USoundWave* SoundWave;
}

[StructLayout(LayoutKind.Explicit, Size = 0x860)] 
public unsafe struct UAudioComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public USoundBase* Sound;
    [FieldOffset(0x0200)] public TArray<FAudioComponentParam> InstanceParameters;
    [FieldOffset(0x0210)] public USoundClass* SoundClassOverride;
    [FieldOffset(0x0218)] public byte bAutoDestroy;
    [FieldOffset(0x0218)] public byte bStopWhenOwnerDestroyed;
    [FieldOffset(0x0218)] public byte bShouldRemainActiveIfDropped;
    [FieldOffset(0x0218)] public byte bAllowSpatialization;
    [FieldOffset(0x0218)] public byte bOverrideAttenuation;
    [FieldOffset(0x0218)] public byte bOverrideSubtitlePriority;
    [FieldOffset(0x0218)] public byte bIsUISound;
    [FieldOffset(0x0218)] public byte bEnableLowPassFilter;
    [FieldOffset(0x0219)] public byte bOverridePriority;
    [FieldOffset(0x0219)] public byte bSuppressSubtitles;
    [FieldOffset(0x021A)] public byte bAutoManageAttachment;
    [FieldOffset(0x0220)] public FName AudioComponentUserID;
    [FieldOffset(0x0228)] public float PitchModulationMin;
    [FieldOffset(0x022C)] public float PitchModulationMax;
    [FieldOffset(0x0230)] public float VolumeModulationMin;
    [FieldOffset(0x0234)] public float VolumeModulationMax;
    [FieldOffset(0x0238)] public float VolumeMultiplier;
    [FieldOffset(0x023C)] public int EnvelopeFollowerAttackTime;
    [FieldOffset(0x0240)] public int EnvelopeFollowerReleaseTime;
    [FieldOffset(0x0244)] public float Priority;
    [FieldOffset(0x0248)] public float SubtitlePriority;
    [FieldOffset(0x0250)] public USoundEffectSourcePresetChain* SourceEffectChain;
    [FieldOffset(0x0258)] public float PitchMultiplier;
    [FieldOffset(0x025C)] public float LowPassFilterFrequency;
    [FieldOffset(0x0268)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0270)] public FSoundAttenuationSettings AttenuationOverrides;
    [FieldOffset(0x0610)] public USoundConcurrency* ConcurrencySettings;
    [FieldOffset(0x0618)] public TSet<IntPtr> ConcurrencySet;
    [FieldOffset(0x0674)] public EAttachmentRule AutoAttachLocationRule;
    [FieldOffset(0x0675)] public EAttachmentRule AutoAttachRotationRule;
    [FieldOffset(0x0676)] public EAttachmentRule AutoAttachScaleRule;
    [FieldOffset(0x0678)] public FSoundModulationDefaultRoutingSettings ModulationRouting;
    [FieldOffset(0x07C0)] public TWeakObjectPtr<USceneComponent> AutoAttachParent;
    [FieldOffset(0x07C8)] public FName AutoAttachSocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAssetImportData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAssetUserData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FKShapeElem
{
    [FieldOffset(0x0008)] public float RestOffset;
    [FieldOffset(0x000C)] public FName Name;
    [FieldOffset(0x0018)] public byte bContributeToMass;
    [FieldOffset(0x0019)] public ECollisionEnabled CollisionEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FKConvexElem
{
    [FieldOffset(0x0000)] public FKShapeElem baseObj;
    [FieldOffset(0x0030)] public TArray<FVector> VertexData;
    [FieldOffset(0x0040)] public TArray<int> IndexData;
    [FieldOffset(0x0050)] public FBox ElemBox;
    [FieldOffset(0x0070)] public FTransform Transform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UMovementComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public USceneComponent* UpdatedComponent;
    [FieldOffset(0x00B8)] public UPrimitiveComponent* UpdatedPrimitive;
    [FieldOffset(0x00C4)] public FVector Velocity;
    [FieldOffset(0x00D0)] public FVector PlaneConstraintNormal;
    [FieldOffset(0x00DC)] public FVector PlaneConstraintOrigin;
    [FieldOffset(0x00E8)] public byte bUpdateOnlyIfRendered;
    [FieldOffset(0x00E8)] public byte bAutoUpdateTickRegistration;
    [FieldOffset(0x00E8)] public byte bTickBeforeOwner;
    [FieldOffset(0x00E8)] public byte bAutoRegisterUpdatedComponent;
    [FieldOffset(0x00E8)] public byte bConstrainToPlane;
    [FieldOffset(0x00E8)] public byte bSnapToPlaneAtStart;
    [FieldOffset(0x00E8)] public byte bAutoRegisterPhysicsVolumeUpdates;
    [FieldOffset(0x00E8)] public byte bComponentShouldUpdatePhysicsVolume;
    [FieldOffset(0x00EB)] public EPlaneConstraintAxisSetting PlaneConstraintAxisSetting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FMovementProperties
{
    [FieldOffset(0x0000)] public byte bCanCrouch;
    [FieldOffset(0x0000)] public byte bCanJump;
    [FieldOffset(0x0000)] public byte bCanWalk;
    [FieldOffset(0x0000)] public byte bCanSwim;
    [FieldOffset(0x0000)] public byte bCanFly;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNavAgentProperties
{
    [FieldOffset(0x0000)] public FMovementProperties baseObj;
    [FieldOffset(0x0004)] public float AgentRadius;
    [FieldOffset(0x0008)] public float AgentHeight;
    [FieldOffset(0x000C)] public float AgentStepHeight;
    [FieldOffset(0x0010)] public float NavWalkingSearchHeightScale;
    [FieldOffset(0x0018)] public FSoftClassPath PreferredNavData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UNavMovementComponent
{
    [FieldOffset(0x0000)] public UMovementComponent baseObj;
    [FieldOffset(0x00F0)] public FNavAgentProperties NavAgentProps;
    [FieldOffset(0x0120)] public float FixedPathBrakingDistance;
    [FieldOffset(0x0124)] public byte bUpdateNavAgentWithOwnersCollision;
    [FieldOffset(0x0124)] public byte bUseAccelerationForPaths;
    [FieldOffset(0x0124)] public byte bUseFixedBrakingDistanceForPaths;
    [FieldOffset(0x0125)] public FMovementProperties MovementState;
    [FieldOffset(0x0128)] public UObject* PathFollowingComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UPawnMovementComponent
{
    [FieldOffset(0x0000)] public UNavMovementComponent baseObj;
    [FieldOffset(0x0130)] public APawn* PawnOwner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x94)] 
public unsafe struct FFindFloorResult
{
    [FieldOffset(0x0000)] public byte bBlockingHit;
    [FieldOffset(0x0000)] public byte bWalkableFloor;
    [FieldOffset(0x0000)] public byte bLineTrace;
    [FieldOffset(0x0004)] public float FloorDist;
    [FieldOffset(0x0008)] public float LineDist;
    [FieldOffset(0x000C)] public FHitResult HitResult;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNavAvoidanceMask
{
    [FieldOffset(0x0000)] public byte bGroup0;
    [FieldOffset(0x0000)] public byte bGroup1;
    [FieldOffset(0x0000)] public byte bGroup2;
    [FieldOffset(0x0000)] public byte bGroup3;
    [FieldOffset(0x0000)] public byte bGroup4;
    [FieldOffset(0x0000)] public byte bGroup5;
    [FieldOffset(0x0000)] public byte bGroup6;
    [FieldOffset(0x0000)] public byte bGroup7;
    [FieldOffset(0x0001)] public byte bGroup8;
    [FieldOffset(0x0001)] public byte bGroup9;
    [FieldOffset(0x0001)] public byte bGroup10;
    [FieldOffset(0x0001)] public byte bGroup11;
    [FieldOffset(0x0001)] public byte bGroup12;
    [FieldOffset(0x0001)] public byte bGroup13;
    [FieldOffset(0x0001)] public byte bGroup14;
    [FieldOffset(0x0001)] public byte bGroup15;
    [FieldOffset(0x0002)] public byte bGroup16;
    [FieldOffset(0x0002)] public byte bGroup17;
    [FieldOffset(0x0002)] public byte bGroup18;
    [FieldOffset(0x0002)] public byte bGroup19;
    [FieldOffset(0x0002)] public byte bGroup20;
    [FieldOffset(0x0002)] public byte bGroup21;
    [FieldOffset(0x0002)] public byte bGroup22;
    [FieldOffset(0x0002)] public byte bGroup23;
    [FieldOffset(0x0003)] public byte bGroup24;
    [FieldOffset(0x0003)] public byte bGroup25;
    [FieldOffset(0x0003)] public byte bGroup26;
    [FieldOffset(0x0003)] public byte bGroup27;
    [FieldOffset(0x0003)] public byte bGroup28;
    [FieldOffset(0x0003)] public byte bGroup29;
    [FieldOffset(0x0003)] public byte bGroup30;
    [FieldOffset(0x0003)] public byte bGroup31;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCharacterMovementComponentPostPhysicsTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xAF0)] 
public unsafe struct UCharacterMovementComponent
{
    [FieldOffset(0x0000)] public UPawnMovementComponent baseObj;
    [FieldOffset(0x0148)] public ACharacter* CharacterOwner;
    [FieldOffset(0x0150)] public float GravityScale;
    [FieldOffset(0x0154)] public float MaxStepHeight;
    [FieldOffset(0x0158)] public float JumpZVelocity;
    [FieldOffset(0x015C)] public float JumpOffJumpZFactor;
    [FieldOffset(0x0160)] public float WalkableFloorAngle;
    [FieldOffset(0x0164)] public float WalkableFloorZ;
    [FieldOffset(0x0168)] public EMovementMode MovementMode;
    [FieldOffset(0x0169)] public byte CustomMovementMode;
    [FieldOffset(0x016A)] public ENetworkSmoothingMode NetworkSmoothingMode;
    [FieldOffset(0x016C)] public float GroundFriction;
    [FieldOffset(0x018C)] public float MaxWalkSpeed;
    [FieldOffset(0x0190)] public float MaxWalkSpeedCrouched;
    [FieldOffset(0x0194)] public float MaxSwimSpeed;
    [FieldOffset(0x0198)] public float MaxFlySpeed;
    [FieldOffset(0x019C)] public float MaxCustomMovementSpeed;
    [FieldOffset(0x01A0)] public float MaxAcceleration;
    [FieldOffset(0x01A4)] public float MinAnalogWalkSpeed;
    [FieldOffset(0x01A8)] public float BrakingFrictionFactor;
    [FieldOffset(0x01AC)] public float BrakingFriction;
    [FieldOffset(0x01B0)] public float BrakingSubStepTime;
    [FieldOffset(0x01B4)] public float BrakingDecelerationWalking;
    [FieldOffset(0x01B8)] public float BrakingDecelerationFalling;
    [FieldOffset(0x01BC)] public float BrakingDecelerationSwimming;
    [FieldOffset(0x01C0)] public float BrakingDecelerationFlying;
    [FieldOffset(0x01C4)] public float AirControl;
    [FieldOffset(0x01C8)] public float AirControlBoostMultiplier;
    [FieldOffset(0x01CC)] public float AirControlBoostVelocityThreshold;
    [FieldOffset(0x01D0)] public float FallingLateralFriction;
    [FieldOffset(0x01D4)] public float CrouchedHalfHeight;
    [FieldOffset(0x01D8)] public float Buoyancy;
    [FieldOffset(0x01DC)] public float PerchRadiusThreshold;
    [FieldOffset(0x01E0)] public float PerchAdditionalHeight;
    [FieldOffset(0x01E4)] public FRotator RotationRate;
    [FieldOffset(0x01F0)] public byte bUseSeparateBrakingFriction;
    [FieldOffset(0x01F0)] public byte bApplyGravityWhileJumping;
    [FieldOffset(0x01F0)] public byte bUseControllerDesiredRotation;
    [FieldOffset(0x01F0)] public byte bOrientRotationToMovement;
    [FieldOffset(0x01F0)] public byte bSweepWhileNavWalking;
    [FieldOffset(0x01F0)] public byte bMovementInProgress;
    [FieldOffset(0x01F0)] public byte bEnableScopedMovementUpdates;
    [FieldOffset(0x01F1)] public byte bEnableServerDualMoveScopedMovementUpdates;
    [FieldOffset(0x01F1)] public byte bForceMaxAccel;
    [FieldOffset(0x01F1)] public byte bRunPhysicsWithNoController;
    [FieldOffset(0x01F1)] public byte bForceNextFloorCheck;
    [FieldOffset(0x01F1)] public byte bShrinkProxyCapsule;
    [FieldOffset(0x01F1)] public byte bCanWalkOffLedges;
    [FieldOffset(0x01F1)] public byte bCanWalkOffLedgesWhenCrouching;
    [FieldOffset(0x01F2)] public byte bNetworkSkipProxyPredictionOnNetUpdate;
    [FieldOffset(0x01F2)] public byte bNetworkAlwaysReplicateTransformUpdateTimestamp;
    [FieldOffset(0x01F2)] public byte bDeferUpdateMoveComponent;
    [FieldOffset(0x01F2)] public byte bEnablePhysicsInteraction;
    [FieldOffset(0x01F2)] public byte bTouchForceScaledToMass;
    [FieldOffset(0x01F2)] public byte bPushForceScaledToMass;
    [FieldOffset(0x01F2)] public byte bPushForceUsingZOffset;
    [FieldOffset(0x01F3)] public byte bScalePushForceToVelocity;
    [FieldOffset(0x01F8)] public USceneComponent* DeferredUpdatedMoveComponent;
    [FieldOffset(0x0200)] public float MaxOutOfWaterStepHeight;
    [FieldOffset(0x0204)] public float OutofWaterZ;
    [FieldOffset(0x0208)] public float Mass;
    [FieldOffset(0x020C)] public float StandingDownwardForceScale;
    [FieldOffset(0x0210)] public float InitialPushForceFactor;
    [FieldOffset(0x0214)] public float PushForceFactor;
    [FieldOffset(0x0218)] public float PushForcePointZOffsetFactor;
    [FieldOffset(0x021C)] public float TouchForceFactor;
    [FieldOffset(0x0220)] public float MinTouchForce;
    [FieldOffset(0x0224)] public float MaxTouchForce;
    [FieldOffset(0x0228)] public float RepulsionForce;
    [FieldOffset(0x022C)] public FVector Acceleration;
    [FieldOffset(0x0240)] public FQuat LastUpdateRotation;
    [FieldOffset(0x0250)] public FVector LastUpdateLocation;
    [FieldOffset(0x025C)] public FVector LastUpdateVelocity;
    [FieldOffset(0x0268)] public float ServerLastTransformUpdateTimeStamp;
    [FieldOffset(0x026C)] public float ServerLastClientGoodMoveAckTime;
    [FieldOffset(0x0270)] public float ServerLastClientAdjustmentTime;
    [FieldOffset(0x0274)] public FVector PendingImpulseToApply;
    [FieldOffset(0x0280)] public FVector PendingForceToApply;
    [FieldOffset(0x028C)] public float AnalogInputModifier;
    [FieldOffset(0x029C)] public float MaxSimulationTimeStep;
    [FieldOffset(0x02A0)] public int MaxSimulationIterations;
    [FieldOffset(0x02A4)] public int MaxJumpApexAttemptsPerSimulation;
    [FieldOffset(0x02A8)] public float MaxDepenetrationWithGeometry;
    [FieldOffset(0x02AC)] public float MaxDepenetrationWithGeometryAsProxy;
    [FieldOffset(0x02B0)] public float MaxDepenetrationWithPawn;
    [FieldOffset(0x02B4)] public float MaxDepenetrationWithPawnAsProxy;
    [FieldOffset(0x02B8)] public float NetworkSimulatedSmoothLocationTime;
    [FieldOffset(0x02BC)] public float NetworkSimulatedSmoothRotationTime;
    [FieldOffset(0x02C0)] public float ListenServerNetworkSimulatedSmoothLocationTime;
    [FieldOffset(0x02C4)] public float ListenServerNetworkSimulatedSmoothRotationTime;
    [FieldOffset(0x02C8)] public float NetProxyShrinkRadius;
    [FieldOffset(0x02CC)] public float NetProxyShrinkHalfHeight;
    [FieldOffset(0x02D0)] public float NetworkMaxSmoothUpdateDistance;
    [FieldOffset(0x02D4)] public float NetworkNoSmoothUpdateDistance;
    [FieldOffset(0x02D8)] public float NetworkMinTimeBetweenClientAckGoodMoves;
    [FieldOffset(0x02DC)] public float NetworkMinTimeBetweenClientAdjustments;
    [FieldOffset(0x02E0)] public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;
    [FieldOffset(0x02E4)] public float NetworkLargeClientCorrectionDistance;
    [FieldOffset(0x02E8)] public float LedgeCheckThreshold;
    [FieldOffset(0x02EC)] public float JumpOutOfWaterPitch;
    [FieldOffset(0x02F0)] public FFindFloorResult CurrentFloor;
    [FieldOffset(0x0384)] public EMovementMode DefaultLandMovementMode;
    [FieldOffset(0x0385)] public EMovementMode DefaultWaterMovementMode;
    [FieldOffset(0x0386)] public EMovementMode GroundMovementMode;
    [FieldOffset(0x0387)] public byte bMaintainHorizontalGroundVelocity;
    [FieldOffset(0x0387)] public byte bImpartBaseVelocityX;
    [FieldOffset(0x0387)] public byte bImpartBaseVelocityY;
    [FieldOffset(0x0387)] public byte bImpartBaseVelocityZ;
    [FieldOffset(0x0387)] public byte bImpartBaseAngularVelocity;
    [FieldOffset(0x0387)] public byte bJustTeleported;
    [FieldOffset(0x0387)] public byte bNetworkUpdateReceived;
    [FieldOffset(0x0387)] public byte bNetworkMovementModeChanged;
    [FieldOffset(0x0388)] public byte bIgnoreClientMovementErrorChecksAndCorrection;
    [FieldOffset(0x0388)] public byte bServerAcceptClientAuthoritativePosition;
    [FieldOffset(0x0388)] public byte bNotifyApex;
    [FieldOffset(0x0388)] public byte bCheatFlying;
    [FieldOffset(0x0388)] public byte bWantsToCrouch;
    [FieldOffset(0x0388)] public byte bCrouchMaintainsBaseLocation;
    [FieldOffset(0x0388)] public byte bIgnoreBaseRotation;
    [FieldOffset(0x0388)] public byte bFastAttachedMove;
    [FieldOffset(0x0389)] public byte bAlwaysCheckFloor;
    [FieldOffset(0x0389)] public byte bUseFlatBaseForFloorChecks;
    [FieldOffset(0x0389)] public byte bPerformingJumpOff;
    [FieldOffset(0x0389)] public byte bWantsToLeaveNavWalking;
    [FieldOffset(0x0389)] public byte bUseRVOAvoidance;
    [FieldOffset(0x0389)] public byte bRequestedMoveUseAcceleration;
    [FieldOffset(0x0389)] public byte bWasSimulatingRootMotion;
    [FieldOffset(0x038A)] public byte bAllowPhysicsRotationDuringAnimRootMotion;
    [FieldOffset(0x038A)] public byte bHasRequestedVelocity;
    [FieldOffset(0x038A)] public byte bRequestedMoveWithMaxSpeed;
    [FieldOffset(0x038A)] public byte bWasAvoidanceUpdated;
    [FieldOffset(0x038A)] public byte bProjectNavMeshWalking;
    [FieldOffset(0x038A)] public byte bProjectNavMeshOnBothWorldChannels;
    [FieldOffset(0x039C)] public float AvoidanceConsiderationRadius;
    [FieldOffset(0x03A0)] public FVector RequestedVelocity;
    [FieldOffset(0x03AC)] public int AvoidanceUID;
    [FieldOffset(0x03B0)] public FNavAvoidanceMask AvoidanceGroup;
    [FieldOffset(0x03B4)] public FNavAvoidanceMask GroupsToAvoid;
    [FieldOffset(0x03B8)] public FNavAvoidanceMask GroupsToIgnore;
    [FieldOffset(0x03BC)] public float AvoidanceWeight;
    [FieldOffset(0x03C0)] public FVector PendingLaunchVelocity;
    [FieldOffset(0x0470)] public float NavMeshProjectionInterval;
    [FieldOffset(0x0474)] public float NavMeshProjectionTimer;
    [FieldOffset(0x0478)] public float NavMeshProjectionInterpSpeed;
    [FieldOffset(0x047C)] public float NavMeshProjectionHeightScaleUp;
    [FieldOffset(0x0480)] public float NavMeshProjectionHeightScaleDown;
    [FieldOffset(0x0484)] public float NavWalkingFloorDistTolerance;
    [FieldOffset(0x0488)] public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction;
    [FieldOffset(0x04D0)] public float MinTimeBetweenTimeStampResets;
    [FieldOffset(0x0980)] public FRootMotionSourceGroup CurrentRootMotion;
    [FieldOffset(0x09B8)] public FRootMotionSourceGroup ServerCorrectionRootMotion;
    [FieldOffset(0x0A80)] public FRootMotionMovementParams RootMotionParams;
    [FieldOffset(0x0AC0)] public FVector AnimRootMotionVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDynamicSubsystem
{
    [FieldOffset(0x0000)] public USubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEngineSubsystem
{
    [FieldOffset(0x0000)] public UDynamicSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FComponentReference
{
    [FieldOffset(0x0000)] public AActor* OtherActor;
    [FieldOffset(0x0008)] public FName ComponentProperty;
    [FieldOffset(0x0010)] public FString PathToComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USoundEffectPreset
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USoundEffectSourcePreset
{
    [FieldOffset(0x0000)] public USoundEffectPreset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USoundEffectSubmixPreset
{
    [FieldOffset(0x0000)] public USoundEffectPreset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UShapeComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UBodySetup* ShapeBodySetup;
    [FieldOffset(0x0458)] public TSubclassOf<UNavAreaBase> AreaClass;
    [FieldOffset(0x0460)] public FColor ShapeColor;
    [FieldOffset(0x0464)] public byte bDrawOnlyIfSelected;
    [FieldOffset(0x0464)] public byte bShouldCollideWhenPlacing;
    [FieldOffset(0x0464)] public byte bDynamicObstacle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x480)] 
public unsafe struct UBoxComponent
{
    [FieldOffset(0x0000)] public UShapeComponent baseObj;
    [FieldOffset(0x0468)] public FVector BoxExtent;
    [FieldOffset(0x0474)] public float LineThickness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct USphereComponent
{
    [FieldOffset(0x0000)] public UShapeComponent baseObj;
    [FieldOffset(0x0468)] public float SphereRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ATriggerVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UCheatManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ADebugCameraController* DebugCameraControllerRef;
    [FieldOffset(0x0030)] public TSubclassOf<ADebugCameraController> DebugCameraControllerClass;
    [FieldOffset(0x0078)] public TArray<IntPtr> CheatManagerExtensions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ASceneCapture
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UStaticMeshComponent* MeshComp;
    [FieldOffset(0x0228)] public USceneComponent* SceneComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ASceneCapture2D
{
    [FieldOffset(0x0000)] public ASceneCapture baseObj;
    [FieldOffset(0x0230)] public USceneCaptureComponent2D* CaptureComponent2D;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7B0)] 
public unsafe struct ACameraActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public EAutoReceiveInput AutoActivateForPlayer;
    [FieldOffset(0x0228)] public UCameraComponent* CameraComponent;
    [FieldOffset(0x0230)] public USceneComponent* SceneComponent;
    [FieldOffset(0x0240)] public byte bConstrainAspectRatio;
    [FieldOffset(0x0244)] public float AspectRatio;
    [FieldOffset(0x0248)] public float FOVAngle;
    [FieldOffset(0x024C)] public float PostProcessBlendWeight;
    [FieldOffset(0x0250)] public FPostProcessSettings PostProcessSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct ANavigationObjectBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public UCapsuleComponent* CapsuleComponent;
    [FieldOffset(0x0230)] public UBillboardComponent* GoodSprite;
    [FieldOffset(0x0238)] public UBillboardComponent* BadSprite;
    [FieldOffset(0x0240)] public byte bIsPIEPlayerStart;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct APlayerStart
{
    [FieldOffset(0x0000)] public ANavigationObjectBase baseObj;
    [FieldOffset(0x0248)] public FName PlayerStartTag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AInfo
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AGameModeBase
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public FString OptionsString;
    [FieldOffset(0x0230)] public TSubclassOf<AGameSession> GameSessionClass;
    [FieldOffset(0x0238)] public TSubclassOf<AGameStateBase> GameStateClass;
    [FieldOffset(0x0240)] public TSubclassOf<APlayerController> PlayerControllerClass;
    [FieldOffset(0x0248)] public TSubclassOf<APlayerState> PlayerStateClass;
    [FieldOffset(0x0250)] public TSubclassOf<AHUD> HUDClass;
    [FieldOffset(0x0258)] public TSubclassOf<APawn> DefaultPawnClass;
    [FieldOffset(0x0260)] public TSubclassOf<ASpectatorPawn> SpectatorClass;
    [FieldOffset(0x0268)] public TSubclassOf<APlayerController> ReplaySpectatorPlayerControllerClass;
    [FieldOffset(0x0270)] public TSubclassOf<AServerStatReplicator> ServerStatReplicatorClass;
    [FieldOffset(0x0278)] public AGameSession* GameSession;
    [FieldOffset(0x0280)] public AGameStateBase* GameState;
    [FieldOffset(0x0288)] public AServerStatReplicator* ServerStatReplicator;
    [FieldOffset(0x0290)] public FText DefaultPlayerName;
    [FieldOffset(0x02A8)] public byte bUseSeamlessTravel;
    [FieldOffset(0x02A8)] public byte bStartPlayersAsSpectators;
    [FieldOffset(0x02A8)] public byte bPauseable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNameCurveKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public FName Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FNameCurve
{
    [FieldOffset(0x0000)] public FIndexedCurve baseObj;
    [FieldOffset(0x0068)] public TArray<FNameCurveKey> Keys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FDebugTextInfo
{
    [FieldOffset(0x0000)] public AActor* SrcActor;
    [FieldOffset(0x0008)] public FVector SrcActorOffset;
    [FieldOffset(0x0014)] public FVector SrcActorDesiredOffset;
    [FieldOffset(0x0020)] public FString DebugText;
    [FieldOffset(0x0030)] public float TimeRemaining;
    [FieldOffset(0x0034)] public float Duration;
    [FieldOffset(0x0038)] public FColor TextColor;
    [FieldOffset(0x003C)] public byte bAbsoluteLocation;
    [FieldOffset(0x003C)] public byte bKeepAttachedToActor;
    [FieldOffset(0x003C)] public byte bDrawShadow;
    [FieldOffset(0x0040)] public FVector OrigActorLocation;
    [FieldOffset(0x0050)] public UFont* Font;
    [FieldOffset(0x0058)] public float FontScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AHUD
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public APlayerController* PlayerOwner;
    [FieldOffset(0x0228)] public byte bLostFocusPaused;
    [FieldOffset(0x0228)] public byte bShowHUD;
    [FieldOffset(0x0228)] public byte bShowDebugInfo;
    [FieldOffset(0x022C)] public int CurrentTargetIndex;
    [FieldOffset(0x0230)] public byte bShowHitBoxDebugInfo;
    [FieldOffset(0x0230)] public byte bShowOverlays;
    [FieldOffset(0x0230)] public byte bEnableDebugTextShadow;
    [FieldOffset(0x0238)] public TArray<IntPtr> PostRenderedActors;
    [FieldOffset(0x0250)] public TArray<FName> DebugDisplay;
    [FieldOffset(0x0260)] public TArray<FName> ToggledDebugCategories;
    [FieldOffset(0x0270)] public UCanvas* Canvas;
    [FieldOffset(0x0278)] public UCanvas* DebugCanvas;
    [FieldOffset(0x0280)] public TArray<FDebugTextInfo> DebugTextList;
    [FieldOffset(0x0290)] public TSubclassOf<AActor> ShowDebugTargetDesiredClass;
    [FieldOffset(0x0298)] public AActor* ShowDebugTargetActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCollectionParameterBase
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public FGuid ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCollectionScalarParameter
{
    [FieldOffset(0x0000)] public FCollectionParameterBase baseObj;
    [FieldOffset(0x0018)] public float DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCollectionVectorParameter
{
    [FieldOffset(0x0000)] public FCollectionParameterBase baseObj;
    [FieldOffset(0x0018)] public FLinearColor DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x478)] 
public unsafe struct UAssetManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x02E0)] public TArray<IntPtr> ObjectReferenceList;
    [FieldOffset(0x02F0)] public bool bIsGlobalAsyncScanEnvironment;
    [FieldOffset(0x02F1)] public bool bShouldGuessTypeAndName;
    [FieldOffset(0x02F2)] public bool bShouldUseSynchronousLoad;
    [FieldOffset(0x02F3)] public bool bIsLoadingFromPakFiles;
    [FieldOffset(0x02F4)] public bool bShouldAcquireMissingChunksOnLoad;
    [FieldOffset(0x02F5)] public bool bOnlyCookProductionAssets;
    [FieldOffset(0x02F6)] public bool bIsBulkScanning;
    [FieldOffset(0x02F7)] public bool bIsPrimaryAssetDirectoryCurrent;
    [FieldOffset(0x02F8)] public bool bIsManagementDatabaseCurrent;
    [FieldOffset(0x02F9)] public bool bUpdateManagementDatabaseAfterScan;
    [FieldOffset(0x02FA)] public bool bIncludeOnlyOnDiskAssets;
    [FieldOffset(0x02FB)] public bool bHasCompletedInitialScan;
    [FieldOffset(0x02FC)] public int NumberOfSpawnedNotifications;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UPrimaryDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FPrimaryAssetRules
{
    [FieldOffset(0x0000)] public int Priority;
    [FieldOffset(0x0004)] public int ChunkId;
    [FieldOffset(0x0008)] public bool bApplyRecursively;
    [FieldOffset(0x0009)] public EPrimaryAssetCookRule CookRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCollectionReference
{
    [FieldOffset(0x0000)] public FName CollectionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UPrimaryAssetLabel
{
    [FieldOffset(0x0000)] public UPrimaryDataAsset baseObj;
    [FieldOffset(0x0030)] public FPrimaryAssetRules Rules;
    [FieldOffset(0x003C)] public byte bLabelAssetsInMyDirectory;
    [FieldOffset(0x003C)] public byte bIsRuntimeLabel;
    [FieldOffset(0x0040)] public TArray<TSoftObjectPtr<UObject>> ExplicitAssets;
    [FieldOffset(0x0050)] public TArray<TSoftClassPtr<UObject>> ExplicitBlueprints;
    [FieldOffset(0x0060)] public FCollectionReference AssetCollection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USaveGame
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AGameMode
{
    [FieldOffset(0x0000)] public AGameModeBase baseObj;
    [FieldOffset(0x02C0)] public FName MatchState;
    [FieldOffset(0x02C8)] public byte bDelayedStart;
    [FieldOffset(0x02CC)] public int NumSpectators;
    [FieldOffset(0x02D0)] public int NumPlayers;
    [FieldOffset(0x02D4)] public int NumBots;
    [FieldOffset(0x02D8)] public float MinRespawnDelay;
    [FieldOffset(0x02DC)] public int NumTravellingPlayers;
    [FieldOffset(0x02E0)] public TSubclassOf<ULocalMessage> EngineMessageClass;
    [FieldOffset(0x02E8)] public TArray<IntPtr> InactivePlayerArray;
    [FieldOffset(0x02F8)] public float InactivePlayerStateLifeSpan;
    [FieldOffset(0x02FC)] public int MaxInactivePlayers;
    [FieldOffset(0x0300)] public bool bHandleDedicatedServerReplays;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct AGameStateBase
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public TSubclassOf<AGameModeBase> GameModeClass;
    [FieldOffset(0x0228)] public AGameModeBase* AuthorityGameMode;
    [FieldOffset(0x0230)] public TSubclassOf<ASpectatorPawn> SpectatorClass;
    [FieldOffset(0x0238)] public TArray<IntPtr> PlayerArray;
    [FieldOffset(0x0248)] public bool bReplicatedHasBegunPlay;
    [FieldOffset(0x024C)] public float ReplicatedWorldTimeSeconds;
    [FieldOffset(0x0250)] public float ServerWorldTimeSecondsDelta;
    [FieldOffset(0x0254)] public float ServerWorldTimeSecondsUpdateFrequency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AGameState
{
    [FieldOffset(0x0000)] public AGameStateBase baseObj;
    [FieldOffset(0x0270)] public FName MatchState;
    [FieldOffset(0x0278)] public FName PreviousMatchState;
    [FieldOffset(0x0280)] public int ElapsedTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ASkyLight
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public USkyLightComponent* LightComponent;
    [FieldOffset(0x0228)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UTextureCube
{
    [FieldOffset(0x0000)] public UTexture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FStaticMeshComponentLODInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FStreamingTextureBuildInfo
{
    [FieldOffset(0x0000)] public uint PackedRelativeBox;
    [FieldOffset(0x0004)] public int TextureLevelIndex;
    [FieldOffset(0x0008)] public float TexelFactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FLightmassPrimitiveSettings
{
    [FieldOffset(0x0000)] public byte bUseTwoSidedLighting;
    [FieldOffset(0x0000)] public byte bShadowIndirectOnly;
    [FieldOffset(0x0000)] public byte bUseEmissiveForStaticLighting;
    [FieldOffset(0x0000)] public byte bUseVertexNormalForHemisphereGather;
    [FieldOffset(0x0004)] public float EmissiveLightFalloffExponent;
    [FieldOffset(0x0008)] public float EmissiveLightExplicitInfluenceRadius;
    [FieldOffset(0x000C)] public float EmissiveBoost;
    [FieldOffset(0x0010)] public float DiffuseBoost;
    [FieldOffset(0x0014)] public float FullyOccludedSamplesFraction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E0)] 
public unsafe struct UStaticMeshComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public int ForcedLodModel;
    [FieldOffset(0x047C)] public int PreviousLODLevel;
    [FieldOffset(0x0480)] public int MinLOD;
    [FieldOffset(0x0484)] public int SubDivisionStepSize;
    [FieldOffset(0x0488)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0490)] public FColor WireframeColorOverride;
    [FieldOffset(0x0494)] public byte bEvaluateWorldPositionOffset;
    [FieldOffset(0x0494)] public byte bOverrideWireframeColor;
    [FieldOffset(0x0494)] public byte bOverrideMinLOD;
    [FieldOffset(0x0494)] public byte bOverrideNavigationExport;
    [FieldOffset(0x0494)] public byte bForceNavigationObstacle;
    [FieldOffset(0x0494)] public byte bDisallowMeshPaintPerInstance;
    [FieldOffset(0x0494)] public byte bIgnoreInstanceForTextureStreaming;
    [FieldOffset(0x0494)] public byte bOverrideLightMapRes;
    [FieldOffset(0x0495)] public byte bCastDistanceFieldIndirectShadow;
    [FieldOffset(0x0495)] public byte bOverrideDistanceFieldSelfShadowBias;
    [FieldOffset(0x0495)] public byte bUseSubDivisions;
    [FieldOffset(0x0495)] public byte bUseDefaultCollision;
    [FieldOffset(0x0495)] public byte bReverseCulling;
    [FieldOffset(0x0498)] public int OverriddenLightMapRes;
    [FieldOffset(0x049C)] public float DistanceFieldIndirectShadowMinVisibility;
    [FieldOffset(0x04A0)] public float DistanceFieldSelfShadowBias;
    [FieldOffset(0x04A4)] public float StreamingDistanceMultiplier;
    [FieldOffset(0x04A8)] public TArray<FStaticMeshComponentLODInfo> LODData;
    [FieldOffset(0x04B8)] public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
    [FieldOffset(0x04C8)] public FLightmassPrimitiveSettings LightmassSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FInstancedStaticMeshInstanceData
{
    [FieldOffset(0x0000)] public FMatrix Transform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInstancedStaticMeshMappingInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x590)] 
public unsafe struct UInstancedStaticMeshComponent
{
    [FieldOffset(0x0000)] public UStaticMeshComponent baseObj;
    [FieldOffset(0x04E0)] public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
    [FieldOffset(0x04F0)] public int NumCustomDataFloats;
    [FieldOffset(0x04F8)] public TArray<float> PerInstanceSMCustomData;
    [FieldOffset(0x0508)] public int InstancingRandomSeed;
    [FieldOffset(0x050C)] public int InstanceStartCullDistance;
    [FieldOffset(0x0510)] public int InstanceEndCullDistance;
    [FieldOffset(0x0518)] public TArray<int> InstanceReorderTable;
    [FieldOffset(0x0570)] public int NumPendingLightmaps;
    [FieldOffset(0x0578)] public TArray<FInstancedStaticMeshMappingInfo> CachedMappings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x680)] 
public unsafe struct UHierarchicalInstancedStaticMeshComponent
{
    [FieldOffset(0x0000)] public UInstancedStaticMeshComponent baseObj;
    [FieldOffset(0x0598)] public TArray<int> SortedInstances;
    [FieldOffset(0x05A8)] public int NumBuiltInstances;
    [FieldOffset(0x05B0)] public FBox BuiltInstanceBounds;
    [FieldOffset(0x05CC)] public FBox UnbuiltInstanceBounds;
    [FieldOffset(0x05E8)] public TArray<FBox> UnbuiltInstanceBoundsList;
    [FieldOffset(0x05F8)] public byte bEnableDensityScaling;
    [FieldOffset(0x0600)] public int OcclusionLayerNumNodes;
    [FieldOffset(0x0604)] public FBoxSphereBounds CacheMeshExtendedBounds;
    [FieldOffset(0x0620)] public bool bDisableCollision;
    [FieldOffset(0x0624)] public int InstanceCountToRender;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AStaticMeshActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UStaticMeshComponent* StaticMeshComponent;
    [FieldOffset(0x0228)] public bool bStaticMeshReplicateMovement;
    [FieldOffset(0x0229)] public ENavDataGatheringMode NavigationGeometryGatheringMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLightmassMaterialInterfaceSettings
{
    [FieldOffset(0x0000)] public float EmissiveBoost;
    [FieldOffset(0x0004)] public float DiffuseBoost;
    [FieldOffset(0x0008)] public float ExportResolutionScale;
    [FieldOffset(0x000C)] public byte bCastShadowAsMasked;
    [FieldOffset(0x000C)] public byte bOverrideCastShadowAsMasked;
    [FieldOffset(0x000C)] public byte bOverrideEmissiveBoost;
    [FieldOffset(0x000C)] public byte bOverrideDiffuseBoost;
    [FieldOffset(0x000C)] public byte bOverrideExportResolutionScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMaterialTextureInfo
{
    [FieldOffset(0x0000)] public float SamplingScale;
    [FieldOffset(0x0004)] public int UVChannelIndex;
    [FieldOffset(0x0008)] public FName TextureName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMaterialParameterInfo
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public EMaterialParameterAssociation Association;
    [FieldOffset(0x000C)] public int Index;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public USubsurfaceProfile* SubsurfaceProfile;
    [FieldOffset(0x0050)] public FLightmassMaterialInterfaceSettings LightmassSettings;
    [FieldOffset(0x0060)] public TArray<FMaterialTextureInfo> TextureStreamingData;
    [FieldOffset(0x0070)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FScalarParameterValue
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public float ParameterValue;
    [FieldOffset(0x0014)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FVectorParameterValue
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public FLinearColor ParameterValue;
    [FieldOffset(0x0020)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTextureParameterValue
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public UTexture* ParameterValue;
    [FieldOffset(0x0018)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FRuntimeVirtualTextureParameterValue
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public URuntimeVirtualTexture* ParameterValue;
    [FieldOffset(0x0018)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFontParameterValue
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public UFont* FontValue;
    [FieldOffset(0x0018)] public int FontPage;
    [FieldOffset(0x001C)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMaterialInstanceBasePropertyOverrides
{
    [FieldOffset(0x0000)] public byte bOverride_OpacityMaskClipValue;
    [FieldOffset(0x0000)] public byte bOverride_BlendMode;
    [FieldOffset(0x0000)] public byte bOverride_ShadingModel;
    [FieldOffset(0x0000)] public byte bOverride_DitheredLODTransition;
    [FieldOffset(0x0000)] public byte bOverride_CastDynamicShadowAsMasked;
    [FieldOffset(0x0000)] public byte bOverride_TwoSided;
    [FieldOffset(0x0000)] public byte TwoSided;
    [FieldOffset(0x0000)] public byte DitheredLODTransition;
    [FieldOffset(0x0001)] public byte bCastDynamicShadowAsMasked;
    [FieldOffset(0x0002)] public EBlendMode BlendMode;
    [FieldOffset(0x0003)] public EMaterialShadingModel ShadingModel;
    [FieldOffset(0x0004)] public float OpacityMaskClipValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FStaticParameterBase
{
    [FieldOffset(0x0000)] public FMaterialParameterInfo ParameterInfo;
    [FieldOffset(0x0010)] public bool bOverride;
    [FieldOffset(0x0014)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStaticSwitchParameter
{
    [FieldOffset(0x0000)] public FStaticParameterBase baseObj;
    [FieldOffset(0x0024)] public bool Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStaticComponentMaskParameter
{
    [FieldOffset(0x0000)] public FStaticParameterBase baseObj;
    [FieldOffset(0x0024)] public bool R;
    [FieldOffset(0x0025)] public bool G;
    [FieldOffset(0x0026)] public bool B;
    [FieldOffset(0x0027)] public bool A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FStaticTerrainLayerWeightParameter
{
    [FieldOffset(0x0000)] public FStaticParameterBase baseObj;
    [FieldOffset(0x0024)] public int WeightmapIndex;
    [FieldOffset(0x0028)] public bool bWeightBasedBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMaterialLayersFunctions
{
    [FieldOffset(0x0000)] public TArray<IntPtr> Layers;
    [FieldOffset(0x0010)] public TArray<IntPtr> Blends;
    [FieldOffset(0x0020)] public TArray<bool> LayerStates;
    [FieldOffset(0x0030)] public FString KeyString;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FStaticMaterialLayersParameter
{
    [FieldOffset(0x0000)] public FStaticParameterBase baseObj;
    [FieldOffset(0x0028)] public FMaterialLayersFunctions Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FStaticParameterSet
{
    [FieldOffset(0x0000)] public TArray<FStaticSwitchParameter> StaticSwitchParameters;
    [FieldOffset(0x0010)] public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters;
    [FieldOffset(0x0020)] public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
    [FieldOffset(0x0030)] public TArray<FStaticMaterialLayersParameter> MaterialLayersParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMaterialCachedParameterEntry
{
    [FieldOffset(0x0000)] public TArray<ulong> NameHashes;
    [FieldOffset(0x0010)] public TArray<FMaterialParameterInfo> ParameterInfos;
    [FieldOffset(0x0020)] public TArray<FGuid> ExpressionGuids;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct FMaterialCachedParameters
{
    [FieldOffset(0x0000)] public FMaterialCachedParameterEntry RuntimeEntries;
    [FieldOffset(0x00F0)] public TArray<float> ScalarValues;
    [FieldOffset(0x0100)] public TArray<FLinearColor> VectorValues;
    [FieldOffset(0x0110)] public TArray<IntPtr> TextureValues;
    [FieldOffset(0x0120)] public TArray<IntPtr> FontValues;
    [FieldOffset(0x0130)] public TArray<int> FontPageValues;
    [FieldOffset(0x0140)] public TArray<IntPtr> RuntimeVirtualTextureValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct UMaterialInstance
{
    [FieldOffset(0x0000)] public UMaterialInterface baseObj;
    [FieldOffset(0x0088)] public UPhysicalMaterial* PhysMaterial;
    [FieldOffset(0x0090)] public UPhysicalMaterial* PhysicalMaterialMap;
    [FieldOffset(0x00D0)] public UMaterialInterface* Parent;
    [FieldOffset(0x00D8)] public byte bHasStaticPermutationResource;
    [FieldOffset(0x00D8)] public byte bOverrideSubsurfaceProfile;
    [FieldOffset(0x00E0)] public TArray<FScalarParameterValue> ScalarParameterValues;
    [FieldOffset(0x00F0)] public TArray<FVectorParameterValue> VectorParameterValues;
    [FieldOffset(0x0100)] public TArray<FTextureParameterValue> TextureParameterValues;
    [FieldOffset(0x0110)] public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
    [FieldOffset(0x0120)] public TArray<FFontParameterValue> FontParameterValues;
    [FieldOffset(0x0130)] public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
    [FieldOffset(0x0148)] public FStaticParameterSet StaticParameters;
    [FieldOffset(0x0188)] public FMaterialCachedParameters CachedLayerParameters;
    [FieldOffset(0x02D8)] public TArray<IntPtr> CachedReferencedTextures;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct UMaterialInstanceConstant
{
    [FieldOffset(0x0000)] public UMaterialInstance baseObj;
    [FieldOffset(0x0310)] public UPhysicalMaterialMask* PhysMaterialMask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UWorldSubsystem
{
    [FieldOffset(0x0000)] public USubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTickableWorldSubsystem
{
    [FieldOffset(0x0000)] public UWorldSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionCustomOutput
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEngineCustomTimeStep
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UTimecodeProvider
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float FrameDelay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBranchingPointNotifyPayload
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FIntegralKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public int Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FIntegralCurve
{
    [FieldOffset(0x0000)] public FIndexedCurve baseObj;
    [FieldOffset(0x0068)] public TArray<FIntegralKey> Keys;
    [FieldOffset(0x0078)] public int DefaultValue;
    [FieldOffset(0x007C)] public bool bUseDefaultValueBeforeFirstKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDynamicBlueprintBinding
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBPComponentClassOverride
{
    [FieldOffset(0x0000)] public FName ComponentName;
    [FieldOffset(0x0008)] public UClass* ComponentClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBlueprintComponentChangedPropertyInfo
{
    [FieldOffset(0x0000)] public FName PropertyName;
    [FieldOffset(0x0008)] public int ArrayIndex;
    [FieldOffset(0x0010)] public UStruct* PropertyScope;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FBlueprintCookedComponentInstancingData
{
    [FieldOffset(0x0000)] public TArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList;
    [FieldOffset(0x0021)] public bool bHasValidCookedData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct UBlueprintGeneratedClass
{
    [FieldOffset(0x0000)] public UClass baseObj;
    [FieldOffset(0x0230)] public int NumReplicatedProperties;
    [FieldOffset(0x0234)] public byte bHasNativizedParent;
    [FieldOffset(0x0234)] public byte bHasCookedComponentInstancingData;
    [FieldOffset(0x0238)] public TArray<IntPtr> DynamicBindingObjects;
    [FieldOffset(0x0248)] public TArray<IntPtr> ComponentTemplates;
    [FieldOffset(0x0258)] public TArray<IntPtr> Timelines;
    [FieldOffset(0x0268)] public TArray<FBPComponentClassOverride> ComponentClassOverrides;
    [FieldOffset(0x0278)] public USimpleConstructionScript* SimpleConstructionScript;
    [FieldOffset(0x0280)] public UInheritableComponentHandler* InheritableComponentHandler;
    [FieldOffset(0x0288)] public UStructProperty* UberGraphFramePointerProperty;
    [FieldOffset(0x0298)] public UFunction* UberGraphFunction;
    [FieldOffset(0x02A0)] public TMap<FName, FBlueprintCookedComponentInstancingData> CookedComponentInstancingData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7D0)] 
public unsafe struct UCameraComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float FieldOfView;
    [FieldOffset(0x01FC)] public float OrthoWidth;
    [FieldOffset(0x0200)] public float OrthoNearClipPlane;
    [FieldOffset(0x0204)] public float OrthoFarClipPlane;
    [FieldOffset(0x0208)] public float AspectRatio;
    [FieldOffset(0x020C)] public byte bConstrainAspectRatio;
    [FieldOffset(0x020C)] public byte bUseFieldOfViewForLOD;
    [FieldOffset(0x020C)] public byte bLockToHmd;
    [FieldOffset(0x020C)] public byte bUsePawnControlRotation;
    [FieldOffset(0x020D)] public ECameraProjectionMode ProjectionMode;
    [FieldOffset(0x0240)] public float PostProcessBlendWeight;
    [FieldOffset(0x0270)] public FPostProcessSettings PostProcessSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSoundSubmixSpectralAnalysisBandSettings
{
    [FieldOffset(0x0000)] public float BandFrequency;
    [FieldOffset(0x0004)] public int AttackTimeMsec;
    [FieldOffset(0x0008)] public int ReleaseTimeMsec;
    [FieldOffset(0x000C)] public float QFactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSourceEffectChainEntry
{
    [FieldOffset(0x0000)] public USoundEffectSourcePreset* Preset;
    [FieldOffset(0x0008)] public byte bBypass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FQuartzTransportTimeStamp
{
    [FieldOffset(0x0000)] public int Bars;
    [FieldOffset(0x0004)] public int Beat;
    [FieldOffset(0x0008)] public float BeatFraction;
    [FieldOffset(0x000C)] public float Seconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FQuartzPulseOverrideStep
{
    [FieldOffset(0x0000)] public int NumberOfPulses;
    [FieldOffset(0x0004)] public EQuartzCommandQuantization PulseDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FQuartzTimeSignature
{
    [FieldOffset(0x0000)] public int NumBeats;
    [FieldOffset(0x0004)] public EQuartzTimeSignatureQuantization BeatType;
    [FieldOffset(0x0008)] public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FQuartzClockSettings
{
    [FieldOffset(0x0000)] public FQuartzTimeSignature TimeSignature;
    [FieldOffset(0x0018)] public bool bIgnoreLevelChange;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBlueprintCore
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClass* SkeletonGeneratedClass;
    [FieldOffset(0x0030)] public UClass* GeneratedClass;
    [FieldOffset(0x0038)] public bool bLegacyNeedToPurgeSkelRefs;
    [FieldOffset(0x003C)] public FGuid BlueprintGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBlueprint
{
    [FieldOffset(0x0000)] public UBlueprintCore baseObj;
    [FieldOffset(0x0050)] public UClass* ParentClass;
    [FieldOffset(0x0058)] public EBlueprintType BlueprintType;
    [FieldOffset(0x0059)] public byte bRecompileOnLoad;
    [FieldOffset(0x0059)] public byte bHasBeenRegenerated;
    [FieldOffset(0x0059)] public byte bIsRegeneratingOnLoad;
    [FieldOffset(0x005C)] public int BlueprintSystemVersion;
    [FieldOffset(0x0060)] public USimpleConstructionScript* SimpleConstructionScript;
    [FieldOffset(0x0068)] public TArray<IntPtr> ComponentTemplates;
    [FieldOffset(0x0078)] public TArray<IntPtr> Timelines;
    [FieldOffset(0x0088)] public TArray<FBPComponentClassOverride> ComponentClassOverrides;
    [FieldOffset(0x0098)] public UInheritableComponentHandler* InheritableComponentHandler;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct UModel
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UChannel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UNetConnection* Connection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UActorChannel
{
    [FieldOffset(0x0000)] public UChannel baseObj;
    [FieldOffset(0x0068)] public AActor* Actor;
    [FieldOffset(0x0158)] public TArray<IntPtr> CreateSubObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAnimationAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public USkeleton* Skeleton;
    [FieldOffset(0x0060)] public TArray<IntPtr> MetaData;
    [FieldOffset(0x0070)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInterpolationParameter
{
    [FieldOffset(0x0000)] public float InterpolationTime;
    [FieldOffset(0x0004)] public EFilterInterpolationType InterpolationType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FPerBoneInterpolation
{
    [FieldOffset(0x0000)] public FBoneReference BoneReference;
    [FieldOffset(0x0010)] public float InterpolationSpeedPerSec;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBlendSample
{
    [FieldOffset(0x0000)] public UAnimSequence* Animation;
    [FieldOffset(0x0008)] public FVector SampleValue;
    [FieldOffset(0x0014)] public float RateScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEditorElement
{
    [FieldOffset(0x0000)] public int Indices;
    [FieldOffset(0x000C)] public float Weights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBlendParameter
{
    [FieldOffset(0x0000)] public FString DisplayName;
    [FieldOffset(0x0010)] public float Min;
    [FieldOffset(0x0014)] public float Max;
    [FieldOffset(0x0018)] public int GridNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UBlendSpaceBase
{
    [FieldOffset(0x0000)] public UAnimationAsset baseObj;
    [FieldOffset(0x0088)] public bool bRotationBlendInMeshSpace;
    [FieldOffset(0x008C)] public float AnimLength;
    [FieldOffset(0x0090)] public FInterpolationParameter InterpolationParam;
    [FieldOffset(0x00A8)] public float TargetWeightInterpolationSpeedPerSec;
    [FieldOffset(0x00AC)] public ENotifyTriggerMode NotifyTriggerMode;
    [FieldOffset(0x00B0)] public TArray<FPerBoneInterpolation> PerBoneBlend;
    [FieldOffset(0x00C0)] public int SampleIndexWithMarkers;
    [FieldOffset(0x00C8)] public TArray<FBlendSample> SampleData;
    [FieldOffset(0x00D8)] public TArray<FEditorElement> GridSamples;
    [FieldOffset(0x00E8)] public FBlendParameter BlendParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UBlendSpace
{
    [FieldOffset(0x0000)] public UBlendSpaceBase baseObj;
    [FieldOffset(0x0148)] public EBlendSpaceAxis AxisToScaleAnimation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UAimOffsetBlendSpace
{
    [FieldOffset(0x0000)] public UBlendSpace baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UBlendSpace1D
{
    [FieldOffset(0x0000)] public UBlendSpaceBase baseObj;
    [FieldOffset(0x0148)] public bool bScaleAnimation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UAimOffsetBlendSpace1D
{
    [FieldOffset(0x0000)] public UBlendSpace1D baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAISystemBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSoftClassPath AISystemClassName;
    [FieldOffset(0x0040)] public FName AISystemModuleName;
    [FieldOffset(0x0050)] public bool bInstantiateAISystemOnClient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AAmbientSound
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UAudioComponent* AudioComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCustomAttributeSetting
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FString Meaning;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UAnimationSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public int CompressCommandletVersion;
    [FieldOffset(0x0040)] public TArray<FString> KeyEndEffectorsMatchNameArray;
    [FieldOffset(0x0050)] public bool ForceRecompression;
    [FieldOffset(0x0051)] public bool bForceBelowThreshold;
    [FieldOffset(0x0052)] public bool bFirstRecompressUsingCurrentOrDefault;
    [FieldOffset(0x0053)] public bool bRaiseMaxErrorToExisting;
    [FieldOffset(0x0054)] public bool bEnablePerformanceLog;
    [FieldOffset(0x0055)] public bool bStripAnimationDataOnDedicatedServer;
    [FieldOffset(0x0056)] public bool bTickAnimationOnSkeletalMeshInit;
    [FieldOffset(0x0058)] public TArray<FCustomAttributeSetting> BoneCustomAttributesNames;
    [FieldOffset(0x0068)] public TArray<FString> BoneNamesWithCustomAttributes;
    [FieldOffset(0x0078)] public TMap<FName, ECustomAttributeBlendType> AttributeBlendModes;
    [FieldOffset(0x00C8)] public ECustomAttributeBlendType DefaultAttributeBlendMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimGroupInfo
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FLinearColor Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UAnimBlueprint
{
    [FieldOffset(0x0000)] public UBlueprint baseObj;
    [FieldOffset(0x00A8)] public USkeleton* TargetSkeleton;
    [FieldOffset(0x00B0)] public TArray<FAnimGroupInfo> Groups;
    [FieldOffset(0x00C0)] public bool bUseMultiThreadedAnimationUpdate;
    [FieldOffset(0x00C1)] public bool bWarnAboutBlueprintUsage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBakedStateExitTransition
{
    [FieldOffset(0x0000)] public int CanTakeDelegateIndex;
    [FieldOffset(0x0004)] public int CustomResultNodeIndex;
    [FieldOffset(0x0008)] public int TransitionIndex;
    [FieldOffset(0x000C)] public bool bDesiredTransitionReturnValue;
    [FieldOffset(0x000D)] public bool bAutomaticRemainingTimeRule;
    [FieldOffset(0x0010)] public TArray<int> PoseEvaluatorLinks;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FBakedAnimationState
{
    [FieldOffset(0x0000)] public FName StateName;
    [FieldOffset(0x0008)] public TArray<FBakedStateExitTransition> Transitions;
    [FieldOffset(0x0018)] public int StateRootNodeIndex;
    [FieldOffset(0x001C)] public int StartNotify;
    [FieldOffset(0x0020)] public int EndNotify;
    [FieldOffset(0x0024)] public int FullyBlendedNotify;
    [FieldOffset(0x0028)] public bool bIsAConduit;
    [FieldOffset(0x002C)] public int EntryRuleNodeIndex;
    [FieldOffset(0x0030)] public TArray<int> PlayerNodeIndices;
    [FieldOffset(0x0040)] public TArray<int> LayerNodeIndices;
    [FieldOffset(0x0050)] public bool bAlwaysResetOnEntry;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAnimationStateBase
{
    [FieldOffset(0x0000)] public FName StateName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAnimationTransitionBetweenStates
{
    [FieldOffset(0x0000)] public FAnimationStateBase baseObj;
    [FieldOffset(0x0008)] public int PreviousState;
    [FieldOffset(0x000C)] public int NextState;
    [FieldOffset(0x0010)] public float CrossfadeDuration;
    [FieldOffset(0x0014)] public int StartNotify;
    [FieldOffset(0x0018)] public int EndNotify;
    [FieldOffset(0x001C)] public int InterruptNotify;
    [FieldOffset(0x0020)] public EAlphaBlendOption BlendMode;
    [FieldOffset(0x0028)] public UCurveFloat* CustomCurve;
    [FieldOffset(0x0030)] public UBlendProfile* BlendProfile;
    [FieldOffset(0x0038)] public ETransitionLogicType LogicType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBakedAnimationStateMachine
{
    [FieldOffset(0x0000)] public FName MachineName;
    [FieldOffset(0x0008)] public int InitialState;
    [FieldOffset(0x0010)] public TArray<FBakedAnimationState> States;
    [FieldOffset(0x0020)] public TArray<FAnimationTransitionBetweenStates> Transitions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCachedPoseIndices
{
    [FieldOffset(0x0000)] public TArray<int> OrderedSavedPoseNodeIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FExposedValueCopyRecord
{
    [FieldOffset(0x0000)] public int CopyIndex;
    [FieldOffset(0x0004)] public EPostCopyOperation PostCopyOperation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FExposedValueHandler
{
    [FieldOffset(0x0000)] public FName BoundFunction;
    [FieldOffset(0x0008)] public TArray<FExposedValueCopyRecord> CopyRecords;
    [FieldOffset(0x0018)] public UFunction* Function;
    [FieldOffset(0x0020)] public TFieldPath<FStructProperty> ValueHandlerNodeProperty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGraphAssetPlayerInformation
{
    [FieldOffset(0x0000)] public TArray<int> PlayerNodeIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAnimGraphBlendOptions
{
    [FieldOffset(0x0000)] public float BlendInTime;
    [FieldOffset(0x0004)] public float BlendOutTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5B0)] 
public unsafe struct UAnimBlueprintGeneratedClass
{
    [FieldOffset(0x0000)] public UBlueprintGeneratedClass baseObj;
    [FieldOffset(0x0330)] public TArray<FBakedAnimationStateMachine> BakedStateMachines;
    [FieldOffset(0x0340)] public USkeleton* TargetSkeleton;
    [FieldOffset(0x0348)] public TArray<FAnimNotifyEvent> AnimNotifies;
    [FieldOffset(0x0358)] public TMap<FName, FCachedPoseIndices> OrderedSavedPoseIndicesMap;
    [FieldOffset(0x0428)] public TArray<FName> SyncGroupNames;
    [FieldOffset(0x0438)] public TArray<FExposedValueHandler> EvaluateGraphExposedInputs;
    [FieldOffset(0x0448)] public TMap<FName, FGraphAssetPlayerInformation> GraphAssetPlayerInformation;
    [FieldOffset(0x0498)] public TMap<FName, FAnimGraphBlendOptions> GraphBlendOptions;
    [FieldOffset(0x04E8)] public FPropertyAccessLibrary PropertyAccessLibrary;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimBoneCompressionCodec
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString Description;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimBoneCompressionSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Codecs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FAnimBlueprintFunction
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FName Group;
    [FieldOffset(0x0010)] public int OutputPoseNodeIndex;
    [FieldOffset(0x0018)] public TArray<FName> InputPoseNames;
    [FieldOffset(0x0028)] public TArray<int> InputPoseNodeIndices;
    [FieldOffset(0x0060)] public bool bImplemented;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAnimBlueprintFunctionData
{
    [FieldOffset(0x0000)] public TFieldPath<FStructProperty> OutputPoseNodeProperty;
    [FieldOffset(0x0020)] public TArray<TFieldPath<FStructProperty>> InputPoseNodeProperties;
    [FieldOffset(0x0030)] public TArray<TFieldPath<FProperty>> InputProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct UAnimClassData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<FBakedAnimationStateMachine> BakedStateMachines;
    [FieldOffset(0x0040)] public USkeleton* TargetSkeleton;
    [FieldOffset(0x0048)] public TArray<FAnimNotifyEvent> AnimNotifies;
    [FieldOffset(0x0058)] public TMap<FName, FCachedPoseIndices> OrderedSavedPoseIndicesMap;
    [FieldOffset(0x00A8)] public TArray<FAnimBlueprintFunction> AnimBlueprintFunctions;
    [FieldOffset(0x00B8)] public TArray<FAnimBlueprintFunctionData> AnimBlueprintFunctionData;
    [FieldOffset(0x00C8)] public TArray<TFieldPath<FStructProperty>> AnimNodeProperties;
    [FieldOffset(0x00E8)] public TArray<TFieldPath<FStructProperty>> LinkedAnimGraphNodeProperties;
    [FieldOffset(0x0108)] public TArray<TFieldPath<FStructProperty>> LinkedAnimLayerNodeProperties;
    [FieldOffset(0x0128)] public TArray<TFieldPath<FStructProperty>> PreUpdateNodeProperties;
    [FieldOffset(0x0148)] public TArray<TFieldPath<FStructProperty>> DynamicResetNodeProperties;
    [FieldOffset(0x0168)] public TArray<TFieldPath<FStructProperty>> StateMachineNodeProperties;
    [FieldOffset(0x0188)] public TArray<TFieldPath<FStructProperty>> InitializationNodeProperties;
    [FieldOffset(0x01A8)] public TMap<FName, FGraphAssetPlayerInformation> GraphNameAssetPlayers;
    [FieldOffset(0x01F8)] public TArray<FName> SyncGroupNames;
    [FieldOffset(0x0208)] public TArray<FExposedValueHandler> EvaluateGraphExposedInputs;
    [FieldOffset(0x0218)] public TMap<FName, FAnimGraphBlendOptions> GraphBlendOptions;
    [FieldOffset(0x0268)] public FPropertyAccessLibrary PropertyAccessLibrary;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAnimClassInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSmartName
{
    [FieldOffset(0x0000)] public FName DisplayName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimCurveBase
{
    [FieldOffset(0x0000)] public FName LastObservedName;
    [FieldOffset(0x0008)] public FSmartName Name;
    [FieldOffset(0x0014)] public int CurveTypeFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FFloatCurve
{
    [FieldOffset(0x0000)] public FAnimCurveBase baseObj;
    [FieldOffset(0x0018)] public FRichCurve FloatCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRawCurveTracks
{
    [FieldOffset(0x0000)] public TArray<FFloatCurve> FloatCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UAnimSequenceBase
{
    [FieldOffset(0x0000)] public UAnimationAsset baseObj;
    [FieldOffset(0x0080)] public TArray<FAnimNotifyEvent> Notifies;
    [FieldOffset(0x0090)] public float SequenceLength;
    [FieldOffset(0x0094)] public float RateScale;
    [FieldOffset(0x0098)] public FRawCurveTracks RawCurveData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UAnimCompositeBase
{
    [FieldOffset(0x0000)] public UAnimSequenceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimSegment
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* AnimReference;
    [FieldOffset(0x0008)] public float StartPos;
    [FieldOffset(0x000C)] public float AnimStartTime;
    [FieldOffset(0x0010)] public float AnimEndTime;
    [FieldOffset(0x0014)] public float AnimPlayRate;
    [FieldOffset(0x0018)] public int LoopingCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimTrack
{
    [FieldOffset(0x0000)] public TArray<FAnimSegment> AnimSegments;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UAnimComposite
{
    [FieldOffset(0x0000)] public UAnimCompositeBase baseObj;
    [FieldOffset(0x00A8)] public FAnimTrack AnimationTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAnimCompress
{
    [FieldOffset(0x0000)] public UAnimBoneCompressionCodec baseObj;
    [FieldOffset(0x0038)] public byte bNeedsSkeleton;
    [FieldOffset(0x003C)] public AnimationCompressionFormat TranslationCompressionFormat;
    [FieldOffset(0x003D)] public AnimationCompressionFormat RotationCompressionFormat;
    [FieldOffset(0x003E)] public AnimationCompressionFormat ScaleCompressionFormat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAnimCompress_BitwiseCompressOnly
{
    [FieldOffset(0x0000)] public UAnimCompress baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAnimCompress_LeastDestructive
{
    [FieldOffset(0x0000)] public UAnimCompress_BitwiseCompressOnly baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAnimCompress_RemoveLinearKeys
{
    [FieldOffset(0x0000)] public UAnimCompress baseObj;
    [FieldOffset(0x0040)] public float MaxPosDiff;
    [FieldOffset(0x0044)] public float MaxAngleDiff;
    [FieldOffset(0x0048)] public float MaxScaleDiff;
    [FieldOffset(0x004C)] public float MaxEffectorDiff;
    [FieldOffset(0x0050)] public float MinEffectorDiff;
    [FieldOffset(0x0054)] public float EffectorDiffSocket;
    [FieldOffset(0x0058)] public float ParentKeyScale;
    [FieldOffset(0x005C)] public byte bRetarget;
    [FieldOffset(0x005C)] public byte bActuallyFilterLinearKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UAnimCompress_PerTrackCompression
{
    [FieldOffset(0x0000)] public UAnimCompress_RemoveLinearKeys baseObj;
    [FieldOffset(0x0060)] public float MaxZeroingThreshold;
    [FieldOffset(0x0064)] public float MaxPosDiffBitwise;
    [FieldOffset(0x0068)] public float MaxAngleDiffBitwise;
    [FieldOffset(0x006C)] public float MaxScaleDiffBitwise;
    [FieldOffset(0x0070)] public TArray<AnimationCompressionFormat> AllowedRotationFormats;
    [FieldOffset(0x0080)] public TArray<AnimationCompressionFormat> AllowedTranslationFormats;
    [FieldOffset(0x0090)] public TArray<AnimationCompressionFormat> AllowedScaleFormats;
    [FieldOffset(0x00A0)] public byte bResampleAnimation;
    [FieldOffset(0x00A4)] public float ResampledFramerate;
    [FieldOffset(0x00A8)] public int MinKeysForResampling;
    [FieldOffset(0x00AC)] public byte bUseAdaptiveError;
    [FieldOffset(0x00AC)] public byte bUseOverrideForEndEffectors;
    [FieldOffset(0x00B0)] public int TrackHeightBias;
    [FieldOffset(0x00B4)] public float ParentingDivisor;
    [FieldOffset(0x00B8)] public float ParentingDivisorExponent;
    [FieldOffset(0x00BC)] public byte bUseAdaptiveError2;
    [FieldOffset(0x00C0)] public float RotationErrorSourceRatio;
    [FieldOffset(0x00C4)] public float TranslationErrorSourceRatio;
    [FieldOffset(0x00C8)] public float ScaleErrorSourceRatio;
    [FieldOffset(0x00CC)] public float MaxErrorPerTrackRatio;
    [FieldOffset(0x00D0)] public float PerturbationProbeSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAnimCompress_RemoveEverySecondKey
{
    [FieldOffset(0x0000)] public UAnimCompress baseObj;
    [FieldOffset(0x0040)] public int MinKeys;
    [FieldOffset(0x0044)] public byte bStartAtSecondKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAnimCompress_RemoveTrivialKeys
{
    [FieldOffset(0x0000)] public UAnimCompress baseObj;
    [FieldOffset(0x0040)] public float MaxPosDiff;
    [FieldOffset(0x0044)] public float MaxAngleDiff;
    [FieldOffset(0x0048)] public float MaxScaleDiff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimCurveCompressionCodec
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimCurveCompressionCodec_CompressedRichCurve
{
    [FieldOffset(0x0000)] public UAnimCurveCompressionCodec baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimCurveCompressionCodec_UniformIndexable
{
    [FieldOffset(0x0000)] public UAnimCurveCompressionCodec baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimCurveCompressionCodec_UniformlySampled
{
    [FieldOffset(0x0000)] public UAnimCurveCompressionCodec baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAnimCurveCompressionSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAnimCurveCompressionCodec* Codec;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAnimLayerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimMetaData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAlphaBlend
{
    [FieldOffset(0x0000)] public UCurveFloat* CustomCurve;
    [FieldOffset(0x0008)] public float BlendTime;
    [FieldOffset(0x0024)] public EAlphaBlendOption BlendOption;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAnimSyncMarker
{
    [FieldOffset(0x0000)] public FName MarkerName;
    [FieldOffset(0x0008)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMarkerSyncData
{
    [FieldOffset(0x0000)] public TArray<FAnimSyncMarker> AuthoredSyncMarkers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FCompositeSection
{
    [FieldOffset(0x0000)] public FAnimLinkableElement baseObj;
    [FieldOffset(0x0030)] public FName SectionName;
    [FieldOffset(0x0038)] public float StartTime;
    [FieldOffset(0x003C)] public FName NextSectionName;
    [FieldOffset(0x0048)] public TArray<IntPtr> MetaData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSlotAnimationTrack
{
    [FieldOffset(0x0000)] public FName SlotName;
    [FieldOffset(0x0008)] public FAnimTrack AnimTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBranchingPoint
{
    [FieldOffset(0x0000)] public FAnimLinkableElement baseObj;
    [FieldOffset(0x0030)] public FName EventName;
    [FieldOffset(0x0038)] public float DisplayTime;
    [FieldOffset(0x003C)] public float TriggerTimeOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBranchingPointMarker
{
    [FieldOffset(0x0000)] public int NotifyIndex;
    [FieldOffset(0x0004)] public float TriggerTime;
    [FieldOffset(0x0008)] public EAnimNotifyEventType NotifyEventType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTimeStretchCurveMarker
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x000C)] public float Alpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTimeStretchCurve
{
    [FieldOffset(0x0000)] public float SamplingRate;
    [FieldOffset(0x0004)] public float CurveValueMinPrecision;
    [FieldOffset(0x0008)] public TArray<FTimeStretchCurveMarker> Markers;
    [FieldOffset(0x0018)] public float Sum_dT_i_by_C_i;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UAnimMontage
{
    [FieldOffset(0x0000)] public UAnimCompositeBase baseObj;
    [FieldOffset(0x00A8)] public FAlphaBlend BlendIn;
    [FieldOffset(0x00D8)] public float BlendInTime;
    [FieldOffset(0x00E0)] public FAlphaBlend BlendOut;
    [FieldOffset(0x0110)] public float BlendOutTime;
    [FieldOffset(0x0114)] public float BlendOutTriggerTime;
    [FieldOffset(0x0118)] public FName SyncGroup;
    [FieldOffset(0x0120)] public int SyncSlotIndex;
    [FieldOffset(0x0128)] public FMarkerSyncData MarkerData;
    [FieldOffset(0x0148)] public TArray<FCompositeSection> CompositeSections;
    [FieldOffset(0x0158)] public TArray<FSlotAnimationTrack> SlotAnimTracks;
    [FieldOffset(0x0168)] public TArray<FBranchingPoint> BranchingPoints;
    [FieldOffset(0x0178)] public bool bEnableRootMotionTranslation;
    [FieldOffset(0x0179)] public bool bEnableRootMotionRotation;
    [FieldOffset(0x017A)] public bool bEnableAutoBlendOut;
    [FieldOffset(0x017B)] public ERootMotionRootLock RootMotionRootLock;
    [FieldOffset(0x0180)] public TArray<FBranchingPointMarker> BranchingPointMarkers;
    [FieldOffset(0x0190)] public TArray<int> BranchingPointStateNotifyIndices;
    [FieldOffset(0x01A0)] public FTimeStretchCurve TimeStretchCurve;
    [FieldOffset(0x01C8)] public FName TimeStretchCurveName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify_PauseClothingSimulation
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAnimNotify_PlayParticleEffect
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public UParticleSystem* PSTemplate;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public FVector Scale;
    [FieldOffset(0x0080)] public byte Attached;
    [FieldOffset(0x0084)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAnimNotify_PlaySound
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public USoundBase* Sound;
    [FieldOffset(0x0040)] public float VolumeMultiplier;
    [FieldOffset(0x0044)] public float PitchMultiplier;
    [FieldOffset(0x0048)] public byte bFollow;
    [FieldOffset(0x004C)] public FName AttachName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify_ResetClothingSimulation
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify_ResetDynamics
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAnimNotify_ResumeClothingSimulation
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAnimNotifyState_DisableRootMotion
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAnimNotifyState_TimedParticleEffect
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public UParticleSystem* PSTemplate;
    [FieldOffset(0x0038)] public FName SocketName;
    [FieldOffset(0x0040)] public FVector LocationOffset;
    [FieldOffset(0x004C)] public FRotator RotationOffset;
    [FieldOffset(0x0058)] public bool bDestroyAtEnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAnimNotifyState_Trail
{
    [FieldOffset(0x0000)] public UAnimNotifyState baseObj;
    [FieldOffset(0x0030)] public UParticleSystem* PSTemplate;
    [FieldOffset(0x0038)] public FName FirstSocketName;
    [FieldOffset(0x0040)] public FName SecondSocketName;
    [FieldOffset(0x0048)] public ETrailWidthMode WidthScaleMode;
    [FieldOffset(0x004C)] public FName WidthScaleCurve;
    [FieldOffset(0x0054)] public byte bRecycleSpawnedSystems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FTrackToSkeletonMap
{
    [FieldOffset(0x0000)] public int BoneTreeIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FStringCurveKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0008)] public FString Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FStringCurve
{
    [FieldOffset(0x0000)] public FIndexedCurve baseObj;
    [FieldOffset(0x0068)] public FString DefaultValue;
    [FieldOffset(0x0078)] public TArray<FStringCurveKey> Keys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FBakedStringCustomAttribute
{
    [FieldOffset(0x0000)] public FName AttributeName;
    [FieldOffset(0x0008)] public FStringCurve StringCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FBakedIntegerCustomAttribute
{
    [FieldOffset(0x0000)] public FName AttributeName;
    [FieldOffset(0x0008)] public FIntegralCurve IntCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSimpleCurveKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FSimpleCurve
{
    [FieldOffset(0x0000)] public FRealCurve baseObj;
    [FieldOffset(0x0070)] public ERichCurveInterpMode InterpMode;
    [FieldOffset(0x0078)] public TArray<FSimpleCurveKey> Keys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FBakedFloatCustomAttribute
{
    [FieldOffset(0x0000)] public FName AttributeName;
    [FieldOffset(0x0008)] public FSimpleCurve FloatCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBakedCustomAttributePerBoneData
{
    [FieldOffset(0x0000)] public int BoneTreeIndex;
    [FieldOffset(0x0008)] public TArray<FBakedStringCustomAttribute> StringAttributes;
    [FieldOffset(0x0018)] public TArray<FBakedIntegerCustomAttribute> IntAttributes;
    [FieldOffset(0x0028)] public TArray<FBakedFloatCustomAttribute> FloatAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UAnimSequence
{
    [FieldOffset(0x0000)] public UAnimSequenceBase baseObj;
    [FieldOffset(0x00A8)] public int NumFrames;
    [FieldOffset(0x00B0)] public TArray<FTrackToSkeletonMap> TrackToSkeletonMapTable;
    [FieldOffset(0x00D0)] public UAnimBoneCompressionSettings* BoneCompressionSettings;
    [FieldOffset(0x00D8)] public UAnimCurveCompressionSettings* CurveCompressionSettings;
    [FieldOffset(0x0150)] public EAdditiveAnimationType AdditiveAnimType;
    [FieldOffset(0x0151)] public EAdditiveBasePoseType RefPoseType;
    [FieldOffset(0x0158)] public UAnimSequence* RefPoseSeq;
    [FieldOffset(0x0160)] public int RefFrameIndex;
    [FieldOffset(0x0164)] public FName RetargetSource;
    [FieldOffset(0x0170)] public TArray<FTransform> RetargetSourceAssetReferencePose;
    [FieldOffset(0x0180)] public EAnimInterpolationType Interpolation;
    [FieldOffset(0x0181)] public bool bEnableRootMotion;
    [FieldOffset(0x0182)] public ERootMotionRootLock RootMotionRootLock;
    [FieldOffset(0x0183)] public bool bForceRootLock;
    [FieldOffset(0x0184)] public bool bUseNormalizedRootMotionScale;
    [FieldOffset(0x0185)] public bool bRootMotionSettingsCopiedFromMontage;
    [FieldOffset(0x0188)] public TArray<FAnimSyncMarker> AuthoredSyncMarkers;
    [FieldOffset(0x01B0)] public TArray<FBakedCustomAttributePerBoneData> BakedPerBoneCustomAttributeData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimSetMeshLinkup
{
    [FieldOffset(0x0000)] public TArray<int> BoneToTrackTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UAnimSet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bAnimRotationOnly;
    [FieldOffset(0x0030)] public TArray<FName> TrackBoneNames;
    [FieldOffset(0x0040)] public TArray<FAnimSetMeshLinkup> LinkupCache;
    [FieldOffset(0x0050)] public TArray<byte> BoneUseAnimTranslation;
    [FieldOffset(0x0060)] public TArray<byte> ForceUseMeshTranslation;
    [FieldOffset(0x0070)] public TArray<FName> UseTranslationBoneNames;
    [FieldOffset(0x0080)] public TArray<FName> ForceMeshTranslationBoneNames;
    [FieldOffset(0x0090)] public FName PreviewSkelMeshName;
    [FieldOffset(0x0098)] public FName BestRatioSkelMeshName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct UAnimSingleNodeInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public UAnimationAsset* CurrentAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAnimStateMachineTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UAnimStreamable
{
    [FieldOffset(0x0000)] public UAnimSequenceBase baseObj;
    [FieldOffset(0x00A8)] public int NumFrames;
    [FieldOffset(0x00AC)] public EAnimInterpolationType Interpolation;
    [FieldOffset(0x00B0)] public FName RetargetSource;
    [FieldOffset(0x00C8)] public UAnimBoneCompressionSettings* BoneCompressionSettings;
    [FieldOffset(0x00D0)] public UAnimCurveCompressionSettings* CurveCompressionSettings;
    [FieldOffset(0x00D8)] public bool bEnableRootMotion;
    [FieldOffset(0x00D9)] public ERootMotionRootLock RootMotionRootLock;
    [FieldOffset(0x00DA)] public bool bForceRootLock;
    [FieldOffset(0x00DB)] public bool bUseNormalizedRootMotionScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UApplicationLifecycleComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UArrowComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public FColor ArrowColor;
    [FieldOffset(0x0454)] public float ArrowSize;
    [FieldOffset(0x0458)] public float ArrowLength;
    [FieldOffset(0x045C)] public float ScreenSize;
    [FieldOffset(0x0460)] public byte bIsScreenSizeScaled;
    [FieldOffset(0x0460)] public byte bTreatAsASprite;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAssetExportTask
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UObject* Object;
    [FieldOffset(0x0030)] public UExporter* Exporter;
    [FieldOffset(0x0038)] public FString Filename;
    [FieldOffset(0x0048)] public bool bSelected;
    [FieldOffset(0x0049)] public bool bReplaceIdentical;
    [FieldOffset(0x004A)] public bool bPrompt;
    [FieldOffset(0x004B)] public bool bAutomated;
    [FieldOffset(0x004C)] public bool bUseFileArchive;
    [FieldOffset(0x004D)] public bool bWriteEmptyFiles;
    [FieldOffset(0x0050)] public TArray<IntPtr> IgnoreObjectList;
    [FieldOffset(0x0060)] public UObject* Options;
    [FieldOffset(0x0068)] public TArray<FString> Errors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FPrimaryAssetTypeInfo
{
    [FieldOffset(0x0000)] public FName PrimaryAssetType;
    [FieldOffset(0x0008)] public TSoftClassPtr<UObject> AssetBaseClass;
    [FieldOffset(0x0030)] public UClass* AssetBaseClassLoaded;
    [FieldOffset(0x0038)] public bool bHasBlueprintClasses;
    [FieldOffset(0x0039)] public bool bIsEditorOnly;
    [FieldOffset(0x0040)] public TArray<FDirectoryPath> Directories;
    [FieldOffset(0x0050)] public TArray<FSoftObjectPath> SpecificAssets;
    [FieldOffset(0x0060)] public FPrimaryAssetRules Rules;
    [FieldOffset(0x0070)] public TArray<FString> AssetScanPaths;
    [FieldOffset(0x0080)] public bool bIsDynamicAsset;
    [FieldOffset(0x0084)] public int NumberOfAssets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FPrimaryAssetRulesOverride
{
    [FieldOffset(0x0000)] public FPrimaryAssetId PrimaryAssetId;
    [FieldOffset(0x0010)] public FPrimaryAssetRules Rules;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPrimaryAssetRulesCustomOverride
{
    [FieldOffset(0x0000)] public FPrimaryAssetType PrimaryAssetType;
    [FieldOffset(0x0008)] public FDirectoryPath FilterDirectory;
    [FieldOffset(0x0018)] public FString FilterString;
    [FieldOffset(0x0028)] public FPrimaryAssetRules Rules;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAssetManagerRedirect
{
    [FieldOffset(0x0000)] public FString Old;
    [FieldOffset(0x0010)] public FString New;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UAssetManagerSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan;
    [FieldOffset(0x0048)] public TArray<FDirectoryPath> DirectoriesToExclude;
    [FieldOffset(0x0058)] public TArray<FPrimaryAssetRulesOverride> PrimaryAssetRules;
    [FieldOffset(0x0068)] public TArray<FPrimaryAssetRulesCustomOverride> CustomPrimaryAssetRules;
    [FieldOffset(0x0078)] public bool bOnlyCookProductionAssets;
    [FieldOffset(0x0079)] public bool bShouldManagerDetermineTypeAndName;
    [FieldOffset(0x007A)] public bool bShouldGuessTypeAndNameInEditor;
    [FieldOffset(0x007B)] public bool bShouldAcquireMissingChunksOnLoad;
    [FieldOffset(0x0080)] public TArray<FAssetManagerRedirect> PrimaryAssetIdRedirects;
    [FieldOffset(0x0090)] public TArray<FAssetManagerRedirect> PrimaryAssetTypeRedirects;
    [FieldOffset(0x00A0)] public TArray<FAssetManagerRedirect> AssetPathRedirects;
    [FieldOffset(0x00B0)] public TSet<FName> MetaDataTagsForAssetRegistry;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAssetMapping
{
    [FieldOffset(0x0000)] public UAnimationAsset* SourceAsset;
    [FieldOffset(0x0008)] public UAnimationAsset* TargetAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAssetMappingTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FAssetMapping> MappedAssets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAsyncActionHandleSaveGame
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
    [FieldOffset(0x0060)] public USaveGame* SaveGameObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAsyncActionLoadPrimaryAssetBase
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAsyncActionLoadPrimaryAsset
{
    [FieldOffset(0x0000)] public UAsyncActionLoadPrimaryAssetBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAsyncActionLoadPrimaryAssetClass
{
    [FieldOffset(0x0000)] public UAsyncActionLoadPrimaryAssetBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAsyncActionLoadPrimaryAssetList
{
    [FieldOffset(0x0000)] public UAsyncActionLoadPrimaryAssetBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAsyncActionLoadPrimaryAssetClassList
{
    [FieldOffset(0x0000)] public UAsyncActionLoadPrimaryAssetBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAsyncActionChangePrimaryAssetBundles
{
    [FieldOffset(0x0000)] public UAsyncActionLoadPrimaryAssetBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AAtmosphericFog
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public UAtmosphericFogComponent* AtmosphericFogComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FAtmospherePrecomputeParameters
{
    [FieldOffset(0x0000)] public float DensityHeight;
    [FieldOffset(0x0004)] public float DecayHeight;
    [FieldOffset(0x0008)] public int MaxScatteringOrder;
    [FieldOffset(0x000C)] public int TransmittanceTexWidth;
    [FieldOffset(0x0010)] public int TransmittanceTexHeight;
    [FieldOffset(0x0014)] public int IrradianceTexWidth;
    [FieldOffset(0x0018)] public int IrradianceTexHeight;
    [FieldOffset(0x001C)] public int InscatterAltitudeSampleNum;
    [FieldOffset(0x0020)] public int InscatterMuNum;
    [FieldOffset(0x0024)] public int InscatterMuSNum;
    [FieldOffset(0x0028)] public int InscatterNuNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x300)] 
public unsafe struct UAtmosphericFogComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float SunMultiplier;
    [FieldOffset(0x01FC)] public float FogMultiplier;
    [FieldOffset(0x0200)] public float DensityMultiplier;
    [FieldOffset(0x0204)] public float DensityOffset;
    [FieldOffset(0x0208)] public float DistanceScale;
    [FieldOffset(0x020C)] public float AltitudeScale;
    [FieldOffset(0x0210)] public float DistanceOffset;
    [FieldOffset(0x0214)] public float GroundOffset;
    [FieldOffset(0x0218)] public float StartDistance;
    [FieldOffset(0x021C)] public float SunDiscScale;
    [FieldOffset(0x0220)] public float DefaultBrightness;
    [FieldOffset(0x0224)] public FColor DefaultLightColor;
    [FieldOffset(0x0228)] public byte bDisableSunDisk;
    [FieldOffset(0x0228)] public byte bAtmosphereAffectsSunIlluminance;
    [FieldOffset(0x0228)] public byte bDisableGroundScattering;
    [FieldOffset(0x022C)] public FAtmospherePrecomputeParameters PrecomputeParams;
    [FieldOffset(0x0258)] public UTexture2D* TransmittanceTexture;
    [FieldOffset(0x0260)] public UTexture2D* IrradianceTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAudioBus
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public EAudioBusChannels AudioBusChannels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAudioQualitySettings
{
    [FieldOffset(0x0000)] public FText DisplayName;
    [FieldOffset(0x0018)] public int MaxChannels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSoundDebugEntry
{
    [FieldOffset(0x0000)] public FName DebugName;
    [FieldOffset(0x0008)] public FSoftObjectPath Sound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDefaultAudioBusSettings
{
    [FieldOffset(0x0000)] public FSoftObjectPath AudioBus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x198)] 
public unsafe struct UAudioSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FSoftObjectPath DefaultSoundClassName;
    [FieldOffset(0x0050)] public FSoftObjectPath DefaultMediaSoundClassName;
    [FieldOffset(0x0068)] public FSoftObjectPath DefaultSoundConcurrencyName;
    [FieldOffset(0x0080)] public FSoftObjectPath DefaultBaseSoundMix;
    [FieldOffset(0x0098)] public FSoftObjectPath VoiPSoundClass;
    [FieldOffset(0x00B0)] public FSoftObjectPath MasterSubmix;
    [FieldOffset(0x00C8)] public FSoftObjectPath BaseDefaultSubmix;
    [FieldOffset(0x00E0)] public FSoftObjectPath ReverbSubmix;
    [FieldOffset(0x00F8)] public FSoftObjectPath EQSubmix;
    [FieldOffset(0x0110)] public EVoiceSampleRate VoiPSampleRate;
    [FieldOffset(0x0114)] public float DefaultReverbSendLevel;
    [FieldOffset(0x0118)] public int MaximumConcurrentStreams;
    [FieldOffset(0x011C)] public float GlobalMinPitchScale;
    [FieldOffset(0x0120)] public float GlobalMaxPitchScale;
    [FieldOffset(0x0128)] public TArray<FAudioQualitySettings> QualityLevels;
    [FieldOffset(0x0138)] public byte bAllowPlayWhenSilent;
    [FieldOffset(0x0138)] public byte bDisableMasterEQ;
    [FieldOffset(0x0138)] public byte bAllowCenterChannel3DPanning;
    [FieldOffset(0x013C)] public uint NumStoppingSources;
    [FieldOffset(0x0140)] public EPanningMethod PanningMethod;
    [FieldOffset(0x0141)] public EMonoChannelUpmixMethod MonoChannelUpmixMethod;
    [FieldOffset(0x0148)] public FString DialogueFilenameFormat;
    [FieldOffset(0x0158)] public TArray<FSoundDebugEntry> DebugSounds;
    [FieldOffset(0x0168)] public TArray<FDefaultAudioBusSettings> DefaultAudioBuses;
    [FieldOffset(0x0178)] public USoundClass* DefaultSoundClass;
    [FieldOffset(0x0180)] public USoundClass* DefaultMediaSoundClass;
    [FieldOffset(0x0188)] public USoundConcurrency* DefaultSoundConcurrency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FReverbSettings
{
    [FieldOffset(0x0000)] public bool bApplyReverb;
    [FieldOffset(0x0008)] public UReverbEffect* ReverbEffect;
    [FieldOffset(0x0010)] public USoundEffectSubmixPreset* ReverbPluginEffect;
    [FieldOffset(0x0018)] public float Volume;
    [FieldOffset(0x001C)] public float FadeTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FInteriorSettings
{
    [FieldOffset(0x0000)] public bool bIsWorldSettings;
    [FieldOffset(0x0004)] public float ExteriorVolume;
    [FieldOffset(0x0008)] public float ExteriorTime;
    [FieldOffset(0x000C)] public float ExteriorLPF;
    [FieldOffset(0x0010)] public float ExteriorLPFTime;
    [FieldOffset(0x0014)] public float InteriorVolume;
    [FieldOffset(0x0018)] public float InteriorTime;
    [FieldOffset(0x001C)] public float InteriorLPF;
    [FieldOffset(0x0020)] public float InteriorLPFTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAudioVolumeSubmixSendSettings
{
    [FieldOffset(0x0000)] public EAudioVolumeLocationState ListenerLocationState;
    [FieldOffset(0x0001)] public EAudioVolumeLocationState SourceLocationState;
    [FieldOffset(0x0008)] public TArray<FSoundSubmixSendInfo> SubmixSends;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAudioVolumeSubmixOverrideSettings
{
    [FieldOffset(0x0000)] public USoundSubmix* Submix;
    [FieldOffset(0x0008)] public TArray<IntPtr> SubmixEffectChain;
    [FieldOffset(0x0018)] public float CrossfadeTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct AAudioVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public float Priority;
    [FieldOffset(0x025C)] public byte bEnabled;
    [FieldOffset(0x0260)] public FReverbSettings Settings;
    [FieldOffset(0x0280)] public FInteriorSettings AmbientZoneSettings;
    [FieldOffset(0x02A8)] public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings;
    [FieldOffset(0x02B8)] public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAutoDestroySubsystem
{
    [FieldOffset(0x0000)] public UTickableWorldSubsystem baseObj;
    [FieldOffset(0x0040)] public TArray<IntPtr> ActorsToPoll;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEditorMapPerformanceTestDefinition
{
    [FieldOffset(0x0000)] public FSoftObjectPath PerformanceTestmap;
    [FieldOffset(0x0018)] public int TestTimer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFilePath
{
    [FieldOffset(0x0000)] public FString FilePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FImportFactorySettingValues
{
    [FieldOffset(0x0000)] public FString SettingName;
    [FieldOffset(0x0010)] public FString Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEditorImportWorkflowDefinition
{
    [FieldOffset(0x0000)] public FFilePath ImportFilePath;
    [FieldOffset(0x0010)] public TArray<FImportFactorySettingValues> FactorySettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct FBuildPromotionImportWorkflowSettings
{
    [FieldOffset(0x0000)] public FEditorImportWorkflowDefinition Diffuse;
    [FieldOffset(0x0020)] public FEditorImportWorkflowDefinition Normal;
    [FieldOffset(0x0040)] public FEditorImportWorkflowDefinition StaticMesh;
    [FieldOffset(0x0060)] public FEditorImportWorkflowDefinition ReimportStaticMesh;
    [FieldOffset(0x0080)] public FEditorImportWorkflowDefinition BlendShapeMesh;
    [FieldOffset(0x00A0)] public FEditorImportWorkflowDefinition MorphMesh;
    [FieldOffset(0x00C0)] public FEditorImportWorkflowDefinition SkeletalMesh;
    [FieldOffset(0x00E0)] public FEditorImportWorkflowDefinition Animation;
    [FieldOffset(0x0100)] public FEditorImportWorkflowDefinition Sound;
    [FieldOffset(0x0120)] public FEditorImportWorkflowDefinition SurroundSound;
    [FieldOffset(0x0140)] public TArray<FEditorImportWorkflowDefinition> OtherAssetsToImport;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FBuildPromotionOpenAssetSettings
{
    [FieldOffset(0x0000)] public FFilePath BlueprintAsset;
    [FieldOffset(0x0010)] public FFilePath MaterialAsset;
    [FieldOffset(0x0020)] public FFilePath ParticleSystemAsset;
    [FieldOffset(0x0030)] public FFilePath SkeletalMeshAsset;
    [FieldOffset(0x0040)] public FFilePath StaticMeshAsset;
    [FieldOffset(0x0050)] public FFilePath TextureAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBuildPromotionNewProjectSettings
{
    [FieldOffset(0x0000)] public FDirectoryPath NewProjectFolderOverride;
    [FieldOffset(0x0010)] public FString NewProjectNameOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct FBuildPromotionTestSettings
{
    [FieldOffset(0x0000)] public FFilePath DefaultStaticMeshAsset;
    [FieldOffset(0x0010)] public FBuildPromotionImportWorkflowSettings ImportWorkflow;
    [FieldOffset(0x0160)] public FBuildPromotionOpenAssetSettings OpenAssets;
    [FieldOffset(0x01C0)] public FBuildPromotionNewProjectSettings NewProjectSettings;
    [FieldOffset(0x01E0)] public FFilePath SourceControlMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMaterialEditorPromotionSettings
{
    [FieldOffset(0x0000)] public FFilePath DefaultMaterialAsset;
    [FieldOffset(0x0010)] public FFilePath DefaultDiffuseTexture;
    [FieldOffset(0x0020)] public FFilePath DefaultNormalTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FParticleEditorPromotionSettings
{
    [FieldOffset(0x0000)] public FFilePath DefaultParticleAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBlueprintEditorPromotionSettings
{
    [FieldOffset(0x0000)] public FFilePath FirstMeshPath;
    [FieldOffset(0x0010)] public FFilePath SecondMeshPath;
    [FieldOffset(0x0020)] public FFilePath DefaultParticleAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FExternalToolDefinition
{
    [FieldOffset(0x0000)] public FString ToolName;
    [FieldOffset(0x0010)] public FFilePath ExecutablePath;
    [FieldOffset(0x0020)] public FString CommandLineOptions;
    [FieldOffset(0x0030)] public FDirectoryPath WorkingDirectory;
    [FieldOffset(0x0040)] public FString ScriptExtension;
    [FieldOffset(0x0050)] public FDirectoryPath ScriptDirectory;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FEditorImportExportTestDefinition
{
    [FieldOffset(0x0000)] public FFilePath ImportFilePath;
    [FieldOffset(0x0010)] public FString ExportFileExtension;
    [FieldOffset(0x0020)] public bool bSkipExport;
    [FieldOffset(0x0028)] public TArray<FImportFactorySettingValues> FactorySettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLaunchOnTestSettings
{
    [FieldOffset(0x0000)] public FFilePath LaunchOnTestmap;
    [FieldOffset(0x0010)] public FString DeviceID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct UAutomationTestSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FString> EngineTestModules;
    [FieldOffset(0x0038)] public TArray<FString> EditorTestModules;
    [FieldOffset(0x0048)] public FSoftObjectPath AutomationTestmap;
    [FieldOffset(0x0060)] public TArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps;
    [FieldOffset(0x0070)] public TArray<FSoftObjectPath> AssetsToOpen;
    [FieldOffset(0x0080)] public TArray<FString> MapsToPIETest;
    [FieldOffset(0x0090)] public FBuildPromotionTestSettings BuildPromotionTest;
    [FieldOffset(0x0280)] public FMaterialEditorPromotionSettings MaterialEditorPromotionTest;
    [FieldOffset(0x02B0)] public FParticleEditorPromotionSettings ParticleEditorPromotionTest;
    [FieldOffset(0x02C0)] public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest;
    [FieldOffset(0x02F0)] public TArray<FString> TestLevelFolders;
    [FieldOffset(0x0300)] public TArray<FExternalToolDefinition> ExternalTools;
    [FieldOffset(0x0310)] public TArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions;
    [FieldOffset(0x0320)] public TArray<FLaunchOnTestSettings> LaunchOnSettings;
    [FieldOffset(0x0330)] public FIntPoint DefaultScreenshotResolution;
    [FieldOffset(0x0338)] public float PIETestDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UAvoidanceManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public float DefaultTimeToLive;
    [FieldOffset(0x0034)] public float LockTimeAfterAvoid;
    [FieldOffset(0x0038)] public float LockTimeAfterClean;
    [FieldOffset(0x003C)] public float DeltaTimeToPredict;
    [FieldOffset(0x0040)] public float ArtificialRadiusExpansion;
    [FieldOffset(0x0044)] public float TestHeightDifference;
    [FieldOffset(0x0048)] public float HeightCheckMargin;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBandwidthTestItem
{
    [FieldOffset(0x0000)] public TArray<byte> Kilobyte;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBandwidthTestGenerator
{
    [FieldOffset(0x0000)] public TArray<FBandwidthTestItem> ReplicatedBuffers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct ABandwidthTestActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public FBandwidthTestGenerator BandwidthGenerator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UBillboardComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UTexture2D* Sprite;
    [FieldOffset(0x0458)] public byte bIsScreenSizeScaled;
    [FieldOffset(0x045C)] public float ScreenSize;
    [FieldOffset(0x0460)] public float U;
    [FieldOffset(0x0464)] public float UL;
    [FieldOffset(0x0468)] public float V;
    [FieldOffset(0x046C)] public float VL;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBlendableInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBoneNode
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int ParentIndex;
    [FieldOffset(0x000C)] public EBoneTranslationRetargetingMode TranslationRetargetingMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FVirtualBone
{
    [FieldOffset(0x0000)] public FName SourceBoneName;
    [FieldOffset(0x0008)] public FName TargetBoneName;
    [FieldOffset(0x0010)] public FName VirtualBoneName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FSmartNameContainer
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimSlotGroup
{
    [FieldOffset(0x0000)] public FName GroupName;
    [FieldOffset(0x0008)] public TArray<FName> SlotNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x390)] 
public unsafe struct USkeleton
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<FBoneNode> BoneTree;
    [FieldOffset(0x0048)] public TArray<FTransform> RefLocalPoses;
    [FieldOffset(0x0170)] public FGuid VirtualBoneGuid;
    [FieldOffset(0x0180)] public TArray<FVirtualBone> VirtualBones;
    [FieldOffset(0x0190)] public TArray<IntPtr> Sockets;
    [FieldOffset(0x01F0)] public FSmartNameContainer SmartNames;
    [FieldOffset(0x0270)] public TArray<IntPtr> BlendProfiles;
    [FieldOffset(0x0280)] public TArray<FAnimSlotGroup> SlotGroups;
    [FieldOffset(0x0380)] public TArray<IntPtr> AssetUserData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FBlendProfileBoneEntry
{
    [FieldOffset(0x0000)] public FBoneReference BoneReference;
    [FieldOffset(0x0010)] public float BlendScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBlendProfile
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public USkeleton* OwningSkeleton;
    [FieldOffset(0x0038)] public TArray<FBlendProfileBoneEntry> ProfileEntries;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ABlockingVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintExtension
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintMapLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintPathsLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct UPlatformGameInstance
{
    [FieldOffset(0x0000)] public UGameInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintPlatformLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintSetLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FKSphereElem
{
    [FieldOffset(0x0000)] public FKShapeElem baseObj;
    [FieldOffset(0x0030)] public FVector Center;
    [FieldOffset(0x003C)] public float Radius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FKBoxElem
{
    [FieldOffset(0x0000)] public FKShapeElem baseObj;
    [FieldOffset(0x0030)] public FVector Center;
    [FieldOffset(0x003C)] public FRotator Rotation;
    [FieldOffset(0x0048)] public float X;
    [FieldOffset(0x004C)] public float Y;
    [FieldOffset(0x0050)] public float Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FKSphylElem
{
    [FieldOffset(0x0000)] public FKShapeElem baseObj;
    [FieldOffset(0x0030)] public FVector Center;
    [FieldOffset(0x003C)] public FRotator Rotation;
    [FieldOffset(0x0048)] public float Radius;
    [FieldOffset(0x004C)] public float Length;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FKTaperedCapsuleElem
{
    [FieldOffset(0x0000)] public FKShapeElem baseObj;
    [FieldOffset(0x0030)] public FVector Center;
    [FieldOffset(0x003C)] public FRotator Rotation;
    [FieldOffset(0x0048)] public float Radius0;
    [FieldOffset(0x004C)] public float Radius1;
    [FieldOffset(0x0050)] public float Length;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FKAggregateGeom
{
    [FieldOffset(0x0000)] public TArray<FKSphereElem> SphereElems;
    [FieldOffset(0x0010)] public TArray<FKBoxElem> BoxElems;
    [FieldOffset(0x0020)] public TArray<FKSphylElem> SphylElems;
    [FieldOffset(0x0030)] public TArray<FKConvexElem> ConvexElems;
    [FieldOffset(0x0040)] public TArray<FKTaperedCapsuleElem> TaperedCapsuleElems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct UBodySetup
{
    [FieldOffset(0x0000)] public UBodySetupCore baseObj;
    [FieldOffset(0x0048)] public FKAggregateGeom AggGeom;
    [FieldOffset(0x00A0)] public byte bAlwaysFullAnimWeight;
    [FieldOffset(0x00A0)] public byte bConsiderForBounds;
    [FieldOffset(0x00A0)] public byte bMeshCollideAll;
    [FieldOffset(0x00A0)] public byte bDoubleSidedGeometry;
    [FieldOffset(0x00A0)] public byte bGenerateNonMirroredCollision;
    [FieldOffset(0x00A0)] public byte bSharedCookedData;
    [FieldOffset(0x00A0)] public byte bGenerateMirroredCollision;
    [FieldOffset(0x00A0)] public byte bSupportUVsAndFaceRemap;
    [FieldOffset(0x00A8)] public UPhysicalMaterial* PhysMaterial;
    [FieldOffset(0x00B0)] public FWalkableSlopeOverride WalkableSlopeOverride;
    [FieldOffset(0x0128)] public FBodyInstance DefaultInstance;
    [FieldOffset(0x0288)] public FVector BuildScale3D;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBranchFilter
{
    [FieldOffset(0x0000)] public FName BoneName;
    [FieldOffset(0x0008)] public int BlendDepth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FInputBlendPose
{
    [FieldOffset(0x0000)] public TArray<FBranchFilter> BranchFilters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBoneMaskFilter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FInputBlendPose> BlendPoses;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBookmarkBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBookMark
{
    [FieldOffset(0x0000)] public UBookmarkBase baseObj;
    [FieldOffset(0x0028)] public FVector Location;
    [FieldOffset(0x0034)] public FRotator Rotation;
    [FieldOffset(0x0040)] public TArray<FString> HiddenLevels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBookMark2D
{
    [FieldOffset(0x0000)] public UBookmarkBase baseObj;
    [FieldOffset(0x0028)] public float Zoom2D;
    [FieldOffset(0x002C)] public FIntPoint Location;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UBoundsCopyComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public TSoftObjectPtr<AActor> BoundsSourceActor;
    [FieldOffset(0x00D8)] public bool bUseCollidingComponentsForSourceBounds;
    [FieldOffset(0x00D9)] public bool bKeepOwnBoundsScale;
    [FieldOffset(0x00DA)] public bool bUseCollidingComponentsForOwnBounds;
    [FieldOffset(0x00E0)] public FTransform PostTransform;
    [FieldOffset(0x0110)] public bool bCopyXBounds;
    [FieldOffset(0x0111)] public bool bCopyYBounds;
    [FieldOffset(0x0112)] public bool bCopyZBounds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AReflectionCapture
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UReflectionCaptureComponent* CaptureComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ABoxReflectionCapture
{
    [FieldOffset(0x0000)] public AReflectionCapture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UReflectionCaptureComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public UBillboardComponent* CaptureOffsetComponent;
    [FieldOffset(0x0200)] public EReflectionSourceType ReflectionSourceType;
    [FieldOffset(0x0201)] public EMobileReflectionCompression MobileReflectionCompression;
    [FieldOffset(0x0208)] public UTextureCube* Cubemap;
    [FieldOffset(0x0210)] public float SourceCubemapAngle;
    [FieldOffset(0x0214)] public float Brightness;
    [FieldOffset(0x0218)] public bool bModifyMaxValueRGBM;
    [FieldOffset(0x021C)] public float MaxValueRGBM;
    [FieldOffset(0x0220)] public FVector CaptureOffset;
    [FieldOffset(0x022C)] public FGuid MapBuildDataId;
    [FieldOffset(0x0250)] public UTextureCube* CachedEncodedHDRCubemap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UBoxReflectionCaptureComponent
{
    [FieldOffset(0x0000)] public UReflectionCaptureComponent baseObj;
    [FieldOffset(0x0270)] public float BoxTransitionDistance;
    [FieldOffset(0x0278)] public UBoxComponent* PreviewInfluenceBox;
    [FieldOffset(0x0280)] public UBoxComponent* PreviewCaptureBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UBreakpoint
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bEnabled;
    [FieldOffset(0x0030)] public UEdGraphNode* Node;
    [FieldOffset(0x0038)] public byte bStepOnce;
    [FieldOffset(0x0038)] public byte bStepOnce_WasPreviouslyDisabled;
    [FieldOffset(0x0038)] public byte bStepOnce_RemoveAfterHit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBuilderPoly
{
    [FieldOffset(0x0000)] public TArray<int> VertexIndices;
    [FieldOffset(0x0010)] public int Direction;
    [FieldOffset(0x0014)] public FName ItemName;
    [FieldOffset(0x001C)] public int PolyFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UBrushBuilder
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString BitmapFilename;
    [FieldOffset(0x0038)] public FString Tooltip;
    [FieldOffset(0x0048)] public byte NotifyBadParams;
    [FieldOffset(0x0050)] public TArray<FVector> Vertices;
    [FieldOffset(0x0060)] public TArray<FBuilderPoly> Polys;
    [FieldOffset(0x0070)] public FName Layer;
    [FieldOffset(0x0078)] public byte MergeCoplanars;
}

[StructLayout(LayoutKind.Explicit, Size = 0x460)] 
public unsafe struct UBrushComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UModel* Brush;
    [FieldOffset(0x0458)] public UBodySetup* BrushBodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ABrushShape
{
    [FieldOffset(0x0000)] public ABrush baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct UButtonStyleAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FButtonStyle ButtonStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5D0)] 
public unsafe struct UCameraAnim
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UInterpGroup* CameraInterpGroup;
    [FieldOffset(0x0030)] public float AnimLength;
    [FieldOffset(0x0034)] public FBox BoundingBox;
    [FieldOffset(0x0050)] public byte bRelativeToInitialTransform;
    [FieldOffset(0x0050)] public byte bRelativeToInitialFOV;
    [FieldOffset(0x0054)] public float BaseFOV;
    [FieldOffset(0x0060)] public FPostProcessSettings BasePostProcessSettings;
    [FieldOffset(0x05C0)] public float BasePostProcessBlendWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UCameraAnimInst
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UCameraAnim* CamAnim;
    [FieldOffset(0x0030)] public UInterpGroupInst* InterpGroupInst;
    [FieldOffset(0x0050)] public float PlayRate;
    [FieldOffset(0x0068)] public UInterpTrackMove* MoveTrack;
    [FieldOffset(0x0070)] public UInterpTrackInstMove* MoveInst;
    [FieldOffset(0x0078)] public ECameraShakePlaySpace PlaySpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ACameraBlockingVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UCameraModifier
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bDebug;
    [FieldOffset(0x0028)] public byte bExclusive;
    [FieldOffset(0x002C)] public byte Priority;
    [FieldOffset(0x0030)] public APlayerCameraManager* CameraOwner;
    [FieldOffset(0x0038)] public float AlphaInTime;
    [FieldOffset(0x003C)] public float AlphaOutTime;
    [FieldOffset(0x0040)] public float Alpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FActiveCameraShakeInfo
{
    [FieldOffset(0x0000)] public UCameraShakeBase* ShakeInstance;
    [FieldOffset(0x0008)] public TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource;
    [FieldOffset(0x0010)] public bool bIsCustomInitialized;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPooledCameraShakes
{
    [FieldOffset(0x0000)] public TArray<IntPtr> PooledShakes;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UCameraModifier_CameraShake
{
    [FieldOffset(0x0000)] public UCameraModifier baseObj;
    [FieldOffset(0x0048)] public TArray<FActiveCameraShakeInfo> ActiveShakes;
    [FieldOffset(0x0058)] public TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes> ExpiredPooledShakesMap;
    [FieldOffset(0x00A8)] public float SplitScreenShakeScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ACameraShakeSourceActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UCameraShakeSourceComponent* CameraShakeSourceComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UCameraShakeSourceComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public ECameraShakeAttenuation Attenuation;
    [FieldOffset(0x01FC)] public float InnerAttenuationRadius;
    [FieldOffset(0x0200)] public float OuterAttenuationRadius;
    [FieldOffset(0x0208)] public TSubclassOf<UCameraShakeBase> CameraShake;
    [FieldOffset(0x0210)] public bool bAutoStart;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FCanvasUVTri
{
    [FieldOffset(0x0000)] public FVector2D V0_Pos;
    [FieldOffset(0x0008)] public FVector2D V0_UV;
    [FieldOffset(0x0010)] public FLinearColor V0_Color;
    [FieldOffset(0x0020)] public FVector2D V1_Pos;
    [FieldOffset(0x0028)] public FVector2D V1_UV;
    [FieldOffset(0x0030)] public FLinearColor V1_Color;
    [FieldOffset(0x0040)] public FVector2D V2_Pos;
    [FieldOffset(0x0048)] public FVector2D V2_UV;
    [FieldOffset(0x0050)] public FLinearColor V2_Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct UCanvas
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float OrgX;
    [FieldOffset(0x002C)] public float OrgY;
    [FieldOffset(0x0030)] public float ClipX;
    [FieldOffset(0x0034)] public float ClipY;
    [FieldOffset(0x0038)] public FColor DrawColor;
    [FieldOffset(0x003C)] public byte bCenterX;
    [FieldOffset(0x003C)] public byte bCenterY;
    [FieldOffset(0x003C)] public byte bNoSmooth;
    [FieldOffset(0x0040)] public int SizeX;
    [FieldOffset(0x0044)] public int SizeY;
    [FieldOffset(0x0050)] public FPlane ColorModulate;
    [FieldOffset(0x0060)] public UTexture2D* DefaultTexture;
    [FieldOffset(0x0068)] public UTexture2D* GradientTexture0;
    [FieldOffset(0x0070)] public UReporterGraph* ReporterGraph;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UTextureRenderTarget
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0178)] public float TargetGamma;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UTextureRenderTarget2D
{
    [FieldOffset(0x0000)] public UTextureRenderTarget baseObj;
    [FieldOffset(0x0180)] public int SizeX;
    [FieldOffset(0x0184)] public int SizeY;
    [FieldOffset(0x0188)] public FLinearColor ClearColor;
    [FieldOffset(0x0198)] public TextureAddress AddressX;
    [FieldOffset(0x0199)] public TextureAddress AddressY;
    [FieldOffset(0x019A)] public byte bForceLinearGamma;
    [FieldOffset(0x019A)] public byte bHDR;
    [FieldOffset(0x019A)] public byte bGPUSharedFlag;
    [FieldOffset(0x019B)] public ETextureRenderTargetFormat RenderTargetFormat;
    [FieldOffset(0x019C)] public byte bAutoGenerateMips;
    [FieldOffset(0x019D)] public TextureFilter MipsSamplerFilter;
    [FieldOffset(0x019E)] public TextureAddress MipsAddressU;
    [FieldOffset(0x019F)] public TextureAddress MipsAddressV;
    [FieldOffset(0x01A0)] public EPixelFormat OverrideFormat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UCanvasRenderTarget2D
{
    [FieldOffset(0x0000)] public UTextureRenderTarget2D baseObj;
    [FieldOffset(0x01B8)] public TWeakObjectPtr<UWorld> World;
    [FieldOffset(0x01C0)] public bool bShouldClearRenderTargetOnReceiveUpdate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UCapsuleComponent
{
    [FieldOffset(0x0000)] public UShapeComponent baseObj;
    [FieldOffset(0x0468)] public float CapsuleHalfHeight;
    [FieldOffset(0x046C)] public float CapsuleRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCheatManagerExtension
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5A8)] 
public unsafe struct UCheckBoxStyleAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FCheckBoxStyle CheckBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UChildActorComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public TSubclassOf<AActor> ChildActorClass;
    [FieldOffset(0x0200)] public AActor* childActor;
    [FieldOffset(0x0208)] public AActor* ChildActorTemplate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1BB0)] 
public unsafe struct UChildConnection
{
    [FieldOffset(0x0000)] public UNetConnection baseObj;
    [FieldOffset(0x1BA8)] public UNetConnection* Parent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDelegateArray
{
    //[FieldOffset(0x0000)] public TArray<FDelegateArrayDelegates> Delegates;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPlatformInterfaceBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FDelegateArray> AllDelegates;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UCloudStorageBase
{
    [FieldOffset(0x0000)] public UPlatformInterfaceBase baseObj;
    [FieldOffset(0x0038)] public TArray<FString> LocalCloudFiles;
    [FieldOffset(0x0048)] public byte bSuppressDelegateCalls;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FCollisionResponseTemplate
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public ECollisionEnabled CollisionEnabled;
    [FieldOffset(0x000A)] public bool bCanModify;
    [FieldOffset(0x002C)] public FName ObjectTypeName;
    [FieldOffset(0x0038)] public TArray<FResponseChannel> CustomResponses;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FCustomChannelSetup
{
    [FieldOffset(0x0000)] public ECollisionChannel Channel;
    [FieldOffset(0x0001)] public ECollisionResponse DefaultResponse;
    [FieldOffset(0x0002)] public bool bTraceType;
    [FieldOffset(0x0003)] public bool bStaticObject;
    [FieldOffset(0x0004)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCustomProfile
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public TArray<FResponseChannel> CustomResponses;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRedirector
{
    [FieldOffset(0x0000)] public FName OldName;
    [FieldOffset(0x0008)] public FName NewName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UCollisionProfile
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public TArray<FCollisionResponseTemplate> Profiles;
    [FieldOffset(0x0048)] public TArray<FCustomChannelSetup> DefaultChannelResponses;
    [FieldOffset(0x0058)] public TArray<FCustomProfile> EditProfiles;
    [FieldOffset(0x0068)] public TArray<FRedirector> ProfileRedirects;
    [FieldOffset(0x0078)] public TArray<FRedirector> CollisionChannelRedirects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBlueprintComponentDelegateBinding
{
    [FieldOffset(0x0000)] public FName ComponentPropertyName;
    [FieldOffset(0x0008)] public FName DelegatePropertyName;
    [FieldOffset(0x0010)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UComponentDelegateBinding
{
    [FieldOffset(0x0000)] public UDynamicBlueprintBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintComponentDelegateBinding> ComponentDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UActorComponentInstanceDataTransientOuter
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UCurveTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UCompositeCurveTable
{
    [FieldOffset(0x0000)] public UCurveTable baseObj;
    [FieldOffset(0x00A0)] public TArray<IntPtr> ParentTables;
    [FieldOffset(0x00B0)] public TArray<IntPtr> OldParentTables;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UDataTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UScriptStruct* RowStruct;
    [FieldOffset(0x0080)] public byte bStripFromClientBuilds;
    [FieldOffset(0x0080)] public byte bIgnoreExtraFields;
    [FieldOffset(0x0080)] public byte bIgnoreMissingFields;
    [FieldOffset(0x0088)] public FString ImportKeyField;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UCompositeDataTable
{
    [FieldOffset(0x0000)] public UDataTable baseObj;
    [FieldOffset(0x00B0)] public TArray<IntPtr> ParentTables;
    [FieldOffset(0x00C0)] public TArray<IntPtr> OldParentTables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FStatColorMapEntry
{
    [FieldOffset(0x0000)] public float In;
    [FieldOffset(0x0004)] public FColor Out;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStatColorMapping
{
    [FieldOffset(0x0000)] public FString StatName;
    [FieldOffset(0x0010)] public TArray<FStatColorMapEntry> ColorMap;
    [FieldOffset(0x0020)] public byte DisableBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGameNameRedirect
{
    [FieldOffset(0x0000)] public FName OldGameName;
    [FieldOffset(0x0008)] public FName NewGameName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FClassRedirect
{
    [FieldOffset(0x0000)] public FName ObjectName;
    [FieldOffset(0x0008)] public FName OldClassName;
    [FieldOffset(0x0010)] public FName NewClassName;
    [FieldOffset(0x0018)] public FName OldSubobjName;
    [FieldOffset(0x0020)] public FName NewSubobjName;
    [FieldOffset(0x0028)] public FName NewClassClass;
    [FieldOffset(0x0030)] public FName NewClassPackage;
    [FieldOffset(0x0038)] public bool InstanceOnly;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FPluginRedirect
{
    [FieldOffset(0x0000)] public FString OldPluginName;
    [FieldOffset(0x0010)] public FString NewPluginName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FStructRedirect
{
    [FieldOffset(0x0000)] public FName OldStructName;
    [FieldOffset(0x0008)] public FName NewStructName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDropNoteInfo
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FRotator Rotation;
    [FieldOffset(0x0018)] public FString Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNetDriverDefinition
{
    [FieldOffset(0x0000)] public FName DefName;
    [FieldOffset(0x0008)] public FName DriverClassName;
    [FieldOffset(0x0010)] public FName DriverClassNameFallback;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD20)] 
public unsafe struct UEngine
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UFont* TinyFont;
    [FieldOffset(0x0038)] public FSoftObjectPath TinyFontName;
    [FieldOffset(0x0050)] public UFont* SmallFont;
    [FieldOffset(0x0058)] public FSoftObjectPath SmallFontName;
    [FieldOffset(0x0070)] public UFont* MediumFont;
    [FieldOffset(0x0078)] public FSoftObjectPath MediumFontName;
    [FieldOffset(0x0090)] public UFont* LargeFont;
    [FieldOffset(0x0098)] public FSoftObjectPath LargeFontName;
    [FieldOffset(0x00B0)] public UFont* SubtitleFont;
    [FieldOffset(0x00B8)] public FSoftObjectPath SubtitleFontName;
    [FieldOffset(0x00D0)] public TArray<IntPtr> AdditionalFonts;
    [FieldOffset(0x00E0)] public TArray<FString> AdditionalFontNames;
    [FieldOffset(0x00F0)] public TSubclassOf<UConsole> ConsoleClass;
    [FieldOffset(0x00F8)] public FSoftClassPath ConsoleClassName;
    [FieldOffset(0x0110)] public TSubclassOf<UGameViewportClient> GameViewportClientClass;
    [FieldOffset(0x0118)] public FSoftClassPath GameViewportClientClassName;
    [FieldOffset(0x0130)] public TSubclassOf<ULocalPlayer> LocalPlayerClass;
    [FieldOffset(0x0138)] public FSoftClassPath LocalPlayerClassName;
    [FieldOffset(0x0150)] public TSubclassOf<AWorldSettings> WorldSettingsClass;
    [FieldOffset(0x0158)] public FSoftClassPath WorldSettingsClassName;
    [FieldOffset(0x0170)] public FSoftClassPath NavigationSystemClassName;
    [FieldOffset(0x0188)] public TSubclassOf<UNavigationSystemBase> NavigationSystemClass;
    [FieldOffset(0x0190)] public FSoftClassPath NavigationSystemConfigClassName;
    [FieldOffset(0x01A8)] public TSubclassOf<UNavigationSystemConfig> NavigationSystemConfigClass;
    [FieldOffset(0x01B0)] public FSoftClassPath AvoidanceManagerClassName;
    [FieldOffset(0x01C8)] public TSubclassOf<UAvoidanceManager> AvoidanceManagerClass;
    [FieldOffset(0x01D0)] public FSoftClassPath AIControllerClassName;
    [FieldOffset(0x01E8)] public TSubclassOf<UPhysicsCollisionHandler> PhysicsCollisionHandlerClass;
    [FieldOffset(0x01F0)] public FSoftClassPath PhysicsCollisionHandlerClassName;
    [FieldOffset(0x0208)] public FSoftClassPath GameUserSettingsClassName;
    [FieldOffset(0x0220)] public TSubclassOf<UGameUserSettings> GameUserSettingsClass;
    [FieldOffset(0x0228)] public UGameUserSettings* GameUserSettings;
    [FieldOffset(0x0230)] public TSubclassOf<ALevelScriptActor> LevelScriptActorClass;
    [FieldOffset(0x0238)] public FSoftClassPath LevelScriptActorClassName;
    [FieldOffset(0x0250)] public FSoftClassPath DefaultBlueprintBaseClassName;
    [FieldOffset(0x0268)] public FSoftClassPath GameSingletonClassName;
    [FieldOffset(0x0280)] public UObject* GameSingleton;
    [FieldOffset(0x0288)] public FSoftClassPath AssetManagerClassName;
    [FieldOffset(0x02A0)] public UAssetManager* AssetManager;
    [FieldOffset(0x02A8)] public UTexture2D* DefaultTexture;
    [FieldOffset(0x02B0)] public FSoftObjectPath DefaultTextureName;
    [FieldOffset(0x02C8)] public UTexture* DefaultDiffuseTexture;
    [FieldOffset(0x02D0)] public FSoftObjectPath DefaultDiffuseTextureName;
    [FieldOffset(0x02E8)] public UTexture2D* DefaultBSPVertexTexture;
    [FieldOffset(0x02F0)] public FSoftObjectPath DefaultBSPVertexTextureName;
    [FieldOffset(0x0308)] public UTexture2D* HighFrequencyNoiseTexture;
    [FieldOffset(0x0310)] public FSoftObjectPath HighFrequencyNoiseTextureName;
    [FieldOffset(0x0328)] public UTexture2D* DefaultBokehTexture;
    [FieldOffset(0x0330)] public FSoftObjectPath DefaultBokehTextureName;
    [FieldOffset(0x0348)] public UTexture2D* DefaultBloomKernelTexture;
    [FieldOffset(0x0350)] public FSoftObjectPath DefaultBloomKernelTextureName;
    [FieldOffset(0x0368)] public UMaterial* WireframeMaterial;
    [FieldOffset(0x0370)] public FString WireframeMaterialName;
    [FieldOffset(0x0380)] public UMaterial* DebugMeshMaterial;
    [FieldOffset(0x0388)] public FSoftObjectPath DebugMeshMaterialName;
    [FieldOffset(0x03A0)] public UMaterial* EmissiveMeshMaterial;
    [FieldOffset(0x03A8)] public FSoftObjectPath EmissiveMeshMaterialName;
    [FieldOffset(0x03C0)] public UMaterial* LevelColorationLitMaterial;
    [FieldOffset(0x03C8)] public FString LevelColorationLitMaterialName;
    [FieldOffset(0x03D8)] public UMaterial* LevelColorationUnlitMaterial;
    [FieldOffset(0x03E0)] public FString LevelColorationUnlitMaterialName;
    [FieldOffset(0x03F0)] public UMaterial* LightingTexelDensityMaterial;
    [FieldOffset(0x03F8)] public FString LightingTexelDensityName;
    [FieldOffset(0x0408)] public UMaterial* ShadedLevelColorationLitMaterial;
    [FieldOffset(0x0410)] public FString ShadedLevelColorationLitMaterialName;
    [FieldOffset(0x0420)] public UMaterial* ShadedLevelColorationUnlitMaterial;
    [FieldOffset(0x0428)] public FString ShadedLevelColorationUnlitMaterialName;
    [FieldOffset(0x0438)] public UMaterial* RemoveSurfaceMaterial;
    [FieldOffset(0x0440)] public FSoftObjectPath RemoveSurfaceMaterialName;
    [FieldOffset(0x0458)] public UMaterial* VertexColorMaterial;
    [FieldOffset(0x0460)] public FString VertexColorMaterialName;
    [FieldOffset(0x0470)] public UMaterial* VertexColorViewModeMaterial_ColorOnly;
    [FieldOffset(0x0478)] public FString VertexColorViewModeMaterialName_ColorOnly;
    [FieldOffset(0x0488)] public UMaterial* VertexColorViewModeMaterial_AlphaAsColor;
    [FieldOffset(0x0490)] public FString VertexColorViewModeMaterialName_AlphaAsColor;
    [FieldOffset(0x04A0)] public UMaterial* VertexColorViewModeMaterial_RedOnly;
    [FieldOffset(0x04A8)] public FString VertexColorViewModeMaterialName_RedOnly;
    [FieldOffset(0x04B8)] public UMaterial* VertexColorViewModeMaterial_GreenOnly;
    [FieldOffset(0x04C0)] public FString VertexColorViewModeMaterialName_GreenOnly;
    [FieldOffset(0x04D0)] public UMaterial* VertexColorViewModeMaterial_BlueOnly;
    [FieldOffset(0x04D8)] public FString VertexColorViewModeMaterialName_BlueOnly;
    [FieldOffset(0x04E8)] public FSoftObjectPath DebugEditorMaterialName;
    [FieldOffset(0x0500)] public UMaterial* ConstraintLimitMaterial;
    [FieldOffset(0x0508)] public UMaterialInstanceDynamic* ConstraintLimitMaterialX;
    [FieldOffset(0x0510)] public UMaterialInstanceDynamic* ConstraintLimitMaterialXAxis;
    [FieldOffset(0x0518)] public UMaterialInstanceDynamic* ConstraintLimitMaterialY;
    [FieldOffset(0x0520)] public UMaterialInstanceDynamic* ConstraintLimitMaterialYAxis;
    [FieldOffset(0x0528)] public UMaterialInstanceDynamic* ConstraintLimitMaterialZ;
    [FieldOffset(0x0530)] public UMaterialInstanceDynamic* ConstraintLimitMaterialZAxis;
    [FieldOffset(0x0538)] public UMaterialInstanceDynamic* ConstraintLimitMaterialPrismatic;
    [FieldOffset(0x0540)] public UMaterial* InvalidLightmapSettingsMaterial;
    [FieldOffset(0x0548)] public FSoftObjectPath InvalidLightmapSettingsMaterialName;
    [FieldOffset(0x0560)] public UMaterial* PreviewShadowsIndicatorMaterial;
    [FieldOffset(0x0568)] public FSoftObjectPath PreviewShadowsIndicatorMaterialName;
    [FieldOffset(0x0580)] public UMaterial* ArrowMaterial;
    [FieldOffset(0x0588)] public UMaterialInstanceDynamic* ArrowMaterialYellow;
    [FieldOffset(0x0590)] public FSoftObjectPath ArrowMaterialName;
    [FieldOffset(0x05A8)] public FLinearColor LightingOnlyBrightness;
    [FieldOffset(0x05B8)] public TArray<FLinearColor> ShaderComplexityColors;
    [FieldOffset(0x05C8)] public TArray<FLinearColor> QuadComplexityColors;
    [FieldOffset(0x05D8)] public TArray<FLinearColor> LightComplexityColors;
    [FieldOffset(0x05E8)] public TArray<FLinearColor> StationaryLightOverlapColors;
    [FieldOffset(0x05F8)] public TArray<FLinearColor> LODColorationColors;
    [FieldOffset(0x0608)] public TArray<FLinearColor> HLODColorationColors;
    [FieldOffset(0x0618)] public TArray<FLinearColor> StreamingAccuracyColors;
    [FieldOffset(0x0628)] public float MaxPixelShaderAdditiveComplexityCount;
    [FieldOffset(0x062C)] public float MaxES3PixelShaderAdditiveComplexityCount;
    [FieldOffset(0x0630)] public float MinLightMapDensity;
    [FieldOffset(0x0634)] public float IdealLightMapDensity;
    [FieldOffset(0x0638)] public float MaxLightMapDensity;
    [FieldOffset(0x063C)] public byte bRenderLightMapDensityGrayscale;
    [FieldOffset(0x0640)] public float RenderLightMapDensityGrayscaleScale;
    [FieldOffset(0x0644)] public float RenderLightMapDensityColorScale;
    [FieldOffset(0x0648)] public FLinearColor LightMapDensityVertexMappedColor;
    [FieldOffset(0x0658)] public FLinearColor LightMapDensitySelectedColor;
    [FieldOffset(0x0668)] public TArray<FStatColorMapping> StatColorMappings;
    [FieldOffset(0x0678)] public UPhysicalMaterial* DefaultPhysMaterial;
    [FieldOffset(0x0680)] public FSoftObjectPath DefaultPhysMaterialName;
    [FieldOffset(0x0698)] public TArray<FGameNameRedirect> ActiveGameNameRedirects;
    [FieldOffset(0x06A8)] public TArray<FClassRedirect> ActiveClassRedirects;
    [FieldOffset(0x06B8)] public TArray<FPluginRedirect> ActivePluginRedirects;
    [FieldOffset(0x06C8)] public TArray<FStructRedirect> ActiveStructRedirects;
    [FieldOffset(0x06D8)] public UTexture2D* PreIntegratedSkinBRDFTexture;
    [FieldOffset(0x06E0)] public FSoftObjectPath PreIntegratedSkinBRDFTextureName;
    [FieldOffset(0x06F8)] public UTexture2D* BlueNoiseTexture;
    [FieldOffset(0x0700)] public FSoftObjectPath BlueNoiseTextureName;
    [FieldOffset(0x0718)] public UTexture2D* MiniFontTexture;
    [FieldOffset(0x0720)] public FSoftObjectPath MiniFontTextureName;
    [FieldOffset(0x0738)] public UTexture* WeightMapPlaceholderTexture;
    [FieldOffset(0x0740)] public FSoftObjectPath WeightMapPlaceholderTextureName;
    [FieldOffset(0x0758)] public UTexture2D* LightMapDensityTexture;
    [FieldOffset(0x0760)] public FSoftObjectPath LightMapDensityTextureName;
    [FieldOffset(0x0780)] public UGameViewportClient* GameViewport;
    [FieldOffset(0x0788)] public TArray<FString> DeferredCommands;
    [FieldOffset(0x0798)] public float NearClipPlane;
    [FieldOffset(0x079C)] public byte bSubtitlesEnabled;
    [FieldOffset(0x079C)] public byte bSubtitlesForcedOff;
    [FieldOffset(0x07A0)] public int MaximumLoopIterationCount;
    [FieldOffset(0x07A4)] public byte bCanBlueprintsTickByDefault;
    [FieldOffset(0x07A4)] public byte bOptimizeAnimBlueprintMemberVariableAccess;
    [FieldOffset(0x07A4)] public byte bAllowMultiThreadedAnimationUpdate;
    [FieldOffset(0x07A4)] public byte bEnableEditorPSysRealtimeLOD;
    [FieldOffset(0x07A4)] public byte bSmoothFrameRate;
    [FieldOffset(0x07A4)] public byte bUseFixedFrameRate;
    [FieldOffset(0x07A8)] public float FixedFrameRate;
    [FieldOffset(0x07AC)] public FFloatRange SmoothedFrameRateRange;
    [FieldOffset(0x07C0)] public UEngineCustomTimeStep* CustomTimeStep;
    [FieldOffset(0x07E8)] public FSoftClassPath CustomTimeStepClassName;
    [FieldOffset(0x0800)] public UTimecodeProvider* TimecodeProvider;
    [FieldOffset(0x0828)] public FSoftClassPath TimecodeProviderClassName;
    [FieldOffset(0x0840)] public bool bGenerateDefaultTimecode;
    [FieldOffset(0x0844)] public FFrameRate GenerateDefaultTimecodeFrameRate;
    [FieldOffset(0x084C)] public float GenerateDefaultTimecodeFrameDelay;
    [FieldOffset(0x0850)] public byte bCheckForMultiplePawnsSpawnedInAFrame;
    [FieldOffset(0x0854)] public int NumPawnsAllowedToBeSpawnedInAFrame;
    [FieldOffset(0x0858)] public byte bShouldGenerateLowQualityLightmaps;
    [FieldOffset(0x085C)] public FColor C_WorldBox;
    [FieldOffset(0x0860)] public FColor C_BrushWire;
    [FieldOffset(0x0864)] public FColor C_AddWire;
    [FieldOffset(0x0868)] public FColor C_SubtractWire;
    [FieldOffset(0x086C)] public FColor C_SemiSolidWire;
    [FieldOffset(0x0870)] public FColor C_NonSolidWire;
    [FieldOffset(0x0874)] public FColor C_WireBackground;
    [FieldOffset(0x0878)] public FColor C_ScaleBoxHi;
    [FieldOffset(0x087C)] public FColor C_VolumeCollision;
    [FieldOffset(0x0880)] public FColor C_BSPCollision;
    [FieldOffset(0x0884)] public FColor C_OrthoBackground;
    [FieldOffset(0x0888)] public FColor C_Volume;
    [FieldOffset(0x088C)] public FColor C_BrushShape;
    [FieldOffset(0x0890)] public float StreamingDistanceFactor;
    [FieldOffset(0x0898)] public FDirectoryPath GameScreenshotSaveDirectory;
    [FieldOffset(0x08A8)] public ETransitionType TransitionType;
    [FieldOffset(0x08B0)] public FString TransitionDescription;
    [FieldOffset(0x08C0)] public FString TransitionGameMode;
    [FieldOffset(0x08D0)] public byte bAllowMatureLanguage;
    [FieldOffset(0x08D4)] public float CameraRotationThreshold;
    [FieldOffset(0x08D8)] public float CameraTranslationThreshold;
    [FieldOffset(0x08DC)] public float PrimitiveProbablyVisibleTime;
    [FieldOffset(0x08E0)] public float MaxOcclusionPixelsFraction;
    [FieldOffset(0x08E4)] public byte bPauseOnLossOfFocus;
    [FieldOffset(0x08E8)] public int MaxParticleResize;
    [FieldOffset(0x08EC)] public int MaxParticleResizeWarn;
    [FieldOffset(0x08F0)] public TArray<FDropNoteInfo> PendingDroppedNotes;
    [FieldOffset(0x0900)] public float NetClientTicksPerSecond;
    [FieldOffset(0x0904)] public float DisplayGamma;
    [FieldOffset(0x0908)] public float MinDesiredFrameRate;
    [FieldOffset(0x090C)] public FLinearColor DefaultSelectedMaterialColor;
    [FieldOffset(0x091C)] public FLinearColor SelectedMaterialColor;
    [FieldOffset(0x092C)] public FLinearColor SelectionOutlineColor;
    [FieldOffset(0x093C)] public FLinearColor SubduedSelectionOutlineColor;
    [FieldOffset(0x094C)] public FLinearColor SelectedMaterialColorOverride;
    [FieldOffset(0x095C)] public bool bIsOverridingSelectedColor;
    [FieldOffset(0x0960)] public byte bEnableOnScreenDebugMessages;
    [FieldOffset(0x0960)] public byte bEnableOnScreenDebugMessagesDisplay;
    [FieldOffset(0x0960)] public byte bSuppressMapWarnings;
    [FieldOffset(0x0960)] public byte bDisableAILogging;
    [FieldOffset(0x0964)] public uint bEnableVisualLogRecordingOnStart;
    [FieldOffset(0x0968)] public int ScreenSaverInhibitorSemaphore;
    [FieldOffset(0x096C)] public byte bLockReadOnlyLevels;
    [FieldOffset(0x0970)] public FString ParticleEventManagerClassPath;
    [FieldOffset(0x0980)] public float SelectionHighlightIntensity;
    [FieldOffset(0x0984)] public float BSPSelectionHighlightIntensity;
    [FieldOffset(0x0988)] public float SelectionHighlightIntensityBillboards;
    [FieldOffset(0x0BF8)] public TArray<FNetDriverDefinition> NetDriverDefinitions;
    [FieldOffset(0x0C08)] public TArray<FString> ServerActors;
    [FieldOffset(0x0C18)] public TArray<FString> RuntimeServerActors;
    [FieldOffset(0x0C28)] public float NetErrorLogInterval;
    [FieldOffset(0x0C2C)] public byte bStartedLoadMapMovie;
    [FieldOffset(0x0C48)] public int NextWorldContextHandle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UScriptViewportClient
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDebugDisplayProperty
{
    [FieldOffset(0x0000)] public UObject* Obj;
    [FieldOffset(0x0008)] public UClass* WithinClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct UGameViewportClient
{
    [FieldOffset(0x0000)] public UScriptViewportClient baseObj;
    [FieldOffset(0x0040)] public UConsole* ViewportConsole;
    [FieldOffset(0x0048)] public TArray<FDebugDisplayProperty> DebugProperties;
    [FieldOffset(0x0068)] public int MaxSplitscreenPlayers;
    [FieldOffset(0x0078)] public UWorld* World;
    [FieldOffset(0x0080)] public UGameInstance* GameInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UConsole
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public ULocalPlayer* ConsoleTargetPlayer;
    [FieldOffset(0x0040)] public UTexture2D* DefaultTexture_Black;
    [FieldOffset(0x0048)] public UTexture2D* DefaultTexture_White;
    [FieldOffset(0x0068)] public TArray<FString> HistoryBuffer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UControlChannel
{
    [FieldOffset(0x0000)] public UChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UStreamingSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public byte AsyncLoadingThreadEnabled;
    [FieldOffset(0x0038)] public byte WarnIfTimeLimitExceeded;
    [FieldOffset(0x003C)] public float TimeLimitExceededMultiplier;
    [FieldOffset(0x0040)] public float TimeLimitExceededMinTime;
    [FieldOffset(0x0044)] public int MinBulkDataSizeForAsyncLoading;
    [FieldOffset(0x0048)] public byte UseBackgroundLevelStreaming;
    [FieldOffset(0x0048)] public byte AsyncLoadingUseFullTimeLimit;
    [FieldOffset(0x004C)] public float AsyncLoadingTimeLimit;
    [FieldOffset(0x0050)] public float PriorityAsyncLoadingExtraTime;
    [FieldOffset(0x0054)] public float LevelStreamingActorsUpdateTimeLimit;
    [FieldOffset(0x0058)] public float PriorityLevelStreamingActorsUpdateExtraTime;
    [FieldOffset(0x005C)] public int LevelStreamingComponentsRegistrationGranularity;
    [FieldOffset(0x0060)] public float LevelStreamingUnregisterComponentsTimeLimit;
    [FieldOffset(0x0064)] public int LevelStreamingComponentsUnregistrationGranularity;
    [FieldOffset(0x0068)] public byte FlushStreamingOnExit;
    [FieldOffset(0x0068)] public byte EventDrivenLoaderEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGarbageCollectionSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public float TimeBetweenPurgingPendingKillObjects;
    [FieldOffset(0x003C)] public byte FlushStreamingOnGC;
    [FieldOffset(0x003C)] public byte AllowParallelGC;
    [FieldOffset(0x003C)] public byte IncrementalBeginDestroyEnabled;
    [FieldOffset(0x003C)] public byte MultithreadedDestructionEnabled;
    [FieldOffset(0x003C)] public byte CreateGCClusters;
    [FieldOffset(0x003C)] public byte AssetClusteringEnabled;
    [FieldOffset(0x003C)] public byte ActorClusteringEnabled;
    [FieldOffset(0x003C)] public byte BlueprintClusteringEnabled;
    [FieldOffset(0x003D)] public byte UseDisregardForGCOnDedicatedServers;
    [FieldOffset(0x0040)] public int MinGCClusterSize;
    [FieldOffset(0x0044)] public int NumRetriesBeforeForcingGC;
    [FieldOffset(0x0048)] public int MaxObjectsNotConsideredByGC;
    [FieldOffset(0x004C)] public int SizeOfPermanentObjectPool;
    [FieldOffset(0x0050)] public int MaxObjectsInGame;
    [FieldOffset(0x0054)] public int MaxObjectsInEditor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCullDistanceSizePair
{
    [FieldOffset(0x0000)] public float Size;
    [FieldOffset(0x0004)] public float CullDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ACullDistanceVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public TArray<FCullDistanceSizePair> CullDistances;
    [FieldOffset(0x0268)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UCurveBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDEPRECATED_CurveEdPresetCurve
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UCurveFloat
{
    [FieldOffset(0x0000)] public UCurveBase baseObj;
    [FieldOffset(0x0030)] public FRichCurve FloatCurve;
    [FieldOffset(0x00B0)] public bool bIsEventCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UCurveLinearColor
{
    [FieldOffset(0x0000)] public UCurveBase baseObj;
    [FieldOffset(0x0030)] public FRichCurve FloatCurves;
    [FieldOffset(0x0230)] public float AdjustHue;
    [FieldOffset(0x0234)] public float AdjustSaturation;
    [FieldOffset(0x0238)] public float AdjustBrightness;
    [FieldOffset(0x023C)] public float AdjustBrightnessCurve;
    [FieldOffset(0x0240)] public float AdjustVibrance;
    [FieldOffset(0x0244)] public float AdjustMinAlpha;
    [FieldOffset(0x0248)] public float AdjustMaxAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UTexture2D
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0178)] public int LevelIndex;
    [FieldOffset(0x017C)] public int FirstResourceMemMip;
    [FieldOffset(0x0180)] public byte bTemporarilyDisableStreaming;
    [FieldOffset(0x0181)] public TextureAddress AddressX;
    [FieldOffset(0x0182)] public TextureAddress AddressY;
    [FieldOffset(0x0184)] public FIntPoint ImportedSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UCurveLinearColorAtlas
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
    [FieldOffset(0x01A0)] public uint TextureSize;
    [FieldOffset(0x01A4)] public byte bSquareResolution;
    [FieldOffset(0x01A8)] public uint TextureHeight;
    [FieldOffset(0x01B0)] public TArray<IntPtr> GradientCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNamedCurveValue
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ICurveSourceInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UCurveVector
{
    [FieldOffset(0x0000)] public UCurveBase baseObj;
    [FieldOffset(0x0030)] public FRichCurve FloatCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDamageType
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bCausedByWorld;
    [FieldOffset(0x0028)] public byte bScaleMomentumByMass;
    [FieldOffset(0x0028)] public byte bRadialDamageVelChange;
    [FieldOffset(0x002C)] public float DamageImpulse;
    [FieldOffset(0x0030)] public float DestructibleImpulse;
    [FieldOffset(0x0034)] public float DestructibleDamageSpreadScale;
    [FieldOffset(0x0038)] public float DamageFalloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDataDrivenCVarEngineSubsystem
{
    [FieldOffset(0x0000)] public UEngineSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDataDrivenConsoleVariable
{
    [FieldOffset(0x0000)] public FDataDrivenCVarType Type;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FString Tooltip;
    [FieldOffset(0x0028)] public float DefaultValueFloat;
    [FieldOffset(0x002C)] public int DefaultValueInt;
    [FieldOffset(0x0030)] public bool DefaultValueBool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDataDrivenConsoleVariableSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0050)] public TArray<FDataDrivenConsoleVariable> CVarsArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDataTableFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x680)] 
public unsafe struct ADebugCameraController
{
    [FieldOffset(0x0000)] public APlayerController baseObj;
    [FieldOffset(0x0580)] public byte bShowSelectedInfo;
    [FieldOffset(0x0580)] public byte bIsFrozenRendering;
    [FieldOffset(0x0580)] public byte bIsOrbitingSelectedActor;
    [FieldOffset(0x0580)] public byte bOrbitPivotUseCenter;
    [FieldOffset(0x0580)] public byte bEnableBufferVisualization;
    [FieldOffset(0x0580)] public byte bEnableBufferVisualizationFullMode;
    [FieldOffset(0x0580)] public byte bIsBufferVisualizationInputSetup;
    [FieldOffset(0x0580)] public byte bLastDisplayEnabled;
    [FieldOffset(0x0588)] public UDrawFrustumComponent* DrawFrustum;
    [FieldOffset(0x0590)] public AActor* SelectedActor;
    [FieldOffset(0x0598)] public UPrimitiveComponent* SelectedComponent;
    [FieldOffset(0x05A0)] public FHitResult SelectedHitPoint;
    [FieldOffset(0x0628)] public APlayerController* OriginalControllerRef;
    [FieldOffset(0x0630)] public UPlayer* OriginalPlayer;
    [FieldOffset(0x0638)] public float SpeedScale;
    [FieldOffset(0x063C)] public float InitialMaxSpeed;
    [FieldOffset(0x0640)] public float InitialAccel;
    [FieldOffset(0x0644)] public float InitialDecel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDebugCameraControllerSettingsViewModeIndex
{
    [FieldOffset(0x0008)] public EViewModeIndex ViewModeIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDebugCameraControllerSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public TArray<FDebugCameraControllerSettingsViewModeIndex> CycleViewModes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct ADebugCameraHUD
{
    [FieldOffset(0x0000)] public AHUD baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDebugDrawService
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ADecalActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UDecalComponent* Decal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct UDecalComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public UMaterialInterface* DecalMaterial;
    [FieldOffset(0x0200)] public int SortOrder;
    [FieldOffset(0x0204)] public float FadeScreenSize;
    [FieldOffset(0x0208)] public float FadeStartDelay;
    [FieldOffset(0x020C)] public float FadeDuration;
    [FieldOffset(0x0210)] public float FadeInDuration;
    [FieldOffset(0x0214)] public float FadeInStartDelay;
    [FieldOffset(0x0218)] public byte bDestroyOwnerAfterFade;
    [FieldOffset(0x021C)] public FVector DecalSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ADefaultPawn
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public float BaseTurnRate;
    [FieldOffset(0x0284)] public float BaseLookUpRate;
    [FieldOffset(0x0288)] public UPawnMovementComponent* MovementComponent;
    [FieldOffset(0x0290)] public USphereComponent* CollisionComponent;
    [FieldOffset(0x0298)] public UStaticMeshComponent* MeshComponent;
    [FieldOffset(0x02A0)] public byte bAddDefaultMovementBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct APhysicsVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public float TerminalVelocity;
    [FieldOffset(0x025C)] public int Priority;
    [FieldOffset(0x0260)] public float FluidFriction;
    [FieldOffset(0x0264)] public byte bWaterVolume;
    [FieldOffset(0x0264)] public byte bPhysicsOnContact;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct ADefaultPhysicsVolume
{
    [FieldOffset(0x0000)] public APhysicsVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C18)] 
public unsafe struct UDemoNetConnection
{
    [FieldOffset(0x0000)] public UNetConnection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FRollbackNetStartupActorInfo
{
    [FieldOffset(0x0008)] public UObject* Archetype;
    [FieldOffset(0x0038)] public ULevel* Level;
    [FieldOffset(0x00A0)] public TArray<IntPtr> ObjReferences;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMulticastRecordOptions
{
    [FieldOffset(0x0000)] public FString FuncPathName;
    [FieldOffset(0x0010)] public bool bServerSkip;
    [FieldOffset(0x0011)] public bool bClientSkip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x12D8)] 
public unsafe struct UDemoNetDriver
{
    [FieldOffset(0x0000)] public UNetDriver baseObj;
    [FieldOffset(0x0858)] public TMap<FString, FRollbackNetStartupActorInfo> RollbackNetStartupActors;
    [FieldOffset(0x0A04)] public float CheckpointSaveMaxMSPerFrame;
    [FieldOffset(0x0A28)] public TArray<FMulticastRecordOptions> MulticastRecordOptions;
    [FieldOffset(0x0A38)] public bool bIsLocalReplay;
    [FieldOffset(0x0A40)] public TArray<IntPtr> SpectatorControllers;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UPendingNetGame
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UNetDriver* NetDriver;
    [FieldOffset(0x0038)] public UDemoNetDriver* DemoNetDriver;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UDemoPendingNetGame
{
    [FieldOffset(0x0000)] public UPendingNetGame baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IDestructibleInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FTextureLODGroup
{
    [FieldOffset(0x0000)] public TextureGroup Group;
    [FieldOffset(0x000C)] public int LODBias;
    [FieldOffset(0x0010)] public int LODBias_Smaller;
    [FieldOffset(0x0014)] public int LODBias_Smallest;
    [FieldOffset(0x001C)] public int NumStreamedMips;
    [FieldOffset(0x0020)] public TextureMipGenSettings MipGenSettings;
    [FieldOffset(0x0024)] public int MinLODSize;
    [FieldOffset(0x0028)] public int MaxLODSize;
    [FieldOffset(0x002C)] public int MaxLODSize_Smaller;
    [FieldOffset(0x0030)] public int MaxLODSize_Smallest;
    [FieldOffset(0x0034)] public int OptionalLODBias;
    [FieldOffset(0x0038)] public int OptionalMaxLODSize;
    [FieldOffset(0x0040)] public FName MinMagFilter;
    [FieldOffset(0x0048)] public FName MipFilter;
    [FieldOffset(0x0050)] public ETextureMipLoadOptions MipLoadOptions;
    [FieldOffset(0x0051)] public bool HighPriorityLoad;
    [FieldOffset(0x0052)] public bool DuplicateNonOptionalMips;
    [FieldOffset(0x0054)] public float Downscale;
    [FieldOffset(0x0058)] public ETextureDownscaleOptions DownscaleOptions;
    [FieldOffset(0x005C)] public int VirtualTextureTileCountBias;
    [FieldOffset(0x0060)] public int VirtualTextureTileSizeBias;
    [FieldOffset(0x0064)] public ETextureLossyCompressionAmount LossyCompressionAmount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTextureLODSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FTextureLODGroup> TextureLODGroups;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UDeviceProfile
{
    [FieldOffset(0x0000)] public UTextureLODSettings baseObj;
    [FieldOffset(0x0038)] public FString DeviceType;
    [FieldOffset(0x0048)] public FString BaseProfileName;
    [FieldOffset(0x0058)] public UObject* Parent;
    [FieldOffset(0x0088)] public TArray<FString> CVars;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDeviceProfileFragment
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UDeviceProfileManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Profiles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UDialogueSoundWaveProxy
{
    [FieldOffset(0x0000)] public USoundBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDialogueVoice
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public EGrammaticalGender Gender;
    [FieldOffset(0x0029)] public EGrammaticalNumber Plurality;
    [FieldOffset(0x002C)] public FGuid LocalizationGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDialogueContext
{
    [FieldOffset(0x0000)] public UDialogueVoice* Speaker;
    [FieldOffset(0x0008)] public TArray<IntPtr> Targets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDialogueContextMapping
{
    [FieldOffset(0x0000)] public FDialogueContext Context;
    [FieldOffset(0x0018)] public USoundWave* SoundWave;
    [FieldOffset(0x0020)] public FString LocalizationKeyFormat;
    [FieldOffset(0x0030)] public UDialogueSoundWaveProxy* Proxy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UDialogueWave
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bMature;
    [FieldOffset(0x0028)] public byte bOverride_SubtitleOverride;
    [FieldOffset(0x0030)] public FString SpokenText;
    [FieldOffset(0x0040)] public FString SubtitleOverride;
    [FieldOffset(0x0050)] public TArray<FDialogueContextMapping> ContextMappings;
    [FieldOffset(0x0060)] public FGuid LocalizationGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ALight
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ULightComponent* LightComponent;
    [FieldOffset(0x0228)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ADirectionalLight
{
    [FieldOffset(0x0000)] public ALight baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ULightComponentBase
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public FGuid LightGuid;
    [FieldOffset(0x0208)] public float Brightness;
    [FieldOffset(0x020C)] public float Intensity;
    [FieldOffset(0x0210)] public FColor LightColor;
    [FieldOffset(0x0214)] public byte bAffectsWorld;
    [FieldOffset(0x0214)] public byte CastShadows;
    [FieldOffset(0x0214)] public byte CastStaticShadows;
    [FieldOffset(0x0214)] public byte CastDynamicShadows;
    [FieldOffset(0x0214)] public byte bAffectTranslucentLighting;
    [FieldOffset(0x0214)] public byte bTransmission;
    [FieldOffset(0x0214)] public byte bCastVolumetricShadow;
    [FieldOffset(0x0214)] public byte bCastDeepShadow;
    [FieldOffset(0x0215)] public byte bCastRaytracedShadow;
    [FieldOffset(0x0215)] public byte bAffectReflection;
    [FieldOffset(0x0215)] public byte bAffectGlobalIllumination;
    [FieldOffset(0x0218)] public float DeepShadowLayerDistribution;
    [FieldOffset(0x021C)] public float IndirectLightingIntensity;
    [FieldOffset(0x0220)] public float VolumetricScatteringIntensity;
    [FieldOffset(0x0224)] public int SamplesPerPixel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct ULightComponent
{
    [FieldOffset(0x0000)] public ULightComponentBase baseObj;
    [FieldOffset(0x0228)] public float Temperature;
    [FieldOffset(0x022C)] public float MaxDrawDistance;
    [FieldOffset(0x0230)] public float MaxDistanceFadeRange;
    [FieldOffset(0x0234)] public byte bUseTemperature;
    [FieldOffset(0x0238)] public int ShadowMapChannel;
    [FieldOffset(0x0240)] public float MinRoughness;
    [FieldOffset(0x0244)] public float SpecularScale;
    [FieldOffset(0x0248)] public float ShadowResolutionScale;
    [FieldOffset(0x024C)] public float ShadowBias;
    [FieldOffset(0x0250)] public float ShadowSlopeBias;
    [FieldOffset(0x0254)] public float ShadowSharpen;
    [FieldOffset(0x0258)] public float ContactShadowLength;
    [FieldOffset(0x025C)] public byte ContactShadowLengthInWS;
    [FieldOffset(0x025C)] public byte InverseSquaredFalloff;
    [FieldOffset(0x025C)] public byte CastTranslucentShadows;
    [FieldOffset(0x025C)] public byte bCastShadowsFromCinematicObjectsOnly;
    [FieldOffset(0x025C)] public byte bAffectDynamicIndirectLighting;
    [FieldOffset(0x025C)] public byte bForceCachedShadowsForMovablePrimitives;
    [FieldOffset(0x0260)] public FLightingChannels LightingChannels;
    [FieldOffset(0x0268)] public UMaterialInterface* LightFunctionMaterial;
    [FieldOffset(0x0270)] public FVector LightFunctionScale;
    [FieldOffset(0x0280)] public UTextureLightProfile* IESTexture;
    [FieldOffset(0x0288)] public byte bUseIESBrightness;
    [FieldOffset(0x028C)] public float IESBrightnessScale;
    [FieldOffset(0x0290)] public float LightFunctionFadeDistance;
    [FieldOffset(0x0294)] public float DisabledBrightness;
    [FieldOffset(0x0298)] public byte bEnableLightShaftBloom;
    [FieldOffset(0x029C)] public float BloomScale;
    [FieldOffset(0x02A0)] public float BloomThreshold;
    [FieldOffset(0x02A4)] public float BloomMaxBrightness;
    [FieldOffset(0x02A8)] public FColor BloomTint;
    [FieldOffset(0x02AC)] public bool bUseRayTracedDistanceFieldShadows;
    [FieldOffset(0x02B0)] public float RayStartOffsetDepthScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FLightmassLightSettings
{
    [FieldOffset(0x0000)] public float IndirectLightingSaturation;
    [FieldOffset(0x0004)] public float ShadowExponent;
    [FieldOffset(0x0008)] public bool bUseAreaShadowsForStationaryLight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLightmassDirectionalLightSettings
{
    [FieldOffset(0x0000)] public FLightmassLightSettings baseObj;
    [FieldOffset(0x000C)] public float LightSourceAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F0)] 
public unsafe struct UDirectionalLightComponent
{
    [FieldOffset(0x0000)] public ULightComponent baseObj;
    [FieldOffset(0x0328)] public float ShadowCascadeBiasDistribution;
    [FieldOffset(0x032C)] public byte bEnableLightShaftOcclusion;
    [FieldOffset(0x0330)] public float OcclusionMaskDarkness;
    [FieldOffset(0x0334)] public float OcclusionDepthRange;
    [FieldOffset(0x0338)] public FVector LightShaftOverrideDirection;
    [FieldOffset(0x0344)] public float WholeSceneDynamicShadowRadius;
    [FieldOffset(0x0348)] public float DynamicShadowDistanceMovableLight;
    [FieldOffset(0x034C)] public float DynamicShadowDistanceStationaryLight;
    [FieldOffset(0x0350)] public int DynamicShadowCascades;
    [FieldOffset(0x0354)] public float CascadeDistributionExponent;
    [FieldOffset(0x0358)] public float CascadeTransitionFraction;
    [FieldOffset(0x035C)] public float ShadowDistanceFadeoutFraction;
    [FieldOffset(0x0360)] public byte bUseInsetShadowsForMovableObjects;
    [FieldOffset(0x0364)] public int FarShadowCascadeCount;
    [FieldOffset(0x0368)] public float FarShadowDistance;
    [FieldOffset(0x036C)] public float DistanceFieldShadowDistance;
    [FieldOffset(0x0370)] public float LightSourceAngle;
    [FieldOffset(0x0374)] public float LightSourceSoftAngle;
    [FieldOffset(0x0378)] public float ShadowSourceAngleFactor;
    [FieldOffset(0x037C)] public float TraceDistance;
    [FieldOffset(0x0380)] public byte bUsedAsAtmosphereSunLight;
    [FieldOffset(0x0384)] public int AtmosphereSunLightIndex;
    [FieldOffset(0x0388)] public FLinearColor AtmosphereSunDiskColorScale;
    [FieldOffset(0x0398)] public byte bPerPixelAtmosphereTransmittance;
    [FieldOffset(0x0398)] public byte bCastShadowsOnClouds;
    [FieldOffset(0x0398)] public byte bCastShadowsOnAtmosphere;
    [FieldOffset(0x0398)] public byte bCastCloudShadows;
    [FieldOffset(0x039C)] public float CloudShadowStrength;
    [FieldOffset(0x03A0)] public float CloudShadowOnAtmosphereStrength;
    [FieldOffset(0x03A4)] public float CloudShadowOnSurfaceStrength;
    [FieldOffset(0x03A8)] public float CloudShadowDepthBias;
    [FieldOffset(0x03AC)] public float CloudShadowExtent;
    [FieldOffset(0x03B0)] public float CloudShadowMapResolutionScale;
    [FieldOffset(0x03B4)] public float CloudShadowRaySampleCountScale;
    [FieldOffset(0x03B8)] public FLinearColor CloudScatteredLuminanceScale;
    [FieldOffset(0x03C8)] public FLightmassDirectionalLightSettings LightmassSettings;
    [FieldOffset(0x03D8)] public byte bCastModulatedShadows;
    [FieldOffset(0x03DC)] public FColor ModulatedShadowColor;
    [FieldOffset(0x03E0)] public float ShadowAmount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UDistribution
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDistributionFloat
{
    [FieldOffset(0x0000)] public UDistribution baseObj;
    [FieldOffset(0x0030)] public byte bCanBeBaked;
    [FieldOffset(0x0030)] public byte bBakedDataSuccesfully;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDistributionFloatConstant
{
    [FieldOffset(0x0000)] public UDistributionFloat baseObj;
    [FieldOffset(0x0038)] public float Constant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDistributionFloatConstantCurve
{
    [FieldOffset(0x0000)] public UDistributionFloat baseObj;
    [FieldOffset(0x0038)] public FInterpCurveFloat ConstantCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDistributionFloatParameterBase
{
    [FieldOffset(0x0000)] public UDistributionFloatConstant baseObj;
    [FieldOffset(0x0040)] public FName ParameterName;
    [FieldOffset(0x0048)] public float MinInput;
    [FieldOffset(0x004C)] public float MaxInput;
    [FieldOffset(0x0050)] public float MinOutput;
    [FieldOffset(0x0054)] public float MaxOutput;
    [FieldOffset(0x0058)] public DistributionParamMode ParamMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDistributionFloatParticleParameter
{
    [FieldOffset(0x0000)] public UDistributionFloatParameterBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDistributionFloatUniform
{
    [FieldOffset(0x0000)] public UDistributionFloat baseObj;
    [FieldOffset(0x0038)] public float Min;
    [FieldOffset(0x003C)] public float Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDistributionFloatUniformCurve
{
    [FieldOffset(0x0000)] public UDistributionFloat baseObj;
    [FieldOffset(0x0038)] public FInterpCurveVector2D ConstantCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDistributionVector
{
    [FieldOffset(0x0000)] public UDistribution baseObj;
    [FieldOffset(0x0030)] public byte bCanBeBaked;
    [FieldOffset(0x0030)] public byte bIsDirty;
    [FieldOffset(0x0030)] public byte bBakedDataSuccesfully;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDistributionVectorConstant
{
    [FieldOffset(0x0000)] public UDistributionVector baseObj;
    [FieldOffset(0x0038)] public FVector Constant;
    [FieldOffset(0x0044)] public byte bLockAxes;
    [FieldOffset(0x0048)] public EDistributionVectorLockFlags LockedAxes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDistributionVectorConstantCurve
{
    [FieldOffset(0x0000)] public UDistributionVector baseObj;
    [FieldOffset(0x0038)] public FInterpCurveVector ConstantCurve;
    [FieldOffset(0x0050)] public byte bLockAxes;
    [FieldOffset(0x0054)] public EDistributionVectorLockFlags LockedAxes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDistributionVectorParameterBase
{
    [FieldOffset(0x0000)] public UDistributionVectorConstant baseObj;
    [FieldOffset(0x0050)] public FName ParameterName;
    [FieldOffset(0x0058)] public FVector MinInput;
    [FieldOffset(0x0064)] public FVector MaxInput;
    [FieldOffset(0x0070)] public FVector MinOutput;
    [FieldOffset(0x007C)] public FVector MaxOutput;
    [FieldOffset(0x0088)] public DistributionParamMode ParamModes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDistributionVectorParticleParameter
{
    [FieldOffset(0x0000)] public UDistributionVectorParameterBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDistributionVectorUniform
{
    [FieldOffset(0x0000)] public UDistributionVector baseObj;
    [FieldOffset(0x0038)] public FVector Max;
    [FieldOffset(0x0044)] public FVector Min;
    [FieldOffset(0x0050)] public byte bLockAxes;
    [FieldOffset(0x0054)] public EDistributionVectorLockFlags LockedAxes;
    [FieldOffset(0x0055)] public EDistributionVectorMirrorFlags MirrorFlags;
    [FieldOffset(0x0058)] public byte bUseExtremes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDistributionVectorUniformCurve
{
    [FieldOffset(0x0000)] public UDistributionVector baseObj;
    [FieldOffset(0x0038)] public FInterpCurveTwoVectors ConstantCurve;
    [FieldOffset(0x0050)] public byte bLockAxes1;
    [FieldOffset(0x0050)] public byte bLockAxes2;
    [FieldOffset(0x0054)] public EDistributionVectorLockFlags LockedAxes;
    [FieldOffset(0x0056)] public EDistributionVectorMirrorFlags MirrorFlags;
    [FieldOffset(0x005C)] public byte bUseExtremes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ADocumentationActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDPICustomScalingRule
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UDrawFrustumComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public FColor FrustumColor;
    [FieldOffset(0x0454)] public float FrustumAngle;
    [FieldOffset(0x0458)] public float FrustumAspectRatio;
    [FieldOffset(0x045C)] public float FrustumStartDist;
    [FieldOffset(0x0460)] public float FrustumEndDist;
    [FieldOffset(0x0468)] public UTexture* Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UDrawSphereComponent
{
    [FieldOffset(0x0000)] public USphereComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UEdGraph
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSubclassOf<UEdGraphSchema> Schema;
    [FieldOffset(0x0030)] public TArray<IntPtr> Nodes;
    [FieldOffset(0x0040)] public byte bEditable;
    [FieldOffset(0x0040)] public byte bAllowDeletion;
    [FieldOffset(0x0040)] public byte bAllowRenaming;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UGraphNodeContextMenuContext
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UBlueprint* Blueprint;
    [FieldOffset(0x0030)] public UEdGraph* Graph;
    [FieldOffset(0x0038)] public UEdGraphNode* Node;
    [FieldOffset(0x0048)] public bool bIsDebugging;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UEdGraphNode
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> DeprecatedPins;
    [FieldOffset(0x0048)] public int NodePosX;
    [FieldOffset(0x004C)] public int NodePosY;
    [FieldOffset(0x0050)] public int NodeWidth;
    [FieldOffset(0x0054)] public int NodeHeight;
    [FieldOffset(0x0058)] public ENodeAdvancedPins AdvancedPinDisplay;
    [FieldOffset(0x0059)] public ENodeEnabledState EnabledState;
    [FieldOffset(0x005B)] public byte bDisplayAsDisabled;
    [FieldOffset(0x005B)] public byte bUserSetEnabledState;
    [FieldOffset(0x005B)] public byte bIsNodeEnabled;
    [FieldOffset(0x005B)] public byte bHasCompilerMessage;
    [FieldOffset(0x0060)] public FString NodeComment;
    [FieldOffset(0x0070)] public int ErrorType;
    [FieldOffset(0x0078)] public FString ErrorMsg;
    [FieldOffset(0x0088)] public FGuid NodeGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UEdGraphNode_Documentation
{
    [FieldOffset(0x0000)] public UEdGraphNode baseObj;
    [FieldOffset(0x0098)] public FString Link;
    [FieldOffset(0x00A8)] public FString Excerpt;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FEdGraphTerminalType
{
    [FieldOffset(0x0000)] public FName TerminalCategory;
    [FieldOffset(0x0008)] public FName TerminalSubCategory;
    [FieldOffset(0x0010)] public TWeakObjectPtr<UObject> TerminalSubCategoryObject;
    [FieldOffset(0x0018)] public bool bTerminalIsConst;
    [FieldOffset(0x0019)] public bool bTerminalIsWeakPointer;
    [FieldOffset(0x001A)] public bool bTerminalIsUObjectWrapper;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FEdGraphPinType
{
    [FieldOffset(0x0000)] public FName PinCategory;
    [FieldOffset(0x0008)] public FName PinSubCategory;
    [FieldOffset(0x0010)] public TWeakObjectPtr<UObject> PinSubCategoryObject;
    [FieldOffset(0x0018)] public FSimpleMemberReference PinSubCategoryMemberReference;
    [FieldOffset(0x0038)] public FEdGraphTerminalType PinValueType;
    [FieldOffset(0x0054)] public EPinContainerType ContainerType;
    [FieldOffset(0x0055)] public byte bIsArray;
    [FieldOffset(0x0055)] public byte bIsReference;
    [FieldOffset(0x0055)] public byte bIsConst;
    [FieldOffset(0x0055)] public byte bIsWeakPointer;
    [FieldOffset(0x0055)] public byte bIsUObjectWrapper;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UEdGraphPin_Deprecated
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString PinName;
    [FieldOffset(0x0038)] public FString PinToolTip;
    [FieldOffset(0x0048)] public EEdGraphPinDirection Direction;
    [FieldOffset(0x0050)] public FEdGraphPinType PinType;
    [FieldOffset(0x00A8)] public FString DefaultValue;
    [FieldOffset(0x00B8)] public FString AutogeneratedDefaultValue;
    [FieldOffset(0x00C8)] public UObject* DefaultObject;
    [FieldOffset(0x00D0)] public FText DefaultTextValue;
    [FieldOffset(0x00E8)] public TArray<IntPtr> LinkedTo;
    [FieldOffset(0x00F8)] public TArray<IntPtr> SubPins;
    [FieldOffset(0x0108)] public UEdGraphPin_Deprecated* ParentPin;
    [FieldOffset(0x0110)] public UEdGraphPin_Deprecated* ReferencePassThroughConnection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEdGraphSchema
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct AEmitter
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UParticleSystemComponent* ParticleSystemComponent;
    [FieldOffset(0x0228)] public byte bDestroyOnSystemFinish;
    [FieldOffset(0x0228)] public byte bPostUpdateTickGroup;
    [FieldOffset(0x0228)] public byte bCurrentlyActive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct AEmitterCameraLensEffectBase
{
    [FieldOffset(0x0000)] public AEmitter baseObj;
    [FieldOffset(0x0270)] public UParticleSystem* PS_CameraEffect;
    [FieldOffset(0x0278)] public UParticleSystem* PS_CameraEffectNonExtremeContent;
    [FieldOffset(0x0280)] public APlayerCameraManager* BaseCamera;
    [FieldOffset(0x0290)] public FTransform RelativeTransform;
    [FieldOffset(0x02C0)] public float BaseFOV;
    [FieldOffset(0x02C4)] public byte bAllowMultipleInstances;
    [FieldOffset(0x02C4)] public byte bResetWhenRetriggered;
    [FieldOffset(0x02C8)] public TArray<TSubclassOf<AEmitterCameraLensEffectBase>> EmittersToTreatAsSame;
    [FieldOffset(0x02D8)] public float DistFromCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UViewModeUtils
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEngineBaseTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEngineHandlerComponentFactory
{
    [FieldOffset(0x0000)] public UHandlerComponentFactory baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULocalMessage
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UEngineMessage
{
    [FieldOffset(0x0000)] public ULocalMessage baseObj;
    [FieldOffset(0x0028)] public FString FailedPlaceMessage;
    [FieldOffset(0x0038)] public FString MaxedOutMessage;
    [FieldOffset(0x0048)] public FString EnteredMessage;
    [FieldOffset(0x0058)] public FString LeftMessage;
    [FieldOffset(0x0068)] public FString GlobalNameChange;
    [FieldOffset(0x0078)] public FString SpecEnteredMessage;
    [FieldOffset(0x0088)] public FString NewPlayerMessage;
    [FieldOffset(0x0098)] public FString NewSpecMessage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEngineTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AExponentialHeightFog
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public UExponentialHeightFogComponent* Component;
    [FieldOffset(0x0228)] public byte bEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FExponentialHeightFogData
{
    [FieldOffset(0x0000)] public float FogDensity;
    [FieldOffset(0x0004)] public float FogHeightFalloff;
    [FieldOffset(0x0008)] public float FogHeightOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct UExponentialHeightFogComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float FogDensity;
    [FieldOffset(0x01FC)] public float FogHeightFalloff;
    [FieldOffset(0x0200)] public FExponentialHeightFogData SecondFogData;
    [FieldOffset(0x020C)] public FLinearColor FogInscatteringColor;
    [FieldOffset(0x0220)] public UTextureCube* InscatteringColorCubemap;
    [FieldOffset(0x0228)] public float InscatteringColorCubemapAngle;
    [FieldOffset(0x022C)] public FLinearColor InscatteringTextureTint;
    [FieldOffset(0x023C)] public float FullyDirectionalInscatteringColorDistance;
    [FieldOffset(0x0240)] public float NonDirectionalInscatteringColorDistance;
    [FieldOffset(0x0244)] public float DirectionalInscatteringExponent;
    [FieldOffset(0x0248)] public float DirectionalInscatteringStartDistance;
    [FieldOffset(0x024C)] public FLinearColor DirectionalInscatteringColor;
    [FieldOffset(0x025C)] public float FogMaxOpacity;
    [FieldOffset(0x0260)] public float StartDistance;
    [FieldOffset(0x0264)] public float FogCutoffDistance;
    [FieldOffset(0x0268)] public bool bEnableVolumetricFog;
    [FieldOffset(0x026C)] public float VolumetricFogScatteringDistribution;
    [FieldOffset(0x0270)] public FColor VolumetricFogAlbedo;
    [FieldOffset(0x0274)] public FLinearColor VolumetricFogEmissive;
    [FieldOffset(0x0284)] public float VolumetricFogExtinctionScale;
    [FieldOffset(0x0288)] public float VolumetricFogDistance;
    [FieldOffset(0x028C)] public float VolumetricFogStaticLightingScatteringIntensity;
    [FieldOffset(0x0290)] public bool bOverrideLightColorsWithFogInscatteringColors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UExporter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClass* SupportedClass;
    [FieldOffset(0x0030)] public UObject* ExportRootScope;
    [FieldOffset(0x0038)] public TArray<FString> FormatExtension;
    [FieldOffset(0x0048)] public TArray<FString> FormatDescription;
    [FieldOffset(0x0058)] public int PreferredFormatIndex;
    [FieldOffset(0x005C)] public int TextIndent;
    [FieldOffset(0x0060)] public byte bText;
    [FieldOffset(0x0060)] public byte bSelectedOnly;
    [FieldOffset(0x0060)] public byte bForceFileOperations;
    [FieldOffset(0x0068)] public UAssetExportTask* ExportTask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UFloatingPawnMovement
{
    [FieldOffset(0x0000)] public UPawnMovementComponent baseObj;
    [FieldOffset(0x0138)] public float MaxSpeed;
    [FieldOffset(0x013C)] public float Acceleration;
    [FieldOffset(0x0140)] public float Deceleration;
    [FieldOffset(0x0144)] public float TurningBoost;
    [FieldOffset(0x0148)] public byte bPositionCorrected;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFontCharacter
{
    [FieldOffset(0x0000)] public int StartU;
    [FieldOffset(0x0004)] public int StartV;
    [FieldOffset(0x0008)] public int USize;
    [FieldOffset(0x000C)] public int VSize;
    [FieldOffset(0x0010)] public byte TextureIndex;
    [FieldOffset(0x0014)] public int VerticalOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FFontImportOptionsData
{
    [FieldOffset(0x0000)] public FString FontName;
    [FieldOffset(0x0010)] public float Height;
    [FieldOffset(0x0014)] public byte bEnableAntialiasing;
    [FieldOffset(0x0014)] public byte bEnableBold;
    [FieldOffset(0x0014)] public byte bEnableItalic;
    [FieldOffset(0x0014)] public byte bEnableUnderline;
    [FieldOffset(0x0014)] public byte bAlphaOnly;
    [FieldOffset(0x0018)] public EFontImportCharacterSet CharacterSet;
    [FieldOffset(0x0020)] public FString Chars;
    [FieldOffset(0x0030)] public FString UnicodeRange;
    [FieldOffset(0x0040)] public FString CharsFilePath;
    [FieldOffset(0x0050)] public FString CharsFileWildcard;
    [FieldOffset(0x0060)] public byte bCreatePrintableOnly;
    [FieldOffset(0x0060)] public byte bIncludeASCIIRange;
    [FieldOffset(0x0064)] public FLinearColor ForegroundColor;
    [FieldOffset(0x0074)] public byte bEnableDropShadow;
    [FieldOffset(0x0078)] public int TexturePageWidth;
    [FieldOffset(0x007C)] public int TexturePageMaxHeight;
    [FieldOffset(0x0080)] public int XPadding;
    [FieldOffset(0x0084)] public int YPadding;
    [FieldOffset(0x0088)] public int ExtendBoxTop;
    [FieldOffset(0x008C)] public int ExtendBoxBottom;
    [FieldOffset(0x0090)] public int ExtendBoxRight;
    [FieldOffset(0x0094)] public int ExtendBoxLeft;
    [FieldOffset(0x0098)] public byte bEnableLegacyMode;
    [FieldOffset(0x009C)] public int Kerning;
    [FieldOffset(0x00A0)] public byte bUseDistanceFieldAlpha;
    [FieldOffset(0x00A4)] public int DistanceFieldScaleFactor;
    [FieldOffset(0x00A8)] public float DistanceFieldScanRadiusScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UFont
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public EFontCacheType FontCacheType;
    [FieldOffset(0x0038)] public TArray<FFontCharacter> Characters;
    [FieldOffset(0x0048)] public TArray<IntPtr> Textures;
    [FieldOffset(0x0058)] public int IsRemapped;
    [FieldOffset(0x005C)] public float EmScale;
    [FieldOffset(0x0060)] public float Ascent;
    [FieldOffset(0x0064)] public float Descent;
    [FieldOffset(0x0068)] public float Leading;
    [FieldOffset(0x006C)] public int Kerning;
    [FieldOffset(0x0070)] public FFontImportOptionsData ImportOptions;
    [FieldOffset(0x0120)] public int NumCharacters;
    [FieldOffset(0x0128)] public TArray<int> MaxCharHeight;
    [FieldOffset(0x0138)] public float ScalingFactor;
    [FieldOffset(0x013C)] public int LegacyFontSize;
    [FieldOffset(0x0140)] public FName LegacyFontName;
    [FieldOffset(0x0148)] public FCompositeFont CompositeFont;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UFontFace
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FString SourceFilename;
    [FieldOffset(0x0040)] public EFontHinting Hinting;
    [FieldOffset(0x0041)] public EFontLoadingPolicy LoadingPolicy;
    [FieldOffset(0x0042)] public EFontLayoutMethod LayoutMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UFontImportOptions
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FFontImportOptionsData Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FForceFeedbackAttenuationSettings
{
    [FieldOffset(0x0000)] public FBaseAttenuationSettings baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UForceFeedbackAttenuation
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FForceFeedbackAttenuationSettings Attenuation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UForceFeedbackComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public UForceFeedbackEffect* ForceFeedbackEffect;
    [FieldOffset(0x0200)] public byte bAutoDestroy;
    [FieldOffset(0x0200)] public byte bStopWhenOwnerDestroyed;
    [FieldOffset(0x0200)] public byte bLooping;
    [FieldOffset(0x0200)] public byte bIgnoreTimeDilation;
    [FieldOffset(0x0200)] public byte bOverrideAttenuation;
    [FieldOffset(0x0204)] public float IntensityMultiplier;
    [FieldOffset(0x0208)] public UForceFeedbackAttenuation* AttenuationSettings;
    [FieldOffset(0x0210)] public FForceFeedbackAttenuationSettings AttenuationOverrides;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FForceFeedbackChannelDetails
{
    [FieldOffset(0x0000)] public byte bAffectsLeftLarge;
    [FieldOffset(0x0000)] public byte bAffectsLeftSmall;
    [FieldOffset(0x0000)] public byte bAffectsRightLarge;
    [FieldOffset(0x0000)] public byte bAffectsRightSmall;
    [FieldOffset(0x0008)] public FRuntimeFloatCurve Curve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UForceFeedbackEffect
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FForceFeedbackChannelDetails> ChannelDetails;
    [FieldOffset(0x0038)] public float Duration;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD70)] 
public unsafe struct UGameEngine
{
    [FieldOffset(0x0000)] public UEngine baseObj;
    [FieldOffset(0x0D20)] public float MaxDeltaTime;
    [FieldOffset(0x0D24)] public float ServerFlushLogInterval;
    [FieldOffset(0x0D28)] public UGameInstance* GameInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AGameNetworkManager
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public float BadPacketLossThreshold;
    [FieldOffset(0x0224)] public float SeverePacketLossThreshold;
    [FieldOffset(0x0228)] public int BadPingThreshold;
    [FieldOffset(0x022C)] public int SeverePingThreshold;
    [FieldOffset(0x0230)] public int AdjustedNetSpeed;
    [FieldOffset(0x0234)] public float LastNetSpeedUpdateTime;
    [FieldOffset(0x0238)] public int TotalNetBandwidth;
    [FieldOffset(0x023C)] public int MinDynamicBandwidth;
    [FieldOffset(0x0240)] public int MaxDynamicBandwidth;
    [FieldOffset(0x0244)] public byte bIsStandbyCheckingEnabled;
    [FieldOffset(0x0244)] public byte bHasStandbyCheatTriggered;
    [FieldOffset(0x0248)] public float StandbyRxCheatTime;
    [FieldOffset(0x024C)] public float StandbyTxCheatTime;
    [FieldOffset(0x0250)] public float PercentMissingForRxStandby;
    [FieldOffset(0x0254)] public float PercentMissingForTxStandby;
    [FieldOffset(0x0258)] public float PercentForBadPing;
    [FieldOffset(0x025C)] public float JoinInProgressStandbyWaitTime;
    [FieldOffset(0x0260)] public float MoveRepSize;
    [FieldOffset(0x0264)] public float MAXPOSITIONERRORSQUARED;
    [FieldOffset(0x0268)] public float MAXNEARZEROVELOCITYSQUARED;
    [FieldOffset(0x026C)] public float CLIENTADJUSTUPDATECOST;
    [FieldOffset(0x0270)] public float MAXCLIENTUPDATEINTERVAL;
    [FieldOffset(0x0274)] public float MaxClientForcedUpdateDuration;
    [FieldOffset(0x0278)] public float ServerForcedUpdateHitchThreshold;
    [FieldOffset(0x027C)] public float ServerForcedUpdateHitchCooldown;
    [FieldOffset(0x0280)] public float MaxMoveDeltaTime;
    [FieldOffset(0x0284)] public float MaxClientSmoothingDeltaTime;
    [FieldOffset(0x0288)] public float ClientNetSendMoveDeltaTime;
    [FieldOffset(0x028C)] public float ClientNetSendMoveDeltaTimeThrottled;
    [FieldOffset(0x0290)] public float ClientNetSendMoveDeltaTimeStationary;
    [FieldOffset(0x0294)] public int ClientNetSendMoveThrottleAtNetSpeed;
    [FieldOffset(0x0298)] public int ClientNetSendMoveThrottleOverPlayerCount;
    [FieldOffset(0x029C)] public bool ClientAuthorativePosition;
    [FieldOffset(0x02A0)] public float ClientErrorUpdateRateLimit;
    [FieldOffset(0x02A4)] public float ClientNetCamUpdateDeltaTime;
    [FieldOffset(0x02A8)] public float ClientNetCamUpdatePositionLimit;
    [FieldOffset(0x02AC)] public bool bMovementTimeDiscrepancyDetection;
    [FieldOffset(0x02AD)] public bool bMovementTimeDiscrepancyResolution;
    [FieldOffset(0x02B0)] public float MovementTimeDiscrepancyMaxTimeMargin;
    [FieldOffset(0x02B4)] public float MovementTimeDiscrepancyMinTimeMargin;
    [FieldOffset(0x02B8)] public float MovementTimeDiscrepancyResolutionRate;
    [FieldOffset(0x02BC)] public float MovementTimeDiscrepancyDriftAllowance;
    [FieldOffset(0x02C0)] public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution;
    [FieldOffset(0x02C1)] public bool bUseDistanceBasedRelevancy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FPredictProjectilePathParams
{
    [FieldOffset(0x0000)] public FVector StartLocation;
    [FieldOffset(0x000C)] public FVector LaunchVelocity;
    [FieldOffset(0x0018)] public bool bTraceWithCollision;
    [FieldOffset(0x001C)] public float ProjectileRadius;
    [FieldOffset(0x0020)] public float MaxSimTime;
    [FieldOffset(0x0024)] public bool bTraceWithChannel;
    [FieldOffset(0x0025)] public ECollisionChannel TraceChannel;
    [FieldOffset(0x0028)] public TArray<EObjectTypeQuery> ObjectTypes;
    [FieldOffset(0x0038)] public TArray<IntPtr> ActorsToIgnore;
    [FieldOffset(0x0048)] public float SimFrequency;
    [FieldOffset(0x004C)] public float OverrideGravityZ;
    [FieldOffset(0x0050)] public EDrawDebugTrace DrawDebugType;
    [FieldOffset(0x0054)] public float DrawDebugTime;
    [FieldOffset(0x0058)] public bool bTraceComplex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FPredictProjectilePathPointData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Velocity;
    [FieldOffset(0x0018)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FPredictProjectilePathResult
{
    [FieldOffset(0x0000)] public TArray<FPredictProjectilePathPointData> PathData;
    [FieldOffset(0x0010)] public FPredictProjectilePathPointData LastTraceDestination;
    [FieldOffset(0x002C)] public FHitResult HitResult;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UGameplayStatics
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AGameSession
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public int MaxSpectators;
    [FieldOffset(0x0224)] public int MaxPlayers;
    [FieldOffset(0x0228)] public int MaxPartySize;
    [FieldOffset(0x022C)] public byte MaxSplitscreensPerConnection;
    [FieldOffset(0x022D)] public bool bRequiresPushToTalk;
    [FieldOffset(0x0230)] public FName SessionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UGameUserSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bUseVSync;
    [FieldOffset(0x0029)] public bool bUseDynamicResolution;
    [FieldOffset(0x0080)] public uint ResolutionSizeX;
    [FieldOffset(0x0084)] public uint ResolutionSizeY;
    [FieldOffset(0x0088)] public uint LastUserConfirmedResolutionSizeX;
    [FieldOffset(0x008C)] public uint LastUserConfirmedResolutionSizeY;
    [FieldOffset(0x0090)] public int WindowPosX;
    [FieldOffset(0x0094)] public int WindowPosY;
    [FieldOffset(0x0098)] public int FullscreenMode;
    [FieldOffset(0x009C)] public int LastConfirmedFullscreenMode;
    [FieldOffset(0x00A0)] public int PreferredFullscreenMode;
    [FieldOffset(0x00A4)] public uint Version;
    [FieldOffset(0x00A8)] public int AudioQualityLevel;
    [FieldOffset(0x00AC)] public int LastConfirmedAudioQualityLevel;
    [FieldOffset(0x00B0)] public float FrameRateLimit;
    [FieldOffset(0x00B8)] public int DesiredScreenWidth;
    [FieldOffset(0x00BC)] public bool bUseDesiredScreenHeight;
    [FieldOffset(0x00C0)] public int DesiredScreenHeight;
    [FieldOffset(0x00C4)] public int LastUserConfirmedDesiredScreenWidth;
    [FieldOffset(0x00C8)] public int LastUserConfirmedDesiredScreenHeight;
    [FieldOffset(0x00CC)] public float LastRecommendedScreenWidth;
    [FieldOffset(0x00D0)] public float LastRecommendedScreenHeight;
    [FieldOffset(0x00D4)] public float LastCPUBenchmarkResult;
    [FieldOffset(0x00D8)] public float LastGPUBenchmarkResult;
    [FieldOffset(0x00E0)] public TArray<float> LastCPUBenchmarkSteps;
    [FieldOffset(0x00F0)] public TArray<float> LastGPUBenchmarkSteps;
    [FieldOffset(0x0100)] public float LastGPUBenchmarkMultiplier;
    [FieldOffset(0x0104)] public bool bUseHDRDisplayOutput;
    [FieldOffset(0x0108)] public int HDRDisplayOutputNits;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ASpotLight
{
    [FieldOffset(0x0000)] public ALight baseObj;
    [FieldOffset(0x0230)] public USpotLightComponent* SpotLightComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AGeneratedMeshAreaLight
{
    [FieldOffset(0x0000)] public ASpotLight baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHapticFeedbackEffect_Base
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHapticFeedbackEffect_Buffer
{
    [FieldOffset(0x0000)] public UHapticFeedbackEffect_Base baseObj;
    [FieldOffset(0x0028)] public TArray<byte> Amplitudes;
    [FieldOffset(0x0038)] public int SampleRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct FHapticFeedbackDetails_Curve
{
    [FieldOffset(0x0000)] public FRuntimeFloatCurve Frequency;
    [FieldOffset(0x0088)] public FRuntimeFloatCurve Amplitude;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UHapticFeedbackEffect_Curve
{
    [FieldOffset(0x0000)] public UHapticFeedbackEffect_Base baseObj;
    [FieldOffset(0x0028)] public FHapticFeedbackDetails_Curve HapticDetails;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UHapticFeedbackEffect_SoundWave
{
    [FieldOffset(0x0000)] public UHapticFeedbackEffect_Base baseObj;
    [FieldOffset(0x0028)] public USoundWave* SoundWave;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHealthSnapshotBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UHLODEngineSubsystem
{
    [FieldOffset(0x0000)] public UEngineSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FHLODProxyMesh
{
    [FieldOffset(0x0000)] public TLazyObjectPtr<ALODActor> LODActor;
    [FieldOffset(0x0020)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0028)] public FName Key;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UHLODProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FHLODProxyMesh> ProxyMeshes;
    [FieldOffset(0x0038)] public TMap<IntPtr, FHLODProxyMesh> HLODActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHLODProxyDesc
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FImportanceTexture
{
    [FieldOffset(0x0000)] public FIntPoint Size;
    [FieldOffset(0x0008)] public int NumMips;
    [FieldOffset(0x0010)] public TArray<float> MarginalCDF;
    [FieldOffset(0x0020)] public TArray<float> ConditionalCDF;
    [FieldOffset(0x0030)] public TArray<FColor> TextureData;
    [FieldOffset(0x0040)] public TWeakObjectPtr<UTexture2D> Texture;
    [FieldOffset(0x0048)] public EImportanceWeight Weighting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UImportanceSamplingLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IImportantToggleSettingInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInGameAdManager
{
    [FieldOffset(0x0000)] public UPlatformInterfaceBase baseObj;
    [FieldOffset(0x0038)] public byte bShouldPauseWhileAdOpen;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FComponentKey
{
    [FieldOffset(0x0000)] public UClass* OwnerClass;
    [FieldOffset(0x0008)] public FName SCSVariableName;
    [FieldOffset(0x0010)] public FGuid AssociatedGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FComponentOverrideRecord
{
    [FieldOffset(0x0000)] public UClass* ComponentClass;
    [FieldOffset(0x0008)] public UActorComponent* ComponentTemplate;
    [FieldOffset(0x0010)] public FComponentKey ComponentKey;
    [FieldOffset(0x0030)] public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UInheritableComponentHandler
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FComponentOverrideRecord> Records;
    [FieldOffset(0x0038)] public TArray<IntPtr> UnnecessaryComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInputDelegateBinding
{
    [FieldOffset(0x0000)] public UDynamicBlueprintBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FBlueprintInputDelegateBinding
{
    [FieldOffset(0x0000)] public byte bConsumeInput;
    [FieldOffset(0x0000)] public byte bExecuteWhenPaused;
    [FieldOffset(0x0000)] public byte bOverrideParentBinding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBlueprintInputActionDelegateBinding
{
    [FieldOffset(0x0000)] public FBlueprintInputDelegateBinding baseObj;
    [FieldOffset(0x0004)] public FName InputActionName;
    [FieldOffset(0x000C)] public EInputEvent InputKeyEvent;
    [FieldOffset(0x0010)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputActionDelegateBinding
{
    [FieldOffset(0x0000)] public UInputDelegateBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintInputActionDelegateBinding> InputActionDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FBlueprintInputAxisDelegateBinding
{
    [FieldOffset(0x0000)] public FBlueprintInputDelegateBinding baseObj;
    [FieldOffset(0x0004)] public FName InputAxisName;
    [FieldOffset(0x000C)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputAxisDelegateBinding
{
    [FieldOffset(0x0000)] public UInputDelegateBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintInputAxisDelegateBinding> InputAxisDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBlueprintInputAxisKeyDelegateBinding
{
    [FieldOffset(0x0000)] public FBlueprintInputDelegateBinding baseObj;
    [FieldOffset(0x0008)] public FKey AxisKey;
    [FieldOffset(0x0020)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputAxisKeyDelegateBinding
{
    [FieldOffset(0x0000)] public UInputDelegateBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintInputAxisKeyDelegateBinding> InputAxisKeyDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FCachedKeyToActionInfo
{
    [FieldOffset(0x0000)] public UPlayerInput* PlayerInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UInputComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x0120)] public TArray<FCachedKeyToActionInfo> CachedKeyToActionInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBlueprintInputKeyDelegateBinding
{
    [FieldOffset(0x0000)] public FBlueprintInputDelegateBinding baseObj;
    [FieldOffset(0x0008)] public FInputChord InputChord;
    [FieldOffset(0x0028)] public EInputEvent InputKeyEvent;
    [FieldOffset(0x002C)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputKeyDelegateBinding
{
    [FieldOffset(0x0000)] public UInputDelegateBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintInputKeyDelegateBinding> InputKeyDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FInputAxisProperties
{
    [FieldOffset(0x0000)] public float DeadZone;
    [FieldOffset(0x0004)] public float Sensitivity;
    [FieldOffset(0x0008)] public float Exponent;
    [FieldOffset(0x000C)] public byte bInvert;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInputAxisConfigEntry
{
    [FieldOffset(0x0000)] public FName AxisKeyName;
    [FieldOffset(0x0008)] public FInputAxisProperties AxisProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FInputActionKeyMapping
{
    [FieldOffset(0x0000)] public FName ActionName;
    [FieldOffset(0x0008)] public byte bShift;
    [FieldOffset(0x0008)] public byte bCtrl;
    [FieldOffset(0x0008)] public byte bAlt;
    [FieldOffset(0x0008)] public byte bCmd;
    [FieldOffset(0x0010)] public FKey Key;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FInputAxisKeyMapping
{
    [FieldOffset(0x0000)] public FName AxisName;
    [FieldOffset(0x0008)] public float Scale;
    [FieldOffset(0x0010)] public FKey Key;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FInputActionSpeechMapping
{
    [FieldOffset(0x0000)] public FName ActionName;
    [FieldOffset(0x0008)] public FName SpeechKeyword;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UInputSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FInputAxisConfigEntry> AxisConfig;
    [FieldOffset(0x0038)] public byte bAltEnterTogglesFullscreen;
    [FieldOffset(0x0038)] public byte bF11TogglesFullscreen;
    [FieldOffset(0x0038)] public byte bUseMouseForTouch;
    [FieldOffset(0x0038)] public byte bEnableMouseSmoothing;
    [FieldOffset(0x0038)] public byte bEnableFOVScaling;
    [FieldOffset(0x0038)] public byte bCaptureMouseOnLaunch;
    [FieldOffset(0x0038)] public byte bDefaultViewportMouseLock;
    [FieldOffset(0x0038)] public byte bAlwaysShowTouchInterface;
    [FieldOffset(0x0039)] public byte bShowConsoleOnFourFingerTap;
    [FieldOffset(0x0039)] public byte bEnableGestureRecognizer;
    [FieldOffset(0x003A)] public bool bUseAutocorrect;
    [FieldOffset(0x0040)] public TArray<FString> ExcludedAutocorrectOS;
    [FieldOffset(0x0050)] public TArray<FString> ExcludedAutocorrectCultures;
    [FieldOffset(0x0060)] public TArray<FString> ExcludedAutocorrectDeviceModels;
    [FieldOffset(0x0070)] public EMouseCaptureMode DefaultViewportMouseCaptureMode;
    [FieldOffset(0x0071)] public EMouseLockMode DefaultViewportMouseLockMode;
    [FieldOffset(0x0074)] public float FOVScale;
    [FieldOffset(0x0078)] public float DoubleClickTime;
    [FieldOffset(0x0080)] public TArray<FInputActionKeyMapping> ActionMappings;
    [FieldOffset(0x0090)] public TArray<FInputAxisKeyMapping> AxisMappings;
    [FieldOffset(0x00A0)] public TArray<FInputActionSpeechMapping> SpeechMappings;
    [FieldOffset(0x00B0)] public TSoftClassPtr<UPlayerInput> DefaultPlayerInputClass;
    [FieldOffset(0x00D8)] public TSoftClassPtr<UInputComponent> DefaultInputComponentClass;
    [FieldOffset(0x0100)] public FSoftObjectPath DefaultTouchInterface;
    [FieldOffset(0x0118)] public FKey ConsoleKey;
    [FieldOffset(0x0130)] public TArray<FKey> ConsoleKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBlueprintInputTouchDelegateBinding
{
    [FieldOffset(0x0000)] public FBlueprintInputDelegateBinding baseObj;
    [FieldOffset(0x0004)] public EInputEvent InputKeyEvent;
    [FieldOffset(0x0008)] public FName FunctionNameToBind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputTouchDelegateBinding
{
    [FieldOffset(0x0000)] public UInputDelegateBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintInputTouchDelegateBinding> InputTouchDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputVectorAxisDelegateBinding
{
    [FieldOffset(0x0000)] public UInputAxisKeyDelegateBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface_ActorSubobject
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface_AssetUserData
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBoneReferenceSkeletonProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface_CollisionDataProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface_PostProcessVolume
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInterface_PreviewMeshProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCurveEdEntry
{
    [FieldOffset(0x0000)] public UObject* CurveObject;
    [FieldOffset(0x0008)] public FColor CurveColor;
    [FieldOffset(0x0010)] public FString CurveName;
    [FieldOffset(0x0020)] public int bHideCurve;
    [FieldOffset(0x0024)] public int bColorCurve;
    [FieldOffset(0x0028)] public int bFloatingPointColorCurve;
    [FieldOffset(0x002C)] public int bClamp;
    [FieldOffset(0x0030)] public float ClampLow;
    [FieldOffset(0x0034)] public float ClampHigh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCurveEdTab
{
    [FieldOffset(0x0000)] public FString TabName;
    [FieldOffset(0x0010)] public TArray<FCurveEdEntry> Curves;
    [FieldOffset(0x0020)] public float ViewStartInput;
    [FieldOffset(0x0024)] public float ViewEndInput;
    [FieldOffset(0x0028)] public float ViewStartOutput;
    [FieldOffset(0x002C)] public float ViewEndOutput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UInterpCurveEdSetup
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FCurveEdTab> Tabs;
    [FieldOffset(0x0038)] public int ActiveTab;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UInterpData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float InterpLength;
    [FieldOffset(0x002C)] public float PathBuildTime;
    [FieldOffset(0x0030)] public TArray<IntPtr> InterpGroups;
    [FieldOffset(0x0040)] public UInterpCurveEdSetup* CurveEdSetup;
    [FieldOffset(0x0048)] public float EdSectionStart;
    [FieldOffset(0x004C)] public float EdSectionEnd;
    [FieldOffset(0x0050)] public byte bShouldBakeAndPrune;
    [FieldOffset(0x0058)] public UInterpGroupDirector* CachedDirectorGroup;
    [FieldOffset(0x0060)] public TArray<FName> AllEventNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInterpFilter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString Caption;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInterpFilter_Classes
{
    [FieldOffset(0x0000)] public UInterpFilter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInterpFilter_Custom
{
    [FieldOffset(0x0000)] public UInterpFilter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UInterpGroup
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> InterpTracks;
    [FieldOffset(0x0040)] public FName GroupName;
    [FieldOffset(0x0048)] public FColor GroupColor;
    [FieldOffset(0x004C)] public byte bCollapsed;
    [FieldOffset(0x004C)] public byte bVisible;
    [FieldOffset(0x004C)] public byte bIsFolder;
    [FieldOffset(0x004C)] public byte bIsParented;
    [FieldOffset(0x004C)] public byte bIsSelected;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInterpGroupCamera
{
    [FieldOffset(0x0000)] public UInterpGroup baseObj;
    [FieldOffset(0x0050)] public UCameraAnim* CameraAnimInst;
    [FieldOffset(0x0058)] public float CompressTolerance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UInterpGroupDirector
{
    [FieldOffset(0x0000)] public UInterpGroup baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UInterpGroupInst
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UInterpGroup* Group;
    [FieldOffset(0x0030)] public AActor* GroupActor;
    [FieldOffset(0x0038)] public TArray<IntPtr> TrackInst;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UInterpGroupInstCamera
{
    [FieldOffset(0x0000)] public UInterpGroupInst baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UInterpGroupInstDirector
{
    [FieldOffset(0x0000)] public UInterpGroupInst baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FInterpControlPoint
{
    [FieldOffset(0x0000)] public FVector PositionControlPoint;
    [FieldOffset(0x000C)] public bool bPositionIsRelative;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UInterpToMovementComponent
{
    [FieldOffset(0x0000)] public UMovementComponent baseObj;
    [FieldOffset(0x00F0)] public float Duration;
    [FieldOffset(0x00F4)] public byte bPauseOnImpact;
    [FieldOffset(0x00F8)] public bool bSweep;
    [FieldOffset(0x00F9)] public ETeleportType TeleportType;
    [FieldOffset(0x00FA)] public EInterpToBehaviourType BehaviourType;
    [FieldOffset(0x00FB)] public bool bCheckIfStillInWorld;
    [FieldOffset(0x00FC)] public byte bForceSubStepping;
    [FieldOffset(0x0150)] public float MaxSimulationTimeStep;
    [FieldOffset(0x0154)] public int MaxSimulationIterations;
    [FieldOffset(0x0158)] public TArray<FInterpControlPoint> ControlPoints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UInterpTrack
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> SubTracks;
    [FieldOffset(0x0048)] public TSubclassOf<UInterpTrackInst> TrackInstClass;
    [FieldOffset(0x0050)] public ETrackActiveCondition ActiveCondition;
    [FieldOffset(0x0058)] public FString TrackTitle;
    [FieldOffset(0x0068)] public byte bOnePerGroup;
    [FieldOffset(0x0068)] public byte bDirGroupOnly;
    [FieldOffset(0x0068)] public byte bDisableTrack;
    [FieldOffset(0x0068)] public byte bIsSelected;
    [FieldOffset(0x0068)] public byte bIsAnimControlTrack;
    [FieldOffset(0x0068)] public byte bSubTrackOnly;
    [FieldOffset(0x0068)] public byte bVisible;
    [FieldOffset(0x0068)] public byte bIsRecording;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackFloatBase
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public FInterpCurveFloat FloatTrack;
    [FieldOffset(0x0088)] public float CurveTension;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimControlTrackKey
{
    [FieldOffset(0x0000)] public float StartTime;
    [FieldOffset(0x0008)] public UAnimSequence* AnimSeq;
    [FieldOffset(0x0010)] public float AnimStartOffset;
    [FieldOffset(0x0014)] public float AnimEndOffset;
    [FieldOffset(0x0018)] public float AnimPlayRate;
    [FieldOffset(0x001C)] public byte bLooping;
    [FieldOffset(0x001C)] public byte bReverse;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UInterpTrackAnimControl
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public FName SlotName;
    [FieldOffset(0x0098)] public TArray<FAnimControlTrackKey> AnimSeqs;
    [FieldOffset(0x00A8)] public byte bSkipAnimNotifiers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackVectorBase
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public FInterpCurveVector VectorTrack;
    [FieldOffset(0x0088)] public float CurveTension;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackAudioMaster
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FBoolTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public byte Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UInterpTrackBoolProp
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FBoolTrackKey> BoolTrack;
    [FieldOffset(0x0080)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInterpTrackColorProp
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
    [FieldOffset(0x0090)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackColorScale
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDirectorTrackCut
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public float TransitionTime;
    [FieldOffset(0x0008)] public FName TargetCamGroup;
    [FieldOffset(0x0010)] public int ShotNumber;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UInterpTrackDirector
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FDirectorTrackCut> CutTrack;
    [FieldOffset(0x0080)] public byte bSimulateCameraCutsOnClients;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FEventTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public FName EventName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UInterpTrackEvent
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FEventTrackKey> EventTrack;
    [FieldOffset(0x0080)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenJumpingForwards;
    [FieldOffset(0x0080)] public byte bUseCustomEventName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInterpTrackFade
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public byte bPersistFade;
    [FieldOffset(0x0090)] public byte bFadeAudio;
    [FieldOffset(0x0094)] public FLinearColor FadeColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UInterpTrackFloatAnimBPParam
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public UClass* AnimBlueprintClass;
    [FieldOffset(0x0098)] public TSubclassOf<UAnimInstance> AnimClass;
    [FieldOffset(0x00A0)] public FName ParamName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInterpTrackFloatMaterialParam
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> TargetMaterials;
    [FieldOffset(0x00A0)] public FName ParamName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInterpTrackFloatParticleParam
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public FName ParamName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInterpTrackFloatProp
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInterpTrackInst
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstAnimControl
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float LastUpdatePosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInterpTrackInstAudioMaster
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UInterpTrackInstProperty
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public TFieldPath<FProperty> InterpProperty;
    [FieldOffset(0x0048)] public UObject* PropertyOuterObjectInst;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UInterpTrackInstBoolProp
{
    [FieldOffset(0x0000)] public UInterpTrackInstProperty baseObj;
    [FieldOffset(0x0060)] public bool ResetBool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInterpTrackInstColorProp
{
    [FieldOffset(0x0000)] public UInterpTrackInstProperty baseObj;
    [FieldOffset(0x0058)] public FColor ResetColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInterpTrackInstColorScale
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstDirector
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public AActor* OldViewTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstEvent
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float LastUpdatePosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInterpTrackInstFade
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UInterpTrackInstFloatAnimBPParam
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public UAnimInstance* AnimScriptInstance;
    [FieldOffset(0x0030)] public float ResetFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPrimitiveMaterialRef
{
    [FieldOffset(0x0000)] public UPrimitiveComponent* Primitive;
    [FieldOffset(0x0008)] public UDecalComponent* Decal;
    [FieldOffset(0x0010)] public int ElementIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInterpTrackInstFloatMaterialParam
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> MaterialInstances;
    [FieldOffset(0x0038)] public TArray<float> ResetFloats;
    [FieldOffset(0x0048)] public TArray<FPrimitiveMaterialRef> PrimitiveMaterialRefs;
    [FieldOffset(0x0058)] public UInterpTrackFloatMaterialParam* InstancedTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstFloatParticleParam
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float ResetFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInterpTrackInstFloatProp
{
    [FieldOffset(0x0000)] public UInterpTrackInstProperty baseObj;
    [FieldOffset(0x0058)] public float ResetFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UInterpTrackInstLinearColorProp
{
    [FieldOffset(0x0000)] public UInterpTrackInstProperty baseObj;
    [FieldOffset(0x0058)] public FLinearColor ResetColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UInterpTrackInstMove
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public FVector ResetLocation;
    [FieldOffset(0x0034)] public FRotator ResetRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstParticleReplay
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float LastUpdatePosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstSlomo
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float OldTimeDilation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInterpTrackInstSound
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public float LastUpdatePosition;
    [FieldOffset(0x0030)] public UAudioComponent* PlayAudioComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInterpTrackInstToggle
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public ETrackToggleAction Action;
    [FieldOffset(0x002C)] public float LastUpdatePosition;
    [FieldOffset(0x0030)] public byte bSavedActiveState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInterpTrackInstVectorMaterialParam
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> MaterialInstances;
    [FieldOffset(0x0038)] public TArray<FVector> ResetVectors;
    [FieldOffset(0x0048)] public TArray<FPrimitiveMaterialRef> PrimitiveMaterialRefs;
    [FieldOffset(0x0058)] public UInterpTrackVectorMaterialParam* InstancedTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UInterpTrackInstVectorProp
{
    [FieldOffset(0x0000)] public UInterpTrackInstProperty baseObj;
    [FieldOffset(0x0058)] public FVector ResetVector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInterpTrackInstVisibility
{
    [FieldOffset(0x0000)] public UInterpTrackInst baseObj;
    [FieldOffset(0x0028)] public EVisibilityTrackAction Action;
    [FieldOffset(0x002C)] public float LastUpdatePosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackLinearColorBase
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public FInterpCurveLinearColor LinearColorTrack;
    [FieldOffset(0x0088)] public float CurveTension;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInterpTrackLinearColorProp
{
    [FieldOffset(0x0000)] public UInterpTrackLinearColorBase baseObj;
    [FieldOffset(0x0090)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FInterpLookupPoint
{
    [FieldOffset(0x0000)] public FName GroupName;
    [FieldOffset(0x0008)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FInterpLookupTrack
{
    [FieldOffset(0x0000)] public TArray<FInterpLookupPoint> Points;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UInterpTrackMove
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public FInterpCurveVector PosTrack;
    [FieldOffset(0x0088)] public FInterpCurveVector EulerTrack;
    [FieldOffset(0x00A0)] public FInterpLookupTrack LookupTrack;
    [FieldOffset(0x00B0)] public FName LookAtGroupName;
    [FieldOffset(0x00B8)] public float LinCurveTension;
    [FieldOffset(0x00BC)] public float AngCurveTension;
    [FieldOffset(0x00C0)] public byte bUseQuatInterpolation;
    [FieldOffset(0x00C0)] public byte bShowArrowAtKeys;
    [FieldOffset(0x00C0)] public byte bDisableMovement;
    [FieldOffset(0x00C0)] public byte bShowTranslationOnCurveEd;
    [FieldOffset(0x00C0)] public byte bShowRotationOnCurveEd;
    [FieldOffset(0x00C0)] public byte bHide3DTrack;
    [FieldOffset(0x00C4)] public EInterpTrackMoveRotMode RotMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInterpTrackMoveAxis
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
    [FieldOffset(0x0090)] public EInterpMoveAxis MoveAxis;
    [FieldOffset(0x0098)] public FInterpLookupTrack LookupTrack;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FParticleReplayTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public float Duration;
    [FieldOffset(0x0008)] public int ClipIDNumber;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UInterpTrackParticleReplay
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FParticleReplayTrackKey> TrackKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInterpTrackSlomo
{
    [FieldOffset(0x0000)] public UInterpTrackFloatBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSoundTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public float Volume;
    [FieldOffset(0x0008)] public float Pitch;
    [FieldOffset(0x0010)] public USoundBase* Sound;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInterpTrackSound
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
    [FieldOffset(0x0090)] public TArray<FSoundTrackKey> Sounds;
    [FieldOffset(0x00A0)] public byte bPlayOnReverse;
    [FieldOffset(0x00A0)] public byte bContinueSoundOnMatineeEnd;
    [FieldOffset(0x00A0)] public byte bSuppressSubtitles;
    [FieldOffset(0x00A0)] public byte bTreatAsDialogue;
    [FieldOffset(0x00A0)] public byte bAttach;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FToggleTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public ETrackToggleAction ToggleAction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UInterpTrackToggle
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FToggleTrackKey> ToggleTrack;
    [FieldOffset(0x0080)] public byte bActivateSystemEachUpdate;
    [FieldOffset(0x0080)] public byte bActivateWithJustAttachedFlag;
    [FieldOffset(0x0080)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenJumpingForwards;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInterpTrackVectorMaterialParam
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> TargetMaterials;
    [FieldOffset(0x00A0)] public FName ParamName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInterpTrackVectorProp
{
    [FieldOffset(0x0000)] public UInterpTrackVectorBase baseObj;
    [FieldOffset(0x0090)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVisibilityTrackKey
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public EVisibilityTrackAction Action;
    [FieldOffset(0x0005)] public EVisibilityTrackCondition ActiveCondition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UInterpTrackVisibility
{
    [FieldOffset(0x0000)] public UInterpTrack baseObj;
    [FieldOffset(0x0070)] public TArray<FVisibilityTrackKey> VisibilityTrack;
    [FieldOffset(0x0080)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x0080)] public byte bFireEventsWhenJumpingForwards;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UIntSerialization
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ushort UnsignedInt16Variable;
    [FieldOffset(0x002C)] public uint UnsignedInt32Variable;
    [FieldOffset(0x0030)] public ulong UnsignedInt64Variable;
    [FieldOffset(0x0038)] public sbyte SignedInt8Variable;
    [FieldOffset(0x003A)] public short SignedInt16Variable;
    [FieldOffset(0x0040)] public long SignedInt64Variable;
    [FieldOffset(0x0048)] public byte UnsignedInt8Variable;
    [FieldOffset(0x004C)] public int SignedInt32Variable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct AKillZVolume
{
    [FieldOffset(0x0000)] public APhysicsVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetArrayLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetGuidLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetInputLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetInternationalizationLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetMaterialLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FVectorSpringState
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFloatSpringState
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetMathLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetNodeHelperLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDrawToRenderTargetContext
{
    [FieldOffset(0x0000)] public UTextureRenderTarget2D* RenderTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetRenderingLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetStringLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetStringTableLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FUserActivity
{
    [FieldOffset(0x0000)] public FString ActionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FGenericStruct
{
    [FieldOffset(0x0000)] public int Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCollisionProfileName
{
    [FieldOffset(0x0000)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FTimerHandle
{
    [FieldOffset(0x0000)] public ulong Handle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDebugFloatHistory
{
    [FieldOffset(0x0000)] public TArray<float> Samples;
    [FieldOffset(0x0010)] public float MaxSamples;
    [FieldOffset(0x0014)] public float MinValue;
    [FieldOffset(0x0018)] public float MaxValue;
    [FieldOffset(0x001C)] public bool bAutoAdjustMinMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetSystemLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FFormatArgumentData
{
    [FieldOffset(0x0000)] public FString ArgumentName;
    [FieldOffset(0x0010)] public EFormatArgumentType ArgumentValueType;
    [FieldOffset(0x0018)] public FText ArgumentValue;
    [FieldOffset(0x0030)] public int ArgumentValueInt;
    [FieldOffset(0x0034)] public float ArgumentValueFloat;
    [FieldOffset(0x0038)] public ETextGender ArgumentValueGender;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKismetTextLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLayerActorStats
{
    [FieldOffset(0x0000)] public UClass* Type;
    [FieldOffset(0x0008)] public int Total;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct ULayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName LayerName;
    [FieldOffset(0x0030)] public byte bIsVisible;
    [FieldOffset(0x0038)] public TArray<FLayerActorStats> ActorStats;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ILevelPartitionInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FReplicatedStaticActorDestructionInfo
{
    [FieldOffset(0x0030)] public UClass* ObjClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ULevel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x00B8)] public UWorld* OwningWorld;
    [FieldOffset(0x00C0)] public UModel* Model;
    [FieldOffset(0x00C8)] public TArray<IntPtr> ModelComponents;
    [FieldOffset(0x00D8)] public ULevelActorContainer* ActorCluster;
    [FieldOffset(0x00E0)] public int NumTextureStreamingUnbuiltComponents;
    [FieldOffset(0x00E4)] public int NumTextureStreamingDirtyResources;
    [FieldOffset(0x00E8)] public ALevelScriptActor* LevelScriptActor;
    [FieldOffset(0x00F0)] public ANavigationObjectBase* NavListStart;
    [FieldOffset(0x00F8)] public ANavigationObjectBase* NavListEnd;
    [FieldOffset(0x0100)] public TArray<IntPtr> NavDataChunks;
    [FieldOffset(0x0110)] public float LightmapTotalSize;
    [FieldOffset(0x0114)] public float ShadowmapTotalSize;
    [FieldOffset(0x0118)] public TArray<FVector> StaticNavigableGeometry;
    [FieldOffset(0x0128)] public TArray<FGuid> StreamingTextureGuids;
    [FieldOffset(0x01D0)] public FGuid LevelBuildDataId;
    [FieldOffset(0x01E0)] public UMapBuildDataRegistry* MapBuildData;
    [FieldOffset(0x01E8)] public FIntVector LightBuildLevelOffset;
    [FieldOffset(0x01F4)] public byte bIsLightingScenario;
    [FieldOffset(0x01F4)] public byte bTextureStreamingRotationChanged;
    [FieldOffset(0x01F4)] public byte bStaticComponentsRegisteredInStreamingManager;
    [FieldOffset(0x01F4)] public byte bIsVisible;
    [FieldOffset(0x0258)] public AWorldSettings* WorldSettings;
    [FieldOffset(0x0268)] public TArray<IntPtr> AssetUserData;
    [FieldOffset(0x0288)] public TArray<FReplicatedStaticActorDestructionInfo> DestroyedReplicatedStaticActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULevelActorContainer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Actors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ALevelBounds
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBoxComponent* BoxComponent;
    [FieldOffset(0x0228)] public bool bAutoUpdateBounds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ALevelScriptActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public byte bInputEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct ULevelScriptBlueprint
{
    [FieldOffset(0x0000)] public UBlueprint baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStreamingLevelsToConsider
{
    [FieldOffset(0x0000)] public TArray<IntPtr> StreamingLevels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FLevelCollection
{
    [FieldOffset(0x0008)] public AGameStateBase* GameState;
    [FieldOffset(0x0010)] public UNetDriver* NetDriver;
    [FieldOffset(0x0018)] public UDemoNetDriver* DemoNetDriver;
    [FieldOffset(0x0020)] public ULevel* PersistentLevel;
    [FieldOffset(0x0028)] public TSet<IntPtr> Levels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPSCPoolElem
{
    [FieldOffset(0x0000)] public UParticleSystemComponent* PSC;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPSCPool
{
    [FieldOffset(0x0000)] public TArray<FPSCPoolElem> FreeElements;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FWorldPSCPool
{
    [FieldOffset(0x0000)] public TMap<IntPtr, FPSCPool> WorldParticleSystemPools;
}

[StructLayout(LayoutKind.Explicit, Size = 0x798)] 
public unsafe struct UWorld
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public ULevel* PersistentLevel;
    [FieldOffset(0x0038)] public UNetDriver* NetDriver;
    [FieldOffset(0x0040)] public ULineBatchComponent* LineBatcher;
    [FieldOffset(0x0048)] public ULineBatchComponent* PersistentLineBatcher;
    [FieldOffset(0x0050)] public ULineBatchComponent* ForegroundLineBatcher;
    [FieldOffset(0x0058)] public AGameNetworkManager* NetworkManager;
    [FieldOffset(0x0060)] public UPhysicsCollisionHandler* PhysicsCollisionHandler;
    [FieldOffset(0x0068)] public TArray<IntPtr> ExtraReferencedObjects;
    [FieldOffset(0x0078)] public TArray<IntPtr> PerModuleDataObjects;
    [FieldOffset(0x0088)] public TArray<IntPtr> StreamingLevels;
    [FieldOffset(0x0098)] public FStreamingLevelsToConsider StreamingLevelsToConsider;
    [FieldOffset(0x00C0)] public FString StreamingLevelsPrefix;
    [FieldOffset(0x00D0)] public ULevel* CurrentLevelPendingVisibility;
    [FieldOffset(0x00D8)] public ULevel* CurrentLevelPendingInvisibility;
    [FieldOffset(0x00E0)] public UDemoNetDriver* DemoNetDriver;
    [FieldOffset(0x00E8)] public AParticleEventManager* MyParticleEventManager;
    [FieldOffset(0x00F0)] public APhysicsVolume* DefaultPhysicsVolume;
    [FieldOffset(0x010E)] public byte bAreConstraintsDirty;
    [FieldOffset(0x0110)] public UNavigationSystemBase* NavigationSystem;
    [FieldOffset(0x0118)] public AGameModeBase* AuthorityGameMode;
    [FieldOffset(0x0120)] public AGameStateBase* GameState;
    [FieldOffset(0x0128)] public UAISystemBase* AISystem;
    [FieldOffset(0x0130)] public UAvoidanceManager* AvoidanceManager;
    [FieldOffset(0x0138)] public TArray<IntPtr> Levels;
    [FieldOffset(0x0148)] public TArray<FLevelCollection> LevelCollections;
    [FieldOffset(0x0180)] public UGameInstance* OwningGameInstance;
    [FieldOffset(0x0188)] public TArray<IntPtr> ParameterCollectionInstances;
    [FieldOffset(0x0198)] public UCanvas* CanvasForRenderingToTarget;
    [FieldOffset(0x01A0)] public UCanvas* CanvasForDrawMaterialToRenderTarget;
    [FieldOffset(0x01F8)] public UPhysicsFieldComponent* PhysicsField;
    [FieldOffset(0x0200)] public TSet<IntPtr> ComponentsThatNeedPreEndOfFrameSync;
    [FieldOffset(0x0250)] public TArray<IntPtr> ComponentsThatNeedEndOfFrameUpdate;
    [FieldOffset(0x0260)] public TArray<IntPtr> ComponentsThatNeedEndOfFrameUpdate_OnGameThread;
    [FieldOffset(0x05E0)] public UWorldComposition* WorldComposition;
    [FieldOffset(0x0678)] public FWorldPSCPool PSCPool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct ULevelStreaming
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSoftObjectPtr<UWorld> WorldAsset;
    [FieldOffset(0x0050)] public FName PackageNameToLoad;
    [FieldOffset(0x0058)] public TArray<FName> LODPackageNames;
    [FieldOffset(0x0080)] public FTransform LevelTransform;
    [FieldOffset(0x00B0)] public int LevelLODIndex;
    [FieldOffset(0x00B4)] public int StreamingPriority;
    [FieldOffset(0x00BA)] public byte bShouldBeVisible;
    [FieldOffset(0x00BA)] public byte bShouldBeLoaded;
    [FieldOffset(0x00BA)] public byte bLocked;
    [FieldOffset(0x00BA)] public byte bIsStatic;
    [FieldOffset(0x00BA)] public byte bShouldBlockOnLoad;
    [FieldOffset(0x00BB)] public byte bShouldBlockOnUnload;
    [FieldOffset(0x00BB)] public byte bDisableDistanceStreaming;
    [FieldOffset(0x00BB)] public byte bDrawOnLevelStatusMap;
    [FieldOffset(0x00BC)] public FLinearColor LevelColor;
    [FieldOffset(0x00D0)] public TArray<IntPtr> EditorStreamingVolumes;
    [FieldOffset(0x00E0)] public float MinTimeBetweenVolumeUnloadRequests;
    [FieldOffset(0x0128)] public ULevel* LoadedLevel;
    [FieldOffset(0x0130)] public ULevel* PendingUnloadLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct ULevelStreamingAlwaysLoaded
{
    [FieldOffset(0x0000)] public ULevelStreaming baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct ULevelStreamingDynamic
{
    [FieldOffset(0x0000)] public ULevelStreaming baseObj;
    [FieldOffset(0x0148)] public byte bInitiallyLoaded;
    [FieldOffset(0x0148)] public byte bInitiallyVisible;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct ULevelStreamingPersistent
{
    [FieldOffset(0x0000)] public ULevelStreaming baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ALevelStreamingVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public TArray<FName> StreamingLevelNames;
    [FieldOffset(0x0268)] public byte bEditorPreVisOnly;
    [FieldOffset(0x0268)] public byte bDisabled;
    [FieldOffset(0x026C)] public EStreamingVolumeUsage StreamingUsage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct ULightmappedSurfaceCollection
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UModel* SourceModel;
    [FieldOffset(0x0030)] public TArray<int> Surfaces;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct ULightMapTexture2D
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct ULightMapVirtualTexture2D
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
    [FieldOffset(0x01A0)] public TArray<sbyte> TypeToLayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ALightmassCharacterIndirectDetailVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ALightmassImportanceVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ALightmassPortal
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ULightmassPortalComponent* PortalComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct ULightmassPortalComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public UBoxComponent* PreviewBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct ULightmassPrimitiveSettingsObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FLightmassPrimitiveSettings LightmassSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct ULineBatchComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FLightmassPointLightSettings
{
    [FieldOffset(0x0000)] public FLightmassLightSettings baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct ULocalLightComponent
{
    [FieldOffset(0x0000)] public ULightComponent baseObj;
    [FieldOffset(0x0328)] public ELightUnits IntensityUnits;
    [FieldOffset(0x032C)] public float Radius;
    [FieldOffset(0x0330)] public float AttenuationRadius;
    [FieldOffset(0x0334)] public FLightmassPointLightSettings LightmassSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ULocalPlayer
{
    [FieldOffset(0x0000)] public UPlayer baseObj;
    [FieldOffset(0x0070)] public UGameViewportClient* ViewportClient;
    [FieldOffset(0x0094)] public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
    [FieldOffset(0x0098)] public TSubclassOf<APlayerController> PendingLevelPlayerControllerClass;
    [FieldOffset(0x00A0)] public byte bSentSplitJoin;
    [FieldOffset(0x00B8)] public int ControllerId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct ULocalPlayerSubsystem
{
    [FieldOffset(0x0000)] public USubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FHLODInstancingKey
{
    [FieldOffset(0x0000)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0008)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ALODActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UStaticMeshComponent* StaticMeshComponent;
    [FieldOffset(0x0228)] public TMap<FHLODInstancingKey, IntPtr> InstancedStaticMeshComponents;
    [FieldOffset(0x0278)] public UHLODProxy* Proxy;
    [FieldOffset(0x0280)] public FName Key;
    [FieldOffset(0x0288)] public float LODDrawDistance;
    [FieldOffset(0x028C)] public int LODLevel;
    [FieldOffset(0x0290)] public TArray<IntPtr> SubActors;
    [FieldOffset(0x02A0)] public byte CachedNumHLODLevels;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FComponentSync
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public ESyncOption SyncOption;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLODMappingData
{
    [FieldOffset(0x0000)] public TArray<int> Mapping;
    [FieldOffset(0x0010)] public TArray<int> InverseMapping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct ULODSyncComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public int NumLODs;
    [FieldOffset(0x00B4)] public int ForcedLOD;
    [FieldOffset(0x00B8)] public TArray<FComponentSync> ComponentsToSync;
    [FieldOffset(0x00C8)] public TMap<FName, FLODMappingData> CustomLODMapping;
    [FieldOffset(0x0118)] public int CurrentLOD;
    [FieldOffset(0x011C)] public int CurrentNumLODs;
    [FieldOffset(0x0120)] public TArray<IntPtr> DriveComponents;
    [FieldOffset(0x0130)] public TArray<IntPtr> SubComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ILODSyncInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct UMapBuildDataRegistry
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public ELightingBuildQuality LevelLightingQuality;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMaterialInput
{
    [FieldOffset(0x0000)] public int OutputIndex;
    [FieldOffset(0x0004)] public FName InputName;
    [FieldOffset(0x000C)] public FName ExpressionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FScalarMaterialInput
{
    [FieldOffset(0x0000)] public FMaterialInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FVectorMaterialInput
{
    [FieldOffset(0x0000)] public FMaterialInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FColorMaterialInput
{
    [FieldOffset(0x0000)] public FMaterialInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FMaterialShadingModelField
{
    [FieldOffset(0x0000)] public ushort ShadingModelField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMaterialAttributesInput
{
    [FieldOffset(0x0000)] public FExpressionInput baseObj;
    [FieldOffset(0x0014)] public int PropertyConnectedBitmask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FShadingModelMaterialInput
{
    [FieldOffset(0x0000)] public FMaterialInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMaterialFunctionInfo
{
    [FieldOffset(0x0000)] public FGuid StateId;
    [FieldOffset(0x0010)] public UMaterialFunctionInterface* Function;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMaterialParameterCollectionInfo
{
    [FieldOffset(0x0000)] public FGuid StateId;
    [FieldOffset(0x0010)] public UMaterialParameterCollection* ParameterCollection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct FMaterialCachedExpressionData
{
    [FieldOffset(0x0000)] public FMaterialCachedParameters Parameters;
    [FieldOffset(0x0150)] public TArray<IntPtr> ReferencedTextures;
    [FieldOffset(0x0160)] public TArray<FMaterialFunctionInfo> FunctionInfos;
    [FieldOffset(0x0170)] public TArray<FMaterialParameterCollectionInfo> ParameterCollectionInfos;
    [FieldOffset(0x0180)] public TArray<IntPtr> DefaultLayers;
    [FieldOffset(0x0190)] public TArray<IntPtr> DefaultLayerBlends;
    [FieldOffset(0x01A0)] public TArray<IntPtr> GrassTypes;
    [FieldOffset(0x01B0)] public TArray<FName> DynamicParameterNames;
    [FieldOffset(0x01C0)] public TArray<bool> QualityLevelsUsed;
    [FieldOffset(0x01D0)] public byte bHasRuntimeVirtualTextureOutput;
    [FieldOffset(0x01D0)] public byte bHasSceneColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x440)] 
public unsafe struct UMaterial
{
    [FieldOffset(0x0000)] public UMaterialInterface baseObj;
    [FieldOffset(0x0088)] public UPhysicalMaterial* PhysMaterial;
    [FieldOffset(0x0090)] public UPhysicalMaterialMask* PhysMaterialMask;
    [FieldOffset(0x0098)] public UPhysicalMaterial* PhysicalMaterialMap;
    [FieldOffset(0x00D8)] public FScalarMaterialInput Metallic;
    [FieldOffset(0x00EC)] public FScalarMaterialInput Specular;
    [FieldOffset(0x0100)] public FScalarMaterialInput Anisotropy;
    [FieldOffset(0x0114)] public FVectorMaterialInput Normal;
    [FieldOffset(0x0128)] public FVectorMaterialInput Tangent;
    [FieldOffset(0x013C)] public FColorMaterialInput EmissiveColor;
    [FieldOffset(0x0150)] public EMaterialDomain MaterialDomain;
    [FieldOffset(0x0151)] public EBlendMode BlendMode;
    [FieldOffset(0x0152)] public EDecalBlendMode DecalBlendMode;
    [FieldOffset(0x0153)] public EMaterialDecalResponse MaterialDecalResponse;
    [FieldOffset(0x0154)] public EMaterialShadingModel ShadingModel;
    [FieldOffset(0x0155)] public byte bCastDynamicShadowAsMasked;
    [FieldOffset(0x0156)] public FMaterialShadingModelField ShadingModels;
    [FieldOffset(0x0158)] public float OpacityMaskClipValue;
    [FieldOffset(0x015C)] public FVectorMaterialInput WorldPositionOffset;
    [FieldOffset(0x0170)] public FScalarMaterialInput Refraction;
    [FieldOffset(0x0184)] public FMaterialAttributesInput MaterialAttributes;
    [FieldOffset(0x019C)] public FScalarMaterialInput PixelDepthOffset;
    [FieldOffset(0x01B0)] public FShadingModelMaterialInput ShadingModelFromMaterialExpression;
    [FieldOffset(0x01C4)] public byte bEnableSeparateTranslucency;
    [FieldOffset(0x01C4)] public byte bEnableResponsiveAA;
    [FieldOffset(0x01C4)] public byte bScreenSpaceReflections;
    [FieldOffset(0x01C4)] public byte bContactShadows;
    [FieldOffset(0x01C4)] public byte TwoSided;
    [FieldOffset(0x01C4)] public byte DitheredLODTransition;
    [FieldOffset(0x01C4)] public byte DitherOpacityMask;
    [FieldOffset(0x01C4)] public byte bAllowNegativeEmissiveColor;
    [FieldOffset(0x01C5)] public ETranslucencyLightingMode TranslucencyLightingMode;
    [FieldOffset(0x01C6)] public byte bEnableMobileSeparateTranslucency;
    [FieldOffset(0x01C8)] public int NumCustomizedUVs;
    [FieldOffset(0x01CC)] public float TranslucencyDirectionalLightingIntensity;
    [FieldOffset(0x01D0)] public float TranslucentShadowDensityScale;
    [FieldOffset(0x01D4)] public float TranslucentSelfShadowDensityScale;
    [FieldOffset(0x01D8)] public float TranslucentSelfShadowSecondDensityScale;
    [FieldOffset(0x01DC)] public float TranslucentSelfShadowSecondOpacity;
    [FieldOffset(0x01E0)] public float TranslucentBackscatteringExponent;
    [FieldOffset(0x01E4)] public FLinearColor TranslucentMultipleScatteringExtinction;
    [FieldOffset(0x01F4)] public float TranslucentShadowStartOffset;
    [FieldOffset(0x01F8)] public byte bDisableDepthTest;
    [FieldOffset(0x01F8)] public byte bWriteOnlyAlpha;
    [FieldOffset(0x01F8)] public byte bGenerateSphericalParticleNormals;
    [FieldOffset(0x01F8)] public byte bTangentSpaceNormal;
    [FieldOffset(0x01F8)] public byte bUseEmissiveForDynamicAreaLighting;
    [FieldOffset(0x01F8)] public byte bBlockGI;
    [FieldOffset(0x01F8)] public byte bUsedAsSpecialEngineMaterial;
    [FieldOffset(0x01F8)] public byte bUsedWithSkeletalMesh;
    [FieldOffset(0x01F9)] public byte bUsedWithEditorCompositing;
    [FieldOffset(0x01F9)] public byte bUsedWithParticleSprites;
    [FieldOffset(0x01F9)] public byte bUsedWithBeamTrails;
    [FieldOffset(0x01F9)] public byte bUsedWithMeshParticles;
    [FieldOffset(0x01F9)] public byte bUsedWithNiagaraSprites;
    [FieldOffset(0x01F9)] public byte bUsedWithNiagaraRibbons;
    [FieldOffset(0x01F9)] public byte bUsedWithNiagaraMeshParticles;
    [FieldOffset(0x01F9)] public byte bUsedWithGeometryCache;
    [FieldOffset(0x01FA)] public byte bUsedWithStaticLighting;
    [FieldOffset(0x01FA)] public byte bUsedWithMorphTargets;
    [FieldOffset(0x01FA)] public byte bUsedWithSplineMeshes;
    [FieldOffset(0x01FA)] public byte bUsedWithInstancedStaticMeshes;
    [FieldOffset(0x01FA)] public byte bUsedWithGeometryCollections;
    [FieldOffset(0x01FA)] public byte bUsesDistortion;
    [FieldOffset(0x01FA)] public byte bUsedWithClothing;
    [FieldOffset(0x01FC)] public byte bUsedWithWater;
    [FieldOffset(0x01FC)] public byte bUsedWithHairStrands;
    [FieldOffset(0x01FC)] public byte bUsedWithLidarPointCloud;
    [FieldOffset(0x01FC)] public byte bUsedWithVirtualHeightfieldMesh;
    [FieldOffset(0x0200)] public byte bUsedWithUI;
    [FieldOffset(0x0200)] public byte bAutomaticallySetUsageInEditor;
    [FieldOffset(0x0200)] public byte bFullyRough;
    [FieldOffset(0x0200)] public byte bUseFullPrecision;
    [FieldOffset(0x0200)] public byte bUseLightmapDirectionality;
    [FieldOffset(0x0200)] public byte bUseAlphaToCoverage;
    [FieldOffset(0x0204)] public byte bForwardRenderUsePreintegratedGFForSimpleIBL;
    [FieldOffset(0x0208)] public byte bUseHQForwardReflections;
    [FieldOffset(0x0208)] public byte bForwardBlendsSkyLightCubemaps;
    [FieldOffset(0x0208)] public byte bUsePlanarForwardReflections;
    [FieldOffset(0x0208)] public byte bNormalCurvatureToRoughness;
    [FieldOffset(0x0209)] public EMaterialTessellationMode D3D11TessellationMode;
    [FieldOffset(0x020A)] public byte bEnableCrackFreeDisplacement;
    [FieldOffset(0x020A)] public byte bEnableAdaptiveTessellation;
    [FieldOffset(0x020A)] public byte AllowTranslucentCustomDepthWrites;
    [FieldOffset(0x020A)] public byte Wireframe;
    [FieldOffset(0x020A)] public byte WriteDepthToTranslucentMaterial;
    [FieldOffset(0x020B)] public EMaterialShadingRate ShadingRate;
    [FieldOffset(0x020C)] public byte bCanMaskedBeAssumedOpaque;
    [FieldOffset(0x020C)] public byte bIsMasked;
    [FieldOffset(0x020C)] public byte bIsPreviewMaterial;
    [FieldOffset(0x020C)] public byte bIsFunctionPreviewMaterial;
    [FieldOffset(0x020C)] public byte bUseMaterialAttributes;
    [FieldOffset(0x020C)] public byte bCastRayTracedShadows;
    [FieldOffset(0x020C)] public byte bUseTranslucencyVertexFog;
    [FieldOffset(0x020C)] public byte bApplyCloudFogging;
    [FieldOffset(0x020D)] public byte bIsSky;
    [FieldOffset(0x020D)] public byte bComputeFogPerPixel;
    [FieldOffset(0x020D)] public byte bOutputTranslucentVelocity;
    [FieldOffset(0x020D)] public byte bAllowDevelopmentShaderCompile;
    [FieldOffset(0x020D)] public byte bIsMaterialEditorStatsMaterial;
    [FieldOffset(0x020E)] public EBlendableLocation BlendableLocation;
    [FieldOffset(0x020F)] public byte BlendableOutputAlpha;
    [FieldOffset(0x020F)] public byte bEnableStencilTest;
    [FieldOffset(0x0210)] public EMaterialStencilCompare StencilCompare;
    [FieldOffset(0x0211)] public byte StencilRefValue;
    [FieldOffset(0x0212)] public ERefractionMode RefractionMode;
    [FieldOffset(0x0214)] public int BlendablePriority;
    [FieldOffset(0x0218)] public byte bIsBlendable;
    [FieldOffset(0x021C)] public uint UsageFlagWarnings;
    [FieldOffset(0x0220)] public float RefractionDepthBias;
    [FieldOffset(0x0224)] public FGuid StateId;
    [FieldOffset(0x0234)] public float MaxDisplacement;
    [FieldOffset(0x0268)] public FMaterialCachedExpressionData CachedExpressionData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMaterialSpriteElement
{
    [FieldOffset(0x0000)] public UMaterialInterface* Material;
    [FieldOffset(0x0008)] public UCurveFloat* DistanceToOpacityCurve;
    [FieldOffset(0x0010)] public byte bSizeIsInScreenSpace;
    [FieldOffset(0x0014)] public float BaseSizeX;
    [FieldOffset(0x0018)] public float BaseSizeY;
    [FieldOffset(0x0020)] public UCurveFloat* DistanceToSizeCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x460)] 
public unsafe struct UMaterialBillboardComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public TArray<FMaterialSpriteElement> Elements;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionAbs
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionActorPositionWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionAdd
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionAntialiasedTextureMask
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter2D baseObj;
    [FieldOffset(0x0080)] public float Threshold;
    [FieldOffset(0x0084)] public ETextureColorChannel Channel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionAppendVector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArccosine
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArccosineFast
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArcsine
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArcsineFast
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArctangent
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionArctangent2
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Y;
    [FieldOffset(0x0054)] public FExpressionInput X;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionArctangent2Fast
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Y;
    [FieldOffset(0x0054)] public FExpressionInput X;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionArctangentFast
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionAtmosphericFogColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput WorldPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionAtmosphericLightColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionAtmosphericLightVector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionBentNormalCustomOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionBlackBody
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Temp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionBlendMaterialAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FMaterialAttributesInput A;
    [FieldOffset(0x0058)] public FMaterialAttributesInput B;
    [FieldOffset(0x0070)] public FExpressionInput Alpha;
    [FieldOffset(0x0084)] public EMaterialAttributeBlend PixelAttributeBlendType;
    [FieldOffset(0x0085)] public EMaterialAttributeBlend VertexAttributeBlendType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionBreakMaterialAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FMaterialAttributesInput MaterialAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionBumpOffset
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput coordinate;
    [FieldOffset(0x0054)] public FExpressionInput Height;
    [FieldOffset(0x0068)] public FExpressionInput HeightRatioInput;
    [FieldOffset(0x007C)] public float HeightRatio;
    [FieldOffset(0x0080)] public float ReferencePlane;
    [FieldOffset(0x0084)] public uint ConstCoordinate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionCameraPositionWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionCameraVectorWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionCeil
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionParameter
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FName ParameterName;
    [FieldOffset(0x0048)] public FGuid ExpressionGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionVectorParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionParameter baseObj;
    [FieldOffset(0x0058)] public FLinearColor DefaultValue;
    [FieldOffset(0x0068)] public bool bUseCustomPrimitiveData;
    [FieldOffset(0x0069)] public byte PrimitiveDataIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionChannelMaskParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionVectorParameter baseObj;
    [FieldOffset(0x0070)] public EChannelMaskParameterColor MaskChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionClamp
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public FExpressionInput Min;
    [FieldOffset(0x0068)] public FExpressionInput Max;
    [FieldOffset(0x007C)] public EClampMode ClampMode;
    [FieldOffset(0x0080)] public float MinDefault;
    [FieldOffset(0x0084)] public float MaxDefault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionClearCoatNormalCustomOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionCloudSampleAttribute
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionCollectionParameter
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public UMaterialParameterCollection* Collection;
    [FieldOffset(0x0048)] public FName ParameterName;
    [FieldOffset(0x0050)] public FGuid ParameterId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionComment
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public int SizeX;
    [FieldOffset(0x0044)] public int SizeY;
    [FieldOffset(0x0048)] public FString Text;
    [FieldOffset(0x0058)] public FLinearColor CommentColor;
    [FieldOffset(0x0068)] public int FontSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionComponentMask
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public byte R;
    [FieldOffset(0x0054)] public byte G;
    [FieldOffset(0x0054)] public byte B;
    [FieldOffset(0x0054)] public byte A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionConstant
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public float R;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionConstant2Vector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public float R;
    [FieldOffset(0x0044)] public float G;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionConstant3Vector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FLinearColor Constant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionConstant4Vector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FLinearColor Constant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionConstantBiasScale
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public float Bias;
    [FieldOffset(0x0058)] public float Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionCosine
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public float Period;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionCrossProduct
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionScalarParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionParameter baseObj;
    [FieldOffset(0x0058)] public float DefaultValue;
    [FieldOffset(0x005C)] public bool bUseCustomPrimitiveData;
    [FieldOffset(0x005D)] public byte PrimitiveDataIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionCurveAtlasRowParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionScalarParameter baseObj;
    [FieldOffset(0x0060)] public UCurveLinearColor* Curve;
    [FieldOffset(0x0068)] public UCurveLinearColorAtlas* Atlas;
    [FieldOffset(0x0070)] public FExpressionInput InputTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCustomInput
{
    [FieldOffset(0x0000)] public FName InputName;
    [FieldOffset(0x0008)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FCustomOutput
{
    [FieldOffset(0x0000)] public FName OutputName;
    [FieldOffset(0x0008)] public ECustomMaterialOutputType OutputType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCustomDefine
{
    [FieldOffset(0x0000)] public FString DefineName;
    [FieldOffset(0x0010)] public FString DefineValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMaterialExpressionCustom
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FString Code;
    [FieldOffset(0x0050)] public ECustomMaterialOutputType OutputType;
    [FieldOffset(0x0058)] public FString Description;
    [FieldOffset(0x0068)] public TArray<FCustomInput> Inputs;
    [FieldOffset(0x0078)] public TArray<FCustomOutput> AdditionalOutputs;
    [FieldOffset(0x0088)] public TArray<FCustomDefine> AdditionalDefines;
    [FieldOffset(0x0098)] public TArray<FString> IncludeFilePaths;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDDX
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDDY
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionDecalDerivative
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionDecalLifetimeOpacity
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionDecalMipmapLevel
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput TextureSize;
    [FieldOffset(0x0054)] public float ConstWidth;
    [FieldOffset(0x0058)] public float ConstHeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionDeltaTime
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionDepthFade
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput InOpacity;
    [FieldOffset(0x0054)] public FExpressionInput FadeDistance;
    [FieldOffset(0x0068)] public float OpacityDefault;
    [FieldOffset(0x006C)] public float FadeDistanceDefault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDepthOfFieldFunction
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EDepthOfFieldFunctionValue FunctionValue;
    [FieldOffset(0x0044)] public FExpressionInput Depth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDeriveNormalZ
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput InXY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionDesaturation
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public FExpressionInput Fraction;
    [FieldOffset(0x0068)] public FLinearColor LuminanceFactors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionDistance
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionDistanceCullFade
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDistanceFieldGradient
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Position;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionDistanceFieldsRenderingSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput No;
    [FieldOffset(0x0054)] public FExpressionInput Yes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionDistanceToNearestSurface
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Position;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionDivide
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionDotProduct
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionDynamicParameter
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public TArray<FString> ParamNames;
    [FieldOffset(0x0050)] public FLinearColor DefaultValue;
    [FieldOffset(0x0060)] public uint ParameterIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionEyeAdaptation
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionFeatureLevelSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionFloor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionFmod
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionFontSample
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public UFont* Font;
    [FieldOffset(0x0048)] public int FontTexturePage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionFontSampleParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionFontSample baseObj;
    [FieldOffset(0x0050)] public FName ParameterName;
    [FieldOffset(0x0058)] public FGuid ExpressionGUID;
    [FieldOffset(0x0068)] public FName Group;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionFrac
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionFresnel
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput ExponentIn;
    [FieldOffset(0x0054)] public float Exponent;
    [FieldOffset(0x0058)] public FExpressionInput BaseReflectFractionIn;
    [FieldOffset(0x006C)] public float BaseReflectFraction;
    [FieldOffset(0x0070)] public FExpressionInput Normal;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMaterialExpressionFunctionInput
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Preview;
    [FieldOffset(0x0054)] public FName InputName;
    [FieldOffset(0x0060)] public FString Description;
    [FieldOffset(0x0070)] public FGuid ID;
    [FieldOffset(0x0080)] public EFunctionInputType InputType;
    [FieldOffset(0x0090)] public FVector4 PreviewValue;
    [FieldOffset(0x00A0)] public byte bUsePreviewValueAsDefault;
    [FieldOffset(0x00A4)] public int SortPriority;
    [FieldOffset(0x00A8)] public byte bCompilingFunctionPreview;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionFunctionOutput
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FName OutputName;
    [FieldOffset(0x0048)] public FString Description;
    [FieldOffset(0x0058)] public int SortPriority;
    [FieldOffset(0x005C)] public FExpressionInput A;
    [FieldOffset(0x0070)] public byte bLastPreviewed;
    [FieldOffset(0x0074)] public FGuid ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionGetMaterialAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FMaterialAttributesInput MaterialAttributes;
    [FieldOffset(0x0058)] public TArray<FGuid> AttributeGetTypes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionGIReplace
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput StaticIndirect;
    [FieldOffset(0x0068)] public FExpressionInput DynamicIndirect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionHairAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public byte bUseTangentSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionHairColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Melanin;
    [FieldOffset(0x0054)] public FExpressionInput Redness;
    [FieldOffset(0x0068)] public FExpressionInput DyeColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMaterialExpressionIf
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public FExpressionInput AGreaterThanB;
    [FieldOffset(0x007C)] public FExpressionInput AEqualsB;
    [FieldOffset(0x0090)] public FExpressionInput ALessThanB;
    [FieldOffset(0x00A4)] public float EqualsThreshold;
    [FieldOffset(0x00A8)] public float ConstB;
    [FieldOffset(0x00AC)] public float ConstAEqualsB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionInverseLinearInterpolate
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public FExpressionInput Value;
    [FieldOffset(0x007C)] public float ConstA;
    [FieldOffset(0x0080)] public float ConstB;
    [FieldOffset(0x0084)] public float ConstValue;
    [FieldOffset(0x0088)] public bool bClampResult;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionLightmapUVs
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionLightmassReplace
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Realtime;
    [FieldOffset(0x0054)] public FExpressionInput Lightmass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionLightVector
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionLinearInterpolate
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public FExpressionInput Alpha;
    [FieldOffset(0x007C)] public float ConstA;
    [FieldOffset(0x0080)] public float ConstB;
    [FieldOffset(0x0084)] public float ConstAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionLogarithm10
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput X;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionLogarithm2
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput X;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UMaterialExpressionMakeMaterialAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput BaseColor;
    [FieldOffset(0x0054)] public FExpressionInput Metallic;
    [FieldOffset(0x0068)] public FExpressionInput Specular;
    [FieldOffset(0x007C)] public FExpressionInput Roughness;
    [FieldOffset(0x0090)] public FExpressionInput Anisotropy;
    [FieldOffset(0x00A4)] public FExpressionInput EmissiveColor;
    [FieldOffset(0x00B8)] public FExpressionInput Opacity;
    [FieldOffset(0x00CC)] public FExpressionInput OpacityMask;
    [FieldOffset(0x00E0)] public FExpressionInput Normal;
    [FieldOffset(0x00F4)] public FExpressionInput Tangent;
    [FieldOffset(0x0108)] public FExpressionInput WorldPositionOffset;
    [FieldOffset(0x011C)] public FExpressionInput WorldDisplacement;
    [FieldOffset(0x0130)] public FExpressionInput TessellationMultiplier;
    [FieldOffset(0x0144)] public FExpressionInput SubsurfaceColor;
    [FieldOffset(0x0158)] public FExpressionInput ClearCoat;
    [FieldOffset(0x016C)] public FExpressionInput ClearCoatRoughness;
    [FieldOffset(0x0180)] public FExpressionInput AmbientOcclusion;
    [FieldOffset(0x0194)] public FExpressionInput Refraction;
    [FieldOffset(0x01A8)] public FExpressionInput CustomizedUVs;
    [FieldOffset(0x0248)] public FExpressionInput PixelDepthOffset;
    [FieldOffset(0x025C)] public FExpressionInput ShadingModel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionMapARPassthroughCameraUV
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Coordinates;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMaterialExpressionMaterialAttributeLayers
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FName ParameterName;
    [FieldOffset(0x0048)] public FGuid ExpressionGUID;
    [FieldOffset(0x0058)] public FMaterialAttributesInput Input;
    [FieldOffset(0x0070)] public FMaterialLayersFunctions DefaultLayers;
    [FieldOffset(0x00B0)] public TArray<IntPtr> LayerCallers;
    [FieldOffset(0x00C0)] public int NumActiveLayerCallers;
    [FieldOffset(0x00C8)] public TArray<IntPtr> BlendCallers;
    [FieldOffset(0x00D8)] public int NumActiveBlendCallers;
    [FieldOffset(0x00DC)] public bool bIsLayerGraphBuilt;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionMaterialFunctionCall
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public UMaterialFunctionInterface* MaterialFunction;
    [FieldOffset(0x0048)] public FMaterialParameterInfo FunctionParameterInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionMaterialLayerOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionFunctionOutput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionMaterialProxyReplace
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Realtime;
    [FieldOffset(0x0054)] public FExpressionInput MaterialProxy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionMax
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionMin
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionMultiply
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionRerouteBase
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionNamedRerouteBase
{
    [FieldOffset(0x0000)] public UMaterialExpressionRerouteBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionNamedRerouteDeclaration
{
    [FieldOffset(0x0000)] public UMaterialExpressionNamedRerouteBase baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public FName Name;
    [FieldOffset(0x005C)] public FGuid VariableGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionNamedRerouteUsage
{
    [FieldOffset(0x0000)] public UMaterialExpressionNamedRerouteBase baseObj;
    [FieldOffset(0x0040)] public UMaterialExpressionNamedRerouteDeclaration* Declaration;
    [FieldOffset(0x0048)] public FGuid DeclarationGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionNoise
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Position;
    [FieldOffset(0x0054)] public FExpressionInput FilterWidth;
    [FieldOffset(0x0068)] public float Scale;
    [FieldOffset(0x006C)] public int Quality;
    [FieldOffset(0x0070)] public ENoiseFunction NoiseFunction;
    [FieldOffset(0x0074)] public byte bTurbulence;
    [FieldOffset(0x0078)] public int Levels;
    [FieldOffset(0x007C)] public float OutputMin;
    [FieldOffset(0x0080)] public float OutputMax;
    [FieldOffset(0x0084)] public float LevelScale;
    [FieldOffset(0x0088)] public byte bTiling;
    [FieldOffset(0x008C)] public uint RepeatSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionNormalize
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput VectorInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionObjectBounds
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionObjectOrientation
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionObjectPositionWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionObjectRadius
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionOneMinus
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionPanner
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput coordinate;
    [FieldOffset(0x0054)] public FExpressionInput Time;
    [FieldOffset(0x0068)] public FExpressionInput Speed;
    [FieldOffset(0x007C)] public float SpeedX;
    [FieldOffset(0x0080)] public float SpeedY;
    [FieldOffset(0x0084)] public uint ConstCoordinate;
    [FieldOffset(0x0088)] public bool bFractionalPart;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleDirection
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleMacroUV
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleMotionBlurFade
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticlePositionWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleRadius
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleRandom
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleRelativeTime
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleSize
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleSpeed
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionParticleSubUV
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSample baseObj;
    [FieldOffset(0x0060)] public byte bBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionParticleSubUVProperties
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionPerInstanceCustomData
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput DefaultValue;
    [FieldOffset(0x0054)] public float ConstDefaultValue;
    [FieldOffset(0x0058)] public uint DataIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPerInstanceFadeAmount
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPerInstanceRandom
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPixelDepth
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPixelNormalWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionPower
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Base;
    [FieldOffset(0x0054)] public FExpressionInput Exponent;
    [FieldOffset(0x0068)] public float ConstExponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPrecomputedAOMask
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPreSkinnedLocalBounds
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPreSkinnedNormal
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionPreSkinnedPosition
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionPreviousFrameSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput CurrentFrame;
    [FieldOffset(0x0054)] public FExpressionInput PreviousFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UMaterialExpressionQualitySwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput Inputs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionRayTracingQualitySwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Normal;
    [FieldOffset(0x0054)] public FExpressionInput RayTraced;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionReflectionCapturePassSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput Reflection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionReflectionVectorWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput CustomWorldNormal;
    [FieldOffset(0x0054)] public byte bNormalizeCustomWorldNormal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionReroute
{
    [FieldOffset(0x0000)] public UMaterialExpressionRerouteBase baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UMaterialExpressionRotateAboutAxis
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput NormalizedRotationAxis;
    [FieldOffset(0x0054)] public FExpressionInput RotationAngle;
    [FieldOffset(0x0068)] public FExpressionInput PivotPoint;
    [FieldOffset(0x007C)] public FExpressionInput Position;
    [FieldOffset(0x0090)] public float Period;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionRotator
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput coordinate;
    [FieldOffset(0x0054)] public FExpressionInput Time;
    [FieldOffset(0x0068)] public float CenterX;
    [FieldOffset(0x006C)] public float CenterY;
    [FieldOffset(0x0070)] public float Speed;
    [FieldOffset(0x0074)] public uint ConstCoordinate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionRound
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMaterialExpressionRuntimeVirtualTextureOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput BaseColor;
    [FieldOffset(0x0054)] public FExpressionInput Specular;
    [FieldOffset(0x0068)] public FExpressionInput Roughness;
    [FieldOffset(0x007C)] public FExpressionInput Normal;
    [FieldOffset(0x0090)] public FExpressionInput WorldHeight;
    [FieldOffset(0x00A4)] public FExpressionInput Opacity;
    [FieldOffset(0x00B8)] public FExpressionInput Mask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionRuntimeVirtualTextureReplace
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput VirtualTextureOutput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionRuntimeVirtualTextureSample
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Coordinates;
    [FieldOffset(0x0054)] public FExpressionInput WorldPosition;
    [FieldOffset(0x0068)] public FExpressionInput MipValue;
    [FieldOffset(0x0080)] public URuntimeVirtualTexture* VirtualTexture;
    [FieldOffset(0x0088)] public ERuntimeVirtualTextureMaterialType MaterialType;
    [FieldOffset(0x0089)] public bool bSinglePhysicalSpace;
    [FieldOffset(0x008A)] public bool bAdaptive;
    [FieldOffset(0x008B)] public ERuntimeVirtualTextureMipValueMode MipValueMode;
    [FieldOffset(0x008C)] public ERuntimeVirtualTextureTextureAddressMode TextureAddressMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMaterialExpressionRuntimeVirtualTextureSampleParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionRuntimeVirtualTextureSample baseObj;
    [FieldOffset(0x0090)] public FName ParameterName;
    [FieldOffset(0x0098)] public FGuid ExpressionGUID;
    [FieldOffset(0x00A8)] public FName Group;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSamplePhysicsVectorField
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput WorldPosition;
    [FieldOffset(0x0054)] public EFieldVectorType FieldTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSamplePhysicsScalarField
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput WorldPosition;
    [FieldOffset(0x0054)] public EFieldScalarType FieldTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSamplePhysicsIntegerField
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput WorldPosition;
    [FieldOffset(0x0054)] public EFieldIntegerType FieldTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSaturate
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionSceneColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EMaterialSceneAttributeInputMode InputMode;
    [FieldOffset(0x0044)] public FExpressionInput Input;
    [FieldOffset(0x0058)] public FExpressionInput OffsetFraction;
    [FieldOffset(0x006C)] public FVector2D ConstInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionSceneDepth
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EMaterialSceneAttributeInputMode InputMode;
    [FieldOffset(0x0044)] public FExpressionInput Input;
    [FieldOffset(0x0058)] public FExpressionInput Coordinates;
    [FieldOffset(0x006C)] public FVector2D ConstInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionSceneDepthWithoutWater
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EMaterialSceneAttributeInputMode InputMode;
    [FieldOffset(0x0044)] public FExpressionInput Input;
    [FieldOffset(0x0058)] public FVector2D ConstInput;
    [FieldOffset(0x0060)] public float FallbackDepth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionSceneTexelSize
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSceneTexture
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Coordinates;
    [FieldOffset(0x0054)] public ESceneTextureId SceneTextureId;
    [FieldOffset(0x0055)] public bool bFiltered;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionScreenPosition
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionSetMaterialAttributes
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public TArray<FExpressionInput> Inputs;
    [FieldOffset(0x0050)] public TArray<FGuid> AttributeSetTypes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionShaderStageSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput PixelShader;
    [FieldOffset(0x0054)] public FExpressionInput VertexShader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionShadingModel
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EMaterialShadingModel ShadingModel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionShadingPathSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput Inputs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionShadowReplace
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Default;
    [FieldOffset(0x0054)] public FExpressionInput Shadow;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSign
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSine
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public float Period;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMaterialExpressionSingleLayerWaterMaterialOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput ScatteringCoefficients;
    [FieldOffset(0x0054)] public FExpressionInput AbsorptionCoefficients;
    [FieldOffset(0x0068)] public FExpressionInput PhaseG;
    [FieldOffset(0x007C)] public FExpressionInput ColorScaleBehindWater;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionSkinningVertexOffsets
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionSkyAtmosphereLightDirection
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public int LightIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSkyAtmosphereLightIlluminance
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public int LightIndex;
    [FieldOffset(0x0044)] public FExpressionInput WorldPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionSkyAtmosphereLightDiskLuminance
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public int LightIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSkyAtmosphereAerialPerspective
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput WorldPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionSkyAtmosphereViewLuminance
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionSmoothStep
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Min;
    [FieldOffset(0x0054)] public FExpressionInput Max;
    [FieldOffset(0x0068)] public FExpressionInput Value;
    [FieldOffset(0x007C)] public float ConstMin;
    [FieldOffset(0x0080)] public float ConstMax;
    [FieldOffset(0x0084)] public float ConstValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionSobol
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Cell;
    [FieldOffset(0x0054)] public FExpressionInput Index;
    [FieldOffset(0x0068)] public FExpressionInput Seed;
    [FieldOffset(0x007C)] public uint ConstIndex;
    [FieldOffset(0x0080)] public FVector2D ConstSeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMaterialExpressionSpeedTree
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput GeometryInput;
    [FieldOffset(0x0054)] public FExpressionInput WindInput;
    [FieldOffset(0x0068)] public FExpressionInput LODInput;
    [FieldOffset(0x007C)] public FExpressionInput ExtraBendWS;
    [FieldOffset(0x0090)] public ESpeedTreeGeometryType GeometryType;
    [FieldOffset(0x0091)] public ESpeedTreeWindType WindType;
    [FieldOffset(0x0092)] public ESpeedTreeLODType LODType;
    [FieldOffset(0x0094)] public float BillboardThreshold;
    [FieldOffset(0x0098)] public bool bAccurateWindVelocities;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UMaterialExpressionSphereMask
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public FExpressionInput Radius;
    [FieldOffset(0x007C)] public FExpressionInput Hardness;
    [FieldOffset(0x0090)] public float AttenuationRadius;
    [FieldOffset(0x0094)] public float HardnessPercent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSphericalParticleOpacity
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Density;
    [FieldOffset(0x0054)] public float ConstantDensity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionSquareRoot
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionStaticBool
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public byte Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionStaticBoolParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionParameter baseObj;
    [FieldOffset(0x0058)] public byte DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionStaticComponentMaskParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionParameter baseObj;
    [FieldOffset(0x0058)] public byte DefaultR;
    [FieldOffset(0x0058)] public byte DefaultG;
    [FieldOffset(0x0058)] public byte DefaultB;
    [FieldOffset(0x0058)] public byte DefaultA;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionStaticSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public byte DefaultValue;
    [FieldOffset(0x0044)] public FExpressionInput A;
    [FieldOffset(0x0058)] public FExpressionInput B;
    [FieldOffset(0x006C)] public FExpressionInput Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionStaticSwitchParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionStaticBoolParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionStep
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Y;
    [FieldOffset(0x0054)] public FExpressionInput X;
    [FieldOffset(0x0068)] public float ConstY;
    [FieldOffset(0x006C)] public float ConstX;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialExpressionSubtract
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput A;
    [FieldOffset(0x0054)] public FExpressionInput B;
    [FieldOffset(0x0068)] public float ConstA;
    [FieldOffset(0x006C)] public float ConstB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTangent
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public float Period;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTangentOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialExpressionTemporalSobol
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Index;
    [FieldOffset(0x0054)] public FExpressionInput Seed;
    [FieldOffset(0x0068)] public uint ConstIndex;
    [FieldOffset(0x006C)] public FVector2D ConstSeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMaterialExpressionTextureCoordinate
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public int CoordinateIndex;
    [FieldOffset(0x0044)] public float UTiling;
    [FieldOffset(0x0048)] public float VTiling;
    [FieldOffset(0x004C)] public byte UnMirrorU;
    [FieldOffset(0x004C)] public byte UnMirrorV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionTextureObject
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureObjectParameter
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTextureProperty
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput TextureObject;
    [FieldOffset(0x0054)] public EMaterialExposedTextureProperty Property;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureSampleParameter2DArray
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureSampleParameterCube
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UMaterialExpressionTextureSampleParameterSubUV
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter2D baseObj;
    [FieldOffset(0x0080)] public byte bBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMaterialExpressionTextureSampleParameterVolume
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionThinTranslucentMaterialOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput TransmittanceColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionTime
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public byte bIgnorePause;
    [FieldOffset(0x0040)] public byte bOverride_Period;
    [FieldOffset(0x0044)] public float Period;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTransform
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public EMaterialVectorCoordTransformSource TransformSourceType;
    [FieldOffset(0x0055)] public EMaterialVectorCoordTransform TransformType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTransformPosition
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
    [FieldOffset(0x0054)] public EMaterialPositionTransformSource TransformSourceType;
    [FieldOffset(0x0055)] public EMaterialPositionTransformSource TransformType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialExpressionTruncate
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionTwoSidedSign
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionVectorNoise
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Position;
    [FieldOffset(0x0054)] public EVectorNoiseFunction NoiseFunction;
    [FieldOffset(0x0058)] public int Quality;
    [FieldOffset(0x005C)] public byte bTiling;
    [FieldOffset(0x0060)] public uint TileSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionVertexColor
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMaterialExpressionVertexInterpolator
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionVertexNormalWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionVertexTangentWS
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionViewProperty
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EMaterialExposedViewProperty Property;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionViewSize
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMaterialExpressionVirtualTextureFeatureSwitch
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public FExpressionInput No;
    [FieldOffset(0x0054)] public FExpressionInput Yes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialExpressionVolumetricAdvancedMaterialInput
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UMaterialExpressionVolumetricAdvancedMaterialOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionCustomOutput baseObj;
    [FieldOffset(0x0040)] public FExpressionInput PhaseG;
    [FieldOffset(0x0054)] public FExpressionInput PhaseG2;
    [FieldOffset(0x0068)] public FExpressionInput PhaseBlend;
    [FieldOffset(0x007C)] public FExpressionInput MultiScatteringContribution;
    [FieldOffset(0x0090)] public FExpressionInput MultiScatteringOcclusion;
    [FieldOffset(0x00A4)] public FExpressionInput MultiScatteringEccentricity;
    [FieldOffset(0x00B8)] public FExpressionInput ConservativeDensity;
    [FieldOffset(0x00CC)] public float ConstPhaseG;
    [FieldOffset(0x00D0)] public float ConstPhaseG2;
    [FieldOffset(0x00D4)] public float ConstPhaseBlend;
    [FieldOffset(0x00D8)] public bool PerSamplePhaseEvaluation;
    [FieldOffset(0x00DC)] public uint MultiScatteringApproximationOctaveCount;
    [FieldOffset(0x00E0)] public float ConstMultiScatteringContribution;
    [FieldOffset(0x00E4)] public float ConstMultiScatteringOcclusion;
    [FieldOffset(0x00E8)] public float ConstMultiScatteringEccentricity;
    [FieldOffset(0x00EC)] public bool bGroundContribution;
    [FieldOffset(0x00ED)] public bool bGrayScaleMaterial;
    [FieldOffset(0x00EE)] public bool bRayMarchVolumeShadow;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMaterialExpressionWorldPosition
{
    [FieldOffset(0x0000)] public UMaterialExpression baseObj;
    [FieldOffset(0x0040)] public EWorldPositionIncludedOffsets WorldPositionShaderOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialFunctionInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FGuid StateId;
    [FieldOffset(0x0038)] public EMaterialFunctionUsage MaterialFunctionUsage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialFunction
{
    [FieldOffset(0x0000)] public UMaterialFunctionInterface baseObj;
    [FieldOffset(0x0040)] public FString Description;
    [FieldOffset(0x0050)] public byte bExposeToLibrary;
    [FieldOffset(0x0050)] public byte bPrefixParameterNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMaterialFunctionInstance
{
    [FieldOffset(0x0000)] public UMaterialFunctionInterface baseObj;
    [FieldOffset(0x0040)] public UMaterialFunctionInterface* Parent;
    [FieldOffset(0x0048)] public UMaterialFunctionInterface* Base;
    [FieldOffset(0x0050)] public TArray<FScalarParameterValue> ScalarParameterValues;
    [FieldOffset(0x0060)] public TArray<FVectorParameterValue> VectorParameterValues;
    [FieldOffset(0x0070)] public TArray<FTextureParameterValue> TextureParameterValues;
    [FieldOffset(0x0080)] public TArray<FFontParameterValue> FontParameterValues;
    [FieldOffset(0x0090)] public TArray<FStaticSwitchParameter> StaticSwitchParameterValues;
    [FieldOffset(0x00A0)] public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameterValues;
    [FieldOffset(0x00B0)] public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialFunctionMaterialLayer
{
    [FieldOffset(0x0000)] public UMaterialFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMaterialFunctionMaterialLayerInstance
{
    [FieldOffset(0x0000)] public UMaterialFunctionInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMaterialFunctionMaterialLayerBlend
{
    [FieldOffset(0x0000)] public UMaterialFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMaterialFunctionMaterialLayerBlendInstance
{
    [FieldOffset(0x0000)] public UMaterialFunctionInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AMaterialInstanceActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public TArray<IntPtr> TargetActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct UMaterialInstanceDynamic
{
    [FieldOffset(0x0000)] public UMaterialInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UMaterialParameterCollection
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FGuid StateId;
    [FieldOffset(0x0038)] public TArray<FCollectionScalarParameter> ScalarParameters;
    [FieldOffset(0x0048)] public TArray<FCollectionVectorParameter> VectorParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UMaterialParameterCollectionInstance
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UMaterialParameterCollection* Collection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpGroupActorInfo
{
    [FieldOffset(0x0000)] public FName ObjectName;
    [FieldOffset(0x0008)] public TArray<IntPtr> Actors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCameraCutInfo
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public float Timestamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct AMatineeActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UInterpData* MatineeData;
    [FieldOffset(0x0228)] public FName MatineeControllerName;
    [FieldOffset(0x0230)] public float PlayRate;
    [FieldOffset(0x0234)] public byte bPlayOnLevelLoad;
    [FieldOffset(0x0234)] public byte bForceStartPos;
    [FieldOffset(0x0238)] public float ForceStartPosition;
    [FieldOffset(0x023C)] public byte bLooping;
    [FieldOffset(0x023C)] public byte bRewindOnPlay;
    [FieldOffset(0x023C)] public byte bNoResetOnRewind;
    [FieldOffset(0x023C)] public byte bRewindIfAlreadyPlaying;
    [FieldOffset(0x023C)] public byte bDisableRadioFilter;
    [FieldOffset(0x023C)] public byte bClientSideOnly;
    [FieldOffset(0x023C)] public byte bSkipUpdateIfNotVisible;
    [FieldOffset(0x023C)] public byte bIsSkippable;
    [FieldOffset(0x0240)] public int PreferredSplitScreenNum;
    [FieldOffset(0x0244)] public byte bDisableMovementInput;
    [FieldOffset(0x0244)] public byte bDisableLookAtInput;
    [FieldOffset(0x0244)] public byte bHidePlayer;
    [FieldOffset(0x0244)] public byte bHideHud;
    [FieldOffset(0x0248)] public TArray<FInterpGroupActorInfo> GroupActorInfos;
    [FieldOffset(0x0258)] public byte bShouldShowGore;
    [FieldOffset(0x0260)] public TArray<IntPtr> GroupInst;
    [FieldOffset(0x0270)] public TArray<FCameraCutInfo> CameraCuts;
    [FieldOffset(0x0280)] public byte bIsPlaying;
    [FieldOffset(0x0280)] public byte bReversePlayback;
    [FieldOffset(0x0280)] public byte bPaused;
    [FieldOffset(0x0280)] public byte bPendingStop;
    [FieldOffset(0x0284)] public float InterpPosition;
    [FieldOffset(0x028C)] public byte ReplicationForceIsPlaying;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AMatineeActorCameraAnim
{
    [FieldOffset(0x0000)] public AMatineeActor baseObj;
    [FieldOffset(0x02C8)] public UCameraAnim* CameraAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMatineeAnimInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMatineeInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AMeshMergeCullingVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMeshSimplificationSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FName MeshReductionModuleName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMeshVertexPainterKismetLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPurchaseInfo
{
    [FieldOffset(0x0000)] public FString Identifier;
    [FieldOffset(0x0010)] public FString DisplayName;
    [FieldOffset(0x0020)] public FString DisplayDescription;
    [FieldOffset(0x0030)] public FString DisplayPrice;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UMicroTransactionBase
{
    [FieldOffset(0x0000)] public UPlatformInterfaceBase baseObj;
    [FieldOffset(0x0038)] public TArray<FPurchaseInfo> AvailableProducts;
    [FieldOffset(0x0048)] public FString LastError;
    [FieldOffset(0x0058)] public FString LastErrorSolution;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UModelComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0468)] public UBodySetup* ModelBodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMorphTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public USkeletalMesh* BaseSkelMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavAgentInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UNavAreaBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UNavCollisionBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bIsDynamicObstacle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavEdgeProviderInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UNavigationDataChunk
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName NavigationDataName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavigationDataInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNavigationSystemBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FNavAgentSelector
{
    [FieldOffset(0x0000)] public byte bSupportsAgent0;
    [FieldOffset(0x0000)] public byte bSupportsAgent1;
    [FieldOffset(0x0000)] public byte bSupportsAgent2;
    [FieldOffset(0x0000)] public byte bSupportsAgent3;
    [FieldOffset(0x0000)] public byte bSupportsAgent4;
    [FieldOffset(0x0000)] public byte bSupportsAgent5;
    [FieldOffset(0x0000)] public byte bSupportsAgent6;
    [FieldOffset(0x0000)] public byte bSupportsAgent7;
    [FieldOffset(0x0001)] public byte bSupportsAgent8;
    [FieldOffset(0x0001)] public byte bSupportsAgent9;
    [FieldOffset(0x0001)] public byte bSupportsAgent10;
    [FieldOffset(0x0001)] public byte bSupportsAgent11;
    [FieldOffset(0x0001)] public byte bSupportsAgent12;
    [FieldOffset(0x0001)] public byte bSupportsAgent13;
    [FieldOffset(0x0001)] public byte bSupportsAgent14;
    [FieldOffset(0x0001)] public byte bSupportsAgent15;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNavigationSystemConfig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSoftClassPath NavigationSystemClass;
    [FieldOffset(0x0040)] public FNavAgentSelector SupportedAgentsMask;
    [FieldOffset(0x0044)] public FName DefaultAgentName;
    [FieldOffset(0x004C)] public byte bIsOverriden;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNullNavSysConfig
{
    [FieldOffset(0x0000)] public UNavigationSystemConfig baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNavigationLinkBase
{
    [FieldOffset(0x0000)] public float LeftProjectHeight;
    [FieldOffset(0x0004)] public float MaxFallDownLength;
    [FieldOffset(0x000C)] public float SnapRadius;
    [FieldOffset(0x0010)] public float SnapHeight;
    [FieldOffset(0x0014)] public FNavAgentSelector SupportedAgents;
    [FieldOffset(0x0018)] public byte bSupportsAgent0;
    [FieldOffset(0x0018)] public byte bSupportsAgent1;
    [FieldOffset(0x0018)] public byte bSupportsAgent2;
    [FieldOffset(0x0018)] public byte bSupportsAgent3;
    [FieldOffset(0x0018)] public byte bSupportsAgent4;
    [FieldOffset(0x0018)] public byte bSupportsAgent5;
    [FieldOffset(0x0018)] public byte bSupportsAgent6;
    [FieldOffset(0x0018)] public byte bSupportsAgent7;
    [FieldOffset(0x0019)] public byte bSupportsAgent8;
    [FieldOffset(0x0019)] public byte bSupportsAgent9;
    [FieldOffset(0x0019)] public byte bSupportsAgent10;
    [FieldOffset(0x0019)] public byte bSupportsAgent11;
    [FieldOffset(0x0019)] public byte bSupportsAgent12;
    [FieldOffset(0x0019)] public byte bSupportsAgent13;
    [FieldOffset(0x0019)] public byte bSupportsAgent14;
    [FieldOffset(0x0019)] public byte bSupportsAgent15;
    [FieldOffset(0x001C)] public ENavLinkDirection Direction;
    [FieldOffset(0x001D)] public byte bUseSnapHeight;
    [FieldOffset(0x001D)] public byte bSnapToCheapestArea;
    [FieldOffset(0x001D)] public byte bCustomFlag0;
    [FieldOffset(0x001D)] public byte bCustomFlag1;
    [FieldOffset(0x001D)] public byte bCustomFlag2;
    [FieldOffset(0x001D)] public byte bCustomFlag3;
    [FieldOffset(0x001D)] public byte bCustomFlag4;
    [FieldOffset(0x001D)] public byte bCustomFlag5;
    [FieldOffset(0x001E)] public byte bCustomFlag6;
    [FieldOffset(0x001E)] public byte bCustomFlag7;
    [FieldOffset(0x0020)] public TSubclassOf<UNavAreaBase> AreaClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FNavigationLink
{
    [FieldOffset(0x0000)] public FNavigationLinkBase baseObj;
    [FieldOffset(0x0030)] public FVector Left;
    [FieldOffset(0x003C)] public FVector Right;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FNavigationSegmentLink
{
    [FieldOffset(0x0000)] public FNavigationLinkBase baseObj;
    [FieldOffset(0x0030)] public FVector LeftStart;
    [FieldOffset(0x003C)] public FVector LeftEnd;
    [FieldOffset(0x0048)] public FVector RightStart;
    [FieldOffset(0x0054)] public FVector RightEnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UNavLinkDefinition
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FNavigationLink> Links;
    [FieldOffset(0x0038)] public TArray<FNavigationSegmentLink> SegmentLinks;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavPathObserverInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INavRelevantInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1BA8)] 
public unsafe struct USimulatedClientNetConnection
{
    [FieldOffset(0x0000)] public UNetConnection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNetPushModelHelpers
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INetworkPredictionInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNetworkEmulationProfileDescription
{
    [FieldOffset(0x0000)] public FString ProfileName;
    [FieldOffset(0x0010)] public FString Tooltip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNetworkSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public byte bVerifyPeer;
    [FieldOffset(0x0038)] public byte bEnableMultiplayerWorldOriginRebasing;
    [FieldOffset(0x003C)] public int MaxRepArraySize;
    [FieldOffset(0x0040)] public int MaxRepArrayMemory;
    [FieldOffset(0x0048)] public TArray<FNetworkEmulationProfileDescription> NetworkEmulationProfiles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNodeItem
{
    [FieldOffset(0x0000)] public FName ParentName;
    [FieldOffset(0x0010)] public FTransform Transform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UNodeMappingContainer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TMap<FName, FNodeItem> SourceItems;
    [FieldOffset(0x0078)] public TMap<FName, FNodeItem> TargetItems;
    [FieldOffset(0x00C8)] public TMap<FName, FName> SourceToTarget;
    [FieldOffset(0x0118)] public TSoftObjectPtr<UObject> SourceAsset;
    [FieldOffset(0x0140)] public TSoftObjectPtr<UObject> TargetAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INodeMappingProviderInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ANote
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UObjectLibrary
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClass* ObjectBaseClass;
    [FieldOffset(0x0030)] public bool bHasBlueprintClasses;
    [FieldOffset(0x0038)] public TArray<IntPtr> objects;
    [FieldOffset(0x0048)] public TArray<TWeakObjectPtr<UObject>> WeakObjects;
    [FieldOffset(0x0058)] public bool bUseWeakReferences;
    [FieldOffset(0x0059)] public bool bIsFullyLoaded;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UObjectReferencer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> ReferencedObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UObjectTraceWorldSubsystem
{
    [FieldOffset(0x0000)] public UWorldSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x408)] 
public unsafe struct UPackageMapClient
{
    [FieldOffset(0x0000)] public UPackageMap baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct APainCausingVolume
{
    [FieldOffset(0x0000)] public APhysicsVolume baseObj;
    [FieldOffset(0x0268)] public byte bPainCausing;
    [FieldOffset(0x026C)] public float DamagePerSec;
    [FieldOffset(0x0270)] public TSubclassOf<UDamageType> DamageType;
    [FieldOffset(0x0278)] public float PainInterval;
    [FieldOffset(0x027C)] public byte bEntryPain;
    [FieldOffset(0x027C)] public byte BACKUP_bPainCausing;
    [FieldOffset(0x0280)] public AController* DamageInstigator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UParticleEmitter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName EmitterName;
    [FieldOffset(0x0030)] public int SubUVDataOffset;
    [FieldOffset(0x0034)] public EEmitterRenderMode EmitterRenderMode;
    [FieldOffset(0x0035)] public EParticleSignificanceLevel SignificanceLevel;
    [FieldOffset(0x0037)] public byte bUseLegacySpawningBehavior;
    [FieldOffset(0x0037)] public byte ConvertedModules;
    [FieldOffset(0x0037)] public byte bIsSoloing;
    [FieldOffset(0x0037)] public byte bCookedOut;
    [FieldOffset(0x0037)] public byte bDisabledLODsKeepEmitterAlive;
    [FieldOffset(0x0038)] public byte bDisableWhenInsignficant;
    [FieldOffset(0x0040)] public TArray<IntPtr> LODLevels;
    [FieldOffset(0x0050)] public int PeakActiveParticles;
    [FieldOffset(0x0054)] public int InitialAllocationCount;
    [FieldOffset(0x0058)] public float QualityLevelSpawnRateScale;
    [FieldOffset(0x005C)] public uint DetailModeBitmask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AParticleEventManager
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UParticleLODLevel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int Level;
    [FieldOffset(0x002C)] public byte bEnabled;
    [FieldOffset(0x0030)] public UParticleModuleRequired* RequiredModule;
    [FieldOffset(0x0038)] public TArray<IntPtr> Modules;
    [FieldOffset(0x0048)] public UParticleModuleTypeDataBase* TypeDataModule;
    [FieldOffset(0x0050)] public UParticleModuleSpawn* SpawnModule;
    [FieldOffset(0x0058)] public UParticleModuleEventGenerator* EventGenerator;
    [FieldOffset(0x0060)] public TArray<IntPtr> SpawningModules;
    [FieldOffset(0x0070)] public TArray<IntPtr> SpawnModules;
    [FieldOffset(0x0080)] public TArray<IntPtr> UpdateModules;
    [FieldOffset(0x0090)] public TArray<IntPtr> OrbitModules;
    [FieldOffset(0x00A0)] public TArray<IntPtr> EventReceiverModules;
    [FieldOffset(0x00B0)] public byte ConvertedModules;
    [FieldOffset(0x00B4)] public int PeakActiveParticles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FParticleSystemLOD
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLODSoloTrack
{
    [FieldOffset(0x0000)] public TArray<byte> SoloEnableSetting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNamedEmitterMaterial
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UParticleSystem
{
    [FieldOffset(0x0000)] public UFXSystemAsset baseObj;
    [FieldOffset(0x0030)] public float UpdateTime_FPS;
    [FieldOffset(0x0034)] public float UpdateTime_Delta;
    [FieldOffset(0x0038)] public float WarmupTime;
    [FieldOffset(0x003C)] public float WarmupTickRate;
    [FieldOffset(0x0040)] public TArray<IntPtr> Emitters;
    [FieldOffset(0x0050)] public UParticleSystemComponent* PreviewComponent;
    [FieldOffset(0x0058)] public UInterpCurveEdSetup* CurveEdSetup;
    [FieldOffset(0x0060)] public float LODDistanceCheckTime;
    [FieldOffset(0x0064)] public float MacroUVRadius;
    [FieldOffset(0x0068)] public TArray<float> LODDistances;
    [FieldOffset(0x0078)] public TArray<FParticleSystemLOD> LODSettings;
    [FieldOffset(0x0088)] public FBox FixedRelativeBoundingBox;
    [FieldOffset(0x00A4)] public float SecondsBeforeInactive;
    [FieldOffset(0x00A8)] public float Delay;
    [FieldOffset(0x00AC)] public float DelayLow;
    [FieldOffset(0x00B0)] public byte bOrientZAxisTowardCamera;
    [FieldOffset(0x00B0)] public byte bUseFixedRelativeBoundingBox;
    [FieldOffset(0x00B0)] public byte bShouldResetPeakCounts;
    [FieldOffset(0x00B0)] public byte bHasPhysics;
    [FieldOffset(0x00B0)] public byte bUseRealtimeThumbnail;
    [FieldOffset(0x00B0)] public byte ThumbnailImageOutOfDate;
    [FieldOffset(0x00B1)] public byte bUseDelayRange;
    [FieldOffset(0x00B1)] public byte bAllowManagedTicking;
    [FieldOffset(0x00B1)] public byte bAutoDeactivate;
    [FieldOffset(0x00B1)] public byte bRegenerateLODDuplicate;
    [FieldOffset(0x00B2)] public EParticleSystemUpdateMode SystemUpdateMode;
    [FieldOffset(0x00B3)] public ParticleSystemLODMethod LODMethod;
    [FieldOffset(0x00B4)] public EParticleSystemInsignificanceReaction InsignificantReaction;
    [FieldOffset(0x00B5)] public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod;
    [FieldOffset(0x00B7)] public EParticleSignificanceLevel MaxSignificanceLevel;
    [FieldOffset(0x00B8)] public uint MinTimeBetweenTicks;
    [FieldOffset(0x00BC)] public float InsignificanceDelay;
    [FieldOffset(0x00C0)] public FVector MacroUVPosition;
    [FieldOffset(0x00CC)] public FBox CustomOcclusionBounds;
    [FieldOffset(0x00E8)] public TArray<FLODSoloTrack> SoloTracking;
    [FieldOffset(0x00F8)] public TArray<FNamedEmitterMaterial> NamedMaterialSlots;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModule
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bSpawnModule;
    [FieldOffset(0x0028)] public byte bUpdateModule;
    [FieldOffset(0x0028)] public byte bFinalUpdateModule;
    [FieldOffset(0x0028)] public byte bUpdateForGPUEmitter;
    [FieldOffset(0x0028)] public byte bCurvesAsColor;
    [FieldOffset(0x0028)] public byte b3DDrawMode;
    [FieldOffset(0x0028)] public byte bSupported3DDrawMode;
    [FieldOffset(0x0028)] public byte bEnabled;
    [FieldOffset(0x0029)] public byte bEditable;
    [FieldOffset(0x0029)] public byte LODDuplicate;
    [FieldOffset(0x0029)] public byte bSupportsRandomSeed;
    [FieldOffset(0x0029)] public byte bRequiresLoopingNotification;
    [FieldOffset(0x002A)] public byte LODValidity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleAccelerationBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
    [FieldOffset(0x0030)] public byte bAlwaysInWorldSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDistributionLookupTable
{
    [FieldOffset(0x0000)] public float TimeScale;
    [FieldOffset(0x0004)] public float TimeBias;
    [FieldOffset(0x0008)] public TArray<float> Values;
    [FieldOffset(0x0018)] public byte Op;
    [FieldOffset(0x0019)] public byte EntryCount;
    [FieldOffset(0x001A)] public byte EntryStride;
    [FieldOffset(0x001B)] public byte SubEntryStride;
    [FieldOffset(0x001C)] public byte LockFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRawDistribution
{
    [FieldOffset(0x0000)] public FDistributionLookupTable Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FRawDistributionVector
{
    [FieldOffset(0x0000)] public FRawDistribution baseObj;
    [FieldOffset(0x0020)] public float MinValue;
    [FieldOffset(0x0024)] public float MaxValue;
    [FieldOffset(0x0028)] public FVector MinValueVec;
    [FieldOffset(0x0034)] public FVector MaxValueVec;
    [FieldOffset(0x0040)] public UDistributionVector* Distribution;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UParticleModuleAcceleration
{
    [FieldOffset(0x0000)] public UParticleModuleAccelerationBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionVector Acceleration;
    [FieldOffset(0x0080)] public byte bApplyOwnerScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UParticleModuleAccelerationConstant
{
    [FieldOffset(0x0000)] public UParticleModuleAccelerationBase baseObj;
    [FieldOffset(0x0038)] public FVector Acceleration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FRawDistributionFloat
{
    [FieldOffset(0x0000)] public FRawDistribution baseObj;
    [FieldOffset(0x0020)] public float MinValue;
    [FieldOffset(0x0024)] public float MaxValue;
    [FieldOffset(0x0028)] public UDistributionFloat* Distribution;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UParticleModuleAccelerationDrag
{
    [FieldOffset(0x0000)] public UParticleModuleAccelerationBase baseObj;
    [FieldOffset(0x0038)] public UDistributionFloat* DragCoefficient;
    [FieldOffset(0x0040)] public FRawDistributionFloat DragCoefficientRaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UParticleModuleAccelerationDragScaleOverLife
{
    [FieldOffset(0x0000)] public UParticleModuleAccelerationBase baseObj;
    [FieldOffset(0x0038)] public UDistributionFloat* DragScale;
    [FieldOffset(0x0040)] public FRawDistributionFloat DragScaleRaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleAccelerationOverLifetime
{
    [FieldOffset(0x0000)] public UParticleModuleAccelerationBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionVector AccelOverLife;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleAttractorBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UParticleModuleAttractorLine
{
    [FieldOffset(0x0000)] public UParticleModuleAttractorBase baseObj;
    [FieldOffset(0x0030)] public FVector EndPoint0;
    [FieldOffset(0x003C)] public FVector EndPoint1;
    [FieldOffset(0x0048)] public FRawDistributionFloat Range;
    [FieldOffset(0x0078)] public FRawDistributionFloat Strength;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleAttractorParticle
{
    [FieldOffset(0x0000)] public UParticleModuleAttractorBase baseObj;
    [FieldOffset(0x0030)] public FName EmitterName;
    [FieldOffset(0x0038)] public FRawDistributionFloat Range;
    [FieldOffset(0x0068)] public byte bStrengthByDistance;
    [FieldOffset(0x0070)] public FRawDistributionFloat Strength;
    [FieldOffset(0x00A0)] public byte bAffectBaseVelocity;
    [FieldOffset(0x00A4)] public EAttractorParticleSelectionMethod SelectionMethod;
    [FieldOffset(0x00A8)] public byte bRenewSource;
    [FieldOffset(0x00A8)] public byte bInheritSourceVel;
    [FieldOffset(0x00AC)] public int LastSelIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UParticleModuleAttractorPoint
{
    [FieldOffset(0x0000)] public UParticleModuleAttractorBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector Position;
    [FieldOffset(0x0078)] public FRawDistributionFloat Range;
    [FieldOffset(0x00A8)] public FRawDistributionFloat Strength;
    [FieldOffset(0x00D8)] public byte StrengthByDistance;
    [FieldOffset(0x00D8)] public byte bAffectBaseVelocity;
    [FieldOffset(0x00D8)] public byte bOverrideVelocity;
    [FieldOffset(0x00D8)] public byte bUseWorldSpacePosition;
    [FieldOffset(0x00D8)] public byte Positive_X;
    [FieldOffset(0x00D8)] public byte Positive_Y;
    [FieldOffset(0x00D8)] public byte Positive_Z;
    [FieldOffset(0x00D8)] public byte Negative_X;
    [FieldOffset(0x00D9)] public byte Negative_Y;
    [FieldOffset(0x00D9)] public byte Negative_Z;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleAttractorPointGravity
{
    [FieldOffset(0x0000)] public UParticleModuleAttractorBase baseObj;
    [FieldOffset(0x0030)] public FVector Position;
    [FieldOffset(0x003C)] public float Radius;
    [FieldOffset(0x0040)] public UDistributionFloat* Strength;
    [FieldOffset(0x0048)] public FRawDistributionFloat StrengthRaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleBeamBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FBeamModifierOptions
{
    [FieldOffset(0x0000)] public byte bModify;
    [FieldOffset(0x0000)] public byte bScale;
    [FieldOffset(0x0000)] public byte bLock;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UParticleModuleBeamModifier
{
    [FieldOffset(0x0000)] public UParticleModuleBeamBase baseObj;
    [FieldOffset(0x0030)] public BeamModifierType ModifierType;
    [FieldOffset(0x0034)] public FBeamModifierOptions PositionOptions;
    [FieldOffset(0x0038)] public FRawDistributionVector Position;
    [FieldOffset(0x0080)] public FBeamModifierOptions TangentOptions;
    [FieldOffset(0x0088)] public FRawDistributionVector Tangent;
    [FieldOffset(0x00D0)] public byte bAbsoluteTangent;
    [FieldOffset(0x00D4)] public FBeamModifierOptions StrengthOptions;
    [FieldOffset(0x00D8)] public FRawDistributionFloat Strength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UParticleModuleBeamNoise
{
    [FieldOffset(0x0000)] public UParticleModuleBeamBase baseObj;
    [FieldOffset(0x0030)] public byte bLowFreq_Enabled;
    [FieldOffset(0x0034)] public int Frequency;
    [FieldOffset(0x0038)] public int Frequency_LowRange;
    [FieldOffset(0x0040)] public FRawDistributionVector NoiseRange;
    [FieldOffset(0x0088)] public FRawDistributionFloat NoiseRangeScale;
    [FieldOffset(0x00B8)] public byte bNRScaleEmitterTime;
    [FieldOffset(0x00C0)] public FRawDistributionVector NoiseSpeed;
    [FieldOffset(0x0108)] public byte bSmooth;
    [FieldOffset(0x010C)] public float NoiseLockRadius;
    [FieldOffset(0x0110)] public byte bNoiseLock;
    [FieldOffset(0x0110)] public byte bOscillate;
    [FieldOffset(0x0114)] public float NoiseLockTime;
    [FieldOffset(0x0118)] public float NoiseTension;
    [FieldOffset(0x011C)] public byte bUseNoiseTangents;
    [FieldOffset(0x0120)] public FRawDistributionFloat NoiseTangentStrength;
    [FieldOffset(0x0150)] public int NoiseTessellation;
    [FieldOffset(0x0154)] public byte bTargetNoise;
    [FieldOffset(0x0158)] public float FrequencyDistance;
    [FieldOffset(0x015C)] public byte bApplyNoiseScale;
    [FieldOffset(0x0160)] public FRawDistributionFloat NoiseScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UParticleModuleBeamSource
{
    [FieldOffset(0x0000)] public UParticleModuleBeamBase baseObj;
    [FieldOffset(0x0030)] public Beam2SourceTargetMethod SourceMethod;
    [FieldOffset(0x0034)] public FName SourceName;
    [FieldOffset(0x003C)] public byte bSourceAbsolute;
    [FieldOffset(0x0040)] public FRawDistributionVector Source;
    [FieldOffset(0x0088)] public byte bLockSource;
    [FieldOffset(0x008C)] public Beam2SourceTargetTangentMethod SourceTangentMethod;
    [FieldOffset(0x0090)] public FRawDistributionVector SourceTangent;
    [FieldOffset(0x00D8)] public byte bLockSourceTangent;
    [FieldOffset(0x00E0)] public FRawDistributionFloat SourceStrength;
    [FieldOffset(0x0110)] public byte bLockSourceStength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UParticleModuleBeamTarget
{
    [FieldOffset(0x0000)] public UParticleModuleBeamBase baseObj;
    [FieldOffset(0x0030)] public Beam2SourceTargetMethod TargetMethod;
    [FieldOffset(0x0034)] public FName TargetName;
    [FieldOffset(0x0040)] public FRawDistributionVector Target;
    [FieldOffset(0x0088)] public byte bTargetAbsolute;
    [FieldOffset(0x0088)] public byte bLockTarget;
    [FieldOffset(0x008C)] public Beam2SourceTargetTangentMethod TargetTangentMethod;
    [FieldOffset(0x0090)] public FRawDistributionVector TargetTangent;
    [FieldOffset(0x00D8)] public byte bLockTargetTangent;
    [FieldOffset(0x00E0)] public FRawDistributionFloat TargetStrength;
    [FieldOffset(0x0110)] public byte bLockTargetStength;
    [FieldOffset(0x0114)] public float LockRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleCameraBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleCameraOffset
{
    [FieldOffset(0x0000)] public UParticleModuleCameraBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat CameraOffset;
    [FieldOffset(0x0060)] public byte bSpawnTimeOnly;
    [FieldOffset(0x0064)] public EParticleCameraOffsetUpdateMethod UpdateMethod;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleCollisionBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UParticleModuleCollision
{
    [FieldOffset(0x0000)] public UParticleModuleCollisionBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector DampingFactor;
    [FieldOffset(0x0078)] public FRawDistributionVector DampingFactorRotation;
    [FieldOffset(0x00C0)] public FRawDistributionFloat MaxCollisions;
    [FieldOffset(0x00F0)] public EParticleCollisionComplete CollisionCompletionOption;
    [FieldOffset(0x00F8)] public TArray<EObjectTypeQuery> CollisionTypes;
    [FieldOffset(0x0110)] public byte bApplyPhysics;
    [FieldOffset(0x0110)] public byte bIgnoreTriggerVolumes;
    [FieldOffset(0x0118)] public FRawDistributionFloat ParticleMass;
    [FieldOffset(0x0148)] public float DirScalar;
    [FieldOffset(0x014C)] public byte bPawnsDoNotDecrementCount;
    [FieldOffset(0x014C)] public byte bOnlyVerticalNormalsDecrementCount;
    [FieldOffset(0x0150)] public float VerticalFudgeFactor;
    [FieldOffset(0x0158)] public FRawDistributionFloat DelayAmount;
    [FieldOffset(0x0188)] public byte bDropDetail;
    [FieldOffset(0x0188)] public byte bCollideOnlyIfVisible;
    [FieldOffset(0x0188)] public byte bIgnoreSourceActor;
    [FieldOffset(0x018C)] public float MaxCollisionDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UParticleModuleCollisionGPU
{
    [FieldOffset(0x0000)] public UParticleModuleCollisionBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat Resilience;
    [FieldOffset(0x0060)] public FRawDistributionFloat ResilienceScaleOverLife;
    [FieldOffset(0x0090)] public float Friction;
    [FieldOffset(0x0094)] public float RandomSpread;
    [FieldOffset(0x0098)] public float RandomDistribution;
    [FieldOffset(0x009C)] public float RadiusScale;
    [FieldOffset(0x00A0)] public float RadiusBias;
    [FieldOffset(0x00A4)] public EParticleCollisionResponse Response;
    [FieldOffset(0x00A5)] public EParticleCollisionMode CollisionMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleColorBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleColor
{
    [FieldOffset(0x0000)] public UParticleModuleColorBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartColor;
    [FieldOffset(0x0078)] public FRawDistributionFloat StartAlpha;
    [FieldOffset(0x00A8)] public byte bClampAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FParticleRandomSeedInfo
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public byte bGetSeedFromInstance;
    [FieldOffset(0x0008)] public byte bInstanceSeedIsIndex;
    [FieldOffset(0x0008)] public byte bResetSeedOnEmitterLooping;
    [FieldOffset(0x0008)] public byte bRandomlySelectSeedArray;
    [FieldOffset(0x0010)] public TArray<int> RandomSeeds;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UParticleModuleColor_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleColor baseObj;
    [FieldOffset(0x00B0)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleColorOverLife
{
    [FieldOffset(0x0000)] public UParticleModuleColorBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector ColorOverLife;
    [FieldOffset(0x0078)] public FRawDistributionFloat AlphaOverLife;
    [FieldOffset(0x00A8)] public byte bClampAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleColorScaleOverLife
{
    [FieldOffset(0x0000)] public UParticleModuleColorBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector ColorScaleOverLife;
    [FieldOffset(0x0078)] public FRawDistributionFloat AlphaScaleOverLife;
    [FieldOffset(0x00A8)] public byte bEmitterTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleEventBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FParticleEvent_GenerateInfo
{
    [FieldOffset(0x0000)] public EParticleEventType Type;
    [FieldOffset(0x0004)] public int Frequency;
    [FieldOffset(0x0008)] public int ParticleFrequency;
    [FieldOffset(0x000C)] public byte FirstTimeOnly;
    [FieldOffset(0x000C)] public byte LastTimeOnly;
    [FieldOffset(0x000C)] public byte UseReflectedImpactVector;
    [FieldOffset(0x000C)] public byte bUseOrbitOffset;
    [FieldOffset(0x0010)] public FName CustomName;
    [FieldOffset(0x0018)] public TArray<IntPtr> ParticleModuleEventsToSendToGame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleEventGenerator
{
    [FieldOffset(0x0000)] public UParticleModuleEventBase baseObj;
    [FieldOffset(0x0030)] public TArray<FParticleEvent_GenerateInfo> Events;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleEventReceiverBase
{
    [FieldOffset(0x0000)] public UParticleModuleEventBase baseObj;
    [FieldOffset(0x0030)] public EParticleEventType EventGeneratorType;
    [FieldOffset(0x0034)] public FName EventName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UParticleModuleEventReceiverKillParticles
{
    [FieldOffset(0x0000)] public UParticleModuleEventReceiverBase baseObj;
    [FieldOffset(0x0040)] public byte bStopSpawning;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UParticleModuleEventReceiverSpawn
{
    [FieldOffset(0x0000)] public UParticleModuleEventReceiverBase baseObj;
    [FieldOffset(0x0040)] public FRawDistributionFloat SpawnCount;
    [FieldOffset(0x0070)] public byte bUseParticleTime;
    [FieldOffset(0x0070)] public byte bUsePSysLocation;
    [FieldOffset(0x0070)] public byte bInheritVelocity;
    [FieldOffset(0x0078)] public FRawDistributionVector InheritVelocityScale;
    [FieldOffset(0x00C0)] public TArray<IntPtr> PhysicalMaterials;
    [FieldOffset(0x00D0)] public byte bBanPhysicalMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UParticleModuleEventSendToGame
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleKillBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UParticleModuleKillBox
{
    [FieldOffset(0x0000)] public UParticleModuleKillBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector LowerLeftCorner;
    [FieldOffset(0x0078)] public FRawDistributionVector UpperRightCorner;
    [FieldOffset(0x00C0)] public byte bAbsolute;
    [FieldOffset(0x00C0)] public byte bKillInside;
    [FieldOffset(0x00C0)] public byte bAxisAlignedAndFixedSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleKillHeight
{
    [FieldOffset(0x0000)] public UParticleModuleKillBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat Height;
    [FieldOffset(0x0060)] public byte bAbsolute;
    [FieldOffset(0x0060)] public byte bFloor;
    [FieldOffset(0x0060)] public byte bApplyPSysScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleLifetimeBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UParticleModuleLifetime
{
    [FieldOffset(0x0000)] public UParticleModuleLifetimeBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat LifeTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleLifetime_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLifetime baseObj;
    [FieldOffset(0x0060)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleLightBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UParticleModuleLight
{
    [FieldOffset(0x0000)] public UParticleModuleLightBase baseObj;
    [FieldOffset(0x0030)] public bool bUseInverseSquaredFalloff;
    [FieldOffset(0x0031)] public bool bAffectsTranslucency;
    [FieldOffset(0x0032)] public bool bPreviewLightRadius;
    [FieldOffset(0x0034)] public float SpawnFraction;
    [FieldOffset(0x0038)] public FRawDistributionVector ColorScaleOverLife;
    [FieldOffset(0x0080)] public FRawDistributionFloat BrightnessOverLife;
    [FieldOffset(0x00B0)] public FRawDistributionFloat RadiusScale;
    [FieldOffset(0x00E0)] public FRawDistributionFloat LightExponent;
    [FieldOffset(0x0110)] public FLightingChannels LightingChannels;
    [FieldOffset(0x0114)] public float VolumetricScatteringIntensity;
    [FieldOffset(0x0118)] public bool bHighQualityLights;
    [FieldOffset(0x0119)] public bool bShadowCastingLights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UParticleModuleLight_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLight baseObj;
    [FieldOffset(0x0120)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleLocationBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleLocation
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartLocation;
    [FieldOffset(0x0078)] public float DistributeOverNPoints;
    [FieldOffset(0x007C)] public float DistributeThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UParticleModuleLocation_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLocation baseObj;
    [FieldOffset(0x0080)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FLocationBoneSocketInfo
{
    [FieldOffset(0x0000)] public FName BoneSocketName;
    [FieldOffset(0x0008)] public FVector Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UParticleModuleLocationBoneSocket
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public ELocationBoneSocketSource SourceType;
    [FieldOffset(0x0034)] public FVector UniversalOffset;
    [FieldOffset(0x0040)] public TArray<FLocationBoneSocketInfo> SourceLocations;
    [FieldOffset(0x0050)] public ELocationBoneSocketSelectionMethod SelectionMethod;
    [FieldOffset(0x0054)] public byte bUpdatePositionEachFrame;
    [FieldOffset(0x0054)] public byte bOrientMeshEmitters;
    [FieldOffset(0x0054)] public byte bInheritBoneVelocity;
    [FieldOffset(0x0058)] public float InheritVelocityScale;
    [FieldOffset(0x005C)] public FName SkelMeshActorParamName;
    [FieldOffset(0x0064)] public int NumPreSelectedIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UParticleModuleLocationDirect
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector Location;
    [FieldOffset(0x0078)] public FRawDistributionVector LocationOffset;
    [FieldOffset(0x00C0)] public FRawDistributionVector ScaleFactor;
    [FieldOffset(0x0108)] public FRawDistributionVector Direction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UParticleModuleLocationEmitter
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FName EmitterName;
    [FieldOffset(0x0038)] public ELocationEmitterSelectionMethod SelectionMethod;
    [FieldOffset(0x003C)] public byte InheritSourceVelocity;
    [FieldOffset(0x0040)] public float InheritSourceVelocityScale;
    [FieldOffset(0x0044)] public byte bInheritSourceRotation;
    [FieldOffset(0x0048)] public float InheritSourceRotationScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleLocationEmitterDirect
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FName EmitterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleLocationPrimitiveBase
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public byte Positive_X;
    [FieldOffset(0x0030)] public byte Positive_Y;
    [FieldOffset(0x0030)] public byte Positive_Z;
    [FieldOffset(0x0030)] public byte Negative_X;
    [FieldOffset(0x0030)] public byte Negative_Y;
    [FieldOffset(0x0030)] public byte Negative_Z;
    [FieldOffset(0x0030)] public byte SurfaceOnly;
    [FieldOffset(0x0030)] public byte Velocity;
    [FieldOffset(0x0038)] public FRawDistributionFloat VelocityScale;
    [FieldOffset(0x0068)] public FRawDistributionVector StartLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UParticleModuleLocationPrimitiveCylinder
{
    [FieldOffset(0x0000)] public UParticleModuleLocationPrimitiveBase baseObj;
    [FieldOffset(0x00B0)] public byte RadialVelocity;
    [FieldOffset(0x00B8)] public FRawDistributionFloat StartRadius;
    [FieldOffset(0x00E8)] public FRawDistributionFloat StartHeight;
    [FieldOffset(0x0118)] public CylinderHeightAxis HeightAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UParticleModuleLocationPrimitiveCylinder_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLocationPrimitiveCylinder baseObj;
    [FieldOffset(0x0120)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UParticleModuleLocationPrimitiveSphere
{
    [FieldOffset(0x0000)] public UParticleModuleLocationPrimitiveBase baseObj;
    [FieldOffset(0x00B0)] public FRawDistributionFloat StartRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UParticleModuleLocationPrimitiveSphere_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLocationPrimitiveSphere baseObj;
    [FieldOffset(0x00E0)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UParticleModuleLocationPrimitiveTriangle
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartOffset;
    [FieldOffset(0x0078)] public FRawDistributionFloat Height;
    [FieldOffset(0x00A8)] public FRawDistributionFloat Angle;
    [FieldOffset(0x00D8)] public FRawDistributionFloat Thickness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UParticleModuleLocationSkelVertSurface
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public ELocationSkelVertSurfaceSource SourceType;
    [FieldOffset(0x0034)] public FVector UniversalOffset;
    [FieldOffset(0x0040)] public byte bUpdatePositionEachFrame;
    [FieldOffset(0x0040)] public byte bOrientMeshEmitters;
    [FieldOffset(0x0040)] public byte bInheritBoneVelocity;
    [FieldOffset(0x0044)] public float InheritVelocityScale;
    [FieldOffset(0x0048)] public FName SkelMeshActorParamName;
    [FieldOffset(0x0050)] public TArray<FName> ValidAssociatedBones;
    [FieldOffset(0x0060)] public byte bEnforceNormalCheck;
    [FieldOffset(0x0064)] public FVector NormalToCompare;
    [FieldOffset(0x0070)] public float NormalCheckToleranceDegrees;
    [FieldOffset(0x0074)] public float NormalCheckTolerance;
    [FieldOffset(0x0078)] public TArray<int> ValidMaterialIndices;
    [FieldOffset(0x0088)] public byte bInheritVertexColor;
    [FieldOffset(0x0088)] public byte bInheritUV;
    [FieldOffset(0x008C)] public uint InheritUVChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleLocationWorldOffset
{
    [FieldOffset(0x0000)] public UParticleModuleLocation baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UParticleModuleLocationWorldOffset_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleLocationWorldOffset baseObj;
    [FieldOffset(0x0080)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleMaterialBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleMeshMaterial
{
    [FieldOffset(0x0000)] public UParticleModuleMaterialBase baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> MeshMaterials;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleRotationBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleMeshRotation
{
    [FieldOffset(0x0000)] public UParticleModuleRotationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartRotation;
    [FieldOffset(0x0078)] public byte bInheritParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UParticleModuleMeshRotation_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleMeshRotation baseObj;
    [FieldOffset(0x0080)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleRotationRateBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleMeshRotationRate
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRateBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartRotationRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UParticleModuleMeshRotationRate_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleMeshRotationRate baseObj;
    [FieldOffset(0x0078)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleMeshRotationRateMultiplyLife
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRateBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector LifeMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleMeshRotationRateOverLife
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRateBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector RotRate;
    [FieldOffset(0x0078)] public byte bScaleRotRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleOrbitBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
    [FieldOffset(0x0030)] public byte bUseEmitterTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FOrbitOptions
{
    [FieldOffset(0x0000)] public byte bProcessDuringSpawn;
    [FieldOffset(0x0000)] public byte bProcessDuringUpdate;
    [FieldOffset(0x0000)] public byte bUseEmitterTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UParticleModuleOrbit
{
    [FieldOffset(0x0000)] public UParticleModuleOrbitBase baseObj;
    [FieldOffset(0x0038)] public EOrbitChainMode ChainMode;
    [FieldOffset(0x0040)] public FRawDistributionVector OffsetAmount;
    [FieldOffset(0x0088)] public FOrbitOptions OffsetOptions;
    [FieldOffset(0x0090)] public FRawDistributionVector RotationAmount;
    [FieldOffset(0x00D8)] public FOrbitOptions RotationOptions;
    [FieldOffset(0x00E0)] public FRawDistributionVector RotationRateAmount;
    [FieldOffset(0x0128)] public FOrbitOptions RotationRateOptions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleOrientationBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleOrientationAxisLock
{
    [FieldOffset(0x0000)] public UParticleModuleOrientationBase baseObj;
    [FieldOffset(0x0030)] public EParticleAxisLock LockAxisFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleParameterBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FEmitterDynamicParameter
{
    [FieldOffset(0x0000)] public FName ParamName;
    [FieldOffset(0x0008)] public byte bUseEmitterTime;
    [FieldOffset(0x0008)] public byte bSpawnTimeOnly;
    [FieldOffset(0x000C)] public EEmitterDynamicParameterValue ValueMethod;
    [FieldOffset(0x0010)] public byte bScaleVelocityByParamValue;
    [FieldOffset(0x0018)] public FRawDistributionFloat ParamValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UParticleModuleParameterDynamic
{
    [FieldOffset(0x0000)] public UParticleModuleParameterBase baseObj;
    [FieldOffset(0x0030)] public TArray<FEmitterDynamicParameter> DynamicParams;
    [FieldOffset(0x0040)] public int UpdateFlags;
    [FieldOffset(0x0044)] public byte bUsesVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleParameterDynamic_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleParameterDynamic baseObj;
    [FieldOffset(0x0048)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModulePivotOffset
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FVector2D PivotOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FParticleBurst
{
    [FieldOffset(0x0000)] public int Count;
    [FieldOffset(0x0004)] public int CountLow;
    [FieldOffset(0x0008)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UParticleModuleRequired
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
    [FieldOffset(0x0030)] public UMaterialInterface* Material;
    [FieldOffset(0x0038)] public float MinFacingCameraBlendDistance;
    [FieldOffset(0x003C)] public float MaxFacingCameraBlendDistance;
    [FieldOffset(0x0040)] public FVector EmitterOrigin;
    [FieldOffset(0x004C)] public FRotator EmitterRotation;
    [FieldOffset(0x0058)] public EParticleScreenAlignment ScreenAlignment;
    [FieldOffset(0x0059)] public byte bUseLocalSpace;
    [FieldOffset(0x0059)] public byte bKillOnDeactivate;
    [FieldOffset(0x0059)] public byte bKillOnCompleted;
    [FieldOffset(0x005A)] public EParticleSortMode SortMode;
    [FieldOffset(0x005B)] public byte bUseLegacyEmitterTime;
    [FieldOffset(0x005B)] public byte bRemoveHMDRoll;
    [FieldOffset(0x005B)] public byte bEmitterDurationUseRange;
    [FieldOffset(0x005C)] public float EmitterDuration;
    [FieldOffset(0x0060)] public FRawDistributionFloat SpawnRate;
    [FieldOffset(0x0090)] public TArray<FParticleBurst> BurstList;
    [FieldOffset(0x00A0)] public float EmitterDelay;
    [FieldOffset(0x00A4)] public float EmitterDelayLow;
    [FieldOffset(0x00A8)] public byte bDelayFirstLoopOnly;
    [FieldOffset(0x00A9)] public EParticleSubUVInterpMethod InterpolationMethod;
    [FieldOffset(0x00AA)] public byte bScaleUV;
    [FieldOffset(0x00AA)] public byte bEmitterDelayUseRange;
    [FieldOffset(0x00AB)] public EParticleBurstMethod ParticleBurstMethod;
    [FieldOffset(0x00AC)] public byte bOverrideSystemMacroUV;
    [FieldOffset(0x00AC)] public byte bUseMaxDrawCount;
    [FieldOffset(0x00AD)] public EOpacitySourceMode OpacitySourceMode;
    [FieldOffset(0x00AE)] public EEmitterNormalsMode EmitterNormalsMode;
    [FieldOffset(0x00AF)] public byte bOrbitModuleAffectsVelocityAlignment;
    [FieldOffset(0x00B0)] public int SubImages_Horizontal;
    [FieldOffset(0x00B4)] public int SubImages_Vertical;
    [FieldOffset(0x00B8)] public float RandomImageTime;
    [FieldOffset(0x00BC)] public int RandomImageChanges;
    [FieldOffset(0x00C0)] public FVector MacroUVPosition;
    [FieldOffset(0x00CC)] public float MacroUVRadius;
    [FieldOffset(0x00D0)] public EParticleUVFlipMode UVFlippingMode;
    [FieldOffset(0x00D1)] public ESubUVBoundingVertexCount BoundingMode;
    [FieldOffset(0x00D2)] public byte bDurationRecalcEachLoop;
    [FieldOffset(0x00D4)] public FVector NormalsSphereCenter;
    [FieldOffset(0x00E0)] public float AlphaThreshold;
    [FieldOffset(0x00E4)] public int EmitterLoops;
    [FieldOffset(0x00E8)] public UTexture2D* CutoutTexture;
    [FieldOffset(0x00F0)] public int MaxDrawCount;
    [FieldOffset(0x00F4)] public float EmitterDurationLow;
    [FieldOffset(0x00F8)] public FVector NormalsCylinderDirection;
    [FieldOffset(0x0108)] public TArray<FName> NamedMaterialOverrides;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UParticleModuleRotation
{
    [FieldOffset(0x0000)] public UParticleModuleRotationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat StartRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleRotation_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleRotation baseObj;
    [FieldOffset(0x0060)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleRotationOverLifetime
{
    [FieldOffset(0x0000)] public UParticleModuleRotationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat RotationOverLife;
    [FieldOffset(0x0060)] public byte Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UParticleModuleRotationRate
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRateBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat StartRotationRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleRotationRate_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRate baseObj;
    [FieldOffset(0x0060)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UParticleModuleRotationRateMultiplyLife
{
    [FieldOffset(0x0000)] public UParticleModuleRotationRateBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionFloat LifeMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleSizeBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleSize
{
    [FieldOffset(0x0000)] public UParticleModuleSizeBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector StartSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UParticleModuleSize_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleSize baseObj;
    [FieldOffset(0x0078)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleSizeMultiplyLife
{
    [FieldOffset(0x0000)] public UParticleModuleSizeBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector LifeMultiplier;
    [FieldOffset(0x0078)] public byte MultiplyX;
    [FieldOffset(0x0078)] public byte MultiplyY;
    [FieldOffset(0x0078)] public byte MultiplyZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleSizeScale
{
    [FieldOffset(0x0000)] public UParticleModuleSizeBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector SizeScale;
    [FieldOffset(0x0078)] public byte EnableX;
    [FieldOffset(0x0078)] public byte EnableY;
    [FieldOffset(0x0078)] public byte EnableZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleSizeScaleBySpeed
{
    [FieldOffset(0x0000)] public UParticleModuleSizeBase baseObj;
    [FieldOffset(0x0030)] public FVector2D SpeedScale;
    [FieldOffset(0x0038)] public FVector2D MaxScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleSourceMovement
{
    [FieldOffset(0x0000)] public UParticleModuleLocationBase baseObj;
    [FieldOffset(0x0030)] public FRawDistributionVector SourceMovementScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleSpawnBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
    [FieldOffset(0x0030)] public byte bProcessSpawnRate;
    [FieldOffset(0x0030)] public byte bProcessBurstList;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UParticleModuleSpawn
{
    [FieldOffset(0x0000)] public UParticleModuleSpawnBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionFloat Rate;
    [FieldOffset(0x0068)] public FRawDistributionFloat RateScale;
    [FieldOffset(0x0098)] public EParticleBurstMethod ParticleBurstMethod;
    [FieldOffset(0x00A0)] public TArray<FParticleBurst> BurstList;
    [FieldOffset(0x00B0)] public FRawDistributionFloat BurstScale;
    [FieldOffset(0x00E0)] public byte bApplyGlobalSpawnRateScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UParticleModuleSpawnPerUnit
{
    [FieldOffset(0x0000)] public UParticleModuleSpawnBase baseObj;
    [FieldOffset(0x0038)] public float UnitScalar;
    [FieldOffset(0x003C)] public float MovementTolerance;
    [FieldOffset(0x0040)] public FRawDistributionFloat SpawnPerUnit;
    [FieldOffset(0x0070)] public float MaxFrameDistance;
    [FieldOffset(0x0074)] public byte bIgnoreSpawnRateWhenMoving;
    [FieldOffset(0x0074)] public byte bIgnoreMovementAlongX;
    [FieldOffset(0x0074)] public byte bIgnoreMovementAlongY;
    [FieldOffset(0x0074)] public byte bIgnoreMovementAlongZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleSubUVBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UParticleModuleSubUV
{
    [FieldOffset(0x0000)] public UParticleModuleSubUVBase baseObj;
    [FieldOffset(0x0030)] public USubUVAnimation* Animation;
    [FieldOffset(0x0038)] public FRawDistributionFloat SubImageIndex;
    [FieldOffset(0x0068)] public byte bUseRealTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleSubUVMovie
{
    [FieldOffset(0x0000)] public UParticleModuleSubUV baseObj;
    [FieldOffset(0x0070)] public byte bUseEmitterTime;
    [FieldOffset(0x0078)] public FRawDistributionFloat FrameRate;
    [FieldOffset(0x00A8)] public int StartingFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleTrailBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UParticleModuleTrailSource
{
    [FieldOffset(0x0000)] public UParticleModuleTrailBase baseObj;
    [FieldOffset(0x0030)] public ETrail2SourceMethod SourceMethod;
    [FieldOffset(0x0034)] public FName SourceName;
    [FieldOffset(0x0040)] public FRawDistributionFloat SourceStrength;
    [FieldOffset(0x0070)] public byte bLockSourceStength;
    [FieldOffset(0x0074)] public int SourceOffsetCount;
    [FieldOffset(0x0078)] public TArray<FVector> SourceOffsetDefaults;
    [FieldOffset(0x0088)] public EParticleSourceSelectionMethod SelectionMethod;
    [FieldOffset(0x008C)] public byte bInheritRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleTypeDataBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UParticleModuleTypeDataAnimTrail
{
    [FieldOffset(0x0000)] public UParticleModuleTypeDataBase baseObj;
    [FieldOffset(0x0030)] public byte bDeadTrailsOnDeactivate;
    [FieldOffset(0x0030)] public byte bEnablePreviousTangentRecalculation;
    [FieldOffset(0x0030)] public byte bTangentRecalculationEveryFrame;
    [FieldOffset(0x0034)] public float TilingDistance;
    [FieldOffset(0x0038)] public float DistanceTessellationStepSize;
    [FieldOffset(0x003C)] public float TangentTessellationStepSize;
    [FieldOffset(0x0040)] public float WidthTessellationStepSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UParticleModuleTypeDataBeam2
{
    [FieldOffset(0x0000)] public UParticleModuleTypeDataBase baseObj;
    [FieldOffset(0x0030)] public EBeam2Method BeamMethod;
    [FieldOffset(0x0034)] public int TextureTile;
    [FieldOffset(0x0038)] public float TextureTileDistance;
    [FieldOffset(0x003C)] public int Sheets;
    [FieldOffset(0x0040)] public int MaxBeamCount;
    [FieldOffset(0x0044)] public float Speed;
    [FieldOffset(0x0048)] public int InterpolationPoints;
    [FieldOffset(0x004C)] public byte bAlwaysOn;
    [FieldOffset(0x0050)] public int UpVectorStepSize;
    [FieldOffset(0x0054)] public FName BranchParentName;
    [FieldOffset(0x0060)] public FRawDistributionFloat Distance;
    [FieldOffset(0x0090)] public EBeamTaperMethod TaperMethod;
    [FieldOffset(0x0098)] public FRawDistributionFloat TaperFactor;
    [FieldOffset(0x00C8)] public FRawDistributionFloat TaperScale;
    [FieldOffset(0x00F8)] public byte RenderGeometry;
    [FieldOffset(0x00F8)] public byte RenderDirectLine;
    [FieldOffset(0x00F8)] public byte RenderLines;
    [FieldOffset(0x00F8)] public byte RenderTessellation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FGPUSpriteLocalVectorFieldInfo
{
    [FieldOffset(0x0000)] public UVectorField* Field;
    [FieldOffset(0x0010)] public FTransform Transform;
    [FieldOffset(0x0040)] public FRotator MinInitialRotation;
    [FieldOffset(0x004C)] public FRotator MaxInitialRotation;
    [FieldOffset(0x0058)] public FRotator RotationRate;
    [FieldOffset(0x0064)] public float Intensity;
    [FieldOffset(0x0068)] public float Tightness;
    [FieldOffset(0x006C)] public byte bIgnoreComponentTransform;
    [FieldOffset(0x006C)] public byte bTileX;
    [FieldOffset(0x006C)] public byte bTileY;
    [FieldOffset(0x006C)] public byte bTileZ;
    [FieldOffset(0x006C)] public byte bUseFixDT;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFloatDistribution
{
    [FieldOffset(0x0000)] public FDistributionLookupTable Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct FGPUSpriteEmitterInfo
{
    [FieldOffset(0x0000)] public UParticleModuleRequired* RequiredModule;
    [FieldOffset(0x0008)] public UParticleModuleSpawn* SpawnModule;
    [FieldOffset(0x0010)] public UParticleModuleSpawnPerUnit* SpawnPerUnitModule;
    [FieldOffset(0x0018)] public TArray<IntPtr> SpawnModules;
    [FieldOffset(0x0030)] public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
    [FieldOffset(0x00A0)] public FFloatDistribution VectorFieldScale;
    [FieldOffset(0x00C0)] public FFloatDistribution DragCoefficient;
    [FieldOffset(0x00E0)] public FFloatDistribution PointAttractorStrength;
    [FieldOffset(0x0100)] public FFloatDistribution Resilience;
    [FieldOffset(0x0120)] public FVector ConstantAcceleration;
    [FieldOffset(0x012C)] public FVector PointAttractorPosition;
    [FieldOffset(0x0138)] public float PointAttractorRadiusSq;
    [FieldOffset(0x013C)] public FVector OrbitOffsetBase;
    [FieldOffset(0x0148)] public FVector OrbitOffsetRange;
    [FieldOffset(0x0154)] public FVector2D InvMaxSize;
    [FieldOffset(0x015C)] public float InvRotationRateScale;
    [FieldOffset(0x0160)] public float MaxLifetime;
    [FieldOffset(0x0164)] public int MaxParticleCount;
    [FieldOffset(0x0168)] public EParticleScreenAlignment ScreenAlignment;
    [FieldOffset(0x0169)] public EParticleAxisLock LockAxisFlag;
    [FieldOffset(0x016C)] public byte bEnableCollision;
    [FieldOffset(0x0170)] public EParticleCollisionMode CollisionMode;
    [FieldOffset(0x0174)] public byte bRemoveHMDRoll;
    [FieldOffset(0x0178)] public float MinFacingCameraBlendDistance;
    [FieldOffset(0x017C)] public float MaxFacingCameraBlendDistance;
    [FieldOffset(0x0180)] public FRawDistributionVector DynamicColor;
    [FieldOffset(0x01C8)] public FRawDistributionFloat DynamicAlpha;
    [FieldOffset(0x01F8)] public FRawDistributionVector DynamicColorScale;
    [FieldOffset(0x0240)] public FRawDistributionFloat DynamicAlphaScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct FGPUSpriteResourceData
{
    [FieldOffset(0x0000)] public TArray<FColor> QuantizedColorSamples;
    [FieldOffset(0x0010)] public TArray<FColor> QuantizedMiscSamples;
    [FieldOffset(0x0020)] public TArray<FColor> QuantizedSimulationAttrSamples;
    [FieldOffset(0x0030)] public FVector4 ColorScale;
    [FieldOffset(0x0040)] public FVector4 ColorBias;
    [FieldOffset(0x0050)] public FVector4 MiscScale;
    [FieldOffset(0x0060)] public FVector4 MiscBias;
    [FieldOffset(0x0070)] public FVector4 SimulationAttrCurveScale;
    [FieldOffset(0x0080)] public FVector4 SimulationAttrCurveBias;
    [FieldOffset(0x0090)] public FVector4 SubImageSize;
    [FieldOffset(0x00A0)] public FVector4 SizeBySpeed;
    [FieldOffset(0x00B0)] public FVector ConstantAcceleration;
    [FieldOffset(0x00BC)] public FVector OrbitOffsetBase;
    [FieldOffset(0x00C8)] public FVector OrbitOffsetRange;
    [FieldOffset(0x00D4)] public FVector OrbitFrequencyBase;
    [FieldOffset(0x00E0)] public FVector OrbitFrequencyRange;
    [FieldOffset(0x00EC)] public FVector OrbitPhaseBase;
    [FieldOffset(0x00F8)] public FVector OrbitPhaseRange;
    [FieldOffset(0x0104)] public float GlobalVectorFieldScale;
    [FieldOffset(0x0108)] public float GlobalVectorFieldTightness;
    [FieldOffset(0x010C)] public float PerParticleVectorFieldScale;
    [FieldOffset(0x0110)] public float PerParticleVectorFieldBias;
    [FieldOffset(0x0114)] public float DragCoefficientScale;
    [FieldOffset(0x0118)] public float DragCoefficientBias;
    [FieldOffset(0x011C)] public float ResilienceScale;
    [FieldOffset(0x0120)] public float ResilienceBias;
    [FieldOffset(0x0124)] public float CollisionRadiusScale;
    [FieldOffset(0x0128)] public float CollisionRadiusBias;
    [FieldOffset(0x012C)] public float CollisionTimeBias;
    [FieldOffset(0x0130)] public float CollisionRandomSpread;
    [FieldOffset(0x0134)] public float CollisionRandomDistribution;
    [FieldOffset(0x0138)] public float OneMinusFriction;
    [FieldOffset(0x013C)] public float RotationRateScale;
    [FieldOffset(0x0140)] public float CameraMotionBlurAmount;
    [FieldOffset(0x0144)] public EParticleScreenAlignment ScreenAlignment;
    [FieldOffset(0x0145)] public EParticleAxisLock LockAxisFlag;
    [FieldOffset(0x0148)] public FVector2D PivotOffset;
    [FieldOffset(0x0150)] public byte bRemoveHMDRoll;
    [FieldOffset(0x0154)] public float MinFacingCameraBlendDistance;
    [FieldOffset(0x0158)] public float MaxFacingCameraBlendDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x420)] 
public unsafe struct UParticleModuleTypeDataGpu
{
    [FieldOffset(0x0000)] public UParticleModuleTypeDataBase baseObj;
    [FieldOffset(0x0030)] public FGPUSpriteEmitterInfo EmitterInfo;
    [FieldOffset(0x02B0)] public FGPUSpriteResourceData ResourceData;
    [FieldOffset(0x0410)] public float CameraMotionBlurAmount;
    [FieldOffset(0x0414)] public byte bClearExistingParticlesOnInit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UParticleModuleTypeDataMesh
{
    [FieldOffset(0x0000)] public UParticleModuleTypeDataBase baseObj;
    [FieldOffset(0x0030)] public UStaticMesh* Mesh;
    [FieldOffset(0x0040)] public float LODSizeScale;
    [FieldOffset(0x0044)] public byte bUseStaticMeshLODs;
    [FieldOffset(0x0044)] public byte CastShadows;
    [FieldOffset(0x0044)] public byte DoCollisions;
    [FieldOffset(0x0045)] public EMeshScreenAlignment MeshAlignment;
    [FieldOffset(0x0046)] public byte bOverrideMaterial;
    [FieldOffset(0x0046)] public byte bOverrideDefaultMotionBlurSettings;
    [FieldOffset(0x0046)] public byte bEnableMotionBlur;
    [FieldOffset(0x0048)] public FRawDistributionVector RollPitchYawRange;
    [FieldOffset(0x0090)] public EParticleAxisLock AxisLockOption;
    [FieldOffset(0x0091)] public byte bCameraFacing;
    [FieldOffset(0x0092)] public EMeshCameraFacingUpAxis CameraFacingUpAxisOption;
    [FieldOffset(0x0093)] public EMeshCameraFacingOptions CameraFacingOption;
    [FieldOffset(0x0094)] public byte bApplyParticleRotationAsSpin;
    [FieldOffset(0x0094)] public byte bFaceCameraDirectionRatherThanPosition;
    [FieldOffset(0x0094)] public byte bCollisionsConsiderPartilceSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UParticleModuleTypeDataRibbon
{
    [FieldOffset(0x0000)] public UParticleModuleTypeDataBase baseObj;
    [FieldOffset(0x0030)] public int MaxTessellationBetweenParticles;
    [FieldOffset(0x0034)] public int SheetsPerTrail;
    [FieldOffset(0x0038)] public int MaxTrailCount;
    [FieldOffset(0x003C)] public int MaxParticleInTrailCount;
    [FieldOffset(0x0040)] public byte bDeadTrailsOnDeactivate;
    [FieldOffset(0x0040)] public byte bDeadTrailsOnSourceLoss;
    [FieldOffset(0x0040)] public byte bClipSourceSegement;
    [FieldOffset(0x0040)] public byte bEnablePreviousTangentRecalculation;
    [FieldOffset(0x0040)] public byte bTangentRecalculationEveryFrame;
    [FieldOffset(0x0040)] public byte bSpawnInitialParticle;
    [FieldOffset(0x0044)] public ETrailsRenderAxisOption RenderAxis;
    [FieldOffset(0x0048)] public float TangentSpawningScalar;
    [FieldOffset(0x004C)] public byte bRenderGeometry;
    [FieldOffset(0x004C)] public byte bRenderSpawnPoints;
    [FieldOffset(0x004C)] public byte bRenderTangents;
    [FieldOffset(0x004C)] public byte bRenderTessellation;
    [FieldOffset(0x0050)] public float TilingDistance;
    [FieldOffset(0x0054)] public float DistanceTessellationStepSize;
    [FieldOffset(0x0058)] public byte bEnableTangentDiffInterpScale;
    [FieldOffset(0x005C)] public float TangentTessellationScalar;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UParticleModuleVectorFieldBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleVectorFieldGlobal
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public byte bOverrideGlobalVectorFieldTightness;
    [FieldOffset(0x0034)] public float GlobalVectorFieldScale;
    [FieldOffset(0x0038)] public float GlobalVectorFieldTightness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleVectorFieldLocal
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public UVectorField* VectorField;
    [FieldOffset(0x0038)] public FVector RelativeTranslation;
    [FieldOffset(0x0044)] public FRotator RelativeRotation;
    [FieldOffset(0x0050)] public FVector RelativeScale3D;
    [FieldOffset(0x005C)] public float Intensity;
    [FieldOffset(0x0060)] public float Tightness;
    [FieldOffset(0x0064)] public byte bIgnoreComponentTransform;
    [FieldOffset(0x0064)] public byte bTileX;
    [FieldOffset(0x0064)] public byte bTileY;
    [FieldOffset(0x0064)] public byte bTileZ;
    [FieldOffset(0x0064)] public byte bUseFixDT;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UParticleModuleVectorFieldRotation
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public FVector MinInitialRotation;
    [FieldOffset(0x003C)] public FVector MaxInitialRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleModuleVectorFieldRotationRate
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public FVector RotationRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleVectorFieldScale
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public UDistributionFloat* VectorFieldScale;
    [FieldOffset(0x0038)] public FRawDistributionFloat VectorFieldScaleRaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UParticleModuleVectorFieldScaleOverLife
{
    [FieldOffset(0x0000)] public UParticleModuleVectorFieldBase baseObj;
    [FieldOffset(0x0030)] public UDistributionFloat* VectorFieldScaleOverLife;
    [FieldOffset(0x0038)] public FRawDistributionFloat VectorFieldScaleOverLifeRaw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UParticleModuleVelocityBase
{
    [FieldOffset(0x0000)] public UParticleModule baseObj;
    [FieldOffset(0x0030)] public byte bInWorldSpace;
    [FieldOffset(0x0030)] public byte bApplyOwnerScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UParticleModuleVelocity
{
    [FieldOffset(0x0000)] public UParticleModuleVelocityBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionVector StartVelocity;
    [FieldOffset(0x0080)] public FRawDistributionFloat StartVelocityRadial;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UParticleModuleVelocity_Seeded
{
    [FieldOffset(0x0000)] public UParticleModuleVelocity baseObj;
    [FieldOffset(0x00B0)] public FParticleRandomSeedInfo RandomSeedInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UParticleModuleVelocityCone
{
    [FieldOffset(0x0000)] public UParticleModuleVelocityBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionFloat Angle;
    [FieldOffset(0x0068)] public FRawDistributionFloat Velocity;
    [FieldOffset(0x0098)] public FVector Direction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UParticleModuleVelocityInheritParent
{
    [FieldOffset(0x0000)] public UParticleModuleVelocityBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionVector Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UParticleModuleVelocityOverLifetime
{
    [FieldOffset(0x0000)] public UParticleModuleVelocityBase baseObj;
    [FieldOffset(0x0038)] public FRawDistributionVector VelOverLife;
    [FieldOffset(0x0080)] public byte Absolute;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UParticleSpriteEmitter
{
    [FieldOffset(0x0000)] public UParticleEmitter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FParticleSysParam
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public EParticleSysParamType ParamType;
    [FieldOffset(0x000C)] public float Scalar;
    [FieldOffset(0x0010)] public float Scalar_Low;
    [FieldOffset(0x0014)] public FVector Vector;
    [FieldOffset(0x0020)] public FVector Vector_Low;
    [FieldOffset(0x002C)] public FColor Color;
    [FieldOffset(0x0030)] public AActor* Actor;
    [FieldOffset(0x0038)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6B0)] 
public unsafe struct UParticleSystemComponent
{
    [FieldOffset(0x0000)] public UFXSystemComponent baseObj;
    [FieldOffset(0x0450)] public UParticleSystem* Template;
    [FieldOffset(0x0458)] public TArray<IntPtr> EmitterMaterials;
    [FieldOffset(0x0468)] public TArray<IntPtr> SkelMeshComponents;
    [FieldOffset(0x0479)] public byte bResetOnDetach;
    [FieldOffset(0x0479)] public byte bUpdateOnDedicatedServer;
    [FieldOffset(0x0479)] public byte bAllowRecycling;
    [FieldOffset(0x0479)] public byte bAutoManageAttachment;
    [FieldOffset(0x0479)] public byte bAutoAttachWeldSimulatedBodies;
    [FieldOffset(0x047A)] public byte bWarmingUp;
    [FieldOffset(0x047A)] public byte bOverrideLODMethod;
    [FieldOffset(0x047A)] public byte bSkipUpdateDynamicDataDuringTick;
    [FieldOffset(0x0485)] public ParticleSystemLODMethod LODMethod;
    [FieldOffset(0x0486)] public EParticleSignificanceLevel RequiredSignificance;
    [FieldOffset(0x0488)] public TArray<FParticleSysParam> InstanceParameters;
    [FieldOffset(0x04D8)] public bool bOldPositionValid;
    [FieldOffset(0x04DC)] public FVector OldPosition;
    [FieldOffset(0x04E8)] public FVector PartSysVelocity;
    [FieldOffset(0x04F4)] public float WarmupTime;
    [FieldOffset(0x04F8)] public float WarmupTickRate;
    [FieldOffset(0x0500)] public float SecondsBeforeInactive;
    [FieldOffset(0x0508)] public float MaxTimeBeforeForceUpdateTransform;
    [FieldOffset(0x0528)] public TArray<IntPtr> ReplayClips;
    [FieldOffset(0x0540)] public float CustomTimeDilation;
    [FieldOffset(0x0598)] public TWeakObjectPtr<USceneComponent> AutoAttachParent;
    [FieldOffset(0x05A0)] public FName AutoAttachSocketName;
    [FieldOffset(0x05A8)] public EAttachmentRule AutoAttachLocationRule;
    [FieldOffset(0x05A9)] public EAttachmentRule AutoAttachRotationRule;
    [FieldOffset(0x05AA)] public EAttachmentRule AutoAttachScaleRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UParticleSystemReplay
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int ClipIDNumber;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IPathFollowingAgentInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UPawnNoiseEmitterComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public byte bAIPerceptionSystemCompatibilityMode;
    [FieldOffset(0x00B4)] public FVector LastRemoteNoisePosition;
    [FieldOffset(0x00C0)] public float NoiseLifetime;
    [FieldOffset(0x00C4)] public float LastRemoteNoiseVolume;
    [FieldOffset(0x00C8)] public float LastRemoteNoiseTime;
    [FieldOffset(0x00CC)] public float LastLocalNoiseVolume;
    [FieldOffset(0x00D0)] public float LastLocalNoiseTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FPhysicalAnimationData
{
    [FieldOffset(0x0000)] public FName BodyName;
    [FieldOffset(0x0008)] public byte bIsLocalSimulation;
    [FieldOffset(0x000C)] public float OrientationStrength;
    [FieldOffset(0x0010)] public float AngularVelocityStrength;
    [FieldOffset(0x0014)] public float PositionStrength;
    [FieldOffset(0x0018)] public float VelocityStrength;
    [FieldOffset(0x001C)] public float MaxLinearForce;
    [FieldOffset(0x0020)] public float MaxAngularForce;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UPhysicalAnimationComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float StrengthMultiplyer;
    [FieldOffset(0x00B8)] public USkeletalMeshComponent* SkeletalMeshComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UPhysicalMaterialMask
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int UVChannelIndex;
    [FieldOffset(0x002C)] public TextureAddress AddressX;
    [FieldOffset(0x002D)] public TextureAddress AddressY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FSolverIterations
{
    [FieldOffset(0x0000)] public float FixedTimeStep;
    [FieldOffset(0x0004)] public int SolverIterations;
    [FieldOffset(0x0008)] public int JointIterations;
    [FieldOffset(0x000C)] public int CollisionIterations;
    [FieldOffset(0x0010)] public int SolverPushOutIterations;
    [FieldOffset(0x0014)] public int JointPushOutIterations;
    [FieldOffset(0x0018)] public int CollisionPushOutIterations;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UPhysicsAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<int> BoundsBodies;
    [FieldOffset(0x0040)] public TArray<IntPtr> SkeletalBodySetups;
    [FieldOffset(0x0050)] public TArray<IntPtr> ConstraintSetup;
    [FieldOffset(0x0060)] public FSolverIterations SolverIterations;
    [FieldOffset(0x007C)] public EPhysicsAssetSolverType SolverType;
    [FieldOffset(0x007D)] public byte bNotForDedicatedServer;
    [FieldOffset(0x0120)] public UThumbnailInfo* ThumbnailInfo;
    [FieldOffset(0x0128)] public TArray<IntPtr> BodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FPhysicalAnimationProfile
{
    [FieldOffset(0x0000)] public FName ProfileName;
    [FieldOffset(0x0008)] public FPhysicalAnimationData PhysicalAnimationData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct USkeletalBodySetup
{
    [FieldOffset(0x0000)] public UBodySetup baseObj;
    [FieldOffset(0x02A0)] public bool bSkipScaleFromAnimation;
    [FieldOffset(0x02A8)] public TArray<FPhysicalAnimationProfile> PhysicalAnimationData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPhysicsCollisionHandler
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float ImpactThreshold;
    [FieldOffset(0x002C)] public float ImpactReFireDelay;
    [FieldOffset(0x0030)] public USoundBase* DefaultImpactSound;
    [FieldOffset(0x0038)] public float LastImpactSoundTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct ARigidBodyBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct APhysicsConstraintActor
{
    [FieldOffset(0x0000)] public ARigidBodyBase baseObj;
    [FieldOffset(0x0220)] public UPhysicsConstraintComponent* ConstraintComp;
    [FieldOffset(0x0228)] public AActor* ConstraintActor1;
    [FieldOffset(0x0230)] public AActor* ConstraintActor2;
    [FieldOffset(0x0238)] public byte bDisableCollision;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FConstrainComponentPropName
{
    [FieldOffset(0x0000)] public FName ComponentName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FConstraintInstanceBase
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FConstraintBaseParams
{
    [FieldOffset(0x0000)] public float Stiffness;
    [FieldOffset(0x0004)] public float Damping;
    [FieldOffset(0x0008)] public float Restitution;
    [FieldOffset(0x000C)] public float ContactDistance;
    [FieldOffset(0x0010)] public byte bSoftConstraint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FLinearConstraint
{
    [FieldOffset(0x0000)] public FConstraintBaseParams baseObj;
    [FieldOffset(0x0014)] public float Limit;
    [FieldOffset(0x0018)] public ELinearConstraintMotion XMotion;
    [FieldOffset(0x0019)] public ELinearConstraintMotion YMotion;
    [FieldOffset(0x001A)] public ELinearConstraintMotion ZMotion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FConeConstraint
{
    [FieldOffset(0x0000)] public FConstraintBaseParams baseObj;
    [FieldOffset(0x0014)] public float Swing1LimitDegrees;
    [FieldOffset(0x0018)] public float Swing2LimitDegrees;
    [FieldOffset(0x001C)] public EAngularConstraintMotion Swing1Motion;
    [FieldOffset(0x001D)] public EAngularConstraintMotion Swing2Motion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FTwistConstraint
{
    [FieldOffset(0x0000)] public FConstraintBaseParams baseObj;
    [FieldOffset(0x0014)] public float TwistLimitDegrees;
    [FieldOffset(0x0018)] public EAngularConstraintMotion TwistMotion;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FConstraintDrive
{
    [FieldOffset(0x0000)] public float Stiffness;
    [FieldOffset(0x0004)] public float Damping;
    [FieldOffset(0x0008)] public float MaxForce;
    [FieldOffset(0x000C)] public byte bEnablePositionDrive;
    [FieldOffset(0x000C)] public byte bEnableVelocityDrive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FLinearDriveConstraint
{
    [FieldOffset(0x0000)] public FVector PositionTarget;
    [FieldOffset(0x000C)] public FVector VelocityTarget;
    [FieldOffset(0x0018)] public FConstraintDrive XDrive;
    [FieldOffset(0x0028)] public FConstraintDrive YDrive;
    [FieldOffset(0x0038)] public FConstraintDrive ZDrive;
    [FieldOffset(0x0048)] public byte bEnablePositionDrive;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FAngularDriveConstraint
{
    [FieldOffset(0x0000)] public FConstraintDrive TwistDrive;
    [FieldOffset(0x0010)] public FConstraintDrive SwingDrive;
    [FieldOffset(0x0020)] public FConstraintDrive SlerpDrive;
    [FieldOffset(0x0030)] public FRotator OrientationTarget;
    [FieldOffset(0x003C)] public FVector AngularVelocityTarget;
    [FieldOffset(0x0048)] public EAngularDriveMode AngularDriveMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x114)] 
public unsafe struct FConstraintProfileProperties
{
    [FieldOffset(0x0000)] public float ProjectionLinearTolerance;
    [FieldOffset(0x0004)] public float ProjectionAngularTolerance;
    [FieldOffset(0x0008)] public float ProjectionLinearAlpha;
    [FieldOffset(0x000C)] public float ProjectionAngularAlpha;
    [FieldOffset(0x0010)] public float LinearBreakThreshold;
    [FieldOffset(0x0014)] public float LinearPlasticityThreshold;
    [FieldOffset(0x0018)] public float AngularBreakThreshold;
    [FieldOffset(0x001C)] public float AngularPlasticityThreshold;
    [FieldOffset(0x0020)] public FLinearConstraint LinearLimit;
    [FieldOffset(0x003C)] public FConeConstraint ConeLimit;
    [FieldOffset(0x005C)] public FTwistConstraint TwistLimit;
    [FieldOffset(0x0078)] public FLinearDriveConstraint LinearDrive;
    [FieldOffset(0x00C4)] public FAngularDriveConstraint AngularDrive;
    [FieldOffset(0x0110)] public byte bDisableCollision;
    [FieldOffset(0x0110)] public byte bParentDominates;
    [FieldOffset(0x0110)] public byte bEnableProjection;
    [FieldOffset(0x0110)] public byte bEnableSoftProjection;
    [FieldOffset(0x0110)] public byte bAngularBreakable;
    [FieldOffset(0x0110)] public byte bAngularPlasticity;
    [FieldOffset(0x0110)] public byte bLinearBreakable;
    [FieldOffset(0x0110)] public byte bLinearPlasticity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C8)] 
public unsafe struct FConstraintInstance
{
    [FieldOffset(0x0000)] public FConstraintInstanceBase baseObj;
    [FieldOffset(0x0018)] public FName JointName;
    [FieldOffset(0x0020)] public FName ConstraintBone1;
    [FieldOffset(0x0028)] public FName ConstraintBone2;
    [FieldOffset(0x0030)] public FVector Pos1;
    [FieldOffset(0x003C)] public FVector PriAxis1;
    [FieldOffset(0x0048)] public FVector SecAxis1;
    [FieldOffset(0x0054)] public FVector Pos2;
    [FieldOffset(0x0060)] public FVector PriAxis2;
    [FieldOffset(0x006C)] public FVector SecAxis2;
    [FieldOffset(0x0078)] public FRotator AngularRotationOffset;
    [FieldOffset(0x0084)] public byte bScaleLinearLimits;
    [FieldOffset(0x008C)] public FConstraintProfileProperties ProfileInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x410)] 
public unsafe struct UPhysicsConstraintComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public AActor* ConstraintActor1;
    [FieldOffset(0x0200)] public FConstrainComponentPropName ComponentName1;
    [FieldOffset(0x0208)] public AActor* ConstraintActor2;
    [FieldOffset(0x0210)] public FConstrainComponentPropName ComponentName2;
    [FieldOffset(0x0228)] public UPhysicsConstraintTemplate* ConstraintSetup;
    [FieldOffset(0x0240)] public FConstraintInstance ConstraintInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x11C)] 
public unsafe struct FPhysicsConstraintProfileHandle
{
    [FieldOffset(0x0000)] public FConstraintProfileProperties ProfileProperties;
    [FieldOffset(0x0114)] public FName ProfileName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct UPhysicsConstraintTemplate
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FConstraintInstance DefaultInstance;
    [FieldOffset(0x01F0)] public TArray<FPhysicsConstraintProfileHandle> ProfileHandles;
    [FieldOffset(0x0200)] public FConstraintProfileProperties DefaultProfile;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UPhysicsFieldComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UPhysicsHandleComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UPrimitiveComponent* GrabbedComponent;
    [FieldOffset(0x00C0)] public byte bSoftAngularConstraint;
    [FieldOffset(0x00C0)] public byte bSoftLinearConstraint;
    [FieldOffset(0x00C0)] public byte bInterpolateTarget;
    [FieldOffset(0x00C4)] public float LinearDamping;
    [FieldOffset(0x00C8)] public float LinearStiffness;
    [FieldOffset(0x00CC)] public float AngularDamping;
    [FieldOffset(0x00D0)] public float AngularStiffness;
    [FieldOffset(0x0140)] public float InterpolationSpeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FRigidBodyErrorCorrection
{
    [FieldOffset(0x0000)] public float PingExtrapolation;
    [FieldOffset(0x0004)] public float PingLimit;
    [FieldOffset(0x0008)] public float ErrorPerLinearDifference;
    [FieldOffset(0x000C)] public float ErrorPerAngularDifference;
    [FieldOffset(0x0010)] public float MaxRestoredStateError;
    [FieldOffset(0x0014)] public float MaxLinearHardSnapDistance;
    [FieldOffset(0x0018)] public float PositionLerp;
    [FieldOffset(0x001C)] public float AngleLerp;
    [FieldOffset(0x0020)] public float LinearVelocityCoefficient;
    [FieldOffset(0x0024)] public float AngularVelocityCoefficient;
    [FieldOffset(0x0028)] public float ErrorAccumulationSeconds;
    [FieldOffset(0x002C)] public float ErrorAccumulationDistanceSq;
    [FieldOffset(0x0030)] public float ErrorAccumulationSimilarity;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FPhysicalSurfaceName
{
    [FieldOffset(0x0000)] public EPhysicalSurface Type;
    [FieldOffset(0x0004)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBroadphaseSettings
{
    [FieldOffset(0x0000)] public bool bUseMBPOnClient;
    [FieldOffset(0x0001)] public bool bUseMBPOnServer;
    [FieldOffset(0x0002)] public bool bUseMBPOuterBounds;
    [FieldOffset(0x0004)] public FBox MBPBounds;
    [FieldOffset(0x0020)] public FBox MBPOuterBounds;
    [FieldOffset(0x003C)] public uint MBPNumSubdivs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FChaosPhysicsSettings
{
    [FieldOffset(0x0000)] public EChaosThreadingMode DefaultThreadingModel;
    [FieldOffset(0x0001)] public EChaosSolverTickMode DedicatedThreadTickMode;
    [FieldOffset(0x0002)] public EChaosBufferMode DedicatedThreadBufferMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UPhysicsSettings
{
    [FieldOffset(0x0000)] public UPhysicsSettingsCore baseObj;
    [FieldOffset(0x00E0)] public FRigidBodyErrorCorrection PhysicErrorCorrection;
    [FieldOffset(0x0114)] public ESettingsLockedAxis LockedAxis;
    [FieldOffset(0x0115)] public ESettingsDOF DefaultDegreesOfFreedom;
    [FieldOffset(0x0116)] public bool bSuppressFaceRemapTable;
    [FieldOffset(0x0117)] public bool bSupportUVFromHitResults;
    [FieldOffset(0x0118)] public bool bDisableActiveActors;
    [FieldOffset(0x0119)] public bool bDisableKinematicStaticPairs;
    [FieldOffset(0x011A)] public bool bDisableKinematicKinematicPairs;
    [FieldOffset(0x011B)] public bool bDisableCCD;
    [FieldOffset(0x011C)] public bool bEnableEnhancedDeterminism;
    [FieldOffset(0x0120)] public float AnimPhysicsMinDeltaTime;
    [FieldOffset(0x0124)] public bool bSimulateAnimPhysicsAfterReset;
    [FieldOffset(0x0128)] public float MaxPhysicsDeltaTime;
    [FieldOffset(0x012C)] public bool bSubstepping;
    [FieldOffset(0x012D)] public bool bSubsteppingAsync;
    [FieldOffset(0x0130)] public float MaxSubstepDeltaTime;
    [FieldOffset(0x0134)] public int MaxSubsteps;
    [FieldOffset(0x0138)] public float SyncSceneSmoothingFactor;
    [FieldOffset(0x013C)] public float InitialAverageFrameRate;
    [FieldOffset(0x0140)] public int PhysXTreeRebuildRate;
    [FieldOffset(0x0148)] public TArray<FPhysicalSurfaceName> PhysicalSurfaces;
    [FieldOffset(0x0158)] public FBroadphaseSettings DefaultBroadphaseSettings;
    [FieldOffset(0x0198)] public float MinDeltaVelocityForHitEvents;
    [FieldOffset(0x019C)] public FChaosPhysicsSettings ChaosSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UPhysicsSpringComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float SpringStiffness;
    [FieldOffset(0x01FC)] public float SpringDamping;
    [FieldOffset(0x0200)] public float SpringLengthAtRest;
    [FieldOffset(0x0204)] public float SpringRadius;
    [FieldOffset(0x0208)] public ECollisionChannel SpringChannel;
    [FieldOffset(0x0209)] public bool bIgnoreSelf;
    [FieldOffset(0x020C)] public float SpringCompression;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APhysicsThruster
{
    [FieldOffset(0x0000)] public ARigidBodyBase baseObj;
    [FieldOffset(0x0220)] public UPhysicsThrusterComponent* ThrusterComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UPhysicsThrusterComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float ThrustStrength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct APlanarReflection
{
    [FieldOffset(0x0000)] public ASceneCapture baseObj;
    [FieldOffset(0x0230)] public UPlanarReflectionComponent* PlanarReflectionComponent;
    [FieldOffset(0x0238)] public bool bShowPreviewPlane;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEngineShowFlagsSetting
{
    [FieldOffset(0x0000)] public FString ShowFlagName;
    [FieldOffset(0x0010)] public bool Enabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct USceneCaptureComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public ESceneCapturePrimitiveRenderMode PrimitiveRenderMode;
    [FieldOffset(0x01F9)] public ESceneCaptureSource CaptureSource;
    [FieldOffset(0x01FA)] public byte bCaptureEveryFrame;
    [FieldOffset(0x01FA)] public byte bCaptureOnMovement;
    [FieldOffset(0x01FB)] public bool bAlwaysPersistRenderingState;
    [FieldOffset(0x0200)] public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenComponents;
    [FieldOffset(0x0210)] public TArray<IntPtr> HiddenActors;
    [FieldOffset(0x0220)] public TArray<TWeakObjectPtr<UPrimitiveComponent>> ShowOnlyComponents;
    [FieldOffset(0x0230)] public TArray<IntPtr> ShowOnlyActors;
    [FieldOffset(0x0240)] public float LODDistanceFactor;
    [FieldOffset(0x0244)] public float MaxViewDistanceOverride;
    [FieldOffset(0x0248)] public int CaptureSortPriority;
    [FieldOffset(0x024C)] public bool bUseRayTracingIfEnabled;
    [FieldOffset(0x0250)] public TArray<FEngineShowFlagsSetting> ShowFlagSettings;
    [FieldOffset(0x0290)] public FString ProfilingEventName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct UPlanarReflectionComponent
{
    [FieldOffset(0x0000)] public USceneCaptureComponent baseObj;
    [FieldOffset(0x02B0)] public UBoxComponent* PreviewBox;
    [FieldOffset(0x02B8)] public float NormalDistortionStrength;
    [FieldOffset(0x02BC)] public float PrefilterRoughness;
    [FieldOffset(0x02C0)] public float PrefilterRoughnessDistance;
    [FieldOffset(0x02C4)] public int ScreenPercentage;
    [FieldOffset(0x02C8)] public float ExtraFOV;
    [FieldOffset(0x02CC)] public float DistanceFromPlaneFadeStart;
    [FieldOffset(0x02D0)] public float DistanceFromPlaneFadeEnd;
    [FieldOffset(0x02D4)] public float DistanceFromPlaneFadeoutStart;
    [FieldOffset(0x02D8)] public float DistanceFromPlaneFadeoutEnd;
    [FieldOffset(0x02DC)] public float AngleFromPlaneFadeStart;
    [FieldOffset(0x02E0)] public float AngleFromPlaneFadeEnd;
    [FieldOffset(0x02E4)] public bool bShowPreviewPlane;
    [FieldOffset(0x02E5)] public bool bRenderSceneTwoSided;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APlaneReflectionCapture
{
    [FieldOffset(0x0000)] public AReflectionCapture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct UPlaneReflectionCaptureComponent
{
    [FieldOffset(0x0000)] public UReflectionCaptureComponent baseObj;
    [FieldOffset(0x0270)] public float InfluenceRadiusScale;
    [FieldOffset(0x0278)] public UDrawSphereComponent* PreviewInfluenceRadius;
    [FieldOffset(0x0280)] public UBoxComponent* PreviewCaptureBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UPlatformEventsComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UPlatformInterfaceWebResponse
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString OriginalURL;
    [FieldOffset(0x0038)] public int ResponseCode;
    [FieldOffset(0x003C)] public int Tag;
    [FieldOffset(0x0040)] public FString StringResponse;
    [FieldOffset(0x0050)] public TArray<byte> BinaryResponse;
}

[StructLayout(LayoutKind.Explicit, Size = 0x600)] 
public unsafe struct FCameraCacheEntry
{
    [FieldOffset(0x0000)] public float Timestamp;
    [FieldOffset(0x0010)] public FMinimalViewInfo POV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x610)] 
public unsafe struct FTViewTarget
{
    [FieldOffset(0x0000)] public AActor* Target;
    [FieldOffset(0x0010)] public FMinimalViewInfo POV;
    [FieldOffset(0x0600)] public APlayerState* PlayerState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2810)] 
public unsafe struct APlayerCameraManager
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public APlayerController* PCOwner;
    [FieldOffset(0x0228)] public USceneComponent* TransformComponent;
    [FieldOffset(0x0238)] public float DefaultFOV;
    [FieldOffset(0x0240)] public float DefaultOrthoWidth;
    [FieldOffset(0x0248)] public float DefaultAspectRatio;
    [FieldOffset(0x0290)] public FCameraCacheEntry CameraCache;
    [FieldOffset(0x0890)] public FCameraCacheEntry LastFrameCameraCache;
    [FieldOffset(0x0E90)] public FTViewTarget ViewTarget;
    [FieldOffset(0x14A0)] public FTViewTarget PendingViewTarget;
    [FieldOffset(0x1AE0)] public FCameraCacheEntry CameraCachePrivate;
    [FieldOffset(0x20E0)] public FCameraCacheEntry LastFrameCameraCachePrivate;
    [FieldOffset(0x26E0)] public TArray<IntPtr> ModifierList;
    [FieldOffset(0x26F0)] public TArray<TSubclassOf<UCameraModifier>> DefaultModifiers;
    [FieldOffset(0x2700)] public float FreeCamDistance;
    [FieldOffset(0x2704)] public FVector FreeCamOffset;
    [FieldOffset(0x2710)] public FVector ViewTargetOffset;
    [FieldOffset(0x2740)] public TArray<IntPtr> CameraLensEffects;
    [FieldOffset(0x2750)] public UCameraModifier_CameraShake* CachedCameraShakeMod;
    [FieldOffset(0x2758)] public UCameraAnimInst* AnimInstPool;
    [FieldOffset(0x2798)] public TArray<FPostProcessSettings> PostProcessBlendCache;
    [FieldOffset(0x27B8)] public TArray<IntPtr> ActiveAnims;
    [FieldOffset(0x27C8)] public TArray<IntPtr> FreeAnims;
    [FieldOffset(0x27D8)] public ACameraActor* AnimCameraActor;
    [FieldOffset(0x27E0)] public byte bIsOrthographic;
    [FieldOffset(0x27E0)] public byte bDefaultConstrainAspectRatio;
    [FieldOffset(0x27E0)] public byte bClientSimulatingViewTarget;
    [FieldOffset(0x27E0)] public byte bUseClientSideCameraUpdates;
    [FieldOffset(0x27E1)] public byte bGameCameraCutThisFrame;
    [FieldOffset(0x27E4)] public float ViewPitchMin;
    [FieldOffset(0x27E8)] public float ViewPitchMax;
    [FieldOffset(0x27EC)] public float ViewYawMin;
    [FieldOffset(0x27F0)] public float ViewYawMax;
    [FieldOffset(0x27F4)] public float ViewRollMin;
    [FieldOffset(0x27F8)] public float ViewRollMax;
    [FieldOffset(0x2800)] public float ServerUpdateCameraTimeout;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FKeyBind
{
    [FieldOffset(0x0000)] public FKey Key;
    [FieldOffset(0x0018)] public FString Command;
    [FieldOffset(0x0028)] public byte Control;
    [FieldOffset(0x0028)] public byte Shift;
    [FieldOffset(0x0028)] public byte Alt;
    [FieldOffset(0x0028)] public byte Cmd;
    [FieldOffset(0x0028)] public byte bIgnoreCtrl;
    [FieldOffset(0x0028)] public byte bIgnoreShift;
    [FieldOffset(0x0028)] public byte bIgnoreAlt;
    [FieldOffset(0x0028)] public byte bIgnoreCmd;
    [FieldOffset(0x0029)] public byte bDisabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A8)] 
public unsafe struct UPlayerInput
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0120)] public TArray<FKeyBind> DebugExecBindings;
    [FieldOffset(0x0160)] public TArray<FName> InvertedAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct APlayerStartPIE
{
    [FieldOffset(0x0000)] public APlayerStart baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x320)] 
public unsafe struct APlayerState
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public float Score;
    [FieldOffset(0x0224)] public int PlayerId;
    [FieldOffset(0x0228)] public byte Ping;
    [FieldOffset(0x022A)] public byte bShouldUpdateReplicatedPing;
    [FieldOffset(0x022A)] public byte bIsSpectator;
    [FieldOffset(0x022A)] public byte bOnlySpectator;
    [FieldOffset(0x022A)] public byte bIsABot;
    [FieldOffset(0x022A)] public byte bIsInactive;
    [FieldOffset(0x022A)] public byte bFromPreviousLevel;
    [FieldOffset(0x022C)] public int StartTime;
    [FieldOffset(0x0230)] public TSubclassOf<ULocalMessage> EngineMessageClass;
    [FieldOffset(0x0240)] public FString SavedNetworkAddress;
    [FieldOffset(0x0250)] public FUniqueNetIdRepl UniqueId;
    [FieldOffset(0x0280)] public APawn* PawnPrivate;
    [FieldOffset(0x0300)] public FString PlayerNamePrivate;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UPluginCommandlet
{
    [FieldOffset(0x0000)] public UCommandlet baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct APointLight
{
    [FieldOffset(0x0000)] public ALight baseObj;
    [FieldOffset(0x0230)] public UPointLightComponent* PointLightComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct UPointLightComponent
{
    [FieldOffset(0x0000)] public ULocalLightComponent baseObj;
    [FieldOffset(0x0340)] public byte bUseInverseSquaredFalloff;
    [FieldOffset(0x0344)] public float LightFalloffExponent;
    [FieldOffset(0x0348)] public float SourceRadius;
    [FieldOffset(0x034C)] public float SoftSourceRadius;
    [FieldOffset(0x0350)] public float SourceLength;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPolys
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x800)] 
public unsafe struct UPoseableMeshComponent
{
    [FieldOffset(0x0000)] public USkinnedMeshComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FPoseData
{
    [FieldOffset(0x0000)] public TArray<FTransform> LocalSpacePose;
    [FieldOffset(0x0010)] public TMap<int, int> TrackToBufferIndex;
    [FieldOffset(0x0060)] public TArray<float> CurveData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FPoseDataContainer
{
    [FieldOffset(0x0000)] public TArray<FSmartName> PoseNames;
    [FieldOffset(0x0010)] public TArray<FName> Tracks;
    [FieldOffset(0x0020)] public TMap<FName, int> TrackMap;
    [FieldOffset(0x0070)] public TArray<FPoseData> Poses;
    [FieldOffset(0x0080)] public TArray<FAnimCurveBase> Curves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UPoseAsset
{
    [FieldOffset(0x0000)] public UAnimationAsset baseObj;
    [FieldOffset(0x0080)] public FPoseDataContainer PoseContainer;
    [FieldOffset(0x0110)] public bool bAdditivePose;
    [FieldOffset(0x0114)] public int BasePoseIndex;
    [FieldOffset(0x0118)] public FName RetargetSource;
    [FieldOffset(0x0120)] public TArray<FTransform> RetargetSourceAssetReferencePose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPoseWatch
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UEdGraphNode* Node;
    [FieldOffset(0x0030)] public FColor PoseWatchColour;
}

[StructLayout(LayoutKind.Explicit, Size = 0x770)] 
public unsafe struct UPostProcessComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x0200)] public FPostProcessSettings Settings;
    [FieldOffset(0x0760)] public float Priority;
    [FieldOffset(0x0764)] public float BlendRadius;
    [FieldOffset(0x0768)] public float BlendWeight;
    [FieldOffset(0x076C)] public byte bEnabled;
    [FieldOffset(0x076C)] public byte bUnbound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7D0)] 
public unsafe struct APostProcessVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0260)] public FPostProcessSettings Settings;
    [FieldOffset(0x07C0)] public float Priority;
    [FieldOffset(0x07C4)] public float BlendRadius;
    [FieldOffset(0x07C8)] public float BlendWeight;
    [FieldOffset(0x07CC)] public byte bEnabled;
    [FieldOffset(0x07CC)] public byte bUnbound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct APrecomputedVisibilityOverrideVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public TArray<IntPtr> OverrideVisibleActors;
    [FieldOffset(0x0268)] public TArray<IntPtr> OverrideInvisibleActors;
    [FieldOffset(0x0278)] public TArray<FName> OverrideInvisibleLevels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct APrecomputedVisibilityVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IPreviewCollectionInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FPreviewMeshCollectionEntry
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UPreviewMeshCollection
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0038)] public USkeleton* Skeleton;
    [FieldOffset(0x0040)] public TArray<FPreviewMeshCollectionEntry> SkeletalMeshes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UProjectileMovementComponent
{
    [FieldOffset(0x0000)] public UMovementComponent baseObj;
    [FieldOffset(0x00F0)] public float InitialSpeed;
    [FieldOffset(0x00F4)] public float MaxSpeed;
    [FieldOffset(0x00F8)] public byte bRotationFollowsVelocity;
    [FieldOffset(0x00F8)] public byte bRotationRemainsVertical;
    [FieldOffset(0x00F8)] public byte bShouldBounce;
    [FieldOffset(0x00F8)] public byte bInitialVelocityInLocalSpace;
    [FieldOffset(0x00F8)] public byte bForceSubStepping;
    [FieldOffset(0x00F8)] public byte bSimulationEnabled;
    [FieldOffset(0x00F8)] public byte bSweepCollision;
    [FieldOffset(0x00F8)] public byte bIsHomingProjectile;
    [FieldOffset(0x00F9)] public byte bBounceAngleAffectsFriction;
    [FieldOffset(0x00F9)] public byte bIsSliding;
    [FieldOffset(0x00F9)] public byte bInterpMovement;
    [FieldOffset(0x00F9)] public byte bInterpRotation;
    [FieldOffset(0x00FC)] public float PreviousHitTime;
    [FieldOffset(0x0100)] public FVector PreviousHitNormal;
    [FieldOffset(0x010C)] public float ProjectileGravityScale;
    [FieldOffset(0x0110)] public float Buoyancy;
    [FieldOffset(0x0114)] public float Bounciness;
    [FieldOffset(0x0118)] public float Friction;
    [FieldOffset(0x011C)] public float BounceVelocityStopSimulatingThreshold;
    [FieldOffset(0x0120)] public float MinFrictionFraction;
    [FieldOffset(0x0148)] public float HomingAccelerationMagnitude;
    [FieldOffset(0x014C)] public TWeakObjectPtr<USceneComponent> HomingTargetComponent;
    [FieldOffset(0x0154)] public float MaxSimulationTimeStep;
    [FieldOffset(0x0158)] public int MaxSimulationIterations;
    [FieldOffset(0x015C)] public int BounceAdditionalIterations;
    [FieldOffset(0x0160)] public float InterpLocationTime;
    [FieldOffset(0x0164)] public float InterpRotationTime;
    [FieldOffset(0x0168)] public float InterpLocationMaxLagDistance;
    [FieldOffset(0x016C)] public float InterpLocationSnapToTargetDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UProxyLODMeshSimplificationSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FName ProxyLODMeshReductionModuleName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ARadialForceActor
{
    [FieldOffset(0x0000)] public ARigidBodyBase baseObj;
    [FieldOffset(0x0220)] public URadialForceComponent* ForceComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct URadialForceComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float Radius;
    [FieldOffset(0x01FC)] public ERadialImpulseFalloff Falloff;
    [FieldOffset(0x0200)] public float ImpulseStrength;
    [FieldOffset(0x0204)] public byte bImpulseVelChange;
    [FieldOffset(0x0204)] public byte bIgnoreOwningActor;
    [FieldOffset(0x0208)] public float ForceStrength;
    [FieldOffset(0x020C)] public float DestructibleDamage;
    [FieldOffset(0x0210)] public TArray<EObjectTypeQuery> ObjectTypesToAffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ARectLight
{
    [FieldOffset(0x0000)] public ALight baseObj;
    [FieldOffset(0x0230)] public URectLightComponent* RectLightComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct URectLightComponent
{
    [FieldOffset(0x0000)] public ULocalLightComponent baseObj;
    [FieldOffset(0x0340)] public float SourceWidth;
    [FieldOffset(0x0344)] public float SourceHeight;
    [FieldOffset(0x0348)] public float BarnDoorAngle;
    [FieldOffset(0x034C)] public float BarnDoorLength;
    [FieldOffset(0x0350)] public UTexture* SourceTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct URendererSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public byte bMobileDisableVertexFog;
    [FieldOffset(0x003C)] public int MaxMobileCascades;
    [FieldOffset(0x0040)] public EMobileMSAASampleCount MobileMSAASampleCount;
    [FieldOffset(0x0044)] public byte bMobileAllowDitheredLODTransition;
    [FieldOffset(0x0044)] public byte bMobileAllowSoftwareOcclusionCulling;
    [FieldOffset(0x0044)] public byte bMobileVirtualTextures;
    [FieldOffset(0x0044)] public byte bDiscardUnusedQualityLevels;
    [FieldOffset(0x0044)] public byte bOcclusionCulling;
    [FieldOffset(0x0048)] public float MinScreenRadiusForLights;
    [FieldOffset(0x004C)] public float MinScreenRadiusForEarlyZPass;
    [FieldOffset(0x0050)] public float MinScreenRadiusForCSMdepth;
    [FieldOffset(0x0054)] public byte bPrecomputedVisibilityWarning;
    [FieldOffset(0x0054)] public byte bTextureStreaming;
    [FieldOffset(0x0054)] public byte bUseDXT5NormalMaps;
    [FieldOffset(0x0054)] public byte bVirtualTextures;
    [FieldOffset(0x0054)] public byte bVirtualTextureEnableAutoImport;
    [FieldOffset(0x0054)] public byte bVirtualTexturedLightmaps;
    [FieldOffset(0x0058)] public uint VirtualTextureTileSize;
    [FieldOffset(0x005C)] public uint VirtualTextureTileBorderSize;
    [FieldOffset(0x0060)] public uint VirtualTextureFeedbackFactor;
    [FieldOffset(0x0064)] public byte bVirtualTextureEnableCompressZlib;
    [FieldOffset(0x0064)] public byte bVirtualTextureEnableCompressCrunch;
    [FieldOffset(0x0064)] public byte bClearCoatEnableSecondNormal;
    [FieldOffset(0x0068)] public int ReflectionCaptureResolution;
    [FieldOffset(0x006C)] public byte bReflectionCaptureCompression;
    [FieldOffset(0x006C)] public byte ReflectionEnvironmentLightmapMixBasedOnRoughness;
    [FieldOffset(0x006C)] public byte bForwardShading;
    [FieldOffset(0x006C)] public byte bVertexFoggingForOpaque;
    [FieldOffset(0x006C)] public byte bAllowStaticLighting;
    [FieldOffset(0x006C)] public byte bUseNormalMapsForStaticLighting;
    [FieldOffset(0x006C)] public byte bGenerateMeshDistanceFields;
    [FieldOffset(0x006C)] public byte bEightBitMeshDistanceFields;
    [FieldOffset(0x006D)] public byte bGenerateLandscapeGIData;
    [FieldOffset(0x006D)] public byte bCompressMeshDistanceFields;
    [FieldOffset(0x0070)] public float TessellationAdaptivePixelsPerTriangle;
    [FieldOffset(0x0074)] public byte bSeparateTranslucency;
    [FieldOffset(0x0078)] public ETranslucentSortPolicy TranslucentSortPolicy;
    [FieldOffset(0x007C)] public FVector TranslucentSortAxis;
    [FieldOffset(0x0088)] public EFixedFoveationLevels HMDFixedFoveationLevel;
    [FieldOffset(0x0089)] public ECustomDepthStencil CustomDepthStencil;
    [FieldOffset(0x008C)] public byte bCustomDepthTaaJitter;
    [FieldOffset(0x0090)] public EAlphaChannelMode bEnableAlphaChannelInPostProcessing;
    [FieldOffset(0x0094)] public byte bDefaultFeatureBloom;
    [FieldOffset(0x0094)] public byte bDefaultFeatureAmbientOcclusion;
    [FieldOffset(0x0094)] public byte bDefaultFeatureAmbientOcclusionStaticFraction;
    [FieldOffset(0x0094)] public byte bDefaultFeatureAutoExposure;
    [FieldOffset(0x0098)] public EAutoExposureMethodUI DefaultFeatureAutoExposure;
    [FieldOffset(0x009C)] public float DefaultFeatureAutoExposureBias;
    [FieldOffset(0x00A0)] public byte bExtendDefaultLuminanceRangeInAutoExposureSettings;
    [FieldOffset(0x00A0)] public byte bUsePreExposure;
    [FieldOffset(0x00A0)] public byte bEnablePreExposureOnlyInTheEditor;
    [FieldOffset(0x00A0)] public byte bDefaultFeatureMotionBlur;
    [FieldOffset(0x00A0)] public byte bDefaultFeatureLensFlare;
    [FieldOffset(0x00A0)] public byte bTemporalUpsampling;
    [FieldOffset(0x00A0)] public byte bSSGI;
    [FieldOffset(0x00A4)] public EAntiAliasingMethod DefaultFeatureAntiAliasing;
    [FieldOffset(0x00A5)] public ELightUnits DefaultLightUnits;
    [FieldOffset(0x00A6)] public EDefaultBackBufferPixelFormat DefaultBackBufferPixelFormat;
    [FieldOffset(0x00A8)] public byte bRenderUnbuiltPreviewShadowsInGame;
    [FieldOffset(0x00A8)] public byte bStencilForLODDither;
    [FieldOffset(0x00AC)] public EEarlyZPass EarlyZPass;
    [FieldOffset(0x00B0)] public byte bEarlyZPassOnlyMaterialMasking;
    [FieldOffset(0x00B0)] public byte bDBuffer;
    [FieldOffset(0x00B4)] public EClearSceneOptions ClearSceneMethod;
    [FieldOffset(0x00B8)] public byte bBasePassOutputsVelocity;
    [FieldOffset(0x00B8)] public byte bVertexDeformationOutputsVelocity;
    [FieldOffset(0x00B8)] public byte bSelectiveBasePassOutputs;
    [FieldOffset(0x00B8)] public byte bDefaultParticleCutouts;
    [FieldOffset(0x00BC)] public int GPUSimulationTextureSizeX;
    [FieldOffset(0x00C0)] public int GPUSimulationTextureSizeY;
    [FieldOffset(0x00C4)] public byte bGlobalClipPlane;
    [FieldOffset(0x00C8)] public EGBufferFormat GBufferFormat;
    [FieldOffset(0x00CC)] public byte bUseGPUMorphTargets;
    [FieldOffset(0x00CC)] public byte bNvidiaAftermathEnabled;
    [FieldOffset(0x00CC)] public byte bMultiView;
    [FieldOffset(0x00CC)] public byte bMobilePostProcessing;
    [FieldOffset(0x00CC)] public byte bMobileMultiView;
    [FieldOffset(0x00CC)] public byte bMobileUseHWsRGBEncoding;
    [FieldOffset(0x00CC)] public byte bRoundRobinOcclusion;
    [FieldOffset(0x00CC)] public byte bODSCapture;
    [FieldOffset(0x00CD)] public byte bMeshStreaming;
    [FieldOffset(0x00D0)] public float WireframeCullThreshold;
    [FieldOffset(0x00D4)] public byte bEnableRayTracing;
    [FieldOffset(0x00D4)] public byte bEnableRayTracingTextureLOD;
    [FieldOffset(0x00D4)] public byte bSupportStationarySkylight;
    [FieldOffset(0x00D4)] public byte bSupportLowQualityLightmaps;
    [FieldOffset(0x00D4)] public byte bSupportPointLightWholeSceneShadows;
    [FieldOffset(0x00D4)] public byte bSupportAtmosphericFog;
    [FieldOffset(0x00D4)] public byte bSupportSkyAtmosphere;
    [FieldOffset(0x00D4)] public byte bSupportSkyAtmosphereAffectsHeightFog;
    [FieldOffset(0x00D5)] public byte bSupportSkinCacheShaders;
    [FieldOffset(0x00D8)] public ESkinCacheDefaultBehavior DefaultSkinCacheBehavior;
    [FieldOffset(0x00DC)] public float SkinCacheSceneMemoryLimitInMB;
    [FieldOffset(0x00E0)] public byte bMobileEnableStaticAndCSMShadowReceivers;
    [FieldOffset(0x00E0)] public byte bMobileEnableMovableLightCSMShaderCulling;
    [FieldOffset(0x00E0)] public byte bMobileAllowDistanceFieldShadows;
    [FieldOffset(0x00E0)] public byte bMobileAllowMovableDirectionalLights;
    [FieldOffset(0x00E4)] public uint MobileNumDynamicPointLights;
    [FieldOffset(0x00E8)] public byte bMobileDynamicPointLightsUseStaticBranch;
    [FieldOffset(0x00E8)] public byte bMobileAllowMovableSpotlights;
    [FieldOffset(0x00E8)] public byte bMobileAllowMovableSpotlightShadows;
    [FieldOffset(0x00E8)] public byte bSupport16BitBoneIndex;
    [FieldOffset(0x00E8)] public byte bGPUSkinLimit2BoneInfluences;
    [FieldOffset(0x00E8)] public byte bSupportDepthOnlyIndexBuffers;
    [FieldOffset(0x00E8)] public byte bSupportReversedIndexBuffers;
    [FieldOffset(0x00E8)] public byte bLPV;
    [FieldOffset(0x00E9)] public byte bMobileAmbientOcclusion;
    [FieldOffset(0x00E9)] public byte bUseUnlimitedBoneInfluences;
    [FieldOffset(0x00EC)] public int UnlimitedBonInfluencesThreshold;
    [FieldOffset(0x00F0)] public FPerPlatformInt MaxSkinBones;
    [FieldOffset(0x00F4)] public EMobilePlanarReflectionMode MobilePlanarReflectionMode;
    [FieldOffset(0x00F8)] public byte bMobileSupportsGen4TAA;
    [FieldOffset(0x00FC)] public FPerPlatformBool bStreamSkeletalMeshLODs;
    [FieldOffset(0x00FD)] public FPerPlatformBool bDiscardSkeletalMeshOptionalLODs;
    [FieldOffset(0x0100)] public FSoftObjectPath VisualizeCalibrationColorMaterialPath;
    [FieldOffset(0x0118)] public FSoftObjectPath VisualizeCalibrationCustomMaterialPath;
    [FieldOffset(0x0130)] public FSoftObjectPath VisualizeCalibrationGrayscaleMaterialPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct URendererOverrideSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public byte bSupportAllShaderPermutations;
    [FieldOffset(0x0038)] public byte bForceRecomputeTangents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x23A8)] 
public unsafe struct UReplayNetConnection
{
    [FieldOffset(0x0000)] public UNetConnection baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UReplaySubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public bool bLoadDefaultMapOnStop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UReplicationDriver
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UReplicationConnectionDriver
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UReporterBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UReporterGraph
{
    [FieldOffset(0x0000)] public UReporterBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UReverbEffect
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bBypassEarlyReflections;
    [FieldOffset(0x002C)] public float ReflectionsDelay;
    [FieldOffset(0x0030)] public float GainHF;
    [FieldOffset(0x0034)] public float ReflectionsGain;
    [FieldOffset(0x0038)] public bool bBypassLateReflections;
    [FieldOffset(0x003C)] public float LateDelay;
    [FieldOffset(0x0040)] public float DecayTime;
    [FieldOffset(0x0044)] public float Density;
    [FieldOffset(0x0048)] public float Diffusion;
    [FieldOffset(0x004C)] public float AirAbsorptionGainHF;
    [FieldOffset(0x0050)] public float DecayHFRatio;
    [FieldOffset(0x0054)] public float LateGain;
    [FieldOffset(0x0058)] public float Gain;
    [FieldOffset(0x005C)] public float RoomRolloffFactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRigTransformConstraint
{
    [FieldOffset(0x0000)] public EConstraintTransform TranformType;
    [FieldOffset(0x0004)] public FName ParentSpace;
    [FieldOffset(0x000C)] public float Weight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTransformBaseConstraint
{
    [FieldOffset(0x0000)] public TArray<FRigTransformConstraint> TransformConstraints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTransformBase
{
    [FieldOffset(0x0000)] public FName Node;
    [FieldOffset(0x0008)] public FTransformBaseConstraint Constraints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FNode
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FName ParentName;
    [FieldOffset(0x0010)] public FTransform Transform;
    [FieldOffset(0x0040)] public FString DisplayName;
    [FieldOffset(0x0050)] public bool bAdvanced;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct URig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<FTransformBase> TransformBases;
    [FieldOffset(0x0040)] public TArray<FNode> Nodes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct URotatingMovementComponent
{
    [FieldOffset(0x0000)] public UMovementComponent baseObj;
    [FieldOffset(0x00F0)] public FRotator RotationRate;
    [FieldOffset(0x00FC)] public FVector PivotTranslation;
    [FieldOffset(0x0108)] public byte bRotationInLocalSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct URuntimeOptionsBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct URuntimeVirtualTexture
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int TileCount;
    [FieldOffset(0x002C)] public int TileSize;
    [FieldOffset(0x0030)] public int TileBorderSize;
    [FieldOffset(0x0034)] public ERuntimeVirtualTextureMaterialType MaterialType;
    [FieldOffset(0x0035)] public bool bCompressTextures;
    [FieldOffset(0x0036)] public bool bClearTextures;
    [FieldOffset(0x0037)] public bool bSinglePhysicalSpace;
    [FieldOffset(0x0038)] public bool bPrivateSpace;
    [FieldOffset(0x0039)] public bool bAdaptive;
    [FieldOffset(0x003A)] public bool bContinuousUpdate;
    [FieldOffset(0x003C)] public int RemoveLowMips;
    [FieldOffset(0x0040)] public TextureGroup LODGroup;
    [FieldOffset(0x0044)] public int Size;
    [FieldOffset(0x0048)] public URuntimeVirtualTextureStreamingProxy* StreamingTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct URuntimeVirtualTextureComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public TSoftObjectPtr<AActor> BoundsAlignActor;
    [FieldOffset(0x0220)] public bool bSetBoundsButton;
    [FieldOffset(0x0221)] public bool bSnapBoundsToLandscape;
    [FieldOffset(0x0228)] public URuntimeVirtualTexture* VirtualTexture;
    [FieldOffset(0x0230)] public bool bEnableScalability;
    [FieldOffset(0x0234)] public uint ScalabilityGroup;
    [FieldOffset(0x0238)] public bool bHidePrimitives;
    [FieldOffset(0x0240)] public UVirtualTextureBuilder* StreamingTexture;
    [FieldOffset(0x0248)] public int StreamLowMips;
    [FieldOffset(0x024C)] public bool bBuildStreamingMipsButton;
    [FieldOffset(0x024D)] public bool bEnableCompressCrunch;
    [FieldOffset(0x024E)] public bool bUseStreamingLowMipsInEditor;
    [FieldOffset(0x024F)] public bool bBuildDebugStreamingMips;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ARuntimeVirtualTextureVolume
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public URuntimeVirtualTextureComponent* VirtualTextureComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IRVOAvoidanceInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UScene
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8C0)] 
public unsafe struct USceneCaptureComponent2D
{
    [FieldOffset(0x0000)] public USceneCaptureComponent baseObj;
    [FieldOffset(0x02B0)] public ECameraProjectionMode ProjectionType;
    [FieldOffset(0x02B4)] public float FOVAngle;
    [FieldOffset(0x02B8)] public float OrthoWidth;
    [FieldOffset(0x02C0)] public UTextureRenderTarget2D* TextureTarget;
    [FieldOffset(0x02C8)] public EAtlSceneCaptureMode AtlSceneCaptureMode;
    [FieldOffset(0x02C9)] public ESceneCaptureCompositeMode CompositeMode;
    [FieldOffset(0x02D0)] public FPostProcessSettings PostProcessSettings;
    [FieldOffset(0x0830)] public float PostProcessBlendWeight;
    [FieldOffset(0x0834)] public byte bOverride_CustomNearClippingPlane;
    [FieldOffset(0x0838)] public float CustomNearClippingPlane;
    [FieldOffset(0x083C)] public bool bUseCustomProjectionMatrix;
    [FieldOffset(0x0840)] public FMatrix CustomProjectionMatrix;
    [FieldOffset(0x0880)] public UTexture2D* AtlBgTexture;
    [FieldOffset(0x0888)] public bool bEnableClipPlane;
    [FieldOffset(0x088C)] public FVector ClipPlaneBase;
    [FieldOffset(0x0898)] public FVector ClipPlaneNormal;
    [FieldOffset(0x08A4)] public byte bCameraCutThisFrame;
    [FieldOffset(0x08A4)] public byte bConsiderUnrenderedOpaquePixelAsFullyTranslucent;
    [FieldOffset(0x08A8)] public bool bDisableFlipCopyGLES;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct USceneCaptureComponentCube
{
    [FieldOffset(0x0000)] public USceneCaptureComponent baseObj;
    [FieldOffset(0x02B0)] public UTextureRenderTargetCube* TextureTarget;
    [FieldOffset(0x02B8)] public bool bCaptureRotation;
    [FieldOffset(0x02C0)] public UTextureRenderTargetCube* TextureTargetLeft;
    [FieldOffset(0x02C8)] public UTextureRenderTargetCube* TextureTargetRight;
    [FieldOffset(0x02D0)] public UTextureRenderTarget2D* TextureTargetODS;
    [FieldOffset(0x02D8)] public float IPD;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ASceneCaptureCube
{
    [FieldOffset(0x0000)] public ASceneCapture baseObj;
    [FieldOffset(0x0230)] public USceneCaptureComponentCube* CaptureComponentCube;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBPVariableMetaDataEntry
{
    [FieldOffset(0x0000)] public FName DataKey;
    [FieldOffset(0x0008)] public FString DataValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct USCS_Node
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UClass* ComponentClass;
    [FieldOffset(0x0030)] public UActorComponent* ComponentTemplate;
    [FieldOffset(0x0038)] public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
    [FieldOffset(0x0080)] public FName AttachToName;
    [FieldOffset(0x0088)] public FName ParentComponentOrVariableName;
    [FieldOffset(0x0090)] public FName ParentComponentOwnerClassName;
    [FieldOffset(0x0098)] public bool bIsParentComponentNative;
    [FieldOffset(0x00A0)] public TArray<IntPtr> ChildNodes;
    [FieldOffset(0x00B0)] public TArray<FBPVariableMetaDataEntry> MetaDataArray;
    [FieldOffset(0x00C0)] public FGuid VariableGuid;
    [FieldOffset(0x00D0)] public FName InternalVariableName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct USelection
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AServerStatReplicator
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public bool bUpdateStatNet;
    [FieldOffset(0x0221)] public bool bOverwriteClientStats;
    [FieldOffset(0x0224)] public uint Channels;
    [FieldOffset(0x0228)] public uint InRate;
    [FieldOffset(0x022C)] public uint OutRate;
    [FieldOffset(0x0234)] public uint MaxPacketOverhead;
    [FieldOffset(0x0238)] public uint InRateClientMax;
    [FieldOffset(0x023C)] public uint InRateClientMin;
    [FieldOffset(0x0240)] public uint InRateClientAvg;
    [FieldOffset(0x0244)] public uint InPacketsClientMax;
    [FieldOffset(0x0248)] public uint InPacketsClientMin;
    [FieldOffset(0x024C)] public uint InPacketsClientAvg;
    [FieldOffset(0x0250)] public uint OutRateClientMax;
    [FieldOffset(0x0254)] public uint OutRateClientMin;
    [FieldOffset(0x0258)] public uint OutRateClientAvg;
    [FieldOffset(0x025C)] public uint OutPacketsClientMax;
    [FieldOffset(0x0260)] public uint OutPacketsClientMin;
    [FieldOffset(0x0264)] public uint OutPacketsClientAvg;
    [FieldOffset(0x0268)] public uint NetNumClients;
    [FieldOffset(0x026C)] public uint InPackets;
    [FieldOffset(0x0270)] public uint OutPackets;
    [FieldOffset(0x0274)] public uint InBunches;
    [FieldOffset(0x0278)] public uint OutBunches;
    [FieldOffset(0x027C)] public uint OutLoss;
    [FieldOffset(0x0280)] public uint InLoss;
    [FieldOffset(0x0284)] public uint VoiceBytesSent;
    [FieldOffset(0x0288)] public uint VoiceBytesRecv;
    [FieldOffset(0x028C)] public uint VoicePacketsSent;
    [FieldOffset(0x0290)] public uint VoicePacketsRecv;
    [FieldOffset(0x0294)] public uint PercentInVoice;
    [FieldOffset(0x0298)] public uint PercentOutVoice;
    [FieldOffset(0x029C)] public uint NumActorChannels;
    [FieldOffset(0x02A0)] public uint NumConsideredActors;
    [FieldOffset(0x02A4)] public uint PrioritizedActors;
    [FieldOffset(0x02A8)] public uint NumRelevantActors;
    [FieldOffset(0x02AC)] public uint NumRelevantDeletedActors;
    [FieldOffset(0x02B0)] public uint NumReplicatedActorAttempts;
    [FieldOffset(0x02B4)] public uint NumReplicatedActors;
    [FieldOffset(0x02B8)] public uint NumActors;
    [FieldOffset(0x02BC)] public uint NumNetActors;
    [FieldOffset(0x02C0)] public uint NumDormantActors;
    [FieldOffset(0x02C4)] public uint NumInitiallyDormantActors;
    [FieldOffset(0x02C8)] public uint NumNetGUIDsAckd;
    [FieldOffset(0x02CC)] public uint NumNetGUIDsPending;
    [FieldOffset(0x02D0)] public uint NumNetGUIDsUnAckd;
    [FieldOffset(0x02D4)] public uint ObjPathBytes;
    [FieldOffset(0x02D8)] public uint NetGUIDOutRate;
    [FieldOffset(0x02DC)] public uint NetGUIDInRate;
    [FieldOffset(0x02E0)] public uint NetSaturated;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UShadowMapTexture2D
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
    [FieldOffset(0x01A0)] public EShadowMapFlags ShadowmapFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct USimpleConstructionScript
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> RootNodes;
    [FieldOffset(0x0038)] public TArray<IntPtr> AllNodes;
    [FieldOffset(0x0048)] public USCS_Node* DefaultSceneRootNode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FMeshUVChannelInfo
{
    [FieldOffset(0x0000)] public bool bInitialized;
    [FieldOffset(0x0001)] public bool bOverrideDensities;
    [FieldOffset(0x0004)] public float LocalUVDensities;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSkeletalMaterial
{
    [FieldOffset(0x0000)] public UMaterialInterface* MaterialInterface;
    [FieldOffset(0x0008)] public FName MaterialSlotName;
    [FieldOffset(0x0010)] public FMeshUVChannelInfo UVChannelData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FBoneMirrorInfo
{
    [FieldOffset(0x0000)] public int SourceIndex;
    [FieldOffset(0x0004)] public EAxis BoneFlipAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FSkeletalMeshBuildSettings
{
    [FieldOffset(0x0000)] public byte bRecomputeNormals;
    [FieldOffset(0x0000)] public byte bRecomputeTangents;
    [FieldOffset(0x0000)] public byte bUseMikkTSpace;
    [FieldOffset(0x0000)] public byte bComputeWeightedNormals;
    [FieldOffset(0x0000)] public byte bRemoveDegenerates;
    [FieldOffset(0x0000)] public byte bUseHighPrecisionTangentBasis;
    [FieldOffset(0x0000)] public byte bUseFullPrecisionUVs;
    [FieldOffset(0x0000)] public byte bBuildAdjacencyBuffer;
    [FieldOffset(0x0004)] public float ThresholdPosition;
    [FieldOffset(0x0008)] public float ThresholdTangentNormal;
    [FieldOffset(0x000C)] public float ThresholdUV;
    [FieldOffset(0x0010)] public float MorphThresholdPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FSkeletalMeshOptimizationSettings
{
    [FieldOffset(0x0000)] public SkeletalMeshTerminationCriterion TerminationCriterion;
    [FieldOffset(0x0004)] public float NumOfTrianglesPercentage;
    [FieldOffset(0x0008)] public float NumOfVertPercentage;
    [FieldOffset(0x000C)] public uint MaxNumOfTriangles;
    [FieldOffset(0x0010)] public uint MaxNumOfVerts;
    [FieldOffset(0x0014)] public float MaxDeviationPercentage;
    [FieldOffset(0x0018)] public SkeletalMeshOptimizationType ReductionMethod;
    [FieldOffset(0x0019)] public SkeletalMeshOptimizationImportance SilhouetteImportance;
    [FieldOffset(0x001A)] public SkeletalMeshOptimizationImportance TextureImportance;
    [FieldOffset(0x001B)] public SkeletalMeshOptimizationImportance ShadingImportance;
    [FieldOffset(0x001C)] public SkeletalMeshOptimizationImportance SkinningImportance;
    [FieldOffset(0x001D)] public byte bRemapMorphTargets;
    [FieldOffset(0x001D)] public byte bRecalcNormals;
    [FieldOffset(0x0020)] public float WeldingThreshold;
    [FieldOffset(0x0024)] public float NormalsThreshold;
    [FieldOffset(0x0028)] public int MaxBonesPerVertex;
    [FieldOffset(0x002C)] public byte bEnforceBoneBoundaries;
    [FieldOffset(0x0030)] public float VolumeImportance;
    [FieldOffset(0x0034)] public byte bLockEdges;
    [FieldOffset(0x0034)] public byte bLockColorBounaries;
    [FieldOffset(0x0038)] public int BaseLOD;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FSkeletalMeshLODInfo
{
    [FieldOffset(0x0000)] public FPerPlatformFloat ScreenSize;
    [FieldOffset(0x0004)] public float LODHysteresis;
    [FieldOffset(0x0008)] public TArray<int> LODMaterialMap;
    [FieldOffset(0x0018)] public FSkeletalMeshBuildSettings BuildSettings;
    [FieldOffset(0x002C)] public FSkeletalMeshOptimizationSettings ReductionSettings;
    [FieldOffset(0x0068)] public TArray<FBoneReference> BonesToRemove;
    [FieldOffset(0x0078)] public TArray<FBoneReference> BonesToPrioritize;
    [FieldOffset(0x0088)] public float WeightOfPrioritization;
    [FieldOffset(0x0090)] public UAnimSequence* BakePose;
    [FieldOffset(0x0098)] public UAnimSequence* BakePoseOverride;
    [FieldOffset(0x00A0)] public FString SourceImportFilename;
    [FieldOffset(0x00B0)] public ESkinCacheUsage SkinCacheUsage;
    [FieldOffset(0x00B1)] public byte bHasBeenSimplified;
    [FieldOffset(0x00B1)] public byte bHasPerLODVertexColors;
    [FieldOffset(0x00B1)] public byte bAllowCPUAccess;
    [FieldOffset(0x00B1)] public byte bSupportUniformlyDistributedSampling;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSkeletalMeshSamplingRegionMaterialFilter
{
    [FieldOffset(0x0000)] public FName MaterialName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSkeletalMeshSamplingRegionBoneFilter
{
    [FieldOffset(0x0000)] public FName BoneName;
    [FieldOffset(0x0008)] public byte bIncludeOrExclude;
    [FieldOffset(0x0008)] public byte bApplyToChildren;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkeletalMeshSamplingRegion
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int LODIndex;
    [FieldOffset(0x000C)] public byte bSupportUniformlyDistributedSampling;
    [FieldOffset(0x0010)] public TArray<FSkeletalMeshSamplingRegionMaterialFilter> MaterialFilters;
    [FieldOffset(0x0020)] public TArray<FSkeletalMeshSamplingRegionBoneFilter> BoneFilters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FSkeletalMeshSamplingLODBuiltData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FSkeletalMeshSamplingRegionBuiltData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSkeletalMeshSamplingBuiltData
{
    [FieldOffset(0x0000)] public TArray<FSkeletalMeshSamplingLODBuiltData> WholeMeshBuiltData;
    [FieldOffset(0x0010)] public TArray<FSkeletalMeshSamplingRegionBuiltData> RegionBuiltData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkeletalMeshSamplingInfo
{
    [FieldOffset(0x0000)] public TArray<FSkeletalMeshSamplingRegion> Regions;
    [FieldOffset(0x0010)] public FSkeletalMeshSamplingBuiltData BuiltData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkinWeightProfileInfo
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FPerPlatformBool DefaultProfile;
    [FieldOffset(0x000C)] public FPerPlatformInt DefaultProfileFromLODIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct USkeletalMesh
{
    [FieldOffset(0x0000)] public UStreamableRenderAsset baseObj;
    [FieldOffset(0x0080)] public USkeleton* Skeleton;
    [FieldOffset(0x0088)] public FBoxSphereBounds ImportedBounds;
    [FieldOffset(0x00A4)] public FBoxSphereBounds ExtendedBounds;
    [FieldOffset(0x00C0)] public FVector PositiveBoundsExtension;
    [FieldOffset(0x00CC)] public FVector NegativeBoundsExtension;
    [FieldOffset(0x00D8)] public TArray<FSkeletalMaterial> Materials;
    [FieldOffset(0x00E8)] public TArray<FBoneMirrorInfo> SkelMirrorTable;
    [FieldOffset(0x00F8)] public TArray<FSkeletalMeshLODInfo> LODInfo;
    [FieldOffset(0x0158)] public FPerPlatformInt MinLOD;
    [FieldOffset(0x015C)] public FPerPlatformBool DisableBelowMinLodStripping;
    [FieldOffset(0x015D)] public EAxis SkelMirrorAxis;
    [FieldOffset(0x015E)] public EAxis SkelMirrorFlipAxis;
    [FieldOffset(0x015F)] public byte bUseFullPrecisionUVs;
    [FieldOffset(0x015F)] public byte bUseHighPrecisionTangentBasis;
    [FieldOffset(0x015F)] public byte bHasBeenSimplified;
    [FieldOffset(0x015F)] public byte bHasVertexColors;
    [FieldOffset(0x015F)] public byte bEnablePerPolyCollision;
    [FieldOffset(0x0160)] public UBodySetup* BodySetup;
    [FieldOffset(0x0168)] public UPhysicsAsset* PhysicsAsset;
    [FieldOffset(0x0170)] public UPhysicsAsset* ShadowPhysicsAsset;
    [FieldOffset(0x0178)] public TArray<IntPtr> NodeMappingData;
    [FieldOffset(0x0188)] public byte bSupportRayTracing;
    [FieldOffset(0x0190)] public TArray<IntPtr> MorphTargets;
    [FieldOffset(0x0318)] public TSubclassOf<UAnimInstance> PostProcessAnimBlueprint;
    [FieldOffset(0x0320)] public TArray<IntPtr> MeshClothingAssets;
    [FieldOffset(0x0330)] public FSkeletalMeshSamplingInfo SamplingInfo;
    [FieldOffset(0x0360)] public TArray<IntPtr> AssetUserData;
    [FieldOffset(0x0370)] public TArray<IntPtr> Sockets;
    [FieldOffset(0x0390)] public TArray<FSkinWeightProfileInfo> SkinWeightProfiles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ASkeletalMeshActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public byte bShouldDoAnimNotifies;
    [FieldOffset(0x0228)] public byte bWakeOnLevelStart;
    [FieldOffset(0x0230)] public USkeletalMeshComponent* SkeletalMeshComponent;
    [FieldOffset(0x0238)] public USkeletalMesh* ReplicatedMesh;
    [FieldOffset(0x0240)] public UPhysicsAsset* ReplicatedPhysAsset;
    [FieldOffset(0x0248)] public UMaterialInterface* ReplicatedMaterial0;
    [FieldOffset(0x0250)] public UMaterialInterface* ReplicatedMaterial1;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USkeletalMeshEditorData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBoneFilter
{
    [FieldOffset(0x0000)] public bool bExcludeSelf;
    [FieldOffset(0x0004)] public FName BoneName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FSkeletalMeshLODGroupSettings
{
    [FieldOffset(0x0000)] public FPerPlatformFloat ScreenSize;
    [FieldOffset(0x0004)] public float LODHysteresis;
    [FieldOffset(0x0008)] public EBoneFilterActionOption BoneFilterActionOption;
    [FieldOffset(0x0010)] public TArray<FBoneFilter> BoneList;
    [FieldOffset(0x0020)] public TArray<FName> BonesToPrioritize;
    [FieldOffset(0x0030)] public float WeightOfPrioritization;
    [FieldOffset(0x0038)] public UAnimSequence* BakePose;
    [FieldOffset(0x0040)] public FSkeletalMeshOptimizationSettings ReductionSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USkeletalMeshLODSettings
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FPerPlatformInt MinLOD;
    [FieldOffset(0x0034)] public FPerPlatformBool DisableBelowMinLodStripping;
    [FieldOffset(0x0035)] public bool bOverrideLODStreamingSettings;
    [FieldOffset(0x0036)] public FPerPlatformBool bSupportLODStreaming;
    [FieldOffset(0x0038)] public FPerPlatformInt MaxNumStreamedLODs;
    [FieldOffset(0x003C)] public FPerPlatformInt MaxNumOptionalLODs;
    [FieldOffset(0x0040)] public TArray<FSkeletalMeshLODGroupSettings> LODGroups;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkeletalMeshSimplificationSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FName SkeletalMeshReductionModuleName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USkeletalMeshSocket
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName SocketName;
    [FieldOffset(0x0030)] public FName BoneName;
    [FieldOffset(0x0038)] public FVector RelativeLocation;
    [FieldOffset(0x0044)] public FRotator RelativeRotation;
    [FieldOffset(0x0050)] public FVector RelativeScale;
    [FieldOffset(0x005C)] public bool bForceAlwaysAnimated;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FTentDistribution
{
    [FieldOffset(0x0000)] public float TipAltitude;
    [FieldOffset(0x0004)] public float TipValue;
    [FieldOffset(0x0008)] public float Width;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct USkyAtmosphereComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public ESkyAtmosphereTransformMode TransformMode;
    [FieldOffset(0x01FC)] public float BottomRadius;
    [FieldOffset(0x0200)] public FColor GroundAlbedo;
    [FieldOffset(0x0204)] public float AtmosphereHeight;
    [FieldOffset(0x0208)] public float MultiScatteringFactor;
    [FieldOffset(0x020C)] public float TraceSampleCountScale;
    [FieldOffset(0x0210)] public float RayleighScatteringScale;
    [FieldOffset(0x0214)] public FLinearColor RayleighScattering;
    [FieldOffset(0x0224)] public float RayleighExponentialDistribution;
    [FieldOffset(0x0228)] public float MieScatteringScale;
    [FieldOffset(0x022C)] public FLinearColor MieScattering;
    [FieldOffset(0x023C)] public float MieAbsorptionScale;
    [FieldOffset(0x0240)] public FLinearColor MieAbsorption;
    [FieldOffset(0x0250)] public float MieAnisotropy;
    [FieldOffset(0x0254)] public float MieExponentialDistribution;
    [FieldOffset(0x0258)] public float OtherAbsorptionScale;
    [FieldOffset(0x025C)] public FLinearColor OtherAbsorption;
    [FieldOffset(0x026C)] public FTentDistribution OtherTentDistribution;
    [FieldOffset(0x0278)] public FLinearColor SkyLuminanceFactor;
    [FieldOffset(0x0288)] public float AerialPespectiveViewDistanceScale;
    [FieldOffset(0x028C)] public float HeightFogContribution;
    [FieldOffset(0x0290)] public float TransmittanceMinLightElevationAngle;
    [FieldOffset(0x0294)] public float AerialPerspectiveStartDepth;
    [FieldOffset(0x02BC)] public FGuid bStaticLightingBuiltGUID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ASkyAtmosphere
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public USkyAtmosphereComponent* SkyAtmosphereComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x400)] 
public unsafe struct USkyLightComponent
{
    [FieldOffset(0x0000)] public ULightComponentBase baseObj;
    [FieldOffset(0x0228)] public bool bRealTimeCapture;
    [FieldOffset(0x0229)] public ESkyLightSourceType SourceType;
    [FieldOffset(0x0230)] public UTextureCube* Cubemap;
    [FieldOffset(0x0238)] public float SourceCubemapAngle;
    [FieldOffset(0x023C)] public int CubemapResolution;
    [FieldOffset(0x0240)] public float SkyDistanceThreshold;
    [FieldOffset(0x0244)] public bool bCaptureEmissiveOnly;
    [FieldOffset(0x0245)] public bool bLowerHemisphereIsBlack;
    [FieldOffset(0x0248)] public FLinearColor LowerHemisphereColor;
    [FieldOffset(0x0258)] public float OcclusionMaxDistance;
    [FieldOffset(0x025C)] public float Contrast;
    [FieldOffset(0x0260)] public float OcclusionExponent;
    [FieldOffset(0x0264)] public float MinOcclusion;
    [FieldOffset(0x0268)] public FColor OcclusionTint;
    [FieldOffset(0x026C)] public byte bCloudAmbientOcclusion;
    [FieldOffset(0x0270)] public float CloudAmbientOcclusionStrength;
    [FieldOffset(0x0274)] public float CloudAmbientOcclusionExtent;
    [FieldOffset(0x0278)] public float CloudAmbientOcclusionMapResolutionScale;
    [FieldOffset(0x027C)] public float CloudAmbientOcclusionApertureScale;
    [FieldOffset(0x0280)] public EOcclusionCombineMode OcclusionCombineMode;
    [FieldOffset(0x0328)] public UTextureCube* BlendDestinationCubemap;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USlateBrushAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSlateBrush Brush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ISlateTextureAtlasInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct USmokeTestCommandlet
{
    [FieldOffset(0x0000)] public UCommandlet baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C8)] 
public unsafe struct USoundAttenuation
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSoundAttenuationSettings Attenuation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FSoundClassProperties
{
    [FieldOffset(0x0000)] public float Volume;
    [FieldOffset(0x0004)] public float Pitch;
    [FieldOffset(0x0008)] public float LowPassFilterFrequency;
    [FieldOffset(0x000C)] public float AttenuationDistanceScale;
    [FieldOffset(0x0010)] public float LFEBleed;
    [FieldOffset(0x0014)] public float VoiceCenterChannelVolume;
    [FieldOffset(0x0018)] public float RadioFilterVolume;
    [FieldOffset(0x001C)] public float RadioFilterVolumeThreshold;
    [FieldOffset(0x0020)] public byte bApplyEffects;
    [FieldOffset(0x0020)] public byte bAlwaysPlay;
    [FieldOffset(0x0020)] public byte bIsUISound;
    [FieldOffset(0x0020)] public byte bIsMusic;
    [FieldOffset(0x0020)] public byte bCenterChannelOnly;
    [FieldOffset(0x0020)] public byte bApplyAmbientVolumes;
    [FieldOffset(0x0020)] public byte bReverb;
    [FieldOffset(0x0024)] public float Default2DReverbSendAmount;
    [FieldOffset(0x0028)] public FSoundModulationDefaultSettings ModulationSettings;
    [FieldOffset(0x0068)] public EAudioOutputTarget OutputTarget;
    [FieldOffset(0x0069)] public ESoundWaveLoadingBehavior LoadingBehavior;
    [FieldOffset(0x0070)] public USoundSubmix* DefaultSubmix;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPassiveSoundMixModifier
{
    [FieldOffset(0x0000)] public USoundMix* SoundMix;
    [FieldOffset(0x0008)] public float MinVolumeThreshold;
    [FieldOffset(0x000C)] public float MaxVolumeThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct USoundClass
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSoundClassProperties Properties;
    [FieldOffset(0x00A0)] public TArray<IntPtr> ChildClasses;
    [FieldOffset(0x00B0)] public TArray<FPassiveSoundMixModifier> PassiveSoundMixModifiers;
    [FieldOffset(0x00C0)] public USoundClass* ParentClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundConcurrency
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSoundConcurrencySettings Concurrency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x548)] 
public unsafe struct USoundCue
{
    [FieldOffset(0x0000)] public USoundBase baseObj;
    [FieldOffset(0x0170)] public byte bPrimeOnLoad;
    [FieldOffset(0x0178)] public USoundNode* FirstNode;
    [FieldOffset(0x0180)] public float VolumeMultiplier;
    [FieldOffset(0x0184)] public float PitchMultiplier;
    [FieldOffset(0x0188)] public FSoundAttenuationSettings AttenuationOverrides;
    [FieldOffset(0x0528)] public float SubtitlePriority;
    [FieldOffset(0x0530)] public byte bOverrideAttenuation;
    [FieldOffset(0x0530)] public byte bExcludeFromRandomNodeBranchCulling;
    [FieldOffset(0x0534)] public int CookedQualityIndex;
    [FieldOffset(0x0538)] public byte bHasPlayWhenSilent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USoundEffectSourcePresetChain
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FSourceEffectChainEntry> Chain;
    [FieldOffset(0x0038)] public byte bPlayEffectChainTails;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSoundGroup
{
    [FieldOffset(0x0000)] public ESoundGroup SoundGroup;
    [FieldOffset(0x0008)] public FString DisplayName;
    [FieldOffset(0x0018)] public byte bAlwaysDecompressOnLoad;
    [FieldOffset(0x001C)] public float DecompressedDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct USoundGroups
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FSoundGroup> SoundGroupProfiles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAudioEffectParameters
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAudioEQEffect
{
    [FieldOffset(0x0000)] public FAudioEffectParameters baseObj;
    [FieldOffset(0x0010)] public float FrequencyCenter0;
    [FieldOffset(0x0014)] public float Gain0;
    [FieldOffset(0x0018)] public float Bandwidth0;
    [FieldOffset(0x001C)] public float FrequencyCenter1;
    [FieldOffset(0x0020)] public float Gain1;
    [FieldOffset(0x0024)] public float Bandwidth1;
    [FieldOffset(0x0028)] public float FrequencyCenter2;
    [FieldOffset(0x002C)] public float Gain2;
    [FieldOffset(0x0030)] public float Bandwidth2;
    [FieldOffset(0x0034)] public float FrequencyCenter3;
    [FieldOffset(0x0038)] public float Gain3;
    [FieldOffset(0x003C)] public float Bandwidth3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSoundClassAdjuster
{
    [FieldOffset(0x0000)] public USoundClass* SoundClassObject;
    [FieldOffset(0x0008)] public float VolumeAdjuster;
    [FieldOffset(0x000C)] public float PitchAdjuster;
    [FieldOffset(0x0010)] public float LowPassFilterFrequency;
    [FieldOffset(0x0014)] public byte bApplyToChildren;
    [FieldOffset(0x0018)] public float VoiceCenterChannelVolumeAdjuster;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct USoundMix
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bApplyEQ;
    [FieldOffset(0x002C)] public float EQPriority;
    [FieldOffset(0x0030)] public FAudioEQEffect EQSettings;
    [FieldOffset(0x0070)] public TArray<FSoundClassAdjuster> SoundClassEffects;
    [FieldOffset(0x0080)] public float InitialDelay;
    [FieldOffset(0x0084)] public float fadeInTime;
    [FieldOffset(0x0088)] public float Duration;
    [FieldOffset(0x008C)] public float fadeOutTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct USoundNode
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> ChildNodes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct USoundNodeAssetReferencer
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F8)] 
public unsafe struct USoundNodeAttenuation
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0050)] public FSoundAttenuationSettings AttenuationOverrides;
    [FieldOffset(0x03F0)] public byte bOverrideAttenuation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeBranch
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public FName BoolParameterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeConcatenator
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public TArray<float> InputVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeDelay
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public float DelayMin;
    [FieldOffset(0x004C)] public float DelayMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDialogueWaveParameter
{
    [FieldOffset(0x0000)] public UDialogueWave* DialogueWave;
    [FieldOffset(0x0008)] public FDialogueContext Context;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct USoundNodeDialoguePlayer
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public FDialogueWaveParameter DialogueWaveParameter;
    [FieldOffset(0x0068)] public byte bLooping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDistanceDatum
{
    [FieldOffset(0x0000)] public float FadeInDistanceStart;
    [FieldOffset(0x0004)] public float FadeInDistanceEnd;
    [FieldOffset(0x0008)] public float FadeOutDistanceStart;
    [FieldOffset(0x000C)] public float FadeOutDistanceEnd;
    [FieldOffset(0x0010)] public float Volume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeDistanceCrossFade
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public TArray<FDistanceDatum> CrossFadeInput;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeDoppler
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public float DopplerIntensity;
    [FieldOffset(0x004C)] public bool bUseSmoothing;
    [FieldOffset(0x0050)] public float SmoothingInterpSpeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct USoundNodeEnveloper
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public float LoopStart;
    [FieldOffset(0x004C)] public float LoopEnd;
    [FieldOffset(0x0050)] public float DurationAfterLoop;
    [FieldOffset(0x0054)] public int LoopCount;
    [FieldOffset(0x0058)] public byte bLoopIndefinitely;
    [FieldOffset(0x0058)] public byte bLoop;
    [FieldOffset(0x0060)] public UDistributionFloatConstantCurve* VolumeInterpCurve;
    [FieldOffset(0x0068)] public UDistributionFloatConstantCurve* PitchInterpCurve;
    [FieldOffset(0x0070)] public FRuntimeFloatCurve VolumeCurve;
    [FieldOffset(0x00F8)] public FRuntimeFloatCurve PitchCurve;
    [FieldOffset(0x0180)] public float PitchMin;
    [FieldOffset(0x0184)] public float PitchMax;
    [FieldOffset(0x0188)] public float VolumeMin;
    [FieldOffset(0x018C)] public float VolumeMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeGroupControl
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public TArray<int> GroupSizes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeLooping
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public int LoopCount;
    [FieldOffset(0x004C)] public byte bLoopIndefinitely;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct USoundNodeMature
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeMixer
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public TArray<float> InputVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeModulator
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public float PitchMin;
    [FieldOffset(0x004C)] public float PitchMax;
    [FieldOffset(0x0050)] public float VolumeMin;
    [FieldOffset(0x0054)] public float VolumeMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FModulatorContinuousParams
{
    [FieldOffset(0x0000)] public FName ParameterName;
    [FieldOffset(0x0008)] public float Default;
    [FieldOffset(0x000C)] public float MinInput;
    [FieldOffset(0x0010)] public float MaxInput;
    [FieldOffset(0x0014)] public float MinOutput;
    [FieldOffset(0x0018)] public float MaxOutput;
    [FieldOffset(0x001C)] public ModulationParamMode ParamMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct USoundNodeModulatorContinuous
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public FModulatorContinuousParams PitchModulationParams;
    [FieldOffset(0x0068)] public FModulatorContinuousParams VolumeModulationParams;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct USoundNodeOscillator
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public byte bModulateVolume;
    [FieldOffset(0x0048)] public byte bModulatePitch;
    [FieldOffset(0x004C)] public float AmplitudeMin;
    [FieldOffset(0x0050)] public float AmplitudeMax;
    [FieldOffset(0x0054)] public float FrequencyMin;
    [FieldOffset(0x0058)] public float FrequencyMax;
    [FieldOffset(0x005C)] public float OffsetMin;
    [FieldOffset(0x0060)] public float OffsetMax;
    [FieldOffset(0x0064)] public float CenterMin;
    [FieldOffset(0x0068)] public float CenterMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USoundNodeParamCrossFade
{
    [FieldOffset(0x0000)] public USoundNodeDistanceCrossFade baseObj;
    [FieldOffset(0x0058)] public FName ParamName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeQualityLevel
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public int CookedQualityLevelIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct USoundNodeRandom
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public TArray<float> Weights;
    [FieldOffset(0x0058)] public TArray<bool> HasBeenUsed;
    [FieldOffset(0x0068)] public int NumRandomUsed;
    [FieldOffset(0x006C)] public int PreselectAtLevelLoad;
    [FieldOffset(0x0070)] public byte bShouldExcludeFromBranchCulling;
    [FieldOffset(0x0070)] public byte bSoundCueExcludedFromBranchCulling;
    [FieldOffset(0x0070)] public byte bRandomizeWithoutReplacement;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USoundNodeSoundClass
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public USoundClass* SoundClassOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeSwitch
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public FName IntParameterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundNodeWaveParam
{
    [FieldOffset(0x0000)] public USoundNode baseObj;
    [FieldOffset(0x0048)] public FName WaveParameterName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct USoundNodeWavePlayer
{
    [FieldOffset(0x0000)] public USoundNodeAssetReferencer baseObj;
    [FieldOffset(0x0048)] public TSoftObjectPtr<USoundWave> SoundWaveAssetPtr;
    [FieldOffset(0x0070)] public USoundWave* SoundWave;
    [FieldOffset(0x0080)] public byte bLooping;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct USoundSourceBus
{
    [FieldOffset(0x0000)] public USoundWave baseObj;
    [FieldOffset(0x0370)] public ESourceBusChannels SourceBusChannels;
    [FieldOffset(0x0374)] public float SourceBusDuration;
    [FieldOffset(0x0378)] public UAudioBus* AudioBus;
    [FieldOffset(0x0380)] public byte bAutoDeactivateWhenSilent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct USoundSubmixBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> ChildSubmixes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USoundSubmixWithParentBase
{
    [FieldOffset(0x0000)] public USoundSubmixBase baseObj;
    [FieldOffset(0x0038)] public USoundSubmixBase* ParentSubmix;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct USoundSubmix
{
    [FieldOffset(0x0000)] public USoundSubmixWithParentBase baseObj;
    [FieldOffset(0x0040)] public byte bMuteWhenBackgrounded;
    [FieldOffset(0x0048)] public TArray<IntPtr> SubmixEffectChain;
    [FieldOffset(0x0058)] public USoundfieldEncodingSettingsBase* AmbisonicsPluginSettings;
    [FieldOffset(0x0060)] public int EnvelopeFollowerAttackTime;
    [FieldOffset(0x0064)] public int EnvelopeFollowerReleaseTime;
    [FieldOffset(0x0068)] public EGainParamMode GainMode;
    [FieldOffset(0x006C)] public float OutputVolume;
    [FieldOffset(0x0070)] public float WetLevel;
    [FieldOffset(0x0074)] public float DryLevel;
    [FieldOffset(0x0078)] public FSoundModulationDestinationSettings OutputVolumeModulation;
    [FieldOffset(0x0088)] public FSoundModulationDestinationSettings WetLevelModulation;
    [FieldOffset(0x0098)] public FSoundModulationDestinationSettings DryLevelModulation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USoundfieldSubmix
{
    [FieldOffset(0x0000)] public USoundSubmixWithParentBase baseObj;
    [FieldOffset(0x0040)] public FName SoundfieldEncodingFormat;
    [FieldOffset(0x0048)] public USoundfieldEncodingSettingsBase* EncodingSettings;
    [FieldOffset(0x0050)] public TArray<IntPtr> SoundfieldEffectChain;
    [FieldOffset(0x0060)] public TSubclassOf<USoundfieldEncodingSettingsBase> EncodingSettingsClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UEndpointSubmix
{
    [FieldOffset(0x0000)] public USoundSubmixBase baseObj;
    [FieldOffset(0x0038)] public FName EndpointType;
    [FieldOffset(0x0040)] public TSubclassOf<UAudioEndpointSettingsBase> EndpointSettingsClass;
    [FieldOffset(0x0048)] public UAudioEndpointSettingsBase* EndpointSettings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct USoundfieldEndpointSubmix
{
    [FieldOffset(0x0000)] public USoundSubmixBase baseObj;
    [FieldOffset(0x0038)] public FName SoundfieldEndpointType;
    [FieldOffset(0x0040)] public TSubclassOf<UAudioEndpointSettingsBase> EndpointSettingsClass;
    [FieldOffset(0x0048)] public USoundfieldEndpointSettingsBase* EndpointSettings;
    [FieldOffset(0x0050)] public TSubclassOf<USoundfieldEncodingSettingsBase> EncodingSettingsClass;
    [FieldOffset(0x0058)] public USoundfieldEncodingSettingsBase* EncodingSettings;
    [FieldOffset(0x0060)] public TArray<IntPtr> SoundfieldEffectChain;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ASpectatorPawn
{
    [FieldOffset(0x0000)] public ADefaultPawn baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct USpectatorPawnMovement
{
    [FieldOffset(0x0000)] public UFloatingPawnMovement baseObj;
    [FieldOffset(0x0150)] public byte bIgnoreTimeDilation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ASphereReflectionCapture
{
    [FieldOffset(0x0000)] public AReflectionCapture baseObj;
    [FieldOffset(0x0228)] public UDrawSphereComponent* DrawCaptureRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct USphereReflectionCaptureComponent
{
    [FieldOffset(0x0000)] public UReflectionCaptureComponent baseObj;
    [FieldOffset(0x0270)] public float InfluenceRadius;
    [FieldOffset(0x0274)] public float CaptureDistanceScale;
    [FieldOffset(0x0278)] public UDrawSphereComponent* PreviewInfluenceRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USplineMetadata
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ASplineMeshActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USplineMeshComponent* SplineMeshComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FSplineMeshParams
{
    [FieldOffset(0x0000)] public FVector StartPos;
    [FieldOffset(0x000C)] public FVector StartTangent;
    [FieldOffset(0x0018)] public FVector2D StartScale;
    [FieldOffset(0x0020)] public float StartRoll;
    [FieldOffset(0x0024)] public FVector2D StartOffset;
    [FieldOffset(0x002C)] public FVector EndPos;
    [FieldOffset(0x0038)] public FVector2D EndScale;
    [FieldOffset(0x0040)] public FVector EndTangent;
    [FieldOffset(0x004C)] public float EndRoll;
    [FieldOffset(0x0050)] public FVector2D EndOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x580)] 
public unsafe struct USplineMeshComponent
{
    [FieldOffset(0x0000)] public UStaticMeshComponent baseObj;
    [FieldOffset(0x04E8)] public FSplineMeshParams SplineParams;
    [FieldOffset(0x0540)] public FVector SplineUpDir;
    [FieldOffset(0x054C)] public float SplineBoundaryMin;
    [FieldOffset(0x0550)] public FGuid CachedMeshBodySetupGuid;
    [FieldOffset(0x0560)] public UBodySetup* BodySetup;
    [FieldOffset(0x0568)] public float SplineBoundaryMax;
    [FieldOffset(0x056C)] public byte bAllowSplineEditingPerInstance;
    [FieldOffset(0x056C)] public byte bSmoothInterpRollScale;
    [FieldOffset(0x056C)] public byte bMeshDirty;
    [FieldOffset(0x056D)] public ESplineMeshAxis ForwardAxis;
    [FieldOffset(0x0570)] public float VirtualTextureMainPassMaxDrawDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct USpotLightComponent
{
    [FieldOffset(0x0000)] public UPointLightComponent baseObj;
    [FieldOffset(0x0358)] public float InnerConeAngle;
    [FieldOffset(0x035C)] public float OuterConeAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct USpringArmComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float TargetArmLength;
    [FieldOffset(0x01FC)] public FVector SocketOffset;
    [FieldOffset(0x0208)] public FVector TargetOffset;
    [FieldOffset(0x0214)] public float ProbeSize;
    [FieldOffset(0x0218)] public ECollisionChannel ProbeChannel;
    [FieldOffset(0x021C)] public byte bDoCollisionTest;
    [FieldOffset(0x021C)] public byte bUsePawnControlRotation;
    [FieldOffset(0x021C)] public byte bInheritPitch;
    [FieldOffset(0x021C)] public byte bInheritYaw;
    [FieldOffset(0x021C)] public byte bInheritRoll;
    [FieldOffset(0x021C)] public byte bEnableCameraLag;
    [FieldOffset(0x021C)] public byte bEnableCameraRotationLag;
    [FieldOffset(0x021C)] public byte bUseCameraLagSubstepping;
    [FieldOffset(0x021D)] public byte bDrawDebugLagMarkers;
    [FieldOffset(0x0220)] public float CameraLagSpeed;
    [FieldOffset(0x0224)] public float CameraRotationLagSpeed;
    [FieldOffset(0x0228)] public float CameraLagMaxTimeStep;
    [FieldOffset(0x022C)] public float CameraLagMaxDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FStaticMaterial
{
    [FieldOffset(0x0000)] public UMaterialInterface* MaterialInterface;
    [FieldOffset(0x0008)] public FName MaterialSlotName;
    [FieldOffset(0x0010)] public FName ImportedMaterialSlotName;
    [FieldOffset(0x0018)] public FMeshUVChannelInfo UVChannelData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UStaticMesh
{
    [FieldOffset(0x0000)] public UStreamableRenderAsset baseObj;
    [FieldOffset(0x0080)] public FPerPlatformInt MinLOD;
    [FieldOffset(0x0084)] public float LpvBiasMultiplier;
    [FieldOffset(0x0088)] public TArray<FStaticMaterial> StaticMaterials;
    [FieldOffset(0x0098)] public float LightmapUVDensity;
    [FieldOffset(0x009C)] public int LightMapResolution;
    [FieldOffset(0x00A0)] public int LightMapCoordinateIndex;
    [FieldOffset(0x00A4)] public float DistanceFieldSelfShadowBias;
    [FieldOffset(0x00A8)] public UBodySetup* BodySetup;
    [FieldOffset(0x00B0)] public int LODForCollision;
    [FieldOffset(0x00B4)] public byte bGenerateMeshDistanceField;
    [FieldOffset(0x00B4)] public byte bStripComplexCollisionForConsole;
    [FieldOffset(0x00B4)] public byte bHasNavigationData;
    [FieldOffset(0x00B4)] public byte bSupportUniformlyDistributedSampling;
    [FieldOffset(0x00B4)] public byte bSupportPhysicalMaterialMasks;
    [FieldOffset(0x00B4)] public byte bSupportRayTracing;
    [FieldOffset(0x00B4)] public byte bIsBuiltAtRuntime;
    [FieldOffset(0x00B5)] public byte bAllowCPUAccess;
    [FieldOffset(0x00B5)] public byte bSupportGpuUniformlyDistributedSampling;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sockets;
    [FieldOffset(0x00F8)] public FVector PositiveBoundsExtension;
    [FieldOffset(0x0104)] public FVector NegativeBoundsExtension;
    [FieldOffset(0x0110)] public FBoxSphereBounds ExtendedBounds;
    [FieldOffset(0x012C)] public int ElementToIgnoreForTexFactor;
    [FieldOffset(0x0130)] public TArray<IntPtr> AssetUserData;
    [FieldOffset(0x0140)] public UObject* EditableMesh;
    [FieldOffset(0x0148)] public UNavCollisionBase* NavCollision;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UStaticMeshSocket
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName SocketName;
    [FieldOffset(0x0030)] public FVector RelativeLocation;
    [FieldOffset(0x003C)] public FRotator RelativeRotation;
    [FieldOffset(0x0048)] public FVector RelativeScale;
    [FieldOffset(0x0058)] public FString Tag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UStereoLayerShape
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UStereoLayerShapeQuad
{
    [FieldOffset(0x0000)] public UStereoLayerShape baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UStereoLayerShapeCylinder
{
    [FieldOffset(0x0000)] public UStereoLayerShape baseObj;
    [FieldOffset(0x0028)] public float Radius;
    [FieldOffset(0x002C)] public float OverlayArc;
    [FieldOffset(0x0030)] public int Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UStereoLayerShapeCubemap
{
    [FieldOffset(0x0000)] public UStereoLayerShape baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FEquirectProps
{
    [FieldOffset(0x0000)] public FBox2D LeftUVRect;
    [FieldOffset(0x0014)] public FBox2D RightUVRect;
    [FieldOffset(0x0028)] public FVector2D LeftScale;
    [FieldOffset(0x0030)] public FVector2D RightScale;
    [FieldOffset(0x0038)] public FVector2D LeftBias;
    [FieldOffset(0x0040)] public FVector2D RightBias;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UStereoLayerShapeEquirect
{
    [FieldOffset(0x0000)] public UStereoLayerShape baseObj;
    [FieldOffset(0x0028)] public FBox2D LeftUVRect;
    [FieldOffset(0x003C)] public FBox2D RightUVRect;
    [FieldOffset(0x0050)] public FVector2D LeftScale;
    [FieldOffset(0x0058)] public FVector2D RightScale;
    [FieldOffset(0x0060)] public FVector2D LeftBias;
    [FieldOffset(0x0068)] public FVector2D RightBias;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UStereoLayerComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public byte bLiveTexture;
    [FieldOffset(0x01F8)] public byte bSupportsDepth;
    [FieldOffset(0x01F8)] public byte bNoAlphaChannel;
    [FieldOffset(0x0200)] public UTexture* Texture;
    [FieldOffset(0x0208)] public UTexture* LeftTexture;
    [FieldOffset(0x0210)] public byte bQuadPreserveTextureRatio;
    [FieldOffset(0x0214)] public FVector2D QuadSize;
    [FieldOffset(0x021C)] public FBox2D UVRect;
    [FieldOffset(0x0230)] public float CylinderRadius;
    [FieldOffset(0x0234)] public float CylinderOverlayArc;
    [FieldOffset(0x0238)] public int CylinderHeight;
    [FieldOffset(0x023C)] public FEquirectProps EquirectProps;
    [FieldOffset(0x0284)] public EStereoLayerType StereoLayerType;
    [FieldOffset(0x0285)] public EStereoLayerShape StereoLayerShape;
    [FieldOffset(0x0288)] public UStereoLayerShape* Shape;
    [FieldOffset(0x0290)] public int Priority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UStereoLayerFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UStringTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8C)] 
public unsafe struct FSubsurfaceProfileStruct
{
    [FieldOffset(0x0000)] public FLinearColor SurfaceAlbedo;
    [FieldOffset(0x0010)] public FLinearColor MeanFreePathColor;
    [FieldOffset(0x0020)] public float MeanFreePathDistance;
    [FieldOffset(0x0024)] public float WorldUnitScale;
    [FieldOffset(0x0028)] public bool bEnableBurley;
    [FieldOffset(0x002C)] public float ScatterRadius;
    [FieldOffset(0x0030)] public FLinearColor SubsurfaceColor;
    [FieldOffset(0x0040)] public FLinearColor FalloffColor;
    [FieldOffset(0x0050)] public FLinearColor BoundaryColorBleed;
    [FieldOffset(0x0060)] public float ExtinctionScale;
    [FieldOffset(0x0064)] public float NormalScale;
    [FieldOffset(0x0068)] public float ScatteringDistribution;
    [FieldOffset(0x006C)] public float IOR;
    [FieldOffset(0x0070)] public float Roughness0;
    [FieldOffset(0x0074)] public float Roughness1;
    [FieldOffset(0x0078)] public float LobeMix;
    [FieldOffset(0x007C)] public FLinearColor TransmissionTintColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct USubsurfaceProfile
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FSubsurfaceProfileStruct Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USubsystemBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USubUVAnimation
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UTexture2D* SubUVTexture;
    [FieldOffset(0x0030)] public int SubImages_Horizontal;
    [FieldOffset(0x0034)] public int SubImages_Vertical;
    [FieldOffset(0x0038)] public ESubUVBoundingVertexCount BoundingMode;
    [FieldOffset(0x0039)] public EOpacitySourceMode OpacitySourceMode;
    [FieldOffset(0x003C)] public float AlphaThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USystemTimeTimecodeProvider
{
    [FieldOffset(0x0000)] public UTimecodeProvider baseObj;
    [FieldOffset(0x0030)] public FFrameRate FrameRate;
    [FieldOffset(0x0038)] public bool bGenerateFullFrame;
    [FieldOffset(0x0039)] public bool bUseHighPerformanceClock;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UTextPropertyTestObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FText DefaultedText;
    [FieldOffset(0x0040)] public FText UndefaultedText;
    [FieldOffset(0x0058)] public FText TransientText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATextRenderActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UTextRenderComponent* TextRender;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UTextRenderComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public FText Text;
    [FieldOffset(0x0468)] public UMaterialInterface* TextMaterial;
    [FieldOffset(0x0470)] public UFont* Font;
    [FieldOffset(0x0478)] public EHorizTextAligment HorizontalAlignment;
    [FieldOffset(0x0479)] public EVerticalTextAligment VerticalAlignment;
    [FieldOffset(0x047C)] public FColor TextRenderColor;
    [FieldOffset(0x0480)] public float XScale;
    [FieldOffset(0x0484)] public float YScale;
    [FieldOffset(0x0488)] public float WorldSize;
    [FieldOffset(0x048C)] public float InvDefaultSize;
    [FieldOffset(0x0490)] public float HorizSpacingAdjust;
    [FieldOffset(0x0494)] public float VertSpacingAdjust;
    [FieldOffset(0x0498)] public byte bAlwaysRenderAsText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E0)] 
public unsafe struct UTexture2DArray
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x01D0)] public TextureAddress AddressX;
    [FieldOffset(0x01D1)] public TextureAddress AddressY;
    [FieldOffset(0x01D2)] public TextureAddress AddressZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UTexture2DDynamic
{
    [FieldOffset(0x0000)] public UTexture baseObj;
    [FieldOffset(0x0180)] public EPixelFormat Format;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UTextureLightProfile
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
    [FieldOffset(0x01A0)] public float Brightness;
    [FieldOffset(0x01A4)] public float TextureMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTextureMipDataProviderFactory
{
    [FieldOffset(0x0000)] public UAssetUserData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UTextureRenderTarget2DArray
{
    [FieldOffset(0x0000)] public UTextureRenderTarget baseObj;
    [FieldOffset(0x0180)] public int SizeX;
    [FieldOffset(0x0184)] public int SizeY;
    [FieldOffset(0x0188)] public int Slices;
    [FieldOffset(0x018C)] public FLinearColor ClearColor;
    [FieldOffset(0x019C)] public EPixelFormat OverrideFormat;
    [FieldOffset(0x019D)] public byte bHDR;
    [FieldOffset(0x019D)] public byte bForceLinearGamma;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UTextureRenderTargetCube
{
    [FieldOffset(0x0000)] public UTextureRenderTarget baseObj;
    [FieldOffset(0x0180)] public int SizeX;
    [FieldOffset(0x0184)] public FLinearColor ClearColor;
    [FieldOffset(0x0194)] public EPixelFormat OverrideFormat;
    [FieldOffset(0x0195)] public byte bHDR;
    [FieldOffset(0x0195)] public byte bForceLinearGamma;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UTextureRenderTargetVolume
{
    [FieldOffset(0x0000)] public UTextureRenderTarget baseObj;
    [FieldOffset(0x0180)] public int SizeX;
    [FieldOffset(0x0184)] public int SizeY;
    [FieldOffset(0x0188)] public int SizeZ;
    [FieldOffset(0x018C)] public FLinearColor ClearColor;
    [FieldOffset(0x019C)] public EPixelFormat OverrideFormat;
    [FieldOffset(0x019D)] public byte bHDR;
    [FieldOffset(0x019D)] public byte bForceLinearGamma;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UThumbnailInfo
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FTimelineEventEntry
{
    [FieldOffset(0x0000)] public float Time;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FTimelineVectorTrack
{
    [FieldOffset(0x0000)] public UCurveVector* VectorCurve;
    [FieldOffset(0x0018)] public FName TrackName;
    [FieldOffset(0x0020)] public FName VectorPropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FTimelineFloatTrack
{
    [FieldOffset(0x0000)] public UCurveFloat* FloatCurve;
    [FieldOffset(0x0018)] public FName TrackName;
    [FieldOffset(0x0020)] public FName FloatPropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FTimelineLinearColorTrack
{
    [FieldOffset(0x0000)] public UCurveLinearColor* LinearColorCurve;
    [FieldOffset(0x0018)] public FName TrackName;
    [FieldOffset(0x0020)] public FName LinearColorPropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FTimeline
{
    [FieldOffset(0x0000)] public ETimelineLengthMode LengthMode;
    [FieldOffset(0x0001)] public byte bLooping;
    [FieldOffset(0x0001)] public byte bReversePlayback;
    [FieldOffset(0x0001)] public byte bPlaying;
    [FieldOffset(0x0004)] public float Length;
    [FieldOffset(0x0008)] public float PlayRate;
    [FieldOffset(0x000C)] public float Position;
    [FieldOffset(0x0010)] public TArray<FTimelineEventEntry> Events;
    [FieldOffset(0x0020)] public TArray<FTimelineVectorTrack> InterpVectors;
    [FieldOffset(0x0030)] public TArray<FTimelineFloatTrack> InterpFloats;
    [FieldOffset(0x0040)] public TArray<FTimelineLinearColorTrack> InterpLinearColors;
    [FieldOffset(0x0070)] public TWeakObjectPtr<UObject> PropertySetObject;
    [FieldOffset(0x0078)] public FName DirectionPropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UTimelineComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public FTimeline TheTimeline;
    [FieldOffset(0x0148)] public byte bIgnoreTimeDilation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTTTrackBase
{
    [FieldOffset(0x0008)] public FName TrackName;
    [FieldOffset(0x0010)] public bool bIsExternalCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTTEventTrack
{
    [FieldOffset(0x0000)] public FTTTrackBase baseObj;
    [FieldOffset(0x0018)] public FName FunctionName;
    [FieldOffset(0x0020)] public UCurveFloat* CurveKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FTTPropertyTrack
{
    [FieldOffset(0x0000)] public FTTTrackBase baseObj;
    [FieldOffset(0x0018)] public FName PropertyName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTTFloatTrack
{
    [FieldOffset(0x0000)] public FTTPropertyTrack baseObj;
    [FieldOffset(0x0020)] public UCurveFloat* CurveFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTTVectorTrack
{
    [FieldOffset(0x0000)] public FTTPropertyTrack baseObj;
    [FieldOffset(0x0020)] public UCurveVector* CurveVector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTTLinearColorTrack
{
    [FieldOffset(0x0000)] public FTTPropertyTrack baseObj;
    [FieldOffset(0x0020)] public UCurveLinearColor* CurveLinearColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UTimelineTemplate
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float TimelineLength;
    [FieldOffset(0x002C)] public ETimelineLengthMode LengthMode;
    [FieldOffset(0x002D)] public byte bAutoPlay;
    [FieldOffset(0x002D)] public byte bLoop;
    [FieldOffset(0x002D)] public byte bReplicated;
    [FieldOffset(0x002D)] public byte bIgnoreTimeDilation;
    [FieldOffset(0x0030)] public TArray<FTTEventTrack> EventTracks;
    [FieldOffset(0x0040)] public TArray<FTTFloatTrack> FloatTracks;
    [FieldOffset(0x0050)] public TArray<FTTVectorTrack> VectorTracks;
    [FieldOffset(0x0060)] public TArray<FTTLinearColorTrack> LinearColorTracks;
    [FieldOffset(0x0070)] public TArray<FBPVariableMetaDataEntry> MetaDataArray;
    [FieldOffset(0x0080)] public FGuid TimelineGuid;
    [FieldOffset(0x0090)] public ETickingGroup TimelineTickGroup;
    [FieldOffset(0x0094)] public FName VariableName;
    [FieldOffset(0x009C)] public FName DirectionPropertyName;
    [FieldOffset(0x00A4)] public FName UpdateFunctionName;
    [FieldOffset(0x00AC)] public FName FinishedFunctionName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTireType
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public float FrictionScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FTouchInputControl
{
    [FieldOffset(0x0000)] public UTexture2D* Image1;
    [FieldOffset(0x0008)] public UTexture2D* Image2;
    [FieldOffset(0x0010)] public FVector2D Center;
    [FieldOffset(0x0018)] public FVector2D VisualSize;
    [FieldOffset(0x0020)] public FVector2D ThumbSize;
    [FieldOffset(0x0028)] public FVector2D InteractionSize;
    [FieldOffset(0x0030)] public FVector2D InputScale;
    [FieldOffset(0x0038)] public FKey MainInputKey;
    [FieldOffset(0x0050)] public FKey AltInputKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UTouchInterface
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FTouchInputControl> Controls;
    [FieldOffset(0x0038)] public float ActiveOpacity;
    [FieldOffset(0x003C)] public float InactiveOpacity;
    [FieldOffset(0x0040)] public float TimeUntilDeactive;
    [FieldOffset(0x0044)] public float TimeUntilReset;
    [FieldOffset(0x0048)] public float ActivationDelay;
    [FieldOffset(0x004C)] public bool bPreventRecenter;
    [FieldOffset(0x0050)] public float StartupDelay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATriggerBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UShapeComponent* CollisionComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATriggerBox
{
    [FieldOffset(0x0000)] public ATriggerBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATriggerCapsule
{
    [FieldOffset(0x0000)] public ATriggerBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATriggerSphere
{
    [FieldOffset(0x0000)] public ATriggerBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTwitterIntegrationBase
{
    [FieldOffset(0x0000)] public UPlatformInterfaceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UUserDefinedEnum
{
    [FieldOffset(0x0000)] public UEnum baseObj;
    [FieldOffset(0x0060)] public TMap<FName, FText> DisplayNameMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UUserDefinedStruct
{
    [FieldOffset(0x0000)] public UScriptStruct baseObj;
    [FieldOffset(0x00C0)] public EUserDefinedStructureStatus Status;
    [FieldOffset(0x00C4)] public FGuid Guid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FHardwareCursorReference
{
    [FieldOffset(0x0000)] public FName CursorPath;
    [FieldOffset(0x0008)] public FVector2D HotSpot;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UUserInterfaceSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public ERenderFocusRule RenderFocusRule;
    [FieldOffset(0x0040)] public TMap<EMouseCursor, FHardwareCursorReference> HardwareCursors;
    [FieldOffset(0x0090)] public TMap<EMouseCursor, FSoftClassPath> SoftwareCursors;
    [FieldOffset(0x00E0)] public FSoftClassPath DefaultCursor;
    [FieldOffset(0x00F8)] public FSoftClassPath TextEditBeamCursor;
    [FieldOffset(0x0110)] public FSoftClassPath CrosshairsCursor;
    [FieldOffset(0x0128)] public FSoftClassPath HandCursor;
    [FieldOffset(0x0140)] public FSoftClassPath GrabHandCursor;
    [FieldOffset(0x0158)] public FSoftClassPath GrabHandClosedCursor;
    [FieldOffset(0x0170)] public FSoftClassPath SlashedCircleCursor;
    [FieldOffset(0x0188)] public float ApplicationScale;
    [FieldOffset(0x018C)] public EUIScalingRule UIScaleRule;
    [FieldOffset(0x0190)] public FSoftClassPath CustomScalingRuleClass;
    [FieldOffset(0x01A8)] public FRuntimeFloatCurve UIScaleCurve;
    [FieldOffset(0x0230)] public bool bAllowHighDPIInGameMode;
    [FieldOffset(0x0234)] public FIntPoint DesignScreenSize;
    [FieldOffset(0x023C)] public bool bLoadWidgetsOnDedicatedServer;
    [FieldOffset(0x0240)] public TArray<IntPtr> CursorClasses;
    [FieldOffset(0x0250)] public UClass* CustomScalingRuleClassInstance;
    [FieldOffset(0x0258)] public UDPICustomScalingRule* CustomScalingRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UVectorField
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FBox Bounds;
    [FieldOffset(0x0044)] public float Intensity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UVectorFieldAnimated
{
    [FieldOffset(0x0000)] public UVectorField baseObj;
    [FieldOffset(0x0048)] public UTexture2D* Texture;
    [FieldOffset(0x0050)] public EVectorFieldConstructionOp ConstructionOp;
    [FieldOffset(0x0054)] public int VolumeSizeX;
    [FieldOffset(0x0058)] public int VolumeSizeY;
    [FieldOffset(0x005C)] public int VolumeSizeZ;
    [FieldOffset(0x0060)] public int SubImagesX;
    [FieldOffset(0x0064)] public int SubImagesY;
    [FieldOffset(0x0068)] public int FrameCount;
    [FieldOffset(0x006C)] public float FramesPerSecond;
    [FieldOffset(0x0070)] public byte bLoop;
    [FieldOffset(0x0078)] public UVectorFieldStatic* NoiseField;
    [FieldOffset(0x0080)] public float NoiseScale;
    [FieldOffset(0x0084)] public float NoiseMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x480)] 
public unsafe struct UVectorFieldComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UVectorField* VectorField;
    [FieldOffset(0x0458)] public float Intensity;
    [FieldOffset(0x045C)] public float Tightness;
    [FieldOffset(0x0460)] public byte bPreviewVectorField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UVectorFieldStatic
{
    [FieldOffset(0x0000)] public UVectorField baseObj;
    [FieldOffset(0x0048)] public int SizeX;
    [FieldOffset(0x004C)] public int SizeY;
    [FieldOffset(0x0050)] public int SizeZ;
    [FieldOffset(0x0054)] public bool bAllowCPUAccess;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AVectorFieldVolume
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UVectorFieldComponent* VectorFieldComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UViewportStatsSubsystem
{
    [FieldOffset(0x0000)] public UWorldSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVirtualTexture
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULightMapVirtualTexture
{
    [FieldOffset(0x0000)] public UVirtualTexture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct URuntimeVirtualTextureStreamingProxy
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FVirtualTextureBuildSettings
{
    [FieldOffset(0x0000)] public int TileSize;
    [FieldOffset(0x0004)] public int TileBorderSize;
    [FieldOffset(0x0008)] public bool bEnableCompressCrunch;
    [FieldOffset(0x0009)] public bool bEnableCompressZlib;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UVirtualTexture2D
{
    [FieldOffset(0x0000)] public UTexture2D baseObj;
    [FieldOffset(0x01A0)] public FVirtualTextureBuildSettings Settings;
    [FieldOffset(0x01AC)] public bool bContinuousUpdate;
    [FieldOffset(0x01AD)] public bool bSinglePhysicalSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UVirtualTextureBuilder
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UVirtualTexture2D* Texture;
    [FieldOffset(0x0030)] public ulong BuildHash;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FVirtualTextureSpacePoolConfig
{
    [FieldOffset(0x0000)] public int MinTileSize;
    [FieldOffset(0x0004)] public int MaxTileSize;
    [FieldOffset(0x0008)] public TArray<EPixelFormat> Formats;
    [FieldOffset(0x0018)] public int SizeInMegabyte;
    [FieldOffset(0x001C)] public bool bAllowSizeScale;
    [FieldOffset(0x0020)] public uint ScalabilityGroup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UVirtualTexturePoolConfig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int DefaultSizeInMegabyte;
    [FieldOffset(0x0030)] public TArray<FVirtualTextureSpacePoolConfig> Pools;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVisualLoggerAutomationTests
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IVisualLoggerDebugSnapshotInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVisualLoggerKismetLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UVoiceChannel
{
    [FieldOffset(0x0000)] public UChannel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FVoiceSettings
{
    [FieldOffset(0x0000)] public USceneComponent* ComponentToAttachTo;
    [FieldOffset(0x0008)] public USoundAttenuation* AttenuationSettings;
    [FieldOffset(0x0010)] public USoundEffectSourcePresetChain* SourceEffectChain;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UVOIPTalker
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public FVoiceSettings Settings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVOIPStatics
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UVolumeTexture
{
    [FieldOffset(0x0000)] public UTexture baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct UVolumetricCloudComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float LayerBottomAltitude;
    [FieldOffset(0x01FC)] public float LayerHeight;
    [FieldOffset(0x0200)] public float TracingStartMaxDistance;
    [FieldOffset(0x0204)] public float TracingMaxDistance;
    [FieldOffset(0x0208)] public float PlanetRadius;
    [FieldOffset(0x020C)] public FColor GroundAlbedo;
    [FieldOffset(0x0210)] public UMaterialInterface* Material;
    [FieldOffset(0x0218)] public byte bUsePerSampleAtmosphericLightTransmittance;
    [FieldOffset(0x021C)] public float SkyLightCloudBottomOcclusion;
    [FieldOffset(0x0220)] public float ViewSampleCountScale;
    [FieldOffset(0x0224)] public float ReflectionSampleCountScale;
    [FieldOffset(0x0228)] public float ShadowViewSampleCountScale;
    [FieldOffset(0x022C)] public float ShadowReflectionSampleCountScale;
    [FieldOffset(0x0230)] public float ShadowTracingDistance;
    [FieldOffset(0x0234)] public float StopTracingTransmittanceThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AVolumetricCloud
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public UVolumetricCloudComponent* VolumetricCloudComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct AVolumetricLightmapDensityVolume
{
    [FieldOffset(0x0000)] public AVolume baseObj;
    [FieldOffset(0x0258)] public FInt32Interval AllowedMipLevelRange;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AWindDirectionalSource
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0220)] public UWindDirectionalSourceComponent* Component;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UWindDirectionalSourceComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public float Strength;
    [FieldOffset(0x01FC)] public float Speed;
    [FieldOffset(0x0200)] public float MinGustAmount;
    [FieldOffset(0x0204)] public float MaxGustAmount;
    [FieldOffset(0x0208)] public float Radius;
    [FieldOffset(0x020C)] public byte bPointWind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UWorldComposition
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public TArray<IntPtr> TilesStreaming;
    [FieldOffset(0x0058)] public double TilesStreamingTimeThreshold;
    [FieldOffset(0x0060)] public bool bLoadAllTilesDuringCinematic;
    [FieldOffset(0x0061)] public bool bRebaseOriginIn3DSpace;
    [FieldOffset(0x0064)] public float RebaseOriginDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMaterialProxySettings
{
    [FieldOffset(0x0000)] public FIntPoint TextureSize;
    [FieldOffset(0x0008)] public float GutterSpace;
    [FieldOffset(0x000C)] public float MetallicConstant;
    [FieldOffset(0x0010)] public float RoughnessConstant;
    [FieldOffset(0x0014)] public float AnisotropyConstant;
    [FieldOffset(0x0018)] public float SpecularConstant;
    [FieldOffset(0x001C)] public float OpacityConstant;
    [FieldOffset(0x0020)] public float OpacityMaskConstant;
    [FieldOffset(0x0024)] public float AmbientOcclusionConstant;
    [FieldOffset(0x0028)] public ETextureSizingType TextureSizingType;
    [FieldOffset(0x0029)] public EMaterialMergeType MaterialMergeType;
    [FieldOffset(0x002A)] public EBlendMode BlendMode;
    [FieldOffset(0x002B)] public byte bAllowTwoSidedMaterial;
    [FieldOffset(0x002B)] public byte bNormalMap;
    [FieldOffset(0x002B)] public byte bTangentMap;
    [FieldOffset(0x002B)] public byte bMetallicMap;
    [FieldOffset(0x002B)] public byte bRoughnessMap;
    [FieldOffset(0x002B)] public byte bAnisotropyMap;
    [FieldOffset(0x002B)] public byte bSpecularMap;
    [FieldOffset(0x002B)] public byte bEmissiveMap;
    [FieldOffset(0x002C)] public byte bOpacityMap;
    [FieldOffset(0x002C)] public byte bOpacityMaskMap;
    [FieldOffset(0x002C)] public byte bAmbientOcclusionMap;
    [FieldOffset(0x0030)] public FIntPoint DiffuseTextureSize;
    [FieldOffset(0x0038)] public FIntPoint NormalTextureSize;
    [FieldOffset(0x0040)] public FIntPoint TangentTextureSize;
    [FieldOffset(0x0048)] public FIntPoint MetallicTextureSize;
    [FieldOffset(0x0050)] public FIntPoint RoughnessTextureSize;
    [FieldOffset(0x0058)] public FIntPoint AnisotropyTextureSize;
    [FieldOffset(0x0060)] public FIntPoint SpecularTextureSize;
    [FieldOffset(0x0068)] public FIntPoint EmissiveTextureSize;
    [FieldOffset(0x0070)] public FIntPoint OpacityTextureSize;
    [FieldOffset(0x0078)] public FIntPoint OpacityMaskTextureSize;
    [FieldOffset(0x0080)] public FIntPoint AmbientOcclusionTextureSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FMeshProxySettings
{
    [FieldOffset(0x0000)] public int ScreenSize;
    [FieldOffset(0x0004)] public float VoxelSize;
    [FieldOffset(0x0008)] public FMaterialProxySettings MaterialSettings;
    [FieldOffset(0x0090)] public float MergeDistance;
    [FieldOffset(0x0094)] public FColor UnresolvedGeometryColor;
    [FieldOffset(0x0098)] public float MaxRayCastDist;
    [FieldOffset(0x009C)] public float HardAngleThreshold;
    [FieldOffset(0x00A0)] public int LightMapResolution;
    [FieldOffset(0x00A4)] public EProxyNormalComputationMethod NormalCalculationMethod;
    [FieldOffset(0x00A5)] public ELandscapeCullingPrecision LandscapeCullingPrecision;
    [FieldOffset(0x00A6)] public byte bCalculateCorrectLODModel;
    [FieldOffset(0x00A6)] public byte bOverrideVoxelSize;
    [FieldOffset(0x00A6)] public byte bOverrideTransferDistance;
    [FieldOffset(0x00A6)] public byte bUseHardAngleThreshold;
    [FieldOffset(0x00A6)] public byte bComputeLightMapResolution;
    [FieldOffset(0x00A6)] public byte bRecalculateNormals;
    [FieldOffset(0x00A6)] public byte bUseLandscapeCulling;
    [FieldOffset(0x00A6)] public byte bAllowAdjacency;
    [FieldOffset(0x00A7)] public byte bAllowDistanceField;
    [FieldOffset(0x00A7)] public byte bReuseMeshLightmapUVs;
    [FieldOffset(0x00A7)] public byte bCreateCollision;
    [FieldOffset(0x00A7)] public byte bAllowVertexColors;
    [FieldOffset(0x00A7)] public byte bGenerateLightmapUVs;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FMeshMergingSettings
{
    [FieldOffset(0x0000)] public int TargetLightMapResolution;
    [FieldOffset(0x0004)] public EUVOutput OutputUVs;
    [FieldOffset(0x000C)] public FMaterialProxySettings MaterialSettings;
    [FieldOffset(0x0094)] public int GutterSize;
    [FieldOffset(0x0098)] public int SpecificLOD;
    [FieldOffset(0x009C)] public EMeshLODSelectionType LODSelectionType;
    [FieldOffset(0x009D)] public byte bGenerateLightMapUV;
    [FieldOffset(0x009D)] public byte bComputedLightMapResolution;
    [FieldOffset(0x009D)] public byte bPivotPointAtZero;
    [FieldOffset(0x009D)] public byte bMergePhysicsData;
    [FieldOffset(0x009D)] public byte bMergeMaterials;
    [FieldOffset(0x009D)] public byte bCreateMergedMaterial;
    [FieldOffset(0x009D)] public byte bBakeVertexDataToMesh;
    [FieldOffset(0x009D)] public byte bUseVertexDataForBakingMaterial;
    [FieldOffset(0x009E)] public byte bUseTextureBinning;
    [FieldOffset(0x009E)] public byte bReuseMeshLightmapUVs;
    [FieldOffset(0x009E)] public byte bMergeEquivalentMaterials;
    [FieldOffset(0x009E)] public byte bUseLandscapeCulling;
    [FieldOffset(0x009E)] public byte bIncludeImposters;
    [FieldOffset(0x009E)] public byte bAllowDistanceField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct FHierarchicalSimplification
{
    [FieldOffset(0x0000)] public float TransitionScreenSize;
    [FieldOffset(0x0004)] public float OverrideDrawDistance;
    [FieldOffset(0x0008)] public byte bUseOverrideDrawDistance;
    [FieldOffset(0x0008)] public byte bAllowSpecificExclusion;
    [FieldOffset(0x0008)] public byte bSimplifyMesh;
    [FieldOffset(0x0008)] public byte bOnlyGenerateClustersForVolumes;
    [FieldOffset(0x0008)] public byte bReusePreviousLevelClusters;
    [FieldOffset(0x000C)] public FMeshProxySettings ProxySetting;
    [FieldOffset(0x00B4)] public FMeshMergingSettings MergeSetting;
    [FieldOffset(0x0154)] public float DesiredBoundRadius;
    [FieldOffset(0x0158)] public float DesiredFillingPercentage;
    [FieldOffset(0x015C)] public int MinNumberOfActorsToBuild;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UHierarchicalLODSetup
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FHierarchicalSimplification> HierarchicalLODSetup;
    [FieldOffset(0x0038)] public TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNetViewer
{
    [FieldOffset(0x0000)] public UNetConnection* Connection;
    [FieldOffset(0x0008)] public AActor* InViewer;
    [FieldOffset(0x0010)] public AActor* ViewTarget;
    [FieldOffset(0x0018)] public FVector ViewLocation;
    [FieldOffset(0x0024)] public FVector ViewDir;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct AWorldSettings
{
    [FieldOffset(0x0000)] public AInfo baseObj;
    [FieldOffset(0x0228)] public int VisibilityCellSize;
    [FieldOffset(0x022C)] public EVisibilityAggressiveness VisibilityAggressiveness;
    [FieldOffset(0x022D)] public byte bPrecomputeVisibility;
    [FieldOffset(0x022D)] public byte bPlaceCellsOnlyAlongCameraTracks;
    [FieldOffset(0x022D)] public byte bEnableWorldBoundsChecks;
    [FieldOffset(0x022D)] public byte bEnableNavigationSystem;
    [FieldOffset(0x022D)] public byte bEnableAISystem;
    [FieldOffset(0x022D)] public byte bEnableWorldComposition;
    [FieldOffset(0x022D)] public byte bUseClientSideLevelStreamingVolumes;
    [FieldOffset(0x022D)] public byte bEnableWorldOriginRebasing;
    [FieldOffset(0x022E)] public byte bWorldGravitySet;
    [FieldOffset(0x022E)] public byte bGlobalGravitySet;
    [FieldOffset(0x022E)] public byte bMinimizeBSPSections;
    [FieldOffset(0x022E)] public byte bForceNoPrecomputedLighting;
    [FieldOffset(0x022E)] public byte bHighPriorityLoading;
    [FieldOffset(0x022E)] public byte bHighPriorityLoadingLocal;
    [FieldOffset(0x022E)] public byte bOverrideDefaultBroadphaseSettings;
    [FieldOffset(0x0230)] public UNavigationSystemConfig* NavigationSystemConfig;
    [FieldOffset(0x0238)] public UNavigationSystemConfig* NavigationSystemConfigOverride;
    [FieldOffset(0x0240)] public float WorldToMeters;
    [FieldOffset(0x0244)] public float KillZ;
    [FieldOffset(0x0248)] public TSubclassOf<UDamageType> KillZDamageType;
    [FieldOffset(0x0250)] public float WorldGravityZ;
    [FieldOffset(0x0254)] public float GlobalGravityZ;
    [FieldOffset(0x0258)] public TSubclassOf<ADefaultPhysicsVolume> DefaultPhysicsVolumeClass;
    [FieldOffset(0x0260)] public TSubclassOf<UPhysicsCollisionHandler> PhysicsCollisionHandlerClass;
    [FieldOffset(0x0268)] public TSubclassOf<AGameModeBase> DefaultGameMode;
    [FieldOffset(0x0270)] public TSubclassOf<AGameNetworkManager> GameNetworkManagerClass;
    [FieldOffset(0x0278)] public int PackedLightAndShadowMapTextureSize;
    [FieldOffset(0x027C)] public FVector DefaultColorScale;
    [FieldOffset(0x0288)] public float DefaultMaxDistanceFieldOcclusionDistance;
    [FieldOffset(0x028C)] public float GlobalDistanceFieldViewDistance;
    [FieldOffset(0x0290)] public float DynamicIndirectShadowsSelfShadowingIntensity;
    [FieldOffset(0x0298)] public FReverbSettings DefaultReverbSettings;
    [FieldOffset(0x02B8)] public FInteriorSettings DefaultAmbientZoneSettings;
    [FieldOffset(0x02E0)] public USoundMix* DefaultBaseSoundMix;
    [FieldOffset(0x02E8)] public float TimeDilation;
    [FieldOffset(0x02EC)] public float MatineeTimeDilation;
    [FieldOffset(0x02F0)] public float DemoPlayTimeDilation;
    [FieldOffset(0x02F4)] public float MinGlobalTimeDilation;
    [FieldOffset(0x02F8)] public float MaxGlobalTimeDilation;
    [FieldOffset(0x02FC)] public float MinUndilatedFrameTime;
    [FieldOffset(0x0300)] public float MaxUndilatedFrameTime;
    [FieldOffset(0x0304)] public FBroadphaseSettings BroadphaseSettings;
    [FieldOffset(0x0348)] public APlayerState* Pauser;
    [FieldOffset(0x0350)] public TArray<FNetViewer> ReplicationViewers;
    [FieldOffset(0x0360)] public TArray<IntPtr> AssetUserData;
    [FieldOffset(0x0370)] public APlayerState* PauserPlayerState;
    [FieldOffset(0x0378)] public int MaxNumberOfBookmarks;
    [FieldOffset(0x0380)] public TSubclassOf<UBookmarkBase> DefaultBookmarkClass;
    [FieldOffset(0x0388)] public TArray<IntPtr> BookmarkArray;
    [FieldOffset(0x0398)] public TSubclassOf<UBookmarkBase> LastBookmarkClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FNavDataConfig
{
    [FieldOffset(0x0000)] public FNavAgentProperties baseObj;
    [FieldOffset(0x0030)] public FName Name;
    [FieldOffset(0x0038)] public FColor Color;
    [FieldOffset(0x003C)] public FVector DefaultQueryExtent;
    [FieldOffset(0x0048)] public TSubclassOf<AActor> NavigationDataClass;
    [FieldOffset(0x0050)] public TSoftClassPtr<AActor> NavDataClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FVectorDistribution
{
    [FieldOffset(0x0000)] public FDistributionLookupTable Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FVector4Distribution
{
    [FieldOffset(0x0000)] public FDistributionLookupTable Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFloatRK4SpringInterpolator
{
    [FieldOffset(0x0000)] public float StiffnessConstant;
    [FieldOffset(0x0004)] public float DampeningRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVectorRK4SpringInterpolator
{
    [FieldOffset(0x0000)] public float StiffnessConstant;
    [FieldOffset(0x0004)] public float DampeningRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FExpressionOutput
{
    [FieldOffset(0x0000)] public FName OutputName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FVector2MaterialInput
{
    [FieldOffset(0x0000)] public FMaterialInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FPlatformInterfaceData
{
    [FieldOffset(0x0000)] public FName DataName;
    [FieldOffset(0x0008)] public EPlatformInterfaceDataType Type;
    [FieldOffset(0x000C)] public int IntValue;
    [FieldOffset(0x0010)] public float FloatValue;
    [FieldOffset(0x0018)] public FString StringValue;
    [FieldOffset(0x0028)] public UObject* ObjectValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPlatformInterfaceDelegateResult
{
    [FieldOffset(0x0000)] public bool bSuccessful;
    [FieldOffset(0x0008)] public FPlatformInterfaceData Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimNode_Base
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPoseLinkBase
{
    [FieldOffset(0x0000)] public int LinkID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FComponentSpacePoseLink
{
    [FieldOffset(0x0000)] public FPoseLinkBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInputScaleBias
{
    [FieldOffset(0x0000)] public float Scale;
    [FieldOffset(0x0004)] public float Bias;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FInputAlphaBoolBlend
{
    [FieldOffset(0x0000)] public float BlendInTime;
    [FieldOffset(0x0004)] public float BlendOutTime;
    [FieldOffset(0x0008)] public EAlphaBlendOption BlendOption;
    [FieldOffset(0x0009)] public bool bInitialized;
    [FieldOffset(0x0010)] public UCurveFloat* CustomCurve;
    [FieldOffset(0x0018)] public FAlphaBlend AlphaBlend;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInputRange
{
    [FieldOffset(0x0000)] public float Min;
    [FieldOffset(0x0004)] public float Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FInputScaleBiasClamp
{
    [FieldOffset(0x0000)] public bool bMapRange;
    [FieldOffset(0x0001)] public bool bClampResult;
    [FieldOffset(0x0002)] public bool bInterpResult;
    [FieldOffset(0x0004)] public FInputRange InRange;
    [FieldOffset(0x000C)] public FInputRange OutRange;
    [FieldOffset(0x0014)] public float Scale;
    [FieldOffset(0x0018)] public float Bias;
    [FieldOffset(0x001C)] public float ClampMin;
    [FieldOffset(0x0020)] public float ClampMax;
    [FieldOffset(0x0024)] public float InterpSpeedIncreasing;
    [FieldOffset(0x0028)] public float InterpSpeedDecreasing;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPoseLink
{
    [FieldOffset(0x0000)] public FPoseLinkBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x770)] 
public unsafe struct FAnimInstanceProxy
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAnimNode_AssetPlayerBase
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FName GroupName;
    [FieldOffset(0x0018)] public EAnimGroupRole GroupRole;
    [FieldOffset(0x0019)] public EAnimSyncGroupScope GroupScope;
    [FieldOffset(0x001A)] public bool bIgnoreForRelevancyTest;
    [FieldOffset(0x001C)] public float BlendWeight;
    [FieldOffset(0x0020)] public float InternalTimeAccumulator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPerBoneBlendWeight
{
    [FieldOffset(0x0000)] public int SourceIndex;
    [FieldOffset(0x0004)] public float BlendWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimNode_Root
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Result;
    [FieldOffset(0x0020)] public FName Name;
    [FieldOffset(0x0028)] public FName Group;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAnimCurveParam
{
    [FieldOffset(0x0000)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FActorComponentDuplicatedObjectData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FActorComponentInstanceData
{
    [FieldOffset(0x0008)] public UObject* SourceComponentTemplate;
    [FieldOffset(0x0010)] public EComponentCreationMethod SourceComponentCreationMethod;
    [FieldOffset(0x0014)] public int SourceComponentTypeSerializedIndex;
    [FieldOffset(0x0018)] public TArray<byte> SavedProperties;
    [FieldOffset(0x0028)] public FActorComponentDuplicatedObjectData UniqueTransientPackage;
    [FieldOffset(0x0038)] public TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects;
    [FieldOffset(0x0048)] public TArray<IntPtr> ReferencedObjects;
    [FieldOffset(0x0058)] public TArray<FName> ReferencedNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FSceneComponentInstanceData
{
    [FieldOffset(0x0000)] public FActorComponentInstanceData baseObj;
    [FieldOffset(0x0068)] public TMap<IntPtr, FTransform> AttachedInstanceComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAnimationGroupReference
{
    [FieldOffset(0x0000)] public FName GroupName;
    [FieldOffset(0x0008)] public EAnimGroupRole GroupRole;
    [FieldOffset(0x0009)] public EAnimSyncGroupScope GroupScope;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FAnimGroupInstance
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FAnimTickRecord
{
    [FieldOffset(0x0000)] public UAnimationAsset* SourceAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FBlendFilter
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBlendSampleData
{
    [FieldOffset(0x0000)] public int SampleDataIndex;
    [FieldOffset(0x0008)] public UAnimSequence* Animation;
    [FieldOffset(0x0010)] public float TotalWeight;
    [FieldOffset(0x0014)] public float Time;
    [FieldOffset(0x0018)] public float PreviousTime;
    [FieldOffset(0x001C)] public float SamplePlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FAnimationRecordingSettings
{
    [FieldOffset(0x0000)] public bool bRecordInWorldSpace;
    [FieldOffset(0x0001)] public bool bRemoveRootAnimation;
    [FieldOffset(0x0002)] public bool bAutoSaveAsset;
    [FieldOffset(0x0004)] public float SampleRate;
    [FieldOffset(0x0008)] public float Length;
    [FieldOffset(0x000C)] public ERichCurveInterpMode InterpMode;
    [FieldOffset(0x000D)] public ERichCurveTangentMode TangentMode;
    [FieldOffset(0x000F)] public bool bRecordTransforms;
    [FieldOffset(0x0010)] public bool bRecordCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FComponentSpacePose
{
    [FieldOffset(0x0000)] public TArray<FTransform> Transforms;
    [FieldOffset(0x0010)] public TArray<FName> Names;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLocalSpacePose
{
    [FieldOffset(0x0000)] public TArray<FTransform> Transforms;
    [FieldOffset(0x0010)] public TArray<FName> Names;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FNamedTransform
{
    [FieldOffset(0x0000)] public FTransform Value;
    [FieldOffset(0x0030)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNamedColor
{
    [FieldOffset(0x0000)] public FColor Value;
    [FieldOffset(0x0004)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FNamedVector
{
    [FieldOffset(0x0000)] public FVector Value;
    [FieldOffset(0x000C)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FNamedFloat
{
    [FieldOffset(0x0000)] public float Value;
    [FieldOffset(0x0004)] public FName Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimParentNodeAssetOverride
{
    [FieldOffset(0x0000)] public UAnimationAsset* NewAsset;
    [FieldOffset(0x0008)] public FGuid ParentNodeGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FAnimBlueprintDebugData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FAnimationFrameSnapshot
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FStateMachineDebugData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FStateMachineStateDebugData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRootMotionExtractionStep
{
    [FieldOffset(0x0000)] public UAnimSequence* AnimSequence;
    [FieldOffset(0x0008)] public float StartPosition;
    [FieldOffset(0x000C)] public float EndPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimationErrorStats
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x198)] 
public unsafe struct FVectorCurve
{
    [FieldOffset(0x0000)] public FAnimCurveBase baseObj;
    [FieldOffset(0x0018)] public FRichCurve FloatCurves;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E0)] 
public unsafe struct FTransformCurve
{
    [FieldOffset(0x0000)] public FAnimCurveBase baseObj;
    [FieldOffset(0x0018)] public FVectorCurve TranslationCurve;
    [FieldOffset(0x01B0)] public FVectorCurve RotationCurve;
    [FieldOffset(0x0348)] public FVectorCurve ScaleCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FSlotEvaluationPose
{
    [FieldOffset(0x0000)] public EAdditiveAnimationType AdditiveType;
    [FieldOffset(0x0004)] public float Weight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FA2Pose
{
    [FieldOffset(0x0000)] public TArray<FTransform> Bones;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FA2CSPose
{
    [FieldOffset(0x0000)] public FA2Pose baseObj;
    [FieldOffset(0x0018)] public TArray<byte> ComponentSpaceFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FQueuedDrawDebugItem
{
    [FieldOffset(0x0000)] public EDrawDebugItemType ItemType;
    [FieldOffset(0x0004)] public FVector StartLoc;
    [FieldOffset(0x0010)] public FVector EndLoc;
    [FieldOffset(0x001C)] public FVector Center;
    [FieldOffset(0x0028)] public FRotator Rotation;
    [FieldOffset(0x0034)] public float Radius;
    [FieldOffset(0x0038)] public float Size;
    [FieldOffset(0x003C)] public int Segments;
    [FieldOffset(0x0040)] public FColor Color;
    [FieldOffset(0x0044)] public bool bPersistentLines;
    [FieldOffset(0x0048)] public float LifeTime;
    [FieldOffset(0x004C)] public float Thickness;
    [FieldOffset(0x0050)] public FString Message;
    [FieldOffset(0x0060)] public FVector2D TextScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FAnimInstanceSubsystemData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct FAnimMontageInstance
{
    [FieldOffset(0x0000)] public UAnimMontage* Montage;
    [FieldOffset(0x0028)] public bool bPlaying;
    [FieldOffset(0x002C)] public float DefaultBlendTimeMultiplier;
    [FieldOffset(0x00E8)] public TArray<int> NextSections;
    [FieldOffset(0x00F8)] public TArray<int> PrevSections;
    [FieldOffset(0x0118)] public TArray<FAnimNotifyEvent> ActiveStateBranchingPoints;
    [FieldOffset(0x0128)] public float Position;
    [FieldOffset(0x012C)] public float PlayRate;
    [FieldOffset(0x0130)] public FAlphaBlend Blend;
    [FieldOffset(0x018C)] public int DisableRootMotionCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FAnimNode_ApplyMeshSpaceAdditive
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Base;
    [FieldOffset(0x0020)] public FPoseLink Additive;
    [FieldOffset(0x0030)] public EAnimAlphaInputType AlphaInputType;
    [FieldOffset(0x0034)] public float Alpha;
    [FieldOffset(0x0038)] public byte bAlphaBoolEnabled;
    [FieldOffset(0x0040)] public FInputAlphaBoolBlend AlphaBoolBlend;
    [FieldOffset(0x0088)] public FName AlphaCurveName;
    [FieldOffset(0x0090)] public FInputScaleBias AlphaScaleBias;
    [FieldOffset(0x0098)] public FInputScaleBiasClamp AlphaScaleBiasClamp;
    [FieldOffset(0x00C8)] public int LODThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FAnimNode_CustomProperty
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public TArray<FName> SourcePropertyNames;
    [FieldOffset(0x0020)] public TArray<FName> DestPropertyNames;
    [FieldOffset(0x0030)] public UObject* TargetInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FAnimNode_Inertialization
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Source;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FInertializationPoseDiff
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FInertializationCurveDiff
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FInertializationBoneDiff
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FInertializationPose
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAnimNode_LinkedAnimGraph
{
    [FieldOffset(0x0000)] public FAnimNode_CustomProperty baseObj;
    [FieldOffset(0x0058)] public TArray<FPoseLink> InputPoses;
    [FieldOffset(0x0068)] public TArray<FName> InputPoseNames;
    [FieldOffset(0x0078)] public TSubclassOf<UAnimInstance> InstanceClass;
    [FieldOffset(0x0080)] public FName Tag;
    [FieldOffset(0x009C)] public byte bReceiveNotifiesFromLinkedInstances;
    [FieldOffset(0x009C)] public byte bPropagateNotifiesToLinkedInstances;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FAnimNode_LinkedAnimLayer
{
    [FieldOffset(0x0000)] public FAnimNode_LinkedAnimGraph baseObj;
    //[FieldOffset(0x00A0)] public TSubclassOf<UAnimLayerInterface> Interface;
    [FieldOffset(0x00A8)] public FName Layer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FAnimNode_LinkedInputPose
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FName Name;
    [FieldOffset(0x0018)] public FName Graph;
    [FieldOffset(0x0020)] public FPoseLink InputPose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct FAnimNode_SaveCachedPose
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink Pose;
    [FieldOffset(0x0020)] public FName CachePoseName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FAnimNode_SequencePlayer
{
    [FieldOffset(0x0000)] public FAnimNode_AssetPlayerBase baseObj;
    [FieldOffset(0x0038)] public UAnimSequenceBase* Sequence;
    [FieldOffset(0x0040)] public float PlayRateBasis;
    [FieldOffset(0x0044)] public float PlayRate;
    [FieldOffset(0x0048)] public FInputScaleBiasClamp PlayRateScaleBiasClamp;
    [FieldOffset(0x0078)] public float StartPosition;
    [FieldOffset(0x007C)] public bool bLoopAnimation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FAnimNode_StateMachine
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public int StateMachineIndexInClass;
    [FieldOffset(0x0014)] public int MaxTransitionsPerFrame;
    [FieldOffset(0x0018)] public bool bSkipFirstUpdateTransition;
    [FieldOffset(0x0019)] public bool bReinitializeOnBecomingRelevant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimationPotentialTransition
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FAnimationActiveTransitionEntry
{
    [FieldOffset(0x00B8)] public UBlendProfile* BlendProfile;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FAnimNode_TransitionPoseEvaluator
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x00E8)] public int FramesToCachePose;
    [FieldOffset(0x00F0)] public EEvaluatorDataSource DataSource;
    [FieldOffset(0x00F1)] public EEvaluatorMode EvaluatorMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAnimNode_TransitionResult
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public bool bCanEnterTransition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAnimNode_UseCachedPose
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink LinkToCachingNode;
    [FieldOffset(0x0020)] public FName CachePoseName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimNode_ConvertLocalToComponentSpace
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink LocalPose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimNode_ConvertComponentToLocalSpace
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FComponentSpacePoseLink ComponentPose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCompressedTrack
{
    [FieldOffset(0x0000)] public TArray<byte> ByteStream;
    [FieldOffset(0x0010)] public TArray<float> Times;
    [FieldOffset(0x0020)] public float Mins;
    [FieldOffset(0x002C)] public float Ranges;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCurveTrack
{
    [FieldOffset(0x0000)] public FName CurveName;
    [FieldOffset(0x0008)] public TArray<float> CurveWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FScaleTrack
{
    [FieldOffset(0x0000)] public TArray<FVector> ScaleKeys;
    [FieldOffset(0x0010)] public TArray<float> Times;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRotationTrack
{
    [FieldOffset(0x0000)] public TArray<FQuat> RotKeys;
    [FieldOffset(0x0010)] public TArray<float> Times;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FTranslationTrack
{
    [FieldOffset(0x0000)] public TArray<FVector> PosKeys;
    [FieldOffset(0x0010)] public TArray<float> Times;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FRawAnimSequenceTrack
{
    [FieldOffset(0x0000)] public TArray<FVector> PosKeys;
    [FieldOffset(0x0010)] public TArray<FQuat> RotKeys;
    [FieldOffset(0x0020)] public TArray<FVector> ScaleKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimSequenceTrackContainer
{
    [FieldOffset(0x0000)] public TArray<FRawAnimSequenceTrack> AnimationTracks;
    [FieldOffset(0x0010)] public TArray<FName> TrackNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8C0)] 
public unsafe struct FAnimSingleNodeInstanceProxy
{
    [FieldOffset(0x0000)] public FAnimInstanceProxy baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAnimNode_SingleNode
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink SourcePose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnimationTransitionRule
{
    [FieldOffset(0x0000)] public FName RuleToExecute;
    [FieldOffset(0x0008)] public bool TransitionReturnVal;
    [FieldOffset(0x000C)] public int TransitionIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAnimationState
{
    [FieldOffset(0x0000)] public FAnimationStateBase baseObj;
    [FieldOffset(0x0008)] public TArray<FAnimationTransitionRule> Transitions;
    [FieldOffset(0x0018)] public int StateRootNodeIndex;
    [FieldOffset(0x001C)] public int StartNotify;
    [FieldOffset(0x0020)] public int EndNotify;
    [FieldOffset(0x0024)] public int FullyBlendedNotify;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAnimNotifyTrack
{
    [FieldOffset(0x0000)] public FName TrackName;
    [FieldOffset(0x0008)] public FLinearColor TrackColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPerBoneBlendWeights
{
    [FieldOffset(0x0000)] public TArray<FPerBoneBlendWeight> BoneBlendWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FAssetImportInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAssetManagerSearchRules
{
    [FieldOffset(0x0000)] public TArray<FString> AssetScanPaths;
    [FieldOffset(0x0010)] public TArray<FString> IncludePatterns;
    [FieldOffset(0x0020)] public TArray<FString> ExcludePatterns;
    [FieldOffset(0x0030)] public UClass* AssetBaseClass;
    [FieldOffset(0x0038)] public bool bHasBlueprintClasses;
    [FieldOffset(0x0039)] public bool bForceSynchronousScan;
    [FieldOffset(0x003A)] public bool bSkipVirtualPathExpansion;
    [FieldOffset(0x003B)] public bool bSkipManagerIncludeCheck;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct FAtmospherePrecomputeInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FAudioReverbEffect
{
    [FieldOffset(0x0000)] public FAudioEffectParameters baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FNavAvoidanceData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FGridBlendSample
{
    [FieldOffset(0x0000)] public FEditorElement GridElement;
    [FieldOffset(0x0018)] public float BlendWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBPEditorBookmarkNode
{
    [FieldOffset(0x0000)] public FGuid NodeGuid;
    [FieldOffset(0x0010)] public FGuid ParentGuid;
    [FieldOffset(0x0020)] public FText DisplayName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEditedDocumentInfo
{
    [FieldOffset(0x0000)] public FSoftObjectPath EditedObjectPath;
    [FieldOffset(0x0018)] public FVector2D SavedViewOffset;
    [FieldOffset(0x0020)] public float SavedZoomAmount;
    [FieldOffset(0x0028)] public UObject* EditedObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBPInterfaceDescription
{
    [FieldOffset(0x0000)] public TSubclassOf<UInterface> Interface;
    [FieldOffset(0x0008)] public TArray<IntPtr> Graphs;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FBPVariableDescription
{
    [FieldOffset(0x0000)] public FName VarName;
    [FieldOffset(0x0008)] public FGuid VarGuid;
    [FieldOffset(0x0018)] public FEdGraphPinType VarType;
    [FieldOffset(0x0070)] public FString FriendlyName;
    [FieldOffset(0x0080)] public FText Category;
    [FieldOffset(0x0098)] public ulong PropertyFlags;
    [FieldOffset(0x00A0)] public FName RepNotifyFunc;
    [FieldOffset(0x00A8)] public ELifetimeCondition ReplicationCondition;
    [FieldOffset(0x00B0)] public TArray<FBPVariableMetaDataEntry> MetaDataArray;
    [FieldOffset(0x00C0)] public FString DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBlueprintMacroCosmeticInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FCompilerNativizationOptions
{
    [FieldOffset(0x0000)] public FName PlatformName;
    [FieldOffset(0x0008)] public bool ServerOnlyPlatform;
    [FieldOffset(0x0009)] public bool ClientOnlyPlatform;
    [FieldOffset(0x000A)] public bool bExcludeMonolithicHeaders;
    [FieldOffset(0x0010)] public TArray<FName> ExcludedModules;
    [FieldOffset(0x0020)] public TSet<FSoftObjectPath> ExcludedAssets;
    [FieldOffset(0x0070)] public TArray<FString> ExcludedFolderPaths;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEventGraphFastCallPair
{
    [FieldOffset(0x0000)] public UFunction* FunctionToPatch;
    [FieldOffset(0x0008)] public int EventGraphCallOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBlueprintDebugData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPointerToUberGraphFrame
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct FDebuggingInfoForSingleFunction
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FNodeToCodeAssociation
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FAnimCurveType
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBookmarkBaseJumpToSettings
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBookmarkJumpToSettings
{
    [FieldOffset(0x0000)] public FBookmarkBaseJumpToSettings baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FBookmark2DJumpToSettings
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FCachedAnimTransitionData
{
    [FieldOffset(0x0000)] public FName StateMachineName;
    [FieldOffset(0x0008)] public FName FromStateName;
    [FieldOffset(0x0010)] public FName ToStateName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCachedAnimRelevancyData
{
    [FieldOffset(0x0000)] public FName StateMachineName;
    [FieldOffset(0x0008)] public FName StateName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCachedAnimAssetPlayerData
{
    [FieldOffset(0x0000)] public FName StateMachineName;
    [FieldOffset(0x0008)] public FName StateName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCachedAnimStateData
{
    [FieldOffset(0x0000)] public FName StateMachineName;
    [FieldOffset(0x0008)] public FName StateName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCachedAnimStateArray
{
    [FieldOffset(0x0000)] public TArray<FCachedAnimStateData> States;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCameraShakeDuration
{
    [FieldOffset(0x0000)] public float Duration;
    [FieldOffset(0x0004)] public ECameraShakeDurationType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCameraShakeInfo
{
    [FieldOffset(0x0000)] public FCameraShakeDuration Duration;
    [FieldOffset(0x0008)] public float BlendIn;
    [FieldOffset(0x000C)] public float BlendOut;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FCameraShakeStopParams
{
    [FieldOffset(0x0000)] public bool bImmediately;
}

[StructLayout(LayoutKind.Explicit, Size = 0x590)] 
public unsafe struct FCameraShakeUpdateResult
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x600)] 
public unsafe struct FCameraShakeScrubParams
{
    [FieldOffset(0x0000)] public float AbsoluteTime;
    [FieldOffset(0x0004)] public float ShakeScale;
    [FieldOffset(0x0008)] public float DynamicScale;
    [FieldOffset(0x000C)] public float BlendingWeight;
    [FieldOffset(0x0010)] public FMinimalViewInfo POV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x600)] 
public unsafe struct FCameraShakeUpdateParams
{
    [FieldOffset(0x0000)] public float DeltaTime;
    [FieldOffset(0x0004)] public float ShakeScale;
    [FieldOffset(0x0008)] public float DynamicScale;
    [FieldOffset(0x000C)] public float BlendingWeight;
    [FieldOffset(0x0010)] public FMinimalViewInfo POV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FCameraShakeStartParams
{
    [FieldOffset(0x0000)] public bool bIsRestarting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FDummySpacerCameraTypes
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCanvasIcon
{
    [FieldOffset(0x0000)] public UTexture* Texture;
    [FieldOffset(0x0008)] public float U;
    [FieldOffset(0x000C)] public float V;
    [FieldOffset(0x0010)] public float UL;
    [FieldOffset(0x0014)] public float VL;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FWrappedStringElement
{
    [FieldOffset(0x0000)] public FString Value;
    [FieldOffset(0x0010)] public FVector2D LineExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTextSizingParameters
{
    [FieldOffset(0x0000)] public float DrawX;
    [FieldOffset(0x0004)] public float DrawY;
    [FieldOffset(0x0008)] public float DrawXL;
    [FieldOffset(0x000C)] public float DrawYL;
    [FieldOffset(0x0010)] public FVector2D Scaling;
    [FieldOffset(0x0018)] public UFont* DrawFont;
    [FieldOffset(0x0020)] public FVector2D SpacingAdjust;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FChildActorAttachedActorInfo
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<AActor> Actor;
    [FieldOffset(0x0008)] public FName SocketName;
    [FieldOffset(0x0010)] public FTransform RelativeTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FChildActorComponentInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00B8)] public TSubclassOf<AActor> ChildActorClass;
    [FieldOffset(0x00C0)] public FName ChildActorName;
    [FieldOffset(0x00C8)] public TArray<FChildActorAttachedActorInfo> AttachedActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAutoCompleteNode
{
    [FieldOffset(0x0000)] public int IndexChar;
    [FieldOffset(0x0008)] public TArray<int> AutoCompleteListIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x208)] 
public unsafe struct FRuntimeCurveLinearColor
{
    [FieldOffset(0x0000)] public FRichCurve ColorCurves;
    [FieldOffset(0x0200)] public UCurveLinearColor* ExternalCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FCurveAtlasColorAdjustments
{
    [FieldOffset(0x0000)] public byte bChromaKeyTexture;
    [FieldOffset(0x0004)] public float AdjustBrightness;
    [FieldOffset(0x0008)] public float AdjustBrightnessCurve;
    [FieldOffset(0x000C)] public float AdjustVibrance;
    [FieldOffset(0x0010)] public float AdjustSaturation;
    [FieldOffset(0x0014)] public float AdjustRGBCurve;
    [FieldOffset(0x0018)] public float AdjustHue;
    [FieldOffset(0x001C)] public float AdjustMinAlpha;
    [FieldOffset(0x0020)] public float AdjustMaxAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCurveTableRowHandle
{
    [FieldOffset(0x0000)] public UCurveTable* CurveTable;
    [FieldOffset(0x0008)] public FName RowName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCustomAttribute
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int VariantType;
    [FieldOffset(0x0010)] public TArray<float> Times;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCustomAttributePerBoneData
{
    [FieldOffset(0x0000)] public int BoneTreeIndex;
    [FieldOffset(0x0008)] public TArray<FCustomAttribute> Attributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDataTableCategoryHandle
{
    [FieldOffset(0x0000)] public UDataTable* DataTable;
    [FieldOffset(0x0008)] public FName ColumnName;
    [FieldOffset(0x0010)] public FName RowContents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDataTableRowHandle
{
    [FieldOffset(0x0000)] public UDataTable* DataTable;
    [FieldOffset(0x0008)] public FName RowName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGraphReference
{
    [FieldOffset(0x0000)] public UEdGraph* MacroGraph;
    [FieldOffset(0x0008)] public UBlueprint* GraphBlueprint;
    [FieldOffset(0x0010)] public FGuid GraphGuid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEdGraphPinReference
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UEdGraphNode> OwningNode;
    [FieldOffset(0x0008)] public FGuid PinId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct FEdGraphSchemaAction
{
    [FieldOffset(0x0008)] public FText MenuDescription;
    [FieldOffset(0x0020)] public FText TooltipDescription;
    [FieldOffset(0x0038)] public FText Category;
    [FieldOffset(0x0050)] public FText Keywords;
    [FieldOffset(0x0068)] public int Grouping;
    [FieldOffset(0x006C)] public int SectionID;
    [FieldOffset(0x0070)] public TArray<FString> MenuDescriptionArray;
    [FieldOffset(0x0080)] public TArray<FString> FullSearchTitlesArray;
    [FieldOffset(0x0090)] public TArray<FString> FullSearchKeywordsArray;
    [FieldOffset(0x00A0)] public TArray<FString> FullSearchCategoryArray;
    [FieldOffset(0x00B0)] public TArray<FString> LocalizedMenuDescriptionArray;
    [FieldOffset(0x00C0)] public TArray<FString> LocalizedFullSearchTitlesArray;
    [FieldOffset(0x00D0)] public TArray<FString> LocalizedFullSearchKeywordsArray;
    [FieldOffset(0x00E0)] public TArray<FString> LocalizedFullSearchCategoryArray;
    [FieldOffset(0x00F0)] public FString SearchText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FEdGraphSchemaAction_NewNode
{
    [FieldOffset(0x0000)] public FEdGraphSchemaAction baseObj;
    [FieldOffset(0x0100)] public UEdGraphNode* NodeTemplate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FScreenMessageString
{
    [FieldOffset(0x0000)] public ulong Key;
    [FieldOffset(0x0008)] public FString ScreenMessage;
    [FieldOffset(0x0018)] public FColor DisplayColor;
    [FieldOffset(0x001C)] public float TimeToDisplay;
    [FieldOffset(0x0020)] public float CurrentTimeDisplayed;
    [FieldOffset(0x0024)] public FVector2D TextScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FURL
{
    [FieldOffset(0x0000)] public FString Protocol;
    [FieldOffset(0x0010)] public FString Host;
    [FieldOffset(0x0020)] public int Port;
    [FieldOffset(0x0024)] public int valid;
    [FieldOffset(0x0028)] public FString Map;
    [FieldOffset(0x0038)] public FString RedirectURL;
    [FieldOffset(0x0048)] public TArray<FString> Op;
    [FieldOffset(0x0058)] public FString Portal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFullyLoadedPackagesInfo
{
    [FieldOffset(0x0000)] public EFullyLoadPackageType FullyLoadType;
    [FieldOffset(0x0008)] public FString Tag;
    [FieldOffset(0x0018)] public TArray<FName> PackagesToLoad;
    [FieldOffset(0x0028)] public TArray<IntPtr> LoadedObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLevelStreamingStatus
{
    [FieldOffset(0x0000)] public FName PackageName;
    [FieldOffset(0x0008)] public byte bShouldBeLoaded;
    [FieldOffset(0x0008)] public byte bShouldBeVisible;
    [FieldOffset(0x000C)] public uint LODIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNamedNetDriver
{
    [FieldOffset(0x0000)] public UNetDriver* NetDriver;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct FWorldContext
{
    [FieldOffset(0x00D0)] public FURL LastURL;
    [FieldOffset(0x0138)] public FURL LastRemoteURL;
    [FieldOffset(0x01A0)] public UPendingNetGame* PendingNetGame;
    [FieldOffset(0x01A8)] public TArray<FFullyLoadedPackagesInfo> PackagesToFullyLoad;
    [FieldOffset(0x01C8)] public TArray<IntPtr> LoadedLevelsForPendingMapChange;
    [FieldOffset(0x01F0)] public TArray<IntPtr> ObjectReferencers;
    [FieldOffset(0x0200)] public TArray<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates;
    [FieldOffset(0x0210)] public UGameViewportClient* GameViewport;
    [FieldOffset(0x0218)] public UGameInstance* OwningGameInstance;
    [FieldOffset(0x0220)] public TArray<FNamedNetDriver> ActiveNetDrivers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FExposureSettings
{
    [FieldOffset(0x0000)] public float FixedEV100;
    [FieldOffset(0x0004)] public bool bFixed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTickPrerequisite
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FDepthFieldGlowInfo
{
    [FieldOffset(0x0000)] public byte bEnableGlow;
    [FieldOffset(0x0004)] public FLinearColor GlowColor;
    [FieldOffset(0x0014)] public FVector2D GlowOuterRadius;
    [FieldOffset(0x001C)] public FVector2D GlowInnerRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFontRenderInfo
{
    [FieldOffset(0x0000)] public byte bClipText;
    [FieldOffset(0x0000)] public byte bEnableShadow;
    [FieldOffset(0x0004)] public FDepthFieldGlowInfo GlowInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDamageEvent
{
    [FieldOffset(0x0008)] public TSubclassOf<UDamageType> DamageTypeClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FRadialDamageParams
{
    [FieldOffset(0x0000)] public float BaseDamage;
    [FieldOffset(0x0004)] public float MinimumDamage;
    [FieldOffset(0x0008)] public float InnerRadius;
    [FieldOffset(0x000C)] public float OuterRadius;
    [FieldOffset(0x0010)] public float DamageFalloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRadialDamageEvent
{
    [FieldOffset(0x0000)] public FDamageEvent baseObj;
    [FieldOffset(0x0010)] public FRadialDamageParams Params;
    [FieldOffset(0x0024)] public FVector Origin;
    [FieldOffset(0x0030)] public TArray<FHitResult> ComponentHits;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FPointDamageEvent
{
    [FieldOffset(0x0000)] public FDamageEvent baseObj;
    [FieldOffset(0x0010)] public float Damage;
    [FieldOffset(0x0014)] public FVector_NetQuantizeNormal ShotDirection;
    [FieldOffset(0x0020)] public FHitResult HitInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FMeshBuildSettings
{
    [FieldOffset(0x0000)] public byte bUseMikkTSpace;
    [FieldOffset(0x0000)] public byte bRecomputeNormals;
    [FieldOffset(0x0000)] public byte bRecomputeTangents;
    [FieldOffset(0x0000)] public byte bComputeWeightedNormals;
    [FieldOffset(0x0000)] public byte bRemoveDegenerates;
    [FieldOffset(0x0000)] public byte bBuildAdjacencyBuffer;
    [FieldOffset(0x0000)] public byte bBuildReversedIndexBuffer;
    [FieldOffset(0x0000)] public byte bUseHighPrecisionTangentBasis;
    [FieldOffset(0x0001)] public byte bUseFullPrecisionUVs;
    [FieldOffset(0x0001)] public byte bGenerateLightmapUVs;
    [FieldOffset(0x0001)] public byte bGenerateDistanceFieldAsIfTwoSided;
    [FieldOffset(0x0001)] public byte bSupportFaceRemap;
    [FieldOffset(0x0004)] public int MinLightmapResolution;
    [FieldOffset(0x0008)] public int SrcLightmapIndex;
    [FieldOffset(0x000C)] public int DstLightmapIndex;
    [FieldOffset(0x0010)] public float BuildScale;
    [FieldOffset(0x0014)] public FVector BuildScale3D;
    [FieldOffset(0x0020)] public float DistanceFieldResolutionScale;
    [FieldOffset(0x0028)] public UStaticMesh* DistanceFieldReplacementMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FPOV
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FRotator Rotation;
    [FieldOffset(0x0018)] public float FOV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FAnimUpdateRateParameters
{
    [FieldOffset(0x0001)] public EUpdateRateShiftBucket ShiftBucket;
    [FieldOffset(0x0002)] public byte bInterpolateSkippedFrames;
    [FieldOffset(0x0002)] public byte bShouldUseLodMap;
    [FieldOffset(0x0002)] public byte bShouldUseMinLod;
    [FieldOffset(0x0002)] public byte bSkipUpdate;
    [FieldOffset(0x0002)] public byte bSkipEvaluation;
    [FieldOffset(0x0004)] public int UpdateRate;
    [FieldOffset(0x0008)] public int EvaluationRate;
    [FieldOffset(0x000C)] public float TickedPoseOffestTime;
    [FieldOffset(0x0010)] public float AdditionalTime;
    [FieldOffset(0x0018)] public int BaseNonRenderedUpdateRate;
    [FieldOffset(0x001C)] public int MaxEvalRateForInterpolation;
    [FieldOffset(0x0020)] public TArray<float> BaseVisibleDistanceFactorThesholds;
    [FieldOffset(0x0030)] public TMap<int, int> LODToFrameSkipMap;
    [FieldOffset(0x0080)] public int SkippedUpdateFrames;
    [FieldOffset(0x0084)] public int SkippedEvalFrames;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAnimSlotDesc
{
    [FieldOffset(0x0000)] public FName SlotName;
    [FieldOffset(0x0008)] public int NumChannels;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAnimSlotInfo
{
    [FieldOffset(0x0000)] public FName SlotName;
    [FieldOffset(0x0008)] public TArray<float> ChannelWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMTDResult
{
    [FieldOffset(0x0000)] public FVector Direction;
    [FieldOffset(0x000C)] public float Distance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FOverlapResult
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<AActor> Actor;
    [FieldOffset(0x0008)] public TWeakObjectPtr<UPrimitiveComponent> Component;
    [FieldOffset(0x0014)] public byte bBlockingHit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FSwarmDebugOptions
{
    [FieldOffset(0x0000)] public byte bDistributionEnabled;
    [FieldOffset(0x0000)] public byte bForceContentExport;
    [FieldOffset(0x0000)] public byte bInitialized;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FLightmassDebugOptions
{
    [FieldOffset(0x0000)] public byte bDebugMode;
    [FieldOffset(0x0000)] public byte bStatsEnabled;
    [FieldOffset(0x0000)] public byte bGatherBSPSurfacesAcrossComponents;
    [FieldOffset(0x0004)] public float CoplanarTolerance;
    [FieldOffset(0x0008)] public byte bUseImmediateImport;
    [FieldOffset(0x0008)] public byte bImmediateProcessMappings;
    [FieldOffset(0x0008)] public byte bSortMappings;
    [FieldOffset(0x0008)] public byte bDumpBinaryFiles;
    [FieldOffset(0x0008)] public byte bDebugMaterials;
    [FieldOffset(0x0008)] public byte bPadMappings;
    [FieldOffset(0x0008)] public byte bDebugPaddings;
    [FieldOffset(0x0008)] public byte bOnlyCalcDebugTexelMappings;
    [FieldOffset(0x0009)] public byte bUseRandomColors;
    [FieldOffset(0x0009)] public byte bColorBordersGreen;
    [FieldOffset(0x0009)] public byte bColorByExecutionTime;
    [FieldOffset(0x000C)] public float ExecutionTimeDivisor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBasedPosition
{
    [FieldOffset(0x0000)] public AActor* Base;
    [FieldOffset(0x0008)] public FVector Position;
    [FieldOffset(0x0014)] public FVector CachedBaseLocation;
    [FieldOffset(0x0020)] public FRotator CachedBaseRotation;
    [FieldOffset(0x002C)] public FVector CachedTransPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFractureEffect
{
    [FieldOffset(0x0000)] public UParticleSystem* ParticleSystem;
    [FieldOffset(0x0008)] public USoundBase* Sound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FRigidBodyContactInfo
{
    [FieldOffset(0x0000)] public FVector ContactPosition;
    [FieldOffset(0x000C)] public FVector ContactNormal;
    [FieldOffset(0x0018)] public float ContactPenetration;
    [FieldOffset(0x0020)] public UPhysicalMaterial* PhysMaterial;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCollisionImpactData
{
    [FieldOffset(0x0000)] public TArray<FRigidBodyContactInfo> ContactInfos;
    [FieldOffset(0x0010)] public FVector TotalNormalImpulse;
    [FieldOffset(0x001C)] public FVector TotalFrictionImpulse;
    [FieldOffset(0x0028)] public bool bIsVelocityDeltaUnderThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRigidBodyState
{
    [FieldOffset(0x0000)] public FVector_NetQuantize100 Position;
    [FieldOffset(0x0010)] public FQuat Quaternion;
    [FieldOffset(0x0020)] public FVector_NetQuantize100 LinVel;
    [FieldOffset(0x002C)] public FVector_NetQuantize100 AngVel;
    [FieldOffset(0x0038)] public byte flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FActiveHapticFeedbackEffect
{
    [FieldOffset(0x0000)] public UHapticFeedbackEffect_Base* HapticEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FClusterNode
{
    [FieldOffset(0x0000)] public FVector BoundMin;
    [FieldOffset(0x000C)] public int FirstChild;
    [FieldOffset(0x0010)] public FVector BoundMax;
    [FieldOffset(0x001C)] public int LastChild;
    [FieldOffset(0x0020)] public int FirstInstance;
    [FieldOffset(0x0024)] public int LastInstance;
    [FieldOffset(0x0028)] public FVector MinInstanceScale;
    [FieldOffset(0x0034)] public FVector MaxInstanceScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FClusterNode_DEPRECATED
{
    [FieldOffset(0x0000)] public FVector BoundMin;
    [FieldOffset(0x000C)] public int FirstChild;
    [FieldOffset(0x0010)] public FVector BoundMax;
    [FieldOffset(0x001C)] public int LastChild;
    [FieldOffset(0x0020)] public int FirstInstance;
    [FieldOffset(0x0024)] public int LastInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FHLODISMComponentDesc
{
    [FieldOffset(0x0000)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0008)] public UMaterialInterface* Material;
    [FieldOffset(0x0010)] public TArray<FTransform> Instances;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FInstancedStaticMeshLightMapInstanceData
{
    [FieldOffset(0x0000)] public FTransform Transform;
    [FieldOffset(0x0030)] public TArray<FGuid> MapBuildDataIds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct FInstancedStaticMeshComponentInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00B8)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x00C0)] public FInstancedStaticMeshLightMapInstanceData CachedStaticLighting;
    [FieldOffset(0x0100)] public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
    [FieldOffset(0x0110)] public TArray<float> PerInstanceSMCustomData;
    [FieldOffset(0x0140)] public int InstancingRandomSeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInterpEdSelKey
{
    [FieldOffset(0x0000)] public UInterpGroup* Group;
    [FieldOffset(0x0008)] public UInterpTrack* Track;
    [FieldOffset(0x0010)] public int KeyIndex;
    [FieldOffset(0x0014)] public float UnsnappedPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCameraPreviewInfo
{
    [FieldOffset(0x0000)] public TSubclassOf<APawn> PawnClass;
    [FieldOffset(0x0008)] public UAnimSequence* AnimSeq;
    [FieldOffset(0x0010)] public FVector Location;
    [FieldOffset(0x001C)] public FRotator Rotation;
    [FieldOffset(0x0028)] public APawn* PawnInst;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSubTrackGroup
{
    [FieldOffset(0x0000)] public FString GroupName;
    [FieldOffset(0x0010)] public TArray<int> TrackIndices;
    [FieldOffset(0x0020)] public byte bIsCollapsed;
    [FieldOffset(0x0020)] public byte bIsSelected;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSupportedSubTrackInfo
{
    [FieldOffset(0x0000)] public TSubclassOf<UInterpTrack> SupportedClass;
    [FieldOffset(0x0008)] public FString SubTrackName;
    [FieldOffset(0x0018)] public int GroupIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FLatentActionManager
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x12C)] 
public unsafe struct FLevelSimplificationDetails
{
    [FieldOffset(0x0000)] public bool bCreatePackagePerAsset;
    [FieldOffset(0x0004)] public float DetailsPercentage;
    [FieldOffset(0x0008)] public FMaterialProxySettings StaticMeshMaterialSettings;
    [FieldOffset(0x0090)] public bool bOverrideLandscapeExportLOD;
    [FieldOffset(0x0094)] public int LandscapeExportLOD;
    [FieldOffset(0x0098)] public FMaterialProxySettings LandscapeMaterialSettings;
    [FieldOffset(0x0120)] public bool bBakeFoliageToLandscape;
    [FieldOffset(0x0121)] public bool bBakeGrassToLandscape;
    [FieldOffset(0x0122)] public bool bGenerateMeshNormalMap;
    [FieldOffset(0x0123)] public bool bGenerateMeshMetallicMap;
    [FieldOffset(0x0124)] public bool bGenerateMeshRoughnessMap;
    [FieldOffset(0x0125)] public bool bGenerateMeshSpecularMap;
    [FieldOffset(0x0126)] public bool bGenerateLandscapeNormalMap;
    [FieldOffset(0x0127)] public bool bGenerateLandscapeMetallicMap;
    [FieldOffset(0x0128)] public bool bGenerateLandscapeRoughnessMap;
    [FieldOffset(0x0129)] public bool bGenerateLandscapeSpecularMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStreamableTextureInstance
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDynamicTextureInstance
{
    [FieldOffset(0x0000)] public FStreamableTextureInstance baseObj;
    [FieldOffset(0x0028)] public UTexture2D* Texture;
    [FieldOffset(0x0030)] public bool bAttached;
    [FieldOffset(0x0034)] public float OriginalRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct FPrecomputedLightInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00C0)] public FTransform Transform;
    [FieldOffset(0x00F0)] public FGuid LightGuid;
    [FieldOffset(0x0100)] public int PreviewShadowMapChannel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBatchedPoint
{
    [FieldOffset(0x0000)] public FVector Position;
    [FieldOffset(0x000C)] public FLinearColor Color;
    [FieldOffset(0x001C)] public float PointSize;
    [FieldOffset(0x0020)] public float RemainingLifeTime;
    [FieldOffset(0x0024)] public byte DepthPriority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FBatchedLine
{
    [FieldOffset(0x0000)] public FVector Start;
    [FieldOffset(0x000C)] public FVector End;
    [FieldOffset(0x0018)] public FLinearColor Color;
    [FieldOffset(0x0028)] public float Thickness;
    [FieldOffset(0x002C)] public float RemainingLifeTime;
    [FieldOffset(0x0030)] public byte DepthPriority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FClientReceiveData
{
    [FieldOffset(0x0000)] public APlayerController* LocalPC;
    [FieldOffset(0x0008)] public FName MessageType;
    [FieldOffset(0x0010)] public int MessageIndex;
    [FieldOffset(0x0018)] public FString MessageString;
    [FieldOffset(0x0028)] public APlayerState* RelatedPlayerState_1;
    [FieldOffset(0x0030)] public APlayerState* RelatedPlayerState_2;
    [FieldOffset(0x0038)] public UObject* OptionalObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FParameterGroupData
{
    [FieldOffset(0x0000)] public FString GroupName;
    [FieldOffset(0x0010)] public int GroupSortPriority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FStaticComponentMaskValue
{
    [FieldOffset(0x0000)] public bool R;
    [FieldOffset(0x0001)] public bool G;
    [FieldOffset(0x0002)] public bool B;
    [FieldOffset(0x0003)] public bool A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FParameterChannelNames
{
    [FieldOffset(0x0000)] public FText R;
    [FieldOffset(0x0018)] public FText G;
    [FieldOffset(0x0030)] public FText B;
    [FieldOffset(0x0048)] public FText A;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFunctionExpressionOutput
{
    [FieldOffset(0x0000)] public UMaterialExpressionFunctionOutput* ExpressionOutput;
    [FieldOffset(0x0008)] public FGuid ExpressionOutputId;
    [FieldOffset(0x0018)] public FExpressionOutput Output;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFunctionExpressionInput
{
    [FieldOffset(0x0000)] public UMaterialExpressionFunctionInput* ExpressionInput;
    [FieldOffset(0x0008)] public FGuid ExpressionInputId;
    [FieldOffset(0x0018)] public FExpressionInput Input;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FScalarParameterAtlasInstanceData
{
    [FieldOffset(0x0000)] public bool bIsUsedAsAtlasPosition;
    [FieldOffset(0x0008)] public TSoftObjectPtr<UCurveLinearColor> Curve;
    [FieldOffset(0x0030)] public TSoftObjectPtr<UCurveLinearColorAtlas> Atlas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FMemberReference
{
    [FieldOffset(0x0000)] public UObject* MemberParent;
    [FieldOffset(0x0008)] public FString MemberScope;
    [FieldOffset(0x0018)] public FName MemberName;
    [FieldOffset(0x0020)] public FGuid MemberGuid;
    [FieldOffset(0x0030)] public bool bSelfContext;
    [FieldOffset(0x0031)] public bool bWasDeprecated;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMeshInstancingSettings
{
    [FieldOffset(0x0000)] public TSubclassOf<AActor> ActorClassToUse;
    [FieldOffset(0x0008)] public int InstanceReplacementThreshold;
    [FieldOffset(0x000C)] public EMeshInstancingReplacementMethod MeshReplacementMethod;
    [FieldOffset(0x000D)] public bool bSkipMeshesWithVertexColors;
    [FieldOffset(0x000E)] public bool bUseHLODVolumes;
    [FieldOffset(0x0010)] public TSubclassOf<UInstancedStaticMeshComponent> ISMComponentToUse;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FMeshReductionSettings
{
    [FieldOffset(0x0000)] public float PercentTriangles;
    [FieldOffset(0x0004)] public float PercentVertices;
    [FieldOffset(0x0008)] public float MaxDeviation;
    [FieldOffset(0x000C)] public float PixelError;
    [FieldOffset(0x0010)] public float WeldingThreshold;
    [FieldOffset(0x0014)] public float HardAngleThreshold;
    [FieldOffset(0x0018)] public int BaseLODModel;
    [FieldOffset(0x001C)] public EMeshFeatureImportance SilhouetteImportance;
    [FieldOffset(0x001D)] public EMeshFeatureImportance TextureImportance;
    [FieldOffset(0x001E)] public EMeshFeatureImportance ShadingImportance;
    [FieldOffset(0x001F)] public byte bRecalculateNormals;
    [FieldOffset(0x001F)] public byte bGenerateUniqueLightmapUVs;
    [FieldOffset(0x001F)] public byte bKeepSymmetry;
    [FieldOffset(0x001F)] public byte bVisibilityAided;
    [FieldOffset(0x001F)] public byte bCullOccluded;
    [FieldOffset(0x0020)] public EStaticMeshReductionTerimationCriterion TerminationCriterion;
    [FieldOffset(0x0021)] public EMeshFeatureImportance VisibilityAggressiveness;
    [FieldOffset(0x0022)] public EMeshFeatureImportance VertexColorImportance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FPacketSimulationSettings
{
    [FieldOffset(0x0000)] public int PktLoss;
    [FieldOffset(0x0004)] public int PktLossMaxSize;
    [FieldOffset(0x0008)] public int PktLossMinSize;
    [FieldOffset(0x000C)] public int PktOrder;
    [FieldOffset(0x0010)] public int PktDup;
    [FieldOffset(0x0014)] public int PktLag;
    [FieldOffset(0x0018)] public int PktLagVariance;
    [FieldOffset(0x001C)] public int PktLagMin;
    [FieldOffset(0x0020)] public int PktLagMax;
    [FieldOffset(0x0024)] public int PktIncomingLagMin;
    [FieldOffset(0x0028)] public int PktIncomingLagMax;
    [FieldOffset(0x002C)] public int PktIncomingLoss;
    [FieldOffset(0x0030)] public int PktJitter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FFastArraySerializer
{
    [FieldOffset(0x0054)] public int ArrayReplicationKey;
    [FieldOffset(0x0100)] public EFastArraySerializerDeltaFlags DeltaFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFastArraySerializerItem
{
    [FieldOffset(0x0000)] public int ReplicationID;
    [FieldOffset(0x0004)] public int ReplicationKey;
    [FieldOffset(0x0008)] public int MostRecentArrayReplicationKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FParticleCurvePair
{
    [FieldOffset(0x0000)] public FString CurveName;
    [FieldOffset(0x0010)] public UObject* CurveObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBeamTargetData
{
    [FieldOffset(0x0000)] public FName TargetName;
    [FieldOffset(0x0008)] public float TargetPercentage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FParticleSystemWorldManagerTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FParticleSystemReplayFrame
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FParticleEmitterReplayFrame
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FFreezablePerPlatformInt
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPlayerMuteList
{
    [FieldOffset(0x0030)] public bool bHasVoiceHandshakeCompleted;
    [FieldOffset(0x0034)] public int VoiceChannelIdx;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPreviewAttachedObjectPair
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<UObject> AttachedObject;
    [FieldOffset(0x0028)] public UObject* Object;
    [FieldOffset(0x0030)] public FName AttachedTo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPreviewAssetAttachContainer
{
    [FieldOffset(0x0000)] public TArray<FPreviewAttachedObjectPair> AttachedObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct FPrimitiveComponentInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00C0)] public FTransform ComponentTransform;
    [FieldOffset(0x00F0)] public int VisibilityId;
    [FieldOffset(0x00F8)] public UPrimitiveComponent* LODParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSpriteCategoryInfo
{
    [FieldOffset(0x0000)] public FName Category;
    [FieldOffset(0x0008)] public FText DisplayName;
    [FieldOffset(0x0020)] public FText Description;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FLevelNameAndTime
{
    [FieldOffset(0x0000)] public FString LevelName;
    [FieldOffset(0x0010)] public uint LevelChangeTimeInMS;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCompressedRichCurve
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FRootMotionSourceStatus
{
    [FieldOffset(0x0000)] public byte flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FRootMotionFinishVelocitySettings
{
    [FieldOffset(0x0000)] public ERootMotionFinishVelocityMode Mode;
    [FieldOffset(0x0004)] public FVector SetVelocity;
    [FieldOffset(0x0010)] public float ClampVelocity;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FRootMotionSource
{
    [FieldOffset(0x0010)] public ushort Priority;
    [FieldOffset(0x0012)] public ushort LocalID;
    [FieldOffset(0x0014)] public ERootMotionAccumulateMode AccumulateMode;
    [FieldOffset(0x0018)] public FName InstanceName;
    [FieldOffset(0x0020)] public float StartTime;
    [FieldOffset(0x0024)] public float CurrentTime;
    [FieldOffset(0x0028)] public float PreviousTime;
    [FieldOffset(0x002C)] public float Duration;
    [FieldOffset(0x0030)] public FRootMotionSourceStatus Status;
    [FieldOffset(0x0031)] public FRootMotionSourceSettings Settings;
    [FieldOffset(0x0032)] public bool bInLocalSpace;
    [FieldOffset(0x0040)] public FRootMotionMovementParams RootMotionParams;
    [FieldOffset(0x0080)] public FRootMotionFinishVelocitySettings FinishVelocityParams;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FRootMotionSource_JumpForce
{
    [FieldOffset(0x0000)] public FRootMotionSource baseObj;
    [FieldOffset(0x0098)] public FRotator Rotation;
    [FieldOffset(0x00A4)] public float Distance;
    [FieldOffset(0x00A8)] public float Height;
    [FieldOffset(0x00AC)] public bool bDisableTimeout;
    [FieldOffset(0x00B0)] public UCurveVector* PathOffsetCurve;
    [FieldOffset(0x00B8)] public UCurveFloat* TimeMappingCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FRootMotionSource_MoveToDynamicForce
{
    [FieldOffset(0x0000)] public FRootMotionSource baseObj;
    [FieldOffset(0x0098)] public FVector StartLocation;
    [FieldOffset(0x00A4)] public FVector InitialTargetLocation;
    [FieldOffset(0x00B0)] public FVector TargetLocation;
    [FieldOffset(0x00BC)] public bool bRestrictSpeedToExpected;
    [FieldOffset(0x00C0)] public UCurveVector* PathOffsetCurve;
    [FieldOffset(0x00C8)] public UCurveFloat* TimeMappingCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FRootMotionSource_MoveToForce
{
    [FieldOffset(0x0000)] public FRootMotionSource baseObj;
    [FieldOffset(0x0098)] public FVector StartLocation;
    [FieldOffset(0x00A4)] public FVector TargetLocation;
    [FieldOffset(0x00B0)] public bool bRestrictSpeedToExpected;
    [FieldOffset(0x00B8)] public UCurveVector* PathOffsetCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FRootMotionSource_RadialForce
{
    [FieldOffset(0x0000)] public FRootMotionSource baseObj;
    [FieldOffset(0x0098)] public FVector Location;
    [FieldOffset(0x00A8)] public AActor* LocationActor;
    [FieldOffset(0x00B0)] public float Radius;
    [FieldOffset(0x00B4)] public float Strength;
    [FieldOffset(0x00B8)] public bool bIsPush;
    [FieldOffset(0x00B9)] public bool bNoZForce;
    [FieldOffset(0x00C0)] public UCurveFloat* StrengthDistanceFalloff;
    [FieldOffset(0x00C8)] public UCurveFloat* StrengthOverTime;
    [FieldOffset(0x00D0)] public bool bUseFixedWorldDirection;
    [FieldOffset(0x00D4)] public FRotator FixedWorldDirection;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FRootMotionSource_ConstantForce
{
    [FieldOffset(0x0000)] public FRootMotionSource baseObj;
    [FieldOffset(0x0098)] public FVector Force;
    [FieldOffset(0x00A8)] public UCurveFloat* StrengthOverTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCameraExposureSettings
{
    [FieldOffset(0x0000)] public EAutoExposureMethod Method;
    [FieldOffset(0x0004)] public float LowPercent;
    [FieldOffset(0x0008)] public float HighPercent;
    [FieldOffset(0x000C)] public float MinBrightness;
    [FieldOffset(0x0010)] public float MaxBrightness;
    [FieldOffset(0x0014)] public float SpeedUp;
    [FieldOffset(0x0018)] public float SpeedDown;
    [FieldOffset(0x001C)] public float Bias;
    [FieldOffset(0x0020)] public UCurveFloat* BiasCurve;
    [FieldOffset(0x0028)] public UTexture* MeterMask;
    [FieldOffset(0x0030)] public float HistogramLogMin;
    [FieldOffset(0x0034)] public float HistogramLogMax;
    [FieldOffset(0x0038)] public float CalibrationConstant;
    [FieldOffset(0x003C)] public byte ApplyPhysicalCameraExposure;
}

[StructLayout(LayoutKind.Explicit, Size = 0x84)] 
public unsafe struct FGaussianSumBloomSettings
{
    [FieldOffset(0x0000)] public float Intensity;
    [FieldOffset(0x0004)] public float Threshold;
    [FieldOffset(0x0008)] public float SizeScale;
    [FieldOffset(0x000C)] public float Filter1Size;
    [FieldOffset(0x0010)] public float Filter2Size;
    [FieldOffset(0x0014)] public float Filter3Size;
    [FieldOffset(0x0018)] public float Filter4Size;
    [FieldOffset(0x001C)] public float Filter5Size;
    [FieldOffset(0x0020)] public float Filter6Size;
    [FieldOffset(0x0024)] public FLinearColor Filter1Tint;
    [FieldOffset(0x0034)] public FLinearColor Filter2Tint;
    [FieldOffset(0x0044)] public FLinearColor Filter3Tint;
    [FieldOffset(0x0054)] public FLinearColor Filter4Tint;
    [FieldOffset(0x0064)] public FLinearColor Filter5Tint;
    [FieldOffset(0x0074)] public FLinearColor Filter6Tint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FConvolutionBloomSettings
{
    [FieldOffset(0x0000)] public UTexture2D* Texture;
    [FieldOffset(0x0008)] public float Size;
    [FieldOffset(0x000C)] public FVector2D CenterUV;
    [FieldOffset(0x0014)] public float PreFilterMin;
    [FieldOffset(0x0018)] public float PreFilterMax;
    [FieldOffset(0x001C)] public float PreFilterMult;
    [FieldOffset(0x0020)] public float BufferScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FLensBloomSettings
{
    [FieldOffset(0x0000)] public FGaussianSumBloomSettings GaussianSum;
    [FieldOffset(0x0088)] public FConvolutionBloomSettings Convolution;
    [FieldOffset(0x00B0)] public EBloomMethod Method;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLensImperfectionSettings
{
    [FieldOffset(0x0000)] public UTexture* DirtMask;
    [FieldOffset(0x0008)] public float DirtMaskIntensity;
    [FieldOffset(0x000C)] public FLinearColor DirtMaskTint;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct FLensSettings
{
    [FieldOffset(0x0000)] public FLensBloomSettings Bloom;
    [FieldOffset(0x00B8)] public FLensImperfectionSettings Imperfections;
    [FieldOffset(0x00D8)] public float ChromaticAberration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FFilmStockSettings
{
    [FieldOffset(0x0000)] public float Slope;
    [FieldOffset(0x0004)] public float Toe;
    [FieldOffset(0x0008)] public float Shoulder;
    [FieldOffset(0x000C)] public float BlackClip;
    [FieldOffset(0x0010)] public float WhiteClip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FColorGradePerRangeSettings
{
    [FieldOffset(0x0000)] public FVector4 Saturation;
    [FieldOffset(0x0010)] public FVector4 Contrast;
    [FieldOffset(0x0020)] public FVector4 Gamma;
    [FieldOffset(0x0030)] public FVector4 Gain;
    [FieldOffset(0x0040)] public FVector4 Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct FColorGradingSettings
{
    [FieldOffset(0x0000)] public FColorGradePerRangeSettings Global;
    [FieldOffset(0x0050)] public FColorGradePerRangeSettings Shadows;
    [FieldOffset(0x00A0)] public FColorGradePerRangeSettings Midtones;
    [FieldOffset(0x00F0)] public FColorGradePerRangeSettings Highlights;
    [FieldOffset(0x0140)] public float ShadowsMax;
    [FieldOffset(0x0144)] public float HighlightsMin;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FSceneViewExtensionIsActiveFunctor
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FClothPhysicsProperties_Legacy
{
    [FieldOffset(0x0000)] public float VerticalResistance;
    [FieldOffset(0x0004)] public float HorizontalResistance;
    [FieldOffset(0x0008)] public float BendResistance;
    [FieldOffset(0x000C)] public float ShearResistance;
    [FieldOffset(0x0010)] public float Friction;
    [FieldOffset(0x0014)] public float Damping;
    [FieldOffset(0x0018)] public float TetherStiffness;
    [FieldOffset(0x001C)] public float TetherLimit;
    [FieldOffset(0x0020)] public float Drag;
    [FieldOffset(0x0024)] public float StiffnessFrequency;
    [FieldOffset(0x0028)] public float GravityScale;
    [FieldOffset(0x002C)] public float MassScale;
    [FieldOffset(0x0030)] public float InertiaBlend;
    [FieldOffset(0x0034)] public float SelfCollisionThickness;
    [FieldOffset(0x0038)] public float SelfCollisionSquashScale;
    [FieldOffset(0x003C)] public float SelfCollisionStiffness;
    [FieldOffset(0x0040)] public float SolverFrequency;
    [FieldOffset(0x0044)] public float FiberCompression;
    [FieldOffset(0x0048)] public float FiberExpansion;
    [FieldOffset(0x004C)] public float FiberResistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FClothingAssetData_Legacy
{
    [FieldOffset(0x0000)] public FName AssetName;
    [FieldOffset(0x0008)] public FString ApexFileName;
    [FieldOffset(0x0018)] public bool bClothPropertiesChanged;
    [FieldOffset(0x001C)] public FClothPhysicsProperties_Legacy PhysicsProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FSkeletalMeshClothBuildParams
{
    [FieldOffset(0x0000)] public TWeakObjectPtr<UClothingAssetBase> TargetAsset;
    [FieldOffset(0x0008)] public int TargetLod;
    [FieldOffset(0x000C)] public bool bRemapParameters;
    [FieldOffset(0x0010)] public FString AssetName;
    [FieldOffset(0x0020)] public int LODIndex;
    [FieldOffset(0x0024)] public int SourceSection;
    [FieldOffset(0x0028)] public bool bRemoveFromMesh;
    [FieldOffset(0x0030)] public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FBoneMirrorExport
{
    [FieldOffset(0x0000)] public FName BoneName;
    [FieldOffset(0x0008)] public FName SourceBoneName;
    [FieldOffset(0x0010)] public EAxis BoneFlipAxis;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkeletalMeshComponentClothTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkeletalMeshComponentEndPhysicsTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNameMapping
{
    [FieldOffset(0x0000)] public FName NodeName;
    [FieldOffset(0x0008)] public FName BoneName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FRigConfiguration
{
    [FieldOffset(0x0000)] public URig* Rig;
    [FieldOffset(0x0008)] public TArray<FNameMapping> BoneMappingTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBoneReductionSetting
{
    [FieldOffset(0x0000)] public TArray<FName> BonesToRemove;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FReferencePose
{
    [FieldOffset(0x0000)] public FName PoseName;
    [FieldOffset(0x0008)] public TArray<FTransform> ReferencePose;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSkeletonToMeshLinkup
{
    [FieldOffset(0x0000)] public TArray<int> SkeletonToMeshTable;
    [FieldOffset(0x0010)] public TArray<int> MeshToSkeletonTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkinWeightProfileManagerTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct FPrecomputedSkyLightInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00B8)] public FGuid LightGuid;
    [FieldOffset(0x00C8)] public float AverageBrightness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FSmartNameMapping
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCurveMetaData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSoundClassEditorData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSoundNodeEditorData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FStreamedAudioPlatformData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct FSplineInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00B8)] public bool bSplineHasBeenEdited;
    [FieldOffset(0x00C0)] public FSplineCurves SplineCurves;
    [FieldOffset(0x0130)] public FSplineCurves SplineCurvesPreUCS;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FSplineMeshInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
    [FieldOffset(0x00B8)] public FVector StartPos;
    [FieldOffset(0x00C4)] public FVector EndPos;
    [FieldOffset(0x00D0)] public FVector StartTangent;
    [FieldOffset(0x00DC)] public FVector EndTangent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMaterialRemapIndex
{
    [FieldOffset(0x0000)] public uint ImportVersionKey;
    [FieldOffset(0x0008)] public TArray<int> MaterialRemap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAssetEditorOrbitCameraPosition
{
    [FieldOffset(0x0000)] public bool bIsSet;
    [FieldOffset(0x0004)] public FVector CamOrbitPoint;
    [FieldOffset(0x0010)] public FVector CamOrbitZoom;
    [FieldOffset(0x001C)] public FRotator CamOrbitRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMeshSectionInfo
{
    [FieldOffset(0x0000)] public int MaterialIndex;
    [FieldOffset(0x0004)] public bool bEnableCollision;
    [FieldOffset(0x0005)] public bool bCastShadow;
    [FieldOffset(0x0006)] public bool bVisibleInRayTracing;
    [FieldOffset(0x0007)] public bool bForceOpaque;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FMeshSectionInfoMap
{
    [FieldOffset(0x0000)] public TMap<uint, FMeshSectionInfo> Map;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FStaticMeshSourceModel
{
    [FieldOffset(0x0000)] public FMeshBuildSettings BuildSettings;
    [FieldOffset(0x0030)] public FMeshReductionSettings ReductionSettings;
    [FieldOffset(0x0054)] public float LODDistance;
    [FieldOffset(0x0058)] public FPerPlatformFloat ScreenSize;
    [FieldOffset(0x0060)] public FString SourceImportFilename;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FStaticMeshOptimizationSettings
{
    [FieldOffset(0x0000)] public EOptimizationType ReductionMethod;
    [FieldOffset(0x0004)] public float NumOfTrianglesPercentage;
    [FieldOffset(0x0008)] public float MaxDeviationPercentage;
    [FieldOffset(0x000C)] public float WeldingThreshold;
    [FieldOffset(0x0010)] public bool bRecalcNormals;
    [FieldOffset(0x0014)] public float NormalsThreshold;
    [FieldOffset(0x0018)] public byte SilhouetteImportance;
    [FieldOffset(0x0019)] public byte TextureImportance;
    [FieldOffset(0x001A)] public byte ShadingImportance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FPaintedVertex
{
    [FieldOffset(0x0000)] public FVector Position;
    [FieldOffset(0x000C)] public FColor Color;
    [FieldOffset(0x0010)] public FVector4 Normal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FStaticMeshVertexColorLODData
{
    [FieldOffset(0x0000)] public TArray<FPaintedVertex> PaintedVertices;
    [FieldOffset(0x0010)] public TArray<FColor> VertexBufferColors;
    [FieldOffset(0x0020)] public uint LODIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct FStaticMeshComponentInstanceData
{
    [FieldOffset(0x0000)] public FPrimitiveComponentInstanceData baseObj;
    [FieldOffset(0x0100)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0108)] public TArray<FStaticMeshVertexColorLODData> VertexColorLODs;
    [FieldOffset(0x0118)] public TArray<FGuid> CachedStaticLighting;
    [FieldOffset(0x0128)] public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FTextureFormatSettings
{
    [FieldOffset(0x0000)] public TextureCompressionSettings CompressionSettings;
    [FieldOffset(0x0001)] public byte CompressionNoAlpha;
    [FieldOffset(0x0001)] public byte CompressionNone;
    [FieldOffset(0x0001)] public byte CompressionYCoCg;
    [FieldOffset(0x0001)] public byte sRGB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FTexturePlatformData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FTextureSource
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTextureSourceBlock
{
    [FieldOffset(0x0000)] public int BlockX;
    [FieldOffset(0x0004)] public int BlockY;
    [FieldOffset(0x0008)] public int SizeX;
    [FieldOffset(0x000C)] public int SizeY;
    [FieldOffset(0x0010)] public int NumSlices;
    [FieldOffset(0x0014)] public int NumMips;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FStreamingRenderAssetPrimitiveInfo
{
    [FieldOffset(0x0000)] public UStreamableRenderAsset* RenderAsset;
    [FieldOffset(0x0008)] public FBoxSphereBounds Bounds;
    [FieldOffset(0x0024)] public float TexelFactor;
    [FieldOffset(0x0028)] public uint PackedRelativeBox;
    [FieldOffset(0x002C)] public byte bAllowInvalidTexelFactorWhenUnregistered;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FTTTrackId
{
    [FieldOffset(0x0000)] public int TrackType;
    [FieldOffset(0x0004)] public int TrackIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FTimeStretchCurveInstance
{
    [FieldOffset(0x0000)] public bool bHasValidData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEndPhysicsTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FStartPhysicsTickFunction
{
    [FieldOffset(0x0000)] public FTickFunction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FLevelViewportInfo
{
    [FieldOffset(0x0000)] public FVector CamPosition;
    [FieldOffset(0x000C)] public FRotator CamRotation;
    [FieldOffset(0x0018)] public float CamOrthoZoom;
    [FieldOffset(0x001C)] public bool CamUpdated;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FLightmassWorldInfoSettings
{
    [FieldOffset(0x0000)] public float StaticLightingLevelScale;
    [FieldOffset(0x0004)] public int NumIndirectLightingBounces;
    [FieldOffset(0x0008)] public int NumSkyLightingBounces;
    [FieldOffset(0x000C)] public float IndirectLightingQuality;
    [FieldOffset(0x0010)] public float IndirectLightingSmoothness;
    [FieldOffset(0x0014)] public FColor EnvironmentColor;
    [FieldOffset(0x0018)] public float EnvironmentIntensity;
    [FieldOffset(0x001C)] public float EmissiveBoost;
    [FieldOffset(0x0020)] public float DiffuseBoost;
    [FieldOffset(0x0024)] public EVolumeLightingMethod VolumeLightingMethod;
    [FieldOffset(0x0025)] public byte bUseAmbientOcclusion;
    [FieldOffset(0x0025)] public byte bGenerateAmbientOcclusionMaterialMask;
    [FieldOffset(0x0025)] public byte bVisualizeMaterialDiffuse;
    [FieldOffset(0x0025)] public byte bVisualizeAmbientOcclusion;
    [FieldOffset(0x0025)] public byte bCompressLightmaps;
    [FieldOffset(0x0028)] public float VolumetricLightmapDetailCellSize;
    [FieldOffset(0x002C)] public float VolumetricLightmapMaximumBrickMemoryMb;
    [FieldOffset(0x0030)] public float VolumetricLightmapSphericalHarmonicSmoothing;
    [FieldOffset(0x0034)] public float VolumeLightSamplePlacementScale;
    [FieldOffset(0x0038)] public float DirectIlluminationOcclusionFraction;
    [FieldOffset(0x003C)] public float IndirectIlluminationOcclusionFraction;
    [FieldOffset(0x0040)] public float OcclusionExponent;
    [FieldOffset(0x0044)] public float FullyOccludedSamplesFraction;
    [FieldOffset(0x0048)] public float MaxOcclusionDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__BlueprintGeneratedClass
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__AnimBlueprintGeneratedClass
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct FDefault__UserDefinedStruct
{
}

