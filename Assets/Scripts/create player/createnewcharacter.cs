using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createnewcharacter : MonoBehaviour {

    private baseplayer newPlayer;
    private string playerName = "EnterName";

	// Use this for initialization
	void Start () {
        newPlayer = new baseplayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName);
        if (GUILayout.Button("Create"))
        {
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = Random.Range(8, 12);
            newPlayer.Speed = Random.Range(8, 12);
            newPlayer.Strength = Random.Range(8, 12);
            newPlayer.Endurance = Random.Range(8, 12);
            newPlayer.Fame = 0;
            newPlayer.Intellect = Random.Range(8, 12);
            newPlayer.PlayerName = playerName;
            StoreNewPlayerInfo();
            saveinformation.SaveAllInformation();

        }

        if (GUILayout.Button("Load"))
        {
            Application.LoadLevel("Test");
        }

    }

    private void StoreNewPlayerInfo()
    {
        gameinformation.PlayerName = newPlayer.PlayerName;
        gameinformation.PlayerLevel = newPlayer.PlayerLevel;
        gameinformation.Stamina = newPlayer.Stamina;
        gameinformation.Speed = newPlayer.Speed;
        gameinformation.Strength = newPlayer.Strength;
        gameinformation.Endurance = newPlayer.Endurance;
        gameinformation.Fame = newPlayer.Fame;
        gameinformation.Intellect = newPlayer.Intellect;

    }
}
