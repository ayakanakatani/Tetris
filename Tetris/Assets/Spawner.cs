using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] groups;
    {
        public void spawnNext() {
            //Rangesは、配列から呼び出す関数らしい
            int i = Random.Range(0, groups.Length);
            // Spawn Group at current Position
            Instantiate(groups[i],
            transform.position,
            //回転を決めているらしい
            Quaternion.identity);

        }
    }

}
