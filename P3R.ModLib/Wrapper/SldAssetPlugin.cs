using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SldAsset : ObjectBase<USldAsset>
{
    public SldAsset(IntPtr pointer) : base(pointer) {}
}

