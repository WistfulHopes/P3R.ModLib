using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class IpConnection : ObjectBase<UIpConnection>
{

}

public unsafe class IpNetDriver : ObjectBase<UIpNetDriver>
{

}

public unsafe class AchievementBlueprintLibrary : ObjectBase<UAchievementBlueprintLibrary>
{

    public void GetCachedAchievementProgress(UObject* WorldContextObject, APlayerController* PlayerController, FName AchievementID, ref bool bFoundID, ref float Progress)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("AchievementID", AchievementID), 
            ("bFoundID", bFoundID), 
            ("Progress", Progress)
        ];
        ProcessEvent(GetFunction("GetCachedAchievementProgress"),  @params);
    }
    public void GetCachedAchievementDescription(UObject* WorldContextObject, APlayerController* PlayerController, FName AchievementID, ref bool bFoundID, ref FText Title, ref FText LockedDescription, ref FText UnlockedDescription, ref bool bHidden)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("AchievementID", AchievementID), 
            ("bFoundID", bFoundID), 
            ("Title", Title), 
            ("LockedDescription", LockedDescription), 
            ("UnlockedDescription", UnlockedDescription), 
            ("bHidden", bHidden)
        ];
        ProcessEvent(GetFunction("GetCachedAchievementDescription"),  @params);
    }
}

public unsafe class AchievementQueryCallbackProxy : ObjectBase<UAchievementQueryCallbackProxy>
{

    public UAchievementQueryCallbackProxy* CacheAchievements(UObject* WorldContextObject, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UAchievementQueryCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CacheAchievements"),  @params);
    }
    public UAchievementQueryCallbackProxy* CacheAchievementDescriptions(UObject* WorldContextObject, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UAchievementQueryCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CacheAchievementDescriptions"),  @params);
    }
}

public unsafe class AchievementWriteCallbackProxy : ObjectBase<UAchievementWriteCallbackProxy>
{

    public UAchievementWriteCallbackProxy* WriteAchievementProgress(UObject* WorldContextObject, APlayerController* PlayerController, FName AchievementName, float Progress, int UserTag)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("AchievementName", AchievementName), 
            ("Progress", Progress), 
            ("UserTag", UserTag)
        ];
        return (UAchievementWriteCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("WriteAchievementProgress"),  @params);
    }
}

public unsafe class ConnectionCallbackProxy : ObjectBase<UConnectionCallbackProxy>
{

    public UConnectionCallbackProxy* ConnectToService(UObject* WorldContextObject, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UConnectionCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("ConnectToService"),  @params);
    }
}

public unsafe class CreateSessionCallbackProxy : ObjectBase<UCreateSessionCallbackProxy>
{

    public UCreateSessionCallbackProxy* CreateSession(UObject* WorldContextObject, APlayerController* PlayerController, int PublicConnections, bool bUseLAN)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("PublicConnections", PublicConnections), 
            ("bUseLAN", bUseLAN)
        ];
        return (UCreateSessionCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateSession"),  @params);
    }
}

public unsafe class DestroySessionCallbackProxy : ObjectBase<UDestroySessionCallbackProxy>
{

    public UDestroySessionCallbackProxy* DestroySession(UObject* WorldContextObject, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UDestroySessionCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("DestroySession"),  @params);
    }
}

public unsafe class EndMatchCallbackProxy : ObjectBase<UEndMatchCallbackProxy>
{

    public UEndMatchCallbackProxy* EndMatch(UObject* WorldContextObject, APlayerController* PlayerController, TScriptInterface<ITurnBasedMatchInterface> MatchActor, FString MatchID, EMPMatchOutcome LocalPlayerOutcome, EMPMatchOutcome OtherPlayersOutcome)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchActor", MatchActor), 
            ("MatchID", MatchID), 
            ("LocalPlayerOutcome", LocalPlayerOutcome), 
            ("OtherPlayersOutcome", OtherPlayersOutcome)
        ];
        return (UEndMatchCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("EndMatch"),  @params);
    }
}

public unsafe class EndTurnCallbackProxy : ObjectBase<UEndTurnCallbackProxy>
{

    public UEndTurnCallbackProxy* EndTurn(UObject* WorldContextObject, APlayerController* PlayerController, FString MatchID, TScriptInterface<ITurnBasedMatchInterface> TurnBasedMatchInterface)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchID", MatchID), 
            ("TurnBasedMatchInterface", TurnBasedMatchInterface)
        ];
        return (UEndTurnCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("EndTurn"),  @params);
    }
}

