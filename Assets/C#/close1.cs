using UnityEngine;
using System.Collections;

public class close1 : MonoBehaviour {

	
	public GameObject a,b,c,d;
	
	public void level1button () {
		
		b.SetActive (false);
		c.SetActive (false);
		a.SetActive (false);
		d.SetActive (false);
	}
}
