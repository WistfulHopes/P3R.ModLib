using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class APCommandBase : ObjectBase<UAPCommandBase>
{
    public APCommandBase(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdEcho : ObjectBase<UAPCmdEcho>
{
    public APCmdEcho(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdEndRecord : ObjectBase<UAPCmdEndRecord>
{
    public APCmdEndRecord(IntPtr pointer) : base(pointer) {}
}

public unsafe class APCmdNop : ObjectBase<UAPCmdNop>
{
    public APCmdNop(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdRecordRequest : ObjectBase<UAPCmdRecordRequest>
{
    public APCmdRecordRequest(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdScreenShot : ObjectBase<UAPCmdScreenShot>
{
    public APCmdScreenShot(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdSlowMotion : ObjectBase<UAPCmdSlowMotion>
{
    public APCmdSlowMotion(IntPtr pointer) : base(pointer) {}}

public unsafe class APCmdStartRecord : ObjectBase<UAPCmdStartRecord>
{
    public APCmdStartRecord(IntPtr pointer) : base(pointer) {}
}

public unsafe class APCmdWaitForNextCommand : ObjectBase<UAPCmdWaitForNextCommand>
{
    public APCmdWaitForNextCommand(IntPtr pointer) : base(pointer) {}
}

public unsafe class AutoPlayCommandLogger : ObjectBase<UAutoPlayCommandLogger>
{
    public AutoPlayCommandLogger(IntPtr pointer) : base(pointer) {}}

public unsafe class AutoPlayCommandManager : ObjectBase<UAutoPlayCommandManager>
{
    public AutoPlayCommandManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class AutoPlayCommandServer : ObjectBase<UAutoPlayCommandServer>
{
    public AutoPlayCommandServer(IntPtr pointer) : base(pointer) {}
    public void OnReceivedAsString(UAtlSocketBase* Socket, FString str)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket), 
            ("str", str)
        ];
        ProcessEvent(GetFunction("OnReceivedAsString"), @params);
    }
    public void OnDisconnected(UAtlSocketBase* Socket)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket)
        ];
        ProcessEvent(GetFunction("OnDisconnected"), @params);
    }
    public void OnConnected(UAtlSocketBase* Socket)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket)
        ];
        ProcessEvent(GetFunction("OnConnected"), @params);
    }
}

public unsafe class AutoPlayCommandWorker : ObjectBase<UAutoPlayCommandWorker>
{
    public AutoPlayCommandWorker(IntPtr pointer) : base(pointer) {}
}

public unsafe class AutoPlayEventObject : ObjectBase<UAutoPlayEventObject>
{
    public AutoPlayEventObject(IntPtr pointer) : base(pointer) {}}

public unsafe class AutoPlayGameInstanceSubsystem : ObjectBase<UAutoPlayGameInstanceSubsystem>
{
    public AutoPlayGameInstanceSubsystem(IntPtr pointer) : base(pointer) {}
}

