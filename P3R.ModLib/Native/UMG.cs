using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UVisual
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FWidgetTransform
{
    [FieldOffset(0x0000)] public FVector2D Translation;
    [FieldOffset(0x0008)] public FVector2D Scale;
    [FieldOffset(0x0010)] public FVector2D Shear;
    [FieldOffset(0x0018)] public float Angle;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FEventReply
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x108)] 
public unsafe struct UWidget
{
    [FieldOffset(0x0000)] public UVisual baseObj;
    [FieldOffset(0x0028)] public UPanelSlot* Slot;
    [FieldOffset(0x0040)] public FText ToolTipText;
    [FieldOffset(0x0068)] public UWidget* ToolTipWidget;
    [FieldOffset(0x0090)] public FWidgetTransform RenderTransform;
    [FieldOffset(0x00AC)] public FVector2D RenderTransformPivot;
    [FieldOffset(0x00B4)] public byte bIsVariable;
    [FieldOffset(0x00B4)] public byte bCreatedByConstructionScript;
    [FieldOffset(0x00B4)] public byte bIsEnabled;
    [FieldOffset(0x00B4)] public byte bOverride_Cursor;
    [FieldOffset(0x00B8)] public USlateAccessibleWidgetData* AccessibleWidgetData;
    [FieldOffset(0x00C0)] public byte bIsVolatile;
    [FieldOffset(0x00C1)] public EMouseCursor Cursor;
    [FieldOffset(0x00C2)] public EWidgetClipping Clipping;
    [FieldOffset(0x00C3)] public ESlateVisibility Visibility;
    [FieldOffset(0x00C4)] public float RenderOpacity;
    [FieldOffset(0x00C8)] public UWidgetNavigation* Navigation;
    [FieldOffset(0x00D0)] public EFlowDirectionPreference FlowDirectionPreference;
    [FieldOffset(0x00F8)] public TArray<IntPtr> NativeBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3)] 
public unsafe struct FShapedTextOptions
{
    [FieldOffset(0x0000)] public byte bOverride_TextShapingMethod;
    [FieldOffset(0x0000)] public byte bOverride_TextFlowDirection;
    [FieldOffset(0x0001)] public ETextShapingMethod TextShapingMethod;
    [FieldOffset(0x0002)] public ETextFlowDirection TextFlowDirection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x128)] 
public unsafe struct UTextLayoutWidget
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FShapedTextOptions ShapedTextOptions;
    [FieldOffset(0x010B)] public ETextJustify Justification;
    [FieldOffset(0x010C)] public ETextWrappingPolicy WrappingPolicy;
    [FieldOffset(0x010D)] public byte AutoWrapText;
    [FieldOffset(0x0110)] public float WrapTextAt;
    [FieldOffset(0x0114)] public FMargin Margin;
    [FieldOffset(0x0124)] public float LineHeightPercentage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNamedSlotBinding
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public UWidget* Content;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAnimationEventBinding
{
    [FieldOffset(0x0000)] public UWidgetAnimation* Animation;
    [FieldOffset(0x0018)] public EWidgetAnimationEvent AnimationEvent;
    [FieldOffset(0x001C)] public FName UserTag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FPaintContext
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x260)] 
public unsafe struct UUserWidget
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0110)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x0130)] public FSlateColor ForegroundColor;
    [FieldOffset(0x0190)] public FMargin Padding;
    [FieldOffset(0x01A0)] public TArray<IntPtr> ActiveSequencePlayers;
    [FieldOffset(0x01B0)] public UUMGSequenceTickManager* AnimationTickManager;
    [FieldOffset(0x01B8)] public TArray<IntPtr> StoppedSequencePlayers;
    [FieldOffset(0x01C8)] public TArray<FNamedSlotBinding> NamedSlotBindings;
    [FieldOffset(0x01D8)] public UWidgetTree* WidgetTree;
    [FieldOffset(0x01E0)] public int Priority;
    [FieldOffset(0x01E4)] public byte bSupportsKeyboardFocus;
    [FieldOffset(0x01E4)] public byte bIsFocusable;
    [FieldOffset(0x01E4)] public byte bStopAction;
    [FieldOffset(0x01E4)] public byte bHasScriptImplementedTick;
    [FieldOffset(0x01E4)] public byte bHasScriptImplementedPaint;
    [FieldOffset(0x01F0)] public EWidgetTickFrequency TickFrequency;
    [FieldOffset(0x01F8)] public UInputComponent* InputComponent;
    [FieldOffset(0x0200)] public TArray<FAnimationEventBinding> AnimationCallbacks;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UAsyncTaskDownloadImage
{
    [FieldOffset(0x0000)] public UBlueprintAsyncActionBase baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UPanelWidget
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public TArray<IntPtr> Slots;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UContentWidget
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UBackgroundBlur
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public FMargin Padding;
    [FieldOffset(0x0130)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0131)] public EVerticalAlignment VerticalAlignment;
    [FieldOffset(0x0132)] public bool bApplyAlphaToBlur;
    [FieldOffset(0x0134)] public float BlurStrength;
    [FieldOffset(0x0138)] public bool bOverrideAutoRadiusCalculation;
    [FieldOffset(0x013C)] public int BlurRadius;
    [FieldOffset(0x0140)] public FSlateBrush LowQualityFallbackBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UPanelSlot
{
    [FieldOffset(0x0000)] public UVisual baseObj;
    [FieldOffset(0x0028)] public UPanelWidget* Parent;
    [FieldOffset(0x0030)] public UWidget* Content;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBackgroundBlurSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FDynamicPropertyPath
{
    [FieldOffset(0x0000)] public FCachedPropertyPath baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UPropertyBinding
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TWeakObjectPtr<UObject> SourceObject;
    [FieldOffset(0x0030)] public FDynamicPropertyPath SourcePath;
    [FieldOffset(0x0058)] public FName DestinationProperty;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBoolBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct UBorder
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0121)] public EVerticalAlignment VerticalAlignment;
    [FieldOffset(0x0122)] public byte bShowEffectWhenDisabled;
    [FieldOffset(0x0124)] public FLinearColor ContentColorAndOpacity;
    [FieldOffset(0x0144)] public FMargin Padding;
    [FieldOffset(0x0158)] public FSlateBrush BackGround;
    [FieldOffset(0x01F0)] public FLinearColor BrushColor;
    [FieldOffset(0x0210)] public FVector2D DesiredSizeScale;
    [FieldOffset(0x0218)] public bool bFlipForRightToLeftFlowDirection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UBorderSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UBrushBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x428)] 
