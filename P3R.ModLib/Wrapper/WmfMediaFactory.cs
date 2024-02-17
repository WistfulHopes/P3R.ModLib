using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class WmfMediaSettings : ObjectBase<UWmfMediaSettings>
{
    public WmfMediaSettings(IntPtr pointer) : base(pointer) {}
}

