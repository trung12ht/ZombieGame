using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnee;
    public Transform target;
    public Camera cam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            GameObject bullet = Instantiate(spawnee, target.position, target.rotation);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //float speed = 10f;
                //        float step = speed * Time.deltaTime;
               // target.position = Vector3.MoveTowards(target.position, hit.point, step);
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 100000);
            }
        }
    }
}
