using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMargin
{
    [FieldOffset(0x0000)] public float Left;
    [FieldOffset(0x0004)] public float Top;
    [FieldOffset(0x0008)] public float Right;
    [FieldOffset(0x000C)] public float Bottom;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FSlateColor
{
    [FieldOffset(0x0000)] public FLinearColor SpecifiedColor;
    [FieldOffset(0x0010)] public ESlateColorStylingMode ColorUseRule;
}

[StructLayout(LayoutKind.Explicit, Size = 0x88)] 
public unsafe struct FSlateBrush
{
    [FieldOffset(0x0008)] public FVector2D ImageSize;
    [FieldOffset(0x0010)] public FMargin Margin;
    [FieldOffset(0x0020)] public FSlateColor TintColor;
    [FieldOffset(0x0048)] public UObject* ResourceObject;
    [FieldOffset(0x0050)] public FName ResourceName;
    [FieldOffset(0x0058)] public FBox2D UVRegion;
    [FieldOffset(0x006C)] public ESlateBrushDrawType DrawAs;
    [FieldOffset(0x006D)] public ESlateBrushTileType Tiling;
    [FieldOffset(0x006E)] public ESlateBrushMirrorType Mirroring;
    [FieldOffset(0x006F)] public ESlateBrushImageType ImageType;
    [FieldOffset(0x0080)] public byte bIsDynamicallyLoaded;
    [FieldOffset(0x0080)] public byte bHasUObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FGeometry
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInputEvent
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x70)] 
public unsafe struct FPointerEvent
{
    [FieldOffset(0x0000)] public FInputEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FSlateWidgetStyle
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFontOutlineSettings
{
    [FieldOffset(0x0000)] public int OutlineSize;
    [FieldOffset(0x0004)] public bool bSeparateFillAlpha;
    [FieldOffset(0x0005)] public bool bApplyOutlineToDropShadows;
    [FieldOffset(0x0008)] public UObject* OutlineMaterial;
    [FieldOffset(0x0010)] public FLinearColor OutlineColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x58)] 
public unsafe struct FSlateFontInfo
{
    [FieldOffset(0x0000)] public UObject* FontObject;
    [FieldOffset(0x0008)] public UObject* FontMaterial;
    [FieldOffset(0x0010)] public FFontOutlineSettings OutlineSettings;
    [FieldOffset(0x0040)] public FName TypefaceFontName;
    [FieldOffset(0x0048)] public int Size;
    [FieldOffset(0x004C)] public int LetterSpacing;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FFocusEvent
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FKeyEvent
{
    [FieldOffset(0x0000)] public FInputEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FMotionEvent
{
    [FieldOffset(0x0000)] public FInputEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCharacterEvent
{
    [FieldOffset(0x0000)] public FInputEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FAnalogInputEvent
{
    [FieldOffset(0x0000)] public FKeyEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UFontBulkData
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IFontFaceInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IFontProviderInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct USlateTypes
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct USlateWidgetStyleAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public USlateWidgetStyleContainerBase* CustomStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct USlateWidgetStyleContainerBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ISlateWidgetStyleContainerInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSlateSound
{
    [FieldOffset(0x0000)] public UObject* ResourceObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x278)] 
public unsafe struct FButtonStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush Normal;
    [FieldOffset(0x0090)] public FSlateBrush Hovered;
    [FieldOffset(0x0118)] public FSlateBrush Pressed;
    [FieldOffset(0x01A0)] public FSlateBrush Disabled;
    [FieldOffset(0x0228)] public FMargin NormalPadding;
    [FieldOffset(0x0238)] public FMargin PressedPadding;
    [FieldOffset(0x0248)] public FSlateSound PressedSlateSound;
    [FieldOffset(0x0260)] public FSlateSound HoveredSlateSound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x580)] 
public unsafe struct FCheckBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public ESlateCheckBoxType CheckBoxType;
    [FieldOffset(0x0010)] public FSlateBrush UncheckedImage;
    [FieldOffset(0x0098)] public FSlateBrush UncheckedHoveredImage;
    [FieldOffset(0x0120)] public FSlateBrush UncheckedPressedImage;
    [FieldOffset(0x01A8)] public FSlateBrush CheckedImage;
    [FieldOffset(0x0230)] public FSlateBrush CheckedHoveredImage;
    [FieldOffset(0x02B8)] public FSlateBrush CheckedPressedImage;
    [FieldOffset(0x0340)] public FSlateBrush UndeterminedImage;
    [FieldOffset(0x03C8)] public FSlateBrush UndeterminedHoveredImage;
    [FieldOffset(0x0450)] public FSlateBrush UndeterminedPressedImage;
    [FieldOffset(0x04D8)] public FMargin Padding;
    [FieldOffset(0x04E8)] public FSlateColor ForegroundColor;
    [FieldOffset(0x0510)] public FSlateColor BorderBackgroundColor;
    [FieldOffset(0x0538)] public FSlateSound CheckedSlateSound;
    [FieldOffset(0x0550)] public FSlateSound UncheckedSlateSound;
    [FieldOffset(0x0568)] public FSlateSound HoveredSlateSound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3B8)] 
