public enum EAppCharCategoryType {
    None = 0,
    MainCharacter = 1,
    SubCharacter = 2,
    NpcCharacter = 3,
    EAppCharCategoryType_MAX = 4,
};

public enum ECharacterSimpleLipsAnimAppStateType {
    StartSpeaking = 0,
    StopSpeaking = 1,
    ECharacterSimpleLipsAnimAppStateType_MAX = 2,
};

public enum EAtlLevelSequenceActorType {
    UE4Default = 0,
    AtlusEvent = 1,
    AtlusBattle = 2,
    AtlusBattleEvent = 3,
    AtlusFieldEvent = 4,
    AtlusEventTemplateFieldEvent = 5,
    EAtlLevelSequenceActorType_MAX = 6,
};

public enum EDungeonObjHitEvent {
    In = 0,
    Out = 1,
    Action = 2,
    EDungeonObjHitEvent_MAX = 3,
};

public enum ELipSyncAppStateType {
    StartSpeaking = 0,
    StopSpeaking = 1,
    ELipSyncAppStateType_MAX = 2,
};

public enum EAppPauseObjectFlag {
    Unknown = 0,
    CampUI = 1,
    CharacterModel = 2,
    FieldLocal = 4,
    SystemUI = 8,
    FacilityUI = 16,
    FieldSound = 32,
    FieldCrowd = 64,
    Always = 255,
    EAppPauseObjectFlag_MAX = 256,
};

public enum EUIBLEND_STATE_TYPE {
    EUI_Defult_Value = 0,
    UI_DEFAULT = 0,
    UI_MUL = 1,
    UI_ADD = 2,
    UI_CREATE_MASK = 3,
    UI_CREATE_MASK_INV = 4,
    UI_DRAW_MIN_ALPHA = 5,
    UI_USE_MASK_DRAW = 6,
    UI_USE_MASK_ADD_DRAW = 7,
    UI_ONE = 8,
    UI_MINIMAP_MASK = 9,
    UI_DEFAULT_AND_NONE_ALPHA = 10,
    UI_MUL_AND_NONE_ALPHA = 11,
    UI_ADD_AND_NONE_ALPHA = 12,
    EUIBLEND_STATE_MAX = 13,
};

public enum EUI_DRAW_POINT {
    UI_DRAW_LEFT_TOP = 0,
    UI_DRAW_LEFT_CENTER = 1,
    UI_DRAW_LEFT_BOTTOM = 2,
    UI_DRAW_CENTER_TOP = 3,
    UI_DRAW_CENTER_CENTER = 4,
    UI_DRAW_CENTER_BOTTOM = 5,
    UI_DRAW_RIGHT_TOP = 6,
    UI_DRAW_RIGHT_CENTER = 7,
    UI_DRAW_RIGHT_BOTTOM = 8,
    UI_DRAW_MAX = 9,
};

public enum EUIFontStyle {
    EUI_Defult_Value = 0,
    UI_FONT_STYLE_NORMAL_SSMALL = 3,
    UI_FONT_STYLE_NORMAL_SMALL = 0,
    UI_FONT_STYLE_NORMAL_MEDIUM = 1,
    UI_FONT_STYLE_NORMAL_LARGE = 2,
    EUIFontStyle_MAX = 4,
};

public enum EUIBlendFactor {
    EUI_Defult_Value = 0,
    UI_BF_Zero = 0,
    UI_BF_One = 1,
    UI_BF_SourceColor = 2,
    UI_BF_InverseSourceColor = 3,
    UI_BF_SourceAlpha = 4,
    UI_BF_InverseSourceAlpha = 5,
    UI_BF_DestAlpha = 6,
    UI_BF_InverseDestAlpha = 7,
    UI_BF_DestColor = 8,
    UI_BF_InverseDestColor = 9,
    UI_BF_ConstantBlendFactor = 10,
    UI_BF_InverseConstantBlendFactor = 11,
    UI_BF_Source1Color = 12,
    UI_BF_InverseSource1Color = 13,
    UI_BF_Source1Alpha = 14,
    UI_BF_InverseSource1Alpha = 15,
    UI_EBlendFactor_Num = 16,
    UI_EBlendFactor_NumBits = 4,
    EUIBlendFactor_MAX = 17,
};

public enum EUIBlendOperation {
    EUI_Defult_Value = 0,
    UI_BO_Add = 0,
    UI_BO_Subtract = 1,
    UI_BO_Min = 2,
    UI_BO_Max = 3,
    UI_BO_ReverseSubtract = 4,
    UI_EBlendOperation_Num = 5,
    UI_EBlendOperation_NumBits = 3,
    EUIBlendOperation_MAX = 6,
};

public enum EUIOTPRESET_BLEND_TYPE {
    EUI_Defult_Value = 0,
    UI_OT_PRESET_BLEND_OPAQUE = 0,
    UI_OT_PRESET_BLEND_SEMITRANS = 1,
    UI_OT_PRESET_BLEND_ADDTRANS = 2,
    UI_OT_PRESET_BLEND_SUBTRANS = 3,
    UI_OT_PRESET_BLEND_MULTRANS = 4,
    UI_OT_PRESET_BLEND_MUL2TRANS = 5,
    UI_OT_PRESET_BLEND_ADVANCED = 6,
    UI_OT_PRESET_BLEND_MAKE_MASK = 7,
    UI_OT_PRESET_BLEND_MAKE_MASK_MUL = 8,
    UI_OT_PRESET_BLEND_DRAW_ONLY_MASK = 9,
    EUIOTPRESET_BLEND_MAX = 10,
};

public enum appCalculationType {
    Default_value = 0,
    LINEAR = 0,
    DEC = 1,
    ACC = 2,
    COS2 = 3,
    H_DEC = 4,
    H_ACC = 5,
    ACC_DEC = 6,
    SIN_2 = 7,
    AD_SIN = 8,
    LOOP = 9,
    appCalculationType_MAX = 10,
};

public enum EDrawConfigListType {
    NONE = 0,
    BUTTON = 1,
    SOUNT_OUTPUT = 2,
    GRAPHIC_QUALITY = 3,
    RENDERING_SCALE = 4,
    SHADOW_QUALITY = 5,
    FRAMELATE = 6,
    RESOLUTION = 7,
    SCREEN_MODE = 8,
    MONITOR = 9,
    KEY_CONFIG = 10,
    EDrawConfigListType_MAX = 11,
};

public enum EDrawConfigParamType {
    DCPT_FLAG = 0,
    DCPT_VALUE = 1,
    DCPT_LANGUAGE = 2,
    DCPT_SELECT = 3,
    DCPT_BGM = 4,
    DCPT_LIST = 5,
    DCPT_MAX = 6,
};

public enum ECmpLayoutConfig {
    PLAYLIST_POS = 0,
    SET_POS = 1,
    INFO_POS = 2,
    INFO_TEXT_POS = 3,
    BUTTON_TEXT_POS = 4,
    AUDIO_DEVICE_BASELINE = 5,
    Max = 6,
};

public enum ECmpLayoutConfigText {
    DETAIL_TEXT_COLLISION = 0,
    ITEM_TEXT_COLLISION = 1,
    BUTTON_TEXT_COLLISION = 2,
    CHOICE_TEXT_COLLISION = 3,
    CHOICE_TEXT_POS_Y = 4,
    BGM_TEXT_COLLISION = 5,
    SET_BGM_TEXT_COLLISION = 6,
    Max = 7,
};

public enum ESaveLoadDateLayout {
    MONTH = 0,
    DAY_1_DIG = 1,
    DAY_2_DIG = 2,
    SEL_MONTH = 3,
    SEL_DAY_1_DIG = 4,
    SEL_DAY_2_DIG = 5,
    MAX = 6,
};

public enum ESaveLoadLayout2 {
    CLEAR_DATA = 0,
    NETWORK_NOT_SET = 1,
    NETWORK_DISCONNECTED = 2,
    NETWORK_NOT_SET_SEL = 3,
    NETWORK_DISCONNECTED_SEL = 4,
    MAX = 5,
};

public enum ESaveLoadLayout {
    SAVE_HELP = 0,
    SAVE_HELP_TEXT = 1,
    LOAD_HELP = 2,
    LOAD_HELP_TEXT = 3,
    ROLL_BACK_HELP = 4,
    ROLL_BACK_HELP_TEXT = 5,
    LOCATION_TEXTCOL = 6,
    LV_POS = 7,
    LVNUM_POS = 8,
    LVNUM_10POS = 9,
    PL_POS = 10,
    PL_TEXTCOL = 11,
    PL_LF_THRESHOLD = 12,
    MAX = 13,
};

public enum ESaveDrawOpenType {
    TYPE_FIELD = 0,
    TYPE_CAMP = 1,
    TYPE_TITLE = 2,
    TYPE_MAX = 3,
};

public enum EAddContentEntitlementCategory {
    Blank = 0,
    Bundle = 1,
    Unlock = 2,
    Entitlement = 3,
    EAddContentEntitlementCategory_MAX = 4,
};

public enum EEventAnimID {
    BLANK = 0,
    Main = 1,
    Neutral = 2,
    Walk = 3,
    Run = 4,
    TalkR = 5,
    TalkMainR = 6,
    SatN = 7,
    SatMain = 8,
    SatTalkR = 9,
    TurnL90 = 10,
    TurnR90 = 11,
    TurnL180 = 12,
    TurnR180 = 13,
    NodN = 14,
    NeckSwingN = 15,
    BagL = 16,
    TalkR_17 = 17,
    Main_18 = 18,
    TalkR_19 = 19,
    MainTag = 20,
    NeutralTag = 21,
    WalkTag = 22,
    RunTag = 23,
    TalkRTag = 24,
    TalkMainRTag = 25,
    SurprisedTag = 26,
    AngryTag = 27,
    TroubleTag = 28,
    SadTag = 29,
    CryTag = 30,
    LaughTag = 31,
    GladTag = 32,
    StandingActionATag = 33,
    SatActionTag = 34,
    SatNTag = 35,
    SatMainStartTag = 36,
    SatMainTag = 37,
    SatMainEndTag = 38,
    SatAStartTag = 39,
    SatATag = 40,
    SatAEndTag = 41,
    SatBStartTag = 42,
    SatBTag = 43,
    SatBEndTag = 44,
    StandTag = 45,
    SitTag = 46,
    StandingAStartTag = 47,
    StandingATag = 48,
    StandingAEndTag = 49,
    StandingBStartTag = 50,
    StandingBTag = 51,
    StandingBEndTag = 52,
    StandingActionBTag = 53,
    TalkSatNTag = 54,
    EVC0321 = 60,
    EVC0322 = 61,
    EEventAnimID_MAX = 62,
};

public enum EDungeonAnimID {
    BLANK = 0,
    Idel = 1,
    Walk = 2,
    Talk = 3,
    SatMain = 4,
    SatTalk = 5,
    SatA = 6,
    SatB = 7,
    SatN = 8,
    TurnL90 = 9,
    TurnR90 = 10,
    TurnL180 = 11,
    TurnR180 = 12,
    Run = 13,
    Dash = 14,
    AttackA = 50,
    AttackB = 51,
    AttackAssault = 52,
    DashStop = 53,
    DashStopTurn = 54,
    AttackDashA = 55,
    DoorOpen00 = 115,
    PersonalAction1 = 200,
    PersonalAction2 = 201,
    PersonalAction3 = 202,
    PersonalAction4 = 203,
    PersonalAction5 = 204,
    PersonalAction6 = 205,
    TurnL = 210,
    TurnR = 211,
    EDungeonAnimID_MAX = 212,
};

public enum ECommonAnimID {
    BLANK = 0,
    Idel = 1,
    Walk = 2,
    Talk = 3,
    SatMain = 4,
    SatTalk = 5,
    SatA = 6,
    SatB = 7,
    SatN = 8,
    TurnL90 = 9,
    TurnR90 = 10,
    TurnL180 = 11,
    TurnR180 = 12,
    PhoneIdel = 13,
    PhoneWalk = 14,
    PhoneTalk = 15,
    PhoneSatMain = 16,
    PhoneSatTalk = 17,
    StrongIdel = 18,
    StrongWalk = 19,
    StrongTalk = 20,
    StrongSatMain = 21,
    StrongSatTalk = 22,
    WeakIdel = 23,
    WeakWalk = 24,
    WeakTalk = 25,
    WeakSatMain = 26,
    WeakSatTalk = 27,
    FldAction1 = 50,
    FldAction2 = 51,
    FldAction3 = 52,
    FldAction4 = 53,
    FldAction5 = 54,
    FldAction6 = 55,
    FldAction7 = 56,
    FldAction8 = 57,
    FldAction9 = 58,
    FldAction10 = 59,
    FldAction11 = 60,
    FldAction12 = 61,
    FldAction13 = 62,
    FldAction14 = 63,
    FldAction15 = 64,
    FldAction16 = 65,
    FldAction17 = 66,
    FldAction18 = 67,
    FldAction19 = 68,
    TalkMainR = 80,
    TalkMainL = 81,
    KageIdle = 100,
    DoorOpen1 = 115,
    DoorOpen2 = 116,
    DoorOpen3 = 117,
    DoorOpen4 = 118,
    DoorOpen5 = 119,
    DoorOpen6 = 120,
    DoorOpen7 = 121,
    DoorOpen8 = 122,
    DoorOpen9 = 123,
    DoorOpen10 = 124,
    DoorOpen11 = 125,
    DoorOpen12 = 126,
    PersonalAction1 = 200,
    PersonalAction2 = 201,
    PersonalAction3 = 202,
    PersonalAction4 = 203,
    PersonalAction5 = 204,
    PersonalAction6 = 205,
    TurnL = 210,
    TurnR = 211,
    ECommonAnimID_MAX = 212,
};

public enum EAnimPackID {
    None = 0,
    Common = 1,
    Dungeon = 2,
    Combine = 3,
    Event = 4,
    EAnimPackID_MAX = 5,
};

public enum EAppCharAnimSlot {
    Default = 0,
    Event = 1,
    Max = 2,
};

public enum EAppCharWeaponType {
    None = 0,
    Battle = 1,
    Field = 2,
    EAppCharWeaponType_MAX = 3,
};

public enum EAppCharState {
    None = 0,
    Move = 1,
    MoveStop = 2,
    EAppCharState_MAX = 3,
};

public enum EAppCharBagAnimType {
    EC_None = 0,
    EC_Stand = 1,
    EC_Run = 2,
    EC_Max = 3,
};

public enum EAppCharFaceAnimID {
    EA_Normal = 0,
    EA_Smile = 1,
    EA_Anger = 2,
    EA_Sad = 3,
    EA_Surprise = 4,
    EA_Pain = 5,
    EA_Sigh = 6,
    EA_Shock = 7,
    EA_Shout = 8,
    EA_Daring = 9,
    EA_Disappointed = 10,
    EA_Laugh = 11,
    EA_Agony = 12,
    EA_Serious = 13,
    EA_Summon = 14,
    EA_CloseEyes = 15,
    EA_Max = 16,
};

public enum EAppCharFootstepsType {
    None = 0,
    Walk = 1,
    Run = 2,
    EAppCharFootstepsType_MAX = 3,
};

public enum EAppCharShoesID {
    None = 0,
    Shoes = 50,
    Slippers = 51,
    Socks = 52,
    EAppCharShoesID_MAX = 53,
};

public enum EAppCharAnimCategoryType {
    Common = 0,
    Battle = 1,
    EventBC = 2,
    Field = 3,
    Dungeon = 4,
    EAppCharAnimCategoryType_MAX = 5,
};

public enum AppCharWeaponAnimType {
    None = 0,
    AnimDefault = 1,
    Idle = 2,
    Attack = 3,
    AttackLong = 4,
    AttackCritical = 5,
    AttackMiss = 6,
    AppCharWeaponAnimType_MAX = 7,
};

public enum AppCharWeaponUsageEnv {
    Battle = 0,
    Field = 1,
    AppCharWeaponUsageEnv_MAX = 2,
};

public enum EAppLevelType {
    Normal = 0,
    Resident = 1,
    PreLoad = 2,
    EAppLevelType_MAX = 3,
};

public enum EAppLevelStatus {
    LevelInvalid = 0,
    LevelUnloaded = 1,
    LevelLoading = 2,
    LevelLoaded = 3,
    LevelMakingVisible = 4,
    LevelVisible = 5,
    LevelAlwaysLoaded = 6,
    EAppLevelStatus_MAX = 7,
};

public enum EAppPauseType {
    None = 0,
    Camp = 1,
    TownMap = 2,
    DialogueLog = 3,
    PauseEventA = 4,
    Max = 5,
};

public enum EAppPropsAnimPackType {
    Common = 0,
    EAppPropsAnimPackType_MAX = 1,
};

public enum EAppPropsCardType {
    Blank = 0,
    Persona = 1,
    MajorArcana = 2,
    MinorArcana = 3,
    EAppPropsCardType_MAX = 4,
};

public enum EEventManagerEventRank {
    EventRankA = 0,
    EventRankB = 1,
    EventRankC = 2,
    EventRankUnknown = 3,
    EEventManagerEventRank_MAX = 4,
};

public enum EEventManagerMessageState {
    Invalid = 0,
    RunningMessage = 1,
    EndMessage = 2,
    RunningSelect = 3,
    EndSelect = 4,
    Finished = 5,
    EEventManagerMessageState_MAX = 6,
};

