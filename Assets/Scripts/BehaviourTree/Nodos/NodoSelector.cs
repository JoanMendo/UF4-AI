using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class NodoSelector : NodoBase
{
    public List<NodoBase> nodosHijos = new List<NodoBase>();

    public NodoSelector(List<NodoBase> nodosHijos)
    {
        this.nodosHijos = nodosHijos;
    }

    public override EstadosNodo ExecuteNode()
    {
        foreach (NodoBase nodo in nodosHijos)
        {
            switch (nodo.ExecuteNode())
            {
                case EstadosNodo.NodoCorrecto:
                    return EstadosNodo.NodoCorrecto;
                case EstadosNodo.NodoEjecutandose:
                    return EstadosNodo.NodoEjecutandose;
                case EstadosNodo.NodoRoñoso:
                    continue;
            }
        }
        return EstadosNodo.NodoRoñoso;
    }
}
