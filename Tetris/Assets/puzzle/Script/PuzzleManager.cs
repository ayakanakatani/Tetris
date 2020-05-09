using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public int fieldX;
    public int fieldY;
    public static PuzzleManager Ins;
    //public GameObject[] obj_Panels;
    public GameObject[,] field_Panels;
    public int[,] field_Num;
    public Color[] color;
    public GameObject pfPanel;
    public Transform objParent;
    public GridLayoutGroup grid;



    void Start()

    {
        Ins = this;


        grid.constraintCount = fieldX;
        //配列用意
        field_Panels = new GameObject[fieldX, fieldY];
        field_Num = new int[fieldX, fieldY];

        //パネルを生成して二次配列に入れたい
        int x, y;
        int c = 0;
        for (y = 0; y < fieldY; y++)
            for (x = 0; x < fieldX; x++)
            {
                //プレハブ生成して0、0座標に置いた
                GameObject thisPf = Instantiate(pfPanel, objParent);
                thisPf.transform.localPosition = new Vector2(0.0f, 0.0f);
                field_Panels[x, y] = thisPf;
                //プレハブのxとyに配列内の場所を示す数字を入れた
                field_Panels[x, y].GetComponent<PuzzleButton>().x = x;
                field_Panels[x, y].GetComponent<PuzzleButton>().y = y;
                c += 1;
            }

        //それぞれに0～1の番号ランダムに入れた
        int fx, fy;
        for (fy = 0; fy < fieldY; fy++)
            for (fx = 0; fx < fieldX; fx++)
            {
                field_Num[fx, fy] = Random.Range(1, 4);
                field_Panels[fx, fy].GetComponent<PuzzleButton>().num.text = field_Num[fx, fy].ToString();
            }
        //番号によって色をつける
        int cx, cy;
        for (cy = 0; cy < fieldY; cy++)
            for (cx = 0; cx < fieldX; cx++)
            {
                field_Panels[cx, cy].GetComponent<Image>().color = color[field_Num[cx, cy]];

            }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void PanelClick(int x, int y)
    {
        Color thisColor = field_Panels[x, y].GetComponent<Image>().color;
        ChangePanel(x, y);
        if ((x + 1) < fieldX)
            if (field_Panels[x + 1, y].GetComponent<Image>().color == thisColor)
                ChangePanel(x + 1, y);

        if ((x - 1) > -1)
            if (field_Panels[x - 1, y].GetComponent<Image>().color == thisColor)
                ChangePanel(x - 1, y);

        if ((y + 1) < fieldY)
            if (field_Panels[x, y + 1].GetComponent<Image>().color == thisColor)
                ChangePanel(x, y + 1);

        if ((y - 1) > -1)
            if (field_Panels[x, y - 1].GetComponent<Image>().color == thisColor)
                ChangePanel(x, y - 1);

    }
    private void Changecolor(int cx, int cy)
    {
        field_Panels[cx, cy].GetComponent<PuzzleButton>().num.text = field_Num[cx, cy].ToString();
        if (field_Num[cx, cy] == 1)
        {
            field_Panels[cx, cy].GetComponent<Image>().color = color[1];
        }
        else if (field_Num[cx, cy] == 2)
        {
            field_Panels[cx, cy].GetComponent<Image>().color = color[2];
        }
        else
        {
            field_Panels[cx, cy].GetComponent<Image>().color = color[0];
        }
    }
    private void ChangePanel(int x, int y)
    {
        field_Num[x, y] = 0;
        Changecolor(x, y);

    }

}
