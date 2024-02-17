using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ArchVisCharacter : ObjectBase<AArchVisCharacter>
{
    public ArchVisCharacter(IntPtr pointer) : base(pointer) {}
}

public unsafe class ArchVisCharMovementComponent : ObjectBase<UArchVisCharMovementComponent>
{
    public ArchVisCharMovementComponent(IntPtr pointer) : base(pointer) {}
}