public unsafe struct UButton
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0128)] public FButtonStyle WidgetStyle;
    [FieldOffset(0x03A0)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x03B0)] public FLinearColor BackgroundColor;
    [FieldOffset(0x03C0)] public EButtonClickMethod ClickMethod;
    [FieldOffset(0x03C1)] public EButtonTouchMethod TouchMethod;
    [FieldOffset(0x03C2)] public EButtonPressMethod PressMethod;
    [FieldOffset(0x03C3)] public bool IsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UButtonSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UCanvasPanel
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FAnchorData
{
    [FieldOffset(0x0000)] public FMargin Offsets;
    [FieldOffset(0x0010)] public FAnchors Anchors;
    [FieldOffset(0x0020)] public FVector2D Alignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UCanvasPanelSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FAnchorData LayoutData;
    [FieldOffset(0x0060)] public bool bAutoSize;
    [FieldOffset(0x0064)] public int ZOrder;
}

[StructLayout(LayoutKind.Explicit, Size = 0x770)] 
public unsafe struct UCheckBox
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public ECheckBoxState CheckedState;
    [FieldOffset(0x0138)] public FCheckBoxStyle WidgetStyle;
    [FieldOffset(0x06B8)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x06C0)] public USlateBrushAsset* UncheckedImage;
    [FieldOffset(0x06C8)] public USlateBrushAsset* UncheckedHoveredImage;
    [FieldOffset(0x06D0)] public USlateBrushAsset* UncheckedPressedImage;
    [FieldOffset(0x06D8)] public USlateBrushAsset* CheckedImage;
    [FieldOffset(0x06E0)] public USlateBrushAsset* CheckedHoveredImage;
    [FieldOffset(0x06E8)] public USlateBrushAsset* CheckedPressedImage;
    [FieldOffset(0x06F0)] public USlateBrushAsset* UndeterminedImage;
    [FieldOffset(0x06F8)] public USlateBrushAsset* UndeterminedHoveredImage;
    [FieldOffset(0x0700)] public USlateBrushAsset* UndeterminedPressedImage;
    [FieldOffset(0x0708)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x070C)] public FMargin Padding;
    [FieldOffset(0x0720)] public FSlateColor BorderBackgroundColor;
    [FieldOffset(0x0748)] public EButtonClickMethod ClickMethod;
    [FieldOffset(0x0749)] public EButtonTouchMethod TouchMethod;
    [FieldOffset(0x074A)] public EButtonPressMethod PressMethod;
    [FieldOffset(0x074B)] public bool IsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UCheckedStateBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C0)] 
public unsafe struct UCircularThrobber
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public int NumberOfPieces;
    [FieldOffset(0x010C)] public float Period;
    [FieldOffset(0x0110)] public float Radius;
    [FieldOffset(0x0118)] public USlateBrushAsset* PieceImage;
    [FieldOffset(0x0120)] public FSlateBrush Image;
    [FieldOffset(0x01A8)] public bool bEnableRadius;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UColorBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UComboBox
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public TArray<IntPtr> Items;
    [FieldOffset(0x0128)] public bool bIsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE00)] 
public unsafe struct UComboBoxString
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public TArray<FString> DefaultOptions;
    [FieldOffset(0x0118)] public FString SelectedOption;
    [FieldOffset(0x0128)] public FComboBoxStyle WidgetStyle;
    [FieldOffset(0x0518)] public FTableRowStyle ItemStyle;
    [FieldOffset(0x0CE0)] public FMargin ContentPadding;
    [FieldOffset(0x0CF0)] public float MaxListHeight;
    [FieldOffset(0x0CF4)] public bool HasDownArrow;
    [FieldOffset(0x0CF5)] public bool EnableGamepadNavigationMode;
    [FieldOffset(0x0CF8)] public FSlateFontInfo Font;
    [FieldOffset(0x0D50)] public FSlateColor ForegroundColor;
    [FieldOffset(0x0D78)] public bool bIsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct UDragDropOperation
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString Tag;
    [FieldOffset(0x0038)] public UObject* Payload;
    [FieldOffset(0x0040)] public UWidget* DefaultDragVisual;
    [FieldOffset(0x0048)] public EDragPivot Pivot;
    [FieldOffset(0x004C)] public FVector2D Offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSlateChildSize
{
    [FieldOffset(0x0000)] public float Value;
    [FieldOffset(0x0004)] public ESlateSizeRule SizeRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRadialBoxSettings
{
    [FieldOffset(0x0000)] public float StartingAngle;
    [FieldOffset(0x0004)] public bool bDistributeItemsEvenly;
    [FieldOffset(0x0008)] public float AngleBetweenItems;
    [FieldOffset(0x000C)] public float SectorCentralAngle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct FUserWidgetPool
{
    [FieldOffset(0x0000)] public TArray<IntPtr> ActiveWidgets;
    [FieldOffset(0x0010)] public TArray<IntPtr> InactiveWidgets;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D8)] 
public unsafe struct UDynamicEntryBoxBase
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public EDynamicBoxType EntryBoxType;
    [FieldOffset(0x010C)] public FVector2D EntrySpacing;
    [FieldOffset(0x0118)] public TArray<FVector2D> SpacingPattern;
    [FieldOffset(0x0128)] public FSlateChildSize EntrySizeRule;
    [FieldOffset(0x0130)] public EHorizontalAlignment EntryHorizontalAlignment;
    [FieldOffset(0x0131)] public EVerticalAlignment EntryVerticalAlignment;
    [FieldOffset(0x0134)] public int MaxElementSize;
    [FieldOffset(0x0138)] public FRadialBoxSettings RadialBoxSettings;
    [FieldOffset(0x0158)] public FUserWidgetPool EntryWidgetPool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E0)] 
public unsafe struct UDynamicEntryBox
{
    [FieldOffset(0x0000)] public UDynamicEntryBoxBase baseObj;
    [FieldOffset(0x01D8)] public TSubclassOf<UUserWidget> EntryWidgetClass;
}

