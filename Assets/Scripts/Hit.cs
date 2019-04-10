using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    public GameObject Explosion;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "HitObject")
        {
            GameObject explosion = Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject, 0.25f);
        Destroy(explosion, 1.5f);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
