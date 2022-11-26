using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                {
                    {
                        if (hit.transform != null)
                        {
                            PrintObjectName(hit.transform.gameObject);
                        }
                    }

                }
            }

        }

    }
    
    private void PrintObjectName(GameObject obj)
    {
        Debug.Log(obj.name);
        print(obj.name);
    }

}
