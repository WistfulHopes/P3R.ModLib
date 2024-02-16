using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class TemplateSequence : ObjectBase<UTemplateSequence>
{

}

public unsafe class CameraAnimationSequence : ObjectBase<UCameraAnimationSequence>
{
}

public unsafe class SequenceCameraShakeCameraStandIn : ObjectBase<USequenceCameraShakeCameraStandIn>
{

}

public unsafe class SequenceCameraShakePattern : ObjectBase<USequenceCameraShakePattern>
{

}

public unsafe class SequenceCameraShakeSequencePlayer : ObjectBase<USequenceCameraShakeSequencePlayer>
{

}

public unsafe class TemplateSequenceActor : ObjectBase<ATemplateSequenceActor>
{

    public void SetSequence(UTemplateSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        ProcessEvent(GetFunction("SetSequence"),  @params);
    }
    public void SetBinding(AActor* Actor, bool bOverridesDefault)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("bOverridesDefault", bOverridesDefault)
        ];
        ProcessEvent(GetFunction("SetBinding"),  @params);
    }
    public UTemplateSequence* LoadSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequence*)ProcessEvent<IntPtr>(GetFunction("LoadSequence"),  @params);
    }
    public UTemplateSequencePlayer* GetSequencePlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("GetSequencePlayer"),  @params);
    }
    public UTemplateSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"),  @params);
    }
}

public unsafe class TemplateSequencePlayer : ObjectBase<UTemplateSequencePlayer>
{

    public UTemplateSequencePlayer* CreateTemplateSequencePlayer(UObject* WorldContextObject, UTemplateSequence* TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, ref ATemplateSequenceActor* OutActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("TemplateSequence", (IntPtr)TemplateSequence), 
            ("Settings", Settings), 
            ("OutActor", (IntPtr)OutActor)
        ];
        return (UTemplateSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("CreateTemplateSequencePlayer"),  @params);
    }
}

public unsafe class TemplateSequenceSection : ObjectBase<UTemplateSequenceSection>
{

}

public unsafe class TemplateSequenceSystem : ObjectBase<UTemplateSequenceSystem>
{
}

public unsafe class TemplateSequencePropertyScalingInstantiatorSystem : ObjectBase<UTemplateSequencePropertyScalingInstantiatorSystem>
{
}

public unsafe class TemplateSequencePropertyScalingEvaluatorSystem : ObjectBase<UTemplateSequencePropertyScalingEvaluatorSystem>
{
}

public unsafe class TemplateSequenceTrack : ObjectBase<UTemplateSequenceTrack>
{
}

public unsafe class TemplateSequenceBindingOverrideData : ObjectBase<FTemplateSequenceBindingOverrideData>
{

}

public unsafe class TemplateSectionPropertyScale : ObjectBase<FTemplateSectionPropertyScale>
{

}

