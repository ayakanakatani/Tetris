using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject[] obj_Panels;
    public GameObject[,] field_Panels = new GameObject[5, 5];
    public int[,] field_Num = new int[5, 5];
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


        int fx, fy;
        for (fy = 0; fy < 5; fy++)
            for (fx = 0; fx < 5; fx++)
            {
                field_Num[fx, fy] = Random.Range(0, 2);
                field_Panels[fx, fy].GetComponent<PanelButton>().num.text = field_Num[fx, fy].ToString();
            }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
