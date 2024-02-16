using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AIController : ObjectBase<AAIController>
{

    public bool UseBlackboard(UBlackboardData* BlackboardAsset, ref UBlackboardComponent* BlackboardComponent)
    {
        Span<(string name, object value)> @params = [
            ("BlackboardAsset", (IntPtr)BlackboardAsset), 
            ("BlackboardComponent", (IntPtr)BlackboardComponent)
        ];
        return ProcessEvent<bool>(GetFunction("UseBlackboard"),  @params);
    }
    public void UnclaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
    {
        Span<(string name, object value)> @params = [
            ("ResourceClass", ResourceClass)
        ];
        ProcessEvent(GetFunction("UnclaimTaskResource"),  @params);
    }
    public void SetPathFollowingComponent(UPathFollowingComponent* NewPFComponent)
    {
        Span<(string name, object value)> @params = [
            ("NewPFComponent", (IntPtr)NewPFComponent)
        ];
        ProcessEvent(GetFunction("SetPathFollowingComponent"),  @params);
    }
    public void SetMoveBlockDetection(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetMoveBlockDetection"),  @params);
    }
    public bool RunBehaviorTree(UBehaviorTree* BTAsset)
    {
        Span<(string name, object value)> @params = [
            ("BTAsset", (IntPtr)BTAsset)
        ];
        return ProcessEvent<bool>(GetFunction("RunBehaviorTree"),  @params);
    }
    public void OnUsingBlackBoard(UBlackboardComponent* BlackboardComp, UBlackboardData* BlackboardAsset)
    {
        Span<(string name, object value)> @params = [
            ("BlackboardComp", (IntPtr)BlackboardComp), 
            ("BlackboardAsset", (IntPtr)BlackboardAsset)
        ];
        ProcessEvent(GetFunction("OnUsingBlackBoard"),  @params);
    }
    public void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
    {
        Span<(string name, object value)> @params = [
            ("NewlyClaimed", NewlyClaimed), 
            ("FreshlyReleased", FreshlyReleased)
        ];
        ProcessEvent(GetFunction("OnGameplayTaskResourcesClaimed"),  @params);
    }
    public EPathFollowingRequestResult MoveToLocation(ref FVector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, TSubclassOf<UNavigationQueryFilter> FilterClass, bool bAllowPartialPath)
    {
        Span<(string name, object value)> @params = [
            ("Dest", Dest), 
            ("AcceptanceRadius", AcceptanceRadius), 
            ("bStopOnOverlap", bStopOnOverlap), 
            ("bUsePathfinding", bUsePathfinding), 
            ("bProjectDestinationToNavigation", bProjectDestinationToNavigation), 
            ("bCanStrafe", bCanStrafe), 
            ("FilterClass", FilterClass), 
            ("bAllowPartialPath", bAllowPartialPath)
        ];
        return ProcessEvent<EPathFollowingRequestResult>(GetFunction("MoveToLocation"),  @params);
    }
    public EPathFollowingRequestResult MoveToActor(AActor* Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, TSubclassOf<UNavigationQueryFilter> FilterClass, bool bAllowPartialPath)
    {
        Span<(string name, object value)> @params = [
            ("Goal", (IntPtr)Goal), 
            ("AcceptanceRadius", AcceptanceRadius), 
            ("bStopOnOverlap", bStopOnOverlap), 
            ("bUsePathfinding", bUsePathfinding), 
            ("bCanStrafe", bCanStrafe), 
            ("FilterClass", FilterClass), 
            ("bAllowPartialPath", bAllowPartialPath)
        ];
        return ProcessEvent<EPathFollowingRequestResult>(GetFunction("MoveToActor"),  @params);
    }
    public void K2_SetFocus(AActor* NewFocus)
    {
        Span<(string name, object value)> @params = [
            ("NewFocus", (IntPtr)NewFocus)
        ];
        ProcessEvent(GetFunction("K2_SetFocus"),  @params);
    }
    public void K2_SetFocalPoint(FVector FP)
    {
        Span<(string name, object value)> @params = [
            ("FP", FP)
        ];
        ProcessEvent(GetFunction("K2_SetFocalPoint"),  @params);
    }
    public void K2_ClearFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("K2_ClearFocus"),  @params);
    }
    public bool HasPartialPath()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasPartialPath"),  @params);
    }
    public UPathFollowingComponent* GetPathFollowingComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPathFollowingComponent*)ProcessEvent<IntPtr>(GetFunction("GetPathFollowingComponent"),  @params);
    }
    public EPathFollowingStatus GetMoveStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EPathFollowingStatus>(GetFunction("GetMoveStatus"),  @params);
    }
    public FVector GetImmediateMoveDestination()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetImmediateMoveDestination"),  @params);
    }
    public AActor* GetFocusActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetFocusActor"),  @params);
    }
    public FVector GetFocalPointOnActor(AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<FVector>(GetFunction("GetFocalPointOnActor"),  @params);
    }
    public FVector GetFocalPoint()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetFocalPoint"),  @params);
    }
    public UAIPerceptionComponent* GetAIPerceptionComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAIPerceptionComponent*)ProcessEvent<IntPtr>(GetFunction("GetAIPerceptionComponent"),  @params);
    }
    public void ClaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
    {
        Span<(string name, object value)> @params = [
            ("ResourceClass", ResourceClass)
        ];
        ProcessEvent(GetFunction("ClaimTaskResource"),  @params);
    }
}

public unsafe class AIRequestID : ObjectBase<FAIRequestID>
{

}

public unsafe class AIAsyncTaskBlueprintProxy : ObjectBase<UAIAsyncTaskBlueprintProxy>
{

    public void OnMoveCompleted(FAIRequestID RequestID, EPathFollowingResult MovementResult)
    {
        Span<(string name, object value)> @params = [
            ("RequestID", RequestID), 
            ("MovementResult", MovementResult)
        ];
        ProcessEvent(GetFunction("OnMoveCompleted"),  @params);
    }
}

public unsafe class AIBlueprintHelperLibrary : ObjectBase<UAIBlueprintHelperLibrary>
{

    public void UnlockAIResourcesWithAnimation(UAnimInstance* AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("bUnlockMovement", bUnlockMovement), 
            ("UnlockAILogic", UnlockAILogic)
        ];
        ProcessEvent(GetFunction("UnlockAIResourcesWithAnimation"),  @params);
    }
    public APawn* SpawnAIFromClass(UObject* WorldContextObject, TSubclassOf<APawn> PawnClass, UBehaviorTree* BehaviorTree, FVector Location, FRotator Rotation, bool bNoCollisionFail, AActor* Owner)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PawnClass", PawnClass), 
            ("BehaviorTree", (IntPtr)BehaviorTree), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("bNoCollisionFail", bNoCollisionFail), 
            ("Owner", (IntPtr)Owner)
        ];
        return (APawn*)ProcessEvent<IntPtr>(GetFunction("SpawnAIFromClass"),  @params);
    }
    public void SimpleMoveToLocation(AController* Controller, ref FVector Goal)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("Goal", Goal)
        ];
        ProcessEvent(GetFunction("SimpleMoveToLocation"),  @params);
    }
    public void SimpleMoveToActor(AController* Controller, AActor* Goal)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("Goal", (IntPtr)Goal)
        ];
        ProcessEvent(GetFunction("SimpleMoveToActor"),  @params);
    }
    public void SendAIMessage(APawn* Target, FName Message, UObject* MessageSource, bool bSuccess)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("Message", Message), 
            ("MessageSource", (IntPtr)MessageSource), 
            ("bSuccess", bSuccess)
        ];
        ProcessEvent(GetFunction("SendAIMessage"),  @params);
    }
    public void LockAIResourcesWithAnimation(UAnimInstance* AnimInstance, bool bLockMovement, bool LockAILogic)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("bLockMovement", bLockMovement), 
            ("LockAILogic", LockAILogic)
        ];
        ProcessEvent(GetFunction("LockAIResourcesWithAnimation"),  @params);
    }
    public bool IsValidAIRotation(FRotator Rotation)
    {
        Span<(string name, object value)> @params = [
            ("Rotation", Rotation)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidAIRotation"),  @params);
    }
    public bool IsValidAILocation(FVector Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidAILocation"),  @params);
    }
    public bool IsValidAIDirection(FVector DirectionVector)
    {
        Span<(string name, object value)> @params = [
            ("DirectionVector", DirectionVector)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidAIDirection"),  @params);
    }
    public int GetNextNavLinkIndex(AController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller)
        ];
        return ProcessEvent<int>(GetFunction("GetNextNavLinkIndex"),  @params);
    }
    public TArray<FVector> GetCurrentPathPoints(AController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller)
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetCurrentPathPoints"),  @params);
    }
    public int GetCurrentPathIndex(AController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller)
        ];
        return ProcessEvent<int>(GetFunction("GetCurrentPathIndex"),  @params);
    }
    public UNavigationPath* GetCurrentPath(AController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller)
        ];
        return (UNavigationPath*)ProcessEvent<IntPtr>(GetFunction("GetCurrentPath"),  @params);
    }
    public UBlackboardComponent* GetBlackboard(AActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        return (UBlackboardComponent*)ProcessEvent<IntPtr>(GetFunction("GetBlackboard"),  @params);
    }
    public AAIController* GetAIController(AActor* ControlledActor)
    {
        Span<(string name, object value)> @params = [
            ("ControlledActor", (IntPtr)ControlledActor)
        ];
        return (AAIController*)ProcessEvent<IntPtr>(GetFunction("GetAIController"),  @params);
    }
    public UAIAsyncTaskBlueprintProxy* CreateMoveToProxyObject(UObject* WorldContextObject, APawn* Pawn, FVector Destination, AActor* TargetActor, float AcceptanceRadius, bool bStopOnOverlap)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Pawn", (IntPtr)Pawn), 
            ("Destination", Destination), 
            ("TargetActor", (IntPtr)TargetActor), 
            ("AcceptanceRadius", AcceptanceRadius), 
            ("bStopOnOverlap", bStopOnOverlap)
        ];
        return (UAIAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CreateMoveToProxyObject"),  @params);
    }
}

