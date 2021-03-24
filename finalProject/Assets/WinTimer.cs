using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTimer : MonoBehaviour
{

    public GameObject gameWin;

    public static bool isWin;

    // Start is called before the first frame update
    void Start()
    {
        gameWin.SetActive(false);
        startGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWin)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        gameWin.SetActive(true);
        Time.timeScale = 0f;
        isWin = true;
    }

    public void startGame()
    {
        gameWin.SetActive(false);
        Time.timeScale = 1f;
        isWin = false;
    }

}
