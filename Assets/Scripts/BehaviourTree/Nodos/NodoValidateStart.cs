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
            return EstadosNodo.NodoRo�oso;
        }

        if (blackboard.startingWaypoints == null)
        {
            return EstadosNodo.NodoRo�oso;
        }

        if (blackboard.player == null)
        {
            return EstadosNodo.NodoRo�oso;
        }

        return EstadosNodo.NodoCorrecto;
    }
}
