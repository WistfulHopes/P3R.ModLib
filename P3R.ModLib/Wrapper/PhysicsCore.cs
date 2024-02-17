using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class BodySetupCore : ObjectBase<UBodySetupCore>
{
    public BodySetupCore(IntPtr pointer) : base(pointer) {}
}

public unsafe class ChaosPhysicalMaterial : ObjectBase<UChaosPhysicalMaterial>
{
    public ChaosPhysicalMaterial(IntPtr pointer) : base(pointer) {}
}

public unsafe class PhysicalMaterial : ObjectBase<UPhysicalMaterial>
{
    public PhysicalMaterial(IntPtr pointer) : base(pointer) {}
}

public unsafe class PhysicalMaterialPropertyBase : ObjectBase<UDEPRECATED_PhysicalMaterialPropertyBase>
{
    public PhysicalMaterialPropertyBase(IntPtr pointer) : base(pointer) {}}

public unsafe class PhysicsSettingsCore : ObjectBase<UPhysicsSettingsCore>
{
    public PhysicsSettingsCore(IntPtr pointer) : base(pointer) {}
}

