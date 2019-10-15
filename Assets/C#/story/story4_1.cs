using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;//從script到playmaker必加

public class story4_1 : MonoBehaviour {
	
	//設置故事內容
	private string[] mData={"\n1602年","\n荷蘭創立了東印度\n公司喵？","\n歐洲現在已經是我\n的了喵",
		"\n別想往海外發展喵\n","\n讓我們進攻荷蘭摧\n毀東印度公司吧喵\n！"};
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
				Application.LoadLevelAsync ("L4Easy");
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