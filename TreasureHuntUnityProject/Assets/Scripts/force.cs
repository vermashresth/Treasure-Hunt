using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {
	float V;
	// Use this for initialization
	void Start () {
		Invoke ("des", 5f);
		V = Random.Range(25f,30f);
	}
	void des(){
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0, 0,V * Time.deltaTime);
		V += 10f*Time.deltaTime;
	}
}
