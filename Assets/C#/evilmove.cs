using UnityEngine;
using System.Collections;

public class evilmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0.03f,0,0);

	}
}
