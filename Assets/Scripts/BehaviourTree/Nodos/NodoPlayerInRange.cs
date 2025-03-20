using UnityEngine;

public class NodoPlayerInRange : NodoBase
{
    private Blackboard blackboard;

    public NodoPlayerInRange(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {


        
        if (blackboard.playerInSight)
        {
            blackboard.agent.SetDestination(blackboard.player.transform.position);
            blackboard.arrivedToDestination = false;
            return EstadosNodo.NodoCorrecto;
        }

        return EstadosNodo.NodoEjecutandose;
    }
}

