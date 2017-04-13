using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class Displayer : MonoBehaviour {
	public GameObject text,hologram,gamemanager;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<DefaultTrackableEventHandler> ().flag == 0) {
			text.SetActive (false);
			hologram.SetActive (false);
			Debug.Log (gameObject.GetComponent<DefaultTrackableEventHandler> ().flag);
			Debug.Log ("not working");

		} else {
			//if (gameObject.GetComponent<validate> ().allow == 1) {
				text.SetActive (true);
				//text.GetComponent<Text> ().text = gamemanager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number];
				hologram.SetActive (true);
				Debug.Log ("working");
			//}
		}
	}
}
