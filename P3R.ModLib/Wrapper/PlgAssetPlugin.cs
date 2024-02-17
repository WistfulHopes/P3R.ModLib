using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class PlgAsset : ObjectBase<UPlgAsset>
{
    public PlgAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class PlgPrimitiveComponent : ObjectBase<UPlgPrimitiveComponent>
{
    public PlgPrimitiveComponent(IntPtr pointer) : base(pointer) {}
}

