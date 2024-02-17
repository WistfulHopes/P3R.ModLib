using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class CharacterBaseBpLib : ObjectBase<UCharacterBaseBpLib>
{
    public CharacterBaseBpLib(IntPtr pointer) : base(pointer) {}
    public FString GetSoftClassPath(UObject* WorldContextObject, TSoftObjectPtr<UAnimBlueprint> AnimBP)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("AnimBP", AnimBP)
        ];
        return ProcessEvent<FString>(GetFunction("GetSoftClassPath"), @params);
    }
}

public unsafe class AnimInstanceCore : ObjectBase<UAnimInstanceCore>
{
    public AnimInstanceCore(IntPtr pointer) : base(pointer) {}
    public void SetOverrideLocomotionNotMoveAnim(UAnimSequence* InAnimSeq)
    {
        Span<(string name, object value)> @params = [
            ("InAnimSeq", (IntPtr)InAnimSeq)
        ];
        ProcessEvent(GetFunction("SetOverrideLocomotionNotMoveAnim"), @params);
    }
    public void SetLookAtWorldLocation(FVector Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetLookAtWorldLocation"), @params);
    }
    public void SetLookAtType(byte LookAtType)
    {
        Span<(string name, object value)> @params = [
            ("LookAtType", LookAtType)
        ];
        ProcessEvent(GetFunction("SetLookAtType"), @params);
    }
    public void SetLookAtTargetActorBoneName(FString BoneName)
    {
        Span<(string name, object value)> @params = [
            ("BoneName", BoneName)
        ];
        ProcessEvent(GetFunction("SetLookAtTargetActorBoneName"), @params);
    }
    public void SetLookAtTargetActor(AActor* TargetActor)
    {
        Span<(string name, object value)> @params = [
            ("TargetActor", (IntPtr)TargetActor)
        ];
        ProcessEvent(GetFunction("SetLookAtTargetActor"), @params);
    }
    public bool IsPlaySlotAnimation(FName InAnimSlotName)
    {
        Span<(string name, object value)> @params = [
            ("InAnimSlotName", InAnimSlotName)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaySlotAnimation"), @params);
    }
    public FVector GetLookAtWorldLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetLookAtWorldLocation"), @params);
    }
    public byte GetLookAtType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<byte>(GetFunction("GetLookAtType"), @params);
    }
    public FString GetLookAtTargetActorBoneName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetLookAtTargetActorBoneName"), @params);
    }
    public AActor* GetLookAtTargetActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetLookAtTargetActor"), @params);
    }
}

