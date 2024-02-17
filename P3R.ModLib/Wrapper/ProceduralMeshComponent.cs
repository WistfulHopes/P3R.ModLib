using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class KismetProceduralMeshLibrary : ObjectBase<UKismetProceduralMeshLibrary>
{
    public KismetProceduralMeshLibrary(IntPtr pointer) : base(pointer) {}
    public void SliceProceduralMesh(UProceduralMeshComponent* InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, ref UProceduralMeshComponent* OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, UMaterialInterface* CapMaterial)
    {
        Span<(string name, object value)> @params = [
            ("InProcMesh", (IntPtr)InProcMesh), 
            ("PlanePosition", PlanePosition), 
            ("PlaneNormal", PlaneNormal), 
            ("bCreateOtherHalf", bCreateOtherHalf), 
            ("OutOtherHalfProcMesh", (IntPtr)OutOtherHalfProcMesh), 
            ("CapOption", CapOption), 
            ("CapMaterial", (IntPtr)CapMaterial)
        ];
        ProcessEvent(GetFunction("SliceProceduralMesh"), @params);
    }
    public void GetSectionFromStaticMesh(UStaticMesh* InMesh, int LODIndex, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("InMesh", (IntPtr)InMesh), 
            ("LODIndex", LODIndex), 
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("UVs", UVs), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("GetSectionFromStaticMesh"), @params);
    }
    public void GetSectionFromProceduralMesh(UProceduralMeshComponent* InProcMesh, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("InProcMesh", (IntPtr)InProcMesh), 
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("UVs", UVs), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("GetSectionFromProceduralMesh"), @params);
    }
    public void GenerateBoxMesh(FVector BoxRadius, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("BoxRadius", BoxRadius), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("UVs", UVs), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("GenerateBoxMesh"), @params);
    }
    public void CreateGridMeshWelded(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, float GridSpacing)
    {
        Span<(string name, object value)> @params = [
            ("NumX", NumX), 
            ("NumY", NumY), 
            ("Triangles", Triangles), 
            ("Vertices", Vertices), 
            ("UVs", UVs), 
            ("GridSpacing", GridSpacing)
        ];
        ProcessEvent(GetFunction("CreateGridMeshWelded"), @params);
    }
    public void CreateGridMeshTriangles(int NumX, int NumY, bool bWinding, ref TArray<int> Triangles)
    {
        Span<(string name, object value)> @params = [
            ("NumX", NumX), 
            ("NumY", NumY), 
            ("bWinding", bWinding), 
            ("Triangles", Triangles)
        ];
        ProcessEvent(GetFunction("CreateGridMeshTriangles"), @params);
    }
    public void CreateGridMeshSplit(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, ref TArray<FVector2D> UV1s, float GridSpacing)
    {
        Span<(string name, object value)> @params = [
            ("NumX", NumX), 
            ("NumY", NumY), 
            ("Triangles", Triangles), 
            ("Vertices", Vertices), 
            ("UVs", UVs), 
            ("UV1s", UV1s), 
            ("GridSpacing", GridSpacing)
        ];
        ProcessEvent(GetFunction("CreateGridMeshSplit"), @params);
    }
    public void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent* StaticMeshComponent, int LODIndex, UProceduralMeshComponent* ProcMeshComponent, bool bCreateCollision)
    {
        Span<(string name, object value)> @params = [
            ("StaticMeshComponent", (IntPtr)StaticMeshComponent), 
            ("LODIndex", LODIndex), 
            ("ProcMeshComponent", (IntPtr)ProcMeshComponent), 
            ("bCreateCollision", bCreateCollision)
        ];
        ProcessEvent(GetFunction("CopyProceduralMeshFromStaticMeshComponent"), @params);
    }
    public void ConvertQuadToTriangles(ref TArray<int> Triangles, int Vert0, int Vert1, int Vert2, int Vert3)
    {
        Span<(string name, object value)> @params = [
            ("Triangles", Triangles), 
            ("Vert0", Vert0), 
            ("Vert1", Vert1), 
            ("Vert2", Vert2), 
            ("Vert3", Vert3)
        ];
        ProcessEvent(GetFunction("ConvertQuadToTriangles"), @params);
    }
    public void CalculateTangentsForMesh(ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector2D> UVs, ref TArray<FVector> Normals, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("UVs", UVs), 
            ("Normals", Normals), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("CalculateTangentsForMesh"), @params);
    }
}

