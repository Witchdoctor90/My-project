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
		InitButtonsArray();		
	}

	private void InitButtonsArray()
    {
		Buttons = GetComponentsInChildren<ItemSlot>().ToList();
	}

	public void AddItem (Item_data _item)
	{
		ItemsList.Add(_item);
		GameObject slot = Instantiate(slotPrefab, this.transform);
		slot.GetComponent<ItemSlot>().item = _item;
		slot.GetComponent<Image>().sprite= _item.item_icon;				
		InitSlots();
	}

	public void RemoveItem(Item_data _item)
    {
		Destroy(Buttons[ItemsList.IndexOf(_item)].gameObject);
		Buttons.Remove(Buttons[ItemsList.IndexOf(_item)]);
		ItemsList.Remove(_item);
    }

	//DEBUG
	//DEBUG


}
