using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AvfMediaSettings : ObjectBase<UAvfMediaSettings>
{
    public AvfMediaSettings(IntPtr pointer) : base(pointer) {}
}

