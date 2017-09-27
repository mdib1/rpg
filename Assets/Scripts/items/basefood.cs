using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class basefood : basestatitem {

    public enum foodTypes
    {
        HEALTH,
        ENERGY,
        STRENGTH,
        INTELLECT,
        STAMINA,
        ENDURANCE,
        SPEED
    }


    private foodTypes foodType;
    private int spellEffectID;

    public foodTypes FoodType
    {
        get { return foodType; }
        set { foodType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
