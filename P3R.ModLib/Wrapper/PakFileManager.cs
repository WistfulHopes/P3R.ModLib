using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class PakFile : ObjectBase<UPakFile>
{

    public bool syncReadFile()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("syncReadFile"),  @params);
    }
}

public unsafe class PakFileManagerControl : ObjectBase<UPakFileManagerControl>
{

    public UPakFile* requestReadFile(FString Filename)
    {
        Span<(string name, object value)> @params = [
            ("Filename", Filename)
        ];
        return (UPakFile*)ProcessEvent<IntPtr>(GetFunction("requestReadFile"),  @params);
    }
}

public unsafe class PakFiledManagerGameInstanceSubSystem : ObjectBase<UPakFiledManagerGameInstanceSubSystem>
{

    public UPakFileManagerControl* GetFileManagerControl()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UPakFileManagerControl*)ProcessEvent<IntPtr>(GetFunction("GetFileManagerControl"),  @params);
    }
}

