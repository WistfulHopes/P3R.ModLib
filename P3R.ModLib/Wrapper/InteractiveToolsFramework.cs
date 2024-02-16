using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class InputBehavior : ObjectBase<UInputBehavior>
{
}

public unsafe class AnyButtonInputBehavior : ObjectBase<UAnyButtonInputBehavior>
{
}

public unsafe class InteractiveGizmoBuilder : ObjectBase<UInteractiveGizmoBuilder>
{
}

public unsafe class AxisAngleGizmoBuilder : ObjectBase<UAxisAngleGizmoBuilder>
{
}

public unsafe class InteractiveGizmo : ObjectBase<UInteractiveGizmo>
{

}

public unsafe class AxisAngleGizmo : ObjectBase<UAxisAngleGizmo>
{

}

public unsafe class AxisPositionGizmoBuilder : ObjectBase<UAxisPositionGizmoBuilder>
{
}

public unsafe class AxisPositionGizmo : ObjectBase<UAxisPositionGizmo>
{

}

public unsafe class GizmoConstantAxisSource : ObjectBase<UGizmoConstantAxisSource>
{

}

public unsafe class GizmoConstantFrameAxisSource : ObjectBase<UGizmoConstantFrameAxisSource>
{

}

public unsafe class GizmoWorldAxisSource : ObjectBase<UGizmoWorldAxisSource>
{

}

public unsafe class GizmoComponentAxisSource : ObjectBase<UGizmoComponentAxisSource>
{

}

public unsafe class InteractiveToolPropertySet : ObjectBase<UInteractiveToolPropertySet>
{

}

public unsafe class BrushBaseProperties : ObjectBase<UBrushBaseProperties>
{

}

public unsafe class InteractiveTool : ObjectBase<UInteractiveTool>
{

}

public unsafe class SingleSelectionTool : ObjectBase<USingleSelectionTool>
{
}

public unsafe class MeshSurfacePointTool : ObjectBase<UMeshSurfacePointTool>
{
}

public unsafe class BaseBrushTool : ObjectBase<UBaseBrushTool>
{

}

public unsafe class BrushStampIndicatorBuilder : ObjectBase<UBrushStampIndicatorBuilder>
{
}

public unsafe class BrushStampIndicator : ObjectBase<UBrushStampIndicator>
{

}

public unsafe class ClickDragInputBehavior : ObjectBase<UClickDragInputBehavior>
{

}

public unsafe class LocalClickDragInputBehavior : ObjectBase<ULocalClickDragInputBehavior>
{
}

public unsafe class InteractiveToolBuilder : ObjectBase<UInteractiveToolBuilder>
{
}

public unsafe class ClickDragToolBuilder : ObjectBase<UClickDragToolBuilder>
{
}

public unsafe class ClickDragTool : ObjectBase<UClickDragTool>
{
}

public unsafe class InternalToolFrameworkActor : ObjectBase<AInternalToolFrameworkActor>
{
}

public unsafe class GizmoActor : ObjectBase<AGizmoActor>
{
}

public unsafe class GizmoBaseComponent : ObjectBase<UGizmoBaseComponent>
{

    public void UpdateWorldLocalState(bool bWorldIn)
    {
        Span<(string name, object value)> @params = [
            ("bWorldIn", bWorldIn)
        ];
        ProcessEvent(GetFunction("UpdateWorldLocalState"),  @params);
    }
    public void UpdateHoverState(bool bHoveringIn)
    {
        Span<(string name, object value)> @params = [
            ("bHoveringIn", bHoveringIn)
        ];
        ProcessEvent(GetFunction("UpdateHoverState"),  @params);
    }
}

public unsafe class GizmoArrowComponent : ObjectBase<UGizmoArrowComponent>
{

}

public unsafe class GizmoBoxComponent : ObjectBase<UGizmoBoxComponent>
{

}

public unsafe class GizmoCircleComponent : ObjectBase<UGizmoCircleComponent>
{

}

public unsafe class GizmoTransformSource : ObjectBase<IGizmoTransformSource>
{

