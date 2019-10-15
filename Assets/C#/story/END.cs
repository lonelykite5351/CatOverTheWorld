using UnityEngine;
using System.Collections;

public class END : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.transform.position += new Vector3(0,1,0);
	}
}
