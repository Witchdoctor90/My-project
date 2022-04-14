using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class dubClickListener : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = .2f;
    [SerializeField]private float lastClickTime;
    public UnityEvent OnDoubleClick;    

    public void DetectDubClick()
    {
        float timeSinceLastClick = Time.time - lastClickTime;
        if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
        {
            OnDoubleClick.Invoke();
        }
        lastClickTime = Time.time;
    }    
}
