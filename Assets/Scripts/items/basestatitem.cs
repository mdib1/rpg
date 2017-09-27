using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class basestatitem : baseitem {

    private int stamina;
    private int strength;
    private int intellect;
    private int endurance;
    private int speed;
    private int fame;

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Fame
    {
        get { return fame; }
        set { fame = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

}
