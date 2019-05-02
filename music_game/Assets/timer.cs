using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    private float Timer;

    public Text holder;
    // Use this for initialization
	void Start () {
        Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
        holder.text = Timer.ToString("0.00");
	}
}
