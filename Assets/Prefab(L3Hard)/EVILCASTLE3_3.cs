﻿using UnityEngine;
using System.Collections;

public class EVILCASTLE3_3 : MonoBehaviour {
	
	static public int HP=60;
/*	
	public GameObject C;
	
	static public int Lmoney;
	
	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "bullet(playmaker)") 
		{
			

			HP=HP-Cattack.CATK;
			Destroy (GameObject.Find("bullet(playmaker)"));
			
		} 
		if (col.gameObject.name == "Alpaca(Clone)") 
		{
			
			
			HP=HP-Dattack.DATK;
			Destroy (GameObject.Find("Alpaca(Clone)"));
			
		} 
		if(HP==0)
		{
			Destroy (GameObject.Find("EVILHOME"));
			C.SetActive(true);
			Lmoney=Lmoney+100;
		}
	}
*/
	public void EvilHomeHPP()
	{
		EVILCASTLE3_3.HP -= 1;
	}

	public void EvilHomeHPP_2()
	{
		EVILCASTLE3_3.HP -= 2;
	}

	public void EvilHomeHPP_3()
	{
		EVILCASTLE3_3.HP -= 3;
	}

	public void EvilHomeHPP_4()
	{
		EVILCASTLE3_3.HP -= 4;
	}

	public void EvilHomeHPP_5()
	{
		EVILCASTLE3_3.HP -= 5;
	}

	public void EvilHomeHPP_6 ()
	{
		EVILCASTLE3_3.HP -= 6;
	}
	
	public void EvilHomeHPP_8 ()
	{
		EVILCASTLE3_3.HP -= 8;
	}
	
	public void EvilHomeHPP_10 ()
	{
		EVILCASTLE3_3.HP -= 10;
	}
}
