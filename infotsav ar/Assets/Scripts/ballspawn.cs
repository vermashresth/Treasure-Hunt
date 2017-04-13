using UnityEngine;
using System.Collections;
using Vuforia;
public class ballspawn : MonoBehaviour {
	public GameObject img;
	public GameObject sph;
	GameObject copy;
	int made;
	// Use this for initialization
	void Start () {
		made = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (img.GetComponent<DefaultTrackableEventHandler> ().flag == 1) {
			if (made == 0) {
				copy = Instantiate (sph, img.transform) as GameObject;
				made = 1;
			}
		} 
		else {
			Destroy (copy);
			made = 0;
		}

	}
}
