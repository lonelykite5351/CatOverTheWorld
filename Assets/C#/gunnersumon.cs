using UnityEngine;
using System.Collections;

public class gunnersumon : MonoBehaviour {
	public GameObject gunner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void aaa () {
		if (sumon.money >= 30)
		{
			sumon.money -= 30;
			Instantiate (GameObject.Find ("gunner"), transform.position = new Vector3 (11, 9, 0), transform.rotation);
		}
	}
}
