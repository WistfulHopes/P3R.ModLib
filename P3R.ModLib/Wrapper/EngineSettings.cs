using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ConsoleSettings : ObjectBase<UConsoleSettings>
{
    public ConsoleSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class GameMapsSettings : ObjectBase<UGameMapsSettings>
{
    public GameMapsSettings(IntPtr pointer) : base(pointer) {}
    public void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer)
    {
        Span<(string name, object value)> @params = [
            ("bSkipFirstPlayer", bSkipFirstPlayer)
        ];
        ProcessEvent(GetFunction("SetSkipAssigningGamepadToPlayer1"), @params);
    }
    public bool GetSkipAssigningGamepadToPlayer1()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetSkipAssigningGamepadToPlayer1"), @params);
    }
    public UGameMapsSettings* GetGameMapsSettings()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UGameMapsSettings*)ProcessEvent<IntPtr>(GetFunction("GetGameMapsSettings"), @params);
    }
}

public unsafe class GameNetworkManagerSettings : ObjectBase<UGameNetworkManagerSettings>
{
    public GameNetworkManagerSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class GameSessionSettings : ObjectBase<UGameSessionSettings>
{
    public GameSessionSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class GeneralEngineSettings : ObjectBase<UGeneralEngineSettings>
{
    public GeneralEngineSettings(IntPtr pointer) : base(pointer) {}}

public unsafe class GeneralProjectSettings : ObjectBase<UGeneralProjectSettings>
{
    public GeneralProjectSettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class HudSettings : ObjectBase<UHudSettings>
{
    public HudSettings(IntPtr pointer) : base(pointer) {}
}

