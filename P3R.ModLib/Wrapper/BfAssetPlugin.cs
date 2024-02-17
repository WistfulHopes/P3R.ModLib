using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class BfAsset : ObjectBase<UBfAsset>
{
    public BfAsset(IntPtr pointer) : base(pointer) {}
}