public enum EEventManagerSeqControllerState {
    Idle = 0,
    BeginWaitFinishedMessage = 1,
    WaitingFinishedMessage = 2,
    EndWaitFinishedMessage = 3,
    EEventManagerSeqControllerState_MAX = 4,
};

public enum EAtlEvtManagerSequencerPlayerPauseType {
    NoPause = 0,
    MessagePause = 1,
    GamePause = 2,
    EAtlEvtManagerSequencerPlayerPauseType_MAX = 3,
};

public enum EAtlEvtManagerPauseFlag {
    None = 0,
    AtlEvtMessagePaused = 1,
    AEvtPaused = 2,
    BacklogPaused = 4,
    NetAnswerPaused = 8,
    Always = 255,
    EAtlEvtManagerPauseFlag_MAX = 256,
};

public enum EAtlEvtLocomotionTeleportVelocityType {
    Default = 0,
    Clamp = 1,
    Constant = 2,
    Keep = 3,
    EAtlEvtLocomotionTeleportVelocityType_MAX = 4,
};

public enum EAtlEvtPropAttachType {
    SetAttachPropActor = 0,
    SetDetachTransform = 1,
    Invalid = 2,
    EAtlEvtPropAttachType_MAX = 3,
};

public enum EEvtSoundManageOperationType {
    DayTimeFieldEnvSE = 0,
    SetAisacValueFieldEnvSE = 1,
    EEvtSoundManageOperationType_MAX = 2,
};

public enum EEvtAdxTrackSoundOperationType {
    Play = 0,
    Stop = 1,
    Invalid = 2,
    EEvtAdxTrackSoundOperationType_MAX = 3,
};

public enum EEvtSoundCategoryType {
    GlobalBGM = 0,
    GlobalSE = 1,
    EventVoice = 2,
    EventSE = 3,
    EventSE_2 = 4,
    EventSE_3 = 5,
    UserID = 6,
    EEvtSoundCategoryType_MAX = 7,
};

public enum EEvtConditionalBranchCompType {
    Equal = 0,
    Not = 1,
    LessThan = 2,
    GreaterThan = 3,
    Less = 4,
    Greater = 5,
    EEvtConditionalBranchCompType_MAX = 6,
};

public enum EAtlEvtEventCategoryType {
    MAIN = 0,
    CMMU = 1,
    QEST = 2,
    EXTR = 3,
    FILD = 4,
    EAtlEvtEventCategoryType_MAX = 5,
};

public enum EAtlEvtKeyHelpType {
    Normal = 0,
    AEvent = 1,
    Answer = 2,
    BackLog = 3,
    Disable_Log = 4,
    Max = 5,
};

public enum EAtlEvtLoadLevelCheckType {
    FieldMain = 0,
    FieldSound = 1,
    FieldSeason = 2,
    LightScenario = 3,
    EventMain = 4,
    EAtlEvtLoadLevelCheckType_MAX = 5,
};

public enum EAtlEvtPlayMode {
    PlayingGameMode = 0,
    EventEditHelperMode = 1,
    EAtlEvtPlayMode_MAX = 2,
};

public enum EAtlEvtPlayLoadSublevelType {
    Custom = 0,
    BindActorSublevel = 1,
    CallEvent = 2,
    EvtPlay = 3,
    EventEditHelper = 4,
    EAtlEvtPlayLoadSublevelType_MAX = 5,
};

public enum EAtlEvtSublevelType {
    Unknown = 0,
    Background = 1,
    LightScenario = 2,
    Sound = 3,
    Season = 4,
    Crowd = 5,
    EventSublevel = 6,
    EAtlEvtSublevelType_MAX = 7,
};

public enum EAtlUIPrimitivePreset {
    UI_PRIM_FREE = 0,
    UI_PRIM_TRIANGLE = 1,
    UI_PRIM_SQUARE = 2,
    UI_PRIM_ROUND_SQUARE = 3,
    UI_PRIM_CIRCLE = 4,
    UI_PRIM_MAX = 5,
};

public enum EAtlUIFontStyle {
    UI_FONT_STYLE_NORMAL_SMALL = 0,
    UI_FONT_STYLE_NORMAL_MEDIUM = 1,
    UI_FONT_STYLE_NORMAL_LARGE = 2,
    UI_FONT_STYLE_NORMAL_SSMALL = 3,
    UI_FONT_STYLE_NORMAL_MAX = 4,
};

public enum EEvtCharaAnimationLookAtType {
    Disable = 0,
    World = 1,
    TargetActor = 2,
    TargetActorFIELD = 3,
    EEvtCharaAnimationLookAtType_MAX = 4,
};

public enum EEvtCharaAnimationSlotType {
    User = 0,
    DefaultSlot = 1,
    EventSlot = 2,
    NodSlot = 3,
    FacialSlot = 4,
    ArmL = 5,
    ArmR = 6,
    EEvtCharaAnimationSlotType_MAX = 7,
};

public enum EEvtCharaAnimationType {
    SimpleMontage = 0,
    LoopAnimationSingle = 1,
    LoopAnimationOnLastFrame = 2,
    StopSlotAnimation = 3,
    LoopAnimationSingleWithStartOffset = 4,
    KeepWorld = 5,
    EEvtCharaAnimationType_MAX = 6,
};

public enum EBtlCutsceneMoveMode {
    CharaToNormal = 0,
    NormalToChara = 1,
    EBtlCutsceneMoveMode_MAX = 2,
};

public enum EBtlCutsceneEditorMode {
    NormalCamera = 0,
    CharacterCamera = 1,
    MoveCamera = 2,
    EBtlCutsceneEditorMode_MAX = 3,
};

public enum EBtlCalcStatsType {
    STRENGTH = 0,
    MAGIC = 1,
    ENDURANCE = 2,
    SPEED = 3,
    LUCK = 4,
    EBtlCalcStatsType_MAX = 5,
};

public enum EBtlCalcParamType {
    LEVEL_ATK = 0,
    LEVEL_DEF = 1,
    HP_ATK = 2,
    HP_DEF = 3,
    MAXHP_ATK = 4,
    MAXHP_DEF = 5,
    SP_ATK = 6,
    SP_DEF = 7,
    MAXSP_ATK = 8,
    MAXSP_DEF = 9,
    AFFINITY_ATK = 10,
    AFFINITY_DEF = 11,
    PARAM_ATK = 12,
    PARAM_DEF = 13,
    BAD_AFFINITY_ATK = 14,
    BAD_AFFINITY_DEF = 15,
    HIT = 16,
    BAD_HIT = 17,
    SKILL_POWER = 18,
    CRITICAL = 19,
    DOWN = 20,
    LEVELDAMAGE = 21,
    MAGIC_BONUS_DAMAGE = 22,
    MAGIC_BONUS_RECOVERY = 23,
    ALLOUT_MEMBER_NUM = 24,
    ALLOUT_LEVEL_POWER_RATE = 25,
    ARMOR_ATK = 26,
    ARMOR_DEF = 27,
    EVASION_ATK = 28,
    EVASION_DEF = 29,
    EBtlCalcParamType_MAX = 30,
};

public enum EBtlGameDifficulty {
    BTL_SAFETY = 0,
    BTL_EASY = 1,
    BTL_NORMAL = 2,
    BTL_HARD = 3,
    BTL_RISKY = 4,
    BTL_MAX = 5,
};

public enum EBtlCalcCameraLookAtType {
    CylinderCenter = 0,
    UpShot = 1,
    BustShot = 2,
    LongShot = 3,
    Cylinder = 4,
    Field = 5,
    EBtlCalcCameraLookAtType_MAX = 6,
};

public enum EBtlCalcCameraCylinderType {
    Enchant = 0,
    TargetGroup = 1,
    Whole = 2,
    None = 3,
    Field = 4,
    World = 5,
    EBtlCalcCameraCylinderType_MAX = 6,
};

public enum EBtlLoadingTimeCategory {
    Levels = 0,
    Residents = 1,
    Resources = 2,
    Resourcesenemy = 3,
    GUI = 4,
    CharacterSetup = 5,
    GUIModel = 6,
    MAX = 7,
};

public enum EBtlEncountPreemptive {
    Normal = 0,
    Enemy = 1,
    Ally = 2,
    MAX = 3,
};

public enum EBtlDataMoveCursorTactics {
    BTL_DATA_MOVE_TACTICS_UP = 0,
    BTL_DATA_MOVE_TACTICS_RIGHT = 1,
    BTL_DATA_MOVE_TACTICS_DOWN = 2,
    BTL_DATA_MOVE_TACTICS_LEFT = 3,
    BTL_DATA_MOVE_TACTICS_MAX = 4,
};

public enum EBtlDataBadStatus {
    BTL_DATA_BAD_KIZETU = 0,
    BTL_DATA_BAD_CHARM = 1,
    BTL_DATA_BAD_UPSET = 2,
    BTL_DATA_BAD_PANIC = 3,
    BTL_DATA_BAD_FEAR = 4,
    BTL_DATA_BAD_ANGER = 5,
    BTL_DATA_BAD_FREEZE = 6,
    BTL_DATA_BAD_SHOCK = 7,
    BTL_DATA_BAD_POISON = 8,
    BTL_DATA_BAD_OVERLIMIT = 9,
    BTL_DATA_BAD_OVERHEAT = 10,
    BTL_DATA_BAD_BOMB = 11,
    BTL_DATA_BAD_DEAD = 12,
    BTL_DATA_BAD_DOWN = 13,
    BTL_DATA_BAD_MAX = 14,
};

public enum EBtlDataItemUseType {
    BTL_DATA_ITEM_USE_SUCCESS = 0,
    BTL_DATA_ITEM_USE_DONTUSE = 1,
    BTL_DATA_ITEM_USE_MAX = 2,
};

public enum EBtlDataSupportTable {
    BTL_DATA_SUPPORT_ATK_UP = 0,
    BTL_DATA_SUPPORT_ATK_DOWN = 1,
    BTL_DATA_SUPPORT_ESC_UP = 2,
    BTL_DATA_SUPPORT_ESC_DOWN = 3,
    BTL_DATA_SUPPORT_DEF_UP = 4,
    BTL_DATA_SUPPORT_DEF_DOWN = 5,
    BTL_DATA_SUPPORT_HIT_UP = 6,
    BTL_DATA_SUPPORT_HIT_DOWN = 7,
    BTL_DATA_SUPPORT_HIRISK = 8,
    BTL_DATA_SUPPORT_RISKHG = 9,
    BTL_DATA_SUPPORT_AGINDA = 10,
    BTL_DATA_SUPPORT_BUFNDA = 11,
    BTL_DATA_SUPPORT_GALNDA = 12,
    BTL_DATA_SUPPORT_JIONDA = 13,
    BTL_DATA_SUPPORT_BADx2 = 14,
    BTL_DATA_SUPPORT_REDWALL = 15,
    BTL_DATA_SUPPORT_BLUWALL = 16,
    BTL_DATA_SUPPORT_YELWALL = 17,
    BTL_DATA_SUPPORT_GRNWALL = 18,
    BTL_DATA_SUPPORT_TETORA = 19,
    BTL_DATA_SUPPORT_MAKARA = 20,
    BTL_DATA_SUPPORT_BATKx2 = 21,
    BTL_DATA_SUPPORT_MATKx2 = 22,
    BTL_DATA_SUPPORT_DEKAJA = 23,
    BTL_DATA_SUPPORT_DEKUNDA = 24,
    BTL_DATA_SUPPORT_MAX = 25,
};

public enum EBtlDataCostType {
    BTL_DATA_COST_NONE = 0,
    BTL_DATA_COST_HP = 1,
    BTL_DATA_COST_SP = 2,
    BTL_DATA_COST_MAX = 3,
};

public enum EBtlDataAnalyze {
    BTL_DATA_ANA_NORMAL = 0,
    BTL_DATA_ANA_MUKOU = 1,
    BTL_DATA_ANA_HANSYA = 2,
    BTL_DATA_ANA_KYUSYU = 3,
    BTL_DATA_ANA_WEAK = 4,
    BTL_DATA_ANA_TAISEI = 5,
    BTL_DATA_ANA_NOOPEN = 6,
    BTL_DATA_ANA_MAX = 7,
};

public enum EBtlDataKeyControl {
    BTL_DATA_KEYCONTROL_ATTACK = 0,
    BTL_DATA_KEYCONTROL_GUARD = 1,
    BTL_DATA_KEYCONTROL_PERSONA = 2,
    BTL_DATA_KEYCONTROL_ITEM = 4,
    BTL_DATA_KEYCONTROL_SHIFT = 4,
    BTL_DATA_KEYCONTROL_ANALYZE = 4,
    BTL_DATA_KEYCONTROL_STRATEGY = 4,
    BTL_DATA_KEYCONTROL_ASSIST = 4,
    BTL_DATA_KEYCONTROL_RUSH = 4,
    BTL_DATA_KEYCONTROL_MAX = 5,
};

public enum EBtlDataTargetArea {
    BTL_DATA_TARGET_AREA_NULL = 0,
    BTL_DATA_TARGET_AREA_ALLY = 1,
    BTL_DATA_TARGET_AREA_ENEMY = 2,
    BTL_DATA_TARGET_AREA_PERSONA = 4,
    BTL_DATA_TARGET_AREA_MAX = 5,
};

public enum EBtlDataTargetType {
    BTL_DATA_TARGET_TYPE_NULL = 0,
    BTL_DATA_TARGET_TYPE_SINGLE = 0,
    BTL_DATA_TARGET_TYPE_GROUP = 1,
    BTL_DATA_TARGET_TYPE_ALL = 2,
    BTL_DATA_TARGET_TYPE_NON = 3,
    BTL_DATA_TARGET_TYPE_MAX = 4,
};

public enum EBtlDataEfficacyType {
    BTL_DATA_EFFICACY_NULL = 0,
    BTL_DATA_EFFICACY_NON = 0,
    BTL_DATA_EFFICACY_BUTURI = 1,
    BTL_DATA_EFFICACY_MAGIC = 2,
    BTL_DATA_EFFICACY_MAX = 3,
};

public enum EBtlCommonEventType {
    RETRY = 0,
    MAX = 1,
};

public enum EBtlEventType {
    ENCOUNT = 0,
    BTLSTART = 1,
    AISTART = 2,
    ACTSTART = 3,
    ACTEND = 4,
    BTLEND = 5,
    TALK = 6,
    TALK02 = 7,
    EVENT0 = 8,
    EVENT1 = 9,
    EVENT2 = 10,
    EVENT3 = 11,
    EVENT4 = 12,
    EVENT5 = 13,
    MAX = 14,
};

public enum EBtlFadeType {
    BTL_FADE_TYPE_NULL = 0,
    BTL_FADE_TYPE_BLACKOUT = 1,
    BTL_FADE_TYPE_WHITEOUT = 2,
    BTL_FADE_TYPE_LINEWIPE = 3,
    BTL_FADE_TYPE_CIRCLE = 4,
    BTL_FADE_TYPE_CIRCLE2 = 5,
    BTL_FADE_TYPE_CIRCLE3 = 6,
    BTL_FADE_TYPE_SHIFTIN = 7,
    BTL_FADE_TYPE_SHIFTOUT = 8,
    BTL_FADE_TYPE_THEURGIA = 9,
    BTL_FADE_TYPE_BATTLE_RESULT = 10,
    BTL_FADE_TYPE_BATTLE_RESULT_END = 11,
    BTL_FADE_TYPE_CONTINUE = 12,
    BTL_FADE_TYPE_MAX = 13,
};

public enum EBtlSizeCategoryType {
    CATEGORY_S = 0,
    CATEGORY_M = 1,
    CATEGORY_L = 2,
    CATEGORY_LL = 3,
    CATEGORY_EX = 4,
    CATEGORY_MAX = 5,
};

public enum EBtlFormationCategoryType {
    CATEGORY_S = 0,
    CATEGORY_M = 1,
    CATEGORY_L = 2,
    CATEGORY_SS = 3,
    CATEGORY_MS = 4,
    CATEGORY_MM = 5,
    CATEGORY_LS = 6,
    CATEGORY_LM = 7,
    CATEGORY_LL = 8,
    CATEGORY_SSS = 9,
    CATEGORY_MSS = 10,
    CATEGORY_MMS = 11,
    CATEGORY_MMM = 12,
    CATEGORY_LSS = 13,
    CATEGORY_LMS = 14,
    CATEGORY_LMM = 15,
    CATEGORY_LLS = 16,
    CATEGORY_LLM = 17,
    CATEGORY_LLL = 18,
    CATEGORY_SSSS = 19,
    CATEGORY_MSSS = 20,
    CATEGORY_MMSS = 21,
    CATEGORY_MMMS = 22,
    CATEGORY_LMSS = 23,
    CATEGORY_LMMS = 24,
    CATEGORY_LLSS = 25,
    CATEGORY_MMMM = 26,
    CATEGORY_SSSSS = 27,
    CATEGORY_MSSSS = 28,
    CATEGORY_MMSSS = 29,
    CATEGORY_LSSSS = 30,
    CATEGORY_MMMMM = 31,
    CATEGORY_MAX = 32,
};

public enum EBtlFormationSizeType {
    BTL_FORMATION_POINT_SIZE_S = 0,
    BTL_FORMATION_POINT_SIZE_M = 1,
    BTL_FORMATION_POINT_SIZE_L = 2,
    BTL_FORMATION_POINT_SIZE_MAX = 3,
};

