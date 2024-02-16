using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MaterialExpressionSpriteTextureSampler : ObjectBase<UMaterialExpressionSpriteTextureSampler>
{

}

public unsafe class PaperCharacter : ObjectBase<APaperCharacter>
{

}

public unsafe class PaperFlipbook : ObjectBase<UPaperFlipbook>
{

    public bool IsValidKeyFrameIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidKeyFrameIndex"),  @params);
    }
    public float GetTotalDuration()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetTotalDuration"),  @params);
    }
    public UPaperSprite* GetSpriteAtTime(float Time, bool bClampToEnds)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time), 
            ("bClampToEnds", bClampToEnds)
        ];
        return (UPaperSprite*)ProcessEvent<IntPtr>(GetFunction("GetSpriteAtTime"),  @params);
    }
    public UPaperSprite* GetSpriteAtFrame(int FrameIndex)
    {
        Span<(string name, object value)> @params = [
            ("FrameIndex", FrameIndex)
        ];
        return (UPaperSprite*)ProcessEvent<IntPtr>(GetFunction("GetSpriteAtFrame"),  @params);
    }
    public int GetNumKeyFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumKeyFrames"),  @params);
    }
    public int GetNumFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumFrames"),  @params);
    }
    public int GetKeyFrameIndexAtTime(float Time, bool bClampToEnds)
    {
        Span<(string name, object value)> @params = [
            ("Time", Time), 
            ("bClampToEnds", bClampToEnds)
        ];
        return ProcessEvent<int>(GetFunction("GetKeyFrameIndexAtTime"),  @params);
    }
}

public unsafe class PaperFlipbookActor : ObjectBase<APaperFlipbookActor>
{

}

public unsafe class PaperFlipbookComponent : ObjectBase<UPaperFlipbookComponent>
{

    public void Stop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Stop"),  @params);
    }
    public void SetSpriteColor(FLinearColor NewColor)
    {
        Span<(string name, object value)> @params = [
            ("NewColor", NewColor)
        ];
        ProcessEvent(GetFunction("SetSpriteColor"),  @params);
    }
    public void SetPlayRate(float NewRate)
    {
        Span<(string name, object value)> @params = [
            ("NewRate", NewRate)
        ];
        ProcessEvent(GetFunction("SetPlayRate"),  @params);
    }
    public void SetPlaybackPositionInFrames(int NewFramePosition, bool bFireEvents)
    {
        Span<(string name, object value)> @params = [
            ("NewFramePosition", NewFramePosition), 
            ("bFireEvents", bFireEvents)
        ];
        ProcessEvent(GetFunction("SetPlaybackPositionInFrames"),  @params);
    }
    public void SetPlaybackPosition(float NewPosition, bool bFireEvents)
    {
        Span<(string name, object value)> @params = [
            ("NewPosition", NewPosition), 
            ("bFireEvents", bFireEvents)
        ];
        ProcessEvent(GetFunction("SetPlaybackPosition"),  @params);
    }
    public void SetNewTime(float NewTime)
    {
        Span<(string name, object value)> @params = [
            ("NewTime", NewTime)
        ];
        ProcessEvent(GetFunction("SetNewTime"),  @params);
    }
    public void SetLooping(bool bNewLooping)
    {
        Span<(string name, object value)> @params = [
            ("bNewLooping", bNewLooping)
        ];
        ProcessEvent(GetFunction("SetLooping"),  @params);
    }
    public bool SetFlipbook(UPaperFlipbook* NewFlipbook)
    {
        Span<(string name, object value)> @params = [
            ("NewFlipbook", (IntPtr)NewFlipbook)
        ];
        return ProcessEvent<bool>(GetFunction("SetFlipbook"),  @params);
    }
    public void ReverseFromEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ReverseFromEnd"),  @params);
    }
    public void Reverse()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Reverse"),  @params);
    }
    public void PlayFromStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PlayFromStart"),  @params);
    }
    public void Play()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Play"),  @params);
    }
    public void OnRep_SourceFlipbook(UPaperFlipbook* OldFlipbook)
    {
        Span<(string name, object value)> @params = [
            ("OldFlipbook", (IntPtr)OldFlipbook)
        ];
        ProcessEvent(GetFunction("OnRep_SourceFlipbook"),  @params);
    }
    public bool IsReversing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReversing"),  @params);
    }
    public bool IsPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlaying"),  @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"),  @params);
    }
    public FLinearColor GetSpriteColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetSpriteColor"),  @params);
    }
    public float GetPlayRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlayRate"),  @params);
    }
    public int GetPlaybackPositionInFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPlaybackPositionInFrames"),  @params);
    }
    public float GetPlaybackPosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetPlaybackPosition"),  @params);
    }
    public int GetFlipbookLengthInFrames()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetFlipbookLengthInFrames"),  @params);
    }
    public float GetFlipbookLength()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFlipbookLength"),  @params);
    }
    public float GetFlipbookFramerate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFlipbookFramerate"),  @params);
    }
    public UPaperFlipbook* GetFlipbook()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPaperFlipbook*)ProcessEvent<IntPtr>(GetFunction("GetFlipbook"),  @params);
    }
}

