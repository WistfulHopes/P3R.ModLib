using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SteamAuthComponentModuleInterface : ObjectBase<USteamAuthComponentModuleInterface>
{
    public SteamAuthComponentModuleInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class SteamNetConnection : ObjectBase<USteamNetConnection>
{
    public SteamNetConnection(IntPtr pointer) : base(pointer) {}
}

public unsafe class SteamNetDriver : ObjectBase<USteamNetDriver>
{
    public SteamNetDriver(IntPtr pointer) : base(pointer) {}}