public unsafe class BlueprintSessionResult : ObjectBase<FBlueprintSessionResult>
{
}

public unsafe class FindSessionsCallbackProxy : ObjectBase<UFindSessionsCallbackProxy>
{

    public FString GetServerName(ref FBlueprintSessionResult Result)
    {
        Span<(string name, object value)> @params = [
            ("Result", Result)
        ];
        return ProcessEvent<FString>(GetFunction("GetServerName"),  @params);
    }
    public int GetPingInMs(ref FBlueprintSessionResult Result)
    {
        Span<(string name, object value)> @params = [
            ("Result", Result)
        ];
        return ProcessEvent<int>(GetFunction("GetPingInMs"),  @params);
    }
    public int GetMaxPlayers(ref FBlueprintSessionResult Result)
    {
        Span<(string name, object value)> @params = [
            ("Result", Result)
        ];
        return ProcessEvent<int>(GetFunction("GetMaxPlayers"),  @params);
    }
    public int GetCurrentPlayers(ref FBlueprintSessionResult Result)
    {
        Span<(string name, object value)> @params = [
            ("Result", Result)
        ];
        return ProcessEvent<int>(GetFunction("GetCurrentPlayers"),  @params);
    }
    public UFindSessionsCallbackProxy* FindSessions(UObject* WorldContextObject, APlayerController* PlayerController, int MaxResults, bool bUseLAN)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MaxResults", MaxResults), 
            ("bUseLAN", bUseLAN)
        ];
        return (UFindSessionsCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("FindSessions"),  @params);
    }
}

public unsafe class FindTurnBasedMatchCallbackProxy : ObjectBase<UFindTurnBasedMatchCallbackProxy>
{

    public UFindTurnBasedMatchCallbackProxy* FindTurnBasedMatch(UObject* WorldContextObject, APlayerController* PlayerController, TScriptInterface<ITurnBasedMatchInterface> MatchActor, int MinPlayers, int MaxPlayers, int PlayerGroup, bool ShowExistingMatches)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchActor", MatchActor), 
            ("MinPlayers", MinPlayers), 
            ("MaxPlayers", MaxPlayers), 
            ("PlayerGroup", PlayerGroup), 
            ("ShowExistingMatches", ShowExistingMatches)
        ];
        return (UFindTurnBasedMatchCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("FindTurnBasedMatch"),  @params);
    }
}

public unsafe class InAppPurchaseCallbackProxy : ObjectBase<UInAppPurchaseCallbackProxy>
{

    public UInAppPurchaseCallbackProxy* CreateProxyObjectForInAppPurchase(APlayerController* PlayerController, ref FInAppPurchaseProductRequest ProductRequest)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("ProductRequest", ProductRequest)
        ];
        return (UInAppPurchaseCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchase"),  @params);
    }
}

public unsafe class InAppPurchaseProductRequest2 : ObjectBase<FInAppPurchaseProductRequest2>
{

}

public unsafe class InAppPurchaseCallbackProxy2 : ObjectBase<UInAppPurchaseCallbackProxy2>
{

    public UInAppPurchaseCallbackProxy2* CreateProxyObjectForInAppPurchaseUnprocessedPurchases(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UInAppPurchaseCallbackProxy2*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseUnprocessedPurchases"),  @params);
    }
    public UInAppPurchaseCallbackProxy2* CreateProxyObjectForInAppPurchaseQueryOwned(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UInAppPurchaseCallbackProxy2*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseQueryOwned"),  @params);
    }
    public UInAppPurchaseCallbackProxy2* CreateProxyObjectForInAppPurchase(APlayerController* PlayerController, ref FInAppPurchaseProductRequest2 ProductRequest)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("ProductRequest", ProductRequest)
        ];
        return (UInAppPurchaseCallbackProxy2*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchase"),  @params);
    }
}

public unsafe class InAppPurchaseQueryCallbackProxy : ObjectBase<UInAppPurchaseQueryCallbackProxy>
{

    public UInAppPurchaseQueryCallbackProxy* CreateProxyObjectForInAppPurchaseQuery(APlayerController* PlayerController, ref TArray<FString> ProductIdentifiers)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("ProductIdentifiers", ProductIdentifiers)
        ];
        return (UInAppPurchaseQueryCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseQuery"),  @params);
    }
}

