using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerUI : MonoBehaviour
{
    // Start is called before the first frame update
    // init variable
    public float timeRemaining = 60;
    public Text timer;
    public Text preTimer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = 120;
            preTimer.text = "     Survival to win: ";
        }
        timer.text = timeRemaining.ToString();
    }
}
