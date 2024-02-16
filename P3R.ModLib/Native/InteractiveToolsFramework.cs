using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInputBehavior
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UAnyButtonInputBehavior
{
    [FieldOffset(0x0000)] public UInputBehavior baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInteractiveGizmoBuilder
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAxisAngleGizmoBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInteractiveGizmo
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UInputBehaviorSet* InputBehaviors;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UAxisAngleGizmo
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x0058)] public TScriptInterface<IGizmoFloatParameterSource> AngleSource;
    [FieldOffset(0x0068)] public TScriptInterface<IGizmoClickTarget> HitTarget;
    [FieldOffset(0x0078)] public TScriptInterface<IGizmoStateTarget> StateTarget;
    [FieldOffset(0x0088)] public bool bInInteraction;
    [FieldOffset(0x008C)] public FVector RotationOrigin;
    [FieldOffset(0x0098)] public FVector RotationAxis;
    [FieldOffset(0x00A4)] public FVector RotationPlaneX;
    [FieldOffset(0x00B0)] public FVector RotationPlaneY;
    [FieldOffset(0x00BC)] public FVector InteractionStartPoint;
    [FieldOffset(0x00C8)] public FVector InteractionCurPoint;
    [FieldOffset(0x00D4)] public float InteractionStartAngle;
    [FieldOffset(0x00D8)] public float InteractionCurAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UAxisPositionGizmoBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UAxisPositionGizmo
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x0058)] public TScriptInterface<IGizmoFloatParameterSource> ParameterSource;
    [FieldOffset(0x0068)] public TScriptInterface<IGizmoClickTarget> HitTarget;
    [FieldOffset(0x0078)] public TScriptInterface<IGizmoStateTarget> StateTarget;
    [FieldOffset(0x0088)] public bool bEnableSignedAxis;
    [FieldOffset(0x0089)] public bool bInInteraction;
    [FieldOffset(0x008C)] public FVector InteractionOrigin;
    [FieldOffset(0x0098)] public FVector InteractionAxis;
    [FieldOffset(0x00A4)] public FVector InteractionStartPoint;
    [FieldOffset(0x00B0)] public FVector InteractionCurPoint;
    [FieldOffset(0x00BC)] public float InteractionStartParameter;
    [FieldOffset(0x00C0)] public float InteractionCurParameter;
    [FieldOffset(0x00C4)] public float ParameterSign;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGizmoConstantAxisSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FVector Origin;
    [FieldOffset(0x003C)] public FVector Direction;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UGizmoConstantFrameAxisSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FVector Origin;
    [FieldOffset(0x003C)] public FVector Direction;
    [FieldOffset(0x0048)] public FVector TangentX;
    [FieldOffset(0x0054)] public FVector TangentY;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGizmoWorldAxisSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public FVector Origin;
    [FieldOffset(0x003C)] public int AxisIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UGizmoComponentAxisSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public USceneComponent* Component;
    [FieldOffset(0x0038)] public int AxisIndex;
    [FieldOffset(0x003C)] public bool bLocalAxes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInteractiveToolPropertySet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0038)] public UInteractiveToolPropertySet* CachedProperties;
    [FieldOffset(0x0040)] public bool bIsPropertySetEnabled;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UBrushBaseProperties
{
    [FieldOffset(0x0000)] public UInteractiveToolPropertySet baseObj;
    [FieldOffset(0x0060)] public float BrushSize;
    [FieldOffset(0x0064)] public bool bSpecifyRadius;
    [FieldOffset(0x0068)] public float BrushRadius;
    [FieldOffset(0x006C)] public float BrushStrength;
    [FieldOffset(0x0070)] public float BrushFalloffAmount;
    [FieldOffset(0x0074)] public bool bShowStrength;
    [FieldOffset(0x0075)] public bool bShowFalloff;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UInteractiveTool
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0048)] public UInputBehaviorSet* InputBehaviors;
    [FieldOffset(0x0050)] public TArray<IntPtr> ToolPropertyObjects;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct USingleSelectionTool
{
    [FieldOffset(0x0000)] public UInteractiveTool baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMeshSurfacePointTool
{
    [FieldOffset(0x0000)] public USingleSelectionTool baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FBrushStampData
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B8)] 
public unsafe struct UBaseBrushTool
{
    [FieldOffset(0x0000)] public UMeshSurfacePointTool baseObj;
    [FieldOffset(0x00C0)] public UBrushBaseProperties* BrushProperties;
    [FieldOffset(0x00C8)] public bool bInBrushStroke;
    [FieldOffset(0x00CC)] public float WorldToLocalScale;
    [FieldOffset(0x00D0)] public FBrushStampData LastBrushStamp;
    [FieldOffset(0x0188)] public TSoftClassPtr<UBrushBaseProperties> PropertyClass;
    [FieldOffset(0x01B0)] public UBrushStampIndicator* BrushStampIndicator;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBrushStampIndicatorBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UBrushStampIndicator
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0038)] public float BrushRadius;
    [FieldOffset(0x003C)] public float BrushFalloff;
    [FieldOffset(0x0040)] public FVector BrushPosition;
    [FieldOffset(0x004C)] public FVector BrushNormal;
    [FieldOffset(0x0058)] public bool bDrawIndicatorLines;
    [FieldOffset(0x0059)] public bool bDrawRadiusCircle;
    [FieldOffset(0x005C)] public int SampleStepCount;
    [FieldOffset(0x0060)] public FLinearColor LineColor;
    [FieldOffset(0x0070)] public float LineThickness;
    [FieldOffset(0x0074)] public bool bDepthTested;
    [FieldOffset(0x0075)] public bool bDrawSecondaryLines;
    [FieldOffset(0x0078)] public float SecondaryLineThickness;
    [FieldOffset(0x007C)] public FLinearColor SecondaryLineColor;
    [FieldOffset(0x0090)] public UPrimitiveComponent* AttachedComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UClickDragInputBehavior
{
    [FieldOffset(0x0000)] public UAnyButtonInputBehavior baseObj;
    [FieldOffset(0x0120)] public bool bUpdateModifiersDuringDrag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x280)] 
