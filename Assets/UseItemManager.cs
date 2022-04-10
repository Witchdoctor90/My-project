using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemManager : MonoBehaviour
{
	[SerializeField]private ItemsManager _itemsManager;
	[SerializeField]private PlayerCmbt _playerCmbt;
	[SerializeField]Equipment _equipment;

	public void OnUseItem (Item_data currItem)
	{
		switch(currItem.itemType)
        {
			case Type.weapon:
				_equipment.weapon = currItem as Weapon_item_data;
				_itemsManager.ItemsList.Remove(currItem);
				_itemsManager.InventoryUpdate.Invoke();
				break;
			case Type.usable:
				_itemsManager.ItemsList.Remove(currItem);
				_itemsManager.InventoryUpdate.Invoke();
				break;

        
        }

	}



	
}
