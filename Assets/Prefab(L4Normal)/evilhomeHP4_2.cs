﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class evilhomeHP4_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = EVILCASTLE4_2.HP.ToString();  
	}
}
