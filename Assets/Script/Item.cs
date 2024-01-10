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
        if (name.Equals("Axe"))
        {
            PlayerMovement.instance.ShowAxe();
            RemoveItemFromInventory();
        }
        if (name.Equals("Chicken"))
        {
            FoodController.instance.healingFood();
            RemoveItemFromInventory();
        }
    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