public unsafe class AIDataProvider : ObjectBase<UAIDataProvider>
{
}

public unsafe class AIDataProvider_QueryParams : ObjectBase<UAIDataProvider_QueryParams>
{

}

public unsafe class AIDataProvider_Random : ObjectBase<UAIDataProvider_Random>
{

}

public unsafe class AIHotSpotManager : ObjectBase<UAIHotSpotManager>
{
}

public unsafe class ActorPerceptionBlueprintInfo : ObjectBase<FActorPerceptionBlueprintInfo>
{

}

public unsafe class AIPerceptionComponent : ObjectBase<UAIPerceptionComponent>
{

    public void SetSenseEnabled(TSubclassOf<UAISense> SenseClass, bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("SenseClass", SenseClass), 
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetSenseEnabled"),  @params);
    }
    public void RequestStimuliListenerUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestStimuliListenerUpdate"),  @params);
    }
    public void OnOwnerEndPlay(AActor* Actor, EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("OnOwnerEndPlay"),  @params);
    }
    public void GetPerceivedHostileActorsBySense(TSubclassOf<UAISense> SenseToUse, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("SenseToUse", SenseToUse), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetPerceivedHostileActorsBySense"),  @params);
    }
    public void GetPerceivedHostileActors(ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetPerceivedHostileActors"),  @params);
    }
    public void GetPerceivedActors(TSubclassOf<UAISense> SenseToUse, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("SenseToUse", SenseToUse), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetPerceivedActors"),  @params);
    }
    public void GetKnownPerceivedActors(TSubclassOf<UAISense> SenseToUse, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("SenseToUse", SenseToUse), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetKnownPerceivedActors"),  @params);
    }
    public void GetCurrentlyPerceivedActors(TSubclassOf<UAISense> SenseToUse, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("SenseToUse", SenseToUse), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetCurrentlyPerceivedActors"),  @params);
    }
    public bool GetActorsPerception(AActor* Actor, ref FActorPerceptionBlueprintInfo Info)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Info", Info)
        ];
        return ProcessEvent<bool>(GetFunction("GetActorsPerception"),  @params);
    }
    public void ForgetAll()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForgetAll"),  @params);
    }
}

public unsafe class AIPerceptionListenerInterface : ObjectBase<IAIPerceptionListenerInterface>
{
}

public unsafe class AIPerceptionStimuliSourceComponent : ObjectBase<UAIPerceptionStimuliSourceComponent>
{

    public void UnregisterFromSense(TSubclassOf<UAISense> SenseClass)
    {
        Span<(string name, object value)> @params = [
            ("SenseClass", SenseClass)
        ];
        ProcessEvent(GetFunction("UnregisterFromSense"),  @params);
    }
    public void UnregisterFromPerceptionSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UnregisterFromPerceptionSystem"),  @params);
    }
    public void RegisterWithPerceptionSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RegisterWithPerceptionSystem"),  @params);
    }
    public void RegisterForSense(TSubclassOf<UAISense> SenseClass)
    {
        Span<(string name, object value)> @params = [
            ("SenseClass", SenseClass)
        ];
        ProcessEvent(GetFunction("RegisterForSense"),  @params);
    }
}

public unsafe class AISubsystem : ObjectBase<UAISubsystem>
{

}

public unsafe class AIStimulus : ObjectBase<FAIStimulus>
{

}

public unsafe class AIPerceptionSystem : ObjectBase<UAIPerceptionSystem>
{

    public void ReportPerceptionEvent(UObject* WorldContextObject, UAISenseEvent* PerceptionEvent)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PerceptionEvent", (IntPtr)PerceptionEvent)
        ];
        ProcessEvent(GetFunction("ReportPerceptionEvent"),  @params);
    }
    public void ReportEvent(UAISenseEvent* PerceptionEvent)
    {
        Span<(string name, object value)> @params = [
            ("PerceptionEvent", (IntPtr)PerceptionEvent)
        ];
        ProcessEvent(GetFunction("ReportEvent"),  @params);
    }
    public bool RegisterPerceptionStimuliSource(UObject* WorldContextObject, TSubclassOf<UAISense> Sense, AActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Sense", Sense), 
            ("Target", (IntPtr)Target)
        ];
        return ProcessEvent<bool>(GetFunction("RegisterPerceptionStimuliSource"),  @params);
    }
    public void OnPerceptionStimuliSourceEndPlay(AActor* Actor, EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("OnPerceptionStimuliSourceEndPlay"),  @params);
    }
    public TSubclassOf<UAISense> GetSenseClassForStimulus(UObject* WorldContextObject, ref FAIStimulus Stimulus)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Stimulus", Stimulus)
        ];
        return ProcessEvent<TSubclassOf<UAISense>>(GetFunction("GetSenseClassForStimulus"),  @params);
    }
}

public unsafe class AIResourceInterface : ObjectBase<IAIResourceInterface>
{
}

public unsafe class AIResource_Movement : ObjectBase<UAIResource_Movement>
{
}

public unsafe class AIResource_Logic : ObjectBase<UAIResource_Logic>
{
}

public unsafe class AISense : ObjectBase<UAISense>
{

}

public unsafe class AISense_Blueprint : ObjectBase<UAISense_Blueprint>
{

    public float OnUpdate(ref TArray<IntPtr> EventsToProcess)
    {
        Span<(string name, object value)> @params = [
            ("EventsToProcess", EventsToProcess)
        ];
        return ProcessEvent<float>(GetFunction("OnUpdate"),  @params);
    }
    public void OnListenerUpdated(AActor* ActorListener, UAIPerceptionComponent* PerceptionComponent)
    {
        Span<(string name, object value)> @params = [
            ("ActorListener", (IntPtr)ActorListener), 
            ("PerceptionComponent", (IntPtr)PerceptionComponent)
        ];
        ProcessEvent(GetFunction("OnListenerUpdated"),  @params);
    }
    public void OnListenerUnregistered(AActor* ActorListener, UAIPerceptionComponent* PerceptionComponent)
    {
        Span<(string name, object value)> @params = [
            ("ActorListener", (IntPtr)ActorListener), 
            ("PerceptionComponent", (IntPtr)PerceptionComponent)
        ];
        ProcessEvent(GetFunction("OnListenerUnregistered"),  @params);
    }
    public void OnListenerRegistered(AActor* ActorListener, UAIPerceptionComponent* PerceptionComponent)
    {
        Span<(string name, object value)> @params = [
            ("ActorListener", (IntPtr)ActorListener), 
            ("PerceptionComponent", (IntPtr)PerceptionComponent)
        ];
        ProcessEvent(GetFunction("OnListenerRegistered"),  @params);
    }
    public void K2_OnNewPawn(APawn* NewPawn)
    {
        Span<(string name, object value)> @params = [
            ("NewPawn", (IntPtr)NewPawn)
        ];
        ProcessEvent(GetFunction("K2_OnNewPawn"),  @params);
    }
    public void GetAllListenerComponents(ref TArray<IntPtr> ListenerComponents)
    {
        Span<(string name, object value)> @params = [
            ("ListenerComponents", ListenerComponents)
        ];
        ProcessEvent(GetFunction("GetAllListenerComponents"),  @params);
    }
    public void GetAllListenerActors(ref TArray<IntPtr> ListenerActors)
    {
        Span<(string name, object value)> @params = [
            ("ListenerActors", ListenerActors)
        ];
        ProcessEvent(GetFunction("GetAllListenerActors"),  @params);
    }
}

