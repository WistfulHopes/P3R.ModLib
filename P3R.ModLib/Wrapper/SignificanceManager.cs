using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class SignificanceManager : ObjectBase<USignificanceManager>
{
    public SignificanceManager(IntPtr pointer) : base(pointer) {}
}

