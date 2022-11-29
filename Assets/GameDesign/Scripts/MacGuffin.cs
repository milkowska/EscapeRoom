using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MacGuffin : MonoBehaviour
{
    Item item;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.isMapPickedUp)
        {
            Destroy(this.gameObject);
        }
        item = new Item("MacGuffin", GetComponent<SpriteRenderer>().sprite); // map
    }


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TextManager.instruction = "This is a MacGuffin. It looks like a map!";
        }
    }

    private void OnMouseExit()
    {
        TextManager.instruction = "";
    }

    private void OnMouseDown()
    {
        InventoryManager.Instance.Add(item);
        GameManager.isMapPickedUp = true;
        TextManager.instruction = "";
        Destroy(this.gameObject);
    }
}