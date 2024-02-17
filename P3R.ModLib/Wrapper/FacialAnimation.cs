using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AudioCurveSourceComponent : ObjectBase<UAudioCurveSourceComponent>
{
    public AudioCurveSourceComponent(IntPtr pointer) : base(pointer) {}
}

