using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0xA0)] 
public unsafe struct UMaterialExpressionSpriteTextureSampler
{
    [FieldOffset(0x0000)] public UMaterialExpressionTextureSampleParameter2D baseObj;
    [FieldOffset(0x0080)] public bool bSampleAdditionalTextures;
    [FieldOffset(0x0084)] public int AdditionalSlotIndex;
    [FieldOffset(0x0088)] public FText SlotDisplayName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C0)] 
public unsafe struct APaperCharacter
{
    [FieldOffset(0x0000)] public ACharacter baseObj;
    [FieldOffset(0x04B8)] public UPaperFlipbookComponent* Sprite;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPaperFlipbookKeyFrame
{
    [FieldOffset(0x0000)] public UPaperSprite* Sprite;
    [FieldOffset(0x0008)] public int FrameRun;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UPaperFlipbook
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public float FramesPerSecond;
    [FieldOffset(0x0030)] public TArray<FPaperFlipbookKeyFrame> KeyFrames;
    [FieldOffset(0x0040)] public UMaterialInterface* DefaultMaterial;
    [FieldOffset(0x0048)] public EFlipbookCollisionMode CollisionSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APaperFlipbookActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UPaperFlipbookComponent* RenderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4C0)] 
public unsafe struct UPaperFlipbookComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public UPaperFlipbook* SourceFlipbook;
    [FieldOffset(0x0480)] public UMaterialInterface* Material;
    [FieldOffset(0x0488)] public float PlayRate;
    [FieldOffset(0x048C)] public byte bLooping;
    [FieldOffset(0x048C)] public byte bReversePlayback;
    [FieldOffset(0x048C)] public byte bPlaying;
    [FieldOffset(0x0490)] public float AccumulatedTime;
    [FieldOffset(0x0494)] public int CachedFrameIndex;
    [FieldOffset(0x0498)] public FLinearColor SpriteColor;
    [FieldOffset(0x04A8)] public UBodySetup* CachedBodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APaperGroupedSpriteActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UPaperGroupedSpriteComponent* RenderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FSpriteInstanceData
{
    [FieldOffset(0x0000)] public FMatrix Transform;
    [FieldOffset(0x0040)] public UPaperSprite* SourceSprite;
    [FieldOffset(0x0048)] public FColor VertexColor;
    [FieldOffset(0x004C)] public int MaterialIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4B0)] 
public unsafe struct UPaperGroupedSpriteComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public TArray<IntPtr> InstanceMaterials;
    [FieldOffset(0x0488)] public TArray<FSpriteInstanceData> PerInstanceSpriteData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UPaperRuntimeSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bEnableSpriteAtlasGroups;
    [FieldOffset(0x0029)] public bool bEnableTerrainSplineEditing;
    [FieldOffset(0x002A)] public bool bResizeSpriteDataToMatchTextures;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPaperSpriteSocket
{
    [FieldOffset(0x0000)] public FTransform LocalTransform;
    [FieldOffset(0x0030)] public FName SocketName;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UPaperSprite
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public TArray<IntPtr> AdditionalSourceTextures;
    [FieldOffset(0x0048)] public FVector2D BakedSourceUV;
    [FieldOffset(0x0050)] public FVector2D BakedSourceDimension;
    [FieldOffset(0x0058)] public UTexture2D* BakedSourceTexture;
    [FieldOffset(0x0060)] public UMaterialInterface* DefaultMaterial;
    [FieldOffset(0x0068)] public UMaterialInterface* AlternateMaterial;
    [FieldOffset(0x0070)] public TArray<FPaperSpriteSocket> Sockets;
    [FieldOffset(0x0080)] public ESpriteCollisionMode SpriteCollisionDomain;
    [FieldOffset(0x0084)] public float PixelsPerUnrealUnit;
    [FieldOffset(0x0088)] public UBodySetup* BodySetup;
    [FieldOffset(0x0090)] public int AlternateMaterialSplitIndex;
    [FieldOffset(0x0098)] public TArray<FVector4> BakedRenderData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APaperSpriteActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UPaperSpriteComponent* RenderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UPaperSpriteAtlas
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UPaperSpriteBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UPaperSpriteComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public UPaperSprite* SourceSprite;
    [FieldOffset(0x0480)] public UMaterialInterface* MaterialOverride;
    [FieldOffset(0x0488)] public FLinearColor SpriteColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct APaperTerrainActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public USceneComponent* DummyRoot;
    [FieldOffset(0x0228)] public UPaperTerrainSplineComponent* SplineComponent;
    [FieldOffset(0x0230)] public UPaperTerrainComponent* RenderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4B0)] 
