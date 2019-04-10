using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDatailController : MonoBehaviour {

    public Image Icon;
    public Text Name;
    public Text Desc;
    public GameObject UseButton;

    private ItemData showedItem;
    private ItemUsableData usableItem;

    public void Setup(ItemData data)
    {
        Icon.sprite = data.Icon;
        Name.text = data.name;
        Desc.text = data.Description;
        showedItem = data;
        if(data is ItemUsableData)
        {
            usableItem = (ItemUsableData)data;
            UseButton.SetActive(true);
        }
        else
        {
            usableItem = null;
            UseButton.SetActive(false);
        }
    }

    public void Drop()
    {
        LevelManager.Instance.Inventory.DropItem(showedItem.ID);
    }

    public void Use()
    {
        if (usableItem != null)
        {
            usableItem.Use();
        }
    }

}
