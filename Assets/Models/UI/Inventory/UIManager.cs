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
    [SerializeField] private Equipment _equipment;
    public ItemsManager _itemsManager;
    public GameObject _descriptionPanel;
    public GameObject _inventoryPanel;
    public DescriptionPanelController _descPanelController;
    public HealthBar _healthBar;
    public SelectSlotEvent selectSlotEvent;

    private void Start()
    {
        _descriptionPanel.SetActive(false);
        _inventoryPanel.SetActive(false);
    }

}
