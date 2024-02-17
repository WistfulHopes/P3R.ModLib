using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class BmdAsset : ObjectBase<UBmdAsset>
{
    public BmdAsset(IntPtr pointer) : base(pointer) {}
}

