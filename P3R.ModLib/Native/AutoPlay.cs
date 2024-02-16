using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAPCommandBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UAPCmdEcho
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAPCmdEndRecord
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
    [FieldOffset(0x0060)] public TWeakObjectPtr<UAutoPlayGameInstanceSubsystem> APSubsystem_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UAPCmdNop
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UAPCmdRecordRequest
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAPCmdScreenShot
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAPCmdSlowMotion
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UAPCmdStartRecord
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
    [FieldOffset(0x0060)] public TWeakObjectPtr<UAutoPlayGameInstanceSubsystem> APSubsystem_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UAPCmdWaitForNextCommand
{
    [FieldOffset(0x0000)] public UAPCommandBase baseObj;
    [FieldOffset(0x0068)] public TWeakObjectPtr<UAutoPlayGameInstanceSubsystem> APSubsystem_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UAutoPlayCommandLogger
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAPCommandReserve
{
    [FieldOffset(0x0000)] public UAPCommandBase* Command;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAutoPlayCommandManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FAPCommandReserve> CommandQueue_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UAutoPlayCommandServer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UAtlTcpListener* Server_;
    [FieldOffset(0x0030)] public UAutoPlayCommandManager* CommandManager_;
    [FieldOffset(0x0038)] public UAutoPlayCommandLogger* CommandLogger_;
    [FieldOffset(0x0040)] public UAPCommandBase* CurrentCommand_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FAPCommandInstance
{
    [FieldOffset(0x0000)] public UAPCommandBase* Command;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct UAutoPlayCommandWorker
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<FAPCommandInstance> CommandQueue_;
    [FieldOffset(0x0050)] public FAPCommandInstance CurrentCommand_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UAutoPlayEventObject
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B8)] 
public unsafe struct UAutoPlayGameInstanceSubsystem
{
    [FieldOffset(0x0000)] public UGameInstanceSubsystem baseObj;
    [FieldOffset(0x0260)] public TMap<uint, IntPtr> EventObjects_;
    [FieldOffset(0x02D8)] public UFont* FontObject_;
    [FieldOffset(0x02E0)] public UAutoPlayCommandServer* CommandServer_;
    [FieldOffset(0x02E8)] public UAutoPlayCommandLogger* CommandLogger_;
    [FieldOffset(0x02F0)] public UAutoPlayCommandManager* CommandManager_;
    [FieldOffset(0x02F8)] public UAutoPlayCommandWorker* CommandWorker_;
    [FieldOffset(0x03A8)] public UTexture* PadImage_;
    [FieldOffset(0x03B0)] public UTexture* PadPress_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAPCommandParam
{
    [FieldOffset(0x0000)] public FString command_name;
    [FieldOffset(0x0010)] public FString filter_name;
    [FieldOffset(0x0020)] public UStruct* TypeInfo_;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAPEndRecordParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAPStartRecordParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAPSlowMotionParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
    [FieldOffset(0x0028)] public float Speed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FAPScreenShotParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
    [FieldOffset(0x0028)] public FString Filename;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FAPWaitForNextCommandParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
    [FieldOffset(0x0028)] public float time_limit;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAPNopParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAPEchoParam
{
    [FieldOffset(0x0000)] public FAPCommandParam baseObj;
    [FieldOffset(0x0028)] public FString Message;
    [FieldOffset(0x0038)] public float DisplayTime;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAPCommandLog
{
    [FieldOffset(0x0000)] public float Time;
}

