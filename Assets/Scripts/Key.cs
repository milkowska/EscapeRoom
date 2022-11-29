using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public GameObject key;
    public bool foundKey = false;
    Item item;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.isKeyPickedUp)
        {
            Destroy(this.gameObject);
        }
        item = new Item("Key", GetComponent<SpriteRenderer>().sprite);
    }

   
    public void Show()
    {
        foundKey = true;
        key.SetActive(true);
    }

    public void Hide()
    {
        key.SetActive(false);
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
        Destroy(this.gameObject);
    }
}
