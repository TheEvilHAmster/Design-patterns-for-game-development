using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : interactible
{

    public Item item;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }

    void Pickup()
    {
        
        Debug.Log("Picked Up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
        {
            Destroy(gameObject);            
        }

    }
}
