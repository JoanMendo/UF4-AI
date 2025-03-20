using UnityEngine;

public class NodoValidateStart : NodoBase
{

    private Blackboard blackboard;

    public NodoValidateStart(Blackboard blackboard)
    {
        this.blackboard = blackboard;
    }
    public override EstadosNodo ExecuteNode()
    {
        if (blackboard.agent == null)
        {
            return EstadosNodo.NodoRoñoso;
        }

        if (blackboard.startingWaypoints == null)
        {
            return EstadosNodo.NodoRoñoso;
        }

        if (blackboard.player == null)
        {
            return EstadosNodo.NodoRoñoso;
        }

        return EstadosNodo.NodoCorrecto;
    }
}
