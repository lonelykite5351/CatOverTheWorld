using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP4_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle4_2.castleHP4_2.ToString();  
	}
}
