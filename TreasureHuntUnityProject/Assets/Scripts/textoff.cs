using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class textoff : MonoBehaviour {
	public GameObject text,q1,q2,manager,img1,img2,img3;
	bool updatedP,updatedS;
	public Sprite newSprite1,newSprite2,newSprite3;
	int number;
	int lvl = PlayerPrefs.GetInt ("level");
	// Use this for initialization
	void Start () {
		img1 = manager.GetComponent<Levelinfo> ().Imagelvl1;
		img2 = manager.GetComponent<Levelinfo> ().Imagelvl2;
		img3 = manager.GetComponent<Levelinfo> ().Imagelvl3;

		updatedP = false;
		updatedS = true;
		/*if(number%6==1)
			newSprite1 = manager.GetComponent<Levelinfo> ().level1[lvl-1];
		else if(number%6==2)
		newSprite2 = manager.GetComponent<Levelinfo> ().level2;
		else if(number%6==3)
		newSprite3 = manager.GetComponent<Levelinfo> ().level3;
*/
		//int.TryParse(gameObject.GetComponent<ImageTargetBehaviour> ().ImageTarget.Name,out number);
		number=gameObject.GetComponent<validate> ().number;
	}
	
	// Update is called once per frame
	void Update () {
		//newSprite = Resources.Load ("img1") as Sprite;

		if (gameObject.GetComponent<DefaultTrackableEventHandler> ().flag == 0) {
			if (manager.GetComponent<Levelinfo> ().nothing == 0) {
				text.SetActive (false);
				q1.SetActive (false);
				q2.SetActive (false);
				if (number%5 == 1) {
					//Debug.Log ("img");
					img1.SetActive (false);
				}
				else if (number%5 == 2) {
					//Debug.Log ("img");
					img2.SetActive (false);
				}
				else if (number%5 == 3) {
					//Debug.Log ("img");
					img3.SetActive (false);
				}
			}
			if (gameObject.GetComponent<validate> ().allow == 1) {
				if (!updatedS) {
					manager.GetComponent<Levelinfo> ().nothing -= 1;
					updatedS = true;
					updatedP = false;
				}
			}
		} else {
			if (!updatedP) {
				
				if (gameObject.GetComponent<validate> ().allow == 1) {
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

			}

			if (gameObject.GetComponent<validate> ().allow == 1) {
				//Debug.Log ("aaa");
				//Debug.Log ("eterred "+number);
				//manager.GetComponent<Levelinfo>().Imagelvl1.GetComponent<UnityEngine.UI.Image>().sprite= manager.GetComponent<Levelinfo> ().level1[number/6];
				if (number % 6 == 1) {
					//Debug.Log ("imgm3");		
					img1.SetActive (true);
					Debug.Log (number / 6);
					manager.GetComponent<Levelinfo> ().imagewala = number;

				} else if (number % 6 == 2) {
					//Debug.Log ("imgm3");		
					img2.SetActive (true);
					manager.GetComponent<Levelinfo> ().imagewala = number;

				} else if (number % 6 == 3) {
					//Debug.Log ("imgm3");		
					img3.SetActive (true);
					manager.GetComponent<Levelinfo> ().imagewala = number;

				} else {
					//text.GetComponent<Text> ().text = manager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number-1];
					text.GetComponent<TypeOutScript> ().FinalText = manager.GetComponent<Levelinfo> ().clues [gameObject.GetComponent<validate> ().number - 1];
					text.GetComponent<TypeOutScript> ().On = true;
			
					text.SetActive (true);
				}
				q1.SetActive (true);
				q2.SetActive (true);
			}
		}
	}
}
