using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class FixedFrameRateCustomTimeStep : ObjectBase<UFixedFrameRateCustomTimeStep>
{
    public FixedFrameRateCustomTimeStep(IntPtr pointer) : base(pointer) {}}

public unsafe class GenlockedCustomTimeStep : ObjectBase<UGenlockedCustomTimeStep>
{
    public GenlockedCustomTimeStep(IntPtr pointer) : base(pointer) {}}

public unsafe class GenlockedFixedRateCustomTimeStep : ObjectBase<UGenlockedFixedRateCustomTimeStep>
{
    public GenlockedFixedRateCustomTimeStep(IntPtr pointer) : base(pointer) {}
}

public unsafe class GenlockedTimecodeProvider : ObjectBase<UGenlockedTimecodeProvider>
{
    public GenlockedTimecodeProvider(IntPtr pointer) : base(pointer) {}
}

public unsafe class TimeManagementBlueprintLibrary : ObjectBase<UTimeManagementBlueprintLibrary>
{
    public TimeManagementBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public FFrameTime TransformTime(ref FFrameTime SourceTime, ref FFrameRate SourceRate, ref FFrameRate DestinationRate)
    {
        Span<(string name, object value)> @params = [
            ("SourceTime", SourceTime), 
            ("SourceRate", SourceRate), 
            ("DestinationRate", DestinationRate)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("TransformTime"), @params);
    }
    public FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A, int B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Subtract_FrameNumberInteger"), @params);
    }
    public FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Subtract_FrameNumberFrameNumber"), @params);
    }
    public FFrameTime SnapFrameTimeToRate(ref FFrameTime SourceTime, ref FFrameRate SourceRate, ref FFrameRate SnapToRate)
    {
        Span<(string name, object value)> @params = [
            ("SourceTime", SourceTime), 
            ("SourceRate", SourceRate), 
            ("SnapToRate", SnapToRate)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("SnapFrameTimeToRate"), @params);
    }
    public FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds, ref FFrameRate FrameRate)
    {
        Span<(string name, object value)> @params = [
            ("TimeInSeconds", TimeInSeconds), 
            ("FrameRate", FrameRate)
        ];
        return ProcessEvent<FFrameTime>(GetFunction("Multiply_SecondsFrameRate"), @params);
    }
    public FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A, int B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Multiply_FrameNumberInteger"), @params);
    }
    public bool IsValid_MultipleOf(ref FFrameRate InFrameRate, ref FFrameRate OtherFramerate)
    {
        Span<(string name, object value)> @params = [
            ("InFrameRate", InFrameRate), 
            ("OtherFramerate", OtherFramerate)
        ];
        return ProcessEvent<bool>(GetFunction("IsValid_MultipleOf"), @params);
    }
    public bool IsValid_Framerate(ref FFrameRate InFrameRate)
    {
        Span<(string name, object value)> @params = [
            ("InFrameRate", InFrameRate)
        ];
        return ProcessEvent<bool>(GetFunction("IsValid_Framerate"), @params);
    }
    public FFrameRate GetTimecodeFrameRate()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FFrameRate>(GetFunction("GetTimecodeFrameRate"), @params);
    }
    public FTimecode GetTimecode()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FTimecode>(GetFunction("GetTimecode"), @params);
    }
    public FFrameNumber Divide_FrameNumberInteger(FFrameNumber A, int B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Divide_FrameNumberInteger"), @params);
    }
    public FString Conv_TimecodeToString(ref FTimecode InTimecode, bool bForceSignDisplay)
    {
        Span<(string name, object value)> @params = [
            ("InTimecode", InTimecode), 
            ("bForceSignDisplay", bForceSignDisplay)
        ];
        return ProcessEvent<FString>(GetFunction("Conv_TimecodeToString"), @params);
    }
    public float Conv_QualifiedFrameTimeToSeconds(ref FQualifiedFrameTime InFrameTime)
    {
        Span<(string name, object value)> @params = [
            ("InFrameTime", InFrameTime)
        ];
        return ProcessEvent<float>(GetFunction("Conv_QualifiedFrameTimeToSeconds"), @params);
    }
    public float Conv_FrameRateToSeconds(ref FFrameRate InFrameRate)
    {
        Span<(string name, object value)> @params = [
            ("InFrameRate", InFrameRate)
        ];
        return ProcessEvent<float>(GetFunction("Conv_FrameRateToSeconds"), @params);
    }
    public int Conv_FrameNumberToInteger(ref FFrameNumber InFrameNumber)
    {
        Span<(string name, object value)> @params = [
            ("InFrameNumber", InFrameNumber)
        ];
        return ProcessEvent<int>(GetFunction("Conv_FrameNumberToInteger"), @params);
    }
    public FFrameNumber Add_FrameNumberInteger(FFrameNumber A, int B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Add_FrameNumberInteger"), @params);
    }
    public FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
    {
        Span<(string name, object value)> @params = [
            ("A", A), 
            ("B", B)
        ];
        return ProcessEvent<FFrameNumber>(GetFunction("Add_FrameNumberFrameNumber"), @params);
    }
}

public unsafe class TimeSynchronizationSource : ObjectBase<UTimeSynchronizationSource>
{
    public TimeSynchronizationSource(IntPtr pointer) : base(pointer) {}
}

