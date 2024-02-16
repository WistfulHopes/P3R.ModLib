using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEditableMeshAdapter
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD8)] 
public unsafe struct UEditableGeometryCollectionAdapter
{
    [FieldOffset(0x0000)] public UEditableMeshAdapter baseObj;
    [FieldOffset(0x0028)] public UGeometryCollection* GeometryCollection;
    [FieldOffset(0x0030)] public UGeometryCollection* OriginalGeometryCollection;
    [FieldOffset(0x0038)] public int GeometryCollectionLODIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVertexPair
{
    [FieldOffset(0x0000)] public FVertexID VertexID0;
    [FieldOffset(0x0004)] public FVertexID VertexID1;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPolygonToSplit
{
    [FieldOffset(0x0000)] public FPolygonID PolygonID;
    [FieldOffset(0x0008)] public TArray<FVertexPair> VertexPairsToSplitAt;
}

[StructLayout(LayoutKind.Explicit, Size = 0x50)] 
public unsafe struct FMeshElementAttributeValue
{
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct FMeshElementAttributeData
{
    [FieldOffset(0x0000)] public FName AttributeName;
    [FieldOffset(0x0008)] public int AttributeIndex;
    [FieldOffset(0x0010)] public FMeshElementAttributeValue AttributeValue;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FMeshElementAttributeList
{
    [FieldOffset(0x0000)] public TArray<FMeshElementAttributeData> Attributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAttributesForVertex
{
    [FieldOffset(0x0000)] public FVertexID VertexID;
    [FieldOffset(0x0008)] public FMeshElementAttributeList VertexAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAttributesForVertexInstance
{
    [FieldOffset(0x0000)] public FVertexInstanceID VertexInstanceID;
    [FieldOffset(0x0008)] public FMeshElementAttributeList VertexInstanceAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVertexAttributesForPolygonHole
{
    [FieldOffset(0x0000)] public TArray<FMeshElementAttributeList> VertexAttributeList;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FVertexAttributesForPolygon
{
    [FieldOffset(0x0000)] public FPolygonID PolygonID;
    [FieldOffset(0x0008)] public TArray<FMeshElementAttributeList> PerimeterVertexAttributeLists;
    [FieldOffset(0x0018)] public TArray<FVertexAttributesForPolygonHole> VertexAttributeListsForEachHole;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAttributesForEdge
{
    [FieldOffset(0x0000)] public FEdgeID EdgeID;
    [FieldOffset(0x0008)] public FMeshElementAttributeList EdgeAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVertexToMove
{
    [FieldOffset(0x0000)] public FVertexID VertexID;
    [FieldOffset(0x0004)] public FVector NewVertexPosition;
}

[StructLayout(LayoutKind.Explicit, Size = 0x34)] 
public unsafe struct FSubdividedQuadVertex
{
    [FieldOffset(0x0000)] public int VertexPositionIndex;
    [FieldOffset(0x0004)] public FVector2D TextureCoordinate0;
    [FieldOffset(0x000C)] public FVector2D TextureCoordinate1;
    [FieldOffset(0x0014)] public FColor VertexColor;
    [FieldOffset(0x0018)] public FVector VertexNormal;
    [FieldOffset(0x0024)] public FVector VertexTangent;
    [FieldOffset(0x0030)] public float VertexBinormalSign;
}

[StructLayout(LayoutKind.Explicit, Size = 0xD0)] 
public unsafe struct FSubdividedQuad
{
    [FieldOffset(0x0000)] public FSubdividedQuadVertex QuadVertex0;
    [FieldOffset(0x0034)] public FSubdividedQuadVertex QuadVertex1;
    [FieldOffset(0x0068)] public FSubdividedQuadVertex QuadVertex2;
    [FieldOffset(0x009C)] public FSubdividedQuadVertex QuadVertex3;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSubdivisionLimitSection
{
    [FieldOffset(0x0000)] public TArray<FSubdividedQuad> SubdividedQuads;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)] 
public unsafe struct FSubdividedWireEdge
{
    [FieldOffset(0x0000)] public int EdgeVertex0PositionIndex;
    [FieldOffset(0x0004)] public int EdgeVertex1PositionIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSubdivisionLimitData
{
    [FieldOffset(0x0000)] public TArray<FVector> VertexPositions;
    [FieldOffset(0x0010)] public TArray<FSubdivisionLimitSection> Sections;
    [FieldOffset(0x0020)] public TArray<FSubdividedWireEdge> SubdividedWireEdges;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FVertexToCreate
{
    [FieldOffset(0x0000)] public FMeshElementAttributeList VertexAttributes;
    [FieldOffset(0x0010)] public FVertexID OriginalVertexID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FVertexInstanceToCreate
{
    [FieldOffset(0x0000)] public FVertexID VertexID;
    [FieldOffset(0x0008)] public FMeshElementAttributeList VertexInstanceAttributes;
    [FieldOffset(0x0018)] public FVertexInstanceID OriginalVertexInstanceID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FVertexAndAttributes
{
    [FieldOffset(0x0000)] public FVertexInstanceID VertexInstanceID;
    [FieldOffset(0x0004)] public FVertexID VertexID;
    [FieldOffset(0x0008)] public FMeshElementAttributeList PolygonVertexAttributes;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FPolygonToCreate
{
    [FieldOffset(0x0000)] public FPolygonGroupID PolygonGroupID;
    [FieldOffset(0x0008)] public TArray<FVertexAndAttributes> PerimeterVertices;
    [FieldOffset(0x0018)] public FPolygonID OriginalPolygonID;
    [FieldOffset(0x001C)] public EPolygonEdgeHardness PolygonEdgeHardness;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FPolygonGroupToCreate
{
    [FieldOffset(0x0000)] public FMeshElementAttributeList PolygonGroupAttributes;
    [FieldOffset(0x0010)] public FPolygonGroupID OriginalPolygonGroupID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FEdgeToCreate
{
    [FieldOffset(0x0000)] public FVertexID VertexID0;
    [FieldOffset(0x0004)] public FVertexID VertexID1;
    [FieldOffset(0x0008)] public FMeshElementAttributeList EdgeAttributes;
    [FieldOffset(0x0018)] public FEdgeID OriginalEdgeID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FVertexIndexAndInstanceID
{
    [FieldOffset(0x0000)] public int ContourIndex;
    [FieldOffset(0x0004)] public FVertexInstanceID VertexInstanceID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FVertexInstancesForPolygonHole
{
    [FieldOffset(0x0000)] public TArray<FVertexIndexAndInstanceID> VertexIndicesAndInstanceIDs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct FChangeVertexInstancesForPolygon
{
    [FieldOffset(0x0000)] public FPolygonID PolygonID;
    [FieldOffset(0x0008)] public TArray<FVertexIndexAndInstanceID> PerimeterVertexIndicesAndInstanceIDs;
    [FieldOffset(0x0018)] public TArray<FVertexInstancesForPolygonHole> VertexIndicesAndInstanceIDsForEachHole;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPolygonGroupForPolygon
{
    [FieldOffset(0x0000)] public FPolygonID PolygonID;
    [FieldOffset(0x0004)] public FPolygonGroupID PolygonGroupID;
}

[StructLayout(LayoutKind.Explicit, Size = 0x708)] 
public unsafe struct UEditableMesh
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x03B8)] public TArray<IntPtr> Adapters;
    [FieldOffset(0x03D0)] public int TextureCoordinateCount;
    [FieldOffset(0x051C)] public int PendingCompactCounter;
    [FieldOffset(0x0520)] public int SubdivisionCount;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct UEditableMeshFactory
{
    [FieldOffset(0x0000)] public UObject baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0xE0)] 
public unsafe struct UEditableStaticMeshAdapter
{
    [FieldOffset(0x0000)] public UEditableMeshAdapter baseObj;
    [FieldOffset(0x0028)] public UStaticMesh* StaticMesh;
    [FieldOffset(0x0030)] public UStaticMesh* OriginalStaticMesh;
    [FieldOffset(0x0038)] public int StaticMeshLODIndex;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FAdaptorPolygon2Group
{
    [FieldOffset(0x0000)] public uint RenderingSectionIndex;
    [FieldOffset(0x0004)] public int MaterialIndex;
    [FieldOffset(0x0008)] public int MaxTriangles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x4)] 
public unsafe struct FAdaptorTriangleID
{
    [FieldOffset(0x0000)] public FElementID baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FAdaptorPolygon
{
    [FieldOffset(0x0000)] public FPolygonGroupID PolygonGroupID;
    [FieldOffset(0x0008)] public TArray<FAdaptorTriangleID> TriangulatedPolygonTriangleIndices;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct FRenderingPolygonGroup
{
    [FieldOffset(0x0000)] public uint RenderingSectionIndex;
    [FieldOffset(0x0004)] public int MaterialIndex;
    [FieldOffset(0x0008)] public int MaxTriangles;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FRenderingPolygon
{
    [FieldOffset(0x0000)] public FPolygonGroupID PolygonGroupID;
    [FieldOffset(0x0008)] public TArray<FTriangleID> TriangulatedPolygonTriangleIndices;
}

