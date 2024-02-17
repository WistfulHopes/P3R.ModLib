using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class MeshDescription : ObjectBase<UDEPRECATED_MeshDescription>
{
    public MeshDescription(IntPtr pointer) : base(pointer) {}}

public unsafe class MeshDescriptionBase : ObjectBase<UMeshDescriptionBase>
{
    public MeshDescriptionBase(IntPtr pointer) : base(pointer) {}
    public void SetVertexPosition(FVertexID VertexID, ref FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("Position", Position)
        ];
        ProcessEvent(GetFunction("SetVertexPosition"), @params);
    }
    public void SetPolygonVertexInstance(FPolygonID PolygonID, int PerimeterIndex, FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PerimeterIndex", PerimeterIndex), 
            ("VertexInstanceID", VertexInstanceID)
        ];
        ProcessEvent(GetFunction("SetPolygonVertexInstance"), @params);
    }
    public void SetPolygonPolygonGroup(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PolygonGroupID", PolygonGroupID)
        ];
        ProcessEvent(GetFunction("SetPolygonPolygonGroup"), @params);
    }
    public void ReversePolygonFacing(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        ProcessEvent(GetFunction("ReversePolygonFacing"), @params);
    }
    public void ReserveNewVertices(int NumberOfNewVertices)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewVertices", NumberOfNewVertices)
        ];
        ProcessEvent(GetFunction("ReserveNewVertices"), @params);
    }
    public void ReserveNewVertexInstances(int NumberOfNewVertexInstances)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewVertexInstances", NumberOfNewVertexInstances)
        ];
        ProcessEvent(GetFunction("ReserveNewVertexInstances"), @params);
    }
    public void ReserveNewTriangles(int NumberOfNewTriangles)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewTriangles", NumberOfNewTriangles)
        ];
        ProcessEvent(GetFunction("ReserveNewTriangles"), @params);
    }
    public void ReserveNewPolygons(int NumberOfNewPolygons)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewPolygons", NumberOfNewPolygons)
        ];
        ProcessEvent(GetFunction("ReserveNewPolygons"), @params);
    }
    public void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewPolygonGroups", NumberOfNewPolygonGroups)
        ];
        ProcessEvent(GetFunction("ReserveNewPolygonGroups"), @params);
    }
    public void ReserveNewEdges(int NumberOfNewEdges)
    {
        Span<(string name, object value)> @params = [
            ("NumberOfNewEdges", NumberOfNewEdges)
        ];
        ProcessEvent(GetFunction("ReserveNewEdges"), @params);
    }
    public bool IsVertexValid(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<bool>(GetFunction("IsVertexValid"), @params);
    }
    public bool IsVertexOrphaned(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<bool>(GetFunction("IsVertexOrphaned"), @params);
    }
    public bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<bool>(GetFunction("IsVertexInstanceValid"), @params);
    }
    public bool IsTriangleValid(FTriangleID TriangleID)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID)
        ];
        return ProcessEvent<bool>(GetFunction("IsTriangleValid"), @params);
    }
    public bool IsTrianglePartOfNgon(FTriangleID TriangleID)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID)
        ];
        return ProcessEvent<bool>(GetFunction("IsTrianglePartOfNgon"), @params);
    }
    public bool IsPolygonValid(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<bool>(GetFunction("IsPolygonValid"), @params);
    }
    public bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        return ProcessEvent<bool>(GetFunction("IsPolygonGroupValid"), @params);
    }
    public bool IsEmpty()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsEmpty"), @params);
    }
    public bool IsEdgeValid(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<bool>(GetFunction("IsEdgeValid"), @params);
    }
    public bool IsEdgeInternalToPolygon(FEdgeID EdgeID, FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<bool>(GetFunction("IsEdgeInternalToPolygon"), @params);
    }
    public bool IsEdgeInternal(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<bool>(GetFunction("IsEdgeInternal"), @params);
    }
    public void GetVertexVertexInstances(FVertexID VertexID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutVertexInstanceIDs", OutVertexInstanceIDs)
        ];
        ProcessEvent(GetFunction("GetVertexVertexInstances"), @params);
    }
    public FVector GetVertexPosition(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<FVector>(GetFunction("GetVertexPosition"), @params);
    }
    public FEdgeID GetVertexPairEdge(FVertexID VertexID0, FVertexID VertexID1)
    {
        Span<(string name, object value)> @params = [
            ("VertexID0", VertexID0), 
            ("VertexID1", VertexID1)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetVertexPairEdge"), @params);
    }
    public FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<FVertexID>(GetFunction("GetVertexInstanceVertex"), @params);
    }
    public FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0, FVertexInstanceID VertexInstanceID1)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID0", VertexInstanceID0), 
            ("VertexInstanceID1", VertexInstanceID1)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetVertexInstancePairEdge"), @params);
    }
    public FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID, FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("VertexID", VertexID)
        ];
        return ProcessEvent<FVertexInstanceID>(GetFunction("GetVertexInstanceForTriangleVertex"), @params);
    }
    public FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID, FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("VertexID", VertexID)
        ];
        return ProcessEvent<FVertexInstanceID>(GetFunction("GetVertexInstanceForPolygonVertex"), @params);
    }
    public void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("OutConnectedTriangleIDs", OutConnectedTriangleIDs)
        ];
        ProcessEvent(GetFunction("GetVertexInstanceConnectedTriangles"), @params);
    }
    public void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetVertexInstanceConnectedPolygons"), @params);
    }
    public void GetVertexConnectedTriangles(FVertexID VertexID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutConnectedTriangleIDs", OutConnectedTriangleIDs)
        ];
        ProcessEvent(GetFunction("GetVertexConnectedTriangles"), @params);
    }
    public void GetVertexConnectedPolygons(FVertexID VertexID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetVertexConnectedPolygons"), @params);
    }
    public void GetVertexConnectedEdges(FVertexID VertexID, ref TArray<FEdgeID> OutEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutEdgeIDs", OutEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetVertexConnectedEdges"), @params);
    }
    public void GetVertexAdjacentVertices(FVertexID VertexID, ref TArray<FVertexID> OutAdjacentVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutAdjacentVertexIDs", OutAdjacentVertexIDs)
        ];
        ProcessEvent(GetFunction("GetVertexAdjacentVertices"), @params);
    }
    public void GetTriangleVertices(FTriangleID TriangleID, ref TArray<FVertexID> OutVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("OutVertexIDs", OutVertexIDs)
        ];
        ProcessEvent(GetFunction("GetTriangleVertices"), @params);
    }
    public void GetTriangleVertexInstances(FTriangleID TriangleID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("OutVertexInstanceIDs", OutVertexInstanceIDs)
        ];
        ProcessEvent(GetFunction("GetTriangleVertexInstances"), @params);
    }
    public FVertexInstanceID GetTriangleVertexInstance(FTriangleID TriangleID, int Index)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("Index", Index)
        ];
        return ProcessEvent<FVertexInstanceID>(GetFunction("GetTriangleVertexInstance"), @params);
    }
    public FPolygonGroupID GetTrianglePolygonGroup(FTriangleID TriangleID)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID)
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("GetTrianglePolygonGroup"), @params);
    }
    public FPolygonID GetTrianglePolygon(FTriangleID TriangleID)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("GetTrianglePolygon"), @params);
    }
    public void GetTriangleEdges(FTriangleID TriangleID, ref TArray<FEdgeID> OutEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("OutEdgeIDs", OutEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetTriangleEdges"), @params);
    }
    public void GetTriangleAdjacentTriangles(FTriangleID TriangleID, ref TArray<FTriangleID> OutTriangleIDs)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("OutTriangleIDs", OutTriangleIDs)
        ];
        ProcessEvent(GetFunction("GetTriangleAdjacentTriangles"), @params);
    }
    public void GetPolygonVertices(FPolygonID PolygonID, ref TArray<FVertexID> OutVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutVertexIDs", OutVertexIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonVertices"), @params);
    }
    public void GetPolygonVertexInstances(FPolygonID PolygonID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutVertexInstanceIDs", OutVertexInstanceIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonVertexInstances"), @params);
    }
    public void GetPolygonTriangles(FPolygonID PolygonID, ref TArray<FTriangleID> OutTriangleIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutTriangleIDs", OutTriangleIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonTriangles"), @params);
    }
    public FPolygonGroupID GetPolygonPolygonGroup(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("GetPolygonPolygonGroup"), @params);
    }
    public void GetPolygonPerimeterEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutEdgeIDs", OutEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonPerimeterEdges"), @params);
    }
    public void GetPolygonInternalEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutEdgeIDs", OutEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonInternalEdges"), @params);
    }
    public void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID, ref TArray<FPolygonID> OutPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID), 
            ("OutPolygonIDs", OutPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonGroupPolygons"), @params);
    }
    public void GetPolygonAdjacentPolygons(FPolygonID PolygonID, ref TArray<FPolygonID> OutPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutPolygonIDs", OutPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonAdjacentPolygons"), @params);
    }
    public int GetNumVertexVertexInstances(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexVertexInstances"), @params);
    }
    public int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexInstanceConnectedTriangles"), @params);
    }
    public int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexInstanceConnectedPolygons"), @params);
    }
    public int GetNumVertexConnectedTriangles(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexConnectedTriangles"), @params);
    }
    public int GetNumVertexConnectedPolygons(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexConnectedPolygons"), @params);
    }
    public int GetNumVertexConnectedEdges(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumVertexConnectedEdges"), @params);
    }
    public int GetNumPolygonVertices(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumPolygonVertices"), @params);
    }
    public int GetNumPolygonTriangles(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumPolygonTriangles"), @params);
    }
    public int GetNumPolygonInternalEdges(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumPolygonInternalEdges"), @params);
    }
    public int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumPolygonGroupPolygons"), @params);
    }
    public int GetNumEdgeConnectedTriangles(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumEdgeConnectedTriangles"), @params);
    }
    public int GetNumEdgeConnectedPolygons(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<int>(GetFunction("GetNumEdgeConnectedPolygons"), @params);
    }
    public void GetEdgeVertices(FEdgeID EdgeID, ref TArray<FVertexID> OutVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutVertexIDs", OutVertexIDs)
        ];
        ProcessEvent(GetFunction("GetEdgeVertices"), @params);
    }
    public FVertexID GetEdgeVertex(FEdgeID EdgeID, int VertexNumber)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("VertexNumber", VertexNumber)
        ];
        return ProcessEvent<FVertexID>(GetFunction("GetEdgeVertex"), @params);
    }
    public void GetEdgeConnectedTriangles(FEdgeID EdgeID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutConnectedTriangleIDs", OutConnectedTriangleIDs)
        ];
        ProcessEvent(GetFunction("GetEdgeConnectedTriangles"), @params);
    }
    public void GetEdgeConnectedPolygons(FEdgeID EdgeID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetEdgeConnectedPolygons"), @params);
    }
    public void Empty()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Empty"), @params);
    }
    public void DeleteVertexInstance(FVertexInstanceID VertexInstanceID, ref TArray<FVertexID> OrphanedVertices)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("OrphanedVertices", OrphanedVertices)
        ];
        ProcessEvent(GetFunction("DeleteVertexInstance"), @params);
    }
    public void DeleteVertex(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        ProcessEvent(GetFunction("DeleteVertex"), @params);
    }
    public void DeleteTriangle(FTriangleID TriangleID, ref TArray<FEdgeID> OrphanedEdges, ref TArray<FVertexInstanceID> OrphanedVertexInstances, ref TArray<FPolygonGroupID> OrphanedPolygonGroupsPtr)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("OrphanedEdges", OrphanedEdges), 
            ("OrphanedVertexInstances", OrphanedVertexInstances), 
            ("OrphanedPolygonGroupsPtr", OrphanedPolygonGroupsPtr)
        ];
        ProcessEvent(GetFunction("DeleteTriangle"), @params);
    }
    public void DeletePolygonGroup(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        ProcessEvent(GetFunction("DeletePolygonGroup"), @params);
    }
    public void DeletePolygon(FPolygonID PolygonID, ref TArray<FEdgeID> OrphanedEdges, ref TArray<FVertexInstanceID> OrphanedVertexInstances, ref TArray<FPolygonGroupID> OrphanedPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OrphanedEdges", OrphanedEdges), 
            ("OrphanedVertexInstances", OrphanedVertexInstances), 
            ("OrphanedPolygonGroups", OrphanedPolygonGroups)
        ];
        ProcessEvent(GetFunction("DeletePolygon"), @params);
    }
    public void DeleteEdge(FEdgeID EdgeID, ref TArray<FVertexID> OrphanedVertices)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OrphanedVertices", OrphanedVertices)
        ];
        ProcessEvent(GetFunction("DeleteEdge"), @params);
    }
    public void CreateVertexWithID(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        ProcessEvent(GetFunction("CreateVertexWithID"), @params);
    }
    public void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID, FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("VertexID", VertexID)
        ];
        ProcessEvent(GetFunction("CreateVertexInstanceWithID"), @params);
    }
    public FVertexInstanceID CreateVertexInstance(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<FVertexInstanceID>(GetFunction("CreateVertexInstance"), @params);
    }
    public FVertexID CreateVertex()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVertexID>(GetFunction("CreateVertex"), @params);
    }
    public void CreateTriangleWithID(FTriangleID TriangleID, FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("TriangleID", TriangleID), 
            ("PolygonGroupID", PolygonGroupID), 
            ("VertexInstanceIDs", VertexInstanceIDs), 
            ("NewEdgeIDs", NewEdgeIDs)
        ];
        ProcessEvent(GetFunction("CreateTriangleWithID"), @params);
    }
    public FTriangleID CreateTriangle(FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID), 
            ("VertexInstanceIDs", VertexInstanceIDs), 
            ("NewEdgeIDs", NewEdgeIDs)
        ];
        return ProcessEvent<FTriangleID>(GetFunction("CreateTriangle"), @params);
    }
    public void CreatePolygonWithID(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PolygonGroupID", PolygonGroupID), 
            ("VertexInstanceIDs", VertexInstanceIDs), 
            ("NewEdgeIDs", NewEdgeIDs)
        ];
        ProcessEvent(GetFunction("CreatePolygonWithID"), @params);
    }
    public void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        ProcessEvent(GetFunction("CreatePolygonGroupWithID"), @params);
    }
    public FPolygonGroupID CreatePolygonGroup()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("CreatePolygonGroup"), @params);
    }
    public FPolygonID CreatePolygon(FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID), 
            ("VertexInstanceIDs", VertexInstanceIDs), 
            ("NewEdgeIDs", NewEdgeIDs)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("CreatePolygon"), @params);
    }
    public void CreateEdgeWithID(FEdgeID EdgeID, FVertexID VertexID0, FVertexID VertexID1)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("VertexID0", VertexID0), 
            ("VertexID1", VertexID1)
        ];
        ProcessEvent(GetFunction("CreateEdgeWithID"), @params);
    }
    public FEdgeID CreateEdge(FVertexID VertexID0, FVertexID VertexID1)
    {
        Span<(string name, object value)> @params = [
            ("VertexID0", VertexID0), 
            ("VertexID1", VertexID1)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("CreateEdge"), @params);
    }
    public void ComputePolygonTriangulation(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        ProcessEvent(GetFunction("ComputePolygonTriangulation"), @params);
    }
}

