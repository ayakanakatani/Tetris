﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playfield : MonoBehaviour {

public static int w = 10;
public static int h = 20;
public static Transform[,] grid = new Transform[w,h];

public static Vector2 roundVec2(Vector2 v){
    //Mathf.Round f　に近い整数を返す
    return new Vector2(Mathf.Round(v.x),
                       Mathf.Round(v.y));
}
public static bool insideBorder(Vector2 pos)
{
    return ((int)pos.x >= 0 &&
            (int)pos.x < w &&
            (int)pos.y >= 0);
}
public static void delete(int y)
{
    for(int x = 0; x < w ; ++x)
    {
        Destroy(grid[x , y].gameObject);
        grid[x,y] = null;
        
    }
}
}
