using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singleton

    public int space = 20;
    public static Inventory instance;
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one inventory found");
            return;
        }

        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();

    public OnItemChanged onItemChangedCAllBack;
    
    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }
            items.Add(item);
            onItemChangedCAllBack?.Invoke();

        }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        onItemChangedCAllBack?.Invoke();
    }
}
