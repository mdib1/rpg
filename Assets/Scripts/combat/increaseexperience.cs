using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class increaseexperience {

    private static int xpToGive;

    public static void AddExperience()
    {
        xpToGive = gameinformation.PlayerLevel * 100;
        gameinformation.CurrentXP += xpToGive;
        CheckToSeeIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckToSeeIfPlayerLeveled()
    {
        if (gameinformation.CurrentXP >= gameinformation.RequiredXP)
        {
            //create level up script
        }
    }

}
