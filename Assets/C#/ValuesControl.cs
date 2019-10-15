using UnityEngine;
using System.Collections;

public class ValuesControl : MonoBehaviour {

	// Use this for initialization
	static public float Money = 0;
	static public float Money1_2 = 0;
	static public float HomeHP;//這一行沒用到不要管它，我設好玩的
	static public float EvilHomeHP;//這一行沒用到不要管它，我設好玩的

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SetMoney()
	{
		ValuesControl.Money = 0;
	}

	public void reloadL1Easy()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle.castleHP = 10;
		EVILCASTLE.HP = 10;
	}

	public void reloadL1Normal()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle1_2.castleHP1_2 = 10;
		EVILCASTLE1_2.HP = 20;
	}

	public void reloadL1Hard()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle1_3.castleHP1_3 = 10;
		EVILCASTLE1_3.HP = 30;
	}

	public void reloadL2Easy()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle2_1.castleHP2_1 = 20;
		EVILCASTLE2_1.HP = 15;
	}

	public void reloadL2Normal()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle2_2.castleHP2_2 = 20;
		EVILCASTLE2_2.HP = 30;
	}

	public void reloadL2Hard()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle2_3.castleHP2_3 = 20;
		EVILCASTLE2_3.HP = 45;
	}

	public void reloadL3Easy()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle3_1.castleHP3_1 = 30;
		EVILCASTLE3_1.HP = 20;
	}

	public void reloadL3Normal()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle3_2.castleHP3_2 = 30;
		EVILCASTLE3_2.HP = 40;
	}

	public void reloadL3Hard()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle3_3.castleHP3_3 = 30;
		EVILCASTLE3_3.HP = 60;
	}

	public void reloadL4Easy()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle4_1.castleHP4_1 = 40;
		EVILCASTLE4_1.HP = 25;
	}

	public void reloadL4Normal()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle4_2.castleHP4_2 = 40;
		EVILCASTLE4_2.HP = 50;
	}

	public void reloadL4Hard()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle4_3.castleHP4_3 = 40;
		EVILCASTLE4_3.HP = 75;
	}

	public void reloadL5Easy()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle5_1.castleHP5_1 = 50;
		EVILCASTLE5_1.HP = 30;
	}

	public void reloadL5Normal()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle5_2.castleHP5_2 = 50;
		EVILCASTLE5_2.HP = 60;
	}

	public void reloadL5Hard()//拿來給FSM重設數值
	{
		Application.LoadLevel (Application.loadedLevelName);
		ValuesControl.Money = 0;
		castle5_3.castleHP5_3 = 50;
		EVILCASTLE5_3.HP = 100;
	}

	public void win()//拿來給FSM重設數值
	{
		EVILCASTLE.HP = 0;
		EVILCASTLE1_2.HP = 0;
		EVILCASTLE1_3.HP = 0;
		EVILCASTLE2_1.HP = 0;
		EVILCASTLE2_2.HP = 0;
		EVILCASTLE2_3.HP = 0;
		EVILCASTLE3_1.HP = 0;
		EVILCASTLE3_2.HP = 0;
		EVILCASTLE3_3.HP = 0;
		EVILCASTLE4_1.HP = 0;
		EVILCASTLE4_2.HP = 0;
		EVILCASTLE4_3.HP = 0;
		EVILCASTLE5_1.HP = 0;
		EVILCASTLE5_2.HP = 0;
		EVILCASTLE5_3.HP = 0;
	}
	public void lose()//拿來給FSM重設數值
	{
		castle.castleHP = 0;
		castle1_2.castleHP1_2 = 0;
		castle1_3.castleHP1_3 = 0;
		castle2_1.castleHP2_1 = 0;
		castle2_2.castleHP2_2 = 0;
		castle2_3.castleHP2_3 = 0;
		castle3_1.castleHP3_1 = 0;
		castle3_2.castleHP3_2 = 0;
		castle3_3.castleHP3_3 = 0;
		castle4_1.castleHP4_1 = 0;
		castle4_2.castleHP4_2 = 0;
		castle4_3.castleHP4_3 = 0;
		castle5_1.castleHP5_1 = 0;
		castle5_2.castleHP5_2 = 0;
		castle5_3.castleHP5_3 = 0;
	}

	public void HomeHPP_1()
	{
		castle.castleHP -= 1;
	}

}