public unsafe class AISense_Damage : ObjectBase<UAISense_Damage>
{

    public void ReportDamageEvent(UObject* WorldContextObject, AActor* DamagedActor, AActor* Instigator, float DamageAmount, FVector EventLocation, FVector HitLocation, FName Tag)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("DamagedActor", (IntPtr)DamagedActor), 
            ("Instigator", (IntPtr)Instigator), 
            ("DamageAmount", DamageAmount), 
            ("EventLocation", EventLocation), 
            ("HitLocation", HitLocation), 
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("ReportDamageEvent"),  @params);
    }
}

public unsafe class AISense_Hearing : ObjectBase<UAISense_Hearing>
{

    public void ReportNoiseEvent(UObject* WorldContextObject, FVector NoiseLocation, float Loudness, AActor* Instigator, float MaxRange, FName Tag)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("NoiseLocation", NoiseLocation), 
            ("Loudness", Loudness), 
            ("Instigator", (IntPtr)Instigator), 
            ("MaxRange", MaxRange), 
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("ReportNoiseEvent"),  @params);
    }
}

public unsafe class AISense_Prediction : ObjectBase<UAISense_Prediction>
{

    public void RequestPawnPredictionEvent(APawn* Requestor, AActor* PredictedActor, float PredictionTime)
    {
        Span<(string name, object value)> @params = [
            ("Requestor", (IntPtr)Requestor), 
            ("PredictedActor", (IntPtr)PredictedActor), 
            ("PredictionTime", PredictionTime)
        ];
        ProcessEvent(GetFunction("RequestPawnPredictionEvent"),  @params);
    }
    public void RequestControllerPredictionEvent(AAIController* Requestor, AActor* PredictedActor, float PredictionTime)
    {
        Span<(string name, object value)> @params = [
            ("Requestor", (IntPtr)Requestor), 
            ("PredictedActor", (IntPtr)PredictedActor), 
            ("PredictionTime", PredictionTime)
        ];
        ProcessEvent(GetFunction("RequestControllerPredictionEvent"),  @params);
    }
}

public unsafe class AISense_Sight : ObjectBase<UAISense_Sight>
{

}

public unsafe class AISense_Team : ObjectBase<UAISense_Team>
{

}

public unsafe class AISense_Touch : ObjectBase<UAISense_Touch>
{

}

public unsafe class AISenseBlueprintListener : ObjectBase<UAISenseBlueprintListener>
{
}

public unsafe class AISenseConfig : ObjectBase<UAISenseConfig>
{

}

public unsafe class AISenseConfig_Blueprint : ObjectBase<UAISenseConfig_Blueprint>
{

}

public unsafe class AISenseConfig_Damage : ObjectBase<UAISenseConfig_Damage>
{

}

public unsafe class AISenseConfig_Hearing : ObjectBase<UAISenseConfig_Hearing>
{

}

public unsafe class AISenseConfig_Prediction : ObjectBase<UAISenseConfig_Prediction>
{
}

public unsafe class AISenseConfig_Sight : ObjectBase<UAISenseConfig_Sight>
{

}

public unsafe class AISenseConfig_Team : ObjectBase<UAISenseConfig_Team>
{
}

public unsafe class AISenseConfig_Touch : ObjectBase<UAISenseConfig_Touch>
{
}

public unsafe class AISenseEvent : ObjectBase<UAISenseEvent>
{
}

public unsafe class AISenseEvent_Damage : ObjectBase<UAISenseEvent_Damage>
{

}

public unsafe class AISenseEvent_Hearing : ObjectBase<UAISenseEvent_Hearing>
{

}

public unsafe class AISightTargetInterface : ObjectBase<IAISightTargetInterface>
{
}

public unsafe class AISystem : ObjectBase<UAISystem>
{

    public void AILoggingVerbose()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AILoggingVerbose"),  @params);
    }
    public void AIIgnorePlayers()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AIIgnorePlayers"),  @params);
    }
}

public unsafe class AITask : ObjectBase<UAITask>
{

}

public unsafe class AITask_LockLogic : ObjectBase<UAITask_LockLogic>
{
}

public unsafe class AITask_MoveTo : ObjectBase<UAITask_MoveTo>
{

    public UAITask_MoveTo* AIMoveTo(AAIController* Controller, FVector GoalLocation, AActor* GoalActor, float AcceptanceRadius, EAIOptionFlag StopOnOverlap, EAIOptionFlag AcceptPartialPath, bool bUsePathfinding, bool bLockAILogic, bool bUseContinuosGoalTracking, EAIOptionFlag ProjectGoalOnNavigation)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("GoalLocation", GoalLocation), 
            ("GoalActor", (IntPtr)GoalActor), 
            ("AcceptanceRadius", AcceptanceRadius), 
            ("StopOnOverlap", StopOnOverlap), 
            ("AcceptPartialPath", AcceptPartialPath), 
            ("bUsePathfinding", bUsePathfinding), 
            ("bLockAILogic", bLockAILogic), 
            ("bUseContinuosGoalTracking", bUseContinuosGoalTracking), 
            ("ProjectGoalOnNavigation", ProjectGoalOnNavigation)
        ];
        return (UAITask_MoveTo*)ProcessEvent<IntPtr>(GetFunction("AIMoveTo"),  @params);
    }
}

public unsafe class AITask_RunEQS : ObjectBase<UAITask_RunEQS>
{

    public UAITask_RunEQS* RunEQS(AAIController* Controller, UEnvQuery* QueryTemplate)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller), 
            ("QueryTemplate", (IntPtr)QueryTemplate)
        ];
        return (UAITask_RunEQS*)ProcessEvent<IntPtr>(GetFunction("RunEQS"),  @params);
    }
}

public unsafe class BehaviorTree : ObjectBase<UBehaviorTree>
{

}

public unsafe class BrainComponent : ObjectBase<UBrainComponent>
{

    public void StopLogic(FString Reason)
    {
        Span<(string name, object value)> @params = [
            ("Reason", Reason)
        ];
        ProcessEvent(GetFunction("StopLogic"),  @params);
    }
    public void StartLogic()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartLogic"),  @params);
    }
    public void RestartLogic()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestartLogic"),  @params);
    }
    public bool IsRunning()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsRunning"),  @params);
    }
    public bool IsPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPaused"),  @params);
    }
}

public unsafe class BehaviorTreeComponent : ObjectBase<UBehaviorTreeComponent>
{

    public void SetDynamicSubtree(FGameplayTag InjectTag, UBehaviorTree* BehaviorAsset)
    {
        Span<(string name, object value)> @params = [
            ("InjectTag", InjectTag), 
            ("BehaviorAsset", (IntPtr)BehaviorAsset)
        ];
        ProcessEvent(GetFunction("SetDynamicSubtree"),  @params);
    }
    public float GetTagCooldownEndTime(FGameplayTag CooldownTag)
    {
        Span<(string name, object value)> @params = [
            ("CooldownTag", CooldownTag)
        ];
        return ProcessEvent<float>(GetFunction("GetTagCooldownEndTime"),  @params);
    }
    public void AddCooldownTagDuration(FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)
    {
        Span<(string name, object value)> @params = [
            ("CooldownTag", CooldownTag), 
            ("CooldownDuration", CooldownDuration), 
            ("bAddToExistingDuration", bAddToExistingDuration)
        ];
        ProcessEvent(GetFunction("AddCooldownTagDuration"),  @params);
    }
}

public unsafe class BehaviorTreeManager : ObjectBase<UBehaviorTreeManager>
{

}

public unsafe class BehaviorTreeTypes : ObjectBase<UBehaviorTreeTypes>
{
}

public unsafe class BlackboardAssetProvider : ObjectBase<IBlackboardAssetProvider>
{

    public UBlackboardData* GetBlackboardAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBlackboardData*)ProcessEvent<IntPtr>(GetFunction("GetBlackboardAsset"),  @params);
    }
}

public unsafe class BlackboardComponent : ObjectBase<UBlackboardComponent>
{

