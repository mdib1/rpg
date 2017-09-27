using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup
{
    public void LevelUpCharacter()
    {
        //check to see if currentxp > requiredxp
        if(gameinformation.CurrentXP > gameinformation.RequiredXP)
        {
            gameinformation.CurrentXP -= gameinformation.RequiredXP;
        }else
        {
            gameinformation.CurrentXP = 0;
        }
        //give player stat points
        //give player new xp goal
        DetermineRequiredXP();
        //unlock skills
    }

    private void DetermineRequiredXP(int playerLevel)
    {
        playerLevel += 1;
        int levels = 999;
        float xpLevel1 = 500.0f;
        float xpLevel999 = 5000000000.0f;
        float temp1 = Mathf.Log(xpLevel999 / xpLevel1);
        float b = temp1 / (levels - 1);
        float temp2 = (Mathf.Exp(b) - 1);
        float a = (xpLevel1 / temp2);
        int oldxp = (int)(a * Mathf.Exp((float)b * (playerLevel - 1)));
        int newxp = (int)(a * Mathf.Exp((float)b *(playerLevel));
        int temp = newxp - oldxp;
        temp = (int)Mathf.Round((float)temp / 10.0f) * 10;
        gameinformation.RequiredXP = temp;     

    }
}
