using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HurtPlayer : MonoBehaviour
{
    public int damageGiven;
    public UnityEvent triggerEnter;
    private void OnCollisionEnter(Collision other)
    {
        triggerEnter.Invoke();
    }
}
