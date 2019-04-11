using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject TargetSpot = null;
    public GameObject Player = null;
    private bool startTeleport = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (startTeleport)
        {
            Player.transform.position = Vector3.Slerp(Player.transform.position, TargetSpot.transform.position, 0.05f * Time.timeScale);
            float distance = Vector3.Distance(Player.transform.position, TargetSpot.transform.position);
            if (distance < 1.0f)
            {
                startTeleport = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        startTeleport = true;
    }

}
