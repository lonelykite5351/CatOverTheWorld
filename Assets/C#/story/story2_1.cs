using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;//從script到playmaker必加

public class story2_1 : MonoBehaviour {
	
	//設置故事內容
	private string[] mData={"\n法國真是不堪一擊\n喵","\n下一個目標就是英\n國了喵","\n喵呼呼呼","\n看來1588年的英國\n和西班牙會有精彩\n的海上衝突喵",
		"\n我等可以在英國回\n航時進攻他們疲勞\n的艦隊","\n這樣就可以順利地\n擊敗英國了喵","\n只要擊敗英國","\n美國也不存在了喵\n！","\n時空轉換儀啟動\n喵！",
		"\n讓我們前往1588\n年的英國喵！"};
	//当前對話索引
	private int index=0;
	//顯示對話的 TextMesh
	public TextMesh mText;
	//對話標示貼圖
	public Texture mTalkIcon;
	//是否顯示對話貼圖
	private bool isTalk=false;
	
	void Update ()
	{
		
		isTalk=true;
		//允許繪製
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			//列出本文
			if(index<mData.Length)
			{
				mText.text="希特勒貓：" + mData[index];
				index=index+1;
			}else
			{
				Application.LoadLevelAsync ("L2Easy");
			}
			/*else
					{
						index=0;
						mText.text="NPC:"+mData[index];
					}*/
		}
	}
	
	/*void OnGUI()
	{
		if(isTalk)
		{
			//禁用原始滑鼠貼圖
			Cursor.visible=false;
			Rect mRect=new Rect(Input.mousePosition.x-mTalkIcon.width,
			                    Screen.height-Input.mousePosition.y-mTalkIcon.height,
			                    mTalkIcon.width,mTalkIcon.height);
			//自定義滑鼠貼圖
			GUI.DrawTexture(mRect,mTalkIcon);
		}
		
	}*/
}