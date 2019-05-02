using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMusic : MonoBehaviour {

    private AudioSource Player;
    public Text TM;
    
    // Use this for initialization
	void Start () {
        Player = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Player.time);
        TM.text = Player.time.ToString("0.00");
        if (Player.isPlaying == false)
        {
            gameObject.SetActive(false);
        }
	}
}
