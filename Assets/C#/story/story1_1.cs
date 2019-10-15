using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;//從script到playmaker必加

public class story1_1 : MonoBehaviour {
	
	//設置故事內容
	private string[] mData={"\n喵呼呼呼呼","\n這項武器竟然運作\n成功了喵","\n可惡的盟軍","\n我會在你們還在使\n用舊科技時一一擊\n敗你們喵",
		"\n按照時空儀上顯示\n現在是1562年的法\n國","\n看來法國宗教戰爭\n正要開打喵","\n這是一個殲滅法國\n的好機會喵！","\n納粹精銳士兵們!","\n進攻法國！",
		"\n趁他們忙於自取滅\n亡時一鼓作氣殲滅\n他們喵！"};
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
				Application.LoadLevelAsync ("L1Easy");
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