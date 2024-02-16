using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneAtomSection : ObjectBase<UMovieSceneAtomSection>
{

    public void SetStartOffset(FFrameNumber InStartOffset)
    {
        Span<(string name, object value)> @params = [
            ("InStartOffset", InStartOffset)
        ];
        ProcessEvent(GetFunction("SetStartOffset"),  @params);
    }
    public bool IsLooping()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsLooping"),  @params);
    }
    public FFrameNumber GetStartOffset()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("GetStartOffset"),  @params);
    }
}

public unsafe class MovieSceneAtomTrack : ObjectBase<UMovieSceneAtomTrack>
{

}

public unsafe class MovieSceneManaSection : ObjectBase<UMovieSceneManaSection>
{

}

public unsafe class MovieSceneManaTrack : ObjectBase<UMovieSceneManaTrack>
{

}

public unsafe class MovieSceneAtomSectionTemplate : ObjectBase<FMovieSceneAtomSectionTemplate>
{

}

public unsafe class MovieSceneManaSectionTemplate : ObjectBase<FMovieSceneManaSectionTemplate>
{

}

public unsafe class MovieSceneManaSectionParams : ObjectBase<FMovieSceneManaSectionParams>
{

}

