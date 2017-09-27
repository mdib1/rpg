using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class baseitem {

    private string itemName;
    private string itemDescription;
    private int itemID;
    private itemTypes itemType;

    public enum itemTypes
    {
        EQUIPMENT,
        WEAPON,
        FOOD
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public itemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }

}
