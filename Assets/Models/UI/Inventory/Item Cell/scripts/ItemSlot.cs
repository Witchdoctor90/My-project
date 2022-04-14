using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SelectMeEvent : UnityEvent<ItemSlot>
{

}

public class ItemSlot : MonoBehaviour
{
	private UIManager _uiManager;
	public int index;
	public int amount;
	public Item_data item;

	private void Start()
    {
		_uiManager = GameObject.Find("Inventory").GetComponent<UIManager>();
    }

	public void SelectMe()
    {
        _uiManager.selectSlotEvent.Invoke(this);
    }

	public void ShowDesc()
    {
		_uiManager._descriptionPanel.SetActive(true);
		_uiManager._descPanelController.UpdateText();
    }

	

}

