using UnityEngine;
using System.Collections;

public class castle1_2 : MonoBehaviour {

	static public int castleHP1_2=10;
	/*
	public void OnCollisionEnter2D(Collision2D  col)
	{
		if (col.gameObject.name == "evil(Clone)") 
		{
			Destroy (GameObject.Find("evil(Clone)"));
		} 
		if(castleHP1_2==0)
		{
			Destroy (GameObject.Find("HOME"));
		}
	}
*/
	public void CastleHPP()
	{
		castle1_2.castleHP1_2 -= 2;
	}
}
