using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {
    static int panelMax = 5;
    public GameObject [] panelPf;
    public Transform panelParent;
    public static int[,] panelG = new int[panelMax, panelMax];
    public static int x;
    public static int y;

    // Use this for initialization
    void Start () 
    {
        int[,] panelG = new int[panelMax, panelMax];
        for (x = 0; x < panelMax; x++)
            for (y = 0; y < panelMax; y++)
            {
                panelG[x, y] = randomNum(3);
                Instantiate(panelPf[0], new Vector3(x, y, 0), Quaternion.identity,panelParent);
                
               /* if (panelG[x, y] == 0)
                {
                    Instantiate(panelPf[1], new Vector3(x, y, 0), Quaternion.identity);
                }
                if (panelG[x, y] == 1)
                {
                    Instantiate(panelPf[2], new Vector3(x, y, 0), Quaternion.identity);
                }
                if (panelG[x, y] == 2)
                {
                    Instantiate(panelPf[3], new Vector3(x, y, 0), Quaternion.identity);
                }
              */
            
            }
        Debug.Log(panelG[0,0]);
		Debug.Log(panelG[0,1]);
		Debug.Log(panelG[0,2]);
	}
	// Update is called once per frame

    int randomNum(int r)
    {
        return (Random.Range(0, r));
    }
}
