using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AppleImageUtilsBaseAsyncTaskBlueprintProxy : ObjectBase<UAppleImageUtilsBaseAsyncTaskBlueprintProxy>
{
    public AppleImageUtilsBaseAsyncTaskBlueprintProxy(IntPtr pointer) : base(pointer) {}
    public UAppleImageUtilsBaseAsyncTaskBlueprintProxy* CreateProxyObjectForConvertToTIFF(UTexture* SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)
    {
        Span<(string name, object value)> @params = [
            ("SourceImage", (IntPtr)SourceImage), 
            ("bWantColor", bWantColor), 
            ("bUseGpu", bUseGpu), 
            ("Scale", Scale), 
            ("Rotate", Rotate)
        ];
        return (UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForConvertToTIFF"), @params);
    }
    public UAppleImageUtilsBaseAsyncTaskBlueprintProxy* CreateProxyObjectForConvertToPNG(UTexture* SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)
    {
        Span<(string name, object value)> @params = [
            ("SourceImage", (IntPtr)SourceImage), 
            ("bWantColor", bWantColor), 
            ("bUseGpu", bUseGpu), 
            ("Scale", Scale), 
            ("Rotate", Rotate)
        ];
        return (UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForConvertToPNG"), @params);
    }
    public UAppleImageUtilsBaseAsyncTaskBlueprintProxy* CreateProxyObjectForConvertToJPEG(UTexture* SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)
    {
        Span<(string name, object value)> @params = [
            ("SourceImage", (IntPtr)SourceImage), 
            ("Quality", Quality), 
            ("bWantColor", bWantColor), 
            ("bUseGpu", bUseGpu), 
            ("Scale", Scale), 
            ("Rotate", Rotate)
        ];
        return (UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForConvertToJPEG"), @params);
    }
    public UAppleImageUtilsBaseAsyncTaskBlueprintProxy* CreateProxyObjectForConvertToHEIF(UTexture* SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate)
    {
        Span<(string name, object value)> @params = [
            ("SourceImage", (IntPtr)SourceImage), 
            ("Quality", Quality), 
            ("bWantColor", bWantColor), 
            ("bUseGpu", bUseGpu), 
            ("Scale", Scale), 
            ("Rotate", Rotate)
        ];
        return (UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)ProcessEvent<IntPtr>(GetFunction("CreateProxyObjectForConvertToHEIF"), @params);
    }
}

public unsafe class AppleImageInterface : ObjectBase<IAppleImageInterface>
{
    public AppleImageInterface(IntPtr pointer) : base(pointer) {}}

