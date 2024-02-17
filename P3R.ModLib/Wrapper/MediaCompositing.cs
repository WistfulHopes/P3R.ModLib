using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneMediaPlayerPropertySection : ObjectBase<UMovieSceneMediaPlayerPropertySection>
{
    public MovieSceneMediaPlayerPropertySection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMediaPlayerPropertyTrack : ObjectBase<UMovieSceneMediaPlayerPropertyTrack>
{
    public MovieSceneMediaPlayerPropertyTrack(IntPtr pointer) : base(pointer) {}}

public unsafe class MovieSceneMediaSection : ObjectBase<UMovieSceneMediaSection>
{
    public MovieSceneMediaSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneMediaTrack : ObjectBase<UMovieSceneMediaTrack>
{
    public MovieSceneMediaTrack(IntPtr pointer) : base(pointer) {}
}

