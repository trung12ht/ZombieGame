using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bullet;

    public float speed = 40f;

    public Vector3 fire;
    // Start is called before the first frame update
   void Start()
    {
       // bullet.AddComponent<Rigidbody>();
        fire = new Vector3(-13.414f, 1.06f, 0.548f);
    }
// Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
         GameObject b = Instantiate(bullet, fire, Quaternion.identity) as GameObject;

          Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //GameObject r = Instantiate(bullet);
       rb.AddForce(Vector3.forward * speed);
    }

}

