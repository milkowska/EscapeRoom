using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public GameObject key;
    Item item;

    void Start()
    {
        if (GameManager.isKeyPickedUp)
        {
            Destroy(this.gameObject);
        }
        item = new Item("Key", GetComponent<SpriteRenderer>().sprite);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TextManager.instruction = "This is a key!";
        }
    }

    private void OnMouseExit()
    {
        TextManager.instruction = "";
    }

    private void OnMouseDown()
    {
        InventoryManager.Instance.Add(item);
        GameManager.isKeyPickedUp = true;
        TextManager.instruction = "";
        AudioManager.instance.PlaySound("itemPickup");
        Destroy(this.gameObject);
    }
}
