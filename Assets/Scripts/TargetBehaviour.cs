using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 new_location = new Vector3();

        new_location.x = Random.Range(-11f, -37f);
        new_location.z = Random.Range(-6f, -16f);
        new_location.y = Terrain.activeTerrain.SampleHeight(new_location);

        transform.position = new_location;
        // update agent's destination
        agent.SetDestination(transform.position);

    }
}