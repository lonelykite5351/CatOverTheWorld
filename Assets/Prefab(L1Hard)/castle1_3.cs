using UnityEngine;
using System.Collections;

public class castle1_3 : MonoBehaviour {

	static public int castleHP1_3=10;
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
		castle1_3.castleHP1_3 -= 4;
	}
}
