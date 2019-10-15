using UnityEngine;
using System.Collections;

public class hardEHP : MonoBehaviour {
	
	
	static public int HEATK = 3;
	int HEHP=3;
	
	void update()
	{
		
	}
	
	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "Alpaca(Clone)"&&HEHP>0) 
		{
			transform.Translate(-2,0.2f,0);
			
			HEHP=HEHP-Dattack.DATK;
			
			
			
			
		} 
		if (col.gameObject.name == "bullet(Clone)"&&HEHP>0) 
		{
			transform.Translate(-2,0.2f,0);
			
			HEHP=HEHP-Cattack.CATK;
			
			
			
			
		} 
		if (col.gameObject.name == "HOME"&&HEHP>0) 
		{
			transform.Translate(-1,0.2f,0);
			
			castle.castleHP=castle.castleHP-EVILHP.EATK;
			
			
			
			
		} 
		if(HEHP==0)
		{
			Destroy (gameObject);
		}
	}
}
