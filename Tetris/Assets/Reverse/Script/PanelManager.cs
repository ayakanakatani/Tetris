using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public static PanelManager Ins;
    public GameObject[] obj_Panels;
    public GameObject[,] field_Panels = new GameObject[5, 5];
    public int[,] field_Num = new int[5, 5];
    void Start()
    {
        Ins = this;
        //パネルを二次元配列に入れなおし
        int x, y;
        int c = 0;
        for (y = 0; y < 5; y++)
            for (x = 0; x < 5; x++)
            {
                field_Panels[x, y] = obj_Panels[c];
                field_Panels[x, y].GetComponent<PanelButton>().x = x;
                field_Panels[x, y].GetComponent<PanelButton>().y = y;
                c += 1;
            }

        //それぞれに0～1の番号ランダムに入れた
        int fx, fy;
        for (fy = 0; fy < 5; fy++)
            for (fx = 0; fx < 5; fx++)
            {
                field_Num[fx, fy] = Random.Range(0, 2);
                field_Panels[fx, fy].GetComponent<PanelButton>().num.text = field_Num[fx, fy].ToString();
            }
        //番号によって色をつける
        int cx, cy;
        for (cy = 0; cy < 5; cy++)
            for (cx = 0; cx < 5; cx++)
            {
                if (field_Num[cx, cy] == 0)
                {
                    field_Panels[cx, cy].GetComponent<Image>().color = Color.red;
                }
                else
                {
                    field_Panels[cx, cy].GetComponent<Image>().color = Color.blue;
                }


            }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void PanelClick(int x, int y)
    {
        if (field_Num[x, y] == 0)
        {
            field_Num[x, y] = 1;
            ChangeBlue(x, y);
        }
        else
        {
            field_Num[x, y] = 0;
            ChangeRed(x, y);
        }
    }
    private void ChangeBlue(int x, int y)
    {
        field_Panels[x, y].GetComponent<Image>().color = Color.blue;
        field_Panels[x, y].GetComponent<PanelButton>().num.text = "1";
    }
    private void ChangeRed(int x, int y)
    {
        field_Panels[x, y].GetComponent<Image>().color = Color.red;
        field_Panels[x, y].GetComponent<PanelButton>().num.text = "0";
    }


}