public enum EBtlAnalyzeSupportType {
    BTL_ANALYZE_SUPPORT_QUESTION = 0,
    BTL_ANALYZE_SUPPORT_NOT_PREPARE = 1,
    BTL_ANALYZE_SUPPORT_CANNOT_ENEMY = 2,
    BTL_ANALYZE_SUPPORT_PLAY = 3,
    BTL_ANALYZE_SUPPORT_ALREADY_PLAY = 4,
    BTL_ANALYZE_SUPPORT_NOT_SP = 5,
    BTL_ANALYZE_SUPPORT_MAX = 6,
};

public enum EBtlTouchCallbackValue {
    TOP_ATTACK_TEXT = 0,
    TOP_ATTACK_KEY = 1,
    TOP_GUARD_TEXT = 2,
    TOP_GUARD_KEY = 3,
    TOP_ITEM_TEXT = 4,
    TOP_ITEM_KEY = 5,
    TOP_SKILL_TEXT = 6,
    TOP_SKILL_KEY = 7,
    TOP_THEURGIA_TEXT = 8,
    TOP_THEURGIA_KEY = 9,
    TOP_SHIFT_TEXT = 10,
    TOP_SHIFT_KEY = 11,
    TOP_ORACLE_TEXT = 12,
    TOP_ORACLE_KEY = 13,
    PROMISE_CANCEL_TEXT = 14,
    PROMISE_CANCEL_KEY = 15,
    PROMISE_GO_TEXT = 16,
    PROMISE_GO_KEY = 17,
    GUARD_NO_TEXT = 18,
    GUARD_NO_KEY = 19,
    GUARD_YES_TEXT = 20,
    GUARD_YES_KEY = 21,
    RUSH_STOP_TEXT = 22,
    RUSH_STOP_KEY = 23,
    SKILL_L_TEXT = 24,
    SKILL_R_TEXT = 25,
    ANALYZE_HIGH_ANALYZE_KEY = 26,
    ANALYZE_L_TEXT = 27,
    ANALYZE_R_TEXT = 28,
    THEURGIA_ARROW_L = 29,
    THEURGIA_ARROW_R = 30,
    THEURGIA_SELECT = 31,
    LIST_SCROLL_BAR = 100,
    LIST_SCROLL_SLIDER = 101,
    EBtlTouchCallbackValue_MAX = 102,
};

public enum EBtlTouchScreenID {
    BTL_SCREEN_ID_CMN = 0,
    BTL_SCREEN_ID_SCROLL = 1,
    BTL_SCREEN_ID_ITEM_LIST = 2,
    BTL_SCREEN_ID_SKILL_LIST = 3,
    BTL_SCREEN_ID_TACTICS1_LIST = 4,
    BTL_SCREEN_ID_TACTICS2_LIST = 5,
    BTL_SCREEN_ID_TACTICS3_LIST = 6,
    BTL_SCREEN_ID_THEURGIA_LIST = 7,
    BTL_SCREEN_ID_MAX = 8,
};

public enum EBtlGuiTextType {
    BTL_TTYPE_NORMAL = 0,
    BTL_TTYPE_ITALIC = 1,
    BTL_TTYPE_THEURGIA_ITALIC = 2,
    BTL_TTYPE_MAX = 3,
};

public enum EBtlGuiFontStyle {
    BTL_FSTYLE_SMALL = 0,
    BTL_FSTYLE_MEDIUM = 1,
    BTL_FSTYLE_MAX = 2,
};

public enum EBtlGuiDrawType {
    BTL_DTYPE_NORMAL = 0,
    BTL_DTYPE_INVALPHA = 1,
    BTL_DTYPE_GAUSS = 2,
    BTL_DTYPE_GAUSSINVAPLHA = 3,
    BTL_DTYPE_GAUSSTEXTURE = 4,
    BTL_DTYPE_GAUSSINVTEXTURE = 5,
    BTL_DTYPE_MULTIPLY = 6,
    BTL_DTYPE_MAX = 7,
};

public enum EBtlGuiAnchorPt {
    BTL_ANC_CENTER = 0,
    BTL_ANC_LU = 1,
    BTL_ANC_RU = 2,
    BTL_ANC_LD = 3,
    BTL_ANC_RD = 4,
    BTL_ANC_MAX = 5,
};

public enum EBtlGuiColorWhiteMask {
    BTL_CW_RGBA = 0,
    BTL_CW_R = 1,
    BTL_CW_G = 2,
    BTL_CW_B = 3,
    BTL_CW_A = 4,
    BTL_CW_RG = 5,
    BTL_CW_BA = 6,
    BTL_CW_RGB = 7,
    BTL_CW_NONE = 8,
    BTL_CW_MAX = 9,
};

public enum EBtlGuiOT {
    BTL_OT_LOW = 0,
    BTL_OT_WIPE = 1,
    BTL_OT_MIDDLE = 2,
    BTL_OT_HIGH = 3,
    BTL_OT_FADE = 4,
    BTL_OT_FADE_HIGH = 5,
    BTL_OT_PTPANEL_HIGH = 6,
    BTL_OT_MAX = 7,
};

public enum EBtlGuiBlendFactor {
    BTL_BF_Zero = 0,
    BTL_BF_One = 1,
    BTL_BF_SourceColor = 2,
    BTL_BF_InverseSourceColor = 3,
    BTL_BF_SourceAlpha = 4,
    BTL_BF_InverseSourceAlpha = 5,
    BTL_BF_DestAlpha = 6,
    BTL_BF_InverseDestAlpha = 7,
    BTL_BF_DestColor = 8,
    BTL_BF_InverseDestColor = 9,
    BTL_BF_ConstantBlendFactor = 10,
    BTL_BF_InverseConstantBlendFactor = 11,
    BTL_BF_Source1Color = 12,
    BTL_BF_InverseSource1Color = 13,
    BTL_BF_Source1Alpha = 14,
    BTL_BF_InverseSource1Alpha = 15,
    BTL_BF_MAX = 16,
};

public enum EBtlGuiBlendOp {
    BTL_OP_ADD = 0,
    BTL_OP_SUBTRACT = 1,
    BTL_OP_MIN = 2,
    BTL_OP_MAX = 3,
    BTL_OP_REVSUB = 4,
};

public enum EBtlGuiCanvas {
    BTL_CANVAS_NULL = 0,
    BTL_CANVAS_0 = 1,
    BTL_CANVAS_1 = 2,
    BTL_CANVAS_2 = 3,
    BTL_CANVAS_3 = 4,
    BTL_CANVAS_4 = 5,
    BTL_CANVAS_5 = 6,
    BTL_CANVAS_6 = 7,
    BTL_CANVAS_7 = 8,
    BTL_CANVAS_CAP = 9,
    BTL_CANVAS_MAX = 10,
};

public enum EBtlEncountWipeType {
    BTL_ENCWIPE_NONE = 0,
    BTL_ENCWIPE_NORMAL = 1,
    BTL_ENCWIPE_PINCH = 2,
    BTL_ENCWIPE_EVENT = 3,
    BTL_ENCWIPE_MAX = 4,
};

public enum EBtlGuiIconKeyHelp {
    BTL_ICON_KEYHELP_NONE = 0,
    BTL_ICON_KEYHELP_TOP = 1,
    BTL_ICON_KEYHELP_SKILL = 2,
    BTL_ICON_KEYHELP_ITEM = 3,
    BTL_ICON_KEYHELP_PROMISE = 4,
    BTL_ICON_KEYHELP_TARGET = 5,
    BTL_ICON_KEYHELP_ALLYTARGET = 6,
    BTL_ICON_KEYHELP_SHIFT = 7,
    BTL_ICON_KEYHELP_TACTICSALLY = 8,
    BTL_ICON_KEYHELP_TACTICSENEMY = 9,
    BTL_ICON_KEYHELP_THEURGIA = 10,
    BTL_ICON_KEYHELP_THEURGIADETAIL = 11,
    BTL_ICON_KEYHELP_ANALYZE = 12,
    BTL_ICON_KEYHELP_ORACLE_TARGET = 13,
    BTL_ICON_KEYHELP_MAX = 14,
};

public enum EBtlGuiIconDamageType {
    BTL_ICON_DAMAGE_NORMAL = 0,
    BTL_ICON_DAMAGE_CRITICAL = 1,
    BTL_ICON_DAMAGE_WEAK = 2,
    BTL_ICON_DAMAGE_MAX = 3,
};

public enum EBtlGuiIconHit {
    BTL_ICON_HIT_NORMAL = 0,
    BTL_ICON_HIT_HANSYA = 1,
    BTL_ICON_HIT_KYUSYU = 2,
    BTL_ICON_HIT_MUKOU = 3,
    BTL_ICON_HIT_TAISEI = 4,
    BTL_ICON_HIT_SAKE = 5,
    BTL_ICON_HIT_MISS = 6,
    BTL_ICON_HIT_MAX = 7,
};

public enum EBtlTouchCollisionLayout {
    TOP_COMMAND_ATTACK = 0,
    TOP_COMMAND_ATTACK_WH = 1,
    TOP_COMMAND_GUARD = 2,
    TOP_COMMAND_GUARD_WH = 3,
    TOP_COMMAND_SKILL = 4,
    TOP_COMMAND_SKILL_WH = 5,
    TOP_COMMAND_ITEM = 6,
    TOP_COMMAND_ITEM_WH = 7,
    TOP_COMMAND_ORACLE = 8,
    TOP_COMMAND_ORACLE_WH = 9,
    TOP_COMMAND_THEURGIA = 10,
    TOP_COMMAND_THEURGIA_WH = 11,
    TOP_COMMAND_SHIFT = 12,
    TOP_COMMAND_SHIFT_WH = 13,
    Max = 14,
};

public enum EBtlOthersLayout {
    SKILL_NAME_PANEL_TEXTCOLL = 0,
    SKILL_NAME_PANEL_POS_Y = 1,
    JYOKYO_HELP_POS_Y_SHORT1LINE = 2,
    JYOKYO_HELP_POS_Y = 3,
    JYOKYO_HELP_ROW_Y = 4,
    JYOKYO_HELP_TEXTCOLL_X = 5,
    ITEM_HELP_TITLE_POS = 6,
    Max = 7,
};

public enum EBtlRushLayout {
    STOP_MASK_LENGTH = 0,
    STOP_MASK_RATE = 1,
    Max = 2,
};

public enum EBtlDamageIconLayout {
    DAMAGE_WEAK_BASE = 0,
    DAMAGE_WEAK_TOP_OFS_Y = 1,
    DAMAGE_WEAK_BOTTOM_OFS_Y = 2,
    DAMAGE_CRITICAL_BASE = 3,
    DAMAGE_CRITICAL_TOP_OFS_Y = 4,
    DAMAGE_CRITICAL_BOTTOM_OFS_Y = 5,
    Max = 6,
};

public enum EBtlPromiseLayout {
    COMMAND_GO_MARU = 0,
    COMMAND_GO_BATSU = 1,
    COMMAND_CANCEL_MARU = 2,
    COMMAND_CANCEL_BATSU = 3,
    Max = 4,
};

public enum EBtlTacticsCheckLayout {
    SITUATION_HEADLINE_WIDTH = 0,
    Max = 1,
};

public enum EBtlGuardLayout {
    GUARD_HEADLINE_WIDTH_TOP = 0,
    GUARD_HEADLINE_WIDTH_BOTTOM = 1,
    Max = 2,
};

public enum EBtlTopLayout {
    COMMAND_ITEM = 0,
    COMMAND_GUARD_MARU = 1,
    COMMAND_GUARD_BATSU = 2,
    COMMAND_SHIFT = 3,
    Max = 4,
};

public enum EBtlTargetInfoTextLayout {
    TARGET_NAME = 0,
    TARGET_NAME_POS = 1,
    Max = 2,
};

public enum EBtlTacticsListTextLayout {
    CHARA_NAME = 0,
    CHARA_NAME_POS = 1,
    OPERATION_NAME = 2,
    OPERATION_NAME_POS = 3,
    MEMBER_CHARA_NAME_POS = 4,
    MEMBER_OPERATION_NAME_POS = 5,
    Max = 6,
};

public enum EBtlTacticsLayout {
    ALREADY_ESCAPE = 0,
    Max = 1,
};

public enum EBtlItemSkillListTextLayout {
    ITEM_SKILL_NAME = 0,
    ITEM_SKILL_HELP = 1,
    ITEM_HELP_POS = 2,
    SKILL_HELP_POS = 3,
    SKILL_PERSONA_NAME = 4,
    SKILL_PERSONA_NAME_POS = 5,
    Max = 6,
};

public enum EBtlTheurgiaLayout {
    USING_QUESTION_TEXT = 0,
    INFO = 1,
    Max = 2,
};

public enum EBtlAnalyzeTextLayout {
    ENEMY_NAME = 0,
    LIST_NAME = 1,
    NAVI_TEXT_X = 2,
    Max = 3,
};

public enum EBtlAnalyzeLayout {
    ARCANA = 0,
    AFFINITY_TEXT = 1,
    NAVI_TEXT_POS_Y = 2,
    Max = 3,
};

public enum EBtlListScreenID {
    NONE = 0,
    BTL_LIST_SCREEN_ID_ITEM = 1,
    BTL_LIST_SCREEN_ID_SKILL = 2,
    BTL_LIST_SCREEN_ID_TACTICS1 = 3,
    BTL_LIST_SCREEN_ID_TACTICS2 = 4,
    BTL_LIST_SCREEN_ID_TACTICS3 = 5,
    BTL_LIST_SCREEN_ID_THEURGIA = 6,
    EBtlListScreenID_MAX = 7,
};

public enum EBtlGuiPromise {
    BTL_PROMISE_NORMAL = 0,
    BTL_PROMISE_GUARD = 1,
    BTL_PROMISE_SOUKOUGEKI = 2,
    BTL_PROMISE_MAX = 3,
};

public enum EBtlGuiState {
    BTL_STATE_NONE = 0,
    BTL_STATE_TOP = 1,
    BTL_STATE_SKILL = 2,
    BTL_STATE_ITEM = 3,
    BTL_STATE_TARGET = 4,
    BTL_STATE_PROMISE = 5,
    BTL_STATE_TACTICS = 6,
    BTL_STATE_THEURGIA = 7,
    BTL_STATE_ANALYZE = 8,
    BTL_STATE_SHIFT = 9,
    BTL_STATE_STRATEGY = 10,
    BTL_STATE_GUARD = 11,
    BTL_STATE_PERSONASTATUS = 12,
    BTL_STATE_NAVIGATION = 13,
    BTL_STATE_NUM = 14,
    BTL_STATE_MAX = 15,
};

public enum EBtlInputKeyboardEnum {
    BTL_INPUT_KEY_NONE = 0,
    BTL_INPUT_KEY_RU = 1,
    BTL_INPUT_KEY_RR = 2,
    BTL_INPUT_KEY_RL = 3,
    BTL_INPUT_KEY_RD = 4,
    BTL_INPUT_KEY_LU = 5,
    BTL_INPUT_KEY_LR = 6,
    BTL_INPUT_KEY_LL = 7,
    BTL_INPUT_KEY_LD = 8,
    BTL_INPUT_KEY_R1 = 9,
    BTL_INPUT_KEY_L1 = 10,
    BTL_INPUT_KEY_R2 = 11,
    BTL_INPUT_KEY_L2 = 12,
    BTL_INPUT_KEY_R3 = 13,
    BTL_INPUT_KEY_L3 = 14,
    BTL_INPUT_KEY_OPTION = 15,
    BTL_INPUT_KEY_TOUCH = 16,
    BTL_INPUT_MAX = 17,
};

public enum EBattlePhaseName {
    Fighting = 0,
    Dead = 1,
    Escape = 2,
    SerialEncount = 3,
    Result = 4,
    Victory = 5,
    None = 6,
    EBattlePhaseName_MAX = 7,
};

public enum EBtlResultType {
    Normal = 0,
    AllAttack = 1,
    EBtlResultType_MAX = 2,
};

public enum EBtlPhaseType {
    None = 0,
    Fighting = 1,
    Victory = 2,
    Annihilation = 3,
    Escape = 4,
    EscapeSkill = 5,
    Others = 6,
    EBtlPhaseType_MAX = 7,
};

public enum EBtlResidentResource {
    Summon = 0,
    SummonShell = 1,
    HitSlash = 2,
    HitPierce = 3,
    HitStrike = 4,
    ReflectionHit = 5,
    AbsorptionHit = 6,
    PersonaAura = 7,
    PersonaAuraShine = 8,
    ShadowSummon = 9,
    ShadowDead = 10,
    ShadowDeadSplash = 11,
    HitPierceYukariCritical = 12,
    MAX = 13,
};

public enum EBtlShuffleTextLayout {
    CARD_NAME = 0,
    CARD_NAME_POS = 1,
    CARD_HELP = 2,
    CARD_HELP_POS = 3,
    PERSONA_NAME = 4,
    Max = 5,
};

public enum EBtlShuffleLayout {
    ARCANA_SWORDS = 0,
    Max = 1,
};

public enum EBtlResultTextLayout {
    PERSONA_NAME_POS = 0,
    PERSONA_NAME_DOT_OFS_POS = 1,
    ITEM_NAME = 2,
    ITEM_NAME_POS = 3,
    LV_UP_CHARA_NAME_POS = 4,
    LV_UP_PERSONA_NAME = 5,
    LV_UP_PERSONA_NAME_DOT_OFS_POS = 6,
    LV_UP_PERSONA_NAME_POS = 7,
    Max = 8,
};

public enum EBtlResultLayout {
    PERSONA_ARCANA = 0,
    RESULT_HEADLINE_WIDTH = 1,
    RESULT_HELP_TRIANGLE = 2,
    Max = 3,
};