public unsafe class PaperGroupedSpriteActor : ObjectBase<APaperGroupedSpriteActor>
{

}

public unsafe class PaperGroupedSpriteComponent : ObjectBase<UPaperGroupedSpriteComponent>
{

    public bool UpdateInstanceTransform(int InstanceIndex, ref FTransform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)
    {
        Span<(string name, object value)> @params = [
            ("InstanceIndex", InstanceIndex), 
            ("NewInstanceTransform", NewInstanceTransform), 
            ("bWorldSpace", bWorldSpace), 
            ("bMarkRenderStateDirty", bMarkRenderStateDirty), 
            ("bTeleport", bTeleport)
        ];
        return ProcessEvent<bool>(GetFunction("UpdateInstanceTransform"),  @params);
    }
    public bool UpdateInstanceColor(int InstanceIndex, FLinearColor NewInstanceColor, bool bMarkRenderStateDirty)
    {
        Span<(string name, object value)> @params = [
            ("InstanceIndex", InstanceIndex), 
            ("NewInstanceColor", NewInstanceColor), 
            ("bMarkRenderStateDirty", bMarkRenderStateDirty)
        ];
        return ProcessEvent<bool>(GetFunction("UpdateInstanceColor"),  @params);
    }
    public void SortInstancesAlongAxis(FVector WorldSpaceSortAxis)
    {
        Span<(string name, object value)> @params = [
            ("WorldSpaceSortAxis", WorldSpaceSortAxis)
        ];
        ProcessEvent(GetFunction("SortInstancesAlongAxis"),  @params);
    }
    public bool RemoveInstance(int InstanceIndex)
    {
        Span<(string name, object value)> @params = [
            ("InstanceIndex", InstanceIndex)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveInstance"),  @params);
    }
    public bool GetInstanceTransform(int InstanceIndex, ref FTransform OutInstanceTransform, bool bWorldSpace)
    {
        Span<(string name, object value)> @params = [
            ("InstanceIndex", InstanceIndex), 
            ("OutInstanceTransform", OutInstanceTransform), 
            ("bWorldSpace", bWorldSpace)
        ];
        return ProcessEvent<bool>(GetFunction("GetInstanceTransform"),  @params);
    }
    public int GetInstanceCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetInstanceCount"),  @params);
    }
    public void ClearInstances()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearInstances"),  @params);
    }
    public int AddInstance(ref FTransform Transform, UPaperSprite* Sprite, bool bWorldSpace, FLinearColor Color)
    {
        Span<(string name, object value)> @params = [
            ("Transform", Transform), 
            ("Sprite", (IntPtr)Sprite), 
            ("bWorldSpace", bWorldSpace), 
            ("Color", Color)
        ];
        return ProcessEvent<int>(GetFunction("AddInstance"),  @params);
    }
}

