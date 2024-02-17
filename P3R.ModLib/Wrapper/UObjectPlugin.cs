using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MyPluginObject : ObjectBase<UMyPluginObject>
{
    public MyPluginObject(IntPtr pointer) : base(pointer) {}
}