[StructLayout(LayoutKind.Explicit, Size = 0x460)] 
public unsafe struct UEditableText
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FText Text;
    [FieldOffset(0x0130)] public FText HintText;
    [FieldOffset(0x0158)] public FEditableTextStyle WidgetStyle;
    [FieldOffset(0x0378)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0380)] public USlateBrushAsset* BackgroundImageSelected;
    [FieldOffset(0x0388)] public USlateBrushAsset* BackgroundImageComposing;
    [FieldOffset(0x0390)] public USlateBrushAsset* CaretImage;
    [FieldOffset(0x0398)] public FSlateFontInfo Font;
    [FieldOffset(0x03F0)] public FSlateColor ColorAndOpacity;
    [FieldOffset(0x0418)] public bool IsReadOnly;
    [FieldOffset(0x0419)] public bool IsPassword;
    [FieldOffset(0x041C)] public float MinimumDesiredWidth;
    [FieldOffset(0x0420)] public bool IsCaretMovedWhenGainFocus;
    [FieldOffset(0x0421)] public bool SelectAllTextWhenFocused;
    [FieldOffset(0x0422)] public bool RevertTextOnEscape;
    [FieldOffset(0x0423)] public bool ClearKeyboardFocusOnCommit;
    [FieldOffset(0x0424)] public bool SelectAllTextOnCommit;
    [FieldOffset(0x0425)] public bool AllowContextMenu;
    [FieldOffset(0x0426)] public EVirtualKeyboardType KeyboardType;
    [FieldOffset(0x0427)] public FVirtualKeyboardOptions VirtualKeyboardOptions;
    [FieldOffset(0x0428)] public EVirtualKeyboardTrigger VirtualKeyboardTrigger;
    [FieldOffset(0x0429)] public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
    [FieldOffset(0x042A)] public ETextJustify Justification;
    [FieldOffset(0x042B)] public FShapedTextOptions ShapedTextOptions;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA38)] 
public unsafe struct UEditableTextBox
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FText Text;
    [FieldOffset(0x0130)] public FEditableTextBoxStyle WidgetStyle;
    [FieldOffset(0x0928)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0930)] public FText HintText;
    [FieldOffset(0x0958)] public FSlateFontInfo Font;
    [FieldOffset(0x09B0)] public FLinearColor ForegroundColor;
    [FieldOffset(0x09C0)] public FLinearColor BackgroundColor;
    [FieldOffset(0x09D0)] public FLinearColor ReadOnlyForegroundColor;
    [FieldOffset(0x09E0)] public bool IsReadOnly;
    [FieldOffset(0x09E1)] public bool IsPassword;
    [FieldOffset(0x09E4)] public float MinimumDesiredWidth;
    [FieldOffset(0x09E8)] public FMargin Padding;
    [FieldOffset(0x09F8)] public bool IsCaretMovedWhenGainFocus;
    [FieldOffset(0x09F9)] public bool SelectAllTextWhenFocused;
    [FieldOffset(0x09FA)] public bool RevertTextOnEscape;
    [FieldOffset(0x09FB)] public bool ClearKeyboardFocusOnCommit;
    [FieldOffset(0x09FC)] public bool SelectAllTextOnCommit;
    [FieldOffset(0x09FD)] public bool AllowContextMenu;
    [FieldOffset(0x09FE)] public EVirtualKeyboardType KeyboardType;
    [FieldOffset(0x09FF)] public FVirtualKeyboardOptions VirtualKeyboardOptions;
    [FieldOffset(0x0A00)] public EVirtualKeyboardTrigger VirtualKeyboardTrigger;
    [FieldOffset(0x0A01)] public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
    [FieldOffset(0x0A02)] public ETextJustify Justification;
    [FieldOffset(0x0A03)] public FShapedTextOptions ShapedTextOptions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x338)] 
public unsafe struct UExpandableArea
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0110)] public FExpandableAreaStyle Style;
    [FieldOffset(0x0230)] public FSlateBrush BorderBrush;
    [FieldOffset(0x02B8)] public FSlateColor BorderColor;
    [FieldOffset(0x02E0)] public bool bIsExpanded;
    [FieldOffset(0x02E4)] public float MaxHeight;
    [FieldOffset(0x02E8)] public FMargin HeaderPadding;
    [FieldOffset(0x02F8)] public FMargin AreaPadding;
    [FieldOffset(0x0318)] public UWidget* HeaderContent;
    [FieldOffset(0x0320)] public UWidget* BodyContent;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UFloatBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct UGridPanel
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
    [FieldOffset(0x0120)] public TArray<float> ColumnFill;
    [FieldOffset(0x0130)] public TArray<float> RowFill;
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct UGridSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
    [FieldOffset(0x004C)] public int Row;
    [FieldOffset(0x0050)] public int RowSpan;
    [FieldOffset(0x0054)] public int Column;
    [FieldOffset(0x0058)] public int ColumnSpan;
    [FieldOffset(0x005C)] public int Layer;
    [FieldOffset(0x0060)] public FVector2D Nudge;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UHorizontalBox
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UHorizontalBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0040)] public FMargin Padding;
    [FieldOffset(0x0050)] public FSlateChildSize Size;
    [FieldOffset(0x0058)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0059)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x210)] 
public unsafe struct UImage
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FSlateBrush Brush;
    [FieldOffset(0x01A0)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x01C0)] public bool bFlipForRightToLeftFlowDirection;
}

[StructLayout(LayoutKind.Explicit, Size = 0x700)] 
public unsafe struct UInputKeySelector
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FButtonStyle WidgetStyle;
    [FieldOffset(0x0380)] public FTextBlockStyle TextStyle;
    [FieldOffset(0x05F0)] public FInputChord SelectedKey;
    [FieldOffset(0x0610)] public FSlateFontInfo Font;
    [FieldOffset(0x0668)] public FMargin Margin;
    [FieldOffset(0x0678)] public FLinearColor ColorAndOpacity;
    [FieldOffset(0x0688)] public FText KeySelectionText;
    [FieldOffset(0x06A0)] public FText NoKeySpecifiedText;
    [FieldOffset(0x06B8)] public bool bAllowModifierKeys;
    [FieldOffset(0x06B9)] public bool bAllowGamepadKeys;
    [FieldOffset(0x06C0)] public TArray<FKey> EscapeKeys;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UInt32Binding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UInvalidationBox
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public bool bCanCache;
    [FieldOffset(0x0121)] public bool CacheRelativeTransforms;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IUserListEntry
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUserListEntryLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IUserObjectListEntry
{
    [FieldOffset(0x0000)] public IUserListEntry baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UUserObjectListEntryLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x218)] 
