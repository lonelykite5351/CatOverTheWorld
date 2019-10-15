using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP1_3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle1_3.castleHP1_3.ToString();  
	}
}
