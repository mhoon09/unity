using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    bool isjump;
    public float speed;
    Rigidbody rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //플래이어 이동
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        rigid.velocity = new Vector3(h * speed, rigid.velocity.y, v * speed);

        if (Input.GetButtonDown("Jump") && isjump == false)
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isjump = true;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "f")
        {
            isjump = false;
        }
    }
}