    public void SetValueAsVector(ref FName KeyName, FVector VectorValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("VectorValue", VectorValue)
        ];
        ProcessEvent(GetFunction("SetValueAsVector"),  @params);
    }
    public void SetValueAsString(ref FName KeyName, FString StringValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("StringValue", StringValue)
        ];
        ProcessEvent(GetFunction("SetValueAsString"),  @params);
    }
    public void SetValueAsRotator(ref FName KeyName, FRotator VectorValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("VectorValue", VectorValue)
        ];
        ProcessEvent(GetFunction("SetValueAsRotator"),  @params);
    }
    public void SetValueAsObject(ref FName KeyName, UObject* ObjectValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("ObjectValue", (IntPtr)ObjectValue)
        ];
        ProcessEvent(GetFunction("SetValueAsObject"),  @params);
    }
    public void SetValueAsName(ref FName KeyName, FName NameValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("NameValue", NameValue)
        ];
        ProcessEvent(GetFunction("SetValueAsName"),  @params);
    }
    public void SetValueAsInt(ref FName KeyName, int IntValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("IntValue", IntValue)
        ];
        ProcessEvent(GetFunction("SetValueAsInt"),  @params);
    }
    public void SetValueAsFloat(ref FName KeyName, float FloatValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("FloatValue", FloatValue)
        ];
        ProcessEvent(GetFunction("SetValueAsFloat"),  @params);
    }
    public void SetValueAsEnum(ref FName KeyName, byte EnumValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("EnumValue", EnumValue)
        ];
        ProcessEvent(GetFunction("SetValueAsEnum"),  @params);
    }
    public void SetValueAsClass(ref FName KeyName, UClass* ClassValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("ClassValue", (IntPtr)ClassValue)
        ];
        ProcessEvent(GetFunction("SetValueAsClass"),  @params);
    }
    public void SetValueAsBool(ref FName KeyName, bool BoolValue)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("BoolValue", BoolValue)
        ];
        ProcessEvent(GetFunction("SetValueAsBool"),  @params);
    }
    public bool IsVectorValueSet(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<bool>(GetFunction("IsVectorValueSet"),  @params);
    }
    public FVector GetValueAsVector(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<FVector>(GetFunction("GetValueAsVector"),  @params);
    }
    public FString GetValueAsString(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<FString>(GetFunction("GetValueAsString"),  @params);
    }
    public FRotator GetValueAsRotator(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<FRotator>(GetFunction("GetValueAsRotator"),  @params);
    }
    public UObject* GetValueAsObject(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetValueAsObject"),  @params);
    }
    public FName GetValueAsName(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<FName>(GetFunction("GetValueAsName"),  @params);
    }
    public int GetValueAsInt(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<int>(GetFunction("GetValueAsInt"),  @params);
    }
    public float GetValueAsFloat(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<float>(GetFunction("GetValueAsFloat"),  @params);
    }
    public byte GetValueAsEnum(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<byte>(GetFunction("GetValueAsEnum"),  @params);
    }
    public UClass* GetValueAsClass(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return (UClass*)ProcessEvent<IntPtr>(GetFunction("GetValueAsClass"),  @params);
    }
    public bool GetValueAsBool(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        return ProcessEvent<bool>(GetFunction("GetValueAsBool"),  @params);
    }
    public bool GetRotationFromEntry(ref FName KeyName, ref FRotator ResultRotation)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("ResultRotation", ResultRotation)
        ];
        return ProcessEvent<bool>(GetFunction("GetRotationFromEntry"),  @params);
    }
    public bool GetLocationFromEntry(ref FName KeyName, ref FVector ResultLocation)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName), 
            ("ResultLocation", ResultLocation)
        ];
        return ProcessEvent<bool>(GetFunction("GetLocationFromEntry"),  @params);
    }
    public void ClearValue(ref FName KeyName)
    {
        Span<(string name, object value)> @params = [
            ("KeyName", KeyName)
        ];
        ProcessEvent(GetFunction("ClearValue"),  @params);
    }
}

public unsafe class BlackboardData : ObjectBase<UBlackboardData>
{

}

public unsafe class BlackboardKeyType : ObjectBase<UBlackboardKeyType>
{
}

public unsafe class BlackboardKeyType_Bool : ObjectBase<UBlackboardKeyType_Bool>
{
}

public unsafe class BlackboardKeyType_Class : ObjectBase<UBlackboardKeyType_Class>
{

}

public unsafe class BlackboardKeyType_Enum : ObjectBase<UBlackboardKeyType_Enum>
{

}

public unsafe class BlackboardKeyType_Float : ObjectBase<UBlackboardKeyType_Float>
{
}

public unsafe class BlackboardKeyType_Int : ObjectBase<UBlackboardKeyType_Int>
{
}

public unsafe class BlackboardKeyType_Name : ObjectBase<UBlackboardKeyType_Name>
{
}

public unsafe class BlackboardKeyType_NativeEnum : ObjectBase<UBlackboardKeyType_NativeEnum>
{

}

public unsafe class BlackboardKeyType_Object : ObjectBase<UBlackboardKeyType_Object>
{

}

public unsafe class BlackboardKeyType_Rotator : ObjectBase<UBlackboardKeyType_Rotator>
{
}

public unsafe class BlackboardKeyType_String : ObjectBase<UBlackboardKeyType_String>
{

}

public unsafe class BlackboardKeyType_Vector : ObjectBase<UBlackboardKeyType_Vector>
{
}

public unsafe class BTNode : ObjectBase<UBTNode>
{

}

public unsafe class BTAuxiliaryNode : ObjectBase<UBTAuxiliaryNode>
{
}

public unsafe class BTCompositeNode : ObjectBase<UBTCompositeNode>
{

}

public unsafe class BTComposite_Selector : ObjectBase<UBTComposite_Selector>
{
}

public unsafe class BTComposite_Sequence : ObjectBase<UBTComposite_Sequence>
{
}

public unsafe class BTComposite_SimpleParallel : ObjectBase<UBTComposite_SimpleParallel>
{

}

public unsafe class BTDecorator : ObjectBase<UBTDecorator>
{

}

public unsafe class BTDecorator_BlackboardBase : ObjectBase<UBTDecorator_BlackboardBase>
{

}

public unsafe class BTDecorator_Blackboard : ObjectBase<UBTDecorator_Blackboard>
{

}

public unsafe class BTDecorator_BlueprintBase : ObjectBase<UBTDecorator_BlueprintBase>
{

    public void ReceiveTickAI(AAIController* OwnerController, APawn* ControlledPawn, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTickAI"),  @params);
    }
    public void ReceiveTick(AActor* OwnerActor, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTick"),  @params);
    }
    public void ReceiveObserverDeactivatedAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveObserverDeactivatedAI"),  @params);
    }
    public void ReceiveObserverDeactivated(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveObserverDeactivated"),  @params);
    }
    public void ReceiveObserverActivatedAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveObserverActivatedAI"),  @params);
    }
    public void ReceiveObserverActivated(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveObserverActivated"),  @params);
    }
    public void ReceiveExecutionStartAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveExecutionStartAI"),  @params);
    }
    public void ReceiveExecutionStart(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveExecutionStart"),  @params);
    }
    public void ReceiveExecutionFinishAI(AAIController* OwnerController, APawn* ControlledPawn, EBTNodeResult NodeResult)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("NodeResult", NodeResult)
        ];
        ProcessEvent(GetFunction("ReceiveExecutionFinishAI"),  @params);
    }
    public void ReceiveExecutionFinish(AActor* OwnerActor, EBTNodeResult NodeResult)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor), 
            ("NodeResult", NodeResult)
        ];
        ProcessEvent(GetFunction("ReceiveExecutionFinish"),  @params);
    }
    public bool PerformConditionCheckAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        return ProcessEvent<bool>(GetFunction("PerformConditionCheckAI"),  @params);
    }
    public bool PerformConditionCheck(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        return ProcessEvent<bool>(GetFunction("PerformConditionCheck"),  @params);
    }
    public bool IsDecoratorObserverActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDecoratorObserverActive"),  @params);
    }
    public bool IsDecoratorExecutionActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDecoratorExecutionActive"),  @params);
    }
}

public unsafe class BTDecorator_CheckGameplayTagsOnActor : ObjectBase<UBTDecorator_CheckGameplayTagsOnActor>
{

}

public unsafe class BTDecorator_CompareBBEntries : ObjectBase<UBTDecorator_CompareBBEntries>
{

}

public unsafe class BTDecorator_ConditionalLoop : ObjectBase<UBTDecorator_ConditionalLoop>
{
}

public unsafe class BTDecorator_ConeCheck : ObjectBase<UBTDecorator_ConeCheck>
{

}

public unsafe class BTDecorator_Cooldown : ObjectBase<UBTDecorator_Cooldown>
{

}

public unsafe class BTDecorator_DoesPathExist : ObjectBase<UBTDecorator_DoesPathExist>
{

}

public unsafe class BTDecorator_ForceSuccess : ObjectBase<UBTDecorator_ForceSuccess>
{
}

public unsafe class BTDecorator_IsAtLocation : ObjectBase<UBTDecorator_IsAtLocation>
{

}

public unsafe class BTDecorator_IsBBEntryOfClass : ObjectBase<UBTDecorator_IsBBEntryOfClass>
{

}

public unsafe class BTDecorator_KeepInCone : ObjectBase<UBTDecorator_KeepInCone>
{

}

