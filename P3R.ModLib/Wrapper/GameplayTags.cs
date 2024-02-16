using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class GameplayTagContainer : ObjectBase<FGameplayTagContainer>
{

}

public unsafe class GameplayTag : ObjectBase<FGameplayTag>
{

}

public unsafe class GameplayTagQuery : ObjectBase<FGameplayTagQuery>
{

}

public unsafe class BlueprintGameplayTagLibrary : ObjectBase<UBlueprintGameplayTagLibrary>
{

    public bool RemoveGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("Tag", Tag)
        ];
        return ProcessEvent<bool>(GetFunction("RemoveGameplayTag"),  @params);
    }
    public bool NotEqual_TagTag(FGameplayTag A, FString B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("NotEqual_TagTag"),  @params);
    }
    public bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A, FString B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("NotEqual_TagContainerTagContainer"),  @params);
    }
    public bool NotEqual_GameplayTagContainer(ref FGameplayTagContainer A, ref FGameplayTagContainer B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("NotEqual_GameplayTagContainer"),  @params);
    }
    public bool NotEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("NotEqual_GameplayTag"),  @params);
    }
    public bool MatchesTag(FGameplayTag TagOne, FGameplayTag TagTwo, bool bExactMatch)
    {
        Span<(string name, object value)> @params = [
            ("TagOne", TagOne), 
            ("TagTwo", TagTwo), 
            ("bExactMatch", bExactMatch)
        ];
        return ProcessEvent<bool>(GetFunction("MatchesTag"),  @params);
    }
    public bool MatchesAnyTags(FGameplayTag TagOne, ref FGameplayTagContainer OtherContainer, bool bExactMatch)
    {
        Span<(string name, object value)> @params = [
            ("TagOne", TagOne), 
            ("OtherContainer", OtherContainer), 
            ("bExactMatch", bExactMatch)
        ];
        return ProcessEvent<bool>(GetFunction("MatchesAnyTags"),  @params);
    }
    public FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        return ProcessEvent<FGameplayTagContainer>(GetFunction("MakeLiteralGameplayTagContainer"),  @params);
    }
    public FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value)
    {
        Span<(string name, object value)> @params = [
            ("Value", Value)
        ];
        return ProcessEvent<FGameplayTag>(GetFunction("MakeLiteralGameplayTag"),  @params);
    }
    public FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery)
    {
        Span<(string name, object value)> @params = [
            ("TagQuery", TagQuery)
        ];
        return ProcessEvent<FGameplayTagQuery>(GetFunction("MakeGameplayTagQuery"),  @params);
    }
    public FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag)
    {
        Span<(string name, object value)> @params = [
            ("SingleTag", SingleTag)
        ];
        return ProcessEvent<FGameplayTagContainer>(GetFunction("MakeGameplayTagContainerFromTag"),  @params);
    }
    public FGameplayTagContainer MakeGameplayTagContainerFromArray(ref TArray<FGameplayTag> GameplayTags)
    {
        Span<(string name, object value)> @params = [
            ("GameplayTags", GameplayTags)
        ];
        return ProcessEvent<FGameplayTagContainer>(GetFunction("MakeGameplayTagContainerFromArray"),  @params);
    }
    public bool IsTagQueryEmpty(ref FGameplayTagQuery TagQuery)
    {
        Span<(string name, object value)> @params = [
            ("TagQuery", TagQuery)
        ];
        return ProcessEvent<bool>(GetFunction("IsTagQueryEmpty"),  @params);
    }
    public bool IsGameplayTagValid(FGameplayTag GameplayTag)
    {
        Span<(string name, object value)> @params = [
            ("GameplayTag", GameplayTag)
        ];
        return ProcessEvent<bool>(GetFunction("IsGameplayTagValid"),  @params);
    }
    public bool HasTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag, bool bExactMatch)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("Tag", Tag), 
            ("bExactMatch", bExactMatch)
        ];
        return ProcessEvent<bool>(GetFunction("HasTag"),  @params);
    }
    public bool HasAnyTags(ref FGameplayTagContainer TagContainer, ref FGameplayTagContainer OtherContainer, bool bExactMatch)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("OtherContainer", OtherContainer), 
            ("bExactMatch", bExactMatch)
        ];
        return ProcessEvent<bool>(GetFunction("HasAnyTags"),  @params);
    }
    public bool HasAllTags(ref FGameplayTagContainer TagContainer, ref FGameplayTagContainer OtherContainer, bool bExactMatch)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("OtherContainer", OtherContainer), 
            ("bExactMatch", bExactMatch)
        ];
        return ProcessEvent<bool>(GetFunction("HasAllTags"),  @params);
    }
    public bool HasAllMatchingGameplayTags(TScriptInterface<IGameplayTagAssetInterface> TagContainerInterface, ref FGameplayTagContainer OtherContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainerInterface", TagContainerInterface), 
            ("OtherContainer", OtherContainer)
        ];
        return ProcessEvent<bool>(GetFunction("HasAllMatchingGameplayTags"),  @params);
    }
    public FName GetTagName(ref FGameplayTag GameplayTag)
    {
        Span<(string name, object value)> @params = [
            ("GameplayTag", GameplayTag)
        ];
        return ProcessEvent<FName>(GetFunction("GetTagName"),  @params);
    }
    public int GetNumGameplayTagsInContainer(ref FGameplayTagContainer TagContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer)
        ];
        return ProcessEvent<int>(GetFunction("GetNumGameplayTagsInContainer"),  @params);
    }
    public FString GetDebugStringFromGameplayTagContainer(ref FGameplayTagContainer TagContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer)
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugStringFromGameplayTagContainer"),  @params);
    }
    public FString GetDebugStringFromGameplayTag(FGameplayTag GameplayTag)
    {
        Span<(string name, object value)> @params = [
            ("GameplayTag", GameplayTag)
        ];
        return ProcessEvent<FString>(GetFunction("GetDebugStringFromGameplayTag"),  @params);
    }
    public void GetAllActorsOfClassMatchingTagQuery(UObject* WorldContextObject, TSubclassOf<AActor> ActorClass, ref FGameplayTagQuery GameplayTagQuery, ref TArray<IntPtr> OutActors)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("ActorClass", ActorClass), 
            ("GameplayTagQuery", GameplayTagQuery), 
            ("OutActors", OutActors)
        ];
        ProcessEvent(GetFunction("GetAllActorsOfClassMatchingTagQuery"),  @params);
    }
    public bool EqualEqual_GameplayTagContainer(ref FGameplayTagContainer A, ref FGameplayTagContainer B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("EqualEqual_GameplayTagContainer"),  @params);
    }
    public bool EqualEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<bool>(GetFunction("EqualEqual_GameplayTag"),  @params);
    }
    public bool DoesTagAssetInterfaceHaveTag(TScriptInterface<IGameplayTagAssetInterface> TagContainerInterface, FGameplayTag Tag)
    {
        Span<(string name, object value)> @params = [
            ("TagContainerInterface", TagContainerInterface), 
            ("Tag", Tag)
        ];
        return ProcessEvent<bool>(GetFunction("DoesTagAssetInterfaceHaveTag"),  @params);
    }
    public bool DoesContainerMatchTagQuery(ref FGameplayTagContainer TagContainer, ref FGameplayTagQuery TagQuery)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("TagQuery", TagQuery)
        ];
        return ProcessEvent<bool>(GetFunction("DoesContainerMatchTagQuery"),  @params);
    }
    public void BreakGameplayTagContainer(ref FGameplayTagContainer GameplayTagContainer, ref TArray<FGameplayTag> GameplayTags)
    {
        Span<(string name, object value)> @params = [
            ("GameplayTagContainer", GameplayTagContainer), 
            ("GameplayTags", GameplayTags)
        ];
        ProcessEvent(GetFunction("BreakGameplayTagContainer"),  @params);
    }
    public void AppendGameplayTagContainers(ref FGameplayTagContainer InOutTagContainer, ref FGameplayTagContainer InTagContainer)
    {
        Span<(string name, object value)> @params = [
            ("InOutTagContainer", InOutTagContainer), 
            ("InTagContainer", InTagContainer)
        ];
        ProcessEvent(GetFunction("AppendGameplayTagContainers"),  @params);
    }
    public void AddGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer), 
            ("Tag", Tag)
        ];
        ProcessEvent(GetFunction("AddGameplayTag"),  @params);
    }
}

