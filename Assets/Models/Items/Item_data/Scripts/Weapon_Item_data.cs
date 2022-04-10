using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon_item_data : Item_data
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
