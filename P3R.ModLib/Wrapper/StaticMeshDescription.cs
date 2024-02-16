using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class StaticMeshDescription : ObjectBase<UStaticMeshDescription>
{

    public void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID, FVector2D UV, int UVIndex)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("UV", UV), 
            ("UVIndex", UVIndex)
        ];
        ProcessEvent(GetFunction("SetVertexInstanceUV"),  @params);
    }
    public void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID, ref FName SlotName)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID), 
            ("SlotName", SlotName)
        ];
        ProcessEvent(GetFunction("SetPolygonGroupMaterialSlotName"),  @params);
    }
    public FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID, int UVIndex)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("UVIndex", UVIndex)
        ];
        return ProcessEvent<FVector2D>(GetFunction("GetVertexInstanceUV"),  @params);
    }
    public void CreateCube(FVector Center, FVector HalfExtents, FPolygonGroupID PolygonGroup, ref FPolygonID PolygonID_PlusX, ref FPolygonID PolygonID_MinusX, ref FPolygonID PolygonID_PlusY, ref FPolygonID PolygonID_MinusY, ref FPolygonID PolygonID_PlusZ, ref FPolygonID PolygonID_MinusZ)
    {
        Span<(string name, object value)> @params = [
            ("Center", Center), 
            ("HalfExtents", HalfExtents), 
            ("PolygonGroup", PolygonGroup), 
            ("PolygonID_PlusX", PolygonID_PlusX), 
            ("PolygonID_MinusX", PolygonID_MinusX), 
            ("PolygonID_PlusY", PolygonID_PlusY), 
            ("PolygonID_MinusY", PolygonID_MinusY), 
            ("PolygonID_PlusZ", PolygonID_PlusZ), 
            ("PolygonID_MinusZ", PolygonID_MinusZ)
        ];
        ProcessEvent(GetFunction("CreateCube"),  @params);
    }
}

public unsafe class UVMapSettings : ObjectBase<FUVMapSettings>
{

}

