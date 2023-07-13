using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    public GameObject ItemText;
    public itemObject item;

    void Start()
    {
        ItemText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            ItemText.SetActive(true);
            if (Input.GetKey(KeyCode.E)) {
                
                ItemText.SetActive(false);
                // Call a method in the player script to handle the item pickup
                other.GetComponent<ControllerPlayer>().PickUpItem(item);

                // Remove the item from the scene
                Destroy(gameObject);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        ItemText.SetActive(false);

    }
}
