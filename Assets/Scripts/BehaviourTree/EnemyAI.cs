using UnityEngine;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public Blackboard blackboard;
    public NodoBase nodoBase;

    private void Awake()
    {
        // Configuraci�n inicial del Blackboard (se pueden asignar otras propiedades seg�n sea necesario)
        blackboard = GetComponent<Blackboard>();
    }
    void Start()
    {
        nodoBase = new NodoSecuencial(new List<NodoBase> 
        {
            new NodoValidateStart(blackboard),
            new NodoSelector(new List<NodoBase>
            {
                new NodoSelector(new List<NodoBase>
                {
                    new NodoChase(blackboard),
                    new NodoHuir(blackboard)

                }),
                new NodoSecuencial(new List<NodoBase>
                {
                    //new NodoArrivedDestination(blackboard),
                    new NodoPatrol(blackboard)

                })

        })});
    }
    void Update()
    {
        nodoBase.ExecuteNode();
    }

}