public unsafe struct UListViewBase
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public TSubclassOf<UUserWidget> EntryWidgetClass;
    [FieldOffset(0x0110)] public float WheelScrollMultiplier;
    [FieldOffset(0x0114)] public bool bEnableScrollAnimation;
    [FieldOffset(0x0115)] public bool bEnableFixedLineOffset;
    [FieldOffset(0x0118)] public float FixedLineScrollOffset;
    [FieldOffset(0x0140)] public FUserWidgetPool EntryWidgetPool;
}

[StructLayout(LayoutKind.Explicit, Size = 0x368)] 
public unsafe struct UListView
{
    [FieldOffset(0x0000)] public UListViewBase baseObj;
    [FieldOffset(0x02D8)] public EOrientation Orientation;
    [FieldOffset(0x02D9)] public ESelectionMode SelectionMode;
    [FieldOffset(0x02DA)] public EConsumeMouseWheel ConsumeMouseWheel;
    [FieldOffset(0x02DB)] public bool bClearSelectionOnClick;
    [FieldOffset(0x02DC)] public bool bIsFocusable;
    [FieldOffset(0x02E0)] public float EntrySpacing;
    [FieldOffset(0x02E4)] public bool bReturnFocusToSelection;
    [FieldOffset(0x02E8)] public TArray<IntPtr> ListItems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UListViewDesignerPreviewItem
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x170)] 
public unsafe struct UMenuAnchor
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public TSubclassOf<UUserWidget> MenuClass;
    [FieldOffset(0x0148)] public EMenuPlacement Placement;
    [FieldOffset(0x0149)] public bool bFitInWindow;
    [FieldOffset(0x014A)] public bool ShouldDeferPaintingAfterWindowContent;
    [FieldOffset(0x014B)] public bool UseApplicationMenuStack;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UMouseCursorBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieScene2DTransformPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FMovieScene2DTransformMask
{
    [FieldOffset(0x0000)] public uint Mask;
}

[StructLayout(LayoutKind.Explicit, Size = 0x558)] 
public unsafe struct UMovieScene2DTransformSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieScene2DTransformMask TransformMask;
    [FieldOffset(0x00F8)] public FMovieSceneFloatChannel Translation;
    [FieldOffset(0x0238)] public FMovieSceneFloatChannel Rotation;
    [FieldOffset(0x02D8)] public FMovieSceneFloatChannel Scale;
    [FieldOffset(0x0418)] public FMovieSceneFloatChannel Shear;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieScene2DTransformTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UMovieSceneMarginPropertySystem
{
    [FieldOffset(0x0000)] public UMovieScenePropertySystem baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x370)] 
public unsafe struct UMovieSceneMarginSection
{
    [FieldOffset(0x0000)] public UMovieSceneSection baseObj;
    [FieldOffset(0x00F0)] public FMovieSceneFloatChannel TopCurve;
    [FieldOffset(0x0190)] public FMovieSceneFloatChannel LeftCurve;
    [FieldOffset(0x0230)] public FMovieSceneFloatChannel RightCurve;
    [FieldOffset(0x02D0)] public FMovieSceneFloatChannel BottomCurve;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneMarginTrack
{
    [FieldOffset(0x0000)] public UMovieScenePropertyTrack baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC0)] 
public unsafe struct UMovieSceneWidgetMaterialTrack
{
    [FieldOffset(0x0000)] public UMovieSceneMaterialTrack baseObj;
    [FieldOffset(0x00A8)] public TArray<FName> BrushPropertyNamePath;
    [FieldOffset(0x00B8)] public FName TrackName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x470)] 
public unsafe struct UMultiLineEditableText
{
    [FieldOffset(0x0000)] public UTextLayoutWidget baseObj;
    [FieldOffset(0x0128)] public FText Text;
    [FieldOffset(0x0140)] public FText HintText;
    [FieldOffset(0x0168)] public FTextBlockStyle WidgetStyle;
    [FieldOffset(0x03D8)] public bool bIsReadOnly;
    [FieldOffset(0x03E0)] public FSlateFontInfo Font;
    [FieldOffset(0x0438)] public bool SelectAllTextWhenFocused;
    [FieldOffset(0x0439)] public bool ClearTextSelectionOnFocusLoss;
    [FieldOffset(0x043A)] public bool RevertTextOnEscape;
    [FieldOffset(0x043B)] public bool ClearKeyboardFocusOnCommit;
    [FieldOffset(0x043C)] public bool AllowContextMenu;
    [FieldOffset(0x043D)] public FVirtualKeyboardOptions VirtualKeyboardOptions;
    [FieldOffset(0x043E)] public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC98)] 
public unsafe struct UMultiLineEditableTextBox
{
    [FieldOffset(0x0000)] public UTextLayoutWidget baseObj;
    [FieldOffset(0x0128)] public FText Text;
    [FieldOffset(0x0140)] public FText HintText;
    [FieldOffset(0x0168)] public FEditableTextBoxStyle WidgetStyle;
    [FieldOffset(0x0960)] public FTextBlockStyle TextStyle;
    [FieldOffset(0x0BD0)] public bool bIsReadOnly;
    [FieldOffset(0x0BD1)] public bool AllowContextMenu;
    [FieldOffset(0x0BD2)] public FVirtualKeyboardOptions VirtualKeyboardOptions;
    [FieldOffset(0x0BD3)] public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
    [FieldOffset(0x0BD8)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0BE0)] public FSlateFontInfo Font;
    [FieldOffset(0x0C38)] public FLinearColor ForegroundColor;
    [FieldOffset(0x0C48)] public FLinearColor BackgroundColor;
    [FieldOffset(0x0C58)] public FLinearColor ReadOnlyForegroundColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UNamedSlot
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct INamedSlotInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct UNativeWidgetHost
{
    [FieldOffset(0x0000)] public UWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UOverlay
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UOverlaySlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0040)] public FMargin Padding;
    [FieldOffset(0x0050)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0051)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct UProgressBar
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FProgressBarStyle WidgetStyle;
    [FieldOffset(0x02A8)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x02B0)] public USlateBrushAsset* BackgroundImage;
    [FieldOffset(0x02B8)] public USlateBrushAsset* FillImage;
    [FieldOffset(0x02C0)] public USlateBrushAsset* MarqueeImage;
    [FieldOffset(0x02C8)] public float percent;
    [FieldOffset(0x02CC)] public EProgressBarFillType BarFillType;
    [FieldOffset(0x02CD)] public bool bIsMarquee;
    [FieldOffset(0x02D0)] public FVector2D BorderPadding;
    [FieldOffset(0x02E8)] public FLinearColor FillColorAndOpacity;
}

