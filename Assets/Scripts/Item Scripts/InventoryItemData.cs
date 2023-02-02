using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory System/Inventory Item")]
public class InventoryItemData : ScriptableObject
{
    //public int ID;
    public string DisplayName;
    public Sprite Icon;
    public int MaxStackSize;
}