public enum EBtlResultHeroPersonaUpEvent {
    No = 0,
    UpStock8 = 1,
    UpStock10 = 2,
    UpStock12 = 3,
    EBtlResultHeroPersonaUpEvent_MAX = 4,
};

public enum EBtlResultState {
    Init = 0,
    Top = 1,
    Levelup = 2,
    PersonaLvup = 3,
    HeroHumanLevelup = 4,
    HeroPersonaStatus = 5,
    AllyPersonaStatus = 6,
    PersonaStatus = 7,
    End = 8,
    EBtlResultState_MAX = 9,
};

public enum EBtlShakeType {
    BTL_SHAKE_NORMAL = 0,
    BTL_SHAKE_NORMAL_STRONG = 1,
    BTL_SHAKE_SINGLE_SHORT = 2,
    BTL_SHAKE_SINGLE_SHORT_STRONG = 3,
    BTL_SHAKE_SINGLE_LONG = 4,
    BTL_SHAKE_SINGLE_LONG_STRONG = 5,
    BTL_SHAKE_MAX = 6,
};

public enum EBtlShuffleCardRotationState {
    BTL_SHUFFLECARD_ROTATION_WAIT = 0,
    BTL_SHUFFLECARD_ROTATION_PLAYING = 1,
    BTL_SHUFFLECARD_ROTATION_END = 2,
    BTL_SHUFFLECARD_ROTATION_MAX = 3,
};

public enum EBtlShuffleCardAllGetBonusAnimeState {
    BTL_SHUFFLECARD_BONUSANIME_OUTSMALLTAROT = 0,
    BTL_SHUFFLECARD_BONUSANIME_IN = 1,
    BTL_SHUFFLECARD_BONUSANIME_TRANSE = 2,
    BTL_SHUFFLECARD_BONUSANIME_OUT = 3,
    BTL_SHUFFLECARD_BONUSANIME_FINISH = 4,
    BTL_SHUFFLECARD_BONUSANIME_MAX = 5,
};

public enum EBtlShuffleCardSmallTarotState {
    BTL_SHUFFLECARD_TAROTCARD_NORMAL = 0,
    BTL_SHUFFLECARD_TAROTCARD_ALLGETBONUS_ANIME = 1,
    BTL_SHUFFLECARD_TAROTCARD_INVISIBLE = 2,
    BTL_SHUFFLECARD_TAROTCARD_MAX = 3,
};

public enum EBtlShuffleCardEffectSelectState {
    BTL_SHUFFLECARD_EFFECTSELECT_WAIT = 0,
    BTL_SHUFFLECARD_EFFECTSELECT_OUT = 1,
    BTL_SHUFFLECARD_EFFECTSELECT_IN = 2,
    BTL_SHUFFLECARD_EFFECTSELECT_MAX = 3,
};

public enum EBtlShuffleKeyHelpState {
    BTL_SHUFFLE_KEYHELP_NONE = 0,
    BTL_SHUFFLE_KEYHELP_SELECTCARD = 1,
    BTL_SHUFFLE_KEYHELP_SELECTPERSONA = 2,
    BTL_SHUFFLE_KEYHELP_MAX = 3,
};

public enum EBtlShuffleCardState {
    BTL_SHUFFLECARD_WAIT = 0,
    BTL_SHUFFLECARD_SELECT = 1,
    BTL_SHUFFLECARD_MOVE = 2,
    BTL_SHUFFLECARD_DISSOLVE = 3,
    BTL_SHUFFLECARD_MAX = 4,
};

public enum EBtlSkillDirectionTargetType {
    BTL_SKILL_DIR_FRONT = 0,
    BTL_SKILL_DIR_NONE = 1,
    BTL_SKILL_DIR_FRONT_NOT_ROT = 2,
    BTL_SKILL_DIR_NONE_NOT_ROT = 3,
    BTL_SKILL_DIR_MAX = 4,
};

public enum EBtlSkillPositionTargetType {
    BTL_SKILL_POS_TARGETS_ROOT = 0,
    BTL_SKILL_POS_TARGETS_DAMAGE_SOCKET = 1,
    BTL_SKILL_POS_TARGETS_CYLINDER = 2,
    BTL_SKILL_POS_WORLD = 3,
    BTL_SKILL_POS_MAX = 4,
};

public enum EBtlSkillPositionHeightType {
    BTL_SKILL_POS_H_GROUND = 0,
    BTL_SKILL_POS_H_CENTER = 1,
    BTL_SKILL_POS_H_ONHEAD = 2,
    BTL_SKILL_POS_H_MAX = 3,
};

public enum EBtlSkillTargetType {
    BTL_SKILL_TARGET_CHARACTERS = 0,
    BTL_SKILL_TARGET_GROUP = 1,
    BTL_SKILL_TARGET_ENCHANTER = 2,
    BTL_SKILL_TARGET_FIELD_CENTER = 3,
    BTL_SKILL_TARGET_MAX = 4,
};

public enum EBtlDataAttr {
    BTL_DATA_ATTR_SLASH = 0,
    BTL_DATA_ATTR_STRIKE = 1,
    BTL_DATA_ATTR_PIERCE = 2,
    BTL_DATA_ATTR_FIRE = 3,
    BTL_DATA_ATTR_ICE = 4,
    BTL_DATA_ATTR_ELECTRIC = 5,
    BTL_DATA_ATTR_WIND = 6,
    BTL_DATA_ATTR_ALMIGHTY = 7,
    BTL_DATA_ATTR_LIGHT = 8,
    BTL_DATA_ATTR_DARK = 9,
    BTL_DATA_ATTR_CHARM = 10,
    BTL_DATA_ATTR_POISON = 11,
    BTL_DATA_ATTR_UPSET = 12,
    BTL_DATA_ATTR_PANIC = 13,
    BTL_DATA_ATTR_FEAR = 14,
    BTL_DATA_ATTR_ANGER = 15,
    BTL_DATA_ATTR_RECOVERY = 16,
    BTL_DATA_ATTR_SUPPORT = 17,
    BTL_DATA_ATTR_SPECIAL = 18,
    BTL_DATA_ATTR_NON = 19,
    BTL_DATA_ATTR_MAX = 20,
};

public enum EBtlJyokyohelpType {
    NyxCoreHeroRecovery1 = 0,
    NyxCoreHeroRecovery2 = 1,
    NyxCoreHeroRecovery3 = 2,
    AegisOveerheat = 3,
    EBtlJyokyohelpType_MAX = 4,
};

public enum EBtlRelocationType {
    Normal = 0,
    Command = 1,
    Closed = 2,
    Encount = 3,
    WholeForEnchanterBackshot = 4,
    EBtlRelocationType_MAX = 5,
};

public enum EBtlFinishResult {
    None = 0,
    Win = 1,
    Lose = 2,
    Escape = 3,
    Roundup = 4,
    Trafuli = 5,
    EneEscape = 6,
    EBtlFinishResult_MAX = 7,
};

public enum EBtlAttackPerformanceType {
    Normal = 0,
    Long = 1,
    Critical = 2,
    EBtlAttackPerformanceType_MAX = 3,
};

public enum EBtlAttackWeaponAnimType {
    Normal = 0,
    TypeB = 1,
    TypeC = 2,
    TypeOrgia = 3,
    EBtlAttackWeaponAnimType_MAX = 4,
};

public enum EBtlAlloutAttackResult {
    Blank = 0,
    Annihilation = 1,
    DefeatAtLeastOne = 2,
    DefeatNone = 3,
    EBtlAlloutAttackResult_MAX = 4,
};

public enum EBtlTheurgiaBoostType {
    RecoveryFromDown = 0,
    WithPowerCharge = 1,
    WithPowerBoost = 2,
    LowHP = 3,
    LowSP = 4,
    GetTakeover = 5,
    EnemyBadStatus = 6,
    CriticalAttack = 7,
    PersonaSkillWeak = 8,
    PersonaSkillCritical = 9,
    PersonaSkillPhysics = 10,
    PersonaSkillMagic = 11,
    PersonaSkillHeal = 12,
    PersonaSkillSupport = 13,
    PersonaHitBadStatus = 14,
    HighAnalyze = 15,
    EnemyStatusDown = 16,
    TypeMax = 17,
    EBtlTheurgiaBoostType_MAX = 18,
};

public enum EBtlCutsceneBlendType {
    Liner = 0,
    Cubic = 1,
    EaseIN = 2,
    EaseOut = 3,
    EaseInOut = 4,
    EBtlCutsceneBlendType_MAX = 5,
};

public enum EBtlBGMType {
    Fighting = 0,
    Victory = 1,
    EBtlBGMType_MAX = 2,
};

public enum EBtlBadStatusIcon {
    Knockedout = 0,
    Charm = 1,
    Upset = 2,
    Panic = 3,
    Fear = 4,
    Anger = 5,
    Freeze = 6,
    Shock = 7,
    Poison = 8,
    Overlimit = 9,
    Overheat = 10,
    Bomb = 11,
    Dead = 12,
    Down = 13,
    None = 14,
    EBtlBadStatusIcon_MAX = 15,
};

public enum EBtlAnimNotifyHitEffect {
    DefaultType = 0,
    YukariFromAbove = 1,
    MitsuruKick = 2,
    AegisVulcan = 3,
    AegisCanon = 4,
    AegisRifle = 5,
    AegisKick = 6,
    AegisOrgiaAttack = 7,
    AmadaSweep = 8,
    EBtlAnimNotifyHitEffect_MAX = 9,
};

public enum EBtlAnimNotifyPersona {
    Custom = 0,
    SkillShot = 1,
    SkillCamChange = 2,
    FadeoutStart = 3,
    AnimationStop = 4,
    EBtlAnimNotifyPersona_MAX = 5,
};

public enum EBtlAnimNotifyShadow {
    Custom = 0,
    Hit = 1,
    SkillShot = 2,
    SkillCamChange = 3,
    DeadPerformance = 4,
    PersonalMotion = 5,
    AnimationStop = 6,
    BlendToWait = 7,
    ShowWeaponEffect = 8,
    EBtlAnimNotifyShadow_MAX = 9,
};

public enum EBtlAnimNotify {
    Custom = 0,
    Hit = 1,
    SummonActBurst = 2,
    HideWeapon = 3,
    ShowWeapon = 4,
    HideGun = 5,
    ShowGun = 6,
    ShiftPersonaSkill = 7,
    AnimationStop = 8,
    HitSub = 9,
    BlendToWait = 10,
    ItemUse = 11,
    PersonalMotion = 12,
    BackstepLoop = 13,
    PlayCriticalAttackCamera = 14,
    SyncDeadAnim = 15,
    SkillAct = 16,
    SkillCamChange = 17,
    SkillActEffect = 18,
    BlendToCommandWait = 19,
    EBtlAnimNotify_MAX = 20,
};

public enum EBtlSkillCameraType {
    NORMAL = 0,
    DYNAMIC = 1,
    CUTIN = 2,
    EBtlSkillCameraType_MAX = 3,
};

public enum EBtlAttackType {
    SLASH = 0,
    PIERCE = 1,
    STRIKE = 2,
    EBtlAttackType_MAX = 3,
};

public enum EBtlEventAreaType {
    BTL_AREA_NULL = 0,
    BTL_AREA_INVOKE = 1,
    BTL_AREA_PARTY_TEAM = 2,
    BTL_AREA_TARGET = 3,
    BTL_AREA_ENEMY_TEAM = 4,
    BTL_AREA_PARTY_MEMBER1 = 5,
    BTL_AREA_PARTY_MEMBER2 = 6,
    BTL_AREA_PARTY_MEMBER3 = 7,
    BTL_AREA_NUM = 8,
    BTL_AREA_MAX = 9,
};

public enum EBtlPersonaSceneAnimationType {
    BTL_ANIM_THEURGIA_A = 0,
    BTL_ANIM_THEURGIA_A_LOOP = 1,
    BTL_ANIM_THEURGIA_B = 2,
    BTL_ANIM_THEURGIA_B_LOOP = 3,
    BTL_ANIM_MIXRAID_A = 4,
    BTL_ANIM_MIXRAID_A_LOOP = 5,
    BTL_ANIM_MAX = 6,
};

public enum EBtlPersonaAnimationType {
    BTL_ANIM_NULL = 0,
    BTL_ANIM_WAIT = 1,
    BTL_ANIM_ATTACK = 2,
    BTL_ANIM_MAGIC = 3,
    BTL_ANIM_SKILL_END = 4,
    BTL_ANIM_THEURGIA_A = 5,
    BTL_ANIM_THEURGIA_B = 6,
    BTL_ANIM_NUM = 7,
    BTL_ANIM_MAX = 8,
};

public enum EBtlSceneAnimationType {
    BTL_S_ANIM_NULL = 0,
    BTL_S_ANIM_ALLOUT_START_1 = 1,
    BTL_S_ANIM_ALLOUT_START_2 = 2,
    BTL_S_ANIM_ALLOUT_START_3 = 3,
    BTL_S_ANIM_ALLOUT_START_4 = 4,
    BTL_S_ANIM_ALLOUT_LAST = 5,
    BTL_S_ANIM_SHUFFLE_START = 6,
    BTL_S_ANIM_SHUFFLE_END = 7,
    BTL_S_ANIM_SHUFFLE_LOOP = 8,
    BTL_S_ANIM_TAKEOVER_FROM = 9,
    BTL_S_ANIM_TAKEOVER_TO = 10,
    BTL_S_ANIM_THEURGIA_A = 11,
    BTL_S_ANIM_THEURGIA_B = 12,
    BTL_S_ANIM_MIXRAID_A = 13,
    BTL_S_ANIM_MIXRAID_B = 14,
    BTL_S_ANIM_MIXRAID_C = 15,
    BTL_S_ANIM_MIXRAID_D = 16,
    BTL_S_ANIM_MIXRAID_E = 17,
    BTL_S_ANIM_MIXRAID_F = 18,
    BTL_S_ANIM_MIXRAID_G = 19,
    BTL_S_ANIM_RESULT_MAIN = 20,
    BTL_S_ANIM_RESULT_SUB = 21,
    BTL_S_ANIM_SUMMON_LOOP = 22,
    BTL_S_ANIM_SUMMON_ACT = 23,
    BTL_S_ANIM_OVERHEAT_1 = 24,
    BTL_S_ANIM_OVERHEAT_2 = 25,
    BTL_S_ANIM_OVERHEAT_3 = 26,
    BTL_S_ANIM_THEURGIA_A_END = 27,
    BTL_S_ANIM_MAX = 28,
};

public enum EBtlAnimationType {
    BTL_ANIM_NULL = 0,
    BTL_ANIM_WAIT = 1,
    BTL_ANIM_WAIT_NORMAL = 2,
    BTL_ANIM_WAIT_DYING = 3,
    BTL_ANIM_DAMAGED = 4,
    BTL_ANIM_COMMAND_WAIT = 5,
    BTL_ANIM_COMMAND_WAIT_LOOP = 6,
    BTL_ANIM_SUMMON_START = 7,
    BTL_ANIM_SUMMON_LOOP = 8,
    BTL_ANIM_SUMMON_ACT = 9,
    BTL_ANIM_SUMMON_CANCEL = 10,
    BTL_ANIM_SUMMON_END = 11,
    BTL_ANIM_SKILL_CHANT = 12,
    BTL_ANIM_SKILL_SHOT = 13,
    BTL_ANIM_SKILL_SHOT_LOOP = 14,
    BTL_ANIM_SKILL_SHOT_END = 15,
    BTL_ANIM_DEAD = 16,
    BTL_ANIM_DOWN = 17,
    BTL_ANIM_WAKE_UP = 18,
    BTL_ANIM_DEAD_START = 19,
    BTL_ANIM_DEAD_SHORT = 20,
    BTL_ANIM_RUN = 21,
    BTL_ANIM_WALK = 22,
    BTL_ANIM_DOWN_LOOP = 23,
    BTL_ANIM_AVOID = 24,
    BTL_ANIM_ITEM_START = 25,
    BTL_ANIM_ITEM_USE = 26,
    BTL_ANIM_ITEM_CANCEL = 27,
    BTL_ANIM_REVIVAL = 28,
    BTL_ANIM_GUARD = 29,
    BTL_ANIM_GUARD_CANCEL = 30,
    BTL_ANIM_PERSONAL = 31,
    BTL_ANIM_PERSONA_CHANGE = 32,
    BTL_ANIM_SPECIAL_01_CHANT = 33,
    BTL_ANIM_SPECIAL_02_CHANT = 34,
    BTL_ANIM_SPECIAL_03_CHANT = 35,
    BTL_ANIM_SPECIAL_04_CHANT = 36,
    BTL_ANIM_SPECIAL_01 = 37,
    BTL_ANIM_SPECIAL_02 = 38,
    BTL_ANIM_SPECIAL_03 = 39,
    BTL_ANIM_SPECIAL_04 = 40,
    BTL_ANIM_SPECIAL_01_END = 41,
    BTL_ANIM_SPECIAL_02_END = 42,
    BTL_ANIM_SPECIAL_03_END = 43,
    BTL_ANIM_SPECIAL_04_END = 44,
    BTL_ANIM_TALK_A_START = 45,
    BTL_ANIM_TALK_A_END = 46,
    BTL_ANIM_TALK_B_START = 47,
    BTL_ANIM_TALK_B_END = 48,
    BTL_ANIM_TALK_C_START = 49,
    BTL_ANIM_TALK_C_END = 50,
    BTL_ANIM_TALK_D_START = 51,
    BTL_ANIM_TALK_D_END = 52,
    BTL_ANIM_BACKSTEP_START = 53,
    BTL_ANIM_BACKSTEP_LOOP = 54,
    BTL_ANIM_BACKSTEP_END = 55,
    BTL_ANIM_RUNAWAY = 56,
    BTL_ANIM_RUN_STOP = 57,
    BTL_ANIM_DEAD_LOOP = 58,
    BTL_ANIM_EVENT_1 = 59,
    BTL_ANIM_EVENT_2 = 60,
    BTL_ANIM_EVENT_3 = 61,
    BTL_ANIM_EVENT_4 = 62,
    BTL_ANIM_ATTACK = 63,
    BTL_ANIM_ATTACK_SINGLE = 64,
    BTL_ANIM_ATTACK_MISS = 65,
    BTL_ANIM_ATTACK_LONG = 66,
    BTL_ANIM_CRITICAL = 67,
    BTL_ANIM_ATTACK_B = 68,
    BTL_ANIM_ATTACK_B_SINGLE = 69,
    BTL_ANIM_ATTACK_B_MISS = 70,
    BTL_ANIM_ATTACK_B_LONG = 71,
    BTL_ANIM_CRITICAL_B = 72,
    BTL_ANIM_ATTACK_C = 73,
    BTL_ANIM_ATTACK_C_SINGLE = 74,
    BTL_ANIM_ATTACK_C_MISS = 75,
    BTL_ANIM_ATTACK_C_LONG = 76,
    BTL_ANIM_CRITICAL_C = 77,
    BTL_ANIM_EX_CHANT = 78,
    BTL_ANIM_EX_SKILL_SHOT = 79,
    BTL_ANIM_EX_SKILL_END = 80,
    BTL_ANIM_NUM = 81,
    BTL_ANIM_MAX = 82,
};

