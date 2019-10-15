using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class MoneyText : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Text>().text = ValuesControl.Money.ToString();  
	}
}