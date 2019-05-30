using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMove : MonoBehaviour {

    public float MoveSpeed = 4f;

    private float x;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xR = 0;
        float xL = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xR = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xL = -1;
        }

        x = xR + xL;
            
        transform.position += new Vector3(x, 0, 0) * MoveSpeed * Time.deltaTime;
    }
}
