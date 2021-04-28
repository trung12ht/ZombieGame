using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnee;
    public Transform target;
    public Camera cam;

    public PlayerBullet playerBullet;
    void Start()
    {
        playerBullet = GameObject.Find("InGameGUI").GetComponent<PlayerBullet>();
    }

    void Awake() // lấy đối tượng
    {
       

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (playerBullet.checkBullet()) // kiem tra con dan hay k
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                GameObject bullet = Instantiate(spawnee, target.position, target.rotation);

                playerBullet.subtractBullet(); // tru 1 vien

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
}