public unsafe class GameplayTagAssetInterface : ObjectBase<IGameplayTagAssetInterface>
{

    public bool HasMatchingGameplayTag(FGameplayTag TagToCheck)
    {
        Span<(string name, object value)> @params = [
            ("TagToCheck", TagToCheck)
        ];
        return ProcessEvent<bool>(GetFunction("HasMatchingGameplayTag"),  @params);
    }
    public bool HasAnyMatchingGameplayTags(ref FGameplayTagContainer TagContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer)
        ];
        return ProcessEvent<bool>(GetFunction("HasAnyMatchingGameplayTags"),  @params);
    }
    public bool HasAllMatchingGameplayTags(ref FGameplayTagContainer TagContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer)
        ];
        return ProcessEvent<bool>(GetFunction("HasAllMatchingGameplayTags"),  @params);
    }
    public void GetOwnedGameplayTags(ref FGameplayTagContainer TagContainer)
    {
        Span<(string name, object value)> @params = [
            ("TagContainer", TagContainer)
        ];
        ProcessEvent(GetFunction("GetOwnedGameplayTags"),  @params);
    }
}

public unsafe class EditableGameplayTagQuery : ObjectBase<UEditableGameplayTagQuery>
{

}

public unsafe class EditableGameplayTagQueryExpression : ObjectBase<UEditableGameplayTagQueryExpression>
{
}

