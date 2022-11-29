using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{
    Item item;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.isScrewPickedUp)
        {
            Destroy(this.gameObject);
        }
        item = new Item("Screw", GetComponent<SpriteRenderer>().sprite);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TextManager.instruction = "This is a screw!";
        }
    }

    private void OnMouseExit()
    {
        TextManager.instruction = "";
    }

    private void OnMouseDown()
    {
        InventoryManager.Instance.Add(item);
        GameManager.isScrewPickedUp = true;
        TextManager.instruction = "";
        Destroy(this.gameObject);
    }
}
