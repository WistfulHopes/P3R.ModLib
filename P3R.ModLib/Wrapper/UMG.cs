using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class Button : ObjectBase<UButton>
{
    public Button(IntPtr pointer) : base(pointer) {}
    public void SetTouchMethod(EButtonTouchMethod InTouchMethod)
    {
        Span<(string name, object value)> @params = [
            ("InTouchMethod", InTouchMethod)
        ];
        ProcessEvent(GetFunction("SetTouchMethod"), @params);
    }
    public void SetStyle(ref FButtonStyle InStyle)
    {
        Span<(string name, object value)> @params = [
            ("InStyle", InStyle)
        ];
        ProcessEvent(GetFunction("SetStyle"), @params);
    }
    public void SetPressMethod(EButtonPressMethod InPressMethod)
    {
        Span<(string name, object value)> @params = [
            ("InPressMethod", InPressMethod)
        ];
        ProcessEvent(GetFunction("SetPressMethod"), @params);
    }
    public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetColorAndOpacity"), @params);
    }
    public void SetClickMethod(EButtonClickMethod InClickMethod)
    {
        Span<(string name, object value)> @params = [
            ("InClickMethod", InClickMethod)
        ];
        ProcessEvent(GetFunction("SetClickMethod"), @params);
    }
    public void SetBackgroundColor(FLinearColor InBackgroundColor)
    {
        Span<(string name, object value)> @params = [
            ("InBackgroundColor", InBackgroundColor)
        ];
        ProcessEvent(GetFunction("SetBackgroundColor"), @params);
    }
    public bool IsPressed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPressed"), @params);
    }
}

public unsafe class ButtonSlot : ObjectBase<UButtonSlot>
{
    public ButtonSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class CanvasPanel : ObjectBase<UCanvasPanel>
{
    public CanvasPanel(IntPtr pointer) : base(pointer) {}
    public UCanvasPanelSlot* AddChildToCanvas(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UCanvasPanelSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToCanvas"), @params);
    }
}

public unsafe class CanvasPanelSlot : ObjectBase<UCanvasPanelSlot>
{
    public CanvasPanelSlot(IntPtr pointer) : base(pointer) {}
    public void SetZOrder(int InZOrder)
    {
        Span<(string name, object value)> @params = [
            ("InZOrder", InZOrder)
        ];
        ProcessEvent(GetFunction("SetZOrder"), @params);
    }
    public void SetSize(FVector2D InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        ProcessEvent(GetFunction("SetSize"), @params);
    }
    public void SetPosition(FVector2D InPosition)
    {
        Span<(string name, object value)> @params = [
            ("InPosition", InPosition)
        ];
        ProcessEvent(GetFunction("SetPosition"), @params);
    }
    public void SetOffsets(FMargin InOffset)
    {
        Span<(string name, object value)> @params = [
            ("InOffset", InOffset)
        ];
        ProcessEvent(GetFunction("SetOffsets"), @params);
    }
    public void SetMinimum(FVector2D InMinimumAnchors)
    {
        Span<(string name, object value)> @params = [
            ("InMinimumAnchors", InMinimumAnchors)
        ];
        ProcessEvent(GetFunction("SetMinimum"), @params);
    }
    public void SetMaximum(FVector2D InMaximumAnchors)
    {
        Span<(string name, object value)> @params = [
            ("InMaximumAnchors", InMaximumAnchors)
        ];
        ProcessEvent(GetFunction("SetMaximum"), @params);
    }
    public void SetLayout(ref FAnchorData InLayoutData)
    {
        Span<(string name, object value)> @params = [
            ("InLayoutData", InLayoutData)
        ];
        ProcessEvent(GetFunction("SetLayout"), @params);
    }
    public void SetAutoSize(bool InbAutoSize)
    {
        Span<(string name, object value)> @params = [
            ("InbAutoSize", InbAutoSize)
        ];
        ProcessEvent(GetFunction("SetAutoSize"), @params);
    }
    public void SetAnchors(FAnchors InAnchors)
    {
        Span<(string name, object value)> @params = [
            ("InAnchors", InAnchors)
        ];
        ProcessEvent(GetFunction("SetAnchors"), @params);
    }
    public void SetAlignment(FVector2D InAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InAlignment", InAlignment)
        ];
        ProcessEvent(GetFunction("SetAlignment"), @params);
    }
    public int GetZOrder()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetZOrder"), @params);
    }
    public FVector2D GetSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetSize"), @params);
    }
    public FVector2D GetPosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetPosition"), @params);
    }
    public FMargin GetOffsets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FMargin>(GetFunction("GetOffsets"), @params);
    }
    public FAnchorData GetLayout()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FAnchorData>(GetFunction("GetLayout"), @params);
    }
    public bool GetAutoSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetAutoSize"), @params);
    }
    public FAnchors GetAnchors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FAnchors>(GetFunction("GetAnchors"), @params);
    }
    public FVector2D GetAlignment()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAlignment"), @params);
    }
}

public unsafe class CheckBox : ObjectBase<UCheckBox>
{
    public CheckBox(IntPtr pointer) : base(pointer) {}
    public void SetTouchMethod(EButtonTouchMethod InTouchMethod)
    {
        Span<(string name, object value)> @params = [
            ("InTouchMethod", InTouchMethod)
        ];
        ProcessEvent(GetFunction("SetTouchMethod"), @params);
    }
    public void SetPressMethod(EButtonPressMethod InPressMethod)
    {
        Span<(string name, object value)> @params = [
            ("InPressMethod", InPressMethod)
        ];
        ProcessEvent(GetFunction("SetPressMethod"), @params);
    }
    public void SetIsChecked(bool InIsChecked)
    {
        Span<(string name, object value)> @params = [
            ("InIsChecked", InIsChecked)
        ];
        ProcessEvent(GetFunction("SetIsChecked"), @params);
    }
    public void SetClickMethod(EButtonClickMethod InClickMethod)
    {
        Span<(string name, object value)> @params = [
            ("InClickMethod", InClickMethod)
        ];
        ProcessEvent(GetFunction("SetClickMethod"), @params);
    }
    public void SetCheckedState(ECheckBoxState InCheckedState)
    {
        Span<(string name, object value)> @params = [
            ("InCheckedState", InCheckedState)
        ];
        ProcessEvent(GetFunction("SetCheckedState"), @params);
    }
    public bool IsPressed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPressed"), @params);
    }
    public bool IsChecked()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsChecked"), @params);
    }
    public ECheckBoxState GetCheckedState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECheckBoxState>(GetFunction("GetCheckedState"), @params);
    }
}

public unsafe class CheckedStateBinding : ObjectBase<UCheckedStateBinding>
{
    public CheckedStateBinding(IntPtr pointer) : base(pointer) {}
    public ECheckBoxState GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECheckBoxState>(GetFunction("GetValue"), @params);
    }
}

public unsafe class CircularThrobber : ObjectBase<UCircularThrobber>
{
    public CircularThrobber(IntPtr pointer) : base(pointer) {}
    public void SetRadius(float InRadius)
    {
        Span<(string name, object value)> @params = [
            ("InRadius", InRadius)
        ];
        ProcessEvent(GetFunction("SetRadius"), @params);
    }
    public void SetPeriod(float InPeriod)
    {
        Span<(string name, object value)> @params = [
            ("InPeriod", InPeriod)
        ];
        ProcessEvent(GetFunction("SetPeriod"), @params);
    }
    public void SetNumberOfPieces(int InNumberOfPieces)
    {
        Span<(string name, object value)> @params = [
            ("InNumberOfPieces", InNumberOfPieces)
        ];
        ProcessEvent(GetFunction("SetNumberOfPieces"), @params);
    }
}

public unsafe class ColorBinding : ObjectBase<UColorBinding>
{
    public ColorBinding(IntPtr pointer) : base(pointer) {}
    public FSlateColor GetSlateValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSlateColor>(GetFunction("GetSlateValue"), @params);
    }
    public FLinearColor GetLinearValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetLinearValue"), @params);
    }
}

public unsafe class ComboBox : ObjectBase<UComboBox>
{
    public ComboBox(IntPtr pointer) : base(pointer) {}
}

public unsafe class ComboBoxString : ObjectBase<UComboBoxString>
{
    public ComboBoxString(IntPtr pointer) : base(pointer) {}
    public void SetSelectedOption(FString OPTION)
    {
        Span<(string name, object value)> @params = [
            ("OPTION", OPTION)
        ];
        ProcessEvent(GetFunction("SetSelectedOption"), @params);
    }
    public void SetSelectedIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetSelectedIndex"), @params);
    }
    public bool RemoveOption(FString OPTION)
    {
        Span<(string name, object value)> @params = [
            ("OPTION", OPTION)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveOption"), @params);
    }
    public void RefreshOptions()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RefreshOptions"), @params);
    }
    public void OnSelectionChangedEvent__DelegateSignature(FString SelectedItem, ESelectInfo SelectionType)
    {
        Span<(string name, object value)> @params = [
            ("SelectedItem", SelectedItem), 
            ("SelectionType", SelectionType)
        ];
        ProcessEvent(GetFunction("OnSelectionChangedEvent__DelegateSignature"), @params);
    }
    public void OnOpeningEvent__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnOpeningEvent__DelegateSignature"), @params);
    }
    public bool IsOpen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOpen"), @params);
    }
    public FString GetSelectedOption()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetSelectedOption"), @params);
    }
    public int GetSelectedIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSelectedIndex"), @params);
    }
    public int GetOptionCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetOptionCount"), @params);
    }
    public FString GetOptionAtIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<FString>(GetFunction("GetOptionAtIndex"), @params);
    }
    public int FindOptionIndex(FString OPTION)
    {
        Span<(string name, object value)> @params = [
            ("OPTION", OPTION)
        ];
        return ProcessEvent<int>(GetFunction("FindOptionIndex"), @params);
    }
    public void ClearSelection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearSelection"), @params);
    }
    public void ClearOptions()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearOptions"), @params);
    }
    public void AddOption(FString OPTION)
    {
        Span<(string name, object value)> @params = [
            ("OPTION", OPTION)
        ];
        ProcessEvent(GetFunction("AddOption"), @params);
    }
}

public unsafe class DragDropOperation : ObjectBase<UDragDropOperation>
{
    public DragDropOperation(IntPtr pointer) : base(pointer) {}
    public void Drop(ref FPointerEvent PointerEvent)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent)
        ];
        ProcessEvent(GetFunction("Drop"), @params);
    }
    public void Dragged(ref FPointerEvent PointerEvent)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent)
        ];
        ProcessEvent(GetFunction("Dragged"), @params);
    }
    public void DragCancelled(ref FPointerEvent PointerEvent)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent)
        ];
        ProcessEvent(GetFunction("DragCancelled"), @params);
    }
}

public unsafe class DynamicEntryBoxBase : ObjectBase<UDynamicEntryBoxBase>
{
    public DynamicEntryBoxBase(IntPtr pointer) : base(pointer) {}
    public void SetRadialSettings(ref FRadialBoxSettings InSettings)
    {
        Span<(string name, object value)> @params = [
            ("InSettings", InSettings)
        ];
        ProcessEvent(GetFunction("SetRadialSettings"), @params);
    }
    public void SetEntrySpacing(ref FVector2D InEntrySpacing)
    {
        Span<(string name, object value)> @params = [
            ("InEntrySpacing", InEntrySpacing)
        ];
        ProcessEvent(GetFunction("SetEntrySpacing"), @params);
    }
    public int GetNumEntries()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumEntries"), @params);
    }
    public TArray<IntPtr> GetAllEntries()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllEntries"), @params);
    }
}

public unsafe class DynamicEntryBox : ObjectBase<UDynamicEntryBox>
{
    public DynamicEntryBox(IntPtr pointer) : base(pointer) {}
    public void Reset(bool bDeleteWidgets)
    {
        Span<(string name, object value)> @params = [
            ("bDeleteWidgets", bDeleteWidgets)
        ];
        ProcessEvent(GetFunction("Reset"), @params);
    }
    public void RemoveEntry(UUserWidget* EntryWidget)
    {
        Span<(string name, object value)> @params = [
            ("EntryWidget", (IntPtr)EntryWidget)
        ];
        ProcessEvent(GetFunction("RemoveEntry"), @params);
    }
    public UUserWidget* BP_CreateEntryOfClass(TSubclassOf<UUserWidget> EntryClass)
    {
        Span<(string name, object value)> @params = [
            ("EntryClass", EntryClass)
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("BP_CreateEntryOfClass"), @params);
    }
    public UUserWidget* BP_CreateEntry()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("BP_CreateEntry"), @params);
    }
}

public unsafe class EditableText : ObjectBase<UEditableText>
{
    public EditableText(IntPtr pointer) : base(pointer) {}
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetJustification(ETextJustify InJustification)
    {
        Span<(string name, object value)> @params = [
            ("InJustification", InJustification)
        ];
        ProcessEvent(GetFunction("SetJustification"), @params);
    }
    public void SetIsReadOnly(bool InbIsReadyOnly)
    {
        Span<(string name, object value)> @params = [
            ("InbIsReadyOnly", InbIsReadyOnly)
        ];
        ProcessEvent(GetFunction("SetIsReadOnly"), @params);
    }
    public void SetIsPassword(bool InbIsPassword)
    {
        Span<(string name, object value)> @params = [
            ("InbIsPassword", InbIsPassword)
        ];
        ProcessEvent(GetFunction("SetIsPassword"), @params);
    }
    public void SetHintText(FText InHintText)
    {
        Span<(string name, object value)> @params = [
            ("InHintText", InHintText)
        ];
        ProcessEvent(GetFunction("SetHintText"), @params);
    }
    public void OnEditableTextCommittedEvent__DelegateSignature(ref FText Text, ETextCommit CommitMethod)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text), 
            ("CommitMethod", CommitMethod)
        ];
        ProcessEvent(GetFunction("OnEditableTextCommittedEvent__DelegateSignature"), @params);
    }
    public void OnEditableTextChangedEvent__DelegateSignature(ref FText Text)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("OnEditableTextChangedEvent__DelegateSignature"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
}

public unsafe class EditableTextBox : ObjectBase<UEditableTextBox>
{
    public EditableTextBox(IntPtr pointer) : base(pointer) {}
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetJustification(ETextJustify InJustification)
    {
        Span<(string name, object value)> @params = [
            ("InJustification", InJustification)
        ];
        ProcessEvent(GetFunction("SetJustification"), @params);
    }
    public void SetIsReadOnly(bool bReadOnly)
    {
        Span<(string name, object value)> @params = [
            ("bReadOnly", bReadOnly)
        ];
        ProcessEvent(GetFunction("SetIsReadOnly"), @params);
    }
    public void SetIsPassword(bool bIsPassword)
    {
        Span<(string name, object value)> @params = [
            ("bIsPassword", bIsPassword)
        ];
        ProcessEvent(GetFunction("SetIsPassword"), @params);
    }
    public void SetHintText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetHintText"), @params);
    }
    public void SetError(FText InError)
    {
        Span<(string name, object value)> @params = [
            ("InError", InError)
        ];
        ProcessEvent(GetFunction("SetError"), @params);
    }
    public void OnEditableTextBoxCommittedEvent__DelegateSignature(ref FText Text, ETextCommit CommitMethod)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text), 
            ("CommitMethod", CommitMethod)
        ];
        ProcessEvent(GetFunction("OnEditableTextBoxCommittedEvent__DelegateSignature"), @params);
    }
    public void OnEditableTextBoxChangedEvent__DelegateSignature(ref FText Text)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("OnEditableTextBoxChangedEvent__DelegateSignature"), @params);
    }
    public bool HasError()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasError"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public void ClearError()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearError"), @params);
    }
}

public unsafe class ExpandableArea : ObjectBase<UExpandableArea>
{
    public ExpandableArea(IntPtr pointer) : base(pointer) {}
    public void SetIsExpanded_Animated(bool IsExpanded)
    {
        Span<(string name, object value)> @params = [
            ("IsExpanded", IsExpanded)
        ];
        ProcessEvent(GetFunction("SetIsExpanded_Animated"), @params);
    }
    public void SetIsExpanded(bool IsExpanded)
    {
        Span<(string name, object value)> @params = [
            ("IsExpanded", IsExpanded)
        ];
        ProcessEvent(GetFunction("SetIsExpanded"), @params);
    }
    public bool GetIsExpanded()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetIsExpanded"), @params);
    }
}

public unsafe class FloatBinding : ObjectBase<UFloatBinding>
{
    public FloatBinding(IntPtr pointer) : base(pointer) {}
    public float GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetValue"), @params);
    }
}

public unsafe class GridPanel : ObjectBase<UGridPanel>
{
    public GridPanel(IntPtr pointer) : base(pointer) {}
    public void SetRowFill(int ColumnIndex, float Coefficient)
    {
        Span<(string name, object value)> @params = [
            ("ColumnIndex", ColumnIndex), 
            ("Coefficient", Coefficient)
        ];
        ProcessEvent(GetFunction("SetRowFill"), @params);
    }
    public void SetColumnFill(int ColumnIndex, float Coefficient)
    {
        Span<(string name, object value)> @params = [
            ("ColumnIndex", ColumnIndex), 
            ("Coefficient", Coefficient)
        ];
        ProcessEvent(GetFunction("SetColumnFill"), @params);
    }
    public UGridSlot* AddChildToGrid(UWidget* Content, int InRow, int InColumn)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content), 
            ("InRow", InRow), 
            ("InColumn", InColumn)
        ];
        return (UGridSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToGrid"), @params);
    }
}

