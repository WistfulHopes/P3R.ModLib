public enum EVirtualKeyboardDismissAction {
    TextChangeOnDismiss = 0,
    TextCommitOnAccept = 1,
    TextCommitOnDismiss = 2,
    EVirtualKeyboardDismissAction_MAX = 3,
};

public enum EVirtualKeyboardTrigger {
    OnFocusByPointer = 0,
    OnAllFocusEvents = 1,
    EVirtualKeyboardTrigger_MAX = 2,
};

public enum ETableViewMode {
    List = 0,
    Tile = 1,
    Tree = 2,
    ETableViewMode_MAX = 3,
};

public enum ESelectionMode {
    None = 0,
    Single = 1,
    SingleToggle = 2,
    Multi = 3,
    ESelectionMode_MAX = 4,
};

public enum EMultiBlockType {
    None = 0,
    ButtonRow = 1,
    EditableText = 2,
    Heading = 3,
    MenuEntry = 4,
    Separator = 5,
    ToolBarButton = 6,
    ToolBarComboButton = 7,
    Widget = 8,
    EMultiBlockType_MAX = 9,
};

public enum EMultiBoxType {
    MenuBar = 0,
    ToolBar = 1,
    VerticalToolBar = 2,
    UniformToolBar = 3,
    Menu = 4,
    ButtonRow = 5,
    EMultiBoxType_MAX = 6,
};

public enum EProgressBarFillType {
    LeftToRight = 0,
    RightToLeft = 1,
    FillFromCenter = 2,
    TopToBottom = 3,
    BottomToTop = 4,
    EProgressBarFillType_MAX = 5,
};

public enum EStretch {
    None = 0,
    Fill = 1,
    ScaleToFit = 2,
    ScaleToFitX = 3,
    ScaleToFitY = 4,
    ScaleToFill = 5,
    ScaleBySafeZone = 6,
    UserSpecified = 7,
    EStretch_MAX = 8,
};

public enum EStretchDirection {
    Both = 0,
    DownOnly = 1,
    UpOnly = 2,
    EStretchDirection_MAX = 3,
};

public enum EScrollWhenFocusChanges {
    NoScroll = 0,
    InstantScroll = 1,
    AnimatedScroll = 2,
    EScrollWhenFocusChanges_MAX = 3,
};

public enum EDescendantScrollDestination {
    IntoView = 0,
    TopOrLeft = 1,
    Center = 2,
    BottomOrRight = 3,
    EDescendantScrollDestination_MAX = 4,
};

public enum EListItemAlignment {
    EvenlyDistributed = 0,
    EvenlySize = 1,
    EvenlyWide = 2,
    LeftAligned = 3,
    RightAligned = 4,
    CenterAligned = 5,
    Fill = 6,
    EListItemAlignment_MAX = 7,
};

public enum ETextFlowDirection {
    Auto = 0,
    LeftToRight = 1,
    RightToLeft = 2,
    ETextFlowDirection_MAX = 3,
};

public enum ETextWrappingPolicy {
    DefaultWrapping = 0,
    AllowPerCharacterWrapping = 1,
    ETextWrappingPolicy_MAX = 2,
};

public enum ETextTransformPolicy {
    None = 0,
    ToLower = 1,
    ToUpper = 2,
    ETextTransformPolicy_MAX = 3,
};

public enum ETextJustify {
    Left = 0,
    Center = 1,
    Right = 2,
    ETextJustify_MAX = 3,
};

public enum ECustomizedToolMenuVisibility {
    None = 0,
    Visible = 1,
    Hidden = 2,
    ECustomizedToolMenuVisibility_MAX = 3,
};

public enum EMultipleKeyBindingIndex {
    Primary = 0,
    Secondary = 1,
    NumChords = 2,
    EMultipleKeyBindingIndex_MAX = 3,
};

public enum EUserInterfaceActionType {
    None = 0,
    Button = 1,
    ToggleButton = 2,
    RadioButton = 3,
    Check = 4,
    CollapsedButton = 5,
    EUserInterfaceActionType_MAX = 6,
};

