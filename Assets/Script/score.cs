using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour {
    public static int ObjectCounter = 0;
    public GameObject wonCanvas;

    // Update is called once per frame
    void Update () {
        GetComponent<Text>().text = ObjectCounter.ToString();

        if(ObjectCounter ==9)
        {
            wonCanvas.active = true;
        }

        
    }
}
