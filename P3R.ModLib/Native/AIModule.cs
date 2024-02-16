using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct AAIController
{
    [FieldOffset(0x0000)] public AController baseObj;
    [FieldOffset(0x02D0)] public byte bStartAILogicOnPossess;
    [FieldOffset(0x02D0)] public byte bStopAILogicOnUnposses;
    [FieldOffset(0x02D0)] public byte bLOSflag;
    [FieldOffset(0x02D0)] public byte bSkipExtraLOSChecks;
    [FieldOffset(0x02D0)] public byte bAllowStrafe;
    [FieldOffset(0x02D0)] public byte bWantsPlayerState;
    [FieldOffset(0x02D0)] public byte bSetControlRotationFromPawnOrientation;
    [FieldOffset(0x02D8)] public UPathFollowingComponent* PathFollowingComponent;
    [FieldOffset(0x02E0)] public UBrainComponent* BrainComponent;
    [FieldOffset(0x02E8)] public UAIPerceptionComponent* PerceptionComponent;
    [FieldOffset(0x02F0)] public UPawnActionsComponent* ActionsComp;
    [FieldOffset(0x02F8)] public UBlackboardComponent* Blackboard;
    [FieldOffset(0x0300)] public UGameplayTasksComponent* CachedGameplayTasksComponent;
    [FieldOffset(0x0308)] public TSubclassOf<UNavigationQueryFilter> DefaultNavigationFilterClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FAIRequestID
{
    [FieldOffset(0x0000)] public uint RequestID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAIAsyncTaskBlueprintProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAIBlueprintHelperLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAIDataProvider
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAIDataProvider_QueryParams
{
    [FieldOffset(0x0000)] public UAIDataProvider baseObj;
    [FieldOffset(0x0028)] public FName ParamName;
    [FieldOffset(0x0030)] public float FloatValue;
    [FieldOffset(0x0034)] public int IntValue;
    [FieldOffset(0x0038)] public bool BoolValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAIDataProvider_Random
{
    [FieldOffset(0x0000)] public UAIDataProvider_QueryParams baseObj;
    [FieldOffset(0x0040)] public float Min;
    [FieldOffset(0x0044)] public float Max;
    [FieldOffset(0x0048)] public byte bInteger;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAIHotSpotManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FAIStimulus
{
    [FieldOffset(0x0000)] public float Age;
    [FieldOffset(0x0004)] public float ExpirationAge;
    [FieldOffset(0x0008)] public float Strength;
    [FieldOffset(0x000C)] public FVector StimulusLocation;
    [FieldOffset(0x0018)] public FVector ReceiverLocation;
    [FieldOffset(0x0024)] public FName Tag;
    [FieldOffset(0x0038)] public byte bSuccessfullySensed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FActorPerceptionBlueprintInfo
{
    [FieldOffset(0x0000)] public AActor* Target;
    [FieldOffset(0x0008)] public TArray<FAIStimulus> LastSensedStimuli;
    [FieldOffset(0x0018)] public byte bIsHostile;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UAIPerceptionComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public TArray<IntPtr> SensesConfig;
    [FieldOffset(0x00C0)] public TSubclassOf<UAISense> DominantSense;
    [FieldOffset(0x00D8)] public AAIController* AIOwner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAIPerceptionListenerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UAIPerceptionStimuliSourceComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public byte bAutoRegisterAsSource;
    [FieldOffset(0x00B8)] public TArray<TSubclassOf<UAISense>> RegisterAsSourceForSenses;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAISubsystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UAISystem* AISystem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UAIPerceptionSystem
{
    [FieldOffset(0x0000)] public UAISubsystem baseObj;
    [FieldOffset(0x0088)] public TArray<IntPtr> Senses;
    [FieldOffset(0x0098)] public float PerceptionAgingRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAIResourceInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAIResource_Movement
{
    [FieldOffset(0x0000)] public UGameplayTaskResource baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAIResource_Logic
{
    [FieldOffset(0x0000)] public UGameplayTaskResource baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAISense
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float DefaultExpirationAge;
    [FieldOffset(0x002C)] public EAISenseNotifyType NotifyType;
    [FieldOffset(0x0030)] public byte bWantsNewPawnNotification;
    [FieldOffset(0x0030)] public byte bAutoRegisterAllPawnsAsSources;
    [FieldOffset(0x0038)] public UAIPerceptionSystem* PerceptionSystemInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UAISense_Blueprint
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TSubclassOf<UUserDefinedStruct> ListenerDataType;
    [FieldOffset(0x0088)] public TArray<IntPtr> ListenerContainer;
    [FieldOffset(0x0098)] public TArray<IntPtr> UnprocessedEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAIDamageEvent
{
    [FieldOffset(0x0000)] public float Amount;
    [FieldOffset(0x0004)] public FVector Location;
    [FieldOffset(0x0010)] public FVector HitLocation;
    [FieldOffset(0x0020)] public AActor* DamagedActor;
    [FieldOffset(0x0028)] public AActor* Instigator;
    [FieldOffset(0x0030)] public FName Tag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAISense_Damage
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TArray<FAIDamageEvent> RegisteredEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAINoiseEvent
{
    [FieldOffset(0x0004)] public FVector NoiseLocation;
    [FieldOffset(0x0010)] public float Loudness;
    [FieldOffset(0x0014)] public float MaxRange;
    [FieldOffset(0x0018)] public AActor* Instigator;
    [FieldOffset(0x0020)] public FName Tag;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UAISense_Hearing
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TArray<FAINoiseEvent> NoiseEvents;
    [FieldOffset(0x0090)] public float SpeedOfSoundSq;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAIPredictionEvent
{
    [FieldOffset(0x0000)] public AActor* Requestor;
    [FieldOffset(0x0008)] public AActor* PredictedActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAISense_Prediction
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TArray<FAIPredictionEvent> RegisteredEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UAISense_Sight
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0148)] public int MaxTracesPerTick;
    [FieldOffset(0x014C)] public int MinQueriesPerTimeSliceCheck;
    [FieldOffset(0x0150)] public double MaxTimeSlicePerTick;
    [FieldOffset(0x0158)] public float HighImportanceQueryDistanceThreshold;
    [FieldOffset(0x0160)] public float MaxQueryImportance;
    [FieldOffset(0x0164)] public float SightLimitQueryImportance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAITeamStimulusEvent
{
    [FieldOffset(0x0028)] public AActor* Broadcaster;
    [FieldOffset(0x0030)] public AActor* Enemy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAISense_Team
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TArray<FAITeamStimulusEvent> RegisteredEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAITouchEvent
{
    [FieldOffset(0x0010)] public AActor* TouchReceiver;
    [FieldOffset(0x0018)] public AActor* OtherActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAISense_Touch
{
    [FieldOffset(0x0000)] public UAISense baseObj;
    [FieldOffset(0x0080)] public TArray<FAITouchEvent> RegisteredEvents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UAISenseBlueprintListener
{
    [FieldOffset(0x0000)] public UUserDefinedStruct baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAISenseConfig
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FColor DebugColor;
    [FieldOffset(0x002C)] public float MaxAge;
    [FieldOffset(0x0030)] public byte bStartsEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAISenseConfig_Blueprint
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<UAISense_Blueprint> Implementation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAISenseConfig_Damage
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<UAISense_Damage> Implementation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FAISenseAffiliationFilter
{
    [FieldOffset(0x0000)] public byte bDetectEnemies;
    [FieldOffset(0x0000)] public byte bDetectNeutrals;
    [FieldOffset(0x0000)] public byte bDetectFriendlies;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAISenseConfig_Hearing
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<UAISense_Hearing> Implementation;
    [FieldOffset(0x0050)] public float HearingRange;
    [FieldOffset(0x0054)] public float LoSHearingRange;
    [FieldOffset(0x0058)] public byte bUseLoSHearing;
    [FieldOffset(0x005C)] public FAISenseAffiliationFilter DetectionByAffiliation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAISenseConfig_Prediction
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAISenseConfig_Sight
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<UAISense_Sight> Implementation;
    [FieldOffset(0x0050)] public float SightRadius;
    [FieldOffset(0x0054)] public float LoseSightRadius;
    [FieldOffset(0x0058)] public float PeripheralVisionAngleDegrees;
    [FieldOffset(0x005C)] public FAISenseAffiliationFilter DetectionByAffiliation;
    [FieldOffset(0x0060)] public float AutoSuccessRangeFromLastSeenLocation;
    [FieldOffset(0x0064)] public float PointOfViewBackwardOffset;
    [FieldOffset(0x0068)] public float NearClippingRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAISenseConfig_Team
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAISenseConfig_Touch
{
    [FieldOffset(0x0000)] public UAISenseConfig baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAISenseEvent
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAISenseEvent_Damage
{
    [FieldOffset(0x0000)] public UAISenseEvent baseObj;
    [FieldOffset(0x0028)] public FAIDamageEvent Event;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAISenseEvent_Hearing
{
    [FieldOffset(0x0000)] public UAISenseEvent baseObj;
    [FieldOffset(0x0028)] public FAINoiseEvent Event;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAISightTargetInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UAISystem
{
    [FieldOffset(0x0000)] public UAISystemBase baseObj;
    [FieldOffset(0x0058)] public FSoftClassPath PerceptionSystemClassName;
    [FieldOffset(0x0070)] public FSoftClassPath HotSpotManagerClassName;
    [FieldOffset(0x0088)] public float AcceptanceRadius;
    [FieldOffset(0x008C)] public float PathfollowingRegularPathPointAcceptanceRadius;
    [FieldOffset(0x0090)] public float PathfollowingNavLinkAcceptanceRadius;
    [FieldOffset(0x0094)] public bool bFinishMoveOnGoalOverlap;
    [FieldOffset(0x0095)] public bool bAcceptPartialPaths;
    [FieldOffset(0x0096)] public bool bAllowStrafing;
    [FieldOffset(0x0097)] public bool bEnableBTAITasks;
    [FieldOffset(0x0098)] public bool bAllowControllersAsEQSQuerier;
    [FieldOffset(0x0099)] public bool bEnableDebuggerPlugin;
    [FieldOffset(0x009A)] public bool bForgetStaleActors;
    [FieldOffset(0x009B)] public bool bAddBlackboardSelfKey;
    [FieldOffset(0x009C)] public ECollisionChannel DefaultSightCollisionChannel;
    [FieldOffset(0x00A0)] public UBehaviorTreeManager* BehaviorTreeManager;
    [FieldOffset(0x00A8)] public UEnvQueryManager* EnvironmentQueryManager;
    [FieldOffset(0x00B0)] public UAIPerceptionSystem* PerceptionSystem;
    [FieldOffset(0x00B8)] public TArray<IntPtr> AllProxyObjects;
    [FieldOffset(0x00C8)] public UAIHotSpotManager* HotSpotManager;
    [FieldOffset(0x00D0)] public UNavLocalGridManager* NavLocalGrids;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAITask
{
    [FieldOffset(0x0000)] public UGameplayTask baseObj;
    [FieldOffset(0x0068)] public AAIController* OwnerController;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAITask_LockLogic
{
    [FieldOffset(0x0000)] public UAITask baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAIMoveRequest
{
    [FieldOffset(0x0000)] public AActor* GoalActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UAITask_MoveTo
{
    [FieldOffset(0x0000)] public UAITask baseObj;
    [FieldOffset(0x0090)] public FAIMoveRequest MoveRequest;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UAITask_RunEQS
{
    [FieldOffset(0x0000)] public UAITask baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FBTDecoratorLogic
{
    [FieldOffset(0x0000)] public EBTDecoratorLogic Operation;
    [FieldOffset(0x0002)] public ushort Number;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBehaviorTree
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UBTCompositeNode* RootNode;
    [FieldOffset(0x0038)] public UBlackboardData* BlackboardAsset;
    [FieldOffset(0x0040)] public TArray<IntPtr> RootDecorators;
    [FieldOffset(0x0050)] public TArray<FBTDecoratorLogic> RootDecoratorOps;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UBrainComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B8)] public UBlackboardComponent* BlackboardComp;
    [FieldOffset(0x00C0)] public AAIController* AIOwner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct UBehaviorTreeComponent
{
    [FieldOffset(0x0000)] public UBrainComponent baseObj;
    [FieldOffset(0x0128)] public TArray<IntPtr> NodeInstances;
    [FieldOffset(0x0278)] public UBehaviorTree* DefaultBehaviorTreeAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBehaviorTreeTemplateInfo
{
    [FieldOffset(0x0000)] public UBehaviorTree* Asset;
    [FieldOffset(0x0008)] public UBTCompositeNode* Template;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBehaviorTreeManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int MaxDebuggerSteps;
    [FieldOffset(0x0030)] public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates;
    [FieldOffset(0x0040)] public TArray<IntPtr> ActiveComponents;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBehaviorTreeTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBlackboardAssetProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UBlackboardComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UBrainComponent* BrainComp;
    [FieldOffset(0x00B8)] public UBlackboardData* DefaultBlackboardAsset;
    [FieldOffset(0x00C0)] public UBlackboardData* BlackboardAsset;
    [FieldOffset(0x00E8)] public TArray<IntPtr> KeyInstances;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBlackboardEntry
{
    [FieldOffset(0x0000)] public FName EntryName;
    [FieldOffset(0x0008)] public UBlackboardKeyType* KeyType;
    [FieldOffset(0x0010)] public byte bInstanceSynced;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBlackboardData
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public UBlackboardData* Parent;
    [FieldOffset(0x0038)] public TArray<FBlackboardEntry> Keys;
    [FieldOffset(0x0048)] public byte bHasSynchronizedKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Bool
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBlackboardKeyType_Class
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
    [FieldOffset(0x0030)] public UClass* BaseClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBlackboardKeyType_Enum
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
    [FieldOffset(0x0030)] public UEnum* EnumType;
    [FieldOffset(0x0038)] public FString EnumName;
    [FieldOffset(0x0048)] public byte bIsEnumNameValid;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Float
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Int
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Name
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBlackboardKeyType_NativeEnum
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
    [FieldOffset(0x0030)] public FString EnumName;
    [FieldOffset(0x0040)] public UEnum* EnumType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBlackboardKeyType_Object
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
    [FieldOffset(0x0030)] public UClass* BaseClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Rotator
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UBlackboardKeyType_String
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
    [FieldOffset(0x0030)] public FString StringValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBlackboardKeyType_Vector
{
    [FieldOffset(0x0000)] public UBlackboardKeyType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UBTNode
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FString NodeName;
    [FieldOffset(0x0040)] public UBehaviorTree* TreeAsset;
    [FieldOffset(0x0048)] public UBTCompositeNode* ParentNode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBTAuxiliaryNode
{
    [FieldOffset(0x0000)] public UBTNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBTCompositeChild
{
    [FieldOffset(0x0000)] public UBTCompositeNode* ChildComposite;
    [FieldOffset(0x0008)] public UBTTaskNode* ChildTask;
    [FieldOffset(0x0010)] public TArray<IntPtr> Decorators;
    [FieldOffset(0x0020)] public TArray<FBTDecoratorLogic> DecoratorOps;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UBTCompositeNode
{
    [FieldOffset(0x0000)] public UBTNode baseObj;
    [FieldOffset(0x0058)] public TArray<FBTCompositeChild> Children;
    [FieldOffset(0x0068)] public TArray<IntPtr> Services;
    [FieldOffset(0x0088)] public byte bApplyDecoratorScope;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UBTComposite_Selector
{
    [FieldOffset(0x0000)] public UBTCompositeNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UBTComposite_Sequence
{
    [FieldOffset(0x0000)] public UBTCompositeNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBTComposite_SimpleParallel
{
    [FieldOffset(0x0000)] public UBTCompositeNode baseObj;
    [FieldOffset(0x0090)] public EBTParallelMode FinishMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBTDecorator
{
    [FieldOffset(0x0000)] public UBTAuxiliaryNode baseObj;
    [FieldOffset(0x0060)] public byte bInverseCondition;
    [FieldOffset(0x0064)] public EBTFlowAbortMode FlowAbortMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBlackboardKeySelector
{
    [FieldOffset(0x0000)] public TArray<IntPtr> AllowedTypes;
    [FieldOffset(0x0010)] public FName SelectedKeyName;
    [FieldOffset(0x0018)] public TSubclassOf<UBlackboardKeyType> SelectedKeyType;
    [FieldOffset(0x0020)] public byte SelectedKeyID;
    [FieldOffset(0x0024)] public byte bNoneIsAllowedValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UBTDecorator_BlackboardBase
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public FBlackboardKeySelector BlackboardKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UBTDecorator_Blackboard
{
    [FieldOffset(0x0000)] public UBTDecorator_BlackboardBase baseObj;
    [FieldOffset(0x0090)] public int IntValue;
    [FieldOffset(0x0094)] public float FloatValue;
    [FieldOffset(0x0098)] public FString StringValue;
    [FieldOffset(0x00A8)] public FString CachedDescription;
    [FieldOffset(0x00B8)] public byte OperationType;
    [FieldOffset(0x00B9)] public EBTBlackboardRestart NotifyObserver;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBTDecorator_BlueprintBase
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public AAIController* AIOwner;
    [FieldOffset(0x0070)] public AActor* ActorOwner;
    [FieldOffset(0x0078)] public TArray<FName> ObservedKeyNames;
    [FieldOffset(0x0098)] public byte bShowPropertyDetails;
    [FieldOffset(0x0098)] public byte bCheckConditionOnlyBlackBoardChanges;
    [FieldOffset(0x0098)] public byte bIsObservingBB;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBTDecorator_CheckGameplayTagsOnActor
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public FBlackboardKeySelector ActorToCheck;
    [FieldOffset(0x0090)] public EGameplayContainerMatchType TagsToMatch;
    [FieldOffset(0x0098)] public FGameplayTagContainer GameplayTags;
    [FieldOffset(0x00B8)] public FString CachedDescription;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UBTDecorator_CompareBBEntries
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public EBlackBoardEntryComparison Operator;
    [FieldOffset(0x0070)] public FBlackboardKeySelector BlackboardKeyA;
    [FieldOffset(0x0098)] public FBlackboardKeySelector BlackboardKeyB;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UBTDecorator_ConditionalLoop
{
    [FieldOffset(0x0000)] public UBTDecorator_Blackboard baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UBTDecorator_ConeCheck
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public float ConeHalfAngle;
    [FieldOffset(0x0070)] public FBlackboardKeySelector ConeOrigin;
    [FieldOffset(0x0098)] public FBlackboardKeySelector ConeDirection;
    [FieldOffset(0x00C0)] public FBlackboardKeySelector Observed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBTDecorator_Cooldown
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public float CoolDownTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBTDecorator_DoesPathExist
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public FBlackboardKeySelector BlackboardKeyA;
    [FieldOffset(0x0090)] public FBlackboardKeySelector BlackboardKeyB;
    [FieldOffset(0x00B8)] public byte bUseSelf;
    [FieldOffset(0x00BC)] public EPathExistanceQueryType PathQueryType;
    [FieldOffset(0x00C0)] public TSubclassOf<UNavigationQueryFilter> FilterClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBTDecorator_ForceSuccess
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAIDataProviderValue
{
    [FieldOffset(0x0010)] public UAIDataProvider* DataBinding;
    [FieldOffset(0x0018)] public FName DataField;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAIDataProviderTypedValue
{
    [FieldOffset(0x0000)] public FAIDataProviderValue baseObj;
    [FieldOffset(0x0020)] public UClass* PropertyType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAIDataProviderFloatValue
{
    [FieldOffset(0x0000)] public FAIDataProviderTypedValue baseObj;
    [FieldOffset(0x0030)] public float DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UBTDecorator_IsAtLocation
{
    [FieldOffset(0x0000)] public UBTDecorator_BlackboardBase baseObj;
    [FieldOffset(0x0090)] public float AcceptableRadius;
    [FieldOffset(0x0098)] public FAIDataProviderFloatValue ParametrizedAcceptableRadius;
    [FieldOffset(0x00D0)] public FAIDistanceType GeometricDistanceType;
    [FieldOffset(0x00D4)] public byte bUseParametrizedRadius;
    [FieldOffset(0x00D4)] public byte bUseNavAgentGoalLocation;
    [FieldOffset(0x00D4)] public byte bPathFindingBasedTest;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBTDecorator_IsBBEntryOfClass
{
    [FieldOffset(0x0000)] public UBTDecorator_BlackboardBase baseObj;
    [FieldOffset(0x0090)] public UClass* TestClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBTDecorator_KeepInCone
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public float ConeHalfAngle;
    [FieldOffset(0x0070)] public FBlackboardKeySelector ConeOrigin;
    [FieldOffset(0x0098)] public FBlackboardKeySelector Observed;
    [FieldOffset(0x00C0)] public byte bUseSelfAsOrigin;
    [FieldOffset(0x00C0)] public byte bUseSelfAsObserved;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTDecorator_Loop
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public int NumLoops;
    [FieldOffset(0x006C)] public bool bInfiniteLoop;
    [FieldOffset(0x0070)] public float InfiniteLoopTimeoutTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBTDecorator_ReachedMoveGoal
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTDecorator_SetTagCooldown
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public FGameplayTag CooldownTag;
    [FieldOffset(0x0070)] public float CooldownDuration;
    [FieldOffset(0x0074)] public bool bAddToExistingDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTDecorator_TagCooldown
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public FGameplayTag CooldownTag;
    [FieldOffset(0x0070)] public float CooldownDuration;
    [FieldOffset(0x0074)] public bool bAddToExistingDuration;
    [FieldOffset(0x0075)] public bool bActivatesCooldown;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBTDecorator_TimeLimit
{
    [FieldOffset(0x0000)] public UBTDecorator baseObj;
    [FieldOffset(0x0068)] public float TimeLimit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBTFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBTService
{
    [FieldOffset(0x0000)] public UBTAuxiliaryNode baseObj;
    [FieldOffset(0x0060)] public float Interval;
    [FieldOffset(0x0064)] public float RandomDeviation;
    [FieldOffset(0x0068)] public byte bCallTickOnSearchStart;
    [FieldOffset(0x0068)] public byte bRestartTimerOnEachActivation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBTService_BlackboardBase
{
    [FieldOffset(0x0000)] public UBTService baseObj;
    [FieldOffset(0x0070)] public FBlackboardKeySelector BlackboardKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBTService_BlueprintBase
{
    [FieldOffset(0x0000)] public UBTService baseObj;
    [FieldOffset(0x0070)] public AAIController* AIOwner;
    [FieldOffset(0x0078)] public AActor* ActorOwner;
    [FieldOffset(0x0090)] public byte bShowPropertyDetails;
    [FieldOffset(0x0090)] public byte bShowEventDetails;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBTService_DefaultFocus
{
    [FieldOffset(0x0000)] public UBTService_BlackboardBase baseObj;
    [FieldOffset(0x0098)] public byte FocusPriority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAIDynamicParam
{
    [FieldOffset(0x0000)] public FName ParamName;
    [FieldOffset(0x0008)] public EAIParamType ParamType;
    [FieldOffset(0x000C)] public float Value;
    [FieldOffset(0x0010)] public FBlackboardKeySelector BBKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FEQSParametrizedQueryExecutionRequest
{
    [FieldOffset(0x0000)] public UEnvQuery* QueryTemplate;
    [FieldOffset(0x0008)] public TArray<FAIDynamicParam> QueryConfig;
    [FieldOffset(0x0018)] public FBlackboardKeySelector EQSQueryBlackboardKey;
    [FieldOffset(0x0040)] public EEnvQueryRunMode RunMode;
    [FieldOffset(0x0044)] public byte bUseBBKeyForQueryTemplate;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UBTService_RunEQS
{
    [FieldOffset(0x0000)] public UBTService_BlackboardBase baseObj;
    [FieldOffset(0x0098)] public FEQSParametrizedQueryExecutionRequest EQSRequest;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBTTaskNode
{
    [FieldOffset(0x0000)] public UBTNode baseObj;
    [FieldOffset(0x0058)] public TArray<IntPtr> Services;
    [FieldOffset(0x0068)] public byte bIgnoreRestartSelf;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBTTask_BlackboardBase
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public FBlackboardKeySelector BlackboardKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FIntervalCountdown
{
    [FieldOffset(0x0000)] public float Interval;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UBTTask_BlueprintBase
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public AAIController* AIOwner;
    [FieldOffset(0x0078)] public AActor* ActorOwner;
    [FieldOffset(0x0080)] public FIntervalCountdown TickInterval;
    [FieldOffset(0x00A0)] public byte bShowPropertyDetails;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_FinishWithResult
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public EBTNodeResult Result;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_GameplayTaskBase
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public byte bWaitForGameplayTask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_MakeNoise
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public float Loudnes;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UBTTask_MoveTo
{
    [FieldOffset(0x0000)] public UBTTask_BlackboardBase baseObj;
    [FieldOffset(0x0098)] public float AcceptableRadius;
    [FieldOffset(0x00A0)] public TSubclassOf<UNavigationQueryFilter> FilterClass;
    [FieldOffset(0x00A8)] public float ObservedBlackboardValueTolerance;
    [FieldOffset(0x00AC)] public byte bObserveBlackboardValue;
    [FieldOffset(0x00AC)] public byte bAllowStrafe;
    [FieldOffset(0x00AC)] public byte bAllowPartialPath;
    [FieldOffset(0x00AC)] public byte bTrackMovingGoal;
    [FieldOffset(0x00AC)] public byte bProjectGoalLocation;
    [FieldOffset(0x00AC)] public byte bReachTestIncludesAgentRadius;
    [FieldOffset(0x00AC)] public byte bReachTestIncludesGoalRadius;
    [FieldOffset(0x00AC)] public byte bStopOnOverlap;
    [FieldOffset(0x00AD)] public byte bStopOnOverlapNeedsUpdate;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UBTTask_MoveDirectlyToward
{
    [FieldOffset(0x0000)] public UBTTask_MoveTo baseObj;
    [FieldOffset(0x00B0)] public byte bDisablePathUpdateOnGoalLocationChange;
    [FieldOffset(0x00B0)] public byte bProjectVectorGoalToNavigation;
    [FieldOffset(0x00B0)] public byte bUpdatedDeprecatedProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBTTask_PawnActionBase
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UBTTask_PlayAnimation
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public UAnimationAsset* AnimationToPlay;
    [FieldOffset(0x0078)] public byte bLooping;
    [FieldOffset(0x0078)] public byte bNonBlocking;
    [FieldOffset(0x0080)] public UBehaviorTreeComponent* MyOwnerComp;
    [FieldOffset(0x0088)] public USkeletalMeshComponent* CachedSkelMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_PlaySound
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public USoundCue* SoundToPlay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_PushPawnAction
{
    [FieldOffset(0x0000)] public UBTTask_PawnActionBase baseObj;
    [FieldOffset(0x0070)] public UPawnAction* Action;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBTTask_RotateToFaceBBEntry
{
    [FieldOffset(0x0000)] public UBTTask_BlackboardBase baseObj;
    [FieldOffset(0x0098)] public float Precision;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_RunBehavior
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public UBehaviorTree* BehaviorAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UBTTask_RunBehaviorDynamic
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public FGameplayTag InjectionTag;
    [FieldOffset(0x0078)] public UBehaviorTree* DefaultBehaviorAsset;
    [FieldOffset(0x0080)] public UBehaviorTree* BehaviorAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEnvNamedValue
{
    [FieldOffset(0x0000)] public FName ParamName;
    [FieldOffset(0x0008)] public EAIParamType ParamType;
    [FieldOffset(0x000C)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UBTTask_RunEQSQuery
{
    [FieldOffset(0x0000)] public UBTTask_BlackboardBase baseObj;
    [FieldOffset(0x0098)] public UEnvQuery* QueryTemplate;
    [FieldOffset(0x00A0)] public TArray<FEnvNamedValue> QueryParams;
    [FieldOffset(0x00B0)] public TArray<FAIDynamicParam> QueryConfig;
    [FieldOffset(0x00C0)] public EEnvQueryRunMode RunMode;
    [FieldOffset(0x00C8)] public FBlackboardKeySelector EQSQueryBlackboardKey;
    [FieldOffset(0x00F0)] public bool bUseBBKey;
    [FieldOffset(0x00F8)] public FEQSParametrizedQueryExecutionRequest EQSRequest;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UBTTask_SetTagCooldown
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public FGameplayTag CooldownTag;
    [FieldOffset(0x0078)] public bool bAddToExistingDuration;
    [FieldOffset(0x007C)] public float CooldownDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBTTask_Wait
{
    [FieldOffset(0x0000)] public UBTTaskNode baseObj;
    [FieldOffset(0x0070)] public float WaitTime;
    [FieldOffset(0x0074)] public float RandomDeviation;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBTTask_WaitBlackboardTime
{
    [FieldOffset(0x0000)] public UBTTask_Wait baseObj;
    [FieldOffset(0x0078)] public FBlackboardKeySelector BlackboardKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ICrowdAgentInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UPathFollowingComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00E8)] public UNavMovementComponent* MovementComp;
    [FieldOffset(0x00F8)] public ANavigationData* MyNavData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct UCrowdFollowingComponent
{
    [FieldOffset(0x0000)] public UPathFollowingComponent baseObj;
    [FieldOffset(0x0268)] public FVector CrowdAgentMoveDirection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCrowdAvoidanceConfig
{
    [FieldOffset(0x0000)] public float VelocityBias;
    [FieldOffset(0x0004)] public float DesiredVelocityWeight;
    [FieldOffset(0x0008)] public float CurrentVelocityWeight;
    [FieldOffset(0x000C)] public float SideBiasWeight;
    [FieldOffset(0x0010)] public float ImpactTimeWeight;
    [FieldOffset(0x0014)] public float ImpactTimeRange;
    [FieldOffset(0x0018)] public byte CustomPatternIdx;
    [FieldOffset(0x0019)] public byte AdaptiveDivisions;
    [FieldOffset(0x001A)] public byte AdaptiveRings;
    [FieldOffset(0x001B)] public byte AdaptiveDepth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCrowdAvoidanceSamplingPattern
{
    [FieldOffset(0x0000)] public TArray<float> Angles;
    [FieldOffset(0x0010)] public TArray<float> Radii;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UCrowdManager
{
    [FieldOffset(0x0000)] public UCrowdManagerBase baseObj;
    [FieldOffset(0x0028)] public ANavigationData* MyNavData;
    [FieldOffset(0x0030)] public TArray<FCrowdAvoidanceConfig> AvoidanceConfig;
    [FieldOffset(0x0040)] public TArray<FCrowdAvoidanceSamplingPattern> SamplingPatterns;
    [FieldOffset(0x0050)] public int MaxAgents;
    [FieldOffset(0x0054)] public float MaxAgentRadius;
    [FieldOffset(0x0058)] public int MaxAvoidedAgents;
    [FieldOffset(0x005C)] public int MaxAvoidedWalls;
    [FieldOffset(0x0060)] public float NavmeshCheckInterval;
    [FieldOffset(0x0064)] public float PathOptimizationInterval;
    [FieldOffset(0x0068)] public float SeparationDirClamp;
    [FieldOffset(0x006C)] public float PathOffsetRadiusMultiplier;
    [FieldOffset(0x0070)] public byte bResolveCollisions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct ADetourCrowdAIController
{
    [FieldOffset(0x0000)] public AAIController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEnvQuery
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FName QueryName;
    [FieldOffset(0x0038)] public TArray<IntPtr> Options;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEnvQueryContext
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryContext_BlueprintBase
{
    [FieldOffset(0x0000)] public UEnvQueryContext baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEnvQueryContext_Item
{
    [FieldOffset(0x0000)] public UEnvQueryContext baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEnvQueryContext_Querier
{
    [FieldOffset(0x0000)] public UEnvQueryContext baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEnvQueryDebugHelpers
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryNode
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int VerNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UEnvQueryGenerator
{
    [FieldOffset(0x0000)] public UEnvQueryNode baseObj;
    [FieldOffset(0x0030)] public FString OptionName;
    [FieldOffset(0x0040)] public TSubclassOf<UEnvQueryItemType> ItemType;
    [FieldOffset(0x0048)] public byte bAutoSortTests;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAIDataProviderBoolValue
{
    [FieldOffset(0x0000)] public FAIDataProviderTypedValue baseObj;
    [FieldOffset(0x0030)] public bool DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UEnvQueryGenerator_ActorsOfClass
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator baseObj;
    [FieldOffset(0x0050)] public TSubclassOf<AActor> SearchedActorClass;
    [FieldOffset(0x0058)] public FAIDataProviderBoolValue GenerateOnlyActorsInRadius;
    [FieldOffset(0x0090)] public FAIDataProviderFloatValue SearchRadius;
    [FieldOffset(0x00C8)] public TSubclassOf<UEnvQueryContext> SearchCenter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UEnvQueryGenerator_BlueprintBase
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator baseObj;
    [FieldOffset(0x0050)] public FText GeneratorsActionDescription;
    [FieldOffset(0x0068)] public TSubclassOf<UEnvQueryContext> Context;
    [FieldOffset(0x0070)] public TSubclassOf<UEnvQueryItemType> GeneratedItemType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UEnvQueryGenerator_Composite
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator baseObj;
    [FieldOffset(0x0050)] public TArray<IntPtr> Generators;
    [FieldOffset(0x0060)] public byte bAllowDifferentItemTypes;
    [FieldOffset(0x0060)] public byte bHasMatchingItemType;
    [FieldOffset(0x0068)] public TSubclassOf<UEnvQueryItemType> ForcedItemType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEnvTraceData
{
    [FieldOffset(0x0000)] public int VersionNum;
    [FieldOffset(0x0008)] public TSubclassOf<UNavigationQueryFilter> NavigationFilter;
    [FieldOffset(0x0010)] public float ProjectDown;
    [FieldOffset(0x0014)] public float ProjectUp;
    [FieldOffset(0x0018)] public float ExtentX;
    [FieldOffset(0x001C)] public float ExtentY;
    [FieldOffset(0x0020)] public float ExtentZ;
    [FieldOffset(0x0024)] public float PostProjectionVerticalOffset;
    [FieldOffset(0x0028)] public ETraceTypeQuery TraceChannel;
    [FieldOffset(0x0029)] public ECollisionChannel SerializedChannel;
    [FieldOffset(0x002A)] public EEnvTraceShape TraceShape;
    [FieldOffset(0x002B)] public EEnvQueryTrace TraceMode;
    [FieldOffset(0x002C)] public byte bTraceComplex;
    [FieldOffset(0x002C)] public byte bOnlyBlockingHits;
    [FieldOffset(0x002C)] public byte bCanTraceOnNavMesh;
    [FieldOffset(0x002C)] public byte bCanTraceOnGeometry;
    [FieldOffset(0x002C)] public byte bCanDisableTrace;
    [FieldOffset(0x002C)] public byte bCanProjectDown;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UEnvQueryGenerator_ProjectedPoints
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator baseObj;
    [FieldOffset(0x0050)] public FEnvTraceData ProjectionData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UEnvQueryGenerator_Cone
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator_ProjectedPoints baseObj;
    [FieldOffset(0x0080)] public FAIDataProviderFloatValue AlignedPointsDistance;
    [FieldOffset(0x00B8)] public FAIDataProviderFloatValue ConeDegrees;
    [FieldOffset(0x00F0)] public FAIDataProviderFloatValue AngleStep;
    [FieldOffset(0x0128)] public FAIDataProviderFloatValue Range;
    [FieldOffset(0x0160)] public TSubclassOf<UEnvQueryContext> CenterActor;
    [FieldOffset(0x0168)] public byte bIncludeContextLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UEnvQueryGenerator_CurrentLocation
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator baseObj;
    [FieldOffset(0x0050)] public TSubclassOf<UEnvQueryContext> QueryContext;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAIDataProviderIntValue
{
    [FieldOffset(0x0000)] public FAIDataProviderTypedValue baseObj;
    [FieldOffset(0x0030)] public int DefaultValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEnvDirection
{
    [FieldOffset(0x0000)] public TSubclassOf<UEnvQueryContext> LineFrom;
    [FieldOffset(0x0008)] public TSubclassOf<UEnvQueryContext> LineTo;
    [FieldOffset(0x0010)] public TSubclassOf<UEnvQueryContext> Rotation;
    [FieldOffset(0x0018)] public EEnvDirection DirMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UEnvQueryGenerator_Donut
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator_ProjectedPoints baseObj;
    [FieldOffset(0x0080)] public FAIDataProviderFloatValue InnerRadius;
    [FieldOffset(0x00B8)] public FAIDataProviderFloatValue OuterRadius;
    [FieldOffset(0x00F0)] public FAIDataProviderIntValue NumberOfRings;
    [FieldOffset(0x0128)] public FAIDataProviderIntValue PointsPerRing;
    [FieldOffset(0x0160)] public FEnvDirection ArcDirection;
    [FieldOffset(0x0180)] public FAIDataProviderFloatValue ArcAngle;
    [FieldOffset(0x01B8)] public bool bUseSpiralPattern;
    [FieldOffset(0x01C0)] public TSubclassOf<UEnvQueryContext> Center;
    [FieldOffset(0x01C8)] public byte bDefineArc;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct UEnvQueryGenerator_OnCircle
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator_ProjectedPoints baseObj;
    [FieldOffset(0x0080)] public FAIDataProviderFloatValue CircleRadius;
    [FieldOffset(0x00B8)] public FAIDataProviderFloatValue SpaceBetween;
    [FieldOffset(0x00F0)] public FAIDataProviderIntValue NumberOfPoints;
    [FieldOffset(0x0128)] public EPointOnCircleSpacingMethod PointOnCircleSpacingMethod;
    [FieldOffset(0x0130)] public FEnvDirection ArcDirection;
    [FieldOffset(0x0150)] public FAIDataProviderFloatValue ArcAngle;
    [FieldOffset(0x0188)] public float AngleRadians;
    [FieldOffset(0x0190)] public TSubclassOf<UEnvQueryContext> CircleCenter;
    [FieldOffset(0x0198)] public bool bIgnoreAnyContextActorsWhenGeneratingCircle;
    [FieldOffset(0x01A0)] public FAIDataProviderFloatValue CircleCenterZOffset;
    [FieldOffset(0x01D8)] public FEnvTraceData TraceData;
    [FieldOffset(0x0208)] public byte bDefineArc;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UEnvQueryGenerator_SimpleGrid
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator_ProjectedPoints baseObj;
    [FieldOffset(0x0080)] public FAIDataProviderFloatValue GridSize;
    [FieldOffset(0x00B8)] public FAIDataProviderFloatValue SpaceBetween;
    [FieldOffset(0x00F0)] public TSubclassOf<UEnvQueryContext> GenerateAround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UEnvQueryGenerator_PathingGrid
{
    [FieldOffset(0x0000)] public UEnvQueryGenerator_SimpleGrid baseObj;
    [FieldOffset(0x00F8)] public FAIDataProviderBoolValue PathToItem;
    [FieldOffset(0x0130)] public TSubclassOf<UNavigationQueryFilter> NavigationFilter;
    [FieldOffset(0x0138)] public FAIDataProviderFloatValue ScanRangeMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UEnvQueryInstanceBlueprintWrapper
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public int QueryID;
    [FieldOffset(0x0058)] public TSubclassOf<UEnvQueryItemType> ItemType;
    [FieldOffset(0x0060)] public int OptionIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType_VectorBase
{
    [FieldOffset(0x0000)] public UEnvQueryItemType baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType_ActorBase
{
    [FieldOffset(0x0000)] public UEnvQueryItemType_VectorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType_Actor
{
    [FieldOffset(0x0000)] public UEnvQueryItemType_ActorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType_Direction
{
    [FieldOffset(0x0000)] public UEnvQueryItemType_VectorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UEnvQueryItemType_Point
{
    [FieldOffset(0x0000)] public UEnvQueryItemType_VectorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x178)] 
public unsafe struct FEnvQueryInstanceCache
{
    [FieldOffset(0x0000)] public UEnvQuery* Template;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UEnvQueryManager
{
    [FieldOffset(0x0000)] public UAISubsystem baseObj;
    [FieldOffset(0x00A8)] public TArray<FEnvQueryInstanceCache> InstanceCache;
    [FieldOffset(0x00B8)] public TArray<IntPtr> LocalContexts;
    [FieldOffset(0x00C8)] public TArray<IntPtr> GCShieldedWrappers;
    [FieldOffset(0x012C)] public float MaxAllowedTestingTime;
    [FieldOffset(0x0130)] public bool bTestQueriesUsingBreadth;
    [FieldOffset(0x0134)] public int QueryCountWarningThreshold;
    [FieldOffset(0x0138)] public double QueryCountWarningInterval;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UEnvQueryOption
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UEnvQueryGenerator* Generator;
    [FieldOffset(0x0030)] public TArray<IntPtr> Tests;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F8)] 
public unsafe struct UEnvQueryTest
{
    [FieldOffset(0x0000)] public UEnvQueryNode baseObj;
    [FieldOffset(0x0030)] public int TestOrder;
    [FieldOffset(0x0034)] public EEnvTestPurpose TestPurpose;
    [FieldOffset(0x0038)] public FString TestComment;
    [FieldOffset(0x0048)] public EEnvTestFilterOperator MultipleContextFilterOp;
    [FieldOffset(0x0049)] public EEnvTestScoreOperator MultipleContextScoreOp;
    [FieldOffset(0x004A)] public EEnvTestFilterType FilterType;
    [FieldOffset(0x0050)] public FAIDataProviderBoolValue BoolValue;
    [FieldOffset(0x0088)] public FAIDataProviderFloatValue FloatValueMin;
    [FieldOffset(0x00C0)] public FAIDataProviderFloatValue FloatValueMax;
    [FieldOffset(0x00F9)] public EEnvTestScoreEquation ScoringEquation;
    [FieldOffset(0x00FA)] public EEnvQueryTestClamping ClampMinType;
    [FieldOffset(0x00FB)] public EEnvQueryTestClamping ClampMaxType;
    [FieldOffset(0x00FC)] public EEQSNormalizationType NormalizationType;
    [FieldOffset(0x0100)] public FAIDataProviderFloatValue ScoreClampMin;
    [FieldOffset(0x0138)] public FAIDataProviderFloatValue ScoreClampMax;
    [FieldOffset(0x0170)] public FAIDataProviderFloatValue ScoringFactor;
    [FieldOffset(0x01A8)] public FAIDataProviderFloatValue ReferenceValue;
    [FieldOffset(0x01E0)] public bool bDefineReferenceValue;
    [FieldOffset(0x01F0)] public byte bWorkOnFloatValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x208)] 
public unsafe struct UEnvQueryTest_Distance
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public EEnvTestDistance TestMode;
    [FieldOffset(0x0200)] public TSubclassOf<UEnvQueryContext> DistanceTo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct UEnvQueryTest_Dot
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public FEnvDirection LineA;
    [FieldOffset(0x0218)] public FEnvDirection LineB;
    [FieldOffset(0x0238)] public EEnvTestDot TestMode;
    [FieldOffset(0x0239)] public bool bAbsoluteValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct UEnvQueryTest_GameplayTags
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public FGameplayTagQuery TagQueryToMatch;
    [FieldOffset(0x0240)] public bool bUpdatedToUseQuery;
    [FieldOffset(0x0241)] public EGameplayContainerMatchType TagsToMatch;
    [FieldOffset(0x0248)] public FGameplayTagContainer GameplayTags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEnvOverlapData
{
    [FieldOffset(0x0000)] public float ExtentX;
    [FieldOffset(0x0004)] public float ExtentY;
    [FieldOffset(0x0008)] public float ExtentZ;
    [FieldOffset(0x000C)] public FVector ShapeOffset;
    [FieldOffset(0x0018)] public ECollisionChannel OverlapChannel;
    [FieldOffset(0x0019)] public EEnvOverlapShape OverlapShape;
    [FieldOffset(0x001C)] public byte bOnlyBlockingHits;
    [FieldOffset(0x001C)] public byte bOverlapComplex;
    [FieldOffset(0x001C)] public byte bSkipOverlapQuerier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x218)] 
public unsafe struct UEnvQueryTest_Overlap
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public FEnvOverlapData OverlapData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UEnvQueryTest_Pathfinding
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public EEnvTestPathfinding TestMode;
    [FieldOffset(0x0200)] public TSubclassOf<UEnvQueryContext> Context;
    [FieldOffset(0x0208)] public FAIDataProviderBoolValue PathFromContext;
    [FieldOffset(0x0240)] public FAIDataProviderBoolValue SkipUnreachable;
    [FieldOffset(0x0278)] public TSubclassOf<UNavigationQueryFilter> FilterClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct UEnvQueryTest_PathfindingBatch
{
    [FieldOffset(0x0000)] public UEnvQueryTest_Pathfinding baseObj;
    [FieldOffset(0x0280)] public FAIDataProviderFloatValue ScanRangeMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct UEnvQueryTest_Project
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public FEnvTraceData ProjectionData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F8)] 
public unsafe struct UEnvQueryTest_Random
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct UEnvQueryTest_Trace
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public FEnvTraceData TraceData;
    [FieldOffset(0x0228)] public FAIDataProviderBoolValue TraceFromContext;
    [FieldOffset(0x0260)] public FAIDataProviderFloatValue ItemHeightOffset;
    [FieldOffset(0x0298)] public FAIDataProviderFloatValue ContextHeightOffset;
    [FieldOffset(0x02D0)] public TSubclassOf<UEnvQueryContext> Context;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct UEnvQueryTest_Volume
{
    [FieldOffset(0x0000)] public UEnvQueryTest baseObj;
    [FieldOffset(0x01F8)] public TSubclassOf<UEnvQueryContext> VolumeContext;
    [FieldOffset(0x0200)] public TSubclassOf<AVolume> VolumeClass;
    [FieldOffset(0x0208)] public byte bDoComplexVolumeTest;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEnvQueryTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IEQSQueryResultSourceInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UEQSRenderingComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x550)] 
public unsafe struct AEQSTestingPawn
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04C0)] public UEnvQuery* QueryTemplate;
    [FieldOffset(0x04C8)] public TArray<FEnvNamedValue> QueryParams;
    [FieldOffset(0x04D8)] public TArray<FAIDynamicParam> QueryConfig;
    [FieldOffset(0x04E8)] public float TimeLimitPerStep;
    [FieldOffset(0x04EC)] public int StepToDebugDraw;
    [FieldOffset(0x04F0)] public EEnvQueryHightlightMode HighlightMode;
    [FieldOffset(0x04F4)] public byte bDrawLabels;
    [FieldOffset(0x04F4)] public byte bDrawFailedItems;
    [FieldOffset(0x04F4)] public byte bReRunQueryOnlyOnFinishedMove;
    [FieldOffset(0x04F4)] public byte bShouldBeVisibleInGame;
    [FieldOffset(0x04F4)] public byte bTickDuringGame;
    [FieldOffset(0x04F8)] public EEnvQueryRunMode QueryingMode;
    [FieldOffset(0x0500)] public FNavAgentProperties NavAgentProperties;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGenericTeamAgentInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct AGridPathAIController
{
    [FieldOffset(0x0000)] public AAIController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UGridPathFollowingComponent
{
    [FieldOffset(0x0000)] public UPathFollowingComponent baseObj;
    [FieldOffset(0x0250)] public UNavLocalGridManager* GridManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UNavFilter_AIControllerDefault
{
    [FieldOffset(0x0000)] public UNavigationQueryFilter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct ANavLinkProxy
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public TArray<FNavigationLink> PointLinks;
    [FieldOffset(0x0240)] public TArray<FNavigationSegmentLink> SegmentLinks;
    [FieldOffset(0x0250)] public UNavLinkCustomComponent* SmartLinkComp;
    [FieldOffset(0x0258)] public bool bSmartLinkIsRelevant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UNavLocalGridManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UPathFollowingManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UPawnAction
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UPawnAction* ChildAction;
    [FieldOffset(0x0030)] public UPawnAction* ParentAction;
    [FieldOffset(0x0038)] public UPawnActionsComponent* OwnerComponent;
    [FieldOffset(0x0040)] public UObject* Instigator;
    [FieldOffset(0x0048)] public UBrainComponent* BrainComp;
    [FieldOffset(0x0080)] public byte bAllowNewSameClassInstance;
    [FieldOffset(0x0080)] public byte bReplaceActiveSameClassInstance;
    [FieldOffset(0x0080)] public byte bShouldPauseMovement;
    [FieldOffset(0x0080)] public byte bAlwaysNotifyOnFinished;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UPawnAction_BlueprintBase
{
    [FieldOffset(0x0000)] public UPawnAction baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UPawnAction_Move
{
    [FieldOffset(0x0000)] public UPawnAction baseObj;
    [FieldOffset(0x0090)] public AActor* GoalActor;
    [FieldOffset(0x0098)] public FVector GoalLocation;
    [FieldOffset(0x00A4)] public float AcceptableRadius;
    [FieldOffset(0x00A8)] public TSubclassOf<UNavigationQueryFilter> FilterClass;
    [FieldOffset(0x00B0)] public byte bAllowStrafe;
    [FieldOffset(0x00B0)] public byte bFinishOnOverlap;
    [FieldOffset(0x00B0)] public byte bUsePathfinding;
    [FieldOffset(0x00B0)] public byte bAllowPartialPath;
    [FieldOffset(0x00B0)] public byte bProjectGoalToNavigation;
    [FieldOffset(0x00B0)] public byte bUpdatePathToGoal;
    [FieldOffset(0x00B0)] public byte bAbortChildActionOnPathChange;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UPawnAction_Repeat
{
    [FieldOffset(0x0000)] public UPawnAction baseObj;
    [FieldOffset(0x0090)] public UPawnAction* ActionToRepeat;
    [FieldOffset(0x0098)] public UPawnAction* RecentActionCopy;
    [FieldOffset(0x00A0)] public EPawnActionFailHandling ChildFailureHandlingMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UPawnAction_Sequence
{
    [FieldOffset(0x0000)] public UPawnAction baseObj;
    [FieldOffset(0x0090)] public TArray<IntPtr> ActionSequence;
    [FieldOffset(0x00A0)] public EPawnActionFailHandling ChildFailureHandlingMode;
    [FieldOffset(0x00A8)] public UPawnAction* RecentActionCopy;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UPawnAction_Wait
{
    [FieldOffset(0x0000)] public UPawnAction baseObj;
    [FieldOffset(0x0090)] public float TimeToWait;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPawnActionStack
{
    [FieldOffset(0x0000)] public UPawnAction* TopAction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPawnActionEvent
{
    [FieldOffset(0x0000)] public UPawnAction* Action;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UPawnActionsComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public APawn* ControlledPawn;
    [FieldOffset(0x00B8)] public TArray<FPawnActionStack> ActionStacks;
    [FieldOffset(0x00C8)] public TArray<FPawnActionEvent> ActionEvents;
    [FieldOffset(0x00D8)] public UPawnAction* CurrentAction;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UPawnSensingComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float HearingThreshold;
    [FieldOffset(0x00B4)] public float LOSHearingThreshold;
    [FieldOffset(0x00B8)] public float SightRadius;
    [FieldOffset(0x00BC)] public float SensingInterval;
    [FieldOffset(0x00C0)] public float HearingMaxSoundAge;
    [FieldOffset(0x00C4)] public byte bEnableSensingUpdates;
    [FieldOffset(0x00C4)] public byte bOnlySensePlayers;
    [FieldOffset(0x00C4)] public byte bSeePawns;
    [FieldOffset(0x00C4)] public byte bHearNoises;
    [FieldOffset(0x00F0)] public float PeripheralVisionAngle;
    [FieldOffset(0x00F4)] public float PeripheralVisionCosine;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVisualLoggerExtension
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FActorPerceptionUpdateInfo
{
    [FieldOffset(0x0000)] public int TargetID;
    [FieldOffset(0x0004)] public TWeakObjectPtr<AActor> Target;
    [FieldOffset(0x000C)] public FAIStimulus Stimulus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAIDataProviderStructValue
{
    [FieldOffset(0x0000)] public FAIDataProviderValue baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAISightEvent
{
    [FieldOffset(0x0008)] public AActor* SeenActor;
    [FieldOffset(0x0010)] public AActor* Observer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FEnvQueryRequest
{
    [FieldOffset(0x0000)] public UEnvQuery* QueryTemplate;
    [FieldOffset(0x0008)] public UObject* Owner;
    [FieldOffset(0x0010)] public UWorld* World;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FEnvQueryResult
{
    [FieldOffset(0x0010)] public TSubclassOf<UEnvQueryItemType> ItemType;
    [FieldOffset(0x002C)] public int OptionIndex;
    [FieldOffset(0x0030)] public int QueryID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FGenericTeamId
{
    [FieldOffset(0x0000)] public byte TeamID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FRecastGraphWrapper
{
    [FieldOffset(0x0000)] public ARecastNavMesh* RecastNavMeshActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct FDefault__AISenseBlueprintListener
{
}

