using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;


	// Use this for initialization
	void Start () {
        health = 10;
    }
	
	// Update is called once per frame
	void Update () {


    }

    
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "TurretBullet")
        {
            health = health - 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "FirstAid")
        {
            {
                health = health + 1;
                Destroy(other.gameObject);
            }
        }

        LevelManager.Instance.UIController.SetHealth(health);

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