public unsafe class InAppPurchaseQueryCallbackProxy2 : ObjectBase<UInAppPurchaseQueryCallbackProxy2>
{

    public UInAppPurchaseQueryCallbackProxy2* CreateProxyObjectForInAppPurchaseQuery(APlayerController* PlayerController, ref TArray<FString> ProductIdentifiers)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("ProductIdentifiers", ProductIdentifiers)
        ];
        return (UInAppPurchaseQueryCallbackProxy2*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseQuery"),  @params);
    }
}

public unsafe class InAppPurchaseRestoreCallbackProxy : ObjectBase<UInAppPurchaseRestoreCallbackProxy>
{

    public UInAppPurchaseRestoreCallbackProxy* CreateProxyObjectForInAppPurchaseRestore(ref TArray<FInAppPurchaseProductRequest> ConsumableProductFlags, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("ConsumableProductFlags", ConsumableProductFlags), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UInAppPurchaseRestoreCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseRestore"),  @params);
    }
}

public unsafe class InAppPurchaseRestoreCallbackProxy2 : ObjectBase<UInAppPurchaseRestoreCallbackProxy2>
{

    public UInAppPurchaseRestoreCallbackProxy2* CreateProxyObjectForInAppPurchaseRestore(ref TArray<FInAppPurchaseProductRequest2> ConsumableProductFlags, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("ConsumableProductFlags", ConsumableProductFlags), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (UInAppPurchaseRestoreCallbackProxy2*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForInAppPurchaseRestore"),  @params);
    }
}

public unsafe class JoinSessionCallbackProxy : ObjectBase<UJoinSessionCallbackProxy>
{

    public UJoinSessionCallbackProxy* JoinSession(UObject* WorldContextObject, APlayerController* PlayerController, ref FBlueprintSessionResult SearchResult)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("SearchResult", SearchResult)
        ];
        return (UJoinSessionCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("JoinSession"),  @params);
    }
}

public unsafe class LeaderboardBlueprintLibrary : ObjectBase<ULeaderboardBlueprintLibrary>
{

    public bool WriteLeaderboardInteger(APlayerController* PlayerController, FName StatName, int StatValue)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("StatName", StatName), 
            ("StatValue", StatValue)
        ];
        return ProcessEvent<bool>(GetFunction("WriteLeaderboardInteger"),  @params);
    }
}

public unsafe class LeaderboardFlushCallbackProxy : ObjectBase<ULeaderboardFlushCallbackProxy>
{

    public ULeaderboardFlushCallbackProxy* CreateProxyObjectForFlush(APlayerController* PlayerController, FName SessionName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("SessionName", SessionName)
        ];
        return (ULeaderboardFlushCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForFlush"),  @params);
    }
}

public unsafe class LeaderboardQueryCallbackProxy : ObjectBase<ULeaderboardQueryCallbackProxy>
{

    public ULeaderboardQueryCallbackProxy* CreateProxyObjectForIntQuery(APlayerController* PlayerController, FName StatName)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("StatName", StatName)
        ];
        return (ULeaderboardQueryCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForIntQuery"),  @params);
    }
}

public unsafe class LogoutCallbackProxy : ObjectBase<ULogoutCallbackProxy>
{

    public ULogoutCallbackProxy* Logout(UObject* WorldContextObject, APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return (ULogoutCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("Logout"),  @params);
    }
}

public unsafe class OnlineBeacon : ObjectBase<AOnlineBeacon>
{

}

public unsafe class OnlineBeaconClient : ObjectBase<AOnlineBeaconClient>
{

    public void ClientOnConnected()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClientOnConnected"),  @params);
    }
}

public unsafe class OnlineBeaconHost : ObjectBase<AOnlineBeaconHost>
{

}

public unsafe class OnlineBeaconHostObject : ObjectBase<AOnlineBeaconHostObject>
{

}

public unsafe class OnlineEngineInterfaceImpl : ObjectBase<UOnlineEngineInterfaceImpl>
{

}

public unsafe class OnlinePIESettings : ObjectBase<UOnlinePIESettings>
{

}

public unsafe class OnlineSessionClient : ObjectBase<UOnlineSessionClient>
{

}

public unsafe class PartyReservation : ObjectBase<FPartyReservation>
{

}

public unsafe class PartyBeaconClient : ObjectBase<APartyBeaconClient>
{

