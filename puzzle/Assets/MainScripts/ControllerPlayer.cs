using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    public inventoryManager inventoryManager; // Reference to the inventory manager

    public void PickUpItem(GameObject item)
    {
        //Debug.Log("dentro do player : ");
        // Get the Item component from the picked-up item GameObject
        //Item itemComponent = item.GetComponent<Item>();

        // Add the item to the player's inventory
        //inventoryManager.AddItem(itemComponent);
    }
}
