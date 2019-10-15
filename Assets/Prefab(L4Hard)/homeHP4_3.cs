using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP4_3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle4_3.castleHP4_3.ToString();  
	}
}
