using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SprAsset : ObjectBase<USprAsset>
{
    public SprAsset(IntPtr pointer) : base(pointer) {}
}

