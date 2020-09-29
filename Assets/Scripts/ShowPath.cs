using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShowPath : MonoBehaviour
{
    public NavMeshAgent agent;
    public NavMeshAgent agent2;
    public NavMeshAgent agent3;

    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.positionCount = agent.path.corners.Length;
        lr.SetPositions(agent.path.corners);
        lr.positionCount = agent2.path.corners.Length;
        lr.SetPositions(agent2.path.corners);
        lr.positionCount = agent3.path.corners.Length;
        lr.SetPositions(agent3.path.corners);
    }
}