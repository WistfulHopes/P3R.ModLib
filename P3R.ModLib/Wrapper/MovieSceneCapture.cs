using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MovieSceneCaptureProtocolBase : ObjectBase<UMovieSceneCaptureProtocolBase>
{

    public bool IsCapturing()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCapturing"),  @params);
    }
    public EMovieSceneCaptureProtocolState GetState()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<EMovieSceneCaptureProtocolState>(GetFunction("GetState"),  @params);
    }
}

public unsafe class MovieSceneAudioCaptureProtocolBase : ObjectBase<UMovieSceneAudioCaptureProtocolBase>
{
}

public unsafe class NullAudioCaptureProtocol : ObjectBase<UNullAudioCaptureProtocol>
{
}

public unsafe class MasterAudioSubmixCaptureProtocol : ObjectBase<UMasterAudioSubmixCaptureProtocol>
{

}

public unsafe class MovieSceneImageCaptureProtocolBase : ObjectBase<UMovieSceneImageCaptureProtocolBase>
{
}

public unsafe class CompositionGraphCaptureProtocol : ObjectBase<UCompositionGraphCaptureProtocol>
{

}

public unsafe class FrameGrabberProtocol : ObjectBase<UFrameGrabberProtocol>
{
}

public unsafe class ImageSequenceProtocol : ObjectBase<UImageSequenceProtocol>
{
}

public unsafe class CompressedImageSequenceProtocol : ObjectBase<UCompressedImageSequenceProtocol>
{

}

public unsafe class ImageSequenceProtocol_BMP : ObjectBase<UImageSequenceProtocol_BMP>
{
}

public unsafe class ImageSequenceProtocol_PNG : ObjectBase<UImageSequenceProtocol_PNG>
{
}

public unsafe class ImageSequenceProtocol_JPG : ObjectBase<UImageSequenceProtocol_JPG>
{
}

public unsafe class ImageSequenceProtocol_EXR : ObjectBase<UImageSequenceProtocol_EXR>
{

}

public unsafe class MovieSceneCaptureInterface : ObjectBase<IMovieSceneCaptureInterface>
{
}

public unsafe class MovieSceneCapture : ObjectBase<UMovieSceneCapture>
{

    public void SetImageCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
    {
        Span<(string name, object value)> @params = [
            ("ProtocolType", ProtocolType)
        ];
        ProcessEvent(GetFunction("SetImageCaptureProtocolType"),  @params);
    }
    public void SetAudioCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
    {
        Span<(string name, object value)> @params = [
            ("ProtocolType", ProtocolType)
        ];
        ProcessEvent(GetFunction("SetAudioCaptureProtocolType"),  @params);
    }
    public UMovieSceneCaptureProtocolBase* GetImageCaptureProtocol()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneCaptureProtocolBase*)ProcessEvent<IntPtr>(GetFunction("GetImageCaptureProtocol"),  @params);
    }
    public UMovieSceneCaptureProtocolBase* GetAudioCaptureProtocol()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneCaptureProtocolBase*)ProcessEvent<IntPtr>(GetFunction("GetAudioCaptureProtocol"),  @params);
    }
}

public unsafe class LevelCapture : ObjectBase<ULevelCapture>
{

}

public unsafe class MovieSceneCaptureEnvironment : ObjectBase<UMovieSceneCaptureEnvironment>
{

    public bool IsCaptureInProgress()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCaptureInProgress"),  @params);
    }
    public int GetCaptureFrameNumber()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetCaptureFrameNumber"),  @params);
    }
    public float GetCaptureElapsedTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetCaptureElapsedTime"),  @params);
    }
    public UMovieSceneImageCaptureProtocolBase* FindImageCaptureProtocol()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneImageCaptureProtocolBase*)ProcessEvent<IntPtr>(GetFunction("FindImageCaptureProtocol"),  @params);
    }
    public UMovieSceneAudioCaptureProtocolBase* FindAudioCaptureProtocol()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UMovieSceneAudioCaptureProtocolBase*)ProcessEvent<IntPtr>(GetFunction("FindAudioCaptureProtocol"),  @params);
    }
}

public unsafe class CapturedPixelsID : ObjectBase<FCapturedPixelsID>
{

}

