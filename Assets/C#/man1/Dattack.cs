using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class Dattack : MonoBehaviour {
	
	static public int DATK=1;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = "攻擊力: "+ DATK.ToString();  
	}
}