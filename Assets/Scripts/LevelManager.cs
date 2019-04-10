using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySampleAssets.Characters.FirstPerson;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance;

    public UIController UIController;
    public RigidbodyFirstPersonController Player;
    public InventoryManager Inventory;

	// Use this for initialization
	void Start () {
		if (Instance != null)
        {
            Debug.LogError("Instance je už zabrána");
        }
        else
        {
            Instance = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
