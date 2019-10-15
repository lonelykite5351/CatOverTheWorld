using UnityEngine;
using System.Collections;

public class EVILHP : MonoBehaviour {


	static public int EATK = 1;
	int HP=1;

	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "Alpaca(Clone)"&&HP>0) 
		{
			transform.Translate(-1,0.2f,0);
			
			HP=HP-Dattack.DATK;

			
			
			
		} 
		if (col.gameObject.name == "bullet(Clone)"&&HP>0) 
		{
			transform.Translate(-1,0.2f,0);
			
			HP=HP-Cattack.CATK;
			
			
			
			
		} 
		if (col.gameObject.name == "HOME"&&HP>0) 
		{
			transform.Translate(-1,0.2f,0);
			
			castle.castleHP=castle.castleHP-EATK;
			
			
			
			
		} 
		if(HP==0)
		{
			Destroy (gameObject);
		}
	}
}
