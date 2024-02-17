using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ActorSequence : ObjectBase<UActorSequence>
{
    public ActorSequence(IntPtr pointer) : base(pointer) {}
}

public unsafe class ActorSequenceComponent : ObjectBase<UActorSequenceComponent>
{
    public ActorSequenceComponent(IntPtr pointer) : base(pointer) {}
}

public unsafe class ActorSequencePlayer : ObjectBase<UActorSequencePlayer>
{
    public ActorSequencePlayer(IntPtr pointer) : base(pointer) {}}

