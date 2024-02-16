using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ControlPointMeshActor : ObjectBase<AControlPointMeshActor>
{

}

public unsafe class ControlPointMeshComponent : ObjectBase<UControlPointMeshComponent>
{

}

public unsafe class LandscapeProxy : ObjectBase<ALandscapeProxy>
{

    public void SetLandscapeMaterialVectorParameterValue(FName ParameterName, FLinearColor Value)
    {
        Span<(string name, object value)> @params = [
            ("ParameterName", ParameterName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetLandscapeMaterialVectorParameterValue"),  @params);
    }
    public void SetLandscapeMaterialTextureParameterValue(FName ParameterName, UTexture* Value)
    {
        Span<(string name, object value)> @params = [
            ("ParameterName", ParameterName), 
            ("Value", (IntPtr)Value)
        ];
        ProcessEvent(GetFunction("SetLandscapeMaterialTextureParameterValue"),  @params);
    }
    public void SetLandscapeMaterialScalarParameterValue(FName ParameterName, float Value)
    {
        Span<(string name, object value)> @params = [
            ("ParameterName", ParameterName), 
            ("Value", Value)
        ];
        ProcessEvent(GetFunction("SetLandscapeMaterialScalarParameterValue"),  @params);
    }
    public bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D* inRenderTarget, bool InExportHeightIntoRGChannel, bool InExportLandscapeProxies)
    {
        Span<(string name, object value)> @params = [
            ("inRenderTarget", (IntPtr)inRenderTarget), 
            ("InExportHeightIntoRGChannel", InExportHeightIntoRGChannel), 
            ("InExportLandscapeProxies", InExportLandscapeProxies)
        ];
        return ProcessEvent<bool>(GetFunction("LandscapeExportHeightmapToRenderTarget"),  @params);
    }
    public void EditorSetLandscapeMaterial(UMaterialInterface* NewLandscapeMaterial)
    {
        Span<(string name, object value)> @params = [
            ("NewLandscapeMaterial", (IntPtr)NewLandscapeMaterial)
        ];
        ProcessEvent(GetFunction("EditorSetLandscapeMaterial"),  @params);
    }
    public void EditorApplySpline(USplineComponent* InSplineComponent, float StartWidth, float EndWidth, float StartSideFalloff, float EndSideFalloff, float StartRoll, float EndRoll, int NumSubdivisions, bool bRaiseHeights, bool bLowerHeights, ULandscapeLayerInfoObject* PaintLayer, FName EditLayerName)
    {
        Span<(string name, object value)> @params = [
            ("InSplineComponent", (IntPtr)InSplineComponent), 
            ("StartWidth", StartWidth), 
            ("EndWidth", EndWidth), 
            ("StartSideFalloff", StartSideFalloff), 
            ("EndSideFalloff", EndSideFalloff), 
            ("StartRoll", StartRoll), 
            ("EndRoll", EndRoll), 
            ("NumSubdivisions", NumSubdivisions), 
            ("bRaiseHeights", bRaiseHeights), 
            ("bLowerHeights", bLowerHeights), 
            ("PaintLayer", (IntPtr)PaintLayer), 
            ("EditLayerName", EditLayerName)
        ];
        ProcessEvent(GetFunction("EditorApplySpline"),  @params);
    }
    public void ChangeUseTessellationComponentScreenSizeFalloff(bool InComponentScreenSizeToUseSubSections)
    {
        Span<(string name, object value)> @params = [
            ("InComponentScreenSizeToUseSubSections", InComponentScreenSizeToUseSubSections)
        ];
        ProcessEvent(GetFunction("ChangeUseTessellationComponentScreenSizeFalloff"),  @params);
    }
    public void ChangeTessellationComponentScreenSizeFalloff(float InUseTessellationComponentScreenSizeFalloff)
    {
        Span<(string name, object value)> @params = [
            ("InUseTessellationComponentScreenSizeFalloff", InUseTessellationComponentScreenSizeFalloff)
        ];
        ProcessEvent(GetFunction("ChangeTessellationComponentScreenSizeFalloff"),  @params);
    }
    public void ChangeTessellationComponentScreenSize(float InTessellationComponentScreenSize)
    {
        Span<(string name, object value)> @params = [
            ("InTessellationComponentScreenSize", InTessellationComponentScreenSize)
        ];
        ProcessEvent(GetFunction("ChangeTessellationComponentScreenSize"),  @params);
    }
    public void ChangeLODDistanceFactor(float InLODDistanceFactor)
    {
        Span<(string name, object value)> @params = [
            ("InLODDistanceFactor", InLODDistanceFactor)
        ];
        ProcessEvent(GetFunction("ChangeLODDistanceFactor"),  @params);
    }
    public void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)
    {
        Span<(string name, object value)> @params = [
            ("InComponentScreenSizeToUseSubSections", InComponentScreenSizeToUseSubSections)
        ];
        ProcessEvent(GetFunction("ChangeComponentScreenSizeToUseSubSections"),  @params);
    }
}