public unsafe struct FComboButtonStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FButtonStyle ButtonStyle;
    [FieldOffset(0x0280)] public FSlateBrush DownArrowImage;
    [FieldOffset(0x0308)] public FVector2D ShadowOffset;
    [FieldOffset(0x0310)] public FLinearColor ShadowColorAndOpacity;
    [FieldOffset(0x0320)] public FSlateBrush MenuBorderBrush;
    [FieldOffset(0x03A8)] public FMargin MenuBorderPadding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3F0)] 
public unsafe struct FComboBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FComboButtonStyle ComboButtonStyle;
    [FieldOffset(0x03C0)] public FSlateSound PressedSlateSound;
    [FieldOffset(0x03D8)] public FSlateSound SelectionChangeSlateSound;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D0)] 
public unsafe struct FScrollBarStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush HorizontalBackgroundImage;
    [FieldOffset(0x0090)] public FSlateBrush VerticalBackgroundImage;
    [FieldOffset(0x0118)] public FSlateBrush VerticalTopSlotImage;
    [FieldOffset(0x01A0)] public FSlateBrush HorizontalTopSlotImage;
    [FieldOffset(0x0228)] public FSlateBrush VerticalBottomSlotImage;
    [FieldOffset(0x02B0)] public FSlateBrush HorizontalBottomSlotImage;
    [FieldOffset(0x0338)] public FSlateBrush NormalThumbImage;
    [FieldOffset(0x03C0)] public FSlateBrush HoveredThumbImage;
    [FieldOffset(0x0448)] public FSlateBrush DraggedThumbImage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7F8)] 
public unsafe struct FEditableTextBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush BackgroundImageNormal;
    [FieldOffset(0x0090)] public FSlateBrush BackgroundImageHovered;
    [FieldOffset(0x0118)] public FSlateBrush BackgroundImageFocused;
    [FieldOffset(0x01A0)] public FSlateBrush BackgroundImageReadOnly;
    [FieldOffset(0x0228)] public FMargin Padding;
    [FieldOffset(0x0238)] public FSlateFontInfo Font;
    [FieldOffset(0x0290)] public FSlateColor ForegroundColor;
    [FieldOffset(0x02B8)] public FSlateColor BackgroundColor;
    [FieldOffset(0x02E0)] public FSlateColor ReadOnlyForegroundColor;
    [FieldOffset(0x0308)] public FMargin HScrollBarPadding;
    [FieldOffset(0x0318)] public FMargin VScrollBarPadding;
    [FieldOffset(0x0328)] public FScrollBarStyle ScrollBarStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x220)] 
