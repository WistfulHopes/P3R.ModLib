using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ImageWriteBlueprintLibrary : ObjectBase<UImageWriteBlueprintLibrary>
{
    public ImageWriteBlueprintLibrary(IntPtr pointer) : base(pointer) {}
    public void ExportToDisk(UTexture* Texture, FString Filename, ref FImageWriteOptions Options)
    {
        Span<(string name, object value)> @params = [
            ("Texture", (IntPtr)Texture), 
            ("Filename", Filename), 
            ("Options", Options)
        ];
        ProcessEvent(GetFunction("ExportToDisk"), @params);
    }
}

