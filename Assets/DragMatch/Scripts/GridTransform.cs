using UnityEngine;
using System.Collections;

public class GridTransform : MonoBehaviour {

	public GameObject GridOBJ;

	// Use this for initialization
	void Start () {
		GridOBJ.transform.position = new Vector3 (20.9f, 2.8f,11.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
