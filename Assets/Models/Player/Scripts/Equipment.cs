using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;



public class Equipment : MonoBehaviour
{
	[SerializeField] private PlayerCmbt _playerCmbt;
    [SerializeField] private ItemsManager _itemsManager;
    public WeaponSlot weaponSlot;
    public ArmorSlot armorSlot;


    public void Equip(EquipmentItemData currEquipment)
    {
        switch (currEquipment.GetType().Name)
        {
            case (nameof(Weapon_Item_data)):
                weaponSlot.weapon = currEquipment as Weapon_Item_data;
                InitEquipmentSlots();
                _playerCmbt.UpdateStats();
                break;

            case (nameof(ArmorItemData)):
                armorSlot.armor = currEquipment as ArmorItemData;
                InitEquipmentSlots();
                _playerCmbt.UpdateStats();
                break;
        }
    }
    
    public void InitEquipmentSlots()
    {
    //WEAPON
        if (weaponSlot.weapon != null)
        {
            weaponSlot.gameObject.GetComponent<Image>().sprite = weaponSlot.weapon.item_icon;
        }
        else
        {
            weaponSlot.gameObject.GetComponent<Image>().sprite = null;
        }
    //WEAPON

    //ARMOR
        if(armorSlot.armor != null)
        {
            armorSlot.gameObject.GetComponent<Image>().sprite = armorSlot.armor.item_icon;
        }
        else
        {
            armorSlot.gameObject.GetComponent<Image>().sprite = null;
        }
    //ARMOR
    }    

    public void UnEquip(EquipmentItemData _equipment)
    {
        switch (_equipment.GetType().Name)
        {
            case (nameof(Weapon_Item_data)):
                _itemsManager.AddItem(_equipment as Item_data);
                weaponSlot.weapon = null;
                InitEquipmentSlots();
                _playerCmbt.UpdateStats();
                break;
            case (nameof(ArmorItemData)):
                _itemsManager.AddItem(_equipment as Item_data);
                armorSlot.armor = null;
                InitEquipmentSlots();
                _playerCmbt.UpdateStats();
                break;
        }
    }

}
