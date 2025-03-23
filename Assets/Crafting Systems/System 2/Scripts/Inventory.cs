using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    private List<Items> itemList;

    public Inventory()
    {
        itemList = new List<Items>();

        AddItem(new Items { itemType = Items.ItemType.Head, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Arm, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Leg, amount = 1 });

        Debug.Log(itemList.Count);

    }

    public void AddItem (Items items)
    {
        itemList.Add(items);
    }

    public List<Items> GetItemList()
    {
        return itemList;
    }

}