public unsafe class CB_HumanMeshPackAsset : ObjectBase<UCB_HumanMeshPackAsset>
{
    public CB_HumanMeshPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CB_HumanAnimPackAsset : ObjectBase<UCB_HumanAnimPackAsset>
{
    public CB_HumanAnimPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CB_PersonaMeshPackAsset : ObjectBase<UCB_PersonaMeshPackAsset>
{
    public CB_PersonaMeshPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CB_PersonaAnimPackAsset : ObjectBase<UCB_PersonaAnimPackAsset>
{
    public CB_PersonaAnimPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CB_NpcMeshPackAsset : ObjectBase<UCB_NpcMeshPackAsset>
{
    public CB_NpcMeshPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CB_NpcAnimPackAsset : ObjectBase<UCB_NpcAnimPackAsset>
{
    public CB_NpcAnimPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CharacterBaseCore : ObjectBase<ACharacterBaseCore>
{
    public CharacterBaseCore(IntPtr pointer) : base(pointer) {}
    public void ReCalculateBounds()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReCalculateBounds"), @params);
    }
    public void LoadEndEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadEndEvent"), @params);
    }
    public FName GetMontageSectionName(UAnimMontage* Montage, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("Index", Index)
        ];
        return ProcessEvent<FName>(GetFunction("GetMontageSectionName"), @params);
    }
    public float GetLastRenderTimeOnScreen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLastRenderTimeOnScreen"), @params);
    }
    public float GetCompLastRenderTimeOnScreen(UPrimitiveComponent* MeshComp)
    {
        Span<(string name, object value)> @params = [
            ("MeshComp", (IntPtr)MeshComp)
        ];
        return ProcessEvent<float>(GetFunction("GetCompLastRenderTimeOnScreen"), @params);
    }
}

public unsafe class CBL_LoaderBase : ObjectBase<UCBL_LoaderBase>
{
    public CBL_LoaderBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class CBL_LoaderTexture : ObjectBase<UCBL_LoaderTexture>
{
    public CBL_LoaderTexture(IntPtr pointer) : base(pointer) {}
}

public unsafe class CrowdNpcBaseCore : ObjectBase<ACrowdNpcBaseCore>
{
    public CrowdNpcBaseCore(IntPtr pointer) : base(pointer) {}}

public unsafe class EnemySymbolBaseCore : ObjectBase<AEnemySymbolBaseCore>
{
    public EnemySymbolBaseCore(IntPtr pointer) : base(pointer) {}}

public unsafe class MobBaseAiControllerCore : ObjectBase<AMobBaseAiControllerCore>
{
    public MobBaseAiControllerCore(IntPtr pointer) : base(pointer) {}
    public void UpdateProc(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateProc"), @params);
    }
    public void UpdateActorBlueprint(float WalkSpeedRatio, float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("WalkSpeedRatio", WalkSpeedRatio), 
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateActorBlueprint"), @params);
    }
    public void StartAiCtrl()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAiCtrl"), @params);
    }
    public void SetPointIndex(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetPointIndex"), @params);
    }
    public void ReStartAiCtrl()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReStartAiCtrl"), @params);
    }
    public FMobWalkRoutePoint GetRoutePointNOW()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMobWalkRoutePoint>(GetFunction("GetRoutePointNOW"), @params);
    }
    public FMobWalkRoutePoint GetRoutePointNEXT()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMobWalkRoutePoint>(GetFunction("GetRoutePointNEXT"), @params);
    }
    public int GetPointIndexLAST()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPointIndexLAST"), @params);
    }
    public int GetPointIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPointIndex"), @params);
    }
    public AMobWalkCharaBaseCore* GetOwnerActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AMobWalkCharaBaseCore*)ProcessEvent<IntPtr>(GetFunction("GetOwnerActor"), @params);
    }
    public void AddPointIndex(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("AddPointIndex"), @params);
    }
}

public unsafe class MobCharaBaseListener : ObjectBase<IMobCharaBaseListener>
{
    public MobCharaBaseListener(IntPtr pointer) : base(pointer) {}
    public void UpdateMobChara(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateMobChara"), @params);
    }
}

public unsafe class MobWalkTarget : ObjectBase<AMobWalkTarget>
{
    public MobWalkTarget(IntPtr pointer) : base(pointer) {}
    public EMobWalkTargetType GetTargetType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMobWalkTargetType>(GetFunction("GetTargetType"), @params);
    }
}

