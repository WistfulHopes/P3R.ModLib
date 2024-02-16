using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AutomationUtilsBlueprintLibrary : ObjectBase<UAutomationUtilsBlueprintLibrary>
{

    public void TakeGameplayAutomationScreenshot(FString ScreenshotName, float MaxGlobalError, float MaxLocalError, FString MapNameOverride)
    {
        Span<(string name, object value)> @params = [
            ("ScreenshotName", ScreenshotName), 
            ("MaxGlobalError", MaxGlobalError), 
            ("MaxLocalError", MaxLocalError), 
            ("MapNameOverride", MapNameOverride)
        ];
        ProcessEvent(GetFunction("TakeGameplayAutomationScreenshot"),  @params);
    }
}

