using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject e1;
    int RandomX;
    int RandomY;
    int RandomZ;
    float timer;

    void Awake()
    {

    }

    void Update()
    {
        RandomX = UnityEngine.Random.Range(-20, 20);
        RandomZ = UnityEngine.Random.Range(-20, 20);
        RandomY = UnityEngine.Random.Range(-12, 12);

        Vector3 rspawn = new Vector3(RandomX, RandomY, RandomZ);

        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            Instantiate(e1, rspawn, Quaternion.identity);
            timer = UnityEngine.Random.Range(1, 5);
        }

    }
}

