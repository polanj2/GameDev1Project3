using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

    public float fadeSpeed = 0.5f;
    public string sceneName;
    public Color fadeColor = Color.black;

    void OnGUI()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Initiate.Fade(sceneName, fadeColor, fadeSpeed);
        }
    }
}