public unsafe class GridSlot : ObjectBase<UGridSlot>
{
    public GridSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetRowSpan(int InRowSpan)
    {
        Span<(string name, object value)> @params = [
            ("InRowSpan", InRowSpan)
        ];
        ProcessEvent(GetFunction("SetRowSpan"), @params);
    }
    public void SetRow(int InRow)
    {
        Span<(string name, object value)> @params = [
            ("InRow", InRow)
        ];
        ProcessEvent(GetFunction("SetRow"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetNudge(FVector2D InNudge)
    {
        Span<(string name, object value)> @params = [
            ("InNudge", InNudge)
        ];
        ProcessEvent(GetFunction("SetNudge"), @params);
    }
    public void SetLayer(int InLayer)
    {
        Span<(string name, object value)> @params = [
            ("InLayer", InLayer)
        ];
        ProcessEvent(GetFunction("SetLayer"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
    public void SetColumnSpan(int InColumnSpan)
    {
        Span<(string name, object value)> @params = [
            ("InColumnSpan", InColumnSpan)
        ];
        ProcessEvent(GetFunction("SetColumnSpan"), @params);
    }
    public void SetColumn(int InColumn)
    {
        Span<(string name, object value)> @params = [
            ("InColumn", InColumn)
        ];
        ProcessEvent(GetFunction("SetColumn"), @params);
    }
}

public unsafe class HorizontalBox : ObjectBase<UHorizontalBox>
{
    public HorizontalBox(IntPtr pointer) : base(pointer) {}
    public UHorizontalBoxSlot* AddChildToHorizontalBox(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UHorizontalBoxSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToHorizontalBox"), @params);
    }
}

public unsafe class HorizontalBoxSlot : ObjectBase<UHorizontalBoxSlot>
{
    public HorizontalBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetSize(FSlateChildSize InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        ProcessEvent(GetFunction("SetSize"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class Image : ObjectBase<UImage>
{
    public Image(IntPtr pointer) : base(pointer) {}
    public void SetOpacity(float InOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InOpacity", InOpacity)
        ];
        ProcessEvent(GetFunction("SetOpacity"), @params);
    }
    public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetColorAndOpacity"), @params);
    }
    public void SetBrushTintColor(FSlateColor TintColor)
    {
        Span<(string name, object value)> @params = [
            ("TintColor", TintColor)
        ];
        ProcessEvent(GetFunction("SetBrushTintColor"), @params);
    }
    public void SetBrushSize(FVector2D DesiredSize)
    {
        Span<(string name, object value)> @params = [
            ("DesiredSize", DesiredSize)
        ];
        ProcessEvent(GetFunction("SetBrushSize"), @params);
    }
    public void SetBrushResourceObject(UObject* ResourceObject)
    {
        Span<(string name, object value)> @params = [
            ("ResourceObject", (IntPtr)ResourceObject)
        ];
        ProcessEvent(GetFunction("SetBrushResourceObject"), @params);
    }
    public void SetBrushFromTextureDynamic(UTexture2DDynamic* Texture, bool bMatchSize)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("bMatchSize", bMatchSize)
        ];
        ProcessEvent(GetFunction("SetBrushFromTextureDynamic"), @params);
    }
    public void SetBrushFromTexture(UTexture2D* Texture, bool bMatchSize)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("bMatchSize", bMatchSize)
        ];
        ProcessEvent(GetFunction("SetBrushFromTexture"), @params);
    }
    public void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture, bool bMatchSize)
    {
        Span<(string name, object value)> @params = [
            ("SoftTexture", SoftTexture), 
            ("bMatchSize", bMatchSize)
        ];
        ProcessEvent(GetFunction("SetBrushFromSoftTexture"), @params);
    }
    public void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial)
    {
        Span<(string name, object value)> @params = [
            ("SoftMaterial", SoftMaterial)
        ];
        ProcessEvent(GetFunction("SetBrushFromSoftMaterial"), @params);
    }
    public void SetBrushFromMaterial(UMaterialInterface* Material)
    {
        Span<(string name, object value)> @params = [
            ("Material", (IntPtr)Material)
        ];
        ProcessEvent(GetFunction("SetBrushFromMaterial"), @params);
    }
    public void SetBrushFromAtlasInterface(TScriptInterface<ISlateTextureAtlasInterface> AtlasRegion, bool bMatchSize)
    {
        Span<(string name, object value)> @params = [
            ("AtlasRegion", AtlasRegion), 
            ("bMatchSize", bMatchSize)
        ];
        ProcessEvent(GetFunction("SetBrushFromAtlasInterface"), @params);
    }
    public void SetBrushFromAsset(USlateBrushAsset* Asset)
    {
        Span<(string name, object value)> @params = [
            ("Asset", (IntPtr)Asset)
        ];
        ProcessEvent(GetFunction("SetBrushFromAsset"), @params);
    }
    public void SetBrush(ref FSlateBrush InBrush)
    {
        Span<(string name, object value)> @params = [
            ("InBrush", InBrush)
        ];
        ProcessEvent(GetFunction("SetBrush"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicMaterial"), @params);
    }
}

public unsafe class InputKeySelector : ObjectBase<UInputKeySelector>
{
    public InputKeySelector(IntPtr pointer) : base(pointer) {}
    public void SetTextBlockVisibility(ESlateVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetTextBlockVisibility"), @params);
    }
    public void SetSelectedKey(ref FInputChord InSelectedKey)
    {
        Span<(string name, object value)> @params = [
            ("InSelectedKey", InSelectedKey)
        ];
        ProcessEvent(GetFunction("SetSelectedKey"), @params);
    }
    public void SetNoKeySpecifiedText(FText InNoKeySpecifiedText)
    {
        Span<(string name, object value)> @params = [
            ("InNoKeySpecifiedText", InNoKeySpecifiedText)
        ];
        ProcessEvent(GetFunction("SetNoKeySpecifiedText"), @params);
    }
    public void SetKeySelectionText(FText InKeySelectionText)
    {
        Span<(string name, object value)> @params = [
            ("InKeySelectionText", InKeySelectionText)
        ];
        ProcessEvent(GetFunction("SetKeySelectionText"), @params);
    }
    public void SetEscapeKeys(ref TArray<FKey> InKeys)
    {
        Span<(string name, object value)> @params = [
            ("InKeys", InKeys)
        ];
        ProcessEvent(GetFunction("SetEscapeKeys"), @params);
    }
    public void SetAllowModifierKeys(bool bInAllowModifierKeys)
    {
        Span<(string name, object value)> @params = [
            ("bInAllowModifierKeys", bInAllowModifierKeys)
        ];
        ProcessEvent(GetFunction("SetAllowModifierKeys"), @params);
    }
    public void SetAllowGamepadKeys(bool bInAllowGamepadKeys)
    {
        Span<(string name, object value)> @params = [
            ("bInAllowGamepadKeys", bInAllowGamepadKeys)
        ];
        ProcessEvent(GetFunction("SetAllowGamepadKeys"), @params);
    }
    public void OnKeySelected__DelegateSignature(FInputChord SelectedKey)
    {
        Span<(string name, object value)> @params = [
            ("SelectedKey", SelectedKey)
        ];
        ProcessEvent(GetFunction("OnKeySelected__DelegateSignature"), @params);
    }
    public void OnIsSelectingKeyChanged__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnIsSelectingKeyChanged__DelegateSignature"), @params);
    }
    public bool GetIsSelectingKey()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetIsSelectingKey"), @params);
    }
}

public unsafe class Int32Binding : ObjectBase<UInt32Binding>
{
    public Int32Binding(IntPtr pointer) : base(pointer) {}
    public int GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetValue"), @params);
    }
}

public unsafe class InvalidationBox : ObjectBase<UInvalidationBox>
{
    public InvalidationBox(IntPtr pointer) : base(pointer) {}
    public void SetCanCache(bool CanCache)
    {
        Span<(string name, object value)> @params = [
            ("CanCache", CanCache)
        ];
        ProcessEvent(GetFunction("SetCanCache"), @params);
    }
    public void InvalidateCache()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InvalidateCache"), @params);
    }
    public bool GetCanCache()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetCanCache"), @params);
    }
}

public unsafe class UserListEntry : ObjectBase<IUserListEntry>
{
    public UserListEntry(IntPtr pointer) : base(pointer) {}
    public void BP_OnItemSelectionChanged(bool bIsSelected)
    {
        Span<(string name, object value)> @params = [
            ("bIsSelected", bIsSelected)
        ];
        ProcessEvent(GetFunction("BP_OnItemSelectionChanged"), @params);
    }
    public void BP_OnItemExpansionChanged(bool bIsExpanded)
    {
        Span<(string name, object value)> @params = [
            ("bIsExpanded", bIsExpanded)
        ];
        ProcessEvent(GetFunction("BP_OnItemExpansionChanged"), @params);
    }
    public void BP_OnEntryReleased()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BP_OnEntryReleased"), @params);
    }
}

public unsafe class UserListEntryLibrary : ObjectBase<UUserListEntryLibrary>
{
    public UserListEntryLibrary(IntPtr pointer) : base(pointer) {}
    public bool IsListItemSelected(TScriptInterface<IUserListEntry> UserListEntry)
    {
        Span<(string name, object value)> @params = [
            ("UserListEntry", UserListEntry)
        ];
        return ProcessEvent<bool>(GetFunction("IsListItemSelected"), @params);
    }
    public bool IsListItemExpanded(TScriptInterface<IUserListEntry> UserListEntry)
    {
        Span<(string name, object value)> @params = [
            ("UserListEntry", UserListEntry)
        ];
        return ProcessEvent<bool>(GetFunction("IsListItemExpanded"), @params);
    }
    public UListViewBase* GetOwningListView(TScriptInterface<IUserListEntry> UserListEntry)
    {
        Span<(string name, object value)> @params = [
            ("UserListEntry", UserListEntry)
        ];
        return (UListViewBase*)ProcessEvent<IntPtr>(GetFunction("GetOwningListView"), @params);
    }
}

public unsafe class UserObjectListEntry : ObjectBase<IUserObjectListEntry>
{
    public UserObjectListEntry(IntPtr pointer) : base(pointer) {}
    public void OnListItemObjectSet(UObject* ListItemObject)
    {
        Span<(string name, object value)> @params = [
            ("ListItemObject", (IntPtr)ListItemObject)
        ];
        ProcessEvent(GetFunction("OnListItemObjectSet"), @params);
    }
}

public unsafe class UserObjectListEntryLibrary : ObjectBase<UUserObjectListEntryLibrary>
{
    public UserObjectListEntryLibrary(IntPtr pointer) : base(pointer) {}
    public UObject* GetListItemObject(TScriptInterface<IUserObjectListEntry> UserObjectListEntry)
    {
        Span<(string name, object value)> @params = [
            ("UserObjectListEntry", UserObjectListEntry)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetListItemObject"), @params);
    }
}

public unsafe class ListViewBase : ObjectBase<UListViewBase>
{
    public ListViewBase(IntPtr pointer) : base(pointer) {}
    public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
    {
        Span<(string name, object value)> @params = [
            ("NewWheelScrollMultiplier", NewWheelScrollMultiplier)
        ];
        ProcessEvent(GetFunction("SetWheelScrollMultiplier"), @params);
    }
    public void SetScrollOffset(float InScrollOffset)
    {
        Span<(string name, object value)> @params = [
            ("InScrollOffset", InScrollOffset)
        ];
        ProcessEvent(GetFunction("SetScrollOffset"), @params);
    }
    public void SetScrollbarVisibility(ESlateVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetScrollbarVisibility"), @params);
    }
    public void ScrollToTop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ScrollToTop"), @params);
    }
    public void ScrollToBottom()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ScrollToBottom"), @params);
    }
    public void RequestRefresh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRefresh"), @params);
    }
    public void RegenerateAllEntries()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RegenerateAllEntries"), @params);
    }
    public TArray<IntPtr> GetDisplayedEntryWidgets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetDisplayedEntryWidgets"), @params);
    }
}

public unsafe class ListView : ObjectBase<UListView>
{
    public ListView(IntPtr pointer) : base(pointer) {}
    public void SetSelectionMode(ESelectionMode SelectionMode)
    {
        Span<(string name, object value)> @params = [
            ("SelectionMode", SelectionMode)
        ];
        ProcessEvent(GetFunction("SetSelectionMode"), @params);
    }
    public void SetSelectedIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetSelectedIndex"), @params);
    }
    public void ScrollIndexIntoView(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("ScrollIndexIntoView"), @params);
    }
    public void RemoveItem(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        ProcessEvent(GetFunction("RemoveItem"), @params);
    }
    public void NavigateToIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("NavigateToIndex"), @params);
    }
    public bool IsRefreshPending()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsRefreshPending"), @params);
    }
    public int GetNumItems()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumItems"), @params);
    }
    public TArray<IntPtr> GetListItems()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetListItems"), @params);
    }
    public UObject* GetItemAt(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetItemAt"), @params);
    }
    public int GetIndexForItem(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        return ProcessEvent<int>(GetFunction("GetIndexForItem"), @params);
    }
    public void ClearListItems()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearListItems"), @params);
    }
    public void BP_SetSelectedItem(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        ProcessEvent(GetFunction("BP_SetSelectedItem"), @params);
    }
    public void BP_SetListItems(ref TArray<IntPtr> InListItems)
    {
        Span<(string name, object value)> @params = [
            ("InListItems", InListItems)
        ];
        ProcessEvent(GetFunction("BP_SetListItems"), @params);
    }
    public void BP_SetItemSelection(UObject* Item, bool bSelected)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item), 
            ("bSelected", bSelected)
        ];
        ProcessEvent(GetFunction("BP_SetItemSelection"), @params);
    }
    public void BP_ScrollItemIntoView(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        ProcessEvent(GetFunction("BP_ScrollItemIntoView"), @params);
    }
    public void BP_NavigateToItem(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        ProcessEvent(GetFunction("BP_NavigateToItem"), @params);
    }
    public bool BP_IsItemVisible(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        return ProcessEvent<bool>(GetFunction("BP_IsItemVisible"), @params);
    }
    public bool BP_GetSelectedItems(ref TArray<IntPtr> Items)
    {
        Span<(string name, object value)> @params = [
            ("Items", Items)
        ];
        return ProcessEvent<bool>(GetFunction("BP_GetSelectedItems"), @params);
    }
    public UObject* BP_GetSelectedItem()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("BP_GetSelectedItem"), @params);
    }
    public int BP_GetNumItemsSelected()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("BP_GetNumItemsSelected"), @params);
    }
    public void BP_ClearSelection()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BP_ClearSelection"), @params);
    }
    public void BP_CancelScrollIntoView()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("BP_CancelScrollIntoView"), @params);
    }
    public void AddItem(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        ProcessEvent(GetFunction("AddItem"), @params);
    }
}

public unsafe class ListViewDesignerPreviewItem : ObjectBase<UListViewDesignerPreviewItem>
{
    public ListViewDesignerPreviewItem(IntPtr pointer) : base(pointer) {}}

public unsafe class MenuAnchor : ObjectBase<UMenuAnchor>
{
    public MenuAnchor(IntPtr pointer) : base(pointer) {}
    public void ToggleOpen(bool bFocusOnOpen)
    {
        Span<(string name, object value)> @params = [
            ("bFocusOnOpen", bFocusOnOpen)
        ];
        ProcessEvent(GetFunction("ToggleOpen"), @params);
    }
    public bool ShouldOpenDueToClick()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("ShouldOpenDueToClick"), @params);
    }
    public void SetPlacement(EMenuPlacement InPlacement)
    {
        Span<(string name, object value)> @params = [
            ("InPlacement", InPlacement)
        ];
        ProcessEvent(GetFunction("SetPlacement"), @params);
    }
    public void Open(bool bFocusMenu)
    {
        Span<(string name, object value)> @params = [
            ("bFocusMenu", bFocusMenu)
        ];
        ProcessEvent(GetFunction("Open"), @params);
    }
    public bool IsOpen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOpen"), @params);
    }
    public bool HasOpenSubMenus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasOpenSubMenus"), @params);
    }
    public UUserWidget* GetUserWidget__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("GetUserWidget__DelegateSignature"), @params);
    }
    public FVector2D GetMenuPosition()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetMenuPosition"), @params);
    }
    public void FitInWindow(bool bFit)
    {
        Span<(string name, object value)> @params = [
            ("bFit", bFit)
        ];
        ProcessEvent(GetFunction("FitInWindow"), @params);
    }
    public void Close()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Close"), @params);
    }
}

public unsafe class MouseCursorBinding : ObjectBase<UMouseCursorBinding>
{
    public MouseCursorBinding(IntPtr pointer) : base(pointer) {}
    public EMouseCursor GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMouseCursor>(GetFunction("GetValue"), @params);
    }
}

