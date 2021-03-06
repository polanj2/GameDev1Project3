using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour
{
	Skybox sky;
	public Material skyMat;
	float time;
	float count;
	WorldOver wo;

	void Start ()
	{
		//mainLight = GetComponent<Light> ();
		// skyMat = RenderSettings.skybox;
		time = 12.0f;
		// count = 0.0f;
		wo = gameObject.GetComponentsInParent<WorldOver> () [0];
	}

	void Update ()
	{
        // if (Input.GetKey (KeyCode.T)) {
        // 	count += 0.25f;
        //	time = (Mathf.Floor (count)) % 24;
        //}

        print ("Time is " + wo.timeGet ());

        time = ((wo.timeGet() % 50) / 50.0f) * 18 + 6;
        Debug.Log("Time = " + time);



		float i = 0.0f;//((maxIntensity - minIntensity) * dot) + minIntensity;
		//0-6 0.25-0.9
		//6-18 0.9-1.6
		//18-24 1.6-0.25



		if (time >= 0 && time < 6)
			i = 0.25f + (0.65f) * (time / 6.0f);
		else if (time >= 6 && time < 18)
			i = 0.9f + (0.7f) * ((time - 6.0f) / 12.0f);
		else
			i = 1.6f - (1.35f) * ((time - 18.0f) / 6.0f);

		skyMat.SetFloat ("_AtmosphereThickness", i);
	}
}