[StructLayout(LayoutKind.Explicit, Size = 0x150)] 
public unsafe struct URetainerBox
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public bool bRetainRender;
    [FieldOffset(0x0121)] public bool RenderOnInvalidation;
    [FieldOffset(0x0122)] public bool RenderOnPhase;
    [FieldOffset(0x0124)] public int phase;
    [FieldOffset(0x0128)] public int PhaseCount;
    [FieldOffset(0x0130)] public UMaterialInterface* EffectMaterial;
    [FieldOffset(0x0138)] public FName TextureParameter;
}

[StructLayout(LayoutKind.Explicit, Size = 0x678)] 
public unsafe struct URichTextBlock
{
    [FieldOffset(0x0000)] public UTextLayoutWidget baseObj;
    [FieldOffset(0x0128)] public FText Text;
    [FieldOffset(0x0140)] public UDataTable* TextStyleSet;
    [FieldOffset(0x0148)] public TArray<TSubclassOf<URichTextBlockDecorator>> DecoratorClasses;
    [FieldOffset(0x0158)] public bool bOverrideDefaultStyle;
    [FieldOffset(0x0160)] public FTextBlockStyle DefaultTextStyleOverride;
    [FieldOffset(0x03D0)] public float MinDesiredWidth;
    [FieldOffset(0x03D4)] public ETextTransformPolicy TextTransformPolicy;
    [FieldOffset(0x03D8)] public FTextBlockStyle DefaultTextStyle;
    [FieldOffset(0x0648)] public TArray<IntPtr> InstanceDecorators;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct URichTextBlockDecorator
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct URichTextBlockImageDecorator
{
    [FieldOffset(0x0000)] public URichTextBlockDecorator baseObj;
    [FieldOffset(0x0028)] public UDataTable* ImageSet;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct USafeZone
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public bool PadLeft;
    [FieldOffset(0x0121)] public bool PadRight;
    [FieldOffset(0x0122)] public bool PadTop;
    [FieldOffset(0x0123)] public bool PadBottom;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USafeZoneSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public bool bIsTitleSafe;
    [FieldOffset(0x003C)] public FMargin SafeAreaScale;
    [FieldOffset(0x004C)] public EHorizontalAlignment HAlign;
    [FieldOffset(0x004D)] public EVerticalAlignment VAlign;
    [FieldOffset(0x0050)] public FMargin Padding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UScaleBox
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public EStretch Stretch;
    [FieldOffset(0x0121)] public EStretchDirection StretchDirection;
    [FieldOffset(0x0124)] public float UserSpecifiedScale;
    [FieldOffset(0x0128)] public bool IgnoreInheritedScale;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UScaleBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x610)] 
public unsafe struct UScrollBar
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FScrollBarStyle WidgetStyle;
    [FieldOffset(0x05D8)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x05E0)] public bool bAlwaysShowScrollbar;
    [FieldOffset(0x05E1)] public bool bAlwaysShowScrollbarTrack;
    [FieldOffset(0x05E2)] public EOrientation Orientation;
    [FieldOffset(0x05E4)] public FVector2D Thickness;
    [FieldOffset(0x05EC)] public FMargin Padding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x880)] 
public unsafe struct UScrollBox
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
    [FieldOffset(0x0120)] public FScrollBoxStyle WidgetStyle;
    [FieldOffset(0x0348)] public FScrollBarStyle WidgetBarStyle;
    [FieldOffset(0x0818)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0820)] public USlateWidgetStyleAsset* BarStyle;
    [FieldOffset(0x0828)] public EOrientation Orientation;
    [FieldOffset(0x0829)] public ESlateVisibility ScrollBarVisibility;
    [FieldOffset(0x082A)] public EConsumeMouseWheel ConsumeMouseWheel;
    [FieldOffset(0x082C)] public FVector2D ScrollbarThickness;
    [FieldOffset(0x0834)] public FMargin ScrollbarPadding;
    [FieldOffset(0x0844)] public bool AlwaysShowScrollbar;
    [FieldOffset(0x0845)] public bool AlwaysShowScrollbarTrack;
    [FieldOffset(0x0846)] public bool AllowOverscroll;
    [FieldOffset(0x0847)] public bool bAnimateWheelScrolling;
    [FieldOffset(0x0848)] public EDescendantScrollDestination NavigationDestination;
    [FieldOffset(0x084C)] public float NavigationScrollPadding;
    [FieldOffset(0x0850)] public EScrollWhenFocusChanges ScrollWhenFocusChanges;
    [FieldOffset(0x0851)] public bool bAllowRightClickDragScrolling;
    [FieldOffset(0x0854)] public float WheelScrollMultiplier;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UScrollBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x158)] 
