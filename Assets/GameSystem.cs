using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameSystem : MonoBehaviour
{
	private const int TileLineNum = 5;//直排方塊數量
	private const int TileColNum = 6;//橫排方塊數量
	public const float TileWidth = 1;
	public const float TileHeight = 1;
	private const float FirstTilePosX = 0;
	private const float FirstTilePosY = 0;
	private int[,] tileTable = new int[TileLineNum, TileColNum];
	private bool[,] deleteTable = new bool[TileLineNum, TileColNum];
	
	public float tapX;
	public float tapY;

	public float max_x;
	public float min_x;
	public float max_y;
	public float min_y;

	public int scr = 0;
	public int Money;
	public Sprite[] Tiles;
	public GameObject TileObj;
	public GameObject holdObj;
	public float holdPositionX;
	public float holdPositionY;
	private float z = 10f;
	private GameObject[,] tileSet;

	public int a=0;
	
	// Use this for initialization
	void Start()
	{

		SetTileSet();
		InitalizeTile();
		LeftUp();
		sumon.money = 0;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			LeftClick();
		}
		if (Input.GetMouseButton(0))
		{
			LeftDrag();
		}
		if (Input.GetMouseButtonUp(0))
		{
			LeftUp();
		}
/*    測試邊界用   
		if (holdObj.transform.position.x > 5.1f) //x軸右正左負
		{
//			a++;
		}

		if (holdObj.transform.position.x < -0.1f) 
		{
//			a++;
		}

		if (holdObj.transform.position.y > 4.1f) 
		{
//			a++;
		}

		if (holdObj.transform.position.y < -0.1f) 
		{
//			a++;
		}
*/
		//轉珠邊界
		holdObj.transform.position = new Vector3 (Mathf.Clamp (holdObj.transform.position.x, -0.1f, 5.1f)
		                                         , Mathf.Clamp (holdObj.transform.position.y, -0.1f, 4.1f), z);
	}
	
	private void LeftClick()
	{
		
		Vector3 tapPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, z);
		if (holdObj == null) {
			Collider2D col = Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (tapPoint));
			if (col != null) {
				this.holdObj = col.gameObject;
				holdPositionX = this.holdObj.transform.position.x;
				holdPositionY = this.holdObj.transform.position.y;
				holdObj.transform.position = Camera.main.ScreenToWorldPoint (tapPoint);
			}
		}
		
	}
	private void LeftDrag()
	{
		Vector3 tapPoint = Input.mousePosition;
		tapX = tapPoint.x;
		tapY = tapPoint.y;
		if (holdObj != null)
		{
			this.holdObj.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(tapPoint.x, tapPoint.y, z));
			Collider2D[] colSet = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(new Vector3(tapPoint.x, tapPoint.y, z)));
			if (colSet.Length > 1)
			{
				foreach (Collider2D col in colSet)
				{
					if (!col.gameObject.Equals(this.holdObj))
					{
						float tmpPositionX = holdPositionX;
						float tmpPositionY = holdPositionY;
						holdPositionX = col.gameObject.transform.position.x;
						holdPositionY = col.gameObject.transform.position.y;
						col.gameObject.transform.position = new Vector3(tmpPositionX, tmpPositionY, z);
					}
				}
			}
		}
	}
	private void LeftUp()
	{
		bool conFlg = true;
		if (holdObj != null)
		{
			holdObj.transform.position = new Vector3(holdPositionX, holdPositionY, z);
			holdObj = null;
		}
		SetTileSet();
		while (conFlg)
		{
			conFlg = false;
			DeleteMatchTile();
			foreach (bool deleteFlg in deleteTable)
			{
				if (deleteFlg)
				{
					conFlg = true;
					break;
				}
			}
			deleteTable = new bool[TileLineNum, TileColNum];
			tileTable = new int[TileLineNum, TileColNum];
		}
	}
	private void SetTileSet()
	{
		GameObject[,] tileSet = new GameObject[TileLineNum, TileColNum];
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				Collider2D col = Physics2D.OverlapPoint(new Vector2(FirstTilePosX + TileWidth * j, FirstTilePosY + TileHeight * i));
				if ("tile".Equals(col.tag))
				{
					tileSet[i, j] = col.gameObject;
				}
			}
		}
		
		this.tileSet = tileSet;
	}
	
	private void DeleteMatchTile()
	{
		int cnt = 0;
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				cnt = CompareHorizontal(i, j, cnt);
				cnt = CompareVertical(i, j, cnt);
			}
		}
		
		DeleteTile();
	}
	
	private int CompareHorizontal(int i, int j, int cnt)
	{
		if (j + 1 < TileColNum)
		{
			Sprite nowSprite = GetSprite(this.tileSet[i, j]);
			Sprite nextSprite = GetSprite(this.tileSet[i, j + 1]);
			if (nowSprite.Equals(nextSprite))
			{
				if (tileTable[i, j] > 0)
				{
					tileTable[i, j + 1] = tileTable[i, j];
				}
				else
				{
					int cntInTile = ReCompareHorizontal(i, j, nowSprite);
					if (cntInTile > 0)
					{
						tileTable[i, j] = cntInTile;
						tileTable[i, j + 1] = cntInTile;
					}
					else
					{
						cnt++;
						tileTable[i, j] = cnt;
						tileTable[i, j + 1] = cnt;
					}
				}
			}
		}
		return cnt;
	}
	
	private int ReCompareHorizontal(int i, int j, Sprite baseSprite)
	{
		int result = 0;
		if (j + 1 < TileColNum)
		{
			Sprite nextSprite = GetSprite(this.tileSet[i, j + 1]);
			if (baseSprite.Equals(nextSprite))
			{
				if (tileTable[i, j + 1] > 0)
				{
					result = tileTable[i, j + 1];
				}
				else
				{
					result = ReCompareHorizontal(i, j + 1, baseSprite);
				}
			}
			else
			{
				result = 0;
			}
		}
		else
		{
			result = 0;
		}
		return result;
	}
	
	private int CompareVertical(int i, int j, int cnt)
	{
		for (int k = 1; i + k < TileLineNum; k++)
		{
			Sprite nowSprite = GetSprite(this.tileSet[i, j]);
			Sprite nextSprite = GetSprite(this.tileSet[i + k, j]);
			if (nowSprite.Equals(nextSprite))
			{
				if (tileTable[i, j] > 0)
				{
					tileTable[i + k, j] = tileTable[i, j];
				}
				else
				{
					cnt++;
					tileTable[i, j] = cnt;
					tileTable[i + k, j] = cnt;
				}
			}
			else
			{
				break;
			}
		}
		
		return cnt;
	}
	
	private Sprite GetSprite(GameObject obj)
	{
		SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();
		return renderer.sprite;
	}
	
	private void DeleteTile()
	{
		SetDeleteTileSet();
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				if (deleteTable[i, j])
				{
					Destroy(this.tileSet[i, j]);
					sumon.money = sumon.money + 3;
				}
			}
		}
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				if (deleteTable[i, j])
				{
					tileSet[i, j] = null;
				}
			}
		}
		FallTile();
		RecreateTile();
	}
	
	private void SetDeleteTileSet()
	{
		scr = 0;
		for (int i = 0; i < TileLineNum; i++)
		{
			
			int cnt = 1;
			for (int j = 1; j < TileColNum; j++)
			{
				
				if (tileTable[i, j] != 0 && tileTable[i, j - 1] == tileTable[i, j])
				{
					cnt++;
					if (j == TileColNum - 1)
					{
						if (cnt > 2)
						{
							scr =( tileTable[i, j]+1)*10;
							for (int k = 0; k < cnt; k++)
							{
								deleteTable[i, j - k] = true;
							}
						}
						cnt = 1;
					}
				}
				else
				{
					if (cnt > 2)
					{
						for (int k = 1; k <= cnt; k++)
						{
							deleteTable[i, j - k] = true;
						}
					}
					cnt = 1;
				}
			}
		}
		
		for (int i = 0; i < TileColNum; i++)
		{
			int cnt = 1;
			for (int j = 1; j < TileLineNum; j++)
			{
				if (tileTable[j, i] != 0 && tileTable[j - 1, i] == tileTable[j, i])
				{
					cnt++;
					if (j == TileLineNum - 1)
					{
						if (cnt > 2)
						{
							for (int k = 0; k < cnt; k++)
							{
								deleteTable[j - k, i] = true;
							}
						}
						cnt = 1;
					}
				}
				else
				{
					if (cnt > 2)
					{
						for (int k = 1; k <= cnt; k++)
						{
							deleteTable[j - k, i] = true;
						}
					}
					cnt = 1;
				}
			}
		}
	}
	
	private void FallTile()
	{
		for (int i = 0; i < TileColNum; i++)
		{
			for (int j = 1; j < TileLineNum; j++)
			{
				if (tileSet[j - 1, i] == null && tileSet[j, i] != null)
				{
					GameObject obj = tileSet[j, i].gameObject;
					obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y - TileHeight, z);
					tileSet[j - 1, i] = obj;
					tileSet[j, i] = null;
					j = 0;
				}
			}
		}
	}
	
	private void RecreateTile()
	{
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				if (tileSet[i, j] == null)
				{
					GameObject tile = (GameObject)Instantiate(TileObj);
					SpriteRenderer renderer = tile.gameObject.GetComponent<SpriteRenderer>();
					renderer.sprite = Tiles[Random.Range(0, 5)];
					Vector3 pos = new Vector3(FirstTilePosX + TileWidth * j, FirstTilePosY + TileHeight * i, z);
					tile.transform.position = pos;
					tileSet[i, j] = tile;
				}
			}
		}
	}
	
	private void InitalizeTile()
	{
		for (int i = 0; i < TileLineNum; i++)
		{
			for (int j = 0; j < TileColNum; j++)
			{
				GameObject tile = tileSet[i, j];
				SpriteRenderer renderer = tile.gameObject.GetComponent<SpriteRenderer>();
				renderer.sprite = Tiles[Random.Range(0, 5)];
			}
		}
	}
}