public unsafe class PaperRuntimeSettings : ObjectBase<UPaperRuntimeSettings>
{

}

public unsafe class PaperSprite : ObjectBase<UPaperSprite>
{

}

public unsafe class PaperSpriteActor : ObjectBase<APaperSpriteActor>
{

}

public unsafe class PaperSpriteAtlas : ObjectBase<UPaperSpriteAtlas>
{
}

public unsafe class PaperSpriteBlueprintLibrary : ObjectBase<UPaperSpriteBlueprintLibrary>
{

    public FSlateBrush MakeBrushFromSprite(UPaperSprite* Sprite, int Width, int Height)
    {
        Span<(string name, object value)> @params = [
            ("Sprite", (IntPtr)Sprite), 
            ("Width", Width), 
            ("Height", Height)
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("MakeBrushFromSprite"),  @params);
    }
}

public unsafe class PaperSpriteComponent : ObjectBase<UPaperSpriteComponent>
{

    public void SetSpriteColor(FLinearColor NewColor)
    {
        Span<(string name, object value)> @params = [
            ("NewColor", NewColor)
        ];
        ProcessEvent(GetFunction("SetSpriteColor"),  @params);
    }
    public bool SetSprite(UPaperSprite* NewSprite)
    {
        Span<(string name, object value)> @params = [
            ("NewSprite", (IntPtr)NewSprite)
        ];
        return ProcessEvent<bool>(GetFunction("SetSprite"),  @params);
    }
    public UPaperSprite* GetSprite()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPaperSprite*)ProcessEvent<IntPtr>(GetFunction("GetSprite"),  @params);
    }
}

public unsafe class PaperTerrainActor : ObjectBase<APaperTerrainActor>
{

}

public unsafe class PaperTerrainComponent : ObjectBase<UPaperTerrainComponent>
{

    public void SetTerrainColor(FLinearColor NewColor)
    {
        Span<(string name, object value)> @params = [
            ("NewColor", NewColor)
        ];
        ProcessEvent(GetFunction("SetTerrainColor"),  @params);
    }
}

public unsafe class PaperTerrainMaterial : ObjectBase<UPaperTerrainMaterial>
{

}

public unsafe class PaperTerrainSplineComponent : ObjectBase<UPaperTerrainSplineComponent>
{
}

public unsafe class PaperTileLayer : ObjectBase<UPaperTileLayer>
{

}

public unsafe class PaperTileMap : ObjectBase<UPaperTileMap>
{

}

public unsafe class PaperTileMapActor : ObjectBase<APaperTileMapActor>
{

}

public unsafe class PaperTileInfo : ObjectBase<FPaperTileInfo>
{

}

public unsafe class PaperTileMapComponent : ObjectBase<UPaperTileMapComponent>
{

