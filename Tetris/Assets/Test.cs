using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
public GameObject[] blocks;
public Transform blocksParent;
private int blockMax = 5;
private int x;
private int y ;
public static int [,] groupA;
void Start () 
    {
    int [,] groupA = new int [blockMax,blockMax];
        for( x =0; x<blockMax; x++ )
        for( y =0; y<blockMax; y++ )
            groupA[x , y] = randomNum(3);

   // BlockReLoad();
        
        for(y= 0 ; y < 5; y++)
        for(x= 0 ; x < 5; x++)
            {
                if(groupA[x,y]==0)
                {
                    Instantiate(blocks[0], new Vector3(x,y,0), Quaternion.identity,blocksParent);
                }
                if(groupA[x,y]==1)
                {
                    Instantiate(blocks[1], new Vector3(x,y,0), Quaternion.identity,blocksParent);
                }
                if(groupA[x,y]==2)
                {
                    Instantiate(blocks[2], new Vector3(x,y,0), Quaternion.identity,blocksParent);
                }
            }
    }
//public void BlockReLoad()

/* 
        for(y= 0 ; y < 5; y++)
        for(x= 0 ; x < 5; x++)
        if( x % 2 == 0 )
        Instantiate(blocks[0], new Vector3(x,y,0), Quaternion.identity,blocksParent);
        else
        Instantiate(blocks[1], new Vector3(x,y,0), Quaternion.identity,blocksParent);
        }
        */
	// Update is called once per frame
int  randomNum(int r)
{
return (Random.Range(0,r));
}

}
