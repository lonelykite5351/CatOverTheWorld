using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP4_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle4_1.castleHP4_1.ToString();  
	}
}
