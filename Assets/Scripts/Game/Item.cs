using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public UnityEvent startOnAwakeEvent;

    void Start()
    {
        startOnAwakeEvent?.Invoke();
    }


}
