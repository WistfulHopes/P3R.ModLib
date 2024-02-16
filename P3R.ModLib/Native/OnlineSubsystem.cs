using System.Runtime.InteropServices;

namespace P3R.ModLib.Native;

[StructLayout(LayoutKind.Explicit, Size = 0x10)] 
public unsafe struct FNamedInterface
{
    [FieldOffset(0x0000)] public FName InterfaceName;
    [FieldOffset(0x0008)] public UObject* InterfaceObject;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FNamedInterfaceDef
{
    [FieldOffset(0x0000)] public FName InterfaceName;
    [FieldOffset(0x0008)] public FString InterfaceClassName;
}

[StructLayout(LayoutKind.Explicit, Size = 0x60)] 
public unsafe struct UNamedInterfaces
{
    [FieldOffset(0x0000)] public UObject baseObj;
    [FieldOffset(0x0028)] public TArray<FNamedInterface> NamedInterfaces;
    [FieldOffset(0x0038)] public TArray<FNamedInterfaceDef> NamedInterfaceDefs;
}

[StructLayout(LayoutKind.Explicit, Size = 0x28)] 
public unsafe struct ITurnBasedMatchInterface
{
    [FieldOffset(0x0000)] public IInterface baseObj;
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)] 
public unsafe struct FInAppPurchaseProductRequest
{
    [FieldOffset(0x0000)] public FString ProductIdentifier;
    [FieldOffset(0x0010)] public bool bIsConsumable;
}

[StructLayout(LayoutKind.Explicit, Size = 0xA8)] 
public unsafe struct FInAppPurchaseProductInfo
{
    [FieldOffset(0x0000)] public FString Identifier;
    [FieldOffset(0x0010)] public FString TransactionIdentifier;
    [FieldOffset(0x0020)] public FString DisplayName;
    [FieldOffset(0x0030)] public FString DisplayDescription;
    [FieldOffset(0x0040)] public FString DisplayPrice;
    [FieldOffset(0x0050)] public float RawPrice;
    [FieldOffset(0x0058)] public FString CurrencyCode;
    [FieldOffset(0x0068)] public FString CurrencySymbol;
    [FieldOffset(0x0078)] public FString DecimalSeparator;
    [FieldOffset(0x0088)] public FString GroupingSeparator;
    [FieldOffset(0x0098)] public FString ReceiptData;
}

[StructLayout(LayoutKind.Explicit, Size = 0x30)] 
public unsafe struct FInAppPurchaseRestoreInfo
{
    [FieldOffset(0x0000)] public FString Identifier;
    [FieldOffset(0x0010)] public FString ReceiptData;
    [FieldOffset(0x0020)] public FString TransactionIdentifier;
}

