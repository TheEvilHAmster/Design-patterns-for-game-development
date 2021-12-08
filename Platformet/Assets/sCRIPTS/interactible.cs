using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactible : MonoBehaviour
{
    public float radius = 2f;
    public Transform interactionTransform;

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
    
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
    }
}
