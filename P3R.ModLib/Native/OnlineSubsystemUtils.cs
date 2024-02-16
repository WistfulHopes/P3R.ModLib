using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x1C48)] 
public unsafe struct UIpConnection
{
    [FieldOffset(0x0000)] public UNetConnection baseObj;
    [FieldOffset(0x1BF8)] public float SocketErrorDisconnectDelay;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7D0)] 
public unsafe struct UIpNetDriver
{
    [FieldOffset(0x0000)] public UNetDriver baseObj;
    [FieldOffset(0x0760)] public byte LogPortUnreach;
    [FieldOffset(0x0760)] public byte AllowPlayerPortUnreach;
    [FieldOffset(0x0764)] public uint MaxPortCountToTry;
    [FieldOffset(0x0774)] public uint ServerDesiredSocketReceiveBufferBytes;
    [FieldOffset(0x0778)] public uint ServerDesiredSocketSendBufferBytes;
    [FieldOffset(0x077C)] public uint ClientDesiredSocketReceiveBufferBytes;
    [FieldOffset(0x0780)] public uint ClientDesiredSocketSendBufferBytes;
    [FieldOffset(0x0788)] public double MaxSecondsInReceive;
    [FieldOffset(0x0790)] public int NbPacketsBetweenReceiveTimeTest;
    [FieldOffset(0x0794)] public float ResolutionConnectionTimeout;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAchievementBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAchievementQueryCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAchievementWriteCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UConnectionCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UCreateSessionCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UDestroySessionCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UEndMatchCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UEndTurnCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct FBlueprintSessionResult
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UFindSessionsCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UFindTurnBasedMatchCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UInAppPurchaseCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInAppPurchaseProductRequest2
{
    [FieldOffset(0x0000)] public FString ProductIdentifier;
    [FieldOffset(0x0010)] public bool bIsConsumable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInAppPurchaseCallbackProxy2
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInAppPurchaseQueryCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UInAppPurchaseQueryCallbackProxy2
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UInAppPurchaseRestoreCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UInAppPurchaseRestoreCallbackProxy2
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x180)] 
public unsafe struct UJoinSessionCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ULeaderboardBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct ULeaderboardFlushCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct ULeaderboardQueryCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct ULogoutCallbackProxy
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct AOnlineBeacon
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0228)] public float BeaconConnectionInitialTimeout;
    [FieldOffset(0x022C)] public float BeaconConnectionTimeout;
    [FieldOffset(0x0230)] public UNetDriver* NetDriver;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct AOnlineBeaconClient
{
    [FieldOffset(0x0000)] public AOnlineBeacon baseObj;
    [FieldOffset(0x0250)] public AOnlineBeaconHostObject* BeaconOwner;
    [FieldOffset(0x0258)] public UNetConnection* BeaconConnection;
    [FieldOffset(0x0260)] public EBeaconConnectionState ConnectionState;
}

[StructLayout(LayoutKind.Explicit, Size = 0x308)] 
public unsafe struct AOnlineBeaconHost
{
    [FieldOffset(0x0000)] public AOnlineBeacon baseObj;
    [FieldOffset(0x0250)] public int ListenPort;
    [FieldOffset(0x0258)] public TArray<IntPtr> ClientActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct AOnlineBeaconHostObject
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public FString BeaconTypeName;
    [FieldOffset(0x0230)] public TSubclassOf<AOnlineBeaconClient> ClientBeaconActorClass;
    [FieldOffset(0x0238)] public TArray<IntPtr> ClientActors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x188)] 
public unsafe struct UOnlineEngineInterfaceImpl
{
    [FieldOffset(0x0000)] public UOnlineEngineInterface baseObj;
    [FieldOffset(0x0028)] public TMap<FName, FName> MappedUniqueNetIdTypes;
    [FieldOffset(0x0078)] public TArray<FName> CompatibleUniqueNetIdTypes;
    [FieldOffset(0x0088)] public FName VoiceSubsystemNameOverride;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPIELoginSettingsInternal
{
    [FieldOffset(0x0000)] public FString ID;
    [FieldOffset(0x0010)] public FString Token;
    [FieldOffset(0x0020)] public FString Type;
    [FieldOffset(0x0030)] public TArray<byte> TokenBytes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UOnlinePIESettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public bool bOnlinePIEEnabled;
    [FieldOffset(0x0040)] public TArray<FPIELoginSettingsInternal> Logins;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C8)] 
