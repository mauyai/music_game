using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class songPlay : MonoBehaviour {

    public string nextSceneName;

	public void press()
    {
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }

}
