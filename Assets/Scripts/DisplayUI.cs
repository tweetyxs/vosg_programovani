using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour, IUsable {

    Transform player;

  
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    public virtual void Use()
    {
        Debug.Log("Used object");
        Destroy(gameObject);
    }

    void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Use this for initialization
    void Start () {
        myText.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(player);

        FadeText();
        //if (Input.GetKeyDown (KeyCode.Escape))
        //{
            //Screen.lockCursor = false;
        //}
	}

    void OnMouseOver()
    {
        displayInfo = true;
        LevelManager.Instance.Player.SetFocus(this);
    }

    void OnMouseExit()
    {
        displayInfo = false;
        LevelManager.Instance.Player.SetFocus(null);
    }

    private void OnDestroy()
    {
        LevelManager.Instance.Player.SetFocus(null);
    }

    void FadeText ()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
    
}
