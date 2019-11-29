using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour {

Test script;
public void Delete()
    {
        Debug.Log ((int)this.transform.position.x +(",") + (int)this.transform.position.y );
        Test.groupA[(int)this.transform.position.x,(int)this.transform.position.y] = 0;
        //Test.ResetBlocks();
        Destroy (this.gameObject);
    }
}