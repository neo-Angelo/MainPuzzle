using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    
    public List<InventorySlot> Container = new List<InventorySlot>();

    public void addItem(itemObject _item) {
        bool hasItem = false;

        for (int i = 0; i < Container.Count; i++) {
            if (Container[i].item == _item){
                hasItem = true;
                break;
            }

        }
        if (!hasItem)
        {
            Container.Add(new InventorySlot(_item));
        }

    }
}

[System.Serializable]
public class InventorySlot
{
    public itemObject item;
    public string nameItem;
    public InventorySlot(itemObject _item) {
        item = _item;
        nameItem = _item.nameItem;
    }

}