public unsafe class MovieScene2DTransformPropertySystem : ObjectBase<UMovieScene2DTransformPropertySystem>
{
    public MovieScene2DTransformPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieScene2DTransformSection : ObjectBase<UMovieScene2DTransformSection>
{
    public MovieScene2DTransformSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieScene2DTransformTrack : ObjectBase<UMovieScene2DTransformTrack>
{
    public MovieScene2DTransformTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneMarginPropertySystem : ObjectBase<UMovieSceneMarginPropertySystem>
{
    public MovieSceneMarginPropertySystem(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneMarginSection : ObjectBase<UMovieSceneMarginSection>
{
    public MovieSceneMarginSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMarginTrack : ObjectBase<UMovieSceneMarginTrack>
{
    public MovieSceneMarginTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneWidgetMaterialTrack : ObjectBase<UMovieSceneWidgetMaterialTrack>
{
    public MovieSceneWidgetMaterialTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MultiLineEditableText : ObjectBase<UMultiLineEditableText>
{
    public MultiLineEditableText(IntPtr pointer) : base(pointer) {}
    public void SetWidgetStyle(ref FTextBlockStyle InWidgetStyle)
    {
        Span<(string name, object value)> @params = [
            ("InWidgetStyle", InWidgetStyle)
        ];
        ProcessEvent(GetFunction("SetWidgetStyle"), @params);
    }
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetIsReadOnly(bool bReadOnly)
    {
        Span<(string name, object value)> @params = [
            ("bReadOnly", bReadOnly)
        ];
        ProcessEvent(GetFunction("SetIsReadOnly"), @params);
    }
    public void SetHintText(FText InHintText)
    {
        Span<(string name, object value)> @params = [
            ("InHintText", InHintText)
        ];
        ProcessEvent(GetFunction("SetHintText"), @params);
    }
    public void OnMultiLineEditableTextCommittedEvent__DelegateSignature(ref FText Text, ETextCommit CommitMethod)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text), 
            ("CommitMethod", CommitMethod)
        ];
        ProcessEvent(GetFunction("OnMultiLineEditableTextCommittedEvent__DelegateSignature"), @params);
    }
    public void OnMultiLineEditableTextChangedEvent__DelegateSignature(ref FText Text)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("OnMultiLineEditableTextChangedEvent__DelegateSignature"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public FText GetHintText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetHintText"), @params);
    }
}

public unsafe class MultiLineEditableTextBox : ObjectBase<UMultiLineEditableTextBox>
{
    public MultiLineEditableTextBox(IntPtr pointer) : base(pointer) {}
    public void SetTextStyle(ref FTextBlockStyle InTextStyle)
    {
        Span<(string name, object value)> @params = [
            ("InTextStyle", InTextStyle)
        ];
        ProcessEvent(GetFunction("SetTextStyle"), @params);
    }
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetIsReadOnly(bool bReadOnly)
    {
        Span<(string name, object value)> @params = [
            ("bReadOnly", bReadOnly)
        ];
        ProcessEvent(GetFunction("SetIsReadOnly"), @params);
    }
    public void SetHintText(FText InHintText)
    {
        Span<(string name, object value)> @params = [
            ("InHintText", InHintText)
        ];
        ProcessEvent(GetFunction("SetHintText"), @params);
    }
    public void SetError(FText InError)
    {
        Span<(string name, object value)> @params = [
            ("InError", InError)
        ];
        ProcessEvent(GetFunction("SetError"), @params);
    }
    public void OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature(ref FText Text, ETextCommit CommitMethod)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text), 
            ("CommitMethod", CommitMethod)
        ];
        ProcessEvent(GetFunction("OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature"), @params);
    }
    public void OnMultiLineEditableTextBoxChangedEvent__DelegateSignature(ref FText Text)
    {
        Span<(string name, object value)> @params = [
            ("Text", Text)
        ];
        ProcessEvent(GetFunction("OnMultiLineEditableTextBoxChangedEvent__DelegateSignature"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public FText GetHintText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetHintText"), @params);
    }
}

public unsafe class NamedSlot : ObjectBase<UNamedSlot>
{
    public NamedSlot(IntPtr pointer) : base(pointer) {}}

public unsafe class NamedSlotInterface : ObjectBase<INamedSlotInterface>
{
    public NamedSlotInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class NativeWidgetHost : ObjectBase<UNativeWidgetHost>
{
    public NativeWidgetHost(IntPtr pointer) : base(pointer) {}}

public unsafe class Overlay : ObjectBase<UOverlay>
{
    public Overlay(IntPtr pointer) : base(pointer) {}
    public UOverlaySlot* AddChildToOverlay(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UOverlaySlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToOverlay"), @params);
    }
}

public unsafe class OverlaySlot : ObjectBase<UOverlaySlot>
{
    public OverlaySlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class ProgressBar : ObjectBase<UProgressBar>
{
    public ProgressBar(IntPtr pointer) : base(pointer) {}
    public void SetPercent(float InPercent)
    {
        Span<(string name, object value)> @params = [
            ("InPercent", InPercent)
        ];
        ProcessEvent(GetFunction("SetPercent"), @params);
    }
    public void SetIsMarquee(bool InbIsMarquee)
    {
        Span<(string name, object value)> @params = [
            ("InbIsMarquee", InbIsMarquee)
        ];
        ProcessEvent(GetFunction("SetIsMarquee"), @params);
    }
    public void SetFillColorAndOpacity(FLinearColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("SetFillColorAndOpacity"), @params);
    }
}

public unsafe class RetainerBox : ObjectBase<URetainerBox>
{
    public RetainerBox(IntPtr pointer) : base(pointer) {}
    public void SetTextureParameter(FName TextureParameter)
    {
        Span<(string name, object value)> @params = [
            ("TextureParameter", TextureParameter)
        ];
        ProcessEvent(GetFunction("SetTextureParameter"), @params);
    }
    public void SetRetainRendering(bool bInRetainRendering)
    {
        Span<(string name, object value)> @params = [
            ("bInRetainRendering", bInRetainRendering)
        ];
        ProcessEvent(GetFunction("SetRetainRendering"), @params);
    }
    public void SetRenderingPhase(int RenderPhase, int TotalPhases)
    {
        Span<(string name, object value)> @params = [
            ("RenderPhase", RenderPhase), 
            ("TotalPhases", TotalPhases)
        ];
        ProcessEvent(GetFunction("SetRenderingPhase"), @params);
    }
    public void SetEffectMaterial(UMaterialInterface* EffectMaterial)
    {
        Span<(string name, object value)> @params = [
            ("EffectMaterial", (IntPtr)EffectMaterial)
        ];
        ProcessEvent(GetFunction("SetEffectMaterial"), @params);
    }
    public void RequestRender()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRender"), @params);
    }
    public UMaterialInstanceDynamic* GetEffectMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetEffectMaterial"), @params);
    }
}

public unsafe class RichTextBlock : ObjectBase<URichTextBlock>
{
    public RichTextBlock(IntPtr pointer) : base(pointer) {}
    public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
    {
        Span<(string name, object value)> @params = [
            ("InTransformPolicy", InTransformPolicy)
        ];
        ProcessEvent(GetFunction("SetTextTransformPolicy"), @params);
    }
    public void SetTextStyleSet(UDataTable* NewTextStyleSet)
    {
        Span<(string name, object value)> @params = [
            ("NewTextStyleSet", (IntPtr)NewTextStyleSet)
        ];
        ProcessEvent(GetFunction("SetTextStyleSet"), @params);
    }
    public void SetText(ref FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetMinDesiredWidth(float InMinDesiredWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredWidth", InMinDesiredWidth)
        ];
        ProcessEvent(GetFunction("SetMinDesiredWidth"), @params);
    }
    public void SetDefaultTextStyle(ref FTextBlockStyle InDefaultTextStyle)
    {
        Span<(string name, object value)> @params = [
            ("InDefaultTextStyle", InDefaultTextStyle)
        ];
        ProcessEvent(GetFunction("SetDefaultTextStyle"), @params);
    }
    public void SetDefaultStrikeBrush(ref FSlateBrush InStrikeBrush)
    {
        Span<(string name, object value)> @params = [
            ("InStrikeBrush", InStrikeBrush)
        ];
        ProcessEvent(GetFunction("SetDefaultStrikeBrush"), @params);
    }
    public void SetDefaultShadowOffset(FVector2D InShadowOffset)
    {
        Span<(string name, object value)> @params = [
            ("InShadowOffset", InShadowOffset)
        ];
        ProcessEvent(GetFunction("SetDefaultShadowOffset"), @params);
    }
    public void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InShadowColorAndOpacity", InShadowColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetDefaultShadowColorAndOpacity"), @params);
    }
    public void SetDefaultFont(FSlateFontInfo InFontInfo)
    {
        Span<(string name, object value)> @params = [
            ("InFontInfo", InFontInfo)
        ];
        ProcessEvent(GetFunction("SetDefaultFont"), @params);
    }
    public void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetDefaultColorAndOpacity"), @params);
    }
    public void SetAutoWrapText(bool InAutoTextWrap)
    {
        Span<(string name, object value)> @params = [
            ("InAutoTextWrap", InAutoTextWrap)
        ];
        ProcessEvent(GetFunction("SetAutoWrapText"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public URichTextBlockDecorator* GetDecoratorByClass(TSubclassOf<URichTextBlockDecorator> DecoratorClass)
    {
        Span<(string name, object value)> @params = [
            ("DecoratorClass", DecoratorClass)
        ];
        return (URichTextBlockDecorator*)ProcessEvent<IntPtr>(GetFunction("GetDecoratorByClass"), @params);
    }
    public void ClearAllDefaultStyleOverrides()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearAllDefaultStyleOverrides"), @params);
    }
}

public unsafe class RichTextBlockDecorator : ObjectBase<URichTextBlockDecorator>
{
    public RichTextBlockDecorator(IntPtr pointer) : base(pointer) {}}

public unsafe class RichTextBlockImageDecorator : ObjectBase<URichTextBlockImageDecorator>
{
    public RichTextBlockImageDecorator(IntPtr pointer) : base(pointer) {}
}

public unsafe class SafeZone : ObjectBase<USafeZone>
{
    public SafeZone(IntPtr pointer) : base(pointer) {}
    public void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom)
    {
        Span<(string name, object value)> @params = [
            ("InPadLeft", InPadLeft), 
            ("InPadRight", InPadRight), 
            ("InPadTop", InPadTop), 
            ("InPadBottom", InPadBottom)
        ];
        ProcessEvent(GetFunction("SetSidesToPad"), @params);
    }
}

public unsafe class SafeZoneSlot : ObjectBase<USafeZoneSlot>
{
    public SafeZoneSlot(IntPtr pointer) : base(pointer) {}
}

public unsafe class ScaleBox : ObjectBase<UScaleBox>
{
    public ScaleBox(IntPtr pointer) : base(pointer) {}
    public void SetUserSpecifiedScale(float InUserSpecifiedScale)
    {
        Span<(string name, object value)> @params = [
            ("InUserSpecifiedScale", InUserSpecifiedScale)
        ];
        ProcessEvent(GetFunction("SetUserSpecifiedScale"), @params);
    }
    public void SetStretchDirection(EStretchDirection InStretchDirection)
    {
        Span<(string name, object value)> @params = [
            ("InStretchDirection", InStretchDirection)
        ];
        ProcessEvent(GetFunction("SetStretchDirection"), @params);
    }
    public void SetStretch(EStretch InStretch)
    {
        Span<(string name, object value)> @params = [
            ("InStretch", InStretch)
        ];
        ProcessEvent(GetFunction("SetStretch"), @params);
    }
    public void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
    {
        Span<(string name, object value)> @params = [
            ("bInIgnoreInheritedScale", bInIgnoreInheritedScale)
        ];
        ProcessEvent(GetFunction("SetIgnoreInheritedScale"), @params);
    }
}

public unsafe class ScaleBoxSlot : ObjectBase<UScaleBoxSlot>
{
    public ScaleBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class ScrollBar : ObjectBase<UScrollBar>
{
    public ScrollBar(IntPtr pointer) : base(pointer) {}
    public void SetState(float InOffsetFraction, float InThumbSizeFraction)
    {
        Span<(string name, object value)> @params = [
            ("InOffsetFraction", InOffsetFraction), 
            ("InThumbSizeFraction", InThumbSizeFraction)
        ];
        ProcessEvent(GetFunction("SetState"), @params);
    }
}

public unsafe class ScrollBox : ObjectBase<UScrollBox>
{
    public ScrollBox(IntPtr pointer) : base(pointer) {}
    public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
    {
        Span<(string name, object value)> @params = [
            ("NewWheelScrollMultiplier", NewWheelScrollMultiplier)
        ];
        ProcessEvent(GetFunction("SetWheelScrollMultiplier"), @params);
    }
    public void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges)
    {
        Span<(string name, object value)> @params = [
            ("NewScrollWhenFocusChanges", NewScrollWhenFocusChanges)
        ];
        ProcessEvent(GetFunction("SetScrollWhenFocusChanges"), @params);
    }
    public void SetScrollOffset(float NewScrollOffset)
    {
        Span<(string name, object value)> @params = [
            ("NewScrollOffset", NewScrollOffset)
        ];
        ProcessEvent(GetFunction("SetScrollOffset"), @params);
    }
    public void SetScrollbarVisibility(ESlateVisibility NewScrollBarVisibility)
    {
        Span<(string name, object value)> @params = [
            ("NewScrollBarVisibility", NewScrollBarVisibility)
        ];
        ProcessEvent(GetFunction("SetScrollbarVisibility"), @params);
    }
    public void SetScrollbarThickness(ref FVector2D NewScrollbarThickness)
    {
        Span<(string name, object value)> @params = [
            ("NewScrollbarThickness", NewScrollbarThickness)
        ];
        ProcessEvent(GetFunction("SetScrollbarThickness"), @params);
    }
    public void SetScrollbarPadding(ref FMargin NewScrollbarPadding)
    {
        Span<(string name, object value)> @params = [
            ("NewScrollbarPadding", NewScrollbarPadding)
        ];
        ProcessEvent(GetFunction("SetScrollbarPadding"), @params);
    }
    public void SetOrientation(EOrientation NewOrientation)
    {
        Span<(string name, object value)> @params = [
            ("NewOrientation", NewOrientation)
        ];
        ProcessEvent(GetFunction("SetOrientation"), @params);
    }
    public void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel)
    {
        Span<(string name, object value)> @params = [
            ("NewConsumeMouseWheel", NewConsumeMouseWheel)
        ];
        ProcessEvent(GetFunction("SetConsumeMouseWheel"), @params);
    }
    public void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling)
    {
        Span<(string name, object value)> @params = [
            ("bShouldAnimateWheelScrolling", bShouldAnimateWheelScrolling)
        ];
        ProcessEvent(GetFunction("SetAnimateWheelScrolling"), @params);
    }
    public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)
    {
        Span<(string name, object value)> @params = [
            ("NewAlwaysShowScrollbar", NewAlwaysShowScrollbar)
        ];
        ProcessEvent(GetFunction("SetAlwaysShowScrollbar"), @params);
    }
    public void SetAllowOverscroll(bool NewAllowOverscroll)
    {
        Span<(string name, object value)> @params = [
            ("NewAllowOverscroll", NewAllowOverscroll)
        ];
        ProcessEvent(GetFunction("SetAllowOverscroll"), @params);
    }
    public void ScrollWidgetIntoView(UWidget* WidgetToFind, bool AnimateScroll, EDescendantScrollDestination ScrollDestination, float Padding)
    {
        Span<(string name, object value)> @params = [
            ("WidgetToFind", (IntPtr)WidgetToFind), 
            ("AnimateScroll", AnimateScroll), 
            ("ScrollDestination", ScrollDestination), 
            ("Padding", Padding)
        ];
        ProcessEvent(GetFunction("ScrollWidgetIntoView"), @params);
    }
    public void ScrollToStart()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ScrollToStart"), @params);
    }
    public void ScrollToEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ScrollToEnd"), @params);
    }
    public float GetViewOffsetFraction()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetViewOffsetFraction"), @params);
    }
    public float GetScrollOffsetOfEnd()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetScrollOffsetOfEnd"), @params);
    }
    public float GetScrollOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetScrollOffset"), @params);
    }
    public void EndInertialScrolling()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EndInertialScrolling"), @params);
    }
}

