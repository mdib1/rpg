using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class baseweapon : basestatitem {

    public enum weaponTypes
    {
        BLUNT,
        EDGE,
        PROJECTILE,
        MAGIC
    }

    private weaponTypes weaponType;
    private int spellEffectID;

    public weaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
