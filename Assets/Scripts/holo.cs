using UnityEngine;
using System.Collections;

public class holo : MonoBehaviour {
	public int matIndex=0;
	public Vector2 AnimRate=new Vector2(1.0f,0.0f);
	public string textname="_MainTex";
	Vector2 off=Vector2.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		off += (AnimRate * Time.deltaTime);
		Renderer r = gameObject.GetComponent<Renderer>();
		if (r.enabled)
			r.materials [matIndex].SetTextureOffset (textname, off);
	}
}
