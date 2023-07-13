using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class itemObject : ScriptableObject
{
    public GameObject PreFab;
    public int id;
    public string nameItem;
    [TextArea(15,20)]
    public string description;
}
