using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDropping : MonoBehaviour {

    public Vector3 DropSpot;
    public float DropToY;
    public float TotalDropTime = 4f;

    private float MovementPerSec;
    private float TotalYMovement;

	// Use this for initialization
	void Start () {
        gameObject.transform.position = DropSpot;
        TotalYMovement = DropToY - DropSpot.y;
        MovementPerSec =  TotalYMovement / TotalDropTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(0, MovementPerSec * Time.fixedDeltaTime, 0);
    }
}
