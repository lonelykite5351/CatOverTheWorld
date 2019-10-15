using UnityEngine;
using System.Collections;

public class castle4_3 : MonoBehaviour {

	static public int castleHP4_3=40;
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
	public void CastleHPP_12()
	{
		castle4_3.castleHP4_3 -= 12;
	}
}
