using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{

	Vector3 rot = Vector3.zero;
	float rotSpeed = 40f;
	Animator anim;
	Vector3 mLastPosition;
	float timeScroll = 5f;
	bool isScroll = false;

	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
		gameObject.transform.eulerAngles = rot;
	}

	// Update is called once per frame
	void Update()
	{
		//CheckKey();
		//gameObject.transform.eulerAngles = rot;

		float speed = (transform.position - mLastPosition).magnitude;
		mLastPosition = transform.position;

		timeScroll -= 0.002f;

		if (timeScroll <= 0)
        {
			isScroll = !isScroll;
			
			anim.SetBool("Roll_Anim", isScroll);
			timeScroll = Random.Range(0f, 10f);
			if (isScroll == true) timeScroll = Random.Range(0f, 5f);
		}

		if (speed>0)
        {
			anim.SetBool("Walk_Anim", true);
			//rot[1] += rotSpeed * Time.fixedDeltaTime;
		} else
        {
			anim.SetBool("Walk_Anim", false);
		}
	}

	void CheckKey()
	{
		// Walk
		if (Input.GetKey(KeyCode.W))
		{
			anim.SetBool("Walk_Anim", true);
		}
		else if (Input.GetKeyUp(KeyCode.W))
		{
			anim.SetBool("Walk_Anim", false);
		}

		// Rotate Left
		if (Input.GetKey(KeyCode.A))
		{
			rot[1] -= rotSpeed * Time.fixedDeltaTime;
		}

		// Rotate Right
		if (Input.GetKey(KeyCode.D))
		{
			rot[1] += rotSpeed * Time.fixedDeltaTime;
		}

		// Roll
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (anim.GetBool("Roll_Anim"))
			{
				anim.SetBool("Roll_Anim", false);
			}
			else
			{
				anim.SetBool("Roll_Anim", true);
			}
		}

		// Close
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			if (!anim.GetBool("Open_Anim"))
			{
				anim.SetBool("Open_Anim", true);
			}
			else
			{
				anim.SetBool("Open_Anim", false);
			}
		}
	}

}