public unsafe class BTDecorator_Loop : ObjectBase<UBTDecorator_Loop>
{

}

public unsafe class BTDecorator_ReachedMoveGoal : ObjectBase<UBTDecorator_ReachedMoveGoal>
{
}

public unsafe class BTDecorator_SetTagCooldown : ObjectBase<UBTDecorator_SetTagCooldown>
{

}

public unsafe class BTDecorator_TagCooldown : ObjectBase<UBTDecorator_TagCooldown>
{

}

public unsafe class BTDecorator_TimeLimit : ObjectBase<UBTDecorator_TimeLimit>
{

}

public unsafe class BlackboardKeySelector : ObjectBase<FBlackboardKeySelector>
{

}

public unsafe class BTFunctionLibrary : ObjectBase<UBTFunctionLibrary>
{

    public void StopUsingExternalEvent(UBTNode* NodeOwner)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner)
        ];
        ProcessEvent(GetFunction("StopUsingExternalEvent"),  @params);
    }
    public void StartUsingExternalEvent(UBTNode* NodeOwner, AActor* OwningActor)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("OwningActor", (IntPtr)OwningActor)
        ];
        ProcessEvent(GetFunction("StartUsingExternalEvent"),  @params);
    }
    public void SetBlackboardValueAsVector(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, FVector Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsVector"),  @params);
    }
    public void SetBlackboardValueAsString(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, FString Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsString"),  @params);
    }
    public void SetBlackboardValueAsRotator(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, FRotator Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsRotator"),  @params);
    }
    public void SetBlackboardValueAsObject(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, UObject* Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", (IntPtr)Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsObject"),  @params);
    }
    public void SetBlackboardValueAsName(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, FName Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsName"),  @params);
    }
    public void SetBlackboardValueAsInt(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, int Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsInt"),  @params);
    }
    public void SetBlackboardValueAsFloat(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, float Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsFloat"),  @params);
    }
    public void SetBlackboardValueAsEnum(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, byte Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsEnum"),  @params);
    }
    public void SetBlackboardValueAsClass(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, UClass* Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", (IntPtr)Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsClass"),  @params);
    }
    public void SetBlackboardValueAsBool(UBTNode* NodeOwner, ref FBlackboardKeySelector Key, bool Value)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBlackboardValueAsBool"),  @params);
    }
    public UBlackboardComponent* GetOwnersBlackboard(UBTNode* NodeOwner)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner)
        ];
        return (UBlackboardComponent*)ProcessEvent<IntPtr>(GetFunction("GetOwnersBlackboard"),  @params);
    }
    public UBehaviorTreeComponent* GetOwnerComponent(UBTNode* NodeOwner)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner)
        ];
        return (UBehaviorTreeComponent*)ProcessEvent<IntPtr>(GetFunction("GetOwnerComponent"),  @params);
    }
    public FVector GetBlackboardValueAsVector(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<FVector>(GetFunction("GetBlackboardValueAsVector"),  @params);
    }
    public FString GetBlackboardValueAsString(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<FString>(GetFunction("GetBlackboardValueAsString"),  @params);
    }
    public FRotator GetBlackboardValueAsRotator(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<FRotator>(GetFunction("GetBlackboardValueAsRotator"),  @params);
    }
    public UObject* GetBlackboardValueAsObject(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetBlackboardValueAsObject"),  @params);
    }
    public FName GetBlackboardValueAsName(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<FName>(GetFunction("GetBlackboardValueAsName"),  @params);
    }
    public int GetBlackboardValueAsInt(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<int>(GetFunction("GetBlackboardValueAsInt"),  @params);
    }
    public float GetBlackboardValueAsFloat(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<float>(GetFunction("GetBlackboardValueAsFloat"),  @params);
    }
    public byte GetBlackboardValueAsEnum(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<byte>(GetFunction("GetBlackboardValueAsEnum"),  @params);
    }
    public UClass* GetBlackboardValueAsClass(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return (UClass*)ProcessEvent<IntPtr>(GetFunction("GetBlackboardValueAsClass"),  @params);
    }
    public bool GetBlackboardValueAsBool(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return ProcessEvent<bool>(GetFunction("GetBlackboardValueAsBool"),  @params);
    }
    public AActor* GetBlackboardValueAsActor(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetBlackboardValueAsActor"),  @params);
    }
    public void ClearBlackboardValueAsVector(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        ProcessEvent(GetFunction("ClearBlackboardValueAsVector"),  @params);
    }
    public void ClearBlackboardValue(UBTNode* NodeOwner, ref FBlackboardKeySelector Key)
    {
        Span<(string name, object value)> @params = [
            ("NodeOwner", (IntPtr)NodeOwner), 
            ("Key", Key)
        ];
        ProcessEvent(GetFunction("ClearBlackboardValue"),  @params);
    }
}

public unsafe class BTService : ObjectBase<UBTService>
{

}

public unsafe class BTService_BlackboardBase : ObjectBase<UBTService_BlackboardBase>
{

}

public unsafe class BTService_BlueprintBase : ObjectBase<UBTService_BlueprintBase>
{

    public void ReceiveTickAI(AAIController* OwnerController, APawn* ControlledPawn, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTickAI"),  @params);
    }
    public void ReceiveTick(AActor* OwnerActor, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTick"),  @params);
    }
    public void ReceiveSearchStartAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveSearchStartAI"),  @params);
    }
    public void ReceiveSearchStart(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveSearchStart"),  @params);
    }
    public void ReceiveDeactivationAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveDeactivationAI"),  @params);
    }
    public void ReceiveDeactivation(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveDeactivation"),  @params);
    }
    public void ReceiveActivationAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveActivationAI"),  @params);
    }
    public void ReceiveActivation(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveActivation"),  @params);
    }
    public bool IsServiceActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsServiceActive"),  @params);
    }
}

public unsafe class BTService_DefaultFocus : ObjectBase<UBTService_DefaultFocus>
{

}

public unsafe class BTService_RunEQS : ObjectBase<UBTService_RunEQS>
{

}

public unsafe class BTTaskNode : ObjectBase<UBTTaskNode>
{

}

public unsafe class BTTask_BlackboardBase : ObjectBase<UBTTask_BlackboardBase>
{

}

public unsafe class BTTask_BlueprintBase : ObjectBase<UBTTask_BlueprintBase>
{

    public void SetFinishOnMessageWithId(FName MessageName, int RequestID)
    {
        Span<(string name, object value)> @params = [
            ("MessageName", MessageName), 
            ("RequestID", RequestID)
        ];
        ProcessEvent(GetFunction("SetFinishOnMessageWithId"),  @params);
    }
    public void SetFinishOnMessage(FName MessageName)
    {
        Span<(string name, object value)> @params = [
            ("MessageName", MessageName)
        ];
        ProcessEvent(GetFunction("SetFinishOnMessage"),  @params);
    }
    public void ReceiveTickAI(AAIController* OwnerController, APawn* ControlledPawn, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTickAI"),  @params);
    }
    public void ReceiveTick(AActor* OwnerActor, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ReceiveTick"),  @params);
    }
    public void ReceiveExecuteAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveExecuteAI"),  @params);
    }
    public void ReceiveExecute(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveExecute"),  @params);
    }
    public void ReceiveAbortAI(AAIController* OwnerController, APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("OwnerController", (IntPtr)OwnerController), 
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ReceiveAbortAI"),  @params);
    }
    public void ReceiveAbort(AActor* OwnerActor)
    {
        Span<(string name, object value)> @params = [
            ("OwnerActor", (IntPtr)OwnerActor)
        ];
        ProcessEvent(GetFunction("ReceiveAbort"),  @params);
    }
    public bool IsTaskExecuting()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTaskExecuting"),  @params);
    }
    public bool IsTaskAborting()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTaskAborting"),  @params);
    }
    public void FinishExecute(bool bSuccess)
    {
        Span<(string name, object value)> @params = [
            ("bSuccess", bSuccess)
        ];
        ProcessEvent(GetFunction("FinishExecute"),  @params);
    }
    public void FinishAbort()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinishAbort"),  @params);
    }
}

public unsafe class BTTask_FinishWithResult : ObjectBase<UBTTask_FinishWithResult>
{

}

public unsafe class BTTask_GameplayTaskBase : ObjectBase<UBTTask_GameplayTaskBase>
{

}

public unsafe class BTTask_MakeNoise : ObjectBase<UBTTask_MakeNoise>
{

}

public unsafe class BTTask_MoveTo : ObjectBase<UBTTask_MoveTo>
{

}

public unsafe class BTTask_MoveDirectlyToward : ObjectBase<UBTTask_MoveDirectlyToward>
{

}

public unsafe class BTTask_PawnActionBase : ObjectBase<UBTTask_PawnActionBase>
{
}

