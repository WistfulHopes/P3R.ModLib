using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class BuildPatchManifest : ObjectBase<UBuildPatchManifest>
{
    public BuildPatchManifest(IntPtr pointer) : base(pointer) {}
}

