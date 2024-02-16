using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ConsoleSettings : ObjectBase<UConsoleSettings>
{

}

public unsafe class GameMapsSettings : ObjectBase<UGameMapsSettings>
{

    public void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer)
    {
        Span<(string name, object value)> @params = [
            ("bSkipFirstPlayer", bSkipFirstPlayer)
        ];
        ProcessEvent(GetFunction("SetSkipAssigningGamepadToPlayer1"),  @params);
    }
    public bool GetSkipAssigningGamepadToPlayer1()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetSkipAssigningGamepadToPlayer1"),  @params);
    }
    public UGameMapsSettings* GetGameMapsSettings()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UGameMapsSettings*)ProcessEvent<IntPtr>(GetFunction("GetGameMapsSettings"),  @params);
    }
}

public unsafe class GameNetworkManagerSettings : ObjectBase<UGameNetworkManagerSettings>
{

}

public unsafe class GameSessionSettings : ObjectBase<UGameSessionSettings>
{

}

public unsafe class GeneralEngineSettings : ObjectBase<UGeneralEngineSettings>
{
}

public unsafe class GeneralProjectSettings : ObjectBase<UGeneralProjectSettings>
{

}

public unsafe class HudSettings : ObjectBase<UHudSettings>
{

}

public unsafe class AutoCompleteCommand : ObjectBase<FAutoCompleteCommand>
{

}

public unsafe class GameModeName : ObjectBase<FGameModeName>
{

}

