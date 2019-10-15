using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Dhealth : MonoBehaviour {
	
	static public int DHP=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "血量: "+ DHP.ToString();  
	}
}