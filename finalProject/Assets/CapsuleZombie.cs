using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleZombie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Zombie1")
        {
            Debug.Log("You lose!");
            GameOverMenu.isLose = true;
        }
        if (collision.collider.name == "Zombie1(Clone)")
        {
            Debug.Log("You lose!");
            GameOverMenu.isLose = true;
        }
    }


}
