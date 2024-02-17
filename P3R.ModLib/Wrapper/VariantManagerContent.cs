using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class LevelVariantSets : ObjectBase<ULevelVariantSets>
{
    public LevelVariantSets(IntPtr pointer) : base(pointer) {}
    public UVariantSet* GetVariantSetByName(FString VariantSetName)
    {
        Span<(string name, object value)> @params = [
            ("VariantSetName", VariantSetName)
        ];
        return (UVariantSet*)ProcessEvent<IntPtr>(GetFunction("GetVariantSetByName"), @params);
    }
    public UVariantSet* GetVariantSet(int VariantSetIndex)
    {
        Span<(string name, object value)> @params = [
            ("VariantSetIndex", VariantSetIndex)
        ];
        return (UVariantSet*)ProcessEvent<IntPtr>(GetFunction("GetVariantSet"), @params);
    }
    public int GetNumVariantSets()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumVariantSets"), @params);
    }
}

public unsafe class LevelVariantSetsActor : ObjectBase<ALevelVariantSetsActor>
{
    public LevelVariantSetsActor(IntPtr pointer) : base(pointer) {}
    public bool SwitchOnVariantByName(FString VariantSetName, FString VariantName)
    {
        Span<(string name, object value)> @params = [
            ("VariantSetName", VariantSetName), 
            ("VariantName", VariantName)
        ];
        return ProcessEvent<bool>(GetFunction("SwitchOnVariantByName"), @params);
    }
    public bool SwitchOnVariantByIndex(int VariantSetIndex, int VariantIndex)
    {
        Span<(string name, object value)> @params = [
            ("VariantSetIndex", VariantSetIndex), 
            ("VariantIndex", VariantIndex)
        ];
        return ProcessEvent<bool>(GetFunction("SwitchOnVariantByIndex"), @params);
    }
    public void SetLevelVariantSets(ULevelVariantSets* InVariantSets)
    {
        Span<(string name, object value)> @params = [
            ("InVariantSets", (IntPtr)InVariantSets)
        ];
        ProcessEvent(GetFunction("SetLevelVariantSets"), @params);
    }
    public ULevelVariantSets* GetLevelVariantSets(bool bLoad)
    {
        Span<(string name, object value)> @params = [
            ("bLoad", bLoad)
        ];
        return (ULevelVariantSets*)ProcessEvent<IntPtr>(GetFunction("GetLevelVariantSets"), @params);
    }
}

public unsafe class LevelVariantSetsFunctionDirector : ObjectBase<ULevelVariantSetsFunctionDirector>
{
    public LevelVariantSetsFunctionDirector(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValue : ObjectBase<UPropertyValue>
{
    public PropertyValue(IntPtr pointer) : base(pointer) {}
    public bool HasRecordedData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("HasRecordedData"), @params);
    }
    public FText GetPropertyTooltip()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetPropertyTooltip"), @params);
    }
    public FString GetFullDisplayString()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetFullDisplayString"), @params);
    }
}