public unsafe struct FEditableTextStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateFontInfo Font;
    [FieldOffset(0x0060)] public FSlateColor ColorAndOpacity;
    [FieldOffset(0x0088)] public FSlateBrush BackgroundImageSelected;
    [FieldOffset(0x0110)] public FSlateBrush BackgroundImageComposing;
    [FieldOffset(0x0198)] public FSlateBrush CaretImage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1A0)] 
public unsafe struct FProgressBarStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush BackgroundImage;
    [FieldOffset(0x0090)] public FSlateBrush FillImage;
    [FieldOffset(0x0118)] public FSlateBrush MarqueeImage;
}

[StructLayout(LayoutKind.Explicit, Size = 0x228)] 
public unsafe struct FScrollBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush TopShadowBrush;
    [FieldOffset(0x0090)] public FSlateBrush BottomShadowBrush;
    [FieldOffset(0x0118)] public FSlateBrush LeftShadowBrush;
    [FieldOffset(0x01A0)] public FSlateBrush RightShadowBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2E8)] 
public unsafe struct FSpinBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush BackgroundBrush;
    [FieldOffset(0x0090)] public FSlateBrush HoveredBackgroundBrush;
    [FieldOffset(0x0118)] public FSlateBrush ActiveFillBrush;
    [FieldOffset(0x01A0)] public FSlateBrush InactiveFillBrush;
    [FieldOffset(0x0228)] public FSlateBrush ArrowsImage;
    [FieldOffset(0x02B0)] public FSlateColor ForegroundColor;
    [FieldOffset(0x02D8)] public FMargin TextPadding;
}

[StructLayout(LayoutKind.Explicit, Size = 0x270)] 
public unsafe struct FTextBlockStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateFontInfo Font;
    [FieldOffset(0x0060)] public FSlateColor ColorAndOpacity;
    [FieldOffset(0x0088)] public FVector2D ShadowOffset;
    [FieldOffset(0x0090)] public FLinearColor ShadowColorAndOpacity;
    [FieldOffset(0x00A0)] public FSlateColor SelectedBackgroundColor;
    [FieldOffset(0x00C8)] public FLinearColor HighlightColor;
    [FieldOffset(0x00D8)] public FSlateBrush HighlightShape;
    [FieldOffset(0x0160)] public FSlateBrush StrikeBrush;
    [FieldOffset(0x01E8)] public FSlateBrush UnderlineBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x7C8)] 
public unsafe struct FTableRowStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush SelectorFocusedBrush;
    [FieldOffset(0x0090)] public FSlateBrush ActiveHoveredBrush;
    [FieldOffset(0x0118)] public FSlateBrush ActiveBrush;
    [FieldOffset(0x01A0)] public FSlateBrush InactiveHoveredBrush;
    [FieldOffset(0x0228)] public FSlateBrush InactiveBrush;
    [FieldOffset(0x02B0)] public FSlateBrush EvenRowBackgroundHoveredBrush;
    [FieldOffset(0x0338)] public FSlateBrush EvenRowBackgroundBrush;
    [FieldOffset(0x03C0)] public FSlateBrush OddRowBackgroundHoveredBrush;
    [FieldOffset(0x0448)] public FSlateBrush OddRowBackgroundBrush;
    [FieldOffset(0x04D0)] public FSlateColor TextColor;
    [FieldOffset(0x04F8)] public FSlateColor SelectedTextColor;
    [FieldOffset(0x0520)] public FSlateBrush DropIndicator_Above;
    [FieldOffset(0x05A8)] public FSlateBrush DropIndicator_Onto;
    [FieldOffset(0x0630)] public FSlateBrush DropIndicator_Below;
    [FieldOffset(0x06B8)] public FSlateBrush ActiveHighlightedBrush;
    [FieldOffset(0x0740)] public FSlateBrush InactiveHighlightedBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct FExpandableAreaStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush CollapsedImage;
    [FieldOffset(0x0090)] public FSlateBrush ExpandedImage;
    [FieldOffset(0x0118)] public float RolloutAnimationSeconds;
}

