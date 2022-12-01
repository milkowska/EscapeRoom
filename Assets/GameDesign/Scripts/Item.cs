using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    public int id;
    public string ItemName;
    public Sprite ItemIcon;

    public Item(string itemName, Sprite sprite)
    {
        this.ItemName = itemName;
        this.ItemIcon = sprite;
    }
}
