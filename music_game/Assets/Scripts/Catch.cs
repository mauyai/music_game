using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour {

    
    

    private NoteDropping nd;
    private float beatTime;
    private AudioSource AS;

    public float missTime = 0.15f;

    // Use this for initialization
    void Start () {
        
        nd = GetComponent<NoteDropping>();
        beatTime = nd.beatTime_N;
        AS = nd.AS;
    }
	
	// Update is called once per frame
	void Update () {
        if ((AS.time - beatTime) > missTime)
        {
            miss();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "panel")
        {
            perfect();
        }
    }
    private void perfect()
    {
        Debug.Log("perfect");
        Destroy(gameObject);
    }
    private void miss()
    {
        Debug.Log("miss");
        Destroy(gameObject);
    }
}
