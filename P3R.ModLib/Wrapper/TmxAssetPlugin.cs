using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class TmxAsset : ObjectBase<UTmxAsset>
{
    public TmxAsset(IntPtr pointer) : base(pointer) {}
}

