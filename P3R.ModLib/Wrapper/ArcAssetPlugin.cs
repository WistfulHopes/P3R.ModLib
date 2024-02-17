using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ArcAsset : ObjectBase<UArcAsset>
{
    public ArcAsset(IntPtr pointer) : base(pointer) {}
}

