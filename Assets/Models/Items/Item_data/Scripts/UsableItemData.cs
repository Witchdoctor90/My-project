using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "Usable", menuName = "Item/UsableItem")]
public class UsableItemData : Item_data
{
	public new Type itemType {
		get {
			return Type.usable;
		}
	}

	public int healPointsCount;
    
}
