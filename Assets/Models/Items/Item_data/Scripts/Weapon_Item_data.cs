using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Weapon", menuName = "Item/Weapon")]
public class Weapon_Item_data : EquipmentItemData
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
