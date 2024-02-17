using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class NamedInterfaces : ObjectBase<UNamedInterfaces>
{
    public NamedInterfaces(IntPtr pointer) : base(pointer) {}
}

public unsafe class TurnBasedMatchInterface : ObjectBase<ITurnBasedMatchInterface>
{
    public TurnBasedMatchInterface(IntPtr pointer) : base(pointer) {}
    public void OnMatchReceivedTurn(FString Match, bool bDidBecomeActive)
    {
        Span<(string name, object value)> @params = [
            ("Match", Match), 
            ("bDidBecomeActive", bDidBecomeActive)
        ];
        ProcessEvent(GetFunction("OnMatchReceivedTurn"), @params);
    }
    public void OnMatchEnded(FString Match)
    {
        Span<(string name, object value)> @params = [
            ("Match", Match)
        ];
        ProcessEvent(GetFunction("OnMatchEnded"), @params);
    }
}

