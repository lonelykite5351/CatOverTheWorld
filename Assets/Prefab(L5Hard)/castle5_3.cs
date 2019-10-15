using UnityEngine;
using System.Collections;

public class castle5_3 : MonoBehaviour {

	static public int castleHP5_3=50;
/*
	public void OnCollisionEnter2D(Collision2D  col)
	{
		if (col.gameObject.name == "evil2_1(Clone)") 
		{
			Destroy (GameObject.Find("evil2_1(Clone)"));
			castle2_1.castleHP2_1 -= 2;
		} 
		if(castleHP2_1==0)
		{
			Destroy (GameObject.Find("HOME"));
		}
	}
*/
	public void CastleHPP_20()
	{
		castle5_3.castleHP5_3 -= 20;
	}
}