public enum EBtlCommandType {
    BTL_ACT_NULL = 0,
    BTL_ACT_ATTACK = 1,
    BTL_ACT_SKILL = 2,
    BTL_ACT_ITEM = 3,
    BTL_ACT_ESCAPE = 4,
    BTL_ACT_GUARD = 5,
    BTL_ACT_SKIP = 6,
    BTL_ACT_TAKEOVER = 7,
    BTL_ACT_SUMMON = 8,
    BTL_ACT_WAIT = 9,
    BTL_ACT_BADSTATUS_ACTION = 10,
    BTL_ACT_THEURGIA = 11,
    BTL_ACT_FAILURE_WAIT = 12,
    BTL_ACT_RUSH = 13,
    BTL_ACT_NUM = 14,
    BTL_ACT_MAX = 15,
};

public enum EBtlSoundType {
    START = 50,
    BTL_VOICE_HERO = 51,
    BTL_VOICE_YUKARI = 52,
    BTL_VOICE_JUNPEI = 53,
    BTL_VOICE_SANADA = 54,
    BTL_VOICE_MITURU = 55,
    BTL_VOICE_FUKA = 56,
    BTL_VOICE_AEGIS = 57,
    BTL_VOICE_AMADA = 58,
    BTL_VOICE_KOROMARU = 59,
    BTL_VOICE_ARAGAKI = 60,
    BTL_VOICE_ENEMY1 = 70,
    BTL_VOICE_ENEMY2 = 71,
    BTL_VOICE_ENEMY3 = 72,
    BTL_VOICE_ENEMY4 = 73,
    BTL_VOICE_ENEMY5 = 74,
    EBtlSoundType_MAX = 75,
};

public enum ECldSceneChangeType {
    None = 0,
    TimeChange = 1,
    DayChange = 2,
    ECldSceneChangeType_MAX = 3,
};

public enum ECldSeasonClothType {
    Summer = 0,
    Winter = 1,
    ECldSeasonClothType_MAX = 2,
};

public enum ECldDayDispState {
    On = 0,
    Off = 1,
    ECldDayDispState_MAX = 2,
};

public enum ECldMoonAge {
    Moon01 = 0,
    Moon02 = 1,
    Moon03 = 2,
    Moon04 = 3,
    Moon05 = 4,
    Moon06 = 5,
    Moon07 = 6,
    Moon08 = 7,
    Moon09 = 8,
    Moon10 = 9,
    Moon11 = 10,
    Moon12 = 11,
    Moon13 = 12,
    Moon14 = 13,
    Moon15 = 14,
    Moon16 = 15,
    Moon17 = 16,
    Moon18 = 17,
    Moon19 = 18,
    Moon20 = 19,
    Moon21 = 20,
    Moon22 = 21,
    Moon23 = 22,
    Moon24 = 23,
    Moon25 = 24,
    Moon26 = 25,
    Moon27 = 26,
    Moon28 = 27,
    Moon29 = 28,
    Moon30 = 29,
    MoonMax = 30,
    ECldMoonAge_MAX = 31,
};

public enum ECldWeek {
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    WeekMax = 7,
    ECldWeek_MAX = 8,
};

public enum ECldTimeZone {
    None = 0,
    EarlyMorning = 1,
    Morning = 2,
    AM = 3,
    Noon = 4,
    PM = 5,
    AfterSchool = 6,
    Night = 7,
    Shadow = 8,
    Midnight = 9,
    TimeMax = 10,
    ECldTimeZone_MAX = 11,
};

public enum ECldSeason {
    Spring = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 3,
    SeasonMax = 4,
    ECldSeason_MAX = 5,
};

public enum EUIGaussType {
    VeryWeak1 = 0,
    Weak2 = 1,
    Normal3 = 2,
    Strong4 = 3,
    VeryStrong5 = 4,
    MostWeak0 = 5,
    Off = 6,
    EUIGaussType_MAX = 7,
};

public enum ECldCmnDataBpClass {
    SchedulerEveryDay = 0,
    SchedulerEveryTime = 1,
    Max = 2,
};

public enum ECldDateMsgPeriod {
    Single = 0,
    Start = 1,
    Mid = 2,
    End = 3,
    ECldDateMsgPeriod_MAX = 4,
};

public enum ECldDateColor {
    Normal = 0,
    Red = 1,
    ECldDateColor_MAX = 2,
};

public enum EBtlCommonNameIndex {
    BTL_COMMON_NAME_DEFENCE = 0,
    BTL_COMMON_NAME_SUMMON = 1,
    BTL_COMMON_NAME_ESCAPE = 2,
    BTL_COMMON_NAME_OPERATION = 3,
    BTL_COMMON_NAME_ATTACK = 10,
    BTL_COMMON_NAME_MAX = 11,
};

public enum EDifficultySelectionLayout {
    DIFFICULT_SELECTION_TEXT = 0,
    DIFFICULT_SELECTION_INFO_TEXT = 1,
    DIFFICULT_SELECTION_ROW = 2,
    DIFFICULT_SELECTION_INFO_ROW = 3,
    LIST_ROOT_POS = 4,
    PEACEFUL_POS_OFFSET = 5,
    EASY_POS_OFFSET = 6,
    NORMAL_POS_OFFSET = 7,
    HARD_POS_OFFSET = 8,
    LUNATIC_POS_OFFSET = 9,
    LIST_CURSOR = 10,
    MASK_WIDTH = 11,
    MASK_OFFSET = 12,
    MAX = 13,
};

public enum EAdcType {
    COSTUME_SET_1 = 0,
    COSTUME_SET_2 = 1,
    COSTUME_SET_3 = 2,
    PERSONA_SET_1 = 3,
    PERSONA_SET_2 = 4,
    PERSONA_SET_3 = 5,
    BGM_SET_1 = 6,
    BGM_SET_2 = 7,
    ITEM_SET1 = 8,
    SEASON_BGM_SET_1 = 9,
    SEASON_BGM_SET_2 = 10,
    COSTUME_SET_4 = 11,
    SEASON_BGM_SET_3 = 12,
    SEASON_BGM_SET_4 = 13,
    MAX = 14,
};

public enum EAdcCategory {
    COSTUME_SET = 0,
    PERSONA_SET = 1,
    BGM_SET = 2,
    ITEM_SET = 3,
    EXPASS_SET = 4,
    MAX = 5,
};

public enum EEvtManagerState {
    EVTM_BC_Playing = 0,
    EVTM_A_Playing = 1,
    EVTM_Playing = 2,
    EVTM_BackLog = 3,
    EVTM_NetAnswer = 4,
    EVTM_A_Skip = 5,
    TS_Exit = 6,
    TS_Num = 7,
    EEvtManagerState_MAX = 8,
};

public enum EFadeMode {
    Idle = 0,
    In = 1,
    Out = 2,
    EFadeMode_MAX = 3,
};

public enum EFadingState {
    Blank = 0,
    Filled = 1,
    Running = 2,
    EFadingState_MAX = 3,
};

public enum EFldShapeCompType {
    LinkAnimHit = 0,
    EFldShapeCompType_MAX = 1,
};

public enum EFldActorType {
    Player = 0,
    Door = 1,
    AnimObj = 2,
    LinkAnimObj = 3,
    HitActor = 4,
    Npc = 5,
    CmmNpc = 6,
    Animal = 7,
    PlayerStart = 8,
    CrowdManager = 9,
    CrowdTarget = 10,
    TargetIcon = 11,
    EFldActorType_MAX = 12,
};

public enum EFldAnimalMotion_BIRD {
    Blank = 0,
    Idle = 1,
    Walk = 2,
    Run = 3,
    PersonalAction00 = 4,
    PersonalAction01 = 5,
    FlyAway = 6,
    ComeBack = 7,
    FlyIdol = 8,
    EFldAnimalMotion_MAX = 9,
};

public enum EFldAnimalMotion_CAT {
    Blank = 0,
    Idle_Stand = 1,
    Idle_Sit = 2,
    Walk = 3,
    Run = 4,
    To_Stand = 5,
    To_Sit = 6,
    PersonalAction00_Stand = 7,
    PersonalAction01_Stand = 8,
    PersonalAction00_Sit = 9,
    PersonalAction01_Sit = 10,
    Max = 11,
};

public enum EFldLoadPersistentType {
    Daily = 0,
    Dungeon = 1,
    Max = 2,
};

public enum EFldBpRetBool {
    FldBpTrue = 0,
    FldBpFalse = 1,
    EFldBpRetBool_MAX = 2,
};

public enum EFldBpRetFlag {
    FldBpOn = 0,
    FldBpOff = 1,
    EFldBpRetFlag_MAX = 2,
};

public enum EFldCameraForwardType {
    Camera = 0,
    WorldX = 1,
    WorldInverseX = 2,
    WorldY = 3,
    WorldInverseY = 4,
    Free = 5,
    SplinePath = 6,
    EFldCameraForwardType_MAX = 7,
};

public enum EFldCameraBehaviorFreeState {
    None = 0,
    Free = 1,
    ZoomAnim = 2,
    MoveToDefault = 3,
    EFldCameraBehaviorFreeState_MAX = 4,
};

public enum EFldCharAccessIconType {
    Fukidashi = 0,
    Talk = 1,
    Zawazawa = 2,
    Hisoiso = 3,
    Butsubutsu = 4,
    Bosoboso = 5,
    Max = 6,
};

public enum EFldCharAttackAnimNotifyFlag {
    None = 0,
    Collision = 1,
    Orbit = 2,
    Encount = 3,
    EFldCharAttackAnimNotifyFlag_MAX = 4,
};

public enum EFldCharKeyType {
    Triangle = 1,
    Ok_Cross = 2,
    Square = 3,
    Cancel_Circle = 4,
    Up = 5,
    Down = 6,
    Right = 7,
    Left = 8,
    L1 = 9,
    L2 = 10,
    L3 = 11,
    R1 = 12,
    R2 = 13,
    R3 = 14,
    OPTION = 15,
    TOUCH = 16,
    EFldCharKeyType_MAX = 17,
};

public enum EFldCmmNpcType {
    Cmm = 0,
    Normal = 1,
    Max = 2,
};

public enum EFldCmnDataBpClass {
    NpcIconActor_Normal = 0,
    NpcIconActor_Talk = 1,
    NpcIconActor_Cmm = 2,
    NpcIconActor_Cmm_Reverse = 3,
    NpcIconActor_Cmm_Object = 4,
    NpcIconActor_Quest = 5,
    NpcIconActor_MaleQuest = 6,
    NpcIconActor_MaleQuest_Object = 7,
    NpcIconActor_Dormitory = 8,
    NpcIconActor_Study = 9,
    NpcIconActor_Koromaru = 10,
    NpcIconActor_Readed_Normal = 11,
    NpcIconActor_Readed_Talk = 12,
    WordIconActor_00 = 13,
    WordIconActor_Readed_00 = 14,
    WordIconActor_01 = 15,
    WordIconActor_Readed_01 = 16,
    WordIconActor_02 = 17,
    WordIconActor_03 = 18,
    Props_HeroPhone = 19,
    CameraShakeActor = 20,
    Max = 21,
};

public enum EFldDataTable {
    SubLevelList = 0,
    VariationSubLevelList = 1,
    CrowdSubLevelList = 2,
    BgmList = 3,
    NpcTypeList = 4,
    PlayerCostumeList = 5,
    ShortcutNameList = 6,
    PlaceNameList = 7,
    HitNameList_Daily = 8,
    HitNameList_Dungeon = 9,
    NpcNameList = 10,
    TvProgram = 11,
    MailOrder = 12,
    CrowdWalkInit = 13,
    SortieMember = 14,
    LmapCmmNpcLayout = 15,
    LmapNpcLayout = 16,
    TemporalAAList = 17,
    PersonalMotionList = 18,
    PoolPack = 19,
    PoolPack_PLAYGO = 20,
    PoolConnect = 21,
    RaytraceSettingList = 22,
    Max = 23,
};

public enum EFldCrowdRoutePtn {
    Normal = 0,
    Outward = 1,
    Return = 2,
    EFldCrowdRoutePtn_MAX = 3,
};

public enum EFldCrowdTime {
    None = 0,
    Noon = 1,
    Evening = 2,
    Night = 3,
    Shadow = 4,
    Max = 5,
};

public enum EFldCrowdSeason {
    None = 0,
    Winter = 1,
    Summer = 2,
    EndTime = 3,
    Max = 4,
};

public enum EFldDoorOpenType {
    OpenFront = 0,
    OpenBack = 1,
    EFldDoorOpenType_MAX = 2,
};

public enum EEncountEnemyType {
    Blank = 0,
    Normal = 1,
    Strong = 2,
    Rare = 3,
    Death = 4,
    Num = 5,
    EEncountEnemyType_MAX = 6,
};

public enum EEncountType {
    Blank = 0,
    Normal = 1,
    Chance = 2,
    Pinch = 3,
    Friend = 4,
    Num = 5,
    EEncountType_MAX = 6,
};

public enum EDungeonBattleRetType {
    None = 0,
    Win = 1,
    Lose = 2,
    Escape = 3,
    Roundup = 4,
    Trafuli = 5,
    EneEscape = 6,
    Max = 7,
};

public enum EDungeonTBoxType {
    Normal = 0,
    Rare = 1,
    Jewelry = 2,
    PrimField = 3,
    Medal1 = 4,
    Medal2 = 5,
    Medal3 = 6,
    Medal4 = 7,
    Medal5 = 8,
    Medal6 = 9,
    Num = 10,
    UseNum = 7,
    EDungeonTBoxType_MAX = 11,
};

public enum EDungeonEnemyType {
    Normal = 0,
    Strong = 1,
    Rare = 2,
    Death = 3,
    Gatekeeper = 4,
    Num = 5,
    EDungeonEnemyType_MAX = 6,
};

public enum EDungeonFieldType {
    Auto = 0,
    Fixed = 1,
    Design = 2,
    Num = 3,
    EDungeonFieldType_MAX = 4,
};

public enum EDungeonEffectType {
    Dark = 0,
    HeroAttack = 1,
    EnemyAttack = 2,
    TartarosSearch = 3,
    Num = 4,
    EDungeonEffectType_MAX = 5,
};

public enum EDungeonEnemyGroup {
    Normal = 0,
    ForbiddenDoor = 1,
    EDungeonEnemyGroup_MAX = 2,
};

public enum EDungeonEnvType {
    CharaLight = 0,
    ShadowTimeFilter = 1,
    Num = 2,
    EDungeonEnvType_MAX = 3,
};

public enum EDungeonEventTransOriginType {
    Part = 0,
    ObjectInfo = 1,
    TBox = 2,
    Clock = 3,
    Enemy = 4,
    DirectEnemy = 5,
    MissingNPC = 6,
    SecretGate = 7,
    RefActor = 99,
    EDungeonEventTransOriginType_MAX = 100,
};

public enum EDungeonObjectInfoType {
    Goal = 0,
    FDoor = 1,
    EDungeonObjectInfoType_MAX = 2,
};

public enum EDungeonInfoType {
    Object = 0,
    EDungeonInfoType_MAX = 1,
};

public enum ELayoutStartType {
    StartPart = 0,
    Transfer = 1,
    EventBattle = 2,
    ForbiddenDoor = 3,
    ForbiddenDoorRet = 4,
    FreeID = 5,
    Partner = 6,
    FieldEvent = 7,
    ELayoutStartType_MAX = 8,
};

public enum ELayoutDirType {
    Up = 0,
    Left = 1,
    Down = 2,
    Right = 3,
    ELayoutDirType_MAX = 4,
};

