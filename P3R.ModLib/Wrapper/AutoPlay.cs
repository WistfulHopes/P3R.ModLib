using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class APCommandBase : ObjectBase<UAPCommandBase>
{
}

public unsafe class APCmdEcho : ObjectBase<UAPCmdEcho>
{
}

public unsafe class APCmdEndRecord : ObjectBase<UAPCmdEndRecord>
{

}

public unsafe class APCmdNop : ObjectBase<UAPCmdNop>
{
}

public unsafe class APCmdRecordRequest : ObjectBase<UAPCmdRecordRequest>
{
}

public unsafe class APCmdScreenShot : ObjectBase<UAPCmdScreenShot>
{
}

public unsafe class APCmdSlowMotion : ObjectBase<UAPCmdSlowMotion>
{
}

public unsafe class APCmdStartRecord : ObjectBase<UAPCmdStartRecord>
{

}

public unsafe class APCmdWaitForNextCommand : ObjectBase<UAPCmdWaitForNextCommand>
{

}

public unsafe class AutoPlayCommandLogger : ObjectBase<UAutoPlayCommandLogger>
{
}

public unsafe class AutoPlayCommandManager : ObjectBase<UAutoPlayCommandManager>
{

}

public unsafe class AutoPlayCommandServer : ObjectBase<UAutoPlayCommandServer>
{

    public void OnReceivedAsString(UAtlSocketBase* Socket, FString str)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket), 
            ("str", str)
        ];
        ProcessEvent(GetFunction("OnReceivedAsString"),  @params);
    }
    public void OnDisconnected(UAtlSocketBase* Socket)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket)
        ];
        ProcessEvent(GetFunction("OnDisconnected"),  @params);
    }
    public void OnConnected(UAtlSocketBase* Socket)
    {
        Span<(string name, object value)> @params = [
            ("Socket", (IntPtr)Socket)
        ];
        ProcessEvent(GetFunction("OnConnected"),  @params);
    }
}

public unsafe class AutoPlayCommandWorker : ObjectBase<UAutoPlayCommandWorker>
{

}

public unsafe class AutoPlayEventObject : ObjectBase<UAutoPlayEventObject>
{
}

public unsafe class AutoPlayGameInstanceSubsystem : ObjectBase<UAutoPlayGameInstanceSubsystem>
{

}

public unsafe class APCommandParam : ObjectBase<FAPCommandParam>
{

}

public unsafe class APEndRecordParam : ObjectBase<FAPEndRecordParam>
{
}

public unsafe class APStartRecordParam : ObjectBase<FAPStartRecordParam>
{
}

public unsafe class APSlowMotionParam : ObjectBase<FAPSlowMotionParam>
{

}

public unsafe class APScreenShotParam : ObjectBase<FAPScreenShotParam>
{

}

public unsafe class APWaitForNextCommandParam : ObjectBase<FAPWaitForNextCommandParam>
{

}

public unsafe class APNopParam : ObjectBase<FAPNopParam>
{
}

public unsafe class APEchoParam : ObjectBase<FAPEchoParam>
{

}

public unsafe class APCommandLog : ObjectBase<FAPCommandLog>
{

}

public unsafe class APCommandReserve : ObjectBase<FAPCommandReserve>
{

}

public unsafe class APCommandInstance : ObjectBase<FAPCommandInstance>
{

}

