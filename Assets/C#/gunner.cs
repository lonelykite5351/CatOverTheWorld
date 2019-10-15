using UnityEngine;
using System.Collections;

public class gunner : MonoBehaviour {


	public float CD;
	float timer;
	public float firespeed;
	public GameObject aaa;
	int YO=1;
	//获取要追踪的对象

	//敌人的检测范围
	public const int AI_ATTACK_DISTANCE =5;

	// Use this for initialization

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (YO == 1) 
		{
			move();
		}
		if(YO==0)
		{
			fire ();
			YO=1;
		}
		if(Vector3.Distance(GameObject.Find("evil(Clone)").transform.position,transform.position) < AI_ATTACK_DISTANCE)
		{

		
			YO=0;
						
		}

		if(Vector3.Distance(GameObject.Find("EVILHOME").transform.position,transform.position) < AI_ATTACK_DISTANCE)
		{
			YO=0;
			

			
			
		}


	}
	void move()
	{
		gameObject.transform.position += new Vector3 (-0.03f,0.04f,0);

	}
	void fire()
	{
		CD=1/(firespeed/100);
		if (timer > CD) {
			timer = 0;
			Instantiate (aaa, this.transform.position, this.transform.rotation);
		} else {
		
			timer=timer+Time.deltaTime;
		}
	}

	public void OnCollisionEnter2D(Collision2D  col)
	{
		
		
		if (col.gameObject.name == "evil(Clone)") 
		{
			transform.Translate(2,1,0);
			
			Destroy (gameObject);
			
			
			
		} 

	}
}
