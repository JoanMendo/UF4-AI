using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class Blackboard : MonoBehaviour
{

    public float health;
    public float maxHealth;
    public GameObject startingWaypoints;
    public GameObject player;

    public bool playerInSight = false;
    public bool arrivedToDestination = false;
    public float lastWaypointIndex = 0;
    public Transform lastPosition;
    public GameObject self;
    public List<GameObject> WaypointsList = new List<GameObject>();
    public NavMeshAgent agent;

    private void Awake()
    {
        lastPosition = transform;
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        self = gameObject;
        foreach (Transform child in startingWaypoints.transform)
        {
            WaypointsList.Add(child.gameObject);
        }
        agent = GetComponent<NavMeshAgent>();

    }
}
