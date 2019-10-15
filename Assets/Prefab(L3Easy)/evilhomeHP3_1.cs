using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class evilhomeHP3_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = EVILCASTLE3_1.HP.ToString();  
	}
}
