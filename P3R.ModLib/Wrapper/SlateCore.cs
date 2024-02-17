using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class FontBulkData : ObjectBase<UFontBulkData>
{
    public FontBulkData(IntPtr pointer) : base(pointer) {}}

public unsafe class FontFaceInterface : ObjectBase<IFontFaceInterface>
{
    public FontFaceInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class FontProviderInterface : ObjectBase<IFontProviderInterface>
{
    public FontProviderInterface(IntPtr pointer) : base(pointer) {}}

public unsafe class SlateTypes : ObjectBase<USlateTypes>
{
    public SlateTypes(IntPtr pointer) : base(pointer) {}}

public unsafe class SlateWidgetStyleAsset : ObjectBase<USlateWidgetStyleAsset>
{
    public SlateWidgetStyleAsset(IntPtr pointer) : base(pointer) {}
}

public unsafe class SlateWidgetStyleContainerBase : ObjectBase<USlateWidgetStyleContainerBase>
{
    public SlateWidgetStyleContainerBase(IntPtr pointer) : base(pointer) {}}

public unsafe class SlateWidgetStyleContainerInterface : ObjectBase<ISlateWidgetStyleContainerInterface>
{
    public SlateWidgetStyleContainerInterface(IntPtr pointer) : base(pointer) {}}

