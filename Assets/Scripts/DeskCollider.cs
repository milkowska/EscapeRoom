using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskCollider : MonoBehaviour
{
    private void OnMouseDown()
    {
        DeskDrawer.isDrawerOpen = !DeskDrawer.isDrawerOpen;
    }
}
