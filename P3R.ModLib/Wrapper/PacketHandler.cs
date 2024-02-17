using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class HandlerComponentFactory : ObjectBase<UHandlerComponentFactory>
{
    public HandlerComponentFactory(IntPtr pointer) : base(pointer) {}}

public unsafe class PacketHandlerProfileConfig : ObjectBase<UPacketHandlerProfileConfig>
{
    public PacketHandlerProfileConfig(IntPtr pointer) : base(pointer) {}
}

