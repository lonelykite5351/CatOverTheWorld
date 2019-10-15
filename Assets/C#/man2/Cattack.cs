using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Cattack : MonoBehaviour {
	
	static public int CATK=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "攻擊力: "+ CATK.ToString();  
	}
}