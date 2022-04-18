using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnEquipWeaponEvent : UnityEvent<EquipmentItemData>
{

}
public class WeaponSlot : MonoBehaviour
{
    public Weapon_Item_data weapon;
    public UnEquipWeaponEvent unEquipMe;
    public void UnEquip()
    {
        unEquipMe.Invoke(weapon);
    }
}
