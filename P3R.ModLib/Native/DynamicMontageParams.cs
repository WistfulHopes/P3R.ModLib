using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FDynamicMontageParams
{
    [FieldOffset(0x0000)] public UAnimSequenceBase* Animation_2_5E5C122A46BA0311400556A423FC05D0;
    [FieldOffset(0x0008)] public float BlendInTime_10_1C5E8446412E51FFA0B03AB8BD32E6E8;
    [FieldOffset(0x000C)] public float BlendOutTime_12_79DFD9804491A7DF0813EFA923002F9C;
    [FieldOffset(0x0010)] public float PlayRate_5_4724216C43D83EADF735F0AFEE9947EB;
    [FieldOffset(0x0014)] public float StartTime_7_3C5D7A3849D194E10AB51CA0344EBC8D;
}