    public void SetTransform(ref FTransform NewTransform)
    {
        Span<(string name, object value)> @params = [
            ("NewTransform", NewTransform)
        ];
        ProcessEvent(GetFunction("SetTransform"),  @params);
    }
    public FTransform GetTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetTransform"),  @params);
    }
}

public unsafe class GizmoAxisSource : ObjectBase<IGizmoAxisSource>
{

    public bool HasTangentVectors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasTangentVectors"),  @params);
    }
    public void GetTangentVectors(ref FVector TangentXOut, ref FVector TangentYOut)
    {
        Span<(string name, object value)> @params = [
            ("TangentXOut", TangentXOut), 
            ("TangentYOut", TangentYOut)
        ];
        ProcessEvent(GetFunction("GetTangentVectors"),  @params);
    }
    public FVector GetOrigin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetOrigin"),  @params);
    }
    public FVector GetDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetDirection"),  @params);
    }
}

public unsafe class GizmoClickTarget : ObjectBase<IGizmoClickTarget>
{

    public void UpdateHoverState(bool bHovering)
    {
        Span<(string name, object value)> @params = [
            ("bHovering", bHovering)
        ];
        ProcessEvent(GetFunction("UpdateHoverState"),  @params);
    }
}

public unsafe class GizmoStateTarget : ObjectBase<IGizmoStateTarget>
{

    public void EndUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndUpdate"),  @params);
    }
    public void BeginUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginUpdate"),  @params);
    }
}

public unsafe class GizmoFloatParameterSource : ObjectBase<IGizmoFloatParameterSource>
{

    public void SetParameter(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetParameter"),  @params);
    }
    public float GetParameter()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetParameter"),  @params);
    }
    public void EndModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndModify"),  @params);
    }
    public void BeginModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginModify"),  @params);
    }
}

public unsafe class GizmoVec2ParameterSource : ObjectBase<IGizmoVec2ParameterSource>
{

    public void SetParameter(ref FVector2D NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetParameter"),  @params);
    }
    public FVector2D GetParameter()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetParameter"),  @params);
    }
    public void EndModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndModify"),  @params);
    }
    public void BeginModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginModify"),  @params);
    }
}

public unsafe class GizmoLineHandleComponent : ObjectBase<UGizmoLineHandleComponent>
{

}

public unsafe class GizmoRectangleComponent : ObjectBase<UGizmoRectangleComponent>
{

}

public unsafe class GizmoLambdaHitTarget : ObjectBase<UGizmoLambdaHitTarget>
{
}

public unsafe class GizmoComponentHitTarget : ObjectBase<UGizmoComponentHitTarget>
{

}

public unsafe class InputBehaviorSet : ObjectBase<UInputBehaviorSet>
{

}

public unsafe class InputBehaviorSource : ObjectBase<IInputBehaviorSource>
{
}

public unsafe class InputRouter : ObjectBase<UInputRouter>
{

}

public unsafe class InteractionMechanic : ObjectBase<UInteractionMechanic>
{
}

public unsafe class InteractiveGizmoManager : ObjectBase<UInteractiveGizmoManager>
{

}

public unsafe class ToolContextTransactionProvider : ObjectBase<IToolContextTransactionProvider>
{
}

public unsafe class InteractiveToolManager : ObjectBase<UInteractiveToolManager>
{

}

public unsafe class ToolFrameworkComponent : ObjectBase<IToolFrameworkComponent>
{
}

public unsafe class InteractiveToolsContext : ObjectBase<UInteractiveToolsContext>
{

}

public unsafe class IntervalGizmoActor : ObjectBase<AIntervalGizmoActor>
{

}

public unsafe class IntervalGizmoBuilder : ObjectBase<UIntervalGizmoBuilder>
{
}

public unsafe class IntervalGizmo : ObjectBase<UIntervalGizmo>
{

}

public unsafe class GizmoBaseFloatParameterSource : ObjectBase<UGizmoBaseFloatParameterSource>
{
}

public unsafe class GizmoAxisIntervalParameterSource : ObjectBase<UGizmoAxisIntervalParameterSource>
{

}

public unsafe class KeyAsModifierInputBehavior : ObjectBase<UKeyAsModifierInputBehavior>
{
}

public unsafe class MeshSurfacePointToolBuilder : ObjectBase<UMeshSurfacePointToolBuilder>
{
}

