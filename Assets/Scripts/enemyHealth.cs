using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    int health;

	// Use this for initialization
	void Start () {
        health = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            health = health - 1;
            Destroy(other.gameObject);
        }
    }

}
