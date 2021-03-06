using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private CharacterController _controller;

    private Rigidbody rg;

    float moveSpeed = Constant.movespeed;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 move = - transform.up * x + transform.forward * z;

        //_controller.Move(move * moveSpeed * Time.deltaTime);

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // _controller.Move(move * Time.deltaTime * moveSpeed);
        transform.position = transform.position + move * Time.deltaTime * moveSpeed/4*3;
        //rg.AddForce(move);


    }
}
