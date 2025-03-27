using UnityEngine;

public class Items
{
    public enum ItemType
    {
        Leg,
        Arm,
        Head,
        Torso,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {

            default:
                case ItemType.Leg: return ItemAssets.Instance.legSprite;
                case ItemType.Head: return ItemAssets.Instance.headSprite;
                case ItemType.Torso: return ItemAssets.Instance.torsoSprite;
                case ItemType.Arm: return ItemAssets.Instance.armSprite;


        }
    }
}
