using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FLightPropagationVolumeSettings
{
    [FieldOffset(0x0000)] public byte bOverride_LPVIntensity;
    [FieldOffset(0x0000)] public byte bOverride_LPVDirectionalOcclusionIntensity;
    [FieldOffset(0x0000)] public byte bOverride_LPVDirectionalOcclusionRadius;
    [FieldOffset(0x0000)] public byte bOverride_LPVDiffuseOcclusionExponent;
    [FieldOffset(0x0000)] public byte bOverride_LPVSpecularOcclusionExponent;
    [FieldOffset(0x0000)] public byte bOverride_LPVDiffuseOcclusionIntensity;
    [FieldOffset(0x0000)] public byte bOverride_LPVSpecularOcclusionIntensity;
    [FieldOffset(0x0000)] public byte bOverride_LPVSize;
    [FieldOffset(0x0001)] public byte bOverride_LPVSecondaryOcclusionIntensity;
    [FieldOffset(0x0001)] public byte bOverride_LPVSecondaryBounceIntensity;
    [FieldOffset(0x0001)] public byte bOverride_LPVGeometryVolumeBias;
    [FieldOffset(0x0001)] public byte bOverride_LPVVplInjectionBias;
    [FieldOffset(0x0001)] public byte bOverride_LPVEmissiveInjectionIntensity;
    [FieldOffset(0x0004)] public float LPVIntensity;
    [FieldOffset(0x0008)] public float LPVVplInjectionBias;
    [FieldOffset(0x000C)] public float LPVSize;
    [FieldOffset(0x0010)] public float LPVSecondaryOcclusionIntensity;
    [FieldOffset(0x0014)] public float LPVSecondaryBounceIntensity;
    [FieldOffset(0x0018)] public float LPVGeometryVolumeBias;
    [FieldOffset(0x001C)] public float LPVEmissiveInjectionIntensity;
    [FieldOffset(0x0020)] public float LPVDirectionalOcclusionIntensity;
    [FieldOffset(0x0024)] public float LPVDirectionalOcclusionRadius;
    [FieldOffset(0x0028)] public float LPVDiffuseOcclusionExponent;
    [FieldOffset(0x002C)] public float LPVSpecularOcclusionExponent;
    [FieldOffset(0x0030)] public float LPVDiffuseOcclusionIntensity;
    [FieldOffset(0x0034)] public float LPVSpecularOcclusionIntensity;
    [FieldOffset(0x0038)] public float LPVFadeRange;
    [FieldOffset(0x003C)] public float LPVDirectionalOcclusionFadeRange;
}

