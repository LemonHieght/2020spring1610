using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public int whol;
    public float desa;
    public string words;
    public UnityEvent triggerExit;
    public UnityEvent triggerEnter;
    public UnityEvent triggerStay;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExit.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerStay.Invoke();
    }
}
