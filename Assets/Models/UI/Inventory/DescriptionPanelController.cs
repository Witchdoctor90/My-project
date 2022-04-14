using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanelController : MonoBehaviour
{
    [SerializeField]private UIManager _uiManager;
    [SerializeField]private Text descText;
    [SerializeField]private Text attributesText;
    [SerializeField]private Text buttonText;
    
    private string attributesString()
    {
        
        if(_uiManager._itemsManager.selectedSlot.item is Weapon_Item_data)
        {
            return
                ("damage:" + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).damageBoost + System.Environment.NewLine +
                "CritDamage:" + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).critDamage + System.Environment.NewLine +
                "CritChance:" + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).critChance);
        }
        else if(_uiManager._itemsManager.selectedSlot.item is UsableItemData)
        {
            return("Heals :" + (_uiManager._itemsManager.selectedSlot.item as UsableItemData).healPointsCount);
        }
        return "lol nothing here";              
    }

    public string UseButtonString()
    {
        if(_uiManager._itemsManager.selectedSlot.item is Weapon_Item_data)
        {
            return ("Equip");
        }
        else if (_uiManager._itemsManager.selectedSlot.item is UsableItemData)
        {
            return ("Use");
        }
        return "lol nothing here";
    }
    
    public void UpdateText()
    {
        descText.text = _uiManager._itemsManager.selectedSlot.item.item_desc;
        buttonText.text = UseButtonString();
        attributesText.text = attributesString();
    }
}
