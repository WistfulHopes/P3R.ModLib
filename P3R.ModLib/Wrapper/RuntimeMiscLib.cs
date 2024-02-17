using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class ML_MontageUtility : ObjectBase<UML_MontageUtility>
{
    public ML_MontageUtility(IntPtr pointer) : base(pointer) {}
    public void SetBlendOut(UAnimMontage* AnimMontage, float Time)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("SetBlendOut"), @params);
    }
    public bool SetBlendInOutAutoWithParam(USkeletalMeshComponent* SkeletalMeshComp, UAnimMontage* AnimMontage, FName SectionName, float DecreaseBlendTime)
    {
        Span<(string name, object value)> @params = [
            ("SkeletalMeshComp", (IntPtr)SkeletalMeshComp), 
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName), 
            ("DecreaseBlendTime", DecreaseBlendTime)
        ];
        return ProcessEvent<bool>(GetFunction("SetBlendInOutAutoWithParam"), @params);
    }
    public bool SetBlendInAuto(USkeletalMeshComponent* SkeletalMeshComp, UAnimMontage* AnimMontage, FName SectionName)
    {
        Span<(string name, object value)> @params = [
            ("SkeletalMeshComp", (IntPtr)SkeletalMeshComp), 
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName)
        ];
        return ProcessEvent<bool>(GetFunction("SetBlendInAuto"), @params);
    }
    public void SetBlendIn(UAnimMontage* AnimMontage, float Time)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("Time", Time)
        ];
        ProcessEvent(GetFunction("SetBlendIn"), @params);
    }
    public FName GetNextSectionName(UAnimMontage* AnimMontage, FName SectionName, ref bool Success)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SectionName", SectionName), 
            ("Success", Success)
        ];
        return ProcessEvent<FName>(GetFunction("GetNextSectionName"), @params);
    }
    public float GetBlendOut(UAnimMontage* AnimMontage)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage)
        ];
        return ProcessEvent<float>(GetFunction("GetBlendOut"), @params);
    }
    public float GetBlendIn(UAnimMontage* AnimMontage)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage)
        ];
        return ProcessEvent<float>(GetFunction("GetBlendIn"), @params);
    }
    public bool GetAnimationSequence(UAnimMontage* AnimMontage, FName SlotName, FName SectionName, ref UAnimSequenceBase* AnimSequence)
    {
        Span<(string name, object value)> @params = [
            ("AnimMontage", (IntPtr)AnimMontage), 
            ("SlotName", SlotName), 
            ("SectionName", SectionName), 
            ("AnimSequence", (IntPtr)AnimSequence)
        ];
        return ProcessEvent<bool>(GetFunction("GetAnimationSequence"), @params);
    }
}

public unsafe class ML_SplineActor : ObjectBase<AML_SplineActor>
{
    public ML_SplineActor(IntPtr pointer) : base(pointer) {}
    public void SetMarkerVisibility(bool Visibility)
    {
        Span<(string name, object value)> @params = [
            ("Visibility", Visibility)
        ];
        ProcessEvent(GetFunction("SetMarkerVisibility"), @params);
    }
    public void SetMarkerPosition(int Index, FVector Position)
    {
        Span<(string name, object value)> @params = [
            ("Index", Index), 
            ("Position", Position)
        ];
        ProcessEvent(GetFunction("SetMarkerPosition"), @params);
    }
}

public unsafe class ML_SplineComponent : ObjectBase<UML_SplineComponent>
{
    public ML_SplineComponent(IntPtr pointer) : base(pointer) {}}

public unsafe class ML_TargetMarkerComponent : ObjectBase<UML_TargetMarkerComponent>
{
    public ML_TargetMarkerComponent(IntPtr pointer) : base(pointer) {}}

