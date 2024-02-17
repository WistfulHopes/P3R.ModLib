using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AxisPositionGizmoBuilder : ObjectBase<UAxisPositionGizmoBuilder>
{
    public AxisPositionGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class AxisPositionGizmo : ObjectBase<UAxisPositionGizmo>
{
    public AxisPositionGizmo(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoConstantAxisSource : ObjectBase<UGizmoConstantAxisSource>
{
    public GizmoConstantAxisSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoConstantFrameAxisSource : ObjectBase<UGizmoConstantFrameAxisSource>
{
    public GizmoConstantFrameAxisSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoWorldAxisSource : ObjectBase<UGizmoWorldAxisSource>
{
    public GizmoWorldAxisSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoComponentAxisSource : ObjectBase<UGizmoComponentAxisSource>
{
    public GizmoComponentAxisSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class InteractiveToolPropertySet : ObjectBase<UInteractiveToolPropertySet>
{
    public InteractiveToolPropertySet(IntPtr pointer) : base(pointer) {}
}

public unsafe class BrushBaseProperties : ObjectBase<UBrushBaseProperties>
{
    public BrushBaseProperties(IntPtr pointer) : base(pointer) {}
}

public unsafe class InteractiveTool : ObjectBase<UInteractiveTool>
{
    public InteractiveTool(IntPtr pointer) : base(pointer) {}
}

public unsafe class SingleSelectionTool : ObjectBase<USingleSelectionTool>
{
    public SingleSelectionTool(IntPtr pointer) : base(pointer) {}}

public unsafe class MeshSurfacePointTool : ObjectBase<UMeshSurfacePointTool>
{
    public MeshSurfacePointTool(IntPtr pointer) : base(pointer) {}}

public unsafe class BaseBrushTool : ObjectBase<UBaseBrushTool>
{
    public BaseBrushTool(IntPtr pointer) : base(pointer) {}
}

public unsafe class BrushStampIndicatorBuilder : ObjectBase<UBrushStampIndicatorBuilder>
{
    public BrushStampIndicatorBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class BrushStampIndicator : ObjectBase<UBrushStampIndicator>
{
    public BrushStampIndicator(IntPtr pointer) : base(pointer) {}
}

public unsafe class ClickDragInputBehavior : ObjectBase<UClickDragInputBehavior>
{
    public ClickDragInputBehavior(IntPtr pointer) : base(pointer) {}
}

public unsafe class LocalClickDragInputBehavior : ObjectBase<ULocalClickDragInputBehavior>
{
    public LocalClickDragInputBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveToolBuilder : ObjectBase<UInteractiveToolBuilder>
{
    public InteractiveToolBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class ClickDragToolBuilder : ObjectBase<UClickDragToolBuilder>
{
    public ClickDragToolBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class ClickDragTool : ObjectBase<UClickDragTool>
{
    public ClickDragTool(IntPtr pointer) : base(pointer) {}}

public unsafe class InternalToolFrameworkActor : ObjectBase<AInternalToolFrameworkActor>
{
    public InternalToolFrameworkActor(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoActor : ObjectBase<AGizmoActor>
{
    public GizmoActor(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoBaseComponent : ObjectBase<UGizmoBaseComponent>
{
    public GizmoBaseComponent(IntPtr pointer) : base(pointer) {}
    public void UpdateWorldLocalState(bool bWorldIn)
    {
        Span<(string name, object value)> @params = [
            ("bWorldIn", bWorldIn)
        ];
        ProcessEvent(GetFunction("UpdateWorldLocalState"), @params);
    }
    public void UpdateHoverState(bool bHoveringIn)
    {
        Span<(string name, object value)> @params = [
            ("bHoveringIn", bHoveringIn)
        ];
        ProcessEvent(GetFunction("UpdateHoverState"), @params);
    }
}

public unsafe class GizmoArrowComponent : ObjectBase<UGizmoArrowComponent>
{
    public GizmoArrowComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoBoxComponent : ObjectBase<UGizmoBoxComponent>
{
    public GizmoBoxComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoCircleComponent : ObjectBase<UGizmoCircleComponent>
{
    public GizmoCircleComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoTransformSource : ObjectBase<IGizmoTransformSource>
{
    public GizmoTransformSource(IntPtr pointer) : base(pointer) {}
    public void SetTransform(ref FTransform NewTransform)
    {
        Span<(string name, object value)> @params = [
            ("NewTransform", NewTransform)
        ];
        ProcessEvent(GetFunction("SetTransform"), @params);
    }
    public FTransform GetTransform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTransform>(GetFunction("GetTransform"), @params);
    }
}

public unsafe class GizmoAxisSource : ObjectBase<IGizmoAxisSource>
{
    public GizmoAxisSource(IntPtr pointer) : base(pointer) {}
    public bool HasTangentVectors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasTangentVectors"), @params);
    }
    public void GetTangentVectors(ref FVector TangentXOut, ref FVector TangentYOut)
    {
        Span<(string name, object value)> @params = [
            ("TangentXOut", TangentXOut), 
            ("TangentYOut", TangentYOut)
        ];
        ProcessEvent(GetFunction("GetTangentVectors"), @params);
    }
    public FVector GetOrigin()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetOrigin"), @params);
    }
    public FVector GetDirection()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetDirection"), @params);
    }
}

public unsafe class GizmoClickTarget : ObjectBase<IGizmoClickTarget>
{
    public GizmoClickTarget(IntPtr pointer) : base(pointer) {}
    public void UpdateHoverState(bool bHovering)
    {
        Span<(string name, object value)> @params = [
            ("bHovering", bHovering)
        ];
        ProcessEvent(GetFunction("UpdateHoverState"), @params);
    }
}

public unsafe class GizmoStateTarget : ObjectBase<IGizmoStateTarget>
{
    public GizmoStateTarget(IntPtr pointer) : base(pointer) {}
    public void EndUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndUpdate"), @params);
    }
    public void BeginUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginUpdate"), @params);
    }
}

public unsafe class GizmoFloatParameterSource : ObjectBase<IGizmoFloatParameterSource>
{
    public GizmoFloatParameterSource(IntPtr pointer) : base(pointer) {}
    public void SetParameter(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetParameter"), @params);
    }
    public float GetParameter()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetParameter"), @params);
    }
    public void EndModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndModify"), @params);
    }
    public void BeginModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginModify"), @params);
    }
}

public unsafe class GizmoVec2ParameterSource : ObjectBase<IGizmoVec2ParameterSource>
{
    public GizmoVec2ParameterSource(IntPtr pointer) : base(pointer) {}
    public void SetParameter(ref FVector2D NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetParameter"), @params);
    }
    public FVector2D GetParameter()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetParameter"), @params);
    }
    public void EndModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndModify"), @params);
    }
    public void BeginModify()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BeginModify"), @params);
    }
}

public unsafe class GizmoLineHandleComponent : ObjectBase<UGizmoLineHandleComponent>
{
    public GizmoLineHandleComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoRectangleComponent : ObjectBase<UGizmoRectangleComponent>
{
    public GizmoRectangleComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoLambdaHitTarget : ObjectBase<UGizmoLambdaHitTarget>
{
    public GizmoLambdaHitTarget(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoComponentHitTarget : ObjectBase<UGizmoComponentHitTarget>
{
    public GizmoComponentHitTarget(IntPtr pointer) : base(pointer) {}
}

public unsafe class InputBehaviorSet : ObjectBase<UInputBehaviorSet>
{
    public InputBehaviorSet(IntPtr pointer) : base(pointer) {}
}

public unsafe class InputBehaviorSource : ObjectBase<IInputBehaviorSource>
{
    public InputBehaviorSource(IntPtr pointer) : base(pointer) {}}

public unsafe class InputRouter : ObjectBase<UInputRouter>
{
    public InputRouter(IntPtr pointer) : base(pointer) {}
}

public unsafe class InteractionMechanic : ObjectBase<UInteractionMechanic>
{
    public InteractionMechanic(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveGizmoManager : ObjectBase<UInteractiveGizmoManager>
{
    public InteractiveGizmoManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class ToolContextTransactionProvider : ObjectBase<IToolContextTransactionProvider>
{
    public ToolContextTransactionProvider(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveToolManager : ObjectBase<UInteractiveToolManager>
{
    public InteractiveToolManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class ToolFrameworkComponent : ObjectBase<IToolFrameworkComponent>
{
    public ToolFrameworkComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveToolsContext : ObjectBase<UInteractiveToolsContext>
{
    public InteractiveToolsContext(IntPtr pointer) : base(pointer) {}
}

public unsafe class IntervalGizmoActor : ObjectBase<AIntervalGizmoActor>
{
    public IntervalGizmoActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class IntervalGizmoBuilder : ObjectBase<UIntervalGizmoBuilder>
{
    public IntervalGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class IntervalGizmo : ObjectBase<UIntervalGizmo>
{
    public IntervalGizmo(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoBaseFloatParameterSource : ObjectBase<UGizmoBaseFloatParameterSource>
{
    public GizmoBaseFloatParameterSource(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoAxisIntervalParameterSource : ObjectBase<UGizmoAxisIntervalParameterSource>
{
    public GizmoAxisIntervalParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class KeyAsModifierInputBehavior : ObjectBase<UKeyAsModifierInputBehavior>
{
    public KeyAsModifierInputBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class MeshSurfacePointToolBuilder : ObjectBase<UMeshSurfacePointToolBuilder>
{
    public MeshSurfacePointToolBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class MouseHoverBehavior : ObjectBase<UMouseHoverBehavior>
{
    public MouseHoverBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class MultiClickSequenceInputBehavior : ObjectBase<UMultiClickSequenceInputBehavior>
{
    public MultiClickSequenceInputBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class MultiSelectionTool : ObjectBase<UMultiSelectionTool>
{
    public MultiSelectionTool(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoLocalFloatParameterSource : ObjectBase<UGizmoLocalFloatParameterSource>
{
    public GizmoLocalFloatParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoBaseVec2ParameterSource : ObjectBase<UGizmoBaseVec2ParameterSource>
{
    public GizmoBaseVec2ParameterSource(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoLocalVec2ParameterSource : ObjectBase<UGizmoLocalVec2ParameterSource>
{
    public GizmoLocalVec2ParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoAxisTranslationParameterSource : ObjectBase<UGizmoAxisTranslationParameterSource>
{
    public GizmoAxisTranslationParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoPlaneTranslationParameterSource : ObjectBase<UGizmoPlaneTranslationParameterSource>
{
    public GizmoPlaneTranslationParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoAxisRotationParameterSource : ObjectBase<UGizmoAxisRotationParameterSource>
{
    public GizmoAxisRotationParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoUniformScaleParameterSource : ObjectBase<UGizmoUniformScaleParameterSource>
{
    public GizmoUniformScaleParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoAxisScaleParameterSource : ObjectBase<UGizmoAxisScaleParameterSource>
{
    public GizmoAxisScaleParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoPlaneScaleParameterSource : ObjectBase<UGizmoPlaneScaleParameterSource>
{
    public GizmoPlaneScaleParameterSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class PlanePositionGizmoBuilder : ObjectBase<UPlanePositionGizmoBuilder>
{
    public PlanePositionGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class PlanePositionGizmo : ObjectBase<UPlanePositionGizmo>
{
    public PlanePositionGizmo(IntPtr pointer) : base(pointer) {}
}

public unsafe class InputBehavior : ObjectBase<UInputBehavior>
{
    public InputBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class MeshSelectionSet : ObjectBase<UMeshSelectionSet>
{
    public MeshSelectionSet(IntPtr pointer) : base(pointer) {}
}

public unsafe class SingleClickInputBehavior : ObjectBase<USingleClickInputBehavior>
{
    public SingleClickInputBehavior(IntPtr pointer) : base(pointer) {}
}

public unsafe class SingleClickToolBuilder : ObjectBase<USingleClickToolBuilder>
{
    public SingleClickToolBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class SingleClickTool : ObjectBase<USingleClickTool>
{
    public SingleClickTool(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoNilStateTarget : ObjectBase<UGizmoNilStateTarget>
{
    public GizmoNilStateTarget(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoLambdaStateTarget : ObjectBase<UGizmoLambdaStateTarget>
{
    public GizmoLambdaStateTarget(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoObjectModifyStateTarget : ObjectBase<UGizmoObjectModifyStateTarget>
{
    public GizmoObjectModifyStateTarget(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoTransformChangeStateTarget : ObjectBase<UGizmoTransformChangeStateTarget>
{
    public GizmoTransformChangeStateTarget(IntPtr pointer) : base(pointer) {}
}

public unsafe class TransformGizmoActor : ObjectBase<ATransformGizmoActor>
{
    public TransformGizmoActor(IntPtr pointer) : base(pointer) {}
}

public unsafe class TransformGizmoBuilder : ObjectBase<UTransformGizmoBuilder>
{
    public TransformGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class SelectionSet : ObjectBase<USelectionSet>
{
    public SelectionSet(IntPtr pointer) : base(pointer) {}}

public unsafe class TransformProxy : ObjectBase<UTransformProxy>
{
    public TransformProxy(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoBaseTransformSource : ObjectBase<UGizmoBaseTransformSource>
{
    public GizmoBaseTransformSource(IntPtr pointer) : base(pointer) {}}

public unsafe class GizmoComponentWorldTransformSource : ObjectBase<UGizmoComponentWorldTransformSource>
{
    public GizmoComponentWorldTransformSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoScaledTransformSource : ObjectBase<UGizmoScaledTransformSource>
{
    public GizmoScaledTransformSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class GizmoTransformProxyTransformSource : ObjectBase<UGizmoTransformProxyTransformSource>
{
    public GizmoTransformProxyTransformSource(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnyButtonInputBehavior : ObjectBase<UAnyButtonInputBehavior>
{
    public AnyButtonInputBehavior(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveGizmoBuilder : ObjectBase<UInteractiveGizmoBuilder>
{
    public InteractiveGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class AxisAngleGizmoBuilder : ObjectBase<UAxisAngleGizmoBuilder>
{
    public AxisAngleGizmoBuilder(IntPtr pointer) : base(pointer) {}}

public unsafe class InteractiveGizmo : ObjectBase<UInteractiveGizmo>
{
    public InteractiveGizmo(IntPtr pointer) : base(pointer) {}
}

public unsafe class AxisAngleGizmo : ObjectBase<UAxisAngleGizmo>
{
    public AxisAngleGizmo(IntPtr pointer) : base(pointer) {}
}

public unsafe class TransformGizmo : ObjectBase<UTransformGizmo>
{
    public TransformGizmo(IntPtr pointer) : base(pointer) {}
}