public enum ELayoutUsageType {
    Normal = 0,
    FixedFloor = 1,
    MonadPassage = 2,
    ForbiddenDoor = 3,
    ELayoutUsageType_MAX = 4,
};

public enum ELayoutGroup {
    Blank = 0,
    G_01 = 1,
    G_02 = 2,
    G_03 = 3,
    G_04 = 4,
    G_05 = 5,
    G_06 = 6,
    G_07 = 7,
    G_08 = 8,
    G_09 = 9,
    G_10 = 10,
    G_11 = 11,
    G_12 = 12,
    G_13 = 13,
    G_14 = 14,
    G_15 = 15,
    G_16 = 16,
    ELayoutGroup_MAX = 17,
};

public enum ELayoutType {
    Blank = 0,
    StartPos = 1,
    Enemy = 10,
    DirectEnemy = 20,
    EnemyPath = 100,
    TBox = 30,
    DirectTBox = 40,
    RetDev = 50,
    NPC = 60,
    Broken = 70,
    Reaper = 80,
    Clock = 90,
    SecretGate = 110,
    ELayoutType_MAX = 111,
};

public enum EDungeonObjType {
    Blank = 0,
    TBoxNormal = 1,
    TBoxRare = 2,
    TBoxJewelry = 3,
    TBoxPrimField = 4,
    ReturnDevice = 10,
    TransferDevice = 11,
    MonadReturnDevice = 15,
    MonadTransferDevice = 16,
    TBoxMedal1 = 21,
    TBoxMedal2 = 22,
    TBoxMedal3 = 23,
    Broken1 = 30,
    Broken2 = 31,
    Broken3 = 32,
    BrokenFragment = 39,
    Clock = 40,
    ClockFloorEntrance = 50,
    Gimmick = 100,
    EDungeonObjType_MAX = 101,
};

public enum EDungeonLevelPathType {
    Blank = 0,
    Floor = 1,
    Environment = 2,
    NavMesh = 3,
    EDungeonLevelPathType_MAX = 4,
};

public enum EDungeonBfBmdPathGroup {
    BattleEnd = 0,
    FloorPreLoad = 1,
    Hit = 2,
    SupportTalk = 3,
    Debug = 4,
    Num = 5,
    EDungeonBfBmdPathGroup_MAX = 6,
};

public enum EDungeonPathGroup {
    G_01 = 0,
    G_02 = 1,
    G_03 = 2,
    G_04 = 3,
    G_05 = 4,
    G_06 = 5,
    Num = 6,
    EDungeonPathGroup_MAX = 7,
};

public enum EDungeonPathType {
    Blank = 0,
    PartNiagara = 1,
    Part = 2,
    PartWall = 3,
    FDoorPart = 4,
    Environment = 5,
    EffectNiagara = 6,
    Effect = 7,
    EnemyNiagara = 8,
    Enemy = 9,
    Enemy_Unique = 10,
    Enemy_Boss = 11,
    Enemy_FBD = 12,
    TBoxNiagara = 13,
    TBoxObj = 14,
    TBox = 15,
    TBoxSE = 16,
    BrokenObjNiagara = 17,
    BrokenObj = 18,
    ReturnDev = 19,
    Clock = 20,
    SecretGate = 21,
    CameraAttachNiagara = 22,
    SupportSkill = 23,
    Reaper = 24,
    AutoRecover = 25,
    Partner = 26,
    Missing = 27,
    MisNpcTypeSE = 28,
    BfBmd = 29,
    EnemyModel = 30,
    BtlEnemyModel = 31,
    UI = 32,
    Sprite = 33,
    EncountChara = 34,
    BattleResident = 35,
    BattleResidentBackLoad = 36,
    BattleField = 37,
    ParamData = 38,
    Niagara = 39,
    CheckMode = 40,
    Num = 41,
    EDungeonPathType_MAX = 42,
};

public enum EDungeonMisNpcType {
    MALE_01 = 0,
    MALE_02 = 1,
    MALE_03 = 2,
    MALE_04 = 3,
    FEMALE_01 = 4,
    FEMALE_02 = 5,
    FEMALE_03 = 6,
    FEMALE_04 = 7,
    CAT_01 = 8,
    EDungeonMisNpcType_MAX = 9,
};

public enum EDungeonResetDataType {
    Flag = 0,
    Counter = 1,
    EDungeonResetDataType_MAX = 2,
};

public enum EDungeonResetTiming {
    Blank = 0,
    FieldInit = 1,
    SetupEnd = 2,
    EDungeonResetTiming_MAX = 3,
};

public enum EDungeonTrophyType {
    ChanceEncount = 0,
    EDungeonTrophyType_MAX = 1,
};

public enum EPartDirType {
    Up = 0,
    Right = 1,
    Down = 2,
    Left = 3,
    EPartDirType_MAX = 4,
};

public enum EPartType {
    Blank0 = 0,
    FloorStart = 1,
    Straight = 2,
    Lshape = 3,
    Tshape = 4,
    Croshape = 5,
    DeadEnd = 6,
    RoomA = 7,
    RoomB = 8,
    MissingRoom = 9,
    ForbiddenDoor = 10,
    FloorEnd = 11,
    Blank12 = 12,
    Num = 13,
    Wall = 20,
    EPartType_MAX = 21,
};

public enum EDungeonSuondType {
    EnvSE = 0,
    MissingSE = 1,
    TBoxSE = 2,
    EDungeonSuondType_MAX = 3,
};

public enum EDungeonUIFontStyle {
    Small = 0,
    Medium = 1,
    EDungeonUIFontStyle_MAX = 2,
};

public enum EDungeonUISpriteOrigin {
    LeftUp = 0,
    RightUp = 1,
    Center = 2,
    LeftCenter = 3,
    RightCenter = 4,
    CenterDown = 5,
    RightDown = 6,
    EDungeonUISpriteOrigin_MAX = 7,
};

public enum EDungeonUIBlendStateType {
    Default = 0,
    Mul = 1,
    Add = 2,
    EDungeonUIBlendStateType_MAX = 3,
};

public enum EDungeonUISpriteType {
    SituationHelp = 0,
    Num = 1,
    EDungeonUISpriteType_MAX = 2,
};

public enum EDungeonUIType {
    SituationHelp = 0,
    Num = 1,
    EDungeonUIType_MAX = 2,
};

public enum EFldEnemyState {
    None = 0,
    Standby = 1,
    Alive = 2,
    Dead = 3,
    Execution = 4,
    EFldEnemyState_MAX = 5,
};

public enum EFldEnemyType {
    Normal = 0,
    Strong = 1,
    Rare = 2,
    Death = 3,
    Gatekeeper = 4,
    ForbiddenDoor = 5,
    EFldEnemyType_MAX = 6,
};

public enum EFldHitActorIconType {
    None = 0,
    Quest = 1,
    Max = 2,
};

public enum EFldHitType {
    Normal = 0,
    AreaChange = 1,
    EFldHitType_MAX = 2,
};

public enum EFldHitCharaHeroMotion {
    Speak = 0,
    Listen = 1,
    EFldHitCharaHeroMotion_MAX = 2,
};

public enum EFldHitCharaIconAttachedType {
    Auto = 0,
    ModelTop = 1,
    ModelNeck = 2,
    ModelCenter = 3,
    ModelRoot = 4,
    CollisionTop = 5,
    OwnActor = 6,
    EFldHitCharaIconAttachedType_MAX = 7,
};

public enum EFldHitCharaIconType {
    None = 0,
    Normal = 1,
    Talk = 2,
    Cmm = 3,
    Cmm_Normal = 4,
    Cmm_Reverse = 5,
    Cmm_Object = 6,
    Quest = 7,
    MaleQuest = 8,
    MaleQuest_Object = 9,
    Dormitory = 10,
    Study = 11,
    Koromaru = 12,
    WORD_13 = 13,
    WORD_14 = 14,
    WORD_15 = 15,
    WORD_16 = 16,
    Max = 17,
    TargetOnly = 18,
    QuestHit = 19,
};

public enum EFldHitCoreCheckIconType {
    Check = 0,
    Speak = 1,
    Listen = 2,
    Goto = 3,
    Action = 4,
    Shop = 5,
    None = 6,
    Max = 7,
};

public enum FFldHitCoreHeroDirectType {
    None = 0,
    Center = 1,
    Front = 2,
    Back = 3,
    Left = 4,
    Right = 5,
    BackNG = 6,
    Max = 7,
};

public enum EFldKeyHelpType {
    Common = 0,
    Daily = 1,
    Dungeon = 2,
    Max = 3,
};

public enum EFldLevelLoaderType {
    Load = 0,
    Unload = 1,
    EFldLevelLoaderType_MAX = 2,
};

public enum EFldLoadCrowdType {
    Auto = 0,
    Parant = 1,
    Child01 = 2,
    Child02 = 3,
    Holiday = 4,
    Sale = 5,
    Target = 6,
    Max = 7,
};

public enum EFldLoadPattern {
    All = 0,
    BgOnly = 1,
    BgMob = 2,
    BgHit = 3,
    BgNpc = 4,
    BgCmm = 5,
    KeyFreeEvent = 6,
    Dungeon = 7,
    Load = 8,
    ExceptEnv = 9,
    TimeChanged = 10,
    Max = 11,
};

public enum EShadowSettingCategory {
    FIELD = 0,
    DUNGEONPARTS = 1,
    EVENT_MAIN = 2,
    EVENT_CMMU = 3,
    EShadowSettingCategory_MAX = 4,
};

public enum EFldLmapData_QuestType {
    Npc = 0,
    Target = 1,
    Hit = 2,
    EFldLmapData_MAX = 3,
};

public enum EFldLmapData_NpcType {
    None = 0,
    MaleQuest = 1,
    Dormitory = 2,
    Koromaru = 3,
    Quest = 4,
    EFldLmapData_MAX = 5,
};

public enum EFldMailOrderType {
    Buy = 0,
    Receive = 1,
    Max = 2,
};

public enum EFldCmnProps {
    HeroPhone = 0,
    Max = 1,
};

public enum EFldType {
    DailyField = 0,
    DungeonField = 1,
    Max = 2,
};

public enum EFldMiniMapType_NPC {
    Normal = 0,
    Cmm = 1,
    Cmm_Reverse = 2,
    MaleQuest = 3,
    Dormitory = 4,
    Study = 5,
    Koromaru = 6,
    Cmm_Object = 7,
    Quest = 8,
    EFldMiniMapType_MAX = 9,
};

public enum FFldMiscCharBaseReload_Type {
    ALL = 0,
    WeaponOnly = 1,
    FFldMiscCharBaseReload_MAX = 2,
};

public enum EFldNpcActorType {
    Normal = 0,
    Special = 1,
    Target = 2,
    Hit = 3,
    EFldNpcActorType_MAX = 4,
};

public enum EFldNpcModelType {
    Main = 0,
    Sub = 1,
    ColorMob = 2,
    EFldNpcModelType_MAX = 3,
};

public enum EFldOperatorKeyState {
    None = 0,
    Disable = 1,
    EnablePrepare = 2,
    Enable = 3,
    EFldOperatorKeyState_MAX = 4,
};

public enum EFldOperatorState {
    None = 0,
    Free = 1,
    Encounting = 2,
    DailyMenu = 3,
    DungeonMenu = 4,
    AutoRecover = 5,
    Camp = 6,
    LargeMap = 7,
    BackLog = 8,
    VoiceActionDisp = 9,
    Save = 10,
    Battle = 11,
    Event = 12,
    EventEnd = 13,
    DebugCamera = 14,
    EFldOperatorState_MAX = 15,
};

public enum EFldOperatorEncountType {
    None = 0,
    Normal = 1,
    Chance = 2,
    Assault = 3,
    AssaultChance = 4,
    Pinch = 5,
    EFldOperatorEncountType_MAX = 6,
};

public enum EFldPartnerBehavior {
    None = 0,
    Idel = 1,
    TrackingFar = 2,
    TrackingNear = 3,
    Avoid = 4,
    Adjustment = 5,
    EFldPartnerBehavior_MAX = 6,
};

public enum EFldPartnerState {
    None = 0,
    Standby = 1,
    EndBattle = 2,
    Execution = 3,
    EFldPartnerState_MAX = 4,
};

public enum ESearchPriority {
    Standard = 0,
    Enemy = 1,
    ESearchPriority_MAX = 2,
};

public enum EFldPlayerSpeedState {
    None = 0,
    Walk = 1,
    Run = 2,
    Dash = 3,
    Assault = 4,
    EFldPlayerSpeedState_MAX = 5,
};

public enum EFldPlayerState {
    None = 0,
    Standby = 1,
    EndBattle = 2,
    Execution = 3,
    EFldPlayerState_MAX = 4,
};

public enum EFldPlayerDailyBehavior {
    None = 0,
    Free = 1,
    Turn = 2,
    EFldPlayerDailyBehavior_MAX = 3,
};

public enum EFldPlayerDngBehavior {
    None = 0,
    Free = 1,
    Turn = 2,
    Brake = 3,
    Braking = 4,
    BrakingTurn = 5,
    BrakingEnd = 6,
    Attack = 7,
    Attacking = 8,
    Encount = 9,
    Encounting = 10,
    EFldPlayerDngBehavior_MAX = 11,
};

public enum EFldPoolPackType {
    Common = 0,
    Daily = 1,
    Dungeon_01 = 2,
    Dungeon_02 = 3,
    Max = 4,
};

public enum EFldShortcutResult {
    Success = 0,
    Failed = 1,
    TownMap = 2,
    NowField = 3,
    EFldShortcutResult_MAX = 4,
};

public enum EPlatFormIndex {
    WIN = 0,
    PS4 = 1,
    PS5 = 2,
    WIN_GDK = 3,
    XBOX_ONE = 4,
    XSX = 5,
    MAX = 6,
};

public enum ESubLevelIndex {
    TITLE = 0,
    Battle = 1,
    Field = 2,
    BC_Event = 3,
    A_Event = 4,
    Dungeon = 5,
    UI_Weapon = 6,
    UI_Conbine = 7,
    SubLevelIndexMAX = 8,
    ESubLevelIndex_MAX = 9,
};

public enum EGWorkSeqType {
    Battle = 0,
    Field = 1,
    Event = 2,
    KeyFreeEvent = 3,
    EGWorkSeqType_MAX = 4,
};

public enum EGWorkOnOffEnum {
    On = 0,
    Off = 1,
    EGWorkOnOffEnum_MAX = 2,
};

public enum EHandwritingLayout {
    GROAN_1_POS_ROT = 0,
    GROAN_1_SCALE = 1,
    GROAN_2_POS_ROT = 2,
    GROAN_2_SCALE = 3,
    MUMBLE_1_POS_ROT = 4,
    MUMBLE_1_SCALE = 5,
    MUMBLE_2_POS_ROT = 6,
    MUMBLE_2_SCALE = 7,
    DOORKNOCK_1 = 8,
    DOORKNOCK_2 = 9,
    CALLING_1 = 10,
    CALLING_2 = 11,
    CALLING_3 = 12,
    WOOF_1 = 13,
    WOOF_2 = 14,
    WOOF_3 = 15,
    WOOF_4 = 16,
    WHINE_POS = 17,
    WHINE_SCALE = 18,
    BUZZ_1_POS = 19,
    BUZZ_1_SCALE = 20,
    BUZZ_2_POS = 21,
    BUZZ_2_SCALE = 22,
    DOUBLE_EXCLAMATION_POS = 23,
    EXCLAMATION_QUESTION_POS = 24,
    EXCLAMATION_QUESTION_SCALE = 25,
    QUESTION_POS = 26,
    Max = 27,
};

public enum EHandwritingSpawnRules {
    SpawnWorldLocation = 0,
    AttachToSpawner = 1,
    EHandwritingSpawnRules_MAX = 2,
};

public enum EAtlEvtHandwritingType {
    AngerMark = 0,
    AngerMark_01 = 1,
    Calling = 2,
    DoorKnock_00 = 3,
    Exclamation_00 = 4,
    Sweat_00 = 5,
    DoubleExclamation_00 = 6,
    Question_00 = 7,
    ExclamationQuestion_00 = 8,
    Sweat_01 = 9,
    Woof_00 = 10,
    Whine_00 = 11,
    Zzz_00 = 12,
    Ittitate_00 = 13,
    AccessIcon_Listen = 14,
    EAtlEvtHandwritingType_MAX = 15,
};

public enum EAtlHandwritingGroupType {
    Default = 0,
    Field = 1,
    Event = 2,
    EAtlHandwritingGroupType_MAX = 3,
};

public enum EItemShopText {
    ITEM_NAME = 0,
    ITEM_HELP = 1,
    Max = 2,
};

public enum EItemShopLayout {
    ITEM_DETAIL_POS = 0,
    ITEM_DETAIL_ROW = 1,
    Max = 2,
};

public enum EMsgProcWindowLayout_MIND {
    MSG_OFFSET = 0,
    MSG_ROW = 1,
    SELECT_OFS = 2,
    Max = 3,
};

public enum EMsgProcWindowLayout_DIALOG {
    TITLE_TEXT = 0,
    MAIN_TEXT = 1,
    Max = 2,
};

public enum EMsgProcWindowLayout_SELECT {
    SELECT_TEXT_COL = 0,
    NON_SELECT_TEXT_COL = 1,
    SELECT_TEXT_OFFSET = 2,
    NON_SELECT_TEXT_OFFSET = 3,
    Max = 4,
};

