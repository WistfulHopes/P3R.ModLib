public enum ELocationZToSpawnEnum {
    ChaosNiagara_LocationZToSpawn_None = 0,
    ChaosNiagara_LocationZToSpawn_Min = 1,
    ChaosNiagara_LocationZToSpawn_Max = 2,
    ChaosNiagara_LocationZToSpawn_MinMax = 3,
    ChaosNiagara_Max = 4,
};

public enum ELocationYToSpawnEnum {
    ChaosNiagara_LocationYToSpawn_None = 0,
    ChaosNiagara_LocationYToSpawn_Min = 1,
    ChaosNiagara_LocationYToSpawn_Max = 2,
    ChaosNiagara_LocationYToSpawn_MinMax = 3,
    ChaosNiagara_Max = 4,
};

public enum ELocationXToSpawnEnum {
    ChaosNiagara_LocationXToSpawn_None = 0,
    ChaosNiagara_LocationXToSpawn_Min = 1,
    ChaosNiagara_LocationXToSpawn_Max = 2,
    ChaosNiagara_LocationXToSpawn_MinMax = 3,
    ChaosNiagara_Max = 4,
};

public enum ELocationFilteringModeEnum {
    ChaosNiagara_LocationFilteringMode_Inclusive = 0,
    ChaosNiagara_LocationFilteringMode_Exclusive = 1,
    ChaosNiagara_Max = 2,
};

public enum EDataSourceTypeEnum {
    ChaosNiagara_DataSourceType_Collision = 0,
    ChaosNiagara_DataSourceType_Breaking = 1,
    ChaosNiagara_DataSourceType_Trailing = 2,
    ChaosNiagara_Max = 3,
};

public enum EDebugTypeEnum {
    ChaosNiagara_DebugType_NoDebug = 0,
    ChaosNiagara_DebugType_ColorBySolver = 1,
    ChaosNiagara_DebugType_ColorByParticleIndex = 2,
    ChaosNiagara_Max = 3,
};

public enum ERandomVelocityGenerationTypeEnum {
    ChaosNiagara_RandomVelocityGenerationType_RandomDistribution = 0,
    ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers = 1,
    ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased = 2,
    ChaosNiagara_Max = 3,
};

public enum EDataSortTypeEnum {
    ChaosNiagara_DataSortType_NoSorting = 0,
    ChaosNiagara_DataSortType_RandomShuffle = 1,
    ChaosNiagara_DataSortType_SortByMassMaxToMin = 2,
    ChaosNiagara_DataSortType_SortByMassMinToMax = 3,
    ChaosNiagara_Max = 4,
};

