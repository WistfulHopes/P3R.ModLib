using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ClothConfigBase : ObjectBase<UClothConfigBase>
{
    public ClothConfigBase(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingSimulationFactory : ObjectBase<UClothingSimulationFactory>
{
    public ClothingSimulationFactory(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingInteractor : ObjectBase<UClothingInteractor>
{
    public ClothingInteractor(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingSimulationInteractor : ObjectBase<UClothingSimulationInteractor>
{
    public ClothingSimulationInteractor(IntPtr pointer) : base(pointer) {}
    public void SetNumSubsteps(int NumSubsteps)
    {
        Span<(string name, object value)> @params = [
            ("NumSubsteps", NumSubsteps)
        ];
        ProcessEvent(GetFunction("SetNumSubsteps"), @params);
    }
    public void SetNumIterations(int NumIterations)
    {
        Span<(string name, object value)> @params = [
            ("NumIterations", NumIterations)
        ];
        ProcessEvent(GetFunction("SetNumIterations"), @params);
    }
    public void SetAnimDriveSpringStiffness(float InStiffness)
    {
        Span<(string name, object value)> @params = [
            ("InStiffness", InStiffness)
        ];
        ProcessEvent(GetFunction("SetAnimDriveSpringStiffness"), @params);
    }
    public void PhysicsAssetUpdated()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PhysicsAssetUpdated"), @params);
    }
    public float GetSimulationTime()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<float>(GetFunction("GetSimulationTime"), @params);
    }
    public int GetNumSubsteps()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumSubsteps"), @params);
    }
    public int GetNumKinematicParticles()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumKinematicParticles"), @params);
    }
    public int GetNumIterations()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumIterations"), @params);
    }
    public int GetNumDynamicParticles()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumDynamicParticles"), @params);
    }
    public int GetNumCloths()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumCloths"), @params);
    }
    public UClothingInteractor* GetClothingInteractor(FString ClothingAssetName)
    {
        Span<(string name, object value)> @params = [
            ("ClothingAssetName", ClothingAssetName)
        ];
        return (UClothingInteractor*)ProcessEvent<IntPtr>(GetFunction("GetClothingInteractor"), @params);
    }
    public void EnableGravityOverride(ref FVector InVector)
    {
        Span<(string name, object value)> @params = [
            ("InVector", InVector)
        ];
        ProcessEvent(GetFunction("EnableGravityOverride"), @params);
    }
    public void DisableGravityOverride()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisableGravityOverride"), @params);
    }
    public void ClothConfigUpdated()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClothConfigUpdated"), @params);
    }
}

public unsafe class ClothSharedSimConfigBase : ObjectBase<UDEPRECATED_ClothSharedSimConfigBase>
{
    public ClothSharedSimConfigBase(IntPtr pointer) : base(pointer) {}}

public unsafe class ClothingAssetBase : ObjectBase<UClothingAssetBase>
{
    public ClothingAssetBase(IntPtr pointer) : base(pointer) {}
}

public unsafe class ClothPhysicalMeshDataBase_Legacy : ObjectBase<UClothPhysicalMeshDataBase_Legacy>
{
    public ClothPhysicalMeshDataBase_Legacy(IntPtr pointer) : base(pointer) {}
}

