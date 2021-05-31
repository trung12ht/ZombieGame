using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Blink : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imageCooldown;

    public float cooltime = 5;

    public Camera cam;

    public Transform target;

    public float timeSkillE = 0.0f;

    bool isCooldown;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSkillE -= Time.deltaTime;
        if (timeSkillE < 0) {
            if (Input.GetKey(KeyCode.E))
            {   
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);


                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        Debug.Log(hit.point);
                    }
                    if (hit.point.y <= 1)
                    {
                        target.position = new Vector3(hit.point.x, target.position.y, hit.point.z);
                        timeSkillE = 5.0f;
                        
                    }
                }
            }
        }
        
        
    }
}
