using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UNiagaraScriptBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FNiagaraDataInterfaceGeneratedFunction
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FNiagaraDataInterfaceGPUParamInfo
{
    [FieldOffset(0x0000)] public FString DataInterfaceHLSLSymbol;
    [FieldOffset(0x0010)] public FString DIClassName;
    [FieldOffset(0x0020)] public TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSimulationStageMetaData
{
    [FieldOffset(0x0000)] public FName SimulationStageName;
    [FieldOffset(0x0008)] public FName IterationSource;
    [FieldOffset(0x0010)] public byte bSpawnOnly;
    [FieldOffset(0x0010)] public byte bWritesParticles;
    [FieldOffset(0x0010)] public byte bPartialParticleUpdate;
    [FieldOffset(0x0018)] public TArray<FName> OutputDestinations;
    [FieldOffset(0x0028)] public int MinStage;
    [FieldOffset(0x002C)] public int MaxStage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FNiagaraCompileEvent
{
    [FieldOffset(0x0000)] public FNiagaraCompileEventSeverity Severity;
    [FieldOffset(0x0008)] public FString Message;
    [FieldOffset(0x0018)] public FString ShortDescription;
    [FieldOffset(0x0028)] public bool bDismissable;
    [FieldOffset(0x002C)] public FGuid NodeGuid;
    [FieldOffset(0x003C)] public FGuid PinGuid;
    [FieldOffset(0x0050)] public TArray<FGuid> StackGuids;
}