public unsafe struct USizeBox
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0130)] public float WidthOverride;
    [FieldOffset(0x0134)] public float HeightOverride;
    [FieldOffset(0x0138)] public float MinDesiredWidth;
    [FieldOffset(0x013C)] public float MinDesiredHeight;
    [FieldOffset(0x0140)] public float MaxDesiredWidth;
    [FieldOffset(0x0144)] public float MaxDesiredHeight;
    [FieldOffset(0x0148)] public float MinAspectRatio;
    [FieldOffset(0x014C)] public float MaxAspectRatio;
    [FieldOffset(0x0150)] public byte bOverride_WidthOverride;
    [FieldOffset(0x0150)] public byte bOverride_HeightOverride;
    [FieldOffset(0x0150)] public byte bOverride_MinDesiredWidth;
    [FieldOffset(0x0150)] public byte bOverride_MinDesiredHeight;
    [FieldOffset(0x0150)] public byte bOverride_MaxDesiredWidth;
    [FieldOffset(0x0150)] public byte bOverride_MaxDesiredHeight;
    [FieldOffset(0x0150)] public byte bOverride_MinAspectRatio;
    [FieldOffset(0x0150)] public byte bOverride_MaxAspectRatio;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USizeBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0058)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0059)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USlateBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C)] 
public unsafe struct FSlateMeshVertex
{
    [FieldOffset(0x0000)] public FVector2D Position;
    [FieldOffset(0x0008)] public FColor Color;
    [FieldOffset(0x000C)] public FVector2D UV0;
    [FieldOffset(0x0014)] public FVector2D UV1;
    [FieldOffset(0x001C)] public FVector2D UV2;
    [FieldOffset(0x0024)] public FVector2D UV3;
    [FieldOffset(0x002C)] public FVector2D UV4;
    [FieldOffset(0x0034)] public FVector2D UV5;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct USlateVectorArtData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FSlateMeshVertex> VertexData;
    [FieldOffset(0x0038)] public TArray<uint> IndexData;
    [FieldOffset(0x0048)] public UMaterialInterface* Material;
    [FieldOffset(0x0050)] public FVector2D ExtentMin;
    [FieldOffset(0x0058)] public FVector2D ExtentMax;
}

[StructLayout(LayoutKind.Explicit, Size = 0x80)] 
public unsafe struct USlateAccessibleWidgetData
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bCanChildrenBeAccessible;
    [FieldOffset(0x0029)] public ESlateAccessibleBehavior AccessibleBehavior;
    [FieldOffset(0x002A)] public ESlateAccessibleBehavior AccessibleSummaryBehavior;
    [FieldOffset(0x0030)] public FText AccessibleText;
    [FieldOffset(0x0058)] public FText AccessibleSummaryText;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4F8)] 
public unsafe struct USlider
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public float Value;
    [FieldOffset(0x011C)] public float MinValue;
    [FieldOffset(0x0120)] public float MaxValue;
    [FieldOffset(0x0128)] public FSliderStyle WidgetStyle;
    [FieldOffset(0x0468)] public EOrientation Orientation;
    [FieldOffset(0x046C)] public FLinearColor SliderBarColor;
    [FieldOffset(0x047C)] public FLinearColor SliderHandleColor;
    [FieldOffset(0x048C)] public bool IndentHandle;
    [FieldOffset(0x048D)] public bool Locked;
    [FieldOffset(0x048E)] public bool MouseUsesStep;
    [FieldOffset(0x048F)] public bool RequiresControllerLock;
    [FieldOffset(0x0490)] public float StepSize;
    [FieldOffset(0x0494)] public bool IsFocusable;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct USpacer
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public FVector2D Size;
}

[StructLayout(LayoutKind.Explicit, Size = 0x520)] 
public unsafe struct USpinBox
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public float Value;
    [FieldOffset(0x0120)] public FSpinBoxStyle WidgetStyle;
    [FieldOffset(0x0408)] public USlateWidgetStyleAsset* Style;
    [FieldOffset(0x0410)] public int MinFractionalDigits;
    [FieldOffset(0x0414)] public int MaxFractionalDigits;
    [FieldOffset(0x0418)] public bool bAlwaysUsesDeltaSnap;
    [FieldOffset(0x041C)] public float Delta;
    [FieldOffset(0x0420)] public float SliderExponent;
    [FieldOffset(0x0428)] public FSlateFontInfo Font;
    [FieldOffset(0x0480)] public ETextJustify Justification;
    [FieldOffset(0x0484)] public float MinDesiredWidth;
    [FieldOffset(0x0488)] public bool ClearKeyboardFocusOnCommit;
    [FieldOffset(0x0489)] public bool SelectAllTextOnCommit;
    [FieldOffset(0x0490)] public FSlateColor ForegroundColor;
    [FieldOffset(0x04F8)] public byte bOverride_MinValue;
    [FieldOffset(0x04F8)] public byte bOverride_MaxValue;
    [FieldOffset(0x04F8)] public byte bOverride_MinSliderValue;
    [FieldOffset(0x04F8)] public byte bOverride_MaxSliderValue;
    [FieldOffset(0x04FC)] public float MinValue;
    [FieldOffset(0x0500)] public float MaxValue;
    [FieldOffset(0x0504)] public float MinSliderValue;
    [FieldOffset(0x0508)] public float MaxSliderValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct UTextBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct UTextBlock
{
    [FieldOffset(0x0000)] public UTextLayoutWidget baseObj;
    [FieldOffset(0x0128)] public FText Text;
    [FieldOffset(0x0150)] public FSlateColor ColorAndOpacity;
    [FieldOffset(0x0188)] public FSlateFontInfo Font;
    [FieldOffset(0x01E0)] public FSlateBrush StrikeBrush;
    [FieldOffset(0x0268)] public FVector2D ShadowOffset;
    [FieldOffset(0x0270)] public FLinearColor ShadowColorAndOpacity;
    [FieldOffset(0x0290)] public float MinDesiredWidth;
    [FieldOffset(0x0294)] public bool bWrapWithInvalidationPanel;
    [FieldOffset(0x0295)] public bool bAutoWrapText;
    [FieldOffset(0x0296)] public ETextTransformPolicy TextTransformPolicy;
    [FieldOffset(0x0297)] public bool bSimpleTextMode;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1B0)] 
public unsafe struct UThrobber
{
    [FieldOffset(0x0000)] public UWidget baseObj;
    [FieldOffset(0x0108)] public int NumberOfPieces;
    [FieldOffset(0x010C)] public bool bAnimateHorizontally;
    [FieldOffset(0x010D)] public bool bAnimateVertically;
    [FieldOffset(0x010E)] public bool bAnimateOpacity;
    [FieldOffset(0x0110)] public USlateBrushAsset* PieceImage;
    [FieldOffset(0x0118)] public FSlateBrush Image;
}

