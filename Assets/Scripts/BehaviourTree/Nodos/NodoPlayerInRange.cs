using UnityEngine;
using UnityEngine.AI;

public class NodoPlayerInRange : NodoBase
{
    private Blackboard blackboard;

    public NodoPlayerInRange(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {



        NavMeshHit hit;

        if (NavMesh.SamplePosition(blackboard.player.transform.position, out hit, 1.0f, NavMesh.AllAreas))
        {
            blackboard.playerInSight = true;
            return EstadosNodo.NodoCorrecto;
        }

        return EstadosNodo.NodoRoñoso;
    }
}

