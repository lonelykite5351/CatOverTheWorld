using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP5_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle5_1.castleHP5_1.ToString();  
	}
}
