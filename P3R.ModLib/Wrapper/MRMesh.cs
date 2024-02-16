using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MeshReconstructorBase : ObjectBase<UMeshReconstructorBase>
{

    public void StopReconstruction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StopReconstruction"),  @params);
    }
    public void StartReconstruction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("StartReconstruction"),  @params);
    }
    public void PauseReconstruction()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PauseReconstruction"),  @params);
    }
    public bool IsReconstructionStarted()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReconstructionStarted"),  @params);
    }
    public bool IsReconstructionPaused()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsReconstructionPaused"),  @params);
    }
    public void DisconnectMRMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisconnectMRMesh"),  @params);
    }
    public void ConnectMRMesh(UMRMeshComponent* Mesh)
    {
        Span<(string name, object value)> @params = [
            ("Mesh", (IntPtr)Mesh)
        ];
        ProcessEvent(GetFunction("ConnectMRMesh"),  @params);
    }
}

public unsafe class MockDataMeshTrackerComponent : ObjectBase<UMockDataMeshTrackerComponent>
{

    public void OnMockDataMeshTrackerUpdated__DelegateSignature(int Index, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<float> Confidence)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("Confidence", Confidence)
        ];
        ProcessEvent(GetFunction("OnMockDataMeshTrackerUpdated__DelegateSignature"),  @params);
    }
    public void DisconnectMRMesh(UMRMeshComponent* InMRMeshPtr)
    {
        Span<(string name, object value)> @params = [
            ("InMRMeshPtr", (IntPtr)InMRMeshPtr)
        ];
        ProcessEvent(GetFunction("DisconnectMRMesh"),  @params);
    }
    public void ConnectMRMesh(UMRMeshComponent* InMRMeshPtr)
    {
        Span<(string name, object value)> @params = [
            ("InMRMeshPtr", (IntPtr)InMRMeshPtr)
        ];
        ProcessEvent(GetFunction("ConnectMRMesh"),  @params);
    }
}

public unsafe class MRMeshComponent : ObjectBase<UMRMeshComponent>
{

    public void SetWireframeMaterial(UMaterialInterface* InMaterial)
    {
        Span<(string name, object value)> @params = [
            ("InMaterial", (IntPtr)InMaterial)
        ];
        ProcessEvent(GetFunction("SetWireframeMaterial"),  @params);
    }
    public void SetWireframeColor(ref FLinearColor InColor)
    {
        Span<(string name, object value)> @params = [
            ("InColor", InColor)
        ];
        ProcessEvent(GetFunction("SetWireframeColor"),  @params);
    }
    public void SetUseWireframe(bool bUseWireframe)
    {
        Span<(string name, object value)> @params = [
            ("bUseWireframe", bUseWireframe)
        ];
        ProcessEvent(GetFunction("SetUseWireframe"),  @params);
    }
    public void SetEnableMeshOcclusion(bool bEnable)
    {
        Span<(string name, object value)> @params = [
            ("bEnable", bEnable)
        ];
        ProcessEvent(GetFunction("SetEnableMeshOcclusion"),  @params);
    }
    public bool IsConnected()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsConnected"),  @params);
    }
    public FLinearColor GetWireframeColor()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FLinearColor>(GetFunction("GetWireframeColor"),  @params);
    }
    public bool GetUseWireframe()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetUseWireframe"),  @params);
    }
    public bool GetEnableMeshOcclusion()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("GetEnableMeshOcclusion"),  @params);
    }
    public void ForceNavMeshUpdate()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ForceNavMeshUpdate"),  @params);
    }
    public void Clear()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Clear"),  @params);
    }
}

public unsafe class MRMeshConfiguration : ObjectBase<FMRMeshConfiguration>
{
}

