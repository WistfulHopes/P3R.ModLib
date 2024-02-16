using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct UMoviePlayerSettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public bool bWaitForMoviesToComplete;
    [FieldOffset(0x0029)] public bool bMoviesAreSkippable;
    [FieldOffset(0x0030)] public TArray<FString> StartupMovies;
}

