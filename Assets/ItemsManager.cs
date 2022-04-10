using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ItemsManager : MonoBehaviour
{

	[SerializeField]private GameObject slotPrefab;
	
	public ItemSlot[] Buttons;
	public List<Item_data> ItemsList;
	
	public UnityEvent InventoryUpdate;



    public void InitButtons ()
	{
		Buttons = GetComponentsInChildren<ItemSlot> ();
	}

	public void InitItems ()
	{
		for (int i = 0; i < ItemsList.Count; i++) {
			Buttons [i].GetComponent<ItemSlot> ().item = ItemsList [i];
		}
	}


	public void AddItem (Item_data _item)
	{
		slotPrefab.GetComponent<ItemSlot>().item = _item;
		slotPrefab.GetComponent<Image>().sprite = _item.item_sprite;
		slotPrefab.GetComponent<ItemSlot>().isEmpty = false;
		ItemsList.Add(_item);
		Instantiate(slotPrefab, this.transform);
		InventoryUpdate.Invoke();
	}

	//DEBUG
	//DEBUG


}
