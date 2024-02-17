using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ClothConfigCommon : ObjectBase<UClothConfigCommon>
{
    public ClothConfigCommon(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothSharedConfigCommon : ObjectBase<UClothSharedConfigCommon>
{
    public ClothSharedConfigCommon(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingAssetCustomData : ObjectBase<UClothingAssetCustomData>
{
    public ClothingAssetCustomData(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingAssetCommon : ObjectBase<UClothingAssetCommon>
{
    public ClothingAssetCommon(IntPtr pointer) : base(pointer) {}
}

public unsafe class ClothLODDataCommon_Legacy : ObjectBase<UClothLODDataCommon_Legacy>
{
    public ClothLODDataCommon_Legacy(IntPtr pointer) : base(pointer) {}
}

