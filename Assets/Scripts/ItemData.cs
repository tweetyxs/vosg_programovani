using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/Item", order = 1)]

public class ItemData : ScriptableObject {

    public ItemsID ID;
    public Sprite Icon;
    public string Name;
    public string Description;
    public GameObject OriginObject;
}
