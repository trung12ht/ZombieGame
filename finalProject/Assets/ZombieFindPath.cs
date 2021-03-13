using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieFindPath : MonoBehaviour
{

    public NavMeshAgent nm;

    public Transform target;

    int interval = 1;

    float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= nextTime)
        {

            nm.SetDestination(target.position);

            nextTime += interval;

        }

        float velocity = nm.velocity.magnitude / nm.speed;

        if (velocity <= 0.5f) {
            nm.SetDestination(target.position);
        }

    }
}