public unsafe class MobWalkCharaBaseCore : ObjectBase<AMobWalkCharaBaseCore>
{
    public MobWalkCharaBaseCore(IntPtr pointer) : base(pointer) {}
    public void SetWaitTime(float InTime)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime)
        ];
        ProcessEvent(GetFunction("SetWaitTime"), @params);
    }
    public void SetStartLocation(FVector InLocation)
    {
        Span<(string name, object value)> @params = [
            ("InLocation", InLocation)
        ];
        ProcessEvent(GetFunction("SetStartLocation"), @params);
    }
    public void SetPointIndex(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetPointIndex"), @params);
    }
    public void SetOpacityCore(float Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetOpacityCore"), @params);
    }
    public void SetFollowRelativeLocation(FVector InLocation)
    {
        Span<(string name, object value)> @params = [
            ("InLocation", InLocation)
        ];
        ProcessEvent(GetFunction("SetFollowRelativeLocation"), @params);
    }
    public void SetFollowParent(AActor* InParent)
    {
        Span<(string name, object value)> @params = [
            ("InParent", (IntPtr)InParent)
        ];
        ProcessEvent(GetFunction("SetFollowParent"), @params);
    }
    public void SetBpIndex(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetBpIndex"), @params);
    }
    public void InitPointList()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitPointList"), @params);
    }
    public float GetWaitTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetWaitTime"), @params);
    }
    public FVector GetStartLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetStartLocation"), @params);
    }
    public int GetPointListMax()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPointListMax"), @params);
    }
    public FMobWalkRoutePoint GetPointList_START()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMobWalkRoutePoint>(GetFunction("GetPointList_START"), @params);
    }
    public FMobWalkRoutePoint GetPointList_LAST()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMobWalkRoutePoint>(GetFunction("GetPointList_LAST"), @params);
    }
    public FMobWalkRoutePoint GetPointList(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<FMobWalkRoutePoint>(GetFunction("GetPointList"), @params);
    }
    public int GetPointIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPointIndex"), @params);
    }
    public float GetOpacityCore()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetOpacityCore"), @params);
    }
    public FVector GetFollowRelativeLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetFollowRelativeLocation"), @params);
    }
    public AActor* GetFollowParent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetFollowParent"), @params);
    }
    public int GetBpIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetBpIndex"), @params);
    }
    public void AddPointList(FMobWalkRoutePoint InPoint)
    {
        Span<(string name, object value)> @params = [
            ("InPoint", InPoint)
        ];
        ProcessEvent(GetFunction("AddPointList"), @params);
    }
}

public unsafe class NpcAnimationBaseCore : ObjectBase<UNpcAnimationBaseCore>
{
    public NpcAnimationBaseCore(IntPtr pointer) : base(pointer) {}
    public void SetLookAtWorldLocation(FVector Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetLookAtWorldLocation"), @params);
    }
    public void SetLookAtType(ENpcAnimLookAtType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetLookAtType"), @params);
    }
    public void SetLookAtTargetActorBoneName(FString BoneName)
    {
        Span<(string name, object value)> @params = [
            ("BoneName", BoneName)
        ];
        ProcessEvent(GetFunction("SetLookAtTargetActorBoneName"), @params);
    }
    public void SetLookAtTargetActor(AActor* TargetActor)
    {
        Span<(string name, object value)> @params = [
            ("TargetActor", (IntPtr)TargetActor)
        ];
        ProcessEvent(GetFunction("SetLookAtTargetActor"), @params);
    }
    public void SetIdolAnimSequnece(UAnimSequenceBase* Anim)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim)
        ];
        ProcessEvent(GetFunction("SetIdolAnimSequnece"), @params);
    }
    public FVector GetLookAtWorldLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetLookAtWorldLocation"), @params);
    }
    public ENpcAnimLookAtType GetLookAtType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ENpcAnimLookAtType>(GetFunction("GetLookAtType"), @params);
    }
    public FString GetLookAtTargetActorBoneName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetLookAtTargetActorBoneName"), @params);
    }
    public AActor* GetLookAtTargetActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetLookAtTargetActor"), @params);
    }
    public UAnimSequenceBase* GetIdolAnimSequnece()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAnimSequenceBase*)ProcessEvent<IntPtr>(GetFunction("GetIdolAnimSequnece"), @params);
    }
}

public unsafe class NpcBaseCore : ObjectBase<ANpcBaseCore>
{
    public NpcBaseCore(IntPtr pointer) : base(pointer) {}
    public FName GetMontageSectionName(UAnimMontage* Montage, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("Index", Index)
        ];
        return ProcessEvent<FName>(GetFunction("GetMontageSectionName"), @params);
    }
    public USkeletalMeshComponent* GetMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetMesh"), @params);
    }
    public void CommitModelSetting()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CommitModelSetting"), @params);
    }
}

public unsafe class PersonaBaseCore : ObjectBase<APersonaBaseCore>
{
    public PersonaBaseCore(IntPtr pointer) : base(pointer) {}
}

public unsafe class ShadowBaseCore : ObjectBase<AShadowBaseCore>
{
    public ShadowBaseCore(IntPtr pointer) : base(pointer) {}
}

