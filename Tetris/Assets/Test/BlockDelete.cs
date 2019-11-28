using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour {
public GameObject obj;

public void Delete()
    {
        Destroy(obj);
    }
	
}
