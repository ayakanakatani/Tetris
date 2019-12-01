using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelClick : MonoBehaviour {
public GameObject [] block;
public TextMesh num;
private int px;
private int py;

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
            Instantiate(block[0], new Vector3(px,py,0), Quaternion.identity,this.transform);
        }
        if(Test2.panelG[px,py]==1)
        {
            Instantiate(block[1], new Vector3(px,py,0), Quaternion.identity,this.transform);
        }
        if(Test2.panelG[px,py]==2)
        {
            Instantiate(block[2], new Vector3(px,py,0), Quaternion.identity,this.transform);
        }  
    }
public void Click()
    {
        Test2.panelG[px,py] = 99;
        
        foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }

    }
}