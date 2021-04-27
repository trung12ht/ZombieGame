using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBox : MonoBehaviour
{
    public Transform bulletBox;
    public int location;
    public PlayerBullet bullet;
    // location ban dau  -5,0,0
    // Start is called before the first frame update
    public PlayerBullet playerBullet; // khởi tạo đối tượng
   
    void Start()
    {
        location = 1; // co  3 vi tri xuat hien hop dan
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   


    void Awake()
    {
        playerBullet = GetComponent<PlayerBullet>(); // lấy đối tượng
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            if(location == 1)
            {
                bulletBox.position = bulletBox.position + new Vector3(-75f, 0f, 25f); // -80 0 25
                location = 2;
                // can goi ham addbullet

                // them dan
                playerBullet.addBullet();
            }
            else if( location == 2)
            {
                bulletBox.position =bulletBox.position +  new Vector3(-40f, 0f, 15f); // -120 0 40
                location = 3;

            }else if (location == 3)
            {
                bulletBox.position += new Vector3(115f, 0f, -40f);//-5 0 0
                location = 1;
            }
           
            
        }
    }
}