[StructLayout(LayoutKind.Explicit, Size = 0x340)] 
public unsafe struct FSliderStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush NormalBarImage;
    [FieldOffset(0x0090)] public FSlateBrush HoveredBarImage;
    [FieldOffset(0x0118)] public FSlateBrush DisabledBarImage;
    [FieldOffset(0x01A0)] public FSlateBrush NormalThumbImage;
    [FieldOffset(0x0228)] public FSlateBrush HoveredThumbImage;
    [FieldOffset(0x02B0)] public FSlateBrush DisabledThumbImage;
    [FieldOffset(0x0338)] public float BarThickness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FNavigationEvent
{
    [FieldOffset(0x0000)] public FInputEvent baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FFontData
{
    [FieldOffset(0x0000)] public FString FontFilename;
    [FieldOffset(0x0010)] public EFontHinting Hinting;
    [FieldOffset(0x0011)] public EFontLoadingPolicy LoadingPolicy;
    [FieldOffset(0x0014)] public int SubFaceIndex;
    [FieldOffset(0x0018)] public UObject* FontFaceAsset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FTypefaceEntry
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public FFontData Font;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FTypeface
{
    [FieldOffset(0x0000)] public TArray<FTypefaceEntry> Fonts;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FCompositeFallbackFont
{
    [FieldOffset(0x0000)] public FTypeface Typeface;
    [FieldOffset(0x0010)] public float ScalingFactor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCompositeSubFont
{
    [FieldOffset(0x0000)] public FCompositeFallbackFont baseObj;
    [FieldOffset(0x0018)] public TArray<FInt32Range> CharacterRanges;
    [FieldOffset(0x0028)] public FString Cultures;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct FCompositeFont
{
    [FieldOffset(0x0000)] public FTypeface DefaultTypeface;
    [FieldOffset(0x0010)] public FCompositeFallbackFont FallbackTypeface;
    [FieldOffset(0x0028)] public TArray<FCompositeSubFont> SubTypefaces;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FCaptureLostEvent
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x1060)] 
public unsafe struct FWindowStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FButtonStyle MinimizeButtonStyle;
    [FieldOffset(0x0280)] public FButtonStyle MaximizeButtonStyle;
    [FieldOffset(0x04F8)] public FButtonStyle RestoreButtonStyle;
    [FieldOffset(0x0770)] public FButtonStyle CloseButtonStyle;
    [FieldOffset(0x09E8)] public FTextBlockStyle TitleTextStyle;
    [FieldOffset(0x0C58)] public FSlateBrush ActiveTitleBrush;
    [FieldOffset(0x0CE0)] public FSlateBrush InactiveTitleBrush;
    [FieldOffset(0x0D68)] public FSlateBrush FlashTitleBrush;
    [FieldOffset(0x0DF0)] public FSlateColor BackgroundColor;
    [FieldOffset(0x0E18)] public FSlateBrush OutlineBrush;
    [FieldOffset(0x0EA0)] public FSlateColor OutlineColor;
    [FieldOffset(0x0EC8)] public FSlateBrush BorderBrush;
    [FieldOffset(0x0F50)] public FSlateBrush BackgroundBrush;
    [FieldOffset(0x0FD8)] public FSlateBrush ChildBackgroundBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FScrollBorderStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush TopShadowBrush;
    [FieldOffset(0x0090)] public FSlateBrush BottomShadowBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x700)] 
public unsafe struct FDockTabStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FButtonStyle CloseButtonStyle;
    [FieldOffset(0x0280)] public FSlateBrush NormalBrush;
    [FieldOffset(0x0308)] public FSlateBrush ActiveBrush;
    [FieldOffset(0x0390)] public FSlateBrush ColorOverlayTabBrush;
    [FieldOffset(0x0418)] public FSlateBrush ColorOverlayIconBrush;
    [FieldOffset(0x04A0)] public FSlateBrush ForegroundBrush;
    [FieldOffset(0x0528)] public FSlateBrush HoveredBrush;
    [FieldOffset(0x05B0)] public FSlateBrush ContentAreaBrush;
    [FieldOffset(0x0638)] public FSlateBrush TabWellBrush;
    [FieldOffset(0x06C0)] public FMargin TabPadding;
    [FieldOffset(0x06D0)] public float OverlapWidth;
    [FieldOffset(0x06D8)] public FSlateColor FlashColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4D0)] 