public unsafe class ScrollBoxSlot : ObjectBase<UScrollBoxSlot>
{
    public ScrollBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class SizeBox : ObjectBase<USizeBox>
{
    public SizeBox(IntPtr pointer) : base(pointer) {}
    public void SetWidthOverride(float InWidthOverride)
    {
        Span<(string name, object value)> @params = [
            ("InWidthOverride", InWidthOverride)
        ];
        ProcessEvent(GetFunction("SetWidthOverride"), @params);
    }
    public void SetMinDesiredWidth(float InMinDesiredWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredWidth", InMinDesiredWidth)
        ];
        ProcessEvent(GetFunction("SetMinDesiredWidth"), @params);
    }
    public void SetMinDesiredHeight(float InMinDesiredHeight)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredHeight", InMinDesiredHeight)
        ];
        ProcessEvent(GetFunction("SetMinDesiredHeight"), @params);
    }
    public void SetMinAspectRatio(float InMinAspectRatio)
    {
        Span<(string name, object value)> @params = [
            ("InMinAspectRatio", InMinAspectRatio)
        ];
        ProcessEvent(GetFunction("SetMinAspectRatio"), @params);
    }
    public void SetMaxDesiredWidth(float InMaxDesiredWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMaxDesiredWidth", InMaxDesiredWidth)
        ];
        ProcessEvent(GetFunction("SetMaxDesiredWidth"), @params);
    }
    public void SetMaxDesiredHeight(float InMaxDesiredHeight)
    {
        Span<(string name, object value)> @params = [
            ("InMaxDesiredHeight", InMaxDesiredHeight)
        ];
        ProcessEvent(GetFunction("SetMaxDesiredHeight"), @params);
    }
    public void SetMaxAspectRatio(float InMaxAspectRatio)
    {
        Span<(string name, object value)> @params = [
            ("InMaxAspectRatio", InMaxAspectRatio)
        ];
        ProcessEvent(GetFunction("SetMaxAspectRatio"), @params);
    }
    public void SetHeightOverride(float InHeightOverride)
    {
        Span<(string name, object value)> @params = [
            ("InHeightOverride", InHeightOverride)
        ];
        ProcessEvent(GetFunction("SetHeightOverride"), @params);
    }
    public void ClearWidthOverride()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearWidthOverride"), @params);
    }
    public void ClearMinDesiredWidth()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMinDesiredWidth"), @params);
    }
    public void ClearMinDesiredHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMinDesiredHeight"), @params);
    }
    public void ClearMinAspectRatio()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMinAspectRatio"), @params);
    }
    public void ClearMaxDesiredWidth()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMaxDesiredWidth"), @params);
    }
    public void ClearMaxDesiredHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMaxDesiredHeight"), @params);
    }
    public void ClearMaxAspectRatio()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMaxAspectRatio"), @params);
    }
    public void ClearHeightOverride()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearHeightOverride"), @params);
    }
}

public unsafe class SizeBoxSlot : ObjectBase<USizeBoxSlot>
{
    public SizeBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class SlateBlueprintLibrary : ObjectBase<USlateBlueprintLibrary>
{
    public SlateBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public FVector2D TransformVectorLocalToAbsolute(ref FGeometry Geometry, FVector2D LocalVector)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("LocalVector", LocalVector)
        ];
        return ProcessEvent<FVector2D>(GetFunction("TransformVectorLocalToAbsolute"), @params);
    }
    public FVector2D TransformVectorAbsoluteToLocal(ref FGeometry Geometry, FVector2D AbsoluteVector)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("AbsoluteVector", AbsoluteVector)
        ];
        return ProcessEvent<FVector2D>(GetFunction("TransformVectorAbsoluteToLocal"), @params);
    }
    public float TransformScalarLocalToAbsolute(ref FGeometry Geometry, float LocalScalar)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("LocalScalar", LocalScalar)
        ];
        return ProcessEvent<float>(GetFunction("TransformScalarLocalToAbsolute"), @params);
    }
    public float TransformScalarAbsoluteToLocal(ref FGeometry Geometry, float AbsoluteScalar)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("AbsoluteScalar", AbsoluteScalar)
        ];
        return ProcessEvent<float>(GetFunction("TransformScalarAbsoluteToLocal"), @params);
    }
    public void ScreenToWidgetLocal(UObject* WorldContextObject, ref FGeometry Geometry, FVector2D ScreenPosition, ref FVector2D LocalCoordinate, bool bIncludeWindowPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Geometry", Geometry), 
            ("ScreenPosition", ScreenPosition), 
            ("LocalCoordinate", LocalCoordinate), 
            ("bIncludeWindowPosition", bIncludeWindowPosition)
        ];
        ProcessEvent(GetFunction("ScreenToWidgetLocal"), @params);
    }
    public void ScreenToWidgetAbsolute(UObject* WorldContextObject, FVector2D ScreenPosition, ref FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ScreenPosition", ScreenPosition), 
            ("AbsoluteCoordinate", AbsoluteCoordinate), 
            ("bIncludeWindowPosition", bIncludeWindowPosition)
        ];
        ProcessEvent(GetFunction("ScreenToWidgetAbsolute"), @params);
    }
    public void ScreenToViewport(UObject* WorldContextObject, FVector2D ScreenPosition, ref FVector2D ViewportPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ScreenPosition", ScreenPosition), 
            ("ViewportPosition", ViewportPosition)
        ];
        ProcessEvent(GetFunction("ScreenToViewport"), @params);
    }
    public void LocalToViewport(UObject* WorldContextObject, ref FGeometry Geometry, FVector2D LocalCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Geometry", Geometry), 
            ("LocalCoordinate", LocalCoordinate), 
            ("PixelPosition", PixelPosition), 
            ("ViewportPosition", ViewportPosition)
        ];
        ProcessEvent(GetFunction("LocalToViewport"), @params);
    }
    public FVector2D LocalToAbsolute(ref FGeometry Geometry, FVector2D LocalCoordinate)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("LocalCoordinate", LocalCoordinate)
        ];
        return ProcessEvent<FVector2D>(GetFunction("LocalToAbsolute"), @params);
    }
    public bool IsUnderLocation(ref FGeometry Geometry, ref FVector2D AbsoluteCoordinate)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("AbsoluteCoordinate", AbsoluteCoordinate)
        ];
        return ProcessEvent<bool>(GetFunction("IsUnderLocation"), @params);
    }
    public FVector2D GetLocalTopLeft(ref FGeometry Geometry)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetLocalTopLeft"), @params);
    }
    public FVector2D GetLocalSize(ref FGeometry Geometry)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetLocalSize"), @params);
    }
    public FVector2D GetAbsoluteSize(ref FGeometry Geometry)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAbsoluteSize"), @params);
    }
    public bool EqualEqual_SlateBrush(ref FSlateBrush A, ref FSlateBrush B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("EqualEqual_SlateBrush"), @params);
    }
    public void AbsoluteToViewport(UObject* WorldContextObject, FVector2D AbsoluteDesktopCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("AbsoluteDesktopCoordinate", AbsoluteDesktopCoordinate), 
            ("PixelPosition", PixelPosition), 
            ("ViewportPosition", ViewportPosition)
        ];
        ProcessEvent(GetFunction("AbsoluteToViewport"), @params);
    }
    public FVector2D AbsoluteToLocal(ref FGeometry Geometry, FVector2D AbsoluteCoordinate)
    {
        Span<(string name, object value)> @params = [
            ("Geometry", Geometry), 
            ("AbsoluteCoordinate", AbsoluteCoordinate)
        ];
        return ProcessEvent<FVector2D>(GetFunction("AbsoluteToLocal"), @params);
    }
}

public unsafe class SlateVectorArtData : ObjectBase<USlateVectorArtData>
{
    public SlateVectorArtData(IntPtr pointer) : base(pointer) {}
}

public unsafe class SlateAccessibleWidgetData : ObjectBase<USlateAccessibleWidgetData>
{
    public SlateAccessibleWidgetData(IntPtr pointer) : base(pointer) {}
}

public unsafe class Slider : ObjectBase<USlider>
{
    public Slider(IntPtr pointer) : base(pointer) {}
    public void SetValue(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetValue"), @params);
    }
    public void SetStepSize(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetStepSize"), @params);
    }
    public void SetSliderHandleColor(FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetSliderHandleColor"), @params);
    }
    public void SetSliderBarColor(FLinearColor inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetSliderBarColor"), @params);
    }
    public void SetMinValue(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetMinValue"), @params);
    }
    public void SetMaxValue(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetMaxValue"), @params);
    }
    public void SetLocked(bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetLocked"), @params);
    }
    public void SetIndentHandle(bool inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("SetIndentHandle"), @params);
    }
    public float GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetValue"), @params);
    }
    public float GetNormalizedValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetNormalizedValue"), @params);
    }
}

public unsafe class Spacer : ObjectBase<USpacer>
{
    public Spacer(IntPtr pointer) : base(pointer) {}
    public void SetSize(FVector2D InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        ProcessEvent(GetFunction("SetSize"), @params);
    }
}

public unsafe class SpinBox : ObjectBase<USpinBox>
{
    public SpinBox(IntPtr pointer) : base(pointer) {}
    public void SetValue(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetValue"), @params);
    }
    public void SetMinValue(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMinValue"), @params);
    }
    public void SetMinSliderValue(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMinSliderValue"), @params);
    }
    public void SetMinFractionalDigits(int NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMinFractionalDigits"), @params);
    }
    public void SetMaxValue(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMaxValue"), @params);
    }
    public void SetMaxSliderValue(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMaxSliderValue"), @params);
    }
    public void SetMaxFractionalDigits(int NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetMaxFractionalDigits"), @params);
    }
    public void SetForegroundColor(FSlateColor InForegroundColor)
    {
        Span<(string name, object value)> @params = [
            ("InForegroundColor", InForegroundColor)
        ];
        ProcessEvent(GetFunction("SetForegroundColor"), @params);
    }
    public void SetDelta(float NewValue)
    {
        Span<(string name, object value)> @params = [
            ("NewValue", NewValue)
        ];
        ProcessEvent(GetFunction("SetDelta"), @params);
    }
    public void SetAlwaysUsesDeltaSnap(bool bNewValue)
    {
        Span<(string name, object value)> @params = [
            ("bNewValue", bNewValue)
        ];
        ProcessEvent(GetFunction("SetAlwaysUsesDeltaSnap"), @params);
    }
    public void OnSpinBoxValueCommittedEvent__DelegateSignature(float inValue, ETextCommit CommitMethod)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue), 
            ("CommitMethod", CommitMethod)
        ];
        ProcessEvent(GetFunction("OnSpinBoxValueCommittedEvent__DelegateSignature"), @params);
    }
    public void OnSpinBoxValueChangedEvent__DelegateSignature(float inValue)
    {
        Span<(string name, object value)> @params = [
            ("inValue", inValue)
        ];
        ProcessEvent(GetFunction("OnSpinBoxValueChangedEvent__DelegateSignature"), @params);
    }
    public void OnSpinBoxBeginSliderMovement__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnSpinBoxBeginSliderMovement__DelegateSignature"), @params);
    }
    public float GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetValue"), @params);
    }
    public float GetMinValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMinValue"), @params);
    }
    public float GetMinSliderValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMinSliderValue"), @params);
    }
    public int GetMinFractionalDigits()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMinFractionalDigits"), @params);
    }
    public float GetMaxValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxValue"), @params);
    }
    public float GetMaxSliderValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetMaxSliderValue"), @params);
    }
    public int GetMaxFractionalDigits()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetMaxFractionalDigits"), @params);
    }
    public float GetDelta()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetDelta"), @params);
    }
    public bool GetAlwaysUsesDeltaSnap()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetAlwaysUsesDeltaSnap"), @params);
    }
    public void ClearMinValue()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMinValue"), @params);
    }
    public void ClearMinSliderValue()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMinSliderValue"), @params);
    }
    public void ClearMaxValue()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMaxValue"), @params);
    }
    public void ClearMaxSliderValue()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearMaxSliderValue"), @params);
    }
}

public unsafe class TextBinding : ObjectBase<UTextBinding>
{
    public TextBinding(IntPtr pointer) : base(pointer) {}
    public FText GetTextValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetTextValue"), @params);
    }
    public FString GetStringValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetStringValue"), @params);
    }
}

public unsafe class TextBlock : ObjectBase<UTextBlock>
{
    public TextBlock(IntPtr pointer) : base(pointer) {}
    public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
    {
        Span<(string name, object value)> @params = [
            ("InTransformPolicy", InTransformPolicy)
        ];
        ProcessEvent(GetFunction("SetTextTransformPolicy"), @params);
    }
    public void SetText(FText InText)
    {
        Span<(string name, object value)> @params = [
            ("InText", InText)
        ];
        ProcessEvent(GetFunction("SetText"), @params);
    }
    public void SetStrikeBrush(FSlateBrush InStrikeBrush)
    {
        Span<(string name, object value)> @params = [
            ("InStrikeBrush", InStrikeBrush)
        ];
        ProcessEvent(GetFunction("SetStrikeBrush"), @params);
    }
    public void SetShadowOffset(FVector2D InShadowOffset)
    {
        Span<(string name, object value)> @params = [
            ("InShadowOffset", InShadowOffset)
        ];
        ProcessEvent(GetFunction("SetShadowOffset"), @params);
    }
    public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InShadowColorAndOpacity", InShadowColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetShadowColorAndOpacity"), @params);
    }
    public void SetOpacity(float InOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InOpacity", InOpacity)
        ];
        ProcessEvent(GetFunction("SetOpacity"), @params);
    }
    public void SetMinDesiredWidth(float InMinDesiredWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredWidth", InMinDesiredWidth)
        ];
        ProcessEvent(GetFunction("SetMinDesiredWidth"), @params);
    }
    public void SetFont(FSlateFontInfo InFontInfo)
    {
        Span<(string name, object value)> @params = [
            ("InFontInfo", InFontInfo)
        ];
        ProcessEvent(GetFunction("SetFont"), @params);
    }
    public void SetColorAndOpacity(FSlateColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetColorAndOpacity"), @params);
    }
    public void SetAutoWrapText(bool InAutoTextWrap)
    {
        Span<(string name, object value)> @params = [
            ("InAutoTextWrap", InAutoTextWrap)
        ];
        ProcessEvent(GetFunction("SetAutoWrapText"), @params);
    }
    public FText GetText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicOutlineMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicOutlineMaterial"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicFontMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicFontMaterial"), @params);
    }
}

public unsafe class Throbber : ObjectBase<UThrobber>
{
    public Throbber(IntPtr pointer) : base(pointer) {}
    public void SetNumberOfPieces(int InNumberOfPieces)
    {
        Span<(string name, object value)> @params = [
            ("InNumberOfPieces", InNumberOfPieces)
        ];
        ProcessEvent(GetFunction("SetNumberOfPieces"), @params);
    }
    public void SetAnimateVertically(bool bInAnimateVertically)
    {
        Span<(string name, object value)> @params = [
            ("bInAnimateVertically", bInAnimateVertically)
        ];
        ProcessEvent(GetFunction("SetAnimateVertically"), @params);
    }
    public void SetAnimateOpacity(bool bInAnimateOpacity)
    {
        Span<(string name, object value)> @params = [
            ("bInAnimateOpacity", bInAnimateOpacity)
        ];
        ProcessEvent(GetFunction("SetAnimateOpacity"), @params);
    }
    public void SetAnimateHorizontally(bool bInAnimateHorizontally)
    {
        Span<(string name, object value)> @params = [
            ("bInAnimateHorizontally", bInAnimateHorizontally)
        ];
        ProcessEvent(GetFunction("SetAnimateHorizontally"), @params);
    }
}

public unsafe class TileView : ObjectBase<UTileView>
{
    public TileView(IntPtr pointer) : base(pointer) {}
    public void SetEntryWidth(float NewWidth)
    {
        Span<(string name, object value)> @params = [
            ("NewWidth", NewWidth)
        ];
        ProcessEvent(GetFunction("SetEntryWidth"), @params);
    }
    public void SetEntryHeight(float NewHeight)
    {
        Span<(string name, object value)> @params = [
            ("NewHeight", NewHeight)
        ];
        ProcessEvent(GetFunction("SetEntryHeight"), @params);
    }
    public float GetEntryWidth()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEntryWidth"), @params);
    }
    public float GetEntryHeight()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEntryHeight"), @params);
    }
}

public unsafe class TreeView : ObjectBase<UTreeView>
{
    public TreeView(IntPtr pointer) : base(pointer) {}
    public void SetItemExpansion(UObject* Item, bool bExpandItem)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item), 
            ("bExpandItem", bExpandItem)
        ];
        ProcessEvent(GetFunction("SetItemExpansion"), @params);
    }
    public void ExpandAll()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ExpandAll"), @params);
    }
    public void CollapseAll()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CollapseAll"), @params);
    }
}

public unsafe class UMGSequencePlayer : ObjectBase<UUMGSequencePlayer>
{
    public UMGSequencePlayer(IntPtr pointer) : base(pointer) {}
    public void SetUserTag(FName InUserTag)
    {
        Span<(string name, object value)> @params = [
            ("InUserTag", InUserTag)
        ];
        ProcessEvent(GetFunction("SetUserTag"), @params);
    }
    public FName GetUserTag()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FName>(GetFunction("GetUserTag"), @params);
    }
}

public unsafe class UMGSequenceTickManager : ObjectBase<UUMGSequenceTickManager>
{
    public UMGSequenceTickManager(IntPtr pointer) : base(pointer) {}
}

public unsafe class UniformGridPanel : ObjectBase<UUniformGridPanel>
{
    public UniformGridPanel(IntPtr pointer) : base(pointer) {}
    public void SetSlotPadding(FMargin InSlotPadding)
    {
        Span<(string name, object value)> @params = [
            ("InSlotPadding", InSlotPadding)
        ];
        ProcessEvent(GetFunction("SetSlotPadding"), @params);
    }
    public void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredSlotWidth", InMinDesiredSlotWidth)
        ];
        ProcessEvent(GetFunction("SetMinDesiredSlotWidth"), @params);
    }
    public void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)
    {
        Span<(string name, object value)> @params = [
            ("InMinDesiredSlotHeight", InMinDesiredSlotHeight)
        ];
        ProcessEvent(GetFunction("SetMinDesiredSlotHeight"), @params);
    }
    public UUniformGridSlot* AddChildToUniformGrid(UWidget* Content, int InRow, int InColumn)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content), 
            ("InRow", InRow), 
            ("InColumn", InColumn)
        ];
        return (UUniformGridSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToUniformGrid"), @params);
    }
}

