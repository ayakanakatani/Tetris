using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour {
public GameObject[] blocks; 
Test script;
public void Delete()
    {
        Test.groupA[(int)this.transform.position.x,(int)this.transform.position.y] = 0;

int xx ;
int yy ;
for(yy= 0 ; yy < 5; yy++)
for(xx= 0 ; xx < 5; xx++)
            {
                if(Test.groupA[xx,yy]==0)
                {
                    Instantiate(blocks[0], new Vector3(xx,yy,0), Quaternion.identity);
                }
                if(Test.groupA[xx,yy]==1)
                {
                    Instantiate(blocks[1], new Vector3(xx,yy,0), Quaternion.identity);
                }
                if(Test.groupA[xx,yy]==2)
                {
                    Instantiate(blocks[2], new Vector3(xx,yy,0), Quaternion.identity);
                }
            }

        Destroy (this.gameObject);
    }
}