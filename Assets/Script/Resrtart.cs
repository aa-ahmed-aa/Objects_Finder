using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Resrtart : MonoBehaviour {

    public GameObject wonCanvas;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space"))
        {
            wonCanvas.active = false;
            score.ObjectCounter = 0;
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}
