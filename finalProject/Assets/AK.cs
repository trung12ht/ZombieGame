using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    public Camera can;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");

       // mousePos = can.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        
       // rb.MovePosititon(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
      //  Vector2 lookDir = mousePos - rb.position;
      //  float angle = Mathf.Atan2(lockDir.y, lockDir.x) * Mathf.Rad2Deg - 90f;
       // rb.rotation = angle;
    }
   
}
