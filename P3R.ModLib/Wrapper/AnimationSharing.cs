using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimSharingStateInstance : ObjectBase<UAnimSharingStateInstance>
{
    public AnimSharingStateInstance(IntPtr pointer) : base(pointer) {}
    public void GetInstancedActors(ref TArray<IntPtr> Actors)
    {
        Span<(string name, object value)> @params = [
            ("Actors", Actors)
        ];
        ProcessEvent(GetFunction("GetInstancedActors"), @params);
    }
}

public unsafe class AnimSharingTransitionInstance : ObjectBase<UAnimSharingTransitionInstance>
{
    public AnimSharingTransitionInstance(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimSharingAdditiveInstance : ObjectBase<UAnimSharingAdditiveInstance>
{
    public AnimSharingAdditiveInstance(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimSharingInstance : ObjectBase<UAnimSharingInstance>
{
    public AnimSharingInstance(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimationSharingManager : ObjectBase<UAnimationSharingManager>
{
    public AnimationSharingManager(IntPtr pointer) : base(pointer) {}
    public void RegisterActorWithSkeletonBP(AActor* InActor, USkeleton* SharingSkeleton)
    {
        Span<(string name, object value)> @params = [
            ("InActor", (IntPtr)InActor), 
            ("SharingSkeleton", (IntPtr)SharingSkeleton)
        ];
        ProcessEvent(GetFunction("RegisterActorWithSkeletonBP"), @params);
    }
    public UAnimationSharingManager* GetAnimationSharingManager(UObject* WorldContextObject)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject)
        ];
        return (UAnimationSharingManager*)ProcessEvent<IntPtr>(GetFunction("GetAnimationSharingManager"), @params);
    }
    public bool CreateAnimationSharingManager(UObject* WorldContextObject, UAnimationSharingSetup* Setup)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("Setup", (IntPtr)Setup)
        ];
        return ProcessEvent<bool>(GetFunction("CreateAnimationSharingManager"), @params);
    }
    public bool AnimationSharingEnabled()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("AnimationSharingEnabled"), @params);
    }
}

public unsafe class AnimationSharingSetup : ObjectBase<UAnimationSharingSetup>
{
    public AnimationSharingSetup(IntPtr pointer) : base(pointer) {}
}

public unsafe class AnimationSharingStateProcessor : ObjectBase<UAnimationSharingStateProcessor>
{
    public AnimationSharingStateProcessor(IntPtr pointer) : base(pointer) {}
    public void ProcessActorState(ref int OutState, AActor* InActor, byte CurrentState, byte OnDemandState, ref bool bShouldProcess)
    {
        Span<(string name, object value)> @params = [
            ("OutState", OutState), 
            ("InActor", (IntPtr)InActor), 
            ("CurrentState", CurrentState), 
            ("OnDemandState", OnDemandState), 
            ("bShouldProcess", bShouldProcess)
        ];
        ProcessEvent(GetFunction("ProcessActorState"), @params);
    }
    public UEnum* GetAnimationStateEnum()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UEnum*)ProcessEvent<IntPtr>(GetFunction("GetAnimationStateEnum"), @params);
    }
}

