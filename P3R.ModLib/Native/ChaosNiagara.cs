using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct UNiagaraDataInterfaceChaosDestruction
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
    [FieldOffset(0x0038)] public TSet<IntPtr> ChaosSolverActorSet;
    [FieldOffset(0x0088)] public EDataSourceTypeEnum DataSourceType;
    [FieldOffset(0x008C)] public int DataProcessFrequency;
    [FieldOffset(0x0090)] public int MaxNumberOfDataEntriesToSpawn;
    [FieldOffset(0x0094)] public bool DoSpawn;
    [FieldOffset(0x0098)] public FVector2D SpawnMultiplierMinMax;
    [FieldOffset(0x00A0)] public float SpawnChance;
    [FieldOffset(0x00A4)] public FVector2D ImpulseToSpawnMinMax;
    [FieldOffset(0x00AC)] public FVector2D SpeedToSpawnMinMax;
    [FieldOffset(0x00B4)] public FVector2D MassToSpawnMinMax;
    [FieldOffset(0x00BC)] public FVector2D ExtentMinToSpawnMinMax;
    [FieldOffset(0x00C4)] public FVector2D ExtentMaxToSpawnMinMax;
    [FieldOffset(0x00CC)] public FVector2D VolumeToSpawnMinMax;
    [FieldOffset(0x00D4)] public FVector2D SolverTimeToSpawnMinMax;
    [FieldOffset(0x00DC)] public int SurfaceTypeToSpawn;
    [FieldOffset(0x00E0)] public ELocationFilteringModeEnum LocationFilteringMode;
    [FieldOffset(0x00E1)] public ELocationXToSpawnEnum LocationXToSpawn;
    [FieldOffset(0x00E4)] public FVector2D LocationXToSpawnMinMax;
    [FieldOffset(0x00EC)] public ELocationYToSpawnEnum LocationYToSpawn;
    [FieldOffset(0x00F0)] public FVector2D LocationYToSpawnMinMax;
    [FieldOffset(0x00F8)] public ELocationZToSpawnEnum LocationZToSpawn;
    [FieldOffset(0x00FC)] public FVector2D LocationZToSpawnMinMax;
    [FieldOffset(0x0104)] public EDataSortTypeEnum DataSortingType;
    [FieldOffset(0x0105)] public bool bGetExternalCollisionData;
    [FieldOffset(0x0106)] public bool DoSpatialHash;
    [FieldOffset(0x0108)] public FVector SpatialHashVolumeMin;
    [FieldOffset(0x0114)] public FVector SpatialHashVolumeMax;
    [FieldOffset(0x0120)] public FVector SpatialHashVolumeCellSize;
    [FieldOffset(0x012C)] public int MaxDataPerCell;
    [FieldOffset(0x0130)] public bool bApplyMaterialsFilter;
    [FieldOffset(0x0138)] public TSet<IntPtr> ChaosBreakingMaterialSet;
    [FieldOffset(0x0188)] public bool bGetExternalBreakingData;
    [FieldOffset(0x0189)] public bool bGetExternalTrailingData;
    [FieldOffset(0x018C)] public FVector2D RandomPositionMagnitudeMinMax;
    [FieldOffset(0x0194)] public float InheritedVelocityMultiplier;
    [FieldOffset(0x0198)] public ERandomVelocityGenerationTypeEnum RandomVelocityGenerationType;
    [FieldOffset(0x019C)] public FVector2D RandomVelocityMagnitudeMinMax;
    [FieldOffset(0x01A4)] public float SpreadAngleMax;
    [FieldOffset(0x01A8)] public FVector VelocityOffsetMin;
    [FieldOffset(0x01B4)] public FVector VelocityOffsetMax;
    [FieldOffset(0x01C0)] public FVector2D FinalVelocityMagnitudeMinMax;
    [FieldOffset(0x01C8)] public float MaxLatency;
    [FieldOffset(0x01CC)] public EDebugTypeEnum DebugType;
    [FieldOffset(0x01D0)] public int LastSpawnedPointID;
    [FieldOffset(0x01D4)] public float LastSpawnTime;
    [FieldOffset(0x01E8)] public float SolverTime;
    [FieldOffset(0x01EC)] public float TimeStampOfLastProcessedData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UNiagaraDataInterfacePhysicsField
{
    [FieldOffset(0x0000)] public UNiagaraDataInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x44)] 
public unsafe struct FChaosDestructionEvent
{
    [FieldOffset(0x0000)] public FVector Position;
    [FieldOffset(0x000C)] public FVector Normal;
    [FieldOffset(0x0018)] public FVector Velocity;
    [FieldOffset(0x0024)] public FVector AngularVelocity;
    [FieldOffset(0x0030)] public float ExtentMin;
    [FieldOffset(0x0034)] public float ExtentMax;
    [FieldOffset(0x0038)] public int ParticleID;
    [FieldOffset(0x003C)] public float Time;
    [FieldOffset(0x0040)] public int Type;
}

