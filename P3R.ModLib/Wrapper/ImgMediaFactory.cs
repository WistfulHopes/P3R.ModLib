using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ImgMediaSettings : ObjectBase<UImgMediaSettings>
{
    public ImgMediaSettings(IntPtr pointer) : base(pointer) {}
}

