using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ClothConfigNv : ObjectBase<UClothConfigNv>
{

}

public unsafe class ClothingSimulationFactoryNv : ObjectBase<UClothingSimulationFactoryNv>
{
}

public unsafe class ClothingSimulationInteractorNv : ObjectBase<UClothingSimulationInteractorNv>
{

    public void SetAnimDriveDamperStiffness(float InStiffness)
    {
        Span<(string name, object value)> @params = [
            ("InStiffness", InStiffness)
        ];
        ProcessEvent(GetFunction("SetAnimDriveDamperStiffness"),  @params);
    }
}

public unsafe class ClothPhysicalMeshDataNv_Legacy : ObjectBase<UClothPhysicalMeshDataNv_Legacy>
{

}

public unsafe class ClothConstraintSetupNv : ObjectBase<FClothConstraintSetupNv>
{

}

