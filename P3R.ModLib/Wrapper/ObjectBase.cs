using System.Runtime.InteropServices;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public class ObjectBase<TObjType> : ObjectReference where TObjType : unmanaged
{
    public TObjType Instance => Marshal.PtrToStructure<TObjType>(Pointer);

    public ObjectBase(IntPtr pointer)
    {
        Pointer = pointer;
    }
}