public unsafe class Landscape : ObjectBase<ALandscape>
{
}

public unsafe class LandscapeBlueprintBrushBase : ObjectBase<ALandscapeBlueprintBrushBase>
{

    public void RequestLandscapeUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestLandscapeUpdate"),  @params);
    }
    public UTextureRenderTarget2D* Render(bool InIsHeightmap, UTextureRenderTarget2D* InCombinedResult, ref FName InWeightmapLayerName)
    {
        Span<(string name, object value)> @params = [
            ("InIsHeightmap", InIsHeightmap), 
            ("InCombinedResult", (IntPtr)InCombinedResult), 
            ("InWeightmapLayerName", InWeightmapLayerName)
        ];
        return (UTextureRenderTarget2D*)ProcessEvent<IntPtr>(GetFunction("Render"),  @params);
    }
    public void Initialize(ref FTransform InLandscapeTransform, ref FIntPoint InLandscapeSize, ref FIntPoint InLandscapeRenderTargetSize)
    {
        Span<(string name, object value)> @params = [
            ("InLandscapeTransform", InLandscapeTransform), 
            ("InLandscapeSize", InLandscapeSize), 
            ("InLandscapeRenderTargetSize", InLandscapeRenderTargetSize)
        ];
        ProcessEvent(GetFunction("Initialize"),  @params);
    }
    public void GetBlueprintRenderDependencies(ref TArray<IntPtr> OutStreamableAssets)
    {
        Span<(string name, object value)> @params = [
            ("OutStreamableAssets", OutStreamableAssets)
        ];
        ProcessEvent(GetFunction("GetBlueprintRenderDependencies"),  @params);
    }
}

public unsafe class LandscapeLODStreamingProxy : ObjectBase<ULandscapeLODStreamingProxy>
{
}

public unsafe class LandscapeComponent : ObjectBase<ULandscapeComponent>
{

    public UMaterialInstanceDynamic* GetMaterialInstanceDynamic(int InIndex)
    {
        Span<(string name, object value)> @params = [
            ("InIndex", InIndex)
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetMaterialInstanceDynamic"),  @params);
    }
    public float EditorGetPaintLayerWeightByNameAtLocation(ref FVector InLocation, FName InPaintLayerName)
    {
        Span<(string name, object value)> @params = [
            ("InLocation", InLocation), 
            ("InPaintLayerName", InPaintLayerName)
        ];
        return ProcessEvent<float>(GetFunction("EditorGetPaintLayerWeightByNameAtLocation"),  @params);
    }
    public float EditorGetPaintLayerWeightAtLocation(ref FVector InLocation, ULandscapeLayerInfoObject* PaintLayer)
    {
        Span<(string name, object value)> @params = [
            ("InLocation", InLocation), 
            ("PaintLayer", (IntPtr)PaintLayer)
        ];
        return ProcessEvent<float>(GetFunction("EditorGetPaintLayerWeightAtLocation"),  @params);
    }
}

public unsafe class LandscapeGizmoActor : ObjectBase<ALandscapeGizmoActor>
{
}

public unsafe class LandscapeGizmoActiveActor : ObjectBase<ALandscapeGizmoActiveActor>
{
}

public unsafe class LandscapeGizmoRenderComponent : ObjectBase<ULandscapeGizmoRenderComponent>
{
}

public unsafe class LandscapeGrassType : ObjectBase<ULandscapeGrassType>
{

}

public unsafe class LandscapeHeightfieldCollisionComponent : ObjectBase<ULandscapeHeightfieldCollisionComponent>
{

    public ULandscapeComponent* GetRenderComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULandscapeComponent*)ProcessEvent<IntPtr>(GetFunction("GetRenderComponent"),  @params);
    }
}

public unsafe class LandscapeInfo : ObjectBase<ULandscapeInfo>
{

}

public unsafe class LandscapeInfoMap : ObjectBase<ULandscapeInfoMap>
{
}

public unsafe class LandscapeLayerInfoObject : ObjectBase<ULandscapeLayerInfoObject>
{

}

public unsafe class LandscapeMaterialInstanceConstant : ObjectBase<ULandscapeMaterialInstanceConstant>
{

}

public unsafe class LandscapeMeshCollisionComponent : ObjectBase<ULandscapeMeshCollisionComponent>
{

}

public unsafe class LandscapeMeshProxyActor : ObjectBase<ALandscapeMeshProxyActor>
{

}

public unsafe class LandscapeMeshProxyComponent : ObjectBase<ULandscapeMeshProxyComponent>
{

}

public unsafe class LandscapeSettings : ObjectBase<ULandscapeSettings>
{

}