public unsafe struct FTableColumnHeaderStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush SortPrimaryAscendingImage;
    [FieldOffset(0x0090)] public FSlateBrush SortPrimaryDescendingImage;
    [FieldOffset(0x0118)] public FSlateBrush SortSecondaryAscendingImage;
    [FieldOffset(0x01A0)] public FSlateBrush SortSecondaryDescendingImage;
    [FieldOffset(0x0228)] public FSlateBrush NormalBrush;
    [FieldOffset(0x02B0)] public FSlateBrush HoveredBrush;
    [FieldOffset(0x0338)] public FSlateBrush MenuDropdownImage;
    [FieldOffset(0x03C0)] public FSlateBrush MenuDropdownNormalBorderBrush;
    [FieldOffset(0x0448)] public FSlateBrush MenuDropdownHoveredBorderBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0x118)] 
public unsafe struct FSplitterStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush HandleNormalBrush;
    [FieldOffset(0x0090)] public FSlateBrush HandleHighlightBrush;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB70)] 
public unsafe struct FHeaderRowStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FTableColumnHeaderStyle ColumnStyle;
    [FieldOffset(0x04D8)] public FTableColumnHeaderStyle LastColumnStyle;
    [FieldOffset(0x09A8)] public FSplitterStyle ColumnSplitterStyle;
    [FieldOffset(0x0AC0)] public FSlateBrush BackgroundBrush;
    [FieldOffset(0x0B48)] public FSlateColor ForegroundColor;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct FInlineTextImageStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSlateBrush Image;
    [FieldOffset(0x0090)] public short Baseline;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5F0)] 
public unsafe struct FVolumeControlStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FSliderStyle SliderStyle;
    [FieldOffset(0x0348)] public FSlateBrush HighVolumeImage;
    [FieldOffset(0x03D0)] public FSlateBrush MidVolumeImage;
    [FieldOffset(0x0458)] public FSlateBrush LowVolumeImage;
    [FieldOffset(0x04E0)] public FSlateBrush NoVolumeImage;
    [FieldOffset(0x0568)] public FSlateBrush MutedImage;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA90)] 
public unsafe struct FSearchBoxStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FEditableTextBoxStyle TextBoxStyle;
    [FieldOffset(0x0800)] public FSlateFontInfo ActiveFontInfo;
    [FieldOffset(0x0858)] public FSlateBrush UpArrowImage;
    [FieldOffset(0x08E0)] public FSlateBrush DownArrowImage;
    [FieldOffset(0x0968)] public FSlateBrush GlassImage;
    [FieldOffset(0x09F0)] public FSlateBrush ClearImage;
    [FieldOffset(0x0A78)] public FMargin ImagePadding;
    [FieldOffset(0x0A88)] public bool bLeftAlignButtons;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA70)] 
public unsafe struct FInlineEditableTextBlockStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FEditableTextBoxStyle EditableTextBoxStyle;
    [FieldOffset(0x0800)] public FTextBlockStyle TextStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x500)] 
public unsafe struct FHyperlinkStyle
{
    [FieldOffset(0x0000)] public FSlateWidgetStyle baseObj;
    [FieldOffset(0x0008)] public FButtonStyle UnderlineStyle;
    [FieldOffset(0x0280)] public FTextBlockStyle TextStyle;
    [FieldOffset(0x04F0)] public FMargin Padding;
}

