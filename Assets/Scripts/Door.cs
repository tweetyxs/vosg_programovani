using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public ItemsID Key = ItemsID.None;

	void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && (Key == ItemsID.None || LevelManager.Instance.Inventory.IsOwning(Key)))
        {
            Destroy(gameObject);
        }
    }
}
