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


    public void Equip(Weapon_Item_data _weapon)
    {
		weaponSlot.weapon = _weapon;
        InitEquipmentSlot();
        _playerCmbt.UpdateStats();
    }
    
    public void InitEquipmentSlot()
    {
        if (weaponSlot.weapon != null)
        {
            weaponSlot.gameObject.GetComponent<Image>().sprite = weaponSlot.weapon.item_icon;
        }
        else
        {
            weaponSlot.gameObject.GetComponent<Image>().sprite = null;
        }
    }    

    public void UnEquip()
    {
        _itemsManager.AddItem(weaponSlot.weapon);
        weaponSlot.weapon = null;
        InitEquipmentSlot();
        _playerCmbt.UpdateStats();
    }

}
