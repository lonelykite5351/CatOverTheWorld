using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP2_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle2_2.castleHP2_2.ToString();  
	}
}
