using UnityEngine;
using System.Collections;
using Vuforia;
public class validate : MonoBehaviour {
	public int number;
	public int allow;
	public int numbOfLevels;
	// Use this for initialization
	void Start () {
		allow = 0;
		numbOfLevels = 6;

	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<DefaultTrackableEventHandler> ().flag == 1) {
			if ((PlayerPrefs.GetInt ("story") == -1) && (number % numbOfLevels == 1) && number<30) {
				PlayerPrefs.SetInt ("story", number);
				PlayerPrefs.SetInt ("level", 0);
			}
			if (number == PlayerPrefs.GetInt ("story") + PlayerPrefs.GetInt ("level") &&PlayerPrefs.GetInt ("level")<6 ) {
				allow = 1;
				PlayerPrefs.SetInt ("level", PlayerPrefs.GetInt ("level") + 1);
			}
			if (PlayerPrefs.HasKey ("story")) {
				if(number>= PlayerPrefs.GetInt("story") && number<PlayerPrefs.GetInt("story")+PlayerPrefs.GetInt("level"))
					allow=1;
			}
		}
	}
}
