using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MoviePlayerSettings : ObjectBase<UMoviePlayerSettings>
{
    public MoviePlayerSettings(IntPtr pointer) : base(pointer) {}
}

