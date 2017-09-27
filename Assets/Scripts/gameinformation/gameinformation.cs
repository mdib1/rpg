using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class gameinformation : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static baseequipment EquipmentOne { get; set; }
    public static string PlayerName { get; set;}
    public static int PlayerLevel { get; set; }
    public static int Stamina { get; set; }
    public static int Endurance { get; set; }
    public static int Strength { get; set; }
    public static int Speed { get; set; }
    public static int Fame { get; set; }
    public static int Intellect { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
}
