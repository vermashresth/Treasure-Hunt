using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Levelinfo : MonoBehaviour {
	public string[] clues;
	public int nothing;
	public GameObject leveltext;
	//public Sprite[] level1,level2,level3;
	public GameObject Imagelvl1,Imagelvl2,Imagelvl3;
	public int imagewala;
	// Use this for initialization
	void Start () {
		imagewala = -1;
		nothing = 0;
		clues = new string[] {"","","", "A van is needed going this way \n" +
			"A tarmac play of bay by bay\n" +
			"Now is the time to slow your stride\n" +
			"Make sure you station your ride\n",

			"This is surrounded by concrete\n" +
			"Where we are celebrating the feast\n" +
			"Clatter and Clamour\n" +
			"Bask in glory and Glamour\n",

			"Reach the venue where you \n" +
			"played Muggle Quidditch yesterday\n" +
			"Where a task awaits you",


			"","","", "A court  full of love\n" +
			"With sphere from above\n" +
			"The place to you must get\n" +
			"Is split with a low net\n",

			"This is surrounded by concrete\n" +
			"Where we are celebrating the feast\n" +
			"Clatter and Clamour\n" +
			"Bask in glory and Glamour\n",

			"Reach the venue where you \n" +
			"played Muggle Quidditch yesterday\n" +
			"Where a task awaits you",


			"","","", "Old memories were already made \n" +
			"Sitting on the chairs \n" +
			"Now new memories will be made\n" +
			"You must know where\n",

			"This is surrounded by concrete\n" +
			"Where we are celebrating the feast\n" +
			"Clatter and Clamour\n" +
			"Bask in glory and Glamour\n",

			"Reach the venue where you \n" +
			"played Muggle Quidditch yesterday\n" +
			"Where a task awaits you",


			"","","", "To solve the hunt you must get\n" +
			"In the room wired to the rest\n" +
			"Crammed with tech and full of code\n" +
			"The clue is hidden in this abode\n",

			"This is surrounded by concrete\n" +
			"Where we are celebrating the feast\n" +
			"Clatter and Clamour\n" +
			"Bask in glory and Glamour\n",

			"Reach the venue where you \n" +
			"played Muggle Quidditch yesterday\n" +
			"Where a task awaits you",

			"","","", "Open sky, green pasture\n" +
			"Sit for leisure\n" +
			"Run for a game\n" +
			"That need Iron pane\n",

			"This is surrounded by concrete\n" +
			"Where we are celebrating the feast\n" +
			"Clatter and Clamour\n" +
			"Bask in glory and Glamour\n",

			"Reach the venue where you \n" +
			"played Muggle Quidditch yesterday\n" +
			"Where a task awaits you",

			};
		if(!PlayerPrefs.HasKey("story"))
		{
			PlayerPrefs.SetInt ("story", -1);
		}

		if (!PlayerPrefs.HasKey ("level")) {
			PlayerPrefs.SetInt ("level", 0);
		}
		//PlayerPrefs.SetInt ("story", -1);
		//PlayerPrefs.SetInt ("level", 0);
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (PlayerPrefs.GetInt ("story"));
		//Debug.Log (PlayerPrefs.GetInt ("level"));
		leveltext.GetComponent<Text> ().text = "level " + (PlayerPrefs.GetInt ("level") ).ToString ();
	}
}

