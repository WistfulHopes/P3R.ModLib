using System.Numerics;
using P3R.ModLib.Battle.Enums;
using UE4SSDotNetFramework.Framework;

namespace P3R.ModLib.Battle;

public class BtlActor : ObjectReference
{
    public BtlActor(IntPtr pointer)
        : base(pointer)
    {
        Pointer = pointer;
    }
    
    public BtlActor(ObjectReference? @base)
    {
        if (@base is not null) Pointer = @base.Pointer;
    }

    public BtlAttackType AttackBaseType
    {
        get
        {
            BtlAttackType value = 0;
            GetEnum("AttackBaseType", ref value);
            return value;
        }
        set => SetEnum("AttackBaseType", value);
    }

    public Vector3 HomePosition
    {
        get => GetVector("HomePosition");
        set => SetVector("HomePosition", value);
    }

    public Vector3 HomeRotation
    {
        get => GetVector("HomeRotation");
        set => SetVector("HomeRotation", value);
    }

    public Vector3 Position
    {
        get => GetVector("Position");
        set => SetVector("Position", value);
    }

    public Vector3 Rotation
    {
        get => GetVector("Rotation");
        set => SetVector("Rotation", value);
    }

    public int HomePositionId
    {
        get
        {
            var value = 0;
            GetInt("HomePositionID", ref value);
            return value;
        }
        set => SetInt("HomePositionID", value);
    }

    public int InitialLocationIndexFromLeft
    {
        get
        {
            var value = 0;
            GetInt("InitialLocationIndexFromLeft", ref value);
            return value;
        }
        set => SetInt("InitialLocationIndexFromLeft", value);
    }

    public bool EnemyFlag
    {
        get
        {
            var value = false;
            GetBool("EnemyFlag", ref value);
            return value;
        }
        set => SetBool("EnemyFlag", value);
    }

    public bool PersonaFlag
    {
        get
        {
            var value = false;
            GetBool("PersonaFlag", ref value);
            return value;
        }
        set => SetBool("PersonaFlag", value);
    }

    public bool PersonaHideEmergeEffect
    {
        get
        {
            var value = false;
            GetBool("PersonaHideEmergeEffect", ref value);
            return value;
        }
        set => SetBool("PersonaHideEmergeEffect", value);
    }
}