public unsafe class LandscapeSplinesComponent : ObjectBase<ULandscapeSplinesComponent>
{

    public TArray<IntPtr> GetSplineMeshComponents()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetSplineMeshComponents"),  @params);
    }
}

public unsafe class LandscapeSplineControlPoint : ObjectBase<ULandscapeSplineControlPoint>
{

}

public unsafe class LandscapeSplineSegment : ObjectBase<ULandscapeSplineSegment>
{

}

public unsafe class LandscapeStreamingProxy : ObjectBase<ALandscapeStreamingProxy>
{

}

public unsafe class LandscapeSubsystem : ObjectBase<ULandscapeSubsystem>
{
}

public unsafe class LandscapeWeightmapUsage : ObjectBase<ULandscapeWeightmapUsage>
{

}

public unsafe class MaterialExpressionLandscapeGrassOutput : ObjectBase<UMaterialExpressionLandscapeGrassOutput>
{

}

public unsafe class MaterialExpressionLandscapeLayerBlend : ObjectBase<UMaterialExpressionLandscapeLayerBlend>
{

}

public unsafe class MaterialExpressionLandscapeLayerCoords : ObjectBase<UMaterialExpressionLandscapeLayerCoords>
{

}

public unsafe class MaterialExpressionLandscapeLayerSample : ObjectBase<UMaterialExpressionLandscapeLayerSample>
{

}

public unsafe class MaterialExpressionLandscapeLayerSwitch : ObjectBase<UMaterialExpressionLandscapeLayerSwitch>
{

}

public unsafe class MaterialExpressionLandscapeLayerWeight : ObjectBase<UMaterialExpressionLandscapeLayerWeight>
{

}

public unsafe class MaterialExpressionLandscapePhysicalMaterialOutput : ObjectBase<UMaterialExpressionLandscapePhysicalMaterialOutput>
{

}

public unsafe class MaterialExpressionLandscapeVisibilityMask : ObjectBase<UMaterialExpressionLandscapeVisibilityMask>
{

}

public unsafe class LandscapeLayer : ObjectBase<FLandscapeLayer>
{

}

public unsafe class LandscapeLayerBrush : ObjectBase<FLandscapeLayerBrush>
{
}

public unsafe class LandscapeLayerComponentData : ObjectBase<FLandscapeLayerComponentData>
{

}

public unsafe class WeightmapData : ObjectBase<FWeightmapData>
{

}

public unsafe class WeightmapLayerAllocationInfo : ObjectBase<FWeightmapLayerAllocationInfo>
{

}

public unsafe class HeightmapData : ObjectBase<FHeightmapData>
{

}

public unsafe class LandscapeComponentMaterialOverride : ObjectBase<FLandscapeComponentMaterialOverride>
{

}

public unsafe class LandscapeEditToolRenderData : ObjectBase<FLandscapeEditToolRenderData>
{

}

public unsafe class GizmoSelectData : ObjectBase<FGizmoSelectData>
{
}

public unsafe class GrassVariety : ObjectBase<FGrassVariety>
{

}

public unsafe class LandscapeInfoLayerSettings : ObjectBase<FLandscapeInfoLayerSettings>
{

}

public unsafe class LandscapeMaterialTextureStreamingInfo : ObjectBase<FLandscapeMaterialTextureStreamingInfo>
{

}

public unsafe class LandscapeProxyMaterialOverride : ObjectBase<FLandscapeProxyMaterialOverride>
{

}

public unsafe class LandscapeImportLayerInfo : ObjectBase<FLandscapeImportLayerInfo>
{
}

public unsafe class LandscapeLayerStruct : ObjectBase<FLandscapeLayerStruct>
{

}

public unsafe class LandscapeEditorLayerSettings : ObjectBase<FLandscapeEditorLayerSettings>
{
}

public unsafe class LandscapeSplineConnection : ObjectBase<FLandscapeSplineConnection>
{

}

public unsafe class ForeignWorldSplineData : ObjectBase<FForeignWorldSplineData>
{
}

public unsafe class ForeignSplineSegmentData : ObjectBase<FForeignSplineSegmentData>
{
}

public unsafe class ForeignControlPointData : ObjectBase<FForeignControlPointData>
{
}

public unsafe class LandscapeSplineMeshEntry : ObjectBase<FLandscapeSplineMeshEntry>
{

}

public unsafe class LandscapeSplineSegmentConnection : ObjectBase<FLandscapeSplineSegmentConnection>
{

}

public unsafe class LandscapeSplineInterpPoint : ObjectBase<FLandscapeSplineInterpPoint>
{

}

public unsafe class GrassInput : ObjectBase<FGrassInput>
{

}

public unsafe class LayerBlendInput : ObjectBase<FLayerBlendInput>
{

}

public unsafe class PhysicalMaterialInput : ObjectBase<FPhysicalMaterialInput>
{

}

