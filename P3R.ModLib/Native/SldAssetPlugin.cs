using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSprLayoutEditResources
{
    [FieldOffset(0x0000)] public ESLDResTypes Type;
    [FieldOffset(0x0008)] public UObject* Resources;
}

[StructLayout(LayoutKind.Explicit, Size = 0x8)] 
public unsafe struct FPVectore
{
    [FieldOffset(0x0000)] public float X;
    [FieldOffset(0x0004)] public float Y;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FDrawebleUVPos
{
    [FieldOffset(0x0000)] public float U0;
    [FieldOffset(0x0004)] public float U1;
    [FieldOffset(0x0008)] public float V0;
    [FieldOffset(0x000C)] public float v1;
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FDrawebleVertexPos
{
    [FieldOffset(0x0000)] public FPVectore V00;
    [FieldOffset(0x0008)] public FPVectore V01;
    [FieldOffset(0x0010)] public FPVectore V10;
    [FieldOffset(0x0018)] public FPVectore V11;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB0)] 
public unsafe struct FSprLayoutDrawItem
{
    [FieldOffset(0x0000)] public uint _uniqueID;
    [FieldOffset(0x0010)] public FMatrix _transform;
    [FieldOffset(0x0050)] public FLinearColor _color;
    [FieldOffset(0x0060)] public FPVectore _imageSize;
    [FieldOffset(0x0068)] public FDrawebleUVPos _uv;
    [FieldOffset(0x0078)] public FDrawebleVertexPos _vertexPos;
    [FieldOffset(0x0098)] public UTexture* _texture;
    [FieldOffset(0x00A0)] public FVector2D _offset;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSprLayoutEditGroup
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public TArray<FSprLayoutDrawItem> DrawItems;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FSprLayoutEditScene
{
    [FieldOffset(0x0000)] public FName Name;
    [FieldOffset(0x0008)] public TArray<FSprLayoutEditGroup> Groups;
}

[StructLayout(LayoutKind.Explicit, Size = 0x48)] 
public unsafe struct USldAsset
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FSprLayoutEditResources> TargetResources;
    [FieldOffset(0x0038)] public TArray<FSprLayoutEditScene> SceneDatas;
}

