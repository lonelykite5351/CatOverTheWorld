using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP2_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle2_1.castleHP2_1.ToString();  
	}
}
