using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class spl21 : MonoBehaviour {
	public GameObject text,q1,q2,manager;
	GameObject img2,img4;
	bool updatedP,updatedS;
	public Sprite newSprite2,newSprite4;
	int number;

	// Use this for initialization
	void Start () {
		
		updatedP = false;
		updatedS = true;


	}

	// Update is called once per frame
	void Update () {
		//newSprite = Resources.Load ("") as Sprite;
		//if (!newSprite)
		//Debug.Log ("sprite not found");
		if (gameObject.GetComponent<DefaultTrackableEventHandler> ().flag == 0) {
			if (manager.GetComponent<Levelinfo> ().nothing == 0) {
				text.SetActive (false);
				q1.SetActive (false);
				q2.SetActive (false);

			}
			if (!updatedS) {
				manager.GetComponent<Levelinfo> ().nothing -= 1;
				updatedS = true;
				updatedP = false;
			}
		} else {
			if (!updatedP) {
				manager.GetComponent<Levelinfo> ().nothing += 1;
				updatedP = true;
				updatedS = false;


					//text.GetComponent<text> ().text = manager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number-1];
					//text.GetComponent<TypeOutScript>().FinalText=manager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number-1];

					text.GetComponent<TypeOutScript> ().reset = true;
					//text.GetComponent<TypeOutScript> ().reset = false;
					text.GetComponent<TypeOutScript> ().On = true;
					//text.SetActive (true);
					//q1.SetActive (true);
					//q2.SetActive (true);


			}



					
					//text.GetComponent<Text> ().text = manager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number-1];
					text.GetComponent<TypeOutScript> ().FinalText = manager.GetComponent<Levelinfo> ().clues [20];
					text.GetComponent<TypeOutScript> ().On = true;

					text.SetActive (true);


				q1.SetActive (true);
				q2.SetActive (true);

		}
	}
}
