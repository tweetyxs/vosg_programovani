using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListElementControl : MonoBehaviour {

    public Image Icon;
    public Text Name;
    private ItemData item;

    public void Setup(ItemData item)
    {
        Icon.sprite = item.Icon;
        Name.text = item.Name;
        this.item = item;
    }

    public void Pressed ()
    {
        LevelManager.Instance.Inventory.inventoryUI.ShowDetail(item);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