[StructLayout(LayoutKind.Explicit, Size = 0x388)] 
public unsafe struct UTileView
{
    [FieldOffset(0x0000)] public UListView baseObj;
    [FieldOffset(0x0368)] public float EntryHeight;
    [FieldOffset(0x036C)] public float EntryWidth;
    [FieldOffset(0x0370)] public EListItemAlignment TileAlignment;
    [FieldOffset(0x0371)] public bool bWrapHorizontalNavigation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C0)] 
public unsafe struct UTreeView
{
    [FieldOffset(0x0000)] public UListView baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3C8)] 
public unsafe struct UUMGSequencePlayer
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0260)] public UWidgetAnimation* Animation;
    [FieldOffset(0x0270)] public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UUMGSequenceTickManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TSet<TWeakObjectPtr<UUserWidget>> WeakUserWidgets;
    [FieldOffset(0x0078)] public UMovieSceneEntitySystemLinker* Linker;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UUniformGridPanel
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
    [FieldOffset(0x0120)] public FMargin SlotPadding;
    [FieldOffset(0x0130)] public float MinDesiredSlotWidth;
    [FieldOffset(0x0134)] public float MinDesiredSlotHeight;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UUniformGridSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0039)] public EVerticalAlignment VerticalAlignment;
    [FieldOffset(0x003C)] public int Row;
    [FieldOffset(0x0040)] public int Column;
}

[StructLayout(LayoutKind.Explicit, Size = 0x130)] 
public unsafe struct UVerticalBox
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UVerticalBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FSlateChildSize Size;
    [FieldOffset(0x0040)] public FMargin Padding;
    [FieldOffset(0x0058)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0059)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x168)] 
public unsafe struct UViewport
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public FLinearColor BackgroundColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UVisibilityBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FWidgetAnimationBinding
{
    [FieldOffset(0x0000)] public FName WidgetName;
    [FieldOffset(0x0008)] public FName SlotWidgetName;
    [FieldOffset(0x0010)] public FGuid AnimationGuid;
    [FieldOffset(0x0020)] public bool bIsRootWidget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct UWidgetAnimation
{
    [FieldOffset(0x0000)] public UMovieSceneSequence baseObj;
    [FieldOffset(0x0060)] public UMovieScene* MovieScene;
    [FieldOffset(0x0068)] public TArray<FWidgetAnimationBinding> AnimationBindings;
    [FieldOffset(0x0078)] public bool bLegacyFinishOnStop;
    [FieldOffset(0x0080)] public FString DisplayLabel;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C)] 
public unsafe struct FBlueprintWidgetAnimationDelegateBinding
{
    [FieldOffset(0x0000)] public EWidgetAnimationEvent Action;
    [FieldOffset(0x0004)] public FName AnimationToBind;
    [FieldOffset(0x000C)] public FName FunctionNameToBind;
    [FieldOffset(0x0014)] public FName UserTag;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UWidgetAnimationDelegateBinding
{
    [FieldOffset(0x0000)] public UDynamicBlueprintBinding baseObj;
    [FieldOffset(0x0028)] public TArray<FBlueprintWidgetAnimationDelegateBinding> WidgetAnimationDelegateBindings;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UWidgetAnimationPlayCallbackProxy
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UWidgetBinding
{
    [FieldOffset(0x0000)] public UPropertyBinding baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FDelegateRuntimeBinding
{
    [FieldOffset(0x0000)] public FString ObjectName;
    [FieldOffset(0x0010)] public FName PropertyName;
    [FieldOffset(0x0018)] public FName FunctionName;
    [FieldOffset(0x0020)] public FDynamicPropertyPath SourcePath;
    [FieldOffset(0x0048)] public EBindingKind Kind;
}

[StructLayout(LayoutKind.Explicit, Size = 0x368)] 
public unsafe struct UWidgetBlueprintGeneratedClass
{
    [FieldOffset(0x0000)] public UBlueprintGeneratedClass baseObj;
    [FieldOffset(0x0328)] public UWidgetTree* WidgetTree;
    [FieldOffset(0x0330)] public byte bClassRequiresNativeTick;
    [FieldOffset(0x0338)] public TArray<FDelegateRuntimeBinding> Bindings;
    [FieldOffset(0x0348)] public TArray<IntPtr> Animations;
    [FieldOffset(0x0358)] public TArray<FName> NamedSlots;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UWidgetBlueprintLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5A0)] 
public unsafe struct UWidgetComponent
{
    [FieldOffset(0x0000)] public UMeshComponent baseObj;
    [FieldOffset(0x0478)] public EWidgetSpace Space;
    [FieldOffset(0x0479)] public EWidgetTimingPolicy TimingPolicy;
    [FieldOffset(0x0480)] public TSubclassOf<UUserWidget> WidgetClass;
    [FieldOffset(0x0488)] public FIntPoint DrawSize;
    [FieldOffset(0x0490)] public bool bManuallyRedraw;
    [FieldOffset(0x0491)] public bool bRedrawRequested;
    [FieldOffset(0x0494)] public float RedrawTime;
    [FieldOffset(0x04A0)] public FIntPoint CurrentDrawSize;
    [FieldOffset(0x04A8)] public bool bDrawAtDesiredSize;
    [FieldOffset(0x04AC)] public FVector2D Pivot;
    [FieldOffset(0x04B4)] public bool bReceiveHardwareInput;
    [FieldOffset(0x04B5)] public bool bWindowFocusable;
    [FieldOffset(0x04B6)] public EWindowVisibility WindowVisibility;
    [FieldOffset(0x04B7)] public bool bApplyGammaCorrection;
    [FieldOffset(0x04B8)] public ULocalPlayer* OwnerPlayer;
    [FieldOffset(0x04C0)] public FLinearColor BackgroundColor;
    [FieldOffset(0x04D0)] public FLinearColor TintColorAndOpacity;
    [FieldOffset(0x04E0)] public float OpacityFromTexture;
    [FieldOffset(0x04E4)] public EWidgetBlendMode BlendMode;
    [FieldOffset(0x04E5)] public bool bIsTwoSided;
    [FieldOffset(0x04E6)] public bool TickWhenOffscreen;
    [FieldOffset(0x04E8)] public UBodySetup* BodySetup;
    [FieldOffset(0x04F0)] public UMaterialInterface* TranslucentMaterial;
    [FieldOffset(0x04F8)] public UMaterialInterface* TranslucentMaterial_OneSided;
    [FieldOffset(0x0500)] public UMaterialInterface* OpaqueMaterial;
    [FieldOffset(0x0508)] public UMaterialInterface* OpaqueMaterial_OneSided;
    [FieldOffset(0x0510)] public UMaterialInterface* MaskedMaterial;
    [FieldOffset(0x0518)] public UMaterialInterface* MaskedMaterial_OneSided;
    [FieldOffset(0x0520)] public UTextureRenderTarget2D* RenderTarget;
    [FieldOffset(0x0528)] public UMaterialInstanceDynamic* MaterialInstance;
    [FieldOffset(0x0530)] public bool bAddedToScreen;
    [FieldOffset(0x0531)] public bool bEditTimeUsable;
    [FieldOffset(0x0534)] public FName SharedLayerName;
    [FieldOffset(0x053C)] public int LayerZOrder;
    [FieldOffset(0x0540)] public EWidgetGeometryMode GeometryMode;
    [FieldOffset(0x0544)] public float CylinderArcAngle;
    [FieldOffset(0x0548)] public ETickMode TickMode;
    [FieldOffset(0x0570)] public UUserWidget* Widget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F0)] 
public unsafe struct UWidgetInteractionComponent
{
    [FieldOffset(0x0000)] public USceneComponent baseObj;
    [FieldOffset(0x0218)] public int VirtualUserIndex;
    [FieldOffset(0x021C)] public int PointerIndex;
    [FieldOffset(0x0220)] public ECollisionChannel TraceChannel;
    [FieldOffset(0x0224)] public float InteractionDistance;
    [FieldOffset(0x0228)] public EWidgetInteractionSource InteractionSource;
    [FieldOffset(0x0229)] public bool bEnableHitTesting;
    [FieldOffset(0x022A)] public bool bShowDebug;
    [FieldOffset(0x022C)] public float DebugSphereLineThickness;
    [FieldOffset(0x0230)] public float DebugLineThickness;
    [FieldOffset(0x0234)] public FLinearColor DebugColor;
    [FieldOffset(0x02C0)] public FHitResult CustomHitResult;
    [FieldOffset(0x0348)] public FVector2D LocalHitLocation;
    [FieldOffset(0x0350)] public FVector2D LastLocalHitLocation;
    [FieldOffset(0x0358)] public UWidgetComponent* HoveredWidgetComponent;
    [FieldOffset(0x0360)] public FHitResult LastHitResult;
    [FieldOffset(0x03E8)] public bool bIsHoveredWidgetInteractable;
    [FieldOffset(0x03E9)] public bool bIsHoveredWidgetFocusable;
    [FieldOffset(0x03EA)] public bool bIsHoveredWidgetHitTestVisible;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UWidgetLayoutLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x24)] 
