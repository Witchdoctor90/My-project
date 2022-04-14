using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ItemsManager : MonoBehaviour
{

	[SerializeField]private GameObject slotPrefab;
	
	public List<ItemSlot> Buttons;
	public List<Item_data> ItemsList;
	public UnityEvent InventoryUpdate;
	public ItemSlot selectedSlot;
	
	public void SelectSlot(ItemSlot slot)
	{
		selectedSlot = slot;
	}

	public void InitSlots ()
	{



		for (int i = 0; i < ItemsList.Count; i++)
		{
			if (ItemsList.Count > Buttons.Count)
			{
				foreach (ItemSlot slot in Buttons)
				{
					if (slot.item == null)
					{
						return;

					}
				}
			}
			else if (Buttons.Count > ItemsList.Count)
			{
				foreach (ItemSlot slot in Buttons)
				{
					if (slot.item = null)
					{
						Destroy(slot);
					}
				}
			}
			Buttons[i].GetComponent<ItemSlot>().item = ItemsList[i];
			Buttons[i].GetComponent<Image>().sprite = ItemsList[i].item_icon;
		}
		
	}

	private void InitButtonsArray()
    {
		Buttons = GetComponentsInChildren<ItemSlot>().ToList();
	}

	public void AddItem (Item_data _item)
	{
		ItemsList.Add(_item);
		InitSlots();
	}

	//DEBUG
	//DEBUG


}
