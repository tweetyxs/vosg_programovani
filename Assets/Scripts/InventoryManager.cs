using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public List<ItemData> InventoryData;
    public InventoryUIController inventoryUI;
    private List<ItemsID> ItemsInInventory = new List<ItemsID>();
    private bool inventoryShowed = false;

    void Start()
    {
        inventoryUI.gameObject.SetActive(false);
    }

    public ItemData GetData(ItemsID item)
    {
        ItemData result = null;
        for(int i = 0; i < InventoryData.Count; i++)
        {
            if(InventoryData [i].ID == item)
            {
                result = InventoryData [i];
                break;
            }
        }
        return result;
    }

    public bool PickItem(ItemsID item)
    {
        ItemsInInventory.Add(item);
        return true;
    }

    public bool DropItem(ItemsID item)
    {
        bool result = ItemsInInventory.Remove(item);
        if(result)
        {
            ItemData data = GetData(item);
            if(data != null && data.OriginObject != null)
            {
                Transform pivotTransform = LevelManager.Instance.Player._camera.transform;
                Vector3 spawnPoint = pivotTransform.position + pivotTransform.forward * 2;
                Instantiate(data.OriginObject, spawnPoint, Quaternion.identity);
            }
        }
        inventoryUI.RefreshInventory(ItemsInInventory);
        return result;
        
    }

    public void ShowInventory()
    {
        inventoryShowed = !inventoryShowed;
        inventoryUI.gameObject.SetActive(inventoryShowed);
        if(inventoryShowed)
        {
            inventoryUI.RefreshInventory(ItemsInInventory);
        }
    }

    public bool IsOwning(ItemsID ID)
    {
        return ItemsInInventory.Contains(ID);
    }

    public void DestroyItem(ItemsID item)
    {
        ItemsInInventory.Remove(item);
        inventoryUI.RefreshInventory(ItemsInInventory);
    }
	
}
