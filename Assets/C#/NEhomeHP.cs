/*
using UnityEngine;
using System.Collections;

public class NEhomeHP : MonoBehaviour {
	
	
	static public int HP=20;
	
	public GameObject D;
	
	
	
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
			D.SetActive(true);
			EVILCASTLE.Lmoney=EVILCASTLE.Lmoney+200;
		}
	}
}
*/