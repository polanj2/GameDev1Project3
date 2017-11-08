using UnityEngine;
using System.Collections;

public class PickupNote : MonoBehaviour
{
	//Maximum Distance
	public float maxDistance = 2F;	
	private bool readingNote = false;
	private string noteText;
    //GUI Skin with the Margins, Padding, Align, And Texture
    public GUISkin skin;

    void Start ()
    {
		//Start the input check loop
		StartCoroutine ( CheckForInput () );	
	}
	
	private IEnumerator CheckForInput ()
    {
		//Keep Updating
		while (true)
        {
			//If the 'E' was pressed and not reading a note check for a note, else stop reading
			if (Input.GetKeyDown (KeyCode.E))
            {
                if (!readingNote)
                {
                    CheckForNote();
                }
                else
                {
                    readingNote = false;
                }
			}	
			//Wait One Frame Before Continuing Loop
			yield return null;	
		}
	}
	
	private void CheckForNote ()
    {
		//A ray from the center of the screen
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit data;
		
		//Did we hit something?
		if (Physics.Raycast(ray, out data, maxDistance))
        {	
			//Was the object we hit a note?
			if (data.transform.name == "Note")
            {
				//Get text of note, destroy the note, and set reading to true
				noteText = data.transform.GetComponent <Note> ().Text;
				Destroy (data.transform.gameObject);
				readingNote = true;
			}
		}		
	}
	
	void OnGUI ()
    {
		if (skin)
			GUI.skin = skin;
		//Are we reading a note? If so draw it.
		if (readingNote)
        {
			//Draw the note on screen
			GUI.Box (new Rect (Screen.width / 4F, Screen.height / 16F, Screen.width / 2F, Screen.height * 0.75F), noteText);			
		}		
	}	
}