public unsafe class CapturedPixels : ObjectBase<FCapturedPixels>
{
}

public unsafe class FrameMetrics : ObjectBase<FFrameMetrics>
{

}

public unsafe class UserDefinedCaptureProtocol : ObjectBase<UUserDefinedCaptureProtocol>
{

    public void StopCapturingFinalPixels()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopCapturingFinalPixels"),  @params);
    }
    public void StartCapturingFinalPixels(ref FCapturedPixelsID StreamID)
    {
        Span<(string name, object value)> @params = [
            ("StreamID", StreamID)
        ];
        ProcessEvent(GetFunction("StartCapturingFinalPixels"),  @params);
    }
    public void ResolveBuffer(UTexture* Buffer, ref FCapturedPixelsID BufferID)
    {
        Span<(string name, object value)> @params = [
            ("Buffer", (IntPtr)Buffer), 
            ("BufferID", BufferID)
        ];
        ProcessEvent(GetFunction("ResolveBuffer"),  @params);
    }
    public void OnWarmUp()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnWarmUp"),  @params);
    }
    public void OnTick()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnTick"),  @params);
    }
    public void OnStartCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnStartCapture"),  @params);
    }
    public bool OnSetup()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnSetup"),  @params);
    }
    public void OnPreTick()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnPreTick"),  @params);
    }
    public void OnPixelsReceived(ref FCapturedPixels Pixels, ref FCapturedPixelsID ID, FFrameMetrics FrameMetrics)
    {
        Span<(string name, object value)> @params = [
            ("Pixels", Pixels), 
            ("ID", ID), 
            ("FrameMetrics", FrameMetrics)
        ];
        ProcessEvent(GetFunction("OnPixelsReceived"),  @params);
    }
    public void OnPauseCapture()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnPauseCapture"),  @params);
    }
    public void OnFinalize()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnFinalize"),  @params);
    }
    public void OnCaptureFrame()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnCaptureFrame"),  @params);
    }
    public bool OnCanFinalize()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("OnCanFinalize"),  @params);
    }
    public void OnBeginFinalize()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("OnBeginFinalize"),  @params);
    }
    public FFrameMetrics GetCurrentFrameMetrics()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameMetrics>(GetFunction("GetCurrentFrameMetrics"),  @params);
    }
    public FString GenerateFilename(ref FFrameMetrics InFrameMetrics)
    {
        Span<(string name, object value)> @params = [
            ("InFrameMetrics", InFrameMetrics)
        ];
        return ProcessEvent<FString>(GetFunction("GenerateFilename"),  @params);
    }
}

public unsafe class UserDefinedImageCaptureProtocol : ObjectBase<UUserDefinedImageCaptureProtocol>
{

    public void WriteImageToDisk(ref FCapturedPixels PixelData, ref FCapturedPixelsID StreamID, ref FFrameMetrics FrameMetrics, bool bCopyImageData)
    {
        Span<(string name, object value)> @params = [
            ("PixelData", PixelData), 
            ("StreamID", StreamID), 
            ("FrameMetrics", FrameMetrics), 
            ("bCopyImageData", bCopyImageData)
        ];
        ProcessEvent(GetFunction("WriteImageToDisk"),  @params);
    }
    public FString GenerateFilenameForCurrentFrame()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GenerateFilenameForCurrentFrame"),  @params);
    }
    public FString GenerateFilenameForBuffer(UTexture* Buffer, ref FCapturedPixelsID StreamID)
    {
        Span<(string name, object value)> @params = [
            ("Buffer", (IntPtr)Buffer), 
            ("StreamID", StreamID)
        ];
        return ProcessEvent<FString>(GetFunction("GenerateFilenameForBuffer"),  @params);
    }
}

public unsafe class VideoCaptureProtocol : ObjectBase<UVideoCaptureProtocol>
{

}

public unsafe class CompositionGraphCapturePasses : ObjectBase<FCompositionGraphCapturePasses>
{

}

public unsafe class MovieSceneCaptureSettings : ObjectBase<FMovieSceneCaptureSettings>
{

}

public unsafe class CaptureResolution : ObjectBase<FCaptureResolution>
{

}

