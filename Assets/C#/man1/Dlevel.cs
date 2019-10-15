using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Dlevel : MonoBehaviour {
	
	static public int DLV=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "等級: "+ DLV.ToString();  
	}
}