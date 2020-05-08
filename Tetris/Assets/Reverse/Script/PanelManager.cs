using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject[] obj_Panels;
    public GameObject[,] field_Panels = new GameObject[5, 5];
    // Use this for initialization
    void Start()
    {
        //パネルを二次元配列に入れなおし
        int x, y;
        int c = 0;
        for (y = 0; y < 5; y++)
            for (x = 0; x < 5; x++)
            {
                field_Panels[x, y] = obj_Panels[c];
                c += 1;
            }
        Debug.Log(field_Panels[3, 3].gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
