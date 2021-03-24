using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverTime : MonoBehaviour
{
    // Start is called before the first frame update
    // init variable
    public float timeRemaining = -60;
    public Text timer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime;
        timer.text = timeRemaining.ToString();
    }
}
