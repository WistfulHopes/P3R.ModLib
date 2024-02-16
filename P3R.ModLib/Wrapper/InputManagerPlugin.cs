using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class InputManager : ObjectBase<AInputManager>
{

    public void EnableInputManager()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("EnableInputManager"),  @params);
    }
    public void DisableInputManager()
    {
        Span<(string name, object value)> @params = [
        ];
        ProcessEvent(GetFunction("DisableInputManager"),  @params);
    }
}

