using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]
public class ScriptableItem : ScriptableObject
{

    public enum ItemType
    {
        Item,
        Armor,
        Weapon
    }

    public ItemType itemType;

    public string itemName;
    public string itemDescription;
    public int itemPrince;
    public Sprite itemSprite;

}
