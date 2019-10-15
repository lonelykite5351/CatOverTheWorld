using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Chealth : MonoBehaviour {
	
	static public int CHP=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "血量: "+ CHP.ToString();  
	}
}