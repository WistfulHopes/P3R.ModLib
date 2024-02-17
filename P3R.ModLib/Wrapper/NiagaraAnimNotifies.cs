using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimNotify_PlayNiagaraEffect : ObjectBase<UAnimNotify_PlayNiagaraEffect>
{
    public AnimNotify_PlayNiagaraEffect(IntPtr pointer) : base(pointer) {}
    public UFXSystemComponent* GetSpawnedEffect()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UFXSystemComponent*)ProcessEvent<IntPtr>(GetFunction("GetSpawnedEffect"), @params);
    }
}

public unsafe class AnimNotifyState_TimedNiagaraEffect : ObjectBase<UAnimNotifyState_TimedNiagaraEffect>
{
    public AnimNotifyState_TimedNiagaraEffect(IntPtr pointer) : base(pointer) {}
    public UFXSystemComponent* GetSpawnedEffect(UMeshComponent* MeshComp)
    {
        Span<(string name, object value)> @params = [
            ("MeshComp", (IntPtr)MeshComp)
        ];
        return (UFXSystemComponent*)ProcessEvent<IntPtr>(GetFunction("GetSpawnedEffect"), @params);
    }
}

public unsafe class AnimNotifyState_TimedNiagaraEffectAdvanced : ObjectBase<UAnimNotifyState_TimedNiagaraEffectAdvanced>
{
    public AnimNotifyState_TimedNiagaraEffectAdvanced(IntPtr pointer) : base(pointer) {}
    public float GetNotifyProgress(UMeshComponent* MeshComp)
    {
        Span<(string name, object value)> @params = [
            ("MeshComp", (IntPtr)MeshComp)
        ];
        return ProcessEvent<float>(GetFunction("GetNotifyProgress"), @params);
    }
}