    public void ServerUpdateReservationRequest(FString SessionId, ref FPartyReservation ReservationUpdate)
    {
        Span<(string name, object value)> @params = [
            ("SessionId", SessionId), 
            ("ReservationUpdate", ReservationUpdate)
        ];
        ProcessEvent(GetFunction("ServerUpdateReservationRequest"),  @params);
    }
    public void ServerReservationRequest(FString SessionId, ref FPartyReservation Reservation)
    {
        Span<(string name, object value)> @params = [
            ("SessionId", SessionId), 
            ("Reservation", Reservation)
        ];
        ProcessEvent(GetFunction("ServerReservationRequest"),  @params);
    }
    public void ServerRemoveMemberFromReservationRequest(FString SessionId, ref FPartyReservation ReservationUpdate)
    {
        Span<(string name, object value)> @params = [
            ("SessionId", SessionId), 
            ("ReservationUpdate", ReservationUpdate)
        ];
        ProcessEvent(GetFunction("ServerRemoveMemberFromReservationRequest"),  @params);
    }
    public void ServerCancelReservationRequest(ref FUniqueNetIdRepl PartyLeader)
    {
        Span<(string name, object value)> @params = [
            ("PartyLeader", PartyLeader)
        ];
        ProcessEvent(GetFunction("ServerCancelReservationRequest"),  @params);
    }
    public void ServerAddOrUpdateReservationRequest(FString SessionId, ref FPartyReservation Reservation)
    {
        Span<(string name, object value)> @params = [
            ("SessionId", SessionId), 
            ("Reservation", Reservation)
        ];
        ProcessEvent(GetFunction("ServerAddOrUpdateReservationRequest"),  @params);
    }
    public void ClientSendReservationUpdates(int NumRemainingReservations)
    {
        Span<(string name, object value)> @params = [
            ("NumRemainingReservations", NumRemainingReservations)
        ];
        ProcessEvent(GetFunction("ClientSendReservationUpdates"),  @params);
    }
    public void ClientSendReservationFull()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClientSendReservationFull"),  @params);
    }
    public void ClientReservationResponse(EPartyReservationResult ReservationResponse)
    {
        Span<(string name, object value)> @params = [
            ("ReservationResponse", ReservationResponse)
        ];
        ProcessEvent(GetFunction("ClientReservationResponse"),  @params);
    }
    public void ClientCancelReservationResponse(EPartyReservationResult ReservationResponse)
    {
        Span<(string name, object value)> @params = [
            ("ReservationResponse", ReservationResponse)
        ];
        ProcessEvent(GetFunction("ClientCancelReservationResponse"),  @params);
    }
}

public unsafe class PartyBeaconHost : ObjectBase<APartyBeaconHost>
{

}

public unsafe class PartyBeaconState : ObjectBase<UPartyBeaconState>
{

}

public unsafe class QuitMatchCallbackProxy : ObjectBase<UQuitMatchCallbackProxy>
{

    public UQuitMatchCallbackProxy* QuitMatch(UObject* WorldContextObject, APlayerController* PlayerController, FString MatchID, EMPMatchOutcome Outcome, int TurnTimeoutInSeconds)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchID", MatchID), 
            ("Outcome", Outcome), 
            ("TurnTimeoutInSeconds", TurnTimeoutInSeconds)
        ];
        return (UQuitMatchCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("QuitMatch"),  @params);
    }
}

public unsafe class ShowLoginUICallbackProxy : ObjectBase<UShowLoginUICallbackProxy>
{

    public UShowLoginUICallbackProxy* ShowExternalLoginUI(UObject* WorldContextObject, APlayerController* InPlayerController)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InPlayerController", (IntPtr)InPlayerController)
        ];
        return (UShowLoginUICallbackProxy*)ProcessEvent<IntPtr>(GetFunction("ShowExternalLoginUI"),  @params);
    }
}

public unsafe class SpectatorReservation : ObjectBase<FSpectatorReservation>
{

}

public unsafe class SpectatorBeaconClient : ObjectBase<ASpectatorBeaconClient>
{

