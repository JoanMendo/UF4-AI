using UnityEngine;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public Blackboard blackboard;
    public NodoBase nodoBase;

    private void Awake()
    {
        // Configuración inicial del Blackboard (se pueden asignar otras propiedades según sea necesario)
        blackboard = GetComponent<Blackboard>();
    }
    void Start()
    {
        nodoBase = new NodoSelector(new List<NodoBase>
        {
            new NodoSecuencial(new List<NodoBase>
            {
                new NodoPatrol(blackboard)

            }),
           
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