    public void SetTileMapColor(FLinearColor NewColor)
    {
        Span<(string name, object value)> @params = [
            ("NewColor", NewColor)
        ];
        ProcessEvent(GetFunction("SetTileMapColor"),  @params);
    }
    public bool SetTileMap(UPaperTileMap* NewTileMap)
    {
        Span<(string name, object value)> @params = [
            ("NewTileMap", (IntPtr)NewTileMap)
        ];
        return ProcessEvent<bool>(GetFunction("SetTileMap"),  @params);
    }
    public void SetTile(int X, int Y, int Layer, FPaperTileInfo NewValue)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Layer", Layer), 
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetTile"),  @params);
    }
    public void SetLayerColor(FLinearColor NewColor, int Layer)
    {
        Span<(string name, object value)> @params = [
            ("NewColor", NewColor), 
            ("Layer", Layer)
        ];
        ProcessEvent(GetFunction("SetLayerColor"),  @params);
    }
    public void SetLayerCollision(int Layer, bool bHasCollision, bool bOverrideThickness, float CustomThickness, bool bOverrideOffset, float CustomOffset, bool bRebuildCollision)
    {
        Span<(string name, object value)> @params = [
            ("Layer", Layer), 
            ("bHasCollision", bHasCollision), 
            ("bOverrideThickness", bOverrideThickness), 
            ("CustomThickness", CustomThickness), 
            ("bOverrideOffset", bOverrideOffset), 
            ("CustomOffset", CustomOffset), 
            ("bRebuildCollision", bRebuildCollision)
        ];
        ProcessEvent(GetFunction("SetLayerCollision"),  @params);
    }
    public void SetDefaultCollisionThickness(float Thickness, bool bRebuildCollision)
    {
        Span<(string name, object value)> @params = [
            ("Thickness", Thickness), 
            ("bRebuildCollision", bRebuildCollision)
        ];
        ProcessEvent(GetFunction("SetDefaultCollisionThickness"),  @params);
    }
    public void ResizeMap(int NewWidthInTiles, int NewHeightInTiles)
    {
        Span<(string name, object value)> @params = [
            ("NewWidthInTiles", NewWidthInTiles), 
            ("NewHeightInTiles", NewHeightInTiles)
        ];
        ProcessEvent(GetFunction("ResizeMap"),  @params);
    }
    public void RebuildCollision()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RebuildCollision"),  @params);
    }
    public bool OwnsTileMap()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OwnsTileMap"),  @params);
    }
    public void MakeTileMapEditable()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("MakeTileMapEditable"),  @params);
    }
    public void GetTilePolygon(int TileX, int TileY, ref TArray<FVector> Points, int LayerIndex, bool bWorldSpace)
    {
        Span<(string name, object value)> @params = [
            ("TileX", TileX), 
            ("TileY", TileY), 
            ("Points", Points), 
            ("LayerIndex", LayerIndex), 
            ("bWorldSpace", bWorldSpace)
        ];
        ProcessEvent(GetFunction("GetTilePolygon"),  @params);
    }
    public FLinearColor GetTileMapColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetTileMapColor"),  @params);
    }
    public FVector GetTileCornerPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace)
    {
        Span<(string name, object value)> @params = [
            ("TileX", TileX), 
            ("TileY", TileY), 
            ("LayerIndex", LayerIndex), 
            ("bWorldSpace", bWorldSpace)
        ];
        return ProcessEvent<FVector>(GetFunction("GetTileCornerPosition"),  @params);
    }
    public FVector GetTileCenterPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace)
    {
        Span<(string name, object value)> @params = [
            ("TileX", TileX), 
            ("TileY", TileY), 
            ("LayerIndex", LayerIndex), 
            ("bWorldSpace", bWorldSpace)
        ];
        return ProcessEvent<FVector>(GetFunction("GetTileCenterPosition"),  @params);
    }
    public FPaperTileInfo GetTile(int X, int Y, int Layer)
    {
        Span<(string name, object value)> @params = [
            ("X", X), 
            ("Y", Y), 
            ("Layer", Layer)
        ];
        return ProcessEvent<FPaperTileInfo>(GetFunction("GetTile"),  @params);
    }
    public void GetMapSize(ref int MapWidth, ref int MapHeight, ref int NumLayers)
    {
        Span<(string name, object value)> @params = [
            ("MapWidth", MapWidth), 
            ("MapHeight", MapHeight), 
            ("NumLayers", NumLayers)
        ];
        ProcessEvent(GetFunction("GetMapSize"),  @params);
    }
    public FLinearColor GetLayerColor(int Layer)
    {
        Span<(string name, object value)> @params = [
            ("Layer", Layer)
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetLayerColor"),  @params);
    }
    public void CreateNewTileMap(int MapWidth, int MapHeight, int TileWidth, int TileHeight, float PixelsPerUnrealUnit, bool bCreateLayer)
    {
        Span<(string name, object value)> @params = [
            ("MapWidth", MapWidth), 
            ("MapHeight", MapHeight), 
            ("TileWidth", TileWidth), 
            ("TileHeight", TileHeight), 
            ("PixelsPerUnrealUnit", PixelsPerUnrealUnit), 
            ("bCreateLayer", bCreateLayer)
        ];
        ProcessEvent(GetFunction("CreateNewTileMap"),  @params);
    }
    public UPaperTileLayer* AddNewLayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPaperTileLayer*)ProcessEvent<IntPtr>(GetFunction("AddNewLayer"),  @params);
    }
}

