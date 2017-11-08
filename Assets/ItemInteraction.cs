using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {
	public string itemType;
	PlayerInventory player;

	// Use this for initialization
	void Start () {
		player = (GameObject.Find ("Main Camera")).GetComponent<PlayerInventory>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && Vector3.Distance(player.transform.position, this.transform.position) < 20) {
			if (itemType == "Stick") {
				player.stickUp();
				Destroy (gameObject);
			}
			else if (itemType == "Knife") {
				player.knifeGet();
				Destroy (gameObject);
			}
			else if (itemType == "Water") {
				player.waterGet();
			}
			else if (itemType == "Brotiene") {
				player.broGet();
				Destroy (gameObject);
			}
			else if (itemType == "Bed") {
				player.broGet();
				Destroy (gameObject);
			}
			else if (itemType == "Thorn" && player.hasKnife()) {
				Destroy (gameObject);
			}
			else if (itemType == "Boulder" && player.hasBro()) {
				Destroy (gameObject);
			}
		}
	}
}
