using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imageE;
    public Image imageQ;
    public float cooltime = 5;
    bool isCooldownE ;
    bool isCooldownQ ;

    // Update is called once per frame
    void Start()
    {
        imageE.fillAmount = 0;
        imageQ.fillAmount = 0;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                isCooldownE = true;
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {

            if (Input.GetMouseButtonDown(0))
            {
                isCooldownQ = true;
            }
        }

        if (isCooldownE)
        {
            imageE.fillAmount += 1 / cooltime * Time.deltaTime;
            if (imageE.fillAmount >= 1)
            {
                imageE.fillAmount = 0;
                isCooldownE = false;
            }

        }

        if (isCooldownQ)
        {
            imageQ.fillAmount += 1 / cooltime * Time.deltaTime;
            if (imageQ.fillAmount >= 1)
            {
                imageQ.fillAmount = 0;
                isCooldownQ = false;
            }

        }
    }
}
