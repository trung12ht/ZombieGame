using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttletColider : MonoBehaviour
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
        Debug.Log("shoot");
        Destroy(this.gameObject);
        if (collision.collider.name == "Pet")
        {
        }
    }

}
