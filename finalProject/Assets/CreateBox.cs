﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreateBox : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;

    public GameObject Cube;

    public Transform target;

    public float timeSkillQ = 0.0f;



    // Update is called once per frame
    void Update()
    {
        timeSkillQ -= Time.deltaTime;
        if (timeSkillQ < 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);


                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        Debug.Log(hit.point);
                        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube.transform.position = new Vector3(hit.point.x, target.position.y, hit.point.z);
                        timeSkillQ = 5.0f;
                    }

                }
            }
        }
    }
}