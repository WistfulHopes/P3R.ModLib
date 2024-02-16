public enum EDatasmithAreaLightActorType {
    Point = 0,
    Spot = 1,
    Rect = 2,
    EDatasmithAreaLightActorType_MAX = 3,
};

public enum EDatasmithAreaLightActorShape {
    Rectangle = 0,
    Disc = 1,
    Sphere = 2,
    Cylinder = 3,
    None = 4,
    EDatasmithAreaLightActorShape_MAX = 5,
};

public enum EDatasmithCADRetessellationRule {
    All = 0,
    SkipDeletedSurfaces = 1,
    EDatasmithCADRetessellationRule_MAX = 2,
};

public enum EDatasmithCADStitchingTechnique {
    StitchingNone = 0,
    StitchingHeal = 1,
    StitchingSew = 2,
    EDatasmithCADStitchingTechnique_MAX = 3,
};

public enum EDatasmithImportScene {
    NewLevel = 0,
    CurrentLevel = 1,
    AssetsOnly = 2,
    EDatasmithImportScene_MAX = 3,
};

public enum EDatasmithImportLightmapMax {
    LIGHTMAP_64 = 0,
    LIGHTMAP_128 = 1,
    LIGHTMAP_256 = 2,
    LIGHTMAP_512 = 3,
    LIGHTMAP_1024 = 4,
    LIGHTMAP_2048 = 5,
    LIGHTMAP_4096 = 6,
    LIGHTMAP_MAX = 7,
};

public enum EDatasmithImportLightmapMin {
    LIGHTMAP_16 = 0,
    LIGHTMAP_32 = 1,
    LIGHTMAP_64 = 2,
    LIGHTMAP_128 = 3,
    LIGHTMAP_256 = 4,
    LIGHTMAP_512 = 5,
    LIGHTMAP_MAX = 6,
};

public enum EDatasmithImportMaterialQuality {
    UseNoFresnelCurves = 0,
    UseSimplifierFresnelCurves = 1,
    UseRealFresnelCurves = 2,
    EDatasmithImportMaterialQuality_MAX = 3,
};

public enum EDatasmithImportActorPolicy {
    Update = 0,
    Full = 1,
    Ignore = 2,
    EDatasmithImportActorPolicy_MAX = 3,
};

public enum EDatasmithImportAssetConflictPolicy {
    Replace = 0,
    Update = 1,
    Use = 2,
    Ignore = 3,
    EDatasmithImportAssetConflictPolicy_MAX = 4,
};

public enum EDatasmithImportSearchPackagePolicy {
    Current = 0,
    All = 1,
    EDatasmithImportSearchPackagePolicy_MAX = 2,
};
