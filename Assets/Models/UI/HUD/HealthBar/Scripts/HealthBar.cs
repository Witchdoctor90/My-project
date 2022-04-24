using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class OnHPChangedEvent : UnityEvent<int>
{

}

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    public OnHPChangedEvent OnHpChanged;

    public void HpSet(int _HP)
    {
        _slider.value = _HP;
    }

    
}
