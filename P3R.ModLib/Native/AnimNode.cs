using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x20)] 
public unsafe struct FAnimNode_TEST
{
    [FieldOffset(0x0000)] public FAnimNode_Base baseObj;
    [FieldOffset(0x0010)] public FPoseLink SourcePose;
}

