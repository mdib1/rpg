using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class baseequipment : basestatitem {

    public enum equipmentTypes
    {
        HEAD,
        CHEST,
        LEGS,
        FEET,
        HANDS,
        BELT,
        CAPE,
        RING
    }

    private equipmentTypes equipmentType;
    private int spellEffectID;  

    public equipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
