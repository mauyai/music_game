using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDisplayer : MonoBehaviour {

    public AudioSource AS;                //音源
    public GameObject note;               //音符
    public Vector3 spawnPoint;            //生成點
    public float beatTime;                //拍點
    public float fallingTime;             //掉落時長
    private float spawnTime;              //生成時間

    private bool displayed;
    private NoteDropping nd;

    void Start()
    {
        nd = note.GetComponent<NoteDropping>();

        spawnTime = beatTime - fallingTime;
        displayed = false;
        note.transform.position = spawnPoint;
        nd.AS = AS;
        nd.beatTime_N = beatTime;
        nd.fallingTime_N = fallingTime;
    }
	
	void Update () {
        if (!displayed)
        {
            if(AS.time >= spawnTime)
            {
                note.SetActive(true);
                displayed = true;
            }
        }
	}
}
