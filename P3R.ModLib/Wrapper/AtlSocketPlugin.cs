using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AtlSocketBase : ObjectBase<UAtlSocketBase>
{
    public AtlSocketBase(IntPtr pointer) : base(pointer) {}}

public unsafe class AtlSocketStringUtils : ObjectBase<UAtlSocketStringUtils>
{
    public AtlSocketStringUtils(IntPtr pointer) : base(pointer) {}}

public unsafe class AtlTcpListener : ObjectBase<UAtlTcpListener>
{
    public AtlTcpListener(IntPtr pointer) : base(pointer) {}
    public void OnReceivedFromClient(UAtlSocketBase* Socket, ref TArray<byte> Buffer)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket), 
            ("Buffer", Buffer)
        ];
        ProcessEvent(GetFunction("OnReceivedFromClient"), @params);
    }
    public void OnDisconnectedClient(UAtlSocketBase* Socket)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket)
        ];
        ProcessEvent(GetFunction("OnDisconnectedClient"), @params);
    }
}

public unsafe class AtlTcpSocket : ObjectBase<UAtlTcpSocket>
{
    public AtlTcpSocket(IntPtr pointer) : base(pointer) {}}

