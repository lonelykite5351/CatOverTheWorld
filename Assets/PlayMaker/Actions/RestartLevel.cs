// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.
// micro script by Andrew Raphael Lukasik

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Level)]
	[Tooltip("Restarts current level.")]
	public class RestartLevel : FsmStateAction
	{
		/*原本只有這一串
	    public override void OnEnter()
	    {
		    Application.LoadLevel(Application.loadedLevelName);
	        Finish();
	    }
	    */

		public override void Reset(){}//多加這一行
		public override void OnEnter()	
		{
			Application.LoadLevel(Application.loadedLevelName);	
		}
	}
}