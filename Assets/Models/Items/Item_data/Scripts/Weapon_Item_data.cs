using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Weapon", menuName = "Weapon")]
public class Weapon_Item_data : Item_data
{
	public new Type itemType
    {
        get
        {
            return Type.weapon;
        }
    }

	
	public int damageBoost;
	public int critDamage;
	public int critChance;

    
}
