using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    // El NavMeshAgent que controla al personaje
    public NavMeshAgent agent;

    // Raycast de la cámara
    Camera mainCamera;



    void Start()
    {
        // Obtén la referencia de la cámara principal
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Detectar clic del ratón
        if (Input.GetMouseButtonDown(0))
        {
            // Llamar a la función para mover al personaje
            MoveCharacterToClickPosition();
        }
    }

    void MoveCharacterToClickPosition()
    {
        // Lanzamos un rayo desde la cámara a la posición del ratón en el espacio 3D
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Comprobamos si el rayo golpea el suelo o una superficie válida
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // Comprobar si la posición es válida en el NavMesh
            NavMeshHit navMeshHit;
            if (NavMesh.SamplePosition(hit.point, out navMeshHit, 1.0f, NavMesh.AllAreas))
            {
                // Mover al agente a la posición válida en el NavMesh
                agent.SetDestination(navMeshHit.position);
            }
        }
    }
}