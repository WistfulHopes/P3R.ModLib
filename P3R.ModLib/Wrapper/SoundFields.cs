using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AmbisonicsEncodingSettings : ObjectBase<UAmbisonicsEncodingSettings>
{
    public AmbisonicsEncodingSettings(IntPtr pointer) : base(pointer) {}
}