public unsafe struct ULocalClickDragInputBehavior
{
    [FieldOffset(0x0000)] public UClickDragInputBehavior baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UInteractiveToolBuilder
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UClickDragToolBuilder
{
    [FieldOffset(0x0000)] public UInteractiveToolBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UClickDragTool
{
    [FieldOffset(0x0000)] public UInteractiveTool baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AInternalToolFrameworkActor
{
    [FieldOffset(0x0000)] public AActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct AGizmoActor
{
    [FieldOffset(0x0000)] public AInternalToolFrameworkActor baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UGizmoBaseComponent
{
    [FieldOffset(0x0000)] public UPrimitiveComponent baseObj;
    [FieldOffset(0x0450)] public FLinearColor Color;
    [FieldOffset(0x0460)] public float HoverSizeMultiplier;
    [FieldOffset(0x0464)] public float PixelHitDistanceThreshold;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UGizmoArrowComponent
{
    [FieldOffset(0x0000)] public UGizmoBaseComponent baseObj;
    [FieldOffset(0x0470)] public FVector Direction;
    [FieldOffset(0x047C)] public float Gap;
    [FieldOffset(0x0480)] public float Length;
    [FieldOffset(0x0484)] public float Thickness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4B0)] 
public unsafe struct UGizmoBoxComponent
{
    [FieldOffset(0x0000)] public UGizmoBaseComponent baseObj;
    [FieldOffset(0x0470)] public FVector Origin;
    [FieldOffset(0x0480)] public FQuat Rotation;
    [FieldOffset(0x0490)] public FVector Dimensions;
    [FieldOffset(0x049C)] public float LineThickness;
    [FieldOffset(0x04A0)] public bool bRemoveHiddenLines;
    [FieldOffset(0x04A1)] public bool bEnableAxisFlip;
}

[StructLayout(LayoutKind.Explicit, Size = 0x490)] 
public unsafe struct UGizmoCircleComponent
{
    [FieldOffset(0x0000)] public UGizmoBaseComponent baseObj;
    [FieldOffset(0x0470)] public FVector Normal;
    [FieldOffset(0x047C)] public float Radius;
    [FieldOffset(0x0480)] public float Thickness;
    [FieldOffset(0x0484)] public int NumSides;
    [FieldOffset(0x0488)] public bool bViewAligned;
    [FieldOffset(0x0489)] public bool bOnlyAllowFrontFacingHits;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoTransformSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoAxisSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoClickTarget
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoStateTarget
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoFloatParameterSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGizmoVec2ParameterSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UGizmoLineHandleComponent
{
    [FieldOffset(0x0000)] public UGizmoBaseComponent baseObj;
    [FieldOffset(0x0470)] public FVector Normal;
    [FieldOffset(0x047C)] public float HandleSize;
    [FieldOffset(0x0480)] public float Thickness;
    [FieldOffset(0x0484)] public FVector Direction;
    [FieldOffset(0x0490)] public float Length;
    [FieldOffset(0x0494)] public bool bImageScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4A0)] 
public unsafe struct UGizmoRectangleComponent
{
    [FieldOffset(0x0000)] public UGizmoBaseComponent baseObj;
    [FieldOffset(0x0470)] public FVector DirectionX;
    [FieldOffset(0x047C)] public FVector DirectionY;
    [FieldOffset(0x0488)] public float OffsetX;
    [FieldOffset(0x048C)] public float OffsetY;
    [FieldOffset(0x0490)] public float LengthX;
    [FieldOffset(0x0494)] public float LengthY;
    [FieldOffset(0x0498)] public float Thickness;
    [FieldOffset(0x049C)] public byte SegmentFlags;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UGizmoLambdaHitTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UGizmoComponentHitTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UPrimitiveComponent* Component;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FBehaviorInfo
{
    [FieldOffset(0x0000)] public UInputBehavior* Behavior;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UInputBehaviorSet
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FBehaviorInfo> Behaviors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IInputBehaviorSource
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UInputRouter
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bAutoInvalidateOnHover;
    [FieldOffset(0x0029)] public bool bAutoInvalidateOnCapture;
    [FieldOffset(0x0038)] public UInputBehaviorSet* ActiveInputBehaviors;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UInteractionMechanic
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FActiveGizmo
{
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UInteractiveGizmoManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public TArray<FActiveGizmo> ActiveGizmos;
    [FieldOffset(0x0058)] public TMap<FString, IntPtr> GizmoBuilders;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IToolContextTransactionProvider
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UInteractiveToolManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0030)] public UInteractiveTool* ActiveLeftTool;
    [FieldOffset(0x0038)] public UInteractiveTool* ActiveRightTool;
    [FieldOffset(0x0090)] public TMap<FString, IntPtr> ToolBuilders;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IToolFrameworkComponent
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UInteractiveToolsContext
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0058)] public UInputRouter* InputRouter;
    [FieldOffset(0x0060)] public UInteractiveToolManager* ToolManager;
    [FieldOffset(0x0068)] public UInteractiveGizmoManager* GizmoManager;
    [FieldOffset(0x0070)] public TSoftClassPtr<UInteractiveToolManager> ToolManagerClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x238)] 
public unsafe struct AIntervalGizmoActor
{
    [FieldOffset(0x0000)] public AGizmoActor baseObj;
    [FieldOffset(0x0220)] public UGizmoLineHandleComponent* UpIntervalComponent;
    [FieldOffset(0x0228)] public UGizmoLineHandleComponent* DownIntervalComponent;
    [FieldOffset(0x0230)] public UGizmoLineHandleComponent* ForwardIntervalComponent;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UIntervalGizmoBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UIntervalGizmo
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0038)] public UGizmoTransformChangeStateTarget* StateTarget;
    [FieldOffset(0x0050)] public UTransformProxy* TransformProxy;
    [FieldOffset(0x0058)] public TArray<IntPtr> ActiveComponents;
    [FieldOffset(0x0068)] public TArray<IntPtr> ActiveGizmos;
    [FieldOffset(0x0090)] public UGizmoComponentAxisSource* AxisYSource;
    [FieldOffset(0x0098)] public UGizmoComponentAxisSource* AxisZSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGizmoBaseFloatParameterSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UGizmoAxisIntervalParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseFloatParameterSource baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoFloatParameterSource> FloatParameterSource;
    [FieldOffset(0x0058)] public float MinParameter;
    [FieldOffset(0x005C)] public float MaxParameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UKeyAsModifierInputBehavior
{
    [FieldOffset(0x0000)] public UInputBehavior baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UMeshSurfacePointToolBuilder
{
    [FieldOffset(0x0000)] public UInteractiveToolBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UMouseHoverBehavior
{
    [FieldOffset(0x0000)] public UInputBehavior baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UMultiClickSequenceInputBehavior
{
    [FieldOffset(0x0000)] public UAnyButtonInputBehavior baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UMultiSelectionTool
{
    [FieldOffset(0x0000)] public UInteractiveTool baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGizmoFloatParameterChange
{
    [FieldOffset(0x0000)] public float InitialValue;
    [FieldOffset(0x0004)] public float CurrentValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGizmoLocalFloatParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseFloatParameterSource baseObj;
    [FieldOffset(0x0048)] public float Value;
    [FieldOffset(0x004C)] public FGizmoFloatParameterChange LastChange;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGizmoBaseVec2ParameterSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGizmoVec2ParameterChange
{
    [FieldOffset(0x0000)] public FVector2D InitialValue;
    [FieldOffset(0x0008)] public FVector2D CurrentValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UGizmoLocalVec2ParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseVec2ParameterSource baseObj;
    [FieldOffset(0x0048)] public FVector2D Value;
    [FieldOffset(0x0050)] public FGizmoVec2ParameterChange LastChange;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UGizmoAxisTranslationParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseFloatParameterSource baseObj;
    [FieldOffset(0x0090)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x00A0)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x00B0)] public float Parameter;
    [FieldOffset(0x00B4)] public FGizmoFloatParameterChange LastChange;
    [FieldOffset(0x00BC)] public FVector CurTranslationAxis;
    [FieldOffset(0x00C8)] public FVector CurTranslationOrigin;
    [FieldOffset(0x00E0)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UGizmoPlaneTranslationParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseVec2ParameterSource baseObj;
    [FieldOffset(0x0090)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x00A0)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x00B0)] public FVector2D Parameter;
    [FieldOffset(0x00B8)] public FGizmoVec2ParameterChange LastChange;
    [FieldOffset(0x00C8)] public FVector CurTranslationOrigin;
    [FieldOffset(0x00D4)] public FVector CurTranslationNormal;
    [FieldOffset(0x00E0)] public FVector CurTranslationAxisX;
    [FieldOffset(0x00EC)] public FVector CurTranslationAxisY;
    [FieldOffset(0x0100)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x110)] 
public unsafe struct UGizmoAxisRotationParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseFloatParameterSource baseObj;
    [FieldOffset(0x0090)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x00A0)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x00B0)] public float Angle;
    [FieldOffset(0x00B4)] public FGizmoFloatParameterChange LastChange;
    [FieldOffset(0x00BC)] public FVector CurRotationAxis;
    [FieldOffset(0x00C8)] public FVector CurRotationOrigin;
    [FieldOffset(0x00E0)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UGizmoUniformScaleParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseVec2ParameterSource baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x0058)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x0068)] public float ScaleMultiplier;
    [FieldOffset(0x006C)] public FVector2D Parameter;
    [FieldOffset(0x0074)] public FGizmoVec2ParameterChange LastChange;
    [FieldOffset(0x0084)] public FVector CurScaleOrigin;
    [FieldOffset(0x0090)] public FVector CurScaleNormal;
    [FieldOffset(0x009C)] public FVector CurScaleAxisX;
    [FieldOffset(0x00A8)] public FVector CurScaleAxisY;
    [FieldOffset(0x00C0)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UGizmoAxisScaleParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseFloatParameterSource baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x0058)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x0068)] public float ScaleMultiplier;
    [FieldOffset(0x006C)] public float Parameter;
    [FieldOffset(0x0070)] public FGizmoFloatParameterChange LastChange;
    [FieldOffset(0x0078)] public FVector CurScaleAxis;
    [FieldOffset(0x0084)] public FVector CurScaleOrigin;
    [FieldOffset(0x0090)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UGizmoPlaneScaleParameterSource
{
    [FieldOffset(0x0000)] public UGizmoBaseVec2ParameterSource baseObj;
    [FieldOffset(0x0090)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x00A0)] public TScriptInterface<IGizmoTransformSource> TransformSource;
    [FieldOffset(0x00B0)] public float ScaleMultiplier;
    [FieldOffset(0x00B4)] public FVector2D Parameter;
    [FieldOffset(0x00BC)] public FGizmoVec2ParameterChange LastChange;
    [FieldOffset(0x00CC)] public FVector CurScaleOrigin;
    [FieldOffset(0x00D8)] public FVector CurScaleNormal;
    [FieldOffset(0x00E4)] public FVector CurScaleAxisX;
    [FieldOffset(0x00F0)] public FVector CurScaleAxisY;
    [FieldOffset(0x0100)] public FTransform InitialTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UPlanePositionGizmoBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UPlanePositionGizmo
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoAxisSource> AxisSource;
    [FieldOffset(0x0058)] public TScriptInterface<IGizmoVec2ParameterSource> ParameterSource;
    [FieldOffset(0x0068)] public TScriptInterface<IGizmoClickTarget> HitTarget;
    [FieldOffset(0x0078)] public TScriptInterface<IGizmoStateTarget> StateTarget;
    [FieldOffset(0x0088)] public bool bEnableSignedAxis;
    [FieldOffset(0x0089)] public bool bFlipX;
    [FieldOffset(0x008A)] public bool bFlipY;
    [FieldOffset(0x008B)] public bool bInInteraction;
    [FieldOffset(0x008C)] public FVector InteractionOrigin;
    [FieldOffset(0x0098)] public FVector InteractionNormal;
    [FieldOffset(0x00A4)] public FVector InteractionAxisX;
    [FieldOffset(0x00B0)] public FVector InteractionAxisY;
    [FieldOffset(0x00BC)] public FVector InteractionStartPoint;
    [FieldOffset(0x00C8)] public FVector InteractionCurPoint;
    [FieldOffset(0x00D4)] public FVector2D InteractionStartParameter;
    [FieldOffset(0x00DC)] public FVector2D InteractionCurParameter;
    [FieldOffset(0x00E4)] public FVector2D ParameterSigns;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct USelectionSet
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct UMeshSelectionSet
{
    [FieldOffset(0x0000)] public USelectionSet baseObj;
    [FieldOffset(0x0040)] public TArray<int> Vertices;
    [FieldOffset(0x0050)] public TArray<int> Edges;
    [FieldOffset(0x0060)] public TArray<int> Faces;
    [FieldOffset(0x0070)] public TArray<int> Groups;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct USingleClickInputBehavior
{
    [FieldOffset(0x0000)] public UAnyButtonInputBehavior baseObj;
    [FieldOffset(0x00C0)] public bool HitTestOnRelease;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USingleClickToolBuilder
{
    [FieldOffset(0x0000)] public UInteractiveToolBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct USingleClickTool
{
    [FieldOffset(0x0000)] public UInteractiveTool baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UGizmoNilStateTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct UGizmoLambdaStateTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGizmoObjectModifyStateTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UGizmoTransformChangeStateTarget
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0050)] public TScriptInterface<IToolContextTransactionProvider> TransactionManager;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct ATransformGizmoActor
{
    [FieldOffset(0x0000)] public AGizmoActor baseObj;
    [FieldOffset(0x0220)] public UPrimitiveComponent* TranslateX;
    [FieldOffset(0x0228)] public UPrimitiveComponent* TranslateY;
    [FieldOffset(0x0230)] public UPrimitiveComponent* TranslateZ;
    [FieldOffset(0x0238)] public UPrimitiveComponent* TranslateYZ;
    [FieldOffset(0x0240)] public UPrimitiveComponent* TranslateXZ;
    [FieldOffset(0x0248)] public UPrimitiveComponent* TranslateXY;
    [FieldOffset(0x0250)] public UPrimitiveComponent* RotateX;
    [FieldOffset(0x0258)] public UPrimitiveComponent* RotateY;
    [FieldOffset(0x0260)] public UPrimitiveComponent* RotateZ;
    [FieldOffset(0x0268)] public UPrimitiveComponent* UniformScale;
    [FieldOffset(0x0270)] public UPrimitiveComponent* AxisScaleX;
    [FieldOffset(0x0278)] public UPrimitiveComponent* AxisScaleY;
    [FieldOffset(0x0280)] public UPrimitiveComponent* AxisScaleZ;
    [FieldOffset(0x0288)] public UPrimitiveComponent* PlaneScaleYZ;
    [FieldOffset(0x0290)] public UPrimitiveComponent* PlaneScaleXZ;
    [FieldOffset(0x0298)] public UPrimitiveComponent* PlaneScaleXY;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UTransformGizmoBuilder
{
    [FieldOffset(0x0000)] public UInteractiveGizmoBuilder baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct UTransformGizmo
{
    [FieldOffset(0x0000)] public UInteractiveGizmo baseObj;
    [FieldOffset(0x0040)] public UTransformProxy* ActiveTarget;
    [FieldOffset(0x0048)] public bool bSnapToWorldGrid;
    [FieldOffset(0x0049)] public bool bGridSizeIsExplicit;
    [FieldOffset(0x004C)] public FVector ExplicitGridSize;
    [FieldOffset(0x0058)] public bool bRotationGridSizeIsExplicit;
    [FieldOffset(0x005C)] public FRotator ExplicitRotationGridSize;
    [FieldOffset(0x0068)] public bool bSnapToWorldRotGrid;
    [FieldOffset(0x0069)] public bool bUseContextCoordinateSystem;
    [FieldOffset(0x006C)] public EToolContextCoordinateSystem CurrentCoordinateSystem;
    [FieldOffset(0x0100)] public TArray<IntPtr> ActiveComponents;
    [FieldOffset(0x0110)] public TArray<IntPtr> NonuniformScaleComponents;
    [FieldOffset(0x0120)] public TArray<IntPtr> ActiveGizmos;
    [FieldOffset(0x0140)] public UGizmoConstantFrameAxisSource* CameraAxisSource;
    [FieldOffset(0x0148)] public UGizmoComponentAxisSource* AxisXSource;
    [FieldOffset(0x0150)] public UGizmoComponentAxisSource* AxisYSource;
    [FieldOffset(0x0158)] public UGizmoComponentAxisSource* AxisZSource;
    [FieldOffset(0x0160)] public UGizmoComponentAxisSource* UnitAxisXSource;
    [FieldOffset(0x0168)] public UGizmoComponentAxisSource* UnitAxisYSource;
    [FieldOffset(0x0170)] public UGizmoComponentAxisSource* UnitAxisZSource;
    [FieldOffset(0x0178)] public UGizmoTransformChangeStateTarget* StateTarget;
    [FieldOffset(0x0180)] public UGizmoScaledTransformSource* ScaledTransformSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0xF0)] 
public unsafe struct UTransformProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0070)] public bool bRotatePerObject;
    [FieldOffset(0x0071)] public bool bSetPivotMode;
    [FieldOffset(0x0090)] public FTransform SharedTransform;
    [FieldOffset(0x00C0)] public FTransform InitialSharedTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGizmoBaseTransformSource
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UGizmoComponentWorldTransformSource
{
    [FieldOffset(0x0000)] public UGizmoBaseTransformSource baseObj;
    [FieldOffset(0x0048)] public USceneComponent* Component;
    [FieldOffset(0x0050)] public bool bModifyComponentOnTransform;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UGizmoScaledTransformSource
{
    [FieldOffset(0x0000)] public UGizmoBaseTransformSource baseObj;
    [FieldOffset(0x0048)] public TScriptInterface<IGizmoTransformSource> ChildTransformSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UGizmoTransformProxyTransformSource
{
    [FieldOffset(0x0000)] public UGizmoBaseTransformSource baseObj;
    [FieldOffset(0x0048)] public UTransformProxy* Proxy;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FInputRayHit
{
}

