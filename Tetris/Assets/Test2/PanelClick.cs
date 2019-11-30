using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClick : MonoBehaviour {

public void Click()
    {
        Debug.Log(this.transform.position.x +"," + this.transform.position.y);
        Test2.panelG[(int)this.transform.position.x, (int)this.transform.position.y] = 99;
    }
}