using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class evilhomeHP5_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = EVILCASTLE5_1.HP.ToString();  
	}
}
