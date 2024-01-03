using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

[CreateAssetMenu (fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "";
    public Sprite icon = null;
    public bool showInventory = true;

    // คำสั่งกรณีใช้ Item
    public void Use()
    {

    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
