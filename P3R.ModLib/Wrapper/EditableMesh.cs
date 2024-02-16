using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class EditableMeshAdapter : ObjectBase<UEditableMeshAdapter>
{
}

public unsafe class EditableGeometryCollectionAdapter : ObjectBase<UEditableGeometryCollectionAdapter>
{

}

public unsafe class PolygonToSplit : ObjectBase<FPolygonToSplit>
{

}

public unsafe class AttributesForVertex : ObjectBase<FAttributesForVertex>
{

}

public unsafe class AttributesForVertexInstance : ObjectBase<FAttributesForVertexInstance>
{

}

public unsafe class VertexAttributesForPolygon : ObjectBase<FVertexAttributesForPolygon>
{

}

public unsafe class AttributesForEdge : ObjectBase<FAttributesForEdge>
{

}

public unsafe class VertexToMove : ObjectBase<FVertexToMove>
{

}

public unsafe class SubdivisionLimitData : ObjectBase<FSubdivisionLimitData>
{

}

public unsafe class VertexToCreate : ObjectBase<FVertexToCreate>
{

}

public unsafe class VertexInstanceToCreate : ObjectBase<FVertexInstanceToCreate>
{

}

public unsafe class PolygonToCreate : ObjectBase<FPolygonToCreate>
{

}

public unsafe class PolygonGroupToCreate : ObjectBase<FPolygonGroupToCreate>
{

}

public unsafe class EdgeToCreate : ObjectBase<FEdgeToCreate>
{

}

public unsafe class ChangeVertexInstancesForPolygon : ObjectBase<FChangeVertexInstancesForPolygon>
{

}

public unsafe class PolygonGroupForPolygon : ObjectBase<FPolygonGroupForPolygon>
{

}

public unsafe class EditableMesh : ObjectBase<UEditableMesh>
{

