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

        //それぞれに番号ランダムに入れた
        int fx, fy;
        for (fy = 0; fy < fieldY; fy++)
            for (fx = 0; fx < fieldX; fx++)
            {
                field_Num[fx, fy] = Random.Range(1, 4);
                field_Panels[fx, fy].GetComponent<PuzzleButton>().num.text = field_Num[fx, fy].ToString();
            }
        ColorChange();
    }
    // Update is called once per frame
    void Update()
    {

    }
    //パネルが押されたときの処理（パネルプレハブから呼び出してる
    public void PanelClick(int x, int y)
    {
        PanelClickChangeCheck(x, y);
        Panel0Check();
        //NewPanel();
        //ColorChange();
    }



    public void PanelClickChangeCheck(int x, int y)
    {
        ChangePanelNum(x, y);
        Color thisColor = field_Panels[x, y].GetComponent<Image>().color;
        if ((x + 1) < fieldX)
            if (field_Panels[x + 1, y].GetComponent<Image>().color == thisColor && !(field_Num[x + 1, y] == 0))
            {
                int x2 = x + 1;
                ChangePanelNum(x2, y);
                PanelClickChangeCheck(x2, y);
            }


        if ((x - 1) > -1)
            if (field_Panels[x - 1, y].GetComponent<Image>().color == thisColor && !(field_Num[x - 1, y] == 0))
            {
                int x2 = x - 1;
                ChangePanelNum(x2, y);
                PanelClickChangeCheck(x2, y);
            }


        if ((y + 1) < fieldY)
            if (field_Panels[x, y + 1].GetComponent<Image>().color == thisColor && !(field_Num[x, y + 1] == 0))
            {
                int y2 = y + 1;
                ChangePanelNum(x, y2);
                PanelClickChangeCheck(x, y2);
            }


        if ((y - 1) > -1)
            if (field_Panels[x, y - 1].GetComponent<Image>().color == thisColor && !(field_Num[x, y - 1] == 0))
            {
                int y2 = y - 1;
                ChangePanelNum(x, y2);
                PanelClickChangeCheck(x, y2);
            }

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
    private void ChangePanelNum(int x, int y)
    {
        field_Num[x, y] = 0;
        field_Panels[x, y].GetComponent<PuzzleButton>().num.text = "0";

    }
    //番号によって色をつける
    void ColorChange()
    {
        int cx, cy;
        for (cy = 0; cy < fieldY; cy++)
            for (cx = 0; cx < fieldX; cx++)
            {
                field_Panels[cx, cy].GetComponent<Image>().color = color[field_Num[cx, cy]];

            }
    }
    void Panel0Check()
    {
        int i;
        for (i = 0; i < fieldY; i++)
        {
            StartCoroutine(WaitDown(0.5f));
        }


    }

    IEnumerator PanelDown(float waitTime, int x, int y)
    {
        yield return new WaitForSeconds(waitTime);
        if (field_Num[x, y] == 0 && y + 1 < fieldY)
        {
            field_Num[x, y] = field_Num[x, y + 1];
            field_Num[x, y + 1] = 0;
            field_Panels[x, y + 1].GetComponent<PuzzleButton>().num.text = "0";
            field_Panels[x, y].GetComponent<PuzzleButton>().num.text = field_Num[x, y].ToString();
            int y2 = y + 1;
            ColorChange();
            StartCoroutine(PanelDown(0.2f, x, y2));

            //StartCoroutine(WaitDown(3f, x, y2));
        }

    }

    void NewPanel()
    {
        int fx, fy;
        for (fy = 0; fy < fieldY; fy++)
            for (fx = 0; fx < fieldX; fx++)
            {
                if (field_Num[fx, fy] == 0)
                {
                    field_Num[fx, fy] = Random.Range(1, 4);
                    field_Panels[fx, fy].GetComponent<PuzzleButton>().num.text = field_Num[fx, fy].ToString();
                }

            }
    }
    IEnumerator WaitDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        int x, y;
        for (y = 0; y < fieldY; y++)
            for (x = 0; x < fieldX; x++)
            {
                if (field_Num[x, y] == 0)
                {
                    StartCoroutine(PanelDown(0.1f, x, y));
                }

            }

    }
}
