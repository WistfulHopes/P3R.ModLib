using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ClothConfigNv : ObjectBase<UClothConfigNv>
{
    public ClothConfigNv(IntPtr pointer) : base(pointer) {}
}

public unsafe class ClothingSimulationFactoryNv : ObjectBase<UClothingSimulationFactoryNv>
{
    public ClothingSimulationFactoryNv(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingSimulationInteractorNv : ObjectBase<UClothingSimulationInteractorNv>
{
    public ClothingSimulationInteractorNv(IntPtr pointer) : base(pointer) {}
    public void SetAnimDriveDamperStiffness(float InStiffness)
    {
        Span<(string name, object value)> @params = [
            ("InStiffness", InStiffness)
        ];
        ProcessEvent(GetFunction("SetAnimDriveDamperStiffness"), @params);
    }
}

public unsafe class ClothPhysicalMeshDataNv_Legacy : ObjectBase<UClothPhysicalMeshDataNv_Legacy>
{
    public ClothPhysicalMeshDataNv_Legacy(IntPtr pointer) : base(pointer) {}
}

