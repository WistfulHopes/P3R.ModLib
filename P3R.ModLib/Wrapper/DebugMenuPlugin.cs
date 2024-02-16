using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class DebugMenuBase : ObjectBase<UDebugMenuBase>
{
}

public unsafe class DebugMenuBPI_Actor : ObjectBase<ADebugMenuBPI_Actor>
{

}

public unsafe class DebugMenuItem : ObjectBase<FDebugMenuItem>
{
}

public unsafe class DebugMenuBPI : ObjectBase<UDebugMenuBPI>
{

    public bool Exit()
    {
        Span<(string name, object value)> @params = [
        ];
        return ProcessEvent<bool>(GetFunction("Exit"),  @params);
    }
    public bool CreateCaption(FString CaptionName, ref FDebugMenuItem OutMenuItem)
    {
        Span<(string name, object value)> @params = [
            ("CaptionName", CaptionName), 
            ("OutMenuItem", OutMenuItem)
        ];
        return ProcessEvent<bool>(GetFunction("CreateCaption"),  @params);
    }
    public bool Create(UObject* WorldContextObject, UClass* InClass, float X, float Y)
    {
        Span<(string name, object value)> @params = [
            ("WorldContextObject", (IntPtr)WorldContextObject), 
            ("InClass", (IntPtr)InClass), 
            ("X", X), 
            ("Y", Y)
        ];
        return ProcessEvent<bool>(GetFunction("Create"),  @params);
    }
}

public unsafe class DebugMenuEventData : ObjectBase<FDebugMenuEventData>
{
}

