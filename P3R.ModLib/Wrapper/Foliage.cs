using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class FoliageInstancedStaticMeshComponent : ObjectBase<UFoliageInstancedStaticMeshComponent>
{

}

public unsafe class FoliageStatistics : ObjectBase<UFoliageStatistics>
{

    public int FoliageOverlappingSphereCount(UObject* WorldContextObject, UStaticMesh* StaticMesh, FVector CenterPosition, float Radius)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("StaticMesh", (IntPtr)StaticMesh), 
            ("CenterPosition", CenterPosition), 
            ("Radius", Radius)
        ];
        return ProcessEvent<int>(GetFunction("FoliageOverlappingSphereCount"),  @params);
    }
    public int FoliageOverlappingBoxCount(UObject* WorldContextObject, UStaticMesh* StaticMesh, FBox Box)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("StaticMesh", (IntPtr)StaticMesh), 
            ("Box", Box)
        ];
        return ProcessEvent<int>(GetFunction("FoliageOverlappingBoxCount"),  @params);
    }
}

public unsafe class FoliageType : ObjectBase<UFoliageType>
{

}

public unsafe class FoliageType_Actor : ObjectBase<UFoliageType_Actor>
{

}

public unsafe class FoliageType_InstancedStaticMesh : ObjectBase<UFoliageType_InstancedStaticMesh>
{

}

public unsafe class InstancedFoliageActor : ObjectBase<AInstancedFoliageActor>
{
}

public unsafe class InteractiveFoliageActor : ObjectBase<AInteractiveFoliageActor>
{

    public void CapsuleTouched(UPrimitiveComponent* OverlappedComp, AActor* Other, UPrimitiveComponent* OtherComp, int OtherBodyIndex, bool bFromSweep, ref FHitResult OverlapInfo)
    {
        Span<(string name, object value)> @params = [
            ("OverlappedComp", (IntPtr)OverlappedComp), 
            ("Other", (IntPtr)Other), 
            ("OtherComp", (IntPtr)OtherComp), 
            ("OtherBodyIndex", OtherBodyIndex), 
            ("bFromSweep", bFromSweep), 
            ("OverlapInfo", OverlapInfo)
        ];
        ProcessEvent(GetFunction("CapsuleTouched"),  @params);
    }
}

public unsafe class InteractiveFoliageComponent : ObjectBase<UInteractiveFoliageComponent>
{
}

public unsafe class ProceduralFoliageBlockingVolume : ObjectBase<AProceduralFoliageBlockingVolume>
{

}

public unsafe class ProceduralFoliageComponent : ObjectBase<UProceduralFoliageComponent>
{

}

public unsafe class ProceduralFoliageSpawner : ObjectBase<UProceduralFoliageSpawner>
{

    public void Simulate(int NumSteps)
    {
        Span<(string name, object value)> @params = [
            ("NumSteps", NumSteps)
        ];
        ProcessEvent(GetFunction("Simulate"),  @params);
    }
}

public unsafe class ProceduralFoliageTile : ObjectBase<UProceduralFoliageTile>
{

}

public unsafe class ProceduralFoliageVolume : ObjectBase<AProceduralFoliageVolume>
{

}

public unsafe class FoliageVertexColorChannelMask : ObjectBase<FFoliageVertexColorChannelMask>
{

}

public unsafe class FoliageTypeObject : ObjectBase<FFoliageTypeObject>
{

}

public unsafe class ProceduralFoliageInstance : ObjectBase<FProceduralFoliageInstance>
{

}

