using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    // El NavMeshAgent que controla al personaje
    public NavMeshAgent agent;

    // Raycast de la c�mara
    Camera mainCamera;



    void Start()
    {
        // Obt�n la referencia de la c�mara principal
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Detectar clic del rat�n
        if (Input.GetMouseButtonDown(0))
        {
            // Llamar a la funci�n para mover al personaje
            MoveCharacterToClickPosition();
        }
    }

    void MoveCharacterToClickPosition()
    {
        // Lanzamos un rayo desde la c�mara a la posici�n del rat�n en el espacio 3D
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Comprobamos si el rayo golpea el suelo o una superficie v�lida
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // Comprobar si la posici�n es v�lida en el NavMesh
            NavMeshHit navMeshHit;
            if (NavMesh.SamplePosition(hit.point, out navMeshHit, 1.0f, NavMesh.AllAreas))
            {
                // Mover al agente a la posici�n v�lida en el NavMesh
                agent.SetDestination(navMeshHit.position);
            }
        }
    }
}