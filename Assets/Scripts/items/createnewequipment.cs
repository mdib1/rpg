using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createnewequipment : MonoBehaviour
{

    private baseequipment newEquipment;

    private string[] itemNames = new string[4] { "Common", "Great", "Amazin", "Insane" };
    private string[] itemDescriptions = new string[2] { "A New cool item", "A new less cool item" };

    void Start()
    {
        CreateEquipment();
        Debug.Log("name " + newEquipment.ItemName);
        Debug.Log("desc " + newEquipment.ItemDescription);
        Debug.Log("id " + newEquipment.ItemID.ToString());
        Debug.Log("speed " + newEquipment.Speed.ToString());
        Debug.Log("type " + newEquipment.EquipmentType.ToString());
        Debug.Log("intellect: " + newEquipment.Intellect.ToString());
    }

    public void CreateEquipment()
    {
        newEquipment = new baseequipment();
        //create description
        newEquipment.ItemDescription = itemDescriptions[Random.Range(0, itemDescriptions.Length)];
        //equipment id
        newEquipment.ItemID = Random.Range(1, 101);
        //stats
        newEquipment.Speed = Random.Range(0, 11);
        newEquipment.Stamina = Random.Range(0, 11);
        newEquipment.Endurance = Random.Range(0, 11);
        newEquipment.Strength = Random.Range(0, 11);
        newEquipment.Fame = Random.Range(0, 11);
        newEquipment.Intellect = Random.Range(0, 11);
        //choose type
        ChooseEquipmentType();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        //spell effects id
        newEquipment.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseEquipmentType()
    {
        int randomTemp = Random.Range(1, 8);
        if (randomTemp == 1)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.HEAD;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.CHEST;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.LEGS;
        }
        else if (randomTemp == 4)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.FEET;
        }
        else if (randomTemp == 5)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.HANDS;
        }
        else if (randomTemp == 6)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.BELT;
        }
        else if (randomTemp == 7)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.CAPE;
        }
        else if (randomTemp == 8)
        {
            newEquipment.EquipmentType = baseequipment.equipmentTypes.RING;
        }

    }

}