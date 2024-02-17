using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneAtomSection : ObjectBase<UMovieSceneAtomSection>
{
    public MovieSceneAtomSection(IntPtr pointer) : base(pointer) {}
    public void SetStartOffset(FFrameNumber InStartOffset)
    {
        Span<(string name, object value)> @params = [
            ("InStartOffset", InStartOffset)
        ];
        ProcessEvent(GetFunction("SetStartOffset"), @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"), @params);
    }
    public FFrameNumber GetStartOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("GetStartOffset"), @params);
    }
}

public unsafe class MovieSceneAtomTrack : ObjectBase<UMovieSceneAtomTrack>
{
    public MovieSceneAtomTrack(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneManaSection : ObjectBase<UMovieSceneManaSection>
{
    public MovieSceneManaSection(IntPtr pointer) : base(pointer) {}
}

public unsafe class MovieSceneManaTrack : ObjectBase<UMovieSceneManaTrack>
{
    public MovieSceneManaTrack(IntPtr pointer) : base(pointer) {}
}

