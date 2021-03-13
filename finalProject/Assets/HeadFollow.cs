using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = Constant.smoothSpeed;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        Vector3 rs = target.position;
        rs.y = 2.6f;
        transform.position = rs + offset;
    }
}