public unsafe struct UPaperTerrainComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public UPaperTerrainMaterial* TerrainMaterial;
    [FieldOffset(0x0458)] public bool bClosedSpline;
    [FieldOffset(0x0459)] public bool bFilledSpline;
    [FieldOffset(0x0460)] public UPaperTerrainSplineComponent* AssociatedSpline;
    [FieldOffset(0x0468)] public int RandomSeed;
    [FieldOffset(0x046C)] public float SegmentOverlapAmount;
    [FieldOffset(0x0470)] public FLinearColor TerrainColor;
    [FieldOffset(0x0480)] public int ReparamStepsPerSegment;
    [FieldOffset(0x0484)] public ESpriteCollisionMode SpriteCollisionDomain;
    [FieldOffset(0x0488)] public float CollisionThickness;
    [FieldOffset(0x0490)] public UBodySetup* CachedBodySetup;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FPaperTerrainMaterialRule
{
    [FieldOffset(0x0000)] public UPaperSprite* StartCap;
    [FieldOffset(0x0008)] public TArray<IntPtr> Body;
    [FieldOffset(0x0018)] public UPaperSprite* EndCap;
    [FieldOffset(0x0020)] public float MinimumAngle;
    [FieldOffset(0x0024)] public float MaximumAngle;
    [FieldOffset(0x0028)] public bool bEnableCollision;
    [FieldOffset(0x002C)] public float CollisionOffset;
    [FieldOffset(0x0030)] public int DrawOrder;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UPaperTerrainMaterial
{
    [FieldOffset(0x0000)] public UDataAsset baseObj;
    [FieldOffset(0x0030)] public TArray<FPaperTerrainMaterialRule> Rules;
    [FieldOffset(0x0040)] public UPaperSprite* InteriorFill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x560)] 
public unsafe struct UPaperTerrainSplineComponent
{
    [FieldOffset(0x0000)] public USplineComponent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FPaperTileInfo
{
    [FieldOffset(0x0000)] public UPaperTileSet* TileSet;
    [FieldOffset(0x0008)] public int PackedTileIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UPaperTileLayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FText LayerName;
    [FieldOffset(0x0040)] public int LayerWidth;
    [FieldOffset(0x0044)] public int LayerHeight;
    [FieldOffset(0x0048)] public byte bHiddenInGame;
    [FieldOffset(0x0048)] public byte bLayerCollides;
    [FieldOffset(0x0048)] public byte bOverrideCollisionThickness;
    [FieldOffset(0x0048)] public byte bOverrideCollisionOffset;
    [FieldOffset(0x004C)] public float CollisionThicknessOverride;
    [FieldOffset(0x0050)] public float CollisionOffsetOverride;
    [FieldOffset(0x0054)] public FLinearColor LayerColor;
    [FieldOffset(0x0064)] public int AllocatedWidth;
    [FieldOffset(0x0068)] public int AllocatedHeight;
    [FieldOffset(0x0070)] public TArray<FPaperTileInfo> AllocatedCells;
    [FieldOffset(0x0080)] public UPaperTileSet* TileSet;
    [FieldOffset(0x0088)] public TArray<int> AllocatedGrid;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UPaperTileMap
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public int MapWidth;
    [FieldOffset(0x002C)] public int MapHeight;
    [FieldOffset(0x0030)] public int TileWidth;
    [FieldOffset(0x0034)] public int TileHeight;
    [FieldOffset(0x0038)] public float PixelsPerUnrealUnit;
    [FieldOffset(0x003C)] public float SeparationPerTileX;
    [FieldOffset(0x0040)] public float SeparationPerTileY;
    [FieldOffset(0x0044)] public float SeparationPerLayer;
    [FieldOffset(0x0048)] public TSoftObjectPtr<UPaperTileSet> SelectedTileSet;
    [FieldOffset(0x0070)] public UMaterialInterface* Material;
    [FieldOffset(0x0078)] public TArray<IntPtr> TileLayers;
    [FieldOffset(0x0088)] public float CollisionThickness;
    [FieldOffset(0x008C)] public ESpriteCollisionMode SpriteCollisionDomain;
    [FieldOffset(0x008D)] public ETileMapProjectionMode ProjectionMode;
    [FieldOffset(0x0090)] public int HexSideLength;
    [FieldOffset(0x0098)] public UBodySetup* BodySetup;
    [FieldOffset(0x00A0)] public int LayerNameIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct APaperTileMapActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
    [FieldOffset(0x0220)] public UPaperTileMapComponent* RenderComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D0)] 
