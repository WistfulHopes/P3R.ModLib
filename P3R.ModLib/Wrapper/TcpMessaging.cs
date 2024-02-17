using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class TcpMessagingSettings : ObjectBase<UTcpMessagingSettings>
{
    public TcpMessagingSettings(IntPtr pointer) : base(pointer) {}
}

