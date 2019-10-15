/*
using UnityEngine;
using System.Collections;

public class HEhomeHP : MonoBehaviour {
	
	
	static public int HP=30;
	
	public GameObject F;
	
	
	
	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "bullet(Clone)") 
		{
			
			
			HP=HP-Cattack.CATK;
			Destroy (GameObject.Find("bullet(Clone)"));
			
		} 
		if (col.gameObject.name == "Alpaca(Clone)") 
		{
			
			
			HP=HP-Dattack.DATK;
			Destroy (GameObject.Find("Alpaca(Clone)"));
			
		} 
		if(HP==0)
		{
			Destroy (GameObject.Find("EVILHOME"));
			F.SetActive(true);
			EVILCASTLE.Lmoney=EVILCASTLE.Lmoney+300;
		}
	}
}
*/