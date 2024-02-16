using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSolverCollisionFilterSettings
{
    [FieldOffset(0x0000)] public bool FilterEnabled;
    [FieldOffset(0x0004)] public float MinMass;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinImpulse;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSolverBreakingFilterSettings
{
    [FieldOffset(0x0000)] public bool FilterEnabled;
    [FieldOffset(0x0004)] public float MinMass;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FSolverTrailingFilterSettings
{
    [FieldOffset(0x0000)] public bool FilterEnabled;
    [FieldOffset(0x0004)] public float MinMass;
    [FieldOffset(0x0008)] public float MinSpeed;
    [FieldOffset(0x000C)] public float MinVolume;
}

[StructLayout(LayoutKind.Explicit, Size = 0x68)] 
public unsafe struct FChaosSolverConfiguration
{
    [FieldOffset(0x0000)] public int Iterations;
    [FieldOffset(0x0004)] public int CollisionPairIterations;
    [FieldOffset(0x0008)] public int PushOutIterations;
    [FieldOffset(0x000C)] public int CollisionPushOutPairIterations;
    [FieldOffset(0x0010)] public float CollisionMarginFraction;
    [FieldOffset(0x0014)] public float CollisionMarginMax;
    [FieldOffset(0x0018)] public float CollisionCullDistance;
    [FieldOffset(0x001C)] public int JointPairIterations;
    [FieldOffset(0x0020)] public int JointPushOutPairIterations;
    [FieldOffset(0x0024)] public float ClusterConnectionFactor;
    [FieldOffset(0x0028)] public EClusterUnionMethod ClusterUnionConnectionType;
    [FieldOffset(0x0029)] public bool bGenerateCollisionData;
    [FieldOffset(0x002C)] public FSolverCollisionFilterSettings CollisionFilterSettings;
    [FieldOffset(0x003C)] public bool bGenerateBreakData;
    [FieldOffset(0x0040)] public FSolverBreakingFilterSettings BreakingFilterSettings;
    [FieldOffset(0x0050)] public bool bGenerateTrailingData;
    [FieldOffset(0x0054)] public FSolverTrailingFilterSettings TrailingFilterSettings;
    [FieldOffset(0x0064)] public bool bGenerateContactGraph;
}

[StructLayout(LayoutKind.Explicit, Size = 0x6C)] 
public unsafe struct FSolverCollisionData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector AccumulatedImpulse;
    [FieldOffset(0x0018)] public FVector Normal;
    [FieldOffset(0x0024)] public FVector Velocity1;
    [FieldOffset(0x0030)] public FVector Velocity2;
    [FieldOffset(0x003C)] public FVector AngularVelocity1;
    [FieldOffset(0x0048)] public FVector AngularVelocity2;
    [FieldOffset(0x0054)] public float Mass1;
    [FieldOffset(0x0058)] public float Mass2;
    [FieldOffset(0x005C)] public int ParticleIndex;
    [FieldOffset(0x0060)] public int LevelsetIndex;
    [FieldOffset(0x0064)] public int ParticleIndexMesh;
    [FieldOffset(0x0068)] public int LevelsetIndexMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSolverBreakingData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Velocity;
    [FieldOffset(0x0018)] public FVector AngularVelocity;
    [FieldOffset(0x0024)] public float Mass;
    [FieldOffset(0x0028)] public int ParticleIndex;
    [FieldOffset(0x002C)] public int ParticleIndexMesh;
}

[StructLayout(LayoutKind.Explicit, Size = 0xB8)] 
public unsafe struct FRecordedFrame
{
    [FieldOffset(0x0000)] public TArray<FTransform> Transforms;
    [FieldOffset(0x0010)] public TArray<int> TransformIndices;
    [FieldOffset(0x0020)] public TArray<int> PreviousTransformIndices;
    [FieldOffset(0x0030)] public TArray<bool> DisabledFlags;
    [FieldOffset(0x0040)] public TArray<FSolverCollisionData> Collisions;
    [FieldOffset(0x0050)] public TArray<FSolverBreakingData> Breakings;
    [FieldOffset(0x0060)] public TSet<FSolverTrailingData> Trailings;
    [FieldOffset(0x00B0)] public float Timestamp;
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FRecordedTransformTrack
{
    [FieldOffset(0x0000)] public TArray<FRecordedFrame> Records;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FSolverTrailingData
{
    [FieldOffset(0x0000)] public FVector Location;
    [FieldOffset(0x000C)] public FVector Velocity;
    [FieldOffset(0x0018)] public FVector AngularVelocity;
    [FieldOffset(0x0024)] public float Mass;
    [FieldOffset(0x0028)] public int ParticleIndex;
    [FieldOffset(0x002C)] public int ParticleIndexMesh;
}

