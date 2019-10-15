using UnityEngine;
using System.Collections;

public class DestoryControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EvilAttackSumon ()
	{
		Destroy (GameObject.Find("Sumon(Clone)"));
	}

	public void EvilAttackGunner ()
	{
		Destroy (GameObject.Find("Gunner(Clone)"));
	}

	public void EvilAttackGunnerLV2 ()
	{
		Destroy (GameObject.Find("GunnerLV2(Clone)"));
	}

	public void EvilAttackGunnerLV3 ()
	{
		Destroy (GameObject.Find("GunnerLV3(Clone)"));
	}

	public void GunnerAttackEvil1_3 ()
	{
		Destroy (GameObject.Find("evil1_3(Clone)"));
	}

	public void BulletDrstory ()
	{
		Destroy (GameObject.Find("bullet(playmaker)(Clone)"));
	}

	public void EvilHomeAttackGunner ()
	{
		Destroy (GameObject.Find("bullet(playmaker)(Clone)"));
	}

	public void EvilHomeAttackSumonLV2 ()
	{
		Destroy (GameObject.Find("SumonLV2(Clone)"));
	}

	public void EvilHomeAttackSumonLV3 ()
	{
		Destroy (GameObject.Find("SumonLV3(Clone)"));
	}
}