public unsafe class ProceduralMeshComponent : ObjectBase<UProceduralMeshComponent>
{
    public ProceduralMeshComponent(IntPtr pointer) : base(pointer) {}
    public void UpdateMeshSection_LinearColor(int SectionIndex, ref TArray<FVector> Vertices, ref TArray<FVector> Normals, ref TArray<FVector2D> UV0, ref TArray<FVector2D> UV1, ref TArray<FVector2D> UV2, ref TArray<FVector2D> UV3, ref TArray<FLinearColor> VertexColors, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Normals", Normals), 
            ("UV0", UV0), 
            ("UV1", UV1), 
            ("UV2", UV2), 
            ("UV3", UV3), 
            ("VertexColors", VertexColors), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("UpdateMeshSection_LinearColor"), @params);
    }
    public void UpdateMeshSection(int SectionIndex, ref TArray<FVector> Vertices, ref TArray<FVector> Normals, ref TArray<FVector2D> UV0, ref TArray<FColor> VertexColors, ref TArray<FProcMeshTangent> Tangents)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Normals", Normals), 
            ("UV0", UV0), 
            ("VertexColors", VertexColors), 
            ("Tangents", Tangents)
        ];
        ProcessEvent(GetFunction("UpdateMeshSection"), @params);
    }
    public void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex), 
            ("bNewVisibility", bNewVisibility)
        ];
        ProcessEvent(GetFunction("SetMeshSectionVisible"), @params);
    }
    public bool IsMeshSectionVisible(int SectionIndex)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex)
        ];
        return ProcessEvent<bool>(GetFunction("IsMeshSectionVisible"), @params);
    }
    public int GetNumSections()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<int>(GetFunction("GetNumSections"), @params);
    }
    public void CreateMeshSection_LinearColor(int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UV0, ref TArray<FVector2D> UV1, ref TArray<FVector2D> UV2, ref TArray<FVector2D> UV3, ref TArray<FLinearColor> VertexColors, ref TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("UV0", UV0), 
            ("UV1", UV1), 
            ("UV2", UV2), 
            ("UV3", UV3), 
            ("VertexColors", VertexColors), 
            ("Tangents", Tangents), 
            ("bCreateCollision", bCreateCollision)
        ];
        ProcessEvent(GetFunction("CreateMeshSection_LinearColor"), @params);
    }
    public void CreateMeshSection(int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UV0, ref TArray<FColor> VertexColors, ref TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex), 
            ("Vertices", Vertices), 
            ("Triangles", Triangles), 
            ("Normals", Normals), 
            ("UV0", UV0), 
            ("VertexColors", VertexColors), 
            ("Tangents", Tangents), 
            ("bCreateCollision", bCreateCollision)
        ];
        ProcessEvent(GetFunction("CreateMeshSection"), @params);
    }
    public void ClearMeshSection(int SectionIndex)
    {
        Span<(string name, object value)> @params = [
            ("SectionIndex", SectionIndex)
        ];
        ProcessEvent(GetFunction("ClearMeshSection"), @params);
    }
    public void ClearCollisionConvexMeshes()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearCollisionConvexMeshes"), @params);
    }
    public void ClearAllMeshSections()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("ClearAllMeshSections"), @params);
    }
    public void AddCollisionConvexMesh(TArray<FVector> ConvexVerts)
    {
        Span<(string name, object value)> @params = [
            ("ConvexVerts", ConvexVerts)
        ];
        ProcessEvent(GetFunction("AddCollisionConvexMesh"), @params);
    }
}

