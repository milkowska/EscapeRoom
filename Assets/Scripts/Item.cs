using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New item", menuName ="Item/Create new item")]
public class Item : ScriptableObject
{
    public int id;
    public string ItemName;
    public Sprite ItemIcon;
}
