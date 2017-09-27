using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveinformation : MonoBehaviour {

public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", gameinformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", gameinformation.PlayerName);
        PlayerPrefs.SetInt("PLAYERSTAMINA", gameinformation.Stamina);
        PlayerPrefs.SetInt("PLAYERENDURANCE", gameinformation.Endurance);
        PlayerPrefs.SetInt("PLAYERINTELLECT", gameinformation.Intellect);
        PlayerPrefs.SetInt("PLAYERSTRENGTH", gameinformation.Strength);
        PlayerPrefs.SetInt("PLAYERSPEED", gameinformation.Speed);
        PlayerPrefs.SetInt("PLAYERFAME", gameinformation.Fame);

        if(gameinformation.EquipmentOne != null)
        {
            ppserialization.Save("EQUIPMENTITEM1", gameinformation.EquipmentOne);
        }
        
        Debug.Log("saved all info");
    }
}
