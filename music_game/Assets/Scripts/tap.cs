using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour {

    private GameObject panel;             //panel
    public float rangeX;                  //X差值
    public float tapTimeP = 0.05f;        //perfect點擊誤差
    public float tapTimeG = 0.1f;         //good點擊誤差
    public float tapTimeM = 0.15f;        //miss點擊誤差

    private NoteDropping nd;
    private float beatTime;
    private AudioSource AS;

    // Use this for initialization
    void Start () {
        panel = GameObject.Find("panel");
        nd = GetComponent<NoteDropping>();
        beatTime = nd.beatTime_N;
        AS = nd.AS;
    }
	
	// Update is called once per frame
	void Update () {
        if (Mathf.Abs(transform.position.x - panel.transform.position.x) < rangeX)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Mathf.Abs(AS.time - beatTime) <= tapTimeP)
                {
                    perfect();
                }
                else if(Mathf.Abs(AS.time - beatTime) <= tapTimeG)
                {
                    good();
                }
                else if (Mathf.Abs(AS.time - beatTime) <= tapTimeM)
                {
                    miss();
                }

            }

        }

        if ((AS.time - beatTime) > tapTimeM)
        {
            miss();
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
    private void good()
    {
        Debug.Log("good");
        Destroy(gameObject);
    }
}
