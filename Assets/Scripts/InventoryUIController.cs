using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIController : MonoBehaviour {

    public GameObject ItemElementPrefab;
    public RectTransform ItemList;
    public ItemDatailController ItemdDetail;
    private ItemData focused = null;
    private List<ItemListElementControl> spawnedElem = new List<ItemListElementControl>();

    public int widthItemElement = 100;
    public int heigthItemElement = 120;
    public int offsetItemElement = 20;
    public int numInRow = 3;

    public void RefreshInventory(List<ItemsID> inventory)
    {
        Clear ();
        HideDetail();
        for (int i = 0; i < inventory.Count; i++)
        {
            ItemData data = LevelManager.Instance.Inventory.GetData(inventory[i]);
            GameObject spawned = Instantiate(ItemElementPrefab, ItemList);

            int row = i / numInRow;
            int col = i % numInRow;

            RectTransform spawnedTrans = (RectTransform)spawned.transform;
            spawnedTrans.anchoredPosition = new Vector2(offsetItemElement + col * (widthItemElement + offsetItemElement), -1 * (offsetItemElement + row * (heigthItemElement + offsetItemElement)));

            ItemListElementControl spawnedcontrol;
            spawnedcontrol = spawned.GetComponent<ItemListElementControl>();
            if (spawnedcontrol != null)
                spawnedElem.Add(spawnedcontrol);
                spawnedcontrol.Setup(data);
        }
        int rowSum = inventory.Count / numInRow +1;
        int colSum = numInRow;

        ItemList.sizeDelta = new Vector2(offsetItemElement + colSum * (widthItemElement + offsetItemElement),  (offsetItemElement + rowSum * (heigthItemElement + offsetItemElement)));
    }

    private void Clear()
    {
        for(int it = 0; it < spawnedElem.Count; it++)
        {
            Destroy(spawnedElem[it].gameObject);
  
        }
            spawnedElem.Clear();
        }

    private void HideDetail()
    {
        ItemdDetail.gameObject.SetActive(false);
    }

    public void ShowDetail(ItemData item)
    {
        ItemdDetail.gameObject.SetActive(true);
        ItemdDetail.Setup(item);
    }

}
