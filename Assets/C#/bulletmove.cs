using UnityEngine;
using System.Collections;

public class bulletmove : MonoBehaviour {

	// Use this for initialization


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (-0.5f,0,0);




	}
	public void OnCollisionEnter2D(Collision2D  col)
	{
		if (col.gameObject.name == "evil(Clone)") 
		{			



			Destroy(gameObject);
						
		} 

	}}
