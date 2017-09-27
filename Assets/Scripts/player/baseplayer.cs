using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseplayer {

    private string playerName;
    private int playerLevel;

    private int stamina;
    private int strength;
    private int intellect;
    private int endurance;
    private int fame;
    private int speed;
    private int currentXP;
    private int requiredXP;

    public string PlayerName { get; set; }
    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

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
