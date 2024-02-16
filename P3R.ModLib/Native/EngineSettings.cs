using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAutoCompleteCommand
{
    [FieldOffset(0x0000)] public FString Command;
    [FieldOffset(0x0010)] public FString Desc;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UConsoleSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int MaxScrollbackSize;
    [FieldOffset(0x0030)] public TArray<FAutoCompleteCommand> ManualAutoCompleteList;
    [FieldOffset(0x0040)] public TArray<FString> AutoCompleteMapPaths;
    [FieldOffset(0x0050)] public float BackgroundOpacityPercentage;
    [FieldOffset(0x0054)] public bool bOrderTopToBottom;
    [FieldOffset(0x0055)] public bool bDisplayHelpInAutoComplete;
    [FieldOffset(0x0058)] public FColor InputColor;
    [FieldOffset(0x005C)] public FColor HistoryColor;
    [FieldOffset(0x0060)] public FColor AutoCompleteCommandColor;
    [FieldOffset(0x0064)] public FColor AutoCompleteCVarColor;
    [FieldOffset(0x0068)] public FColor AutoCompleteFadedColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FGameModeName
{
    [FieldOffset(0x0000)] public FString Name;
    [FieldOffset(0x0010)] public FSoftClassPath GameMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UGameMapsSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString LocalMapOptions;
    [FieldOffset(0x0038)] public FSoftObjectPath TransitionMap;
    [FieldOffset(0x0050)] public bool bUseSplitscreen;
    [FieldOffset(0x0051)] public ETwoPlayerSplitScreenType TwoPlayerSplitscreenLayout;
    [FieldOffset(0x0052)] public EThreePlayerSplitScreenType ThreePlayerSplitscreenLayout;
    [FieldOffset(0x0053)] public EFourPlayerSplitScreenType FourPlayerSplitscreenLayout;
    [FieldOffset(0x0054)] public bool bOffsetPlayerGamepadIds;
    [FieldOffset(0x0058)] public FSoftClassPath GameInstanceClass;
    [FieldOffset(0x0070)] public FSoftObjectPath GameDefaultMap;
    [FieldOffset(0x0088)] public FSoftObjectPath ServerDefaultMap;
    [FieldOffset(0x00A0)] public FSoftClassPath GlobalDefaultGameMode;
    [FieldOffset(0x00B8)] public FSoftClassPath GlobalDefaultServerGameMode;
    [FieldOffset(0x00D0)] public TArray<FGameModeName> GameModeMapPrefixes;
    [FieldOffset(0x00E0)] public TArray<FGameModeName> GameModeClassAliases;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGameNetworkManagerSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int MinDynamicBandwidth;
    [FieldOffset(0x002C)] public int MaxDynamicBandwidth;
    [FieldOffset(0x0030)] public int TotalNetBandwidth;
    [FieldOffset(0x0034)] public int BadPingThreshold;
    [FieldOffset(0x0038)] public byte bIsStandbyCheckingEnabled;
    [FieldOffset(0x003C)] public float StandbyRxCheatTime;
    [FieldOffset(0x0040)] public float StandbyTxCheatTime;
    [FieldOffset(0x0044)] public float PercentMissingForRxStandby;
    [FieldOffset(0x0048)] public float PercentMissingForTxStandby;
    [FieldOffset(0x004C)] public float PercentForBadPing;
    [FieldOffset(0x0050)] public float JoinInProgressStandbyWaitTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UGameSessionSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int MaxSpectators;
    [FieldOffset(0x002C)] public int MaxPlayers;
    [FieldOffset(0x0030)] public byte bRequiresPushToTalk;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UGeneralEngineSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UGeneralProjectSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString CompanyName;
    [FieldOffset(0x0038)] public FString CompanyDistinguishedName;
    [FieldOffset(0x0048)] public FString CopyrightNotice;
    [FieldOffset(0x0058)] public FString Description;
    [FieldOffset(0x0068)] public FString Homepage;
    [FieldOffset(0x0078)] public FString LicensingTerms;
    [FieldOffset(0x0088)] public FString PrivacyPolicy;
    [FieldOffset(0x0098)] public FGuid ProjectID;
    [FieldOffset(0x00A8)] public FString ProjectName;
    [FieldOffset(0x00B8)] public FString ProjectVersion;
    [FieldOffset(0x00C8)] public FString SupportContact;
    [FieldOffset(0x00D8)] public FText ProjectDisplayedTitle;
    [FieldOffset(0x00F0)] public FText ProjectDebugTitleInfo;
    [FieldOffset(0x0108)] public bool bShouldWindowPreserveAspectRatio;
    [FieldOffset(0x0109)] public bool bUseBorderlessWindow;
    [FieldOffset(0x010A)] public bool bStartInVR;
    [FieldOffset(0x010B)] public bool bAllowWindowResize;
    [FieldOffset(0x010C)] public bool bAllowClose;
    [FieldOffset(0x010D)] public bool bAllowMaximize;
    [FieldOffset(0x010E)] public bool bAllowMinimize;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UHudSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte bShowHUD;
    [FieldOffset(0x0030)] public TArray<FName> DebugDisplay;
}