public unsafe struct FWidgetNavigationData
{
    [FieldOffset(0x0000)] public EUINavigationRule Rule;
    [FieldOffset(0x0004)] public FName WidgetToFocus;
    [FieldOffset(0x000C)] public TWeakObjectPtr<UWidget> Widget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x100)] 
public unsafe struct UWidgetNavigation
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FWidgetNavigationData Up;
    [FieldOffset(0x004C)] public FWidgetNavigationData Down;
    [FieldOffset(0x0070)] public FWidgetNavigationData Left;
    [FieldOffset(0x0094)] public FWidgetNavigationData Right;
    [FieldOffset(0x00B8)] public FWidgetNavigationData Next;
    [FieldOffset(0x00DC)] public FWidgetNavigationData Previous;
}

[StructLayout(LayoutKind.Explicit, Size = 0x138)] 
public unsafe struct UWidgetSwitcher
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
    [FieldOffset(0x0120)] public int ActiveWidgetIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct UWidgetSwitcherSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0040)] public FMargin Padding;
    [FieldOffset(0x0050)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0051)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct UWidgetTree
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public UWidget* RootWidget;
}

[StructLayout(LayoutKind.Explicit, Size = 0x140)] 
public unsafe struct UWindowTitleBarArea
{
    [FieldOffset(0x0000)] public UContentWidget baseObj;
    [FieldOffset(0x0120)] public bool bWindowButtonsEnabled;
    [FieldOffset(0x0121)] public bool bDoubleClickTogglesFullscreen;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UWindowTitleBarAreaSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0049)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x148)] 
public unsafe struct UWrapBox
{
    [FieldOffset(0x0000)] public UPanelWidget baseObj;
    [FieldOffset(0x0120)] public FVector2D InnerSlotPadding;
    [FieldOffset(0x0128)] public float WrapWidth;
    [FieldOffset(0x012C)] public float WrapSize;
    [FieldOffset(0x0130)] public bool bExplicitWrapWidth;
    [FieldOffset(0x0131)] public bool bExplicitWrapSize;
    [FieldOffset(0x0132)] public EOrientation Orientation;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UWrapBoxSlot
{
    [FieldOffset(0x0000)] public UPanelSlot baseObj;
    [FieldOffset(0x0038)] public FMargin Padding;
    [FieldOffset(0x0048)] public bool bFillEmptySpace;
    [FieldOffset(0x004C)] public float FillSpanWhenLessThan;
    [FieldOffset(0x0050)] public EHorizontalAlignment HorizontalAlignment;
    [FieldOffset(0x0051)] public EVerticalAlignment VerticalAlignment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FMovieSceneWidgetMaterialSectionTemplate
{
    [FieldOffset(0x0000)] public FMovieSceneParameterSectionTemplate baseObj;
    [FieldOffset(0x0080)] public TArray<FName> BrushPropertyNamePath;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct FRichTextStyleRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FTextBlockStyle TextStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)] 
public unsafe struct FRichImageRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FSlateBrush Brush;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC8)] 
public unsafe struct FWidgetComponentInstanceData
{
    [FieldOffset(0x0000)] public FSceneComponentInstanceData baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x0)] 
public unsafe struct UDefault__WidgetBlueprintGeneratedClass
{
}

