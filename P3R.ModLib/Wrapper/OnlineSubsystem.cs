using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class NamedInterfaces : ObjectBase<UNamedInterfaces>
{

}

public unsafe class TurnBasedMatchInterface : ObjectBase<ITurnBasedMatchInterface>
{

    public void OnMatchReceivedTurn(FString Match, bool bDidBecomeActive)
    {
        Span<(string name, object value)> @params = [
            ("Match", Match), 
            ("bDidBecomeActive", bDidBecomeActive)
        ];
        ProcessEvent(GetFunction("OnMatchReceivedTurn"),  @params);
    }
    public void OnMatchEnded(FString Match)
    {
        Span<(string name, object value)> @params = [
            ("Match", Match)
        ];
        ProcessEvent(GetFunction("OnMatchEnded"),  @params);
    }
}

public unsafe class InAppPurchaseProductRequest : ObjectBase<FInAppPurchaseProductRequest>
{

}

public unsafe class InAppPurchaseProductInfo : ObjectBase<FInAppPurchaseProductInfo>
{

}

public unsafe class InAppPurchaseRestoreInfo : ObjectBase<FInAppPurchaseRestoreInfo>
{

}

public unsafe class NamedInterfaceDef : ObjectBase<FNamedInterfaceDef>
{

}

public unsafe class NamedInterface : ObjectBase<FNamedInterface>
{

}

