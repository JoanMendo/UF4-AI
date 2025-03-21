using UnityEngine;

public class NodoChase : NodoBase
{
    private Blackboard blackboard;

    public NodoChase(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {


         if (blackboard.playerInSight && blackboard.health >= (blackboard.maxHealth/2))
         {
            blackboard.agent.SetDestination(blackboard.player.transform.position);
            return EstadosNodo.NodoCorrecto;
         }
 
        return EstadosNodo.NodoEjecutandose;

    }
}
