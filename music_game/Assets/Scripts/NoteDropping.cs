using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDropping : MonoBehaviour {

    public AudioSource AS;                //音源
    public float beatTime_N;              //拍點
    public float fallingTime_N;           //掉落時長

    public float fallToY;                 //按鍵高度
    

    private float totalLength;            //掉落總長
    private float dropPerSec;             //每秒掉落

   

    // Use this for initialization
    void Start()
    {
        
        totalLength = fallToY - transform.position.y;
        dropPerSec = totalLength / fallingTime_N;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, dropPerSec * Time.deltaTime, 0);
        
        
    }
   

}
