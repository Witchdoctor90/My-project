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
        switch (_uiManager._itemsManager.selectedSlot.item.GetType().Name)
        {
            case (nameof(Weapon_Item_data)):            
                 return
                ("DMG " + "+ " + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).damageBoost + System.Environment.NewLine +
                "CritDMG " + "+ " + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).critDamage + System.Environment.NewLine +
                "CritChance " + "+ " + (_uiManager._itemsManager.selectedSlot.item as Weapon_Item_data).critChance);
            case (nameof(UsableItemData)):
                return ("HP " + "+ " + (_uiManager._itemsManager.selectedSlot.item as UsableItemData).healPointsCount);
            case (nameof(ArmorItemData)):
                return ("Def " + "+ " + (_uiManager._itemsManager.selectedSlot.item as ArmorItemData).defensePoints);
            default: return ("lol nothing here");
        }            
    }

    public string UseButtonString()
    {
        switch (_uiManager._itemsManager.selectedSlot.item.GetType().Name)
        {
            case (nameof(Weapon_Item_data)):
                return ("Equip");
            case (nameof(ArmorItemData)):
                return ("Equip");
            case (nameof(UsableItemData)):
                return ("Use");
            default: 
                return "lol nothing here";
        }
    }
    
    public void UpdateText()
    {
        descText.text = _uiManager._itemsManager.selectedSlot.item.item_desc;
        buttonText.text = UseButtonString();
        attributesText.text = attributesString();
    }
}
