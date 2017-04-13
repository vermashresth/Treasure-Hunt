using UnityEngine;
using System.Collections;
using Vuforia;
public class rig : MonoBehaviour {
	public GameObject sp1, sp2;
	public int i;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating("incr",0f,.2f);
		i = 0;
	}
	void incr(){
		if (gameObject.GetComponentInParent<DefaultTrackableEventHandler> ().flag == 1) {
			i += 1;
			i %= 5;
			if (i == 0)
				Invoke ("in1", Random.Range (0f, 3f));
			if (i == 4)
				Invoke ("in2", Random.Range (0f, 3f));
		}
	}
	void in1(){
		Instantiate (sp1);
	}
	void in2(){
		Instantiate (sp2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
