using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
public GameObject[] blocks; 
private static int blockMax = 3;
public static int x;
public static int y ;
public static int [,] groupA　= new int [blockMax,blockMax];
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
                    Instantiate(blocks[0], new Vector3(x,y,0), Quaternion.identity);
                }
                if(groupA[x,y]==1)
                {
                    Instantiate(blocks[1], new Vector3(x,y,0), Quaternion.identity);
                }
                if(groupA[x,y]==2)
                {
                    Instantiate(blocks[2], new Vector3(x,y,0), Quaternion.identity);
                }
            }
    }
/* 
public static void BlockReset(GameObject blockPrefab)
{
    int xx ;
    int yy ;
for(yy= 0 ; yy < 5; yy++)
for(xx= 0 ; xx < 5; xx++)
            {
                if(groupA[xx,yy]==0)
                {
                    Instantiate(blockPrefab[0], new Vector3(xx,yy,0), Quaternion.identity,blocksParent);
                }
                if(groupA[xx,yy]==1)
                {
                    Instantiate(blockPrefab[1], new Vector3(xx,yy,0), Quaternion.identity,blocksParent);
                }
                if(groupA[xx,yy]==2)
                {
                    Instantiate(blockPrefab[2], new Vector3(xx,yy,0), Quaternion.identity,blocksParent);
                }
            }
}
*/
int  randomNum(int r)
{
return (Random.Range(0,r));
}

}
