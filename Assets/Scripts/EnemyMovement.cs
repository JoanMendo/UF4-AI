using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;


public class EnemyMovementPath : MonoBehaviour
{

    public GameObject initialWaypoints;
   
    private List<Transform> waypoints = new List<Transform>();
    private NavMeshAgent agent;
    private int currentWaypointIndex = 0;
    void Start()
    {
        foreach (Transform child in initialWaypoints.transform)
        {
            waypoints.Add(child);
        }
        agent = GetComponent<NavMeshAgent>();

        if (waypoints.Count > 0)
        {
            agent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextWaypoint();
        }
    }

    void GoToNextWaypoint()
    {
        if (waypoints.Count == 0)
            return;

        // Avanza al siguiente punto
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
        agent.SetDestination(waypoints[currentWaypointIndex].position);
    }
}
