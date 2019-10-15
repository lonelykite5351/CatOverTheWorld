using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	int HP=Dhealth.DHP;


	public void OnCollisionEnter2D(Collision2D  col)
	{
		 
		
		if (col.gameObject.name == "evil(Clone)"&&HP>0) 
		{
				transform.Translate(2,0.5f,0);
			HP=HP-EVILHP.EATK;
				
				


		} 
		if(HP==0)
		{
			Destroy (gameObject);
		}
	}
}
