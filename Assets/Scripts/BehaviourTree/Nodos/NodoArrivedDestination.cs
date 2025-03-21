using UnityEngine;

public class NodoArrivedDestination : NodoBase
{
    private Blackboard blackboard;

    public NodoArrivedDestination(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {

        if (!blackboard.agent.pathPending && blackboard.agent.remainingDistance < 0.5f)
        {
            blackboard.arrivedToDestination = true;
            return EstadosNodo.NodoCorrecto;
        }
        return EstadosNodo.NodoRoñoso;
    }
}