public unsafe class PropertyValueTransform : ObjectBase<UPropertyValueTransform>
{
    public PropertyValueTransform(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValueVisibility : ObjectBase<UPropertyValueVisibility>
{
    public PropertyValueVisibility(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValueColor : ObjectBase<UPropertyValueColor>
{
    public PropertyValueColor(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValueMaterial : ObjectBase<UPropertyValueMaterial>
{
    public PropertyValueMaterial(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValueOption : ObjectBase<UPropertyValueOption>
{
    public PropertyValueOption(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyValueSoftObject : ObjectBase<UPropertyValueSoftObject>
{
    public PropertyValueSoftObject(IntPtr pointer) : base(pointer) {}}

public unsafe class SwitchActor : ObjectBase<ASwitchActor>
{
    public SwitchActor(IntPtr pointer) : base(pointer) {}
    public void SelectOption(int OptionIndex)
    {
        Span<(string name, object value)> @params = [
            ("OptionIndex", OptionIndex)
        ];
        ProcessEvent(GetFunction("SelectOption"), @params);
    }
    public int GetSelectedOption()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSelectedOption"), @params);
    }
    public TArray<IntPtr> GetOptions()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetOptions"), @params);
    }
}

public unsafe class Variant : ObjectBase<UVariant>
{
    public Variant(IntPtr pointer) : base(pointer) {}
    public void SwitchOn()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SwitchOn"), @params);
    }
    public void SetThumbnailFromTexture(UTexture2D* NewThumbnail)
    {
        Span<(string name, object value)> @params = [
            ("NewThumbnail", (IntPtr)NewThumbnail)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromTexture"), @params);
    }
    public void SetThumbnailFromFile(FString FilePath)
    {
        Span<(string name, object value)> @params = [
            ("FilePath", FilePath)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromFile"), @params);
    }
    public void SetThumbnailFromEditorViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetThumbnailFromEditorViewport"), @params);
    }
    public void SetThumbnailFromCamera(UObject* WorldContextObject, ref FTransform CameraTransform, float FOVDegrees, float MinZ, float Gamma)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CameraTransform", CameraTransform), 
            ("FOVDegrees", FOVDegrees), 
            ("MinZ", MinZ), 
            ("Gamma", Gamma)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromCamera"), @params);
    }
    public void SetDisplayText(ref FText NewDisplayText)
    {
        Span<(string name, object value)> @params = [
            ("NewDisplayText", NewDisplayText)
        ];
        ProcessEvent(GetFunction("SetDisplayText"), @params);
    }
    public void SetDependency(int Index, ref FVariantDependency Dependency)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Dependency", Dependency)
        ];
        ProcessEvent(GetFunction("SetDependency"), @params);
    }
    public bool IsActive()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsActive"), @params);
    }
    public UTexture2D* GetThumbnail()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture2D*)ProcessEvent<IntPtr>(GetFunction("GetThumbnail"), @params);
    }
    public UVariantSet* GetParent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UVariantSet*)ProcessEvent<IntPtr>(GetFunction("GetParent"), @params);
    }
    public int GetNumDependencies()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumDependencies"), @params);
    }
    public int GetNumActors()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumActors"), @params);
    }
    public FText GetDisplayText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetDisplayText"), @params);
    }
    public TArray<IntPtr> GetDependents(ULevelVariantSets* LevelVariantSets, bool bOnlyEnabledDependencies)
    {
        Span<(string name, object value)> @params = [
            ("LevelVariantSets", (IntPtr)LevelVariantSets), 
            ("bOnlyEnabledDependencies", bOnlyEnabledDependencies)
        ];
        return ProcessEvent<TArray<IntPtr>>(GetFunction("GetDependents"), @params);
    }
    public FVariantDependency GetDependency(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        return ProcessEvent<FVariantDependency>(GetFunction("GetDependency"), @params);
    }
    public AActor* GetActor(int ActorIndex)
    {
        Span<(string name, object value)> @params = [
            ("ActorIndex", ActorIndex)
        ];
        return (AActor*)ProcessEvent<IntPtr>(GetFunction("GetActor"), @params);
    }
    public void DeleteDependency(int Index)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index)
        ];
        ProcessEvent(GetFunction("DeleteDependency"), @params);
    }
    public int AddDependency(ref FVariantDependency Dependency)
    {
        Span<(string name, object value)> @params = [
            ("Dependency", Dependency)
        ];
        return ProcessEvent<int>(GetFunction("AddDependency"), @params);
    }
}

public unsafe class VariantObjectBinding : ObjectBase<UVariantObjectBinding>
{
    public VariantObjectBinding(IntPtr pointer) : base(pointer) {}
}

public unsafe class VariantSet : ObjectBase<UVariantSet>
{
    public VariantSet(IntPtr pointer) : base(pointer) {}
    public void SetThumbnailFromTexture(UTexture2D* NewThumbnail)
    {
        Span<(string name, object value)> @params = [
            ("NewThumbnail", (IntPtr)NewThumbnail)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromTexture"), @params);
    }
    public void SetThumbnailFromFile(FString FilePath)
    {
        Span<(string name, object value)> @params = [
            ("FilePath", FilePath)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromFile"), @params);
    }
    public void SetThumbnailFromEditorViewport()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("SetThumbnailFromEditorViewport"), @params);
    }
    public void SetThumbnailFromCamera(UObject* WorldContextObject, ref FTransform CameraTransform, float FOVDegrees, float MinZ, float Gamma)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("CameraTransform", CameraTransform), 
            ("FOVDegrees", FOVDegrees), 
            ("MinZ", MinZ), 
            ("Gamma", Gamma)
        ];
        ProcessEvent(GetFunction("SetThumbnailFromCamera"), @params);
    }
    public void SetDisplayText(ref FText NewDisplayText)
    {
        Span<(string name, object value)> @params = [
            ("NewDisplayText", NewDisplayText)
        ];
        ProcessEvent(GetFunction("SetDisplayText"), @params);
    }
    public UVariant* GetVariantByName(FString VariantName)
    {
        Span<(string name, object value)> @params = [
            ("VariantName", VariantName)
        ];
        return (UVariant*)ProcessEvent<IntPtr>(GetFunction("GetVariantByName"), @params);
    }
    public UVariant* GetVariant(int VariantIndex)
    {
        Span<(string name, object value)> @params = [
            ("VariantIndex", VariantIndex)
        ];
        return (UVariant*)ProcessEvent<IntPtr>(GetFunction("GetVariant"), @params);
    }
    public UTexture2D* GetThumbnail()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTexture2D*)ProcessEvent<IntPtr>(GetFunction("GetThumbnail"), @params);
    }
    public ULevelVariantSets* GetParent()
    {
        Span<(string name, object value)> @params = [
        ];
        return (ULevelVariantSets*)ProcessEvent<IntPtr>(GetFunction("GetParent"), @params);
    }
    public int GetNumVariants()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumVariants"), @params);
    }
    public FText GetDisplayText()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FText>(GetFunction("GetDisplayText"), @params);
    }
}

