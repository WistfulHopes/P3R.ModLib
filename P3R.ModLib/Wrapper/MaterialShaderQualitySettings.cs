using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MaterialShaderQualitySettings : ObjectBase<UMaterialShaderQualitySettings>
{
    public MaterialShaderQualitySettings(IntPtr pointer) : base(pointer) {}
}

public unsafe class ShaderPlatformQualitySettings : ObjectBase<UShaderPlatformQualitySettings>
{
    public ShaderPlatformQualitySettings(IntPtr pointer) : base(pointer) {}
}

