using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void Add(Item item)
    {
        Items.Add(item);
        ListItems();
    }
    public void Reset()
    {
        Item[] list = FindObjectsOfType<Item>();

        foreach(Item item in list)
        {
            Destroy(item);
        }
        Items.Clear();
    }

    public void ListItems()
    {
        //Clean before open
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var ItemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            ItemName.text = item.ItemName;
            itemIcon.sprite = item.ItemIcon;
        }
    }

    public void destroyInventory()
    {
        Destroy(gameObject);
    }
}
