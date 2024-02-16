using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x78)] 
public unsafe struct UMaterialShaderQualitySettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TMap<FName, IntPtr> ForwardSettingMap;
}

[StructLayout(LayoutKind.Explicit, Size = 0x9)] 
public unsafe struct FMaterialQualityOverrides
{
    [FieldOffset(0x0000)] public bool bDiscardQualityDuringCook;
    [FieldOffset(0x0001)] public bool bEnableOverride;
    [FieldOffset(0x0002)] public bool bForceFullyRough;
    [FieldOffset(0x0003)] public bool bForceNonMetal;
    [FieldOffset(0x0004)] public bool bForceDisableLMDirectionality;
    [FieldOffset(0x0005)] public bool bForceLQReflections;
    [FieldOffset(0x0006)] public bool bForceDisablePreintegratedGF;
    [FieldOffset(0x0007)] public bool bDisableMaterialNormalCalculation;
    [FieldOffset(0x0008)] public EMobileShadowQuality MobileShadowQuality;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UShaderPlatformQualitySettings
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public FMaterialQualityOverrides QualityOverrides;
}

