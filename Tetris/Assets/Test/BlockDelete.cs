using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour {
public static int xx;
public static int yy;
Test script;
public void Delete()
    {
        Debug.Log ((int)this.transform.position.x +(",") + (int)this.transform.position.y );
        Destroy (this.gameObject);
        
    }
}