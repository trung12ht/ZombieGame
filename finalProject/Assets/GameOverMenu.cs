using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOverMenu;

    public static bool isLose;

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
        startGame();
    }

    // Update is called once per frame
    void Update()
    {
            if (isLose)
            {
                LoseGame();
            }
    }

    public void LoseGame()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        isLose = true;
    }

    public void startGame()
    {
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        isLose = false;
    }

}