public unsafe class BTTask_PlayAnimation : ObjectBase<UBTTask_PlayAnimation>
{

}

public unsafe class BTTask_PlaySound : ObjectBase<UBTTask_PlaySound>
{

}

public unsafe class BTTask_PushPawnAction : ObjectBase<UBTTask_PushPawnAction>
{

}

public unsafe class BTTask_RotateToFaceBBEntry : ObjectBase<UBTTask_RotateToFaceBBEntry>
{

}

public unsafe class BTTask_RunBehavior : ObjectBase<UBTTask_RunBehavior>
{

}

public unsafe class BTTask_RunBehaviorDynamic : ObjectBase<UBTTask_RunBehaviorDynamic>
{

}

public unsafe class BTTask_RunEQSQuery : ObjectBase<UBTTask_RunEQSQuery>
{

}

public unsafe class BTTask_SetTagCooldown : ObjectBase<UBTTask_SetTagCooldown>
{

}

public unsafe class BTTask_Wait : ObjectBase<UBTTask_Wait>
{

}

public unsafe class BTTask_WaitBlackboardTime : ObjectBase<UBTTask_WaitBlackboardTime>
{

}

public unsafe class CrowdAgentInterface : ObjectBase<ICrowdAgentInterface>
{
}

public unsafe class PathFollowingComponent : ObjectBase<UPathFollowingComponent>
{

    public void OnNavDataRegistered(ANavigationData* NavData)
    {
        Span<(string name, object value)> @params = [
            ("NavData", (IntPtr)NavData)
        ];
        ProcessEvent(GetFunction("OnNavDataRegistered"),  @params);
    }
    public void OnActorBump(AActor* SelfActor, AActor* OtherActor, FVector NormalImpulse, ref FHitResult Hit)
    {
        Span<(string name, object value)> @params = [
            ("SelfActor", (IntPtr)SelfActor), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("NormalImpulse", NormalImpulse), 
            ("Hit", Hit)
        ];
        ProcessEvent(GetFunction("OnActorBump"),  @params);
    }
    public FVector GetPathDestination()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetPathDestination"),  @params);
    }
    public EPathFollowingAction GetPathActionType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EPathFollowingAction>(GetFunction("GetPathActionType"),  @params);
    }
}

public unsafe class CrowdFollowingComponent : ObjectBase<UCrowdFollowingComponent>
{

    public void SuspendCrowdSteering(bool bSuspend)
    {
        Span<(string name, object value)> @params = [
            ("bSuspend", bSuspend)
        ];
        ProcessEvent(GetFunction("SuspendCrowdSteering"),  @params);
    }
}

public unsafe class CrowdManager : ObjectBase<UCrowdManager>
{

}

public unsafe class DetourCrowdAIController : ObjectBase<ADetourCrowdAIController>
{
}

public unsafe class EnvQuery : ObjectBase<UEnvQuery>
{

}

public unsafe class EnvQueryContext : ObjectBase<UEnvQueryContext>
{
}

public unsafe class EnvQueryContext_BlueprintBase : ObjectBase<UEnvQueryContext_BlueprintBase>
{

    public void ProvideSingleLocation(UObject* QuerierObject, AActor* QuerierActor, ref FVector ResultingLocation)
    {
        Span<(string name, object value)> @params = [
            ("QuerierObject", (IntPtr)QuerierObject), 
            ("QuerierActor", (IntPtr)QuerierActor), 
            ("ResultingLocation", ResultingLocation)
        ];
        ProcessEvent(GetFunction("ProvideSingleLocation"),  @params);
    }
    public void ProvideSingleActor(UObject* QuerierObject, AActor* QuerierActor, ref AActor* ResultingActor)
    {
        Span<(string name, object value)> @params = [
            ("QuerierObject", (IntPtr)QuerierObject), 
            ("QuerierActor", (IntPtr)QuerierActor), 
            ("ResultingActor", (IntPtr)ResultingActor)
        ];
        ProcessEvent(GetFunction("ProvideSingleActor"),  @params);
    }
    public void ProvideLocationsSet(UObject* QuerierObject, AActor* QuerierActor, ref TArray<FVector> ResultingLocationSet)
    {
        Span<(string name, object value)> @params = [
            ("QuerierObject", (IntPtr)QuerierObject), 
            ("QuerierActor", (IntPtr)QuerierActor), 
            ("ResultingLocationSet", ResultingLocationSet)
        ];
        ProcessEvent(GetFunction("ProvideLocationsSet"),  @params);
    }
    public void ProvideActorsSet(UObject* QuerierObject, AActor* QuerierActor, ref TArray<IntPtr> ResultingActorsSet)
    {
        Span<(string name, object value)> @params = [
            ("QuerierObject", (IntPtr)QuerierObject), 
            ("QuerierActor", (IntPtr)QuerierActor), 
            ("ResultingActorsSet", ResultingActorsSet)
        ];
        ProcessEvent(GetFunction("ProvideActorsSet"),  @params);
    }
}

public unsafe class EnvQueryContext_Item : ObjectBase<UEnvQueryContext_Item>
{
}

public unsafe class EnvQueryContext_Querier : ObjectBase<UEnvQueryContext_Querier>
{
}

public unsafe class EnvQueryDebugHelpers : ObjectBase<UEnvQueryDebugHelpers>
{
}

public unsafe class EnvQueryNode : ObjectBase<UEnvQueryNode>
{

}

public unsafe class EnvQueryGenerator : ObjectBase<UEnvQueryGenerator>
{

}

public unsafe class EnvQueryGenerator_ActorsOfClass : ObjectBase<UEnvQueryGenerator_ActorsOfClass>
{

}

public unsafe class EnvQueryGenerator_BlueprintBase : ObjectBase<UEnvQueryGenerator_BlueprintBase>
{

    public UObject* GetQuerier()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetQuerier"),  @params);
    }
    public void DoItemGeneration(ref TArray<FVector> ContextLocations)
    {
        Span<(string name, object value)> @params = [
            ("ContextLocations", ContextLocations)
        ];
        ProcessEvent(GetFunction("DoItemGeneration"),  @params);
    }
    public void AddGeneratedVector(FVector GeneratedVector)
    {
        Span<(string name, object value)> @params = [
            ("GeneratedVector", GeneratedVector)
        ];
        ProcessEvent(GetFunction("AddGeneratedVector"),  @params);
    }
    public void AddGeneratedActor(AActor* GeneratedActor)
    {
        Span<(string name, object value)> @params = [
            ("GeneratedActor", (IntPtr)GeneratedActor)
        ];
        ProcessEvent(GetFunction("AddGeneratedActor"),  @params);
    }
}

public unsafe class EnvQueryGenerator_Composite : ObjectBase<UEnvQueryGenerator_Composite>
{

}

public unsafe class EnvQueryGenerator_ProjectedPoints : ObjectBase<UEnvQueryGenerator_ProjectedPoints>
{

}

public unsafe class EnvQueryGenerator_Cone : ObjectBase<UEnvQueryGenerator_Cone>
{

}

public unsafe class EnvQueryGenerator_CurrentLocation : ObjectBase<UEnvQueryGenerator_CurrentLocation>
{

}

public unsafe class EnvQueryGenerator_Donut : ObjectBase<UEnvQueryGenerator_Donut>
{

}

public unsafe class EnvQueryGenerator_OnCircle : ObjectBase<UEnvQueryGenerator_OnCircle>
{

}

public unsafe class EnvQueryGenerator_SimpleGrid : ObjectBase<UEnvQueryGenerator_SimpleGrid>
{

}

public unsafe class EnvQueryGenerator_PathingGrid : ObjectBase<UEnvQueryGenerator_PathingGrid>
{

}

public unsafe class EnvQueryInstanceBlueprintWrapper : ObjectBase<UEnvQueryInstanceBlueprintWrapper>
{

    public void SetNamedParam(FName ParamName, float Value)
    {
        Span<(string name, object value)> @params = [
            ("ParamName", ParamName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetNamedParam"),  @params);
    }
    public TArray<FVector> GetResultsAsLocations()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FVector>>(GetFunction("GetResultsAsLocations"),  @params);
    }
    public TArray<IntPtr> GetResultsAsActors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetResultsAsActors"),  @params);
    }
    public bool GetQueryResultsAsLocations(ref TArray<FVector> ResultLocations)
    {
        Span<(string name, object value)> @params = [
            ("ResultLocations", ResultLocations)
        ];
        return ProcessEvent<bool>(GetFunction("GetQueryResultsAsLocations"),  @params);
    }
    public bool GetQueryResultsAsActors(ref TArray<IntPtr> ResultActors)
    {
        Span<(string name, object value)> @params = [
            ("ResultActors", ResultActors)
        ];
        return ProcessEvent<bool>(GetFunction("GetQueryResultsAsActors"),  @params);
    }
    public float GetItemScore(int ItemIndex)
    {
        Span<(string name, object value)> @params = [
            ("ItemIndex", ItemIndex)
        ];
        return ProcessEvent<float>(GetFunction("GetItemScore"),  @params);
    }
    public void EQSQueryDoneSignature__DelegateSignature(UEnvQueryInstanceBlueprintWrapper* QueryInstance, EEnvQueryStatus QueryStatus)
    {
        Span<(string name, object value)> @params = [
            ("QueryInstance", (IntPtr)QueryInstance), 
            ("QueryStatus", QueryStatus)
        ];
        ProcessEvent(GetFunction("EQSQueryDoneSignature__DelegateSignature"),  @params);
    }
}

