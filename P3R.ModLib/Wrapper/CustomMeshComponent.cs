using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class CustomMeshComponent : ObjectBase<UCustomMeshComponent>
{
    public CustomMeshComponent(IntPtr pointer) : base(pointer) {}
    public bool SetCustomMeshTriangles(ref TArray<FCustomMeshTriangle> Triangles)
    {
        Span<(string name, object value)> @params = [
            ("Triangles", Triangles)
        ];
        return ProcessEvent<bool>(GetFunction("SetCustomMeshTriangles"), @params);
    }
    public void ClearCustomMeshTriangles()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearCustomMeshTriangles"), @params);
    }
    public void AddCustomMeshTriangles(ref TArray<FCustomMeshTriangle> Triangles)
    {
        Span<(string name, object value)> @params = [
            ("Triangles", Triangles)
        ];
        ProcessEvent(GetFunction("AddCustomMeshTriangles"), @params);
    }
}