    public void ServerReservationRequest(FString SessionId, ref FSpectatorReservation Reservation)
    {
        Span<(string name, object value)> @params = [
            ("SessionId", SessionId), 
            ("Reservation", Reservation)
        ];
        ProcessEvent(GetFunction("ServerReservationRequest"),  @params);
    }
    public void ServerCancelReservationRequest(ref FUniqueNetIdRepl Spectator)
    {
        Span<(string name, object value)> @params = [
            ("Spectator", Spectator)
        ];
        ProcessEvent(GetFunction("ServerCancelReservationRequest"),  @params);
    }
    public void ClientSendReservationUpdates(int NumRemainingReservations)
    {
        Span<(string name, object value)> @params = [
            ("NumRemainingReservations", NumRemainingReservations)
        ];
        ProcessEvent(GetFunction("ClientSendReservationUpdates"),  @params);
    }
    public void ClientSendReservationFull()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClientSendReservationFull"),  @params);
    }
    public void ClientReservationResponse(ESpectatorReservationResult ReservationResponse)
    {
        Span<(string name, object value)> @params = [
            ("ReservationResponse", ReservationResponse)
        ];
        ProcessEvent(GetFunction("ClientReservationResponse"),  @params);
    }
    public void ClientCancelReservationResponse(ESpectatorReservationResult ReservationResponse)
    {
        Span<(string name, object value)> @params = [
            ("ReservationResponse", ReservationResponse)
        ];
        ProcessEvent(GetFunction("ClientCancelReservationResponse"),  @params);
    }
}

public unsafe class SpectatorBeaconHost : ObjectBase<ASpectatorBeaconHost>
{

}

public unsafe class SpectatorBeaconState : ObjectBase<USpectatorBeaconState>
{

}

public unsafe class TestBeaconClient : ObjectBase<ATestBeaconClient>
{

    public void ServerPong()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ServerPong"),  @params);
    }
    public void ClientPing()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClientPing"),  @params);
    }
}

public unsafe class TestBeaconHost : ObjectBase<ATestBeaconHost>
{
}

public unsafe class TurnBasedBlueprintLibrary : ObjectBase<UTurnBasedBlueprintLibrary>
{

    public void RegisterTurnBasedMatchInterfaceObject(UObject* WorldContextObject, APlayerController* PlayerController, UObject* Object)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("Object", (IntPtr)Object)
        ];
        ProcessEvent(GetFunction("RegisterTurnBasedMatchInterfaceObject"),  @params);
    }
    public void GetPlayerDisplayName(UObject* WorldContextObject, APlayerController* PlayerController, FString MatchID, int PlayerIndex, ref FString PlayerDisplayName)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchID", MatchID), 
            ("PlayerIndex", PlayerIndex), 
            ("PlayerDisplayName", PlayerDisplayName)
        ];
        ProcessEvent(GetFunction("GetPlayerDisplayName"),  @params);
    }
    public void GetMyPlayerIndex(UObject* WorldContextObject, APlayerController* PlayerController, FString MatchID, ref int PlayerIndex)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchID", MatchID), 
            ("PlayerIndex", PlayerIndex)
        ];
        ProcessEvent(GetFunction("GetMyPlayerIndex"),  @params);
    }
    public void GetIsMyTurn(UObject* WorldContextObject, APlayerController* PlayerController, FString MatchID, ref bool bIsMyTurn)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("PlayerController", (IntPtr)PlayerController), 
            ("MatchID", MatchID), 
            ("bIsMyTurn", bIsMyTurn)
        ];
        ProcessEvent(GetFunction("GetIsMyTurn"),  @params);
    }
}

public unsafe class VoipListenerSynthComponent : ObjectBase<UVoipListenerSynthComponent>
{

    public bool IsIdling()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsIdling"),  @params);
    }
}

public unsafe class InAppPurchaseReceiptInfo2 : ObjectBase<FInAppPurchaseReceiptInfo2>
{

}

public unsafe class OnlineProxyStoreOffer : ObjectBase<FOnlineProxyStoreOffer>
{

}

public unsafe class InAppPurchaseRestoreInfo2 : ObjectBase<FInAppPurchaseRestoreInfo2>
{

}

public unsafe class InAppPurchaseReceiptInfo : ObjectBase<FInAppPurchaseReceiptInfo>
{

}

public unsafe class InAppPurchaseProductInfo2 : ObjectBase<FInAppPurchaseProductInfo2>
{

}

public unsafe class PlayerReservation : ObjectBase<FPlayerReservation>
{

}

public unsafe class PIELoginSettingsInternal : ObjectBase<FPIELoginSettingsInternal>
{

}

public unsafe class PartyBeaconCrossplayPlatformMapping : ObjectBase<FPartyBeaconCrossplayPlatformMapping>
{

}

