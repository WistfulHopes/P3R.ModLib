using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ItfController : ObjectBase<AItfController>
{
    public ItfController(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgDictionary : ObjectBase<UMsgDictionary>
{
    public MsgDictionary(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgDLC : ObjectBase<UMsgDLC>
{
    public MsgDLC(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgMessage : ObjectBase<UMsgMessage>
{
    public MsgMessage(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgMind : ObjectBase<UMsgMind>
{
    public MsgMind(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgMindSubtitles : ObjectBase<UMsgMindSubtitles>
{
    public MsgMindSubtitles(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgManager : ObjectBase<UMsgManager>
{
    public MsgManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcItem : ObjectBase<UMsgProcItem>
{
    public MsgProcItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindowBase : ObjectBase<UMsgProcWindowBase>
{
    public MsgProcWindowBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Assist : ObjectBase<UMsgProcWindow_Assist>
{
    public MsgProcWindow_Assist(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Mind : ObjectBase<UMsgProcWindow_Mind>
{
    public MsgProcWindow_Mind(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Performance : ObjectBase<UMsgProcWindow_Performance>
{
    public MsgProcWindow_Performance(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Select : ObjectBase<UMsgProcWindow_Select>
{
    public MsgProcWindow_Select(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Select_Mind : ObjectBase<UMsgProcWindow_Select_Mind>
{
    public MsgProcWindow_Select_Mind(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Select_Simple : ObjectBase<UMsgProcWindow_Select_Simple>
{
    public MsgProcWindow_Select_Simple(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Simple : ObjectBase<UMsgProcWindow_Simple>
{
    public MsgProcWindow_Simple(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_System : ObjectBase<UMsgProcWindow_System>
{
    public MsgProcWindow_System(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgProcWindow_Tutorial : ObjectBase<UMsgProcWindow_Tutorial>
{
    public MsgProcWindow_Tutorial(IntPtr pointer) : base(pointer) {}
}

public unsafe class itfMsgProgWindow_TUTRIALDraw : ObjectBase<AitfMsgProgWindow_TUTRIALDraw>
{
    public itfMsgProgWindow_TUTRIALDraw(IntPtr pointer) : base(pointer) {}
    public void Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
}

public unsafe class MsgWork : ObjectBase<UMsgWork>
{
    public MsgWork(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgPerformance : ObjectBase<UMsgPerformance>
{
    public MsgPerformance(IntPtr pointer) : base(pointer) {}}

public unsafe class SelItem : ObjectBase<USelItem>
{
    public SelItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class SelAEventTypeA : ObjectBase<USelAEventTypeA>
{
    public SelAEventTypeA(IntPtr pointer) : base(pointer) {}
}

public unsafe class SelAEventTypeB : ObjectBase<USelAEventTypeB>
{
    public SelAEventTypeB(IntPtr pointer) : base(pointer) {}
}

public unsafe class SelFukaSuport : ObjectBase<USelFukaSuport>
{
    public SelFukaSuport(IntPtr pointer) : base(pointer) {}}

public unsafe class SelMessage : ObjectBase<USelMessage>
{
    public SelMessage(IntPtr pointer) : base(pointer) {}}

public unsafe class SelMind : ObjectBase<USelMind>
{
    public SelMind(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgSubtitles : ObjectBase<UMsgSubtitles>
{
    public MsgSubtitles(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgSystem : ObjectBase<UMsgSystem>
{
    public MsgSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgTutorial : ObjectBase<UMsgTutorial>
{
    public MsgTutorial(IntPtr pointer) : base(pointer) {}}

public unsafe class TutorialManager : ObjectBase<UTutorialManager>
{
    public TutorialManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class KernelResource : ObjectBase<UKernelResource>
{
    public KernelResource(IntPtr pointer) : base(pointer) {}
}

public unsafe class BuildModeLibrary : ObjectBase<UBuildModeLibrary>
{
    public BuildModeLibrary(IntPtr pointer) : base(pointer) {}
    public bool IsShipping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsShipping"), @params);
    }
    public bool IsDebug()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDebug"), @params);
    }
}

public unsafe class KernelWidget : ObjectBase<UKernelWidget>
{
    public KernelWidget(IntPtr pointer) : base(pointer) {}}

public unsafe class KernelActor : ObjectBase<AKernelActor>
{
    public KernelActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class KernelBpLib : ObjectBase<UKernelBpLib>
{
    public KernelBpLib(IntPtr pointer) : base(pointer) {}
    public void StopLoadingScreen()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopLoadingScreen"), @params);
    }
    public void StartLoadingScreen(UObject* WorldContextObject, bool bPlayUntilStopped, float PlayTime)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("bPlayUntilStopped", bPlayUntilStopped), 
            ("PlayTime", PlayTime)
        ];
        ProcessEvent(GetFunction("StartLoadingScreen"), @params);
    }
    public void StartBfPath(UObject* WorldContextObject, FString BfAssetPath, FString BmdAssetPath, int ProcNo, FLatentActionInfo LatentInfo, ref int Result)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("BfAssetPath", BfAssetPath), 
            ("BmdAssetPath", BmdAssetPath), 
            ("ProcNo", ProcNo), 
            ("LatentInfo", LatentInfo), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("StartBfPath"), @params);
    }
    public void StartBfEx(UObject* WorldContextObject, TSoftObjectPtr<UBfAsset> InBfAsset, TSoftObjectPtr<UBmdAsset> InBmdAsset, int ProcNo, bool PlayerStop, bool BmdSearchOff, FLatentActionInfo LatentInfo, ref int Result)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InBfAsset", InBfAsset), 
            ("InBmdAsset", InBmdAsset), 
            ("ProcNo", ProcNo), 
            ("PlayerStop", PlayerStop), 
            ("BmdSearchOff", BmdSearchOff), 
            ("LatentInfo", LatentInfo), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("StartBfEx"), @params);
    }
    public void StartBf(UObject* WorldContextObject, TSoftObjectPtr<UBfAsset> InAsset, int ProcNo, bool PlayerStop, bool BmdSearchOff, FLatentActionInfo LatentInfo, ref int Result)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InAsset", InAsset), 
            ("ProcNo", ProcNo), 
            ("PlayerStop", PlayerStop), 
            ("BmdSearchOff", BmdSearchOff), 
            ("LatentInfo", LatentInfo), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("StartBf"), @params);
    }
    public void SetTestMap(UObject* WorldContextObject, FTransform Location)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetTestMap"), @params);
    }
    public void SetTestCharacter(UObject* WorldContextObject, TSubclassOf<ACharacter> In, FTransform Location)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("In", In), 
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetTestCharacter"), @params);
    }
    public bool IsInEditor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInEditor"), @params);
    }
}

public unsafe class DebugMenu : ObjectBase<UDebugMenu>
{
    public DebugMenu(IntPtr pointer) : base(pointer) {}}

public unsafe class KimuraDebugMenu : ObjectBase<AKimuraDebugMenu>
{
    public KimuraDebugMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class KimuraURO : ObjectBase<AKimuraURO>
{
    public KimuraURO(IntPtr pointer) : base(pointer) {}
    public void Update(TArray<float> V)
    {
        Span<(string name, object value)> @params = [
            ("V", V)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void Enable(bool F)
    {
        Span<(string name, object value)> @params = [
            ("F", F)
        ];
        ProcessEvent(GetFunction("Enable"), @params);
    }
    public void Apply()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Apply"), @params);
    }
}

public unsafe class kitadeTestEditManager : ObjectBase<AkitadeTestEditManager>
{
    public kitadeTestEditManager(IntPtr pointer) : base(pointer) {}}

public unsafe class LaunchActivityActor : ObjectBase<ALaunchActivityActor>
{
    public LaunchActivityActor(IntPtr pointer) : base(pointer) {}}

public unsafe class LeaderBoardManager : ObjectBase<ULeaderBoardManager>
{
    public LeaderBoardManager(IntPtr pointer) : base(pointer) {}}

public unsafe class LipsyncAppObserverSubsystem : ObjectBase<ULipsyncAppObserverSubsystem>
{
    public LipsyncAppObserverSubsystem(IntPtr pointer) : base(pointer) {}
    public void StopAllSpeakCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAllSpeakCharacter"), @params);
    }
    public void StartSpeakCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID, int SoundMajorID, int SoundMinorID, bool bOverride)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("SoundMajorID", SoundMajorID), 
            ("SoundMinorID", SoundMinorID), 
            ("bOverride", bOverride)
        ];
        ProcessEvent(GetFunction("StartSpeakCharacter"), @params);
    }
    public bool IsSpeakingCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        return ProcessEvent<bool>(GetFunction("IsSpeakingCharacter"), @params);
    }
    public FCriLipsMorphTargetBlendAmountAsJapanese getLipsyncLiveInfo(int SoundMajorID, int SoundMinorID)
    {
        Span<(string name, object value)> @params = [
            ("SoundMajorID", SoundMajorID), 
            ("SoundMinorID", SoundMinorID)
        ];
        return ProcessEvent<FCriLipsMorphTargetBlendAmountAsJapanese>(GetFunction("getLipsyncLiveInfo"), @params);
    }
    public void FinishSpeakCharacterFromSoundID(int SoundMajorID, int SoundMinorID)
    {
        Span<(string name, object value)> @params = [
            ("SoundMajorID", SoundMajorID), 
            ("SoundMinorID", SoundMinorID)
        ];
        ProcessEvent(GetFunction("FinishSpeakCharacterFromSoundID"), @params);
    }
    public void FinishSpeakCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        ProcessEvent(GetFunction("FinishSpeakCharacter"), @params);
    }
}

public unsafe class LipsyncAppObserverSpeakWatcher : ObjectBase<ULipsyncAppObserverSpeakWatcher>
{
    public LipsyncAppObserverSpeakWatcher(IntPtr pointer) : base(pointer) {}
}

public unsafe class LoaderActor : ObjectBase<ALoaderActor>
{
    public LoaderActor(IntPtr pointer) : base(pointer) {}
    public void OnLoadFailed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFailed"), @params);
    }
    public void OnLoadCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted"), @params);
    }
}

public unsafe class Loading : ObjectBase<ULoading>
{
    public Loading(IntPtr pointer) : base(pointer) {}
    public void Start(ECldTimeZone Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("Start"), @params);
    }
    public void SpawnDrawActor(ALoadingDraw* LoadingDraw)
    {
        Span<(string name, object value)> @params = [
            ("LoadingDraw", (IntPtr)LoadingDraw)
        ];
        ProcessEvent(GetFunction("SpawnDrawActor"), @params);
    }
    public void End()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("End"), @params);
    }
}

public unsafe class LoadingDraw : ObjectBase<ALoadingDraw>
{
    public LoadingDraw(IntPtr pointer) : base(pointer) {}
    public void SetVisible(bool on)
    {
        Span<(string name, object value)> @params = [
            ("on", on)
        ];
        ProcessEvent(GetFunction("SetVisible"), @params);
    }
    public void SetTimeZone(ECldTimeZone inTimeShifting)
    {
        Span<(string name, object value)> @params = [
            ("inTimeShifting", inTimeShifting)
        ];
        ProcessEvent(GetFunction("SetTimeZone"), @params);
    }
    public void Draw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Draw"), @params);
    }
}

public unsafe class LocalizationTest : ObjectBase<ALocalizationTest>
{
    public LocalizationTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class TextureData : ObjectBase<ATextureData>
{
    public TextureData(IntPtr pointer) : base(pointer) {}
}

public unsafe class LocalizeStaffRoll : ObjectBase<ALocalizeStaffRoll>
{
    public LocalizeStaffRoll(IntPtr pointer) : base(pointer) {}
}

public unsafe class LocalizeStaffRollDraw : ObjectBase<ALocalizeStaffRollDraw>
{
    public LocalizeStaffRollDraw(IntPtr pointer) : base(pointer) {}}

public unsafe class MailActor : ObjectBase<AMailActor>
{
    public MailActor(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class MailDraw : ObjectBase<AMailDraw>
{
    public MailDraw(IntPtr pointer) : base(pointer) {}
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Out"), @params);
    }
    public bool StateDraw_Mail()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Mail"), @params);
    }
    public bool StateDraw_List()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_List"), @params);
    }
    public bool StateDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_IN"), @params);
    }
    public bool StateDraw_Frame()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Frame"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public void SetTouchCollision(int Index, float X, float Y, float Width, float Height, EUI_DRAW_POINT DrawPoint, bool onList)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("DrawPoint", DrawPoint), 
            ("onList", onList)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetScrollBarSliderCollision(float X, float Y, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarSliderCollision"), @params);
    }
    public void SetScrollBarBaseCollision(float X, float Y, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarBaseCollision"), @params);
    }
    public void SetMailListIsNew(int InIndex, bool InIsNew)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("InIsNew", InIsNew)
        ];
        ProcessEvent(GetFunction("SetMailListIsNew"), @params);
    }
    public void OneTimeLockInput()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OneTimeLockInput"), @params);
    }
    public bool IsIsDeterminedByCross()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsIsDeterminedByCross"), @params);
    }
    public bool InitDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_Out"), @params);
    }
    public bool InitDraw_Mail()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_Mail"), @params);
    }
    public bool InitDraw_List()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_List"), @params);
    }
    public bool InitDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_IN"), @params);
    }
    public int GetMailSenderID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMailSenderID"), @params);
    }
    public int GetListSenderID(int InIndex)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex)
        ];
        return ProcessEvent<int>(GetFunction("GetListSenderID"), @params);
    }
    public bool GetListIsRead(int InIndex)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex)
        ];
        return ProcessEvent<bool>(GetFunction("GetListIsRead"), @params);
    }
    public bool GetListIsNew(int InIndex)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex)
        ];
        return ProcessEvent<bool>(GetFunction("GetListIsNew"), @params);
    }
    public FVector2D GetAdjustedLayoutPosition(EMailLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAdjustedLayoutPosition"), @params);
    }
    public void DrawSprForUIResources(FVector2D InPos, FColor InColor, int SprID, FVector2D Scale, float Angle, EUICommonResource ResourceType, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("SprID", SprID), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("ResourceType", ResourceType), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("DrawSprForUIResources"), @params);
    }
    public void DrawMailTitleText(FVector2D InPos, FColor InColor, float InScale)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("DrawMailTitleText"), @params);
    }
    public void DrawMailSenderText(FVector2D InPos, FColor InColor, float InScale)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("DrawMailSenderText"), @params);
    }
    public void DrawMailMainText(FVector2D InPos, FColor InColor, float InScale)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("DrawMailMainText"), @params);
    }
    public void DrawListMailTitleText(int InIndex, FVector2D InPos, FColor InColor, float InScale)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("DrawListMailTitleText"), @params);
    }
    public void DrawListMailSenderText(int InIndex, FVector2D InPos, FColor InColor, float InScale)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("DrawListMailSenderText"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
}

public unsafe class MCATestActor : ObjectBase<AMCATestActor>
{
    public MCATestActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class MiyamuraTestManager : ObjectBase<AMiyamuraTestManager>
{
    public MiyamuraTestManager(IntPtr pointer) : base(pointer) {}}

public unsafe class MiyamuraLoadTest : ObjectBase<AMiyamuraLoadTest>
{
    public MiyamuraLoadTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestCharacter3 : ObjectBase<ATestCharacter3>
{
    public TestCharacter3(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestSplineCollision : ObjectBase<ATestSplineCollision>
{
    public TestSplineCollision(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestBoxCollision : ObjectBase<ATestBoxCollision>
{
    public TestBoxCollision(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestTriggerBox : ObjectBase<ATestTriggerBox>
{
    public TestTriggerBox(IntPtr pointer) : base(pointer) {}
    public void OnComponentOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnComponentOverlapEnd"), @params);
    }
    public void OnComponentOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnComponentOverlapBegin"), @params);
    }
}

public unsafe class TestActorComponent : ObjectBase<UTestActorComponent>
{
    public TestActorComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestAnimInst : ObjectBase<UTestAnimInst>
{
    public TestAnimInst(IntPtr pointer) : base(pointer) {}
    public void TestFunction(int Type, int Param)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("TestFunction"), @params);
    }
    public void AnimChange(int Type, int Param)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("AnimChange"), @params);
    }
}

public unsafe class CollisionActor : ObjectBase<UCollisionActor>
{
    public CollisionActor(IntPtr pointer) : base(pointer) {}
    public void OnEndOverlapSphere(UPrimitiveComponent* OverlappedComp, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComp", (IntPtr)OverlappedComp), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnEndOverlapSphere"), @params);
    }
    public void OnBeginOverlapSphere(UPrimitiveComponent* OverlappedComp, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComp", (IntPtr)OverlappedComp), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnBeginOverlapSphere"), @params);
    }
}

public unsafe class ModelTestComp : ObjectBase<UModelTestComp>
{
    public ModelTestComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class ModelTest : ObjectBase<AModelTest>
{
    public ModelTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieCuePointFunction : ObjectBase<UMovieCuePointFunction>
{
    public MovieCuePointFunction(IntPtr pointer) : base(pointer) {}
    public void MovieSetMetaDataWorkAllocator(UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("MovieSetMetaDataWorkAllocator"), @params);
    }
    public void MovieLoadAssetStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MovieLoadAssetStart"), @params);
    }
    public void MovieLoadAssetForCuePoint(UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("MovieLoadAssetForCuePoint"), @params);
    }
    public bool MovieIsLoadedAssetForCuePoint()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("MovieIsLoadedAssetForCuePoint"), @params);
    }
    public int MovieGetLanguageTrack()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("MovieGetLanguageTrack"), @params);
    }
    public int MovieCheckTrackId(UManaComponent* ManaComponent, int trackId)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent), 
            ("trackId", trackId)
        ];
        return ProcessEvent<int>(GetFunction("MovieCheckTrackId"), @params);
    }
    public void MovieBindCuePointFunction(UManaComponent* ManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("ManaComponent", (IntPtr)ManaComponent)
        ];
        ProcessEvent(GetFunction("MovieBindCuePointFunction"), @params);
    }
}

public unsafe class MovieCuePointManager : ObjectBase<UMovieCuePointManager>
{
    public MovieCuePointManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class MoviePanel : ObjectBase<UMoviePanel>
{
    public MoviePanel(IntPtr pointer) : base(pointer) {}
    public void SetOT(int OT)
    {
        Span<(string name, object value)> @params = [
            ("OT", OT)
        ];
        ProcessEvent(GetFunction("SetOT"), @params);
    }
}

public unsafe class MoviePlayActorBase : ObjectBase<AMoviePlayActorBase>
{
    public MoviePlayActorBase(IntPtr pointer) : base(pointer) {}
    public void Start()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Start"), @params);
    }
    public void SetManaComponent(UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("SetManaComponent"), @params);
    }
    public void RequestMovie(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("RequestMovie"), @params);
    }
    public void Remove()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Remove"), @params);
    }
    public void MoviePlay(FString OpenedUrl)
    {
        Span<(string name, object value)> @params = [
            ("OpenedUrl", OpenedUrl)
        ];
        ProcessEvent(GetFunction("MoviePlay"), @params);
    }
    public void MovieEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MovieEnd"), @params);
    }
    public void Close(bool ForceClose)
    {
        Span<(string name, object value)> @params = [
            ("ForceClose", ForceClose)
        ];
        ProcessEvent(GetFunction("Close"), @params);
    }
    public void CallOpenSourceForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallOpenSourceForBP"), @params);
    }
}

public unsafe class MoviePlayActor : ObjectBase<AMoviePlayActor>
{
    public MoviePlayActor(IntPtr pointer) : base(pointer) {}
    public void VisibleKeyHelp(bool bIsVisible)
    {
        Span<(string name, object value)> @params = [
            ("bIsVisible", bIsVisible)
        ];
        ProcessEvent(GetFunction("VisibleKeyHelp"), @params);
    }
    public bool SyncInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncInstance"), @params);
    }
    public void ReserveDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReserveDestroy"), @params);
    }
    public void Pause(bool IsPause)
    {
        Span<(string name, object value)> @params = [
            ("IsPause", IsPause)
        ];
        ProcessEvent(GetFunction("Pause"), @params);
    }
    public bool IsReserveDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReserveDestroy"), @params);
    }
    public bool IsPause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPause"), @params);
    }
    public bool IsBattleWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBattleWipe"), @params);
    }
    public AMoviePlayActor* GetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AMoviePlayActor*)ProcessEvent<IntPtr>(GetFunction("GetInstance"), @params);
    }
    public bool GetBGMFlg()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetBGMFlg"), @params);
    }
    public void CreateInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateInstance"), @params);
    }
    public bool CheckInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInstance"), @params);
    }
    public bool CanDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CanDestroy"), @params);
    }
}

public unsafe class MoviePlayActorBattle : ObjectBase<AMoviePlayActorBattle>
{
    public MoviePlayActorBattle(IntPtr pointer) : base(pointer) {}
    public bool SyncBattleMovieInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncBattleMovieInstance"), @params);
    }
    public void RequestStopperForBP(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("RequestStopperForBP"), @params);
    }
    public void RequestRemoveMaterialsForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRemoveMaterialsForBP"), @params);
    }
    public void MaterialStartForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MaterialStartForBP"), @params);
    }
    public AMoviePlayActorBattle* GetBattleMovieInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AMoviePlayActorBattle*)ProcessEvent<IntPtr>(GetFunction("GetBattleMovieInstance"), @params);
    }
    public void CreateBattleMovieInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateBattleMovieInstance"), @params);
    }
    public bool CheckPrepareForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPrepareForBP"), @params);
    }
    public bool CheckBattleMovieInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleMovieInstance"), @params);
    }
}

public unsafe class MoviePlayActorEventSequenceTrack : ObjectBase<AMoviePlayActorEventSequenceTrack>
{
    public MoviePlayActorEventSequenceTrack(IntPtr pointer) : base(pointer) {}
    public bool SyncInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncInstance"), @params);
    }
    public void SetPause_Main220040(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetPause_Main220040"), @params);
    }
    public void OnTextureUpdated(int InFrameNumber, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InFrameNumber", InFrameNumber), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("OnTextureUpdated"), @params);
    }
    public void OnSequenceUpdate(FQualifiedFrameTime InCurrentTime, FQualifiedFrameTime InPreviousTime)
    {
        Span<(string name, object value)> @params = [
            ("InCurrentTime", InCurrentTime), 
            ("InPreviousTime", InPreviousTime)
        ];
        ProcessEvent(GetFunction("OnSequenceUpdate"), @params);
    }
    public void OnSeekCompleted(int InFrameNumber, UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InFrameNumber", InFrameNumber), 
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("OnSeekCompleted"), @params);
    }
    public void OnBeginPlay(UManaComponent* InManaComponent)
    {
        Span<(string name, object value)> @params = [
            ("InManaComponent", (IntPtr)InManaComponent)
        ];
        ProcessEvent(GetFunction("OnBeginPlay"), @params);
    }
    public bool IsPause_Main220040()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPause_Main220040"), @params);
    }
    public AMoviePlayActorEventSequenceTrack* GetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AMoviePlayActorEventSequenceTrack*)ProcessEvent<IntPtr>(GetFunction("GetInstance"), @params);
    }
    public void CreateInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateInstance"), @params);
    }
    public bool CheckInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInstance"), @params);
    }
}

public unsafe class MoviePlayTest : ObjectBase<AMoviePlayTest>
{
    public MoviePlayTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundFadeSection : ObjectBase<UMovieSceneEvtAdxSoundFadeSection>
{
    public MovieSceneEvtAdxSoundFadeSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtConditionalBranchTrack : ObjectBase<UMovieSceneEvtConditionalBranchTrack>
{
    public MovieSceneEvtConditionalBranchTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundFadeTrack : ObjectBase<UMovieSceneEvtAdxSoundFadeTrack>
{
    public MovieSceneEvtAdxSoundFadeTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundManageSection : ObjectBase<UMovieSceneEvtAdxSoundManageSection>
{
    public MovieSceneEvtAdxSoundManageSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundManageTrack : ObjectBase<UMovieSceneEvtAdxSoundManageTrack>
{
    public MovieSceneEvtAdxSoundManageTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundSection : ObjectBase<UMovieSceneEvtAdxSoundSection>
{
    public MovieSceneEvtAdxSoundSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtAdxSoundTrack : ObjectBase<UMovieSceneEvtAdxSoundTrack>
{
    public MovieSceneEvtAdxSoundTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaAnimationSection : ObjectBase<UMovieSceneEvtCharaAnimationSection>
{
    public MovieSceneEvtCharaAnimationSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaAnimationTrack : ObjectBase<UMovieSceneEvtCharaAnimationTrack>
{
    public MovieSceneEvtCharaAnimationTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaHandwritingSection : ObjectBase<UMovieSceneEvtCharaHandwritingSection>
{
    public MovieSceneEvtCharaHandwritingSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaHandwritingTrack : ObjectBase<UMovieSceneEvtCharaHandwritingTrack>
{
    public MovieSceneEvtCharaHandwritingTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaOperationControllerSection : ObjectBase<UMovieSceneEvtCharaOperationControllerSection>
{
    public MovieSceneEvtCharaOperationControllerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaOperationControllerTrack : ObjectBase<UMovieSceneEvtCharaOperationControllerTrack>
{
    public MovieSceneEvtCharaOperationControllerTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPackAnimationSection : ObjectBase<UMovieSceneEvtCharaPackAnimationSection>
{
    public MovieSceneEvtCharaPackAnimationSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPackAnimationTrack : ObjectBase<UMovieSceneEvtCharaPackAnimationTrack>
{
    public MovieSceneEvtCharaPackAnimationTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPackFaceAnimationSection : ObjectBase<UMovieSceneEvtCharaPackFaceAnimationSection>
{
    public MovieSceneEvtCharaPackFaceAnimationSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPackFaceAnimationTrack : ObjectBase<UMovieSceneEvtCharaPackFaceAnimationTrack>
{
    public MovieSceneEvtCharaPackFaceAnimationTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPropAttachSection : ObjectBase<UMovieSceneEvtCharaPropAttachSection>
{
    public MovieSceneEvtCharaPropAttachSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtCharaPropAttachTrack : ObjectBase<UMovieSceneEvtCharaPropAttachTrack>
{
    public MovieSceneEvtCharaPropAttachTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtDialogueOptionsSection : ObjectBase<UMovieSceneEvtDialogueOptionsSection>
{
    public MovieSceneEvtDialogueOptionsSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtDialogueOptionsTrack : ObjectBase<UMovieSceneEvtDialogueOptionsTrack>
{
    public MovieSceneEvtDialogueOptionsTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtDialogueSection : ObjectBase<UMovieSceneEvtDialogueSection>
{
    public MovieSceneEvtDialogueSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtDialogueTrack : ObjectBase<UMovieSceneEvtDialogueTrack>
{
    public MovieSceneEvtDialogueTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtFadeScreenSection : ObjectBase<UMovieSceneEvtFadeScreenSection>
{
    public MovieSceneEvtFadeScreenSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtFadeScreenTrack : ObjectBase<UMovieSceneEvtFadeScreenTrack>
{
    public MovieSceneEvtFadeScreenTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtFieldAnimationSection : ObjectBase<UMovieSceneEvtFieldAnimationSection>
{
    public MovieSceneEvtFieldAnimationSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtFieldAnimationTrack : ObjectBase<UMovieSceneEvtFieldAnimationTrack>
{
    public MovieSceneEvtFieldAnimationTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtMessageSubtitleSection : ObjectBase<UMovieSceneEvtMessageSubtitleSection>
{
    public MovieSceneEvtMessageSubtitleSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtMessageSubtitleTrack : ObjectBase<UMovieSceneEvtMessageSubtitleTrack>
{
    public MovieSceneEvtMessageSubtitleTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtMovieSection : ObjectBase<UMovieSceneEvtMovieSection>
{
    public MovieSceneEvtMovieSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtMovieTrack : ObjectBase<UMovieSceneEvtMovieTrack>
{
    public MovieSceneEvtMovieTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtScriptSection : ObjectBase<UMovieSceneEvtScriptSection>
{
    public MovieSceneEvtScriptSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtScriptTrack : ObjectBase<UMovieSceneEvtScriptTrack>
{
    public MovieSceneEvtScriptTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtSeqControllerSection : ObjectBase<UMovieSceneEvtSeqControllerSection>
{
    public MovieSceneEvtSeqControllerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtSeqControllerTrack : ObjectBase<UMovieSceneEvtSeqControllerTrack>
{
    public MovieSceneEvtSeqControllerTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtSeqTimeJumpControllerSection : ObjectBase<UMovieSceneEvtSeqTimeJumpControllerSection>
{
    public MovieSceneEvtSeqTimeJumpControllerSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneEvtSeqTimeJumpControllerTrack : ObjectBase<UMovieSceneEvtSeqTimeJumpControllerTrack>
{
    public MovieSceneEvtSeqTimeJumpControllerTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgTest : ObjectBase<AMsgTest>
{
    public MsgTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class MyActor : ObjectBase<AMyActor>
{
    public MyActor(IntPtr pointer) : base(pointer) {}}

public unsafe class MyBlueprintFunctionLibrary : ObjectBase<UMyBlueprintFunctionLibrary>
{
    public MyBlueprintFunctionLibrary(IntPtr pointer) : base(pointer) {}}

public unsafe class NiagaraCameraAttachComponent : ObjectBase<UNiagaraCameraAttachComponent>
{
    public NiagaraCameraAttachComponent(IntPtr pointer) : base(pointer) {}
    public void SetAttachCam(USceneComponent* Parent)
    {
        Span<(string name, object value)> @params = [
            ("Parent", (IntPtr)Parent)
        ];
        ProcessEvent(GetFunction("SetAttachCam"), @params);
    }
    public void PlayEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayEffect"), @params);
    }
    public void OnLoadSystem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadSystem"), @params);
    }
    public void OnComplete(UNiagaraComponent* PSystem)
    {
        Span<(string name, object value)> @params = [
            ("PSystem", (IntPtr)PSystem)
        ];
        ProcessEvent(GetFunction("OnComplete"), @params);
    }
    public bool IsCallDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCallDestroy"), @params);
    }
    public bool IsAssetLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAssetLoaded"), @params);
    }
    public UNiagaraComponent* GetParticleComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("GetParticleComponent"), @params);
    }
}

public unsafe class NishidaTestMenu : ObjectBase<ANishidaTestMenu>
{
    public NishidaTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class NowatariTestMenu : ObjectBase<ANowatariTestMenu>
{
    public NowatariTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class OdagakiTestMenu : ObjectBase<AOdagakiTestMenu>
{
    public OdagakiTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class OkadaTestMenu : ObjectBase<AOkadaTestMenu>
{
    public OkadaTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class OtHUD : ObjectBase<AOtHUD>
{
    public OtHUD(IntPtr pointer) : base(pointer) {}}

public unsafe class PadRumble : ObjectBase<UPadRumble>
{
    public PadRumble(IntPtr pointer) : base(pointer) {}
}

public unsafe class PadRumbleSequencer : ObjectBase<APadRumbleSequencer>
{
    public PadRumbleSequencer(IntPtr pointer) : base(pointer) {}
    public void RumbleStopSmall()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RumbleStopSmall"), @params);
    }
    public void RumbleStopLarge()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RumbleStopLarge"), @params);
    }
    public void RumbleStopAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RumbleStopAsset"), @params);
    }
    public void RumbleStartSmall(int Frame, int WaitFrame, int Num, int TotalFram)
    {
        Span<(string name, object value)> @params = [
            ("Frame", Frame), 
            ("WaitFrame", WaitFrame), 
            ("Num", Num), 
            ("TotalFram", TotalFram)
        ];
        ProcessEvent(GetFunction("RumbleStartSmall"), @params);
    }
    public void RumbleStartLarge(int power, int Frame, int WaitFrame, int Num, int TotalFram)
    {
        Span<(string name, object value)> @params = [
            ("power", power), 
            ("Frame", Frame), 
            ("WaitFrame", WaitFrame), 
            ("Num", Num), 
            ("TotalFram", TotalFram)
        ];
        ProcessEvent(GetFunction("RumbleStartLarge"), @params);
    }
    public void RumbleStartAsset(UForceFeedbackEffect* pRumble, bool IsLoop)
    {
        Span<(string name, object value)> @params = [
            ("pRumble", (IntPtr)pRumble), 
            ("IsLoop", IsLoop)
        ];
        ProcessEvent(GetFunction("RumbleStartAsset"), @params);
    }
}

public unsafe class PartyPanelRecoveryEffect : ObjectBase<UPartyPanelRecoveryEffect>
{
    public PartyPanelRecoveryEffect(IntPtr pointer) : base(pointer) {}
}

public unsafe class PauseUserWidget : ObjectBase<UPauseUserWidget>
{
    public PauseUserWidget(IntPtr pointer) : base(pointer) {}
    public void SetTickableWhenPaused(bool bTickableWhenPaused)
    {
        Span<(string name, object value)> @params = [
            ("bTickableWhenPaused", bTickableWhenPaused)
        ];
        ProcessEvent(GetFunction("SetTickableWhenPaused"), @params);
    }
    public bool GetTickableWhenPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetTickableWhenPaused"), @params);
    }
}

public unsafe class PerformanceViewer : ObjectBase<APerformanceViewer>
{
    public PerformanceViewer(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusTest : ObjectBase<APersonaStatusTest>
{
    public PersonaStatusTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusViewer : ObjectBase<APersonaStatusViewer>
{
    public PersonaStatusViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class PlatformFunctionLibrary : ObjectBase<UPlatformFunctionLibrary>
{
    public PlatformFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public EPlatformName Platform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EPlatformName>(GetFunction("Platform"), @params);
    }
    public float GetFPS()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFPS"), @params);
    }
}

public unsafe class PreloadVolume : ObjectBase<APreloadVolume>
{
    public PreloadVolume(IntPtr pointer) : base(pointer) {}
    public void OnOverlapEnd(AActor* OverlappedActor, AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedActor", (IntPtr)OverlappedActor), 
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("OnOverlapEnd"), @params);
    }
    public void OnOverlapBegin(AActor* OverlappedActor, AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedActor", (IntPtr)OverlappedActor), 
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("OnOverlapBegin"), @params);
    }
    public void LoadComplete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadComplete"), @params);
    }
}

public unsafe class QuestDisappearList : ObjectBase<UQuestDisappearList>
{
    public QuestDisappearList(IntPtr pointer) : base(pointer) {}
}

public unsafe class QuestElizMessage : ObjectBase<UQuestElizMessage>
{
    public QuestElizMessage(IntPtr pointer) : base(pointer) {}}

public unsafe class QuestElizRequest : ObjectBase<UQuestElizRequest>
{
    public QuestElizRequest(IntPtr pointer) : base(pointer) {}
}

public unsafe class RankUpTest : ObjectBase<ARankUpTest>
{
    public RankUpTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class RightsNotation : ObjectBase<ARightsNotation>
{
    public RightsNotation(IntPtr pointer) : base(pointer) {}
}

public unsafe class RightsNotationDraw : ObjectBase<ARightsNotationDraw>
{
    public RightsNotationDraw(IntPtr pointer) : base(pointer) {}
    public void Update()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
}

public unsafe class sainoTestEditManager : ObjectBase<AsainoTestEditManager>
{
    public sainoTestEditManager(IntPtr pointer) : base(pointer) {}}

public unsafe class NetworkWindowTest : ObjectBase<ANetworkWindowTest>
{
    public NetworkWindowTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class SaveLoadDraw : ObjectBase<ASaveLoadDraw>
{
    public SaveLoadDraw(IntPtr pointer) : base(pointer) {}
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDraw_Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Update"), @params);
    }
    public bool StateDraw_SaveDataList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_SaveDataList"), @params);
    }
    public bool StateDraw_Close()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Close"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public void SetTouchCollision(int Index, bool isSelected, float X, float Y, float Width, float Height, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("isSelected", isSelected), 
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetScrollBarSliderCollision(float X, float Y, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarSliderCollision"), @params);
    }
    public void SetScrollBarCollision(float X, float Y, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarCollision"), @params);
    }
    public void SetScrollBarBaseCollision(float X, float Y, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarBaseCollision"), @params);
    }
    public void ProcessCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcessCompleted__DelegateSignature"), @params);
    }
    public void PLNameFontDraw(float X, float Y, FString String, FColor Color, float Scale, float Angle, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("String", String), 
            ("Color", Color), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("PLNameFontDraw"), @params);
    }
    public void PlayListInSE()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayListInSE"), @params);
    }
    public void LocationNameDraw(float X, float Y, float Z, FString String, byte R, byte G, byte B, byte A, float Scale, float Angle, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("LocationNameDraw"), @params);
    }
    public bool IsMonthDayDisplayLanguages()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsMonthDayDisplayLanguages"), @params);
    }
    public bool IsDebugDrawClearData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDebugDrawClearData"), @params);
    }
    public bool IsDayZeroPaddingLanguages(int InMonth)
    {
        Span<(string name, object value)> @params = [
            ("InMonth", InMonth)
        ];
        return ProcessEvent<bool>(GetFunction("IsDayZeroPaddingLanguages"), @params);
    }
    public bool IsCheckedNetworkSave()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCheckedNetworkSave"), @params);
    }
    public int GetSelDebugMonth(int InMonth)
    {
        Span<(string name, object value)> @params = [
            ("InMonth", InMonth)
        ];
        return ProcessEvent<int>(GetFunction("GetSelDebugMonth"), @params);
    }
    public int GetSelDebugDay(int InDay)
    {
        Span<(string name, object value)> @params = [
            ("InDay", InDay)
        ];
        return ProcessEvent<int>(GetFunction("GetSelDebugDay"), @params);
    }
    public int GetDebugMonth(int InMonth)
    {
        Span<(string name, object value)> @params = [
            ("InMonth", InMonth)
        ];
        return ProcessEvent<int>(GetFunction("GetDebugMonth"), @params);
    }
    public int GetDebugDay(int InDay)
    {
        Span<(string name, object value)> @params = [
            ("InDay", InDay)
        ];
        return ProcessEvent<int>(GetFunction("GetDebugDay"), @params);
    }
    public void DrawTextureEx(float X, float Y, float Width, float Height, UTexture* TextureHandle, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("TextureHandle", (IntPtr)TextureHandle), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("DrawTextureEx"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
    public void CallOnFinishedInAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallOnFinishedInAnim"), @params);
    }
    public void CallOnFinishedCloseAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallOnFinishedCloseAnim"), @params);
    }
    public FVector2D AdjustedLayoutPos(ESaveLoadLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("AdjustedLayoutPos"), @params);
    }
    public FVector2D AdjustedLayout2Pos(ESaveLoadLayout2 InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("AdjustedLayout2Pos"), @params);
    }
    public FVector2D AdjustedDateLayoutPos(ESaveLoadDateLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("AdjustedDateLayoutPos"), @params);
    }
}

public unsafe class ScrActor : ObjectBase<AScrActor>
{
    public ScrActor(IntPtr pointer) : base(pointer) {}
    public void ForcedStopScr()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForcedStopScr"), @params);
    }
}

public unsafe class SeqBpFuncLib : ObjectBase<USeqBpFuncLib>
{
    public SeqBpFuncLib(IntPtr pointer) : base(pointer) {}
    public void StartGameSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartGameSequence"), @params);
    }
    public void GoToTartarus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GoToTartarus"), @params);
    }
    public void CallWeaponShop(UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CallWeaponShop"), @params);
    }
    public void CallTitle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallTitle"), @params);
    }
    public void CallKeyfreeEvent(int FieldMajor, int FieldMinor, int KeyfreeEventID, int PlayerStartID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajor", FieldMajor), 
            ("FieldMinor", FieldMinor), 
            ("KeyfreeEventID", KeyfreeEventID), 
            ("PlayerStartID", PlayerStartID)
        ];
        ProcessEvent(GetFunction("CallKeyfreeEvent"), @params);
    }
    public void CallItemShop(UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CallItemShop"), @params);
    }
    public void CallField(int FieldMajor, int FieldMinor, int PlayerStartID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajor", FieldMajor), 
            ("FieldMinor", FieldMinor), 
            ("PlayerStartID", PlayerStartID)
        ];
        ProcessEvent(GetFunction("CallField"), @params);
    }
    public void CallEventCmm(int EventMajor, int EventMinor, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("EventMajor", EventMajor), 
            ("EventMinor", EventMinor), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CallEventCmm"), @params);
    }
    public void CallEvent(int EventMajor, int EventMinor, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("EventMajor", EventMajor), 
            ("EventMinor", EventMinor), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CallEvent"), @params);
    }
    public void CallCalendar()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallCalendar"), @params);
    }
    public void CallBattle(int EncountID, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("EncountID", EncountID), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CallBattle"), @params);
    }
}

public unsafe class Sequence : ObjectBase<USequence>
{
    public Sequence(IntPtr pointer) : base(pointer) {}}

public unsafe class ShdParameter : ObjectBase<UShdParameter>
{
    public ShdParameter(IntPtr pointer) : base(pointer) {}}

public unsafe class SignedInDialog : ObjectBase<USignedInDialog>
{
    public SignedInDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class ErrorDialog : ObjectBase<UErrorDialog>
{
    public ErrorDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class MessageDialog : ObjectBase<UMessageDialog>
{
    public MessageDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class SimpleShopDraw : ObjectBase<ASimpleShopDraw>
{
    public SimpleShopDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class SoundApp : ObjectBase<USoundApp>
{
    public SoundApp(IntPtr pointer) : base(pointer) {}
    public void StopSingleVoice(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("StopSingleVoice"), @params);
    }
    public void StopFacilityVoice(int CharaIndexID, bool UseAttenuator, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CharaIndexID", CharaIndexID), 
            ("UseAttenuator", UseAttenuator), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopFacilityVoice"), @params);
    }
    public void StopEventVoiceWithLipSync(EAppCharCategoryType CharcterCategoryType, int CharaIndexID, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopEventVoiceWithLipSync"), @params);
    }
    public void StopEventVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopEventVoice"), @params);
    }
    public void StopEventSE(int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopEventSE"), @params);
    }
    public void StopComSE(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("StopComSE"), @params);
    }
    public void StopBGM_IMD()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopBGM_IMD"), @params);
    }
    public void StopBGM()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopBGM"), @params);
    }
    public void StopBattleEventVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopBattleEventVoice"), @params);
    }
    public void StopBackLogVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("StopBackLogVoice"), @params);
    }
    public void SetSystemPausePlayerAll(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("SetSystemPausePlayerAll"), @params);
    }
    public void SetSelectorLabel(int PlayerMajorID, int PlayerMinorID, FString Selector, FString Label)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID), 
            ("Selector", Selector), 
            ("Label", Label)
        ];
        ProcessEvent(GetFunction("SetSelectorLabel"), @params);
    }
    public void SetPausePlayerAll(bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("SetPausePlayerAll"), @params);
    }
    public void SetPausePlayer(int majorId, int minorId, bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("majorId", majorId), 
            ("minorId", minorId), 
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("SetPausePlayer"), @params);
    }
    public void SetAisacByNameVOICE(float ControlValue)
    {
        Span<(string name, object value)> @params = [
            ("ControlValue", ControlValue)
        ];
        ProcessEvent(GetFunction("SetAisacByNameVOICE"), @params);
    }
    public void SetAisacByNameSE(float ControlValue)
    {
        Span<(string name, object value)> @params = [
            ("ControlValue", ControlValue)
        ];
        ProcessEvent(GetFunction("SetAisacByNameSE"), @params);
    }
    public void SetAisacByNameBGM(float ControlValue)
    {
        Span<(string name, object value)> @params = [
            ("ControlValue", ControlValue)
        ];
        ProcessEvent(GetFunction("SetAisacByNameBGM"), @params);
    }
    public void ResetSelectorLabel(int PlayerMajorID, int PlayerMinorID)
    {
        Span<(string name, object value)> @params = [
            ("PlayerMajorID", PlayerMajorID), 
            ("PlayerMinorID", PlayerMinorID)
        ];
        ProcessEvent(GetFunction("ResetSelectorLabel"), @params);
    }
    public bool ReqReadFacilityVoiceData(FString Filename, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReqReadFacilityVoiceData"), @params);
    }
    public bool ReqReadEventVoiceData(FString Filename, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReqReadEventVoiceData"), @params);
    }
    public bool ReqReadBattleEventVoiceData(FString Filename, int BankNum, bool UseLipsync)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename), 
            ("BankNum", BankNum), 
            ("UseLipsync", UseLipsync)
        ];
        return ProcessEvent<bool>(GetFunction("ReqReadBattleEventVoiceData"), @params);
    }
    public bool ReqReadBackLogVoiceData(FString Filename, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReqReadBackLogVoiceData"), @params);
    }
    public bool ReleaseFacilityVoiceData(UGameInstance* GameInst, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("GameInst", (IntPtr)GameInst), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReleaseFacilityVoiceData"), @params);
    }
    public bool ReleaseEventVoiceData(UGameInstance* GameInst, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("GameInst", (IntPtr)GameInst), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReleaseEventVoiceData"), @params);
    }
    public bool ReleaseBattleEventVoiceData(UGameInstance* GameInst, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("GameInst", (IntPtr)GameInst), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReleaseBattleEventVoiceData"), @params);
    }
    public bool ReleaseBackLogVoiceData(UGameInstance* GameInst, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("GameInst", (IntPtr)GameInst), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("ReleaseBackLogVoiceData"), @params);
    }
    public void PlayVoiceWithSimpleLipCustomParam(ref FCharacterSimpleLipsAnimAppParam SimpleLipsParam, int CueId, int SoundMajorID, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("SimpleLipsParam", SimpleLipsParam), 
            ("CueId", CueId), 
            ("SoundMajorID", SoundMajorID), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayVoiceWithSimpleLipCustomParam"), @params);
    }
    public void PlayVoiceWithLipsync(EAppCharCategoryType CharcterCategoryType, int CharaIndexID, int CueId, int SoundMajorID, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("CueId", CueId), 
            ("SoundMajorID", SoundMajorID), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayVoiceWithLipsync"), @params);
    }
    public void PlaySingleVoice(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("PlaySingleVoice"), @params);
    }
    public void PlayFacilityVoice(int CueId, int CharaIndexID, bool UseAttenuator, int BankNum, bool UseLips)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("CharaIndexID", CharaIndexID), 
            ("UseAttenuator", UseAttenuator), 
            ("BankNum", BankNum), 
            ("UseLips", UseLips)
        ];
        ProcessEvent(GetFunction("PlayFacilityVoice"), @params);
    }
    public void PlayEventVoiceWithSimpleLipCustomParam(ref FCharacterSimpleLipsAnimAppParam SimpleLipsParam, int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("SimpleLipsParam", SimpleLipsParam), 
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayEventVoiceWithSimpleLipCustomParam"), @params);
    }
    public void PlayEventVoiceWithLipsync(EAppCharCategoryType CharcterCategoryType, int CharaIndexID, int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayEventVoiceWithLipsync"), @params);
    }
    public void PlayEventVoice(int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayEventVoice"), @params);
    }
    public void PlayEventSE(int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayEventSE"), @params);
    }
    public void PlayComSE(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("PlayComSE"), @params);
    }
    public void PlayBGM(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("PlayBGM"), @params);
    }
    public void PlayBattleEventVoiceWithLipsync(EAppCharCategoryType CategoryType, int CharaIndexID, int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CategoryType", CategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayBattleEventVoiceWithLipsync"), @params);
    }
    public void PlayBattleEventVoice(int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayBattleEventVoice"), @params);
    }
    public void PlayBattleBGM(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("PlayBattleBGM"), @params);
    }
    public void PlayBackLogVoice(int CueId, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId), 
            ("BankNum", BankNum)
        ];
        ProcessEvent(GetFunction("PlayBackLogVoice"), @params);
    }
    public void PauseEventVoice(int BankNum, bool bPause)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum), 
            ("bPause", bPause)
        ];
        ProcessEvent(GetFunction("PauseEventVoice"), @params);
    }
    public bool IsSetupEndFacilityVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsSetupEndFacilityVoiceData"), @params);
    }
    public bool IsSetupEndEventVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsSetupEndEventVoiceData"), @params);
    }
    public bool IsSetupEndBattleEventVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsSetupEndBattleEventVoiceData"), @params);
    }
    public bool IsSetupEndBackLogVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsSetupEndBackLogVoiceData"), @params);
    }
    public bool IsPlayingSingleVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingSingleVoice"), @params);
    }
    public bool IsPlayingFacilityVoice(bool UseAttenuator, int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("UseAttenuator", UseAttenuator), 
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingFacilityVoice"), @params);
    }
    public bool IsPlayingEventVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingEventVoice"), @params);
    }
    public bool IsPlayingComSE(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingComSE"), @params);
    }
    public bool IsPlayingBattleEventVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingBattleEventVoice"), @params);
    }
    public bool IsPlayingBackLogVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingBackLogVoice"), @params);
    }
    public bool IsActiveFacilityVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsActiveFacilityVoiceData"), @params);
    }
    public bool IsActiveEventVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsActiveEventVoiceData"), @params);
    }
    public bool IsActiveBattleEventVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsActiveBattleEventVoiceData"), @params);
    }
    public bool IsActiveBackLogVoiceData(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("IsActiveBackLogVoiceData"), @params);
    }
    public void Init()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Init"), @params);
    }
    public float GetTime(int majorId, int minorId)
    {
        Span<(string name, object value)> @params = [
            ("majorId", majorId), 
            ("minorId", minorId)
        ];
        return ProcessEvent<float>(GetFunction("GetTime"), @params);
    }
    public int GetNowPlayBGMQueID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowPlayBGMQueID"), @params);
    }
    public FCriLipsMorphTargetBlendAmountAsJapanese getLipsyncLiveInfo(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<FCriLipsMorphTargetBlendAmountAsJapanese>(GetFunction("getLipsyncLiveInfo"), @params);
    }
    public float GetLength(int majorId, int minorId, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("majorId", majorId), 
            ("minorId", minorId), 
            ("CueId", CueId)
        ];
        return ProcessEvent<float>(GetFunction("GetLength"), @params);
    }
    public FString GetCurrentAppliedSnapshot()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetCurrentAppliedSnapshot"), @params);
    }
    public void FadeOutComSE(int FadeOutFrame)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutFrame", FadeOutFrame)
        ];
        ProcessEvent(GetFunction("FadeOutComSE"), @params);
    }
    public void FadeOutCategoryBGM(int FadeOutFrame, float fadeOutVolume)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutFrame", FadeOutFrame), 
            ("fadeOutVolume", fadeOutVolume)
        ];
        ProcessEvent(GetFunction("FadeOutCategoryBGM"), @params);
    }
    public void FadeoutBGM(int FadeOutFrame)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutFrame", FadeOutFrame)
        ];
        ProcessEvent(GetFunction("FadeoutBGM"), @params);
    }
    public void FadeInCategoryBGM(int FadeInFrame, float fadeOutVolume)
    {
        Span<(string name, object value)> @params = [
            ("FadeInFrame", FadeInFrame), 
            ("fadeOutVolume", fadeOutVolume)
        ];
        ProcessEvent(GetFunction("FadeInCategoryBGM"), @params);
    }
    public void FadeInBGM(int FadeOutFrame)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutFrame", FadeOutFrame)
        ];
        ProcessEvent(GetFunction("FadeInBGM"), @params);
    }
    public void DetachDspBusSetting()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DetachDspBusSetting"), @params);
    }
    public bool CheckPauseEventVoice(int BankNum)
    {
        Span<(string name, object value)> @params = [
            ("BankNum", BankNum)
        ];
        return ProcessEvent<bool>(GetFunction("CheckPauseEventVoice"), @params);
    }
    public void AttachDspBusSetting(FString SettingName)
    {
        Span<(string name, object value)> @params = [
            ("SettingName", SettingName)
        ];
        ProcessEvent(GetFunction("AttachDspBusSetting"), @params);
    }
    public void ApplyDspBusSnapshot(FString SnapshotName, int Millisecond)
    {
        Span<(string name, object value)> @params = [
            ("SnapshotName", SnapshotName), 
            ("Millisecond", Millisecond)
        ];
        ProcessEvent(GetFunction("ApplyDspBusSnapshot"), @params);
    }
}

public unsafe class SoundDataAssets : ObjectBase<USoundDataAssets>
{
    public SoundDataAssets(IntPtr pointer) : base(pointer) {}
}

public unsafe class SoundMonitoring : ObjectBase<ASoundMonitoring>
{
    public SoundMonitoring(IntPtr pointer) : base(pointer) {}
    public int startReadAcb(FString Filename)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename)
        ];
        return ProcessEvent<int>(GetFunction("startReadAcb"), @params);
    }
    public int startFreePlayer(int PlayerId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId)
        ];
        return ProcessEvent<int>(GetFunction("startFreePlayer"), @params);
    }
    public int startFreeAcb(int bankID)
    {
        Span<(string name, object value)> @params = [
            ("bankID", bankID)
        ];
        return ProcessEvent<int>(GetFunction("startFreeAcb"), @params);
    }
    public void setReadBankToPlayer(int PlayerId, int readBank)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("readBank", readBank)
        ];
        ProcessEvent(GetFunction("setReadBankToPlayer"), @params);
    }
    public int playCueID(int PlayerId, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("CueId", CueId)
        ];
        return ProcessEvent<int>(GetFunction("playCueID"), @params);
    }
    public bool fadeOutBGMCategorySoundMonitor(int fadeOutTime, float fadeOutVolume)
    {
        Span<(string name, object value)> @params = [
            ("fadeOutTime", fadeOutTime), 
            ("fadeOutVolume", fadeOutVolume)
        ];
        return ProcessEvent<bool>(GetFunction("fadeOutBGMCategorySoundMonitor"), @params);
    }
    public bool fadeInBGMCategorySoundMonitor(int fadeInTime, float fadeInVolume)
    {
        Span<(string name, object value)> @params = [
            ("fadeInTime", fadeInTime), 
            ("fadeInVolume", fadeInVolume)
        ];
        return ProcessEvent<bool>(GetFunction("fadeInBGMCategorySoundMonitor"), @params);
    }
    public bool createPlayer(int PlayerId, EsoundPlayerType Type)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("createPlayer"), @params);
    }
    public bool checkReadySoundMonitor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("checkReadySoundMonitor"), @params);
    }
    public bool checkReadyPlayer(int PlayerId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId)
        ];
        return ProcessEvent<bool>(GetFunction("checkReadyPlayer"), @params);
    }
    public bool checkReadBank(int readBank)
    {
        Span<(string name, object value)> @params = [
            ("readBank", readBank)
        ];
        return ProcessEvent<bool>(GetFunction("checkReadBank"), @params);
    }
}

public unsafe class SoundMonitorReadyAsyncFunction : ObjectBase<USoundMonitorReadyAsyncFunction>
{
    public SoundMonitorReadyAsyncFunction(IntPtr pointer) : base(pointer) {}
    public USoundMonitorReadyAsyncFunction* SoundMonitorReadyAsync(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (USoundMonitorReadyAsyncFunction*)ProcessEvent<IntPtr>(GetFunction("SoundMonitorReadyAsyncFunction"), @params);
    }
}

public unsafe class SoundMonitorACBReadAsyncFunction : ObjectBase<USoundMonitorACBReadAsyncFunction>
{
    public SoundMonitorACBReadAsyncFunction(IntPtr pointer) : base(pointer) {}
    public USoundMonitorACBReadAsyncFunction* SoundMonitorACBReadAsync(UObject* WorldContextObject, int acbBankID)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("acbBankID", acbBankID)
        ];
        return (USoundMonitorACBReadAsyncFunction*)ProcessEvent<IntPtr>(GetFunction("SoundMonitorACBReadAsyncFunction"), @params);
    }
}

public unsafe class SoundPlayerActor : ObjectBase<ASoundPlayerActor>
{
    public SoundPlayerActor(IntPtr pointer) : base(pointer) {}}

public unsafe class SoundTableTypes : ObjectBase<USoundTableTypes>
{
    public SoundTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class DatDlcBgmTable : ObjectBase<UDatDlcBgmTable>
{
    public DatDlcBgmTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class soundTestGameInstance : ObjectBase<UsoundTestGameInstance>
{
    public soundTestGameInstance(IntPtr pointer) : base(pointer) {}
    public UPlayAdxControl* GetPlayAdxControl()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPlayAdxControl*)ProcessEvent<IntPtr>(GetFunction("GetPlayAdxControl"), @params);
    }
    public UPakFileManagerControl* GetFileManagerControl()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPakFileManagerControl*)ProcessEvent<IntPtr>(GetFunction("GetFileManagerControl"), @params);
    }
}

public unsafe class StaffRoll : ObjectBase<AStaffRoll>
{
    public StaffRoll(IntPtr pointer) : base(pointer) {}
    public void Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public bool Start(short Type, bool RoundFlg)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("RoundFlg", RoundFlg)
        ];
        return ProcessEvent<bool>(GetFunction("Start"), @params);
    }
    public void Draw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Draw"), @params);
    }
}

public unsafe class StaffRollDataAsset : ObjectBase<UStaffRollDataAsset>
{
    public StaffRollDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class StaffRollDebugViewer : ObjectBase<AStaffRollDebugViewer>
{
    public StaffRollDebugViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class StaffRollDraw : ObjectBase<AStaffRollDraw>
{
    public StaffRollDraw(IntPtr pointer) : base(pointer) {}
    public void Draw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Draw"), @params);
    }
}

public unsafe class SteamInputLibrary : ObjectBase<USteamInputLibrary>
{
    public SteamInputLibrary(IntPtr pointer) : base(pointer) {}
    public bool SteamInputPadPress_RightUp()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_RightUp"), @params);
    }
    public bool SteamInputPadPress_RightRight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_RightRight"), @params);
    }
    public bool SteamInputPadPress_RightLeft()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_RightLeft"), @params);
    }
    public bool SteamInputPadPress_RightDown()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_RightDown"), @params);
    }
    public bool SteamInputPadPress_R3()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_R3"), @params);
    }
    public bool SteamInputPadPress_R2()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_R2"), @params);
    }
    public bool SteamInputPadPress_R1()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_R1"), @params);
    }
    public bool SteamInputPadPress_LeftUp()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_LeftUp"), @params);
    }
    public bool SteamInputPadPress_LeftRight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_LeftRight"), @params);
    }
    public bool SteamInputPadPress_LeftLeft()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_LeftLeft"), @params);
    }
    public bool SteamInputPadPress_LeftDown()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_LeftDown"), @params);
    }
    public bool SteamInputPadPress_L3()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_L3"), @params);
    }
    public bool SteamInputPadPress_L2()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_L2"), @params);
    }
    public bool SteamInputPadPress_L1()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputPadPress_L1"), @params);
    }
    public bool SteamInputInitialize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SteamInputInitialize"), @params);
    }
    public void SteamInitializeLanguage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SteamInitializeLanguage"), @params);
    }
    public ESteamControllerType GetInputTypeName(int nIndex)
    {
        Span<(string name, object value)> @params = [
            ("nIndex", nIndex)
        ];
        return ProcessEvent<ESteamControllerType>(GetFunction("GetInputTypeName"), @params);
    }
}

public unsafe class SuzukiDrawTest : ObjectBase<ASuzukiDrawTest>
{
    public SuzukiDrawTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class SuzukiDrawTestDraw : ObjectBase<ASuzukiDrawTestDraw>
{
    public SuzukiDrawTestDraw(IntPtr pointer) : base(pointer) {}
    public void Update(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public bool SyncModelCapture(FTransform modelTransform, FVector NewGazeOffset)
    {
        Span<(string name, object value)> @params = [
            ("modelTransform", modelTransform), 
            ("NewGazeOffset", NewGazeOffset)
        ];
        return ProcessEvent<bool>(GetFunction("SyncModelCapture"), @params);
    }
    public void FromBPDraw(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("FromBPDraw"), @params);
    }
}

public unsafe class suzukiTestMenu : ObjectBase<AsuzukiTestMenu>
{
    public suzukiTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class SystemViewer : ObjectBase<ASystemViewer>
{
    public SystemViewer(IntPtr pointer) : base(pointer) {}}

public unsafe class TaskActor : ObjectBase<ATaskActor>
{
    public TaskActor(IntPtr pointer) : base(pointer) {}}

public unsafe class TCSSaveData : ObjectBase<UTCSSaveData>
{
    public TCSSaveData(IntPtr pointer) : base(pointer) {}}

public unsafe class TestIguchiFuncLib : ObjectBase<UTestIguchiFuncLib>
{
    public TestIguchiFuncLib(IntPtr pointer) : base(pointer) {}
    public void StartReplaceCostumeID()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartReplaceCostumeID"), @params);
    }
}

public unsafe class TestMultiDraw : ObjectBase<ATestMultiDraw>
{
    public TestMultiDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestNishidaGameMode : ObjectBase<ATestNishidaGameMode>
{
    public TestNishidaGameMode(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestNishidaResource : ObjectBase<UTestNishidaResource>
{
    public TestNishidaResource(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestNishidaResourceActor : ObjectBase<ATestNishidaResourceActor>
{
    public TestNishidaResourceActor(IntPtr pointer) : base(pointer) {}
    public void Load()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Load"), @params);
    }
}

public unsafe class TestPauseSoundClass : ObjectBase<UTestPauseSoundClass>
{
    public TestPauseSoundClass(IntPtr pointer) : base(pointer) {}
    public void testPauseSoundPasue(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("testPauseSoundPasue"), @params);
    }
}

public unsafe class TestSaveGameActor : ObjectBase<ATestSaveGameActor>
{
    public TestSaveGameActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class TestSprAppActor : ObjectBase<ATestSprAppActor>
{
    public TestSprAppActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class TheurgiaActor : ObjectBase<ATheurgiaActor>
{
    public TheurgiaActor(IntPtr pointer) : base(pointer) {}}

public unsafe class TheurgiaDraw : ObjectBase<ATheurgiaDraw>
{
    public TheurgiaDraw(IntPtr pointer) : base(pointer) {}
    public void UpdateTimes(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateTimes"), @params);
    }
    public void SetCurrsorIndex(int No)
    {
        Span<(string name, object value)> @params = [
            ("No", No)
        ];
        ProcessEvent(GetFunction("SetCurrsorIndex"), @params);
    }
    public void OpenSkillHelp()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OpenSkillHelp"), @params);
    }
    public int GetTheurgiaListMax()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetTheurgiaListMax"), @params);
    }
    public int GetTheurgiaCursorIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetTheurgiaCursorIndex"), @params);
    }
    public void DrawTheurgiaName(float X, float Y, int Index)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("DrawTheurgiaName"), @params);
    }
    public void DrawTheurgiaHelp(float X, float Y, int Index)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("DrawTheurgiaHelp"), @params);
    }
    public void DrawRiseTrend(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawRiseTrend"), @params);
    }
    public void DrawCharaName(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawCharaName"), @params);
    }
    public void DrawCharacteristicName(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawCharacteristicName"), @params);
    }
    public void DrawCharacteristicHelp(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawCharacteristicHelp"), @params);
    }
    public void CloseSkillHelp()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseSkillHelp"), @params);
    }
}

public unsafe class TitleActor : ObjectBase<ATitleActor>
{
    public TitleActor(IntPtr pointer) : base(pointer) {}
    public void OnLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoaded"), @params);
    }
}

public unsafe class TitleLogoActor : ObjectBase<ATitleLogoActor>
{
    public TitleLogoActor(IntPtr pointer) : base(pointer) {}
    public bool IsGameClear()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsGameClear"), @params);
    }
    public float GetAlpha()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAlpha"), @params);
    }
}

public unsafe class TitleStateBase : ObjectBase<UTitleStateBase>
{
    public TitleStateBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class TitleStateCaution : ObjectBase<UTitleStateCaution>
{
    public TitleStateCaution(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateComeBackLoad : ObjectBase<UTitleStateComeBackLoad>
{
    public TitleStateComeBackLoad(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateConfig : ObjectBase<UTitleStateConfig>
{
    public TitleStateConfig(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateDebugScript : ObjectBase<UTitleStateDebugScript>
{
    public TitleStateDebugScript(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateExit : ObjectBase<UTitleStateExit>
{
    public TitleStateExit(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateLoadGame : ObjectBase<UTitleStateLoadGame>
{
    public TitleStateLoadGame(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppDataAsset : ObjectBase<UAppDataAsset>
{
    public AppDataAsset(IntPtr pointer) : base(pointer) {}
    public void Import()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Import"), @params);
    }
}

public unsafe class TitleStateNetworkCheck : ObjectBase<UTitleStateNetworkCheck>
{
    public TitleStateNetworkCheck(IntPtr pointer) : base(pointer) {}
}

public unsafe class TitleStateNewGame : ObjectBase<UTitleStateNewGame>
{
    public TitleStateNewGame(IntPtr pointer) : base(pointer) {}
    public void OnCloseDifficultySelection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnCloseDifficultySelection"), @params);
    }
    public void OnCanselDifficultySelection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnCanselDifficultySelection"), @params);
    }
}

public unsafe class TitleStateOP : ObjectBase<UTitleStateOP>
{
    public TitleStateOP(IntPtr pointer) : base(pointer) {}
}

public unsafe class TitleStatePhotosensitiveCaution : ObjectBase<UTitleStatePhotosensitiveCaution>
{
    public TitleStatePhotosensitiveCaution(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStatePressWait : ObjectBase<UTitleStatePressWait>
{
    public TitleStatePressWait(IntPtr pointer) : base(pointer) {}}

public unsafe class TitleStateSelect : ObjectBase<UTitleStateSelect>
{
    public TitleStateSelect(IntPtr pointer) : base(pointer) {}}

public unsafe class TrophyManager : ObjectBase<UTrophyManager>
{
    public TrophyManager(IntPtr pointer) : base(pointer) {}}

public unsafe class TutorialTableDataAsset : ObjectBase<UTutorialTableDataAsset>
{
    public TutorialTableDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class TutorialViewer : ObjectBase<ATutorialViewer>
{
    public TutorialViewer(IntPtr pointer) : base(pointer) {}}

public unsafe class UIAccessInfoDraw : ObjectBase<AUIAccessInfoDraw>
{
    public UIAccessInfoDraw(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class UIActionSuggestionDraw : ObjectBase<AUIActionSuggestionDraw>
{
    public UIActionSuggestionDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIArcanaCardCapture : ObjectBase<AUIArcanaCardCapture>
{
    public UIArcanaCardCapture(IntPtr pointer) : base(pointer) {}
    public void StartPoemOutAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPoemOutAnime"), @params);
    }
    public void StartAnimeReverse()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAnimeReverse"), @params);
    }
    public void StartAnimeRecoveryTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAnimeRecoveryTurn"), @params);
    }
    public void StartAnimeRecoveryOutv()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAnimeRecoveryOutv"), @params);
    }
    public void StartAnimeRecoveryIn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAnimeRecoveryIn"), @params);
    }
    public void FadeOutEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FadeOutEffect"), @params);
    }
    public void FadeInEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FadeInEffect"), @params);
    }
}

public unsafe class UIAssist : ObjectBase<UUIAssist>
{
    public UIAssist(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIBackLog : ObjectBase<AUIBackLog>
{
    public UIBackLog(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIBackLogDraw : ObjectBase<AUIBackLogDraw>
{
    public UIBackLogDraw(IntPtr pointer) : base(pointer) {}
    public void Update()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
}

public unsafe class UIBattlePartyPanel : ObjectBase<AUIBattlePartyPanel>
{
    public UIBattlePartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICalc : ObjectBase<UUICalc>
{
    public UICalc(IntPtr pointer) : base(pointer) {}}

public unsafe class UICampPartyPanel : ObjectBase<AUICampPartyPanel>
{
    public UICampPartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIClearSaveActor : ObjectBase<AUIClearSaveActor>
{
    public UIClearSaveActor(IntPtr pointer) : base(pointer) {}
    public void CallStatePatternEndDelicate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallStatePatternEndDelicate"), @params);
    }
}

public unsafe class UICloudCursorDraw : ObjectBase<AUICloudCursorDraw>
{
    public UICloudCursorDraw(IntPtr pointer) : base(pointer) {}}

public unsafe class UICmmRankUPAnimManager : ObjectBase<AUICmmRankUPAnimManager>
{
    public UICmmRankUPAnimManager(IntPtr pointer) : base(pointer) {}
    public void StartRipple3GameOverAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRipple3GameOverAnime"), @params);
    }
    public void StartRipple2GameOverAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRipple2GameOverAnime"), @params);
    }
    public void StartRipple1GameOverAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRipple1GameOverAnime"), @params);
    }
    public void StartReverseRankInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartReverseRankInAnime"), @params);
    }
    public void StartReverseOutAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartReverseOutAnime"), @params);
    }
    public void StartReverseInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartReverseInAnime"), @params);
    }
    public void StartRecoveryAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRecoveryAnime"), @params);
    }
    public void StartRankUpOutAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRankUpOutAnime"), @params);
    }
    public void StartRankUpInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRankUpInAnime"), @params);
    }
    public void StartKeyHelpWaitAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartKeyHelpWaitAnime"), @params);
    }
    public void StartKeyHelpOutAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartKeyHelpOutAnime"), @params);
    }
    public void StartKeyHelpInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartKeyHelpInAnime"), @params);
    }
    public void StartGameOverOneContentAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartGameOverOneContentAnime"), @params);
    }
    public void StartGameOverAllAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartGameOverAllAnime"), @params);
    }
    public void StartCardInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartCardInAnime"), @params);
    }
    public void StartCardEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartCardEffect"), @params);
    }
    public void SkipContentAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SkipContentAnime"), @params);
    }
    public void SetShowKeyHelp(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetShowKeyHelp"), @params);
    }
    public void SetPlayStarInAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetPlayStarInAnime"), @params);
    }
    public void SetPlayBGCardOutAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetPlayBGCardOutAnime"), @params);
    }
    public void SetEndUIOutAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndUIOutAnime"), @params);
    }
    public void SetEndUIInAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndUIInAnime"), @params);
    }
    public void SetEndReverseRankInAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndReverseRankInAnime"), @params);
    }
    public void SetEndReverseOutAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndReverseOutAnime"), @params);
    }
    public void SetEndReverseInAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndReverseInAnime"), @params);
    }
    public void SetEndRecoveryAnime(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndRecoveryAnime"), @params);
    }
    public void SetEndGameoverOneLine(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetEndGameoverOneLine"), @params);
    }
    public void RestartGameover()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestartGameover"), @params);
    }
    public void PlaySE(EUICmmRankUpSE SEType)
    {
        Span<(string name, object value)> @params = [
            ("SEType", SEType)
        ];
        ProcessEvent(GetFunction("PlaySE"), @params);
    }
    public void PauseGameover()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PauseGameover"), @params);
    }
    public void EndCardEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndCardEffect"), @params);
    }
}

public unsafe class UICmmRankUpBG : ObjectBase<AUICmmRankUpBG>
{
    public UICmmRankUpBG(IntPtr pointer) : base(pointer) {}
    public void Update(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void UICmmDrawBG_Red()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_Red"), @params);
    }
    public void UICmmDrawBG_5()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_5"), @params);
    }
    public void UICmmDrawBG_4(FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_4"), @params);
    }
    public void UICmmDrawBG_3(FColor Top, FColor Bottom)
    {
        Span<(string name, object value)> @params = [
            ("Top", Top), 
            ("Bottom", Bottom)
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_3"), @params);
    }
    public void UICmmDrawBG_2(FColor Top, FColor Bottom)
    {
        Span<(string name, object value)> @params = [
            ("Top", Top), 
            ("Bottom", Bottom)
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_2"), @params);
    }
    public void UICmmDrawBG_1(FColor Top, FColor Bottom)
    {
        Span<(string name, object value)> @params = [
            ("Top", Top), 
            ("Bottom", Bottom)
        ];
        ProcessEvent(GetFunction("UICmmDrawBG_1"), @params);
    }
    public bool UICmmBGCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("UICmmBGCapture"), @params);
    }
    public void StartAnimePoemBG1In()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartAnimePoemBG1In"), @params);
    }
    public void InitSettingMaterialBG(UMaterialInstance* Material)
    {
        Span<(string name, object value)> @params = [
            ("Material", (IntPtr)Material)
        ];
        ProcessEvent(GetFunction("InitSettingMaterialBG"), @params);
    }
}

public unsafe class UICmmRankUpDraw : ObjectBase<AUICmmRankUpDraw>
{
    public UICmmRankUpDraw(IntPtr pointer) : base(pointer) {}
    public void Update(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void UICmmReverseBG(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("UICmmReverseBG"), @params);
    }
    public void UICmmDrawRankStar(float BasePosX, float BasePosY)
    {
        Span<(string name, object value)> @params = [
            ("BasePosX", BasePosX), 
            ("BasePosY", BasePosY)
        ];
        ProcessEvent(GetFunction("UICmmDrawRankStar"), @params);
    }
    public void UICmmDrawOkKey(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("UICmmDrawOkKey"), @params);
    }
    public void UICmmDrawLetter(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("UICmmDrawLetter"), @params);
    }
    public void UICmmDrawGradationBG(FVector2D vLeftPos, FVector2D vRightPos, FVector2D hLeftPos, FVector2D hRightPos)
    {
        Span<(string name, object value)> @params = [
            ("vLeftPos", vLeftPos), 
            ("vRightPos", vRightPos), 
            ("hLeftPos", hLeftPos), 
            ("hRightPos", hRightPos)
        ];
        ProcessEvent(GetFunction("UICmmDrawGradationBG"), @params);
    }
    public void UICmmDrawEndDraw(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("UICmmDrawEndDraw"), @params);
    }
    public void UICmmDrawCard(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("UICmmDrawCard"), @params);
    }
    public void StartStarWaitAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartStarWaitAnime"), @params);
    }
    public void StartStarMainInAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartStarMainInAnime"), @params);
    }
    public void StartStarFrameAnime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartStarFrameAnime"), @params);
    }
    public void StartShowReverseStar()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartShowReverseStar"), @params);
    }
    public bool isEndAnimStart()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("isEndAnimStart"), @params);
    }
}

public unsafe class CmpCldCursor : ObjectBase<UCmpCldCursor>
{
    public CmpCldCursor(IntPtr pointer) : base(pointer) {}}

public unsafe class UICmpCalendar : ObjectBase<AUICmpCalendar>
{
    public UICmpCalendar(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICmpCalendarDraw : ObjectBase<UUICmpCalendarDraw>
{
    public UICmpCalendarDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICmpCommu : ObjectBase<AUICmpCommu>
{
    public UICmpCommu(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICmpPersona : ObjectBase<AUICmpPersona>
{
    public UICmpPersona(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICmpQuest : ObjectBase<AUICmpQuest>
{
    public UICmpQuest(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICmpStatus : ObjectBase<UUICmpStatus>
{
    public UICmpStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICombine : ObjectBase<UUICombine>
{
    public UICombine(IntPtr pointer) : base(pointer) {}
    public void StreamLevelCountDecrement()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StreamLevelCountDecrement"), @params);
    }
}

public unsafe class UICombineCalcFunction : ObjectBase<UUICombineCalcFunction>
{
    public UICombineCalcFunction(IntPtr pointer) : base(pointer) {}
    public int GetSuccessionIncense(int IncenseParam, int SuccessionParam, int Num)
    {
        Span<(string name, object value)> @params = [
            ("IncenseParam", IncenseParam), 
            ("SuccessionParam", SuccessionParam), 
            ("Num", Num)
        ];
        return ProcessEvent<int>(GetFunction("GetSuccessionIncense"), @params);
    }
    public int GetNormalSpreadLevel(int LevelA, int LevelB)
    {
        Span<(string name, object value)> @params = [
            ("LevelA", LevelA), 
            ("LevelB", LevelB)
        ];
        return ProcessEvent<int>(GetFunction("GetNormalSpreadLevel"), @params);
    }
    public int GetFoolAccidentLevel(int PlayerLevel)
    {
        Span<(string name, object value)> @params = [
            ("PlayerLevel", PlayerLevel)
        ];
        return ProcessEvent<int>(GetFunction("GetFoolAccidentLevel"), @params);
    }
    public int GetBookDrawOut(int power, int Magic, int Endurance, int Quick, int Luck, int CommuLevel, int MaxSkillLevel)
    {
        Span<(string name, object value)> @params = [
            ("power", power), 
            ("Magic", Magic), 
            ("Endurance", Endurance), 
            ("Quick", Quick), 
            ("Luck", Luck), 
            ("CommuLevel", CommuLevel), 
            ("MaxSkillLevel", MaxSkillLevel)
        ];
        return ProcessEvent<int>(GetFunction("GetBookDrawOut"), @params);
    }
}

public unsafe class UICombineCalc : ObjectBase<UUICombineCalc>
{
    public UICombineCalc(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICompleteBook : ObjectBase<UUICompleteBook>
{
    public UICompleteBook(IntPtr pointer) : base(pointer) {}
}

public unsafe class UICompleteBookRegist : ObjectBase<UUICompleteBookRegist>
{
    public UICompleteBookRegist(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIConfiguration : ObjectBase<AUIConfiguration>
{
    public UIConfiguration(IntPtr pointer) : base(pointer) {}
    public void OnDrawClosed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnDrawClosed"), @params);
    }
    public void OnDifficultCancel(bool inIsCancel)
    {
        Span<(string name, object value)> @params = [
            ("inIsCancel", inIsCancel)
        ];
        ProcessEvent(GetFunction("OnDifficultCancel"), @params);
    }
    public void OnConfigInAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnConfigInAnimFinished"), @params);
    }
    public void OnConfigCancel(bool inIsCancel)
    {
        Span<(string name, object value)> @params = [
            ("inIsCancel", inIsCancel)
        ];
        ProcessEvent(GetFunction("OnConfigCancel"), @params);
    }
    public void OnBgmSetAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBgmSetAnimFinished"), @params);
    }
    public void OnBGMInAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBGMInAnimFinished"), @params);
    }
    public bool IsWindowDraw()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsWindowDraw"), @params);
    }
}

public unsafe class ActivityDataAsset : ObjectBase<UActivityDataAsset>
{
    public ActivityDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppActor : ObjectBase<AAppActor>
{
    public AppActor(IntPtr pointer) : base(pointer) {}
    public EAppPauseObjectFlag GetAppPauseFlags()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAppPauseObjectFlag>(GetFunction("GetAppPauseFlags"), @params);
    }
    public void EndPlay(EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("EndPlay"), @params);
    }
    public void BeginPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginPlay"), @params);
    }
    public UObject* AsUObject()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("AsUObject"), @params);
    }
    public AActor* AsAActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("AsAActor"), @params);
    }
}

public unsafe class UIConfigurationDraw : ObjectBase<AUIConfigurationDraw>
{
    public UIConfigurationDraw(IntPtr pointer) : base(pointer) {}
    public void UpdateInWipe(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateInWipe"), @params);
    }
    public void UpdateCloseWipe(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateCloseWipe"), @params);
    }
    public void UpdateAnim(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateAnim"), @params);
    }
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDraw_UpdateOnlyCursor(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_UpdateOnlyCursor"), @params);
    }
    public bool StateDraw_Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Update"), @params);
    }
    public bool StateDraw_Main()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Main"), @params);
    }
    public bool StateDraw_ListItem(int inMenueID, int InListIndex)
    {
        Span<(string name, object value)> @params = [
            ("inMenueID", inMenueID), 
            ("InListIndex", InListIndex)
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_ListItem"), @params);
    }
    public bool StateDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_IN"), @params);
    }
    public bool StateDraw_Close()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Close"), @params);
    }
    public bool StateDraw_BGMSelect()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BGMSelect"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public bool StateBGMDraw_In()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateBGMDraw_In"), @params);
    }
    public void StartInWipe(bool IsTitle)
    {
        Span<(string name, object value)> @params = [
            ("IsTitle", IsTitle)
        ];
        ProcessEvent(GetFunction("StartInWipe"), @params);
    }
    public void StartCloseWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartCloseWipe"), @params);
    }
    public bool Start_ToConfAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Start_ToConfAnim"), @params);
    }
    public bool Start_ToBGMAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Start_ToBGMAnim"), @params);
    }
    public bool Start_MenuChangeAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Start_MenuChangeAnim"), @params);
    }
    public bool Start_InAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Start_InAnim"), @params);
    }
    public bool Start_CloseAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Start_CloseAnim"), @params);
    }
    public void SetValueGaugeTouchCollision(ref FDrawConfigParam drawParam, float GaugeX, float GaugeY, float GaugeWidth, float GaugeHeight, float SliderX, float SliderY)
    {
        Span<(string name, object value)> @params = [
            ("drawParam", drawParam), 
            ("GaugeX", GaugeX), 
            ("GaugeY", GaugeY), 
            ("GaugeWidth", GaugeWidth), 
            ("GaugeHeight", GaugeHeight), 
            ("SliderX", SliderX), 
            ("SliderY", SliderY)
        ];
        ProcessEvent(GetFunction("SetValueGaugeTouchCollision"), @params);
    }
    public void SetTouchCollision(int Index, float X, float Y, float Width, float Height, int addLayer, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("addLayer", addLayer), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetSliderPos(int InMenuID, FVector2D InSliderPos)
    {
        Span<(string name, object value)> @params = [
            ("InMenuID", InMenuID), 
            ("InSliderPos", InSliderPos)
        ];
        ProcessEvent(GetFunction("SetSliderPos"), @params);
    }
    public void SetScrollTouchCollision(float X, float Y, float Width, float Height, int addLayer, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("addLayer", addLayer), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollTouchCollision"), @params);
    }
    public void SetScrollSize(FVector2D InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        ProcessEvent(GetFunction("SetScrollSize"), @params);
    }
    public void SetScrollPos(FVector2D InPos, float Height, float ScrollRange, int DrawListNum, int MaxListNum, int ScrollPosY)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("ScrollPosY", ScrollPosY)
        ];
        ProcessEvent(GetFunction("SetScrollPos"), @params);
    }
    public void SetScrollBarTouchCollision(float X, float Y, float Width, float Height, float ScrollRange, int DrawListNum, int MaxListNum, int ScrollPosY, int addLayer, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("ScrollPosY", ScrollPosY), 
            ("addLayer", addLayer), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetScrollBarTouchCollision"), @params);
    }
    public void ProcessCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcessCompleted__DelegateSignature"), @params);
    }
    public bool On_ValueChanged(int inMenueID, bool inFlag, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("inMenueID", inMenueID), 
            ("inFlag", inFlag), 
            ("inValue", inValue)
        ];
        return ProcessEvent<bool>(GetFunction("On_ValueChanged"), @params);
    }
    public bool On_PlayingIndexChanged(int inPlayingIndex)
    {
        Span<(string name, object value)> @params = [
            ("inPlayingIndex", inPlayingIndex)
        ];
        return ProcessEvent<bool>(GetFunction("On_PlayingIndexChanged"), @params);
    }
    public bool On_CursorIndexChanged_BGM(int inCursorIndex, int inListTopIndex)
    {
        Span<(string name, object value)> @params = [
            ("inCursorIndex", inCursorIndex), 
            ("inListTopIndex", inListTopIndex)
        ];
        return ProcessEvent<bool>(GetFunction("On_CursorIndexChanged_BGM"), @params);
    }
    public bool On_CursorIndexChanged(int inCursorIndex, int inListTopIndex)
    {
        Span<(string name, object value)> @params = [
            ("inCursorIndex", inCursorIndex), 
            ("inListTopIndex", inListTopIndex)
        ];
        return ProcessEvent<bool>(GetFunction("On_CursorIndexChanged"), @params);
    }
    public bool On_BgmSetIndexChanged(int inSetIndex)
    {
        Span<(string name, object value)> @params = [
            ("inSetIndex", inSetIndex)
        ];
        return ProcessEvent<bool>(GetFunction("On_BgmSetIndexChanged"), @params);
    }
    public bool IsWindowShow()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsWindowShow"), @params);
    }
    public bool IsTitleOpend()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTitleOpend"), @params);
    }
    public bool IsScrollDrawBgmSelectText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsScrollDrawBgmSelectText"), @params);
    }
    public bool IsKeyConfig()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsKeyConfig"), @params);
    }
    public bool IsConfigTypeMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsConfigTypeMode"), @params);
    }
    public bool IsBGMMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBGMMode"), @params);
    }
    public bool IsBaseDiffLuna()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBaseDiffLuna"), @params);
    }
    public FString GetSoundOutputText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetSoundOutputText"), @params);
    }
    public FString GetSelLangText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetSelLangText"), @params);
    }
    public int GetPlayingIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPlayingIndex"), @params);
    }
    public FString GetOnText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetOnText"), @params);
    }
    public FString GetOffText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetOffText"), @params);
    }
    public int GetListTopIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetListTopIndex"), @params);
    }
    public int GetListNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetListNum"), @params);
    }
    public bool GetIsFisrt()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetIsFisrt"), @params);
    }
    public FDrawConfigParam GetIndexedDrawConfigParam(int InIndex)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex)
        ];
        return ProcessEvent<FDrawConfigParam>(GetFunction("GetIndexedDrawConfigParam"), @params);
    }
    public FColor GetGradation2TopColour()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetGradation2TopColour"), @params);
    }
    public FColor GetGradation2BottomColour()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetGradation2BottomColour"), @params);
    }
    public FColor GetGradation1TopColour()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetGradation1TopColour"), @params);
    }
    public FColor GetGradation1BottomColour()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetGradation1BottomColour"), @params);
    }
    public FDrawConfigParam GetDrawConfigParam(int InMenuID)
    {
        Span<(string name, object value)> @params = [
            ("InMenuID", InMenuID)
        ];
        return ProcessEvent<FDrawConfigParam>(GetFunction("GetDrawConfigParam"), @params);
    }
    public FString GetDifficultyText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetDifficultyText"), @params);
    }
    public int GetCursorIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCursorIndex"), @params);
    }
    public int GetCurrentIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCurrentIndex"), @params);
    }
    public FString GetConfigTypeText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetConfigTypeText"), @params);
    }
    public FString GetButtonLayoutText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetButtonLayoutText"), @params);
    }
    public FColor GetBlueBoardColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetBlueBoardColor"), @params);
    }
    public FString GetBGMText(int InSelect)
    {
        Span<(string name, object value)> @params = [
            ("InSelect", InSelect)
        ];
        return ProcessEvent<FString>(GetFunction("GetBGMText"), @params);
    }
    public int GetBgmSetID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetBgmSetID"), @params);
    }
    public int GetBgmListTopIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetBgmListTopIndex"), @params);
    }
    public int GetBgmCursorIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetBgmCursorIndex"), @params);
    }
    public bool GetAdjustedHelpRootPosition(bool InIsBGMMode, ref FVector2D OutPosition)
    {
        Span<(string name, object value)> @params = [
            ("InIsBGMMode", InIsBGMMode), 
            ("OutPosition", OutPosition)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedHelpRootPosition"), @params);
    }
    public bool GetAdjustedHelpBarOffset(bool InIsBGMMode, ref FVector2D OutPosition)
    {
        Span<(string name, object value)> @params = [
            ("InIsBGMMode", InIsBGMMode), 
            ("OutPosition", OutPosition)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedHelpBarOffset"), @params);
    }
    public void GetAdjustedConfigTextCol(ECmpLayoutConfigText InType, ref FVector2D OutSize)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("OutSize", OutSize)
        ];
        ProcessEvent(GetFunction("GetAdjustedConfigTextCol"), @params);
    }
    public void GetAdjustedConfigPos(ECmpLayoutConfig InType, FVector2D Default, ref FVector2D OutSize)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("Default", Default), 
            ("OutSize", OutSize)
        ];
        ProcessEvent(GetFunction("GetAdjustedConfigPos"), @params);
    }
    public UMaterialInterface* Get_BgMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInterface*)ProcessEvent<IntPtr>(GetFunction("Get_BgMaterial"), @params);
    }
    public void DrawUim(UObject* inUimAsset, float InFrame, ref bool bIsMaxFrame, UTexture* inTexture)
    {
        Span<(string name, object value)> @params = [
            ("inUimAsset", (IntPtr)inUimAsset), 
            ("InFrame", InFrame), 
            ("bIsMaxFrame", bIsMaxFrame), 
            ("inTexture", (IntPtr)inTexture)
        ];
        ProcessEvent(GetFunction("DrawUim"), @params);
    }
    public void DrawNami()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawNami"), @params);
    }
    public void DrawKeyConfigSwitcher(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawKeyConfigSwitcher"), @params);
    }
    public void DrawKeyConfigButtonSpr(float X, float Y, ref FDrawConfigParam DrawConfigParam, ref FColor RGBA, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("DrawConfigParam", DrawConfigParam), 
            ("RGBA", RGBA), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("DrawKeyConfigButtonSpr"), @params);
    }
    public void DrawInWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawInWipe"), @params);
    }
    public void DrawHeroTexture(UTexture* inTexture)
    {
        Span<(string name, object value)> @params = [
            ("inTexture", (IntPtr)inTexture)
        ];
        ProcessEvent(GetFunction("DrawHeroTexture"), @params);
    }
    public void DrawHeroSilhouette(FVector2D Offset)
    {
        Span<(string name, object value)> @params = [
            ("Offset", Offset)
        ];
        ProcessEvent(GetFunction("DrawHeroSilhouette"), @params);
    }
    public void DrawGlowCore(FVector2D Offset, FColor Color, float Scale, FVector2D PlusOffset, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("Offset", Offset), 
            ("Color", Color), 
            ("Scale", Scale), 
            ("PlusOffset", PlusOffset), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("DrawGlowCore"), @params);
    }
    public void DrawCommonBg2(bool IsTitle)
    {
        Span<(string name, object value)> @params = [
            ("IsTitle", IsTitle)
        ];
        ProcessEvent(GetFunction("DrawCommonBg2"), @params);
    }
    public void DrawCommonBg1()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawCommonBg1"), @params);
    }
    public void DrawCloseWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawCloseWipe"), @params);
    }
    public void DrawBgmSelectText(float baseX, float baseY, float textX, float textY, byte textColorR, byte textColorG, byte textColorB, byte textColorA, float SizeX, float SizeY, ref FDrawConfigParam DrawConfigParam, ref FDrawBGMParam DrawBGMParam, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("baseX", baseX), 
            ("baseY", baseY), 
            ("textX", textX), 
            ("textY", textY), 
            ("textColorR", textColorR), 
            ("textColorG", textColorG), 
            ("textColorB", textColorB), 
            ("textColorA", textColorA), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("DrawConfigParam", DrawConfigParam), 
            ("DrawBGMParam", DrawBGMParam), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("DrawBgmSelectText"), @params);
    }
    public void DrawAudioDeviceChange(float baseX, float baseY, float textX, float textY, byte textColorR, byte textColorG, byte textColorB, byte textColorA, float SizeX, float SizeY, ref FDrawConfigParam DrawConfigParam, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("baseX", baseX), 
            ("baseY", baseY), 
            ("textX", textX), 
            ("textY", textY), 
            ("textColorR", textColorR), 
            ("textColorG", textColorG), 
            ("textColorB", textColorB), 
            ("textColorA", textColorA), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("DrawConfigParam", DrawConfigParam), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("DrawAudioDeviceChange"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
    public void ConfigInAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ConfigInAnimFinished"), @params);
    }
    public void Closed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Closed"), @params);
    }
    public void BPUICommand_DrawSpr_Ex(float X, float Y, float Z, byte R, byte G, byte B, byte A, int SprNo, float ScaleX, float ScaleY, float PipodX, float PipodY, float Angle, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("SprNo", SprNo), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("PipodX", PipodX), 
            ("PipodY", PipodY), 
            ("Angle", Angle), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawSpr_Ex"), @params);
    }
    public void BgmSetAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BgmSetAnimFinished"), @params);
    }
    public float BGMScaleCalculation(float InTimer, float InSrcValue, float InDstValue, int InWaitFrame, int InMoveFrame, appCalculationType InAnimType)
    {
        Span<(string name, object value)> @params = [
            ("InTimer", InTimer), 
            ("InSrcValue", InSrcValue), 
            ("InDstValue", InDstValue), 
            ("InWaitFrame", InWaitFrame), 
            ("InMoveFrame", InMoveFrame), 
            ("InAnimType", InAnimType)
        ];
        return ProcessEvent<float>(GetFunction("BGMScaleCalculation"), @params);
    }
    public FVector2D BGMMoveCalculation(float InTimer, FVector2D InSrcValue, FVector2D InDstValue, int InWaitFrame, int InMoveFrame, appCalculationType InAnimType)
    {
        Span<(string name, object value)> @params = [
            ("InTimer", InTimer), 
            ("InSrcValue", InSrcValue), 
            ("InDstValue", InDstValue), 
            ("InWaitFrame", InWaitFrame), 
            ("InMoveFrame", InMoveFrame), 
            ("InAnimType", InAnimType)
        ];
        return ProcessEvent<FVector2D>(GetFunction("BGMMoveCalculation"), @params);
    }
    public void BGMInAnimFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BGMInAnimFinished"), @params);
    }
    public float BGMAlphaCalculation(float InTimer, float InSrcValue, float InDstValue, int InWaitFrame, int InNextWaitFrame, int InMoveFrame, int InNextMoveFrame, appCalculationType InAnimType)
    {
        Span<(string name, object value)> @params = [
            ("InTimer", InTimer), 
            ("InSrcValue", InSrcValue), 
            ("InDstValue", InDstValue), 
            ("InWaitFrame", InWaitFrame), 
            ("InNextWaitFrame", InNextWaitFrame), 
            ("InMoveFrame", InMoveFrame), 
            ("InNextMoveFrame", InNextMoveFrame), 
            ("InAnimType", InAnimType)
        ];
        return ProcessEvent<float>(GetFunction("BGMAlphaCalculation"), @params);
    }
}

public unsafe class UIContactManager : ObjectBase<UUIContactManager>
{
    public UIContactManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDataAssets : ObjectBase<UUIDataAssets>
{
    public UIDataAssets(IntPtr pointer) : base(pointer) {}}

public unsafe class WeaponItemListTable : ObjectBase<UWeaponItemListTable>
{
    public WeaponItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class ArmorItemListTable : ObjectBase<UArmorItemListTable>
{
    public ArmorItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class ShoesItemListTable : ObjectBase<UShoesItemListTable>
{
    public ShoesItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class AccsItemListTable : ObjectBase<UAccsItemListTable>
{
    public AccsItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillcardItemListTable : ObjectBase<USkillcardItemListTable>
{
    public SkillcardItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class EvitemItemListTable : ObjectBase<UEvitemItemListTable>
{
    public EvitemItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class MaterialItemListTable : ObjectBase<UMaterialItemListTable>
{
    public MaterialItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class CostumeItemListTable : ObjectBase<UCostumeItemListTable>
{
    public CostumeItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommonItemListTable : ObjectBase<UCommonItemListTable>
{
    public CommonItemListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class WeaponShopLineUpListTable : ObjectBase<UWeaponShopLineUpListTable>
{
    public WeaponShopLineUpListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class ItemShopLineUpListTable : ObjectBase<UItemShopLineUpListTable>
{
    public ItemShopLineUpListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class AntiqueShopLineUpListTable : ObjectBase<UAntiqueShopLineUpListTable>
{
    public AntiqueShopLineUpListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class SimpleShopDataAsset : ObjectBase<USimpleShopDataAsset>
{
    public SimpleShopDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class ItemNameListTable : ObjectBase<UItemNameListTable>
{
    public ItemNameListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class FontAdjustmentListTable : ObjectBase<UFontAdjustmentListTable>
{
    public FontAdjustmentListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class SuggestionListTable : ObjectBase<USuggestionListTable>
{
    public SuggestionListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class SuggestionTextListTable : ObjectBase<USuggestionTextListTable>
{
    public SuggestionTextListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class MiniMapIconListTable : ObjectBase<UMiniMapIconListTable>
{
    public MiniMapIconListTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class TownMapRestrictionsDataAsset : ObjectBase<UTownMapRestrictionsDataAsset>
{
    public TownMapRestrictionsDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class TownMapTimeDataAsset : ObjectBase<UTownMapTimeDataAsset>
{
    public TownMapTimeDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class TownMapInfoDataAsset : ObjectBase<UTownMapInfoDataAsset>
{
    public TownMapInfoDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class TownMapInfoNameDataAsset : ObjectBase<UTownMapInfoNameDataAsset>
{
    public TownMapInfoNameDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class TownMapDetailTextDataAsset : ObjectBase<UTownMapDetailTextDataAsset>
{
    public TownMapDetailTextDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MiniMapOffsetDataAsset : ObjectBase<UMiniMapOffsetDataAsset>
{
    public MiniMapOffsetDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MiniMapInfoDataAsset : ObjectBase<UMiniMapInfoDataAsset>
{
    public MiniMapInfoDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupExistDataAsset : ObjectBase<UBustupExistDataAsset>
{
    public BustupExistDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupAnimDataAsset : ObjectBase<UBustupAnimDataAsset>
{
    public BustupAnimDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupEnvironmentDataAsset : ObjectBase<UBustupEnvironmentDataAsset>
{
    public BustupEnvironmentDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupGradationDataAsset : ObjectBase<UBustupGradationDataAsset>
{
    public BustupGradationDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SupportBustupDataAsset : ObjectBase<USupportBustupDataAsset>
{
    public SupportBustupDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MailIncomingDataAsset : ObjectBase<UMailIncomingDataAsset>
{
    public MailIncomingDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class DisappearDataAsset : ObjectBase<UDisappearDataAsset>
{
    public DisappearDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class NormalSpreadDataAsset : ObjectBase<UNormalSpreadDataAsset>
{
    public NormalSpreadDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SpecialSpreadDataAsset : ObjectBase<USpecialSpreadDataAsset>
{
    public SpecialSpreadDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaLiftDataAsset : ObjectBase<UPersonaLiftDataAsset>
{
    public PersonaLiftDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillAffinityDataAsset : ObjectBase<USkillAffinityDataAsset>
{
    public SkillAffinityDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillLimitDataAsset : ObjectBase<USkillLimitDataAsset>
{
    public SkillLimitDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaConfigDataAsset : ObjectBase<UPersonaConfigDataAsset>
{
    public PersonaConfigDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityRankDataAsset : ObjectBase<UCommunityRankDataAsset>
{
    public CommunityRankDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MoonAgeProbabilityDataAsset : ObjectBase<UMoonAgeProbabilityDataAsset>
{
    public MoonAgeProbabilityDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CombineCounterDataAsset : ObjectBase<UCombineCounterDataAsset>
{
    public CombineCounterDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillChangeDataAsset : ObjectBase<USkillChangeDataAsset>
{
    public SkillChangeDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillPackDataAsset : ObjectBase<USkillPackDataAsset>
{
    public SkillPackDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SkillPowerUpDataAsset : ObjectBase<USkillPowerUpDataAsset>
{
    public SkillPowerUpDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CombineMiscDataAsset : ObjectBase<UCombineMiscDataAsset>
{
    public CombineMiscDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class VelvetRoomQuestDataAsset : ObjectBase<UVelvetRoomQuestDataAsset>
{
    public VelvetRoomQuestDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmmProfileDataAsset : ObjectBase<UCmmProfileDataAsset>
{
    public CmmProfileDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class ModelCaptureLayoutDataAsset : ObjectBase<UModelCaptureLayoutDataAsset>
{
    public ModelCaptureLayoutDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenSelItemDefineDataAsset : ObjectBase<UGenSelItemDefineDataAsset>
{
    public GenSelItemDefineDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenSelItemLineupDataAsset : ObjectBase<UGenSelItemLineupDataAsset>
{
    public GenSelItemLineupDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class ArbeitInfoDataAsset : ObjectBase<UArbeitInfoDataAsset>
{
    public ArbeitInfoDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class HiddenArbeitDataAsset : ObjectBase<UHiddenArbeitDataAsset>
{
    public HiddenArbeitDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class NameEntryCnvCharDataAsset : ObjectBase<UNameEntryCnvCharDataAsset>
{
    public NameEntryCnvCharDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class DLCPersonaCombineBirthDataAsset : ObjectBase<UDLCPersonaCombineBirthDataAsset>
{
    public DLCPersonaCombineBirthDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class WordSortDataAsset : ObjectBase<UWordSortDataAsset>
{
    public WordSortDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContentTableDataAsset : ObjectBase<UAddContentTableDataAsset>
{
    public AddContentTableDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContentBundleNameTableDataAsset : ObjectBase<UAddContentBundleNameTableDataAsset>
{
    public AddContentBundleNameTableDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContentNameDispTableDataAsset : ObjectBase<UAddContentNameDispTableDataAsset>
{
    public AddContentNameDispTableDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIPoetryDataAsset : ObjectBase<UUIPoetryDataAsset>
{
    public UIPoetryDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITextDataAsset : ObjectBase<UUITextDataAsset>
{
    public UITextDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIPoetryRippleDataAsset : ObjectBase<UUIPoetryRippleDataAsset>
{
    public UIPoetryRippleDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDataInheritanceActor : ObjectBase<AUIDataInheritanceActor>
{
    public UIDataInheritanceActor(IntPtr pointer) : base(pointer) {}
    public void OnSelectedChoise()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnSelectedChoise"), @params);
    }
    public void CallStatePatternEndDelicate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallStatePatternEndDelicate"), @params);
    }
}

public unsafe class UIDateDraw : ObjectBase<AUIDateDraw>
{
    public UIDateDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDayChange : ObjectBase<AUIDayChange>
{
    public UIDayChange(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDebugDraw : ObjectBase<AUIDebugDraw>
{
    public UIDebugDraw(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScrDebug(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScrDebug"), @params);
    }
}

public unsafe class UIDialogBase : ObjectBase<AUIDialogBase>
{
    public UIDialogBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDialogDouble : ObjectBase<AUIDialogDouble>
{
    public UIDialogDouble(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDialogSingle : ObjectBase<AUIDialogSingle>
{
    public UIDialogSingle(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDictionary : ObjectBase<AUIDictionary>
{
    public UIDictionary(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDataAsset : ObjectBase<UUIDataAsset>
{
    public UIDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDrawGamerTag : ObjectBase<UUIDrawGamerTag>
{
    public UIDrawGamerTag(IntPtr pointer) : base(pointer) {}
    public void SetScale(float Scale)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("SetScale"), @params);
    }
    public void SetNameText(FString nameText)
    {
        Span<(string name, object value)> @params = [
            ("nameText", nameText)
        ];
        ProcessEvent(GetFunction("SetNameText"), @params);
    }
    public void DebugOnDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugOnDestroy"), @params);
    }
}

public unsafe class UIDungeonTransfer : ObjectBase<AUIDungeonTransfer>
{
    public UIDungeonTransfer(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDungeonTransferData : ObjectBase<UUIDungeonTransferData>
{
    public UIDungeonTransferData(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIFieldPartyPanel : ObjectBase<AUIFieldPartyPanel>
{
    public UIFieldPartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIFieldType : ObjectBase<UUIFieldType>
{
    public UIFieldType(IntPtr pointer) : base(pointer) {}}

public unsafe class UIGameOverPoem : ObjectBase<AUIGameOverPoem>
{
    public UIGameOverPoem(IntPtr pointer) : base(pointer) {}
    public void StartRipple()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartRipple"), @params);
    }
}

public unsafe class UIGenericSelect : ObjectBase<AUIGenericSelect>
{
    public UIGenericSelect(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenericSelectCharacterDataAsset : ObjectBase<UGenericSelectCharacterDataAsset>
{
    public GenericSelectCharacterDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIGenericSelectCharacter : ObjectBase<UUIGenericSelectCharacter>
{
    public UIGenericSelectCharacter(IntPtr pointer) : base(pointer) {}}

public unsafe class UIGenericSelectDraw : ObjectBase<AUIGenericSelectDraw>
{
    public UIGenericSelectDraw(IntPtr pointer) : base(pointer) {}
    public void UpdateTimes(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateTimes"), @params);
    }
    public void DrawTitle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawTitle"), @params);
    }
    public void DrawMultiplyPlates()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawMultiplyPlates"), @params);
    }
    public void DrawList()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawList"), @params);
    }
    public void DrawItemInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawItemInfo"), @params);
    }
    public void DrawCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawCharacter"), @params);
    }
}

public unsafe class UIGetCommunityPointDraw : ObjectBase<AUIGetCommunityPointDraw>
{
    public UIGetCommunityPointDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIGetHeroParameterDraw : ObjectBase<AUIGetHeroParameterDraw>
{
    public UIGetHeroParameterDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIHeroParameterStatus : ObjectBase<AUIHeroParameterStatus>
{
    public UIHeroParameterStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIHeroParameterStatusDraw : ObjectBase<AUIHeroParameterStatusDraw>
{
    public UIHeroParameterStatusDraw(IntPtr pointer) : base(pointer) {}}

public unsafe class UIKeyHelpDraw : ObjectBase<AUIKeyHelpDraw>
{
    public UIKeyHelpDraw(IntPtr pointer) : base(pointer) {}}

public unsafe class UILayoutDataTable : ObjectBase<UUILayoutDataTable>
{
    public UILayoutDataTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class UISaveLoad : ObjectBase<AUISaveLoad>
{
    public UISaveLoad(IntPtr pointer) : base(pointer) {}
    public void OnFinishedInAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedInAnim"), @params);
    }
    public void OnFinishedCloseAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedCloseAnim"), @params);
    }
}

public unsafe class UILoadDialog : ObjectBase<AUILoadDialog>
{
    public UILoadDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class UILocationSelect : ObjectBase<UUILocationSelect>
{
    public UILocationSelect(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMailIconDraw : ObjectBase<AUIMailIconDraw>
{
    public UIMailIconDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class MiniMapAssetLoader : ObjectBase<UMiniMapAssetLoader>
{
    public MiniMapAssetLoader(IntPtr pointer) : base(pointer) {}
    public UTexture* GetWallTex()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetWallTex"), @params);
    }
    public TMap<int, int> GetTartarusMapPartIndexList(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<TMap<int, int>>(GetFunction("GetTartarusMapPartIndexList"), @params);
    }
    public USprAsset* GetPartMaskSpr()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetPartMaskSpr"), @params);
    }
    public TArray<byte> GetPartList(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<TArray<byte>>(GetFunction("GetPartList"), @params);
    }
    public UTexture* GetMapTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetMapTexture"), @params);
    }
    public UTexture* GetMapTex()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetMapTex"), @params);
    }
    public UTexture* GetMapParts(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetMapParts"), @params);
    }
    public EFldType GetFldType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EFldType>(GetFunction("GetFldType"), @params);
    }
    public UMiniMapIconListTable* GetFldMiniMapIconTable()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMiniMapIconListTable*)ProcessEvent<IntPtr>(GetFunction("GetFldMiniMapIconTable"), @params);
    }
    public UAssetLoader* GetAssetLoader()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAssetLoader*)ProcessEvent<IntPtr>(GetFunction("GetAssetLoader"), @params);
    }
}

public unsafe class UIMiniMapDraw : ObjectBase<UUIMiniMapDraw>
{
    public UIMiniMapDraw(IntPtr pointer) : base(pointer) {}
    public void Completed()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Completed"), @params);
    }
}

public unsafe class UIMiscCheckDraw : ObjectBase<AUIMiscCheckDraw>
{
    public UIMiscCheckDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscCinemaScopeDraw : ObjectBase<AUIMiscCinemaScopeDraw>
{
    public UIMiscCinemaScopeDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscEnemySymbolDraw : ObjectBase<AUIMiscEnemySymbolDraw>
{
    public UIMiscEnemySymbolDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscGetItemDraw : ObjectBase<AUIMiscGetItemDraw>
{
    public UIMiscGetItemDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscMoneyDraw : ObjectBase<AUIMiscMoneyDraw>
{
    public UIMiscMoneyDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscPictureDraw : ObjectBase<AUIMiscPictureDraw>
{
    public UIMiscPictureDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscSpecialKeyhelp : ObjectBase<UUIMiscSpecialKeyhelp>
{
    public UIMiscSpecialKeyhelp(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMiscSupportPartyPanel : ObjectBase<AUIMiscSupportPartyPanel>
{
    public UIMiscSupportPartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMissingPerson : ObjectBase<UUIMissingPerson>
{
    public UIMissingPerson(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIMissingPersonActor : ObjectBase<AUIMissingPersonActor>
{
    public UIMissingPersonActor(IntPtr pointer) : base(pointer) {}}

public unsafe class ModelCaptureUpdater : ObjectBase<AModelCaptureUpdater>
{
    public ModelCaptureUpdater(IntPtr pointer) : base(pointer) {}
    public void OnSetTargetActor(AActor* AActor)
    {
        Span<(string name, object value)> @params = [
            ("AActor", (IntPtr)AActor)
        ];
        ProcessEvent(GetFunction("OnSetTargetActor"), @params);
    }
}

public unsafe class UIMorphTestActor : ObjectBase<AUIMorphTestActor>
{
    public UIMorphTestActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class NameEntry : ObjectBase<ANameEntry>
{
    public NameEntry(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class UINameEntryDraw : ObjectBase<AUINameEntryDraw>
{
    public UINameEntryDraw(IntPtr pointer) : base(pointer) {}
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Out"), @params);
    }
    public bool StateDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_IN"), @params);
    }
    public bool StateDraw_Frame()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Frame"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public void SetNameTouchCollision(FVector2D InName1Pos, FVector2D InName2Pos)
    {
        Span<(string name, object value)> @params = [
            ("InName1Pos", InName1Pos), 
            ("InName2Pos", InName2Pos)
        ];
        ProcessEvent(GetFunction("SetNameTouchCollision"), @params);
    }
    public void SetDicitionTouchCollision(FVector2D InDicitionPos, FVector2D OptionScale, FVector2D DicitionScale, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("InDicitionPos", InDicitionPos), 
            ("OptionScale", OptionScale), 
            ("DicitionScale", DicitionScale), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetDicitionTouchCollision"), @params);
    }
    public bool ResetDraw()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ResetDraw"), @params);
    }
    public void PlaySENameEntry()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlaySENameEntry"), @params);
    }
    public void OneTimeLockInput()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OneTimeLockInput"), @params);
    }
    public bool KeyHelpOut()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpOut"), @params);
    }
    public bool KeyHelpIn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpIn"), @params);
    }
    public bool IsName2TypingOnKeyboard()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsName2TypingOnKeyboard"), @params);
    }
    public bool IsName2Entered()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsName2Entered"), @params);
    }
    public bool IsName1TypingOnKeyboard()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsName1TypingOnKeyboard"), @params);
    }
    public bool IsName1Entered()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsName1Entered"), @params);
    }
    public bool IsKeyHelpGray()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsKeyHelpGray"), @params);
    }
    public bool IsIsDeterminedByCross()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsIsDeterminedByCross"), @params);
    }
    public bool IsEnableOption()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnableOption"), @params);
    }
    public bool IsCursorPreName2Use()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCursorPreName2Use"), @params);
    }
    public bool IsCursorPreName1Use()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCursorPreName1Use"), @params);
    }
    public bool IsCursorName2Use()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCursorName2Use"), @params);
    }
    public bool IsCursorName1Use()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCursorName1Use"), @params);
    }
    public bool IsAllNameEntered()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAllNameEntered"), @params);
    }
    public bool InitDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_Out"), @params);
    }
    public bool InitDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_IN"), @params);
    }
    public FVector2D GetAdjustedLayoutScale(EUINameEntryLayout InLayoutId, FVector2D InDefaultScale)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultScale", InDefaultScale)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAdjustedLayoutScale"), @params);
    }
    public FVector2D GetAdjustedLayoutPosition(EUINameEntryLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAdjustedLayoutPosition"), @params);
    }
    public void DrawTranslation(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawTranslation"), @params);
    }
    public void DrawOptionsBase(FVector2D InPos, FColor InColor, FVector2D Scale, float Angle, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("DrawOptionsBase"), @params);
    }
    public void DrawOptions(FVector2D InPos, FColor InColor, FVector2D Scale, float Angle, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("DrawOptions"), @params);
    }
    public void DrawName2Text(FVector2D InPos, FColor InColor, FColor InColorDown, FColor InColorUp)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InColorDown", InColorDown), 
            ("InColorUp", InColorUp)
        ];
        ProcessEvent(GetFunction("DrawName2Text"), @params);
    }
    public void DrawName1Text(FVector2D InPos, FColor InColor, FColor InColorDown, FColor InColorUp)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("InColorDown", InColorDown), 
            ("InColorUp", InColorUp)
        ];
        ProcessEvent(GetFunction("DrawName1Text"), @params);
    }
    public void DrawGradationScreen(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawGradationScreen"), @params);
    }
    public void DrawCursor1(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawCursor1"), @params);
    }
    public void DrawBlueLight(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawBlueLight"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
}

public unsafe class UIParameterAsset : ObjectBase<UUIParameterAsset>
{
    public UIParameterAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIPartyPanel : ObjectBase<AUIPartyPanel>
{
    public UIPartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIPersonaModelActor : ObjectBase<AUIPersonaModelActor>
{
    public UIPersonaModelActor(IntPtr pointer) : base(pointer) {}
    public USkeletalMeshComponent* GetSkeletalMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetSkeletalMesh"), @params);
    }
}

public unsafe class PersonaPreviewWorldUpdater : ObjectBase<APersonaPreviewWorldUpdater>
{
    public PersonaPreviewWorldUpdater(IntPtr pointer) : base(pointer) {}
    public void RequestAnimation(AActor* Actor, EPersonaStatusModelAnim Anim)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Anim", Anim)
        ];
        ProcessEvent(GetFunction("RequestAnimation"), @params);
    }
    public void CheckPlayAnimation(AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("CheckPlayAnimation"), @params);
    }
}

public unsafe class PersonaModelCaptureUpdater : ObjectBase<APersonaModelCaptureUpdater>
{
    public PersonaModelCaptureUpdater(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatus : ObjectBase<APersonaStatus>
{
    public PersonaStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusDraw : ObjectBase<APersonaStatusDraw>
{
    public PersonaStatusDraw(IntPtr pointer) : base(pointer) {}
    public void Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void SetupOutAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupOutAnimation"), @params);
    }
    public UTexture* GetCaptureRenderTarget()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetCaptureRenderTarget"), @params);
    }
    public void DrawSkillSelectList(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawSkillSelectList"), @params);
    }
    public void DrawSkillInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawSkillInfo"), @params);
    }
    public void DrawSkillCard(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawSkillCard"), @params);
    }
    public void DrawRegistrySkillList(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRegistrySkillList"), @params);
    }
    public void DrawRegistryPersonaInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRegistryPersonaInfo"), @params);
    }
    public void DrawRegistryPersona(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRegistryPersona"), @params);
    }
    public void DrawRegistryCommentary(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRegistryCommentary"), @params);
    }
    public void DrawOutAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawOutAnimation"), @params);
    }
    public void DrawLevelUpConception(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLevelUpConception"), @params);
    }
    public void DrawLevelUp(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLevelUp"), @params);
    }
    public void DrawExpBonus(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawExpBonus"), @params);
    }
    public void DrawDrawerPersona(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDrawerPersona"), @params);
    }
    public void DrawDrawerConceptionInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDrawerConceptionInfo"), @params);
    }
    public void DrawDrawerConception(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDrawerConception"), @params);
    }
    public void DrawDefaultStatusParameter(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefaultStatusParameter"), @params);
    }
    public void DrawDefaultPersonaInfoBackground(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefaultPersonaInfoBackground"), @params);
    }
    public void DrawDefaultPersonaInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefaultPersonaInfo"), @params);
    }
    public void DrawDefaultPersona(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefaultPersona"), @params);
    }
    public void DrawDefaultCommentary(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefaultCommentary"), @params);
    }
    public void DrawDefalutSkillList(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefalutSkillList"), @params);
    }
    public void DrawDefalutConception(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDefalutConception"), @params);
    }
    public void DrawConceptionInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawConceptionInfo"), @params);
    }
    public void DrawCommuBonus(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCommuBonus"), @params);
    }
    public void DrawCombinePersonaInfo(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCombinePersonaInfo"), @params);
    }
    public void DrawCombinePersona(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCombinePersona"), @params);
    }
    public void DrawBackground()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBackground"), @params);
    }
    public void DrawAttribute(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAttribute"), @params);
    }
}

public unsafe class PersonaStatusSeq : ObjectBase<UPersonaStatusSeq>
{
    public PersonaStatusSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusSkillHelpSeq : ObjectBase<UPersonaStatusSkillHelpSeq>
{
    public PersonaStatusSkillHelpSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusSelectSkillSeq : ObjectBase<UPersonaStatusSelectSkillSeq>
{
    public PersonaStatusSelectSkillSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusChangeSkillSeq : ObjectBase<UPersonaStatusChangeSkillSeq>
{
    public PersonaStatusChangeSkillSeq(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusLvUpSeq : ObjectBase<UPersonaStatusLvUpSeq>
{
    public PersonaStatusLvUpSeq(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusSkillCardSeq : ObjectBase<UPersonaStatusSkillCardSeq>
{
    public PersonaStatusSkillCardSeq(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusSkillListSeq : ObjectBase<UPersonaStatusSkillListSeq>
{
    public PersonaStatusSkillListSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusRememberSkillSeq : ObjectBase<UPersonaStatusRememberSkillSeq>
{
    public PersonaStatusRememberSkillSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusSkillInfoSeq : ObjectBase<UPersonaStatusSkillInfoSeq>
{
    public PersonaStatusSkillInfoSeq(IntPtr pointer) : base(pointer) {}}

public unsafe class PersonaStatusParamUpSeq : ObjectBase<UPersonaStatusParamUpSeq>
{
    public PersonaStatusParamUpSeq(IntPtr pointer) : base(pointer) {}
}

public unsafe class PersonaStatusCommentarySeq : ObjectBase<UPersonaStatusCommentarySeq>
{
    public PersonaStatusCommentarySeq(IntPtr pointer) : base(pointer) {}}

public unsafe class UIPoetryActor : ObjectBase<AUIPoetryActor>
{
    public UIPoetryActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIPoetryDraw : ObjectBase<AUIPoetryDraw>
{
    public UIPoetryDraw(IntPtr pointer) : base(pointer) {}
    public void Update(float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public bool UIPoetryIsRankMaxPoetry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("UIPoetryIsRankMaxPoetry"), @params);
    }
    public void UIPoetryGetParam(float EfBaseAlpha_)
    {
        Span<(string name, object value)> @params = [
            ("EfBaseAlpha_", EfBaseAlpha_)
        ];
        ProcessEvent(GetFunction("UIPoetryGetParam"), @params);
    }
    public void UIPoetryDrawRippleOpen(float DeltaTime, float Ripple1, float Ripple2, float Ripple3, float Ripple4, float Ripple5)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("Ripple1", Ripple1), 
            ("Ripple2", Ripple2), 
            ("Ripple3", Ripple3), 
            ("Ripple4", Ripple4), 
            ("Ripple5", Ripple5)
        ];
        ProcessEvent(GetFunction("UIPoetryDrawRippleOpen"), @params);
    }
    public void UIPoetryDrawRippleMax(float DeltaTime, float Ripple1, float Ripple2, float Ripple3, float Ripple4, float Ripple5, float Ripple6, float Ripple7, float Ripple8)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("Ripple1", Ripple1), 
            ("Ripple2", Ripple2), 
            ("Ripple3", Ripple3), 
            ("Ripple4", Ripple4), 
            ("Ripple5", Ripple5), 
            ("Ripple6", Ripple6), 
            ("Ripple7", Ripple7), 
            ("Ripple8", Ripple8)
        ];
        ProcessEvent(GetFunction("UIPoetryDrawRippleMax"), @params);
    }
    public void UIPoetryDrawOkKey()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawOkKey"), @params);
    }
    public void UIPoetryDrawMaxLine3()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawMaxLine3"), @params);
    }
    public void UIPoetryDrawMaxLine2()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawMaxLine2"), @params);
    }
    public void UIPoetryDrawMaxLine1()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawMaxLine1"), @params);
    }
    public void UIPoetryDrawLine2()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawLine2"), @params);
    }
    public void UIPoetryDrawLine1()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawLine1"), @params);
    }
    public void UIPoetryDrawAllPoetry()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryDrawAllPoetry"), @params);
    }
    public void UIPoetryCreateMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UIPoetryCreateMaterial"), @params);
    }
    public float GetAdjustedLayoutRippleTiming(EUIRippleTimeLayout InLayoutId, float InDefaultTiming)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultTiming", InDefaultTiming)
        ];
        return ProcessEvent<float>(GetFunction("GetAdjustedLayoutRippleTiming"), @params);
    }
}

public unsafe class UIPreviewWorldUpdater : ObjectBase<AUIPreviewWorldUpdater>
{
    public UIPreviewWorldUpdater(IntPtr pointer) : base(pointer) {}
    public void GetAllActorsOfClass(UObject* WorldContextObject, TSubclassOf<AActor> ActorClass, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ActorClass", ActorClass), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetAllActorsOfClass"), @params);
    }
}

public unsafe class UIProgressBarDraw : ObjectBase<AUIProgressBarDraw>
{
    public UIProgressBarDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIRankUpDraw : ObjectBase<AUIRankUpDraw>
{
    public UIRankUpDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIRenderWidget : ObjectBase<UUIRenderWidget>
{
    public UIRenderWidget(IntPtr pointer) : base(pointer) {}
    public void SetPause(bool inPause)
    {
        Span<(string name, object value)> @params = [
            ("inPause", inPause)
        ];
        ProcessEvent(GetFunction("SetPause"), @params);
    }
    public bool IsPause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPause"), @params);
    }
    public bool Initialize(UTextureRenderTarget2D* inRenderTarget, UUserWidget* inRenderWidget, FVector2D DrawSize, bool inUseGamma, bool inClearTarget, TextureFilter inFilter)
    {
        Span<(string name, object value)> @params = [
            ("inRenderTarget", (IntPtr)inRenderTarget), 
            ("inRenderWidget", (IntPtr)inRenderWidget), 
            ("DrawSize", DrawSize), 
            ("inUseGamma", inUseGamma), 
            ("inClearTarget", inClearTarget), 
            ("inFilter", inFilter)
        ];
        return ProcessEvent<bool>(GetFunction("Initialize"), @params);
    }
    public void DrawToRenderTarget()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawToRenderTarget"), @params);
    }
}

public unsafe class UIRequest : ObjectBase<UUIRequest>
{
    public UIRequest(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class UIResources : ObjectBase<UUIResources>
{
    public UIResources(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIRestore : ObjectBase<AUIRestore>
{
    public UIRestore(IntPtr pointer) : base(pointer) {}
    public void OnFinishedInAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedInAnim"), @params);
    }
    public void OnFinishedCloseAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedCloseAnim"), @params);
    }
}

public unsafe class UISaveDialog : ObjectBase<AUISaveDialog>
{
    public UISaveDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class UISceneCapture : ObjectBase<AUISceneCapture>
{
    public UISceneCapture(IntPtr pointer) : base(pointer) {}
    public void LoopAnimationStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoopAnimationStart"), @params);
    }
    public void InAnimationStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InAnimationStart"), @params);
    }
}

public unsafe class UISceneFSM : ObjectBase<UUISceneFSM>
{
    public UISceneFSM(IntPtr pointer) : base(pointer) {}
}

public unsafe class UISoundManager : ObjectBase<UUISoundManager>
{
    public UISoundManager(IntPtr pointer) : base(pointer) {}}

public unsafe class UISubsystem : ObjectBase<UUISubsystem>
{
    public UISubsystem(IntPtr pointer) : base(pointer) {}
    public void NotifyLevelLoadedShop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedShop"), @params);
    }
}

public unsafe class UISystemMsgActor : ObjectBase<AUISystemMsgActor>
{
    public UISystemMsgActor(IntPtr pointer) : base(pointer) {}}

public unsafe class UITableTypes : ObjectBase<UUITableTypes>
{
    public UITableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class TestNishidaDataAsset : ObjectBase<UTestNishidaDataAsset>
{
    public TestNishidaDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITest1Actor : ObjectBase<AUITest1Actor>
{
    public UITest1Actor(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITestSpawnActor : ObjectBase<AUITestSpawnActor>
{
    public UITestSpawnActor(IntPtr pointer) : base(pointer) {}
    public void VelvetRoomUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("VelvetRoomUpdate"), @params);
    }
    public void Update(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void SpawnVelvetRoom()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnVelvetRoom"), @params);
    }
    public void SpawnTownMap()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnTownMap"), @params);
    }
    public void SpawnMoney()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnMoney"), @params);
    }
    public void SpawnDungeon()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnDungeon"), @params);
    }
    public void SpawnCommunity()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnCommunity"), @params);
    }
    public void SpawnBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnBattle"), @params);
    }
    public void SpawnAlwayField()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SpawnAlwayField"), @params);
    }
    public void MoneyUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MoneyUpdate"), @params);
    }
    public void DungeonUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DungeonUpdate"), @params);
    }
    public void CommunityUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CommunityUpdate"), @params);
    }
    public void AlwayFieldUpdate(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("AlwayFieldUpdate"), @params);
    }
}

public unsafe class UITheurgia : ObjectBase<UUITheurgia>
{
    public UITheurgia(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITimeChange : ObjectBase<AUITimeChange>
{
    public UITimeChange(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITownMapActor : ObjectBase<AUITownMapActor>
{
    public UITownMapActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITownMapCameraActor : ObjectBase<AUITownMapCameraActor>
{
    public UITownMapCameraActor(IntPtr pointer) : base(pointer) {}
    public void Initialize(AActor* MainCamera, AActor* SchoolCamera, AActor* DormitoryCamera, AActor* PortislandCamera, AActor* PolonianmallCamera, AActor* IwatodayCamera, AActor* NaganakiCamera, AActor* SchoolActor, AActor* DormitoryActor, AActor* PortislandActor, AActor* PolonianmallActor, AActor* IwatodayActor, AActor* NaganakiActor, AActor* StartCamera)
    {
        Span<(string name, object value)> @params = [
            ("MainCamera", (IntPtr)MainCamera), 
            ("SchoolCamera", (IntPtr)SchoolCamera), 
            ("DormitoryCamera", (IntPtr)DormitoryCamera), 
            ("PortislandCamera", (IntPtr)PortislandCamera), 
            ("PolonianmallCamera", (IntPtr)PolonianmallCamera), 
            ("IwatodayCamera", (IntPtr)IwatodayCamera), 
            ("NaganakiCamera", (IntPtr)NaganakiCamera), 
            ("SchoolActor", (IntPtr)SchoolActor), 
            ("DormitoryActor", (IntPtr)DormitoryActor), 
            ("PortislandActor", (IntPtr)PortislandActor), 
            ("PolonianmallActor", (IntPtr)PolonianmallActor), 
            ("IwatodayActor", (IntPtr)IwatodayActor), 
            ("NaganakiActor", (IntPtr)NaganakiActor), 
            ("StartCamera", (IntPtr)StartCamera)
        ];
        ProcessEvent(GetFunction("Initialize"), @params);
    }
}

public unsafe class UITownMapSymbolComponent : ObjectBase<UUITownMapSymbolComponent>
{
    public UITownMapSymbolComponent(IntPtr pointer) : base(pointer) {}
    public void Initialize(AFldAnimObj* FldAnimObj, USkinnedMeshComponent* SkinnedComponent, ETownType TownType)
    {
        Span<(string name, object value)> @params = [
            ("FldAnimObj", (IntPtr)FldAnimObj), 
            ("SkinnedComponent", (IntPtr)SkinnedComponent), 
            ("TownType", TownType)
        ];
        ProcessEvent(GetFunction("Initialize"), @params);
    }
}

public unsafe class UITutorial : ObjectBase<AUITutorial>
{
    public UITutorial(IntPtr pointer) : base(pointer) {}
}

public unsafe class UITutorialDraw : ObjectBase<AUITutorialDraw>
{
    public UITutorialDraw(IntPtr pointer) : base(pointer) {}
    public void DrawList(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawList"), @params);
    }
    public void DrawHelp(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawHelp"), @params);
    }
    public void DrawCloseWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawCloseWipe"), @params);
    }
    public void DrawCategorys(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCategorys"), @params);
    }
    public void DrawBackground(float X, float Y, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBackground"), @params);
    }
}

public unsafe class UIVelvetRoom : ObjectBase<AUIVelvetRoom>
{
    public UIVelvetRoom(IntPtr pointer) : base(pointer) {}
    public void StreamLevelCountDecrement()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StreamLevelCountDecrement"), @params);
    }
}

public unsafe class UIVelvetRoomDraw : ObjectBase<AUIVelvetRoomDraw>
{
    public UIVelvetRoomDraw(IntPtr pointer) : base(pointer) {}
    public void UpdateTimes(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateTimes"), @params);
    }
    public void UpdateMcaTimes(float DeltaTime, UObject* ResourceData)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("ResourceData", (IntPtr)ResourceData)
        ];
        ProcessEvent(GetFunction("UpdateMcaTimes"), @params);
    }
    public void UpdateCardTimes(float DeltaTime, UObject* ResourceData)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("ResourceData", (IntPtr)ResourceData)
        ];
        ProcessEvent(GetFunction("UpdateCardTimes"), @params);
    }
    public int GetHeroCostumeID(int ForceID)
    {
        Span<(string name, object value)> @params = [
            ("ForceID", ForceID)
        ];
        return ProcessEvent<int>(GetFunction("GetHeroCostumeID"), @params);
    }
    public void DrawTopHero(float X, float Y, float Width, float Height, USceneCaptureComponent2D* pSceneCapture)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("pSceneCapture", (IntPtr)pSceneCapture)
        ];
        ProcessEvent(GetFunction("DrawTopHero"), @params);
    }
    public void DrawTopHelpMessage(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawTopHelpMessage"), @params);
    }
    public void DrawTopCard(FTransform Transform, UObject* CardDataAsset)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform), 
            ("CardDataAsset", (IntPtr)CardDataAsset)
        ];
        ProcessEvent(GetFunction("DrawTopCard"), @params);
    }
    public void DrawTopBlackDesign(UObject* UniqueResource)
    {
        Span<(string name, object value)> @params = [
            ("UniqueResource", (IntPtr)UniqueResource)
        ];
        ProcessEvent(GetFunction("DrawTopBlackDesign"), @params);
    }
    public void DrawSpecialCombinePlayerNameBoard(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSpecialCombinePlayerNameBoard"), @params);
    }
    public void DrawSpecialCombineList(UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSpecialCombineList"), @params);
    }
    public void DrawSpecialCombineIgor(float X, float Y, float Angle, USceneCaptureComponent2D* pSceneCapture)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("pSceneCapture", (IntPtr)pSceneCapture)
        ];
        ProcessEvent(GetFunction("DrawSpecialCombineIgor"), @params);
    }
    public void DrawSpecialCombineHeading(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSpecialCombineHeading"), @params);
    }
    public void DrawSearchCombineSortPanel(float X, float Y, float Angle, UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSearchCombineSortPanel"), @params);
    }
    public void DrawSearchCombinePlayerNameBoard(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSearchCombinePlayerNameBoard"), @params);
    }
    public void DrawSearchCombineList(UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSearchCombineList"), @params);
    }
    public void DrawSearchCombineIgor(float X, float Y, float Angle, USceneCaptureComponent2D* pSceneCapture)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("pSceneCapture", (IntPtr)pSceneCapture)
        ];
        ProcessEvent(GetFunction("DrawSearchCombineIgor"), @params);
    }
    public void DrawSearchCombineHeading(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawSearchCombineHeading"), @params);
    }
    public void DrawRegistryPlayerNameBoard(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawRegistryPlayerNameBoard"), @params);
    }
    public void DrawRegistryList(float X, float Y, float Angle, UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawRegistryList"), @params);
    }
    public void DrawRegistryHelpMessage(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawRegistryHelpMessage"), @params);
    }
    public void DrawRegistryHeading(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawRegistryHeading"), @params);
    }
    public void DrawRegistryElizabeth(float X, float Y, float Angle, USceneCaptureComponent2D* pSceneCapture, UObject* Elizabeth)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("pSceneCapture", (IntPtr)pSceneCapture), 
            ("Elizabeth", (IntPtr)Elizabeth)
        ];
        ProcessEvent(GetFunction("DrawRegistryElizabeth"), @params);
    }
    public void DrawMessageWaitScene()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawMessageWaitScene"), @params);
    }
    public void DrawHelpMessageSpecialCombine(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawHelpMessageSpecialCombine"), @params);
    }
    public void DrawHelpMessageSearchCombine(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawHelpMessageSearchCombine"), @params);
    }
    public void DrawHelpMessage2Combine(UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawHelpMessage2Combine"), @params);
    }
    public void DrawDrawerRegistryRate(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerRegistryRate"), @params);
    }
    public void DrawDrawerPlayerNameBoard(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerPlayerNameBoard"), @params);
    }
    public void DrawDrawerListSortPanel(float X, float Y, float Angle, UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerListSortPanel"), @params);
    }
    public void DrawDrawerList(float X, float Y, float Angle, UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerList"), @params);
    }
    public void DrawDrawerHelpMessage(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerHelpMessage"), @params);
    }
    public void DrawDrawerHeading(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("DrawDrawerHeading"), @params);
    }
    public void DrawDrawerElizabeth(float X, float Y, float Angle, USceneCaptureComponent2D* pSceneCapture, UObject* Elizabeth)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("pSceneCapture", (IntPtr)pSceneCapture), 
            ("Elizabeth", (IntPtr)Elizabeth)
        ];
        ProcessEvent(GetFunction("DrawDrawerElizabeth"), @params);
    }
    public void DrawBlackScreenMiddle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBlackScreenMiddle"), @params);
    }
    public void DrawBlackScreenLow()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBlackScreenLow"), @params);
    }
    public void DrawBlackScreenHigh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBlackScreenHigh"), @params);
    }
    public void DrawBlackScreenFadeOut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBlackScreenFadeOut"), @params);
    }
    public void DrawBackgroundPanels(ref TArray<FColor> Colors, ref TArray<int> BlackPanelIndex)
    {
        Span<(string name, object value)> @params = [
            ("Colors", Colors), 
            ("BlackPanelIndex", BlackPanelIndex)
        ];
        ProcessEvent(GetFunction("DrawBackgroundPanels"), @params);
    }
    public void DrawBackgroundPanelLattices(UObject* Resource)
    {
        Span<(string name, object value)> @params = [
            ("Resource", (IntPtr)Resource)
        ];
        ProcessEvent(GetFunction("DrawBackgroundPanelLattices"), @params);
    }
    public void Draw2CombinePlayerNameBoard(float X, float Y, float Angle, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Angle", Angle), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("Draw2CombinePlayerNameBoard"), @params);
    }
    public void Draw2CombineList(UObject* UniqueResource, UObject* CommonResource)
    {
        Span<(string name, object value)> @params = [
            ("UniqueResource", (IntPtr)UniqueResource), 
            ("CommonResource", (IntPtr)CommonResource)
        ];
        ProcessEvent(GetFunction("Draw2CombineList"), @params);
    }
    public void Draw2CombineIgor(USceneCaptureComponent2D* pSceneCapture)
    {
        Span<(string name, object value)> @params = [
            ("pSceneCapture", (IntPtr)pSceneCapture)
        ];
        ProcessEvent(GetFunction("Draw2CombineIgor"), @params);
    }
    public void Draw2CombineHeading(float X, float Y, UObject* UniqueResource)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("UniqueResource", (IntPtr)UniqueResource)
        ];
        ProcessEvent(GetFunction("Draw2CombineHeading"), @params);
    }
    public void ApplyMcaToSceneCaptureComponent(USceneCaptureComponent2D* pCaptureComponent, UObject* pResource, EUIVELVET_ROOM_MCA_CAPTURE Type, FVector OffsetPoint, FRotator OffsetRotation, float OffsetFov)
    {
        Span<(string name, object value)> @params = [
            ("pCaptureComponent", (IntPtr)pCaptureComponent), 
            ("pResource", (IntPtr)pResource), 
            ("Type", Type), 
            ("OffsetPoint", OffsetPoint), 
            ("OffsetRotation", OffsetRotation), 
            ("OffsetFov", OffsetFov)
        ];
        ProcessEvent(GetFunction("ApplyMcaToSceneCaptureComponent"), @params);
    }
    public void ApplyMcaForSceneCaptureComponent2D(USceneCaptureComponent2D* SceneCaptureComponent2D, UObject* McaResourceData)
    {
        Span<(string name, object value)> @params = [
            ("SceneCaptureComponent2D", (IntPtr)SceneCaptureComponent2D), 
            ("McaResourceData", (IntPtr)McaResourceData)
        ];
        ProcessEvent(GetFunction("ApplyMcaForSceneCaptureComponent2D"), @params);
    }
}

public unsafe class VelvetRoomMcaDataAsset : ObjectBase<UVelvetRoomMcaDataAsset>
{
    public VelvetRoomMcaDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVelvetRoomMca : ObjectBase<UUIVelvetRoomMca>
{
    public UIVelvetRoomMca(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVelvetRoomOwner : ObjectBase<UUIVelvetRoomOwner>
{
    public UIVelvetRoomOwner(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class UIVelvetRoomPanel : ObjectBase<AUIVelvetRoomPanel>
{
    public UIVelvetRoomPanel(IntPtr pointer) : base(pointer) {}}

public unsafe class UIVelvetRoomRequest : ObjectBase<AUIVelvetRoomRequest>
{
    public UIVelvetRoomRequest(IntPtr pointer) : base(pointer) {}}

public unsafe class UIVelvetRoomRequestDraw : ObjectBase<AUIVelvetRoomRequestDraw>
{
    public UIVelvetRoomRequestDraw(IntPtr pointer) : base(pointer) {}
    public void OpenQuestMenu()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OpenQuestMenu"), @params);
    }
    public void OpenQuestDetails()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OpenQuestDetails"), @params);
    }
    public int GetSortType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSortType"), @params);
    }
    public EQuestListItemState GetQuestState(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<EQuestListItemState>(GetFunction("GetQuestState"), @params);
    }
    public int GetQuestRank()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetQuestRank"), @params);
    }
    public bool GetQuestNewFlag(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("GetQuestNewFlag"), @params);
    }
    public int GetQuestListMax()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetQuestListMax"), @params);
    }
    public int GetQuestID(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetQuestID"), @params);
    }
    public int GetCursorListTopIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCursorListTopIndex"), @params);
    }
    public int GetCursorCurrentIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCursorCurrentIndex"), @params);
    }
    public void DrawQuestReward(float X, float Y, int Index)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("DrawQuestReward"), @params);
    }
    public void DrawQuestItem(float X, float Y, int Index)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("DrawQuestItem"), @params);
    }
    public void DrawQuestHelp(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawQuestHelp"), @params);
    }
    public void DrawQuestDetails(float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("DrawQuestDetails"), @params);
    }
    public void CloseQuestMenu()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseQuestMenu"), @params);
    }
    public void CloseQuestDetails()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseQuestDetails"), @params);
    }
}

public unsafe class VelvetRoomCardTextureDataAsset : ObjectBase<UVelvetRoomCardTextureDataAsset>
{
    public VelvetRoomCardTextureDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class VelvetRoomUnimDataAsset : ObjectBase<UVelvetRoomUnimDataAsset>
{
    public VelvetRoomUnimDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class VelvetRoomCardDataAsset : ObjectBase<UVelvetRoomCardDataAsset>
{
    public VelvetRoomCardDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVelvetRoomUimCard : ObjectBase<UUIVelvetRoomUimCard>
{
    public UIVelvetRoomUimCard(IntPtr pointer) : base(pointer) {}
}

public unsafe class TextInputWidget : ObjectBase<UTextInputWidget>
{
    public TextInputWidget(IntPtr pointer) : base(pointer) {}
    public void SetText(ref FText Text)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetBaseText(ref FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetBaseText"), @params);
    }
    public bool IsDrawLetterBoxDirHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDrawLetterBoxDirHeight"), @params);
    }
    public bool IsChangeScreenSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsChangeScreenSize"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public void Decide()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Decide"), @params);
    }
    public void ChangeInputTextPositionRight()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeInputTextPositionRight"), @params);
    }
    public void ChangeInputTextPositionLeft()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeInputTextPositionLeft"), @params);
    }
    public float CalcScreenScale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcScreenScale"), @params);
    }
    public float CalcLetterBoxSize(float InTmpScreenSize)
    {
        Span<(string name, object value)> @params = [
            ("InTmpScreenSize", InTmpScreenSize)
        ];
        return ProcessEvent<float>(GetFunction("CalcLetterBoxSize"), @params);
    }
}

public unsafe class UIVoiceAction : ObjectBase<AUIVoiceAction>
{
    public UIVoiceAction(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVoiceActionDraw : ObjectBase<AUIVoiceActionDraw>
{
    public UIVoiceActionDraw(IntPtr pointer) : base(pointer) {}
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDrawNetworkIcon_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawNetworkIcon_Out"), @params);
    }
    public bool StateDrawNetworkIcon_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawNetworkIcon_IN"), @params);
    }
    public bool StateDrawBlackBoard_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawBlackBoard_Out"), @params);
    }
    public bool StateDrawBlackBoard_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawBlackBoard_IN"), @params);
    }
    public bool StateDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Out"), @params);
    }
    public bool StateDraw_Network()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Network"), @params);
    }
    public bool StateDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_IN"), @params);
    }
    public bool StateDraw_Frame()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Frame"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public void OneTimeLockInput()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OneTimeLockInput"), @params);
    }
    public bool KeyHelpOut()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpOut"), @params);
    }
    public bool KeyHelpIn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpIn"), @params);
    }
    public void InitSetDayTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitSetDayTime"), @params);
    }
    public bool InitDrawNetworkIcon_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawNetworkIcon_Out"), @params);
    }
    public bool InitDrawNetworkIcon_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawNetworkIcon_IN"), @params);
    }
    public bool InitDrawBlackBoard_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawBlackBoard_Out"), @params);
    }
    public bool InitDrawBlackBoard_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawBlackBoard_IN"), @params);
    }
    public bool InitDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_Out"), @params);
    }
    public bool InitDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_IN"), @params);
    }
    public void DrawStickyNoteAverage(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawStickyNoteAverage"), @params);
    }
    public void DrawNetworkIconSecond(FVector2D InPos, FColor InColor, float Angle, float Scale)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle), 
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("DrawNetworkIconSecond"), @params);
    }
    public void DrawNetworkIcon(FVector2D InPos, FColor InColor, float Angle, float IconAngle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle), 
            ("IconAngle", IconAngle)
        ];
        ProcessEvent(GetFunction("DrawNetworkIcon"), @params);
    }
    public void DrawMonth(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawMonth"), @params);
    }
    public void DrawDungeonActionStickyNote(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDungeonActionStickyNote"), @params);
    }
    public void DrawDungeonActionPercent(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDungeonActionPercent"), @params);
    }
    public void DrawDayOfWeek(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDayOfWeek"), @params);
    }
    public void DrawDay(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDay"), @params);
    }
    public void DrawDailyActionStickyNote(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDailyActionStickyNote"), @params);
    }
    public void DrawDailyActionPercent(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDailyActionPercent"), @params);
    }
    public void DrawCommunityActionStickyNote(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCommunityActionStickyNote"), @params);
    }
    public void DrawCommunityActionPercent(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawCommunityActionPercent"), @params);
    }
    public void DrawBlueBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBlueBoard"), @params);
    }
    public void DrawBlackBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBlackBoard"), @params);
    }
    public void DrawBackBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBackBoard"), @params);
    }
    public void DrawActionBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawActionBoard"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
}

public unsafe class UIVoiceAnswer : ObjectBase<AUIVoiceAnswer>
{
    public UIVoiceAnswer(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVoiceAnswerDraw : ObjectBase<AUIVoiceAnswerDraw>
{
    public UIVoiceAnswerDraw(IntPtr pointer) : base(pointer) {}
    public bool TimeWithinRangeFrame(float NowTime, int StartFrame, int EndFrame)
    {
        Span<(string name, object value)> @params = [
            ("NowTime", NowTime), 
            ("StartFrame", StartFrame), 
            ("EndFrame", EndFrame)
        ];
        return ProcessEvent<bool>(GetFunction("TimeWithinRangeFrame"), @params);
    }
    public bool StateDrawNetworkIcon_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawNetworkIcon_Out"), @params);
    }
    public bool StateDrawNetworkIcon_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawNetworkIcon_IN"), @params);
    }
    public bool StateDrawBlackBoard_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawBlackBoard_Out"), @params);
    }
    public bool StateDrawBlackBoard_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDrawBlackBoard_IN"), @params);
    }
    public bool StateDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Out"), @params);
    }
    public bool StateDraw_Network()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Network"), @params);
    }
    public bool StateDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_IN"), @params);
    }
    public bool StateDraw_Frame()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_Frame"), @params);
    }
    public bool StateDraw_BG()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("StateDraw_BG"), @params);
    }
    public void OneTimeLockInput()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OneTimeLockInput"), @params);
    }
    public bool KeyHelpOut()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpOut"), @params);
    }
    public bool KeyHelpIn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("KeyHelpIn"), @params);
    }
    public bool IsMaxAnswer()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsMaxAnswer"), @params);
    }
    public void InitSetDayTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitSetDayTime"), @params);
    }
    public bool InitDrawNetworkIcon_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawNetworkIcon_Out"), @params);
    }
    public bool InitDrawNetworkIcon_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawNetworkIcon_IN"), @params);
    }
    public bool InitDrawBlackBoard_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawBlackBoard_Out"), @params);
    }
    public bool InitDrawBlackBoard_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDrawBlackBoard_IN"), @params);
    }
    public bool InitDraw_Out()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_Out"), @params);
    }
    public bool InitDraw_IN()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InitDraw_IN"), @params);
    }
    public void DrawTextureD(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawTextureD"), @params);
    }
    public void DrawTextureC(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawTextureC"), @params);
    }
    public void DrawTextureB(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawTextureB"), @params);
    }
    public void DrawTextureA(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawTextureA"), @params);
    }
    public void DrawStickerD(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawStickerD"), @params);
    }
    public void DrawStickerC(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawStickerC"), @params);
    }
    public void DrawStickerB(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawStickerB"), @params);
    }
    public void DrawStickerA(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawStickerA"), @params);
    }
    public void DrawRightBracketsD(FVector2D InPos, FColor InColor, float Width, float Height, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRightBracketsD"), @params);
    }
    public void DrawRightBracketsC(FVector2D InPos, FColor InColor, float Width, float Height, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRightBracketsC"), @params);
    }
    public void DrawRightBracketsB(FVector2D InPos, FColor InColor, float Width, float Height, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRightBracketsB"), @params);
    }
    public void DrawRightBracketsA(FVector2D InPos, FColor InColor, float Width, float Height, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawRightBracketsA"), @params);
    }
    public void DrawNetworkIconSecond(FVector2D InPos, FColor InColor, float Angle, float Scale)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle), 
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("DrawNetworkIconSecond"), @params);
    }
    public void DrawNetworkIcon(FVector2D InPos, FColor InColor, float Angle, float IconAngle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle), 
            ("IconAngle", IconAngle)
        ];
        ProcessEvent(GetFunction("DrawNetworkIcon"), @params);
    }
    public void DrawMonth(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawMonth"), @params);
    }
    public void DrawLeftBracketsD(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLeftBracketsD"), @params);
    }
    public void DrawLeftBracketsC(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLeftBracketsC"), @params);
    }
    public void DrawLeftBracketsB(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLeftBracketsB"), @params);
    }
    public void DrawLeftBracketsA(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawLeftBracketsA"), @params);
    }
    public void DrawDayOfWeek(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDayOfWeek"), @params);
    }
    public void DrawDay(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawDay"), @params);
    }
    public void DrawBlueBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBlueBoard"), @params);
    }
    public void DrawBlackBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBlackBoard"), @params);
    }
    public void DrawBackBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawBackBoard"), @params);
    }
    public void DrawAnswerTextD(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAnswerTextD"), @params);
    }
    public void DrawAnswerTextC(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAnswerTextC"), @params);
    }
    public void DrawAnswerTextB(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAnswerTextB"), @params);
    }
    public void DrawAnswerTextA(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAnswerTextA"), @params);
    }
    public void DrawAnswerBoard(FVector2D InPos, FColor InColor, float Angle)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor), 
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("DrawAnswerBoard"), @params);
    }
    public float ConvFrameToTime(int InFrame)
    {
        Span<(string name, object value)> @params = [
            ("InFrame", InFrame)
        ];
        return ProcessEvent<float>(GetFunction("ConvFrameToTime"), @params);
    }
}

public unsafe class UIVoiceConnect : ObjectBase<AUIVoiceConnect>
{
    public UIVoiceConnect(IntPtr pointer) : base(pointer) {}}

public unsafe class UIVoiceConnectWatching : ObjectBase<AUIVoiceConnectWatching>
{
    public UIVoiceConnectWatching(IntPtr pointer) : base(pointer) {}}

public unsafe class UmgDebugLogActor : ObjectBase<AUmgDebugLogActor>
{
    public UmgDebugLogActor(IntPtr pointer) : base(pointer) {}}

public unsafe class UmgDebugLogWidget : ObjectBase<UUmgDebugLogWidget>
{
    public UmgDebugLogWidget(IntPtr pointer) : base(pointer) {}
    public void SetText(ref FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
}

public unsafe class UmgDialog : ObjectBase<UUmgDialog>
{
    public UmgDialog(IntPtr pointer) : base(pointer) {}
    public void SetText(ref FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetEndFlag()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetEndFlag"), @params);
    }
    public bool IsStreamingTouch()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsStreamingTouch"), @params);
    }
    public bool IsInputBlocked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInputBlocked"), @params);
    }
    public bool IsChangeScreenSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsChangeScreenSize"), @params);
    }
    public float CalcScreenScale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcScreenScale"), @params);
    }
}

public unsafe class UmgDialogActor : ObjectBase<AUmgDialogActor>
{
    public UmgDialogActor(IntPtr pointer) : base(pointer) {}}

public unsafe class UtlBpObjManager : ObjectBase<UUtlBpObjManager>
{
    public UtlBpObjManager(IntPtr pointer) : base(pointer) {}
    public void SetEventEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetEventEnd"), @params);
    }
    public void SetBluePrint(UUtlBpObjCore* BpObjCore)
    {
        Span<(string name, object value)> @params = [
            ("BpObjCore", (IntPtr)BpObjCore)
        ];
        ProcessEvent(GetFunction("SetBluePrint"), @params);
    }
    public UUtlBpObjCore* CreateBluePrint(UClass* ObjectClass)
    {
        Span<(string name, object value)> @params = [
            ("ObjectClass", (IntPtr)ObjectClass)
        ];
        return (UUtlBpObjCore*)ProcessEvent<IntPtr>(GetFunction("CreateBluePrint"), @params);
    }
}

public unsafe class UtlProcManager : ObjectBase<UUtlProcManager>
{
    public UtlProcManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class VeveWork : ObjectBase<UVeveWork>
{
    public VeveWork(IntPtr pointer) : base(pointer) {}
}

public unsafe class VoiceActionViewer : ObjectBase<AVoiceActionViewer>
{
    public VoiceActionViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class Xrd777AssetManager : ObjectBase<UXrd777AssetManager>
{
    public Xrd777AssetManager(IntPtr pointer) : base(pointer) {}}

public unsafe class APPGameModeBase : ObjectBase<AAPPGameModeBase>
{
    public APPGameModeBase(IntPtr pointer) : base(pointer) {}}

public unsafe class Xrd777PrimaryAssetLabel : ObjectBase<UXrd777PrimaryAssetLabel>
{
    public Xrd777PrimaryAssetLabel(IntPtr pointer) : base(pointer) {}
}

public unsafe class XRD777SaveGame : ObjectBase<UXRD777SaveGame>
{
    public XRD777SaveGame(IntPtr pointer) : base(pointer) {}
}

public unsafe class Xrd777SaveManager : ObjectBase<UXrd777SaveManager>
{
    public Xrd777SaveManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class ActivityTest : ObjectBase<AActivityTest>
{
    public ActivityTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContent : ObjectBase<UAddContent>
{
    public AddContent(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContentDialog : ObjectBase<AAddContentDialog>
{
    public AddContentDialog(IntPtr pointer) : base(pointer) {}
}

public unsafe class AddContentEntitlementDataAsset : ObjectBase<UAddContentEntitlementDataAsset>
{
    public AddContentEntitlementDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AgePanel : ObjectBase<UAgePanel>
{
    public AgePanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimController : ObjectBase<UAnimController>
{
    public AnimController(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimNotify_BtlPlayMontageNotify : ObjectBase<UAnimNotify_BtlPlayMontageNotify>
{
    public AnimNotify_BtlPlayMontageNotify(IntPtr pointer) : base(pointer) {}
    public void ReplaceNotifyName(FName NewName)
    {
        Span<(string name, object value)> @params = [
            ("NewName", NewName)
        ];
        ProcessEvent(GetFunction("ReplaceNotifyName"), @params);
    }
    public FName GetBattleNotifyName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetBattleNotifyName"), @params);
    }
}

public unsafe class AnimNotify_PlayEvtMultiMontage : ObjectBase<UAnimNotify_PlayEvtMultiMontage>
{
    public AnimNotify_PlayEvtMultiMontage(IntPtr pointer) : base(pointer) {}
    public void OnFinished(UAnimMontage* Montage, bool bInterapt)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterapt", bInterapt)
        ];
        ProcessEvent(GetFunction("OnFinished"), @params);
    }
}

public unsafe class AppActivity : ObjectBase<UAppActivity>
{
    public AppActivity(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppActorComponent : ObjectBase<UAppActorComponent>
{
    public AppActorComponent(IntPtr pointer) : base(pointer) {}
    public EAppPauseObjectFlag GetAppPauseFlags()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAppPauseObjectFlag>(GetFunction("GetAppPauseFlags"), @params);
    }
    public void EndPlay(EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("EndPlay"), @params);
    }
    public void BeginPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginPlay"), @params);
    }
    public UObject* AsUObject()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("AsUObject"), @params);
    }
    public AActor* AsAActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("AsAActor"), @params);
    }
}

public unsafe class AppAnimCtrl : ObjectBase<UAppAnimCtrl>
{
    public AppAnimCtrl(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharBaseComp : ObjectBase<UAppCharBaseComp>
{
    public AppCharBaseComp(IntPtr pointer) : base(pointer) {}
    public void StopTurnAnimation(float InBlendOutTime)
    {
        Span<(string name, object value)> @params = [
            ("InBlendOutTime", InBlendOutTime)
        ];
        ProcessEvent(GetFunction("StopTurnAnimation"), @params);
    }
    public void StopNeckAnimation(float InBlendOutTime)
    {
        Span<(string name, object value)> @params = [
            ("InBlendOutTime", InBlendOutTime)
        ];
        ProcessEvent(GetFunction("StopNeckAnimation"), @params);
    }
    public void StopHaveBagAnimation(float InBlendOutTime)
    {
        Span<(string name, object value)> @params = [
            ("InBlendOutTime", InBlendOutTime)
        ];
        ProcessEvent(GetFunction("StopHaveBagAnimation"), @params);
    }
    public void StopFaceAnimation(float InBlendOutTime)
    {
        Span<(string name, object value)> @params = [
            ("InBlendOutTime", InBlendOutTime)
        ];
        ProcessEvent(GetFunction("StopFaceAnimation"), @params);
    }
    public void StopAnim_DefaultSlot(float InBlendOutTime)
    {
        Span<(string name, object value)> @params = [
            ("InBlendOutTime", InBlendOutTime)
        ];
        ProcessEvent(GetFunction("StopAnim_DefaultSlot"), @params);
    }
    public void SetWeaponType(ref EAppCharWeaponType Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetWeaponType"), @params);
    }
    public void SetWeaponId(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetWeaponId"), @params);
    }
    public void SetupHaveBag_AfterSetCostume()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupHaveBag_AfterSetCostume"), @params);
    }
    public void SetShoesId(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SetShoesId"), @params);
    }
    public void SetShoes(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetShoes"), @params);
    }
    public void SetMotionAttachedActorCore(AActor* AttachedActor, FName AttachedSocketName)
    {
        Span<(string name, object value)> @params = [
            ("AttachedActor", (IntPtr)AttachedActor), 
            ("AttachedSocketName", AttachedSocketName)
        ];
        ProcessEvent(GetFunction("SetMotionAttachedActorCore"), @params);
    }
    public void SetMotionAttachedActor(AActor* AttachedActor)
    {
        Span<(string name, object value)> @params = [
            ("AttachedActor", (IntPtr)AttachedActor)
        ];
        ProcessEvent(GetFunction("SetMotionAttachedActor"), @params);
    }
    public void SetIndexID(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetIndexID"), @params);
    }
    public void SetFadeSettingFromMotion(int FadeType, int FadeFrame, int FadePattern)
    {
        Span<(string name, object value)> @params = [
            ("FadeType", FadeType), 
            ("FadeFrame", FadeFrame), 
            ("FadePattern", FadePattern)
        ];
        ProcessEvent(GetFunction("SetFadeSettingFromMotion"), @params);
    }
    public void SetCostumeID(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetCostumeID"), @params);
    }
    public void SetCostume()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetCostume"), @params);
    }
    public void SetCategoryID(EAppCharCategoryType Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetCategoryID"), @params);
    }
    public void SetBag(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetBag"), @params);
    }
    public void SetAnimPackID(EAnimPackID Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetAnimPackID"), @params);
    }
    public void SetAnimMontageDefaultSlot(UAnimMontage* AnimMontage)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage)
        ];
        ProcessEvent(GetFunction("SetAnimMontageDefaultSlot"), @params);
    }
    public void ResetIK()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetIK"), @params);
    }
    public void RequestPauseAnimFromMotionIMD(bool IsLookAt)
    {
        Span<(string name, object value)> @params = [
            ("IsLookAt", IsLookAt)
        ];
        ProcessEvent(GetFunction("RequestPauseAnimFromMotionIMD"), @params);
    }
    public void RequestLoadWeapons()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestLoadWeapons"), @params);
    }
    public void RequestDelayPauseAnimFromMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestDelayPauseAnimFromMotion"), @params);
    }
    public UAnimMontage* PlayTurnAnimation(int AnimIndex, bool IsLoop, float InBlendInTime, float InBlendOutTime, float InPlayRate, float InBlendWeight)
    {
        Span<(string name, object value)> @params = [
            ("AnimIndex", AnimIndex), 
            ("IsLoop", IsLoop), 
            ("InBlendInTime", InBlendInTime), 
            ("InBlendOutTime", InBlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("InBlendWeight", InBlendWeight)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayTurnAnimation"), @params);
    }
    public UAnimMontage* PlayNeckAnimation(int AnimIndex, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("AnimIndex", AnimIndex), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayNeckAnimation"), @params);
    }
    public UAnimMontage* PlayHaveBagAnimation(EAppCharBagAnimType AnimType, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("AnimType", AnimType), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayHaveBagAnimation"), @params);
    }
    public UAnimMontage* PlayFaceAnimIndex(int AnimIndex, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("AnimIndex", AnimIndex), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayFaceAnimIndex"), @params);
    }
    public UAnimMontage* PlayFaceAnimation(EAppCharFaceAnimID FaceAnimID, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("FaceAnimID", FaceAnimID), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayFaceAnimation"), @params);
    }
    public UAnimMontage* PlayAnimBagSlot_Pack(int AnimId, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("AnimId", AnimId), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnimBagSlot_Pack"), @params);
    }
    public void PlayAnimationPackMotionAttachedProps(int InAnimePackIndex, int InPlayType, float InBlendInTime, float InBlendOutTime, float InPlayRate, FName InAnimSlotName)
    {
        Span<(string name, object value)> @params = [
            ("InAnimePackIndex", InAnimePackIndex), 
            ("InPlayType", InPlayType), 
            ("InBlendInTime", InBlendInTime), 
            ("InBlendOutTime", InBlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("InAnimSlotName", InAnimSlotName)
        ];
        ProcessEvent(GetFunction("PlayAnimationPackMotionAttachedProps"), @params);
    }
    public UAnimMontage* PlayAnim_TurnSlot(UAnimSequenceBase* Anim, bool IsLoop, float InBlendInTime, float InBlendOutTime, float InPlayRate, float InBlendWeight)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("IsLoop", IsLoop), 
            ("InBlendInTime", InBlendInTime), 
            ("InBlendOutTime", InBlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("InBlendWeight", InBlendWeight)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_TurnSlot"), @params);
    }
    public UAnimMontage* PlayAnim_Pack(int ID, bool Loop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID), 
            ("Loop", Loop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_Pack"), @params);
    }
    public UAnimMontage* PlayAnim_NeckSlot(UAnimSequenceBase* Anim, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_NeckSlot"), @params);
    }
    public UAnimMontage* PlayAnim_HaveBagSlot(UAnimSequenceBase* Anim, ref FName SetSlotName, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("SetSlotName", SetSlotName), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_HaveBagSlot"), @params);
    }
    public UAnimMontage* PlayAnim_FacialSlot(UAnimSequenceBase* Anim, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_FacialSlot"), @params);
    }
    public UAnimMontage* PlayAnim_DefaultSlot(UAnimSequenceBase* Anim, bool Loop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("Loop", Loop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim_DefaultSlot"), @params);
    }
    public UAnimMontage* PlayAnim(UAnimSequenceBase* Anim, EAppCharAnimSlot Slot, bool Loop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("Anim", (IntPtr)Anim), 
            ("Slot", Slot), 
            ("Loop", Loop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnim"), @params);
    }
    public void PauseAnim(bool bPause, UAnimMontage* InMontage)
    {
        Span<(string name, object value)> @params = [
            ("bPause", bPause), 
            ("InMontage", (IntPtr)InMontage)
        ];
        ProcessEvent(GetFunction("PauseAnim"), @params);
    }
    public void OverwriteTransformMotionAttachedActor(FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform)
        ];
        ProcessEvent(GetFunction("OverwriteTransformMotionAttachedActor"), @params);
    }
    public void Movement(FVector Location, float Speed)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location), 
            ("Speed", Speed)
        ];
        ProcessEvent(GetFunction("Movement"), @params);
    }
    public bool IsTurnAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsTurnAnimation"), @params);
    }
    public bool IsPlayAnim_DefaultSlot()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayAnim_DefaultSlot"), @params);
    }
    public bool IsNeckAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsNeckAnimation"), @params);
    }
    public bool IsLoadWeapons()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoadWeapons"), @params);
    }
    public bool IsDelayPauseAnimFromMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDelayPauseAnimFromMotion"), @params);
    }
    public bool IsCostumeChenged()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCostumeChenged"), @params);
    }
    public bool IsBag()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBag"), @params);
    }
    public TArray<IntPtr> GetWeapons()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetWeapons"), @params);
    }
    public bool GetWeaponEnable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetWeaponEnable"), @params);
    }
    public AAppCharWeaponBase* GetWeapon()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AAppCharWeaponBase*)ProcessEvent<IntPtr>(GetFunction("GetWeapon"), @params);
    }
    public USkeletalMeshComponent* GetMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetMesh"), @params);
    }
    public int GetIndexID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetIndexID"), @params);
    }
    public USkeletalMeshComponent* GetHairMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetHairMesh"), @params);
    }
    public UAppCharFootstepsAtom* GetFootstepsAtom()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAppCharFootstepsAtom*)ProcessEvent<IntPtr>(GetFunction("GetFootstepsAtom"), @params);
    }
    public USkeletalMeshComponent* GetFaceMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetFaceMesh"), @params);
    }
    public TArray<IntPtr> GetEffectWeapons()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetEffectWeapons"), @params);
    }
    public USkeletalMeshComponent* GetCostumeMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("GetCostumeMesh"), @params);
    }
    public int GetCostumeID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCostumeID"), @params);
    }
    public EAppCharCategoryType GetCategoryID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAppCharCategoryType>(GetFunction("GetCategoryID"), @params);
    }
    public TSoftClassPtr<AAppPropsCore> GetBagClassPtr()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TSoftClassPtr<AAppPropsCore>>(GetFunction("GetBagClassPtr"), @params);
    }
    public FName GetBagAttachSocketName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetBagAttachSocketName"), @params);
    }
    public EAnimPackID GetAnimPackID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAnimPackID>(GetFunction("GetAnimPackID"), @params);
    }
    public UAnimMontage* GetAnimMontageDefaultSlot()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("GetAnimMontageDefaultSlot"), @params);
    }
    public TArray<IntPtr> GetAllMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllMaterial"), @params);
    }
    public void ClearDelayPauseAnimFromMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearDelayPauseAnimFromMotion"), @params);
    }
}

public unsafe class AppCharacterComp : ObjectBase<UAppCharacterComp>
{
    public AppCharacterComp(IntPtr pointer) : base(pointer) {}
    public void UnlinkPhysics()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UnlinkPhysics"), @params);
    }
    public void SetVisibleAttachComponent(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetVisibleAttachComponent"), @params);
    }
    public UCharacterMovementComponent* GetMovement()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCharacterMovementComponent*)ProcessEvent<IntPtr>(GetFunction("GetMovement"), @params);
    }
    public ACharacterBaseCore* GetCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ACharacterBaseCore*)ProcessEvent<IntPtr>(GetFunction("GetCharacter"), @params);
    }
    public UCapsuleComponent* GetCapsule()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCapsuleComponent*)ProcessEvent<IntPtr>(GetFunction("GetCapsule"), @params);
    }
}

public unsafe class AppCharacterPoolManager : ObjectBase<UAppCharacterPoolManager>
{
    public AppCharacterPoolManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAnimAttachNotify : ObjectBase<UAppCharAnimAttachNotify>
{
    public AppCharAnimAttachNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAnimDetachNotify : ObjectBase<UAppCharAnimDetachNotify>
{
    public AppCharAnimDetachNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAnimDetachPrepareNotify : ObjectBase<UAppCharAnimDetachPrepareNotify>
{
    public AppCharAnimDetachPrepareNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAttachedPropsAnimNotify : ObjectBase<UAppCharAttachedPropsAnimNotify>
{
    public AppCharAttachedPropsAnimNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAnimDataAsset : ObjectBase<UAppCharAnimDataAsset>
{
    public AppCharAnimDataAsset(IntPtr pointer) : base(pointer) {}
    public void Make()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Make"), @params);
    }
}

public unsafe class AppCharAnimFadeNotify : ObjectBase<UAppCharAnimFadeNotify>
{
    public AppCharAnimFadeNotify(IntPtr pointer) : base(pointer) {}}

public unsafe class AppCharAnimLockLookAtNotify : ObjectBase<UAppCharAnimLockLookAtNotify>
{
    public AppCharAnimLockLookAtNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharAnimUnlockLookAtNotify : ObjectBase<UAppCharAnimUnlockLookAtNotify>
{
    public AppCharAnimUnlockLookAtNotify(IntPtr pointer) : base(pointer) {}}

public unsafe class AppCharAnimStopTimingNotify : ObjectBase<UAppCharAnimStopTimingNotify>
{
    public AppCharAnimStopTimingNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppNpcCostume_DA : ObjectBase<UAppNpcCostume_DA>
{
    public AppNpcCostume_DA(IntPtr pointer) : base(pointer) {}
    public void Make()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Make"), @params);
    }
}

public unsafe class AppCharFaceAnimDataAsset : ObjectBase<UAppCharFaceAnimDataAsset>
{
    public AppCharFaceAnimDataAsset(IntPtr pointer) : base(pointer) {}
    public void Make()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Make"), @params);
    }
    public FString GetAssetPath(EAppCharFaceAnimID FaceAnimID, EAppCharCategoryType CharCategory, int CharId, EAppCharAnimCategoryType AnimCategory)
    {
        Span<(string name, object value)> @params = [
            ("FaceAnimID", FaceAnimID), 
            ("CharCategory", CharCategory), 
            ("CharId", CharId), 
            ("AnimCategory", AnimCategory)
        ];
        return ProcessEvent<FString>(GetFunction("GetAssetPath"), @params);
    }
    public void AddExtra()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AddExtra"), @params);
    }
}

public unsafe class AppCharFootstepsAtom : ObjectBase<UAppCharFootstepsAtom>
{
    public AppCharFootstepsAtom(IntPtr pointer) : base(pointer) {}
    public void SetWalkCue(USoundAtomCue* Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", (IntPtr)Value)
        ];
        ProcessEvent(GetFunction("SetWalkCue"), @params);
    }
    public void SetRunCue(USoundAtomCue* Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", (IntPtr)Value)
        ];
        ProcessEvent(GetFunction("SetRunCue"), @params);
    }
    public void SetEnable(bool Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetEnable"), @params);
    }
}

public unsafe class AppCharFootstepsDataAsset : ObjectBase<UAppCharFootstepsDataAsset>
{
    public AppCharFootstepsDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharFootstepsTable : ObjectBase<UAppCharFootstepsTable>
{
    public AppCharFootstepsTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharFootstepsNotify : ObjectBase<UAppCharFootstepsNotify>
{
    public AppCharFootstepsNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharFootstepsTriggerComp_BOX : ObjectBase<UAppCharFootstepsTriggerComp_BOX>
{
    public AppCharFootstepsTriggerComp_BOX(IntPtr pointer) : base(pointer) {}
    public void OnOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnOverlapEnd"), @params);
    }
    public void OnOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnOverlapBegin"), @params);
    }
}

public unsafe class AppCharFootstepsTriggerComp_CIRCLE : ObjectBase<UAppCharFootstepsTriggerComp_CIRCLE>
{
    public AppCharFootstepsTriggerComp_CIRCLE(IntPtr pointer) : base(pointer) {}
    public void OnOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnOverlapEnd"), @params);
    }
    public void OnOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnOverlapBegin"), @params);
    }
}

public unsafe class AppCharFootstepsTriggerVolume : ObjectBase<AAppCharFootstepsTriggerVolume>
{
    public AppCharFootstepsTriggerVolume(IntPtr pointer) : base(pointer) {}
    public void OnOverlapEnd(AActor* OverlappedActor, AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedActor", (IntPtr)OverlappedActor), 
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("OnOverlapEnd"), @params);
    }
    public void OnOverlapBegin(AActor* OverlappedActor, AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedActor", (IntPtr)OverlappedActor), 
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("OnOverlapBegin"), @params);
    }
}

public unsafe class AppCharLib : ObjectBase<UAppCharLib>
{
    public AppCharLib(IntPtr pointer) : base(pointer) {}
    public void SetOpacityNiagaraOnly(AActor* Target, float Value)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetOpacityNiagaraOnly"), @params);
    }
    public void SetOpacity(AActor* Target, float Value)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetOpacity"), @params);
    }
    public bool IsUniqueNpc(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<bool>(GetFunction("IsUniqueNpc"), @params);
    }
    public bool IsDungeonChara(AActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        return ProcessEvent<bool>(GetFunction("IsDungeonChara"), @params);
    }
    public FString GetMaterialSlotName(USkeletalMeshComponent* Target, int ID)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("ID", ID)
        ];
        return ProcessEvent<FString>(GetFunction("GetMaterialSlotName"), @params);
    }
    public TArray<IntPtr> GetMaterial(AActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetMaterial"), @params);
    }
}

public unsafe class AppCharLoader : ObjectBase<UAppCharLoader>
{
    public AppCharLoader(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharTransparencyArea : ObjectBase<AAppCharTransparencyArea>
{
    public AppCharTransparencyArea(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharWeaponAnimDataAsset : ObjectBase<UAppCharWeaponAnimDataAsset>
{
    public AppCharWeaponAnimDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCharWeaponBase : ObjectBase<AAppCharWeaponBase>
{
    public AppCharWeaponBase(IntPtr pointer) : base(pointer) {}
    public void PlayAnimSequence(UAnimSequenceBase* pSequence, bool Loop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("pSequence", (IntPtr)pSequence), 
            ("Loop", Loop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        ProcessEvent(GetFunction("PlayAnimSequence"), @params);
    }
    public void PlayAnim(int animNo, bool Loop, float BlendInTime, float BlendOutTime, float InPlayRate)
    {
        Span<(string name, object value)> @params = [
            ("animNo", animNo), 
            ("Loop", Loop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate)
        ];
        ProcessEvent(GetFunction("PlayAnim"), @params);
    }
    public int GetWaitAnimNo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetWaitAnimNo"), @params);
    }
    public void Event_LoadEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Event_LoadEnd"), @params);
    }
}

public unsafe class AppCheatManager : ObjectBase<UAppCheatManager>
{
    public AppCheatManager(IntPtr pointer) : base(pointer) {}
    public void AtlWindowPosSaveEnable(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("AtlWindowPosSaveEnable"), @params);
    }
    public void AtlUObjectLeakChecker(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("AtlUObjectLeakChecker"), @params);
    }
    public void AtlSoundConfigInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlSoundConfigInfo"), @params);
    }
    public void AtlSoundConfigDevice(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("AtlSoundConfigDevice"), @params);
    }
    public void AtlSetWorldTimeSec(float sec)
    {
        Span<(string name, object value)> @params = [
            ("sec", sec)
        ];
        ProcessEvent(GetFunction("AtlSetWorldTimeSec"), @params);
    }
    public void AtlSetNextDayTime(int Month, int Day, int Time)
    {
        Span<(string name, object value)> @params = [
            ("Month", Month), 
            ("Day", Day), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("AtlSetNextDayTime"), @params);
    }
    public void AtlSetDayTime(int Month, int Day, int Time)
    {
        Span<(string name, object value)> @params = [
            ("Month", Month), 
            ("Day", Day), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("AtlSetDayTime"), @params);
    }
    public void AtlSetCameraTransform(float PosX, float PosY, float PosZ, float RotX, float RotY, float RotZ)
    {
        Span<(string name, object value)> @params = [
            ("PosX", PosX), 
            ("PosY", PosY), 
            ("PosZ", PosZ), 
            ("RotX", RotX), 
            ("RotY", RotY), 
            ("RotZ", RotZ)
        ];
        ProcessEvent(GetFunction("AtlSetCameraTransform"), @params);
    }
    public void AtlSaveDataConvert(FString Mode, FString SaveDataID, int SlotIndex)
    {
        Span<(string name, object value)> @params = [
            ("Mode", Mode), 
            ("SaveDataID", SaveDataID), 
            ("SlotIndex", SlotIndex)
        ];
        ProcessEvent(GetFunction("AtlSaveDataConvert"), @params);
    }
    public void AtlSaveDataAccessorMask(FString Mask)
    {
        Span<(string name, object value)> @params = [
            ("Mask", Mask)
        ];
        ProcessEvent(GetFunction("AtlSaveDataAccessorMask"), @params);
    }
    public void AtlRushEffectRate(float Rate)
    {
        Span<(string name, object value)> @params = [
            ("Rate", Rate)
        ];
        ProcessEvent(GetFunction("AtlRushEffectRate"), @params);
    }
    public void AtlRayTraceEnable(int raytrace, int PlanarReflection)
    {
        Span<(string name, object value)> @params = [
            ("raytrace", raytrace), 
            ("PlanarReflection", PlanarReflection)
        ];
        ProcessEvent(GetFunction("AtlRayTraceEnable"), @params);
    }
    public void AtlPlanarReflectionPercentage(int percent)
    {
        Span<(string name, object value)> @params = [
            ("percent", percent)
        ];
        ProcessEvent(GetFunction("AtlPlanarReflectionPercentage"), @params);
    }
    public void AtlLogWorldTimeSec()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlLogWorldTimeSec"), @params);
    }
    public void AtlGraphicConfigShadowQuality(int Quality)
    {
        Span<(string name, object value)> @params = [
            ("Quality", Quality)
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigShadowQuality"), @params);
    }
    public void AtlGraphicConfigScreenMode(int ScreenMode, int displayNo)
    {
        Span<(string name, object value)> @params = [
            ("ScreenMode", ScreenMode), 
            ("displayNo", displayNo)
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigScreenMode"), @params);
    }
    public void AtlGraphicConfigScreen(int ResX, int ResY, int ScreenMode, int displayNo)
    {
        Span<(string name, object value)> @params = [
            ("ResX", ResX), 
            ("ResY", ResY), 
            ("ScreenMode", ScreenMode), 
            ("displayNo", displayNo)
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigScreen"), @params);
    }
    public void AtlGraphicConfigPreset(int Preset)
    {
        Span<(string name, object value)> @params = [
            ("Preset", Preset)
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigPreset"), @params);
    }
    public void AtlGraphicConfigHardwareStat()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigHardwareStat"), @params);
    }
    public void AtlGraphicConfigFPS(int maxFPS)
    {
        Span<(string name, object value)> @params = [
            ("maxFPS", maxFPS)
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigFPS"), @params);
    }
    public void AtlGraphicConfigBenchmark()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlGraphicConfigBenchmark"), @params);
    }
    public void AtlGetDayTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlGetDayTime"), @params);
    }
    public void AtlForceUnpause()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlForceUnpause"), @params);
    }
    public void AtlForceFadeOUT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlForceFadeOUT"), @params);
    }
    public void AtlForceFadeIN()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlForceFadeIN"), @params);
    }
    public void AtlFieldPlayerPos(float X, float Y, float Z)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z)
        ];
        ProcessEvent(GetFunction("AtlFieldPlayerPos"), @params);
    }
    public void AtlFieldPauseActorALL(bool bPaused)
    {
        Span<(string name, object value)> @params = [
            ("bPaused", bPaused)
        ];
        ProcessEvent(GetFunction("AtlFieldPauseActorALL"), @params);
    }
    public void AtlFieldChangeVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlFieldChangeVisible"), @params);
    }
    public void AtlFieldCameraShakeStart(float InFrequency, float InPowerX, float InPowerY, float InTime)
    {
        Span<(string name, object value)> @params = [
            ("InFrequency", InFrequency), 
            ("InPowerX", InPowerX), 
            ("InPowerY", InPowerY), 
            ("InTime", InTime)
        ];
        ProcessEvent(GetFunction("AtlFieldCameraShakeStart"), @params);
    }
    public void AtlFieldCameraShakeEnd(float InTime)
    {
        Span<(string name, object value)> @params = [
            ("InTime", InTime)
        ];
        ProcessEvent(GetFunction("AtlFieldCameraShakeEnd"), @params);
    }
    public void AtlEventForceFinish()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlEventForceFinish"), @params);
    }
    public void AtlDrawPlayLog(bool bVisible)
    {
        Span<(string name, object value)> @params = [
            ("bVisible", bVisible)
        ];
        ProcessEvent(GetFunction("AtlDrawPlayLog"), @params);
    }
    public void AtlDispLoadedStreamingLevels()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlDispLoadedStreamingLevels"), @params);
    }
    public void AtlDispCharacterPoolListToOutputLog()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlDispCharacterPoolListToOutputLog"), @params);
    }
    public void AtlDevPlayLogging(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("AtlDevPlayLogging"), @params);
    }
    public void AtlCallNextTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlCallNextTime"), @params);
    }
    public void AtlCallEventFild(int EventMaojorID, int EventMinorID)
    {
        Span<(string name, object value)> @params = [
            ("EventMaojorID", EventMaojorID), 
            ("EventMinorID", EventMinorID)
        ];
        ProcessEvent(GetFunction("AtlCallEventFild"), @params);
    }
    public void AtlCallEventCmmu(int EventMaojorID, int EventMinorID)
    {
        Span<(string name, object value)> @params = [
            ("EventMaojorID", EventMaojorID), 
            ("EventMinorID", EventMinorID)
        ];
        ProcessEvent(GetFunction("AtlCallEventCmmu"), @params);
    }
    public void AtlCallEvent(int EventMajorID, int EventMinorID)
    {
        Span<(string name, object value)> @params = [
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID)
        ];
        ProcessEvent(GetFunction("AtlCallEvent"), @params);
    }
    public void AtlCallDebugStartMenu()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlCallDebugStartMenu"), @params);
    }
    public void AtlCallAlphaDebugMenu()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlCallAlphaDebugMenu"), @params);
    }
    public void AtlBtlFadeManagerOldProcessEnable(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("AtlBtlFadeManagerOldProcessEnable"), @params);
    }
    public void AtlBtlCountdownStop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlBtlCountdownStop"), @params);
    }
    public void AtlBtlCountdownSetTime(int InSecond)
    {
        Span<(string name, object value)> @params = [
            ("InSecond", InSecond)
        ];
        ProcessEvent(GetFunction("AtlBtlCountdownSetTime"), @params);
    }
    public void AtlBtlCountdownPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlBtlCountdownPlay"), @params);
    }
    public void AtlBgmStop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlBgmStop"), @params);
    }
    public void AtlBgmRestart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlBgmRestart"), @params);
    }
    public void AtlAutoPlayExecSkillMutationTest(int SkillPackIndex, int MaxTryCount)
    {
        Span<(string name, object value)> @params = [
            ("SkillPackIndex", SkillPackIndex), 
            ("MaxTryCount", MaxTryCount)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecSkillMutationTest"), @params);
    }
    public void AtlAutoPlayExecSkillMutationPowerUpUnitTest(int OldSkillID, int NewSkillID)
    {
        Span<(string name, object value)> @params = [
            ("OldSkillID", OldSkillID), 
            ("NewSkillID", NewSkillID)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecSkillMutationPowerUpUnitTest"), @params);
    }
    public void AtlAutoPlayExecSkillMutationPowerUpTest(int StartIndex, int MaxTryCount)
    {
        Span<(string name, object value)> @params = [
            ("StartIndex", StartIndex), 
            ("MaxTryCount", MaxTryCount)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecSkillMutationPowerUpTest"), @params);
    }
    public void AtlAutoPlayExecShuffleTimeTest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecShuffleTimeTest"), @params);
    }
    public void AtlAutoPlayExecEnemyDropItemLoggingTest(int MinEncountID, int MaxEncountID)
    {
        Span<(string name, object value)> @params = [
            ("MinEncountID", MinEncountID), 
            ("MaxEncountID", MaxEncountID)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecEnemyDropItemLoggingTest"), @params);
    }
    public void AtlAutoPlayExecEnemyAILoggingTest(int MinEncountID, int MaxEncountID)
    {
        Span<(string name, object value)> @params = [
            ("MinEncountID", MinEncountID), 
            ("MaxEncountID", MaxEncountID)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecEnemyAILoggingTest"), @params);
    }
    public void AtlAutoPlayExecDungeonTBoxTest(int BeginFloor, int EndFloor, bool bLoop)
    {
        Span<(string name, object value)> @params = [
            ("BeginFloor", BeginFloor), 
            ("EndFloor", EndFloor), 
            ("bLoop", bLoop)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecDungeonTBoxTest"), @params);
    }
    public void AtlAutoPlayExecDungeonPassingTest(int BeginFloor, int EndFloor, bool bLoop, bool bRebuild)
    {
        Span<(string name, object value)> @params = [
            ("BeginFloor", BeginFloor), 
            ("EndFloor", EndFloor), 
            ("bLoop", bLoop), 
            ("bRebuild", bRebuild)
        ];
        ProcessEvent(GetFunction("AtlAutoPlayExecDungeonPassingTest"), @params);
    }
    public void AtlAutoPlay(FString OPTION)
    {
        Span<(string name, object value)> @params = [
            ("OPTION", OPTION)
        ];
        ProcessEvent(GetFunction("AtlAutoPlay"), @params);
    }
}

public unsafe class AppChunkInstall : ObjectBase<UAppChunkInstall>
{
    public AppChunkInstall(IntPtr pointer) : base(pointer) {}}

public unsafe class AppMultiDataAsset : ObjectBase<UAppMultiDataAsset>
{
    public AppMultiDataAsset(IntPtr pointer) : base(pointer) {}
    public void Import()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Import"), @params);
    }
}

public unsafe class AppKoromaruComp : ObjectBase<UAppKoromaruComp>
{
    public AppKoromaruComp(IntPtr pointer) : base(pointer) {}}

public unsafe class AppLvMngUnloadMonitorActor : ObjectBase<AAppLvMngUnloadMonitorActor>
{
    public AppLvMngUnloadMonitorActor(IntPtr pointer) : base(pointer) {}
    public void OnEndExec()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnEndExec"), @params);
    }
}

public unsafe class AppLevelManager : ObjectBase<UAppLevelManager>
{
    public AppLevelManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class ApplicationWindowState : ObjectBase<AApplicationWindowState>
{
    public ApplicationWindowState(IntPtr pointer) : base(pointer) {}
    public void OnFocusChangeBP(bool IsFocus)
    {
        Span<(string name, object value)> @params = [
            ("IsFocus", IsFocus)
        ];
        ProcessEvent(GetFunction("OnFocusChangeBP"), @params);
    }
}

public unsafe class AppNpcComp : ObjectBase<UAppNpcComp>
{
    public AppNpcComp(IntPtr pointer) : base(pointer) {}
    public void SetFootForBP(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SetFootForBP"), @params);
    }
    public void SetCosTexID(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetCosTexID"), @params);
    }
    public ANpcBaseCore* GetBaseCore()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ANpcBaseCore*)ProcessEvent<IntPtr>(GetFunction("GetBaseCore"), @params);
    }
}

public unsafe class AppPauseableListener : ObjectBase<IAppPauseableListener>
{
    public AppPauseableListener(IntPtr pointer) : base(pointer) {}
    public void UnPaused(EAppPauseType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("UnPaused"), @params);
    }
    public void Paused(EAppPauseType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("Paused"), @params);
    }
    public EAppPauseObjectFlag GetAppPauseFlags()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAppPauseObjectFlag>(GetFunction("GetAppPauseFlags"), @params);
    }
    public UObject* AsUObject()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("AsUObject"), @params);
    }
    public AActor* AsAActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("AsAActor"), @params);
    }
    public void AppPauseableEndPlay(EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("AppPauseableEndPlay"), @params);
    }
    public void AppPauseableBeginPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AppPauseableBeginPlay"), @params);
    }
}

public unsafe class AppPauseList : ObjectBase<UAppPauseList>
{
    public AppPauseList(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppPauseManagerSubsystem : ObjectBase<UAppPauseManagerSubsystem>
{
    public AppPauseManagerSubsystem(IntPtr pointer) : base(pointer) {}
    public void UnPause()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UnPause"), @params);
    }
    public void Pause(EAppPauseType InPauseType)
    {
        Span<(string name, object value)> @params = [
            ("InPauseType", InPauseType)
        ];
        ProcessEvent(GetFunction("Pause"), @params);
    }
    public bool IsPause(ref EAppPauseType PauseType)
    {
        Span<(string name, object value)> @params = [
            ("PauseType", PauseType)
        ];
        return ProcessEvent<bool>(GetFunction("IsPause"), @params);
    }
}

public unsafe class AppPropsAnimPackAsset : ObjectBase<UAppPropsAnimPackAsset>
{
    public AppPropsAnimPackAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppPropsCardInterface : ObjectBase<IAppPropsCardInterface>
{
    public AppPropsCardInterface(IntPtr pointer) : base(pointer) {}
    public bool TarotCardSync()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("TarotCardSync"), @params);
    }
    public void TarotCardSetup(FAppPropsCardParam Param)
    {
        Span<(string name, object value)> @params = [
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("TarotCardSetup"), @params);
    }
    public UMaterialInstanceDynamic* GetFrontMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetFrontMaterial"), @params);
    }
    public UMaterialInstanceDynamic* GetBackMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetBackMaterial"), @params);
    }
}

public unsafe class AppPropsCardContainer : ObjectBase<AAppPropsCardContainer>
{
    public AppPropsCardContainer(IntPtr pointer) : base(pointer) {}
    public bool SyncCards()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncCards"), @params);
    }
    public void LoadCards(TArray<FAppPropsCardParam> Params)
    {
        Span<(string name, object value)> @params = [
            ("Params", Params)
        ];
        ProcessEvent(GetFunction("LoadCards"), @params);
    }
    public TArray<FAppPropsCardData> GetCards()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FAppPropsCardData>>(GetFunction("GetCards"), @params);
    }
    public void DestroyContainer(bool DestroyCardProps)
    {
        Span<(string name, object value)> @params = [
            ("DestroyCardProps", DestroyCardProps)
        ];
        ProcessEvent(GetFunction("DestroyContainer"), @params);
    }
}

public unsafe class AppPropsCore : ObjectBase<AAppPropsCore>
{
    public AppPropsCore(IntPtr pointer) : base(pointer) {}
    public void PlayAnimationPack(int AnimePackIndex, bool IsLoop, float BlendInTime, float BlendOutTime, float InPlayRate, FName AnimSlotName)
    {
        Span<(string name, object value)> @params = [
            ("AnimePackIndex", AnimePackIndex), 
            ("IsLoop", IsLoop), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("AnimSlotName", AnimSlotName)
        ];
        ProcessEvent(GetFunction("PlayAnimationPack"), @params);
    }
    public void CompareToHiddenCharacter(int LocalDataIndex, int ConditionalValue, EEvtConditionalBranchCompType CompareType)
    {
        Span<(string name, object value)> @params = [
            ("LocalDataIndex", LocalDataIndex), 
            ("ConditionalValue", ConditionalValue), 
            ("CompareType", CompareType)
        ];
        ProcessEvent(GetFunction("CompareToHiddenCharacter"), @params);
    }
}

public unsafe class AssetHolder : ObjectBase<UAssetHolder>
{
    public AssetHolder(IntPtr pointer) : base(pointer) {}
    public void UnloadAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UnloadAsset"), @params);
    }
    public void LoadedDelegate__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadedDelegate__DelegateSignature"), @params);
    }
    public void LoadComplete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadComplete"), @params);
    }
    public void LoadAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadAsset"), @params);
    }
    public void ChildLoadComplete(TArray<IntPtr> loadedAssets)
    {
        Span<(string name, object value)> @params = [
            ("loadedAssets", loadedAssets)
        ];
        ProcessEvent(GetFunction("ChildLoadComplete"), @params);
    }
}

public unsafe class AssetLoader : ObjectBase<UAssetLoader>
{
    public AssetLoader(IntPtr pointer) : base(pointer) {}}

public unsafe class AssistTest : ObjectBase<AAssistTest>
{
    public AssistTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class AssistViewTest : ObjectBase<AAssistViewTest>
{
    public AssistViewTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtActorComponent : ObjectBase<UAtlEvtActorComponent>
{
    public AtlEvtActorComponent(IntPtr pointer) : base(pointer) {}
    public AHandwritingSpawner* SpawnHandwritingAttachedDefaultParam(EAtlEvtHandwritingType Type, bool bAttached)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("bAttached", bAttached)
        ];
        return (AHandwritingSpawner*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAttachedDefaultParam"), @params);
    }
    public AHandwritingSpawner* SpawnHandwritingAttached(EAtlEvtHandwritingType Type, int LoopCount, float CameraOffset, FName AttachPointName, FVector Location, FRotator Rotation, FVector Scale, bool bAttached)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("LoopCount", LoopCount), 
            ("CameraOffset", CameraOffset), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("Scale", Scale), 
            ("bAttached", bAttached)
        ];
        return (AHandwritingSpawner*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAttached"), @params);
    }
    public void SetUseAnimPack(bool bInUseAnimPack)
    {
        Span<(string name, object value)> @params = [
            ("bInUseAnimPack", bInUseAnimPack)
        ];
        ProcessEvent(GetFunction("SetUseAnimPack"), @params);
    }
    public void SetupHeroBag()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupHeroBag"), @params);
    }
    public void SetupAnimPack()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupAnimPack"), @params);
    }
    public void SetShoesId(EAppCharShoesID ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SetShoesId"), @params);
    }
    public void SetOverwriteDettachPropTransform(ref FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform)
        ];
        ProcessEvent(GetFunction("SetOverwriteDettachPropTransform"), @params);
    }
    public void SetOverrideAnimPackID(EAnimPackID InAnimPackID)
    {
        Span<(string name, object value)> @params = [
            ("InAnimPackID", InAnimPackID)
        ];
        ProcessEvent(GetFunction("SetOverrideAnimPackID"), @params);
    }
    public void SetLocomotionTeleportVelocityType(EAtlEvtLocomotionTeleportVelocityType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetLocomotionTeleportVelocityType"), @params);
    }
    public void SetEnableBag(bool bInEnableAtlEvtBag)
    {
        Span<(string name, object value)> @params = [
            ("bInEnableAtlEvtBag", bInEnableAtlEvtBag)
        ];
        ProcessEvent(GetFunction("SetEnableBag"), @params);
    }
    public void SetEnableAtlEvtLocomotionVelocitySimulation(bool bInEnableAtlEvtLocomotionVelocitySimulation)
    {
        Span<(string name, object value)> @params = [
            ("bInEnableAtlEvtLocomotionVelocitySimulation", bInEnableAtlEvtLocomotionVelocitySimulation)
        ];
        ProcessEvent(GetFunction("SetEnableAtlEvtLocomotionVelocitySimulation"), @params);
    }
    public void SetAttachPropActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetAttachPropActor"), @params);
    }
    public void ResetVelocitySimulateParam()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetVelocitySimulateParam"), @params);
    }
    public void LoadEnded()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadEnded"), @params);
    }
    public bool IsUseAnimPack()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUseAnimPack"), @params);
    }
    public bool IsEnableLocomotionVelocitySimulate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnableLocomotionVelocitySimulate"), @params);
    }
    public bool IsEnableBag()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnableBag"), @params);
    }
    public EAppCharShoesID GetShoesID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAppCharShoesID>(GetFunction("GetShoesID"), @params);
    }
    public EAtlEvtLocomotionTeleportVelocityType GetLocomotionTeleportVelocityType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAtlEvtLocomotionTeleportVelocityType>(GetFunction("GetLocomotionTeleportVelocityType"), @params);
    }
    public void CompareToHiddenCharacter(int LocalDataIndex, int ConditionalValue, EEvtConditionalBranchCompType CompareType)
    {
        Span<(string name, object value)> @params = [
            ("LocalDataIndex", LocalDataIndex), 
            ("ConditionalValue", ConditionalValue), 
            ("CompareType", CompareType)
        ];
        ProcessEvent(GetFunction("CompareToHiddenCharacter"), @params);
    }
    public void ClearAttachPropActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearAttachPropActor"), @params);
    }
    public FVector CalcEvtLocomotionTeleportVelocity(ref FVector SimVelocity, ref FVector PrevSimVelocity, float VelocityRate)
    {
        Span<(string name, object value)> @params = [
            ("SimVelocity", SimVelocity), 
            ("PrevSimVelocity", PrevSimVelocity), 
            ("VelocityRate", VelocityRate)
        ];
        return ProcessEvent<FVector>(GetFunction("CalcEvtLocomotionTeleportVelocity"), @params);
    }
}

public unsafe class AtlEvtAnswerActor : ObjectBase<AAtlEvtAnswerActor>
{
    public AtlEvtAnswerActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtHelperSettings : ObjectBase<UAtlEvtHelperSettings>
{
    public AtlEvtHelperSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtEventEditHelper : ObjectBase<AAtlEvtEventEditHelper>
{
    public AtlEvtEventEditHelper(IntPtr pointer) : base(pointer) {}
    public void SetPreviewCrowdSettings(int InCrowdMonth, int InCrowdDay, ECldTimeZone InCrowdTimeZone, bool bInPreviewCrowd)
    {
        Span<(string name, object value)> @params = [
            ("InCrowdMonth", InCrowdMonth), 
            ("InCrowdDay", InCrowdDay), 
            ("InCrowdTimeZone", InCrowdTimeZone), 
            ("bInPreviewCrowd", bInPreviewCrowd)
        ];
        ProcessEvent(GetFunction("SetPreviewCrowdSettings"), @params);
    }
    public void OnLoadedLevelInPIE()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadedLevelInPIE"), @params);
    }
    public bool IsRankAEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsRankAEvent"), @params);
    }
}

public unsafe class AtlEvtEventManager : ObjectBase<AAtlEvtEventManager>
{
    public AtlEvtEventManager(IntPtr pointer) : base(pointer) {}
    public void SetLocalData(int Index, int Data)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Data", Data)
        ];
        ProcessEvent(GetFunction("SetLocalData"), @params);
    }
    public void ResumeEventSequencer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResumeEventSequencer"), @params);
    }
    public void OnFinishedAtlScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedAtlScr"), @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"), @params);
    }
    public bool IsEventRankA()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEventRankA"), @params);
    }
    public int GetLocalData(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetLocalData"), @params);
    }
    public void ForcedStopScript()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForcedStopScript"), @params);
    }
    public void ForcedRemoveMessage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForcedRemoveMessage"), @params);
    }
    public void ForceClick(FKey Key, EInputEvent EventType)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("EventType", EventType)
        ];
        ProcessEvent(GetFunction("ForceClick"), @params);
    }
    public int ExecuteSelectScript()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("ExecuteSelectScript"), @params);
    }
    public void ExecuteScript(UBfAsset* InAsset, int InProcNo, bool bUseBmdAssetInBfAsset, UBmdAsset* InBmdAsset)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InProcNo", InProcNo), 
            ("bUseBmdAssetInBfAsset", bUseBmdAssetInBfAsset), 
            ("InBmdAsset", (IntPtr)InBmdAsset)
        ];
        ProcessEvent(GetFunction("ExecuteScript"), @params);
    }
    public int ExecuteMsgScript()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("ExecuteMsgScript"), @params);
    }
    public void ExecuteMessageWithSelect(UBmdAsset* InAsset, int InMessageNo, int InSelectNo, int InSelectResponceToLocalDataID, int InSeqEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageNo", InMessageNo), 
            ("InSelectNo", InSelectNo), 
            ("InSelectResponceToLocalDataID", InSelectResponceToLocalDataID), 
            ("InSeqEventMessageID", InSeqEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteMessageWithSelect"), @params);
    }
    public void ExecuteMessage(UBmdAsset* InAsset, int InMessageNo, int InEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageNo", InMessageNo), 
            ("InEventMessageID", InEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteMessage"), @params);
    }
    public void ExecuteBmdMessageWithSelect(UBmdAsset* InAsset, int InMessageMajorID, int InMessageMinorID, int InMessageSubID, int InMessagePageID, int InSelectMessageMajorID, int InSelectMessageMinorID, int InSelectMessageSubID, int InSelectResponceToLocalDataID, bool bInEnableMessageRef, int InEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageMajorID", InMessageMajorID), 
            ("InMessageMinorID", InMessageMinorID), 
            ("InMessageSubID", InMessageSubID), 
            ("InMessagePageID", InMessagePageID), 
            ("InSelectMessageMajorID", InSelectMessageMajorID), 
            ("InSelectMessageMinorID", InSelectMessageMinorID), 
            ("InSelectMessageSubID", InSelectMessageSubID), 
            ("InSelectResponceToLocalDataID", InSelectResponceToLocalDataID), 
            ("bInEnableMessageRef", bInEnableMessageRef), 
            ("InEventMessageID", InEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteBmdMessageWithSelect"), @params);
    }
    public void ExecuteBmdMessageSubtitleWithSelect(UBmdAsset* InAsset, int InMessageMajorID, int InMessageMinorID, int InMessageSubID, int InMessagePageID, int InDrawFrame, int InSelectMessageMajorID, int InSelectMessageMinorID, int InSelectMessageSubID, int InSelectResponceToLocalDataID, bool bInEnableMessageRef, int InSeqEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageMajorID", InMessageMajorID), 
            ("InMessageMinorID", InMessageMinorID), 
            ("InMessageSubID", InMessageSubID), 
            ("InMessagePageID", InMessagePageID), 
            ("InDrawFrame", InDrawFrame), 
            ("InSelectMessageMajorID", InSelectMessageMajorID), 
            ("InSelectMessageMinorID", InSelectMessageMinorID), 
            ("InSelectMessageSubID", InSelectMessageSubID), 
            ("InSelectResponceToLocalDataID", InSelectResponceToLocalDataID), 
            ("bInEnableMessageRef", bInEnableMessageRef), 
            ("InSeqEventMessageID", InSeqEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteBmdMessageSubtitleWithSelect"), @params);
    }
    public void ExecuteBmdMessageSubtitleSelect(UBmdAsset* InAsset, int InSelectMessageMajorID, int InSelectMessageMinorID, int InSelectMessageSubID, int InSelectResponceToLocalDataID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InSelectMessageMajorID", InSelectMessageMajorID), 
            ("InSelectMessageMinorID", InSelectMessageMinorID), 
            ("InSelectMessageSubID", InSelectMessageSubID), 
            ("InSelectResponceToLocalDataID", InSelectResponceToLocalDataID)
        ];
        ProcessEvent(GetFunction("ExecuteBmdMessageSubtitleSelect"), @params);
    }
    public void ExecuteBmdMessageSubtitle(UBmdAsset* InAsset, int InMessageMajorID, int InMessageMinorID, int InMessageSubID, int InMessagePageID, int InDrawFrame, bool bInEnableMessageRef, int InSeqEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageMajorID", InMessageMajorID), 
            ("InMessageMinorID", InMessageMinorID), 
            ("InMessageSubID", InMessageSubID), 
            ("InMessagePageID", InMessagePageID), 
            ("InDrawFrame", InDrawFrame), 
            ("bInEnableMessageRef", bInEnableMessageRef), 
            ("InSeqEventMessageID", InSeqEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteBmdMessageSubtitle"), @params);
    }
    public void ExecuteBmdMessage(UBmdAsset* InAsset, int InMessageMajorID, int InMessageMinorID, int InMessageSubID, int InMessagePageID, bool bInEnableMessageRef, int InSeqEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageMajorID", InMessageMajorID), 
            ("InMessageMinorID", InMessageMinorID), 
            ("InMessageSubID", InMessageSubID), 
            ("InMessagePageID", InMessagePageID), 
            ("bInEnableMessageRef", bInEnableMessageRef), 
            ("InSeqEventMessageID", InSeqEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteBmdMessage"), @params);
    }
    public void CloseMessage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseMessage"), @params);
    }
    public void BackLogFinishDelegte()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BackLogFinishDelegte"), @params);
    }
    public void AtlEvt_ResumeEventSequencer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AtlEvt_ResumeEventSequencer"), @params);
    }
}

public unsafe class AtlEvtEventManager_PauseActor : ObjectBase<AAtlEvtEventManager_PauseActor>
{
    public AtlEvtEventManager_PauseActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtHandwritingDataAsset : ObjectBase<UAtlEvtHandwritingDataAsset>
{
    public AtlEvtHandwritingDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtHandwritingSubsystem : ObjectBase<UAtlEvtHandwritingSubsystem>
{
    public AtlEvtHandwritingSubsystem(IntPtr pointer) : base(pointer) {}
    public void LoadEventHandwrintingData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadEventHandwrintingData"), @params);
    }
}

public unsafe class AtlEvtHighStreamingLocator : ObjectBase<AAtlEvtHighStreamingLocator>
{
    public AtlEvtHighStreamingLocator(IntPtr pointer) : base(pointer) {}
    public void SetEnableHighStreaming(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetEnableHighStreaming"), @params);
    }
}

public unsafe class AtlEvtLevelSequenceLoadingActor : ObjectBase<AAtlEvtLevelSequenceLoadingActor>
{
    public AtlEvtLevelSequenceLoadingActor(IntPtr pointer) : base(pointer) {}
    public void OnFinishedLoadingAssets()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedLoadingAssets"), @params);
    }
}

public unsafe class AtlEvtLevelSequenceActor : ObjectBase<AAtlEvtLevelSequenceActor>
{
    public AtlEvtLevelSequenceActor(IntPtr pointer) : base(pointer) {}
    public void PreloadEvtDialogueTime(UMovieSceneSequence* MovieSceneSequence, UMovieSceneSubSection* CurrentSubSceneSection)
    {
        Span<(string name, object value)> @params = [
            ("MovieSceneSequence", (IntPtr)MovieSceneSequence), 
            ("CurrentSubSceneSection", (IntPtr)CurrentSubSceneSection)
        ];
        ProcessEvent(GetFunction("PreloadEvtDialogueTime"), @params);
    }
    public void OnTickFromSequenceTickManager__DelegateSignature(FQualifiedFrameTime CurrentTime, FQualifiedFrameTime PreviousTime)
    {
        Span<(string name, object value)> @params = [
            ("CurrentTime", CurrentTime), 
            ("PreviousTime", PreviousTime)
        ];
        ProcessEvent(GetFunction("OnTickFromSequenceTickManager__DelegateSignature"), @params);
    }
    public void OnHighSpeed(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("OnHighSpeed"), @params);
    }
    public bool IsCompletedLoadSoundAssets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCompletedLoadSoundAssets"), @params);
    }
}

public unsafe class AtlEvtLightScenarioSublevelsDataAsset : ObjectBase<UAtlEvtLightScenarioSublevelsDataAsset>
{
    public AtlEvtLightScenarioSublevelsDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtLightScenarioLoader : ObjectBase<AAtlEvtLightScenarioLoader>
{
    public AtlEvtLightScenarioLoader(IntPtr pointer) : base(pointer) {}
    public void OnLoadCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadCompleted"), @params);
    }
}

public unsafe class AtlEvtLightScenarioUnloader : ObjectBase<AAtlEvtLightScenarioUnloader>
{
    public AtlEvtLightScenarioUnloader(IntPtr pointer) : base(pointer) {}
    public void OnUnloadCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnUnloadCompleted"), @params);
    }
}

public unsafe class AtlEvtLightScenarioTransitionController : ObjectBase<AAtlEvtLightScenarioTransitionController>
{
    public AtlEvtLightScenarioTransitionController(IntPtr pointer) : base(pointer) {}
    public void TransitionLightScenario(int InNextLightScenarioIndex)
    {
        Span<(string name, object value)> @params = [
            ("InNextLightScenarioIndex", InNextLightScenarioIndex)
        ];
        ProcessEvent(GetFunction("TransitionLightScenario"), @params);
    }
    public void RemoveAllLightScenarioParam()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveAllLightScenarioParam"), @params);
    }
    public void OnUnloadFinished(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("OnUnloadFinished"), @params);
    }
    public void OnLoadFinished(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("OnLoadFinished"), @params);
    }
    public void OnCompletedPreload()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnCompletedPreload"), @params);
    }
    public bool IsDoingTransition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDoingTransition"), @params);
    }
    public int GetLightScenarioNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetLightScenarioNum"), @params);
    }
    public int AddLightScenario(FName LevelName)
    {
        Span<(string name, object value)> @params = [
            ("LevelName", LevelName)
        ];
        return ProcessEvent<int>(GetFunction("AddLightScenario"), @params);
    }
}

public unsafe class AtlEvtMoviePlayManager : ObjectBase<UAtlEvtMoviePlayManager>
{
    public AtlEvtMoviePlayManager(IntPtr pointer) : base(pointer) {}}

public unsafe class EvtTextureForOnePicture : ObjectBase<UEvtTextureForOnePicture>
{
    public EvtTextureForOnePicture(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtOnePicture : ObjectBase<AAtlEvtOnePicture>
{
    public AtlEvtOnePicture(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtPreDataAsset : ObjectBase<UAtlEvtPreDataAsset>
{
    public AtlEvtPreDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlEvtPropDetachLocator : ObjectBase<AAtlEvtPropDetachLocator>
{
    public AtlEvtPropDetachLocator(IntPtr pointer) : base(pointer) {}}

public unsafe class AtlEvtSubsystem : ObjectBase<UAtlEvtSubsystem>
{
    public AtlEvtSubsystem(IntPtr pointer) : base(pointer) {}
    public void TransitionLightScenarioSublevel(int NextLightScenarioIndex)
    {
        Span<(string name, object value)> @params = [
            ("NextLightScenarioIndex", NextLightScenarioIndex)
        ];
        ProcessEvent(GetFunction("TransitionLightScenarioSublevel"), @params);
    }
    public void SetShowCinemaScope(bool bShow)
    {
        Span<(string name, object value)> @params = [
            ("bShow", bShow)
        ];
        ProcessEvent(GetFunction("SetShowCinemaScope"), @params);
    }
    public void SetOT(FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("SetOT"), @params);
    }
    public void SetLocalData(int Index, int Data)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Data", Data)
        ];
        ProcessEvent(GetFunction("SetLocalData"), @params);
    }
    public void SetEventPlayMode(EAtlEvtPlayMode InPlayMode)
    {
        Span<(string name, object value)> @params = [
            ("InPlayMode", InPlayMode)
        ];
        ProcessEvent(GetFunction("SetEventPlayMode"), @params);
    }
    public void ResetLocalData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetLocalData"), @params);
    }
    public void OnActorSpawnedEventSublevel(AActor* SpawnedActor)
    {
        Span<(string name, object value)> @params = [
            ("SpawnedActor", (IntPtr)SpawnedActor)
        ];
        ProcessEvent(GetFunction("OnActorSpawnedEventSublevel"), @params);
    }
    public TArray<FString> MakeFieldSublevelPathListField(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("MakeFieldSublevelPathListField"), @params);
    }
    public TArray<FString> MakeFieldSublevelPathListEvent(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("MakeFieldSublevelPathListEvent"), @params);
    }
    public TArray<FString> MakeFieldSublevelPathListCmmu(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("MakeFieldSublevelPathListCmmu"), @params);
    }
    public TArray<FString> MakeFieldSublevelPathList(UObject* WorldContextObject, EAtlEvtEventCategoryType CategoryType, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CategoryType", CategoryType), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        return ProcessEvent<TArray<FString>>(GetFunction("MakeFieldSublevelPathList"), @params);
    }
    public bool IsShowCinemaScope()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsShowCinemaScope"), @params);
    }
    public bool IsPlayingEventOrEditHelperMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingEventOrEditHelperMode"), @params);
    }
    public bool IsPlayingEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingEvent"), @params);
    }
    public bool IsHighSpeed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsHighSpeed"), @params);
    }
    public bool IsFinishedPreloadLightScenarioSublevels()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsFinishedPreloadLightScenarioSublevels"), @params);
    }
    public bool IsEventPlayModeEditHelper()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEventPlayModeEditHelper"), @params);
    }
    public bool IsDoingTransitionLightScenarioSublevel()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDoingTransitionLightScenarioSublevel"), @params);
    }
    public bool IsConditionalBranchFromLocalData(EEvtConditionalBranchCompType CompType, int LHS, int Index)
    {
        Span<(string name, object value)> @params = [
            ("CompType", CompType), 
            ("LHS", LHS), 
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("IsConditionalBranchFromLocalData"), @params);
    }
    public void InitScriptFinishFunction(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("InitScriptFinishFunction"), @params);
    }
    public FAtlEvtVisibleEventInfo GetPlayingVisibleEventInfo(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<FAtlEvtVisibleEventInfo>(GetFunction("GetPlayingVisibleEventInfo"), @params);
    }
    public int GetLocalData(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetLocalData"), @params);
    }
    public TArray<FAtlEvtPlayLoadSublevelInfo> GetLoadedEventSublevelInfos()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FAtlEvtPlayLoadSublevelInfo>>(GetFunction("GetLoadedEventSublevelInfos"), @params);
    }
    public AActor* GetFirstAppEventCharacterByLipUniqueID(int LipUniqueID)
    {
        Span<(string name, object value)> @params = [
            ("LipUniqueID", LipUniqueID)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetFirstAppEventCharacterByLipUniqueID"), @params);
    }
    public AActor* GetFirstAppEventCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetFirstAppEventCharacter"), @params);
    }
    public uint GetEvtPreDataHash(EAtlEvtEventCategoryType CategoryType, int EventMajorID, int EventMinorID)
    {
        Span<(string name, object value)> @params = [
            ("CategoryType", CategoryType), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID)
        ];
        return ProcessEvent<uint>(GetFunction("GetEvtPreDataHash"), @params);
    }
    public FAtlEvtPreData GetEvtPreData(EAtlEvtEventCategoryType CategoryType, int EventMajorID, int EventMinorID)
    {
        Span<(string name, object value)> @params = [
            ("CategoryType", CategoryType), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID)
        ];
        return ProcessEvent<FAtlEvtPreData>(GetFunction("GetEvtPreData"), @params);
    }
    public EAtlEvtPlayMode GetEventPlayMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EAtlEvtPlayMode>(GetFunction("GetEventPlayMode"), @params);
    }
    public uint GetAppEvtCharactersHash(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        return ProcessEvent<uint>(GetFunction("GetAppEvtCharactersHash"), @params);
    }
    public FAtlEvtPlayingCharacterInfo GetAppEventCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        return ProcessEvent<FAtlEvtPlayingCharacterInfo>(GetFunction("GetAppEventCharacter"), @params);
    }
    public void EvtPlay(UObject* WorldContextObject, FString EvtName, FString InEventRank, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EvtName", EvtName), 
            ("InEventRank", InEventRank), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("EvtPlay"), @params);
    }
    public void DateOffDelegate(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("DateOffDelegate"), @params);
    }
    public void CallEventField(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("CallEventField"), @params);
    }
    public void CallEventCmmu(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("CallEventCmmu"), @params);
    }
    public AAtlEvtPlayObject* CallEvent_SpawnLoadSublevelActor(UWorld* World, ref FName StreamTargetLevelName, ref FAtlEvtPlayParameter Param, ref FAtlEvtPreData PreData, EAtlEvtSublevelType SublevelType, ref FLatentActionInfo LatentInfo, UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("World", (IntPtr)World), 
            ("StreamTargetLevelName", StreamTargetLevelName), 
            ("Param", Param), 
            ("PreData", PreData), 
            ("SublevelType", SublevelType), 
            ("LatentInfo", LatentInfo), 
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (AAtlEvtPlayObject*)ProcessEvent<IntPtr>(GetFunction("CallEvent_SpawnLoadSublevelActor"), @params);
    }
    public bool CallEvent_IsCompleteFieldLoadingSublevel()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CallEvent_IsCompleteFieldLoadingSublevel"), @params);
    }
    public void CallEvent_InternalFinishedEvent(int Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("CallEvent_InternalFinishedEvent"), @params);
    }
    public void CallEvent_DecrementFieldLoadingCount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallEvent_DecrementFieldLoadingCount"), @params);
    }
    public void CallEvent(UObject* WorldContextObject, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("CallEvent"), @params);
    }
    public void CallCategoryEvent(UObject* WorldContextObject, EAtlEvtEventCategoryType CategoryType, int EventMajorID, int EventMinorID, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CategoryType", CategoryType), 
            ("EventMajorID", EventMajorID), 
            ("EventMinorID", EventMinorID), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("CallCategoryEvent"), @params);
    }
}

public unsafe class AtlEvtPlayObject : ObjectBase<AAtlEvtPlayObject>
{
    public AtlEvtPlayObject(IntPtr pointer) : base(pointer) {}
    public void OnPlayEventSequencer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnPlayEventSequencer"), @params);
    }
    public void OnLoadLevelStreaming()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadLevelStreaming"), @params);
    }
    public void OnLoadFieldLevelStreaming_WaitUnpaused()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFieldLevelStreaming_WaitUnpaused"), @params);
    }
    public void OnLoadFieldLevelStreaming_DelayCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFieldLevelStreaming_DelayCompleted"), @params);
    }
    public void OnLoadFieldLevelStreaming()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadFieldLevelStreaming"), @params);
    }
    public void OnLoadEvtLevelSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadEvtLevelSequence"), @params);
    }
    public void OnLoadedReplaceCharactersCostume()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadedReplaceCharactersCostume"), @params);
    }
    public void OnLoadedReplaceCharacters()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadedReplaceCharacters"), @params);
    }
    public void OnLoadedMovieTrack()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadedMovieTrack"), @params);
    }
    public void OnFinishedSceneChange()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedSceneChange"), @params);
    }
    public void OnFinishedEventSequencer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedEventSequencer"), @params);
    }
}

public unsafe class AtlEvtPlayUnstreamObject : ObjectBase<AAtlEvtPlayUnstreamObject>
{
    public AtlEvtPlayUnstreamObject(IntPtr pointer) : base(pointer) {}
    public void OnFinishedUnloadLevelStreaming()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinishedUnloadLevelStreaming"), @params);
    }
}

public unsafe class AtlEvtSubsystemDraft : ObjectBase<UDEPRECATED_AtlEvtSubsystemDraft>
{
    public AtlEvtSubsystemDraft(IntPtr pointer) : base(pointer) {}
    public void ResetGlobalCount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetGlobalCount"), @params);
    }
    public void EvtPlay(UObject* WorldContextObject, FString EvtName, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EvtName", EvtName), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("EvtPlay"), @params);
    }
}

public unsafe class AtlHandwritingDataAsset : ObjectBase<UAtlHandwritingDataAsset>
{
    public AtlHandwritingDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlNiagaraActor : ObjectBase<AAtlNiagaraActor>
{
    public AtlNiagaraActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlUIPlg : ObjectBase<UAtlUIPlg>
{
    public AtlUIPlg(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlUIPrimitive : ObjectBase<UAtlUIPrimitive>
{
    public AtlUIPrimitive(IntPtr pointer) : base(pointer) {}
}

public unsafe class AtlUITextBlock : ObjectBase<UAtlUITextBlock>
{
    public AtlUITextBlock(IntPtr pointer) : base(pointer) {}
    public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
    {
        Span<(string name, object value)> @params = [
            ("InTransformPolicy", InTransformPolicy)
        ];
        ProcessEvent(GetFunction("SetTextTransformPolicy"), @params);
    }
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetStrikeBrush(FSlateBrush InStrikeBrush)
    {
        Span<(string name, object value)> @params = [
            ("InStrikeBrush", InStrikeBrush)
        ];
        ProcessEvent(GetFunction("SetStrikeBrush"), @params);
    }
    public void SetShadowOffset(FVector2D InShadowOffset)
    {
        Span<(string name, object value)> @params = [
            ("InShadowOffset", InShadowOffset)
        ];
        ProcessEvent(GetFunction("SetShadowOffset"), @params);
    }
    public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InShadowColorAndOpacity", InShadowColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetShadowColorAndOpacity"), @params);
    }
    public void SetOpacity(float InOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InOpacity", InOpacity)
        ];
        ProcessEvent(GetFunction("SetOpacity"), @params);
    }
    public void SetMinDesiredWidth(float InMinDesiredWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredWidth", InMinDesiredWidth)
        ];
        ProcessEvent(GetFunction("SetMinDesiredWidth"), @params);
    }
    public void SetFont(FSlateFontInfo InFontInfo)
    {
        Span<(string name, object value)> @params = [
            ("InFontInfo", InFontInfo)
        ];
        ProcessEvent(GetFunction("SetFont"), @params);
    }
    public void SetColorAndOpacity(FSlateColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetColorAndOpacity"), @params);
    }
    public void SetAutoWrapText(bool InAutoTextWrap)
    {
        Span<(string name, object value)> @params = [
            ("InAutoTextWrap", InAutoTextWrap)
        ];
        ProcessEvent(GetFunction("SetAutoWrapText"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicOutlineMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicOutlineMaterial"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicFontMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicFontMaterial"), @params);
    }
}

public unsafe class AtlUITriangle : ObjectBase<UAtlUITriangle>
{
    public AtlUITriangle(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIBaseActor : ObjectBase<AUIBaseActor>
{
    public UIBaseActor(IntPtr pointer) : base(pointer) {}}

public unsafe class BasePartyPanel : ObjectBase<ABasePartyPanel>
{
    public BasePartyPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class BFL_UIPaint : ObjectBase<UBFL_UIPaint>
{
    public BFL_UIPaint(IntPtr pointer) : base(pointer) {}
    public void DrawTest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawTest"), @params);
    }
}

public unsafe class BFLAtlEvtCharacter : ObjectBase<UBFLAtlEvtCharacter>
{
    public BFLAtlEvtCharacter(IntPtr pointer) : base(pointer) {}
    public void TickLookAtEditorOnly(ACharacter* Character, bool bShowDebugLookAtTargetLocation, FVector LookAtFinalLocation)
    {
        Span<(string name, object value)> @params = [
            ("Character", (IntPtr)Character), 
            ("bShowDebugLookAtTargetLocation", bShowDebugLookAtTargetLocation), 
            ("LookAtFinalLocation", LookAtFinalLocation)
        ];
        ProcessEvent(GetFunction("TickLookAtEditorOnly"), @params);
    }
    public void PersonaCombineAdjust(AActor* PersonaActor)
    {
        Span<(string name, object value)> @params = [
            ("PersonaActor", (IntPtr)PersonaActor)
        ];
        ProcessEvent(GetFunction("PersonaCombineAdjust"), @params);
    }
    public void KoromaruAdjust(AActor* KoromaruActor)
    {
        Span<(string name, object value)> @params = [
            ("KoromaruActor", (IntPtr)KoromaruActor)
        ];
        ProcessEvent(GetFunction("KoromaruAdjust"), @params);
    }
    public void ConstructNPCCostume(ANpcBaseCore* NpcBaseCore, int AppNpcCharaCostumeIndex, int NpcIndexId, int HairId, int FaceID)
    {
        Span<(string name, object value)> @params = [
            ("NpcBaseCore", (IntPtr)NpcBaseCore), 
            ("AppNpcCharaCostumeIndex", AppNpcCharaCostumeIndex), 
            ("NpcIndexId", NpcIndexId), 
            ("HairId", HairId), 
            ("FaceID", FaceID)
        ];
        ProcessEvent(GetFunction("ConstructNPCCostume"), @params);
    }
    public void ConstructCostume(ACharacterBaseCore* CharacterBaseCore, EAppCharCategoryType AppCharaCategory, int AppCharaIndex, int AppCharaCostumeIndex)
    {
        Span<(string name, object value)> @params = [
            ("CharacterBaseCore", (IntPtr)CharacterBaseCore), 
            ("AppCharaCategory", AppCharaCategory), 
            ("AppCharaIndex", AppCharaIndex), 
            ("AppCharaCostumeIndex", AppCharaCostumeIndex)
        ];
        ProcessEvent(GetFunction("ConstructCostume"), @params);
    }
}

public unsafe class BFLAtlEvtHandwriting : ObjectBase<UBFLAtlEvtHandwriting>
{
    public BFLAtlEvtHandwriting(IntPtr pointer) : base(pointer) {}
    public UNiagaraComponent* SpawnHandwritingAttached(EAtlEvtHandwritingType Type, int LoopCount, float CameraOffset, ACharacter* AttachToCharacter, FName AttachPointName, FVector Location, FRotator Rotation, FVector Scale, EAttachLocation LocationType, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("LoopCount", LoopCount), 
            ("CameraOffset", CameraOffset), 
            ("AttachToCharacter", (IntPtr)AttachToCharacter), 
            ("AttachPointName", AttachPointName), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("Scale", Scale), 
            ("LocationType", LocationType), 
            ("bAutoDestroy", bAutoDestroy), 
            ("bAutoActivate", bAutoActivate), 
            ("PoolingMethod", PoolingMethod), 
            ("bPreCullCheck", bPreCullCheck)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAttached"), @params);
    }
    public UNiagaraComponent* SpawnHandwritingAtLocation(UObject* WorldContextObject, EAtlEvtHandwritingType Type, int LoopCount, float CameraOffset, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Type", Type), 
            ("LoopCount", LoopCount), 
            ("CameraOffset", CameraOffset), 
            ("Location", Location), 
            ("Rotation", Rotation), 
            ("Scale", Scale), 
            ("bAutoDestroy", bAutoDestroy), 
            ("bAutoActivate", bAutoActivate), 
            ("PoolingMethod", PoolingMethod), 
            ("bPreCullCheck", bPreCullCheck)
        ];
        return (UNiagaraComponent*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAtLocation"), @params);
    }
    public FName MakeHandwritingTypeName(EAtlEvtHandwritingType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<FName>(GetFunction("MakeHandwritingTypeName"), @params);
    }
    public FName MakeHandwritingTypeDefaultParamAssetPath(EAtlEvtHandwritingType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<FName>(GetFunction("MakeHandwritingTypeDefaultParamAssetPath"), @params);
    }
    public FName MakeHandwritingTypeCharaParamAssetPath(EAtlEvtHandwritingType Type, EAppCharCategoryType CharacterTypeCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("CharacterTypeCategoryType", CharacterTypeCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        return ProcessEvent<FName>(GetFunction("MakeHandwritingTypeCharaParamAssetPath"), @params);
    }
    public FName MakeHandwritingTypeAssetPath(EAtlEvtHandwritingType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<FName>(GetFunction("MakeHandwritingTypeAssetPath"), @params);
    }
}

public unsafe class AtlEvtPlayOnBindingActorObject : ObjectBase<AAtlEvtPlayOnBindingActorObject>
{
    public AtlEvtPlayOnBindingActorObject(IntPtr pointer) : base(pointer) {}
    public void OnLoadBindingLevelStreaming()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadBindingLevelStreaming"), @params);
    }
}

public unsafe class BFLAtlEvtTest : ObjectBase<UBFLAtlEvtTest>
{
    public BFLAtlEvtTest(IntPtr pointer) : base(pointer) {}
    public void EvtPlayOnBindingActor(UObject* WorldContextObject, FString EvtName, FString SublevelOnBindingActorName, ref FAtlEvtPlayParameter Param)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("EvtName", EvtName), 
            ("SublevelOnBindingActorName", SublevelOnBindingActorName), 
            ("Param", Param)
        ];
        ProcessEvent(GetFunction("EvtPlayOnBindingActor"), @params);
    }
}

public unsafe class BFLBtlAnimation : ObjectBase<UBFLBtlAnimation>
{
    public BFLBtlAnimation(IntPtr pointer) : base(pointer) {}
    public void StopMontageAnimation(USkeletalMeshComponent* InSkeletalMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent)
        ];
        ProcessEvent(GetFunction("StopMontageAnimation"), @params);
    }
    public void SetMontagePositionInSection(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimMontage* MontageToPlay, FName SectionName, float PositionInSection)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("MontageToPlay", (IntPtr)MontageToPlay), 
            ("SectionName", SectionName), 
            ("PositionInSection", PositionInSection)
        ];
        ProcessEvent(GetFunction("SetMontagePositionInSection"), @params);
    }
    public void SetMontageAnimationSpeed(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimMontage* MontageToPlay, float PlayRate)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("MontageToPlay", (IntPtr)MontageToPlay), 
            ("PlayRate", PlayRate)
        ];
        ProcessEvent(GetFunction("SetMontageAnimationSpeed"), @params);
    }
    public float GetRemainingTimeFromCurrentSection(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimMontage* AnimMontage)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("AnimMontage", (IntPtr)AnimMontage)
        ];
        return ProcessEvent<float>(GetFunction("GetRemainingTimeFromCurrentSection"), @params);
    }
    public float GetMontageSectionLength(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimMontage* AnimMontage, FName SectionName)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName)
        ];
        return ProcessEvent<float>(GetFunction("GetMontageSectionLength"), @params);
    }
    public bool GetMontageNextSectionName(UAnimMontage* AnimMontage, FName SectionName, ref FName NextSectionName)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName), 
            ("NextSectionName", NextSectionName)
        ];
        return ProcessEvent<bool>(GetFunction("GetMontageNextSectionName"), @params);
    }
    public bool GetMontageAlignedNextSectionName(UAnimMontage* AnimMontage, FName SectionName, ref FName NextSectionName)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName), 
            ("NextSectionName", NextSectionName)
        ];
        return ProcessEvent<bool>(GetFunction("GetMontageAlignedNextSectionName"), @params);
    }
    public FName GetCurrentSectionName(USkeletalMeshComponent* InSkeletalMeshComponent)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent)
        ];
        return ProcessEvent<FName>(GetFunction("GetCurrentSectionName"), @params);
    }
    public void ForcePoseUpdate(USkeletalMeshComponent* SkeletalMesh)
    {
        Span<(string name, object value)> @params = [
            ("SkeletalMesh", (IntPtr)SkeletalMesh)
        ];
        ProcessEvent(GetFunction("ForcePoseUpdate"), @params);
    }
    public void CoordinateDefaultAnimPose(USkeletalMeshComponent* InSkeletalMeshComponent, UAnimSequence* AnimSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSkeletalMeshComponent", (IntPtr)InSkeletalMeshComponent), 
            ("AnimSequence", (IntPtr)AnimSequence)
        ];
        ProcessEvent(GetFunction("CoordinateDefaultAnimPose"), @params);
    }
    public bool CheckMontageSectionIsLoop(UAnimMontage* AnimMontage, FName SectionName)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName)
        ];
        return ProcessEvent<bool>(GetFunction("CheckMontageSectionIsLoop"), @params);
    }
}

public unsafe class BFLBtlManager : ObjectBase<UBFLBtlManager>
{
    public BFLBtlManager(IntPtr pointer) : base(pointer) {}
    public void MarkAsBattleMainSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsBattleMainSetup"), @params);
    }
    public void MarkAsBattleCoreSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsBattleCoreSetup"), @params);
    }
    public void ClearBattleManagerSetupFlags()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearBattleManagerSetupFlags"), @params);
    }
    public bool CheckBattleMainLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleMainLoaded"), @params);
    }
    public bool CheckBattleCoreLoaded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleCoreLoaded"), @params);
    }
}

public unsafe class BFLEventMovieScene : ObjectBase<UBFLEventMovieScene>
{
    public BFLEventMovieScene(IntPtr pointer) : base(pointer) {}
    public void StopSlotAnimation(UAnimInstance* AnimInstance, float BlendOutTime, FName SlotNodeName)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("BlendOutTime", BlendOutTime), 
            ("SlotNodeName", SlotNodeName)
        ];
        ProcessEvent(GetFunction("StopSlotAnimation"), @params);
    }
    public USkeletalMeshComponent* SkeletalMeshComponentFromObject(UObject* InObject)
    {
        Span<(string name, object value)> @params = [
            ("InObject", (IntPtr)InObject)
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("SkeletalMeshComponentFromObject"), @params);
    }
    public void SetNearClipPlane(UObject* WorldContextObject, float NearClipCm)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("NearClipCm", NearClipCm)
        ];
        ProcessEvent(GetFunction("SetNearClipPlane"), @params);
    }
    public void SetEnableStreamingTexture(UObject* WorldContextObject, bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetEnableStreamingTexture"), @params);
    }
    public void ResetNearClipPlane(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        ProcessEvent(GetFunction("ResetNearClipPlane"), @params);
    }
    public UAnimMontage* PlaySlotOffsetAnimationAsDynamicMontageLoop(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float StartOffsetTime, float EndOffsetTime, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("StartOffsetTime", StartOffsetTime), 
            ("EndOffsetTime", EndOffsetTime), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotOffsetAnimationAsDynamicMontageLoop"), @params);
    }
    public UAnimMontage* PlaySlotMultiAnimationOffsetAsDynamicMontageTwo(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* BaseAnimAsset, UAnimSequenceBase* LoopAsset, FName SlotNodeName, float StartOffsetTime, float EndOffsetTime, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("BaseAnimAsset", (IntPtr)BaseAnimAsset), 
            ("LoopAsset", (IntPtr)LoopAsset), 
            ("SlotNodeName", SlotNodeName), 
            ("StartOffsetTime", StartOffsetTime), 
            ("EndOffsetTime", EndOffsetTime), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotMultiAnimationOffsetAsDynamicMontageTwo"), @params);
    }
    public UAnimMontage* PlaySlotMultiAnimationOffsetAsDynamicMontage(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* BaseAnimAsset, ref TArray<FAtlSlotMultiAnimationParam> AnimAssets, FName SlotNodeName, EEvtCharaAnimationType EvtCharaAnimationType, float StartOffsetTime, float EndOffsetTime, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("BaseAnimAsset", (IntPtr)BaseAnimAsset), 
            ("AnimAssets", AnimAssets), 
            ("SlotNodeName", SlotNodeName), 
            ("EvtCharaAnimationType", EvtCharaAnimationType), 
            ("StartOffsetTime", StartOffsetTime), 
            ("EndOffsetTime", EndOffsetTime), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotMultiAnimationOffsetAsDynamicMontage"), @params);
    }
    public UAnimMontage* PlaySlotMultiAnimationAsDynamicMontage(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* BaseAnimAsset, ref TArray<FAtlSlotMultiAnimationParam> AnimAssets, FName SlotNodeName, EEvtCharaAnimationType EvtCharaAnimationType, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("BaseAnimAsset", (IntPtr)BaseAnimAsset), 
            ("AnimAssets", AnimAssets), 
            ("SlotNodeName", SlotNodeName), 
            ("EvtCharaAnimationType", EvtCharaAnimationType), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotMultiAnimationAsDynamicMontage"), @params);
    }
    public UAnimMontage* PlaySlotAnimationAsDynamicMontageTwo(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* Asset, UAnimSequenceBase* Asset2, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("Asset2", (IntPtr)Asset2), 
            ("SlotNodeName", SlotNodeName), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotAnimationAsDynamicMontageTwo"), @params);
    }
    public UAnimMontage* PlaySlotAnimationAsDynamicMontageLoopSecOnLastFrame(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float StartOffsetTime, float EndOffsetTime, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("StartOffsetTime", StartOffsetTime), 
            ("EndOffsetTime", EndOffsetTime), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotAnimationAsDynamicMontageLoopSecOnLastFrame"), @params);
    }
    public UAnimMontage* PlaySlotAnimationAsDynamicMontageLoopOnLastFrame(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotAnimationAsDynamicMontageLoopOnLastFrame"), @params);
    }
    public UAnimMontage* PlaySlotAnimationAsDynamicMontageLoop(UAnimInstance* AnimInstance, USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("AnimInstance", (IntPtr)AnimInstance), 
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlaySlotAnimationAsDynamicMontageLoop"), @params);
    }
    public FName MakeSeasonSublevel(int FieldMajorID, int FieldMinorID, ECldSeason Season, bool bStreamingPath)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID), 
            ("Season", Season), 
            ("bStreamingPath", bStreamingPath)
        ];
        return ProcessEvent<FName>(GetFunction("MakeSeasonSublevel"), @params);
    }
    public void LoadSublevel(FString SublevelName)
    {
        Span<(string name, object value)> @params = [
            ("SublevelName", SublevelName)
        ];
        ProcessEvent(GetFunction("LoadSublevel"), @params);
    }
    public bool IsCondition(EEvtConditionalBranchCompType CompareType, int LHS, int RHS)
    {
        Span<(string name, object value)> @params = [
            ("CompareType", CompareType), 
            ("LHS", LHS), 
            ("RHS", RHS)
        ];
        return ProcessEvent<bool>(GetFunction("IsCondition"), @params);
    }
    public FMovieSceneObjectBindingID GetBindingID(ALevelSequenceActor* SequenceActor, FString ObjectDisplayName)
    {
        Span<(string name, object value)> @params = [
            ("SequenceActor", (IntPtr)SequenceActor), 
            ("ObjectDisplayName", ObjectDisplayName)
        ];
        return ProcessEvent<FMovieSceneObjectBindingID>(GetFunction("GetBindingID"), @params);
    }
    public FName GetAnimationSlotName(EEvtCharaAnimationSlotType SlotType)
    {
        Span<(string name, object value)> @params = [
            ("SlotType", SlotType)
        ];
        return ProcessEvent<FName>(GetFunction("GetAnimationSlotName"), @params);
    }
    public ALevelSequenceActor* FindLevelSequenceActor(ULevelStreaming* TargetLevelStreaming)
    {
        Span<(string name, object value)> @params = [
            ("TargetLevelStreaming", (IntPtr)TargetLevelStreaming)
        ];
        return (ALevelSequenceActor*)ProcessEvent<IntPtr>(GetFunction("FindLevelSequenceActor"), @params);
    }
    public AAtlEvtEventManager* FindAtlEvtEventManager(ULevelStreaming* TargetLevelStreaming)
    {
        Span<(string name, object value)> @params = [
            ("TargetLevelStreaming", (IntPtr)TargetLevelStreaming)
        ];
        return (AAtlEvtEventManager*)ProcessEvent<IntPtr>(GetFunction("FindAtlEvtEventManager"), @params);
    }
    public UAnimMontage* CreateSlotOffsetAnimationAsDynamicMontage(USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float StartOffsetTime, float EndOffsetTime, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("StartOffsetTime", StartOffsetTime), 
            ("EndOffsetTime", EndOffsetTime), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("CreateSlotOffsetAnimationAsDynamicMontage"), @params);
    }
    public UAnimMontage* CreateSlotAnimationAsDynamicMontage(USkeletalMesh* Mesh, UAnimSequenceBase* Asset, FName SlotNodeName, float BlendInTime, float BlendOutTime, float InPlayRate, int LoopCount, float BlendOutTriggerTime, float InTimeToStartMontageAt)
    {
        Span<(string name, object value)> @params = [
            ("Mesh", (IntPtr)Mesh), 
            ("Asset", (IntPtr)Asset), 
            ("SlotNodeName", SlotNodeName), 
            ("BlendInTime", BlendInTime), 
            ("BlendOutTime", BlendOutTime), 
            ("InPlayRate", InPlayRate), 
            ("LoopCount", LoopCount), 
            ("BlendOutTriggerTime", BlendOutTriggerTime), 
            ("InTimeToStartMontageAt", InTimeToStartMontageAt)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("CreateSlotAnimationAsDynamicMontage"), @params);
    }
    public int AllActorBinding(AActor* BindingActor, FString TargetName)
    {
        Span<(string name, object value)> @params = [
            ("BindingActor", (IntPtr)BindingActor), 
            ("TargetName", TargetName)
        ];
        return ProcessEvent<int>(GetFunction("AllActorBinding"), @params);
    }
    public void AddViewSlaveLocation(ref FVector Location, float BoostFactor, bool bOverrideLocation, float Duration)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location), 
            ("BoostFactor", BoostFactor), 
            ("bOverrideLocation", bOverrideLocation), 
            ("Duration", Duration)
        ];
        ProcessEvent(GetFunction("AddViewSlaveLocation"), @params);
    }
    public UAnimMontage* AddPlayEvtMultiMontageAnimNotify(int Index, UAnimMontage* NewMontage, ref TArray<FAtlSlotMultiAnimationParam> AnimAssets, FName SlotNodeName, EEvtCharaAnimationType EvtCharaAnimationType, float CurrentMontageBlendOut, float NextMontageBlendIn)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("NewMontage", (IntPtr)NewMontage), 
            ("AnimAssets", AnimAssets), 
            ("SlotNodeName", SlotNodeName), 
            ("EvtCharaAnimationType", EvtCharaAnimationType), 
            ("CurrentMontageBlendOut", CurrentMontageBlendOut), 
            ("NextMontageBlendIn", NextMontageBlendIn)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("AddPlayEvtMultiMontageAnimNotify"), @params);
    }
}

public unsafe class BPExtensionsFunctionLibrary : ObjectBase<UBPExtensionsFunctionLibrary>
{
    public BPExtensionsFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public void SetScreenPercentage(UPlanarReflectionComponent* inComponent, int inValue)
    {
        Span<(string name, object value)> @params = [
            ("inComponent", (IntPtr)inComponent), 
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetScreenPercentage"), @params);
    }
    public void RemoveRenderMesh(USkeletalMeshComponent* targetMesh)
    {
        Span<(string name, object value)> @params = [
            ("targetMesh", (IntPtr)targetMesh)
        ];
        ProcessEvent(GetFunction("RemoveRenderMesh"), @params);
    }
    public int GetScreenPercentage(UPlanarReflectionComponent* inComponent)
    {
        Span<(string name, object value)> @params = [
            ("inComponent", (IntPtr)inComponent)
        ];
        return ProcessEvent<int>(GetFunction("GetScreenPercentage"), @params);
    }
    public TArray<FLinearColor> GetInverseMatrix(ref FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform)
        ];
        return ProcessEvent<TArray<FLinearColor>>(GetFunction("GetInverseMatrix"), @params);
    }
    public void DetachSocketAttachment(UMeshComponent* Target, FName SocketName)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SocketName", SocketName)
        ];
        ProcessEvent(GetFunction("DetachSocketAttachment"), @params);
    }
    public void CommitConsoleLog(FString inString)
    {
        Span<(string name, object value)> @params = [
            ("inString", inString)
        ];
        ProcessEvent(GetFunction("CommitConsoleLog"), @params);
    }
    public void ChangeSkeletalMesh(USkeletalMeshComponent* targetMesh, USkeletalMesh* changeMesh)
    {
        Span<(string name, object value)> @params = [
            ("targetMesh", (IntPtr)targetMesh), 
            ("changeMesh", (IntPtr)changeMesh)
        ];
        ProcessEvent(GetFunction("ChangeSkeletalMesh"), @params);
    }
    public UMeshComponent* AttachStaticMesh(UMeshComponent* Target, FName SocketName, UStaticMesh* attachSTMesh)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SocketName", SocketName), 
            ("attachSTMesh", (IntPtr)attachSTMesh)
        ];
        return (UMeshComponent*)ProcessEvent<IntPtr>(GetFunction("AttachStaticMesh"), @params);
    }
    public UMeshComponent* AttachSkeletalMesh(UMeshComponent* Target, FName SocketName, USkeletalMesh* attachSKMesh)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SocketName", SocketName), 
            ("attachSKMesh", (IntPtr)attachSKMesh)
        ];
        return (UMeshComponent*)ProcessEvent<IntPtr>(GetFunction("AttachSkeletalMesh"), @params);
    }
    public void AttachMeshComponent(UMeshComponent* Target, FName SocketName, UMeshComponent* AttachComponent)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("SocketName", SocketName), 
            ("AttachComponent", (IntPtr)AttachComponent)
        ];
        ProcessEvent(GetFunction("AttachMeshComponent"), @params);
    }
}

public unsafe class BtlActionManagerComponent : ObjectBase<UBtlActionManagerComponent>
{
    public BtlActionManagerComponent(IntPtr pointer) : base(pointer) {}
    public void SetCommandWithTargets(ABtlActor* commander, EBtlCommandType Type, int ID, TArray<IntPtr> Targets)
    {
        Span<(string name, object value)> @params = [
            ("commander", (IntPtr)commander), 
            ("Type", Type), 
            ("ID", ID), 
            ("Targets", Targets)
        ];
        ProcessEvent(GetFunction("SetCommandWithTargets"), @params);
    }
    public void SetCommandTargets(TArray<IntPtr> Targets)
    {
        Span<(string name, object value)> @params = [
            ("Targets", Targets)
        ];
        ProcessEvent(GetFunction("SetCommandTargets"), @params);
    }
    public void SetCommander(ABtlActor* commander)
    {
        Span<(string name, object value)> @params = [
            ("commander", (IntPtr)commander)
        ];
        ProcessEvent(GetFunction("SetCommander"), @params);
    }
    public void SetCommand(ABtlActor* commander, EBtlCommandType Type, int ID)
    {
        Span<(string name, object value)> @params = [
            ("commander", (IntPtr)commander), 
            ("Type", Type), 
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SetCommand"), @params);
    }
    public void DoCommand()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoCommand"), @params);
    }
    public void ClearCommand()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearCommand"), @params);
    }
}

public unsafe class BtlActor : ObjectBase<ABtlActor>
{
    public BtlActor(IntPtr pointer) : base(pointer) {}
    public void UpdatePersonalAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UpdatePersonalAnimation"), @params);
    }
    public void TurnOffOrgia(bool Dead)
    {
        Span<(string name, object value)> @params = [
            ("Dead", Dead)
        ];
        ProcessEvent(GetFunction("TurnOffOrgia"), @params);
    }
    public void ToEndTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ToEndTurn"), @params);
    }
    public bool SyncSkillTimeline()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncSkillTimeline"), @params);
    }
    public bool SyncModelsForEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncModelsForEvent"), @params);
    }
    public bool SyncModelsForAlloutAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncModelsForAlloutAttack"), @params);
    }
    public void SummonGunTurnToTheurgiaMode()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SummonGunTurnToTheurgiaMode"), @params);
    }
    public void StopShakeAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopShakeAnim"), @params);
    }
    public void StartHoldup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartHoldup"), @params);
    }
    public void StartEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartEscape"), @params);
    }
    public void StandbyAction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StandbyAction"), @params);
    }
    public ABtlActor* SpawnSummonEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("SpawnSummonEnemy"), @params);
    }
    public void SpawnPersona(bool WithoutEmergeEffect)
    {
        Span<(string name, object value)> @params = [
            ("WithoutEmergeEffect", WithoutEmergeEffect)
        ];
        ProcessEvent(GetFunction("SpawnPersona"), @params);
    }
    public ABtlActor* SpawnFukaForTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("SpawnFukaForTheurgia"), @params);
    }
    public void SpawnCharacterBP(bool initialHiding)
    {
        Span<(string name, object value)> @params = [
            ("initialHiding", initialHiding)
        ];
        ProcessEvent(GetFunction("SpawnCharacterBP"), @params);
    }
    public TArray<IntPtr> SpawnAllSummonEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("SpawnAllSummonEnemy"), @params);
    }
    public void ShowFromHiding()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowFromHiding"), @params);
    }
    public void ShowActionName()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowActionName"), @params);
    }
    public void SetVisibleFromCode(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetVisibleFromCode"), @params);
    }
    public void SetupForEventMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetupForEventMode"), @params);
    }
    public void SetupConditionForAllyEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupConditionForAllyEscape"), @params);
    }
    public void SetStatusColor(FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("SetStatusColor"), @params);
    }
    public void SetPersonaWorldLocation(FTransform WorldTrans, int Index)
    {
        Span<(string name, object value)> @params = [
            ("WorldTrans", WorldTrans), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetPersonaWorldLocation"), @params);
    }
    public void SetPersonaLocation(FTransform RelativeTrans, int Index)
    {
        Span<(string name, object value)> @params = [
            ("RelativeTrans", RelativeTrans), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetPersonaLocation"), @params);
    }
    public void SetGuard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetGuard"), @params);
    }
    public void SetGeneralAttackResult(EBtlAlloutAttackResult Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetGeneralAttackResult"), @params);
    }
    public void SetEventMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetEventMode"), @params);
    }
    public void SetDisableUpdateFaceAnimFromBody(bool disable)
    {
        Span<(string name, object value)> @params = [
            ("disable", disable)
        ];
        ProcessEvent(GetFunction("SetDisableUpdateFaceAnimFromBody"), @params);
    }
    public void SetActiveMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetActiveMode"), @params);
    }
    public void SetActionID(int ActionID)
    {
        Span<(string name, object value)> @params = [
            ("ActionID", ActionID)
        ];
        ProcessEvent(GetFunction("SetActionID"), @params);
    }
    public USkeletalMeshComponent* SearchSkeletalMesh(UObject* InObject)
    {
        Span<(string name, object value)> @params = [
            ("InObject", (IntPtr)InObject)
        ];
        return (USkeletalMeshComponent*)ProcessEvent<IntPtr>(GetFunction("SearchSkeletalMesh"), @params);
    }
    public void RumbleEnemyEmerge()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RumbleEnemyEmerge"), @params);
    }
    public void RestoreModelsFromEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestoreModelsFromEvent"), @params);
    }
    public void RestoreModelsFromAlloutAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestoreModelsFromAlloutAttack"), @params);
    }
    public void ResetAlongWithRelocation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetAlongWithRelocation"), @params);
    }
    public void RequestPersonalAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestPersonalAnimation"), @params);
    }
    public void RequestHidePlayersForEspaceSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestHidePlayersForEspaceSkill"), @params);
    }
    public void RequestFaceAnimation(EAppCharFaceAnimID AnimType, bool UseBlendSetting, float Blend)
    {
        Span<(string name, object value)> @params = [
            ("AnimType", AnimType), 
            ("UseBlendSetting", UseBlendSetting), 
            ("Blend", Blend)
        ];
        ProcessEvent(GetFunction("RequestFaceAnimation"), @params);
    }
    public void RequestDamageAndDeadPerformance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestDamageAndDeadPerformance"), @params);
    }
    public void RequestAnimationWithNext(EBtlAnimationType AnimType, EBtlAnimationType animNextType)
    {
        Span<(string name, object value)> @params = [
            ("AnimType", AnimType), 
            ("animNextType", animNextType)
        ];
        ProcessEvent(GetFunction("RequestAnimationWithNext"), @params);
    }
    public void RequestAnimation(EBtlAnimationType AnimType, float startingPosition, bool UseBlendSetting, float Blend)
    {
        Span<(string name, object value)> @params = [
            ("AnimType", AnimType), 
            ("startingPosition", startingPosition), 
            ("UseBlendSetting", UseBlendSetting), 
            ("Blend", Blend)
        ];
        ProcessEvent(GetFunction("RequestAnimation"), @params);
    }
    public void RequestAddStatusEffect(EBtlBadStatusIcon Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("RequestAddStatusEffect"), @params);
    }
    public void RemoveEffectItem(EBtlBadStatusIcon Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("RemoveEffectItem"), @params);
    }
    public void ProcessBeforeCommandSelectStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcessBeforeCommandSelectStart"), @params);
    }
    public void ProcBeforeFadeinToAlloutAttackDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcBeforeFadeinToAlloutAttackDamage"), @params);
    }
    public void PreAffectSkillDamagePortion(float portionRatio)
    {
        Span<(string name, object value)> @params = [
            ("portionRatio", portionRatio)
        ];
        ProcessEvent(GetFunction("PreAffectSkillDamagePortion"), @params);
    }
    public void PlayWaitAnimation(float startingPosition, bool UseBlendSetting, float Blend, bool IgnoreWhenSamePose)
    {
        Span<(string name, object value)> @params = [
            ("startingPosition", startingPosition), 
            ("UseBlendSetting", UseBlendSetting), 
            ("Blend", Blend), 
            ("IgnoreWhenSamePose", IgnoreWhenSamePose)
        ];
        ProcessEvent(GetFunction("PlayWaitAnimation"), @params);
    }
    public void PlayVoiceTheurgia(int TypeIndex)
    {
        Span<(string name, object value)> @params = [
            ("TypeIndex", TypeIndex)
        ];
        ProcessEvent(GetFunction("PlayVoiceTheurgia"), @params);
    }
    public void PlayVoiceTakeoverStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceTakeoverStart"), @params);
    }
    public void PlayVoiceTakeoverReceive()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceTakeoverReceive"), @params);
    }
    public void PlayVoiceSkillShot()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceSkillShot"), @params);
    }
    public void PlayVoiceSkillChant()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceSkillChant"), @params);
    }
    public void PlayVoicePersonaSkillCutin(bool isFirstSummon)
    {
        Span<(string name, object value)> @params = [
            ("isFirstSummon", isFirstSummon)
        ];
        ProcessEvent(GetFunction("PlayVoicePersonaSkillCutin"), @params);
    }
    public void PlayVoicePersonaSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoicePersonaSkill"), @params);
    }
    public void PlayVoiceFirstSummonScene()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceFirstSummonScene"), @params);
    }
    public void PlayVoiceDead()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceDead"), @params);
    }
    public void PlayVoiceAlloutAttackStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceAlloutAttackStart"), @params);
    }
    public void PlayVoiceAlloutAttacking()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceAlloutAttacking"), @params);
    }
    public void PlayVoiceAlloutAttackFinishStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceAlloutAttackFinishStart"), @params);
    }
    public void PlayVoiceAlloutAttackFinishCut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayVoiceAlloutAttackFinishCut"), @params);
    }
    public void PlayShakeAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayShakeAnim"), @params);
    }
    public void PlayReflectionEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayReflectionEffect"), @params);
    }
    public void PlayEnemySummonEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayEnemySummonEffect"), @params);
    }
    public void PlayAbsorptionEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayAbsorptionEffect"), @params);
    }
    public void MarkReadyToDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkReadyToDestroy"), @params);
    }
    public void MarkAsPlayedStandbyCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsPlayedStandbyCamera"), @params);
    }
    public void MarkAsHidingPersonaForSkillScene()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsHidingPersonaForSkillScene"), @params);
    }
    public void MarkAsCalledFirstSummonScene()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsCalledFirstSummonScene"), @params);
    }
    public void MarkAsAvoidRelocationUntilTurnEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsAvoidRelocationUntilTurnEnd"), @params);
    }
    public void LoadModelsForEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadModelsForEvent"), @params);
    }
    public void LoadModelsForAlloutAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadModelsForAlloutAttack"), @params);
    }
    public void LoadFukaForTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadFukaForTheurgia"), @params);
    }
    public bool IsVelvet()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsVelvet"), @params);
    }
    public bool IsValidUnit()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsValidUnit"), @params);
    }
    public bool IsUsingSummonSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUsingSummonSkill"), @params);
    }
    public bool IsUsingOffensiveSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUsingOffensiveSkill"), @params);
    }
    public bool IsUsingGroupTargetSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUsingGroupTargetSkill"), @params);
    }
    public bool IsUsingDamageSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUsingDamageSkill"), @params);
    }
    public bool IsUsingAllTargetSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUsingAllTargetSkill"), @params);
    }
    public bool IsSummonedEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSummonedEnemy"), @params);
    }
    public bool IsStrega()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsStrega"), @params);
    }
    public bool IsSkillTrafuliEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillTrafuliEscape"), @params);
    }
    public bool IsSkillTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillTheurgia"), @params);
    }
    public bool IsSkillPhysicalType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillPhysicalType"), @params);
    }
    public bool IsSkillOrgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillOrgia"), @params);
    }
    public bool IsSkillMixraid()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillMixraid"), @params);
    }
    public bool IsSkillItemDumping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillItemDumping"), @params);
    }
    public bool IsSkillHit()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillHit"), @params);
    }
    public bool IsSkillFukaTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillFukaTheurgia"), @params);
    }
    public bool IsSkillEffective()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSkillEffective"), @params);
    }
    public bool IsRushAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsRushAttack"), @params);
    }
    public bool IsPossibleTakeoverTarget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPossibleTakeoverTarget"), @params);
    }
    public bool IsPossibleEventTarget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPossibleEventTarget"), @params);
    }
    public bool IsPossibleAlloutMember()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPossibleAlloutMember"), @params);
    }
    public bool IsPossibleAITarget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPossibleAITarget"), @params);
    }
    public bool IsPlayableDyingAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayableDyingAnim"), @params);
    }
    public bool IsPersonaEvolved()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPersonaEvolved"), @params);
    }
    public bool IsPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPersona"), @params);
    }
    public bool IsOrgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOrgia"), @params);
    }
    public bool IsOccurringSkillReflection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOccurringSkillReflection"), @params);
    }
    public bool IsOccurringSkillBlock()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOccurringSkillBlock"), @params);
    }
    public bool IsOccurringSkillAbsorption()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOccurringSkillAbsorption"), @params);
    }
    public bool IsNewBattleOutfitForAlloutFinish()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsNewBattleOutfitForAlloutFinish"), @params);
    }
    public bool IsNewBattleOutfit()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsNewBattleOutfit"), @params);
    }
    public bool IsManualOperation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsManualOperation"), @params);
    }
    public bool IsKoromaru()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsKoromaru"), @params);
    }
    public bool IsInTakeOver()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInTakeOver"), @params);
    }
    public bool IsInOneMore()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInOneMore"), @params);
    }
    public bool IsInActionTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInActionTurn"), @params);
    }
    public bool IsGuard()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsGuard"), @params);
    }
    public bool IsEnemyInParty()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnemyInParty"), @params);
    }
    public bool IsEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnemy"), @params);
    }
    public bool IsDyingBadStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDyingBadStatus"), @params);
    }
    public bool IsDying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDying"), @params);
    }
    public bool IsDown()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDown"), @params);
    }
    public bool IsDormancy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDormancy"), @params);
    }
    public bool IsDead()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDead"), @params);
    }
    public bool IsBoss()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBoss"), @params);
    }
    public bool IsAttackMiss()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAttackMiss"), @params);
    }
    public bool IsAttackHit()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAttackHit"), @params);
    }
    public bool IsAttackFailed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAttackFailed"), @params);
    }
    public bool IsAttackControlledByAI()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAttackControlledByAI"), @params);
    }
    public bool IsAnimationWait()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAnimationWait"), @params);
    }
    public bool IsAnimationChant()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAnimationChant"), @params);
    }
    public void InstantKill()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InstantKill"), @params);
    }
    public void HideForOtherAction(bool CriticalHindrance, bool Rapid, bool HalfMode)
    {
        Span<(string name, object value)> @params = [
            ("CriticalHindrance", CriticalHindrance), 
            ("Rapid", Rapid), 
            ("HalfMode", HalfMode)
        ];
        ProcessEvent(GetFunction("HideForOtherAction"), @params);
    }
    public int GetUID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetUID"), @params);
    }
    public UBtlTargetsManagerComponent* GetTargetsManager()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBtlTargetsManagerComponent*)ProcessEvent<IntPtr>(GetFunction("GetTargetsManager"), @params);
    }
    public int GetSummonEnemyID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSummonEnemyID"), @params);
    }
    public FTransform GetSocketTransformFromCpp(FName SocketName)
    {
        Span<(string name, object value)> @params = [
            ("SocketName", SocketName)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetSocketTransformFromCpp"), @params);
    }
    public FBtlBossAnimRequestParam GetSkillShotAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBtlBossAnimRequestParam>(GetFunction("GetSkillShotAnim"), @params);
    }
    public int GetSkillID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSkillID"), @params);
    }
    public FBtlBossAnimRequestParam GetSkillEndAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBtlBossAnimRequestParam>(GetFunction("GetSkillEndAnim"), @params);
    }
    public FBtlBossAnimRequestParam GetSkillChantAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBtlBossAnimRequestParam>(GetFunction("GetSkillChantAnim"), @params);
    }
    public EBtlSizeCategoryType GetSizeCategory()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlSizeCategoryType>(GetFunction("GetSizeCategory"), @params);
    }
    public float GetRecoveryWaitTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRecoveryWaitTime"), @params);
    }
    public FTransform GetPersonaTransformFromSkillCondition(ABtlActor* PersonaOwner)
    {
        Span<(string name, object value)> @params = [
            ("PersonaOwner", (IntPtr)PersonaOwner)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetPersonaTransformFromSkillCondition"), @params);
    }
    public FTransform GetPersonaTransform(bool ForCutin)
    {
        Span<(string name, object value)> @params = [
            ("ForCutin", ForCutin)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetPersonaTransform"), @params);
    }
    public ABtlActor* GetPersona(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetPersona"), @params);
    }
    public int GetOriginalID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetOriginalID"), @params);
    }
    public int GetItemID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetItemID"), @params);
    }
    public int GetId()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetId"), @params);
    }
    public FVector GetHomePosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetHomePosition"), @params);
    }
    public EBtlAlloutAttackResult GetGeneralAttackResult()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlAlloutAttackResult>(GetFunction("GetGeneralAttackResult"), @params);
    }
    public float GetExpireSupportWaitTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetExpireSupportWaitTime"), @params);
    }
    public EBtlBadStatusIcon GetCurrentStatusEffectType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlBadStatusIcon>(GetFunction("GetCurrentStatusEffectType"), @params);
    }
    public EBtlAnimationType GetCurrentAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlAnimationType>(GetFunction("GetCurrentAnimation"), @params);
    }
    public int GetCharacterID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCharacterID"), @params);
    }
    public UAppCharBaseComp* GetCharaBPFromCode()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAppCharBaseComp*)ProcessEvent<IntPtr>(GetFunction("GetCharaBPFromCode"), @params);
    }
    public FName GetBadStatusEffectName(EBtlBadStatusIcon Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<FName>(GetFunction("GetBadStatusEffectName"), @params);
    }
    public float GetBadStatusActionWaitTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetBadStatusActionWaitTime"), @params);
    }
    public EBtlAttackWeaponAnimType GetAttackWeaponAnimType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlAttackWeaponAnimType>(GetFunction("GetAttackWeaponAnimType"), @params);
    }
    public EBtlAttackType GetAttackType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlAttackType>(GetFunction("GetAttackType"), @params);
    }
    public EBtlAttackPerformanceType GetAttackPerformanceType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlAttackPerformanceType>(GetFunction("GetAttackPerformanceType"), @params);
    }
    public EBtlDataAttr GetAttackAttr()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlDataAttr>(GetFunction("GetAttackAttr"), @params);
    }
    public float GetAnimationBaseSpeedRatio()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAnimationBaseSpeedRatio"), @params);
    }
    public EBtlCommandType GetActionType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlCommandType>(GetFunction("GetActionType"), @params);
    }
    public TArray<IntPtr> GetActionTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetActionTargets"), @params);
    }
    public UBtlActionManagerComponent* GetActionManager()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBtlActionManagerComponent*)ProcessEvent<IntPtr>(GetFunction("GetActionManager"), @params);
    }
    public int GetActionID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetActionID"), @params);
    }
    public void EnemiesLookatThisCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EnemiesLookatThisCharacter"), @params);
    }
    public void EndWaitTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndWaitTurn"), @params);
    }
    public void DoSpecificActionTurnEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoSpecificActionTurnEnd"), @params);
    }
    public void DoSpecificActionAIEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoSpecificActionAIEnd"), @params);
    }
    public void DoSpecificActionActEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoSpecificActionActEnd"), @params);
    }
    public bool DoSpecificAction()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("DoSpecificAction"), @params);
    }
    public void DoNothing()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoNothing"), @params);
    }
    public void DoGeneralAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoGeneralAttack"), @params);
    }
    public void DoClearSupportStatus(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("DoClearSupportStatus"), @params);
    }
    public void DoBadStatusDamage(ref bool IsDamageOccurred)
    {
        Span<(string name, object value)> @params = [
            ("IsDamageOccurred", IsDamageOccurred)
        ];
        ProcessEvent(GetFunction("DoBadStatusDamage"), @params);
    }
    public void DoBadStatusAction(ref bool ActBadStatusSkillAction, ref bool NeedToWaitProcess, ref bool IsOverheatInterrupt)
    {
        Span<(string name, object value)> @params = [
            ("ActBadStatusSkillAction", ActBadStatusSkillAction), 
            ("NeedToWaitProcess", NeedToWaitProcess), 
            ("IsOverheatInterrupt", IsOverheatInterrupt)
        ];
        ProcessEvent(GetFunction("DoBadStatusAction"), @params);
    }
    public void DoAutoSkillRecovery(ref bool RecoveryValid)
    {
        Span<(string name, object value)> @params = [
            ("RecoveryValid", RecoveryValid)
        ];
        ProcessEvent(GetFunction("DoAutoSkillRecovery"), @params);
    }
    public void DestroyPersonaBeforeCreatePersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyPersonaBeforeCreatePersona"), @params);
    }
    public void DestroyPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyPersona"), @params);
    }
    public void DestroyFukaForTheurgia(ABtlActor* pFuka)
    {
        Span<(string name, object value)> @params = [
            ("pFuka", (IntPtr)pFuka)
        ];
        ProcessEvent(GetFunction("DestroyFukaForTheurgia"), @params);
    }
    public void DestroyEffect(UNiagaraComponent* pNiagara)
    {
        Span<(string name, object value)> @params = [
            ("pNiagara", (IntPtr)pNiagara)
        ];
        ProcessEvent(GetFunction("DestroyEffect"), @params);
    }
    public void CreateSummonEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateSummonEnemy"), @params);
    }
    public void CreatePersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreatePersona"), @params);
    }
    public void CoordinateSkillBPForSpecificSituations(ABtlSkill* Skill)
    {
        Span<(string name, object value)> @params = [
            ("Skill", (IntPtr)Skill)
        ];
        ProcessEvent(GetFunction("CoordinateSkillBPForSpecificSituations"), @params);
    }
    public FName ConvExAnimSectionName(ref bool Found, EBtlAnimationType Type, ref bool ForceShowWeapon, ref FBtlBossAnimRequestParam Params)
    {
        Span<(string name, object value)> @params = [
            ("Found", Found), 
            ("Type", Type), 
            ("ForceShowWeapon", ForceShowWeapon), 
            ("Params", Params)
        ];
        return ProcessEvent<FName>(GetFunction("ConvExAnimSectionName"), @params);
    }
    public void CleanupStatusEffect(bool Status, bool Down, bool keepSwoon)
    {
        Span<(string name, object value)> @params = [
            ("Status", Status), 
            ("Down", Down), 
            ("keepSwoon", keepSwoon)
        ];
        ProcessEvent(GetFunction("CleanupStatusEffect"), @params);
    }
    public bool CheckUsingTakeoverOtherCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckUsingTakeoverOtherCamera"), @params);
    }
    public bool CheckUseSkillShotSeqCam()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckUseSkillShotSeqCam"), @params);
    }
    public bool CheckTurnFromGuardCancel()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckTurnFromGuardCancel"), @params);
    }
    public bool CheckSkipTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkipTurn"), @params);
    }
    public bool CheckSkipSkillEndAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkipSkillEndAnim"), @params);
    }
    public bool CheckSkipSkillChantAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkipSkillChantAnim"), @params);
    }
    public bool CheckSkipAction()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkipAction"), @params);
    }
    public bool CheckSkillCameraCharacterHideDisable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkillCameraCharacterHideDisable"), @params);
    }
    public bool CheckShakingWhenDownDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckShakingWhenDownDamage"), @params);
    }
    public bool CheckRecoveryFromDown()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckRecoveryFromDown"), @params);
    }
    public bool CheckRecoveryFromBadStatus(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckRecoveryFromBadStatus"), @params);
    }
    public bool CheckReadyFukaForTheurgia(ABtlActor* pFuka)
    {
        Span<(string name, object value)> @params = [
            ("pFuka", (IntPtr)pFuka)
        ];
        return ProcessEvent<bool>(GetFunction("CheckReadyFukaForTheurgia"), @params);
    }
    public bool CheckReadyCharacterBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckReadyCharacterBP"), @params);
    }
    public bool CheckReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckReady"), @params);
    }
    public bool CheckProgressToHoldup()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckProgressToHoldup"), @params);
    }
    public bool CheckPriorConvExAnimSection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPriorConvExAnimSection"), @params);
    }
    public bool CheckPlayedStandbyCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayedStandbyCamera"), @params);
    }
    public bool CheckPlayableWaitAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayableWaitAnimation"), @params);
    }
    public bool CheckPlayableShortSkillSceneAfterCutin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayableShortSkillSceneAfterCutin"), @params);
    }
    public bool CheckPersonaValid()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaValid"), @params);
    }
    public bool CheckPersonaStartWithoutEmergePerformance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaStartWithoutEmergePerformance"), @params);
    }
    public bool CheckPersonaAlreadyChanged()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaAlreadyChanged"), @params);
    }
    public bool CheckNotSummonPersonaSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNotSummonPersonaSkill"), @params);
    }
    public bool CheckNeedToPlayPreSkillPorc()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNeedToPlayPreSkillPorc"), @params);
    }
    public bool CheckNeedToCallFirstSummonScene()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNeedToCallFirstSummonScene"), @params);
    }
    public bool CheckNeedOverheatScene()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNeedOverheatScene"), @params);
    }
    public bool CheckLookatEnable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckLookatEnable"), @params);
    }
    public bool CheckKeepDeadAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckKeepDeadAnimation"), @params);
    }
    public bool CheckInOverheatProc()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInOverheatProc"), @params);
    }
    public bool CheckInAlloutSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInAlloutSequence"), @params);
    }
    public bool CheckIdle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckIdle"), @params);
    }
    public bool CheckHidingPersonaForSkillScene()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHidingPersonaForSkillScene"), @params);
    }
    public bool CheckHiddingWeaponMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHiddingWeaponMode"), @params);
    }
    public bool CheckGuest()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckGuest"), @params);
    }
    public bool CheckGeneralAttackAnnihilation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckGeneralAttackAnnihilation"), @params);
    }
    public bool CheckExpireSupportStatus(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckExpireSupportStatus"), @params);
    }
    public bool CheckExistStatusEffectRequestList(EBtlBadStatusIcon RequestType)
    {
        Span<(string name, object value)> @params = [
            ("RequestType", RequestType)
        ];
        return ProcessEvent<bool>(GetFunction("CheckExistStatusEffectRequestList"), @params);
    }
    public bool CheckExistStatusEffect(EBtlBadStatusIcon Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("CheckExistStatusEffect"), @params);
    }
    public bool CheckEnableTranslucence()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableTranslucence"), @params);
    }
    public bool CheckEnableTheurgiaSkillUse()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableTheurgiaSkillUse"), @params);
    }
    public bool CheckEnableTakeover()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableTakeover"), @params);
    }
    public bool CheckEnableRotation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableRotation"), @params);
    }
    public bool CheckEnableDeadAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableDeadAnimation"), @params);
    }
    public bool CheckDownContinuedState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckDownContinuedState"), @params);
    }
    public bool CheckDisableUpdateFaceAnimFromBody()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckDisableUpdateFaceAnimFromBody"), @params);
    }
    public bool CheckCutinOccur()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckCutinOccur"), @params);
    }
    public bool CheckBadStatusEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBadStatusEscape"), @params);
    }
    public bool CheckBadStatusDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBadStatusDamage"), @params);
    }
    public bool CheckBadStatusAction()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBadStatusAction"), @params);
    }
    public bool CheckBackshotDisable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBackshotDisable"), @params);
    }
    public bool CheckAlreadyTakeover()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAlreadyTakeover"), @params);
    }
    public bool CheckAlive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAlive"), @params);
    }
    public bool CheckActiveMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckActiveMode"), @params);
    }
    public void CharacterDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CharacterDestroy"), @params);
    }
    public void CancelHoldup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CancelHoldup"), @params);
    }
    public FVector CalcClosedStandLocation(UBtlCoreComponent* pCore, ref FVector Pos, float standRange, bool coordinateFromEnemyCenter)
    {
        Span<(string name, object value)> @params = [
            ("pCore", (IntPtr)pCore), 
            ("Pos", Pos), 
            ("standRange", standRange), 
            ("coordinateFromEnemyCenter", coordinateFromEnemyCenter)
        ];
        return ProcessEvent<FVector>(GetFunction("CalcClosedStandLocation"), @params);
    }
    public void AffectSkillDamageRestPortion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectSkillDamageRestPortion"), @params);
    }
    public void AffectRecoveryFromEvent(float RecoveryHpRatio)
    {
        Span<(string name, object value)> @params = [
            ("RecoveryHpRatio", RecoveryHpRatio)
        ];
        ProcessEvent(GetFunction("AffectRecoveryFromEvent"), @params);
    }
    public void AffectRecoveryBadStatus(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("AffectRecoveryBadStatus"), @params);
    }
    public void AffectOverheat()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectOverheat"), @params);
    }
    public void AffectGeneralAttackDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectGeneralAttackDamage"), @params);
    }
    public void AffectGeneralAttackAnnihilation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectGeneralAttackAnnihilation"), @params);
    }
    public void AffectEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectEscape"), @params);
    }
    public void AdjustPersonaLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AdjustPersonaLocation"), @params);
    }
    public void AdjustHomePosition()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AdjustHomePosition"), @params);
    }
    public void AddTheurgiaGauge(EBtlTheurgiaBoostType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("AddTheurgiaGauge"), @params);
    }
    public void AddStatusEffectRequestList(EBtlBadStatusIcon RequestType)
    {
        Span<(string name, object value)> @params = [
            ("RequestType", RequestType)
        ];
        ProcessEvent(GetFunction("AddStatusEffectRequestList"), @params);
    }
    public void AddStatusEffect(UNiagaraComponent* comp, EBtlBadStatusIcon Type, AActor* ParentEmpActor)
    {
        Span<(string name, object value)> @params = [
            ("ref", (IntPtr)comp), 
            ("Type", Type), 
            ("ParentEmpActor", (IntPtr)ParentEmpActor)
        ];
        ProcessEvent(GetFunction("AddStatusEffect"), @params);
    }
    public void ActionReady(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("ActionReady"), @params);
    }
    public void ActionPrepareSkill(UBtlCoreComponent* BtlCore, ABtlSkill* Skill)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("Skill", (IntPtr)Skill)
        ];
        ProcessEvent(GetFunction("ActionPrepareSkill"), @params);
    }
    public void ActionPrepareAct(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("ActionPrepareAct"), @params);
    }
    public void ActionPlayTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ActionPlayTheurgia"), @params);
    }
    public void ActionPlaySkillTimeline()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ActionPlaySkillTimeline"), @params);
    }
}

public unsafe class BtlPersonaInterface : ObjectBase<IBtlPersonaInterface>
{
    public BtlPersonaInterface(IntPtr pointer) : base(pointer) {}
    public void SetPersonaOwner(ABtlActor* PersonaOwner)
    {
        Span<(string name, object value)> @params = [
            ("PersonaOwner", (IntPtr)PersonaOwner)
        ];
        ProcessEvent(GetFunction("SetPersonaOwner"), @params);
    }
    public FTransform GetPersonaTransformFromSkillCondition(ABtlActor* PersonaOwner)
    {
        Span<(string name, object value)> @params = [
            ("PersonaOwner", (IntPtr)PersonaOwner)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetPersonaTransformFromSkillCondition"), @params);
    }
}

public unsafe class BtlAegisInterface : ObjectBase<IBtlAegisInterface>
{
    public BtlAegisInterface(IntPtr pointer) : base(pointer) {}
    public void SetupOverheat(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetupOverheat"), @params);
    }
    public void SetupOrgiaWaitingEffect(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetupOrgiaWaitingEffect"), @params);
    }
    public void SetupOrgiaAttackEffect(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetupOrgiaAttackEffect"), @params);
    }
    public void SetupOrgia(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetupOrgia"), @params);
    }
    public void PlayOrgiaDeadEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayOrgiaDeadEffect"), @params);
    }
    public void ClearAllAegisEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearAllAegisEffect"), @params);
    }
}

public unsafe class BtlAiScriptWatcher : ObjectBase<ABtlAiScriptWatcher>
{
    public BtlAiScriptWatcher(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlAI : ObjectBase<ABtlAI>
{
    public BtlAI(IntPtr pointer) : base(pointer) {}
    public int GetPrevUseActionIDForActor(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetPrevUseActionIDForActor"), @params);
    }
}

public unsafe class BtlManualAI : ObjectBase<ABtlManualAI>
{
    public BtlManualAI(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlScriptAI : ObjectBase<ABtlScriptAI>
{
    public BtlScriptAI(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlAIManagerComponent : ObjectBase<UBtlAIManagerComponent>
{
    public BtlAIManagerComponent(IntPtr pointer) : base(pointer) {}
    public void DetermineAIAction(UBtlActionManagerComponent* ActionManager, ABtlActor* commander)
    {
        Span<(string name, object value)> @params = [
            ("ActionManager", (IntPtr)ActionManager), 
            ("commander", (IntPtr)commander)
        ];
        ProcessEvent(GetFunction("DetermineAIAction"), @params);
    }
}

public unsafe class BtlBCDCharaCameraComponent : ObjectBase<UBtlBCDCharaCameraComponent>
{
    public BtlBCDCharaCameraComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlBCDMoveCameraComponent : ObjectBase<UBtlBCDMoveCameraComponent>
{
    public BtlBCDMoveCameraComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlBoss : ObjectBase<UBtlBoss>
{
    public BtlBoss(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlBossChariot : ObjectBase<UBtlBossChariot>
{
    public BtlBossChariot(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossElizabeth : ObjectBase<UBtlBossElizabeth>
{
    public BtlBossElizabeth(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossEmperor : ObjectBase<UBtlBossEmperor>
{
    public BtlBossEmperor(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossEmperorInterface : ObjectBase<IBtlBossEmperorInterface>
{
    public BtlBossEmperorInterface(IntPtr pointer) : base(pointer) {}
    public void StandingAlwaysWithPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StandingAlwaysWithPersona"), @params);
    }
}

public unsafe class BtlBossFortune : ObjectBase<UBtlBossFortune>
{
    public BtlBossFortune(IntPtr pointer) : base(pointer) {}
    public void ProcAfterReturnRoulette()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcAfterReturnRoulette"), @params);
    }
}

public unsafe class BtlBossFortuneInterface : ObjectBase<IBtlBossFortuneInterface>
{
    public BtlBossFortuneInterface(IntPtr pointer) : base(pointer) {}
    public void StrengthFlowerLoopEffectFadeout(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("StrengthFlowerLoopEffectFadeout"), @params);
    }
    public void FortuneFlowerLoopEffectFadeout(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FortuneFlowerLoopEffectFadeout"), @params);
    }
    public void FortuneFlowerLoopEffectFadein(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FortuneFlowerLoopEffectFadein"), @params);
    }
    public void FortuneFadeout(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FortuneFadeout"), @params);
    }
    public void FortuneFadein(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FortuneFadein"), @params);
    }
}

public unsafe class BtlBossHangedMan : ObjectBase<UBtlBossHangedMan>
{
    public BtlBossHangedMan(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossHangedManInterface : ObjectBase<IBtlBossHangedManInterface>
{
    public BtlBossHangedManInterface(IntPtr pointer) : base(pointer) {}
    public void FadeoutStatueEffect(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FadeoutStatueEffect"), @params);
    }
    public void FadeoutHangedManEffect(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FadeoutHangedManEffect"), @params);
    }
    public void FadeinHangedManEffect(float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("FadeinHangedManEffect"), @params);
    }
}

public unsafe class BtlBossHermit : ObjectBase<UBtlBossHermit>
{
    public BtlBossHermit(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossHermitInterface : ObjectBase<IBtlBossHermitInterface>
{
    public BtlBossHermitInterface(IntPtr pointer) : base(pointer) {}
    public void SetVisibleChargeStartEffect(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetVisibleChargeStartEffect"), @params);
    }
    public void SetVisibleChargeEffectFromLevel(bool Visible, int Level)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible), 
            ("Level", Level)
        ];
        ProcessEvent(GetFunction("SetVisibleChargeEffectFromLevel"), @params);
    }
    public void SetVisibleChargeEffect(bool Visible, bool StrongEffect)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible), 
            ("StrongEffect", StrongEffect)
        ];
        ProcessEvent(GetFunction("SetVisibleChargeEffect"), @params);
    }
}

public unsafe class BtlBossHierophant : ObjectBase<UBtlBossHierophant>
{
    public BtlBossHierophant(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossLovers : ObjectBase<UBtlBossLovers>
{
    public BtlBossLovers(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossMagician : ObjectBase<UBtlBossMagician>
{
    public BtlBossMagician(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossNyxAvatar : ObjectBase<UBtlBossNyxAvatar>
{
    public BtlBossNyxAvatar(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossNyxAvatarInterface : ObjectBase<IBtlBossNyxAvatarInterface>
{
    public BtlBossNyxAvatarInterface(IntPtr pointer) : base(pointer) {}
    public void SetVisibleWeaponEffect(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetVisibleWeaponEffect"), @params);
    }
    public void PlayFeatherAnim(float AnimSeconds)
    {
        Span<(string name, object value)> @params = [
            ("AnimSeconds", AnimSeconds)
        ];
        ProcessEvent(GetFunction("PlayFeatherAnim"), @params);
    }
    public void FadeoutWeaponEffect(float AnimSeconds)
    {
        Span<(string name, object value)> @params = [
            ("AnimSeconds", AnimSeconds)
        ];
        ProcessEvent(GetFunction("FadeoutWeaponEffect"), @params);
    }
    public void FadeoutFeatherAnim(float AnimSeconds)
    {
        Span<(string name, object value)> @params = [
            ("AnimSeconds", AnimSeconds)
        ];
        ProcessEvent(GetFunction("FadeoutFeatherAnim"), @params);
    }
}

public unsafe class BtlBossNyxCore : ObjectBase<UBtlBossNyxCore>
{
    public BtlBossNyxCore(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossNyxCoreInterface : ObjectBase<IBtlBossNyxCoreInterface>
{
    public BtlBossNyxCoreInterface(IntPtr pointer) : base(pointer) {}
    public void LoadHeroAnimationForNyxCore()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadHeroAnimationForNyxCore"), @params);
    }
}

public unsafe class BtlBossPriestess : ObjectBase<UBtlBossPriestess>
{
    public BtlBossPriestess(IntPtr pointer) : base(pointer) {}
    public void TimeoverEventEndCallback()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("TimeoverEventEndCallback"), @params);
    }
}

public unsafe class BtlBossStregaBase : ObjectBase<UBtlBossStregaBase>
{
    public BtlBossStregaBase(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaJin : ObjectBase<UBtlBossStregaJin>
{
    public BtlBossStregaJin(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaTakaya : ObjectBase<UBtlBossStregaTakaya>
{
    public BtlBossStregaTakaya(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaTakayaJin : ObjectBase<UBtlBossStregaTakayaJin>
{
    public BtlBossStregaTakayaJin(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaChidori : ObjectBase<UBtlBossStregaChidori>
{
    public BtlBossStregaChidori(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaInterface : ObjectBase<IBtlBossStregaInterface>
{
    public BtlBossStregaInterface(IntPtr pointer) : base(pointer) {}
    public void SetTakayaTheurgiaMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetTakayaTheurgiaMode"), @params);
    }
    public void PlayJinDrugLoopEffect(bool isFadeIn, float FadeTime)
    {
        Span<(string name, object value)> @params = [
            ("isFadeIn", isFadeIn), 
            ("FadeTime", FadeTime)
        ];
        ProcessEvent(GetFunction("PlayJinDrugLoopEffect"), @params);
    }
}

public unsafe class BtlBossStregaTakayaJoined : ObjectBase<UBtlBossStregaTakayaJoined>
{
    public BtlBossStregaTakayaJoined(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlCalcBase : ObjectBase<ABtlCalcBase>
{
    public BtlCalcBase(IntPtr pointer) : base(pointer) {}
    public float RecoveryRatioFromUPSET()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("RecoveryRatioFromUPSET"), @params);
    }
    public float RecoveryRatioFromPANIC()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("RecoveryRatioFromPANIC"), @params);
    }
    public float RecoveryRatioFromFEAR()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("RecoveryRatioFromFEAR"), @params);
    }
    public float RecoveryRatioFromCHARM()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("RecoveryRatioFromCHARM"), @params);
    }
    public float RecoveryRatioFromANGER()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("RecoveryRatioFromANGER"), @params);
    }
    public int GetSpeedSupportRatio(bool isPlayer, int Point)
    {
        Span<(string name, object value)> @params = [
            ("isPlayer", isPlayer), 
            ("Point", Point)
        ];
        return ProcessEvent<int>(GetFunction("GetSpeedSupportRatio"), @params);
    }
    public int GetShuffleTimeOccurPercent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetShuffleTimeOccurPercent"), @params);
    }
    public float GetShuffleTimeMajorPercent(int EncountNumFromLastMajor)
    {
        Span<(string name, object value)> @params = [
            ("EncountNumFromLastMajor", EncountNumFromLastMajor)
        ];
        return ProcessEvent<float>(GetFunction("GetShuffleTimeMajorPercent"), @params);
    }
    public float GetSaleMerchMoneyRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSaleMerchMoneyRate"), @params);
    }
    public float GetPlayerWeakDamageRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayerWeakDamageRate"), @params);
    }
    public float GetPlayerCriticalDamageRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayerCriticalDamageRate"), @params);
    }
    public float GetParam(EBtlCalcParamType Type, int Param)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Param", Param)
        ];
        return ProcessEvent<float>(GetFunction("GetParam"), @params);
    }
    public float GetNewmoonSkillPowerRatio(int MoonAge)
    {
        Span<(string name, object value)> @params = [
            ("MoonAge", MoonAge)
        ];
        return ProcessEvent<float>(GetFunction("GetNewmoonSkillPowerRatio"), @params);
    }
    public float GetMoneyRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMoneyRate"), @params);
    }
    public int GetMagicBonusRecovery(int MagicAttacker)
    {
        Span<(string name, object value)> @params = [
            ("MagicAttacker", MagicAttacker)
        ];
        return ProcessEvent<int>(GetFunction("GetMagicBonusRecovery"), @params);
    }
    public int GetMagicBonusDamage(int MagicAttacker)
    {
        Span<(string name, object value)> @params = [
            ("MagicAttacker", MagicAttacker)
        ];
        return ProcessEvent<int>(GetFunction("GetMagicBonusDamage"), @params);
    }
    public float GetLevelExpRatio(int LevelDifference)
    {
        Span<(string name, object value)> @params = [
            ("LevelDifference", LevelDifference)
        ];
        return ProcessEvent<float>(GetFunction("GetLevelExpRatio"), @params);
    }
    public float GetLevelDamageRatio(int LevelAttacker, int LevelTarget)
    {
        Span<(string name, object value)> @params = [
            ("LevelAttacker", LevelAttacker), 
            ("LevelTarget", LevelTarget)
        ];
        return ProcessEvent<float>(GetFunction("GetLevelDamageRatio"), @params);
    }
    public float GetLevelDamageBossRatio(int LevelAttacker, int LevelTarget)
    {
        Span<(string name, object value)> @params = [
            ("LevelAttacker", LevelAttacker), 
            ("LevelTarget", LevelTarget)
        ];
        return ProcessEvent<float>(GetFunction("GetLevelDamageBossRatio"), @params);
    }
    public float GetLevelAccuracyRatio(int LevelAttacker, int LevelTarget)
    {
        Span<(string name, object value)> @params = [
            ("LevelAttacker", LevelAttacker), 
            ("LevelTarget", LevelTarget)
        ];
        return ProcessEvent<float>(GetFunction("GetLevelAccuracyRatio"), @params);
    }
    public float GetFullmoonSkillPowerRatio(int MoonAge)
    {
        Span<(string name, object value)> @params = [
            ("MoonAge", MoonAge)
        ];
        return ProcessEvent<float>(GetFunction("GetFullmoonSkillPowerRatio"), @params);
    }
    public float GetExpRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetExpRate"), @params);
    }
    public float GetEnemyWeakDamageRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEnemyWeakDamageRate"), @params);
    }
    public float GetEnemyCriticalDamageRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEnemyCriticalDamageRate"), @params);
    }
    public int GetDownAgilityForEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDownAgilityForEnemy"), @params);
    }
    public EBtlGameDifficulty GetDifficulty()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlGameDifficulty>(GetFunction("GetDifficulty"), @params);
    }
    public int GetDefenseSupportRatio(bool isPlayer, int Point)
    {
        Span<(string name, object value)> @params = [
            ("isPlayer", isPlayer), 
            ("Point", Point)
        ];
        return ProcessEvent<int>(GetFunction("GetDefenseSupportRatio"), @params);
    }
    public float GetDamageRateToPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDamageRateToPlayer"), @params);
    }
    public float GetDamageRateToEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDamageRateToEnemy"), @params);
    }
    public int GetAttackSupportRatio(bool isPlayer, int Point)
    {
        Span<(string name, object value)> @params = [
            ("isPlayer", isPlayer), 
            ("Point", Point)
        ];
        return ProcessEvent<int>(GetFunction("GetAttackSupportRatio"), @params);
    }
    public float GetAllOutAttackSwoonRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAllOutAttackSwoonRate"), @params);
    }
    public float DamageRatioByUPSET()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("DamageRatioByUPSET"), @params);
    }
    public float DamageRatioByOVERLIMIT()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("DamageRatioByOVERLIMIT"), @params);
    }
    public float DamageRatioByOVERHEAT()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("DamageRatioByOVERHEAT"), @params);
    }
    public float DamageRatioByANGER()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("DamageRatioByANGER"), @params);
    }
    public bool CheckTargetIsEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckTargetIsEnemy"), @params);
    }
    public bool CheckSkillIsAttack()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSkillIsAttack"), @params);
    }
    public bool CheckAttackerIsEnemy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAttackerIsEnemy"), @params);
    }
    public float CalcTheurgiaSkillDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcTheurgiaSkillDamage"), @params);
    }
    public float CalcRushDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcRushDamage"), @params);
    }
    public float CalcPhysicalDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcPhysicalDamage"), @params);
    }
    public float CalcMagicDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcMagicDamage"), @params);
    }
    public float CalcHealRecovery()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcHealRecovery"), @params);
    }
    public float CalcExpPersonaLevelUp(float Level, float DefaultLevel)
    {
        Span<(string name, object value)> @params = [
            ("Level", Level), 
            ("DefaultLevel", DefaultLevel)
        ];
        return ProcessEvent<float>(GetFunction("CalcExpPersonaLevelUp"), @params);
    }
    public float CalcEscapeRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcEscapeRate"), @params);
    }
    public float CalcDownRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcDownRate"), @params);
    }
    public float CalcCriticalHitRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcCriticalHitRate"), @params);
    }
    public float CalcBadStatusRecoveryRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcBadStatusRecoveryRate"), @params);
    }
    public float CalcBadStatusHitRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcBadStatusHitRate"), @params);
    }
    public float CalcAllOutAttackDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcAllOutAttackDamage"), @params);
    }
    public float CalcAccuracyRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("CalcAccuracyRate"), @params);
    }
    public float AttackRatioByUPSET()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("AttackRatioByUPSET"), @params);
    }
    public float AttackRatioByOVERLIMIT()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("AttackRatioByOVERLIMIT"), @params);
    }
    public float AttackRatioByANGER()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("AttackRatioByANGER"), @params);
    }
}

public unsafe class BtlFormula : ObjectBase<ABtlFormula>
{
    public BtlFormula(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlCamera : ObjectBase<ABtlCamera>
{
    public BtlCamera(IntPtr pointer) : base(pointer) {}
    public void SetCameraTargets(TArray<IntPtr> Targets)
    {
        Span<(string name, object value)> @params = [
            ("Targets", Targets)
        ];
        ProcessEvent(GetFunction("SetCameraTargets"), @params);
    }
    public void SetCameraMainCharacter(ABtlActor* cameraMainCharacter)
    {
        Span<(string name, object value)> @params = [
            ("cameraMainCharacter", (IntPtr)cameraMainCharacter)
        ];
        ProcessEvent(GetFunction("SetCameraMainCharacter"), @params);
    }
    public TArray<IntPtr> GetCameraTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetCameraTargets"), @params);
    }
    public ABtlActor* GetCameraMainCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetCameraMainCharacter"), @params);
    }
}

public unsafe class BtlCompensation : ObjectBase<UBtlCompensation>
{
    public BtlCompensation(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlCoreComponent : ObjectBase<UBtlCoreComponent>
{
    public BtlCoreComponent(IntPtr pointer) : base(pointer) {}
    public void ToggleSkillEditMode()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ToggleSkillEditMode"), @params);
    }
    public void TheurgiaDebugSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("TheurgiaDebugSetup"), @params);
    }
    public bool SyncReadyIndependentBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncReadyIndependentBattle"), @params);
    }
    public bool SyncInfoGameover()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncInfoGameover"), @params);
    }
    public void SpawnCharacters(bool initialHiding)
    {
        Span<(string name, object value)> @params = [
            ("initialHiding", initialHiding)
        ];
        ProcessEvent(GetFunction("SpawnCharacters"), @params);
    }
    public void ShowDebugData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowDebugData"), @params);
    }
    public FBtlEncountParam SetupIndependentBattle(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        return ProcessEvent<FBtlEncountParam>(GetFunction("SetupIndependentBattle"), @params);
    }
    public void SetupDebugKill(ref bool RejectDebugKillRequest)
    {
        Span<(string name, object value)> @params = [
            ("RejectDebugKillRequest", RejectDebugKillRequest)
        ];
        ProcessEvent(GetFunction("SetupDebugKill"), @params);
    }
    public void SetRushMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetRushMode"), @params);
    }
    public void SetRushDisable(bool disable)
    {
        Span<(string name, object value)> @params = [
            ("disable", disable)
        ];
        ProcessEvent(GetFunction("SetRushDisable"), @params);
    }
    public void SetPhase(ABtlPhase* NextPhase)
    {
        Span<(string name, object value)> @params = [
            ("NextPhase", (IntPtr)NextPhase)
        ];
        ProcessEvent(GetFunction("SetPhase"), @params);
    }
    public void SetPersonaStatusMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetPersonaStatusMode"), @params);
    }
    public void SetEncountParam(FBtlEncountParam Encount)
    {
        Span<(string name, object value)> @params = [
            ("Encount", Encount)
        ];
        ProcessEvent(GetFunction("SetEncountParam"), @params);
    }
    public void SetDebugStateString(FString str)
    {
        Span<(string name, object value)> @params = [
            ("str", str)
        ];
        ProcessEvent(GetFunction("SetDebugStateString"), @params);
    }
    public void SetDebugLatestCamera(FString str)
    {
        Span<(string name, object value)> @params = [
            ("str", str)
        ];
        ProcessEvent(GetFunction("SetDebugLatestCamera"), @params);
    }
    public void SetBGMTheurgiaMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetBGMTheurgiaMode"), @params);
    }
    public void SetBattleTimeDilation(float Rate)
    {
        Span<(string name, object value)> @params = [
            ("Rate", Rate)
        ];
        ProcessEvent(GetFunction("SetBattleTimeDilation"), @params);
    }
    public void SetAnalyzeMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetAnalyzeMode"), @params);
    }
    public void RestoreGameCondition()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestoreGameCondition"), @params);
    }
    public void RequestSummonEnemies()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestSummonEnemies"), @params);
    }
    public void RequestSituationHelp(ABtlActor* pEmploy, EBtlJyokyohelpType Type)
    {
        Span<(string name, object value)> @params = [
            ("pEmploy", (IntPtr)pEmploy), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("RequestSituationHelp"), @params);
    }
    public void RequestRushMode(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("RequestRushMode"), @params);
    }
    public void RequestPartyPanelVisible(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("RequestPartyPanelVisible"), @params);
    }
    public bool RequestEncountProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("RequestEncountProcess"), @params);
    }
    public void RequestCutinAging(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("RequestCutinAging"), @params);
    }
    public void RequestClearUtensilEffectWithRelocation()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestClearUtensilEffectWithRelocation"), @params);
    }
    public void RequestBGM(EBtlBGMType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("RequestBGM"), @params);
    }
    public void RemoveUtensilEffect(AAppActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        ProcessEvent(GetFunction("RemoveUtensilEffect"), @params);
    }
    public void RelocationRequestOnBCDPlay(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("RelocationRequestOnBCDPlay"), @params);
    }
    public void RelocationCustom(EBtlRelocationType Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("RelocationCustom"), @params);
    }
    public void Relocation(bool PlayerOnly)
    {
        Span<(string name, object value)> @params = [
            ("PlayerOnly", PlayerOnly)
        ];
        ProcessEvent(GetFunction("Relocation"), @params);
    }
    public void RegisterTakeoverCharacter(ABtlActor* Target, ABtlActor* takeoverFrom)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("takeoverFrom", (IntPtr)takeoverFrom)
        ];
        ProcessEvent(GetFunction("RegisterTakeoverCharacter"), @params);
    }
    public void ProgressOrder()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProgressOrder"), @params);
    }
    public void ProcessBeforeStartNextTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcessBeforeStartNextTurn"), @params);
    }
    public void ProcBeforeLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcBeforeLoad"), @params);
    }
    public void ProcAheadOfRetrySequence()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcAheadOfRetrySequence"), @params);
    }
    public void ProcAfterLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcAfterLoad"), @params);
    }
    public void ProcAfterAllCharacterSpawned()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcAfterAllCharacterSpawned"), @params);
    }
    public void PlayInfoGameover()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayInfoGameover"), @params);
    }
    public void PlayInfoFukaCutin()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayInfoFukaCutin"), @params);
    }
    public void PlayInfoAlloutAttackSuggestion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayInfoAlloutAttackSuggestion"), @params);
    }
    public void PlayHighAnalyzeEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayHighAnalyzeEvent"), @params);
    }
    public void MarkAsUICommand()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsUICommand"), @params);
    }
    public void MarkAsPlayedShadowExChantCam()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsPlayedShadowExChantCam"), @params);
    }
    public void MarkAsPlayedFukaCutin()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsPlayedFukaCutin"), @params);
    }
    public void LoadResidentData(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        ProcessEvent(GetFunction("LoadResidentData"), @params);
    }
    public void LoadEnemyData(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        ProcessEvent(GetFunction("LoadEnemyData"), @params);
    }
    public void LoadDataForSerialEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadDataForSerialEncount"), @params);
    }
    public void LoadData(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        ProcessEvent(GetFunction("LoadData"), @params);
    }
    public bool IsNeedToFinale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsNeedToFinale"), @params);
    }
    public bool IsEventResult(ref bool IsCaptureResult)
    {
        Span<(string name, object value)> @params = [
            ("IsCaptureResult", IsCaptureResult)
        ];
        return ProcessEvent<bool>(GetFunction("IsEventResult"), @params);
    }
    public bool IsEventBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEventBattle"), @params);
    }
    public bool IsDisableSequenceCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDisableSequenceCamera"), @params);
    }
    public void InitProcessBeforeFirstTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitProcessBeforeFirstTurn"), @params);
    }
    public void InitializeOrder()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitializeOrder"), @params);
    }
    public void InitializeBattleForNextBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitializeBattleForNextBattle"), @params);
    }
    public void InitializeBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitializeBattle"), @params);
    }
    public ABtlActor* GetResultMainPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetResultMainPlayer"), @params);
    }
    public TArray<IntPtr> GetPlayerList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetPlayerList"), @params);
    }
    public EBtlPhaseType GetPhaseType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlPhaseType>(GetFunction("GetPhaseType"), @params);
    }
    public ABtlPhase* GetPhase()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlPhase*)ProcessEvent<IntPtr>(GetFunction("GetPhase"), @params);
    }
    public ABtlActor* GetNextAction(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetNextAction"), @params);
    }
    public ABtlActor* GetHero()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetHero"), @params);
    }
    public ABtlActor* GetEventMainAction()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetEventMainAction"), @params);
    }
    public TArray<IntPtr> GetEnemyList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetEnemyList"), @params);
    }
    public FString GetEnemyFormationName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetEnemyFormationName"), @params);
    }
    public FBtlEncountParam GetEncountParamForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBtlEncountParam>(GetFunction("GetEncountParamForBP"), @params);
    }
    public float GetElapsedTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetElapsedTime"), @params);
    }
    public float GetDeltaTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDeltaTime"), @params);
    }
    public FString GetDebugStateString()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugStateString"), @params);
    }
    public FString GetDebugModeName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugModeName"), @params);
    }
    public FString GetDebugLatestCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugLatestCamera"), @params);
    }
    public int GetDebugCalcFlag()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDebugCalcFlag"), @params);
    }
    public UDataTable* GetBossCameraTable()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UDataTable*)ProcessEvent<IntPtr>(GetFunction("GetBossCameraTable"), @params);
    }
    public TArray<IntPtr> GetAllCharacterList()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllCharacterList"), @params);
    }
    public ABtlActor* GetAction()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetAction"), @params);
    }
    public void FinishLoadingRecord(EBtlLoadingTimeCategory Category)
    {
        Span<(string name, object value)> @params = [
            ("Category", Category)
        ];
        ProcessEvent(GetFunction("FinishLoadingRecord"), @params);
    }
    public void FinalProcessAfterGameover()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinalProcessAfterGameover"), @params);
    }
    public void FinalizeActionTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinalizeActionTurn"), @params);
    }
    public void FadeoutBGM(int FadeFrame)
    {
        Span<(string name, object value)> @params = [
            ("FadeFrame", FadeFrame)
        ];
        ProcessEvent(GetFunction("FadeoutBGM"), @params);
    }
    public void DoInterruptProcessEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DoInterruptProcessEscape"), @params);
    }
    public void DestroyAllBattleActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyAllBattleActor"), @params);
    }
    public void DeleteCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeleteCapture"), @params);
    }
    public void DebugSetCustomDamage(int Damage)
    {
        Span<(string name, object value)> @params = [
            ("Damage", Damage)
        ];
        ProcessEvent(GetFunction("DebugSetCustomDamage"), @params);
    }
    public int DebugGetCustomDamage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("DebugGetCustomDamage"), @params);
    }
    public void DebugAllCharacterToDying()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugAllCharacterToDying"), @params);
    }
    public void DebugAllCharacterToDown()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugAllCharacterToDown"), @params);
    }
    public FBtlEncountParam CoordinateEncountParam(FBtlEncountParam Encount)
    {
        Span<(string name, object value)> @params = [
            ("Encount", Encount)
        ];
        return ProcessEvent<FBtlEncountParam>(GetFunction("CoordinateEncountParam"), @params);
    }
    public void CoordinateBattleCondition(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        ProcessEvent(GetFunction("CoordinateBattleCondition"), @params);
    }
    public void ClearUtensilEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearUtensilEffect"), @params);
    }
    public void ClearUIForSerialEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearUIForSerialEncount"), @params);
    }
    public bool CheckValidFukaTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckValidFukaTheurgia"), @params);
    }
    public bool CheckUseQuickEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckUseQuickEncount"), @params);
    }
    public bool CheckUsableRetry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckUsableRetry"), @params);
    }
    public bool CheckUsableFukaTheurgia()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckUsableFukaTheurgia"), @params);
    }
    public bool CheckSuspendTurnProgress()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSuspendTurnProgress"), @params);
    }
    public bool CheckShuffleTimeOccurrence()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckShuffleTimeOccurrence"), @params);
    }
    public bool CheckShaffleTimeAllowed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckShaffleTimeAllowed"), @params);
    }
    public bool CheckShadowExChantCamMustPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckShadowExChantCamMustPlay"), @params);
    }
    public bool CheckRushSwitchable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckRushSwitchable"), @params);
    }
    public bool CheckRushDisable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckRushDisable"), @params);
    }
    public bool CheckRequestRushMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckRequestRushMode"), @params);
    }
    public bool CheckPlayingEventScript()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayingEventScript"), @params);
    }
    public bool CheckPlayableDesignedCommonAttackCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayableDesignedCommonAttackCamera"), @params);
    }
    public bool CheckNeedTurningTable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNeedTurningTable"), @params);
    }
    public bool CheckNeedResult()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckNeedResult"), @params);
    }
    public bool CheckLineFormation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckLineFormation"), @params);
    }
    public bool CheckKnockedoutHero()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckKnockedoutHero"), @params);
    }
    public bool CheckIsSerialEncountBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckIsSerialEncountBattle"), @params);
    }
    public bool CheckInterruptProcessEscape()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInterruptProcessEscape"), @params);
    }
    public bool CheckInRush()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInRush"), @params);
    }
    public bool CheckInAllout()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckInAllout"), @params);
    }
    public bool CheckIgnoreShowingCharacterAtPreAct()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckIgnoreShowingCharacterAtPreAct"), @params);
    }
    public bool CheckHighAnalyzeUnlocked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHighAnalyzeUnlocked"), @params);
    }
    public bool CheckHighAnalyzeEnable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHighAnalyzeEnable"), @params);
    }
    public bool CheckHasHighAnalyzeEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHasHighAnalyzeEvent"), @params);
    }
    public bool CheckEventBattleFinish()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEventBattleFinish"), @params);
    }
    public bool CheckEnemyLoadFinished()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnemyLoadFinished"), @params);
    }
    public bool CheckEnableRelocationClosedFormation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableRelocationClosedFormation"), @params);
    }
    public bool CheckEnableFukaCutin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableFukaCutin"), @params);
    }
    public bool CheckEnableActEndProc()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableActEndProc"), @params);
    }
    public bool CheckEnableActEndEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableActEndEvent"), @params);
    }
    public bool CheckDecideRetry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckDecideRetry"), @params);
    }
    public bool CheckCutinAging()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckCutinAging"), @params);
    }
    public bool CheckBattleProgressToNextBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleProgressToNextBattle"), @params);
    }
    public bool CheckBattleInProgress()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleInProgress"), @params);
    }
    public bool CheckAnyInterruptProcessBetweenTurn()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAnyInterruptProcessBetweenTurn"), @params);
    }
    public bool CheckAllowEnemyAttackBackshotCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAllowEnemyAttackBackshotCamera"), @params);
    }
    public bool CheckAlloutResult()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAlloutResult"), @params);
    }
    public void CallResultCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallResultCapture"), @params);
    }
    public void CallInfoForSerialEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallInfoForSerialEncount"), @params);
    }
    public void CallDebugWindow()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallDebugWindow"), @params);
    }
    public void CallDebugSkillSelect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallDebugSkillSelect"), @params);
    }
    public void CallDebugMonitor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallDebugMonitor"), @params);
    }
    public void CallCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallCapture"), @params);
    }
    public void BeginLoadingRecord(EBtlLoadingTimeCategory Category)
    {
        Span<(string name, object value)> @params = [
            ("Category", Category)
        ];
        ProcessEvent(GetFunction("BeginLoadingRecord"), @params);
    }
    public bool BattleFadeOutSync()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("BattleFadeOutSync"), @params);
    }
    public void BattleFadeOut(bool ForceRapid, bool White)
    {
        Span<(string name, object value)> @params = [
            ("ForceRapid", ForceRapid), 
            ("White", White)
        ];
        ProcessEvent(GetFunction("BattleFadeOut"), @params);
    }
    public void BattleFadeIn(bool ForceRapid)
    {
        Span<(string name, object value)> @params = [
            ("ForceRapid", ForceRapid)
        ];
        ProcessEvent(GetFunction("BattleFadeIn"), @params);
    }
    public void AffectRetry()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AffectRetry"), @params);
    }
    public void AffectHighAnalyze(ABtlActor* pTarget)
    {
        Span<(string name, object value)> @params = [
            ("pTarget", (IntPtr)pTarget)
        ];
        ProcessEvent(GetFunction("AffectHighAnalyze"), @params);
    }
    public void AddUtensilEffect(AAppActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        ProcessEvent(GetFunction("AddUtensilEffect"), @params);
    }
}

public unsafe class BtlManagerInterface : ObjectBase<IBtlManagerInterface>
{
    public BtlManagerInterface(IntPtr pointer) : base(pointer) {}
    public void MarkAsBtlCoreIsReady()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MarkAsBtlCoreIsReady"), @params);
    }
}

public unsafe class BtlCountdown : ObjectBase<ABtlCountdown>
{
    public BtlCountdown(IntPtr pointer) : base(pointer) {}
    public void SetVisible(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetVisible"), @params);
    }
    public void PullTime(float Time)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("PullTime"), @params);
    }
}

public unsafe class BtlDataAssets : ObjectBase<UBtlDataAssets>
{
    public BtlDataAssets(IntPtr pointer) : base(pointer) {}}

public unsafe class DatPlayerMaxHPSPTable : ObjectBase<UDatPlayerMaxHPSPTable>
{
    public DatPlayerMaxHPSPTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPlayerLevelUpTable : ObjectBase<UDatPlayerLevelUpTable>
{
    public DatPlayerLevelUpTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEncountTable : ObjectBase<UDatEncountTable>
{
    public DatEncountTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEnemyTable : ObjectBase<UDatEnemyTable>
{
    public DatEnemyTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEnemyAnalyzeSyncTable : ObjectBase<UDatEnemyAnalyzeSyncTable>
{
    public DatEnemyAnalyzeSyncTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEnemyNameTable : ObjectBase<UDatEnemyNameTable>
{
    public DatEnemyNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPersonaTable : ObjectBase<UDatPersonaTable>
{
    public DatPersonaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPersonaNameTable : ObjectBase<UDatPersonaNameTable>
{
    public DatPersonaNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSkillNameTable : ObjectBase<UDatSkillNameTable>
{
    public DatSkillNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSkillTable : ObjectBase<UDatSkillTable>
{
    public DatSkillTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSkillNormalTable : ObjectBase<UDatSkillNormalTable>
{
    public DatSkillNormalTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatAffinityTable : ObjectBase<UDatAffinityTable>
{
    public DatAffinityTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatAttrNameTable : ObjectBase<UDatAttrNameTable>
{
    public DatAttrNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPersonaGrowthTable : ObjectBase<UDatPersonaGrowthTable>
{
    public DatPersonaGrowthTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatAllyPersonaGrowthTable : ObjectBase<UDatAllyPersonaGrowthTable>
{
    public DatAllyPersonaGrowthTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSupportInfoTable : ObjectBase<UDatSupportInfoTable>
{
    public DatSupportInfoTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatRaceTable : ObjectBase<UDatRaceTable>
{
    public DatRaceTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleChoiceMinorArcanaTable : ObjectBase<UDatShuffleChoiceMinorArcanaTable>
{
    public DatShuffleChoiceMinorArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleChoiceMajorArcanaTable : ObjectBase<UDatShuffleChoiceMajorArcanaTable>
{
    public DatShuffleChoiceMajorArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShufflePersonaArcanaTable : ObjectBase<UDatShufflePersonaArcanaTable>
{
    public DatShufflePersonaArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleCoinArcanaTable : ObjectBase<UDatShuffleCoinArcanaTable>
{
    public DatShuffleCoinArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleCupArcanaTable : ObjectBase<UDatShuffleCupArcanaTable>
{
    public DatShuffleCupArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleLoversArcanaTable : ObjectBase<UDatShuffleLoversArcanaTable>
{
    public DatShuffleLoversArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleArcanaNameTable : ObjectBase<UDatShuffleArcanaNameTable>
{
    public DatShuffleArcanaNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleCommonCoefficientArcanaTable : ObjectBase<UDatShuffleCommonCoefficientArcanaTable>
{
    public DatShuffleCommonCoefficientArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatShuffleCommonItemdropArcanaTable : ObjectBase<UDatShuffleCommonItemdropArcanaTable>
{
    public DatShuffleCommonItemdropArcanaTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatBtlCommonNameTable : ObjectBase<UDatBtlCommonNameTable>
{
    public DatBtlCommonNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatCalcPANICDropItemTable : ObjectBase<UDatCalcPANICDropItemTable>
{
    public DatCalcPANICDropItemTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatCalcPANICUseItemTable : ObjectBase<UDatCalcPANICUseItemTable>
{
    public DatCalcPANICUseItemTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEncountEnemyBadPercentTable : ObjectBase<UDatEncountEnemyBadPercentTable>
{
    public DatEncountEnemyBadPercentTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatBtlTheurgiaBoostTable : ObjectBase<UDatBtlTheurgiaBoostTable>
{
    public DatBtlTheurgiaBoostTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatBtlMixraidReleaseTable : ObjectBase<UDatBtlMixraidReleaseTable>
{
    public DatBtlMixraidReleaseTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class TheurgiaAnimActor : ObjectBase<ATheurgiaAnimActor>
{
    public TheurgiaAnimActor(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlDataBaseComponent : ObjectBase<UBtlDataBaseComponent>
{
    public BtlDataBaseComponent(IntPtr pointer) : base(pointer) {}
    public ABtlActor* SyncTheugiaWindowEnd(UBtlCoreComponent* BtlCore, ref bool IsEnd)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("IsEnd", IsEnd)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("SyncTheugiaWindowEnd"), @params);
    }
    public bool SyncRewuestTutorial(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("SyncRewuestTutorial"), @params);
    }
    public bool StartTheugiaWindow(ABtlActor* pAction, TArray<IntPtr> targetList)
    {
        Span<(string name, object value)> @params = [
            ("pAction", (IntPtr)pAction), 
            ("targetList", targetList)
        ];
        return ProcessEvent<bool>(GetFunction("StartTheugiaWindow"), @params);
    }
    public void StartNavigation(ABtlActor* Action, ref EBtlGuiState State, ref int ID, ref TArray<IntPtr> Target, ref int PersonaID, ref bool physical)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("State", State), 
            ("ID", ID), 
            ("Target", Target), 
            ("PersonaID", PersonaID), 
            ("physical", physical)
        ];
        ProcessEvent(GetFunction("StartNavigation"), @params);
    }
    public TArray<IntPtr> SortPlayerTacticsList(TArray<IntPtr> inList)
    {
        Span<(string name, object value)> @params = [
            ("inList", inList)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("SortPlayerTacticsList"), @params);
    }
    public TArray<FBtlItemData> SortItemBagData(UBtlCoreComponent* BtlCore, TArray<FBtlItemData> In)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("In", In)
        ];
        return ProcessEvent<TArray<FBtlItemData>>(GetFunction("SortItemBagData"), @params);
    }
    public TArray<IntPtr> SortEnemyTacticsList(TArray<IntPtr> inList)
    {
        Span<(string name, object value)> @params = [
            ("inList", inList)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("SortEnemyTacticsList"), @params);
    }
    public void SetUnitTP(ABtlActor* Actor, int Hp)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Hp", Hp)
        ];
        ProcessEvent(GetFunction("SetUnitTP"), @params);
    }
    public void SetUnitSP(ABtlActor* Actor, int Hp)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Hp", Hp)
        ];
        ProcessEvent(GetFunction("SetUnitSP"), @params);
    }
    public void SetUnitHP(ABtlActor* Actor, int Hp)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Hp", Hp)
        ];
        ProcessEvent(GetFunction("SetUnitHP"), @params);
    }
    public void SetSupport(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetSupport"), @params);
    }
    public void SetPersonaStockEquip(ABtlActor* Actor, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetPersonaStockEquip"), @params);
    }
    public void SetPersonaEquipID(ABtlActor* Actor, int ID)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SetPersonaEquipID"), @params);
    }
    public void SetPersonaDefaultStock(ABtlActor* Actor, int PersonaID, ref int Index)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("PersonaID", PersonaID), 
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetPersonaDefaultStock"), @params);
    }
    public void SetOperation(ABtlActor* Action, int Operation)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("Operation", Operation)
        ];
        ProcessEvent(GetFunction("SetOperation"), @params);
    }
    public void SetManualOperate(ABtlActor* Action, bool isManual)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("isManual", isManual)
        ];
        ProcessEvent(GetFunction("SetManualOperate"), @params);
    }
    public void SetHighStreamingLocation(FVector Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetHighStreamingLocation"), @params);
    }
    public void SetBadStatus(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetBadStatus"), @params);
    }
    public void SaveReceiveSkillAttr(TArray<IntPtr> Targets, EBtlDataAttr attr)
    {
        Span<(string name, object value)> @params = [
            ("Targets", Targets), 
            ("attr", attr)
        ];
        ProcessEvent(GetFunction("SaveReceiveSkillAttr"), @params);
    }
    public void SavePrevUseSkillID(ABtlActor* Action, int ID)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SavePrevUseSkillID"), @params);
    }
    public void SavePrevUseItemID(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("SavePrevUseItemID"), @params);
    }
    public void OpenAllAttr(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("OpenAllAttr"), @params);
    }
    public ABtlActor* MoveCursorTacticsSimple(int nowIdx, TArray<IntPtr> List, TArray<FVector2D> PosCursor, EBtlDataMoveCursorTactics moveCursor)
    {
        Span<(string name, object value)> @params = [
            ("nowIdx", nowIdx), 
            ("List", List), 
            ("PosCursor", PosCursor), 
            ("moveCursor", moveCursor)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("MoveCursorTacticsSimple"), @params);
    }
    public ABtlActor* MoveCursorTactics(int nowIdx, TArray<IntPtr> List, TArray<FVector2D> PosCursor, EBtlDataMoveCursorTactics moveCursor, bool IsBoss)
    {
        Span<(string name, object value)> @params = [
            ("nowIdx", nowIdx), 
            ("List", List), 
            ("PosCursor", PosCursor), 
            ("moveCursor", moveCursor), 
            ("IsBoss", IsBoss)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("MoveCursorTactics"), @params);
    }
    public AActor* GetViewTargetActor(APlayerCameraManager* CameraManager)
    {
        Span<(string name, object value)> @params = [
            ("CameraManager", (IntPtr)CameraManager)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetViewTargetActor"), @params);
    }
    public int GetUnitTP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitTP"), @params);
    }
    public int GetUnitSP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitSP"), @params);
    }
    public FText GetUnitName(ABtlActor* Actor, bool InsertSpace)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("InsertSpace", InsertSpace)
        ];
        return ProcessEvent<FText>(GetFunction("GetUnitName"), @params);
    }
    public int GetUnitMaxTP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitMaxTP"), @params);
    }
    public int GetUnitMaxSP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitMaxSP"), @params);
    }
    public int GetUnitMaxHP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitMaxHP"), @params);
    }
    public int GetUnitLevel(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitLevel"), @params);
    }
    public int GetUnitID(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitID"), @params);
    }
    public int GetUnitHP(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitHP"), @params);
    }
    public int GetUnitArcana(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetUnitArcana"), @params);
    }
    public ABtlActor* GetUINextAction(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetUINextAction"), @params);
    }
    public UBmdAsset* GetTheurgiaFlavorBMD()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBmdAsset*)ProcessEvent<IntPtr>(GetFunction("GetTheurgiaFlavorBMD"), @params);
    }
    public int GetTargetEffectiveIndex(TArray<IntPtr> Target, EBtlDataCostType Type)
    {
        Span<(string name, object value)> @params = [
            ("Target", Target), 
            ("Type", Type)
        ];
        return ProcessEvent<int>(GetFunction("GetTargetEffectiveIndex"), @params);
    }
    public int GetSupportTurn(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        return ProcessEvent<int>(GetFunction("GetSupportTurn"), @params);
    }
    public int GetSupportPoint(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        return ProcessEvent<int>(GetFunction("GetSupportPoint"), @params);
    }
    public int GetStatusStrength(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetStatusStrength"), @params);
    }
    public int GetStatusSpeed(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetStatusSpeed"), @params);
    }
    public int GetStatusMagic(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetStatusMagic"), @params);
    }
    public int GetStatusLuck(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetStatusLuck"), @params);
    }
    public int GetStatusEndurance(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetStatusEndurance"), @params);
    }
    public TArray<int> GetSpecialSkillList(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetSpecialSkillList"), @params);
    }
    public int GetSpecialAutoSkill(ABtlActor* Actor, ref bool bPowerUp)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("bPowerUp", bPowerUp)
        ];
        return ProcessEvent<int>(GetFunction("GetSpecialAutoSkill"), @params);
    }
    public EBtlDataTargetType GetSkillTargetType(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<EBtlDataTargetType>(GetFunction("GetSkillTargetType"), @params);
    }
    public FBtlDataTargetRule GetSkillTargetRule(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<FBtlDataTargetRule>(GetFunction("GetSkillTargetRule"), @params);
    }
    public EBtlDataTargetArea GetSkillTargetArea(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<EBtlDataTargetArea>(GetFunction("GetSkillTargetArea"), @params);
    }
    public FText GetSkillParamN(int skillId, ref bool Sucsess)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("Sucsess", Sucsess)
        ];
        return ProcessEvent<FText>(GetFunction("GetSkillParamN"), @params);
    }
    public FText GetSkillName(int skillId, ref bool Sucsess)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("Sucsess", Sucsess)
        ];
        return ProcessEvent<FText>(GetFunction("GetSkillName"), @params);
    }
    public int GetSkillMaxNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSkillMaxNum"), @params);
    }
    public void GetSkillList(ABtlActor* Actor, ref TArray<int> Output)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Output", Output)
        ];
        ProcessEvent(GetFunction("GetSkillList"), @params);
    }
    public bool GetSkillIsSupport(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsSupport"), @params);
    }
    public bool GetSkillIsRecovery(int skillId, EBtlDataCostType Type)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsRecovery"), @params);
    }
    public bool GetSkillIsNoPanel(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsNoPanel"), @params);
    }
    public bool GetSkillIsHealSupport(int skillId, ref EBtlDataSupportTable support)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("support", support)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsHealSupport"), @params);
    }
    public bool GetSkillIsDamageBit(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsDamageBit"), @params);
    }
    public bool GetSkillIsDamage(int skillId, EBtlDataCostType Type)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsDamage"), @params);
    }
    public bool GetSkillIsCharge(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsCharge"), @params);
    }
    public bool GetSkillIsBadStatus(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillIsBadStatus"), @params);
    }
    public int GetSkillIconSprNoByAttr(EBtlDataAttr attr)
    {
        Span<(string name, object value)> @params = [
            ("attr", attr)
        ];
        return ProcessEvent<int>(GetFunction("GetSkillIconSprNoByAttr"), @params);
    }
    public int GetSkillIconSprNo(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<int>(GetFunction("GetSkillIconSprNo"), @params);
    }
    public EBtlDataEfficacyType GetSkillEfficacyType(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<EBtlDataEfficacyType>(GetFunction("GetSkillEfficacyType"), @params);
    }
    public bool GetSkillCostCheckOff(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("GetSkillCostCheckOff"), @params);
    }
    public int GetSkillCost(int skillId, ABtlActor* Action, ref bool Sucsess, ref EBtlDataCostType cost)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("Action", (IntPtr)Action), 
            ("Sucsess", Sucsess), 
            ("cost", cost)
        ];
        return ProcessEvent<int>(GetFunction("GetSkillCost"), @params);
    }
    public EBtlDataAttr GetSkillAttr(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<EBtlDataAttr>(GetFunction("GetSkillAttr"), @params);
    }
    public int GetPrevUseSkillID(ABtlActor* Action)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action)
        ];
        return ProcessEvent<int>(GetFunction("GetPrevUseSkillID"), @params);
    }
    public int GetPrevUseItemID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPrevUseItemID"), @params);
    }
    public FColor GetPlatFormButtonColor(int ButtonType)
    {
        Span<(string name, object value)> @params = [
            ("ButtonType", ButtonType)
        ];
        return ProcessEvent<FColor>(GetFunction("GetPlatFormButtonColor"), @params);
    }
    public TArray<int> GetPersonaTableSkillList(int PersonaID)
    {
        Span<(string name, object value)> @params = [
            ("PersonaID", PersonaID)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetPersonaTableSkillList"), @params);
    }
    public TArray<int> GetPersonaStockIndexList(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetPersonaStockIndexList"), @params);
    }
    public TArray<int> GetPersonaSkillList(ABtlActor* Actor, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Index", Index)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetPersonaSkillList"), @params);
    }
    public void GetPersonaNameList(ABtlActor* Actor, ref TArray<FText> NameList, ref int Count, ref int equip)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("NameList", NameList), 
            ("Count", Count), 
            ("equip", equip)
        ];
        ProcessEvent(GetFunction("GetPersonaNameList"), @params);
    }
    public FText GetPersonaName(int PersonaID)
    {
        Span<(string name, object value)> @params = [
            ("PersonaID", PersonaID)
        ];
        return ProcessEvent<FText>(GetFunction("GetPersonaName"), @params);
    }
    public int GetPersonaMaxNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPersonaMaxNum"), @params);
    }
    public TArray<int> GetPersonaEquipSkillList(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetPersonaEquipSkillList"), @params);
    }
    public FText GetPersonaEquipName(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<FText>(GetFunction("GetPersonaEquipName"), @params);
    }
    public int GetPersonaEquipIndex(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetPersonaEquipIndex"), @params);
    }
    public int GetPersonaEquipID(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetPersonaEquipID"), @params);
    }
    public void GetPersonaBySpecialSkill(int skillId, ref int personaID1, ref int personaID2, ref bool twoPersona)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId), 
            ("personaID1", personaID1), 
            ("personaID2", personaID2), 
            ("twoPersona", twoPersona)
        ];
        ProcessEvent(GetFunction("GetPersonaBySpecialSkill"), @params);
    }
    public bool GetOrgiaMode(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("GetOrgiaMode"), @params);
    }
    public int GetOperation(ABtlActor* Action)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action)
        ];
        return ProcessEvent<int>(GetFunction("GetOperation"), @params);
    }
    public int GetNormalSkillMaxNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNormalSkillMaxNum"), @params);
    }
    public bool GetManualOperate(ABtlActor* Action)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action)
        ];
        return ProcessEvent<bool>(GetFunction("GetManualOperate"), @params);
    }
    public TArray<bool> GetKeyControl(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<TArray<bool>>(GetFunction("GetKeyControl"), @params);
    }
    public EBtlDataItemUseType GetItemUseType(UBtlCoreComponent* BtlCore, EBtlCommandType Type, int ID)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("Type", Type), 
            ("ID", ID)
        ];
        return ProcessEvent<EBtlDataItemUseType>(GetFunction("GetItemUseType"), @params);
    }
    public int GetItemSkillID(int ItemId)
    {
        Span<(string name, object value)> @params = [
            ("ItemId", ItemId)
        ];
        return ProcessEvent<int>(GetFunction("GetItemSkillID"), @params);
    }
    public FText GetItemName(int ItemId)
    {
        Span<(string name, object value)> @params = [
            ("ItemId", ItemId)
        ];
        return ProcessEvent<FText>(GetFunction("GetItemName"), @params);
    }
    public int GetItemIconSprNo(int ItemId)
    {
        Span<(string name, object value)> @params = [
            ("ItemId", ItemId)
        ];
        return ProcessEvent<int>(GetFunction("GetItemIconSprNo"), @params);
    }
    public TArray<FBtlItemData> GetItemBagData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FBtlItemData>>(GetFunction("GetItemBagData"), @params);
    }
    public bool GetInputDecideKeyCross()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetInputDecideKeyCross"), @params);
    }
    public int GetFukaTheurgiaSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFukaTheurgiaSkill"), @params);
    }
    public int GetEnemyDropItem(ABtlActor* Actor, int Index)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetEnemyDropItem"), @params);
    }
    public void GetCorrespondList(ref TArray<IntPtr> Out, ABtlActor* spEmployment, EBtlCommandType Command, int ID)
    {
        Span<(string name, object value)> @params = [
            ("Out", Out), 
            ("spEmployment", (IntPtr)spEmployment), 
            ("Command", Command), 
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("GetCorrespondList"), @params);
    }
    public FText GetBtlCommonText(int Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        return ProcessEvent<FText>(GetFunction("GetBtlCommonText"), @params);
    }
    public bool GetBadStatus(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("GetBadStatus"), @params);
    }
    public FText GetAttackName(int attr)
    {
        Span<(string name, object value)> @params = [
            ("attr", attr)
        ];
        return ProcessEvent<FText>(GetFunction("GetAttackName"), @params);
    }
    public int GetAnalyzeAttrMaxNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetAnalyzeAttrMaxNum"), @params);
    }
    public EBtlDataAnalyze GatAnalizeAttr(ABtlActor* Actor, byte attr)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("attr", attr)
        ];
        return ProcessEvent<EBtlDataAnalyze>(GetFunction("GatAnalizeAttr"), @params);
    }
    public void CloseAllAttr(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("CloseAllAttr"), @params);
    }
    public void ClearTargetSupport(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("ClearTargetSupport"), @params);
    }
    public void ClearSupport(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("ClearSupport"), @params);
    }
    public void ClearBadStatus(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("ClearBadStatus"), @params);
    }
    public bool ChkUseAllSkillAgeing(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkUseAllSkillAgeing"), @params);
    }
    public bool ChkTutorialSkillList(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkTutorialSkillList"), @params);
    }
    public bool ChkTurnOff(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkTurnOff"), @params);
    }
    public bool ChkTPValid(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("ChkTPValid"), @params);
    }
    public bool ChkSpecialSkillID(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<bool>(GetFunction("ChkSpecialSkillID"), @params);
    }
    public bool ChkSkillIgnoreResistances(ABtlActor* Action, int skillId)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("ChkSkillIgnoreResistances"), @params);
    }
    public bool ChkSelectAllSkill(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkSelectAllSkill"), @params);
    }
    public bool ChkSelectAllPersona(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkSelectAllPersona"), @params);
    }
    public bool ChkPrevUseSkillIDFrag()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ChkPrevUseSkillIDFrag"), @params);
    }
    public bool ChkPlayerDamageOff(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkPlayerDamageOff"), @params);
    }
    public bool ChkLastActionLoop(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkLastActionLoop"), @params);
    }
    public int ChkExcessEfficary(ABtlActor* pAction, TArray<IntPtr> targetList, int skillId, bool isItem)
    {
        Span<(string name, object value)> @params = [
            ("pAction", (IntPtr)pAction), 
            ("targetList", targetList), 
            ("skillId", skillId), 
            ("isItem", isItem)
        ];
        return ProcessEvent<int>(GetFunction("ChkExcessEfficary"), @params);
    }
    public bool ChkEnemySideWeakAll(ABtlActor* Action, TArray<IntPtr> EnemyList)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("EnemyList", EnemyList)
        ];
        return ProcessEvent<bool>(GetFunction("ChkEnemySideWeakAll"), @params);
    }
    public bool ChkEnemySideWeak(ABtlActor* Action, TArray<IntPtr> EnemyList, EBtlDataAttr attr)
    {
        Span<(string name, object value)> @params = [
            ("Action", (IntPtr)Action), 
            ("EnemyList", EnemyList), 
            ("attr", attr)
        ];
        return ProcessEvent<bool>(GetFunction("ChkEnemySideWeak"), @params);
    }
    public bool ChkAutoSkill(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("ChkAutoSkill"), @params);
    }
    public bool ChkAllCostOff(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("ChkAllCostOff"), @params);
    }
    public bool CheckTacticsIconLLSize(ABtlActor* Target)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target)
        ];
        return ProcessEvent<bool>(GetFunction("CheckTacticsIconLLSize"), @params);
    }
    public bool CheckSupportDownUp(ABtlActor* Actor, EBtlDataSupportTable support)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("support", support)
        ];
        return ProcessEvent<bool>(GetFunction("CheckSupportDownUp"), @params);
    }
    public bool CheckSupport(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("CheckSupport"), @params);
    }
    public bool CheckNyxCoreBattle(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckNyxCoreBattle"), @params);
    }
    public bool CheckExistTutorial(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckExistTutorial"), @params);
    }
    public bool CheckExistTarget(UBtlCoreComponent* BtlCore, int skillId)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("CheckExistTarget"), @params);
    }
    public void CallSupportInfoDisableShift(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("CallSupportInfoDisableShift"), @params);
    }
    public void CallRequestEscape(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("CallRequestEscape"), @params);
    }
    public bool CallCheckEncountEscape(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CallCheckEncountEscape"), @params);
    }
    public bool CallCheckAlreadyRequestEscape(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CallCheckAlreadyRequestEscape"), @params);
    }
}

public unsafe class BtlEnvironmentBase : ObjectBase<UBtlEnvironmentBase>
{
    public BtlEnvironmentBase(IntPtr pointer) : base(pointer) {}
    public void RequestLoversFogEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestLoversFogEffect"), @params);
    }
    public void InvisibleHangedmanBGObj()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InvisibleHangedmanBGObj"), @params);
    }
    public TArray<IntPtr> GetNyxAvatarFeatherEffects()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetNyxAvatarFeatherEffects"), @params);
    }
    public TArray<IntPtr> GetMonorailWallObj()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetMonorailWallObj"), @params);
    }
    public TArray<IntPtr> GetMonorailStrapObj()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetMonorailStrapObj"), @params);
    }
    public TArray<IntPtr> GetMonorailRushEffects()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetMonorailRushEffects"), @params);
    }
    public AFldAnimObj* GetMonorailBGObj()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AFldAnimObj*)ProcessEvent<IntPtr>(GetFunction("GetMonorailBGObj"), @params);
    }
    public TArray<IntPtr> GetLoversFogEffects()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetLoversFogEffects"), @params);
    }
    public void DeleteLoversFogEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeleteLoversFogEffect"), @params);
    }
}

public unsafe class BtlEventActor : ObjectBase<ABtlEventActor>
{
    public BtlEventActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlEventAlloutShuffleMonitor : ObjectBase<ABtlEventAlloutShuffleMonitor>
{
    public BtlEventAlloutShuffleMonitor(IntPtr pointer) : base(pointer) {}
    public void StartShuffleTime(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("StartShuffleTime"), @params);
    }
    public bool CheckReadyToDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckReadyToDestroy"), @params);
    }
}

public unsafe class BtlEventBfLoader : ObjectBase<ABtlEventBfLoader>
{
    public BtlEventBfLoader(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlEventController : ObjectBase<UBtlEventController>
{
    public BtlEventController(IntPtr pointer) : base(pointer) {}
    public void SetPerformer(ABtlActor* Actor, EBtlEventAreaType Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("SetPerformer"), @params);
    }
    public void ResetAllPerformer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetAllPerformer"), @params);
    }
    public bool IsPlayingEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingEvent"), @params);
    }
    public bool HasEventScriptForBP(FBtlEncountParam EncParam)
    {
        Span<(string name, object value)> @params = [
            ("EncParam", EncParam)
        ];
        return ProcessEvent<bool>(GetFunction("HasEventScriptForBP"), @params);
    }
    public void EventStart(EBtlEventType EventType)
    {
        Span<(string name, object value)> @params = [
            ("EventType", EventType)
        ];
        ProcessEvent(GetFunction("EventStart"), @params);
    }
    public void CommonEventStart(EBtlCommonEventType EventType)
    {
        Span<(string name, object value)> @params = [
            ("EventType", EventType)
        ];
        ProcessEvent(GetFunction("CommonEventStart"), @params);
    }
}

public unsafe class BtlEventCutsceneController : ObjectBase<UBtlEventCutsceneController>
{
    public BtlEventCutsceneController(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlFadeManager : ObjectBase<ABtlFadeManager>
{
    public BtlFadeManager(IntPtr pointer) : base(pointer) {}
    public void FadeUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FadeUpdate"), @params);
    }
    public void FadeInit(bool isFadeOut)
    {
        Span<(string name, object value)> @params = [
            ("isFadeOut", isFadeOut)
        ];
        ProcessEvent(GetFunction("FadeInit"), @params);
    }
    public void ClearDrawItem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearDrawItem"), @params);
    }
    public bool BtlFadeSync()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("BtlFadeSync"), @params);
    }
    public void BtlFadeOut(EBtlFadeType Type, int Frame, bool IsEnemy, bool isAIAction)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame), 
            ("IsEnemy", IsEnemy), 
            ("isAIAction", isAIAction)
        ];
        ProcessEvent(GetFunction("BtlFadeOut"), @params);
    }
    public ABtlFadeManager* BtlFadeManagerGetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlFadeManager*)ProcessEvent<IntPtr>(GetFunction("BtlFadeManagerGetInstance"), @params);
    }
    public void BtlFadeIn(EBtlFadeType Type, int Frame, bool IsEnemy, bool isAIAction)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame), 
            ("IsEnemy", IsEnemy), 
            ("isAIAction", isAIAction)
        ];
        ProcessEvent(GetFunction("BtlFadeIn"), @params);
    }
    public bool BtlFadeCheckScreenWrap()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("BtlFadeCheckScreenWrap"), @params);
    }
    public void BtlCrossFadeOut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlCrossFadeOut"), @params);
    }
    public void BtlCrossFadeIn(int Frame)
    {
        Span<(string name, object value)> @params = [
            ("Frame", Frame)
        ];
        ProcessEvent(GetFunction("BtlCrossFadeIn"), @params);
    }
}

public unsafe class BtlFormationPoint : ObjectBase<ABtlFormationPoint>
{
    public BtlFormationPoint(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiAnalyzeComponent : ObjectBase<UBtlGuiAnalyzeComponent>
{
    public BtlGuiAnalyzeComponent(IntPtr pointer) : base(pointer) {}
    public void UpdateAnalyze(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("UpdateAnalyze"), @params);
    }
    public void StartLoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartLoadResource"), @params);
    }
    public void ShowMessage(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("ShowMessage"), @params);
    }
    public void ShowFukaPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowFukaPartyPanel"), @params);
    }
    public void SetSelectIndex(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("SetSelectIndex"), @params);
    }
    public TArray<IntPtr> RemoveSameEnemyID(TArray<IntPtr> inList, ABtlActor* PriorityActor)
    {
        Span<(string name, object value)> @params = [
            ("inList", inList), 
            ("PriorityActor", (IntPtr)PriorityActor)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("RemoveSameEnemyID"), @params);
    }
    public void PlaySupportInfo(UBtlCoreComponent* BtlCore, ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("PlaySupportInfo"), @params);
    }
    public void PlayAnalyzeSupportInfo(UBtlCoreComponent* BtlCore, int PlayID)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("PlayID", PlayID)
        ];
        ProcessEvent(GetFunction("PlayAnalyzeSupportInfo"), @params);
    }
    public void OpenSelectWindow()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OpenSelectWindow"), @params);
    }
    public void Init()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Init"), @params);
    }
    public void HiddenFukaPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("HiddenFukaPartyPanel"), @params);
    }
    public EBtlAnalyzeSupportType GetSupportTypeTargetEnemy(UBtlCoreComponent* BtlCore, ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<EBtlAnalyzeSupportType>(GetFunction("GetSupportTypeTargetEnemy"), @params);
    }
    public UBmdAsset* GetHighAnalyzeBMD(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return (UBmdAsset*)ProcessEvent<IntPtr>(GetFunction("GetHighAnalyzeBMD"), @params);
    }
    public bool GetDebugEnableFlag(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("GetDebugEnableFlag"), @params);
    }
    public int GetCostHighAnalyze()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCostHighAnalyze"), @params);
    }
    public int GetAnalyzeSupportInfo(UBtlCoreComponent* BtlCore, EBtlAnalyzeSupportType Type)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("Type", Type)
        ];
        return ProcessEvent<int>(GetFunction("GetAnalyzeSupportInfo"), @params);
    }
    public void CloseSelectWindow()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseSelectWindow"), @params);
    }
    public void CloseAnalyze()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseAnalyze"), @params);
    }
    public bool CheckShowStatus(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowStatus"), @params);
    }
    public bool CheckShowSkill(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowSkill"), @params);
    }
    public bool CheckShowItem(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowItem"), @params);
    }
    public bool CheckShowFukaFukidashi(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowFukaFukidashi"), @params);
    }
    public bool CheckShowAttackAttr(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowAttackAttr"), @params);
    }
    public bool CheckShowArcana(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowArcana"), @params);
    }
    public bool CheckPlayHighAnalzeSupport(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckPlayHighAnalzeSupport"), @params);
    }
    public bool CheckHighAnalyzeEnableSP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHighAnalyzeEnableSP"), @params);
    }
    public bool CheckEndLoader()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEndLoader"), @params);
    }
    public bool CheckAttrFullOpen(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<bool>(GetFunction("CheckAttrFullOpen"), @params);
    }
}

public unsafe class BtlGuiDrawObjectCore : ObjectBase<UBtlGuiDrawObjectCore>
{
    public BtlGuiDrawObjectCore(IntPtr pointer) : base(pointer) {}
    public void SetScaleVec2(FVector2D Scale)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("SetScaleVec2"), @params);
    }
    public void SetScaleAnchorPos(FVector2D anchor)
    {
        Span<(string name, object value)> @params = [
            ("anchor", anchor)
        ];
        ProcessEvent(GetFunction("SetScaleAnchorPos"), @params);
    }
    public void SetScale(float Scale)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("SetScale"), @params);
    }
    public void SetPos(FVector2D Pos)
    {
        Span<(string name, object value)> @params = [
            ("Pos", Pos)
        ];
        ProcessEvent(GetFunction("SetPos"), @params);
    }
    public void SetColor(FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("SetColor"), @params);
    }
    public void SetChildObject(UBtlGuiDrawObjectCore* Object, FBtlGuiDrawFlag flag)
    {
        Span<(string name, object value)> @params = [
            ("Object", (IntPtr)Object), 
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetChildObject"), @params);
    }
    public void SetAngleAnchorPos(FVector2D anchor)
    {
        Span<(string name, object value)> @params = [
            ("anchor", anchor)
        ];
        ProcessEvent(GetFunction("SetAngleAnchorPos"), @params);
    }
    public void SetAngle(float Angle)
    {
        Span<(string name, object value)> @params = [
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("SetAngle"), @params);
    }
    public void SetAnchorPos(FVector2D anchor)
    {
        Span<(string name, object value)> @params = [
            ("anchor", anchor)
        ];
        ProcessEvent(GetFunction("SetAnchorPos"), @params);
    }
    public void SetAlpha(float Alpha)
    {
        Span<(string name, object value)> @params = [
            ("Alpha", Alpha)
        ];
        ProcessEvent(GetFunction("SetAlpha"), @params);
    }
    public FVector2D GetScaleAnchorPos()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetScaleAnchorPos"), @params);
    }
    public FVector2D GetScale()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetScale"), @params);
    }
    public FVector2D GetPos()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetPos"), @params);
    }
    public FColor GetColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetColor"), @params);
    }
    public FVector2D GetAngleAnchorPos()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAngleAnchorPos"), @params);
    }
    public float GetAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAngle"), @params);
    }
    public float GetAlpha()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetAlpha"), @params);
    }
}

public unsafe class BtlGuiDrawObjectClearScreen : ObjectBase<UBtlGuiDrawObjectClearScreen>
{
    public BtlGuiDrawObjectClearScreen(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiDrawObjectImage : ObjectBase<UBtlGuiDrawObjectImage>
{
    public BtlGuiDrawObjectImage(IntPtr pointer) : base(pointer) {}
    public void GetWidthHeight(ref float Width, ref float Height)
    {
        Span<(string name, object value)> @params = [
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetWidthHeight"), @params);
    }
}

public unsafe class BtlGuiDrawObjectPanel : ObjectBase<UBtlGuiDrawObjectPanel>
{
    public BtlGuiDrawObjectPanel(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiDrawObjectText : ObjectBase<UBtlGuiDrawObjectText>
{
    public BtlGuiDrawObjectText(IntPtr pointer) : base(pointer) {}
    public void GetTextWidthHeight(ref float Width, ref float Height)
    {
        Span<(string name, object value)> @params = [
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetTextWidthHeight"), @params);
    }
    public void CalcAdjustedScale(FBtlGuiDrawText Item, FVector2D textCollision, bool ScalingOnlyX, ref FVector2D adjustedScale)
    {
        Span<(string name, object value)> @params = [
            ("Item", Item), 
            ("textCollision", textCollision), 
            ("ScalingOnlyX", ScalingOnlyX), 
            ("adjustedScale", adjustedScale)
        ];
        ProcessEvent(GetFunction("CalcAdjustedScale"), @params);
    }
    public void ApplyFontStyleMakeOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ApplyFontStyleMakeOffset"), @params);
    }
}

public unsafe class BtlGuiDrawObjectMsg : ObjectBase<UBtlGuiDrawObjectMsg>
{
    public BtlGuiDrawObjectMsg(IntPtr pointer) : base(pointer) {}
    public void SetSkillHelpMsg()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetSkillHelpMsg"), @params);
    }
    public void SetItemHelpMsg(int ItemId)
    {
        Span<(string name, object value)> @params = [
            ("ItemId", ItemId)
        ];
        ProcessEvent(GetFunction("SetItemHelpMsg"), @params);
    }
    public void ResetBmd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetBmd"), @params);
    }
    public void ReCreateMsgInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReCreateMsgInfo"), @params);
    }
    public void GetMsgWindowLength(ref float Width, ref float Height)
    {
        Span<(string name, object value)> @params = [
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetMsgWindowLength"), @params);
    }
    public void CalcAdjustedScaleOnlyX(FBtlGuiDrawMsg Item, FVector2D textCollision, ref FVector2D adjustedScale)
    {
        Span<(string name, object value)> @params = [
            ("Item", Item), 
            ("textCollision", textCollision), 
            ("adjustedScale", adjustedScale)
        ];
        ProcessEvent(GetFunction("CalcAdjustedScaleOnlyX"), @params);
    }
    public void CalcAdjustedScale(FBtlGuiDrawMsg Item, FVector2D textCollision, ref FVector2D adjustedScale, ref float lineBreak, bool onKeepScale)
    {
        Span<(string name, object value)> @params = [
            ("Item", Item), 
            ("textCollision", textCollision), 
            ("adjustedScale", adjustedScale), 
            ("lineBreak", lineBreak), 
            ("onKeepScale", onKeepScale)
        ];
        ProcessEvent(GetFunction("CalcAdjustedScale"), @params);
    }
}

public unsafe class BtlGuiDrawObjectRect : ObjectBase<UBtlGuiDrawObjectRect>
{
    public BtlGuiDrawObjectRect(IntPtr pointer) : base(pointer) {}
    public void SetTouchCollision(EBtlTouchCallbackValue callbackValue, float adjustX, float adjustY, float adjustAngle, float adjustW, float adjustH, int addLayer)
    {
        Span<(string name, object value)> @params = [
            ("callbackValue", callbackValue), 
            ("adjustX", adjustX), 
            ("adjustY", adjustY), 
            ("adjustAngle", adjustAngle), 
            ("adjustW", adjustW), 
            ("adjustH", adjustH), 
            ("addLayer", addLayer)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetScrollBarTouchCollision(EBtlTouchScreenID screenID, float adjustX, float adjustY, float adjustAngle, float adjustW, float adjustH, bool onSlider)
    {
        Span<(string name, object value)> @params = [
            ("screenID", screenID), 
            ("adjustX", adjustX), 
            ("adjustY", adjustY), 
            ("adjustAngle", adjustAngle), 
            ("adjustW", adjustW), 
            ("adjustH", adjustH), 
            ("onSlider", onSlider)
        ];
        ProcessEvent(GetFunction("SetScrollBarTouchCollision"), @params);
    }
    public void SetListTouchCollision(EBtlTouchScreenID screenID, int idx, float adjustX, float adjustY, float adjustAngle, float adjustW, float adjustH, int addLayer)
    {
        Span<(string name, object value)> @params = [
            ("screenID", screenID), 
            ("idx", idx), 
            ("adjustX", adjustX), 
            ("adjustY", adjustY), 
            ("adjustAngle", adjustAngle), 
            ("adjustW", adjustW), 
            ("adjustH", adjustH), 
            ("addLayer", addLayer)
        ];
        ProcessEvent(GetFunction("SetListTouchCollision"), @params);
    }
    public void OnEnableTouchCollision(bool onEnable)
    {
        Span<(string name, object value)> @params = [
            ("onEnable", onEnable)
        ];
        ProcessEvent(GetFunction("OnEnableTouchCollision"), @params);
    }
}

public unsafe class BtlGuiDrawObjectSprite : ObjectBase<UBtlGuiDrawObjectSprite>
{
    public BtlGuiDrawObjectSprite(IntPtr pointer) : base(pointer) {}
    public void SetTouchCollision(EBtlTouchCallbackValue callbackValue, float adjustX, float adjustY, float adjustAngle, float adjustW, float adjustH, int addLayer)
    {
        Span<(string name, object value)> @params = [
            ("callbackValue", callbackValue), 
            ("adjustX", adjustX), 
            ("adjustY", adjustY), 
            ("adjustAngle", adjustAngle), 
            ("adjustW", adjustW), 
            ("adjustH", adjustH), 
            ("addLayer", addLayer)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetListTouchCollision(EBtlTouchScreenID screenID, int idx, float adjustX, float adjustY, float adjustAngle, float adjustW, float adjustH, int addLayer)
    {
        Span<(string name, object value)> @params = [
            ("screenID", screenID), 
            ("idx", idx), 
            ("adjustX", adjustX), 
            ("adjustY", adjustY), 
            ("adjustAngle", adjustAngle), 
            ("adjustW", adjustW), 
            ("adjustH", adjustH), 
            ("addLayer", addLayer)
        ];
        ProcessEvent(GetFunction("SetListTouchCollision"), @params);
    }
    public void OnEnableTouchCollision(bool onEnable)
    {
        Span<(string name, object value)> @params = [
            ("onEnable", onEnable)
        ];
        ProcessEvent(GetFunction("OnEnableTouchCollision"), @params);
    }
    public void GetWidthHeight(ref float Width, ref float Height)
    {
        Span<(string name, object value)> @params = [
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetWidthHeight"), @params);
    }
}

public unsafe class BtlGuiDrawObjectMaterial : ObjectBase<UBtlGuiDrawObjectMaterial>
{
    public BtlGuiDrawObjectMaterial(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiDrawObjectPlg : ObjectBase<UBtlGuiDrawObjectPlg>
{
    public BtlGuiDrawObjectPlg(IntPtr pointer) : base(pointer) {}
    public FVector2D GetSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetSize"), @params);
    }
}

public unsafe class BtlGuiDrawObjectPrimitive : ObjectBase<UBtlGuiDrawObjectPrimitive>
{
    public BtlGuiDrawObjectPrimitive(IntPtr pointer) : base(pointer) {}
    public void SetAntiLength(float anti)
    {
        Span<(string name, object value)> @params = [
            ("anti", anti)
        ];
        ProcessEvent(GetFunction("SetAntiLength"), @params);
    }
    public void MakeRhombus(FVector2D Size, FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Size", Size), 
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("MakeRhombus"), @params);
    }
    public void MakeCircle(float Radius, FColor Color, FVector2D Scale)
    {
        Span<(string name, object value)> @params = [
            ("Radius", Radius), 
            ("Color", Color), 
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("MakeCircle"), @params);
    }
}

public unsafe class BtlGuiDrawObjectLineFrame : ObjectBase<UBtlGuiDrawObjectLineFrame>
{
    public BtlGuiDrawObjectLineFrame(IntPtr pointer) : base(pointer) {}
    public void SetAntiLength(float anti)
    {
        Span<(string name, object value)> @params = [
            ("anti", anti)
        ];
        ProcessEvent(GetFunction("SetAntiLength"), @params);
    }
    public void MakeRhombus(FVector2D Size, FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Size", Size), 
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("MakeRhombus"), @params);
    }
    public void MakeCircle(float Radius, FColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Radius", Radius), 
            ("Color", Color)
        ];
        ProcessEvent(GetFunction("MakeCircle"), @params);
    }
}

public unsafe class BtlGuiDrawObjectRoundRect : ObjectBase<UBtlGuiDrawObjectRoundRect>
{
    public BtlGuiDrawObjectRoundRect(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiDrawObjectSilhouette : ObjectBase<UBtlGuiDrawObjectSilhouette>
{
    public BtlGuiDrawObjectSilhouette(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlGuiDrawComponent : ObjectBase<UBtlGuiDrawComponent>
{
    public BtlGuiDrawComponent(IntPtr pointer) : base(pointer) {}
    public UPlgAsset* TranslateObjectToPlgAsset(UObject* Obj)
    {
        Span<(string name, object value)> @params = [
            ("Obj", (IntPtr)Obj)
        ];
        return (UPlgAsset*)ProcessEvent<IntPtr>(GetFunction("TranslateObjectToPlgAsset"), @params);
    }
    public void TranslateObjectToAsset(UObject* Obj, UClass* TranslateClass, ref UObject* OutAsset)
    {
        Span<(string name, object value)> @params = [
            ("Obj", (IntPtr)Obj), 
            ("TranslateClass", (IntPtr)TranslateClass), 
            ("OutAsset", (IntPtr)OutAsset)
        ];
        ProcessEvent(GetFunction("TranslateObjectToAsset"), @params);
    }
    public void SetVisible(bool IsVisible)
    {
        Span<(string name, object value)> @params = [
            ("IsVisible", IsVisible)
        ];
        ProcessEvent(GetFunction("SetVisible"), @params);
    }
    public void SetItemVisible(int idx, bool IsVisible)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("IsVisible", IsVisible)
        ];
        ProcessEvent(GetFunction("SetItemVisible"), @params);
    }
    public void SetComponentBoolOff(bool isOff)
    {
        Span<(string name, object value)> @params = [
            ("isOff", isOff)
        ];
        ProcessEvent(GetFunction("SetComponentBoolOff"), @params);
    }
    public void SetCanvas(EBtlGuiCanvas Canvas)
    {
        Span<(string name, object value)> @params = [
            ("Canvas", Canvas)
        ];
        ProcessEvent(GetFunction("SetCanvas"), @params);
    }
    public void SetAryVisible(bool IsVisible)
    {
        Span<(string name, object value)> @params = [
            ("IsVisible", IsVisible)
        ];
        ProcessEvent(GetFunction("SetAryVisible"), @params);
    }
    public bool IsWindowsPlatform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsWindowsPlatform"), @params);
    }
    public bool IsNotUsingPS4PS5GuardYesNoKey(UBtlGuiDrawObjectSprite* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        return ProcessEvent<bool>(GetFunction("IsNotUsingPS4PS5GuardYesNoKey"), @params);
    }
    public bool GetVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetVisible"), @params);
    }
    public FVector2D GetViewportSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetViewportSize"), @params);
    }
    public UTextureRenderTarget2D* GetRenderTarget(EBtlGuiCanvas Canvas)
    {
        Span<(string name, object value)> @params = [
            ("Canvas", Canvas)
        ];
        return (UTextureRenderTarget2D*)ProcessEvent<IntPtr>(GetFunction("GetRenderTarget"), @params);
    }
    public void GetGroupDrawItem(int grpNo, ref TArray<int> idAry, ref TArray<IntPtr> objAry, bool Reverse)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("idAry", idAry), 
            ("objAry", objAry), 
            ("Reverse", Reverse)
        ];
        ProcessEvent(GetFunction("GetGroupDrawItem"), @params);
    }
    public void GetDrawItem(int ID, ref UBtlGuiDrawObjectCore* Obj)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID), 
            ("Obj", (IntPtr)Obj)
        ];
        ProcessEvent(GetFunction("GetDrawItem"), @params);
    }
    public void GetAllDrawItem(ref TArray<int> idAry, ref TArray<IntPtr> objAry)
    {
        Span<(string name, object value)> @params = [
            ("idAry", idAry), 
            ("objAry", objAry)
        ];
        ProcessEvent(GetFunction("GetAllDrawItem"), @params);
    }
    public UTexture* FrameBufferCapture(bool is2DCapture)
    {
        Span<(string name, object value)> @params = [
            ("is2DCapture", is2DCapture)
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("FrameBufferCapture"), @params);
    }
    public void DrawAtCanvas(EBtlGuiCanvas useCanvas)
    {
        Span<(string name, object value)> @params = [
            ("useCanvas", useCanvas)
        ];
        ProcessEvent(GetFunction("DrawAtCanvas"), @params);
    }
    public void Draw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Draw"), @params);
    }
    public void CreateDrawText(int grpNo, FBtlGuiDrawText Item, ref int outID, ref UBtlGuiDrawObjectText* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawText"), @params);
    }
    public void CreateDrawSprite(int grpNo, FBtlGuiDrawSprite Item, ref int outID, ref UBtlGuiDrawObjectSprite* outItem, bool onChangeByPlatform)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem), 
            ("onChangeByPlatform", onChangeByPlatform)
        ];
        ProcessEvent(GetFunction("CreateDrawSprite"), @params);
    }
    public void CreateDrawSilhouette(int grpNo, FBtlGuiDrawSilhouette Item, ref int outID, ref UBtlGuiDrawObjectSilhouette* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawSilhouette"), @params);
    }
    public void CreateDrawRoundRect(int grpNo, FBtlGuiDrawRoundRect Item, ref int outID, ref UBtlGuiDrawObjectRoundRect* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawRoundRect"), @params);
    }
    public void CreateDrawRect(int grpNo, FBtlGuiDrawRect Item, ref int outID, ref UBtlGuiDrawObjectRect* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawRect"), @params);
    }
    public void CreateDrawPrimitive(int grpNo, FBtlGuiDrawPrimitive Item, ref int outID, ref UBtlGuiDrawObjectPrimitive* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawPrimitive"), @params);
    }
    public void CreateDrawPlg(int grpNo, FBtlGuiDrawPlg Item, ref int outID, ref UBtlGuiDrawObjectPlg* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawPlg"), @params);
    }
    public void CreateDrawPanel(int grpNo, FBtlGuiDrawPanel Item, ref int outID, ref UBtlGuiDrawObjectPanel* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawPanel"), @params);
    }
    public void CreateDrawMsg(int grpNo, FBtlGuiDrawMsg Item, ref int outID, ref UBtlGuiDrawObjectMsg* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawMsg"), @params);
    }
    public void CreateDrawMaterial(int grpNo, FBtlGuiDrawMaterial Item, ref int outID, ref UBtlGuiDrawObjectMaterial* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawMaterial"), @params);
    }
    public void CreateDrawLineFrame(int grpNo, FBtlGuiDrawLineFrame Item, ref int outID, ref UBtlGuiDrawObjectLineFrame* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawLineFrame"), @params);
    }
    public void CreateDrawImageByStruct(int grpNo, FBtlGuiDrawImage Item, ref int outID, ref UBtlGuiDrawObjectImage* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Item", Item), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawImageByStruct"), @params);
    }
    public void CreateDrawImage(int grpNo, UTexture* Texture, FVector2D Pos, ref int outID, ref UBtlGuiDrawObjectImage* outItem)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("Texture", (IntPtr)Texture), 
            ("Pos", Pos), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem)
        ];
        ProcessEvent(GetFunction("CreateDrawImage"), @params);
    }
    public void ClearScreen(int grpNo, ref int outID, ref UBtlGuiDrawObjectClearScreen* outItem, FColor Color, EBtlGuiOT OT)
    {
        Span<(string name, object value)> @params = [
            ("grpNo", grpNo), 
            ("outID", outID), 
            ("outItem", (IntPtr)outItem), 
            ("Color", Color), 
            ("OT", OT)
        ];
        ProcessEvent(GetFunction("ClearScreen"), @params);
    }
    public void ClearDrawItem()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearDrawItem"), @params);
    }
    public void ClearCanvas(EBtlGuiCanvas Canvas, float Alpha, FBtlBlendState Bs)
    {
        Span<(string name, object value)> @params = [
            ("Canvas", Canvas), 
            ("Alpha", Alpha), 
            ("Bs", Bs)
        ];
        ProcessEvent(GetFunction("ClearCanvas"), @params);
    }
    public bool BtlGuiWorldToScreen2(FVector WorldPos, APlayerCameraManager* CameraManager, ref FVector2D outPos, ref float fZ, ACameraActor* CameraActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldPos", WorldPos), 
            ("CameraManager", (IntPtr)CameraManager), 
            ("outPos", outPos), 
            ("fZ", fZ), 
            ("CameraActor", (IntPtr)CameraActor)
        ];
        return ProcessEvent<bool>(GetFunction("BtlGuiWorldToScreen2"), @params);
    }
    public FVector2D BtlGuiWorldToScreen(FVector WorldPos, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldPos", WorldPos), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return ProcessEvent<FVector2D>(GetFunction("BtlGuiWorldToScreen"), @params);
    }
    public void BtlGuiSetDrawEnable(bool isEnable)
    {
        Span<(string name, object value)> @params = [
            ("isEnable", isEnable)
        ];
        ProcessEvent(GetFunction("BtlGuiSetDrawEnable"), @params);
    }
    public void BtlGuiCheckDrawEnable(ref bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("BtlGuiCheckDrawEnable"), @params);
    }
}

public unsafe class BtlEncountWipeLoader : ObjectBase<UBtlEncountWipeLoader>
{
    public BtlEncountWipeLoader(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlEncountWipeCore : ObjectBase<ABtlEncountWipeCore>
{
    public BtlEncountWipeCore(IntPtr pointer) : base(pointer) {}
    public void RequestEndWipe(UBtlCoreComponent* Core)
    {
        Span<(string name, object value)> @params = [
            ("Core", (IntPtr)Core)
        ];
        ProcessEvent(GetFunction("RequestEndWipe"), @params);
    }
    public void LoadResources()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadResources"), @params);
    }
    public EBtlEncountWipeType GetWipeType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlEncountWipeType>(GetFunction("GetWipeType"), @params);
    }
    public void ForceFadeIn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceFadeIn"), @params);
    }
    public void ClearResources()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearResources"), @params);
    }
    public bool CheckFadeInEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckFadeInEnd"), @params);
    }
    public ABtlEncountWipeCore* BtlEncountWipeGetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlEncountWipeCore*)ProcessEvent<IntPtr>(GetFunction("BtlEncountWipeGetInstance"), @params);
    }
    public void BtlEncountWipeDeleteInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlEncountWipeDeleteInstance"), @params);
    }
    public bool BtlEncountWipeCheckWraped()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("BtlEncountWipeCheckWraped"), @params);
    }
}

public unsafe class BtlGuiEncountWipe : ObjectBase<ABtlGuiEncountWipe>
{
    public BtlGuiEncountWipe(IntPtr pointer) : base(pointer) {}
    public void SetTransform(FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform)
        ];
        ProcessEvent(GetFunction("SetTransform"), @params);
    }
    public void SetCharacterVisible(bool Visible)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible)
        ];
        ProcessEvent(GetFunction("SetCharacterVisible"), @params);
    }
    public void SetCharacterAttackAnim()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetCharacterAttackAnim"), @params);
    }
    public UAppCharacterComp* GetCharacterComp()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAppCharacterComp*)ProcessEvent<IntPtr>(GetFunction("GetCharacterComp"), @params);
    }
    public float GetCharacterAnimTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCharacterAnimTime"), @params);
    }
    public void EndWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndWipe"), @params);
    }
}

public unsafe class BtlGuiPinchEncountWipe : ObjectBase<ABtlGuiPinchEncountWipe>
{
    public BtlGuiPinchEncountWipe(IntPtr pointer) : base(pointer) {}
    public void EndWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndWipe"), @params);
    }
}

public unsafe class BtlGuiEventEncountWipe : ObjectBase<ABtlGuiEventEncountWipe>
{
    public BtlGuiEventEncountWipe(IntPtr pointer) : base(pointer) {}
    public void EndWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndWipe"), @params);
    }
}

public unsafe class BtlGuiFBufferCapture : ObjectBase<ABtlGuiFBufferCapture>
{
    public BtlGuiFBufferCapture(IntPtr pointer) : base(pointer) {}
    public void SetWhiteOut(float WhiteOut)
    {
        Span<(string name, object value)> @params = [
            ("WhiteOut", WhiteOut)
        ];
        ProcessEvent(GetFunction("SetWhiteOut"), @params);
    }
    public void SetupBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupBP"), @params);
    }
    public void SetGrayScale(float GrayScale)
    {
        Span<(string name, object value)> @params = [
            ("GrayScale", GrayScale)
        ];
        ProcessEvent(GetFunction("SetGrayScale"), @params);
    }
    public void SetCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetCapture"), @params);
    }
    public void BtlFBufferCaptureStart(bool is2DCapture, bool isGrayScale, float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("is2DCapture", is2DCapture), 
            ("isGrayScale", isGrayScale), 
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("BtlFBufferCaptureStart"), @params);
    }
    public ABtlGuiFBufferCapture* BtlFBufferCaptureGetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlGuiFBufferCapture*)ProcessEvent<IntPtr>(GetFunction("BtlFBufferCaptureGetInstance"), @params);
    }
    public void BtlFBufferCaptureDrawEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlFBufferCaptureDrawEnd"), @params);
    }
    public void BtlFBufferCaptureDelete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlFBufferCaptureDelete"), @params);
    }
    public void BtlFBufferCaptureCreate2D(float GrayScale, float WhiteOut, float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("GrayScale", GrayScale), 
            ("WhiteOut", WhiteOut), 
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("BtlFBufferCaptureCreate2D"), @params);
    }
    public void BtlFBufferCaptureCreate(float GrayScale, float WhiteOut, float AnimTime)
    {
        Span<(string name, object value)> @params = [
            ("GrayScale", GrayScale), 
            ("WhiteOut", WhiteOut), 
            ("AnimTime", AnimTime)
        ];
        ProcessEvent(GetFunction("BtlFBufferCaptureCreate"), @params);
    }
}

public unsafe class BtlGuiIconComponent : ObjectBase<UBtlGuiIconComponent>
{
    public BtlGuiIconComponent(IntPtr pointer) : base(pointer) {}
    public void VisibleActionSuggestion(bool IsVisible)
    {
        Span<(string name, object value)> @params = [
            ("IsVisible", IsVisible)
        ];
        ProcessEvent(GetFunction("VisibleActionSuggestion"), @params);
    }
    public void UpdateParamPartyPanel_SP(int PlayerId, int Sp)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("Sp", Sp)
        ];
        ProcessEvent(GetFunction("UpdateParamPartyPanel_SP"), @params);
    }
    public void UpdateParamPartyPanel_HP(int PlayerId, int Hp)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("Hp", Hp)
        ];
        ProcessEvent(GetFunction("UpdateParamPartyPanel_HP"), @params);
    }
    public void StartEncountEffectForBP(bool IsPlayerAdvantage, float Time)
    {
        Span<(string name, object value)> @params = [
            ("IsPlayerAdvantage", IsPlayerAdvantage), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("StartEncountEffectForBP"), @params);
    }
    public void Start1MoreEffectForBP(bool IsEnemy, float Time)
    {
        Span<(string name, object value)> @params = [
            ("IsEnemy", IsEnemy), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("Start1MoreEffectForBP"), @params);
    }
    public void ShowFukaPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShowFukaPartyPanel"), @params);
    }
    public void SetVariableJyokyoHelp(UBtlGuiDrawObjectMsg* pMsg, int genus, int ID, int var1, int var2, int flags)
    {
        Span<(string name, object value)> @params = [
            ("pMsg", (IntPtr)pMsg), 
            ("genus", genus), 
            ("ID", ID), 
            ("var1", var1), 
            ("var2", var2), 
            ("flags", flags)
        ];
        ProcessEvent(GetFunction("SetVariableJyokyoHelp"), @params);
    }
    public void SetPartyPanelVisible(bool vidible, bool ResetAnimFlag)
    {
        Span<(string name, object value)> @params = [
            ("vidible", vidible), 
            ("ResetAnimFlag", ResetAnimFlag)
        ];
        ProcessEvent(GetFunction("SetPartyPanelVisible"), @params);
    }
    public void SetKeyHelpVisible(bool Visible, UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible), 
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("SetKeyHelpVisible"), @params);
    }
    public void SetKeyHelpOffset(EBtlGuiIconKeyHelp help, UBtlCoreComponent* BtlCore, bool noChange, bool disableParam)
    {
        Span<(string name, object value)> @params = [
            ("help", help), 
            ("BtlCore", (IntPtr)BtlCore), 
            ("noChange", noChange), 
            ("disableParam", disableParam)
        ];
        ProcessEvent(GetFunction("SetKeyHelpOffset"), @params);
    }
    public void SetCharacterPartyPanel(ABtlActor* ActiveActor, bool IsSkipAnim)
    {
        Span<(string name, object value)> @params = [
            ("ActiveActor", (IntPtr)ActiveActor), 
            ("IsSkipAnim", IsSkipAnim)
        ];
        ProcessEvent(GetFunction("SetCharacterPartyPanel"), @params);
    }
    public void RequestJyokyoHelpForBP(int genus, int ID, int msgNo, int var1, int var2, float renderTime, float DelayTime, bool forceOverride, int flags)
    {
        Span<(string name, object value)> @params = [
            ("genus", genus), 
            ("ID", ID), 
            ("msgNo", msgNo), 
            ("var1", var1), 
            ("var2", var2), 
            ("renderTime", renderTime), 
            ("DelayTime", DelayTime), 
            ("forceOverride", forceOverride), 
            ("flags", flags)
        ];
        ProcessEvent(GetFunction("RequestJyokyoHelpForBP"), @params);
    }
    public void RecoverPartyPanel_SP(int PlayerId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId)
        ];
        ProcessEvent(GetFunction("RecoverPartyPanel_SP"), @params);
    }
    public void RecoverPartyPanel_HP(int PlayerId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId)
        ];
        ProcessEvent(GetFunction("RecoverPartyPanel_HP"), @params);
    }
    public void RecoverPartyPanel_BadStatus(int PlayerId)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId)
        ];
        ProcessEvent(GetFunction("RecoverPartyPanel_BadStatus"), @params);
    }
    public bool LoadSyncPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("LoadSyncPartyPanel"), @params);
    }
    public UTexture* GetRenderTargets(int Num)
    {
        Span<(string name, object value)> @params = [
            ("Num", Num)
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetRenderTargets"), @params);
    }
    public void DisableCharacterPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisableCharacterPartyPanel"), @params);
    }
    public void DestroyPartyPanel()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyPartyPanel"), @params);
    }
    public void DestroyActionSuggestion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyActionSuggestion"), @params);
    }
    public void DamagePartyPanel(int PlayerId, bool isWeak)
    {
        Span<(string name, object value)> @params = [
            ("PlayerId", PlayerId), 
            ("isWeak", isWeak)
        ];
        ProcessEvent(GetFunction("DamagePartyPanel"), @params);
    }
    public void CreateTotalDamagePanelForBP(int Damage)
    {
        Span<(string name, object value)> @params = [
            ("Damage", Damage)
        ];
        ProcessEvent(GetFunction("CreateTotalDamagePanelForBP"), @params);
    }
    public void CreateSkillNamePanelForBP(EBtlCommandType Cmd, int ID, bool IsEnemy, float Time)
    {
        Span<(string name, object value)> @params = [
            ("Cmd", Cmd), 
            ("ID", ID), 
            ("IsEnemy", IsEnemy), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("CreateSkillNamePanelForBP"), @params);
    }
    public void CreatePartyPanel(float Scale, float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale), 
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("CreatePartyPanel"), @params);
    }
    public void CreateDamagePanelForBP(ref FBtlGuiIconDamage Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", Data)
        ];
        ProcessEvent(GetFunction("CreateDamagePanelForBP"), @params);
    }
    public void CreateActionSuggestion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateActionSuggestion"), @params);
    }
    public void ClearSkillNamePanelForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearSkillNamePanelForBP"), @params);
    }
    public void ClearKeyHelpOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearKeyHelpOffset"), @params);
    }
    public void ClearDamagePanelForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearDamagePanelForBP"), @params);
    }
    public bool CheckPartyPanelVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPartyPanelVisible"), @params);
    }
    public void CancelJyokyoHelpForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CancelJyokyoHelpForBP"), @params);
    }
    public void CallJyokyoHelpBroadcast()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallJyokyoHelpBroadcast"), @params);
    }
}

public unsafe class BtlGuiListComponent : ObjectBase<UBtlGuiListComponent>
{
    public BtlGuiListComponent(IntPtr pointer) : base(pointer) {}
    public void Update(ref int CursorIndex, ref int TopIndex, ref int CurrentIndex)
    {
        Span<(string name, object value)> @params = [
            ("CursorIndex", CursorIndex), 
            ("TopIndex", TopIndex), 
            ("CurrentIndex", CurrentIndex)
        ];
        ProcessEvent(GetFunction("Update"), @params);
    }
    public void SetScrollBarData(float PosY, float ScrollRange, float CenterPosY)
    {
        Span<(string name, object value)> @params = [
            ("PosY", PosY), 
            ("ScrollRange", ScrollRange), 
            ("CenterPosY", CenterPosY)
        ];
        ProcessEvent(GetFunction("SetScrollBarData"), @params);
    }
    public void SetCursor(int CurrentIndex)
    {
        Span<(string name, object value)> @params = [
            ("CurrentIndex", CurrentIndex)
        ];
        ProcessEvent(GetFunction("SetCursor"), @params);
    }
    public void Init(int ItemDtarMin, int ItemDtarMax, int itemNum, EBtlListScreenID screenID, int CursorIdx, int ListTopIdx, int MoveType)
    {
        Span<(string name, object value)> @params = [
            ("ItemDtarMin", ItemDtarMin), 
            ("ItemDtarMax", ItemDtarMax), 
            ("itemNum", itemNum), 
            ("screenID", screenID), 
            ("CursorIdx", CursorIdx), 
            ("ListTopIdx", ListTopIdx), 
            ("MoveType", MoveType)
        ];
        ProcessEvent(GetFunction("Init"), @params);
    }
    public void GetCursor(ref int CursorIndex, ref int TopIndex, ref int CurrentIndex)
    {
        Span<(string name, object value)> @params = [
            ("CursorIndex", CursorIndex), 
            ("TopIndex", TopIndex), 
            ("CurrentIndex", CurrentIndex)
        ];
        ProcessEvent(GetFunction("GetCursor"), @params);
    }
}

public unsafe class BtlGuiPersonaStatusComponent : ObjectBase<UBtlGuiPersonaStatusComponent>
{
    public BtlGuiPersonaStatusComponent(IntPtr pointer) : base(pointer) {}
    public void UpdatePersonaStatus(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdatePersonaStatus"), @params);
    }
    public void StartPersonaSkillHelp()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPersonaSkillHelp"), @params);
    }
    public void StartPersonaCommentary()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPersonaCommentary"), @params);
    }
    public void SetEquipPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetEquipPersona"), @params);
    }
    public bool IsEndPersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEndPersonaStatus"), @params);
    }
    public int GetPersonaStockCount(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        return ProcessEvent<int>(GetFunction("GetPersonaStockCount"), @params);
    }
    public ABtlActor* GetDispActor(UBtlCoreComponent* pCore)
    {
        Span<(string name, object value)> @params = [
            ("pCore", (IntPtr)pCore)
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetDispActor"), @params);
    }
    public void DeleteInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeleteInstance"), @params);
    }
    public void CreatePersonaStatusTargetSelect(ABtlActor* Actor, UBtlCoreComponent* pCore, TArray<IntPtr> PlayerList)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("pCore", (IntPtr)pCore), 
            ("PlayerList", PlayerList)
        ];
        ProcessEvent(GetFunction("CreatePersonaStatusTargetSelect"), @params);
    }
    public void CreatePersonaStatus(ABtlActor* Actor, UBtlCoreComponent* pCore, int CurrentNum, bool AlwaysChange)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("pCore", (IntPtr)pCore), 
            ("CurrentNum", CurrentNum), 
            ("AlwaysChange", AlwaysChange)
        ];
        ProcessEvent(GetFunction("CreatePersonaStatus"), @params);
    }
    public void CreateInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateInstance"), @params);
    }
    public void ClosePersonaStatus(UBtlCoreComponent* pCore)
    {
        Span<(string name, object value)> @params = [
            ("pCore", (IntPtr)pCore)
        ];
        ProcessEvent(GetFunction("ClosePersonaStatus"), @params);
    }
    public bool CheckPersonaSkillHelp()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaSkillHelp"), @params);
    }
    public bool CheckPersonaCommentary()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaCommentary"), @params);
    }
    public bool CheckPersonaChange()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaChange"), @params);
    }
    public void ChangePersonaStatusRightActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangePersonaStatusRightActor"), @params);
    }
    public bool ChangePersonaStatusRight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ChangePersonaStatusRight"), @params);
    }
    public void ChangePersonaStatusLeftActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangePersonaStatusLeftActor"), @params);
    }
    public bool ChangePersonaStatusLeft()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ChangePersonaStatusLeft"), @params);
    }
}

public unsafe class BtlGuiPromiseComponent : ObjectBase<UBtlGuiPromiseComponent>
{
    public BtlGuiPromiseComponent(IntPtr pointer) : base(pointer) {}
    public void StopSupportInfo(UBtlCoreComponent* BtlCore)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore)
        ];
        ProcessEvent(GetFunction("StopSupportInfo"), @params);
    }
    public void StartSupportInfo(UBtlCoreComponent* BtlCore, bool isGeneral, int msgNo)
    {
        Span<(string name, object value)> @params = [
            ("BtlCore", (IntPtr)BtlCore), 
            ("isGeneral", isGeneral), 
            ("msgNo", msgNo)
        ];
        ProcessEvent(GetFunction("StartSupportInfo"), @params);
    }
    public bool CheckMsgStart()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckMsgStart"), @params);
    }
}

public unsafe class BtlGuiResourcesBase : ObjectBase<ABtlGuiResourcesBase>
{
    public BtlGuiResourcesBase(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlGuiResourcesActor : ObjectBase<ABtlGuiResourcesActor>
{
    public BtlGuiResourcesActor(IntPtr pointer) : base(pointer) {}
    public void RequestAddResources(FString ResourcesPath)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesPath", ResourcesPath)
        ];
        ProcessEvent(GetFunction("RequestAddResources"), @params);
    }
    public void InitializeTopLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTopLayoutData"), @params);
    }
    public void InitializeTheurgiaTextLayoutData(UDataTable* textData, UDataTable* textRowData, UDataTable* textPosData)
    {
        Span<(string name, object value)> @params = [
            ("textData", (IntPtr)textData), 
            ("textRowData", (IntPtr)textRowData), 
            ("textPosData", (IntPtr)textPosData)
        ];
        ProcessEvent(GetFunction("InitializeTheurgiaTextLayoutData"), @params);
    }
    public void InitializeTheurgiaLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTheurgiaLayoutData"), @params);
    }
    public void InitializeTargetInfoTextLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTargetInfoTextLayoutData"), @params);
    }
    public void InitializeTargetInfoLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTargetInfoLayoutData"), @params);
    }
    public void InitializeTacticsListTextLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTacticsListTextLayoutData"), @params);
    }
    public void InitializeTacticsLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeTacticsLayoutData"), @params);
    }
    public void InitializeRushLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeRushLayoutData"), @params);
    }
    public void InitializePromiseLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializePromiseLayoutData"), @params);
    }
    public void InitializeOthersLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeOthersLayoutData"), @params);
    }
    public void InitializeItemSkillListTextLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeItemSkillListTextLayoutData"), @params);
    }
    public void InitializeGuardLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeGuardLayoutData"), @params);
    }
    public void InitializeDamageIconLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeDamageIconLayoutData"), @params);
    }
    public void InitializeBattleTouchCollLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeBattleTouchCollLayoutData"), @params);
    }
    public void InitializeAnalyzeTextLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeAnalyzeTextLayoutData"), @params);
    }
    public void InitializeAnalyzeLayoutData(UDataTable* Data)
    {
        Span<(string name, object value)> @params = [
            ("Data", (IntPtr)Data)
        ];
        ProcessEvent(GetFunction("InitializeAnalyzeLayoutData"), @params);
    }
    public UObject* GetResources(FName Name)
    {
        Span<(string name, object value)> @params = [
            ("Name", Name)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetResources"), @params);
    }
    public UObject* GetAddResources()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetAddResources"), @params);
    }
    public void CallDelegate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallDelegate"), @params);
    }
}

public unsafe class BtlGuiResourcesLoadWatcher : ObjectBase<ABtlGuiResourcesLoadWatcher>
{
    public BtlGuiResourcesLoadWatcher(IntPtr pointer) : base(pointer) {}
    public void LoadStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadStart"), @params);
    }
}

public unsafe class BtlGuiResources : ObjectBase<UBtlGuiResources>
{
    public BtlGuiResources(IntPtr pointer) : base(pointer) {}
    public void SetResourcesActor(ABtlGuiResourcesActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetResourcesActor"), @params);
    }
    public void SetAsyncLoadCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetAsyncLoadCompleted"), @params);
    }
    public void RequestAddResources(FString ResourcesPath)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesPath", ResourcesPath)
        ];
        ProcessEvent(GetFunction("RequestAddResources"), @params);
    }
    public void LoadEndAction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadEndAction"), @params);
    }
    public void InitializeLayoutDebugMenu(ABtlGuiStateManager* StateManager)
    {
        Span<(string name, object value)> @params = [
            ("StateManager", (IntPtr)StateManager)
        ];
        ProcessEvent(GetFunction("InitializeLayoutDebugMenu"), @params);
    }
    public void GetTouchCollData(EBtlTouchCollisionLayout LayoutId, ref float PosX, ref float PosY, ref float Angle, ref float Width, ref float Height)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId), 
            ("PosX", PosX), 
            ("PosY", PosY), 
            ("Angle", Angle), 
            ("Width", Width), 
            ("Height", Height)
        ];
        ProcessEvent(GetFunction("GetTouchCollData"), @params);
    }
    public FVector2D GetTopAdjustedPosition(EBtlTopLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTopAdjustedPosition"), @params);
    }
    public FVector2D GetTheurgiaTextTextCollition(EUITheurgiaTextLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTheurgiaTextTextCollition"), @params);
    }
    public int GetTheurgiaTextRow(EUITheurgiaTextRowLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<int>(GetFunction("GetTheurgiaTextRow"), @params);
    }
    public FVector2D GetTheurgiaTextPos(EUITheurgiaTextPosLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTheurgiaTextPos"), @params);
    }
    public FVector2D GetTheurgiaAdjustedPosition(EBtlTheurgiaLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTheurgiaAdjustedPosition"), @params);
    }
    public FVector2D GetTargetInfoTextCollision(EBtlTargetInfoTextLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTargetInfoTextCollision"), @params);
    }
    public FVector2D GetTacticsTextCollision(EBtlTacticsListTextLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTacticsTextCollision"), @params);
    }
    public FVector2D GetTacticsCheckAdjustedPosition(EBtlTacticsCheckLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTacticsCheckAdjustedPosition"), @params);
    }
    public FVector2D GetTacticsAdjustedPosition(EBtlTacticsLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTacticsAdjustedPosition"), @params);
    }
    public FVector2D GetRushAdjustedPosition(EBtlRushLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetRushAdjustedPosition"), @params);
    }
    public void GetResourcesPure(FName ResourcesName, UClass* ResourcesClass, ref UObject* OutResources)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesName", ResourcesName), 
            ("ResourcesClass", (IntPtr)ResourcesClass), 
            ("OutResources", (IntPtr)OutResources)
        ];
        ProcessEvent(GetFunction("GetResourcesPure"), @params);
    }
    public void GetResources(FName ResourcesName, UClass* ResourcesClass, ref UObject* OutResources)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesName", ResourcesName), 
            ("ResourcesClass", (IntPtr)ResourcesClass), 
            ("OutResources", (IntPtr)OutResources)
        ];
        ProcessEvent(GetFunction("GetResources"), @params);
    }
    public FVector2D GetPromiseAdjustedPosition(EBtlPromiseLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetPromiseAdjustedPosition"), @params);
    }
    public FVector2D GetOthersAdjustedPosition(EBtlOthersLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetOthersAdjustedPosition"), @params);
    }
    public USprAsset* GetKeyHelpSpr()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetKeyHelpSpr"), @params);
    }
    public FVector GetItemSkillListTextCollision(EBtlItemSkillListTextLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector>(GetFunction("GetItemSkillListTextCollision"), @params);
    }
    public USprAsset* GetItemIconSpr()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetItemIconSpr"), @params);
    }
    public FVector2D GetGuardAdjustedPosition(EBtlGuardLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetGuardAdjustedPosition"), @params);
    }
    public FVector2D GetDamageIconAdjustedPosition(EBtlDamageIconLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetDamageIconAdjustedPosition"), @params);
    }
    public USprAsset* GetCampSpr()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetCampSpr"), @params);
    }
    public UTextureRenderTarget2D* GetAppRenderTarget(int Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return (UTextureRenderTarget2D*)ProcessEvent<IntPtr>(GetFunction("GetAppRenderTarget"), @params);
    }
    public FVector2D GetAnalyzeTextTextCollition(EBtlAnalyzeTextLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAnalyzeTextTextCollition"), @params);
    }
    public FVector2D GetAnalyzeAdjustedPosition(EBtlAnalyzeLayout LayoutId)
    {
        Span<(string name, object value)> @params = [
            ("LayoutId", LayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAnalyzeAdjustedPosition"), @params);
    }
    public void GetAddResourcesPure(UClass* ResourcesClass, ref UObject* OutResources)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesClass", (IntPtr)ResourcesClass), 
            ("OutResources", (IntPtr)OutResources)
        ];
        ProcessEvent(GetFunction("GetAddResourcesPure"), @params);
    }
    public void GetAddResources(UClass* ResourcesClass, ref UObject* OutResources)
    {
        Span<(string name, object value)> @params = [
            ("ResourcesClass", (IntPtr)ResourcesClass), 
            ("OutResources", (IntPtr)OutResources)
        ];
        ProcessEvent(GetFunction("GetAddResources"), @params);
    }
    public bool CheckBtlResourcesCompleted()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBtlResourcesCompleted"), @params);
    }
    public void BtlGuiResourcesDestroy()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlGuiResourcesDestroy"), @params);
    }
    public ABtlGuiResourcesBase* BtlGuiResourcesCreate()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlGuiResourcesBase*)ProcessEvent<IntPtr>(GetFunction("BtlGuiResourcesCreate"), @params);
    }
}

public unsafe class BtlGuiRushEffect : ObjectBase<ABtlGuiRushEffect>
{
    public BtlGuiRushEffect(IntPtr pointer) : base(pointer) {}
    public void SetOT(int OT)
    {
        Span<(string name, object value)> @params = [
            ("OT", OT)
        ];
        ProcessEvent(GetFunction("SetOT"), @params);
    }
    public void SetEffect(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("SetEffect"), @params);
    }
    public void SetBtlFlag(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetBtlFlag"), @params);
    }
    public void SetAppCanvas(int appCanvas)
    {
        Span<(string name, object value)> @params = [
            ("appCanvas", appCanvas)
        ];
        ProcessEvent(GetFunction("SetAppCanvas"), @params);
    }
    public void AnimationPause(bool Pause)
    {
        Span<(string name, object value)> @params = [
            ("Pause", Pause)
        ];
        ProcessEvent(GetFunction("AnimationPause"), @params);
    }
}

public unsafe class EventSkipEffect : ObjectBase<AEventSkipEffect>
{
    public EventSkipEffect(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlGuiStateManager : ObjectBase<ABtlGuiStateManager>
{
    public BtlGuiStateManager(IntPtr pointer) : base(pointer) {}
    public void UpdateLayoutDebugMenu()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UpdateLayoutDebugMenu"), @params);
    }
    public void SetState(EBtlGuiState State, bool sendFlag, int sendNumber)
    {
        Span<(string name, object value)> @params = [
            ("State", State), 
            ("sendFlag", sendFlag), 
            ("sendNumber", sendNumber)
        ];
        ProcessEvent(GetFunction("SetState"), @params);
    }
    public void SetPrevState(EBtlGuiState State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        ProcessEvent(GetFunction("SetPrevState"), @params);
    }
    public void ResetPrevState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetPrevState"), @params);
    }
    public bool OnDebugRushStopMaskVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnDebugRushStopMaskVisible"), @params);
    }
    public bool OnDebugRushStopMaskAnimPause()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnDebugRushStopMaskAnimPause"), @params);
    }
    public bool OnDebugRushDraw()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnDebugRushDraw"), @params);
    }
    public bool IsLayoutDebugMenuOpen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLayoutDebugMenuOpen"), @params);
    }
    public EBtlGuiState GetState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlGuiState>(GetFunction("GetState"), @params);
    }
    public EBtlGuiState GetPrevState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlGuiState>(GetFunction("GetPrevState"), @params);
    }
    public int GetDebugSkillNamePanelID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDebugSkillNamePanelID"), @params);
    }
    public int GetDebugJyokyoHelpID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDebugJyokyoHelpID"), @params);
    }
    public int GetDebugDamageTextIdx()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDebugDamageTextIdx"), @params);
    }
    public void ClearState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearState"), @params);
    }
    public void ChangePrevState(bool sendFlag, int sendNumber)
    {
        Span<(string name, object value)> @params = [
            ("sendFlag", sendFlag), 
            ("sendNumber", sendNumber)
        ];
        ProcessEvent(GetFunction("ChangePrevState"), @params);
    }
}

public unsafe class BtlInputComponent : ObjectBase<UBtlInputComponent>
{
    public BtlInputComponent(IntPtr pointer) : base(pointer) {}
    public void RemoveTouchCollCallback()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveTouchCollCallback"), @params);
    }
    public void CallInputTrigKeyboard(EBtlInputKeyboardEnum Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        ProcessEvent(GetFunction("CallInputTrigKeyboard"), @params);
    }
    public void BtlInputSetCtrlEnable(bool isEnable)
    {
        Span<(string name, object value)> @params = [
            ("isEnable", isEnable)
        ];
        ProcessEvent(GetFunction("BtlInputSetCtrlEnable"), @params);
    }
    public void BtlInputSetComponentEnable(bool isEnable)
    {
        Span<(string name, object value)> @params = [
            ("isEnable", isEnable)
        ];
        ProcessEvent(GetFunction("BtlInputSetComponentEnable"), @params);
    }
    public void BtlInputKeyLockClear()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlInputKeyLockClear"), @params);
    }
    public void BtlInputKeyLock(TArray<EBtlInputKeyboardEnum> lockKey)
    {
        Span<(string name, object value)> @params = [
            ("lockKey", lockKey)
        ];
        ProcessEvent(GetFunction("BtlInputKeyLock"), @params);
    }
    public void BtlInputCheckCtrlEnable(ref bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("BtlInputCheckCtrlEnable"), @params);
    }
    public void BtlInputCheckComponentEnable(ref bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("BtlInputCheckComponentEnable"), @params);
    }
    public void BtlInputAlwaysEnable(bool isEnable)
    {
        Span<(string name, object value)> @params = [
            ("isEnable", isEnable)
        ];
        ProcessEvent(GetFunction("BtlInputAlwaysEnable"), @params);
    }
    public void AddTouchCollCallback()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AddTouchCollCallback"), @params);
    }
}

public unsafe class BtlManager : ObjectBase<ABtlManager>
{
    public BtlManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlControlBase : ObjectBase<ABtlControlBase>
{
    public BtlControlBase(IntPtr pointer) : base(pointer) {}
    public bool SyncBattleFinish()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncBattleFinish"), @params);
    }
    public void SetGamePaused(int IsPause)
    {
        Span<(string name, object value)> @params = [
            ("IsPause", IsPause)
        ];
        ProcessEvent(GetFunction("SetGamePaused"), @params);
    }
    public bool PreLoad(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        return ProcessEvent<bool>(GetFunction("PreLoad"), @params);
    }
    public void Encount(ref FBtlEncountParam EncountParam)
    {
        Span<(string name, object value)> @params = [
            ("EncountParam", EncountParam)
        ];
        ProcessEvent(GetFunction("Encount"), @params);
    }
    public void DestroyLoadedData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DestroyLoadedData"), @params);
    }
    public bool CheckBattleInProgress()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckBattleInProgress"), @params);
    }
}

public unsafe class BtlOrder : ObjectBase<UBtlOrder>
{
    public BtlOrder(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlPerformanceMonitor : ObjectBase<ABtlPerformanceMonitor>
{
    public BtlPerformanceMonitor(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlPhase : ObjectBase<ABtlPhase>
{
    public BtlPhase(IntPtr pointer) : base(pointer) {}
    public bool SyncProgressTimingInBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("SyncProgressTimingInBP"), @params);
    }
    public void StartPhaseInBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPhaseInBP"), @params);
    }
    public void StartPhase()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPhase"), @params);
    }
    public void SetNowBattlePhaseName(EBattlePhaseName newPhaseName)
    {
        Span<(string name, object value)> @params = [
            ("newPhaseName", newPhaseName)
        ];
        ProcessEvent(GetFunction("SetNowBattlePhaseName"), @params);
    }
    public ABtlPhase* GetNextPhaseInBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlPhase*)ProcessEvent<IntPtr>(GetFunction("GetNextPhaseInBP"), @params);
    }
    public ABtlPhase* GetNextPhase()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlPhase*)ProcessEvent<IntPtr>(GetFunction("GetNextPhase"), @params);
    }
    public void FinalizePhaseInBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinalizePhaseInBP"), @params);
    }
    public void FinalizePhase()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FinalizePhase"), @params);
    }
    public ABtlPhase* CreateNextPhase(EBtlPhaseType phase)
    {
        Span<(string name, object value)> @params = [
            ("phase", phase)
        ];
        return (ABtlPhase*)ProcessEvent<IntPtr>(GetFunction("CreateNextPhase"), @params);
    }
    public bool CheckProgressNextPhaseInBP()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckProgressNextPhaseInBP"), @params);
    }
}

public unsafe class BtlPhaseVictory : ObjectBase<ABtlPhaseVictory>
{
    public BtlPhaseVictory(IntPtr pointer) : base(pointer) {}
    public void SetResultType(EBtlResultType resulttype)
    {
        Span<(string name, object value)> @params = [
            ("resulttype", resulttype)
        ];
        ProcessEvent(GetFunction("SetResultType"), @params);
    }
    public EBtlResultType GetResultType()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlResultType>(GetFunction("GetResultType"), @params);
    }
}

public unsafe class BtlPhaseResult : ObjectBase<ABtlPhaseResult>
{
    public BtlPhaseResult(IntPtr pointer) : base(pointer) {}
    public void SetStartResultInVictory(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetStartResultInVictory"), @params);
    }
    public void SetHaveVictorySequence(bool flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("SetHaveVictorySequence"), @params);
    }
    public void ReleaseResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReleaseResource"), @params);
    }
    public void PlayResultUI()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayResultUI"), @params);
    }
    public void CreatePhaseVictory()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreatePhaseVictory"), @params);
    }
    public bool CheckAlreadyStartResult()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAlreadyStartResult"), @params);
    }
}

public unsafe class BtlResidentDataBase : ObjectBase<UBtlResidentDataBase>
{
    public BtlResidentDataBase(IntPtr pointer) : base(pointer) {}
    public void LoadAsync()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadAsync"), @params);
    }
    public UNiagaraSystem* GetEffect(EBtlResidentResource Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return (UNiagaraSystem*)ProcessEvent<IntPtr>(GetFunction("GetEffect"), @params);
    }
    public bool CheckLoaded(EBtlResidentResource Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<bool>(GetFunction("CheckLoaded"), @params);
    }
}

public unsafe class BtlResultResourceManager : ObjectBase<ABtlResultResourceManager>
{
    public BtlResultResourceManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlResultSceneBase : ObjectBase<ABtlResultSceneBase>
{
    public BtlResultSceneBase(IntPtr pointer) : base(pointer) {}
    public void StartEntryScene()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartEntryScene"), @params);
    }
    public void ReleaseResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReleaseResource"), @params);
    }
    public void LoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadResource"), @params);
    }
    public bool CheckEndEntryScene()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEndEntryScene"), @params);
    }
    public bool CheckCompleteLoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckCompleteLoadResource"), @params);
    }
}

public unsafe class BtlResultUIBase : ObjectBase<ABtlResultUIBase>
{
    public BtlResultUIBase(IntPtr pointer) : base(pointer) {}
    public void UpdatePersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UpdatePersonaStatus"), @params);
    }
    public void StartResultUI(UBtlResultViewData* InViewData)
    {
        Span<(string name, object value)> @params = [
            ("InViewData", (IntPtr)InViewData)
        ];
        ProcessEvent(GetFunction("StartResultUI"), @params);
    }
    public void StartPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartPersona"), @params);
    }
    public void StartHeroStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartHeroStatus"), @params);
    }
    public void ReleaseResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReleaseResource"), @params);
    }
    public void PrevDebugPersonaTexutreID()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrevDebugPersonaTexutreID"), @params);
    }
    public void ObtainItems()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ObtainItems"), @params);
    }
    public void NextDebugPersonaTexutreID()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NextDebugPersonaTexutreID"), @params);
    }
    public void LoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadResource"), @params);
    }
    public bool IsLayoutDebugMenuOpen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLayoutDebugMenuOpen"), @params);
    }
    public bool IsDrawComma(int digCount)
    {
        Span<(string name, object value)> @params = [
            ("digCount", digCount)
        ];
        return ProcessEvent<bool>(GetFunction("IsDrawComma"), @params);
    }
    public bool InputTrigDecideButton()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InputTrigDecideButton"), @params);
    }
    public bool InputRepRUButton()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InputRepRUButton"), @params);
    }
    public bool InputDebugButtonR()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InputDebugButtonR"), @params);
    }
    public bool InputDebugButtonL()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InputDebugButtonL"), @params);
    }
    public bool InputDebugButton()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("InputDebugButton"), @params);
    }
    public FVector2D GetTextCollision(EBtlResultTextLayout InLayoutId)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetTextCollision"), @params);
    }
    public USprAsset* GetSprAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetSprAsset"), @params);
    }
    public UBmdAsset* GetResultBmd()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBmdAsset*)ProcessEvent<IntPtr>(GetFunction("GetResultBmd"), @params);
    }
    public TArray<FBtlResultPersonaParam> GetPersonaLevelupParam()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FBtlResultPersonaParam>>(GetFunction("GetPersonaLevelupParam"), @params);
    }
    public FVector2D GetOkNextLayoutPosition(EOkNextLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetOkNextLayoutPosition"), @params);
    }
    public TArray<FBtlResultItemParam> GetItemParams()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FBtlResultItemParam>>(GetFunction("GetItemParams"), @params);
    }
    public int GetItemMsgID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetItemMsgID"), @params);
    }
    public FBtlResultHeroInfo GetHeroInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBtlResultHeroInfo>(GetFunction("GetHeroInfo"), @params);
    }
    public void GetHeroHumanLvupParam(ref bool isLvup, ref int Level)
    {
        Span<(string name, object value)> @params = [
            ("isLvup", isLvup), 
            ("Level", Level)
        ];
        ProcessEvent(GetFunction("GetHeroHumanLvupParam"), @params);
    }
    public UTexture* GetEquipPersonaTexture()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetEquipPersonaTexture"), @params);
    }
    public int GetDebugPersonaTexutreID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetDebugPersonaTexutreID"), @params);
    }
    public TArray<FBtlResultAllyLvupParam> GetAllyLevelupParam()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<FBtlResultAllyLvupParam>>(GetFunction("GetAllyLevelupParam"), @params);
    }
    public FVector2D GetAdjustedLayoutPosition(EBtlResultLayout InLayoutId, FVector2D InDefaultPos)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId), 
            ("InDefaultPos", InDefaultPos)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAdjustedLayoutPosition"), @params);
    }
    public void DrawMsg(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("DrawMsg"), @params);
    }
    public void CreateMsg()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateMsg"), @params);
    }
    public int ConvertItemSprID(int ItemId)
    {
        Span<(string name, object value)> @params = [
            ("ItemId", ItemId)
        ];
        return ProcessEvent<int>(GetFunction("ConvertItemSprID"), @params);
    }
    public void CloseMsg()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseMsg"), @params);
    }
    public void CloseHeroStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseHeroStatus"), @params);
    }
    public bool CheckSKillGetPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckSKillGetPersona"), @params);
    }
    public bool CheckShowMsg(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowMsg"), @params);
    }
    public bool CheckPersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckPersonaStatus"), @params);
    }
    public bool CheckHeroStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckHeroStatus"), @params);
    }
    public bool CheckEndResultUI()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEndResultUI"), @params);
    }
    public bool CheckCompleteLoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckCompleteLoadResource"), @params);
    }
    public EBtlResultHeroPersonaUpEvent CalcStockUp()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EBtlResultHeroPersonaUpEvent>(GetFunction("CalcStockUp"), @params);
    }
}

public unsafe class BtlResultViewData : ObjectBase<UBtlResultViewData>
{
    public BtlResultViewData(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlScriptCommandEventBattle : ObjectBase<ABtlScriptCommandEventBattle>
{
    public BtlScriptCommandEventBattle(IntPtr pointer) : base(pointer) {}
    public void FieldBattleWait()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattleWait"), @params);
    }
    public void FieldBattleSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattleSetup"), @params);
    }
    public void FieldBattlePlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattlePlay"), @params);
    }
    public void FieldBattleLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattleLoad"), @params);
    }
    public void FieldBattleInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattleInit"), @params);
    }
    public void FieldBattleEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FieldBattleEnd"), @params);
    }
    public void EventBattleWait()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleWait"), @params);
    }
    public void EventBattleSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleSetup"), @params);
    }
    public void EventBattlePlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattlePlay"), @params);
    }
    public void EventBattleLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleLoad"), @params);
    }
    public void EventBattleInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleInit"), @params);
    }
    public void EventBattleEventWait()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleEventWait"), @params);
    }
    public void EventBattleEventInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleEventInit"), @params);
    }
    public void EventBattleEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EventBattleEnd"), @params);
    }
}

public unsafe class BtlSequencerObserve : ObjectBase<ABtlSequencerObserve>
{
    public BtlSequencerObserve(IntPtr pointer) : base(pointer) {}
    public void SetParam(ALevelSequenceActor* InSequenceActor, bool InStart)
    {
        Span<(string name, object value)> @params = [
            ("InSequenceActor", (IntPtr)InSequenceActor), 
            ("InStart", InStart)
        ];
        ProcessEvent(GetFunction("SetParam"), @params);
    }
}

public unsafe class BtlShakeManager : ObjectBase<ABtlShakeManager>
{
    public BtlShakeManager(IntPtr pointer) : base(pointer) {}
    public void BtlShakeStop(APlayerController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Controller", (IntPtr)Controller)
        ];
        ProcessEvent(GetFunction("BtlShakeStop"), @params);
    }
    public void BtlShakePlay(EBtlShakeType Type, float PlayTime, APlayerController* Controller)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("PlayTime", PlayTime), 
            ("Controller", (IntPtr)Controller)
        ];
        ProcessEvent(GetFunction("BtlShakePlay"), @params);
    }
    public ABtlShakeManager* BtlShakeManagerGetInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlShakeManager*)ProcessEvent<IntPtr>(GetFunction("BtlShakeManagerGetInstance"), @params);
    }
}

public unsafe class BtlShuffleArcanaManager : ObjectBase<ABtlShuffleArcanaManager>
{
    public BtlShuffleArcanaManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlShuffleMainBase : ObjectBase<ABtlShuffleMainBase>
{
    public BtlShuffleMainBase(IntPtr pointer) : base(pointer) {}
    public void UpdateCardRotation(float DeltaTime, int idx)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("UpdateCardRotation"), @params);
    }
    public void StartMsg(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        ProcessEvent(GetFunction("StartMsg"), @params);
    }
    public void StartLoadCardResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartLoadCardResource"), @params);
    }
    public void StartingCardSelect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartingCardSelect"), @params);
    }
    public void SetTouchCollision(int Index, float X, float Y, float Width, float Height, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("SetTouchCollision"), @params);
    }
    public void SetPosPersonaList(FVector2D InPos)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos)
        ];
        ProcessEvent(GetFunction("SetPosPersonaList"), @params);
    }
    public void SetPersonaSkillHelp(bool use)
    {
        Span<(string name, object value)> @params = [
            ("use", use)
        ];
        ProcessEvent(GetFunction("SetPersonaSkillHelp"), @params);
    }
    public void SetMsgVariableSelectCard(UBtlGuiDrawObjectMsg* pMsg, int idx, int PersonaID, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("pMsg", (IntPtr)pMsg), 
            ("idx", idx), 
            ("PersonaID", PersonaID), 
            ("isBonusCard", isBonusCard)
        ];
        ProcessEvent(GetFunction("SetMsgVariableSelectCard"), @params);
    }
    public void SetKeyHelp(EBtlShuffleKeyHelpState State)
    {
        Span<(string name, object value)> @params = [
            ("State", State)
        ];
        ProcessEvent(GetFunction("SetKeyHelp"), @params);
    }
    public void SetEndPersonaListInFlag(bool Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetEndPersonaListInFlag"), @params);
    }
    public void SetEndCardInAnime(bool Input)
    {
        Span<(string name, object value)> @params = [
            ("Input", Input)
        ];
        ProcessEvent(GetFunction("SetEndCardInAnime"), @params);
    }
    public void SetEndArcanaBurstInFlag(bool Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetEndArcanaBurstInFlag"), @params);
    }
    public void SetBmdValue(UBtlGuiDrawObjectMsg* pMsg, FString value1, FString value2, FString value3, FString value4)
    {
        Span<(string name, object value)> @params = [
            ("pMsg", (IntPtr)pMsg), 
            ("value1", value1), 
            ("value2", value2), 
            ("value3", value3), 
            ("value4", value4)
        ];
        ProcessEvent(GetFunction("SetBmdValue"), @params);
    }
    public void SetAlphaPersonaList(float Alpha)
    {
        Span<(string name, object value)> @params = [
            ("Alpha", Alpha)
        ];
        ProcessEvent(GetFunction("SetAlphaPersonaList"), @params);
    }
    public void SecondTextCardInStateEffect(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("SecondTextCardInStateEffect"), @params);
    }
    public void RunStateSelectPersona(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateSelectPersona"), @params);
    }
    public void RunStateSelectCardAllGetBonus(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateSelectCardAllGetBonus"), @params);
    }
    public void RunStateSelectCard(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateSelectCard"), @params);
    }
    public void RunStateExit(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateExit"), @params);
    }
    public void RunStateEnter(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateEnter"), @params);
    }
    public void RunStateEffectCard(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateEffectCard"), @params);
    }
    public void RunStateEffectAllGetBonus(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateEffectAllGetBonus"), @params);
    }
    public void RunStateAllGetBonus(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("RunStateAllGetBonus"), @params);
    }
    public void ReleaseTutorialStopper()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReleaseTutorialStopper"), @params);
    }
    public void ReleaseResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReleaseResource"), @params);
    }
    public void PrepareStateSelectPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateSelectPersona"), @params);
    }
    public void PrepareStateSelectCardAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateSelectCardAllGetBonus"), @params);
    }
    public void PrepareStateSelectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateSelectCard"), @params);
    }
    public void PrepareStateExit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateExit"), @params);
    }
    public void PrepareStateEnter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateEnter"), @params);
    }
    public void PrepareStateEffectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateEffectCard"), @params);
    }
    public void PrepareStateEffectAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateEffectAllGetBonus"), @params);
    }
    public void PrepareStateAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PrepareStateAllGetBonus"), @params);
    }
    public void PlayOnemore()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayOnemore"), @params);
    }
    public void LoadTimeCardStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadTimeCardStart"), @params);
    }
    public void LoadTimeCardEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadTimeCardEnd"), @params);
    }
    public void LoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadResource"), @params);
    }
    public void InitLayoutDataTable(UDataTable* pLayoutData, UDataTable* pTextLayoutData)
    {
        Span<(string name, object value)> @params = [
            ("pLayoutData", (IntPtr)pLayoutData), 
            ("pTextLayoutData", (IntPtr)pTextLayoutData)
        ];
        ProcessEvent(GetFunction("InitLayoutDataTable"), @params);
    }
    public FVector GetTextCollision(EBtlShuffleTextLayout InLayoutId)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId)
        ];
        return ProcessEvent<FVector>(GetFunction("GetTextCollision"), @params);
    }
    public USprAsset* GetSprAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("GetSprAsset"), @params);
    }
    public int GetSelectedCardIndex(int selectIdx)
    {
        Span<(string name, object value)> @params = [
            ("selectIdx", selectIdx)
        ];
        return ProcessEvent<int>(GetFunction("GetSelectedCardIndex"), @params);
    }
    public int GetRemainNumMajorArcana()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetRemainNumMajorArcana"), @params);
    }
    public UPlgAsset* GetPlgAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPlgAsset*)ProcessEvent<IntPtr>(GetFunction("GetPlgAsset"), @params);
    }
    public FString GetNamePersona(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<FString>(GetFunction("GetNamePersona"), @params);
    }
    public FString GetNameMajorArcana(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<FString>(GetFunction("GetNameMajorArcana"), @params);
    }
    public int GetMegNoDetailArcanaSelectCard(int idx, int minorId, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("minorId", minorId), 
            ("isBonusCard", isBonusCard)
        ];
        return ProcessEvent<int>(GetFunction("GetMegNoDetailArcanaSelectCard"), @params);
    }
    public int GetMaxNumMajorArcana()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMaxNumMajorArcana"), @params);
    }
    public int GetItemNumSelectCard(int idx, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("isBonusCard", isBonusCard)
        ];
        return ProcessEvent<int>(GetFunction("GetItemNumSelectCard"), @params);
    }
    public UAnimSequenceBase* GetInAnime(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        return (UAnimSequenceBase*)ProcessEvent<IntPtr>(GetFunction("GetInAnime"), @params);
    }
    public TArray<int> GetHaveMajorArcana()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<int>>(GetFunction("GetHaveMajorArcana"), @params);
    }
    public int GetHaveItemNumBySelectCard(int idx, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("isBonusCard", isBonusCard)
        ];
        return ProcessEvent<int>(GetFunction("GetHaveItemNumBySelectCard"), @params);
    }
    public UBmdAsset* GetBmdAsset()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UBmdAsset*)ProcessEvent<IntPtr>(GetFunction("GetBmdAsset"), @params);
    }
    public void GetAxisR(ref float X, ref float Y)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y)
        ];
        ProcessEvent(GetFunction("GetAxisR"), @params);
    }
    public void GetAppearCardInfoDetail(int idx, ref int Type, ref int Rank, ref int Value, ref int value2, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("Type", Type), 
            ("Rank", Rank), 
            ("Value", Value), 
            ("value2", value2), 
            ("isBonusCard", isBonusCard)
        ];
        ProcessEvent(GetFunction("GetAppearCardInfoDetail"), @params);
    }
    public void GetAppearCard(int idx, ref FAppPropsCardParam Output, bool isBonusCard)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx), 
            ("Output", Output), 
            ("isBonusCard", isBonusCard)
        ];
        ProcessEvent(GetFunction("GetAppearCard"), @params);
    }
    public UTexture* GetAllGetTexture(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        return (UTexture*)ProcessEvent<IntPtr>(GetFunction("GetAllGetTexture"), @params);
    }
    public FVector2D GetAdjustedPosition(EBtlShuffleLayout InLayoutId)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutId", InLayoutId)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAdjustedPosition"), @params);
    }
    public void EndStateSelectPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateSelectPersona"), @params);
    }
    public void EndStateSelectCardAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateSelectCardAllGetBonus"), @params);
    }
    public void EndStateSelectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateSelectCard"), @params);
    }
    public void EndStateExit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateExit"), @params);
    }
    public void EndStateEnter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateEnter"), @params);
    }
    public void EndStateEffectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateEffectCard"), @params);
    }
    public void EndStateEffectAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateEffectAllGetBonus"), @params);
    }
    public void EndStateAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndStateAllGetBonus"), @params);
    }
    public void CreatePersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreatePersonaStatus"), @params);
    }
    public void CreateMsg()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateMsg"), @params);
    }
    public void ClosePersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClosePersonaStatus"), @params);
    }
    public void CloseMsg()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseMsg"), @params);
    }
    public bool CheckShowPersonaStatus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowPersonaStatus"), @params);
    }
    public bool CheckShowMsg(int ID)
    {
        Span<(string name, object value)> @params = [
            ("ID", ID)
        ];
        return ProcessEvent<bool>(GetFunction("CheckShowMsg"), @params);
    }
    public bool CheckNewCard(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        return ProcessEvent<bool>(GetFunction("CheckNewCard"), @params);
    }
    public bool CheckLoadCardResource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckLoadCardResource"), @params);
    }
    public bool CheckEnableShuffletime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnableShuffletime"), @params);
    }
    public bool CheckDoubleDraw()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckDoubleDraw"), @params);
    }
    public bool CheckCursorSlectedArcana(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        return ProcessEvent<bool>(GetFunction("CheckCursorSlectedArcana"), @params);
    }
    public bool CheckCompleteLoadResource()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckCompleteLoadResource"), @params);
    }
    public bool CheckChangeCard()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckChangeCard"), @params);
    }
    public bool CheckAlloutMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAlloutMode"), @params);
    }
    public bool CheckAllGetBonusMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckAllGetBonusMode"), @params);
    }
    public void ChangeTextureEffectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeTextureEffectCard"), @params);
    }
    public void ChangeStateSelectPersona()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateSelectPersona"), @params);
    }
    public void ChangeStateSelectCardAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateSelectCardAllGetBonus"), @params);
    }
    public void ChangeStateSelectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateSelectCard"), @params);
    }
    public void ChangeStateExit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateExit"), @params);
    }
    public void ChangeStateEnter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateEnter"), @params);
    }
    public void ChangeStateEffectCard()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateEffectCard"), @params);
    }
    public void ChangeStateEffectAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateEffectAllGetBonus"), @params);
    }
    public void ChangeStateAllGetBonus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeStateAllGetBonus"), @params);
    }
    public void ChangePersonaStatusRight(int Cursor)
    {
        Span<(string name, object value)> @params = [
            ("Cursor", Cursor)
        ];
        ProcessEvent(GetFunction("ChangePersonaStatusRight"), @params);
    }
    public void ChangePersonaStatusLeft(int Cursor)
    {
        Span<(string name, object value)> @params = [
            ("Cursor", Cursor)
        ];
        ProcessEvent(GetFunction("ChangePersonaStatusLeft"), @params);
    }
    public void ChangeCardRotationSpeed(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("ChangeCardRotationSpeed"), @params);
    }
    public void CardFallUpdate(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("CardFallUpdate"), @params);
    }
    public void CardFallInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CardFallInit"), @params);
    }
    public void CardFallDraw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CardFallDraw"), @params);
    }
    public void ActionSelectCard(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("ActionSelectCard"), @params);
    }
    public void ActionOnemore()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ActionOnemore"), @params);
    }
    public void ActionCardInStateEffect(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("ActionCardInStateEffect"), @params);
    }
    public void ActionCancel(int idx)
    {
        Span<(string name, object value)> @params = [
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("ActionCancel"), @params);
    }
}

public unsafe class BtlShufflePersonaList : ObjectBase<UBtlShufflePersonaList>
{
    public BtlShufflePersonaList(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlSkill : ObjectBase<ABtlSkill>
{
    public BtlSkill(IntPtr pointer) : base(pointer) {}
    public float CalcOnlyAbsorptionTime(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<float>(GetFunction("CalcOnlyAbsorptionTime"), @params);
    }
}

public unsafe class BtlSkillGeneratorComponent : ObjectBase<UBtlSkillGeneratorComponent>
{
    public BtlSkillGeneratorComponent(IntPtr pointer) : base(pointer) {}
    public bool RequestCreateSkill(int skillId)
    {
        Span<(string name, object value)> @params = [
            ("skillId", skillId)
        ];
        return ProcessEvent<bool>(GetFunction("RequestCreateSkill"), @params);
    }
    public ABtlSkill* GetSkill()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlSkill*)ProcessEvent<IntPtr>(GetFunction("GetSkill"), @params);
    }
}

public unsafe class BtlSoundBPFuncLib : ObjectBase<UBtlSoundBPFuncLib>
{
    public BtlSoundBPFuncLib(IntPtr pointer) : base(pointer) {}
    public void BtlSEPlaySHIFT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlaySHIFT"), @params);
    }
    public void BtlSEPlayPANELOPEN()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayPANELOPEN"), @params);
    }
    public void BtlSEPlayPAGE()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayPAGE"), @params);
    }
    public void BtlSEPlayERROR()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayERROR"), @params);
    }
    public void BtlSEPlayDOWN()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayDOWN"), @params);
    }
    public void BtlSEPlayDECIDE()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayDECIDE"), @params);
    }
    public void BtlSEPlayCURSOR()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayCURSOR"), @params);
    }
    public void BtlSEPlayCRITICAL()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayCRITICAL"), @params);
    }
    public void BtlSEPlayCANCEL()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BtlSEPlayCANCEL"), @params);
    }
    public void BtlSEPlay(int CueId)
    {
        Span<(string name, object value)> @params = [
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("BtlSEPlay"), @params);
    }
    public void BtlPCVoicePlayNotLipsync(ABtlActor* Actor, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("BtlPCVoicePlayNotLipsync"), @params);
    }
    public void BtlPCVoicePlay_ShiftSelect(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("BtlPCVoicePlay_ShiftSelect"), @params);
    }
    public void BtlPCVoicePlay_HeroUI(ABtlActor* Actor, int Type)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("Type", Type)
        ];
        ProcessEvent(GetFunction("BtlPCVoicePlay_HeroUI"), @params);
    }
    public void BtlPCVoicePlay_Command(ABtlActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("BtlPCVoicePlay_Command"), @params);
    }
    public void BtlPCVoicePlay(ABtlActor* Actor, int CueId)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("CueId", CueId)
        ];
        ProcessEvent(GetFunction("BtlPCVoicePlay"), @params);
    }
}

public unsafe class BtlSpecificEventBattle : ObjectBase<UBtlSpecificEventBattle>
{
    public BtlSpecificEventBattle(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlSupportInfoBase : ObjectBase<UBtlSupportInfoBase>
{
    public BtlSupportInfoBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlSupportInfoCommonOnly : ObjectBase<UBtlSupportInfoCommonOnly>
{
    public BtlSupportInfoCommonOnly(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlSupportInfoFuka : ObjectBase<UBtlSupportInfoFuka>
{
    public BtlSupportInfoFuka(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlSupportInfoMessage : ObjectBase<UBtlSupportInfoMessage>
{
    public BtlSupportInfoMessage(IntPtr pointer) : base(pointer) {}
}

public unsafe class BtlSupportInfoMituru : ObjectBase<UBtlSupportInfoMituru>
{
    public BtlSupportInfoMituru(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlSupportSound : ObjectBase<UBtlSupportSound>
{
    public BtlSupportSound(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTableTypes : ObjectBase<UBtlTableTypes>
{
    public BtlTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTargetsManagerComponent : ObjectBase<UBtlTargetsManagerComponent>
{
    public BtlTargetsManagerComponent(IntPtr pointer) : base(pointer) {}
    public void SetTargets(TArray<IntPtr> List)
    {
        Span<(string name, object value)> @params = [
            ("List", List)
        ];
        ProcessEvent(GetFunction("SetTargets"), @params);
    }
    public void SetMainCharacter(ABtlActor* Character)
    {
        Span<(string name, object value)> @params = [
            ("Character", (IntPtr)Character)
        ];
        ProcessEvent(GetFunction("SetMainCharacter"), @params);
    }
    public void SetCursorTargets(TArray<IntPtr> List)
    {
        Span<(string name, object value)> @params = [
            ("List", List)
        ];
        ProcessEvent(GetFunction("SetCursorTargets"), @params);
    }
    public TArray<IntPtr> GetTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetTargets"), @params);
    }
    public ABtlActor* GetMainCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ABtlActor*)ProcessEvent<IntPtr>(GetFunction("GetMainCharacter"), @params);
    }
    public TArray<IntPtr> GetEffectTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetEffectTargets"), @params);
    }
    public TArray<IntPtr> GetCursorTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetCursorTargets"), @params);
    }
    public TArray<IntPtr> GetConstTargets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetConstTargets"), @params);
    }
    public void ClearForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearForBP"), @params);
    }
    public void Clear()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Clear"), @params);
    }
    public bool CheckTargetIsNextActionCharacter(UBtlCoreComponent* pCore)
    {
        Span<(string name, object value)> @params = [
            ("pCore", (IntPtr)pCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckTargetIsNextActionCharacter"), @params);
    }
    public bool CheckTargetIsLatestActionCharacter(UBtlCoreComponent* pCore)
    {
        Span<(string name, object value)> @params = [
            ("pCore", (IntPtr)pCore)
        ];
        return ProcessEvent<bool>(GetFunction("CheckTargetIsLatestActionCharacter"), @params);
    }
}

public unsafe class BtlTutorialBase : ObjectBase<UBtlTutorialBase>
{
    public BtlTutorialBase(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTutorial1st : ObjectBase<UBtlTutorial1st>
{
    public BtlTutorial1st(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTutorial2nd : ObjectBase<UBtlTutorial2nd>
{
    public BtlTutorial2nd(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTutorial3rd : ObjectBase<UBtlTutorial3rd>
{
    public BtlTutorial3rd(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlTutorialTheurgia : ObjectBase<UBtlTutorialTheurgia>
{
    public BtlTutorialTheurgia(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlVoicePlayWatcher : ObjectBase<UBtlVoicePlayWatcher>
{
    public BtlVoicePlayWatcher(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlVoice : ObjectBase<UBtlVoice>
{
    public BtlVoice(IntPtr pointer) : base(pointer) {}
    public void StartLipyncWatcher()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartLipyncWatcher"), @params);
    }
    public void EndLipsyncWatcher()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndLipsyncWatcher"), @params);
    }
}

public unsafe class BtlPcVoice : ObjectBase<UBtlPcVoice>
{
    public BtlPcVoice(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossVoice : ObjectBase<UBtlBossVoice>
{
    public BtlBossVoice(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossStregaVoice : ObjectBase<UBtlBossStregaVoice>
{
    public BtlBossStregaVoice(IntPtr pointer) : base(pointer) {}}

public unsafe class BtlBossNyxAvatarVoice : ObjectBase<UBtlBossNyxAvatarVoice>
{
    public BtlBossNyxAvatarVoice(IntPtr pointer) : base(pointer) {}}

public unsafe class BustupController : ObjectBase<UBustupController>
{
    public BustupController(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupObject : ObjectBase<UBustupObject>
{
    public BustupObject(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupDraw : ObjectBase<UBustupDraw>
{
    public BustupDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class BustupModel : ObjectBase<UBustupModel>
{
    public BustupModel(IntPtr pointer) : base(pointer) {}
}

public unsafe class AppCalculaterComponent : ObjectBase<UAppCalculaterComponent>
{
    public AppCalculaterComponent(IntPtr pointer) : base(pointer) {}
    public float BPCommand_CalculationUpdate(float DeltaTime, ref FAppCalculaterComponentWork Work, bool IsReverse, bool IsLoop, bool IsReset)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime), 
            ("Work", Work), 
            ("IsReverse", IsReverse), 
            ("IsLoop", IsLoop), 
            ("IsReset", IsReset)
        ];
        return ProcessEvent<float>(GetFunction("BPCommand_CalculationUpdate"), @params);
    }
}

public unsafe class Calendar : ObjectBase<UCalendar>
{
    public Calendar(IntPtr pointer) : base(pointer) {}
}

public unsafe class CalendarActor : ObjectBase<ACalendarActor>
{
    public CalendarActor(IntPtr pointer) : base(pointer) {}}

public unsafe class CampModelControllerItem : ObjectBase<UCampModelControllerItem>
{
    public CampModelControllerItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CampPlayerModelControllerItem : ObjectBase<UCampPlayerModelControllerItem>
{
    public CampPlayerModelControllerItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CampModelController : ObjectBase<UCampModelController>
{
    public CampModelController(IntPtr pointer) : base(pointer) {}
}

public unsafe class CampSceneCapture : ObjectBase<ACampSceneCapture>
{
    public CampSceneCapture(IntPtr pointer) : base(pointer) {}
    public void LoopAnimationStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoopAnimationStart"), @params);
    }
    public void InAnimationStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InAnimationStart"), @params);
    }
}

public unsafe class CharacterLipsyncAppComponent : ObjectBase<UCharacterLipsyncAppComponent>
{
    public CharacterLipsyncAppComponent(IntPtr pointer) : base(pointer) {}
    public void OnChangeLipsyncState(ELipSyncAppStateType LipSyncAppStateType, ref FLipsyncAppListener LipsyncParam)
    {
        Span<(string name, object value)> @params = [
            ("LipSyncAppStateType", LipSyncAppStateType), 
            ("LipsyncParam", LipsyncParam)
        ];
        ProcessEvent(GetFunction("OnChangeLipsyncState"), @params);
    }
    public ULipsyncAppObserverSubsystem* GetLipsyncSubsystem()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULipsyncAppObserverSubsystem*)ProcessEvent<IntPtr>(GetFunction("GetLipsyncSubsystem"), @params);
    }
    public void FindLipPropsPtr()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FindLipPropsPtr"), @params);
    }
}

public unsafe class CharacterSimpleLipsAnimAppComponent : ObjectBase<UCharacterSimpleLipsAnimAppComponent>
{
    public CharacterSimpleLipsAnimAppComponent(IntPtr pointer) : base(pointer) {}
    public void OnChangeLipsState(ECharacterSimpleLipsAnimAppStateType LipSyncAppStateType, ref FCharacterSimpleLipsAnimAppListener LipsyncParam)
    {
        Span<(string name, object value)> @params = [
            ("LipSyncAppStateType", LipSyncAppStateType), 
            ("LipsyncParam", LipsyncParam)
        ];
        ProcessEvent(GetFunction("OnChangeLipsState"), @params);
    }
    public UCharacterSimpleLipsAnimAppSubsystem* GetLipsSubsystem()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UCharacterSimpleLipsAnimAppSubsystem*)ProcessEvent<IntPtr>(GetFunction("GetLipsSubsystem"), @params);
    }
    public void FindPropsPtr()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FindPropsPtr"), @params);
    }
}

public unsafe class CharacterSimpleLipsAnimAppSubsystem : ObjectBase<UCharacterSimpleLipsAnimAppSubsystem>
{
    public CharacterSimpleLipsAnimAppSubsystem(IntPtr pointer) : base(pointer) {}
    public void StopAllSpeakCharacter()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAllSpeakCharacter"), @params);
    }
    public void StartSpeakCharacterWithCustomParam(ref FCharacterSimpleLipsAnimAppParam SimpleLipsParam, bool bOverride)
    {
        Span<(string name, object value)> @params = [
            ("SimpleLipsParam", SimpleLipsParam), 
            ("bOverride", bOverride)
        ];
        ProcessEvent(GetFunction("StartSpeakCharacterWithCustomParam"), @params);
    }
    public void StartSpeakCharacterPtr(AActor* ActorPtr, float RequestedSpeakTotalTime, int MajorPlayerID, int MinorPlayerID, bool bOverride)
    {
        Span<(string name, object value)> @params = [
            ("ActorPtr", (IntPtr)ActorPtr), 
            ("RequestedSpeakTotalTime", RequestedSpeakTotalTime), 
            ("MajorPlayerID", MajorPlayerID), 
            ("MinorPlayerID", MinorPlayerID), 
            ("bOverride", bOverride)
        ];
        ProcessEvent(GetFunction("StartSpeakCharacterPtr"), @params);
    }
    public void StartSpeakCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID, float RequestedSpeakTotalTime, bool bOverride)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID), 
            ("RequestedSpeakTotalTime", RequestedSpeakTotalTime), 
            ("bOverride", bOverride)
        ];
        ProcessEvent(GetFunction("StartSpeakCharacter"), @params);
    }
    public void FinishSpeakCharacterPtr(AActor* ActorPtr)
    {
        Span<(string name, object value)> @params = [
            ("ActorPtr", (IntPtr)ActorPtr)
        ];
        ProcessEvent(GetFunction("FinishSpeakCharacterPtr"), @params);
    }
    public void FinishSpeakCharacter(EAppCharCategoryType CharcterCategoryType, int CharaIndexID)
    {
        Span<(string name, object value)> @params = [
            ("CharcterCategoryType", CharcterCategoryType), 
            ("CharaIndexID", CharaIndexID)
        ];
        ProcessEvent(GetFunction("FinishSpeakCharacter"), @params);
    }
}

public unsafe class CldBindingEventActor : ObjectBase<ACldBindingEventActor>
{
    public CldBindingEventActor(IntPtr pointer) : base(pointer) {}
    public void CallStatePatternEndDelicate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallStatePatternEndDelicate"), @params);
    }
}

public unsafe class CldBpFuncLib : ObjectBase<UCldBpFuncLib>
{
    public CldBpFuncLib(IntPtr pointer) : base(pointer) {}
    public void SetNowTotalDay(int TotalDay)
    {
        Span<(string name, object value)> @params = [
            ("TotalDay", TotalDay)
        ];
        ProcessEvent(GetFunction("SetNowTotalDay"), @params);
    }
    public void SetNowTimeZone(ECldTimeZone TimeZone)
    {
        Span<(string name, object value)> @params = [
            ("TimeZone", TimeZone)
        ];
        ProcessEvent(GetFunction("SetNowTimeZone"), @params);
    }
    public int GetTotalDayFromSeason(ECldSeason Season)
    {
        Span<(string name, object value)> @params = [
            ("Season", Season)
        ];
        return ProcessEvent<int>(GetFunction("GetTotalDayFromSeason"), @params);
    }
    public int GetNowYoubi()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowYoubi"), @params);
    }
    public bool GetNowYasumi()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetNowYasumi"), @params);
    }
    public void GetNowTotalToDayMon(ref int Month, ref int Day)
    {
        Span<(string name, object value)> @params = [
            ("Month", Month), 
            ("Day", Day)
        ];
        ProcessEvent(GetFunction("GetNowTotalToDayMon"), @params);
    }
    public int GetNowTotalDay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowTotalDay"), @params);
    }
    public ECldTimeZone GetNowTimeZone()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECldTimeZone>(GetFunction("GetNowTimeZone"), @params);
    }
    public int GetNowTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowTime"), @params);
    }
    public ECldSeason GetNowSeason()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECldSeason>(GetFunction("GetNowSeason"), @params);
    }
    public int GetNowMoonAge()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowMoonAge"), @params);
    }
    public void CldSetDrawDayDispIm(ECldDayDispState flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("CldSetDrawDayDispIm"), @params);
    }
    public void CldSetDrawDayDisp(ECldDayDispState flag)
    {
        Span<(string name, object value)> @params = [
            ("flag", flag)
        ];
        ProcessEvent(GetFunction("CldSetDrawDayDisp"), @params);
    }
    public ECldDayDispState CldGetDayDispState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECldDayDispState>(GetFunction("CldGetDayDispState"), @params);
    }
    public bool CldCheckDayDispInOut()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CldCheckDayDispInOut"), @params);
    }
    public bool CheckWinterCloth()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckWinterCloth"), @params);
    }
}

public unsafe class CldCmnDataActor : ObjectBase<ACldCmnDataActor>
{
    public CldCmnDataActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class CldCommonData : ObjectBase<UCldCommonData>
{
    public CldCommonData(IntPtr pointer) : base(pointer) {}
}

public unsafe class CldDateDataAsset : ObjectBase<UCldDateDataAsset>
{
    public CldDateDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CldDateMessageDataAsset : ObjectBase<UCldDateMessageDataAsset>
{
    public CldDateMessageDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CldSceneChange : ObjectBase<UCldSceneChange>
{
    public CldSceneChange(IntPtr pointer) : base(pointer) {}}

public unsafe class CldSchedulerActor : ObjectBase<ACldSchedulerActor>
{
    public CldSchedulerActor(IntPtr pointer) : base(pointer) {}
    public void SetBpObjEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetBpObjEnd"), @params);
    }
}

public unsafe class UtlBpObjCore : ObjectBase<UUtlBpObjCore>
{
    public UtlBpObjCore(IntPtr pointer) : base(pointer) {}
    public void UnloadLevel(FName LevelName, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("LevelName", LevelName), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("UnloadLevel"), @params);
    }
    public void StartProc()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartProc"), @params);
    }
    public void ReturnField()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReturnField"), @params);
    }
    public void Return()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Return"), @params);
    }
    public void LoadLevel(FName LevelName, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("LevelName", LevelName), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("LoadLevel"), @params);
    }
    public void CallOpenLevel(FName LevelName)
    {
        Span<(string name, object value)> @params = [
            ("LevelName", LevelName)
        ];
        ProcessEvent(GetFunction("CallOpenLevel"), @params);
    }
}

public unsafe class UtlBpObj : ObjectBase<UUtlBpObj>
{
    public UtlBpObj(IntPtr pointer) : base(pointer) {}
    public void SyncFade(int Type, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("SyncFade"), @params);
    }
    public void StartScript(TSoftObjectPtr<UBfAsset> InAsset, int ProcNo, FLatentActionInfo LatentInfo, ref int Result)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", InAsset), 
            ("ProcNo", ProcNo), 
            ("LatentInfo", LatentInfo), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("StartScript"), @params);
    }
    public void StartFadeOUT(int Type, int Frame)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame)
        ];
        ProcessEvent(GetFunction("StartFadeOUT"), @params);
    }
    public void StartFadeIN(int Type, int Frame)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame)
        ];
        ProcessEvent(GetFunction("StartFadeIN"), @params);
    }
}

public unsafe class CldSchedulerBpObject : ObjectBase<UCldSchedulerBpObject>
{
    public CldSchedulerBpObject(IntPtr pointer) : base(pointer) {}
    public void Shadow()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Shadow"), @params);
    }
    public void PM()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PM"), @params);
    }
    public void Noon()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Noon"), @params);
    }
    public void Night()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Night"), @params);
    }
    public void Morning()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Morning"), @params);
    }
    public void Midnight()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Midnight"), @params);
    }
    public void EarlyMorning()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EarlyMorning"), @params);
    }
    public void CallNextTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallNextTime"), @params);
    }
    public void AM()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AM"), @params);
    }
    public void AfterSchool()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AfterSchool"), @params);
    }
}

public unsafe class UtlProcActor : ObjectBase<AUtlProcActor>
{
    public UtlProcActor(IntPtr pointer) : base(pointer) {}
    public void StartProc()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartProc"), @params);
    }
    public void ReturnField()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReturnField"), @params);
    }
    public void Return()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Return"), @params);
    }
    public void RequestBfSettedFile(UObject* WorldContextObject, int ProcNo, FLatentActionInfo LatentInfo, ref int Result)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ProcNo", ProcNo), 
            ("LatentInfo", LatentInfo), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("RequestBfSettedFile"), @params);
    }
}

public unsafe class CldSchedulerProcActor : ObjectBase<ACldSchedulerProcActor>
{
    public CldSchedulerProcActor(IntPtr pointer) : base(pointer) {}
    public void ShadowTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ShadowTime"), @params);
    }
    public void PM()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PM"), @params);
    }
    public void Noon()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Noon"), @params);
    }
    public void Night()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Night"), @params);
    }
    public void Morning()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Morning"), @params);
    }
    public void Midnight()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Midnight"), @params);
    }
    public void EarlyMorning()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EarlyMorning"), @params);
    }
    public void CallNextTime()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallNextTime"), @params);
    }
    public void AM()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AM"), @params);
    }
    public void AfterSchool()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AfterSchool"), @params);
    }
}

public unsafe class CldTableTypes : ObjectBase<UCldTableTypes>
{
    public CldTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class CmpMenuBase : ObjectBase<UCmpMenuBase>
{
    public CmpMenuBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCalendar : ObjectBase<UCmpCalendar>
{
    public CmpCalendar(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIScene : ObjectBase<UUIScene>
{
    public UIScene(IntPtr pointer) : base(pointer) {}}

public unsafe class CmpCharacterStatus : ObjectBase<UCmpCharacterStatus>
{
    public CmpCharacterStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCharacterStatusDraw : ObjectBase<UCmpCharacterStatusDraw>
{
    public CmpCharacterStatusDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCommu : ObjectBase<UCmpCommu>
{
    public CmpCommu(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCommuDetails : ObjectBase<UCmpCommuDetails>
{
    public CmpCommuDetails(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCommuList : ObjectBase<UCmpCommuList>
{
    public CmpCommuList(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCommuCardAnimInstance : ObjectBase<UCmpCommuCardAnimInstance>
{
    public CmpCommuCardAnimInstance(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpCommuModelController : ObjectBase<ACmpCommuModelController>
{
    public CmpCommuModelController(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpEquip : ObjectBase<UCmpEquip>
{
    public CmpEquip(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpEquipDraw : ObjectBase<UCmpEquipDraw>
{
    public CmpEquipDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpEquipSystem : ObjectBase<UCmpEquipSystem>
{
    public CmpEquipSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpHeroHumanStatus : ObjectBase<UCmpHeroHumanStatus>
{
    public CmpHeroHumanStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpHeroHumanStatusDraw : ObjectBase<UCmpHeroHumanStatusDraw>
{
    public CmpHeroHumanStatusDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpItem : ObjectBase<UCmpItem>
{
    public CmpItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpItemDraw : ObjectBase<UCmpItemDraw>
{
    public CmpItemDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpItemSystem : ObjectBase<UCmpItemSystem>
{
    public CmpItemSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpMainActor : ObjectBase<ACmpMainActor>
{
    public CmpMainActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class CampLoadSequenceBase : ObjectBase<UCampLoadSequenceBase>
{
    public CampLoadSequenceBase(IntPtr pointer) : base(pointer) {}}

public unsafe class CallFieldSequence : ObjectBase<UCallFieldSequence>
{
    public CallFieldSequence(IntPtr pointer) : base(pointer) {}}

public unsafe class CallTitleSequence : ObjectBase<UCallTitleSequence>
{
    public CallTitleSequence(IntPtr pointer) : base(pointer) {}}

public unsafe class CmpMainLoadActor : ObjectBase<ACmpMainLoadActor>
{
    public CmpMainLoadActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpPersona : ObjectBase<UCmpPersona>
{
    public CmpPersona(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpPersonaList : ObjectBase<UCmpPersonaList>
{
    public CmpPersonaList(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpQuest : ObjectBase<UCmpQuest>
{
    public CmpQuest(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpRoot : ObjectBase<UCmpRoot>
{
    public CmpRoot(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpRootDraw : ObjectBase<UCmpRootDraw>
{
    public CmpRootDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpSkill : ObjectBase<UCmpSkill>
{
    public CmpSkill(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpSkillDraw : ObjectBase<UCmpSkillDraw>
{
    public CmpSkillDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpSkillSystem : ObjectBase<UCmpSkillSystem>
{
    public CmpSkillSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class CmpStatus : ObjectBase<UCmpStatus>
{
    public CmpStatus(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpStatusCharacterList : ObjectBase<UCmpStatusCharacterList>
{
    public CmpStatusCharacterList(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpStatusCharacterListDraw : ObjectBase<UCmpStatusCharacterListDraw>
{
    public CmpStatusCharacterListDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpSystem : ObjectBase<UCmpSystem>
{
    public CmpSystem(IntPtr pointer) : base(pointer) {}
    public void OnEndPlaySubProcess(AActor* Actor, EEndPlayReason EndPlayReason)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("EndPlayReason", EndPlayReason)
        ];
        ProcessEvent(GetFunction("OnEndPlaySubProcess"), @params);
    }
}

public unsafe class CmpSystemDraw : ObjectBase<UCmpSystemDraw>
{
    public CmpSystemDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class CmpSystemSystem : ObjectBase<UCmpSystemSystem>
{
    public CmpSystemSystem(IntPtr pointer) : base(pointer) {}
}

public unsafe class CombineTest : ObjectBase<ACombineTest>
{
    public CombineTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityEventManager : ObjectBase<ACommunityEventManager>
{
    public CommunityEventManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityHandler : ObjectBase<UCommunityHandler>
{
    public CommunityHandler(IntPtr pointer) : base(pointer) {}
}

public unsafe class DebugViewer : ObjectBase<ADebugViewer>
{
    public DebugViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityShortcut : ObjectBase<ACommunityShortcut>
{
    public CommunityShortcut(IntPtr pointer) : base(pointer) {}
    public void ScriptFinishedFunction(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("ScriptFinishedFunction"), @params);
    }
}

public unsafe class CommunityEventDataAsset : ObjectBase<UCommunityEventDataAsset>
{
    public CommunityEventDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class HeroParameterDataAsset : ObjectBase<UHeroParameterDataAsset>
{
    public HeroParameterDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class HolidayEventDataAsset : ObjectBase<UHolidayEventDataAsset>
{
    public HolidayEventDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class HolidayScheduleDataAsset : ObjectBase<UHolidayScheduleDataAsset>
{
    public HolidayScheduleDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CoefficientDataAsset : ObjectBase<UCoefficientDataAsset>
{
    public CoefficientDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityPresentDataAsset : ObjectBase<UCommunityPresentDataAsset>
{
    public CommunityPresentDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class MoviesEventDataAsset : ObjectBase<UMoviesEventDataAsset>
{
    public MoviesEventDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SummerFestivalEventDataAsset : ObjectBase<USummerFestivalEventDataAsset>
{
    public SummerFestivalEventDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class ChristmasEventDataAsset : ObjectBase<UChristmasEventDataAsset>
{
    public ChristmasEventDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class CommunityWork : ObjectBase<UCommunityWork>
{
    public CommunityWork(IntPtr pointer) : base(pointer) {}
}

public unsafe class ConfigBGMSelectDialog : ObjectBase<UConfigBGMSelectDialog>
{
    public ConfigBGMSelectDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class ConfigDialog : ObjectBase<UConfigDialog>
{
    public ConfigDialog(IntPtr pointer) : base(pointer) {}
}

public unsafe class ConfigDungeonBGMSelectDialog : ObjectBase<UConfigDungeonBGMSelectDialog>
{
    public ConfigDungeonBGMSelectDialog(IntPtr pointer) : base(pointer) {}}

public unsafe class CutInDraw : ObjectBase<ACutInDraw>
{
    public CutInDraw(IntPtr pointer) : base(pointer) {}
}

public unsafe class DailyChangeVoiceActionViewer : ObjectBase<ADailyChangeVoiceActionViewer>
{
    public DailyChangeVoiceActionViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIVoiceBase : ObjectBase<AUIVoiceBase>
{
    public UIVoiceBase(IntPtr pointer) : base(pointer) {}}

public unsafe class UIDebugReceiveVoiceAction : ObjectBase<AUIDebugReceiveVoiceAction>
{
    public UIDebugReceiveVoiceAction(IntPtr pointer) : base(pointer) {}}

public unsafe class DatAnalyze : ObjectBase<UDatAnalyze>
{
    public DatAnalyze(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatBtlCommon : ObjectBase<UDatBtlCommon>
{
    public DatBtlCommon(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEncount : ObjectBase<UDatEncount>
{
    public DatEncount(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatEnemy : ObjectBase<UDatEnemy>
{
    public DatEnemy(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatFontAdjustment : ObjectBase<UDatFontAdjustment>
{
    public DatFontAdjustment(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatItemActor : ObjectBase<ADatItemActor>
{
    public DatItemActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatItem : ObjectBase<UDatItem>
{
    public DatItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatMiniMapInfo : ObjectBase<UDatMiniMapInfo>
{
    public DatMiniMapInfo(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatMiniMapOffset : ObjectBase<UDatMiniMapOffset>
{
    public DatMiniMapOffset(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPersona : ObjectBase<UDatPersona>
{
    public DatPersona(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPlayer : ObjectBase<UDatPlayer>
{
    public DatPlayer(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPlayerNameTable : ObjectBase<UDatPlayerNameTable>
{
    public DatPlayerNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPlayerFirstNameTable : ObjectBase<UDatPlayerFirstNameTable>
{
    public DatPlayerFirstNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPlayerLastNameTable : ObjectBase<UDatPlayerLastNameTable>
{
    public DatPlayerLastNameTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatRace : ObjectBase<UDatRace>
{
    public DatRace(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSaveDataLocalization : ObjectBase<UDatSaveDataLocalization>
{
    public DatSaveDataLocalization(IntPtr pointer) : base(pointer) {}}

public unsafe class DatShuffleCard : ObjectBase<UDatShuffleCard>
{
    public DatShuffleCard(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSkill : ObjectBase<UDatSkill>
{
    public DatSkill(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSuggestion : ObjectBase<UDatSuggestion>
{
    public DatSuggestion(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSupportInfo : ObjectBase<UDatSupportInfo>
{
    public DatSupportInfo(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatSystemText : ObjectBase<UDatSystemText>
{
    public DatSystemText(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatTableTypes : ObjectBase<UDatTableTypes>
{
    public DatTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class DatTheurgia : ObjectBase<UDatTheurgia>
{
    public DatTheurgia(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatTownMapInfo : ObjectBase<UDatTownMapInfo>
{
    public DatTownMapInfo(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatTownMapRestrictions : ObjectBase<UDatTownMapRestrictions>
{
    public DatTownMapRestrictions(IntPtr pointer) : base(pointer) {}}

public unsafe class DatTownMapTime : ObjectBase<UDatTownMapTime>
{
    public DatTownMapTime(IntPtr pointer) : base(pointer) {}}

public unsafe class DatUICalendarText : ObjectBase<UDatUICalendarText>
{
    public DatUICalendarText(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatUIText : ObjectBase<UDatUIText>
{
    public DatUIText(IntPtr pointer) : base(pointer) {}}

public unsafe class DatUIUseText : ObjectBase<UDatUIUseText>
{
    public DatUIUseText(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatUnit : ObjectBase<UDatUnit>
{
    public DatUnit(IntPtr pointer) : base(pointer) {}}

public unsafe class DbgCmpStatusTest : ObjectBase<ADbgCmpStatusTest>
{
    public DbgCmpStatusTest(IntPtr pointer) : base(pointer) {}
}

public unsafe class DictionaryTableDataAsset : ObjectBase<UDictionaryTableDataAsset>
{
    public DictionaryTableDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class UIDrawBaseActor : ObjectBase<AUIDrawBaseActor>
{
    public UIDrawBaseActor(IntPtr pointer) : base(pointer) {}
    public bool Sync()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Sync"), @params);
    }
    public void LoadStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadStart"), @params);
    }
    public UObject* GetResourceData(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetResourceData"), @params);
    }
    public void BPUIDebugCommand_DrawTriangle(float VX0, float VY0, float VX1, float VY1, float VX2, float VY2, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing)
    {
        Span<(string name, object value)> @params = [
            ("VX0", VX0), 
            ("VY0", VY0), 
            ("VX1", VX1), 
            ("VY1", VY1), 
            ("VX2", VX2), 
            ("VY2", VY2), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawTriangle"), @params);
    }
    public void BPUIDebugCommand_DrawTexture(float X, float Y, float Z, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float U0, float V0, float U1, float v1, UTexture* TextureHandle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("U0", U0), 
            ("V0", V0), 
            ("U1", U1), 
            ("v1", v1), 
            ("TextureHandle", (IntPtr)TextureHandle)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawTexture"), @params);
    }
    public void BPUIDebugCommand_DrawSpr(float X, float Y, float Z, byte R, byte G, byte B, byte A, int SprNo, float ScaleX, float ScaleY, float Angle, USprAsset* SprHandle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("SprNo", SprNo), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("SprHandle", (IntPtr)SprHandle)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawSpr"), @params);
    }
    public void BPUIDebugCommand_DrawRectV4(float X, float Y, float Z, float VX0, float VY0, float VX1, float VY1, float VX2, float VY2, float VX3, float VY3, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("VX0", VX0), 
            ("VY0", VY0), 
            ("VX1", VX1), 
            ("VY1", VY1), 
            ("VX2", VX2), 
            ("VY2", VY2), 
            ("VX3", VX3), 
            ("VY3", VY3), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawRectV4"), @params);
    }
    public void BPUIDebugCommand_DrawRect(float X, float Y, float Z, float Width, float Height, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawRect"), @params);
    }
    public void BPUIDebugCommand_DrawMaterial(float X, float Y, float Z, float Width, float Height, float Angle, UMaterialInstance* pMaterialInstance)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle), 
            ("pMaterialInstance", (IntPtr)pMaterialInstance)
        ];
        ProcessEvent(GetFunction("BPUIDebugCommand_DrawMaterial"), @params);
    }
    public void BPUICommand_SetRenderTarget(int CanvasIndex)
    {
        Span<(string name, object value)> @params = [
            ("CanvasIndex", CanvasIndex)
        ];
        ProcessEvent(GetFunction("BPUICommand_SetRenderTarget"), @params);
    }
    public void BPUICommand_SetPresetBlendState(EUIOTPRESET_BLEND_TYPE BlendType)
    {
        Span<(string name, object value)> @params = [
            ("BlendType", BlendType)
        ];
        ProcessEvent(GetFunction("BPUICommand_SetPresetBlendState"), @params);
    }
    public void BPUICommand_SetBlendState(EUIBlendOperation OpColor, EUIBlendFactor SrcColor, EUIBlendFactor DstColor, EUIBlendOperation OpAlpha, EUIBlendFactor SrcAlpha, EUIBlendFactor DstAlpha)
    {
        Span<(string name, object value)> @params = [
            ("OpColor", OpColor), 
            ("SrcColor", SrcColor), 
            ("DstColor", DstColor), 
            ("OpAlpha", OpAlpha), 
            ("SrcAlpha", SrcAlpha), 
            ("DstAlpha", DstAlpha)
        ];
        ProcessEvent(GetFunction("BPUICommand_SetBlendState"), @params);
    }
    public void BPUICommand_ScalingItalicFontDraw(float X, float Y, FString String, FColor Color, float SizeX, float SizeY, float Scale, float Angle, bool ScalingOnlyX, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("String", String), 
            ("Color", Color), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("ScalingOnlyX", ScalingOnlyX), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_ScalingItalicFontDraw"), @params);
    }
    public void BPUICommand_ScalingFontDraw(float X, float Y, float Z, FString String, byte R, byte G, byte B, byte A, float SizeX, float SizeY, float Scale, float Angle, bool ScalingOnlyX, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style, bool IsScaling)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("SizeX", SizeX), 
            ("SizeY", SizeY), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("ScalingOnlyX", ScalingOnlyX), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style), 
            ("IsScaling", IsScaling)
        ];
        ProcessEvent(GetFunction("BPUICommand_ScalingFontDraw"), @params);
    }
    public void BPUICommand_ItalicFontDraw(float X, float Y, FString String, FColor Color, float Scale, float Angle, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("String", String), 
            ("Color", Color), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_ItalicFontDraw"), @params);
    }
    public UTextureRenderTarget2D* BPUICommand_GetRenderTarget(int CanvasIndex)
    {
        Span<(string name, object value)> @params = [
            ("CanvasIndex", CanvasIndex)
        ];
        return (UTextureRenderTarget2D*)ProcessEvent<IntPtr>(GetFunction("BPUICommand_GetRenderTarget"), @params);
    }
    public void BPUICommand_FontDrawFromFName(float X, float Y, float Z, ref FName String, byte R, byte G, byte B, byte A, float Scale, float Angle, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_FontDrawFromFName"), @params);
    }
    public void BPUICommand_FontDrawExFromFName(float X, float Y, float Z, ref FName String, byte R, byte G, byte B, byte A, float Scale, float Angle, float AnglePointX, float AnglePointY, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("AnglePointX", AnglePointX), 
            ("AnglePointY", AnglePointY), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_FontDrawExFromFName"), @params);
    }
    public void BPUICommand_FontDrawEx(float X, float Y, float Z, FString String, byte R, byte G, byte B, byte A, float Scale, float Angle, float AnglePointX, float AnglePointY, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("AnglePointX", AnglePointX), 
            ("AnglePointY", AnglePointY), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_FontDrawEx"), @params);
    }
    public void BPUICommand_FontDraw(float X, float Y, float Z, FString String, byte R, byte G, byte B, byte A, float Scale, float Angle, EUI_DRAW_POINT DrawPoint, EUIFontStyle Style)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("String", String), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Scale", Scale), 
            ("Angle", Angle), 
            ("DrawPoint", DrawPoint), 
            ("Style", Style)
        ];
        ProcessEvent(GetFunction("BPUICommand_FontDraw"), @params);
    }
    public void BPUICommand_DrawVerticalGradationRect(float X, float Y, float Width, float Height, FColor TopColor, FColor BottomColor)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Width", Width), 
            ("Height", Height), 
            ("TopColor", TopColor), 
            ("BottomColor", BottomColor)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawVerticalGradationRect"), @params);
    }
    public void BPUICommand_DrawTriangle(float X, float Y, float Z, float VX0, float VY0, float VX1, float VY1, float VX2, float VY2, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("VX0", VX0), 
            ("VY0", VY0), 
            ("VX1", VX1), 
            ("VY1", VY1), 
            ("VX2", VX2), 
            ("VY2", VY2), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawTriangle"), @params);
    }
    public void BPUICommand_DrawTexture(float X, float Y, float Z, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float U0, float V0, float U1, float v1, UTexture* TextureHandle, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("U0", U0), 
            ("V0", V0), 
            ("U1", U1), 
            ("v1", v1), 
            ("TextureHandle", (IntPtr)TextureHandle), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawTexture"), @params);
    }
    public void BPUICommand_DrawSpr(float X, float Y, float Z, byte R, byte G, byte B, byte A, int SprNo, float ScaleX, float ScaleY, float Angle, USprAsset* SprHandle, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("SprNo", SprNo), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("SprHandle", (IntPtr)SprHandle), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawSpr"), @params);
    }
    public void BPUICommand_DrawSircle(float X, float Y, float Z, float Radius, byte R, byte G, byte B, byte A, float Antialiasing)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Radius", Radius), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("Antialiasing", Antialiasing)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawSircle"), @params);
    }
    public void BPUICommand_DrawScrollbar(float X, float Y, float Z, float Width, float Height, float ScrollRange, int ScrollPos, int DrawListNum, int MaxListNum, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("ScrollRange", ScrollRange), 
            ("ScrollPos", ScrollPos), 
            ("DrawListNum", DrawListNum), 
            ("MaxListNum", MaxListNum), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawScrollbar"), @params);
    }
    public void BPUICommand_DrawRoundRect(float X, float Y, float Z, float Width, float Height, int Round, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("Round", Round), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawRoundRect"), @params);
    }
    public void BPUICommand_DrawRectV4(float X, float Y, float Z, float VX0, float VY0, float VX1, float VY1, float VX2, float VY2, float VX3, float VY3, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("VX0", VX0), 
            ("VY0", VY0), 
            ("VX1", VX1), 
            ("VY1", VY1), 
            ("VX2", VX2), 
            ("VY2", VY2), 
            ("VX3", VX3), 
            ("VY3", VY3), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawRectV4"), @params);
    }
    public void BPUICommand_DrawRect(float X, float Y, float Z, float Width, float Height, byte R, byte G, byte B, byte A, float ScaleX, float ScaleY, float Angle, float Antialiasing, EUI_DRAW_POINT DrawPoint)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("Antialiasing", Antialiasing), 
            ("DrawPoint", DrawPoint)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawRect"), @params);
    }
    public void BPUICommand_DrawPlg(float X, float Y, float Z, byte R, byte G, byte B, byte A, int PlgID, float ScaleX, float ScaleY, float Angle, UPlgAsset* PlgHandle)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("R", R), 
            ("G", G), 
            ("B", B), 
            ("A", A), 
            ("PlgID", PlgID), 
            ("ScaleX", ScaleX), 
            ("ScaleY", ScaleY), 
            ("Angle", Angle), 
            ("PlgHandle", (IntPtr)PlgHandle)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawPlg"), @params);
    }
    public void BPUICommand_DrawMaterial(float X, float Y, float Z, float Width, float Height, float Angle, UObject* pMaterial)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Z", Z), 
            ("Width", Width), 
            ("Height", Height), 
            ("Angle", Angle), 
            ("pMaterial", (IntPtr)pMaterial)
        ];
        ProcessEvent(GetFunction("BPUICommand_DrawMaterial"), @params);
    }
    public USprAsset* BPUICommand_CastSprAsset(UObject* Asset)
    {
        Span<(string name, object value)> @params = [
            ("Asset", (IntPtr)Asset)
        ];
        return (USprAsset*)ProcessEvent<IntPtr>(GetFunction("BPUICommand_CastSprAsset"), @params);
    }
    public UPlgAsset* BPUICommand_CastPlgAsset(UObject* Asset)
    {
        Span<(string name, object value)> @params = [
            ("Asset", (IntPtr)Asset)
        ];
        return (UPlgAsset*)ProcessEvent<IntPtr>(GetFunction("BPUICommand_CastPlgAsset"), @params);
    }
    public void BPUICommand_AtlUIBlendState(EUIBLEND_STATE_TYPE BlendType)
    {
        Span<(string name, object value)> @params = [
            ("BlendType", BlendType)
        ];
        ProcessEvent(GetFunction("BPUICommand_AtlUIBlendState"), @params);
    }
    public void AddLoadAsset(TSoftObjectPtr<UObject> SoftAsset)
    {
        Span<(string name, object value)> @params = [
            ("SoftAsset", SoftAsset)
        ];
        ProcessEvent(GetFunction("AddLoadAsset"), @params);
    }
}

public unsafe class DifficultySelectionActor : ObjectBase<ADifficultySelectionActor>
{
    public DifficultySelectionActor(IntPtr pointer) : base(pointer) {}
    public void ProcessCompleted__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ProcessCompleted__DelegateSignature"), @params);
    }
    public bool LoadCheck()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("LoadCheck"), @params);
    }
    public bool HasMsgInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasMsgInstance"), @params);
    }
    public FVector2D GetScreenSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetScreenSize"), @params);
    }
    public int GetCursorIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCursorIndex"), @params);
    }
    public void DrawInfoText(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawInfoText"), @params);
    }
    public void DrawHelp(float AddX, float AddY)
    {
        Span<(string name, object value)> @params = [
            ("AddX", AddX), 
            ("AddY", AddY)
        ];
        ProcessEvent(GetFunction("DrawHelp"), @params);
    }
    public void DrawDiffList()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawDiffList"), @params);
    }
    public void DrawDescriptionText(FVector2D InPos, FColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InPos", InPos), 
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("DrawDescriptionText"), @params);
    }
    public void DrawBlackFade()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBlackFade"), @params);
    }
    public void DrawBG()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DrawBG"), @params);
    }
    public void ChangeInfoR()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeInfoR"), @params);
    }
    public void ChangeInfoL()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeInfoL"), @params);
    }
}

public unsafe class DLCManager : ObjectBase<ADLCManager>
{
    public DLCManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class Draft_EventManager : ObjectBase<ADEPRECATED_Draft_EventManager>
{
    public Draft_EventManager(IntPtr pointer) : base(pointer) {}
    public void SetLocalData(int Index, int Data)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Data", Data)
        ];
        ProcessEvent(GetFunction("SetLocalData"), @params);
    }
    public void ResumeEventSequencer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResumeEventSequencer"), @params);
    }
    public int GetLocalData(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GetLocalData"), @params);
    }
    public void ForcedRemoveMessage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForcedRemoveMessage"), @params);
    }
    public int ExecuteSelectScript()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("ExecuteSelectScript"), @params);
    }
    public int ExecuteMsgScript()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("ExecuteMsgScript"), @params);
    }
    public void ExecuteMessageWithSelect(UBmdAsset* InAsset, int InMessageNo, int InSelectNo, int InEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageNo", InMessageNo), 
            ("InSelectNo", InSelectNo), 
            ("InEventMessageID", InEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteMessageWithSelect"), @params);
    }
    public void ExecuteMessage(UBmdAsset* InAsset, int InMessageNo, int InEventMessageID)
    {
        Span<(string name, object value)> @params = [
            ("InAsset", (IntPtr)InAsset), 
            ("InMessageNo", InMessageNo), 
            ("InEventMessageID", InEventMessageID)
        ];
        ProcessEvent(GetFunction("ExecuteMessage"), @params);
    }
    public void CloseMessage()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CloseMessage"), @params);
    }
}

public unsafe class DungeonSoundDataAssets : ObjectBase<UDungeonSoundDataAssets>
{
    public DungeonSoundDataAssets(IntPtr pointer) : base(pointer) {}
}

public unsafe class DungeonSoundTableTypes : ObjectBase<UDungeonSoundTableTypes>
{
    public DungeonSoundTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class DatDlcDungeonBgmTable : ObjectBase<UDatDlcDungeonBgmTable>
{
    public DatDlcDungeonBgmTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class EventSkipWidgetDelegate : ObjectBase<UEventSkipWidgetDelegate>
{
    public EventSkipWidgetDelegate(IntPtr pointer) : base(pointer) {}
    public void CallDelegate(bool InSetEffect)
    {
        Span<(string name, object value)> @params = [
            ("InSetEffect", InSetEffect)
        ];
        ProcessEvent(GetFunction("CallDelegate"), @params);
    }
}

public unsafe class EvtCharacterDraft : ObjectBase<AEvtCharacterDraft>
{
    public EvtCharacterDraft(IntPtr pointer) : base(pointer) {}}

public unsafe class EvtDataAssets : ObjectBase<UEvtDataAssets>
{
    public EvtDataAssets(IntPtr pointer) : base(pointer) {}}

public unsafe class DatDataOffTable : ObjectBase<UDatDataOffTable>
{
    public DatDataOffTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatFadeOutTable : ObjectBase<UDatFadeOutTable>
{
    public DatFadeOutTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatAssetOverWriteTable : ObjectBase<UDatAssetOverWriteTable>
{
    public DatAssetOverWriteTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatAssetOverWriteEventTable : ObjectBase<UDatAssetOverWriteEventTable>
{
    public DatAssetOverWriteEventTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatBagEnableTable : ObjectBase<UDatBagEnableTable>
{
    public DatBagEnableTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatPersonaCombineAdjustTable : ObjectBase<UDatPersonaCombineAdjustTable>
{
    public DatPersonaCombineAdjustTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class DatObjectVisibleTable : ObjectBase<UDatObjectVisibleTable>
{
    public DatObjectVisibleTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class EvtDataLoad : ObjectBase<UEvtDataLoad>
{
    public EvtDataLoad(IntPtr pointer) : base(pointer) {}
}

public unsafe class EvtManagerStateBase : ObjectBase<UEvtManagerStateBase>
{
    public EvtManagerStateBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class EvtManagerStateBacklog : ObjectBase<UEvtManagerStateBacklog>
{
    public EvtManagerStateBacklog(IntPtr pointer) : base(pointer) {}
    public void OnBackLogFinishDelegte()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBackLogFinishDelegte"), @params);
    }
}

public unsafe class EvtManagerStateExit : ObjectBase<UEvtManagerStateExit>
{
    public EvtManagerStateExit(IntPtr pointer) : base(pointer) {}}

public unsafe class EvtManagerStateNetAnswer : ObjectBase<UEvtManagerStateNetAnswer>
{
    public EvtManagerStateNetAnswer(IntPtr pointer) : base(pointer) {}
    public void OnNetAnswerFinishDelegte()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnNetAnswerFinishDelegte"), @params);
    }
}

public unsafe class EvtManagerStatePlaying : ObjectBase<UEvtManagerStatePlaying>
{
    public EvtManagerStatePlaying(IntPtr pointer) : base(pointer) {}}

public unsafe class EvtTableTypes : ObjectBase<UEvtTableTypes>
{
    public EvtTableTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgBattleEventWipeActor : ObjectBase<AFadePgBattleEventWipeActor>
{
    public FadePgBattleEventWipeActor(IntPtr pointer) : base(pointer) {}
    public void RequestFadeOutForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestFadeOutForBP"), @params);
    }
    public void RequestFadeInForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestFadeInForBP"), @params);
    }
    public void DrawForBP(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("DrawForBP"), @params);
    }
    public void DeleteForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DeleteForBP"), @params);
    }
    public void CreateForBP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CreateForBP"), @params);
    }
}

public unsafe class FadeProgramBase : ObjectBase<UFadeProgramBase>
{
    public FadeProgramBase(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgBattleEventWipe : ObjectBase<UFadePgBattleEventWipe>
{
    public FadePgBattleEventWipe(IntPtr pointer) : base(pointer) {}
}

public unsafe class BattleResultWatcher : ObjectBase<UBattleResultWatcher>
{
    public BattleResultWatcher(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgBattleResult : ObjectBase<UFadePgBattleResult>
{
    public FadePgBattleResult(IntPtr pointer) : base(pointer) {}
}

public unsafe class FadePgBattleResultEnd : ObjectBase<UFadePgBattleResultEnd>
{
    public FadePgBattleResultEnd(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgCircle : ObjectBase<UFadePgCircle>
{
    public FadePgCircle(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgColorOut : ObjectBase<UFadePgColorOut>
{
    public FadePgColorOut(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgCrossFade : ObjectBase<UFadePgCrossFade>
{
    public FadePgCrossFade(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgDarkHour : ObjectBase<UFadePgDarkHour>
{
    public FadePgDarkHour(IntPtr pointer) : base(pointer) {}
}

public unsafe class FadePgSlide : ObjectBase<UFadePgSlide>
{
    public FadePgSlide(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgSlideVertical : ObjectBase<UFadePgSlideVertical>
{
    public FadePgSlideVertical(IntPtr pointer) : base(pointer) {}}

public unsafe class FadePgVelvet : ObjectBase<UFadePgVelvet>
{
    public FadePgVelvet(IntPtr pointer) : base(pointer) {}
}

public unsafe class FadePgVelvetReturn : ObjectBase<UFadePgVelvetReturn>
{
    public FadePgVelvetReturn(IntPtr pointer) : base(pointer) {}
}

public unsafe class FadePlayer : ObjectBase<UFadePlayer>
{
    public FadePlayer(IntPtr pointer) : base(pointer) {}
    public void SetColor(float R, float G, float B)
    {
        Span<(string name, object value)> @params = [
            ("R", R), 
            ("G", G), 
            ("B", B)
        ];
        ProcessEvent(GetFunction("SetColor"), @params);
    }
    public void OnTick(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("OnTick"), @params);
    }
    public bool IsFilled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsFilled"), @params);
    }
    public bool IsFading()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsFading"), @params);
    }
    public bool IsExistNextFade()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsExistNextFade"), @params);
    }
    public float GetRemainDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRemainDuration"), @params);
    }
    public float GetProgressRate(bool Inverse)
    {
        Span<(string name, object value)> @params = [
            ("Inverse", Inverse)
        ];
        return ProcessEvent<float>(GetFunction("GetProgressRate"), @params);
    }
    public EFadingState GetFadingState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EFadingState>(GetFunction("GetFadingState"), @params);
    }
    public EFadeMode GetFadeMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EFadeMode>(GetFunction("GetFadeMode"), @params);
    }
    public float GetFadeDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFadeDuration"), @params);
    }
    public FFadeProperties GetDefaultProperties(int Type)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type)
        ];
        return ProcessEvent<FFadeProperties>(GetFunction("GetDefaultProperties"), @params);
    }
    public float GetCurrentStateTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCurrentStateTime"), @params);
    }
    public FColor GetColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FColor>(GetFunction("GetColor"), @params);
    }
    public void FadeOut(int Type, ref FFadeProperties Props)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Props", Props)
        ];
        ProcessEvent(GetFunction("FadeOut"), @params);
    }
    public void FadeIn(int Type, ref FFadeProperties Props)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Props", Props)
        ];
        ProcessEvent(GetFunction("FadeIn"), @params);
    }
}

public unsafe class FclShopBase : ObjectBase<AFclShopBase>
{
    public FclShopBase(IntPtr pointer) : base(pointer) {}
    public void OnFinishedScr(int ExitType)
    {
        Span<(string name, object value)> @params = [
            ("ExitType", ExitType)
        ];
        ProcessEvent(GetFunction("OnFinishedScr"), @params);
    }
}

public unsafe class FclAntiqueShop : ObjectBase<AFclAntiqueShop>
{
    public FclAntiqueShop(IntPtr pointer) : base(pointer) {}
}

public unsafe class AntiqueShopDrawCommon : ObjectBase<UAntiqueShopDrawCommon>
{
    public AntiqueShopDrawCommon(IntPtr pointer) : base(pointer) {}
}

public unsafe class FclWeaponShopDrawActorBase : ObjectBase<AFclWeaponShopDrawActorBase>
{
    public FclWeaponShopDrawActorBase(IntPtr pointer) : base(pointer) {}
    public void SetMcaCamera(UMcaAsset* McaAsset, bool Play)
    {
        Span<(string name, object value)> @params = [
            ("McaAsset", (IntPtr)McaAsset), 
            ("Play", Play)
        ];
        ProcessEvent(GetFunction("SetMcaCamera"), @params);
    }
}

public unsafe class FclAntiqueShopDrawActor : ObjectBase<AFclAntiqueShopDrawActor>
{
    public FclAntiqueShopDrawActor(IntPtr pointer) : base(pointer) {}
    public void EventMcaCameraInit(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraInit"), @params);
    }
    public void EventMcaCameraExchange(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraExchange"), @params);
    }
    public void EventMcaCameraCombine(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraCombine"), @params);
    }
}

public unsafe class FclItemShop : ObjectBase<AFclItemShop>
{
    public FclItemShop(IntPtr pointer) : base(pointer) {}
}

public unsafe class FclSimpleShop : ObjectBase<AFclSimpleShop>
{
    public FclSimpleShop(IntPtr pointer) : base(pointer) {}
}

public unsafe class FclWeaponShop : ObjectBase<AFclWeaponShop>
{
    public FclWeaponShop(IntPtr pointer) : base(pointer) {}
}

public unsafe class WeaponShopDrawCommon : ObjectBase<UWeaponShopDrawCommon>
{
    public WeaponShopDrawCommon(IntPtr pointer) : base(pointer) {}
}

public unsafe class FclWeaponShopDrawActor : ObjectBase<AFclWeaponShopDrawActor>
{
    public FclWeaponShopDrawActor(IntPtr pointer) : base(pointer) {}
    public void EventMcaCameraSell(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraSell"), @params);
    }
    public void EventMcaCameraMemberSelect(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraMemberSelect"), @params);
    }
    public void EventMcaCameraInit(int Tag)
    {
        Span<(string name, object value)> @params = [
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("EventMcaCameraInit"), @params);
    }
}

public unsafe class FileNameListAssets : ObjectBase<UFileNameListAssets>
{
    public FileNameListAssets(IntPtr pointer) : base(pointer) {}
}

public unsafe class UFileNameManagerrActor : ObjectBase<AUFileNameManagerrActor>
{
    public UFileNameManagerrActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FileNameManager : ObjectBase<UFileNameManager>
{
    public FileNameManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldLocalActorComp : ObjectBase<UFldLocalActorComp>
{
    public FldLocalActorComp(IntPtr pointer) : base(pointer) {}}

public unsafe class FldAnimalCompCore : ObjectBase<UFldAnimalCompCore>
{
    public FldAnimalCompCore(IntPtr pointer) : base(pointer) {}
    public AAppPropsCore* CreateAnimalActor(UWorld* InWorld, int InIndex, TSubclassOf<AAppPropsCore> InClassPtr, FTransform InTransform, AActor* InOwner)
    {
        Span<(string name, object value)> @params = [
            ("InWorld", (IntPtr)InWorld), 
            ("InIndex", InIndex), 
            ("InClassPtr", InClassPtr), 
            ("InTransform", InTransform), 
            ("InOwner", (IntPtr)InOwner)
        ];
        return (AAppPropsCore*)ProcessEvent<IntPtr>(GetFunction("CreateAnimalActor"), @params);
    }
}

public unsafe class FldAnimalComp_BIRD : ObjectBase<UFldAnimalComp_BIRD>
{
    public FldAnimalComp_BIRD(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldAnimalComp_CAT : ObjectBase<UFldAnimalComp_CAT>
{
    public FldAnimalComp_CAT(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldAnimalComp_PIGEON : ObjectBase<UFldAnimalComp_PIGEON>
{
    public FldAnimalComp_PIGEON(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldLocalActor : ObjectBase<AFldLocalActor>
{
    public FldLocalActor(IntPtr pointer) : base(pointer) {}
    public void CallStatePatternEndDelicate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallStatePatternEndDelicate"), @params);
    }
}

public unsafe class TitleStateLogo : ObjectBase<UTitleStateLogo>
{
    public TitleStateLogo(IntPtr pointer) : base(pointer) {}
    public void OnLoadedHolder()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadedHolder"), @params);
    }
}

public unsafe class FldAnimalHit : ObjectBase<AFldAnimalHit>
{
    public FldAnimalHit(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldObjBase : ObjectBase<AFldObjBase>
{
    public FldObjBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldAnimObj : ObjectBase<AFldAnimObj>
{
    public FldAnimObj(IntPtr pointer) : base(pointer) {}
    public void PlayAnimation(int AnimeID, bool LoopFlag)
    {
        Span<(string name, object value)> @params = [
            ("AnimeID", AnimeID), 
            ("LoopFlag", LoopFlag)
        ];
        ProcessEvent(GetFunction("PlayAnimation"), @params);
    }
    public bool IsPlayingAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingAnimation"), @params);
    }
    public void InitializeArray(TArray<IntPtr> SkeleTalMeshList, int AnimeID)
    {
        Span<(string name, object value)> @params = [
            ("SkeleTalMeshList", SkeleTalMeshList), 
            ("AnimeID", AnimeID)
        ];
        ProcessEvent(GetFunction("InitializeArray"), @params);
    }
    public void Initialize(USkeletalMeshComponent* SkeletalMesh, int AnimeID)
    {
        Span<(string name, object value)> @params = [
            ("SkeletalMesh", (IntPtr)SkeletalMesh), 
            ("AnimeID", AnimeID)
        ];
        ProcessEvent(GetFunction("Initialize"), @params);
    }
    public int GetNowAnimeID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNowAnimeID"), @params);
    }
    public int GetAnimationNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetAnimationNum"), @params);
    }
    public void DebugSetting()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugSetting"), @params);
    }
    public void ChangeAnimationDEBUG()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ChangeAnimationDEBUG"), @params);
    }
}

public unsafe class FldAtomSound : ObjectBase<AFldAtomSound>
{
    public FldAtomSound(IntPtr pointer) : base(pointer) {}
    public void stopSound_IMD()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("stopSound_IMD"), @params);
    }
    public void stopSound()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("stopSound"), @params);
    }
    public void PlaySound()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlaySound"), @params);
    }
    public void FadeOutSound(float FadeOutDuration)
    {
        Span<(string name, object value)> @params = [
            ("FadeOutDuration", FadeOutDuration)
        ];
        ProcessEvent(GetFunction("FadeOutSound"), @params);
    }
    public void FadeInSound(float FadeInDuration)
    {
        Span<(string name, object value)> @params = [
            ("FadeInDuration", FadeInDuration)
        ];
        ProcessEvent(GetFunction("FadeInSound"), @params);
    }
    public bool CheckEnablePlay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckEnablePlay"), @params);
    }
}

public unsafe class FldScriptManagerCore : ObjectBase<AFldScriptManagerCore>
{
    public FldScriptManagerCore(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldAutoRecoverMenuScript : ObjectBase<AFldAutoRecoverMenuScript>
{
    public FldAutoRecoverMenuScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FldBossBattleScript : ObjectBase<AFldBossBattleScript>
{
    public FldBossBattleScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FldBpFuncLib : ObjectBase<UFldBpFuncLib>
{
    public FldBpFuncLib(IntPtr pointer) : base(pointer) {}
    public void SyncFade(UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("SyncFade"), @params);
    }
    public void StartFadeOUT(int Type, int Frame, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("StartFadeOUT"), @params);
    }
    public void StartFadeIN(int Type, int Frame, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Frame", Frame), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("StartFadeIN"), @params);
    }
    public bool ShowSubLevellOrigin(UObject* WorldContextObject, FString LevelAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelAssetPath", LevelAssetPath)
        ];
        return ProcessEvent<bool>(GetFunction("ShowSubLevellOrigin"), @params);
    }
    public void SetSkelMeshCompUpdateAnimationInEditor(USkeletalMeshComponent* Component, bool NewUpdateState)
    {
        Span<(string name, object value)> @params = [
            ("Component", (IntPtr)Component), 
            ("NewUpdateState", NewUpdateState)
        ];
        ProcessEvent(GetFunction("SetSkelMeshCompUpdateAnimationInEditor"), @params);
    }
    public void SetLocalFlag(FName FlagName, bool OnOff)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName), 
            ("OnOff", OnOff)
        ];
        ProcessEvent(GetFunction("SetLocalFlag"), @params);
    }
    public void SetLocalCounter(FName CntName, int Value)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetLocalCounter"), @params);
    }
    public void RequestUnloadSubLevellOrigin(UObject* WorldContextObject, FString LevelAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelAssetPath", LevelAssetPath)
        ];
        ProcessEvent(GetFunction("RequestUnloadSubLevellOrigin"), @params);
    }
    public void RequestLoadSubLevelOrigin(UObject* WorldContextObject, FString LevelAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelAssetPath", LevelAssetPath)
        ];
        ProcessEvent(GetFunction("RequestLoadSubLevelOrigin"), @params);
    }
    public bool HideSubLevellOrigin(UObject* WorldContextObject, FString LevelAssetPath)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelAssetPath", LevelAssetPath)
        ];
        return ProcessEvent<bool>(GetFunction("HideSubLevellOrigin"), @params);
    }
    public EFldLoadPersistentType GetPersistentType(int FieldMajorID, int FieldMinorID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID)
        ];
        return ProcessEvent<EFldLoadPersistentType>(GetFunction("GetPersistentType"), @params);
    }
    public void GetLocalFlag(FName FlagName, ref EFldBpRetFlag RetFlag)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName), 
            ("RetFlag", RetFlag)
        ];
        ProcessEvent(GetFunction("GetLocalFlag"), @params);
    }
    public int GetLocalCounter(FName CntName)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName)
        ];
        return ProcessEvent<int>(GetFunction("GetLocalCounter"), @params);
    }
    public void FldSoundManagerSetAisacValue_FRONT_VELVETROOM(float ControlValue)
    {
        Span<(string name, object value)> @params = [
            ("ControlValue", ControlValue)
        ];
        ProcessEvent(GetFunction("FldSoundManagerSetAisacValue_FRONT_VELVETROOM"), @params);
    }
    public void FldSetDisableNpcActor(int NpcMajorID, int NpcMinorID, bool ToHide)
    {
        Span<(string name, object value)> @params = [
            ("NpcMajorID", NpcMajorID), 
            ("NpcMinorID", NpcMinorID), 
            ("ToHide", ToHide)
        ];
        ProcessEvent(GetFunction("FldSetDisableNpcActor"), @params);
    }
    public void FldLibUpdateNpcLayoutTable(UDataTable* SubLevelTable, UDataTable* DataTable)
    {
        Span<(string name, object value)> @params = [
            ("SubLevelTable", (IntPtr)SubLevelTable), 
            ("DataTable", (IntPtr)DataTable)
        ];
        ProcessEvent(GetFunction("FldLibUpdateNpcLayoutTable"), @params);
    }
    public void FldLibUpdateCmmNpcLayoutTable(UDataTable* SubLevelTable, UDataTable* DataTable)
    {
        Span<(string name, object value)> @params = [
            ("SubLevelTable", (IntPtr)SubLevelTable), 
            ("DataTable", (IntPtr)DataTable)
        ];
        ProcessEvent(GetFunction("FldLibUpdateCmmNpcLayoutTable"), @params);
    }
    public AActor* FldGetPlayerActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("FldGetPlayerActor"), @params);
    }
    public void FldDispCriAtomExDebugResourcesInfo()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FldDispCriAtomExDebugResourcesInfo"), @params);
    }
    public void FldCommitViewports()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FldCommitViewports"), @params);
    }
    public void CheckRegistedSubLevel(UObject* WorldContextObject, FString LevelName, ref EFldBpRetBool Result)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LevelName", LevelName), 
            ("Result", Result)
        ];
        ProcessEvent(GetFunction("CheckRegistedSubLevel"), @params);
    }
    public void CheckLoadedCommonDataSyncBlock()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CheckLoadedCommonDataSyncBlock"), @params);
    }
    public void CheckLoadedCommonData(UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("CheckLoadedCommonData"), @params);
    }
    public void CallFieldLevel(int FieldMajorID, int FieldMinorID, int TotalDay, ECldTimeZone TimeZone, int StartID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID), 
            ("TotalDay", TotalDay), 
            ("TimeZone", TimeZone), 
            ("StartID", StartID)
        ];
        ProcessEvent(GetFunction("CallFieldLevel"), @params);
    }
    public void CallFieldKeyFreeEventLevel(int FieldMajorID, int FieldMinorID, int TotalDay, ECldTimeZone TimeZone, int eventId, int PlayerStartID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID), 
            ("TotalDay", TotalDay), 
            ("TimeZone", TimeZone), 
            ("eventId", eventId), 
            ("PlayerStartID", PlayerStartID)
        ];
        ProcessEvent(GetFunction("CallFieldKeyFreeEventLevel"), @params);
    }
}

public unsafe class FldCameraBase : ObjectBase<AFldCameraBase>
{
    public FldCameraBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCamera : ObjectBase<AFldCamera>
{
    public FldCamera(IntPtr pointer) : base(pointer) {}}

public unsafe class FldCameraBehaviorBase : ObjectBase<UFldCameraBehaviorBase>
{
    public FldCameraBehaviorBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraBehaviorFixed : ObjectBase<UFldCameraBehaviorFixed>
{
    public FldCameraBehaviorFixed(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraBehaviorFree : ObjectBase<UFldCameraBehaviorFree>
{
    public FldCameraBehaviorFree(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraFixed : ObjectBase<AFldCameraFixed>
{
    public FldCameraFixed(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraFree : ObjectBase<AFldCameraFree>
{
    public FldCameraFree(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraHitBase : ObjectBase<AFldCameraHitBase>
{
    public FldCameraHitBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraHitBox : ObjectBase<AFldCameraHitBox>
{
    public FldCameraHitBox(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraHitSpline : ObjectBase<AFldCameraHitSpline>
{
    public FldCameraHitSpline(IntPtr pointer) : base(pointer) {}
    public void SetupCamera()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetupCamera"), @params);
    }
}

public unsafe class FldCameraSpline : ObjectBase<AFldCameraSpline>
{
    public FldCameraSpline(IntPtr pointer) : base(pointer) {}}

public unsafe class FldCameraTransBase : ObjectBase<UFldCameraTransBase>
{
    public FldCameraTransBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraTransLinear : ObjectBase<UFldCameraTransLinear>
{
    public FldCameraTransLinear(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCameraUtility : ObjectBase<UFldCameraUtility>
{
    public FldCameraUtility(IntPtr pointer) : base(pointer) {}}

public unsafe class FldCharAccessIconMngComp : ObjectBase<UFldCharAccessIconMngComp>
{
    public FldCharAccessIconMngComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharAttackAnimNotify : ObjectBase<UFldCharAttackAnimNotify>
{
    public FldCharAttackAnimNotify(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharArea : ObjectBase<AFldCharArea>
{
    public FldCharArea(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharDataAsset : ObjectBase<UFldCharDataAsset>
{
    public FldCharDataAsset(IntPtr pointer) : base(pointer) {}
    public void PlayerOutputLog()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayerOutputLog"), @params);
    }
}

public unsafe class FldCharParamTable : ObjectBase<UFldCharParamTable>
{
    public FldCharParamTable(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharEmotionIconMngComp : ObjectBase<UFldCharEmotionIconMngComp>
{
    public FldCharEmotionIconMngComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharPersonalMotionComp : ObjectBase<UFldCharPersonalMotionComp>
{
    public FldCharPersonalMotionComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCharSysBPFL : ObjectBase<UFldCharSysBPFL>
{
    public FldCharSysBPFL(IntPtr pointer) : base(pointer) {}
    public UAnimMontage* PlayAnimSequence(USkeletalMeshComponent* Target, UAnimSequenceBase* Anim, bool Loop)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("Anim", (IntPtr)Anim), 
            ("Loop", Loop)
        ];
        return (UAnimMontage*)ProcessEvent<IntPtr>(GetFunction("PlayAnimSequence"), @params);
    }
}

public unsafe class FldHitCore : ObjectBase<AFldHitCore>
{
    public FldHitCore(IntPtr pointer) : base(pointer) {}
    public void RequestKeyPushBluePrint()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestKeyPushBluePrint"), @params);
    }
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
    public void CleanupRequest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CleanupRequest"), @params);
    }
}

public unsafe class FldHitCharacter : ObjectBase<AFldHitCharacter>
{
    public FldHitCharacter(IntPtr pointer) : base(pointer) {}
    public int GetCharaModelNum()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCharaModelNum"), @params);
    }
    public UFldNpcComp* GetCharaModelNpcComp(int ModelIndex)
    {
        Span<(string name, object value)> @params = [
            ("ModelIndex", ModelIndex)
        ];
        return (UFldNpcComp*)ProcessEvent<IntPtr>(GetFunction("GetCharaModelNpcComp"), @params);
    }
    public void EndDelicate_SyncMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndDelicate_SyncMotion"), @params);
    }
    public void EndDelicate_RotationToPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndDelicate_RotationToPlayer"), @params);
    }
    public void EndDelicate_ReturnBaseRotator()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndDelicate_ReturnBaseRotator"), @params);
    }
    public void EndDelicate_ProcHeroPrevAction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndDelicate_ProcHeroPrevAction"), @params);
    }
}

public unsafe class FldCmmActor : ObjectBase<AFldCmmActor>
{
    public FldCmmActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCmnDataActor : ObjectBase<AFldCmnDataActor>
{
    public FldCmnDataActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCommonData : ObjectBase<UFldCommonData>
{
    public FldCommonData(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCrowdIdleBehaviorComp : ObjectBase<UFldCrowdIdleBehaviorComp>
{
    public FldCrowdIdleBehaviorComp(IntPtr pointer) : base(pointer) {}
    public void UpdateProc(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateProc"), @params);
    }
}

public unsafe class FldCrowdNpcBase : ObjectBase<AFldCrowdNpcBase>
{
    public FldCrowdNpcBase(IntPtr pointer) : base(pointer) {}
    public float UpdateOpacityByPlayerActor(float Opacity, AActor* TargetActor)
    {
        Span<(string name, object value)> @params = [
            ("Opacity", Opacity), 
            ("TargetActor", (IntPtr)TargetActor)
        ];
        return ProcessEvent<float>(GetFunction("UpdateOpacityByPlayerActor"), @params);
    }
}

public unsafe class FldCrowdOpacityComp : ObjectBase<UFldCrowdOpacityComp>
{
    public FldCrowdOpacityComp(IntPtr pointer) : base(pointer) {}
    public void UpdateProc(float DeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("DeltaTime", DeltaTime)
        ];
        ProcessEvent(GetFunction("UpdateProc"), @params);
    }
}

public unsafe class FldCrowdTarget : ObjectBase<AFldCrowdTarget>
{
    public FldCrowdTarget(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCrowdTarget_STOP : ObjectBase<AFldCrowdTarget_STOP>
{
    public FldCrowdTarget_STOP(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldCrowdWalkManager : ObjectBase<AFldCrowdWalkManager>
{
    public FldCrowdWalkManager(IntPtr pointer) : base(pointer) {}
    public void SaveMobWalkInitTable(UDataTable* InitTable)
    {
        Span<(string name, object value)> @params = [
            ("InitTable", (IntPtr)InitTable)
        ];
        ProcessEvent(GetFunction("SaveMobWalkInitTable"), @params);
    }
}

public unsafe class FldCrowdWalkOpacityComp : ObjectBase<UFldCrowdWalkOpacityComp>
{
    public FldCrowdWalkOpacityComp(IntPtr pointer) : base(pointer) {}
    public void SetPointLocation(FVector StartPoint, FVector EndPoint)
    {
        Span<(string name, object value)> @params = [
            ("StartPoint", StartPoint), 
            ("EndPoint", EndPoint)
        ];
        ProcessEvent(GetFunction("SetPointLocation"), @params);
    }
}

public unsafe class FldDailyMenuScript : ObjectBase<AFldDailyMenuScript>
{
    public FldDailyMenuScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDbgChLoad : ObjectBase<AFldDbgChLoad>
{
    public FldDbgChLoad(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDbgEmMaker : ObjectBase<AFldDbgEmMaker>
{
    public FldDbgEmMaker(IntPtr pointer) : base(pointer) {}
    public void SetScale(AActor* Target, float Scale)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("SetScale"), @params);
    }
}

public unsafe class FldDbgMaker : ObjectBase<AFldDbgMaker>
{
    public FldDbgMaker(IntPtr pointer) : base(pointer) {}
    public bool Load()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Load"), @params);
    }
    public APawn* GetPlayerActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (APawn*)ProcessEvent<IntPtr>(GetFunction("GetPlayerActor"), @params);
    }
    public TArray<IntPtr> GetPartnerActors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetPartnerActors"), @params);
    }
    public void ForceWaitPose(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("ForceWaitPose"), @params);
    }
}

public unsafe class FldDbgNpcMaker : ObjectBase<AFldDbgNpcMaker>
{
    public FldDbgNpcMaker(IntPtr pointer) : base(pointer) {}
    public TArray<IntPtr> GetNpcActors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetNpcActors"), @params);
    }
    public APawn* GetNpcActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (APawn*)ProcessEvent<IntPtr>(GetFunction("GetNpcActor"), @params);
    }
}

public unsafe class FldDungeonTable : ObjectBase<UFldDungeonTable>
{
    public FldDungeonTable(IntPtr pointer) : base(pointer) {}
    public void Import()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Import"), @params);
    }
}

public unsafe class FldDoorPointComp : ObjectBase<UFldDoorPointComp>
{
    public FldDoorPointComp(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDoorObjCore : ObjectBase<AFldDoorObjCore>
{
    public FldDoorObjCore(IntPtr pointer) : base(pointer) {}
    public void PlayDoorOpenWithFade(EFldDoorOpenType OpenType, int FadeType, int FadeFrame, int FadePattern)
    {
        Span<(string name, object value)> @params = [
            ("OpenType", OpenType), 
            ("FadeType", FadeType), 
            ("FadeFrame", FadeFrame), 
            ("FadePattern", FadePattern)
        ];
        ProcessEvent(GetFunction("PlayDoorOpenWithFade"), @params);
    }
    public void PlayDoorOpen(EFldDoorOpenType OpenType)
    {
        Span<(string name, object value)> @params = [
            ("OpenType", OpenType)
        ];
        ProcessEvent(GetFunction("PlayDoorOpen"), @params);
    }
    public bool IsPlayingOpen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingOpen"), @params);
    }
    public void CallStateEndDelicate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CallStateEndDelicate"), @params);
    }
}

public unsafe class FldDungeonComponentBase : ObjectBase<UFldDungeonComponentBase>
{
    public FldDungeonComponentBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonAccidentController : ObjectBase<UFldDungeonAccidentController>
{
    public FldDungeonAccidentController(IntPtr pointer) : base(pointer) {}}

public unsafe class DungeonAssetData : ObjectBase<UDungeonAssetData>
{
    public DungeonAssetData(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonAutoGenerateBaseActor : ObjectBase<AFldDungeonAutoGenerateBaseActor>
{
    public FldDungeonAutoGenerateBaseActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonAutoGenerateActor : ObjectBase<AFldDungeonAutoGenerateActor>
{
    public FldDungeonAutoGenerateActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonBase : ObjectBase<AFldDungeonBase>
{
    public FldDungeonBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonBattleEncount : ObjectBase<AFldDungeonBattleEncount>
{
    public FldDungeonBattleEncount(IntPtr pointer) : base(pointer) {}
    public void WaitVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("WaitVisible"), @params);
    }
    public void WaitFadeOut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("WaitFadeOut"), @params);
    }
    public void WaitEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("WaitEnd"), @params);
    }
    public void Idle()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Idle"), @params);
    }
    public void ExcuteWipe()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ExcuteWipe"), @params);
    }
    public void End()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("End"), @params);
    }
    public void CaptureWait()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CaptureWait"), @params);
    }
}

public unsafe class FldDungeonBattleResult : ObjectBase<AFldDungeonBattleResult>
{
    public FldDungeonBattleResult(IntPtr pointer) : base(pointer) {}
    public void Wait()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Wait"), @params);
    }
    public void StartScript()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartScript"), @params);
    }
    public void Run()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Run"), @params);
    }
    public void Load()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Load"), @params);
    }
    public void Init()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Init"), @params);
    }
    public void End()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("End"), @params);
    }
}

public unsafe class FldDungeonRollBack : ObjectBase<AFldDungeonRollBack>
{
    public FldDungeonRollBack(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonBattleRetry : ObjectBase<AFldDungeonBattleRetry>
{
    public FldDungeonBattleRetry(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonBrokenObjController : ObjectBase<UFldDungeonBrokenObjController>
{
    public FldDungeonBrokenObjController(IntPtr pointer) : base(pointer) {}
    public void HitEvent(EDungeonObjHitEvent EventType, int ID, AFldDungeonObjectActor* pObject)
    {
        Span<(string name, object value)> @params = [
            ("EventType", EventType), 
            ("ID", ID), 
            ("pObject", (IntPtr)pObject)
        ];
        ProcessEvent(GetFunction("HitEvent"), @params);
    }
}

public unsafe class FldDungeonClockController : ObjectBase<UFldDungeonClockController>
{
    public FldDungeonClockController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonScriptActor : ObjectBase<AFldDungeonScriptActor>
{
    public FldDungeonScriptActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonGameBase : ObjectBase<AFldDungeonGameBase>
{
    public FldDungeonGameBase(IntPtr pointer) : base(pointer) {}
    public void NotifyLevelUnLoadedNavMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelUnLoadedNavMesh"), @params);
    }
    public void NotifyLevelUnLoadedMap()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelUnLoadedMap"), @params);
    }
    public void NotifyLevelUnLoadedEnv()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelUnLoadedEnv"), @params);
    }
    public void NotifyLevelLoadedNavMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedNavMesh"), @params);
    }
    public void NotifyLevelLoadedFloorBase()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedFloorBase"), @params);
    }
    public void NotifyLevelLoadedFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedFloor"), @params);
    }
    public void NotifyLevelLoadedFixedFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedFixedFloor"), @params);
    }
    public void NotifyLevelLoadedEnvironment()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedEnvironment"), @params);
    }
    public void NotifyLevelLoadedDesignMap()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NotifyLevelLoadedDesignMap"), @params);
    }
}

public unsafe class FldDungeonGameInit : ObjectBase<AFldDungeonGameInit>
{
    public FldDungeonGameInit(IntPtr pointer) : base(pointer) {}
    public void NAVMESH_LOAD_WAIT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("NAVMESH_LOAD_WAIT"), @params);
    }
    public void LOAD_WAIT_LEVEL()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LOAD_WAIT_LEVEL"), @params);
    }
    public void LOAD_START()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LOAD_START"), @params);
    }
    public void INIT_FLOOR_LEVEL()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("INIT_FLOOR_LEVEL"), @params);
    }
    public void INIT_FIXED_FLOOR()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("INIT_FIXED_FLOOR"), @params);
    }
    public void INIT_END()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("INIT_END"), @params);
    }
    public void INIT_DESIGIN_MAP()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("INIT_DESIGIN_MAP"), @params);
    }
    public void FloorInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FloorInit"), @params);
    }
    public void DungeonInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DungeonInit"), @params);
    }
    public void CREATE_LAYOUT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CREATE_LAYOUT"), @params);
    }
    public void CREATE_END()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CREATE_END"), @params);
    }
    public void ATTACH_OBJ_WAIT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ATTACH_OBJ_WAIT"), @params);
    }
    public void ADVANCE_PROCESS_WAIT()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ADVANCE_PROCESS_WAIT"), @params);
    }
    public void ADVANCE_PROCESS()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ADVANCE_PROCESS"), @params);
    }
    public void ADVANCE_LOAD()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ADVANCE_LOAD"), @params);
    }
}

public unsafe class FldDungeonGame : ObjectBase<AFldDungeonGame>
{
    public FldDungeonGame(IntPtr pointer) : base(pointer) {}
    public bool IsBattle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBattle"), @params);
    }
    public void ForceEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceEncount"), @params);
    }
    public void BattleSync()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BattleSync"), @params);
    }
}

public unsafe class FldDungeonControlActor : ObjectBase<AFldDungeonControlActor>
{
    public FldDungeonControlActor(IntPtr pointer) : base(pointer) {}
    public void SetNextFieldFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetNextFieldFloor"), @params);
    }
    public void SetField(int major, int Minor, int idx)
    {
        Span<(string name, object value)> @params = [
            ("major", major), 
            ("Minor", Minor), 
            ("idx", idx)
        ];
        ProcessEvent(GetFunction("SetField"), @params);
    }
    public bool IsExist()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsExist"), @params);
    }
    public void Delete()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Delete"), @params);
    }
    public void DebugSetPrevFieldFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugSetPrevFieldFloor"), @params);
    }
    public void DebugSetNextFieldFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DebugSetNextFieldFloor"), @params);
    }
    public AFldDungeonControlActor* Create()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AFldDungeonControlActor*)ProcessEvent<IntPtr>(GetFunction("Create"), @params);
    }
    public bool CheckReady()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckReady"), @params);
    }
}

public unsafe class FldDungeonDebugController : ObjectBase<UFldDungeonDebugController>
{
    public FldDungeonDebugController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonEffectController : ObjectBase<UFldDungeonEffectController>
{
    public FldDungeonEffectController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonEffectActor : ObjectBase<AFldDungeonEffectActor>
{
    public FldDungeonEffectActor(IntPtr pointer) : base(pointer) {}
    public void SetPlayEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetPlayEnd"), @params);
    }
    public void RequestFadeOut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestFadeOut"), @params);
    }
    public bool IsPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlay"), @params);
    }
    public float GetPlayTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayTime"), @params);
    }
    public float GetFadeValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFadeValue"), @params);
    }
    public float GetFadeOutTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFadeOutTime"), @params);
    }
    public float GetFadeInTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFadeInTime"), @params);
    }
    public void BPUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPUpdate"), @params);
    }
    public void BPInit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPInit"), @params);
    }
}

public unsafe class FldDungeonEffectTartarosSearch : ObjectBase<UFldDungeonEffectTartarosSearch>
{
    public FldDungeonEffectTartarosSearch(IntPtr pointer) : base(pointer) {}
    public float GetRadius()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRadius"), @params);
    }
    public float GetMaxBrightness()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxBrightness"), @params);
    }
    public float GetLifeSpan()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetLifeSpan"), @params);
    }
    public float GetIntensity()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetIntensity"), @params);
    }
}

public unsafe class FldDungeonEffectCameraAttachActor : ObjectBase<AFldDungeonEffectCameraAttachActor>
{
    public FldDungeonEffectCameraAttachActor(IntPtr pointer) : base(pointer) {}
    public void OnComplete(UNiagaraComponent* PSystem)
    {
        Span<(string name, object value)> @params = [
            ("PSystem", (IntPtr)PSystem)
        ];
        ProcessEvent(GetFunction("OnComplete"), @params);
    }
}

public unsafe class FldDungeonEncountController : ObjectBase<UFldDungeonEncountController>
{
    public FldDungeonEncountController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonEnemyController : ObjectBase<UFldDungeonEnemyController>
{
    public FldDungeonEnemyController(IntPtr pointer) : base(pointer) {}
    public void FixedFloorLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FixedFloorLoad"), @params);
    }
    public void FixedFloorCreateActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FixedFloorCreateActor"), @params);
    }
    public void FixedFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FixedFloorAdvanceProcess"), @params);
    }
    public void DesignFloorLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DesignFloorLoad"), @params);
    }
    public void DesignFloorCreateActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DesignFloorCreateActor"), @params);
    }
    public void DesignFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DesignFloorAdvanceProcess"), @params);
    }
    public void AutoFloorLoad()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoFloorLoad"), @params);
    }
    public void AutoFloorCreateActor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoFloorCreateActor"), @params);
    }
    public void AutoFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoFloorAdvanceProcess"), @params);
    }
}

public unsafe class FldDungeonEnvController : ObjectBase<UFldDungeonEnvController>
{
    public FldDungeonEnvController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonEnvActor : ObjectBase<AFldDungeonEnvActor>
{
    public FldDungeonEnvActor(IntPtr pointer) : base(pointer) {}
    public void BPUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPUpdate"), @params);
    }
    public void BPSetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPSetDefault"), @params);
    }
    public void BPResume()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPResume"), @params);
    }
    public void BPReflect()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPReflect"), @params);
    }
    public void BPPause()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPPause"), @params);
    }
    public void BPGetDefault()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPGetDefault"), @params);
    }
}

public unsafe class FldDungeonEventController : ObjectBase<UFldDungeonEventController>
{
    public FldDungeonEventController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonEventTransActor : ObjectBase<AFldDungeonEventTransActor>
{
    public FldDungeonEventTransActor(IntPtr pointer) : base(pointer) {}
    public void SetPartyTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetPartyTransform"), @params);
    }
}

public unsafe class FldDungeonEventRefActor : ObjectBase<AFldDungeonEventRefActor>
{
    public FldDungeonEventRefActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonFloorFlagsDataAsset : ObjectBase<UFldDungeonFloorFlagsDataAsset>
{
    public FldDungeonFloorFlagsDataAsset(IntPtr pointer) : base(pointer) {}
    public void SearchTag()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SearchTag"), @params);
    }
    public void SearchFloor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SearchFloor"), @params);
    }
    public void SearchFlag()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SearchFlag"), @params);
    }
    public void Input()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Input"), @params);
    }
}

public unsafe class FldDungeonFloorFlags : ObjectBase<UFldDungeonFloorFlags>
{
    public FldDungeonFloorFlags(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonForbiddenDoorController : ObjectBase<UFldDungeonForbiddenDoorController>
{
    public FldDungeonForbiddenDoorController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonInfoActor : ObjectBase<AFldDungeonInfoActor>
{
    public FldDungeonInfoActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonObjectInfoActor : ObjectBase<AFldDungeonObjectInfoActor>
{
    public FldDungeonObjectInfoActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonInfoSupportController : ObjectBase<UFldDungeonInfoSupportController>
{
    public FldDungeonInfoSupportController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonLayoutActor : ObjectBase<AFldDungeonLayoutActor>
{
    public FldDungeonLayoutActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutStartActor : ObjectBase<AFldDungeonLayoutStartActor>
{
    public FldDungeonLayoutStartActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutEnemyActor : ObjectBase<AFldDungeonLayoutEnemyActor>
{
    public FldDungeonLayoutEnemyActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutDirectActor : ObjectBase<AFldDungeonLayoutDirectActor>
{
    public FldDungeonLayoutDirectActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutDirectEnemyActor : ObjectBase<AFldDungeonLayoutDirectEnemyActor>
{
    public FldDungeonLayoutDirectEnemyActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutDirectTBoxActor : ObjectBase<AFldDungeonLayoutDirectTBoxActor>
{
    public FldDungeonLayoutDirectTBoxActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLayoutBrokenActor : ObjectBase<AFldDungeonLayoutBrokenActor>
{
    public FldDungeonLayoutBrokenActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonLoader : ObjectBase<AFldDungeonLoader>
{
    public FldDungeonLoader(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonMenuScript : ObjectBase<AFldDungeonMenuScript>
{
    public FldDungeonMenuScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonMissingController : ObjectBase<UFldDungeonMissingController>
{
    public FldDungeonMissingController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonObjectActor : ObjectBase<AFldDungeonObjectActor>
{
    public FldDungeonObjectActor(IntPtr pointer) : base(pointer) {}
    public void HitOutNotice(AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("HitOutNotice"), @params);
    }
    public void HitInNotice(AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("HitInNotice"), @params);
    }
    public void HitActionNotice(APawn* Player)
    {
        Span<(string name, object value)> @params = [
            ("Player", (IntPtr)Player)
        ];
        ProcessEvent(GetFunction("HitActionNotice"), @params);
    }
}

public unsafe class FldDungeonParamDataAsset : ObjectBase<UFldDungeonParamDataAsset>
{
    public FldDungeonParamDataAsset(IntPtr pointer) : base(pointer) {}
    public void ImportLevelPath()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ImportLevelPath"), @params);
    }
    public void ImportDataPath()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ImportDataPath"), @params);
    }
    public void GenEnemyModelID()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GenEnemyModelID"), @params);
    }
    public void DelResetData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DelResetData"), @params);
    }
    public void AddResetData()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AddResetData"), @params);
    }
}

public unsafe class FldDungeonParamActor : ObjectBase<AFldDungeonParamActor>
{
    public FldDungeonParamActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonPartController : ObjectBase<UFldDungeonPartController>
{
    public FldDungeonPartController(IntPtr pointer) : base(pointer) {}
    public void InitFixedMap()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitFixedMap"), @params);
    }
    public void InitDesignMap()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitDesignMap"), @params);
    }
    public void AutoLoadPart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoLoadPart"), @params);
    }
    public void AutoCreatePart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoCreatePart"), @params);
    }
}

public unsafe class FldDungeonPartActor : ObjectBase<AFldDungeonPartActor>
{
    public FldDungeonPartActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonFDoorPartActor : ObjectBase<AFldDungeonFDoorPartActor>
{
    public FldDungeonFDoorPartActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonPartnerController : ObjectBase<UFldDungeonPartnerController>
{
    public FldDungeonPartnerController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonPartVariationDataAsset : ObjectBase<UFldDungeonPartVariationDataAsset>
{
    public FldDungeonPartVariationDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonPartVariation : ObjectBase<UFldDungeonPartVariation>
{
    public FldDungeonPartVariation(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonReaperController : ObjectBase<UFldDungeonReaperController>
{
    public FldDungeonReaperController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonRecoverController : ObjectBase<UFldDungeonRecoverController>
{
    public FldDungeonRecoverController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonResourceServer : ObjectBase<AFldDungeonResourceServer>
{
    public FldDungeonResourceServer(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonSecretGateController : ObjectBase<UFldDungeonSecretGateController>
{
    public FldDungeonSecretGateController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonSeparatelyController : ObjectBase<UFldDungeonSeparatelyController>
{
    public FldDungeonSeparatelyController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonSetupController : ObjectBase<UFldDungeonSetupController>
{
    public FldDungeonSetupController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonSoundBaseActor : ObjectBase<AFldDungeonSoundBaseActor>
{
    public FldDungeonSoundBaseActor(IntPtr pointer) : base(pointer) {}
    public void BPStop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPStop"), @params);
    }
    public void BPPlay()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BPPlay"), @params);
    }
}

public unsafe class FldDungeonSoundActor : ObjectBase<AFldDungeonSoundActor>
{
    public FldDungeonSoundActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonStartParam : ObjectBase<UFldDungeonStartParam>
{
    public FldDungeonStartParam(IntPtr pointer) : base(pointer) {}
    public void SetStartParam(int major, int Minor, int idx, bool bScript)
    {
        Span<(string name, object value)> @params = [
            ("major", major), 
            ("Minor", Minor), 
            ("idx", idx), 
            ("bScript", bScript)
        ];
        ProcessEvent(GetFunction("SetStartParam"), @params);
    }
    public bool CheckStartParam()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckStartParam"), @params);
    }
}

public unsafe class FldDungeonStartActor : ObjectBase<AFldDungeonStartActor>
{
    public FldDungeonStartActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonSupportSkillController : ObjectBase<UFldDungeonSupportSkillController>
{
    public FldDungeonSupportSkillController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonTalkController : ObjectBase<UFldDungeonTalkController>
{
    public FldDungeonTalkController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldDungeonTBoxController : ObjectBase<UFldDungeonTBoxController>
{
    public FldDungeonTBoxController(IntPtr pointer) : base(pointer) {}
    public void HitEvent(EDungeonObjHitEvent EventType, int ID, AFldDungeonObjectActor* pObject)
    {
        Span<(string name, object value)> @params = [
            ("EventType", EventType), 
            ("ID", ID), 
            ("pObject", (IntPtr)pObject)
        ];
        ProcessEvent(GetFunction("HitEvent"), @params);
    }
    public void ForbiddenDoorHitEvent(EDungeonObjHitEvent EventType, int ID, AFldDungeonObjectActor* pObject)
    {
        Span<(string name, object value)> @params = [
            ("EventType", EventType), 
            ("ID", ID), 
            ("pObject", (IntPtr)pObject)
        ];
        ProcessEvent(GetFunction("ForbiddenDoorHitEvent"), @params);
    }
    public void FixedFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FixedFloorAdvanceProcess"), @params);
    }
    public void DesignFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DesignFloorAdvanceProcess"), @params);
    }
    public void AutoFloorAdvanceProcess()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("AutoFloorAdvanceProcess"), @params);
    }
}

public unsafe class FldDungeonTransferController : ObjectBase<UFldDungeonTransferController>
{
    public FldDungeonTransferController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonUIController : ObjectBase<UFldDungeonUIController>
{
    public FldDungeonUIController(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldDungeonUIActor : ObjectBase<AFldDungeonUIActor>
{
    public FldDungeonUIActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldEnemyComp : ObjectBase<UFldEnemyComp>
{
    public FldEnemyComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldEnemyController : ObjectBase<AFldEnemyController>
{
    public FldEnemyController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldEnemyForbiddenDoorComp : ObjectBase<UFldEnemyForbiddenDoorComp>
{
    public FldEnemyForbiddenDoorComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldEnemyManager : ObjectBase<AFldEnemyManager>
{
    public FldEnemyManager(IntPtr pointer) : base(pointer) {}
    public void Setup(AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("Setup"), @params);
    }
    public void SetEnable(bool Enable, int Group)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable), 
            ("Group", Group)
        ];
        ProcessEvent(GetFunction("SetEnable"), @params);
    }
    public void ForceEncount()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceEncount"), @params);
    }
    public void Cleanup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Cleanup"), @params);
    }
    public void Add(AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("Add"), @params);
    }
}

public unsafe class FldEnemyNormalComp : ObjectBase<UFldEnemyNormalComp>
{
    public FldEnemyNormalComp(IntPtr pointer) : base(pointer) {}
    public void OnMontageEnded(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageEnded"), @params);
    }
}

public unsafe class FldEnemyDataAsset : ObjectBase<UFldEnemyDataAsset>
{
    public FldEnemyDataAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldEnemyFootprintDA : ObjectBase<UFldEnemyFootprintDA>
{
    public FldEnemyFootprintDA(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldEnemyUniqueComp : ObjectBase<UFldEnemyUniqueComp>
{
    public FldEnemyUniqueComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldFieldEventActor : ObjectBase<AFldFieldEventActor>
{
    public FldFieldEventActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldFollowerComp : ObjectBase<UFldFollowerComp>
{
    public FldFollowerComp(IntPtr pointer) : base(pointer) {}
    public void ProcOutEvent(AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("ProcOutEvent"), @params);
    }
    public void ProcInEvent(AActor* OtherActor)
    {
        Span<(string name, object value)> @params = [
            ("OtherActor", (IntPtr)OtherActor)
        ];
        ProcessEvent(GetFunction("ProcInEvent"), @params);
    }
    public void GetAwayHeroRequest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GetAwayHeroRequest"), @params);
    }
    public void CleanupRequest()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CleanupRequest"), @params);
    }
    public void CheckEnableAction(APawn* Player, ref bool Check)
    {
        Span<(string name, object value)> @params = [
            ("Player", (IntPtr)Player), 
            ("Check", Check)
        ];
        ProcessEvent(GetFunction("CheckEnableAction"), @params);
    }
    public void ActoinRequest(APawn* Player)
    {
        Span<(string name, object value)> @params = [
            ("Player", (IntPtr)Player)
        ];
        ProcessEvent(GetFunction("ActoinRequest"), @params);
    }
}

public unsafe class FldFollowerController : ObjectBase<AFldFollowerController>
{
    public FldFollowerController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldFollowerPointComp : ObjectBase<UFldFollowerPointComp>
{
    public FldFollowerPointComp(IntPtr pointer) : base(pointer) {}}

public unsafe class FldSaveCallField : ObjectBase<UFldSaveCallField>
{
    public FldSaveCallField(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitActor : ObjectBase<AFldHitActor>
{
    public FldHitActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldHitActorBOX : ObjectBase<AFldHitActorBOX>
{
    public FldHitActorBOX(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitActorCAPSULE : ObjectBase<AFldHitActorCAPSULE>
{
    public FldHitActorCAPSULE(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitActorEachPlayer : ObjectBase<AFldHitActorEachPlayer>
{
    public FldHitActorEachPlayer(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldHitCharaIdleBehaviorComp : ObjectBase<UFldHitCharaIdleBehaviorComp>
{
    public FldHitCharaIdleBehaviorComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldHitCharaIdleTalkComp : ObjectBase<UFldHitCharaIdleTalkComp>
{
    public FldHitCharaIdleTalkComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldHitPartner : ObjectBase<AFldHitPartner>
{
    public FldHitPartner(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldHitSoundCore : ObjectBase<AFldHitSoundCore>
{
    public FldHitSoundCore(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldHitSound_BOX : ObjectBase<AFldHitSound_BOX>
{
    public FldHitSound_BOX(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitSound_CIRCLE : ObjectBase<AFldHitSound_CIRCLE>
{
    public FldHitSound_CIRCLE(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitSoundSnapshotCore : ObjectBase<AFldHitSoundSnapshotCore>
{
    public FldHitSoundSnapshotCore(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldHitSoundSnapshot_BOX : ObjectBase<AFldHitSoundSnapshot_BOX>
{
    public FldHitSoundSnapshot_BOX(IntPtr pointer) : base(pointer) {}}

public unsafe class FldHitSoundSnapshot_CIRCLE : ObjectBase<AFldHitSoundSnapshot_CIRCLE>
{
    public FldHitSoundSnapshot_CIRCLE(IntPtr pointer) : base(pointer) {}}

public unsafe class FldInitScriptManager : ObjectBase<AFldInitScriptManager>
{
    public FldInitScriptManager(IntPtr pointer) : base(pointer) {}}

public unsafe class FldKeyFreeAnnounceActor : ObjectBase<AFldKeyFreeAnnounceActor>
{
    public FldKeyFreeAnnounceActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldKeyFreeEventActor : ObjectBase<AFldKeyFreeEventActor>
{
    public FldKeyFreeEventActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldLevelLoaderMonitorActor : ObjectBase<AFldLevelLoaderMonitorActor>
{
    public FldLevelLoaderMonitorActor(IntPtr pointer) : base(pointer) {}
    public void OnLoadLevelStreaming()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnLoadLevelStreaming"), @params);
    }
}

public unsafe class FldLevelManager : ObjectBase<AFldLevelManager>
{
    public FldLevelManager(IntPtr pointer) : base(pointer) {}}

public unsafe class FldLevelPoolManager : ObjectBase<AFldLevelPoolManager>
{
    public FldLevelPoolManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldLinkAnimHitBase : ObjectBase<AFldLinkAnimHitBase>
{
    public FldLinkAnimHitBase(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldLinkAnimHit_BOX : ObjectBase<AFldLinkAnimHit_BOX>
{
    public FldLinkAnimHit_BOX(IntPtr pointer) : base(pointer) {}}

public unsafe class FldLinkAnimHit_CIRCLE : ObjectBase<AFldLinkAnimHit_CIRCLE>
{
    public FldLinkAnimHit_CIRCLE(IntPtr pointer) : base(pointer) {}}

public unsafe class FldLinkAnimHitComp_BOX : ObjectBase<UFldLinkAnimHitComp_BOX>
{
    public FldLinkAnimHitComp_BOX(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldLinkAnimHitComp_CIRCLE : ObjectBase<UFldLinkAnimHitComp_CIRCLE>
{
    public FldLinkAnimHitComp_CIRCLE(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldLinkAnimObj : ObjectBase<AFldLinkAnimObj>
{
    public FldLinkAnimObj(IntPtr pointer) : base(pointer) {}
    public void InitializeArray(TArray<IntPtr> SkeleTalMeshList)
    {
        Span<(string name, object value)> @params = [
            ("SkeleTalMeshList", SkeleTalMeshList)
        ];
        ProcessEvent(GetFunction("InitializeArray"), @params);
    }
    public void Initialize(USkeletalMeshComponent* SkeletalMesh)
    {
        Span<(string name, object value)> @params = [
            ("SkeletalMesh", (IntPtr)SkeletalMesh)
        ];
        ProcessEvent(GetFunction("Initialize"), @params);
    }
}

public unsafe class FldLmapManager : ObjectBase<UFldLmapManager>
{
    public FldLmapManager(IntPtr pointer) : base(pointer) {}}

public unsafe class FldMailOrderScript : ObjectBase<AFldMailOrderScript>
{
    public FldMailOrderScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FldManagerSubsystem : ObjectBase<UFldManagerSubsystem>
{
    public FldManagerSubsystem(IntPtr pointer) : base(pointer) {}
    public void SetPlayerKeyEnable(bool KeyEnable)
    {
        Span<(string name, object value)> @params = [
            ("KeyEnable", KeyEnable)
        ];
        ProcessEvent(GetFunction("SetPlayerKeyEnable"), @params);
    }
    public void SetPlayerEnable(bool Visible, bool KeyEnable)
    {
        Span<(string name, object value)> @params = [
            ("Visible", Visible), 
            ("KeyEnable", KeyEnable)
        ];
        ProcessEvent(GetFunction("SetPlayerEnable"), @params);
    }
    public void SetParamDebug(int FieldMajorID, int FieldMinorID)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID)
        ];
        ProcessEvent(GetFunction("SetParamDebug"), @params);
    }
    public void SetFieldCameraShakeActor(AFldMiscCameraShake* InActor)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor)
        ];
        ProcessEvent(GetFunction("SetFieldCameraShakeActor"), @params);
    }
    public void ProcLevelBluePrint(TSubclassOf<ACharacterBaseCore> DefaultPlayerClass, TSubclassOf<ACharacterBaseCore> DungeonPlayerClass, TSubclassOf<AFldCameraBase> DefaultCameraClass, TSubclassOf<AFldCameraBase> DungeonCameraClass, TSubclassOf<AFldCamera> TransCameraClass, TSubclassOf<ACharacterBaseCore> FollowerClass, TSubclassOf<ACharacterBaseCore> FollowerKoromaruClass, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("DefaultPlayerClass", DefaultPlayerClass), 
            ("DungeonPlayerClass", DungeonPlayerClass), 
            ("DefaultCameraClass", DefaultCameraClass), 
            ("DungeonCameraClass", DungeonCameraClass), 
            ("TransCameraClass", TransCameraClass), 
            ("FollowerClass", FollowerClass), 
            ("FollowerKoromaruClass", FollowerKoromaruClass), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("ProcLevelBluePrint"), @params);
    }
    public void LoadFieldSubLevelDebug(int FieldMajorID, int FieldMinorID, int TotalDay, ECldTimeZone TimeZone, EFldLoadPattern Pattern, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID), 
            ("TotalDay", TotalDay), 
            ("TimeZone", TimeZone), 
            ("Pattern", Pattern), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("LoadFieldSubLevelDebug"), @params);
    }
    public bool IsProcFldEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsProcFldEvent"), @params);
    }
    public bool IsProcField()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsProcField"), @params);
    }
    public bool IsLoadingField()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLoadingField"), @params);
    }
    public bool IsKeyFreeEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsKeyFreeEvent"), @params);
    }
    public bool IsEnablePartyChange()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEnablePartyChange"), @params);
    }
    public AFldMiscCameraShake* GetFieldCameraShakeActor()
    {
        Span<(string name, object value)> @params = [
        ];
        return (AFldMiscCameraShake*)ProcessEvent<IntPtr>(GetFunction("GetFieldCameraShakeActor"), @params);
    }
    public bool CheckKeyFree()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("CheckKeyFree"), @params);
    }
    public void ChangeFieldSubLevelDebug(int FieldMajorID, int FieldMinorID, int TotalDay, ECldTimeZone TimeZone, EFldLoadPattern Pattern, UObject* WorldContextObject, FLatentActionInfo LatentInfo)
    {
        Span<(string name, object value)> @params = [
            ("FieldMajorID", FieldMajorID), 
            ("FieldMinorID", FieldMinorID), 
            ("TotalDay", TotalDay), 
            ("TimeZone", TimeZone), 
            ("Pattern", Pattern), 
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("LatentInfo", LatentInfo)
        ];
        ProcessEvent(GetFunction("ChangeFieldSubLevelDebug"), @params);
    }
}

public unsafe class FldMiniMapManager : ObjectBase<UFldMiniMapManager>
{
    public FldMiniMapManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldMiscCameraMove : ObjectBase<AFldMiscCameraMove>
{
    public FldMiscCameraMove(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldMiscCameraShake : ObjectBase<AFldMiscCameraShake>
{
    public FldMiscCameraShake(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldMiscCharaBaseMove : ObjectBase<AFldMiscCharaBaseMove>
{
    public FldMiscCharaBaseMove(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldMiscCharBaseReload : ObjectBase<AFldMiscCharBaseReload>
{
    public FldMiscCharBaseReload(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldNpcActor : ObjectBase<AFldNpcActor>
{
    public FldNpcActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldNpcComp : ObjectBase<UFldNpcComp>
{
    public FldNpcComp(IntPtr pointer) : base(pointer) {}
    public void RequestRestartAnimProcByMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRestartAnimProcByMotion"), @params);
    }
    public void RequestPauseAnimProcByMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestPauseAnimProcByMotion"), @params);
    }
    public void RequestLookAtPlayerByMotion()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestLookAtPlayerByMotion"), @params);
    }
    public UAppCharBaseComp* GetCharBaseComp()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UAppCharBaseComp*)ProcessEvent<IntPtr>(GetFunction("GetCharBaseComp"), @params);
    }
}

public unsafe class FldOperationBase : ObjectBase<UFldOperationBase>
{
    public FldOperationBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldOperationPrePhysics : ObjectBase<UFldOperationPrePhysics>
{
    public FldOperationPrePhysics(IntPtr pointer) : base(pointer) {}}

public unsafe class FldOperationCamera : ObjectBase<UFldOperationCamera>
{
    public FldOperationCamera(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldOperationPlayer : ObjectBase<UFldOperationPlayer>
{
    public FldOperationPlayer(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldOperator : ObjectBase<AFldOperator>
{
    public FldOperator(IntPtr pointer) : base(pointer) {}
    public void Setup(AKernelInput* KernelInput, APawn* Player, AFldCameraFree* FreeCamera, AFldCamera* Camera)
    {
        Span<(string name, object value)> @params = [
            ("KernelInput", (IntPtr)KernelInput), 
            ("Player", (IntPtr)Player), 
            ("FreeCamera", (IntPtr)FreeCamera), 
            ("Camera", (IntPtr)Camera)
        ];
        ProcessEvent(GetFunction("Setup"), @params);
    }
    public void SetFreeCameraYaw(float Angle)
    {
        Span<(string name, object value)> @params = [
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("SetFreeCameraYaw"), @params);
    }
    public void SetFreeCameraPitch(float Angle)
    {
        Span<(string name, object value)> @params = [
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("SetFreeCameraPitch"), @params);
    }
    public void KeyEnable(bool Enable)
    {
        Span<(string name, object value)> @params = [
            ("Enable", Enable)
        ];
        ProcessEvent(GetFunction("KeyEnable"), @params);
    }
    public void FreeCameraReset()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FreeCameraReset"), @params);
    }
    public void EndEvent(bool bNotCameraReset)
    {
        Span<(string name, object value)> @params = [
            ("bNotCameraReset", bNotCameraReset)
        ];
        ProcessEvent(GetFunction("EndEvent"), @params);
    }
    public void Cleanup()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Cleanup"), @params);
    }
    public void BeginFadeOut()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginFadeOut"), @params);
    }
    public void BeginFadeIn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginFadeIn"), @params);
    }
    public void BeginEvent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginEvent"), @params);
    }
}

public unsafe class FldPartnerPointComp : ObjectBase<UFldPartnerPointComp>
{
    public FldPartnerPointComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPartnerStartPointComp : ObjectBase<UFldPartnerStartPointComp>
{
    public FldPartnerStartPointComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPartnerComp : ObjectBase<UFldPartnerComp>
{
    public FldPartnerComp(IntPtr pointer) : base(pointer) {}
    public float GetWalkThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetWalkThreshold"), @params);
    }
    public float GetRunThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRunThreshold"), @params);
    }
    public float GetDashThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDashThreshold"), @params);
    }
}

public unsafe class FldPartnerController : ObjectBase<AFldPartnerController>
{
    public FldPartnerController(IntPtr pointer) : base(pointer) {}}

public unsafe class FldPartnerManager : ObjectBase<AFldPartnerManager>
{
    public FldPartnerManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPlayerComp : ObjectBase<UFldPlayerComp>
{
    public FldPlayerComp(IntPtr pointer) : base(pointer) {}
    public void OnMontageEnded(UAnimMontage* Montage, bool bInterrupted)
    {
        Span<(string name, object value)> @params = [
            ("Montage", (IntPtr)Montage), 
            ("bInterrupted", bInterrupted)
        ];
        ProcessEvent(GetFunction("OnMontageEnded"), @params);
    }
    public float GetWalkThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetWalkThreshold"), @params);
    }
    public float GetRunThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRunThreshold"), @params);
    }
    public float GetDashThreshold()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDashThreshold"), @params);
    }
}

public unsafe class FldPlayerAbsComp : ObjectBase<UFldPlayerAbsComp>
{
    public FldPlayerAbsComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPlayerDailyComp : ObjectBase<UFldPlayerDailyComp>
{
    public FldPlayerDailyComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPlayerDungeonComp : ObjectBase<UFldPlayerDungeonComp>
{
    public FldPlayerDungeonComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPlayerEncountComp : ObjectBase<UFldPlayerEncountComp>
{
    public FldPlayerEncountComp(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPlayerStart : ObjectBase<AFldPlayerStart>
{
    public FldPlayerStart(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldPostValumeSound : ObjectBase<AFldPostValumeSound>
{
    public FldPostValumeSound(IntPtr pointer) : base(pointer) {}
    public void OnActorOverlapEnd(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex)
        ];
        ProcessEvent(GetFunction("OnActorOverlapEnd"), @params);
    }
    public void OnActorOverlapBegin(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult SweepResult)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComponent", (IntPtr)OverlappedComponent), 
            ("OtherActor", (IntPtr)OtherActor), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("SweepResult", SweepResult)
        ];
        ProcessEvent(GetFunction("OnActorOverlapBegin"), @params);
    }
}

public unsafe class FldScriptActor : ObjectBase<AFldScriptActor>
{
    public FldScriptActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldShortcutMove : ObjectBase<AFldShortcutMove>
{
    public FldShortcutMove(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldShortcutManager : ObjectBase<UFldShortcutManager>
{
    public FldShortcutManager(IntPtr pointer) : base(pointer) {}}

public unsafe class FldSoundMngChangeTownmapActor : ObjectBase<AFldSoundMngChangeTownmapActor>
{
    public FldSoundMngChangeTownmapActor(IntPtr pointer) : base(pointer) {}}

public unsafe class FldSoundMngChangeAISAC : ObjectBase<AFldSoundMngChangeAISAC>
{
    public FldSoundMngChangeAISAC(IntPtr pointer) : base(pointer) {}}

public unsafe class FldSoundManager : ObjectBase<UFldSoundManager>
{
    public FldSoundManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldTargetIcon : ObjectBase<AFldTargetIcon>
{
    public FldTargetIcon(IntPtr pointer) : base(pointer) {}
}

public unsafe class FldTvProgramScript : ObjectBase<AFldTvProgramScript>
{
    public FldTvProgramScript(IntPtr pointer) : base(pointer) {}}

public unsafe class FrameBufferCapture : ObjectBase<UFrameBufferCapture>
{
    public FrameBufferCapture(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenericSelectSystemBase : ObjectBase<UGenericSelectSystemBase>
{
    public GenericSelectSystemBase(IntPtr pointer) : base(pointer) {}}

public unsafe class GenericSelectItem : ObjectBase<UGenericSelectItem>
{
    public GenericSelectItem(IntPtr pointer) : base(pointer) {}}

public unsafe class GenericSelectMsg : ObjectBase<UGenericSelectMsg>
{
    public GenericSelectMsg(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenericSelectShop : ObjectBase<UGenericSelectShop>
{
    public GenericSelectShop(IntPtr pointer) : base(pointer) {}}

public unsafe class GlobalGameData : ObjectBase<UGlobalGameData>
{
    public GlobalGameData(IntPtr pointer) : base(pointer) {}
    public void StartDataInitialize()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartDataInitialize"), @params);
    }
    public void SetDataInheritance_ALWAYS()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetDataInheritance_ALWAYS"), @params);
    }
    public void SetDataInheritance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetDataInheritance"), @params);
    }
    public void ClearDataInheritance()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearDataInheritance"), @params);
    }
}

public unsafe class GlobalWork : ObjectBase<UGlobalWork>
{
    public GlobalWork(IntPtr pointer) : base(pointer) {}
    public AActor* SpawnActorFromClassSubLevelIndex(TSubclassOf<AActor> ActorClass, ESubLevelIndex SubLevelIndex, FTransform Transform)
    {
        Span<(string name, object value)> @params = [
            ("ActorClass", ActorClass), 
            ("SubLevelIndex", SubLevelIndex), 
            ("Transform", Transform)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("SpawnActorFromClassSubLevelIndex"), @params);
    }
    public void SetSubLevelActor(ESubLevelIndex SubLevelNum, AActor* Actor)
    {
        Span<(string name, object value)> @params = [
            ("SubLevelNum", SubLevelNum), 
            ("Actor", (IntPtr)Actor)
        ];
        ProcessEvent(GetFunction("SetSubLevelActor"), @params);
    }
    public void SetSequenceParam_KEY_FREE_EVENT(EGWorkSeqType Type, int major, int Minor, int mKfEvent)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("major", major), 
            ("Minor", Minor), 
            ("mKfEvent", mKfEvent)
        ];
        ProcessEvent(GetFunction("SetSequenceParam_KEY_FREE_EVENT"), @params);
    }
    public void SetSequenceParam_DEBUG(EGWorkSeqType Type, int major, int Minor, int mKfEvent, FString Tag)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("major", major), 
            ("Minor", Minor), 
            ("mKfEvent", mKfEvent), 
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("SetSequenceParam_DEBUG"), @params);
    }
    public void SetSequenceParam(EGWorkSeqType Type, int major, int Minor)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("major", major), 
            ("Minor", Minor)
        ];
        ProcessEvent(GetFunction("SetSequenceParam"), @params);
    }
    public AActor* GetSubLevelActor(ESubLevelIndex SubLevelNum)
    {
        Span<(string name, object value)> @params = [
            ("SubLevelNum", SubLevelNum)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetSubLevelActor"), @params);
    }
    public void GetSequenceParam_DEBUG(ref EGWorkSeqType Type, ref int major, ref int Minor, ref int mKfEvent, ref FString Tag)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("major", major), 
            ("Minor", Minor), 
            ("mKfEvent", mKfEvent), 
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("GetSequenceParam_DEBUG"), @params);
    }
    public void GetSequenceParam(ref EGWorkSeqType Type, ref int major, ref int Minor, ref int mKfEvent)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("major", major), 
            ("Minor", Minor), 
            ("mKfEvent", mKfEvent)
        ];
        ProcessEvent(GetFunction("GetSequenceParam"), @params);
    }
    public void ClearSubLevelActor(ESubLevelIndex SubLevelNum)
    {
        Span<(string name, object value)> @params = [
            ("SubLevelNum", SubLevelNum)
        ];
        ProcessEvent(GetFunction("ClearSubLevelActor"), @params);
    }
}

public unsafe class GWSettings : ObjectBase<UGWSettings>
{
    public GWSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class GlobalWorkBpLib : ObjectBase<UGlobalWorkBpLib>
{
    public GlobalWorkBpLib(IntPtr pointer) : base(pointer) {}
    public void GWorkSetPartyOUT(int PCID)
    {
        Span<(string name, object value)> @params = [
            ("PCID", PCID)
        ];
        ProcessEvent(GetFunction("GWorkSetPartyOUT"), @params);
    }
    public void GWorkSetPartyIN(int PCID)
    {
        Span<(string name, object value)> @params = [
            ("PCID", PCID)
        ];
        ProcessEvent(GetFunction("GWorkSetPartyIN"), @params);
    }
    public void GWorkSetMoney(int SetMoeny)
    {
        Span<(string name, object value)> @params = [
            ("SetMoeny", SetMoeny)
        ];
        ProcessEvent(GetFunction("GWorkSetMoney"), @params);
    }
    public void GWorkSetCounterValue(int CntNo, int Value)
    {
        Span<(string name, object value)> @params = [
            ("CntNo", CntNo), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("GWorkSetCounterValue"), @params);
    }
    public void GWorkSetCounter(FName CntName, int Value)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("GWorkSetCounter"), @params);
    }
    public bool GWorkIsPartyExists(int PCID)
    {
        Span<(string name, object value)> @params = [
            ("PCID", PCID)
        ];
        return ProcessEvent<bool>(GetFunction("GWorkIsPartyExists"), @params);
    }
    public bool GWorkIsJapaneseLanguage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GWorkIsJapaneseLanguage"), @params);
    }
    public bool GWorkIsFullHpSpAllPartyMember()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GWorkIsFullHpSpAllPartyMember"), @params);
    }
    public bool GWorkIsEFIGSLanguages()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GWorkIsEFIGSLanguages"), @params);
    }
    public bool GWorkIsAsiaLanguages()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GWorkIsAsiaLanguages"), @params);
    }
    public void GWorkIncCounterValue(int CntNo)
    {
        Span<(string name, object value)> @params = [
            ("CntNo", CntNo)
        ];
        ProcessEvent(GetFunction("GWorkIncCounterValue"), @params);
    }
    public void GWorkIncCounter(FName CntName)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName)
        ];
        ProcessEvent(GetFunction("GWorkIncCounter"), @params);
    }
    public float GWorkGetRealTimeDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GWorkGetRealTimeDelta"), @params);
    }
    public int GWorkGetPartyID(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<int>(GetFunction("GWorkGetPartyID"), @params);
    }
    public int GWorkGetMoney()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GWorkGetMoney"), @params);
    }
    public float GWorkGetMaxFPS()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GWorkGetMaxFPS"), @params);
    }
    public int GWorkGetCounterValue(int CntNo)
    {
        Span<(string name, object value)> @params = [
            ("CntNo", CntNo)
        ];
        return ProcessEvent<int>(GetFunction("GWorkGetCounterValue"), @params);
    }
    public int GWorkGetCounter(FName CntName)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName)
        ];
        return ProcessEvent<int>(GetFunction("GWorkGetCounter"), @params);
    }
    public void GWorkFullRecoveryAllPartyMember()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkFullRecoveryAllPartyMember"), @params);
    }
    public void GWorkFlagSetValue(int Index, ref EGWorkOnOffEnum OnOff)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("OnOff", OnOff)
        ];
        ProcessEvent(GetFunction("GWorkFlagSetValue"), @params);
    }
    public void GWorkFlagSet(FName FlagName, ref EGWorkOnOffEnum OnOff)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName), 
            ("OnOff", OnOff)
        ];
        ProcessEvent(GetFunction("GWorkFlagSet"), @params);
    }
    public void GWorkFlagOnValue(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("GWorkFlagOnValue"), @params);
    }
    public void GWorkFlagOn(FName FlagName)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName)
        ];
        ProcessEvent(GetFunction("GWorkFlagOn"), @params);
    }
    public void GWorkFlagOffValue(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("GWorkFlagOffValue"), @params);
    }
    public void GWorkFlagOff(FName FlagName)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName)
        ];
        ProcessEvent(GetFunction("GWorkFlagOff"), @params);
    }
    public void GWorkFlagChkValue(int Index, ref EGWorkOnOffEnum OnOff)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("OnOff", OnOff)
        ];
        ProcessEvent(GetFunction("GWorkFlagChkValue"), @params);
    }
    public void GWorkFlagChk(FName FlagName, ref EGWorkOnOffEnum OnOff)
    {
        Span<(string name, object value)> @params = [
            ("FlagName", FlagName), 
            ("OnOff", OnOff)
        ];
        ProcessEvent(GetFunction("GWorkFlagChk"), @params);
    }
    public void GWorkDecCounterValue(int CntNo)
    {
        Span<(string name, object value)> @params = [
            ("CntNo", CntNo)
        ];
        ProcessEvent(GetFunction("GWorkDecCounterValue"), @params);
    }
    public void GWorkDecCounter(FName CntName)
    {
        Span<(string name, object value)> @params = [
            ("CntName", CntName)
        ];
        ProcessEvent(GetFunction("GWorkDecCounter"), @params);
    }
    public void GWorkCreateTrophyManagere()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkCreateTrophyManagere"), @params);
    }
    public void GWorkCreateSignedInDialog()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkCreateSignedInDialog"), @params);
    }
    public void GWorkCreateMessageDialog()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkCreateMessageDialog"), @params);
    }
    public void GWorkCreateLeaderBoardManagere()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkCreateLeaderBoardManagere"), @params);
    }
    public void GWorkCreateErrorDialog()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("GWorkCreateErrorDialog"), @params);
    }
    public bool GWorkCheckPartyFull()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GWorkCheckPartyFull"), @params);
    }
    public int GWorkAddMoney(int SetMoeny)
    {
        Span<(string name, object value)> @params = [
            ("SetMoeny", SetMoeny)
        ];
        return ProcessEvent<int>(GetFunction("GWorkAddMoney"), @params);
    }
}

public unsafe class GWFlagWork : ObjectBase<UGWFlagWork>
{
    public GWFlagWork(IntPtr pointer) : base(pointer) {}
}

public unsafe class HandwritingEffectBase : ObjectBase<AHandwritingEffectBase>
{
    public HandwritingEffectBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class HandwritingSpawner : ObjectBase<AHandwritingSpawner>
{
    public HandwritingSpawner(IntPtr pointer) : base(pointer) {}
    public void RequestPlayEffectFromParam(EAtlEvtHandwritingType InType, ref FAtlHandwritingNiagaraRequestParam InParam, EHandwritingSpawnRules InSpawnRule, bool bInLoop)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("InParam", InParam), 
            ("InSpawnRule", InSpawnRule), 
            ("bInLoop", bInLoop)
        ];
        ProcessEvent(GetFunction("RequestPlayEffectFromParam"), @params);
    }
    public void RequestPlayEffectAtSpawnerLocation(EAtlEvtHandwritingType InType, bool bInLoop, ref FVector InLocation, ref FRotator InRotator, int InLoopCount, int InCameraOffset, ref FVector InScale)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("bInLoop", bInLoop), 
            ("InLocation", InLocation), 
            ("InRotator", InRotator), 
            ("InLoopCount", InLoopCount), 
            ("InCameraOffset", InCameraOffset), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("RequestPlayEffectAtSpawnerLocation"), @params);
    }
    public void RequestPlayEffectAtSpawnerAttachedToNpc(EAtlEvtHandwritingType InType, ANpcBaseCore* NpcBase, FName AttachSocketName, EHandwritingSpawnRules InSpawnRule, bool bInLoop, ref FVector InLocation, ref FRotator InRotator, int InLoopCount, int InCameraOffset, ref FVector InScale)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("NpcBase", (IntPtr)NpcBase), 
            ("AttachSocketName", AttachSocketName), 
            ("InSpawnRule", InSpawnRule), 
            ("bInLoop", bInLoop), 
            ("InLocation", InLocation), 
            ("InRotator", InRotator), 
            ("InLoopCount", InLoopCount), 
            ("InCameraOffset", InCameraOffset), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("RequestPlayEffectAtSpawnerAttachedToNpc"), @params);
    }
    public void RequestPlayEffectAtSpawnerAttachedTo(EAtlEvtHandwritingType InType, ACharacter* Character, FName AttachSocketName, EHandwritingSpawnRules InSpawnRule, bool bInLoop, ref FVector InLocation, ref FRotator InRotator, int InLoopCount, int InCameraOffset, ref FVector InScale)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("Character", (IntPtr)Character), 
            ("AttachSocketName", AttachSocketName), 
            ("InSpawnRule", InSpawnRule), 
            ("bInLoop", bInLoop), 
            ("InLocation", InLocation), 
            ("InRotator", InRotator), 
            ("InLoopCount", InLoopCount), 
            ("InCameraOffset", InCameraOffset), 
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("RequestPlayEffectAtSpawnerAttachedTo"), @params);
    }
    public void RequestPlayEffect(EAtlEvtHandwritingType InType, EHandwritingSpawnRules InSpawnRule, bool bInLoop)
    {
        Span<(string name, object value)> @params = [
            ("InType", InType), 
            ("InSpawnRule", InSpawnRule), 
            ("bInLoop", bInLoop)
        ];
        ProcessEvent(GetFunction("RequestPlayEffect"), @params);
    }
    public void OnCompleteNiagara(UNiagaraComponent* PSystem)
    {
        Span<(string name, object value)> @params = [
            ("PSystem", (IntPtr)PSystem)
        ];
        ProcessEvent(GetFunction("OnCompleteNiagara"), @params);
    }
    public void LoadEffectEnded()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("LoadEffectEnded"), @params);
    }
}

public unsafe class HandwritingSubsystem : ObjectBase<UHandwritingSubsystem>
{
    public HandwritingSubsystem(IntPtr pointer) : base(pointer) {}
    public AHandwritingSpawner* SpawnHandwritingAttachedNpc(EAtlHandwritingGroupType GroupType, EAtlEvtHandwritingType Type, ANpcBaseCore* NpcBase, FName AttachSocketName, EHandwritingSpawnRules InSpawnRule, ref FAtlHandwritingNiagaraRequestParam InParam, bool bAutoDestroySpawner, bool InbLoop)
    {
        Span<(string name, object value)> @params = [
            ("GroupType", GroupType), 
            ("Type", Type), 
            ("NpcBase", (IntPtr)NpcBase), 
            ("AttachSocketName", AttachSocketName), 
            ("InSpawnRule", InSpawnRule), 
            ("InParam", InParam), 
            ("bAutoDestroySpawner", bAutoDestroySpawner), 
            ("InbLoop", InbLoop)
        ];
        return (AHandwritingSpawner*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAttachedNpc"), @params);
    }
    public AHandwritingSpawner* SpawnHandwritingAttached(EAtlHandwritingGroupType GroupType, EAtlEvtHandwritingType Type, ACharacter* Character, FName AttachSocketName, EHandwritingSpawnRules InSpawnRule, ref FAtlHandwritingNiagaraRequestParam InParam, bool bAutoDestroySpawner, bool InbLoop)
    {
        Span<(string name, object value)> @params = [
            ("GroupType", GroupType), 
            ("Type", Type), 
            ("Character", (IntPtr)Character), 
            ("AttachSocketName", AttachSocketName), 
            ("InSpawnRule", InSpawnRule), 
            ("InParam", InParam), 
            ("bAutoDestroySpawner", bAutoDestroySpawner), 
            ("InbLoop", InbLoop)
        ];
        return (AHandwritingSpawner*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAttached"), @params);
    }
    public AHandwritingSpawner* SpawnHandwritingAtLocation(UObject* WorldContextObject, EAtlHandwritingGroupType GroupType, EAtlEvtHandwritingType Type, ref FAtlHandwritingNiagaraRequestParam InParam, bool bAutoDestroySpawner, bool InbLoop)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("GroupType", GroupType), 
            ("Type", Type), 
            ("InParam", InParam), 
            ("bAutoDestroySpawner", bAutoDestroySpawner), 
            ("InbLoop", InbLoop)
        ];
        return (AHandwritingSpawner*)ProcessEvent<IntPtr>(GetFunction("SpawnHandwritingAtLocation"), @params);
    }
    public bool IsPolandLanguage()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPolandLanguage"), @params);
    }
    public bool GetAdjustedWoofLayoutData(ref FVector OutPosition1, ref FVector OutPosition2, ref FVector OutPosition3, ref FVector OutPosition4)
    {
        Span<(string name, object value)> @params = [
            ("OutPosition1", OutPosition1), 
            ("OutPosition2", OutPosition2), 
            ("OutPosition3", OutPosition3), 
            ("OutPosition4", OutPosition4)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedWoofLayoutData"), @params);
    }
    public bool GetAdjustedWhineLayoutData(ref FVector OutPosition, ref FVector OutScale, ref float OutSize)
    {
        Span<(string name, object value)> @params = [
            ("OutPosition", OutPosition), 
            ("OutScale", OutScale), 
            ("OutSize", OutSize)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedWhineLayoutData"), @params);
    }
    public bool GetAdjustedQuestionLayoutData(ref FVector OutPosition1, ref FVector OutPosition2, ref FVector OutPosition3)
    {
        Span<(string name, object value)> @params = [
            ("OutPosition1", OutPosition1), 
            ("OutPosition2", OutPosition2), 
            ("OutPosition3", OutPosition3)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedQuestionLayoutData"), @params);
    }
    public bool GetAdjustedLayoutScale(EHandwritingLayout InIndex, ref float OutScale)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("OutScale", OutScale)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedLayoutScale"), @params);
    }
    public bool GetAdjustedLayoutRotation(EHandwritingLayout InIndex, ref float OutAngle)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("OutAngle", OutAngle)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedLayoutRotation"), @params);
    }
    public bool GetAdjustedLayoutPosition(EHandwritingLayout InIndex, ref FVector OutPosition)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("OutPosition", OutPosition)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedLayoutPosition"), @params);
    }
    public bool GetAdjustedLayoutData(EHandwritingLayout InIndex, ref FVector OutPosition, ref float OutAngle, ref float OutScale)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex), 
            ("OutPosition", OutPosition), 
            ("OutAngle", OutAngle), 
            ("OutScale", OutScale)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedLayoutData"), @params);
    }
    public bool GetAdjustedExclamationQuestionLayoutData(ref FVector OutPosition1, ref FVector OutPosition2, ref FVector OutScale, ref float OutScaleFloat)
    {
        Span<(string name, object value)> @params = [
            ("OutPosition1", OutPosition1), 
            ("OutPosition2", OutPosition2), 
            ("OutScale", OutScale), 
            ("OutScaleFloat", OutScaleFloat)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedExclamationQuestionLayoutData"), @params);
    }
    public bool GetAdjustedDoubleExclamationLayoutData(ref FVector OutPosition1, ref FVector OutPosition2)
    {
        Span<(string name, object value)> @params = [
            ("OutPosition1", OutPosition1), 
            ("OutPosition2", OutPosition2)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedDoubleExclamationLayoutData"), @params);
    }
    public bool GetAdjustedCallingLayoutData(ref float OutScale1, ref float OutScale2, ref float OutScale3)
    {
        Span<(string name, object value)> @params = [
            ("OutScale1", OutScale1), 
            ("OutScale2", OutScale2), 
            ("OutScale3", OutScale3)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedCallingLayoutData"), @params);
    }
    public bool GetAdjustedAllLayoutData(EHandwritingLayout InIndexPosRot, ref FVector OutPosition, ref float OutAngle, EHandwritingLayout InIndexScale, ref FVector OutScale, ref float OutSize)
    {
        Span<(string name, object value)> @params = [
            ("InIndexPosRot", InIndexPosRot), 
            ("OutPosition", OutPosition), 
            ("OutAngle", OutAngle), 
            ("InIndexScale", InIndexScale), 
            ("OutScale", OutScale), 
            ("OutSize", OutSize)
        ];
        return ProcessEvent<bool>(GetFunction("GetAdjustedAllLayoutData"), @params);
    }
}

public unsafe class HeroParameterHandle : ObjectBase<UHeroParameterHandle>
{
    public HeroParameterHandle(IntPtr pointer) : base(pointer) {}
}

public unsafe class HmModelTestActor : ObjectBase<AHmModelTestActor>
{
    public HmModelTestActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class HT_UMGTestGameModeBase : ObjectBase<AHT_UMGTestGameModeBase>
{
    public HT_UMGTestGameModeBase(IntPtr pointer) : base(pointer) {}
    public void ChangeMenuWidget(TSubclassOf<UUserWidget> NewWidgetClass)
    {
        Span<(string name, object value)> @params = [
            ("NewWidgetClass", NewWidgetClass)
        ];
        ProcessEvent(GetFunction("ChangeMenuWidget"), @params);
    }
}

public unsafe class HT_UMGTestPlayerController : ObjectBase<AHT_UMGTestPlayerController>
{
    public HT_UMGTestPlayerController(IntPtr pointer) : base(pointer) {}}

public unsafe class HttpBpLib : ObjectBase<UHttpBpLib>
{
    public HttpBpLib(IntPtr pointer) : base(pointer) {}
    public void SpawnHttpActor(FString BPActorReferencePath, FString Arg)
    {
        Span<(string name, object value)> @params = [
            ("BPActorReferencePath", BPActorReferencePath), 
            ("Arg", Arg)
        ];
        ProcessEvent(GetFunction("SpawnHttpActor"), @params);
    }
    public void PostTeamsMessage(FString URL, FString Title, FString Text)
    {
        Span<(string name, object value)> @params = [
            ("URL", URL), 
            ("Title", Title), 
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("PostTeamsMessage"), @params);
    }
}

public unsafe class HumanParameterUpViewer : ObjectBase<AHumanParameterUpViewer>
{
    public HumanParameterUpViewer(IntPtr pointer) : base(pointer) {}
}

public unsafe class IKAnimInstanceBase : ObjectBase<UIKAnimInstanceBase>
{
    public IKAnimInstanceBase(IntPtr pointer) : base(pointer) {}
    public void UpdateLocomotionTick(float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("UpdateLocomotionTick"), @params);
    }
}

public unsafe class IKCharacterBase : ObjectBase<AIKCharacterBase>
{
    public IKCharacterBase(IntPtr pointer) : base(pointer) {}
    public void UpdateInterpRotator(ref FRotator Value, FRotator Target, float InterpSpeed, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value), 
            ("Target", Target), 
            ("InterpSpeed", InterpSpeed), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("UpdateInterpRotator"), @params);
    }
    public void UpdateInterpFloat(ref float Value, float Target, float InterpSpeed, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value), 
            ("Target", Target), 
            ("InterpSpeed", InterpSpeed), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("UpdateInterpFloat"), @params);
    }
    public void UpdateCapsuleHalfHeight(float HipOffset, bool bResetCapsule, float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("HipOffset", HipOffset), 
            ("bResetCapsule", bResetCapsule), 
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("UpdateCapsuleHalfHeight"), @params);
    }
    public void UpdateAnimInstanceParams()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UpdateAnimInstanceParams"), @params);
    }
    public void TickUpdateIK(float DeltaSeconds)
    {
        Span<(string name, object value)> @params = [
            ("DeltaSeconds", DeltaSeconds)
        ];
        ProcessEvent(GetFunction("TickUpdateIK"), @params);
    }
    public void InitializeIKSetup(bool bEnable, USkeletalMeshComponent* InTargetMesh, UIKAnimInstanceBase* InIKAnimInstance)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable), 
            ("InTargetMesh", (IntPtr)InTargetMesh), 
            ("InIKAnimInstance", (IntPtr)InIKAnimInstance)
        ];
        ProcessEvent(GetFunction("InitializeIKSetup"), @params);
    }
    public void EnableIK()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EnableIK"), @params);
    }
    public void DisableIK()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisableIK"), @params);
    }
}

public unsafe class IkedaTestMenu : ObjectBase<AIkedaTestMenu>
{
    public IkedaTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class ImanishiTestMenu : ObjectBase<AImanishiTestMenu>
{
    public ImanishiTestMenu(IntPtr pointer) : base(pointer) {}
}

public unsafe class InitReadActor : ObjectBase<AInitReadActor>
{
    public InitReadActor(IntPtr pointer) : base(pointer) {}}

public unsafe class MsgItem : ObjectBase<UMsgItem>
{
    public MsgItem(IntPtr pointer) : base(pointer) {}
}

public unsafe class MsgAssist : ObjectBase<UMsgAssist>
{
    public MsgAssist(IntPtr pointer) : base(pointer) {}}

public unsafe class KernelInput : ObjectBase<AKernelInput>
{
    public KernelInput(IntPtr pointer) : base(pointer) {}}

