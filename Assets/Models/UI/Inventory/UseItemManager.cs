using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class WeaponEquipEvent : UnityEvent<Weapon_Item_data>
{

}
[System.Serializable]
public class ItemUseEvent : UnityEvent<UsableItemData>
{

}


public class UseItemManager : MonoBehaviour
{
	[SerializeField]private ItemsManager _itemsManager;
	[SerializeField]Equipment _equipment;
	public WeaponEquipEvent weaponEquipEvent;
	public ItemUseEvent itemUseEvent;
	

	
	public void OnUseItem ()
	{
		Item_data currItem = _itemsManager.selectedSlot.item;
		if (currItem is Weapon_Item_data)
		{
			weaponEquipEvent.Invoke((Weapon_Item_data)currItem);
			_itemsManager.RemoveItem(currItem);
		}


		else if (currItem is UsableItemData)
		{
			if ((currItem as UsableItemData).healPointsCount != 0)
			{
				itemUseEvent.Invoke((UsableItemData)currItem);
			}
			_itemsManager.RemoveItem(currItem);
		}





    }





}
