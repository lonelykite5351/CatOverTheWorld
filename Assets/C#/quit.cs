﻿/*using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
	// public
	public int windowWidth = 400;
	public int windowHight = 150;
	
	// private
	Rect windowRect ;
	int windowSwitch = 0;
	float alpha = 0;
	
	void GUIAlphaColor_0_To_1 ()
	{
		if (alpha < 1) {
			alpha += Time.deltaTime;
			GUI.color = new Color (1, 1, 1, alpha);
		}
	}
	
	// Init
	void Awake ()
	{
		windowRect = new Rect (
			(Screen.width - windowWidth) / 2,
			(Screen.height - windowHight) / 2,
			windowWidth,
			windowHight);
	}
	
	void Update ()
	{
		if (castle.castleHP==0||Input.GetKeyDown ("escape")) {
			windowSwitch = 1;
			alpha = 0; // Init Window Alpha Color
		}
	}
	
	void OnGUI ()
	{
		if (windowSwitch == 1) {

			windowRect = GUI.Window (0, windowRect, QuitWindow, "Quit Window");
		}
	}
	
	void QuitWindow (int windowID)
	{
		GUI.Label (new Rect (100, 50, 300, 30), "             你死了(新細明體");
		
		if (GUI.Button (new Rect (80, 110, 100, 20), "離開")) {
			Application.LoadLevel("level") ;
		}
		if (GUI.Button (new Rect (220, 110, 100, 20), "重來")) {
			Application.LoadLevel("3 match 1") ;
		}
		
		GUI.DragWindow ();
	}
	
}*/