using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelClick : MonoBehaviour {
public GameObject [] block;
public TextMesh num;
private int px;
private int py;
public Transform gameOBJ;

void Start()
{
px = (int)this.transform.position.x;
py = (int)this.transform.position.y;
BlockInsta();

}
void BlockInsta()
    {
        if(Test2.panelG[px,py]==0)
        {
            Instantiate(block[0], new Vector3(px,py,0), Quaternion.identity,gameOBJ.transform);
        }
        if(Test2.panelG[px,py]==1)
        {
            Instantiate(block[1], new Vector3(px,py,0), Quaternion.identity,gameOBJ.transform);
        }
        if(Test2.panelG[px,py]==2)
        {
            Instantiate(block[2], new Vector3(px,py,0), Quaternion.identity,gameOBJ.transform);
        }  
    }
public void Click()
    {
    int blockNo = Test2.panelG[px,py];
    int blockCount = 1;
    int check = 1;
    Test2.panelG[px,py] += 10;
    Check(check,blockCount,blockNo);
        //for(check = 1; check < Test2.panelMax; check++)
        //{
            
       // }
        
    }
    
void Check(int check , int blockCount,int blockNo)
{
            if(py+check < Test2.panelMax && Test2.panelG[px,py+check] == blockNo)
            {
                Test2.panelG[px,py+check] += 10;
                blockCount += 1;
                Check(check,blockCount,blockNo);
            }
            if(py-check >= 0 && Test2.panelG[px,py-check] == blockNo)
            {
                Test2.panelG[px,py-check] += 10;
                blockCount += 1;
                Check(check,blockCount,blockNo);
            }
            
            if(px+check < Test2.panelMax && Test2.panelG[px+check,py] == blockNo)
            {
                Test2.panelG[px+check,py] += 10;
                blockCount += 1;
                Check(check,blockCount,blockNo);
            }
            if(px-check >= 0  && Test2.panelG[px-check,py] == blockNo)
            {
                Test2.panelG[px-check,py] += 10;
                blockCount += 1;
                Check(check,blockCount,blockNo);
            }
}
void Update()
{

//テスト用
num.text = Test2.panelG[px,py].ToString();

//ブロック削除
if(Test2.panelG[px,py] >= 10)
{
    foreach (Transform child in gameOBJ.transform)
        {
            Destroy(child.gameObject);
        }
}
}

}

/*
Test2.panelG[px,py] = 99;
foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
*/