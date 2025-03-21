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
            return EstadosNodo.NodoRoņoso;
        }

        if (blackboard.startingWaypoints == null)
        {
            return EstadosNodo.NodoRoņoso;
        }

        if (blackboard.player == null)
        {
            return EstadosNodo.NodoRoņoso;
        }

        return EstadosNodo.NodoCorrecto;
    }
}
