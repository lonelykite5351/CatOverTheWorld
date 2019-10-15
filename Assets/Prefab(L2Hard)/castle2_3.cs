using UnityEngine;
using System.Collections;

public class castle2_3 : MonoBehaviour {

	static public int castleHP2_3=20;
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
	public void CastleHPP_6()
	{
		castle2_3.castleHP2_3 -= 6;
	}
}
