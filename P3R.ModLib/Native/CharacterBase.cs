using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UCharacterBaseBpLib
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct UAnimInstanceCore
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FCB_HumanMeshPack
{
    [FieldOffset(0x0000)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Base;
    [FieldOffset(0x0010)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Costume;
    [FieldOffset(0x0020)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Hair;
    [FieldOffset(0x0030)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Face;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UCB_HumanMeshPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_HumanMeshPack _MeshPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FCB_HumanAnimPack
{
    [FieldOffset(0x0000)] public TArray<TSoftClassPtr<UObject>> _Base;
    [FieldOffset(0x0010)] public TArray<TSoftClassPtr<UObject>> _Costume;
    [FieldOffset(0x0020)] public TArray<TSoftClassPtr<UObject>> _Hair;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCB_HumanAnimPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_HumanAnimPack _AnimPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCB_PersonaMeshPack
{
    [FieldOffset(0x0000)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Base;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCB_PersonaMeshPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_PersonaMeshPack _MeshPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCB_PersonaAnimPack
{
    [FieldOffset(0x0000)] public TArray<TSoftClassPtr<UObject>> _Base;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCB_PersonaAnimPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_PersonaAnimPack _AnimPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCB_NpcMeshPack
{
    [FieldOffset(0x0000)] public TArray<TSoftObjectPtr<USkeletalMesh>> _Base;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCB_NpcMeshPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_NpcMeshPack _MeshPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCB_NpcAnimPack
{
    [FieldOffset(0x0000)] public TArray<TSoftClassPtr<UObject>> _Base;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UCB_NpcAnimPackAsset
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public FCB_NpcAnimPack _AnimPack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5A0)] 
public unsafe struct ACharacterBaseCore
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public UCBL_LoaderBase* _SkeletalMeshLoader;
    [FieldOffset(0x04C0)] public UCBL_LoaderBase* _AnimBpLoader;
    [FieldOffset(0x04C8)] public TArray<IntPtr> _SkeletalMeshCompArray;
    [FieldOffset(0x04D8)] public bool _RecalcBounds;
    [FieldOffset(0x04D9)] public bool _AutoLoading;
    [FieldOffset(0x04E0)] public UCB_HumanMeshPackAsset* _MeshPackAsset;
    [FieldOffset(0x0528)] public int _PreviewMeshNo;
    [FieldOffset(0x052C)] public int _PreviewCostumeNo;
    [FieldOffset(0x0530)] public int _PreviewHairNo;
    [FieldOffset(0x0534)] public int _PreviewFaceNo;
    [FieldOffset(0x0548)] public UCB_HumanAnimPackAsset* _AnimPackAsset;
    [FieldOffset(0x0580)] public int _PreviewMeshAnimNo;
    [FieldOffset(0x0584)] public int _PreviewCostumeAnimNo;
    [FieldOffset(0x0588)] public int _PreviewHairAnimNo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCBL_LoaderBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0050)] public TArray<IntPtr> _LoadedAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UCBL_LoaderTexture
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0050)] public TArray<IntPtr> _LoadedAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ACrowdNpcBaseCore
{
    [FieldOffset(0x0000)] public APawn baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C0)] 
public unsafe struct AEnemySymbolBaseCore
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FMobWalkRoutePoint
{
    [FieldOffset(0x0000)] public EMobWalkTargetType mType;
    [FieldOffset(0x0004)] public float mStopTime;
    [FieldOffset(0x0010)] public FTransform mTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x378)] 
public unsafe struct AMobBaseAiControllerCore
{
    [FieldOffset(0x0000)] public AAIController baseObj;
    [FieldOffset(0x0328)] public float mTargetDistance_;
    [FieldOffset(0x032C)] public float mTurnSpeed_;
    [FieldOffset(0x0330)] public float mWalkMaxSpeed_;
    [FieldOffset(0x0334)] public float mWalkStopTurnSpeedRatio_;
    [FieldOffset(0x0338)] public float mWalkInterpTurnSpeedMIN_;
    [FieldOffset(0x033C)] public float mWalkInterpTurnSpeedMAX_;
    [FieldOffset(0x0340)] public float mShiftDirectionDistance_;
    [FieldOffset(0x0344)] public float mShiftDirectionMinInterpSpeed_;
    [FieldOffset(0x0348)] public float mShiftDirectionMaxInterpSpeed_;
    [FieldOffset(0x034C)] public float mShiftDirectionTimeOut_;
    [FieldOffset(0x0350)] public float mFollowWarpDistance_;
    [FieldOffset(0x0354)] public float mDeleteInterval_;
    [FieldOffset(0x0358)] public float mDeleteMoveMin_;
    [FieldOffset(0x035C)] public float mDeleteTime_;
    [FieldOffset(0x0368)] public AMobWalkCharaBaseCore* mOwnerActor_;
    [FieldOffset(0x0370)] public float mNowDeltaTime_;
    [FieldOffset(0x0374)] public float mAnimeRatio_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IMobCharaBaseListener
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct AMobWalkTarget
{
    [FieldOffset(0x0000)] public ATargetPoint baseObj;
    [FieldOffset(0x0220)] public EMobWalkTargetType mType_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x500)] 
public unsafe struct AMobWalkCharaBaseCore
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public int mBpIndex_;
    [FieldOffset(0x04BC)] public float mOpacityCore_;
    [FieldOffset(0x04C0)] public TArray<FMobWalkRoutePoint> mPointList_;
    [FieldOffset(0x04D0)] public int mPointIndex_;
    [FieldOffset(0x04D4)] public FVector mStartLocation_;
    [FieldOffset(0x04E0)] public float mWaitTime_;
    [FieldOffset(0x04E8)] public AActor* mFollowParent_;
    [FieldOffset(0x04F0)] public FVector mFollowRelativeLocation_;
    [FieldOffset(0x04FC)] public EMobWalkStartState mStartState_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2F0)] 
public unsafe struct UNpcAnimationBaseCore
{
    [FieldOffset(0x0000)] public UAnimInstance baseObj;
    [FieldOffset(0x02B8)] public ENpcAnimLookAtType LookAtType;
    [FieldOffset(0x02BC)] public FVector LookAtWorldLocation;
    [FieldOffset(0x02C8)] public AActor* LookAtTargetActor;
    [FieldOffset(0x02D0)] public FString LookAtTargetActorBoneName;
    [FieldOffset(0x02E0)] public UAnimSequenceBase* IdolAnimSequence;
}

[StructLayout(LayoutKind.Explicit, Size = 0x418)] 
public unsafe struct ANpcBaseCore
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public USceneComponent* Root;
    [FieldOffset(0x0288)] public USkeletalMeshComponent* Mesh;
    [FieldOffset(0x0290)] public UCBL_LoaderBase* _SkeletalMeshLoader;
    [FieldOffset(0x0298)] public UCBL_LoaderBase* _AnimBpLoader;
    [FieldOffset(0x02A0)] public UCBL_LoaderTexture* _TextureLoader;
    [FieldOffset(0x02A8)] public TArray<IntPtr> _SkeletalMeshCompArray;
    [FieldOffset(0x02B8)] public bool _AutoLoading;
    [FieldOffset(0x02C0)] public UCB_HumanMeshPackAsset* _MeshPackAsset;
    [FieldOffset(0x0308)] public int _PreviewMeshNo;
    [FieldOffset(0x030C)] public int _PreviewCostumeNo;
    [FieldOffset(0x0310)] public int _PreviewHairNo;
    [FieldOffset(0x0314)] public int _PreviewFaceNo;
    [FieldOffset(0x0328)] public UCB_HumanAnimPackAsset* _AnimPackAsset;
    [FieldOffset(0x0360)] public int _PreviewMeshAnimNo;
    [FieldOffset(0x0364)] public int _PreviewCostumeAnimNo;
    [FieldOffset(0x0368)] public int _PreviewHairAnimNo;
    [FieldOffset(0x0380)] public UTexture2D* CostumeTexture;
    [FieldOffset(0x0388)] public UTexture2D* HairTexture;
    [FieldOffset(0x0390)] public UTexture2D* FaceTexture;
    [FieldOffset(0x0398)] public TSoftObjectPtr<UTexture2D> _CostumeTexturePtr;
    [FieldOffset(0x03C0)] public TSoftObjectPtr<UTexture2D> _HairTexturePtr;
    [FieldOffset(0x03E8)] public TSoftObjectPtr<UTexture2D> _FaceTexturePtr;
    [FieldOffset(0x0410)] public int SkinColorID;
    [FieldOffset(0x0414)] public float HeightScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct APersonaBaseCore
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public USkeletalMeshComponent* Mesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x288)] 
public unsafe struct AShadowBaseCore
{
    [FieldOffset(0x0000)] public APawn baseObj;
    [FieldOffset(0x0280)] public USkeletalMeshComponent* Mesh;
}

