using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ChaosClothConfig : ObjectBase<UChaosClothConfig>
{

}

public unsafe class ChaosClothSharedSimConfig : ObjectBase<UChaosClothSharedSimConfig>
{

}

public unsafe class ChaosClothingSimulationFactory : ObjectBase<UChaosClothingSimulationFactory>
{
}

public unsafe class ChaosClothingInteractor : ObjectBase<UChaosClothingInteractor>
{

    public void SetVelocityScale(FVector LinearVelocityScale, float AngularVelocityScale, float FictitiousAngularScale)
    {
        Span<(string name, object value)> @params = [
            ("LinearVelocityScale", LinearVelocityScale), 
            ("AngularVelocityScale", AngularVelocityScale), 
            ("FictitiousAngularScale", FictitiousAngularScale)
        ];
        ProcessEvent(GetFunction("SetVelocityScale"),  @params);
    }
    public void SetMaterialLinear(float EdgeStiffness, float BendingStiffness, float AreaStiffness)
    {
        Span<(string name, object value)> @params = [
            ("EdgeStiffness", EdgeStiffness), 
            ("BendingStiffness", BendingStiffness), 
            ("AreaStiffness", AreaStiffness)
        ];
        ProcessEvent(GetFunction("SetMaterialLinear"),  @params);
    }
    public void SetLongRangeAttachmentLinear(float TetherStiffness)
    {
        Span<(string name, object value)> @params = [
            ("TetherStiffness", TetherStiffness)
        ];
        ProcessEvent(GetFunction("SetLongRangeAttachmentLinear"),  @params);
    }
    public void SetLongRangeAttachment(FVector2D TetherStiffness)
    {
        Span<(string name, object value)> @params = [
            ("TetherStiffness", TetherStiffness)
        ];
        ProcessEvent(GetFunction("SetLongRangeAttachment"),  @params);
    }
    public void SetGravity(float GravityScale, bool bIsGravityOverridden, FVector GravityOverride)
    {
        Span<(string name, object value)> @params = [
            ("GravityScale", GravityScale), 
            ("bIsGravityOverridden", bIsGravityOverridden), 
            ("GravityOverride", GravityOverride)
        ];
        ProcessEvent(GetFunction("SetGravity"),  @params);
    }
    public void SetDamping(float DampingCoefficient)
    {
        Span<(string name, object value)> @params = [
            ("DampingCoefficient", DampingCoefficient)
        ];
        ProcessEvent(GetFunction("SetDamping"),  @params);
    }
    public void SetCollision(float CollisionThickness, float FrictionCoefficient, bool bUseCCD, float SelfCollisionThickness)
    {
        Span<(string name, object value)> @params = [
            ("CollisionThickness", CollisionThickness), 
            ("FrictionCoefficient", FrictionCoefficient), 
            ("bUseCCD", bUseCCD), 
            ("SelfCollisionThickness", SelfCollisionThickness)
        ];
        ProcessEvent(GetFunction("SetCollision"),  @params);
    }
    public void SetAnimDriveLinear(float AnimDriveStiffness)
    {
        Span<(string name, object value)> @params = [
            ("AnimDriveStiffness", AnimDriveStiffness)
        ];
        ProcessEvent(GetFunction("SetAnimDriveLinear"),  @params);
    }
    public void SetAnimDrive(FVector2D AnimDriveStiffness, FVector2D AnimDriveDamping)
    {
        Span<(string name, object value)> @params = [
            ("AnimDriveStiffness", AnimDriveStiffness), 
            ("AnimDriveDamping", AnimDriveDamping)
        ];
        ProcessEvent(GetFunction("SetAnimDrive"),  @params);
    }
    public void SetAerodynamics(float DragCoefficient, float LiftCoefficient, FVector WindVelocity)
    {
        Span<(string name, object value)> @params = [
            ("DragCoefficient", DragCoefficient), 
            ("LiftCoefficient", LiftCoefficient), 
            ("WindVelocity", WindVelocity)
        ];
        ProcessEvent(GetFunction("SetAerodynamics"),  @params);
    }
    public void ResetAndTeleport(bool bReset, bool bTeleport)
    {
        Span<(string name, object value)> @params = [
            ("bReset", bReset), 
            ("bTeleport", bTeleport)
        ];
        ProcessEvent(GetFunction("ResetAndTeleport"),  @params);
    }
}

public unsafe class ChaosClothingSimulationInteractor : ObjectBase<UChaosClothingSimulationInteractor>
{
}

public unsafe class ChaosClothWeightedValue : ObjectBase<FChaosClothWeightedValue>
{

}

