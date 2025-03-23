using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    private Transform itemSlotContainer;
    private Transform itemSlot;

    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlot = itemSlotContainer.Find("itemSlot");
    }
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;

        foreach (Items item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x *  itemSlotCellSize, y * itemSlotCellSize);
            x++;
                if(x > 4)
            {
                x = 0;
                y++;
            }
        }
    }
}
