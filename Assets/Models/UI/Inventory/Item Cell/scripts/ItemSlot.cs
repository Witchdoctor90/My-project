using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemSlot : MonoBehaviour
{
	[SerializeField] private ItemsManager _itemsManager;
	public int index;
	public int amount;
	public bool isEmpty;
	public Item_data item;


	private void Start()
    {
		_itemsManager = GameObject.Find("Items").GetComponent<ItemsManager>();
    }



}
