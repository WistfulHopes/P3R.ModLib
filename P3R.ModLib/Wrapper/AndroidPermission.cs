using P3R.ModLib.Native;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Wrapper;

public unsafe class AndroidPermissionCallbackProxy : ObjectBase<UAndroidPermissionCallbackProxy>
{
    public AndroidPermissionCallbackProxy(IntPtr pointer) : base(pointer) {}
}

public unsafe class AndroidPermissionFunctionLibrary : ObjectBase<UAndroidPermissionFunctionLibrary>
{
    public AndroidPermissionFunctionLibrary(IntPtr pointer) : base(pointer) {}
    public bool CheckPermission(FString permission)
    {
        Span<(string name, object value)> @params = [
            ("permission", permission)
        ];
        return ProcessEvent<bool>(GetFunction("CheckPermission"), @params);
    }
    public UAndroidPermissionCallbackProxy* AcquirePermissions(ref TArray<FString> Permissions)
    {
        Span<(string name, object value)> @params = [
            ("Permissions", Permissions)
        ];
        return (UAndroidPermissionCallbackProxy*)ProcessEvent<IntPtr>(GetFunction("AcquirePermissions"), @params);
    }
}

