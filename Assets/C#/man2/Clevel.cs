using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Clevel : MonoBehaviour {
	
	static public int CLV=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "等級: "+ CLV.ToString();  
	}
}