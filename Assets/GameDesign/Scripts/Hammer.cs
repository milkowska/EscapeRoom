using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hammer : MonoBehaviour
{
    public bool isClicked;
    Item item;

    // Start is called before the first frame update
    void Start()
    {
        // isClicked = false;
        if (GameManager.isHammerPickedUp)
        {
            Destroy(this.gameObject);
        }

        item = new Item("Hammer", GetComponent<SpriteRenderer>().sprite);
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TextManager.instruction = "This is a hammer";
        }
    }

    private void OnMouseExit()
    {
        TextManager.instruction = "";
    }

    private void OnMouseDown()
    {
        InventoryManager.Instance.Add(item);
        GameManager.isHammerPickedUp = true;
        TextManager.instruction = "";
        AudioManager.instance.PlaySound("itemPickup");
        Destroy(this.gameObject);
    }
}
    