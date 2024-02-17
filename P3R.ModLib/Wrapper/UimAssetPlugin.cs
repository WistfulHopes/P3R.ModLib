using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class UimAsset : ObjectBase<UUimAsset>
{
    public UimAsset(IntPtr pointer) : base(pointer) {}
}

