using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class CacheData : ObjectBase<UCacheData>
{
    public CacheData(IntPtr pointer) : base(pointer) {}
}

public unsafe class OrderingTableResourceCache : ObjectBase<UOrderingTableResourceCache>
{
    public OrderingTableResourceCache(IntPtr pointer) : base(pointer) {}
}

