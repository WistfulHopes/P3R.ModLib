using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAppDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FActivityTaskData
{
    [FieldOffset(0x0000)] public FName EndFlag;
    [FieldOffset(0x0008)] public int EndFloorNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FActivityData
{
    [FieldOffset(0x0000)] public byte StartMonth;
    [FieldOffset(0x0001)] public byte StartDay;
    [FieldOffset(0x0002)] public ushort MinFloorNo;
    [FieldOffset(0x0004)] public ushort MaxFloorNo;
    [FieldOffset(0x0008)] public FName StartFlag;
    [FieldOffset(0x0010)] public FName EndFlag;
    [FieldOffset(0x0018)] public TArray<FActivityTaskData> TaskIds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UActivityDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FActivityData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AAppActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public EAppPauseObjectFlag AppPauseFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AActivityTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAddContent
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public ADLCManager* mDlcManager;
    [FieldOffset(0x0040)] public AAddContentDialog* mAdcDialog;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E8)] 
public unsafe struct AAddContentDialog
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x03D8)] public ADLCManager* mDlcManager;
    [FieldOffset(0x03E0)] public AUIProgressBarDraw* mProgressBar;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAddContentEntitlement
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public bool Enabled;
    [FieldOffset(0x0009)] public EAddContentEntitlementCategory Categories;
    [FieldOffset(0x0010)] public int Items;
    [FieldOffset(0x0028)] public FString PsEntitlementLabel;
    [FieldOffset(0x0038)] public FString MsStoreId;
    [FieldOffset(0x0048)] public uint SteamAppId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAddContentEntitlementDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAddContentEntitlement> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBaseCurveAnimation
{
    [FieldOffset(0x0018)] public UAssetLoader* m_pAssetLoader;
    [FieldOffset(0x0020)] public UCurveBase* m_pCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCurveVectorAnimation
{
    [FieldOffset(0x0000)] public FBaseCurveAnimation baseObj;
    [FieldOffset(0x0028)] public UCurveVector* m_pCurveVector;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UAgePanel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public USprAsset* _readSpr;
    [FieldOffset(0x0040)] public UMaterial* _readMat;
    [FieldOffset(0x0050)] public UMaterialInstanceDynamic* _readMatInst;
    [FieldOffset(0x0060)] public FCurveVectorAnimation _fadeCurve;
    [FieldOffset(0x02E8)] public UAssetLoader* Loader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAnimController
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FName> mAnimNameArray;
    [FieldOffset(0x0038)] public TArray<IntPtr> mSkMeshCompArray;
    [FieldOffset(0x0048)] public TArray<IntPtr> mMontageArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAnimNotify_BtlPlayMontageNotify
{
    [FieldOffset(0x0000)] public UAnimNotify_PlayMontageNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtlSlotMultiAnimationParam
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* Animation;
    [FieldOffset(0x0008)] public float StartOffset;
    [FieldOffset(0x000C)] public float EndOffset;
    [FieldOffset(0x0010)] public float BlendIn;
    [FieldOffset(0x0014)] public float BlendOut;
    [FieldOffset(0x0018)] public float PlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAnimNotify_PlayEvtMultiMontage
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public TArray<FAtlSlotMultiAnimationParam> MontageArray;
    [FieldOffset(0x0048)] public FName SlotNodeName;
    [FieldOffset(0x0050)] public EEvtCharaAnimationType AnimationType;
    [FieldOffset(0x0051)] public bool bStop;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UAppActivity
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0048)] public UAssetLoader* Loader_;
    [FieldOffset(0x0050)] public UActivityDataAsset* DataAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UAppActorComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00C0)] public EAppPauseObjectFlag AppPauseFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAppAnimSequence
{
    [FieldOffset(0x0000)] public UAnimSequence* pAnimSequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UAppAnimCtrl
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TSubclassOf<ACharacter> pCharacterClass;
    [FieldOffset(0x0038)] public ACharacter* pCharacter;
    [FieldOffset(0x0040)] public USkeletalMesh* pSkeletalMesh;
    [FieldOffset(0x0048)] public ASkeletalMeshActor* pSkelMeshAct;
    [FieldOffset(0x0050)] public USkeletalMeshComponent* pSkMeshCompo;
    [FieldOffset(0x0058)] public TArray<FAppAnimSequence> animSeqAry;
    [FieldOffset(0x0068)] public TArray<IntPtr> mMontageAry;
    [FieldOffset(0x0078)] public TArray<float> mSeqLengthAry;
    [FieldOffset(0x0090)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAppCharTransparency
{
    [FieldOffset(0x0000)] public float Opacity;
    [FieldOffset(0x0004)] public float MaxOpacity;
    [FieldOffset(0x0008)] public bool bLarge;
}

[StructLayout(LayoutKind.Explicit, Size = 0x300)] 
public unsafe struct UAppCharBaseComp
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00E0)] public AActor* mMotionAttached_;
    [FieldOffset(0x00E8)] public FName mMotionAttachedSocketName_;
    [FieldOffset(0x00F0)] public FTransform mMotionAttachedTransform;
    [FieldOffset(0x0120)] public bool mMotionDetachPrepared_;
    [FieldOffset(0x0121)] public bool bMotionDetachPreparedTransKeep_;
    [FieldOffset(0x0122)] public bool bMotionDetachPreparedRelativeTrans_;
    [FieldOffset(0x0124)] public FRotator mMotionDetachPreparedRelativeRotator_;
    [FieldOffset(0x0130)] public FVector mMotionDetachPreparedRelativeLocation_;
    [FieldOffset(0x0150)] public int mFadeType_;
    [FieldOffset(0x0154)] public int mFadeFrame_;
    [FieldOffset(0x0158)] public int mFadePattern_;
    [FieldOffset(0x0190)] public bool mDelayPauseAnimReq_;
    [FieldOffset(0x0191)] public bool mDelayPauseAnimFlag_;
    [FieldOffset(0x0194)] public float mDelayPauseAnimSpeedRate_;
    [FieldOffset(0x0198)] public TSoftClassPtr<AAppPropsCore> mBagClassPtr_;
    [FieldOffset(0x01C0)] public FName mBagAttachSocketName;
    [FieldOffset(0x01C8)] public FName mBagAnimSlotName_;
    [FieldOffset(0x01D0)] public TMap<EAppCharBagAnimType, IntPtr> mBagAnims_;
    [FieldOffset(0x0220)] public AAppPropsCore* mBagActor_;
    [FieldOffset(0x0228)] public bool bIsLockedLookAt_;
    [FieldOffset(0x0229)] public byte mLockedLookAtType_;
    [FieldOffset(0x022C)] public float mLockedLookAtSpeed_;
    [FieldOffset(0x0230)] public USkeletalMeshComponent* CostumeMesh;
    [FieldOffset(0x0238)] public USkeletalMeshComponent* HairMesh;
    [FieldOffset(0x0240)] public USkeletalMeshComponent* FaceMesh;
    [FieldOffset(0x0248)] public UAppCharFootstepsAtom* FootstepsAtom;
    [FieldOffset(0x0250)] public UAnimMontage* AnimMontage_DefaultSlot;
    [FieldOffset(0x0258)] public UAnimMontage* AnimMontage_FacialSlot;
    [FieldOffset(0x0260)] public UAnimMontage* AnimMontage_NeckSlot;
    [FieldOffset(0x0268)] public UAnimMontage* AnimMontage_TurnSlot;
    [FieldOffset(0x0278)] public UAnimMontage* AnimMontage_HavBagSlot;
    [FieldOffset(0x0280)] public EAppCharCategoryType CategoryID;
    [FieldOffset(0x0284)] public int IndexID;
    [FieldOffset(0x0288)] public int CostumeID;
    [FieldOffset(0x028C)] public EAnimPackID AnimPackID;
    [FieldOffset(0x0290)] public UAppCharAnimDataAsset* AnimPack;
    [FieldOffset(0x0298)] public UAppCharFaceAnimDataAsset* FaceAnimPack;
    [FieldOffset(0x02A0)] public EAppCharWeaponType WeaponType;
    [FieldOffset(0x02A4)] public int WeaponId;
    [FieldOffset(0x02A8)] public TArray<IntPtr> Weapons;
    [FieldOffset(0x02B8)] public bool bBagEnable;
    [FieldOffset(0x02BC)] public int ShoesID;
    [FieldOffset(0x02C0)] public EAppCharState State;
    [FieldOffset(0x02C4)] public FVector MoveLocation;
    [FieldOffset(0x02D0)] public float MoveSpeed;
    [FieldOffset(0x02D4)] public bool bTransparencyEnable;
    [FieldOffset(0x02D8)] public FAppCharTransparency Transparency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UAppCharacterComp
{
    [FieldOffset(0x0000)] public UAppCharBaseComp baseObj;
    [FieldOffset(0x02F8)] public float mBagMotionBlendTime_StandToRun_;
    [FieldOffset(0x02FC)] public float mBagMotionBlendTime_RunToStand_;
    [FieldOffset(0x0300)] public bool bIsBagSetting_;
    [FieldOffset(0x0301)] public bool bIsBagRun_;
    [FieldOffset(0x0304)] public int mBagKeyID_;
    [FieldOffset(0x0308)] public int mOverwirteBagKeyID_;
    [FieldOffset(0x030C)] public bool bIsBagInvalidIK_;
    [FieldOffset(0x0310)] public ACharacterBaseCore* Character;
    [FieldOffset(0x0318)] public bool bNeedInitialize;
    [FieldOffset(0x0320)] public UAppCharLoader* Loader;
    [FieldOffset(0x0328)] public TArray<IntPtr> EffectWeapons;
    [FieldOffset(0x0338)] public TArray<int> HideMaterialIDs;
    [FieldOffset(0x0358)] public int mSetCostumeID;
    [FieldOffset(0x035C)] public int mSetWeaponType;
    [FieldOffset(0x0360)] public int mSetWeaponModelID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAppCharacterPoolManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAppCharLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAppCharAnimAttachNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public FName mSocketName_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAppCharAnimDetachNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public bool bDetachTrans_;
    [FieldOffset(0x0040)] public FTransform mRelativeTrans_;
    [FieldOffset(0x0070)] public bool bRelativeTrans_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAppCharAnimDetachPrepareNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public bool bDetachTrans_;
    [FieldOffset(0x0040)] public FTransform mRelativeTrans_;
    [FieldOffset(0x0070)] public bool bRelativeTrans_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAppCharAttachedPropsAnimNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public int mAnimePackIndex_;
    [FieldOffset(0x003C)] public int mPlayType_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UAppCharAnimDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public EAnimPackID PackId;
    [FieldOffset(0x0031)] public EAppCharCategoryType Category;
    [FieldOffset(0x0034)] public int CharId;
    [FieldOffset(0x0038)] public UClass* AnimInstance;
    [FieldOffset(0x0040)] public TMap<int, IntPtr> SpecialAnimInstance;
    [FieldOffset(0x0090)] public TMap<int, IntPtr> Anims;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAppCharAnimFadeNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAppCharAnimLockLookAtNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public float mInterpSpeed_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAppCharAnimUnlockLookAtNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAppCharAnimStopTimingNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public bool mLookAtFlag_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FAppNpcCostumePartsData
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USkeletalMesh> Mesh;
    [FieldOffset(0x0028)] public TSoftClassPtr<UObject> Anim;
    [FieldOffset(0x0050)] public TMap<int, TSoftObjectPtr<UTexture2D>> Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct FAppNpcUniqueCostumeData
{
    [FieldOffset(0x0000)] public TMap<EAnimPackID, TSoftObjectPtr<UAppCharAnimDataAsset>> Anims;
    [FieldOffset(0x0050)] public FAppNpcCostumePartsData Costume;
    [FieldOffset(0x00F0)] public FAppNpcCostumePartsData Hair;
    [FieldOffset(0x0190)] public FAppNpcCostumePartsData Face;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UAppNpcCostume_DA
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public int Type;
    [FieldOffset(0x0034)] public FVector MeshLocation;
    [FieldOffset(0x0040)] public TMap<EAnimPackID, TSoftObjectPtr<UAppCharAnimDataAsset>> Anims;
    [FieldOffset(0x0090)] public FAppNpcCostumePartsData Base;
    [FieldOffset(0x0130)] public TMap<int, FAppNpcCostumePartsData> CostumeSummer;
    [FieldOffset(0x0180)] public TMap<int, FAppNpcCostumePartsData> CostumeWinter;
    [FieldOffset(0x01D0)] public TMap<int, FAppNpcCostumePartsData> Hair;
    [FieldOffset(0x0220)] public TMap<int, FAppNpcCostumePartsData> Face;
    [FieldOffset(0x0270)] public TMap<int, FAppNpcUniqueCostumeData> Unique;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAppCharFaceAnimDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public EAppCharCategoryType Category;
    [FieldOffset(0x0034)] public int CharId;
    [FieldOffset(0x0038)] public TMap<int, IntPtr> Anims;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FUAppCharFootstepsLabel
{
    [FieldOffset(0x0000)] public FString Walk;
    [FieldOffset(0x0010)] public FString Run;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAppCharFootstepsOverwrite
{
    [FieldOffset(0x0000)] public AActor* mOverwriteActor;
    [FieldOffset(0x0008)] public FUAppCharFootstepsLabel mLable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1100)] 
public unsafe struct UAppCharFootstepsAtom
{
    [FieldOffset(0x0000)] public UAtomComponent baseObj;
    [FieldOffset(0x1098)] public FUAppCharFootstepsLabel Lable;
    [FieldOffset(0x10B8)] public FUAppCharFootstepsLabel DefaultLable;
    [FieldOffset(0x10D8)] public AActor* OverwriteActor;
    [FieldOffset(0x10E0)] public TArray<FAppCharFootstepsOverwrite> mKeepOverwrites_;
    [FieldOffset(0x10F0)] public bool bEnable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FUAppCharFootstepsMajor
{
    [FieldOffset(0x0000)] public TMap<int, FUAppCharFootstepsLabel> Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FUAppCharFootstepsCue
{
    [FieldOffset(0x0000)] public USoundAtomCue* Common;
    [FieldOffset(0x0008)] public TMap<int, IntPtr> Costume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UAppCharFootstepsDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<int, FUAppCharFootstepsMajor> Field;
    [FieldOffset(0x0080)] public TMap<int, FUAppCharFootstepsMajor> Battle;
    [FieldOffset(0x00D0)] public USoundAtomCue* CommonCue;
    [FieldOffset(0x00D8)] public USoundAtomCue* NpcCue;
    [FieldOffset(0x00E0)] public TMap<int, FUAppCharFootstepsCue> CharCue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UAppCharFootstepsTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSoftObjectPtr<UAppCharFootstepsDataAsset> Path;
    [FieldOffset(0x0050)] public UAppCharFootstepsDataAsset* Data;
    [FieldOffset(0x0058)] public bool bLoaded;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAppCharFootstepsNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public EAppCharFootstepsType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UAppCharFootstepsTriggerComp_BOX
{
    [FieldOffset(0x0000)] public UBoxComponent baseObj;
    [FieldOffset(0x0478)] public FUAppCharFootstepsLabel mLabel_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UAppCharFootstepsTriggerComp_CIRCLE
{
    [FieldOffset(0x0000)] public USphereComponent baseObj;
    [FieldOffset(0x0470)] public FUAppCharFootstepsLabel mLabel_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AAppCharFootstepsTriggerVolume
{
    [FieldOffset(0x0000)] public ATriggerVolume baseObj;
    [FieldOffset(0x0258)] public FUAppCharFootstepsLabel mLabel_;
    [FieldOffset(0x0278)] public bool mTimeNoon_;
    [FieldOffset(0x0279)] public bool mTimeAfternoon_;
    [FieldOffset(0x027A)] public bool mTimeNight_;
    [FieldOffset(0x027B)] public bool mTimeShadow_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAppCharLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAppCharLoader
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0078)] public TArray<IntPtr> Assets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct AAppCharTransparencyArea
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UCapsuleComponent* CapsuleComp;
    [FieldOffset(0x0228)] public float Opacity;
    [FieldOffset(0x022C)] public float Speed;
    [FieldOffset(0x0230)] public float Distance;
    [FieldOffset(0x0234)] public float MobDistance;
    [FieldOffset(0x0238)] public float LargeDistance;
    [FieldOffset(0x023C)] public int Priority;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAppCharWeaponAnimDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public int WaitAnimNo;
    [FieldOffset(0x0038)] public TMap<int, IntPtr> Anims;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAppCharWeaponMeshData
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USkeletalMesh> Mesh;
    [FieldOffset(0x0028)] public bool MultiEquip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAppCharWeapoAnimAssetTypeData
{
    [FieldOffset(0x0000)] public AppCharWeaponUsageEnv UsageEnv;
    [FieldOffset(0x0008)] public TSoftObjectPtr<UAppCharWeaponAnimDataAsset> Asset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FAppCharWeaponTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TMap<int, FAppCharWeaponMeshData> Data;
    [FieldOffset(0x0058)] public TSoftClassPtr<UObject> Anim;
    [FieldOffset(0x0080)] public TArray<FAppCharWeapoAnimAssetTypeData> AnimAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x448)] 
public unsafe struct AAppCharWeaponBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public int PlayerId;
    [FieldOffset(0x0280)] public USceneComponent* Root;
    [FieldOffset(0x0288)] public USkeletalMeshComponent* Mesh;
    [FieldOffset(0x0290)] public FAppCharWeaponTableRow WeaponTbl;
    [FieldOffset(0x0320)] public FName AttachSocketName;
    [FieldOffset(0x0328)] public int HideMaterialID;
    [FieldOffset(0x0330)] public UAppCharWeaponAnimDataAsset* AnimPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAppCheatManager
{
    [FieldOffset(0x0000)] public UCheatManager baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAppChunkInstall
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UAppMultiDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UAppKoromaruComp
{
    [FieldOffset(0x0000)] public UAppCharacterComp baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AAppLvMngUnloadMonitorActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public int mUniqueId_;
    [FieldOffset(0x0224)] public FName mLevelName_;
    [FieldOffset(0x0230)] public UAppLevelManager* mManager_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAppLevelData
{
    [FieldOffset(0x0000)] public EAppLevelType mType;
    [FieldOffset(0x0004)] public int mReferenceCounter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UAppLevelManager
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public TMap<FName, FAppLevelData> mLevelTable_;
    [FieldOffset(0x0080)] public TArray<IntPtr> mMonitors_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct AApplicationWindowState
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct UAppNpcComp
{
    [FieldOffset(0x0000)] public UAppCharBaseComp baseObj;
    [FieldOffset(0x02F8)] public ANpcBaseCore* mBaseCore_;
    [FieldOffset(0x0330)] public UAppCharLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAppPauseableListener
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPauseDebugItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAppPauseList
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<TScriptInterface<IAppPauseableListener>> List;
    [FieldOffset(0x0038)] public TArray<FPauseDebugItem> DebugList;
    [FieldOffset(0x0048)] public TArray<FName> WarningObjectNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAppPauseManagerSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public TArray<EAppPauseType> PauseFlow;
    [FieldOffset(0x0040)] public UAppPauseList* AppPauseables;
    [FieldOffset(0x0048)] public UAppPauseList* AppPaused;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UAppPropsAnimPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public EAppPropsAnimPackType PackType;
    [FieldOffset(0x0038)] public TMap<int, IntPtr> Anims;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAppPropsCardParam
{
    [FieldOffset(0x0000)] public EAppPropsCardType Type;
    [FieldOffset(0x0004)] public int ID;
    [FieldOffset(0x0008)] public int Rank;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IAppPropsCardInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAppPropsCardData
{
    [FieldOffset(0x0000)] public FAppPropsCardParam Param;
    [FieldOffset(0x0010)] public AAppPropsCore* Card;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AAppPropsCardContainer
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* Loader;
    [FieldOffset(0x0288)] public TArray<FAppPropsCardData> CardList;
    [FieldOffset(0x0298)] public TSubclassOf<AAppPropsCore> PersonaCardClass;
    [FieldOffset(0x02A0)] public TSubclassOf<AAppPropsCore> MajorCardClass;
    [FieldOffset(0x02A8)] public TSubclassOf<AAppPropsCore> MinorCardClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AAppPropsCore
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public FName mOnFlagName_;
    [FieldOffset(0x0280)] public FName mOffFlagName_;
    [FieldOffset(0x0288)] public USceneComponent* Root;
    [FieldOffset(0x0290)] public USkeletalMeshComponent* SkeletalMesh;
    [FieldOffset(0x0298)] public UAppPropsAnimPackAsset* mAnimePackAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UAssetHolder
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FSoftObjectPath> HoldAssets;
    [FieldOffset(0x0070)] public TArray<IntPtr> loadedAssets;
    [FieldOffset(0x0080)] public TArray<IntPtr> ChildHolders;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAssetLoader
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAssistTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* Loader_;
    [FieldOffset(0x0280)] public UBmdAsset* BmdAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAssistViewTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* Loader_;
    [FieldOffset(0x0280)] public UBmdAsset* BmdAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAtlEvtNiagaraSystemPool
{
    [FieldOffset(0x0010)] public ACharacter* AttachToCharacter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct UAtlEvtActorComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public AActor* AttachPropActor;
    [FieldOffset(0x00D0)] public EAtlEvtLocomotionTeleportVelocityType LocomotionTeleportVelocityType;
    [FieldOffset(0x00D4)] public float LocomotionTeleportDistanceThreshold;
    [FieldOffset(0x00D8)] public FVector LocomotionTeleportVelocityConstant;
    [FieldOffset(0x00E4)] public FVector2D LocomotionTeleportVelocityClampMinMax;
    [FieldOffset(0x00EC)] public int LipUniqueID;
    [FieldOffset(0x00F0)] public TWeakObjectPtr<UNiagaraComponent> HandwritingComp;
    [FieldOffset(0x00F8)] public TWeakObjectPtr<AHandwritingSpawner> HandwritingSpawner;
    [FieldOffset(0x0100)] public ACharacter* OwnerCharacter;
    [FieldOffset(0x0108)] public ANpcBaseCore* OwnerNpc;
    [FieldOffset(0x0110)] public UAppCharBaseComp* AppCharaBaseComp;
    [FieldOffset(0x0118)] public FAtlEvtNiagaraSystemPool EvtNiagaraSystemPool;
    [FieldOffset(0x0260)] public bool bUseAnimPack;
    [FieldOffset(0x0261)] public EAnimPackID OverrideAnimPackID;
    [FieldOffset(0x0262)] public bool bEnableAtlEvtLocomotionVelocitySimulation;
    [FieldOffset(0x0263)] public bool bEnableAtlEvtBag;
    [FieldOffset(0x0264)] public EAppCharShoesID ShoesID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAtlEvtAnswerActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public AAppActor* mNetAnswer_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAtlEvtHelperSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public bool bLoadSublevelsInAEvent;
    [FieldOffset(0x0039)] public bool bUseSimulateDate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AAtlEvtEventEditHelper
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public bool bLoadAllSublevels;
    [FieldOffset(0x0280)] public FString EventSublevelName;
    [FieldOffset(0x0290)] public EAtlEvtEventCategoryType EventCategoryType;
    [FieldOffset(0x0291)] public bool bFieldEventInterpFieldCamera;
    [FieldOffset(0x0292)] public ECldTimeZone PreviewTimeZone;
    [FieldOffset(0x0293)] public ECldSeason PreviewSeason;
    [FieldOffset(0x0294)] public bool bPreviewCrowd;
    [FieldOffset(0x0298)] public int PreviewCrowdMonth;
    [FieldOffset(0x029C)] public int PreviewCrowdDay;
    [FieldOffset(0x02A0)] public ECldTimeZone PreviewCrowdTimeZone;
    [FieldOffset(0x02AC)] public TWeakObjectPtr<AInitReadActor> InitReadActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAtlEvtEventManagerMovieSceneOperator
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct AAtlEvtEventManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* FieldCameraActor;
    [FieldOffset(0x0280)] public AActor* MovieSceneCameraActor;
    [FieldOffset(0x0289)] public EEventManagerEventRank EventRank;
    [FieldOffset(0x0298)] public UEventSkipWidgetDelegate* EventSkipWidget;
    [FieldOffset(0x02A0)] public TSubclassOf<UEventSkipWidgetDelegate> EventSkipWidgetClass;
    [FieldOffset(0x02AC)] public FAtlEvtEventManagerMovieSceneOperator MovieSceneOperator;
    [FieldOffset(0x02B8)] public UBmdAsset* mpBmdAsset;
    [FieldOffset(0x02C8)] public TArray<uint> MsgUniqIDList;
    [FieldOffset(0x02D8)] public int BmdAssetMsgID;
    [FieldOffset(0x02DC)] public int ExecutingMessageNo;
    [FieldOffset(0x02E5)] public EEventManagerMessageState MessageState;
    [FieldOffset(0x0300)] public AScrActor* ScrActor;
    [FieldOffset(0x0308)] public AUIBackLog* UIBackLogActor;
    [FieldOffset(0x0318)] public AUIVoiceAnswer* UINetAnswerActor;
    [FieldOffset(0x0330)] public UMovieSceneSequencePlayer* EventSequencePlayer;
    [FieldOffset(0x0340)] public int RequestedSeqClosedEventMessageID;
    [FieldOffset(0x0344)] public EEventManagerSeqControllerState SeqControllerState;
    [FieldOffset(0x0350)] public AAtlEvtEventManager_PauseActor* PauseControllerActor;
    [FieldOffset(0x0360)] public UAtlEvtMoviePlayManager* MoviePlayManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AAtlEvtEventManager_PauseActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AAtlEvtEventManager* OwnerManagerActor;
    [FieldOffset(0x0288)] public UEvtManagerStateBase* CurrentAtlEventState;
    [FieldOffset(0x0290)] public TMap<EEvtManagerState, IntPtr> AtlEventStates;
    [FieldOffset(0x02E0)] public AUIBackLog* UIBackLogActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtlEvtHandwritingData
{
    [FieldOffset(0x0000)] public EAtlEvtHandwritingType HandwritingType;
    [FieldOffset(0x0004)] public FVector Location;
    [FieldOffset(0x0010)] public FVector Scale;
    [FieldOffset(0x0020)] public FString BoneName;
    [FieldOffset(0x0030)] public int LoopCount;
    [FieldOffset(0x0034)] public float CameraOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAtlEvtHandwritingDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FAtlEvtHandwritingData EvtHandwritingData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UAtlEvtHandwritingSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public UAtlEvtHandwritingDataAsset* EvtHandwritingAsset;
    [FieldOffset(0x0038)] public TArray<FAtlEvtHandwritingData> EvtHandwritingDefaultDatas;
    [FieldOffset(0x0048)] public TMap<uint, FAtlEvtHandwritingData> EvtHandwritingDataMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAtlEvtHighStreamingLocator
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public int HighStreamingLocatorID;
    [FieldOffset(0x027C)] public float BoostFactor;
    [FieldOffset(0x0280)] public bool bOverrideLocation;
    [FieldOffset(0x0284)] public float Duration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AAtlEvtLevelSequenceLoadingActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public AAtlEvtLevelSequenceActor* OwnerEvtLevelSequenceActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtlEvtLevelSequenceSound
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USoundAtomCueSheet> AtomCueAssetPath;
    [FieldOffset(0x0028)] public int PlayerMajorID;
    [FieldOffset(0x002C)] public int PlayerMinorID;
    [FieldOffset(0x0030)] public EPlayerType SoundPlayerType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtlEvtLevelSequenceEventVoice
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USoundAtomCueSheet> AtomCueAssetPath;
    [FieldOffset(0x0028)] public int BankNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAtlEvtLevelSequenceEventSE
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USoundAtomCueSheet> AtomCueAssetPath;
    [FieldOffset(0x0028)] public int BankNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct AAtlEvtLevelSequenceActor
{
    [FieldOffset(0x0000)] public ALevelSequenceActor baseObj;
    [FieldOffset(0x02A8)] public EAtlLevelSequenceActorType AtlSequenceType;
    [FieldOffset(0x02B0)] public TArray<FFrameNumber> EvtDialogueTimeArray;
    [FieldOffset(0x02C8)] public TArray<FAtlEvtLevelSequenceSound> SoundAssetArray;
    [FieldOffset(0x02D8)] public TArray<int> BankIDArray;
    [FieldOffset(0x02E8)] public TArray<FAtlEvtLevelSequenceEventVoice> EventVoiceAssetArray;
    [FieldOffset(0x02F8)] public TArray<FAtlEvtLevelSequenceEventSE> EventSEAssetArray;
    [FieldOffset(0x030C)] public int AtlFieldEventIndex;
    [FieldOffset(0x0318)] public bool bUseDOFInCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtlEvtLightScenarioSublevel
{
    [FieldOffset(0x0000)] public FName FieldLevelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtlEvtAdditionBGSublevel
{
    [FieldOffset(0x0000)] public FName FieldLevelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAtlEvtLightScenarioSublevelsDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAtlEvtLightScenarioSublevel> LightingIndexArray;
    [FieldOffset(0x0040)] public TArray<FAtlEvtAdditionBGSublevel> AdditionBGSublevelArray;
    [FieldOffset(0x0050)] public bool bDisableAutoLoadFirstLightingScenarioLevel;
    [FieldOffset(0x0051)] public bool bForceDisableUseCurrentTimeZone;
    [FieldOffset(0x0054)] public int ForceMonth;
    [FieldOffset(0x0058)] public int ForceDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAtlEvtLightScenarioLoader
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AAtlEvtLightScenarioUnloader
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAtlEvtLightScenarioSublevelParam
{
    [FieldOffset(0x0000)] public UObject* Level;
    [FieldOffset(0x0008)] public FName LevelName;
    [FieldOffset(0x0010)] public FPrimaryAssetId PrimaryAssetId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AAtlEvtLightScenarioTransitionController
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0290)] public TArray<FAtlEvtLightScenarioSublevelParam> LightScenarioSublevelParamArray;
    [FieldOffset(0x02C0)] public AAtlEvtLightScenarioLoader* LoaderActor;
    [FieldOffset(0x02C8)] public AAtlEvtLightScenarioUnloader* UnloaderActor;
    [FieldOffset(0x02D0)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAtlEvtMoviePlayManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UEvtTextureForOnePicture
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UTexture2D* Texture;
    [FieldOffset(0x0030)] public UAssetLoader* AssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct AAtlEvtOnePicture
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public TArray<IntPtr> TextureArray;
    [FieldOffset(0x0230)] public UMaterial* Material;
    [FieldOffset(0x0238)] public UMaterialInstanceDynamic* DynamicMaterial;
    [FieldOffset(0x0240)] public UAssetLoader* AssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtlEvtPreSublevelData
{
    [FieldOffset(0x0000)] public TArray<FString> EventBGLevels;
    [FieldOffset(0x0010)] public int BGFieldMajorID;
    [FieldOffset(0x0014)] public int BGFieldMinorID;
    [FieldOffset(0x0018)] public FString BGFieldSeasonSubLevel;
    [FieldOffset(0x0028)] public FString BGFieldSoundSubLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtlEvtPreDungeonSublevelData
{
    [FieldOffset(0x0000)] public FName EventBGFloorLevel;
    [FieldOffset(0x0008)] public FName BGEnvironmentSubLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FAtlEvtPreData
{
    [FieldOffset(0x0000)] public int EventMajorID;
    [FieldOffset(0x0004)] public int EventMinorID;
    [FieldOffset(0x0008)] public int EventCategoryTypeID;
    [FieldOffset(0x000C)] public FName EventRank;
    [FieldOffset(0x0014)] public FName EventCategory;
    [FieldOffset(0x0020)] public FString EventLevel;
    [FieldOffset(0x0030)] public TArray<FAtlEvtPreSublevelData> EventSublevels;
    [FieldOffset(0x0040)] public TArray<FName> LightScenarioSublevels;
    [FieldOffset(0x0050)] public FAtlEvtPreDungeonSublevelData DungeonSublevel;
    [FieldOffset(0x0060)] public bool bDisableAutoLoadFirstLightingScenarioLevel;
    [FieldOffset(0x0061)] public bool bForceDisableUseCurrentTimeZone;
    [FieldOffset(0x0062)] public byte ForcedCldTimeZoneValue;
    [FieldOffset(0x0064)] public int ForceMonth;
    [FieldOffset(0x0068)] public int ForceDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAtlEvtPreDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAtlEvtPreData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AAtlEvtPropDetachLocator
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAtlEvtPlayingCharacterInfo
{
    [FieldOffset(0x0000)] public TArray<TWeakObjectPtr<AActor>> AppEventCharacters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FAtlEvtSoundSEInfo
{
    [FieldOffset(0x0000)] public int bankID;
    [FieldOffset(0x0004)] public bool bStopWhileHighSpeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEvtLocalData
{
    [FieldOffset(0x0000)] public TArray<int> LocalDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAtlEvtPlayLoadSublevelInfo
{
    [FieldOffset(0x0000)] public FName SublevelPackageName;
    [FieldOffset(0x0008)] public EAtlEvtPlayLoadSublevelType SublevelType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtlEvtPlayBindingTagParameter
{
    [FieldOffset(0x0000)] public AActor* BindingActor;
    [FieldOffset(0x0008)] public FString BindingTag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtlEvtAssetOverrideParameter
{
    [FieldOffset(0x0000)] public FAtlEvtPlayBindingTagParameter BindingTagParameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFieldEventInfo
{
    [FieldOffset(0x0000)] public AActor* FieldCameraActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtlEvtPlayParameter
{
    [FieldOffset(0x0000)] public FString EventAssetName;
    [FieldOffset(0x0010)] public bool bEnableBinding;
    [FieldOffset(0x0018)] public TArray<FAtlEvtPlayBindingTagParameter> BindingTagActors;
    [FieldOffset(0x0028)] public bool bDisableTimeZone;
    [FieldOffset(0x0030)] public FFieldEventInfo FieldEventInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FAtlEvtVisibleEventInfo
{
    [FieldOffset(0x0000)] public bool bExsistVisibleField;
    [FieldOffset(0x0008)] public FString EventLevelName;
    [FieldOffset(0x0018)] public int EventCategoryTypeID;
    [FieldOffset(0x001C)] public int EventMajorID;
    [FieldOffset(0x0020)] public int EventMinorID;
    [FieldOffset(0x0028)] public TSoftObjectPtr<ULevelStreaming> VisibleLevelStreaming;
    [FieldOffset(0x0050)] public int FieldMajorID;
    [FieldOffset(0x0054)] public int FieldMinorID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct UAtlEvtSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public TMap<uint, FAtlEvtPlayingCharacterInfo> AppEvtCharactersMap;
    [FieldOffset(0x0080)] public TMap<int, FAtlEvtPlayingCharacterInfo> AppEvtLipUniqueIDCharactersMap;
    [FieldOffset(0x00D0)] public TArray<FAtlEvtSoundSEInfo> EventSEInfoArray;
    [FieldOffset(0x00E0)] public AAtlEvtLightScenarioTransitionController* LightScenarioTransitionController;
    [FieldOffset(0x00E8)] public FEvtLocalData EvtLocalData;
    [FieldOffset(0x00F8)] public UAssetLoader* pLSAssetLoader;
    [FieldOffset(0x0100)] public UObject* LevelSequenceObject;
    [FieldOffset(0x0148)] public UAtlEvtPreDataAsset* EvtPreDataAsset;
    [FieldOffset(0x0150)] public TMap<uint, FAtlEvtPreData> EvtPreDataMap;
    [FieldOffset(0x01A0)] public TWeakObjectPtr<UWorld> EventSublevelWorldObjPtr;
    [FieldOffset(0x01B8)] public TArray<FAtlEvtPlayLoadSublevelInfo> LoadedEventSublevelInfos;
    [FieldOffset(0x0270)] public TArray<FName> CurrentLoadedEventSublevels;
    [FieldOffset(0x0280)] public TArray<FAtlEvtAssetOverrideParameter> ReserveAssetOverrideParameter;
    [FieldOffset(0x0298)] public UAssetLoader* AssetOverrideLoader;
    [FieldOffset(0x02A0)] public TSubclassOf<ACharacter> AssetOverrideSubClass;
    [FieldOffset(0x02C8)] public AActor* BagActor;
    [FieldOffset(0x02D0)] public AAtlEvtOnePicture* OnePicture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x300)] 
public unsafe struct AAtlEvtPlayObject
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public FString LevelName;
    [FieldOffset(0x0288)] public FAtlEvtPlayParameter EvtPlayParam;
    [FieldOffset(0x02C0)] public FString EventRank;
    [FieldOffset(0x02E8)] public ALevelSequenceActor* LevelSequenceActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AAtlEvtPlayUnstreamObject
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public FString LevelName;
    [FieldOffset(0x0298)] public ALevelSequenceActor* LevelSequenceActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDEPRECATED_AtlEvtSubsystemDraft
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0040)] public int GlobalCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAtlHandwritingDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<EAtlEvtHandwritingType, TSoftClassPtr<AHandwritingEffectBase>> HandwritingEffectSoftObjMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AAtlNiagaraActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UNiagaraComponent* NiagaraComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x208)] 
public unsafe struct UAtlUIPlg
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FSlateBrush Brush;
    [FieldOffset(0x01A0)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x01C0)] public UPlgAsset* PlgAsset;
    [FieldOffset(0x01C8)] public int PrimitiveNo;
    [FieldOffset(0x01CC)] public float PlgScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x218)] 
public unsafe struct UAtlUIPrimitive
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FSlateBrush Brush;
    [FieldOffset(0x01A0)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x01C0)] public TArray<FVector2D> Vertexes;
    [FieldOffset(0x01D0)] public TArray<int> Indexes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct UAtlUITextBlock
{
    [FieldOffset(0x0000)] public UTextLayoutWidget baseObj;
    [FieldOffset(0x0128)] public FText Text;
    [FieldOffset(0x0150)] public EAtlUIFontStyle fontStyle;
    [FieldOffset(0x0154)] public float TextScale;
    [FieldOffset(0x0158)] public UFontAdjustmentListTable* FontAdjustmentListTable;
    [FieldOffset(0x0170)] public FSlateColor ColorAndOpacity;
    [FieldOffset(0x01A8)] public FSlateFontInfo Font;
    [FieldOffset(0x0200)] public FSlateBrush StrikeBrush;
    [FieldOffset(0x0288)] public FVector2D ShadowOffset;
    [FieldOffset(0x0290)] public FLinearColor ShadowColorAndOpacity;
    [FieldOffset(0x02B0)] public float MinDesiredWidth;
    [FieldOffset(0x02B4)] public bool bWrapWithInvalidationPanel;
    [FieldOffset(0x02B5)] public bool bAutoWrapText;
    [FieldOffset(0x02B6)] public ETextTransformPolicy TextTransformPolicy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x218)] 
public unsafe struct UAtlUITriangle
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FSlateBrush Brush;
    [FieldOffset(0x01A0)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x01C0)] public FVector2D Vertexe01;
    [FieldOffset(0x01C8)] public FVector2D Vertexe02;
    [FieldOffset(0x01D0)] public FVector2D Vertexe03;
    [FieldOffset(0x01D8)] public int Antialiasing;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AUIBaseActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct ABasePartyPanel
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public UDataTable* LayoutData;
    [FieldOffset(0x02B0)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFL_UIPaint
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLAtlEvtCharacter
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLAtlEvtHandwriting
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AAtlEvtPlayOnBindingActorObject
{
    [FieldOffset(0x0000)] public AAtlEvtPlayObject baseObj;
    [FieldOffset(0x0300)] public FString EvtName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLAtlEvtTest
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLBtlAnimation
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLBtlManager
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBFLEventMovieScene
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBPExtensionsFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UBtlActionManagerComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public ABtlActor* ActionCommander;
    [FieldOffset(0x00D0)] public EBtlCommandType ActionType;
    [FieldOffset(0x00D4)] public int ActionID;
    [FieldOffset(0x00D8)] public TArray<IntPtr> ActionTargets;
    [FieldOffset(0x00E8)] public UBtlTargetsManagerComponent* TargetsManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBtlEventCustomEquipment
{
    [FieldOffset(0x0000)] public bool UseCustomEquipSettings;
    [FieldOffset(0x0004)] public int CostumeID;
    [FieldOffset(0x0008)] public bool UseWeapon;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlEffectItem
{
    [FieldOffset(0x0000)] public AActor* ParentEmpActor;
    [FieldOffset(0x0008)] public UNiagaraComponent* ObjectReference;
    [FieldOffset(0x0010)] public FName Tag;
    [FieldOffset(0x0018)] public EBtlBadStatusIcon Type;
    [FieldOffset(0x0019)] public bool BadStatus;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBtlBossAnimRequestParam
{
    [FieldOffset(0x0000)] public EBtlAnimationType Type;
    [FieldOffset(0x0001)] public bool UseCustomFade;
    [FieldOffset(0x0004)] public float CustomFadeIn;
    [FieldOffset(0x0008)] public float CustomFadeOut;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10A50)] 
public unsafe struct ABtlActor
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x02F0)] public FBtlEventCustomEquipment CustomEquipments;
    [FieldOffset(0x0320)] public EBtlAttackType AttackBaseType;
    [FieldOffset(0x0338)] public FVector HomePosition;
    [FieldOffset(0x0344)] public FRotator HomeRotation;
    [FieldOffset(0x0350)] public FVector Position;
    [FieldOffset(0x035C)] public FRotator Rotation;
    [FieldOffset(0x0368)] public int HomePositionID;
    [FieldOffset(0x036C)] public int InitialLocationIndexFromLeft;
    [FieldOffset(0x0370)] public bool EnemyFlag;
    [FieldOffset(0x0371)] public bool PersonaFlag;
    [FieldOffset(0x0372)] public bool PersonaHideEmergeEffect;
    [FieldOffset(0x03D0)] public ABtlAI* AI;
    [FieldOffset(0x03D8)] public UBtlVoice* Voice;
    [FieldOffset(0x03E0)] public UBtlCoreComponent* BtlCore;
    [FieldOffset(0x03E8)] public TArray<IntPtr> PersonaList;
    [FieldOffset(0x03F8)] public int RequestedPersonaNum;
    [FieldOffset(0x0400)] public TArray<FBtlEffectItem> EffectList;
    [FieldOffset(0x0410)] public TArray<EBtlBadStatusIcon> EffectRequestList;
    [FieldOffset(0x0420)] public EBtlBadStatusIcon CurrentBadStatusType;
    [FieldOffset(0x0421)] public EBtlAlloutAttackResult AlloutAttackResult;
    [FieldOffset(0x0422)] public EBtlAttackPerformanceType AttackPerformanceType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlPersonaInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlAegisInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ABtlAiScriptWatcher
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public ABtlAI* AI;
    [FieldOffset(0x0288)] public UBtlActionManagerComponent* ActionManager;
    [FieldOffset(0x0290)] public ABtlActor* Character;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB58)] 
public unsafe struct ABtlAI
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0AE0)] public ABtlActor* Character;
    [FieldOffset(0x0AE8)] public UBtlCoreComponent* Core;
    [FieldOffset(0x0AF0)] public EBtlCommandType ActionType;
    [FieldOffset(0x0AF1)] public EBtlCommandType PrevActionType;
    [FieldOffset(0x0AF4)] public uint ActionID;
    [FieldOffset(0x0AF8)] public uint ActionSkillID;
    [FieldOffset(0x0AFC)] public uint ActionItemID;
    [FieldOffset(0x0B00)] public uint PrevActionID;
    [FieldOffset(0x0B04)] public ushort MinorParam;
    [FieldOffset(0x0B06)] public EBtlDataAttr ReceiveSkillAttr;
    [FieldOffset(0x0B08)] public TArray<IntPtr> ActionTargets;
    [FieldOffset(0x0B18)] public TArray<IntPtr> PrevActionTargets;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB58)] 
public unsafe struct ABtlManualAI
{
    [FieldOffset(0x0000)] public ABtlAI baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB78)] 
public unsafe struct ABtlScriptAI
{
    [FieldOffset(0x0000)] public ABtlAI baseObj;
    [FieldOffset(0x0B58)] public UAssetLoader* pLoader;
    [FieldOffset(0x0B60)] public UBfAsset* pBfAsset;
    [FieldOffset(0x0B68)] public bool bAssetLoaded;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UBtlAIManagerComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UBtlBCDCharaCameraComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float RadiumRation;
    [FieldOffset(0x00B4)] public float HeightRation;
    [FieldOffset(0x00B8)] public float RotateDegree;
    [FieldOffset(0x00BC)] public float Pan;
    [FieldOffset(0x00C0)] public float Roll;
    [FieldOffset(0x00C4)] public bool bUseCommonCylinder;
    [FieldOffset(0x00C5)] public EBtlEventAreaType TargetAreaType;
    [FieldOffset(0x00C8)] public FString SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UBtlBCDMoveCameraComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public float BlendAlpha;
    [FieldOffset(0x00B4)] public EBtlCutsceneMoveMode MoveMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlBoss
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UDataTable* CameraTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UBtlBossChariot
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossElizabeth
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossEmperor
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossEmperorInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UBtlBossFortune
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
    [FieldOffset(0x0038)] public UBtlCoreComponent* pSavedCore;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossFortuneInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBtlBossHangedMan
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossHangedManInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBtlBossHermit
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossHermitInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlBossHierophant
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlBossLovers
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossMagician
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossNyxAvatar
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossNyxAvatarInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct UBtlBossNyxCore
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossNyxCoreInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossPriestess
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossStregaBase
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBtlBossStregaJin
{
    [FieldOffset(0x0000)] public UBtlBossStregaBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBtlBossStregaTakaya
{
    [FieldOffset(0x0000)] public UBtlBossStregaBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBtlBossStregaTakayaJin
{
    [FieldOffset(0x0000)] public UBtlBossStregaBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossStregaChidori
{
    [FieldOffset(0x0000)] public UBtlBossStregaBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlBossStregaInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlBossStregaTakayaJoined
{
    [FieldOffset(0x0000)] public UBtlBossStregaBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x488)] 
public unsafe struct ABtlCalcBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public int DamageMax;
    [FieldOffset(0x027C)] public int CriticalMin;
    [FieldOffset(0x0280)] public int CriticalMax;
    [FieldOffset(0x0284)] public float CriticalPlayerDamageRate;
    [FieldOffset(0x0288)] public float CriticalEnemyDamageRate;
    [FieldOffset(0x028C)] public float KnockdownRateAttackingDownCharacter;
    [FieldOffset(0x0290)] public int AccuracyMin;
    [FieldOffset(0x0294)] public int AccuracyMax;
    [FieldOffset(0x0298)] public int BadStatusAccuracyMin;
    [FieldOffset(0x029C)] public int BadStatusAccuracyMax;
    [FieldOffset(0x02A0)] public int EscapeSuccessRateMin;
    [FieldOffset(0x02A4)] public int EscapeSuccessRateMax;
    [FieldOffset(0x02A8)] public int EscapeTurn;
    [FieldOffset(0x02AC)] public int DyingHPRatio;
    [FieldOffset(0x02B0)] public float PhysicsChargePowerRate;
    [FieldOffset(0x02B4)] public float MagicChargePowerRate;
    [FieldOffset(0x02B8)] public float PhysicsChargePowerRateTheurgia;
    [FieldOffset(0x02BC)] public float MagicChargePowerRateTheurgia;
    [FieldOffset(0x02C0)] public int BadStatusRecoveryPlayerRate;
    [FieldOffset(0x02C4)] public int BadStatusRecoveryEnemyRate;
    [FieldOffset(0x02C8)] public float GuardProtectRatio;
    [FieldOffset(0x02CC)] public float DamageRatioToDown;
    [FieldOffset(0x02D0)] public float SupportTurnMax;
    [FieldOffset(0x02D4)] public float CharmBoosterDamageRatioToCharm;
    [FieldOffset(0x02D8)] public float SkillDamageBonusToDown;
    [FieldOffset(0x02DC)] public float BadHitRatioBonus;
    [FieldOffset(0x02E0)] public float AutoMikiri;
    [FieldOffset(0x02E4)] public float AutoShinMikiri;
    [FieldOffset(0x02E8)] public float AutoBooster;
    [FieldOffset(0x02EC)] public float AutoHighBooster;
    [FieldOffset(0x02F0)] public float AutoMegaBooster;
    [FieldOffset(0x02F4)] public float AutoBoosterMax;
    [FieldOffset(0x02F8)] public float AutoAlloutBooster;
    [FieldOffset(0x02FC)] public float AutoBadStatusBooster;
    [FieldOffset(0x0300)] public float AutoBadStatusSwoonBooster;
    [FieldOffset(0x0304)] public int AutoCounterOccur;
    [FieldOffset(0x0308)] public int AutoHeavyCounterOccur;
    [FieldOffset(0x030C)] public int AutoHyperCounterOccur;
    [FieldOffset(0x0310)] public float AutoGrowthLowExpRatio;
    [FieldOffset(0x0314)] public float AutoGrowthMiddleExpRatio;
    [FieldOffset(0x0318)] public float AutoGrowthhightExpRatio;
    [FieldOffset(0x031C)] public float AutoHPRecoveryRatio_1;
    [FieldOffset(0x0320)] public float AutoHPRecoveryRatio_2;
    [FieldOffset(0x0324)] public float AutoHPRecoveryRatio_3;
    [FieldOffset(0x0328)] public float AutoSPRecoveryValue_1;
    [FieldOffset(0x032C)] public float AutoSPRecoveryValue_2;
    [FieldOffset(0x0330)] public float AutoSPRecoveryValue_3;
    [FieldOffset(0x0334)] public float AutoSPRecoveryValue_AddEffect_1;
    [FieldOffset(0x0338)] public float AutoSPRecoveryValue_AddEffect_2;
    [FieldOffset(0x033C)] public float AutoAddExp_Ration_1;
    [FieldOffset(0x0340)] public float AutoAddExp_Ration_2;
    [FieldOffset(0x0344)] public float AutoTakeoverBooster;
    [FieldOffset(0x0348)] public float AutoTakeoverHighBooster;
    [FieldOffset(0x034C)] public float AutoSingleTargetBooster;
    [FieldOffset(0x0350)] public float AutoMultiTargetBooster;
    [FieldOffset(0x0354)] public int AutoAddCritical;
    [FieldOffset(0x0358)] public int AutoAddCriticalHigh;
    [FieldOffset(0x035C)] public float AutoTGRWeakBooster;
    [FieldOffset(0x0360)] public float AutoTGRWeakHighBooster;
    [FieldOffset(0x0364)] public float AutoTGRCriticalBooster;
    [FieldOffset(0x0368)] public float AutoTGRCriticalHighBooster;
    [FieldOffset(0x036C)] public int AutoTGRAddCritical;
    [FieldOffset(0x0370)] public int AutoTGRAddCriticalHigh;
    [FieldOffset(0x0374)] public float AutoTGRPowerBoostAmplify;
    [FieldOffset(0x0378)] public float AutoTGRPowerBoostHighAmplify;
    [FieldOffset(0x037C)] public float AutoTGRAddCriticalToBadStatus;
    [FieldOffset(0x0380)] public float AutoTGRAddCriticalHighToBadStatus;
    [FieldOffset(0x0384)] public float AutoTGRWeakProtecter;
    [FieldOffset(0x0388)] public float AutoTGRWeakHighProtecter;
    [FieldOffset(0x038C)] public float AutoTGRPhisicsBooster;
    [FieldOffset(0x0390)] public float AutoTGRPhisicsHighBooster;
    [FieldOffset(0x0394)] public float AutoTGRSPHeal;
    [FieldOffset(0x0398)] public float AutoTGRSPHighHeal;
    [FieldOffset(0x039C)] public float TGRGaugeLowHPRatio;
    [FieldOffset(0x03A0)] public float TGRGaugeLowSPRatio;
    [FieldOffset(0x03A4)] public float TGRExpBonusRatio;
    [FieldOffset(0x03A8)] public float TGRGaugeBonusRatio;
    [FieldOffset(0x03AC)] public float TGRGaugeBonusHighRatio;
    [FieldOffset(0x03B0)] public int MaxTurnSWOON;
    [FieldOffset(0x03B4)] public int MaxTurnCHARM;
    [FieldOffset(0x03B8)] public int MinTurnCHARM;
    [FieldOffset(0x03BC)] public int MaxTurnUPSET;
    [FieldOffset(0x03C0)] public int MinTurnUPSET;
    [FieldOffset(0x03C4)] public int MaxTurnPANIC;
    [FieldOffset(0x03C8)] public int MinTurnPANIC;
    [FieldOffset(0x03CC)] public int MaxTurnFEAR;
    [FieldOffset(0x03D0)] public int MinTurnFEAR;
    [FieldOffset(0x03D4)] public int MaxTurnANGER;
    [FieldOffset(0x03D8)] public int MinTurnANGER;
    [FieldOffset(0x03DC)] public int MaxTurnFREEZE;
    [FieldOffset(0x03E0)] public int MinTurnFREEZE;
    [FieldOffset(0x03E4)] public int MaxTurnSHOCK;
    [FieldOffset(0x03E8)] public int MinTurnSHOCK;
    [FieldOffset(0x03EC)] public int DefaultTurnOVERLIMIT;
    [FieldOffset(0x03F0)] public int DefaultTurnOVERHEAT;
    [FieldOffset(0x03F4)] public int AddCriticalByUPSET;
    [FieldOffset(0x03F8)] public int AddCriticalByPANIC;
    [FieldOffset(0x03FC)] public int AddCriticalByFEAR;
    [FieldOffset(0x0400)] public int AddCriticalBySHOCK;
    [FieldOffset(0x0404)] public int AddCriticalByFREEZE;
    [FieldOffset(0x0408)] public int AddCriticalBySWOON;
    [FieldOffset(0x040C)] public int PoisonMaxDamage;
    [FieldOffset(0x0410)] public float PoisonDamageRatio;
    [FieldOffset(0x0414)] public float AccuracyRatioByANGER;
    [FieldOffset(0x0418)] public int AttackSwoonDownRatio;
    [FieldOffset(0x041C)] public int PhysicalSkillSwoonDownRatio;
    [FieldOffset(0x0420)] public int MagicalSkillSwoonDownRatio;
    [FieldOffset(0x0424)] public int TheurgiaSkillSwoonDownRatio;
    [FieldOffset(0x0428)] public int DoNothingRatioByFEAR;
    [FieldOffset(0x042C)] public float MajorArcanaRationByStrong;
    [FieldOffset(0x0430)] public float MajorArcanaRationByRare;
    [FieldOffset(0x0434)] public int MustAppearMajorEncount;
    [FieldOffset(0x0438)] public float ShufflePersonaBonusExpRation;
    [FieldOffset(0x043C)] public float MajorArcanaBasicRation;
    [FieldOffset(0x0440)] public int MinorArcanaBasicRation;
    [FieldOffset(0x0444)] public int PersonaArcanaBasicRation;
    [FieldOffset(0x0448)] public float ShuffleTimeAlloutBooster;
    [FieldOffset(0x044C)] public int ShuffleTimeChariotIncreaseHeroHp;
    [FieldOffset(0x0450)] public int ShuffleTimeHermitIncreaseHeroSP;
    [FieldOffset(0x0454)] public int ShuffleTimeFortuneIncreasePartyHp;
    [FieldOffset(0x0458)] public int ShuffleTimeStrengthIncreasePartySp;
    [FieldOffset(0x045C)] public int MaxBattleNumNotContinualPlayingFukaCutin;
    [FieldOffset(0x0460)] public int OneMoreCount;
    [FieldOffset(0x0464)] public int OneMoreCountEnemy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ABtlFormula
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* Loader;
    [FieldOffset(0x0288)] public ABtlCalcBase* Calc;
    [FieldOffset(0x0290)] public TSubclassOf<ABtlCalcBase> CalcAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct ABtlCamera
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ABtlActor* cameraMainCharacter;
    [FieldOffset(0x0228)] public TArray<IntPtr> CameraTargets;
    [FieldOffset(0x0238)] public ACineCameraActor* MainCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBtlCompensation
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlEncountParam
{
    [FieldOffset(0x0000)] public int EncountID;
    [FieldOffset(0x0004)] public EBtlEncountPreemptive Preemptive;
    [FieldOffset(0x0005)] public EBtlEncountPreemptive PreemptiveOriginal;
    [FieldOffset(0x0010)] public int StageMajor;
    [FieldOffset(0x0014)] public int StageMinor;
    [FieldOffset(0x0018)] public int EnemyBadStatus;
    [FieldOffset(0x001C)] public bool CalledFromScript;
    [FieldOffset(0x001D)] public bool IsEventResult;
}

[StructLayout(LayoutKind.Explicit, Size = 0x568)] 
public unsafe struct UBtlCoreComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x0190)] public TWeakObjectPtr<AInitReadActor> InitReadActor;
    [FieldOffset(0x0198)] public FSoftObjectPath FormationData;
    [FieldOffset(0x01B0)] public UDataTable* FormationTable;
    [FieldOffset(0x01B8)] public UBtlEventCutsceneController* BtlCutscene;
    [FieldOffset(0x01C0)] public UBtlBoss* Boss;
    [FieldOffset(0x01C8)] public ABtlCountdown* Countdown;
    [FieldOffset(0x01D0)] public UBtlEventController* BtlEventController;
    [FieldOffset(0x01D8)] public UBtlResidentDataBase* ResidentData;
    [FieldOffset(0x01E0)] public AActor* PlayerLocationRoot;
    [FieldOffset(0x01E8)] public AActor* EnemyLocationRoot;
    [FieldOffset(0x01F0)] public AActor* EnemyAttachRoot;
    [FieldOffset(0x01F8)] public ABtlActor* EnemyTurnTableRotationTargetCharacter;
    [FieldOffset(0x0200)] public UBtlEnvironmentBase* BtlEnvironmentComponent;
    [FieldOffset(0x0208)] public ABtlFadeManager* FadeManager;
    [FieldOffset(0x0210)] public ABtlShakeManager* ShakeManager;
    [FieldOffset(0x025C)] public uint SummonEnemyCount;
    [FieldOffset(0x0290)] public float BattleElapsedTime;
    [FieldOffset(0x0294)] public float BattleDeltaTime;
    [FieldOffset(0x0298)] public FBtlEncountParam EncountParameter;
    [FieldOffset(0x02B8)] public int EncountIndex;
    [FieldOffset(0x02BC)] public EBtlFinishResult BattleResult;
    [FieldOffset(0x02C0)] public ABtlActor* CurrentAction;
    [FieldOffset(0x02C8)] public ABtlActor* EventMainAction;
    [FieldOffset(0x02D0)] public ABtlActor* LatestAction;
    [FieldOffset(0x02D8)] public ABtlActor* ActionRequestedEscape;
    [FieldOffset(0x02E0)] public TArray<IntPtr> ActionList;
    [FieldOffset(0x02F0)] public TArray<IntPtr> PlayerList;
    [FieldOffset(0x0300)] public TArray<IntPtr> EnemyList;
    [FieldOffset(0x0310)] public TArray<TSubclassOf<ABtlActor>> PlayerDataStockList;
    [FieldOffset(0x0330)] public TArray<TSubclassOf<ABtlActor>> PlayerDataAddedStockList;
    [FieldOffset(0x0340)] public TSubclassOf<AAppActor> DebugMonitorData;
    [FieldOffset(0x0348)] public TArray<short> PlayerDataAddedIDList;
    [FieldOffset(0x0360)] public TArray<TSubclassOf<ABtlActor>> EnemyDataStockList;
    [FieldOffset(0x0380)] public TArray<TSubclassOf<ABtlActor>> EnemyDataSummonStockList;
    [FieldOffset(0x0390)] public TArray<short> EnemyDataSummonIDList;
    [FieldOffset(0x03A8)] public TArray<TSubclassOf<ABtlActor>> PersonaDataStockList;
    [FieldOffset(0x03C0)] public UBtlCompensation* Compensation;
    [FieldOffset(0x03C8)] public UBtlOrder* Order;
    [FieldOffset(0x03D0)] public ABtlPhase* CurrentPhase;
    [FieldOffset(0x03D8)] public bool RequestChangePhase;
    [FieldOffset(0x03E0)] public ABtlPhase* RequestedNextPhase;
    [FieldOffset(0x03E8)] public TArray<IntPtr> UtensilEffectList;
    [FieldOffset(0x03F8)] public FString HomeFormation;
    [FieldOffset(0x0408)] public ABtlResultResourceManager* ResultResource;
    [FieldOffset(0x0410)] public bool LoadedResidentData;
    [FieldOffset(0x0411)] public bool LoadedBattleData;
    [FieldOffset(0x0412)] public bool LoadedAllyData;
    [FieldOffset(0x0413)] public bool LoadedEnemyData;
    [FieldOffset(0x0414)] public bool LoadedPersonaData;
    [FieldOffset(0x0415)] public bool LoadedSummonEnemyData;
    [FieldOffset(0x0416)] public bool LoadedAddedPlayerData;
    [FieldOffset(0x0417)] public bool LoadedEncSerial;
    [FieldOffset(0x0418)] public bool LoadedDebugMonitor;
    [FieldOffset(0x0420)] public UAssetLoader* Loader;
    [FieldOffset(0x0428)] public UAssetLoader* LoaderEnemy;
    [FieldOffset(0x0430)] public UAssetLoader* LoaderPersona;
    [FieldOffset(0x0438)] public UAssetLoader* LoaderSummonEnemy;
    [FieldOffset(0x0440)] public UAssetLoader* LoaderAddedPlayer;
    [FieldOffset(0x0448)] public UAssetLoader* LoaderSerialEncount;
    [FieldOffset(0x0450)] public UAssetLoader* LoaderDebugMonitor;
    [FieldOffset(0x0458)] public UBtlSupportInfoBase* SupportInfo;
    [FieldOffset(0x0460)] public ushort InitialEquipedPersonaID;
    [FieldOffset(0x0508)] public TArray<int> TutorialRequestList;
    [FieldOffset(0x0518)] public AAppActor* DebugWindow;
    [FieldOffset(0x0520)] public AAppActor* DebugMonitor;
    [FieldOffset(0x0528)] public AAppActor* DebugSkillSelect;
    [FieldOffset(0x0530)] public FString ModeName;
    [FieldOffset(0x0540)] public FString DebugStateString;
    [FieldOffset(0x0550)] public FString DebugLatestCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IBtlManagerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ABtlCountdown
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public float Timer;
    [FieldOffset(0x027C)] public float Speed;
    [FieldOffset(0x0280)] public bool IsPlay;
    [FieldOffset(0x0281)] public bool IsVisible;
    [FieldOffset(0x0282)] public bool IsAnimation;
    [FieldOffset(0x0284)] public float AnimationLerp;
    [FieldOffset(0x0288)] public float AnimationStartTime;
    [FieldOffset(0x028C)] public float AnimationEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBtlDataAssets
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatPlayerMaxHPSP
{
    [FieldOffset(0x0000)] public ushort MaxHp;
    [FieldOffset(0x0002)] public ushort MaxSp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FDatPlayerMaxHPSPBunch
{
    [FieldOffset(0x0000)] public FDatPlayerMaxHPSP EachPlayerData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPlayerMaxHPSPTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPlayerMaxHPSPBunch> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatPlayerLevelUpDataRecord
{
    [FieldOffset(0x0000)] public uint Exp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPlayerLevelUpTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPlayerLevelUpDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FDatEncountDataRecord
{
    [FieldOffset(0x0000)] public uint flags;
    [FieldOffset(0x0004)] public ushort party_item;
    [FieldOffset(0x0006)] public ushort party_item_num;
    [FieldOffset(0x0008)] public ushort ID;
    [FieldOffset(0x0012)] public ushort major;
    [FieldOffset(0x0014)] public ushort Minor;
    [FieldOffset(0x0016)] public ushort Sound;
    [FieldOffset(0x0018)] public ushort shuffleLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatEncountTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatEncountDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatEnemyItemTable
{
    [FieldOffset(0x0000)] public ushort ID;
    [FieldOffset(0x0002)] public ushort prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatEnemyEventItemTable
{
    [FieldOffset(0x0000)] public uint Event;
    [FieldOffset(0x0004)] public ushort ID;
    [FieldOffset(0x0006)] public ushort prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatEnemyAttackTable
{
    [FieldOffset(0x0000)] public byte attr;
    [FieldOffset(0x0001)] public byte Hit;
    [FieldOffset(0x0002)] public ushort power;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C)] 
public unsafe struct FDatEnemyDataRecord
{
    [FieldOffset(0x0000)] public uint flags;
    [FieldOffset(0x0004)] public byte Race;
    [FieldOffset(0x0006)] public short Level;
    [FieldOffset(0x0008)] public int MaxHp;
    [FieldOffset(0x000C)] public int MaxSp;
    [FieldOffset(0x0010)] public byte Params;
    [FieldOffset(0x0016)] public ushort Skill;
    [FieldOffset(0x0028)] public uint Exp;
    [FieldOffset(0x002C)] public uint money;
    [FieldOffset(0x0030)] public FDatEnemyItemTable Item;
    [FieldOffset(0x0040)] public FDatEnemyEventItemTable eventitem;
    [FieldOffset(0x0048)] public FDatEnemyAttackTable attack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatEnemyTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatEnemyDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatEnemyAnalyzeSyncDataRecord
{
    [FieldOffset(0x0000)] public ushort enemyID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatEnemyAnalyzeSyncTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatEnemyAnalyzeSyncDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatEnemyName
{
    [FieldOffset(0x0000)] public FText Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatEnemyNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatEnemyName> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE)] 
public unsafe struct FDatPersonaDataRecord
{
    [FieldOffset(0x0000)] public ushort flag;
    [FieldOffset(0x0002)] public byte Race;
    [FieldOffset(0x0003)] public byte Level;
    [FieldOffset(0x0004)] public byte Params;
    [FieldOffset(0x0009)] public byte breakage;
    [FieldOffset(0x000A)] public ushort succession;
    [FieldOffset(0x000C)] public byte conception;
    [FieldOffset(0x000D)] public byte Message;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPersonaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPersonaDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatPersonaName
{
    [FieldOffset(0x0000)] public FText Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPersonaNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPersonaName> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSkillNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FText> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FDatSkillTableRecord
{
    [FieldOffset(0x0000)] public sbyte attr;
    [FieldOffset(0x0001)] public sbyte Type;
    [FieldOffset(0x0002)] public sbyte targetLv;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSkillTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatSkillTableRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FDatNormalSkillTableRecord
{
    [FieldOffset(0x0000)] public uint flag;
    [FieldOffset(0x0004)] public ushort use;
    [FieldOffset(0x0006)] public byte koukatype;
    [FieldOffset(0x0007)] public byte costtype;
    [FieldOffset(0x0008)] public ushort cost;
    [FieldOffset(0x000A)] public ushort costbase;
    [FieldOffset(0x000C)] public byte TargetType;
    [FieldOffset(0x000D)] public byte targetarea;
    [FieldOffset(0x000E)] public byte targetrule;
    [FieldOffset(0x0010)] public uint untargetbadstat;
    [FieldOffset(0x0014)] public byte hitratio;
    [FieldOffset(0x0015)] public byte targetcntmin;
    [FieldOffset(0x0016)] public byte targetcntmax;
    [FieldOffset(0x0017)] public byte hptype;
    [FieldOffset(0x0018)] public short hpn;
    [FieldOffset(0x001A)] public byte sptype;
    [FieldOffset(0x001C)] public short spn;
    [FieldOffset(0x001E)] public byte badtype;
    [FieldOffset(0x001F)] public byte badratio;
    [FieldOffset(0x0020)] public uint BadStatus;
    [FieldOffset(0x0024)] public uint support;
    [FieldOffset(0x0028)] public byte program;
    [FieldOffset(0x0029)] public byte criticalratio;
    [FieldOffset(0x002A)] public byte swoonratio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSkillNormalTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatNormalSkillTableRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x26)] 
public unsafe struct FDatAffinityDataRecord
{
    [FieldOffset(0x0000)] public ushort attr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatAffinityTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatAffinityDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatAttrNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FText> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6)] 
public unsafe struct FDatPersonaGrowthEventTable
{
    [FieldOffset(0x0000)] public byte Level;
    [FieldOffset(0x0002)] public ushort eventId;
    [FieldOffset(0x0004)] public ushort skillId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x66)] 
public unsafe struct FDatPersonaGrowthDataRecord
{
    [FieldOffset(0x0000)] public byte paramsUp;
    [FieldOffset(0x0006)] public FDatPersonaGrowthEventTable skillEvent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPersonaGrowthTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPersonaGrowthDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5)] 
public unsafe struct FDatLevelupParam
{
    [FieldOffset(0x0000)] public byte ATK;
    [FieldOffset(0x0001)] public byte MAT;
    [FieldOffset(0x0002)] public byte DEF;
    [FieldOffset(0x0003)] public byte SPD;
    [FieldOffset(0x0004)] public byte LUK;
}

[StructLayout(LayoutKind.Explicit, Size = 0x434)] 
public unsafe struct FDatAllyPersonaGrowthDataRecord
{
    [FieldOffset(0x0000)] public byte PlayerId;
    [FieldOffset(0x0001)] public byte levelMax;
    [FieldOffset(0x0002)] public FDatPersonaGrowthEventTable skillEvent;
    [FieldOffset(0x00C2)] public FDatLevelupParam paramsUp;
    [FieldOffset(0x02AC)] public uint Exp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatAllyPersonaGrowthTable
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatAllyPersonaGrowthDataRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatSupportInfoTableRecord
{
    [FieldOffset(0x0000)] public uint defineId;
    [FieldOffset(0x0004)] public uint majorId;
    [FieldOffset(0x0008)] public uint minorId;
    [FieldOffset(0x000C)] public uint characterId;
    [FieldOffset(0x0010)] public byte show;
    [FieldOffset(0x0011)] public byte Face;
    [FieldOffset(0x0012)] public byte Window;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSupportInfoTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatSupportInfoTableRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FDatRaceTableRecord
{
    [FieldOffset(0x0000)] public FText Race;
    [FieldOffset(0x0018)] public FText Community;
    [FieldOffset(0x0030)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatRaceTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatRaceTableRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FDatShuffleChoiceMinorArcanaRecord
{
    [FieldOffset(0x0000)] public byte AreaId;
    [FieldOffset(0x0004)] public int LowPersonaRankId;
    [FieldOffset(0x0008)] public int HightPersonaRankId;
    [FieldOffset(0x000C)] public int LowWandRankId;
    [FieldOffset(0x0010)] public int HightWandRankId;
    [FieldOffset(0x0014)] public int LowCoinRankId;
    [FieldOffset(0x0018)] public int HightCoinRankId;
    [FieldOffset(0x001C)] public int LowCupRankId;
    [FieldOffset(0x0020)] public int HightCupRankId;
    [FieldOffset(0x0024)] public int LowSwordRankId;
    [FieldOffset(0x0028)] public int HightSwordRankId;
    [FieldOffset(0x002C)] public int CardNumProb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleChoiceMinorArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleChoiceMinorArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9)] 
public unsafe struct FDatShuffleChoiceMajorArcanaRecord
{
    [FieldOffset(0x0000)] public byte ArcanaID;
    [FieldOffset(0x0001)] public byte RankInPhase;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleChoiceMajorArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleChoiceMajorArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FDatShufflePersonaArcanaRecord
{
    [FieldOffset(0x0000)] public byte RankID;
    [FieldOffset(0x0001)] public byte PersonaID;
    [FieldOffset(0x0002)] public byte prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShufflePersonaArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShufflePersonaArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatShuffleCoinArcanaRecord
{
    [FieldOffset(0x0000)] public uint Max;
    [FieldOffset(0x0004)] public uint Min;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleCoinArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleCoinArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatShuffleCupArcanaRecord
{
    [FieldOffset(0x0000)] public byte RankID;
    [FieldOffset(0x0001)] public byte EffectID;
    [FieldOffset(0x0004)] public uint prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleCupArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleCupArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatShuffleLoversArcanaRecord
{
    [FieldOffset(0x0000)] public ushort CommuBonus;
    [FieldOffset(0x0002)] public ushort LoversBonus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleLoversArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleLoversArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatShuffleArcanaNameRecord
{
    [FieldOffset(0x0000)] public FText Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleArcanaNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleArcanaNameRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDatShuffleCommonCoefficientArcanaRecord
{
    [FieldOffset(0x0000)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleCommonCoefficientArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleCommonCoefficientArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatShuffleCommonItemdropArcanaRecord
{
    [FieldOffset(0x0000)] public byte RankID;
    [FieldOffset(0x0001)] public byte Num;
    [FieldOffset(0x0002)] public ushort prob;
    [FieldOffset(0x0004)] public uint ItemtID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatShuffleCommonItemdropArcanaTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatShuffleCommonItemdropArcanaRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatBtlCommonName
{
    [FieldOffset(0x0000)] public FText Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatBtlCommonNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatBtlCommonName> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatCalcPANICDropItemRecord
{
    [FieldOffset(0x0000)] public FDatEnemyItemTable Item;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatCalcPANICDropItemTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatCalcPANICDropItemRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FDatCalcPANICUseItemRecord
{
    [FieldOffset(0x0000)] public ushort ItemId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatCalcPANICUseItemTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatCalcPANICUseItemRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5)] 
public unsafe struct FDatEncountEnemyBadPercentRecord
{
    [FieldOffset(0x0000)] public byte Num1;
    [FieldOffset(0x0001)] public byte Num2;
    [FieldOffset(0x0002)] public byte Num3;
    [FieldOffset(0x0003)] public byte Num4;
    [FieldOffset(0x0004)] public byte NumOver5;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatEncountEnemyBadPercentTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatEncountEnemyBadPercentRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatBtlTheurgiaBoostRecord
{
    [FieldOffset(0x0000)] public short Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatBtlTheurgiaBoostTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatBtlTheurgiaBoostRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FDatBtlMixraidReleaseRecord
{
    [FieldOffset(0x0000)] public ushort PersonaAID;
    [FieldOffset(0x0002)] public ushort PersonaBID;
    [FieldOffset(0x0004)] public uint flag;
    [FieldOffset(0x0008)] public ushort Skill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatBtlMixraidReleaseTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatBtlMixraidReleaseRecord> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ATheurgiaAnimActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlItemData
{
    [FieldOffset(0x0000)] public int IconSpr;
    [FieldOffset(0x0004)] public int ID;
    [FieldOffset(0x0008)] public int CategoryID;
    [FieldOffset(0x000C)] public int Num;
    [FieldOffset(0x0010)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FBtlDataTargetRule
{
    [FieldOffset(0x0000)] public bool Me;
    [FieldOffset(0x0001)] public bool Other;
    [FieldOffset(0x0002)] public bool Dead;
    [FieldOffset(0x0003)] public bool DownOnly;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBtlDataBaseComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UBtlEnvironmentBase
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public TArray<IntPtr> BgObjList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ABtlEventActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public bool bCompleteInit;
    [FieldOffset(0x0279)] public bool bStartScript;
    [FieldOffset(0x0280)] public UBtlEventController* pController;
    [FieldOffset(0x0288)] public int BtlEventProcNo;
    [FieldOffset(0x028C)] public bool isCommonAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct ABtlEventAlloutShuffleMonitor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0298)] public UBtlCoreComponent* pCore;
    [FieldOffset(0x02A0)] public ABtlShuffleMainBase* pShuffle;
    [FieldOffset(0x02A8)] public TSubclassOf<ABtlShuffleMainBase> ShuffleUIBp;
    [FieldOffset(0x02B0)] public UAssetLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct ABtlEventBfLoader
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public bool bCompleteInit;
    [FieldOffset(0x0280)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0288)] public UBfAsset* pBfAsset;
    [FieldOffset(0x0290)] public UBmdAsset* pBmdAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UBtlEventController
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public bool bLoadCompleted;
    [FieldOffset(0x00C9)] public bool bCommonLoadCompleted;
    [FieldOffset(0x00D0)] public UBfAsset* pBfCommonAsset;
    [FieldOffset(0x00D8)] public UBmdAsset* pBmdCommonAsset;
    [FieldOffset(0x00E0)] public UBfAsset* pBfAsset;
    [FieldOffset(0x00E8)] public UBmdAsset* pBmdAsset;
    [FieldOffset(0x00F0)] public ABtlEventActor* pEventActor;
    [FieldOffset(0x00F8)] public FBtlEncountParam EncountParam;
    [FieldOffset(0x0118)] public UBtlCoreComponent* BtlCore;
    [FieldOffset(0x0120)] public TSubclassOf<AAppActor> SequencerObserveClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBtlCutsceneHandleData
{
    [FieldOffset(0x0008)] public ULevelSequence* Scene;
    [FieldOffset(0x0010)] public UAssetLoader* Loader;
    [FieldOffset(0x0018)] public FString RowName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9B0)] 
public unsafe struct UBtlEventCutsceneController
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UDataTable* SequenceTable;
    [FieldOffset(0x0030)] public FBtlCutsceneHandleData LoadSequence;
    [FieldOffset(0x0990)] public ALevelSequenceActor* SequenceActor;
    [FieldOffset(0x0998)] public UAssetLoader* LoaderTable;
    [FieldOffset(0x09A8)] public UAssetLoader* AllLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBtlFadeParam
{
    [FieldOffset(0x0000)] public bool isFadeOut;
    [FieldOffset(0x0004)] public float NowTime;
    [FieldOffset(0x0008)] public float MaxTime;
    [FieldOffset(0x000C)] public float Param;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct ABtlFadeManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0298)] public bool isFadeing;
    [FieldOffset(0x0299)] public bool isScreenWrap;
    [FieldOffset(0x029A)] public bool isEnemyFlag;
    [FieldOffset(0x029B)] public bool isAIActionFlag;
    [FieldOffset(0x029C)] public EBtlFadeType Type;
    [FieldOffset(0x029D)] public EBtlFadeType ReceaveType;
    [FieldOffset(0x029E)] public bool bCrossFade;
    [FieldOffset(0x02A0)] public float CrossfadeTime;
    [FieldOffset(0x02A4)] public float CrossFadeMaxTime;
    [FieldOffset(0x02A8)] public bool LastFadeOut;
    [FieldOffset(0x02B0)] public TArray<FBtlFadeParam> fadeParam;
    [FieldOffset(0x02D0)] public TSubclassOf<ABtlFadeManager> LoadClass;
    [FieldOffset(0x02D8)] public UAssetLoader* pLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ABtlFormationPoint
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public bool IsForEnemies;
    [FieldOffset(0x0221)] public EBtlFormationSizeType SizeCategory;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UBtlGuiAnalyzeComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public UBmdAsset* BmdAsset;
    [FieldOffset(0x00D0)] public UAssetLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FBtlGuiDrawFlag
{
    [FieldOffset(0x0000)] public bool InheritScale;
    [FieldOffset(0x0001)] public bool InheritAngle;
    [FieldOffset(0x0002)] public bool InheritColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UBtlGuiDrawObjectCore
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool Visible;
    [FieldOffset(0x002C)] public int grpNo;
    [FieldOffset(0x0040)] public TArray<IntPtr> childObject;
    [FieldOffset(0x0050)] public FBtlGuiDrawFlag drawFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBtlGuiDrawObjectClearScreen
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FColor Color;
    [FieldOffset(0x005C)] public EBtlGuiOT OT;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FBtlBlendState
{
    [FieldOffset(0x0000)] public EBtlGuiBlendOp OpColor;
    [FieldOffset(0x0001)] public EBtlGuiBlendFactor SrcColor;
    [FieldOffset(0x0002)] public EBtlGuiBlendFactor DstColor;
    [FieldOffset(0x0003)] public EBtlGuiBlendOp OpAlpha;
    [FieldOffset(0x0004)] public EBtlGuiBlendFactor SrcAlpha;
    [FieldOffset(0x0005)] public EBtlGuiBlendFactor DstAlpha;
    [FieldOffset(0x0006)] public EBtlGuiColorWhiteMask ColorWMask;
    [FieldOffset(0x0007)] public EBtlGuiOT OT;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FBtlGuiDrawStructCore
{
    [FieldOffset(0x0000)] public FVector2D Pos;
    [FieldOffset(0x0008)] public FVector2D Scale;
    [FieldOffset(0x0010)] public float Angle;
    [FieldOffset(0x0014)] public EBtlGuiAnchorPt anchor;
    [FieldOffset(0x0018)] public FVector2D scaleAnchorPos;
    [FieldOffset(0x0020)] public FVector2D angleAnchorPos;
    [FieldOffset(0x0028)] public FColor Color;
    [FieldOffset(0x002C)] public FBtlBlendState blendState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FBtlGuiDrawImage
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public UTexture* Texture;
    [FieldOffset(0x0040)] public float Width;
    [FieldOffset(0x0044)] public float Height;
    [FieldOffset(0x0048)] public EBtlGuiDrawType drawType;
    [FieldOffset(0x0050)] public FVector4 UV;
    [FieldOffset(0x0060)] public bool RevHorizontal;
    [FieldOffset(0x0061)] public bool RevVertical;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UBtlGuiDrawObjectImage
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0060)] public FBtlGuiDrawImage Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FBtlGuiDrawPanel
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0034)] public float Width;
    [FieldOffset(0x0038)] public float Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBtlGuiDrawObjectPanel
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FBtlGuiDrawPanel Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FBtlGuiDrawText
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public FString str;
    [FieldOffset(0x0048)] public EBtlGuiTextType textType;
    [FieldOffset(0x0049)] public EBtlGuiFontStyle fontStyle;
    [FieldOffset(0x004C)] public FVector2D adjustedScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UBtlGuiDrawObjectText
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0060)] public FBtlGuiDrawText Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FBtlGuiDrawMsg
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public UBmdAsset* bmd;
    [FieldOffset(0x0050)] public int msgNo;
    [FieldOffset(0x0058)] public int pageNo;
    [FieldOffset(0x005C)] public int msgLine;
    [FieldOffset(0x0064)] public EBtlGuiTextType textType;
    [FieldOffset(0x0065)] public EBtlGuiFontStyle fontStyle;
    [FieldOffset(0x0068)] public float lineBreak;
    [FieldOffset(0x006C)] public int MaxRow;
    [FieldOffset(0x0070)] public FVector2D adjustedScale;
    [FieldOffset(0x0078)] public float RowOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UBtlGuiDrawObjectMsg
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0060)] public FBtlGuiDrawMsg Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBtlGuiDrawRect
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0040)] public FVector4 rect;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UBtlGuiDrawObjectRect
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0080)] public FBtlGuiDrawRect Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBtlGuiDrawSprite
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public USprAsset* Sprite;
    [FieldOffset(0x0040)] public int grpNo;
    [FieldOffset(0x0044)] public int SprNo;
    [FieldOffset(0x0048)] public EBtlGuiDrawType drawType;
    [FieldOffset(0x0049)] public bool RevHorizontal;
    [FieldOffset(0x004A)] public bool RevVertical;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UBtlGuiDrawObjectSprite
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0088)] public FBtlGuiDrawSprite Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FBtlGuiDrawMaterial
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0040)] public FVector4 rect;
    [FieldOffset(0x0050)] public UMaterialInterface* Material;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UBtlGuiDrawObjectMaterial
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0060)] public FBtlGuiDrawMaterial Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FBtlGuiDrawPlg
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public UPlgAsset* plg;
    [FieldOffset(0x0040)] public int plgNo;
    [FieldOffset(0x0044)] public bool reverseAlpha;
    [FieldOffset(0x0045)] public bool inverseX;
    [FieldOffset(0x0046)] public bool isMultiMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UBtlGuiDrawObjectPlg
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FBtlGuiDrawPlg Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FBtlGuiVertex
{
    [FieldOffset(0x0000)] public FVector2D Pos;
    [FieldOffset(0x0008)] public FColor Color;
    [FieldOffset(0x000C)] public FVector2D UV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FBtlGuiDrawPrimitive
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public TArray<FBtlGuiVertex> vertex;
    [FieldOffset(0x0048)] public UTexture* Texture;
    [FieldOffset(0x0054)] public bool useAnriAlias;
    [FieldOffset(0x0055)] public bool SkipAntiFirstVtx;
    [FieldOffset(0x0056)] public bool reverseAlpha;
    [FieldOffset(0x0057)] public bool vertexLeftTurn;
    [FieldOffset(0x0058)] public EBtlGuiDrawType drawType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UBtlGuiDrawObjectPrimitive
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FBtlGuiDrawPrimitive Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FBtlGuiDrawLineFrame
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public TArray<FBtlGuiVertex> vertex;
    [FieldOffset(0x0048)] public float lineLength;
    [FieldOffset(0x0050)] public bool useAnriAlias;
    [FieldOffset(0x0051)] public bool reverseAlpha;
    [FieldOffset(0x0052)] public bool vertexLeftTurn;
    [FieldOffset(0x0053)] public bool outStretch;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UBtlGuiDrawObjectLineFrame
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FBtlGuiDrawLineFrame Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBtlGuiDrawRoundRect
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0034)] public float Width;
    [FieldOffset(0x0038)] public float Height;
    [FieldOffset(0x003C)] public int Round;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UBtlGuiDrawObjectRoundRect
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0058)] public FBtlGuiDrawRoundRect Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FBtlGuiDrawSilhouette
{
    [FieldOffset(0x0000)] public FBtlGuiDrawStructCore baseObj;
    [FieldOffset(0x0038)] public UTexture* Texture;
    [FieldOffset(0x0040)] public float Width;
    [FieldOffset(0x0044)] public float Height;
    [FieldOffset(0x0050)] public FVector4 UV;
    [FieldOffset(0x0060)] public bool reverseAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UBtlGuiDrawObjectSilhouette
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectCore baseObj;
    [FieldOffset(0x0060)] public FBtlGuiDrawSilhouette Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UBtlGuiDrawComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public EBtlGuiCanvas canvasType;
    [FieldOffset(0x00D0)] public TArray<IntPtr> ItemAry;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UBtlEncountWipeLoader
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public UAssetLoader* pLoader;
    [FieldOffset(0x0050)] public ACharacter* Chara;
    [FieldOffset(0x0070)] public TSubclassOf<ABtlEncountWipeCore> EncountBp;
    [FieldOffset(0x0078)] public TSubclassOf<ABtlEncountWipeCore> EventEncountBp;
    [FieldOffset(0x0080)] public TSubclassOf<ABtlEncountWipeCore> PinthEncountBp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ABtlEncountWipeCore
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public bool requestWipeOut;
    [FieldOffset(0x0289)] public bool isWraped;
    [FieldOffset(0x028A)] public bool isSequenceEnable;
    [FieldOffset(0x028B)] public EBtlEncountWipeType wipeType;
    [FieldOffset(0x0290)] public UBtlCoreComponent* Core;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct ABtlGuiEncountWipe
{
    [FieldOffset(0x0000)] public ABtlEncountWipeCore baseObj;
    [FieldOffset(0x02A0)] public ACharacter* Chara;
    [FieldOffset(0x02A8)] public bool IsEnd;
    [FieldOffset(0x02AC)] public FVector startLine;
    [FieldOffset(0x02B8)] public FVector endLine;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ABtlGuiPinchEncountWipe
{
    [FieldOffset(0x0000)] public ABtlEncountWipeCore baseObj;
    [FieldOffset(0x02A0)] public bool IsEnd;
    [FieldOffset(0x02A1)] public bool IsAnimation;
    [FieldOffset(0x02A2)] public bool isTexDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ABtlGuiEventEncountWipe
{
    [FieldOffset(0x0000)] public ABtlEncountWipeCore baseObj;
    [FieldOffset(0x02A0)] public bool IsEnd;
    [FieldOffset(0x02A1)] public bool IsAnimation;
    [FieldOffset(0x02A2)] public bool isTexDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ABtlGuiFBufferCapture
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TSubclassOf<ABtlGuiFBufferCapture> LoadClass;
    [FieldOffset(0x0280)] public UAssetLoader* pLoader;
    [FieldOffset(0x0288)] public bool isSetupCompleted;
    [FieldOffset(0x0289)] public bool isDraw;
    [FieldOffset(0x028A)] public bool is2DCapture;
    [FieldOffset(0x028C)] public float animationTime;
    [FieldOffset(0x0290)] public float endAnimationTime;
    [FieldOffset(0x0294)] public float endGtayScale;
    [FieldOffset(0x0298)] public float endWhiteOut;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlGuiIconDamage
{
    [FieldOffset(0x0000)] public ABtlActor* pTarget;
    [FieldOffset(0x0008)] public int Damage;
    [FieldOffset(0x000C)] public int DamageSP;
    [FieldOffset(0x0010)] public EBtlGuiIconHit Hit;
    [FieldOffset(0x0011)] public EBtlGuiIconDamageType DamageType;
    [FieldOffset(0x0012)] public bool isPortionDamage;
    [FieldOffset(0x0013)] public bool isBadStatus;
    [FieldOffset(0x0014)] public bool isBadStatusRecovery;
    [FieldOffset(0x0015)] public bool isEndure;
    [FieldOffset(0x0018)] public float Delay;
    [FieldOffset(0x001C)] public float StepEndureRadio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UBtlGuiIconComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UBtlGuiListComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UBtlGuiPersonaStatusComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public APersonaStatus* pActor;
    [FieldOffset(0x00D0)] public ABtlActor* pFirstCharacter;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBtlGuiPromiseComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ABtlGuiResourcesBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x350)] 
public unsafe struct ABtlGuiResourcesActor
{
    [FieldOffset(0x0000)] public ABtlGuiResourcesBase baseObj;
    [FieldOffset(0x02A0)] public UObject* pLoadAsset;
    [FieldOffset(0x02A8)] public UAssetLoader* pLoader;
    [FieldOffset(0x02B0)] public FString StackLoadPath;
    [FieldOffset(0x02C0)] public UUILayoutDataTable* pItemSkillListTextDataTable;
    [FieldOffset(0x02C8)] public UUILayoutDataTable* pTargetInfoTextDataTable;
    [FieldOffset(0x02D0)] public UUILayoutDataTable* pTacticsListTextDataTable;
    [FieldOffset(0x02D8)] public UUILayoutDataTable* pTheurgiaDataTable;
    [FieldOffset(0x02E0)] public UUILayoutDataTable* pTacticsDataTable;
    [FieldOffset(0x02E8)] public UUILayoutDataTable* pTopDataTable;
    [FieldOffset(0x02F0)] public UUILayoutDataTable* pGuardDataTable;
    [FieldOffset(0x02F8)] public UUILayoutDataTable* pTheurgiaTextDataTable;
    [FieldOffset(0x0300)] public UUILayoutDataTable* pTheurgiaTextRowDataTable;
    [FieldOffset(0x0308)] public UUILayoutDataTable* pTheurgiaTextPosDataTable;
    [FieldOffset(0x0310)] public UUILayoutDataTable* pTacticsCheckDataTable;
    [FieldOffset(0x0318)] public UUILayoutDataTable* pPromiseDataTable;
    [FieldOffset(0x0320)] public UUILayoutDataTable* pAnalyzeDataTable;
    [FieldOffset(0x0328)] public UUILayoutDataTable* pAnalyzeTextDataTable;
    [FieldOffset(0x0330)] public UUILayoutDataTable* pDamageIconDataTable;
    [FieldOffset(0x0338)] public UUILayoutDataTable* pRushDataTable;
    [FieldOffset(0x0340)] public UUILayoutDataTable* pOthersDataTable;
    [FieldOffset(0x0348)] public UUILayoutDataTable* pTouchCollDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ABtlGuiResourcesLoadWatcher
{
    [FieldOffset(0x0000)] public ABtlGuiResourcesBase baseObj;
    [FieldOffset(0x0290)] public TSubclassOf<ABtlGuiResourcesActor> LoadClass;
    [FieldOffset(0x0298)] public UAssetLoader* pLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UBtlGuiResources
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FBtlGuiRushEffectParam
{
    [FieldOffset(0x0000)] public float Intensity_float;
    [FieldOffset(0x0004)] public float LineDensity_float;
    [FieldOffset(0x0008)] public float LineThershold_float;
    [FieldOffset(0x000C)] public float LineWidthX_float;
    [FieldOffset(0x0010)] public float LineWidthY_float;
    [FieldOffset(0x0014)] public float MaskWidth_float;
    [FieldOffset(0x0018)] public float Speed_float;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct ABtlGuiRushEffect
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UMaterialInterface* Material;
    [FieldOffset(0x0280)] public UMaterialInstanceDynamic* DynamicMaterial;
    [FieldOffset(0x0288)] public UMaterialParameterCollection* MPC;
    [FieldOffset(0x0294)] public int switchState;
    [FieldOffset(0x0298)] public int materialOt;
    [FieldOffset(0x029C)] public int renderOt;
    [FieldOffset(0x02A0)] public UAssetLoader* pLoader;
    [FieldOffset(0x02A8)] public bool bEffectEnable;
    [FieldOffset(0x02A9)] public bool bAnimationPause;
    [FieldOffset(0x02AA)] public bool bLoadComlpeted;
    [FieldOffset(0x02AB)] public bool bBtlFlag;
    [FieldOffset(0x02AC)] public FBtlGuiRushEffectParam defaultEffectParam;
    [FieldOffset(0x02C8)] public float maskWidth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AEventSkipEffect
{
    [FieldOffset(0x0000)] public ABtlGuiRushEffect baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct ABtlGuiStateManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EBtlGuiState nowState;
    [FieldOffset(0x0279)] public EBtlGuiState prevState;
    [FieldOffset(0x0280)] public TArray<EBtlGuiState> StateList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBtlInputKeyParam
{
    [FieldOffset(0x0000)] public bool ru;
    [FieldOffset(0x0001)] public bool OK;
    [FieldOffset(0x0002)] public bool RL;
    [FieldOffset(0x0003)] public bool CANCEL;
    [FieldOffset(0x0004)] public bool LU;
    [FieldOffset(0x0005)] public bool LR;
    [FieldOffset(0x0006)] public bool LL;
    [FieldOffset(0x0007)] public bool LD;
    [FieldOffset(0x0008)] public bool R1;
    [FieldOffset(0x0009)] public bool L1;
    [FieldOffset(0x000A)] public bool R2;
    [FieldOffset(0x000B)] public bool L2;
    [FieldOffset(0x000C)] public bool R3;
    [FieldOffset(0x000D)] public bool L3;
    [FieldOffset(0x000E)] public bool OPTION;
    [FieldOffset(0x000F)] public bool Touch;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBtlInputKey
{
    [FieldOffset(0x0000)] public FBtlInputKeyParam Trig;
    [FieldOffset(0x0010)] public FBtlInputKeyParam Press;
    [FieldOffset(0x0020)] public FBtlInputKeyParam Rep;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UBtlInputComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00EB)] public FBtlInputKey InputKey;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct ABtlManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public ABtlControlBase* Control;
    [FieldOffset(0x0280)] public UAssetLoader* Loader;
    [FieldOffset(0x0290)] public TSubclassOf<ABtlControlBase> ControlAsset;
    [FieldOffset(0x0298)] public FBtlEncountParam Param;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ABtlControlBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UBtlCoreComponent* BtlCore;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBtlOrder
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> InterruptList;
    [FieldOffset(0x0038)] public TArray<IntPtr> StandbyList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ABtlPerformanceMonitor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ABtlPhase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EBtlPhaseType Type;
    [FieldOffset(0x0279)] public bool ImplementInBP;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ABtlPhaseVictory
{
    [FieldOffset(0x0000)] public ABtlPhase baseObj;
    [FieldOffset(0x0288)] public UBtlCompensation* CompensationData;
    [FieldOffset(0x0290)] public UBtlCoreComponent* BtlCore;
}

[StructLayout(LayoutKind.Explicit, Size = 0x570)] 
public unsafe struct ABtlPhaseResult
{
    [FieldOffset(0x0000)] public ABtlPhaseVictory baseObj;
    [FieldOffset(0x0360)] public ABtlResultSceneBase* _sceneBase;
    [FieldOffset(0x0368)] public ABtlResultUIBase* _uiBase;
    [FieldOffset(0x0370)] public UBtlResultViewData* _ViewData;
    [FieldOffset(0x0378)] public ABtlShuffleMainBase* _ShuffleMain;
    [FieldOffset(0x0380)] public UBtlGuiDrawObjectRect* ReactBackGround;
    [FieldOffset(0x0388)] public TSubclassOf<ABtlResultUIBase> ResutlUIBp;
    [FieldOffset(0x0390)] public TSubclassOf<ABtlShuffleMainBase> ShuffleUIBp;
    [FieldOffset(0x0398)] public UAssetLoader* Loader;
    [FieldOffset(0x03A8)] public ABtlPhase* PhaseVictory;
    [FieldOffset(0x03B0)] public bool hasVictoryPhase;
    [FieldOffset(0x03B1)] public bool isStartResultInVictory;
    [FieldOffset(0x03B2)] public bool ReadyForExitByVictoryPhase;
    [FieldOffset(0x0558)] public TArray<IntPtr> FoundActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UBtlResidentDataBase
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public UNiagaraSystem* SummonVFX;
    [FieldOffset(0x00D0)] public UNiagaraSystem* SummonShellVFX;
    [FieldOffset(0x00D8)] public UNiagaraSystem* HitSlashVFX;
    [FieldOffset(0x00E0)] public UNiagaraSystem* HitPierceVFX;
    [FieldOffset(0x00E8)] public UNiagaraSystem* HitStrikeVFX;
    [FieldOffset(0x00F0)] public UNiagaraSystem* ReflectionVFX;
    [FieldOffset(0x00F8)] public UNiagaraSystem* AbsorptionVFX;
    [FieldOffset(0x0100)] public UNiagaraSystem* PersonaAuraVFX;
    [FieldOffset(0x0108)] public UNiagaraSystem* PersonaAuraShineVFX;
    [FieldOffset(0x0110)] public UNiagaraSystem* ShadowSummonVFX;
    [FieldOffset(0x0118)] public UNiagaraSystem* ShadowDeadVFX;
    [FieldOffset(0x0120)] public UNiagaraSystem* ShadowDeadSplashVFX;
    [FieldOffset(0x0128)] public UNiagaraSystem* HitPierceVFX_YukariCritical;
    [FieldOffset(0x0130)] public UAssetLoader* Loader;
    [FieldOffset(0x0138)] public bool LoadedResidentData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x400)] 
public unsafe struct ABtlResultResourceManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TSubclassOf<ABtlResultUIBase> ResutlUIBp;
    [FieldOffset(0x0280)] public TSubclassOf<ABtlShuffleMainBase> ShuffleUIBp;
    [FieldOffset(0x0288)] public UBmdAsset* MessageBmd;
    [FieldOffset(0x0290)] public USprAsset* SprShuffle;
    [FieldOffset(0x0298)] public UPlgAsset* PlgShuffle;
    [FieldOffset(0x02A0)] public UAnimSequenceBase* AnimCardInSequence;
    [FieldOffset(0x02E0)] public UAnimSequenceBase* AnimCardIn;
    [FieldOffset(0x0308)] public UNiagaraSystem* CardSelectEffect;
    [FieldOffset(0x0310)] public UNiagaraSystem* CardBonusEffect;
    [FieldOffset(0x0318)] public ABtlShuffleArcanaManager* ArcanaManager;
    [FieldOffset(0x03B0)] public UTexture* AllGetDownTexture;
    [FieldOffset(0x03D0)] public USprAsset* SprResult;
    [FieldOffset(0x03D8)] public UBmdAsset* BmdResult;
    [FieldOffset(0x03E0)] public AAppPropsCardContainer* CardContainer;
    [FieldOffset(0x03F0)] public UAssetLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ABtlResultSceneBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBtlResultPersonaParam
{
    [FieldOffset(0x0000)] public int PersonaID;
    [FieldOffset(0x0004)] public int Level;
    [FieldOffset(0x0008)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBtlResultItemParam
{
    [FieldOffset(0x0000)] public int ID;
    [FieldOffset(0x0004)] public int Num;
    [FieldOffset(0x0008)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBtlResultHeroInfo
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public int Hp;
    [FieldOffset(0x0014)] public int MaxHp;
    [FieldOffset(0x0018)] public int Sp;
    [FieldOffset(0x001C)] public int MaxSp;
    [FieldOffset(0x0020)] public long NextExp;
    [FieldOffset(0x0028)] public int EquipRaceNo;
    [FieldOffset(0x002C)] public int EquipPersonaLevel;
    [FieldOffset(0x0030)] public FString EquipPersonaName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBtlResultAllyLvupParam
{
    [FieldOffset(0x0000)] public int PlayerId;
    [FieldOffset(0x0004)] public int Level;
    [FieldOffset(0x0008)] public bool isLevelUp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct ABtlResultUIBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UBtlResultViewData* _ViewData;
    [FieldOffset(0x0280)] public bool isShowPlusWindos;
    [FieldOffset(0x0288)] public bool isCreateMsgWindow;
    [FieldOffset(0x0290)] public TArray<IntPtr> FoundActors;
    [FieldOffset(0x02B8)] public byte ShowingPersonaNum;
    [FieldOffset(0x02B9)] public byte ShowingPlayerNum;
    [FieldOffset(0x02BA)] public bool IsEndPersonaStatus;
    [FieldOffset(0x02BB)] public bool isEndHeroPersona;
    [FieldOffset(0x02BC)] public bool isEndAllyPersona;
    [FieldOffset(0x02C0)] public APersonaStatus* _PersonaStatusActor;
    [FieldOffset(0x02C8)] public UAssetLoader* Loader;
    [FieldOffset(0x02D0)] public USprAsset* SprResult;
    [FieldOffset(0x02D8)] public UBmdAsset* BmdResult;
    [FieldOffset(0x02E0)] public UTexture* EquipPersonaTexture;
    [FieldOffset(0x02E8)] public ABtlResultResourceManager* ResultResource;
    [FieldOffset(0x02F0)] public bool isEndPrepare;
    [FieldOffset(0x02F8)] public UDataTable* LayoutData;
    [FieldOffset(0x0300)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0308)] public UDataTable* TextLayoutData;
    [FieldOffset(0x0310)] public UUILayoutDataTable* TextLayoutDataTable;
    [FieldOffset(0x0318)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x0320)] public UUILayoutDataTable* OkNextLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UBtlResultViewData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public long Exp;
    [FieldOffset(0x0030)] public long money;
    [FieldOffset(0x0050)] public TArray<byte> PartyAfterLevel;
    [FieldOffset(0x0060)] public bool HeroStatusShowFlag;
    [FieldOffset(0x0088)] public bool isBonusExpArcana;
    [FieldOffset(0x0089)] public bool isBonusExpTheurgia;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct ABtlScriptCommandEventBattle
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct ABtlSequencerObserve
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct ABtlShakeManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TArray<TSubclassOf<UMatineeCameraShake>> PresetShakeClass;
    [FieldOffset(0x0288)] public UAssetLoader* Loader;
    [FieldOffset(0x0290)] public ABtlShakeManager* childActor;
    [FieldOffset(0x0298)] public TSubclassOf<ABtlShakeManager> ShakeAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct ABtlShuffleArcanaManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TArray<int> RemainMajorArcana;
    [FieldOffset(0x0288)] public TArray<int> RemainMinorArcana;
    [FieldOffset(0x02A8)] public TArray<IntPtr> FoundActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FShuffleCardInfo
{
    [FieldOffset(0x0000)] public AAppPropsCore* Card;
    [FieldOffset(0x0008)] public FVector Pos;
    [FieldOffset(0x0014)] public FVector PosBase;
    [FieldOffset(0x0020)] public FVector PosAllMove;
    [FieldOffset(0x002C)] public FVector PosWaittingMove;
    [FieldOffset(0x0038)] public FVector SpeedWatting;
    [FieldOffset(0x0044)] public float BaseRotX;
    [FieldOffset(0x0048)] public float BaseRotZ;
    [FieldOffset(0x004C)] public float RotationX;
    [FieldOffset(0x0050)] public float RotationZ;
    [FieldOffset(0x0054)] public float SppedRotationX;
    [FieldOffset(0x0058)] public float SppedRotationZ;
    [FieldOffset(0x005C)] public FVector PosMoveFrom;
    [FieldOffset(0x0068)] public FVector PosMoveTo;
    [FieldOffset(0x0074)] public float RotMoveXFrom;
    [FieldOffset(0x0078)] public float RotMoveXTo;
    [FieldOffset(0x007C)] public float RotMoveZFrom;
    [FieldOffset(0x0080)] public float RotMoveZTo;
    [FieldOffset(0x0084)] public float MoveLerpValue;
    [FieldOffset(0x0088)] public EBtlShuffleCardState MoveAfterState;
    [FieldOffset(0x008C)] public float MoveTime;
    [FieldOffset(0x0090)] public EBtlShuffleCardState State;
    [FieldOffset(0x0091)] public bool Moving;
    [FieldOffset(0x0092)] public bool isOutAnimeSelectEffect;
    [FieldOffset(0x0094)] public float SelectEffectAlpha;
    [FieldOffset(0x0098)] public EBtlShuffleCardEffectSelectState EffectSelectState;
    [FieldOffset(0x009C)] public float ValueCardRotation;
    [FieldOffset(0x00A0)] public float TimeWaitCardRotation;
    [FieldOffset(0x00A4)] public EBtlShuffleCardRotationState StateCardRotation;
    [FieldOffset(0x00A5)] public bool IsTickCard;
    [FieldOffset(0x00A6)] public bool IsStartMajorAppear;
    [FieldOffset(0x00A8)] public float RotationMajorAppear;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF58)] 
public unsafe struct ABtlShuffleMainBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x030C)] public int SelectCoursorIndex;
    [FieldOffset(0x0310)] public int ShowCardsMax;
    [FieldOffset(0x0314)] public int EnableSelectNum;
    [FieldOffset(0x0318)] public bool IsFirstSelect;
    [FieldOffset(0x0319)] public bool IsStopButton;
    [FieldOffset(0x033C)] public int SelectedCardNum;
    [FieldOffset(0x0340)] public int ActionCardIndex;
    [FieldOffset(0x0344)] public bool IsStartMajorArcanaEffect;
    [FieldOffset(0x0345)] public EBtlShuffleCardState EffectMessagePage;
    [FieldOffset(0x0348)] public int PersonaSelectCoursorIndex;
    [FieldOffset(0x034C)] public int PersonaSelectState;
    [FieldOffset(0x0352)] public bool IsStartCharaAnime;
    [FieldOffset(0x0358)] public int AllGetBonousMessageIndex;
    [FieldOffset(0x035C)] public EBtlShuffleCardState AllGetBonousEffectMessageIndex;
    [FieldOffset(0x035D)] public bool isEndCardInAnime;
    [FieldOffset(0x035E)] public bool isEndPersonaListInFlag;
    [FieldOffset(0x035F)] public bool isEndArcanaBurstInFlag;
    [FieldOffset(0x0368)] public TArray<byte> AppearMajors;
    [FieldOffset(0x0390)] public UAssetLoader* Loader;
    [FieldOffset(0x0398)] public USprAsset* SprShuffle;
    [FieldOffset(0x03A0)] public UPlgAsset* PlgShuffle;
    [FieldOffset(0x03A8)] public UTutorialManager* pTutorialManager;
    [FieldOffset(0x03B0)] public UBmdAsset* MessageBmd;
    [FieldOffset(0x03B8)] public UTexture* AllGetDownTexture;
    [FieldOffset(0x03D8)] public UBtlGuiDrawObjectMsg* MsgShuffle;
    [FieldOffset(0x03E0)] public UBtlCompensation* CompensationData;
    [FieldOffset(0x03E8)] public ABtlShuffleArcanaManager* ArcanaManager;
    [FieldOffset(0x03F8)] public UBtlShufflePersonaList* PersonaList;
    [FieldOffset(0x0DC0)] public UAnimSequenceBase* AnimCardInSequence;
    [FieldOffset(0x0E00)] public UAnimSequenceBase* AnimCardIn;
    [FieldOffset(0x0E28)] public UNiagaraSystem* CardSelectEffect;
    [FieldOffset(0x0E30)] public UNiagaraSystem* CardBonusEffect;
    [FieldOffset(0x0E38)] public AAppPropsCardContainer* CardContainer;
    [FieldOffset(0x0E40)] public TArray<FShuffleCardInfo> CardInfos;
    [FieldOffset(0x0E88)] public APersonaStatus* _PersonaStatusActor;
    [FieldOffset(0x0ED0)] public ABtlResultResourceManager* ResultResource;
    [FieldOffset(0x0EE0)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0EE8)] public UUILayoutDataTable* TextLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA50)] 
public unsafe struct UBtlShufflePersonaList
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBtlSkillParam
{
    [FieldOffset(0x0000)] public UNiagaraSystem* VFX;
    [FieldOffset(0x0008)] public EBtlSkillTargetType TargetType;
    [FieldOffset(0x0009)] public EBtlSkillPositionTargetType PositionType;
    [FieldOffset(0x000A)] public EBtlSkillPositionHeightType PositionHeight;
    [FieldOffset(0x000B)] public EBtlSkillDirectionTargetType Direction;
    [FieldOffset(0x000C)] public float Scale;
    [FieldOffset(0x0010)] public float StartTime;
    [FieldOffset(0x0014)] public float IntervalTime;
    [FieldOffset(0x0018)] public bool IsDamageEffect;
    [FieldOffset(0x0020)] public USoundAtomCue* SkillSE;
    [FieldOffset(0x0028)] public float SEVolumeRatio;
    [FieldOffset(0x002C)] public bool SE_UseCameraRangeParam;
    [FieldOffset(0x0030)] public float SE_CameraRangeMaxCM;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBtlSkillCameraEffectParam
{
    [FieldOffset(0x0000)] public UNiagaraCameraAttachComponent* CameraEffect;
    [FieldOffset(0x0008)] public float StartTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct ABtlSkill
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TArray<FBtlSkillParam> EffectList;
    [FieldOffset(0x0288)] public float DestroyTime;
    [FieldOffset(0x028C)] public float DamageTime;
    [FieldOffset(0x0290)] public bool WaitUntilDestroy;
    [FieldOffset(0x0298)] public FBtlSkillCameraEffectParam CameraEffect;
    [FieldOffset(0x02A8)] public bool QuickAbsorptionEffectWhenAbsorptionOnly;
    [FieldOffset(0x02AC)] public float EnvAnimTime;
    [FieldOffset(0x02B0)] public bool UseLightEnvParam;
    [FieldOffset(0x02B4)] public float LightIntensityRatio;
    [FieldOffset(0x02B8)] public bool UseFogEnvParam;
    [FieldOffset(0x02BC)] public float FogPower;
    [FieldOffset(0x02C0)] public float FogDistance;
    [FieldOffset(0x02C4)] public float FogGradationRange;
    [FieldOffset(0x02C8)] public bool UseBGBlack;
    [FieldOffset(0x02CC)] public float BGBlackPower;
    [FieldOffset(0x02D0)] public bool IsOnlyAbsorptionMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UBtlSkillGeneratorComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00C0)] public ABtlSkill* pSkill;
    [FieldOffset(0x00C8)] public TSubclassOf<ABtlSkill> SkillAsset;
    [FieldOffset(0x00D0)] public UAssetLoader* Loader;
    [FieldOffset(0x00D8)] public bool LoadRequested;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBtlSoundBPFuncLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlSpecificEventBattle
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBtlSupportInfoBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UBtlSupportInfoMessage* SupportInfoMessage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBtlSupportInfoCommonOnly
{
    [FieldOffset(0x0000)] public UBtlSupportInfoBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBtlSupportInfoFuka
{
    [FieldOffset(0x0000)] public UBtlSupportInfoBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UBtlSupportInfoMessage
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UBmdAsset* commonBmdAsset;
    [FieldOffset(0x0030)] public UBmdAsset* currentNaviBmdAsset;
    [FieldOffset(0x0038)] public UDatSupportInfo* commonDataAsset;
    [FieldOffset(0x0040)] public UDatSupportInfo* currentNaviDataAsset;
    [FieldOffset(0x0048)] public UAssetLoader* Loader;
    [FieldOffset(0x0070)] public FString CommonBmdpath;
    [FieldOffset(0x0080)] public FString CommonTablepath;
    [FieldOffset(0x0090)] public FString CurrentNaviBmdpath;
    [FieldOffset(0x00A0)] public FString CurrentNaviTablepath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBtlSupportInfoMituru
{
    [FieldOffset(0x0000)] public UBtlSupportInfoBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBtlSupportSound
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBtlTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UBtlTargetsManagerComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Targets;
    [FieldOffset(0x00D8)] public TArray<IntPtr> EffectTargets;
    [FieldOffset(0x00E8)] public TArray<IntPtr> CursorTargets;
    [FieldOffset(0x00F8)] public ABtlActor* MainCharacter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlTutorialBase
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlTutorial1st
{
    [FieldOffset(0x0000)] public UBtlTutorialBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlTutorial2nd
{
    [FieldOffset(0x0000)] public UBtlTutorialBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UBtlTutorial3rd
{
    [FieldOffset(0x0000)] public UBtlTutorialBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBtlTutorialTheurgia
{
    [FieldOffset(0x0000)] public UBtlBoss baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBtlVoicePlayWatcher
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBtlVoice
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0058)] public ABtlActor* Character;
    [FieldOffset(0x0060)] public UBtlCoreComponent* Core;
    [FieldOffset(0x0068)] public UBtlVoicePlayWatcher* Watcher;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBtlPcVoice
{
    [FieldOffset(0x0000)] public UBtlVoice baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBtlBossVoice
{
    [FieldOffset(0x0000)] public UBtlVoice baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBtlBossStregaVoice
{
    [FieldOffset(0x0000)] public UBtlBossVoice baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UBtlBossNyxAvatarVoice
{
    [FieldOffset(0x0000)] public UBtlBossVoice baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UBustupController
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UBustupModel* pModel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UBustupObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UMaterialInterface* BaseMaterial_;
    [FieldOffset(0x0030)] public UMaterialInstanceDynamic* DrawableMaterial_;
    [FieldOffset(0x0040)] public UTexture* BaseTex_;
    [FieldOffset(0x0048)] public UTexture* ShadowMask_;
    [FieldOffset(0x0050)] public UTexture* RimLightMask_;
    [FieldOffset(0x0058)] public UTexture* EyeTex_;
    [FieldOffset(0x0070)] public UTexture* MouthTex_;
    [FieldOffset(0x0088)] public UTexture* BlushTex_;
    [FieldOffset(0x0090)] public UTexture* SweatTex_;
    [FieldOffset(0x0098)] public UTexture* BaseMask_;
    [FieldOffset(0x00A0)] public UTexture* DropMask_;
    [FieldOffset(0x00A8)] public UAssetLoader* Loader_;
    [FieldOffset(0x0118)] public UBustupAnimDataAsset* BustupAnim_;
    [FieldOffset(0x0120)] public USupportBustupDataAsset* SupportBustupOffset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBustupObjectBuffer
{
    [FieldOffset(0x0000)] public UBustupObject* BustupObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UBustupDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public UBustupObject* BustupObject_;
    [FieldOffset(0x0040)] public UBustupObject* PrevBustupObject_;
    [FieldOffset(0x0048)] public TArray<FBustupObjectBuffer> ObjectBuffer_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UBustupModel
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UBustupDraw* pBustupDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FAppCalculationItem
{
    [FieldOffset(0x0000)] public float SrcValue;
    [FieldOffset(0x0004)] public float DstValue;
    [FieldOffset(0x0008)] public int Delay;
    [FieldOffset(0x000C)] public int DstFrame;
    [FieldOffset(0x0010)] public appCalculationType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAppCalculaterComponentWork
{
    [FieldOffset(0x0000)] public float Timer;
    [FieldOffset(0x0008)] public TArray<FAppCalculationItem> List;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UAppCalculaterComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UCalendar
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0090)] public ACldBindingEventActor* mEventActor_;
    [FieldOffset(0x0098)] public uint mChangeFlag_;
    [FieldOffset(0x009C)] public ECldSceneChangeType mChangeType_;
    [FieldOffset(0x009D)] public ECldSceneChangeType mChangeSetted_;
    [FieldOffset(0x00A0)] public int mChangePrevDay_;
    [FieldOffset(0x00A4)] public ECldTimeZone mChangePrevTimeZone_;
    [FieldOffset(0x00A8)] public int mChangeNextDay_;
    [FieldOffset(0x00AC)] public ECldTimeZone mChangeNextTimeZone_;
    [FieldOffset(0x00B0)] public int cursorDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ACalendarActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCampModelControllerMotionItem
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* pAnimSequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCampModelControllerItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<FCampModelControllerMotionItem> AnimItems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCampPlayerModelControllerItem
{
    [FieldOffset(0x0000)] public UCampModelControllerItem baseObj;
    [FieldOffset(0x0048)] public TSubclassOf<ACharacter> pCharacterClass;
    [FieldOffset(0x0050)] public ACharacter* pCharacter;
    [FieldOffset(0x0058)] public UAnimMontage* pDefaultMontage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UCampModelController
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0038)] public TArray<IntPtr> Items;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ACampSceneCapture
{
    [FieldOffset(0x0000)] public ASceneCapture2D baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FLipsyncAppListener
{
    [FieldOffset(0x0000)] public EAppCharCategoryType CharcterCategoryType;
    [FieldOffset(0x0004)] public int CharaIndexID;
    [FieldOffset(0x0008)] public int SoundMajorID;
    [FieldOffset(0x000C)] public int SoundMinorID;
    [FieldOffset(0x0010)] public float PlayingCheckWaitTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UCharacterLipsyncAppComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public FLipsyncAppListener CurrentLipsyncParam;
    [FieldOffset(0x00E0)] public USkeletalMeshComponent* OwnerMesh;
    [FieldOffset(0x00E8)] public UAppCharBaseComp* AppCharacterComponent;
    [FieldOffset(0x00F0)] public TFieldPath<FFloatProperty> LipA_PropPath;
    [FieldOffset(0x0110)] public TFieldPath<FFloatProperty> LipI_PropPath;
    [FieldOffset(0x0130)] public TFieldPath<FFloatProperty> LipU_PropPath;
    [FieldOffset(0x0150)] public TFieldPath<FFloatProperty> LipE_PropPath;
    [FieldOffset(0x0170)] public TFieldPath<FFloatProperty> LipO_PropPath;
    [FieldOffset(0x0190)] public float mCurrentTotalTime;
    [FieldOffset(0x0198)] public UCurveFloat* mLipACurveDefault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCharacterSimpleLipsAnimAppParam
{
    [FieldOffset(0x0000)] public EAppCharCategoryType CharcterCategoryType;
    [FieldOffset(0x0004)] public int CharaIndexID;
    [FieldOffset(0x0008)] public float RequestedTotalTime;
    [FieldOffset(0x000C)] public float LipsPlayRate;
    [FieldOffset(0x0010)] public float StartLipsDelaySec;
    [FieldOffset(0x0018)] public UCurveFloat* LipACustomCurve;
    [FieldOffset(0x0020)] public AActor* CharaActorPtr;
    [FieldOffset(0x0028)] public int PlayerMajorID;
    [FieldOffset(0x002C)] public int PlayerMinorID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCharacterSimpleLipsAnimAppListener
{
    [FieldOffset(0x0000)] public FCharacterSimpleLipsAnimAppParam SimpleLipsAnimParam;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UCharacterSimpleLipsAnimAppComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public UCurveFloat* LipACurveDefault;
    [FieldOffset(0x00D0)] public float CurrentTotalLipDeltaTime;
    [FieldOffset(0x00D4)] public float CurrentTotalTime;
    [FieldOffset(0x00D8)] public float RequestedTotalEndTime;
    [FieldOffset(0x00DC)] public float LipsPlayRate;
    [FieldOffset(0x00E0)] public float StartLipsDelaySec;
    [FieldOffset(0x00E8)] public UCurveFloat* LipACustomCurve;
    [FieldOffset(0x00F0)] public int PlayerMajorID;
    [FieldOffset(0x00F4)] public int PlayerMinorID;
    [FieldOffset(0x00F8)] public FCharacterSimpleLipsAnimAppListener CurrentLipsyncParam;
    [FieldOffset(0x0128)] public USkeletalMeshComponent* OwnerMesh;
    [FieldOffset(0x0130)] public UAppCharBaseComp* AppCharacterComponent;
    [FieldOffset(0x0138)] public TFieldPath<FFloatProperty> LipA_PropPath;
    [FieldOffset(0x0158)] public TFieldPath<FFloatProperty> LipI_PropPath;
    [FieldOffset(0x0178)] public TFieldPath<FFloatProperty> LipU_PropPath;
    [FieldOffset(0x0198)] public TFieldPath<FFloatProperty> LipE_PropPath;
    [FieldOffset(0x01B8)] public TFieldPath<FFloatProperty> LipO_PropPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UCharacterSimpleLipsAnimAppSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0040)] public TMap<uint, FCharacterSimpleLipsAnimAppListener> SpeakCharacterMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCldBindingData
{
    [FieldOffset(0x0000)] public FString mBindingTag;
    [FieldOffset(0x0010)] public FString mAssetPath;
    [FieldOffset(0x0020)] public int mNpcSkeltonID;
    [FieldOffset(0x0024)] public short mCostumeID;
    [FieldOffset(0x0026)] public short mAnimSlotID;
    [FieldOffset(0x0028)] public bool mIsBag;
    [FieldOffset(0x0030)] public UClass* mBpClass;
    [FieldOffset(0x0038)] public AActor* mActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct ACldBindingEventActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x02A8)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x02B0)] public TArray<FCldBindingData> mBindList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCldBpFuncLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ACldCmnDataActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x0290)] public UArcAsset* mArcAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCldCommonData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public ACldCmnDataActor* mActor_;
    [FieldOffset(0x0048)] public UCldDateDataAsset* mDatesData_;
    [FieldOffset(0x0050)] public UClass* mBpClass_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6)] 
public unsafe struct FCldDateTableItem
{
    [FieldOffset(0x0000)] public byte Month;
    [FieldOffset(0x0001)] public byte Day;
    [FieldOffset(0x0002)] public byte MoonAge;
    [FieldOffset(0x0003)] public bool IsHoliday;
    [FieldOffset(0x0004)] public bool IsPublicHoliday;
    [FieldOffset(0x0005)] public ECldDateColor NumColorType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCldDateDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCldDateTableItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FCldDateMessage
{
    [FieldOffset(0x0000)] public int Key;
    [FieldOffset(0x0004)] public ushort TotalDay;
    [FieldOffset(0x0006)] public byte Month;
    [FieldOffset(0x0007)] public byte Day;
    [FieldOffset(0x0008)] public ECldDateMsgPeriod Period;
    [FieldOffset(0x000C)] public uint MsgLabel;
    [FieldOffset(0x0010)] public uint VisibleFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCldDateMessageMonth
{
    [FieldOffset(0x0000)] public TArray<FCldDateMessage> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCldDateMessageDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCldDateMessageMonth> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCldSceneChange
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct ACldSchedulerActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public AUIVoiceConnect* mVoiceConnect_;
    [FieldOffset(0x02B0)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x02B8)] public UClass* mBpClass_;
    [FieldOffset(0x02C0)] public AUtlProcActor* mProcActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUtlBpObjCore
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUtlBpObj
{
    [FieldOffset(0x0000)] public UUtlBpObjCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCldSchedulerBpObject
{
    [FieldOffset(0x0000)] public UUtlBpObj baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AUtlProcActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct ACldSchedulerProcActor
{
    [FieldOffset(0x0000)] public AUtlProcActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCldTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UCmpMenuBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UCmpCalendar
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0040)] public UAssetLoader* AssetLoader_;
    [FieldOffset(0x0048)] public AUICmpCalendar* Actor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUIScene
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UCmpCharacterStatus
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0058)] public UCmpHeroHumanStatus* HeroStatus_;
    [FieldOffset(0x0060)] public UUICmpStatus* Owner_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF10)] 
public unsafe struct UCmpCharacterStatusDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public UCmpHeroHumanStatusDraw* HumanParamDraw_;
    [FieldOffset(0x0040)] public UUICmpStatus* pParent;
    [FieldOffset(0x0048)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC60)] 
public unsafe struct UCmpCommu
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0060)] public UTexture2D* pCommuBustupAry;
    [FieldOffset(0x0C48)] public UAssetLoader* AssetLoader_;
    [FieldOffset(0x0C50)] public AUICmpCommu* Actor_;
    [FieldOffset(0x0C58)] public ACmpCommuModelController* pModelController;
}

[StructLayout(LayoutKind.Explicit, Size = 0x968)] 
public unsafe struct UCmpCommuDetails
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0060)] public AUICmpCommu* Context_;
    [FieldOffset(0x08B0)] public AUICmpCommu* pParent;
    [FieldOffset(0x08B8)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x550)] 
public unsafe struct UCmpCommuList
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x04C0)] public AUICmpCommu* Context_;
    [FieldOffset(0x04C8)] public AUICmpCommu* pParent;
    [FieldOffset(0x04D0)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct UCmpCommuCardAnimInstance
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct ACmpCommuModelController
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x02B0)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x02B8)] public AAppPropsCardContainer* pCardContainer;
    [FieldOffset(0x02C0)] public AAppPropsCore* pCardBp;
    [FieldOffset(0x02C8)] public TArray<IntPtr> pTextures;
    [FieldOffset(0x02D8)] public TArray<IntPtr> pMotions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct UCmpEquip
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0278)] public UCmpEquipSystem* PSystem;
    [FieldOffset(0x0280)] public UCmpEquipDraw* pDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3528)] 
public unsafe struct UCmpEquipDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x34C0)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x34C8)] public UCmpEquip* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FEquipListItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UCmpEquipSystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<short> PartyMemberList;
    [FieldOffset(0x0038)] public TArray<FEquipListItem> EquipList;
    [FieldOffset(0x0048)] public TArray<FEquipListItem> LastEquipList;
    [FieldOffset(0x0060)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x0068)] public UCmpEquip* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCmpHeroHumanStatus
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0050)] public UCmpHeroHumanStatusDraw* pOffHumanParamDraw_;
    [FieldOffset(0x0058)] public UUICmpStatus* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4138)] 
public unsafe struct UCmpHeroHumanStatusDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x4048)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x4050)] public UUICmpStatus* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct UCmpItem
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0188)] public UCmpItemSystem* PSystem;
    [FieldOffset(0x0190)] public UCmpItemDraw* pDraw;
    [FieldOffset(0x0198)] public APersonaStatus* pPersonaStatus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x608)] 
public unsafe struct UCmpItemDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FItemListItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x798)] 
public unsafe struct UCmpItemSystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0768)] public TArray<short> PartyMemberList;
    [FieldOffset(0x0778)] public TArray<int> PersonaStockIDList;
    [FieldOffset(0x0788)] public TArray<FItemListItem> ItemList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30F0)] 
public unsafe struct ACmpMainActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x12C8)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x12D0)] public TSubclassOf<ACampSceneCapture> SceneCaptureClass;
    [FieldOffset(0x12D8)] public ACampSceneCapture* pSceneCapture2D;
    [FieldOffset(0x12E0)] public UMaterialInstance* pCaptureMaterial;
    [FieldOffset(0x12E8)] public UMaterialInstanceDynamic* pCaptureInstanceDynamic;
    [FieldOffset(0x12F0)] public UMaterialInstance* pOutlineMaterial;
    [FieldOffset(0x12F8)] public UMaterialInstanceDynamic* pOutlineInstanceDynamic;
    [FieldOffset(0x1300)] public UMaterial* pSimpleCopyMaterial;
    [FieldOffset(0x1308)] public UMaterialInstanceDynamic* pSimpleCopyMateDynamic;
    [FieldOffset(0x1310)] public UMaterial* pHologramMaterial;
    [FieldOffset(0x1318)] public UMaterialInstanceDynamic* pHologramMateDynamic;
    [FieldOffset(0x1320)] public UTexture2D* HologMaskTexAAry;
    [FieldOffset(0x1328)] public UTexture2D* HologMaskTexBAry;
    [FieldOffset(0x1330)] public UTexture2D* HologMaskTexCAry;
    [FieldOffset(0x1338)] public UTexture2D* HologMaskTexDAry;
    [FieldOffset(0x1340)] public UMaterialInstanceDynamic* pGlassMateDynamic;
    [FieldOffset(0x1348)] public UTextureRenderTarget2D* pCaptureRenderTarget;
    [FieldOffset(0x1350)] public UTexture2D* HeroGaussMaskTexAry;
    [FieldOffset(0x13A8)] public UTexture2D* pOutAnimationTexture;
    [FieldOffset(0x13B0)] public USprAsset* pSprCommon;
    [FieldOffset(0x13B8)] public UUimAsset* pUimBgAry;
    [FieldOffset(0x13C8)] public UDataTable* pParamHologTable;
    [FieldOffset(0x13D0)] public UDataTable* pParamTopTable;
    [FieldOffset(0x13D8)] public UDataTable* pParamSkillTable;
    [FieldOffset(0x13E0)] public UDataTable* pParamItemTable;
    [FieldOffset(0x13E8)] public UDataTable* pParamEquipTable;
    [FieldOffset(0x13F0)] public UDataTable* pParamPersonaTable;
    [FieldOffset(0x13F8)] public UDataTable* pParamStatusTable;
    [FieldOffset(0x1400)] public UDataTable* pParamRankUpTable;
    [FieldOffset(0x1408)] public UDataTable* pParamCommuTable;
    [FieldOffset(0x1410)] public UDataTable* pParamSystemTable;
    [FieldOffset(0x1418)] public UDataTable* pParamCommonTable;
    [FieldOffset(0x1420)] public UDataTable* pCameraTable;
    [FieldOffset(0x1428)] public UDataTable* pHologramTable;
    [FieldOffset(0x1430)] public UMaterial* pMateWaveCaustics;
    [FieldOffset(0x1438)] public UDataTable* pParamLayoutDataRoot;
    [FieldOffset(0x1440)] public UDataTable* pParamLayoutDataSystem;
    [FieldOffset(0x1448)] public UDataTable* pParamTriangularCursorDataRoot;
    [FieldOffset(0x1450)] public UDataTable* pParamTriangularCursorDataSystem;
    [FieldOffset(0x1458)] public UDataTable* pParamLayoutDataQuest;
    [FieldOffset(0x1460)] public UDataTable* pParamLayoutDataQuestDate;
    [FieldOffset(0x1468)] public UDataTable* pParamLayoutPersonaList;
    [FieldOffset(0x1470)] public UDataTable* pParamLayoutDataItem;
    [FieldOffset(0x1478)] public UDataTable* pParamLayoutDataSkill;
    [FieldOffset(0x1480)] public UDataTable* pParamLayoutDataSkill2;
    [FieldOffset(0x1488)] public UDataTable* pParamLayoutDataOthers;
    [FieldOffset(0x1490)] public UDataTable* pParamLayoutDataHelpOthers;
    [FieldOffset(0x1498)] public UDataTable* pParamLayoutDataPartyPanel;
    [FieldOffset(0x14A0)] public UDataTable* pParamLayoutDataTutorialText;
    [FieldOffset(0x14A8)] public UDataTable* pParamLayoutDataDictionaryText;
    [FieldOffset(0x14B0)] public UDataTable* pParamLayoutDataCalendarText;
    [FieldOffset(0x14B8)] public UDataTable* pParamLayoutDataEquipTextCol;
    [FieldOffset(0x14C0)] public UDataTable* pParamLayoutDataItemTextCol;
    [FieldOffset(0x14C8)] public UDataTable* pParamLayoutDataQuestTextCol;
    [FieldOffset(0x14D0)] public UDataTable* pParamLayoutDataQuestTextPos;
    [FieldOffset(0x14D8)] public UDataTable* pParamLayoutDataCommuTextCol;
    [FieldOffset(0x14E0)] public UDataTable* pParamLayoutDataStatusTextCol;
    [FieldOffset(0x14E8)] public UDataTable* pParamLayoutDataOkNext;
    [FieldOffset(0x14F0)] public UDataTable* pParamLayoutDataOkNextMask;
    [FieldOffset(0x14F8)] public UDataTable* pParamLayoutDataRootTouchColl;
    [FieldOffset(0x1500)] public UDataTable* pParamLayoutDataSystemTouchColl;
    [FieldOffset(0x1508)] public UUimAsset* pUimNamiRootAAry;
    [FieldOffset(0x15F8)] public UUimAsset* pUimNamiRootBAry;
    [FieldOffset(0x16E8)] public UUimAsset* pUimNamiSkillAAry;
    [FieldOffset(0x17D8)] public UUimAsset* pUimNamiSkillBAry;
    [FieldOffset(0x18C8)] public UUimAsset* pUimNamiItemAAry;
    [FieldOffset(0x19B8)] public UUimAsset* pUimNamiItemBAry;
    [FieldOffset(0x1AA8)] public UUimAsset* pUimNamiEquipAAry;
    [FieldOffset(0x1B98)] public UUimAsset* pUimNamiEquipBAry;
    [FieldOffset(0x1C88)] public UUimAsset* pUimNamiPersonaAAry;
    [FieldOffset(0x1D78)] public UUimAsset* pUimNamiPersonaBAry;
    [FieldOffset(0x1E68)] public UUimAsset* pUimNamiStatusAAry;
    [FieldOffset(0x1F58)] public UUimAsset* pUimNamiStatusBAry;
    [FieldOffset(0x2048)] public UUimAsset* pUimNamiQuestAAry;
    [FieldOffset(0x2138)] public UUimAsset* pUimNamiQuestBAry;
    [FieldOffset(0x2228)] public UUimAsset* pUimNamiCommuAAry;
    [FieldOffset(0x2318)] public UUimAsset* pUimNamiCommuBAry;
    [FieldOffset(0x2408)] public UUimAsset* pUimNamiCalendarAAry;
    [FieldOffset(0x24F8)] public UUimAsset* pUimNamiCalendarBAry;
    [FieldOffset(0x25E8)] public UUimAsset* pUimNamiSystemAAry;
    [FieldOffset(0x26D8)] public UUimAsset* pUimNamiSystemBAry;
    [FieldOffset(0x27C8)] public UUimAsset* pUimNamiTutorialAAry;
    [FieldOffset(0x28B8)] public UUimAsset* pUimNamiTutorialBAry;
    [FieldOffset(0x29A8)] public UUimAsset* pUimNamiConfigAAry;
    [FieldOffset(0x2A98)] public UUimAsset* pUimNamiConfigBAry;
    [FieldOffset(0x2B88)] public UTexture2D* pCharaGlassAry;
    [FieldOffset(0x2BD8)] public UTexture2D* pCharaDetailAry;
    [FieldOffset(0x2C28)] public UTexture2D* pCharaDetailShdAry;
    [FieldOffset(0x2C98)] public TArray<IntPtr> MenuList;
    [FieldOffset(0x2CB0)] public UCmpMenuBase* pCurrentMenu;
    [FieldOffset(0x2CB8)] public UCmpMenuBase* pNextMenu;
    [FieldOffset(0x2CC0)] public UCmpMenuBase* pPrevMenu;
    [FieldOffset(0x2CC8)] public UCampModelController* pModelController;
    [FieldOffset(0x2CD0)] public ACmpMainLoadActor* pCmpMainLoadActor;
    [FieldOffset(0x2CE0)] public TSubclassOf<ACharacter> pHeroCharaClass;
    [FieldOffset(0x2CE8)] public UAppAnimCtrl* pHeroAnimCtrl;
    [FieldOffset(0x2CF0)] public TArray<IntPtr> MateInterAry;
    [FieldOffset(0x2D00)] public bool bIsDisableForceTermination;
    [FieldOffset(0x2D02)] public bool bEquipChange;
    [FieldOffset(0x2D03)] public bool bReturnCommuToField;
    [FieldOffset(0x2D08)] public UUIRequest* pUIRequest;
    [FieldOffset(0x2D10)] public UUIMissingPerson* pUIMissingPerson;
    [FieldOffset(0x2D18)] public UUITheurgia* pUITheurgia;
    [FieldOffset(0x3028)] public UUILayoutDataTable* RootLayoutDataTable;
    [FieldOffset(0x3030)] public UUILayoutDataTable* SystemLayoutDataTable;
    [FieldOffset(0x3038)] public UUILayoutDataTable* QuestLayoutDataTable;
    [FieldOffset(0x3040)] public UUILayoutDataTable* QuestDateLayoutDataTable;
    [FieldOffset(0x3048)] public UUILayoutDataTable* OthersLayoutDataTable;
    [FieldOffset(0x3050)] public UUILayoutDataTable* HelpOthersLayoutDataTable;
    [FieldOffset(0x3058)] public UUILayoutDataTable* PersonaListLayoutDataTable;
    [FieldOffset(0x3060)] public UUILayoutDataTable* ItemLayoutDataTable;
    [FieldOffset(0x3068)] public UUILayoutDataTable* SkillLayoutDataTable;
    [FieldOffset(0x3070)] public UUILayoutDataTable* SkillLayoutDataTable2;
    [FieldOffset(0x3078)] public UUILayoutDataTable* PartyPanelLayoutDataTable;
    [FieldOffset(0x3080)] public UUILayoutDataTable* TutorialTextLayoutDataTable;
    [FieldOffset(0x3088)] public UUILayoutDataTable* DictionaryTextLayoutDataTable;
    [FieldOffset(0x3090)] public UUILayoutDataTable* CalendarTextLayoutDataTable;
    [FieldOffset(0x3098)] public UUILayoutDataTable* EquipTextColLayoutDataTable;
    [FieldOffset(0x30A0)] public UUILayoutDataTable* ItemTextColLayoutDataTable;
    [FieldOffset(0x30A8)] public UUILayoutDataTable* QuestTextColLayoutDataTable;
    [FieldOffset(0x30B0)] public UUILayoutDataTable* QuestTextPosLayoutDataTable;
    [FieldOffset(0x30B8)] public UUILayoutDataTable* CommuTextColLayoutDataTable;
    [FieldOffset(0x30C0)] public UUILayoutDataTable* StatusTextColLayoutDataTable;
    [FieldOffset(0x30C8)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x30D0)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
    [FieldOffset(0x30D8)] public UUILayoutDataTable* RootTouchCollLayoutDataTable;
    [FieldOffset(0x30E0)] public UUILayoutDataTable* SystemTouchCollLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UCampLoadSequenceBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UCallFieldSequence
{
    [FieldOffset(0x0000)] public UCampLoadSequenceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UCallTitleSequence
{
    [FieldOffset(0x0000)] public UCampLoadSequenceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct ACmpMainLoadActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UCampLoadSequenceBase* pSequence;
    [FieldOffset(0x0280)] public ACmpMainActor* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x460)] 
public unsafe struct UCmpPersona
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0048)] public UAssetLoader* AssetLoader_;
    [FieldOffset(0x0050)] public UMaterialInstanceDynamic* pDynaMateWaveCausticsAry;
    [FieldOffset(0x0110)] public UTexture2D* pTexArcanaWordAry;
    [FieldOffset(0x01D0)] public AUICmpPersona* Actor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UCmpPersonaList
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0088)] public AUICmpPersona* Context_;
    [FieldOffset(0x0090)] public APersonaStatus* PSStatusActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UCmpQuest
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0040)] public USprAsset* m_pSpr;
    [FieldOffset(0x0048)] public UAssetLoader* AssetLoader_;
    [FieldOffset(0x0050)] public USprAsset* m_pCampSpr;
    [FieldOffset(0x0058)] public USprAsset* m_pCampKeySpr;
    [FieldOffset(0x0060)] public UPlgAsset* m_pCampPlg;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UCmpRoot
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0088)] public UCmpRootDraw* pRootDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x878)] 
public unsafe struct UCmpRootDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0828)] public UUimAsset* pUimTextCursorOn;
    [FieldOffset(0x0830)] public UUimAsset* pUimCursorLoop;
    [FieldOffset(0x0838)] public UUimAsset* pUimCursorInBounce;
    [FieldOffset(0x0840)] public TArray<IntPtr> pMenuItemInstanceDynamics;
    [FieldOffset(0x0850)] public UMaterial* pMetaricMaterial;
    [FieldOffset(0x0858)] public UMaterial* pWriteMetaricMaterial;
    [FieldOffset(0x0860)] public UMaterialInstanceDynamic* pWriteMetaricInstanceDynamics;
    [FieldOffset(0x0868)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UCmpSkill
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0100)] public UCmpSkillDraw* pSkillDraw;
    [FieldOffset(0x0108)] public UCmpSkillSystem* pSkillSystem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x548)] 
public unsafe struct UCmpSkillDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UCmpSkillSystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct UCmpStatus
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x0058)] public UUICmpStatus* Actor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UCmpStatusCharacterList
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x00B8)] public UUICmpStatus* Owner_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x870)] 
public unsafe struct UCmpStatusCharacterListDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UUICmpStatus* pParent;
    [FieldOffset(0x0030)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UCmpSystem
{
    [FieldOffset(0x0000)] public UCmpMenuBase baseObj;
    [FieldOffset(0x00A8)] public UCmpSystemDraw* pSystemDraw;
    [FieldOffset(0x00B0)] public UCmpSystemSystem* pSystemSystem;
    [FieldOffset(0x00B8)] public AUISaveLoad* pSaveMenu;
    [FieldOffset(0x00C0)] public AUITutorial* pTutorial;
    [FieldOffset(0x00C8)] public AUIDictionary* pDictionary;
    [FieldOffset(0x00D0)] public TSubclassOf<AUITutorialDraw> pTutorialDrawClass;
    [FieldOffset(0x00D8)] public AUIConfiguration* pConfig;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1408)] 
public unsafe struct UCmpSystemDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public TArray<IntPtr> SubMenuMateDynamicAry;
    [FieldOffset(0x13F8)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x1400)] public UCmpSystem* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UCmpSystemSystem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public ACmpMainActor* pCmpMainActor;
    [FieldOffset(0x0048)] public AUISaveLoad* pSaveMenu;
    [FieldOffset(0x0050)] public AUIRestore* pRestoreMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ACombineTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UUICombineCalc* CombineCalc_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCommunityCallEventData
{
    [FieldOffset(0x0000)] public int Rank;
    [FieldOffset(0x0004)] public int major;
    [FieldOffset(0x0008)] public int Minor;
    [FieldOffset(0x000C)] public uint Flag0;
    [FieldOffset(0x0010)] public uint Flag1;
    [FieldOffset(0x0014)] public uint Flag2;
    [FieldOffset(0x0018)] public uint Flag3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ACommunityEventManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public TArray<FCommunityCallEventData> CallEventList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UCommunityHandler
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x00F0)] public UCommunityEventDataAsset* pEventDataAsset;
    [FieldOffset(0x00F8)] public UHolidayEventDataAsset* pHolidayEventDataAsset;
    [FieldOffset(0x0100)] public UHolidayScheduleDataAsset* pHolidayScheduleDataAsset;
    [FieldOffset(0x0108)] public UDataTable* pMemberFormatTable;
    [FieldOffset(0x0110)] public UDataTable* pNameFormatTable;
    [FieldOffset(0x0118)] public UCoefficientDataAsset* pCoefficientDataAsset;
    [FieldOffset(0x0120)] public UCommunityPresentDataAsset* pPresentDataAsset;
    [FieldOffset(0x0128)] public UMoviesEventDataAsset* pMoviesEventDataAsset;
    [FieldOffset(0x0130)] public USummerFestivalEventDataAsset* pSummerFestivalEventDataAsset;
    [FieldOffset(0x0138)] public UChristmasEventDataAsset* pChristmasEventDataAsset;
    [FieldOffset(0x0140)] public ACommunityEventManager* pEventManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ADebugViewer
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UDebugMenu* pMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct ACommunityShortcut
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x02A0)] public AScrActor* pScript;
    [FieldOffset(0x02A8)] public UBfAsset* pBfAsset;
    [FieldOffset(0x02B0)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FCommunityEventData
{
    [FieldOffset(0x0000)] public int Rank;
    [FieldOffset(0x0004)] public int major;
    [FieldOffset(0x0008)] public int Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FCommunityRankUpEventData
{
    [FieldOffset(0x0000)] public short Rank;
    [FieldOffset(0x0002)] public short Point;
    [FieldOffset(0x0004)] public short major;
    [FieldOffset(0x0006)] public short Minor;
    [FieldOffset(0x0008)] public sbyte Brain;
    [FieldOffset(0x0009)] public sbyte charm;
    [FieldOffset(0x000A)] public sbyte Courage;
    [FieldOffset(0x000C)] public uint Flag0;
    [FieldOffset(0x0010)] public uint Flag1;
    [FieldOffset(0x0014)] public uint Flag2;
    [FieldOffset(0x0018)] public uint Flag3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCommunityEventTable
{
    [FieldOffset(0x0000)] public TArray<FCommunityEventData> NotRankUpTable;
    [FieldOffset(0x0010)] public TArray<FCommunityRankUpEventData> RankUpTable;
    [FieldOffset(0x0020)] public TArray<FCommunityRankUpEventData> LoverRankUpTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCommunityEventDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCommunityEventTable> Tables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FHeroParameterTable
{
    [FieldOffset(0x0000)] public TArray<int> Points;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHeroParameterDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FHeroParameterTable> Tables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FHolidayEventData
{
    [FieldOffset(0x0000)] public int major;
    [FieldOffset(0x0004)] public int Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FHolidayEventDataTable
{
    [FieldOffset(0x0000)] public TArray<FHolidayEventData> Datas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHolidayEventDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FHolidayEventDataTable> Tables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FHolidayScheduleData
{
    [FieldOffset(0x0000)] public int Month;
    [FieldOffset(0x0004)] public int Day;
    [FieldOffset(0x0008)] public int ArcanaID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHolidayScheduleDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FHolidayScheduleData> Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCoefficientInfo
{
    [FieldOffset(0x0000)] public int Value;
    [FieldOffset(0x0004)] public float Coefficient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FUniqCoefficient
{
    [FieldOffset(0x0000)] public TMap<int, FCoefficientInfo> DataMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UCoefficientDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCoefficientInfo> GeneralTable;
    [FieldOffset(0x0040)] public TArray<FUniqCoefficient> UniqTables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCommunityPresentData
{
    [FieldOffset(0x0000)] public uint ItemId;
    [FieldOffset(0x0004)] public int AddCommunityPoint;
    [FieldOffset(0x0008)] public FName ReactionMessageLabel;
    [FieldOffset(0x0010)] public FName HeroMessageLabel;
    [FieldOffset(0x0018)] public FName ChristmasReactionMessageLabel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCommunityPresentTable
{
    [FieldOffset(0x0000)] public TArray<FCommunityPresentData> Datas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCommunityPresentDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCommunityPresentTable> Tables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMoviesEventData
{
    [FieldOffset(0x0000)] public sbyte Month;
    [FieldOffset(0x0001)] public sbyte Day;
    [FieldOffset(0x0004)] public int ArcanaID;
    [FieldOffset(0x0008)] public int MailID;
    [FieldOffset(0x000C)] public short major;
    [FieldOffset(0x000E)] public short Minor;
    [FieldOffset(0x0010)] public sbyte CommunityRankMin;
    [FieldOffset(0x0011)] public sbyte CommunityRankMax;
    [FieldOffset(0x0014)] public uint OffFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMoviesEventDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMoviesEventData> Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSummerFestivalEventData
{
    [FieldOffset(0x0000)] public int MailID;
    [FieldOffset(0x0004)] public short major;
    [FieldOffset(0x0006)] public short Minor;
    [FieldOffset(0x0008)] public uint OnFlag;
    [FieldOffset(0x000C)] public uint OffFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USummerFestivalEventDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSummerFestivalEventData> Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FChristmasEventMailData
{
    [FieldOffset(0x0000)] public short ID;
    [FieldOffset(0x0002)] public short Rank;
    [FieldOffset(0x0004)] public uint flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FChristmasEventListData
{
    [FieldOffset(0x0000)] public short major;
    [FieldOffset(0x0002)] public short Minor;
    [FieldOffset(0x0004)] public uint flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChristmasEventData
{
    [FieldOffset(0x0000)] public FChristmasEventMailData Mail;
    [FieldOffset(0x0008)] public TArray<FChristmasEventListData> Events;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UChristmasEventDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FChristmasEventData> Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UCommunityWork
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0030)] public UCommunityHandler* pCommunityHandle;
    [FieldOffset(0x0038)] public UVeveWork* pVeveWork;
    [FieldOffset(0x0040)] public UHeroParameterHandle* pHeroParameterHandle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UConfigBGMSelectDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UConfigDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UConfigDungeonBGMSelectDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FGetUIParameter
{
    [FieldOffset(0x0018)] public UUIParameterAsset* ParameterAsset;
    [FieldOffset(0x0020)] public TMap<FString, float> ParameterMap;
    [FieldOffset(0x0070)] public UAssetLoader* AssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xAC8)] 
public unsafe struct ACutInDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x08D8)] public UAssetLoader* AssetLoader_;
    [FieldOffset(0x08E0)] public UPlgAsset* EmotionIconPlg_;
    [FieldOffset(0x08E8)] public UTexture* BustUpTexture_;
    [FieldOffset(0x08F0)] public UTexture* BustUpDummyTexture_;
    [FieldOffset(0x08F8)] public FGetUIParameter UIP_;
    [FieldOffset(0x0970)] public FCurveVectorAnimation Curve1_;
    [FieldOffset(0x09A0)] public FCurveVectorAnimation Curve2_;
    [FieldOffset(0x09D0)] public FCurveVectorAnimation Curve3_;
    [FieldOffset(0x0A00)] public FCurveVectorAnimation Curve4_;
    [FieldOffset(0x0A30)] public FCurveVectorAnimation Curve5_;
    [FieldOffset(0x0A60)] public FCurveVectorAnimation Curve6_;
    [FieldOffset(0x0A90)] public FCurveVectorAnimation Curve7_;
    [FieldOffset(0x0AC0)] public USprAsset* Spr_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct ADailyChangeVoiceActionViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x02B8)] public AUIDebugReceiveVoiceAction* mVoiceConnect_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AUIVoiceBase
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AUIDebugReceiveVoiceAction
{
    [FieldOffset(0x0000)] public AUIVoiceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatAnalyze
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableAnalyzeSync;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDatBtlCommon
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* Table;
    [FieldOffset(0x0038)] public UDataAsset* TableCalcPANICDropItem;
    [FieldOffset(0x0040)] public UDataAsset* TableCalcPANICUseItem;
    [FieldOffset(0x0048)] public UDataAsset* TableEncountEnemyBadPercent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatEncount
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableEncount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UDatEnemy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableEnemy;
    [FieldOffset(0x0038)] public UDataAsset* TableName;
    [FieldOffset(0x0040)] public UDataAsset* TableAttr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatFontAdjustment
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UFontAdjustmentListTable* TableFontAdjustment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ADatItemActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UAssetLoader* mAssetLoader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UDatItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableAccs;
    [FieldOffset(0x0038)] public UDataAsset* TableArmor;
    [FieldOffset(0x0040)] public UDataAsset* TableCommon;
    [FieldOffset(0x0048)] public UDataAsset* TableCostume;
    [FieldOffset(0x0050)] public UDataAsset* TableEvitem;
    [FieldOffset(0x0058)] public UDataAsset* TableMaterial;
    [FieldOffset(0x0060)] public UDataAsset* TableShoes;
    [FieldOffset(0x0068)] public UDataAsset* TableSkillcard;
    [FieldOffset(0x0070)] public UDataAsset* TableWeapon;
    [FieldOffset(0x0078)] public UDataAsset* TableAccsName;
    [FieldOffset(0x0080)] public UDataAsset* TableArmorName;
    [FieldOffset(0x0088)] public UDataAsset* TableCommonName;
    [FieldOffset(0x0090)] public UDataAsset* TableCostumeName;
    [FieldOffset(0x0098)] public UDataAsset* TableEvitemName;
    [FieldOffset(0x00A0)] public UDataAsset* TableMaterialName;
    [FieldOffset(0x00A8)] public UDataAsset* TableShoesName;
    [FieldOffset(0x00B0)] public UDataAsset* TableSkillcardName;
    [FieldOffset(0x00B8)] public UDataAsset* TableWeaponName;
    [FieldOffset(0x00C8)] public ADatItemActor* mActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMiniMapInfoTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString FieldID;
    [FieldOffset(0x0018)] public float Scale;
    [FieldOffset(0x001C)] public float DegreeAngle;
    [FieldOffset(0x0020)] public bool Hide;
    [FieldOffset(0x0024)] public float VLScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatMiniMapInfo
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0048)] public TArray<FMiniMapInfoTable> m_aInfoList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMiniMapOffsetTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString FieldID;
    [FieldOffset(0x0018)] public int OffsetX;
    [FieldOffset(0x001C)] public int OffsetY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatMiniMapOffset
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0048)] public TArray<FMiniMapOffsetTable> m_aOffsetList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatPersona
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TablePersona;
    [FieldOffset(0x0038)] public UDataAsset* TableAttr;
    [FieldOffset(0x0040)] public UDataAsset* TableName;
    [FieldOffset(0x0048)] public UDataAsset* TableGrowth;
    [FieldOffset(0x0050)] public UDataAsset* TableAllyGrowth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatPlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableLevelup;
    [FieldOffset(0x0038)] public UDataAsset* TableMaxHPSP;
    [FieldOffset(0x0040)] public UDataAsset* TableName;
    [FieldOffset(0x0048)] public UDataAsset* TableFitstName;
    [FieldOffset(0x0050)] public UDataAsset* TableLastName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatPlayerNameOne
{
    [FieldOffset(0x0000)] public int mPlayerID;
    [FieldOffset(0x0008)] public FText mName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPlayerNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPlayerNameOne> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPlayerFirstNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPlayerNameOne> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPlayerLastNameTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPlayerNameOne> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDatRace
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UDatSaveDataLocalization
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UDatShuffleCard
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableName;
    [FieldOffset(0x0038)] public UDataAsset* TableChoiceMajor;
    [FieldOffset(0x0040)] public UDataAsset* TableChoiceMinor;
    [FieldOffset(0x0048)] public UDataAsset* TablePersona;
    [FieldOffset(0x0050)] public UDataAsset* TableWand;
    [FieldOffset(0x0058)] public UDataAsset* TableCoin;
    [FieldOffset(0x0060)] public UDataAsset* TableCup;
    [FieldOffset(0x0068)] public UDataAsset* TableSword;
    [FieldOffset(0x0070)] public UDataAsset* TableFool;
    [FieldOffset(0x0078)] public UDataAsset* TableMagician;
    [FieldOffset(0x0080)] public UDataAsset* TableLovers;
    [FieldOffset(0x0088)] public UDataAsset* TableFortune;
    [FieldOffset(0x0090)] public UDataAsset* TableStrength;
    [FieldOffset(0x0098)] public UDataAsset* TableHangedman;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDatSkill
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableName;
    [FieldOffset(0x0038)] public UDataAsset* TableSkill;
    [FieldOffset(0x0040)] public UDataAsset* TableNormal;
    [FieldOffset(0x0048)] public UDataAsset* TableAttrName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSuggestion
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableSuggestion;
    [FieldOffset(0x0038)] public UDataAsset* TableSuggestionText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatSupportInfo
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UAssetLoader* Loader;
    [FieldOffset(0x0038)] public UDataAsset* TableSupportInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDatSystemText
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataTable* DataTable;
    [FieldOffset(0x0038)] public TMap<int, FString> SystemTextTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UDatTheurgia
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableTheurgiaBoost;
    [FieldOffset(0x0038)] public UDataAsset* TableTheurgiaBoostBoss;
    [FieldOffset(0x0040)] public UDataAsset* TableMixraidRelease;
    [FieldOffset(0x0048)] public UBmdAsset* TheurgiaFlavorText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FTownMapInfoTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString LocationName;
    [FieldOffset(0x0018)] public int LocationNo;
    [FieldOffset(0x0020)] public FString CategoryName;
    [FieldOffset(0x0030)] public int CategoryNo;
    [FieldOffset(0x0038)] public FString IconName;
    [FieldOffset(0x0048)] public int SprType;
    [FieldOffset(0x004C)] public int SprNo;
    [FieldOffset(0x0050)] public bool Noon;
    [FieldOffset(0x0051)] public bool Night;
    [FieldOffset(0x0058)] public FString HideFlag;
    [FieldOffset(0x0068)] public FString TextLabel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FTownMapInfoNameTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString TextLabel;
    [FieldOffset(0x0018)] public FString Text;
    [FieldOffset(0x0028)] public FString Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FTownMapDetailTextTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString DetailText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UDatTownMapInfo
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0048)] public TArray<FTownMapInfoTable> m_aTownMapInfoList;
    [FieldOffset(0x0058)] public TArray<FTownMapInfoNameTable> m_aNameList;
    [FieldOffset(0x0068)] public TArray<FTownMapDetailTextTable> m_aDetailTextList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UDatTownMapRestrictions
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatTownMapTime
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UDatUICalendarText
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataTable* MonthTable;
    [FieldOffset(0x0038)] public UDataTable* DateTable;
    [FieldOffset(0x0040)] public UDataTable* DayOfWeekTable;
    [FieldOffset(0x0048)] public TArray<FString> MonthTexts;
    [FieldOffset(0x0058)] public TArray<FString> DateTexts;
    [FieldOffset(0x0068)] public TArray<FString> DayOfWeekTexts;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UDatUIText
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UDatUIUseText
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataTable* DataTable;
    [FieldOffset(0x0038)] public TMap<int, FString> UIUseTextTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDatUnit
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct ADbgCmpStatusTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UUICmpStatus* Actor_;
    [FieldOffset(0x0280)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDictionaryTableData
{
    [FieldOffset(0x0000)] public int DictionaryID;
    [FieldOffset(0x0004)] public int SortID;
    [FieldOffset(0x0008)] public int OpenFlagID;
    [FieldOffset(0x0010)] public FString Title;
    [FieldOffset(0x0020)] public TArray<FName> TextureNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDictionaryTableDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDictionaryTableData> Tables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AUIDrawBaseActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0290)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0298)] public UUIDataAsset* ResourceDataAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x740)] 
public unsafe struct ADifficultySelectionActor
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x0340)] public UAssetLoader* AssetLoader;
    [FieldOffset(0x0348)] public USprAsset* TitleSpr;
    [FieldOffset(0x0350)] public UPlgAsset* TitlePlg;
    [FieldOffset(0x0358)] public UTexture* InheritanceTex;
    [FieldOffset(0x0360)] public UDataTable* TitleSelectDataTable;
    [FieldOffset(0x0368)] public UDataTable* LayoutDataTable;
    [FieldOffset(0x0370)] public UUILayoutDataTable* UILayoutLayoutDataTable;
    [FieldOffset(0x0378)] public int DiffBGScaleAnimFrame;
    [FieldOffset(0x037C)] public int DiffBGAlphaAnimFrame;
    [FieldOffset(0x0380)] public int DiffBGGradAlphaAnimFrame;
    [FieldOffset(0x0384)] public int ListWaitFrame;
    [FieldOffset(0x0388)] public int InfoInAnimRange;
    [FieldOffset(0x038C)] public int InfoInAnimFrame;
    [FieldOffset(0x0390)] public int InfoInWaitFrame;
    [FieldOffset(0x0394)] public int InfoChangeAnimRange;
    [FieldOffset(0x0398)] public int InfoChangeFrame;
    [FieldOffset(0x039C)] public int InfoChangeAnimWaitFrame;
    [FieldOffset(0x03A0)] public int CloseListAndHelpFrame;
    [FieldOffset(0x03A4)] public int CloseListY;
    [FieldOffset(0x03A8)] public int CloseBGFrame;
    [FieldOffset(0x03AC)] public int InheritanceBGFrame;
    [FieldOffset(0x03B0)] public int InheritanceFadeFrame;
    [FieldOffset(0x03B4)] public bool CloseBGNotScaleFlag;
    [FieldOffset(0x03B5)] public bool bChangeAnimDisable;
    [FieldOffset(0x03B8)] public float DiffBGX;
    [FieldOffset(0x03BC)] public float DiffBGY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct ADLCManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x02D8)] public UAssetLoader* mAssetLoader;
    [FieldOffset(0x02E0)] public UAddContentEntitlementDataAsset* mAddContentEntitlementData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct ADEPRECATED_Draft_EventManager
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBmdAsset* mpBmdAsset;
    [FieldOffset(0x0230)] public int ExecutingMessageNo;
    [FieldOffset(0x0238)] public EEventManagerMessageState MessageState;
    [FieldOffset(0x0240)] public UMovieSceneSequencePlayer* EventSequencePlayer;
    [FieldOffset(0x0250)] public int RequestedSeqClosedEventMessageID;
    [FieldOffset(0x0254)] public EEventManagerSeqControllerState SeqControllerState;
    [FieldOffset(0x0258)] public FEvtLocalData EvtLocalData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UDungeonSoundDataAssets
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0030)] public UDataAsset* pDlcDungeonBgm;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UDungeonSoundTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDatDlcDungeonBgmTableData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint BandleID;
    [FieldOffset(0x000C)] public uint SerialNumber;
    [FieldOffset(0x0010)] public FName Title;
    [FieldOffset(0x0018)] public uint CueId;
    [FieldOffset(0x001C)] public uint ControlNumber;
    [FieldOffset(0x0020)] public uint Sort;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatDlcDungeonBgmTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatDlcDungeonBgmTableData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct UEventSkipWidgetDelegate
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AEvtCharacterDraft
{
    [FieldOffset(0x0000)] public APawn baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEvtDataAssets
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatDataOffDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Category;
    [FieldOffset(0x0010)] public uint major;
    [FieldOffset(0x0014)] public uint Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatDataOffTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatDataOffDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatFadeOutDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Category;
    [FieldOffset(0x0010)] public uint major;
    [FieldOffset(0x0014)] public uint Minor;
    [FieldOffset(0x0018)] public byte FadeType;
    [FieldOffset(0x0019)] public byte ColorR;
    [FieldOffset(0x001A)] public byte ColorG;
    [FieldOffset(0x001B)] public byte ColorB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatFadeOutTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatFadeOutDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDatAssetOverWriteDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint major;
    [FieldOffset(0x000C)] public uint Minor;
    [FieldOffset(0x0010)] public FName BindingTag;
    [FieldOffset(0x0018)] public byte Month;
    [FieldOffset(0x0019)] public byte Day;
    [FieldOffset(0x001A)] public byte Time;
    [FieldOffset(0x001C)] public uint BaseMotion;
    [FieldOffset(0x0020)] public uint BaseMotionEx;
    [FieldOffset(0x0024)] public uint AddMotionEx;
    [FieldOffset(0x0028)] public uint flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatAssetOverWriteTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatAssetOverWriteDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatAssetOverWriteEventDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Category;
    [FieldOffset(0x0010)] public uint major;
    [FieldOffset(0x0014)] public uint Minor;
    [FieldOffset(0x0018)] public uint ProcNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatAssetOverWriteEventTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatAssetOverWriteEventDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatBagEnableDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Category;
    [FieldOffset(0x0010)] public uint major;
    [FieldOffset(0x0014)] public uint Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatBagEnableTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatBagEnableDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDatPersonaCombineAdjustDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint PersonaID;
    [FieldOffset(0x000C)] public float TransX;
    [FieldOffset(0x0010)] public float TransY;
    [FieldOffset(0x0014)] public float TransZ;
    [FieldOffset(0x0018)] public float RotationX;
    [FieldOffset(0x001C)] public float RotationY;
    [FieldOffset(0x0020)] public float RotationZ;
    [FieldOffset(0x0024)] public float ScaleX;
    [FieldOffset(0x0028)] public float ScaleY;
    [FieldOffset(0x002C)] public float ScaleZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatPersonaCombineAdjustTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatPersonaCombineAdjustDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FDatObjectVisibleDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint major;
    [FieldOffset(0x000C)] public uint Minor;
    [FieldOffset(0x0010)] public uint ObjectID;
    [FieldOffset(0x0014)] public byte Visible;
    [FieldOffset(0x0018)] public FString FlagCond1;
    [FieldOffset(0x0028)] public byte FlagValue1;
    [FieldOffset(0x0030)] public FString FlagCond2;
    [FieldOffset(0x0040)] public byte FlagValue2;
    [FieldOffset(0x0048)] public FString FlagCond3;
    [FieldOffset(0x0058)] public byte FlagValue3;
    [FieldOffset(0x0060)] public FString TimeZone;
    [FieldOffset(0x0070)] public FString FlagDoW;
    [FieldOffset(0x0080)] public byte FlagDoWValue;
    [FieldOffset(0x0081)] public byte StartMonth;
    [FieldOffset(0x0082)] public byte StartDay;
    [FieldOffset(0x0083)] public byte EndMonth;
    [FieldOffset(0x0084)] public byte EndDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatObjectVisibleTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatObjectVisibleDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UEvtDataLoad
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0030)] public UDataAsset* pDataOffTable;
    [FieldOffset(0x0038)] public UDataAsset* pFadeOutTable;
    [FieldOffset(0x0040)] public UDataAsset* pAssetOverWriteTable;
    [FieldOffset(0x0048)] public UDataAsset* pAssetOverWriteEventTable;
    [FieldOffset(0x0050)] public UDataAsset* pBagEnableTable;
    [FieldOffset(0x0058)] public UDataAsset* pEvtPreDataTable;
    [FieldOffset(0x0060)] public UDataAsset* pPersonaCombineAdjustTable;
    [FieldOffset(0x0068)] public UDataAsset* pObjectVisibleTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEvtManagerStateBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public AAtlEvtEventManager_PauseActor* EvtPauseActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEvtManagerStateBacklog
{
    [FieldOffset(0x0000)] public UEvtManagerStateBase baseObj;
    [FieldOffset(0x0038)] public AUIBackLog* UIBackLogActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEvtManagerStateExit
{
    [FieldOffset(0x0000)] public UEvtManagerStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEvtManagerStateNetAnswer
{
    [FieldOffset(0x0000)] public UEvtManagerStateBase baseObj;
    [FieldOffset(0x0038)] public AUIVoiceAnswer* UINetAnswerActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEvtManagerStatePlaying
{
    [FieldOffset(0x0000)] public UEvtManagerStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEvtTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFadePgBattleEventWipeActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public bool IsAnimation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFadeProgramBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UFadePgBattleEventWipe
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
    [FieldOffset(0x0040)] public AFadePgBattleEventWipeActor* pActor;
    [FieldOffset(0x0048)] public TSubclassOf<AFadePgBattleEventWipeActor> LoadClass;
    [FieldOffset(0x0050)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0058)] public bool m_bLoading;
    [FieldOffset(0x0059)] public bool m_bLoaded;
    [FieldOffset(0x005A)] public bool m_bMainLoaded;
    [FieldOffset(0x005B)] public bool m_bIsAnimation;
    [FieldOffset(0x005C)] public int requestNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UBattleResultWatcher
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FPgBtlResultWipe
{
    [FieldOffset(0x0000)] public FCurveVectorAnimation m_curveFadeOutBlack;
    [FieldOffset(0x0030)] public FCurveVectorAnimation m_curveFadeOutBlue;
    [FieldOffset(0x0060)] public FCurveVectorAnimation m_curveFadeInBlack;
    [FieldOffset(0x0090)] public TArray<IntPtr> objList;
    [FieldOffset(0x00A0)] public UBattleResultWatcher* m_Watcher;
    [FieldOffset(0x00A8)] public FVector2D centerOffset;
    [FieldOffset(0x00B0)] public FVector2D Offset1;
    [FieldOffset(0x00B8)] public FVector2D Offset2;
    [FieldOffset(0x00C0)] public FVector2D Offset3;
    [FieldOffset(0x00C8)] public bool m_bLoading;
    [FieldOffset(0x00C9)] public bool m_bLoaded;
    [FieldOffset(0x00CA)] public bool m_bMainLoaded;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFadePgBattleResult
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
    [FieldOffset(0x0040)] public FPgBtlResultWipe m_PgBtlResultWipe;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFadePgBattleResultEnd
{
    [FieldOffset(0x0000)] public UFadePgBattleResult baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFadePgCircle
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFadePgColorOut
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFadePgCrossFade
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FDarkHourWork
{
    [FieldOffset(0x0020)] public USkeletalMesh* SkeletalMesh;
    [FieldOffset(0x0028)] public UAppAnimCtrl* pAnimCtrl;
    [FieldOffset(0x0030)] public UStaticMesh* pSkyBoxMesh;
    [FieldOffset(0x0038)] public AStaticMeshActor* pSkyBoxMeshActor;
    [FieldOffset(0x0040)] public UStaticMeshComponent* pSkyBoxMeshCompo;
    [FieldOffset(0x0048)] public UMaterialInterface* pLoadMaterial;
    [FieldOffset(0x0050)] public UMaterialInstanceDynamic* mMateInst;
    [FieldOffset(0x0058)] public UMaterialParameterCollection* pMpc;
    [FieldOffset(0x0088)] public TSubclassOf<AUISceneCapture> UISceneCaptureClass;
    [FieldOffset(0x0090)] public AUISceneCapture* pUISceneCapture2D;
    [FieldOffset(0x0098)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UFadePgDarkHour
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
    [FieldOffset(0x0040)] public FDarkHourWork Work;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UFadePgSlide
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UFadePgSlideVertical
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2418)] 
public unsafe struct FVelvetWipe
{
    [FieldOffset(0x0000)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0008)] public USprAsset* m_pSpr;
    [FieldOffset(0x0010)] public FGetUIParameter m_uip;
    [FieldOffset(0x0088)] public UDataTable* m_pVelvetWipeDT;
    [FieldOffset(0x0090)] public FCurveVectorAnimation m_curveOpenAnim;
    [FieldOffset(0x00C0)] public FCurveVectorAnimation m_curveFadeInAnim;
    [FieldOffset(0x00F0)] public FCurveVectorAnimation m_curveSpeedAnim;
    [FieldOffset(0x0120)] public FCurveVectorAnimation m_curveCenterDoorSpeedAnim;
    [FieldOffset(0x0150)] public UTexture* m_pCaptureTex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2458)] 
public unsafe struct UFadePgVelvet
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
    [FieldOffset(0x0040)] public FVelvetWipe m_velvetWipe;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2458)] 
public unsafe struct UFadePgVelvetReturn
{
    [FieldOffset(0x0000)] public UFadeProgramBase baseObj;
    [FieldOffset(0x0040)] public FVelvetWipe m_velvetWipe;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFadeProperties
{
    [FieldOffset(0x0000)] public int Frame;
    [FieldOffset(0x0004)] public int RenderTargetOt;
    [FieldOffset(0x0008)] public int CaptureTargetOt;
    [FieldOffset(0x000C)] public bool UseCapture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UFadePlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0088)] public TArray<IntPtr> Programs_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C0)] 
public unsafe struct AFclShopBase
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x0368)] public AScrActor* ScrActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x530)] 
public unsafe struct AFclAntiqueShop
{
    [FieldOffset(0x0000)] public AFclShopBase baseObj;
    [FieldOffset(0x03C0)] public UAssetLoader* Loader_;
    [FieldOffset(0x03C8)] public UAntiqueShopLineUpListTable* LineupTable_;
    [FieldOffset(0x03D0)] public UBfAsset* BfAsset_;
    [FieldOffset(0x03D8)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x03E0)] public USprAsset* _ComSpr00;
    [FieldOffset(0x03E8)] public UPlgAsset* _ComPlg00;
    [FieldOffset(0x03F0)] public USprAsset* _Spr00;
    [FieldOffset(0x03F8)] public UPlgAsset* _Plg00;
    [FieldOffset(0x0400)] public UDataTable* pParamLayoutDataAntique;
    [FieldOffset(0x0408)] public TSubclassOf<AFclAntiqueShopDrawActor> _DrawActorClass;
    [FieldOffset(0x0410)] public AFclAntiqueShopDrawActor* _DrawActor;
    [FieldOffset(0x0460)] public UDataTable* LayoutData;
    [FieldOffset(0x0468)] public UDataTable* TextColLayoutData;
    [FieldOffset(0x0470)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0478)] public UUILayoutDataTable* TextColLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x23D0)] 
public unsafe struct UAntiqueShopDrawCommon
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x1E28)] public AUICloudCursorDraw* _pCloudCursor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFclWeaponShopDrawActorBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UMcaAsset* _CurrentMcaAsset;
    [FieldOffset(0x0280)] public ACameraActor* _CurrentCamera;
    [FieldOffset(0x0288)] public AActor* _OldCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FWeaponShopDrawParam
{
    [FieldOffset(0x0000)] public FVector2D _Position;
    [FieldOffset(0x0008)] public FVector2D _ScaleOrWH;
    [FieldOffset(0x0010)] public float _Angle;
    [FieldOffset(0x0014)] public float _GenericValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FWeaponShopAnimParam
{
    [FieldOffset(0x0000)] public FWeaponShopDrawParam _StartParam;
    [FieldOffset(0x0018)] public FWeaponShopDrawParam _EndParam;
    [FieldOffset(0x0030)] public float _WaitTime;
    [FieldOffset(0x0038)] public UCurveFloat* _InterpCurve;
    [FieldOffset(0x0040)] public float _InterpCoefficient;
    [FieldOffset(0x0044)] public float _InterpTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA10)] 
public unsafe struct AFclAntiqueShopDrawActor
{
    [FieldOffset(0x0000)] public AFclWeaponShopDrawActorBase baseObj;
    [FieldOffset(0x02E0)] public UAntiqueShopDrawCommon* _CommonData;
    [FieldOffset(0x02E8)] public FColor _ListUnselectedStringColor;
    [FieldOffset(0x02EC)] public FColor _ListPanelColor;
    [FieldOffset(0x02F0)] public FColor _DetailPanelHyphenColor;
    [FieldOffset(0x02F4)] public FColor _MatIconDisabledColor;
    [FieldOffset(0x02F8)] public FColor _MatNamelDisabledColor;
    [FieldOffset(0x02FC)] public FColor _MatNumberDisabledColor;
    [FieldOffset(0x0300)] public FColor _BgColor;
    [FieldOffset(0x0308)] public FWeaponShopAnimParam _TopMenuList1stAnim;
    [FieldOffset(0x0350)] public FWeaponShopAnimParam _TopMenuListAnim;
    [FieldOffset(0x0398)] public FWeaponShopAnimParam _TopMenuListOutAnim;
    [FieldOffset(0x03E0)] public FWeaponShopAnimParam _TopMenuKanban1stAnim;
    [FieldOffset(0x0428)] public FWeaponShopAnimParam _TopMenuKanbanAnim;
    [FieldOffset(0x0470)] public FWeaponShopAnimParam _TopMenuKanbanOutAnim;
    [FieldOffset(0x04B8)] public FWeaponShopAnimParam _TopMenuMoonAnim;
    [FieldOffset(0x0500)] public FWeaponShopAnimParam _TopMenuMoonLoopAnim;
    [FieldOffset(0x0548)] public FWeaponShopAnimParam _TopMenuMoonOutAnim;
    [FieldOffset(0x0590)] public FWeaponShopAnimParam _ListCursorBaseInAnim;
    [FieldOffset(0x05D8)] public FWeaponShopAnimParam _ListCursorInAnim;
    [FieldOffset(0x0620)] public FWeaponShopAnimParam _ListTriangleCursorInAnim;
    [FieldOffset(0x0668)] public FWeaponShopAnimParam _ListTriangleCursorLoopAnim;
    [FieldOffset(0x06B0)] public FWeaponShopAnimParam _CompareBaseShiftAnim;
    [FieldOffset(0x06F8)] public FWeaponShopAnimParam _CompareMoonRotateAnim;
    [FieldOffset(0x0740)] public FWeaponShopAnimParam _CompareCharacterMoonRotateAnim;
    [FieldOffset(0x0788)] public FWeaponShopAnimParam _CompareOutAnim;
    [FieldOffset(0x07D0)] public FWeaponShopAnimParam _LRCursorLoopAnim;
    [FieldOffset(0x0818)] public FWeaponShopAnimParam _LRCursorInputAnim;
    [FieldOffset(0x0860)] public FWeaponShopAnimParam _UDCursorLoopAnim;
    [FieldOffset(0x08A8)] public FWeaponShopAnimParam _UDCursorInputAnim;
    [FieldOffset(0x08F0)] public FWeaponShopAnimParam _ParamUpDownAnim;
    [FieldOffset(0x0938)] public FWeaponShopAnimParam _SellListCursorBaseInAnim;
    [FieldOffset(0x0980)] public FWeaponShopAnimParam _SellListCursorInAnim;
    [FieldOffset(0x09C8)] public FWeaponShopAnimParam _ParamUpDownLoopAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1128)] 
public unsafe struct AFclItemShop
{
    [FieldOffset(0x0000)] public AFclShopBase baseObj;
    [FieldOffset(0x09A0)] public USprAsset* m_pSpr_ItemShop;
    [FieldOffset(0x09A8)] public USprAsset* m_pSpr_Common;
    [FieldOffset(0x09B0)] public UPlgAsset* m_pTex_ItemShopPlg;
    [FieldOffset(0x09B8)] public UPlgAsset* m_pTex_CommonPlg;
    [FieldOffset(0x09C0)] public UTexture* m_pTex_Medisine1;
    [FieldOffset(0x09C8)] public UTexture* m_pTex_Medisine2;
    [FieldOffset(0x09D0)] public UTexture* m_pTex_Medisine3;
    [FieldOffset(0x09D8)] public UTexture* m_pTex_Medisine4;
    [FieldOffset(0x09E0)] public UTexture* m_pTex_CapusleA_1;
    [FieldOffset(0x09E8)] public UTexture* m_pTex_CapusleB_1;
    [FieldOffset(0x09F0)] public UTexture* m_pTex_CapusleC_1;
    [FieldOffset(0x09F8)] public UTexture* m_pTex_CapusleShadow;
    [FieldOffset(0x0A00)] public USprAsset* m_pSpr_Common_Money;
    [FieldOffset(0x0FC0)] public UAssetLoader* Loader_;
    [FieldOffset(0x0FC8)] public UItemShopLineUpListTable* LineupTable_;
    [FieldOffset(0x0FD0)] public UBfAsset* BfAsset_;
    [FieldOffset(0x0FD8)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x0FE8)] public UUimAsset* m_pUimCapsuleAIn;
    [FieldOffset(0x0FF0)] public UUimAsset* m_pUimCapsuleBIn;
    [FieldOffset(0x0FF8)] public UUimAsset* m_pUimCapsuleCIn;
    [FieldOffset(0x1000)] public UUimAsset* m_pUimCapsuleAChange;
    [FieldOffset(0x1008)] public UUimAsset* m_pUimCapsuleBChange;
    [FieldOffset(0x1010)] public UUimAsset* m_pUimCapsuleCChange;
    [FieldOffset(0x1018)] public UUimAsset* m_pUimCapsuleAOut1;
    [FieldOffset(0x1020)] public UUimAsset* m_pUimCapsuleBOut1;
    [FieldOffset(0x1028)] public UUimAsset* m_pUimCapsuleCOut1;
    [FieldOffset(0x1030)] public UUimAsset* m_pUimCapsuleAOut2;
    [FieldOffset(0x1038)] public UUimAsset* m_pUimCapsuleBOut2;
    [FieldOffset(0x1040)] public UUimAsset* m_pUimCapsuleCOut2;
    [FieldOffset(0x1048)] public AUICloudCursorDraw* CloudCursor_;
    [FieldOffset(0x1080)] public UUILayoutDataTable* m_pTextDataTable;
    [FieldOffset(0x1088)] public UDataTable* m_pTextData;
    [FieldOffset(0x1090)] public UUILayoutDataTable* m_pLayoutDataTable;
    [FieldOffset(0x1098)] public UDataTable* m_pLayoutData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x520)] 
public unsafe struct AFclSimpleShop
{
    [FieldOffset(0x0000)] public AFclShopBase baseObj;
    [FieldOffset(0x03D8)] public ASimpleShopDraw* ShopDraw;
    [FieldOffset(0x03E0)] public UFrameBufferCapture* captureBackGround;
    [FieldOffset(0x03F0)] public UTexture* tex;
    [FieldOffset(0x0400)] public UAssetLoader* Loader_;
    [FieldOffset(0x0420)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0428)] public UDataTable* pTextParamLayoutData;
    [FieldOffset(0x0430)] public UUILayoutDataTable* pLayoutDataTable;
    [FieldOffset(0x0438)] public UUILayoutDataTable* pTextLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x580)] 
public unsafe struct AFclWeaponShop
{
    [FieldOffset(0x0000)] public AFclShopBase baseObj;
    [FieldOffset(0x03C0)] public UAssetLoader* Loader_;
    [FieldOffset(0x03C8)] public UWeaponShopLineUpListTable* LineupTable_;
    [FieldOffset(0x03D0)] public UBfAsset* BfAsset_;
    [FieldOffset(0x03D8)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x03E0)] public USprAsset* _ComSpr00;
    [FieldOffset(0x03E8)] public UPlgAsset* _ComPlg00;
    [FieldOffset(0x03F0)] public USprAsset* _Spr00;
    [FieldOffset(0x03F8)] public UPlgAsset* _Plg00;
    [FieldOffset(0x0400)] public UDataTable* pParamLayoutDataRoot;
    [FieldOffset(0x0408)] public UUILayoutDataTable* pLayoutDataTableRoot;
    [FieldOffset(0x0410)] public UDataTable* pParamLayoutDataChara;
    [FieldOffset(0x0418)] public UUILayoutDataTable* pLayoutDataTableChara;
    [FieldOffset(0x0420)] public UDataTable* pParamLayoutDataCharaText;
    [FieldOffset(0x0428)] public UUILayoutDataTable* pLayoutDataTableCharaText;
    [FieldOffset(0x0430)] public UDataTable* pParamLayoutDataBuyText;
    [FieldOffset(0x0438)] public UUILayoutDataTable* pLayoutDataTableBuyText;
    [FieldOffset(0x0440)] public UDataTable* pParamLayoutDataBuyHelpText;
    [FieldOffset(0x0448)] public UUILayoutDataTable* pLayoutDataTableBuyHelpText;
    [FieldOffset(0x0450)] public UDataTable* pParamLayoutDataSellText;
    [FieldOffset(0x0458)] public UUILayoutDataTable* pLayoutDataTableSellText;
    [FieldOffset(0x0460)] public UDataTable* pParamLayoutDataTradeInText;
    [FieldOffset(0x0468)] public UUILayoutDataTable* pLayoutDataTableTradeInText;
    [FieldOffset(0x0470)] public UDataTable* pParamLayoutDataOther;
    [FieldOffset(0x0478)] public UUILayoutDataTable* pLayoutDataTableOther;
    [FieldOffset(0x0480)] public TSubclassOf<AFclWeaponShopDrawActor> _DrawActorClass;
    [FieldOffset(0x0488)] public AFclWeaponShopDrawActor* _DrawActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3778)] 
public unsafe struct UWeaponShopDrawCommon
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x36B8)] public AUICloudCursorDraw* _pCloudCursor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xAC0)] 
public unsafe struct AFclWeaponShopDrawActor
{
    [FieldOffset(0x0000)] public AFclWeaponShopDrawActorBase baseObj;
    [FieldOffset(0x02D8)] public UWeaponShopDrawCommon* _CommonData;
    [FieldOffset(0x02E0)] public FColor _BgColor;
    [FieldOffset(0x02E4)] public FColor _InfoWindowInnerColor;
    [FieldOffset(0x02E8)] public FWeaponShopAnimParam _TopMenuAnim;
    [FieldOffset(0x0330)] public FWeaponShopAnimParam _CatIconAnim;
    [FieldOffset(0x0378)] public FWeaponShopAnimParam _TapeAnim;
    [FieldOffset(0x03C0)] public FWeaponShopAnimParam _TapeChangeAnim;
    [FieldOffset(0x0408)] public FWeaponShopAnimParam _EquipCompareTapeAnim;
    [FieldOffset(0x0450)] public FWeaponShopAnimParam _ListCursorBaseInAnim;
    [FieldOffset(0x0498)] public FWeaponShopAnimParam _ListCursorInAnim;
    [FieldOffset(0x04E0)] public FWeaponShopAnimParam _ListTriangleCursorInAnim;
    [FieldOffset(0x0528)] public FWeaponShopAnimParam _ListTriangleCursorLoopAnim;
    [FieldOffset(0x0570)] public FWeaponShopAnimParam _LRCursorLoopAnim;
    [FieldOffset(0x05B8)] public FWeaponShopAnimParam _LRCursorInputAnim;
    [FieldOffset(0x0600)] public FWeaponShopAnimParam _UDCursorLoopAnim;
    [FieldOffset(0x0648)] public FWeaponShopAnimParam _UDCursorInputAnim;
    [FieldOffset(0x0690)] public FWeaponShopAnimParam _RevolverAnim;
    [FieldOffset(0x06D8)] public TArray<FWeaponShopAnimParam> _DecideConfirmPanelAnimArray;
    [FieldOffset(0x06E8)] public TArray<FWeaponShopAnimParam> _NumConfirmPanelAnimArray;
    [FieldOffset(0x06F8)] public TArray<FWeaponShopAnimParam> _MoneyWindowAnimArray;
    [FieldOffset(0x0708)] public FWeaponShopAnimParam _EquipCompareInAnim;
    [FieldOffset(0x0750)] public FWeaponShopAnimParam _EquipCompareOutAnim;
    [FieldOffset(0x0798)] public FWeaponShopAnimParam _ParamUpDownAnim;
    [FieldOffset(0x07E0)] public TArray<FWeaponShopAnimParam> _PicUpAnimArray;
    [FieldOffset(0x07F0)] public FWeaponShopAnimParam _SellListCursorBaseInAnim;
    [FieldOffset(0x0838)] public FWeaponShopAnimParam _SellListCursorInAnim;
    [FieldOffset(0x0880)] public FWeaponShopAnimParam _ParamUpDownLoopAnim;
    [FieldOffset(0x08C8)] public FWeaponShopAnimParam _ListInAnim;
    [FieldOffset(0x0910)] public FWeaponShopAnimParam _CharaEquipListInAnim;
    [FieldOffset(0x0958)] public FWeaponShopAnimParam _TopMenuOutAnim;
    [FieldOffset(0x09A0)] public FWeaponShopAnimParam _CatIconOutAnim;
    [FieldOffset(0x09E8)] public FWeaponShopAnimParam _TapeOutAnim;
    [FieldOffset(0x0A30)] public FWeaponShopAnimParam _CharaListCursorInAnim;
    [FieldOffset(0x0A78)] public FWeaponShopAnimParam _SellInfoInAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFileNameList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Path;
    [FieldOffset(0x0018)] public FString Name;
    [FieldOffset(0x0028)] public int chunk;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFileNameListAssets
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FFileNameList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AUFileNameManagerrActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UAssetLoader* mAssetLoader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UFileNameManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader;
    [FieldOffset(0x0030)] public UDataAsset* TableFileName;
    [FieldOffset(0x0040)] public AUFileNameManagerrActor* mActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UFldLocalActorComp
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FFldAnimalParam
{
    [FieldOffset(0x0000)] public float mWalkSpeed;
    [FieldOffset(0x0004)] public float mRunSpeed;
    [FieldOffset(0x0008)] public float mRotSpeed;
    [FieldOffset(0x000C)] public float mIdleTimeFix;
    [FieldOffset(0x0010)] public float mIdleTimeRnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UFldAnimalCompCore
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public int mIndex_;
    [FieldOffset(0x00CC)] public bool bIsEscape_;
    [FieldOffset(0x00CD)] public bool bIsNotComeBack_;
    [FieldOffset(0x00D0)] public float mSceneOutTimeFix_;
    [FieldOffset(0x00D4)] public float mSceneOutTimeRnd_;
    [FieldOffset(0x00D8)] public float mEscapeRadius_;
    [FieldOffset(0x00DC)] public FFldAnimalParam mParamater_;
    [FieldOffset(0x00F4)] public FVector mEscapeVector_;
    [FieldOffset(0x0108)] public AAppPropsCore* mOwnerAnimal_;
    [FieldOffset(0x0110)] public bool mInitDisp_;
    [FieldOffset(0x0120)] public FTransform mInitTransform_;
    [FieldOffset(0x0150)] public AFldAnimalHit* mEscapeHit_;
    [FieldOffset(0x0158)] public TArray<IntPtr> mOverlapTargets_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UFldAnimalComp_BIRD
{
    [FieldOffset(0x0000)] public UFldAnimalCompCore baseObj;
    [FieldOffset(0x0168)] public bool bWalkAfterLanding_;
    [FieldOffset(0x016C)] public float mFlyPitch_;
    [FieldOffset(0x0170)] public float mFlyAwayTime_;
    [FieldOffset(0x0174)] public float mFlyAwayDist_;
    [FieldOffset(0x0178)] public float mComebackTime_;
    [FieldOffset(0x017C)] public float mComebackDist_;
    [FieldOffset(0x0180)] public bool bAutoFlyAway_;
    [FieldOffset(0x0184)] public float mAutoFlyAwayTimeFix_;
    [FieldOffset(0x0188)] public float mAutoFlyAwayTimeRnd_;
    [FieldOffset(0x018C)] public float mAutoFlyAwayYaw_;
    [FieldOffset(0x0190)] public bool bIsMove_;
    [FieldOffset(0x0194)] public float mMoveTimeFix_;
    [FieldOffset(0x0198)] public float mMoveTimeRnd_;
    [FieldOffset(0x019C)] public float mMoveDist_;
    [FieldOffset(0x01A0)] public float mMoveRadius_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldCatMotionList
{
    [FieldOffset(0x0000)] public TArray<EFldAnimalMotion_CAT> mList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UFldAnimalComp_CAT
{
    [FieldOffset(0x0000)] public UFldAnimalCompCore baseObj;
    [FieldOffset(0x0168)] public TArray<FFldCatMotionList> mMotionPattern_;
    [FieldOffset(0x0178)] public float mEscapeTime_;
    [FieldOffset(0x017C)] public float mEscapeDist_;
    [FieldOffset(0x0180)] public float mComebackDist_;
    [FieldOffset(0x0184)] public bool bEscapeYawFixed_;
    [FieldOffset(0x0188)] public float mEscapeFixedYaw_;
    [FieldOffset(0x018C)] public bool bAutoWalkAway_;
    [FieldOffset(0x0190)] public float mAutoWalkAwayTimeFix_;
    [FieldOffset(0x0194)] public float mAutoWalkAwayTimeRnd_;
    [FieldOffset(0x0198)] public float mAutoWalkAwayYaw_;
    [FieldOffset(0x019C)] public float mAutoWalkAwayDist_;
    [FieldOffset(0x01A0)] public bool bFixedMove_;
    [FieldOffset(0x01A4)] public float mFixedMoveTimeFix_;
    [FieldOffset(0x01A8)] public float mFixedMoveTimeRnd_;
    [FieldOffset(0x01B0)] public FTransform mFixedMoveTransform_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UFldAnimalComp_PIGEON
{
    [FieldOffset(0x0000)] public UFldAnimalComp_BIRD baseObj;
    [FieldOffset(0x01C0)] public float mRunAwayDist_;
    [FieldOffset(0x01C4)] public float mHeroNearDist_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldLocalActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldAnimalHit
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public UFldAnimalCompCore* mOwner_;
    [FieldOffset(0x0288)] public float mHitRadius_;
    [FieldOffset(0x0290)] public USphereComponent* mHitComp_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldObjBase
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public FName mOnFlagName_;
    [FieldOffset(0x0288)] public FName mOffFlagName_;
    [FieldOffset(0x0290)] public ECldWeek mOnWeek_;
    [FieldOffset(0x0291)] public bool bIsOnWeek_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldAnimeObjAnimation
{
    [FieldOffset(0x0000)] public UAnimationAsset* mAsset;
    [FieldOffset(0x0008)] public bool mLoop;
    [FieldOffset(0x0010)] public UNiagaraSystem* mNiagara;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AFldAnimObj
{
    [FieldOffset(0x0000)] public AFldObjBase baseObj;
    [FieldOffset(0x0298)] public TArray<FFldAnimeObjAnimation> mAnimeArray_;
    [FieldOffset(0x02A8)] public int mIndex_;
    [FieldOffset(0x02AC)] public bool mNotPausedInLoop_;
    [FieldOffset(0x02B0)] public USkeletalMeshComponent* mAnimeMesh_;
    [FieldOffset(0x02B8)] public UNiagaraComponent* mNiagaraComp_;
    [FieldOffset(0x02C0)] public TArray<IntPtr> mAnimeMeshList_;
    [FieldOffset(0x02D0)] public int mAnimIndex_;
    [FieldOffset(0x02D4)] public bool bIsInit_;
    [FieldOffset(0x02D8)] public int mLoopAnimIndex_;
    [FieldOffset(0x02DC)] public bool mIsHide_;
    [FieldOffset(0x02E0)] public FTransform mHideTransform_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldAtomSound
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public bool mSeasonSpring_;
    [FieldOffset(0x0281)] public bool mSeasonSummer_;
    [FieldOffset(0x0282)] public bool mSeasonAutumn_;
    [FieldOffset(0x0283)] public bool mSeasonWinter_;
    [FieldOffset(0x0284)] public bool mTimeNoon_;
    [FieldOffset(0x0285)] public bool mTimeAfternoon_;
    [FieldOffset(0x0286)] public bool mTimeNight_;
    [FieldOffset(0x0287)] public bool mTimeShadow_;
    [FieldOffset(0x0288)] public bool mOffInEvent_;
    [FieldOffset(0x028C)] public FName mOnFlagName_;
    [FieldOffset(0x0294)] public FName mOffFlagName_;
    [FieldOffset(0x02A0)] public UAtomComponent* AtomComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldScriptManagerCore
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0290)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x0298)] public UBfAsset* mBfAsset_;
    [FieldOffset(0x02A0)] public UBmdAsset* mBmdAsset_;
    [FieldOffset(0x02A8)] public AFldScriptActor* mScriptActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldAutoRecoverMenuScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldBossBattleScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldBpFuncLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldPlayerHolder
{
    [FieldOffset(0x0000)] public APawn* Pawn;
    [FieldOffset(0x0008)] public UFldPlayerComp* PlayerComp;
    [FieldOffset(0x0010)] public UFldPlayerDungeonComp* DungeonComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct AFldCameraBase
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USceneComponent* YawSceneComp;
    [FieldOffset(0x0228)] public USceneComponent* PitchSceneComp;
    [FieldOffset(0x0230)] public UCameraComponent* CameraComp;
    [FieldOffset(0x0238)] public AFldCameraHitBase* HitRef;
    [FieldOffset(0x0240)] public FFldPlayerHolder PlayerRef;
    [FieldOffset(0x0258)] public bool bIsCurrent;
    [FieldOffset(0x025C)] public FVector Input;
    [FieldOffset(0x0268)] public bool bZoom;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7B0)] 
public unsafe struct AFldCamera
{
    [FieldOffset(0x0000)] public ACameraActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UFldCameraBehaviorBase
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public AFldCameraBase* BaseOwner;
    [FieldOffset(0x00B8)] public EFldCameraForwardType ForwardType;
    [FieldOffset(0x00C0)] public AActor* FreeForward;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UFldCameraBehaviorFixed
{
    [FieldOffset(0x0000)] public UFldCameraBehaviorBase baseObj;
    [FieldOffset(0x00C8)] public float FixedYaw;
    [FieldOffset(0x00CC)] public float FixedPitch;
    [FieldOffset(0x00D0)] public float MarginYaw;
    [FieldOffset(0x00D4)] public float MarginPitch;
    [FieldOffset(0x00D8)] public float RotSpeed;
    [FieldOffset(0x00DC)] public bool MarginForward;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FldCameraRotParam
{
    [FieldOffset(0x0000)] public float Speed;
    [FieldOffset(0x0004)] public float Acceleration;
    [FieldOffset(0x0008)] public float Deceleration;
    [FieldOffset(0x000C)] public float Press;
    [FieldOffset(0x0010)] public float Release;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FldCameraCorrectionParam
{
    [FieldOffset(0x0000)] public FldCameraRotParam baseObj;
    [FieldOffset(0x001C)] public float Margin;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FldCameraSlopeParam
{
    [FieldOffset(0x0000)] public FldCameraRotParam baseObj;
    [FieldOffset(0x001C)] public float Margin;
    [FieldOffset(0x0020)] public float Pitch;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FldCameraParam
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UFldCameraBehaviorFree
{
    [FieldOffset(0x0000)] public UFldCameraBehaviorBase baseObj;
    [FieldOffset(0x00C8)] public AFldCameraFree* DrivedOwner;
    [FieldOffset(0x00D0)] public FFldPlayerHolder Player;
    [FieldOffset(0x00E8)] public FldCameraRotParam YawParam;
    [FieldOffset(0x0104)] public FldCameraRotParam PitchParam;
    [FieldOffset(0x0120)] public FldCameraCorrectionParam CorrectionParam;
    [FieldOffset(0x0140)] public FldCameraSlopeParam SlopeParam;
    [FieldOffset(0x0164)] public float FarLength;
    [FieldOffset(0x0168)] public float NearLength;
    [FieldOffset(0x016C)] public FVector Offset;
    [FieldOffset(0x0178)] public float ZoomTime;
    [FieldOffset(0x017C)] public float InitialPitch;
    [FieldOffset(0x0180)] public float DefaultMoveSpeed;
    [FieldOffset(0x0184)] public float NormalFov;
    [FieldOffset(0x0188)] public float DashFov;
    [FieldOffset(0x018C)] public float FovAnimSpeed;
    [FieldOffset(0x0190)] public float ExtrusionSpeed;
    [FieldOffset(0x0194)] public float UpLimitBegin;
    [FieldOffset(0x0198)] public float UpLimitEnd;
    [FieldOffset(0x019C)] public float UpLimitLength;
    [FieldOffset(0x01A0)] public FVector UpLimitOffset;
    [FieldOffset(0x01AC)] public float DownLimitBegin;
    [FieldOffset(0x01B0)] public float DownLimitEnd;
    [FieldOffset(0x01B4)] public float DownLimitLength;
    [FieldOffset(0x01B8)] public FVector DownLimitOffset;
    [FieldOffset(0x01C4)] public float BlurAmount;
    [FieldOffset(0x01C8)] public float PushOutOffset;
    [FieldOffset(0x0220)] public EFldCameraBehaviorFreeState State;
    [FieldOffset(0x0224)] public EFldCameraBehaviorFreeState NextState;
    [FieldOffset(0x0228)] public FVector StoredInput;
    [FieldOffset(0x0234)] public float AnimTime;
    [FieldOffset(0x0238)] public FldCameraParam ResetParam;
    [FieldOffset(0x0254)] public bool bResetDirectionOnce;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AFldCameraFixed
{
    [FieldOffset(0x0000)] public AFldCameraBase baseObj;
    [FieldOffset(0x0270)] public UFldCameraBehaviorFixed* Behavior;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AFldCameraFree
{
    [FieldOffset(0x0000)] public AFldCameraBase baseObj;
    [FieldOffset(0x0270)] public UFldCameraBehaviorFree* Behavior;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FldCameraLockAtParam
{
    [FieldOffset(0x0000)] public bool bEnable;
    [FieldOffset(0x0004)] public float MinLimitAngle;
    [FieldOffset(0x0008)] public float MaxLimitAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct AFldCameraHitBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UFldCameraTransBase* Transition;
    [FieldOffset(0x0280)] public FldCameraLockAtParam LockAtYaw;
    [FieldOffset(0x028C)] public FldCameraLockAtParam LockAtPitch;
    [FieldOffset(0x0298)] public bool LockAtForward;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AFldCameraHitBox
{
    [FieldOffset(0x0000)] public AFldCameraHitBase baseObj;
    [FieldOffset(0x02E0)] public UBoxComponent* Box;
    [FieldOffset(0x02E8)] public AFldCameraFixed* Camera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A8)] 
public unsafe struct AFldCameraHitSpline
{
    [FieldOffset(0x0000)] public AFldCameraHitBase baseObj;
    [FieldOffset(0x02E0)] public UBoxComponent* BoxComp;
    [FieldOffset(0x02E8)] public USplineComponent* SplineComp;
    [FieldOffset(0x02F0)] public USplineComponent* CameraSplineComp;
    [FieldOffset(0x02F8)] public TMap<int, IntPtr> CameraList;
    [FieldOffset(0x0348)] public EFldCameraForwardType ForwardType;
    [FieldOffset(0x0350)] public AActor* FreeForward;
    [FieldOffset(0x0358)] public bool bTracking;
    [FieldOffset(0x035C)] public float TrackingDistance;
    [FieldOffset(0x0360)] public float TrackingBufferZone_Player;
    [FieldOffset(0x0364)] public float TrackingBufferZone_Camera;
    [FieldOffset(0x0368)] public float MarginYaw;
    [FieldOffset(0x036C)] public float MarginPitch;
    [FieldOffset(0x0370)] public float MarginSpeed;
    [FieldOffset(0x0374)] public bool MarginForward;
    [FieldOffset(0x0394)] public bool bFanShape;
    [FieldOffset(0x0398)] public float Yaw_FrontOffset;
    [FieldOffset(0x039C)] public float Yaw_BackOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct AFldCameraSpline
{
    [FieldOffset(0x0000)] public AFldCameraBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UFldCameraTransBase
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public bool bIdentifyAngle;
    [FieldOffset(0x00CC)] public float ComplementaryAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UFldCameraTransLinear
{
    [FieldOffset(0x0000)] public UFldCameraTransBase baseObj;
    [FieldOffset(0x00D0)] public float TotalTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldCameraUtility
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UFldCharAccessIconMngComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public UAppCharBaseComp* mCharaBaseComp_;
    [FieldOffset(0x00D0)] public AActor* mIconActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UFldCharAttackAnimNotify
{
    [FieldOffset(0x0000)] public UAnimNotify baseObj;
    [FieldOffset(0x0038)] public EFldCharAttackAnimNotifyFlag flag;
    [FieldOffset(0x003C)] public bool bEnable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct AFldCharArea
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USceneComponent* RootComp;
    [FieldOffset(0x0228)] public UBoxComponent* AreaComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldCharSpeed
{
    [FieldOffset(0x0000)] public float Walk;
    [FieldOffset(0x0004)] public float Run;
    [FieldOffset(0x0008)] public float Dash;
    [FieldOffset(0x000C)] public float Assault;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldCharMinorBgData
{
    [FieldOffset(0x0000)] public FFldCharSpeed Speed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FFldCharMajorBgData
{
    [FieldOffset(0x0000)] public TMap<int, FFldCharMinorBgData> Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FFldPlayerInputInterpolationData
{
    [FieldOffset(0x0000)] public float MinAgnle;
    [FieldOffset(0x0004)] public int MinFrame;
    [FieldOffset(0x0008)] public float MaxAgnle;
    [FieldOffset(0x000C)] public int MaxFrame;
    [FieldOffset(0x0010)] public float Border;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldPlayerAttackData
{
    [FieldOffset(0x0000)] public EDungeonAnimID AnimId;
    [FieldOffset(0x0004)] public float AnimBlendTime;
    [FieldOffset(0x0008)] public int WeaponAnimId;
    [FieldOffset(0x000C)] public float BeginReceivingInputTime;
    [FieldOffset(0x0010)] public float EndReceivingInputTime;
    [FieldOffset(0x0014)] public float SwitchNextAttackTime;
    [FieldOffset(0x0018)] public float SwitchFreeStateTime;
    [FieldOffset(0x001C)] public float SlideRot;
    [FieldOffset(0x0020)] public float SlideScaleTime;
    [FieldOffset(0x0024)] public float SlideScale;
    [FieldOffset(0x0028)] public int VoiceId;
    [FieldOffset(0x002C)] public int NextAttackId;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFldPlayerAttackGuideData
{
    [FieldOffset(0x0000)] public float Range;
    [FieldOffset(0x0004)] public float Angle;
    [FieldOffset(0x0008)] public float GuideAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FRumbleParam
{
    [FieldOffset(0x0000)] public int power;
    [FieldOffset(0x0004)] public int Frame;
    [FieldOffset(0x0008)] public int WaitFrame;
    [FieldOffset(0x000C)] public int Num;
    [FieldOffset(0x0010)] public int TotalFram;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FRumbleData
{
    [FieldOffset(0x0000)] public FRumbleParam Encount;
    [FieldOffset(0x0014)] public FRumbleParam PinchEncount;
    [FieldOffset(0x0028)] public FRumbleParam Broken;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FFldPlayerData
{
    [FieldOffset(0x0000)] public float InputDeadZone;
    [FieldOffset(0x0004)] public float InputWalkZone;
    [FieldOffset(0x0008)] public FFldPlayerInputInterpolationData InputInterpolation;
    [FieldOffset(0x001C)] public float Acceleration;
    [FieldOffset(0x0020)] public float Deceleration;
    [FieldOffset(0x0024)] public float RotSpeed;
    [FieldOffset(0x0028)] public float RotSpeed_Walk;
    [FieldOffset(0x002C)] public float TurnSpeed;
    [FieldOffset(0x0030)] public float TurnMoveRot;
    [FieldOffset(0x0034)] public float BrakingTime;
    [FieldOffset(0x0038)] public float BrakingSlideTime;
    [FieldOffset(0x003C)] public float ReverseBrakingTime;
    [FieldOffset(0x0040)] public float ReverseBrakingSlideTime;
    [FieldOffset(0x0044)] public float EncoutRadius;
    [FieldOffset(0x0048)] public float SwitchingTimeToAssault;
    [FieldOffset(0x004C)] public float SwitchingTimeToAssaultLv2;
    [FieldOffset(0x0050)] public float AssaultGetTpLv1;
    [FieldOffset(0x0054)] public float AssaultGetTpLv2;
    [FieldOffset(0x0058)] public int AssaultUpsetRateLv1;
    [FieldOffset(0x005C)] public int AssaultUpsetRateLv2;
    [FieldOffset(0x0060)] public int IdleAttackId;
    [FieldOffset(0x0064)] public int WalkAttackId;
    [FieldOffset(0x0068)] public int RunAttackId;
    [FieldOffset(0x006C)] public int DashAttackId;
    [FieldOffset(0x0070)] public int AssaultAttackId;
    [FieldOffset(0x0074)] public float AttackToMoveBlendTime;
    [FieldOffset(0x0078)] public TMap<int, FFldPlayerAttackData> attack;
    [FieldOffset(0x00C8)] public TArray<FFldPlayerAttackGuideData> AttackGuide;
    [FieldOffset(0x00D8)] public FRumbleData Rumble;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldPartnerData
{
    [FieldOffset(0x0000)] public float TrackingBeginDistance;
    [FieldOffset(0x0004)] public float TrackingNearDistance;
    [FieldOffset(0x0008)] public float TrackingUpdateDistance;
    [FieldOffset(0x000C)] public float AvoidPlayerDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldCharKeyParam
{
    [FieldOffset(0x0000)] public EFldCharKeyType Save;
    [FieldOffset(0x0001)] public EFldCharKeyType AutoRecover;
    [FieldOffset(0x0002)] public EFldCharKeyType DailyMenu;
    [FieldOffset(0x0003)] public EFldCharKeyType DungeonMenu;
    [FieldOffset(0x0004)] public EFldCharKeyType Camp;
    [FieldOffset(0x0005)] public EFldCharKeyType LargeMap;
    [FieldOffset(0x0006)] public EFldCharKeyType BackLog;
    [FieldOffset(0x0007)] public EFldCharKeyType VoiceActionDisp;
    [FieldOffset(0x0008)] public EFldCharKeyType Check;
    [FieldOffset(0x0009)] public EFldCharKeyType attack;
    [FieldOffset(0x000A)] public EFldCharKeyType CameraZoomIn;
    [FieldOffset(0x000B)] public EFldCharKeyType CameraZoomOut;
    [FieldOffset(0x0010)] public TArray<EFldCharKeyType> CameraDefault;
    [FieldOffset(0x0020)] public EFldCharKeyType DebugCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct UFldCharDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FFldCharSpeed DailySpeed;
    [FieldOffset(0x0040)] public FFldCharSpeed DungeonSpeed;
    [FieldOffset(0x0050)] public TMap<int, FFldCharMajorBgData> MajorBg;
    [FieldOffset(0x00A0)] public FFldPlayerData Player;
    [FieldOffset(0x01B8)] public FFldPartnerData Partner;
    [FieldOffset(0x01C8)] public FFldCharKeyParam Key;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UFldCharParamTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSoftObjectPtr<UFldCharDataAsset> Path;
    [FieldOffset(0x0050)] public UFldCharDataAsset* Data;
    [FieldOffset(0x0058)] public bool bLoaded;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UFldCharEmotionIconMngComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public UAppCharBaseComp* mCharaBaseComp_;
    [FieldOffset(0x00D0)] public AHandwritingSpawner* mHandwritingSpawner_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldPmtCostumeDataCore
{
    [FieldOffset(0x0000)] public int CostumeIndex;
    [FieldOffset(0x0004)] public int Setting;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldPersonalMotionData
{
    [FieldOffset(0x0000)] public int MotionID;
    [FieldOffset(0x0004)] public int IsBag;
    [FieldOffset(0x0008)] public TArray<FFldPmtCostumeDataCore> DailyCostumes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFldCharPersonalMotionComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public float mIdolTime_FIX_;
    [FieldOffset(0x00CC)] public float mIdolTime_RAND_;
    [FieldOffset(0x00D0)] public float mBlendTime_START_;
    [FieldOffset(0x00D4)] public float mBlendTime_END_;
    [FieldOffset(0x00D8)] public UAppCharBaseComp* mCharComp_;
    [FieldOffset(0x00E0)] public float mTimer_;
    [FieldOffset(0x00E4)] public float mMaxTime_;
    [FieldOffset(0x00E8)] public UAnimMontage* mAnimMontage_;
    [FieldOffset(0x00F0)] public TArray<FFldPersonalMotionData> mMotionList_BASE_;
    [FieldOffset(0x0100)] public TArray<FFldPersonalMotionData> mMotionList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldCharSysBPFL
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct AFldHitCore
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0288)] public TArray<IntPtr> mOtherList_;
    [FieldOffset(0x0298)] public int mPriority_;
    [FieldOffset(0x02A0)] public FString mBfAssetPath_;
    [FieldOffset(0x02B0)] public FString mBmdAssetPath_;
    [FieldOffset(0x02C0)] public USceneComponent* RootComp_;
    [FieldOffset(0x02C8)] public UShapeComponent* HitComp_;
    [FieldOffset(0x02D0)] public TSubclassOf<AUtlProcActor> mOverlapBluePrint_;
    [FieldOffset(0x02D8)] public bool mOverlapKeyLock_;
    [FieldOffset(0x02E0)] public TSubclassOf<AUtlProcActor> mKeyPushBluePrint_;
    [FieldOffset(0x02E8)] public bool mActionKeyLock_;
    [FieldOffset(0x02E9)] public FFldHitCoreHeroDirectType mHeroDirectType_;
    [FieldOffset(0x02EA)] public EFldHitCoreCheckIconType mCheckIcon_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldNpcCompAttachPropsParam
{
    [FieldOffset(0x0000)] public FTransform mAddTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FFldHitCharaModelParam
{
    [FieldOffset(0x0000)] public int mMajorID;
    [FieldOffset(0x0004)] public int mMinorID;
    [FieldOffset(0x0008)] public int mFbnNumber;
    [FieldOffset(0x000C)] public bool mNoCollision;
    [FieldOffset(0x0010)] public FTransform mAddTransform;
    [FieldOffset(0x0040)] public FFldNpcCompAttachPropsParam mAttachProps00;
    [FieldOffset(0x0070)] public FFldNpcCompAttachPropsParam mAttachProps01;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFldHitCharaIconParam
{
    [FieldOffset(0x0000)] public FName mFlagName;
    [FieldOffset(0x0008)] public EFldHitCharaIconType mIconType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x458)] 
public unsafe struct AFldHitCharacter
{
    [FieldOffset(0x0000)] public AFldHitCore baseObj;
    [FieldOffset(0x0340)] public UShapeComponent* CollisionComp_;
    [FieldOffset(0x0348)] public TArray<FFldHitCharaModelParam> mCharaModelParam_;
    [FieldOffset(0x0358)] public EFldHitCharaIconType mIconType_;
    [FieldOffset(0x0359)] public bool mIconPlural_;
    [FieldOffset(0x0360)] public TArray<FFldHitCharaIconParam> mChangeIconParam_;
    [FieldOffset(0x0370)] public EFldHitCharaIconAttachedType mIconAttachedType_;
    [FieldOffset(0x0374)] public FVector mIconDirectLocationMODEL_;
    [FieldOffset(0x0380)] public bool bIconDirectLocationMODEL_;
    [FieldOffset(0x0384)] public FName mReadedFlagName_;
    [FieldOffset(0x038C)] public int mFloorIndex_;
    [FieldOffset(0x0390)] public bool mLookHeroOverlap_;
    [FieldOffset(0x0391)] public bool mSpeakMotionKeyPush_;
    [FieldOffset(0x0392)] public bool mLookHeroKeyPush_;
    [FieldOffset(0x0393)] public bool mFaceingHeroKeyPush_;
    [FieldOffset(0x0394)] public EFldHitCharaHeroMotion mHeroMotionKeyPush_;
    [FieldOffset(0x0395)] public bool mReturnBaseRotator_;
    [FieldOffset(0x0398)] public TSubclassOf<ACharacterBaseCore> mCharaBaseClass_;
    [FieldOffset(0x03A0)] public TSubclassOf<ANpcBaseCore> mNpcBaseClass_;
    [FieldOffset(0x03A8)] public TMap<short, IntPtr> mCharaModelList_;
    [FieldOffset(0x03F8)] public AActor* mIconActor_;
    [FieldOffset(0x0400)] public AActor* mMoveActor_;
    [FieldOffset(0x0408)] public AActor* mHeroProcActor_;
    [FieldOffset(0x0410)] public FString mDispName_;
    [FieldOffset(0x0420)] public bool bChangedRotator_;
    [FieldOffset(0x0424)] public FRotator mBaseRotator_;
    [FieldOffset(0x0430)] public UFldHitCharaIdleTalkComp* mIdleTalkComp_;
    [FieldOffset(0x0438)] public UFldHitCharaIdleBehaviorComp* mIdleBehaviorComp_;
    [FieldOffset(0x0440)] public bool bIsIdleBehaviorCreated_;
    [FieldOffset(0x0441)] public bool bGetAwayPrevAction_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x488)] 
public unsafe struct AFldCmmActor
{
    [FieldOffset(0x0000)] public AFldHitCharacter baseObj;
    [FieldOffset(0x0458)] public int mUniqueId_;
    [FieldOffset(0x045C)] public EFldCmmNpcType mType_;
    [FieldOffset(0x0460)] public int mNameIndex_;
    [FieldOffset(0x0464)] public bool mNotMapInfoDisp_;
    [FieldOffset(0x0468)] public FVector mMapIconDirectLocation_;
    [FieldOffset(0x0474)] public bool bMapIconDirectLocation_;
    [FieldOffset(0x0478)] public FName mOnFlagName_;
    [FieldOffset(0x0480)] public FName mOffFlagName_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldCmnDataActor
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0288)] public UFldCommonData* mParent_;
    [FieldOffset(0x0290)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x0298)] public UArcAsset* mArcAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct UFldCommonData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public AFldCmnDataActor* mActor_;
    [FieldOffset(0x00B8)] public AFldTvProgramScript* mTvProgramActor_;
    [FieldOffset(0x00C0)] public AFldMailOrderScript* mMailOrderActor_;
    [FieldOffset(0x00C8)] public AFldBossBattleScript* mBossBattleActor_;
    [FieldOffset(0x00D0)] public UDataTable* mTableDat_;
    [FieldOffset(0x0188)] public UClass* mBpClass_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFldCrowdIdleBehaviorComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public float mLoopPitchTime_;
    [FieldOffset(0x00CC)] public float mPitchRadius_;
    [FieldOffset(0x00D0)] public float mLoopRollTime_;
    [FieldOffset(0x00D4)] public float mRollRadius_;
    [FieldOffset(0x00D8)] public float mPitchTimer_;
    [FieldOffset(0x00DC)] public int mPitchDir_;
    [FieldOffset(0x00E0)] public float mRollTimer_;
    [FieldOffset(0x00E4)] public int mRollDir_;
    [FieldOffset(0x00E8)] public FRotator mBaseRotator_;
    [FieldOffset(0x00F4)] public FVector mForwardVector_;
    [FieldOffset(0x0100)] public FVector mRightVector_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldCrowdNpcChildParam
{
    [FieldOffset(0x0000)] public int mColorID_G;
    [FieldOffset(0x0004)] public int mColorID_B;
    [FieldOffset(0x0008)] public float mRandomValue;
    [FieldOffset(0x000C)] public bool mGrassesOn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldCrowdNpcBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UCapsuleComponent* CapsuleComp_;
    [FieldOffset(0x0280)] public int mDispValue_;
    [FieldOffset(0x0284)] public FName mOffFlagName_;
    [FieldOffset(0x0290)] public TArray<FFldCrowdNpcChildParam> mChildParam_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UFldCrowdOpacityComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public float mTargetOpacity_;
    [FieldOffset(0x00CC)] public float mSpeed_;
    [FieldOffset(0x00D0)] public float mInvisibleRadius_;
    [FieldOffset(0x00D4)] public float mDisappearRadius_;
    [FieldOffset(0x00D8)] public float mOpacity_;
    [FieldOffset(0x00DC)] public FAppCharTransparency mTransparency_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AFldCrowdTarget
{
    [FieldOffset(0x0000)] public AMobWalkTarget baseObj;
    [FieldOffset(0x0228)] public int mIndex_;
    [FieldOffset(0x0230)] public AMobWalkCharaBaseCore* mMobActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AFldCrowdTarget_STOP
{
    [FieldOffset(0x0000)] public AFldCrowdTarget baseObj;
    [FieldOffset(0x0238)] public int mStopRatio_;
    [FieldOffset(0x023C)] public float mStopTime_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldCrowdWalkRouteTimer
{
    [FieldOffset(0x0000)] public float mTimer_;
    [FieldOffset(0x0004)] public float mLoopTime_;
    [FieldOffset(0x0008)] public EFldCrowdRoutePtn mRoutePattern;
    [FieldOffset(0x0010)] public TArray<int> mPointList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldCrowdWalkRouteParam
{
    [FieldOffset(0x0000)] public TArray<int> mPointList;
    [FieldOffset(0x0010)] public EFldCrowdRoutePtn mRoutePattern_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldCrowdWalkFollowParam
{
    [FieldOffset(0x0000)] public TSubclassOf<AMobWalkCharaBaseCore> mMobBpClass;
    [FieldOffset(0x0008)] public FVector mRelativeLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldCrowdWalkBpParam
{
    [FieldOffset(0x0000)] public TSubclassOf<AMobWalkCharaBaseCore> mMobBpClass;
    [FieldOffset(0x0008)] public TArray<FFldCrowdWalkFollowParam> mFollowList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AFldCrowdWalkManager
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public uint mFlag_;
    [FieldOffset(0x0288)] public TArray<FFldCrowdWalkRouteTimer> mRouteTimers_;
    [FieldOffset(0x0298)] public float mMinTimer_;
    [FieldOffset(0x029C)] public float mMaxTimer_;
    [FieldOffset(0x02A0)] public TArray<FFldCrowdWalkRouteParam> mRouteParam_;
    [FieldOffset(0x02B0)] public TArray<FFldCrowdWalkBpParam> mMobBpList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFldCrowdWalkOpacityComp
{
    [FieldOffset(0x0000)] public UFldCrowdOpacityComp baseObj;
    [FieldOffset(0x00E8)] public float mSpeedLoc_;
    [FieldOffset(0x00EC)] public float mInvisibleRadiusLoc_;
    [FieldOffset(0x00F0)] public float mDisappearRadiusLoc_;
    [FieldOffset(0x00F4)] public FVector mStartPoint_;
    [FieldOffset(0x0100)] public FVector mEndPoint_;
    [FieldOffset(0x010C)] public float mOpacityLoc_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldDailyMenuScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldDbgChLoad
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0238)] public TArray<TSoftClassPtr<UAnimInstance>> AnimInsList;
    [FieldOffset(0x0248)] public UObject* InitSkel;
    [FieldOffset(0x0250)] public UObject* InitAnim;
    [FieldOffset(0x0258)] public TArray<IntPtr> loadedAssets;
    [FieldOffset(0x02A8)] public UAppCharLoader* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldEnemyHolder
{
    [FieldOffset(0x0000)] public AActor* Actor;
    [FieldOffset(0x0008)] public UFldEnemyComp* EnemyComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct AFldDbgEmMaker
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UClass* EmClass;
    [FieldOffset(0x0228)] public TArray<IntPtr> Bg;
    [FieldOffset(0x0248)] public bool IsLoadEnded;
    [FieldOffset(0x0250)] public TArray<FFldEnemyHolder> Enemy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldPartnerHolder
{
    [FieldOffset(0x0000)] public APawn* Pawn;
    [FieldOffset(0x0008)] public UFldPartnerComp* PartnerComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct AFldDbgMaker
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UClass* PlayerClass;
    [FieldOffset(0x0228)] public AActor* PlayerPoints;
    [FieldOffset(0x0230)] public int PlayerCharaId;
    [FieldOffset(0x0238)] public FFldPlayerHolder Player;
    [FieldOffset(0x0250)] public UClass* PartnerClass;
    [FieldOffset(0x0258)] public UClass* KoroPartnerClass;
    [FieldOffset(0x0260)] public TArray<int> PartnerId;
    [FieldOffset(0x0270)] public TArray<IntPtr> PartnerPoints;
    [FieldOffset(0x0280)] public TArray<IntPtr> PartnerActors;
    [FieldOffset(0x0290)] public TArray<FFldPartnerHolder> Partners;
    [FieldOffset(0x02A0)] public int CostumeID;
    [FieldOffset(0x02A4)] public EAnimPackID AnimPackID;
    [FieldOffset(0x02A5)] public bool bWeapon;
    [FieldOffset(0x02A8)] public int WeaponId;
    [FieldOffset(0x02AC)] public bool bBag;
    [FieldOffset(0x02B0)] public int BagId;
    [FieldOffset(0x02B8)] public UAppCharFootstepsDataAsset* FootstepsData;
    [FieldOffset(0x02D0)] public bool IsLoad;
    [FieldOffset(0x02D1)] public bool ReLoadCostume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AFldDbgNpcMaker
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UClass* NpcClass;
    [FieldOffset(0x0228)] public TArray<int> NpcIDs;
    [FieldOffset(0x0238)] public TArray<IntPtr> NpcPoints;
    [FieldOffset(0x0248)] public TArray<IntPtr> NpcActors;
    [FieldOffset(0x0258)] public EAnimPackID AnimPackID;
    [FieldOffset(0x0270)] public bool IsLoad;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FFldDungeonPartsSelDataAssetRecord
{
    [FieldOffset(0x0000)] public byte parts01;
    [FieldOffset(0x0001)] public byte parts02;
    [FieldOffset(0x0002)] public byte parts03;
    [FieldOffset(0x0003)] public byte parts04;
    [FieldOffset(0x0004)] public byte parts05;
    [FieldOffset(0x0005)] public byte parts06;
    [FieldOffset(0x0006)] public byte parts07;
    [FieldOffset(0x0007)] public byte parts08;
    [FieldOffset(0x0008)] public uint primBit01;
    [FieldOffset(0x000C)] public uint primBit02;
    [FieldOffset(0x0010)] public uint primBit03;
    [FieldOffset(0x0014)] public uint scndBit01;
    [FieldOffset(0x0018)] public uint scndBit02;
    [FieldOffset(0x001C)] public uint scndBit03;
    [FieldOffset(0x0020)] public byte primNum;
    [FieldOffset(0x0021)] public byte room;
    [FieldOffset(0x0022)] public byte roomMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldDungeonLayoutCombDataAssetRecord
{
    [FieldOffset(0x0000)] public ushort prio;
    [FieldOffset(0x0002)] public ushort Index;
    [FieldOffset(0x0004)] public byte Data0_0_no;
    [FieldOffset(0x0005)] public byte Data0_0_dir;
    [FieldOffset(0x0006)] public byte Data0_0_y;
    [FieldOffset(0x0007)] public byte Data0_1_no;
    [FieldOffset(0x0008)] public byte Data0_1_dir;
    [FieldOffset(0x0009)] public byte Data0_1_y;
    [FieldOffset(0x000A)] public byte Data0_2_no;
    [FieldOffset(0x000B)] public byte Data0_2_dir;
    [FieldOffset(0x000C)] public byte Data0_2_y;
    [FieldOffset(0x000D)] public byte Data1_0_no;
    [FieldOffset(0x000E)] public byte Data1_0_dir;
    [FieldOffset(0x000F)] public byte Data1_0_y;
    [FieldOffset(0x0010)] public byte Data1_1_no;
    [FieldOffset(0x0011)] public byte Data1_1_dir;
    [FieldOffset(0x0012)] public byte Data1_1_y;
    [FieldOffset(0x0013)] public byte Data1_2_no;
    [FieldOffset(0x0014)] public byte Data1_2_dir;
    [FieldOffset(0x0015)] public byte Data1_2_y;
    [FieldOffset(0x0016)] public byte Data2_0_no;
    [FieldOffset(0x0017)] public byte Data2_0_dir;
    [FieldOffset(0x0018)] public byte Data2_0_y;
    [FieldOffset(0x0019)] public byte Data2_1_no;
    [FieldOffset(0x001A)] public byte Data2_1_dir;
    [FieldOffset(0x001B)] public byte Data2_1_y;
    [FieldOffset(0x001C)] public byte Data2_2_no;
    [FieldOffset(0x001D)] public byte Data2_2_dir;
    [FieldOffset(0x001E)] public byte Data2_2_y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x74)] 
public unsafe struct FFldDungeonFloorDataAssetRecord
{
    [FieldOffset(0x0000)] public uint flags;
    [FieldOffset(0x0004)] public ushort FieldMajor;
    [FieldOffset(0x0006)] public ushort FieldMinor;
    [FieldOffset(0x0008)] public ushort major;
    [FieldOffset(0x000A)] public ushort Minor;
    [FieldOffset(0x000C)] public byte areaNo;
    [FieldOffset(0x000D)] public byte envID;
    [FieldOffset(0x000E)] public byte partMin;
    [FieldOffset(0x000F)] public byte partMax;
    [FieldOffset(0x0010)] public byte partSelTable;
    [FieldOffset(0x0011)] public byte enemyMin;
    [FieldOffset(0x0012)] public byte enemyMax;
    [FieldOffset(0x0013)] public byte strongEnemyProbability;
    [FieldOffset(0x0014)] public byte strongEnemyMax;
    [FieldOffset(0x0015)] public byte rareEnemyProbability;
    [FieldOffset(0x0016)] public byte rareEnemyMax;
    [FieldOffset(0x0017)] public byte repopNormalNormal;
    [FieldOffset(0x0018)] public byte repopNormalStrong;
    [FieldOffset(0x0019)] public byte repopNormalRare;
    [FieldOffset(0x001A)] public byte repopStrongNormal;
    [FieldOffset(0x001B)] public byte repopStrongStrong;
    [FieldOffset(0x001C)] public byte repopStrongRare;
    [FieldOffset(0x001D)] public byte repopRareNormal;
    [FieldOffset(0x001E)] public byte repopRareStrong;
    [FieldOffset(0x001F)] public byte repopRareRare;
    [FieldOffset(0x0020)] public float reaper;
    [FieldOffset(0x0024)] public ushort encountPack;
    [FieldOffset(0x0026)] public ushort strongEncountPack;
    [FieldOffset(0x0028)] public ushort pinchEncountPack;
    [FieldOffset(0x002A)] public ushort pinchStrongEncountPack;
    [FieldOffset(0x002C)] public ushort rareEncountPack;
    [FieldOffset(0x002E)] public ushort continousEncount1;
    [FieldOffset(0x0030)] public ushort continousEncount2;
    [FieldOffset(0x0032)] public byte doorGroup;
    [FieldOffset(0x0033)] public byte doorProbability;
    [FieldOffset(0x0034)] public ushort returnDevProbability;
    [FieldOffset(0x0036)] public byte tboxMin;
    [FieldOffset(0x0037)] public byte tboxMax;
    [FieldOffset(0x0038)] public byte tboxType;
    [FieldOffset(0x0039)] public byte moneyProbability;
    [FieldOffset(0x003A)] public ushort moneyMin;
    [FieldOffset(0x003C)] public ushort moneyMax;
    [FieldOffset(0x003E)] public ushort tboxPack;
    [FieldOffset(0x0040)] public ushort rareTboxPack;
    [FieldOffset(0x0042)] public ushort jewelryTboxPack;
    [FieldOffset(0x0044)] public ushort primFieldTboxPack;
    [FieldOffset(0x0046)] public ushort medal1TboxPack;
    [FieldOffset(0x0048)] public ushort medal2TboxPack;
    [FieldOffset(0x004A)] public ushort medal3TboxPack;
    [FieldOffset(0x004C)] public ushort medal4TboxPack;
    [FieldOffset(0x004E)] public ushort medal5TboxPack;
    [FieldOffset(0x0050)] public ushort medal6TboxPack;
    [FieldOffset(0x0052)] public ushort doorTboxPack;
    [FieldOffset(0x0054)] public ushort doorRareTboxPack;
    [FieldOffset(0x0056)] public ushort doorJewelryTboxPack;
    [FieldOffset(0x0058)] public ushort doorPrimFieldTboxPack;
    [FieldOffset(0x005A)] public ushort doorMedal1TboxPack;
    [FieldOffset(0x005C)] public ushort doorMedal2TboxPack;
    [FieldOffset(0x005E)] public ushort doorMedal3TboxPack;
    [FieldOffset(0x0060)] public ushort doorMedal4TboxPack;
    [FieldOffset(0x0062)] public ushort doorMedal5TboxPack;
    [FieldOffset(0x0064)] public ushort doorMedal6TboxPack;
    [FieldOffset(0x0068)] public uint missingPersonID;
    [FieldOffset(0x006C)] public uint missingBuildID;
    [FieldOffset(0x0070)] public uint scrFileNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FFldDungeonTBoxTypeDataAssetRecord
{
    [FieldOffset(0x0000)] public ushort rareMin;
    [FieldOffset(0x0002)] public ushort rareMax;
    [FieldOffset(0x0004)] public ushort jewelryMin;
    [FieldOffset(0x0006)] public ushort jewelryMax;
    [FieldOffset(0x0008)] public ushort primFieldMin;
    [FieldOffset(0x000A)] public ushort primFieldMax;
    [FieldOffset(0x000C)] public ushort medal1Min;
    [FieldOffset(0x000E)] public ushort medal1Max;
    [FieldOffset(0x0010)] public ushort medal2Min;
    [FieldOffset(0x0012)] public ushort medal2Max;
    [FieldOffset(0x0014)] public ushort medal3Min;
    [FieldOffset(0x0016)] public ushort medal3Max;
    [FieldOffset(0x0018)] public ushort medal4Min;
    [FieldOffset(0x001A)] public ushort medal4Max;
    [FieldOffset(0x001C)] public ushort medal5Min;
    [FieldOffset(0x001E)] public ushort medal5Max;
    [FieldOffset(0x0020)] public ushort medal6Min;
    [FieldOffset(0x0022)] public ushort medal6Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FFldDungeonTBoxItemDataAssetRecord
{
    [FieldOffset(0x0000)] public ushort ItemId;
    [FieldOffset(0x0002)] public ushort itemNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldDungeonTBoxPacDataAssetRecord
{
    [FieldOffset(0x0000)] public uint pacID;
    [FieldOffset(0x0004)] public ushort tboxID;
    [FieldOffset(0x0006)] public ushort Probability;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldDungeonEncountPacDataAssetRecord
{
    [FieldOffset(0x0000)] public ushort encNo1;
    [FieldOffset(0x0002)] public ushort probability1;
    [FieldOffset(0x0004)] public ushort encNo2;
    [FieldOffset(0x0006)] public ushort probability2;
    [FieldOffset(0x0008)] public ushort encNo3;
    [FieldOffset(0x000A)] public ushort probability3;
    [FieldOffset(0x000C)] public ushort encNo4;
    [FieldOffset(0x000E)] public ushort probability4;
    [FieldOffset(0x0010)] public ushort encNo5;
    [FieldOffset(0x0012)] public ushort probability5;
    [FieldOffset(0x0014)] public ushort encNo6;
    [FieldOffset(0x0016)] public ushort probability6;
    [FieldOffset(0x0018)] public ushort encNo7;
    [FieldOffset(0x001A)] public ushort probability7;
    [FieldOffset(0x001C)] public ushort encNo8;
    [FieldOffset(0x001E)] public ushort probability8;
    [FieldOffset(0x0020)] public byte order1;
    [FieldOffset(0x0021)] public byte order2;
    [FieldOffset(0x0022)] public byte order3;
    [FieldOffset(0x0023)] public byte order4;
    [FieldOffset(0x0024)] public byte order5;
    [FieldOffset(0x0025)] public byte order6;
    [FieldOffset(0x0026)] public byte order7;
    [FieldOffset(0x0027)] public byte order8;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UFldDungeonTable
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FFldDungeonPartsSelDataAssetRecord> PartsSelData;
    [FieldOffset(0x0040)] public TArray<FFldDungeonLayoutCombDataAssetRecord> LayoutCombData;
    [FieldOffset(0x0050)] public TArray<FFldDungeonFloorDataAssetRecord> FloorData;
    [FieldOffset(0x0060)] public TArray<FFldDungeonTBoxTypeDataAssetRecord> TBoxTypeData;
    [FieldOffset(0x0070)] public TArray<FFldDungeonTBoxItemDataAssetRecord> TBoxItemData;
    [FieldOffset(0x0080)] public TArray<FFldDungeonTBoxPacDataAssetRecord> TBoxPacData;
    [FieldOffset(0x0090)] public TArray<FFldDungeonEncountPacDataAssetRecord> EncountPacData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UFldDoorPointComp
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldDoorAnimationData
{
    [FieldOffset(0x0000)] public UAnimationAsset* mActionAsset;
    [FieldOffset(0x0008)] public UAnimationAsset* mWaitAsset;
    [FieldOffset(0x0010)] public int mCharaMotionID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x390)] 
public unsafe struct AFldDoorObjCore
{
    [FieldOffset(0x0000)] public AFldAnimObj baseObj;
    [FieldOffset(0x0310)] public float mWalkSpeed_;
    [FieldOffset(0x0314)] public float mDoorCloseRange_;
    [FieldOffset(0x0318)] public UAnimationAsset* mWaitAsset_CLOSE_;
    [FieldOffset(0x0320)] public FFldDoorAnimationData mAnime_FRONT_;
    [FieldOffset(0x0338)] public FFldDoorAnimationData mAnime_BACK_;
    [FieldOffset(0x0350)] public USceneComponent* Root;
    [FieldOffset(0x0358)] public USkeletalMeshComponent* SkeletalMesh;
    [FieldOffset(0x0360)] public UFldDoorPointComp* FrontPoint;
    [FieldOffset(0x0368)] public UFldDoorPointComp* BackPoint;
    [FieldOffset(0x0370)] public uint mFlag_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UFldDungeonComponentBase
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x0118)] public TArray<IntPtr> m_ScrHandleList01;
    [FieldOffset(0x0128)] public TArray<IntPtr> m_ScrHandleList02;
    [FieldOffset(0x013C)] public FName m_Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UFldDungeonAccidentController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UDungeonAssetData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0050)] public UObject* m_pObject;
    [FieldOffset(0x0078)] public UDungeonAssetData* m_pSyncData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AFldDungeonAutoGenerateBaseActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AFldDungeonAutoGenerateActor
{
    [FieldOffset(0x0000)] public AFldDungeonAutoGenerateBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct AFldDungeonBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public USceneComponent* Root;
    [FieldOffset(0x02B8)] public AFldDungeonSoundActor* m_pEnvSEActor;
    [FieldOffset(0x02C8)] public AFldDungeonAutoGenerateActor* m_pFloorAutoGenerator;
    [FieldOffset(0x02D0)] public AFldEnemyManager* m_pEnemyManager;
    [FieldOffset(0x02D8)] public AFldPartnerManager* m_pPartnerManager;
    [FieldOffset(0x02E0)] public TArray<IntPtr> m_ControlComponent;
    [FieldOffset(0x0340)] public AFldDungeonParamActor* m_pDungeonParam;
}

[StructLayout(LayoutKind.Explicit, Size = 0x300)] 
public unsafe struct AFldDungeonBattleEncount
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0290)] public ACharacter* m_pCharacter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldDungeonBattleResult
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0290)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0298)] public UBfAsset* m_pBfAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AFldDungeonRollBack
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UAddContent* m_pAddContentCheck;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AFldDungeonBattleRetry
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UFldDungeonBrokenObjController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0150)] public TArray<IntPtr> m_BrokenActor;
    [FieldOffset(0x0160)] public TArray<IntPtr> m_LayoutArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UFldDungeonClockController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public AFldDungeonObjectActor* m_ClockActor;
    [FieldOffset(0x0150)] public AFldDungeonLayoutActor* m_pLayoutClock;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AFldDungeonScriptActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x510)] 
public unsafe struct AFldDungeonGameBase
{
    [FieldOffset(0x0000)] public AFldDungeonBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x540)] 
public unsafe struct AFldDungeonGameInit
{
    [FieldOffset(0x0000)] public AFldDungeonGameBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x540)] 
public unsafe struct AFldDungeonGame
{
    [FieldOffset(0x0000)] public AFldDungeonGameInit baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x540)] 
public unsafe struct AFldDungeonControlActor
{
    [FieldOffset(0x0000)] public AFldDungeonGame baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UFldDungeonDebugController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F0)] 
public unsafe struct UFldDungeonEffectController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_EffectActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AFldDungeonEffectActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonEffectType Type;
    [FieldOffset(0x0280)] public FSoftObjectPath NiagaraPath;
    [FieldOffset(0x0298)] public float fadeInTime;
    [FieldOffset(0x029C)] public float fadeOutTime;
    [FieldOffset(0x02C0)] public UNiagaraComponent* m_pNiagara;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UFldDungeonEffectTartarosSearch
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public float LifeSpan;
    [FieldOffset(0x00CC)] public float Intensity;
    [FieldOffset(0x00D0)] public float MaxBrightness;
    [FieldOffset(0x00D4)] public float Radius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AFldDungeonEffectCameraAttachActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UNiagaraCameraAttachComponent* m_pEffec;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct UFldDungeonEncountController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0218)] public TArray<FFldEnemyHolder> m_EnemyCompArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UFldDungeonEnemyController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_pLayoutDirectArray;
    [FieldOffset(0x0158)] public TArray<FFldEnemyHolder> m_EnemyList;
    [FieldOffset(0x0168)] public TMap<int, FFldEnemyHolder> m_DirectEnemy;
    [FieldOffset(0x01B8)] public TArray<FFldEnemyHolder> m_MonadEnemy;
    [FieldOffset(0x01C8)] public TArray<FFldEnemyHolder> m_FDoorEnemy;
    [FieldOffset(0x01D8)] public TArray<FFldEnemyHolder> m_Reaper;
    [FieldOffset(0x01E8)] public TArray<IntPtr> m_FixedLayoutArray;
    [FieldOffset(0x01F8)] public TArray<IntPtr> m_FixedLayoutPathArray;
    [FieldOffset(0x0208)] public TArray<IntPtr> m_DesignLayoutArray;
    [FieldOffset(0x0218)] public TArray<IntPtr> m_DesignLayoutPathArray;
    [FieldOffset(0x0228)] public TArray<IntPtr> m_MonadLayoutArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UFldDungeonEnvController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_EnvActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldDungeonEnvActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonEnvType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UFldDungeonEventController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldDungeonEventTransActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonEventTransOriginType TransOriginType;
    [FieldOffset(0x027C)] public int WithinTypeID;
    [FieldOffset(0x0280)] public TArray<IntPtr> m_LayoutPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldDungeonEventRefActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public int RefID;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FDungeonFloorFlagsIDData
{
    [FieldOffset(0x0000)] public FName Tag;
    [FieldOffset(0x0008)] public uint ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonAssignFlagsData
{
    [FieldOffset(0x0000)] public FName Tag;
    [FieldOffset(0x0008)] public FName FlagName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDungeonFloorFlagsData
{
    [FieldOffset(0x0000)] public uint FloorNo;
    [FieldOffset(0x0008)] public TArray<FDungeonAssignFlagsData> AssignFlagList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDungeonFloorFlagsDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FDungeonFloorFlagsData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UFldDungeonFloorFlagsDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDungeonFloorFlagsIDData> IDList;
    [FieldOffset(0x0040)] public FDungeonFloorFlagsDataTableRow FloorFlagsTbl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UFldDungeonFloorFlags
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UFldDungeonForbiddenDoorController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0158)] public AFldDungeonPartActor* m_pForbiddenDoor;
    [FieldOffset(0x0160)] public TArray<IntPtr> m_LayoutActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldDungeonInfoActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonInfoType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AFldDungeonObjectInfoActor
{
    [FieldOffset(0x0000)] public AFldDungeonInfoActor baseObj;
    [FieldOffset(0x0280)] public EDungeonObjectInfoType ObjectType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UFldDungeonInfoSupportController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldDungeonLayoutActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public ELayoutType LayoutType;
    [FieldOffset(0x0279)] public ELayoutUsageType UsageType;
    [FieldOffset(0x027A)] public ELayoutGroup GroupNo;
    [FieldOffset(0x027B)] public ELayoutDirType Dir;
    [FieldOffset(0x0280)] public TArray<int> SpawnSelNo;
    [FieldOffset(0x0290)] public bool Wall;
    [FieldOffset(0x0291)] public bool EventSpace;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldDungeonLayoutStartActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutActor baseObj;
    [FieldOffset(0x0298)] public ELayoutStartType StartType;
    [FieldOffset(0x029C)] public int FreeID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldDungeonLayoutEnemyActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutActor baseObj;
    [FieldOffset(0x0298)] public EDungeonEnemyType EnemyType;
    [FieldOffset(0x029C)] public int EncountID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldDungeonLayoutDirectActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutActor baseObj;
    [FieldOffset(0x0298)] public int LayoutId;
    [FieldOffset(0x029C)] public int Eigenvalue;
    [FieldOffset(0x02A0)] public bool GateKeeper;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldDungeonLayoutDirectEnemyActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutDirectActor baseObj;
    [FieldOffset(0x02A8)] public uint ModelID;
    [FieldOffset(0x02AC)] public uint SymbolID;
    [FieldOffset(0x02B0)] public uint DefeatFlagID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AFldDungeonLayoutDirectTBoxActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutDirectActor baseObj;
    [FieldOffset(0x02A8)] public EDungeonTBoxType tboxType;
    [FieldOffset(0x02AC)] public uint money;
    [FieldOffset(0x02B0)] public bool Encount;
    [FieldOffset(0x02B1)] public bool CheckFlag;
    [FieldOffset(0x02B4)] public FName FlagName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldDungeonLayoutBrokenActor
{
    [FieldOffset(0x0000)] public AFldDungeonLayoutActor baseObj;
    [FieldOffset(0x0298)] public bool Empty;
    [FieldOffset(0x029C)] public int Probability;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct AFldDungeonLoader
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldDungeonMenuScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UFldDungeonMissingController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public ANpcBaseCore* m_pMissingPerson;
    [FieldOffset(0x0150)] public AFldDungeonSoundBaseActor* m_pMisNpcSE;
    [FieldOffset(0x0160)] public AFldDungeonPartActor* m_pPartRoom;
}

[StructLayout(LayoutKind.Explicit, Size = 0x348)] 
public unsafe struct AFldDungeonObjectActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonObjType ObjType;
    [FieldOffset(0x0280)] public FSoftObjectPath BaseObject;
    [FieldOffset(0x0298)] public int InitAnimNo;
    [FieldOffset(0x029C)] public int HitAnimNo;
    [FieldOffset(0x02A0)] public int EndAnimNo;
    [FieldOffset(0x02B8)] public AFldDungeonObjectActor* m_pBaseObject;
    [FieldOffset(0x02C0)] public TArray<IntPtr> m_pHitActorList;
    [FieldOffset(0x02E0)] public TArray<IntPtr> m_AnimObjList;
    [FieldOffset(0x02F8)] public UBoxComponent* m_pBox;
    [FieldOffset(0x0308)] public TArray<IntPtr> m_pLightComps;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDungeonTrophyValue
{
    [FieldOffset(0x0000)] public FName CounterName;
    [FieldOffset(0x0008)] public FName Name;
    [FieldOffset(0x0010)] public int CountMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonResetData
{
    [FieldOffset(0x0000)] public EDungeonResetDataType DataType;
    [FieldOffset(0x0004)] public FName DataName;
    [FieldOffset(0x000C)] public int DataState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonResetList
{
    [FieldOffset(0x0000)] public TArray<FDungeonResetData> ResetData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDungeonPartConnectInfoData
{
    [FieldOffset(0x0000)] public bool ConnectUp;
    [FieldOffset(0x0001)] public bool ConnectLeft;
    [FieldOffset(0x0002)] public bool ConnectDown;
    [FieldOffset(0x0003)] public bool ConnectRight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDungeonPartOpenInfoData
{
    [FieldOffset(0x0000)] public float ConnectPartOpenDistance;
    [FieldOffset(0x0004)] public int SeparatelyNextFloorOpenNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDungeonLightAttenuationData
{
    [FieldOffset(0x0000)] public float StartDist;
    [FieldOffset(0x0004)] public float EndDist;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonUROParamData
{
    [FieldOffset(0x0000)] public TArray<float> ThresholdSizeList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FDungeonBrokenObjData
{
    [FieldOffset(0x0000)] public int FragmentProbability;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDungeonFDoorAppearanceData
{
    [FieldOffset(0x0000)] public TArray<int> MagValue_SAreaDiff;
    [FieldOffset(0x0010)] public int MagDecValue_Floor;
    [FieldOffset(0x0014)] public int MagIncAddValue;
    [FieldOffset(0x0018)] public FVector PartPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDungeonEnemyModelIDData
{
    [FieldOffset(0x0000)] public int majorId;
    [FieldOffset(0x0004)] public int minorId;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FDungeonEnemyModelParamData
{
    [FieldOffset(0x0000)] public float ScaleX;
    [FieldOffset(0x0004)] public float ScaleY;
    [FieldOffset(0x0008)] public float ScaleZ;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDungeonMDoorEncountIDData
{
    [FieldOffset(0x0000)] public TArray<int> Minor00;
    [FieldOffset(0x0010)] public TArray<int> Minor01;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDungeonPathData
{
    [FieldOffset(0x0000)] public int majorId;
    [FieldOffset(0x0004)] public int minorId;
    [FieldOffset(0x0008)] public FSoftObjectPath Path;
    [FieldOffset(0x0020)] public FString StrPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonPathList
{
    [FieldOffset(0x0000)] public TArray<FDungeonPathData> PathData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonPathGroupList
{
    [FieldOffset(0x0000)] public TArray<FDungeonPathList> GroupList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3D8)] 
public unsafe struct FDungeonParamDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TMap<EDungeonTrophyType, FDungeonTrophyValue> TrophyValue;
    [FieldOffset(0x0058)] public TMap<EDungeonResetTiming, FDungeonResetList> ResetTimingData;
    [FieldOffset(0x00A8)] public TMap<EPartType, FDungeonPartConnectInfoData> PartConnectInfo;
    [FieldOffset(0x00F8)] public FDungeonPartOpenInfoData PartOpenInfo;
    [FieldOffset(0x0100)] public TMap<int, FDungeonLightAttenuationData> PartLightAttenuationData;
    [FieldOffset(0x0150)] public FDungeonLightAttenuationData ObjectLightAttenuationData;
    [FieldOffset(0x0158)] public FDungeonUROParamData PartUROParamData;
    [FieldOffset(0x0168)] public FDungeonUROParamData ObjectUROParamData;
    [FieldOffset(0x0178)] public FDungeonBrokenObjData BrokenObjData;
    [FieldOffset(0x0180)] public FDungeonFDoorAppearanceData FDoorAppearanceData;
    [FieldOffset(0x01A8)] public TMap<int, FDungeonEnemyModelIDData> EnemyModelID;
    [FieldOffset(0x01F8)] public TMap<int, FDungeonEnemyModelParamData> EnemyModelParamData;
    [FieldOffset(0x0248)] public TMap<int, int> MDoorBuildID;
    [FieldOffset(0x0298)] public TMap<int, FDungeonMDoorEncountIDData> MDoorEncountID;
    [FieldOffset(0x02E8)] public TMap<int, EDungeonMisNpcType> MisNpcType;
    [FieldOffset(0x0338)] public TMap<EDungeonPathType, FDungeonPathGroupList> DataPath;
    [FieldOffset(0x0388)] public TMap<EDungeonLevelPathType, FDungeonPathList> LevelPath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x408)] 
public unsafe struct UFldDungeonParamDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FDungeonParamDataTableRow ParamData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct AFldDungeonParamActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public FSoftObjectPath DataAsset;
    [FieldOffset(0x0290)] public FSoftObjectPath DungeonTable;
    [FieldOffset(0x02A8)] public FSoftObjectPath PartVariationData;
    [FieldOffset(0x02C0)] public FSoftObjectPath FloorFlagsData;
    [FieldOffset(0x02E0)] public UFldDungeonPartVariation* m_pPartVariation;
    [FieldOffset(0x02E8)] public UFldDungeonFloorFlags* m_pFloorFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UFldDungeonPartController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_PartActor;
    [FieldOffset(0x0158)] public TArray<IntPtr> m_WallActor;
    [FieldOffset(0x0168)] public TArray<IntPtr> m_PartActorRef;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C8)] 
public unsafe struct AFldDungeonPartActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EPartType PartType;
    [FieldOffset(0x027C)] public int PartVariation;
    [FieldOffset(0x0280)] public EPartDirType PartDirType;
    [FieldOffset(0x0281)] public bool ForbiddenDoor;
    [FieldOffset(0x0282)] public bool MonadPassage;
    [FieldOffset(0x0283)] public bool ExclusivelyForEvent;
    [FieldOffset(0x02D8)] public TArray<IntPtr> m_LayoutActor;
    [FieldOffset(0x02E8)] public TArray<IntPtr> m_pLayoutStart;
    [FieldOffset(0x02F8)] public TArray<IntPtr> m_pLayoutEnemy;
    [FieldOffset(0x0308)] public TArray<IntPtr> m_LayoutEnemyPath;
    [FieldOffset(0x0318)] public TArray<IntPtr> m_LayoutTBox;
    [FieldOffset(0x0328)] public AFldDungeonLayoutActor* m_pLayoutRetDev;
    [FieldOffset(0x0338)] public AFldDungeonLayoutActor* m_pLayoutNPC;
    [FieldOffset(0x0340)] public AFldDungeonLayoutActor* m_pLayoutReaper;
    [FieldOffset(0x0348)] public AFldDungeonLayoutActor* m_pLayoutClock;
    [FieldOffset(0x0350)] public AFldDungeonLayoutActor* m_pLayoutSecretGate;
    [FieldOffset(0x0370)] public TArray<IntPtr> m_ObjectInfoActor;
    [FieldOffset(0x0388)] public TArray<IntPtr> m_pSKMeshComps;
    [FieldOffset(0x0398)] public TArray<IntPtr> m_pLightComps;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3D0)] 
public unsafe struct AFldDungeonFDoorPartActor
{
    [FieldOffset(0x0000)] public AFldDungeonPartActor baseObj;
    [FieldOffset(0x03C8)] public int FDoorGroupNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UFldDungeonPartnerController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<FFldPartnerHolder> m_Partners;
    [FieldOffset(0x0158)] public TArray<IntPtr> m_StartList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDungeonPartVariationData
{
    [FieldOffset(0x0000)] public EPartType PartType;
    [FieldOffset(0x0008)] public TArray<byte> VariationNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDungeonPartVariationDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FDungeonPartVariationData> VarNoList;
    [FieldOffset(0x0018)] public TArray<FDungeonPartVariationData> FixedVarNoList;
    [FieldOffset(0x0028)] public TArray<FDungeonPartVariationData> MonadVarNoList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDungeonPartFDoorTypeDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FDungeonPartVariationData> TypeList;
    [FieldOffset(0x0018)] public int VarNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDungeonPartMisRoomTypeDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FDungeonPartVariationData> TypeList;
    [FieldOffset(0x0018)] public int VarNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UFldDungeonPartVariationDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FDungeonPartVariationDataTableRow Area1;
    [FieldOffset(0x0068)] public FDungeonPartVariationDataTableRow Area2;
    [FieldOffset(0x00A0)] public FDungeonPartVariationDataTableRow Area3;
    [FieldOffset(0x00D8)] public FDungeonPartVariationDataTableRow Area4;
    [FieldOffset(0x0110)] public FDungeonPartVariationDataTableRow Area5;
    [FieldOffset(0x0148)] public FDungeonPartVariationDataTableRow Area6;
    [FieldOffset(0x0180)] public FDungeonPartFDoorTypeDataTableRow FDoorTypeTbl;
    [FieldOffset(0x01A0)] public FDungeonPartMisRoomTypeDataTableRow MisRoomTypeTbl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldDungeonPartVariation
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UFldDungeonReaperController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0160)] public AFldDungeonEffectCameraAttachActor* m_pEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UFldDungeonRecoverController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0158)] public UNiagaraCameraAttachComponent* m_pEffectCameraAttach;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct AFldDungeonResourceServer
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UFldDungeonSecretGateController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public AFldDungeonObjectActor* m_SecretGateActor;
    [FieldOffset(0x0150)] public AFldDungeonLayoutActor* m_pLayoutSecretGate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UFldDungeonSeparatelyController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UFldDungeonSetupController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldDungeonSoundBaseActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonSuondType Type;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldDungeonSoundActor
{
    [FieldOffset(0x0000)] public AFldDungeonSoundBaseActor baseObj;
    [FieldOffset(0x0280)] public TArray<int> CueIDList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UFldDungeonStartParam
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AFldDungeonStartActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x178)] 
public unsafe struct UFldDungeonSupportSkillController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_pEffectList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UFldDungeonTalkController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct UFldDungeonTBoxController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_TBoxActor;
    [FieldOffset(0x0158)] public TArray<IntPtr> m_TBoxSE;
    [FieldOffset(0x0170)] public AFldDungeonObjectActor* m_HitTBox;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UFldDungeonTransferController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public AFldDungeonObjectActor* m_ReturnActor;
    [FieldOffset(0x0150)] public AFldDungeonObjectActor* m_pFixedReturn;
    [FieldOffset(0x0158)] public AFldDungeonObjectActor* m_pFixedTransfer;
    [FieldOffset(0x0160)] public AFldDungeonPartActor* m_pPartActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x160)] 
public unsafe struct UFldDungeonUIController
{
    [FieldOffset(0x0000)] public UFldDungeonComponentBase baseObj;
    [FieldOffset(0x0148)] public TArray<IntPtr> m_UIActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonUIBaseData
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public int DrawOrder;
    [FieldOffset(0x000C)] public EDungeonUIBlendStateType BlendStateType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FDungeonUIMaskInfo
{
    [FieldOffset(0x0000)] public bool MaskOnly;
    [FieldOffset(0x0004)] public FName MaskTargetName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDungeonUISprData
{
    [FieldOffset(0x0000)] public FDungeonUIBaseData BaseData;
    [FieldOffset(0x0010)] public FDungeonUIMaskInfo MaskInfo;
    [FieldOffset(0x001C)] public EDungeonUISpriteType SprType;
    [FieldOffset(0x0020)] public int grpNo;
    [FieldOffset(0x0024)] public int SprNo;
    [FieldOffset(0x0028)] public EDungeonUISpriteOrigin Origin;
    [FieldOffset(0x002C)] public FVector Pos;
    [FieldOffset(0x0038)] public byte RGBA;
    [FieldOffset(0x003C)] public float ScaleMin;
    [FieldOffset(0x0044)] public float ScaleMax;
    [FieldOffset(0x004C)] public bool MsgWSync;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDungeonUIVertexData
{
    [FieldOffset(0x0000)] public FVector Ver;
    [FieldOffset(0x000C)] public bool MsgWSync;
    [FieldOffset(0x0010)] public float MsgWSyncOffsSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDungeonUIPrimData
{
    [FieldOffset(0x0000)] public FDungeonUIBaseData BaseData;
    [FieldOffset(0x0010)] public FDungeonUIMaskInfo MaskInfo;
    [FieldOffset(0x0020)] public TArray<FDungeonUIVertexData> vertex;
    [FieldOffset(0x0030)] public float Z;
    [FieldOffset(0x0034)] public byte RGBA;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDungeonUIMsgData
{
    [FieldOffset(0x0000)] public FDungeonUIBaseData BaseData;
    [FieldOffset(0x0010)] public FVector Pos;
    [FieldOffset(0x001C)] public EDungeonUIFontStyle fontStyle;
    [FieldOffset(0x001D)] public byte FontRGBA;
    [FieldOffset(0x0024)] public float LineBreakWidth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FDungeonUIItemNameData
{
    [FieldOffset(0x0000)] public FDungeonUIBaseData BaseData;
    [FieldOffset(0x0010)] public FVector2D IconPivot;
    [FieldOffset(0x0018)] public FVector IconPos;
    [FieldOffset(0x0024)] public float IconScale;
    [FieldOffset(0x0028)] public FVector NamePos;
    [FieldOffset(0x0034)] public EDungeonUIFontStyle fontStyle;
    [FieldOffset(0x0035)] public byte FontRGBA;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FDungeonUIMoneyData
{
    [FieldOffset(0x0000)] public FDungeonUIBaseData BaseData;
    [FieldOffset(0x0010)] public FVector Pos;
    [FieldOffset(0x001C)] public EDungeonUIFontStyle fontStyle;
    [FieldOffset(0x001D)] public byte FontRGBA;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDungeonUIPosAnimData
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public FVector OffsPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDungeonUIAlphaAnimData
{
    [FieldOffset(0x0000)] public float Time;
    [FieldOffset(0x0004)] public float Alpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDungeonUIAnimData
{
    [FieldOffset(0x0000)] public TArray<FDungeonUIPosAnimData> PosAnim;
    [FieldOffset(0x0010)] public TArray<FDungeonUIAlphaAnimData> AlphaAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FDungeonUIDrawData
{
    [FieldOffset(0x0000)] public float LifeSpan;
    [FieldOffset(0x0004)] public FVector BasePos;
    [FieldOffset(0x0010)] public TArray<FDungeonUISprData> Sprite;
    [FieldOffset(0x0020)] public TArray<FDungeonUIPrimData> Primitive;
    [FieldOffset(0x0030)] public TArray<FDungeonUIMsgData> Massage;
    [FieldOffset(0x0040)] public TArray<FDungeonUIItemNameData> ItemName;
    [FieldOffset(0x0050)] public TArray<FDungeonUIMoneyData> money;
    [FieldOffset(0x0060)] public FDungeonUIAnimData FadeIn;
    [FieldOffset(0x0080)] public FDungeonUIAnimData FadeOut;
    [FieldOffset(0x00A0)] public int MsgSyncMinWordCount;
    [FieldOffset(0x00A4)] public int MsgSuncMaxWordCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FDungeonUIDrawDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TMap<int, FDungeonUIDrawData> DrawData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x378)] 
public unsafe struct AFldDungeonUIActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public EDungeonUIType Type;
    [FieldOffset(0x0280)] public FDungeonUIDrawDataTable DrawTbl;
    [FieldOffset(0x0360)] public UDataTable* LayoutData;
    [FieldOffset(0x0368)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0370)] public UAssetLoader* m_pLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UFldEnemyComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public AFldEnemyController* ControllerRef;
    [FieldOffset(0x00D0)] public USkeletalMeshComponent* MeshComp;
    [FieldOffset(0x00D8)] public UCharacterMovementComponent* MovementComp;
    [FieldOffset(0x00E0)] public UCapsuleComponent* CapsuleComp;
    [FieldOffset(0x00E8)] public UChildActorComponent* SearchAreaComp;
    [FieldOffset(0x00F0)] public AFldCharArea* SearchArea;
    [FieldOffset(0x00F8)] public UChildActorComponent* AttackAreaComp;
    [FieldOffset(0x0100)] public AFldCharArea* AttackArea;
    [FieldOffset(0x0108)] public UAnimMontage* AnimMontage;
    [FieldOffset(0x0110)] public UAnimSequenceBase* CurrentAnimSequence;
    [FieldOffset(0x0118)] public EFldEnemyType EnemyType;
    [FieldOffset(0x011C)] public int ID;
    [FieldOffset(0x0120)] public int EncountID;
    [FieldOffset(0x0124)] public int Group;
    [FieldOffset(0x0128)] public int AbnormalStateId;
    [FieldOffset(0x012C)] public bool bForceUpset;
    [FieldOffset(0x012D)] public bool bGroupEnable;
    [FieldOffset(0x012E)] public bool bVisibleEnable;
    [FieldOffset(0x012F)] public bool bCollisionEnable;
    [FieldOffset(0x0130)] public int FlagID;
    [FieldOffset(0x0134)] public bool RespawnProhibited;
    [FieldOffset(0x0135)] public bool TypeChanged;
    [FieldOffset(0x0136)] public bool bAllowStandbyToFinish;
    [FieldOffset(0x0138)] public FAppCharTransparency Transparency;
    [FieldOffset(0x0150)] public FTransform BeginTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct AFldEnemyController
{
    [FieldOffset(0x0000)] public AAIController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldEnemyEffectParam
{
    [FieldOffset(0x0000)] public UNiagaraSystem* Asset;
    [FieldOffset(0x0008)] public FName SocketName;
    [FieldOffset(0x0010)] public float Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UFldEnemyForbiddenDoorComp
{
    [FieldOffset(0x0000)] public UFldEnemyComp baseObj;
    [FieldOffset(0x0188)] public UChildActorComponent* DisplayChildActorComp;
    [FieldOffset(0x0190)] public UNiagaraComponent* AuraNiagaraComp;
    [FieldOffset(0x0198)] public EFldEnemyState State;
    [FieldOffset(0x019C)] public EFldEnemyState NextState;
    [FieldOffset(0x01A0)] public bool bIsLoading;
    [FieldOffset(0x01A1)] public bool bIsSetupDisplay;
    [FieldOffset(0x01A8)] public TSoftClassPtr<UObject> DisplayClassPtr;
    [FieldOffset(0x02C8)] public FFldEnemyEffectParam AuraEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldEnemyManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TArray<FFldEnemyHolder> Enemies;
    [FieldOffset(0x0288)] public bool bBattle;
    [FieldOffset(0x0290)] public TArray<int> DisableleList;
    [FieldOffset(0x02A0)] public UNiagaraComponent* VanishNiagaraComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FFldEnemySkillReactionParam
{
    [FieldOffset(0x0000)] public bool bJamming;
    [FieldOffset(0x0001)] public bool bPressure;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct UFldEnemyNormalComp
{
    [FieldOffset(0x0000)] public UFldEnemyComp baseObj;
    [FieldOffset(0x0188)] public UNiagaraComponent* MarkNiagaraComp;
    [FieldOffset(0x0190)] public UNiagaraComponent* DirectionNiagaraComp;
    [FieldOffset(0x0198)] public UNiagaraComponent* AuraNiagaraComp;
    [FieldOffset(0x01A0)] public UNiagaraComponent* ConditionNiagaraComp;
    [FieldOffset(0x01A8)] public FFldEnemySkillReactionParam SkillReaction;
    [FieldOffset(0x01AC)] public EFldEnemyState State;
    [FieldOffset(0x01B0)] public EFldEnemyState NextState;
    [FieldOffset(0x01B8)] public FFldEnemyEffectParam CurrentMarkEffectParam;
    [FieldOffset(0x01D0)] public FFldEnemyEffectParam CurrentConditionEffectParam;
    [FieldOffset(0x01E8)] public TArray<FVector> LoiterPoints;
    [FieldOffset(0x01F8)] public FFldPlayerHolder TrackingTarget;
    [FieldOffset(0x0210)] public bool bIsDead;
    [FieldOffset(0x0211)] public bool bVanish;
    [FieldOffset(0x0212)] public bool bModalMenu;
    [FieldOffset(0x0213)] public bool bIdleMenu;
    [FieldOffset(0x0218)] public UFldEnemyDataAsset* EnemyData;
    [FieldOffset(0x0220)] public UFldEnemyFootprintDA* FootprintDA;
    [FieldOffset(0x0228)] public UAnimSequenceBase* IdelAnim;
    [FieldOffset(0x0230)] public UAnimSequenceBase* DamageAnim;
    [FieldOffset(0x0238)] public UAnimSequenceBase* RunAnim;
    [FieldOffset(0x0240)] public UAnimSequenceBase* WalkAnim;
    [FieldOffset(0x0248)] public UAnimSequenceBase* AttackAnim;
    [FieldOffset(0x0250)] public UAnimSequenceBase* FindAnim;
    [FieldOffset(0x0258)] public UAnimSequenceBase* SearchAnim;
    [FieldOffset(0x0260)] public UAnimSequenceBase* VanishAnim;
    [FieldOffset(0x0268)] public UAnimSequenceBase* ArrivalAnim;
    [FieldOffset(0x0270)] public UAnimSequenceBase* WinceAnim;
    [FieldOffset(0x0278)] public UAnimSequenceBase* WinceIdleAnim;
    [FieldOffset(0x0280)] public FFldEnemyEffectParam AuraEffect;
    [FieldOffset(0x0298)] public FFldEnemyEffectParam ExclamationEffect;
    [FieldOffset(0x02B0)] public FFldEnemyEffectParam QuestionEffect;
    [FieldOffset(0x02C8)] public FFldEnemyEffectParam SweatEffect;
    [FieldOffset(0x02E0)] public FFldEnemyEffectParam VanishEffect;
    [FieldOffset(0x02F8)] public FFldEnemyEffectParam ArrivalEffect;
    [FieldOffset(0x0310)] public FFldEnemyEffectParam AngerEffect;
    [FieldOffset(0x0328)] public FFldEnemyEffectParam ConfusionEffect;
    [FieldOffset(0x0340)] public FFldEnemyEffectParam FearEffect;
    [FieldOffset(0x0358)] public FFldEnemyEffectParam UpsetEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldEnemySearchParam
{
    [FieldOffset(0x0000)] public float Range;
    [FieldOffset(0x0004)] public float Angle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldEnemyLoiterParam
{
    [FieldOffset(0x0000)] public float Length;
    [FieldOffset(0x0004)] public float Speed;
    [FieldOffset(0x0008)] public float CurveSpeed;
    [FieldOffset(0x000C)] public float CurveScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FFldEnemyNormalParam
{
    [FieldOffset(0x0000)] public float MovementRange;
    [FieldOffset(0x0004)] public FFldEnemySearchParam NormalSearch;
    [FieldOffset(0x000C)] public FFldEnemySearchParam PlayerNearSearch;
    [FieldOffset(0x0014)] public FFldEnemySearchParam PlayerDashSearch;
    [FieldOffset(0x001C)] public FFldEnemySearchParam PlayerFindingSearch;
    [FieldOffset(0x0028)] public TArray<FFldEnemyLoiterParam> LoiterSpeed;
    [FieldOffset(0x0038)] public float LoiterWaitTime;
    [FieldOffset(0x003C)] public float TrackingSpeed;
    [FieldOffset(0x0040)] public float TrackingTime;
    [FieldOffset(0x0044)] public float AttackBlendOut;
    [FieldOffset(0x0048)] public float DiscoverWaitTime;
    [FieldOffset(0x004C)] public float LostWiatTime;
    [FieldOffset(0x0050)] public float EscapeSpeed;
    [FieldOffset(0x0054)] public float EscapeTime;
    [FieldOffset(0x0058)] public float EscapeWaitTime;
    [FieldOffset(0x005C)] public float EscapeResetDistance;
    [FieldOffset(0x0060)] public float EscapeVanishDistance;
    [FieldOffset(0x0064)] public float EscapeForceVanishDistance;
    [FieldOffset(0x0068)] public float RespawnInterval;
    [FieldOffset(0x006C)] public float RespawnDistance;
    [FieldOffset(0x0070)] public float VanishSpawnDistance;
    [FieldOffset(0x0074)] public FVector HitBoxOffset;
    [FieldOffset(0x0080)] public FVector HitBoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FFldEnemyConditionAngerParam
{
    [FieldOffset(0x0000)] public float MovementRange;
    [FieldOffset(0x0004)] public FFldEnemySearchParam NormalSearch;
    [FieldOffset(0x000C)] public FFldEnemySearchParam PlayerNearSearch;
    [FieldOffset(0x0014)] public FFldEnemySearchParam PlayerDashSearch;
    [FieldOffset(0x001C)] public FFldEnemySearchParam PlayerFindingSearch;
    [FieldOffset(0x0028)] public TArray<FFldEnemyLoiterParam> LoiterSpeed;
    [FieldOffset(0x0038)] public float LoiterWaitTime;
    [FieldOffset(0x003C)] public float DiscoverTime;
    [FieldOffset(0x0040)] public float TrackingTime;
    [FieldOffset(0x0044)] public float TrackingRotSpeed;
    [FieldOffset(0x0048)] public float AttackSpeed;
    [FieldOffset(0x004C)] public float AttackRotSpeed;
    [FieldOffset(0x0050)] public float AttackSearchAngle;
    [FieldOffset(0x0054)] public float InertiaRunningTime;
    [FieldOffset(0x0058)] public float BrakingTime;
    [FieldOffset(0x005C)] public float LostWaitTime;
    [FieldOffset(0x0060)] public float RespawnInterval;
    [FieldOffset(0x0064)] public float RespawnDistance;
    [FieldOffset(0x0068)] public float VanishSpawnDistance;
    [FieldOffset(0x006C)] public FVector HitBoxOffset;
    [FieldOffset(0x0078)] public FVector HitBoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FFldEnemyConditionConfusionParam
{
    [FieldOffset(0x0000)] public float MovementRange;
    [FieldOffset(0x0004)] public FFldEnemySearchParam NormalSearch;
    [FieldOffset(0x000C)] public FFldEnemySearchParam PlayerNearSearch;
    [FieldOffset(0x0014)] public FFldEnemySearchParam PlayerDashSearch;
    [FieldOffset(0x001C)] public FFldEnemySearchParam PlayerFindingSearch;
    [FieldOffset(0x0028)] public TArray<FFldEnemyLoiterParam> LoiterSpeed;
    [FieldOffset(0x0038)] public float LoiterWaitTime;
    [FieldOffset(0x003C)] public float DiscoverWaitTime;
    [FieldOffset(0x0040)] public FFldEnemyLoiterParam TrackingSpeed;
    [FieldOffset(0x0050)] public float TrackingTime;
    [FieldOffset(0x0054)] public float TrackingSearchAngle;
    [FieldOffset(0x0058)] public float AttackBlendOut;
    [FieldOffset(0x005C)] public float AttackPlayRate;
    [FieldOffset(0x0060)] public int AttackRotMin;
    [FieldOffset(0x0064)] public int AttackRotMax;
    [FieldOffset(0x0068)] public float AttackRotSpeed;
    [FieldOffset(0x006C)] public float AttackRigidTime;
    [FieldOffset(0x0070)] public float LostWaitTime;
    [FieldOffset(0x0074)] public float RespawnInterval;
    [FieldOffset(0x0078)] public float RespawnDistance;
    [FieldOffset(0x007C)] public float VanishSpawnDistance;
    [FieldOffset(0x0080)] public FVector HitBoxOffset;
    [FieldOffset(0x008C)] public FVector HitBoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FFldEnemyConditionFearParam
{
    [FieldOffset(0x0000)] public float MovementRange;
    [FieldOffset(0x0004)] public FFldEnemySearchParam NormalSearch;
    [FieldOffset(0x000C)] public FFldEnemySearchParam PlayerNearSearch;
    [FieldOffset(0x0014)] public FFldEnemySearchParam PlayerDashSearch;
    [FieldOffset(0x001C)] public FFldEnemySearchParam PlayerFindingSearch;
    [FieldOffset(0x0028)] public TArray<FFldEnemyLoiterParam> LoiterSpeed;
    [FieldOffset(0x0038)] public float LoiterWaitTime;
    [FieldOffset(0x003C)] public float DiscoverWaitTime;
    [FieldOffset(0x0040)] public float TrackingAngle;
    [FieldOffset(0x0044)] public float TrackingSpeed;
    [FieldOffset(0x0048)] public float TrackingTime;
    [FieldOffset(0x004C)] public float AttackBlendOut;
    [FieldOffset(0x0050)] public float WinceTime;
    [FieldOffset(0x0054)] public float WinceDistance;
    [FieldOffset(0x0058)] public float EscapeSpeed;
    [FieldOffset(0x005C)] public float EscapeRotSpeed;
    [FieldOffset(0x0060)] public float EscapeDistance;
    [FieldOffset(0x0064)] public float EscapeMinimumTime;
    [FieldOffset(0x0068)] public float LostWaitTime;
    [FieldOffset(0x006C)] public float RespawnInterval;
    [FieldOffset(0x0070)] public float RespawnDistance;
    [FieldOffset(0x0074)] public float VanishSpawnDistance;
    [FieldOffset(0x0078)] public FVector HitBoxOffset;
    [FieldOffset(0x0084)] public FVector HitBoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FFldEnemyRareParam
{
    [FieldOffset(0x0000)] public float MovementRange;
    [FieldOffset(0x0004)] public FFldEnemySearchParam NormalSearch;
    [FieldOffset(0x000C)] public FFldEnemySearchParam PlayerNearSearch;
    [FieldOffset(0x0014)] public FFldEnemySearchParam PlayerDashSearch;
    [FieldOffset(0x001C)] public FFldEnemySearchParam PlayerFindingSearch;
    [FieldOffset(0x0028)] public TArray<FFldEnemyLoiterParam> LoiterSpeed;
    [FieldOffset(0x0038)] public float LoiterWaitTime;
    [FieldOffset(0x003C)] public float DiscoverWaitTime;
    [FieldOffset(0x0040)] public float EscapeSpeed;
    [FieldOffset(0x0044)] public float EscapeRotSpeed;
    [FieldOffset(0x0048)] public float EscapeTime;
    [FieldOffset(0x004C)] public float RespawnInterval;
    [FieldOffset(0x0050)] public float RespawnDistance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldEnemyReaperParam
{
    [FieldOffset(0x0000)] public float TrackingSpeed;
    [FieldOffset(0x0004)] public float AttackStartDistance;
    [FieldOffset(0x0008)] public float AttackPreparationTime;
    [FieldOffset(0x000C)] public float AttackBlendOut;
    [FieldOffset(0x0010)] public float AttackWaitTime;
    [FieldOffset(0x0014)] public float LockAtPlayerRotSpeed;
    [FieldOffset(0x0018)] public FVector HitBoxOffset;
    [FieldOffset(0x0024)] public FVector HitBoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldEnemySkillReaction
{
    [FieldOffset(0x0000)] public FFldEnemySkillReactionParam Normal;
    [FieldOffset(0x0002)] public FFldEnemySkillReactionParam Strong;
    [FieldOffset(0x0004)] public FFldEnemySkillReactionParam Rare;
    [FieldOffset(0x0006)] public FFldEnemySkillReactionParam Death;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A0)] 
public unsafe struct UFldEnemyDataAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public float ScaleMax;
    [FieldOffset(0x0034)] public float ScaleMin;
    [FieldOffset(0x0038)] public int ScaleStep;
    [FieldOffset(0x0040)] public FFldEnemyNormalParam Normal;
    [FieldOffset(0x00D0)] public FFldEnemyConditionAngerParam anger;
    [FieldOffset(0x0158)] public FFldEnemyConditionConfusionParam Confusion;
    [FieldOffset(0x01F0)] public FFldEnemyConditionFearParam fear;
    [FieldOffset(0x0280)] public FFldEnemyNormalParam upset;
    [FieldOffset(0x0310)] public FFldEnemyRareParam Rare;
    [FieldOffset(0x0368)] public FFldEnemyReaperParam Death;
    [FieldOffset(0x0398)] public FFldEnemySkillReaction SkillReaction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldEnemyFootprintAsset
{
    [FieldOffset(0x0000)] public UMaterialInterface* Color;
    [FieldOffset(0x0008)] public UMaterialInterface* Normal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UFldEnemyFootprintDA
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FFldEnemyFootprintAsset> Assets;
    [FieldOffset(0x0040)] public float Span;
    [FieldOffset(0x0044)] public float FadeDelay;
    [FieldOffset(0x0048)] public float FadeDuration;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct UFldEnemyUniqueComp
{
    [FieldOffset(0x0000)] public UFldEnemyComp baseObj;
    [FieldOffset(0x0188)] public EFldEnemyState State;
    [FieldOffset(0x018C)] public EFldEnemyState NextState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F8)] 
public unsafe struct AFldFieldEventActor
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x02A0)] public UAppCharacterComp* mChgHeroComp_;
    [FieldOffset(0x02A8)] public TMap<int, IntPtr> mChgPartnerComps_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UFldFollowerComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public float mLengthLEAVE_START_;
    [FieldOffset(0x00CC)] public float mLengthLEAVE_END_;
    [FieldOffset(0x00D0)] public float mLengthAPPROACH_START_;
    [FieldOffset(0x00D4)] public float mLengthAPPROACH_END_;
    [FieldOffset(0x00D8)] public float mLengthALLAY_NEAR_;
    [FieldOffset(0x00DC)] public float mLengthSPEAK_HERO_;
    [FieldOffset(0x00E0)] public float mIdleMinTime_;
    [FieldOffset(0x00E4)] public float mIdleMaxTime_;
    [FieldOffset(0x00E8)] public float mLookMinTime_;
    [FieldOffset(0x00EC)] public float mLookMaxTime_;
    [FieldOffset(0x00F0)] public float mSideMinTime_;
    [FieldOffset(0x00F4)] public float mSideMaxTime_;
    [FieldOffset(0x00F8)] public float mInterpSpeed_;
    [FieldOffset(0x00FC)] public uint mFlag_;
    [FieldOffset(0x0100)] public int mFollowerIndex_;
    [FieldOffset(0x0104)] public float mApprouchRad_;
    [FieldOffset(0x0108)] public UAppCharacterComp* mCharaComp_;
    [FieldOffset(0x0110)] public UCapsuleComponent* mCapsuleComp_;
    [FieldOffset(0x0118)] public UCharacterMovementComponent* mMoveComp_;
    [FieldOffset(0x0120)] public AFldHitCharacter* mHitChild_;
    [FieldOffset(0x0128)] public UFldNpcComp* mNpcComp_;
    [FieldOffset(0x0130)] public UFldFollowerPointComp* mPointComp_;
    [FieldOffset(0x0138)] public bool bIsLookAt_;
    [FieldOffset(0x013C)] public float mLookTimer_;
    [FieldOffset(0x0140)] public float mLookEndTime_;
    [FieldOffset(0x0144)] public FVector mLookBaseLocation_;
    [FieldOffset(0x0150)] public int mLookYawDir_;
    [FieldOffset(0x0154)] public int mLookCount_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct AFldFollowerController
{
    [FieldOffset(0x0000)] public AAIController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UFldFollowerPointComp
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldSaveCallField
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FFldHitActorChgIconParam
{
    [FieldOffset(0x0000)] public FName mFlagName;
    [FieldOffset(0x0008)] public EFldHitActorIconType mIconType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct AFldHitActor
{
    [FieldOffset(0x0000)] public AFldHitCore baseObj;
    [FieldOffset(0x0340)] public int mMajorID_;
    [FieldOffset(0x0344)] public int mMinorID_;
    [FieldOffset(0x0348)] public EFldHitType mType_;
    [FieldOffset(0x034C)] public int mNameIndex_;
    [FieldOffset(0x0350)] public EFldHitActorIconType mIconType_;
    [FieldOffset(0x0358)] public TArray<FFldHitActorChgIconParam> mChangeIconParam_;
    [FieldOffset(0x0368)] public FName mReadedFlagName_;
    [FieldOffset(0x0370)] public int mFloorIndex_;
    [FieldOffset(0x0374)] public FName mOffFlagName_;
    [FieldOffset(0x037C)] public FName mExecutedFlagName_;
    [FieldOffset(0x0384)] public FName mIgnoreFlagName_;
    [FieldOffset(0x0390)] public AActor* mIconActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct AFldHitActorBOX
{
    [FieldOffset(0x0000)] public AFldHitActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct AFldHitActorCAPSULE
{
    [FieldOffset(0x0000)] public AFldHitActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldHitActorEachPlayerProc
{
    [FieldOffset(0x0000)] public int mPlayerID;
    [FieldOffset(0x0008)] public TSubclassOf<AUtlProcActor> mProcActor;
    [FieldOffset(0x0010)] public bool mKeyLock;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A8)] 
public unsafe struct AFldHitActorEachPlayer
{
    [FieldOffset(0x0000)] public AFldHitActor baseObj;
    [FieldOffset(0x0398)] public TArray<FFldHitActorEachPlayerProc> mProcList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UFldHitCharaIdleBehaviorComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public float mIdleMinTime_;
    [FieldOffset(0x00CC)] public float mIdleMaxTime_;
    [FieldOffset(0x00D0)] public float mLookMinTime_;
    [FieldOffset(0x00D4)] public float mLookMaxTime_;
    [FieldOffset(0x00D8)] public float mSideMinTime_;
    [FieldOffset(0x00DC)] public float mSideMaxTime_;
    [FieldOffset(0x00E0)] public float mInterpSpeed_;
    [FieldOffset(0x00E4)] public uint mFlag_;
    [FieldOffset(0x00E8)] public UFldNpcComp* mNpcComp_;
    [FieldOffset(0x00F0)] public bool bIsLookAt_;
    [FieldOffset(0x00F4)] public float mLookTimer_;
    [FieldOffset(0x00F8)] public float mLookEndTime_;
    [FieldOffset(0x00FC)] public FVector mLookBaseLocation_;
    [FieldOffset(0x0108)] public int mLookYawDir_;
    [FieldOffset(0x010C)] public int mLookCount_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldHitCitTimeParam
{
    [FieldOffset(0x0000)] public float mMinTime;
    [FieldOffset(0x0004)] public float mMaxTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldHitCitLookParam
{
    [FieldOffset(0x0000)] public FFldHitCitTimeParam baseObj;
    [FieldOffset(0x0008)] public AFldLocalActor* mTargetActer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldHitCharaIdleTalkCharacterParam
{
    [FieldOffset(0x0000)] public UFldNpcComp* mNpcComp;
    [FieldOffset(0x0008)] public float mMotionTimer;
    [FieldOffset(0x000C)] public float mMotionMaxTime;
    [FieldOffset(0x0010)] public float bIsLookAt;
    [FieldOffset(0x0014)] public float mLookTimer;
    [FieldOffset(0x0018)] public float mLookMaxTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UFldHitCharaIdleTalkComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public FFldHitCitTimeParam mMotionParam_;
    [FieldOffset(0x00D0)] public FFldHitCitLookParam mLookParam_;
    [FieldOffset(0x00E0)] public bool bLookAtFlag_;
    [FieldOffset(0x00E4)] public uint mFlag_;
    [FieldOffset(0x00E8)] public TArray<FFldHitCharaIdleTalkCharacterParam> mParamArray_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldHitPartnerProcs
{
    [FieldOffset(0x0000)] public TSubclassOf<AUtlProcActor> Talk;
    [FieldOffset(0x0008)] public TSubclassOf<AUtlProcActor> Assemble;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct AFldHitPartner
{
    [FieldOffset(0x0000)] public AFldHitCore baseObj;
    [FieldOffset(0x0340)] public TMap<int, FFldHitPartnerProcs> Procs;
    [FieldOffset(0x0390)] public int CharId;
    [FieldOffset(0x0394)] public bool bTalkFirst;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldHitSoundCore
{
    [FieldOffset(0x0000)] public AFldAtomSound baseObj;
    [FieldOffset(0x02A8)] public UShapeComponent* HitComp;
    [FieldOffset(0x02B0)] public uint mFlag_;
    [FieldOffset(0x02B4)] public float mTimer_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldHitSound_BOX
{
    [FieldOffset(0x0000)] public AFldHitSoundCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldHitSound_CIRCLE
{
    [FieldOffset(0x0000)] public AFldHitSoundCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldHitSoundSnapshotCore
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public bool mOffInEvent_;
    [FieldOffset(0x0288)] public FString mSnapshotName_;
    [FieldOffset(0x0298)] public UShapeComponent* HitComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldHitSoundSnapshot_BOX
{
    [FieldOffset(0x0000)] public AFldHitSoundSnapshotCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldHitSoundSnapshot_CIRCLE
{
    [FieldOffset(0x0000)] public AFldHitSoundSnapshotCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldInitScriptManager
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AFldKeyFreeAnnounceActor
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0298)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x02A0)] public UBfAsset* mBfAsset_;
    [FieldOffset(0x02A8)] public UBmdAsset* mBmdAsset_;
    [FieldOffset(0x02B0)] public AFldScriptActor* mScriptActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AFldKeyFreeEventActor
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x02A0)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x02A8)] public UBfAsset* mBfAsset_;
    [FieldOffset(0x02B0)] public UBmdAsset* mBmdAsset_;
    [FieldOffset(0x02B8)] public UBfAsset* mAncBfAsset_;
    [FieldOffset(0x02C0)] public UBmdAsset* mAncBmdAsset_;
    [FieldOffset(0x02C8)] public AFldScriptActor* mScriptActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct AFldLevelLoaderMonitorActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public int mUniqueId_;
    [FieldOffset(0x0224)] public EFldLevelLoaderType mType_;
    [FieldOffset(0x0228)] public FString mLevelAssetPath_;
    [FieldOffset(0x0240)] public float mProcTimer_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct AFldLevelManager
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldLevelPoolManager
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x02A0)] public TArray<FString> mLevelPaths_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldLinkAnimHitBase
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public USceneComponent* RootComp_;
    [FieldOffset(0x0288)] public UShapeComponent* HitComp_;
    [FieldOffset(0x0290)] public TArray<IntPtr> mLinkObjectArray_;
    [FieldOffset(0x02A0)] public bool mOneshotFlag_;
    [FieldOffset(0x02A4)] public uint mFlag_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldLinkAnimHit_BOX
{
    [FieldOffset(0x0000)] public AFldLinkAnimHitBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldLinkAnimHit_CIRCLE
{
    [FieldOffset(0x0000)] public AFldLinkAnimHitBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UFldLinkAnimHitComp_BOX
{
    [FieldOffset(0x0000)] public UBoxComponent baseObj;
    [FieldOffset(0x0478)] public TArray<FString> mLinkCompNameArray_;
    [FieldOffset(0x0488)] public bool mOneshotFlag_;
    [FieldOffset(0x048C)] public uint mFlag_;
    [FieldOffset(0x0490)] public TArray<IntPtr> mLinkChildArray_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UFldLinkAnimHitComp_CIRCLE
{
    [FieldOffset(0x0000)] public USphereComponent baseObj;
    [FieldOffset(0x0470)] public TArray<FString> mLinkCompNameArray_;
    [FieldOffset(0x0480)] public bool mOneshotFlag_;
    [FieldOffset(0x0484)] public uint mFlag_;
    [FieldOffset(0x0488)] public TArray<IntPtr> mLinkChildArray_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldLaoAnimData
{
    [FieldOffset(0x0000)] public UAnimationAsset* mAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct AFldLinkAnimObj
{
    [FieldOffset(0x0000)] public AFldObjBase baseObj;
    [FieldOffset(0x0298)] public FFldLaoAnimData mAnime_WAIT_;
    [FieldOffset(0x02A0)] public FFldLaoAnimData mAnime_START_;
    [FieldOffset(0x02A8)] public TArray<FFldLaoAnimData> mAnimeArray_LOOP_;
    [FieldOffset(0x02B8)] public bool mAnimeLoopFlag_;
    [FieldOffset(0x02C0)] public FFldLaoAnimData mAnime_END_;
    [FieldOffset(0x02C8)] public uint mFlag_;
    [FieldOffset(0x02CC)] public int mLoopIndex_;
    [FieldOffset(0x02D0)] public TArray<IntPtr> mAnimeMeshList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldLmapManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldMailOrderScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F0)] 
public unsafe struct UFldManagerSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x00B0)] public AFldLevelManager* mLevelManager_;
    [FieldOffset(0x00C0)] public UAppCharacterComp* mPlayerComp_;
    [FieldOffset(0x00D0)] public FTransform mPlayerTransform;
    [FieldOffset(0x0100)] public AFldOperator* mOparetator_;
    [FieldOffset(0x0108)] public AFldInitScriptManager* mInitScrManager_;
    [FieldOffset(0x0140)] public AFldKeyFreeAnnounceActor* mKeyFreeAnnounceActor_;
    [FieldOffset(0x0148)] public AFldKeyFreeEventActor* mKeyFreeEventActor_;
    [FieldOffset(0x0150)] public AFldFieldEventActor* mFieldEventActor_;
    [FieldOffset(0x0158)] public AAppActor* mLargeMapActor_;
    [FieldOffset(0x0160)] public UFldSoundManager* mSoundManager_;
    [FieldOffset(0x0168)] public UFldMiniMapManager* mMiniMapManager_;
    [FieldOffset(0x02C8)] public AFldDungeonMenuScript* mDungeonMenuScript_;
    [FieldOffset(0x02D0)] public AFldDailyMenuScript* mDailyMenuScript_;
    [FieldOffset(0x02D8)] public AUISaveLoad* mSaveMenu_;
    [FieldOffset(0x02E0)] public AUIBackLog* mBackLogDisp_;
    [FieldOffset(0x02E8)] public AActor* mVoiceActionDisp_;
    [FieldOffset(0x02F0)] public AFldHitCore* mKeyLockedActor_;
    [FieldOffset(0x02F8)] public AFldAutoRecoverMenuScript* mAutoRecoverMenuScript_;
    [FieldOffset(0x0300)] public TArray<IntPtr> mHiddenActorArray_;
    [FieldOffset(0x0310)] public AFldMiscCharBaseReload* mCharBaseReload_;
    [FieldOffset(0x0318)] public TMap<EFldCmnProps, IntPtr> mCmnPropsActors_;
    [FieldOffset(0x0368)] public AFldMiscCameraShake* mCameraShake_;
    [FieldOffset(0x0370)] public float mKeyHelpDelayTimer_;
    [FieldOffset(0x0374)] public float mMoveFloorTimer_;
    [FieldOffset(0x0378)] public TSubclassOf<ACharacterBaseCore> mDefaultPlayerClass_;
    [FieldOffset(0x0380)] public TSubclassOf<ACharacterBaseCore> mDungeonPlayerClass_;
    [FieldOffset(0x0388)] public TSubclassOf<AFldCameraBase> mDefaultCameraClass_;
    [FieldOffset(0x0390)] public TSubclassOf<AFldCameraBase> mDungeonCameraClass_;
    [FieldOffset(0x0398)] public TSubclassOf<AFldCamera> mTransCameraClass_;
    [FieldOffset(0x03A0)] public TSubclassOf<ACharacterBaseCore> mFollowerClass_;
    [FieldOffset(0x03A8)] public TSubclassOf<ACharacterBaseCore> mFollowerKoromaruClass_;
    [FieldOffset(0x03B0)] public UObject* mWorldContextObject_;
    [FieldOffset(0x03B8)] public AFldMiscCharaBaseMove* mMoveActor_;
    [FieldOffset(0x03C0)] public bool mCameraLock_;
    [FieldOffset(0x03C8)] public AFldMiscCameraMove* mCameraMoveActor_;
    [FieldOffset(0x03D0)] public TArray<IntPtr> mOverlapedHitArray_;
    [FieldOffset(0x03E0)] public AAppActor* mDebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UFldMiniMapManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0070)] public TArray<IntPtr> mCharactorList_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7C0)] 
public unsafe struct AFldMiscCameraMove
{
    [FieldOffset(0x0000)] public ACameraActor baseObj;
    [FieldOffset(0x07B0)] public uint mFlag_;
    [FieldOffset(0x07B4)] public float mTimer_;
    [FieldOffset(0x07B8)] public AFldMiscCameraMove* mPrevCamera_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldMiscCameraShake
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public UMaterialParameterCollection* mCollection_;
    [FieldOffset(0x0288)] public float mSetTime_;
    [FieldOffset(0x028C)] public float mSetFrequency_;
    [FieldOffset(0x0290)] public float mSetPowerX_;
    [FieldOffset(0x0294)] public float mSetPowerY_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct AFldMiscCharaBaseMove
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x02A0)] public AActor* mCharactor_;
    [FieldOffset(0x02A8)] public UFldNpcComp* mNpcComp_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldMiscCharBaseReload_Data
{
    [FieldOffset(0x0000)] public FFldMiscCharBaseReload_Type mType;
    [FieldOffset(0x0008)] public UAppCharacterComp* mCharaComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AFldMiscCharBaseReload
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public TArray<FFldMiscCharBaseReload_Data> mDataArray_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct AFldNpcActor
{
    [FieldOffset(0x0000)] public AFldHitCharacter baseObj;
    [FieldOffset(0x0458)] public int mMajorID_;
    [FieldOffset(0x045C)] public int mMinorID_;
    [FieldOffset(0x0460)] public EFldNpcActorType mType_;
    [FieldOffset(0x0464)] public int mNameIndex_;
    [FieldOffset(0x0468)] public bool mNotMapInfoDisp_;
    [FieldOffset(0x046C)] public FVector mMapIconDirectLocation_;
    [FieldOffset(0x0478)] public bool bMapIconDirectLocation_;
    [FieldOffset(0x047C)] public FName mOnFlagName_;
    [FieldOffset(0x0484)] public FName mOffFlagName_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FFldNpcCompPropsInfo
{
    [FieldOffset(0x0000)] public AAppPropsCore* mActor;
    [FieldOffset(0x0008)] public FSoftObjectPath mFilePath;
    [FieldOffset(0x0020)] public int mAttachIndex;
    [FieldOffset(0x0028)] public FString mAttachName;
    [FieldOffset(0x0040)] public FTransform mTransform;
    [FieldOffset(0x0070)] public bool mMotionAttached;
    [FieldOffset(0x0074)] public int mWaitMotionID;
    [FieldOffset(0x0078)] public int mSpeakMotionID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FFldNpcCompOrnamentsInfo
{
    [FieldOffset(0x0000)] public FFldNpcCompPropsInfo baseObj;
    [FieldOffset(0x0080)] public int mOnFlagValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UFldNpcComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00D8)] public UAppCharBaseComp* mCharaBaseComp_;
    [FieldOffset(0x00E8)] public int mListIndex_;
    [FieldOffset(0x00EC)] public int mMajorID_;
    [FieldOffset(0x00F0)] public int mMinorID_;
    [FieldOffset(0x00F4)] public int mFbnNumber_;
    [FieldOffset(0x00F8)] public float mSpeakMotionBlendInTime_;
    [FieldOffset(0x00FC)] public float mSpeakMotionBlendOutTime_;
    [FieldOffset(0x0118)] public TArray<FFldNpcCompPropsInfo> mPropsArray_;
    [FieldOffset(0x0128)] public TArray<FFldNpcCompOrnamentsInfo> mOrnamentsArray_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UFldOperationBase
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public AFldOperator* Holder;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UFldOperationPrePhysics
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UFldOperationCamera
{
    [FieldOffset(0x0000)] public UFldOperationBase baseObj;
    [FieldOffset(0x00B8)] public AFldCameraHitBase* CurrentHitRef;
    [FieldOffset(0x00C0)] public bool bLock;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UFldOperationPlayer
{
    [FieldOffset(0x0000)] public UFldOperationBase baseObj;
    [FieldOffset(0x00B8)] public bool HitUI;
    [FieldOffset(0x00C0)] public FMatrix Direction;
    [FieldOffset(0x0100)] public FVector2D PreviousAxisL;
    [FieldOffset(0x0108)] public FFldEnemyHolder EncountEnemy;
    [FieldOffset(0x0118)] public float Timer;
    [FieldOffset(0x011C)] public float StackTimer;
    [FieldOffset(0x0120)] public bool CameraChanged;
    [FieldOffset(0x0124)] public float Clamp;
    [FieldOffset(0x0128)] public FVector2D D_AxisL;
    [FieldOffset(0x0130)] public FVector2D D_AxisR;
    [FieldOffset(0x0138)] public FVector2D D_ClampAxisL;
    [FieldOffset(0x0140)] public FVector2D D_ClampAxisR;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AFldOperator
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UFldOperationCamera* OpCameraComp;
    [FieldOffset(0x0228)] public UFldOperationPlayer* OpPlayerComp;
    [FieldOffset(0x0230)] public UFldOperationPrePhysics* OpPrePhysicsComp;
    [FieldOffset(0x0238)] public AFldCamera* MainCamera;
    [FieldOffset(0x0240)] public AFldCameraFree* FreeCamera;
    [FieldOffset(0x0248)] public FFldPlayerHolder PlayerHolder;
    [FieldOffset(0x0260)] public AController* PlayerController;
    [FieldOffset(0x0268)] public AKernelInput* KernelInput;
    [FieldOffset(0x0270)] public TArray<IntPtr> OverloapHits;
    [FieldOffset(0x0280)] public EFldOperatorKeyState KeyState;
    [FieldOffset(0x0284)] public EFldOperatorState State;
    [FieldOffset(0x0288)] public EFldOperatorState NextState;
    [FieldOffset(0x0290)] public FFldEnemyHolder EncountEnemy;
    [FieldOffset(0x02A0)] public EFldOperatorEncountType EncountType;
    [FieldOffset(0x02A8)] public FFldPartnerHolder AssembleEvent;
    [FieldOffset(0x02B8)] public bool bDebugStandalone;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UFldPartnerPointComp
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public int UsePartyId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x200)] 
public unsafe struct UFldPartnerStartPointComp
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public int ID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F8)] 
public unsafe struct UFldPartnerComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public UAppCharacterComp* AppCharacter;
    [FieldOffset(0x00D0)] public UCharacterLipsyncAppComponent* LipComp;
    [FieldOffset(0x00D8)] public UCharacterSimpleLipsAnimAppComponent* SimpleLipComp;
    [FieldOffset(0x00E0)] public AFldPartnerController* ControllerRef;
    [FieldOffset(0x00E8)] public FFldPlayerHolder Player;
    [FieldOffset(0x0100)] public int PartyID;
    [FieldOffset(0x0104)] public FFldPartnerData Data;
    [FieldOffset(0x0114)] public FFldCharSpeed SpeedData;
    [FieldOffset(0x0124)] public bool bAllowStandbyToFinish;
    [FieldOffset(0x0128)] public EFldPartnerState State;
    [FieldOffset(0x012C)] public EFldPartnerState NextState;
    [FieldOffset(0x0130)] public EFldPartnerBehavior Behavior;
    [FieldOffset(0x0134)] public EFldPartnerBehavior NextBehavior;
    [FieldOffset(0x0138)] public int TrackingPointId;
    [FieldOffset(0x013C)] public FVector TrackingLocation;
    [FieldOffset(0x0148)] public FVector TrackingPlayerLocation;
    [FieldOffset(0x0154)] public FVector AvoidLocation;
    [FieldOffset(0x01D0)] public FVector MoveForce;
    [FieldOffset(0x01E0)] public UFldCharPersonalMotionComp* PersonalMotionComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct AFldPartnerController
{
    [FieldOffset(0x0000)] public AAIController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AFldPartnerManager
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public TArray<FFldPartnerHolder> Partners;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct UFldPlayerComp
{
    [FieldOffset(0x0000)] public UFldLocalActorComp baseObj;
    [FieldOffset(0x00C8)] public AController* ControllerRef;
    [FieldOffset(0x00D0)] public UAppCharacterComp* AppCharComp;
    [FieldOffset(0x00D8)] public AFldHitCore* HitCoreRef;
    [FieldOffset(0x00E0)] public AFldCameraHitBase* CameraHitRef;
    [FieldOffset(0x00E8)] public FFldPlayerData PlayerData;
    [FieldOffset(0x0200)] public FFldCharSpeed SpeedData;
    [FieldOffset(0x0210)] public EFldPlayerState State;
    [FieldOffset(0x0214)] public EFldPlayerState NextState;
    [FieldOffset(0x0218)] public bool bEnableDash;
    [FieldOffset(0x0219)] public bool bEnableAssault;
    [FieldOffset(0x021A)] public bool bJammingSkill;
    [FieldOffset(0x021B)] public bool bPressureSkill;
    [FieldOffset(0x021C)] public bool bOnceAnimStop;
    [FieldOffset(0x021D)] public bool bNotSearchedByEnemies;
    [FieldOffset(0x0220)] public UAnimMontage* AttackMontage;
    [FieldOffset(0x0278)] public UFldCharPersonalMotionComp* PersonalMotionComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x44)] 
public unsafe struct FldPlayerInputInterpolation
{
    [FieldOffset(0x0000)] public FVector Begin;
    [FieldOffset(0x000C)] public FVector End;
    [FieldOffset(0x0038)] public float Distance;
    [FieldOffset(0x003C)] public float Yaw;
    [FieldOffset(0x0040)] public int Frame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UFldPlayerAbsComp
{
    [FieldOffset(0x0000)] public UFldPlayerComp baseObj;
    [FieldOffset(0x0304)] public FldPlayerInputInterpolation InputInterpolation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x380)] 
public unsafe struct UFldPlayerDailyComp
{
    [FieldOffset(0x0000)] public UFldPlayerAbsComp baseObj;
    [FieldOffset(0x0370)] public EFldPlayerDailyBehavior Behavior;
    [FieldOffset(0x0374)] public EFldPlayerDailyBehavior NextBehavior;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FFldCharEffectParam
{
    [FieldOffset(0x0000)] public UNiagaraSystem* Asset;
    [FieldOffset(0x0008)] public FName SocketName;
    [FieldOffset(0x0010)] public FTransform Transform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UFldPlayerDungeonComp
{
    [FieldOffset(0x0000)] public UFldPlayerAbsComp baseObj;
    [FieldOffset(0x0370)] public UChildActorComponent* AttackAreaComp;
    [FieldOffset(0x0378)] public AFldCharArea* AttackArea;
    [FieldOffset(0x0380)] public UChildActorComponent* SearchAreaComp;
    [FieldOffset(0x0388)] public AFldCharArea* SearchArea;
    [FieldOffset(0x0390)] public TMap<int, IntPtr> PartnerStartPoints;
    [FieldOffset(0x03E0)] public TArray<IntPtr> PartnerPoints;
    [FieldOffset(0x03F0)] public UPostProcessComponent* PostProcessComp;
    [FieldOffset(0x03F8)] public EFldPlayerDngBehavior Behavior;
    [FieldOffset(0x03FC)] public EFldPlayerDngBehavior NextBehavior;
    [FieldOffset(0x0400)] public float Timer;
    [FieldOffset(0x0404)] public int AttackId;
    [FieldOffset(0x0408)] public bool bNextAttack;
    [FieldOffset(0x0409)] public bool bRotAttack;
    [FieldOffset(0x040C)] public FVector AttackForward;
    [FieldOffset(0x0418)] public float RootMoveY;
    [FieldOffset(0x041C)] public float AssaultTimer;
    [FieldOffset(0x0420)] public bool bEncountingPause;
    [FieldOffset(0x0430)] public FFldCharEffectParam AssaultEffect;
    [FieldOffset(0x0470)] public UNiagaraComponent* AssaultNiagara;
    [FieldOffset(0x0478)] public FVector AttackOrbitBegin;
    [FieldOffset(0x0484)] public FVector AttackOrbitEnd;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UFldPlayerEncountComp
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public UAppCharacterComp* AppCharComp;
    [FieldOffset(0x00D0)] public UAnimMontage* AnimMontage;
    [FieldOffset(0x00D8)] public UAnimSequenceBase* RunAnim;
    [FieldOffset(0x00E0)] public UAnimSequenceBase* AttackAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct AFldPlayerStart
{
    [FieldOffset(0x0000)] public APlayerStart baseObj;
    [FieldOffset(0x0250)] public int mIndex_;
    [FieldOffset(0x0258)] public USceneComponent* CameraDir;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct AFldPostValumeSound
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
    [FieldOffset(0x0280)] public float mOutRadius_;
    [FieldOffset(0x0284)] public float mInRadius_;
    [FieldOffset(0x0288)] public bool bXdirOnly_;
    [FieldOffset(0x0289)] public bool bYdirOnly_;
    [FieldOffset(0x0290)] public USceneComponent* RootComp;
    [FieldOffset(0x0298)] public UShapeComponent* HitComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AFldScriptActor
{
    [FieldOffset(0x0000)] public AFldLocalActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldShortcutMove
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0298)] public UAssetLoader* mAssetLoader_;
    [FieldOffset(0x02A0)] public UBfAsset* mBfAsset_;
    [FieldOffset(0x02A8)] public AFldScriptActor* mScriptActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UFldShortcutManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AFldSoundMngChangeTownmapActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AFldSoundMngChangeAISAC
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldSoundMngAisacSet
{
    [FieldOffset(0x0000)] public uint mAisacID;
    [FieldOffset(0x0004)] public float mNowValume;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UFldSoundManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public uint mFlag_;
    [FieldOffset(0x0030)] public AFldSoundMngChangeAISAC* mChgActorAISAC_;
    [FieldOffset(0x0038)] public FString mComVoicePath_;
    [FieldOffset(0x0048)] public FString mComSePath_;
    [FieldOffset(0x0058)] public FString mGayaSePath_;
    [FieldOffset(0x0068)] public TArray<IntPtr> mActorArrays_;
    [FieldOffset(0x0078)] public TArray<IntPtr> mAtomCompArray_;
    [FieldOffset(0x0088)] public TArray<FFldSoundMngAisacSet> mAisacArray_;
    [FieldOffset(0x0098)] public TArray<IntPtr> mPostVolumeArray_;
    [FieldOffset(0x00A8)] public AFldSoundMngChangeTownmapActor* mChangeActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AFldTargetIcon
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public FName mOnFlagName_;
    [FieldOffset(0x0280)] public FName mOffFlagName_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AFldTvProgramScript
{
    [FieldOffset(0x0000)] public AFldScriptManagerCore baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFrameBufferCaptureDebugWork
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UFrameBufferCapture
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<FFrameBufferCaptureDebugWork> DebugInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UGenericSelectSystemBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UGenericSelectItem
{
    [FieldOffset(0x0000)] public UGenericSelectSystemBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UGenericSelectMsg
{
    [FieldOffset(0x0000)] public UGenericSelectSystemBase baseObj;
    [FieldOffset(0x0060)] public UTexture* SelectionImage_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UGenericSelectShop
{
    [FieldOffset(0x0000)] public UGenericSelectMsg baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UGlobalGameData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<int> mFlags_ALWAYS_;
    [FieldOffset(0x0038)] public TArray<int> mFlags_ANY_;
    [FieldOffset(0x0048)] public TArray<int> mCounters_ALWAYS_;
    [FieldOffset(0x0058)] public TArray<int> mCounters_ANY_;
    [FieldOffset(0x0068)] public TArray<ushort> mComItems_ALWAYS_;
    [FieldOffset(0x0078)] public TArray<ushort> mComItems_ANY_;
    [FieldOffset(0x0088)] public TArray<ushort> mEvtItems_ALWAYS_;
    [FieldOffset(0x0098)] public TArray<ushort> mEvtItems_ANY_;
    [FieldOffset(0x00A8)] public TArray<ushort> mDlcItems_ALWAYS_;
    [FieldOffset(0x00B8)] public TArray<ushort> mNotInheritanceItems_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FSaveGameHeadder
{
    [FieldOffset(0x0000)] public FString GameName;
    [FieldOffset(0x0010)] public FString SaveSlotName;
    [FieldOffset(0x0020)] public uint UserIndex;
    [FieldOffset(0x0024)] public sbyte FirstName;
    [FieldOffset(0x0064)] public sbyte LastName;
    [FieldOffset(0x00A4)] public int Month;
    [FieldOffset(0x00A8)] public int Day;
    [FieldOffset(0x00AC)] public ECldWeek Week;
    [FieldOffset(0x00AD)] public ECldTimeZone TimeZone;
    [FieldOffset(0x00B0)] public int FldMajorID;
    [FieldOffset(0x00B4)] public int FldMinorID;
    [FieldOffset(0x00B8)] public int FldPartsID;
    [FieldOffset(0x00BC)] public uint PlayerLevel;
    [FieldOffset(0x00C0)] public ushort Difficulty;
    [FieldOffset(0x00C4)] public uint PlayTime;
    [FieldOffset(0x00C8)] public ECldMoonAge Age;
    [FieldOffset(0x00CC)] public int ClearStatus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250E0)] 
public unsafe struct UGlobalWork
{
    [FieldOffset(0x0000)] public UGameInstance baseObj;
    [FieldOffset(0x24778)] public USequence* mSequenceInstance_;
    [FieldOffset(0x24780)] public UCalendar* mCalendarInstance_;
    [FieldOffset(0x24788)] public UCldCommonData* mCldCommonData_;
    [FieldOffset(0x24790)] public UFileNameManager* mFileNameData_;
    [FieldOffset(0x24798)] public UFldCommonData* mFldCommonData_;
    [FieldOffset(0x247A0)] public UDatItem* mItemData_;
    [FieldOffset(0x247A8)] public UTrophyManager* mTrophy_;
    [FieldOffset(0x247B0)] public ULeaderBoardManager* mLeaderBoard_;
    [FieldOffset(0x247B8)] public USignedInDialog* mSignedInDialog_;
    [FieldOffset(0x247C0)] public UErrorDialog* mErrorDialog_;
    [FieldOffset(0x247C8)] public UMessageDialog* mMessageDialog_;
    [FieldOffset(0x247D0)] public UBustupController* pBustupController;
    [FieldOffset(0x247D8)] public UCommunityWork* pCommunityWork;
    [FieldOffset(0x247E0)] public UMsgWork* pMsgWork;
    [FieldOffset(0x247E8)] public UEvtDataLoad* pEvtDataLoad;
    [FieldOffset(0x247F0)] public UFrameBufferCapture* pFrameBufferCapture;
    [FieldOffset(0x247F8)] public UPadRumble* pPadRumble;
    [FieldOffset(0x248C8)] public UFldCharParamTable* mFldCharParamTable_;
    [FieldOffset(0x248D0)] public UAppCharFootstepsTable* mFootstepsTable_;
    [FieldOffset(0x248D8)] public UAppCharacterPoolManager* mCharacterPoolManager_;
    [FieldOffset(0x248E0)] public UDatSystemText* mSystemTextTable;
    [FieldOffset(0x248E8)] public UDatUIUseText* mUIUseTextTable;
    [FieldOffset(0x248F0)] public UDatUICalendarText* mUICalendarTextTable;
    [FieldOffset(0x248F8)] public UXrd777SaveManager* mSaveManager_;
    [FieldOffset(0x24900)] public UAddContent* mAddContent_;
    [FieldOffset(0x24F78)] public ULoading* pLoadingInst;
    [FieldOffset(0x24F80)] public ACmpMainActor* mCmpMainActor_;
    [FieldOffset(0x24F88)] public ABtlGuiResourcesBase* mBtlGuiResourcesActor_;
    [FieldOffset(0x24F90)] public UBtlEncountWipeLoader* mBtlEncountWipeLoader_;
    [FieldOffset(0x24F98)] public ABtlEncountWipeCore* mBtlEncountWipeCore_;
    [FieldOffset(0x24FA0)] public AFldLevelPoolManager* mLevelPoolManager_;
    [FieldOffset(0x24FA8)] public bool mPoolSetting_;
    [FieldOffset(0x24FE8)] public FSaveGameHeadder mTempSaveHeader_;
    [FieldOffset(0x250B8)] public bool bTempSaveHeaderUsed_;
    [FieldOffset(0x250C0)] public UGlobalGameData* mGameDataProc_;
    [FieldOffset(0x250C8)] public AAppActor* mSystemMonitor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGWSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public bool bIsDeterminedByCross;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UGlobalWorkBpLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGWHashBase
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public uint hash;
    [FieldOffset(0x000C)] public uint Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x368C0)] 
public unsafe struct UGWFlagWork
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UDataTable* pBattleDataTable;
    [FieldOffset(0x0030)] public UDataTable* pCommuDataTable;
    [FieldOffset(0x0038)] public UDataTable* pEventDataTable;
    [FieldOffset(0x0040)] public UDataTable* pFieldDataTable;
    [FieldOffset(0x0048)] public UDataTable* pProgramDataTable;
    [FieldOffset(0x0050)] public UDataTable* pSystemDataTable;
    [FieldOffset(0x0058)] public UDataTable* pCounterDataTable;
    [FieldOffset(0x0060)] public FGWHashBase BattleDataHashArry;
    [FieldOffset(0x2060)] public FGWHashBase CommuDataHashArry;
    [FieldOffset(0xE060)] public FGWHashBase EventDataHashArry;
    [FieldOffset(0x1A060)] public FGWHashBase FieldDataHashArry;
    [FieldOffset(0x2E060)] public FGWHashBase ProgramDataHashArry;
    [FieldOffset(0x30060)] public FGWHashBase SystemDataHashArry;
    [FieldOffset(0x32060)] public FGWHashBase CounterDataHashArry;
    [FieldOffset(0x33870)] public int BattleDataHashNum;
    [FieldOffset(0x33874)] public int CommuDataHashNum;
    [FieldOffset(0x33878)] public int EventDataHashNum;
    [FieldOffset(0x3387C)] public int FieldDataHashNum;
    [FieldOffset(0x33880)] public int ProgramDataHashNum;
    [FieldOffset(0x33884)] public int SystemDataHashNum;
    [FieldOffset(0x33888)] public int CounterDataHashNum;
    [FieldOffset(0x33890)] public UDataTable* mFldLocalFlagDataTable_;
    [FieldOffset(0x33898)] public FGWHashBase mFldLocalFlagDataHashArry_;
    [FieldOffset(0x34898)] public int mFldLocalFlagDataHashNum_;
    [FieldOffset(0x348A0)] public UDataTable* mFldLocalCounterDataTable_;
    [FieldOffset(0x348A8)] public FGWHashBase mFldLocalCounterDataHashArry_;
    [FieldOffset(0x358A8)] public int mFldLocalCounterDataHashNum_;
    [FieldOffset(0x358B0)] public UDataTable* mFldNpcFlagDataTable_;
    [FieldOffset(0x358B8)] public FGWHashBase mFldNpcFlagDataHashArry_;
    [FieldOffset(0x368B8)] public int mFldNpcFlagDataHashNum_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AHandwritingEffectBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UNiagaraComponent* NiagaraComp;
    [FieldOffset(0x0280)] public UAtomComponent* AtomComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FAtlHandwritingNiagaraRequestAbsoluteFlag
{
    [FieldOffset(0x0000)] public bool bAbsoluteLocation;
    [FieldOffset(0x0001)] public bool bAbsoluteRotation;
    [FieldOffset(0x0002)] public bool bAbsoluteScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAtlHandwritingNiagaraRequestParam
{
    [FieldOffset(0x0000)] public int LoopCount;
    [FieldOffset(0x0004)] public float CameraOffset;
    [FieldOffset(0x0008)] public FVector Location;
    [FieldOffset(0x0014)] public FRotator Rotation;
    [FieldOffset(0x0020)] public FVector Scale;
    [FieldOffset(0x002C)] public FAtlHandwritingNiagaraRequestAbsoluteFlag SpawnedWorldAbsoluteFlag;
    [FieldOffset(0x002F)] public FAtlHandwritingNiagaraRequestAbsoluteFlag SpawnedAttachAbsoluteFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3D8)] 
public unsafe struct AHandwritingSpawner
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TSubclassOf<AHandwritingEffectBase> HandwritingEffectObj;
    [FieldOffset(0x0280)] public EAtlHandwritingGroupType HandwritingGroupType;
    [FieldOffset(0x0281)] public bool bAutoDestroyWhenFinishedHandwriting;
    [FieldOffset(0x0288)] public UAtlHandwritingDataAsset* DataAsset;
    [FieldOffset(0x0290)] public FAtlHandwritingNiagaraRequestParam NiagaraRequestedParam;
    [FieldOffset(0x02C8)] public EHandwritingSpawnRules SpawnRule;
    [FieldOffset(0x02C9)] public EAtlEvtHandwritingType HandwritingType;
    [FieldOffset(0x02CC)] public TWeakObjectPtr<AHandwritingEffectBase> HandwritingEffectBaseActor;
    [FieldOffset(0x02D4)] public TWeakObjectPtr<UNiagaraComponent> HandwritingComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UHandwritingSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public UAtlHandwritingDataAsset* HandwritingDataAsset;
    [FieldOffset(0x0038)] public TMap<EAtlEvtHandwritingType, TSoftClassPtr<AHandwritingEffectBase>> PreloadedHandwritingEffectObjMap;
    [FieldOffset(0x0088)] public TMap<EAtlEvtHandwritingType, TSoftClassPtr<AHandwritingEffectBase>> PreloadedHandwritingEffectObjMap_Field;
    [FieldOffset(0x00D8)] public TMap<EAtlEvtHandwritingType, TSoftClassPtr<AHandwritingEffectBase>> PreloadedHandwritingEffectObjMap_Event;
    [FieldOffset(0x0128)] public TSubclassOf<AHandwritingSpawner> HandwritingSpawnerDefaultClass;
    [FieldOffset(0x0130)] public TArray<TSubclassOf<AHandwritingSpawner>> HandwritingSpawnerClassArray;
    [FieldOffset(0x0140)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHeroParameterHandle
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UHeroParameterDataAsset* pDataAsset;
    [FieldOffset(0x0038)] public UDataTable* pParameterNameTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x350)] 
public unsafe struct AHmModelTestActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UStaticMesh* MeshAry;
    [FieldOffset(0x0270)] public ACameraActor* pMayaCamera;
    [FieldOffset(0x0278)] public AActor* pOldCamera;
    [FieldOffset(0x0290)] public FDarkHourWork Work;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AHT_UMGTestGameModeBase
{
    [FieldOffset(0x0000)] public AGameModeBase baseObj;
    [FieldOffset(0x02C0)] public TSubclassOf<UUserWidget> StartingWidgetClass;
    [FieldOffset(0x02C8)] public UUserWidget* CurrentWidget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x580)] 
public unsafe struct AHT_UMGTestPlayerController
{
    [FieldOffset(0x0000)] public APlayerController baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UHttpBpLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AHumanParameterUpViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x02A8)] public UCmpHeroHumanStatus* pHeroParamSystem_;
    [FieldOffset(0x02B0)] public UCmpHeroHumanStatusDraw* pHumanParamDraw_;
    [FieldOffset(0x02B8)] public UUIScene* pScene;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct UIKAnimInstanceBase
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public float MoveSpeed;
    [FieldOffset(0x02BC)] public bool bUsingFootIK;
    [FieldOffset(0x02BD)] public bool bEnableFootIK;
    [FieldOffset(0x02E0)] public FVector LeftFootOffset;
    [FieldOffset(0x02EC)] public FVector RightFootOffset;
    [FieldOffset(0x02F8)] public float RotationOffsetInterpSpeed;
    [FieldOffset(0x02FC)] public float ZOffsetInterpSpeed;
    [FieldOffset(0x0300)] public float PelvisOffset;
    [FieldOffset(0x0304)] public FVector MinLimitStanding;
    [FieldOffset(0x0310)] public FVector MaxLimitStanding;
    [FieldOffset(0x031C)] public FName LeftFootIKSocketName;
    [FieldOffset(0x0324)] public FName RightFootIKSocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFootIKSetupParam
{
    [FieldOffset(0x0000)] public float TraceDistance;
    [FieldOffset(0x0004)] public float TraceOffset;
    [FieldOffset(0x0008)] public float FootAdjustOffset;
    [FieldOffset(0x000C)] public FName LeftFootSocketName;
    [FieldOffset(0x0014)] public FName RightFootSocketName;
    [FieldOffset(0x001C)] public float VelocityThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x530)] 
public unsafe struct AIKCharacterBase
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public USkeletalMeshComponent* IKMeshComp;
    [FieldOffset(0x04C0)] public UIKAnimInstanceBase* IKAnimInstance;
    [FieldOffset(0x04C8)] public FFootIKSetupParam IKSetupParam;
    [FieldOffset(0x04E8)] public float DefaultCapsuleHalfHeight;
    [FieldOffset(0x04EC)] public float TestLeg;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AIkedaTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* _Actor;
    [FieldOffset(0x0280)] public UDebugMenu* _DebugMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AImanishiTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* Actor_;
    [FieldOffset(0x0280)] public AUICloudCursorDraw* CloudCursor_;
    [FieldOffset(0x0288)] public AAddContentDialog* AdcDialog_;
    [FieldOffset(0x0290)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x0298)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AInitReadActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMsgItemInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMsgItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0068)] public TArray<FMsgItemInfo> MssageList;
    [FieldOffset(0x0078)] public TArray<FMsgItemInfo> SpeakerList;
    [FieldOffset(0x0088)] public UMsgProcWindowBase* mpMsgProcWindow;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMsgAssist
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2840)] 
public unsafe struct AKernelInput
{
    [FieldOffset(0x0000)] public AInputManager baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2948)] 
public unsafe struct AItfController
{
    [FieldOffset(0x0000)] public AKernelInput baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMsgDictionary
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMsgDLC
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UMsgMessage
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMsgMind
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UMsgMindSubtitles
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
    [FieldOffset(0x0100)] public UTexture* pTexture;
    [FieldOffset(0x0108)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMsgManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> ProcList;
    [FieldOffset(0x0050)] public TArray<IntPtr> MsgReleaseList;
    [FieldOffset(0x0070)] public UDataTable* Simple_LayoutData;
    [FieldOffset(0x0078)] public UDataTable* SelectSimple_LayoutData;
    [FieldOffset(0x0080)] public UDataTable* CS_A_LayoutData;
    [FieldOffset(0x0088)] public UUILayoutDataTable* CS_A_LayoutDataTable;
    [FieldOffset(0x0090)] public UDataTable* AssistLayoutDataTextCol;
    [FieldOffset(0x0098)] public UDataTable* AssistLayoutData;
    [FieldOffset(0x00A0)] public UDataTable* BacklogLayoutDataTextCol;
    [FieldOffset(0x00A8)] public UUILayoutDataTable* AssistTextColLayoutDataTable;
    [FieldOffset(0x00B0)] public UUILayoutDataTable* AssistLayoutDataTable;
    [FieldOffset(0x00B8)] public UUILayoutDataTable* BacklogTextColLayoutDataTable;
    [FieldOffset(0x00C0)] public UDataTable* Mind_LayoutData;
    [FieldOffset(0x00C8)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x00D0)] public UAssetLoader* pCSAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMsgProcItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public UMsgItem* pMsgItem;
    [FieldOffset(0x0050)] public USelItem* pSelItem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UMsgProcWindowBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0090)] public UMsgItem* pMsgWork;
    [FieldOffset(0x0098)] public UTutorialManager* pTutorialManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UMsgProcWindow_Assist
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* Loader_;
    [FieldOffset(0x0110)] public USprAsset* MsgSpr_;
    [FieldOffset(0x0118)] public TArray<FVector> SupportPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct UMsgProcWindow_Mind
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* Loader_;
    [FieldOffset(0x0110)] public UMaterial* ReadMat_;
    [FieldOffset(0x0118)] public UMaterial* ReadaddMat_;
    [FieldOffset(0x0120)] public UMaterial* ReadblurMat_;
    [FieldOffset(0x0128)] public UMaterialInstanceDynamic* ReadMatInst_;
    [FieldOffset(0x0130)] public UMaterialInstanceDynamic* ReadaddMatInst_;
    [FieldOffset(0x0138)] public UMaterialInstanceDynamic* ReadblurMatInst_;
    [FieldOffset(0x0140)] public USprAsset* _readSpr;
    [FieldOffset(0x0148)] public UPlgAsset* MsgPlg_;
    [FieldOffset(0x0220)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UMsgProcWindow_Performance
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* m_pPerformanceLoader;
    [FieldOffset(0x0110)] public TSubclassOf<AitfMsgProgWindow_TUTRIALDraw> PerformanceDrawClass;
    [FieldOffset(0x0118)] public AitfMsgProgWindow_TUTRIALDraw* pPerformanceDraw;
    [FieldOffset(0x0120)] public UDataTable* TextColDataTable;
    [FieldOffset(0x0128)] public UUILayoutDataTable* TextColLayoutDataTable;
    [FieldOffset(0x0130)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x0138)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x0140)] public UDataTable* OkNextMaskLayoutData;
    [FieldOffset(0x0148)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UMsgProcWindow_Select
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public USelItem* pSelWork;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct UMsgProcWindow_Select_Mind
{
    [FieldOffset(0x0000)] public UMsgProcWindow_Select baseObj;
    [FieldOffset(0x0128)] public UBustupObject* BustupObject_;
    [FieldOffset(0x0130)] public USprAsset* MsgSpr_;
    [FieldOffset(0x0138)] public UPlgAsset* MsgPlg_;
    [FieldOffset(0x0228)] public UAssetLoader* Loader_;
    [FieldOffset(0x0230)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UMsgProcWindow_Select_Simple
{
    [FieldOffset(0x0000)] public UMsgProcWindow_Select baseObj;
    [FieldOffset(0x0190)] public UBustupObject* BustupObject_;
    [FieldOffset(0x0198)] public USprAsset* MsgSpr_;
    [FieldOffset(0x01A0)] public UPlgAsset* MsgPlg_;
    [FieldOffset(0x01A8)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UMsgProcWindow_Simple
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* Loader_;
    [FieldOffset(0x0110)] public USprAsset* MsgSpr_;
    [FieldOffset(0x0118)] public UPlgAsset* MsgPlg_;
    [FieldOffset(0x01B0)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UMsgProcWindow_System
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* m_pSystemLoader;
    [FieldOffset(0x0110)] public TSubclassOf<AitfMsgProgWindow_TUTRIALDraw> SystemDrawClass;
    [FieldOffset(0x0118)] public AitfMsgProgWindow_TUTRIALDraw* pSystemDraw;
    [FieldOffset(0x0120)] public UDataTable* TextColDataTable;
    [FieldOffset(0x0128)] public UUILayoutDataTable* TextColLayoutDataTable;
    [FieldOffset(0x0130)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x0138)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x0140)] public UDataTable* OkNextMaskLayoutData;
    [FieldOffset(0x0148)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct UMsgProcWindow_Tutorial
{
    [FieldOffset(0x0000)] public UMsgProcWindowBase baseObj;
    [FieldOffset(0x0108)] public UAssetLoader* m_pTutrialLoader;
    [FieldOffset(0x0110)] public TSubclassOf<AitfMsgProgWindow_TUTRIALDraw> TutrialDrawClass;
    [FieldOffset(0x0118)] public AitfMsgProgWindow_TUTRIALDraw* pTutrialDraw;
    [FieldOffset(0x0120)] public UDataTable* TextColDataTable;
    [FieldOffset(0x0128)] public UUILayoutDataTable* TextColLayoutDataTable;
    [FieldOffset(0x0130)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x0138)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x0140)] public UDataTable* OkNextMaskLayoutData;
    [FieldOffset(0x0148)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x528)] 
public unsafe struct AitfMsgProgWindow_TUTRIALDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public float FadeInNonThumbnailMovePosFrame;
    [FieldOffset(0x02BC)] public float FadeInWaitNonThumbnailMovePosFrame;
    [FieldOffset(0x02C0)] public float FadeOutNonThumbnailMovePosFrame;
    [FieldOffset(0x02C4)] public float FadeOutWaitNonThumbnailMovePosFrame;
    [FieldOffset(0x02C8)] public float FadeInNonThumbnailAlphaFrame;
    [FieldOffset(0x02CC)] public float FadeInWaitNonThumbnailAlphaFrame;
    [FieldOffset(0x02D0)] public float FadeOutNonThumbnailAlphaFrame;
    [FieldOffset(0x02D4)] public float FadeOutWaitNonThumbnailAlphaFrame;
    [FieldOffset(0x02D8)] public float FadeInThumbnailMovePosFrame;
    [FieldOffset(0x02DC)] public float FadeInWaitThumbnailMovePosFrame;
    [FieldOffset(0x02E0)] public float FadeOutThumbnailMovePosFrame;
    [FieldOffset(0x02E4)] public float FadeOutWaitThumbnailMovePosFrame;
    [FieldOffset(0x02E8)] public float FadeInThumbnailAlphaFrame;
    [FieldOffset(0x02EC)] public float FadeInWaitThumbnailAlphaFrame;
    [FieldOffset(0x02F0)] public float FadeOutThumbnailAlphaFrame;
    [FieldOffset(0x02F4)] public float FadeOutWaitThumbnailAlphaFrame;
    [FieldOffset(0x02F8)] public float FadeInThumbnailAngleFrame;
    [FieldOffset(0x02FC)] public float FadeInWaitThumbnailAngleFrame;
    [FieldOffset(0x0300)] public float FadeOutThumbnailAngleFrame;
    [FieldOffset(0x0304)] public float FadeOutWaitThumbnailAngleFrame;
    [FieldOffset(0x0308)] public float FixThumbnailAngle;
    [FieldOffset(0x030C)] public float FixThumbnailPosX;
    [FieldOffset(0x0310)] public float FixThumbnailPosY;
    [FieldOffset(0x0314)] public float FixThumbnailPlusAngle;
    [FieldOffset(0x0318)] public float FadeInGroundAlphaFrame;
    [FieldOffset(0x031C)] public float FadeInWaitGroundAlphaFrame;
    [FieldOffset(0x0320)] public float FadeOutGroundAlphaFrame;
    [FieldOffset(0x0324)] public float FadeOutWaitGroundAlphaFrame;
    [FieldOffset(0x0328)] public FColor NavyColor;
    [FieldOffset(0x032C)] public FColor GradationColor;
    [FieldOffset(0x0330)] public FColor UnderShadowColor;
    [FieldOffset(0x0334)] public FColor BackColor;
    [FieldOffset(0x0338)] public float PageOutButtonFrame;
    [FieldOffset(0x033C)] public float PageOutWaitButtonFrame;
    [FieldOffset(0x0340)] public float PageInButtonFrame;
    [FieldOffset(0x0344)] public float PageInWaitButtonFrame;
    [FieldOffset(0x0348)] public float PageOutTextFrame;
    [FieldOffset(0x034C)] public float PageOutWaitTextFrame;
    [FieldOffset(0x0350)] public float PageInTextFrame;
    [FieldOffset(0x0354)] public float PageInWaitTextFrame;
    [FieldOffset(0x0358)] public float PageOutTextAlphaFrame;
    [FieldOffset(0x035C)] public float PageOutWaitTextAlphaFrame;
    [FieldOffset(0x0360)] public float PageInTextAlphaFrame;
    [FieldOffset(0x0364)] public float PageInWaitTextAlphaFrame;
    [FieldOffset(0x0368)] public float PageOutThumbnailFrame;
    [FieldOffset(0x036C)] public float PageOutWaitThumbnailFrame;
    [FieldOffset(0x0370)] public float PageInThumbnailFrame;
    [FieldOffset(0x0374)] public float PageInWaitThumbnailFrame;
    [FieldOffset(0x0378)] public float InWaitThumbnailShadowFrame;
    [FieldOffset(0x037C)] public float InThumbnailShadowFrame;
    [FieldOffset(0x0380)] public int MaskLoopWaitFrameFirst;
    [FieldOffset(0x0384)] public int MaskLoopWaitFrameSecond;
    [FieldOffset(0x0388)] public int MaskLoopWaitFrameThird;
    [FieldOffset(0x038C)] public int MaskLoopMoveFrameFirst;
    [FieldOffset(0x0390)] public int MaskLoopMoveFrameSecond;
    [FieldOffset(0x0394)] public int MaskLoopMoveFrameThird;
    [FieldOffset(0x0398)] public int ButtonScaleWaitFrameFirst;
    [FieldOffset(0x039C)] public int ButtonScaleWaitFrameSecond;
    [FieldOffset(0x03A0)] public int ButtonScaleWaitFrameThird;
    [FieldOffset(0x03A4)] public int ButtonScaleMoveFrameFirst;
    [FieldOffset(0x03A8)] public int ButtonScaleMoveFrameSecond;
    [FieldOffset(0x03AC)] public int ButtonScaleMoveFrameThird;
    [FieldOffset(0x03B0)] public int Edit_Icon_Animation_Start_Delay;
    [FieldOffset(0x03B4)] public int Edit_Icon_Angle_Frame;
    [FieldOffset(0x03B8)] public int Edit_Icon_Angle_Delay;
    [FieldOffset(0x03BC)] public int Edit_Icon_Scale_1Loop_Frame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMsgWork
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public UMsgManager* pMsgManager;
    [FieldOffset(0x0040)] public UTutorialManager* pTutorialManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UMsgPerformance
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USelItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x00A0)] public UMsgProcWindow_Select* mpSelProcWindow;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct USelAEventTypeA
{
    [FieldOffset(0x0000)] public USelItem baseObj;
    [FieldOffset(0x00D8)] public USprAsset* pSprAsset;
    [FieldOffset(0x00E0)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x00E8)] public UDataTable* LayoutData;
    [FieldOffset(0x00F0)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x178)] 
public unsafe struct USelAEventTypeB
{
    [FieldOffset(0x0000)] public USelItem baseObj;
    [FieldOffset(0x0120)] public USprAsset* pSprAsset;
    [FieldOffset(0x0128)] public UTexture* pTexture;
    [FieldOffset(0x0130)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0138)] public UCineCameraComponent* pCineCamera;
    [FieldOffset(0x0140)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0148)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USelFukaSuport
{
    [FieldOffset(0x0000)] public USelItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USelMessage
{
    [FieldOffset(0x0000)] public USelItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct USelMind
{
    [FieldOffset(0x0000)] public USelItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UMsgSubtitles
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMsgSystem
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMsgTutorial
{
    [FieldOffset(0x0000)] public UMsgItem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UTutorialManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0050)] public UBmdAsset* pBmdAsset;
    [FieldOffset(0x0058)] public TArray<IntPtr> Textures;
    [FieldOffset(0x0068)] public TArray<FString> Paths;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UKernelResource
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0040)] public TArray<IntPtr> _Font;
    [FieldOffset(0x0050)] public UFont* _DevelopmentFont;
    [FieldOffset(0x0058)] public TArray<IntPtr> _RenderTarget;
    [FieldOffset(0x0068)] public UAssetLoader* _LoadHandle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBuildModeLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UKernelWidget
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AKernelActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public ACameraActor* _DebugCamera;
    [FieldOffset(0x0238)] public AActor* _OldCamera;
    [FieldOffset(0x0258)] public UKernelWidget* _KernelWidget;
    [FieldOffset(0x0260)] public UDebugMenu* mpDebugMenu;
    [FieldOffset(0x0268)] public AActor* mpChildActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UKernelBpLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UDebugMenu
{
    [FieldOffset(0x0000)] public UDebugMenuBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AKimuraDebugMenu
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UDebugMenu* Menu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AKimuraURO
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public ACharacter* Target;
    [FieldOffset(0x0228)] public TArray<float> Rate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct AkitadeTestEditManager
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct ALaunchActivityActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F8)] 
public unsafe struct ULeaderBoardManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct ULipsyncAppObserverSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0040)] public TMap<uint, FLipsyncAppListener> SpeakCharacterMap;
    [FieldOffset(0x0090)] public ULipsyncAppObserverSpeakWatcher* SpeakWatcher;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct ULipsyncAppObserverSpeakWatcher
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TWeakObjectPtr<ULipsyncAppObserverSubsystem> LipsyncAppObserverSubsystem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ALoaderActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0290)] public UAtomCueSheetLoaderComponent* Loader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct ULoading
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public ALoadingDraw* pLoadingDraw;
    [FieldOffset(0x0038)] public TSubclassOf<ALoadingDraw> LoadingDrawClass;
    [FieldOffset(0x0040)] public UAssetLoader* pAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7C0)] 
public unsafe struct ALoadingDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x0738)] public TArray<FColor> CloudMorningColorList;
    [FieldOffset(0x0748)] public TArray<FColor> CloudEveningColorList;
    [FieldOffset(0x0758)] public TArray<FColor> CloudNightColorList;
    [FieldOffset(0x0768)] public TArray<FColor> CloudShadowTimeColorList;
    [FieldOffset(0x0778)] public float CloudMoveFlameSlow;
    [FieldOffset(0x077C)] public float CloudMoveFlameFast;
    [FieldOffset(0x0780)] public float WhetherToStart;
    [FieldOffset(0x0784)] public float FadeTime;
    [FieldOffset(0x0788)] public float earlyWaitTime;
    [FieldOffset(0x078C)] public FVector2D moonPos;
    [FieldOffset(0x0794)] public FVector2D OriginPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F8)] 
public unsafe struct ALocalizationTest
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public EUI_DRAW_POINT DrawPoint;
    [FieldOffset(0x02BC)] public int LinesNum;
    [FieldOffset(0x02C0)] public FVector Position;
    [FieldOffset(0x02CC)] public FVector Offset;
    [FieldOffset(0x02D8)] public float Angle;
    [FieldOffset(0x02DC)] public float Scale;
    [FieldOffset(0x02E0)] public UDebugMenu* DebugMenu;
    [FieldOffset(0x02E8)] public UAssetLoader* Loader;
    [FieldOffset(0x02F0)] public UDataTable* pDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ATextureData
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UTexture* Texture;
    [FieldOffset(0x0280)] public USprAsset* Sprite;
}

[StructLayout(LayoutKind.Explicit, Size = 0x348)] 
public unsafe struct ALocalizeStaffRoll
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0298)] public UFont* m_StaffRollFont;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct ALocalizeStaffRollDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct AMailActor
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public UAssetLoader* Loader_;
    [FieldOffset(0x02B0)] public TMap<FString, IntPtr> BmdAssets_;
    [FieldOffset(0x0300)] public TMap<FString, IntPtr> BfAssets_;
    [FieldOffset(0x0360)] public AScrActor* ScrActor_;
    [FieldOffset(0x0368)] public TSubclassOf<AMailDraw> MailDrawActorSC;
    [FieldOffset(0x0370)] public AMailDraw* MailDrawActor;
    [FieldOffset(0x03B8)] public UDataTable* LayoutData;
    [FieldOffset(0x03C0)] public UDataTable* textData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FUIMailListItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x380)] 
public unsafe struct AMailDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public bool bIsDirectOpen;
    [FieldOffset(0x02B9)] public bool bIsFlipToMainAnim;
    [FieldOffset(0x02BA)] public bool bIsFlipToListAnim;
    [FieldOffset(0x02BB)] public bool bIsStartInAnim;
    [FieldOffset(0x02BC)] public bool bIsFinishInAnim;
    [FieldOffset(0x02BD)] public bool bIsStartListAnim;
    [FieldOffset(0x02BE)] public bool bIsFinishListAnim;
    [FieldOffset(0x02BF)] public bool bIsStartMailAnim;
    [FieldOffset(0x02C0)] public bool bIsFinishMailAnim;
    [FieldOffset(0x02C1)] public bool bIsStartOutAnim;
    [FieldOffset(0x02C2)] public bool bIsFinishOutAnim;
    [FieldOffset(0x02C3)] public bool bIsShowMsg;
    [FieldOffset(0x02C4)] public bool bIsCloseMsg;
    [FieldOffset(0x02C5)] public bool bIsFinishShowMsgAnim;
    [FieldOffset(0x02C6)] public bool bIsFinishCloseMsgAnim;
    [FieldOffset(0x02C7)] public bool bHaveScript;
    [FieldOffset(0x02C8)] public int SelectedIndex;
    [FieldOffset(0x02CC)] public int DrawIndex;
    [FieldOffset(0x02D0)] public int ScrollIndex;
    [FieldOffset(0x02D4)] public int MailScrollLine;
    [FieldOffset(0x02D8)] public int MailRowCount;
    [FieldOffset(0x02DC)] public int MailRowMax;
    [FieldOffset(0x02E0)] public int MailScrollMax;
    [FieldOffset(0x02E8)] public TArray<FUIMailListItem> MailListItems;
    [FieldOffset(0x02F8)] public UTexture2D* MailMainBustupTexture;
    [FieldOffset(0x0300)] public UAssetLoader* Loader;
    [FieldOffset(0x0358)] public UDataTable* LayoutData;
    [FieldOffset(0x0360)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0368)] public UDataTable* textData;
    [FieldOffset(0x0370)] public UUILayoutDataTable* TextDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AMCATestActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UMcaAsset* m_pMcaCam0;
    [FieldOffset(0x0248)] public ACameraActor* pMayaCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AMiyamuraTestManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AMiyamuraLoadTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UBtlGuiDrawObjectImage* Image;
    [FieldOffset(0x0280)] public UTexture* TextureCup;
    [FieldOffset(0x0288)] public UTexture* TextureCoin;
    [FieldOffset(0x0290)] public UTexture* TextureSword;
    [FieldOffset(0x0298)] public UTexture* TextureWand;
    [FieldOffset(0x02A0)] public UTexture* TexturePersona;
    [FieldOffset(0x02A8)] public UTexture* TextureFool;
    [FieldOffset(0x02B0)] public UTexture* TextureMagician;
    [FieldOffset(0x02B8)] public UTexture* TextureEmpress;
    [FieldOffset(0x02C0)] public UTexture* TextureEmperor;
    [FieldOffset(0x02C8)] public UTexture* TextureHighPrietess;
    [FieldOffset(0x02D0)] public TArray<IntPtr> TextureArray;
    [FieldOffset(0x02E0)] public UAssetLoader* LoaderAlpha;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D0)] 
public unsafe struct ATestCharacter3
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public USkeletalMeshComponent* Mesh2;
    [FieldOffset(0x04C0)] public USkeletalMeshComponent* Mesh3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATestSplineCollision
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USplineComponent* SplineComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct ATestBoxCollision
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBoxComponent* CollisionComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x230)] 
public unsafe struct ATestTriggerBox
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBillboardComponent* Icon;
    [FieldOffset(0x0228)] public UBoxComponent* CollisionComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UTestActorComponent
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct UTestAnimInst
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public FVector LookatPosition2;
    [FieldOffset(0x02C4)] public float LookatAlpha2;
    [FieldOffset(0x02C8)] public int ExpressionTrig;
    [FieldOffset(0x02D0)] public UAnimSequence* AnimSeq0;
    [FieldOffset(0x02D8)] public UAnimSequence* AnimSeq1;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UCollisionActor
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public USphereComponent* mpSphere;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UModelTestComp
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UDebugMenu* mpDebugMenu;
    [FieldOffset(0x00C0)] public TSubclassOf<ACharacter> mCharClass;
    [FieldOffset(0x00D8)] public USprAsset* mpTestSpr;
    [FieldOffset(0x00E0)] public UMaterial* mpTestMaterial;
    [FieldOffset(0x00E8)] public UMaterialInstanceDynamic* mpTestMID;
    [FieldOffset(0x00F0)] public TArray<IntPtr> mMatPushPopArray;
    [FieldOffset(0x0100)] public TArray<IntPtr> mMatArray;
    [FieldOffset(0x0120)] public UAnimController* mpAnimController;
    [FieldOffset(0x0128)] public ACharacter* mpTestSpawnCharacter;
    [FieldOffset(0x0130)] public TArray<IntPtr> mTestAnimSeqArray;
    [FieldOffset(0x0170)] public TArray<IntPtr> mAiCharArray;
    [FieldOffset(0x0180)] public ACineCameraActor* mpCamera;
    [FieldOffset(0x0188)] public USceneCaptureComponent2D* mpSceneCaptureComp;
    [FieldOffset(0x0190)] public UCollisionActor* mpCollisionActor;
    [FieldOffset(0x0198)] public USphereComponent* mpAttachTestSphere;
    [FieldOffset(0x01A8)] public UStaticMeshComponent* mpMeshComp;
    [FieldOffset(0x01B0)] public APointLight* mpLight;
    [FieldOffset(0x01B8)] public UAssetLoader* mpAssetLoader;
    [FieldOffset(0x01D0)] public APostProcessVolume* mpPostProcessVolume;
    [FieldOffset(0x01D8)] public UMaterial* mpCaptureDrawMat;
    [FieldOffset(0x01E0)] public TArray<IntPtr> mTestMatArray;
    [FieldOffset(0x01F0)] public TArray<IntPtr> mTestMidArray;
    [FieldOffset(0x0200)] public USprAsset* mpDrawTestSpr;
    [FieldOffset(0x0210)] public UTestActorComponent* mTestComponent;
    [FieldOffset(0x0218)] public bool InputActivate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AModelTest
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UModelTestComp* mpModelTestComp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMovieCuePointFunction
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UMovieCuePointManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* AssetLoader;
    [FieldOffset(0x0030)] public UBmdAsset* BmdAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct UMoviePanel
{
    [FieldOffset(0x0000)] public UActorComponent baseObj;
    [FieldOffset(0x00B0)] public UMaterialInterface* MovieMaterial;
    [FieldOffset(0x00B8)] public bool bEnable;
    [FieldOffset(0x00BC)] public int OTType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AMoviePlayActorBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public TArray<int> MovieIDList;
    [FieldOffset(0x0288)] public bool enableAutoFlg;
    [FieldOffset(0x0290)] public UAssetLoader* Loader;
    [FieldOffset(0x0298)] public AMoviePlayActorBase* MainActor;
    [FieldOffset(0x02A0)] public TSubclassOf<AMoviePlayActorBase> SubClass;
    [FieldOffset(0x02A8)] public UManaComponent* ManaComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct AMoviePlayActor
{
    [FieldOffset(0x0000)] public AMoviePlayActorBase baseObj;
    [FieldOffset(0x02B0)] public bool IsMaterialMovie;
    [FieldOffset(0x02C0)] public UMovieCuePointManager* CuePointManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AMoviePlayActorBattle
{
    [FieldOffset(0x0000)] public AMoviePlayActorBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AMoviePlayActorEventSequenceTrack
{
    [FieldOffset(0x0000)] public AMoviePlayActorBase baseObj;
    [FieldOffset(0x02C0)] public UMovieCuePointManager* CuePointManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x690)] 
public unsafe struct AMoviePlayTest
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0680)] public AMoviePlayActor* MovieActor;
    [FieldOffset(0x0688)] public AActor* mMovieInhibitActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FEvtAdxSoundFadePayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EEvtAdxSoundFadeType Type;
    [FieldOffset(0x000C)] public int Time;
    [FieldOffset(0x0010)] public float TargetVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtAdxSoundFadeSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtAdxSoundFadePayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtAdxSoundFadeSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtAdxSoundFadeSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEvtConditionalBranchData
{
    [FieldOffset(0x0000)] public EEvtConditionalBranchType ConditionalType;
    [FieldOffset(0x0004)] public int ConditionalNo;
    [FieldOffset(0x0008)] public int ConditionalValue;
    [FieldOffset(0x000C)] public EEvtConditionalBranchCompType CompareType;
    [FieldOffset(0x0010)] public FMovieSceneObjectBindingID EvtManagerBindingID;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UMovieSceneEvtConditionalBranchTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0090)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtAdxSoundFadeTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FEvtAdxSoundManagePayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EEvtSoundManageOperationType EvtAdxSoundManageOperationType;
    [FieldOffset(0x000C)] public int Month;
    [FieldOffset(0x0010)] public int Day;
    [FieldOffset(0x0014)] public ECldTimeZone TimeZone;
    [FieldOffset(0x0018)] public uint ControlId;
    [FieldOffset(0x001C)] public float ControlValue;
    [FieldOffset(0x0020)] public int ControlFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtAdxSoundManageSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtAdxSoundManagePayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtAdxSoundManageSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtAdxSoundManageSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtAdxSoundManageTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEvtAdxSoundPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public int PlayerMajorID;
    [FieldOffset(0x000C)] public int PlayerMinorID;
    [FieldOffset(0x0010)] public int CueId;
    [FieldOffset(0x0014)] public EEvtSoundCategoryType EvtSoundCategoryType;
    [FieldOffset(0x0015)] public EEvtAdxTrackSoundOperationType EvtAdxSoundOperationType;
    [FieldOffset(0x0016)] public bool bStopWhileHighSpeed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtAdxSoundSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtAdxSoundPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtAdxSoundSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtAdxSoundSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtAdxSoundTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FEvtCharaAnimationPayload
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* Animation;
    [FieldOffset(0x0008)] public FName SlotName;
    [FieldOffset(0x0010)] public EEvtCharaAnimationSlotType SlotType;
    [FieldOffset(0x0014)] public float StartOffset;
    [FieldOffset(0x0018)] public float EndOffset;
    [FieldOffset(0x001C)] public float BlendIn;
    [FieldOffset(0x0020)] public float BlendOut;
    [FieldOffset(0x0024)] public float PlayRate;
    [FieldOffset(0x0028)] public EEvtCharaAnimationType CharaAnimationType;
    [FieldOffset(0x0030)] public TArray<FAtlSlotMultiAnimationParam> AnimArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaAnimationSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaAnimationPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneEvtCharaAnimationSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FNameCurve Events;
    [FieldOffset(0x0160)] public FMovieSceneEvtCharaAnimationSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEvtCharaAnimationTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C4)] public EAtlCharaAnimFireEventsAtPosition EventPosition;
    [FieldOffset(0x00C8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FEvtCharaHandwritingPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EEvtCharaHandwritingSpawnOwnerType OwnerType;
    [FieldOffset(0x0009)] public bool bAttached;
    [FieldOffset(0x000A)] public EAtlEvtHandwritingType HandwritingType;
    [FieldOffset(0x000C)] public FVector Location;
    [FieldOffset(0x0018)] public FVector Scale;
    [FieldOffset(0x0028)] public FString BoneName;
    [FieldOffset(0x0038)] public int LoopCount;
    [FieldOffset(0x003C)] public float CameraOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaHandwritingSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaHandwritingPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtCharaHandwritingSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtCharaHandwritingSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtCharaHandwritingTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FEvtCharaOperationControllerPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EEvtCharaOperationType OperationID;
    [FieldOffset(0x0009)] public EEvtCharaOperationFootStepLabelType FootStepLabelType;
    [FieldOffset(0x000C)] public FName FootStepLabelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaOperationControllerSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaOperationControllerPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtCharaOperationControllerSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtCharaOperationControllerSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEvtCharaOperationControllerTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FMovieSceneEvtCharaPackAnimationParams
{
    [FieldOffset(0x0000)] public EEventAnimID EventAnimID;
    [FieldOffset(0x0001)] public ECommonAnimID CommonAnimID;
    [FieldOffset(0x0002)] public EDungeonAnimID DungeonAnimID;
    [FieldOffset(0x0004)] public float StartOffset;
    [FieldOffset(0x0008)] public float EndOffset;
    [FieldOffset(0x000C)] public float BlendIn;
    [FieldOffset(0x0010)] public float BlendOut;
    [FieldOffset(0x0014)] public float PlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEvtCharaPackAnimationPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public ECommonAnimID AnimId;
    [FieldOffset(0x0009)] public EEvtCharaAnimationPackIDType UsingAnimIDType;
    [FieldOffset(0x000A)] public EEventAnimID EventAnimID;
    [FieldOffset(0x000B)] public ECommonAnimID CommonAnimID;
    [FieldOffset(0x000C)] public EDungeonAnimID DungeonAnimID;
    [FieldOffset(0x000D)] public bool bLoop;
    [FieldOffset(0x0010)] public float BlendInTime;
    [FieldOffset(0x0014)] public float BlendOutTime;
    [FieldOffset(0x0018)] public float PlayRate;
    [FieldOffset(0x001C)] public bool bBagSlot;
    [FieldOffset(0x001D)] public EEvtCharaAnimationType MultiAnimCharaAnimationType;
    [FieldOffset(0x0020)] public TArray<FMovieSceneEvtCharaPackAnimationParams> AnimArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaPackAnimationSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaPackAnimationPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtCharaPackAnimationSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtCharaPackAnimationSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtCharaPackAnimationTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEvtCharaPackFaceAnimationPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EAppCharFaceAnimID FaceAnimID;
    [FieldOffset(0x0009)] public bool bLoop;
    [FieldOffset(0x000C)] public float BlendInTime;
    [FieldOffset(0x0010)] public float BlendOutTime;
    [FieldOffset(0x0014)] public float PlayRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaPackFaceAnimationSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaPackFaceAnimationPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneEvtCharaPackFaceAnimationSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FNameCurve Events;
    [FieldOffset(0x0160)] public FMovieSceneEvtCharaPackFaceAnimationSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEvtCharaPackFaceAnimationTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C4)] public EAtlCharaFaceAnimFireEventsAtPosition EventPosition;
    [FieldOffset(0x00C8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FEvtCharaPropAttachPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EAtlEvtPropAttachType PropAttachType;
    [FieldOffset(0x000C)] public FMovieSceneObjectBindingID PropActorBindingID;
    [FieldOffset(0x0024)] public FMovieSceneObjectBindingID PropActorDetachPointBindingID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtCharaPropAttachSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtCharaPropAttachPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtCharaPropAttachSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtCharaPropAttachSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtCharaPropAttachTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEvtDialogueOptionsParameters
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FEvtDialogueOptionsPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public FMovieSceneEvtDialogueOptionsParameters Parameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtDialogueOptionsSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtDialogueOptionsPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneEvtDialogueOptionsSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FNameCurve Events;
    [FieldOffset(0x0160)] public FMovieSceneEvtDialogueOptionsSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneEvtDialogueOptionsTrack
{
    [FieldOffset(0x0000)] public UMovieSceneNameableTrack baseObj;
    [FieldOffset(0x0098)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x0098)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x009C)] public EFireEventsAtPositionggg EventPosition;
    [FieldOffset(0x00A0)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B0)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FEvtDialoguePayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public int MessageNo;
    [FieldOffset(0x000C)] public int MessageMajorID;
    [FieldOffset(0x0010)] public int MessageMinorID;
    [FieldOffset(0x0014)] public int MessageSubID;
    [FieldOffset(0x0018)] public int MessagePageID;
    [FieldOffset(0x0020)] public UBmdAsset* BmdAsset;
    [FieldOffset(0x0028)] public bool bMessageRefAffected;
    [FieldOffset(0x0029)] public bool bPauseSequencer;
    [FieldOffset(0x002C)] public int EventMessageID;
    [FieldOffset(0x0030)] public int SeqEventMessageID;
    [FieldOffset(0x0034)] public bool bWithSelect;
    [FieldOffset(0x0038)] public int SelectID;
    [FieldOffset(0x003C)] public int SelectMessageMajorID;
    [FieldOffset(0x0040)] public int SelectMessageMinorID;
    [FieldOffset(0x0044)] public int SelectMessageSubID;
    [FieldOffset(0x0048)] public int SelectResponceToLocalDataID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtDialogueSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtDialoguePayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct UMovieSceneEvtDialogueSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtDialogueSectionData EventData;
    [FieldOffset(0x0170)] public FNameCurve Events;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtDialogueTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEvtFadeScreenPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public EEvtFadeScreenType FadeScreenType;
    [FieldOffset(0x000C)] public int FadeType;
    [FieldOffset(0x0010)] public int FadeFrame;
    [FieldOffset(0x0014)] public byte ColorR;
    [FieldOffset(0x0015)] public byte ColorG;
    [FieldOffset(0x0016)] public byte ColorB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtFadeScreenSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtFadeScreenPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtFadeScreenSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtFadeScreenSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtFadeScreenTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEvtFieldAnimationPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public int AnimId;
    [FieldOffset(0x000C)] public bool bLoop;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtFieldAnimationSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtFieldAnimationPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtFieldAnimationSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtFieldAnimationSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtFieldAnimationTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FEvtMessageSubtitlePayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public bool bUseMessage;
    [FieldOffset(0x000C)] public int MessageMajorID;
    [FieldOffset(0x0010)] public int MessageMinorID;
    [FieldOffset(0x0014)] public int MessageSubID;
    [FieldOffset(0x0018)] public int MessagePageID;
    [FieldOffset(0x0020)] public UBmdAsset* BmdAsset;
    [FieldOffset(0x0028)] public bool bMessageRefAffected;
    [FieldOffset(0x002C)] public int DrawFrame;
    [FieldOffset(0x0030)] public bool bPauseSequencer;
    [FieldOffset(0x0031)] public bool bWithSelect;
    [FieldOffset(0x0034)] public int SelectID;
    [FieldOffset(0x0038)] public int SelectMessageMajorID;
    [FieldOffset(0x003C)] public int SelectMessageMinorID;
    [FieldOffset(0x0040)] public int SelectMessageSubID;
    [FieldOffset(0x0044)] public int SelectResponceToLocalDataID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtMessageSubtitleSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtMessageSubtitlePayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtMessageSubtitleSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtMessageSubtitleSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtMessageSubtitleTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FEvtMoviePayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public int ID;
    [FieldOffset(0x000C)] public EEvtMovieOperation Operation;
    [FieldOffset(0x0010)] public int SeekFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtMovieSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtMoviePayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtMovieSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtMovieSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtMovieTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FEvtScriptPayload
{
    [FieldOffset(0x0000)] public FName EventName;
    [FieldOffset(0x0008)] public int ProcNo;
    [FieldOffset(0x0010)] public UBfAsset* BfAsset;
    [FieldOffset(0x0018)] public bool bPauseSequencer;
    [FieldOffset(0x0019)] public bool bUseBmdAssetInBfAsset;
    [FieldOffset(0x0020)] public UBmdAsset* BmdAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtScriptSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtScriptPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtScriptSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtScriptSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UMovieSceneEvtScriptTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FEvtSeqControllerPayload
{
    [FieldOffset(0x0000)] public EEvtSeqControllerOperation Operation;
    [FieldOffset(0x0004)] public int ClosedEventMessageID;
    [FieldOffset(0x0008)] public float JumpToSec;
    [FieldOffset(0x000C)] public float CameraBlendTime;
    [FieldOffset(0x0010)] public int NextTransitionLightScenarioIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtSeqControllerSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtSeqControllerPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtSeqControllerSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtSeqControllerSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEvtSeqControllerTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FEvtSeqTimeJumpControllerPayload
{
    [FieldOffset(0x0000)] public EEvtSeqTimeJumpControllerOperation Operation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FMovieSceneEvtSeqTimeJumpControllerSectionData
{
    [FieldOffset(0x0000)] public FMovieSceneChannel baseObj;
    [FieldOffset(0x0008)] public TArray<FFrameNumber> Times;
    [FieldOffset(0x0018)] public TArray<FEvtSeqTimeJumpControllerPayload> KeyValues;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMovieSceneEvtSeqTimeJumpControllerSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00E8)] public FMovieSceneEvtSeqTimeJumpControllerSectionData EventData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UMovieSceneEvtSeqTimeJumpControllerTrack
{
    [FieldOffset(0x0000)] public UMovieSceneEvtConditionalBranchTrack baseObj;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00C0)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00C8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00D8)] public TArray<IntPtr> Sections;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AMsgTest
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBmdAsset* mpBmdAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AMyActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UMyBlueprintFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UNiagaraCameraAttachComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x01F8)] public TSoftObjectPtr<UNiagaraSystem> NiagaraSystem;
    [FieldOffset(0x0220)] public FVector SpawnLocation;
    [FieldOffset(0x022C)] public bool bAutoDestroy;
    [FieldOffset(0x022D)] public bool bAsyncSystemLoad;
    [FieldOffset(0x0230)] public UNiagaraSystem* SpawnNiagaraSystem;
    [FieldOffset(0x0238)] public bool bIsAutoAttachCam;
    [FieldOffset(0x0239)] public bool bIsAutPlay;
    [FieldOffset(0x0240)] public UNiagaraComponent* ParticleComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct ANishidaTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* Actor_;
    [FieldOffset(0x0280)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ANowatariTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* Actor_;
    [FieldOffset(0x0280)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x0288)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AOdagakiTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* _Actor;
    [FieldOffset(0x0280)] public UDebugMenu* _DebugMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AOkadaTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* Actor_;
    [FieldOffset(0x0280)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AOtHUD
{
    [FieldOffset(0x0000)] public AHUD baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UPadRumble
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UForceFeedbackEffect* haveRumble;
    [FieldOffset(0x0030)] public UForceFeedbackEffect* haveRumble2;
    [FieldOffset(0x0038)] public UForceFeedbackEffect* ProgramEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct APadRumbleSequencer
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCurveLinearColorAnimation
{
    [FieldOffset(0x0000)] public FBaseCurveAnimation baseObj;
    [FieldOffset(0x0028)] public UCurveLinearColor* m_pCurveLinearColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1200)] 
public unsafe struct UPartyPanelRecoveryEffect
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public USprAsset* m_pSpr;
    [FieldOffset(0x0030)] public FCurveLinearColorAnimation m_curveRecoveryEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct UPauseUserWidget
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
    [FieldOffset(0x0260)] public bool bTickEvenWhenPaused;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct APerformanceViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct APersonaStatusTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public APersonaStatus* Actor_;
    [FieldOffset(0x0288)] public UUICombineCalc* CombineCalc_;
    [FieldOffset(0x0290)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FPersonaStatusListItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F8)] 
public unsafe struct APersonaStatusViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x02E0)] public TArray<FPersonaStatusListItem> StatusList;
    [FieldOffset(0x02F0)] public APersonaStatus* pPersonaStatus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UPlatformFunctionLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct APreloadVolume
{
    [FieldOffset(0x0000)] public ATriggerVolume baseObj;
    [FieldOffset(0x0258)] public TArray<FSoftObjectPath> PreloadAssets;
    [FieldOffset(0x0278)] public TArray<IntPtr> loadedAssets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UQuestDisappearList
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0068)] public AUICmpQuest* Context_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UQuestElizMessage
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UQuestElizRequest
{
    [FieldOffset(0x0000)] public UUIScene baseObj;
    [FieldOffset(0x0080)] public AUICmpQuest* Context_;
    [FieldOffset(0x0088)] public UQuestElizMessage* ElizMessage_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x320)] 
public unsafe struct ARankUpTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0310)] public AAppActor* Actor;
    [FieldOffset(0x0318)] public UDebugMenu* DebugMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct ARightsNotation
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02A8)] public TSubclassOf<ARightsNotationDraw> pLoadDrawClass;
    [FieldOffset(0x02B0)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x02B8)] public ARightsNotationDraw* pDrawClass;
    [FieldOffset(0x02C0)] public UTexture* pCaptureTex;
    [FieldOffset(0x02C8)] public UFrameBufferCapture* pCaptureBackGround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E0)] 
public unsafe struct ARightsNotationDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public FColor BlackBoardColor;
    [FieldOffset(0x02BC)] public FColor GladationBoardColor;
    [FieldOffset(0x02C0)] public FColor BlueBoardColor;
    [FieldOffset(0x02C4)] public FColor BlackBoardCoverColor;
    [FieldOffset(0x02C8)] public TArray<float> BlackBoardMoveSpeed;
    [FieldOffset(0x02D8)] public TArray<float> BlueBoardMoveSpeed;
    [FieldOffset(0x02E8)] public TArray<float> BlueBoardRollSpeed;
    [FieldOffset(0x02F8)] public TArray<float> MainTextMoveSpeed;
    [FieldOffset(0x0308)] public TArray<float> ScrollBarMoveSpeed;
    [FieldOffset(0x0318)] public TArray<float> BlackBoardAlphaSpeed;
    [FieldOffset(0x0328)] public TArray<float> BlueBoardAlphaSpeed;
    [FieldOffset(0x0338)] public TArray<float> GradationAlphaSpeed;
    [FieldOffset(0x0348)] public TArray<float> MainTextAlphaSpeed;
    [FieldOffset(0x0358)] public TArray<float> ScrollBarAlphaSpeed;
    [FieldOffset(0x0368)] public float FadeOutAnimFinishTime;
    [FieldOffset(0x03B0)] public UTexture* pCaptureTex;
    [FieldOffset(0x03B8)] public UFrameBufferCapture* pCaptureBackGround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct AsainoTestEditManager
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ANetworkWindowTest
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x0290)] public AUISystemMsgActor* pDialog;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FSaveSlotItem
{
    [FieldOffset(0x0000)] public int SlotNo;
    [FieldOffset(0x0004)] public int Month;
    [FieldOffset(0x0008)] public int Day;
    [FieldOffset(0x000C)] public int PLV;
    [FieldOffset(0x0010)] public int Week;
    [FieldOffset(0x0014)] public bool bHoliday;
    [FieldOffset(0x0018)] public int PTimeHour;
    [FieldOffset(0x001C)] public int PTimeMin;
    [FieldOffset(0x0020)] public int Diff;
    [FieldOffset(0x0024)] public int MoonAge;
    [FieldOffset(0x0028)] public int TimeZone;
    [FieldOffset(0x0030)] public FString PlayerName;
    [FieldOffset(0x0040)] public FString LocationName;
    [FieldOffset(0x0050)] public bool bIsGoodEnd;
    [FieldOffset(0x0051)] public bool bIsBadEnd;
    [FieldOffset(0x0052)] public bool bIsLoaded;
    [FieldOffset(0x0053)] public bool bHasData;
    [FieldOffset(0x0054)] public bool bUseDefaultHeroName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x338)] 
public unsafe struct ASaveLoadDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02EC)] public int BootMode;
    [FieldOffset(0x02F0)] public bool bIsStartInAnim;
    [FieldOffset(0x02F1)] public bool bIsUseCapture;
    [FieldOffset(0x02F2)] public bool bIsOpenCamp;
    [FieldOffset(0x02F3)] public bool bIsUseScrollBar;
    [FieldOffset(0x02F4)] public bool bIsStartCloseAnim;
    [FieldOffset(0x02F8)] public int CursorIndex;
    [FieldOffset(0x02FC)] public int ListTopIndex;
    [FieldOffset(0x0300)] public int CurrentIndex;
    [FieldOffset(0x0308)] public TArray<FSaveSlotItem> SaveSlotItems;
    [FieldOffset(0x0318)] public ESaveDrawOpenType OpenType;
    [FieldOffset(0x031C)] public int AllSlotNum;
    [FieldOffset(0x0320)] public int CheckOverListIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AScrActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UBfAsset* mpBfAsset;
    [FieldOffset(0x0228)] public UBmdAsset* mpBmdAsset;
    [FieldOffset(0x0270)] public UAssetLoader* mpAssetLoader;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USeqBpFuncLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct USequence
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UShdParameter
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct USignedInDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UErrorDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UMessageDialog
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x690)] 
public unsafe struct ASimpleShopDraw
{
    [FieldOffset(0x0000)] public AFclShopBase baseObj;
    [FieldOffset(0x03E8)] public USprAsset* SprData;
    [FieldOffset(0x03F0)] public USprAsset* m_pSpr_Common;
    [FieldOffset(0x03F8)] public TArray<IntPtr> m_ShimpleShop;
    [FieldOffset(0x0408)] public USprAsset* m_pSpr_ShimpleShop;
    [FieldOffset(0x0410)] public UPlgAsset* m_pPlg_ShimpleShop;
    [FieldOffset(0x0418)] public TArray<int> SaveItemNum;
    [FieldOffset(0x0450)] public TSubclassOf<ASimpleShopDraw> ShimpleShopDrawClass;
    [FieldOffset(0x0458)] public UAssetLoader* pLoader;
    [FieldOffset(0x0460)] public UItemShopLineUpListTable* LineupTable_;
    [FieldOffset(0x0660)] public UTexture* tex;
    [FieldOffset(0x0668)] public UFrameBufferCapture* captureBackGround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USoundApp
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct USoundDataAssets
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0030)] public UDataAsset* pDlcBgm;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ASoundMonitoring
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct USoundMonitorReadyAsyncFunction
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct USoundMonitorACBReadAsyncFunction
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ASoundPlayerActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USoundTableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDatDlcBgmTableData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint BandleID;
    [FieldOffset(0x000C)] public uint SerialNumber;
    [FieldOffset(0x0010)] public FName Title;
    [FieldOffset(0x0018)] public uint Offset;
    [FieldOffset(0x001C)] public uint ControlNumber;
    [FieldOffset(0x0020)] public uint Sort;
    [FieldOffset(0x0024)] public int Result;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDatDlcBgmTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDatDlcBgmTableData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UsoundTestGameInstance
{
    [FieldOffset(0x0000)] public UGameInstance baseObj;
    [FieldOffset(0x01A8)] public UPlayAdxControl* m_PlayAdxControl;
}

[StructLayout(LayoutKind.Explicit, Size = 0x338)] 
public unsafe struct AStaffRoll
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02D8)] public UAssetLoader* m_pStaffRollDrawLoader;
    [FieldOffset(0x02E0)] public TSubclassOf<AStaffRollDraw> StaffRollDrawClass;
    [FieldOffset(0x02E8)] public AStaffRollDraw* pStaffRollDraw;
    [FieldOffset(0x02F0)] public UStaffRollDataAsset* pStaffRollDataList;
    [FieldOffset(0x02F8)] public AMoviePlayActor* pStaffRollMovie;
    [FieldOffset(0x0300)] public UFont* pStaffRollFont;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FStaffRollTableData
{
    [FieldOffset(0x0000)] public int StaffRollIndex;
    [FieldOffset(0x0008)] public FString FirstColumnName;
    [FieldOffset(0x0018)] public FString SecondColumnName;
    [FieldOffset(0x0028)] public FString ThirdColumnName;
    [FieldOffset(0x0038)] public FString ForthColumnName;
    [FieldOffset(0x0048)] public FColor Ficolor;
    [FieldOffset(0x004C)] public FColor Scolor;
    [FieldOffset(0x0050)] public FColor Tcolor;
    [FieldOffset(0x0054)] public FColor Focolor;
    [FieldOffset(0x0058)] public byte Fistyle;
    [FieldOffset(0x0059)] public byte Sstyle;
    [FieldOffset(0x005A)] public byte Tstyle;
    [FieldOffset(0x005B)] public byte Fostyle;
    [FieldOffset(0x005C)] public byte Fisize;
    [FieldOffset(0x005D)] public byte Ssize;
    [FieldOffset(0x005E)] public byte Tsize;
    [FieldOffset(0x005F)] public byte Fosize;
    [FieldOffset(0x0060)] public byte Command;
    [FieldOffset(0x0061)] public byte SecondCommand;
    [FieldOffset(0x0062)] public byte ThirdCommand;
    [FieldOffset(0x0063)] public byte ForthCommand;
    [FieldOffset(0x0064)] public int LineCount;
    [FieldOffset(0x0068)] public bool LineCommand;
    [FieldOffset(0x006C)] public int EmptyCount;
    [FieldOffset(0x0070)] public float StartWaitSeconds;
    [FieldOffset(0x0074)] public float FinishSeconds;
    [FieldOffset(0x0078)] public float LastSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UStaffRollDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FStaffRollTableData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct AStaffRollDebugViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x0290)] public UBfAsset* mpBfAsset;
    [FieldOffset(0x0298)] public UAssetLoader* Loader_;
    [FieldOffset(0x02A0)] public AScrActor* mpActor;
    [FieldOffset(0x02B0)] public bool isBFAsset;
    [FieldOffset(0x02B1)] public bool bStartScript;
    [FieldOffset(0x02D0)] public AStaffRoll* pStaffRollSys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A720)] 
public unsafe struct AStaffRollDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02C8)] public float PictOutWaitFrame;
    [FieldOffset(0x02CC)] public float PictOutMoveFrame;
    [FieldOffset(0x02D0)] public float PictInWaitFrame;
    [FieldOffset(0x02D4)] public float PictInMoveFrame;
    [FieldOffset(0x02D8)] public float SceneAnimOutWaitFrame;
    [FieldOffset(0x02DC)] public float SceneAnimOutMoveFrame;
    [FieldOffset(0x02E0)] public float SceneAnimInWaitFrame;
    [FieldOffset(0x02E4)] public float SceneAnimInMoveFrame;
    [FieldOffset(0x02E8)] public float SoundSwitchWaitSec;
    [FieldOffset(0x02EC)] public int SoundFadeFrame;
    [FieldOffset(0x02F0)] public UStaffRollDataAsset* DataList;
    [FieldOffset(0x02F8)] public USprAsset* SprData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USteamInputLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ASuzukiDrawTest
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0280)] public TSubclassOf<ASuzukiDrawTestDraw> SuzukiDrawTestDrawClass;
    [FieldOffset(0x0288)] public ASuzukiDrawTestDraw* pSuzukiDrawTestDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x328)] 
public unsafe struct ASuzukiDrawTestDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public UMaterialInstance* pMaterial;
    [FieldOffset(0x02C0)] public UMaterialInstanceDynamic* pParamMateDynamic;
    [FieldOffset(0x02C8)] public UPlgAsset* pPlgAsset;
    [FieldOffset(0x02D0)] public UMaterial* pCaptureMaterial;
    [FieldOffset(0x02D8)] public UMaterialInstanceDynamic* pBackgroundMaterial;
    [FieldOffset(0x02E0)] public UTexture* pCaptureTexture;
    [FieldOffset(0x02E8)] public UTexture* pModelCaptureTex;
    [FieldOffset(0x02F0)] public APreviewWorldUpdater* PWorldUpdater_;
    [FieldOffset(0x02F8)] public int State;
    [FieldOffset(0x0300)] public UFrameBufferCapture* captureBackGround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AsuzukiTestMenu
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* Actor_;
    [FieldOffset(0x0280)] public UDebugMenu* DebugMenu_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ASystemViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct ATaskActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x32C0)] 
public unsafe struct UTCSSaveData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTestIguchiFuncLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct ATestMultiDraw
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UTexture* baseTex;
    [FieldOffset(0x0228)] public UTexture* baseMultiBaseTex;
    [FieldOffset(0x0230)] public UTexture* baseMultiTex;
    [FieldOffset(0x0238)] public UTexture* maskTex;
    [FieldOffset(0x0240)] public USprAsset* mpMultiplyTestSpr;
    [FieldOffset(0x0248)] public UMaterial* MAT;
    [FieldOffset(0x0250)] public UMaterial* mat2;
    [FieldOffset(0x0258)] public TArray<IntPtr> mTestMID2D;
    [FieldOffset(0x0268)] public UMaterialInstanceConstant* mTestMIC2D;
    [FieldOffset(0x0270)] public UTexture* bustupEye_00;
    [FieldOffset(0x0278)] public UTexture* bustupEye_01;
    [FieldOffset(0x0280)] public UTexture* bustupMouth_00;
    [FieldOffset(0x0288)] public UTexture* bustupMouth_01;
    [FieldOffset(0x0290)] public UTexture* bustupSdw_00;
    [FieldOffset(0x0298)] public UTexture* bustupSdw_01;
    [FieldOffset(0x02A0)] public UTexture* bustupEye_mask;
    [FieldOffset(0x02A8)] public UTexture* bustupMouth_mask;
    [FieldOffset(0x02C8)] public UMaterialInstanceDynamic* DrawableMaterial;
    [FieldOffset(0x02D0)] public UTexture* bustupBase;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct ATestNishidaGameMode
{
    [FieldOffset(0x0000)] public AGameModeBase baseObj;
    [FieldOffset(0x02C0)] public TSubclassOf<UTestNishidaResource> m_pTestNishidaResource;
    [FieldOffset(0x02C8)] public TSubclassOf<ATestNishidaResourceActor> m_pTestNishidaResourceActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UTestNishidaResource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UTexture* m_pTexture;
    [FieldOffset(0x0030)] public TSoftObjectPtr<UTexture> m_pSoftTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct ATestNishidaResourceActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UTexture* _HardReferenceTexture;
    [FieldOffset(0x0228)] public TSoftObjectPtr<UTexture> _SoftReferenceTexture;
    [FieldOffset(0x0250)] public UTexture* _texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTestPauseSoundClass
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct ATestSaveGameActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UDebugMenu* mpTestSaveGameDebugMenu;
}

[StructLayout(LayoutKind.Explicit, Size = 0x298)] 
public unsafe struct ATestSprAppActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public USprAsset* mpTestSpr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ATheurgiaActor
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct ATheurgiaDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6A8)] 
public unsafe struct ATitleActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UTitleStateBase* CurrentTitleState;
    [FieldOffset(0x0288)] public TMap<ETitleState, IntPtr> TitleStates;
    [FieldOffset(0x02D8)] public AActor* DefaultCamera;
    [FieldOffset(0x02E0)] public AActor* TitleCamera;
    [FieldOffset(0x02E8)] public UUIDrawGamerTag* m_GamerTagWidget;
    [FieldOffset(0x02F0)] public TSubclassOf<UUserWidget> m_GamerTagWidgetClass;
    [FieldOffset(0x0340)] public UAssetLoader* TitleAssetLoader;
    [FieldOffset(0x0348)] public UDataTable* TitleDataTable;
    [FieldOffset(0x0350)] public UDataTable* TitleSelectDataTable;
    [FieldOffset(0x0360)] public ATitleLogoActor* LogoActor;
    [FieldOffset(0x0368)] public TSubclassOf<ATitleLogoActor> LogoActorSC;
    [FieldOffset(0x0370)] public FCurveVectorAnimation CurvePressAnyButtonBlueRect;
    [FieldOffset(0x03A0)] public FCurveVectorAnimation CurvePressAnyButtonAnim;
    [FieldOffset(0x03D0)] public UDataTable* LayoutDataTable;
    [FieldOffset(0x03D8)] public UUILayoutDataTable* UILayoutLayoutDataTable;
    [FieldOffset(0x03E0)] public USprAsset* TitleSpr;
    [FieldOffset(0x03E8)] public UTexture* CautionTex;
    [FieldOffset(0x03F0)] public UTexture* PhotosensitiveCautionTex;
    [FieldOffset(0x0590)] public UMcaAsset* McaCameraAsset;
    [FieldOffset(0x0598)] public ACameraActor* MainCamera;
    [FieldOffset(0x05A0)] public AActor* OldCamera;
    [FieldOffset(0x05D8)] public UMaterial* PressAnyButtonMat;
    [FieldOffset(0x05E0)] public UMaterialInstanceDynamic* PressAnyButtonMID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x290)] 
public unsafe struct ATitleLogoActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public int FadeInFrame;
    [FieldOffset(0x0224)] public int FadeOutFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTitleStateBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public ATitleActor* TitleActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UTitleStateCaution
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UTitleStateComeBackLoad
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UTitleStateConfig
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTitleStateDebugScript
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UTitleStateExit
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UTitleStateLoadGame
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
    [FieldOffset(0x0038)] public AUISaveLoad* SaveLoadUI;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UTitleStateLogo
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
    [FieldOffset(0x00D0)] public UAssetLoader* AssetLoader;
    [FieldOffset(0x00D8)] public UMaterial* AtlusLogoMat;
    [FieldOffset(0x00E0)] public UMaterialInstanceDynamic* AtlusLogoMID;
    [FieldOffset(0x00E8)] public UMaterial* P_StudioLogoMat;
    [FieldOffset(0x00F0)] public UMaterialInstanceDynamic* P_StudioLogoMID;
    [FieldOffset(0x00F8)] public UMaterial* UE4AndCRILogoMat;
    [FieldOffset(0x0100)] public UMaterialInstanceDynamic* UE4AndCRILogoMID;
    [FieldOffset(0x0108)] public FCurveVectorAnimation CurveAtlusLogoAnimation;
    [FieldOffset(0x0138)] public FCurveLinearColorAnimation CurveAtlusLogoColorAnimation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UTitleStateNetworkCheck
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
    [FieldOffset(0x0048)] public AUISystemMsgActor* NetWaitDialog;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UTitleStateNewGame
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
    [FieldOffset(0x0038)] public UAddContent* AddContentCheck;
    [FieldOffset(0x0040)] public UAssetLoader* Loader;
    [FieldOffset(0x0048)] public ADifficultySelectionActor* DifficultySelection;
    [FieldOffset(0x0050)] public TSubclassOf<ADifficultySelectionActor> DifficultySelectionSC;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UTitleStateOP
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
    [FieldOffset(0x0038)] public AMoviePlayActor* MovieActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UTitleStatePhotosensitiveCaution
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UTitleStatePressWait
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UTitleStateSelect
{
    [FieldOffset(0x0000)] public UTitleStateBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UTrophyManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FTutorialTableData
{
    [FieldOffset(0x0000)] public int TutorialID;
    [FieldOffset(0x0004)] public int SortID;
    [FieldOffset(0x0008)] public int OpenFlagID;
    [FieldOffset(0x0010)] public FString Title;
    [FieldOffset(0x0020)] public TArray<FName> TextureNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTutorialTables
{
    [FieldOffset(0x0000)] public TArray<FTutorialTableData> Datas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTutorialTableDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTutorialTables> Table;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ATutorialViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCurveFloatAnimation
{
    [FieldOffset(0x0000)] public FBaseCurveAnimation baseObj;
    [FieldOffset(0x0028)] public UCurveFloat* m_pCurveFloat;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1060)] 
public unsafe struct AUIAccessInfoDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02F0)] public USprAsset* m_pMiniMapSpr;
    [FieldOffset(0x02F8)] public USprAsset* m_pPlaceSpr;
    [FieldOffset(0x0300)] public UUIMiniMapDraw* m_pMiniMap;
    [FieldOffset(0x0308)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0310)] public AScrActor* m_pScrActor;
    [FieldOffset(0x0318)] public UBfAsset* m_pBfAsset;
    [FieldOffset(0x0320)] public UBmdAsset* m_pBmdAsset;
    [FieldOffset(0x0328)] public UUILocationSelect* m_pLocationSelect;
    [FieldOffset(0x0330)] public UPlgAsset* m_pPlacePlg;
    [FieldOffset(0x0E00)] public FGetUIParameter m_tagUip;
    [FieldOffset(0x0E78)] public FCurveFloatAnimation m_tagFadeInCurve;
    [FieldOffset(0x0EA8)] public FCurveFloatAnimation m_tagFadeOutCurve;
    [FieldOffset(0x0F30)] public UDataTable* LayoutData;
    [FieldOffset(0x0F38)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0F40)] public UDataTable* LayoutParamData;
    [FieldOffset(0x0F48)] public UDataTable* PlaceNameLayoutData;
    [FieldOffset(0x0F50)] public UUILayoutDataTable* PlaceNameLayoutDataTable;
    [FieldOffset(0x0F58)] public UDataTable* MapNameLayoutData;
    [FieldOffset(0x0F60)] public UUILayoutDataTable* MapNameLayoutDataTable;
    [FieldOffset(0x0F68)] public UDataTable* IwatodaiFloorNoLayoutData;
    [FieldOffset(0x0F70)] public UUILayoutDataTable* IwatodaiFloorNoLayoutDataTable;
    [FieldOffset(0x0F78)] public UDataTable* MallFloorNoLayoutData;
    [FieldOffset(0x0F80)] public UUILayoutDataTable* MallFloorNoLayoutDataTable;
    [FieldOffset(0x0F88)] public UDataTable* SchoolFloorNoLayoutData;
    [FieldOffset(0x0F90)] public UUILayoutDataTable* SchoolFloorNoLayoutDataTable;
    [FieldOffset(0x0F98)] public UDataTable* DormitoryFloorNoLayoutData;
    [FieldOffset(0x0FA0)] public UUILayoutDataTable* DormitoryFloorNoLayoutDataTable;
    [FieldOffset(0x0FA8)] public UDataTable* RyokanFloorNoLayoutData;
    [FieldOffset(0x0FB0)] public UUILayoutDataTable* RyokanFloorNoLayoutDataTable;
    [FieldOffset(0x0FB8)] public UDataTable* HotelFloorNoLayoutData;
    [FieldOffset(0x0FC0)] public UUILayoutDataTable* HotelFloorNoLayoutDataTable;
    [FieldOffset(0x0FC8)] public UDataTable* ThebelFloorNoLayoutData;
    [FieldOffset(0x0FD0)] public UUILayoutDataTable* ThebelFloorNoLayoutDataTable;
    [FieldOffset(0x0FD8)] public UDataTable* ArqaFloorNoLayoutData;
    [FieldOffset(0x0FE0)] public UUILayoutDataTable* ArqaFloorNoLayoutDataTable;
    [FieldOffset(0x0FE8)] public UDataTable* YabbashahFloorNoLayoutData;
    [FieldOffset(0x0FF0)] public UUILayoutDataTable* YabbashahFloorNoLayoutDataTable;
    [FieldOffset(0x0FF8)] public UDataTable* TziahFloorNoLayoutData;
    [FieldOffset(0x1000)] public UUILayoutDataTable* TziahFloorNoLayoutDataTable;
    [FieldOffset(0x1008)] public UDataTable* HarabahFloorNoLayoutData;
    [FieldOffset(0x1010)] public UUILayoutDataTable* HarabahFloorNoLayoutDataTable;
    [FieldOffset(0x1018)] public UDataTable* AdamahFloorNoLayoutData;
    [FieldOffset(0x1020)] public UUILayoutDataTable* AdamahFloorNoLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7B0)] 
public unsafe struct AUIActionSuggestionDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02D0)] public UDataTable* m_pTextColDataTable;
    [FieldOffset(0x02D8)] public UUILayoutDataTable* m_pTextColLayoutDataTable;
    [FieldOffset(0x02E0)] public USprAsset* m_pGuidanceSpr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E0)] 
public unsafe struct AUIArcanaCardCapture
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public UTexture* pModelCaptureTex;
    [FieldOffset(0x02C0)] public AAppPropsCardContainer* CardContainer;
    [FieldOffset(0x02C8)] public AAppPropsCore* CardBp;
    [FieldOffset(0x0338)] public UAnimSequenceBase* AnimSequence;
    [FieldOffset(0x03A8)] public AUISceneCapture* pUISceneCapture2D;
    [FieldOffset(0x03B0)] public TSubclassOf<AUISceneCapture> UISceneCaptureClass;
    [FieldOffset(0x03B8)] public AUICmmRankUPAnimManager* AnimManager;
    [FieldOffset(0x03C0)] public UNiagaraSystem* CardEffect;
    [FieldOffset(0x03C8)] public UNiagaraComponent* EffectComponent;
    [FieldOffset(0x03D0)] public USkeletalMeshComponent* SkeltalComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAssistSpriteItem
{
    [FieldOffset(0x0018)] public UBustupObject* BustupObject;
    [FieldOffset(0x0020)] public USprAsset* Sprite;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct UUIAssist
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UBmdAsset* MessageData_;
    [FieldOffset(0x0058)] public FAssistSpriteItem Sprites_;
    [FieldOffset(0x0218)] public UAssetLoader* Loader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct AUIBackLog
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02C0)] public TSubclassOf<AUIBackLogDraw> BackLoadDrawClass;
    [FieldOffset(0x02C8)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x02D0)] public AUIBackLogDraw* pBackLoadDraw;
    [FieldOffset(0x02E0)] public UTexture* tex;
    [FieldOffset(0x02E8)] public UFrameBufferCapture* captureBackGround;
    [FieldOffset(0x0300)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0308)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA60)] 
public unsafe struct AUIBackLogDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public float CursorMoveSpeed;
    [FieldOffset(0x02C0)] public TArray<float> CursorPosFix;
    [FieldOffset(0x02D0)] public float IconWaveMoveSpeed;
    [FieldOffset(0x02D8)] public TArray<int> IconWaveSmallWaitFrameList;
    [FieldOffset(0x02E8)] public TArray<int> IconWaveMediumWaitFrameList;
    [FieldOffset(0x02F8)] public TArray<int> IconWaveLargeWaitFrameList;
    [FieldOffset(0x0308)] public TArray<int> IconWaitAngleFrame;
    [FieldOffset(0x0318)] public TArray<int> IconMoveAngleFrame;
    [FieldOffset(0x0328)] public TArray<FColor> IconWaveSelColorList;
    [FieldOffset(0x0338)] public TArray<FColor> IconWaveNonSelColorList;
    [FieldOffset(0x0348)] public TArray<FColor> IconColor;
    [FieldOffset(0x0358)] public FColor BlackBoardColor;
    [FieldOffset(0x035C)] public FColor GladationBoardColor;
    [FieldOffset(0x0360)] public FColor BlueBoardColor;
    [FieldOffset(0x0364)] public FColor BlackBoardCoverColor;
    [FieldOffset(0x0368)] public TArray<int> CursorWaitMoveSlideFrame;
    [FieldOffset(0x0378)] public TArray<int> CursorMoveSlideFrame;
    [FieldOffset(0x0388)] public TArray<float> BlackBoardMoveSpeed;
    [FieldOffset(0x0398)] public TArray<float> BlueBoardMoveSpeed;
    [FieldOffset(0x03A8)] public TArray<float> BlueBoardRollSpeed;
    [FieldOffset(0x03B8)] public TArray<float> DayMoveSpeed;
    [FieldOffset(0x03C8)] public TArray<float> ScrollBarMoveSpeed;
    [FieldOffset(0x03D8)] public TArray<float> LogMoveSpeed;
    [FieldOffset(0x03E8)] public TArray<float> IconMoveSpeed;
    [FieldOffset(0x03F8)] public TArray<float> NoneMoveSpeed;
    [FieldOffset(0x0408)] public TArray<float> DecoMoveSpeed;
    [FieldOffset(0x0418)] public TArray<float> BlackBoardAlphaSpeed;
    [FieldOffset(0x0428)] public TArray<float> BlueBoardAlphaSpeed;
    [FieldOffset(0x0438)] public TArray<float> GradationAlphaSpeed;
    [FieldOffset(0x0448)] public TArray<float> DayAlphaSpeed;
    [FieldOffset(0x0458)] public TArray<float> ScrollBarAlphaSpeed;
    [FieldOffset(0x0468)] public TArray<float> LogAlphaSpeed;
    [FieldOffset(0x0478)] public TArray<float> IconAlphaSpeed;
    [FieldOffset(0x0488)] public TArray<float> NoneAlphaSpeed;
    [FieldOffset(0x0498)] public TArray<float> DecoAlphaSpeed;
    [FieldOffset(0x04A8)] public TArray<float> CursorWhiteMoveSpeed;
    [FieldOffset(0x04B8)] public TArray<float> CursorWhiteAlphaSpeed;
    [FieldOffset(0x04C8)] public TArray<float> CursorBlueMoveSpeed;
    [FieldOffset(0x04D8)] public TArray<float> CursorBlueAlphaSpeed;
    [FieldOffset(0x04E8)] public float AnimFinishTime;
    [FieldOffset(0x04EC)] public float SelMsgInterval;
    [FieldOffset(0x04F0)] public float MingMsgInterval;
    [FieldOffset(0x04F4)] public float SoundPlusPosX;
    [FieldOffset(0x04F8)] public float SoundPlusPosY;
    [FieldOffset(0x05C0)] public UTexture* tex;
    [FieldOffset(0x05C8)] public UFrameBufferCapture* captureBackGround;
    [FieldOffset(0x0A58)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xCA0)] 
public unsafe struct FBaseHeadPanel
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x4010)] 
public unsafe struct FBattleHeadPanel
{
    [FieldOffset(0x0000)] public FBaseHeadPanel baseObj;
    [FieldOffset(0x12C8)] public UMaterialInstanceDynamic* materialSmokeInst;
    [FieldOffset(0x12D0)] public UMaterialInstanceDynamic* materialSmokeInstGrey;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA70)] 
public unsafe struct AUIBattlePartyPanel
{
    [FieldOffset(0x0000)] public ABasePartyPanel baseObj;
    [FieldOffset(0x02C0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02C8)] public USprAsset* m_pSpr;
    [FieldOffset(0x03B0)] public TArray<FBattleHeadPanel> m_aHeadPanelList;
    [FieldOffset(0x03D0)] public FGetUIParameter m_uip;
    [FieldOffset(0x0448)] public FCurveVectorAnimation m_curveDamageShake;
    [FieldOffset(0x0508)] public FCurveFloatAnimation m_curveIceYScale;
    [FieldOffset(0x05C8)] public FCurveFloatAnimation m_curveIceAlpha;
    [FieldOffset(0x0688)] public FCurveFloatAnimation m_curveThunderWave;
    [FieldOffset(0x0748)] public FCurveFloatAnimation m_curveThunderWaveBone;
    [FieldOffset(0x0808)] public FCurveFloatAnimation m_curveThunderWaveCharaLight;
    [FieldOffset(0x08C8)] public FCurveVectorAnimation m_curveThunderWaveIcons;
    [FieldOffset(0x0988)] public FCurveVectorAnimation m_curveOrgiaEffect;
    [FieldOffset(0x0A48)] public UMaterialInterface* m_pSmokeMat;
    [FieldOffset(0x0A50)] public UMaterialInstanceDynamic* m_pSmokeMatInst;
    [FieldOffset(0x0A58)] public UMaterialInterface* m_pSmokeMatGrey;
    [FieldOffset(0x0A60)] public UMaterialInstanceDynamic* m_pSmokeMatInstGrey;
    [FieldOffset(0x0A68)] public UPartyPanelRecoveryEffect* m_pRecoveryEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUICalc
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xCE0)] 
public unsafe struct FCampHeadPanel
{
    [FieldOffset(0x0000)] public FBaseHeadPanel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct AUICampPartyPanel
{
    [FieldOffset(0x0000)] public ABasePartyPanel baseObj;
    [FieldOffset(0x02C0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02C8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02D0)] public TArray<FCampHeadPanel> m_aHeadPanelList;
    [FieldOffset(0x02E0)] public FCurveVectorAnimation m_curveInAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AUIClearSaveActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AUICloudCursorDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x480)] 
public unsafe struct AUICmmRankUPAnimManager
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public float RippleTime;
    [FieldOffset(0x027C)] public float RippleInitScale;
    [FieldOffset(0x0280)] public int CardNumFront;
    [FieldOffset(0x0284)] public int CardNumBack;
    [FieldOffset(0x0288)] public float CardScaleFront;
    [FieldOffset(0x028C)] public float CardScaleBack;
    [FieldOffset(0x0290)] public float TimeBGFadeIn;
    [FieldOffset(0x0294)] public float TimeBGFadeOut;
    [FieldOffset(0x0298)] public float TimeStarMainInAnime;
    [FieldOffset(0x029C)] public float FrameStartInAnimeInterval;
    [FieldOffset(0x02A0)] public float TimeWaitStarExpansion;
    [FieldOffset(0x02A4)] public float TimeWaitStarVanish;
    [FieldOffset(0x02A8)] public float TimeWaitStarWait;
    [FieldOffset(0x02AC)] public float TimeStartWaitAnimeInterval;
    [FieldOffset(0x02B0)] public float FrameCardFadeOut;
    [FieldOffset(0x02B4)] public FColor ColorNormalBG3Up;
    [FieldOffset(0x02B8)] public FColor ColorNormalBG3Middle;
    [FieldOffset(0x02BC)] public FColor ColorNormalBG3Down;
    [FieldOffset(0x02C0)] public FColor ColorNormalBG4;
    [FieldOffset(0x02C4)] public FColor ColorReverseBG3Up;
    [FieldOffset(0x02C8)] public FColor ColorReverseBG3Middle;
    [FieldOffset(0x02CC)] public FColor ColorReverseBG3Down;
    [FieldOffset(0x02D0)] public FColor ColorReverseBG4;
    [FieldOffset(0x02D4)] public float TimeMaxFadeIn;
    [FieldOffset(0x02D8)] public float TimeMaxWaitAfter;
    [FieldOffset(0x02E0)] public TArray<float> RippleBlur;
    [FieldOffset(0x02F0)] public TArray<float> RippleWidth;
    [FieldOffset(0x0300)] public float RationGradationUI;
    [FieldOffset(0x0304)] public float RationPosToOutGradationUI;
    [FieldOffset(0x0308)] public float RationReverseBG;
    [FieldOffset(0x030C)] public float ChangeRationReverseColorGradation;
    [FieldOffset(0x0310)] public float RotRationGradationReverse;
    [FieldOffset(0x0314)] public float AlphaRationBG12;
    [FieldOffset(0x0318)] public float SpeedRationBackCards;
    [FieldOffset(0x031C)] public float MoveRatioBackBGCard;
    [FieldOffset(0x0320)] public float MoveRatioFrontBGCard;
    [FieldOffset(0x0324)] public float ChangeRationReverseColorBackCards;
    [FieldOffset(0x0328)] public float RotationAllBGCard;
    [FieldOffset(0x032C)] public float RotRatioArcanaCard;
    [FieldOffset(0x0330)] public float AlphaRatioArcanaCard;
    [FieldOffset(0x0334)] public bool isVisibleArcanaCardShadow;
    [FieldOffset(0x0335)] public bool isVisibleStars;
    [FieldOffset(0x0338)] public float RotateAllStars;
    [FieldOffset(0x033C)] public float AlphaAllStars;
    [FieldOffset(0x0340)] public float MoveXRankUpTitle;
    [FieldOffset(0x0344)] public float AlphaRankUpTitle;
    [FieldOffset(0x0348)] public float RatioLetter;
    [FieldOffset(0x034C)] public float AlphaRankupStrings;
    [FieldOffset(0x0350)] public float MoveRationRankupStrings;
    [FieldOffset(0x0354)] public float AlphaRankupMaxStrings;
    [FieldOffset(0x0358)] public float MoveRankupMaxStrings;
    [FieldOffset(0x035C)] public bool IsChangeReverseSprCommuName;
    [FieldOffset(0x0360)] public float MoveXReverseString;
    [FieldOffset(0x0364)] public float AlphaReverseString;
    [FieldOffset(0x0368)] public float AlphaKeyhelp;
    [FieldOffset(0x036C)] public float ScaleKeyhelp;
    [FieldOffset(0x0370)] public float MoveAllKeyHelp;
    [FieldOffset(0x0374)] public float MoveMaskKeyHelp;
    [FieldOffset(0x0378)] public bool IsStartKeyHelpIn;
    [FieldOffset(0x0379)] public bool IsStartKeyHelpOut;
    [FieldOffset(0x037C)] public int AnimationContentGameOver;
    [FieldOffset(0x0380)] public float AlphaEFGameOver;
    [FieldOffset(0x0384)] public float ScaleRationGameOver;
    [FieldOffset(0x0388)] public float WeaveSpeedGameOver;
    [FieldOffset(0x038C)] public float ScaleWidthGameOver;
    [FieldOffset(0x0390)] public float ScaleHightGameOver;
    [FieldOffset(0x0394)] public float TimeGameOver;
    [FieldOffset(0x0398)] public float AlphaNormalGameOver;
    [FieldOffset(0x039C)] public float MoveYGameOver;
    [FieldOffset(0x03A0)] public float AlphaRipple1;
    [FieldOffset(0x03A4)] public float ScaleRipple1;
    [FieldOffset(0x03A8)] public float AlphaRipple2;
    [FieldOffset(0x03AC)] public float ScaleRipple2;
    [FieldOffset(0x03B0)] public float AlphaRipple3;
    [FieldOffset(0x03B4)] public float ScaleRipple3;
    [FieldOffset(0x03B8)] public bool IsEndFinalRipple;
    [FieldOffset(0x03BC)] public float AlphaCardEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AUICmmRankUpBG
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02BD)] public EUIBlendFactor SrcColor;
    [FieldOffset(0x02BE)] public EUIBlendFactor DstColor;
    [FieldOffset(0x02BF)] public EUIBlendFactor SrcAlpha;
    [FieldOffset(0x02C0)] public EUIBlendFactor DstAlpha;
    [FieldOffset(0x02C1)] public bool bCaptureBG;
    [FieldOffset(0x02C8)] public UMaterialInstanceDynamic* pBGMaterial;
    [FieldOffset(0x02D0)] public bool isAlreadySetBGMaterial;
    [FieldOffset(0x02F8)] public AUICmmRankUPAnimManager* AnimManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC30)] 
public unsafe struct AUICmmRankUpDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02C0)] public USprAsset* pSprAsset;
    [FieldOffset(0x02C8)] public UPlgAsset* pPlgAsset;
    [FieldOffset(0x0B10)] public UFrameBufferCapture* CaptureTexture;
    [FieldOffset(0x0B18)] public AUICmmRankUPAnimManager* AnimManager;
    [FieldOffset(0x0B20)] public USprAsset* pSprKeyHelp;
    [FieldOffset(0x0B28)] public USprAsset* pSprKeyHelpButton;
    [FieldOffset(0x0B30)] public AUIRankUpDraw* pManager;
    [FieldOffset(0x0C18)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x0C20)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
    [FieldOffset(0x0C28)] public UUILayoutDataTable* CmmRankUpLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UCmpCldCursor
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct AUICmpCalendar
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02F8)] public UCmpCldCursor* DayCursor_;
    [FieldOffset(0x0300)] public UUICmpCalendarDraw* Drawer_;
    [FieldOffset(0x0310)] public TSubclassOf<AUICmpCalendar> CalendarBPClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x410)] 
public unsafe struct UUICmpCalendarDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x03C8)] public UMaterialInstance* pBackgroundMaterialInstance;
    [FieldOffset(0x03D0)] public UMaterialInstanceDynamic* pBackgroundMaterialDaynamic;
    [FieldOffset(0x03D8)] public UDataTable* pEditParameterDataTable;
    [FieldOffset(0x03E0)] public UDataTable* pMonthTable;
    [FieldOffset(0x03E8)] public UDataTable* pDayTable;
    [FieldOffset(0x03F0)] public UDataTable* pWeekTable;
    [FieldOffset(0x03F8)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0400)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x478)] 
public unsafe struct AUICmpCommu
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x0408)] public UUISceneFSM* SceneFSM_;
    [FieldOffset(0x0410)] public UCmpCommuList* CommuListScene_;
    [FieldOffset(0x0418)] public UCmpCommuDetails* CommuDetailsScene_;
    [FieldOffset(0x0458)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x0460)] public UCmpCommu* pParent;
    [FieldOffset(0x0468)] public ACmpCommuModelController* pModelController;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9F0)] 
public unsafe struct AUICmpPersona
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0298)] public UUISceneFSM* SceneFSM_;
    [FieldOffset(0x02A0)] public UCmpPersonaList* PersonaList_;
    [FieldOffset(0x02A8)] public APersonaStatus* PSStatusActor_;
    [FieldOffset(0x09D0)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x09D8)] public UCmpPersona* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AUICmpQuest
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B0)] public UUISceneFSM* SceneFSM_;
    [FieldOffset(0x02B8)] public UQuestElizRequest* ElizRequestScene_;
    [FieldOffset(0x02C0)] public UQuestDisappearList* DisappearListScene_;
    [FieldOffset(0x02C8)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x348)] 
public unsafe struct UUICmpStatus
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x02B0)] public UUISceneFSM* SceneFSM_;
    [FieldOffset(0x02B8)] public TMap<int, IntPtr> Scenes_;
    [FieldOffset(0x0308)] public APersonaStatus* PSStatusActor_;
    [FieldOffset(0x0310)] public AUIDialogSingle* SingleDialog_;
    [FieldOffset(0x0318)] public UCmpStatusCharacterListDraw* CharaListDraw_;
    [FieldOffset(0x0320)] public UCmpCharacterStatusDraw* CharaStatusDraw_;
    [FieldOffset(0x0330)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x0338)] public UCmpStatus* pParent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x418)] 
public unsafe struct UUICombine
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UUIVelvetRoomOwner* m_pOwner;
    [FieldOffset(0x03E0)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x03E8)] public TSubclassOf<AUIPersonaModelActor> pBPPersonaBaseCore;
    [FieldOffset(0x03F0)] public AActor* pPersonaBaseCore;
    [FieldOffset(0x03F8)] public AAppPropsCardContainer* pAppPropsCardContainer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUICombineCalcFunction
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UUICombineCalc
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* Loader_;
    [FieldOffset(0x0030)] public UNormalSpreadDataAsset* NormalSpread_;
    [FieldOffset(0x0038)] public USpecialSpreadDataAsset* SpecialSpread_;
    [FieldOffset(0x0040)] public UPersonaLiftDataAsset* PersonaLift_;
    [FieldOffset(0x0048)] public USkillAffinityDataAsset* SkillAffinity_;
    [FieldOffset(0x0050)] public USkillLimitDataAsset* SkillLimit_;
    [FieldOffset(0x0058)] public UPersonaConfigDataAsset* PersonaConfig_;
    [FieldOffset(0x0060)] public UCommunityRankDataAsset* CommunityRank_;
    [FieldOffset(0x0068)] public UMoonAgeProbabilityDataAsset* MoonAgeProbability_;
    [FieldOffset(0x0070)] public UCombineCounterDataAsset* CombineCounter_;
    [FieldOffset(0x0078)] public USkillChangeDataAsset* SkillChange_;
    [FieldOffset(0x0080)] public USkillPackDataAsset* SkillPack_;
    [FieldOffset(0x0088)] public USkillPowerUpDataAsset* SkillPowerUp_;
    [FieldOffset(0x0090)] public UCombineMiscDataAsset* CombineMisc_;
    [FieldOffset(0x0098)] public UObject* BPCombineCalc_;
    [FieldOffset(0x00A0)] public UUICombineCalcFunction* CombineCalcFunction_;
    [FieldOffset(0x00A8)] public UDLCPersonaCombineBirthDataAsset* DLCPersonaCombineBirth_;
    [FieldOffset(0x00B0)] public UWordSortDataAsset* WordSortDataAsset_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UUICompleteBook
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UUIVelvetRoomOwner* m_pOwner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UUICompleteBookRegist
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0040)] public UUIVelvetRoomOwner* m_pOwner;
    [FieldOffset(0x0048)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0050)] public USprAsset* m_pSpr;
}

[StructLayout(LayoutKind.Explicit, Size = 0xCD8)] 
public unsafe struct AUIConfiguration
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x03C8)] public UConfigBGMSelectDialog* ConfigBGMSelect;
    [FieldOffset(0x03D0)] public UConfigDungeonBGMSelectDialog* ConfigDungeonBGMSelect;
    [FieldOffset(0x03D8)] public UDataTable* ConfigTable;
    [FieldOffset(0x03E0)] public UAssetLoader* Loader;
    [FieldOffset(0x03E8)] public AUISystemMsgActor* NetWaitDialog;
    [FieldOffset(0x03F0)] public TSubclassOf<AUIConfigurationDraw> DrawActorSC;
    [FieldOffset(0x03F8)] public AUIConfigurationDraw* DrawActor;
    [FieldOffset(0x0400)] public USprAsset* pKeySpr;
    [FieldOffset(0x0CC0)] public UDataTable* LayoutData;
    [FieldOffset(0x0CC8)] public UDataTable* HelpLayoutData;
    [FieldOffset(0x0CD0)] public UDataTable* pParamLayoutDataConfigText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDrawBGMParam
{
    [FieldOffset(0x0000)] public FString Title;
    [FieldOffset(0x0010)] public int BgmId;
    [FieldOffset(0x0014)] public bool bNewFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FDrawConfigParam
{
    [FieldOffset(0x0000)] public EDrawConfigParamType Type;
    [FieldOffset(0x0004)] public int MenueID;
    [FieldOffset(0x0008)] public FString Title;
    [FieldOffset(0x0018)] public FString Description;
    [FieldOffset(0x0028)] public int Value;
    [FieldOffset(0x002C)] public bool bFlag;
    [FieldOffset(0x002D)] public bool bEnable;
    [FieldOffset(0x002E)] public EDrawConfigListType ListType;
    [FieldOffset(0x0030)] public int ListMaxNum;
    [FieldOffset(0x0034)] public int ListDefault;
    [FieldOffset(0x0038)] public FString SelectedLabel;
    [FieldOffset(0x0048)] public FColor SprColor;
    [FieldOffset(0x004C)] public int DrawStatus;
    [FieldOffset(0x0060)] public float DescriptionScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x680)] 
public unsafe struct AUIConfigurationDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02F8)] public FVector2D ItemDrawOffset;
    [FieldOffset(0x0340)] public TArray<FDrawBGMParam> BgmParams;
    [FieldOffset(0x0350)] public USprAsset* pKeySpr;
    [FieldOffset(0x0668)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0670)] public UUILayoutDataTable* HelpLayoutDataTable;
    [FieldOffset(0x0678)] public UUILayoutDataTable* ConfigTextLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UUIContactManager
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> m_pUIActorList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUIDataAssets
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FWeaponItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint WeaponType;
    [FieldOffset(0x0018)] public uint EquipID;
    [FieldOffset(0x001C)] public ushort AttrID;
    [FieldOffset(0x001E)] public ushort Rarity;
    [FieldOffset(0x0020)] public ushort Tier;
    [FieldOffset(0x0022)] public ushort attack;
    [FieldOffset(0x0024)] public ushort Accuracy;
    [FieldOffset(0x0026)] public ushort Strength;
    [FieldOffset(0x0028)] public ushort Magic;
    [FieldOffset(0x002A)] public ushort Endurance;
    [FieldOffset(0x002C)] public ushort Agility;
    [FieldOffset(0x002E)] public ushort Luck;
    [FieldOffset(0x0030)] public ushort skillId;
    [FieldOffset(0x0034)] public uint Price;
    [FieldOffset(0x0038)] public uint SellPrice;
    [FieldOffset(0x003C)] public ushort GetFLG;
    [FieldOffset(0x003E)] public ushort ModelID;
    [FieldOffset(0x0040)] public uint flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UWeaponItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FWeaponItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FArmorItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public uint EquipID;
    [FieldOffset(0x001C)] public ushort Rarity;
    [FieldOffset(0x001E)] public ushort Tier;
    [FieldOffset(0x0020)] public ushort Defence;
    [FieldOffset(0x0022)] public ushort Strength;
    [FieldOffset(0x0024)] public ushort Magic;
    [FieldOffset(0x0026)] public ushort Endurance;
    [FieldOffset(0x0028)] public ushort Agility;
    [FieldOffset(0x002A)] public ushort Luck;
    [FieldOffset(0x002C)] public ushort skillId;
    [FieldOffset(0x0030)] public uint Price;
    [FieldOffset(0x0034)] public uint SellPrice;
    [FieldOffset(0x0038)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UArmorItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FArmorItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FShoesItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public uint EquipID;
    [FieldOffset(0x001C)] public ushort Rarity;
    [FieldOffset(0x001E)] public ushort Tier;
    [FieldOffset(0x0020)] public ushort Evasion;
    [FieldOffset(0x0022)] public ushort Strength;
    [FieldOffset(0x0024)] public ushort Magic;
    [FieldOffset(0x0026)] public ushort Endurance;
    [FieldOffset(0x0028)] public ushort Agility;
    [FieldOffset(0x002A)] public ushort Luck;
    [FieldOffset(0x002C)] public ushort skillId;
    [FieldOffset(0x0030)] public uint Price;
    [FieldOffset(0x0034)] public uint SellPrice;
    [FieldOffset(0x0038)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UShoesItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FShoesItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAccsItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public uint EquipID;
    [FieldOffset(0x001C)] public ushort Rarity;
    [FieldOffset(0x001E)] public ushort Tier;
    [FieldOffset(0x0020)] public ushort Strength;
    [FieldOffset(0x0022)] public ushort Magic;
    [FieldOffset(0x0024)] public ushort Endurance;
    [FieldOffset(0x0026)] public ushort Agility;
    [FieldOffset(0x0028)] public ushort Luck;
    [FieldOffset(0x002A)] public ushort skillId;
    [FieldOffset(0x002C)] public uint Price;
    [FieldOffset(0x0030)] public uint SellPrice;
    [FieldOffset(0x0034)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAccsItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAccsItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSkillcardItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public ushort Rarity;
    [FieldOffset(0x001A)] public ushort Tier;
    [FieldOffset(0x001C)] public ushort skillId;
    [FieldOffset(0x0020)] public uint Price;
    [FieldOffset(0x0024)] public uint SellPrice;
    [FieldOffset(0x0028)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillcardItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillcardItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEvitemItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UEvitemItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FEvitemItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMaterialItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public ushort Rarity;
    [FieldOffset(0x001C)] public uint Price;
    [FieldOffset(0x0020)] public uint SellPrice;
    [FieldOffset(0x0024)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMaterialItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMaterialItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCostumeItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public uint EquipID;
    [FieldOffset(0x001C)] public uint Price;
    [FieldOffset(0x0020)] public uint SellPrice;
    [FieldOffset(0x0024)] public ushort GetFLG;
    [FieldOffset(0x0028)] public uint ReflectType;
    [FieldOffset(0x002C)] public ushort CostumeID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCostumeItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCostumeItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCommonItemList
{
    [FieldOffset(0x0000)] public FString ItemDef;
    [FieldOffset(0x0010)] public ushort SortNum;
    [FieldOffset(0x0012)] public ushort BtlSortNum;
    [FieldOffset(0x0014)] public uint ItemType;
    [FieldOffset(0x0018)] public ushort UsePlaceID;
    [FieldOffset(0x001A)] public ushort Rarity;
    [FieldOffset(0x001C)] public ushort Tier;
    [FieldOffset(0x001E)] public ushort Hp;
    [FieldOffset(0x0020)] public ushort Sp;
    [FieldOffset(0x0022)] public ushort Strength;
    [FieldOffset(0x0024)] public ushort Magic;
    [FieldOffset(0x0026)] public ushort Endurance;
    [FieldOffset(0x0028)] public ushort Agility;
    [FieldOffset(0x002A)] public ushort Luck;
    [FieldOffset(0x002C)] public ushort skillId;
    [FieldOffset(0x0030)] public uint Price;
    [FieldOffset(0x0034)] public uint SellPrice;
    [FieldOffset(0x0038)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCommonItemListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCommonItemList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FShopLineUpListBase
{
    [FieldOffset(0x0000)] public ushort Value;
    [FieldOffset(0x0002)] public ushort SaleMonth;
    [FieldOffset(0x0004)] public ushort SaleDay;
    [FieldOffset(0x0008)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FWeaponShopLineUpList
{
    [FieldOffset(0x0000)] public FShopLineUpListBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UWeaponShopLineUpListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FWeaponShopLineUpList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FItemShopLineUpList
{
    [FieldOffset(0x0000)] public FShopLineUpListBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UItemShopLineUpListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FItemShopLineUpList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FAntiqueShopTradeItem
{
    [FieldOffset(0x0000)] public ushort ItemId;
    [FieldOffset(0x0002)] public ushort itemNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAntiqueShopLineUpList
{
    [FieldOffset(0x0000)] public FShopLineUpListBase baseObj;
    [FieldOffset(0x000C)] public ushort Type;
    [FieldOffset(0x0010)] public TArray<FAntiqueShopTradeItem> TradeItems;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FAntiqueShopEquipCombineSource
{
    [FieldOffset(0x0000)] public FShopLineUpListBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAntiqueShopEquipCombineResult
{
    [FieldOffset(0x0000)] public FShopLineUpListBase baseObj;
    [FieldOffset(0x000C)] public ushort BaseItemID;
    [FieldOffset(0x0010)] public TArray<FAntiqueShopTradeItem> TradeItems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAntiqueShopLineUpListTable
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAntiqueShopLineUpList> TradeData;
    [FieldOffset(0x0040)] public TArray<FAntiqueShopEquipCombineSource> CombineSources;
    [FieldOffset(0x0050)] public TArray<FAntiqueShopEquipCombineResult> CombineResults;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSimpleShopLineup
{
    [FieldOffset(0x0000)] public ushort ItemId;
    [FieldOffset(0x0002)] public byte SellWeekFlag;
    [FieldOffset(0x0003)] public byte LiftMonth;
    [FieldOffset(0x0004)] public byte LiftDays;
    [FieldOffset(0x0005)] public byte Stock;
    [FieldOffset(0x0006)] public byte ResetWeekFlag;
    [FieldOffset(0x0008)] public int OpenFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSimpleShopData
{
    [FieldOffset(0x0000)] public TArray<FSimpleShopLineup> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USimpleShopDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSimpleShopData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UItemNameListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FString> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFontAdjustmentList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Code;
    [FieldOffset(0x0010)] public FString Font;
    [FieldOffset(0x0020)] public float Left_Adjustment;
    [FieldOffset(0x0024)] public float Right_Adjustment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UFontAdjustmentListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<int, FFontAdjustmentList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FSuggestionList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Category;
    [FieldOffset(0x0018)] public FString TextLabel;
    [FieldOffset(0x0028)] public FString VisibleFlag;
    [FieldOffset(0x0038)] public FString HideFlag;
    [FieldOffset(0x0048)] public FString ReferenceGlobalCounter;
    [FieldOffset(0x0058)] public int StartValue;
    [FieldOffset(0x005C)] public int EndValue;
    [FieldOffset(0x0060)] public int AnimationFlag;
    [FieldOffset(0x0068)] public FString SuggestionFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USuggestionListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSuggestionList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSuggestionTextList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString TextLabel;
    [FieldOffset(0x0018)] public FString Text;
    [FieldOffset(0x0028)] public FString Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USuggestionTextListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSuggestionTextList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMiniMapIconList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString IconName;
    [FieldOffset(0x0018)] public int SprType;
    [FieldOffset(0x001C)] public int SprNo;
    [FieldOffset(0x0020)] public float X;
    [FieldOffset(0x0024)] public float Y;
    [FieldOffset(0x0028)] public float DegreeAngle;
    [FieldOffset(0x0030)] public FString VisibleFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMiniMapIconListTable
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMiniMapIconList> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FTownMapRestrictionsTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int KeyfreeEventID;
    [FieldOffset(0x000C)] public bool CloseLMap;
    [FieldOffset(0x0010)] public int DestinationA;
    [FieldOffset(0x0014)] public int DestinationB;
    [FieldOffset(0x0018)] public int DestinationC;
    [FieldOffset(0x001C)] public int DestinationD;
    [FieldOffset(0x0020)] public int DestinationE;
    [FieldOffset(0x0024)] public int DestinationF;
    [FieldOffset(0x0028)] public FString AfterMove;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTownMapRestrictionsDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTownMapRestrictionsTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FTownMapTimeTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString TownName;
    [FieldOffset(0x0018)] public bool Noon;
    [FieldOffset(0x0020)] public FString NoonVisibleFlag;
    [FieldOffset(0x0030)] public FString NoonHideFlag1;
    [FieldOffset(0x0040)] public FString NoonHideFlag2;
    [FieldOffset(0x0050)] public bool Night;
    [FieldOffset(0x0058)] public FString NightVisibleFlag;
    [FieldOffset(0x0068)] public FString NightHideFlag1;
    [FieldOffset(0x0078)] public FString NightHideFlag2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTownMapTimeDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTownMapTimeTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTownMapInfoDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTownMapInfoTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTownMapInfoNameDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTownMapInfoNameTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTownMapDetailTextDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTownMapDetailTextTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMiniMapOffsetDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMiniMapOffsetTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMiniMapInfoDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMiniMapInfoTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBustupParts
{
    [FieldOffset(0x0000)] public FString Pose;
    [FieldOffset(0x0010)] public ushort EyePartsID;
    [FieldOffset(0x0012)] public ushort MouthPartsID;
    [FieldOffset(0x0014)] public byte bEyeAnim;
    [FieldOffset(0x0014)] public byte bMouthAnim;
    [FieldOffset(0x0015)] public byte InBetween;
    [FieldOffset(0x0018)] public float EyeX;
    [FieldOffset(0x001C)] public float EyeY;
    [FieldOffset(0x0020)] public float MouthX;
    [FieldOffset(0x0024)] public float MouthY;
    [FieldOffset(0x0028)] public float BlushX;
    [FieldOffset(0x002C)] public float BlushY;
    [FieldOffset(0x0030)] public float SweatX;
    [FieldOffset(0x0034)] public float SweatY;
    [FieldOffset(0x0038)] public float OffsetX;
    [FieldOffset(0x003C)] public float OffsetY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBustupCloth
{
    [FieldOffset(0x0000)] public TMap<int, FBustupParts> Clothes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBustupFace
{
    [FieldOffset(0x0000)] public TMap<int, FBustupCloth> Faces;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UBustupExistDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<int, FBustupFace> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FBustupAnim
{
    [FieldOffset(0x0000)] public byte Type;
    [FieldOffset(0x0004)] public float Duration;
    [FieldOffset(0x0008)] public float Random;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBustupMouthAnim
{
    [FieldOffset(0x0000)] public TArray<FBustupAnim> Anim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UBustupAnimDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FBustupAnim> EyeAnim;
    [FieldOffset(0x0040)] public TArray<FBustupMouthAnim> MouthAnim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBustupEnvironment
{
    [FieldOffset(0x0000)] public TArray<byte> No;
    [FieldOffset(0x0010)] public TArray<byte> HeroNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBustupEnvironmentBG
{
    [FieldOffset(0x0000)] public TMap<int, FBustupEnvironment> Bg;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UBustupEnvironmentDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<int, FBustupEnvironmentBG> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBustupGradation
{
    [FieldOffset(0x0000)] public float Angle;
    [FieldOffset(0x0004)] public float ShadowPosition;
    [FieldOffset(0x0008)] public float Range;
    [FieldOffset(0x000C)] public float ShadowColorR;
    [FieldOffset(0x0010)] public float ShadowColorG;
    [FieldOffset(0x0014)] public float ShadowColorB;
    [FieldOffset(0x0018)] public float ShadowColorA;
    [FieldOffset(0x001C)] public float Desaturation;
    [FieldOffset(0x0020)] public float Brightness;
    [FieldOffset(0x0024)] public byte TextureNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UBustupGradationDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<byte, FBustupGradation> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSupportBustupParam
{
    [FieldOffset(0x0000)] public ushort CharaID;
    [FieldOffset(0x0008)] public FString Pose;
    [FieldOffset(0x0018)] public float OffsetLeft_X;
    [FieldOffset(0x001C)] public float OffsetLeft_Y;
    [FieldOffset(0x0020)] public float MaskOffsetLeft_Y;
    [FieldOffset(0x0024)] public float OffsetRight_X;
    [FieldOffset(0x0028)] public float OffsetRight_Y;
    [FieldOffset(0x002C)] public float MaskOffsetRight_Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USupportBustupDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSupportBustupParam> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FMailIncomingItem
{
    [FieldOffset(0x0000)] public ushort ID;
    [FieldOffset(0x0002)] public ushort SenderID;
    [FieldOffset(0x0004)] public ushort Group;
    [FieldOffset(0x0006)] public EMailCategory Category;
    [FieldOffset(0x0007)] public byte StartMonth;
    [FieldOffset(0x0008)] public byte StartDays;
    [FieldOffset(0x0009)] public byte EndMonth;
    [FieldOffset(0x000A)] public byte EndDays;
    [FieldOffset(0x000B)] public EMailTime ReceiveTime;
    [FieldOffset(0x000C)] public byte WeekFlag;
    [FieldOffset(0x000D)] public byte bWeekday;
    [FieldOffset(0x000D)] public byte bHoliday;
    [FieldOffset(0x000D)] public byte bRankUp;
    [FieldOffset(0x000D)] public byte bOnlyOnce;
    [FieldOffset(0x000E)] public byte ArcanaID;
    [FieldOffset(0x000F)] public EMailCondition ArcanaCondition;
    [FieldOffset(0x0010)] public byte Rank;
    [FieldOffset(0x0011)] public byte InviteCounter;
    [FieldOffset(0x0014)] public int CounterID;
    [FieldOffset(0x0018)] public EMailCondition CounterCondition;
    [FieldOffset(0x001C)] public int CounterValue;
    [FieldOffset(0x0020)] public FString MailBmdFileName;
    [FieldOffset(0x0030)] public int SenderLabelID;
    [FieldOffset(0x0034)] public int TitleLabelID;
    [FieldOffset(0x0038)] public int BodyLabelID;
    [FieldOffset(0x0040)] public FString ScriptBfFileName;
    [FieldOffset(0x0050)] public FString ScriptBmdFileName;
    [FieldOffset(0x0060)] public TArray<int> EnableFlags;
    [FieldOffset(0x0070)] public TArray<int> DisableFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMailIncomingDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<int, FMailIncomingItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FDisappearItem
{
    [FieldOffset(0x0000)] public byte StartMonth;
    [FieldOffset(0x0001)] public byte StartDays;
    [FieldOffset(0x0002)] public byte LimitMonth;
    [FieldOffset(0x0003)] public byte LimitDays;
    [FieldOffset(0x0004)] public int ActiveFlag;
    [FieldOffset(0x0008)] public int SuccessFlag;
    [FieldOffset(0x000C)] public int FailedFlag;
    [FieldOffset(0x0010)] public int NpcFlag;
    [FieldOffset(0x0014)] public int InfoOnFlag;
    [FieldOffset(0x0018)] public int AwardFlag;
    [FieldOffset(0x001C)] public ushort AwardItemID;
    [FieldOffset(0x001E)] public ushort AwardItemNum;
    [FieldOffset(0x0020)] public uint AwardMoney;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UDisappearDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<ushort, FDisappearItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNormalSpreadItem
{
    [FieldOffset(0x0000)] public TArray<byte> Races;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UNormalSpreadDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FNormalSpreadItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSpecialSpreadItem
{
    [FieldOffset(0x0000)] public ushort ResultID;
    [FieldOffset(0x0002)] public ushort SourceID;
    [FieldOffset(0x000E)] public ushort Index;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USpecialSpreadDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSpecialSpreadItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FPersonaLiftItem
{
    [FieldOffset(0x0000)] public ushort PersonaID;
    [FieldOffset(0x0004)] public uint OrFlag;
    [FieldOffset(0x0008)] public uint AndFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPersonaLiftDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FPersonaLiftItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FSkillAffinityItem
{
    [FieldOffset(0x0000)] public uint Bit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillAffinityDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillAffinityItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FSkillLimitItem
{
    [FieldOffset(0x0000)] public byte TotalSkillNum;
    [FieldOffset(0x0001)] public byte InheritanceSkillNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillLimitDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillLimitItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FPersonaConfigItem
{
    [FieldOffset(0x0000)] public int BirthMsgNo;
    [FieldOffset(0x0004)] public uint ToneType;
    [FieldOffset(0x0008)] public uint VoicePack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPersonaConfigDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FPersonaConfigItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FCommunityRankItem
{
    [FieldOffset(0x0000)] public ushort Bonus;
    [FieldOffset(0x0002)] public ushort HighBonus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCommunityRankDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCommunityRankItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMoonAgeProbabilityItem
{
    [FieldOffset(0x0000)] public ushort ConceptionRate;
    [FieldOffset(0x0002)] public ushort SkillChangeRate;
    [FieldOffset(0x0004)] public ushort AccidentRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMoonAgeProbabilityDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FMoonAgeProbabilityItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCombineCounterItem
{
    [FieldOffset(0x0000)] public ushort Num;
    [FieldOffset(0x0002)] public ushort ConceptionRate;
    [FieldOffset(0x0004)] public ushort SkillChangeRate;
    [FieldOffset(0x0006)] public ushort AccidentRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCombineCounterDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FCombineCounterItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FSkillChangeItem
{
    [FieldOffset(0x0000)] public ushort SkillPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillChangeDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillChangeItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSkillPackItem
{
    [FieldOffset(0x0000)] public ushort Rank;
    [FieldOffset(0x0002)] public ushort Skill;
    [FieldOffset(0x0004)] public ushort Weight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkillPackItems
{
    [FieldOffset(0x0000)] public TArray<FSkillPackItem> Items;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillPackDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillPackItems> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSkillPowerUpItem
{
    [FieldOffset(0x0000)] public ushort OldSkill;
    [FieldOffset(0x0002)] public ushort NewSkill;
    [FieldOffset(0x0004)] public ushort LevelLimit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USkillPowerUpDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FSkillPowerUpItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UCombineMiscDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public float AccidentBaseRate;
    [FieldOffset(0x0034)] public float FoolAccidentRate;
    [FieldOffset(0x0038)] public short AccidentMinLv;
    [FieldOffset(0x003A)] public short AccidentMaxLv;
    [FieldOffset(0x003C)] public float SkillChangeBaseRate;
    [FieldOffset(0x0040)] public float SkillBuildUpRate;
    [FieldOffset(0x0048)] public TArray<float> SkillChanges;
    [FieldOffset(0x0058)] public TArray<float> SkillWeights;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVelvetRoomQuestRequest
{
    [FieldOffset(0x0000)] public EQuestRequestType Type;
    [FieldOffset(0x0001)] public EQuestRequestPersonaType PersonaType;
    [FieldOffset(0x0002)] public EQuestRequestOption OPTION;
    [FieldOffset(0x0004)] public uint ID;
    [FieldOffset(0x0008)] public uint Value;
    [FieldOffset(0x000C)] public uint Penalty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVelvetRoomQuestReward
{
    [FieldOffset(0x0000)] public ushort ItemId;
    [FieldOffset(0x0002)] public ushort itemNum;
    [FieldOffset(0x0004)] public uint money;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FVelvetRoomQuestItem
{
    [FieldOffset(0x0000)] public TArray<ushort> OpenNo;
    [FieldOffset(0x0010)] public byte StartMonth;
    [FieldOffset(0x0011)] public byte StartDay;
    [FieldOffset(0x0012)] public byte EndMonth;
    [FieldOffset(0x0013)] public byte EndDay;
    [FieldOffset(0x0014)] public uint OpenFlag;
    [FieldOffset(0x0018)] public uint ReceivedFlag;
    [FieldOffset(0x001C)] public uint EndFlag;
    [FieldOffset(0x0020)] public byte Rank;
    [FieldOffset(0x0024)] public FVelvetRoomQuestRequest Request;
    [FieldOffset(0x0034)] public FVelvetRoomQuestReward Reward;
    [FieldOffset(0x003C)] public uint InfoDisplay;
    [FieldOffset(0x0040)] public uint OrderTalkID;
    [FieldOffset(0x0044)] public uint QuestIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UVelvetRoomQuestDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FVelvetRoomQuestItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FCmmProfileItem
{
    [FieldOffset(0x0000)] public ushort PCID;
    [FieldOffset(0x0004)] public uint DisappearID;
    [FieldOffset(0x0008)] public int NameMsgNo;
    [FieldOffset(0x0010)] public TMap<ECmmProfileMsgType, int> ProfileMsgNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UCmmProfileDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<ushort, FCmmProfileItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FModelCaptureEnvironment
{
    [FieldOffset(0x0000)] public TArray<FCollectionScalarParameter> ScalarParameters;
    [FieldOffset(0x0010)] public TArray<FCollectionVectorParameter> VectorParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FModelCaptureLayoutItem
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FRotator Rotation;
    [FieldOffset(0x0018)] public FVector RotationOffset;
    [FieldOffset(0x0024)] public float FOV;
    [FieldOffset(0x0028)] public bool bRotationLocal;
    [FieldOffset(0x0029)] public bool bYawLimit;
    [FieldOffset(0x002C)] public float YawMinusLimit;
    [FieldOffset(0x0030)] public float YawPlusLimit;
    [FieldOffset(0x0034)] public EAnimationType AnimType;
    [FieldOffset(0x0038)] public FModelCaptureEnvironment Environment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UModelCaptureLayoutDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public FModelCaptureEnvironment Environment;
    [FieldOffset(0x0050)] public TArray<FModelCaptureLayoutItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FGenSelItemDefine
{
    [FieldOffset(0x0000)] public int DefineValue;
    [FieldOffset(0x0008)] public FString DefineName;
    [FieldOffset(0x0018)] public FString TitleText;
    [FieldOffset(0x0028)] public FString CommentText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGenSelItemDefineDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FGenSelItemDefine> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGenSelItemLineupItem
{
    [FieldOffset(0x0000)] public ushort ItemId;
    [FieldOffset(0x0004)] public uint VisibleFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGenSelItemLineup
{
    [FieldOffset(0x0000)] public TArray<FGenSelItemLineupItem> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGenSelItemLineupDataAsset
{
    [FieldOffset(0x0000)] public UAppMultiDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FGenSelItemLineup> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FArbeitInfo
{
    [FieldOffset(0x0000)] public uint HelpMSGLabel;
    [FieldOffset(0x0004)] public EArbeitOrderableTime OrderableTimes;
    [FieldOffset(0x0005)] public byte OrderableWeeks;
    [FieldOffset(0x0008)] public uint UnlockFLG;
    [FieldOffset(0x000C)] public uint UnlockDayCNT;
    [FieldOffset(0x0010)] public uint HiddenFLG;
    [FieldOffset(0x0014)] public bool HolidayWork;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UArbeitInfoDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FArbeitInfo> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FHiddenArbeitData
{
    [FieldOffset(0x0000)] public int Month;
    [FieldOffset(0x0004)] public int Day;
    [FieldOffset(0x0008)] public int TotalDay;
    [FieldOffset(0x000C)] public EArbeitOrderableTime TimeZone;
    [FieldOffset(0x000D)] public bool Visibility;
    [FieldOffset(0x0010)] public uint EnableFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHiddenArbeitDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FHiddenArbeitData> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UNameEntryCnvCharDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TMap<uint, FString> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDLCPersonaCombineBirthTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000C)] public uint flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UDLCPersonaCombineBirthDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FDLCPersonaCombineBirthTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FWordSortTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort PersonaID;
    [FieldOffset(0x000C)] public uint Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UWordSortDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FWordSortTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAddContentTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort CategoryID;
    [FieldOffset(0x000A)] public ushort ItemId;
    [FieldOffset(0x001E)] public ushort itemNum;
    [FieldOffset(0x0034)] public uint ActiveFlag;
    [FieldOffset(0x0038)] public uint GetFlag;
    [FieldOffset(0x003C)] public uint NewFlag;
    [FieldOffset(0x0040)] public FString GdkStoreId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAddContentTableDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAddContentTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAddContentsBundleNameTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAddContentBundleNameTableDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAddContentsBundleNameTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAddContentsNameDispTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort ItemId;
    [FieldOffset(0x000A)] public ushort Category;
    [FieldOffset(0x0010)] public FString Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UAddContentNameDispTableDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FAddContentsNameDispTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FPoetryTexturePath
{
    [FieldOffset(0x0000)] public FString Blur;
    [FieldOffset(0x0010)] public FString Ef;
    [FieldOffset(0x0020)] public FString Normal;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FPoetryParamTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FPoetryTexturePath Type;
    [FieldOffset(0x0038)] public float PosX;
    [FieldOffset(0x003C)] public float PosY;
    [FieldOffset(0x0040)] public byte DrawPoint;
    [FieldOffset(0x0041)] public byte TextureNum;
    [FieldOffset(0x0044)] public float Scale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUIPoetryDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FPoetryParamTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FUITextTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString KewWord;
    [FieldOffset(0x0018)] public FString Text;
    [FieldOffset(0x0028)] public FString Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUITextDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FUITextTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPoetryRipplesParam
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float PosX;
    [FieldOffset(0x000C)] public float PosY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUIPoetryRippleDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FPoetryRipplesParam> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AUIDataInheritanceActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0288)] public UAssetLoader* Loader;
    [FieldOffset(0x0290)] public ADifficultySelectionActor* DifficultySelection;
    [FieldOffset(0x0298)] public TSubclassOf<ADifficultySelectionActor> DifficultySelectionSC;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7E0)] 
public unsafe struct AUIDateDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public UAgePanel* m_pAgePanel;
    [FieldOffset(0x02B0)] public USprAsset* m_pFieldSpr;
    [FieldOffset(0x07D0)] public UDataTable* LayoutData;
    [FieldOffset(0x07D8)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDayChangeRipple
{
    [FieldOffset(0x0000)] public FCurveLinearColorAnimation curveRipple;
}

[StructLayout(LayoutKind.Explicit, Size = 0xFA8)] 
public unsafe struct AUIDayChange
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02B8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02C0)] public UPlgAsset* m_pPlg;
    [FieldOffset(0x02C8)] public FGetUIParameter m_tagUip;
    [FieldOffset(0x0340)] public FDayChangeRipple m_tagRipple;
    [FieldOffset(0x0370)] public FDayChangeRipple m_tagLoadRipple;
    [FieldOffset(0x03A0)] public FCurveFloatAnimation m_curveInAnim;
    [FieldOffset(0x03D0)] public FCurveFloatAnimation m_curveInRectMaskAnim;
    [FieldOffset(0x0400)] public FCurveFloatAnimation m_curveCenterBlueBandMaskAnim;
    [FieldOffset(0x0430)] public FCurveFloatAnimation m_curve1DaySpeedAnim;
    [FieldOffset(0x0460)] public FCurveFloatAnimation m_curveSkipSpeedAnim;
    [FieldOffset(0x0490)] public FCurveFloatAnimation m_curveSuperSkipSpeedAnim;
    [FieldOffset(0x04C0)] public FCurveVectorAnimation m_curveCenterMoonAgeInOutAnim;
    [FieldOffset(0x04F0)] public FCurveVectorAnimation m_curveBigMoonAgeInOutAnim;
    [FieldOffset(0x0520)] public FCurveFloatAnimation m_curveCommonMoveAnim;
    [FieldOffset(0x0550)] public FCurveVectorAnimation m_curveDaysGroupInAnim;
    [FieldOffset(0x0580)] public FCurveVectorAnimation m_curveDayInAnim;
    [FieldOffset(0x05B0)] public FCurveVectorAnimation m_curveDayOutAnim;
    [FieldOffset(0x05E0)] public FCurveFloatAnimation m_curveBlueBandAnim;
    [FieldOffset(0x0610)] public FCurveVectorAnimation m_curveSkipMoonAgeFadeAnim;
    [FieldOffset(0x0640)] public UDataTable* m_pLayoutData;
    [FieldOffset(0x0648)] public UUILayoutDataTable* m_pLayoutDataParam;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FTestDebugNishidaBase
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FTestDebugNishida
{
    [FieldOffset(0x0000)] public FTestDebugNishidaBase baseObj;
    [FieldOffset(0x0008)] public FGetUIParameter uip;
    [FieldOffset(0x0080)] public FCurveFloatAnimation curveIceYScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x698)] 
public unsafe struct AUIDebugDraw
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0420)] public UAssetLoader* m_pMapLoader;
    [FieldOffset(0x0428)] public USprAsset* m_pSprAsset;
    [FieldOffset(0x0430)] public UMaterial* m_pMaterial;
    [FieldOffset(0x0438)] public UTexture* m_pTexture;
    [FieldOffset(0x0440)] public UMaterialInstanceDynamic* m_pMID;
    [FieldOffset(0x0448)] public APersonaStatus* m_pPersonaStatus;
    [FieldOffset(0x0450)] public UPlgAsset* m_pNotePlg;
    [FieldOffset(0x0458)] public FGetUIParameter m_uip;
    [FieldOffset(0x04D0)] public FGetUIParameter m_uipB;
    [FieldOffset(0x0548)] public FGetUIParameter m_uipC;
    [FieldOffset(0x05C0)] public FGetUIParameter m_uipD;
    [FieldOffset(0x0638)] public FCurveFloatAnimation m_curve;
    [FieldOffset(0x0668)] public TArray<FTestDebugNishida> m_aTestDebugNishidaList;
    [FieldOffset(0x0680)] public AScrActor* m_pScrActor;
    [FieldOffset(0x0688)] public UBfAsset* m_pBfAsset;
    [FieldOffset(0x0690)] public UBmdAsset* m_pBmdAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AUIDialogBase
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0298)] public FString DialogMessage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct AUIDialogDouble
{
    [FieldOffset(0x0000)] public AUIDialogBase baseObj;
    [FieldOffset(0x02E0)] public FString FirstChoices;
    [FieldOffset(0x02F0)] public FString SecondChoices;
    [FieldOffset(0x0308)] public ACmpMainActor* pCmpMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D0)] 
public unsafe struct AUIDialogSingle
{
    [FieldOffset(0x0000)] public AUIDialogBase baseObj;
    [FieldOffset(0x02C0)] public FString FirstChoices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x358)] 
public unsafe struct AUIDictionary
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public UAssetLoader* Loader;
    [FieldOffset(0x0280)] public UDataTable* DataTableAsset;
    [FieldOffset(0x0288)] public UDataTable* NameTableAsset;
    [FieldOffset(0x02F0)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x02F8)] public AUITutorialDraw* pTutorialDraw;
    [FieldOffset(0x0300)] public TSubclassOf<AUITutorialDraw> pTutorialDrawClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUIDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> Assets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UUIDrawGamerTag
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x948)] 
public unsafe struct AUIDungeonTransfer
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B0)] public UAssetLoader* Loader;
    [FieldOffset(0x02B8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02C0)] public USprAsset* m_pSpr_BG;
    [FieldOffset(0x02C8)] public UPlgAsset* m_pPlg;
    [FieldOffset(0x02D0)] public UDataTable* m_pTable;
    [FieldOffset(0x02D8)] public UDataTable* m_pLayoutData;
    [FieldOffset(0x02E0)] public UUIDungeonTransferData* m_Data;
    [FieldOffset(0x02E8)] public TSubclassOf<UUIDungeonTransferData> DataAsset;
    [FieldOffset(0x08E8)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FUIDungeonTransferCloudParam
{
    [FieldOffset(0x0000)] public int SprNo;
    [FieldOffset(0x0004)] public FVector Pos;
    [FieldOffset(0x0010)] public FVector Scale;
    [FieldOffset(0x001C)] public float Speed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FUIDungeonTransferHazeParam
{
    [FieldOffset(0x0000)] public int Num;
    [FieldOffset(0x0004)] public FVector Pos;
    [FieldOffset(0x0010)] public FVector Scale;
    [FieldOffset(0x001C)] public float Alpha;
    [FieldOffset(0x0020)] public float RotationSecond;
    [FieldOffset(0x0024)] public EUIDungeonTransferHazeDrawMode DrawMode;
    [FieldOffset(0x0028)] public int PresetNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x588)] 
public unsafe struct UUIDungeonTransferData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int ContentNum;
    [FieldOffset(0x002C)] public FVector FloorListPosWhen2_4;
    [FieldOffset(0x0038)] public FVector FloorListPosWhen5_8;
    [FieldOffset(0x0044)] public FVector FloorListScale;
    [FieldOffset(0x0050)] public float FloorListInterval;
    [FieldOffset(0x0054)] public FVector FloorListColorV0;
    [FieldOffset(0x0060)] public FVector FloorListColorV1;
    [FieldOffset(0x006C)] public FVector FloorListColorV2;
    [FieldOffset(0x0078)] public FVector FloorListColorV3;
    [FieldOffset(0x0084)] public FVector FloorListLightPosDif;
    [FieldOffset(0x0090)] public FVector FloorListLightScale;
    [FieldOffset(0x009C)] public FVector FloorListLightColor;
    [FieldOffset(0x00A8)] public FVector ScrollBarPosDif;
    [FieldOffset(0x00B4)] public float ScrollBarEnableY;
    [FieldOffset(0x00B8)] public FVector ScrollBarMinmamSize;
    [FieldOffset(0x00C4)] public FVector TarminalIconPosDif;
    [FieldOffset(0x00D0)] public FVector ListHeadPosDif;
    [FieldOffset(0x00DC)] public FVector FMarkPosDif;
    [FieldOffset(0x00E8)] public FVector FloorListSelectedColor;
    [FieldOffset(0x00F4)] public FVector FloorListNotSelectedColor;
    [FieldOffset(0x0100)] public FVector FloorNumWhen1PosDif;
    [FieldOffset(0x010C)] public FVector FloorNumDigit1PosDif;
    [FieldOffset(0x0118)] public FVector FloorNumDigit2PosDif;
    [FieldOffset(0x0124)] public FVector FloorNumDigit3PosDif;
    [FieldOffset(0x0130)] public FVector FloorEntrancePosDif;
    [FieldOffset(0x013C)] public FVector CurrentIconPosDif;
    [FieldOffset(0x0148)] public FVector CurrentIconSelectedColor;
    [FieldOffset(0x0154)] public FVector CurrentIconNotSelectedColor;
    [FieldOffset(0x0160)] public FVector DoorIconPosDif;
    [FieldOffset(0x016C)] public FVector HorizonPosDif;
    [FieldOffset(0x0178)] public FVector HorizonScale;
    [FieldOffset(0x0184)] public float HorizonAlpha;
    [FieldOffset(0x0188)] public FVector WhiteCursorPosDif;
    [FieldOffset(0x0194)] public FVector WhiteCursorScale;
    [FieldOffset(0x01A0)] public FVector WhiteCursorColor;
    [FieldOffset(0x01AC)] public FVector GreenCursorPosDif;
    [FieldOffset(0x01B8)] public FVector GreenCursorScale;
    [FieldOffset(0x01C4)] public FVector GreenCursorColor;
    [FieldOffset(0x01D0)] public FVector InfoPlatePos;
    [FieldOffset(0x01DC)] public FVector InfoPlateScale;
    [FieldOffset(0x01E8)] public FVector InfoPlateScaleWhenEntrance;
    [FieldOffset(0x01F4)] public FVector InfoPlateColor;
    [FieldOffset(0x0200)] public FVector InfoBlockNamePosDiff;
    [FieldOffset(0x020C)] public FVector InfoBlockHeadPosDiff;
    [FieldOffset(0x0218)] public float InfoBlockHeadAlpha;
    [FieldOffset(0x021C)] public FVector InfoBlockNumPosDiff;
    [FieldOffset(0x0228)] public FVector InfoBlockNumColorDarkColor;
    [FieldOffset(0x0234)] public FVector InfoBlockNumColorLightColor;
    [FieldOffset(0x0240)] public float InfoBlockNumColorLightAlpha;
    [FieldOffset(0x0244)] public FVector InfoBlockNumMaskPosDiff;
    [FieldOffset(0x0250)] public FVector InfoBlockNumMaskScale;
    [FieldOffset(0x025C)] public FVector InfoNameEntrancePosDiff;
    [FieldOffset(0x0268)] public FVector InfoNameFloor1PosDiff;
    [FieldOffset(0x0274)] public FVector InfoNameFloor2PosDiff;
    [FieldOffset(0x0280)] public FVector InfoNameFloor3PosDiff;
    [FieldOffset(0x028C)] public FVector InfoNameFloor4PosDiff;
    [FieldOffset(0x0298)] public FVector InfoNameFloor5PosDiff;
    [FieldOffset(0x02A4)] public FVector InfoNameFloor6PosDiff;
    [FieldOffset(0x02B0)] public FVector InfoNameColorDark;
    [FieldOffset(0x02BC)] public FVector InfoNameColorLight;
    [FieldOffset(0x02C8)] public FVector InfoMissHeadPos;
    [FieldOffset(0x02D4)] public FVector InfoMissUnitPosDiff;
    [FieldOffset(0x02E0)] public FVector InfoMissNumPosDiff;
    [FieldOffset(0x02EC)] public FVector InfoMiss0Color;
    [FieldOffset(0x02F8)] public FVector InfoTrianglePosDiff;
    [FieldOffset(0x0304)] public float InfoTriangleAlpha;
    [FieldOffset(0x0308)] public FVector InfoTriangleOutPosDiff;
    [FieldOffset(0x0314)] public float InfoTriangleOutAlpha;
    [FieldOffset(0x0318)] public FVector InfoExclamationPosDiff;
    [FieldOffset(0x0324)] public FVector CursorInAnimeMove;
    [FieldOffset(0x0330)] public int CursorInAnimeFrame;
    [FieldOffset(0x0334)] public FVector FloorNameAnimeMoveUp;
    [FieldOffset(0x0340)] public FVector FloorNameAnimeMoveDown;
    [FieldOffset(0x034C)] public int FloorNameAnimeFrame;
    [FieldOffset(0x0350)] public float InfoMissTriangleRotationSecond;
    [FieldOffset(0x0354)] public float FloorNameFadeInFrame;
    [FieldOffset(0x0358)] public float FloorNameFadeOutFrame;
    [FieldOffset(0x0360)] public TArray<FVector> BackGroundPos;
    [FieldOffset(0x0370)] public float BackGroundSelectUpY;
    [FieldOffset(0x0374)] public float BackGroundSelectDownY;
    [FieldOffset(0x0378)] public float BackGroundNotSelectUpY;
    [FieldOffset(0x037C)] public float BackGroundNotSelectDownY;
    [FieldOffset(0x0380)] public float DistantviewFrontSpeed;
    [FieldOffset(0x0384)] public float DistantviewBackSpeed;
    [FieldOffset(0x0388)] public float DistantviewInterval;
    [FieldOffset(0x038C)] public int DistantviewLoopXFront;
    [FieldOffset(0x0390)] public int DistantviewLoopXBack;
    [FieldOffset(0x0398)] public TArray<float> DistantviewPos;
    [FieldOffset(0x03A8)] public TArray<FVector> moonPos;
    [FieldOffset(0x03B8)] public TArray<float> MoonScale;
    [FieldOffset(0x03C8)] public FVector ColorMoonCloud;
    [FieldOffset(0x03D4)] public FVector TowerDownPos;
    [FieldOffset(0x03E0)] public FVector TowerMidPos;
    [FieldOffset(0x03EC)] public FVector TowerUpPos;
    [FieldOffset(0x03F8)] public FVector TowerTownPos;
    [FieldOffset(0x0404)] public FVector TowerColorDark;
    [FieldOffset(0x0410)] public FVector TowerColorLight;
    [FieldOffset(0x041C)] public float TowerTownMoveRation;
    [FieldOffset(0x0420)] public TArray<FVector> WindowPos;
    [FieldOffset(0x0430)] public float WomdowAlpha;
    [FieldOffset(0x0438)] public TArray<FUIDungeonTransferCloudParam> CloudFloor1;
    [FieldOffset(0x0448)] public TArray<FUIDungeonTransferCloudParam> CloudFloor2;
    [FieldOffset(0x0458)] public TArray<FUIDungeonTransferCloudParam> CloudFloor3;
    [FieldOffset(0x0468)] public TArray<FUIDungeonTransferCloudParam> CloudFloor4;
    [FieldOffset(0x0478)] public TArray<FUIDungeonTransferCloudParam> CloudFloor5;
    [FieldOffset(0x0488)] public TArray<FUIDungeonTransferCloudParam> CloudFloor6;
    [FieldOffset(0x0498)] public float CloudLoopDistance;
    [FieldOffset(0x04A0)] public TArray<FUIDungeonTransferHazeParam> HazeParam;
    [FieldOffset(0x04B0)] public float HazeFadeInSecond;
    [FieldOffset(0x04B4)] public float HazeAppearSecond;
    [FieldOffset(0x04B8)] public float HazeWaitSecond;
    [FieldOffset(0x04BC)] public float HazeVanishSecondMin;
    [FieldOffset(0x04C0)] public float HazeVanishSecondMax;
    [FieldOffset(0x04C4)] public float HazeAppearSecondMin;
    [FieldOffset(0x04C8)] public float HazeAppearSecondMax;
    [FieldOffset(0x04CC)] public float HazeAllRotationMin;
    [FieldOffset(0x04D0)] public float HazeAllRotationMax;
    [FieldOffset(0x04D4)] public float HazeInitRMax;
    [FieldOffset(0x04D8)] public float HazeMoveMin;
    [FieldOffset(0x04DC)] public float HazeMoveMax;
    [FieldOffset(0x04E0)] public float HazeInitScaleMin;
    [FieldOffset(0x04E4)] public float HazeInitScaleMax;
    [FieldOffset(0x04E8)] public float HazeInitAlphaMin;
    [FieldOffset(0x04EC)] public float HazeInitAlphaMax;
    [FieldOffset(0x04F0)] public float HazeHiddenPosUpY;
    [FieldOffset(0x04F4)] public float HazeHiddenPosDownY;
    [FieldOffset(0x04F8)] public TArray<FVector> RedHazePos;
    [FieldOffset(0x0508)] public float RedHazeWholeTime;
    [FieldOffset(0x050C)] public int RedHazeSprMin;
    [FieldOffset(0x0510)] public int RedHazeSprMax;
    [FieldOffset(0x0514)] public int RedHazeNumMin;
    [FieldOffset(0x0518)] public int RedHazeNumMax;
    [FieldOffset(0x051C)] public float RedHazeInitRMax;
    [FieldOffset(0x0520)] public float RedHazeInitScaleMin;
    [FieldOffset(0x0524)] public float RedHazeInitScaleMax;
    [FieldOffset(0x0528)] public int RedHazeAddNumMin;
    [FieldOffset(0x052C)] public int RedHazeAddNumMax;
    [FieldOffset(0x0530)] public float RedHazeAddInitRMax;
    [FieldOffset(0x0534)] public float RedHazeAddInitScaleMin;
    [FieldOffset(0x0538)] public float RedHazeAddInitScaleMax;
    [FieldOffset(0x0540)] public TArray<float> RedHazeAddInitRationStart;
    [FieldOffset(0x0550)] public TArray<float> RedHazeAddInitRationEnd;
    [FieldOffset(0x0560)] public float RedHazeFadeSecond;
    [FieldOffset(0x0564)] public int BGAnimChangeWholeFrame;
    [FieldOffset(0x0568)] public int BGAnimChangeDistantviewFrame;
    [FieldOffset(0x056C)] public int BGAnimChangeMoonFrame;
    [FieldOffset(0x0570)] public int BGAnimChangeCloudFadeOutFrame;
    [FieldOffset(0x0574)] public int BGAnimChangeCloudFadeInFrame;
    [FieldOffset(0x0578)] public int ScreenFadeInFrame;
    [FieldOffset(0x057C)] public int ScreenFadeOutFrame;
    [FieldOffset(0x0580)] public int ScreenFadeOutCancelFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0xEF0)] 
public unsafe struct FFieldHeadPanel
{
    [FieldOffset(0x0000)] public FBaseHeadPanel baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AUIFieldPartyPanel
{
    [FieldOffset(0x0000)] public ABasePartyPanel baseObj;
    [FieldOffset(0x02C0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02C8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02D0)] public TArray<FFieldHeadPanel> m_aHeadPanelList;
    [FieldOffset(0x02E0)] public UPartyPanelRecoveryEffect* m_pRecoveryEffect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUIFieldType
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FGameOverPoemContent
{
    [FieldOffset(0x0060)] public UTexture* m_pEfTex;
    [FieldOffset(0x0068)] public UTexture* m_pNormalTex;
    [FieldOffset(0x0070)] public UMaterialInstanceDynamic* pMatNormal;
    [FieldOffset(0x0078)] public UMaterialInstanceDynamic* pMatEf;
}

[StructLayout(LayoutKind.Explicit, Size = 0x560)] 
public unsafe struct AUIGameOverPoem
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public FGameOverPoemContent poem;
    [FieldOffset(0x04B8)] public UMaterialInstanceDynamic* ripple;
    [FieldOffset(0x04D0)] public FVector2D openRipplesPos;
    [FieldOffset(0x04E8)] public float openRipplesSize;
    [FieldOffset(0x0508)] public UAssetLoader* pLoader;
    [FieldOffset(0x0510)] public UUIPoetryDataAsset* PoetryData_;
    [FieldOffset(0x0518)] public UMaterialInstance* pMaterial;
    [FieldOffset(0x0520)] public UMaterialInstance* pRippleMat;
    [FieldOffset(0x0528)] public AUICmmRankUPAnimManager* AnimManager;
    [FieldOffset(0x0530)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0538)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct AUIGenericSelect
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02F8)] public UGenericSelectSystemBase* System_;
    [FieldOffset(0x0300)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0308)] public TSubclassOf<AUIGenericSelectDraw> pDrawClass;
    [FieldOffset(0x0310)] public AUIGenericSelectDraw* pDrawActor;
    [FieldOffset(0x0318)] public UDataTable* LayoutData;
    [FieldOffset(0x0320)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGenericSelectCharacterTextureItem
{
    [FieldOffset(0x0000)] public uint characterId;
    [FieldOffset(0x0008)] public UTexture* pTexture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGenericSelectCharacterDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FGenericSelectCharacterTextureItem> Assets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UUIGenericSelectCharacter
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct AUIGenericSelectDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public FVector2D Edit_PointA;
    [FieldOffset(0x02C0)] public FVector2D Edit_PointD;
    [FieldOffset(0x02C8)] public FVector2D Edit_PointG;
    [FieldOffset(0x02D0)] public FVector2D Edit_PointH;
    [FieldOffset(0x02D8)] public float Edit_TitleLogo_LoopAnima_Offset_Min;
    [FieldOffset(0x02DC)] public float Edit_TitleLogo_LoopAnima_Offset_Max;
    [FieldOffset(0x02E0)] public float Edit_Character_LoopAnima_Offset_Min;
    [FieldOffset(0x02E4)] public float Edit_Character_LoopAnima_Offset_Max;
    [FieldOffset(0x02E8)] public int Edit_Cursor_AnimationFrame;
    [FieldOffset(0x02EC)] public int Edit_SubCursor_AnimationFrame;
    [FieldOffset(0x02F0)] public int Edit_InAnimation_1_1;
    [FieldOffset(0x02F4)] public int Edit_InAnimation_1_1_2;
    [FieldOffset(0x02F8)] public int Edit_InAnimation_1_3;
    [FieldOffset(0x02FC)] public int Edit_InAnimation_1_3_CharacterMask_DelayFrame;
    [FieldOffset(0x0300)] public int Edit_InAnimation_1_4_ListItem_InFrame;
    [FieldOffset(0x0304)] public int Edit_InAnimation_1_4_ListItem_DelayFrame;
    [FieldOffset(0x0308)] public int Edit_InAnimation_1_4_Cursor_InFrame;
    [FieldOffset(0x030C)] public int Edit_InAnimation_1_4_Cursor_DelayFrame;
    [FieldOffset(0x0310)] public int Edit_LoopAnima_Frame_Min;
    [FieldOffset(0x0314)] public int Edit_LoopAnima_Frame_Max;
    [FieldOffset(0x0318)] public int Edit_OutAnimation_3_1;
    [FieldOffset(0x031C)] public int Edit_CharacterChange_In_Frame;
    [FieldOffset(0x0320)] public int Edit_CharacterChange_Out_Frame;
    [FieldOffset(0x0324)] public int Edit_CharacterChange_Slide_Frame;
    [FieldOffset(0x0328)] public FColor Edit_TitleLogo_MorninColor;
    [FieldOffset(0x032C)] public FColor Edit_TitleLogo_AfterschoolColor;
    [FieldOffset(0x0330)] public FColor Edit_TitleLogo_NightColor;
    [FieldOffset(0x0334)] public FColor Edit_ListAndCharacter_MorninColor;
    [FieldOffset(0x0338)] public FColor Edit_ListAndCharacter_AfterschoolColor;
    [FieldOffset(0x033C)] public FColor Edit_ListAndCharacter_NightColor;
    [FieldOffset(0x0340)] public FColor Edit_CharacterBackPlate_MorninColor;
    [FieldOffset(0x0344)] public FColor Edit_CharacterBackPlate_AfterschoolColor;
    [FieldOffset(0x0348)] public FColor Edit_CharacterBackPlate_NightColor;
    [FieldOffset(0x0350)] public USprAsset* pSprAsset;
    [FieldOffset(0x0358)] public UPlgAsset* pPlgAsset;
    [FieldOffset(0x0360)] public UGenericSelectCharacterDataAsset* pCharacterDataAsset;
    [FieldOffset(0x03E0)] public UGenericSelectSystemBase* PSystem;
    [FieldOffset(0x03E8)] public TArray<IntPtr> CharacterEnableList;
    [FieldOffset(0x03F8)] public TArray<IntPtr> CharacterDisableList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2768)] 
public unsafe struct AUIGetCommunityPointDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A0)] public USprAsset* m_pSpr;
    [FieldOffset(0x02A8)] public UPlgAsset* m_pNotePlg;
    [FieldOffset(0x02B0)] public UNiagaraSystem* m_pRankUpEffect;
    [FieldOffset(0x02B8)] public UNiagaraSystem* m_pRankUpFinishEffect;
    [FieldOffset(0x02C0)] public UNiagaraComponent* m_pRankUpEffectComponent;
    [FieldOffset(0x02C8)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02D0)] public FGetUIParameter m_tagGetUIP;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E0)] 
public unsafe struct FPointUpNote
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xD20)] 
public unsafe struct AUIGetHeroParameterDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A0)] public USprAsset* m_pEffSpr;
    [FieldOffset(0x02A8)] public UPlgAsset* m_pNotePlg;
    [FieldOffset(0x02B0)] public UNiagaraSystem* m_pRankUpEffect;
    [FieldOffset(0x02B8)] public UNiagaraSystem* m_pRankUpFinishEffect;
    [FieldOffset(0x02C0)] public UNiagaraComponent* m_pRankUpEffectComponent;
    [FieldOffset(0x02C8)] public FGetUIParameter m_tagGetUIP;
    [FieldOffset(0x0350)] public FPointUpNote m_tagNote;
    [FieldOffset(0x0D00)] public UCmpHeroHumanStatusDraw* pHumanParamDraw_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AUIHeroParameterStatus
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02A8)] public AUIHeroParameterStatusDraw* m_pHeroParamDrawActor;
    [FieldOffset(0x02B0)] public TSubclassOf<AUIHeroParameterStatusDraw> m_pHeroParamDrawActorSC;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AUIHeroParameterStatusDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E0)] 
public unsafe struct AUIKeyHelpDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUILayoutDataTable
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UDataTable* LayoutTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B0)] 
public unsafe struct AUISaveLoad
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x02D8)] public UAddContent* AddContentCheck;
    [FieldOffset(0x02E0)] public UAssetLoader* Loader;
    [FieldOffset(0x02E8)] public UUILayoutDataTable* SaveLoadLayoutDataTable;
    [FieldOffset(0x02F0)] public UUILayoutDataTable* SaveLoadLayoutDataTable2;
    [FieldOffset(0x02F8)] public UUILayoutDataTable* SaveLoadDateLayoutDataTable;
    [FieldOffset(0x0300)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0308)] public UDataTable* pParamLayoutData2;
    [FieldOffset(0x0310)] public UDataTable* pParamDateLayoutData;
    [FieldOffset(0x0338)] public AUISystemMsgActor* NetworkConnectionDialog;
    [FieldOffset(0x0340)] public UXrd777SaveManager* SaveManagerInst;
    [FieldOffset(0x0348)] public TSubclassOf<ASaveLoadDraw> DrawActorSC;
    [FieldOffset(0x0350)] public ASaveLoadDraw* DrawActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B8)] 
public unsafe struct AUILoadDialog
{
    [FieldOffset(0x0000)] public AUISaveLoad baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldShortcutData
{
    [FieldOffset(0x0000)] public short mShortcutIndex;
    [FieldOffset(0x0008)] public FString mName;
    [FieldOffset(0x0018)] public bool mEnable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct FShortcutItem
{
    [FieldOffset(0x0000)] public FFldShortcutData Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x358)] 
public unsafe struct UUILocationSelect
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public USprAsset* m_pMiniMapSpr;
    [FieldOffset(0x0050)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0058)] public FGetUIParameter m_tagUip;
    [FieldOffset(0x00D0)] public TArray<FShortcutItem> m_aShortcutList;
    [FieldOffset(0x0308)] public UDataTable* m_pLayoutData;
    [FieldOffset(0x0310)] public UUILayoutDataTable* m_pLayoutDataTable;
    [FieldOffset(0x0318)] public UDataTable* m_pLayoutData2;
    [FieldOffset(0x0320)] public UUILayoutDataTable* m_pLayoutDataTable2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct AUIMailIconDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public USprAsset* Sprite_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10A8)] 
public unsafe struct UMiniMapAssetLoader
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x0030)] public bool bLoadedFlag;
    [FieldOffset(0x0038)] public UTexture* pMapTex;
    [FieldOffset(0x0040)] public UMiniMapIconListTable* pFldMiniMapIconTable;
    [FieldOffset(0x0048)] public UTexture* pMapParts;
    [FieldOffset(0x0458)] public UTexture* pWallTex;
    [FieldOffset(0x0460)] public USprAsset* pPartMaskSpr;
    [FieldOffset(0x0468)] public EFldType EFldType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF810)] 
public unsafe struct UUIMiniMapDraw
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0058)] public USprAsset* m_pMiniMapIcon00Spr;
    [FieldOffset(0x0060)] public USprAsset* m_pMiniMapIcon01Spr;
    [FieldOffset(0x0068)] public USprAsset* m_pPartMaskSpr;
    [FieldOffset(0x0070)] public USprAsset* m_pNoiseSpr;
    [FieldOffset(0x0078)] public UTexture* m_pMapTex;
    [FieldOffset(0x0080)] public UTexture* m_pPrevMapTex1;
    [FieldOffset(0x0088)] public UTexture* m_pPrevMapTex2;
    [FieldOffset(0x0090)] public UTexture* m_pPrevMapTex3;
    [FieldOffset(0x0098)] public UMaterial* m_pVelvetRoomIconMat;
    [FieldOffset(0x00A0)] public UMaterialInstanceDynamic* m_pVelvetRoomIconMID;
    [FieldOffset(0x00A8)] public UMiniMapIconListTable* m_pFldMiniMapIconTable;
    [FieldOffset(0x00B0)] public UAssetLoader* m_pIconLoader;
    [FieldOffset(0x00B8)] public UAssetLoader* m_pMapLoader;
    [FieldOffset(0x00C0)] public TArray<IntPtr> m_pMapLoaders;
    [FieldOffset(0xF250)] public UTexture* m_pMapParts;
    [FieldOffset(0xF660)] public UTexture* m_pWallTex;
    [FieldOffset(0xF668)] public UFldDungeonPartVariationDataAsset* m_pPartVariationDataAsset;
    [FieldOffset(0xF760)] public UDataTable* m_pSchoolUpDownLayoutData;
    [FieldOffset(0xF768)] public UUILayoutDataTable* m_pSchoolUpDownLayoutDataTable;
    [FieldOffset(0xF770)] public UDataTable* m_pDormitoryUpDownLayoutData;
    [FieldOffset(0xF778)] public UUILayoutDataTable* m_pDormitoryUpDownLayoutDataTable;
    [FieldOffset(0xF780)] public UDataTable* m_pArcadeUpDownLayoutData;
    [FieldOffset(0xF788)] public UUILayoutDataTable* m_pArcadeUpDownLayoutDataTable;
    [FieldOffset(0xF790)] public UDataTable* m_pMallUpDownLayoutData;
    [FieldOffset(0xF798)] public UUILayoutDataTable* m_pMallUpDownLayoutDataTable;
    [FieldOffset(0xF7A0)] public UDataTable* m_pClubUpDownLayoutData;
    [FieldOffset(0xF7A8)] public UUILayoutDataTable* m_pClubUpDownLayoutDataTable;
    [FieldOffset(0xF7B0)] public UDataTable* m_pRyokanUpDownLayoutData;
    [FieldOffset(0xF7B8)] public UUILayoutDataTable* m_pRyokanUpDownLayoutDataTable;
    [FieldOffset(0xF7C0)] public UDataTable* m_pHotelUpDownLayoutData;
    [FieldOffset(0xF7C8)] public UUILayoutDataTable* m_pHotelUpDownLayoutDataTable;
    [FieldOffset(0xF7D0)] public UDataTable* m_pDungeonUpDownLayoutData;
    [FieldOffset(0xF7D8)] public UUILayoutDataTable* m_pDungeonUpDownLayoutDataTable;
    [FieldOffset(0xF7E0)] public UDataTable* m_pIconLayoutData;
    [FieldOffset(0xF7E8)] public UUILayoutDataTable* m_pIconLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x11C0)] 
public unsafe struct AUIMiscCheckDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B8)] public USprAsset* m_pAlphaSpr;
    [FieldOffset(0x02C0)] public USprAsset* m_pKeySpr;
    [FieldOffset(0x02C8)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02D0)] public FCurveLinearColorAnimation m_tagMaxColorWave;
    [FieldOffset(0x0300)] public FGetUIParameter m_uip;
    [FieldOffset(0x1198)] public UDataTable* LayoutData;
    [FieldOffset(0x11A0)] public UDataTable* TextLayoutData;
    [FieldOffset(0x11A8)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x11B0)] public UUILayoutDataTable* TextLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B0)] 
public unsafe struct AUIMiscCinemaScopeDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02C0)] public USprAsset* m_pSpr_Cinema;
    [FieldOffset(0x02C8)] public UPlgAsset* m_pPlg_Cinema;
    [FieldOffset(0x03A8)] public UAssetLoader* Loader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3A8)] 
public unsafe struct AUIMiscEnemySymbolDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A0)] public USprAsset* m_pSpr;
    [FieldOffset(0x03A0)] public AActor* m_pEnemyRef;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE38)] 
public unsafe struct AUIMiscGetItemDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x0308)] public USprAsset* m_pGetItemSpr;
    [FieldOffset(0x0310)] public UPlgAsset* m_pGetPlg;
    [FieldOffset(0x0318)] public UDataTable* m_pItemGetDT;
    [FieldOffset(0x0320)] public USprAsset* m_pSpecialKeyHelpSpr;
    [FieldOffset(0x0328)] public USprAsset* m_pSpecialKeyHelpTextSpr;
    [FieldOffset(0x0330)] public UDataTable* m_pLayoutTextColDT;
    [FieldOffset(0x0338)] public UDataTable* m_pLayoutOkNextDT;
    [FieldOffset(0x0340)] public UDataTable* m_pLayoutOkNextMaskDT;
    [FieldOffset(0x0348)] public UUILayoutDataTable* m_pLayoutTextCol;
    [FieldOffset(0x0350)] public UUILayoutDataTable* m_pLayoutOkNext;
    [FieldOffset(0x0358)] public UUILayoutDataTable* m_pLayoutOkNextMask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x858)] 
public unsafe struct AUIMiscMoneyDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02D8)] public USprAsset* m_pMoneySpr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x520)] 
public unsafe struct AUIMiscPictureDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02C0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02C8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02D0)] public UTexture* m_pPicture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x458)] 
public unsafe struct UUIMiscSpecialKeyhelp
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0060)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0068)] public USprAsset* m_pSpecialKeyHelpSpr;
    [FieldOffset(0x0070)] public USprAsset* m_pSpecialKeyHelpTextSpr;
    [FieldOffset(0x0078)] public UDataTable* m_pDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7F8)] 
public unsafe struct AUIMiscSupportPartyPanel
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02B0)] public UDataTable* m_pSupportPartyPanelDT;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FMissingParamTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int PlateQuestInAllFrame;
    [FieldOffset(0x000C)] public int PlateQuestInStartFrame;
    [FieldOffset(0x0010)] public int PlateChangeAllFrame;
    [FieldOffset(0x0014)] public int PlateChangeStartFrame;
    [FieldOffset(0x0018)] public int PlateChangeOutAllFrame;
    [FieldOffset(0x001C)] public int PlateChangeOutStartFrame;
    [FieldOffset(0x0020)] public int ListChangeAllFrame;
    [FieldOffset(0x0024)] public int ListChangeStartFrame;
    [FieldOffset(0x0028)] public int AlphaBGNoCampAllFrame;
    [FieldOffset(0x002C)] public int AlphaBGNoCampStartFrame;
    [FieldOffset(0x0030)] public int BGPlateNoCampAllFrame;
    [FieldOffset(0x0034)] public int BGPlateNoCampStartFrame;
    [FieldOffset(0x0038)] public int MissingPlateNoCampAllFrame;
    [FieldOffset(0x003C)] public int MissingPlateNoCampStartFrame;
    [FieldOffset(0x0040)] public int ListNoCampAllFrame;
    [FieldOffset(0x0044)] public int ListNoCampStartFrame;
    [FieldOffset(0x0048)] public int DetailInPlateAllFrame;
    [FieldOffset(0x004C)] public int DetailInPlateStartFrame;
    [FieldOffset(0x0050)] public int DetailInInfoAllFrame;
    [FieldOffset(0x0054)] public int DetailInInfoStartFrame;
    [FieldOffset(0x0058)] public int DetailInCursorAllFrame;
    [FieldOffset(0x005C)] public int DetailInCursorStartFrame;
    [FieldOffset(0x0060)] public int DetailInMoreInfoAllFrame;
    [FieldOffset(0x0064)] public int DetailInMoreInfoStartFrame;
    [FieldOffset(0x0068)] public int DetailInNotSelectAllFrame;
    [FieldOffset(0x006C)] public int DetailInNotSelectStartFrame;
    [FieldOffset(0x0070)] public int DetailInCompleteAllFrame;
    [FieldOffset(0x0074)] public int DetailInCompleteStartFrame;
    [FieldOffset(0x0078)] public int DetailOutPlateAllFrame;
    [FieldOffset(0x007C)] public int DetailOutPlateStartFrame;
    [FieldOffset(0x0080)] public int DetailOutInfoAllFrame;
    [FieldOffset(0x0084)] public int DetailOutInfoStartFrame;
    [FieldOffset(0x0088)] public int DetailOutCursorAllFrame;
    [FieldOffset(0x008C)] public int DetailOutCursorStartFrame;
    [FieldOffset(0x0090)] public int DetailOutMoreInfoAllFrame;
    [FieldOffset(0x0094)] public int DetailOutMoreInfoStartFrame;
    [FieldOffset(0x0098)] public int DetailOutNotSelectAllFrame;
    [FieldOffset(0x009C)] public int DetailOutNotSelectStartFrame;
    [FieldOffset(0x00A0)] public int DetailOutCompleteAllFrame;
    [FieldOffset(0x00A4)] public int DetailOutCompleteStartFrame;
    [FieldOffset(0x00A8)] public int DetailShowPrevContentFrame;
    [FieldOffset(0x00AC)] public int DetailChangeInfoAllFrame;
    [FieldOffset(0x00B0)] public int DetailChangeInfoStartFrame;
    [FieldOffset(0x00B4)] public int DetailChangeCompleteAllFrame;
    [FieldOffset(0x00B8)] public int DetailChangeCompleteStartFrame;
    [FieldOffset(0x00BC)] public int SortPrevAllFrame;
    [FieldOffset(0x00C0)] public int SortPrevStartFrame;
    [FieldOffset(0x00C4)] public int SortNewAllFrame;
    [FieldOffset(0x00C8)] public int SortNewStartFrame;
    [FieldOffset(0x00CC)] public int SortListAllFrame;
    [FieldOffset(0x00D0)] public int SortListStartFrame;
    [FieldOffset(0x00D4)] public float PlateWhenMissingX;
    [FieldOffset(0x00D8)] public float PlateWhenMissingY;
    [FieldOffset(0x00DC)] public float PlateWhenQuestX;
    [FieldOffset(0x00E0)] public float PlateWhenQuestY;
    [FieldOffset(0x00E4)] public float PlateInY;
    [FieldOffset(0x00E8)] public float TatumiY;
    [FieldOffset(0x00EC)] public float CursorRedInAllFrame;
    [FieldOffset(0x00F0)] public float CursorRedInStartFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0xBF8)] 
public unsafe struct UUIMissingPerson
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0408)] public USprAsset* pSpr_;
    [FieldOffset(0x0410)] public UAssetLoader* pLoader_;
    [FieldOffset(0x0418)] public UMaterialInterface* m_pBGMat;
    [FieldOffset(0x0420)] public UMaterialInstanceDynamic* m_pBGMatInst;
    [FieldOffset(0x0428)] public UDataTable* m_pDT;
    [FieldOffset(0x0430)] public FMissingParamTableRow ParamDT;
    [FieldOffset(0x0528)] public UWorld* pRefWorld_;
    [FieldOffset(0x0B60)] public UUILayoutDataTable* LayoutData;
    [FieldOffset(0x0B68)] public UUILayoutDataTable* TextColLayoutData;
    [FieldOffset(0x0B70)] public UUILayoutDataTable* TextPosLayoutData;
    [FieldOffset(0x0B78)] public UUILayoutDataTable* DateLayoutData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AUIMissingPersonActor
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AModelCaptureUpdater
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public APreviewWorldUpdater* PreviewWorldUpdater_;
    [FieldOffset(0x0280)] public AActor* TargetActor_;
    [FieldOffset(0x0288)] public UMaterialParameterCollection* LightSource_;
    [FieldOffset(0x0298)] public UObject* BlueprintClass_;
    [FieldOffset(0x02A0)] public UAssetLoader* Loader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AUIMorphTestActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UUimAsset* m_pUimMain;
    [FieldOffset(0x0228)] public UUimAsset* mpUimSubAry;
    [FieldOffset(0x0250)] public UUimAsset* m_pUimCross;
    [FieldOffset(0x0258)] public UUimAsset* m_pUimColor;
    [FieldOffset(0x0260)] public UUimAsset* m_pUimUV;
    [FieldOffset(0x0268)] public UUimAsset* m_pUimPoly;
    [FieldOffset(0x0270)] public UUimAsset* m_pUimUVCol;
    [FieldOffset(0x0278)] public UTexture* m_TexMain;
    [FieldOffset(0x0280)] public UTexture* m_TexSubAry;
    [FieldOffset(0x02A8)] public UTexture* m_TexMask;
    [FieldOffset(0x02B0)] public USprAsset* m_pSpr;
    [FieldOffset(0x02D8)] public ACameraActor* pMayaCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct ANameEntry
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02E8)] public UAssetLoader* Loader_;
    [FieldOffset(0x02F0)] public AScrActor* ScrActor_;
    [FieldOffset(0x02F8)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x0300)] public UBfAsset* BfAsset_;
    [FieldOffset(0x0308)] public UNameEntryCnvCharDataAsset* CnvCharDataAsset_;
    [FieldOffset(0x0320)] public TSubclassOf<AUINameEntryDraw> NameEntryDrawSubClass;
    [FieldOffset(0x0328)] public AUINameEntryDraw* pNameEntryDrawActor;
    [FieldOffset(0x0348)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0350)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x360)] 
public unsafe struct AUINameEntryDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02D0)] public bool bIsStartInAnim;
    [FieldOffset(0x02D1)] public bool bIsFinishInAnim;
    [FieldOffset(0x02D2)] public bool bIsStartOutAnim;
    [FieldOffset(0x02D3)] public bool bIsFinishOutAnim;
    [FieldOffset(0x02D4)] public bool bIsKeyOutAnim;
    [FieldOffset(0x02D5)] public bool bReturnSceneOptionAnim;
    [FieldOffset(0x02D8)] public USprAsset* SprData;
    [FieldOffset(0x02E0)] public int OffStartFrame;
    [FieldOffset(0x02E4)] public int InFirstStartFrame;
    [FieldOffset(0x02E8)] public int InSecondStartFrame;
    [FieldOffset(0x02EC)] public int InThirdStartFrame;
    [FieldOffset(0x02F0)] public int InFourthStartFrame;
    [FieldOffset(0x02F4)] public int InFirstEndFrame;
    [FieldOffset(0x02F8)] public int InSecondEndFrame;
    [FieldOffset(0x02FC)] public int InThirdEndFrame;
    [FieldOffset(0x0300)] public int InFourthEndFrame;
    [FieldOffset(0x0304)] public int OutFirstStartFrame;
    [FieldOffset(0x0308)] public int OutSecondStartFrame;
    [FieldOffset(0x030C)] public int OutFirstEndFrame;
    [FieldOffset(0x0310)] public int OutSecondEndFrame;
    [FieldOffset(0x0358)] public UUILayoutDataTable* pLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FUIParameter
{
    [FieldOffset(0x0000)] public float Value;
    [FieldOffset(0x0008)] public FString Key;
    [FieldOffset(0x0018)] public FString Info;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UUIParameterAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FUIParameter> UIParameters;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2D8)] 
public unsafe struct AUIPartyPanel
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public USprAsset* m_pPartyPanelSpr;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct AUIPersonaModelActor
{
    [FieldOffset(0x0000)] public APawn baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct APersonaPreviewWorldUpdater
{
    [FieldOffset(0x0000)] public APreviewWorldUpdater baseObj;
    [FieldOffset(0x0330)] public bool IsPlaying;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct APersonaModelCaptureUpdater
{
    [FieldOffset(0x0000)] public AModelCaptureUpdater baseObj;
    [FieldOffset(0x02B8)] public TArray<IntPtr> DataAssets_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x640)] 
public unsafe struct APersonaStatus
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0520)] public UPersonaStatusSeq* Sequence_;
    [FieldOffset(0x0538)] public TArray<FPersonaStatusListItem> PersonaList;
    [FieldOffset(0x0548)] public TArray<FPersonaStatusListItem> RegistList;
    [FieldOffset(0x0580)] public APersonaStatusDraw* pPersonaStatusDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x900)] 
public unsafe struct APersonaStatusDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public bool IsMemoryCheckPersonaModel;
    [FieldOffset(0x02D8)] public int Edit_L1R1_Loop_Animation_Frame;
    [FieldOffset(0x02DC)] public int Edit_L1R1_Push_Animation_Frame;
    [FieldOffset(0x02E0)] public int Edit_Flickering_Loop_Frame;
    [FieldOffset(0x02E4)] public int Edit_Persona_Change_SlideIn_Frame;
    [FieldOffset(0x02E8)] public float Edit_Persona_Change_Slide_Value;
    [FieldOffset(0x02EC)] public EPERSONA_STATUS_DRAW_SCENE Scene;
    [FieldOffset(0x02F0)] public UMaterialInstanceDynamic* pBackgroundMaterial;
    [FieldOffset(0x03A8)] public APersonaModelCaptureUpdater* ModelCaptureUpdater;
    [FieldOffset(0x03B0)] public int Edit_Background_FadeIn_Frame;
    [FieldOffset(0x03B4)] public int Edit_Caustics_SlideIn_Delay;
    [FieldOffset(0x03B8)] public int Edit_Caustics_SlideIn_Frame;
    [FieldOffset(0x03BC)] public int Edit_Caustics_RectMask_ScaleUp_Delay;
    [FieldOffset(0x03C0)] public int Edit_Caustics_RectMask_ScaleUp_Frame;
    [FieldOffset(0x03C4)] public int Edit_PersonaInfo_SlideIn_Delay;
    [FieldOffset(0x03C8)] public int Edit_PersonaInfo_SlideIn_Frame;
    [FieldOffset(0x03CC)] public int Edit_Attribute_Effect_Frame;
    [FieldOffset(0x03D0)] public int Edit_SkillList_SlideIn_Delay;
    [FieldOffset(0x03D4)] public int Edit_SkillList_SlideIn_Frame;
    [FieldOffset(0x03D8)] public int Edit_Parameter_SlideIn_Delay;
    [FieldOffset(0x03DC)] public int Edit_Parameter_SlideIn_Frame;
    [FieldOffset(0x03E0)] public int Edit_Persona_SlideIn_Delay;
    [FieldOffset(0x03E4)] public int Edit_Persona_SlideIn_Frame;
    [FieldOffset(0x042C)] public int Edit_Parameter_Gage_Animation_Frame;
    [FieldOffset(0x0430)] public int Edit_Parameter_Gage_Animation_Delay;
    [FieldOffset(0x0434)] public int Edit_Parameter_UpGage_Animation_Frame;
    [FieldOffset(0x0438)] public int Edit_Parameter_Incense_Value_FadeIn_Frame;
    [FieldOffset(0x0484)] public int Edit_LevelUp_SlideIn_Frame;
    [FieldOffset(0x0488)] public int Edit_LevelUp_Plate_FadeOut_Frame;
    [FieldOffset(0x05A0)] public int Edit_SkillAdd_Next_Skill_Start_Delay;
    [FieldOffset(0x05A4)] public float Edit_SkillAdd_Next_Skill_Plate_Color_Fade_Wait;
    [FieldOffset(0x05A8)] public float Edit_SkillAdd_Next_Skill_Plate_Color_Fade_Time;
    [FieldOffset(0x05AC)] public int Edit_SkillAdd_Next_Skill_Move_Frame;
    [FieldOffset(0x05B0)] public int Edit_SkillAdd_Next_Skill_In_Frame;
    [FieldOffset(0x05B4)] public int Edit_SkillAdd_Next_Skill_New_Slide_In_Frame;
    [FieldOffset(0x05B8)] public int Edit_SkillAdd_Next_Skill_New_Fade_In_Frame;
    [FieldOffset(0x05E8)] public int Edit_Conception_Level3_LoopAnimation_Frame;
    [FieldOffset(0x05EC)] public int Edit_Conception_Level1_LoopAnimation_Frame;
    [FieldOffset(0x05F0)] public int Edit_Conception_GetEffect_Scale_Frame;
    [FieldOffset(0x05F4)] public int Edit_Conception_GetEffect_FadeOut_Delay;
    [FieldOffset(0x05F8)] public int Edit_Conception_GetEffect_FadeOut_Frame;
    [FieldOffset(0x05FC)] public int Edit_Conception_Icon_Get_FadeOut_Delay;
    [FieldOffset(0x0600)] public int Edit_Conception_Icon_Get_FadeOut_Frame;
    [FieldOffset(0x0614)] public int Edit_SkillCard_FadeIn_Frame;
    [FieldOffset(0x0618)] public int Edit_SkillCard_SlideIn_Frame;
    [FieldOffset(0x061C)] public int Edit_SkillCard_Used_FadeOut_Frame;
    [FieldOffset(0x0620)] public int Edit_SkillCard_Used_SlideeOut_Frame;
    [FieldOffset(0x0624)] public int Edit_SkillCard_Used_Plate_AddEffect_Frame;
    [FieldOffset(0x0628)] public int Edit_SkillCard_Used_Plate_LoopAnimation_Frame;
    [FieldOffset(0x062C)] public int Edit_SkillCard_Used_GetIcon_SlideIn_Frame;
    [FieldOffset(0x0648)] public int Edit_ChangeSkill_Skill_Name_Color_LoopAnimation_Frame;
    [FieldOffset(0x064C)] public int Edit_ChangeSkill_1Effect_Delay;
    [FieldOffset(0x0650)] public int Edit_ChangeSkill_BluePlate_SlideIn_Frame;
    [FieldOffset(0x0654)] public int Edit_ChangeSkill_BluePlate_Slide_Wait_Frame;
    [FieldOffset(0x0658)] public int Edit_ChangeSkill_BluePlate_SlideOut_Frame;
    [FieldOffset(0x065C)] public int Edit_ChangeSkill_Change_Font_SlideIn_Delay;
    [FieldOffset(0x0660)] public int Edit_ChangeSkill_Change_Font_SlideIn_Frame;
    [FieldOffset(0x0664)] public int Edit_ChangeSkill_Change_Font_Slide_Wait_Frame;
    [FieldOffset(0x0668)] public int Edit_ChangeSkill_Change_Font_SlideOut_Frame;
    [FieldOffset(0x066C)] public int Edit_ChangeSkill_Change_Font_FadeIn_Delay;
    [FieldOffset(0x0670)] public int Edit_ChangeSkill_Change_Font_FadeIn_Frame;
    [FieldOffset(0x0674)] public int Edit_ChangeSkill_Change_Font_Fade_Wait_Frame;
    [FieldOffset(0x0678)] public int Edit_ChangeSkill_Change_Font_FadeOut_Frame;
    [FieldOffset(0x067C)] public int Edit_ChangeSkill_ChangeIcon_FadeIn_Frame;
    [FieldOffset(0x0680)] public int Edit_ChangeSkill_ChangeIcon_SlideIn_Frame;
    [FieldOffset(0x06A8)] public int Edit_SkillInfo_SlideIn_Frame;
    [FieldOffset(0x06AC)] public int Edit_SkillInfo_FadeIn_Frame;
    [FieldOffset(0x06B0)] public int Edit_SkillInfo_SlideOut_Frame;
    [FieldOffset(0x06B4)] public int Edit_SkillInfo_FadeOut_Frame;
    [FieldOffset(0x06B8)] public int Edit_SkillInfo_Cursor_FadeIn_Frame;
    [FieldOffset(0x06BC)] public int Edit_SkillInfo_Cursor_FadeOut_Frame;
    [FieldOffset(0x06C0)] public int Edit_SkillInfo_Cursor_Frame;
    [FieldOffset(0x06C4)] public int Edit_SkillInfo_SubCursor_Frame;
    [FieldOffset(0x072C)] public int Edit_AffinityCheck_Icon_Move_Frame;
    [FieldOffset(0x0730)] public int Edit_AffinityCheck_Icon_1_Move_Delay;
    [FieldOffset(0x0734)] public int Edit_AffinityCheck_Font_Delay;
    [FieldOffset(0x0738)] public int Edit_AffinityCheck_Font_Move_Frame;
    [FieldOffset(0x073C)] public int Edit_AffinityCheck_Font_1_Move_Delay;
    [FieldOffset(0x0740)] public int Edit_AffinityCheck_Font_FadeIn_Frame;
    [FieldOffset(0x0744)] public int Edit_AffinityCheck_Font_1_FadeIn_Delay;
    [FieldOffset(0x0750)] public int Edit_SkillSelectList_SlideIn_Delay;
    [FieldOffset(0x0754)] public int Edit_SkillSelectList_SlideIn_Frame;
    [FieldOffset(0x0758)] public int Edit_SkillSelectList_FadeIn_Delay;
    [FieldOffset(0x075C)] public int Edit_SkillSelectList_FadeIn_Frame;
    [FieldOffset(0x0760)] public int Edit_SkillSelectList_SlideOut_Delay;
    [FieldOffset(0x0764)] public int Edit_SkillSelectList_SlideOut_Frame;
    [FieldOffset(0x0768)] public int Edit_SkillSelectList_FadeOut_Delay;
    [FieldOffset(0x076C)] public int Edit_SkillSelectList_FadeOut_Frame;
    [FieldOffset(0x0770)] public int Edit_SkillSelectList_RectScale_Delay;
    [FieldOffset(0x0774)] public int Edit_SkillSelectList_RectScale_Frame;
    [FieldOffset(0x0778)] public int Edit_SkillSelectList_Cursor_FadeIn_Delay;
    [FieldOffset(0x077C)] public int Edit_SkillSelectList_Cursor_FadeIn_Frame;
    [FieldOffset(0x0780)] public int Edit_SkillSelectList_Cursor_SlideIn_Delay;
    [FieldOffset(0x0784)] public int Edit_SkillSelectList_Cursor_SlideIn_Frame;
    [FieldOffset(0x0788)] public int Edit_SkillSelectList_SubCursor_SlideIn_Frame;
    [FieldOffset(0x078C)] public int Edit_SkillSelectList_Cursor_Frame;
    [FieldOffset(0x0790)] public int Edit_SkillSelectList_SubCursor_Frame;
    [FieldOffset(0x0794)] public int Edit_SkillSelectList_Info_SlideIn_Frame;
    [FieldOffset(0x0798)] public int Edit_SkillSelectList_Info_FadeIn_Frame;
    [FieldOffset(0x079C)] public int Edit_SkillSelectList_Info_ChangeSlideIn_Frame;
    [FieldOffset(0x07A0)] public int Edit_SkillSelectList_Info_ChangeFadeIn_Frame;
    [FieldOffset(0x07A4)] public int Edit_Selected_Succession_Skill_SlideIn_Delay;
    [FieldOffset(0x07A8)] public int Edit_Selected_Succession_Skill_SlideIn_Frame;
    [FieldOffset(0x07AC)] public int Edit_Selected_Succession_Skill_FadeIn_Delay;
    [FieldOffset(0x07B0)] public int Edit_Selected_Succession_Skill_FadeIn_Frame;
    [FieldOffset(0x07E8)] public int Edit_Commentary_FadeIn_Frame;
    [FieldOffset(0x07EC)] public int Edit_Commentary_SlideIn_Frame;
    [FieldOffset(0x07F0)] public int Edit_Commentary_Persona_Slide_Delay;
    [FieldOffset(0x07F4)] public int Edit_Commentary_Persona_Slide_Frame;
    [FieldOffset(0x07F8)] public int Edit_Commentary_Info_FadeOut_Delay;
    [FieldOffset(0x07FC)] public int Edit_Commentary_Info_FadeOut_Frame;
    [FieldOffset(0x0800)] public int Edit_Commentary_SkillList_Move_Delay;
    [FieldOffset(0x0804)] public int Edit_Commentary_SkillList_Move_Frame;
    [FieldOffset(0x0808)] public int Edit_Commentary_Paramter_Move_Delay;
    [FieldOffset(0x080C)] public int Edit_Commentary_Paramter_Move_Frame;
    [FieldOffset(0x0810)] public int Edit_Commentary_Affinity_FadeOut_Delay;
    [FieldOffset(0x0814)] public int Edit_Commentary_Affinity_FadeOut_Frame;
    [FieldOffset(0x0818)] public int Edit_Commentary_Affinity_SlideOut_Delay;
    [FieldOffset(0x081C)] public int Edit_Commentary_Affinity_SlideOut_Frame;
    [FieldOffset(0x0820)] public int Edit_Commentary_Rect_ScaleUp_Delay;
    [FieldOffset(0x0824)] public int Edit_Commentary_Rect_ScaleUp_Frame;
    [FieldOffset(0x0828)] public int Edit_Commentary_Font_Change_Frame;
    [FieldOffset(0x0834)] public int Edit_Combine_CommuBonus_SlideIn_Frame;
    [FieldOffset(0x0838)] public int Edit_Combine_CommuBonus_Plate_FadeOut_Frame;
    [FieldOffset(0x083C)] public int Edit_Combine_CommuBonus_Font_FadeOut_Frame;
    [FieldOffset(0x0840)] public int Edit_Combine_CommuBonus_Fix_Point_ColorChange_Frame1;
    [FieldOffset(0x0844)] public int Edit_Combine_CommuBonus_Fix_Point_ColorChange_Frame2;
    [FieldOffset(0x0848)] public int Edit_Combine_CommuBonus_ColorChange_Frame;
    [FieldOffset(0x084C)] public int Edit_Combine_BonusExp_SlideIn_Delay;
    [FieldOffset(0x0850)] public int Edit_Combine_BonusExp_SlideIn_Frame;
    [FieldOffset(0x0854)] public int Edit_Combine_BonusExp_Fade_Frame;
    [FieldOffset(0x0870)] public int Edit_Registry_LockIcon_InAnimation_Delay;
    [FieldOffset(0x0874)] public int Edit_Registry_LockIcon_InAnimation_Frame;
    [FieldOffset(0x0878)] public int Edit_Registry_Switch_Heading_SlideOut_Delay;
    [FieldOffset(0x087C)] public int Edit_Registry_Switch_Heading_SlideOut_Frame;
    [FieldOffset(0x0880)] public int Edit_Registry_Switch_Heading_FadeOut_Delay;
    [FieldOffset(0x0884)] public int Edit_Registry_Switch_Heading_FadeOut_Frame;
    [FieldOffset(0x0888)] public int Edit_Registry_Switch_Heading_SlideIn_Delay;
    [FieldOffset(0x088C)] public int Edit_Registry_Switch_Heading_SlideIn_Frame;
    [FieldOffset(0x0890)] public int Edit_Registry_Switch_Heading_FadeIn_Delay;
    [FieldOffset(0x0894)] public int Edit_Registry_Switch_Heading_FadeIn_Frame;
    [FieldOffset(0x0898)] public int Edit_Registry_Switch_Mark_Rotate_Animation_Frame;
    [FieldOffset(0x08B0)] public UDataTable* LayoutTable;
    [FieldOffset(0x08B8)] public UDataTable* TextLayoutTable;
    [FieldOffset(0x08C0)] public UDataTable* TextPosRowLayoutTable;
    [FieldOffset(0x08C8)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x08D0)] public UUILayoutDataTable* TextLayoutDataTable;
    [FieldOffset(0x08D8)] public UUILayoutDataTable* TextPosRowLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UPersonaStatusSeq
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPersonaStatusSkillHelpSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UPersonaStatusSelectSkillSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UPersonaStatusChangeSkillSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
    [FieldOffset(0x0050)] public UPersonaStatusSkillHelpSeq* SkillHelpSequence_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1F8)] 
public unsafe struct UPersonaStatusLvUpSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
    [FieldOffset(0x0160)] public UPersonaStatusSkillHelpSeq* SkillHelpSequence_;
    [FieldOffset(0x0168)] public UPersonaStatusSelectSkillSeq* SelectSkillSequence_;
    [FieldOffset(0x0170)] public UPersonaStatusChangeSkillSeq* ChangeSkillSequence_;
    [FieldOffset(0x0178)] public UUICombineCalc* CombineCalc_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UPersonaStatusSkillCardSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
    [FieldOffset(0x0040)] public UPersonaStatusSkillHelpSeq* SkillHelpSequence_;
    [FieldOffset(0x0048)] public UPersonaStatusSelectSkillSeq* SelectSkillSequence_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPersonaStatusSkillListSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPersonaStatusRememberSkillSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UPersonaStatusSkillInfoSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UPersonaStatusParamUpSeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
    [FieldOffset(0x0048)] public UPersonaStatusSkillHelpSeq* SkillHelpSequence_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UPersonaStatusCommentarySeq
{
    [FieldOffset(0x0000)] public UPersonaStatusSeq baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AUIPoetryActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0280)] public UUIPoetryDataAsset* PoetryData_;
    [FieldOffset(0x0288)] public UUIPoetryRippleDataAsset* PoetryRippleData_;
    [FieldOffset(0x0290)] public AUICmmRankUPAnimManager* AnimManager;
    [FieldOffset(0x02A8)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x02B0)] public TSubclassOf<AUIPoetryDraw> UIPoetryDrawClass;
    [FieldOffset(0x02B8)] public AUIPoetryDraw* pUIPoetryDraw;
}

[StructLayout(LayoutKind.Explicit, Size = 0x958)] 
public unsafe struct AUIPoetryDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02C0)] public uint ArcanaID;
    [FieldOffset(0x02C4)] public uint ModeID;
    [FieldOffset(0x02C8)] public UUIPoetryDataAsset* Data_;
    [FieldOffset(0x02D0)] public UUIPoetryRippleDataAsset* RippleData_;
    [FieldOffset(0x02D8)] public FString m_BlurTexPath;
    [FieldOffset(0x0348)] public FString m_pEfTexPath;
    [FieldOffset(0x03B8)] public FString m_pNormalTexPath;
    [FieldOffset(0x0430)] public UTexture* m_pBlurTex;
    [FieldOffset(0x0468)] public UTexture* m_pEfTex;
    [FieldOffset(0x04A0)] public UTexture* m_pNormalTex;
    [FieldOffset(0x04D8)] public UTexture* m_ArcanaTex;
    [FieldOffset(0x04E0)] public UTexture* m_ArcanaTexBlur;
    [FieldOffset(0x04E8)] public UTexture* m_ArcanaTexEf;
    [FieldOffset(0x04F0)] public UMaterialInstance* pMaterial;
    [FieldOffset(0x04F8)] public UMaterialInstance* pRippleMat;
    [FieldOffset(0x0500)] public UMaterialInstanceDynamic* pMat_Line1;
    [FieldOffset(0x0518)] public UMaterialInstanceDynamic* pMat_Line2;
    [FieldOffset(0x0530)] public UMaterialInstanceDynamic* pMat_Line3;
    [FieldOffset(0x0548)] public UMaterialInstanceDynamic* pMat_Line4;
    [FieldOffset(0x0560)] public UMaterialInstanceDynamic* pMat_Line5;
    [FieldOffset(0x0578)] public UMaterialInstanceDynamic* pMat_Ripples;
    [FieldOffset(0x05B8)] public float EfBaseAlpha;
    [FieldOffset(0x05BC)] public float LineStartTime_1;
    [FieldOffset(0x05C0)] public float LineStartTime_2;
    [FieldOffset(0x05C4)] public float LineStartTime_3;
    [FieldOffset(0x05C8)] public float LineStartTime_4;
    [FieldOffset(0x05CC)] public float LineStartTime_5;
    [FieldOffset(0x05D0)] public float OkKeyPushStartTimeMax;
    [FieldOffset(0x05D4)] public float OkKeyPushEndTimeMax;
    [FieldOffset(0x05D8)] public float OkKeyFadeOutAnimTime;
    [FieldOffset(0x05DC)] public float OkKeyFadeOutMovePos;
    [FieldOffset(0x05F0)] public FCurveFloatAnimation CrvFadeWidthAnim;
    [FieldOffset(0x0620)] public FCurveFloatAnimation CrvFadeHeightAnim;
    [FieldOffset(0x0650)] public FCurveFloatAnimation CrvFadeLineAnim;
    [FieldOffset(0x0680)] public FCurveFloatAnimation CrvFadeLineEfAnim;
    [FieldOffset(0x06B0)] public FCurveFloatAnimation CrvFadeRippleAlpha;
    [FieldOffset(0x06E0)] public FCurveFloatAnimation CrvFadeRippleScale;
    [FieldOffset(0x0718)] public AUICmmRankUPAnimManager* AnimManager;
    [FieldOffset(0x08A8)] public UDataTable* PoetyLayoutData;
    [FieldOffset(0x08B0)] public UUILayoutDataTable* PoetyLayoutDataTable;
    [FieldOffset(0x08B8)] public UDataTable* RippleLayoutData;
    [FieldOffset(0x08C0)] public UUILayoutDataTable* RippleLayoutDataTable;
    [FieldOffset(0x08C8)] public UDataTable* RippleTimeData;
    [FieldOffset(0x08D0)] public UUILayoutDataTable* RippleTimeDataTable;
    [FieldOffset(0x08D8)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x08E0)] public UUILayoutDataTable* OkNextLayoutDataTable;
    [FieldOffset(0x08E8)] public UDataTable* OkNextMaskLayoutData;
    [FieldOffset(0x08F0)] public UUILayoutDataTable* OkNextMaskLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct AUIPreviewWorldUpdater
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public TSoftObjectPtr<UWorld> PreviewWorld;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct AUIProgressBarDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public USprAsset* pSprAsset;
    [FieldOffset(0x0378)] public UDataTable* LayoutData;
    [FieldOffset(0x0380)] public UUILayoutDataTable* LayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x330)] 
public unsafe struct AUIRankUpDraw
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B8)] public AUIPoetryActor* PoetryActor;
    [FieldOffset(0x02C0)] public AUIArcanaCardCapture* UIACCaptureActor;
    [FieldOffset(0x02C8)] public AUIGameOverPoem* UIGameOverPoem;
    [FieldOffset(0x02D0)] public UAssetLoader* pAssetLoader;
    [FieldOffset(0x02D8)] public TSubclassOf<AUICmmRankUpBG> UIBGActorClass;
    [FieldOffset(0x02E0)] public AUICmmRankUpBG* pUIBGActor;
    [FieldOffset(0x02E8)] public TSubclassOf<AUICmmRankUpDraw> UICmmRankUpDrawClass;
    [FieldOffset(0x02F0)] public AUICmmRankUpDraw* pUICmmRankUpDraw;
    [FieldOffset(0x02F8)] public TSubclassOf<AUICmmRankUPAnimManager> RankUpAnimManagerClass;
    [FieldOffset(0x0300)] public AUICmmRankUPAnimManager* pRankUpAnimManager;
    [FieldOffset(0x0308)] public UMaterialInstance* pMaterialBGGameover;
    [FieldOffset(0x0318)] public UDataTable* OkNextLayoutData;
    [FieldOffset(0x0320)] public UDataTable* OkNextMaskLayoutData;
    [FieldOffset(0x0328)] public UDataTable* CmmRankUpLayoutData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct UUIRenderWidget
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public UTextureRenderTarget2D* RenderTarget;
    [FieldOffset(0x00D0)] public UUserWidget* RenderWidget;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE00)] 
public unsafe struct UUIRequest
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0058)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0060)] public AScrActor* m_pScrActor;
    [FieldOffset(0x0068)] public UBfAsset* m_pBfAsset;
    [FieldOffset(0x0070)] public UBmdAsset* m_pBmdAsset;
    [FieldOffset(0x0078)] public UWorld* m_pRefWorld;
    [FieldOffset(0x0080)] public USprAsset* m_pCampSpr;
    [FieldOffset(0x0088)] public UPlgAsset* m_pCampPlg;
    [FieldOffset(0x0090)] public UMaterialInterface* m_pBGMat;
    [FieldOffset(0x0098)] public UMaterialInstanceDynamic* m_pBGMatInst;
    [FieldOffset(0x00A0)] public UDataTable* m_pRequestDT;
    [FieldOffset(0x0D68)] public UUILayoutDataTable* LayoutData;
    [FieldOffset(0x0D70)] public UUILayoutDataTable* TextColLayoutData;
    [FieldOffset(0x0D78)] public UUILayoutDataTable* TextPosLayoutData;
    [FieldOffset(0x0D80)] public UUILayoutDataTable* DateLayoutData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct UUIResources
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0038)] public UAssetLoader* Loader_;
    [FieldOffset(0x0040)] public TArray<IntPtr> Assets_;
    [FieldOffset(0x00D0)] public UDataTable* HandwritingLayoutData_;
    [FieldOffset(0x00D8)] public UFontStyleAsset* FontStyleAsset_;
    [FieldOffset(0x00E0)] public UFont* SystemFont_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct AUIRestore
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x02A8)] public UUILayoutDataTable* SaveLoadLayoutDataTable;
    [FieldOffset(0x02B0)] public UUILayoutDataTable* SaveLoadLayoutDataTable2;
    [FieldOffset(0x02B8)] public UUILayoutDataTable* SaveLoadDateLayoutDataTable;
    [FieldOffset(0x02C0)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x02C8)] public UDataTable* pParamLayoutData2;
    [FieldOffset(0x02D0)] public UDataTable* pParamDateLayoutData;
    [FieldOffset(0x02D8)] public UAssetLoader* Loader;
    [FieldOffset(0x02E0)] public TSubclassOf<ASaveLoadDraw> DrawActorSC;
    [FieldOffset(0x02E8)] public ASaveLoadDraw* DrawActor;
    [FieldOffset(0x02F0)] public UAddContent* AddContentCheck;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B8)] 
public unsafe struct AUISaveDialog
{
    [FieldOffset(0x0000)] public AUISaveLoad baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AUISceneCapture
{
    [FieldOffset(0x0000)] public ASceneCapture2D baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UUISceneFSM
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> SceneStack_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UUISoundManager
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UUISubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0048)] public AActor* ShopActor_;
    [FieldOffset(0x0050)] public TWeakObjectPtr<AActor> TempActor_;
    [FieldOffset(0x0058)] public UUIAssist* Assist_;
    [FieldOffset(0x0060)] public UFadePlayer* FadePlayer_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct AUISystemMsgActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUITableTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTestNishidaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Level;
    [FieldOffset(0x000A)] public ushort attack;
    [FieldOffset(0x000C)] public ushort Defence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UTestNishidaDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FTestNishidaDataTable> Data;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9E0)] 
public unsafe struct AUITest1Actor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0230)] public UTexture* m_pMenuTexture;
    [FieldOffset(0x0238)] public USprAsset* m_pIconSpr;
    [FieldOffset(0x0240)] public UMaterial* m_pPostMaterial;
    [FieldOffset(0x0248)] public UTextureRenderTarget2D* m_pRenderTarget1;
    [FieldOffset(0x08A8)] public UMaterial* m_loadMaterial;
    [FieldOffset(0x08B0)] public UMaterialInstanceDynamic* m_loadMaterialInstanceDynamic;
    [FieldOffset(0x08B8)] public UTexture* m_loadTex;
    [FieldOffset(0x08C0)] public UCurveFloat* m_pCurveFloat;
    [FieldOffset(0x08C8)] public FCurveFloatAnimation m_tagCurveFloatAnimation;
    [FieldOffset(0x08F8)] public FCurveVectorAnimation m_tagCurveVectorAnimation;
    [FieldOffset(0x0928)] public FCurveLinearColorAnimation m_tagCurveColorAnimation;
    [FieldOffset(0x0958)] public UTestNishidaDataAsset* m_pTestNishidaTableData;
    [FieldOffset(0x0960)] public FGetUIParameter m_tagGetUIP;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct AUITestSpawnActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF50)] 
public unsafe struct UUITheurgia
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0070)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0078)] public UWorld* m_pRefWorld;
    [FieldOffset(0x0080)] public USprAsset* m_pTheurgiaSpr;
    [FieldOffset(0x0088)] public UPlgAsset* m_pTheurgiaPlg;
    [FieldOffset(0x0090)] public UMaterialInterface* m_pBGMat;
    [FieldOffset(0x0098)] public UMaterialInstanceDynamic* m_pBGMatInst;
    [FieldOffset(0x00A0)] public USprAsset* m_pCampSpr;
    [FieldOffset(0x00A8)] public UPlgAsset* m_pCampPlg;
    [FieldOffset(0x00B0)] public UDataTable* m_pTheurgiaUIDT;
    [FieldOffset(0x00B8)] public UUIMiscSpecialKeyhelp* m_pMiscSpecialKeyhelp;
    [FieldOffset(0x01C0)] public FCurveFloatAnimation m_curveCurrentCursorAlways_Light;
    [FieldOffset(0x01F0)] public FCurveFloatAnimation m_curveCurrentCursorAlways_Persona;
    [FieldOffset(0x0220)] public FCurveFloatAnimation m_curveCurrentCursorAlways_ChangeTiming;
    [FieldOffset(0x0250)] public FCurveFloatAnimation m_curveStart_CursorRate;
    [FieldOffset(0x0280)] public FCurveFloatAnimation m_curveEnd_CursorRate;
    [FieldOffset(0x02B0)] public FCurveFloatAnimation m_curveCtrlCursorIn_Rate;
    [FieldOffset(0x02E0)] public FCurveFloatAnimation m_curveCtrlCursorOut_Rate;
    [FieldOffset(0x0310)] public FCurveFloatAnimation m_curveStart_CursorListRate;
    [FieldOffset(0x0340)] public FCurveFloatAnimation m_curveStart_LRCursorListRate;
    [FieldOffset(0x0370)] public FCurveFloatAnimation m_curveStart_LRCursorListAlpha;
    [FieldOffset(0x03A0)] public FCurveFloatAnimation m_curveEnd_LRCursorListRate;
    [FieldOffset(0x03D0)] public FCurveFloatAnimation m_curveEnd_LRCursorListAlpha;
    [FieldOffset(0x0400)] public FCurveFloatAnimation m_curve_LRCursorListWaveRate;
    [FieldOffset(0x0430)] public FCurveFloatAnimation m_curveEnd_SkillRate;
    [FieldOffset(0x0460)] public FCurveFloatAnimation m_curveStart_DetailTextIn;
    [FieldOffset(0x0490)] public FCurveFloatAnimation m_curveStart_TheurgiaText;
    [FieldOffset(0x04C0)] public FCurveFloatAnimation m_curveStart_SkillHelpText;
    [FieldOffset(0x04F0)] public FCurveVectorAnimation m_curveStart_StatusTab;
    [FieldOffset(0x0520)] public FCurveVectorAnimation m_curveEnd_StatusTab;
    [FieldOffset(0x0550)] public FCurveFloatAnimation m_curveDetailStart_CirclePos;
    [FieldOffset(0x0580)] public FCurveFloatAnimation m_curveDetailStart_CircleScale;
    [FieldOffset(0x05B0)] public FCurveFloatAnimation m_curveDetailEnd_CirclePos;
    [FieldOffset(0x05E0)] public FCurveFloatAnimation m_curveDetailEnd_CircleScale;
    [FieldOffset(0x0610)] public FCurveFloatAnimation m_curveDetailStart_DetailAddText;
    [FieldOffset(0x0640)] public FCurveFloatAnimation m_curveDetailEnd_DetailAddText;
    [FieldOffset(0x0670)] public FCurveFloatAnimation m_curveDetailStart_PersonalityRate;
    [FieldOffset(0x06A0)] public FCurveFloatAnimation m_curveDetailStart_NormalPersonalityRate;
    [FieldOffset(0x06D0)] public FCurveFloatAnimation m_curveDetailEnd_NormalPersonalityRate;
    [FieldOffset(0x0700)] public FCurveFloatAnimation m_curveDetailStart_MovementRate;
    [FieldOffset(0x0730)] public FCurveFloatAnimation m_curveDetailEnd_MovementRate;
    [FieldOffset(0x0760)] public FCurveVectorAnimation m_curveDetailStart_Kira;
    [FieldOffset(0x0790)] public FCurveFloatAnimation m_curveCurrentCursorLineFirst_Rate;
    [FieldOffset(0x07C0)] public FCurveFloatAnimation m_curveCurrentCursorLineLoop_Rate;
    [FieldOffset(0x07F0)] public FCurveFloatAnimation m_curveFade_YellowKira;
    [FieldOffset(0x0820)] public FCurveVectorAnimation m_curveMove_YellowKira;
    [FieldOffset(0x0850)] public FCurveVectorAnimation m_curveMove_YellowKiraPowerUp;
    [FieldOffset(0x0880)] public FCurveVectorAnimation m_curveRotateAndScale_YellowKira;
    [FieldOffset(0x08B0)] public FCurveVectorAnimation m_curveRotateAndScale_YellowKira_PowerUp;
    [FieldOffset(0x08E0)] public FCurveFloatAnimation m_curveFade_YellowPersonality;
    [FieldOffset(0x0910)] public FCurveFloatAnimation m_curveFade_BlackBG_In;
    [FieldOffset(0x0940)] public FCurveFloatAnimation m_curveMove_YellowPersonality;
    [FieldOffset(0x0970)] public FCurveFloatAnimation m_curveFlickering_AfterYellowKira1;
    [FieldOffset(0x09A0)] public FCurveFloatAnimation m_curveFlickering_AfterYellowKira2;
    [FieldOffset(0x09D0)] public FCurveFloatAnimation m_curveFlickering_Text;
    [FieldOffset(0x0A00)] public FCurveFloatAnimation m_curveRotate_AfterYellowKira1;
    [FieldOffset(0x0A30)] public FCurveFloatAnimation m_curveRotate_AfterYellowKira2;
    [FieldOffset(0x0A60)] public FCurveFloatAnimation m_curveMove_MovePassiveTextRatio;
    [FieldOffset(0x0A90)] public FCurveFloatAnimation m_curveFade_YellowPersonalityPlate;
    [FieldOffset(0x0AC0)] public FCurveFloatAnimation m_curveFade_BlackBG_Out;
    [FieldOffset(0x0AF0)] public FCurveFloatAnimation m_curveFade_BlackBG_In_Obtain;
    [FieldOffset(0x0B20)] public FCurveFloatAnimation m_curveFade_BlackBG_Out_Obtain;
    [FieldOffset(0x0B50)] public FCurveFloatAnimation m_curveFade_YellowPersonalityPlate_Obtain;
    [FieldOffset(0x0B80)] public FCurveFloatAnimation m_curveMove_YellowPersonality_Obtain;
    [FieldOffset(0x0BB0)] public FCurveFloatAnimation m_curveFade_YellowPersonality_Obtain;
    [FieldOffset(0x0D60)] public FCurveVectorAnimation m_curveRipple_ObtainCursor;
    [FieldOffset(0x0D90)] public FCurveFloatAnimation m_curveFlickering_ObtainSkillText;
    [FieldOffset(0x0DC0)] public FCurveFloatAnimation m_curveMove_ObtainSkillTextRatio;
    [FieldOffset(0x0EC0)] public UDataTable* LayoutData;
    [FieldOffset(0x0EC8)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0ED0)] public UDataTable* TextLayoutData;
    [FieldOffset(0x0ED8)] public UUILayoutDataTable* TextLayoutDataTable;
    [FieldOffset(0x0EE0)] public UDataTable* TextPosLayoutData;
    [FieldOffset(0x0EE8)] public UUILayoutDataTable* TextPosLayoutDataTable;
    [FieldOffset(0x0EF0)] public UDataTable* TextRowLayoutData;
    [FieldOffset(0x0EF8)] public UUILayoutDataTable* TexRowLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8D8)] 
public unsafe struct AUITimeChange
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02B0)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x02B8)] public USprAsset* m_pSpr;
    [FieldOffset(0x02C0)] public FCurveVectorAnimation m_curveRotateAnim1;
    [FieldOffset(0x02F0)] public FCurveVectorAnimation m_curveRotateAnim2;
    [FieldOffset(0x0320)] public FCurveVectorAnimation m_curveRotateAnim3;
    [FieldOffset(0x0350)] public FCurveVectorAnimation m_curveRotateAnim4;
    [FieldOffset(0x0380)] public FCurveVectorAnimation m_curveRotateAnim5;
    [FieldOffset(0x03B0)] public FCurveVectorAnimation m_curveOutAnim;
    [FieldOffset(0x03E0)] public FGetUIParameter m_uip;
    [FieldOffset(0x0458)] public UDataTable* m_pTimeChangeUIDT;
    [FieldOffset(0x08B8)] public UDataTable* m_pTimeChangeDataTable;
    [FieldOffset(0x08C0)] public UUILayoutDataTable* m_pTimeChangeLayoutDataTable;
    [FieldOffset(0x08C8)] public UDataTable* m_pTimeChangeMaskDataTable;
    [FieldOffset(0x08D0)] public UUILayoutDataTable* m_pTimeChangeMaskLayoutDataTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40F0)] 
public unsafe struct AUITownMapActor
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02F0)] public UDataTable* m_pTownMapDT;
    [FieldOffset(0x02F8)] public USprAsset* m_pTownMapSpr;
    [FieldOffset(0x0300)] public USprAsset* m_pMiniMapIcon00Spr;
    [FieldOffset(0x0308)] public USprAsset* m_pMiniMapIcon01Spr;
    [FieldOffset(0x0310)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0318)] public FGetUIParameter m_tagUip;
    [FieldOffset(0x0390)] public FCurveVectorAnimation m_curveHeadInAnim;
    [FieldOffset(0x03C0)] public FCurveVectorAnimation m_curveBlueDiamondAnim;
    [FieldOffset(0x03F0)] public FCurveVectorAnimation m_curveWhiteDiamondAnim;
    [FieldOffset(0x0420)] public FCurveVectorAnimation m_curveInfoInAnim;
    [FieldOffset(0x0450)] public FCurveVectorAnimation m_curveIconAnim;
    [FieldOffset(0x0480)] public UUILocationSelect* m_pLocationSelect;
    [FieldOffset(0x0488)] public AFldAnimObj* m_pSymbolRefList;
    [FieldOffset(0x04B8)] public USkinnedMeshComponent* m_pSymbolSkinnedRefList;
    [FieldOffset(0x04E8)] public AActor* m_pFieldCamera;
    [FieldOffset(0x04F0)] public AActor* m_pMainCamera;
    [FieldOffset(0x04F8)] public AActor* m_pStartCamera;
    [FieldOffset(0x0500)] public AActor* m_pInfoCamera;
    [FieldOffset(0x0530)] public AActor* m_pNameLocator;
    [FieldOffset(0x0560)] public UBmdAsset* m_pTownMapDetailText;
    [FieldOffset(0x3ED8)] public FVector MarginRot;
    [FieldOffset(0x3F20)] public UUILayoutDataTable* m_notSelectedLayoutDataTables;
    [FieldOffset(0x3F50)] public UUILayoutDataTable* m_selectedLayoutDataTables;
    [FieldOffset(0x3F80)] public UUILayoutDataTable* m_infoLayoutDataTable;
    [FieldOffset(0x3F88)] public UUILayoutDataTable* m_infoLayoutDataTable2;
    [FieldOffset(0x3F90)] public UDataTable* m_notSelectedParamLayouts;
    [FieldOffset(0x3FC0)] public UDataTable* m_selectedParamLayouts;
    [FieldOffset(0x3FF0)] public UDataTable* m_infoParamLayout;
    [FieldOffset(0x3FF8)] public UDataTable* m_infoParamLayout2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct AUITownMapCameraActor
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0278)] public AActor* MainCamera_;
    [FieldOffset(0x0280)] public AActor* SchoolCamera_;
    [FieldOffset(0x0288)] public AActor* DormitoryCamera_;
    [FieldOffset(0x0290)] public AActor* PortislandCamera_;
    [FieldOffset(0x0298)] public AActor* PolonianmallCamera_;
    [FieldOffset(0x02A0)] public AActor* IwatodayCamera_;
    [FieldOffset(0x02A8)] public AActor* NaganakiCamera_;
    [FieldOffset(0x02B0)] public AActor* SchoolActor_;
    [FieldOffset(0x02B8)] public AActor* DormitoryActor_;
    [FieldOffset(0x02C0)] public AActor* PortislandActor_;
    [FieldOffset(0x02C8)] public AActor* PolonianmallActor_;
    [FieldOffset(0x02D0)] public AActor* IwatodayActor_;
    [FieldOffset(0x02D8)] public AActor* NaganakiActor_;
    [FieldOffset(0x02E0)] public AActor* StartCamera_;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UUITownMapSymbolComponent
{
    [FieldOffset(0x0000)] public UAppActorComponent baseObj;
    [FieldOffset(0x00C8)] public AFldAnimObj* FldAnimObj_;
    [FieldOffset(0x00D0)] public USkinnedMeshComponent* SkinnedComponent_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x420)] 
public unsafe struct AUITutorial
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
    [FieldOffset(0x0350)] public UAssetLoader* Loader;
    [FieldOffset(0x0358)] public UDataTable* BattleDataTableAsset;
    [FieldOffset(0x0360)] public UDataTable* BattleNameTableAsset;
    [FieldOffset(0x0368)] public UDataTable* DungeonDataTableAsset;
    [FieldOffset(0x0370)] public UDataTable* DungeonNameTableAsset;
    [FieldOffset(0x0378)] public UDataTable* DailyDataTableAsset;
    [FieldOffset(0x0380)] public UDataTable* DailyNameTableAsset;
    [FieldOffset(0x0388)] public UDataTable* CombineDataTableAsset;
    [FieldOffset(0x0390)] public UDataTable* CombineNameTableAsset;
    [FieldOffset(0x0398)] public UDataTable* SystemDataTableAsset;
    [FieldOffset(0x03A0)] public UDataTable* SystemNameTableAsset;
    [FieldOffset(0x03A8)] public ACmpMainActor* pMainActor;
    [FieldOffset(0x03B0)] public AUITutorialDraw* pTutorialDraw;
    [FieldOffset(0x03B8)] public TSubclassOf<AUITutorialDraw> pTutorialDrawClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5A8)] 
public unsafe struct AUITutorialDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public UMaterialInstanceDynamic* pBackgroundMaterialDynamicInstance;
    [FieldOffset(0x02C0)] public UBmdAsset* pBmdAsset;
    [FieldOffset(0x02C8)] public int Edit_Title_Logo_Slide_In_Delay;
    [FieldOffset(0x02CC)] public int Edit_Title_Logo_Slide_In_Frame;
    [FieldOffset(0x02D0)] public int Edit_Navy_Blue_Plate_Slide_In_Delay;
    [FieldOffset(0x02D4)] public int Edit_Navy_Blue_Plate_Slide_In_Frame;
    [FieldOffset(0x02D8)] public int Edit_Gradation_Slide_In_Delay;
    [FieldOffset(0x02DC)] public int Edit_Gradation_Slide_In_Frame;
    [FieldOffset(0x02E0)] public int Edit_White_Plate_Slide_In_Delay;
    [FieldOffset(0x02E4)] public int Edit_White_Plate_Slide_In_Frame;
    [FieldOffset(0x02E8)] public int Edit_Tab_Slide_In_Delay;
    [FieldOffset(0x02EC)] public int Edit_Tab_Slide_In_Frame;
    [FieldOffset(0x02F0)] public int Edit_Tab_Fade_In_Delay;
    [FieldOffset(0x02F4)] public int Edit_Tab_Fade_In_Frame;
    [FieldOffset(0x02F8)] public int Edit_List_Slide_In_Delay;
    [FieldOffset(0x02FC)] public int Edit_List_Slide_In_Frame;
    [FieldOffset(0x0300)] public int Edit_List_Fade_In_Delay;
    [FieldOffset(0x0304)] public int Edit_List_Fade_In_Frame;
    [FieldOffset(0x0308)] public int Edit_List_Sub_Cursor_Slide_In_Delay;
    [FieldOffset(0x030C)] public int Edit_List_Sub_Cursor_Slide_In_Frame;
    [FieldOffset(0x0314)] public int Edit_List_Change_Fade_Out_Delay;
    [FieldOffset(0x0318)] public int Edit_List_Change_Fade_Out_Frame;
    [FieldOffset(0x031C)] public int Edit_List_Change_Fade_In_Delay;
    [FieldOffset(0x0320)] public int Edit_List_Change_Fade_In_Frame;
    [FieldOffset(0x0324)] public int Edit_List_Change_Slide_In_Delay;
    [FieldOffset(0x0328)] public int Edit_List_Change_Slide_In_Frame;
    [FieldOffset(0x032C)] public int Edit_Gradation_Change_Slide_In_Delay;
    [FieldOffset(0x0330)] public int Edit_Gradation_Change_Slide_In_Frame;
    [FieldOffset(0x0334)] public int Edit_Gradation_Change_Cross_Fade_Delay;
    [FieldOffset(0x0338)] public int Edit_Gradation_Change_Cross_Fade_Frame;
    [FieldOffset(0x03A0)] public int Edit_Tab_Cursor_Frame;
    [FieldOffset(0x03A4)] public int Edit_List_Cursor_Frame;
    [FieldOffset(0x03A8)] public int Edit_List_Sub_Cursor_Frame;
    [FieldOffset(0x03AC)] public int Edit_Gray_Out_Frame;
    [FieldOffset(0x0588)] public ACmpMainActor* pMainActor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4E8)] 
public unsafe struct AUIVelvetRoom
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
    [FieldOffset(0x02A8)] public UUICombine* m_pUICombine;
    [FieldOffset(0x02B0)] public UUICompleteBook* m_pUICompleteBook;
    [FieldOffset(0x02B8)] public UUICompleteBookRegist* m_pUICompleteBookRegist;
    [FieldOffset(0x02C0)] public UUIVelvetRoomOwner* m_pOwner;
}

[StructLayout(LayoutKind.Explicit, Size = 0x670)] 
public unsafe struct AUIVelvetRoomDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B8)] public int Edit_Panel_InAnimation_Frame;
    [FieldOffset(0x02BC)] public int Edit_Panel_OutAnimation_Frame;
    [FieldOffset(0x02C0)] public float Edit_Panel_Loop_Wait_Time;
    [FieldOffset(0x02C4)] public float Edit_Panel_Loop_Fade_In_Time;
    [FieldOffset(0x02C8)] public float Edit_Panel_Loop_Fade_Out_Time;
    [FieldOffset(0x02CC)] public int Edit_Cursor_InAnimation_Frame;
    [FieldOffset(0x02D0)] public float Edit_Dollar_Icon_Animation_Time;
    [FieldOffset(0x02D4)] public float Edit_Equipe_Icon_Animation_Time;
    [FieldOffset(0x02D8)] public float Edit_Equipe_Icon_Wait_Time;
    [FieldOffset(0x02DC)] public int Edit_Equipe_Icon_FadeOut_Frame;
    [FieldOffset(0x02E0)] public float Edit_HelpMessage_Line_Height;
    [FieldOffset(0x02E4)] public int Edit_Sort_Tab_Animation_Frame;
    [FieldOffset(0x02E8)] public EUIVelvetRoomDrawScene Scene;
    [FieldOffset(0x0378)] public AUIVelvetRoomPanel* pPanel;
    [FieldOffset(0x0380)] public ACameraActor* pCamera;
    [FieldOffset(0x0388)] public APersonaStatus* pPersonaStatus;
    [FieldOffset(0x0390)] public int Edit_PanelNoneColorRate;
    [FieldOffset(0x0394)] public int Edit_InAnimationFrame_Lattice;
    [FieldOffset(0x0398)] public int Edit_Hero_FadeOut_Frame;
    [FieldOffset(0x039C)] public int Edit_HelpMessageInAnimationFrame;
    [FieldOffset(0x03A0)] public int Edit_HelpMessageOutAnimationFrame;
    [FieldOffset(0x03A4)] public int Edit_HelpMessageChangeAnimationFrame;
    [FieldOffset(0x03A8)] public FVector Edit_CardOffsetPosition;
    [FieldOffset(0x03B4)] public FVector Edit_CardOffsetRotation;
    [FieldOffset(0x03C0)] public FVector Edit_CardSadowOffsetPosition;
    [FieldOffset(0x03CC)] public FVector Edit_CardSadowOffsetRotation;
    [FieldOffset(0x03D8)] public float Edit_CardSadowScale;
    [FieldOffset(0x03DC)] public int Edit_BlackScreenLow_FadeIn_Frame;
    [FieldOffset(0x03E0)] public int Edit_BlackScreenLow_FadeIn_Delay;
    [FieldOffset(0x03E4)] public int Edit_BlackScreenMiddle_FadeIn_Frame;
    [FieldOffset(0x03E8)] public int Edit_BlackScreenMiddle_FadeIn_Delay;
    [FieldOffset(0x03EC)] public int Edit_BlackScreenHigh_FadeIn_Frame;
    [FieldOffset(0x03F0)] public int Edit_BlackScreenHigh_FadeIn_Delay;
    [FieldOffset(0x03F4)] public int Edit_VelvetRoomTop_FadeOut_Frame;
    [FieldOffset(0x03F8)] public int Edit_VelvetRoomTop_CardIn_Delay;
    [FieldOffset(0x03FC)] public int Edit_VelvetRoomTop_KeyHelpIn_Delay;
    [FieldOffset(0x0400)] public FVector2D Edit_VelvetRoomTop_Capture_OffsetUV;
    [FieldOffset(0x0408)] public int Edit_VelvetRoomTop_Hero_Wave1_Fade_Delay;
    [FieldOffset(0x040C)] public int Edit_VelvetRoomTop_Hero_Wave1_Fade_Frame;
    [FieldOffset(0x0410)] public int Edit_VelvetRoomTop_Hero_Wave2_Fade_Delay;
    [FieldOffset(0x0414)] public int Edit_VelvetRoomTop_Hero_Wave2_Fade_Frame;
    [FieldOffset(0x0458)] public int CombineType;
    [FieldOffset(0x045C)] public bool IsHeroPlayMotion;
    [FieldOffset(0x0460)] public UMaterialInstance* pHeroWaveMaterial1;
    [FieldOffset(0x0468)] public UMaterialInstance* pHeroWaveMaterial2;
    [FieldOffset(0x0470)] public UMaterialInstanceDynamic* pHeroWaveDynamicMaterial1;
    [FieldOffset(0x0478)] public UMaterialInstanceDynamic* pHeroWaveDynamicMaterial2;
    [FieldOffset(0x0498)] public UUIVelvetRoomUimCard* pCard;
    [FieldOffset(0x04A0)] public UUIVelvetRoomMca* pMca;
    [FieldOffset(0x04A8)] public int Edit_2Combine_InAnimation_Frame;
    [FieldOffset(0x04AC)] public int Edit_2Combine_Igor_InAnimation_Frame;
    [FieldOffset(0x04B0)] public int Edit_2Combine_Heading_InAnimation_Frame;
    [FieldOffset(0x04B4)] public int Edit_2Combine_List_SelectedAnimation_Frame;
    [FieldOffset(0x04B8)] public int Edit_2Combine_List_Cursor_Animation_Frame;
    [FieldOffset(0x04BC)] public int Edit_2Combine_1Icon_Animation_Frame;
    [FieldOffset(0x04C0)] public int Edit_2Combine_Igor_Selected_Animation_Frame;
    [FieldOffset(0x04C4)] public FVector2D Edit_2Combine_Capture_OffsetUV;
    [FieldOffset(0x04E4)] public int Edit_SearchCombine_Heading_InAnimation_Frame;
    [FieldOffset(0x04E8)] public int Edit_SearchCombine_Igor_Panel_InAnimation_Frame;
    [FieldOffset(0x04EC)] public int Edit_SearchCombine_Sort_Panel_InAnimation_Frame;
    [FieldOffset(0x04F0)] public int Edit_SearchCombine_Name_Panel_InAnimation_Frame;
    [FieldOffset(0x04F4)] public int Edit_SearchCombine_Help_Message_InAnimation_Frame;
    [FieldOffset(0x04F8)] public int Edit_SearchCombine_List_InAnimation_Frame;
    [FieldOffset(0x04FC)] public FVector2D Edit_SearchCombine_Capture_OffsetUV;
    [FieldOffset(0x0504)] public int Edit_SearchCombine_List_Fade_Out_Delay;
    [FieldOffset(0x0508)] public int Edit_SearchCombine_List_Fade_Out_Frame;
    [FieldOffset(0x050C)] public int Edit_SearchCombine_List_Fade_In_Delay;
    [FieldOffset(0x0510)] public int Edit_SearchCombine_List_Fade_In_Frame;
    [FieldOffset(0x0514)] public int Edit_SearchCombine_List_Slide_In_Delay;
    [FieldOffset(0x0518)] public int Edit_SearchCombine_List_Slide_In_Frame;
    [FieldOffset(0x0528)] public int Edit_SpecialCombine_Heading_InAnimation_Frame;
    [FieldOffset(0x052C)] public int Edit_SpecialCombine_Igor_Panel_InAnimation_Frame;
    [FieldOffset(0x0530)] public int Edit_SpecialCombine_Name_Panel_InAnimation_Frame;
    [FieldOffset(0x0534)] public int Edit_SpecialCombine_Help_Message_InAnimation_Frame;
    [FieldOffset(0x0538)] public int Edit_SpecialCombine_List_InAnimation_Frame;
    [FieldOffset(0x053C)] public FVector2D Edit_SpecialCombine_Capture_OffsetUV;
    [FieldOffset(0x054C)] public int Edit_Drawer_Heading_InAnimation_Frame;
    [FieldOffset(0x0550)] public int Edit_Drawer_Elizabeth_Panel_InAnimation_Frame;
    [FieldOffset(0x0554)] public int Edit_Drawer_Name_Panel_InAnimation_Frame;
    [FieldOffset(0x0558)] public int Edit_Drawer_Money_InAnimation_Delay;
    [FieldOffset(0x055C)] public int Edit_Drawer_Money_InAnimation_Frame;
    [FieldOffset(0x0560)] public int Edit_Drawer_Money_OutAnimation_Delay;
    [FieldOffset(0x0564)] public int Edit_Drawer_Money_OutAnimation_Frame;
    [FieldOffset(0x0568)] public int Edit_Drawer_Help_Message_InAnimation_Frame;
    [FieldOffset(0x056C)] public int Edit_Drawer_List_InAnimation_Frame;
    [FieldOffset(0x0570)] public int Edit_Drawer_Sort_Panel_InAnimation_Frame;
    [FieldOffset(0x0574)] public int Edit_Drawer_List_Switch_Angle_Animation_Frame;
    [FieldOffset(0x0578)] public int Edit_Drawer_List_LockIcon_FadeIn_Delay;
    [FieldOffset(0x057C)] public int Edit_Drawer_List_LockIcon_FadeIn_Frame;
    [FieldOffset(0x0580)] public int Edit_Drawer_List_LockIcon_Animation_Delay;
    [FieldOffset(0x0584)] public int Edit_Drawer_List_LockIcon_Animation_Frame1;
    [FieldOffset(0x0588)] public int Edit_Drawer_List_LockIcon_Animation_Frame2;
    [FieldOffset(0x058C)] public int Edit_Drawer_List_LockIcon_Animation_Frame3;
    [FieldOffset(0x0590)] public float Edit_Drawer_List_LockIcon_Scale1;
    [FieldOffset(0x0594)] public float Edit_Drawer_List_LockIcon_Scale2;
    [FieldOffset(0x0598)] public float Edit_Drawer_List_LockIcon_Scale3;
    [FieldOffset(0x059C)] public float Edit_Drawer_List_LockIcon_Scale4;
    [FieldOffset(0x05A0)] public float Edit_Drawer_List_LockIcon_Angle1;
    [FieldOffset(0x05A4)] public float Edit_Drawer_List_LockIcon_Angle2;
    [FieldOffset(0x05A8)] public float Edit_Drawer_List_LockIcon_Angle3;
    [FieldOffset(0x05AC)] public float Edit_Drawer_List_LockIcon_Angle4;
    [FieldOffset(0x05B0)] public int Edit_Drawer_List_Switch_Heading_FadeOut_Delay;
    [FieldOffset(0x05B4)] public int Edit_Drawer_List_Switch_Heading_FadeOut_Frame;
    [FieldOffset(0x05B8)] public int Edit_Drawer_List_Switch_Heading_FadeIn_Delay;
    [FieldOffset(0x05BC)] public int Edit_Drawer_List_Switch_Heading_FadeIn_Frame;
    [FieldOffset(0x05C0)] public int Edit_Drawer_List_Switch_Heading_SlideIn_Delay;
    [FieldOffset(0x05C4)] public int Edit_Drawer_List_Switch_Heading_SlideIn_Frame;
    [FieldOffset(0x05C8)] public FVector2D Edit_Drawer_Capture_OffsetUV;
    [FieldOffset(0x05D0)] public int Edit_Drawer_List_Change_Category_Fade_Out_Delay;
    [FieldOffset(0x05D4)] public int Edit_Drawer_List_Change_Category_Fade_Out_Frame;
    [FieldOffset(0x05D8)] public int Edit_Drawer_List_Change_Category_Fade_In_Delay;
    [FieldOffset(0x05DC)] public int Edit_Drawer_List_Change_Category_Fade_In_Frame;
    [FieldOffset(0x05E0)] public int Edit_Drawer_List_Change_Category_Slide_In_Delay;
    [FieldOffset(0x05E4)] public int Edit_Drawer_List_Change_Category_Slide_In_Frame;
    [FieldOffset(0x0614)] public int Edit_Registry_Heading_InAnimation_Frame;
    [FieldOffset(0x0618)] public int Edit_Registry_Elizabeth_Panel_InAnimation_Frame;
    [FieldOffset(0x061C)] public int Edit_Registry_Name_Panel_InAnimation_Frame;
    [FieldOffset(0x0620)] public int Edit_Registry_Help_Message_InAnimation_Frame;
    [FieldOffset(0x0624)] public int Edit_Registry_List_InAnimation_Frame;
    [FieldOffset(0x0628)] public int Edit_Registry_List_CheckMark_Slide_Delay;
    [FieldOffset(0x062C)] public int Edit_Registry_List_CheckMark_Slide_Frame;
    [FieldOffset(0x0630)] public int Edit_Registry_List_CheckMark_FadeIn_Delay;
    [FieldOffset(0x0634)] public int Edit_Registry_List_CheckMark_FadeIn_Frame;
    [FieldOffset(0x0638)] public FVector2D Edit_Registry_Capture_OffsetUV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UVelvetRoomMcaDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> Asset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UUIVelvetRoomMca
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public UWorld* pWorld;
    [FieldOffset(0x0040)] public ACameraActor* pCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UUIVelvetRoomOwner
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAssetLoader* m_pLoader;
    [FieldOffset(0x0030)] public AScrActor* m_pScrActor;
    [FieldOffset(0x0038)] public UBfAsset* m_pBfAsset;
    [FieldOffset(0x0040)] public UBmdAsset* m_pBmdAsset;
    [FieldOffset(0x0048)] public APersonaStatus* m_pPersonaStatusActor;
    [FieldOffset(0x0050)] public UUICombineCalc* m_pCombineCalc;
    [FieldOffset(0x0058)] public UTexture* m_pCombineStateTex;
    [FieldOffset(0x0060)] public AUIVelvetRoomDraw* m_pVelvetRoomDraw;
    [FieldOffset(0x0078)] public TSubclassOf<AUIVelvetRoomDraw> m_pVelvetRoomDrawClass;
    [FieldOffset(0x0088)] public UUILayoutDataTable* CommonLayoutDataTable;
    [FieldOffset(0x0090)] public UUILayoutDataTable* CompendiumLayoutDataTable;
    [FieldOffset(0x0098)] public UUILayoutDataTable* SearchLayoutDataTable;
    [FieldOffset(0x00A0)] public UUILayoutDataTable* SpreadLayoutDataTable;
    [FieldOffset(0x00A8)] public UUILayoutDataTable* SpecialLayoutDataTable;
    [FieldOffset(0x00B0)] public UUILayoutDataTable* SummonLayoutDataTable;
    [FieldOffset(0x00B8)] public UUILayoutDataTable* CommonTextLayoutDataTable;
    [FieldOffset(0x00C0)] public UUILayoutDataTable* HelpLayoutDataTable;
    [FieldOffset(0x00C8)] public UDataTable* pParamLayoutDataCommon;
    [FieldOffset(0x00D0)] public UDataTable* pParamLayoutDataCompendium;
    [FieldOffset(0x00D8)] public UDataTable* pParamLayoutDataSearch;
    [FieldOffset(0x00E0)] public UDataTable* pParamLayoutDataSpread;
    [FieldOffset(0x00E8)] public UDataTable* pParamLayoutDataSpecial;
    [FieldOffset(0x00F0)] public UDataTable* pParamLayoutDataSummon;
    [FieldOffset(0x00F8)] public UDataTable* pParamLayoutDataCommonText;
    [FieldOffset(0x0100)] public UDataTable* pParamLayoutDataHelp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B0)] 
public unsafe struct AUIVelvetRoomPanel
{
    [FieldOffset(0x0000)] public AAppActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct AUIVelvetRoomRequest
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AUIVelvetRoomRequestDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UVelvetRoomCardTextureDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> Textures;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UVelvetRoomUnimDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> Asset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UVelvetRoomCardDataAsset
{
    [FieldOffset(0x0000)] public UAppDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<IntPtr> TextureDataAsset;
    [FieldOffset(0x0040)] public TArray<IntPtr> UnimDataAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UUIVelvetRoomUimCard
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x01B0)] public UWorld* pWorld;
    [FieldOffset(0x01B8)] public ACameraActor* pCamera;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct UTextInputWidget
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct AUIVoiceAction
{
    [FieldOffset(0x0000)] public AUIVoiceBase baseObj;
    [FieldOffset(0x03E8)] public TSubclassOf<AUIVoiceActionDraw> VoiceActionDrawSubClass;
    [FieldOffset(0x03F0)] public AUIVoiceActionDraw* pVoiceActionDrawActor;
    [FieldOffset(0x03F8)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0400)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0408)] public UAssetLoader* Loader_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E0)] 
public unsafe struct AUIVoiceActionDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02F8)] public bool bIsStartInAnim;
    [FieldOffset(0x02F9)] public bool bIsFinishInAnim;
    [FieldOffset(0x02FA)] public bool bIsStartOutAnim;
    [FieldOffset(0x02FB)] public bool bIsFinishOutAnim;
    [FieldOffset(0x02FC)] public bool bIsKeyOutAnim;
    [FieldOffset(0x02FD)] public bool bReturnSceneOptionAnim;
    [FieldOffset(0x02FE)] public bool bIsStartInNetworkIconAnim;
    [FieldOffset(0x02FF)] public bool bIsFinishInNetworkIconAnim;
    [FieldOffset(0x0300)] public bool bIsStartOutNetworkIconAnim;
    [FieldOffset(0x0301)] public bool bIsFinishOutNetworkIconAnim;
    [FieldOffset(0x0302)] public bool bIsStartInBlackBoardAnim;
    [FieldOffset(0x0303)] public bool bIsFinishInBlackBoardAnim;
    [FieldOffset(0x0304)] public bool bIsStartOutBlackBoardAnim;
    [FieldOffset(0x0305)] public bool bIsFinishOutBlackBoardAnim;
    [FieldOffset(0x0306)] public bool IsStartGetData;
    [FieldOffset(0x0307)] public bool IsGetData;
    [FieldOffset(0x0308)] public USprAsset* SprData;
    [FieldOffset(0x0310)] public UPlgAsset* PlgData;
    [FieldOffset(0x0318)] public int OffStartFrame;
    [FieldOffset(0x031C)] public bool IsDisp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct AUIVoiceAnswer
{
    [FieldOffset(0x0000)] public AUIVoiceBase baseObj;
    [FieldOffset(0x0310)] public UAssetLoader* Loader_;
    [FieldOffset(0x0318)] public UBmdAsset* BmdAsset_;
    [FieldOffset(0x0338)] public TSubclassOf<AUIVoiceAnswerDraw> VoiceAnswerDrawSubClass;
    [FieldOffset(0x0340)] public AUIVoiceAnswerDraw* pVoiceAnswerDrawActor;
    [FieldOffset(0x0348)] public UUILayoutDataTable* LayoutDataTable;
    [FieldOffset(0x0350)] public UUILayoutDataTable* LayoutTextColDataTable;
    [FieldOffset(0x0358)] public UDataTable* pParamLayoutData;
    [FieldOffset(0x0360)] public UDataTable* pParamTextColLayoutData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9C8)] 
public unsafe struct AUIVoiceAnswerDraw
{
    [FieldOffset(0x0000)] public AUIDrawBaseActor baseObj;
    [FieldOffset(0x02B9)] public bool bIsStartInAnim;
    [FieldOffset(0x02BA)] public bool bIsFinishInAnim;
    [FieldOffset(0x02BB)] public bool bIsStartOutAnim;
    [FieldOffset(0x02BC)] public bool bIsFinishOutAnim;
    [FieldOffset(0x02BD)] public bool bIsKeyOutAnim;
    [FieldOffset(0x02BE)] public bool bReturnSceneOptionAnim;
    [FieldOffset(0x02BF)] public bool bIsStartInNetworkIconAnim;
    [FieldOffset(0x02C0)] public bool bIsFinishInNetworkIconAnim;
    [FieldOffset(0x02C1)] public bool bIsStartOutNetworkIconAnim;
    [FieldOffset(0x02C2)] public bool bIsFinishOutNetworkIconAnim;
    [FieldOffset(0x02C3)] public bool bIsStartInBlackBoardAnim;
    [FieldOffset(0x02C4)] public bool bIsFinishInBlackBoardAnim;
    [FieldOffset(0x02C5)] public bool bIsStartOutBlackBoardAnim;
    [FieldOffset(0x02C6)] public bool bIsFinishOutBlackBoardAnim;
    [FieldOffset(0x02C7)] public bool IsStartGetData;
    [FieldOffset(0x02C8)] public bool IsGetData;
    [FieldOffset(0x02C9)] public bool IsDisp;
    [FieldOffset(0x02D0)] public USprAsset* SprData;
    [FieldOffset(0x02D8)] public UPlgAsset* PlgData;
    [FieldOffset(0x02E0)] public int OffStartFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct AUIVoiceConnect
{
    [FieldOffset(0x0000)] public AUIVoiceBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AUIVoiceConnectWatching
{
    [FieldOffset(0x0000)] public AUIBaseActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x268)] 
public unsafe struct AUmgDebugLogActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UUmgDebugLogWidget
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct UUmgDialog
{
    [FieldOffset(0x0000)] public UUserWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct AUmgDialogActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UUtlBpObjManager
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public UUtlBpObjCore* mObject_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UUtlProcManager
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0030)] public AUtlProcActor* mNowActor_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UVeveWork
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UDataTable* pTable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C8)] 
public unsafe struct AVoiceActionViewer
{
    [FieldOffset(0x0000)] public ADebugViewer baseObj;
    [FieldOffset(0x02C0)] public AUIVoiceAction* pActionVoiceSystem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x478)] 
public unsafe struct UXrd777AssetManager
{
    [FieldOffset(0x0000)] public UAssetManager baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct AAPPGameModeBase
{
    [FieldOffset(0x0000)] public AGameModeBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UXrd777PrimaryAssetLabel
{
    [FieldOffset(0x0000)] public UPrimaryAssetLabel baseObj;
    [FieldOffset(0x0068)] public TMap<FString, FPrimaryAssetRules> PlatformRules;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3806F8)] 
public unsafe struct UXRD777SaveGame
{
    [FieldOffset(0x0000)] public USaveGame baseObj;
    [FieldOffset(0x0028)] public FSaveGameHeadder SaveDataHeadder;
    [FieldOffset(0x00F8)] public uint SaveDataArea;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UXrd777SaveManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0058)] public UTCSSaveData* TCSSaveData;
    [FieldOffset(0x0070)] public UXRD777SaveGame* NetworkSaveInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct FAppNpcCostumeData
{
    [FieldOffset(0x0000)] public FAppNpcCostumePartsData Base;
    [FieldOffset(0x00A0)] public FAppNpcCostumePartsData Costume;
    [FieldOffset(0x0140)] public FAppNpcCostumePartsData Hair;
    [FieldOffset(0x01E0)] public FAppNpcCostumePartsData Face;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FAppNpcSkeletonTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector MeshLocation;
    [FieldOffset(0x0018)] public TMap<EAnimPackID, TSoftObjectPtr<UAppCharAnimDataAsset>> Anims;
    [FieldOffset(0x0068)] public TMap<int, FAppNpcCostumeData> Costumes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAppCharCostumePartsData
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<USkeletalMesh> Mesh;
    [FieldOffset(0x0028)] public TSoftClassPtr<UObject> Anim;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct FAppCharCostumeData
{
    [FieldOffset(0x0000)] public FAppCharCostumePartsData Base;
    [FieldOffset(0x0050)] public FAppCharCostumePartsData Costume;
    [FieldOffset(0x00A0)] public FAppCharCostumePartsData Hair;
    [FieldOffset(0x00F0)] public FAppCharCostumePartsData Face;
    [FieldOffset(0x0140)] public int BagKeyID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAppCharWeaponData
{
    [FieldOffset(0x0000)] public TArray<TSoftClassPtr<AAppCharWeaponBase>> BluePrints;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FAppCharBagData
{
    [FieldOffset(0x0000)] public TSoftClassPtr<AAppPropsCore> Base;
    [FieldOffset(0x0028)] public FName AttachSocketName;
    [FieldOffset(0x0030)] public FName SetAnimSlotName;
    [FieldOffset(0x0038)] public TMap<EAppCharBagAnimType, TSoftObjectPtr<UAnimSequenceBase>> AnimSeqs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct FAppCharTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float CapsuleHalfHeight;
    [FieldOffset(0x000C)] public FVector MeshLocation;
    [FieldOffset(0x0018)] public TMap<EAnimPackID, TSoftObjectPtr<UAppCharAnimDataAsset>> Anims;
    [FieldOffset(0x0068)] public TSoftObjectPtr<UAppCharFaceAnimDataAsset> FaceAnim;
    [FieldOffset(0x0090)] public TMap<int, FAppCharCostumeData> Costumes;
    [FieldOffset(0x00E0)] public TMap<int, FAppCharWeaponData> WeaponType;
    [FieldOffset(0x0130)] public TMap<int, FAppCharBagData> BagType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAppPropsCardTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EAppPropsCardType Type;
    [FieldOffset(0x0010)] public TSoftObjectPtr<UTexture> Texture;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtlEvtEventManagerInitializer
{
    [FieldOffset(0x0000)] public FString EventRank;
    [FieldOffset(0x0010)] public UMovieSceneSequencePlayer* EventSequencePlayer;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAtlEvtHandwritingDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EAppCharCategoryType CharCategoryType;
    [FieldOffset(0x000C)] public int CharaIndexID;
    [FieldOffset(0x0010)] public EAtlEvtHandwritingType HandwritingType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3D0)] 
public unsafe struct FAtlEvtPreDataTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int EventMajorID;
    [FieldOffset(0x000C)] public int EventMinorID;
    [FieldOffset(0x0010)] public FName EventRank;
    [FieldOffset(0x0018)] public FName EventType;
    [FieldOffset(0x0020)] public FString EventLevel;
    [FieldOffset(0x0030)] public int BGFieldMajorID0;
    [FieldOffset(0x0034)] public int BGFieldMinorID0;
    [FieldOffset(0x0038)] public FString BGFieldSubLevel0_0;
    [FieldOffset(0x0048)] public FString BGFieldSubLevel0_1;
    [FieldOffset(0x0058)] public FString BGFieldSubLevel0_2;
    [FieldOffset(0x0068)] public FString BGFieldSubLevel0_3;
    [FieldOffset(0x0078)] public FString BGFieldSubLevel0_4;
    [FieldOffset(0x0088)] public FString BGFieldSeasonSubLevel0_0;
    [FieldOffset(0x0098)] public FString BGFieldSoundSubLevel0_0;
    [FieldOffset(0x00A8)] public int BGFieldMajorID1;
    [FieldOffset(0x00AC)] public int BGFieldMinorID1;
    [FieldOffset(0x00B0)] public FString BGFieldSubLevel1_0;
    [FieldOffset(0x00C0)] public FString BGFieldSubLevel1_1;
    [FieldOffset(0x00D0)] public FString BGFieldSubLevel1_2;
    [FieldOffset(0x00E0)] public FString BGFieldSubLevel1_3;
    [FieldOffset(0x00F0)] public FString BGFieldSubLevel1_4;
    [FieldOffset(0x0100)] public FString BGFieldSeasonSubLevel1_0;
    [FieldOffset(0x0110)] public FString BGFieldSoundSubLevel1_0;
    [FieldOffset(0x0120)] public int BGFieldMajorID2;
    [FieldOffset(0x0124)] public int BGFieldMinorID2;
    [FieldOffset(0x0128)] public FString BGFieldSubLevel2_0;
    [FieldOffset(0x0138)] public FString BGFieldSubLevel2_1;
    [FieldOffset(0x0148)] public FString BGFieldSubLevel2_2;
    [FieldOffset(0x0158)] public FString BGFieldSubLevel2_3;
    [FieldOffset(0x0168)] public FString BGFieldSubLevel2_4;
    [FieldOffset(0x0178)] public FString BGFieldSeasonSubLevel2_0;
    [FieldOffset(0x0188)] public FString BGFieldSoundSubLevel2_0;
    [FieldOffset(0x0198)] public int BGFieldMajorID3;
    [FieldOffset(0x019C)] public int BGFieldMinorID3;
    [FieldOffset(0x01A0)] public FString BGFieldSubLevel3_0;
    [FieldOffset(0x01B0)] public FString BGFieldSubLevel3_1;
    [FieldOffset(0x01C0)] public FString BGFieldSubLevel3_2;
    [FieldOffset(0x01D0)] public FString BGFieldSubLevel3_3;
    [FieldOffset(0x01E0)] public FString BGFieldSubLevel3_4;
    [FieldOffset(0x01F0)] public FString BGFieldSeasonSubLevel3_0;
    [FieldOffset(0x0200)] public FString BGFieldSoundSubLevel3_0;
    [FieldOffset(0x0210)] public int BGFieldMajorID4;
    [FieldOffset(0x0214)] public int BGFieldMinorID4;
    [FieldOffset(0x0218)] public FString BGFieldSubLevel4_0;
    [FieldOffset(0x0228)] public FString BGFieldSubLevel4_1;
    [FieldOffset(0x0238)] public FString BGFieldSubLevel4_2;
    [FieldOffset(0x0248)] public FString BGFieldSubLevel4_3;
    [FieldOffset(0x0258)] public FString BGFieldSubLevel4_4;
    [FieldOffset(0x0268)] public FString BGFieldSeasonSubLevel4_0;
    [FieldOffset(0x0278)] public FString BGFieldSoundSubLevel4_0;
    [FieldOffset(0x0288)] public int BGFieldMajorID5;
    [FieldOffset(0x028C)] public int BGFieldMinorID5;
    [FieldOffset(0x0290)] public FString BGFieldSubLevel5_0;
    [FieldOffset(0x02A0)] public FString BGFieldSubLevel5_1;
    [FieldOffset(0x02B0)] public FString BGFieldSubLevel5_2;
    [FieldOffset(0x02C0)] public FString BGFieldSubLevel5_3;
    [FieldOffset(0x02D0)] public FString BGFieldSubLevel5_4;
    [FieldOffset(0x02E0)] public FString BGFieldSeasonSubLevel5_0;
    [FieldOffset(0x02F0)] public FString BGFieldSoundSubLevel5_0;
    [FieldOffset(0x0300)] public int BGFieldMajorID6;
    [FieldOffset(0x0304)] public int BGFieldMinorID6;
    [FieldOffset(0x0308)] public FString BGFieldSubLevel6_0;
    [FieldOffset(0x0318)] public FString BGFieldSubLevel6_1;
    [FieldOffset(0x0328)] public FString BGFieldSubLevel6_2;
    [FieldOffset(0x0338)] public FString BGFieldSubLevel6_3;
    [FieldOffset(0x0348)] public FString BGFieldSubLevel6_4;
    [FieldOffset(0x0358)] public FString BGFieldSeasonSubLevel6_0;
    [FieldOffset(0x0368)] public FString BGFieldSoundSubLevel6_0;
    [FieldOffset(0x0378)] public FName LightScenario0;
    [FieldOffset(0x0380)] public FName LightScenario1;
    [FieldOffset(0x0388)] public FName LightScenario2;
    [FieldOffset(0x0390)] public FName LightScenario3;
    [FieldOffset(0x0398)] public FName LightScenario4;
    [FieldOffset(0x03A0)] public FName LightScenario5;
    [FieldOffset(0x03A8)] public FName LightScenario6;
    [FieldOffset(0x03B0)] public FName DungeonFloorSubLevel;
    [FieldOffset(0x03B8)] public FName DungeonEnvironmentSubLevel;
    [FieldOffset(0x03C0)] public bool DisableAutoLoadFirstLightingScenarioLevel;
    [FieldOffset(0x03C1)] public bool ForceDisableUseCurrentTimeZone;
    [FieldOffset(0x03C4)] public int ForceMonth;
    [FieldOffset(0x03C8)] public int ForceDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FAtlEvtPlayingEventInfo
{
    [FieldOffset(0x0000)] public FString EventLevelName;
    [FieldOffset(0x0010)] public int EventCategoryTypeID;
    [FieldOffset(0x0018)] public FString EventCategory;
    [FieldOffset(0x0028)] public FString EventRank;
    [FieldOffset(0x0038)] public int EventMajorID;
    [FieldOffset(0x003C)] public int EventMinorID;
    [FieldOffset(0x0040)] public TWeakObjectPtr<AAtlEvtLevelSequenceActor> AtlEvtLevelSequenceActor;
    [FieldOffset(0x0048)] public TWeakObjectPtr<AAtlEvtEventManager> AtlEvtEventManagerActor;
    [FieldOffset(0x0050)] public int EventFirstFieldMajorID;
    [FieldOffset(0x0054)] public int EventFirstFieldMinorID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBtlCharacterWeaponVisibility
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public bool ShowWeapon;
    [FieldOffset(0x0009)] public bool ShowGun;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBtlCharacterFaceAnim
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName SectionName;
    [FieldOffset(0x0010)] public EAppCharFaceAnimID FaceType;
    [FieldOffset(0x0011)] public bool NotPlay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBtlCharacterVisual
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public bool Movable;
    [FieldOffset(0x0009)] public bool AttackWithMove;
    [FieldOffset(0x000C)] public float AttackRange;
    [FieldOffset(0x0010)] public TArray<float> AttackDegree;
    [FieldOffset(0x0020)] public bool HasMultiPersonalMotion;
    [FieldOffset(0x0021)] public bool UseShakingWhenDownDamage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlCylinder
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector CenterBottom;
    [FieldOffset(0x0014)] public float Radius;
    [FieldOffset(0x0018)] public float Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FBtlPersonaVisual
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector SummonLocation;
    [FieldOffset(0x0014)] public FRotator SummonRotation;
    [FieldOffset(0x0020)] public FVector PhysicsLocation;
    [FieldOffset(0x002C)] public FRotator PhysicsRotation;
    [FieldOffset(0x0038)] public FVector MagicLocation;
    [FieldOffset(0x0044)] public FRotator MagicRotation;
    [FieldOffset(0x0050)] public FVector CustomCutinLocation;
    [FieldOffset(0x005C)] public FRotator CustomCutinRotation;
    [FieldOffset(0x0068)] public float PhysicalSkillRange;
    [FieldOffset(0x006C)] public bool DisableBackShotCamera;
    [FieldOffset(0x006D)] public bool UseLSizeCutin;
    [FieldOffset(0x006E)] public bool UseCustomCutinLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FBtlDamageParam
{
    [FieldOffset(0x0000)] public int Damage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FBtlCalcCameraPosParam
{
    [FieldOffset(0x0000)] public EBtlCalcCameraCylinderType CylinderType;
    [FieldOffset(0x0001)] public bool DirectToOrigin;
    [FieldOffset(0x0002)] public bool DirectAlongLookedAtCharacter;
    [FieldOffset(0x0004)] public float RotateDegree;
    [FieldOffset(0x0008)] public float RadiusRatio;
    [FieldOffset(0x000C)] public float RadiusAdd;
    [FieldOffset(0x0010)] public float RadiusAddHeightRatio;
    [FieldOffset(0x0014)] public float HeightRatio;
    [FieldOffset(0x0018)] public float HeightAddRadiusRatio;
    [FieldOffset(0x001C)] public EBtlCalcCameraLookAtType LookAtTarget;
    [FieldOffset(0x0020)] public float LookAtCylinderHightRatio;
    [FieldOffset(0x0024)] public float LookAtBlendToCenter;
    [FieldOffset(0x0028)] public float LookAtLineRatio;
    [FieldOffset(0x002C)] public bool UseRoll;
    [FieldOffset(0x0030)] public float Roll;
    [FieldOffset(0x0034)] public float HeightBlend;
    [FieldOffset(0x0038)] public float HeightDefault;
    [FieldOffset(0x003C)] public float Pan;
    [FieldOffset(0x0040)] public float PanV;
    [FieldOffset(0x0044)] public float SlideCamX;
    [FieldOffset(0x0048)] public bool UseCommonCylinder;
    [FieldOffset(0x0049)] public bool ExceptPersonaCylinder;
    [FieldOffset(0x0050)] public FTransform WorldTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct FBtlCalcCameraData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0010)] public FBtlCalcCameraPosParam Start;
    [FieldOffset(0x0090)] public FBtlCalcCameraPosParam Goal;
    [FieldOffset(0x0110)] public float AnimTime;
    [FieldOffset(0x0114)] public bool RefleshEachFrame;
    [FieldOffset(0x0118)] public UCurveFloat* Curve;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBtlCameraParam
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float HideOtherProcCylinderRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBtlCutsceneData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TSoftObjectPtr<ULevelSequence> Cutscene;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBtlFormationUnit
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector Translation;
    [FieldOffset(0x0014)] public FRotator Rotation;
    [FieldOffset(0x0020)] public int ID;
    [FieldOffset(0x0024)] public EBtlSizeCategoryType SizeCategory;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBtlFormationData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FBtlFormationUnit> PlayerPositions;
    [FieldOffset(0x0018)] public TArray<FBtlFormationUnit> EnemyPositions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FBtlAnalyzeHighAnalyzePrimitive
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectPrimitive* Object;
    [FieldOffset(0x0008)] public float PosX;
    [FieldOffset(0x000C)] public float PosY;
    [FieldOffset(0x0010)] public float Width;
    [FieldOffset(0x0014)] public bool isReflectX;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBtlAnalyzeItemSpace
{
    [FieldOffset(0x0000)] public FVector Pos;
    [FieldOffset(0x0010)] public UBtlGuiDrawObjectText* Text;
    [FieldOffset(0x0018)] public UBtlGuiDrawObjectSprite* Icon;
    [FieldOffset(0x0020)] public UBtlGuiDrawObjectSprite* NoneIcon;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBtlAnalyzeSkillSpace
{
    [FieldOffset(0x0000)] public FVector Pos;
    [FieldOffset(0x0010)] public UBtlGuiDrawObjectText* Text;
    [FieldOffset(0x0018)] public UBtlGuiDrawObjectSprite* Icon;
    [FieldOffset(0x0020)] public UBtlGuiDrawObjectRoundRect* BGRect;
    [FieldOffset(0x0028)] public UBtlGuiDrawObjectSprite* NoneIcon;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FBtlAnalyzeScanPrimitive
{
    [FieldOffset(0x0000)] public TArray<IntPtr> objects;
    [FieldOffset(0x0010)] public float Size;
    [FieldOffset(0x0014)] public float Alpha;
    [FieldOffset(0x0018)] public TArray<float> MoveX;
    [FieldOffset(0x0028)] public TArray<float> MoveY;
    [FieldOffset(0x0038)] public float MoveToX;
    [FieldOffset(0x003C)] public float MoveToY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct FBtlAnalyzeAffinityIcon
{
    [FieldOffset(0x0000)] public FVector Pos;
    [FieldOffset(0x0010)] public UBtlGuiDrawObjectSprite* Icon;
    [FieldOffset(0x0018)] public UBtlGuiDrawObjectSprite* BGRect;
    [FieldOffset(0x0020)] public UBtlGuiDrawObjectSprite* WeakIn;
    [FieldOffset(0x0028)] public UBtlGuiDrawObjectSprite* WeakOut;
    [FieldOffset(0x0030)] public UBtlGuiDrawObjectSprite* WeakInDupli;
    [FieldOffset(0x0038)] public UBtlGuiDrawObjectSprite* WeakOutDupli;
    [FieldOffset(0x0040)] public float AlphaWeakDupli;
    [FieldOffset(0x0044)] public float ScaleWeakDupli;
    [FieldOffset(0x0048)] public float TimeWeakDupli;
    [FieldOffset(0x004C)] public bool isPlayingInAnime;
    [FieldOffset(0x0050)] public UBtlGuiDrawObjectSprite* ResistIcon;
    [FieldOffset(0x0058)] public UBtlGuiDrawObjectSprite* ResistText;
    [FieldOffset(0x0060)] public UBtlGuiDrawObjectSprite* ResistTextBlur;
    [FieldOffset(0x0068)] public UBtlGuiDrawObjectPlg* ScanUnknownIcon;
    [FieldOffset(0x0070)] public UBtlGuiDrawObjectSprite* ScanUnknownIconBlur;
    [FieldOffset(0x0078)] public UBtlGuiDrawObjectPlg* ScanResistIcon;
    [FieldOffset(0x0080)] public UBtlGuiDrawObjectSprite* ScanResistIconBlur;
    [FieldOffset(0x0088)] public UBtlGuiDrawObjectSprite* RippleEffectLarge;
    [FieldOffset(0x0090)] public UBtlGuiDrawObjectSprite* RippleEffectSmall;
    [FieldOffset(0x0098)] public UBtlGuiDrawObjectSprite* KnownEffect;
    [FieldOffset(0x00A0)] public UBtlGuiDrawObjectSprite* SmallScanUnknownIconBlur;
    [FieldOffset(0x00A8)] public FBtlAnalyzeScanPrimitive ScanPrimitive;
    [FieldOffset(0x00E8)] public float TimeScan1;
    [FieldOffset(0x00EC)] public float AlphaUnknownIcon;
    [FieldOffset(0x00F0)] public float TimeScan2;
    [FieldOffset(0x00F4)] public float AlphaResistIcon;
    [FieldOffset(0x00F8)] public float AlphaRippleEffec;
    [FieldOffset(0x00FC)] public float SizeRippleEffect;
    [FieldOffset(0x0100)] public float AlphaKnownEffect;
    [FieldOffset(0x0104)] public bool isHighAnalyzeAnime;
    [FieldOffset(0x0105)] public bool isShowNewAttr;
    [FieldOffset(0x0108)] public FVector2D KnownIconPosDif;
    [FieldOffset(0x0110)] public float RationDetailMove;
    [FieldOffset(0x0114)] public FColor ColorIcon;
    [FieldOffset(0x0118)] public bool IsWeakKnownIcon;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5C)] 
public unsafe struct FShuffleBackGroundPrimitiveDrawObject
{
    [FieldOffset(0x0000)] public float SlideX;
    [FieldOffset(0x0004)] public float ScaleW;
    [FieldOffset(0x0008)] public float ScaleH;
    [FieldOffset(0x000C)] public FVector PosBase;
    [FieldOffset(0x0018)] public float RotationBase;
    [FieldOffset(0x001C)] public float RotationBeforeExpansion;
    [FieldOffset(0x0020)] public float RotationAfterExpansion;
    [FieldOffset(0x0024)] public float SpeedRotationBeforeExpansion;
    [FieldOffset(0x0028)] public float SpeedRotationAfterExpansion;
    [FieldOffset(0x002C)] public float TimeRotationBeforeExpansion;
    [FieldOffset(0x0030)] public float TimeRotationAfterExpansion;
    [FieldOffset(0x0034)] public float ChangeTimeRotationBeforeExpansion;
    [FieldOffset(0x0038)] public float ChangeTimeRotationAfterExpansion;
    [FieldOffset(0x003C)] public FVector Move;
    [FieldOffset(0x0048)] public FVector SpeedMove;
    [FieldOffset(0x0054)] public float TimeMove;
    [FieldOffset(0x0058)] public float ChangeTimeMove;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FShuffleSmallArcanaDrawObject
{
    [FieldOffset(0x0000)] public UBtlGuiDrawObjectSprite* Card;
    [FieldOffset(0x0008)] public UBtlGuiDrawObjectSprite* Shine1;
    [FieldOffset(0x0010)] public UBtlGuiDrawObjectSprite* Shine2;
    [FieldOffset(0x0018)] public UBtlGuiDrawObjectSprite* Frame;
    [FieldOffset(0x0020)] public UBtlGuiDrawObjectSprite* BonusShine;
    [FieldOffset(0x0028)] public UBtlGuiDrawObjectSprite* Glow;
    [FieldOffset(0x0030)] public UBtlGuiDrawObjectSprite* GetEffect;
    [FieldOffset(0x0038)] public bool isNewGetArcana;
    [FieldOffset(0x003C)] public float GlowAlpha;
    [FieldOffset(0x0040)] public float GlowWaitAnimeTime;
    [FieldOffset(0x0044)] public bool isStartGlowWaitAnime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBtlSkillEnvParam
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float FadeTime;
    [FieldOffset(0x000C)] public float FogPower;
    [FieldOffset(0x0010)] public float FogDistance;
    [FieldOffset(0x0014)] public float FogGradationRange;
    [FieldOffset(0x0018)] public float LightIntensityRatio;
    [FieldOffset(0x001C)] public float BGBlackRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FBtlCutinBackGround
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TSoftObjectPtr<UMaterialInstance> BackGround;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatBtlMixraidReleaseDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort PersonaAID;
    [FieldOffset(0x000A)] public ushort PersonaBID;
    [FieldOffset(0x000C)] public uint flag;
    [FieldOffset(0x0010)] public ushort Skill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatBtlTheurgiaBoostDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public short Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatEncountEnemyBadPercentDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte Num1;
    [FieldOffset(0x0009)] public byte Num2;
    [FieldOffset(0x000A)] public byte Num3;
    [FieldOffset(0x000B)] public byte Num4;
    [FieldOffset(0x000C)] public byte NumOver5;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatCalcPANICUseItemDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort ItemId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatCalcPANICDropItemDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FDatEnemyItemTable item0;
    [FieldOffset(0x000C)] public FDatEnemyItemTable item1;
    [FieldOffset(0x0010)] public FDatEnemyItemTable item2;
    [FieldOffset(0x0014)] public FDatEnemyItemTable item3;
    [FieldOffset(0x0018)] public FDatEnemyItemTable item4;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleCommonRationDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleAppearRationDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleCommonItemdropArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte RankID;
    [FieldOffset(0x0009)] public byte Num;
    [FieldOffset(0x000A)] public ushort prob;
    [FieldOffset(0x000C)] public uint ItemtID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleCommonCoefficientArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDatShuffleArcanaNameDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FText Name;
    [FieldOffset(0x0020)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleLoversArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort CommuBonus;
    [FieldOffset(0x000A)] public ushort LoversBonus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleCupArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte RankID;
    [FieldOffset(0x0009)] public byte EffectID;
    [FieldOffset(0x000C)] public uint prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShuffleCoinArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Max;
    [FieldOffset(0x000C)] public uint Min;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatShufflePersonaArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte RankID;
    [FieldOffset(0x0009)] public byte PersonaID;
    [FieldOffset(0x000A)] public byte prob;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatShuffleChoiceMajorArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte ArcanaID;
    [FieldOffset(0x0009)] public byte RankInPhase;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2)] 
public unsafe struct FDatShuffleMajorArcanaCard
{
    [FieldOffset(0x0000)] public byte Type;
    [FieldOffset(0x0001)] public byte Rank;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FDatShuffleChoiceMinorArcanaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte AreaId;
    [FieldOffset(0x000C)] public int LowPersonaRankId;
    [FieldOffset(0x0010)] public int HightPersonaRankId;
    [FieldOffset(0x0014)] public int LowWandRankId;
    [FieldOffset(0x0018)] public int HightWandRankId;
    [FieldOffset(0x001C)] public int LowCoinRankId;
    [FieldOffset(0x0020)] public int HightCoinRankId;
    [FieldOffset(0x0024)] public int LowCupRankId;
    [FieldOffset(0x0028)] public int HightCupRankId;
    [FieldOffset(0x002C)] public int LowSwordRankId;
    [FieldOffset(0x0030)] public int HightSwordRankId;
    [FieldOffset(0x0034)] public int CardNumProb;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDatRaceDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FText Name1;
    [FieldOffset(0x0020)] public FText Name2;
    [FieldOffset(0x0038)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatSupportInfoDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint defineId;
    [FieldOffset(0x000C)] public uint majorId;
    [FieldOffset(0x0010)] public uint minorId;
    [FieldOffset(0x0014)] public uint characterId;
    [FieldOffset(0x0018)] public byte show;
    [FieldOffset(0x0019)] public byte Face;
    [FieldOffset(0x001A)] public byte Window;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDatNormalSkillDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint flag;
    [FieldOffset(0x000C)] public ushort use;
    [FieldOffset(0x000E)] public byte koukatype;
    [FieldOffset(0x000F)] public byte costtype;
    [FieldOffset(0x0010)] public ushort cost;
    [FieldOffset(0x0012)] public ushort costbase;
    [FieldOffset(0x0014)] public byte TargetType;
    [FieldOffset(0x0015)] public byte targetarea;
    [FieldOffset(0x0016)] public byte targetrule;
    [FieldOffset(0x0018)] public uint untargetbadstat;
    [FieldOffset(0x001C)] public byte hitratio;
    [FieldOffset(0x001D)] public byte targetcntmin;
    [FieldOffset(0x001E)] public byte targetcntmax;
    [FieldOffset(0x001F)] public byte hptype;
    [FieldOffset(0x0020)] public short hpn;
    [FieldOffset(0x0022)] public byte sptype;
    [FieldOffset(0x0024)] public short spn;
    [FieldOffset(0x0026)] public byte badtype;
    [FieldOffset(0x0027)] public byte badratio;
    [FieldOffset(0x0028)] public uint BadStatus;
    [FieldOffset(0x002C)] public uint support;
    [FieldOffset(0x0030)] public byte program;
    [FieldOffset(0x0031)] public byte criticalratio;
    [FieldOffset(0x0032)] public byte swoonratio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatSkillDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public sbyte attr;
    [FieldOffset(0x0009)] public sbyte Type;
    [FieldOffset(0x000A)] public sbyte targetLv;
}

[StructLayout(LayoutKind.Explicit, Size = 0x190)] 
public unsafe struct FDatAllyPersonaExpDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Exp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B8)] 
public unsafe struct FDatAllyPersonaGrowthDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte PlayerId;
    [FieldOffset(0x0009)] public byte levelMax;
    [FieldOffset(0x000A)] public FDatPersonaGrowthEventTable skillEvent0;
    [FieldOffset(0x0010)] public FDatPersonaGrowthEventTable skillEvent1;
    [FieldOffset(0x0016)] public FDatPersonaGrowthEventTable skillEvent2;
    [FieldOffset(0x001C)] public FDatPersonaGrowthEventTable skillEvent3;
    [FieldOffset(0x0022)] public FDatPersonaGrowthEventTable skillEvent4;
    [FieldOffset(0x0028)] public FDatPersonaGrowthEventTable skillEvent5;
    [FieldOffset(0x002E)] public FDatPersonaGrowthEventTable skillEvent6;
    [FieldOffset(0x0034)] public FDatPersonaGrowthEventTable skillEvent7;
    [FieldOffset(0x003A)] public FDatPersonaGrowthEventTable skillEvent8;
    [FieldOffset(0x0040)] public FDatPersonaGrowthEventTable skillEvent9;
    [FieldOffset(0x0046)] public FDatPersonaGrowthEventTable skillEvent10;
    [FieldOffset(0x004C)] public FDatPersonaGrowthEventTable skillEvent11;
    [FieldOffset(0x0052)] public FDatPersonaGrowthEventTable skillEvent12;
    [FieldOffset(0x0058)] public FDatPersonaGrowthEventTable skillEvent13;
    [FieldOffset(0x005E)] public FDatPersonaGrowthEventTable skillEvent14;
    [FieldOffset(0x0064)] public FDatPersonaGrowthEventTable skillEvent15;
    [FieldOffset(0x006A)] public FDatPersonaGrowthEventTable skillEvent16;
    [FieldOffset(0x0070)] public FDatPersonaGrowthEventTable skillEvent17;
    [FieldOffset(0x0076)] public FDatPersonaGrowthEventTable skillEvent18;
    [FieldOffset(0x007C)] public FDatPersonaGrowthEventTable skillEvent19;
    [FieldOffset(0x0082)] public FDatPersonaGrowthEventTable skillEvent20;
    [FieldOffset(0x0088)] public FDatPersonaGrowthEventTable skillEvent21;
    [FieldOffset(0x008E)] public FDatPersonaGrowthEventTable skillEvent22;
    [FieldOffset(0x0094)] public FDatPersonaGrowthEventTable skillEvent23;
    [FieldOffset(0x009A)] public FDatPersonaGrowthEventTable skillEvent24;
    [FieldOffset(0x00A0)] public FDatPersonaGrowthEventTable skillEvent25;
    [FieldOffset(0x00A6)] public FDatPersonaGrowthEventTable skillEvent26;
    [FieldOffset(0x00AC)] public FDatPersonaGrowthEventTable skillEvent27;
    [FieldOffset(0x00B2)] public FDatPersonaGrowthEventTable skillEvent28;
    [FieldOffset(0x00B8)] public FDatPersonaGrowthEventTable skillEvent29;
    [FieldOffset(0x00BE)] public FDatPersonaGrowthEventTable skillEvent30;
    [FieldOffset(0x00C4)] public FDatPersonaGrowthEventTable skillEvent31;
    [FieldOffset(0x00CA)] public FDatLevelupParam param0;
    [FieldOffset(0x00CF)] public FDatLevelupParam Param1;
    [FieldOffset(0x00D4)] public FDatLevelupParam Param2;
    [FieldOffset(0x00D9)] public FDatLevelupParam param3;
    [FieldOffset(0x00DE)] public FDatLevelupParam param4;
    [FieldOffset(0x00E3)] public FDatLevelupParam param5;
    [FieldOffset(0x00E8)] public FDatLevelupParam param6;
    [FieldOffset(0x00ED)] public FDatLevelupParam param7;
    [FieldOffset(0x00F2)] public FDatLevelupParam param8;
    [FieldOffset(0x00F7)] public FDatLevelupParam param9;
    [FieldOffset(0x00FC)] public FDatLevelupParam param10;
    [FieldOffset(0x0101)] public FDatLevelupParam param11;
    [FieldOffset(0x0106)] public FDatLevelupParam param12;
    [FieldOffset(0x010B)] public FDatLevelupParam param13;
    [FieldOffset(0x0110)] public FDatLevelupParam param14;
    [FieldOffset(0x0115)] public FDatLevelupParam param15;
    [FieldOffset(0x011A)] public FDatLevelupParam param16;
    [FieldOffset(0x011F)] public FDatLevelupParam param17;
    [FieldOffset(0x0124)] public FDatLevelupParam param18;
    [FieldOffset(0x0129)] public FDatLevelupParam param19;
    [FieldOffset(0x012E)] public FDatLevelupParam param20;
    [FieldOffset(0x0133)] public FDatLevelupParam param21;
    [FieldOffset(0x0138)] public FDatLevelupParam param22;
    [FieldOffset(0x013D)] public FDatLevelupParam param23;
    [FieldOffset(0x0142)] public FDatLevelupParam param24;
    [FieldOffset(0x0147)] public FDatLevelupParam param25;
    [FieldOffset(0x014C)] public FDatLevelupParam param26;
    [FieldOffset(0x0151)] public FDatLevelupParam param27;
    [FieldOffset(0x0156)] public FDatLevelupParam param28;
    [FieldOffset(0x015B)] public FDatLevelupParam param29;
    [FieldOffset(0x0160)] public FDatLevelupParam param30;
    [FieldOffset(0x0165)] public FDatLevelupParam param31;
    [FieldOffset(0x016A)] public FDatLevelupParam param32;
    [FieldOffset(0x016F)] public FDatLevelupParam param33;
    [FieldOffset(0x0174)] public FDatLevelupParam param34;
    [FieldOffset(0x0179)] public FDatLevelupParam param35;
    [FieldOffset(0x017E)] public FDatLevelupParam param36;
    [FieldOffset(0x0183)] public FDatLevelupParam param37;
    [FieldOffset(0x0188)] public FDatLevelupParam param38;
    [FieldOffset(0x018D)] public FDatLevelupParam param39;
    [FieldOffset(0x0192)] public FDatLevelupParam param40;
    [FieldOffset(0x0197)] public FDatLevelupParam param41;
    [FieldOffset(0x019C)] public FDatLevelupParam param42;
    [FieldOffset(0x01A1)] public FDatLevelupParam param43;
    [FieldOffset(0x01A6)] public FDatLevelupParam param44;
    [FieldOffset(0x01AB)] public FDatLevelupParam param45;
    [FieldOffset(0x01B0)] public FDatLevelupParam param46;
    [FieldOffset(0x01B5)] public FDatLevelupParam param47;
    [FieldOffset(0x01BA)] public FDatLevelupParam param48;
    [FieldOffset(0x01BF)] public FDatLevelupParam param49;
    [FieldOffset(0x01C4)] public FDatLevelupParam param50;
    [FieldOffset(0x01C9)] public FDatLevelupParam param51;
    [FieldOffset(0x01CE)] public FDatLevelupParam param52;
    [FieldOffset(0x01D3)] public FDatLevelupParam param53;
    [FieldOffset(0x01D8)] public FDatLevelupParam param54;
    [FieldOffset(0x01DD)] public FDatLevelupParam param55;
    [FieldOffset(0x01E2)] public FDatLevelupParam param56;
    [FieldOffset(0x01E7)] public FDatLevelupParam param57;
    [FieldOffset(0x01EC)] public FDatLevelupParam param58;
    [FieldOffset(0x01F1)] public FDatLevelupParam param59;
    [FieldOffset(0x01F6)] public FDatLevelupParam param60;
    [FieldOffset(0x01FB)] public FDatLevelupParam param61;
    [FieldOffset(0x0200)] public FDatLevelupParam param62;
    [FieldOffset(0x0205)] public FDatLevelupParam param63;
    [FieldOffset(0x020A)] public FDatLevelupParam param64;
    [FieldOffset(0x020F)] public FDatLevelupParam param65;
    [FieldOffset(0x0214)] public FDatLevelupParam param66;
    [FieldOffset(0x0219)] public FDatLevelupParam param67;
    [FieldOffset(0x021E)] public FDatLevelupParam param68;
    [FieldOffset(0x0223)] public FDatLevelupParam param69;
    [FieldOffset(0x0228)] public FDatLevelupParam param70;
    [FieldOffset(0x022D)] public FDatLevelupParam param71;
    [FieldOffset(0x0232)] public FDatLevelupParam param72;
    [FieldOffset(0x0237)] public FDatLevelupParam param73;
    [FieldOffset(0x023C)] public FDatLevelupParam param74;
    [FieldOffset(0x0241)] public FDatLevelupParam param75;
    [FieldOffset(0x0246)] public FDatLevelupParam param76;
    [FieldOffset(0x024B)] public FDatLevelupParam param77;
    [FieldOffset(0x0250)] public FDatLevelupParam param78;
    [FieldOffset(0x0255)] public FDatLevelupParam param79;
    [FieldOffset(0x025A)] public FDatLevelupParam param80;
    [FieldOffset(0x025F)] public FDatLevelupParam param81;
    [FieldOffset(0x0264)] public FDatLevelupParam param82;
    [FieldOffset(0x0269)] public FDatLevelupParam param83;
    [FieldOffset(0x026E)] public FDatLevelupParam param84;
    [FieldOffset(0x0273)] public FDatLevelupParam param85;
    [FieldOffset(0x0278)] public FDatLevelupParam param86;
    [FieldOffset(0x027D)] public FDatLevelupParam param87;
    [FieldOffset(0x0282)] public FDatLevelupParam param88;
    [FieldOffset(0x0287)] public FDatLevelupParam param89;
    [FieldOffset(0x028C)] public FDatLevelupParam param90;
    [FieldOffset(0x0291)] public FDatLevelupParam param91;
    [FieldOffset(0x0296)] public FDatLevelupParam param92;
    [FieldOffset(0x029B)] public FDatLevelupParam param93;
    [FieldOffset(0x02A0)] public FDatLevelupParam param94;
    [FieldOffset(0x02A5)] public FDatLevelupParam param95;
    [FieldOffset(0x02AA)] public FDatLevelupParam param96;
    [FieldOffset(0x02AF)] public FDatLevelupParam param97;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FDatPersonaGrowthDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte paramsUp;
    [FieldOffset(0x000E)] public FDatPersonaGrowthEventTable event0;
    [FieldOffset(0x0014)] public FDatPersonaGrowthEventTable event1;
    [FieldOffset(0x001A)] public FDatPersonaGrowthEventTable event2;
    [FieldOffset(0x0020)] public FDatPersonaGrowthEventTable event3;
    [FieldOffset(0x0026)] public FDatPersonaGrowthEventTable event4;
    [FieldOffset(0x002C)] public FDatPersonaGrowthEventTable event5;
    [FieldOffset(0x0032)] public FDatPersonaGrowthEventTable event6;
    [FieldOffset(0x0038)] public FDatPersonaGrowthEventTable event7;
    [FieldOffset(0x003E)] public FDatPersonaGrowthEventTable event8;
    [FieldOffset(0x0044)] public FDatPersonaGrowthEventTable event9;
    [FieldOffset(0x004A)] public FDatPersonaGrowthEventTable event10;
    [FieldOffset(0x0050)] public FDatPersonaGrowthEventTable event11;
    [FieldOffset(0x0056)] public FDatPersonaGrowthEventTable event12;
    [FieldOffset(0x005C)] public FDatPersonaGrowthEventTable event13;
    [FieldOffset(0x0062)] public FDatPersonaGrowthEventTable event14;
    [FieldOffset(0x0068)] public FDatPersonaGrowthEventTable event15;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FDatAffinityDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Slash;
    [FieldOffset(0x000A)] public ushort strike;
    [FieldOffset(0x000C)] public ushort pierce;
    [FieldOffset(0x000E)] public ushort fire;
    [FieldOffset(0x0010)] public ushort ice;
    [FieldOffset(0x0012)] public ushort electric;
    [FieldOffset(0x0014)] public ushort wind;
    [FieldOffset(0x0016)] public ushort almighty;
    [FieldOffset(0x0018)] public ushort Light;
    [FieldOffset(0x001A)] public ushort dark;
    [FieldOffset(0x001C)] public ushort charm;
    [FieldOffset(0x001E)] public ushort poison;
    [FieldOffset(0x0020)] public ushort upset;
    [FieldOffset(0x0022)] public ushort panic;
    [FieldOffset(0x0024)] public ushort fear;
    [FieldOffset(0x0026)] public ushort anger;
    [FieldOffset(0x0028)] public ushort recovery;
    [FieldOffset(0x002A)] public ushort support;
    [FieldOffset(0x002C)] public ushort Special;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDatPersonaDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort flag;
    [FieldOffset(0x000A)] public byte Race;
    [FieldOffset(0x000B)] public byte Level;
    [FieldOffset(0x000C)] public byte Params;
    [FieldOffset(0x0011)] public byte breakage;
    [FieldOffset(0x0012)] public ushort succession;
    [FieldOffset(0x0014)] public byte conception;
    [FieldOffset(0x0015)] public byte Message;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDatEnemyAnalyzeSyncDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort enemyID0;
    [FieldOffset(0x000A)] public ushort enemyID1;
    [FieldOffset(0x000C)] public ushort enemyID2;
    [FieldOffset(0x000E)] public ushort enemyID3;
    [FieldOffset(0x0010)] public ushort enemyID4;
    [FieldOffset(0x0012)] public ushort enemyID5;
    [FieldOffset(0x0014)] public ushort enemyID6;
    [FieldOffset(0x0016)] public ushort enemyID7;
    [FieldOffset(0x0018)] public ushort enemyID8;
    [FieldOffset(0x001A)] public ushort enemyID9;
    [FieldOffset(0x0020)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FDatEnemyDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint flags;
    [FieldOffset(0x000C)] public byte Race;
    [FieldOffset(0x000E)] public short Level;
    [FieldOffset(0x0010)] public int MaxHp;
    [FieldOffset(0x0014)] public int MaxSp;
    [FieldOffset(0x0018)] public byte Params;
    [FieldOffset(0x001E)] public ushort Skill;
    [FieldOffset(0x0030)] public uint Exp;
    [FieldOffset(0x0034)] public uint money;
    [FieldOffset(0x0038)] public FDatEnemyItemTable item0;
    [FieldOffset(0x003C)] public FDatEnemyItemTable item1;
    [FieldOffset(0x0040)] public FDatEnemyItemTable item2;
    [FieldOffset(0x0044)] public FDatEnemyItemTable item3;
    [FieldOffset(0x0048)] public FDatEnemyEventItemTable eventitem;
    [FieldOffset(0x0050)] public FDatEnemyAttackTable attack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDatEncountDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint flags;
    [FieldOffset(0x000C)] public ushort party_item;
    [FieldOffset(0x000E)] public ushort party_item_num;
    [FieldOffset(0x0010)] public ushort id0;
    [FieldOffset(0x0012)] public ushort id1;
    [FieldOffset(0x0014)] public ushort id2;
    [FieldOffset(0x0016)] public ushort id3;
    [FieldOffset(0x0018)] public ushort id4;
    [FieldOffset(0x001A)] public ushort major;
    [FieldOffset(0x001C)] public ushort Minor;
    [FieldOffset(0x001E)] public ushort Sound;
    [FieldOffset(0x0020)] public ushort shuffleLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDatPlayerLevelUpDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Exp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDatPlayerMaxHPSPDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort MaxHp;
    [FieldOffset(0x000A)] public ushort MaxSp;
    [FieldOffset(0x0010)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FCampHologramTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float ScaleGradient_Holo;
    [FieldOffset(0x000C)] public uint Holog_Frame;
    [FieldOffset(0x0010)] public float TexA_EndRot;
    [FieldOffset(0x0014)] public float TexA_EndU;
    [FieldOffset(0x0018)] public float TexA_EndV;
    [FieldOffset(0x001C)] public float TexA_Scale;
    [FieldOffset(0x0020)] public float TexA_StartRot;
    [FieldOffset(0x0024)] public float TexA_StartU;
    [FieldOffset(0x0028)] public float TexA_StartV;
    [FieldOffset(0x002C)] public float TexB_EndRot;
    [FieldOffset(0x0030)] public float TexB_EndU;
    [FieldOffset(0x0034)] public float TexB_EndV;
    [FieldOffset(0x0038)] public float TexB_Scale;
    [FieldOffset(0x003C)] public float TexB_StartRot;
    [FieldOffset(0x0040)] public float TexB_StartU;
    [FieldOffset(0x0044)] public float TexB_StartV;
    [FieldOffset(0x0048)] public float TexC_EndRot;
    [FieldOffset(0x004C)] public float TexC_EndU;
    [FieldOffset(0x0050)] public float TexC_EndV;
    [FieldOffset(0x0054)] public float TexC_Scale;
    [FieldOffset(0x0058)] public float TexC_StartRot;
    [FieldOffset(0x005C)] public float TexC_StartU;
    [FieldOffset(0x0060)] public float TexC_StartV;
    [FieldOffset(0x0064)] public float TexD_EndRot;
    [FieldOffset(0x0068)] public float TexD_EndU;
    [FieldOffset(0x006C)] public float TexD_EndV;
    [FieldOffset(0x0070)] public float TexD_Scale;
    [FieldOffset(0x0074)] public float TexD_StartRot;
    [FieldOffset(0x0078)] public float TexD_StartU;
    [FieldOffset(0x007C)] public float TexD_StartV;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCampCameraTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector CameraPos;
    [FieldOffset(0x0014)] public FRotator CameraRot;
    [FieldOffset(0x0020)] public FVector CharaPos;
    [FieldOffset(0x002C)] public FRotator CharaRot;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D8)] 
public unsafe struct FCampParamTableCommonRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EOneAnimType ListAllSlideAnimType;
    [FieldOffset(0x000C)] public uint ListAllSlideFrame;
    [FieldOffset(0x0010)] public uint ListAllSlideBackFrame;
    [FieldOffset(0x0014)] public EOneAnimType Edit_List_Cursor_Anim_Type;
    [FieldOffset(0x0018)] public uint Edit_List_Cursor_Slide_Frame;
    [FieldOffset(0x001C)] public EOneAnimType Edit_List_Party_RedCursor_Anim_Type;
    [FieldOffset(0x0020)] public uint Edit_List_Party_RedCursor_Slide_Frame;
    [FieldOffset(0x0024)] public EOneAnimType Edit_List_Commu_RedCursor_Anim_Type;
    [FieldOffset(0x0028)] public uint Edit_List_Commu_RedCursor_Slide_Frame;
    [FieldOffset(0x002C)] public EOneAnimType ListRedSlideAnimType;
    [FieldOffset(0x0030)] public uint ListRedSlideFrame;
    [FieldOffset(0x0034)] public uint ListRedSlideWait;
    [FieldOffset(0x0038)] public uint ListRedSlideBackFrame;
    [FieldOffset(0x003C)] public uint HPSPFlashFrame;
    [FieldOffset(0x0040)] public EOneAnimType TabShakeAnimType;
    [FieldOffset(0x0044)] public uint TabShakeFrame;
    [FieldOffset(0x0048)] public EOneAnimType TabLoopAnimType;
    [FieldOffset(0x004C)] public uint TabLoopFrame;
    [FieldOffset(0x0050)] public EOneAnimType CampOKScaleAnimType;
    [FieldOffset(0x0054)] public uint CampOKScaleFrame;
    [FieldOffset(0x0058)] public uint CampOKScaleWait;
    [FieldOffset(0x005C)] public float CampOKEndScale;
    [FieldOffset(0x0060)] public EOneAnimType CampOKInScaleAnimType;
    [FieldOffset(0x0064)] public uint CampOKInScaleFrame;
    [FieldOffset(0x0068)] public uint CampOKInScaleWait;
    [FieldOffset(0x006C)] public float CampOKInEndScale;
    [FieldOffset(0x0070)] public float CampOKCaptureScale;
    [FieldOffset(0x0074)] public EOneAnimType PartyPanelInFlagSlideAnimType;
    [FieldOffset(0x0078)] public uint PartyPanelInFlagSlideFrame;
    [FieldOffset(0x007C)] public uint PartyPanelInFlagSlideBackFrame;
    [FieldOffset(0x0080)] public EOneAnimType WipeChangeMaskAAnimType;
    [FieldOffset(0x0084)] public uint WipeChangeMaskAFrame;
    [FieldOffset(0x0088)] public EOneAnimType WipeChangeMaskBAnimType;
    [FieldOffset(0x008C)] public uint WipeChangeMaskBFrame;
    [FieldOffset(0x0090)] public uint WipeChangeMaskBWait;
    [FieldOffset(0x0094)] public float WipeChangeCaptureScale;
    [FieldOffset(0x0098)] public uint WipeCloseMaskAFrame;
    [FieldOffset(0x009C)] public uint WipeCloseMaskBWait;
    [FieldOffset(0x00A0)] public EOneAnimType SuitekiAnimType;
    [FieldOffset(0x00A4)] public uint SuitekiFrame;
    [FieldOffset(0x00A8)] public byte HighpassBrightThreshold;
    [FieldOffset(0x00AC)] public float HighpassBrightScale;
    [FieldOffset(0x00B0)] public FColor AoItaColorHigh;
    [FieldOffset(0x00B4)] public FColor AoItaColorMid;
    [FieldOffset(0x00B8)] public FColor AoItaColorLow;
    [FieldOffset(0x00BC)] public FColor GradAUpColorHigh;
    [FieldOffset(0x00C0)] public FColor GradADownColorHigh;
    [FieldOffset(0x00C4)] public FColor GradBUpColorHigh;
    [FieldOffset(0x00C8)] public FColor GradBDownColorHigh;
    [FieldOffset(0x00CC)] public FColor GradAUpColorMid;
    [FieldOffset(0x00D0)] public FColor GradADownColorMid;
    [FieldOffset(0x00D4)] public FColor GradBUpColorMid;
    [FieldOffset(0x00D8)] public FColor GradBDownColorMid;
    [FieldOffset(0x00DC)] public FColor GradAUpColorLow;
    [FieldOffset(0x00E0)] public FColor GradADownColorLow;
    [FieldOffset(0x00E4)] public FColor GradBUpColorLow;
    [FieldOffset(0x00E8)] public FColor GradBDownColorLow;
    [FieldOffset(0x00EC)] public FColor HeroCaptureBgColor;
    [FieldOffset(0x00F0)] public EUIGaussType HeroGaussType;
    [FieldOffset(0x00F1)] public byte HeroGaussHorizontal;
    [FieldOffset(0x00F2)] public byte HeroGaussVertical;
    [FieldOffset(0x00F4)] public float HeroGaussScale;
    [FieldOffset(0x00F8)] public float HeroBlurPrev1Offset;
    [FieldOffset(0x00FC)] public byte HeroBlurPrev1Alpha;
    [FieldOffset(0x0100)] public float HeroBlurPrev2Offset;
    [FieldOffset(0x0104)] public byte HeroBlurPrev2Alpha;
    [FieldOffset(0x0108)] public uint NamiOneFrame;
    [FieldOffset(0x010C)] public float NamiAlpha;
    [FieldOffset(0x0110)] public EUIGaussType NamiGaussType;
    [FieldOffset(0x0114)] public FVector2D NamiTopAOfsPos;
    [FieldOffset(0x011C)] public FVector2D NamiTopAScale;
    [FieldOffset(0x0124)] public FColor NamiTopAColor;
    [FieldOffset(0x0128)] public bool NamiTopAAddBlend;
    [FieldOffset(0x012C)] public FVector2D NamiTopBOfsPos;
    [FieldOffset(0x0134)] public FVector2D NamiTopBScale;
    [FieldOffset(0x013C)] public FColor NamiTopBColor;
    [FieldOffset(0x0140)] public bool NamiTopBAddBlend;
    [FieldOffset(0x0144)] public FVector2D NamiSkillAOfsPos;
    [FieldOffset(0x014C)] public FVector2D NamiSkillAScale;
    [FieldOffset(0x0154)] public FColor NamiSkillAColor;
    [FieldOffset(0x0158)] public bool NamiSkillAAddBlend;
    [FieldOffset(0x015C)] public FVector2D NamiSkillBOfsPos;
    [FieldOffset(0x0164)] public FVector2D NamiSkillBScale;
    [FieldOffset(0x016C)] public FColor NamiSkillBColor;
    [FieldOffset(0x0170)] public bool NamiSkillBAddBlend;
    [FieldOffset(0x0174)] public FVector2D NamiItemAOfsPos;
    [FieldOffset(0x017C)] public FVector2D NamiItemAScale;
    [FieldOffset(0x0184)] public FColor NamiItemAColor;
    [FieldOffset(0x0188)] public bool NamiItemAAddBlend;
    [FieldOffset(0x018C)] public FVector2D NamiItemBOfsPos;
    [FieldOffset(0x0194)] public FVector2D NamiItemBScale;
    [FieldOffset(0x019C)] public FColor NamiItemBColor;
    [FieldOffset(0x01A0)] public bool NamiItemBAddBlend;
    [FieldOffset(0x01A4)] public FVector2D NamiEquipAOfsPos;
    [FieldOffset(0x01AC)] public FVector2D NamiEquipAScale;
    [FieldOffset(0x01B4)] public FColor NamiEquipAColor;
    [FieldOffset(0x01B8)] public bool NamiEquipAAddBlend;
    [FieldOffset(0x01BC)] public FVector2D NamiEquipBOfsPos;
    [FieldOffset(0x01C4)] public FVector2D NamiEquipBScale;
    [FieldOffset(0x01CC)] public FColor NamiEquipBColor;
    [FieldOffset(0x01D0)] public bool NamiEquipBAddBlend;
    [FieldOffset(0x01D4)] public FVector2D NamiPersonaAOfsPos;
    [FieldOffset(0x01DC)] public FVector2D NamiPersonaAScale;
    [FieldOffset(0x01E4)] public FColor NamiPersonaAColor;
    [FieldOffset(0x01E8)] public bool NamiPersonaAAddBlend;
    [FieldOffset(0x01EC)] public FVector2D NamiPersonaBOfsPos;
    [FieldOffset(0x01F4)] public FVector2D NamiPersonaBScale;
    [FieldOffset(0x01FC)] public FColor NamiPersonaBColor;
    [FieldOffset(0x0200)] public bool NamiPersonaBAddBlend;
    [FieldOffset(0x0204)] public FVector2D NamiStatusAOfsPos;
    [FieldOffset(0x020C)] public FVector2D NamiStatusAScale;
    [FieldOffset(0x0214)] public FColor NamiStatusAColor;
    [FieldOffset(0x0218)] public bool NamiStatusAAddBlend;
    [FieldOffset(0x021C)] public FVector2D NamiStatusBOfsPos;
    [FieldOffset(0x0224)] public FVector2D NamiStatusBScale;
    [FieldOffset(0x022C)] public FColor NamiStatusBColor;
    [FieldOffset(0x0230)] public bool NamiStatusBAddBlend;
    [FieldOffset(0x0234)] public FVector2D NamiQuestAOfsPos;
    [FieldOffset(0x023C)] public FVector2D NamiQuestAScale;
    [FieldOffset(0x0244)] public FColor NamiQuestAColor;
    [FieldOffset(0x0248)] public bool NamiQuestAAddBlend;
    [FieldOffset(0x024C)] public FVector2D NamiQuestBOfsPos;
    [FieldOffset(0x0254)] public FVector2D NamiQuestBScale;
    [FieldOffset(0x025C)] public FColor NamiQuestBColor;
    [FieldOffset(0x0260)] public bool NamiQuestBAddBlend;
    [FieldOffset(0x0264)] public FVector2D NamiCommuAOfsPos;
    [FieldOffset(0x026C)] public FVector2D NamiCommuAScale;
    [FieldOffset(0x0274)] public FColor NamiCommuAColor;
    [FieldOffset(0x0278)] public bool NamiCommuAAddBlend;
    [FieldOffset(0x027C)] public FVector2D NamiCommuBOfsPos;
    [FieldOffset(0x0284)] public FVector2D NamiCommuBScale;
    [FieldOffset(0x028C)] public FColor NamiCommuBColor;
    [FieldOffset(0x0290)] public bool NamiCommuBAddBlend;
    [FieldOffset(0x0294)] public FVector2D NamiCalendarAOfsPos;
    [FieldOffset(0x029C)] public FVector2D NamiCalendarAScale;
    [FieldOffset(0x02A4)] public FColor NamiCalendarAColor;
    [FieldOffset(0x02A8)] public bool NamiCalendarAAddBlend;
    [FieldOffset(0x02AC)] public FVector2D NamiCalendarBOfsPos;
    [FieldOffset(0x02B4)] public FVector2D NamiCalendarBScale;
    [FieldOffset(0x02BC)] public FColor NamiCalendarBColor;
    [FieldOffset(0x02C0)] public bool NamiCalendarBAddBlend;
    [FieldOffset(0x02C4)] public FVector2D NamiSystemAOfsPos;
    [FieldOffset(0x02CC)] public FVector2D NamiSystemAScale;
    [FieldOffset(0x02D4)] public FColor NamiSystemAColor;
    [FieldOffset(0x02D8)] public bool NamiSystemAAddBlend;
    [FieldOffset(0x02DC)] public FVector2D NamiSystemBOfsPos;
    [FieldOffset(0x02E4)] public FVector2D NamiSystemBScale;
    [FieldOffset(0x02EC)] public FColor NamiSystemBColor;
    [FieldOffset(0x02F0)] public bool NamiSystemBAddBlend;
    [FieldOffset(0x02F4)] public FVector2D NamiTutorialAOfsPos;
    [FieldOffset(0x02FC)] public FVector2D NamiTutorialAScale;
    [FieldOffset(0x0304)] public FColor NamiTutorialAColor;
    [FieldOffset(0x0308)] public bool NamiTutorialAAddBlend;
    [FieldOffset(0x030C)] public FVector2D NamiTutorialBOfsPos;
    [FieldOffset(0x0314)] public FVector2D NamiTutorialBScale;
    [FieldOffset(0x031C)] public FColor NamiTutorialBColor;
    [FieldOffset(0x0320)] public bool NamiTutorialBAddBlend;
    [FieldOffset(0x0324)] public FVector2D NamiConfigAOfsPos;
    [FieldOffset(0x032C)] public FVector2D NamiConfigAScale;
    [FieldOffset(0x0334)] public FColor NamiConfigAColor;
    [FieldOffset(0x0338)] public bool NamiConfigAAddBlend;
    [FieldOffset(0x033C)] public FVector2D NamiConfigBOfsPos;
    [FieldOffset(0x0344)] public FVector2D NamiConfigBScale;
    [FieldOffset(0x034C)] public FColor NamiConfigBColor;
    [FieldOffset(0x0350)] public bool NamiConfigBAddBlend;
    [FieldOffset(0x0354)] public FLinearColor LightVecOfsTop;
    [FieldOffset(0x0364)] public FLinearColor LightVecOfsSkill;
    [FieldOffset(0x0374)] public FLinearColor LightVecOfsItem;
    [FieldOffset(0x0384)] public FLinearColor LightVecOfsEquip;
    [FieldOffset(0x0394)] public FLinearColor LightVecOfsPersona;
    [FieldOffset(0x03A4)] public FLinearColor LightVecOfsStatus;
    [FieldOffset(0x03B4)] public FLinearColor LightVecOfsQuest;
    [FieldOffset(0x03C4)] public FLinearColor LightVecOfsCommu;
    [FieldOffset(0x03D4)] public FLinearColor LightVecOfsCalender;
    [FieldOffset(0x03E4)] public FLinearColor LightVecOfsSystem;
    [FieldOffset(0x03F4)] public uint Edit_Key_Lock_Frame;
    [FieldOffset(0x03F8)] public float Edit_GuideLine_X;
    [FieldOffset(0x03FC)] public uint Edit_StatusKeyLockFrame;
    [FieldOffset(0x0400)] public FLinearColor Edit_Root_FillColor;
    [FieldOffset(0x0410)] public float Edit_Root_Near;
    [FieldOffset(0x0414)] public float Edit_Root_Far;
    [FieldOffset(0x0418)] public FLinearColor Edit_Skill_FillColor;
    [FieldOffset(0x0428)] public float Edit_Skill_Near;
    [FieldOffset(0x042C)] public float Edit_Skill_Far;
    [FieldOffset(0x0430)] public FLinearColor Edit_Item_FillColor;
    [FieldOffset(0x0440)] public float Edit_Item_Near;
    [FieldOffset(0x0444)] public float Edit_Item_Far;
    [FieldOffset(0x0448)] public FLinearColor Edit_Equip_FillColor;
    [FieldOffset(0x0458)] public float Edit_Equip_Near;
    [FieldOffset(0x045C)] public float Edit_Equip_Far;
    [FieldOffset(0x0460)] public FLinearColor Edit_Status_FillColor;
    [FieldOffset(0x0470)] public float Edit_Status_Near;
    [FieldOffset(0x0474)] public float Edit_Status_Far;
    [FieldOffset(0x0478)] public FLinearColor Edit_Quest_FillColor;
    [FieldOffset(0x0488)] public float Edit_Quest_Near;
    [FieldOffset(0x048C)] public float Edit_Quest_Far;
    [FieldOffset(0x0490)] public FLinearColor Edit_Commu_FillColor;
    [FieldOffset(0x04A0)] public float Edit_Commu_Near;
    [FieldOffset(0x04A4)] public float Edit_Commu_Far;
    [FieldOffset(0x04A8)] public FLinearColor Edit_System_FillColor;
    [FieldOffset(0x04B8)] public float Edit_System_Near;
    [FieldOffset(0x04BC)] public float Edit_System_Far;
    [FieldOffset(0x04C0)] public FLinearColor Edit_Config_FillColor;
    [FieldOffset(0x04D0)] public float Edit_Config_Near;
    [FieldOffset(0x04D4)] public float Edit_Config_Far;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct FCampParamTableSystemRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float SystemTopInMenuDist;
    [FieldOffset(0x000C)] public uint SystemTopInTopMenuFrame1;
    [FieldOffset(0x0010)] public uint SystemTopInTopMenuFrame2;
    [FieldOffset(0x0014)] public uint SystemTopInTopMenuRotFrame;
    [FieldOffset(0x0018)] public EOneAnimType SystemTopInAoItaAnimType;
    [FieldOffset(0x001C)] public uint SystemTopInAoItaFrame;
    [FieldOffset(0x0020)] public uint SystemTopInAoItaWait;
    [FieldOffset(0x0024)] public EOneAnimType SystemTopInTitleAnimType;
    [FieldOffset(0x0028)] public uint SystemTopInTitleFrame;
    [FieldOffset(0x002C)] public uint SystemTopInTitleWait;
    [FieldOffset(0x0030)] public FVector2D SystemTopTutorialOnPos;
    [FieldOffset(0x0038)] public float SystemTopTutorialOnRot;
    [FieldOffset(0x003C)] public FVector2D SystemTopConfigOnPos;
    [FieldOffset(0x0044)] public float SystemTopConfigOnRot;
    [FieldOffset(0x0048)] public FVector2D SystemTopDictionaryOnPos;
    [FieldOffset(0x0050)] public float SystemTopDictionaryOnRot;
    [FieldOffset(0x0054)] public FVector2D SystemTopDataloadOnPos;
    [FieldOffset(0x005C)] public float SystemTopDataloadOnRot;
    [FieldOffset(0x0060)] public FVector2D SystemTopDatasaveOnPos;
    [FieldOffset(0x0068)] public float SystemTopDatasaveOnRot;
    [FieldOffset(0x006C)] public FVector2D SystemTopRollbackOnPos;
    [FieldOffset(0x0074)] public float SystemTopRollbackOnRot;
    [FieldOffset(0x0078)] public FVector2D SystemTopTitleOnPos;
    [FieldOffset(0x0080)] public float SystemTopTitleOnRot;
    [FieldOffset(0x0084)] public FVector2D SystemTopTutorialOffPos;
    [FieldOffset(0x008C)] public float SystemTopTutorialOffRot;
    [FieldOffset(0x0090)] public FVector2D SystemTopConfigOffPos;
    [FieldOffset(0x0098)] public float SystemTopConfigOffRot;
    [FieldOffset(0x009C)] public FVector2D SystemTopDictionaryOffPos;
    [FieldOffset(0x00A4)] public float SystemTopDictionaryOffRot;
    [FieldOffset(0x00A8)] public FVector2D SystemTopDataloadOffPos;
    [FieldOffset(0x00B0)] public float SystemTopDataloadOffRot;
    [FieldOffset(0x00B4)] public FVector2D SystemTopDatasaveOffPos;
    [FieldOffset(0x00BC)] public float SystemTopDatasaveOffRot;
    [FieldOffset(0x00C0)] public FVector2D SystemTopRollbackOffPos;
    [FieldOffset(0x00C8)] public float SystemTopRollbackOffRot;
    [FieldOffset(0x00CC)] public FVector2D SystemTopTitleOffPos;
    [FieldOffset(0x00D4)] public float SystemTopTitleOffRot;
    [FieldOffset(0x00D8)] public FVector2D Edit_CursorOn_Tutorial_Text_Scale;
    [FieldOffset(0x00E0)] public FVector2D Edit_CursorOn_Tutorial_Cursor_Scale;
    [FieldOffset(0x00E8)] public FVector2D Edit_CursorOn_Config_Text_Scale;
    [FieldOffset(0x00F0)] public FVector2D Edit_CursorOn_Config_Cursor_Scale;
    [FieldOffset(0x00F8)] public FVector2D Edit_CursorOn_Dictionary_Text_Scale;
    [FieldOffset(0x0100)] public FVector2D Edit_CursorOn_Dictionary_Cursor_Scale;
    [FieldOffset(0x0108)] public FVector2D Edit_CursorOn_DataLoad_Text_Scale;
    [FieldOffset(0x0110)] public FVector2D Edit_CursorOn_DataLoad_Cursor_Scale;
    [FieldOffset(0x0118)] public FVector2D Edit_CursorOn_DataSave_Text_Scale;
    [FieldOffset(0x0120)] public FVector2D Edit_CursorOn_DataSave_Cursor_Scale;
    [FieldOffset(0x0128)] public FVector2D Edit_CursorOn_RollBack_Text_Scale;
    [FieldOffset(0x0130)] public FVector2D Edit_CursorOn_RollBack_Cursor_Scale;
    [FieldOffset(0x0138)] public FVector2D Edit_CursorOn_ReturnToTitle_Text_Scale;
    [FieldOffset(0x0140)] public FVector2D Edit_CursorOn_ReturnToTitle_Cursor_Scale;
    [FieldOffset(0x0148)] public float Edit_CursorOn_Tutorial_Cursor_Angle;
    [FieldOffset(0x014C)] public float Edit_CursorOn_Config_Cursor_Angle;
    [FieldOffset(0x0150)] public float Edit_CursorOn_Dictionary_Cursor_Angle;
    [FieldOffset(0x0154)] public float Edit_CursorOn_DataLoad_Cursor_Angle;
    [FieldOffset(0x0158)] public float Edit_CursorOn_DataSave_Cursor_Angle;
    [FieldOffset(0x015C)] public float Edit_CursorOn_RollBack_Cursor_Angle;
    [FieldOffset(0x0160)] public float Edit_CursorOn_ReturnToTitle_Cursor_Angle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FCampParamTableCommuRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EOneAnimType CommListInSilhouetteAnimType;
    [FieldOffset(0x000C)] public uint CommListInSilhouetteFrame;
    [FieldOffset(0x0010)] public uint CommListInSilhouetteWait;
    [FieldOffset(0x0014)] public EOneAnimType CommListInSiroItaAnimType;
    [FieldOffset(0x0018)] public uint CommListInSiroItaFrame;
    [FieldOffset(0x001C)] public uint CommListInSiroItaWait;
    [FieldOffset(0x0020)] public uint CommListOutSiroItaFrame;
    [FieldOffset(0x0024)] public EOneAnimType CommListInListAnimType;
    [FieldOffset(0x0028)] public uint CommListInListFrame;
    [FieldOffset(0x002C)] public uint CommListInListWait;
    [FieldOffset(0x0030)] public uint CommListOutListFrame;
    [FieldOffset(0x0034)] public EOneAnimType CommDetlInDetailAnimType;
    [FieldOffset(0x0038)] public uint CommDetlInDetailFrame;
    [FieldOffset(0x003C)] public uint CommDetlInDetailWait;
    [FieldOffset(0x0040)] public uint CommDetlOutDetailFrame;
    [FieldOffset(0x0044)] public EOneAnimType CommDetlInDescriAnimType;
    [FieldOffset(0x0048)] public uint CommDetlInDescriFrame;
    [FieldOffset(0x004C)] public uint CommDetlInDescriWait;
    [FieldOffset(0x0050)] public EOneAnimType CommDetlInMemberAnimType;
    [FieldOffset(0x0054)] public uint CommDetlInMemberFrame;
    [FieldOffset(0x0058)] public uint CommDetlInMemberWait;
    [FieldOffset(0x005C)] public EOneAnimType CommDetlInBustupAnimType;
    [FieldOffset(0x0060)] public uint CommDetlInBustupFrame;
    [FieldOffset(0x0064)] public uint CommDetlInBustupWait;
    [FieldOffset(0x0068)] public uint CommDetlBustupChangeFrame;
    [FieldOffset(0x006C)] public EOneAnimType CommuCardAnimType;
    [FieldOffset(0x0070)] public uint CommuCardFrameMin;
    [FieldOffset(0x0074)] public uint CommuCardFrameMax;
    [FieldOffset(0x0078)] public uint CommuCardWaitMin;
    [FieldOffset(0x007C)] public uint CommuCardWaitMax;
    [FieldOffset(0x0080)] public float CommuCardScaleMin;
    [FieldOffset(0x0084)] public float CommuCardScaleMax;
    [FieldOffset(0x0088)] public float CommuCardXAccMin;
    [FieldOffset(0x008C)] public float CommuCardXAccMax;
    [FieldOffset(0x0090)] public float CommuCardRotAxis1Min;
    [FieldOffset(0x0094)] public float CommuCardRotAxis1Max;
    [FieldOffset(0x0098)] public float CommuCardRotAxis2Min;
    [FieldOffset(0x009C)] public float CommuCardRotAxis2Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct FCampParamTableRankUpRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FColor HumanSankakuRed;
    [FieldOffset(0x000C)] public FColor HumanSankakuGreen;
    [FieldOffset(0x0010)] public FColor HumanBokasiRed;
    [FieldOffset(0x0014)] public FColor HumanBokasiGreen;
    [FieldOffset(0x0018)] public FColor HumanPointUpLightblue;
    [FieldOffset(0x001C)] public FColor HumanBrainBlue;
    [FieldOffset(0x0020)] public FColor HumanCharmBlue;
    [FieldOffset(0x0024)] public FColor HumanCourageBlue;
    [FieldOffset(0x0028)] public FColor CampHumanBrainBlue;
    [FieldOffset(0x002C)] public FColor CampHumanCharmBlue;
    [FieldOffset(0x0030)] public FColor CampHumanCourageBlue;
    [FieldOffset(0x0034)] public FColor ParameterNameYellow;
    [FieldOffset(0x0038)] public FColor CircleYellow;
    [FieldOffset(0x003C)] public FColor HelpTextYellow;
    [FieldOffset(0x0040)] public FVector2D PointUpTextStartPos;
    [FieldOffset(0x0048)] public FVector2D PointUpTextEndPos;
    [FieldOffset(0x0050)] public FVector2D RankUpTextStartPos;
    [FieldOffset(0x0058)] public FVector2D RankUpTextEndPos;
    [FieldOffset(0x0060)] public uint HumanInBgSankakuFrame;
    [FieldOffset(0x0064)] public uint HumanInSankakuFrame;
    [FieldOffset(0x0068)] public uint HumanInAllBGFrame;
    [FieldOffset(0x006C)] public uint HumanInHamonFrame;
    [FieldOffset(0x0070)] public uint HumanInRankRotFrame;
    [FieldOffset(0x0074)] public uint HumanInRankSlideFrame;
    [FieldOffset(0x0078)] public uint HumanInHelpSlideFrame;
    [FieldOffset(0x007C)] public uint HumanInTitleSlideFrame;
    [FieldOffset(0x0080)] public uint HumanInBgSankakuFrameWait;
    [FieldOffset(0x0084)] public uint HumanInSankakuFrameWaitWhite;
    [FieldOffset(0x0088)] public uint HumanInSankakuFrameWaitGreen;
    [FieldOffset(0x008C)] public uint HumanInSankakuFrameWaitRed;
    [FieldOffset(0x0090)] public uint HumanInAllBGFrameWait;
    [FieldOffset(0x0094)] public uint HumanInHamonFrameWait;
    [FieldOffset(0x0098)] public uint HumanInHamonFrameWaitSecond;
    [FieldOffset(0x009C)] public uint HumanInHamonFrameWaitThird;
    [FieldOffset(0x00A0)] public uint HumanInRankRotFrameWait;
    [FieldOffset(0x00A4)] public uint HumanInRankSlideFrameWait;
    [FieldOffset(0x00A8)] public uint HumanInHelpSlideFrameWait;
    [FieldOffset(0x00AC)] public uint HumanInTitleSlideFrameWait;
    [FieldOffset(0x00B0)] public EOneAnimType HumanInBgSankakuType;
    [FieldOffset(0x00B1)] public EOneAnimType HumanInSankakuType;
    [FieldOffset(0x00B2)] public EOneAnimType HumanInAllBGType;
    [FieldOffset(0x00B3)] public EOneAnimType HumanInHamonType;
    [FieldOffset(0x00B4)] public EOneAnimType HumanInRankRotType;
    [FieldOffset(0x00B5)] public EOneAnimType HumanInRankSlideType;
    [FieldOffset(0x00B6)] public EOneAnimType HumanInHelpSlideType;
    [FieldOffset(0x00B7)] public EOneAnimType HumanInTitleSlideType;
    [FieldOffset(0x00B8)] public uint HumanPointUpTextSlideOneFrame;
    [FieldOffset(0x00BC)] public uint HumanPointUpTextSlideTwoFrame;
    [FieldOffset(0x00C0)] public uint HumanPointUpTextSlideThreeFrame;
    [FieldOffset(0x00C4)] public uint HumanPointUpTextFadeOneFrame;
    [FieldOffset(0x00C8)] public uint HumanPointUpTextFadeTwoFrame;
    [FieldOffset(0x00CC)] public uint HumanPointUpTextFadeThreeFrame;
    [FieldOffset(0x00D0)] public uint HumanPointUpHamonScaleFrame;
    [FieldOffset(0x00D4)] public uint HumanPointUpHamonFadeFrame;
    [FieldOffset(0x00D8)] public uint HumanPointUpBlueCircleFadeOneFrame;
    [FieldOffset(0x00DC)] public uint HumanPointUpBlueCircleFadeTwoFrame;
    [FieldOffset(0x00E0)] public uint HumanPointUpBlueCircleFadeThreeFrame;
    [FieldOffset(0x00E4)] public uint HumanPointUpBlueCircleScaleOneFrame;
    [FieldOffset(0x00E8)] public uint HumanPointUpBlueCircleScaleTwoFrame;
    [FieldOffset(0x00EC)] public uint HumanPointUpBlueCircleScaleThreeFrame;
    [FieldOffset(0x00F0)] public uint HumanPointUpTextSlideOneFrameWait;
    [FieldOffset(0x00F4)] public uint HumanPointUpTextSlideTwoFrameWait;
    [FieldOffset(0x00F8)] public uint HumanPointUpTextSlideThreeFrameWait;
    [FieldOffset(0x00FC)] public uint HumanPointUpTextFadeOneFrameWait;
    [FieldOffset(0x0100)] public uint HumanPointUpTextFadeTwoFrameWait;
    [FieldOffset(0x0104)] public uint HumanPointUpTextFadeThreeFrameWait;
    [FieldOffset(0x0108)] public uint HumanPointUpHamonScaleFrameWait;
    [FieldOffset(0x010C)] public uint HumanPointUpHamonFadeFrameWait;
    [FieldOffset(0x0110)] public uint HumanPointUpBlueCircleFadeOneFrameWait;
    [FieldOffset(0x0114)] public uint HumanPointUpBlueCircleFadeTwoFrameWait;
    [FieldOffset(0x0118)] public uint HumanPointUpBlueCircleFadeThreeFrameWait;
    [FieldOffset(0x011C)] public uint HumanPointUpBlueCircleScaleOneFrameWait;
    [FieldOffset(0x0120)] public uint HumanPointUpBlueCircleScaleTwoFrameWait;
    [FieldOffset(0x0124)] public uint HumanPointUpBlueCircleScaleThreeFrameWait;
    [FieldOffset(0x0128)] public EOneAnimType HumanPointUpTextSlideOneType;
    [FieldOffset(0x0129)] public EOneAnimType HumanPointUpTextSlideTwoType;
    [FieldOffset(0x012A)] public EOneAnimType HumanPointUpTextSlideThreeType;
    [FieldOffset(0x012B)] public EOneAnimType HumanPointUpTextFadeOneType;
    [FieldOffset(0x012C)] public EOneAnimType HumanPointUpTextFadeTwoType;
    [FieldOffset(0x012D)] public EOneAnimType HumanPointUpTextFadeThreeType;
    [FieldOffset(0x012E)] public EOneAnimType HumanPointUpHamonScaleType;
    [FieldOffset(0x012F)] public EOneAnimType HumanPointUpHamonFadeType;
    [FieldOffset(0x0130)] public EOneAnimType HumanPointUpBlueCircleFadeScaleOneType;
    [FieldOffset(0x0131)] public EOneAnimType HumanPointUpBlueCircleFadeScaleTwoType;
    [FieldOffset(0x0132)] public EOneAnimType HumanPointUpBlueCircleFadeScaleThreeType;
    [FieldOffset(0x0134)] public uint HumanRankUpTextSlideOneFrame;
    [FieldOffset(0x0138)] public uint HumanRankUpTextSlideTwoFrame;
    [FieldOffset(0x013C)] public uint HumanRankUpTextSlideThreeFrame;
    [FieldOffset(0x0140)] public uint HumanRankUpTextFadeOneFrame;
    [FieldOffset(0x0144)] public uint HumanRankUpTextFadeTwoFrame;
    [FieldOffset(0x0148)] public uint HumanRankUpTextFadeThreeFrame;
    [FieldOffset(0x014C)] public uint HumanRankUpHamonScaleFrame;
    [FieldOffset(0x0150)] public uint HumanRankUpHamonFadeFrame;
    [FieldOffset(0x0154)] public uint HumanRankUpWhiteCircleColorOneFrame;
    [FieldOffset(0x0158)] public uint HumanRankUpWhiteCircleColorTwoFrame;
    [FieldOffset(0x015C)] public uint HumanRankUpWhiteCircleColorThreeFrame;
    [FieldOffset(0x0160)] public uint HumanRankUpWhiteCircleScaleOneFrame;
    [FieldOffset(0x0164)] public uint HumanRankUpWhiteCircleScaleTwoFrame;
    [FieldOffset(0x0168)] public uint HumanRankUpWhiteCircleScaleThreeFrame;
    [FieldOffset(0x016C)] public uint HumanRankUpTextSlideOneFrameWait;
    [FieldOffset(0x0170)] public uint HumanRankUpTextSlideTwoFrameWait;
    [FieldOffset(0x0174)] public uint HumanRankUpTextSlideThreeFrameWait;
    [FieldOffset(0x0178)] public uint HumanRankUpTextFadeOneFrameWait;
    [FieldOffset(0x017C)] public uint HumanRankUpTextFadeTwoFrameWait;
    [FieldOffset(0x0180)] public uint HumanRankUpTextFadeThreeFrameWait;
    [FieldOffset(0x0184)] public uint HumanRankUpHamonScaleFrameWait;
    [FieldOffset(0x0188)] public uint HumanRankUpHamonFadeFrameWait;
    [FieldOffset(0x018C)] public uint HumanRankUpWhiteCircleColorOneFrameWait;
    [FieldOffset(0x0190)] public uint HumanRankUpWhiteCircleColorTwoFrameWait;
    [FieldOffset(0x0194)] public uint HumanRankUpWhiteCircleColorThreeFrameWait;
    [FieldOffset(0x0198)] public uint HumanRankUpWhiteCircleScaleOneFrameWait;
    [FieldOffset(0x019C)] public uint HumanRankUpWhiteCircleScaleTwoFrameWait;
    [FieldOffset(0x01A0)] public uint HumanRankUpWhiteCircleScaleThreeFrameWait;
    [FieldOffset(0x01A4)] public EOneAnimType HumanRankUpTextSlideOneType;
    [FieldOffset(0x01A5)] public EOneAnimType HumanRankUpTextSlideTwoType;
    [FieldOffset(0x01A6)] public EOneAnimType HumanRankUpTextSlideThreeType;
    [FieldOffset(0x01A7)] public EOneAnimType HumanRankUpTextFadeOneType;
    [FieldOffset(0x01A8)] public EOneAnimType HumanRankUpTextFadeTwoType;
    [FieldOffset(0x01A9)] public EOneAnimType HumanRankUpTextFadeThreeType;
    [FieldOffset(0x01AA)] public EOneAnimType HumanRankUpHamonScaleType;
    [FieldOffset(0x01AB)] public EOneAnimType HumanRankUpHamonFadeType;
    [FieldOffset(0x01AC)] public EOneAnimType HumanRankUpWhiteCircleColorOneType;
    [FieldOffset(0x01AD)] public EOneAnimType HumanRankUpWhiteCircleColorTwoType;
    [FieldOffset(0x01AE)] public EOneAnimType HumanRankUpWhiteCircleColorThreeType;
    [FieldOffset(0x01AF)] public EOneAnimType HumanRankUpWhiteCircleScaleOneType;
    [FieldOffset(0x01B0)] public EOneAnimType HumanRankUpWhiteCircleScaleTwoType;
    [FieldOffset(0x01B1)] public EOneAnimType HumanRankUpWhiteCircleScaleThreeType;
    [FieldOffset(0x01B4)] public uint HumanRankUpAllCircleScaleFrame;
    [FieldOffset(0x01B8)] public uint HumanRankUpCurrentNumberFadeFrame;
    [FieldOffset(0x01BC)] public uint HumanRankUpNextNumberFadeSlideFrame;
    [FieldOffset(0x01C0)] public uint HumanRankUpCurrentHelpTextFadeFrame;
    [FieldOffset(0x01C4)] public uint HumanRankUpNextHelpTextFadeSlideFrame;
    [FieldOffset(0x01C8)] public uint HumanRankUpMaskCircleFrame;
    [FieldOffset(0x01CC)] public uint HumanRankUpAllCircleScaleFrameWait;
    [FieldOffset(0x01D0)] public uint HumanRankUpCurrentNumberFadeFrameWait;
    [FieldOffset(0x01D4)] public uint HumanRankUpNextNumberFadeSlideFrameWait;
    [FieldOffset(0x01D8)] public uint HumanRankUpCurrentHelpTextFadeFrameWait;
    [FieldOffset(0x01DC)] public uint HumanRankUpNextHelpTextFadeSlideFrameWait;
    [FieldOffset(0x01E0)] public uint HumanRankUpMaskCircleFrameWait;
    [FieldOffset(0x01E4)] public EOneAnimType HumanRankUpAllCircleScaleType;
    [FieldOffset(0x01E5)] public EOneAnimType HumanRankUpCurrentNumberFadeType;
    [FieldOffset(0x01E6)] public EOneAnimType HumanRankUpNextNumberFadeSlideType;
    [FieldOffset(0x01E7)] public EOneAnimType HumanRankUpCurrentHelpTextFadeType;
    [FieldOffset(0x01E8)] public EOneAnimType HumanRankUpNextHelpTextFadeSlideType;
    [FieldOffset(0x01E9)] public EOneAnimType HumanRankUpMaskCircleType;
    [FieldOffset(0x01EC)] public uint HumanRankUpNextNumberFadeFrame;
    [FieldOffset(0x01F0)] public uint HumanRankUpNextHelpTextFadeFrame;
    [FieldOffset(0x01F4)] public uint HumanRankUpNextNumberFadeFrameWait;
    [FieldOffset(0x01F8)] public uint HumanRankUpNextHelpTextFadeFrameWait;
    [FieldOffset(0x01FC)] public EOneAnimType HumanRankUpNextNumberFadeType;
    [FieldOffset(0x01FD)] public EOneAnimType HumanRankUpNextHelpTextFadeType;
    [FieldOffset(0x0200)] public uint KeyHelpFadeInFrame;
    [FieldOffset(0x0204)] public uint HumanKeyHelpInFrameWait;
    [FieldOffset(0x0208)] public uint KeyHelpFadeOutFrame;
    [FieldOffset(0x020C)] public uint HumanKeyHelpOutFrameWait;
    [FieldOffset(0x0210)] public uint KeyHelpMaskSlideOneFrame;
    [FieldOffset(0x0214)] public uint KeyHelpMaskSlideTwoFrame;
    [FieldOffset(0x0218)] public uint KeyHelpMaskSlideThreeFrame;
    [FieldOffset(0x021C)] public uint KeyHelpMaskSlideOneWaitFrame;
    [FieldOffset(0x0220)] public uint KeyHelpMaskSlideTwoWaitFrame;
    [FieldOffset(0x0224)] public uint KeyHelpMaskSlideThreeWaitFrame;
    [FieldOffset(0x0228)] public EOneAnimType KeyHelpMaskSlideOneType;
    [FieldOffset(0x0229)] public EOneAnimType KeyHelpMaskSlideTwoType;
    [FieldOffset(0x022A)] public EOneAnimType KeyHelpMaskSlideThreeType;
    [FieldOffset(0x022B)] public EOneAnimType KeyHelpMaskSlideOneWaitType;
    [FieldOffset(0x022C)] public EOneAnimType KeyHelpMaskSlideTwoWaitType;
    [FieldOffset(0x022D)] public EOneAnimType KeyHelpMaskSlideThreeWaitType;
    [FieldOffset(0x022E)] public EOneAnimType KeyHelpOutScaleType;
    [FieldOffset(0x0230)] public uint KeyHelpOutScaleFrame;
    [FieldOffset(0x0234)] public float KeyHelpFadeOutScaleSize;
    [FieldOffset(0x0238)] public uint MaxHamonShiftWaitFlame;
    [FieldOffset(0x023C)] public uint HumanMaxHamonScaleInFlame;
    [FieldOffset(0x0240)] public uint HumanMaxHamonScaleInFlameWait;
    [FieldOffset(0x0244)] public uint HumanMaxHamonFadeInAllFlameWait;
    [FieldOffset(0x0248)] public uint HumanMaxHamonFadeInFlame;
    [FieldOffset(0x024C)] public uint HumanMaxHamonFadeInFlameWait;
    [FieldOffset(0x0250)] public uint HumanMaxHamonFadeOutFlame;
    [FieldOffset(0x0254)] public uint HumanMaxHamonFadeOutFlameWait;
    [FieldOffset(0x0258)] public uint HumanMaxHamonFadeOutLastFlame;
    [FieldOffset(0x025C)] public uint HumanMaxHamonFadeOutLastFlameWait;
    [FieldOffset(0x0260)] public EOneAnimType HumanMaxHamonScaleOutType;
    [FieldOffset(0x0264)] public uint MaxTriangleBlurFadeInFlame;
    [FieldOffset(0x0268)] public uint MaxTriangleBlurFadeInFlameWait;
    [FieldOffset(0x026C)] public uint MaxTriangleBlurFadeOutFlame;
    [FieldOffset(0x0270)] public uint HumanMaxCircleFadeInFlame;
    [FieldOffset(0x0274)] public uint HumanMaxCircleFadeInFlameWait;
    [FieldOffset(0x0278)] public uint HumanMaxCircleFadeOutFlame;
    [FieldOffset(0x027C)] public uint MaxCircleFinishFlameWait;
    [FieldOffset(0x0280)] public EOneAnimType HumanMaxHamonScaleType;
    [FieldOffset(0x0281)] public EOneAnimType HumanMaxHamonFadeInType;
    [FieldOffset(0x0282)] public EOneAnimType HumanMaxHamonFadeOutType;
    [FieldOffset(0x0283)] public EOneAnimType MaxTriangleBlurFadeInType;
    [FieldOffset(0x0284)] public EOneAnimType MaxTriangleBlurFadeOutType;
    [FieldOffset(0x0285)] public EOneAnimType HumanMaxCircleFadeInType;
    [FieldOffset(0x0286)] public EOneAnimType HumanMaxCircleFadeTwoType;
    [FieldOffset(0x0288)] public uint HumanCircleFadeLoop_Wait_0;
    [FieldOffset(0x028C)] public uint HumanCircleFadeLoop_Frame_0;
    [FieldOffset(0x0290)] public uint HumanCircleFadeLoop_Wait_1;
    [FieldOffset(0x0294)] public uint HumanCircleFadeLoop_Frame_1;
    [FieldOffset(0x0298)] public uint HumanCircleColorLoop_Wait_0;
    [FieldOffset(0x029C)] public uint HumanCircleColorLoop_Frame_0;
    [FieldOffset(0x02A0)] public uint HumanCircleColorLoop_Wait_1;
    [FieldOffset(0x02A4)] public uint HumanCircleColorLoop_Frame_1;
    [FieldOffset(0x02A8)] public uint HumanCircleScaleUpLoop_Wait;
    [FieldOffset(0x02AC)] public uint HumanCircleScaleUpLoop_Frame;
    [FieldOffset(0x02B0)] public EOneAnimType HumanCircleFadeLoopType;
    [FieldOffset(0x02B1)] public EOneAnimType HumanCircleScaleLoopType;
    [FieldOffset(0x02B2)] public EOneAnimType HumanCircleColorLoopType;
    [FieldOffset(0x02B4)] public uint HumanPlusHamonFlame;
    [FieldOffset(0x02B8)] public uint HumanCircleLoopStartWait;
    [FieldOffset(0x02BC)] public uint HumanOutHelpSlideFrame;
    [FieldOffset(0x02C0)] public uint HumanOutTitleSlideFrame;
    [FieldOffset(0x02C4)] public uint HumanOutHamonFrame;
    [FieldOffset(0x02C8)] public uint HumanOutSankakuFrame;
    [FieldOffset(0x02CC)] public uint HumanOutRankRotFrame;
    [FieldOffset(0x02D0)] public uint HumanOutBgSankakuFrame;
    [FieldOffset(0x02D4)] public uint HumanOutAllBgFrame;
    [FieldOffset(0x02D8)] public uint HumanOutHelpSlideFrameWait;
    [FieldOffset(0x02DC)] public uint HumanOutTitleSlideFrameWait;
    [FieldOffset(0x02E0)] public uint HumanOutHamonFrameWait;
    [FieldOffset(0x02E4)] public uint HumanOutSankakuFrameWait;
    [FieldOffset(0x02E8)] public uint HumanOutRankRotFrameWait;
    [FieldOffset(0x02EC)] public uint HumanOutBgSankakuFrameWait;
    [FieldOffset(0x02F0)] public uint HumanOutAllBgFrameWait;
    [FieldOffset(0x02F4)] public EOneAnimType HumanOutHelpSlideType;
    [FieldOffset(0x02F5)] public EOneAnimType HumanOutTitleSlideType;
    [FieldOffset(0x02F6)] public EOneAnimType HumanOutHamonType;
    [FieldOffset(0x02F7)] public EOneAnimType HumanOutSankakuType;
    [FieldOffset(0x02F8)] public EOneAnimType HumanOutRankRotType;
    [FieldOffset(0x02F9)] public EOneAnimType HumanOutBgSankakuType;
    [FieldOffset(0x02FA)] public EOneAnimType HumanOutAllBgType;
    [FieldOffset(0x02FB)] public EOneAnimType HumanKeyHelpOutType;
    [FieldOffset(0x02FC)] public uint HumanHamonLoopScaleDownFrame;
    [FieldOffset(0x0300)] public uint HumanHamonLoopScaleUpFrameWait;
    [FieldOffset(0x0304)] public EOneAnimType HumanHamonLoopScaleDownType;
    [FieldOffset(0x0308)] public uint HumanHamonLoopWaitFrame;
    [FieldOffset(0x030C)] public EOneAnimType HumanHamonLoopWaitType;
    [FieldOffset(0x0310)] public uint HumanHamonLoopScaleUpFrame;
    [FieldOffset(0x0314)] public EOneAnimType HumanHamonLoopScaleUpType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x310)] 
public unsafe struct FCampParamTableStatusRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint ListTabChangeFrame;
    [FieldOffset(0x000C)] public uint StatListPartyRightSideFadeOutFrame;
    [FieldOffset(0x0010)] public uint StatListPartyRightSideFadeInFrame;
    [FieldOffset(0x0014)] public uint StatListKoshoLogoRotFrame;
    [FieldOffset(0x0018)] public uint StatListGlassCharaFrame;
    [FieldOffset(0x001C)] public uint StatListGlassCharaWait;
    [FieldOffset(0x0020)] public uint StatListBgNoiseRandFrameMin;
    [FieldOffset(0x0024)] public uint StatListBgNoiseRandFrameMax;
    [FieldOffset(0x0028)] public float StatListInDist;
    [FieldOffset(0x002C)] public EOneAnimType StatListInSilhouetteAnimType;
    [FieldOffset(0x0030)] public uint StatListInSilhouetteFrame;
    [FieldOffset(0x0034)] public uint StatListInSilhouetteWait;
    [FieldOffset(0x0038)] public EOneAnimType StatListInKoshoAnimType;
    [FieldOffset(0x003C)] public uint StatListInKoshoFrame;
    [FieldOffset(0x0040)] public uint StatListInKoshoWait;
    [FieldOffset(0x0044)] public EOneAnimType StatListInTabAnimType;
    [FieldOffset(0x0048)] public uint StatListInTabFrame;
    [FieldOffset(0x004C)] public uint StatListInTabWait;
    [FieldOffset(0x0050)] public EOneAnimType StatListBgNoiseAnimType;
    [FieldOffset(0x0054)] public uint StatListBgNoiseFrame;
    [FieldOffset(0x0058)] public EOneAnimType StatListBgTextAnimType;
    [FieldOffset(0x005C)] public uint StatListBgTextFrame;
    [FieldOffset(0x0060)] public EOneAnimType StatListOpeListAnimType;
    [FieldOffset(0x0064)] public uint StatListOpeListFrame;
    [FieldOffset(0x0068)] public float StatDetailRotation;
    [FieldOffset(0x006C)] public EOneAnimType StatDetailInfoSlideAnimType;
    [FieldOffset(0x0070)] public uint StatDetailInfoSlideFrame;
    [FieldOffset(0x0074)] public EOneAnimType StatDetailBgNumSlideAnimType;
    [FieldOffset(0x0078)] public uint StatDetailBgNumSlideOutFrame;
    [FieldOffset(0x007C)] public uint StatDetailBgNumSlideInFrame;
    [FieldOffset(0x0080)] public EOneAnimType StatDetailHanshaSlideAnimType;
    [FieldOffset(0x0084)] public uint StatDetailHanshaSlideFrame;
    [FieldOffset(0x0088)] public EOneAnimType StatDetailHahenShadowSlideAnimType;
    [FieldOffset(0x008C)] public uint StatDetailHahenShadowSlideFrame;
    [FieldOffset(0x0090)] public EOneAnimType StatDetailCharaShadowSlideAnimType;
    [FieldOffset(0x0094)] public uint StatDetailCharaShadowSlideFrame;
    [FieldOffset(0x0098)] public EOneAnimType StatDetailLeaderRotAnimType;
    [FieldOffset(0x009C)] public uint StatDetailLeaderRotOutFrame;
    [FieldOffset(0x00A0)] public uint StatDetailLeaderRotInFrame;
    [FieldOffset(0x00A4)] public EOneAnimType StatDetailInOutlineAnimType;
    [FieldOffset(0x00A8)] public uint StatDetailInOutlineFrame;
    [FieldOffset(0x00AC)] public uint StatDetailInOutlineWait;
    [FieldOffset(0x00B0)] public uint StatDetailInOutlineOutFrame;
    [FieldOffset(0x00B4)] public EOneAnimType StatDetailPanelSlideAnimType;
    [FieldOffset(0x00B8)] public uint StatDetailPanelSlideFrame;
    [FieldOffset(0x00BC)] public uint StatDetailToTheurLeaderRotFrame;
    [FieldOffset(0x00C0)] public EOneAnimType StatDetailToTheurDetailInfoSlideAnimType;
    [FieldOffset(0x00C4)] public uint StatDetailToTheurDetailInfoSlideFrame;
    [FieldOffset(0x00C8)] public uint StatDetailToTheurBgNumSlideFrame;
    [FieldOffset(0x00CC)] public uint HumanHamonAlphaFrameDown;
    [FieldOffset(0x00D0)] public uint HumanHamonAlphaFrameUp;
    [FieldOffset(0x00D4)] public uint HumanHamonAlphaFrameStay;
    [FieldOffset(0x00D8)] public uint HumanHamonAlphaInterval;
    [FieldOffset(0x00DC)] public FColor HumanSankakuRed;
    [FieldOffset(0x00E0)] public FColor HumanSankakuGreen;
    [FieldOffset(0x00E4)] public FColor HumanBokasiRed;
    [FieldOffset(0x00E8)] public FColor HumanBokasiGreen;
    [FieldOffset(0x00EC)] public uint HumanInBgSankakuFrame;
    [FieldOffset(0x00F0)] public uint HumanInSankakuFrame;
    [FieldOffset(0x00F4)] public uint HumanInHamonFrame;
    [FieldOffset(0x00F8)] public uint HumanInRankRotFrame;
    [FieldOffset(0x00FC)] public uint HumanInRankSlideFrame;
    [FieldOffset(0x0100)] public uint HumanInHelpSlideFrame;
    [FieldOffset(0x0104)] public uint HumanInTitleSlideFrame;
    [FieldOffset(0x0108)] public uint HumanPointUpTextSlideOneFrame;
    [FieldOffset(0x010C)] public uint HumanPointUpTextSlideTwoFrame;
    [FieldOffset(0x0110)] public uint HumanPointUpTextSlideThreeFrame;
    [FieldOffset(0x0114)] public uint HumanPointUpTextFadeOneFrame;
    [FieldOffset(0x0118)] public uint HumanPointUpTextFadeTwoFrame;
    [FieldOffset(0x011C)] public uint HumanPointUpTextFadeThreeFrame;
    [FieldOffset(0x0120)] public uint HumanPointUpHamonScaleFrame;
    [FieldOffset(0x0124)] public uint HumanPointUpHamonFadeFrame;
    [FieldOffset(0x0128)] public uint HumanPointUpBlueCircleFadeScaleOneFrame;
    [FieldOffset(0x012C)] public uint HumanPointUpBlueCircleFadeScaleTwoFrame;
    [FieldOffset(0x0130)] public uint HumanPointUpBlueCircleFadeScaleThreeFrame;
    [FieldOffset(0x0134)] public uint HumanRankUpTextSlideOneFrame;
    [FieldOffset(0x0138)] public uint HumanRankUpTextSlideTwoFrame;
    [FieldOffset(0x013C)] public uint HumanRankUpTextSlideThreeFrame;
    [FieldOffset(0x0140)] public uint HumanRankUpTextFadeOneFrame;
    [FieldOffset(0x0144)] public uint HumanRankUpTextFadeTwoFrame;
    [FieldOffset(0x0148)] public uint HumanRankUpTextFadeThreeFrame;
    [FieldOffset(0x014C)] public uint HumanRankUpHamonScaleFrame;
    [FieldOffset(0x0150)] public uint HumanRankUpHamonFadeFrame;
    [FieldOffset(0x0154)] public uint HumanRankUpWhiteCircleColorOneFrame;
    [FieldOffset(0x0158)] public uint HumanRankUpWhiteCircleColorTwoFrame;
    [FieldOffset(0x015C)] public uint HumanRankUpWhiteCircleColorThreeFrame;
    [FieldOffset(0x0160)] public uint HumanRankUpWhiteCircleScaleOneFrame;
    [FieldOffset(0x0164)] public uint HumanRankUpWhiteCircleScaleTwoFrame;
    [FieldOffset(0x0168)] public uint HumanRankUpWhiteCircleScaleThreeFrame;
    [FieldOffset(0x016C)] public uint HumanRankUpAllCircleScaleFrame;
    [FieldOffset(0x0170)] public uint HumanRankUpCurrentNumberFadeFrame;
    [FieldOffset(0x0174)] public uint HumanRankUpNextNumberFadeSlideFrame;
    [FieldOffset(0x0178)] public uint HumanRankUpCurrentHelpTextFadeFrame;
    [FieldOffset(0x017C)] public uint HumanRankUpNextHelpTextFadeSlideFrame;
    [FieldOffset(0x0180)] public uint HumanRankUpMaskCircleFrame;
    [FieldOffset(0x0184)] public uint KeyHelpFadeFrame;
    [FieldOffset(0x0188)] public uint KeyHelpMaskSlideOneFrame;
    [FieldOffset(0x018C)] public uint KeyHelpMaskSlideTwoFrame;
    [FieldOffset(0x0190)] public uint KeyHelpMaskSlideThreeFrame;
    [FieldOffset(0x0194)] public uint KeyHelpMaskSlideOneWaitFrame;
    [FieldOffset(0x0198)] public uint KeyHelpMaskSlideTwoWaitFrame;
    [FieldOffset(0x019C)] public uint KeyHelpMaskSlideThreeWaitFrame;
    [FieldOffset(0x01A0)] public uint HumanMaxHamonScaleFlame;
    [FieldOffset(0x01A4)] public uint HumanMaxHamonFadeOneFlame;
    [FieldOffset(0x01A8)] public uint HumanMaxHamonFadeTwoFlame;
    [FieldOffset(0x01AC)] public uint HumanMaxCircleFadeOneFlame;
    [FieldOffset(0x01B0)] public uint HumanMaxCircleFadeTwoFlame;
    [FieldOffset(0x01B4)] public uint HumanCircleLoopFlame;
    [FieldOffset(0x01B8)] public uint HumanPlusHamonFlame;
    [FieldOffset(0x01BC)] public uint HumanOutHelpSlideFrame;
    [FieldOffset(0x01C0)] public uint HumanOutHamonFrame;
    [FieldOffset(0x01C4)] public uint HumanOutSankakuFrame;
    [FieldOffset(0x01C8)] public uint HumanOutRankRotFrame;
    [FieldOffset(0x01CC)] public uint HumanOutBgSankakuFrame;
    [FieldOffset(0x01D0)] public uint HumanHamonLoopScaleDownFrame;
    [FieldOffset(0x01D4)] public uint HumanHamonLoopWaitFrame;
    [FieldOffset(0x01D8)] public uint HumanHamonLoopScaleUpFrame;
    [FieldOffset(0x01DC)] public EOneAnimType FldTheurPanelSlideAnimType;
    [FieldOffset(0x01E0)] public uint FldTheurPanelSlideFrame;
    [FieldOffset(0x01E4)] public uint FldTheurPanelSlideWait;
    [FieldOffset(0x01E8)] public uint FldTheurBgNumSlideFrame;
    [FieldOffset(0x01EC)] public uint FldTheurBgNumSlideWait;
    [FieldOffset(0x01F0)] public EOneAnimType FldTheurBustupSlideAnimType;
    [FieldOffset(0x01F4)] public uint FldTheurBustupSlideInFrame;
    [FieldOffset(0x01F8)] public uint FldTheurBustupSlideInWait;
    [FieldOffset(0x01FC)] public uint FldTheurBustupSlideOutFrame;
    [FieldOffset(0x0200)] public FColor TheurCharaMaskColor;
    [FieldOffset(0x0204)] public FVector2D TheurCharaPosHero;
    [FieldOffset(0x020C)] public FVector2D TheurShadowPosHero;
    [FieldOffset(0x0214)] public FVector2D TheurCharaPosYukari;
    [FieldOffset(0x021C)] public FVector2D TheurShadowPosYukari;
    [FieldOffset(0x0224)] public FVector2D TheurCharaPosJunpei;
    [FieldOffset(0x022C)] public FVector2D TheurShadowPosJunpei;
    [FieldOffset(0x0234)] public FVector2D TheurCharaPosSanada;
    [FieldOffset(0x023C)] public FVector2D TheurShadowPosSanada;
    [FieldOffset(0x0244)] public FVector2D TheurCharaPosMituru;
    [FieldOffset(0x024C)] public FVector2D TheurShadowPosMituru;
    [FieldOffset(0x0254)] public FVector2D TheurCharaPosFuka;
    [FieldOffset(0x025C)] public FVector2D TheurShadowPosFuka;
    [FieldOffset(0x0264)] public FVector2D TheurCharaPosAegis;
    [FieldOffset(0x026C)] public FVector2D TheurShadowPosAegis;
    [FieldOffset(0x0274)] public FVector2D TheurCharaPosAmada;
    [FieldOffset(0x027C)] public FVector2D TheurShadowPosAmada;
    [FieldOffset(0x0284)] public FVector2D TheurCharaPosKoromaru;
    [FieldOffset(0x028C)] public FVector2D TheurShadowPosKoromaru;
    [FieldOffset(0x0294)] public FVector2D TheurCharaPosAragaki;
    [FieldOffset(0x029C)] public FVector2D TheurShadowPosAragaki;
    [FieldOffset(0x02A4)] public EOneAnimType Edit_MaskA_InAnimation_SlideIn_Type;
    [FieldOffset(0x02A8)] public int Edit_MaskA_InAnimation_SlideIn_Frame;
    [FieldOffset(0x02AC)] public int Edit_MaskA_InAnimation_SlideIn_Delay;
    [FieldOffset(0x02B0)] public EOneAnimType Edit_MaskA_OutAnimation_SlideIn_Type;
    [FieldOffset(0x02B4)] public int Edit_MaskA_OutAnimation_SlideIn_Frame;
    [FieldOffset(0x02B8)] public int Edit_MaskA_OutAnimation_SlideIn_Delay;
    [FieldOffset(0x02BC)] public EOneAnimType Edit_MaskA_Change_SlideIn_Type;
    [FieldOffset(0x02C0)] public int Edit_MaskA_Change_SlideIn_Frame;
    [FieldOffset(0x02C4)] public int Edit_MaskA_Change_SlideIn_Delay;
    [FieldOffset(0x02C8)] public EOneAnimType Edit_MaskB_InAnimation_SlideIn_Type;
    [FieldOffset(0x02CC)] public int Edit_MaskB_InAnimation_SlideIn_Frame;
    [FieldOffset(0x02D0)] public int Edit_MaskB_InAnimation_SlideIn_Delay;
    [FieldOffset(0x02D4)] public EOneAnimType Edit_MaskB_OutAnimation_SlideIn_Type;
    [FieldOffset(0x02D8)] public int Edit_MaskB_OutAnimation_SlideIn_Frame;
    [FieldOffset(0x02DC)] public int Edit_MaskB_OutAnimation_SlideIn_Delay;
    [FieldOffset(0x02E0)] public EOneAnimType Edit_MaskB_Change_SlideIn_Type;
    [FieldOffset(0x02E4)] public int Edit_MaskB_Change_SlideIn_Frame;
    [FieldOffset(0x02E8)] public int Edit_MaskB_Change_SlideIn_Delay;
    [FieldOffset(0x02EC)] public EOneAnimType Edit_CharacterShadow_InAnimation_SlideIn_Type;
    [FieldOffset(0x02F0)] public int Edit_CharacterShadow_InAnimation_SlideIn_Frame;
    [FieldOffset(0x02F4)] public int Edit_CharacterShadow_InAnimation_SlideIn_Delay;
    [FieldOffset(0x02F8)] public EOneAnimType Edit_CharacterShadow_Change_SlideIn_Type;
    [FieldOffset(0x02FC)] public int Edit_CharacterShadow_Change_SlideIn_Frame;
    [FieldOffset(0x0300)] public int Edit_CharacterShadow_Change_SlideIn_Delay;
    [FieldOffset(0x0304)] public int Edit_Theurgia_Icon_Fade_In_Frame;
    [FieldOffset(0x0308)] public int Edit_Theurgia_Icon_Fade_In_Delay;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FCampParamTablePersonaRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EOneAnimType PersonaEquipScaleAnimType;
    [FieldOffset(0x000C)] public uint PersonaEquipScaleFrame;
    [FieldOffset(0x0010)] public uint PersonaEquipScaleWait;
    [FieldOffset(0x0014)] public EOneAnimType PersonaEquipRotAnimType;
    [FieldOffset(0x0018)] public uint PersonaEquipRotFrame;
    [FieldOffset(0x001C)] public uint PersonaEquipRotWait;
    [FieldOffset(0x0020)] public EOneAnimType PersonaEquipSlideAnimType;
    [FieldOffset(0x0024)] public uint PersonaEquipSlideFrame;
    [FieldOffset(0x0028)] public uint PersonaEquipSlideWait;
    [FieldOffset(0x002C)] public float PersonaLightSpeed;
    [FieldOffset(0x0030)] public float PersonaWaveSpeed;
    [FieldOffset(0x0034)] public EOneAnimType PersonaArcanaFadeAnimType;
    [FieldOffset(0x0038)] public uint PersonaArcanaFadeFrame;
    [FieldOffset(0x003C)] public float PersonaInDist;
    [FieldOffset(0x0040)] public EOneAnimType PersonaInSilhouetteAnimType;
    [FieldOffset(0x0044)] public uint PersonaInSilhouetteFrame;
    [FieldOffset(0x0048)] public uint PersonaInSilhouetteWait;
    [FieldOffset(0x004C)] public EOneAnimType PersonaInPersonaAnimType;
    [FieldOffset(0x0050)] public uint PersonaInPersonaFrame;
    [FieldOffset(0x0054)] public uint PersonaInPersonaWait;
    [FieldOffset(0x0058)] public float PersonaInPersonaDist;
    [FieldOffset(0x005C)] public EOneAnimType PersonaInSiroItaAnimType;
    [FieldOffset(0x0060)] public uint PersonaInSiroItaFrame;
    [FieldOffset(0x0064)] public uint PersonaInSiroItaWait;
    [FieldOffset(0x0068)] public EOneAnimType PersonaInTitleAnimType;
    [FieldOffset(0x006C)] public uint PersonaInTitleFrame;
    [FieldOffset(0x0070)] public uint PersonaInTitleWait;
    [FieldOffset(0x0074)] public EOneAnimType PersonaInListAnimType;
    [FieldOffset(0x0078)] public uint PersonaInListFrame;
    [FieldOffset(0x007C)] public uint PersonaInListWait;
    [FieldOffset(0x0080)] public EOneAnimType PersonaInArcanaAnimType;
    [FieldOffset(0x0084)] public uint PersonaInArcanaFrame;
    [FieldOffset(0x0088)] public uint PersonaInArcanaWait;
    [FieldOffset(0x008C)] public EOneAnimType ItemPerListInAnimType;
    [FieldOffset(0x0090)] public uint ItemPerListInFrame;
    [FieldOffset(0x0094)] public uint ItemPerListInWait;
    [FieldOffset(0x0098)] public uint ItemPerListInBackFrame;
    [FieldOffset(0x009C)] public EOneAnimType ItemPerListInBgAnimType;
    [FieldOffset(0x00A0)] public uint ItemPerListInBgFrame;
    [FieldOffset(0x00A4)] public uint ItemPerListInBgBackFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct FCampParamTableEquipRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EOneAnimType CategoChangeOutAnimType;
    [FieldOffset(0x000C)] public uint CategoChangeOutFrame;
    [FieldOffset(0x0010)] public EOneAnimType CategoChangeInAnimType;
    [FieldOffset(0x0014)] public uint CategoChangeInFrame;
    [FieldOffset(0x0018)] public EOneAnimType EquipListChangeOutAnimType;
    [FieldOffset(0x001C)] public uint EquipListChangeOutFrame;
    [FieldOffset(0x0020)] public EOneAnimType EquipListChangeInAnimType;
    [FieldOffset(0x0024)] public uint EquipListChangeInFrame;
    [FieldOffset(0x0028)] public EOneAnimType EquipListEquipChangeOutAnimType;
    [FieldOffset(0x002C)] public uint EquipListEquipChangeOutFrame;
    [FieldOffset(0x0030)] public EOneAnimType EquipListEquipChangeInAnimType;
    [FieldOffset(0x0034)] public uint EquipListEquipChangeInFrame;
    [FieldOffset(0x0038)] public uint EquipListParamArrowSelectFrame;
    [FieldOffset(0x003C)] public uint EquipListParamArrowLoopFrame;
    [FieldOffset(0x0040)] public uint EquipCompChangeInInfoWait;
    [FieldOffset(0x0044)] public float EquipInPartyPanelDist;
    [FieldOffset(0x0048)] public EOneAnimType EquipInSilhouetteAnimType;
    [FieldOffset(0x004C)] public uint EquipInSilhouetteFrame;
    [FieldOffset(0x0050)] public uint EquipInSilhouetteWait;
    [FieldOffset(0x0054)] public EOneAnimType EquipInSiroItaAnimType;
    [FieldOffset(0x0058)] public uint EquipInSiroItaFrame;
    [FieldOffset(0x005C)] public uint EquipInSiroItaWait;
    [FieldOffset(0x0060)] public EOneAnimType EquipInAoItaAnimType;
    [FieldOffset(0x0064)] public uint EquipInAoItaFrame;
    [FieldOffset(0x0068)] public uint EquipInAoItaWait;
    [FieldOffset(0x006C)] public EOneAnimType EquipInTitleAnimType;
    [FieldOffset(0x0070)] public uint EquipInTitleFrame;
    [FieldOffset(0x0074)] public uint EquipInTitleWait;
    [FieldOffset(0x0078)] public EOneAnimType EquipInBgPlusAnimType;
    [FieldOffset(0x007C)] public uint EquipInBgPlusFrame;
    [FieldOffset(0x0080)] public uint EquipInBgPlusWait;
    [FieldOffset(0x0084)] public float EquipInCharaEquipDist;
    [FieldOffset(0x0088)] public EOneAnimType EquipInCharaEquipSlideAnimType;
    [FieldOffset(0x008C)] public uint EquipInCharaEquipSlideFrame;
    [FieldOffset(0x0090)] public uint EquipInCharaEquipSlideWait;
    [FieldOffset(0x0094)] public uint EquipInCharaEquipSlideInterval;
    [FieldOffset(0x0098)] public uint EquipInCharaEquipFadeFrame;
    [FieldOffset(0x009C)] public uint EquipInPartyPanelWait;
    [FieldOffset(0x00A0)] public uint ToCateCharaEquipFadeFrame;
    [FieldOffset(0x00A4)] public EOneAnimType ToCateSiroItaAnimType;
    [FieldOffset(0x00A8)] public uint ToCateSiroItaFrame;
    [FieldOffset(0x00AC)] public uint ToCateSiroItaWait;
    [FieldOffset(0x00B0)] public EOneAnimType CategoInSelPartySlideAnimType;
    [FieldOffset(0x00B4)] public uint CategoInSelPartySlideFrame;
    [FieldOffset(0x00B8)] public uint CategoInSelPartyFadeFrame;
    [FieldOffset(0x00BC)] public EOneAnimType CategoInBgPlusAnimType;
    [FieldOffset(0x00C0)] public uint CategoInBgPlusFrame;
    [FieldOffset(0x00C4)] public uint CategoInBgPlusWait;
    [FieldOffset(0x00C8)] public EOneAnimType CategoInTabSlideAnimType;
    [FieldOffset(0x00CC)] public uint CategoInTabSlideFrame;
    [FieldOffset(0x00D0)] public float CategoInCategoryDist;
    [FieldOffset(0x00D4)] public EOneAnimType CategoInCategorySlideAnimType;
    [FieldOffset(0x00D8)] public uint CategoInCategorySlideFrame;
    [FieldOffset(0x00DC)] public uint CategoInCategorySlideInterval;
    [FieldOffset(0x00E0)] public uint CategoInCategoryFadeFrame;
    [FieldOffset(0x00E4)] public EOneAnimType BackCateSelPartyOutAnimType;
    [FieldOffset(0x00E8)] public uint BackCateSelPartyOutFrame;
    [FieldOffset(0x00EC)] public EOneAnimType BackCateSiroItaAnimType;
    [FieldOffset(0x00F0)] public uint BackCateSiroItaFrame;
    [FieldOffset(0x00F4)] public uint ToListCharaEquipOutFrame;
    [FieldOffset(0x00F8)] public EOneAnimType ToListSiroItaAnimType;
    [FieldOffset(0x00FC)] public uint ToListSiroItaFrame;
    [FieldOffset(0x0100)] public EOneAnimType ListInPartyExBgSlideAnimType;
    [FieldOffset(0x0104)] public uint ListInPartyExBgSlideFrame;
    [FieldOffset(0x0108)] public uint ListInPartyExInfoFadeFrame;
    [FieldOffset(0x010C)] public float ListInEquipListDist;
    [FieldOffset(0x0110)] public EOneAnimType ListInEquipListSlideAnimType;
    [FieldOffset(0x0114)] public uint ListInEquipListSlideFrame;
    [FieldOffset(0x0118)] public uint ListInEquipListSlideWait;
    [FieldOffset(0x011C)] public uint ListInEquipListFadeFrame;
    [FieldOffset(0x0120)] public uint BackEquipListOutFrame;
    [FieldOffset(0x0124)] public EOneAnimType ToCompBg1ScaleAnimType;
    [FieldOffset(0x0128)] public uint ToCompBg1ScaleFrame;
    [FieldOffset(0x012C)] public uint ToCompBg1ScaleWait;
    [FieldOffset(0x0130)] public uint ToCompBg2ScaleFrame;
    [FieldOffset(0x0134)] public uint ToCompBg2ScaleWait;
    [FieldOffset(0x0138)] public EOneAnimType CompInSelectListSlideAnimType;
    [FieldOffset(0x013C)] public uint CompInSelectListSlideFrame;
    [FieldOffset(0x0140)] public uint CompInSelectListSlideWait;
    [FieldOffset(0x0144)] public EOneAnimType CompInScrollBarSlideAnimType;
    [FieldOffset(0x0148)] public uint CompInScrollBarSlideFrame;
    [FieldOffset(0x014C)] public EOneAnimType CompInArrowSlideAnimType;
    [FieldOffset(0x0150)] public uint CompInArrowSlideFrame;
    [FieldOffset(0x0154)] public EOneAnimType CompInDetailSlideAnimType;
    [FieldOffset(0x0158)] public uint CompInDetailSlideFrame;
    [FieldOffset(0x015C)] public uint BackEquipCompOutFrame;
    [FieldOffset(0x0160)] public EOneAnimType BackCompBgScaleAnimType;
    [FieldOffset(0x0164)] public uint BackCompBgScaleFrame;
    [FieldOffset(0x0168)] public uint BackCompBgScaleWait;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FCampParamTableItemRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float ItemInDist;
    [FieldOffset(0x000C)] public EOneAnimType ItemSilhouetteAnimType;
    [FieldOffset(0x0010)] public uint ItemSilhouetteFrame;
    [FieldOffset(0x0014)] public uint ItemSilhouetteWait;
    [FieldOffset(0x0018)] public EOneAnimType ItemSiroItaAnimType;
    [FieldOffset(0x001C)] public uint ItemSiroItaFrame;
    [FieldOffset(0x0020)] public uint ItemSiroItaWait;
    [FieldOffset(0x0024)] public EOneAnimType ItemTitleAnimType;
    [FieldOffset(0x0028)] public uint ItemTitleFrame;
    [FieldOffset(0x002C)] public uint ItemTitleWait;
    [FieldOffset(0x0030)] public EOneAnimType ItemListAnimType;
    [FieldOffset(0x0034)] public uint ItemListFrame;
    [FieldOffset(0x0038)] public uint ItemListWait;
    [FieldOffset(0x003C)] public EOneAnimType ItemTabAnimType;
    [FieldOffset(0x0040)] public uint ItemTabFrame;
    [FieldOffset(0x0044)] public uint ItemTabWait;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FCampParamTableSkillRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float SkillInDist;
    [FieldOffset(0x000C)] public EOneAnimType SkillSilhouetteAnimType;
    [FieldOffset(0x0010)] public uint SkillSilhouetteFrame;
    [FieldOffset(0x0014)] public uint SkillSilhouetteWait;
    [FieldOffset(0x0018)] public EOneAnimType SkillSiroItaAnimType;
    [FieldOffset(0x001C)] public uint SkillSiroItaFrame;
    [FieldOffset(0x0020)] public uint SkillSiroItaWait;
    [FieldOffset(0x0024)] public EOneAnimType SkillTitleAnimType;
    [FieldOffset(0x0028)] public uint SkillTitleFrame;
    [FieldOffset(0x002C)] public uint SkillTitleWait;
    [FieldOffset(0x0030)] public EOneAnimType SkillListAnimType;
    [FieldOffset(0x0034)] public uint SkillListFrame;
    [FieldOffset(0x0038)] public uint SkillListWait;
    [FieldOffset(0x003C)] public EOneAnimType SkillPartyAnimType;
    [FieldOffset(0x0040)] public uint SkillPartyFrame;
    [FieldOffset(0x0044)] public uint SkillPartyWait;
    [FieldOffset(0x0048)] public uint SkillPartyFadeFrame;
    [FieldOffset(0x004C)] public uint SkillPartyInterval;
    [FieldOffset(0x0050)] public EOneAnimType GunRefRotAnimType;
    [FieldOffset(0x0054)] public uint GunRefInFrame;
    [FieldOffset(0x0058)] public uint GunRefInWait;
    [FieldOffset(0x005C)] public uint GunRefNextFrame;
    [FieldOffset(0x0060)] public FVector2D GunRefPos;
    [FieldOffset(0x0068)] public float GunRefOffset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FCampParamTableTopRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float TopInDist;
    [FieldOffset(0x000C)] public float TopInMenuDist;
    [FieldOffset(0x0010)] public EOneAnimType TopInTitleAnimType;
    [FieldOffset(0x0014)] public uint TopInTitleFrame;
    [FieldOffset(0x0018)] public uint TopInTitleWait;
    [FieldOffset(0x001C)] public EOneAnimType TopInMenuAnimType;
    [FieldOffset(0x0020)] public uint TopInMenuFrame;
    [FieldOffset(0x0024)] public uint TopInMenuWait;
    [FieldOffset(0x0028)] public uint TopInMenuInterval;
    [FieldOffset(0x002C)] public EOneAnimType TopInWhiteCursorAnimType;
    [FieldOffset(0x0030)] public uint TopInWhiteCursorFrame;
    [FieldOffset(0x0034)] public uint TopInWhiteCursorWait;
    [FieldOffset(0x0038)] public EOneAnimType TopInRedCursorAnimType;
    [FieldOffset(0x003C)] public uint TopInRedCursorFrame;
    [FieldOffset(0x0040)] public uint TopInRedCursorWait;
    [FieldOffset(0x0044)] public uint Edit_Top_Reselect_Key_Lock_Frame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCampParamTableHologRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EOneAnimType HologAnimType;
    [FieldOffset(0x000C)] public uint HologTransFrame;
    [FieldOffset(0x0010)] public uint HologTransWait;
    [FieldOffset(0x0014)] public uint HologColorWait;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCampParamTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Dummy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCldBindingEventActorTag
{
    [FieldOffset(0x0000)] public FString mAssetName;
    [FieldOffset(0x0010)] public FString mBindingTag;
    [FieldOffset(0x0020)] public int mNpcSkeltonID;
    [FieldOffset(0x0024)] public short mCostumeID;
    [FieldOffset(0x0026)] public short mAnimSlotID;
    [FieldOffset(0x0028)] public bool mIsBag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCldBindingEventParam
{
    [FieldOffset(0x0000)] public int mEventMajorID;
    [FieldOffset(0x0004)] public int mEventMinorID;
    [FieldOffset(0x0008)] public TArray<FCldBindingEventActorTag> mActorTags;
    [FieldOffset(0x0018)] public short mMsgRef;
    [FieldOffset(0x0020)] public TArray<int> mPictureDefs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCldDateMessageTableItem
{
    [FieldOffset(0x0000)] public int Key;
    [FieldOffset(0x0004)] public byte Month;
    [FieldOffset(0x0005)] public byte Day;
    [FieldOffset(0x0006)] public byte Period;
    [FieldOffset(0x0008)] public FString MsgLabel;
    [FieldOffset(0x0018)] public FString VisibleFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FEquipItemInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FSelectSkillData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChristmasEventMailRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public short MailID;
    [FieldOffset(0x000A)] public short Rank;
    [FieldOffset(0x000C)] public FName flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChristmasEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public short major;
    [FieldOffset(0x000A)] public short Minor;
    [FieldOffset(0x000C)] public FName flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSummerFestivalEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int MailID;
    [FieldOffset(0x000C)] public short major;
    [FieldOffset(0x000E)] public short Minor;
    [FieldOffset(0x0010)] public FName OnFlag;
    [FieldOffset(0x0018)] public FName OffFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMoviesEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public sbyte Month;
    [FieldOffset(0x0009)] public sbyte Day;
    [FieldOffset(0x000C)] public FName ArcanaID;
    [FieldOffset(0x0014)] public int MailID;
    [FieldOffset(0x0018)] public short major;
    [FieldOffset(0x001A)] public short Minor;
    [FieldOffset(0x001C)] public sbyte CommunityRankMin;
    [FieldOffset(0x001D)] public sbyte CommunityRankMax;
    [FieldOffset(0x0020)] public FName OffFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCommunityPresentRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName ItemId;
    [FieldOffset(0x0010)] public int AddCommunityPoint;
    [FieldOffset(0x0014)] public FName ReactionMessageLabel;
    [FieldOffset(0x001C)] public FName HeroMessageLabel;
    [FieldOffset(0x0024)] public FName ChristmasReactionMessageLabel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FUniqCoefficientRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Type;
    [FieldOffset(0x0010)] public FName flag;
    [FieldOffset(0x0018)] public float Coefficient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FGeneralCoefficientRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName flag;
    [FieldOffset(0x0010)] public float Coefficient;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FHolidayScheduleRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Month;
    [FieldOffset(0x000C)] public int Day;
    [FieldOffset(0x0010)] public FName ArcanaID_A;
    [FieldOffset(0x0018)] public FName ArcanaID_B;
    [FieldOffset(0x0020)] public FName ArcanaID_C;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FHolidayEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int major;
    [FieldOffset(0x000C)] public int Minor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FHeroParameterPointRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int BrainPoint;
    [FieldOffset(0x000C)] public int CharmPoint;
    [FieldOffset(0x0010)] public int CouragePoint;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FRankUpEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public short Rank;
    [FieldOffset(0x000A)] public short Point;
    [FieldOffset(0x000C)] public short major;
    [FieldOffset(0x000E)] public short Minor;
    [FieldOffset(0x0010)] public sbyte Brain;
    [FieldOffset(0x0011)] public sbyte charm;
    [FieldOffset(0x0012)] public sbyte Courage;
    [FieldOffset(0x0014)] public FName Flag0;
    [FieldOffset(0x001C)] public FName Flag1;
    [FieldOffset(0x0024)] public FName Flag2;
    [FieldOffset(0x002C)] public FName Flag3;
    [FieldOffset(0x0034)] public FName Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNotRankUpEventRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Rank;
    [FieldOffset(0x000C)] public short major;
    [FieldOffset(0x000E)] public short Minor;
    [FieldOffset(0x0010)] public FName Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVeveMessage
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Message;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCommunityNameFormat
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName CommunityName;
    [FieldOffset(0x0010)] public FName CampDispCommunityCharacterNameA;
    [FieldOffset(0x0018)] public FName CampDispCommunityCharacterNameB;
    [FieldOffset(0x0020)] public FName NPCFirstNameA;
    [FieldOffset(0x0028)] public FName NPCLastNameA;
    [FieldOffset(0x0030)] public FName NPCFirstNameB;
    [FieldOffset(0x0038)] public FName NPCLastNameB;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FCommunityMemberFormat
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int PCID1;
    [FieldOffset(0x000C)] public uint Flag1;
    [FieldOffset(0x0010)] public int PCID2;
    [FieldOffset(0x0014)] public uint Flag2;
    [FieldOffset(0x0018)] public int PCID3;
    [FieldOffset(0x001C)] public uint Flag3;
    [FieldOffset(0x0020)] public int PCID4;
    [FieldOffset(0x0024)] public uint Flag4;
    [FieldOffset(0x0028)] public int PCID5;
    [FieldOffset(0x002C)] public uint Flag5;
    [FieldOffset(0x0030)] public int PCID6;
    [FieldOffset(0x0034)] public uint Flag6;
    [FieldOffset(0x0038)] public int PCID7;
    [FieldOffset(0x003C)] public uint Flag7;
    [FieldOffset(0x0040)] public int PCID8;
    [FieldOffset(0x0044)] public uint Flag8;
    [FieldOffset(0x0048)] public int PCID9;
    [FieldOffset(0x004C)] public uint Flag9;
    [FieldOffset(0x0050)] public int PCID10;
    [FieldOffset(0x0054)] public uint Flag10;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FHeroParameterNameRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FText Brain;
    [FieldOffset(0x0020)] public FText charm;
    [FieldOffset(0x0038)] public FText Courage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCommunityNPCInfo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCommunityCharacter
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCommunityMemberInfo
{
    [FieldOffset(0x0000)] public TArray<FCommunityCharacter> Member;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FHeroParameterHandleSaveData_t
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FCommunityHandleSaveData_t
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FHeroParameterSaveData_t
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCommunitySaveData_t
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D78)] 
public unsafe struct FDatItemBag
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FDatPlayerNameTableRowBase
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int PlayerId;
    [FieldOffset(0x0010)] public FText Name;
    [FieldOffset(0x0028)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDatName2Table
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FText Name1;
    [FieldOffset(0x0020)] public FText Name2;
    [FieldOffset(0x0038)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FDatNameTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FText Name;
    [FieldOffset(0x0020)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDatDefineTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Value;
    [FieldOffset(0x0010)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FDatUnitDropItem
{
    [FieldOffset(0x0000)] public uint ID;
    [FieldOffset(0x0004)] public bool eventitem;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDatUnitStatus
{
    [FieldOffset(0x0000)] public int Hp;
    [FieldOffset(0x0004)] public int Sp;
    [FieldOffset(0x0008)] public int tp;
    [FieldOffset(0x000C)] public uint bad;
    [FieldOffset(0x0010)] public short Level;
    [FieldOffset(0x0014)] public uint Exp;
    [FieldOffset(0x0018)] public ushort affinity;
    [FieldOffset(0x001C)] public uint personalSkill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FDatUnitSupport
{
    [FieldOffset(0x0000)] public uint valid;
    [FieldOffset(0x0004)] public uint appointment;
    [FieldOffset(0x0008)] public sbyte Point;
    [FieldOffset(0x0012)] public sbyte Turn;
}

[StructLayout(LayoutKind.Explicit, Size = 0x244)] 
public unsafe struct FDatUnitPersona
{
    [FieldOffset(0x0000)] public ushort equip;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA)] 
public unsafe struct FDatUnitItem
{
    [FieldOffset(0x0000)] public ushort equip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FDatUnitSpecialSkill
{
    [FieldOffset(0x0000)] public ushort skillId;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B4)] 
public unsafe struct FDatUnitWork
{
    [FieldOffset(0x0000)] public uint flags;
    [FieldOffset(0x0004)] public ushort genus;
    [FieldOffset(0x0008)] public uint ID;
    [FieldOffset(0x000C)] public FDatUnitStatus Status;
    [FieldOffset(0x002C)] public FDatUnitSupport support;
    [FieldOffset(0x0048)] public FDatUnitPersona persona;
    [FieldOffset(0x028C)] public FDatUnitItem Item;
    [FieldOffset(0x0296)] public ushort Operation;
    [FieldOffset(0x0298)] public ushort Message;
    [FieldOffset(0x029A)] public short maxHpUp;
    [FieldOffset(0x029C)] public short maxSpUp;
    [FieldOffset(0x029E)] public FDatUnitSpecialSkill specialSkill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FDictionarySortTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int SortID;
    [FieldOffset(0x0010)] public TArray<FName> TextureNames;
    [FieldOffset(0x0020)] public FName OpenFlagName;
    [FieldOffset(0x0028)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct FVelvetWipeTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector StartRectPos;
    [FieldOffset(0x0014)] public FVector StartRectV1;
    [FieldOffset(0x0020)] public FVector StartRectV2;
    [FieldOffset(0x002C)] public FVector StartRectV3;
    [FieldOffset(0x0038)] public FVector StartRectV4;
    [FieldOffset(0x0044)] public FVector EndRectPos;
    [FieldOffset(0x0050)] public FVector EndRectV1;
    [FieldOffset(0x005C)] public FVector EndRectV2;
    [FieldOffset(0x0068)] public FVector EndRectV3;
    [FieldOffset(0x0074)] public FVector EndRectV4;
    [FieldOffset(0x0080)] public FVector StartRectPosEv;
    [FieldOffset(0x008C)] public FVector StartRectV1Ev;
    [FieldOffset(0x0098)] public FVector StartRectV2Ev;
    [FieldOffset(0x00A4)] public FVector StartRectV3Ev;
    [FieldOffset(0x00B0)] public FVector StartRectV4Ev;
    [FieldOffset(0x00BC)] public FVector EndRectPosEv;
    [FieldOffset(0x00C8)] public FVector EndRectV1Ev;
    [FieldOffset(0x00D4)] public FVector EndRectV2Ev;
    [FieldOffset(0x00E0)] public FVector EndRectV3Ev;
    [FieldOffset(0x00EC)] public FVector EndRectV4Ev;
    [FieldOffset(0x00F8)] public FVector StartRectPos_Out;
    [FieldOffset(0x0104)] public FVector StartRectV1_Out;
    [FieldOffset(0x0110)] public FVector StartRectV2_Out;
    [FieldOffset(0x011C)] public FVector StartRectV3_Out;
    [FieldOffset(0x0128)] public FVector StartRectV4_Out;
    [FieldOffset(0x0134)] public FVector EndRectPos_Out;
    [FieldOffset(0x0140)] public FVector EndRectV1_Out;
    [FieldOffset(0x014C)] public FVector EndRectV2_Out;
    [FieldOffset(0x0158)] public FVector EndRectV3_Out;
    [FieldOffset(0x0164)] public FVector EndRectV4_Out;
    [FieldOffset(0x0170)] public FVector SideDoorLeftStartV1;
    [FieldOffset(0x017C)] public FVector SideDoorLeftStartV2;
    [FieldOffset(0x0188)] public FVector SideDoorLeftStartV3;
    [FieldOffset(0x0194)] public FVector SideDoorLeftStartV4;
    [FieldOffset(0x01A0)] public FVector SideDoorLeftShadowStartV3;
    [FieldOffset(0x01AC)] public FVector SideDoorLeftShadowStartV4;
    [FieldOffset(0x01B8)] public FVector SideDoorRightStartV1;
    [FieldOffset(0x01C4)] public FVector SideDoorRightStartV2;
    [FieldOffset(0x01D0)] public FVector SideDoorRightStartV3;
    [FieldOffset(0x01DC)] public FVector SideDoorRightStartV4;
    [FieldOffset(0x01E8)] public FVector SideDoorRightShadowStartV3;
    [FieldOffset(0x01F4)] public FVector SideDoorRightShadowStartV4;
    [FieldOffset(0x0200)] public FVector SideDoorLeftEndV1;
    [FieldOffset(0x020C)] public FVector SideDoorLeftEndV2;
    [FieldOffset(0x0218)] public FVector SideDoorLeftEndV3;
    [FieldOffset(0x0224)] public FVector SideDoorLeftEndV4;
    [FieldOffset(0x0230)] public FVector SideDoorLeftShadowEndV3;
    [FieldOffset(0x023C)] public FVector SideDoorLeftShadowEndV4;
    [FieldOffset(0x0248)] public FVector SideDoorRightEndV1;
    [FieldOffset(0x0254)] public FVector SideDoorRightEndV2;
    [FieldOffset(0x0260)] public FVector SideDoorRightEndV3;
    [FieldOffset(0x026C)] public FVector SideDoorRightEndV4;
    [FieldOffset(0x0278)] public FVector SideDoorRightShadowEndV3;
    [FieldOffset(0x0284)] public FVector SideDoorRightShadowEndV4;
    [FieldOffset(0x0290)] public int StartRectFadeFrame;
    [FieldOffset(0x0294)] public int StartRectFadeFrame_Out;
    [FieldOffset(0x0298)] public float FlontLightAdjustY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFadeStatus
{
    [FieldOffset(0x0018)] public UFadeProgramBase* program;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFileNameListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Path;
    [FieldOffset(0x0018)] public FString Filename;
    [FieldOffset(0x0028)] public int chunk;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldHeadIconData
{
    [FieldOffset(0x0000)] public bool bIsVisible;
    [FieldOffset(0x0004)] public int mClassIndex;
    [FieldOffset(0x0008)] public AActor* mActor;
    [FieldOffset(0x0010)] public FAppCharTransparency mTransparency;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldIconDispData
{
    [FieldOffset(0x0000)] public bool mSet;
    [FieldOffset(0x0008)] public AFldHitCharacter* mCharaActor;
    [FieldOffset(0x0010)] public AFldHitActor* mHitActor;
    [FieldOffset(0x0018)] public float mTimer;
    [FieldOffset(0x001C)] public float mEndTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFldBgmTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int BgmId;
    [FieldOffset(0x000C)] public int GayaVoiceAssetID;
    [FieldOffset(0x0010)] public int GayaVoiceCueID;
    [FieldOffset(0x0014)] public int FieldMajor;
    [FieldOffset(0x0018)] public int FieldMinor;
    [FieldOffset(0x001C)] public int StartMonth;
    [FieldOffset(0x0020)] public int StartDay;
    [FieldOffset(0x0024)] public int EndMonth;
    [FieldOffset(0x0028)] public int EndDay;
    [FieldOffset(0x002C)] public int Time;
    [FieldOffset(0x0030)] public int flag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FldCameraInputInterpolation
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldCharAreaParam
{
    [FieldOffset(0x0000)] public FVector Offset;
    [FieldOffset(0x000C)] public FVector BoxExtent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FFldCmmNpcLayoutData
{
    [FieldOffset(0x0000)] public int mUniqueID;
    [FieldOffset(0x0004)] public int mArcanaID;
    [FieldOffset(0x0008)] public int mFieldPartsID;
    [FieldOffset(0x000C)] public EFldCmmNpcType mType;
    [FieldOffset(0x000D)] public EFldHitCharaIconType mIconType;
    [FieldOffset(0x0010)] public TArray<FFldHitCharaIconParam> mChangeIcons;
    [FieldOffset(0x0020)] public int mNameIndex;
    [FieldOffset(0x0024)] public FName mOnFlagName;
    [FieldOffset(0x002C)] public FName mOffFlagName;
    [FieldOffset(0x0038)] public TArray<FTransform> mCharaTrans;
    [FieldOffset(0x0050)] public FTransform mIconTran;
    [FieldOffset(0x0080)] public bool bNotMapInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldCmmNpcLayoutList
{
    [FieldOffset(0x0000)] public int mFieldMajor;
    [FieldOffset(0x0004)] public int mFieldMinor;
    [FieldOffset(0x0008)] public int mTimeType;
    [FieldOffset(0x000C)] public int mKeyfreeEventID;
    [FieldOffset(0x0010)] public TArray<FFldCmmNpcLayoutData> mDataList;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FFldCmmNpcLayoutTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajor;
    [FieldOffset(0x000C)] public int FieldMinor;
    [FieldOffset(0x0010)] public int FieldParts;
    [FieldOffset(0x0014)] public int TimeType;
    [FieldOffset(0x0018)] public int KeyfreeEventID;
    [FieldOffset(0x001C)] public int UniqueId;
    [FieldOffset(0x0020)] public int ArcanaID;
    [FieldOffset(0x0024)] public EFldCmmNpcType Type;
    [FieldOffset(0x0025)] public EFldHitCharaIconType IconType;
    [FieldOffset(0x0028)] public TArray<FFldHitCharaIconParam> ChangeIcons;
    [FieldOffset(0x0038)] public int NameIndex;
    [FieldOffset(0x003C)] public FName OnFlagName;
    [FieldOffset(0x0044)] public FName OffFlagName;
    [FieldOffset(0x0050)] public TArray<FTransform> CharaTrans;
    [FieldOffset(0x0060)] public FTransform IconTran;
    [FieldOffset(0x0090)] public bool NotMapInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldCrowdWalkInitActorData
{
    [FieldOffset(0x0000)] public int BpIndex;
    [FieldOffset(0x0004)] public FVector StartLocation;
    [FieldOffset(0x0010)] public int PointIndex;
    [FieldOffset(0x0018)] public TArray<FMobWalkRoutePoint> PointArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldCrowdWalkInitRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajorID;
    [FieldOffset(0x000C)] public int FieldMinorID;
    [FieldOffset(0x0010)] public int SeasonType;
    [FieldOffset(0x0014)] public int TimeType;
    [FieldOffset(0x0018)] public TArray<FFldCrowdWalkInitActorData> ActorArray;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldDungeonEncountPacDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort encNo1;
    [FieldOffset(0x000A)] public ushort probability1;
    [FieldOffset(0x000C)] public ushort encNo2;
    [FieldOffset(0x000E)] public ushort probability2;
    [FieldOffset(0x0010)] public ushort encNo3;
    [FieldOffset(0x0012)] public ushort probability3;
    [FieldOffset(0x0014)] public ushort encNo4;
    [FieldOffset(0x0016)] public ushort probability4;
    [FieldOffset(0x0018)] public ushort encNo5;
    [FieldOffset(0x001A)] public ushort probability5;
    [FieldOffset(0x001C)] public ushort encNo6;
    [FieldOffset(0x001E)] public ushort probability6;
    [FieldOffset(0x0020)] public ushort encNo7;
    [FieldOffset(0x0022)] public ushort probability7;
    [FieldOffset(0x0024)] public ushort encNo8;
    [FieldOffset(0x0026)] public ushort probability8;
    [FieldOffset(0x0028)] public byte order1;
    [FieldOffset(0x0029)] public byte order2;
    [FieldOffset(0x002A)] public byte order3;
    [FieldOffset(0x002B)] public byte order4;
    [FieldOffset(0x002C)] public byte order5;
    [FieldOffset(0x002D)] public byte order6;
    [FieldOffset(0x002E)] public byte order7;
    [FieldOffset(0x002F)] public byte order8;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldDungeonTBoxPacDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint pacID;
    [FieldOffset(0x000C)] public ushort tboxID;
    [FieldOffset(0x000E)] public ushort Probability;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldDungeonTBoxItemDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort ItemId;
    [FieldOffset(0x000A)] public ushort itemNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldDungeonTBoxTypeDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort rareMin;
    [FieldOffset(0x000A)] public ushort rareMax;
    [FieldOffset(0x000C)] public ushort jewelryMin;
    [FieldOffset(0x000E)] public ushort jewelryMax;
    [FieldOffset(0x0010)] public ushort primFieldMin;
    [FieldOffset(0x0012)] public ushort primFieldMax;
    [FieldOffset(0x0014)] public ushort medal1Min;
    [FieldOffset(0x0016)] public ushort medal1Max;
    [FieldOffset(0x0018)] public ushort medal2Min;
    [FieldOffset(0x001A)] public ushort medal2Max;
    [FieldOffset(0x001C)] public ushort medal3Min;
    [FieldOffset(0x001E)] public ushort medal3Max;
    [FieldOffset(0x0020)] public ushort medal4Min;
    [FieldOffset(0x0022)] public ushort medal4Max;
    [FieldOffset(0x0024)] public ushort medal5Min;
    [FieldOffset(0x0026)] public ushort medal5Max;
    [FieldOffset(0x0028)] public ushort medal6Min;
    [FieldOffset(0x002A)] public ushort medal6Max;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FFldDungeonFloorDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint flags;
    [FieldOffset(0x000C)] public ushort FieldMajor;
    [FieldOffset(0x000E)] public ushort FieldMinor;
    [FieldOffset(0x0010)] public ushort major;
    [FieldOffset(0x0012)] public ushort Minor;
    [FieldOffset(0x0014)] public byte areaNo;
    [FieldOffset(0x0015)] public byte envID;
    [FieldOffset(0x0016)] public byte partMin;
    [FieldOffset(0x0017)] public byte partMax;
    [FieldOffset(0x0018)] public byte partSelTable;
    [FieldOffset(0x0019)] public byte enemyMin;
    [FieldOffset(0x001A)] public byte enemyMax;
    [FieldOffset(0x001B)] public byte strongEnemyProbability;
    [FieldOffset(0x001C)] public byte strongEnemyMax;
    [FieldOffset(0x001D)] public byte rareEnemyProbability;
    [FieldOffset(0x001E)] public byte rareEnemyMax;
    [FieldOffset(0x001F)] public byte repopNormalNormal;
    [FieldOffset(0x0020)] public byte repopNormalStrong;
    [FieldOffset(0x0021)] public byte repopNormalRare;
    [FieldOffset(0x0022)] public byte repopStrongNormal;
    [FieldOffset(0x0023)] public byte repopStrongStrong;
    [FieldOffset(0x0024)] public byte repopStrongRare;
    [FieldOffset(0x0025)] public byte repopRareNormal;
    [FieldOffset(0x0026)] public byte repopRareStrong;
    [FieldOffset(0x0027)] public byte repopRareRare;
    [FieldOffset(0x0028)] public float reaper;
    [FieldOffset(0x002C)] public ushort encountPack;
    [FieldOffset(0x002E)] public ushort strongEncountPack;
    [FieldOffset(0x0030)] public ushort pinchEncountPack;
    [FieldOffset(0x0032)] public ushort pinchStrongEncountPack;
    [FieldOffset(0x0034)] public ushort rareEncountPack;
    [FieldOffset(0x0036)] public ushort continousEncount1;
    [FieldOffset(0x0038)] public ushort continousEncount2;
    [FieldOffset(0x003A)] public byte doorGroup;
    [FieldOffset(0x003B)] public byte doorProbability;
    [FieldOffset(0x003C)] public ushort returnDevProbability;
    [FieldOffset(0x003E)] public byte tboxMin;
    [FieldOffset(0x003F)] public byte tboxMax;
    [FieldOffset(0x0040)] public byte tboxType;
    [FieldOffset(0x0041)] public byte moneyProbability;
    [FieldOffset(0x0042)] public ushort moneyMin;
    [FieldOffset(0x0044)] public ushort moneyMax;
    [FieldOffset(0x0046)] public ushort tboxPack;
    [FieldOffset(0x0048)] public ushort rareTboxPack;
    [FieldOffset(0x004A)] public ushort jewelryTboxPack;
    [FieldOffset(0x004C)] public ushort primFieldTboxPack;
    [FieldOffset(0x004E)] public ushort medal1TboxPack;
    [FieldOffset(0x0050)] public ushort medal2TboxPack;
    [FieldOffset(0x0052)] public ushort medal3TboxPack;
    [FieldOffset(0x0054)] public ushort medal4TboxPack;
    [FieldOffset(0x0056)] public ushort medal5TboxPack;
    [FieldOffset(0x0058)] public ushort medal6TboxPack;
    [FieldOffset(0x005A)] public ushort doorTboxPack;
    [FieldOffset(0x005C)] public ushort doorRareTboxPack;
    [FieldOffset(0x005E)] public ushort doorJewelryTboxPack;
    [FieldOffset(0x0060)] public ushort doorPrimFieldTboxPack;
    [FieldOffset(0x0062)] public ushort doorMedal1TboxPack;
    [FieldOffset(0x0064)] public ushort doorMedal2TboxPack;
    [FieldOffset(0x0066)] public ushort doorMedal3TboxPack;
    [FieldOffset(0x0068)] public ushort doorMedal4TboxPack;
    [FieldOffset(0x006A)] public ushort doorMedal5TboxPack;
    [FieldOffset(0x006C)] public ushort doorMedal6TboxPack;
    [FieldOffset(0x0070)] public uint missingPersonID;
    [FieldOffset(0x0074)] public uint missingBuildID;
    [FieldOffset(0x0078)] public uint scrFileNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldDungeonLayoutCombDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort prio;
    [FieldOffset(0x000A)] public ushort Index;
    [FieldOffset(0x000C)] public byte Data0_0_no;
    [FieldOffset(0x000D)] public byte Data0_0_dir;
    [FieldOffset(0x000E)] public byte Data0_0_y;
    [FieldOffset(0x000F)] public byte Data0_1_no;
    [FieldOffset(0x0010)] public byte Data0_1_dir;
    [FieldOffset(0x0011)] public byte Data0_1_y;
    [FieldOffset(0x0012)] public byte Data0_2_no;
    [FieldOffset(0x0013)] public byte Data0_2_dir;
    [FieldOffset(0x0014)] public byte Data0_2_y;
    [FieldOffset(0x0015)] public byte Data1_0_no;
    [FieldOffset(0x0016)] public byte Data1_0_dir;
    [FieldOffset(0x0017)] public byte Data1_0_y;
    [FieldOffset(0x0018)] public byte Data1_1_no;
    [FieldOffset(0x0019)] public byte Data1_1_dir;
    [FieldOffset(0x001A)] public byte Data1_1_y;
    [FieldOffset(0x001B)] public byte Data1_2_no;
    [FieldOffset(0x001C)] public byte Data1_2_dir;
    [FieldOffset(0x001D)] public byte Data1_2_y;
    [FieldOffset(0x001E)] public byte Data2_0_no;
    [FieldOffset(0x001F)] public byte Data2_0_dir;
    [FieldOffset(0x0020)] public byte Data2_0_y;
    [FieldOffset(0x0021)] public byte Data2_1_no;
    [FieldOffset(0x0022)] public byte Data2_1_dir;
    [FieldOffset(0x0023)] public byte Data2_1_y;
    [FieldOffset(0x0024)] public byte Data2_2_no;
    [FieldOffset(0x0025)] public byte Data2_2_dir;
    [FieldOffset(0x0026)] public byte Data2_2_y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldDungeonPartsSelDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte parts01;
    [FieldOffset(0x0009)] public byte parts02;
    [FieldOffset(0x000A)] public byte parts03;
    [FieldOffset(0x000B)] public byte parts04;
    [FieldOffset(0x000C)] public byte parts05;
    [FieldOffset(0x000D)] public byte parts06;
    [FieldOffset(0x000E)] public byte parts07;
    [FieldOffset(0x000F)] public byte parts08;
    [FieldOffset(0x0010)] public uint primBit01;
    [FieldOffset(0x0014)] public uint primBit02;
    [FieldOffset(0x0018)] public uint primBit03;
    [FieldOffset(0x001C)] public uint scndBit01;
    [FieldOffset(0x0020)] public uint scndBit02;
    [FieldOffset(0x0024)] public uint scndBit03;
    [FieldOffset(0x0028)] public byte primNum;
    [FieldOffset(0x0029)] public byte room;
    [FieldOffset(0x002A)] public byte roomMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FFldEnemyFootprint
{
    [FieldOffset(0x0000)] public float Length;
    [FieldOffset(0x0004)] public float Scale;
    [FieldOffset(0x0008)] public FVector BeforLocation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFldHitInfo
{
    [FieldOffset(0x0000)] public int mArcanaID;
    [FieldOffset(0x0004)] public int mCmmLevel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFldHitNameTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FString flag;
    [FieldOffset(0x0028)] public FString Name2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FFldLoadCrowdLevelDays
{
    [FieldOffset(0x0000)] public int StartMonth;
    [FieldOffset(0x0004)] public int StartDay;
    [FieldOffset(0x0008)] public int EndMonth;
    [FieldOffset(0x000C)] public int EndDay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FFldLoadCrowdLevel
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajor;
    [FieldOffset(0x000C)] public int FieldMinor;
    [FieldOffset(0x0010)] public int FieldPartsID;
    [FieldOffset(0x0018)] public TArray<FFldLoadCrowdLevelDays> DayDatas;
    [FieldOffset(0x0028)] public int Time;
    [FieldOffset(0x0030)] public TArray<int> OnFlags;
    [FieldOffset(0x0040)] public TArray<int> OffFlags;
    [FieldOffset(0x0050)] public int Type;
    [FieldOffset(0x0058)] public FString LevelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FFldLoadVariationLevel
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajor;
    [FieldOffset(0x000C)] public int FieldMinor;
    [FieldOffset(0x0010)] public int StartMonth;
    [FieldOffset(0x0014)] public int StartDay;
    [FieldOffset(0x0018)] public int EndMonth;
    [FieldOffset(0x001C)] public int EndDay;
    [FieldOffset(0x0020)] public int Time;
    [FieldOffset(0x0024)] public int OnFlag;
    [FieldOffset(0x0028)] public int OffFlag;
    [FieldOffset(0x0030)] public FString LevelName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FFldLoadLevelListData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajor;
    [FieldOffset(0x000C)] public int FieldMinor;
    [FieldOffset(0x0010)] public TArray<FString> Bg;
    [FieldOffset(0x0020)] public TArray<FString> Lighting_NOON;
    [FieldOffset(0x0030)] public TArray<FString> Lighting_EVENING;
    [FieldOffset(0x0040)] public TArray<FString> Lighting_NIGHT;
    [FieldOffset(0x0050)] public TArray<FString> Lighting_SHADOW;
    [FieldOffset(0x0060)] public TArray<FString> Sound;
    [FieldOffset(0x0070)] public TArray<FString> AreaChange;
    [FieldOffset(0x0080)] public TArray<FString> Hit;
    [FieldOffset(0x0090)] public TArray<FString> Hit_SHADOW;
    [FieldOffset(0x00A0)] public TArray<FString> NPC;
    [FieldOffset(0x00B0)] public TArray<FString> Npc_NOON;
    [FieldOffset(0x00C0)] public TArray<FString> Npc_EVENING;
    [FieldOffset(0x00D0)] public TArray<FString> Npc_NIGHT;
    [FieldOffset(0x00E0)] public TArray<FString> Npc_SHADOW;
    [FieldOffset(0x00F0)] public TArray<FString> Cmm_NOON;
    [FieldOffset(0x0100)] public TArray<FString> Cmm_EVENING;
    [FieldOffset(0x0110)] public TArray<FString> Cmm_NIGHT;
    [FieldOffset(0x0120)] public TArray<FString> CrowdTarget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FShadowSettingData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public float shadowBiasHigh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FShadowFieldData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int majorId;
    [FieldOffset(0x000C)] public int minorId;
    [FieldOffset(0x0010)] public FString partsId;
    [FieldOffset(0x0020)] public EShadowSettingCategory dataCategory;
    [FieldOffset(0x0028)] public TArray<FShadowSettingData> actorList;
    [FieldOffset(0x0038)] public TArray<FShadowSettingData> childComponentList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FRaytraceActorData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString actorName;
    [FieldOffset(0x0018)] public TArray<FString> materialNames;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRaytracePlanarReflectionActorData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString actorName;
    [FieldOffset(0x0018)] public int percentage;
    [FieldOffset(0x001C)] public bool highendOnly;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FRaytraceFieldData
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int minorId;
    [FieldOffset(0x000C)] public bool rayTraceEnable;
    [FieldOffset(0x0010)] public float maxRoughness;
    [FieldOffset(0x0014)] public int reflectionMaxBounces;
    [FieldOffset(0x0018)] public int reflectionShadow;
    [FieldOffset(0x001C)] public int rayTracingCulling;
    [FieldOffset(0x0020)] public int rayTracingCullingRadius;
    [FieldOffset(0x0024)] public int rayTracingCullingAngle;
    [FieldOffset(0x0028)] public int rayTracingGeometryWPOCullingRadius;
    [FieldOffset(0x0030)] public TArray<FRaytraceActorData> actorDatas;
    [FieldOffset(0x0040)] public TArray<FRaytracePlanarReflectionActorData> planarReflectionActorDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRaytraceFieldDataTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int majorId;
    [FieldOffset(0x0010)] public TArray<FRaytraceFieldData> fieldDatas;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldLmapData_CMM
{
    [FieldOffset(0x0000)] public int mArcanaID;
    [FieldOffset(0x0004)] public int mRank;
    [FieldOffset(0x0008)] public bool mReverse;
    [FieldOffset(0x0010)] public FString mName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldLmapData_NPC
{
    [FieldOffset(0x0000)] public EFldLmapData_NpcType mType;
    [FieldOffset(0x0008)] public FString mName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldLmapData_QUEST
{
    [FieldOffset(0x0000)] public EFldLmapData_QuestType mType;
    [FieldOffset(0x0008)] public FString mFlagName;
    [FieldOffset(0x0018)] public FString mDispName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FFldLmapData
{
    [FieldOffset(0x0000)] public TArray<FFldLmapData_CMM> mCmmList;
    [FieldOffset(0x0010)] public TArray<FFldLmapData_NPC> mMaleQuestList;
    [FieldOffset(0x0020)] public TArray<FFldLmapData_NPC> mDormitoryList;
    [FieldOffset(0x0030)] public TArray<FFldLmapData_NPC> mKoromaruList;
    [FieldOffset(0x0040)] public TArray<FFldLmapData_QUEST> mQuestList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFldMailOrderTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int DataIndex;
    [FieldOffset(0x000C)] public int BuyMonth;
    [FieldOffset(0x0010)] public int BuyDay;
    [FieldOffset(0x0014)] public int ReceiveMonth;
    [FieldOffset(0x0018)] public int ReceiveDay;
    [FieldOffset(0x001C)] public int ItemA_ID;
    [FieldOffset(0x0020)] public int ItemA_Num;
    [FieldOffset(0x0024)] public int OneWordMsgID;
    [FieldOffset(0x0028)] public int ItemB_ID;
    [FieldOffset(0x002C)] public int ItemB_Num;
    [FieldOffset(0x0030)] public int Price;
    [FieldOffset(0x0034)] public int ProcID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldSequenceDeleteParam
{
    [FieldOffset(0x0000)] public uint mFlag;
    [FieldOffset(0x0004)] public int mNextSequence;
    [FieldOffset(0x0008)] public TArray<FString> mLoadSubLevelList;
    [FieldOffset(0x0018)] public TArray<FString> mHideSubLevelList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FFldMiniMapData_NPC
{
    [FieldOffset(0x0000)] public EFldMiniMapType_NPC mType;
    [FieldOffset(0x0010)] public FTransform mTransform;
    [FieldOffset(0x0040)] public AActor* mCharactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FFldMiniMapData_Target
{
    [FieldOffset(0x0000)] public FTransform mTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldMiniMapData
{
    [FieldOffset(0x0000)] public TArray<FFldMiniMapData_NPC> mNpcList;
    [FieldOffset(0x0010)] public TArray<FFldMiniMapData_Target> mTargetList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FFldNpcCompPropsParam
{
    [FieldOffset(0x0000)] public int mMajorID;
    [FieldOffset(0x0004)] public int mMinorID;
    [FieldOffset(0x0010)] public FTransform mAddTransform;
    [FieldOffset(0x0040)] public bool mMotionAttached;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct FFldNpcCompTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int ModelType;
    [FieldOffset(0x000C)] public int ModelTableID;
    [FieldOffset(0x0010)] public short CharaBagON;
    [FieldOffset(0x0012)] public short CharShoesID;
    [FieldOffset(0x0014)] public short HairTexID;
    [FieldOffset(0x0016)] public short CosTexID;
    [FieldOffset(0x0018)] public short SkinColorID;
    [FieldOffset(0x001C)] public float HeightScale;
    [FieldOffset(0x0020)] public int WaitMotionID;
    [FieldOffset(0x0024)] public int SpeakMotionID;
    [FieldOffset(0x0028)] public short BreathSetting;
    [FieldOffset(0x002C)] public int PersonalMotionID;
    [FieldOffset(0x0030)] public float ToPersonalMotionTime;
    [FieldOffset(0x0034)] public float FromPersonalMotionTime;
    [FieldOffset(0x0038)] public int GoodsID_00;
    [FieldOffset(0x0040)] public FString GoodsAttachName_00;
    [FieldOffset(0x0050)] public int GoodsAttachedMotion_00;
    [FieldOffset(0x0054)] public int GoodsWaitMotionID_00;
    [FieldOffset(0x0058)] public int GoodsSpeakMotionID_00;
    [FieldOffset(0x005C)] public int GoodsID_01;
    [FieldOffset(0x0060)] public FString GoodsAttachName_01;
    [FieldOffset(0x0070)] public int GoodsAttachedMotion_01;
    [FieldOffset(0x0074)] public int GoodsWaitMotionID_01;
    [FieldOffset(0x0078)] public int GoodsSpeakMotionID_01;
    [FieldOffset(0x007C)] public int GoodsID_Onmt_00;
    [FieldOffset(0x0080)] public int OnFlag_Onmt_00;
    [FieldOffset(0x0088)] public FString AttachName_Onmt_00;
    [FieldOffset(0x0098)] public int WaitMotionID_Onmt_00;
    [FieldOffset(0x009C)] public int SpeakMotionID_Onmt_00;
    [FieldOffset(0x00A0)] public int GoodsID_Onmt_01;
    [FieldOffset(0x00A4)] public int OnFlag_Onmt_01;
    [FieldOffset(0x00A8)] public FString AttachName_Onmt_01;
    [FieldOffset(0x00B8)] public int WaitMotionID_Onmt_01;
    [FieldOffset(0x00BC)] public int SpeakMotionID_Onmt_01;
    [FieldOffset(0x00C0)] public int GoodsID_Onmt_02;
    [FieldOffset(0x00C4)] public int OnFlag_Onmt_02;
    [FieldOffset(0x00C8)] public FString AttachName_Onmt_02;
    [FieldOffset(0x00D8)] public int WaitMotionID_Onmt_02;
    [FieldOffset(0x00DC)] public int SpeakMotionID_Onmt_02;
    [FieldOffset(0x00E0)] public int GoodsID_Onmt_03;
    [FieldOffset(0x00E4)] public int OnFlag_Onmt_03;
    [FieldOffset(0x00E8)] public FString AttachName_Onmt_03;
    [FieldOffset(0x00F8)] public int WaitMotionID_Onmt_03;
    [FieldOffset(0x00FC)] public int SpeakMotionID_Onmt_03;
    [FieldOffset(0x0100)] public int GoodsID_Onmt_04;
    [FieldOffset(0x0104)] public int OnFlag_Onmt_04;
    [FieldOffset(0x0108)] public FString AttachName_Onmt_04;
    [FieldOffset(0x0118)] public int WaitMotionID_Onmt_04;
    [FieldOffset(0x011C)] public int SpeakMotionID_Onmt_04;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FFldNpcLayoutData
{
    [FieldOffset(0x0000)] public int mMajorID;
    [FieldOffset(0x0004)] public int mMinorID;
    [FieldOffset(0x0008)] public int mFieldPartsID;
    [FieldOffset(0x000C)] public EFldNpcActorType mType;
    [FieldOffset(0x000D)] public EFldHitCharaIconType mIconType;
    [FieldOffset(0x0010)] public TArray<FFldHitCharaIconParam> mChangeIcons;
    [FieldOffset(0x0020)] public int mNameIndex;
    [FieldOffset(0x0024)] public FName mOnFlagName;
    [FieldOffset(0x002C)] public FName mOffFlagName;
    [FieldOffset(0x0038)] public TArray<FTransform> mCharaTrans;
    [FieldOffset(0x0050)] public FTransform mIconTran;
    [FieldOffset(0x0080)] public bool bNotMapInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldNpcLayoutList
{
    [FieldOffset(0x0000)] public int mFieldMajor;
    [FieldOffset(0x0004)] public int mFieldMinor;
    [FieldOffset(0x0008)] public int mTimeType;
    [FieldOffset(0x000C)] public int mKeyfreeEventID;
    [FieldOffset(0x0010)] public TArray<FFldNpcLayoutData> mDataList;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct FFldNpcLayoutTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajor;
    [FieldOffset(0x000C)] public int FieldMinor;
    [FieldOffset(0x0010)] public int FieldParts;
    [FieldOffset(0x0014)] public int TimeType;
    [FieldOffset(0x0018)] public int KeyfreeEventID;
    [FieldOffset(0x001C)] public int majorId;
    [FieldOffset(0x0020)] public int minorId;
    [FieldOffset(0x0024)] public EFldNpcActorType Type;
    [FieldOffset(0x0025)] public EFldHitCharaIconType IconType;
    [FieldOffset(0x0028)] public TArray<FFldHitCharaIconParam> ChangeIcons;
    [FieldOffset(0x0038)] public int NameIndex;
    [FieldOffset(0x003C)] public FName OnFlagName;
    [FieldOffset(0x0044)] public FName OffFlagName;
    [FieldOffset(0x0050)] public TArray<FTransform> CharaTrans;
    [FieldOffset(0x0060)] public FTransform IconTran;
    [FieldOffset(0x0090)] public bool NotMapInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FFldNpcNameTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public FString flag;
    [FieldOffset(0x0028)] public FString Name2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FFldPersonalMotionTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int OnFlag;
    [FieldOffset(0x000C)] public int OffFlag;
    [FieldOffset(0x0010)] public int MotionID;
    [FieldOffset(0x0014)] public int IsBag;
    [FieldOffset(0x0018)] public TArray<FFldPmtCostumeDataCore> DailyCostumes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldPlaceNameNameTableRowBase
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Index;
    [FieldOffset(0x0010)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6)] 
public unsafe struct FFldPlayerCostumeData
{
    [FieldOffset(0x0000)] public short CostumeType;
    [FieldOffset(0x0002)] public short BagType;
    [FieldOffset(0x0004)] public short ShoesID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldPlayerCostumeTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FFldPlayerCostumeData Data_DAY;
    [FieldOffset(0x000E)] public FFldPlayerCostumeData Data_AFTER;
    [FieldOffset(0x0014)] public FFldPlayerCostumeData Data_NIGHT;
    [FieldOffset(0x001A)] public FFldPlayerCostumeData Data_NIGHT_H;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldPoolParts
{
    [FieldOffset(0x0000)] public int FieldMajor;
    [FieldOffset(0x0004)] public int FieldMinor;
    [FieldOffset(0x0008)] public int PrevLoad;
    [FieldOffset(0x000C)] public int Noon;
    [FieldOffset(0x0010)] public int Night;
    [FieldOffset(0x0014)] public int Holiday;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldPoolConnectTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FFldPoolParts> Access;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldPoolPackTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public TArray<FFldPoolParts> PartsList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldShortcutNameTableRowBase
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Index;
    [FieldOffset(0x0010)] public FString Name;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFldSortieMemberTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int flag;
    [FieldOffset(0x0010)] public TArray<int> Enables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldTemporalAATableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int FieldMajorID;
    [FieldOffset(0x000C)] public int FieldMinorID;
    [FieldOffset(0x0010)] public int SamplesValue;
    [FieldOffset(0x0014)] public float FrameWeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FFldTvProgramTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int ObjIndex;
    [FieldOffset(0x000C)] public int MotionID;
    [FieldOffset(0x0010)] public int ProcID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGenSelListElementInterface
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGenSelListItemElement
{
    [FieldOffset(0x0000)] public FGenSelListElementInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGenSelListMsgElement
{
    [FieldOffset(0x0000)] public FGenSelListElementInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGenSelListShopElement
{
    [FieldOffset(0x0000)] public FGenSelListMsgElement baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGlobalGameDataInheritanceTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public short Type;
    [FieldOffset(0x000C)] public int Parameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGWFlagType
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public uint Value;
    [FieldOffset(0x000C)] public uint Offset;
    [FieldOffset(0x0010)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFootIKTraceResult
{
    [FieldOffset(0x0000)] public bool bResultHit;
    [FieldOffset(0x0004)] public FVector HitLocation;
    [FieldOffset(0x0010)] public float Offset;
    [FieldOffset(0x0014)] public FRotator FootRotation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FSelData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FStaffRollOneLineData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FStaffRollText
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FLocalizeStaffRollStruct
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name1;
    [FieldOffset(0x0018)] public FString Name2;
    [FieldOffset(0x0028)] public FString Name3;
    [FieldOffset(0x0038)] public int Tag;
    [FieldOffset(0x003C)] public int NameNum;
    [FieldOffset(0x0040)] public int SprID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FUIMailAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public FVector2D StartPos;
    [FieldOffset(0x0014)] public FVector2D EndPos;
    [FieldOffset(0x001C)] public FColor StartColor;
    [FieldOffset(0x0020)] public FColor EndColor;
    [FieldOffset(0x0024)] public float StartAngle;
    [FieldOffset(0x0028)] public float EndAngle;
    [FieldOffset(0x002C)] public float StartValue;
    [FieldOffset(0x0030)] public float EndValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtAdxSoundFadeSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtAdxSoundFadeSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtAdxSoundManageSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtAdxSoundManageSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtAdxSoundSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtAdxSoundSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneEvtCharaAnimationParams
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* AnimationAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FMovieSceneEvtCharaAnimationParameters
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneEvtCharaAnimationSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaAnimationSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00AC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtCharaHandwritingSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaHandwritingSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneEvtCharaOperationControllerSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaOperationControllerSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00AC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtCharaPackAnimationSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaPackAnimationSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FMovieSceneEvtCharaPackFaceAnimationParams
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* AnimationAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneEvtCharaPackFaceAnimationSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaPackFaceAnimationSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00AC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtCharaPropAttachSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtCharaPropAttachSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FMovieSceneEvtDialogueOptionsSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtDialogueOptionsSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtDialogueSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtDialogueSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtFadeScreenSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtFadeScreenSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtFieldAnimationSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtFieldAnimationSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtMessageSubtitleSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtMessageSubtitleSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtMovieTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtMovieSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE8)] 
public unsafe struct FMovieSceneEvtScriptSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtScriptSectionData EventData;
    [FieldOffset(0x00A8)] public TArray<FMovieSceneObjectBindingID> EventReceivers;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00B8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00BC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneEvtSeqControllerSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtSeqControllerSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00AC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct FMovieSceneEvtSeqTimeJumpControllerSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneEvalTemplate baseObj;
    [FieldOffset(0x0020)] public FMovieSceneEvtSeqTimeJumpControllerSectionData EventData;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenForwards;
    [FieldOffset(0x00A8)] public byte bFireEventsWhenBackwards;
    [FieldOffset(0x00AC)] public FMovieSceneEvtConditionalBranchData CondBranchData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNameNumberPairTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public int Number;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FSaveLoadAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public FVector2D StartPos;
    [FieldOffset(0x0014)] public FVector2D EndPos;
    [FieldOffset(0x001C)] public FColor StartColor;
    [FieldOffset(0x0020)] public FColor EndColor;
    [FieldOffset(0x0024)] public float StartAngle;
    [FieldOffset(0x0028)] public float EndAngle;
    [FieldOffset(0x002C)] public float StartValue;
    [FieldOffset(0x0030)] public float EndValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSoundAppFieldControlBlock
{
    [FieldOffset(0x0000)] public bool mIsSetup;
    [FieldOffset(0x0004)] public int mReadBank;
    [FieldOffset(0x0008)] public EPlayerType mPlayerType;
    [FieldOffset(0x000C)] public int mPlayerNum;
    [FieldOffset(0x0010)] public FString mFileName;
    [FieldOffset(0x0020)] public uint mRestartFlags;
    [FieldOffset(0x0028)] public TArray<int> mRestartQueIds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FStaffRollTables
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString FirstColumnName;
    [FieldOffset(0x0018)] public FString SecondColumnName;
    [FieldOffset(0x0028)] public FString ThirdColumnName;
    [FieldOffset(0x0038)] public FString ForthColumnName;
    [FieldOffset(0x0048)] public FString Ficolor;
    [FieldOffset(0x0058)] public FString Scolor;
    [FieldOffset(0x0068)] public FString Tcolor;
    [FieldOffset(0x0078)] public FString Focolor;
    [FieldOffset(0x0088)] public FString Fistyle;
    [FieldOffset(0x0098)] public FString Sstyle;
    [FieldOffset(0x00A8)] public FString Tstyle;
    [FieldOffset(0x00B8)] public FString Fostyle;
    [FieldOffset(0x00C8)] public FString Fisize;
    [FieldOffset(0x00D8)] public FString Ssize;
    [FieldOffset(0x00E8)] public FString Tsize;
    [FieldOffset(0x00F8)] public FString Fosize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FTitleSelectListTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int StretchFrame;
    [FieldOffset(0x000C)] public int ShrinkFrame;
    [FieldOffset(0x0010)] public int ShrinkWaitFrame;
    [FieldOffset(0x0014)] public int TextInAnimAddWaitFrame;
    [FieldOffset(0x0018)] public int BlurPlateAddWidth;
    [FieldOffset(0x001C)] public int WaitMaskAnimFrame;
    [FieldOffset(0x0020)] public int ItemCountWaitFrame;
    [FieldOffset(0x0024)] public int CursorMoveFrame;
    [FieldOffset(0x0028)] public int StretchFrame_Diff;
    [FieldOffset(0x002C)] public int ShrinkFrame_Diff;
    [FieldOffset(0x0030)] public int ShrinkWaitFrame_Diff;
    [FieldOffset(0x0034)] public int TextInAnimAddWaitFrame_Diff;
    [FieldOffset(0x0038)] public int BlurPlateAddWidth_Diff;
    [FieldOffset(0x003C)] public int WaitMaskAnimFrame_Diff;
    [FieldOffset(0x0040)] public int ItemCountWaitFrame_Diff;
    [FieldOffset(0x0044)] public int CursorMoveFrame_Diff;
    [FieldOffset(0x0048)] public int NAKAMI_IN_OK_MASK_FRAME;
    [FieldOffset(0x004C)] public int NAKAMI_OUT_OK_MASK_FRAME;
    [FieldOffset(0x0050)] public int NAKAMI_IN_RECT_ANIM_FRAME;
    [FieldOffset(0x0054)] public int NAKAMI_WAIT_OUT_OK_FRAME;
    [FieldOffset(0x0058)] public int NAKAMI_LOOP_PLAY_WAIT_FRAME;
    [FieldOffset(0x005C)] public int NAKAMI_IN_OK_MASK_FRAME_Diff;
    [FieldOffset(0x0060)] public int NAKAMI_OUT_OK_MASK_FRAME_Diff;
    [FieldOffset(0x0064)] public int NAKAMI_IN_RECT_ANIM_FRAME_Diff;
    [FieldOffset(0x0068)] public int NAKAMI_WAIT_OUT_OK_FRAME_Diff;
    [FieldOffset(0x006C)] public int NAKAMI_LOOP_PLAY_WAIT_FRAME_Diff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FTitleUITableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int LogoFadeInFrame;
    [FieldOffset(0x000C)] public int LogoAtlusCrossFadeFrame;
    [FieldOffset(0x0010)] public int LogoAtlusWaitFrame;
    [FieldOffset(0x0014)] public int LogoMaskOutFrame;
    [FieldOffset(0x0018)] public float LogoAtlusVisibleTime;
    [FieldOffset(0x001C)] public float LogoVisibleTime;
    [FieldOffset(0x0020)] public int CautionFadeInFrame;
    [FieldOffset(0x0024)] public int CautionVisibleFrame;
    [FieldOffset(0x0028)] public int CautionFadeOutFrame;
    [FieldOffset(0x002C)] public int PressAnyButtonVisibleFrame;
    [FieldOffset(0x0030)] public int PressAnyButtonWaitAnimFrame;
    [FieldOffset(0x0034)] public int PressAnyButtonSpeedFrame;
    [FieldOffset(0x0038)] public int CopyLightAndLogoVisibleWaitFrame;
    [FieldOffset(0x003C)] public int CopyLightAndLogoSpeedFrame;
    [FieldOffset(0x0040)] public int PressAnyUICloseFrame;
    [FieldOffset(0x0044)] public int SelectListAnimWaitFrame;
    [FieldOffset(0x0048)] public int TitleSelectListRootX;
    [FieldOffset(0x004C)] public int TitleSelectListRootY;
    [FieldOffset(0x0050)] public float PressWaitTimeout;
    [FieldOffset(0x0054)] public float SelectTimeout;
    [FieldOffset(0x0058)] public float LogoAtlusWidthM;
    [FieldOffset(0x005C)] public float LogoAtlusHeightM;
    [FieldOffset(0x0060)] public float Logo2ProWidthM;
    [FieldOffset(0x0064)] public float Logo2ProHeightM;
    [FieldOffset(0x0068)] public float LogoUe4WidthM;
    [FieldOffset(0x006C)] public float LogoUe4HeightM;
    [FieldOffset(0x0070)] public bool LogoCloseAnimDEC;
    [FieldOffset(0x0074)] public float CautionSkipWaitTime;
    [FieldOffset(0x0078)] public float PleaseWaitFadeInWaitTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FTutorialSortTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int SortID;
    [FieldOffset(0x0010)] public TArray<FName> TextureNames;
    [FieldOffset(0x0020)] public FName OpenFlagName;
    [FieldOffset(0x0028)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FUIAccessInfoLayoutParam
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public EAccessInfoCarNoDisplayType CarNoDisplayType;
    [FieldOffset(0x0009)] public EAccessInfoPlaceNameWidthType PlaceNameWidthType;
    [FieldOffset(0x000C)] public float FixedCharacterWidth;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimeWork_t
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FUICmpCalendarDrawStringItem
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName String;
    [FieldOffset(0x0010)] public FName Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FUICmpCalendarDrawEditParameterItem
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Frame;
    [FieldOffset(0x0010)] public FText Comment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FConfigAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public FVector2D StartPos;
    [FieldOffset(0x0014)] public FVector2D EndPos;
    [FieldOffset(0x001C)] public FColor StartColor;
    [FieldOffset(0x0020)] public FColor EndColor;
    [FieldOffset(0x0024)] public float StartAngle;
    [FieldOffset(0x0028)] public float EndAngle;
    [FieldOffset(0x002C)] public float StartValue;
    [FieldOffset(0x0030)] public float EndValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FBustupPoseOffset
{
    [FieldOffset(0x0000)] public TMap<FString, FBustupParts> PoseOffsets;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FUIDungeonTransferCloudPreset
{
    [FieldOffset(0x0000)] public int SprNo;
    [FieldOffset(0x0004)] public float Speed;
    [FieldOffset(0x0008)] public EUIDungeonTransferCloudDrawMode DrawMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FUIDungeonTransferCloudSetPos
{
    [FieldOffset(0x0000)] public FVector Pos;
    [FieldOffset(0x000C)] public FVector Color;
    [FieldOffset(0x0018)] public float Alpha;
    [FieldOffset(0x001C)] public FVector Scale;
    [FieldOffset(0x0028)] public int PresetNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FDungeonTransferPosAssist
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector FloorListEntrancePosDif;
    [FieldOffset(0x0014)] public FVector InfoMissExclamationColorRed;
    [FieldOffset(0x0020)] public FVector InfoMissExclamationRedPosdef;
    [FieldOffset(0x002C)] public float InfoMissExclamationRedRotation;
    [FieldOffset(0x0030)] public int InfoMissExclamationFrameMove;
    [FieldOffset(0x0038)] public TArray<FUIDungeonTransferHazeParam> HazeParam;
    [FieldOffset(0x0048)] public float HazeAppearVanishRarion;
    [FieldOffset(0x004C)] public float HazeNum;
    [FieldOffset(0x0050)] public float HazeInitRMin;
    [FieldOffset(0x0054)] public float HazeInitRMax;
    [FieldOffset(0x0058)] public TArray<FUIDungeonTransferCloudPreset> CloudPreset;
    [FieldOffset(0x0068)] public TArray<FUIDungeonTransferCloudSetPos> CloudParam;
    [FieldOffset(0x0078)] public TArray<float> CloudAllPos;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGenSelDrawInfo
{
    [FieldOffset(0x0000)] public UGenericSelectSystemBase* System;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8C8)] 
public unsafe struct FCommunityPointDraw
{
    [FieldOffset(0x0008)] public FPointUpNote tagNote;
    [FieldOffset(0x08A8)] public UNiagaraComponent* pRankUpEffectComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FItemGetTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int OutWaitFrame;
    [FieldOffset(0x000C)] public int MaruPekeBounceFrame;
    [FieldOffset(0x0010)] public int Param1;
    [FieldOffset(0x0014)] public int Param2;
    [FieldOffset(0x0018)] public int param3;
    [FieldOffset(0x001C)] public int param4;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSpecialKeyHelpTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int IN_OK_MASK_FRAME;
    [FieldOffset(0x000C)] public int OUT_OK_MASK_FRAME;
    [FieldOffset(0x0010)] public int IN_RECT_ANIM_FRAME;
    [FieldOffset(0x0014)] public int WAIT_OUT_OK_FRAME;
    [FieldOffset(0x0018)] public int FADE_IN_FRAME;
    [FieldOffset(0x001C)] public int FADE_OUT_FRAME;
    [FieldOffset(0x0020)] public int MARU_PEKE_BOUNCE_FRAME;
    [FieldOffset(0x0024)] public int NEXT_ANIM_FRAME;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSupportPartyPanelTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int InFrame;
    [FieldOffset(0x000C)] public int OutFrame;
    [FieldOffset(0x0010)] public int WaveFrame;
    [FieldOffset(0x0014)] public int Param1;
    [FieldOffset(0x0018)] public int Param2;
    [FieldOffset(0x001C)] public int param3;
    [FieldOffset(0x0020)] public int param4;
    [FieldOffset(0x0024)] public int param5;
    [FieldOffset(0x0028)] public int param6;
    [FieldOffset(0x002C)] public int param7;
    [FieldOffset(0x0030)] public int param8;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FUINameEntryAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public FVector2D StartPos;
    [FieldOffset(0x0014)] public FVector2D EndPos;
    [FieldOffset(0x001C)] public FColor StartColor;
    [FieldOffset(0x0020)] public FColor EndColor;
    [FieldOffset(0x0024)] public float StartAngle;
    [FieldOffset(0x0028)] public float EndAngle;
    [FieldOffset(0x002C)] public float StartValue;
    [FieldOffset(0x0030)] public float EndValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FRequestParamTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int InFrame;
    [FieldOffset(0x000C)] public int OutFrame;
    [FieldOffset(0x0010)] public int DetailInFrame;
    [FieldOffset(0x0014)] public int DetailOutFrame;
    [FieldOffset(0x0018)] public int ListInFrame;
    [FieldOffset(0x001C)] public int ListOutFrame;
    [FieldOffset(0x0020)] public int AllCampFirstInWaitFrame;
    [FieldOffset(0x0024)] public int AllElizFirstInWaitFrame;
    [FieldOffset(0x0028)] public int ListFirstInWaitFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FHiddenArbeitTableItem
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int Month;
    [FieldOffset(0x000C)] public int Day;
    [FieldOffset(0x0010)] public EArbeitOrderableTime TimeZone;
    [FieldOffset(0x0011)] public bool Visibility;
    [FieldOffset(0x0018)] public FString EnableFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FArbeitInfoTableItem
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName DefineName;
    [FieldOffset(0x0010)] public FName Name;
    [FieldOffset(0x0018)] public FString HelpMSGLabel;
    [FieldOffset(0x0028)] public bool Afternoon;
    [FieldOffset(0x0029)] public bool Evening;
    [FieldOffset(0x002A)] public bool Sun;
    [FieldOffset(0x002B)] public bool Mon;
    [FieldOffset(0x002C)] public bool Tue;
    [FieldOffset(0x002D)] public bool Wed;
    [FieldOffset(0x002E)] public bool Thu;
    [FieldOffset(0x002F)] public bool Fri;
    [FieldOffset(0x0030)] public bool Sat;
    [FieldOffset(0x0038)] public FString UnlockFLG;
    [FieldOffset(0x0048)] public FString UnlockDayCNT;
    [FieldOffset(0x0058)] public FString HiddenFLG;
    [FieldOffset(0x0068)] public bool HolidayWork;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGenSelItemLineupTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString ItemId;
    [FieldOffset(0x0018)] public FString VisibleFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FGenSelItemDefineTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int DefineValue;
    [FieldOffset(0x0010)] public FString DefineName;
    [FieldOffset(0x0020)] public FString TitleText;
    [FieldOffset(0x0030)] public FString CommentText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FCmmProfileTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString PCID;
    [FieldOffset(0x0018)] public uint DisappearID;
    [FieldOffset(0x0020)] public FString NameMsgLabel;
    [FieldOffset(0x0030)] public FString ProfileMsgLabel;
    [FieldOffset(0x0040)] public FString ProfileMsgLabel_Reverse;
    [FieldOffset(0x0050)] public FString ProfileMsgLabel_Missing;
    [FieldOffset(0x0060)] public FString ProfileMsgLabel_Lost;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FVelvetRoomQuestTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort OpenNo_1;
    [FieldOffset(0x000A)] public ushort OpenNo_2;
    [FieldOffset(0x000C)] public ushort OpenNo_3;
    [FieldOffset(0x000E)] public byte StartMonth;
    [FieldOffset(0x000F)] public byte StartDay;
    [FieldOffset(0x0010)] public byte EndMonth;
    [FieldOffset(0x0011)] public byte EndDay;
    [FieldOffset(0x0014)] public uint OpenFlag;
    [FieldOffset(0x0018)] public uint ReceivedFlag;
    [FieldOffset(0x001C)] public uint EndFlag;
    [FieldOffset(0x0020)] public byte Rank;
    [FieldOffset(0x0021)] public byte RequestType;
    [FieldOffset(0x0022)] public byte PersonaType;
    [FieldOffset(0x0024)] public uint ID;
    [FieldOffset(0x0028)] public uint Value;
    [FieldOffset(0x002C)] public byte OPTION;
    [FieldOffset(0x002E)] public ushort RewardItemID;
    [FieldOffset(0x0030)] public ushort RewardItemNum;
    [FieldOffset(0x0034)] public uint RewardMoney;
    [FieldOffset(0x0038)] public uint InfoDisplay;
    [FieldOffset(0x003C)] public uint OrderTalkID;
    [FieldOffset(0x0040)] public uint QuestIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCombineMiscTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public float AccidentBaseRate;
    [FieldOffset(0x000C)] public float FoolAccidentRate;
    [FieldOffset(0x0010)] public short AccidentMinLv;
    [FieldOffset(0x0012)] public short AccidentMaxLv;
    [FieldOffset(0x0014)] public float SkillChangeBaseRate;
    [FieldOffset(0x0018)] public float SkillBuildUpRate;
    [FieldOffset(0x001C)] public float SkillChange1;
    [FieldOffset(0x0020)] public float SkillChange2;
    [FieldOffset(0x0024)] public float SkillChange3;
    [FieldOffset(0x0028)] public float SkillWeight2Down;
    [FieldOffset(0x002C)] public float SkillWeight1Down;
    [FieldOffset(0x0030)] public float SkillWeightEven;
    [FieldOffset(0x0034)] public float SkillWeight1Up;
    [FieldOffset(0x0038)] public float SkillWeight2Up;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkillPowerUpTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort OldSkill;
    [FieldOffset(0x000A)] public ushort NewSkill;
    [FieldOffset(0x000C)] public ushort LevelLimit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FSkillPackTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Rank_1;
    [FieldOffset(0x000A)] public ushort Skill_1;
    [FieldOffset(0x000C)] public ushort Weight_1;
    [FieldOffset(0x000E)] public ushort Rank_2;
    [FieldOffset(0x0010)] public ushort Skill_2;
    [FieldOffset(0x0012)] public ushort Weight_2;
    [FieldOffset(0x0014)] public ushort Rank_3;
    [FieldOffset(0x0016)] public ushort Skill_3;
    [FieldOffset(0x0018)] public ushort Weight_3;
    [FieldOffset(0x001A)] public ushort Rank_4;
    [FieldOffset(0x001C)] public ushort Skill_4;
    [FieldOffset(0x001E)] public ushort Weight_4;
    [FieldOffset(0x0020)] public ushort Rank_5;
    [FieldOffset(0x0022)] public ushort Skill_5;
    [FieldOffset(0x0024)] public ushort Weight_5;
    [FieldOffset(0x0026)] public ushort Rank_6;
    [FieldOffset(0x0028)] public ushort Skill_6;
    [FieldOffset(0x002A)] public ushort Weight_6;
    [FieldOffset(0x002C)] public ushort Rank_7;
    [FieldOffset(0x002E)] public ushort Skill_7;
    [FieldOffset(0x0030)] public ushort Weight_7;
    [FieldOffset(0x0032)] public ushort Rank_8;
    [FieldOffset(0x0034)] public ushort Skill_8;
    [FieldOffset(0x0036)] public ushort Weight_8;
    [FieldOffset(0x0038)] public ushort Rank_9;
    [FieldOffset(0x003A)] public ushort Skill_9;
    [FieldOffset(0x003C)] public ushort Weight_9;
    [FieldOffset(0x003E)] public ushort Rank_10;
    [FieldOffset(0x0040)] public ushort Skill_10;
    [FieldOffset(0x0042)] public ushort Weight_10;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkillChangeTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SkillPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCombineCounterTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Num;
    [FieldOffset(0x000A)] public ushort ConceptionRate;
    [FieldOffset(0x000C)] public ushort SkillChangeRate;
    [FieldOffset(0x000E)] public ushort AccidentRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMoonAgeProbabilityTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort ConceptionRate;
    [FieldOffset(0x000A)] public ushort SkillChangeRate;
    [FieldOffset(0x000C)] public ushort AccidentRate;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCommunityRankTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Bonus;
    [FieldOffset(0x000A)] public ushort HighBonus;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPersonaConfigTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString BirthMsg;
    [FieldOffset(0x0018)] public FString ToneType;
    [FieldOffset(0x0028)] public FString VoicePack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkillLimitTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte TotalSkillNum;
    [FieldOffset(0x0009)] public byte InheritanceSkillNum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSkillAffinityTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte Slash;
    [FieldOffset(0x0008)] public byte strike;
    [FieldOffset(0x0008)] public byte pierce;
    [FieldOffset(0x0008)] public byte fire;
    [FieldOffset(0x0008)] public byte ice;
    [FieldOffset(0x0008)] public byte electric;
    [FieldOffset(0x0008)] public byte wind;
    [FieldOffset(0x0008)] public byte almighty;
    [FieldOffset(0x0009)] public byte Light;
    [FieldOffset(0x0009)] public byte dark;
    [FieldOffset(0x0009)] public byte charm;
    [FieldOffset(0x0009)] public byte poison;
    [FieldOffset(0x0009)] public byte upset;
    [FieldOffset(0x0009)] public byte panic;
    [FieldOffset(0x0009)] public byte fear;
    [FieldOffset(0x0009)] public byte anger;
    [FieldOffset(0x000A)] public byte recovery;
    [FieldOffset(0x000A)] public byte support;
    [FieldOffset(0x000A)] public byte Special;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPersonaLiftTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000C)] public uint OrFlag;
    [FieldOffset(0x0010)] public uint AndFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSpecialSpreadTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort MatPerVal_1;
    [FieldOffset(0x000C)] public ushort MatPerVal_2;
    [FieldOffset(0x000E)] public ushort MatPerVal_3;
    [FieldOffset(0x0010)] public ushort MatPerVal_4;
    [FieldOffset(0x0012)] public ushort MatPerVal_5;
    [FieldOffset(0x0014)] public ushort MatPerVal_6;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNormalSpreadTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte FOOL;
    [FieldOffset(0x0009)] public byte MAGICIA;
    [FieldOffset(0x000A)] public byte PRIESTE;
    [FieldOffset(0x000B)] public byte EMPRESS;
    [FieldOffset(0x000C)] public byte EMPEROR;
    [FieldOffset(0x000D)] public byte HIEROPH;
    [FieldOffset(0x000E)] public byte LOVERS;
    [FieldOffset(0x000F)] public byte CHARIOT;
    [FieldOffset(0x0010)] public byte JUSTICE;
    [FieldOffset(0x0011)] public byte HERMIT;
    [FieldOffset(0x0012)] public byte FORTUNE;
    [FieldOffset(0x0013)] public byte STRENGT;
    [FieldOffset(0x0014)] public byte HANGEDM;
    [FieldOffset(0x0015)] public byte Death;
    [FieldOffset(0x0016)] public byte TEMPERA;
    [FieldOffset(0x0017)] public byte DEVIL;
    [FieldOffset(0x0018)] public byte TOWER;
    [FieldOffset(0x0019)] public byte STAR;
    [FieldOffset(0x001A)] public byte MOON;
    [FieldOffset(0x001B)] public byte Sun;
    [FieldOffset(0x001C)] public byte JUDGEME;
    [FieldOffset(0x001D)] public byte World;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FDisappearTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort DisappearID;
    [FieldOffset(0x000A)] public byte StartMonth;
    [FieldOffset(0x000B)] public byte StartDays;
    [FieldOffset(0x000C)] public byte LimitMonth;
    [FieldOffset(0x000D)] public byte LimitDays;
    [FieldOffset(0x0010)] public FString ActiveFlag;
    [FieldOffset(0x0020)] public FString SuccessFlag;
    [FieldOffset(0x0030)] public FString FailedFlag;
    [FieldOffset(0x0040)] public FString NpcFlag;
    [FieldOffset(0x0050)] public FString InfoOnFlag;
    [FieldOffset(0x0060)] public FString AwardFlag;
    [FieldOffset(0x0070)] public ushort AwardItemID;
    [FieldOffset(0x0072)] public ushort AwardItemNum;
    [FieldOffset(0x0074)] public uint AwardMoney;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FMailIncomingTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort MailID;
    [FieldOffset(0x000A)] public ushort SenderID;
    [FieldOffset(0x000C)] public ushort Group;
    [FieldOffset(0x000E)] public byte Category;
    [FieldOffset(0x000F)] public byte StartMonth;
    [FieldOffset(0x0010)] public byte StartDays;
    [FieldOffset(0x0011)] public byte EndMonth;
    [FieldOffset(0x0012)] public byte EndDays;
    [FieldOffset(0x0013)] public byte ReceiveTime;
    [FieldOffset(0x0014)] public byte Sun;
    [FieldOffset(0x0014)] public byte Mon;
    [FieldOffset(0x0014)] public byte Tue;
    [FieldOffset(0x0014)] public byte Wed;
    [FieldOffset(0x0014)] public byte Thr;
    [FieldOffset(0x0014)] public byte Fri;
    [FieldOffset(0x0014)] public byte Sat;
    [FieldOffset(0x0014)] public byte Weekday;
    [FieldOffset(0x0015)] public byte Holiday;
    [FieldOffset(0x0015)] public byte RankUp;
    [FieldOffset(0x0015)] public byte OnlyOnce;
    [FieldOffset(0x0016)] public byte ArcanaID;
    [FieldOffset(0x0017)] public byte ArcanaCondition;
    [FieldOffset(0x0018)] public byte Rank;
    [FieldOffset(0x0019)] public byte InviteCounter;
    [FieldOffset(0x0020)] public FString CounterID;
    [FieldOffset(0x0030)] public byte CounterCondition;
    [FieldOffset(0x0034)] public int CounterValue;
    [FieldOffset(0x0038)] public FString MailBmdFileName;
    [FieldOffset(0x0048)] public FString SenderLabel;
    [FieldOffset(0x0058)] public FString TitleLabel;
    [FieldOffset(0x0068)] public FString BodyLabel;
    [FieldOffset(0x0078)] public FString ScriptBfFileName;
    [FieldOffset(0x0088)] public FString ScriptBmdFileName;
    [FieldOffset(0x0098)] public FString EnableFlag0;
    [FieldOffset(0x00A8)] public FString EnableFlag1;
    [FieldOffset(0x00B8)] public FString EnableFlag2;
    [FieldOffset(0x00C8)] public FString DisableFlag0;
    [FieldOffset(0x00D8)] public FString DisableFlag1;
    [FieldOffset(0x00E8)] public FString DisableFlag2;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FSupportBustupTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort CharaID;
    [FieldOffset(0x0010)] public FString Pose;
    [FieldOffset(0x0020)] public float OffsetLeft_X;
    [FieldOffset(0x0024)] public float OffsetLeft_Y;
    [FieldOffset(0x0028)] public float MaskOffsetLeft_Y;
    [FieldOffset(0x002C)] public float OffsetRight_X;
    [FieldOffset(0x0030)] public float OffsetRight_Y;
    [FieldOffset(0x0034)] public float MaskOffsetRight_Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FBustupAnimTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte Type;
    [FieldOffset(0x000C)] public ushort Frame;
    [FieldOffset(0x000E)] public ushort Random;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FBustupGradationTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public byte Environment;
    [FieldOffset(0x000C)] public float Angle;
    [FieldOffset(0x0010)] public float ShadowPosition;
    [FieldOffset(0x0014)] public float Range;
    [FieldOffset(0x0018)] public float ShadowColorR;
    [FieldOffset(0x001C)] public float ShadowColorG;
    [FieldOffset(0x0020)] public float ShadowColorB;
    [FieldOffset(0x0024)] public float ShadowColorA;
    [FieldOffset(0x0028)] public float Desaturation;
    [FieldOffset(0x002C)] public float Brightness;
    [FieldOffset(0x0030)] public byte TextureNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBustupEnvironmentTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int BGMajor;
    [FieldOffset(0x000C)] public int BGMinor;
    [FieldOffset(0x0010)] public byte EarlyMorning;
    [FieldOffset(0x0011)] public byte Morning;
    [FieldOffset(0x0012)] public byte AM;
    [FieldOffset(0x0013)] public byte Noon;
    [FieldOffset(0x0014)] public byte PM;
    [FieldOffset(0x0015)] public byte AfterSchool;
    [FieldOffset(0x0016)] public byte Night;
    [FieldOffset(0x0017)] public byte Shadow;
    [FieldOffset(0x0018)] public byte Midnight;
    [FieldOffset(0x0019)] public byte EarlyMorningHero;
    [FieldOffset(0x001A)] public byte MorningHero;
    [FieldOffset(0x001B)] public byte AMHero;
    [FieldOffset(0x001C)] public byte NoonHero;
    [FieldOffset(0x001D)] public byte PMHero;
    [FieldOffset(0x001E)] public byte AfterSchoolHero;
    [FieldOffset(0x001F)] public byte NightHero;
    [FieldOffset(0x0020)] public byte ShadowHero;
    [FieldOffset(0x0021)] public byte MidnightHero;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FBustupOffsetTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort CharaID;
    [FieldOffset(0x0010)] public FString Pose;
    [FieldOffset(0x0020)] public float EyeX;
    [FieldOffset(0x0024)] public float EyeY;
    [FieldOffset(0x0028)] public float MouthX;
    [FieldOffset(0x002C)] public float MouthY;
    [FieldOffset(0x0030)] public float BlushX;
    [FieldOffset(0x0034)] public float BlushY;
    [FieldOffset(0x0038)] public float SweatX;
    [FieldOffset(0x003C)] public float SweatY;
    [FieldOffset(0x0040)] public float OffsetX;
    [FieldOffset(0x0044)] public float OffsetY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FBustupParamTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort CharaID;
    [FieldOffset(0x000A)] public ushort FaceID;
    [FieldOffset(0x000C)] public ushort ClothID;
    [FieldOffset(0x0010)] public FString Pose;
    [FieldOffset(0x0020)] public bool EyeAnim;
    [FieldOffset(0x0021)] public bool MouthAnim;
    [FieldOffset(0x0022)] public byte InBetween;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSimpleShopTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString ItemId;
    [FieldOffset(0x0018)] public byte SellSun;
    [FieldOffset(0x0018)] public byte SellMon;
    [FieldOffset(0x0018)] public byte SellTue;
    [FieldOffset(0x0018)] public byte SellWed;
    [FieldOffset(0x0018)] public byte SellThr;
    [FieldOffset(0x0018)] public byte SellFri;
    [FieldOffset(0x0018)] public byte SellSat;
    [FieldOffset(0x0019)] public byte LiftMonth;
    [FieldOffset(0x001A)] public byte LiftDays;
    [FieldOffset(0x001B)] public byte Stock;
    [FieldOffset(0x001C)] public byte ResetSun;
    [FieldOffset(0x001C)] public byte ResetMon;
    [FieldOffset(0x001C)] public byte ResetTue;
    [FieldOffset(0x001C)] public byte ResetWed;
    [FieldOffset(0x001C)] public byte ResetThr;
    [FieldOffset(0x001C)] public byte ResetFri;
    [FieldOffset(0x001C)] public byte ResetSat;
    [FieldOffset(0x0020)] public FString OpenFlag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAntiqueShopEquipCombineResultTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort BaseItemValue;
    [FieldOffset(0x000C)] public ushort MatItemValue_1;
    [FieldOffset(0x000E)] public ushort MatItemNum_1;
    [FieldOffset(0x0010)] public ushort MatItemValue_2;
    [FieldOffset(0x0012)] public ushort MatItemNum_2;
    [FieldOffset(0x0014)] public ushort MatItemValue_3;
    [FieldOffset(0x0016)] public ushort MatItemNum_3;
    [FieldOffset(0x0018)] public ushort SaleMonth;
    [FieldOffset(0x001A)] public ushort SaleDay;
    [FieldOffset(0x001C)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAntiqueShopEquipCombineSourceTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort SaleMonth;
    [FieldOffset(0x000C)] public ushort SaleDay;
    [FieldOffset(0x0010)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAntiqueShopLineUpListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort ListType;
    [FieldOffset(0x000C)] public ushort MatItemValue_1;
    [FieldOffset(0x000E)] public ushort MatItemNum_1;
    [FieldOffset(0x0010)] public ushort MatItemValue_2;
    [FieldOffset(0x0012)] public ushort MatItemNum_2;
    [FieldOffset(0x0014)] public ushort MatItemValue_3;
    [FieldOffset(0x0016)] public ushort MatItemNum_3;
    [FieldOffset(0x0018)] public ushort SaleMonth;
    [FieldOffset(0x001A)] public ushort SaleDay;
    [FieldOffset(0x001C)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FItemShopLineUpListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort SaleMonth;
    [FieldOffset(0x000C)] public ushort SaleDay;
    [FieldOffset(0x0010)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FWeaponShopLineUpListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort Value;
    [FieldOffset(0x000A)] public ushort SaleMonth;
    [FieldOffset(0x000C)] public ushort SaleDay;
    [FieldOffset(0x0010)] public uint OpenFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FItemNameList
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString ItemName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCommonItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000A)] public ushort BtlSortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public ushort UsePlaceID;
    [FieldOffset(0x0012)] public ushort Rarity;
    [FieldOffset(0x0014)] public ushort Tier;
    [FieldOffset(0x0016)] public ushort Hp;
    [FieldOffset(0x0018)] public ushort Sp;
    [FieldOffset(0x001A)] public ushort Strength;
    [FieldOffset(0x001C)] public ushort Magic;
    [FieldOffset(0x001E)] public ushort Endurance;
    [FieldOffset(0x0020)] public ushort Agility;
    [FieldOffset(0x0022)] public ushort Luck;
    [FieldOffset(0x0024)] public ushort skillId;
    [FieldOffset(0x0028)] public uint Price;
    [FieldOffset(0x002C)] public uint SellPrice;
    [FieldOffset(0x0030)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FCostumeItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public uint EquipID;
    [FieldOffset(0x0014)] public uint Price;
    [FieldOffset(0x0018)] public uint SellPrice;
    [FieldOffset(0x001C)] public ushort GetFLG;
    [FieldOffset(0x0020)] public uint ReflectType;
    [FieldOffset(0x0024)] public ushort CostumeID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FMaterialItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public ushort Rarity;
    [FieldOffset(0x0014)] public uint Price;
    [FieldOffset(0x0018)] public uint SellPrice;
    [FieldOffset(0x001C)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEvitemItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSkillcardItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public ushort Rarity;
    [FieldOffset(0x0012)] public ushort Tier;
    [FieldOffset(0x0014)] public ushort skillId;
    [FieldOffset(0x0018)] public uint Price;
    [FieldOffset(0x001C)] public uint SellPrice;
    [FieldOffset(0x0020)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAccsItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public uint EquipID;
    [FieldOffset(0x0014)] public ushort Rarity;
    [FieldOffset(0x0016)] public ushort Tier;
    [FieldOffset(0x0018)] public ushort Strength;
    [FieldOffset(0x001A)] public ushort Magic;
    [FieldOffset(0x001C)] public ushort Endurance;
    [FieldOffset(0x001E)] public ushort Agility;
    [FieldOffset(0x0020)] public ushort Luck;
    [FieldOffset(0x0022)] public ushort skillId;
    [FieldOffset(0x0024)] public uint Price;
    [FieldOffset(0x0028)] public uint SellPrice;
    [FieldOffset(0x002C)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FShoesItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public uint EquipID;
    [FieldOffset(0x0014)] public ushort Rarity;
    [FieldOffset(0x0016)] public ushort Tier;
    [FieldOffset(0x0018)] public ushort Evasion;
    [FieldOffset(0x001A)] public ushort Strength;
    [FieldOffset(0x001C)] public ushort Magic;
    [FieldOffset(0x001E)] public ushort Endurance;
    [FieldOffset(0x0020)] public ushort Agility;
    [FieldOffset(0x0022)] public ushort Luck;
    [FieldOffset(0x0024)] public ushort skillId;
    [FieldOffset(0x0028)] public uint Price;
    [FieldOffset(0x002C)] public uint SellPrice;
    [FieldOffset(0x0030)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FArmorItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint ItemType;
    [FieldOffset(0x0010)] public uint EquipID;
    [FieldOffset(0x0014)] public ushort Rarity;
    [FieldOffset(0x0016)] public ushort Tier;
    [FieldOffset(0x0018)] public ushort Defence;
    [FieldOffset(0x001A)] public ushort Strength;
    [FieldOffset(0x001C)] public ushort Magic;
    [FieldOffset(0x001E)] public ushort Endurance;
    [FieldOffset(0x0020)] public ushort Agility;
    [FieldOffset(0x0022)] public ushort Luck;
    [FieldOffset(0x0024)] public ushort skillId;
    [FieldOffset(0x0028)] public uint Price;
    [FieldOffset(0x002C)] public uint SellPrice;
    [FieldOffset(0x0030)] public ushort GetFLG;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FWeaponItemListRecord
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public ushort SortNum;
    [FieldOffset(0x000C)] public uint WeaponType;
    [FieldOffset(0x0010)] public uint EquipID;
    [FieldOffset(0x0014)] public ushort AttrID;
    [FieldOffset(0x0016)] public ushort Rarity;
    [FieldOffset(0x0018)] public ushort Tier;
    [FieldOffset(0x001A)] public ushort attack;
    [FieldOffset(0x001C)] public ushort Accuracy;
    [FieldOffset(0x001E)] public ushort Strength;
    [FieldOffset(0x0020)] public ushort Magic;
    [FieldOffset(0x0022)] public ushort Endurance;
    [FieldOffset(0x0024)] public ushort Agility;
    [FieldOffset(0x0026)] public ushort Luck;
    [FieldOffset(0x0028)] public ushort skillId;
    [FieldOffset(0x002C)] public uint Price;
    [FieldOffset(0x0030)] public uint SellPrice;
    [FieldOffset(0x0034)] public ushort GetFLG;
    [FieldOffset(0x0036)] public ushort ModelID;
    [FieldOffset(0x0038)] public uint flags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FTheurgiaUITableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public int InFrame;
    [FieldOffset(0x000C)] public int OutFrame;
    [FieldOffset(0x0010)] public int Param1;
    [FieldOffset(0x0014)] public int Param2;
    [FieldOffset(0x0018)] public int param3;
    [FieldOffset(0x001C)] public int param4;
    [FieldOffset(0x0020)] public int NewAddX;
    [FieldOffset(0x0024)] public int NewAddY;
    [FieldOffset(0x0028)] public int SelectNewAddX;
    [FieldOffset(0x002C)] public int SelectNewAddY;
    [FieldOffset(0x0030)] public int SkillInfo_ItiretugotonoX;
    [FieldOffset(0x0034)] public int SkillInfo_ItiretugotonoY;
    [FieldOffset(0x0038)] public int OKmadenoFrame;
    [FieldOffset(0x003C)] public int NextkaraOKmadenoFrame;
    [FieldOffset(0x0040)] public float AddAllAngle;
    [FieldOffset(0x0044)] public float AddStatusKeyHelpAngle;
    [FieldOffset(0x0048)] public float AddNEWAngle;
    [FieldOffset(0x004C)] public int ChangeSkillArrowAnimFrame;
    [FieldOffset(0x0050)] public float SkillGetAntenTime;
    [FieldOffset(0x0054)] public float PassiveSkillPersonalityStartWaitTime;
    [FieldOffset(0x0058)] public int GetSkillCardWaitFrame;
    [FieldOffset(0x005C)] public float SkillGetMoveCursorWaitTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct FTimeChangeUITableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector AddNextBlueBandPos_1;
    [FieldOffset(0x0014)] public float AddNextBlueBandAngle_1;
    [FieldOffset(0x0018)] public FVector AddNextBlueBandAnglePoint_1;
    [FieldOffset(0x0024)] public FVector AddNextTimePos_1;
    [FieldOffset(0x0030)] public FVector AddNextSecondHandPos_1;
    [FieldOffset(0x003C)] public float AddNextSecondHandAngle_1;
    [FieldOffset(0x0040)] public FVector AddNextBlueBandPos_2;
    [FieldOffset(0x004C)] public float AddNextBlueBandAngle_2;
    [FieldOffset(0x0050)] public FVector AddNextBlueBandAnglePoint_2;
    [FieldOffset(0x005C)] public FVector AddNextTimePos_2;
    [FieldOffset(0x0068)] public FVector AddNextSecondHandPos_2;
    [FieldOffset(0x0074)] public float AddNextSecondHandAngle_2;
    [FieldOffset(0x0078)] public FVector AddNextBlueBandPos_3;
    [FieldOffset(0x0084)] public float AddNextBlueBandAngle_3;
    [FieldOffset(0x0088)] public FVector AddNextBlueBandAnglePoint_3;
    [FieldOffset(0x0094)] public FVector AddNextTimePos_3;
    [FieldOffset(0x00A0)] public FVector AddNextSecondHandPos_3;
    [FieldOffset(0x00AC)] public float AddNextSecondHandAngle_3;
    [FieldOffset(0x00B0)] public FVector AddNextBlueBandPos_4;
    [FieldOffset(0x00BC)] public float AddNextBlueBandAngle_4;
    [FieldOffset(0x00C0)] public FVector AddNextBlueBandAnglePoint_4;
    [FieldOffset(0x00CC)] public FVector AddNextTimePos_4;
    [FieldOffset(0x00D8)] public FVector AddNextSecondHandPos_4;
    [FieldOffset(0x00E4)] public float AddNextSecondHandAngle_4;
    [FieldOffset(0x00E8)] public FVector AddNextBlueBandPos_5;
    [FieldOffset(0x00F4)] public float AddNextBlueBandAngle_5;
    [FieldOffset(0x00F8)] public FVector AddNextBlueBandAnglePoint_5;
    [FieldOffset(0x0104)] public FVector AddNextTimePos_5;
    [FieldOffset(0x0110)] public FVector AddNextSecondHandPos_5;
    [FieldOffset(0x011C)] public float AddNextSecondHandAngle_5;
    [FieldOffset(0x0120)] public int NowTimeLeftSlideFrame;
    [FieldOffset(0x0124)] public int NowTimeLeftSlideWaitFrame;
    [FieldOffset(0x0128)] public float NowTimeLeftSlideSize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FTownMapParamTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FVector2D SchoolPos;
    [FieldOffset(0x0010)] public FVector2D DormitoryPos;
    [FieldOffset(0x0018)] public FVector2D PolonianmallPos;
    [FieldOffset(0x0020)] public FVector2D PortilandPos;
    [FieldOffset(0x0028)] public FVector2D IwatdaiPos;
    [FieldOffset(0x0030)] public FVector2D NaganakiPos;
    [FieldOffset(0x0038)] public bool bDebugPosDraw;
    [FieldOffset(0x003C)] public int TenmetuFrame;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FVelvetRoomCardWork
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C)] 
public unsafe struct FVelvetRoomCardItem
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FUIVoiceActionAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public bool bIsUseMatrix;
    [FieldOffset(0x0010)] public FVector2D StartPos;
    [FieldOffset(0x0018)] public FVector2D EndPos;
    [FieldOffset(0x0020)] public FColor StartColor;
    [FieldOffset(0x0024)] public FColor EndColor;
    [FieldOffset(0x0028)] public float StartAngle;
    [FieldOffset(0x002C)] public float EndAngle;
    [FieldOffset(0x0030)] public float StartValue;
    [FieldOffset(0x0034)] public float EndValue;
    [FieldOffset(0x0040)] public FMatrix StartMatrix;
    [FieldOffset(0x0080)] public FMatrix EndMatrix;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct FUIVoiceAnswerAnimParams
{
    [FieldOffset(0x0000)] public int StartFrame;
    [FieldOffset(0x0004)] public int EndFrame;
    [FieldOffset(0x0008)] public bool bIsUsePos;
    [FieldOffset(0x0009)] public bool bIsUseColor;
    [FieldOffset(0x000A)] public bool bIsUseAngle;
    [FieldOffset(0x000B)] public bool bIsUseValue;
    [FieldOffset(0x000C)] public bool bIsUseMatrix;
    [FieldOffset(0x0010)] public FVector2D StartPos;
    [FieldOffset(0x0018)] public FVector2D EndPos;
    [FieldOffset(0x0020)] public FColor StartColor;
    [FieldOffset(0x0024)] public FColor EndColor;
    [FieldOffset(0x0028)] public float StartAngle;
    [FieldOffset(0x002C)] public float EndAngle;
    [FieldOffset(0x0030)] public float StartValue;
    [FieldOffset(0x0034)] public float EndValue;
    [FieldOffset(0x0040)] public FMatrix StartMatrix;
    [FieldOffset(0x0080)] public FMatrix EndMatrix;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FWordTranslationTable
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FString Name;
    [FieldOffset(0x0018)] public bool Ext;
    [FieldOffset(0x001C)] public int LangBits;
    [FieldOffset(0x0020)] public int Index;
}

