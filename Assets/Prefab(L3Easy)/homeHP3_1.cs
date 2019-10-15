using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP3_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle3_1.castleHP3_1.ToString();  
	}
}