public unsafe class PaperTileSet : ObjectBase<UPaperTileSet>
{

}

public unsafe class TileMapBlueprintLibrary : ObjectBase<UTileMapBlueprintLibrary>
{

    public FPaperTileInfo MakeTile(int TileIndex, UPaperTileSet* TileSet, bool bFlipH, bool bFlipV, bool bFlipD)
    {
        Span<(string name, object value)> @params = [
            ("TileIndex", TileIndex), 
            ("TileSet", (IntPtr)TileSet), 
            ("bFlipH", bFlipH), 
            ("bFlipV", bFlipV), 
            ("bFlipD", bFlipD)
        ];
        return ProcessEvent<FPaperTileInfo>(GetFunction("MakeTile"),  @params);
    }
    public FName GetTileUserData(FPaperTileInfo Tile)
    {
        Span<(string name, object value)> @params = [
            ("Tile", Tile)
        ];
        return ProcessEvent<FName>(GetFunction("GetTileUserData"),  @params);
    }
    public FTransform GetTileTransform(FPaperTileInfo Tile)
    {
        Span<(string name, object value)> @params = [
            ("Tile", Tile)
        ];
        return ProcessEvent<FTransform>(GetFunction("GetTileTransform"),  @params);
    }
    public void BreakTile(FPaperTileInfo Tile, ref int TileIndex, ref UPaperTileSet* TileSet, ref bool bFlipH, ref bool bFlipV, ref bool bFlipD)
    {
        Span<(string name, object value)> @params = [
            ("Tile", Tile), 
            ("TileIndex", TileIndex), 
            ("TileSet", (IntPtr)TileSet), 
            ("bFlipH", bFlipH), 
            ("bFlipV", bFlipV), 
            ("bFlipD", bFlipD)
        ];
        ProcessEvent(GetFunction("BreakTile"),  @params);
    }
}

public unsafe class IntMargin : ObjectBase<FIntMargin>
{

}

public unsafe class PaperFlipbookKeyFrame : ObjectBase<FPaperFlipbookKeyFrame>
{

}

public unsafe class SpriteInstanceData : ObjectBase<FSpriteInstanceData>
{

}

public unsafe class PaperSpriteSocket : ObjectBase<FPaperSpriteSocket>
{

}

public unsafe class PaperSpriteAtlasSlot : ObjectBase<FPaperSpriteAtlasSlot>
{

}

public unsafe class PaperTerrainMaterialRule : ObjectBase<FPaperTerrainMaterialRule>
{

}

public unsafe class PaperTileSetTerrain : ObjectBase<FPaperTileSetTerrain>
{

}

public unsafe class PaperTileMetadata : ObjectBase<FPaperTileMetadata>
{

}

public unsafe class SpriteGeometryCollection : ObjectBase<FSpriteGeometryCollection>
{

}

public unsafe class SpriteGeometryShape : ObjectBase<FSpriteGeometryShape>
{

}

public unsafe class SpriteDrawCallRecord : ObjectBase<FSpriteDrawCallRecord>
{

}

public unsafe class SpriteAssetInitParameters : ObjectBase<FSpriteAssetInitParameters>
{
}