public enum EMsgProcWindowLayout_SIMPLE {
    MSG_TEXT_COL = 0,
    MSG_OFFSET = 1,
    MSG_ROW = 2,
    Max = 3,
};

public enum EMsgProcWindowLayout_ASSIST {
    ASSIST_POSITION = 0,
    LINE_SPACE_OFFSET = 1,
    SUPPORT_INTERVAL = 2,
    Max = 3,
};

public enum EMsgProcWindowTextColLayout_ASSIST {
    TEXT_SIZE = 0,
    Max = 1,
};

public enum PAGE_MOVE_TYPE {
    PREV_MOVE = 0,
    NEXT_MOVE = 1,
    PAGE_MOVE_TYPE_MAX = 2,
    PAGE_MOVE_MAX = 3,
};

public enum INDEX_SIZE {
    SMALL = 0,
    NORMAL = 1,
    LARGE = 2,
    MAX_INDEX_SIZE = 3,
    INDEX_MAX = 4,
};

public enum PAGE_MOVE {
    BASE_PAGE_MOVE = 0,
    THUM_PAGE_MOVE_X = 1,
    THUM_PAGE_MOVE_Y = 2,
    BUTTON_PAGE_MOVE = 3,
    BASE_PAGE_MOVE_NEXT = 4,
    PAGE_MOVE_MAX = 5,
    PAGE_MAX = 6,
};

public enum FADE_ANIM {
    FADE_ANIM_IN = 0,
    FADE_ANIM_IN_WATE = 1,
    FADE_ANIM_OUT = 2,
    FADE_ANIM_OUT_WATE = 3,
    FADE_ANIM_MAX = 4,
};

public enum FADE_MOVE {
    BASE_MOVE_POSX = 0,
    THUM_MOVE_POSX = 1,
    THUM_MOVE_POSY = 2,
    THUM_ANGLE = 3,
    FADE_MOVE_MAX = 4,
    FADE_MAX = 5,
};

public enum FADE_ALPHA {
    NAVY_ALPHA = 0,
    GRAD_ALPHA = 1,
    UNDER_SHADOW_ALPHA = 2,
    BASE_ALPHA = 3,
    BUTTON_ALPHA = 4,
    TEXT_ALPHA = 5,
    THUM_ALPHA = 6,
    GROUND_ALPHA = 7,
    TEXT_ALPHA_NEXT = 8,
    FADE_ALPHA_MAX = 9,
    FADE_MAX = 10,
};

public enum TUTRIAL_SCENE {
    FADE_IN = 0,
    DRAWING = 1,
    FADE_OUT = 2,
    SCENE_MAX = 3,
    TUTRIAL_MAX = 4,
};

public enum ESystemLanguage {
    Japanese = 0,
    English = 1,
    French = 2,
    Italian = 3,
    German = 4,
    Spanish = 5,
    SimplifiedChinese = 6,
    TraditionalChinese = 7,
    Korean = 8,
    Russian = 9,
    Portuguese = 10,
    Turkish = 11,
    Polish = 12,
    Max = 13,
};

public enum ELOADTRANCE {
    SCENE_START = 0,
    SCENE_WATE = 1,
    SCENE_END = 2,
    SCENE_MAX = 3,
};

public enum TIMESHIFTPARAM {
    MORNING = 0,
    EVENING = 1,
    NIGHT = 2,
    SHADOWHOUR = 3,
    TIMESHIFTPARAM_MAX = 4,
};

public enum ETagType {
    TITLE = 1,
    NAME = 2,
    TEXTURE = 3,
    SPACE = 999,
    ETagType_MAX = 1000,
};

public enum EMailText {
    MAIL_LIST_SENDER = 0,
    MAIL_LIST_TITLE = 1,
    MAIL_SENDER = 2,
    MAIL_TITLE = 3,
    Max = 4,
};

public enum EMailLayout {
    MAIL_NEW_MESSAGE = 0,
    MAIL_LIST_TITLE = 1,
    MAIL_TITLE = 2,
    MAIL_LIST_SENDER = 3,
    MAIL_SENDER = 4,
    MAIL_TODAYS = 5,
    Max = 6,
};

public enum EEvtAdxSoundFadeType {
    FADE_IN = 0,
    FADE_OUT = 1,
    STOP_BGM = 2,
    EEvtAdxSoundFadeType_MAX = 3,
};

public enum EAtlCharaAnimFireEventsAtPosition {
    AtStartOfEvaluation = 0,
    AtEndOfEvaluation = 1,
    AfterSpawn = 2,
    EAtlCharaAnimFireEventsAtPosition_MAX = 3,
};

public enum EEvtCharaHandwritingSpawnOwnerType {
    CharacterDefault = 0,
    Character = 1,
    SpawnerDirectRequest = 2,
    EEvtCharaHandwritingSpawnOwnerType_MAX = 3,
};

public enum EEvtCharaOperationFootStepLabelType {
    Dynamic = 0,
    Carpet = 1,
    Concrete = 2,
    EEvtCharaOperationFootStepLabelType_MAX = 3,
};

public enum EEvtCharaOperationType {
    Invalid = 0,
    OverwriteFootStepLabel = 1,
    EEvtCharaOperationType_MAX = 2,
};

public enum EEvtCharaAnimationPackIDType {
    Event = 0,
    Common = 1,
    Dungeon = 2,
    EEvtCharaAnimationPackIDType_MAX = 3,
};

public enum EAtlCharaFaceAnimFireEventsAtPosition {
    AtStartOfEvaluation = 0,
    AtEndOfEvaluation = 1,
    AfterSpawn = 2,
    EAtlCharaFaceAnimFireEventsAtPosition_MAX = 3,
};

public enum EEvtConditionalBranchType {
    AlwaysExecute = 0,
    DoNotExecute = 1,
    RefFromLocal = 2,
    RefFromGlobalFlag = 3,
    RefFromGlobalCounter = 4,
    EEvtConditionalBranchType_MAX = 5,
};

public enum EFireEventsAtPositionggg {
    AtStartOfEvaluation = 0,
    AtEndOfEvaluation = 1,
    AfterSpawn = 2,
    EFireEventsAtPositionggg_MAX = 3,
};

public enum EEvtFadeScreenType {
    EVT_FADESCREEN_FADE_IN = 0,
    EVT_FADESCREEN_FADE_OUT = 1,
    EVT_FADESCREEN_CROSSFADE_IN = 2,
    EVT_FADESCREEN_CROSSFADE_OUT = 3,
    EVT_FADESCREEN_MAX = 4,
};

public enum EEvtMovieOperation {
    Play = 0,
    Pause = 1,
    Resume = 2,
    EEvtMovieOperation_MAX = 3,
};

public enum EEvtSeqControllerOperation {
    Invalid = 0,
    WaitingMessage = 1,
    FinishSequencer = 2,
    PlayAndJumpToSec = 3,
    Pause = 4,
    ViewFieldCamera = 5,
    ViewSequencerCamera = 6,
    TransitionLightScenarioSublevel = 7,
    WaitTransitionLightScenarioSublevel = 8,
    EEvtSeqControllerOperation_MAX = 9,
};

public enum EEvtSeqTimeJumpControllerOperation {
    TimeJump = 0,
    TimeJumpMarker = 1,
    Invalid = 2,
    SkipAndTimeJump = 3,
    EEvtSeqTimeJumpControllerOperation_MAX = 4,
};

public enum EPlatformName {
    PN_STEAM = 0,
    PN_WINGDK = 1,
    PN_PS4 = 2,
    PN_PS5 = 3,
    PN_XBOXONE = 4,
    PN_XSX = 5,
    PN_COUNT = 6,
    PN_MAX = 7,
};

public enum ANIMFADEALPHA_RN {
    BLACKBOARD_ALPHA = 0,
    BLUEBOARD_ALPHA = 1,
    GRADATION_ALPHA = 2,
    SCROLLBAR_ALPHA = 3,
    MAINTEXT_ALPHA = 4,
    FADE_ALPHA_MAX = 5,
    ANIMFADEALPHA_MAX = 6,
};

public enum ANIMFADEMOVE_RN {
    BLACKBOARD_POS = 0,
    BLUEBOARD_POS = 1,
    BLUEBOARD_ROLL = 2,
    SCROLLBAR_POS = 3,
    MAINTEX_POS = 4,
    FADE_MOVE_MAX = 5,
    ANIMFADEMOVE_MAX = 6,
};

public enum ASSETDATATYPE_RN {
    RightsNotationType = 0,
    DayTypeMax = 1,
    ASSETDATATYPE_MAX = 2,
};

public enum STATEDRAW {
    FADE_IN = 0,
    DRAW_WATE = 1,
    FADE_OUT = 2,
    MAX_STATE = 3,
    STATEDRAW_MAX = 4,
};

public enum TEXTUREID {
    NONE = 0,
    FLOWER = 1,
    SUPPLIES = 2,
    FOOD = 3,
    DRINK1 = 4,
    DRINK2 = 5,
    DRINK3 = 6,
    DRINK4 = 7,
    DRINK5 = 8,
    OMIYAGE = 9,
    DRINK6 = 10,
    DRINK7 = 11,
    UMIUSI = 12,
    PCSOFTWARE = 13,
    GOSSIP = 14,
    JEWELRY = 15,
    TEXTUREID_MAX = 16,
};

public enum TIMEPARM {
    NIGHT = 0,
    DAYTIME = 1,
    MORNING = 2,
    MAX = 3,
};

public enum EsoundPlayerType {
    BGM = 0,
    ENV = 1,
    SE = 2,
    VOICE = 3,
    OTHER = 4,
    NONE = 5,
    EsoundPlayerType_MAX = 6,
};

public enum ESteamControllerType {
    None = 0,
    NoCont = 1,
    Unknown = 2,
    Steam = 3,
    XBOX360 = 4,
    XBOX_ONE = 5,
    XInput = 6,
    PS4 = 7,
    PS5 = 8,
    SwitchPro = 9,
    DirectInput = 10,
    Other = 11,
    Keyboard = 12,
    ESteamControllerType_MAX = 13,
};

public enum ESystemFontType {
    SkipStd = 0,
    AsiaKSJ_B = 1,
    DFGBJH8 = 2,
    DFT_C8 = 3,
    Amrys_Medium = 4,
    SkipPro = 5,
    ESystemFontType_MAX = 6,
};

public enum ETCSSaveDataTCRJobType {
    NONE = 0,
    WRITE = 1,
    READ = 2,
    ETCSSaveDataTCRJobType_MAX = 3,
};

public enum ETCSSaveDataTCRModeType {
    NONE = 0,
    INIT_WEB_API = 1,
    SYNC_WEB_API = 2,
    INIT_WRITE_TCR = 3,
    SYNC_WRITE_TCR = 4,
    INIT_READ_TCR = 5,
    SYNC_READ_TCR = 6,
    END = 7,
    ETCSSaveDataTCRModeType_MAX = 8,
};

public enum ETitleLayout {
    PRESS_ANY_BUTTON_END_POS = 0,
    PRESS_ANY_BUTTON_POS_OFFSET = 1,
    LIST_NEW_GAME = 2,
    LIST_LOAD_GAME = 3,
    LIST_CONFIG = 4,
    LIST_CURSOR = 5,
    MASK_WIDTH = 6,
    PRESS_ANY_BUTTON_MASK_WIDTH = 7,
    PS_PRESS_ANY_BUTTON_END_POS = 8,
    PS_PRESS_ANY_BUTTON_POS_OFFSET = 9,
    PS_PRESS_ANY_BUTTON_MASK_WIDTH = 10,
    MAX = 11,
};

public enum ETitleState {
    TS_Caution = 0,
    TS_PhotosensitiveCaution = 1,
    TS_NetworkCheck = 2,
    TS_Logo = 3,
    TS_OP = 4,
    TS_PressWait = 5,
    TS_Select = 6,
    TS_NewGame = 7,
    TS_LoadGame = 8,
    TS_Config = 9,
    TS_Exit = 10,
    TS_ComeBackLoad = 11,
    TS_Num = 12,
    TS_MAX = 13,
};

public enum ETitleMenueState {
    TM_NewGame = 0,
    TM_LoadGame = 1,
    TM_Config = 2,
    TM_ExitGameDialog = 3,
    TM_RightsNotation = 4,
    TM_Localization = 5,
    TM_Num = 6,
    TM_MAX = 7,
};

public enum EAccessInfoPlaceNameWidthType {
    FIXED_WIDTH = 0,
    PROPORTIONAL = 1,
    EAccessInfoPlaceNameWidthType_MAX = 2,
};

public enum EAccessInfoCarNoDisplayType {
    CAR_NO_LAST = 0,
    CAR_NO_FIRST = 1,
    CAR_NO_MAX = 2,
};

public enum ANIMFADEALPHA {
    BLACKBOARD_ALPHA = 0,
    BLUEBOARD_ALPHA = 1,
    GRADATION_ALPHA = 2,
    DAY_ALPHA = 3,
    SCROLLBAR_ALPHA = 4,
    LOG_ALPHA = 5,
    ICON_ALPHA = 6,
    NONE_ALPHA = 7,
    DECO_ALPHA = 8,
    CURSOR_WHITE_ALPHA = 9,
    CURSOR_BLUE_ALPHA = 10,
    FADE_ALPHA_MAX = 11,
    ANIMFADEALPHA_MAX = 12,
};

public enum ANIMFADEMOVE {
    BLACKBOARD_POS = 0,
    BLUEBOARD_POS = 1,
    BLUEBOARD_ROLL = 2,
    DAY_POS = 3,
    SCROLLBAR_POS = 4,
    LOG_POS = 5,
    ICON_POS = 6,
    NONE_POS = 7,
    DECO_POS = 8,
    CURSOR_WHITE_POS = 9,
    CURSOR_BLUE_POS = 10,
    FADE_MOVE_MAX = 11,
    ANIMFADEMOVE_MAX = 12,
};

public enum ANIMFADE {
    FADE_ANIM_IN = 0,
    FADE_ANIM_OUT = 1,
    FADE_ANIM_IN_WATE = 2,
    FADE_ANIM_OUT_WATE = 3,
    FADE_ANIM_MAX = 4,
};

public enum ASSETDATATYPE {
    BackLogType = 0,
    FieldDayType = 1,
    DayTypeMax = 2,
    ASSETDATATYPE_MAX = 3,
};

public enum WAVETYPE {
    FIRST = 0,
    SECOND = 1,
    THIRD = 2,
    MAX_WAVETYPE = 3,
    WAVETYPE_MAX = 4,
};

public enum DRAWSTATE {
    DRAW_FADE_IN = 0,
    DRAW_WATE = 1,
    DRAW_FADE_OUT = 2,
    MAX_STATE = 3,
    DRAWSTATE_MAX = 4,
};

public enum EUICmmRankUpSE {
    UI_CMM_SE_CARD_SET = 0,
    UI_CMM_SE_CARD_ROTETION = 1,
    UI_CMM_SE_RANKUP_FALL = 2,
    UI_CMM_SE_RANKUP_INSTRING = 3,
    UI_CMM_SE_RANKUP_MAXSTAR = 4,
    UI_CMM_SE_RANKUP_INSTAR = 5,
    UI_CMM_SE_REVERSE_FALL = 6,
    UI_CMM_SE_REVERSE_BGCHANGE = 7,
    UI_CMM_SE_REVERSE_INSTRING = 8,
    UI_CMM_SE_REVERSE_ROTATION = 9,
    UI_CMM_SE_RECOVERY_ROTATION = 10,
    UI_CMM_SE_MAX = 11,
};

public enum EAnimationType {
    Physics = 0,
    Magic = 1,
    EAnimationType_MAX = 2,
};

public enum ECmmProfileMsgType {
    Normal = 0,
    Reverse = 1,
    Missing = 2,
    Lost = 3,
    ECmmProfileMsgType_MAX = 4,
};

public enum EQuestRequestOption {
    None = 0,
    Erase = 1,
    EQuestRequestOption_MAX = 2,
};

public enum EQuestRequestPersonaType {
    None = 0,
    Has = 1,
    Skill = 2,
    Level = 3,
    EQuestRequestPersonaType_MAX = 4,
};

public enum EQuestRequestType {
    Event = 0,
    Item = 1,
    Persona = 2,
    Counter = 3,
    EQuestRequestType_MAX = 4,
};

public enum EMailCategory {
    Community = 0,
    DeepEpisode = 1,
    Facility = 2,
    Common = 3,
    Max = 4,
};

public enum EMailCondition {
    Equal = 0,
    NotEqual = 1,
    Greater = 2,
    EGreater = 3,
    Less = 4,
    ELess = 5,
    EMailCondition_MAX = 6,
};

public enum EMailTime {
    Morning = 0,
    Noon = 1,
    Night = 2,
    EMailTime_MAX = 3,
};

public enum UIActionSuggestionLayout {
    ACTION_SUGGESTION_TEXT = 0,
    ACTION_SUGGESTION_TEXT_POS_Y = 1,
    ACTION_SUGGESTION_ICON_POS_Y = 2,
    Max = 3,
};

