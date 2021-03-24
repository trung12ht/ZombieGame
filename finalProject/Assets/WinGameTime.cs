using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinGameTime : MonoBehaviour
{
    // Start is called before the first frame update
    // init variable
    public float timeRemaining = -10;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime;
        if (timeRemaining>0)
        {
            WinTimer.isWin = true;
        }
    }
}
