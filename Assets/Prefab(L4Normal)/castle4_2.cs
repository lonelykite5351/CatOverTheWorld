using UnityEngine;
using System.Collections;

public class castle4_2 : MonoBehaviour {

	static public int castleHP4_2=40;
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
		castle4_2.castleHP4_2 -= 6;
	}
}
