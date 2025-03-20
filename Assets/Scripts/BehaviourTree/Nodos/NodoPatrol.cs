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


        if (!blackboard.agent.hasPath)
        {
            blackboard.agent.SetDestination(blackboard.WaypointsList[(int)blackboard.lastWaypointIndex].transform.position);
            return EstadosNodo.NodoCorrecto;
        }

        else if (blackboard.arrivedToDestination)
        {
            blackboard.lastWaypointIndex = (blackboard.lastWaypointIndex + 1) % blackboard.WaypointsList.Count;
            blackboard.agent.SetDestination(blackboard.WaypointsList[(int)blackboard.lastWaypointIndex].transform.position);
            blackboard.arrivedToDestination = false;
            return EstadosNodo.NodoCorrecto;
        }
        return EstadosNodo.NodoEjecutandose;

    }
}