public unsafe struct UPaperTileMapComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public int MapWidth;
    [FieldOffset(0x047C)] public int MapHeight;
    [FieldOffset(0x0480)] public int TileWidth;
    [FieldOffset(0x0484)] public int TileHeight;
    [FieldOffset(0x0488)] public UPaperTileSet* DefaultLayerTileSet;
    [FieldOffset(0x0490)] public UMaterialInterface* Material;
    [FieldOffset(0x0498)] public TArray<IntPtr> TileLayers;
    [FieldOffset(0x04A8)] public FLinearColor TileMapColor;
    [FieldOffset(0x04B8)] public int UseSingleLayerIndex;
    [FieldOffset(0x04BC)] public bool bUseSingleLayer;
    [FieldOffset(0x04C0)] public UPaperTileMap* TileMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FIntMargin
{
    [FieldOffset(0x0000)] public int Left;
    [FieldOffset(0x0004)] public int Top;
    [FieldOffset(0x0008)] public int Right;
    [FieldOffset(0x000C)] public int Bottom;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSpriteGeometryShape
{
    [FieldOffset(0x0000)] public ESpriteShapeType ShapeType;
    [FieldOffset(0x0008)] public TArray<FVector2D> Vertices;
    [FieldOffset(0x0018)] public FVector2D BoxSize;
    [FieldOffset(0x0020)] public FVector2D BoxPosition;
    [FieldOffset(0x0028)] public float Rotation;
    [FieldOffset(0x002C)] public bool bNegativeWinding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSpriteGeometryCollection
{
    [FieldOffset(0x0000)] public TArray<FSpriteGeometryShape> Shapes;
    [FieldOffset(0x0010)] public ESpritePolygonMode GeometryType;
    [FieldOffset(0x0014)] public int PixelsPerSubdivisionX;
    [FieldOffset(0x0018)] public int PixelsPerSubdivisionY;
    [FieldOffset(0x001C)] public bool bAvoidVertexMerging;
    [FieldOffset(0x0020)] public float AlphaThreshold;
    [FieldOffset(0x0024)] public float DetailAmount;
    [FieldOffset(0x0028)] public float SimplifyEpsilon;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPaperTileMetadata
{
    [FieldOffset(0x0000)] public FName UserDataName;
    [FieldOffset(0x0008)] public FSpriteGeometryCollection CollisionData;
    [FieldOffset(0x0038)] public byte TerrainMembership;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPaperTileSetTerrain
{
    [FieldOffset(0x0000)] public FString TerrainName;
    [FieldOffset(0x0010)] public int CenterTileIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct UPaperTileSet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FIntPoint TileSize;
    [FieldOffset(0x0030)] public UTexture2D* TileSheet;
    [FieldOffset(0x0038)] public TArray<IntPtr> AdditionalSourceTextures;
    [FieldOffset(0x0048)] public FIntMargin BorderMargin;
    [FieldOffset(0x0058)] public FIntPoint PerTileSpacing;
    [FieldOffset(0x0060)] public FIntPoint DrawingOffset;
    [FieldOffset(0x0068)] public int WidthInTiles;
    [FieldOffset(0x006C)] public int HeightInTiles;
    [FieldOffset(0x0070)] public int AllocatedWidth;
    [FieldOffset(0x0074)] public int AllocatedHeight;
    [FieldOffset(0x0078)] public TArray<FPaperTileMetadata> PerTileData;
    [FieldOffset(0x0088)] public TArray<FPaperTileSetTerrain> Terrains;
    [FieldOffset(0x0098)] public int TileWidth;
    [FieldOffset(0x009C)] public int TileHeight;
    [FieldOffset(0x00A0)] public int Margin;
    [FieldOffset(0x00A4)] public int Spacing;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UTileMapBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FPaperSpriteAtlasSlot
{
    [FieldOffset(0x0000)] public TSoftObjectPtr<UPaperSprite> SpriteRef;
    [FieldOffset(0x0028)] public int AtlasIndex;
    [FieldOffset(0x002C)] public int X;
    [FieldOffset(0x0030)] public int Y;
    [FieldOffset(0x0034)] public int Width;
    [FieldOffset(0x0038)] public int Height;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FSpriteDrawCallRecord
{
    [FieldOffset(0x0000)] public FVector Destination;
    [FieldOffset(0x0010)] public UTexture* BaseTexture;
    [FieldOffset(0x0048)] public FColor Color;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FSpriteAssetInitParameters
{
}

