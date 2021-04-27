using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;

    public Transform target;

    private bool onUseTp = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E)){
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);


                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.point);
                }
                if (hit.point.y <= 0.5)
                {
                    target.position = new Vector3(hit.point.x, target.position.y, hit.point.z);

                }
            }
        }
        
    }
}
