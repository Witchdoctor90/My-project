using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EquipEvent : UnityEvent<EquipmentItemData>
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
	public EquipEvent EquipEvent;
	public ItemUseEvent itemUseEvent;
	

	
	public void OnUseItem ()
	{
		Item_data currItem = _itemsManager.selectedSlot.item;
		
        switch (currItem.GetType().Name)
        {
			case nameof(UsableItemData):
				if ((currItem as UsableItemData).healPointsCount != 0)
				{
					itemUseEvent.Invoke((UsableItemData)currItem);
				}
				_itemsManager.RemoveItem(currItem);
				break;
			case nameof(Weapon_Item_data):
				EquipEvent.Invoke((Weapon_Item_data)currItem);
				_itemsManager.RemoveItem(currItem);
				break;
			case nameof(ArmorItemData):
				EquipEvent.Invoke((ArmorItemData)currItem);
				_itemsManager.RemoveItem(currItem);
				break;


		}


    }





}
