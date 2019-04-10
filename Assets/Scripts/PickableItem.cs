using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : DisplayUI
{

    public ItemsID Item;

    public override void Use()
    {
        PickUp();
    }

    public virtual void PickUp()
    {
        if(LevelManager.Instance.Inventory.PickItem (Item))
        {
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
