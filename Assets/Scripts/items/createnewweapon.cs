using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createnewweapon : MonoBehaviour {

    private baseweapon newWeapon;

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.Speed.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Intellect.ToString());
    }

    public void CreateWeapon()
    {
        newWeapon = new baseweapon();

        //create description
        newWeapon.ItemDescription = "Randomly Generated Weapon";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Speed = Random.Range(0, 11);
        newWeapon.Stamina = Random.Range(0, 11);
        newWeapon.Endurance = Random.Range(0, 11);
        newWeapon.Strength = Random.Range(0, 11);
        newWeapon.Fame = Random.Range(0, 11);
        newWeapon.Intellect = Random.Range(0, 11);
        //choose type
        ChooseWeaponType();
        newWeapon.ItemName = "random " + newWeapon.WeaponType.ToString();
        //spell effects id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 4);
        if(randomTemp == 1)
        {
            newWeapon.WeaponType = baseweapon.weaponTypes.BLUNT;
        }else if (randomTemp == 2)
        {
            newWeapon.WeaponType = baseweapon.weaponTypes.EDGE;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = baseweapon.weaponTypes.PROJECTILE;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = baseweapon.weaponTypes.MAGIC;
        }

    }

}
