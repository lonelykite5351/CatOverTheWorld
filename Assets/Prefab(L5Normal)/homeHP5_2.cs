using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP5_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle5_2.castleHP5_2.ToString();  
	}
}
