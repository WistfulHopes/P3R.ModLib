using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FAnchors
{
    [FieldOffset(0x0000)] public FVector2D Minimum;
    [FieldOffset(0x0008)] public FVector2D Maximum;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)] 
public unsafe struct UButtonWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FButtonStyle ButtonStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x5B0)] 
public unsafe struct UCheckBoxWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FCheckBoxStyle CheckBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x420)] 
public unsafe struct UComboBoxWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FComboBoxStyle ComboBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x3E8)] 
public unsafe struct UComboButtonWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FComboButtonStyle ComboButtonStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x828)] 
public unsafe struct UEditableTextBoxWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FEditableTextBoxStyle EditableTextBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x250)] 
public unsafe struct UEditableTextWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FEditableTextStyle EditableTextStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1D0)] 
public unsafe struct UProgressWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FProgressBarStyle ProgressBarStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x500)] 
public unsafe struct UScrollBarWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FScrollBarStyle ScrollBarStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x258)] 
public unsafe struct UScrollBoxWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FScrollBoxStyle ScrollBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct USlateSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bExplicitCanvasChildZOrder;
}

[StructLayout(LayoutKind.Explicit, Size = 0x318)] 
public unsafe struct USpinBoxWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FSpinBoxStyle SpinBoxStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x2A0)] 
public unsafe struct UTextBlockWidgetStyle
{
    [FieldOffset(0x0000)] public USlateWidgetStyleContainerBase baseObj;
    [FieldOffset(0x0030)] public FTextBlockStyle TextBlockStyle;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UToolMenuBase
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FVirtualKeyboardOptions
{
    [FieldOffset(0x0000)] public bool bEnableAutocorrect;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FInputChord
{
    [FieldOffset(0x0000)] public FKey Key;
    [FieldOffset(0x0018)] public byte bShift;
    [FieldOffset(0x0018)] public byte bCtrl;
    [FieldOffset(0x0018)] public byte bAlt;
    [FieldOffset(0x0018)] public byte bCmd;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FCustomizedToolMenuEntry
{
    [FieldOffset(0x0000)] public ECustomizedToolMenuVisibility Visibility;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FCustomizedToolMenuSection
{
    [FieldOffset(0x0000)] public ECustomizedToolMenuVisibility Visibility;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FCustomizedToolMenuNameArray
{
    [FieldOffset(0x0000)] public TArray<FName> Names;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1E8)] 
public unsafe struct FCustomizedToolMenu
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public TMap<FName, FCustomizedToolMenuEntry> Entries;
    [FieldOffset(0x0058)] public TMap<FName, FCustomizedToolMenuSection> Sections;
    [FieldOffset(0x00A8)] public TMap<FName, FCustomizedToolMenuNameArray> EntryOrder;
    [FieldOffset(0x00F8)] public TArray<FName> SectionOrder;
}