public unsafe class EditableGameplayTagQueryExpression_AnyTagsMatch : ObjectBase<UEditableGameplayTagQueryExpression_AnyTagsMatch>
{

}

public unsafe class EditableGameplayTagQueryExpression_AllTagsMatch : ObjectBase<UEditableGameplayTagQueryExpression_AllTagsMatch>
{

}

public unsafe class EditableGameplayTagQueryExpression_NoTagsMatch : ObjectBase<UEditableGameplayTagQueryExpression_NoTagsMatch>
{

}

public unsafe class EditableGameplayTagQueryExpression_AnyExprMatch : ObjectBase<UEditableGameplayTagQueryExpression_AnyExprMatch>
{

}

public unsafe class EditableGameplayTagQueryExpression_AllExprMatch : ObjectBase<UEditableGameplayTagQueryExpression_AllExprMatch>
{

}

public unsafe class EditableGameplayTagQueryExpression_NoExprMatch : ObjectBase<UEditableGameplayTagQueryExpression_NoExprMatch>
{

}

public unsafe class GameplayTagsManager : ObjectBase<UGameplayTagsManager>
{

}

public unsafe class GameplayTagsList : ObjectBase<UGameplayTagsList>
{

}

public unsafe class RestrictedGameplayTagsList : ObjectBase<URestrictedGameplayTagsList>
{

}

public unsafe class GameplayTagsSettings : ObjectBase<UGameplayTagsSettings>
{

}

public unsafe class GameplayTagsDeveloperSettings : ObjectBase<UGameplayTagsDeveloperSettings>
{

}

public unsafe class GameplayTagCreationWidgetHelper : ObjectBase<FGameplayTagCreationWidgetHelper>
{
}

public unsafe class GameplayTagReferenceHelper : ObjectBase<FGameplayTagReferenceHelper>
{
}

public unsafe class GameplayTagRedirect : ObjectBase<FGameplayTagRedirect>
{

}

public unsafe class GameplayTagNode : ObjectBase<FGameplayTagNode>
{
}

public unsafe class GameplayTagSource : ObjectBase<FGameplayTagSource>
{

}

public unsafe class GameplayTagTableRow : ObjectBase<FGameplayTagTableRow>
{

}

public unsafe class RestrictedGameplayTagTableRow : ObjectBase<FRestrictedGameplayTagTableRow>
{

}

public unsafe class RestrictedConfigInfo : ObjectBase<FRestrictedConfigInfo>
{

}

public unsafe class GameplayTagCategoryRemap : ObjectBase<FGameplayTagCategoryRemap>
{

}