public unsafe class MouseHoverBehavior : ObjectBase<UMouseHoverBehavior>
{
}

public unsafe class MultiClickSequenceInputBehavior : ObjectBase<UMultiClickSequenceInputBehavior>
{
}

public unsafe class MultiSelectionTool : ObjectBase<UMultiSelectionTool>
{
}

public unsafe class GizmoLocalFloatParameterSource : ObjectBase<UGizmoLocalFloatParameterSource>
{

}

public unsafe class GizmoBaseVec2ParameterSource : ObjectBase<UGizmoBaseVec2ParameterSource>
{
}

public unsafe class GizmoLocalVec2ParameterSource : ObjectBase<UGizmoLocalVec2ParameterSource>
{

}

public unsafe class GizmoAxisTranslationParameterSource : ObjectBase<UGizmoAxisTranslationParameterSource>
{

}

public unsafe class GizmoPlaneTranslationParameterSource : ObjectBase<UGizmoPlaneTranslationParameterSource>
{

}

public unsafe class GizmoAxisRotationParameterSource : ObjectBase<UGizmoAxisRotationParameterSource>
{

}

public unsafe class GizmoUniformScaleParameterSource : ObjectBase<UGizmoUniformScaleParameterSource>
{

}

public unsafe class GizmoAxisScaleParameterSource : ObjectBase<UGizmoAxisScaleParameterSource>
{

}

public unsafe class GizmoPlaneScaleParameterSource : ObjectBase<UGizmoPlaneScaleParameterSource>
{

}

public unsafe class PlanePositionGizmoBuilder : ObjectBase<UPlanePositionGizmoBuilder>
{
}

public unsafe class PlanePositionGizmo : ObjectBase<UPlanePositionGizmo>
{

}

public unsafe class SelectionSet : ObjectBase<USelectionSet>
{
}

public unsafe class MeshSelectionSet : ObjectBase<UMeshSelectionSet>
{

}

public unsafe class SingleClickInputBehavior : ObjectBase<USingleClickInputBehavior>
{

}

public unsafe class SingleClickToolBuilder : ObjectBase<USingleClickToolBuilder>
{
}

public unsafe class SingleClickTool : ObjectBase<USingleClickTool>
{
}

public unsafe class GizmoNilStateTarget : ObjectBase<UGizmoNilStateTarget>
{
}

public unsafe class GizmoLambdaStateTarget : ObjectBase<UGizmoLambdaStateTarget>
{
}

public unsafe class GizmoObjectModifyStateTarget : ObjectBase<UGizmoObjectModifyStateTarget>
{
}

public unsafe class GizmoTransformChangeStateTarget : ObjectBase<UGizmoTransformChangeStateTarget>
{

}

public unsafe class TransformGizmoActor : ObjectBase<ATransformGizmoActor>
{

}

public unsafe class TransformGizmoBuilder : ObjectBase<UTransformGizmoBuilder>
{
}

public unsafe class TransformGizmo : ObjectBase<UTransformGizmo>
{

}

public unsafe class TransformProxy : ObjectBase<UTransformProxy>
{

}

public unsafe class GizmoBaseTransformSource : ObjectBase<UGizmoBaseTransformSource>
{
}

public unsafe class GizmoComponentWorldTransformSource : ObjectBase<UGizmoComponentWorldTransformSource>
{

}

public unsafe class GizmoScaledTransformSource : ObjectBase<UGizmoScaledTransformSource>
{

}

public unsafe class GizmoTransformProxyTransformSource : ObjectBase<UGizmoTransformProxyTransformSource>
{

}

public unsafe class BrushStampData : ObjectBase<FBrushStampData>
{
}

public unsafe class BehaviorInfo : ObjectBase<FBehaviorInfo>
{

}

public unsafe class InputRayHit : ObjectBase<FInputRayHit>
{
}

public unsafe class ActiveGizmo : ObjectBase<FActiveGizmo>
{
}

public unsafe class GizmoFloatParameterChange : ObjectBase<FGizmoFloatParameterChange>
{

}

public unsafe class GizmoVec2ParameterChange : ObjectBase<FGizmoVec2ParameterChange>
{

}

