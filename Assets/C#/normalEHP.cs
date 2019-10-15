using UnityEngine;
using System.Collections;

public class normalEHP : MonoBehaviour {
	

	static public int NEATK = 2;
	int NEHP=2;

	void update()
	{

	}

	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "Alpaca(Clone)"&&NEHP>0) 
		{
			transform.Translate(-2,0.2f,0);
			
			NEHP=NEHP-Dattack.DATK;


			
			
		} 
		if (col.gameObject.name == "bullet(Clone)"&&NEHP>0) 
		{
			transform.Translate(-2,0.2f,0);
			
			NEHP=NEHP-Cattack.CATK;

			
			
			
		} 
		if (col.gameObject.name == "HOME"&&NEHP>0) 
		{
			transform.Translate(-1,0.2f,0);
			
			castle.castleHP=castle.castleHP-EVILHP.EATK;
			
			
			
			
		} 
		if(NEHP==0)
		{
			Destroy (gameObject);
		}
	}
}
