using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Collectables : MonoBehaviour
{
    public UnityEvent triggerEnter;
    private void OnCollisionEnter(Collision other)
    {
        triggerEnter.Invoke();
    }
}