    public void WeldVertices(ref TArray<FVertexID> VertexIDs, ref FVertexID OutNewVertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexIDs", VertexIDs), 
            ("OutNewVertexID", OutNewVertexID)
        ];
        ProcessEvent(GetFunction("WeldVertices"),  @params);
    }
    public void TryToRemoveVertex(FVertexID VertexID, ref bool bOutWasVertexRemoved, ref FEdgeID OutNewEdgeID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("bOutWasVertexRemoved", bOutWasVertexRemoved), 
            ("OutNewEdgeID", OutNewEdgeID)
        ];
        ProcessEvent(GetFunction("TryToRemoveVertex"),  @params);
    }
    public void TryToRemovePolygonEdge(FEdgeID EdgeID, ref bool bOutWasEdgeRemoved, ref FPolygonID OutNewPolygonID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("bOutWasEdgeRemoved", bOutWasEdgeRemoved), 
            ("OutNewPolygonID", OutNewPolygonID)
        ];
        ProcessEvent(GetFunction("TryToRemovePolygonEdge"),  @params);
    }
    public void TriangulatePolygons(ref TArray<FPolygonID> PolygonIDs, ref TArray<FPolygonID> OutNewTrianglePolygons)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs), 
            ("OutNewTrianglePolygons", OutNewTrianglePolygons)
        ];
        ProcessEvent(GetFunction("TriangulatePolygons"),  @params);
    }
    public void TessellatePolygons(ref TArray<FPolygonID> PolygonIDs, ETriangleTessellationMode TriangleTessellationMode, ref TArray<FPolygonID> OutNewPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs), 
            ("TriangleTessellationMode", TriangleTessellationMode), 
            ("OutNewPolygonIDs", OutNewPolygonIDs)
        ];
        ProcessEvent(GetFunction("TessellatePolygons"),  @params);
    }
    public void StartModification(EMeshModificationType MeshModificationType, EMeshTopologyChange MeshTopologyChange)
    {
        Span<(string name, object value)> @params = [
            ("MeshModificationType", MeshModificationType), 
            ("MeshTopologyChange", MeshTopologyChange)
        ];
        ProcessEvent(GetFunction("StartModification"),  @params);
    }
    public void SplitPolygons(ref TArray<FPolygonToSplit> PolygonsToSplit, ref TArray<FEdgeID> OutNewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonsToSplit", PolygonsToSplit), 
            ("OutNewEdgeIDs", OutNewEdgeIDs)
        ];
        ProcessEvent(GetFunction("SplitPolygons"),  @params);
    }
    public void SplitPolygonalMesh(ref FPlane InPlane, ref TArray<FPolygonID> PolygonIDs1, ref TArray<FPolygonID> PolygonIDs2, ref TArray<FEdgeID> BoundaryIDs)
    {
        Span<(string name, object value)> @params = [
            ("InPlane", InPlane), 
            ("PolygonIDs1", PolygonIDs1), 
            ("PolygonIDs2", PolygonIDs2), 
            ("BoundaryIDs", BoundaryIDs)
        ];
        ProcessEvent(GetFunction("SplitPolygonalMesh"),  @params);
    }
    public void SplitEdge(FEdgeID EdgeID, ref TArray<float> Splits, ref TArray<FVertexID> OutNewVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("Splits", Splits), 
            ("OutNewVertexIDs", OutNewVertexIDs)
        ];
        ProcessEvent(GetFunction("SplitEdge"),  @params);
    }
    public void SetVerticesCornerSharpness(ref TArray<FVertexID> VertexIDs, ref TArray<float> VerticesNewCornerSharpness)
    {
        Span<(string name, object value)> @params = [
            ("VertexIDs", VertexIDs), 
            ("VerticesNewCornerSharpness", VerticesNewCornerSharpness)
        ];
        ProcessEvent(GetFunction("SetVerticesCornerSharpness"),  @params);
    }
    public void SetVerticesAttributes(ref TArray<FAttributesForVertex> AttributesForVertices)
    {
        Span<(string name, object value)> @params = [
            ("AttributesForVertices", AttributesForVertices)
        ];
        ProcessEvent(GetFunction("SetVerticesAttributes"),  @params);
    }
    public void SetVertexInstancesAttributes(ref TArray<FAttributesForVertexInstance> AttributesForVertexInstances)
    {
        Span<(string name, object value)> @params = [
            ("AttributesForVertexInstances", AttributesForVertexInstances)
        ];
        ProcessEvent(GetFunction("SetVertexInstancesAttributes"),  @params);
    }
    public void SetTextureCoordinateCount(int NumTexCoords)
    {
        Span<(string name, object value)> @params = [
            ("NumTexCoords", NumTexCoords)
        ];
        ProcessEvent(GetFunction("SetTextureCoordinateCount"),  @params);
    }
    public void SetSubdivisionCount(int NewSubdivisionCount)
    {
        Span<(string name, object value)> @params = [
            ("NewSubdivisionCount", NewSubdivisionCount)
        ];
        ProcessEvent(GetFunction("SetSubdivisionCount"),  @params);
    }
    public void SetPolygonsVertexAttributes(ref TArray<FVertexAttributesForPolygon> VertexAttributesForPolygons)
    {
        Span<(string name, object value)> @params = [
            ("VertexAttributesForPolygons", VertexAttributesForPolygons)
        ];
        ProcessEvent(GetFunction("SetPolygonsVertexAttributes"),  @params);
    }
    public void SetEdgesHardnessAutomatically(ref TArray<FEdgeID> EdgeIDs, float MaxDotProductForSoftEdge)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIDs", EdgeIDs), 
            ("MaxDotProductForSoftEdge", MaxDotProductForSoftEdge)
        ];
        ProcessEvent(GetFunction("SetEdgesHardnessAutomatically"),  @params);
    }
    public void SetEdgesHardness(ref TArray<FEdgeID> EdgeIDs, ref TArray<bool> EdgesNewIsHard)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIDs", EdgeIDs), 
            ("EdgesNewIsHard", EdgesNewIsHard)
        ];
        ProcessEvent(GetFunction("SetEdgesHardness"),  @params);
    }
    public void SetEdgesCreaseSharpness(ref TArray<FEdgeID> EdgeIDs, ref TArray<float> EdgesNewCreaseSharpness)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIDs", EdgeIDs), 
            ("EdgesNewCreaseSharpness", EdgesNewCreaseSharpness)
        ];
        ProcessEvent(GetFunction("SetEdgesCreaseSharpness"),  @params);
    }
    public void SetEdgesAttributes(ref TArray<FAttributesForEdge> AttributesForEdges)
    {
        Span<(string name, object value)> @params = [
            ("AttributesForEdges", AttributesForEdges)
        ];
        ProcessEvent(GetFunction("SetEdgesAttributes"),  @params);
    }
    public void SetAllowUndo(bool bInAllowUndo)
    {
        Span<(string name, object value)> @params = [
            ("bInAllowUndo", bInAllowUndo)
        ];
        ProcessEvent(GetFunction("SetAllowUndo"),  @params);
    }
    public void SetAllowSpatialDatabase(bool bInAllowSpatialDatabase)
    {
        Span<(string name, object value)> @params = [
            ("bInAllowSpatialDatabase", bInAllowSpatialDatabase)
        ];
        ProcessEvent(GetFunction("SetAllowSpatialDatabase"),  @params);
    }
    public void SetAllowCompact(bool bInAllowCompact)
    {
        Span<(string name, object value)> @params = [
            ("bInAllowCompact", bInAllowCompact)
        ];
        ProcessEvent(GetFunction("SetAllowCompact"),  @params);
    }
    public void SearchSpatialDatabaseForPolygonsPotentiallyIntersectingPlane(ref FPlane InPlane, ref TArray<FPolygonID> OutPolygons)
    {
        Span<(string name, object value)> @params = [
            ("InPlane", InPlane), 
            ("OutPolygons", OutPolygons)
        ];
        ProcessEvent(GetFunction("SearchSpatialDatabaseForPolygonsPotentiallyIntersectingPlane"),  @params);
    }
    public void SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment(FVector LineSegmentStart, FVector LineSegmentEnd, ref TArray<FPolygonID> OutPolygons)
    {
        Span<(string name, object value)> @params = [
            ("LineSegmentStart", LineSegmentStart), 
            ("LineSegmentEnd", LineSegmentEnd), 
            ("OutPolygons", OutPolygons)
        ];
        ProcessEvent(GetFunction("SearchSpatialDatabaseForPolygonsPotentiallyIntersectingLineSegment"),  @params);
    }
    public void SearchSpatialDatabaseForPolygonsInVolume(ref TArray<FPlane> Planes, ref TArray<FPolygonID> OutPolygons)
    {
        Span<(string name, object value)> @params = [
            ("Planes", Planes), 
            ("OutPolygons", OutPolygons)
        ];
        ProcessEvent(GetFunction("SearchSpatialDatabaseForPolygonsInVolume"),  @params);
    }
    public UEditableMesh* RevertInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return (UEditableMesh*)ProcessEvent<IntPtr>(GetFunction("RevertInstance"),  @params);
    }
    public void Revert()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Revert"),  @params);
    }
    public void RebuildRenderMesh()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("RebuildRenderMesh"),  @params);
    }
    public void QuadrangulateMesh(ref TArray<FPolygonID> OutNewPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("OutNewPolygonIDs", OutNewPolygonIDs)
        ];
        ProcessEvent(GetFunction("QuadrangulateMesh"),  @params);
    }
    public void PropagateInstanceChanges()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("PropagateInstanceChanges"),  @params);
    }
    public void MoveVertices(ref TArray<FVertexToMove> VerticesToMove)
    {
        Span<(string name, object value)> @params = [
            ("VerticesToMove", VerticesToMove)
        ];
        ProcessEvent(GetFunction("MoveVertices"),  @params);
    }
    public FVertexID MakeVertexID(int VertexIndex)
    {
        Span<(string name, object value)> @params = [
            ("VertexIndex", VertexIndex)
        ];
        return ProcessEvent<FVertexID>(GetFunction("MakeVertexID"),  @params);
    }
    public FPolygonID MakePolygonID(int PolygonIndex)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIndex", PolygonIndex)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("MakePolygonID"),  @params);
    }
    public FPolygonGroupID MakePolygonGroupID(int PolygonGroupIndex)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupIndex", PolygonGroupIndex)
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("MakePolygonGroupID"),  @params);
    }
    public FEdgeID MakeEdgeID(int EdgeIndex)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIndex", EdgeIndex)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("MakeEdgeID"),  @params);
    }
    public bool IsValidVertex(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidVertex"),  @params);
    }
    public bool IsValidPolygonGroup(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidPolygonGroup"),  @params);
    }
    public bool IsValidPolygon(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidPolygon"),  @params);
    }
    public bool IsValidEdge(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<bool>(GetFunction("IsValidEdge"),  @params);
    }
    public bool IsUndoAllowed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsUndoAllowed"),  @params);
    }
    public bool IsSpatialDatabaseAllowed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsSpatialDatabaseAllowed"),  @params);
    }
    public bool IsPreviewingSubdivisions()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsPreviewingSubdivisions"),  @params);
    }
    public bool IsOrphanedVertex(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<bool>(GetFunction("IsOrphanedVertex"),  @params);
    }
    public bool IsCompactAllowed()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCompactAllowed"),  @params);
    }
    public bool IsCommittedAsInstance()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCommittedAsInstance"),  @params);
    }
    public bool IsCommitted()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsCommitted"),  @params);
    }
    public bool IsBeingModified()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("IsBeingModified"),  @params);
    }
    public FVertexID InvalidVertexID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FVertexID>(GetFunction("InvalidVertexID"),  @params);
    }
    public FPolygonID InvalidPolygonID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FPolygonID>(GetFunction("InvalidPolygonID"),  @params);
    }
    public FPolygonGroupID InvalidPolygonGroupID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("InvalidPolygonGroupID"),  @params);
    }
    public FEdgeID InvalidEdgeID()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FEdgeID>(GetFunction("InvalidEdgeID"),  @params);
    }
    public void InsetPolygons(ref TArray<FPolygonID> PolygonIDs, float InsetFixedDistance, float InsetProgressTowardCenter, EInsetPolygonsMode Mode, ref TArray<FPolygonID> OutNewCenterPolygonIDs, ref TArray<FPolygonID> OutNewSidePolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs), 
            ("InsetFixedDistance", InsetFixedDistance), 
            ("InsetProgressTowardCenter", InsetProgressTowardCenter), 
            ("Mode", Mode), 
            ("OutNewCenterPolygonIDs", OutNewCenterPolygonIDs), 
            ("OutNewSidePolygonIDs", OutNewSidePolygonIDs)
        ];
        ProcessEvent(GetFunction("InsetPolygons"),  @params);
    }
    public void InsertEdgeLoop(FEdgeID EdgeID, ref TArray<float> Splits, ref TArray<FEdgeID> OutNewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("Splits", Splits), 
            ("OutNewEdgeIDs", OutNewEdgeIDs)
        ];
        ProcessEvent(GetFunction("InsertEdgeLoop"),  @params);
    }
    public void InitializeAdapters()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("InitializeAdapters"),  @params);
    }
    public FEdgeID GetVertexPairEdge(FVertexID VertexID, FVertexID NextVertexID, ref bool bOutEdgeWindingIsReversed)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("NextVertexID", NextVertexID), 
            ("bOutEdgeWindingIsReversed", bOutEdgeWindingIsReversed)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetVertexPairEdge"),  @params);
    }
    public FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<FVertexID>(GetFunction("GetVertexInstanceVertex"),  @params);
    }
    public int GetVertexInstanceCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetVertexInstanceCount"),  @params);
    }
    public void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetVertexInstanceConnectedPolygons"),  @params);
    }
    public int GetVertexInstanceConnectedPolygonCount(FVertexInstanceID VertexInstanceID)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID)
        ];
        return ProcessEvent<int>(GetFunction("GetVertexInstanceConnectedPolygonCount"),  @params);
    }
    public FPolygonID GetVertexInstanceConnectedPolygon(FVertexInstanceID VertexInstanceID, int ConnectedPolygonNumber)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceID", VertexInstanceID), 
            ("ConnectedPolygonNumber", ConnectedPolygonNumber)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("GetVertexInstanceConnectedPolygon"),  @params);
    }
    public int GetVertexCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetVertexCount"),  @params);
    }
    public void GetVertexConnectedPolygons(FVertexID VertexID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetVertexConnectedPolygons"),  @params);
    }
    public void GetVertexConnectedEdges(FVertexID VertexID, ref TArray<FEdgeID> OutConnectedEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutConnectedEdgeIDs", OutConnectedEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetVertexConnectedEdges"),  @params);
    }
    public int GetVertexConnectedEdgeCount(FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("GetVertexConnectedEdgeCount"),  @params);
    }
    public FEdgeID GetVertexConnectedEdge(FVertexID VertexID, int ConnectedEdgeNumber)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("ConnectedEdgeNumber", ConnectedEdgeNumber)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetVertexConnectedEdge"),  @params);
    }
    public void GetVertexAdjacentVertices(FVertexID VertexID, ref TArray<FVertexID> OutAdjacentVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("OutAdjacentVertexIDs", OutAdjacentVertexIDs)
        ];
        ProcessEvent(GetFunction("GetVertexAdjacentVertices"),  @params);
    }
    public int GetTextureCoordinateCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetTextureCoordinateCount"),  @params);
    }
    public FSubdivisionLimitData GetSubdivisionLimitData()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FSubdivisionLimitData>(GetFunction("GetSubdivisionLimitData"),  @params);
    }
    public int GetSubdivisionCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetSubdivisionCount"),  @params);
    }
    public int GetPolygonTriangulatedTriangleCount(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonTriangulatedTriangleCount"),  @params);
    }
    public FTriangleID GetPolygonTriangulatedTriangle(FPolygonID PolygonID, int PolygonTriangleNumber)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PolygonTriangleNumber", PolygonTriangleNumber)
        ];
        return ProcessEvent<FTriangleID>(GetFunction("GetPolygonTriangulatedTriangle"),  @params);
    }
    public void GetPolygonPerimeterVertices(FPolygonID PolygonID, ref TArray<FVertexID> OutPolygonPerimeterVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutPolygonPerimeterVertexIDs", OutPolygonPerimeterVertexIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonPerimeterVertices"),  @params);
    }
    public void GetPolygonPerimeterVertexInstances(FPolygonID PolygonID, ref TArray<FVertexInstanceID> OutPolygonPerimeterVertexInstanceIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutPolygonPerimeterVertexInstanceIDs", OutPolygonPerimeterVertexInstanceIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonPerimeterVertexInstances"),  @params);
    }
    public FVertexInstanceID GetPolygonPerimeterVertexInstance(FPolygonID PolygonID, int PolygonVertexNumber)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PolygonVertexNumber", PolygonVertexNumber)
        ];
        return ProcessEvent<FVertexInstanceID>(GetFunction("GetPolygonPerimeterVertexInstance"),  @params);
    }
    public int GetPolygonPerimeterVertexCount(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonPerimeterVertexCount"),  @params);
    }
    public FVertexID GetPolygonPerimeterVertex(FPolygonID PolygonID, int PolygonVertexNumber)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PolygonVertexNumber", PolygonVertexNumber)
        ];
        return ProcessEvent<FVertexID>(GetFunction("GetPolygonPerimeterVertex"),  @params);
    }
    public void GetPolygonPerimeterEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutPolygonPerimeterEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutPolygonPerimeterEdgeIDs", OutPolygonPerimeterEdgeIDs)
        ];
        ProcessEvent(GetFunction("GetPolygonPerimeterEdges"),  @params);
    }
    public int GetPolygonPerimeterEdgeCount(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonPerimeterEdgeCount"),  @params);
    }
    public FEdgeID GetPolygonPerimeterEdge(FPolygonID PolygonID, int PerimeterEdgeNumber, ref bool bOutEdgeWindingIsReversedForPolygon)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("PerimeterEdgeNumber", PerimeterEdgeNumber), 
            ("bOutEdgeWindingIsReversedForPolygon", bOutEdgeWindingIsReversedForPolygon)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetPolygonPerimeterEdge"),  @params);
    }
    public FPolygonID GetPolygonInGroup(FPolygonGroupID PolygonGroupID, int PolygonNumber)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID), 
            ("PolygonNumber", PolygonNumber)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("GetPolygonInGroup"),  @params);
    }
    public int GetPolygonGroupCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonGroupCount"),  @params);
    }
    public int GetPolygonCountInGroup(FPolygonGroupID PolygonGroupID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupID", PolygonGroupID)
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonCountInGroup"),  @params);
    }
    public int GetPolygonCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetPolygonCount"),  @params);
    }
    public void GetPolygonAdjacentPolygons(FPolygonID PolygonID, ref TArray<FPolygonID> OutAdjacentPolygons)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutAdjacentPolygons", OutAdjacentPolygons)
        ];
        ProcessEvent(GetFunction("GetPolygonAdjacentPolygons"),  @params);
    }
    public FPolygonGroupID GetGroupForPolygon(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("GetGroupForPolygon"),  @params);
    }
    public FPolygonGroupID GetFirstValidPolygonGroup()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FPolygonGroupID>(GetFunction("GetFirstValidPolygonGroup"),  @params);
    }
    public void GetEdgeVertices(FEdgeID EdgeID, ref FVertexID OutEdgeVertexID0, ref FVertexID OutEdgeVertexID1)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutEdgeVertexID0", OutEdgeVertexID0), 
            ("OutEdgeVertexID1", OutEdgeVertexID1)
        ];
        ProcessEvent(GetFunction("GetEdgeVertices"),  @params);
    }
    public FVertexID GetEdgeVertex(FEdgeID EdgeID, int EdgeVertexNumber)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("EdgeVertexNumber", EdgeVertexNumber)
        ];
        return ProcessEvent<FVertexID>(GetFunction("GetEdgeVertex"),  @params);
    }
    public FEdgeID GetEdgeThatConnectsVertices(FVertexID VertexID0, FVertexID VertexID1)
    {
        Span<(string name, object value)> @params = [
            ("VertexID0", VertexID0), 
            ("VertexID1", VertexID1)
        ];
        return ProcessEvent<FEdgeID>(GetFunction("GetEdgeThatConnectsVertices"),  @params);
    }
    public void GetEdgeLoopElements(FEdgeID EdgeID, ref TArray<FEdgeID> EdgeLoopIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("EdgeLoopIDs", EdgeLoopIDs)
        ];
        ProcessEvent(GetFunction("GetEdgeLoopElements"),  @params);
    }
    public int GetEdgeCount()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetEdgeCount"),  @params);
    }
    public void GetEdgeConnectedPolygons(FEdgeID EdgeID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutConnectedPolygonIDs", OutConnectedPolygonIDs)
        ];
        ProcessEvent(GetFunction("GetEdgeConnectedPolygons"),  @params);
    }
    public int GetEdgeConnectedPolygonCount(FEdgeID EdgeID)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID)
        ];
        return ProcessEvent<int>(GetFunction("GetEdgeConnectedPolygonCount"),  @params);
    }
    public FPolygonID GetEdgeConnectedPolygon(FEdgeID EdgeID, int ConnectedPolygonNumber)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("ConnectedPolygonNumber", ConnectedPolygonNumber)
        ];
        return ProcessEvent<FPolygonID>(GetFunction("GetEdgeConnectedPolygon"),  @params);
    }
    public void GeneratePolygonTangentsAndNormals(ref TArray<FPolygonID> PolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs)
        ];
        ProcessEvent(GetFunction("GeneratePolygonTangentsAndNormals"),  @params);
    }
    public void FlipPolygons(ref TArray<FPolygonID> PolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs)
        ];
        ProcessEvent(GetFunction("FlipPolygons"),  @params);
    }
    public int FindPolygonPerimeterVertexNumberForVertex(FPolygonID PolygonID, FVertexID VertexID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("VertexID", VertexID)
        ];
        return ProcessEvent<int>(GetFunction("FindPolygonPerimeterVertexNumberForVertex"),  @params);
    }
    public int FindPolygonPerimeterEdgeNumberForVertices(FPolygonID PolygonID, FVertexID EdgeVertexID0, FVertexID EdgeVertexID1)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("EdgeVertexID0", EdgeVertexID0), 
            ("EdgeVertexID1", EdgeVertexID1)
        ];
        return ProcessEvent<int>(GetFunction("FindPolygonPerimeterEdgeNumberForVertices"),  @params);
    }
    public void FindPolygonLoop(FEdgeID EdgeID, ref TArray<FEdgeID> OutEdgeLoopEdgeIDs, ref TArray<FEdgeID> OutFlippedEdgeIDs, ref TArray<FEdgeID> OutReversedEdgeIDPathToTake, ref TArray<FPolygonID> OutPolygonIDsToSplit)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("OutEdgeLoopEdgeIDs", OutEdgeLoopEdgeIDs), 
            ("OutFlippedEdgeIDs", OutFlippedEdgeIDs), 
            ("OutReversedEdgeIDPathToTake", OutReversedEdgeIDPathToTake), 
            ("OutPolygonIDsToSplit", OutPolygonIDsToSplit)
        ];
        ProcessEvent(GetFunction("FindPolygonLoop"),  @params);
    }
    public void ExtrudePolygons(ref TArray<FPolygonID> Polygons, float ExtrudeDistance, bool bKeepNeighborsTogether, ref TArray<FPolygonID> OutNewExtrudedFrontPolygons)
    {
        Span<(string name, object value)> @params = [
            ("Polygons", Polygons), 
            ("ExtrudeDistance", ExtrudeDistance), 
            ("bKeepNeighborsTogether", bKeepNeighborsTogether), 
            ("OutNewExtrudedFrontPolygons", OutNewExtrudedFrontPolygons)
        ];
        ProcessEvent(GetFunction("ExtrudePolygons"),  @params);
    }
    public void ExtendVertices(ref TArray<FVertexID> VertexIDs, bool bOnlyExtendClosestEdge, FVector ReferencePosition, ref TArray<FVertexID> OutNewExtendedVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexIDs", VertexIDs), 
            ("bOnlyExtendClosestEdge", bOnlyExtendClosestEdge), 
            ("ReferencePosition", ReferencePosition), 
            ("OutNewExtendedVertexIDs", OutNewExtendedVertexIDs)
        ];
        ProcessEvent(GetFunction("ExtendVertices"),  @params);
    }
    public void ExtendEdges(ref TArray<FEdgeID> EdgeIDs, bool bWeldNeighbors, ref TArray<FEdgeID> OutNewExtendedEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIDs", EdgeIDs), 
            ("bWeldNeighbors", bWeldNeighbors), 
            ("OutNewExtendedEdgeIDs", OutNewExtendedEdgeIDs)
        ];
        ProcessEvent(GetFunction("ExtendEdges"),  @params);
    }
    public void EndModification(bool bFromUndo)
    {
        Span<(string name, object value)> @params = [
            ("bFromUndo", bFromUndo)
        ];
        ProcessEvent(GetFunction("EndModification"),  @params);
    }
    public void DeleteVertexInstances(ref TArray<FVertexInstanceID> VertexInstanceIDsToDelete, bool bDeleteOrphanedVertices)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstanceIDsToDelete", VertexInstanceIDsToDelete), 
            ("bDeleteOrphanedVertices", bDeleteOrphanedVertices)
        ];
        ProcessEvent(GetFunction("DeleteVertexInstances"),  @params);
    }
    public void DeleteVertexAndConnectedEdgesAndPolygons(FVertexID VertexID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("VertexID", VertexID), 
            ("bDeleteOrphanedEdges", bDeleteOrphanedEdges), 
            ("bDeleteOrphanedVertices", bDeleteOrphanedVertices), 
            ("bDeleteOrphanedVertexInstances", bDeleteOrphanedVertexInstances), 
            ("bDeleteEmptyPolygonGroups", bDeleteEmptyPolygonGroups)
        ];
        ProcessEvent(GetFunction("DeleteVertexAndConnectedEdgesAndPolygons"),  @params);
    }
    public void DeletePolygons(ref TArray<FPolygonID> PolygonIDsToDelete, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDsToDelete", PolygonIDsToDelete), 
            ("bDeleteOrphanedEdges", bDeleteOrphanedEdges), 
            ("bDeleteOrphanedVertices", bDeleteOrphanedVertices), 
            ("bDeleteOrphanedVertexInstances", bDeleteOrphanedVertexInstances), 
            ("bDeleteEmptyPolygonGroups", bDeleteEmptyPolygonGroups)
        ];
        ProcessEvent(GetFunction("DeletePolygons"),  @params);
    }
    public void DeletePolygonGroups(ref TArray<FPolygonGroupID> PolygonGroupIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupIDs", PolygonGroupIDs)
        ];
        ProcessEvent(GetFunction("DeletePolygonGroups"),  @params);
    }
    public void DeleteOrphanVertices(ref TArray<FVertexID> VertexIDsToDelete)
    {
        Span<(string name, object value)> @params = [
            ("VertexIDsToDelete", VertexIDsToDelete)
        ];
        ProcessEvent(GetFunction("DeleteOrphanVertices"),  @params);
    }
    public void DeleteEdges(ref TArray<FEdgeID> EdgeIDsToDelete, bool bDeleteOrphanedVertices)
    {
        Span<(string name, object value)> @params = [
            ("EdgeIDsToDelete", EdgeIDsToDelete), 
            ("bDeleteOrphanedVertices", bDeleteOrphanedVertices)
        ];
        ProcessEvent(GetFunction("DeleteEdges"),  @params);
    }
    public void DeleteEdgeAndConnectedPolygons(FEdgeID EdgeID, bool bDeleteOrphanedEdges, bool bDeleteOrphanedVertices, bool bDeleteOrphanedVertexInstances, bool bDeleteEmptyPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("EdgeID", EdgeID), 
            ("bDeleteOrphanedEdges", bDeleteOrphanedEdges), 
            ("bDeleteOrphanedVertices", bDeleteOrphanedVertices), 
            ("bDeleteOrphanedVertexInstances", bDeleteOrphanedVertexInstances), 
            ("bDeleteEmptyPolygonGroups", bDeleteEmptyPolygonGroups)
        ];
        ProcessEvent(GetFunction("DeleteEdgeAndConnectedPolygons"),  @params);
    }
    public void CreateVertices(ref TArray<FVertexToCreate> VerticesToCreate, ref TArray<FVertexID> OutNewVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("VerticesToCreate", VerticesToCreate), 
            ("OutNewVertexIDs", OutNewVertexIDs)
        ];
        ProcessEvent(GetFunction("CreateVertices"),  @params);
    }
    public void CreateVertexInstances(ref TArray<FVertexInstanceToCreate> VertexInstancesToCreate, ref TArray<FVertexInstanceID> OutNewVertexInstanceIDs)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstancesToCreate", VertexInstancesToCreate), 
            ("OutNewVertexInstanceIDs", OutNewVertexInstanceIDs)
        ];
        ProcessEvent(GetFunction("CreateVertexInstances"),  @params);
    }
    public void CreatePolygons(ref TArray<FPolygonToCreate> PolygonsToCreate, ref TArray<FPolygonID> OutNewPolygonIDs, ref TArray<FEdgeID> OutNewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonsToCreate", PolygonsToCreate), 
            ("OutNewPolygonIDs", OutNewPolygonIDs), 
            ("OutNewEdgeIDs", OutNewEdgeIDs)
        ];
        ProcessEvent(GetFunction("CreatePolygons"),  @params);
    }
    public void CreatePolygonGroups(ref TArray<FPolygonGroupToCreate> PolygonGroupsToCreate, ref TArray<FPolygonGroupID> OutNewPolygonGroupIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupsToCreate", PolygonGroupsToCreate), 
            ("OutNewPolygonGroupIDs", OutNewPolygonGroupIDs)
        ];
        ProcessEvent(GetFunction("CreatePolygonGroups"),  @params);
    }
    public void CreateMissingPolygonPerimeterEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutNewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID), 
            ("OutNewEdgeIDs", OutNewEdgeIDs)
        ];
        ProcessEvent(GetFunction("CreateMissingPolygonPerimeterEdges"),  @params);
    }
    public void CreateEmptyVertexRange(int NumVerticesToCreate, ref TArray<FVertexID> OutNewVertexIDs)
    {
        Span<(string name, object value)> @params = [
            ("NumVerticesToCreate", NumVerticesToCreate), 
            ("OutNewVertexIDs", OutNewVertexIDs)
        ];
        ProcessEvent(GetFunction("CreateEmptyVertexRange"),  @params);
    }
    public void CreateEdges(ref TArray<FEdgeToCreate> EdgesToCreate, ref TArray<FEdgeID> OutNewEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("EdgesToCreate", EdgesToCreate), 
            ("OutNewEdgeIDs", OutNewEdgeIDs)
        ];
        ProcessEvent(GetFunction("CreateEdges"),  @params);
    }
    public void ComputePolygonsSharedEdges(ref TArray<FPolygonID> PolygonIDs, ref TArray<FEdgeID> OutSharedEdgeIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs), 
            ("OutSharedEdgeIDs", OutSharedEdgeIDs)
        ];
        ProcessEvent(GetFunction("ComputePolygonsSharedEdges"),  @params);
    }
    public FPlane ComputePolygonPlane(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<FPlane>(GetFunction("ComputePolygonPlane"),  @params);
    }
    public FVector ComputePolygonNormal(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<FVector>(GetFunction("ComputePolygonNormal"),  @params);
    }
    public FVector ComputePolygonCenter(FPolygonID PolygonID)
    {
        Span<(string name, object value)> @params = [
            ("PolygonID", PolygonID)
        ];
        return ProcessEvent<FVector>(GetFunction("ComputePolygonCenter"),  @params);
    }
    public FBoxSphereBounds ComputeBoundingBoxAndSphere()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBoxSphereBounds>(GetFunction("ComputeBoundingBoxAndSphere"),  @params);
    }
    public FBox ComputeBoundingBox()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FBox>(GetFunction("ComputeBoundingBox"),  @params);
    }
    public UEditableMesh* CommitInstance(UPrimitiveComponent* ComponentToInstanceTo)
    {
        Span<(string name, object value)> @params = [
            ("ComponentToInstanceTo", (IntPtr)ComponentToInstanceTo)
        ];
        return (UEditableMesh*)ProcessEvent<IntPtr>(GetFunction("CommitInstance"),  @params);
    }
    public void Commit()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("Commit"),  @params);
    }
    public void ChangePolygonsVertexInstances(ref TArray<FChangeVertexInstancesForPolygon> VertexInstancesForPolygons)
    {
        Span<(string name, object value)> @params = [
            ("VertexInstancesForPolygons", VertexInstancesForPolygons)
        ];
        ProcessEvent(GetFunction("ChangePolygonsVertexInstances"),  @params);
    }
    public void BevelPolygons(ref TArray<FPolygonID> PolygonIDs, float BevelFixedDistance, float BevelProgressTowardCenter, ref TArray<FPolygonID> OutNewCenterPolygonIDs, ref TArray<FPolygonID> OutNewSidePolygonIDs)
    {
        Span<(string name, object value)> @params = [
            ("PolygonIDs", PolygonIDs), 
            ("BevelFixedDistance", BevelFixedDistance), 
            ("BevelProgressTowardCenter", BevelProgressTowardCenter), 
            ("OutNewCenterPolygonIDs", OutNewCenterPolygonIDs), 
            ("OutNewSidePolygonIDs", OutNewSidePolygonIDs)
        ];
        ProcessEvent(GetFunction("BevelPolygons"),  @params);
    }
    public void AssignPolygonsToPolygonGroups(ref TArray<FPolygonGroupForPolygon> PolygonGroupForPolygons, bool bDeleteOrphanedPolygonGroups)
    {
        Span<(string name, object value)> @params = [
            ("PolygonGroupForPolygons", PolygonGroupForPolygons), 
            ("bDeleteOrphanedPolygonGroups", bDeleteOrphanedPolygonGroups)
        ];
        ProcessEvent(GetFunction("AssignPolygonsToPolygonGroups"),  @params);
    }
    public bool AnyChangesToUndo()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("AnyChangesToUndo"),  @params);
    }
}

