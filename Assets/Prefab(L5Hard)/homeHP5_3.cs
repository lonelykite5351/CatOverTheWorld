using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class homeHP5_3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = castle5_3.castleHP5_3.ToString();  
	}
}
