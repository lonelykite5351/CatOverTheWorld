using UnityEngine;
using System.Collections;

public class evilsumon : MonoBehaviour {

	public GameObject evil;
	int a;

	IEnumerator Start ()
	{

		yield return StartCoroutine(run(5f));
	}
	
	IEnumerator run (float waitTime)
	{


		while (true) {

						// 每2秒執行一次
						yield return new WaitForSeconds (waitTime);
						Instantiate (GameObject.Find ("evil"), transform.position = new Vector3 (3, 9, 0), transform.rotation);

				}


	}
	
	public void Sumon ()
	{

		


		
	}




}
