using UnityEngine;
using System.Collections;

public class castle : MonoBehaviour {

	static public int castleHP=10;

	public void OnCollisionEnter2D(Collision2D  col)
	{
		if (col.gameObject.name == "evil(Clone)") 
		{
			Destroy (GameObject.Find("evil(Clone)"));
		} 
		if(castleHP==0)
		{
			Destroy (GameObject.Find("HOME"));
		}
	}

	public void SetCastleHP()
	{
		castleHP = 10;
	}
}
