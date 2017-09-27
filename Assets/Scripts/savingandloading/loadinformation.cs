using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadinformation : MonoBehaviour
{

    public static void LoadAllInformation()
    {
        gameinformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        gameinformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        gameinformation.Stamina = PlayerPrefs.GetInt("PLAYERSTAMINA");
        gameinformation.Endurance = PlayerPrefs.GetInt("PLAYERENDURANCE");
        gameinformation.Intellect = PlayerPrefs.GetInt("PLAYERINTELLECT");
        gameinformation.Strength = PlayerPrefs.GetInt("PLAYERSTRENGTH");
        gameinformation.Speed = PlayerPrefs.GetInt("PLAYERSPEED");
        gameinformation.Fame = PlayerPrefs.GetInt("PLAYERFAME");

        if (PlayerPrefs.GetString("EQUIPMENT1") != null)
        {
            gameinformation.EquipmentOne = (baseequipment) ppserialization.Load("EQUIPMENTITEM1");
        }

        Debug.Log("loaded all info");
    }
}
