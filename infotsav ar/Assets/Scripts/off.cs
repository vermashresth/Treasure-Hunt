using UnityEngine;
using System.Collections;
using Vuforia;
public class off : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.GetComponentInParent<DefaultTrackableEventHandler>().flag==1){
		if ((gameObject.GetComponentInParent<rig> ().i + 1).ToString() == (gameObject.name [1]).ToString()) {
			gameObject.GetComponentInChildren<MeshRenderer> ().enabled = true;
		}
		else
			gameObject.GetComponentInChildren<MeshRenderer> ().enabled = false;
		//Debug.Log (gameObject.GetComponentInParent<rig> ().i + 1);
		//Debug.Log (gameObject.name [1]);
		}
	}
}
