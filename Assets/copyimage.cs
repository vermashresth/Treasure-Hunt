using UnityEngine;
using System.Collections;

public class copyimage : MonoBehaviour {
	public GameObject manager;
	public Sprite[] level1,level2,level3;
	// Use this for initialization
	void Start () {
		
		//gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = aa [1];
	}
	
	// Update is called once per frame
	void Update () {
		if(manager.GetComponent<Levelinfo>().imagewala>-1)
		{
			int n = manager.GetComponent<Levelinfo> ().imagewala;
		if (name == "Image1") 
				gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = level1 [n / 6];
		if (name == "Image2")
				gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = level2 [n / 6];
		if (name == "Image3")
				gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = level3 [n / 6];
					}
	}
}
