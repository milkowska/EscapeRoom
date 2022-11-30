using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hammer : MonoBehaviour
{
    public bool isClicked;
    public bool isOutline = false;
    Item item;
    public SpriteRenderer outline;

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
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        TextManager.instruction = "";
        outline.enabled = false;
    }

    private void OnMouseDown()
    {
        if (!isOutline)
        {
            InventoryManager.Instance.Add(item);
        }
        GameManager.isHammerPickedUp = true;
        TextManager.instruction = "";
        AudioManager.instance.PlaySound("itemPickup");
        if (gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
    