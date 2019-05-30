using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSong : MonoBehaviour {

    private  GameObject pics;
    public GameObject mypic;

    public void click()
    {
        pics = GameObject.FindGameObjectWithTag("songpic");
        if(pics != mypic)
        {
            pics.SetActive(false);
            mypic.SetActive(true);
        }
        
    }
}
