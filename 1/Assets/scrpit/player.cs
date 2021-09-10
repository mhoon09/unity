using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float rotateSpeed;
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

        Vector3 a = new Vector3(h * (-1), 0, v*(-1));

        rigid.velocity = new Vector3(h * speed, rigid.velocity.y, v * speed);

        if (Input.GetButtonDown("Jump") && isjump == false)
        {
            rigid.AddForce(Vector3.up * 17, ForceMode.Impulse);
            isjump = true;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(a), Time.deltaTime * rotateSpeed);



    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "f")
        {
            isjump = false;
        }

        if (c.gameObject.tag == "e")
        {
            transform.position =new Vector3(0, 10, 0);
        }
    }
}
