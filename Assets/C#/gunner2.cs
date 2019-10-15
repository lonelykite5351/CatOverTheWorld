﻿using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;//從script到playmaker必加

public class gunner2 : MonoBehaviour {

	public PlayMakerFSM theFsm;
	// Use this for initialization
	void Start () {
		PlayMakerFSM[] temp = GetComponents<PlayMakerFSM>();
		foreach (PlayMakerFSM fsm in temp) {
			if (fsm.FsmName == "CreateGunner"){
				theFsm = fsm;
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		//sumon.money放進FSM裡面宣告好的變數"IntMoney"
		theFsm.FsmVariables.GetFsmFloat ("IntMoney").Value = ValuesControl.Money;

		theFsm.FsmVariables.GetFsmFloat ("IntEvilHomeHP").Value = EVILCASTLE.HP;

		theFsm.FsmVariables.GetFsmFloat ("IntHomeHP").Value = castle.castleHP;
	}

	public void gunnerMoney()
	{
		ValuesControl.Money -= 30;
	}

	public void sumonMoney()
	{
		ValuesControl.Money -= 10;
	}

	public void LightTankMoney()
	{
		ValuesControl.Money -= 100;
	}

	public void MidTankMoney()
	{
		ValuesControl.Money -= 150;
	}	

	public void BigTankMoney()
	{
		ValuesControl.Money -= 200;
	}
}
