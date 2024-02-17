using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class TemplateSequence : ObjectBase<UTemplateSequence>
{
    public TemplateSequence(IntPtr pointer) : base(pointer) {}
}

public unsafe class CameraAnimationSequence : ObjectBase<UCameraAnimationSequence>
{
    public CameraAnimationSequence(IntPtr pointer) : base(pointer) {}}

public unsafe class SequenceCameraShakeCameraStandIn : ObjectBase<USequenceCameraShakeCameraStandIn>
{
    public SequenceCameraShakeCameraStandIn(IntPtr pointer) : base(pointer) {}
}

public unsafe class SequenceCameraShakePattern : ObjectBase<USequenceCameraShakePattern>
{
    public SequenceCameraShakePattern(IntPtr pointer) : base(pointer) {}
}

public unsafe class SequenceCameraShakeSequencePlayer : ObjectBase<USequenceCameraShakeSequencePlayer>
{
    public SequenceCameraShakeSequencePlayer(IntPtr pointer) : base(pointer) {}
}

public unsafe class TemplateSequenceActor : ObjectBase<ATemplateSequenceActor>
{
    public TemplateSequenceActor(IntPtr pointer) : base(pointer) {}
    public void SetSequence(UTemplateSequence* InSequence)
    {
        Span<(string name, object value)> @params = [
            ("InSequence", (IntPtr)InSequence)
        ];
        ProcessEvent(GetFunction("SetSequence"), @params);
    }
    public void SetBinding(AActor* Actor, bool bOverridesDefault)
    {
        Span<(string name, object value)> @params = [
            ("Actor", (IntPtr)Actor), 
            ("bOverridesDefault", bOverridesDefault)
        ];
        ProcessEvent(GetFunction("SetBinding"), @params);
    }
    public UTemplateSequence* LoadSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequence*)ProcessEvent<IntPtr>(GetFunction("LoadSequence"), @params);
    }
    public UTemplateSequencePlayer* GetSequencePlayer()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("GetSequencePlayer"), @params);
    }
    public UTemplateSequence* GetSequence()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UTemplateSequence*)ProcessEvent<IntPtr>(GetFunction("GetSequence"), @params);
    }
}

public unsafe class TemplateSequencePlayer : ObjectBase<UTemplateSequencePlayer>
{
    public TemplateSequencePlayer(IntPtr pointer) : base(pointer) {}
    public UTemplateSequencePlayer* CreateTemplateSequencePlayer(UObject* WorldContextObject, UTemplateSequence* TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, ref ATemplateSequenceActor* OutActor)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("TemplateSequence", (IntPtr)TemplateSequence), 
            ("Settings", Settings), 
            ("OutActor", (IntPtr)OutActor)
        ];
        return (UTemplateSequencePlayer*)ProcessEvent<IntPtr>(GetFunction("CreateTemplateSequencePlayer"), @params);
    }
}

public unsafe class TemplateSequenceSection : ObjectBase<UTemplateSequenceSection>
{
    public TemplateSequenceSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class TemplateSequenceSystem : ObjectBase<UTemplateSequenceSystem>
{
    public TemplateSequenceSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class TemplateSequencePropertyScalingInstantiatorSystem : ObjectBase<UTemplateSequencePropertyScalingInstantiatorSystem>
{
    public TemplateSequencePropertyScalingInstantiatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class TemplateSequencePropertyScalingEvaluatorSystem : ObjectBase<UTemplateSequencePropertyScalingEvaluatorSystem>
{
    public TemplateSequencePropertyScalingEvaluatorSystem(IntPtr pointer) : base(pointer) {}}

public unsafe class TemplateSequenceTrack : ObjectBase<UTemplateSequenceTrack>
{
    public TemplateSequenceTrack(IntPtr pointer) : base(pointer) {}}

