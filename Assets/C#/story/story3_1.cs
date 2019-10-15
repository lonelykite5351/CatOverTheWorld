using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;//從script到playmaker必加

public class story3_1 : MonoBehaviour {
	
	//設置故事內容
	private string[] mData={"\n1592年","\n看來我們的日本盟\n友想要進攻朝鮮喵","\n按照史實紀載中國\n明朝會派軍支援朝\n鮮喵",
		"\n如果能在此時擊敗\n中國必能對我們的\n未來有巨大的影響\n喵","\n讓我們為了日本盟\n友和未來進攻中國\n吧喵！"};
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
				Application.LoadLevelAsync ("L3Easy");
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