public unsafe class UniformGridSlot : ObjectBase<UUniformGridSlot>
{
    public UniformGridSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetRow(int InRow)
    {
        Span<(string name, object value)> @params = [
            ("InRow", InRow)
        ];
        ProcessEvent(GetFunction("SetRow"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
    public void SetColumn(int InColumn)
    {
        Span<(string name, object value)> @params = [
            ("InColumn", InColumn)
        ];
        ProcessEvent(GetFunction("SetColumn"), @params);
    }
}

public unsafe class VerticalBox : ObjectBase<UVerticalBox>
{
    public VerticalBox(IntPtr pointer) : base(pointer) {}
    public UVerticalBoxSlot* AddChildToVerticalBox(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UVerticalBoxSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToVerticalBox"), @params);
    }
}

public unsafe class VerticalBoxSlot : ObjectBase<UVerticalBoxSlot>
{
    public VerticalBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetSize(FSlateChildSize InSize)
    {
        Span<(string name, object value)> @params = [
            ("InSize", InSize)
        ];
        ProcessEvent(GetFunction("SetSize"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class Viewport : ObjectBase<UViewport>
{
    public Viewport(IntPtr pointer) : base(pointer) {}
    public AActor* Spawn(TSubclassOf<AActor> ActorClass)
    {
        Span<(string name, object value)> @params = [
            ("ActorClass", ActorClass)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("Spawn"), @params);
    }
    public void SetViewRotation(FRotator Rotation)
    {
        Span<(string name, object value)> @params = [
            ("Rotation", Rotation)
        ];
        ProcessEvent(GetFunction("SetViewRotation"), @params);
    }
    public void SetViewLocation(FVector Location)
    {
        Span<(string name, object value)> @params = [
            ("Location", Location)
        ];
        ProcessEvent(GetFunction("SetViewLocation"), @params);
    }
    public FRotator GetViewRotation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FRotator>(GetFunction("GetViewRotation"), @params);
    }
    public UWorld* GetViewportWorld()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWorld*)ProcessEvent<IntPtr>(GetFunction("GetViewportWorld"), @params);
    }
    public FVector GetViewLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector>(GetFunction("GetViewLocation"), @params);
    }
}

public unsafe class VisibilityBinding : ObjectBase<UVisibilityBinding>
{
    public VisibilityBinding(IntPtr pointer) : base(pointer) {}
    public ESlateVisibility GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ESlateVisibility>(GetFunction("GetValue"), @params);
    }
}

public unsafe class WidgetAnimation : ObjectBase<UWidgetAnimation>
{
    public WidgetAnimation(IntPtr pointer) : base(pointer) {}
    public void UnbindAllFromAnimationStarted(UUserWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        ProcessEvent(GetFunction("UnbindAllFromAnimationStarted"), @params);
    }
    public void UnbindAllFromAnimationFinished(UUserWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        ProcessEvent(GetFunction("UnbindAllFromAnimationFinished"), @params);
    }
    public float GetStartTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetStartTime"), @params);
    }
    public float GetEndTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetEndTime"), @params);
    }
}

public unsafe class WidgetAnimationDelegateBinding : ObjectBase<UWidgetAnimationDelegateBinding>
{
    public WidgetAnimationDelegateBinding(IntPtr pointer) : base(pointer) {}
}

public unsafe class WidgetAnimationPlayCallbackProxy : ObjectBase<UWidgetAnimationPlayCallbackProxy>
{
    public WidgetAnimationPlayCallbackProxy(IntPtr pointer) : base(pointer) {}
    public UWidgetAnimationPlayCallbackProxy* CreatePlayAnimationTimeRangeProxyObject(ref UUMGSequencePlayer* Result, UUserWidget* Widget, UWidgetAnimation* InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, EUMGSequencePlayMode PlayMode, float PlaybackSpeed)
    {
        Span<(string name, object value)> @params = [
            ("Result", (IntPtr)Result), 
            ("Widget", (IntPtr)Widget), 
            ("InAnimation", (IntPtr)InAnimation), 
            ("StartAtTime", StartAtTime), 
            ("EndAtTime", EndAtTime), 
            ("NumLoopsToPlay", NumLoopsToPlay), 
            ("PlayMode", PlayMode), 
            ("PlaybackSpeed", PlaybackSpeed)
        ];
        return (UWidgetAnimationPlayCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreatePlayAnimationTimeRangeProxyObject"), @params);
    }
    public UWidgetAnimationPlayCallbackProxy* CreatePlayAnimationProxyObject(ref UUMGSequencePlayer* Result, UUserWidget* Widget, UWidgetAnimation* InAnimation, float StartAtTime, int NumLoopsToPlay, EUMGSequencePlayMode PlayMode, float PlaybackSpeed)
    {
        Span<(string name, object value)> @params = [
            ("Result", (IntPtr)Result), 
            ("Widget", (IntPtr)Widget), 
            ("InAnimation", (IntPtr)InAnimation), 
            ("StartAtTime", StartAtTime), 
            ("NumLoopsToPlay", NumLoopsToPlay), 
            ("PlayMode", PlayMode), 
            ("PlaybackSpeed", PlaybackSpeed)
        ];
        return (UWidgetAnimationPlayCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("CreatePlayAnimationProxyObject"), @params);
    }
}

public unsafe class WidgetBinding : ObjectBase<UWidgetBinding>
{
    public WidgetBinding(IntPtr pointer) : base(pointer) {}
    public UWidget* GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetValue"), @params);
    }
}

public unsafe class WidgetBlueprintGeneratedClass : ObjectBase<UWidgetBlueprintGeneratedClass>
{
    public WidgetBlueprintGeneratedClass(IntPtr pointer) : base(pointer) {}
}

public unsafe class WidgetBlueprintLibrary : ObjectBase<UWidgetBlueprintLibrary>
{
    public WidgetBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public FEventReply UnlockMouse(ref FEventReply Reply)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply)
        ];
        return ProcessEvent<FEventReply>(GetFunction("UnlockMouse"), @params);
    }
    public FEventReply Unhandled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FEventReply>(GetFunction("Unhandled"), @params);
    }
    public void SetWindowTitleBarState(UWidget* TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible)
    {
        Span<(string name, object value)> @params = [
            ("TitleBarContent", (IntPtr)TitleBarContent), 
            ("Mode", Mode), 
            ("bTitleBarDragEnabled", bTitleBarDragEnabled), 
            ("bWindowButtonsVisible", bWindowButtonsVisible), 
            ("bTitleBarVisible", bTitleBarVisible)
        ];
        ProcessEvent(GetFunction("SetWindowTitleBarState"), @params);
    }
    public void SetWindowTitleBarCloseButtonActive(bool bActive)
    {
        Span<(string name, object value)> @params = [
            ("bActive", bActive)
        ];
        ProcessEvent(GetFunction("SetWindowTitleBarCloseButtonActive"), @params);
    }
    public FEventReply SetUserFocus(ref FEventReply Reply, UWidget* FocusWidget, bool bInAllUsers)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("FocusWidget", (IntPtr)FocusWidget), 
            ("bInAllUsers", bInAllUsers)
        ];
        return ProcessEvent<FEventReply>(GetFunction("SetUserFocus"), @params);
    }
    public FEventReply SetMousePosition(ref FEventReply Reply, FVector2D NewMousePosition)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("NewMousePosition", NewMousePosition)
        ];
        return ProcessEvent<FEventReply>(GetFunction("SetMousePosition"), @params);
    }
    public void SetInputMode_UIOnlyEx(APlayerController* PlayerController, UWidget* InWidgetToFocus, EMouseLockMode InMouseLockMode)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("InWidgetToFocus", (IntPtr)InWidgetToFocus), 
            ("InMouseLockMode", InMouseLockMode)
        ];
        ProcessEvent(GetFunction("SetInputMode_UIOnlyEx"), @params);
    }
    public void SetInputMode_UIOnly(APlayerController* Target, UWidget* InWidgetToFocus, bool bLockMouseToViewport)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("InWidgetToFocus", (IntPtr)InWidgetToFocus), 
            ("bLockMouseToViewport", bLockMouseToViewport)
        ];
        ProcessEvent(GetFunction("SetInputMode_UIOnly"), @params);
    }
    public void SetInputMode_GameOnly(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        ProcessEvent(GetFunction("SetInputMode_GameOnly"), @params);
    }
    public void SetInputMode_GameAndUIEx(APlayerController* PlayerController, UWidget* InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("InWidgetToFocus", (IntPtr)InWidgetToFocus), 
            ("InMouseLockMode", InMouseLockMode), 
            ("bHideCursorDuringCapture", bHideCursorDuringCapture)
        ];
        ProcessEvent(GetFunction("SetInputMode_GameAndUIEx"), @params);
    }
    public void SetInputMode_GameAndUI(APlayerController* Target, UWidget* InWidgetToFocus, bool bLockMouseToViewport, bool bHideCursorDuringCapture)
    {
        Span<(string name, object value)> @params = [
            ("Target", (IntPtr)Target), 
            ("InWidgetToFocus", (IntPtr)InWidgetToFocus), 
            ("bLockMouseToViewport", bLockMouseToViewport), 
            ("bHideCursorDuringCapture", bHideCursorDuringCapture)
        ];
        ProcessEvent(GetFunction("SetInputMode_GameAndUI"), @params);
    }
    public bool SetHardwareCursor(UObject* WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CursorShape", CursorShape), 
            ("CursorName", CursorName), 
            ("HotSpot", HotSpot)
        ];
        return ProcessEvent<bool>(GetFunction("SetHardwareCursor"), @params);
    }
    public void SetFocusToGameViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetFocusToGameViewport"), @params);
    }
    public void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency)
    {
        Span<(string name, object value)> @params = [
            ("Type", Type), 
            ("Severity", Severity), 
            ("CorrectDeficiency", CorrectDeficiency), 
            ("ShowCorrectionWithDeficiency", ShowCorrectionWithDeficiency)
        ];
        ProcessEvent(GetFunction("SetColorVisionDeficiencyType"), @params);
    }
    public void SetBrushResourceToTexture(ref FSlateBrush Brush, UTexture2D* Texture)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush), 
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetBrushResourceToTexture"), @params);
    }
    public void SetBrushResourceToMaterial(ref FSlateBrush Brush, UMaterialInterface* Material)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush), 
            ("Material", (IntPtr)Material)
        ];
        ProcessEvent(GetFunction("SetBrushResourceToMaterial"), @params);
    }
    public void RestorePreviousWindowTitleBarState()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RestorePreviousWindowTitleBarState"), @params);
    }
    public FEventReply ReleaseMouseCapture(ref FEventReply Reply)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply)
        ];
        return ProcessEvent<FEventReply>(GetFunction("ReleaseMouseCapture"), @params);
    }
    public FEventReply ReleaseJoystickCapture(ref FEventReply Reply, bool bInAllJoysticks)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("bInAllJoysticks", bInAllJoysticks)
        ];
        return ProcessEvent<FEventReply>(GetFunction("ReleaseJoystickCapture"), @params);
    }
    public void OnGameWindowCloseButtonClickedDelegate__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnGameWindowCloseButtonClickedDelegate__DelegateSignature"), @params);
    }
    public FSlateBrush NoResourceBrush()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("NoResourceBrush"), @params);
    }
    public FSlateBrush MakeBrushFromTexture(UTexture2D* Texture, int Width, int Height)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("Width", Width), 
            ("Height", Height)
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("MakeBrushFromTexture"), @params);
    }
    public FSlateBrush MakeBrushFromMaterial(UMaterialInterface* Material, int Width, int Height)
    {
        Span<(string name, object value)> @params = [
            ("Material", (IntPtr)Material), 
            ("Width", Width), 
            ("Height", Height)
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("MakeBrushFromMaterial"), @params);
    }
    public FSlateBrush MakeBrushFromAsset(USlateBrushAsset* BrushAsset)
    {
        Span<(string name, object value)> @params = [
            ("BrushAsset", (IntPtr)BrushAsset)
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("MakeBrushFromAsset"), @params);
    }
    public FEventReply LockMouse(ref FEventReply Reply, UWidget* CapturingWidget)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("CapturingWidget", (IntPtr)CapturingWidget)
        ];
        return ProcessEvent<FEventReply>(GetFunction("LockMouse"), @params);
    }
    public bool IsDragDropping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsDragDropping"), @params);
    }
    public FEventReply Handled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FEventReply>(GetFunction("Handled"), @params);
    }
    public void GetSafeZonePadding(UObject* WorldContextObject, ref FVector4 SafePadding, ref FVector2D SafePaddingScale, ref FVector4 SpillOverPadding)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("SafePadding", SafePadding), 
            ("SafePaddingScale", SafePaddingScale), 
            ("SpillOverPadding", SpillOverPadding)
        ];
        ProcessEvent(GetFunction("GetSafeZonePadding"), @params);
    }
    public FKeyEvent GetKeyEventFromAnalogInputEvent(ref FAnalogInputEvent Event)
    {
        Span<(string name, object value)> @params = [
            ("Event", Event)
        ];
        return ProcessEvent<FKeyEvent>(GetFunction("GetKeyEventFromAnalogInputEvent"), @params);
    }
    public FInputEvent GetInputEventFromPointerEvent(ref FPointerEvent Event)
    {
        Span<(string name, object value)> @params = [
            ("Event", Event)
        ];
        return ProcessEvent<FInputEvent>(GetFunction("GetInputEventFromPointerEvent"), @params);
    }
    public FInputEvent GetInputEventFromNavigationEvent(ref FNavigationEvent Event)
    {
        Span<(string name, object value)> @params = [
            ("Event", Event)
        ];
        return ProcessEvent<FInputEvent>(GetFunction("GetInputEventFromNavigationEvent"), @params);
    }
    public FInputEvent GetInputEventFromKeyEvent(ref FKeyEvent Event)
    {
        Span<(string name, object value)> @params = [
            ("Event", Event)
        ];
        return ProcessEvent<FInputEvent>(GetFunction("GetInputEventFromKeyEvent"), @params);
    }
    public FInputEvent GetInputEventFromCharacterEvent(ref FCharacterEvent Event)
    {
        Span<(string name, object value)> @params = [
            ("Event", Event)
        ];
        return ProcessEvent<FInputEvent>(GetFunction("GetInputEventFromCharacterEvent"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicMaterial(ref FSlateBrush Brush)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush)
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicMaterial"), @params);
    }
    public UDragDropOperation* GetDragDroppingContent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UDragDropOperation*)ProcessEvent<IntPtr>(GetFunction("GetDragDroppingContent"), @params);
    }
    public UTexture2D* GetBrushResourceAsTexture2D(ref FSlateBrush Brush)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush)
        ];
        return (UTexture2D*)ProcessEvent<IntPtr>(GetFunction("GetBrushResourceAsTexture2D"), @params);
    }
    public UMaterialInterface* GetBrushResourceAsMaterial(ref FSlateBrush Brush)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush)
        ];
        return (UMaterialInterface*)ProcessEvent<IntPtr>(GetFunction("GetBrushResourceAsMaterial"), @params);
    }
    public UObject* GetBrushResource(ref FSlateBrush Brush)
    {
        Span<(string name, object value)> @params = [
            ("Brush", Brush)
        ];
        return (UObject*)ProcessEvent<IntPtr>(GetFunction("GetBrushResource"), @params);
    }
    public void GetAllWidgetsWithInterface(UObject* WorldContextObject, ref TArray<IntPtr> FoundWidgets, TSubclassOf<UInterface> Interface, bool TopLevelOnly)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("FoundWidgets", FoundWidgets), 
            ("Interface", Interface), 
            ("TopLevelOnly", TopLevelOnly)
        ];
        ProcessEvent(GetFunction("GetAllWidgetsWithInterface"), @params);
    }
    public void GetAllWidgetsOfClass(UObject* WorldContextObject, ref TArray<IntPtr> FoundWidgets, TSubclassOf<UUserWidget> WidgetClass, bool TopLevelOnly)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("FoundWidgets", FoundWidgets), 
            ("WidgetClass", WidgetClass), 
            ("TopLevelOnly", TopLevelOnly)
        ];
        ProcessEvent(GetFunction("GetAllWidgetsOfClass"), @params);
    }
    public FEventReply EndDragDrop(ref FEventReply Reply)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply)
        ];
        return ProcessEvent<FEventReply>(GetFunction("EndDragDrop"), @params);
    }
    public void DrawTextFormatted(ref FPaintContext Context, ref FText Text, FVector2D Position, UFont* Font, int FontSize, FName FontTypeFace, FLinearColor Tint)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context), 
            ("Text", Text), 
            ("Position", Position), 
            ("Font", (IntPtr)Font), 
            ("FontSize", FontSize), 
            ("FontTypeFace", FontTypeFace), 
            ("Tint", Tint)
        ];
        ProcessEvent(GetFunction("DrawTextFormatted"), @params);
    }
    public void DrawText(ref FPaintContext Context, FString inString, FVector2D Position, FLinearColor Tint)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context), 
            ("inString", inString), 
            ("Position", Position), 
            ("Tint", Tint)
        ];
        ProcessEvent(GetFunction("DrawText"), @params);
    }
    public void DrawLines(ref FPaintContext Context, ref TArray<FVector2D> Points, FLinearColor Tint, bool bAntiAlias, float Thickness)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context), 
            ("Points", Points), 
            ("Tint", Tint), 
            ("bAntiAlias", bAntiAlias), 
            ("Thickness", Thickness)
        ];
        ProcessEvent(GetFunction("DrawLines"), @params);
    }
    public void DrawLine(ref FPaintContext Context, FVector2D PositionA, FVector2D PositionB, FLinearColor Tint, bool bAntiAlias, float Thickness)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context), 
            ("PositionA", PositionA), 
            ("PositionB", PositionB), 
            ("Tint", Tint), 
            ("bAntiAlias", bAntiAlias), 
            ("Thickness", Thickness)
        ];
        ProcessEvent(GetFunction("DrawLine"), @params);
    }
    public void DrawBox(ref FPaintContext Context, FVector2D Position, FVector2D Size, USlateBrushAsset* Brush, FLinearColor Tint)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context), 
            ("Position", Position), 
            ("Size", Size), 
            ("Brush", (IntPtr)Brush), 
            ("Tint", Tint)
        ];
        ProcessEvent(GetFunction("DrawBox"), @params);
    }
    public void DismissAllMenus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DismissAllMenus"), @params);
    }
    public FEventReply DetectDragIfPressed(ref FPointerEvent PointerEvent, UWidget* WidgetDetectingDrag, FKey DragKey)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent), 
            ("WidgetDetectingDrag", (IntPtr)WidgetDetectingDrag), 
            ("DragKey", DragKey)
        ];
        return ProcessEvent<FEventReply>(GetFunction("DetectDragIfPressed"), @params);
    }
    public FEventReply DetectDrag(ref FEventReply Reply, UWidget* WidgetDetectingDrag, FKey DragKey)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("WidgetDetectingDrag", (IntPtr)WidgetDetectingDrag), 
            ("DragKey", DragKey)
        ];
        return ProcessEvent<FEventReply>(GetFunction("DetectDrag"), @params);
    }
    public UDragDropOperation* CreateDragDropOperation(TSubclassOf<UDragDropOperation> OperationClass)
    {
        Span<(string name, object value)> @params = [
            ("OperationClass", OperationClass)
        ];
        return (UDragDropOperation*)ProcessEvent<IntPtr>(GetFunction("CreateDragDropOperation"), @params);
    }
    public UUserWidget* Create(UObject* WorldContextObject, TSubclassOf<UUserWidget> WidgetType, APlayerController* OwningPlayer)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("WidgetType", WidgetType), 
            ("OwningPlayer", (IntPtr)OwningPlayer)
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("Create"), @params);
    }
    public FEventReply ClearUserFocus(ref FEventReply Reply, bool bInAllUsers)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("bInAllUsers", bInAllUsers)
        ];
        return ProcessEvent<FEventReply>(GetFunction("ClearUserFocus"), @params);
    }
    public FEventReply CaptureMouse(ref FEventReply Reply, UWidget* CapturingWidget)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("CapturingWidget", (IntPtr)CapturingWidget)
        ];
        return ProcessEvent<FEventReply>(GetFunction("CaptureMouse"), @params);
    }
    public FEventReply CaptureJoystick(ref FEventReply Reply, UWidget* CapturingWidget, bool bInAllJoysticks)
    {
        Span<(string name, object value)> @params = [
            ("Reply", Reply), 
            ("CapturingWidget", (IntPtr)CapturingWidget), 
            ("bInAllJoysticks", bInAllJoysticks)
        ];
        return ProcessEvent<FEventReply>(GetFunction("CaptureJoystick"), @params);
    }
    public void CancelDragDrop()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CancelDragDrop"), @params);
    }
}

