using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FEngineServiceNotification
{
    [FieldOffset(0x0000)] public FString Text;
    [FieldOffset(0x0010)] public double TimeSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FEngineServiceTerminate
{
    [FieldOffset(0x0000)] public FString UserName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEngineServiceExecuteCommand
{
    [FieldOffset(0x0000)] public FString Command;
    [FieldOffset(0x0010)] public FString UserName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEngineServiceAuthGrant
{
    [FieldOffset(0x0000)] public FString UserName;
    [FieldOffset(0x0010)] public FString UserToGrant;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEngineServiceAuthDeny
{
    [FieldOffset(0x0000)] public FString UserName;
    [FieldOffset(0x0010)] public FString UserToDeny;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FEngineServicePong
{
    [FieldOffset(0x0000)] public FString CurrentLevel;
    [FieldOffset(0x0010)] public int EngineVersion;
    [FieldOffset(0x0014)] public bool HasBegunPlay;
    [FieldOffset(0x0018)] public FGuid InstanceId;
    [FieldOffset(0x0028)] public FString InstanceType;
    [FieldOffset(0x0038)] public FGuid SessionId;
    [FieldOffset(0x0048)] public float WorldTimeSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FEngineServicePing
{
}

