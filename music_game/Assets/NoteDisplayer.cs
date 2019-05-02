using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDisplayer : MonoBehaviour {

    public float TapTime;
    public GameObject Note;
    public Vector3 SpawnSpot;


    public AudioSource AS;
    public float DroppingTime = 4f;
    private float DisplayTime;
    private bool display = false;
    private NoteDropping ND;
    
    // Use this for initialization
	void Start () {
        //AS = GetComponent<AudioSource>();
        ND = Note.GetComponent<NoteDropping>();
        ND.TotalDropTime = DroppingTime;
        ND.DropSpot = SpawnSpot;
        DisplayTime = TapTime - DroppingTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (!display)
        {
            if (AS.time >= DisplayTime)
            {
                Note.transform.position = SpawnSpot;
                Instantiate(Note);
                display = true;

            }
        }
        
	}
}