public unsafe class WidgetComponent : ObjectBase<UWidgetComponent>
{
    public WidgetComponent(IntPtr pointer) : base(pointer) {}
    public void SetWindowVisibility(EWindowVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetWindowVisibility"), @params);
    }
    public void SetWindowFocusable(bool bInWindowFocusable)
    {
        Span<(string name, object value)> @params = [
            ("bInWindowFocusable", bInWindowFocusable)
        ];
        ProcessEvent(GetFunction("SetWindowFocusable"), @params);
    }
    public void SetWidgetSpace(EWidgetSpace NewSpace)
    {
        Span<(string name, object value)> @params = [
            ("NewSpace", NewSpace)
        ];
        ProcessEvent(GetFunction("SetWidgetSpace"), @params);
    }
    public void SetWidget(UUserWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        ProcessEvent(GetFunction("SetWidget"), @params);
    }
    public void SetTwoSided(bool bWantTwoSided)
    {
        Span<(string name, object value)> @params = [
            ("bWantTwoSided", bWantTwoSided)
        ];
        ProcessEvent(GetFunction("SetTwoSided"), @params);
    }
    public void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("NewTintColorAndOpacity", NewTintColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetTintColorAndOpacity"), @params);
    }
    public void SetTickWhenOffscreen(bool bWantTickWhenOffscreen)
    {
        Span<(string name, object value)> @params = [
            ("bWantTickWhenOffscreen", bWantTickWhenOffscreen)
        ];
        ProcessEvent(GetFunction("SetTickWhenOffscreen"), @params);
    }
    public void SetTickMode(ETickMode InTickMode)
    {
        Span<(string name, object value)> @params = [
            ("InTickMode", InTickMode)
        ];
        ProcessEvent(GetFunction("SetTickMode"), @params);
    }
    public void SetRedrawTime(float InRedrawTime)
    {
        Span<(string name, object value)> @params = [
            ("InRedrawTime", InRedrawTime)
        ];
        ProcessEvent(GetFunction("SetRedrawTime"), @params);
    }
    public void SetPivot(ref FVector2D InPivot)
    {
        Span<(string name, object value)> @params = [
            ("InPivot", InPivot)
        ];
        ProcessEvent(GetFunction("SetPivot"), @params);
    }
    public void SetOwnerPlayer(ULocalPlayer* LocalPlayer)
    {
        Span<(string name, object value)> @params = [
            ("LocalPlayer", (IntPtr)LocalPlayer)
        ];
        ProcessEvent(GetFunction("SetOwnerPlayer"), @params);
    }
    public void SetManuallyRedraw(bool bUseManualRedraw)
    {
        Span<(string name, object value)> @params = [
            ("bUseManualRedraw", bUseManualRedraw)
        ];
        ProcessEvent(GetFunction("SetManuallyRedraw"), @params);
    }
    public void SetGeometryMode(EWidgetGeometryMode InGeometryMode)
    {
        Span<(string name, object value)> @params = [
            ("InGeometryMode", InGeometryMode)
        ];
        ProcessEvent(GetFunction("SetGeometryMode"), @params);
    }
    public void SetDrawSize(FVector2D Size)
    {
        Span<(string name, object value)> @params = [
            ("Size", Size)
        ];
        ProcessEvent(GetFunction("SetDrawSize"), @params);
    }
    public void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize)
    {
        Span<(string name, object value)> @params = [
            ("bInDrawAtDesiredSize", bInDrawAtDesiredSize)
        ];
        ProcessEvent(GetFunction("SetDrawAtDesiredSize"), @params);
    }
    public void SetCylinderArcAngle(float InCylinderArcAngle)
    {
        Span<(string name, object value)> @params = [
            ("InCylinderArcAngle", InCylinderArcAngle)
        ];
        ProcessEvent(GetFunction("SetCylinderArcAngle"), @params);
    }
    public void SetBackgroundColor(FLinearColor NewBackgroundColor)
    {
        Span<(string name, object value)> @params = [
            ("NewBackgroundColor", NewBackgroundColor)
        ];
        ProcessEvent(GetFunction("SetBackgroundColor"), @params);
    }
    public void RequestRenderUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRenderUpdate"), @params);
    }
    public void RequestRedraw()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RequestRedraw"), @params);
    }
    public bool IsWidgetVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsWidgetVisible"), @params);
    }
    public EWindowVisibility GetWindowVisiblility()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EWindowVisibility>(GetFunction("GetWindowVisiblility"), @params);
    }
    public bool GetWindowFocusable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetWindowFocusable"), @params);
    }
    public EWidgetSpace GetWidgetSpace()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EWidgetSpace>(GetFunction("GetWidgetSpace"), @params);
    }
    public UUserWidget* GetWidget()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("GetWidget"), @params);
    }
    public UUserWidget* GetUserWidgetObject()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UUserWidget*)ProcessEvent<IntPtr>(GetFunction("GetUserWidgetObject"), @params);
    }
    public bool GetTwoSided()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetTwoSided"), @params);
    }
    public bool GetTickWhenOffscreen()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetTickWhenOffscreen"), @params);
    }
    public UTextureRenderTarget2D* GetRenderTarget()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTextureRenderTarget2D*)ProcessEvent<IntPtr>(GetFunction("GetRenderTarget"), @params);
    }
    public float GetRedrawTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRedrawTime"), @params);
    }
    public FVector2D GetPivot()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetPivot"), @params);
    }
    public ULocalPlayer* GetOwnerPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULocalPlayer*)ProcessEvent<IntPtr>(GetFunction("GetOwnerPlayer"), @params);
    }
    public UMaterialInstanceDynamic* GetMaterialInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetMaterialInstance"), @params);
    }
    public bool GetManuallyRedraw()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetManuallyRedraw"), @params);
    }
    public EWidgetGeometryMode GetGeometryMode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EWidgetGeometryMode>(GetFunction("GetGeometryMode"), @params);
    }
    public FVector2D GetDrawSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetDrawSize"), @params);
    }
    public bool GetDrawAtDesiredSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetDrawAtDesiredSize"), @params);
    }
    public float GetCylinderArcAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCylinderArcAngle"), @params);
    }
    public FVector2D GetCurrentDrawSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetCurrentDrawSize"), @params);
    }
}

public unsafe class WidgetInteractionComponent : ObjectBase<UWidgetInteractionComponent>
{
    public WidgetInteractionComponent(IntPtr pointer) : base(pointer) {}
    public void SetFocus(UWidget* FocusWidget)
    {
        Span<(string name, object value)> @params = [
            ("FocusWidget", (IntPtr)FocusWidget)
        ];
        ProcessEvent(GetFunction("SetFocus"), @params);
    }
    public void SetCustomHitResult(ref FHitResult HitResult)
    {
        Span<(string name, object value)> @params = [
            ("HitResult", HitResult)
        ];
        ProcessEvent(GetFunction("SetCustomHitResult"), @params);
    }
    public bool SendKeyChar(FString Characters, bool bRepeat)
    {
        Span<(string name, object value)> @params = [
            ("Characters", Characters), 
            ("bRepeat", bRepeat)
        ];
        return ProcessEvent<bool>(GetFunction("SendKeyChar"), @params);
    }
    public void ScrollWheel(float ScrollDelta)
    {
        Span<(string name, object value)> @params = [
            ("ScrollDelta", ScrollDelta)
        ];
        ProcessEvent(GetFunction("ScrollWheel"), @params);
    }
    public void ReleasePointerKey(FKey Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        ProcessEvent(GetFunction("ReleasePointerKey"), @params);
    }
    public bool ReleaseKey(FKey Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        return ProcessEvent<bool>(GetFunction("ReleaseKey"), @params);
    }
    public void PressPointerKey(FKey Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        ProcessEvent(GetFunction("PressPointerKey"), @params);
    }
    public bool PressKey(FKey Key, bool bRepeat)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key), 
            ("bRepeat", bRepeat)
        ];
        return ProcessEvent<bool>(GetFunction("PressKey"), @params);
    }
    public bool PressAndReleaseKey(FKey Key)
    {
        Span<(string name, object value)> @params = [
            ("Key", Key)
        ];
        return ProcessEvent<bool>(GetFunction("PressAndReleaseKey"), @params);
    }
    public bool IsOverInteractableWidget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOverInteractableWidget"), @params);
    }
    public bool IsOverHitTestVisibleWidget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOverHitTestVisibleWidget"), @params);
    }
    public bool IsOverFocusableWidget()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsOverFocusableWidget"), @params);
    }
    public FHitResult GetLastHitResult()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FHitResult>(GetFunction("GetLastHitResult"), @params);
    }
    public UWidgetComponent* GetHoveredWidgetComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWidgetComponent*)ProcessEvent<IntPtr>(GetFunction("GetHoveredWidgetComponent"), @params);
    }
    public FVector2D Get2DHitLocation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("Get2DHitLocation"), @params);
    }
}

public unsafe class WidgetLayoutLibrary : ObjectBase<UWidgetLayoutLibrary>
{
    public WidgetLayoutLibrary(IntPtr pointer) : base(pointer) {}
    public UWrapBoxSlot* SlotAsWrapBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UWrapBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsWrapBoxSlot"), @params);
    }
    public UWidgetSwitcherSlot* SlotAsWidgetSwitcherSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UWidgetSwitcherSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsWidgetSwitcherSlot"), @params);
    }
    public UVerticalBoxSlot* SlotAsVerticalBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UVerticalBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsVerticalBoxSlot"), @params);
    }
    public UUniformGridSlot* SlotAsUniformGridSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UUniformGridSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsUniformGridSlot"), @params);
    }
    public USizeBoxSlot* SlotAsSizeBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (USizeBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsSizeBoxSlot"), @params);
    }
    public UScrollBoxSlot* SlotAsScrollBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UScrollBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsScrollBoxSlot"), @params);
    }
    public UScaleBoxSlot* SlotAsScaleBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UScaleBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsScaleBoxSlot"), @params);
    }
    public USafeZoneSlot* SlotAsSafeBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (USafeZoneSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsSafeBoxSlot"), @params);
    }
    public UOverlaySlot* SlotAsOverlaySlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UOverlaySlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsOverlaySlot"), @params);
    }
    public UHorizontalBoxSlot* SlotAsHorizontalBoxSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UHorizontalBoxSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsHorizontalBoxSlot"), @params);
    }
    public UGridSlot* SlotAsGridSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UGridSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsGridSlot"), @params);
    }
    public UCanvasPanelSlot* SlotAsCanvasSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UCanvasPanelSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsCanvasSlot"), @params);
    }
    public UBorderSlot* SlotAsBorderSlot(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        return (UBorderSlot*)ProcessEvent<IntPtr>(GetFunction("SlotAsBorderSlot"), @params);
    }
    public void RemoveAllWidgets(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        ProcessEvent(GetFunction("RemoveAllWidgets"), @params);
    }
    public bool ProjectWorldLocationToWidgetPosition(APlayerController* PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController), 
            ("WorldLocation", WorldLocation), 
            ("ScreenPosition", ScreenPosition), 
            ("bPlayerViewportRelative", bPlayerViewportRelative)
        ];
        return ProcessEvent<bool>(GetFunction("ProjectWorldLocationToWidgetPosition"), @params);
    }
    public FGeometry GetViewportWidgetGeometry(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<FGeometry>(GetFunction("GetViewportWidgetGeometry"), @params);
    }
    public FVector2D GetViewportSize(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetViewportSize"), @params);
    }
    public float GetViewportScale(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<float>(GetFunction("GetViewportScale"), @params);
    }
    public FGeometry GetPlayerScreenWidgetGeometry(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return ProcessEvent<FGeometry>(GetFunction("GetPlayerScreenWidgetGeometry"), @params);
    }
    public bool GetMousePositionScaledByDPI(APlayerController* Player, ref float LocationX, ref float LocationY)
    {
        Span<(string name, object value)> @params = [
            ("Player", (IntPtr)Player), 
            ("LocationX", LocationX), 
            ("LocationY", LocationY)
        ];
        return ProcessEvent<bool>(GetFunction("GetMousePositionScaledByDPI"), @params);
    }
    public FVector2D GetMousePositionOnViewport(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetMousePositionOnViewport"), @params);
    }
    public FVector2D GetMousePositionOnPlatform()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetMousePositionOnPlatform"), @params);
    }
}

public unsafe class WidgetNavigation : ObjectBase<UWidgetNavigation>
{
    public WidgetNavigation(IntPtr pointer) : base(pointer) {}
}

public unsafe class WidgetSwitcher : ObjectBase<UWidgetSwitcher>
{
    public WidgetSwitcher(IntPtr pointer) : base(pointer) {}
    public void SetActiveWidgetIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("SetActiveWidgetIndex"), @params);
    }
    public void SetActiveWidget(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        ProcessEvent(GetFunction("SetActiveWidget"), @params);
    }
    public UWidget* GetWidgetAtIndex(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetWidgetAtIndex"), @params);
    }
    public int GetNumWidgets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumWidgets"), @params);
    }
    public int GetActiveWidgetIndex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetActiveWidgetIndex"), @params);
    }
    public UWidget* GetActiveWidget()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetActiveWidget"), @params);
    }
}

