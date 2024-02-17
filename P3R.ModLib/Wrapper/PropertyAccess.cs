using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class PropertyAccess : ObjectBase<IPropertyAccess>
{
    public PropertyAccess(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyEventBroadcaster : ObjectBase<IPropertyEventBroadcaster>
{
    public PropertyEventBroadcaster(IntPtr pointer) : base(pointer) {}}

public unsafe class PropertyEventSubscriber : ObjectBase<IPropertyEventSubscriber>
{
    public PropertyEventSubscriber(IntPtr pointer) : base(pointer) {}}

