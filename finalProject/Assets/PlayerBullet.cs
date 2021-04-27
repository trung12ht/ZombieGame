using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// lop hiển thị số đạn còn lại
public class PlayerBullet : MonoBehaviour
{  // Start is called before the first frame update
    // init variable
    public float bulletPlayer = 50; //  mặc định đạn 50

    public Text numberOfBullet;
   
    public void Start()
    {

    }

    // Update is called once per frame
    public bool checkBullet() // kiểm tra số đạn mới cho bắn
    {
        if (bulletPlayer > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void addBullet()  //  nhặn 1 hộp đạn thêm 50 viên
    {

        bulletPlayer =bulletPlayer + 50;
        numberOfBullet.text = bulletPlayer.ToString();
    }
    public void subtractBullet() //  băn 1 viên trừ 1
    {
        bulletPlayer = bulletPlayer - 1;
        numberOfBullet.text = bulletPlayer.ToString();
    }
}
