using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class McaAsset : ObjectBase<UMcaAsset>
{
    public McaAsset(IntPtr pointer) : base(pointer) {}
}

