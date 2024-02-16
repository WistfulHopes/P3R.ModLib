using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class PlayAtomCue_C : ObjectBase<UPlayAtomCue_C>
{

    public FString GetNotifyName()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<FString>(GetFunction("GetNotifyName"),  @params);
    }
    public bool Received_Notify(USkeletalMeshComponent* MeshComp, UAnimSequenceBase* Animation)
    {
        Span<(string name, object value)> @params = [
            ("MeshComp", (IntPtr)MeshComp), 
            ("Animation", (IntPtr)Animation)
        ];
        return ProcessEvent<bool>(GetFunction("Received_Notify"),  @params);
    }
}

