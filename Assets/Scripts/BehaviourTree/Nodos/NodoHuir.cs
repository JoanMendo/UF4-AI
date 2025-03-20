using UnityEngine;
using UnityEngine.AI;

public class NodoHuir : NodoBase
{
    private Blackboard blackboard;

    public NodoHuir(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {


        if (blackboard.health < blackboard.maxHealth/2 && blackboard.playerInSight )
        {
            NavMeshPath path = new NavMeshPath();
            float distance = Mathf.Infinity;
            GameObject furthestPoint = new GameObject();
            foreach (GameObject waypoint in blackboard.WaypointsList)
            {
                NavMesh.CalculatePath(blackboard.self.transform.position, waypoint.transform.position, NavMesh.AllAreas, path);
                if (path.corners.Length < distance)
                {
                    distance = path.corners.Length;
                    furthestPoint = waypoint;
                }
            }
            blackboard.agent.SetDestination(furthestPoint.transform.position);
            blackboard.arrivedToDestination = false;
            return EstadosNodo.NodoCorrecto;
        }
        
        return EstadosNodo.NodoEjecutandose;


    }
}
