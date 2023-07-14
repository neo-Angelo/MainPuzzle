using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    public InventoryObject Inventory;


    public void PickUpItem(itemObject _item)
    {
        if (_item) {
            Inventory.addItem(_item);
        }
    }

    private void OnApplicationQuit()
    {
        Inventory.Container.Items.Clear();
    }
}
