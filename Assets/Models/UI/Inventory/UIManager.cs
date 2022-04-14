using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SelectSlotEvent : UnityEvent<ItemSlot>
{

}

public class UIManager : MonoBehaviour
{
    public ItemsManager _itemsManager;
    [SerializeField] private Equipment _equipment;
    public GameObject _descriptionPanel;
    public GameObject _inventoryPanel;
    public DescriptionPanelController _descPanelController;

    public SelectSlotEvent selectSlotEvent;

    private void Start()
    {
        _descriptionPanel.SetActive(false);
        _inventoryPanel.SetActive(false);
    }

}
