using UnityEngine;

public abstract class NodoBase : MonoBehaviour
{
    public abstract EstadosNodo ExecuteNode();
}

public enum EstadosNodo
{
    NodoCorrecto,
    NodoRoñoso,
    NodoEjecutandose
}
