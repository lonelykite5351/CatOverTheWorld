using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class evilhomeHP2_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = EVILCASTLE2_1.HP.ToString();  
	}
}
