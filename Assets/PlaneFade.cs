using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFade : MonoBehaviour {

    public GameObject p;
    // Use this for initialization
    void Start() {
        p.SetActive(false);
        Invoke("Activate", 1f);
    }

    // Update is called once per frame
    void Update() {
        StartCoroutine(ShowAndHide(p, 1.0f)); // 1 second
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }

    void Activate()
    {
        gameObject.SetActive(true);
    }
}
