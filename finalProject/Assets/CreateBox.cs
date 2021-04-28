using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreateBox : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;

    private bool onUseTp = false;

    public GameObject spawnee;

    public Transform target;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
                    Instantiate(spawnee, hit.point, transform.rotation);
                }

            }
        }
    }
}