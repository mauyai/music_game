using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

    public GameObject music;

	public void play()
    {
        music.SetActive(true);
    }
}
