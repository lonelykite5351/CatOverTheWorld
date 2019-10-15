using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle.castleHP.ToString();  
	}
}
