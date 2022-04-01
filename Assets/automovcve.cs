using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class automovcve : MonoBehaviour
{
    public transform target;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
