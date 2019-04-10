using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Inventory/ItemHeal", order = 1)]
public class ItemHealData : ItemUsableData
{
    public int HealAmount = 10;

	public override void Use ()
    {
        base.Use();
        LevelManager.Instance.Player.HealthPlayer.health += HealAmount;
        LevelManager.Instance.UIController.SetHealth(LevelManager.Instance.Player.HealthPlayer.health);
        LevelManager.Instance.Inventory.DestroyItem(ID);
    }
}
