using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{

    private bool hasAddedXP = false;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        //,PLAYERANIMATE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

    // Use this for initialization
    void Start()
    {
        hasAddedXP = false;
        currentState = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                //setup battle function
                break;
            case (BattleStates.PLAYERCHOICE):

                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                if (!hasAddedXP)
                {
                    increaseexperience.AddExperience();
                    hasAddedXP = true;
                }
                break;
        }
    }

    void OnGUI()
    {
        if(GUILayout.Button("Next State"))
        {
            if(currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.LOSE;
            }
            else if (currentState == BattleStates.LOSE)
            {
                currentState = BattleStates.WIN;
            }
            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}
