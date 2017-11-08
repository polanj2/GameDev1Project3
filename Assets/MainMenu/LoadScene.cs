using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void LoadIndexScene(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