public unsafe class EditableMeshFactory : ObjectBase<UEditableMeshFactory>
{

    public UEditableMesh* MakeEditableMesh(UPrimitiveComponent* PrimitiveComponent, int LODIndex)
    {
        Span<(string name, object value)> @params = [
            ("PrimitiveComponent", (IntPtr)PrimitiveComponent), 
            ("LODIndex", LODIndex)
        ];
        return (UEditableMesh*)ProcessEvent<IntPtr>(GetFunction("MakeEditableMesh"),  @params);
    }
}

public unsafe class EditableStaticMeshAdapter : ObjectBase<UEditableStaticMeshAdapter>
{

}

public unsafe class AdaptorPolygon2Group : ObjectBase<FAdaptorPolygon2Group>
{

}

public unsafe class AdaptorPolygon : ObjectBase<FAdaptorPolygon>
{

}

public unsafe class AdaptorTriangleID : ObjectBase<FAdaptorTriangleID>
{
}

public unsafe class MeshElementAttributeList : ObjectBase<FMeshElementAttributeList>
{

}

public unsafe class MeshElementAttributeData : ObjectBase<FMeshElementAttributeData>
{

}

public unsafe class MeshElementAttributeValue : ObjectBase<FMeshElementAttributeValue>
{
}

public unsafe class VertexInstancesForPolygonHole : ObjectBase<FVertexInstancesForPolygonHole>
{

}

public unsafe class VertexIndexAndInstanceID : ObjectBase<FVertexIndexAndInstanceID>
{

}

public unsafe class VertexAttributesForPolygonHole : ObjectBase<FVertexAttributesForPolygonHole>
{

}

public unsafe class VertexPair : ObjectBase<FVertexPair>
{

}

public unsafe class VertexAndAttributes : ObjectBase<FVertexAndAttributes>
{

}

public unsafe class SubdividedWireEdge : ObjectBase<FSubdividedWireEdge>
{

}

public unsafe class SubdivisionLimitSection : ObjectBase<FSubdivisionLimitSection>
{

}

public unsafe class SubdividedQuad : ObjectBase<FSubdividedQuad>
{

}

public unsafe class SubdividedQuadVertex : ObjectBase<FSubdividedQuadVertex>
{

}

public unsafe class RenderingPolygonGroup : ObjectBase<FRenderingPolygonGroup>
{

}

public unsafe class RenderingPolygon : ObjectBase<FRenderingPolygon>
{

}

