using UnityEngine;

public class NodoPatrol : NodoBase
{
    private Blackboard blackboard;

    public NodoPatrol(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {

        if (blackboard.arrivedToDestination)
        {
            Debug.Log("Arrived to destination");
            blackboard.lastWaypointIndex = (blackboard.lastWaypointIndex + 1) % blackboard.WaypointsList.Count;
            blackboard.agent.SetDestination(blackboard.WaypointsList[(int)blackboard.lastWaypointIndex].transform.position);
            blackboard.arrivedToDestination = false;
            return EstadosNodo.NodoCorrecto;
        }      
        return EstadosNodo.NodoEjecutandose;

    }
}