public unsafe class WidgetSwitcherSlot : ObjectBase<UWidgetSwitcherSlot>
{
    public WidgetSwitcherSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class WidgetTree : ObjectBase<UWidgetTree>
{
    public WidgetTree(IntPtr pointer) : base(pointer) {}
}

public unsafe class WindowTitleBarArea : ObjectBase<UWindowTitleBarArea>
{
    public WindowTitleBarArea(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class WindowTitleBarAreaSlot : ObjectBase<UWindowTitleBarAreaSlot>
{
    public WindowTitleBarAreaSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class WrapBox : ObjectBase<UWrapBox>
{
    public WrapBox(IntPtr pointer) : base(pointer) {}
    public void SetInnerSlotPadding(FVector2D InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetInnerSlotPadding"), @params);
    }
    public UWrapBoxSlot* AddChildToWrapBox(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UWrapBoxSlot*)ProcessEvent<IntPtr>(GetFunction("AddChildToWrapBox"), @params);
    }
}

public unsafe class WrapBoxSlot : ObjectBase<UWrapBoxSlot>
{
    public WrapBoxSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
    public void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)
    {
        Span<(string name, object value)> @params = [
            ("InFillSpanWhenLessThan", InFillSpanWhenLessThan)
        ];
        ProcessEvent(GetFunction("SetFillSpanWhenLessThan"), @params);
    }
    public void SetFillEmptySpace(bool InbFillEmptySpace)
    {
        Span<(string name, object value)> @params = [
            ("InbFillEmptySpace", InbFillEmptySpace)
        ];
        ProcessEvent(GetFunction("SetFillEmptySpace"), @params);
    }
}

public unsafe class Visual : ObjectBase<UVisual>
{
    public Visual(IntPtr pointer) : base(pointer) {}}

public unsafe class Widget : ObjectBase<UWidget>
{
    public Widget(IntPtr pointer) : base(pointer) {}
    public void SetVisibility(ESlateVisibility InVisibility)
    {
        Span<(string name, object value)> @params = [
            ("InVisibility", InVisibility)
        ];
        ProcessEvent(GetFunction("SetVisibility"), @params);
    }
    public void SetUserFocus(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        ProcessEvent(GetFunction("SetUserFocus"), @params);
    }
    public void SetToolTipText(ref FText InToolTipText)
    {
        Span<(string name, object value)> @params = [
            ("InToolTipText", InToolTipText)
        ];
        ProcessEvent(GetFunction("SetToolTipText"), @params);
    }
    public void SetToolTip(UWidget* Widget)
    {
        Span<(string name, object value)> @params = [
            ("Widget", (IntPtr)Widget)
        ];
        ProcessEvent(GetFunction("SetToolTip"), @params);
    }
    public void SetRenderTranslation(FVector2D Translation)
    {
        Span<(string name, object value)> @params = [
            ("Translation", Translation)
        ];
        ProcessEvent(GetFunction("SetRenderTranslation"), @params);
    }
    public void SetRenderTransformPivot(FVector2D Pivot)
    {
        Span<(string name, object value)> @params = [
            ("Pivot", Pivot)
        ];
        ProcessEvent(GetFunction("SetRenderTransformPivot"), @params);
    }
    public void SetRenderTransformAngle(float Angle)
    {
        Span<(string name, object value)> @params = [
            ("Angle", Angle)
        ];
        ProcessEvent(GetFunction("SetRenderTransformAngle"), @params);
    }
    public void SetRenderTransform(FWidgetTransform InTransform)
    {
        Span<(string name, object value)> @params = [
            ("InTransform", InTransform)
        ];
        ProcessEvent(GetFunction("SetRenderTransform"), @params);
    }
    public void SetRenderShear(FVector2D Shear)
    {
        Span<(string name, object value)> @params = [
            ("Shear", Shear)
        ];
        ProcessEvent(GetFunction("SetRenderShear"), @params);
    }
    public void SetRenderScale(FVector2D Scale)
    {
        Span<(string name, object value)> @params = [
            ("Scale", Scale)
        ];
        ProcessEvent(GetFunction("SetRenderScale"), @params);
    }
    public void SetRenderOpacity(float InOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InOpacity", InOpacity)
        ];
        ProcessEvent(GetFunction("SetRenderOpacity"), @params);
    }
    public void SetNavigationRuleExplicit(EUINavigation Direction, UWidget* InWidget)
    {
        Span<(string name, object value)> @params = [
            ("Direction", Direction), 
            ("InWidget", (IntPtr)InWidget)
        ];
        ProcessEvent(GetFunction("SetNavigationRuleExplicit"), @params);
    }
    public void SetNavigationRuleBase(EUINavigation Direction, EUINavigationRule Rule)
    {
        Span<(string name, object value)> @params = [
            ("Direction", Direction), 
            ("Rule", Rule)
        ];
        ProcessEvent(GetFunction("SetNavigationRuleBase"), @params);
    }
    public void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, FName WidgetToFocus)
    {
        Span<(string name, object value)> @params = [
            ("Direction", Direction), 
            ("Rule", Rule), 
            ("WidgetToFocus", WidgetToFocus)
        ];
        ProcessEvent(GetFunction("SetNavigationRule"), @params);
    }
    public void SetKeyboardFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetKeyboardFocus"), @params);
    }
    public void SetIsEnabled(bool bInIsEnabled)
    {
        Span<(string name, object value)> @params = [
            ("bInIsEnabled", bInIsEnabled)
        ];
        ProcessEvent(GetFunction("SetIsEnabled"), @params);
    }
    public void SetFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetFocus"), @params);
    }
    public void SetCursor(EMouseCursor InCursor)
    {
        Span<(string name, object value)> @params = [
            ("InCursor", InCursor)
        ];
        ProcessEvent(GetFunction("SetCursor"), @params);
    }
    public void SetClipping(EWidgetClipping InClipping)
    {
        Span<(string name, object value)> @params = [
            ("InClipping", InClipping)
        ];
        ProcessEvent(GetFunction("SetClipping"), @params);
    }
    public void SetAllNavigationRules(EUINavigationRule Rule, FName WidgetToFocus)
    {
        Span<(string name, object value)> @params = [
            ("Rule", Rule), 
            ("WidgetToFocus", WidgetToFocus)
        ];
        ProcessEvent(GetFunction("SetAllNavigationRules"), @params);
    }
    public void ResetCursor()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ResetCursor"), @params);
    }
    public void RemoveFromParent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveFromParent"), @params);
    }
    public FEventReply OnReply__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnReply__DelegateSignature"), @params);
    }
    public FEventReply OnPointerEvent__DelegateSignature(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnPointerEvent__DelegateSignature"), @params);
    }
    public bool IsVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsVisible"), @params);
    }
    public bool IsHovered()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsHovered"), @params);
    }
    public void InvalidateLayoutAndVolatility()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InvalidateLayoutAndVolatility"), @params);
    }
    public bool HasUserFocusedDescendants(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return ProcessEvent<bool>(GetFunction("HasUserFocusedDescendants"), @params);
    }
    public bool HasUserFocus(APlayerController* PlayerController)
    {
        Span<(string name, object value)> @params = [
            ("PlayerController", (IntPtr)PlayerController)
        ];
        return ProcessEvent<bool>(GetFunction("HasUserFocus"), @params);
    }
    public bool HasMouseCaptureByUser(int UserIndex, int PointerIndex)
    {
        Span<(string name, object value)> @params = [
            ("UserIndex", UserIndex), 
            ("PointerIndex", PointerIndex)
        ];
        return ProcessEvent<bool>(GetFunction("HasMouseCaptureByUser"), @params);
    }
    public bool HasMouseCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasMouseCapture"), @params);
    }
    public bool HasKeyboardFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasKeyboardFocus"), @params);
    }
    public bool HasFocusedDescendants()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasFocusedDescendants"), @params);
    }
    public bool HasAnyUserFocus()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasAnyUserFocus"), @params);
    }
    public UWidget* GetWidget__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetWidget__DelegateSignature"), @params);
    }
    public ESlateVisibility GetVisibility()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ESlateVisibility>(GetFunction("GetVisibility"), @params);
    }
    public FGeometry GetTickSpaceGeometry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FGeometry>(GetFunction("GetTickSpaceGeometry"), @params);
    }
    public FText GetText__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetText__DelegateSignature"), @params);
    }
    public ESlateVisibility GetSlateVisibility__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ESlateVisibility>(GetFunction("GetSlateVisibility__DelegateSignature"), @params);
    }
    public FSlateColor GetSlateColor__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSlateColor>(GetFunction("GetSlateColor__DelegateSignature"), @params);
    }
    public FSlateBrush GetSlateBrush__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("GetSlateBrush__DelegateSignature"), @params);
    }
    public float GetRenderTransformAngle()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRenderTransformAngle"), @params);
    }
    public float GetRenderOpacity()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetRenderOpacity"), @params);
    }
    public UPanelWidget* GetParent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPanelWidget*)ProcessEvent<IntPtr>(GetFunction("GetParent"), @params);
    }
    public FGeometry GetPaintSpaceGeometry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FGeometry>(GetFunction("GetPaintSpaceGeometry"), @params);
    }
    public APlayerController* GetOwningPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (APlayerController*)ProcessEvent<IntPtr>(GetFunction("GetOwningPlayer"), @params);
    }
    public ULocalPlayer* GetOwningLocalPlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULocalPlayer*)ProcessEvent<IntPtr>(GetFunction("GetOwningLocalPlayer"), @params);
    }
    public EMouseCursor GetMouseCursor__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMouseCursor>(GetFunction("GetMouseCursor__DelegateSignature"), @params);
    }
    public FLinearColor GetLinearColor__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetLinearColor__DelegateSignature"), @params);
    }
    public bool GetIsEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetIsEnabled"), @params);
    }
    public int GetInt32__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetInt32__DelegateSignature"), @params);
    }
    public UGameInstance* GetGameInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UGameInstance*)ProcessEvent<IntPtr>(GetFunction("GetGameInstance"), @params);
    }
    public float GetFloat__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetFloat__DelegateSignature"), @params);
    }
    public FVector2D GetDesiredSize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetDesiredSize"), @params);
    }
    public EWidgetClipping GetClipping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EWidgetClipping>(GetFunction("GetClipping"), @params);
    }
    public ECheckBoxState GetCheckBoxState__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<ECheckBoxState>(GetFunction("GetCheckBoxState__DelegateSignature"), @params);
    }
    public FGeometry GetCachedGeometry()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FGeometry>(GetFunction("GetCachedGeometry"), @params);
    }
    public bool GetBool__DelegateSignature()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetBool__DelegateSignature"), @params);
    }
    public FText GetAccessibleText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetAccessibleText"), @params);
    }
    public FText GetAccessibleSummaryText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetAccessibleSummaryText"), @params);
    }
    public UWidget* GenerateWidgetForString__DelegateSignature(FString Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", Item)
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GenerateWidgetForString__DelegateSignature"), @params);
    }
    public UWidget* GenerateWidgetForObject__DelegateSignature(UObject* Item)
    {
        Span<(string name, object value)> @params = [
            ("Item", (IntPtr)Item)
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GenerateWidgetForObject__DelegateSignature"), @params);
    }
    public void ForceVolatile(bool bForce)
    {
        Span<(string name, object value)> @params = [
            ("bForce", bForce)
        ];
        ProcessEvent(GetFunction("ForceVolatile"), @params);
    }
    public void ForceLayoutPrepass()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceLayoutPrepass"), @params);
    }
}

public unsafe class TextLayoutWidget : ObjectBase<UTextLayoutWidget>
{
    public TextLayoutWidget(IntPtr pointer) : base(pointer) {}
    public void SetJustification(ETextJustify InJustification)
    {
        Span<(string name, object value)> @params = [
            ("InJustification", InJustification)
        ];
        ProcessEvent(GetFunction("SetJustification"), @params);
    }
}