public unsafe class EnvQueryItemType : ObjectBase<UEnvQueryItemType>
{
}

public unsafe class EnvQueryItemType_VectorBase : ObjectBase<UEnvQueryItemType_VectorBase>
{
}

public unsafe class EnvQueryItemType_ActorBase : ObjectBase<UEnvQueryItemType_ActorBase>
{
}

public unsafe class EnvQueryItemType_Actor : ObjectBase<UEnvQueryItemType_Actor>
{
}

public unsafe class EnvQueryItemType_Direction : ObjectBase<UEnvQueryItemType_Direction>
{
}

public unsafe class EnvQueryItemType_Point : ObjectBase<UEnvQueryItemType_Point>
{
}

public unsafe class EnvQueryManager : ObjectBase<UEnvQueryManager>
{

    public UEnvQueryInstanceBlueprintWrapper* RunEQSQuery(UObject* WorldContextObject, UEnvQuery* QueryTemplate, UObject* Querier, EEnvQueryRunMode RunMode, TSubclassOf<UEnvQueryInstanceBlueprintWrapper> WrapperClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("QueryTemplate", (IntPtr)QueryTemplate), 
            ("Querier", (IntPtr)Querier), 
            ("RunMode", RunMode), 
            ("WrapperClass", WrapperClass)
        ];
        return (UEnvQueryInstanceBlueprintWrapper*)ProcessEvent<IntPtr>(GetFunction("RunEQSQuery"),  @params);
    }
}

public unsafe class EnvQueryOption : ObjectBase<UEnvQueryOption>
{

}

public unsafe class EnvQueryTest : ObjectBase<UEnvQueryTest>
{

}

public unsafe class EnvQueryTest_Distance : ObjectBase<UEnvQueryTest_Distance>
{

}

public unsafe class EnvQueryTest_Dot : ObjectBase<UEnvQueryTest_Dot>
{

}

public unsafe class EnvQueryTest_GameplayTags : ObjectBase<UEnvQueryTest_GameplayTags>
{

}

public unsafe class EnvQueryTest_Overlap : ObjectBase<UEnvQueryTest_Overlap>
{

}

public unsafe class EnvQueryTest_Pathfinding : ObjectBase<UEnvQueryTest_Pathfinding>
{

}

public unsafe class EnvQueryTest_PathfindingBatch : ObjectBase<UEnvQueryTest_PathfindingBatch>
{

}

public unsafe class EnvQueryTest_Project : ObjectBase<UEnvQueryTest_Project>
{

}

public unsafe class EnvQueryTest_Random : ObjectBase<UEnvQueryTest_Random>
{
}

public unsafe class EnvQueryTest_Trace : ObjectBase<UEnvQueryTest_Trace>
{

}

public unsafe class EnvQueryTest_Volume : ObjectBase<UEnvQueryTest_Volume>
{

}

public unsafe class EnvQueryTypes : ObjectBase<UEnvQueryTypes>
{
}

public unsafe class EQSQueryResultSourceInterface : ObjectBase<IEQSQueryResultSourceInterface>
{
}

public unsafe class EQSRenderingComponent : ObjectBase<UEQSRenderingComponent>
{
}

public unsafe class EQSTestingPawn : ObjectBase<AEQSTestingPawn>
{

}

public unsafe class GenericTeamAgentInterface : ObjectBase<IGenericTeamAgentInterface>
{
}

public unsafe class GridPathAIController : ObjectBase<AGridPathAIController>
{
}

public unsafe class GridPathFollowingComponent : ObjectBase<UGridPathFollowingComponent>
{

}

public unsafe class NavFilter_AIControllerDefault : ObjectBase<UNavFilter_AIControllerDefault>
{
}

public unsafe class NavLinkProxy : ObjectBase<ANavLinkProxy>
{

    public void SetSmartLinkEnabled(bool bEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bEnabled", bEnabled)
        ];
        ProcessEvent(GetFunction("SetSmartLinkEnabled"),  @params);
    }
    public void ResumePathFollowing(AActor* Agent)
    {
        Span<(string name, object value)> @params = [
            ("Agent", (IntPtr)Agent)
        ];
        ProcessEvent(GetFunction("ResumePathFollowing"),  @params);
    }
    public void ReceiveSmartLinkReached(AActor* Agent, ref FVector Destination)
    {
        Span<(string name, object value)> @params = [
            ("Agent", (IntPtr)Agent), 
            ("Destination", Destination)
        ];
        ProcessEvent(GetFunction("ReceiveSmartLinkReached"),  @params);
    }
    public bool IsSmartLinkEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSmartLinkEnabled"),  @params);
    }
    public bool HasMovingAgents()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasMovingAgents"),  @params);
    }
}

public unsafe class NavLocalGridManager : ObjectBase<UNavLocalGridManager>
{

    public bool SetLocalNavigationGridDensity(UObject* WorldContextObject, float CellSize)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CellSize", CellSize)
        ];
        return ProcessEvent<bool>(GetFunction("SetLocalNavigationGridDensity"),  @params);
    }
    public void RemoveLocalNavigationGrid(UObject* WorldContextObject, int GridId, bool bRebuildGrids)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("GridId", GridId), 
            ("bRebuildGrids", bRebuildGrids)
        ];
        ProcessEvent(GetFunction("RemoveLocalNavigationGrid"),  @params);
    }
    public bool FindLocalNavigationGridPath(UObject* WorldContextObject, ref FVector Start, ref FVector End, ref TArray<FVector> PathPoints)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Start", Start), 
            ("End", End), 
            ("PathPoints", PathPoints)
        ];
        return ProcessEvent<bool>(GetFunction("FindLocalNavigationGridPath"),  @params);
    }
    public int AddLocalNavigationGridForPoints(UObject* WorldContextObject, ref TArray<FVector> Locations, int Radius2D, float Height, bool bRebuildGrids)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Locations", Locations), 
            ("Radius2D", Radius2D), 
            ("Height", Height), 
            ("bRebuildGrids", bRebuildGrids)
        ];
        return ProcessEvent<int>(GetFunction("AddLocalNavigationGridForPoints"),  @params);
    }
    public int AddLocalNavigationGridForPoint(UObject* WorldContextObject, ref FVector Location, int Radius2D, float Height, bool bRebuildGrids)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Location", Location), 
            ("Radius2D", Radius2D), 
            ("Height", Height), 
            ("bRebuildGrids", bRebuildGrids)
        ];
        return ProcessEvent<int>(GetFunction("AddLocalNavigationGridForPoint"),  @params);
    }
    public int AddLocalNavigationGridForCapsule(UObject* WorldContextObject, ref FVector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D, float Height, bool bRebuildGrids)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Location", Location), 
            ("CapsuleRadius", CapsuleRadius), 
            ("CapsuleHalfHeight", CapsuleHalfHeight), 
            ("Radius2D", Radius2D), 
            ("Height", Height), 
            ("bRebuildGrids", bRebuildGrids)
        ];
        return ProcessEvent<int>(GetFunction("AddLocalNavigationGridForCapsule"),  @params);
    }
    public int AddLocalNavigationGridForBox(UObject* WorldContextObject, ref FVector Location, FVector Extent, FRotator Rotation, int Radius2D, float Height, bool bRebuildGrids)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Location", Location), 
            ("Extent", Extent), 
            ("Rotation", Rotation), 
            ("Radius2D", Radius2D), 
            ("Height", Height), 
            ("bRebuildGrids", bRebuildGrids)
        ];
        return ProcessEvent<int>(GetFunction("AddLocalNavigationGridForBox"),  @params);
    }
}

public unsafe class PathFollowingManager : ObjectBase<UPathFollowingManager>
{
}

public unsafe class PawnAction : ObjectBase<UPawnAction>
{

