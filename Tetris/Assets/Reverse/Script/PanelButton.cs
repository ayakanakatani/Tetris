﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelButton : MonoBehaviour
{
    public Text num;
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClickPanel()
    {
        PanelManager.Ins.PanelClick(x, y);
    }

}
