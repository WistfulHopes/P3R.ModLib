using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class FontStyleAsset : ObjectBase<UFontStyleAsset>
{
    public FontStyleAsset(IntPtr pointer) : base(pointer) {}
}

