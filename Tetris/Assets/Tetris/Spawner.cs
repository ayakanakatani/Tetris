using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] groups;

    public void spawnNext()
    {
        //Rangeは、配列から呼び出す関数らしい
        int i = Random.Range(0, groups.Length -1);
        // Spawn Group at current Position
        Instantiate(groups[i],
        transform.position,
        //回転を決めているらしい
        Quaternion.identity);

    }
    
    int a = Random.Range(0,2) ;

    void Start()
     {
        spawnNext();
    }
}
