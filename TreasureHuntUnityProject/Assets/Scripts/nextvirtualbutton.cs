using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class nextvirtualbutton : MonoBehaviour,IVirtualButtonEventHandler {
	public GameObject textlayer;
	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			// Register with the virtual buttons TrackableBehaviour
			vbs[i].RegisterEventHandler(this);
	}
	}
	
	// Update is called once per frame
	
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		if (vb.VirtualButtonName == "Next") {
			textlayer.GetComponent<Text> ().text = "Button is \n pressed";
			Debug.Log ("pressed");
		}
		
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
	}

}
