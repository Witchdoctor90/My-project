using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class UnEquipArmorEvent : UnityEvent<EquipmentItemData>
{

}

public class ArmorSlot : MonoBehaviour
{
    public ArmorItemData armor;
    public UnEquipArmorEvent unEquipMe;

    public void UnEquip()
    {
        if(armor)
            unEquipMe.Invoke(armor);        
    }
}