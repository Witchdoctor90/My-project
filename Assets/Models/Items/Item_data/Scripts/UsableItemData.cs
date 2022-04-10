using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "Usable", menuName = "UsableItem")]
public class UsableItemData : Item_data
{
	public new Type itemType {
		get {
			return Type.usable;
		}
	}

    
}