public unsafe class UserWidget : ObjectBase<UUserWidget>
{
    public UserWidget(IntPtr pointer) : base(pointer) {}
    public void UnregisterInputComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("UnregisterInputComponent"), @params);
    }
    public void UnbindAllFromAnimationStarted(UWidgetAnimation* Animation)
    {
        Span<(string name, object value)> @params = [
            ("Animation", (IntPtr)Animation)
        ];
        ProcessEvent(GetFunction("UnbindAllFromAnimationStarted"), @params);
    }
    public void UnbindAllFromAnimationFinished(UWidgetAnimation* Animation)
    {
        Span<(string name, object value)> @params = [
            ("Animation", (IntPtr)Animation)
        ];
        ProcessEvent(GetFunction("UnbindAllFromAnimationFinished"), @params);
    }
    public void Tick(FGeometry MyGeometry, float inDeltaTime)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("inDeltaTime", inDeltaTime)
        ];
        ProcessEvent(GetFunction("Tick"), @params);
    }
    public void StopListeningForInputAction(FName ActionName, EInputEvent EventType)
    {
        Span<(string name, object value)> @params = [
            ("ActionName", ActionName), 
            ("EventType", EventType)
        ];
        ProcessEvent(GetFunction("StopListeningForInputAction"), @params);
    }
    public void StopListeningForAllInputActions()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopListeningForAllInputActions"), @params);
    }
    public void StopAnimationsAndLatentActions()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAnimationsAndLatentActions"), @params);
    }
    public void StopAnimation(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        ProcessEvent(GetFunction("StopAnimation"), @params);
    }
    public void StopAllAnimations()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopAllAnimations"), @params);
    }
    public void SetPositionInViewport(FVector2D Position, bool bRemoveDPIScale)
    {
        Span<(string name, object value)> @params = [
            ("Position", Position), 
            ("bRemoveDPIScale", bRemoveDPIScale)
        ];
        ProcessEvent(GetFunction("SetPositionInViewport"), @params);
    }
    public void SetPlaybackSpeed(UWidgetAnimation* InAnimation, float PlaybackSpeed)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("PlaybackSpeed", PlaybackSpeed)
        ];
        ProcessEvent(GetFunction("SetPlaybackSpeed"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetOwningPlayer(APlayerController* LocalPlayerController)
    {
        Span<(string name, object value)> @params = [
            ("LocalPlayerController", (IntPtr)LocalPlayerController)
        ];
        ProcessEvent(GetFunction("SetOwningPlayer"), @params);
    }
    public void SetNumLoopsToPlay(UWidgetAnimation* InAnimation, int NumLoopsToPlay)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("NumLoopsToPlay", NumLoopsToPlay)
        ];
        ProcessEvent(GetFunction("SetNumLoopsToPlay"), @params);
    }
    public void SetInputActionPriority(int NewPriority)
    {
        Span<(string name, object value)> @params = [
            ("NewPriority", NewPriority)
        ];
        ProcessEvent(GetFunction("SetInputActionPriority"), @params);
    }
    public void SetInputActionBlocking(bool bShouldBlock)
    {
        Span<(string name, object value)> @params = [
            ("bShouldBlock", bShouldBlock)
        ];
        ProcessEvent(GetFunction("SetInputActionBlocking"), @params);
    }
    public void SetForegroundColor(FSlateColor InForegroundColor)
    {
        Span<(string name, object value)> @params = [
            ("InForegroundColor", InForegroundColor)
        ];
        ProcessEvent(GetFunction("SetForegroundColor"), @params);
    }
    public void SetDesiredSizeInViewport(FVector2D Size)
    {
        Span<(string name, object value)> @params = [
            ("Size", Size)
        ];
        ProcessEvent(GetFunction("SetDesiredSizeInViewport"), @params);
    }
    public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InColorAndOpacity", InColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetColorAndOpacity"), @params);
    }
    public void SetAnimationCurrentTime(UWidgetAnimation* InAnimation, float InTime)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("InTime", InTime)
        ];
        ProcessEvent(GetFunction("SetAnimationCurrentTime"), @params);
    }
    public void SetAnchorsInViewport(FAnchors Anchors)
    {
        Span<(string name, object value)> @params = [
            ("Anchors", Anchors)
        ];
        ProcessEvent(GetFunction("SetAnchorsInViewport"), @params);
    }
    public void SetAlignmentInViewport(FVector2D Alignment)
    {
        Span<(string name, object value)> @params = [
            ("Alignment", Alignment)
        ];
        ProcessEvent(GetFunction("SetAlignmentInViewport"), @params);
    }
    public void ReverseAnimation(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        ProcessEvent(GetFunction("ReverseAnimation"), @params);
    }
    public void RemoveFromViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RemoveFromViewport"), @params);
    }
    public void RegisterInputComponent()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RegisterInputComponent"), @params);
    }
    public void PreConstruct(bool IsDesignTime)
    {
        Span<(string name, object value)> @params = [
            ("IsDesignTime", IsDesignTime)
        ];
        ProcessEvent(GetFunction("PreConstruct"), @params);
    }
    public void PlaySound(USoundBase* SoundToPlay)
    {
        Span<(string name, object value)> @params = [
            ("SoundToPlay", (IntPtr)SoundToPlay)
        ];
        ProcessEvent(GetFunction("PlaySound"), @params);
    }
    public UUMGSequencePlayer* PlayAnimationTimeRange(UWidgetAnimation* InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, EUMGSequencePlayMode PlayMode, float PlaybackSpeed, bool bRestoreState)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("StartAtTime", StartAtTime), 
            ("EndAtTime", EndAtTime), 
            ("NumLoopsToPlay", NumLoopsToPlay), 
            ("PlayMode", PlayMode), 
            ("PlaybackSpeed", PlaybackSpeed), 
            ("bRestoreState", bRestoreState)
        ];
        return (UUMGSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("PlayAnimationTimeRange"), @params);
    }
    public UUMGSequencePlayer* PlayAnimationReverse(UWidgetAnimation* InAnimation, float PlaybackSpeed, bool bRestoreState)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("PlaybackSpeed", PlaybackSpeed), 
            ("bRestoreState", bRestoreState)
        ];
        return (UUMGSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("PlayAnimationReverse"), @params);
    }
    public UUMGSequencePlayer* PlayAnimationForward(UWidgetAnimation* InAnimation, float PlaybackSpeed, bool bRestoreState)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("PlaybackSpeed", PlaybackSpeed), 
            ("bRestoreState", bRestoreState)
        ];
        return (UUMGSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("PlayAnimationForward"), @params);
    }
    public UUMGSequencePlayer* PlayAnimation(UWidgetAnimation* InAnimation, float StartAtTime, int NumLoopsToPlay, EUMGSequencePlayMode PlayMode, float PlaybackSpeed, bool bRestoreState)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation), 
            ("StartAtTime", StartAtTime), 
            ("NumLoopsToPlay", NumLoopsToPlay), 
            ("PlayMode", PlayMode), 
            ("PlaybackSpeed", PlaybackSpeed), 
            ("bRestoreState", bRestoreState)
        ];
        return (UUMGSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("PlayAnimation"), @params);
    }
    public float PauseAnimation(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        return ProcessEvent<float>(GetFunction("PauseAnimation"), @params);
    }
    public FEventReply OnTouchStarted(FGeometry MyGeometry, ref FPointerEvent InTouchEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InTouchEvent", InTouchEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnTouchStarted"), @params);
    }
    public FEventReply OnTouchMoved(FGeometry MyGeometry, ref FPointerEvent InTouchEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InTouchEvent", InTouchEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnTouchMoved"), @params);
    }
    public FEventReply OnTouchGesture(FGeometry MyGeometry, ref FPointerEvent GestureEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("GestureEvent", GestureEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnTouchGesture"), @params);
    }
    public FEventReply OnTouchForceChanged(FGeometry MyGeometry, ref FPointerEvent InTouchEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InTouchEvent", InTouchEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnTouchForceChanged"), @params);
    }
    public FEventReply OnTouchEnded(FGeometry MyGeometry, ref FPointerEvent InTouchEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InTouchEvent", InTouchEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnTouchEnded"), @params);
    }
    public void OnRemovedFromFocusPath(FFocusEvent InFocusEvent)
    {
        Span<(string name, object value)> @params = [
            ("InFocusEvent", InFocusEvent)
        ];
        ProcessEvent(GetFunction("OnRemovedFromFocusPath"), @params);
    }
    public FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnPreviewMouseButtonDown"), @params);
    }
    public FEventReply OnPreviewKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InKeyEvent", InKeyEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnPreviewKeyDown"), @params);
    }
    public void OnPaint(ref FPaintContext Context)
    {
        Span<(string name, object value)> @params = [
            ("Context", Context)
        ];
        ProcessEvent(GetFunction("OnPaint"), @params);
    }
    public FEventReply OnMouseWheel(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMouseWheel"), @params);
    }
    public FEventReply OnMouseMove(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMouseMove"), @params);
    }
    public void OnMouseLeave(ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MouseEvent", MouseEvent)
        ];
        ProcessEvent(GetFunction("OnMouseLeave"), @params);
    }
    public void OnMouseEnter(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        ProcessEvent(GetFunction("OnMouseEnter"), @params);
    }
    public void OnMouseCaptureLost()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnMouseCaptureLost"), @params);
    }
    public FEventReply OnMouseButtonUp(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMouseButtonUp"), @params);
    }
    public FEventReply OnMouseButtonDown(FGeometry MyGeometry, ref FPointerEvent MouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("MouseEvent", MouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMouseButtonDown"), @params);
    }
    public FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry, ref FPointerEvent InMouseEvent)
    {
        Span<(string name, object value)> @params = [
            ("InMyGeometry", InMyGeometry), 
            ("InMouseEvent", InMouseEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMouseButtonDoubleClick"), @params);
    }
    public FEventReply OnMotionDetected(FGeometry MyGeometry, FMotionEvent InMotionEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InMotionEvent", InMotionEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnMotionDetected"), @params);
    }
    public FEventReply OnKeyUp(FGeometry MyGeometry, FKeyEvent InKeyEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InKeyEvent", InKeyEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnKeyUp"), @params);
    }
    public FEventReply OnKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InKeyEvent", InKeyEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnKeyDown"), @params);
    }
    public FEventReply OnKeyChar(FGeometry MyGeometry, FCharacterEvent InCharacterEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InCharacterEvent", InCharacterEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnKeyChar"), @params);
    }
    public void OnInitialized()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnInitialized"), @params);
    }
    public FEventReply OnFocusReceived(FGeometry MyGeometry, FFocusEvent InFocusEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InFocusEvent", InFocusEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnFocusReceived"), @params);
    }
    public void OnFocusLost(FFocusEvent InFocusEvent)
    {
        Span<(string name, object value)> @params = [
            ("InFocusEvent", InFocusEvent)
        ];
        ProcessEvent(GetFunction("OnFocusLost"), @params);
    }
    public bool OnDrop(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        return ProcessEvent<bool>(GetFunction("OnDrop"), @params);
    }
    public bool OnDragOver(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        return ProcessEvent<bool>(GetFunction("OnDragOver"), @params);
    }
    public void OnDragLeave(FPointerEvent PointerEvent, UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        ProcessEvent(GetFunction("OnDragLeave"), @params);
    }
    public void OnDragEnter(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        ProcessEvent(GetFunction("OnDragEnter"), @params);
    }
    public void OnDragDetected(FGeometry MyGeometry, ref FPointerEvent PointerEvent, ref UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        ProcessEvent(GetFunction("OnDragDetected"), @params);
    }
    public void OnDragCancelled(ref FPointerEvent PointerEvent, UDragDropOperation* Operation)
    {
        Span<(string name, object value)> @params = [
            ("PointerEvent", PointerEvent), 
            ("Operation", (IntPtr)Operation)
        ];
        ProcessEvent(GetFunction("OnDragCancelled"), @params);
    }
    public void OnAnimationStarted(UWidgetAnimation* Animation)
    {
        Span<(string name, object value)> @params = [
            ("Animation", (IntPtr)Animation)
        ];
        ProcessEvent(GetFunction("OnAnimationStarted"), @params);
    }
    public void OnAnimationFinished(UWidgetAnimation* Animation)
    {
        Span<(string name, object value)> @params = [
            ("Animation", (IntPtr)Animation)
        ];
        ProcessEvent(GetFunction("OnAnimationFinished"), @params);
    }
    public FEventReply OnAnalogValueChanged(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
    {
        Span<(string name, object value)> @params = [
            ("MyGeometry", MyGeometry), 
            ("InAnalogInputEvent", InAnalogInputEvent)
        ];
        return ProcessEvent<FEventReply>(GetFunction("OnAnalogValueChanged"), @params);
    }
    public void OnAddedToFocusPath(FFocusEvent InFocusEvent)
    {
        Span<(string name, object value)> @params = [
            ("InFocusEvent", InFocusEvent)
        ];
        ProcessEvent(GetFunction("OnAddedToFocusPath"), @params);
    }
    public bool IsPlayingAnimation()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPlayingAnimation"), @params);
    }
    public bool IsListeningForInputAction(FName ActionName)
    {
        Span<(string name, object value)> @params = [
            ("ActionName", ActionName)
        ];
        return ProcessEvent<bool>(GetFunction("IsListeningForInputAction"), @params);
    }
    public bool IsInViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInViewport"), @params);
    }
    public bool IsInteractable()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsInteractable"), @params);
    }
    public bool IsAnyAnimationPlaying()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsAnyAnimationPlaying"), @params);
    }
    public bool IsAnimationPlayingForward(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        return ProcessEvent<bool>(GetFunction("IsAnimationPlayingForward"), @params);
    }
    public bool IsAnimationPlaying(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        return ProcessEvent<bool>(GetFunction("IsAnimationPlaying"), @params);
    }
    public APawn* GetOwningPlayerPawn()
    {
        Span<(string name, object value)> @params = [
        ];
        return (APawn*)ProcessEvent<IntPtr>(GetFunction("GetOwningPlayerPawn"), @params);
    }
    public APlayerCameraManager* GetOwningPlayerCameraManager()
    {
        Span<(string name, object value)> @params = [
        ];
        return (APlayerCameraManager*)ProcessEvent<IntPtr>(GetFunction("GetOwningPlayerCameraManager"), @params);
    }
    public bool GetIsVisible()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetIsVisible"), @params);
    }
    public float GetAnimationCurrentTime(UWidgetAnimation* InAnimation)
    {
        Span<(string name, object value)> @params = [
            ("InAnimation", (IntPtr)InAnimation)
        ];
        return ProcessEvent<float>(GetFunction("GetAnimationCurrentTime"), @params);
    }
    public FAnchors GetAnchorsInViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FAnchors>(GetFunction("GetAnchorsInViewport"), @params);
    }
    public FVector2D GetAlignmentInViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetAlignmentInViewport"), @params);
    }
    public void FlushAnimations()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("FlushAnimations"), @params);
    }
    public void Destruct()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Destruct"), @params);
    }
    public void Construct()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Construct"), @params);
    }
    public void CancelLatentActions()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("CancelLatentActions"), @params);
    }
    public void AddToViewport(int ZOrder)
    {
        Span<(string name, object value)> @params = [
            ("ZOrder", ZOrder)
        ];
        ProcessEvent(GetFunction("AddToViewport"), @params);
    }
    public bool AddToPlayerScreen(int ZOrder)
    {
        Span<(string name, object value)> @params = [
            ("ZOrder", ZOrder)
        ];
        return ProcessEvent<bool>(GetFunction("AddToPlayerScreen"), @params);
    }
}

public unsafe class AsyncTaskDownloadImage : ObjectBase<UAsyncTaskDownloadImage>
{
    public AsyncTaskDownloadImage(IntPtr pointer) : base(pointer) {}
    public UAsyncTaskDownloadImage* DownloadImage(FString URL)
    {
        Span<(string name, object value)> @params = [
            ("URL", URL)
        ];
        return (UAsyncTaskDownloadImage*)ProcessEvent<IntPtr>(GetFunction("DownloadImage"), @params);
    }
}

public unsafe class PanelWidget : ObjectBase<UPanelWidget>
{
    public PanelWidget(IntPtr pointer) : base(pointer) {}
    public bool RemoveChildAt(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveChildAt"), @params);
    }
    public bool RemoveChild(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveChild"), @params);
    }
    public bool HasChild(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return ProcessEvent<bool>(GetFunction("HasChild"), @params);
    }
    public bool HasAnyChildren()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasAnyChildren"), @params);
    }
    public int GetChildrenCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetChildrenCount"), @params);
    }
    public int GetChildIndex(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return ProcessEvent<int>(GetFunction("GetChildIndex"), @params);
    }
    public UWidget* GetChildAt(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetChildAt"), @params);
    }
    public TArray<IntPtr> GetAllChildren()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetAllChildren"), @params);
    }
    public void ClearChildren()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearChildren"), @params);
    }
    public UPanelSlot* AddChild(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UPanelSlot*)ProcessEvent<IntPtr>(GetFunction("AddChild"), @params);
    }
}

public unsafe class ContentWidget : ObjectBase<UContentWidget>
{
    public ContentWidget(IntPtr pointer) : base(pointer) {}
    public UPanelSlot* SetContent(UWidget* Content)
    {
        Span<(string name, object value)> @params = [
            ("Content", (IntPtr)Content)
        ];
        return (UPanelSlot*)ProcessEvent<IntPtr>(GetFunction("SetContent"), @params);
    }
    public UPanelSlot* GetContentSlot()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPanelSlot*)ProcessEvent<IntPtr>(GetFunction("GetContentSlot"), @params);
    }
    public UWidget* GetContent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UWidget*)ProcessEvent<IntPtr>(GetFunction("GetContent"), @params);
    }
}

public unsafe class BackgroundBlur : ObjectBase<UBackgroundBlur>
{
    public BackgroundBlur(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetLowQualityFallbackBrush(ref FSlateBrush InBrush)
    {
        Span<(string name, object value)> @params = [
            ("InBrush", InBrush)
        ];
        ProcessEvent(GetFunction("SetLowQualityFallbackBrush"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
    public void SetBlurStrength(float InStrength)
    {
        Span<(string name, object value)> @params = [
            ("InStrength", InStrength)
        ];
        ProcessEvent(GetFunction("SetBlurStrength"), @params);
    }
    public void SetBlurRadius(int InBlurRadius)
    {
        Span<(string name, object value)> @params = [
            ("InBlurRadius", InBlurRadius)
        ];
        ProcessEvent(GetFunction("SetBlurRadius"), @params);
    }
    public void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
    {
        Span<(string name, object value)> @params = [
            ("bInApplyAlphaToBlur", bInApplyAlphaToBlur)
        ];
        ProcessEvent(GetFunction("SetApplyAlphaToBlur"), @params);
    }
}

public unsafe class PanelSlot : ObjectBase<UPanelSlot>
{
    public PanelSlot(IntPtr pointer) : base(pointer) {}
}

public unsafe class BackgroundBlurSlot : ObjectBase<UBackgroundBlurSlot>
{
    public BackgroundBlurSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class PropertyBinding : ObjectBase<UPropertyBinding>
{
    public PropertyBinding(IntPtr pointer) : base(pointer) {}
}

public unsafe class BoolBinding : ObjectBase<UBoolBinding>
{
    public BoolBinding(IntPtr pointer) : base(pointer) {}
    public bool GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetValue"), @params);
    }
}

public unsafe class Border : ObjectBase<UBorder>
{
    public Border(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
    public void SetDesiredSizeScale(FVector2D InScale)
    {
        Span<(string name, object value)> @params = [
            ("InScale", InScale)
        ];
        ProcessEvent(GetFunction("SetDesiredSizeScale"), @params);
    }
    public void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity)
    {
        Span<(string name, object value)> @params = [
            ("InContentColorAndOpacity", InContentColorAndOpacity)
        ];
        ProcessEvent(GetFunction("SetContentColorAndOpacity"), @params);
    }
    public void SetBrushFromTexture(UTexture2D* Texture)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture)
        ];
        ProcessEvent(GetFunction("SetBrushFromTexture"), @params);
    }
    public void SetBrushFromMaterial(UMaterialInterface* Material)
    {
        Span<(string name, object value)> @params = [
            ("Material", (IntPtr)Material)
        ];
        ProcessEvent(GetFunction("SetBrushFromMaterial"), @params);
    }
    public void SetBrushFromAsset(USlateBrushAsset* Asset)
    {
        Span<(string name, object value)> @params = [
            ("Asset", (IntPtr)Asset)
        ];
        ProcessEvent(GetFunction("SetBrushFromAsset"), @params);
    }
    public void SetBrushColor(FLinearColor InBrushColor)
    {
        Span<(string name, object value)> @params = [
            ("InBrushColor", InBrushColor)
        ];
        ProcessEvent(GetFunction("SetBrushColor"), @params);
    }
    public void SetBrush(ref FSlateBrush InBrush)
    {
        Span<(string name, object value)> @params = [
            ("InBrush", InBrush)
        ];
        ProcessEvent(GetFunction("SetBrush"), @params);
    }
    public UMaterialInstanceDynamic* GetDynamicMaterial()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMaterialInstanceDynamic*)ProcessEvent<IntPtr>(GetFunction("GetDynamicMaterial"), @params);
    }
}

public unsafe class BorderSlot : ObjectBase<UBorderSlot>
{
    public BorderSlot(IntPtr pointer) : base(pointer) {}
    public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InVerticalAlignment", InVerticalAlignment)
        ];
        ProcessEvent(GetFunction("SetVerticalAlignment"), @params);
    }
    public void SetPadding(FMargin InPadding)
    {
        Span<(string name, object value)> @params = [
            ("InPadding", InPadding)
        ];
        ProcessEvent(GetFunction("SetPadding"), @params);
    }
    public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
    {
        Span<(string name, object value)> @params = [
            ("InHorizontalAlignment", InHorizontalAlignment)
        ];
        ProcessEvent(GetFunction("SetHorizontalAlignment"), @params);
    }
}

public unsafe class BrushBinding : ObjectBase<UBrushBinding>
{
    public BrushBinding(IntPtr pointer) : base(pointer) {}
    public FSlateBrush GetValue()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSlateBrush>(GetFunction("GetValue"), @params);
    }
}

public unsafe class Default__WidgetBlueprintGeneratedClass : ObjectBase<UDefault__WidgetBlueprintGeneratedClass>
{
    public Default__WidgetBlueprintGeneratedClass(IntPtr pointer) : base(pointer) {}}