public unsafe struct UOnlineSessionClient
{
    [FieldOffset(0x0000)] public UOnlineSession baseObj;
    [FieldOffset(0x01C0)] public bool bIsFromInvite;
    [FieldOffset(0x01C1)] public bool bHandlingDisconnect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FPlayerReservation
{
    [FieldOffset(0x0000)] public FUniqueNetIdRepl UniqueId;
    [FieldOffset(0x0028)] public FString ValidationStr;
    [FieldOffset(0x0038)] public FString Platform;
    [FieldOffset(0x0048)] public bool bAllowCrossplay;
    [FieldOffset(0x004C)] public float ElapsedTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FPartyReservation
{
    [FieldOffset(0x0000)] public int TeamNum;
    [FieldOffset(0x0008)] public FUniqueNetIdRepl PartyLeader;
    [FieldOffset(0x0030)] public TArray<FPlayerReservation> PartyMembers;
    [FieldOffset(0x0040)] public TArray<FPlayerReservation> RemovedPartyMembers;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct APartyBeaconClient
{
    [FieldOffset(0x0000)] public AOnlineBeaconClient baseObj;
    [FieldOffset(0x02E0)] public FString DestSessionId;
    [FieldOffset(0x02F0)] public FPartyReservation PendingReservation;
    [FieldOffset(0x0340)] public EClientRequestType RequestType;
    [FieldOffset(0x0341)] public bool bPendingReservationSent;
    [FieldOffset(0x0342)] public bool bCancelReservation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct APartyBeaconHost
{
    [FieldOffset(0x0000)] public AOnlineBeaconHostObject baseObj;
    [FieldOffset(0x0248)] public UPartyBeaconState* State;
    [FieldOffset(0x02B0)] public bool bLogoutOnSessionTimeout;
    [FieldOffset(0x02B4)] public float SessionTimeoutSecs;
    [FieldOffset(0x02B8)] public float TravelSessionTimeoutSecs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FPartyBeaconCrossplayPlatformMapping
{
    [FieldOffset(0x0000)] public FString PlatformName;
    [FieldOffset(0x0010)] public FString PlatformType;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UPartyBeaconState
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName SessionName;
    [FieldOffset(0x0030)] public int NumConsumedReservations;
    [FieldOffset(0x0034)] public int MaxReservations;
    [FieldOffset(0x0038)] public int NumTeams;
    [FieldOffset(0x003C)] public int NumPlayersPerTeam;
    [FieldOffset(0x0040)] public FName TeamAssignmentMethod;
    [FieldOffset(0x0048)] public int ReservedHostTeamNum;
    [FieldOffset(0x004C)] public int ForceTeamNum;
    [FieldOffset(0x0050)] public bool bRestrictCrossConsole;
    [FieldOffset(0x0058)] public TArray<FString> PlatformCrossplayRestrictions;
    [FieldOffset(0x0068)] public TArray<FPartyBeaconCrossplayPlatformMapping> PlatformTypeMapping;
    [FieldOffset(0x0078)] public bool bEnableRemovalRequests;
    [FieldOffset(0x0080)] public TArray<FPartyReservation> Reservations;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UQuitMatchCallbackProxy
{
    [FieldOffset(0x0000)] public UOnlineBlueprintCallProxyBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UShowLoginUICallbackProxy
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct FSpectatorReservation
{
    [FieldOffset(0x0000)] public FUniqueNetIdRepl SpectatorId;
    [FieldOffset(0x0028)] public FPlayerReservation Spectator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x398)] 
public unsafe struct ASpectatorBeaconClient
{
    [FieldOffset(0x0000)] public AOnlineBeaconClient baseObj;
    [FieldOffset(0x02E0)] public FString DestSessionId;
    [FieldOffset(0x02F0)] public FSpectatorReservation PendingReservation;
    [FieldOffset(0x0368)] public ESpectatorClientRequestType RequestType;
    [FieldOffset(0x0369)] public bool bPendingReservationSent;
    [FieldOffset(0x036A)] public bool bCancelReservation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2C0)] 
public unsafe struct ASpectatorBeaconHost
{
    [FieldOffset(0x0000)] public AOnlineBeaconHostObject baseObj;
    [FieldOffset(0x0248)] public USpectatorBeaconState* State;
    [FieldOffset(0x02B0)] public bool bLogoutOnSessionTimeout;
    [FieldOffset(0x02B4)] public float SessionTimeoutSecs;
    [FieldOffset(0x02B8)] public float TravelSessionTimeoutSecs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USpectatorBeaconState
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FName SessionName;
    [FieldOffset(0x0030)] public int NumConsumedReservations;
    [FieldOffset(0x0034)] public int MaxReservations;
    [FieldOffset(0x0038)] public bool bRestrictCrossConsole;
    [FieldOffset(0x0040)] public TArray<FSpectatorReservation> Reservations;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2B0)] 
public unsafe struct ATestBeaconClient
{
    [FieldOffset(0x0000)] public AOnlineBeaconClient baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x248)] 
public unsafe struct ATestBeaconHost
{
    [FieldOffset(0x0000)] public AOnlineBeaconHostObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTurnBasedBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x720)] 
public unsafe struct UVoipListenerSynthComponent
{
    [FieldOffset(0x0000)] public USynthComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FInAppPurchaseReceiptInfo2
{
    [FieldOffset(0x0000)] public FString ItemName;
    [FieldOffset(0x0010)] public FString ItemId;
    [FieldOffset(0x0020)] public FString ValidationInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct FOnlineProxyStoreOffer
{
    [FieldOffset(0x0000)] public FString OfferId;
    [FieldOffset(0x0010)] public FText Title;
    [FieldOffset(0x0028)] public FText Description;
    [FieldOffset(0x0040)] public FText LongDescription;
    [FieldOffset(0x0058)] public FText RegularPriceText;
    [FieldOffset(0x0070)] public int RegularPrice;
    [FieldOffset(0x0078)] public FText PriceText;
    [FieldOffset(0x0090)] public int NumericPrice;
    [FieldOffset(0x0098)] public FString CurrencyCode;
    [FieldOffset(0x00A8)] public FDateTime ReleaseDate;
    [FieldOffset(0x00B0)] public FDateTime ExpirationDate;
    [FieldOffset(0x00B8)] public EOnlineProxyStoreOfferDiscountType DiscountType;
    [FieldOffset(0x00C0)] public TMap<FString, FString> DynamicFields;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FInAppPurchaseRestoreInfo2
{
    [FieldOffset(0x0000)] public FString ItemName;
    [FieldOffset(0x0010)] public FString ItemId;
    [FieldOffset(0x0020)] public FString ValidationInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FInAppPurchaseReceiptInfo
{
    [FieldOffset(0x0000)] public FString ItemName;
    [FieldOffset(0x0010)] public FString ItemId;
    [FieldOffset(0x0020)] public FString ValidationInfo;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF8)] 
public unsafe struct FInAppPurchaseProductInfo2
{
    [FieldOffset(0x0000)] public FString Identifier;
    [FieldOffset(0x0010)] public FString TransactionIdentifier;
    [FieldOffset(0x0020)] public FString DisplayName;
    [FieldOffset(0x0030)] public FString DisplayDescription;
    [FieldOffset(0x0040)] public FString DisplayPrice;
    [FieldOffset(0x0050)] public float RawPrice;
    [FieldOffset(0x0058)] public FString CurrencyCode;
    [FieldOffset(0x0068)] public FString CurrencySymbol;
    [FieldOffset(0x0078)] public FString DecimalSeparator;
    [FieldOffset(0x0088)] public FString GroupingSeparator;
    [FieldOffset(0x0098)] public FString ReceiptData;
    [FieldOffset(0x00A8)] public TMap<FString, FString> DynamicFields;
}