    public EAIRequestPriority GetActionPriority()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAIRequestPriority>(GetFunction("GetActionPriority"),  @params);
    }
    public void Finish(EPawnActionResult WithResult)
    {
        Span<(string name, object value)> @params = [
            ("WithResult", WithResult)
        ];
        ProcessEvent(GetFunction("Finish"),  @params);
    }
    public UPawnAction* CreateActionInstance(UObject* WorldContextObject, TSubclassOf<UPawnAction> ActionClass)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ActionClass", ActionClass)
        ];
        return (UPawnAction*)ProcessEvent<IntPtr>(GetFunction("CreateActionInstance"),  @params);
    }
}

public unsafe class PawnAction_BlueprintBase : ObjectBase<UPawnAction_BlueprintBase>
{

    public void ActionTick(APawn* ControlledPawn, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("ActionTick"),  @params);
    }
    public void ActionStart(APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ActionStart"),  @params);
    }
    public void ActionResume(APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ActionResume"),  @params);
    }
    public void ActionPause(APawn* ControlledPawn)
    {
        Span<(string name, object value)> @params = [
            ("ControlledPawn", (IntPtr)ControlledPawn)
        ];
        ProcessEvent(GetFunction("ActionPause"),  @params);
    }
    public void ActionFinished(APawn* ControlledPawn, EPawnActionResult WithResult)
    {
        Span<(string name, object value)> @params = [
            ("ControlledPawn", (IntPtr)ControlledPawn), 
            ("WithResult", WithResult)
        ];
        ProcessEvent(GetFunction("ActionFinished"),  @params);
    }
}

public unsafe class PawnAction_Move : ObjectBase<UPawnAction_Move>
{

}

public unsafe class PawnAction_Repeat : ObjectBase<UPawnAction_Repeat>
{

}

public unsafe class PawnAction_Sequence : ObjectBase<UPawnAction_Sequence>
{

}

public unsafe class PawnAction_Wait : ObjectBase<UPawnAction_Wait>
{

}

public unsafe class PawnActionsComponent : ObjectBase<UPawnActionsComponent>
{

    public bool K2_PushAction(UPawnAction* NewAction, EAIRequestPriority Priority, UObject* Instigator)
    {
        Span<(string name, object value)> @params = [
            ("NewAction", (IntPtr)NewAction), 
            ("Priority", Priority), 
            ("Instigator", (IntPtr)Instigator)
        ];
        return ProcessEvent<bool>(GetFunction("K2_PushAction"),  @params);
    }
    public bool K2_PerformAction(APawn* Pawn, UPawnAction* Action, EAIRequestPriority Priority)
    {
        Span<(string name, object value)> @params = [
            ("Pawn", (IntPtr)Pawn), 
            ("Action", (IntPtr)Action), 
            ("Priority", Priority)
        ];
        return ProcessEvent<bool>(GetFunction("K2_PerformAction"),  @params);
    }
    public EPawnActionAbortState K2_ForceAbortAction(UPawnAction* ActionToAbort)
    {
        Span<(string name, object value)> @params = [
            ("ActionToAbort", (IntPtr)ActionToAbort)
        ];
        return ProcessEvent<EPawnActionAbortState>(GetFunction("K2_ForceAbortAction"),  @params);
    }
    public EPawnActionAbortState K2_AbortAction(UPawnAction* ActionToAbort)
    {
        Span<(string name, object value)> @params = [
            ("ActionToAbort", (IntPtr)ActionToAbort)
        ];
        return ProcessEvent<EPawnActionAbortState>(GetFunction("K2_AbortAction"),  @params);
    }
}

public unsafe class PawnSensingComponent : ObjectBase<UPawnSensingComponent>
{

    public void SetSensingUpdatesEnabled(bool bEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bEnabled", bEnabled)
        ];
        ProcessEvent(GetFunction("SetSensingUpdatesEnabled"),  @params);
    }
    public void SetSensingInterval(float NewSensingInterval)
    {
        Span<(string name, object value)> @params = [
            ("NewSensingInterval", NewSensingInterval)
        ];
        ProcessEvent(GetFunction("SetSensingInterval"),  @params);
    }
    public void SetPeripheralVisionAngle(float NewPeripheralVisionAngle)
    {
        Span<(string name, object value)> @params = [
            ("NewPeripheralVisionAngle", NewPeripheralVisionAngle)
        ];
        ProcessEvent(GetFunction("SetPeripheralVisionAngle"),  @params);
    }
    public void SeePawnDelegate__DelegateSignature(APawn* Pawn)
    {
        Span<(string name, object value)> @params = [
            ("Pawn", (IntPtr)Pawn)
        ];
        ProcessEvent(GetFunction("SeePawnDelegate__DelegateSignature"),  @params);
    }
    public void HearNoiseDelegate__DelegateSignature(APawn* Instigator, ref FVector Location, float Volume)
    {
        Span<(string name, object value)> @params = [
            ("Instigator", (IntPtr)Instigator), 
            ("Location", Location), 
            ("Volume", Volume)
        ];
        ProcessEvent(GetFunction("HearNoiseDelegate__DelegateSignature"),  @params);
    }
    public float GetPeripheralVisionCosine()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPeripheralVisionCosine"),  @params);
    }
    public float GetPeripheralVisionAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPeripheralVisionAngle"),  @params);
    }
}

public unsafe class VisualLoggerExtension : ObjectBase<UVisualLoggerExtension>
{
}

public unsafe class ActorPerceptionUpdateInfo : ObjectBase<FActorPerceptionUpdateInfo>
{

}

public unsafe class AIDataProviderValue : ObjectBase<FAIDataProviderValue>
{

}

public unsafe class AIDataProviderTypedValue : ObjectBase<FAIDataProviderTypedValue>
{

}

public unsafe class AIDataProviderBoolValue : ObjectBase<FAIDataProviderBoolValue>
{

}

public unsafe class AIDataProviderFloatValue : ObjectBase<FAIDataProviderFloatValue>
{

}

public unsafe class AIDataProviderIntValue : ObjectBase<FAIDataProviderIntValue>
{

}

public unsafe class AIDataProviderStructValue : ObjectBase<FAIDataProviderStructValue>
{
}

public unsafe class AISenseAffiliationFilter : ObjectBase<FAISenseAffiliationFilter>
{

}

public unsafe class AIDamageEvent : ObjectBase<FAIDamageEvent>
{

}

public unsafe class AINoiseEvent : ObjectBase<FAINoiseEvent>
{

}

public unsafe class AIPredictionEvent : ObjectBase<FAIPredictionEvent>
{

}

public unsafe class AISightEvent : ObjectBase<FAISightEvent>
{

}

public unsafe class AITeamStimulusEvent : ObjectBase<FAITeamStimulusEvent>
{

}

public unsafe class AITouchEvent : ObjectBase<FAITouchEvent>
{

}

public unsafe class IntervalCountdown : ObjectBase<FIntervalCountdown>
{

}

public unsafe class AIMoveRequest : ObjectBase<FAIMoveRequest>
{

}

public unsafe class BehaviorTreeTemplateInfo : ObjectBase<FBehaviorTreeTemplateInfo>
{

}

public unsafe class BlackboardEntry : ObjectBase<FBlackboardEntry>
{

}

public unsafe class BTCompositeChild : ObjectBase<FBTCompositeChild>
{

}

public unsafe class BTDecoratorLogic : ObjectBase<FBTDecoratorLogic>
{

}

public unsafe class CrowdAvoidanceSamplingPattern : ObjectBase<FCrowdAvoidanceSamplingPattern>
{

}

public unsafe class CrowdAvoidanceConfig : ObjectBase<FCrowdAvoidanceConfig>
{

}

public unsafe class EnvQueryInstanceCache : ObjectBase<FEnvQueryInstanceCache>
{

}

public unsafe class EnvQueryRequest : ObjectBase<FEnvQueryRequest>
{

}

public unsafe class EQSParametrizedQueryExecutionRequest : ObjectBase<FEQSParametrizedQueryExecutionRequest>
{

}

public unsafe class AIDynamicParam : ObjectBase<FAIDynamicParam>
{

}

public unsafe class EnvQueryResult : ObjectBase<FEnvQueryResult>
{

}

public unsafe class EnvOverlapData : ObjectBase<FEnvOverlapData>
{

}

public unsafe class EnvTraceData : ObjectBase<FEnvTraceData>
{

}

public unsafe class EnvDirection : ObjectBase<FEnvDirection>
{

}

public unsafe class EnvNamedValue : ObjectBase<FEnvNamedValue>
{

}

public unsafe class GenericTeamId : ObjectBase<FGenericTeamId>
{

}

public unsafe class PawnActionStack : ObjectBase<FPawnActionStack>
{

}

public unsafe class PawnActionEvent : ObjectBase<FPawnActionEvent>
{

}

public unsafe class RecastGraphWrapper : ObjectBase<FRecastGraphWrapper>
{

}

public unsafe class Default__AISenseBlueprintListener : ObjectBase<FDefault__AISenseBlueprintListener>
{
}

