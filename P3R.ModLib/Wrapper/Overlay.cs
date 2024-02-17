using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class Overlays : ObjectBase<UOverlays>
{
    public Overlays(IntPtr pointer) : base(pointer) {}}

public unsafe class BasicOverlays : ObjectBase<UBasicOverlays>
{
    public BasicOverlays(IntPtr pointer) : base(pointer) {}
}

public unsafe class LocalizedOverlays : ObjectBase<ULocalizedOverlays>
{
    public LocalizedOverlays(IntPtr pointer) : base(pointer) {}
}

