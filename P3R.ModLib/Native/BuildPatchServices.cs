using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x14)] 
public unsafe struct FSHAHashData
{
    [FieldOffset(0x0000)] public byte hash;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FChunkPartData
{
    [FieldOffset(0x0000)] public FGuid Guid;
    [FieldOffset(0x0010)] public uint Offset;
    [FieldOffset(0x0014)] public uint Size;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FFileManifestData
{
    [FieldOffset(0x0000)] public FString Filename;
    [FieldOffset(0x0010)] public FSHAHashData FileHash;
    [FieldOffset(0x0028)] public TArray<FChunkPartData> FileChunkParts;
    [FieldOffset(0x0038)] public TArray<FString> InstallTags;
    [FieldOffset(0x0048)] public bool bIsUnixExecutable;
    [FieldOffset(0x0050)] public FString SymlinkTarget;
    [FieldOffset(0x0060)] public bool bIsReadOnly;
    [FieldOffset(0x0061)] public bool bIsCompressed;
}

[StructLayout(LayoutKind.Explicit, Size = 0x40)] 
public unsafe struct FChunkInfoData
{
    [FieldOffset(0x0000)] public FGuid Guid;
    [FieldOffset(0x0010)] public ulong hash;
    [FieldOffset(0x0018)] public FSHAHashData ShaHash;
    [FieldOffset(0x0030)] public long FileSize;
    [FieldOffset(0x0038)] public byte GroupNumber;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FCustomFieldData
{
    [FieldOffset(0x0000)] public FString Key;
    [FieldOffset(0x0010)] public FString Value;
}

[StructLayout(LayoutKind.Explicit, Size = 0x120)] 
public unsafe struct UBuildPatchManifest
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public byte ManifestFileVersion;
    [FieldOffset(0x0029)] public bool bIsFileData;
    [FieldOffset(0x002C)] public uint AppID;
    [FieldOffset(0x0030)] public FString AppName;
    [FieldOffset(0x0040)] public FString BuildVersion;
    [FieldOffset(0x0050)] public FString LaunchExe;
    [FieldOffset(0x0060)] public FString LaunchCommand;
    [FieldOffset(0x0070)] public TSet<FString> PrereqIds;
    [FieldOffset(0x00C0)] public FString PrereqName;
    [FieldOffset(0x00D0)] public FString PrereqPath;
    [FieldOffset(0x00E0)] public FString PrereqArgs;
    [FieldOffset(0x00F0)] public TArray<FFileManifestData> FileManifestList;
    [FieldOffset(0x0100)] public TArray<FChunkInfoData> ChunkList;
    [FieldOffset(0x0110)] public TArray<FCustomFieldData> CustomFields;
}

