using System.Collections.Generic;
using UnityEngine;

public class NodoSecuencial : NodoBase
{
    public List<NodoBase> nodosHijos = new List<NodoBase>();

    public NodoSecuencial(List<NodoBase> nodosHijos)
    {
        this.nodosHijos = nodosHijos;
    }

    public override EstadosNodo ExecuteNode()
    {
        foreach (NodoBase nodo in nodosHijos)
        {
            switch (nodo.ExecuteNode())
            {
                case EstadosNodo.NodoRo�oso:
                    return EstadosNodo.NodoRo�oso;
                case EstadosNodo.NodoEjecutandose:
                    return EstadosNodo.NodoEjecutandose;
                case EstadosNodo.NodoCorrecto:
                    continue;
            }
        }
        return EstadosNodo.NodoCorrecto;
    }
}
