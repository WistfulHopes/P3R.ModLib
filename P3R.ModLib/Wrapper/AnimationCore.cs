using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AnimationDataSourceRegistry : ObjectBase<UAnimationDataSourceRegistry>
{
    public AnimationDataSourceRegistry(IntPtr pointer) : base(pointer) {}
}