public enum EUI_OT_TYPE {
    EUI_Defult_Value = 0,
    UI_OT_BEGIN = 0,
    UI_OT_BATTLE_LOW = 3,
    UI_OT_BATTLE_MIDDLE = 5,
    UI_OT_BATTLE_HIGH = 6,
    UI_SKELETON_OT_2D_HIGH = 7,
    UI_OT_FADE_UI_BACK = 9,
    UI_OT_UI_PANEL_BACK = 10,
    UI_OT_UI_PANEL = 11,
    UI_OT_UI_PANEL_FRONT = 12,
    UI_OT_FACILITY = 13,
    UI_OT_FACILITY_FRONT = 17,
    UI_OT_FCL_WEAPON = 18,
    UI_OT_CAMP_BACK = 20,
    UI_OT_CAMP = 21,
    UI_OT_CAMP_FRONT = 22,
    UI_OT_CAMP_MORE_FRONT = 23,
    UI_OT_PERSONA_STATUS_BACK = 24,
    UI_OT_PERSONA_STATUS = 25,
    UI_OT_PERSONA_STATUS_FRONT = 26,
    UI_OT_SAVE = 27,
    UI_OT_CAMP_WIPE = 30,
    UI_OT_STAFFROLL = 31,
    UI_OT_FADE = 32,
    UI_OT_MESSAGE_WINDOW_BACK = 33,
    UI_OT_BUSTUP = 34,
    UI_OT_MESSAGE_WINDOW = 35,
    UI_OT_MESSAGE_SEL_WINDOW = 36,
    UI_OT_BACKLOG = 37,
    UI_OT_CALENDAR = 38,
    UI_OT_NETWORK = 39,
    UI_OT_DEBUG = 41,
    UI_OT_NUM_MAX = 42,
    EUI_OT_MAX = 43,
};

public enum EUIGAUSS_TYPE {
    EUI_Defult_Value = 0,
    UI_OT_GAUSS_VERY_WEAK = 0,
    UI_OT_GAUSS_WEAK = 1,
    UI_OT_GAUSS_NORMAL = 2,
    UI_OT_GAUSS_STRONG = 3,
    UI_OT_GAUSS_VERY_STRONG = 4,
    UI_OT_GAUSSTEX_MOST_WEAK = 5,
    EUIGAUSS_MAX = 6,
};

public enum EUIColorWriteMask {
    EUI_Defult_Value = 0,
    UI_CW_RED = 1,
    UI_CW_GREEN = 2,
    UI_CW_BLUE = 4,
    UI_CW_ALPHA = 8,
    UI_CW_NONE = 0,
    UI_CW_RGB = 7,
    UI_CW_RGBA = 15,
    UI_CW_RG = 3,
    UI_CW_BA = 12,
    UI_EColorWriteMask_NumBits = 4,
    EUIColorWriteMask_MAX = 16,
};

public enum EUIDungeonTransferCloudDrawMode {
    Normal = 0,
    ADD = 1,
    EUIDungeonTransferCloudDrawMode_MAX = 2,
};

public enum EUIDungeonTransferHazeDrawMode {
    TowerMask = 0,
    Normal = 1,
    EUIDungeonTransferHazeDrawMode_MAX = 2,
};

public enum ETownType {
    SCHOOL = 0,
    DORMITORY = 1,
    POLONIANMALL = 2,
    PORTISLAND = 3,
    IWATODAI = 4,
    NAGANAKI_TEMPLE = 5,
    ARRAY_MAX = 6,
    ETownType_MAX = 7,
};

public enum EMiscGetItemLayout {
    ITEM_TEXT_SIZE = 0,
    MAX = 1,
};

public enum EUINameEntryLayout {
    NAME_LEFT = 0,
    NAME_RIGHT = 1,
    CURSOR_NAME_LEFT = 2,
    CURSOR_NAME_RIGHT = 3,
    OPTION = 4,
    DECISION = 5,
    DARK_BLUE_LIGHT = 6,
    LIGHT_BLUE_LIGHT = 7,
    BLUE_LIGHT_LEFT = 8,
    NONAME_LEFT = 9,
    NONAME_RIGHT = 10,
    Max = 11,
};

public enum EOkNextMaskLayout {
    OK_DUNGEON_ITEM_MSK_SIZE = 0,
    OK_DUNGEON_ITEM_MSK_OFFSET = 1,
    OK_CAMP_HUMAN_PARA_MSK_SIZE = 2,
    OK_CAMP_HUMAN_PARA_MSK_OFFSET = 3,
    OK_CAMP_THEURGIA_MSK_SIZE = 4,
    OK_CAMP_THEURGIA_MSK_OFFSET = 5,
    OK_COMMU_POETRY_MSK_SIZE = 6,
    OK_COMMU_POETRY_MSK_OFFSET = 7,
    OK_COMMU_RANK_UP_MSK_SIZE = 8,
    OK_COMMU_RANK_UP_MSK_OFFSET = 9,
    OK_SYSTEM_WINDOW_MSK_SIZE = 10,
    OK_SYSTEM_WINDOW_MSK_OFFSET = 11,
    NEXT_CAMP_THEURGIA_MSK_SIZE = 12,
    NEXT_CAMP_THEURGIA_MSK_OFFSET = 13,
    NEXT_SYSTEM_WINDOW_MSK_SIZE = 14,
    NEXT_SYSTEM_WINDOW_MSK_OFFSET = 15,
    Max = 16,
};

public enum EOkNextLayout {
    OK_DUNGEON_ITEM_OFFSET = 0,
    OK_CAMP_HUMAN_PARAMETER_OFFSET = 1,
    OK_CAMP_THEURGIA_OFFSET = 2,
    OK_COMMU_POETRY_OFFSET = 3,
    OK_COMMU_RANK_UP_OFFSET = 4,
    OK_BATTLE_RESULT_OFFSET = 5,
    BUTTON_BATTLE_RESULT_OFFSET = 6,
    OK_SYSTEM_WINDOW_OFFSET = 7,
    NEXT_CAMP_THEURGIA_OFFSET = 8,
    NEXT_SYSTEM_WINDOW_OFFSET = 9,
    OK_ONLY_CAMP_HUMAN_PARAMETER_OFFSET = 10,
    YES_OFFSET = 11,
    NO_OFFSET = 12,
    Max = 13,
};

public enum EPersonaStatusModelAnim {
    Physics = 0,
    Magic = 1,
    EPersonaStatusModelAnim_MAX = 2,
};

public enum EPERSONA_STATUS_DRAW_SCENE {
    NONE = 0,
    LIST = 1,
    MAIN = 2,
    LEVEL_UP = 3,
    PARAMETER_UP = 4,
    COMBINE = 5,
    DRAWER = 6,
    REGISTRY = 7,
    SKILL_CARD = 8,
    EPERSONA_STATUS_DRAW_MAX = 9,
};

public enum EPersonaGrowthEvent {
    None = 0,
    LevelUp = 1,
    AddSkill = 2,
    Conception = 4,
    ShowStatus = 6,
    ShowStatus_Combine = 7,
    EPersonaGrowthEvent_MAX = 8,
};

public enum EUIRippleTimeLayout {
    RIPPLE_0_TIME = 0,
    RIPPLE_1_TIME = 1,
    RIPPLE_2_TIME = 2,
    RIPPLE_3_TIME = 3,
    RIPPLE_4_TIME = 4,
    RIPPLE_5_TIME = 5,
    RIPPLE_6_TIME = 6,
    RIPPLE_7_TIME = 7,
    RIPPLE_8_TIME = 8,
    RIPPLE_9_TIME = 9,
    RIPPLE_10_TIME = 10,
    RIPPLE_11_TIME = 11,
    RIPPLE_12_TIME = 12,
    Max = 13,
};

public enum EUIRippleLayout {
    RIPPLE_0_POS = 0,
    RIPPLE_0_SIZE = 1,
    RIPPLE_1_POS = 2,
    RIPPLE_1_SIZE = 3,
    RIPPLE_2_POS = 4,
    RIPPLE_2_SIZE = 5,
    RIPPLE_3_POS = 6,
    RIPPLE_3_SIZE = 7,
    RIPPLE_4_POS = 8,
    RIPPLE_4_SIZE = 9,
    RIPPLE_5_POS = 10,
    RIPPLE_5_SIZE = 11,
    RIPPLE_6_POS = 12,
    RIPPLE_6_SIZE = 13,
    RIPPLE_7_POS = 14,
    RIPPLE_7_SIZE = 15,
    RIPPLE_8_POS = 16,
    RIPPLE_8_SIZE = 17,
    RIPPLE_9_POS = 18,
    RIPPLE_9_SIZE = 19,
    RIPPLE_10_POS = 20,
    RIPPLE_10_SIZE = 21,
    RIPPLE_11_POS = 22,
    RIPPLE_11_SIZE = 23,
    RIPPLE_12_POS = 24,
    RIPPLE_12_SIZE = 25,
    Max = 26,
};

public enum EUICommonResource {
    SprItemIcon = 0,
    BustupExist = 1,
    CampSystemBmd = 2,
    SkillHelpBmd = 3,
    ItemWeaponHelpBmd = 4,
    ItemArmorHelpBmd = 5,
    ItemShoesHelpBmd = 6,
    ItemAccessoryHelpBmd = 7,
    ItemCommonHelpBmd = 8,
    ItemEvitemHelpBmd = 9,
    ItemMaterialHelpBmd = 10,
    ItemSkillcardHelpBmd = 11,
    ItemCostumeHelpBmd = 12,
    CmmOutlineHelpBmd = 13,
    CmmProfileHelpBmd = 14,
    CmmProfileHelpTable = 15,
    MailIncoming = 16,
    Disappear = 17,
    VelvetRoomQuest = 18,
    QuestBmd = 19,
    GenSelItemDefineTable = 20,
    GenSelItemLineupTable = 21,
    SimpleShop = 22,
    KeyHelp = 23,
    BattleKeyHelp = 24,
    CampKeyHelp = 25,
    FacilityKeyHelp = 26,
    BustupEnvironment = 27,
    BustupGradation = 28,
    BustupBaseMaterial = 29,
    BustupFillMaterial = 30,
    MessageWindowSpr = 31,
    MessageWindowPlg = 32,
    MessageWindowAssistSpr = 33,
    DisappearHelpBmd = 34,
    BustupAnim = 35,
    KeyHelpPlg = 36,
    WaveMaterial = 37,
    WaveBackMaterial = 38,
    BustupSupportMaterial = 39,
    PersonaHelpBmd = 40,
    ActionRecordBmd = 41,
    CldDateMessagesBmd = 42,
    CldDateMessagesDataAsset = 43,
    ArbeitHelpBmd = 44,
    ArbeitInfoDataAsset = 45,
    HiddenArbeitDataAsset = 46,
    CommonMoneySpr = 47,
    SupportBustupDataAsset = 48,
    ItemAddEffectHelpBmd = 49,
    CampSpr = 50,
    CampPlg = 51,
    AddContentData = 52,
    AddContentBmd = 53,
    AddContentBundleName = 54,
    AddContentEntitlementName = 55,
    AddContentDispName = 56,
    BPPersonaStatusDraw = 57,
    DataInheritanceTable = 58,
    DataInheritanceBmd = 59,
    ClearSaveBmd = 60,
    KeyHelpButton = 61,
    BattleKeyHelpButton = 62,
    CampKeyHelpButton = 63,
    FacilityKeyHelpButton = 64,
    Max = 65,
};

public enum EShopType {
    Weapon = 0,
    Items = 1,
    Antique = 2,
    Combine = 3,
    EShopType_MAX = 4,
};

public enum EArbeitOrderableWeek {
    Sun = 1,
    Mon = 2,
    Tue = 4,
    Wed = 8,
    Thu = 16,
    Fri = 32,
    Sat = 64,
    EArbeitOrderableWeek_MAX = 65,
};

public enum EArbeitOrderableTime {
    Afternoon = 1,
    Evening = 2,
    AllTime = 3,
    EArbeitOrderableTime_MAX = 4,
};

public enum EUITheurgiaTextRowLayout {
    THEURGIA_HELP_MAX_ROW_COUNT = 0,
    THEURGIA_HELP_ROW_OFFSET = 1,
    BTL_THEURGIA_HELP_ROW_OFFSET = 2,
    RISE_TREND_ROW_OFFSET = 3,
    CHARACTERISTIC_HELP_ROW_OFFSET = 4,
    Max = 5,
};

public enum EUITheurgiaTextPosLayout {
    THEURGIA_NAME_POS_Y = 0,
    THEURGIA_HELP_POS_Y = 1,
    BTL_THEURGIA_NAME_POS_Y = 2,
    BTL_THEURGIA_HELP_POS_Y = 3,
    RISE_TREND_POS_Y = 4,
    CHARACTERISTIC_NAME_POS_Y = 5,
    CHARACTERISTIC_HELP_POS_Y = 6,
    Max = 7,
};

public enum EUITheurgiaTextLayout {
    PLAYER_NAME_CHANGE_POS = 0,
    CHARA_NAME = 1,
    CHARA_NAME_POS_OFFSET = 2,
    THEURGIA_NAME = 3,
    THEURGIA_HELP = 4,
    RISE_TREND = 5,
    CHARACTERISTIC_NAME = 6,
    CHARACTERISTIC_HELP = 7,
    Max = 8,
};

public enum EUIScreenID4Touch {
    SaveLoad = 1,
    KeyHelp = 2,
    MsgSystemWindow = 3,
    MsgWindow = 4,
    SelectMsgWindow = 5,
    PersonaStatusDraw_3D = 6,
    Config = 7,
    KeyConfigTab = 8,
    Mail = 9,
    MailList = 10,
    MapLocationSelect = 11,
    MapMiniMap = 12,
    MapTownMap = 13,
    MapDungeon = 14,
    MapDungeonList = 15,
    GenericSelect = 16,
    GenericSelectList = 17,
    BackLog = 18,
    BackLogMask = 19,
    TitleList = 20,
    Shop = 21,
    ShopData = 22,
    ShopList = 23,
    CsAEvent_A = 24,
    CsAEvent_B = 25,
    TitleDiffList = 26,
    CalendarDay = 27,
    CalendarMonth = 28,
    CampTop = 29,
    CampSystemTop = 30,
    Tutorial = 31,
    TutorialTab = 32,
    TutorialList = 33,
    CommuTop = 34,
    CommuTopList = 35,
    CommuDetailsList = 36,
    CommuDetails = 37,
    Battle = 38,
    BattleScrollbar = 39,
    BattleItemList = 40,
    BattleSkillList = 41,
    BattleTacticsList1 = 42,
    BattleTacticsList2 = 43,
    BattleTacticsList3 = 44,
    BattleTheurgiaList = 45,
    BattleKeyHelp = 46,
    ShuffleCardList = 47,
    ShufflePersonaList = 48,
    Quest = 49,
    Request = 50,
    RequestList = 51,
    RequestDetail = 52,
    MissingPerson = 53,
    MissingPersonList = 54,
    MissingPersonDetail = 55,
    CmpPartyPanel = 56,
    CmpPartyPanelEquip = 57,
    CmpStatusMode = 58,
    CmpStatus = 59,
    PersonaList = 60,
    PersonaStatusSkill = 61,
    PersonaStatusSkillSelect = 62,
    PersonaStatusSkillSelectList = 63,
    PersonaStatusRegistry = 64,
    PersonaStatusKeyHelp = 65,
    KeyHelpUniqueAction = 66,
    CmpItem = 67,
    CmpItemList = 68,
    CmpItemPersonaList = 69,
    CmpTheurgia = 70,
    CmpTheurgiaCardList = 71,
    CmpSkillLIst = 72,
    CmpEquip = 73,
    CmpEquipCategory = 74,
    CmpEquipList = 75,
    CmpEquipDetail = 76,
    RightsNotation = 77,
    GameOverPoem = 78,
    EventKeyHelp = 79,
    BackLogKeyHelp = 80,
    NameEntry = 81,
    ConfigList = 82,
    Calendar = 83,
    VelvetKeyHelp = 84,
    ConfigValueGauge = 85,
    HeroParameter = 86,
    VoiceAnswer = 87,
    VoiceAnswerKeyHelp = 88,
    EUIScreenID4Touch_MAX = 89,
};

public enum EUIVELVET_ROOM_MCA_CAPTURE {
    NONE = 0,
    TOP = 1,
    COMBINE2 = 2,
    SEARCH = 3,
    SPECIAL = 4,
    BOOK = 5,
    REGIST = 6,
    EUIVELVET_ROOM_MCA_MAX = 7,
};

public enum EUIVelvetRoomDrawScene {
    NONE = 0,
    EVENT = 1,
    MAIN = 2,
    COMBINE_SELECT = 3,
    COMBINE = 4,
    DRAWER = 5,
    REGIST = 6,
    TALK = 7,
    EUIVelvetRoomDrawScene_MAX = 8,
};

public enum EQuestListItemState {
    None = 0,
    Ordered = 1,
    Completed = 2,
    Failed = 3,
    EQuestListItemState_MAX = 4,
};

public enum EVoiceActionTime {
    Auto = 0,
    Daytime = 1,
    Night = 2,
    EVoiceActionTime_MAX = 3,
};

public enum EOneAnimType {
    Linear = 0,
    Sin90 = 1,
    Sin180 = 2,
    Sin360 = 3,
    HSin180 = 4,
    EaseInOut = 5,
    EaseOut1 = 6,
    EaseOut2 = 7,
    EaseOut3 = 8,
    CurveUp1 = 9,
    CurveUp2 = 10,
    CurveUp3 = 11,
    CurveDown1 = 12,
    CurveDown2 = 13,
    CurveDown3 = 14,
    Haneru1 = 15,
    Haneru1ST1 = 16,
    Haneru2 = 17,
    Haneru3 = 18,
    Fuwari1 = 19,
    Bowa1 = 20,
    Gachan2 = 21,
    KaesiSlide2 = 22,
    ButtonPush = 23,
    YureruRot = 24,
    Max = 25,
};

