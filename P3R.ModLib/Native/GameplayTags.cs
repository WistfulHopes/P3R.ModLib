using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FGameplayTag
{
    [FieldOffset(0x0000)] public FName TagName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGameplayTagContainer
{
    [FieldOffset(0x0000)] public TArray<FGameplayTag> GameplayTags;
    [FieldOffset(0x0010)] public TArray<FGameplayTag> ParentTags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FGameplayTagQuery
{
    [FieldOffset(0x0000)] public int TokenStreamVersion;
    [FieldOffset(0x0008)] public TArray<FGameplayTag> TagDictionary;
    [FieldOffset(0x0018)] public TArray<byte> QueryTokenStream;
    [FieldOffset(0x0028)] public FString UserDescription;
    [FieldOffset(0x0038)] public FString AutoDescription;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UBlueprintGameplayTagLibrary
{
    [FieldOffset(0x0000)] public UBlueprintFunctionLibrary baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct IGameplayTagAssetInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x98)] 
public unsafe struct UEditableGameplayTagQuery
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString UserDescription;
    [FieldOffset(0x0048)] public UEditableGameplayTagQueryExpression* RootExpression;
    [FieldOffset(0x0050)] public FGameplayTagQuery TagQueryExportText_Helper;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEditableGameplayTagQueryExpression
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEditableGameplayTagQueryExpression_AnyTagsMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public FGameplayTagContainer Tags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEditableGameplayTagQueryExpression_AllTagsMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public FGameplayTagContainer Tags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UEditableGameplayTagQueryExpression_NoTagsMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public FGameplayTagContainer Tags;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEditableGameplayTagQueryExpression_AnyExprMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Expressions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEditableGameplayTagQueryExpression_AllExprMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Expressions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)] 
public unsafe struct UEditableGameplayTagQueryExpression_NoExprMatch
{
    [FieldOffset(0x0000)] public UEditableGameplayTagQueryExpression baseObj;
    [FieldOffset(0x0028)] public TArray<IntPtr> Expressions;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGameplayTagSource
{
    [FieldOffset(0x0000)] public FName SourceName;
    [FieldOffset(0x0008)] public EGameplayTagSourceType SourceType;
    [FieldOffset(0x0010)] public UGameplayTagsList* SourceTagList;
    [FieldOffset(0x0018)] public URestrictedGameplayTagsList* SourceRestrictedTagList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x240)] 
public unsafe struct UGameplayTagsManager
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0160)] public TMap<FName, FGameplayTagSource> TagSources;
    [FieldOffset(0x0230)] public TArray<IntPtr> GameplayTagTables;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGameplayTagTableRow
{
    [FieldOffset(0x0000)] public FTableRowBase baseObj;
    [FieldOffset(0x0008)] public FName Tag;
    [FieldOffset(0x0010)] public FString DevComment;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct UGameplayTagsList
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString ConfigFileName;
    [FieldOffset(0x0038)] public TArray<FGameplayTagTableRow> GameplayTagList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FRestrictedGameplayTagTableRow
{
    [FieldOffset(0x0000)] public FGameplayTagTableRow baseObj;
    [FieldOffset(0x0020)] public bool bAllowNonRestrictedChildren;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct URestrictedGameplayTagsList
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FString ConfigFileName;
    [FieldOffset(0x0038)] public TArray<FRestrictedGameplayTagTableRow> RestrictedGameplayTagList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FGameplayTagCategoryRemap
{
    [FieldOffset(0x0000)] public FString BaseCategory;
    [FieldOffset(0x0010)] public TArray<FString> RemapCategories;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGameplayTagRedirect
{
    [FieldOffset(0x0000)] public FName OldTagName;
    [FieldOffset(0x0008)] public FName NewTagName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FRestrictedConfigInfo
{
    [FieldOffset(0x0000)] public FString RestrictedConfigName;
    [FieldOffset(0x0010)] public TArray<FString> Owners;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct UGameplayTagsSettings
{
    [FieldOffset(0x0000)] public UGameplayTagsList baseObj;
    [FieldOffset(0x0048)] public bool ImportTagsFromConfig;
    [FieldOffset(0x0049)] public bool WarnOnInvalidTags;
    [FieldOffset(0x004A)] public bool ClearInvalidTags;
    [FieldOffset(0x004B)] public bool FastReplication;
    [FieldOffset(0x0050)] public FString InvalidTagCharacters;
    [FieldOffset(0x0060)] public TArray<FGameplayTagCategoryRemap> CategoryRemapping;
    [FieldOffset(0x0070)] public TArray<FSoftObjectPath> GameplayTagTableList;
    [FieldOffset(0x0080)] public TArray<FGameplayTagRedirect> GameplayTagRedirects;
    [FieldOffset(0x0090)] public TArray<FName> CommonlyReplicatedTags;
    [FieldOffset(0x00A0)] public int NumBitsForContainerSize;
    [FieldOffset(0x00A4)] public int NetIndexFirstBitSegment;
    [FieldOffset(0x00A8)] public TArray<FRestrictedConfigInfo> RestrictedConfigFiles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct UGameplayTagsDeveloperSettings
{
    [FieldOffset(0x0000)] public UDeveloperSettings baseObj;
    [FieldOffset(0x0038)] public FString DeveloperConfigName;
    [FieldOffset(0x0048)] public FName FavoriteTagSource;
}

[StructLayout(LayoutKind.Explicit, Size = 0x1)] 
public unsafe struct FGameplayTagCreationWidgetHelper
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FGameplayTagReferenceHelper
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FGameplayTagNode
{
}

