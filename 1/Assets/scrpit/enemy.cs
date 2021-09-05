using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public Transform target;
    NavMeshAgent n;
    void Awake()
    {
        n = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        n.SetDestination(target.position);
    }

}
